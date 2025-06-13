<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVMstPart
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVMstPart))
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.grdData = New OPE_Controls.opeDataGrid()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New OPE_Controls.OpeButtonSave()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New OPE_Controls.OpeButtonNew()
        Me.btnEdit = New OPE_Controls.OpeButtonEdit()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New OPE_Controls.OpeButtonDeleteDoc()
        Me.btnLogo = New System.Windows.Forms.ToolStripButton()
        Me.grpUpdateData = New OPE_Controls.OpeGroupBox()
        Me.cboModelDock = New OPE_Controls.OpeComboBox2()
        Me.lblModelDock = New OPE_Controls.OpeLabel(Me.components)
        Me.chkCaliperFlag = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboPartType = New OPE_Controls.OpeComboBox2()
        Me.lblPartType = New OPE_Controls.OpeLabel(Me.components)
        Me.txtVariant = New OPE_Controls.OpeTextBox()
        Me.cboAreaCode = New OPE_Controls.OpeComboBox2()
        Me.lblAreaCode = New OPE_Controls.OpeLabel(Me.components)
        Me.txtPartNo = New OPE_Controls.OpeTextBox()
        Me.lblPartNo = New OPE_Controls.OpeLabel(Me.components)
        Me.lblVariant = New OPE_Controls.OpeLabel(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.cboSCaliper = New OPE_Controls.OpeComboBox2()
        Me.chkSCaliper = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSPartNo = New OPE_Controls.OpeComboBox2()
        Me.cboSPartType = New OPE_Controls.OpeComboBox2()
        Me.chkSPartType = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSPartNo = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSVariant = New OPE_Controls.OpeComboBox2()
        Me.chkSVariant = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSAreaCode = New OPE_Controls.OpeComboBox2()
        Me.chkSAreaCode = New OPE_Controls.OpeCheckBox(Me.components)
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chkSActiveFlag = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkActiveFlag = New OPE_Controls.OpeCheckBox(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUpdateData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpSearchCondition.SuspendLayout()
        Me.grpData.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 674)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(1267, 22)
        Me.StatusBox.TabIndex = 8
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Me.grdData
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.ToolStripSeparator1, Me.btnSave, Me.ToolStripSeparator2, Me.btnNew, Me.btnEdit, Me.ToolStripSeparator3, Me.btnDelete, Me.btnLogo})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(1267, 57)
        Me.ButtonBoxH.StatusBox = Me.StatusBox
        Me.ButtonBoxH.TabIndex = 0
        Me.ButtonBoxH.Text = "OpeButtonBox1"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.AutoGenerateRecordNo = False
        Me.grdData.ChangeEnterToTab = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.EnableHeadersVisualStyles = False
        Me.grdData.IsStatus = False
        Me.grdData.Location = New System.Drawing.Point(6, 15)
        Me.grdData.Name = "grdData"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(1251, 274)
        Me.grdData.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.IsWaitThread = False
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(36, 54)
        Me.btnSearch.Text = "Search"
        Me.btnSearch.ToolTipText = "Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 57)
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(36, 54)
        Me.btnSave.Text = "Save"
        Me.btnSave.ToolTipText = "Save"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 57)
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(36, 54)
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
        Me.btnEdit.Size = New System.Drawing.Size(36, 54)
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.ToolTipText = "Edit"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 57)
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(36, 54)
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.ToolTipText = "Delete"
        '
        'btnLogo
        '
        Me.btnLogo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        Me.btnLogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLogo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(54, 54)
        Me.btnLogo.Text = "ToolStripButton1"
        '
        'grpUpdateData
        '
        Me.grpUpdateData.Controls.Add(Me.chkActiveFlag)
        Me.grpUpdateData.Controls.Add(Me.cboModelDock)
        Me.grpUpdateData.Controls.Add(Me.lblModelDock)
        Me.grpUpdateData.Controls.Add(Me.chkCaliperFlag)
        Me.grpUpdateData.Controls.Add(Me.cboPartType)
        Me.grpUpdateData.Controls.Add(Me.lblPartType)
        Me.grpUpdateData.Controls.Add(Me.txtVariant)
        Me.grpUpdateData.Controls.Add(Me.cboAreaCode)
        Me.grpUpdateData.Controls.Add(Me.lblAreaCode)
        Me.grpUpdateData.Controls.Add(Me.txtPartNo)
        Me.grpUpdateData.Controls.Add(Me.lblPartNo)
        Me.grpUpdateData.Controls.Add(Me.lblVariant)
        Me.grpUpdateData.Controls.Add(Me.Panel1)
        Me.grpUpdateData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpUpdateData.Location = New System.Drawing.Point(0, 486)
        Me.grpUpdateData.Name = "grpUpdateData"
        Me.grpUpdateData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpUpdateData.Size = New System.Drawing.Size(1267, 188)
        Me.grpUpdateData.TabIndex = 3
        Me.grpUpdateData.TabStop = False
        '
        'cboModelDock
        '
        Me.cboModelDock.BackColor = System.Drawing.Color.White
        Me.cboModelDock.Busy = True
        Me.cboModelDock.DataSource = Nothing
        Me.cboModelDock.DisplayMember = ""
        Me.cboModelDock.DisplayMemberLength = Nothing
        Me.cboModelDock.DisplayMemberList = ""
        Me.cboModelDock.DisplayMemberText = Nothing
        Me.cboModelDock.DisplayMemberText2 = Nothing
        Me.cboModelDock.DisplayMemberText3 = Nothing
        Me.cboModelDock.DisplayShowButton = False
        Me.cboModelDock.DropDownList = False
        Me.cboModelDock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboModelDock.ForeColor = System.Drawing.Color.Black
        Me.cboModelDock.IsTextBox = False
        Me.cboModelDock.LinkCheck = Nothing
        Me.cboModelDock.LinkCheckedBox = Nothing
        Me.cboModelDock.LinkTextBox = Nothing
        Me.cboModelDock.LinkTextBox2 = Nothing
        Me.cboModelDock.LinkTextBox3 = Nothing
        Me.cboModelDock.Location = New System.Drawing.Point(554, 86)
        Me.cboModelDock.Margin = New System.Windows.Forms.Padding(0)
        Me.cboModelDock.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboModelDock.MaxLength = 32767
        Me.cboModelDock.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboModelDock.Name = "cboModelDock"
        Me.cboModelDock.NotNull = False
        Me.cboModelDock.RefreshWidth = False
        Me.cboModelDock.RowFilter = ""
        Me.cboModelDock.SelectedIndex = -1
        Me.cboModelDock.SelectedValue = Nothing
        Me.cboModelDock.Size = New System.Drawing.Size(172, 23)
        Me.cboModelDock.TabIndex = 11
        Me.cboModelDock.ValueMember = ""
        '
        'lblModelDock
        '
        Me.lblModelDock.AutoSize = True
        Me.lblModelDock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblModelDock.LabelId = 0
        Me.lblModelDock.Location = New System.Drawing.Point(383, 89)
        Me.lblModelDock.Name = "lblModelDock"
        Me.lblModelDock.Size = New System.Drawing.Size(159, 17)
        Me.lblModelDock.TabIndex = 10
        Me.lblModelDock.Text = "Model Dock Audit (Bike)"
        '
        'chkCaliperFlag
        '
        Me.chkCaliperFlag.AutoSize = True
        Me.chkCaliperFlag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkCaliperFlag.Location = New System.Drawing.Point(383, 125)
        Me.chkCaliperFlag.Name = "chkCaliperFlag"
        Me.chkCaliperFlag.Size = New System.Drawing.Size(103, 21)
        Me.chkCaliperFlag.TabIndex = 9
        Me.chkCaliperFlag.Text = "With Caliper"
        Me.chkCaliperFlag.UseVisualStyleBackColor = True
        '
        'cboPartType
        '
        Me.cboPartType.BackColor = System.Drawing.Color.White
        Me.cboPartType.Busy = True
        Me.cboPartType.DataSource = Nothing
        Me.cboPartType.DisplayMember = ""
        Me.cboPartType.DisplayMemberLength = Nothing
        Me.cboPartType.DisplayMemberList = ""
        Me.cboPartType.DisplayMemberText = Nothing
        Me.cboPartType.DisplayMemberText2 = Nothing
        Me.cboPartType.DisplayMemberText3 = Nothing
        Me.cboPartType.DisplayShowButton = False
        Me.cboPartType.DropDownList = False
        Me.cboPartType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboPartType.ForeColor = System.Drawing.Color.Black
        Me.cboPartType.IsTextBox = False
        Me.cboPartType.LinkCheck = Nothing
        Me.cboPartType.LinkCheckedBox = Nothing
        Me.cboPartType.LinkTextBox = Nothing
        Me.cboPartType.LinkTextBox2 = Nothing
        Me.cboPartType.LinkTextBox3 = Nothing
        Me.cboPartType.Location = New System.Drawing.Point(122, 86)
        Me.cboPartType.Margin = New System.Windows.Forms.Padding(0)
        Me.cboPartType.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboPartType.MaxLength = 32767
        Me.cboPartType.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboPartType.Name = "cboPartType"
        Me.cboPartType.NotNull = False
        Me.cboPartType.RefreshWidth = False
        Me.cboPartType.RowFilter = ""
        Me.cboPartType.SelectedIndex = -1
        Me.cboPartType.SelectedValue = Nothing
        Me.cboPartType.Size = New System.Drawing.Size(172, 23)
        Me.cboPartType.TabIndex = 5
        Me.cboPartType.ValueMember = ""
        '
        'lblPartType
        '
        Me.lblPartType.AutoSize = True
        Me.lblPartType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPartType.LabelId = 0
        Me.lblPartType.Location = New System.Drawing.Point(34, 89)
        Me.lblPartType.Name = "lblPartType"
        Me.lblPartType.Size = New System.Drawing.Size(70, 17)
        Me.lblPartType.TabIndex = 4
        Me.lblPartType.Text = "Part Type"
        '
        'txtVariant
        '
        Me.txtVariant.Add_Comma = False
        Me.txtVariant.DataSource = Nothing
        Me.txtVariant.DecimalDigit = 2
        Me.txtVariant.DisplayMember = Nothing
        Me.txtVariant.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtVariant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtVariant.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtVariant.LinkCheckedBox = Nothing
        Me.txtVariant.Location = New System.Drawing.Point(122, 44)
        Me.txtVariant.MaxValue = 99999.99R
        Me.txtVariant.MinValue = -99999.99R
        Me.txtVariant.Name = "txtVariant"
        Me.txtVariant.NotNull = False
        Me.txtVariant.ShowDecimal = False
        Me.txtVariant.Size = New System.Drawing.Size(172, 23)
        Me.txtVariant.TabIndex = 1
        '
        'cboAreaCode
        '
        Me.cboAreaCode.BackColor = System.Drawing.Color.White
        Me.cboAreaCode.Busy = True
        Me.cboAreaCode.DataSource = Nothing
        Me.cboAreaCode.DisplayMember = ""
        Me.cboAreaCode.DisplayMemberLength = Nothing
        Me.cboAreaCode.DisplayMemberList = ""
        Me.cboAreaCode.DisplayMemberText = Nothing
        Me.cboAreaCode.DisplayMemberText2 = Nothing
        Me.cboAreaCode.DisplayMemberText3 = Nothing
        Me.cboAreaCode.DisplayShowButton = False
        Me.cboAreaCode.DropDownList = False
        Me.cboAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboAreaCode.ForeColor = System.Drawing.Color.Black
        Me.cboAreaCode.IsTextBox = False
        Me.cboAreaCode.LinkCheck = Nothing
        Me.cboAreaCode.LinkCheckedBox = Nothing
        Me.cboAreaCode.LinkTextBox = Nothing
        Me.cboAreaCode.LinkTextBox2 = Nothing
        Me.cboAreaCode.LinkTextBox3 = Nothing
        Me.cboAreaCode.Location = New System.Drawing.Point(554, 44)
        Me.cboAreaCode.Margin = New System.Windows.Forms.Padding(0)
        Me.cboAreaCode.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboAreaCode.MaxLength = 32767
        Me.cboAreaCode.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboAreaCode.Name = "cboAreaCode"
        Me.cboAreaCode.NotNull = False
        Me.cboAreaCode.RefreshWidth = False
        Me.cboAreaCode.RowFilter = ""
        Me.cboAreaCode.SelectedIndex = -1
        Me.cboAreaCode.SelectedValue = Nothing
        Me.cboAreaCode.Size = New System.Drawing.Size(172, 23)
        Me.cboAreaCode.TabIndex = 3
        Me.cboAreaCode.ValueMember = ""
        '
        'lblAreaCode
        '
        Me.lblAreaCode.AutoSize = True
        Me.lblAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAreaCode.LabelId = 0
        Me.lblAreaCode.Location = New System.Drawing.Point(383, 47)
        Me.lblAreaCode.Name = "lblAreaCode"
        Me.lblAreaCode.Size = New System.Drawing.Size(75, 17)
        Me.lblAreaCode.TabIndex = 2
        Me.lblAreaCode.Text = "Area Code"
        '
        'txtPartNo
        '
        Me.txtPartNo.Add_Comma = False
        Me.txtPartNo.DataSource = Nothing
        Me.txtPartNo.DecimalDigit = 2
        Me.txtPartNo.DisplayMember = Nothing
        Me.txtPartNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtPartNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPartNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtPartNo.LinkCheckedBox = Nothing
        Me.txtPartNo.Location = New System.Drawing.Point(122, 124)
        Me.txtPartNo.MaxValue = 99999.99R
        Me.txtPartNo.MinValue = -99999.99R
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.NotNull = False
        Me.txtPartNo.ShowDecimal = False
        Me.txtPartNo.Size = New System.Drawing.Size(172, 23)
        Me.txtPartNo.TabIndex = 7
        '
        'lblPartNo
        '
        Me.lblPartNo.AutoSize = True
        Me.lblPartNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPartNo.LabelId = 0
        Me.lblPartNo.Location = New System.Drawing.Point(34, 127)
        Me.lblPartNo.Name = "lblPartNo"
        Me.lblPartNo.Size = New System.Drawing.Size(60, 17)
        Me.lblPartNo.TabIndex = 6
        Me.lblPartNo.Text = "Part No."
        '
        'lblVariant
        '
        Me.lblVariant.AutoSize = True
        Me.lblVariant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblVariant.LabelId = 0
        Me.lblVariant.Location = New System.Drawing.Point(34, 47)
        Me.lblVariant.Name = "lblVariant"
        Me.lblVariant.Size = New System.Drawing.Size(53, 17)
        Me.lblVariant.TabIndex = 0
        Me.lblVariant.Text = "Variant"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(835, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(50, 98)
        Me.Panel1.TabIndex = 8
        Me.Panel1.TabStop = True
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(41, 40)
        Me.btnOK.TabIndex = 0
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(3, 49)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(41, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.chkSActiveFlag)
        Me.grpSearchCondition.Controls.Add(Me.cboSCaliper)
        Me.grpSearchCondition.Controls.Add(Me.chkSCaliper)
        Me.grpSearchCondition.Controls.Add(Me.cboSPartNo)
        Me.grpSearchCondition.Controls.Add(Me.cboSPartType)
        Me.grpSearchCondition.Controls.Add(Me.chkSPartType)
        Me.grpSearchCondition.Controls.Add(Me.chkSPartNo)
        Me.grpSearchCondition.Controls.Add(Me.cboSVariant)
        Me.grpSearchCondition.Controls.Add(Me.chkSVariant)
        Me.grpSearchCondition.Controls.Add(Me.cboSAreaCode)
        Me.grpSearchCondition.Controls.Add(Me.chkSAreaCode)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 57)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(1267, 134)
        Me.grpSearchCondition.TabIndex = 1
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'cboSCaliper
        '
        Me.cboSCaliper.BackColor = System.Drawing.Color.White
        Me.cboSCaliper.Busy = True
        Me.cboSCaliper.DataSource = Nothing
        Me.cboSCaliper.DisplayMember = ""
        Me.cboSCaliper.DisplayMemberLength = Nothing
        Me.cboSCaliper.DisplayMemberList = ""
        Me.cboSCaliper.DisplayMemberText = Nothing
        Me.cboSCaliper.DisplayMemberText2 = Nothing
        Me.cboSCaliper.DisplayMemberText3 = Nothing
        Me.cboSCaliper.DisplayShowButton = False
        Me.cboSCaliper.DropDownList = False
        Me.cboSCaliper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSCaliper.ForeColor = System.Drawing.Color.Black
        Me.cboSCaliper.IsTextBox = False
        Me.cboSCaliper.LinkCheck = Nothing
        Me.cboSCaliper.LinkCheckedBox = Nothing
        Me.cboSCaliper.LinkTextBox = Nothing
        Me.cboSCaliper.LinkTextBox2 = Nothing
        Me.cboSCaliper.LinkTextBox3 = Nothing
        Me.cboSCaliper.Location = New System.Drawing.Point(147, 87)
        Me.cboSCaliper.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSCaliper.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSCaliper.MaxLength = 32767
        Me.cboSCaliper.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSCaliper.Name = "cboSCaliper"
        Me.cboSCaliper.NotNull = False
        Me.cboSCaliper.RefreshWidth = False
        Me.cboSCaliper.RowFilter = ""
        Me.cboSCaliper.SelectedIndex = -1
        Me.cboSCaliper.SelectedValue = Nothing
        Me.cboSCaliper.Size = New System.Drawing.Size(172, 23)
        Me.cboSCaliper.TabIndex = 9
        Me.cboSCaliper.ValueMember = ""
        '
        'chkSCaliper
        '
        Me.chkSCaliper.AutoSize = True
        Me.chkSCaliper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSCaliper.Location = New System.Drawing.Point(34, 88)
        Me.chkSCaliper.Name = "chkSCaliper"
        Me.chkSCaliper.Size = New System.Drawing.Size(101, 21)
        Me.chkSCaliper.TabIndex = 8
        Me.chkSCaliper.Text = "With caliper"
        Me.chkSCaliper.UseVisualStyleBackColor = True
        '
        'cboSPartNo
        '
        Me.cboSPartNo.BackColor = System.Drawing.Color.White
        Me.cboSPartNo.Busy = True
        Me.cboSPartNo.DataSource = Nothing
        Me.cboSPartNo.DisplayMember = ""
        Me.cboSPartNo.DisplayMemberLength = Nothing
        Me.cboSPartNo.DisplayMemberList = ""
        Me.cboSPartNo.DisplayMemberText = Nothing
        Me.cboSPartNo.DisplayMemberText2 = Nothing
        Me.cboSPartNo.DisplayMemberText3 = Nothing
        Me.cboSPartNo.DisplayShowButton = False
        Me.cboSPartNo.DropDownList = False
        Me.cboSPartNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSPartNo.ForeColor = System.Drawing.Color.Black
        Me.cboSPartNo.IsTextBox = False
        Me.cboSPartNo.LinkCheck = Nothing
        Me.cboSPartNo.LinkCheckedBox = Nothing
        Me.cboSPartNo.LinkTextBox = Nothing
        Me.cboSPartNo.LinkTextBox2 = Nothing
        Me.cboSPartNo.LinkTextBox3 = Nothing
        Me.cboSPartNo.Location = New System.Drawing.Point(470, 59)
        Me.cboSPartNo.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSPartNo.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSPartNo.MaxLength = 32767
        Me.cboSPartNo.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSPartNo.Name = "cboSPartNo"
        Me.cboSPartNo.NotNull = False
        Me.cboSPartNo.RefreshWidth = False
        Me.cboSPartNo.RowFilter = ""
        Me.cboSPartNo.SelectedIndex = -1
        Me.cboSPartNo.SelectedValue = Nothing
        Me.cboSPartNo.Size = New System.Drawing.Size(172, 23)
        Me.cboSPartNo.TabIndex = 7
        Me.cboSPartNo.ValueMember = ""
        '
        'cboSPartType
        '
        Me.cboSPartType.BackColor = System.Drawing.Color.White
        Me.cboSPartType.Busy = True
        Me.cboSPartType.DataSource = Nothing
        Me.cboSPartType.DisplayMember = ""
        Me.cboSPartType.DisplayMemberLength = Nothing
        Me.cboSPartType.DisplayMemberList = ""
        Me.cboSPartType.DisplayMemberText = Nothing
        Me.cboSPartType.DisplayMemberText2 = Nothing
        Me.cboSPartType.DisplayMemberText3 = Nothing
        Me.cboSPartType.DisplayShowButton = False
        Me.cboSPartType.DropDownList = False
        Me.cboSPartType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSPartType.ForeColor = System.Drawing.Color.Black
        Me.cboSPartType.IsTextBox = False
        Me.cboSPartType.LinkCheck = Nothing
        Me.cboSPartType.LinkCheckedBox = Nothing
        Me.cboSPartType.LinkTextBox = Nothing
        Me.cboSPartType.LinkTextBox2 = Nothing
        Me.cboSPartType.LinkTextBox3 = Nothing
        Me.cboSPartType.Location = New System.Drawing.Point(147, 59)
        Me.cboSPartType.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSPartType.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSPartType.MaxLength = 32767
        Me.cboSPartType.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSPartType.Name = "cboSPartType"
        Me.cboSPartType.NotNull = False
        Me.cboSPartType.RefreshWidth = False
        Me.cboSPartType.RowFilter = ""
        Me.cboSPartType.SelectedIndex = -1
        Me.cboSPartType.SelectedValue = Nothing
        Me.cboSPartType.Size = New System.Drawing.Size(172, 23)
        Me.cboSPartType.TabIndex = 5
        Me.cboSPartType.ValueMember = ""
        '
        'chkSPartType
        '
        Me.chkSPartType.AutoSize = True
        Me.chkSPartType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSPartType.Location = New System.Drawing.Point(34, 60)
        Me.chkSPartType.Name = "chkSPartType"
        Me.chkSPartType.Size = New System.Drawing.Size(89, 21)
        Me.chkSPartType.TabIndex = 4
        Me.chkSPartType.Text = "Part Type"
        Me.chkSPartType.UseVisualStyleBackColor = True
        '
        'chkSPartNo
        '
        Me.chkSPartNo.AutoSize = True
        Me.chkSPartNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSPartNo.Location = New System.Drawing.Point(373, 60)
        Me.chkSPartNo.Name = "chkSPartNo"
        Me.chkSPartNo.Size = New System.Drawing.Size(79, 21)
        Me.chkSPartNo.TabIndex = 6
        Me.chkSPartNo.Text = "Part No."
        Me.chkSPartNo.UseVisualStyleBackColor = True
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
        Me.cboSVariant.Location = New System.Drawing.Point(147, 31)
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
        Me.cboSVariant.Size = New System.Drawing.Size(172, 23)
        Me.cboSVariant.TabIndex = 1
        Me.cboSVariant.ValueMember = ""
        '
        'chkSVariant
        '
        Me.chkSVariant.AutoSize = True
        Me.chkSVariant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSVariant.Location = New System.Drawing.Point(34, 32)
        Me.chkSVariant.Name = "chkSVariant"
        Me.chkSVariant.Size = New System.Drawing.Size(72, 21)
        Me.chkSVariant.TabIndex = 0
        Me.chkSVariant.Text = "Variant"
        Me.chkSVariant.UseVisualStyleBackColor = True
        '
        'cboSAreaCode
        '
        Me.cboSAreaCode.BackColor = System.Drawing.Color.White
        Me.cboSAreaCode.Busy = True
        Me.cboSAreaCode.DataSource = Nothing
        Me.cboSAreaCode.DisplayMember = ""
        Me.cboSAreaCode.DisplayMemberLength = Nothing
        Me.cboSAreaCode.DisplayMemberList = ""
        Me.cboSAreaCode.DisplayMemberText = Nothing
        Me.cboSAreaCode.DisplayMemberText2 = Nothing
        Me.cboSAreaCode.DisplayMemberText3 = Nothing
        Me.cboSAreaCode.DisplayShowButton = False
        Me.cboSAreaCode.DropDownList = False
        Me.cboSAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSAreaCode.ForeColor = System.Drawing.Color.Black
        Me.cboSAreaCode.IsTextBox = False
        Me.cboSAreaCode.LinkCheck = Nothing
        Me.cboSAreaCode.LinkCheckedBox = Nothing
        Me.cboSAreaCode.LinkTextBox = Nothing
        Me.cboSAreaCode.LinkTextBox2 = Nothing
        Me.cboSAreaCode.LinkTextBox3 = Nothing
        Me.cboSAreaCode.Location = New System.Drawing.Point(474, 31)
        Me.cboSAreaCode.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSAreaCode.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSAreaCode.MaxLength = 32767
        Me.cboSAreaCode.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSAreaCode.Name = "cboSAreaCode"
        Me.cboSAreaCode.NotNull = False
        Me.cboSAreaCode.RefreshWidth = False
        Me.cboSAreaCode.RowFilter = ""
        Me.cboSAreaCode.SelectedIndex = -1
        Me.cboSAreaCode.SelectedValue = Nothing
        Me.cboSAreaCode.Size = New System.Drawing.Size(172, 23)
        Me.cboSAreaCode.TabIndex = 3
        Me.cboSAreaCode.ValueMember = ""
        '
        'chkSAreaCode
        '
        Me.chkSAreaCode.AutoSize = True
        Me.chkSAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSAreaCode.Location = New System.Drawing.Point(373, 32)
        Me.chkSAreaCode.Name = "chkSAreaCode"
        Me.chkSAreaCode.Size = New System.Drawing.Size(94, 21)
        Me.chkSAreaCode.TabIndex = 2
        Me.chkSAreaCode.Text = "Area Code"
        Me.chkSAreaCode.UseVisualStyleBackColor = True
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 191)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1267, 295)
        Me.grpData.TabIndex = 2
        Me.grpData.TabStop = False
        Me.grpData.Text = "Search Result"
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'chkSActiveFlag
        '
        Me.chkSActiveFlag.AutoSize = True
        Me.chkSActiveFlag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSActiveFlag.Location = New System.Drawing.Point(373, 88)
        Me.chkSActiveFlag.Name = "chkSActiveFlag"
        Me.chkSActiveFlag.Size = New System.Drawing.Size(98, 21)
        Me.chkSActiveFlag.TabIndex = 10
        Me.chkSActiveFlag.Text = "Active Only"
        Me.chkSActiveFlag.UseVisualStyleBackColor = True
        '
        'chkActiveFlag
        '
        Me.chkActiveFlag.AutoSize = True
        Me.chkActiveFlag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkActiveFlag.Location = New System.Drawing.Point(554, 123)
        Me.chkActiveFlag.Name = "chkActiveFlag"
        Me.chkActiveFlag.Size = New System.Drawing.Size(65, 21)
        Me.chkActiveFlag.TabIndex = 12
        Me.chkActiveFlag.Text = "Active"
        Me.chkActiveFlag.UseVisualStyleBackColor = True
        '
        'clsVMstPart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 696)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpUpdateData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVMstPart"
        Me.Text = "Master Part"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUpdateData.ResumeLayout(False)
        Me.grpUpdateData.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        Me.grpData.ResumeLayout(False)
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnLogo As System.Windows.Forms.ToolStripButton
    Friend WithEvents grpUpdateData As OPE_Controls.OpeGroupBox
    Friend WithEvents cboAreaCode As OPE_Controls.OpeComboBox2
    Friend WithEvents lblAreaCode As OPE_Controls.OpeLabel
    Friend WithEvents txtPartNo As OPE_Controls.OpeTextBox
    Friend WithEvents lblPartNo As OPE_Controls.OpeLabel
    Friend WithEvents lblVariant As OPE_Controls.OpeLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents chkSPartNo As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSVariant As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSVariant As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSAreaCode As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSAreaCode As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSPartType As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSPartType As OPE_Controls.OpeCheckBox
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents cboPartType As OPE_Controls.OpeComboBox2
    Friend WithEvents lblPartType As OPE_Controls.OpeLabel
    Friend WithEvents txtVariant As OPE_Controls.OpeTextBox
    Friend WithEvents cboSPartNo As OPE_Controls.OpeComboBox2
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents chkCaliperFlag As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSCaliper As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSCaliper As OPE_Controls.OpeCheckBox
    Friend WithEvents cboModelDock As OPE_Controls.OpeComboBox2
    Friend WithEvents lblModelDock As OPE_Controls.OpeLabel
    Friend WithEvents chkSActiveFlag As OPE_Controls.OpeCheckBox
    Friend WithEvents chkActiveFlag As OPE_Controls.OpeCheckBox
End Class
