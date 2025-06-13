Imports System.Data
Imports System.Windows.Forms
Imports ZFDockAuditBMW.Barcode_System
Imports System.Drawing

Public Class clsVScanAxle
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
    Private Barcode As String
    Private InterfacePath As String

    Private Enum eQR4
        Rack = 0
        Model = 1
        Code = 2
        Running = 3
    End Enum

    Private Enum eQR5
        Rack = 0
        Remark = 1
        Model = 2
        Code = 3
        Running = 4
    End Enum

    Private Enum CheckStatus
        NotUse = -1
        OK = 0
        NG = 1
    End Enum

    Private Enum AxleShockStatus
        Axle = 1
        Shock = 2
    End Enum

#Region "Form_Event"
    Private Sub clsVScanAxle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click, btnSave.Click
        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnSave.Name : SaveClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub

    Private Sub clsVScanAxle_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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

    Private Sub clsVScanAxle_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : SaveClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub

    Private Sub clsVScanAxle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        ActiveTimer.Enabled = True
        MoveActiveDateTime = Now

        InterfacePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName().CodeBase) & "\Interface\"

        Me.Focus()
    End Sub
#End Region

#Region "Clear Screen"
    Private Sub ClearScreen()
        RackDTID = 0
        ModelDockID = 0
        Barcode = ""

        txtModelRack.Text = ""
        txtItem.Text = ""
        txtArea.Text = ""
        txtVariant.Text = ""
        txtLot.Text = ""
        txtAxle.Text = ""
        txtSide.Text = ""
        txtCheck1.Text = ""
        txtCheck2.Text = ""
        txtCheck3.Text = ""
        txtCheck4.Text = ""

        lblCheck1.ForeColor = Drawing.Color.Gray
        lblCheck2.ForeColor = Drawing.Color.Gray
        lblCheck3.ForeColor = Drawing.Color.Gray
        lblCheck4.ForeColor = Drawing.Color.Gray
        txtCheck1.BackColor = DisableText
        txtCheck2.BackColor = DisableText
        txtCheck3.BackColor = DisableText
        txtCheck4.BackColor = DisableText

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
                        Dim dtModelDoc As DataTable = clsCScanAxle.GetModelDock(Model)
                        If dtModelDoc.Rows.Count = 0 Then
                            PlayBeeb()
                            MessageBox.Show("Please check master model dock")
                        Else
                            If dtModelDoc.Rows.Count > 1 Then
                                Dim frm As New clsVModelDockList
                                frm.dtGrid = dtModelDoc.Copy
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
                                txtModelDock.Text = dtModelDoc.Rows(0)("ModelDock").ToString
                            End If
                        End If
                    Else
                        PlayBeeb()
                        MessageBox.Show("Rack not found")
                    End If
                End If
            End If
        Else
            If Not (strData.Length = 1 And strData(0).Length = 15) Then 'Sample = FA74FVA7401802X
                PlayBeeb()
                MessageBox.Show("Please scan axle")
            Else
                Dim sArea As String = Strings.Left(strData(0).ToString, 1)
                Dim sVariant As String = Strings.Mid(strData(0).ToString, 3, 6)
                Dim sLot As String = Strings.Mid(strData(0).ToString, 9, 4)
                Dim sAxle As String = Strings.Mid(strData(0).ToString, 13, 2)
                Dim sSide As String = Strings.Right(strData(0).ToString, 1)

                'Dim iCheck As Integer = 0

                If txtArea.Text.Trim = "" Then
                    Dim dtMstModelDock As DataTable = clsCScanAxle.tbModelDock(txtModelRack.Text.Trim, txtModelDock.Text.Trim, sArea)
                    If dtMstModelDock.Rows.Count = 0 Then
                        PlayBeeb()
                        MessageBox.Show("Invalid product")
                    Else
                        If chkComplete() = True Then
                            PlayBeeb()
                            MessageBox.Show("Completed Item, please change")
                        Else
                            Dim drMstModelDock As DataRow = dtMstModelDock.Rows(0)
                            ModelDockID = CInt(drMstModelDock("ModelDockID"))

                            Dim iAxleShock As Integer = AxleShockStatus.Axle
                            If clsCScanAxle.CheckPrgCompleted(RackDTID, ModelDockID, sVariant, sLot, sAxle, sSide, iAxleShock) = True Then
                                PlayBeeb()
                                MessageBox.Show("Completed Item, please change")
                            Else
                                Barcode = strData(0).ToString
                                txtArea.Text = sArea
                                txtVariant.Text = sVariant
                                txtLot.Text = sLot
                                txtAxle.Text = sAxle
                                txtSide.Text = sSide

                                If CInt(drMstModelDock("Check1")) = 0 Then
                                    lblCheck1.ForeColor = DisableLable
                                    txtCheck1.BackColor = DisableText
                                Else
                                    lblCheck1.ForeColor = EnableLable
                                    txtCheck1.BackColor = EnableText
                                End If
                                If CInt(drMstModelDock("Check2")) = 0 Then
                                    lblCheck2.ForeColor = DisableLable
                                    txtCheck2.BackColor = DisableText
                                Else
                                    lblCheck2.ForeColor = EnableLable
                                    txtCheck2.BackColor = EnableText
                                End If
                                If CInt(drMstModelDock("Check3")) = 0 Then
                                    lblCheck3.ForeColor = DisableLable
                                    txtCheck3.BackColor = DisableText
                                Else
                                    lblCheck3.ForeColor = EnableLable
                                    txtCheck3.BackColor = EnableText
                                End If
                                If CInt(drMstModelDock("Check4")) = 0 Then
                                    lblCheck4.ForeColor = DisableLable
                                    txtCheck4.BackColor = DisableText
                                Else
                                    lblCheck4.ForeColor = EnableLable
                                    txtCheck4.BackColor = EnableText
                                End If
                                Audit()
                            End If
                        End If
                    End If
                Else
                    If txtArea.Text.Trim = sArea And txtVariant.Text.Trim = sVariant And txtLot.Text.Trim = sLot And txtAxle.Text.Trim = sAxle And txtSide.Text.Trim = sSide Then
                        Audit()
                    Else
                        PlayBeeb()
                        MessageBox.Show("Invalid product")
                    End If
                End If
            End If
        End If
        Me.Focus()
    End Sub

    Private Function chkComplete() As Boolean
        Dim Completed As Boolean
        If txtCheck1.Text.Trim = "" And txtCheck2.Text.Trim = "" And txtCheck3.Text.Trim = "" And txtCheck4.Text.Trim = "" Then
            Completed = False
        Else
            If txtCheck1.BackColor = EnableText And txtCheck1.Text.Trim = "" Then
                Completed = False
            ElseIf txtCheck2.BackColor = EnableText And txtCheck2.Text.Trim = "" Then
                Completed = False
            ElseIf txtCheck3.BackColor = EnableText And txtCheck3.Text.Trim = "" Then
                Completed = False
            ElseIf txtCheck4.BackColor = EnableText And txtCheck4.Text.Trim = "" Then
                Completed = False
            Else
                btnSave.Enabled = True
                Completed = True
            End If
        End If
    End Function

    Private Sub Audit()
        Dim iCheck As Integer = 0
        If txtCheck1.BackColor = EnableText And txtCheck1.Text.Trim = "" Then
            iCheck = 1
        ElseIf txtCheck2.BackColor = EnableText And txtCheck2.Text.Trim = "" Then
            iCheck = 2
        ElseIf txtCheck3.BackColor = EnableText And txtCheck3.Text.Trim = "" Then
            iCheck = 3
        ElseIf txtCheck4.BackColor = EnableText And txtCheck4.Text.Trim = "" Then
            iCheck = 4
        Else
            PlayBeeb()
            MessageBox.Show("Audit Complete")
        End If

        If iCheck > 0 Then
            Dim PicBox As New AssetPicBox
            Dim sResult As String = ""
            Dim PicName As String = "Check" & iCheck.ToString & ".jpg"
            Try
                Dim bmp1 As New Bitmap(InterfacePath & "Pic\" & PicName)
                PicBox.AssyPic.Image = bmp1
            Catch ex As Exception

            End Try
            
            PicBox.Location = New System.Drawing.Point(Me.Location.X, Me.Location.Y)
            If PicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
                sResult = "OK"
            Else
                sResult = "NG"
            End If
            PicBox.Dispose()

            If sResult <> "" Then
                Select Case iCheck
                    Case 1
                        txtCheck1.Text = sResult
                        If sResult = "OK" Then
                            txtCheck1.BackColor = OKText
                        Else
                            txtCheck1.BackColor = NGText
                        End If
                    Case 2
                        txtCheck2.Text = sResult
                        If sResult = "OK" Then
                            txtCheck2.BackColor = OKText
                        Else
                            txtCheck2.BackColor = NGText
                        End If
                    Case 3
                        txtCheck3.Text = sResult
                        If sResult = "OK" Then
                            txtCheck3.BackColor = OKText
                        Else
                            txtCheck3.BackColor = NGText
                        End If
                    Case 4
                        txtCheck4.Text = sResult
                        If sResult = "OK" Then
                            txtCheck4.BackColor = OKText
                        Else
                            txtCheck4.BackColor = NGText
                        End If
                End Select
                If iCheck = 4 Then
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

        If txtCheck1.BackColor = OKText Then
            Check1 = CheckStatus.OK
        ElseIf txtCheck1.BackColor = NGText Then
            Check1 = CheckStatus.NG
        End If
        If txtCheck2.BackColor = OKText Then
            Check2 = CheckStatus.OK
        ElseIf txtCheck2.BackColor = NGText Then
            Check2 = CheckStatus.NG
        End If
        If txtCheck3.BackColor = OKText Then
            Check3 = CheckStatus.OK
        ElseIf txtCheck3.BackColor = NGText Then
            Check3 = CheckStatus.NG
        End If
        If txtCheck4.BackColor = OKText Then
            Check4 = CheckStatus.OK
        ElseIf txtCheck4.BackColor = NGText Then
            Check4 = CheckStatus.NG
        End If

        Dim CompleteFlag As Integer = 1
        If Check1 = CheckStatus.NG Then
            CompleteFlag = 0
        ElseIf Check2 = CheckStatus.NG Then
            CompleteFlag = 0
        ElseIf Check3 = CheckStatus.NG Then
            CompleteFlag = 0
        ElseIf Check4 = CheckStatus.NG Then
            CompleteFlag = 0
        End If

        Dim AxleShock As Integer = AxleShockStatus.Axle
        Dim sql As String = "insert into PrgDockAudit( "
        sql &= " RackDTID, ModelDockID, Varian, Lot, AxleNo, Side, Barcode, AxleShock "
        sql &= " ,Check1, Check2, Check3, Check4, Check5, Check6, Check7 "
        sql &= " ,StaffCode, ScanDateTime, CompleteFlag"
        sql &= ")"
        sql &= " select " & RackDTID & ", " & ModelDockID & ", '" & txtVariant.Text.Trim & "','" & txtLot.Text.Trim & "','" & txtAxle.Text.Trim & "','" & txtSide.Text.Trim & "','" & Barcode & "'," & AxleShock & ""
        sql &= " ," & Check1 & "," & Check2 & "," & Check3 & "," & Check4 & "," & Check5 & ", " & Check6 & "," & Check7 & ""
        sql &= " ,'" & P_Sys.StaffID & "','" & Format(Now(), "yyyy-MM-dd HH:mm:ss") & "'," & CompleteFlag & ""

        If P_DB.runSQLCE(sql) = False Then
            MessageBox.Show("Save Error")
        Else
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