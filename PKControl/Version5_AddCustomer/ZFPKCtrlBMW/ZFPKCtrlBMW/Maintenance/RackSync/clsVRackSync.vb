Imports System.IO
Imports System.Data
Imports ZFPKCtrlBMW.Barcode_System
Imports System.Windows.Forms

Public Class clsVRackSync
    Private InterfacePath As String = ""
    Private TransOK As Boolean = False

#Region "Program Active"

    Private Sub clsVRackSync_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If TimeSync.Enabled = True Then TimeSync.Enabled = False
        Dim filesTrn() As String = Directory.GetFiles(InterfacePath & "\Trans")
        For i As Integer = 0 To filesTrn.Length - 1
            Try
                File.Delete(filesTrn(i))
            Catch ex As Exception
                'ถ้าลบไม่ได้ก็ไม่เป็นไร
            End Try
        Next
    End Sub
    Private Sub clsVRackSync_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnExit.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVRackSync_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
#End Region

#Region "Call Function"
    Private Sub ExitClick()
        Me.Close()
    End Sub
#End Region

    Private Sub clsVRackSync_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblZF.Text = ""
        lblBMW.Text = ""
        lblOntruck.Text = ""
        lblSuplier.Text = ""
        lblExtWH.Text = ""
        lblFG.Text = ""
        lblRepairInZF.Text = ""

        btnExit.Enabled = False

        TimeSync.Enabled = False
        InterfacePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName().CodeBase) & "\Interface\"


        Dim filesTrn() As String = Directory.GetFiles(InterfacePath & "\Trans")
        For i As Integer = 0 To filesTrn.Length - 1
            Try
                File.Delete(filesTrn(i))
            Catch ex As Exception
                'ถ้าลบไม่ได้ก็ไม่เป็นไร
            End Try
        Next
        Dim filesMst() As String = Directory.GetFiles(InterfacePath & "\Mst")
        For i As Integer = 0 To filesMst.Length - 1
            Try
                File.Delete(filesMst(i))
            Catch ex As Exception
                MessageBox.Show("Please restart handy to clear Master file")
                Me.Close()
                Exit Sub
            End Try
        Next


        lblStatus.Text = "Uploading Transaction"
        If WriteLog() = True Then
            lblStatus.Text = "Write log completed"
        Else
            lblStatus.Text = "Uploading Transaction Error"
        End If

        TimeSync.Enabled = True
    End Sub

    Private Sub TimeSync_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TimeSync.Tick
        clsCLogin.ActiveDateTime = Now

        If PCLoadedTrans() = False Then Exit Sub
        If NewMasterFile() = True Then
            TimeSync.Enabled = False
            If DownloadMaster() = True Then
                lblStatus.Text = "Download Master Completed"
                Dim dt As DataTable = P_DB.getDataTable_CE("Select * from MstItem")
                Dim iZF As Integer = Convert.ToInt16(dt.Compute("count(RackDTID)", "Current='ZF'"))
                Dim iBMW As Integer = Convert.ToInt16(dt.Compute("count(RackDTID)", "Current='BMW'"))
                Dim iOntruck As Integer = Convert.ToInt16(dt.Compute("count(RackDTID)", "Current='On Truck'"))
                Dim iSupplier As Integer = Convert.ToInt16(dt.Compute("count(RackDTID)", "Current='Supplier'"))
                Dim iExtWH As Integer = Convert.ToInt16(dt.Compute("count(RackDTID)", "Current='Ext WH'"))
                Dim iFG As Integer = Convert.ToInt16(dt.Compute("count(RackDTID)", "Current='FG'"))
                Dim iRepairInZF As Integer = Convert.ToInt16(dt.Compute("count(RackDTID)", "Current='Repair in ZF'"))
                lblZF.Text = "ZF = " & Format(iZF, "#,###")
                lblBMW.Text = "BMW = " & Format(iBMW, "#,###")
                lblOntruck.Text = "On Truck = " & Format(iOntruck, "#,###")
                lblSuplier.Text = "Supplier = " & Format(iSupplier, "#,###")
                lblExtWH.Text = "Ext WH = " & Format(iExtWH, "#,###")
                lblFG.Text = "FG = " & Format(iFG, "#,###")
                lblRepairInZF.Text = "Repair in ZF = " & Format(iRepairInZF, "#,###")

                'Threading.Thread.Sleep(1000)
                'Me.Close()
                btnExit.Enabled = True
            Else
                lblStatus.Text = "Download Master Fail"
                btnExit.Enabled = True
            End If
        Else
            lblStatus.Text = "Please wait"
        End If
    End Sub

    Private Function NewMasterFile() As Boolean
        Try
            Dim MstDir As String = InterfacePath & "\Mst"
            Dim MstFileName As String = "\mst.txt"

            If File.Exists(MstDir & MstFileName) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            lblStatus.Text = "NewMasterFie Err: " & ex.Message
            Return False
        End Try
    End Function
    Private Function PCLoadedTrans() As Boolean
        If TransOK = True Then
            Return True
        Else
            If File.Exists(InterfacePath & "\Trans\TransOK.txt") = True Then
                Dim files() As String = Directory.GetFiles(InterfacePath & "\Trans")
                For i As Integer = 0 To files.Length - 1
                    Try
                        File.Delete(files(i))
                    Catch ex As Exception
                    End Try
                Next
                TransOK = True
                P_DB.runSQLCE("delete from PrgTrans")

                Return True
            Else
                Return False
            End If
        End If
    End Function
    Private Function DownloadMaster() As Boolean
        lblStatus.Text = "Uploading Master Data"

        P_DB.beginTransCE()
        Try
            If P_DB.runSQLCE("delete from MstItem") = False Then
                Return False
                Exit Function
            End If

            Dim SourcePath As String = InterfacePath & "\mst"
            Dim DestinationPath As String = SourcePath & "\BK"
            Dim MstFileName As String = "\mst.txt"
            Dim Cmd As New FileStream(SourcePath & MstFileName, FileMode.Open, FileAccess.Read)
            Dim CmdR As New StreamReader(Cmd)

            Do
                Dim Line As String = ""
                Dim Lines() As String

                Line = CmdR.ReadLine
                Lines = Strings.Split(Line, "|")

                If Lines.Length = 7 Then
                    Dim sql As String = "insert into MstItem (Rack,Remark,Model,Code,Running,[Current],RackDTID)"
                    sql &= " select '" & Lines(1) & "'"
                    sql &= ",'" & Lines(2) & "'"
                    sql &= ",'" & Lines(3) & "'"
                    sql &= ",'" & Lines(4) & "'"
                    sql &= ",'" & Lines(5) & "'"
                    sql &= ",'" & Lines(6) & "'"
                    sql &= "," & Lines(0) & ""

                    If P_DB.runSQLCE(sql) = False Then
                        Return False
                        Exit Function
                    End If
                End If

            Loop Until CmdR.Peek = -1

            P_DB.commitTransCE()
            Cmd.Close()

            If File.Exists(DestinationPath & MstFileName) = True Then
                File.Delete(DestinationPath & MstFileName)
            End If
            File.Move(SourcePath & MstFileName, DestinationPath & MstFileName)
            File.Copy(InterfacePath & "\Mst\BK\MstOK.txt", InterfacePath & "\Mst\MstOK.txt")
            System.Threading.Thread.Sleep(3000)  'อย่าน้อยกว่านี้
            If File.Exists(InterfacePath & "\Mst\MstOK.txt") Then File.Delete(InterfacePath & "\Mst\MstOK.txt")


            Return True
            Exit Function
        Catch ex As Exception
            lblStatus.Text = "DownloadMaster Err: " & ex.Message
            P_DB.rollbackTransCE()
            Return False
            Exit Function
        End Try
    End Function

    Private Function WriteLog() As Boolean
        Try
            Dim LogDir As String = InterfacePath & "\Tmp"
            Dim LogFileName As String = "\Log_" & Strings.Format(Now, "yyyyMMdd_HHmmss") & ".txt"

            If Directory.Exists(LogDir) = False Then
                Directory.CreateDirectory(LogDir)
            End If
            If File.Exists(LogDir & LogFileName) Then
                File.Delete(LogDir & LogFileName)
            End If

            Dim dt As DataTable
            'dt = P_DB.getDataTable_CE("Select * from PrgTrans")
            Dim sql As String = ""
            sql = "select PrgTrans.* "
            sql &= "      ,PrgTruckToday.Model as TruckModel,Varian,Lot,DeliveryNoteNo,AxleNo"
            sql &= " from PrgTrans"
            sql &= " left join PrgTruckToday on PrgTrans.TruckID=PrgTruckToday.TruckID"
            dt = P_DB.getDataTable_CE(sql)

            Dim Cmd As New FileStream(LogDir & LogFileName, FileMode.OpenOrCreate, FileAccess.Write)
            Dim CmdW As New StreamWriter(Cmd)
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    Dim str As String = dr("ID").ToString
                    Dim sTruckModel As String = ""
                    Dim sVarian As String = ""
                    Dim sLot As String = ""
                    Dim sDeliveryNoteNo As String = ""
                    Dim sAxleNo As String = ""
                    If Not IsDBNull(dr("TruckModel")) Then sTruckModel = dr("TruckModel")
                    If Not IsDBNull(dr("Varian")) Then sVarian = dr("Varian")
                    If Not IsDBNull(dr("Lot")) Then sLot = dr("Lot")
                    If Not IsDBNull(dr("DeliveryNoteNo")) Then sDeliveryNoteNo = dr("DeliveryNoteNo")
                    If Not IsDBNull(dr("AxleNo")) Then sAxleNo = dr("AxleNo")
                    str = str & "|" & dr("ScanType").ToString
                    str = str & "|" & dr("Rack").ToString
                    str = str & "|" & dr("Remark").ToString
                    str = str & "|" & dr("Model").ToString
                    str = str & "|" & dr("Code").ToString
                    str = str & "|" & dr("Running").ToString
                    str = str & "|" & Strings.Format(dr("ScanDateTime"), "yyyy-MM-dd HH:mm:ss")
                    str = str & "|" & dr("From").ToString
                    str = str & "|" & dr("To").ToString
                    str = str & "|" & dr("RackDTID").ToString
                    str = str & "|" & dr("StaffCode").ToString
                    str = str & "|" & dr("TruckID").ToString
                    str = str & "|" & sTruckModel
                    str = str & "|" & sVarian
                    str = str & "|" & sLot
                    str = str & "|" & sDeliveryNoteNo
                    str = str & "|" & sAxleNo

                    CmdW.WriteLine(str)

                Next
            End If
            CmdW.Close()
            Cmd.Close()

            Directory.Move(LogDir & LogFileName, InterfacePath & "\Trans" & LogFileName)

            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

End Class
