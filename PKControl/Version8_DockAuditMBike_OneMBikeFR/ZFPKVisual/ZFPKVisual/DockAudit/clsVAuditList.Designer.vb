<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVAuditList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVAuditList))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.btnSave = New OPE_Controls.OpeButtonSave()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New OPE_Controls.OpeButtonNew()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New OPE_Controls.OpeButtonDeleteDoc()
        Me.btnCheckAll = New OPE_Controls.OpeButtonStrip()
        Me.btnReleaseAll = New OPE_Controls.OpeButtonStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.grdData = New OPE_Controls.opeDataGrid()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.OpeLabel7 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTruckID = New OPE_Controls.OpeTextBox()
        Me.txtLicense = New OPE_Controls.OpeTextBox()
        Me.lblRackAmount = New OPE_Controls.OpeLabel(Me.components)
        Me.lblTruckID = New OPE_Controls.OpeLabel(Me.components)
        Me.lblLicense = New OPE_Controls.OpeLabel(Me.components)
        Me.OpeTextBox1 = New OPE_Controls.OpeTextBox()
        Me.OpeTextBox2 = New OPE_Controls.OpeTextBox()
        Me.ButtonBoxH.SuspendLayout()
        Me.grpData.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 505)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(1327, 22)
        Me.StatusBox.TabIndex = 9
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Nothing
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.btnSave, Me.ToolStripSeparator2, Me.btnNew, Me.ToolStripSeparator3, Me.btnDelete, Me.btnCheckAll, Me.btnReleaseAll, Me.ToolStripSeparator1})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(1327, 39)
        Me.ButtonBoxH.StatusBox = Me.StatusBox
        Me.ButtonBoxH.TabIndex = 8
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
        'btnCheckAll
        '
        Me.btnCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCheckAll.Image = CType(resources.GetObject("btnCheckAll.Image"), System.Drawing.Image)
        Me.btnCheckAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(36, 36)
        Me.btnCheckAll.Text = "Select All"
        '
        'btnReleaseAll
        '
        Me.btnReleaseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReleaseAll.Image = CType(resources.GetObject("btnReleaseAll.Image"), System.Drawing.Image)
        Me.btnReleaseAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReleaseAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReleaseAll.Name = "btnReleaseAll"
        Me.btnReleaseAll.Size = New System.Drawing.Size(36, 36)
        Me.btnReleaseAll.Text = "Release All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 119)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1327, 386)
        Me.grpData.TabIndex = 11
        Me.grpData.TabStop = False
        Me.grpData.Text = "Audit List"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdData.AutoGenerateRecordNo = False
        Me.grdData.ChangeEnterToTab = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.EnableHeadersVisualStyles = False
        Me.grdData.IsStatus = False
        Me.grdData.Location = New System.Drawing.Point(6, 15)
        Me.grdData.Name = "grdData"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdData.Size = New System.Drawing.Size(1311, 365)
        Me.grdData.TabIndex = 0
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.OpeTextBox2)
        Me.grpSearchCondition.Controls.Add(Me.OpeTextBox1)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel7)
        Me.grpSearchCondition.Controls.Add(Me.txtTruckID)
        Me.grpSearchCondition.Controls.Add(Me.txtLicense)
        Me.grpSearchCondition.Controls.Add(Me.lblRackAmount)
        Me.grpSearchCondition.Controls.Add(Me.lblTruckID)
        Me.grpSearchCondition.Controls.Add(Me.lblLicense)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 39)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(1327, 80)
        Me.grpSearchCondition.TabIndex = 10
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Document Detail"
        '
        'OpeLabel7
        '
        Me.OpeLabel7.AutoSize = True
        Me.OpeLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpeLabel7.LabelId = 0
        Me.OpeLabel7.Location = New System.Drawing.Point(990, 28)
        Me.OpeLabel7.Name = "OpeLabel7"
        Me.OpeLabel7.Size = New System.Drawing.Size(77, 24)
        Me.OpeLabel7.TabIndex = 33
        Me.OpeLabel7.Text = "Lot No."
        '
        'txtTruckID
        '
        Me.txtTruckID.Add_Comma = False
        Me.txtTruckID.BackColor = System.Drawing.Color.Empty
        Me.txtTruckID.DataSource = Nothing
        Me.txtTruckID.DecimalDigit = 2
        Me.txtTruckID.DisplayMember = Nothing
        Me.txtTruckID.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTruckID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTruckID.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtTruckID.LinkCheckedBox = Nothing
        Me.txtTruckID.Location = New System.Drawing.Point(128, 26)
        Me.txtTruckID.MaxValue = 99999.99R
        Me.txtTruckID.MinValue = -99999.99R
        Me.txtTruckID.Name = "txtTruckID"
        Me.txtTruckID.NotNull = False
        Me.txtTruckID.ReadOnly = True
        Me.txtTruckID.ShowDecimal = False
        Me.txtTruckID.Size = New System.Drawing.Size(165, 29)
        Me.txtTruckID.TabIndex = 1
        Me.txtTruckID.TabStop = False
        Me.txtTruckID.Text = "Front"
        '
        'txtLicense
        '
        Me.txtLicense.Add_Comma = False
        Me.txtLicense.BackColor = System.Drawing.Color.Empty
        Me.txtLicense.DataSource = Nothing
        Me.txtLicense.DecimalDigit = 2
        Me.txtLicense.DisplayMember = Nothing
        Me.txtLicense.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicense.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtLicense.LinkCheckedBox = Nothing
        Me.txtLicense.Location = New System.Drawing.Point(455, 26)
        Me.txtLicense.MaxValue = 99999.99R
        Me.txtLicense.MinValue = -99999.99R
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.NotNull = False
        Me.txtLicense.ReadOnly = True
        Me.txtLicense.ShowDecimal = False
        Me.txtLicense.Size = New System.Drawing.Size(165, 29)
        Me.txtLicense.TabIndex = 3
        Me.txtLicense.TabStop = False
        Me.txtLicense.Text = "G01"
        '
        'lblRackAmount
        '
        Me.lblRackAmount.AutoSize = True
        Me.lblRackAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRackAmount.LabelId = 0
        Me.lblRackAmount.Location = New System.Drawing.Point(658, 28)
        Me.lblRackAmount.Name = "lblRackAmount"
        Me.lblRackAmount.Size = New System.Drawing.Size(75, 24)
        Me.lblRackAmount.TabIndex = 8
        Me.lblRackAmount.Text = "Variant"
        '
        'lblTruckID
        '
        Me.lblTruckID.AutoSize = True
        Me.lblTruckID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTruckID.LabelId = 0
        Me.lblTruckID.Location = New System.Drawing.Point(24, 28)
        Me.lblTruckID.Name = "lblTruckID"
        Me.lblTruckID.Size = New System.Drawing.Size(54, 24)
        Me.lblTruckID.TabIndex = 0
        Me.lblTruckID.Text = "Area"
        '
        'lblLicense
        '
        Me.lblLicense.AutoSize = True
        Me.lblLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicense.LabelId = 0
        Me.lblLicense.Location = New System.Drawing.Point(315, 28)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(68, 24)
        Me.lblLicense.TabIndex = 2
        Me.lblLicense.Text = "Model"
        '
        'OpeTextBox1
        '
        Me.OpeTextBox1.Add_Comma = False
        Me.OpeTextBox1.BackColor = System.Drawing.Color.Empty
        Me.OpeTextBox1.DataSource = Nothing
        Me.OpeTextBox1.DecimalDigit = 2
        Me.OpeTextBox1.DisplayMember = Nothing
        Me.OpeTextBox1.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.OpeTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpeTextBox1.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.OpeTextBox1.LinkCheckedBox = Nothing
        Me.OpeTextBox1.Location = New System.Drawing.Point(790, 26)
        Me.OpeTextBox1.MaxValue = 99999.99R
        Me.OpeTextBox1.MinValue = -99999.99R
        Me.OpeTextBox1.Name = "OpeTextBox1"
        Me.OpeTextBox1.NotNull = False
        Me.OpeTextBox1.ReadOnly = True
        Me.OpeTextBox1.ShowDecimal = False
        Me.OpeTextBox1.Size = New System.Drawing.Size(165, 29)
        Me.OpeTextBox1.TabIndex = 35
        Me.OpeTextBox1.TabStop = False
        Me.OpeTextBox1.Text = "74FVA7"
        '
        'OpeTextBox2
        '
        Me.OpeTextBox2.Add_Comma = False
        Me.OpeTextBox2.BackColor = System.Drawing.Color.Empty
        Me.OpeTextBox2.DataSource = Nothing
        Me.OpeTextBox2.DecimalDigit = 2
        Me.OpeTextBox2.DisplayMember = Nothing
        Me.OpeTextBox2.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.OpeTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpeTextBox2.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.OpeTextBox2.LinkCheckedBox = Nothing
        Me.OpeTextBox2.Location = New System.Drawing.Point(1073, 26)
        Me.OpeTextBox2.MaxValue = 99999.99R
        Me.OpeTextBox2.MinValue = -99999.99R
        Me.OpeTextBox2.Name = "OpeTextBox2"
        Me.OpeTextBox2.NotNull = False
        Me.OpeTextBox2.ReadOnly = True
        Me.OpeTextBox2.ShowDecimal = False
        Me.OpeTextBox2.Size = New System.Drawing.Size(165, 29)
        Me.OpeTextBox2.TabIndex = 36
        Me.OpeTextBox2.TabStop = False
        Me.OpeTextBox2.Text = "4018"
        '
        'clsVAuditList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 527)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVAuditList"
        Me.Text = "Audit List"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        Me.grpData.ResumeLayout(False)
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents btnSave As OPE_Controls.OpeButtonSave
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As OPE_Controls.OpeButtonNew
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As OPE_Controls.OpeButtonDeleteDoc
    Friend WithEvents btnCheckAll As OPE_Controls.OpeButtonStrip
    Friend WithEvents btnReleaseAll As OPE_Controls.OpeButtonStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents OpeTextBox2 As OPE_Controls.OpeTextBox
    Friend WithEvents OpeTextBox1 As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel7 As OPE_Controls.OpeLabel
    Friend WithEvents txtTruckID As OPE_Controls.OpeTextBox
    Friend WithEvents txtLicense As OPE_Controls.OpeTextBox
    Friend WithEvents lblRackAmount As OPE_Controls.OpeLabel
    Friend WithEvents lblTruckID As OPE_Controls.OpeLabel
    Friend WithEvents lblLicense As OPE_Controls.OpeLabel
End Class
