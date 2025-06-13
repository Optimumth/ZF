Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports OBSWMC
Imports System.IO

Public Class clsVSyncronize
    Private cls As New clsCRackStatus
    Private OBSWMC As New OBSWMC.OBSWMC
    Private lsportableDevices As List(Of OBSWMC.PortableDevice)


    Private Sub clsVSyncronize_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        TimeSync.Enabled = True
    End Sub

    Private Sub clsVSyncronize_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Sync()
    End Sub

    Private Sub Sync()
        'If DeviceConnect() = False Then
        '    txtStatus.Text = "Device is not connected, please check cable"
        'ElseIf LoadTransaction() = False Then
        '    txtStatus.Text = "Load Transaction Error"
        'ElseIf UpdateTransaction() = False Then
        '    txtStatus.Text = "Update Transaction Error"
        'ElseIf CreateMasterFile() = False Then
        '    txtStatus.Text = "Create Master File Error"
        'ElseIf SendMasterFile() = False Then
        '    txtStatus.Text = "Send Master To Handy Error"
        'ElseIf BackupTransactionFile() = False Then
        '    txtStatus.Text = "Backup Transfer file Error"
        'Else
        '    txtStatus.Text = "Syncronize successfully"
        'End If


        If DeviceConnect() = False Then
            txtStatus.Text = "Device is not connected, please check cable"
        ElseIf LoadTransaction() = False Then
            txtStatus.Text = "Load Transaction Error"
        ElseIf UpdateTransaction() = False Then
            txtStatus.Text = "Update Transaction Error"
        ElseIf CreateMasterFile() = False Then
            txtStatus.Text = "Create Master File Error"
        ElseIf SendMasterFile() = False Then
            txtStatus.Text = "Send Master To Handy Error"
        Else
            txtStatus.Text = "Please press Sync at handy then click Next"
            btnOperation.Text = "Wait"
            btnOperation.Enabled = False
            TimeSync.Start()
        End If
    End Sub

    Private Function DeviceConnect() As Boolean
        lsportableDevices = OBSWMC.getDevices()
        If lsportableDevices.Count <= 0 Then Return False
        'MC92000
        Dim iPortable As Integer = -1
        For iLoop As Integer = 0 To lsportableDevices.Count - 1
            If InStr(lsportableDevices(iLoop).Name.ToUpper, "MC92000", CompareMethod.Text) Then
                iPortable = iLoop
            End If
        Next

        OBSWMC.PortableDevice = lsportableDevices(iPortable)
        If OBSWMC.Connect() Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function LoadTransaction() As Boolean
        'File from handy
        'ID,RackDTID,StaffCode,Rack,Ramark,Model,Code,Running,ScanDateTime,From,To

        Return True
    End Function

    Private Function UpdateTransaction() As Boolean

        Return True
    End Function
    Private Function CreateMasterFile() As Boolean
        'RackDTID,Rack,Remark,Model,Code,Running,Current
        'ScanDateTiem,Model,Code,RackNo,RackStatus,ColorA,ColorR,ColorG,ColorB,RackDTID
        Try
            Dim dt As DataTable = cls.GetData(False, 0 _
                                           , False, "" _
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

            Return True

        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function
    Private Function SendMasterFile() As Boolean
        Dim PCPath As String = INI.InterfaceMst & INI.MstFilename
        Dim HandyFile As String = INI.MstHandyPath & INI.MstFilename


        Dim obj As Object = OBSWMC.getFile(HandyFile)
        If Not obj Is Nothing Then
            OBSWMC.DeleteFile(HandyFile)
            If (String.IsNullOrEmpty(OBSWMC.Err)) = False Then
                Return False
            End If
        End If

        OBSWMC.CopyFileToDevice(PCPath, INI.MstHandyPath)
        If (String.IsNullOrEmpty(OBSWMC.Err)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function BackupTransactionFile() As Boolean
        Return True
    End Function

    
    Private Sub btnSync_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSync.Click
        Sync()
    End Sub

    Private Sub btnOperation_Click(sender As System.Object, e As System.EventArgs) Handles btnOperation.Click
        Me.Close()
    End Sub

    Private Sub TimeSync_Tick(sender As Object, e As System.EventArgs) Handles TimeSync.Tick
        If HandyMasterFinish() = True Then
            TimeSync.Stop()
        End If
    End Sub

    Private Function HandyMasterFinish() As Boolean
        Dim HandyFile As String = INI.MstHandyPath & INI.MstFilename
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