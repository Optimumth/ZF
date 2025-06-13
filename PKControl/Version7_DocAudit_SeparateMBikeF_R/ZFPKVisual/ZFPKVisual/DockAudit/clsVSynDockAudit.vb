Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports System.IO
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class clsVSynDockAudit
    Private ChkDeviceConnect As Boolean = False
    Private ChkTransferFile As Boolean = False
    Private ChkInsertDB As Boolean = False
    '=========================================
    Private DoingDeviceConnect As Boolean = False
    Private DoingTransferFile As Boolean = False
    Private DoingInsertDB As Boolean = False
    '=========================================
    Private PCPath As String = ""
    Private PCBKPath As String = ""
    Private HandyPath As String = ""
    '=========================================
    Private clsWathcher As New clsFileWatcher
    Private isRecDockAudit As Boolean = False
    Private isRecDockAuditShock As Boolean = False
    'Private sTransDBResult As String = ""

    Private Enum eAnswer
        OK = 0
        Retry = 1
        Cancel = 2
    End Enum

    Private Sub clsVSynDockAudit_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        PCPath = CustomizeSetting.INI.InterfaceDockAudit
        If Not (Strings.Right(PCPath, 1) = "\") Then PCPath &= "\"
        PCBKPath = PCPath & "BK\"
        HandyPath = INI.DockAuditInterface & "/Sync/"
        If Not (Directory.Exists(PCPath)) Then Directory.CreateDirectory(PCPath)
        If Not (Directory.Exists(PCBKPath)) Then Directory.CreateDirectory(PCBKPath)

        '==================================================
        'เคลียร์ไฟล์เก่าที่อาจยังค้างอยู่
        If File.Exists(PCPath & "dockAudit.txt") Then
            File.Delete(PCPath & "dockAudit.txt")
        End If
        If File.Exists(PCPath & "dockAuditShock.txt") Then
            File.Delete(PCPath & "dockAuditShock.txt")
        End If
        '===================================================

        AddHandler clsWathcher.FileDetected, AddressOf OnDockAuditFileDetected
        clsWathcher.StartWatching(PCPath)
        TimeSync.Enabled = True
    End Sub

    Private Sub OnDockAuditFileDetected(filePath As String)
        Dim sErr1 As String = "Save Dock Audit Complete" & vbCrLf
        Dim sErr2 As String = "Save Dock Audit Shock Complete" & vbCrLf
        If InStr(filePath, "dockAudit.txt") Then
            isRecDockAudit = True
        ElseIf InStr(filePath, "dockAuditShock.txt") Then
            isRecDockAuditShock = True
        End If
        If isRecDockAudit = True And isRecDockAuditShock = True Then
            clsWathcher.StopWatching()
            If TransToDB(sErr1, sErr2) = True Then
                If CreateConfirmFile() = True Then
                    MoveFile()
                    UpdateStatus(sErr1 & sErr2)
                    Try
                        File.Delete(PCPath & "PCConfirmed.txt")
                    Catch ex As Exception

                    End Try
                End If
            End If
        End If
    End Sub
    Private Sub UpdateStatus(message As String)
        If txtStatus.InvokeRequired Then
            txtStatus.Invoke(New MethodInvoker(Sub() txtStatus.Text = message))
        Else
            txtStatus.Text = message
        End If
    End Sub

    Private Sub MoveFile()
        If File.Exists(PCBKPath & "dockAudit.txt") Then File.Delete(PCBKPath & "dockAudit.txt")
        If File.Exists(PCBKPath & "dockAuditShock.txt") Then File.Delete(PCBKPath & "dockAuditShock.txt")
        File.Move(PCPath & "dockAudit.txt", PCBKPath & "dockAudit.txt")
        File.Move(PCPath & "dockAuditShock.txt", PCBKPath & "dockAuditShock.txt")
    End Sub

    Private Function CreateConfirmFile() As Boolean
        Try
            Dim RCHCmd As New FileStream(PCPath & "PCConfirmed.txt", FileMode.OpenOrCreate, FileAccess.Write)
            Dim RCHCmdW As New StreamWriter(RCHCmd)
            RCHCmdW.WriteLine(txtStatus.Text)

            If ADBPushToAndroid(PCPath & "PCConfirmed.txt", HandyPath & "PCConfirmed.txt") = True Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub TimeSync_Tick(sender As Object, e As System.EventArgs) Handles TimeSync.Tick
        If ChkDeviceConnect = False Then
            If DoingDeviceConnect = False Then DeviceConnect()
        ElseIf ChkTransferFile = False Then
            If DoingTransferFile = False Then
                CopyTransFile()
                If ChkTransferFile = False Then
                    TimeSync.Stop()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub DeviceConnect()
        DoingDeviceConnect = True
        If ADBCheckAndroidPath() = True Then
            ChkDeviceConnect = True
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Device is now connected" & vbCrLf
        Else
            txtStatus.Text = "Please connect device and go to Synchronize"
        End If
    End Sub

    Private Sub CopyTransFile()
        DoingTransferFile = True
        Do
            txtStatus.Text = "Copying Dock Audit file"


            Dim HandyFilePath As String = ""
            Dim PCFilePath As String = ""

            HandyFilePath = HandyPath & "dockAudit.txt"
            PCFilePath = PCPath & "dockAudit.txt"
            Dim iAnswer As Integer = ADBPullFromAndroid(HandyFilePath, PCFilePath)
            If iAnswer = eAnswer.OK Then
                HandyFilePath = HandyPath & "dockAuditShock.txt"
                PCFilePath = PCPath & "dockAuditShock.txt"

                iAnswer = ADBPullFromAndroid(HandyFilePath, PCFilePath)
                If iAnswer = eAnswer.OK Then
                    ChkTransferFile = True
                    Exit Sub
                ElseIf iAnswer = eAnswer.Cancel Then
                    ChkTransferFile = False
                    Exit Sub
                End If
            ElseIf iAnswer = eAnswer.Cancel Then
                ChkTransferFile = False
                Exit Sub
            End If

            Threading.Thread.Sleep(1000)
        Loop
    End Sub

    Private Function ADBCheckAndroidPath() As Boolean
        Dim ret As Boolean = False
        Dim adbPath As String = INI.ADBPath ' --> C:\platform-tools\adb.exe
        Dim devicePath As String = INI.DockAuditInterface   ' --> /storage/emulated/0/Android/data/zf.bmw.dockaudit/files/

        If Not File.Exists(adbPath) Then
            MsgBox("ADB not found at: " & adbPath)
        Else
            Dim checkDirCommand As String = "shell ls -d " & devicePath & ""
            Dim sOutput As String = "" 'เก็บค่ามาก่อน ไม่รู้จะเอาไปใช้ทำอะไร
            Dim sErr As String = ""    'เก็บค่ามาก่อน ไม่รู้จะเอาไปใช้ทำอะไร
            Dim exitCode As Integer = ExecuteCommandWithExitCode(adbPath, checkDirCommand, sOutput, sErr)

            If exitCode = 0 Then
                ret = True
            End If
        End If

        Return ret
    End Function

    Private Function ADBPullFromAndroid(deviceFilePath As String, localDestinationPath As String) As Integer
        Dim adbPath As String = INI.ADBPath ' --> C:\platform-tools\adb.exe
        Dim iRet As Integer = eAnswer.OK

        If Not File.Exists(adbPath) Then
            If MsgBox("ADB not found at: " & adbPath, MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
                iRet = eAnswer.Retry
            Else
                iRet = eAnswer.Cancel
            End If
        Else
            Dim pullCommand As String = String.Format("pull ""{0}"" ""{1}""", deviceFilePath, localDestinationPath)
            Dim sOutput As String = ""
            Dim sErr As String = ""
            Dim exitCode As Integer = ExecuteCommandWithExitCode(adbPath, pullCommand, sOutput, sErr)
            If exitCode = 0 Then
                iRet = eAnswer.OK
            Else
                If MsgBox("Error during ADB pull: " & sErr, MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
                    iRet = eAnswer.Retry
                Else
                    iRet = eAnswer.Cancel
                End If
            End If
        End If

        Return iRet
    End Function

    Private Function ADBPushToAndroid(localFilePath As String, deviceDestinationPath As String) As Boolean
        Dim ret As Boolean = False
        Dim adbPath As String = INI.ADBPath ' --> C:\platform-tools\adb.exe

        If Not File.Exists(adbPath) Then
            MsgBox("ADB not found at: " & adbPath)
        Else
            Dim pushCommand As String = String.Format("push ""{0}"" ""{1}""", localFilePath, deviceDestinationPath)
            Dim sOutput As String = "" 'เก็บค่ามาก่อน ไม่รู้จะเอาไปใช้ทำอะไร
            Dim sErr As String = ""    'เก็บค่ามาก่อน ไม่รู้จะเอาไปใช้ทำอะไร
            Dim exitCode As Integer = ExecuteCommandWithExitCode(adbPath, pushCommand, sOutput, sErr)
            If exitCode = 0 Then
                ret = True
            End If
        End If

        Return ret
    End Function

    Function ExecuteCommandWithExitCode(ByVal fileName As String, ByVal arguments As String, ByRef sOutput As String, ByRef sErr As String) As Integer
        Dim process As New Process()
        process.StartInfo.FileName = fileName
        process.StartInfo.Arguments = arguments
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = True

        process.Start()
        process.WaitForExit()

        ' Log output (optional)
        sOutput = process.StandardOutput.ReadToEnd()
        sErr = process.StandardError.ReadToEnd()

        Return process.ExitCode
    End Function

    Private Function TransToDB(ByRef sErr1 As String, ByRef sErr2 As String) As Boolean
        DataBase.BeginTrans()
        Try
            If transferDockAudit(sErr1) = True Then
                If transferDockAuditShock(sErr2) = True Then
                    DataBase.CommitTrans()
                    Return True
                    Exit Function
                End If
            End If

        Catch ex As Exception
            GoTo SaveError
        End Try

SaveError:
        DataBase.RollbackTrans()
        Return False
    End Function

    Private Function transferDockAudit(ByRef sErr As String) As Boolean
        Try
            Dim SorceFile As String = PCPath & "dockAudit.txt"
            Dim Cmd As New FileStream(SorceFile, FileMode.Open, FileAccess.Read)
            Dim CmdR As New StreamReader(Cmd)
            Dim sql As String = ""
            Do
                Dim Line As String = ""
                Dim Lines() As String

                Line = CmdR.ReadLine
                Lines = Strings.Split(Line, "|")
                Dim LineLength As Integer = 22
                If Lines.Length = LineLength Then
                    Dim rRackDTID As Integer = Lines(0)
                    Dim rModelDockID As Integer = Lines(1)
                    Dim rVarian As String = Lines(2)
                    Dim rLot As String = Lines(3)
                    Dim rAxleNo As String = Lines(4)
                    Dim rSide As String = Lines(5)
                    Dim rBarcode As String = Lines(6)
                    Dim rRev As Integer = Lines(7)
                    Dim rAxleShock As Integer = Lines(8)
                    Dim rAreaID As Integer = Lines(9)
                    Dim rPartTypeID As Integer = Lines(10)
                    Dim rCheck1 As Integer = Lines(11)
                    Dim rCheck2 As Integer = Lines(12)
                    Dim rCheck3 As Integer = Lines(13)
                    Dim rCheck_Caliper As String = Lines(14)
                    Dim rCheck4 As Integer = Lines(15)
                    Dim rCheck5 As Integer = Lines(16)
                    Dim rCheck6 As Integer = Lines(17)
                    Dim rCheck7 As Integer = Lines(18)
                    Dim rStaffCode As String = Lines(19)
                    Dim rScanDateTime As String = Lines(20)
                    Dim rCompleteFlag As Integer = Lines(21)
                    '=============================
                    Dim dtTrans As DataTable = DataBase.DataSelect("PrgDockAudit", "Barcode='" & rBarcode & "' and AxleShock=" & rAxleShock & "")
                    If dtTrans.Rows.Count > 0 Then
                        sErr &= "- Duplicate " & rBarcode & " (Skipped)" & vbCrLf
                    Else
                        sql = String.Format( _
                            "insert into PrgDockAudit(RackDTID, ModelDockID, Varian, Lot, AxleNo, Side, Barcode, Rev, AxleShock      {0}" & _
                            "                         , AreaID, PartTypeID                                                           {0}" & _
                            "                         , Check1, Check2, Check3, Check3_Caliper, Check4, Check5, Check6, Check7       {0}" & _
                            "                         , StaffCode, ScanDateTime, CompleteFlag, CorrectedFlag, UpdateUser, UpdateDate){0}" & _
                            "select " & rRackDTID & "," & rModelDockID & ", '" & rVarian & "','" & rLot & "','" & rAxleNo & "','" & rSide & "','" & rBarcode & "'," & rRev & "," & rAxleShock & " {0}" & _
                            "       ," & rAreaID & "," & rPartTypeID & "                                                                                                                          {0}" & _
                            "       ," & rCheck1 & "," & rCheck2 & "," & rCheck3 & ",'" & rCheck_Caliper & "'," & rCheck4 & "," & rCheck5 & "," & rCheck6 & "," & rCheck7 & "                     {0}" & _
                            "       ,'" & rStaffCode & "','" & rScanDateTime & "'," & rCompleteFlag & ",0, " & StaffID & ", getdate()                                                             {0}" _
                            , vbCrLf)
                        If DataBase.runSQL(sql) = False Then GoTo SaveError
                    End If
                End If
            Loop Until CmdR.Peek = -1

            Cmd.Close()

            Return True

        Catch ex As Exception
            GoTo SaveError
        End Try

SaveError:
        sErr = "Save Dock Audit fail."
        Return False
    End Function

    Private Function transferDockAuditShock(ByRef sErr As String) As Boolean
        Try
            Dim SorceFile As String = PCPath & "dockAuditShock.txt"
            Dim Cmd As New FileStream(SorceFile, FileMode.Open, FileAccess.Read)
            Dim CmdR As New StreamReader(Cmd)
            Dim sql As String = ""
            Dim dupBarcode As String = ""
            Do
                Dim Line As String = ""
                Dim Lines() As String
                Line = CmdR.ReadLine
                Lines = Strings.Split(Line, "|")
                Dim LineLength As Integer = 4
                If Lines.Length = LineLength Then
                    Dim rBarcodeHD As String = Lines(0)
                    Dim rRev As Integer = Lines(1)
                    Dim rBarcode As String = Lines(2)
                    Dim rResult As String = Lines(3)
                    '=============================
                    Dim dtTrans As DataTable = DataBase.DataSelect("PrgDockAuditShock", "Barcode='" & rBarcode & "'")
                    If dtTrans.Rows.Count > 0 Then
                        If dupBarcode <> rBarcode Then
                            dupBarcode = rBarcode
                            sErr &= "- Duplicate " & rBarcode & " (Skipped)" & vbCrLf
                        End If
                    Else
                        sql = String.Format( _
                            "insert into PrgDockAuditShock(BarcodeHD, Rev, Barcode, Result, UpdateUser, UpdateDate) {0}" & _
                            "select '" & rBarcodeHD & "', " & rRev & ", '" & rBarcode & "', '" & rResult & "'," & StaffID & ",getdate() {0}" _
                            , vbCrLf)
                        If DataBase.runSQL(sql) = False Then GoTo SaveError
                    End If
                End If
            Loop Until CmdR.Peek = -1

            Cmd.Close()

            Return True

        Catch ex As Exception
            GoTo SaveError
        End Try

SaveError:
        sErr = "Save Dock Audit fail."
        Return False
    End Function

    Private Sub btnOperation_Click(sender As System.Object, e As System.EventArgs) Handles btnOperation.Click
        Me.Close()
    End Sub
End Class