Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports System.IO
Public Class clsVSyncronize_Android
    Private cls As New clsCRackStatus
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
    Private Enum eAnswer
        OK = 0
        Retry = 1
        Cancel = 2
    End Enum


    Private Sub clsVSyncronize_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        btnOperation.Enabled = False
        TimeSync.Enabled = True
    End Sub

    Private Sub TimeSync_Tick(sender As Object, e As System.EventArgs) Handles TimeSync.Tick
        If ChkDeviceConnect = False Then
            If DoingDeviceConnect = False Then DeviceConnect()
        ElseIf ChkTransferFile = False Then
            If DoingTransferFile = False Then CopyTransFile()
        ElseIf ChkCreateMaster = False Then
            If DoingCreateMaster = False Then CreateMasterFile()
        ElseIf chkSendMaster = False Then
            If DoingSendMaster = False Then SendMasterFile()
        ElseIf chkHandyFinish = False Then
            If DoingHandyFinish = False Then HandyFinish()
        Else
            TimeSync.Stop()
            btnOperation.Enabled = True
            If CustomerCode = "MB" Then
                Dim clsMB As New clsCRackStatus
                Dim dt As DataTable = clsMB.GetData(False, 0, False, 0, False, "", False, "", False, "", False)
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

            Else
                Dim clsBMW As New clsCRackStatus
                Dim dt As DataTable = clsBMW.GetData(False, 0, False, 0, False, "", False, "", False, "", False)
                Dim iZF As Integer = dt.Compute("count(RackDTID)", "RackStatus='ZF'")
                Dim iBMW As Integer = dt.Compute("count(RackDTID)", "RackStatus='BMW'")
                Dim iOntruck As Integer = dt.Compute("count(RackDTID)", "RackStatus='On Truck'")
                Dim iSupplier As Integer = dt.Compute("count(RackDTID)", "RackStatus='Supplier'")
                Dim iExtWH As Integer = dt.Compute("count(RackDTID)", "RackStatus='Ext WH'")
                Dim iFG As Integer = dt.Compute("count(RackDTID)", "RackStatus='FG'")
                Dim iRepairInZF As Integer = dt.Compute("count(RackDTID)", "RackStatus='Repair in ZF'")

                txtStatus.Text = "Syncronize Completed" & vbCrLf _
                                 & "ZF = " & IIf(iZF = 0, "0", Format(iZF, "#,###")) & "" & vbCrLf _
                                 & "BMW = " & IIf(iBMW = 0, "0", Format(iBMW, "#,###")) & "" & vbCrLf _
                                 & "On Truck = " & IIf(iOntruck = 0, "0", Format(iOntruck, "#,###")) & "" & vbCrLf _
                                 & "Supplier = " & IIf(iSupplier = 0, "0", Format(iSupplier, "#,###")) & "" & vbCrLf _
                                 & "Ext WH = " & IIf(iExtWH = 0, "0", Format(iExtWH, "#,###")) & "" & vbCrLf _
                                 & "FG = " & IIf(iFG = 0, "0", Format(iFG, "#,###")) & "" & vbCrLf _
                                 & "Repair in ZF = " & IIf(iRepairInZF = 0, "0", Format(iRepairInZF, "#,###")) & ""

            End If
            'Threading.Thread.Sleep(3000)
            'Me.Close()
        End If
    End Sub

    Private Sub DeviceConnect()
        DoingDeviceConnect = True
        If ADBCheckAndroidPath() = True Then
            ChkDeviceConnect = True
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Device is now connected" & vbCrLf
        Else
            txtStatus.Text = "Please connect device"
        End If
    End Sub

    Private Function ADBCheckAndroidPath() As Boolean
        Dim ret As Boolean = False
        Dim adbPath As String = INI.ADBPath ' --> C:\platform-tools\adb.exe
        Dim devicePath As String = INI.HandyInterface    ' --> /storage/emulated/0/Android/data/zf.bmw.dockaudit/files/

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

    Private Function ADBPullFromAndroid(deviceFilePath As String, localDestinationPath As String, IsAlert As Boolean) As Integer
        Dim adbPath As String = INI.ADBPath ' --> C:\platform-tools\adb.exe
        Dim iRet As Integer = eAnswer.OK

        If Not File.Exists(adbPath) Then
            If IsAlert = True Then
                If MsgBox("ADB not found at: " & adbPath, MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
                    iRet = eAnswer.Retry
                Else
                    iRet = eAnswer.Cancel
                End If
            Else
                iRet = eAnswer.Retry
            End If
        Else
            Dim pullCommand As String = String.Format("pull ""{0}"" ""{1}""", deviceFilePath, localDestinationPath)
            Dim sOutput As String = ""
            Dim sErr As String = ""
            Dim exitCode As Integer = ExecuteCommandWithExitCode(adbPath, pullCommand, sOutput, sErr)
            If exitCode = 0 Then
                iRet = eAnswer.OK
            Else
                If IsAlert = True Then
                    If MsgBox("Error during ADB pull: " & sErr, MsgBoxStyle.RetryCancel) = MsgBoxResult.Retry Then
                        iRet = eAnswer.Retry
                    Else
                        iRet = eAnswer.Cancel
                    End If
                Else
                    iRet = eAnswer.Retry
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

    Private Function ADBExitingFile(deviceDestinationFilePath As String) As Boolean
        Dim ret As Boolean = False
        Dim adbPath As String = INI.ADBPath ' --> C:\platform-tools\adb.exe

        If Not File.Exists(adbPath) Then
            MsgBox("ADB not found at: " & adbPath)
        Else
            Dim pushCommand As String = String.Format("shell ls {0}", deviceDestinationFilePath)
            Dim sOutput As String = ""
            Dim sErr As String = ""
            Dim exitCode As Integer = ExecuteCommandWithExitCode(adbPath, pushCommand, sOutput, sErr)
            If deviceDestinationFilePath.Trim = sOutput.Trim Then
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

    Private Sub CopyTransFile()
        DoingTransferFile = True
        Do
            txtStatus.Text = "Copying Transaction file"
            'adb pull /storage/emulated/0/Android/data/zf.bmw.pkctrl_bmw/files/Trans/. D:\Source\OPEGit\ZF\PKControl\Version7_DocAudit\ZFPKVisual\ZFPKVisual\bin\Debug\BMW\Interface\Trans\
            Dim HandyPath As String = INI.HandyInterface & "/Trans/"
            Dim PCPath = INI.InterfaceTrn
            PCPath = PCPath.Replace("\Trans", "")
            Dim PCBKPath = PCPath & "BK\"
            Dim iAnswer As Integer = ADBPullFromAndroid(HandyPath, PCPath, False)
            If iAnswer = eAnswer.OK Then
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
                        If ADBPushToAndroid(INI.InterfaceTrn & "\BK\TransOK.txt", INI.HandyInterface & "/Trans/" & "TransOK.txt") = True Then
                            ChkTransferFile = True
                            txtStatus.Text = "Copy transaction file completed"
                        Else
                            txtStatus.Text = "Copy transaction file fail"
                        End If
                        Exit Do
                    End If
                End If
            ElseIf iAnswer = eAnswer.Cancel Then
                ChkTransferFile = False
                Exit Sub
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
                Dim LineLength As Integer = IIf(CustomerCode = "MB", 13, 18)
                If Lines.Length = LineLength Then
                    Dim rScanType As Integer = Lines(1)
                    Dim rScanDateTime As String = Lines(7)
                    Dim rFrom As String = Lines(8)
                    Dim rTo As String = Lines(9)
                    Dim rRackDTID As String = Lines(10)
                    Dim rStaffCode As String = Lines(11)
                    Dim rTruckID As String = Lines(12)

                    '========For BMW==============
                    Dim rTruckModel As String = ""
                    Dim rVarian As String = ""
                    Dim rLot As String = ""
                    Dim rDeliveryNoteNo As String = ""
                    Dim rAxleNo As String = ""
                    If CustomerCode = "BMW" Then
                        rTruckModel = Lines(13)
                        rVarian = Lines(14)
                        rLot = Lines(15)
                        rDeliveryNoteNo = Lines(16)
                        rAxleNo = Lines(17)
                    End If
                    '=============================

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

                        If CustomerCode = "MB" Then
                            sql = "insert into PrgTransaction(ScanType,RackDTID,[From],[To],StaffCode,ScanDateTime,UpdateUser,UpdateDate,Replaced,TruckID)"
                            sql &= " select " & rScanType & ""
                            sql &= "," & rRackDTID & ""
                            sql &= ",'" & rFrom & "'"
                            sql &= ",'" & rTo & "'"
                            sql &= ",'" & rStaffCode & "'"
                            sql &= ",'" & rScanDateTime & "'"
                            sql &= "," & StaffID & ""
                            sql &= ",getdate()"
                            sql &= ",0"
                            sql &= ",'" & rTruckID & "'"
                        Else
                            sql = "insert into PrgTransaction(ScanType,RackDTID,[From],[To],StaffCode,ScanDateTime,UpdateUser,UpdateDate,Replaced,TruckID,TruckModel,Varian,Lot,DeliveryNoteNo,AxleNo)"
                            sql &= " select " & rScanType & ""
                            sql &= "," & rRackDTID & ""
                            sql &= ",'" & rFrom & "'"
                            sql &= ",'" & rTo & "'"
                            sql &= ",'" & rStaffCode & "'"
                            sql &= ",'" & rScanDateTime & "'"
                            sql &= "," & StaffID & ""
                            sql &= ",getdate()"
                            sql &= ",0"
                            sql &= ",'" & rTruckID & "'"
                            sql &= ",'" & rTruckModel & "'"
                            sql &= ",'" & rVarian & "'"
                            sql &= ",'" & rLot & "'"
                            sql &= ",'" & rDeliveryNoteNo & "'"
                            sql &= ",'" & rAxleNo & "'"
                        End If

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
        txtStatus.Text = "Creating Master"

        Try
            Dim dt As DataTable = cls.GetData(False, 0 _
                                           , False, 0 _
                                           , False, "" _
                                           , False, "" _
                                           , False, "" _
                                           , False)


            If Directory.Exists(INI.InterfaceMst) = False Then
                Directory.CreateDirectory(INI.InterfaceMst)
            End If
            If File.Exists(INI.InterfaceMst & INI.MstFilename) Then
                File.Delete(INI.InterfaceMst & INI.MstFilename)
            End If

            Dim RCHCmd As New FileStream(INI.InterfaceMst & INI.MstFilename, FileMode.OpenOrCreate, FileAccess.Write)
            Dim RCHCmdW As New StreamWriter(RCHCmd)
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
        HandyFile = Replace(HandyFile, "\", "/")

        If ADBPushToAndroid(PCPath, HandyFile) = True Then
            txtStatus.Text = "Send master completed"
            chkSendMaster = True
        Else
            txtStatus.Text = "Send master fail"
        End If
    End Sub

    Private Sub HandyFinish()
        DoingHandyFinish = True
        Do
            If ADBExitingFile(INI.HandyInterface & "/Mst/MstOK.txt") = True Then
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
End Class