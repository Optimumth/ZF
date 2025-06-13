Imports System.Data
Imports System.Windows.Forms
Imports ZF_PKCtrl.Barcode_System

Public Class clsVMove
    Private dtGrid As DataTable = Nothing

    Private myScanSampleAPI As ZF_PKCtrl.API = Nothing
    Private isReaderInitiated As Boolean = False

    Private myReadNotifyHandler As EventHandler = Nothing
    Private myStatusNotifyHandler As EventHandler = Nothing

    Private MyAudioController As Symbol.Audio.Controller = Nothing
    Private MyTerminalInfo As Symbol.ResourceCoordination.TerminalInfo = Nothing

    Private MoveActiveDateTime As DateTime

    Public mScanType As Integer = 0
    Public Enum eScanType
        All = 0
        MB = 1
        Sup = 2
        Ext = 3
    End Enum
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

#Region "Program Active"

    'Private Sub clsVMove_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '    If Not Me.isReaderInitiated Then
    '        CloseForm()
    '    Else
    '        Me.myStatusNotifyHandler = New EventHandler(AddressOf myReader_StatusNotify)
    '        myScanSampleAPI.AttachStatusNotify(myStatusNotifyHandler)

    '        myScanSampleAPI.StartRead(False)
    '        Me.myReadNotifyHandler = New System.EventHandler(AddressOf Me.myReader_ReadNotify)
    '        myScanSampleAPI.AttachReadNotify(myReadNotifyHandler)
    '    End If
    'End Sub

    'Private Sub clsVMove_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
    '    If isReaderInitiated Then
    '        myScanSampleAPI.DetachReadNotify()
    '        myScanSampleAPI.DetachStatusNotify()
    '        myScanSampleAPI.TermReader()
    '    End If
    'End Sub
    Private Sub clsVMove_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnExit.KeyUp, btnSave.KeyUp, btnDelete.KeyUp, grdData.KeyUp

        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : SaveClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub

    Private Sub clsVMove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click, btnSave.Click, btnDelete.Click
        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnSave.Name : SaveClick()
                Case btnDelete.Name : DeleteClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        clsCLogin.ActiveDateTime = Now 'ทำทุกเคส ไม่ต้องการรัน Log in

        Dim CheckLogout As Boolean = False
        If dtGrid Is Nothing Then CheckLogout = True
        If dtGrid.Rows.Count = 0 Then CheckLogout = True

        If CheckLogout = True Then
            If DateDiff(DateInterval.Minute, MoveActiveDateTime, Now()) > clsCLogin.AutoLogoutMin Then
                Me.Close()
            End If
        Else
            MoveActiveDateTime = Now
        End If

    End Sub
#End Region
#Region "Call Function"
    Private Sub DeleteClick()
        If grdData.CurrentRowIndex < 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) <> Windows.Forms.DialogResult.Yes Then
            grdData.Focus()
            Exit Sub
        Else
            grdData.Focus()
        End If

        Dim CurID As Integer = Convert.ToInt16(grdData(grdData.CurrentRowIndex, 0))
        Dim dtNew As DataTable = dtGrid.Clone
        Dim drNew As DataRow = Nothing

        Dim ID As Integer = 1
        Dim MaxIDDB As Integer = 0
        Dim dtPrgTrans As DataTable = clsCMove.GetPrgTrans(0, 0)
        If dtPrgTrans.Rows.Count > 0 Then
            For Each drPrgTrans As DataRow In dtPrgTrans.Select("", "ID Desc")
                ID = Convert.ToInt16(drPrgTrans("ID")) + 1
                Exit For
            Next
        End If

        For Each drTrans As DataRow In dtGrid.Select("", "ID")
            If Convert.ToInt16(drTrans("ID")) <> CurID Then
                drNew = dtNew.NewRow
                drNew("ScanType") = drTrans("ScanType")
                drNew("ID") = ID
                drNew("RackDTID") = drTrans("RackDTID")
                drNew("Rack") = drTrans("Rack")
                drNew("Remark") = drTrans("Remark")
                drNew("Model") = drTrans("Model")
                drNew("Code") = drTrans("Code")
                drNew("Running") = drTrans("Running")
                drNew("ScanDateTime") = drTrans("ScanDateTime")
                drNew("From") = drTrans("From")
                drNew("To") = drTrans("To")
                drNew("StaffCode") = drTrans("StaffCode")
                drNew("TruckID") = drTrans("TruckID")
                dtNew.Rows.Add(drNew)
                ID = ID + 1
            End If
        Next




        dtGrid = dtNew
        ShowGrid()
    End Sub
    Private Sub SaveClick()
        If btnSave.Enabled = False Then Exit Sub


        If MessageBox.Show("Do you want to save?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            SaveData()
            grdData.Focus()
        Else
            grdData.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub ExitClick()
        CloseForm()
    End Sub
#End Region

    Private Sub clsVMove_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.myScanSampleAPI = New ZF_PKCtrl.API()

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

        dtGrid = clsCMove.GetPrgTrans(99, 0)
        ShowGrid()
        '==============================
        Dim col0 As New DataGridTextBoxColumn
        col0.MappingName = "ID"
        col0.HeaderText = "ID"
        col0.Width = 50

        Dim col1 As New DataGridTextBoxColumn
        col1.MappingName = "Item"
        col1.HeaderText = "Item"
        col1.Width = 120

        Dim col2 As New DataGridTextBoxColumn
        col2.MappingName = "Current"
        col2.HeaderText = "Current"
        col2.Width = 100

        Dim col3 As New DataGridTextBoxColumn
        col3.MappingName = "New"
        col3.HeaderText = "New"
        col3.Width = 100

        Dim GridTBStyle As New DataGridTableStyle
        GridTBStyle.MappingName = "Transaction"
        With GridTBStyle.GridColumnStyles
            .Add(col0)
            .Add(col1)
            .Add(col2)
            .Add(col3)
        End With
        grdData.TableStyles.Add(GridTBStyle)
        '==============================
        MoveActiveDateTime = Now

        btnSave.Enabled = False
        Me.KeyPreview = True
        ' this.KeyDown += new KeyEventHandler(Form1_KeyDown);

        Timer1.Enabled = True
    End Sub
    Private Sub clsVMove_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Timer1.Enabled = False
        If isReaderInitiated Then
            myScanSampleAPI.DetachReadNotify()
            myScanSampleAPI.DetachStatusNotify()
            myScanSampleAPI.TermReader()
        End If
        Me.MyAudioController.Dispose()
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
        clsCLogin.ActiveDateTime = Now

        If dtGrid.Rows.Count >= 10 Then
            If MessageBox.Show("Do you want to save?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                SaveData()
            Else
                Exit Sub
            End If
        End If

        Dim strQR As String = TheReaderData.Text
        'Select Case strQR
        '    Case "Truck1"
        '        For i As Integer = 1 To 32
        '            Select Case i
        '                Case 1 : strQR = "CMBF0080|X/C253|GLC|F035"
        '                Case 2 : strQR = "CMBF0081|X/C253|GLC|F036"
        '                Case 3 : strQR = "CMBF0082|X/C253|GLC|F037"
        '                Case 4 : strQR = "CMBF0083|X/C253|GLC|F038"
        '                Case 5 : strQR = "CMBF0084|X/C253|GLC|F039"
        '                Case 6 : strQR = "CMBF0090|X/C253|GLC|F045"
        '                Case 7 : strQR = "CMBF0091|X/C253|GLC|F046"
        '                Case 8 : strQR = "CMBF0092|X/C253|GLC|F047"
        '                Case 9 : strQR = "CMBF0093|X/C253|GLC|F048"
        '                Case 10 : strQR = "CMBF0094|X/C253|GLC|F049"
        '                Case 11 : strQR = "CMBF0095|X/C253|GLC|F050"
        '                Case 12 : strQR = "CMBF0096|X/C253|GLC|F051"
        '                Case 13 : strQR = "FMBF0001|V223|CMM|BPS|B0001"
        '                Case 14 : strQR = "FMBF0002|V223|CMM|BPS|B0002"
        '                Case 15 : strQR = "FMBF0003|V223|CMM|BPS|B0003"
        '                Case 16 : strQR = "FMBF0004|V223|CMM|BPS|B0004"
        '                Case 17 : strQR = "FMBF0005|V223|CMM|BPS|B0005"
        '                Case 18 : strQR = "FMBF0006|V223|CMM|BPS|B0006"
        '                Case 19 : strQR = "FMBF0007|V223|CMM|BPS|B0007"
        '                Case 20 : strQR = "FMBF0008|V223|CMM|BPS|B0008"
        '                Case 21 : strQR = "FMBF0009|V223|CMM|BPS|B0009"
        '                Case 22 : strQR = "FMBF0010|V223|CMM|BPS|B0010"
        '                Case 23 : strQR = "FMBF0011|V223|CMM|BPS|B0011"
        '                Case 24 : strQR = "FMBF0012|V223|CMM|BPS|B0012"
        '                Case 25 : strQR = "FMBF0013|V223|CMM|BPS|B0013"
        '                Case 26 : strQR = "FMBF0014|V223|CMM|BPS|B0014"
        '                Case 27 : strQR = "FMBF0015|V223|CMM|BPS|B0015"
        '                Case 28 : strQR = "FMBF0016|V223|CMM|BPS|B0016"
        '                Case 29 : strQR = "FMBF0017|V223|CMM|BPS|B0017"
        '                Case 30 : strQR = "FMBF0018|V223|CMM|BPS|B0018"
        '                Case 31 : strQR = "FMBF0019|V223|CMM|BPS|B0019"
        '                Case 32 : strQR = "FMBF0020|V223|CMM|BPS|B0020"
        '            End Select
        '            TestTruck(strQR)
        '        Next
        '        Exit Sub
        '    Case "Truck2"
        '        For i As Integer = 1 To 32
        '            Select Case i
        '                Case 1 : strQR = "CMBF0097|X/C253|GLC|F052"
        '                Case 2 : strQR = "CMBF0098|X/C253|GLC|F053"
        '                Case 3 : strQR = "CMBF0099|X/C253|GLC|F054"
        '                Case 4 : strQR = "CMBF0100|X/C253|GLC|F055"
        '                Case 5 : strQR = "CMBF0101|X/C253|GLC|F056"
        '                Case 6 : strQR = "CMBF0149|W213|E|F034"
        '                Case 7 : strQR = "CMBF0150|W213|E|F035"
        '                Case 8 : strQR = "CMBF0151|W213|E|F036"
        '                Case 9 : strQR = "CMBF0152|W213|E|F037"
        '                Case 10 : strQR = "CMBF0153|W213|E|F038"
        '                Case 11 : strQR = "CMBF0154|W213|E|F039"
        '                Case 12 : strQR = "CMBF0155|W213|E|F040"
        '                Case 13 : strQR = "FMBF0021|V223|CMM|BPS|B0021"
        '                Case 14 : strQR = "FMBF0022|V223|CMM|BPS|B0022"
        '                Case 15 : strQR = "FMBF0023|V223|CMM|BPS|B0023"
        '                Case 16 : strQR = "FMBF0024|V223|CMM|BPS|B0024"
        '                Case 17 : strQR = "FMBF0025|V223|CMM|BPS|B0025"
        '                Case 18 : strQR = "FMBF0026|V223|CMM|BPS|B0026"
        '                Case 19 : strQR = "FMBF0027|V223|CMM|BPS|B0027"
        '                Case 20 : strQR = "FMBF0028|V223|CMM|BPS|B0028"
        '                Case 21 : strQR = "FMBF0029|V223|CMM|BPS|B0029"
        '                Case 22 : strQR = "FMBF0030|V223|CMM|BPS|B0030"
        '                Case 23 : strQR = "FMBF0031|V223|CMM|BPS|B0031"
        '                Case 24 : strQR = "FMBF0032|V223|CMM|BPS|B0032"
        '                Case 25 : strQR = "FMBF0033|V223|CMM|BPS|B0033"
        '                Case 26 : strQR = "FMBF0034|V223|CMM|BPS|B0034"
        '                Case 27 : strQR = "FMBF0035|V223|CMM|BPS|B0035"
        '                Case 28 : strQR = "FMBF0036|V223|CMM|BPS|B0036"
        '                Case 29 : strQR = "FMBF0037|V223|CMM|BPS|B0037"
        '                Case 30 : strQR = "FMBF0038|V223|CMM|BPS|B0038"
        '                Case 31 : strQR = "FMBF0039|V223|CMM|BPS|B0039"
        '                Case 32 : strQR = "FMBF0040|V223|CMM|BPS|B0040"
        '            End Select
        '            TestTruck(strQR)
        '        Next
        '        Exit Sub
        '    Case "Truck3"
        '        For i As Integer = 1 To 32
        '            Select Case i
        '                Case 1 : strQR = "CMBF0236|C205|C|F049"
        '                Case 2 : strQR = "CMBF0237|C205|C|F050"
        '                Case 3 : strQR = "CMBF0238|C205|C|F051"
        '                Case 4 : strQR = "CMBF0239|C205|C|F052"
        '                Case 5 : strQR = "CMBF0240|C205|C|F053"
        '                Case 6 : strQR = "CMBF0241|C205|C|F054"
        '                Case 7 : strQR = "CMBF0242|C205|C|F055"
        '                Case 8 : strQR = "CMBF0243|C205|C|F056"
        '                Case 9 : strQR = "CMBF0244|C205|C|F057"
        '                Case 10 : strQR = "CMBF0245|C205|C|F058"
        '                Case 11 : strQR = "CMBF0246|C205|C|F059"
        '                Case 12 : strQR = "CMBF0247|C205|C|F060"
        '                Case 13 : strQR = "FMBF0041|V223|CMM|BPS|B0041"
        '                Case 14 : strQR = "FMBF0042|V223|CMM|BPS|B0042"
        '                Case 15 : strQR = "FMBF0043|V223|CMM|BPS|B0043"
        '                Case 16 : strQR = "FMBF0044|V223|CMM|BPS|B0044"
        '                Case 17 : strQR = "FMBF0045|V223|CMM|BPS|B0045"
        '                Case 18 : strQR = "FMBF0046|V223|CMM|BPS|B0046"
        '                Case 19 : strQR = "FMBF0047|V223|CMM|BPS|B0047"
        '                Case 20 : strQR = "FMBF0048|V223|CMM|BPS|B0048"
        '                Case 21 : strQR = "FMBF0049|V223|CMM|BPS|B0049"
        '                Case 22 : strQR = "FMBF0050|V223|CMM|BPS|B0050"
        '                Case 23 : strQR = "FMBF0051|V223|CMM|BPS|B0051"
        '                Case 24 : strQR = "FMBF0052|V223|CMM|BPS|B0052"
        '                Case 25 : strQR = "FMBF0053|V223|CMM|BPS|B0053"
        '                Case 26 : strQR = "FMBF0054|V223|CMM|BPS|B0054"
        '                Case 27 : strQR = "FMBF0055|V223|CMM|BPS|B0055"
        '                Case 28 : strQR = "FMBF0056|V223|CMM|BPS|B0056"
        '                Case 29 : strQR = "FMBF0057|V223|CMM|BPS|B0057"
        '                Case 30 : strQR = "FMBF0058|V223|CMM|BPS|B0058"
        '                Case 31 : strQR = "FMBF0059|V223|CMM|BPS|B0059"
        '                Case 32 : strQR = "FMBF0060|V223|CMM|BPS|B0060"
        '            End Select
        '            TestTruck(strQR)
        '        Next
        '        Exit Sub
        'End Select

            If strQR = "" Then
                PlayBeeb()
                MessageBox.Show("Invalid QR Code")
                grdData.Focus()
                Exit Sub
            End If

            Dim strData() As String = Strings.Split(strQR, "|")
            If Not (strData.Length = 4 Or strData.Length = 5) Then
                PlayBeeb()
                MessageBox.Show("Invalid QR Code")
                grdData.Focus()
                Exit Sub
            End If

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


            If ScanValidate(Rack, Remark, Model, Code, Running) = True Then
                Dim dtMstItem As DataTable = clsCMove.GetMstItem(Rack, Remark, Model, Code, Running)
                If Not dtMstItem Is Nothing Then
                    If dtMstItem.Rows.Count > 0 Then
                        Dim drMstItem As DataRow = dtMstItem.Rows(0)

                        Dim ID As Integer = 0
                        Dim MaxIDGrid As Integer = 0
                        Dim MaxIDDB As Integer = 0
                        If dtGrid.Rows.Count > 0 Then
                            For Each drTrans As DataRow In dtGrid.Select("", "ID desc")
                                MaxIDGrid = Convert.ToInt16(drTrans("ID"))
                                Exit For
                            Next
                        End If
                        Dim dtPrgTrans As DataTable = clsCMove.GetPrgTrans(0, 0)
                        If dtPrgTrans.Rows.Count > 0 Then
                            For Each drPrgTrans As DataRow In dtPrgTrans.Select("", "ID Desc")
                                MaxIDDB = Convert.ToInt16(drPrgTrans("ID"))
                                Exit For
                            Next
                        End If
                        If MaxIDGrid > MaxIDDB Then
                            ID = MaxIDGrid + 1
                        Else
                            ID = MaxIDDB + 1
                        End If


                        Dim strFrom As String = drMstItem("Current").ToString
                        If strFrom = clsCMove.Status_OnTruck Then strFrom = clsCMove.Status_MB
                        Dim strTo As String = ""
                        Select Case mScanType
                            Case eScanType.MB
                                If strFrom = clsCMove.Status_ZF Then
                                    strTo = clsCMove.Status_OnTruck
                                Else
                                    strTo = clsCMove.Status_ZF
                                End If
                            Case eScanType.Sup
                                If strFrom = clsCMove.Status_ZF Then
                                    strTo = clsCMove.Status_Supplier
                                Else
                                    strTo = clsCMove.Status_ZF
                                End If
                            Case eScanType.Ext
                                If strFrom = clsCMove.Status_ZF Then
                                    strTo = clsCMove.Status_ExtWH
                                Else
                                    strTo = clsCMove.Status_ZF
                                End If
                        End Select

                        'ScanType,Rack,Remark,Model,Code,Running,ScanDateTime,From,To,ID,RackDTID
                        Dim drAdd As DataRow = dtGrid.NewRow
                        drAdd("ScanType") = mScanType
                        drAdd("ID") = ID
                        drAdd("RackDTID") = drMstItem("RackDTID")
                        drAdd("Rack") = drMstItem("Rack")
                        drAdd("Remark") = drMstItem("Remark")
                        drAdd("Model") = drMstItem("Model")
                        drAdd("Code") = drMstItem("Code")
                        drAdd("Running") = drMstItem("Running")
                        drAdd("ScanDateTime") = Now()
                        drAdd("From") = strFrom
                        drAdd("To") = strTo
                        drAdd("StaffCode") = P_Sys.StaffID

                        dtGrid.Rows.Add(drAdd)
                        ShowGrid()
                        btnSave.Enabled = True


                    Else
                        PlayBeeb()
                        MessageBox.Show("Rack not found")
                    End If
                End If
            End If
    End Sub

    'Private Sub TestTruck(ByVal strQR As String)
    '    Dim strData() As String = Strings.Split(strQR, "|")
    '    If Not (strData.Length = 4 Or strData.Length = 5) Then
    '        PlayBeeb()
    '        MessageBox.Show("Invalid QR Code")
    '        grdData.Focus()
    '        Exit Sub
    '    End If

    '    Dim Rack As String = ""
    '    Dim Remark As String = ""
    '    Dim Model As String = ""
    '    Dim Code As String = ""
    '    Dim Running As String = ""
    '    If strData.Length = 4 Then
    '        If Not IsDBNull(strData(eQR4.Rack)) Then Rack = strData(eQR4.Rack)
    '        Remark = ""
    '        If Not IsDBNull(strData(eQR4.Model)) Then Model = strData(eQR4.Model)
    '        If Not IsDBNull(strData(eQR4.Code)) Then Code = strData(eQR4.Code)
    '        If Not IsDBNull(strData(eQR4.Running)) Then Running = strData(eQR4.Running)
    '    Else
    '        If Not IsDBNull(strData(eQR5.Rack)) Then Rack = strData(eQR5.Rack)
    '        If Not IsDBNull(strData(eQR5.Remark)) Then Remark = strData(eQR5.Remark)
    '        If Not IsDBNull(strData(eQR5.Model)) Then Model = strData(eQR5.Model)
    '        If Not IsDBNull(strData(eQR5.Code)) Then Code = strData(eQR5.Code)
    '        If Not IsDBNull(strData(eQR5.Running)) Then Running = strData(eQR5.Running)
    '    End If


    '    If ScanValidate(Rack, Remark, Model, Code, Running) = True Then
    '        Dim dtMstItem As DataTable = clsCMove.GetMstItem(Rack, Remark, Model, Code, Running)
    '        If Not dtMstItem Is Nothing Then
    '            If dtMstItem.Rows.Count > 0 Then
    '                Dim drMstItem As DataRow = dtMstItem.Rows(0)

    '                Dim ID As Integer = 0
    '                Dim MaxIDGrid As Integer = 0
    '                Dim MaxIDDB As Integer = 0
    '                If dtGrid.Rows.Count > 0 Then
    '                    For Each drTrans As DataRow In dtGrid.Select("", "ID desc")
    '                        MaxIDGrid = Convert.ToInt16(drTrans("ID"))
    '                        Exit For
    '                    Next
    '                End If
    '                Dim dtPrgTrans As DataTable = clsCMove.GetPrgTrans(0, 0)
    '                If dtPrgTrans.Rows.Count > 0 Then
    '                    For Each drPrgTrans As DataRow In dtPrgTrans.Select("", "ID Desc")
    '                        MaxIDDB = Convert.ToInt16(drPrgTrans("ID"))
    '                        Exit For
    '                    Next
    '                End If
    '                If MaxIDGrid > MaxIDDB Then
    '                    ID = MaxIDGrid + 1
    '                Else
    '                    ID = MaxIDDB + 1
    '                End If


    '                Dim strFrom As String = drMstItem("Current").ToString
    '                If strFrom = clsCMove.Status_OnTruck Then strFrom = clsCMove.Status_MB
    '                Dim strTo As String = ""
    '                Select Case mScanType
    '                    Case eScanType.MB
    '                        If strFrom = clsCMove.Status_ZF Then
    '                            strTo = clsCMove.Status_OnTruck
    '                        Else
    '                            strTo = clsCMove.Status_ZF
    '                        End If
    '                    Case eScanType.Sup
    '                        If strFrom = clsCMove.Status_ZF Then
    '                            strTo = clsCMove.Status_Supplier
    '                        Else
    '                            strTo = clsCMove.Status_ZF
    '                        End If
    '                    Case eScanType.Ext
    '                        If strFrom = clsCMove.Status_ZF Then
    '                            strTo = clsCMove.Status_ExtWH
    '                        Else
    '                            strTo = clsCMove.Status_ZF
    '                        End If
    '                End Select

    '                'ScanType,Rack,Remark,Model,Code,Running,ScanDateTime,From,To,ID,RackDTID
    '                Dim drAdd As DataRow = dtGrid.NewRow
    '                drAdd("ScanType") = mScanType
    '                drAdd("ID") = ID
    '                drAdd("RackDTID") = drMstItem("RackDTID")
    '                drAdd("Rack") = drMstItem("Rack")
    '                drAdd("Remark") = drMstItem("Remark")
    '                drAdd("Model") = drMstItem("Model")
    '                drAdd("Code") = drMstItem("Code")
    '                drAdd("Running") = drMstItem("Running")
    '                drAdd("ScanDateTime") = Now()
    '                drAdd("From") = strFrom
    '                drAdd("To") = strTo
    '                drAdd("StaffCode") = P_Sys.StaffID

    '                dtGrid.Rows.Add(drAdd)
    '                ShowGrid()
    '                btnSave.Enabled = True


    '            Else
    '                PlayBeeb()
    '                MessageBox.Show("Rack not found")
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Function ScanValidate(ByVal Rack As String, ByVal Remark As String, ByVal Model As String, ByVal Code As String, ByVal Running As String) As Boolean
        'Check Existing Master
        Dim dtMst As DataTable = clsCMove.GetMstItem(Rack, Remark, Model, Code, Running)

        Dim RackDTID As Integer = 0
        If dtMst Is Nothing Then
            PlayBeeb()
            MessageBox.Show("No Master")
            grdData.Focus()
            Return False
        ElseIf dtMst.Rows.Count = 0 Then
            PlayBeeb()
            MessageBox.Show("No Master")
            grdData.Focus()
            Return False
        Else
            RackDTID = Convert.ToInt16(dtMst.Rows(0)("RackDTID"))
        End If

        Dim dtPrgTrans As DataTable = clsCMove.GetPrgTrans(0, RackDTID)
        Dim drPrgTrans As DataRow = Nothing
        If Not dtPrgTrans Is Nothing Then
            If dtPrgTrans.Rows.Count > 0 Then
                For Each dr As DataRow In dtPrgTrans.Select("", "ID desc")
                    drPrgTrans = dr
                Next
            End If
        End If

        'Check scan duplicate
        For Each drGrid As DataRow In dtGrid.Select("RackDTID=" & RackDTID & "")
            If DateDiff(DateInterval.Hour, Convert.ToDateTime(drGrid("ScanDateTime")), Now()) < clsCMove.GetScanLimit() Then
                PlayBeeb()
                MessageBox.Show("Duplicate scan (Grid)")
                grdData.Focus()
                Return False
                Exit Function
            End If
        Next
        If dtPrgTrans.Rows.Count > 0 Then
            If DateDiff(DateInterval.Hour, Convert.ToDateTime(drPrgTrans("ScanDateTime")), Now()) < clsCMove.GetScanLimit() Then
                PlayBeeb()
                MessageBox.Show("Duplicate scan (DB)")
                grdData.Focus()
                Return False
                Exit Function
            End If
        End If

        'Check Status compatible with scan Type
        Dim CurStatus As String = dtMst.Rows(0)("Current").ToString
        If CurStatus = clsCMove.Status_OnTruck Then CurStatus = clsCMove.Status_MB
        If dtPrgTrans.Rows.Count > 0 Then
            If drPrgTrans("To").ToString = clsCMove.Status_OnTruck Then
                If DateDiff(DateInterval.Hour, Convert.ToDateTime(drPrgTrans("ScanDateTime")), Now()) >= clsCMove.GetAutoMB() Then
                    CurStatus = clsCMove.Status_MB
                End If
            Else
                CurStatus = drPrgTrans("To").ToString
            End If
        End If
        Dim StatusOK As Boolean = False
        Select Case mScanType
            Case eScanType.MB
                If CurStatus = clsCMove.Status_ZF Or CurStatus = clsCMove.Status_MB Then
                    StatusOK = True
                End If
            Case eScanType.Sup
                If CurStatus = clsCMove.Status_ZF Or CurStatus = clsCMove.Status_Supplier Then
                    StatusOK = True
                End If
            Case eScanType.Ext
                If CurStatus = clsCMove.Status_ZF Or CurStatus = clsCMove.Status_ExtWH Then
                    StatusOK = True
                End If
        End Select
        If StatusOK = False Then
            If mScanType = eScanType.MB And CurStatus = clsCMove.Status_OnTruck Then
                PlayBeeb()
                MessageBox.Show("Rack on truck, please wait")
                grdData.Focus()
            Else
                PlayBeeb()
                MessageBox.Show("Invalid Rack Status")
                grdData.Focus()
            End If
            Return False
            Exit Function
        End If

        Return True

    End Function

    Private Sub ShowGrid()
        'Grid Datasource = Transaction --> ID,Item,Current,New

        Dim dtShowGrid As New DataTable
        dtShowGrid.TableName = "Transaction"
        dtShowGrid.Columns.Add("ID", GetType(Integer))
        dtShowGrid.Columns.Add("Item", GetType(String))
        dtShowGrid.Columns.Add("Current", GetType(String))
        dtShowGrid.Columns.Add("New", GetType(String))

        Dim drAdd As DataRow = Nothing
        For Each drTrans As DataRow In dtGrid.Select("", "ID desc")
            drAdd = dtShowGrid.NewRow
            drAdd("ID") = drTrans("ID")
            drAdd("Item") = String.Concat(drTrans("Code"), drTrans("Running"))
            drAdd("Current") = drTrans("From")
            drAdd("New") = drTrans("To")
            dtShowGrid.Rows.Add(drAdd)
        Next

        With grdData
            .DataSource = dtShowGrid
        End With
    End Sub


    Private Sub SaveData()
        If clsCMove.SaveData(dtGrid, mScanType) = False Then
            PlayBeeb()
            MessageBox.Show("FAIL!!!")
            grdData.Focus()
            btnSave.Enabled = True
        Else
            dtGrid = clsCMove.GetPrgTrans(99, 0)
            ShowGrid()
            'MessageBox.Show("Save OK")
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub CloseForm()
        Me.Close()
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



End Class