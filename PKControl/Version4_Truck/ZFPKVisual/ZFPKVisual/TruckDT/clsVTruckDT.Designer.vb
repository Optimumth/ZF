<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVTruckDT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVTruckDT))
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.grdData = New OPE_Controls.opeDataGrid()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.btnSave = New OPE_Controls.OpeButtonSave()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New OPE_Controls.OpeButtonNew()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New OPE_Controls.OpeButtonDeleteDoc()
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.txtTruckID = New OPE_Controls.OpeTextBox()
        Me.txtLicense = New OPE_Controls.OpeTextBox()
        Me.txtRackAmount = New OPE_Controls.OpeTextBox()
        Me.lblRackAmount = New OPE_Controls.OpeLabel(Me.components)
        Me.lblTruckID = New OPE_Controls.OpeLabel(Me.components)
        Me.lblLicense = New OPE_Controls.OpeLabel(Me.components)
        Me.txtBPS = New OPE_Controls.OpeTextBox()
        Me.OpeLabel3 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtRear = New OPE_Controls.OpeTextBox()
        Me.OpeLabel2 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtFront = New OPE_Controls.OpeTextBox()
        Me.OpeLabel1 = New OPE_Controls.OpeLabel(Me.components)
        Me.btnCheckAll = New OPE_Controls.OpeButtonStrip()
        Me.btnReleaseAll = New OPE_Controls.OpeButtonStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpData.SuspendLayout()
        Me.grpSearchCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 497)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(1275, 22)
        Me.StatusBox.TabIndex = 7
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Me.grdData
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.btnSave, Me.ToolStripSeparator2, Me.btnNew, Me.ToolStripSeparator3, Me.btnDelete, Me.btnCheckAll, Me.btnReleaseAll, Me.ToolStripSeparator1})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(1275, 39)
        Me.ButtonBoxH.StatusBox = Me.StatusBox
        Me.ButtonBoxH.TabIndex = 6
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
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle11
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.EnableHeadersVisualStyles = False
        Me.grdData.IsStatus = False
        Me.grdData.Location = New System.Drawing.Point(6, 13)
        Me.grdData.Name = "grdData"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdData.Size = New System.Drawing.Size(1259, 306)
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
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 172)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1275, 325)
        Me.grpData.TabIndex = 9
        Me.grpData.TabStop = False
        Me.grpData.Text = "Rack List"
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.txtBPS)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel3)
        Me.grpSearchCondition.Controls.Add(Me.txtRear)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel2)
        Me.grpSearchCondition.Controls.Add(Me.txtFront)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel1)
        Me.grpSearchCondition.Controls.Add(Me.txtTruckID)
        Me.grpSearchCondition.Controls.Add(Me.txtLicense)
        Me.grpSearchCondition.Controls.Add(Me.txtRackAmount)
        Me.grpSearchCondition.Controls.Add(Me.lblRackAmount)
        Me.grpSearchCondition.Controls.Add(Me.lblTruckID)
        Me.grpSearchCondition.Controls.Add(Me.lblLicense)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 39)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(1275, 133)
        Me.grpSearchCondition.TabIndex = 8
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Truck Detail"
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
        Me.txtTruckID.Location = New System.Drawing.Point(135, 26)
        Me.txtTruckID.MaxValue = 99999.99R
        Me.txtTruckID.MinValue = -99999.99R
        Me.txtTruckID.Name = "txtTruckID"
        Me.txtTruckID.NotNull = False
        Me.txtTruckID.ReadOnly = True
        Me.txtTruckID.ShowDecimal = False
        Me.txtTruckID.Size = New System.Drawing.Size(165, 29)
        Me.txtTruckID.TabIndex = 1
        Me.txtTruckID.TabStop = False
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
        Me.txtLicense.Location = New System.Drawing.Point(435, 26)
        Me.txtLicense.MaxValue = 99999.99R
        Me.txtLicense.MinValue = -99999.99R
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.NotNull = False
        Me.txtLicense.ReadOnly = True
        Me.txtLicense.ShowDecimal = False
        Me.txtLicense.Size = New System.Drawing.Size(165, 29)
        Me.txtLicense.TabIndex = 3
        Me.txtLicense.TabStop = False
        '
        'txtRackAmount
        '
        Me.txtRackAmount.Add_Comma = False
        Me.txtRackAmount.BackColor = System.Drawing.Color.Empty
        Me.txtRackAmount.DataSource = Nothing
        Me.txtRackAmount.DecimalDigit = 0
        Me.txtRackAmount.DisplayMember = Nothing
        Me.txtRackAmount.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRackAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRackAmount.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtRackAmount.LinkCheckedBox = Nothing
        Me.txtRackAmount.Location = New System.Drawing.Point(796, 26)
        Me.txtRackAmount.MaxValue = 99999.99R
        Me.txtRackAmount.MinValue = -99999.99R
        Me.txtRackAmount.Name = "txtRackAmount"
        Me.txtRackAmount.NotNull = False
        Me.txtRackAmount.ReadOnly = True
        Me.txtRackAmount.ShowDecimal = False
        Me.txtRackAmount.Size = New System.Drawing.Size(165, 29)
        Me.txtRackAmount.TabIndex = 9
        Me.txtRackAmount.TabStop = False
        Me.txtRackAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRackAmount
        '
        Me.lblRackAmount.AutoSize = True
        Me.lblRackAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRackAmount.LabelId = 0
        Me.lblRackAmount.Location = New System.Drawing.Point(652, 29)
        Me.lblRackAmount.Name = "lblRackAmount"
        Me.lblRackAmount.Size = New System.Drawing.Size(93, 24)
        Me.lblRackAmount.TabIndex = 8
        Me.lblRackAmount.Text = "Rack Qty"
        '
        'lblTruckID
        '
        Me.lblTruckID.AutoSize = True
        Me.lblTruckID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTruckID.LabelId = 0
        Me.lblTruckID.Location = New System.Drawing.Point(37, 29)
        Me.lblTruckID.Name = "lblTruckID"
        Me.lblTruckID.Size = New System.Drawing.Size(29, 24)
        Me.lblTruckID.TabIndex = 0
        Me.lblTruckID.Text = "ID"
        '
        'lblLicense
        '
        Me.lblLicense.AutoSize = True
        Me.lblLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLicense.LabelId = 0
        Me.lblLicense.Location = New System.Drawing.Point(342, 29)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(88, 24)
        Me.lblLicense.TabIndex = 2
        Me.lblLicense.Text = "Truck ID"
        '
        'txtBPS
        '
        Me.txtBPS.Add_Comma = False
        Me.txtBPS.BackColor = System.Drawing.Color.Empty
        Me.txtBPS.DataSource = Nothing
        Me.txtBPS.DecimalDigit = 2
        Me.txtBPS.DisplayMember = Nothing
        Me.txtBPS.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtBPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBPS.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtBPS.LinkCheckedBox = Nothing
        Me.txtBPS.Location = New System.Drawing.Point(796, 73)
        Me.txtBPS.MaxValue = 99999.99R
        Me.txtBPS.MinValue = -99999.99R
        Me.txtBPS.Name = "txtBPS"
        Me.txtBPS.NotNull = False
        Me.txtBPS.ReadOnly = True
        Me.txtBPS.ShowDecimal = False
        Me.txtBPS.Size = New System.Drawing.Size(167, 29)
        Me.txtBPS.TabIndex = 26
        Me.txtBPS.TabStop = False
        Me.txtBPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel3
        '
        Me.OpeLabel3.AutoSize = True
        Me.OpeLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpeLabel3.LabelId = 0
        Me.OpeLabel3.Location = New System.Drawing.Point(652, 75)
        Me.OpeLabel3.Name = "OpeLabel3"
        Me.OpeLabel3.Size = New System.Drawing.Size(49, 24)
        Me.OpeLabel3.TabIndex = 25
        Me.OpeLabel3.Text = "BPS"
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
        Me.txtRear.Location = New System.Drawing.Point(435, 73)
        Me.txtRear.MaxValue = 99999.99R
        Me.txtRear.MinValue = -99999.99R
        Me.txtRear.Name = "txtRear"
        Me.txtRear.NotNull = False
        Me.txtRear.ReadOnly = True
        Me.txtRear.ShowDecimal = False
        Me.txtRear.Size = New System.Drawing.Size(167, 29)
        Me.txtRear.TabIndex = 24
        Me.txtRear.TabStop = False
        Me.txtRear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel2
        '
        Me.OpeLabel2.AutoSize = True
        Me.OpeLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpeLabel2.LabelId = 0
        Me.OpeLabel2.Location = New System.Drawing.Point(342, 75)
        Me.OpeLabel2.Name = "OpeLabel2"
        Me.OpeLabel2.Size = New System.Drawing.Size(54, 24)
        Me.OpeLabel2.TabIndex = 23
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
        Me.txtFront.Location = New System.Drawing.Point(135, 73)
        Me.txtFront.MaxValue = 99999.99R
        Me.txtFront.MinValue = -99999.99R
        Me.txtFront.Name = "txtFront"
        Me.txtFront.NotNull = False
        Me.txtFront.ReadOnly = True
        Me.txtFront.ShowDecimal = False
        Me.txtFront.Size = New System.Drawing.Size(167, 29)
        Me.txtFront.TabIndex = 22
        Me.txtFront.TabStop = False
        Me.txtFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel1
        '
        Me.OpeLabel1.AutoSize = True
        Me.OpeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpeLabel1.LabelId = 0
        Me.OpeLabel1.Location = New System.Drawing.Point(37, 75)
        Me.OpeLabel1.Name = "OpeLabel1"
        Me.OpeLabel1.Size = New System.Drawing.Size(59, 24)
        Me.OpeLabel1.TabIndex = 21
        Me.OpeLabel1.Text = "Front"
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
        'clsVTruckDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 519)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVTruckDT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rack in Truck"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpData.ResumeLayout(False)
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
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents txtTruckID As OPE_Controls.OpeTextBox
    Friend WithEvents txtLicense As OPE_Controls.OpeTextBox
    Friend WithEvents txtRackAmount As OPE_Controls.OpeTextBox
    Friend WithEvents lblRackAmount As OPE_Controls.OpeLabel
    Friend WithEvents lblTruckID As OPE_Controls.OpeLabel
    Friend WithEvents lblLicense As OPE_Controls.OpeLabel
    Friend WithEvents txtBPS As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel3 As OPE_Controls.OpeLabel
    Friend WithEvents txtRear As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel2 As OPE_Controls.OpeLabel
    Friend WithEvents txtFront As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel1 As OPE_Controls.OpeLabel
    Friend WithEvents btnCheckAll As OPE_Controls.OpeButtonStrip
    Friend WithEvents btnReleaseAll As OPE_Controls.OpeButtonStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
