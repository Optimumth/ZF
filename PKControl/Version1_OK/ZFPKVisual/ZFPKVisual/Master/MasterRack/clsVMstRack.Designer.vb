<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVMstRack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVMstRack))
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.cboSRemark = New OPE_Controls.OpeComboBox2()
        Me.cboSCode = New OPE_Controls.OpeComboBox2()
        Me.cboSModel = New OPE_Controls.OpeComboBox2()
        Me.chkSRemark = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSCode = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSType = New OPE_Controls.OpeComboBox2()
        Me.chkSModel = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSType = New OPE_Controls.OpeCheckBox(Me.components)
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblModel = New OPE_Controls.OpeLabel(Me.components)
        Me.cboType = New OPE_Controls.OpeComboBox2()
        Me.lblType = New OPE_Controls.OpeLabel(Me.components)
        Me.lblCode = New OPE_Controls.OpeLabel(Me.components)
        Me.txtCode = New OPE_Controls.OpeTextBox()
        Me.lblRemark = New OPE_Controls.OpeLabel(Me.components)
        Me.txtRemark = New OPE_Controls.OpeTextBox()
        Me.cboModel = New OPE_Controls.OpeComboBox2()
        Me.lblQty = New OPE_Controls.OpeLabel(Me.components)
        Me.txtQty = New OPE_Controls.OpeTextBox()
        Me.lblRangeNo = New OPE_Controls.OpeLabel(Me.components)
        Me.txtInitialNo = New OPE_Controls.OpeTextBox()
        Me.Label1 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtEndNo = New OPE_Controls.OpeTextBox()
        Me.grpUpdateData = New OPE_Controls.OpeGroupBox()
        Me.OpeLabel2 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtEndRackID = New OPE_Controls.OpeTextBox()
        Me.OpeLabel3 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtInitialRackID = New OPE_Controls.OpeTextBox()
        Me.OpeLabel4 = New OPE_Controls.OpeLabel(Me.components)
        Me.OpeLabel1 = New OPE_Controls.OpeLabel(Me.components)
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchCondition.SuspendLayout()
        Me.grpData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpUpdateData.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 494)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(1070, 22)
        Me.StatusBox.TabIndex = 3
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Me.grdData
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.ToolStripSeparator1, Me.btnSave, Me.ToolStripSeparator2, Me.btnNew, Me.btnEdit, Me.ToolStripSeparator3, Me.btnDelete})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(1070, 39)
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
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
        Me.grdData.Size = New System.Drawing.Size(1054, 198)
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
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.cboSRemark)
        Me.grpSearchCondition.Controls.Add(Me.cboSCode)
        Me.grpSearchCondition.Controls.Add(Me.cboSModel)
        Me.grpSearchCondition.Controls.Add(Me.chkSRemark)
        Me.grpSearchCondition.Controls.Add(Me.chkSCode)
        Me.grpSearchCondition.Controls.Add(Me.cboSType)
        Me.grpSearchCondition.Controls.Add(Me.chkSModel)
        Me.grpSearchCondition.Controls.Add(Me.chkSType)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 39)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(1070, 91)
        Me.grpSearchCondition.TabIndex = 1
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'cboSRemark
        '
        Me.cboSRemark.BackColor = System.Drawing.Color.White
        Me.cboSRemark.Busy = True
        Me.cboSRemark.DataSource = Nothing
        Me.cboSRemark.DisplayMember = ""
        Me.cboSRemark.DisplayMemberLength = Nothing
        Me.cboSRemark.DisplayMemberList = ""
        Me.cboSRemark.DisplayMemberText = Nothing
        Me.cboSRemark.DisplayMemberText2 = Nothing
        Me.cboSRemark.DisplayMemberText3 = Nothing
        Me.cboSRemark.DisplayShowButton = False
        Me.cboSRemark.DropDownList = False
        Me.cboSRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSRemark.ForeColor = System.Drawing.Color.Black
        Me.cboSRemark.IsTextBox = False
        Me.cboSRemark.LinkCheck = Nothing
        Me.cboSRemark.LinkCheckedBox = Nothing
        Me.cboSRemark.LinkTextBox = Nothing
        Me.cboSRemark.LinkTextBox2 = Nothing
        Me.cboSRemark.LinkTextBox3 = Nothing
        Me.cboSRemark.Location = New System.Drawing.Point(461, 54)
        Me.cboSRemark.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSRemark.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSRemark.MaxLength = 32767
        Me.cboSRemark.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSRemark.Name = "cboSRemark"
        Me.cboSRemark.NotNull = False
        Me.cboSRemark.RefreshWidth = False
        Me.cboSRemark.RowFilter = ""
        Me.cboSRemark.SelectedIndex = -1
        Me.cboSRemark.SelectedValue = Nothing
        Me.cboSRemark.Size = New System.Drawing.Size(182, 23)
        Me.cboSRemark.TabIndex = 15
        Me.cboSRemark.ValueMember = ""
        '
        'cboSCode
        '
        Me.cboSCode.BackColor = System.Drawing.Color.White
        Me.cboSCode.Busy = True
        Me.cboSCode.DataSource = Nothing
        Me.cboSCode.DisplayMember = ""
        Me.cboSCode.DisplayMemberLength = Nothing
        Me.cboSCode.DisplayMemberList = ""
        Me.cboSCode.DisplayMemberText = Nothing
        Me.cboSCode.DisplayMemberText2 = Nothing
        Me.cboSCode.DisplayMemberText3 = Nothing
        Me.cboSCode.DisplayShowButton = False
        Me.cboSCode.DropDownList = False
        Me.cboSCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSCode.ForeColor = System.Drawing.Color.Black
        Me.cboSCode.IsTextBox = False
        Me.cboSCode.LinkCheck = Nothing
        Me.cboSCode.LinkCheckedBox = Nothing
        Me.cboSCode.LinkTextBox = Nothing
        Me.cboSCode.LinkTextBox2 = Nothing
        Me.cboSCode.LinkTextBox3 = Nothing
        Me.cboSCode.Location = New System.Drawing.Point(461, 25)
        Me.cboSCode.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSCode.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSCode.MaxLength = 32767
        Me.cboSCode.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSCode.Name = "cboSCode"
        Me.cboSCode.NotNull = False
        Me.cboSCode.RefreshWidth = False
        Me.cboSCode.RowFilter = ""
        Me.cboSCode.SelectedIndex = -1
        Me.cboSCode.SelectedValue = Nothing
        Me.cboSCode.Size = New System.Drawing.Size(182, 23)
        Me.cboSCode.TabIndex = 13
        Me.cboSCode.ValueMember = ""
        '
        'cboSModel
        '
        Me.cboSModel.BackColor = System.Drawing.Color.White
        Me.cboSModel.Busy = True
        Me.cboSModel.DataSource = Nothing
        Me.cboSModel.DisplayMember = ""
        Me.cboSModel.DisplayMemberLength = Nothing
        Me.cboSModel.DisplayMemberList = ""
        Me.cboSModel.DisplayMemberText = Nothing
        Me.cboSModel.DisplayMemberText2 = Nothing
        Me.cboSModel.DisplayMemberText3 = Nothing
        Me.cboSModel.DisplayShowButton = False
        Me.cboSModel.DropDownList = False
        Me.cboSModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSModel.ForeColor = System.Drawing.Color.Black
        Me.cboSModel.IsTextBox = False
        Me.cboSModel.LinkCheck = Nothing
        Me.cboSModel.LinkCheckedBox = Nothing
        Me.cboSModel.LinkTextBox = Nothing
        Me.cboSModel.LinkTextBox2 = Nothing
        Me.cboSModel.LinkTextBox3 = Nothing
        Me.cboSModel.Location = New System.Drawing.Point(115, 54)
        Me.cboSModel.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSModel.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSModel.MaxLength = 32767
        Me.cboSModel.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSModel.Name = "cboSModel"
        Me.cboSModel.NotNull = False
        Me.cboSModel.RefreshWidth = False
        Me.cboSModel.RowFilter = ""
        Me.cboSModel.SelectedIndex = -1
        Me.cboSModel.SelectedValue = Nothing
        Me.cboSModel.Size = New System.Drawing.Size(182, 23)
        Me.cboSModel.TabIndex = 11
        Me.cboSModel.ValueMember = ""
        '
        'chkSRemark
        '
        Me.chkSRemark.AutoSize = True
        Me.chkSRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSRemark.Location = New System.Drawing.Point(377, 55)
        Me.chkSRemark.Name = "chkSRemark"
        Me.chkSRemark.Size = New System.Drawing.Size(76, 21)
        Me.chkSRemark.TabIndex = 14
        Me.chkSRemark.Text = "Remark"
        Me.chkSRemark.UseVisualStyleBackColor = True
        '
        'chkSCode
        '
        Me.chkSCode.AutoSize = True
        Me.chkSCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSCode.Location = New System.Drawing.Point(377, 26)
        Me.chkSCode.Name = "chkSCode"
        Me.chkSCode.Size = New System.Drawing.Size(60, 21)
        Me.chkSCode.TabIndex = 12
        Me.chkSCode.Text = "Code"
        Me.chkSCode.UseVisualStyleBackColor = True
        '
        'cboSType
        '
        Me.cboSType.BackColor = System.Drawing.Color.White
        Me.cboSType.Busy = True
        Me.cboSType.DataSource = Nothing
        Me.cboSType.DisplayMember = ""
        Me.cboSType.DisplayMemberLength = Nothing
        Me.cboSType.DisplayMemberList = ""
        Me.cboSType.DisplayMemberText = Nothing
        Me.cboSType.DisplayMemberText2 = Nothing
        Me.cboSType.DisplayMemberText3 = Nothing
        Me.cboSType.DisplayShowButton = False
        Me.cboSType.DropDownList = False
        Me.cboSType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSType.ForeColor = System.Drawing.Color.Black
        Me.cboSType.IsTextBox = False
        Me.cboSType.LinkCheck = Nothing
        Me.cboSType.LinkCheckedBox = Nothing
        Me.cboSType.LinkTextBox = Nothing
        Me.cboSType.LinkTextBox2 = Nothing
        Me.cboSType.LinkTextBox3 = Nothing
        Me.cboSType.Location = New System.Drawing.Point(115, 25)
        Me.cboSType.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSType.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSType.MaxLength = 32767
        Me.cboSType.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSType.Name = "cboSType"
        Me.cboSType.NotNull = False
        Me.cboSType.RefreshWidth = False
        Me.cboSType.RowFilter = ""
        Me.cboSType.SelectedIndex = -1
        Me.cboSType.SelectedValue = Nothing
        Me.cboSType.Size = New System.Drawing.Size(182, 23)
        Me.cboSType.TabIndex = 9
        Me.cboSType.ValueMember = ""
        '
        'chkSModel
        '
        Me.chkSModel.AutoSize = True
        Me.chkSModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSModel.Location = New System.Drawing.Point(31, 55)
        Me.chkSModel.Name = "chkSModel"
        Me.chkSModel.Size = New System.Drawing.Size(65, 21)
        Me.chkSModel.TabIndex = 10
        Me.chkSModel.Text = "Model"
        Me.chkSModel.UseVisualStyleBackColor = True
        '
        'chkSType
        '
        Me.chkSType.AutoSize = True
        Me.chkSType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSType.Location = New System.Drawing.Point(31, 26)
        Me.chkSType.Name = "chkSType"
        Me.chkSType.Size = New System.Drawing.Size(59, 21)
        Me.chkSType.TabIndex = 8
        Me.chkSType.Text = "Type"
        Me.chkSType.UseVisualStyleBackColor = True
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 130)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1070, 219)
        Me.grpData.TabIndex = 2
        Me.grpData.TabStop = False
        Me.grpData.Text = "Search Result"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(992, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(58, 124)
        Me.Panel1.TabIndex = 17
        Me.Panel1.TabStop = True
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(3, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(41, 40)
        Me.btnOK.TabIndex = 1
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(3, 49)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(41, 40)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblModel.LabelId = 0
        Me.lblModel.Location = New System.Drawing.Point(28, 56)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(46, 17)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model"
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.MistyRose
        Me.cboType.Busy = True
        Me.cboType.DataSource = Nothing
        Me.cboType.DisplayMember = ""
        Me.cboType.DisplayMemberLength = Nothing
        Me.cboType.DisplayMemberList = ""
        Me.cboType.DisplayMemberText = Nothing
        Me.cboType.DisplayMemberText2 = Nothing
        Me.cboType.DisplayMemberText3 = Nothing
        Me.cboType.DisplayShowButton = False
        Me.cboType.DropDownList = False
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboType.ForeColor = System.Drawing.Color.Black
        Me.cboType.IsTextBox = False
        Me.cboType.LinkCheck = Nothing
        Me.cboType.LinkCheckedBox = Nothing
        Me.cboType.LinkTextBox = Nothing
        Me.cboType.LinkTextBox2 = Nothing
        Me.cboType.LinkTextBox3 = Nothing
        Me.cboType.Location = New System.Drawing.Point(93, 26)
        Me.cboType.Margin = New System.Windows.Forms.Padding(0)
        Me.cboType.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboType.MaxLength = 32767
        Me.cboType.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboType.Name = "cboType"
        Me.cboType.NotNull = False
        Me.cboType.RefreshWidth = False
        Me.cboType.RowFilter = ""
        Me.cboType.SelectedIndex = -1
        Me.cboType.SelectedValue = Nothing
        Me.cboType.Size = New System.Drawing.Size(313, 23)
        Me.cboType.TabIndex = 1
        Me.cboType.ValueMember = ""
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblType.LabelId = 0
        Me.lblType.Location = New System.Drawing.Point(28, 29)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(40, 17)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Type"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCode.LabelId = 0
        Me.lblCode.Location = New System.Drawing.Point(28, 83)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(41, 17)
        Me.lblCode.TabIndex = 4
        Me.lblCode.Text = "Code"
        '
        'txtCode
        '
        Me.txtCode.Add_Comma = False
        Me.txtCode.DataSource = Nothing
        Me.txtCode.DecimalDigit = 2
        Me.txtCode.DisplayMember = Nothing
        Me.txtCode.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCode.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtCode.LinkCheckedBox = Nothing
        Me.txtCode.Location = New System.Drawing.Point(93, 80)
        Me.txtCode.MaxValue = 99999.99R
        Me.txtCode.MinValue = -99999.99R
        Me.txtCode.Name = "txtCode"
        Me.txtCode.NotNull = False
        Me.txtCode.ShowDecimal = False
        Me.txtCode.Size = New System.Drawing.Size(313, 23)
        Me.txtCode.TabIndex = 5
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRemark.LabelId = 0
        Me.lblRemark.Location = New System.Drawing.Point(28, 110)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(57, 17)
        Me.lblRemark.TabIndex = 6
        Me.lblRemark.Text = "Remark"
        '
        'txtRemark
        '
        Me.txtRemark.Add_Comma = False
        Me.txtRemark.DataSource = Nothing
        Me.txtRemark.DecimalDigit = 2
        Me.txtRemark.DisplayMember = Nothing
        Me.txtRemark.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRemark.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtRemark.LinkCheckedBox = Nothing
        Me.txtRemark.Location = New System.Drawing.Point(93, 107)
        Me.txtRemark.MaxValue = 99999.99R
        Me.txtRemark.MinValue = -99999.99R
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.NotNull = False
        Me.txtRemark.ShowDecimal = False
        Me.txtRemark.Size = New System.Drawing.Size(313, 23)
        Me.txtRemark.TabIndex = 7
        '
        'cboModel
        '
        Me.cboModel.BackColor = System.Drawing.Color.MistyRose
        Me.cboModel.Busy = True
        Me.cboModel.DataSource = Nothing
        Me.cboModel.DisplayMember = ""
        Me.cboModel.DisplayMemberLength = Nothing
        Me.cboModel.DisplayMemberList = ""
        Me.cboModel.DisplayMemberText = Nothing
        Me.cboModel.DisplayMemberText2 = Nothing
        Me.cboModel.DisplayMemberText3 = Nothing
        Me.cboModel.DisplayShowButton = False
        Me.cboModel.DropDownList = False
        Me.cboModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboModel.ForeColor = System.Drawing.Color.Black
        Me.cboModel.IsTextBox = False
        Me.cboModel.LinkCheck = Nothing
        Me.cboModel.LinkCheckedBox = Nothing
        Me.cboModel.LinkTextBox = Nothing
        Me.cboModel.LinkTextBox2 = Nothing
        Me.cboModel.LinkTextBox3 = Nothing
        Me.cboModel.Location = New System.Drawing.Point(93, 53)
        Me.cboModel.Margin = New System.Windows.Forms.Padding(0)
        Me.cboModel.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboModel.MaxLength = 32767
        Me.cboModel.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboModel.Name = "cboModel"
        Me.cboModel.NotNull = False
        Me.cboModel.RefreshWidth = False
        Me.cboModel.RowFilter = ""
        Me.cboModel.SelectedIndex = -1
        Me.cboModel.SelectedValue = Nothing
        Me.cboModel.Size = New System.Drawing.Size(313, 23)
        Me.cboModel.TabIndex = 3
        Me.cboModel.ValueMember = ""
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblQty.LabelId = 0
        Me.lblQty.Location = New System.Drawing.Point(449, 29)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(30, 17)
        Me.lblQty.TabIndex = 8
        Me.lblQty.Text = "Qty"
        '
        'txtQty
        '
        Me.txtQty.Add_Comma = False
        Me.txtQty.BackColor = System.Drawing.Color.Empty
        Me.txtQty.DataSource = Nothing
        Me.txtQty.DecimalDigit = 0
        Me.txtQty.DisplayMember = Nothing
        Me.txtQty.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtQty.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtQty.LinkCheckedBox = Nothing
        Me.txtQty.Location = New System.Drawing.Point(566, 26)
        Me.txtQty.MaxValue = 99999.99R
        Me.txtQty.MinValue = -99999.99R
        Me.txtQty.Name = "txtQty"
        Me.txtQty.NotNull = False
        Me.txtQty.ReadOnly = True
        Me.txtQty.ShowDecimal = False
        Me.txtQty.Size = New System.Drawing.Size(231, 23)
        Me.txtQty.TabIndex = 9
        Me.txtQty.TabStop = False
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRangeNo
        '
        Me.lblRangeNo.AutoSize = True
        Me.lblRangeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRangeNo.LabelId = 0
        Me.lblRangeNo.Location = New System.Drawing.Point(449, 56)
        Me.lblRangeNo.Name = "lblRangeNo"
        Me.lblRangeNo.Size = New System.Drawing.Size(107, 17)
        Me.lblRangeNo.TabIndex = 10
        Me.lblRangeNo.Text = "Running Range"
        '
        'txtInitialNo
        '
        Me.txtInitialNo.Add_Comma = False
        Me.txtInitialNo.DataSource = Nothing
        Me.txtInitialNo.DecimalDigit = 0
        Me.txtInitialNo.DisplayMember = Nothing
        Me.txtInitialNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtInitialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtInitialNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtInitialNo.LinkCheckedBox = Nothing
        Me.txtInitialNo.Location = New System.Drawing.Point(566, 53)
        Me.txtInitialNo.MaxValue = 99999.99R
        Me.txtInitialNo.MinValue = -99999.99R
        Me.txtInitialNo.Name = "txtInitialNo"
        Me.txtInitialNo.NotNull = False
        Me.txtInitialNo.ShowDecimal = False
        Me.txtInitialNo.Size = New System.Drawing.Size(102, 23)
        Me.txtInitialNo.TabIndex = 11
        Me.txtInitialNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.LabelId = 0
        Me.Label1.Location = New System.Drawing.Point(676, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "-"
        '
        'txtEndNo
        '
        Me.txtEndNo.Add_Comma = False
        Me.txtEndNo.DataSource = Nothing
        Me.txtEndNo.DecimalDigit = 0
        Me.txtEndNo.DisplayMember = Nothing
        Me.txtEndNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtEndNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEndNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtEndNo.LinkCheckedBox = Nothing
        Me.txtEndNo.Location = New System.Drawing.Point(695, 53)
        Me.txtEndNo.MaxValue = 99999.99R
        Me.txtEndNo.MinValue = -99999.99R
        Me.txtEndNo.Name = "txtEndNo"
        Me.txtEndNo.NotNull = False
        Me.txtEndNo.ShowDecimal = False
        Me.txtEndNo.Size = New System.Drawing.Size(102, 23)
        Me.txtEndNo.TabIndex = 13
        Me.txtEndNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpUpdateData
        '
        Me.grpUpdateData.Controls.Add(Me.OpeLabel2)
        Me.grpUpdateData.Controls.Add(Me.txtEndRackID)
        Me.grpUpdateData.Controls.Add(Me.OpeLabel3)
        Me.grpUpdateData.Controls.Add(Me.txtInitialRackID)
        Me.grpUpdateData.Controls.Add(Me.OpeLabel4)
        Me.grpUpdateData.Controls.Add(Me.OpeLabel1)
        Me.grpUpdateData.Controls.Add(Me.txtEndNo)
        Me.grpUpdateData.Controls.Add(Me.Label1)
        Me.grpUpdateData.Controls.Add(Me.txtInitialNo)
        Me.grpUpdateData.Controls.Add(Me.lblRangeNo)
        Me.grpUpdateData.Controls.Add(Me.txtQty)
        Me.grpUpdateData.Controls.Add(Me.lblQty)
        Me.grpUpdateData.Controls.Add(Me.cboModel)
        Me.grpUpdateData.Controls.Add(Me.txtRemark)
        Me.grpUpdateData.Controls.Add(Me.lblRemark)
        Me.grpUpdateData.Controls.Add(Me.txtCode)
        Me.grpUpdateData.Controls.Add(Me.lblCode)
        Me.grpUpdateData.Controls.Add(Me.lblType)
        Me.grpUpdateData.Controls.Add(Me.cboType)
        Me.grpUpdateData.Controls.Add(Me.lblModel)
        Me.grpUpdateData.Controls.Add(Me.Panel1)
        Me.grpUpdateData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpUpdateData.Location = New System.Drawing.Point(0, 349)
        Me.grpUpdateData.Name = "grpUpdateData"
        Me.grpUpdateData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpUpdateData.Size = New System.Drawing.Size(1070, 145)
        Me.grpUpdateData.TabIndex = 3
        Me.grpUpdateData.TabStop = False
        Me.grpUpdateData.Visible = False
        '
        'OpeLabel2
        '
        Me.OpeLabel2.AutoSize = True
        Me.OpeLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.OpeLabel2.LabelId = 0
        Me.OpeLabel2.Location = New System.Drawing.Point(812, 83)
        Me.OpeLabel2.Name = "OpeLabel2"
        Me.OpeLabel2.Size = New System.Drawing.Size(174, 17)
        Me.OpeLabel2.TabIndex = 19
        Me.OpeLabel2.Text = "ZMBF0001, ZMBF0002, ..."
        '
        'txtEndRackID
        '
        Me.txtEndRackID.Add_Comma = False
        Me.txtEndRackID.DataSource = Nothing
        Me.txtEndRackID.DecimalDigit = 0
        Me.txtEndRackID.DisplayMember = Nothing
        Me.txtEndRackID.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtEndRackID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEndRackID.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtEndRackID.LinkCheckedBox = Nothing
        Me.txtEndRackID.Location = New System.Drawing.Point(695, 80)
        Me.txtEndRackID.MaxValue = 99999.99R
        Me.txtEndRackID.MinValue = -99999.99R
        Me.txtEndRackID.Name = "txtEndRackID"
        Me.txtEndRackID.NotNull = False
        Me.txtEndRackID.ShowDecimal = False
        Me.txtEndRackID.Size = New System.Drawing.Size(102, 23)
        Me.txtEndRackID.TabIndex = 18
        Me.txtEndRackID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel3
        '
        Me.OpeLabel3.AutoSize = True
        Me.OpeLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel3.LabelId = 0
        Me.OpeLabel3.Location = New System.Drawing.Point(676, 83)
        Me.OpeLabel3.Name = "OpeLabel3"
        Me.OpeLabel3.Size = New System.Drawing.Size(13, 17)
        Me.OpeLabel3.TabIndex = 17
        Me.OpeLabel3.Text = "-"
        '
        'txtInitialRackID
        '
        Me.txtInitialRackID.Add_Comma = False
        Me.txtInitialRackID.DataSource = Nothing
        Me.txtInitialRackID.DecimalDigit = 0
        Me.txtInitialRackID.DisplayMember = Nothing
        Me.txtInitialRackID.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtInitialRackID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtInitialRackID.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtInitialRackID.LinkCheckedBox = Nothing
        Me.txtInitialRackID.Location = New System.Drawing.Point(566, 80)
        Me.txtInitialRackID.MaxValue = 99999.99R
        Me.txtInitialRackID.MinValue = -99999.99R
        Me.txtInitialRackID.Name = "txtInitialRackID"
        Me.txtInitialRackID.NotNull = False
        Me.txtInitialRackID.ShowDecimal = False
        Me.txtInitialRackID.Size = New System.Drawing.Size(102, 23)
        Me.txtInitialRackID.TabIndex = 16
        Me.txtInitialRackID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel4
        '
        Me.OpeLabel4.AutoSize = True
        Me.OpeLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel4.LabelId = 0
        Me.OpeLabel4.Location = New System.Drawing.Point(449, 83)
        Me.OpeLabel4.Name = "OpeLabel4"
        Me.OpeLabel4.Size = New System.Drawing.Size(103, 17)
        Me.OpeLabel4.TabIndex = 15
        Me.OpeLabel4.Text = "Rack ID Range"
        '
        'OpeLabel1
        '
        Me.OpeLabel1.AutoSize = True
        Me.OpeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.OpeLabel1.LabelId = 0
        Me.OpeLabel1.Location = New System.Drawing.Point(812, 56)
        Me.OpeLabel1.Name = "OpeLabel1"
        Me.OpeLabel1.Size = New System.Drawing.Size(139, 17)
        Me.OpeLabel1.TabIndex = 14
        Me.OpeLabel1.Text = "F001, R001, B001 ..."
        '
        'clsVMstRack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 516)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpUpdateData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Controls.Add(Me.StatusBox)
        Me.Name = "clsVMstRack"
        Me.Text = "Master Rack"
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        Me.grpData.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.grpUpdateData.ResumeLayout(False)
        Me.grpUpdateData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As OPE_Controls.OpeButtonNew
    Friend WithEvents btnEdit As OPE_Controls.OpeButtonEdit
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As OPE_Controls.OpeButtonDeleteDoc
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents btnSave As OPE_Controls.OpeButtonSave
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents grpUpdateData As OPE_Controls.OpeGroupBox
    Friend WithEvents txtEndNo As OPE_Controls.OpeTextBox
    Friend WithEvents Label1 As OPE_Controls.OpeLabel
    Friend WithEvents txtInitialNo As OPE_Controls.OpeTextBox
    Friend WithEvents lblRangeNo As OPE_Controls.OpeLabel
    Friend WithEvents txtQty As OPE_Controls.OpeTextBox
    Friend WithEvents lblQty As OPE_Controls.OpeLabel
    Friend WithEvents cboModel As OPE_Controls.OpeComboBox2
    Friend WithEvents txtRemark As OPE_Controls.OpeTextBox
    Friend WithEvents lblRemark As OPE_Controls.OpeLabel
    Friend WithEvents txtCode As OPE_Controls.OpeTextBox
    Friend WithEvents lblCode As OPE_Controls.OpeLabel
    Friend WithEvents lblType As OPE_Controls.OpeLabel
    Friend WithEvents cboType As OPE_Controls.OpeComboBox2
    Friend WithEvents lblModel As OPE_Controls.OpeLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents OpeLabel1 As OPE_Controls.OpeLabel
    Friend WithEvents cboSRemark As OPE_Controls.OpeComboBox2
    Friend WithEvents cboSCode As OPE_Controls.OpeComboBox2
    Friend WithEvents cboSModel As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSRemark As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSCode As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSType As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSModel As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSType As OPE_Controls.OpeCheckBox
    Friend WithEvents OpeLabel2 As OPE_Controls.OpeLabel
    Friend WithEvents txtEndRackID As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel3 As OPE_Controls.OpeLabel
    Friend WithEvents txtInitialRackID As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel4 As OPE_Controls.OpeLabel
End Class
