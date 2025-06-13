<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVRackStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVRackStatus))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New OPE_Controls.OpeButtonEdit()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSync = New OPE_Controls.OpeButtonStrip()
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grdFront = New OPE_Controls.opeDataGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.txtRear = New OPE_Controls.OpeTextBox()
        Me.OpeLabel2 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtFront = New OPE_Controls.OpeTextBox()
        Me.OpeLabel1 = New OPE_Controls.OpeLabel(Me.components)
        Me.chkSStatus = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSStatus = New OPE_Controls.OpeComboBox2()
        Me.cboSRemark = New OPE_Controls.OpeComboBox2()
        Me.cboSCode = New OPE_Controls.OpeComboBox2()
        Me.cboSModel = New OPE_Controls.OpeComboBox2()
        Me.txtRackQty = New OPE_Controls.OpeTextBox()
        Me.lblRackQty = New OPE_Controls.OpeLabel(Me.components)
        Me.chkSRemark = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSCode = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSType = New OPE_Controls.OpeComboBox2()
        Me.chkSModel = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSType = New OPE_Controls.OpeCheckBox(Me.components)
        Me.grdRear = New OPE_Controls.opeDataGrid()
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpData.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grdFront, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.grpSearchCondition.SuspendLayout()
        CType(Me.grdRear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Nothing
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.ToolStripSeparator1, Me.btnEdit, Me.ToolStripSeparator2, Me.btnSync})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(1051, 39)
        Me.ButtonBoxH.StatusBox = Me.StatusBox
        Me.ButtonBoxH.TabIndex = 4
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
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
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 404)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(1051, 22)
        Me.StatusBox.TabIndex = 5
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.TabControl1)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 180)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1051, 224)
        Me.grpData.TabIndex = 7
        Me.grpData.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(6, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1035, 203)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grdFront)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1027, 177)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Front"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grdFront
        '
        Me.grdFront.AllowUserToAddRows = False
        Me.grdFront.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.grdFront.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.grdFront.AutoGenerateRecordNo = False
        Me.grdFront.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdFront.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.grdFront.ChangeEnterToTab = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdFront.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grdFront.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdFront.ColumnHeadersVisible = False
        Me.grdFront.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFront.EnableHeadersVisualStyles = False
        Me.grdFront.IsStatus = False
        Me.grdFront.Location = New System.Drawing.Point(3, 3)
        Me.grdFront.Name = "grdFront"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdFront.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grdFront.RowHeadersVisible = False
        Me.grdFront.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdFront.Size = New System.Drawing.Size(1021, 171)
        Me.grdFront.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grdRear)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1027, 177)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rear"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.txtRear)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel2)
        Me.grpSearchCondition.Controls.Add(Me.txtFront)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel1)
        Me.grpSearchCondition.Controls.Add(Me.chkSStatus)
        Me.grpSearchCondition.Controls.Add(Me.cboSStatus)
        Me.grpSearchCondition.Controls.Add(Me.cboSRemark)
        Me.grpSearchCondition.Controls.Add(Me.cboSCode)
        Me.grpSearchCondition.Controls.Add(Me.cboSModel)
        Me.grpSearchCondition.Controls.Add(Me.txtRackQty)
        Me.grpSearchCondition.Controls.Add(Me.lblRackQty)
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
        Me.grpSearchCondition.Size = New System.Drawing.Size(1051, 141)
        Me.grpSearchCondition.TabIndex = 6
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'txtRear
        '
        Me.txtRear.Add_Comma = False
        Me.txtRear.BackColor = System.Drawing.Color.Empty
        Me.txtRear.DataSource = Nothing
        Me.txtRear.DecimalDigit = 2
        Me.txtRear.DisplayMember = Nothing
        Me.txtRear.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRear.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtRear.LinkCheckedBox = Nothing
        Me.txtRear.Location = New System.Drawing.Point(680, 101)
        Me.txtRear.MaxValue = 99999.99R
        Me.txtRear.MinValue = -99999.99R
        Me.txtRear.Name = "txtRear"
        Me.txtRear.NotNull = False
        Me.txtRear.ReadOnly = True
        Me.txtRear.ShowDecimal = False
        Me.txtRear.Size = New System.Drawing.Size(167, 29)
        Me.txtRear.TabIndex = 15
        Me.txtRear.TabStop = False
        Me.txtRear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel2
        '
        Me.OpeLabel2.AutoSize = True
        Me.OpeLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpeLabel2.LabelId = 0
        Me.OpeLabel2.Location = New System.Drawing.Point(624, 103)
        Me.OpeLabel2.Name = "OpeLabel2"
        Me.OpeLabel2.Size = New System.Drawing.Size(54, 24)
        Me.OpeLabel2.TabIndex = 14
        Me.OpeLabel2.Text = "Rear"
        '
        'txtFront
        '
        Me.txtFront.Add_Comma = False
        Me.txtFront.BackColor = System.Drawing.Color.Empty
        Me.txtFront.DataSource = Nothing
        Me.txtFront.DecimalDigit = 2
        Me.txtFront.DisplayMember = Nothing
        Me.txtFront.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFront.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtFront.LinkCheckedBox = Nothing
        Me.txtFront.Location = New System.Drawing.Point(405, 101)
        Me.txtFront.MaxValue = 99999.99R
        Me.txtFront.MinValue = -99999.99R
        Me.txtFront.Name = "txtFront"
        Me.txtFront.NotNull = False
        Me.txtFront.ReadOnly = True
        Me.txtFront.ShowDecimal = False
        Me.txtFront.Size = New System.Drawing.Size(167, 29)
        Me.txtFront.TabIndex = 13
        Me.txtFront.TabStop = False
        Me.txtFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel1
        '
        Me.OpeLabel1.AutoSize = True
        Me.OpeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpeLabel1.LabelId = 0
        Me.OpeLabel1.Location = New System.Drawing.Point(337, 103)
        Me.OpeLabel1.Name = "OpeLabel1"
        Me.OpeLabel1.Size = New System.Drawing.Size(59, 24)
        Me.OpeLabel1.TabIndex = 12
        Me.OpeLabel1.Text = "Front"
        '
        'chkSStatus
        '
        Me.chkSStatus.AutoSize = True
        Me.chkSStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSStatus.Location = New System.Drawing.Point(723, 29)
        Me.chkSStatus.Name = "chkSStatus"
        Me.chkSStatus.Size = New System.Drawing.Size(67, 21)
        Me.chkSStatus.TabIndex = 8
        Me.chkSStatus.Text = "Status"
        Me.chkSStatus.UseVisualStyleBackColor = True
        '
        'cboSStatus
        '
        Me.cboSStatus.BackColor = System.Drawing.Color.White
        Me.cboSStatus.Busy = True
        Me.cboSStatus.DataSource = Nothing
        Me.cboSStatus.DisplayMember = ""
        Me.cboSStatus.DisplayMemberLength = Nothing
        Me.cboSStatus.DisplayMemberList = ""
        Me.cboSStatus.DisplayMemberText = Nothing
        Me.cboSStatus.DisplayMemberText2 = Nothing
        Me.cboSStatus.DisplayMemberText3 = Nothing
        Me.cboSStatus.DisplayShowButton = False
        Me.cboSStatus.DropDownList = False
        Me.cboSStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSStatus.ForeColor = System.Drawing.Color.Black
        Me.cboSStatus.IsTextBox = False
        Me.cboSStatus.LinkCheck = Nothing
        Me.cboSStatus.LinkCheckedBox = Nothing
        Me.cboSStatus.LinkTextBox = Nothing
        Me.cboSStatus.LinkTextBox2 = Nothing
        Me.cboSStatus.LinkTextBox3 = Nothing
        Me.cboSStatus.Location = New System.Drawing.Point(807, 28)
        Me.cboSStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSStatus.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSStatus.MaxLength = 32767
        Me.cboSStatus.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSStatus.Name = "cboSStatus"
        Me.cboSStatus.NotNull = False
        Me.cboSStatus.RefreshWidth = False
        Me.cboSStatus.RowFilter = ""
        Me.cboSStatus.SelectedIndex = -1
        Me.cboSStatus.SelectedValue = Nothing
        Me.cboSStatus.Size = New System.Drawing.Size(182, 23)
        Me.cboSStatus.TabIndex = 9
        Me.cboSStatus.ValueMember = ""
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
        Me.cboSRemark.Location = New System.Drawing.Point(461, 57)
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
        Me.cboSRemark.TabIndex = 7
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
        Me.cboSCode.Location = New System.Drawing.Point(461, 28)
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
        Me.cboSCode.TabIndex = 5
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
        Me.cboSModel.Location = New System.Drawing.Point(115, 57)
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
        Me.cboSModel.TabIndex = 3
        Me.cboSModel.ValueMember = ""
        '
        'txtRackQty
        '
        Me.txtRackQty.Add_Comma = False
        Me.txtRackQty.BackColor = System.Drawing.Color.Empty
        Me.txtRackQty.DataSource = Nothing
        Me.txtRackQty.DecimalDigit = 2
        Me.txtRackQty.DisplayMember = Nothing
        Me.txtRackQty.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRackQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRackQty.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtRackQty.LinkCheckedBox = Nothing
        Me.txtRackQty.Location = New System.Drawing.Point(130, 101)
        Me.txtRackQty.MaxValue = 99999.99R
        Me.txtRackQty.MinValue = -99999.99R
        Me.txtRackQty.Name = "txtRackQty"
        Me.txtRackQty.NotNull = False
        Me.txtRackQty.ReadOnly = True
        Me.txtRackQty.ShowDecimal = False
        Me.txtRackQty.Size = New System.Drawing.Size(167, 29)
        Me.txtRackQty.TabIndex = 11
        Me.txtRackQty.TabStop = False
        Me.txtRackQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRackQty
        '
        Me.lblRackQty.AutoSize = True
        Me.lblRackQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRackQty.LabelId = 0
        Me.lblRackQty.Location = New System.Drawing.Point(31, 104)
        Me.lblRackQty.Name = "lblRackQty"
        Me.lblRackQty.Size = New System.Drawing.Size(93, 24)
        Me.lblRackQty.TabIndex = 10
        Me.lblRackQty.Text = "Rack Qty"
        '
        'chkSRemark
        '
        Me.chkSRemark.AutoSize = True
        Me.chkSRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSRemark.Location = New System.Drawing.Point(377, 58)
        Me.chkSRemark.Name = "chkSRemark"
        Me.chkSRemark.Size = New System.Drawing.Size(76, 21)
        Me.chkSRemark.TabIndex = 6
        Me.chkSRemark.Text = "Remark"
        Me.chkSRemark.UseVisualStyleBackColor = True
        '
        'chkSCode
        '
        Me.chkSCode.AutoSize = True
        Me.chkSCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSCode.Location = New System.Drawing.Point(377, 29)
        Me.chkSCode.Name = "chkSCode"
        Me.chkSCode.Size = New System.Drawing.Size(60, 21)
        Me.chkSCode.TabIndex = 4
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
        Me.cboSType.Location = New System.Drawing.Point(115, 28)
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
        Me.cboSType.TabIndex = 1
        Me.cboSType.ValueMember = ""
        '
        'chkSModel
        '
        Me.chkSModel.AutoSize = True
        Me.chkSModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSModel.Location = New System.Drawing.Point(31, 58)
        Me.chkSModel.Name = "chkSModel"
        Me.chkSModel.Size = New System.Drawing.Size(65, 21)
        Me.chkSModel.TabIndex = 2
        Me.chkSModel.Text = "Model"
        Me.chkSModel.UseVisualStyleBackColor = True
        '
        'chkSType
        '
        Me.chkSType.AutoSize = True
        Me.chkSType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSType.Location = New System.Drawing.Point(31, 29)
        Me.chkSType.Name = "chkSType"
        Me.chkSType.Size = New System.Drawing.Size(59, 21)
        Me.chkSType.TabIndex = 0
        Me.chkSType.Text = "Type"
        Me.chkSType.UseVisualStyleBackColor = True
        '
        'grdRear
        '
        Me.grdRear.AllowUserToAddRows = False
        Me.grdRear.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        Me.grdRear.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.grdRear.AutoGenerateRecordNo = False
        Me.grdRear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdRear.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.grdRear.ChangeEnterToTab = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRear.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.grdRear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRear.ColumnHeadersVisible = False
        Me.grdRear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRear.EnableHeadersVisualStyles = False
        Me.grdRear.IsStatus = False
        Me.grdRear.Location = New System.Drawing.Point(3, 3)
        Me.grdRear.Name = "grdRear"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRear.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.grdRear.RowHeadersVisible = False
        Me.grdRear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdRear.Size = New System.Drawing.Size(1021, 171)
        Me.grdRear.TabIndex = 2
        '
        'clsVRackStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 426)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Controls.Add(Me.StatusBox)
        Me.Name = "clsVRackStatus"
        Me.Text = "Rack Status"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpData.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grdFront, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        CType(Me.grdRear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents chkSRemark As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSCode As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSType As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSModel As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSType As OPE_Controls.OpeCheckBox
    Friend WithEvents btnSync As OPE_Controls.OpeButtonStrip
    Friend WithEvents btnEdit As OPE_Controls.OpeButtonEdit
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkSStatus As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSStatus As OPE_Controls.OpeComboBox2
    Friend WithEvents cboSRemark As OPE_Controls.OpeComboBox2
    Friend WithEvents cboSCode As OPE_Controls.OpeComboBox2
    Friend WithEvents cboSModel As OPE_Controls.OpeComboBox2
    Friend WithEvents txtRackQty As OPE_Controls.OpeTextBox
    Friend WithEvents lblRackQty As OPE_Controls.OpeLabel
    Friend WithEvents txtRear As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel2 As OPE_Controls.OpeLabel
    Friend WithEvents txtFront As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel1 As OPE_Controls.OpeLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grdFront As OPE_Controls.opeDataGrid
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grdRear As OPE_Controls.opeDataGrid
End Class
