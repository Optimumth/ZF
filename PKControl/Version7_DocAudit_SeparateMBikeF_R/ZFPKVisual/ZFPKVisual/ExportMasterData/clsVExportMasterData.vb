Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports OBSWMC
Imports System.IO

Public Class clsVExportMasterData
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


    Private Sub clsVExportMasterData_Load(sender As Object, e As System.EventArgs) Handles Me.Load
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
        lsportableDevices = OBSWMC.getDevices()
        If lsportableDevices.Count <= 0 Then Exit Sub
        'MC92000
        Dim iPortable As Integer = -1
        For iLoop As Integer = 0 To lsportableDevices.Count - 1
            If Not lsportableDevices(iLoop).Name Is Nothing Then
                If InStr(lsportableDevices(iLoop).Name.ToUpper, "MC92000", CompareMethod.Text) Then
                    iPortable = iLoop
                End If
            End If
        Next

        OBSWMC.PortableDevice = lsportableDevices(iPortable)
        If OBSWMC.Connect() Then
            Dim HandyFile As String = INI.DockAuditInterface & "/Mst/mstitem.txt"
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

            HandyFile = INI.DockAuditInterface & "/Mst/mstmodeldock.txt"
            obj = OBSWMC.getFile(HandyFile)
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

            HandyFile = INI.DockAuditInterface & "/Mst/mstpart.txt"
            obj = OBSWMC.getFile(HandyFile)
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

            HandyFile = INI.DockAuditInterface & "/Mst/mststaff.txt"
            obj = OBSWMC.getFile(HandyFile)
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

            ChkDeviceConnect = True
            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "MC92000 is now connected" & vbCrLf
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
                str = str & "|" & dr("Check1").ToString
                str = str & "|" & dr("Check2").ToString
                str = str & "|" & dr("Check3").ToString
                str = str & "|" & dr("Check4").ToString
                str = str & "|" & dr("Check5").ToString
                str = str & "|" & dr("Check6").ToString
                str = str & "|" & dr("Check7").ToString
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

            txtStatus.Text &= "..." & vbCrLf
            txtStatus.Text &= "Create master completed" & vbCrLf
            ChkCreateMaster = True

        Catch ex As Exception
            txtStatus.Text = "Create master fail"
        End Try

    End Sub
    Private Sub SendMasterFile()
        txtStatus.Text &= "..." & vbCrLf
        txtStatus.Text &= "Sending master file" & vbCrLf
        DoingSendMaster = True

        Dim SendOK As Boolean = True

        'Item
        Dim PCPath As String = INI.InterfaceMst & INI.DockAuditMstItemFileName
        Dim HandyFile As String = INI.DockAuditInterface & "/Mst" & INI.DockAuditMstItemFileName
        Dim obj As Object = OBSWMC.getFile(HandyFile)
        If Not obj Is Nothing Then
            OBSWMC.DeleteFile(HandyFile)
            If (String.IsNullOrEmpty(OBSWMC.Err)) = False Then
                SendOK = False
                GoTo Final
            End If
        End If
        OBSWMC.CopyFileToDevice(PCPath, INI.DockAuditInterface & "/Mst")
        If Not (String.IsNullOrEmpty(OBSWMC.Err)) Then
            SendOK = False
            GoTo Final
        End If

        'ModelDock
        PCPath = INI.InterfaceMst & INI.DockAuditMstModelDockFileName
        HandyFile = INI.DockAuditInterface & "/Mst" & INI.DockAuditMstModelDockFileName
        obj = Nothing : obj = OBSWMC.getFile(HandyFile)
        If Not obj Is Nothing Then
            OBSWMC.DeleteFile(HandyFile)
            If (String.IsNullOrEmpty(OBSWMC.Err)) = False Then
                SendOK = False
                GoTo Final
            End If
        End If
        OBSWMC.CopyFileToDevice(PCPath, INI.DockAuditInterface & "/Mst")
        If Not (String.IsNullOrEmpty(OBSWMC.Err)) Then
            SendOK = False
            GoTo Final
        End If

        'Part
        PCPath = INI.InterfaceMst & INI.DockAuditMstPartFileName
        HandyFile = INI.DockAuditInterface & "/Mst" & INI.DockAuditMstPartFileName
        obj = Nothing : obj = OBSWMC.getFile(HandyFile)
        If Not obj Is Nothing Then
            OBSWMC.DeleteFile(HandyFile)
            If (String.IsNullOrEmpty(OBSWMC.Err)) = False Then
                SendOK = False
                GoTo Final
            End If
        End If
        OBSWMC.CopyFileToDevice(PCPath, INI.DockAuditInterface & "/Mst")
        If Not (String.IsNullOrEmpty(OBSWMC.Err)) Then
            SendOK = False
            GoTo Final
        End If

        'Staff
        PCPath = INI.InterfaceMst & INI.DockAuditMstStaffFileName
        HandyFile = INI.DockAuditInterface & "/Mst" & INI.DockAuditMstStaffFileName
        obj = Nothing : obj = OBSWMC.getFile(HandyFile)
        If Not obj Is Nothing Then
            OBSWMC.DeleteFile(HandyFile)
            If (String.IsNullOrEmpty(OBSWMC.Err)) = False Then
                SendOK = False
                GoTo Final
            End If
        End If
        OBSWMC.CopyFileToDevice(PCPath, INI.DockAuditInterface & "/Mst")
        If Not (String.IsNullOrEmpty(OBSWMC.Err)) Then
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
End Class