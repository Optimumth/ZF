<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVSystemConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVSystemConfig))
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.btnSave = New OPE_Controls.OpeButtonSave()
        Me.grpConfig = New OPE_Controls.OpeGroupBox()
        Me.btnOutlogPath = New OPE_Controls.OpeButton(Me.components)
        Me.txtAutoMBHrs = New OPE_Controls.OpeTextBox()
        Me.txtOutlogPath = New OPE_Controls.OpeTextBox()
        Me.lblOutlogPath = New OPE_Controls.OpeLabel(Me.components)
        Me.lblAutoMBHrs = New OPE_Controls.OpeLabel(Me.components)
        Me.lblRackColumn = New OPE_Controls.OpeLabel(Me.components)
        Me.txtRackColumn = New OPE_Controls.OpeTextBox()
        Me.grpPassword = New OPE_Controls.OpeGroupBox()
        Me.lblConfirm = New OPE_Controls.OpeLabel(Me.components)
        Me.txtConfirmPassword = New OPE_Controls.OpeTextBox()
        Me.lblNew = New OPE_Controls.OpeLabel(Me.components)
        Me.txtNewPassword = New OPE_Controls.OpeTextBox()
        Me.lblCurrent = New OPE_Controls.OpeLabel(Me.components)
        Me.txtCurPassword = New OPE_Controls.OpeTextBox()
        Me.txtMBDue = New OPE_Controls.OpeTextBox()
        Me.OpeLabel1 = New OPE_Controls.OpeLabel(Me.components)
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonBoxH.SuspendLayout()
        Me.grpConfig.SuspendLayout()
        Me.grpPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Nothing
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(929, 39)
        Me.ButtonBoxH.StatusBox = Nothing
        Me.ButtonBoxH.TabIndex = 0
        Me.ButtonBoxH.Text = "OpeButtonBox1"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(36, 36)
        Me.btnSave.Text = "Save && Close"
        Me.btnSave.ToolTipText = "Save && Close"
        '
        'grpConfig
        '
        Me.grpConfig.Controls.Add(Me.txtMBDue)
        Me.grpConfig.Controls.Add(Me.OpeLabel1)
        Me.grpConfig.Controls.Add(Me.btnOutlogPath)
        Me.grpConfig.Controls.Add(Me.txtAutoMBHrs)
        Me.grpConfig.Controls.Add(Me.txtOutlogPath)
        Me.grpConfig.Controls.Add(Me.lblOutlogPath)
        Me.grpConfig.Controls.Add(Me.lblAutoMBHrs)
        Me.grpConfig.Controls.Add(Me.lblRackColumn)
        Me.grpConfig.Controls.Add(Me.txtRackColumn)
        Me.grpConfig.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConfig.Location = New System.Drawing.Point(0, 39)
        Me.grpConfig.Name = "grpConfig"
        Me.grpConfig.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpConfig.Size = New System.Drawing.Size(929, 211)
        Me.grpConfig.TabIndex = 3
        Me.grpConfig.TabStop = False
        Me.grpConfig.Text = "General Config"
        '
        'btnOutlogPath
        '
        Me.btnOutlogPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOutlogPath.Location = New System.Drawing.Point(830, 83)
        Me.btnOutlogPath.Name = "btnOutlogPath"
        Me.btnOutlogPath.Size = New System.Drawing.Size(35, 37)
        Me.btnOutlogPath.TabIndex = 7
        Me.btnOutlogPath.Text = "..."
        Me.btnOutlogPath.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOutlogPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOutlogPath.UseVisualStyleBackColor = True
        '
        'txtAutoMBHrs
        '
        Me.txtAutoMBHrs.Add_Comma = False
        Me.txtAutoMBHrs.BackColor = System.Drawing.Color.White
        Me.txtAutoMBHrs.DataSource = Nothing
        Me.txtAutoMBHrs.DecimalDigit = 0
        Me.txtAutoMBHrs.DisplayMember = Nothing
        Me.txtAutoMBHrs.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtAutoMBHrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtAutoMBHrs.ForeColor = System.Drawing.Color.Black
        Me.txtAutoMBHrs.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtAutoMBHrs.LinkCheckedBox = Nothing
        Me.txtAutoMBHrs.Location = New System.Drawing.Point(259, 61)
        Me.txtAutoMBHrs.MaxLength = 50
        Me.txtAutoMBHrs.MaxValue = 99999.99R
        Me.txtAutoMBHrs.MinValue = -99999.99R
        Me.txtAutoMBHrs.Name = "txtAutoMBHrs"
        Me.txtAutoMBHrs.NotNull = False
        Me.txtAutoMBHrs.ShowDecimal = False
        Me.txtAutoMBHrs.Size = New System.Drawing.Size(69, 23)
        Me.txtAutoMBHrs.TabIndex = 4
        Me.txtAutoMBHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOutlogPath
        '
        Me.txtOutlogPath.Add_Comma = False
        Me.txtOutlogPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutlogPath.BackColor = System.Drawing.Color.White
        Me.txtOutlogPath.DataSource = Nothing
        Me.txtOutlogPath.DecimalDigit = 2
        Me.txtOutlogPath.DisplayMember = Nothing
        Me.txtOutlogPath.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtOutlogPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtOutlogPath.ForeColor = System.Drawing.Color.Black
        Me.txtOutlogPath.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtOutlogPath.LinkCheckedBox = Nothing
        Me.txtOutlogPath.Location = New System.Drawing.Point(259, 90)
        Me.txtOutlogPath.MaxLength = 255
        Me.txtOutlogPath.MaxValue = 99999.99R
        Me.txtOutlogPath.MinValue = -99999.99R
        Me.txtOutlogPath.Name = "txtOutlogPath"
        Me.txtOutlogPath.NotNull = False
        Me.txtOutlogPath.ShowDecimal = False
        Me.txtOutlogPath.Size = New System.Drawing.Size(562, 23)
        Me.txtOutlogPath.TabIndex = 6
        '
        'lblOutlogPath
        '
        Me.lblOutlogPath.AutoSize = True
        Me.lblOutlogPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblOutlogPath.LabelId = 0
        Me.lblOutlogPath.Location = New System.Drawing.Point(51, 93)
        Me.lblOutlogPath.Name = "lblOutlogPath"
        Me.lblOutlogPath.Size = New System.Drawing.Size(86, 17)
        Me.lblOutlogPath.TabIndex = 5
        Me.lblOutlogPath.Text = "Out log path"
        '
        'lblAutoMBHrs
        '
        Me.lblAutoMBHrs.AutoSize = True
        Me.lblAutoMBHrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAutoMBHrs.LabelId = 0
        Me.lblAutoMBHrs.Location = New System.Drawing.Point(51, 64)
        Me.lblAutoMBHrs.Name = "lblAutoMBHrs"
        Me.lblAutoMBHrs.Size = New System.Drawing.Size(97, 17)
        Me.lblAutoMBHrs.TabIndex = 3
        Me.lblAutoMBHrs.Text = "Auto MB (Hrs)"
        '
        'lblRackColumn
        '
        Me.lblRackColumn.AutoSize = True
        Me.lblRackColumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRackColumn.LabelId = 0
        Me.lblRackColumn.Location = New System.Drawing.Point(51, 32)
        Me.lblRackColumn.Name = "lblRackColumn"
        Me.lblRackColumn.Size = New System.Drawing.Size(185, 17)
        Me.lblRackColumn.TabIndex = 1
        Me.lblRackColumn.Text = "Rack Status Column Display"
        '
        'txtRackColumn
        '
        Me.txtRackColumn.Add_Comma = False
        Me.txtRackColumn.BackColor = System.Drawing.Color.White
        Me.txtRackColumn.DataSource = Nothing
        Me.txtRackColumn.DecimalDigit = 0
        Me.txtRackColumn.DisplayMember = Nothing
        Me.txtRackColumn.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRackColumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRackColumn.ForeColor = System.Drawing.Color.Black
        Me.txtRackColumn.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtRackColumn.LinkCheckedBox = Nothing
        Me.txtRackColumn.Location = New System.Drawing.Point(259, 29)
        Me.txtRackColumn.MaxLength = 50
        Me.txtRackColumn.MaxValue = 99999.99R
        Me.txtRackColumn.MinValue = -99999.99R
        Me.txtRackColumn.Name = "txtRackColumn"
        Me.txtRackColumn.NotNull = False
        Me.txtRackColumn.ShowDecimal = False
        Me.txtRackColumn.Size = New System.Drawing.Size(69, 23)
        Me.txtRackColumn.TabIndex = 2
        Me.txtRackColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpPassword
        '
        Me.grpPassword.Controls.Add(Me.lblConfirm)
        Me.grpPassword.Controls.Add(Me.txtConfirmPassword)
        Me.grpPassword.Controls.Add(Me.lblNew)
        Me.grpPassword.Controls.Add(Me.txtNewPassword)
        Me.grpPassword.Controls.Add(Me.lblCurrent)
        Me.grpPassword.Controls.Add(Me.txtCurPassword)
        Me.grpPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpPassword.Location = New System.Drawing.Point(0, 250)
        Me.grpPassword.Name = "grpPassword"
        Me.grpPassword.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpPassword.Size = New System.Drawing.Size(929, 301)
        Me.grpPassword.TabIndex = 4
        Me.grpPassword.TabStop = False
        Me.grpPassword.Text = "Rack Status Password"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblConfirm.LabelId = 0
        Me.lblConfirm.Location = New System.Drawing.Point(40, 88)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(53, 16)
        Me.lblConfirm.TabIndex = 4
        Me.lblConfirm.Text = "Confirm"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Add_Comma = False
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.White
        Me.txtConfirmPassword.DataSource = Nothing
        Me.txtConfirmPassword.DecimalDigit = 2
        Me.txtConfirmPassword.DisplayMember = Nothing
        Me.txtConfirmPassword.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtConfirmPassword.LinkCheckedBox = Nothing
        Me.txtConfirmPassword.Location = New System.Drawing.Point(212, 85)
        Me.txtConfirmPassword.MaxLength = 50
        Me.txtConfirmPassword.MaxValue = 99999.99R
        Me.txtConfirmPassword.MinValue = -99999.99R
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.NotNull = False
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.ShowDecimal = False
        Me.txtConfirmPassword.Size = New System.Drawing.Size(116, 22)
        Me.txtConfirmPassword.TabIndex = 5
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNew.LabelId = 0
        Me.lblNew.Location = New System.Drawing.Point(40, 60)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(35, 16)
        Me.lblNew.TabIndex = 2
        Me.lblNew.Text = "New"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Add_Comma = False
        Me.txtNewPassword.BackColor = System.Drawing.Color.White
        Me.txtNewPassword.DataSource = Nothing
        Me.txtNewPassword.DecimalDigit = 2
        Me.txtNewPassword.DisplayMember = Nothing
        Me.txtNewPassword.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtNewPassword.LinkCheckedBox = Nothing
        Me.txtNewPassword.Location = New System.Drawing.Point(212, 57)
        Me.txtNewPassword.MaxLength = 50
        Me.txtNewPassword.MaxValue = 99999.99R
        Me.txtNewPassword.MinValue = -99999.99R
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.NotNull = False
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.ShowDecimal = False
        Me.txtNewPassword.Size = New System.Drawing.Size(116, 22)
        Me.txtNewPassword.TabIndex = 3
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCurrent.LabelId = 0
        Me.lblCurrent.Location = New System.Drawing.Point(40, 32)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(50, 16)
        Me.lblCurrent.TabIndex = 0
        Me.lblCurrent.Text = "Current"
        '
        'txtCurPassword
        '
        Me.txtCurPassword.Add_Comma = False
        Me.txtCurPassword.BackColor = System.Drawing.Color.White
        Me.txtCurPassword.DataSource = Nothing
        Me.txtCurPassword.DecimalDigit = 2
        Me.txtCurPassword.DisplayMember = Nothing
        Me.txtCurPassword.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtCurPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCurPassword.ForeColor = System.Drawing.Color.Black
        Me.txtCurPassword.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtCurPassword.LinkCheckedBox = Nothing
        Me.txtCurPassword.Location = New System.Drawing.Point(212, 29)
        Me.txtCurPassword.MaxLength = 50
        Me.txtCurPassword.MaxValue = 99999.99R
        Me.txtCurPassword.MinValue = -99999.99R
        Me.txtCurPassword.Name = "txtCurPassword"
        Me.txtCurPassword.NotNull = False
        Me.txtCurPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurPassword.ShowDecimal = False
        Me.txtCurPassword.Size = New System.Drawing.Size(116, 22)
        Me.txtCurPassword.TabIndex = 1
        '
        'txtMBDue
        '
        Me.txtMBDue.Add_Comma = False
        Me.txtMBDue.BackColor = System.Drawing.Color.White
        Me.txtMBDue.DataSource = Nothing
        Me.txtMBDue.DecimalDigit = 0
        Me.txtMBDue.DisplayMember = Nothing
        Me.txtMBDue.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtMBDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMBDue.ForeColor = System.Drawing.Color.Black
        Me.txtMBDue.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtMBDue.LinkCheckedBox = Nothing
        Me.txtMBDue.Location = New System.Drawing.Point(259, 119)
        Me.txtMBDue.MaxLength = 50
        Me.txtMBDue.MaxValue = 99999.99R
        Me.txtMBDue.MinValue = -99999.99R
        Me.txtMBDue.Name = "txtMBDue"
        Me.txtMBDue.NotNull = False
        Me.txtMBDue.ShowDecimal = False
        Me.txtMBDue.Size = New System.Drawing.Size(69, 23)
        Me.txtMBDue.TabIndex = 9
        Me.txtMBDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OpeLabel1
        '
        Me.OpeLabel1.AutoSize = True
        Me.OpeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel1.LabelId = 0
        Me.OpeLabel1.Location = New System.Drawing.Point(51, 122)
        Me.OpeLabel1.Name = "OpeLabel1"
        Me.OpeLabel1.Size = New System.Drawing.Size(104, 17)
        Me.OpeLabel1.TabIndex = 8
        Me.OpeLabel1.Text = "MB Due (Days)"
        '
        'clsVSystemConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 551)
        Me.Controls.Add(Me.grpPassword)
        Me.Controls.Add(Me.grpConfig)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVSystemConfig"
        Me.Text = "System Config"
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        Me.grpConfig.ResumeLayout(False)
        Me.grpConfig.PerformLayout()
        Me.grpPassword.ResumeLayout(False)
        Me.grpPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSave As OPE_Controls.OpeButtonSave
    Friend WithEvents grpConfig As OPE_Controls.OpeGroupBox
    Friend WithEvents txtOutlogPath As OPE_Controls.OpeTextBox
    Friend WithEvents lblOutlogPath As OPE_Controls.OpeLabel
    Friend WithEvents lblAutoMBHrs As OPE_Controls.OpeLabel
    Friend WithEvents lblRackColumn As OPE_Controls.OpeLabel
    Friend WithEvents txtRackColumn As OPE_Controls.OpeTextBox
    Friend WithEvents txtAutoMBHrs As OPE_Controls.OpeTextBox
    Friend WithEvents btnOutlogPath As OPE_Controls.OpeButton
    Friend WithEvents grpPassword As OPE_Controls.OpeGroupBox
    Friend WithEvents lblCurrent As OPE_Controls.OpeLabel
    Friend WithEvents txtCurPassword As OPE_Controls.OpeTextBox
    Friend WithEvents lblNew As OPE_Controls.OpeLabel
    Friend WithEvents txtNewPassword As OPE_Controls.OpeTextBox
    Friend WithEvents lblConfirm As OPE_Controls.OpeLabel
    Friend WithEvents txtConfirmPassword As OPE_Controls.OpeTextBox
    Friend WithEvents txtMBDue As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel1 As OPE_Controls.OpeLabel
End Class
