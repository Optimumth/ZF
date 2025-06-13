Imports System.Data
Imports System.Windows.Forms
Imports ZFPKCtrlBMW.Barcode_System

Public Class clsVTruckdetail
    Private myScanSampleAPI As ZFPKCtrlBMW.API = Nothing
    Private isReaderInitiated As Boolean = False

    Private myReadNotifyHandler As EventHandler = Nothing
    Private myStatusNotifyHandler As EventHandler = Nothing

    Private MyAudioController As Symbol.Audio.Controller = Nothing
    Private MyTerminalInfo As Symbol.ResourceCoordination.TerminalInfo = Nothing

    'Private iFocused As Integer = 0
    Private cls As New clsCTruckDetail
    Public TruckID As String = ""
    Private MoveActiveDateTime As DateTime

    Private Enum eQR
        Model = 1
        Varian = 2
        Lot = 3
        DeliveryNoteNo = 4
        AxleNo = 5
    End Enum

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
        Dim strQR As String = TheReaderData.Text
        Dim strData() As String = Strings.Split(strQR, "|")
        If Not (strData.Length = 3) Then
            PlayBeeb()
            MessageBox.Show("Invalid QR Code")
            Exit Sub
        End If

        If Not IsNumeric(strData(0)) Then
            PlayBeeb()
            MessageBox.Show("Invalid QR Code")
            Exit Sub
        End If

        Dim QRIndex As Integer = Convert.ToInt16(strData(0))
        Select Case QRIndex
            Case eQR.Model : txtModel.Text = strData(2)
            Case eQR.Varian : txtVarian.Text = strData(2)
            Case eQR.Lot : txtLot.Text = strData(2)
            Case eQR.DeliveryNoteNo : txtDeliveryNoteNo.Text = strData(2)
            Case eQR.AxleNo : txtAxleNo.Text = strData(2)
            Case Else
                PlayBeeb()
                MessageBox.Show("Invalid QR Code")
                Exit Sub
        End Select
    End Sub

    Private Sub clsVTruckdetail_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Timer1.Enabled = False
        If isReaderInitiated Then
            myScanSampleAPI.DetachReadNotify()
            myScanSampleAPI.DetachStatusNotify()
            myScanSampleAPI.TermReader()
        End If
        Me.MyAudioController.Dispose()
    End Sub
    Private Sub clsVTruckdetail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnExit.KeyUp, btnSave.KeyUp _
          , txtModel.KeyUp, txtVarian.KeyUp, txtLot.KeyUp, txtDeliveryNoteNo.KeyUp, txtAxleNo.KeyUp

        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : SaveClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub chkAxleStatus_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.F4 : SaveClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub

    Private Sub clsVTruckdetail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click, btnSave.Click
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

    Private Sub SaveClick()
        If btnSave.Enabled = False Then Exit Sub

        SaveData()
    End Sub
    Private Sub ExitClick()
        CloseForm()
    End Sub
    Private Sub CloseForm()
        Me.Close()
    End Sub
    Private Sub SaveData()
        If cls.SaveData(TruckID, txtModel.Text.Trim, txtVarian.Text.Trim, txtLot.Text.Trim, txtDeliveryNoteNo.Text.Trim, txtAxleNo.Text.Trim) = False Then
            PlayBeeb()
            MessageBox.Show("FAIL!!!")
        Else
            CloseForm()
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

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ExitClick()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveClick()
    End Sub

    Private Sub clsVTruckdetail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.myScanSampleAPI = New ZFPKCtrlBMW.API()

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

        MoveActiveDateTime = Now

        Dim dt As DataTable = clsCTruckDetail.GetPrgTruckToday(TruckID)
        If dt.Rows.Count > 0 Then
            txtModel.Text = dt.Rows(0)("Model").ToString
            txtVarian.Text = dt.Rows(0)("Varian").ToString
            txtLot.Text = dt.Rows(0)("Lot").ToString
            txtDeliveryNoteNo.Text = dt.Rows(0)("DeliveryNoteNo").ToString
            txtAxleNo.Text = dt.Rows(0)("AxleNo").ToString
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        clsCLogin.ActiveDateTime = Now 'ทำทุกเคส ไม่ต้องการรัน Log in

        Dim CheckLogout As Boolean = True
        If CheckLogout = True Then
            If DateDiff(DateInterval.Minute, MoveActiveDateTime, Now()) > clsCLogin.AutoLogoutMin Then
                Me.Close()
            End If
        Else
            MoveActiveDateTime = Now
        End If

    End Sub
End Class