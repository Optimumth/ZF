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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVSchedule))
        Me.OpePanel1 = New OPE_Controls.OpePanel(Me.components)
        Me.pnChart = New OPE_Controls.OpePanel(Me.components)
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.pgeOverview = New System.Windows.Forms.TabPage()
        Me.TabLayOutOverview = New System.Windows.Forms.TableLayoutPanel()
        Me.grdOverview = New OPE_Controls.opeDataGrid()
        Me.pgeZFEmptyRack = New System.Windows.Forms.TabPage()
        Me.pgeZFFG = New System.Windows.Forms.TabPage()
        Me.pgeCusFG = New System.Windows.Forms.TabPage()
        Me.pgeCusEmptyReturn = New System.Windows.Forms.TabPage()
        Me.pnResult = New OPE_Controls.OpePanel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblWorkingHrsZF = New OPE_Controls.OpeLabel(Me.components)
        Me.txtBreakTimeZF = New OPE_Controls.OpeTextBox()
        Me.OpeLabel1 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtWorkingHrsZF = New OPE_Controls.OpeTextBox()
        Me.lblWorkTimeZF = New OPE_Controls.OpeLabel(Me.components)
        Me.txtWorkTimeZF = New OPE_Controls.OpeTextBox()
        Me.lblBreakTimeZF = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTotalCapacityZF = New OPE_Controls.OpeTextBox()
        Me.lblTotalCapacity = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTrackTimeZF = New OPE_Controls.OpeTextBox()
        Me.lblTrackTimeZF = New OPE_Controls.OpeLabel(Me.components)
        Me.OpeLabel2 = New OPE_Controls.OpeLabel(Me.components)
        Me.OpeLabel6 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTripPerDayZF = New OPE_Controls.OpeTextBox()
        Me.txtTripPerDayCus = New OPE_Controls.OpeTextBox()
        Me.txtTotalCapacityCus = New OPE_Controls.OpeTextBox()
        Me.txtTrackTimeCus = New OPE_Controls.OpeTextBox()
        Me.txtWorkingHrsCus = New OPE_Controls.OpeTextBox()
        Me.txtWorkTimeCus = New OPE_Controls.OpeTextBox()
        Me.txtBreakTimeCus = New OPE_Controls.OpeTextBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnChart = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New OPE_Controls.OpeButtonPrint()
        Me.pnCondition = New OPE_Controls.OpePanel(Me.components)
        Me.grpReturn = New OPE_Controls.OpeGroupBox()
        Me.OpeLabel5 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTravelMinsCus = New OPE_Controls.OpeTextBox()
        Me.OpeLabel3 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtCapacityCus = New OPE_Controls.OpeTextBox()
        Me.lblQtyPerTripCus = New OPE_Controls.OpeLabel(Me.components)
        Me.txtQtyPerTripCus = New OPE_Controls.OpeTextBox()
        Me.lblInitialFGCus = New OPE_Controls.OpeLabel(Me.components)
        Me.txtInitialFGCus = New OPE_Controls.OpeTextBox()
        Me.txtIniEmptyRackCus = New OPE_Controls.OpeTextBox()
        Me.lblIniEmptyRackCus = New OPE_Controls.OpeLabel(Me.components)
        Me.grpDelivery = New OPE_Controls.OpeGroupBox()
        Me.OpeLabel4 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTravelMinsZF = New OPE_Controls.OpeTextBox()
        Me.lblCapacity = New OPE_Controls.OpeLabel(Me.components)
        Me.txtCapacityZF = New OPE_Controls.OpeTextBox()
        Me.lblBlockForMaintenance = New OPE_Controls.OpeLabel(Me.components)
        Me.txtBlockForMaintenance = New OPE_Controls.OpeTextBox()
        Me.txtBlockForSkiplot = New OPE_Controls.OpeTextBox()
        Me.lblBlogForSkiplot = New OPE_Controls.OpeLabel(Me.components)
        Me.lblIniEmptyRackZF = New OPE_Controls.OpeLabel(Me.components)
        Me.txtIniEmptyRackZF = New OPE_Controls.OpeTextBox()
        Me.lblQtyPerTripZF = New OPE_Controls.OpeLabel(Me.components)
        Me.txtQtyPerTripZF = New OPE_Controls.OpeTextBox()
        Me.lblInitialFGZF = New OPE_Controls.OpeLabel(Me.components)
        Me.txtInitialFGZF = New OPE_Controls.OpeTextBox()
        Me.grpRackVisual = New OPE_Controls.OpeGroupBox()
        Me.lblDays = New OPE_Controls.OpeLabel(Me.components)
        Me.txtDays = New OPE_Controls.OpeTextBox()
        Me.pnHeader = New OPE_Controls.OpePanel(Me.components)
        Me.btnShowConfig = New System.Windows.Forms.Button()
        Me.lblHeader = New OPE_Controls.OpeLabel(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpePanel1.SuspendLayout()
        Me.pnChart.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.pgeOverview.SuspendLayout()
        Me.TabLayOutOverview.SuspendLayout()
        CType(Me.grdOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnResult.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.pnCondition.SuspendLayout()
        Me.grpReturn.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.grpRackVisual.SuspendLayout()
        Me.pnHeader.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.OpePanel1.Size = New System.Drawing.Size(1531, 810)
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
        Me.pnChart.Location = New System.Drawing.Point(350, 0)
        Me.pnChart.Name = "pnChart"
        Me.pnChart.Size = New System.Drawing.Size(1181, 810)
        Me.pnChart.TabIndex = 1
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.pgeOverview)
        Me.TabControl.Controls.Add(Me.pgeZFEmptyRack)
        Me.TabControl.Controls.Add(Me.pgeZFFG)
        Me.TabControl.Controls.Add(Me.pgeCusFG)
        Me.TabControl.Controls.Add(Me.pgeCusEmptyReturn)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 127)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1179, 681)
        Me.TabControl.TabIndex = 2
        Me.TabControl.TabStop = False
        '
        'pgeOverview
        '
        Me.pgeOverview.AutoScroll = True
        Me.pgeOverview.Controls.Add(Me.TabLayOutOverview)
        Me.pgeOverview.Location = New System.Drawing.Point(4, 22)
        Me.pgeOverview.Name = "pgeOverview"
        Me.pgeOverview.Size = New System.Drawing.Size(1171, 655)
        Me.pgeOverview.TabIndex = 4
        Me.pgeOverview.Text = "Overview"
        Me.pgeOverview.UseVisualStyleBackColor = True
        '
        'TabLayOutOverview
        '
        Me.TabLayOutOverview.ColumnCount = 1
        Me.TabLayOutOverview.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TabLayOutOverview.Controls.Add(Me.grdOverview, 0, 1)
        Me.TabLayOutOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabLayOutOverview.Location = New System.Drawing.Point(0, 0)
        Me.TabLayOutOverview.Name = "TabLayOutOverview"
        Me.TabLayOutOverview.RowCount = 2
        Me.TabLayOutOverview.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TabLayOutOverview.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TabLayOutOverview.Size = New System.Drawing.Size(1171, 655)
        Me.TabLayOutOverview.TabIndex = 1
        '
        'grdOverview
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan
        Me.grdOverview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grdOverview.AutoGenerateRecordNo = False
        Me.grdOverview.ChangeEnterToTab = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdOverview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdOverview.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdOverview.EnableHeadersVisualStyles = False
        Me.grdOverview.IsStatus = False
        Me.grdOverview.Location = New System.Drawing.Point(3, 461)
        Me.grdOverview.Name = "grdOverview"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdOverview.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdOverview.Size = New System.Drawing.Size(1165, 191)
        Me.grdOverview.TabIndex = 0
        '
        'pgeZFEmptyRack
        '
        Me.pgeZFEmptyRack.AutoScroll = True
        Me.pgeZFEmptyRack.Location = New System.Drawing.Point(4, 22)
        Me.pgeZFEmptyRack.Name = "pgeZFEmptyRack"
        Me.pgeZFEmptyRack.Size = New System.Drawing.Size(1171, 655)
        Me.pgeZFEmptyRack.TabIndex = 5
        Me.pgeZFEmptyRack.Text = "ZF-Empty Rack"
        Me.pgeZFEmptyRack.UseVisualStyleBackColor = True
        '
        'pgeZFFG
        '
        Me.pgeZFFG.AutoScroll = True
        Me.pgeZFFG.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgeZFFG.Location = New System.Drawing.Point(4, 22)
        Me.pgeZFFG.Name = "pgeZFFG"
        Me.pgeZFFG.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeZFFG.Size = New System.Drawing.Size(1171, 655)
        Me.pgeZFFG.TabIndex = 1
        Me.pgeZFFG.Text = "ZF-FG"
        Me.pgeZFFG.UseVisualStyleBackColor = True
        '
        'pgeCusFG
        '
        Me.pgeCusFG.AutoScroll = True
        Me.pgeCusFG.Location = New System.Drawing.Point(4, 22)
        Me.pgeCusFG.Name = "pgeCusFG"
        Me.pgeCusFG.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeCusFG.Size = New System.Drawing.Size(1171, 655)
        Me.pgeCusFG.TabIndex = 2
        Me.pgeCusFG.Text = "Customer-FG"
        Me.pgeCusFG.UseVisualStyleBackColor = True
        '
        'pgeCusEmptyReturn
        '
        Me.pgeCusEmptyReturn.AutoScroll = True
        Me.pgeCusEmptyReturn.Location = New System.Drawing.Point(4, 22)
        Me.pgeCusEmptyReturn.Name = "pgeCusEmptyReturn"
        Me.pgeCusEmptyReturn.Size = New System.Drawing.Size(1171, 655)
        Me.pgeCusEmptyReturn.TabIndex = 3
        Me.pgeCusEmptyReturn.Text = "Customer-Empty Return"
        Me.pgeCusEmptyReturn.UseVisualStyleBackColor = True
        '
        'pnResult
        '
        Me.pnResult.Controls.Add(Me.TableLayoutPanel1)
        Me.pnResult.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnResult.Location = New System.Drawing.Point(0, 42)
        Me.pnResult.Name = "pnResult"
        Me.pnResult.Size = New System.Drawing.Size(1179, 85)
        Me.pnResult.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.16738!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.16738!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.16738!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.16738!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.16738!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.16309!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblWorkingHrsZF, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBreakTimeZF, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.OpeLabel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtWorkingHrsZF, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWorkTimeZF, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtWorkTimeZF, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBreakTimeZF, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTotalCapacityZF, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTotalCapacity, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTrackTimeZF, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTrackTimeZF, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OpeLabel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.OpeLabel6, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTripPerDayZF, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTripPerDayCus, 6, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTotalCapacityCus, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTrackTimeCus, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtWorkingHrsCus, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtWorkTimeCus, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBreakTimeCus, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1179, 85)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'lblWorkingHrsZF
        '
        Me.lblWorkingHrsZF.AutoSize = True
        Me.lblWorkingHrsZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWorkingHrsZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblWorkingHrsZF.LabelId = 0
        Me.lblWorkingHrsZF.Location = New System.Drawing.Point(288, 0)
        Me.lblWorkingHrsZF.Name = "lblWorkingHrsZF"
        Me.lblWorkingHrsZF.Size = New System.Drawing.Size(179, 28)
        Me.lblWorkingHrsZF.TabIndex = 12
        Me.lblWorkingHrsZF.Text = "Working (Hrs/Day)"
        Me.lblWorkingHrsZF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBreakTimeZF
        '
        Me.txtBreakTimeZF.Add_Comma = False
        Me.txtBreakTimeZF.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtBreakTimeZF.DataSource = Nothing
        Me.txtBreakTimeZF.DecimalDigit = 0
        Me.txtBreakTimeZF.DisplayMember = Nothing
        Me.txtBreakTimeZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBreakTimeZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtBreakTimeZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBreakTimeZF.ForeColor = System.Drawing.Color.Black
        Me.txtBreakTimeZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtBreakTimeZF.LinkCheckedBox = Nothing
        Me.txtBreakTimeZF.Location = New System.Drawing.Point(103, 31)
        Me.txtBreakTimeZF.MaxValue = 99999.99R
        Me.txtBreakTimeZF.MinValue = -99999.99R
        Me.txtBreakTimeZF.Name = "txtBreakTimeZF"
        Me.txtBreakTimeZF.NotNull = False
        Me.txtBreakTimeZF.ReadOnly = True
        Me.txtBreakTimeZF.ShowDecimal = False
        Me.txtBreakTimeZF.Size = New System.Drawing.Size(179, 23)
        Me.txtBreakTimeZF.TabIndex = 22
        Me.txtBreakTimeZF.TabStop = False
        Me.txtBreakTimeZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel1
        '
        Me.OpeLabel1.AutoSize = True
        Me.OpeLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel1.LabelId = 0
        Me.OpeLabel1.Location = New System.Drawing.Point(103, 0)
        Me.OpeLabel1.Name = "OpeLabel1"
        Me.OpeLabel1.Size = New System.Drawing.Size(179, 28)
        Me.OpeLabel1.TabIndex = 21
        Me.OpeLabel1.Text = "Break Time (Min)"
        Me.OpeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWorkingHrsZF
        '
        Me.txtWorkingHrsZF.Add_Comma = False
        Me.txtWorkingHrsZF.BackColor = System.Drawing.Color.Empty
        Me.txtWorkingHrsZF.DataSource = Nothing
        Me.txtWorkingHrsZF.DecimalDigit = 0
        Me.txtWorkingHrsZF.DisplayMember = Nothing
        Me.txtWorkingHrsZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWorkingHrsZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtWorkingHrsZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtWorkingHrsZF.ForeColor = System.Drawing.Color.Black
        Me.txtWorkingHrsZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtWorkingHrsZF.LinkCheckedBox = Nothing
        Me.txtWorkingHrsZF.Location = New System.Drawing.Point(288, 31)
        Me.txtWorkingHrsZF.MaxValue = 99999.99R
        Me.txtWorkingHrsZF.MinValue = -99999.99R
        Me.txtWorkingHrsZF.Name = "txtWorkingHrsZF"
        Me.txtWorkingHrsZF.NotNull = False
        Me.txtWorkingHrsZF.ReadOnly = True
        Me.txtWorkingHrsZF.ShowDecimal = False
        Me.txtWorkingHrsZF.Size = New System.Drawing.Size(179, 23)
        Me.txtWorkingHrsZF.TabIndex = 13
        Me.txtWorkingHrsZF.TabStop = False
        Me.txtWorkingHrsZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWorkTimeZF
        '
        Me.lblWorkTimeZF.AutoSize = True
        Me.lblWorkTimeZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWorkTimeZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblWorkTimeZF.LabelId = 0
        Me.lblWorkTimeZF.Location = New System.Drawing.Point(473, 0)
        Me.lblWorkTimeZF.Name = "lblWorkTimeZF"
        Me.lblWorkTimeZF.Size = New System.Drawing.Size(179, 28)
        Me.lblWorkTimeZF.TabIndex = 14
        Me.lblWorkTimeZF.Text = "Actual Work"
        Me.lblWorkTimeZF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWorkTimeZF
        '
        Me.txtWorkTimeZF.Add_Comma = False
        Me.txtWorkTimeZF.BackColor = System.Drawing.Color.Empty
        Me.txtWorkTimeZF.DataSource = Nothing
        Me.txtWorkTimeZF.DecimalDigit = 0
        Me.txtWorkTimeZF.DisplayMember = Nothing
        Me.txtWorkTimeZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWorkTimeZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtWorkTimeZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtWorkTimeZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtWorkTimeZF.LinkCheckedBox = Nothing
        Me.txtWorkTimeZF.Location = New System.Drawing.Point(473, 31)
        Me.txtWorkTimeZF.MaxValue = 99999.99R
        Me.txtWorkTimeZF.MinValue = -99999.99R
        Me.txtWorkTimeZF.Name = "txtWorkTimeZF"
        Me.txtWorkTimeZF.NotNull = False
        Me.txtWorkTimeZF.ReadOnly = True
        Me.txtWorkTimeZF.ShowDecimal = False
        Me.txtWorkTimeZF.Size = New System.Drawing.Size(179, 23)
        Me.txtWorkTimeZF.TabIndex = 15
        Me.txtWorkTimeZF.TabStop = False
        Me.txtWorkTimeZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBreakTimeZF
        '
        Me.lblBreakTimeZF.AutoSize = True
        Me.lblBreakTimeZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBreakTimeZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblBreakTimeZF.LabelId = 0
        Me.lblBreakTimeZF.Location = New System.Drawing.Point(3, 28)
        Me.lblBreakTimeZF.Name = "lblBreakTimeZF"
        Me.lblBreakTimeZF.Size = New System.Drawing.Size(94, 28)
        Me.lblBreakTimeZF.TabIndex = 21
        Me.lblBreakTimeZF.Text = "ZF"
        Me.lblBreakTimeZF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalCapacityZF
        '
        Me.txtTotalCapacityZF.Add_Comma = False
        Me.txtTotalCapacityZF.BackColor = System.Drawing.Color.Empty
        Me.txtTotalCapacityZF.DataSource = Nothing
        Me.txtTotalCapacityZF.DecimalDigit = 2
        Me.txtTotalCapacityZF.DisplayMember = Nothing
        Me.txtTotalCapacityZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotalCapacityZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTotalCapacityZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTotalCapacityZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTotalCapacityZF.LinkCheckedBox = Nothing
        Me.txtTotalCapacityZF.Location = New System.Drawing.Point(658, 31)
        Me.txtTotalCapacityZF.MaxValue = 99999.99R
        Me.txtTotalCapacityZF.MinValue = -99999.99R
        Me.txtTotalCapacityZF.Name = "txtTotalCapacityZF"
        Me.txtTotalCapacityZF.NotNull = False
        Me.txtTotalCapacityZF.ReadOnly = True
        Me.txtTotalCapacityZF.ShowDecimal = True
        Me.txtTotalCapacityZF.Size = New System.Drawing.Size(179, 23)
        Me.txtTotalCapacityZF.TabIndex = 17
        Me.txtTotalCapacityZF.TabStop = False
        Me.txtTotalCapacityZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCapacity
        '
        Me.lblTotalCapacity.AutoSize = True
        Me.lblTotalCapacity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTotalCapacity.LabelId = 0
        Me.lblTotalCapacity.Location = New System.Drawing.Point(658, 0)
        Me.lblTotalCapacity.Name = "lblTotalCapacity"
        Me.lblTotalCapacity.Size = New System.Drawing.Size(179, 28)
        Me.lblTotalCapacity.TabIndex = 16
        Me.lblTotalCapacity.Text = "Total Capacity"
        Me.lblTotalCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTrackTimeZF
        '
        Me.txtTrackTimeZF.Add_Comma = False
        Me.txtTrackTimeZF.BackColor = System.Drawing.Color.Empty
        Me.txtTrackTimeZF.DataSource = Nothing
        Me.txtTrackTimeZF.DecimalDigit = 0
        Me.txtTrackTimeZF.DisplayMember = Nothing
        Me.txtTrackTimeZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTrackTimeZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTrackTimeZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTrackTimeZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTrackTimeZF.LinkCheckedBox = Nothing
        Me.txtTrackTimeZF.Location = New System.Drawing.Point(843, 31)
        Me.txtTrackTimeZF.MaxValue = 99999.99R
        Me.txtTrackTimeZF.MinValue = -99999.99R
        Me.txtTrackTimeZF.Name = "txtTrackTimeZF"
        Me.txtTrackTimeZF.NotNull = False
        Me.txtTrackTimeZF.ReadOnly = True
        Me.txtTrackTimeZF.ShowDecimal = False
        Me.txtTrackTimeZF.Size = New System.Drawing.Size(179, 23)
        Me.txtTrackTimeZF.TabIndex = 19
        Me.txtTrackTimeZF.TabStop = False
        Me.txtTrackTimeZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTrackTimeZF
        '
        Me.lblTrackTimeZF.AutoSize = True
        Me.lblTrackTimeZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTrackTimeZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTrackTimeZF.LabelId = 0
        Me.lblTrackTimeZF.Location = New System.Drawing.Point(843, 0)
        Me.lblTrackTimeZF.Name = "lblTrackTimeZF"
        Me.lblTrackTimeZF.Size = New System.Drawing.Size(179, 28)
        Me.lblTrackTimeZF.TabIndex = 18
        Me.lblTrackTimeZF.Text = "Track Time"
        Me.lblTrackTimeZF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpeLabel2
        '
        Me.OpeLabel2.AutoSize = True
        Me.OpeLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpeLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel2.LabelId = 0
        Me.OpeLabel2.Location = New System.Drawing.Point(3, 56)
        Me.OpeLabel2.Name = "OpeLabel2"
        Me.OpeLabel2.Size = New System.Drawing.Size(94, 29)
        Me.OpeLabel2.TabIndex = 21
        Me.OpeLabel2.Text = "Customer"
        Me.OpeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpeLabel6
        '
        Me.OpeLabel6.AutoSize = True
        Me.OpeLabel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpeLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel6.LabelId = 0
        Me.OpeLabel6.Location = New System.Drawing.Point(1028, 0)
        Me.OpeLabel6.Name = "OpeLabel6"
        Me.OpeLabel6.Size = New System.Drawing.Size(148, 28)
        Me.OpeLabel6.TabIndex = 28
        Me.OpeLabel6.Text = "Trip/Day"
        Me.OpeLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTripPerDayZF
        '
        Me.txtTripPerDayZF.Add_Comma = False
        Me.txtTripPerDayZF.BackColor = System.Drawing.Color.Empty
        Me.txtTripPerDayZF.DataSource = Nothing
        Me.txtTripPerDayZF.DecimalDigit = 0
        Me.txtTripPerDayZF.DisplayMember = Nothing
        Me.txtTripPerDayZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTripPerDayZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTripPerDayZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTripPerDayZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTripPerDayZF.LinkCheckedBox = Nothing
        Me.txtTripPerDayZF.Location = New System.Drawing.Point(1028, 31)
        Me.txtTripPerDayZF.MaxValue = 99999.99R
        Me.txtTripPerDayZF.MinValue = -99999.99R
        Me.txtTripPerDayZF.Name = "txtTripPerDayZF"
        Me.txtTripPerDayZF.NotNull = False
        Me.txtTripPerDayZF.ReadOnly = True
        Me.txtTripPerDayZF.ShowDecimal = False
        Me.txtTripPerDayZF.Size = New System.Drawing.Size(148, 23)
        Me.txtTripPerDayZF.TabIndex = 27
        Me.txtTripPerDayZF.TabStop = False
        Me.txtTripPerDayZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTripPerDayCus
        '
        Me.txtTripPerDayCus.Add_Comma = False
        Me.txtTripPerDayCus.BackColor = System.Drawing.Color.Empty
        Me.txtTripPerDayCus.DataSource = Nothing
        Me.txtTripPerDayCus.DecimalDigit = 0
        Me.txtTripPerDayCus.DisplayMember = Nothing
        Me.txtTripPerDayCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTripPerDayCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTripPerDayCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTripPerDayCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTripPerDayCus.LinkCheckedBox = Nothing
        Me.txtTripPerDayCus.Location = New System.Drawing.Point(1028, 59)
        Me.txtTripPerDayCus.MaxValue = 99999.99R
        Me.txtTripPerDayCus.MinValue = -99999.99R
        Me.txtTripPerDayCus.Name = "txtTripPerDayCus"
        Me.txtTripPerDayCus.NotNull = False
        Me.txtTripPerDayCus.ReadOnly = True
        Me.txtTripPerDayCus.ShowDecimal = False
        Me.txtTripPerDayCus.Size = New System.Drawing.Size(148, 23)
        Me.txtTripPerDayCus.TabIndex = 27
        Me.txtTripPerDayCus.TabStop = False
        Me.txtTripPerDayCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalCapacityCus
        '
        Me.txtTotalCapacityCus.Add_Comma = False
        Me.txtTotalCapacityCus.BackColor = System.Drawing.Color.Empty
        Me.txtTotalCapacityCus.DataSource = Nothing
        Me.txtTotalCapacityCus.DecimalDigit = 2
        Me.txtTotalCapacityCus.DisplayMember = Nothing
        Me.txtTotalCapacityCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotalCapacityCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTotalCapacityCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTotalCapacityCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTotalCapacityCus.LinkCheckedBox = Nothing
        Me.txtTotalCapacityCus.Location = New System.Drawing.Point(658, 59)
        Me.txtTotalCapacityCus.MaxValue = 99999.99R
        Me.txtTotalCapacityCus.MinValue = -99999.99R
        Me.txtTotalCapacityCus.Name = "txtTotalCapacityCus"
        Me.txtTotalCapacityCus.NotNull = False
        Me.txtTotalCapacityCus.ReadOnly = True
        Me.txtTotalCapacityCus.ShowDecimal = True
        Me.txtTotalCapacityCus.Size = New System.Drawing.Size(179, 23)
        Me.txtTotalCapacityCus.TabIndex = 27
        Me.txtTotalCapacityCus.TabStop = False
        Me.txtTotalCapacityCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTrackTimeCus
        '
        Me.txtTrackTimeCus.Add_Comma = False
        Me.txtTrackTimeCus.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTrackTimeCus.DataSource = Nothing
        Me.txtTrackTimeCus.DecimalDigit = 0
        Me.txtTrackTimeCus.DisplayMember = Nothing
        Me.txtTrackTimeCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTrackTimeCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTrackTimeCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTrackTimeCus.ForeColor = System.Drawing.Color.Black
        Me.txtTrackTimeCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTrackTimeCus.LinkCheckedBox = Nothing
        Me.txtTrackTimeCus.Location = New System.Drawing.Point(843, 59)
        Me.txtTrackTimeCus.MaxValue = 99999.99R
        Me.txtTrackTimeCus.MinValue = -99999.99R
        Me.txtTrackTimeCus.Name = "txtTrackTimeCus"
        Me.txtTrackTimeCus.NotNull = False
        Me.txtTrackTimeCus.ReadOnly = True
        Me.txtTrackTimeCus.ShowDecimal = False
        Me.txtTrackTimeCus.Size = New System.Drawing.Size(179, 23)
        Me.txtTrackTimeCus.TabIndex = 23
        Me.txtTrackTimeCus.TabStop = False
        Me.txtTrackTimeCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWorkingHrsCus
        '
        Me.txtWorkingHrsCus.Add_Comma = False
        Me.txtWorkingHrsCus.BackColor = System.Drawing.Color.Empty
        Me.txtWorkingHrsCus.DataSource = Nothing
        Me.txtWorkingHrsCus.DecimalDigit = 0
        Me.txtWorkingHrsCus.DisplayMember = Nothing
        Me.txtWorkingHrsCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWorkingHrsCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtWorkingHrsCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtWorkingHrsCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtWorkingHrsCus.LinkCheckedBox = Nothing
        Me.txtWorkingHrsCus.Location = New System.Drawing.Point(288, 59)
        Me.txtWorkingHrsCus.MaxValue = 99999.99R
        Me.txtWorkingHrsCus.MinValue = -99999.99R
        Me.txtWorkingHrsCus.Name = "txtWorkingHrsCus"
        Me.txtWorkingHrsCus.NotNull = False
        Me.txtWorkingHrsCus.ReadOnly = True
        Me.txtWorkingHrsCus.ShowDecimal = False
        Me.txtWorkingHrsCus.Size = New System.Drawing.Size(179, 23)
        Me.txtWorkingHrsCus.TabIndex = 26
        Me.txtWorkingHrsCus.TabStop = False
        Me.txtWorkingHrsCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWorkTimeCus
        '
        Me.txtWorkTimeCus.Add_Comma = False
        Me.txtWorkTimeCus.BackColor = System.Drawing.Color.Empty
        Me.txtWorkTimeCus.DataSource = Nothing
        Me.txtWorkTimeCus.DecimalDigit = 0
        Me.txtWorkTimeCus.DisplayMember = Nothing
        Me.txtWorkTimeCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWorkTimeCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtWorkTimeCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtWorkTimeCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtWorkTimeCus.LinkCheckedBox = Nothing
        Me.txtWorkTimeCus.Location = New System.Drawing.Point(473, 59)
        Me.txtWorkTimeCus.MaxValue = 99999.99R
        Me.txtWorkTimeCus.MinValue = -99999.99R
        Me.txtWorkTimeCus.Name = "txtWorkTimeCus"
        Me.txtWorkTimeCus.NotNull = False
        Me.txtWorkTimeCus.ReadOnly = True
        Me.txtWorkTimeCus.ShowDecimal = False
        Me.txtWorkTimeCus.Size = New System.Drawing.Size(179, 23)
        Me.txtWorkTimeCus.TabIndex = 24
        Me.txtWorkTimeCus.TabStop = False
        Me.txtWorkTimeCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBreakTimeCus
        '
        Me.txtBreakTimeCus.Add_Comma = False
        Me.txtBreakTimeCus.BackColor = System.Drawing.Color.Empty
        Me.txtBreakTimeCus.DataSource = Nothing
        Me.txtBreakTimeCus.DecimalDigit = 0
        Me.txtBreakTimeCus.DisplayMember = Nothing
        Me.txtBreakTimeCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBreakTimeCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtBreakTimeCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtBreakTimeCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtBreakTimeCus.LinkCheckedBox = Nothing
        Me.txtBreakTimeCus.Location = New System.Drawing.Point(103, 59)
        Me.txtBreakTimeCus.MaxValue = 99999.99R
        Me.txtBreakTimeCus.MinValue = -99999.99R
        Me.txtBreakTimeCus.Name = "txtBreakTimeCus"
        Me.txtBreakTimeCus.NotNull = False
        Me.txtBreakTimeCus.ReadOnly = True
        Me.txtBreakTimeCus.ShowDecimal = False
        Me.txtBreakTimeCus.Size = New System.Drawing.Size(179, 23)
        Me.txtBreakTimeCus.TabIndex = 25
        Me.txtBreakTimeCus.TabStop = False
        Me.txtBreakTimeCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChart, Me.ToolStripSeparator1, Me.btnPrint})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1179, 42)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "ToolStrip"
        '
        'btnChart
        '
        Me.btnChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChart.Image = CType(resources.GetObject("btnChart.Image"), System.Drawing.Image)
        Me.btnChart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnChart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(54, 39)
        Me.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnChart.ToolTipText = "Calculate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.EnableOnly = False
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(36, 39)
        Me.btnPrint.Text = "Export to Excel"
        Me.btnPrint.ToolTipText = "Export Chart"
        '
        'pnCondition
        '
        Me.pnCondition.AutoScroll = True
        Me.pnCondition.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnCondition.Controls.Add(Me.grpReturn)
        Me.pnCondition.Controls.Add(Me.grpDelivery)
        Me.pnCondition.Controls.Add(Me.grpRackVisual)
        Me.pnCondition.Controls.Add(Me.pnHeader)
        Me.pnCondition.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnCondition.Location = New System.Drawing.Point(0, 0)
        Me.pnCondition.Name = "pnCondition"
        Me.pnCondition.Size = New System.Drawing.Size(350, 810)
        Me.pnCondition.TabIndex = 0
        '
        'grpReturn
        '
        Me.grpReturn.Controls.Add(Me.OpeLabel5)
        Me.grpReturn.Controls.Add(Me.txtTravelMinsCus)
        Me.grpReturn.Controls.Add(Me.OpeLabel3)
        Me.grpReturn.Controls.Add(Me.txtCapacityCus)
        Me.grpReturn.Controls.Add(Me.lblQtyPerTripCus)
        Me.grpReturn.Controls.Add(Me.txtQtyPerTripCus)
        Me.grpReturn.Controls.Add(Me.lblInitialFGCus)
        Me.grpReturn.Controls.Add(Me.txtInitialFGCus)
        Me.grpReturn.Controls.Add(Me.txtIniEmptyRackCus)
        Me.grpReturn.Controls.Add(Me.lblIniEmptyRackCus)
        Me.grpReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpReturn.Location = New System.Drawing.Point(0, 331)
        Me.grpReturn.Name = "grpReturn"
        Me.grpReturn.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpReturn.Size = New System.Drawing.Size(348, 477)
        Me.grpReturn.TabIndex = 2
        Me.grpReturn.TabStop = False
        Me.grpReturn.Text = "Customer"
        '
        'OpeLabel5
        '
        Me.OpeLabel5.AutoSize = True
        Me.OpeLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel5.LabelId = 0
        Me.OpeLabel5.Location = New System.Drawing.Point(23, 148)
        Me.OpeLabel5.Name = "OpeLabel5"
        Me.OpeLabel5.Size = New System.Drawing.Size(148, 17)
        Me.OpeLabel5.TabIndex = 10
        Me.OpeLabel5.Text = "Transport Time (Mins)"
        '
        'txtTravelMinsCus
        '
        Me.txtTravelMinsCus.Add_Comma = False
        Me.txtTravelMinsCus.DataSource = Nothing
        Me.txtTravelMinsCus.DecimalDigit = 0
        Me.txtTravelMinsCus.DisplayMember = Nothing
        Me.txtTravelMinsCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTravelMinsCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTravelMinsCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTravelMinsCus.LinkCheckedBox = Nothing
        Me.txtTravelMinsCus.Location = New System.Drawing.Point(173, 145)
        Me.txtTravelMinsCus.MaxValue = 99999.99R
        Me.txtTravelMinsCus.MinValue = -99999.99R
        Me.txtTravelMinsCus.Name = "txtTravelMinsCus"
        Me.txtTravelMinsCus.NotNull = False
        Me.txtTravelMinsCus.ShowDecimal = False
        Me.txtTravelMinsCus.Size = New System.Drawing.Size(108, 23)
        Me.txtTravelMinsCus.TabIndex = 11
        Me.txtTravelMinsCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel3
        '
        Me.OpeLabel3.AutoSize = True
        Me.OpeLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel3.LabelId = 0
        Me.OpeLabel3.Location = New System.Drawing.Point(23, 32)
        Me.OpeLabel3.Name = "OpeLabel3"
        Me.OpeLabel3.Size = New System.Drawing.Size(102, 17)
        Me.OpeLabel3.TabIndex = 0
        Me.OpeLabel3.Text = "Capacity (JPH)"
        '
        'txtCapacityCus
        '
        Me.txtCapacityCus.Add_Comma = False
        Me.txtCapacityCus.DataSource = Nothing
        Me.txtCapacityCus.DecimalDigit = 2
        Me.txtCapacityCus.DisplayMember = Nothing
        Me.txtCapacityCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtCapacityCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCapacityCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtCapacityCus.LinkCheckedBox = Nothing
        Me.txtCapacityCus.Location = New System.Drawing.Point(173, 29)
        Me.txtCapacityCus.MaxValue = 99999.99R
        Me.txtCapacityCus.MinValue = -99999.99R
        Me.txtCapacityCus.Name = "txtCapacityCus"
        Me.txtCapacityCus.NotNull = False
        Me.txtCapacityCus.ShowDecimal = True
        Me.txtCapacityCus.Size = New System.Drawing.Size(108, 23)
        Me.txtCapacityCus.TabIndex = 1
        Me.txtCapacityCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQtyPerTripCus
        '
        Me.lblQtyPerTripCus.AutoSize = True
        Me.lblQtyPerTripCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblQtyPerTripCus.LabelId = 0
        Me.lblQtyPerTripCus.Location = New System.Drawing.Point(23, 119)
        Me.lblQtyPerTripCus.Name = "lblQtyPerTripCus"
        Me.lblQtyPerTripCus.Size = New System.Drawing.Size(59, 17)
        Me.lblQtyPerTripCus.TabIndex = 8
        Me.lblQtyPerTripCus.Text = "Qty/Trip"
        '
        'txtQtyPerTripCus
        '
        Me.txtQtyPerTripCus.Add_Comma = False
        Me.txtQtyPerTripCus.DataSource = Nothing
        Me.txtQtyPerTripCus.DecimalDigit = 0
        Me.txtQtyPerTripCus.DisplayMember = Nothing
        Me.txtQtyPerTripCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtQtyPerTripCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtQtyPerTripCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtQtyPerTripCus.LinkCheckedBox = Nothing
        Me.txtQtyPerTripCus.Location = New System.Drawing.Point(173, 116)
        Me.txtQtyPerTripCus.MaxValue = 99999.99R
        Me.txtQtyPerTripCus.MinValue = -99999.99R
        Me.txtQtyPerTripCus.Name = "txtQtyPerTripCus"
        Me.txtQtyPerTripCus.NotNull = False
        Me.txtQtyPerTripCus.ShowDecimal = False
        Me.txtQtyPerTripCus.Size = New System.Drawing.Size(108, 23)
        Me.txtQtyPerTripCus.TabIndex = 9
        Me.txtQtyPerTripCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInitialFGCus
        '
        Me.lblInitialFGCus.AutoSize = True
        Me.lblInitialFGCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblInitialFGCus.LabelId = 0
        Me.lblInitialFGCus.Location = New System.Drawing.Point(23, 89)
        Me.lblInitialFGCus.Name = "lblInitialFGCus"
        Me.lblInitialFGCus.Size = New System.Drawing.Size(63, 17)
        Me.lblInitialFGCus.TabIndex = 4
        Me.lblInitialFGCus.Text = "Initial FG"
        '
        'txtInitialFGCus
        '
        Me.txtInitialFGCus.Add_Comma = False
        Me.txtInitialFGCus.DataSource = Nothing
        Me.txtInitialFGCus.DecimalDigit = 0
        Me.txtInitialFGCus.DisplayMember = Nothing
        Me.txtInitialFGCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtInitialFGCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtInitialFGCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtInitialFGCus.LinkCheckedBox = Nothing
        Me.txtInitialFGCus.Location = New System.Drawing.Point(173, 86)
        Me.txtInitialFGCus.MaxValue = 99999.99R
        Me.txtInitialFGCus.MinValue = -99999.99R
        Me.txtInitialFGCus.Name = "txtInitialFGCus"
        Me.txtInitialFGCus.NotNull = False
        Me.txtInitialFGCus.ShowDecimal = False
        Me.txtInitialFGCus.Size = New System.Drawing.Size(108, 23)
        Me.txtInitialFGCus.TabIndex = 5
        Me.txtInitialFGCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIniEmptyRackCus
        '
        Me.txtIniEmptyRackCus.Add_Comma = False
        Me.txtIniEmptyRackCus.DataSource = Nothing
        Me.txtIniEmptyRackCus.DecimalDigit = 0
        Me.txtIniEmptyRackCus.DisplayMember = Nothing
        Me.txtIniEmptyRackCus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtIniEmptyRackCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtIniEmptyRackCus.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtIniEmptyRackCus.LinkCheckedBox = Nothing
        Me.txtIniEmptyRackCus.Location = New System.Drawing.Point(173, 57)
        Me.txtIniEmptyRackCus.MaxValue = 99999.99R
        Me.txtIniEmptyRackCus.MinValue = -99999.99R
        Me.txtIniEmptyRackCus.Name = "txtIniEmptyRackCus"
        Me.txtIniEmptyRackCus.NotNull = False
        Me.txtIniEmptyRackCus.ShowDecimal = False
        Me.txtIniEmptyRackCus.Size = New System.Drawing.Size(108, 23)
        Me.txtIniEmptyRackCus.TabIndex = 3
        Me.txtIniEmptyRackCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIniEmptyRackCus
        '
        Me.lblIniEmptyRackCus.AutoSize = True
        Me.lblIniEmptyRackCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblIniEmptyRackCus.LabelId = 0
        Me.lblIniEmptyRackCus.Location = New System.Drawing.Point(23, 60)
        Me.lblIniEmptyRackCus.Name = "lblIniEmptyRackCus"
        Me.lblIniEmptyRackCus.Size = New System.Drawing.Size(119, 17)
        Me.lblIniEmptyRackCus.TabIndex = 2
        Me.lblIniEmptyRackCus.Text = "Initial Empty Rack"
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.OpeLabel4)
        Me.grpDelivery.Controls.Add(Me.txtTravelMinsZF)
        Me.grpDelivery.Controls.Add(Me.lblCapacity)
        Me.grpDelivery.Controls.Add(Me.txtCapacityZF)
        Me.grpDelivery.Controls.Add(Me.lblBlockForMaintenance)
        Me.grpDelivery.Controls.Add(Me.txtBlockForMaintenance)
        Me.grpDelivery.Controls.Add(Me.txtBlockForSkiplot)
        Me.grpDelivery.Controls.Add(Me.lblBlogForSkiplot)
        Me.grpDelivery.Controls.Add(Me.lblIniEmptyRackZF)
        Me.grpDelivery.Controls.Add(Me.txtIniEmptyRackZF)
        Me.grpDelivery.Controls.Add(Me.lblQtyPerTripZF)
        Me.grpDelivery.Controls.Add(Me.txtQtyPerTripZF)
        Me.grpDelivery.Controls.Add(Me.lblInitialFGZF)
        Me.grpDelivery.Controls.Add(Me.txtInitialFGZF)
        Me.grpDelivery.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDelivery.Location = New System.Drawing.Point(0, 95)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpDelivery.Size = New System.Drawing.Size(348, 236)
        Me.grpDelivery.TabIndex = 1
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "ZF"
        '
        'OpeLabel4
        '
        Me.OpeLabel4.AutoSize = True
        Me.OpeLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel4.LabelId = 0
        Me.OpeLabel4.Location = New System.Drawing.Point(23, 191)
        Me.OpeLabel4.Name = "OpeLabel4"
        Me.OpeLabel4.Size = New System.Drawing.Size(148, 17)
        Me.OpeLabel4.TabIndex = 14
        Me.OpeLabel4.Text = "Transport Time (Mins)"
        '
        'txtTravelMinsZF
        '
        Me.txtTravelMinsZF.Add_Comma = False
        Me.txtTravelMinsZF.DataSource = Nothing
        Me.txtTravelMinsZF.DecimalDigit = 0
        Me.txtTravelMinsZF.DisplayMember = Nothing
        Me.txtTravelMinsZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTravelMinsZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTravelMinsZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtTravelMinsZF.LinkCheckedBox = Nothing
        Me.txtTravelMinsZF.Location = New System.Drawing.Point(173, 188)
        Me.txtTravelMinsZF.MaxValue = 99999.99R
        Me.txtTravelMinsZF.MinValue = -99999.99R
        Me.txtTravelMinsZF.Name = "txtTravelMinsZF"
        Me.txtTravelMinsZF.NotNull = False
        Me.txtTravelMinsZF.ShowDecimal = False
        Me.txtTravelMinsZF.Size = New System.Drawing.Size(108, 23)
        Me.txtTravelMinsZF.TabIndex = 15
        Me.txtTravelMinsZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCapacity.LabelId = 0
        Me.lblCapacity.Location = New System.Drawing.Point(23, 25)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(102, 17)
        Me.lblCapacity.TabIndex = 0
        Me.lblCapacity.Text = "Capacity (JPH)"
        '
        'txtCapacityZF
        '
        Me.txtCapacityZF.Add_Comma = False
        Me.txtCapacityZF.DataSource = Nothing
        Me.txtCapacityZF.DecimalDigit = 2
        Me.txtCapacityZF.DisplayMember = Nothing
        Me.txtCapacityZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtCapacityZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCapacityZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtCapacityZF.LinkCheckedBox = Nothing
        Me.txtCapacityZF.Location = New System.Drawing.Point(173, 22)
        Me.txtCapacityZF.MaxValue = 99999.99R
        Me.txtCapacityZF.MinValue = -99999.99R
        Me.txtCapacityZF.Name = "txtCapacityZF"
        Me.txtCapacityZF.NotNull = False
        Me.txtCapacityZF.ShowDecimal = True
        Me.txtCapacityZF.Size = New System.Drawing.Size(108, 23)
        Me.txtCapacityZF.TabIndex = 1
        Me.txtCapacityZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBlockForMaintenance
        '
        Me.lblBlockForMaintenance.AutoSize = True
        Me.lblBlockForMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblBlockForMaintenance.LabelId = 0
        Me.lblBlockForMaintenance.Location = New System.Drawing.Point(23, 163)
        Me.lblBlockForMaintenance.Name = "lblBlockForMaintenance"
        Me.lblBlockForMaintenance.Size = New System.Drawing.Size(140, 17)
        Me.lblBlockForMaintenance.TabIndex = 12
        Me.lblBlockForMaintenance.Text = "Block for maintenace"
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
        Me.txtBlockForMaintenance.Location = New System.Drawing.Point(173, 160)
        Me.txtBlockForMaintenance.MaxValue = 99999.99R
        Me.txtBlockForMaintenance.MinValue = -99999.99R
        Me.txtBlockForMaintenance.Name = "txtBlockForMaintenance"
        Me.txtBlockForMaintenance.NotNull = False
        Me.txtBlockForMaintenance.ShowDecimal = False
        Me.txtBlockForMaintenance.Size = New System.Drawing.Size(108, 23)
        Me.txtBlockForMaintenance.TabIndex = 13
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
        Me.txtBlockForSkiplot.Location = New System.Drawing.Point(173, 133)
        Me.txtBlockForSkiplot.MaxValue = 99999.99R
        Me.txtBlockForSkiplot.MinValue = -99999.99R
        Me.txtBlockForSkiplot.Name = "txtBlockForSkiplot"
        Me.txtBlockForSkiplot.NotNull = False
        Me.txtBlockForSkiplot.ShowDecimal = False
        Me.txtBlockForSkiplot.Size = New System.Drawing.Size(108, 23)
        Me.txtBlockForSkiplot.TabIndex = 11
        Me.txtBlockForSkiplot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBlogForSkiplot
        '
        Me.lblBlogForSkiplot.AutoSize = True
        Me.lblBlogForSkiplot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblBlogForSkiplot.LabelId = 0
        Me.lblBlogForSkiplot.Location = New System.Drawing.Point(23, 136)
        Me.lblBlogForSkiplot.Name = "lblBlogForSkiplot"
        Me.lblBlogForSkiplot.Size = New System.Drawing.Size(111, 17)
        Me.lblBlogForSkiplot.TabIndex = 10
        Me.lblBlogForSkiplot.Text = "Block for skip lot"
        '
        'lblIniEmptyRackZF
        '
        Me.lblIniEmptyRackZF.AutoSize = True
        Me.lblIniEmptyRackZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblIniEmptyRackZF.LabelId = 0
        Me.lblIniEmptyRackZF.Location = New System.Drawing.Point(23, 52)
        Me.lblIniEmptyRackZF.Name = "lblIniEmptyRackZF"
        Me.lblIniEmptyRackZF.Size = New System.Drawing.Size(119, 17)
        Me.lblIniEmptyRackZF.TabIndex = 2
        Me.lblIniEmptyRackZF.Text = "Initial Empty Rack"
        '
        'txtIniEmptyRackZF
        '
        Me.txtIniEmptyRackZF.Add_Comma = False
        Me.txtIniEmptyRackZF.DataSource = Nothing
        Me.txtIniEmptyRackZF.DecimalDigit = 0
        Me.txtIniEmptyRackZF.DisplayMember = Nothing
        Me.txtIniEmptyRackZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtIniEmptyRackZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtIniEmptyRackZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtIniEmptyRackZF.LinkCheckedBox = Nothing
        Me.txtIniEmptyRackZF.Location = New System.Drawing.Point(173, 49)
        Me.txtIniEmptyRackZF.MaxValue = 99999.99R
        Me.txtIniEmptyRackZF.MinValue = -99999.99R
        Me.txtIniEmptyRackZF.Name = "txtIniEmptyRackZF"
        Me.txtIniEmptyRackZF.NotNull = False
        Me.txtIniEmptyRackZF.ShowDecimal = False
        Me.txtIniEmptyRackZF.Size = New System.Drawing.Size(108, 23)
        Me.txtIniEmptyRackZF.TabIndex = 3
        Me.txtIniEmptyRackZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQtyPerTripZF
        '
        Me.lblQtyPerTripZF.AutoSize = True
        Me.lblQtyPerTripZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblQtyPerTripZF.LabelId = 0
        Me.lblQtyPerTripZF.Location = New System.Drawing.Point(23, 108)
        Me.lblQtyPerTripZF.Name = "lblQtyPerTripZF"
        Me.lblQtyPerTripZF.Size = New System.Drawing.Size(59, 17)
        Me.lblQtyPerTripZF.TabIndex = 8
        Me.lblQtyPerTripZF.Text = "Qty/Trip"
        '
        'txtQtyPerTripZF
        '
        Me.txtQtyPerTripZF.Add_Comma = False
        Me.txtQtyPerTripZF.DataSource = Nothing
        Me.txtQtyPerTripZF.DecimalDigit = 0
        Me.txtQtyPerTripZF.DisplayMember = Nothing
        Me.txtQtyPerTripZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtQtyPerTripZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtQtyPerTripZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtQtyPerTripZF.LinkCheckedBox = Nothing
        Me.txtQtyPerTripZF.Location = New System.Drawing.Point(173, 105)
        Me.txtQtyPerTripZF.MaxValue = 99999.99R
        Me.txtQtyPerTripZF.MinValue = -99999.99R
        Me.txtQtyPerTripZF.Name = "txtQtyPerTripZF"
        Me.txtQtyPerTripZF.NotNull = False
        Me.txtQtyPerTripZF.ShowDecimal = False
        Me.txtQtyPerTripZF.Size = New System.Drawing.Size(108, 23)
        Me.txtQtyPerTripZF.TabIndex = 9
        Me.txtQtyPerTripZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInitialFGZF
        '
        Me.lblInitialFGZF.AutoSize = True
        Me.lblInitialFGZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblInitialFGZF.LabelId = 0
        Me.lblInitialFGZF.Location = New System.Drawing.Point(23, 79)
        Me.lblInitialFGZF.Name = "lblInitialFGZF"
        Me.lblInitialFGZF.Size = New System.Drawing.Size(63, 17)
        Me.lblInitialFGZF.TabIndex = 4
        Me.lblInitialFGZF.Text = "Initial FG"
        '
        'txtInitialFGZF
        '
        Me.txtInitialFGZF.Add_Comma = False
        Me.txtInitialFGZF.DataSource = Nothing
        Me.txtInitialFGZF.DecimalDigit = 0
        Me.txtInitialFGZF.DisplayMember = Nothing
        Me.txtInitialFGZF.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtInitialFGZF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtInitialFGZF.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtInitialFGZF.LinkCheckedBox = Nothing
        Me.txtInitialFGZF.Location = New System.Drawing.Point(173, 76)
        Me.txtInitialFGZF.MaxValue = 99999.99R
        Me.txtInitialFGZF.MinValue = -99999.99R
        Me.txtInitialFGZF.Name = "txtInitialFGZF"
        Me.txtInitialFGZF.NotNull = False
        Me.txtInitialFGZF.ShowDecimal = False
        Me.txtInitialFGZF.Size = New System.Drawing.Size(108, 23)
        Me.txtInitialFGZF.TabIndex = 5
        Me.txtInitialFGZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpRackVisual
        '
        Me.grpRackVisual.Controls.Add(Me.lblDays)
        Me.grpRackVisual.Controls.Add(Me.txtDays)
        Me.grpRackVisual.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRackVisual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRackVisual.Location = New System.Drawing.Point(0, 35)
        Me.grpRackVisual.Name = "grpRackVisual"
        Me.grpRackVisual.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpRackVisual.Size = New System.Drawing.Size(348, 60)
        Me.grpRackVisual.TabIndex = 0
        Me.grpRackVisual.TabStop = False
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDays.LabelId = 0
        Me.lblDays.Location = New System.Drawing.Point(23, 21)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(40, 17)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "Days"
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
        Me.txtDays.Location = New System.Drawing.Point(173, 18)
        Me.txtDays.MaxValue = 99999.99R
        Me.txtDays.MinValue = -99999.99R
        Me.txtDays.Name = "txtDays"
        Me.txtDays.NotNull = False
        Me.txtDays.ShowDecimal = False
        Me.txtDays.Size = New System.Drawing.Size(108, 23)
        Me.txtDays.TabIndex = 1
        Me.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.pnHeader.Controls.Add(Me.btnShowConfig)
        Me.pnHeader.Controls.Add(Me.lblHeader)
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(348, 35)
        Me.pnHeader.TabIndex = 0
        '
        'btnShowConfig
        '
        Me.btnShowConfig.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnShowConfig.Location = New System.Drawing.Point(0, 0)
        Me.btnShowConfig.Name = "btnShowConfig"
        Me.btnShowConfig.Size = New System.Drawing.Size(30, 35)
        Me.btnShowConfig.TabIndex = 13
        Me.btnShowConfig.TabStop = False
        Me.btnShowConfig.Text = "<<"
        Me.btnShowConfig.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.LabelId = 0
        Me.lblHeader.Location = New System.Drawing.Point(115, 5)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(119, 24)
        Me.lblHeader.TabIndex = 18
        Me.lblHeader.Text = "Rack Visual"
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'clsVSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1545, 826)
        Me.Controls.Add(Me.OpePanel1)
        Me.Name = "clsVSchedule"
        Me.Text = "Schedule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.OpePanel1.ResumeLayout(False)
        Me.pnChart.ResumeLayout(False)
        Me.pnChart.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.pgeOverview.ResumeLayout(False)
        Me.TabLayOutOverview.ResumeLayout(False)
        CType(Me.grdOverview, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpePanel1 As OPE_Controls.OpePanel
    Friend WithEvents pnChart As OPE_Controls.OpePanel
    Friend WithEvents pnCondition As OPE_Controls.OpePanel
    Friend WithEvents grpReturn As OPE_Controls.OpeGroupBox
    Friend WithEvents txtIniEmptyRackCus As OPE_Controls.OpeTextBox
    Friend WithEvents lblIniEmptyRackCus As OPE_Controls.OpeLabel
    Friend WithEvents grpDelivery As OPE_Controls.OpeGroupBox
    Friend WithEvents lblQtyPerTripZF As OPE_Controls.OpeLabel
    Friend WithEvents txtQtyPerTripZF As OPE_Controls.OpeTextBox
    Friend WithEvents lblInitialFGZF As OPE_Controls.OpeLabel
    Friend WithEvents txtInitialFGZF As OPE_Controls.OpeTextBox
    Friend WithEvents grpRackVisual As OPE_Controls.OpeGroupBox
    Friend WithEvents lblDays As OPE_Controls.OpeLabel
    Friend WithEvents txtDays As OPE_Controls.OpeTextBox
    Friend WithEvents pnHeader As OPE_Controls.OpePanel
    Friend WithEvents lblHeader As OPE_Controls.OpeLabel
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As OPE_Controls.OpeButtonPrint
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents pgeZFFG As System.Windows.Forms.TabPage
    Friend WithEvents pgeCusFG As System.Windows.Forms.TabPage
    Friend WithEvents pgeCusEmptyReturn As System.Windows.Forms.TabPage
    Friend WithEvents pnResult As OPE_Controls.OpePanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblBreakTimeZF As OPE_Controls.OpeLabel
    Friend WithEvents txtBreakTimeZF As OPE_Controls.OpeTextBox
    Friend WithEvents lblWorkingHrsZF As OPE_Controls.OpeLabel
    Friend WithEvents txtWorkingHrsZF As OPE_Controls.OpeTextBox
    Friend WithEvents lblTotalCapacity As OPE_Controls.OpeLabel
    Friend WithEvents txtTotalCapacityZF As OPE_Controls.OpeTextBox
    Friend WithEvents lblWorkTimeZF As OPE_Controls.OpeLabel
    Friend WithEvents txtWorkTimeZF As OPE_Controls.OpeTextBox
    Friend WithEvents lblIniEmptyRackZF As OPE_Controls.OpeLabel
    Friend WithEvents txtIniEmptyRackZF As OPE_Controls.OpeTextBox
    Friend WithEvents lblInitialFGCus As OPE_Controls.OpeLabel
    Friend WithEvents txtInitialFGCus As OPE_Controls.OpeTextBox
    Friend WithEvents lblBlockForMaintenance As OPE_Controls.OpeLabel
    Friend WithEvents txtBlockForMaintenance As OPE_Controls.OpeTextBox
    Friend WithEvents txtBlockForSkiplot As OPE_Controls.OpeTextBox
    Friend WithEvents lblBlogForSkiplot As OPE_Controls.OpeLabel
    Friend WithEvents pgeOverview As System.Windows.Forms.TabPage
    Friend WithEvents lblQtyPerTripCus As OPE_Controls.OpeLabel
    Friend WithEvents txtQtyPerTripCus As OPE_Controls.OpeTextBox
    Friend WithEvents txtTotalCapacityCus As OPE_Controls.OpeTextBox
    Friend WithEvents txtWorkingHrsCus As OPE_Controls.OpeTextBox
    Friend WithEvents txtBreakTimeCus As OPE_Controls.OpeTextBox
    Friend WithEvents txtWorkTimeCus As OPE_Controls.OpeTextBox
    Friend WithEvents txtTrackTimeCus As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel1 As OPE_Controls.OpeLabel
    Friend WithEvents txtTrackTimeZF As OPE_Controls.OpeTextBox
    Friend WithEvents lblTrackTimeZF As OPE_Controls.OpeLabel
    Friend WithEvents OpeLabel2 As OPE_Controls.OpeLabel
    Friend WithEvents OpeLabel3 As OPE_Controls.OpeLabel
    Friend WithEvents txtCapacityCus As OPE_Controls.OpeTextBox
    Friend WithEvents lblCapacity As OPE_Controls.OpeLabel
    Friend WithEvents txtCapacityZF As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel5 As OPE_Controls.OpeLabel
    Friend WithEvents txtTravelMinsCus As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel4 As OPE_Controls.OpeLabel
    Friend WithEvents txtTravelMinsZF As OPE_Controls.OpeTextBox
    Friend WithEvents TabLayOutOverview As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grdOverview As OPE_Controls.opeDataGrid
    Friend WithEvents pgeZFEmptyRack As System.Windows.Forms.TabPage
    Friend WithEvents btnShowConfig As System.Windows.Forms.Button
    Friend WithEvents OpeLabel6 As OPE_Controls.OpeLabel
    Friend WithEvents txtTripPerDayZF As OPE_Controls.OpeTextBox
    Friend WithEvents txtTripPerDayCus As OPE_Controls.OpeTextBox
    Friend WithEvents btnChart As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
End Class
