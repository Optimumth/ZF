<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVMstDockAudit
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVMstDockAudit))
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
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.grpUpdateData = New OPE_Controls.OpeGroupBox()
        Me.chkCaliperFlag = New OPE_Controls.OpeCheckBox(Me.components)
        Me.grbShock = New OPE_Controls.OpeGroupBox()
        Me.btnFormat7 = New OPE_Controls.OpeButton(Me.components)
        Me.btnFormat6 = New OPE_Controls.OpeButton(Me.components)
        Me.btnFormat5 = New OPE_Controls.OpeButton(Me.components)
        Me.Check5 = New OPE_Controls.OpeCheckBox(Me.components)
        Me.Check6 = New OPE_Controls.OpeCheckBox(Me.components)
        Me.Check7 = New OPE_Controls.OpeCheckBox(Me.components)
        Me.grbAxle = New OPE_Controls.OpeGroupBox()
        Me.btnFormat4 = New OPE_Controls.OpeButton(Me.components)
        Me.btnFormat3 = New OPE_Controls.OpeButton(Me.components)
        Me.btnFormat2 = New OPE_Controls.OpeButton(Me.components)
        Me.btnFormat1 = New OPE_Controls.OpeButton(Me.components)
        Me.Check2 = New OPE_Controls.OpeCheckBox(Me.components)
        Me.Check3 = New OPE_Controls.OpeCheckBox(Me.components)
        Me.Check4 = New OPE_Controls.OpeCheckBox(Me.components)
        Me.Check1 = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboAreaCode = New OPE_Controls.OpeComboBox2()
        Me.lblAreaCode = New OPE_Controls.OpeLabel(Me.components)
        Me.cboModel = New OPE_Controls.OpeComboBox2()
        Me.txtRackAmount = New OPE_Controls.OpeTextBox()
        Me.lblRackAmount = New OPE_Controls.OpeLabel(Me.components)
        Me.txtModelDockAudit = New OPE_Controls.OpeTextBox()
        Me.lblModelDock = New OPE_Controls.OpeLabel(Me.components)
        Me.lblModel = New OPE_Controls.OpeLabel(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.cboSModelDock = New OPE_Controls.OpeComboBox2()
        Me.cboSCaliper = New OPE_Controls.OpeComboBox2()
        Me.chkSCaliper = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSModelDock = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSModel = New OPE_Controls.OpeComboBox2()
        Me.chkSModel = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSAreaCode = New OPE_Controls.OpeComboBox2()
        Me.chkSAreaCode = New OPE_Controls.OpeCheckBox(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpData.SuspendLayout()
        Me.grpUpdateData.SuspendLayout()
        Me.grbShock.SuspendLayout()
        Me.grbAxle.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpSearchCondition.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 808)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(1223, 22)
        Me.StatusBox.TabIndex = 6
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
        Me.ButtonBoxH.Size = New System.Drawing.Size(1223, 57)
        Me.ButtonBoxH.StatusBox = Me.StatusBox
        Me.ButtonBoxH.TabIndex = 0
        Me.ButtonBoxH.Text = "OpeButtonBox1"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightCyan
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.grdData.AutoGenerateRecordNo = False
        Me.grdData.ChangeEnterToTab = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle11
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.EnableHeadersVisualStyles = False
        Me.grdData.IsStatus = False
        Me.grdData.Location = New System.Drawing.Point(6, 15)
        Me.grdData.Name = "grdData"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(1207, 382)
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
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 162)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1223, 403)
        Me.grpData.TabIndex = 2
        Me.grpData.TabStop = False
        Me.grpData.Text = "Search Result"
        '
        'grpUpdateData
        '
        Me.grpUpdateData.Controls.Add(Me.chkCaliperFlag)
        Me.grpUpdateData.Controls.Add(Me.grbShock)
        Me.grpUpdateData.Controls.Add(Me.grbAxle)
        Me.grpUpdateData.Controls.Add(Me.cboAreaCode)
        Me.grpUpdateData.Controls.Add(Me.lblAreaCode)
        Me.grpUpdateData.Controls.Add(Me.cboModel)
        Me.grpUpdateData.Controls.Add(Me.txtRackAmount)
        Me.grpUpdateData.Controls.Add(Me.lblRackAmount)
        Me.grpUpdateData.Controls.Add(Me.txtModelDockAudit)
        Me.grpUpdateData.Controls.Add(Me.lblModelDock)
        Me.grpUpdateData.Controls.Add(Me.lblModel)
        Me.grpUpdateData.Controls.Add(Me.Panel1)
        Me.grpUpdateData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpUpdateData.Location = New System.Drawing.Point(0, 565)
        Me.grpUpdateData.Name = "grpUpdateData"
        Me.grpUpdateData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpUpdateData.Size = New System.Drawing.Size(1223, 243)
        Me.grpUpdateData.TabIndex = 3
        Me.grpUpdateData.TabStop = False
        '
        'chkCaliperFlag
        '
        Me.chkCaliperFlag.AutoSize = True
        Me.chkCaliperFlag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkCaliperFlag.Location = New System.Drawing.Point(919, 34)
        Me.chkCaliperFlag.Name = "chkCaliperFlag"
        Me.chkCaliperFlag.Size = New System.Drawing.Size(103, 21)
        Me.chkCaliperFlag.TabIndex = 6
        Me.chkCaliperFlag.Text = "With Caliper"
        Me.chkCaliperFlag.UseVisualStyleBackColor = True
        '
        'grbShock
        '
        Me.grbShock.Controls.Add(Me.btnFormat7)
        Me.grbShock.Controls.Add(Me.btnFormat6)
        Me.grbShock.Controls.Add(Me.btnFormat5)
        Me.grbShock.Controls.Add(Me.Check5)
        Me.grbShock.Controls.Add(Me.Check6)
        Me.grbShock.Controls.Add(Me.Check7)
        Me.grbShock.Location = New System.Drawing.Point(37, 147)
        Me.grbShock.Name = "grbShock"
        Me.grbShock.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grbShock.Size = New System.Drawing.Size(937, 66)
        Me.grbShock.TabIndex = 8
        Me.grbShock.TabStop = False
        Me.grbShock.Text = "Shock"
        '
        'btnFormat7
        '
        Me.btnFormat7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnFormat7.Location = New System.Drawing.Point(457, 16)
        Me.btnFormat7.Name = "btnFormat7"
        Me.btnFormat7.Size = New System.Drawing.Size(35, 36)
        Me.btnFormat7.TabIndex = 19
        Me.btnFormat7.Text = "0"
        Me.btnFormat7.UseVisualStyleBackColor = True
        '
        'btnFormat6
        '
        Me.btnFormat6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnFormat6.Location = New System.Drawing.Point(283, 16)
        Me.btnFormat6.Name = "btnFormat6"
        Me.btnFormat6.Size = New System.Drawing.Size(35, 36)
        Me.btnFormat6.TabIndex = 18
        Me.btnFormat6.Text = "0"
        Me.btnFormat6.UseVisualStyleBackColor = True
        '
        'btnFormat5
        '
        Me.btnFormat5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnFormat5.Location = New System.Drawing.Point(106, 16)
        Me.btnFormat5.Name = "btnFormat5"
        Me.btnFormat5.Size = New System.Drawing.Size(35, 36)
        Me.btnFormat5.TabIndex = 17
        Me.btnFormat5.Text = "0"
        Me.btnFormat5.UseVisualStyleBackColor = True
        '
        'Check5
        '
        Me.Check5.AutoSize = True
        Me.Check5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Check5.Location = New System.Drawing.Point(21, 24)
        Me.Check5.Name = "Check5"
        Me.Check5.Size = New System.Drawing.Size(78, 21)
        Me.Check5.TabIndex = 0
        Me.Check5.Text = "Check 5"
        Me.Check5.UseVisualStyleBackColor = True
        '
        'Check6
        '
        Me.Check6.AutoSize = True
        Me.Check6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Check6.Location = New System.Drawing.Point(198, 24)
        Me.Check6.Name = "Check6"
        Me.Check6.Size = New System.Drawing.Size(78, 21)
        Me.Check6.TabIndex = 1
        Me.Check6.Text = "Check 6"
        Me.Check6.UseVisualStyleBackColor = True
        '
        'Check7
        '
        Me.Check7.AutoSize = True
        Me.Check7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Check7.Location = New System.Drawing.Point(372, 24)
        Me.Check7.Name = "Check7"
        Me.Check7.Size = New System.Drawing.Size(78, 21)
        Me.Check7.TabIndex = 2
        Me.Check7.Text = "Check 7"
        Me.Check7.UseVisualStyleBackColor = True
        '
        'grbAxle
        '
        Me.grbAxle.Controls.Add(Me.btnFormat4)
        Me.grbAxle.Controls.Add(Me.btnFormat3)
        Me.grbAxle.Controls.Add(Me.btnFormat2)
        Me.grbAxle.Controls.Add(Me.btnFormat1)
        Me.grbAxle.Controls.Add(Me.Check2)
        Me.grbAxle.Controls.Add(Me.Check3)
        Me.grbAxle.Controls.Add(Me.Check4)
        Me.grbAxle.Controls.Add(Me.Check1)
        Me.grbAxle.Location = New System.Drawing.Point(37, 73)
        Me.grbAxle.Name = "grbAxle"
        Me.grbAxle.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grbAxle.Size = New System.Drawing.Size(937, 68)
        Me.grbAxle.TabIndex = 7
        Me.grbAxle.TabStop = False
        Me.grbAxle.Text = "Axle"
        '
        'btnFormat4
        '
        Me.btnFormat4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnFormat4.Location = New System.Drawing.Point(643, 16)
        Me.btnFormat4.Name = "btnFormat4"
        Me.btnFormat4.Size = New System.Drawing.Size(35, 36)
        Me.btnFormat4.TabIndex = 17
        Me.btnFormat4.Text = "0"
        Me.btnFormat4.UseVisualStyleBackColor = True
        '
        'btnFormat3
        '
        Me.btnFormat3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnFormat3.Location = New System.Drawing.Point(457, 16)
        Me.btnFormat3.Name = "btnFormat3"
        Me.btnFormat3.Size = New System.Drawing.Size(35, 36)
        Me.btnFormat3.TabIndex = 16
        Me.btnFormat3.Text = "0"
        Me.btnFormat3.UseVisualStyleBackColor = True
        '
        'btnFormat2
        '
        Me.btnFormat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnFormat2.Location = New System.Drawing.Point(282, 16)
        Me.btnFormat2.Name = "btnFormat2"
        Me.btnFormat2.Size = New System.Drawing.Size(35, 36)
        Me.btnFormat2.TabIndex = 15
        Me.btnFormat2.Text = "0"
        Me.btnFormat2.UseVisualStyleBackColor = True
        '
        'btnFormat1
        '
        Me.btnFormat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnFormat1.Location = New System.Drawing.Point(104, 16)
        Me.btnFormat1.Name = "btnFormat1"
        Me.btnFormat1.Size = New System.Drawing.Size(35, 36)
        Me.btnFormat1.TabIndex = 14
        Me.btnFormat1.Text = "0"
        Me.btnFormat1.UseVisualStyleBackColor = True
        '
        'Check2
        '
        Me.Check2.AutoSize = True
        Me.Check2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Check2.Location = New System.Drawing.Point(201, 24)
        Me.Check2.Name = "Check2"
        Me.Check2.Size = New System.Drawing.Size(78, 21)
        Me.Check2.TabIndex = 1
        Me.Check2.Text = "Check 2"
        Me.Check2.UseVisualStyleBackColor = True
        '
        'Check3
        '
        Me.Check3.AutoSize = True
        Me.Check3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Check3.Location = New System.Drawing.Point(376, 24)
        Me.Check3.Name = "Check3"
        Me.Check3.Size = New System.Drawing.Size(78, 21)
        Me.Check3.TabIndex = 2
        Me.Check3.Text = "Check 3"
        Me.Check3.UseVisualStyleBackColor = True
        '
        'Check4
        '
        Me.Check4.AutoSize = True
        Me.Check4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Check4.Location = New System.Drawing.Point(562, 24)
        Me.Check4.Name = "Check4"
        Me.Check4.Size = New System.Drawing.Size(78, 21)
        Me.Check4.TabIndex = 3
        Me.Check4.Text = "Check 4"
        Me.Check4.UseVisualStyleBackColor = True
        '
        'Check1
        '
        Me.Check1.AutoSize = True
        Me.Check1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Check1.Location = New System.Drawing.Point(23, 24)
        Me.Check1.Name = "Check1"
        Me.Check1.Size = New System.Drawing.Size(78, 21)
        Me.Check1.TabIndex = 0
        Me.Check1.Text = "Check 1"
        Me.Check1.UseVisualStyleBackColor = True
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
        Me.cboAreaCode.Location = New System.Drawing.Point(713, 33)
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
        Me.cboAreaCode.Size = New System.Drawing.Size(185, 23)
        Me.cboAreaCode.TabIndex = 5
        Me.cboAreaCode.ValueMember = ""
        '
        'lblAreaCode
        '
        Me.lblAreaCode.AutoSize = True
        Me.lblAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAreaCode.LabelId = 0
        Me.lblAreaCode.Location = New System.Drawing.Point(635, 36)
        Me.lblAreaCode.Name = "lblAreaCode"
        Me.lblAreaCode.Size = New System.Drawing.Size(75, 17)
        Me.lblAreaCode.TabIndex = 4
        Me.lblAreaCode.Text = "Area Code"
        '
        'cboModel
        '
        Me.cboModel.BackColor = System.Drawing.Color.White
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
        Me.cboModel.Location = New System.Drawing.Point(87, 33)
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
        Me.cboModel.Size = New System.Drawing.Size(185, 23)
        Me.cboModel.TabIndex = 1
        Me.cboModel.ValueMember = ""
        '
        'txtRackAmount
        '
        Me.txtRackAmount.Add_Comma = False
        Me.txtRackAmount.DataSource = Nothing
        Me.txtRackAmount.DecimalDigit = 0
        Me.txtRackAmount.DisplayMember = Nothing
        Me.txtRackAmount.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRackAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRackAmount.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtRackAmount.LinkCheckedBox = Nothing
        Me.txtRackAmount.Location = New System.Drawing.Point(1127, 169)
        Me.txtRackAmount.MaxValue = 99999.99R
        Me.txtRackAmount.MinValue = -99999.99R
        Me.txtRackAmount.Name = "txtRackAmount"
        Me.txtRackAmount.NotNull = False
        Me.txtRackAmount.ShowDecimal = False
        Me.txtRackAmount.Size = New System.Drawing.Size(77, 23)
        Me.txtRackAmount.TabIndex = 7
        Me.txtRackAmount.Visible = False
        '
        'lblRackAmount
        '
        Me.lblRackAmount.AutoSize = True
        Me.lblRackAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRackAmount.LabelId = 0
        Me.lblRackAmount.Location = New System.Drawing.Point(987, 172)
        Me.lblRackAmount.Name = "lblRackAmount"
        Me.lblRackAmount.Size = New System.Drawing.Size(142, 17)
        Me.lblRackAmount.TabIndex = 6
        Me.lblRackAmount.Text = "Rack Amount (ไม่โชว์)"
        Me.lblRackAmount.Visible = False
        '
        'txtModelDockAudit
        '
        Me.txtModelDockAudit.Add_Comma = False
        Me.txtModelDockAudit.DataSource = Nothing
        Me.txtModelDockAudit.DecimalDigit = 2
        Me.txtModelDockAudit.DisplayMember = Nothing
        Me.txtModelDockAudit.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtModelDockAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtModelDockAudit.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtModelDockAudit.LinkCheckedBox = Nothing
        Me.txtModelDockAudit.Location = New System.Drawing.Point(423, 33)
        Me.txtModelDockAudit.MaxValue = 99999.99R
        Me.txtModelDockAudit.MinValue = -99999.99R
        Me.txtModelDockAudit.Name = "txtModelDockAudit"
        Me.txtModelDockAudit.NotNull = False
        Me.txtModelDockAudit.ShowDecimal = False
        Me.txtModelDockAudit.Size = New System.Drawing.Size(185, 23)
        Me.txtModelDockAudit.TabIndex = 3
        '
        'lblModelDock
        '
        Me.lblModelDock.AutoSize = True
        Me.lblModelDock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblModelDock.LabelId = 0
        Me.lblModelDock.Location = New System.Drawing.Point(288, 36)
        Me.lblModelDock.Name = "lblModelDock"
        Me.lblModelDock.Size = New System.Drawing.Size(128, 17)
        Me.lblModelDock.TabIndex = 2
        Me.lblModelDock.Text = "Model (Dock Audit)"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblModel.LabelId = 0
        Me.lblModel.Location = New System.Drawing.Point(34, 36)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(46, 17)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Model"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(1153, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(50, 98)
        Me.Panel1.TabIndex = 9
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
        Me.grpSearchCondition.Controls.Add(Me.cboSModelDock)
        Me.grpSearchCondition.Controls.Add(Me.cboSCaliper)
        Me.grpSearchCondition.Controls.Add(Me.chkSCaliper)
        Me.grpSearchCondition.Controls.Add(Me.chkSModelDock)
        Me.grpSearchCondition.Controls.Add(Me.cboSModel)
        Me.grpSearchCondition.Controls.Add(Me.chkSModel)
        Me.grpSearchCondition.Controls.Add(Me.cboSAreaCode)
        Me.grpSearchCondition.Controls.Add(Me.chkSAreaCode)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 57)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(1223, 105)
        Me.grpSearchCondition.TabIndex = 1
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
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
        Me.cboSModelDock.Location = New System.Drawing.Point(544, 31)
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
        Me.cboSModelDock.Size = New System.Drawing.Size(207, 23)
        Me.cboSModelDock.TabIndex = 3
        Me.cboSModelDock.ValueMember = ""
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
        Me.cboSCaliper.Location = New System.Drawing.Point(148, 65)
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
        Me.cboSCaliper.Size = New System.Drawing.Size(207, 23)
        Me.cboSCaliper.TabIndex = 7
        Me.cboSCaliper.ValueMember = ""
        '
        'chkSCaliper
        '
        Me.chkSCaliper.AutoSize = True
        Me.chkSCaliper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSCaliper.Location = New System.Drawing.Point(34, 66)
        Me.chkSCaliper.Name = "chkSCaliper"
        Me.chkSCaliper.Size = New System.Drawing.Size(101, 21)
        Me.chkSCaliper.TabIndex = 6
        Me.chkSCaliper.Text = "With caliper"
        Me.chkSCaliper.UseVisualStyleBackColor = True
        '
        'chkSModelDock
        '
        Me.chkSModelDock.AutoSize = True
        Me.chkSModelDock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSModelDock.Location = New System.Drawing.Point(390, 32)
        Me.chkSModelDock.Name = "chkSModelDock"
        Me.chkSModelDock.Size = New System.Drawing.Size(147, 21)
        Me.chkSModelDock.TabIndex = 2
        Me.chkSModelDock.Text = "Model (Dock Audit)"
        Me.chkSModelDock.UseVisualStyleBackColor = True
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
        Me.cboSModel.Location = New System.Drawing.Point(148, 31)
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
        Me.cboSModel.Size = New System.Drawing.Size(207, 23)
        Me.cboSModel.TabIndex = 1
        Me.cboSModel.ValueMember = ""
        '
        'chkSModel
        '
        Me.chkSModel.AutoSize = True
        Me.chkSModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSModel.Location = New System.Drawing.Point(34, 32)
        Me.chkSModel.Name = "chkSModel"
        Me.chkSModel.Size = New System.Drawing.Size(111, 21)
        Me.chkSModel.TabIndex = 0
        Me.chkSModel.Text = "Model (Rack)"
        Me.chkSModel.UseVisualStyleBackColor = True
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
        Me.cboSAreaCode.Location = New System.Drawing.Point(922, 31)
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
        Me.cboSAreaCode.Size = New System.Drawing.Size(207, 23)
        Me.cboSAreaCode.TabIndex = 5
        Me.cboSAreaCode.ValueMember = ""
        '
        'chkSAreaCode
        '
        Me.chkSAreaCode.AutoSize = True
        Me.chkSAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSAreaCode.Location = New System.Drawing.Point(808, 32)
        Me.chkSAreaCode.Name = "chkSAreaCode"
        Me.chkSAreaCode.Size = New System.Drawing.Size(94, 21)
        Me.chkSAreaCode.TabIndex = 4
        Me.chkSAreaCode.Text = "Area Code"
        Me.chkSAreaCode.UseVisualStyleBackColor = True
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'clsVMstDockAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 830)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpUpdateData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVMstDockAudit"
        Me.Text = "Master Dock Audit"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpData.ResumeLayout(False)
        Me.grpUpdateData.ResumeLayout(False)
        Me.grpUpdateData.PerformLayout()
        Me.grbShock.ResumeLayout(False)
        Me.grbShock.PerformLayout()
        Me.grbAxle.ResumeLayout(False)
        Me.grbAxle.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
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
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents grpUpdateData As OPE_Controls.OpeGroupBox
    Friend WithEvents txtModelDockAudit As OPE_Controls.OpeTextBox
    Friend WithEvents lblModelDock As OPE_Controls.OpeLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents cboSModel As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSModel As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSAreaCode As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSAreaCode As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSModelDock As OPE_Controls.OpeCheckBox
    Friend WithEvents cboModel As OPE_Controls.OpeComboBox2
    Friend WithEvents txtRackAmount As OPE_Controls.OpeTextBox
    Friend WithEvents lblRackAmount As OPE_Controls.OpeLabel
    Friend WithEvents lblModel As OPE_Controls.OpeLabel
    Friend WithEvents cboAreaCode As OPE_Controls.OpeComboBox2
    Friend WithEvents lblAreaCode As OPE_Controls.OpeLabel
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents grbShock As OPE_Controls.OpeGroupBox
    Friend WithEvents Check5 As OPE_Controls.OpeCheckBox
    Friend WithEvents Check6 As OPE_Controls.OpeCheckBox
    Friend WithEvents Check7 As OPE_Controls.OpeCheckBox
    Friend WithEvents grbAxle As OPE_Controls.OpeGroupBox
    Friend WithEvents Check2 As OPE_Controls.OpeCheckBox
    Friend WithEvents Check3 As OPE_Controls.OpeCheckBox
    Friend WithEvents Check4 As OPE_Controls.OpeCheckBox
    Friend WithEvents Check1 As OPE_Controls.OpeCheckBox
    Friend WithEvents btnFormat7 As OPE_Controls.OpeButton
    Friend WithEvents btnFormat6 As OPE_Controls.OpeButton
    Friend WithEvents btnFormat5 As OPE_Controls.OpeButton
    Friend WithEvents btnFormat4 As OPE_Controls.OpeButton
    Friend WithEvents btnFormat3 As OPE_Controls.OpeButton
    Friend WithEvents btnFormat2 As OPE_Controls.OpeButton
    Friend WithEvents btnFormat1 As OPE_Controls.OpeButton
    Friend WithEvents chkCaliperFlag As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSCaliper As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSCaliper As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSModelDock As OPE_Controls.OpeComboBox2
End Class
