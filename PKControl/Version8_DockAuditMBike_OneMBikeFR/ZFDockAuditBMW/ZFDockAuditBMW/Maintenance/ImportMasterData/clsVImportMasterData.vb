Imports System.IO
Imports System.Data
Imports ZFDockAuditBMW.Barcode_System
Imports System.Windows.Forms

Public Class clsVImportMasterData
    Private InterfacePath As String = ""

#Region "Program Active"
    Private Sub clsVImportMasterData_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, txtStatus.KeyUp, txtResult.KeyUp, btnExit.KeyUp, btnDownload.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : DownloadClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVImportMasterData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click, btnDownload.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnDownload.Name : DownloadClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If

        btnDownload.Enabled = False
        btnExit.Text = "Close"
    End Sub
#End Region

#Region "Call Function"
    Private Sub DownloadClick()
        DownloadMaster()
        txtStatus.Text = "Finished"
    End Sub
    Private Sub ExitClick()
        Me.Close()
    End Sub
#End Region

    Private Sub clsVImportMasterData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InterfacePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName().CodeBase) & "\Interface\"
    End Sub
    Private Function DownloadMaster() As Boolean
        Dim OK As Boolean = True
        txtResult.Text = ""
        If DownloadMasterItem() = True Then
            txtResult.Text = "Download Item OK" & vbCrLf
        Else
            txtResult.Text = "Download Item Fail" & vbCrLf
        End If

        If DownloadMasterModelDock() = True Then
            txtResult.Text &= "Download Model Dock OK" & vbCrLf
        Else
            txtResult.Text &= "Download Model Dock Fail" & vbCrLf
        End If

        If DownloadMasterPart() = True Then
            txtResult.Text &= "Download Part OK" & vbCrLf
        Else
            txtResult.Text &= "Download Part Fail" & vbCrLf
        End If

        If DownloadMasterStaff() = True Then
            txtResult.Text &= "Download Staff OK" & vbCrLf
        Else
            txtResult.Text &= "Download Staff Fail" & vbCrLf
        End If

    End Function
    Private Function DownloadMasterItem() As Boolean
        txtStatus.Text = "Start Import"

        P_DB.beginTransCE()
        Try
            Dim SourcePath As String = InterfacePath & "\Mst"
            Dim DestinationPath As String = SourcePath & "\BK"
            Dim MstFileName As String = "\mstitem.txt"
            If File.Exists(DestinationPath & MstFileName) = True Then
                Dim Cmd As New FileStream(SourcePath & MstFileName, FileMode.Open, FileAccess.Read)
                Dim CmdR As New StreamReader(Cmd)

                If P_DB.runSQLCE("delete from MstItem") = False Then
                    Return False
                    Exit Function
                End If

                Do
                    Dim Line As String = ""
                    Dim Lines() As String

                    Line = CmdR.ReadLine
                    Lines = Strings.Split(Line, "|")

                    If Lines.Length = 6 Then
                        Dim sql As String = "insert into MstItem (Rack,Remark,Model,Code,Running,RackDTID)"
                        sql &= " select '" & Lines(1) & "','" & Lines(2) & "','" & Lines(3) & "','" & Lines(4) & "','" & Lines(5) & "'," & Lines(0) & ""

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
                Return True
            Else
                P_DB.rollbackTransCE()
                Return False
            End If
            Exit Function
        Catch ex As Exception
            P_DB.rollbackTransCE()
            Return False
            Exit Function
        End Try
    End Function

    Private Function DownloadMasterModelDock() As Boolean
        txtStatus.Text = "Start Import Model Dock"

        P_DB.beginTransCE()
        Try
            Dim SourcePath As String = InterfacePath & "\Mst"
            Dim DestinationPath As String = SourcePath & "\BK"
            Dim MstFileName As String = "\mstmodeldock.txt"
            If File.Exists(DestinationPath & MstFileName) = True Then
                Dim Cmd As New FileStream(SourcePath & MstFileName, FileMode.Open, FileAccess.Read)
                Dim CmdR As New StreamReader(Cmd)

                If P_DB.runSQLCE("delete from MstModelDock") = False Then
                    Return False
                    Exit Function
                End If

                Do
                    Dim Line As String = ""
                    Dim Lines() As String

                    Line = CmdR.ReadLine
                    Lines = Strings.Split(Line, "|")

                    If Lines.Length = 11 Then
                        Dim sql As String = "insert into MstModelDock (ModelRack,ModelDock,AreaCode,Check1,Check2,Check3,Check4,Check5,Check6,Check7,ModelDockID)"
                        sql &= " select '" & Lines(0) & "','" & Lines(1) & "','" & Lines(2) & "'," & Lines(3) & "," & Lines(4) & "," & Lines(5) & "," & Lines(6) & "," & Lines(7) & "," & Lines(8) & "," & Lines(9) & "," & Lines(10) & ""

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

                Return True
            Else
                P_DB.rollbackTransCE()
                Return False
            End If
            Exit Function
        Catch ex As Exception
            P_DB.rollbackTransCE()
            Return False
            Exit Function
        End Try
    End Function

    Private Function DownloadMasterPart() As Boolean
        txtStatus.Text = "Start Import Part"

        P_DB.beginTransCE()
        Try

            Dim SourcePath As String = InterfacePath & "\Mst"
            Dim DestinationPath As String = SourcePath & "\BK"
            Dim MstFileName As String = "\mstpart.txt"
            If File.Exists(DestinationPath & MstFileName) = True Then
                Dim Cmd As New FileStream(SourcePath & MstFileName, FileMode.Open, FileAccess.Read)
                Dim CmdR As New StreamReader(Cmd)

                If P_DB.runSQLCE("delete from MstPart") = False Then
                    Return False
                    Exit Function
                End If

                Do
                    Dim Line As String = ""
                    Dim Lines() As String

                    Line = CmdR.ReadLine
                    Lines = Strings.Split(Line, "|")

                    If Lines.Length = 3 Then
                        Dim sql As String = "insert into MstPart (Variant,AreaID,PartTypeID)"
                        sql &= " select '" & Lines(0) & "'," & Lines(1) & "," & Lines(2) & ""

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

                Return True
            Else
                P_DB.rollbackTransCE()
                Return False
            End If
            Exit Function
        Catch ex As Exception
            P_DB.rollbackTransCE()
            Return False
            Exit Function
        End Try
    End Function

    Private Function DownloadMasterStaff() As Boolean
        txtStatus.Text = "Start Import Staff"

        P_DB.beginTransCE()
        Try

            Dim SourcePath As String = InterfacePath & "\Mst"
            Dim DestinationPath As String = SourcePath & "\BK"
            Dim MstFileName As String = "\mststaff.txt"
            If File.Exists(DestinationPath & MstFileName) = True Then
                Dim Cmd As New FileStream(SourcePath & MstFileName, FileMode.Open, FileAccess.Read)
                Dim CmdR As New StreamReader(Cmd)

                If P_DB.runSQLCE("delete from MstStaff") = False Then
                    Return False
                    Exit Function
                End If

                Do
                    Dim Line As String = ""
                    Dim Lines() As String

                    Line = CmdR.ReadLine
                    Lines = Strings.Split(Line, "|")

                    If Lines.Length = 1 Then
                        Dim sql As String = "insert into MstStaff (StaffCode)"
                        sql &= " select '" & Lines(0) & "'"

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

                Return True
            Else
                P_DB.rollbackTransCE()
                Return False
            End If
            Exit Function
        Catch ex As Exception
            P_DB.rollbackTransCE()
            Return False
            Exit Function
        End Try
    End Function
End Class