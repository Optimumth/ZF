Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports OBSWMC
Imports System.IO

Public Class clsVSyncronize
    Private cls As New clsCRackStatus
    Private OBSWMC As New OBSWMC.OBSWMC
    Private lsportableDevices As List(Of OBSWMC.PortableDevice)
    Private NewTransFile As String = ""

    '=========================================
    Private ChkDeviceConnect As Boolean = False
    Private ChkTransferFile As Boolean = False
    Private ChkTransToDB As Boolean = False
    Private ChkCreateMaster As Boolean = False
    Private chkSendMaster As Boolean = False
    Private chkHandyFinish As Boolean = False
    '=========================================
    Private DoingDeviceConnect As Boolean = False
    Private DoingTransferFile As Boolean = False
    Private DoingSavePrgTrans As Boolean = False
    Private DoingCreateMaster As Boolean = False
    Private DoingSendMaster As Boolean = False
    Private DoingHandyFinish As Boolean = False
    '=========================================

    'Private SyncStatus As Integer
    'Private Enum eSyncStatus
    '    DeviceConnect = 0
    '    CopyTransFile = 1
    '    TransToDB = 2
    '    CreateMaster = 3
    'End Enum


    Private Sub clsVSyncronize_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        btnOperation.Enabled = False
        TimeSync.Enabled = True
    End Sub

    Private Sub TimeSync_Tick(sender As Object, e As System.EventArgs) Handles TimeSync.Tick
        If ChkDeviceConnect = False Then
            If DoingDeviceConnect = False Then DeviceConnect()
        ElseIf ChkTransferFile = False Then
            If DoingTransferFile = False Then CopyTransFile()
            'ElseIf ChkTransToDB = False Then
            '    If DoingSavePrgTrans = False Then TransToDB()
        ElseIf ChkCreateMaster = False Then
            If DoingCreateMaster = False Then CreateMasterFile()
        ElseIf chkSendMaster = False Then
            If DoingSendMaster = False Then SendMasterFile()
        ElseIf chkHandyFinish = False Then
            If DoingHandyFinish = False Then HandyFinish()
        Else
            TimeSync.Stop()
            btnOperation.Enabled = True
            Dim dt As DataTable = cls.GetData(False, 0, False, 0, False, "", False, "", False, "")
            Dim iZF As Integer = dt.Compute("count(RackDTID)", "RackStatus='ZF'")
            Dim iMB As Integer = dt.Compute("count(RackDTID)", "RackStatus='MB'")
            Dim iOntruck As Integer = dt.Compute("count(RackDTID)", "RackStatus='On Truck'")
            Dim iSupplier As Integer = dt.Compute("count(RackDTID)", "RackStatus='Supplier'")
            Dim iExtWH As Integer = dt.Compute("count(RackDTID)", "RackStatus='Ext WH'")

            txtStatus.Text = "Syncronize Completed" & vbCrLf _
                             & "ZF = " & Format(iZF, "#,###") & "" & vbCrLf _
                             & "MB = " & Format(iMB, "#,###") & "" & vbCrLf _
                             & "On Truck = " & Format(iOntruck, "#,###") & "" & vbCrLf _
                             & "Supplier = " & Format(iSupplier, "#,###") & "" & vbCrLf _
                             & "Ext WH = " & Format(iExtWH, "#,###") & ""


            'Threading.Thread.Sleep(3000)
            'Me.Close()
        End If
    End Sub

    Private Sub DeviceConnect()
        DoingDeviceConnect = True
        txtStatus.Text = "Please connect device"
        lsportableDevices = OBSWMC.getDevices()
        If lsportableDevices.Count <= 0 Then Exit Sub
        'MC92000
        Dim iPortable As Integer = -1
        For iLoop As Integer = 0 To lsportableDevices.Count - 1
            If InStr(lsportableDevices(iLoop).Name.ToUpper, "MC92000", CompareMethod.Text) Then
                iPortable = iLoop
            End If
        Next

        OBSWMC.PortableDevice = lsportableDevices(iPortable)
        If OBSWMC.Connect() Then
            Dim HandyFile As String = INI.HandyInterface & "/Mst/mst.txt"
            Dim obj As Object = OBSWMC.getFile(HandyFile)
            If Not obj Is Nothing Then
                Try
                    If OBSWMC.DeleteFile(HandyFile) = False Then
                        txtStatus.Text = "Please restart handy to clear old file"
                        Exit Sub
                    End If
                Catch ex As Exception
                    txtStatus.Text = "Please restart handy to clear old file"
                    Exit Sub
                End Try
            End If

            HandyFile = INI.HandyInterface & "/Trans/TransOK.txt"
            obj = OBSWMC.getFile(HandyFile)
            If obj Is Nothing Then
                ChkDeviceConnect = True
                txtStatus.Text = "MC92000 is now connected"
            Else
                Try
                    If OBSWMC.DeleteFile(HandyFile) = True Then
                        ChkDeviceConnect = True
                        txtStatus.Text = "MC92000 is now connected"
                    Else
                        txtStatus.Text = "Please restart handy to clear old file"
                        Exit Sub
                    End If
                Catch ex As Exception
                    txtStatus.Text = "Please restart handy to clear old file"
                    Exit Sub
                End Try
            End If

        End If
    End Sub

    Private Sub CopyTransFile()
        DoingTransferFile = True
        Do
            txtStatus.Text = "Copying Transaction file"
            If OBSWMC.CopyFordel(INI.HandyInterface & "/Trans", INI.InterfaceTrn) Then
                Dim files() As String = Directory.GetFiles(CustomizeSetting.INI.InterfaceTrn)
                Dim NewFile As Boolean = False
                For iLoop As Integer = 0 To files.Length - 1
                    Dim OldFile As String = Replace(files(iLoop), "\Trans", "\Trans\BK")
                    If File.Exists(OldFile) Then
                        File.Delete(files(iLoop))
                    Else
                        NewFile = True
                        NewTransFile = files(iLoop)
                    End If
                Next
                If NewFile = True Then
                    If TransToDB() = True Then

                        OBSWMC.CopyFileToDevice(INI.InterfaceTrn & "\BK\TransOK.txt", INI.HandyInterface & "/Trans")
                        If (String.IsNullOrEmpty(OBSWMC.Err)) Then
                            ChkTransferFile = True
                            txtStatus.Text = "Copy transaction file completed"
                        Else
                            txtStatus.Text = "Copy transaction file fail"
                        End If
                        Exit Do
                    End If
                End If
            End If
            Threading.Thread.Sleep(1000)
        Loop
    End Sub

    Private Function TransToDB() As Boolean
        DoingSavePrgTrans = True

        txtStatus.Text = "Saving Transaction"
        DataBase.BeginTrans()
        Try
            Dim SorceFile As String = NewTransFile
            Dim Cmd As New FileStream(SorceFile, FileMode.Open, FileAccess.Read)
            Dim CmdR As New StreamReader(Cmd)

            Do
                Dim Line As String = ""
                Dim Lines() As String

                Line = CmdR.ReadLine
                Lines = Strings.Split(Line, "|")
                If Lines.Length = 12 Then
                    Dim rScanType As Integer = Lines(1)
                    Dim rScanDateTime As String = Lines(7)
                    Dim rFrom As String = Lines(8)
                    Dim rTo As String = Lines(9)
                    Dim rRackDTID As String = Lines(10)
                    Dim rStaffCode As String = Lines(11)

                    Dim dtTrans As DataTable = DataBase.DataSelect("PrgTransaction", "RackDTID=" & rRackDTID & "  and Replaced=0")
                    Dim DupTrans As Boolean = False
                    For Each drTrans As DataRow In dtTrans.Select()
                        If Format(drTrans("ScanDateTime"), "yyyy-MM-dd HH:mm:ss") = rScanDateTime Then
                            DupTrans = True
                            Exit For
                        End If
                    Next

                    If DupTrans = False Then
                        Dim sql As String = ""
                        sql = "update PrgTransaction set Replaced=1 where RackDTID=" & rRackDTID & " and Replaced=0"
                        If DataBase.runSQL(sql) = False Then GoTo SaveError

                        sql = "update MstRackDT set Replaced=1 where ID=" & rRackDTID & ""
                        If DataBase.runSQL(sql) = False Then GoTo SaveError

                        sql = "insert into PrgTransaction(ScanType,RackDTID,[From],[To],StaffCode,ScanDateTime,UpdateUser,UpdateDate,Replaced)"
                        sql &= " select " & rScanType & ""
                        sql &= "," & rRackDTID & ""
                        sql &= ",'" & rFrom & "'"
                        sql &= ",'" & rTo & "'"
                        sql &= ",'" & rStaffCode & "'"
                        sql &= ",'" & rScanDateTime & "'"
                        sql &= "," & StaffID & ""
                        sql &= ",getdate()"
                        sql &= ",0"
                        If DataBase.runSQL(sql) = False Then GoTo SaveError
                    End If
                End If

            Loop Until CmdR.Peek = -1

            Cmd.Close()

            Dim DestFile As String = Replace(SorceFile, "\Trans\", "\Trans\BK\")
            If File.Exists(DestFile) Then File.Delete(DestFile)
            Directory.Move(SorceFile, DestFile)

            Dim files() As String = Directory.GetFiles(CustomizeSetting.INI.InterfaceTrn)
            For iLoop As Integer = 0 To files.Length - 1
                If File.Exists(files(iLoop)) Then File.Delete(files(iLoop))
            Next


            DataBase.CommitTrans()
            ChkTransToDB = True

            txtStatus.Text = "Save transaction completed"
            NewTransFile = ""
            Return True

        Catch ex As Exception
            GoTo SaveError
        End Try

SaveError:
        DataBase.RollbackTrans()
        txtStatus.Text = "Save transaction fail."
        Return False
    End Function

    Private Sub CreateMasterFile()
        'RackDTID,Rack,Remark,Model,Code,Running,Current
        'ScanDateTiem,Model,Code,RackNo,RackStatus,ColorA,ColorR,ColorG,ColorB,RackDTID
        txtStatus.Text = "Creating Master"

        Try
            Dim dt As DataTable = cls.GetData(False, 0 _
                                           , False, 0 _
                                           , False, "" _
                                           , False, "" _
                                           , False, "")

            If Directory.Exists(INI.InterfaceMst) = False Then
                Directory.CreateDirectory(INI.InterfaceMst)
            End If
            If File.Exists(INI.InterfaceMst & INI.MstFilename) Then
                File.Delete(INI.InterfaceMst & INI.MstFilename)
            End If

            Dim RCHCmd As New FileStream(INI.InterfaceMst & INI.MstFilename, FileMode.OpenOrCreate, FileAccess.Write)
            Dim RCHCmdW As New StreamWriter(RCHCmd)
            'RackDTID,Rack,Remark,Model,Code,Running,Current--->Handy's DB
            'ScanDateTiem,Model,Code,RackNo,RackStatus,ColorA,ColorR,ColorG,ColorB,RackDTID -->
            For Each dr As DataRow In dt.Rows
                Dim str As String = dr("RackDTID").ToString
                str = str & "|" & dr("RackID").ToString '= Rack in handy
                str = str & "|" & dr("Remark").ToString
                str = str & "|" & dr("Model").ToString
                str = str & "|" & dr("Code").ToString
                str = str & "|" & dr("RackNo").ToString '= Running in handy
                str = str & "|" & dr("RackStatus").ToString

                RCHCmdW.WriteLine(str)
            Next
            RCHCmdW.Close()
            RCHCmd.Close()

            txtStatus.Text = "Create master completed"
            ChkCreateMaster = True

        Catch ex As Exception
            txtStatus.Text = "Create master fail"
        End Try

    End Sub
    Private Sub SendMasterFile()
        txtStatus.Text = "Sending master file"
        DoingSendMaster = True

        Dim PCPath As String = INI.InterfaceMst & INI.MstFilename
        Dim HandyFile As String = INI.HandyInterface & "/Mst" & INI.MstFilename


        Dim obj As Object = OBSWMC.getFile(HandyFile)
        If Not obj Is Nothing Then
            OBSWMC.DeleteFile(HandyFile)
            If (String.IsNullOrEmpty(OBSWMC.Err)) = False Then
                txtStatus.Text = "Send master fail"
                Exit Sub
            End If
        End If

        OBSWMC.CopyFileToDevice(PCPath, INI.HandyInterface & "/Mst")
        If (String.IsNullOrEmpty(OBSWMC.Err)) Then
            txtStatus.Text = "Send master completed"
            chkSendMaster = True
        Else
            txtStatus.Text = "Send master fail"
        End If
    End Sub

    Private Sub HandyFinish()
        DoingHandyFinish = True
        Do
            Dim OKFile As Object = OBSWMC.getFile(INI.HandyInterface & "/Mst/MstOK.txt")
            If Not OKFile Is Nothing Then
                If File.Exists(CustomizeSetting.INI.InterfaceMst & "\mst.txt") Then File.Delete(CustomizeSetting.INI.InterfaceMst & "\mst.txt")
                If File.Exists(CustomizeSetting.INI.InterfaceMst & "\MstOK.txt") Then File.Delete(CustomizeSetting.INI.InterfaceMst & "\MstOK.txt")
                chkHandyFinish = True
                Threading.Thread.Sleep(1000)
                txtStatus.Text = "All completed"
                Exit Do
            End If

            Threading.Thread.Sleep(1000)
        Loop
    End Sub
    
    Private Sub btnOperation_Click(sender As System.Object, e As System.EventArgs) Handles btnOperation.Click
        Me.Close()
    End Sub

    

    Private Function HandyMasterFinish() As Boolean
        Dim HandyFile As String = INI.HandyInterface & INI.MstFilename
        Dim obj As Object = OBSWMC.getFile(HandyFile)
        If obj Is Nothing Then
            txtStatus.Text = "Handy Master Uploaded"
            btnOperation.Text = "Close"
            btnOperation.Enabled = True
            Return True
        Else
            Return False
        End If
    End Function

End Class