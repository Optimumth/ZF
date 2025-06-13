<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVMstQC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVMstQC))
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
        Me.btnLogo = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New OPE_Controls.OpeButtonDeleteDoc()
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.grpUpdateData = New OPE_Controls.OpeGroupBox()
        Me.txtRemark = New OPE_Controls.OpeTextBox()
        Me.lblRemark = New OPE_Controls.OpeLabel(Me.components)
        Me.txtDesc3 = New OPE_Controls.OpeTextBox()
        Me.lblDesc3 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtDesc2 = New OPE_Controls.OpeTextBox()
        Me.lblDesc2 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtDesc1 = New OPE_Controls.OpeTextBox()
        Me.lblDesc1 = New OPE_Controls.OpeLabel(Me.components)
        Me.chkRear = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkFront = New OPE_Controls.OpeCheckBox(Me.components)
        Me.txtFormatNo = New OPE_Controls.OpeTextBox()
        Me.lblFormatNo = New OPE_Controls.OpeLabel(Me.components)
        Me.txtCheckNo = New OPE_Controls.OpeTextBox()
        Me.lblCheckNo = New OPE_Controls.OpeLabel(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.cboCheckNo = New OPE_Controls.OpeComboBox2()
        Me.chkSRear = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSCheckNo = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSFront = New OPE_Controls.OpeCheckBox(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chkMTB = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSMTB = New OPE_Controls.OpeComboBox2()
        Me.chkSMTB = New OPE_Controls.OpeCheckBox(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpData.SuspendLayout()
        Me.grpUpdateData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpSearchCondition.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 683)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(1016, 22)
        Me.StatusBox.TabIndex = 6
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Me.grdData
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.ToolStripSeparator1, Me.btnSave, Me.ToolStripSeparator2, Me.btnNew, Me.btnEdit, Me.ToolStripSeparator3, Me.btnLogo, Me.btnDelete})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(1016, 57)
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
        Me.grdData.Size = New System.Drawing.Size(1000, 163)
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
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 132)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1016, 184)
        Me.grpData.TabIndex = 2
        Me.grpData.TabStop = False
        Me.grpData.Text = "Search Result"
        '
        'grpUpdateData
        '
        Me.grpUpdateData.Controls.Add(Me.chkMTB)
        Me.grpUpdateData.Controls.Add(Me.txtRemark)
        Me.grpUpdateData.Controls.Add(Me.lblRemark)
        Me.grpUpdateData.Controls.Add(Me.txtDesc3)
        Me.grpUpdateData.Controls.Add(Me.lblDesc3)
        Me.grpUpdateData.Controls.Add(Me.txtDesc2)
        Me.grpUpdateData.Controls.Add(Me.lblDesc2)
        Me.grpUpdateData.Controls.Add(Me.txtDesc1)
        Me.grpUpdateData.Controls.Add(Me.lblDesc1)
        Me.grpUpdateData.Controls.Add(Me.chkRear)
        Me.grpUpdateData.Controls.Add(Me.chkFront)
        Me.grpUpdateData.Controls.Add(Me.txtFormatNo)
        Me.grpUpdateData.Controls.Add(Me.lblFormatNo)
        Me.grpUpdateData.Controls.Add(Me.txtCheckNo)
        Me.grpUpdateData.Controls.Add(Me.lblCheckNo)
        Me.grpUpdateData.Controls.Add(Me.Panel1)
        Me.grpUpdateData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpUpdateData.Location = New System.Drawing.Point(0, 316)
        Me.grpUpdateData.Name = "grpUpdateData"
        Me.grpUpdateData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpUpdateData.Size = New System.Drawing.Size(1016, 367)
        Me.grpUpdateData.TabIndex = 3
        Me.grpUpdateData.TabStop = False
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
        Me.txtRemark.Location = New System.Drawing.Point(141, 290)
        Me.txtRemark.MaxValue = 99999.99R
        Me.txtRemark.MinValue = -99999.99R
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.NotNull = False
        Me.txtRemark.ShowDecimal = False
        Me.txtRemark.Size = New System.Drawing.Size(725, 62)
        Me.txtRemark.TabIndex = 13
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRemark.LabelId = 0
        Me.lblRemark.Location = New System.Drawing.Point(34, 290)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(57, 17)
        Me.lblRemark.TabIndex = 12
        Me.lblRemark.Text = "Remark"
        '
        'txtDesc3
        '
        Me.txtDesc3.Add_Comma = False
        Me.txtDesc3.DataSource = Nothing
        Me.txtDesc3.DecimalDigit = 2
        Me.txtDesc3.DisplayMember = Nothing
        Me.txtDesc3.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtDesc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDesc3.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtDesc3.LinkCheckedBox = Nothing
        Me.txtDesc3.Location = New System.Drawing.Point(141, 222)
        Me.txtDesc3.MaxValue = 99999.99R
        Me.txtDesc3.MinValue = -99999.99R
        Me.txtDesc3.Multiline = True
        Me.txtDesc3.Name = "txtDesc3"
        Me.txtDesc3.NotNull = False
        Me.txtDesc3.ShowDecimal = False
        Me.txtDesc3.Size = New System.Drawing.Size(725, 62)
        Me.txtDesc3.TabIndex = 11
        '
        'lblDesc3
        '
        Me.lblDesc3.AutoSize = True
        Me.lblDesc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDesc3.LabelId = 0
        Me.lblDesc3.Location = New System.Drawing.Point(34, 222)
        Me.lblDesc3.Name = "lblDesc3"
        Me.lblDesc3.Size = New System.Drawing.Size(91, 17)
        Me.lblDesc3.TabIndex = 10
        Me.lblDesc3.Text = "Description 3"
        '
        'txtDesc2
        '
        Me.txtDesc2.Add_Comma = False
        Me.txtDesc2.DataSource = Nothing
        Me.txtDesc2.DecimalDigit = 2
        Me.txtDesc2.DisplayMember = Nothing
        Me.txtDesc2.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDesc2.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtDesc2.LinkCheckedBox = Nothing
        Me.txtDesc2.Location = New System.Drawing.Point(141, 154)
        Me.txtDesc2.MaxValue = 99999.99R
        Me.txtDesc2.MinValue = -99999.99R
        Me.txtDesc2.Multiline = True
        Me.txtDesc2.Name = "txtDesc2"
        Me.txtDesc2.NotNull = False
        Me.txtDesc2.ShowDecimal = False
        Me.txtDesc2.Size = New System.Drawing.Size(725, 62)
        Me.txtDesc2.TabIndex = 9
        '
        'lblDesc2
        '
        Me.lblDesc2.AutoSize = True
        Me.lblDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDesc2.LabelId = 0
        Me.lblDesc2.Location = New System.Drawing.Point(34, 154)
        Me.lblDesc2.Name = "lblDesc2"
        Me.lblDesc2.Size = New System.Drawing.Size(91, 17)
        Me.lblDesc2.TabIndex = 8
        Me.lblDesc2.Text = "Description 2"
        '
        'txtDesc1
        '
        Me.txtDesc1.Add_Comma = False
        Me.txtDesc1.DataSource = Nothing
        Me.txtDesc1.DecimalDigit = 2
        Me.txtDesc1.DisplayMember = Nothing
        Me.txtDesc1.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDesc1.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtDesc1.LinkCheckedBox = Nothing
        Me.txtDesc1.Location = New System.Drawing.Point(141, 86)
        Me.txtDesc1.MaxValue = 99999.99R
        Me.txtDesc1.MinValue = -99999.99R
        Me.txtDesc1.Multiline = True
        Me.txtDesc1.Name = "txtDesc1"
        Me.txtDesc1.NotNull = False
        Me.txtDesc1.ShowDecimal = False
        Me.txtDesc1.Size = New System.Drawing.Size(725, 62)
        Me.txtDesc1.TabIndex = 7
        '
        'lblDesc1
        '
        Me.lblDesc1.AutoSize = True
        Me.lblDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDesc1.LabelId = 0
        Me.lblDesc1.Location = New System.Drawing.Point(34, 86)
        Me.lblDesc1.Name = "lblDesc1"
        Me.lblDesc1.Size = New System.Drawing.Size(91, 17)
        Me.lblDesc1.TabIndex = 6
        Me.lblDesc1.Text = "Description 1"
        '
        'chkRear
        '
        Me.chkRear.AutoSize = True
        Me.chkRear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkRear.Location = New System.Drawing.Point(598, 45)
        Me.chkRear.Name = "chkRear"
        Me.chkRear.Size = New System.Drawing.Size(58, 21)
        Me.chkRear.TabIndex = 5
        Me.chkRear.Text = "Rear"
        Me.chkRear.UseVisualStyleBackColor = True
        '
        'chkFront
        '
        Me.chkFront.AutoSize = True
        Me.chkFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkFront.Location = New System.Drawing.Point(517, 45)
        Me.chkFront.Name = "chkFront"
        Me.chkFront.Size = New System.Drawing.Size(60, 21)
        Me.chkFront.TabIndex = 4
        Me.chkFront.Text = "Front"
        Me.chkFront.UseVisualStyleBackColor = True
        '
        'txtFormatNo
        '
        Me.txtFormatNo.Add_Comma = False
        Me.txtFormatNo.BackColor = System.Drawing.Color.MistyRose
        Me.txtFormatNo.DataSource = Nothing
        Me.txtFormatNo.DecimalDigit = 2
        Me.txtFormatNo.DisplayMember = Nothing
        Me.txtFormatNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtFormatNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFormatNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtFormatNo.LinkCheckedBox = Nothing
        Me.txtFormatNo.Location = New System.Drawing.Point(380, 44)
        Me.txtFormatNo.MaxValue = 99999.99R
        Me.txtFormatNo.MinValue = -99999.99R
        Me.txtFormatNo.Name = "txtFormatNo"
        Me.txtFormatNo.NotNull = False
        Me.txtFormatNo.ShowDecimal = False
        Me.txtFormatNo.Size = New System.Drawing.Size(95, 23)
        Me.txtFormatNo.TabIndex = 3
        '
        'lblFormatNo
        '
        Me.lblFormatNo.AutoSize = True
        Me.lblFormatNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFormatNo.LabelId = 0
        Me.lblFormatNo.Location = New System.Drawing.Point(273, 47)
        Me.lblFormatNo.Name = "lblFormatNo"
        Me.lblFormatNo.Size = New System.Drawing.Size(106, 17)
        Me.lblFormatNo.TabIndex = 2
        Me.lblFormatNo.Text = "Format Number"
        '
        'txtCheckNo
        '
        Me.txtCheckNo.Add_Comma = False
        Me.txtCheckNo.BackColor = System.Drawing.Color.MistyRose
        Me.txtCheckNo.DataSource = Nothing
        Me.txtCheckNo.DecimalDigit = 2
        Me.txtCheckNo.DisplayMember = Nothing
        Me.txtCheckNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCheckNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtCheckNo.LinkCheckedBox = Nothing
        Me.txtCheckNo.Location = New System.Drawing.Point(141, 44)
        Me.txtCheckNo.MaxValue = 99999.99R
        Me.txtCheckNo.MinValue = -99999.99R
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.NotNull = False
        Me.txtCheckNo.ShowDecimal = False
        Me.txtCheckNo.Size = New System.Drawing.Size(95, 23)
        Me.txtCheckNo.TabIndex = 1
        '
        'lblCheckNo
        '
        Me.lblCheckNo.AutoSize = True
        Me.lblCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCheckNo.LabelId = 0
        Me.lblCheckNo.Location = New System.Drawing.Point(34, 47)
        Me.lblCheckNo.Name = "lblCheckNo"
        Me.lblCheckNo.Size = New System.Drawing.Size(101, 17)
        Me.lblCheckNo.TabIndex = 0
        Me.lblCheckNo.Text = "Check Number"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(956, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(50, 98)
        Me.Panel1.TabIndex = 15
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
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.cboSMTB)
        Me.grpSearchCondition.Controls.Add(Me.chkSMTB)
        Me.grpSearchCondition.Controls.Add(Me.cboCheckNo)
        Me.grpSearchCondition.Controls.Add(Me.chkSRear)
        Me.grpSearchCondition.Controls.Add(Me.chkSCheckNo)
        Me.grpSearchCondition.Controls.Add(Me.chkSFront)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 57)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(1016, 75)
        Me.grpSearchCondition.TabIndex = 1
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'cboCheckNo
        '
        Me.cboCheckNo.BackColor = System.Drawing.Color.White
        Me.cboCheckNo.Busy = True
        Me.cboCheckNo.DataSource = Nothing
        Me.cboCheckNo.DisplayMember = ""
        Me.cboCheckNo.DisplayMemberLength = Nothing
        Me.cboCheckNo.DisplayMemberList = ""
        Me.cboCheckNo.DisplayMemberText = Nothing
        Me.cboCheckNo.DisplayMemberText2 = Nothing
        Me.cboCheckNo.DisplayMemberText3 = Nothing
        Me.cboCheckNo.DisplayShowButton = False
        Me.cboCheckNo.DropDownList = False
        Me.cboCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboCheckNo.ForeColor = System.Drawing.Color.Black
        Me.cboCheckNo.IsTextBox = False
        Me.cboCheckNo.LinkCheck = Nothing
        Me.cboCheckNo.LinkCheckedBox = Nothing
        Me.cboCheckNo.LinkTextBox = Nothing
        Me.cboCheckNo.LinkTextBox2 = Nothing
        Me.cboCheckNo.LinkTextBox3 = Nothing
        Me.cboCheckNo.Location = New System.Drawing.Point(152, 28)
        Me.cboCheckNo.Margin = New System.Windows.Forms.Padding(0)
        Me.cboCheckNo.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboCheckNo.MaxLength = 32767
        Me.cboCheckNo.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboCheckNo.Name = "cboCheckNo"
        Me.cboCheckNo.NotNull = False
        Me.cboCheckNo.RefreshWidth = False
        Me.cboCheckNo.RowFilter = ""
        Me.cboCheckNo.SelectedIndex = -1
        Me.cboCheckNo.SelectedValue = Nothing
        Me.cboCheckNo.Size = New System.Drawing.Size(154, 23)
        Me.cboCheckNo.TabIndex = 1
        Me.cboCheckNo.ValueMember = ""
        '
        'chkSRear
        '
        Me.chkSRear.AutoSize = True
        Me.chkSRear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSRear.Location = New System.Drawing.Point(417, 29)
        Me.chkSRear.Name = "chkSRear"
        Me.chkSRear.Size = New System.Drawing.Size(58, 21)
        Me.chkSRear.TabIndex = 3
        Me.chkSRear.Text = "Rear"
        Me.chkSRear.UseVisualStyleBackColor = True
        '
        'chkSCheckNo
        '
        Me.chkSCheckNo.AutoSize = True
        Me.chkSCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSCheckNo.Location = New System.Drawing.Point(26, 29)
        Me.chkSCheckNo.Name = "chkSCheckNo"
        Me.chkSCheckNo.Size = New System.Drawing.Size(120, 21)
        Me.chkSCheckNo.TabIndex = 0
        Me.chkSCheckNo.Text = "Check Number"
        Me.chkSCheckNo.UseVisualStyleBackColor = True
        '
        'chkSFront
        '
        Me.chkSFront.AutoSize = True
        Me.chkSFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSFront.Location = New System.Drawing.Point(336, 29)
        Me.chkSFront.Name = "chkSFront"
        Me.chkSFront.Size = New System.Drawing.Size(60, 21)
        Me.chkSFront.TabIndex = 2
        Me.chkSFront.Text = "Front"
        Me.chkSFront.UseVisualStyleBackColor = True
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'chkMTB
        '
        Me.chkMTB.AutoSize = True
        Me.chkMTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkMTB.Location = New System.Drawing.Point(673, 45)
        Me.chkMTB.Name = "chkMTB"
        Me.chkMTB.Size = New System.Drawing.Size(56, 21)
        Me.chkMTB.TabIndex = 16
        Me.chkMTB.Text = "MTB"
        Me.chkMTB.UseVisualStyleBackColor = True
        '
        'cboSMTB
        '
        Me.cboSMTB.BackColor = System.Drawing.Color.White
        Me.cboSMTB.Busy = True
        Me.cboSMTB.DataSource = Nothing
        Me.cboSMTB.DisplayMember = ""
        Me.cboSMTB.DisplayMemberLength = Nothing
        Me.cboSMTB.DisplayMemberList = ""
        Me.cboSMTB.DisplayMemberText = Nothing
        Me.cboSMTB.DisplayMemberText2 = Nothing
        Me.cboSMTB.DisplayMemberText3 = Nothing
        Me.cboSMTB.DisplayShowButton = False
        Me.cboSMTB.DropDownList = False
        Me.cboSMTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSMTB.ForeColor = System.Drawing.Color.Black
        Me.cboSMTB.IsTextBox = False
        Me.cboSMTB.LinkCheck = Nothing
        Me.cboSMTB.LinkCheckedBox = Nothing
        Me.cboSMTB.LinkTextBox = Nothing
        Me.cboSMTB.LinkTextBox2 = Nothing
        Me.cboSMTB.LinkTextBox3 = Nothing
        Me.cboSMTB.Location = New System.Drawing.Point(564, 28)
        Me.cboSMTB.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSMTB.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSMTB.MaxLength = 32767
        Me.cboSMTB.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSMTB.Name = "cboSMTB"
        Me.cboSMTB.NotNull = False
        Me.cboSMTB.RefreshWidth = False
        Me.cboSMTB.RowFilter = ""
        Me.cboSMTB.SelectedIndex = -1
        Me.cboSMTB.SelectedValue = Nothing
        Me.cboSMTB.Size = New System.Drawing.Size(154, 23)
        Me.cboSMTB.TabIndex = 5
        Me.cboSMTB.ValueMember = ""
        '
        'chkSMTB
        '
        Me.chkSMTB.AutoSize = True
        Me.chkSMTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSMTB.Location = New System.Drawing.Point(506, 29)
        Me.chkSMTB.Name = "chkSMTB"
        Me.chkSMTB.Size = New System.Drawing.Size(56, 21)
        Me.chkSMTB.TabIndex = 4
        Me.chkSMTB.Text = "MTB"
        Me.chkSMTB.UseVisualStyleBackColor = True
        '
        'clsVMstQC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 705)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpUpdateData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVMstQC"
        Me.Text = "Master QC"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpData.ResumeLayout(False)
        Me.grpUpdateData.ResumeLayout(False)
        Me.grpUpdateData.PerformLayout()
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
    Friend WithEvents btnEdit As OPE_Controls.OpeButtonEdit
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLogo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNew As OPE_Controls.OpeButtonNew
    Friend WithEvents btnDelete As OPE_Controls.OpeButtonDeleteDoc
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grpUpdateData As OPE_Controls.OpeGroupBox
    Friend WithEvents lblCheckNo As OPE_Controls.OpeLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents chkSRear As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSCheckNo As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSFront As OPE_Controls.OpeCheckBox
    Friend WithEvents txtCheckNo As OPE_Controls.OpeTextBox
    Friend WithEvents cboCheckNo As OPE_Controls.OpeComboBox2
    Friend WithEvents chkRear As OPE_Controls.OpeCheckBox
    Friend WithEvents chkFront As OPE_Controls.OpeCheckBox
    Friend WithEvents txtFormatNo As OPE_Controls.OpeTextBox
    Friend WithEvents lblFormatNo As OPE_Controls.OpeLabel
    Friend WithEvents txtRemark As OPE_Controls.OpeTextBox
    Friend WithEvents lblRemark As OPE_Controls.OpeLabel
    Friend WithEvents txtDesc3 As OPE_Controls.OpeTextBox
    Friend WithEvents lblDesc3 As OPE_Controls.OpeLabel
    Friend WithEvents txtDesc2 As OPE_Controls.OpeTextBox
    Friend WithEvents lblDesc2 As OPE_Controls.OpeLabel
    Friend WithEvents txtDesc1 As OPE_Controls.OpeTextBox
    Friend WithEvents lblDesc1 As OPE_Controls.OpeLabel
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents chkMTB As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSMTB As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSMTB As OPE_Controls.OpeCheckBox
End Class
