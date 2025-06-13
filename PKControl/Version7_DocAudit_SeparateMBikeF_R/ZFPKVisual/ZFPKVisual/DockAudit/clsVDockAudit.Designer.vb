<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVDockAudit
    Inherits OPE_Controls.OpeForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVDockAudit))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New OPE_Controls.OpeButtonSave()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New OPE_Controls.OpeButtonNew()
        Me.btnEdit = New OPE_Controls.OpeButtonEdit()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New OPE_Controls.OpeButtonDeleteDoc()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSync = New OPE_Controls.OpeButtonStrip()
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.grdData = New OPE_Controls.opeDataGrid()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.cboAxleShock = New OPE_Controls.OpeComboBox2()
        Me.chkSAxleShock = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSModelDock = New OPE_Controls.OpeComboBox2()
        Me.txtSLot = New OPE_Controls.OpeTextBox()
        Me.chkSLot = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSVariant = New OPE_Controls.OpeComboBox2()
        Me.chkSVaraint = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSModelDock = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSArea = New OPE_Controls.OpeComboBox2()
        Me.chkSArea = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSAuditDate = New OPE_Controls.OpeCheckBox(Me.components)
        Me.OpeLabel3 = New OPE_Controls.OpeLabel(Me.components)
        Me.dtpSAuditDate2 = New OPE_Controls.OpeDateTime(Me.components)
        Me.dtpSAuditDate1 = New OPE_Controls.OpeDateTime(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        Me.grpData.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 614)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(1352, 22)
        Me.StatusBox.TabIndex = 7
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Me.grdData
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.ToolStripSeparator1, Me.btnSave, Me.ToolStripSeparator2, Me.btnNew, Me.btnEdit, Me.ToolStripSeparator3, Me.btnDelete, Me.ToolStripSeparator4, Me.btnSync})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(1352, 39)
        Me.ButtonBoxH.StatusBox = Me.StatusBox
        Me.ButtonBoxH.TabIndex = 6
        Me.ButtonBoxH.Text = "OpeButtonBox1"
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.IsWaitThread = False
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(36, 36)
        Me.btnSearch.Text = "Search"
        Me.btnSearch.ToolTipText = "Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(36, 36)
        Me.btnSave.Text = "Save"
        Me.btnSave.ToolTipText = "Save"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(36, 36)
        Me.btnNew.Text = "New"
        Me.btnNew.ToolTipText = "New"
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(36, 36)
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.ToolTipText = "Edit"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(36, 36)
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.ToolTipText = "Delete"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'btnSync
        '
        Me.btnSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSync.Image = Global.ZFPKVisual.My.Resources.Resources.Handy
        Me.btnSync.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSync.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(36, 36)
        Me.btnSync.Text = "Syncronize"
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 157)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1352, 457)
        Me.grpData.TabIndex = 9
        Me.grpData.TabStop = False
        Me.grpData.Text = "Search Result"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grdData.AutoGenerateRecordNo = False
        Me.grdData.ChangeEnterToTab = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.EnableHeadersVisualStyles = False
        Me.grdData.IsStatus = False
        Me.grdData.Location = New System.Drawing.Point(6, 15)
        Me.grdData.Name = "grdData"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(1336, 436)
        Me.grdData.TabIndex = 1
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.cboAxleShock)
        Me.grpSearchCondition.Controls.Add(Me.chkSAxleShock)
        Me.grpSearchCondition.Controls.Add(Me.cboSModelDock)
        Me.grpSearchCondition.Controls.Add(Me.txtSLot)
        Me.grpSearchCondition.Controls.Add(Me.chkSLot)
        Me.grpSearchCondition.Controls.Add(Me.cboSVariant)
        Me.grpSearchCondition.Controls.Add(Me.chkSVaraint)
        Me.grpSearchCondition.Controls.Add(Me.chkSModelDock)
        Me.grpSearchCondition.Controls.Add(Me.cboSArea)
        Me.grpSearchCondition.Controls.Add(Me.chkSArea)
        Me.grpSearchCondition.Controls.Add(Me.chkSAuditDate)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel3)
        Me.grpSearchCondition.Controls.Add(Me.dtpSAuditDate2)
        Me.grpSearchCondition.Controls.Add(Me.dtpSAuditDate1)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 39)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(1352, 118)
        Me.grpSearchCondition.TabIndex = 8
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'cboAxleShock
        '
        Me.cboAxleShock.BackColor = System.Drawing.Color.White
        Me.cboAxleShock.Busy = True
        Me.cboAxleShock.DataSource = Nothing
        Me.cboAxleShock.DisplayMember = ""
        Me.cboAxleShock.DisplayMemberLength = Nothing
        Me.cboAxleShock.DisplayMemberList = ""
        Me.cboAxleShock.DisplayMemberText = Nothing
        Me.cboAxleShock.DisplayMemberText2 = Nothing
        Me.cboAxleShock.DisplayMemberText3 = Nothing
        Me.cboAxleShock.DisplayShowButton = False
        Me.cboAxleShock.DropDownList = False
        Me.cboAxleShock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboAxleShock.ForeColor = System.Drawing.Color.Black
        Me.cboAxleShock.IsTextBox = False
        Me.cboAxleShock.LinkCheck = Nothing
        Me.cboAxleShock.LinkCheckedBox = Nothing
        Me.cboAxleShock.LinkTextBox = Nothing
        Me.cboAxleShock.LinkTextBox2 = Nothing
        Me.cboAxleShock.LinkTextBox3 = Nothing
        Me.cboAxleShock.Location = New System.Drawing.Point(799, 65)
        Me.cboAxleShock.Margin = New System.Windows.Forms.Padding(0)
        Me.cboAxleShock.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboAxleShock.MaxLength = 32767
        Me.cboAxleShock.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboAxleShock.Name = "cboAxleShock"
        Me.cboAxleShock.NotNull = False
        Me.cboAxleShock.RefreshWidth = False
        Me.cboAxleShock.RowFilter = ""
        Me.cboAxleShock.SelectedIndex = -1
        Me.cboAxleShock.SelectedValue = Nothing
        Me.cboAxleShock.Size = New System.Drawing.Size(182, 23)
        Me.cboAxleShock.TabIndex = 14
        Me.cboAxleShock.ValueMember = ""
        '
        'chkSAxleShock
        '
        Me.chkSAxleShock.AutoSize = True
        Me.chkSAxleShock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSAxleShock.Location = New System.Drawing.Point(701, 66)
        Me.chkSAxleShock.Name = "chkSAxleShock"
        Me.chkSAxleShock.Size = New System.Drawing.Size(96, 21)
        Me.chkSAxleShock.TabIndex = 13
        Me.chkSAxleShock.Text = "Axle/Shock"
        Me.chkSAxleShock.UseVisualStyleBackColor = True
        '
        'cboSModelDock
        '
        Me.cboSModelDock.BackColor = System.Drawing.Color.White
        Me.cboSModelDock.Busy = True
        Me.cboSModelDock.DataSource = Nothing
        Me.cboSModelDock.DisplayMember = ""
        Me.cboSModelDock.DisplayMemberLength = Nothing
        Me.cboSModelDock.DisplayMemberList = ""
        Me.cboSModelDock.DisplayMemberText = Nothing
        Me.cboSModelDock.DisplayMemberText2 = Nothing
        Me.cboSModelDock.DisplayMemberText3 = Nothing
        Me.cboSModelDock.DisplayShowButton = False
        Me.cboSModelDock.DropDownList = False
        Me.cboSModelDock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSModelDock.ForeColor = System.Drawing.Color.Black
        Me.cboSModelDock.IsTextBox = False
        Me.cboSModelDock.LinkCheck = Nothing
        Me.cboSModelDock.LinkCheckedBox = Nothing
        Me.cboSModelDock.LinkTextBox = Nothing
        Me.cboSModelDock.LinkTextBox2 = Nothing
        Me.cboSModelDock.LinkTextBox3 = Nothing
        Me.cboSModelDock.Location = New System.Drawing.Point(799, 28)
        Me.cboSModelDock.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSModelDock.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSModelDock.MaxLength = 32767
        Me.cboSModelDock.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSModelDock.Name = "cboSModelDock"
        Me.cboSModelDock.NotNull = False
        Me.cboSModelDock.RefreshWidth = False
        Me.cboSModelDock.RowFilter = ""
        Me.cboSModelDock.SelectedIndex = -1
        Me.cboSModelDock.SelectedValue = Nothing
        Me.cboSModelDock.Size = New System.Drawing.Size(182, 23)
        Me.cboSModelDock.TabIndex = 12
        Me.cboSModelDock.ValueMember = ""
        '
        'txtSLot
        '
        Me.txtSLot.Add_Comma = False
        Me.txtSLot.DataSource = Nothing
        Me.txtSLot.DecimalDigit = 2
        Me.txtSLot.DisplayMember = Nothing
        Me.txtSLot.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSLot.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtSLot.LinkCheckedBox = Nothing
        Me.txtSLot.Location = New System.Drawing.Point(461, 65)
        Me.txtSLot.MaxValue = 99999.99R
        Me.txtSLot.MinValue = -99999.99R
        Me.txtSLot.Name = "txtSLot"
        Me.txtSLot.NotNull = False
        Me.txtSLot.ShowDecimal = False
        Me.txtSLot.Size = New System.Drawing.Size(182, 22)
        Me.txtSLot.TabIndex = 11
        '
        'chkSLot
        '
        Me.chkSLot.AutoSize = True
        Me.chkSLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSLot.Location = New System.Drawing.Point(381, 66)
        Me.chkSLot.Name = "chkSLot"
        Me.chkSLot.Size = New System.Drawing.Size(73, 21)
        Me.chkSLot.TabIndex = 10
        Me.chkSLot.Text = "Lot No."
        Me.chkSLot.UseVisualStyleBackColor = True
        '
        'cboSVariant
        '
        Me.cboSVariant.BackColor = System.Drawing.Color.White
        Me.cboSVariant.Busy = True
        Me.cboSVariant.DataSource = Nothing
        Me.cboSVariant.DisplayMember = ""
        Me.cboSVariant.DisplayMemberLength = Nothing
        Me.cboSVariant.DisplayMemberList = ""
        Me.cboSVariant.DisplayMemberText = Nothing
        Me.cboSVariant.DisplayMemberText2 = Nothing
        Me.cboSVariant.DisplayMemberText3 = Nothing
        Me.cboSVariant.DisplayShowButton = False
        Me.cboSVariant.DropDownList = False
        Me.cboSVariant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSVariant.ForeColor = System.Drawing.Color.Black
        Me.cboSVariant.IsTextBox = False
        Me.cboSVariant.LinkCheck = Nothing
        Me.cboSVariant.LinkCheckedBox = Nothing
        Me.cboSVariant.LinkTextBox = Nothing
        Me.cboSVariant.LinkTextBox2 = Nothing
        Me.cboSVariant.LinkTextBox3 = Nothing
        Me.cboSVariant.Location = New System.Drawing.Point(129, 64)
        Me.cboSVariant.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSVariant.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSVariant.MaxLength = 32767
        Me.cboSVariant.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSVariant.Name = "cboSVariant"
        Me.cboSVariant.NotNull = False
        Me.cboSVariant.RefreshWidth = False
        Me.cboSVariant.RowFilter = ""
        Me.cboSVariant.SelectedIndex = -1
        Me.cboSVariant.SelectedValue = Nothing
        Me.cboSVariant.Size = New System.Drawing.Size(182, 23)
        Me.cboSVariant.TabIndex = 9
        Me.cboSVariant.ValueMember = ""
        '
        'chkSVaraint
        '
        Me.chkSVaraint.AutoSize = True
        Me.chkSVaraint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSVaraint.Location = New System.Drawing.Point(26, 65)
        Me.chkSVaraint.Name = "chkSVaraint"
        Me.chkSVaraint.Size = New System.Drawing.Size(72, 21)
        Me.chkSVaraint.TabIndex = 8
        Me.chkSVaraint.Text = "Variant"
        Me.chkSVaraint.UseVisualStyleBackColor = True
        '
        'chkSModelDock
        '
        Me.chkSModelDock.AutoSize = True
        Me.chkSModelDock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSModelDock.Location = New System.Drawing.Point(701, 29)
        Me.chkSModelDock.Name = "chkSModelDock"
        Me.chkSModelDock.Size = New System.Drawing.Size(65, 21)
        Me.chkSModelDock.TabIndex = 6
        Me.chkSModelDock.Text = "Model"
        Me.chkSModelDock.UseVisualStyleBackColor = True
        '
        'cboSArea
        '
        Me.cboSArea.BackColor = System.Drawing.Color.White
        Me.cboSArea.Busy = True
        Me.cboSArea.DataSource = Nothing
        Me.cboSArea.DisplayMember = ""
        Me.cboSArea.DisplayMemberLength = Nothing
        Me.cboSArea.DisplayMemberList = ""
        Me.cboSArea.DisplayMemberText = Nothing
        Me.cboSArea.DisplayMemberText2 = Nothing
        Me.cboSArea.DisplayMemberText3 = Nothing
        Me.cboSArea.DisplayShowButton = False
        Me.cboSArea.DropDownList = False
        Me.cboSArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSArea.ForeColor = System.Drawing.Color.Black
        Me.cboSArea.IsTextBox = False
        Me.cboSArea.LinkCheck = Nothing
        Me.cboSArea.LinkCheckedBox = Nothing
        Me.cboSArea.LinkTextBox = Nothing
        Me.cboSArea.LinkTextBox2 = Nothing
        Me.cboSArea.LinkTextBox3 = Nothing
        Me.cboSArea.Location = New System.Drawing.Point(461, 28)
        Me.cboSArea.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSArea.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSArea.MaxLength = 32767
        Me.cboSArea.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSArea.Name = "cboSArea"
        Me.cboSArea.NotNull = False
        Me.cboSArea.RefreshWidth = False
        Me.cboSArea.RowFilter = ""
        Me.cboSArea.SelectedIndex = -1
        Me.cboSArea.SelectedValue = Nothing
        Me.cboSArea.Size = New System.Drawing.Size(182, 23)
        Me.cboSArea.TabIndex = 5
        Me.cboSArea.ValueMember = ""
        '
        'chkSArea
        '
        Me.chkSArea.AutoSize = True
        Me.chkSArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSArea.Location = New System.Drawing.Point(381, 29)
        Me.chkSArea.Name = "chkSArea"
        Me.chkSArea.Size = New System.Drawing.Size(57, 21)
        Me.chkSArea.TabIndex = 4
        Me.chkSArea.Text = "Arae"
        Me.chkSArea.UseVisualStyleBackColor = True
        '
        'chkSAuditDate
        '
        Me.chkSAuditDate.AutoSize = True
        Me.chkSAuditDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSAuditDate.Location = New System.Drawing.Point(26, 28)
        Me.chkSAuditDate.Name = "chkSAuditDate"
        Me.chkSAuditDate.Size = New System.Drawing.Size(93, 21)
        Me.chkSAuditDate.TabIndex = 0
        Me.chkSAuditDate.Text = "Audit Date"
        Me.chkSAuditDate.UseVisualStyleBackColor = True
        '
        'OpeLabel3
        '
        Me.OpeLabel3.AutoSize = True
        Me.OpeLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel3.LabelId = 0
        Me.OpeLabel3.Location = New System.Drawing.Point(224, 30)
        Me.OpeLabel3.Name = "OpeLabel3"
        Me.OpeLabel3.Size = New System.Drawing.Size(16, 17)
        Me.OpeLabel3.TabIndex = 2
        Me.OpeLabel3.Text = "~"
        '
        'dtpSAuditDate2
        '
        Me.dtpSAuditDate2.CustomFormat = "dd/MM/yyyy"
        Me.dtpSAuditDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpSAuditDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSAuditDate2.HideButton = False
        Me.dtpSAuditDate2.LinkCheckedBox = Nothing
        Me.dtpSAuditDate2.LinkDateTime = Nothing
        Me.dtpSAuditDate2.Location = New System.Drawing.Point(243, 27)
        Me.dtpSAuditDate2.Name = "dtpSAuditDate2"
        Me.dtpSAuditDate2.Size = New System.Drawing.Size(93, 23)
        Me.dtpSAuditDate2.TabIndex = 3
        Me.dtpSAuditDate2.TextValue = "20180530"
        Me.dtpSAuditDate2.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'dtpSAuditDate1
        '
        Me.dtpSAuditDate1.CustomFormat = "dd/MM/yyyy"
        Me.dtpSAuditDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpSAuditDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSAuditDate1.HideButton = False
        Me.dtpSAuditDate1.LinkCheckedBox = Nothing
        Me.dtpSAuditDate1.LinkDateTime = Nothing
        Me.dtpSAuditDate1.Location = New System.Drawing.Point(129, 27)
        Me.dtpSAuditDate1.Name = "dtpSAuditDate1"
        Me.dtpSAuditDate1.Size = New System.Drawing.Size(93, 23)
        Me.dtpSAuditDate1.TabIndex = 1
        Me.dtpSAuditDate1.TextValue = "20180530"
        Me.dtpSAuditDate1.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'clsVDockAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 636)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVDockAudit"
        Me.Text = "Dock Audit"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        Me.grpData.ResumeLayout(False)
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As OPE_Controls.OpeButtonSave
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As OPE_Controls.OpeButtonNew
    Friend WithEvents btnEdit As OPE_Controls.OpeButtonEdit
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As OPE_Controls.OpeButtonDeleteDoc
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents chkSAuditDate As OPE_Controls.OpeCheckBox
    Friend WithEvents OpeLabel3 As OPE_Controls.OpeLabel
    Friend WithEvents dtpSAuditDate2 As OPE_Controls.OpeDateTime
    Friend WithEvents dtpSAuditDate1 As OPE_Controls.OpeDateTime
    Friend WithEvents btnSync As OPE_Controls.OpeButtonStrip
    Friend WithEvents cboSArea As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSArea As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSLot As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSVariant As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSVaraint As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSModelDock As OPE_Controls.OpeCheckBox
    Friend WithEvents txtSLot As OPE_Controls.OpeTextBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents cboSModelDock As OPE_Controls.OpeComboBox2
    Friend WithEvents cboAxleShock As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSAxleShock As OPE_Controls.OpeCheckBox
End Class
