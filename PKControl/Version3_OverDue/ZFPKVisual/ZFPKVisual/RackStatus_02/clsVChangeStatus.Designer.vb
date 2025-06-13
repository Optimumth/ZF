<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVChangeStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVChangeStatus))
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.btnSave = New OPE_Controls.OpeButtonSave()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtRemark = New OPE_Controls.OpeTextBox()
        Me.lblRemark = New OPE_Controls.OpeLabel(Me.components)
        Me.txtCode = New OPE_Controls.OpeTextBox()
        Me.lblCode = New OPE_Controls.OpeLabel(Me.components)
        Me.lblType = New OPE_Controls.OpeLabel(Me.components)
        Me.lblModel = New OPE_Controls.OpeLabel(Me.components)
        Me.txtType = New OPE_Controls.OpeTextBox()
        Me.txtModel = New OPE_Controls.OpeTextBox()
        Me.rdoExtWH = New OPE_Controls.OpeRadioButton(Me.components)
        Me.rdoSupplier = New OPE_Controls.OpeRadioButton(Me.components)
        Me.rdoOnTruck = New OPE_Controls.OpeRadioButton(Me.components)
        Me.rdoMB = New OPE_Controls.OpeRadioButton(Me.components)
        Me.rdoZF = New OPE_Controls.OpeRadioButton(Me.components)
        Me.lblStatus = New OPE_Controls.OpeLabel(Me.components)
        Me.txtRunningNo = New OPE_Controls.OpeTextBox()
        Me.lblRunningNo = New OPE_Controls.OpeLabel(Me.components)
        Me.txtRackID = New OPE_Controls.OpeTextBox()
        Me.lblRackID = New OPE_Controls.OpeLabel(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Nothing
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.ToolStripSeparator1})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(538, 39)
        Me.ButtonBoxH.StatusBox = Nothing
        Me.ButtonBoxH.TabIndex = 5
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
        Me.btnSave.Text = "Save"
        Me.btnSave.ToolTipText = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
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
        Me.txtRemark.Location = New System.Drawing.Point(96, 142)
        Me.txtRemark.MaxValue = 99999.99R
        Me.txtRemark.MinValue = -99999.99R
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.NotNull = False
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.ShowDecimal = False
        Me.txtRemark.Size = New System.Drawing.Size(313, 23)
        Me.txtRemark.TabIndex = 15
        Me.txtRemark.TabStop = False
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRemark.LabelId = 0
        Me.lblRemark.Location = New System.Drawing.Point(18, 145)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(57, 17)
        Me.lblRemark.TabIndex = 14
        Me.lblRemark.Text = "Remark"
        '
        'txtCode
        '
        Me.txtCode.Add_Comma = False
        Me.txtCode.BackColor = System.Drawing.Color.Empty
        Me.txtCode.DataSource = Nothing
        Me.txtCode.DecimalDigit = 2
        Me.txtCode.DisplayMember = Nothing
        Me.txtCode.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCode.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtCode.LinkCheckedBox = Nothing
        Me.txtCode.Location = New System.Drawing.Point(96, 115)
        Me.txtCode.MaxValue = 99999.99R
        Me.txtCode.MinValue = -99999.99R
        Me.txtCode.Name = "txtCode"
        Me.txtCode.NotNull = False
        Me.txtCode.ReadOnly = True
        Me.txtCode.ShowDecimal = False
        Me.txtCode.Size = New System.Drawing.Size(313, 23)
        Me.txtCode.TabIndex = 13
        Me.txtCode.TabStop = False
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCode.LabelId = 0
        Me.lblCode.Location = New System.Drawing.Point(18, 118)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(41, 17)
        Me.lblCode.TabIndex = 12
        Me.lblCode.Text = "Code"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblType.LabelId = 0
        Me.lblType.Location = New System.Drawing.Point(18, 64)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(40, 17)
        Me.lblType.TabIndex = 8
        Me.lblType.Text = "Type"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblModel.LabelId = 0
        Me.lblModel.Location = New System.Drawing.Point(18, 91)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(46, 17)
        Me.lblModel.TabIndex = 10
        Me.lblModel.Text = "Model"
        '
        'txtType
        '
        Me.txtType.Add_Comma = False
        Me.txtType.BackColor = System.Drawing.Color.Empty
        Me.txtType.DataSource = Nothing
        Me.txtType.DecimalDigit = 2
        Me.txtType.DisplayMember = Nothing
        Me.txtType.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtType.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtType.LinkCheckedBox = Nothing
        Me.txtType.Location = New System.Drawing.Point(96, 61)
        Me.txtType.MaxValue = 99999.99R
        Me.txtType.MinValue = -99999.99R
        Me.txtType.Name = "txtType"
        Me.txtType.NotNull = False
        Me.txtType.ReadOnly = True
        Me.txtType.ShowDecimal = False
        Me.txtType.Size = New System.Drawing.Size(313, 23)
        Me.txtType.TabIndex = 16
        Me.txtType.TabStop = False
        '
        'txtModel
        '
        Me.txtModel.Add_Comma = False
        Me.txtModel.BackColor = System.Drawing.Color.Empty
        Me.txtModel.DataSource = Nothing
        Me.txtModel.DecimalDigit = 2
        Me.txtModel.DisplayMember = Nothing
        Me.txtModel.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtModel.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtModel.LinkCheckedBox = Nothing
        Me.txtModel.Location = New System.Drawing.Point(96, 88)
        Me.txtModel.MaxValue = 99999.99R
        Me.txtModel.MinValue = -99999.99R
        Me.txtModel.Name = "txtModel"
        Me.txtModel.NotNull = False
        Me.txtModel.ReadOnly = True
        Me.txtModel.ShowDecimal = False
        Me.txtModel.Size = New System.Drawing.Size(313, 23)
        Me.txtModel.TabIndex = 17
        Me.txtModel.TabStop = False
        '
        'rdoExtWH
        '
        Me.rdoExtWH.AutoSize = True
        Me.rdoExtWH.Location = New System.Drawing.Point(457, 245)
        Me.rdoExtWH.Name = "rdoExtWH"
        Me.rdoExtWH.Size = New System.Drawing.Size(65, 17)
        Me.rdoExtWH.TabIndex = 22
        Me.rdoExtWH.TabStop = True
        Me.rdoExtWH.Text = "Ext. WH"
        Me.rdoExtWH.UseVisualStyleBackColor = True
        '
        'rdoSupplier
        '
        Me.rdoSupplier.AutoSize = True
        Me.rdoSupplier.Location = New System.Drawing.Point(359, 245)
        Me.rdoSupplier.Name = "rdoSupplier"
        Me.rdoSupplier.Size = New System.Drawing.Size(68, 17)
        Me.rdoSupplier.TabIndex = 21
        Me.rdoSupplier.TabStop = True
        Me.rdoSupplier.Text = "Supplier"
        Me.rdoSupplier.UseVisualStyleBackColor = True
        '
        'rdoOnTruck
        '
        Me.rdoOnTruck.AutoSize = True
        Me.rdoOnTruck.Location = New System.Drawing.Point(263, 245)
        Me.rdoOnTruck.Name = "rdoOnTruck"
        Me.rdoOnTruck.Size = New System.Drawing.Size(70, 17)
        Me.rdoOnTruck.TabIndex = 20
        Me.rdoOnTruck.TabStop = True
        Me.rdoOnTruck.Text = "On truck"
        Me.rdoOnTruck.UseVisualStyleBackColor = True
        '
        'rdoMB
        '
        Me.rdoMB.AutoSize = True
        Me.rdoMB.Location = New System.Drawing.Point(195, 245)
        Me.rdoMB.Name = "rdoMB"
        Me.rdoMB.Size = New System.Drawing.Size(41, 17)
        Me.rdoMB.TabIndex = 19
        Me.rdoMB.TabStop = True
        Me.rdoMB.Text = "MB"
        Me.rdoMB.UseVisualStyleBackColor = True
        '
        'rdoZF
        '
        Me.rdoZF.AutoSize = True
        Me.rdoZF.Location = New System.Drawing.Point(131, 245)
        Me.rdoZF.Name = "rdoZF"
        Me.rdoZF.Size = New System.Drawing.Size(37, 17)
        Me.rdoZF.TabIndex = 18
        Me.rdoZF.TabStop = True
        Me.rdoZF.Text = "ZF"
        Me.rdoZF.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStatus.LabelId = 0
        Me.lblStatus.Location = New System.Drawing.Point(18, 245)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(84, 17)
        Me.lblStatus.TabIndex = 23
        Me.lblStatus.Text = "Rack Status"
        '
        'txtRunningNo
        '
        Me.txtRunningNo.Add_Comma = False
        Me.txtRunningNo.BackColor = System.Drawing.Color.Empty
        Me.txtRunningNo.DataSource = Nothing
        Me.txtRunningNo.DecimalDigit = 2
        Me.txtRunningNo.DisplayMember = Nothing
        Me.txtRunningNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRunningNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRunningNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtRunningNo.LinkCheckedBox = Nothing
        Me.txtRunningNo.Location = New System.Drawing.Point(96, 171)
        Me.txtRunningNo.MaxValue = 99999.99R
        Me.txtRunningNo.MinValue = -99999.99R
        Me.txtRunningNo.Name = "txtRunningNo"
        Me.txtRunningNo.NotNull = False
        Me.txtRunningNo.ReadOnly = True
        Me.txtRunningNo.ShowDecimal = False
        Me.txtRunningNo.Size = New System.Drawing.Size(313, 23)
        Me.txtRunningNo.TabIndex = 25
        Me.txtRunningNo.TabStop = False
        '
        'lblRunningNo
        '
        Me.lblRunningNo.AutoSize = True
        Me.lblRunningNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRunningNo.LabelId = 0
        Me.lblRunningNo.Location = New System.Drawing.Point(18, 174)
        Me.lblRunningNo.Name = "lblRunningNo"
        Me.lblRunningNo.Size = New System.Drawing.Size(66, 17)
        Me.lblRunningNo.TabIndex = 24
        Me.lblRunningNo.Text = "Rack No."
        '
        'txtRackID
        '
        Me.txtRackID.Add_Comma = False
        Me.txtRackID.BackColor = System.Drawing.Color.Empty
        Me.txtRackID.DataSource = Nothing
        Me.txtRackID.DecimalDigit = 2
        Me.txtRackID.DisplayMember = Nothing
        Me.txtRackID.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRackID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRackID.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtRackID.LinkCheckedBox = Nothing
        Me.txtRackID.Location = New System.Drawing.Point(96, 200)
        Me.txtRackID.MaxValue = 99999.99R
        Me.txtRackID.MinValue = -99999.99R
        Me.txtRackID.Name = "txtRackID"
        Me.txtRackID.NotNull = False
        Me.txtRackID.ReadOnly = True
        Me.txtRackID.ShowDecimal = False
        Me.txtRackID.Size = New System.Drawing.Size(313, 23)
        Me.txtRackID.TabIndex = 27
        Me.txtRackID.TabStop = False
        '
        'lblRackID
        '
        Me.lblRackID.AutoSize = True
        Me.lblRackID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRackID.LabelId = 0
        Me.lblRackID.Location = New System.Drawing.Point(18, 203)
        Me.lblRackID.Name = "lblRackID"
        Me.lblRackID.Size = New System.Drawing.Size(57, 17)
        Me.lblRackID.TabIndex = 26
        Me.lblRackID.Text = "Rack ID"
        '
        'clsVChangeStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 342)
        Me.Controls.Add(Me.txtRackID)
        Me.Controls.Add(Me.lblRackID)
        Me.Controls.Add(Me.txtRunningNo)
        Me.Controls.Add(Me.lblRunningNo)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.rdoExtWH)
        Me.Controls.Add(Me.rdoSupplier)
        Me.Controls.Add(Me.rdoOnTruck)
        Me.Controls.Add(Me.rdoMB)
        Me.Controls.Add(Me.rdoZF)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "clsVChangeStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Status"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSave As OPE_Controls.OpeButtonSave
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtRemark As OPE_Controls.OpeTextBox
    Friend WithEvents lblRemark As OPE_Controls.OpeLabel
    Friend WithEvents txtCode As OPE_Controls.OpeTextBox
    Friend WithEvents lblCode As OPE_Controls.OpeLabel
    Friend WithEvents lblType As OPE_Controls.OpeLabel
    Friend WithEvents lblModel As OPE_Controls.OpeLabel
    Friend WithEvents txtType As OPE_Controls.OpeTextBox
    Friend WithEvents txtModel As OPE_Controls.OpeTextBox
    Friend WithEvents rdoExtWH As OPE_Controls.OpeRadioButton
    Friend WithEvents rdoSupplier As OPE_Controls.OpeRadioButton
    Friend WithEvents rdoOnTruck As OPE_Controls.OpeRadioButton
    Friend WithEvents rdoMB As OPE_Controls.OpeRadioButton
    Friend WithEvents rdoZF As OPE_Controls.OpeRadioButton
    Friend WithEvents lblStatus As OPE_Controls.OpeLabel
    Friend WithEvents txtRunningNo As OPE_Controls.OpeTextBox
    Friend WithEvents lblRunningNo As OPE_Controls.OpeLabel
    Friend WithEvents txtRackID As OPE_Controls.OpeTextBox
    Friend WithEvents lblRackID As OPE_Controls.OpeLabel
End Class
