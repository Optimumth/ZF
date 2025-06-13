Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports System.IO
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class clsVExportMasterData_Android
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


    Private Sub clsVExportMasterData_Android_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtStatus.Text = "Please Start" & vbCrLf
        TimeSync.Enabled = False
        btnClose.Enabled = False
    End Sub

    Private Sub TimeSync_Tick(sender As Object, e As System.EventArgs) Handles TimeSync.Tick
        If ChkDeviceConnect = False Then
            If DoingDeviceConnect = False Then DeviceConnect()
        ElseIf ChkCreateMaster = False Then
            If DoingCreateMaster = False Then CreateMasterFile()
        ElseIf chkSendMaster = False Then
            If DoingSendMaster = False Then SendMasterFile()
        Else
            TimeSync.Stop()
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Finished, Please import at BARCODE SCANNER"
            btnClose.Enabled = True
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

    Private Sub CreateMasterFile()
        txtStatus.Text &= "..." & vbCrLf
        txtStatus.Text &= "Creating Master" & vbCrLf
        DoingCreateMaster = True

        Try
            Dim cls As New clsCExportMasterData
            If Directory.Exists(INI.InterfaceMst) = False Then
                Directory.CreateDirectory(INI.InterfaceMst)
            End If
            If File.Exists(INI.InterfaceMst & INI.DockAuditMstItemFileName) Then
                File.Delete(INI.InterfaceMst & INI.DockAuditMstItemFileName)
            End If
            If File.Exists(INI.InterfaceMst & INI.DockAuditMstModelDockFileName) Then
                File.Delete(INI.InterfaceMst & INI.DockAuditMstModelDockFileName)
            End If
            If File.Exists(INI.InterfaceMst & INI.DockAuditMstPartFileName) Then
                File.Delete(INI.InterfaceMst & INI.DockAuditMstPartFileName)
            End If
            If File.Exists(INI.InterfaceMst & INI.DockAuditMstStaffFileName) Then
                File.Delete(INI.InterfaceMst & INI.DockAuditMstStaffFileName)
            End If
            If File.Exists(INI.InterfaceMst & INI.DockAuditMstQCFileName) Then
                File.Delete(INI.InterfaceMst & INI.DockAuditMstQCFileName)
            End If

            Dim RCHCmd As New FileStream(INI.InterfaceMst & INI.DockAuditMstItemFileName, FileMode.OpenOrCreate, FileAccess.Write)
            Dim RCHCmdW As New StreamWriter(RCHCmd)
            Dim dt As DataTable = cls.GetMstItem()
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
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Creat mstitem.txt OK" & vbCrLf

            RCHCmd = New FileStream(INI.InterfaceMst & INI.DockAuditMstModelDockFileName, FileMode.OpenOrCreate, FileAccess.Write)
            RCHCmdW = New StreamWriter(RCHCmd)
            dt = cls.GetMstModelDock
            For Each dr As DataRow In dt.Rows
                Dim str As String = dr("ModelRack").ToString
                str = str & "|" & dr("ModelDock").ToString
                str = str & "|" & dr("AreaCode").ToString
                str = str & "|" & dr("CaliperFlag").ToString
                str = str & "|" & dr("Check1").ToString
                str = str & "|" & dr("Check2").ToString
                str = str & "|" & dr("Check3").ToString
                str = str & "|" & dr("Check4").ToString
                str = str & "|" & dr("Check5").ToString
                str = str & "|" & dr("Check6").ToString
                str = str & "|" & dr("Check7").ToString
                str = str & "|" & dr("Format1").ToString
                str = str & "|" & dr("Format2").ToString
                str = str & "|" & dr("Format3").ToString
                str = str & "|" & dr("Format4").ToString
                str = str & "|" & dr("Format5").ToString
                str = str & "|" & dr("Format6").ToString
                str = str & "|" & dr("Format7").ToString
                str = str & "|" & dr("ModelDockID").ToString

                RCHCmdW.WriteLine(str)
            Next
            RCHCmdW.Close()
            RCHCmd.Close()
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Creat mstmodeldock.txt OK" & vbCrLf

            RCHCmd = New FileStream(INI.InterfaceMst & INI.DockAuditMstPartFileName, FileMode.OpenOrCreate, FileAccess.Write)
            RCHCmdW = New StreamWriter(RCHCmd)
            dt = cls.GetMstPart
            For Each dr As DataRow In dt.Rows
                Dim str As String = dr("Variant").ToString
                str = str & "|" & dr("AreaID").ToString
                str = str & "|" & dr("PartTypeID").ToString
                str = str & "|" & dr("CaliperFlag").ToString
                str = str & "|" & dr("PartNo").ToString

                RCHCmdW.WriteLine(str)
            Next
            RCHCmdW.Close()
            RCHCmd.Close()
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Creat mstpart.txt OK" & vbCrLf

            RCHCmd = New FileStream(INI.InterfaceMst & INI.DockAuditMstStaffFileName, FileMode.OpenOrCreate, FileAccess.Write)
            RCHCmdW = New StreamWriter(RCHCmd)
            dt = cls.GetMstStaff
            For Each dr As DataRow In dt.Rows
                Dim str As String = dr("StaffCode").ToString

                RCHCmdW.WriteLine(str)
            Next
            RCHCmdW.Close()
            RCHCmd.Close()
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Creat mststaff.txt OK" & vbCrLf

            RCHCmd = New FileStream(INI.InterfaceMst & INI.DockAuditMstQCFileName, FileMode.OpenOrCreate, FileAccess.Write)
            RCHCmdW = New StreamWriter(RCHCmd)
            dt = cls.GetMstQC
            For Each dr As DataRow In dt.Rows
                Dim str As String = dr("CheckID").ToString
                str = str & "|" & dr("FormatID").ToString
                str = str & "|" & dr("Desc1").ToString
                str = str & "|" & dr("Desc2").ToString
                str = str & "|" & dr("Desc3").ToString
                str = str.Replace(vbCrLf, "").Replace(vbCr, "").Replace(vbLf, "")
                RCHCmdW.WriteLine(str)
            Next
            RCHCmdW.Close()
            RCHCmd.Close()
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Creat mstqc.txt OK" & vbCrLf

            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Create master completed" & vbCrLf
            ChkCreateMaster = True

        Catch ex As Exception
            txtStatus.Text = "Create master fail"
            btnClose.Enabled = True
        End Try
    End Sub
    Private Sub SendMasterFile()
        txtStatus.Text &= "..." & vbCrLf
        txtStatus.Text &= "Sending master file" & vbCrLf
        DoingSendMaster = True

        Dim SendOK As Boolean = True
        Dim SlashForPC As String = "\"
        Dim SlashForHandy As String = "/"

        'Item
        Dim PCPath As String = INI.InterfaceMst & Replace(INI.DockAuditMstItemFileName, SlashForHandy, SlashForPC)
        Dim HandyFile As String = INI.DockAuditInterface & "/Mst" & Replace(INI.DockAuditMstItemFileName, SlashForPC, SlashForHandy)
        If ADBPushToAndroid(PCPath, HandyFile) = False Then
            SendOK = False
            GoTo Final
        End If

        'ModelDock
        PCPath = INI.InterfaceMst & INI.DockAuditMstModelDockFileName
        HandyFile = INI.DockAuditInterface & "/Mst" & INI.DockAuditMstModelDockFileName
        If ADBPushToAndroid(PCPath, HandyFile) = False Then
            SendOK = False
            GoTo Final
        End If

        'Part
        PCPath = INI.InterfaceMst & INI.DockAuditMstPartFileName
        HandyFile = INI.DockAuditInterface & "/Mst" & INI.DockAuditMstPartFileName
        If ADBPushToAndroid(PCPath, HandyFile) = False Then
            SendOK = False
            GoTo Final
        End If

        'Staff
        PCPath = INI.InterfaceMst & INI.DockAuditMstStaffFileName
        HandyFile = INI.DockAuditInterface & "/Mst" & INI.DockAuditMstStaffFileName
        If ADBPushToAndroid(PCPath, HandyFile) = False Then
            SendOK = False
            GoTo Final
        End If

        'QC
        PCPath = INI.InterfaceMst & INI.DockAuditMstQCFileName
        HandyFile = INI.DockAuditInterface & "/Mst" & INI.DockAuditMstQCFileName
        If ADBPushToAndroid(PCPath, HandyFile) = False Then
            SendOK = False
            GoTo Final
        End If

Final:
        If SendOK = True Then
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Send master completed" & vbCrLf
            chkSendMaster = True
        Else
            txtStatus.Text = "Send master fail"
        End If

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        TimeSync.Enabled = True
        btnStart.Enabled = False
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

    Function ExecuteCommand(ByVal fileName As String, ByVal arguments As String) As String
        Dim process As New Process()
        process.StartInfo.FileName = fileName
        process.StartInfo.Arguments = arguments
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.UseShellExecute = False
        process.StartInfo.CreateNoWindow = True

        process.Start()
        Dim output As String = process.StandardOutput.ReadToEnd()
        Dim errorOutput As String = process.StandardError.ReadToEnd()
        process.WaitForExit()

        ' Combine standard and error outputs
        Return output & errorOutput
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
End Class