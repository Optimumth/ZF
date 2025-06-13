<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVMstQR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVMstQR))
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.grdData = New OPE_Controls.opeDataGrid()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New OPE_Controls.OpeButtonSave()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New OPE_Controls.OpeButtonNew()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New OPE_Controls.OpeButtonDeleteDoc()
        Me.btnLogo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCheckAll = New OPE_Controls.OpeButtonStrip()
        Me.btnReleaseAll = New OPE_Controls.OpeButtonStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New OPE_Controls.OpeButtonPrint()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.cboSValue = New OPE_Controls.OpeComboBox2()
        Me.chkSValue = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSHeader = New OPE_Controls.OpeComboBox2()
        Me.chkSHeader = New OPE_Controls.OpeCheckBox(Me.components)
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblHeader = New OPE_Controls.OpeLabel(Me.components)
        Me.lblValue = New OPE_Controls.OpeLabel(Me.components)
        Me.txtValue = New OPE_Controls.OpeTextBox()
        Me.grpUpdateData = New OPE_Controls.OpeGroupBox()
        Me.cboHeader = New OPE_Controls.OpeComboBox2()
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
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.ToolStripSeparator1, Me.btnSave, Me.ToolStripSeparator2, Me.btnNew, Me.ToolStripSeparator3, Me.btnDelete, Me.btnLogo, Me.ToolStripSeparator4, Me.btnCheckAll, Me.btnReleaseAll, Me.ToolStripSeparator5, Me.btnPrint})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(1070, 57)
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
        Me.grdData.Size = New System.Drawing.Size(1054, 191)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 57)
        '
        'btnCheckAll
        '
        Me.btnCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCheckAll.Image = CType(resources.GetObject("btnCheckAll.Image"), System.Drawing.Image)
        Me.btnCheckAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(36, 54)
        Me.btnCheckAll.Text = "Select All"
        '
        'btnReleaseAll
        '
        Me.btnReleaseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReleaseAll.Image = CType(resources.GetObject("btnReleaseAll.Image"), System.Drawing.Image)
        Me.btnReleaseAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReleaseAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReleaseAll.Name = "btnReleaseAll"
        Me.btnReleaseAll.Size = New System.Drawing.Size(36, 54)
        Me.btnReleaseAll.Text = "Release All"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 57)
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.EnableOnly = False
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(36, 54)
        Me.btnPrint.Text = "Print"
        Me.btnPrint.ToolTipText = "Print"
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.cboSValue)
        Me.grpSearchCondition.Controls.Add(Me.chkSValue)
        Me.grpSearchCondition.Controls.Add(Me.cboSHeader)
        Me.grpSearchCondition.Controls.Add(Me.chkSHeader)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 57)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(1070, 69)
        Me.grpSearchCondition.TabIndex = 1
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'cboSValue
        '
        Me.cboSValue.BackColor = System.Drawing.Color.White
        Me.cboSValue.Busy = True
        Me.cboSValue.DataSource = Nothing
        Me.cboSValue.DisplayMember = ""
        Me.cboSValue.DisplayMemberLength = Nothing
        Me.cboSValue.DisplayMemberList = ""
        Me.cboSValue.DisplayMemberText = Nothing
        Me.cboSValue.DisplayMemberText2 = Nothing
        Me.cboSValue.DisplayMemberText3 = Nothing
        Me.cboSValue.DisplayShowButton = False
        Me.cboSValue.DropDownList = False
        Me.cboSValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSValue.ForeColor = System.Drawing.Color.Black
        Me.cboSValue.IsTextBox = False
        Me.cboSValue.LinkCheck = Nothing
        Me.cboSValue.LinkCheckedBox = Nothing
        Me.cboSValue.LinkTextBox = Nothing
        Me.cboSValue.LinkTextBox2 = Nothing
        Me.cboSValue.LinkTextBox3 = Nothing
        Me.cboSValue.Location = New System.Drawing.Point(461, 25)
        Me.cboSValue.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSValue.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSValue.MaxLength = 32767
        Me.cboSValue.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSValue.Name = "cboSValue"
        Me.cboSValue.NotNull = False
        Me.cboSValue.RefreshWidth = False
        Me.cboSValue.RowFilter = ""
        Me.cboSValue.SelectedIndex = -1
        Me.cboSValue.SelectedValue = Nothing
        Me.cboSValue.Size = New System.Drawing.Size(182, 23)
        Me.cboSValue.TabIndex = 13
        Me.cboSValue.ValueMember = ""
        '
        'chkSValue
        '
        Me.chkSValue.AutoSize = True
        Me.chkSValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSValue.Location = New System.Drawing.Point(378, 26)
        Me.chkSValue.Name = "chkSValue"
        Me.chkSValue.Size = New System.Drawing.Size(63, 21)
        Me.chkSValue.TabIndex = 12
        Me.chkSValue.Text = "Value"
        Me.chkSValue.UseVisualStyleBackColor = True
        '
        'cboSHeader
        '
        Me.cboSHeader.BackColor = System.Drawing.Color.White
        Me.cboSHeader.Busy = True
        Me.cboSHeader.DataSource = Nothing
        Me.cboSHeader.DisplayMember = ""
        Me.cboSHeader.DisplayMemberLength = Nothing
        Me.cboSHeader.DisplayMemberList = ""
        Me.cboSHeader.DisplayMemberText = Nothing
        Me.cboSHeader.DisplayMemberText2 = Nothing
        Me.cboSHeader.DisplayMemberText3 = Nothing
        Me.cboSHeader.DisplayShowButton = False
        Me.cboSHeader.DropDownList = False
        Me.cboSHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSHeader.ForeColor = System.Drawing.Color.Black
        Me.cboSHeader.IsTextBox = False
        Me.cboSHeader.LinkCheck = Nothing
        Me.cboSHeader.LinkCheckedBox = Nothing
        Me.cboSHeader.LinkTextBox = Nothing
        Me.cboSHeader.LinkTextBox2 = Nothing
        Me.cboSHeader.LinkTextBox3 = Nothing
        Me.cboSHeader.Location = New System.Drawing.Point(115, 25)
        Me.cboSHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSHeader.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSHeader.MaxLength = 32767
        Me.cboSHeader.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSHeader.Name = "cboSHeader"
        Me.cboSHeader.NotNull = False
        Me.cboSHeader.RefreshWidth = False
        Me.cboSHeader.RowFilter = ""
        Me.cboSHeader.SelectedIndex = -1
        Me.cboSHeader.SelectedValue = Nothing
        Me.cboSHeader.Size = New System.Drawing.Size(182, 23)
        Me.cboSHeader.TabIndex = 9
        Me.cboSHeader.ValueMember = ""
        '
        'chkSHeader
        '
        Me.chkSHeader.AutoSize = True
        Me.chkSHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSHeader.Location = New System.Drawing.Point(31, 26)
        Me.chkSHeader.Name = "chkSHeader"
        Me.chkSHeader.Size = New System.Drawing.Size(74, 21)
        Me.chkSHeader.TabIndex = 8
        Me.chkSHeader.Text = "Header"
        Me.chkSHeader.UseVisualStyleBackColor = True
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 126)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1070, 212)
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
        Me.Panel1.TabIndex = 4
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
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblHeader.LabelId = 0
        Me.lblHeader.Location = New System.Drawing.Point(28, 29)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(55, 17)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Header"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblValue.LabelId = 0
        Me.lblValue.Location = New System.Drawing.Point(28, 56)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(44, 17)
        Me.lblValue.TabIndex = 2
        Me.lblValue.Text = "Value"
        '
        'txtValue
        '
        Me.txtValue.Add_Comma = False
        Me.txtValue.BackColor = System.Drawing.Color.MistyRose
        Me.txtValue.DataSource = Nothing
        Me.txtValue.DecimalDigit = 2
        Me.txtValue.DisplayMember = Nothing
        Me.txtValue.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtValue.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtValue.LinkCheckedBox = Nothing
        Me.txtValue.Location = New System.Drawing.Point(93, 53)
        Me.txtValue.MaxValue = 99999.99R
        Me.txtValue.MinValue = -99999.99R
        Me.txtValue.Name = "txtValue"
        Me.txtValue.NotNull = False
        Me.txtValue.ShowDecimal = False
        Me.txtValue.Size = New System.Drawing.Size(736, 23)
        Me.txtValue.TabIndex = 3
        '
        'grpUpdateData
        '
        Me.grpUpdateData.Controls.Add(Me.cboHeader)
        Me.grpUpdateData.Controls.Add(Me.txtValue)
        Me.grpUpdateData.Controls.Add(Me.lblValue)
        Me.grpUpdateData.Controls.Add(Me.lblHeader)
        Me.grpUpdateData.Controls.Add(Me.Panel1)
        Me.grpUpdateData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpUpdateData.Location = New System.Drawing.Point(0, 338)
        Me.grpUpdateData.Name = "grpUpdateData"
        Me.grpUpdateData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpUpdateData.Size = New System.Drawing.Size(1070, 156)
        Me.grpUpdateData.TabIndex = 3
        Me.grpUpdateData.TabStop = False
        Me.grpUpdateData.Visible = False
        '
        'cboHeader
        '
        Me.cboHeader.BackColor = System.Drawing.Color.MistyRose
        Me.cboHeader.Busy = True
        Me.cboHeader.DataSource = Nothing
        Me.cboHeader.DisplayMember = ""
        Me.cboHeader.DisplayMemberLength = Nothing
        Me.cboHeader.DisplayMemberList = ""
        Me.cboHeader.DisplayMemberText = Nothing
        Me.cboHeader.DisplayMemberText2 = Nothing
        Me.cboHeader.DisplayMemberText3 = Nothing
        Me.cboHeader.DisplayShowButton = False
        Me.cboHeader.DropDownList = False
        Me.cboHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboHeader.ForeColor = System.Drawing.Color.Black
        Me.cboHeader.IsTextBox = False
        Me.cboHeader.LinkCheck = Nothing
        Me.cboHeader.LinkCheckedBox = Nothing
        Me.cboHeader.LinkTextBox = Nothing
        Me.cboHeader.LinkTextBox2 = Nothing
        Me.cboHeader.LinkTextBox3 = Nothing
        Me.cboHeader.Location = New System.Drawing.Point(93, 26)
        Me.cboHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.cboHeader.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboHeader.MaxLength = 32767
        Me.cboHeader.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboHeader.Name = "cboHeader"
        Me.cboHeader.NotNull = False
        Me.cboHeader.RefreshWidth = False
        Me.cboHeader.RowFilter = ""
        Me.cboHeader.SelectedIndex = -1
        Me.cboHeader.SelectedValue = Nothing
        Me.cboHeader.Size = New System.Drawing.Size(313, 23)
        Me.cboHeader.TabIndex = 1
        Me.cboHeader.ValueMember = ""
        '
        'clsVMstQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 516)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpUpdateData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Controls.Add(Me.StatusBox)
        Me.Name = "clsVMstQR"
        Me.Text = "Master QR"
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
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As OPE_Controls.OpeButtonDeleteDoc
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents btnSave As OPE_Controls.OpeButtonSave
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents grpUpdateData As OPE_Controls.OpeGroupBox
    Friend WithEvents txtValue As OPE_Controls.OpeTextBox
    Friend WithEvents lblValue As OPE_Controls.OpeLabel
    Friend WithEvents lblHeader As OPE_Controls.OpeLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboSValue As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSValue As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSHeader As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSHeader As OPE_Controls.OpeCheckBox
    Friend WithEvents btnLogo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrint As OPE_Controls.OpeButtonPrint
    Friend WithEvents btnCheckAll As OPE_Controls.OpeButtonStrip
    Friend WithEvents btnReleaseAll As OPE_Controls.OpeButtonStrip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboHeader As OPE_Controls.OpeComboBox2
End Class
