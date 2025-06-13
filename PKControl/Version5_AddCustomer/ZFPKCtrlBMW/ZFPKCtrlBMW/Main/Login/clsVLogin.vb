Imports System.Windows.Forms

Public Class clsVLogin
    Private myScanSampleAPI As ZFPKCtrlBMW.API = Nothing
    Private isReaderInitiated As Boolean = False

    Private myReadNotifyHandler As EventHandler = Nothing
    Private myStatusNotifyHandler As EventHandler = Nothing

    Private Sub clsVLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Me.myScanSampleAPI = New ZFPKCtrlBMW.API()

        'Me.isReaderInitiated = Me.myScanSampleAPI.InitReader()

        If Not Me.isReaderInitiated Then
            CloseForm()
        Else
            Me.myStatusNotifyHandler = New EventHandler(AddressOf myReader_StatusNotify)
            myScanSampleAPI.AttachStatusNotify(myStatusNotifyHandler)

            myScanSampleAPI.StartRead(False)
            Me.myReadNotifyHandler = New System.EventHandler(AddressOf Me.myReader_ReadNotify)
            myScanSampleAPI.AttachReadNotify(myReadNotifyHandler)
        End If


        ''==========ข้างล่าง เอาออก
        'Dim StaffCode As String = "ZMBF0005|V223|ZFRACK|CMM|F005"
        'If clsCLogin.Login(StaffCode) = True Then
        '    Me.DialogResult = Windows.Forms.DialogResult.OK
        'Else
        '    MessageBox.Show("Invaild Login ID, please try again")
        'End If
    End Sub
    'Private Sub clsVLogin_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
    '    If isReaderInitiated Then
    '        myScanSampleAPI.DetachReadNotify()
    '        myScanSampleAPI.DetachStatusNotify()
    '        myScanSampleAPI.TermReader()
    '    End If
    'End Sub

    Private Sub clsVLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            clsCLogin.AutoLogoutMin = clsCLogin.GetAutoLogoutMin

        End If
    End Sub

    Private Sub clsVLogin_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If isReaderInitiated Then
            myScanSampleAPI.DetachReadNotify()
            myScanSampleAPI.DetachStatusNotify()
            myScanSampleAPI.TermReader()
        End If
    End Sub

    Private Sub clsVLogin_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnExit.KeyUp
        If e.KeyCode = Keys.Escape Then
            CloseForm()
        End If
    End Sub

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
        Dim StaffCode As String = TheReaderData.Text
        'StaffCode = "ZF13008"
        If clsCLogin.Login(StaffCode) = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Invaild Login ID, please try again")
        End If

    End Sub 'HandleData

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        CloseForm()
    End Sub

    Private Sub CloseForm()
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

   
End Class