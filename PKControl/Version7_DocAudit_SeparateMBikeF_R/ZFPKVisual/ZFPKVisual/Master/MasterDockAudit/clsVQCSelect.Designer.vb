<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVQCSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVQCSelect))
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.btnOK = New OPE_Controls.OpeButtonOK()
        Me.lblAreaCode = New OPE_Controls.OpeLabel(Me.components)
        Me.lblCheckNumber = New OPE_Controls.OpeLabel(Me.components)
        Me.txtCheckNumber = New OPE_Controls.OpeTextBox()
        Me.cboFormatID = New OPE_Controls.OpeComboBox2()
        Me.lblFormatID = New OPE_Controls.OpeLabel(Me.components)
        Me.txtAreaCode = New OPE_Controls.OpeTextBox()
        Me.lblDesc1 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtDesc1 = New OPE_Controls.OpeTextBox()
        Me.txtDesc2 = New OPE_Controls.OpeTextBox()
        Me.lblDesc2 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtDesc3 = New OPE_Controls.OpeTextBox()
        Me.lblDesc3 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtRemark = New OPE_Controls.OpeTextBox()
        Me.lblRemark = New OPE_Controls.OpeLabel(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Nothing
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOK})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(914, 39)
        Me.ButtonBoxH.StatusBox = Nothing
        Me.ButtonBoxH.TabIndex = 10
        Me.ButtonBoxH.Text = "OpeButtonBox1"
        '
        'btnOK
        '
        Me.btnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(36, 36)
        Me.btnOK.Text = "OK"
        Me.btnOK.ToolTipText = "OK"
        '
        'lblAreaCode
        '
        Me.lblAreaCode.AutoSize = True
        Me.lblAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAreaCode.LabelId = 0
        Me.lblAreaCode.Location = New System.Drawing.Point(43, 57)
        Me.lblAreaCode.Name = "lblAreaCode"
        Me.lblAreaCode.Size = New System.Drawing.Size(75, 17)
        Me.lblAreaCode.TabIndex = 11
        Me.lblAreaCode.Text = "Area Code"
        '
        'lblCheckNumber
        '
        Me.lblCheckNumber.AutoSize = True
        Me.lblCheckNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCheckNumber.LabelId = 0
        Me.lblCheckNumber.Location = New System.Drawing.Point(219, 57)
        Me.lblCheckNumber.Name = "lblCheckNumber"
        Me.lblCheckNumber.Size = New System.Drawing.Size(101, 17)
        Me.lblCheckNumber.TabIndex = 15
        Me.lblCheckNumber.Text = "Check Number"
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.Add_Comma = False
        Me.txtCheckNumber.BackColor = System.Drawing.Color.Empty
        Me.txtCheckNumber.DataSource = Nothing
        Me.txtCheckNumber.DecimalDigit = 2
        Me.txtCheckNumber.DisplayMember = Nothing
        Me.txtCheckNumber.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtCheckNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCheckNumber.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtCheckNumber.LinkCheckedBox = Nothing
        Me.txtCheckNumber.Location = New System.Drawing.Point(326, 54)
        Me.txtCheckNumber.MaxValue = 99999.99R
        Me.txtCheckNumber.MinValue = -99999.99R
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.NotNull = False
        Me.txtCheckNumber.ReadOnly = True
        Me.txtCheckNumber.ShowDecimal = False
        Me.txtCheckNumber.Size = New System.Drawing.Size(63, 23)
        Me.txtCheckNumber.TabIndex = 13
        Me.txtCheckNumber.TabStop = False
        '
        'cboFormatID
        '
        Me.cboFormatID.BackColor = System.Drawing.Color.White
        Me.cboFormatID.Busy = True
        Me.cboFormatID.DataSource = Nothing
        Me.cboFormatID.DisplayMember = ""
        Me.cboFormatID.DisplayMemberLength = Nothing
        Me.cboFormatID.DisplayMemberList = ""
        Me.cboFormatID.DisplayMemberText = Nothing
        Me.cboFormatID.DisplayMemberText2 = Nothing
        Me.cboFormatID.DisplayMemberText3 = Nothing
        Me.cboFormatID.DisplayShowButton = False
        Me.cboFormatID.DropDownList = False
        Me.cboFormatID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboFormatID.ForeColor = System.Drawing.Color.Black
        Me.cboFormatID.IsTextBox = False
        Me.cboFormatID.LinkCheck = Nothing
        Me.cboFormatID.LinkCheckedBox = Nothing
        Me.cboFormatID.LinkTextBox = Nothing
        Me.cboFormatID.LinkTextBox2 = Nothing
        Me.cboFormatID.LinkTextBox3 = Nothing
        Me.cboFormatID.Location = New System.Drawing.Point(517, 54)
        Me.cboFormatID.Margin = New System.Windows.Forms.Padding(0)
        Me.cboFormatID.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboFormatID.MaxLength = 32767
        Me.cboFormatID.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboFormatID.Name = "cboFormatID"
        Me.cboFormatID.NotNull = False
        Me.cboFormatID.RefreshWidth = False
        Me.cboFormatID.RowFilter = ""
        Me.cboFormatID.SelectedIndex = -1
        Me.cboFormatID.SelectedValue = Nothing
        Me.cboFormatID.Size = New System.Drawing.Size(185, 23)
        Me.cboFormatID.TabIndex = 17
        Me.cboFormatID.ValueMember = ""
        '
        'lblFormatID
        '
        Me.lblFormatID.AutoSize = True
        Me.lblFormatID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFormatID.LabelId = 0
        Me.lblFormatID.Location = New System.Drawing.Point(439, 57)
        Me.lblFormatID.Name = "lblFormatID"
        Me.lblFormatID.Size = New System.Drawing.Size(69, 17)
        Me.lblFormatID.TabIndex = 16
        Me.lblFormatID.Text = "Format ID"
        '
        'txtAreaCode
        '
        Me.txtAreaCode.Add_Comma = False
        Me.txtAreaCode.BackColor = System.Drawing.Color.Empty
        Me.txtAreaCode.DataSource = Nothing
        Me.txtAreaCode.DecimalDigit = 2
        Me.txtAreaCode.DisplayMember = Nothing
        Me.txtAreaCode.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtAreaCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtAreaCode.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtAreaCode.LinkCheckedBox = Nothing
        Me.txtAreaCode.Location = New System.Drawing.Point(124, 54)
        Me.txtAreaCode.MaxValue = 99999.99R
        Me.txtAreaCode.MinValue = -99999.99R
        Me.txtAreaCode.Name = "txtAreaCode"
        Me.txtAreaCode.NotNull = False
        Me.txtAreaCode.ReadOnly = True
        Me.txtAreaCode.ShowDecimal = False
        Me.txtAreaCode.Size = New System.Drawing.Size(63, 23)
        Me.txtAreaCode.TabIndex = 18
        Me.txtAreaCode.TabStop = False
        '
        'lblDesc1
        '
        Me.lblDesc1.AutoSize = True
        Me.lblDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDesc1.LabelId = 0
        Me.lblDesc1.Location = New System.Drawing.Point(43, 102)
        Me.lblDesc1.Name = "lblDesc1"
        Me.lblDesc1.Size = New System.Drawing.Size(91, 17)
        Me.lblDesc1.TabIndex = 19
        Me.lblDesc1.Text = "Description 1"
        '
        'txtDesc1
        '
        Me.txtDesc1.Add_Comma = False
        Me.txtDesc1.BackColor = System.Drawing.Color.Empty
        Me.txtDesc1.DataSource = Nothing
        Me.txtDesc1.DecimalDigit = 2
        Me.txtDesc1.DisplayMember = Nothing
        Me.txtDesc1.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDesc1.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtDesc1.LinkCheckedBox = Nothing
        Me.txtDesc1.Location = New System.Drawing.Point(140, 102)
        Me.txtDesc1.MaxValue = 99999.99R
        Me.txtDesc1.MinValue = -99999.99R
        Me.txtDesc1.Multiline = True
        Me.txtDesc1.Name = "txtDesc1"
        Me.txtDesc1.NotNull = False
        Me.txtDesc1.ReadOnly = True
        Me.txtDesc1.ShowDecimal = False
        Me.txtDesc1.Size = New System.Drawing.Size(725, 111)
        Me.txtDesc1.TabIndex = 20
        Me.txtDesc1.TabStop = False
        '
        'txtDesc2
        '
        Me.txtDesc2.Add_Comma = False
        Me.txtDesc2.BackColor = System.Drawing.Color.Empty
        Me.txtDesc2.DataSource = Nothing
        Me.txtDesc2.DecimalDigit = 2
        Me.txtDesc2.DisplayMember = Nothing
        Me.txtDesc2.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDesc2.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtDesc2.LinkCheckedBox = Nothing
        Me.txtDesc2.Location = New System.Drawing.Point(140, 230)
        Me.txtDesc2.MaxValue = 99999.99R
        Me.txtDesc2.MinValue = -99999.99R
        Me.txtDesc2.Multiline = True
        Me.txtDesc2.Name = "txtDesc2"
        Me.txtDesc2.NotNull = False
        Me.txtDesc2.ReadOnly = True
        Me.txtDesc2.ShowDecimal = False
        Me.txtDesc2.Size = New System.Drawing.Size(725, 111)
        Me.txtDesc2.TabIndex = 22
        Me.txtDesc2.TabStop = False
        '
        'lblDesc2
        '
        Me.lblDesc2.AutoSize = True
        Me.lblDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDesc2.LabelId = 0
        Me.lblDesc2.Location = New System.Drawing.Point(43, 230)
        Me.lblDesc2.Name = "lblDesc2"
        Me.lblDesc2.Size = New System.Drawing.Size(91, 17)
        Me.lblDesc2.TabIndex = 21
        Me.lblDesc2.Text = "Description 2"
        '
        'txtDesc3
        '
        Me.txtDesc3.Add_Comma = False
        Me.txtDesc3.BackColor = System.Drawing.Color.Empty
        Me.txtDesc3.DataSource = Nothing
        Me.txtDesc3.DecimalDigit = 2
        Me.txtDesc3.DisplayMember = Nothing
        Me.txtDesc3.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtDesc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDesc3.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtDesc3.LinkCheckedBox = Nothing
        Me.txtDesc3.Location = New System.Drawing.Point(140, 360)
        Me.txtDesc3.MaxValue = 99999.99R
        Me.txtDesc3.MinValue = -99999.99R
        Me.txtDesc3.Multiline = True
        Me.txtDesc3.Name = "txtDesc3"
        Me.txtDesc3.NotNull = False
        Me.txtDesc3.ReadOnly = True
        Me.txtDesc3.ShowDecimal = False
        Me.txtDesc3.Size = New System.Drawing.Size(725, 111)
        Me.txtDesc3.TabIndex = 24
        Me.txtDesc3.TabStop = False
        '
        'lblDesc3
        '
        Me.lblDesc3.AutoSize = True
        Me.lblDesc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDesc3.LabelId = 0
        Me.lblDesc3.Location = New System.Drawing.Point(43, 360)
        Me.lblDesc3.Name = "lblDesc3"
        Me.lblDesc3.Size = New System.Drawing.Size(91, 17)
        Me.lblDesc3.TabIndex = 23
        Me.lblDesc3.Text = "Description 3"
        '
        'txtRemark
        '
        Me.txtRemark.Add_Comma = False
        Me.txtRemark.BackColor = System.Drawing.Color.Empty
        Me.txtRemark.DataSource = Nothing
        Me.txtRemark.DecimalDigit = 2
        Me.txtRemark.DisplayMember = Nothing
        Me.txtRemark.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRemark.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtRemark.LinkCheckedBox = Nothing
        Me.txtRemark.Location = New System.Drawing.Point(140, 487)
        Me.txtRemark.MaxValue = 99999.99R
        Me.txtRemark.MinValue = -99999.99R
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.NotNull = False
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.ShowDecimal = False
        Me.txtRemark.Size = New System.Drawing.Size(725, 111)
        Me.txtRemark.TabIndex = 26
        Me.txtRemark.TabStop = False
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRemark.LabelId = 0
        Me.lblRemark.Location = New System.Drawing.Point(43, 487)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(57, 17)
        Me.lblRemark.TabIndex = 25
        Me.lblRemark.Text = "Remark"
        '
        'clsVQCSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 668)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.txtDesc3)
        Me.Controls.Add(Me.lblDesc3)
        Me.Controls.Add(Me.txtDesc2)
        Me.Controls.Add(Me.lblDesc2)
        Me.Controls.Add(Me.txtDesc1)
        Me.Controls.Add(Me.lblDesc1)
        Me.Controls.Add(Me.txtAreaCode)
        Me.Controls.Add(Me.cboFormatID)
        Me.Controls.Add(Me.lblFormatID)
        Me.Controls.Add(Me.lblCheckNumber)
        Me.Controls.Add(Me.txtCheckNumber)
        Me.Controls.Add(Me.lblAreaCode)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVQCSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Audit Description"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnOK As OPE_Controls.OpeButtonOK
    Friend WithEvents lblAreaCode As OPE_Controls.OpeLabel
    Friend WithEvents lblCheckNumber As OPE_Controls.OpeLabel
    Friend WithEvents txtCheckNumber As OPE_Controls.OpeTextBox
    Friend WithEvents cboFormatID As OPE_Controls.OpeComboBox2
    Friend WithEvents lblFormatID As OPE_Controls.OpeLabel
    Friend WithEvents txtAreaCode As OPE_Controls.OpeTextBox
    Friend WithEvents lblDesc1 As OPE_Controls.OpeLabel
    Friend WithEvents txtDesc1 As OPE_Controls.OpeTextBox
    Friend WithEvents txtDesc2 As OPE_Controls.OpeTextBox
    Friend WithEvents lblDesc2 As OPE_Controls.OpeLabel
    Friend WithEvents txtDesc3 As OPE_Controls.OpeTextBox
    Friend WithEvents lblDesc3 As OPE_Controls.OpeLabel
    Friend WithEvents txtRemark As OPE_Controls.OpeTextBox
    Friend WithEvents lblRemark As OPE_Controls.OpeLabel
End Class
