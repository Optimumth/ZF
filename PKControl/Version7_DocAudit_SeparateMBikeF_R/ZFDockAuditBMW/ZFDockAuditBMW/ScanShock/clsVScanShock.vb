Imports System.Data
Imports System.Windows.Forms
Imports ZFDockAuditBMW.Barcode_System

Public Class clsVScanShock
    Private myScanSampleAPI As ZFDockAuditBMW.API = Nothing
    Private isReaderInitiated As Boolean = False
    Private myReadNotifyHandler As EventHandler = Nothing
    Private myStatusNotifyHandler As EventHandler = Nothing
    Private MyAudioController As Symbol.Audio.Controller = Nothing
    Private MyTerminalInfo As Symbol.ResourceCoordination.TerminalInfo = Nothing
    Private MoveActiveDateTime As DateTime

    Private DisableLable As System.Drawing.Color = Drawing.Color.Gray
    Private EnableLable As System.Drawing.Color = Drawing.Color.Black

    Private DisableText As System.Drawing.Color = Drawing.Color.PaleGreen
    Private EnableText As System.Drawing.Color = Drawing.Color.Blue
    Private OKText As System.Drawing.Color = Drawing.Color.Green
    Private NGText As System.Drawing.Color = Drawing.Color.Red

    Private RackDTID As Integer
    Private ModelDockID As Integer
    Private dtDockAuditShock As DataTable

    Public Enum eQR4
        Rack = 0
        Model = 1
        Code = 2
        Running = 3
    End Enum

    Public Enum eQR5
        Rack = 0
        Remark = 1
        Model = 2
        Code = 3
        Running = 4
    End Enum

    Public Enum CheckStatus
        NotUse = -1
        OK = 0
        NG = 1
    End Enum

    Public Enum AxleShockStatus
        Axle = 1
        Shock = 2
    End Enum

#Region "Form_Event"
    Private Sub clsVScanShock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click, btnSave.Click
        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnSave.Name
                    SaveClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub

    Private Sub clsVScanShock_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            If isReaderInitiated Then
                myScanSampleAPI.DetachReadNotify()
                myScanSampleAPI.DetachStatusNotify()
                myScanSampleAPI.TermReader()
                Me.MyAudioController.Dispose()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub clsVScanShock_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : SaveClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub

    Private Sub clsVScanShock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.myScanSampleAPI = New ZFDockAuditBMW.API()

        Me.isReaderInitiated = Me.myScanSampleAPI.InitReader()

        If Not Me.isReaderInitiated Then
            CloseForm()
        Else
            Me.myStatusNotifyHandler = New EventHandler(AddressOf myReader_StatusNotify)
            myScanSampleAPI.AttachStatusNotify(myStatusNotifyHandler)

            myScanSampleAPI.StartRead(False)
            Me.myReadNotifyHandler = New System.EventHandler(AddressOf Me.myReader_ReadNotify)
            myScanSampleAPI.AttachReadNotify(myReadNotifyHandler)
        End If
        '==================================================================
        Dim MyDevice As Symbol.Audio.Device = _
        CType(Symbol.StandardForms.SelectDevice.Select( _
        Symbol.Audio.Controller.Title, _
        Symbol.Audio.Device.AvailableDevices), Symbol.Audio.Device)

        If (MyDevice Is Nothing) Then

            MessageBox.Show("No Device Selected", "SelectDevice")
            Me.Close()

            Return

        End If

        'check the device type
        Select Case (MyDevice.AudioType)

            Case Symbol.Audio.AudioType.StandardAudio

                MyAudioController = New Symbol.Audio.StandardAudio(MyDevice)

            Case Symbol.Audio.AudioType.SimulatedAudio

                MyAudioController = New Symbol.Audio.SimulatedAudio(MyDevice)


            Case Else

                Throw New Symbol.Exceptions.InvalidDataTypeException("Unknown Device Type")


        End Select

        ' check for the presence of speaker
        MyTerminalInfo = New Symbol.ResourceCoordination.TerminalInfo

        '==================================================================

        ClearScreen()
        Me.KeyPreview = True

        Me.Focus()

        ActiveTimer.Enabled = True
        MoveActiveDateTime = Now
    End Sub
#End Region

#Region "Clear Screen"
    Private Sub ClearScreen()
        RackDTID = 0
        ModelDockID = 0

        txtModelRack.Text = ""
        txtItem.Text = ""
        txtArea.Text = ""
        txtBarcode.Text = ""
        txtModelDock.Text = ""
        txtShockNo.Text = ""
        txtSide.Text = ""
        txtCheck5.Text = ""
        txtCheck6.Text = ""
        txtCheck7.Text = ""

        lblCheck5.ForeColor = Drawing.Color.Gray
        lblCheck6.ForeColor = Drawing.Color.Gray
        lblCheck7.ForeColor = Drawing.Color.Gray
        txtCheck5.BackColor = DisableText
        txtCheck6.BackColor = DisableText
        txtCheck7.BackColor = DisableText

        btnSave.Enabled = False
    End Sub
#End Region

#Region "Scan Action"
    Private Sub myReader_ReadNotify(ByVal Sender As Object, ByVal e As EventArgs)
        If Me.InvokeRequired Then
            ' Executes the ReadNotify delegate on the main thread
            Me.Invoke(myReadNotifyHandler, New Object() {Sender, e})

        Else

            ' Get ReaderData
            Dim TheReaderData As Symbol.Barcode.ReaderData = Me.myScanSampleAPI.Reader.GetNextReaderData()

            Select Case TheReaderData.Result

                Case Symbol.Results.SUCCESS
                    HandleData(TheReaderData)
                    Me.myScanSampleAPI.StartRead(False)
            End Select
        End If
    End Sub 'myReader_ReadNotify

    Private Sub myReader_StatusNotify(ByVal Sender As Object, ByVal e As EventArgs)
        ' Checks if the Invoke method is required because the StatusNotify delegate is called by a different thread
        If Me.InvokeRequired Then
            ' Executes the StatusNotify delegate on the main thread
            Me.Invoke(myStatusNotifyHandler, New Object() {Sender, e})

        Else
            ' Get ReaderData
            Dim TheStatusData As Symbol.Barcode.BarcodeStatus = Me.myScanSampleAPI.Reader.GetNextStatus()
        End If
    End Sub 'myReader_StatusNotify

    Private Sub HandleData(ByVal TheReaderData As Symbol.Barcode.ReaderData)
        clsCLogin.ActiveDateTime = Now

        Dim strQR As String = TheReaderData.Text
        If strQR = "" Then
            PlayBeeb()
            MessageBox.Show("Invalid QR Code")
        End If

        Dim strData() As String = Strings.Split(strQR, "|")
        If txtModelRack.Text.Trim = "" Then
            If Not (strData.Length = 4 Or strData.Length = 5) Then
                PlayBeeb()
                MessageBox.Show("Please scan Rack")
            Else
                Dim Rack As String = ""
                Dim Remark As String = ""
                Dim Model As String = ""
                Dim Code As String = ""
                Dim Running As String = ""
                If strData.Length = 4 Then
                    If Not IsDBNull(strData(eQR4.Rack)) Then Rack = strData(eQR4.Rack)
                    Remark = ""
                    If Not IsDBNull(strData(eQR4.Model)) Then Model = strData(eQR4.Model)
                    If Not IsDBNull(strData(eQR4.Code)) Then Code = strData(eQR4.Code)
                    If Not IsDBNull(strData(eQR4.Running)) Then Running = strData(eQR4.Running)
                Else
                    If Not IsDBNull(strData(eQR5.Rack)) Then Rack = strData(eQR5.Rack)
                    If Not IsDBNull(strData(eQR5.Remark)) Then Remark = strData(eQR5.Remark)
                    If Not IsDBNull(strData(eQR5.Model)) Then Model = strData(eQR5.Model)
                    If Not IsDBNull(strData(eQR5.Code)) Then Code = strData(eQR5.Code)
                    If Not IsDBNull(strData(eQR5.Running)) Then Running = strData(eQR5.Running)
                End If

                Dim dtMstItem As DataTable = clsCScanAxle.GetMstItem(Rack, Remark, Model, Code, Running)
                If Not dtMstItem Is Nothing Then
                    If dtMstItem.Rows.Count > 0 Then
                        RackDTID = CInt(dtMstItem.Rows(0)("RackDTID"))
                        Dim sArea As String = ""
                        sArea = Strings.Left(Running, 1)

                        Dim dtModelDock As DataTable = clsCScanShock.GetModelDock(Model, sArea)
                        If dtModelDock.Rows.Count = 0 Then
                            PlayBeeb()
                            MessageBox.Show("Please check master model dock")
                        Else
                            If dtModelDock.Rows.Count > 1 Then
                                Dim frm As New clsVModelDockList
                                frm.dtGrid = dtModelDock.Copy
                                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                    txtModelRack.Text = Model
                                    txtItem.Text = Code & Running
                                    txtModelDock.Text = frm.mModelDock
                                Else
                                    PlayBeeb()
                                    MessageBox.Show("Please select Model Dock")
                                End If
                            Else
                                txtModelRack.Text = Model
                                txtItem.Text = Code & Running
                                txtModelDock.Text = dtModelDock.Rows(0)("ModelDock").ToString
                            End If
                            txtArea.Text = sArea

                            Dim dtTB As DataTable = clsCScanAxle.tbModelDock(txtModelRack.Text.Trim, txtModelDock.Text.Trim, txtArea.Text)
                            Dim drTB As DataRow = dtTB.Rows(0)
                            ModelDockID = CInt(drTB("ModelDockID"))
                            If CInt(drTB("Check5")) = 1 Then
                                txtCheck5.BackColor = EnableText
                            End If
                            If CInt(drTB("Check6")) = 1 Then
                                txtCheck6.BackColor = EnableText
                            End If
                            If CInt(drTB("Check7")) = 1 Then
                                txtCheck7.BackColor = EnableText
                            End If
                        End If
                    Else
                        PlayBeeb()
                        MessageBox.Show("Rack not found")
                    End If
                End If
            End If
        Else
            If Not (strData.Length = 1 And strData(0).Length = 15) Then 'Sample = 7544EEB7404401L
                PlayBeeb()
                MessageBox.Show("Please scan product")
            Else
                If txtBarcode.Text.Trim = "" Then
                    Dim tmpBarcode As String = strData(0).ToString
                    Dim tmpShockNo As String = Strings.Mid(strData(0).ToString, 13, 2)
                    Dim tmpSide As String = Strings.Right(strData(0).ToString, 1)
                    If tmpShockNo <> "01" Then
                        PlayBeeb()
                        MessageBox.Show("Please scan shock no. 1")
                    Else
                        If chkComplete() = True Then
                            PlayBeeb()
                            MessageBox.Show("Completed Item, please change")
                        Else
                            Dim iAxleShock As Integer = AxleShockStatus.Shock
                            If clsCScanShock.CheckPrgCompleted(strData(0).ToString) = True Then
                                PlayBeeb()
                                MessageBox.Show("Completed Item, please change")
                            Else
                                txtBarcode.Text = tmpBarcode
                                txtShockNo.Text = tmpShockNo
                                txtSide.Text = tmpSide
                                Audit()
                            End If
                        End If
                    End If
                Else
                    If txtBarcode.Text.Trim = strData(0).ToString Then
                        Audit()
                    Else
                        PlayBeeb()
                        MessageBox.Show("Invalid Shock")
                    End If
                End If
            End If
        End If
        Me.Focus()
    End Sub

    Private Function chkComplete() As Boolean
        Dim Completed As Boolean
        If txtCheck5.Text.Trim = "" And txtCheck6.Text.Trim = "" And txtCheck7.Text.Trim = "" Then
            Completed = False
        Else
            If txtCheck5.BackColor = EnableText And txtCheck5.Text.Trim = "" Then
                Completed = False
            ElseIf txtCheck6.BackColor = EnableText And txtCheck6.Text.Trim = "" Then
                Completed = False
            ElseIf txtCheck7.BackColor = EnableText And txtCheck7.Text.Trim = "" Then
                Completed = False
            Else
                btnSave.Enabled = True
                Completed = True
            End If
        End If
    End Function

    Private Sub Audit()
        Dim iCheck As Integer = 0
        If txtCheck5.BackColor = EnableText And txtCheck5.Text.Trim = "" Then
            iCheck = 5
        ElseIf txtCheck6.BackColor = EnableText And txtCheck6.Text.Trim = "" Then
            iCheck = 6
        ElseIf txtCheck7.BackColor = EnableText And txtCheck7.Text.Trim = "" Then
            iCheck = 7
        Else
            PlayBeeb()
            MessageBox.Show("Audit Complete")
        End If

        If iCheck >= 5 Then
            Dim sResult As String = ""
            If iCheck = 5 Or iCheck = 6 Then
                Dim PicBox As New AssetPicBox

                PicBox.Location = New System.Drawing.Point(Me.Location.X, Me.Location.Y)
                If PicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
                    sResult = "OK"
                Else
                    sResult = "NG"
                End If
                PicBox.Dispose()
            Else
                Dim frm As New clsVCheck7
                frm.Location = New System.Drawing.Point(Me.Location.X, Me.Location.Y)
                frm.FirstShockBarcode = txtBarcode.Text.Trim
                Dim dResult As Windows.Forms.DialogResult = frm.ShowDialog
                If dResult = Windows.Forms.DialogResult.Yes Then
                    sResult = "OK"
                    dtDockAuditShock = frm.dtGrid
                ElseIf dResult = Windows.Forms.DialogResult.No Then
                    sResult = "NG"
                    dtDockAuditShock = frm.dtGrid
                Else
                    sResult = ""
                End If
                frm.Dispose()
            End If
            If sResult <> "" Then
                Select Case iCheck
                    Case 5
                        txtCheck5.Text = sResult
                        If sResult = "OK" Then
                            txtCheck5.BackColor = OKText
                        Else
                            txtCheck5.BackColor = NGText
                        End If
                    Case 6
                        txtCheck6.Text = sResult
                        If sResult = "OK" Then
                            txtCheck6.BackColor = OKText
                        Else
                            txtCheck6.BackColor = NGText
                        End If
                    Case 7
                        txtCheck7.Text = sResult
                        If sResult = "OK" Then
                            txtCheck7.BackColor = OKText
                        ElseIf sResult = "NG" Then
                            txtCheck7.BackColor = NGText
                        End If
                End Select
                If iCheck = 7 And sResult <> "" Then
                    chkComplete()
                End If
            End If
        End If
    End Sub

    Private Sub PlayBeeb()
        Dim Duration As Integer = 1000 'millisec
        Dim Frequency As Integer = 2670 'hz

        Try
            Me.MyAudioController.PlayAudio(Duration, Frequency) 'play Default beep

        Catch ex As Exception
            MessageBox.Show("PlayAudio failed. Hardware may not be present", "PlayAudio")

        End Try
    End Sub

    Private Sub PlayBeebShort()
        Dim Duration As Integer = 500 'millisec
        Dim Frequency As Integer = 2670 'hz

        Try
            Me.MyAudioController.PlayAudio(Duration, Frequency) 'play Default beep

        Catch ex As Exception

            MessageBox.Show("PlayAudio failed. Hardware may not be present", "PlayAudio")

        End Try
    End Sub
#End Region

#Region "Save"
    Private Sub SaveClick()
        '-1 = NotUse, 0 = OK, 1 = NG
        Dim Check1 As Integer = CheckStatus.NotUse
        Dim Check2 As Integer = CheckStatus.NotUse
        Dim Check3 As Integer = CheckStatus.NotUse
        Dim Check4 As Integer = CheckStatus.NotUse
        Dim Check5 As Integer = CheckStatus.NotUse
        Dim Check6 As Integer = CheckStatus.NotUse
        Dim Check7 As Integer = CheckStatus.NotUse

        If txtCheck5.BackColor = OKText Then
            Check5 = CheckStatus.OK
        ElseIf txtCheck5.BackColor = NGText Then
            Check5 = CheckStatus.NG
        End If
        If txtCheck6.BackColor = OKText Then
            Check6 = CheckStatus.OK
        ElseIf txtCheck6.BackColor = NGText Then
            Check6 = CheckStatus.NG
        End If
        If txtCheck7.BackColor = OKText Then
            Check7 = CheckStatus.OK
        ElseIf txtCheck7.BackColor = NGText Then
            Check7 = CheckStatus.NG
        End If

        Dim CompleteFlag As Integer = 1
        If Check5 = CheckStatus.NG Then
            CompleteFlag = 0
        ElseIf Check6 = CheckStatus.NG Then
            CompleteFlag = 0
        ElseIf Check7 = CheckStatus.NG Then
            CompleteFlag = 0
        End If

        Dim AxleShock As Integer = AxleShockStatus.Shock
        Dim sql As String = "insert into PrgDockAudit( "
        sql &= " RackDTID, ModelDockID, Varian, Lot, AxleNo, Side, Barcode, AxleShock "
        sql &= " ,Check1, Check2, Check3, Check4, Check5, Check6, Check7 "
        sql &= " ,StaffCode, ScanDateTime, CompleteFlag"
        sql &= ")"
        sql &= " select " & RackDTID & ", " & ModelDockID & ", '','','','','" & txtBarcode.Text.Trim & "'," & AxleShock & ""
        sql &= " ," & Check1 & "," & Check2 & "," & Check3 & "," & Check4 & "," & Check5 & ", " & Check6 & "," & Check7 & ""
        sql &= " ,'" & P_Sys.StaffID & "','" & Format(Now(), "yyyy-MM-dd HH:mm:ss") & "'," & CompleteFlag & ""

        If P_DB.runSQLCE(sql) = False Then
            MessageBox.Show("Save Error")
        Else
            For Each drShock As DataRow In dtDockAuditShock.Select()
                sql = "insert into PrgDockAuditShock(BarcodeHD,Barcode,Result)"
                sql &= " select '" & txtBarcode.Text.Trim & "', '" & drShock("Barcode").ToString & "','" & drShock("Result").ToString & "'"
                Dim SaveOK As Boolean = P_DB.runSQLCE(sql)
                If SaveOK = False Then
                    MessageBox.Show("Save Error")
                    Exit Sub
                End If
            Next
            MessageBox.Show("Save Successfull")
            ClearScreen()
        End If
    End Sub
#End Region

#Region "Exit"
    Private Sub ExitClick()
        CloseForm()
    End Sub
    Private Sub CloseForm()
        Me.Close()
    End Sub

#End Region
    Private Sub ActiveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveTimer.Tick
        If clsCLogin.CheckActive = True Then Exit Sub

        ActiveTimer.Enabled = False
        If clsCLogin.ReLogin = True Then
            clsCLogin.ActiveDateTime = Now
            ActiveTimer.Enabled = True
        Else
            If isReaderInitiated Then
                myScanSampleAPI.DetachReadNotify()
                myScanSampleAPI.DetachStatusNotify()
                myScanSampleAPI.TermReader()
                Me.MyAudioController.Dispose()

                isReaderInitiated = False
            End If
            Me.Close()
        End If
    End Sub
End Class