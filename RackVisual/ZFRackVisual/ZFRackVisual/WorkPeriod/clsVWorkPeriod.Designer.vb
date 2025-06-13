<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVWorkPeriod
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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVWorkPeriod))
        Me.OpePanel1 = New OPE_Controls.OpePanel(Me.components)
        Me.tabTimeControl = New System.Windows.Forms.TabControl()
        Me.PgeWokingZF = New System.Windows.Forms.TabPage()
        Me.grdWorkingZF = New OPE_Controls.opeDataGrid()
        Me.BttnBoxWorkZF = New OPE_Controls.OpeButtonBox()
        Me.btnEditWorkZF = New OPE_Controls.OpeButtonEdit()
        Me.btnSaveWorkZF = New OPE_Controls.OpeButtonSave()
        Me.btnHelpWorkTimeZF = New System.Windows.Forms.ToolStripButton()
        Me.PgeWorkingCus = New System.Windows.Forms.TabPage()
        Me.grdWorkingCustomer = New OPE_Controls.opeDataGrid()
        Me.BttnBoxWorkCus = New OPE_Controls.OpeButtonBox()
        Me.btnEditWorkCus = New OPE_Controls.OpeButtonEdit()
        Me.btnSaveWorkCus = New OPE_Controls.OpeButtonSave()
        Me.btnHelpWorkTimeCus = New System.Windows.Forms.ToolStripButton()
        Me.PgeDeliveryZF = New System.Windows.Forms.TabPage()
        Me.grdDeliZF = New OPE_Controls.opeDataGrid()
        Me.BttnBoxDeliZF = New OPE_Controls.OpeButtonBox()
        Me.btnEditDeliZF = New OPE_Controls.OpeButtonEdit()
        Me.btnSaveDeliZF = New OPE_Controls.OpeButtonSave()
        Me.btnHelpDeliZF = New System.Windows.Forms.ToolStripButton()
        Me.PgeDeliveryCus = New System.Windows.Forms.TabPage()
        Me.grdDeliCus = New OPE_Controls.opeDataGrid()
        Me.BttnBoxDeliCus = New OPE_Controls.OpeButtonBox()
        Me.btnEditDeliCus = New OPE_Controls.OpeButtonEdit()
        Me.btnSaveDeliCus = New OPE_Controls.OpeButtonSave()
        Me.btnHelpDeliCus = New System.Windows.Forms.ToolStripButton()
        Me.OpePanel1.SuspendLayout()
        Me.tabTimeControl.SuspendLayout()
        Me.PgeWokingZF.SuspendLayout()
        CType(Me.grdWorkingZF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BttnBoxWorkZF.SuspendLayout()
        Me.PgeWorkingCus.SuspendLayout()
        CType(Me.grdWorkingCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BttnBoxWorkCus.SuspendLayout()
        Me.PgeDeliveryZF.SuspendLayout()
        CType(Me.grdDeliZF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BttnBoxDeliZF.SuspendLayout()
        Me.PgeDeliveryCus.SuspendLayout()
        CType(Me.grdDeliCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BttnBoxDeliCus.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpePanel1
        '
        Me.OpePanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpePanel1.Controls.Add(Me.tabTimeControl)
        Me.OpePanel1.Location = New System.Drawing.Point(5, 5)
        Me.OpePanel1.Name = "OpePanel1"
        Me.OpePanel1.Size = New System.Drawing.Size(1052, 611)
        Me.OpePanel1.TabIndex = 2
        '
        'tabTimeControl
        '
        Me.tabTimeControl.Controls.Add(Me.PgeWokingZF)
        Me.tabTimeControl.Controls.Add(Me.PgeWorkingCus)
        Me.tabTimeControl.Controls.Add(Me.PgeDeliveryZF)
        Me.tabTimeControl.Controls.Add(Me.PgeDeliveryCus)
        Me.tabTimeControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabTimeControl.Location = New System.Drawing.Point(0, 0)
        Me.tabTimeControl.Name = "tabTimeControl"
        Me.tabTimeControl.SelectedIndex = 0
        Me.tabTimeControl.Size = New System.Drawing.Size(1052, 611)
        Me.tabTimeControl.TabIndex = 12
        '
        'PgeWokingZF
        '
        Me.PgeWokingZF.Controls.Add(Me.grdWorkingZF)
        Me.PgeWokingZF.Controls.Add(Me.BttnBoxWorkZF)
        Me.PgeWokingZF.Location = New System.Drawing.Point(4, 22)
        Me.PgeWokingZF.Name = "PgeWokingZF"
        Me.PgeWokingZF.Padding = New System.Windows.Forms.Padding(3)
        Me.PgeWokingZF.Size = New System.Drawing.Size(1044, 585)
        Me.PgeWokingZF.TabIndex = 0
        Me.PgeWokingZF.Text = "Working Time ZF"
        Me.PgeWokingZF.UseVisualStyleBackColor = True
        '
        'grdWorkingZF
        '
        Me.grdWorkingZF.AllowUserToAddRows = False
        Me.grdWorkingZF.AllowUserToDeleteRows = False
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.LightCyan
        Me.grdWorkingZF.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.grdWorkingZF.AutoGenerateRecordNo = False
        Me.grdWorkingZF.ChangeEnterToTab = False
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdWorkingZF.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.grdWorkingZF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdWorkingZF.DefaultCellStyle = DataGridViewCellStyle23
        Me.grdWorkingZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdWorkingZF.EnableHeadersVisualStyles = False
        Me.grdWorkingZF.IsStatus = False
        Me.grdWorkingZF.Location = New System.Drawing.Point(3, 45)
        Me.grdWorkingZF.Name = "grdWorkingZF"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdWorkingZF.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.grdWorkingZF.Size = New System.Drawing.Size(1038, 537)
        Me.grdWorkingZF.TabIndex = 16
        '
        'BttnBoxWorkZF
        '
        Me.BttnBoxWorkZF.ButtonBoxMain = Nothing
        Me.BttnBoxWorkZF.EntryBox = Nothing
        Me.BttnBoxWorkZF.GridData = Nothing
        Me.BttnBoxWorkZF.GridDataTree = Nothing
        Me.BttnBoxWorkZF.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEditWorkZF, Me.btnSaveWorkZF, Me.btnHelpWorkTimeZF})
        Me.BttnBoxWorkZF.Location = New System.Drawing.Point(3, 3)
        Me.BttnBoxWorkZF.Name = "BttnBoxWorkZF"
        Me.BttnBoxWorkZF.Size = New System.Drawing.Size(1038, 42)
        Me.BttnBoxWorkZF.StatusBox = Nothing
        Me.BttnBoxWorkZF.TabIndex = 13
        Me.BttnBoxWorkZF.Text = "OpeButtonBox1"
        '
        'btnEditWorkZF
        '
        Me.btnEditWorkZF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditWorkZF.Image = CType(resources.GetObject("btnEditWorkZF.Image"), System.Drawing.Image)
        Me.btnEditWorkZF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditWorkZF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditWorkZF.Name = "btnEditWorkZF"
        Me.btnEditWorkZF.Size = New System.Drawing.Size(36, 39)
        Me.btnEditWorkZF.Text = "Edit"
        Me.btnEditWorkZF.ToolTipText = "Edit"
        '
        'btnSaveWorkZF
        '
        Me.btnSaveWorkZF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveWorkZF.Image = CType(resources.GetObject("btnSaveWorkZF.Image"), System.Drawing.Image)
        Me.btnSaveWorkZF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSaveWorkZF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveWorkZF.Name = "btnSaveWorkZF"
        Me.btnSaveWorkZF.Size = New System.Drawing.Size(36, 39)
        Me.btnSaveWorkZF.Text = "Save"
        Me.btnSaveWorkZF.ToolTipText = "Save"
        '
        'btnHelpWorkTimeZF
        '
        Me.btnHelpWorkTimeZF.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnHelpWorkTimeZF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelpWorkTimeZF.Image = CType(resources.GetObject("btnHelpWorkTimeZF.Image"), System.Drawing.Image)
        Me.btnHelpWorkTimeZF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnHelpWorkTimeZF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHelpWorkTimeZF.Name = "btnHelpWorkTimeZF"
        Me.btnHelpWorkTimeZF.Size = New System.Drawing.Size(39, 39)
        Me.btnHelpWorkTimeZF.Text = "ToolStripButton1"
        Me.btnHelpWorkTimeZF.ToolTipText = "Help"
        '
        'PgeWorkingCus
        '
        Me.PgeWorkingCus.Controls.Add(Me.grdWorkingCustomer)
        Me.PgeWorkingCus.Controls.Add(Me.BttnBoxWorkCus)
        Me.PgeWorkingCus.Location = New System.Drawing.Point(4, 22)
        Me.PgeWorkingCus.Name = "PgeWorkingCus"
        Me.PgeWorkingCus.Padding = New System.Windows.Forms.Padding(3)
        Me.PgeWorkingCus.Size = New System.Drawing.Size(1044, 585)
        Me.PgeWorkingCus.TabIndex = 1
        Me.PgeWorkingCus.Text = "Working Time Customer"
        Me.PgeWorkingCus.UseVisualStyleBackColor = True
        '
        'grdWorkingCustomer
        '
        Me.grdWorkingCustomer.AllowUserToAddRows = False
        Me.grdWorkingCustomer.AllowUserToDeleteRows = False
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.LightCyan
        Me.grdWorkingCustomer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.grdWorkingCustomer.AutoGenerateRecordNo = False
        Me.grdWorkingCustomer.ChangeEnterToTab = False
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdWorkingCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.grdWorkingCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdWorkingCustomer.DefaultCellStyle = DataGridViewCellStyle27
        Me.grdWorkingCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdWorkingCustomer.EnableHeadersVisualStyles = False
        Me.grdWorkingCustomer.IsStatus = False
        Me.grdWorkingCustomer.Location = New System.Drawing.Point(3, 45)
        Me.grdWorkingCustomer.Name = "grdWorkingCustomer"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdWorkingCustomer.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.grdWorkingCustomer.Size = New System.Drawing.Size(1038, 537)
        Me.grdWorkingCustomer.TabIndex = 15
        '
        'BttnBoxWorkCus
        '
        Me.BttnBoxWorkCus.ButtonBoxMain = Nothing
        Me.BttnBoxWorkCus.EntryBox = Nothing
        Me.BttnBoxWorkCus.GridData = Nothing
        Me.BttnBoxWorkCus.GridDataTree = Nothing
        Me.BttnBoxWorkCus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEditWorkCus, Me.btnSaveWorkCus, Me.btnHelpWorkTimeCus})
        Me.BttnBoxWorkCus.Location = New System.Drawing.Point(3, 3)
        Me.BttnBoxWorkCus.Name = "BttnBoxWorkCus"
        Me.BttnBoxWorkCus.Size = New System.Drawing.Size(1038, 42)
        Me.BttnBoxWorkCus.StatusBox = Nothing
        Me.BttnBoxWorkCus.TabIndex = 14
        Me.BttnBoxWorkCus.Text = "OpeButtonBox1"
        '
        'btnEditWorkCus
        '
        Me.btnEditWorkCus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditWorkCus.Image = CType(resources.GetObject("btnEditWorkCus.Image"), System.Drawing.Image)
        Me.btnEditWorkCus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditWorkCus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditWorkCus.Name = "btnEditWorkCus"
        Me.btnEditWorkCus.Size = New System.Drawing.Size(36, 39)
        Me.btnEditWorkCus.Text = "Edit"
        Me.btnEditWorkCus.ToolTipText = "Edit"
        '
        'btnSaveWorkCus
        '
        Me.btnSaveWorkCus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveWorkCus.Image = CType(resources.GetObject("btnSaveWorkCus.Image"), System.Drawing.Image)
        Me.btnSaveWorkCus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSaveWorkCus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveWorkCus.Name = "btnSaveWorkCus"
        Me.btnSaveWorkCus.Size = New System.Drawing.Size(36, 39)
        Me.btnSaveWorkCus.Text = "Save"
        Me.btnSaveWorkCus.ToolTipText = "Save"
        '
        'btnHelpWorkTimeCus
        '
        Me.btnHelpWorkTimeCus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnHelpWorkTimeCus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelpWorkTimeCus.Image = CType(resources.GetObject("btnHelpWorkTimeCus.Image"), System.Drawing.Image)
        Me.btnHelpWorkTimeCus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnHelpWorkTimeCus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHelpWorkTimeCus.Name = "btnHelpWorkTimeCus"
        Me.btnHelpWorkTimeCus.Size = New System.Drawing.Size(39, 39)
        Me.btnHelpWorkTimeCus.Text = "ToolStripButton1"
        Me.btnHelpWorkTimeCus.ToolTipText = "Help"
        '
        'PgeDeliveryZF
        '
        Me.PgeDeliveryZF.Controls.Add(Me.grdDeliZF)
        Me.PgeDeliveryZF.Controls.Add(Me.BttnBoxDeliZF)
        Me.PgeDeliveryZF.Location = New System.Drawing.Point(4, 22)
        Me.PgeDeliveryZF.Name = "PgeDeliveryZF"
        Me.PgeDeliveryZF.Size = New System.Drawing.Size(1044, 585)
        Me.PgeDeliveryZF.TabIndex = 2
        Me.PgeDeliveryZF.Text = "Delivery Time ZF"
        Me.PgeDeliveryZF.UseVisualStyleBackColor = True
        '
        'grdDeliZF
        '
        Me.grdDeliZF.AllowUserToAddRows = False
        Me.grdDeliZF.AllowUserToDeleteRows = False
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.LightCyan
        Me.grdDeliZF.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
        Me.grdDeliZF.AutoGenerateRecordNo = False
        Me.grdDeliZF.ChangeEnterToTab = False
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDeliZF.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.grdDeliZF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDeliZF.DefaultCellStyle = DataGridViewCellStyle31
        Me.grdDeliZF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDeliZF.EnableHeadersVisualStyles = False
        Me.grdDeliZF.IsStatus = False
        Me.grdDeliZF.Location = New System.Drawing.Point(0, 42)
        Me.grdDeliZF.Name = "grdDeliZF"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDeliZF.RowHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.grdDeliZF.Size = New System.Drawing.Size(1044, 543)
        Me.grdDeliZF.TabIndex = 17
        '
        'BttnBoxDeliZF
        '
        Me.BttnBoxDeliZF.ButtonBoxMain = Nothing
        Me.BttnBoxDeliZF.EntryBox = Nothing
        Me.BttnBoxDeliZF.GridData = Nothing
        Me.BttnBoxDeliZF.GridDataTree = Nothing
        Me.BttnBoxDeliZF.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEditDeliZF, Me.btnSaveDeliZF, Me.btnHelpDeliZF})
        Me.BttnBoxDeliZF.Location = New System.Drawing.Point(0, 0)
        Me.BttnBoxDeliZF.Name = "BttnBoxDeliZF"
        Me.BttnBoxDeliZF.Size = New System.Drawing.Size(1044, 42)
        Me.BttnBoxDeliZF.StatusBox = Nothing
        Me.BttnBoxDeliZF.TabIndex = 16
        Me.BttnBoxDeliZF.Text = "OpeButtonBox1"
        '
        'btnEditDeliZF
        '
        Me.btnEditDeliZF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditDeliZF.Image = CType(resources.GetObject("btnEditDeliZF.Image"), System.Drawing.Image)
        Me.btnEditDeliZF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditDeliZF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditDeliZF.Name = "btnEditDeliZF"
        Me.btnEditDeliZF.Size = New System.Drawing.Size(36, 39)
        Me.btnEditDeliZF.Text = "Edit"
        Me.btnEditDeliZF.ToolTipText = "Edit"
        '
        'btnSaveDeliZF
        '
        Me.btnSaveDeliZF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveDeliZF.Image = CType(resources.GetObject("btnSaveDeliZF.Image"), System.Drawing.Image)
        Me.btnSaveDeliZF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSaveDeliZF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveDeliZF.Name = "btnSaveDeliZF"
        Me.btnSaveDeliZF.Size = New System.Drawing.Size(36, 39)
        Me.btnSaveDeliZF.Text = "Save"
        Me.btnSaveDeliZF.ToolTipText = "Save"
        '
        'btnHelpDeliZF
        '
        Me.btnHelpDeliZF.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnHelpDeliZF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelpDeliZF.Image = CType(resources.GetObject("btnHelpDeliZF.Image"), System.Drawing.Image)
        Me.btnHelpDeliZF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnHelpDeliZF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHelpDeliZF.Name = "btnHelpDeliZF"
        Me.btnHelpDeliZF.Size = New System.Drawing.Size(39, 39)
        Me.btnHelpDeliZF.Text = "ToolStripButton1"
        Me.btnHelpDeliZF.ToolTipText = "Help"
        '
        'PgeDeliveryCus
        '
        Me.PgeDeliveryCus.Controls.Add(Me.grdDeliCus)
        Me.PgeDeliveryCus.Controls.Add(Me.BttnBoxDeliCus)
        Me.PgeDeliveryCus.Location = New System.Drawing.Point(4, 22)
        Me.PgeDeliveryCus.Name = "PgeDeliveryCus"
        Me.PgeDeliveryCus.Size = New System.Drawing.Size(1044, 585)
        Me.PgeDeliveryCus.TabIndex = 3
        Me.PgeDeliveryCus.Text = "Delivery Time Customer"
        Me.PgeDeliveryCus.UseVisualStyleBackColor = True
        '
        'grdDeliCus
        '
        Me.grdDeliCus.AllowUserToAddRows = False
        Me.grdDeliCus.AllowUserToDeleteRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.LightCyan
        Me.grdDeliCus.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.grdDeliCus.AutoGenerateRecordNo = False
        Me.grdDeliCus.ChangeEnterToTab = False
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDeliCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.grdDeliCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDeliCus.DefaultCellStyle = DataGridViewCellStyle19
        Me.grdDeliCus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDeliCus.EnableHeadersVisualStyles = False
        Me.grdDeliCus.IsStatus = False
        Me.grdDeliCus.Location = New System.Drawing.Point(0, 42)
        Me.grdDeliCus.Name = "grdDeliCus"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDeliCus.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.grdDeliCus.Size = New System.Drawing.Size(1044, 543)
        Me.grdDeliCus.TabIndex = 17
        '
        'BttnBoxDeliCus
        '
        Me.BttnBoxDeliCus.ButtonBoxMain = Nothing
        Me.BttnBoxDeliCus.EntryBox = Nothing
        Me.BttnBoxDeliCus.GridData = Nothing
        Me.BttnBoxDeliCus.GridDataTree = Nothing
        Me.BttnBoxDeliCus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEditDeliCus, Me.btnSaveDeliCus, Me.btnHelpDeliCus})
        Me.BttnBoxDeliCus.Location = New System.Drawing.Point(0, 0)
        Me.BttnBoxDeliCus.Name = "BttnBoxDeliCus"
        Me.BttnBoxDeliCus.Size = New System.Drawing.Size(1044, 42)
        Me.BttnBoxDeliCus.StatusBox = Nothing
        Me.BttnBoxDeliCus.TabIndex = 16
        Me.BttnBoxDeliCus.Text = "OpeButtonBox1"
        '
        'btnEditDeliCus
        '
        Me.btnEditDeliCus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditDeliCus.Image = CType(resources.GetObject("btnEditDeliCus.Image"), System.Drawing.Image)
        Me.btnEditDeliCus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEditDeliCus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditDeliCus.Name = "btnEditDeliCus"
        Me.btnEditDeliCus.Size = New System.Drawing.Size(36, 39)
        Me.btnEditDeliCus.Text = "Edit"
        Me.btnEditDeliCus.ToolTipText = "Edit"
        '
        'btnSaveDeliCus
        '
        Me.btnSaveDeliCus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSaveDeliCus.Image = CType(resources.GetObject("btnSaveDeliCus.Image"), System.Drawing.Image)
        Me.btnSaveDeliCus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSaveDeliCus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveDeliCus.Name = "btnSaveDeliCus"
        Me.btnSaveDeliCus.Size = New System.Drawing.Size(36, 39)
        Me.btnSaveDeliCus.Text = "Save"
        Me.btnSaveDeliCus.ToolTipText = "Save"
        '
        'btnHelpDeliCus
        '
        Me.btnHelpDeliCus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnHelpDeliCus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelpDeliCus.Image = CType(resources.GetObject("btnHelpDeliCus.Image"), System.Drawing.Image)
        Me.btnHelpDeliCus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnHelpDeliCus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHelpDeliCus.Name = "btnHelpDeliCus"
        Me.btnHelpDeliCus.Size = New System.Drawing.Size(39, 39)
        Me.btnHelpDeliCus.Text = "ToolStripButton1"
        Me.btnHelpDeliCus.ToolTipText = "Help"
        '
        'clsVWorkPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1066, 622)
        Me.Controls.Add(Me.OpePanel1)
        Me.Name = "clsVWorkPeriod"
        Me.Text = "Work Period"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.OpePanel1.ResumeLayout(False)
        Me.tabTimeControl.ResumeLayout(False)
        Me.PgeWokingZF.ResumeLayout(False)
        Me.PgeWokingZF.PerformLayout()
        CType(Me.grdWorkingZF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BttnBoxWorkZF.ResumeLayout(False)
        Me.BttnBoxWorkZF.PerformLayout()
        Me.PgeWorkingCus.ResumeLayout(False)
        Me.PgeWorkingCus.PerformLayout()
        CType(Me.grdWorkingCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BttnBoxWorkCus.ResumeLayout(False)
        Me.BttnBoxWorkCus.PerformLayout()
        Me.PgeDeliveryZF.ResumeLayout(False)
        Me.PgeDeliveryZF.PerformLayout()
        CType(Me.grdDeliZF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BttnBoxDeliZF.ResumeLayout(False)
        Me.BttnBoxDeliZF.PerformLayout()
        Me.PgeDeliveryCus.ResumeLayout(False)
        Me.PgeDeliveryCus.PerformLayout()
        CType(Me.grdDeliCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BttnBoxDeliCus.ResumeLayout(False)
        Me.BttnBoxDeliCus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpePanel1 As OPE_Controls.OpePanel
    Friend WithEvents tabTimeControl As System.Windows.Forms.TabControl
    Friend WithEvents PgeWokingZF As System.Windows.Forms.TabPage
    Friend WithEvents PgeWorkingCus As System.Windows.Forms.TabPage
    Friend WithEvents BttnBoxWorkZF As OPE_Controls.OpeButtonBox
    Friend WithEvents btnEditWorkZF As OPE_Controls.OpeButtonEdit
    Friend WithEvents btnSaveWorkZF As OPE_Controls.OpeButtonSave
    Friend WithEvents grdWorkingZF As OPE_Controls.opeDataGrid
    Friend WithEvents grdWorkingCustomer As OPE_Controls.opeDataGrid
    Friend WithEvents BttnBoxWorkCus As OPE_Controls.OpeButtonBox
    Friend WithEvents btnEditWorkCus As OPE_Controls.OpeButtonEdit
    Friend WithEvents btnSaveWorkCus As OPE_Controls.OpeButtonSave
    Friend WithEvents PgeDeliveryZF As System.Windows.Forms.TabPage
    Friend WithEvents PgeDeliveryCus As System.Windows.Forms.TabPage
    Friend WithEvents grdDeliZF As OPE_Controls.opeDataGrid
    Friend WithEvents BttnBoxDeliZF As OPE_Controls.OpeButtonBox
    Friend WithEvents btnEditDeliZF As OPE_Controls.OpeButtonEdit
    Friend WithEvents btnSaveDeliZF As OPE_Controls.OpeButtonSave
    Friend WithEvents grdDeliCus As OPE_Controls.opeDataGrid
    Friend WithEvents btnHelpDeliZF As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHelpWorkTimeZF As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHelpWorkTimeCus As System.Windows.Forms.ToolStripButton
    Friend WithEvents BttnBoxDeliCus As OPE_Controls.OpeButtonBox
    Friend WithEvents btnEditDeliCus As OPE_Controls.OpeButtonEdit
    Friend WithEvents btnSaveDeliCus As OPE_Controls.OpeButtonSave
    Friend WithEvents btnHelpDeliCus As System.Windows.Forms.ToolStripButton
End Class
