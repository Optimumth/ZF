Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Windows.Forms
Imports System.Data
Imports Symbol.Exceptions
Imports System.IO
Imports System.Runtime.InteropServices
Imports Symbol.Barcode2

Namespace ZFPKCtrl
    ''' <summary>
    ''' Class MainForm.
    ''' </summary>
    Public Class MainForm
        Inherits System.Windows.Forms.Form
        ' The column headers for the list view.
        Private numberColumn As ColumnHeader = Nothing
        Private itemColumn As ColumnHeader = Nothing
        Private nameColumn As ColumnHeader = Nothing
        Private dataColumn As ColumnHeader = Nothing
        Private optionsColumn As ColumnHeader = Nothing
        Private optionColumn As ColumnHeader = Nothing
        Private code128Column As ColumnHeader = Nothing
        Private code39Column As ColumnHeader = Nothing
        Private valueColumn As ColumnHeader = Nothing

        ' The ImageList reference which is used to control the row height of listViewMain.
        '  This is kind of a workaround in the absense of an exposed API to control the 
        '  row height of System.Windows.Forms.ListView.
        Private imageList As ImageList = Nothing

        Private WithEvents listViewMain As ListView = Nothing
        Private WithEvents panel As Panel

        Private myResources As Resources = Nothing
        Private statusBar As StatusBar = Nothing

        Private WithEvents timer As Timer = Nothing
        Private selectedIndex As Integer = 0

        Private myActivateHandler As System.EventHandler = Nothing

        ' The formatting string used with listview items.
        Private itemNumberFormat As String = ""
        ' Tracks the current view/page of the listViewMain.
        Private currentListView As String = ""

        ' The constants defined for the string table entries.
        Private Const ROOT As String = "Main"
        Private Const EXITAPP As String = "ExitApp"
        Private Const BACK As String = "Back"
        Private Const SCAN As String = "Scan"
        Private Const Download_Master As String = "DownloadMaster"
        Private Const OPTIONS As String = "Options"
        Private Const ABOUT As String = "About"
        Private Const AIMTYPE As String = "AimType"
        Private Const AIMMODE As String = "AimMode"
        Private Const SCANTYPE As String = "ScanType"
        Private Const CODE128 As String = "Code128"
        Private Const CODE39 As String = "Code39"
        Private Const AIMTYPE_TRIGGER As String = "Trigger"
        Private Const AIMTYPE_HOLD As String = "Hold"
        Private Const AIMTYPE_RELEASE As String = "Release"
        Private Const AIMMODE_NONE As String = "None"
        Private Const AIMMODE_DOT As String = "Dot"
        Private Const AIMMODE_SLAB As String = "Slab"
        Private Const AIMMODE_RETICLE As String = "Reticle"
        Private Const SCANTYPE_FOREGROUND As String = "Foreground"
        Private Const SCANTYPE_BACKGROUND As String = "Background"
        Private Const SCANTYPE_MONITOR As String = "Monitor"
        'INSTANT VB NOTE: The variable ENABLED was renamed since Visual Basic does not allow class members with the same name:
        Private Const ENABLED_Renamed As String = "Enabled"
        Private Const DISABLED As String = "Disabled"

        ' All the barcode scanner - related operations in this sample would be carried out  
        '  by using this reference of myScanSampleAPI which is an instance of the class 
        '  ScanSampleAPI. Will be initialized later in the code.
        Private myScanSampleAPI As API = Nothing
        Private myScanNotifyHandler As Barcode2.OnScanHandler = Nothing
        Private myStatusNotifyHandler As Barcode2.OnStatusHandler = Nothing

        Private myFormActivatedEventHandler As EventHandler = Nothing
        Private myFormDeactivatedEventHandler As EventHandler = Nothing

        ' The flag to track whether the Barcode object has been initialized or not.
        Private isBarcodeInitiated As Boolean = False

        ' The factor(n) which defines the row height of the ListView. 
        '  The default row height would be multiplied by this factor (ROW_HEIGHT_FACTOR = n).
        Private Const ROW_HEIGHT_FACTOR As Integer = 2 ' Currently set to 2. So the row height would be doubled in this sample.
        ' The user can set it to any value (i.e. 1,2,3,..., etc.) based on the requirements.

        Public Sub New()

            'Save the current cursor.
            Dim savedCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor

            myResources = New Resources()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            If listViewMain.Font.Size <> 11 Then
                Me.listViewMain.Font = New System.Drawing.Font("Tahoma", 11.0F, System.Drawing.FontStyle.Regular)
            End If

            Me.itemColumn.Text = Resources.GetString("Item")
            Me.valueColumn.Text = Resources.GetString("Value")
            Me.timer.Interval = 1000

            Cursor.Current = savedCursor
        End Sub
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.listViewMain = New System.Windows.Forms.ListView
            Me.imageList = New System.Windows.Forms.ImageList
            Me.numberColumn = New System.Windows.Forms.ColumnHeader
            Me.itemColumn = New System.Windows.Forms.ColumnHeader
            Me.nameColumn = New System.Windows.Forms.ColumnHeader
            Me.dataColumn = New System.Windows.Forms.ColumnHeader
            Me.optionsColumn = New System.Windows.Forms.ColumnHeader
            Me.optionColumn = New System.Windows.Forms.ColumnHeader
            Me.code128Column = New System.Windows.Forms.ColumnHeader
            Me.code39Column = New System.Windows.Forms.ColumnHeader
            Me.valueColumn = New System.Windows.Forms.ColumnHeader
            Me.timer = New System.Windows.Forms.Timer
            Me.statusBar = New System.Windows.Forms.StatusBar
            Me.panel = New System.Windows.Forms.Panel
            Me.panel.SuspendLayout()
            Me.SuspendLayout()
            '
            'listViewMain
            '
            Me.listViewMain.Activation = System.Windows.Forms.ItemActivation.OneClick
            Me.listViewMain.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.listViewMain.FullRowSelect = True
            Me.listViewMain.Location = New System.Drawing.Point(0, 0)
            Me.listViewMain.Name = "listViewMain"
            Me.listViewMain.Size = New System.Drawing.Size(318, 268)
            Me.listViewMain.TabIndex = 1
            Me.listViewMain.View = System.Windows.Forms.View.Details
            '
            'imageList
            '
            Me.imageList.ImageSize = New System.Drawing.Size(16, 16)
            '
            'numberColumn
            '
            Me.numberColumn.Text = "#"
            '
            'itemColumn
            '
            Me.itemColumn.Text = ""
            '
            'nameColumn
            '
            Me.nameColumn.Text = "ColumnHeader"
            '
            'dataColumn
            '
            Me.dataColumn.Text = ""
            '
            'optionsColumn
            '
            Me.optionsColumn.Text = "Options"
            '
            'optionColumn
            '
            Me.optionColumn.Text = "Aim Type"
            '
            'code128Column
            '
            Me.code128Column.Text = "Code128"
            '
            'code39Column
            '
            Me.code39Column.Text = "Code39"
            '
            'valueColumn
            '
            Me.valueColumn.Text = "Value"
            '
            'statusBar
            '
            Me.statusBar.Location = New System.Drawing.Point(0, 268)
            Me.statusBar.Name = "statusBar"
            Me.statusBar.Size = New System.Drawing.Size(318, 24)
            '
            'panel
            '
            Me.panel.Controls.Add(Me.listViewMain)
            Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel.Location = New System.Drawing.Point(0, 0)
            Me.panel.Name = "panel"
            Me.panel.Size = New System.Drawing.Size(318, 268)
            '
            'MainForm
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.ClientSize = New System.Drawing.Size(318, 292)
            Me.Controls.Add(Me.panel)
            Me.Controls.Add(Me.statusBar)
            Me.MinimizeBox = False
            Me.Name = "MainForm"
            Me.Text = "ZF-Packaging Control"
            Me.panel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Shared Sub Main()
            Dim mainForm As New MainForm()
            Application.Run(mainForm)
        End Sub


        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.myActivateHandler = New System.EventHandler(AddressOf Me.listViewMain_ItemActivate)
            AddHandler Me.listViewMain.ItemActivate, Me.myActivateHandler

            Dim conn As New Conn
            conn.ConnectDBWinCE()

            Try
                Dim a As Boolean = False
                MessageBox.Show("1")
                a = busCheckMstProduct.Test
                MessageBox.Show("2")
                If a = True Then
                    MessageBox.Show("True")
                Else
                    MessageBox.Show("False")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            


            'Me.Close()
            ' Add MainMenu if Pocket PC
            If Symbol.Win32.PlatformType.IndexOf("PocketPC") <> -1 Then
                Me.Menu = New MainMenu()
            End If

            ' Initialize the ScanSampleAPI reference.
            Me.myScanSampleAPI = New API()

            Me.isBarcodeInitiated = Me.myScanSampleAPI.InitBarcode()

            If Not (Me.isBarcodeInitiated) Then ' If the Barcode object has not been initialized
                ' Display a message & exit the application.
                MessageBox.Show(Resources.GetString("AppExitMsg"))
                Application.Exit()
            Else ' If the Barcode object has been initialized
                ' Clear the statusbar where subsequent status information would be displayed.
                statusBar.Text = ""

                ' Attach a scan notification handler.
                Me.myScanNotifyHandler = New Barcode2.OnScanHandler(AddressOf myBarcode2_ScanNotify)
                myScanSampleAPI.AttachScanNotify(myScanNotifyHandler)

                ' Attach a status notification handler.
                Me.myStatusNotifyHandler = New Barcode2.OnStatusHandler(AddressOf myBarcode2_StatusNotify)
                myScanSampleAPI.AttachStatusNotify(myStatusNotifyHandler)
            End If

            Me.loadMainListView()

            setRowHeight(Me.listViewMain)
            setGridLines(listViewMain)

            ' Ensure that the keyboard focus is set on a control.
            Me.listViewMain.Focus()

            myFormActivatedEventHandler = New EventHandler(AddressOf MainForm_Activated)
            myFormDeactivatedEventHandler = New EventHandler(AddressOf MainForm_Deactivate)
            AddHandler Me.Activated, myFormActivatedEventHandler
            AddHandler Me.Deactivate, myFormDeactivatedEventHandler
        End Sub

        ''' <summary>
        ''' Add an item to listViewMain.
        ''' </summary>
        ''' <param name="number">The number to display in Number column.</param>
        ''' <param name="itemName">The string to display in Item column.</param>
        Private Sub addListViewItem(ByVal number As Integer, ByVal itemName As String)
            Dim item() As String
            item = New String() {number.ToString(itemNumberFormat), Resources.GetString(itemName), itemName}
            Dim li As New ListViewItem(item)
            listViewMain.Items.Add(li)
        End Sub

        ''' <summary>
        ''' Add an item to listViewMain.
        ''' </summary>
        ''' <param name="number">The number to display in Number column.</param>
        ''' <param name="itemName">The string to display in Item column.</param>
        ''' <param name="itemValue">The string to display in Value column.</param>
        Private Sub addListViewItem(ByVal number As Integer, ByVal itemName As String, ByVal itemValue As String)
            Dim item() As String
            item = New String() {number.ToString(itemNumberFormat), Resources.GetString(itemName), itemValue, itemName}
            Dim li As New ListViewItem(item)
            listViewMain.Items.Add(li)
        End Sub

        ''' <summary>
        ''' Append a data item to listViewMain. This is used in the page for the scanned data.
        ''' Used in the scan mode.
        ''' </summary>
        ''' <param name="itemName">The string to display in data column.</param>
        Private Sub appendListViewDataItem(ByVal name As String, ByVal value As String)
            Dim number As Integer = listViewMain.Items.Count
            Dim item() As String
            item = New String() {number.ToString(itemNumberFormat), Resources.GetString(name), value, ""}
            Dim li As New ListViewItem(item)
            listViewMain.Items.Add(li)
            li.Focused = True
            listViewMain.EnsureVisible(number)

        End Sub

        ''' <summary>
        ''' Append a data item to listViewMain. This is used in the page for the scanned data.
        ''' Used in the scan continuous mode.
        ''' </summary>
        ''' <param name="itemName">The string to display in data column.</param>
        Private Sub appendListViewContinuousDataItem(ByVal data As String)
            Dim number As Integer = listViewMain.Items.Count
            Dim item() As String
            item = New String() {number.ToString(itemNumberFormat), data, ""}
            Dim li As New ListViewItem(item)
            listViewMain.Items.Add(li)
            li.Focused = True
            listViewMain.EnsureVisible(number)
        End Sub

#Region "Main listView"

        ''' <summary>
        ''' Add items to the start page of the Form; main list view.
        ''' </summary>
        Private Sub loadMainListViewItems()
            itemNumberFormat = ""

            Dim i As Integer = 0

            ' Add items.
            addListViewItem(i, EXITAPP)
            i += 1
            addListViewItem(i, SCAN)
            i += 1
            addListViewItem(i, Download_Master)
            i += 1

        End Sub

        ''' <summary>
        ''' Load the the start page of the Form; main list view.
        ''' </summary>
        Private Sub loadMainListView()
            currentListView = ROOT

            'Add column headers
            Me.listViewMain.Columns.Add(Me.numberColumn)
            Me.listViewMain.Columns.Add(Me.itemColumn)
            Me.listViewMain.Columns.Add(Me.nameColumn)
            Me.loadMainListViewItems()

            setListViewColumnWidth()

        End Sub

        ''' <summary>
        ''' Unload the main list view.
        ''' </summary>
        Private Sub unloadMainListView()
            'Remove all items.
            Me.listViewMain.Clear()

            'Remove column headers.
            Me.listViewMain.Columns.Remove(Me.numberColumn)
            Me.listViewMain.Columns.Remove(Me.itemColumn)
            Me.listViewMain.Columns.Remove(Me.nameColumn)

        End Sub

        ''' <summary>
        ''' Add items to the page for the scanned data. 
        ''' </summary>
        Private Sub loadScanDataListViewItems()
            itemNumberFormat = "0"

            Dim i As Integer = 0
            addListViewItem(i, BACK, "")
            i += 1
            addListViewItem(i, "Data", "")
            i += 1
            addListViewItem(i, "Type", "")
            i += 1
            addListViewItem(i, "Source", "")
            i += 1
            addListViewItem(i, "Time", "")
            i += 1
            addListViewItem(i, "Length", "")
            i += 1
        End Sub

        ''' <summary>
        ''' Load the page for the scanned data.
        ''' </summary>
        Private Sub loadScanDataListView()
            currentListView = SCAN

            'Add column headers
            Me.listViewMain.Columns.Add(Me.numberColumn)
            Me.listViewMain.Columns.Add(Me.dataColumn)
            Me.listViewMain.Columns.Add(Me.valueColumn)
            Me.listViewMain.Columns.Add(Me.nameColumn)
            Me.loadScanDataListViewItems()

            'If the Barcode2 object has been initialized
            If isBarcodeInitiated Then
                ' Start a read operation & attach a handler.
                myScanSampleAPI.StartScan(False)

            End If

            setListViewColumnWidth()
        End Sub

        ''' <summary>
        ''' Unload the page for the scanned data.
        ''' </summary>
        Private Sub unloadScanDataListView()
            ' Stop the read operation & detach the handler.
            myScanSampleAPI.StopScan()

            'Remove all items
            Me.listViewMain.Clear()
            'Remove column headers
            Me.listViewMain.Columns.Remove(Me.numberColumn)
            Me.listViewMain.Columns.Remove(Me.dataColumn)
            Me.listViewMain.Columns.Remove(Me.valueColumn)
            Me.listViewMain.Columns.Remove(Me.nameColumn)

            statusBar.Text = ""

        End Sub

        ''' <summary>
        ''' Add items to the page for the scanned data. Used for the scan continuous mode.
        ''' </summary>
        Private Sub loadScanContinuousDataListViewItems()
            itemNumberFormat = "00"

            Dim i As Integer = 0
            addListViewItem(i, BACK)
            i += 1

        End Sub

        ''' <summary>
        ''' Add items to the page for the options (the reader paramters, the scan parameters & the decoders).
        ''' </summary>
        Private Sub loadOptionsListViewItems()
            itemNumberFormat = ""

            Dim aimType As String = "Unknown"
            Dim aimMode As String = "Unknown"
            Dim scanType As String = "Unknown"

            Select Case myScanSampleAPI.Barcode2.Config.Reader.ReaderType
                Case READER_TYPES.READER_TYPE_IMAGER
                    aimType = myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimType.ToString()
                    aimMode = myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimMode.ToString()
                Case READER_TYPES.READER_TYPE_LASER
                    aimType = myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimType.ToString()
                    aimMode = myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimMode.ToString()
            End Select

            scanType = myScanSampleAPI.Barcode2.Config.Scanner.ScanType.ToString()

            Dim i As Integer = 0
            addListViewItem(i, BACK, "")
            i += 1
            addListViewItem(i, Me.AIMTYPE, aimType.Substring(9))
            i += 1
            addListViewItem(i, Me.AIMMODE, aimMode.Substring(9))
            i += 1
            addListViewItem(i, Me.SCANTYPE, scanType)
            i += 1

            If myScanSampleAPI.Barcode2.Config.Decoders.CODE128.Enabled = True Then
                addListViewItem(i, CODE128, ENABLED_Renamed)
            Else
                addListViewItem(i, CODE128, DISABLED)
            End If
            i += 1
            If myScanSampleAPI.Barcode2.Config.Decoders.CODE39.Enabled = True Then
                addListViewItem(i, CODE39, ENABLED_Renamed)
            Else
                addListViewItem(i, CODE39, DISABLED)
            End If
            i += 1
        End Sub

        ''' <summary>
        ''' Load the page for the options (the reader paramters, the scan parameters & the decoders).
        ''' </summary>
        Private Sub loadOptionsListView()
            currentListView = OPTIONS

            'Add column headers
            Me.listViewMain.Columns.Add(Me.numberColumn)
            Me.listViewMain.Columns.Add(Me.optionsColumn)
            Me.listViewMain.Columns.Add(Me.valueColumn)
            Me.listViewMain.Columns.Add(Me.nameColumn)
            Me.loadOptionsListViewItems()

            setListViewColumnWidth()
        End Sub
        ''' <summary>
        ''' Unload the page for the options (the reader paramters, the scan parameters & the decoders).
        ''' </summary>
        Private Sub unloadOptionsListView()
            'Remove all items
            Me.listViewMain.Clear()
            'Remove column headers
            Me.listViewMain.Columns.Remove(Me.numberColumn)
            Me.listViewMain.Columns.Remove(Me.optionsColumn)
            Me.listViewMain.Columns.Remove(Me.valueColumn)
            Me.listViewMain.Columns.Remove(Me.nameColumn)

        End Sub

        ''' <summary>
        ''' Add items to the page for the option (reader parameter) Aim Type.
        ''' </summary>
        Private Sub loadOptionAimTypeListViewItems()
            itemNumberFormat = ""

            Dim i As Integer = 0

            addListViewItem(i, BACK)
            i += 1
            addListViewItem(i, AIMTYPE_TRIGGER)
            i += 1
            addListViewItem(i, AIMTYPE_HOLD)
            i += 1
            addListViewItem(i, AIMTYPE_RELEASE)
            i += 1

        End Sub

        ''' <summary>
        ''' Load the page for the option (reader parameter) Aim Type.
        ''' </summary>
        Private Sub loadOptionAimTypeListView()
            currentListView = AIMTYPE

            'Add column headers
            Me.listViewMain.Columns.Add(Me.numberColumn)
            Me.listViewMain.Columns.Add(Me.optionColumn)
            Me.listViewMain.Columns.Add(Me.nameColumn)
            Me.loadOptionAimTypeListViewItems()

            setListViewColumnWidth()
        End Sub
        ''' <summary>
        ''' Unload the page for the option (reader parameter) Aim Type.
        ''' </summary>
        Private Sub unloadOptionAimTypeListView()
            'Remove all items
            Me.listViewMain.Clear()
            'Remove column headers
            Me.listViewMain.Columns.Remove(Me.numberColumn)
            Me.listViewMain.Columns.Remove(Me.optionColumn)
            Me.listViewMain.Columns.Remove(Me.nameColumn)

        End Sub

        ''' <summary>
        ''' Add items to the page for the option (reader parameter) Aim Mode.
        ''' </summary>
        Private Sub loadOptionAimModeListViewItems()
            itemNumberFormat = ""

            Dim i As Integer = 0

            addListViewItem(i, BACK)
            i += 1
            addListViewItem(i, AIMMODE_NONE)
            i += 1
            addListViewItem(i, AIMMODE_DOT)
            i += 1
            addListViewItem(i, AIMMODE_SLAB)
            i += 1
            addListViewItem(i, AIMMODE_RETICLE)
            i += 1

        End Sub

        ''' <summary>
        ''' Load the page for the option (reader parameter) Aim Mode.
        ''' </summary>
        Private Sub loadOptionAimModeListView()
            currentListView = AIMMODE

            'Add column headers
            Me.listViewMain.Columns.Add(Me.numberColumn)
            Me.listViewMain.Columns.Add(Me.optionColumn)
            Me.listViewMain.Columns.Add(Me.nameColumn)
            Me.loadOptionAimModeListViewItems()

            setListViewColumnWidth()
        End Sub
        ''' <summary>
        ''' Unload the page for the option (reader parameter) Aim Mode.
        ''' </summary>
        Private Sub unloadOptionAimModeListView()
            'Remove all items
            Me.listViewMain.Clear()
            'Remove column headers
            Me.listViewMain.Columns.Remove(Me.numberColumn)
            Me.listViewMain.Columns.Remove(Me.optionColumn)
            Me.listViewMain.Columns.Remove(Me.nameColumn)

        End Sub

        ''' <summary>
        ''' Add items to the page for the option (scan parameter) ScanType.
        ''' </summary>
        Private Sub loadOptionScanTypeListViewItems()
            itemNumberFormat = ""

            Dim i As Integer = 0

            addListViewItem(i, BACK)
            i += 1
            addListViewItem(i, SCANTYPE_FOREGROUND)
            i += 1
            addListViewItem(i, SCANTYPE_BACKGROUND)
            i += 1
            addListViewItem(i, SCANTYPE_MONITOR)
            i += 1

        End Sub

        ''' <summary>
        ''' Load the page for the option (scan parameter) ScanType.
        ''' </summary>
        Private Sub loadOptionScanTypeListView()
            currentListView = SCANTYPE

            'Add column headers
            Me.listViewMain.Columns.Add(Me.numberColumn)
            Me.listViewMain.Columns.Add(Me.optionColumn)
            Me.listViewMain.Columns.Add(Me.nameColumn)
            Me.loadOptionScanTypeListViewItems()

            setListViewColumnWidth()
        End Sub
        ''' <summary>
        ''' Unload the page for the option (scan parameter) ScanType.
        ''' </summary>
        Private Sub unloadOptionScanTypeListView()
            'Remove all items
            Me.listViewMain.Clear()
            'Remove column headers
            Me.listViewMain.Columns.Remove(Me.numberColumn)
            Me.listViewMain.Columns.Remove(Me.optionColumn)
            Me.listViewMain.Columns.Remove(Me.nameColumn)

        End Sub

        ''' <summary>
        ''' Add items to the page for the option (decoder) Code128.
        ''' </summary>
        Private Sub loadOptionCode128ListViewItems()
            currentListView = CODE128

            'Add column headers
            Me.listViewMain.Columns.Add(Me.numberColumn)
            Me.listViewMain.Columns.Add(Me.code128Column)
            Me.listViewMain.Columns.Add(Me.nameColumn)

            setListViewColumnWidth()

            itemNumberFormat = ""

            Dim i As Integer = 0

            addListViewItem(i, BACK)
            i += 1
            addListViewItem(i, ENABLED_Renamed)
            i += 1
            addListViewItem(i, DISABLED)
            i += 1
        End Sub

        ''' <summary>
        ''' Unload the page for the option (decoder) Code128.
        ''' </summary>
        Private Sub unloadOptionCode128ListView()
            'Remove all items
            Me.listViewMain.Clear()
            'Remove column headers
            Me.listViewMain.Columns.Remove(Me.numberColumn)
            Me.listViewMain.Columns.Remove(Me.code128Column)
            Me.listViewMain.Columns.Remove(Me.nameColumn)

        End Sub


        ''' <summary>
        ''' Add items to the page for the option (decoder) Code39.
        ''' </summary>
        Private Sub loadOptionCode39ListViewItems()
            currentListView = CODE39

            'Add column headers
            Me.listViewMain.Columns.Add(Me.numberColumn)
            Me.listViewMain.Columns.Add(Me.code39Column)
            Me.listViewMain.Columns.Add(Me.nameColumn)

            setListViewColumnWidth()

            itemNumberFormat = ""

            Dim i As Integer = 0

            addListViewItem(i, BACK)
            i += 1
            addListViewItem(i, ENABLED_Renamed)
            i += 1
            addListViewItem(i, DISABLED)
            i += 1
        End Sub

        ''' <summary>
        ''' Unload the page for the option (decoder) Code39.
        ''' </summary>
        Private Sub unloadOptionCode39ListView()
            'Remove all items
            Me.listViewMain.Clear()
            'Remove column headers
            Me.listViewMain.Columns.Remove(Me.numberColumn)
            Me.listViewMain.Columns.Remove(Me.code39Column)
            Me.listViewMain.Columns.Remove(Me.nameColumn)

        End Sub

#End Region



        ''' <summary>
        ''' This deligate is called when a listview item is activated.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub listViewMain_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim savedCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim nameColumn As Integer = locateNameColumn(currentListView)

                ' Compare the 3rd element in the selected row in the listwiew.
                ' This name column has been made invisible, but it's used to track the currently active/highlighted row.
                Dim s As String = listViewMain.Items(listViewMain.SelectedIndices(0)).SubItems(nameColumn).Text
                Select Case listViewMain.Items(listViewMain.SelectedIndices(0)).SubItems(nameColumn).Text
                    Case EXITAPP
                        Me.Close()

                    Case SCAN
                        unloadMainListView()
                        loadScanDataListView()

                    Case Download_Master

                    Case OPTIONS

                        unloadMainListView()
                        loadOptionsListView()

                    Case AIMTYPE

                        unloadOptionsListView()
                        loadOptionAimTypeListView()

                    Case AIMTYPE_TRIGGER

                        Select Case myScanSampleAPI.Barcode2.Config.Reader.ReaderType
                            Case READER_TYPES.READER_TYPE_IMAGER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimType = AIM_TYPE.AIM_TYPE_TRIGGER
                            Case READER_TYPES.READER_TYPE_LASER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimType = AIM_TYPE.AIM_TYPE_TRIGGER
                        End Select

                        myScanSampleAPI.Barcode2.Config.Reader.Set()

                        reloadLastListView()


                    Case AIMTYPE_HOLD

                        Select Case myScanSampleAPI.Barcode2.Config.Reader.ReaderType
                            Case READER_TYPES.READER_TYPE_IMAGER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimType = AIM_TYPE.AIM_TYPE_TIMED_HOLD
                            Case READER_TYPES.READER_TYPE_LASER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimType = AIM_TYPE.AIM_TYPE_TIMED_HOLD
                        End Select

                        myScanSampleAPI.Barcode2.Config.Reader.Set()

                        reloadLastListView()


                    Case AIMTYPE_RELEASE

                        Select Case myScanSampleAPI.Barcode2.Config.Reader.ReaderType
                            Case READER_TYPES.READER_TYPE_IMAGER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimType = AIM_TYPE.AIM_TYPE_TIMED_RELEASE
                            Case READER_TYPES.READER_TYPE_LASER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimType = AIM_TYPE.AIM_TYPE_TIMED_RELEASE
                        End Select

                        myScanSampleAPI.Barcode2.Config.Reader.Set()

                        reloadLastListView()


                    Case AIMMODE

                        unloadOptionsListView()
                        loadOptionAimModeListView()

                    Case AIMMODE_NONE

                        Select Case myScanSampleAPI.Barcode2.Config.Reader.ReaderType
                            Case READER_TYPES.READER_TYPE_IMAGER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimMode = AIM_MODE.AIM_MODE_NONE
                            Case READER_TYPES.READER_TYPE_LASER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimMode = AIM_MODE.AIM_MODE_NONE
                        End Select

                        myScanSampleAPI.Barcode2.Config.Reader.Set()

                        reloadLastListView()


                    Case AIMMODE_DOT

                        Select Case myScanSampleAPI.Barcode2.Config.Reader.ReaderType
                            Case READER_TYPES.READER_TYPE_IMAGER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimMode = AIM_MODE.AIM_MODE_DOT
                            Case READER_TYPES.READER_TYPE_LASER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimMode = AIM_MODE.AIM_MODE_DOT
                        End Select

                        myScanSampleAPI.Barcode2.Config.Reader.Set()

                        reloadLastListView()


                    Case AIMMODE_SLAB

                        Select Case myScanSampleAPI.Barcode2.Config.Reader.ReaderType
                            Case READER_TYPES.READER_TYPE_IMAGER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimMode = AIM_MODE.AIM_MODE_SLAB
                            Case READER_TYPES.READER_TYPE_LASER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimMode = AIM_MODE.AIM_MODE_SLAB
                        End Select

                        myScanSampleAPI.Barcode2.Config.Reader.Set()

                        reloadLastListView()


                    Case AIMMODE_RETICLE

                        Select Case myScanSampleAPI.Barcode2.Config.Reader.ReaderType
                            Case READER_TYPES.READER_TYPE_IMAGER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimMode = AIM_MODE.AIM_MODE_RETICLE
                            Case READER_TYPES.READER_TYPE_LASER
                                myScanSampleAPI.Barcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimMode = AIM_MODE.AIM_MODE_RETICLE
                        End Select

                        myScanSampleAPI.Barcode2.Config.Reader.Set()

                        reloadLastListView()


                    Case SCANTYPE

                        unloadOptionsListView()
                        loadOptionScanTypeListView()

                    Case SCANTYPE_FOREGROUND

                        myScanSampleAPI.Barcode2.Config.Scanner.ScanType = SCANTYPES.Foreground
                        myScanSampleAPI.Barcode2.Config.Scanner.Set()

                        reloadLastListView()


                    Case SCANTYPE_BACKGROUND

                        myScanSampleAPI.Barcode2.Config.Scanner.ScanType = SCANTYPES.Background
                        myScanSampleAPI.Barcode2.Config.Scanner.Set()

                        reloadLastListView()


                    Case SCANTYPE_MONITOR

                        myScanSampleAPI.Barcode2.Config.Scanner.ScanType = SCANTYPES.Monitor
                        myScanSampleAPI.Barcode2.Config.Scanner.Set()

                        reloadLastListView()


                    Case CODE128

                        unloadOptionsListView()
                        loadOptionCode128ListViewItems()

                    Case ENABLED_Renamed

                        If currentListView = CODE128 Then
                            myScanSampleAPI.Barcode2.Config.Decoders.CODE128.Enabled = True
                            myScanSampleAPI.Barcode2.Config.Decoders.Set()
                        Else
                            myScanSampleAPI.Barcode2.Config.Decoders.CODE39.Enabled = True
                            myScanSampleAPI.Barcode2.Config.Decoders.Set()
                        End If

                        reloadLastListView()

                    Case DISABLED

                        If currentListView = CODE128 Then
                            myScanSampleAPI.Barcode2.Config.Decoders.CODE128.Enabled = False
                            myScanSampleAPI.Barcode2.Config.Decoders.Set()
                        Else
                            myScanSampleAPI.Barcode2.Config.Decoders.CODE39.Enabled = False
                            myScanSampleAPI.Barcode2.Config.Decoders.Set()
                        End If

                        reloadLastListView()

                    Case CODE39

                        unloadOptionsListView()
                        loadOptionCode39ListViewItems()

                    Case BACK
                        reloadLastListView()

                    Case Else
                End Select
            Catch e1 As ArgumentOutOfRangeException
                System.Windows.Forms.MessageBox.Show(Resources.GetString("ItemNotSelected"), Resources.GetString("ZFPKCtrl"))
                Me.listViewMain.Focus()
            End Try
            Cursor.Current = savedCursor
        End Sub

        Private Function locateNameColumn(ByVal currentListView As String) As Integer
            Select Case currentListView
                Case ROOT
                    Return 2
                Case SCAN
                    Return 3
                Case OPTIONS
                    Return 3
                Case AIMTYPE, AIMMODE, SCANTYPE, CODE128, CODE39
                    Return 2
                Case Else
                    Return -1 ' Error... Shouldn't be reached.
            End Select
        End Function

        ''' <summary>
        ''' Reloads the previous listView.
        ''' </summary>
        Private Sub reloadLastListView()
            Select Case currentListView
                Case SCAN
                    unloadScanDataListView()
                Case OPTIONS
                    unloadOptionsListView()
                Case AIMTYPE
                    unloadOptionAimTypeListView()
                Case AIMMODE
                    unloadOptionAimModeListView()
                Case SCANTYPE
                    unloadOptionScanTypeListView()
                Case CODE128
                    unloadOptionCode128ListView()
                Case CODE39
                    unloadOptionCode39ListView()
                Case Else
                    Return
            End Select

            ' Only in the case of current page being one for any option
            If currentListView = AIMTYPE OrElse currentListView = AIMMODE OrElse currentListView = SCANTYPE OrElse currentListView = CODE128 OrElse currentListView = CODE39 Then
                ' Load the page for the options.
                loadOptionsListView()
            Else ' In all other cases
                ' Load the main page.
                loadMainListView()
            End If
        End Sub

        ''' <summary>
        ''' The handler for the KeyUp event.
        ''' </summary>
        Private Sub ListViewMain_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles listViewMain.KeyUp
            Me.listViewMain.Focus()
        End Sub

        ''' <summary>
        ''' The handler for the KeyDown event.
        ''' Handle keyboard navigation of the listview.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub ListViewMain_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles listViewMain.KeyDown
            'process softkeys first of all
            Select Case e.KeyCode
                Case Keys.Right
                    Me.Close()
                    Return
            End Select

            'Process rest of the keys
            Dim c As Char = System.Convert.ToChar(e.KeyValue)
            Dim tmpIndex As Integer

            If (c >= "0"c) AndAlso (c <= "9"c) Then
                'A number is pressed
                If timer.Enabled Then
                    'stop the timer after the second digit
                    timer.Enabled = False
                    tmpIndex = selectedIndex * 10 + CInt(Fix(AscW(c) - AscW("0"c)))
                    If listViewMain.Items.Count > tmpIndex Then
                        selectedIndex = tmpIndex
                        gotoListItem()
                    Else
                        selectedIndex = 0
                    End If
                Else
                    tmpIndex = CInt(Fix(AscW(c) - AscW("0"c)))
                    If listViewMain.Items.Count > tmpIndex Then
                        selectedIndex = tmpIndex

                        If listViewMain.Items(0).SubItems(0).Text.Length < 2 Then
                            'list view is one digit so process here
                            gotoListItem()
                            'reset selected index for the next cycle
                            selectedIndex = 0

                        Else
                            'list view has more than 10 items so wait for the next cycle or tick
                            'start timer
                            timer.Enabled = True
                        End If
                    End If
                End If
            End If
        End Sub

        ''' <summary>
        ''' Stop the timer and reset index
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            'stop timer after one tic
            timer.Enabled = False
            'reset selected index for the next cycle
            selectedIndex = 0
        End Sub

        ''' <summary>
        ''' Go to the selected item and expand it if possible
        ''' </summary>
        Private Sub gotoListItem()
            If selectedIndex <= listViewMain.Items.Count Then
                'remove all previous selections
                For i As Integer = 0 To listViewMain.Items.Count - 1
                    listViewMain.Items(i).Selected = False
                Next i

                'select the desired item
                listViewMain.Items(selectedIndex).Selected = True
                listViewMain.Invoke(Me.myActivateHandler)
            End If
        End Sub

        ''' <summary>
        ''' The handler called when resizing MainForm. The UI is re-calculated
        ''' and adjusted based on the dimentions of the screen.
        ''' </summary>
        Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs)
            ' If it is CE
            If Symbol.Win32.PlatformType.IndexOf("PocketPC", 0) <= 0 Then
                If Screen.PrimaryScreen.WorkingArea.Width > 320 Then
                    Me.Width = (320)
                Else
                    Me.Width = (Screen.PrimaryScreen.WorkingArea.Width)
                End If
                If Screen.PrimaryScreen.WorkingArea.Height > 320 Then
                    Me.Height = (320)
                Else
                    Me.Height = (Screen.PrimaryScreen.WorkingArea.Height)
                End If
            End If

        End Sub

        ''' <summary>
        ''' Adjust the listViewMain dimensions, mainly the column widths.
        ''' </summary>
        Private Sub setListViewColumnWidth()
            listViewMain.Width = Me.Width
            listViewMain.Height = Me.Height

            Select Case currentListView
                Case ROOT
                    Me.numberColumn.Width = (10 * listViewMain.Width) / 100
                    Me.itemColumn.Width = (90 * listViewMain.Width) / 100
                Case SCAN
                    Me.numberColumn.Width = (10 * listViewMain.Width) / 100
                    Me.dataColumn.Width = (30 * listViewMain.Width) / 100
                    Me.valueColumn.Width = (60 * listViewMain.Width) / 100

                Case OPTIONS
                    Me.numberColumn.Width = (10 * listViewMain.Width) / 100
                    Me.optionsColumn.Width = (50 * listViewMain.Width) / 100
                    Me.valueColumn.Width = (40 * listViewMain.Width) / 100
                Case AIMTYPE, AIMMODE, CODE128, CODE39
                    Me.numberColumn.Width = (10 * listViewMain.Width) / 100
                    Me.optionColumn.Width = (90 * listViewMain.Width) / 100
                Case Else

            End Select

            Me.nameColumn.Width = 0

        End Sub

        Private Sub panel_Resize(ByVal sender As Object, ByVal e As EventArgs)
            setListViewColumnWidth()
        End Sub

        ''' <summary>
        ''' Read notification handler.
        ''' </summary>
        Private Sub myBarcode2_ScanNotify(ByVal scanDataCollection As ScanDataCollection)
            ' Get ScanData
            Dim scanData As ScanData = scanDataCollection.GetFirst

            Select Case scanData.Result
                Case Results.SUCCESS
                    HandleData(scanData)
                    Me.myScanSampleAPI.StartScan(False)

                Case Results.E_SCN_READTIMEOUT
                    If currentListView = SCAN Then
                        Me.myScanSampleAPI.StartScan(False)
                    End If

                Case Results.CANCELED


                Case Results.E_SCN_DEVICEFAILURE

                    Me.myScanSampleAPI.StopScan()
                    If currentListView = SCAN Then
                        Me.myScanSampleAPI.StartScan(False)
                    End If

                Case Else

                    Dim sMsg As String = "Read Failed" & vbLf & "Result = " & (scanData.Result).ToString()

                    appendListViewContinuousDataItem(sMsg)

                    If scanData.Result = Results.E_SCN_READINCOMPATIBLE Then
                        ' If the failure is E_SCN_READINCOMPATIBLE, exit the application.

                        MessageBox.Show(Resources.GetString("AppExitMsg"), Resources.GetString("Failure"))

                        Me.Close()
                        Return
                    End If

            End Select
        End Sub

        ' '' <summary>
        ' '' Status notification handler.
        ' '' </summary>
        Private Sub myBarcode2_StatusNotify(ByVal statusData As StatusData)
            Select Case statusData.State
                Case States.IDLE

                    If currentListView = SCAN Then
                        statusBar.Text = "Press trigger to scan"
                    End If

                Case Else
                    statusBar.Text = statusData.Text
            End Select
        End Sub

        ''' <summary>
        ''' Handle data from the scan. Used in the scan mode.
        ''' </summary>
        Private Sub HandleData(ByVal scanData As ScanData)
            MessageBox.Show(scanData.Text)
            listViewMain.Items(1).SubItems(2).Text = scanData.Text
            listViewMain.Items(2).SubItems(2).Text = scanData.Type.ToString()
            listViewMain.Items(3).SubItems(2).Text = scanData.Source
            listViewMain.Items(4).SubItems(2).Text = scanData.TimeStamp.ToString()
            listViewMain.Items(5).SubItems(2).Text = scanData.Length.ToString()

        End Sub

        ''' <summary>
        ''' Handle data from the scan. Used in the scan continuous mode.
        ''' </summary>
        Private Sub HandleContinuousData(ByVal scanData As ScanData)
            appendListViewContinuousDataItem(scanData.Text)
        End Sub

        Private Sub MainForm_Activated(ByVal sender As Object, ByVal e As EventArgs)
            Me.listViewMain.Focus()
            If currentListView = SCAN Then
                Me.myScanSampleAPI.StartScan(False)
            End If
        End Sub

        Private Sub MainForm_Deactivate(ByVal sender As Object, ByVal e As EventArgs)
            If (currentListView = SCAN) Then
                myScanSampleAPI.StopScan()
            End If
        End Sub


        Private Sub MainForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            ' Do not exit the app if not on the main screen. Simply return to the previous screen.
            If currentListView <> "Main" Then
                e.Cancel = True

                listViewMain.Focus()
                'ASSERT: Item[0] or the first row is always "Exit"
                listViewMain.Items(0).Selected = True
                listViewMain.Invoke(Me.myActivateHandler)
            End If
            If isBarcodeInitiated Then
                myScanSampleAPI.TermBarcode()

                'Remove ListView event handlers
                RemoveHandler Me.listViewMain.ItemActivate, Me.myActivateHandler

                'Remove Form event handlers
                RemoveHandler Me.Activated, myFormActivatedEventHandler
                RemoveHandler Me.Deactivate, myFormDeactivatedEventHandler
            End If
        End Sub



        Private Const LVM_GETITEMPOSITION As Integer = (&H1010)
        Private Const LVM_GETEXTENDEDLISTVIEWSTYLE As Integer = &H1037
        Private Const LVM_SETEXTENDEDLISTVIEWSTYLE As Integer = &H1036
        Private Const LVS_EX_GRIDLINES As Integer = &H1

        Public Structure Point
            Public x As Integer
            Public y As Integer

            Public Sub New(ByVal x As Integer, ByVal y As Integer)
                Me.x = x
                Me.y = y
            End Sub
        End Structure

        <DllImport("coredll.dll")> _
        Private Shared Function SendMessageW(ByVal hWnd As Integer, ByVal wMsg As UInteger, ByVal wParam As Integer, ByRef lParam As Point) As Integer
        End Function

        <DllImport("coredll.dll")> _
        Private Shared Function SendMessageW(ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
        End Function

        Public Sub setRowHeight(ByVal lvw As System.Windows.Forms.ListView)
            Dim positionItem1 As New Point(0, 0)
            Dim positionItem2 As New Point(0, 0)

            SendMessageW(CInt(lvw.Handle), LVM_GETITEMPOSITION, 0, positionItem1)

            SendMessageW(CInt(lvw.Handle), LVM_GETITEMPOSITION, 1, positionItem2)

            Dim rowHeight As Integer = positionItem2.y - positionItem1.y

            ' Adjust the row height of listViewMain by multiplying the current factor by ROW_HEIGHT_FACTOR.
            '  The usage of this imageList is kind of a workaround in the absense of an exposed API to control the 
            '  row height of System.Windows.Forms.ListView.
            Me.imageList.ImageSize = New Size(1, CInt(Fix(rowHeight * ROW_HEIGHT_FACTOR)))
            lvw.SmallImageList = Me.imageList
        End Sub

        Public Sub setGridLines(ByVal lvw As System.Windows.Forms.ListView)
            Dim extendedStyle As Integer = SendMessageW(CInt(lvw.Handle), LVM_GETEXTENDEDLISTVIEWSTYLE, 0, 0)
            extendedStyle = extendedStyle Or LVS_EX_GRIDLINES
            SendMessageW(CInt(lvw.Handle), LVM_SETEXTENDEDLISTVIEWSTYLE, 0, extendedStyle)
        End Sub

        Private Sub MainForm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus

        End Sub
    End Class
    
End Namespace
