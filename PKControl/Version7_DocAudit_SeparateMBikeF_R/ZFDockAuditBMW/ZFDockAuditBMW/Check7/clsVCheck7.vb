Imports System.Data
Imports System.Windows.Forms
Imports ZFDockAuditBMW.Barcode_System

Public Class clsVCheck7
    Private myScanSampleAPI As ZFDockAuditBMW.API = Nothing
    Private isReaderInitiated As Boolean = False
    Private myReadNotifyHandler As EventHandler = Nothing
    Private myStatusNotifyHandler As EventHandler = Nothing
    Private MyAudioController As Symbol.Audio.Controller = Nothing
    Private MyTerminalInfo As Symbol.ResourceCoordination.TerminalInfo = Nothing

    Private MoveActiveDateTime As DateTime
    Public dtGrid As DataTable = Nothing
    Public FirstShockBarcode As String

    Private Sub clsVCheck7_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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

    Private Sub clsVCheck7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : FinishClick()
            Case Keys.Escape : CancelClick()
        End Select
    End Sub
    Private Sub FinishClick()
        If dtGrid.Rows.Count = 0 Then
            MessageBox.Show("Please scan shock")
            Exit Sub
        Else
            Dim OK As Boolean = True
            For Each dr As DataRow In dtGrid.Select()
                If dr("Result").ToString = "NG" Then
                    OK = False
                End If
            Next
            If OK = True Then
                DialogResult = Windows.Forms.DialogResult.Yes
            Else
                DialogResult = Windows.Forms.DialogResult.No
            End If
        End If
    End Sub

    Private Sub CancelClick()
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub clsVCheck7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnFinish.Name : FinishClick()
                Case btnCancel.Name : CancelClick()
            End Select
        End If
    End Sub

    Private Sub clsVCheck7_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.myScanSampleAPI = New ZFDockAuditBMW.API()

        Me.isReaderInitiated = Me.myScanSampleAPI.InitReader()

        If Not Me.isReaderInitiated Then
            MessageBox.Show("Scanner Problem")
            CancelClick()
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
        dtGrid = New DataTable
        dtGrid.TableName = "ShockResult"
        dtGrid.Columns.Add("Barcode", GetType(String))
        dtGrid.Columns.Add("Result", GetType(String))
        '==============================
        Dim col0 As New DataGridTextBoxColumn
        col0.MappingName = "Barcode"
        col0.HeaderText = "Barcode"
        col0.Width = 200

        Dim col1 As New DataGridTextBoxColumn
        col1.MappingName = "Result"
        col1.HeaderText = "Result"
        col1.Width = 100

        Dim GridTBStyle As New DataGridTableStyle
        GridTBStyle.MappingName = "ShockResult"
        With GridTBStyle.GridColumnStyles
            .Add(col0)
            .Add(col1)
        End With
        grdData.TableStyles.Add(GridTBStyle)
        grdData.DataSource = dtGrid
        '==============================
        MoveActiveDateTime = Now

        Me.KeyPreview = True

        Timer1.Enabled = True
    End Sub
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
        If strQR.Length <> 15 Then
            PlayBeeb()
            MessageBox.Show("Please scan Shock")
        Else
            If dtGrid.Rows.Count = 0 Then
                If FirstShockBarcode <> strQR Then
                    PlayBeeb()
                    MessageBox.Show("Please scan shock no.1")
                Else
                    Dim sResult As String = Audit()
                    If sResult <> "" Then
                        AddBarcode(strQR, sResult)
                    End If
                End If
            Else
                If Strings.Left(FirstShockBarcode, 12) <> Strings.Left(strQR, 12) Or Strings.Right(FirstShockBarcode, 1) <> Strings.Right(strQR, 1) Then
                    PlayBeeb()
                    MessageBox.Show("Invalid Shock")
                Else
                    Dim chkDupplicate As Boolean = False
                    For Each drGrid As DataRow In dtGrid.Select()
                        If drGrid("Barcode").ToString = strQR Then
                            chkDupplicate = True
                            Exit For
                        End If
                    Next
                    If chkDupplicate = True Then
                        PlayBeeb()
                        MessageBox.Show("Duplicate Shock")
                    Else
                        Dim sResult As String = Audit()
                        If sResult <> "" Then
                            AddBarcode(strQR, sResult)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Function Audit() As String
        Dim PicBox As New AssetPicBox
        Dim sResult As String = ""
        PicBox.Location = New System.Drawing.Point(Me.Location.X, Me.Location.Y)
        If PicBox.ShowDialog = Windows.Forms.DialogResult.OK Then
            sResult = "OK"
        Else
            sResult = "NG"
        End If
        PicBox.Dispose()

        Return sResult
    End Function

    Private Sub AddBarcode(ByVal sBarcode As String, ByVal sResult As String)
        Dim drAdd As DataRow = dtGrid.NewRow
        drAdd("Barcode") = sBarcode
        drAdd("Result") = sResult

        dtGrid.Rows.Add(drAdd)
        grdData.DataSource = dtGrid
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

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        FinishClick()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        CancelClick()
    End Sub
End Class