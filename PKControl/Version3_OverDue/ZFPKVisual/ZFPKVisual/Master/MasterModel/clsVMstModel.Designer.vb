<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVMstModel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVMstModel))
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
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.txtSModel = New OPE_Controls.OpeTextBox()
        Me.cboSType = New OPE_Controls.OpeComboBox2()
        Me.chkSModel = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSType = New OPE_Controls.OpeCheckBox(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpUpdateData = New OPE_Controls.OpeGroupBox()
        Me.lblColor = New OPE_Controls.OpeLabel(Me.components)
        Me.btnColor = New OPE_Controls.OpeButton(Me.components)
        Me.txtModel = New OPE_Controls.OpeTextBox()
        Me.chkFront = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkRear = New OPE_Controls.OpeCheckBox(Me.components)
        Me.lblModel = New OPE_Controls.OpeLabel(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.chkBPS = New OPE_Controls.OpeCheckBox(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchCondition.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUpdateData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpData.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ButtonBoxH.Size = New System.Drawing.Size(785, 39)
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
        Me.grdData.Size = New System.Drawing.Size(769, 197)
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
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 451)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(785, 22)
        Me.StatusBox.TabIndex = 4
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.txtSModel)
        Me.grpSearchCondition.Controls.Add(Me.cboSType)
        Me.grpSearchCondition.Controls.Add(Me.chkSModel)
        Me.grpSearchCondition.Controls.Add(Me.chkSType)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 39)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(785, 75)
        Me.grpSearchCondition.TabIndex = 1
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'txtSModel
        '
        Me.txtSModel.Add_Comma = False
        Me.txtSModel.DataSource = Nothing
        Me.txtSModel.DecimalDigit = 2
        Me.txtSModel.DisplayMember = Nothing
        Me.txtSModel.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSModel.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtSModel.LinkCheckedBox = Nothing
        Me.txtSModel.Location = New System.Drawing.Point(97, 28)
        Me.txtSModel.MaxValue = 99999.99R
        Me.txtSModel.MinValue = -99999.99R
        Me.txtSModel.Name = "txtSModel"
        Me.txtSModel.NotNull = False
        Me.txtSModel.ShowDecimal = False
        Me.txtSModel.Size = New System.Drawing.Size(141, 23)
        Me.txtSModel.TabIndex = 1
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
        Me.cboSType.Location = New System.Drawing.Point(351, 28)
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
        Me.cboSType.Size = New System.Drawing.Size(207, 23)
        Me.cboSType.TabIndex = 3
        Me.cboSType.ValueMember = ""
        '
        'chkSModel
        '
        Me.chkSModel.AutoSize = True
        Me.chkSModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSModel.Location = New System.Drawing.Point(26, 29)
        Me.chkSModel.Name = "chkSModel"
        Me.chkSModel.Size = New System.Drawing.Size(65, 21)
        Me.chkSModel.TabIndex = 0
        Me.chkSModel.Text = "Model"
        Me.chkSModel.UseVisualStyleBackColor = True
        '
        'chkSType
        '
        Me.chkSType.AutoSize = True
        Me.chkSType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSType.Location = New System.Drawing.Point(289, 29)
        Me.chkSType.Name = "chkSType"
        Me.chkSType.Size = New System.Drawing.Size(59, 21)
        Me.chkSType.TabIndex = 2
        Me.chkSType.Text = "Type"
        Me.chkSType.UseVisualStyleBackColor = True
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'grpUpdateData
        '
        Me.grpUpdateData.Controls.Add(Me.chkBPS)
        Me.grpUpdateData.Controls.Add(Me.lblColor)
        Me.grpUpdateData.Controls.Add(Me.btnColor)
        Me.grpUpdateData.Controls.Add(Me.txtModel)
        Me.grpUpdateData.Controls.Add(Me.chkFront)
        Me.grpUpdateData.Controls.Add(Me.chkRear)
        Me.grpUpdateData.Controls.Add(Me.lblModel)
        Me.grpUpdateData.Controls.Add(Me.Panel1)
        Me.grpUpdateData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpUpdateData.Location = New System.Drawing.Point(0, 332)
        Me.grpUpdateData.Name = "grpUpdateData"
        Me.grpUpdateData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpUpdateData.Size = New System.Drawing.Size(785, 119)
        Me.grpUpdateData.TabIndex = 5
        Me.grpUpdateData.TabStop = False
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblColor.LabelId = 0
        Me.lblColor.Location = New System.Drawing.Point(34, 64)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(41, 17)
        Me.lblColor.TabIndex = 79
        Me.lblColor.Text = "Color"
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(97, 59)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(185, 27)
        Me.btnColor.TabIndex = 78
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'txtModel
        '
        Me.txtModel.Add_Comma = False
        Me.txtModel.BackColor = System.Drawing.Color.MistyRose
        Me.txtModel.DataSource = Nothing
        Me.txtModel.DecimalDigit = 2
        Me.txtModel.DisplayMember = Nothing
        Me.txtModel.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtModel.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtModel.LinkCheckedBox = Nothing
        Me.txtModel.Location = New System.Drawing.Point(97, 24)
        Me.txtModel.MaxValue = 99999.99R
        Me.txtModel.MinValue = -99999.99R
        Me.txtModel.Name = "txtModel"
        Me.txtModel.NotNull = False
        Me.txtModel.ShowDecimal = False
        Me.txtModel.Size = New System.Drawing.Size(185, 23)
        Me.txtModel.TabIndex = 5
        '
        'chkFront
        '
        Me.chkFront.AutoSize = True
        Me.chkFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkFront.Location = New System.Drawing.Point(309, 25)
        Me.chkFront.Name = "chkFront"
        Me.chkFront.Size = New System.Drawing.Size(60, 21)
        Me.chkFront.TabIndex = 2
        Me.chkFront.Text = "Front"
        Me.chkFront.UseVisualStyleBackColor = True
        '
        'chkRear
        '
        Me.chkRear.AutoSize = True
        Me.chkRear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkRear.Location = New System.Drawing.Point(388, 25)
        Me.chkRear.Name = "chkRear"
        Me.chkRear.Size = New System.Drawing.Size(58, 21)
        Me.chkRear.TabIndex = 3
        Me.chkRear.Text = "Rear"
        Me.chkRear.UseVisualStyleBackColor = True
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblModel.LabelId = 0
        Me.lblModel.Location = New System.Drawing.Point(34, 27)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(46, 17)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Model"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(544, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(50, 98)
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
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 114)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(785, 218)
        Me.grpData.TabIndex = 6
        Me.grpData.TabStop = False
        Me.grpData.Text = "Search Result"
        '
        'chkBPS
        '
        Me.chkBPS.AutoSize = True
        Me.chkBPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkBPS.Location = New System.Drawing.Point(466, 24)
        Me.chkBPS.Name = "chkBPS"
        Me.chkBPS.Size = New System.Drawing.Size(54, 21)
        Me.chkBPS.TabIndex = 80
        Me.chkBPS.Text = "BPS"
        Me.chkBPS.UseVisualStyleBackColor = True
        '
        'clsVMstModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 473)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpUpdateData)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVMstModel"
        Me.Text = "Master Model"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUpdateData.ResumeLayout(False)
        Me.grpUpdateData.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.grpData.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As OPE_Controls.OpeButtonSave
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As OPE_Controls.OpeButtonNew
    Friend WithEvents btnEdit As OPE_Controls.OpeButtonEdit
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As OPE_Controls.OpeButtonDeleteDoc
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents txtSModel As OPE_Controls.OpeTextBox
    Friend WithEvents cboSType As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSModel As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSType As OPE_Controls.OpeCheckBox
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grpUpdateData As OPE_Controls.OpeGroupBox
    Friend WithEvents txtModel As OPE_Controls.OpeTextBox
    Friend WithEvents chkFront As OPE_Controls.OpeCheckBox
    Friend WithEvents chkRear As OPE_Controls.OpeCheckBox
    Friend WithEvents lblModel As OPE_Controls.OpeLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblColor As OPE_Controls.OpeLabel
    Friend WithEvents btnColor As OPE_Controls.OpeButton
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents chkBPS As OPE_Controls.OpeCheckBox
End Class
