<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVSchedule))
        Me.OpePanel1 = New OPE_Controls.OpePanel(Me.components)
        Me.pnChart = New OPE_Controls.OpePanel(Me.components)
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.grdEmptyRack = New OPE_Controls.opeDataGrid()
        Me.chtEmptyRack = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.pnResult = New OPE_Controls.OpePanel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBreakTime = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTrackTime = New OPE_Controls.OpeTextBox()
        Me.lblTrackTime = New OPE_Controls.OpeLabel(Me.components)
        Me.txtBreakTime = New OPE_Controls.OpeTextBox()
        Me.lblWorkingHrs = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTotalCapacity = New OPE_Controls.OpeTextBox()
        Me.lblTotalCapacity = New OPE_Controls.OpeLabel(Me.components)
        Me.txtWorkingHrs = New OPE_Controls.OpeTextBox()
        Me.lblWorkTime = New OPE_Controls.OpeLabel(Me.components)
        Me.txtWorkTime = New OPE_Controls.OpeTextBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New OPE_Controls.OpeButtonPrint()
        Me.pnCondition = New OPE_Controls.OpePanel(Me.components)
        Me.btnChart = New OPE_Controls.OpeButton(Me.components)
        Me.grpReturn = New OPE_Controls.OpeGroupBox()
        Me.lblBlockForMaintenance = New OPE_Controls.OpeLabel(Me.components)
        Me.txtEmptyRack = New OPE_Controls.OpeTextBox()
        Me.txtBlockForMaintenance = New OPE_Controls.OpeTextBox()
        Me.txtBlockForSkiplot = New OPE_Controls.OpeTextBox()
        Me.lblEmptyRack = New OPE_Controls.OpeLabel(Me.components)
        Me.lblBlogForSkiplot = New OPE_Controls.OpeLabel(Me.components)
        Me.grpDelivery = New OPE_Controls.OpeGroupBox()
        Me.lblIniEmptyRack = New OPE_Controls.OpeLabel(Me.components)
        Me.txtIniEmptyRack = New OPE_Controls.OpeTextBox()
        Me.lblQtyPerTrip = New OPE_Controls.OpeLabel(Me.components)
        Me.txtQtyPerTrip = New OPE_Controls.OpeTextBox()
        Me.lblInitialFG = New OPE_Controls.OpeLabel(Me.components)
        Me.txtInitialFG = New OPE_Controls.OpeTextBox()
        Me.lblTripPerDay = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTripPerDay = New OPE_Controls.OpeTextBox()
        Me.grpRackVisual = New OPE_Controls.OpeGroupBox()
        Me.lblCapacity = New OPE_Controls.OpeLabel(Me.components)
        Me.lblDays = New OPE_Controls.OpeLabel(Me.components)
        Me.lblStartDate = New OPE_Controls.OpeLabel(Me.components)
        Me.txtCapacity = New OPE_Controls.OpeTextBox()
        Me.txtDays = New OPE_Controls.OpeTextBox()
        Me.dtpStartDate = New OPE_Controls.OpeDateTime(Me.components)
        Me.pnHeader = New OPE_Controls.OpePanel(Me.components)
        Me.lblHeader = New OPE_Controls.OpeLabel(Me.components)
        Me.OpePanel1.SuspendLayout()
        Me.pnChart.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.grdEmptyRack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtEmptyRack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnResult.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.pnCondition.SuspendLayout()
        Me.grpReturn.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.grpRackVisual.SuspendLayout()
        Me.pnHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpePanel1
        '
        Me.OpePanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpePanel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OpePanel1.Controls.Add(Me.pnChart)
        Me.OpePanel1.Controls.Add(Me.pnCondition)
        Me.OpePanel1.Location = New System.Drawing.Point(7, 9)
        Me.OpePanel1.Name = "OpePanel1"
        Me.OpePanel1.Size = New System.Drawing.Size(1518, 717)
        Me.OpePanel1.TabIndex = 8
        '
        'pnChart
        '
        Me.pnChart.AutoScroll = True
        Me.pnChart.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnChart.Controls.Add(Me.TabControl)
        Me.pnChart.Controls.Add(Me.pnResult)
        Me.pnChart.Controls.Add(Me.ToolStrip)
        Me.pnChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnChart.Location = New System.Drawing.Point(336, 0)
        Me.pnChart.Name = "pnChart"
        Me.pnChart.Size = New System.Drawing.Size(1182, 717)
        Me.pnChart.TabIndex = 1
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Controls.Add(Me.TabPage4)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 101)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1180, 614)
        Me.TabControl.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1172, 588)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ZF-Empty Rack"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.grdEmptyRack, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.chtEmptyRack, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1166, 582)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'grdEmptyRack
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.grdEmptyRack.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdEmptyRack.AutoGenerateRecordNo = False
        Me.grdEmptyRack.ChangeEnterToTab = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdEmptyRack.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdEmptyRack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdEmptyRack.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdEmptyRack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEmptyRack.EnableHeadersVisualStyles = False
        Me.grdEmptyRack.IsStatus = False
        Me.grdEmptyRack.Location = New System.Drawing.Point(3, 410)
        Me.grdEmptyRack.Name = "grdEmptyRack"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdEmptyRack.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdEmptyRack.Size = New System.Drawing.Size(1160, 169)
        Me.grdEmptyRack.TabIndex = 0
        '
        'chtEmptyRack
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtEmptyRack.ChartAreas.Add(ChartArea1)
        Me.chtEmptyRack.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chtEmptyRack.Legends.Add(Legend1)
        Me.chtEmptyRack.Location = New System.Drawing.Point(3, 3)
        Me.chtEmptyRack.Name = "chtEmptyRack"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Accumulate"
        Me.chtEmptyRack.Series.Add(Series1)
        Me.chtEmptyRack.Size = New System.Drawing.Size(1160, 401)
        Me.chtEmptyRack.TabIndex = 1
        Me.chtEmptyRack.Text = "Chart1"
        '
        'TabPage2
        '
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1172, 588)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ZF-Initial FG"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1172, 588)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Customer-Initial FG"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1172, 588)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Customer-Empty Return"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'pnResult
        '
        Me.pnResult.Controls.Add(Me.TableLayoutPanel1)
        Me.pnResult.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnResult.Location = New System.Drawing.Point(0, 39)
        Me.pnResult.Name = "pnResult"
        Me.pnResult.Size = New System.Drawing.Size(1180, 62)
        Me.pnResult.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblBreakTime, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTrackTime, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTrackTime, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBreakTime, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWorkingHrs, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTotalCapacity, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTotalCapacity, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtWorkingHrs, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWorkTime, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtWorkTime, 5, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1180, 30)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'lblBreakTime
        '
        Me.lblBreakTime.AutoSize = True
        Me.lblBreakTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBreakTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblBreakTime.LabelId = 0
        Me.lblBreakTime.Location = New System.Drawing.Point(3, 0)
        Me.lblBreakTime.Name = "lblBreakTime"
        Me.lblBreakTime.Size = New System.Drawing.Size(116, 30)
        Me.lblBreakTime.TabIndex = 21
        Me.lblBreakTime.Text = "Break Time (Min)"
        Me.lblBreakTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTrackTime
        '
        Me.txtTrackTime.Add_Comma = False
        Me.txtTrackTime.BackColor = System.Drawing.Color.Empty
        Me.txtTrackTime.DataSource = Nothing
        Me.txtTrackTime.DecimalDigit = 0
        Me.txtTrackTime.DisplayMember = Nothing
        Me.txtTrackTime.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTrackTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTrackTime.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTrackTime.LinkCheckedBox = Nothing
        Me.txtTrackTime.Location = New System.Drawing.Point(1051, 3)
        Me.txtTrackTime.MaxValue = 99999.99R
        Me.txtTrackTime.MinValue = -99999.99R
        Me.txtTrackTime.Name = "txtTrackTime"
        Me.txtTrackTime.NotNull = False
        Me.txtTrackTime.ReadOnly = True
        Me.txtTrackTime.ShowDecimal = False
        Me.txtTrackTime.Size = New System.Drawing.Size(80, 23)
        Me.txtTrackTime.TabIndex = 19
        Me.txtTrackTime.TabStop = False
        Me.txtTrackTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTrackTime
        '
        Me.lblTrackTime.AutoSize = True
        Me.lblTrackTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTrackTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTrackTime.LabelId = 0
        Me.lblTrackTime.Location = New System.Drawing.Point(966, 0)
        Me.lblTrackTime.Name = "lblTrackTime"
        Me.lblTrackTime.Size = New System.Drawing.Size(79, 30)
        Me.lblTrackTime.TabIndex = 18
        Me.lblTrackTime.Text = "Track Time"
        Me.lblTrackTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBreakTime
        '
        Me.txtBreakTime.Add_Comma = False
        Me.txtBreakTime.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtBreakTime.DataSource = Nothing
        Me.txtBreakTime.DecimalDigit = 0
        Me.txtBreakTime.DisplayMember = Nothing
        Me.txtBreakTime.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtBreakTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBreakTime.ForeColor = System.Drawing.Color.Red
        Me.txtBreakTime.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtBreakTime.LinkCheckedBox = Nothing
        Me.txtBreakTime.Location = New System.Drawing.Point(125, 3)
        Me.txtBreakTime.MaxValue = 99999.99R
        Me.txtBreakTime.MinValue = -99999.99R
        Me.txtBreakTime.Name = "txtBreakTime"
        Me.txtBreakTime.NotNull = False
        Me.txtBreakTime.ReadOnly = True
        Me.txtBreakTime.ShowDecimal = False
        Me.txtBreakTime.Size = New System.Drawing.Size(80, 23)
        Me.txtBreakTime.TabIndex = 22
        Me.txtBreakTime.TabStop = False
        Me.txtBreakTime.Text = "0"
        Me.txtBreakTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWorkingHrs
        '
        Me.lblWorkingHrs.AutoSize = True
        Me.lblWorkingHrs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWorkingHrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblWorkingHrs.LabelId = 0
        Me.lblWorkingHrs.Location = New System.Drawing.Point(254, 0)
        Me.lblWorkingHrs.Name = "lblWorkingHrs"
        Me.lblWorkingHrs.Size = New System.Drawing.Size(125, 30)
        Me.lblWorkingHrs.TabIndex = 12
        Me.lblWorkingHrs.Text = "Working (Hrs/Day)"
        Me.lblWorkingHrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalCapacity
        '
        Me.txtTotalCapacity.Add_Comma = False
        Me.txtTotalCapacity.BackColor = System.Drawing.Color.Empty
        Me.txtTotalCapacity.DataSource = Nothing
        Me.txtTotalCapacity.DecimalDigit = 0
        Me.txtTotalCapacity.DisplayMember = Nothing
        Me.txtTotalCapacity.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTotalCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTotalCapacity.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTotalCapacity.LinkCheckedBox = Nothing
        Me.txtTotalCapacity.Location = New System.Drawing.Point(837, 3)
        Me.txtTotalCapacity.MaxValue = 99999.99R
        Me.txtTotalCapacity.MinValue = -99999.99R
        Me.txtTotalCapacity.Name = "txtTotalCapacity"
        Me.txtTotalCapacity.NotNull = False
        Me.txtTotalCapacity.ReadOnly = True
        Me.txtTotalCapacity.ShowDecimal = False
        Me.txtTotalCapacity.Size = New System.Drawing.Size(80, 23)
        Me.txtTotalCapacity.TabIndex = 17
        Me.txtTotalCapacity.TabStop = False
        Me.txtTotalCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCapacity
        '
        Me.lblTotalCapacity.AutoSize = True
        Me.lblTotalCapacity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTotalCapacity.LabelId = 0
        Me.lblTotalCapacity.Location = New System.Drawing.Point(733, 0)
        Me.lblTotalCapacity.Name = "lblTotalCapacity"
        Me.lblTotalCapacity.Size = New System.Drawing.Size(98, 30)
        Me.lblTotalCapacity.TabIndex = 16
        Me.lblTotalCapacity.Text = "Total Capacity"
        Me.lblTotalCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWorkingHrs
        '
        Me.txtWorkingHrs.Add_Comma = False
        Me.txtWorkingHrs.BackColor = System.Drawing.Color.Empty
        Me.txtWorkingHrs.DataSource = Nothing
        Me.txtWorkingHrs.DecimalDigit = 0
        Me.txtWorkingHrs.DisplayMember = Nothing
        Me.txtWorkingHrs.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtWorkingHrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtWorkingHrs.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtWorkingHrs.LinkCheckedBox = Nothing
        Me.txtWorkingHrs.Location = New System.Drawing.Point(385, 3)
        Me.txtWorkingHrs.MaxValue = 99999.99R
        Me.txtWorkingHrs.MinValue = -99999.99R
        Me.txtWorkingHrs.Name = "txtWorkingHrs"
        Me.txtWorkingHrs.NotNull = False
        Me.txtWorkingHrs.ReadOnly = True
        Me.txtWorkingHrs.ShowDecimal = False
        Me.txtWorkingHrs.Size = New System.Drawing.Size(80, 23)
        Me.txtWorkingHrs.TabIndex = 13
        Me.txtWorkingHrs.TabStop = False
        Me.txtWorkingHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWorkTime
        '
        Me.lblWorkTime.AutoSize = True
        Me.lblWorkTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWorkTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblWorkTime.LabelId = 0
        Me.lblWorkTime.Location = New System.Drawing.Point(514, 0)
        Me.lblWorkTime.Name = "lblWorkTime"
        Me.lblWorkTime.Size = New System.Drawing.Size(84, 30)
        Me.lblWorkTime.TabIndex = 14
        Me.lblWorkTime.Text = "Actual Work"
        Me.lblWorkTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWorkTime
        '
        Me.txtWorkTime.Add_Comma = False
        Me.txtWorkTime.BackColor = System.Drawing.Color.Empty
        Me.txtWorkTime.DataSource = Nothing
        Me.txtWorkTime.DecimalDigit = 0
        Me.txtWorkTime.DisplayMember = Nothing
        Me.txtWorkTime.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtWorkTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtWorkTime.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtWorkTime.LinkCheckedBox = Nothing
        Me.txtWorkTime.Location = New System.Drawing.Point(604, 3)
        Me.txtWorkTime.MaxValue = 99999.99R
        Me.txtWorkTime.MinValue = -99999.99R
        Me.txtWorkTime.Name = "txtWorkTime"
        Me.txtWorkTime.NotNull = False
        Me.txtWorkTime.ReadOnly = True
        Me.txtWorkTime.ShowDecimal = False
        Me.txtWorkTime.Size = New System.Drawing.Size(80, 23)
        Me.txtWorkTime.TabIndex = 15
        Me.txtWorkTime.TabStop = False
        Me.txtWorkTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1180, 39)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "ToolStrip"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.EnableOnly = False
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(36, 36)
        Me.btnPrint.Text = "Print"
        Me.btnPrint.ToolTipText = "Print"
        '
        'pnCondition
        '
        Me.pnCondition.AutoScroll = True
        Me.pnCondition.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnCondition.Controls.Add(Me.btnChart)
        Me.pnCondition.Controls.Add(Me.grpReturn)
        Me.pnCondition.Controls.Add(Me.grpDelivery)
        Me.pnCondition.Controls.Add(Me.grpRackVisual)
        Me.pnCondition.Controls.Add(Me.pnHeader)
        Me.pnCondition.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnCondition.Location = New System.Drawing.Point(0, 0)
        Me.pnCondition.Name = "pnCondition"
        Me.pnCondition.Size = New System.Drawing.Size(336, 717)
        Me.pnCondition.TabIndex = 0
        '
        'btnChart
        '
        Me.btnChart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChart.BackgroundImage = CType(resources.GetObject("btnChart.BackgroundImage"), System.Drawing.Image)
        Me.btnChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChart.Location = New System.Drawing.Point(182, 575)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(115, 107)
        Me.btnChart.TabIndex = 4
        Me.btnChart.Text = "Preview"
        Me.btnChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'grpReturn
        '
        Me.grpReturn.Controls.Add(Me.lblBlockForMaintenance)
        Me.grpReturn.Controls.Add(Me.txtEmptyRack)
        Me.grpReturn.Controls.Add(Me.txtBlockForMaintenance)
        Me.grpReturn.Controls.Add(Me.txtBlockForSkiplot)
        Me.grpReturn.Controls.Add(Me.lblEmptyRack)
        Me.grpReturn.Controls.Add(Me.lblBlogForSkiplot)
        Me.grpReturn.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReturn.Location = New System.Drawing.Point(0, 305)
        Me.grpReturn.Name = "grpReturn"
        Me.grpReturn.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpReturn.Size = New System.Drawing.Size(334, 132)
        Me.grpReturn.TabIndex = 3
        Me.grpReturn.TabStop = False
        Me.grpReturn.Text = "Return to ZF"
        '
        'lblBlockForMaintenance
        '
        Me.lblBlockForMaintenance.AutoSize = True
        Me.lblBlockForMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblBlockForMaintenance.LabelId = 0
        Me.lblBlockForMaintenance.Location = New System.Drawing.Point(16, 87)
        Me.lblBlockForMaintenance.Name = "lblBlockForMaintenance"
        Me.lblBlockForMaintenance.Size = New System.Drawing.Size(140, 17)
        Me.lblBlockForMaintenance.TabIndex = 4
        Me.lblBlockForMaintenance.Text = "Block for maintenace"
        '
        'txtEmptyRack
        '
        Me.txtEmptyRack.Add_Comma = False
        Me.txtEmptyRack.DataSource = Nothing
        Me.txtEmptyRack.DecimalDigit = 0
        Me.txtEmptyRack.DisplayMember = Nothing
        Me.txtEmptyRack.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtEmptyRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmptyRack.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtEmptyRack.LinkCheckedBox = Nothing
        Me.txtEmptyRack.Location = New System.Drawing.Point(189, 26)
        Me.txtEmptyRack.MaxValue = 99999.99R
        Me.txtEmptyRack.MinValue = -99999.99R
        Me.txtEmptyRack.Name = "txtEmptyRack"
        Me.txtEmptyRack.NotNull = False
        Me.txtEmptyRack.ShowDecimal = False
        Me.txtEmptyRack.Size = New System.Drawing.Size(108, 23)
        Me.txtEmptyRack.TabIndex = 1
        Me.txtEmptyRack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBlockForMaintenance
        '
        Me.txtBlockForMaintenance.Add_Comma = False
        Me.txtBlockForMaintenance.DataSource = Nothing
        Me.txtBlockForMaintenance.DecimalDigit = 0
        Me.txtBlockForMaintenance.DisplayMember = Nothing
        Me.txtBlockForMaintenance.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtBlockForMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBlockForMaintenance.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtBlockForMaintenance.LinkCheckedBox = Nothing
        Me.txtBlockForMaintenance.Location = New System.Drawing.Point(189, 84)
        Me.txtBlockForMaintenance.MaxValue = 99999.99R
        Me.txtBlockForMaintenance.MinValue = -99999.99R
        Me.txtBlockForMaintenance.Name = "txtBlockForMaintenance"
        Me.txtBlockForMaintenance.NotNull = False
        Me.txtBlockForMaintenance.ShowDecimal = False
        Me.txtBlockForMaintenance.Size = New System.Drawing.Size(108, 23)
        Me.txtBlockForMaintenance.TabIndex = 5
        Me.txtBlockForMaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBlockForSkiplot
        '
        Me.txtBlockForSkiplot.Add_Comma = False
        Me.txtBlockForSkiplot.DataSource = Nothing
        Me.txtBlockForSkiplot.DecimalDigit = 0
        Me.txtBlockForSkiplot.DisplayMember = Nothing
        Me.txtBlockForSkiplot.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtBlockForSkiplot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBlockForSkiplot.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtBlockForSkiplot.LinkCheckedBox = Nothing
        Me.txtBlockForSkiplot.Location = New System.Drawing.Point(189, 55)
        Me.txtBlockForSkiplot.MaxValue = 99999.99R
        Me.txtBlockForSkiplot.MinValue = -99999.99R
        Me.txtBlockForSkiplot.Name = "txtBlockForSkiplot"
        Me.txtBlockForSkiplot.NotNull = False
        Me.txtBlockForSkiplot.ShowDecimal = False
        Me.txtBlockForSkiplot.Size = New System.Drawing.Size(108, 23)
        Me.txtBlockForSkiplot.TabIndex = 3
        Me.txtBlockForSkiplot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEmptyRack
        '
        Me.lblEmptyRack.AutoSize = True
        Me.lblEmptyRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblEmptyRack.LabelId = 0
        Me.lblEmptyRack.Location = New System.Drawing.Point(16, 29)
        Me.lblEmptyRack.Name = "lblEmptyRack"
        Me.lblEmptyRack.Size = New System.Drawing.Size(83, 17)
        Me.lblEmptyRack.TabIndex = 0
        Me.lblEmptyRack.Text = "Empty Rack"
        '
        'lblBlogForSkiplot
        '
        Me.lblBlogForSkiplot.AutoSize = True
        Me.lblBlogForSkiplot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblBlogForSkiplot.LabelId = 0
        Me.lblBlogForSkiplot.Location = New System.Drawing.Point(16, 58)
        Me.lblBlogForSkiplot.Name = "lblBlogForSkiplot"
        Me.lblBlogForSkiplot.Size = New System.Drawing.Size(111, 17)
        Me.lblBlogForSkiplot.TabIndex = 2
        Me.lblBlogForSkiplot.Text = "Block for skip lot"
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.lblIniEmptyRack)
        Me.grpDelivery.Controls.Add(Me.txtIniEmptyRack)
        Me.grpDelivery.Controls.Add(Me.lblQtyPerTrip)
        Me.grpDelivery.Controls.Add(Me.txtQtyPerTrip)
        Me.grpDelivery.Controls.Add(Me.lblInitialFG)
        Me.grpDelivery.Controls.Add(Me.txtInitialFG)
        Me.grpDelivery.Controls.Add(Me.lblTripPerDay)
        Me.grpDelivery.Controls.Add(Me.txtTripPerDay)
        Me.grpDelivery.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDelivery.Location = New System.Drawing.Point(0, 151)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpDelivery.Size = New System.Drawing.Size(334, 154)
        Me.grpDelivery.TabIndex = 2
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "ZF Delivery"
        '
        'lblIniEmptyRack
        '
        Me.lblIniEmptyRack.AutoSize = True
        Me.lblIniEmptyRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblIniEmptyRack.LabelId = 0
        Me.lblIniEmptyRack.Location = New System.Drawing.Point(16, 29)
        Me.lblIniEmptyRack.Name = "lblIniEmptyRack"
        Me.lblIniEmptyRack.Size = New System.Drawing.Size(119, 17)
        Me.lblIniEmptyRack.TabIndex = 6
        Me.lblIniEmptyRack.Text = "Initial Empty Rack"
        '
        'txtIniEmptyRack
        '
        Me.txtIniEmptyRack.Add_Comma = False
        Me.txtIniEmptyRack.DataSource = Nothing
        Me.txtIniEmptyRack.DecimalDigit = 0
        Me.txtIniEmptyRack.DisplayMember = Nothing
        Me.txtIniEmptyRack.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtIniEmptyRack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtIniEmptyRack.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtIniEmptyRack.LinkCheckedBox = Nothing
        Me.txtIniEmptyRack.Location = New System.Drawing.Point(189, 26)
        Me.txtIniEmptyRack.MaxValue = 99999.99R
        Me.txtIniEmptyRack.MinValue = -99999.99R
        Me.txtIniEmptyRack.Name = "txtIniEmptyRack"
        Me.txtIniEmptyRack.NotNull = False
        Me.txtIniEmptyRack.ShowDecimal = False
        Me.txtIniEmptyRack.Size = New System.Drawing.Size(108, 23)
        Me.txtIniEmptyRack.TabIndex = 7
        Me.txtIniEmptyRack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQtyPerTrip
        '
        Me.lblQtyPerTrip.AutoSize = True
        Me.lblQtyPerTrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblQtyPerTrip.LabelId = 0
        Me.lblQtyPerTrip.Location = New System.Drawing.Point(16, 116)
        Me.lblQtyPerTrip.Name = "lblQtyPerTrip"
        Me.lblQtyPerTrip.Size = New System.Drawing.Size(59, 17)
        Me.lblQtyPerTrip.TabIndex = 4
        Me.lblQtyPerTrip.Text = "Qty/Trip"
        '
        'txtQtyPerTrip
        '
        Me.txtQtyPerTrip.Add_Comma = False
        Me.txtQtyPerTrip.DataSource = Nothing
        Me.txtQtyPerTrip.DecimalDigit = 0
        Me.txtQtyPerTrip.DisplayMember = Nothing
        Me.txtQtyPerTrip.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtQtyPerTrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtQtyPerTrip.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtQtyPerTrip.LinkCheckedBox = Nothing
        Me.txtQtyPerTrip.Location = New System.Drawing.Point(189, 113)
        Me.txtQtyPerTrip.MaxValue = 99999.99R
        Me.txtQtyPerTrip.MinValue = -99999.99R
        Me.txtQtyPerTrip.Name = "txtQtyPerTrip"
        Me.txtQtyPerTrip.NotNull = False
        Me.txtQtyPerTrip.ShowDecimal = False
        Me.txtQtyPerTrip.Size = New System.Drawing.Size(108, 23)
        Me.txtQtyPerTrip.TabIndex = 5
        Me.txtQtyPerTrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInitialFG
        '
        Me.lblInitialFG.AutoSize = True
        Me.lblInitialFG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblInitialFG.LabelId = 0
        Me.lblInitialFG.Location = New System.Drawing.Point(16, 58)
        Me.lblInitialFG.Name = "lblInitialFG"
        Me.lblInitialFG.Size = New System.Drawing.Size(63, 17)
        Me.lblInitialFG.TabIndex = 0
        Me.lblInitialFG.Text = "Initial FG"
        '
        'txtInitialFG
        '
        Me.txtInitialFG.Add_Comma = False
        Me.txtInitialFG.DataSource = Nothing
        Me.txtInitialFG.DecimalDigit = 0
        Me.txtInitialFG.DisplayMember = Nothing
        Me.txtInitialFG.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtInitialFG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtInitialFG.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtInitialFG.LinkCheckedBox = Nothing
        Me.txtInitialFG.Location = New System.Drawing.Point(189, 55)
        Me.txtInitialFG.MaxValue = 99999.99R
        Me.txtInitialFG.MinValue = -99999.99R
        Me.txtInitialFG.Name = "txtInitialFG"
        Me.txtInitialFG.NotNull = False
        Me.txtInitialFG.ShowDecimal = False
        Me.txtInitialFG.Size = New System.Drawing.Size(108, 23)
        Me.txtInitialFG.TabIndex = 1
        Me.txtInitialFG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTripPerDay
        '
        Me.lblTripPerDay.AutoSize = True
        Me.lblTripPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTripPerDay.LabelId = 0
        Me.lblTripPerDay.Location = New System.Drawing.Point(16, 87)
        Me.lblTripPerDay.Name = "lblTripPerDay"
        Me.lblTripPerDay.Size = New System.Drawing.Size(62, 17)
        Me.lblTripPerDay.TabIndex = 2
        Me.lblTripPerDay.Text = "Trip/Day"
        '
        'txtTripPerDay
        '
        Me.txtTripPerDay.Add_Comma = False
        Me.txtTripPerDay.DataSource = Nothing
        Me.txtTripPerDay.DecimalDigit = 0
        Me.txtTripPerDay.DisplayMember = Nothing
        Me.txtTripPerDay.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTripPerDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTripPerDay.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTripPerDay.LinkCheckedBox = Nothing
        Me.txtTripPerDay.Location = New System.Drawing.Point(189, 84)
        Me.txtTripPerDay.MaxValue = 99999.99R
        Me.txtTripPerDay.MinValue = -99999.99R
        Me.txtTripPerDay.Name = "txtTripPerDay"
        Me.txtTripPerDay.NotNull = False
        Me.txtTripPerDay.ShowDecimal = False
        Me.txtTripPerDay.Size = New System.Drawing.Size(108, 23)
        Me.txtTripPerDay.TabIndex = 3
        Me.txtTripPerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpRackVisual
        '
        Me.grpRackVisual.Controls.Add(Me.lblCapacity)
        Me.grpRackVisual.Controls.Add(Me.lblDays)
        Me.grpRackVisual.Controls.Add(Me.lblStartDate)
        Me.grpRackVisual.Controls.Add(Me.txtCapacity)
        Me.grpRackVisual.Controls.Add(Me.txtDays)
        Me.grpRackVisual.Controls.Add(Me.dtpStartDate)
        Me.grpRackVisual.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRackVisual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRackVisual.Location = New System.Drawing.Point(0, 35)
        Me.grpRackVisual.Name = "grpRackVisual"
        Me.grpRackVisual.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpRackVisual.Size = New System.Drawing.Size(334, 116)
        Me.grpRackVisual.TabIndex = 1
        Me.grpRackVisual.TabStop = False
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCapacity.LabelId = 0
        Me.lblCapacity.Location = New System.Drawing.Point(16, 79)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(102, 17)
        Me.lblCapacity.TabIndex = 4
        Me.lblCapacity.Text = "Capacity (JPH)"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDays.LabelId = 0
        Me.lblDays.Location = New System.Drawing.Point(16, 49)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(40, 17)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "Days"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStartDate.LabelId = 0
        Me.lblStartDate.Location = New System.Drawing.Point(16, 20)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(72, 17)
        Me.lblStartDate.TabIndex = 0
        Me.lblStartDate.Text = "Start Date"
        '
        'txtCapacity
        '
        Me.txtCapacity.Add_Comma = False
        Me.txtCapacity.DataSource = Nothing
        Me.txtCapacity.DecimalDigit = 0
        Me.txtCapacity.DisplayMember = Nothing
        Me.txtCapacity.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCapacity.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtCapacity.LinkCheckedBox = Nothing
        Me.txtCapacity.Location = New System.Drawing.Point(189, 76)
        Me.txtCapacity.MaxValue = 99999.99R
        Me.txtCapacity.MinValue = -99999.99R
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.NotNull = False
        Me.txtCapacity.ShowDecimal = False
        Me.txtCapacity.Size = New System.Drawing.Size(108, 23)
        Me.txtCapacity.TabIndex = 5
        Me.txtCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDays
        '
        Me.txtDays.Add_Comma = False
        Me.txtDays.DataSource = Nothing
        Me.txtDays.DecimalDigit = 0
        Me.txtDays.DisplayMember = Nothing
        Me.txtDays.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDays.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtDays.LinkCheckedBox = Nothing
        Me.txtDays.Location = New System.Drawing.Point(189, 46)
        Me.txtDays.MaxValue = 99999.99R
        Me.txtDays.MinValue = -99999.99R
        Me.txtDays.Name = "txtDays"
        Me.txtDays.NotNull = False
        Me.txtDays.ShowDecimal = False
        Me.txtDays.Size = New System.Drawing.Size(108, 23)
        Me.txtDays.TabIndex = 3
        Me.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.HideButton = False
        Me.dtpStartDate.LinkCheckedBox = Nothing
        Me.dtpStartDate.LinkDateTime = Nothing
        Me.dtpStartDate.Location = New System.Drawing.Point(189, 17)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(108, 23)
        Me.dtpStartDate.TabIndex = 1
        Me.dtpStartDate.TextValue = "20180530"
        Me.dtpStartDate.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.pnHeader.Controls.Add(Me.lblHeader)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(334, 35)
        Me.pnHeader.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.LabelId = 0
        Me.lblHeader.Location = New System.Drawing.Point(126, 5)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(119, 24)
        Me.lblHeader.TabIndex = 18
        Me.lblHeader.Text = "Rack Visual"
        '
        'clsVSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1532, 733)
        Me.Controls.Add(Me.OpePanel1)
        Me.Name = "clsVSchedule"
        Me.Text = "Schedule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.OpePanel1.ResumeLayout(False)
        Me.pnChart.ResumeLayout(False)
        Me.pnChart.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.grdEmptyRack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtEmptyRack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnResult.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.pnCondition.ResumeLayout(False)
        Me.grpReturn.ResumeLayout(False)
        Me.grpReturn.PerformLayout()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.grpRackVisual.ResumeLayout(False)
        Me.grpRackVisual.PerformLayout()
        Me.pnHeader.ResumeLayout(False)
        Me.pnHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpePanel1 As OPE_Controls.OpePanel
    Friend WithEvents pnChart As OPE_Controls.OpePanel
    Friend WithEvents pnCondition As OPE_Controls.OpePanel
    Friend WithEvents grpReturn As OPE_Controls.OpeGroupBox
    Friend WithEvents lblBlockForMaintenance As OPE_Controls.OpeLabel
    Friend WithEvents txtEmptyRack As OPE_Controls.OpeTextBox
    Friend WithEvents txtBlockForMaintenance As OPE_Controls.OpeTextBox
    Friend WithEvents txtBlockForSkiplot As OPE_Controls.OpeTextBox
    Friend WithEvents lblEmptyRack As OPE_Controls.OpeLabel
    Friend WithEvents lblBlogForSkiplot As OPE_Controls.OpeLabel
    Friend WithEvents grpDelivery As OPE_Controls.OpeGroupBox
    Friend WithEvents lblQtyPerTrip As OPE_Controls.OpeLabel
    Friend WithEvents txtQtyPerTrip As OPE_Controls.OpeTextBox
    Friend WithEvents lblInitialFG As OPE_Controls.OpeLabel
    Friend WithEvents txtInitialFG As OPE_Controls.OpeTextBox
    Friend WithEvents lblTripPerDay As OPE_Controls.OpeLabel
    Friend WithEvents txtTripPerDay As OPE_Controls.OpeTextBox
    Friend WithEvents grpRackVisual As OPE_Controls.OpeGroupBox
    Friend WithEvents lblCapacity As OPE_Controls.OpeLabel
    Friend WithEvents lblDays As OPE_Controls.OpeLabel
    Friend WithEvents lblStartDate As OPE_Controls.OpeLabel
    Friend WithEvents txtCapacity As OPE_Controls.OpeTextBox
    Friend WithEvents txtDays As OPE_Controls.OpeTextBox
    Friend WithEvents dtpStartDate As OPE_Controls.OpeDateTime
    Friend WithEvents pnHeader As OPE_Controls.OpePanel
    Friend WithEvents lblHeader As OPE_Controls.OpeLabel
    Friend WithEvents btnChart As OPE_Controls.OpeButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As OPE_Controls.OpeButtonPrint
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents pnResult As OPE_Controls.OpePanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblBreakTime As OPE_Controls.OpeLabel
    Friend WithEvents txtBreakTime As OPE_Controls.OpeTextBox
    Friend WithEvents lblWorkingHrs As OPE_Controls.OpeLabel
    Friend WithEvents txtWorkingHrs As OPE_Controls.OpeTextBox
    Friend WithEvents lblTrackTime As OPE_Controls.OpeLabel
    Friend WithEvents txtTrackTime As OPE_Controls.OpeTextBox
    Friend WithEvents lblTotalCapacity As OPE_Controls.OpeLabel
    Friend WithEvents txtTotalCapacity As OPE_Controls.OpeTextBox
    Friend WithEvents lblWorkTime As OPE_Controls.OpeLabel
    Friend WithEvents txtWorkTime As OPE_Controls.OpeTextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grdEmptyRack As OPE_Controls.opeDataGrid
    Friend WithEvents chtEmptyRack As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblIniEmptyRack As OPE_Controls.OpeLabel
    Friend WithEvents txtIniEmptyRack As OPE_Controls.OpeTextBox
End Class
