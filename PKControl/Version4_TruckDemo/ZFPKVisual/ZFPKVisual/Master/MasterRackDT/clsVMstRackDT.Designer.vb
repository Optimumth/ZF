<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVMstRackDT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVMstRackDT))
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.grdData = New OPE_Controls.opeDataGrid()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.btnSave = New OPE_Controls.OpeButtonSave()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New OPE_Controls.OpeButtonNew()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New OPE_Controls.OpeButtonDeleteDoc()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.txtEndRackID = New OPE_Controls.OpeTextBox()
        Me.OpeLabel1 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtInitialRackID = New OPE_Controls.OpeTextBox()
        Me.OpeLabel2 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtType = New OPE_Controls.OpeTextBox()
        Me.txtModel = New OPE_Controls.OpeTextBox()
        Me.txtEndNo = New OPE_Controls.OpeTextBox()
        Me.Label1 = New OPE_Controls.OpeLabel(Me.components)
        Me.txtInitialNo = New OPE_Controls.OpeTextBox()
        Me.lblRangeNo = New OPE_Controls.OpeLabel(Me.components)
        Me.txtQty = New OPE_Controls.OpeTextBox()
        Me.lblQty = New OPE_Controls.OpeLabel(Me.components)
        Me.txtRemark = New OPE_Controls.OpeTextBox()
        Me.lblRemark = New OPE_Controls.OpeLabel(Me.components)
        Me.txtCode = New OPE_Controls.OpeTextBox()
        Me.lblCode = New OPE_Controls.OpeLabel(Me.components)
        Me.lblType = New OPE_Controls.OpeLabel(Me.components)
        Me.lblModel = New OPE_Controls.OpeLabel(Me.components)
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchCondition.SuspendLayout()
        Me.grpData.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 539)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(879, 22)
        Me.StatusBox.TabIndex = 5
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Me.grdData
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.btnSave, Me.ToolStripSeparator2, Me.btnNew, Me.ToolStripSeparator3, Me.btnDelete})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(879, 39)
        Me.ButtonBoxH.StatusBox = Me.StatusBox
        Me.ButtonBoxH.TabIndex = 4
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
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.grdData.Size = New System.Drawing.Size(863, 336)
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
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.txtEndRackID)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel1)
        Me.grpSearchCondition.Controls.Add(Me.txtInitialRackID)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel2)
        Me.grpSearchCondition.Controls.Add(Me.txtType)
        Me.grpSearchCondition.Controls.Add(Me.txtModel)
        Me.grpSearchCondition.Controls.Add(Me.txtEndNo)
        Me.grpSearchCondition.Controls.Add(Me.Label1)
        Me.grpSearchCondition.Controls.Add(Me.txtInitialNo)
        Me.grpSearchCondition.Controls.Add(Me.lblRangeNo)
        Me.grpSearchCondition.Controls.Add(Me.txtQty)
        Me.grpSearchCondition.Controls.Add(Me.lblQty)
        Me.grpSearchCondition.Controls.Add(Me.txtRemark)
        Me.grpSearchCondition.Controls.Add(Me.lblRemark)
        Me.grpSearchCondition.Controls.Add(Me.txtCode)
        Me.grpSearchCondition.Controls.Add(Me.lblCode)
        Me.grpSearchCondition.Controls.Add(Me.lblType)
        Me.grpSearchCondition.Controls.Add(Me.lblModel)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 39)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(879, 143)
        Me.grpSearchCondition.TabIndex = 6
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Rack Header"
        '
        'txtEndRackID
        '
        Me.txtEndRackID.Add_Comma = False
        Me.txtEndRackID.BackColor = System.Drawing.Color.Empty
        Me.txtEndRackID.DataSource = Nothing
        Me.txtEndRackID.DecimalDigit = 0
        Me.txtEndRackID.DisplayMember = Nothing
        Me.txtEndRackID.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtEndRackID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEndRackID.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtEndRackID.LinkCheckedBox = Nothing
        Me.txtEndRackID.Location = New System.Drawing.Point(704, 80)
        Me.txtEndRackID.MaxValue = 99999.99R
        Me.txtEndRackID.MinValue = -99999.99R
        Me.txtEndRackID.Name = "txtEndRackID"
        Me.txtEndRackID.NotNull = False
        Me.txtEndRackID.ReadOnly = True
        Me.txtEndRackID.ShowDecimal = False
        Me.txtEndRackID.Size = New System.Drawing.Size(102, 23)
        Me.txtEndRackID.TabIndex = 17
        Me.txtEndRackID.TabStop = False
        Me.txtEndRackID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel1
        '
        Me.OpeLabel1.AutoSize = True
        Me.OpeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel1.LabelId = 0
        Me.OpeLabel1.Location = New System.Drawing.Point(685, 83)
        Me.OpeLabel1.Name = "OpeLabel1"
        Me.OpeLabel1.Size = New System.Drawing.Size(13, 17)
        Me.OpeLabel1.TabIndex = 16
        Me.OpeLabel1.Text = "-"
        '
        'txtInitialRackID
        '
        Me.txtInitialRackID.Add_Comma = False
        Me.txtInitialRackID.BackColor = System.Drawing.Color.Empty
        Me.txtInitialRackID.DataSource = Nothing
        Me.txtInitialRackID.DecimalDigit = 0
        Me.txtInitialRackID.DisplayMember = Nothing
        Me.txtInitialRackID.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtInitialRackID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtInitialRackID.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtInitialRackID.LinkCheckedBox = Nothing
        Me.txtInitialRackID.Location = New System.Drawing.Point(575, 80)
        Me.txtInitialRackID.MaxValue = 99999.99R
        Me.txtInitialRackID.MinValue = -99999.99R
        Me.txtInitialRackID.Name = "txtInitialRackID"
        Me.txtInitialRackID.NotNull = False
        Me.txtInitialRackID.ReadOnly = True
        Me.txtInitialRackID.ShowDecimal = False
        Me.txtInitialRackID.Size = New System.Drawing.Size(102, 23)
        Me.txtInitialRackID.TabIndex = 15
        Me.txtInitialRackID.TabStop = False
        Me.txtInitialRackID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpeLabel2
        '
        Me.OpeLabel2.AutoSize = True
        Me.OpeLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel2.LabelId = 0
        Me.OpeLabel2.Location = New System.Drawing.Point(458, 83)
        Me.OpeLabel2.Name = "OpeLabel2"
        Me.OpeLabel2.Size = New System.Drawing.Size(103, 17)
        Me.OpeLabel2.TabIndex = 14
        Me.OpeLabel2.Text = "Rack ID Range"
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
        Me.txtType.Location = New System.Drawing.Point(102, 26)
        Me.txtType.MaxValue = 99999.99R
        Me.txtType.MinValue = -99999.99R
        Me.txtType.Name = "txtType"
        Me.txtType.NotNull = False
        Me.txtType.ReadOnly = True
        Me.txtType.ShowDecimal = False
        Me.txtType.Size = New System.Drawing.Size(313, 23)
        Me.txtType.TabIndex = 1
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
        Me.txtModel.Location = New System.Drawing.Point(102, 53)
        Me.txtModel.MaxValue = 99999.99R
        Me.txtModel.MinValue = -99999.99R
        Me.txtModel.Name = "txtModel"
        Me.txtModel.NotNull = False
        Me.txtModel.ReadOnly = True
        Me.txtModel.ShowDecimal = False
        Me.txtModel.Size = New System.Drawing.Size(313, 23)
        Me.txtModel.TabIndex = 3
        Me.txtModel.TabStop = False
        '
        'txtEndNo
        '
        Me.txtEndNo.Add_Comma = False
        Me.txtEndNo.BackColor = System.Drawing.Color.Empty
        Me.txtEndNo.DataSource = Nothing
        Me.txtEndNo.DecimalDigit = 0
        Me.txtEndNo.DisplayMember = Nothing
        Me.txtEndNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtEndNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEndNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtEndNo.LinkCheckedBox = Nothing
        Me.txtEndNo.Location = New System.Drawing.Point(704, 53)
        Me.txtEndNo.MaxValue = 99999.99R
        Me.txtEndNo.MinValue = -99999.99R
        Me.txtEndNo.Name = "txtEndNo"
        Me.txtEndNo.NotNull = False
        Me.txtEndNo.ReadOnly = True
        Me.txtEndNo.ShowDecimal = False
        Me.txtEndNo.Size = New System.Drawing.Size(102, 23)
        Me.txtEndNo.TabIndex = 13
        Me.txtEndNo.TabStop = False
        Me.txtEndNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.LabelId = 0
        Me.Label1.Location = New System.Drawing.Point(685, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "-"
        '
        'txtInitialNo
        '
        Me.txtInitialNo.Add_Comma = False
        Me.txtInitialNo.BackColor = System.Drawing.Color.Empty
        Me.txtInitialNo.DataSource = Nothing
        Me.txtInitialNo.DecimalDigit = 0
        Me.txtInitialNo.DisplayMember = Nothing
        Me.txtInitialNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtInitialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtInitialNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtInitialNo.LinkCheckedBox = Nothing
        Me.txtInitialNo.Location = New System.Drawing.Point(575, 53)
        Me.txtInitialNo.MaxValue = 99999.99R
        Me.txtInitialNo.MinValue = -99999.99R
        Me.txtInitialNo.Name = "txtInitialNo"
        Me.txtInitialNo.NotNull = False
        Me.txtInitialNo.ReadOnly = True
        Me.txtInitialNo.ShowDecimal = False
        Me.txtInitialNo.Size = New System.Drawing.Size(102, 23)
        Me.txtInitialNo.TabIndex = 11
        Me.txtInitialNo.TabStop = False
        Me.txtInitialNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRangeNo
        '
        Me.lblRangeNo.AutoSize = True
        Me.lblRangeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRangeNo.LabelId = 0
        Me.lblRangeNo.Location = New System.Drawing.Point(458, 56)
        Me.lblRangeNo.Name = "lblRangeNo"
        Me.lblRangeNo.Size = New System.Drawing.Size(107, 17)
        Me.lblRangeNo.TabIndex = 10
        Me.lblRangeNo.Text = "Running Range"
        '
        'txtQty
        '
        Me.txtQty.Add_Comma = False
        Me.txtQty.BackColor = System.Drawing.Color.Empty
        Me.txtQty.DataSource = Nothing
        Me.txtQty.DecimalDigit = 0
        Me.txtQty.DisplayMember = Nothing
        Me.txtQty.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtQty.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtQty.LinkCheckedBox = Nothing
        Me.txtQty.Location = New System.Drawing.Point(575, 26)
        Me.txtQty.MaxValue = 99999.99R
        Me.txtQty.MinValue = -99999.99R
        Me.txtQty.Name = "txtQty"
        Me.txtQty.NotNull = False
        Me.txtQty.ReadOnly = True
        Me.txtQty.ShowDecimal = False
        Me.txtQty.Size = New System.Drawing.Size(231, 23)
        Me.txtQty.TabIndex = 9
        Me.txtQty.TabStop = False
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblQty.LabelId = 0
        Me.lblQty.Location = New System.Drawing.Point(458, 29)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(30, 17)
        Me.lblQty.TabIndex = 8
        Me.lblQty.Text = "Qty"
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
        Me.txtRemark.Location = New System.Drawing.Point(102, 107)
        Me.txtRemark.MaxValue = 99999.99R
        Me.txtRemark.MinValue = -99999.99R
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.NotNull = False
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.ShowDecimal = False
        Me.txtRemark.Size = New System.Drawing.Size(313, 23)
        Me.txtRemark.TabIndex = 7
        Me.txtRemark.TabStop = False
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRemark.LabelId = 0
        Me.lblRemark.Location = New System.Drawing.Point(37, 110)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(57, 17)
        Me.lblRemark.TabIndex = 6
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
        Me.txtCode.Location = New System.Drawing.Point(102, 80)
        Me.txtCode.MaxValue = 99999.99R
        Me.txtCode.MinValue = -99999.99R
        Me.txtCode.Name = "txtCode"
        Me.txtCode.NotNull = False
        Me.txtCode.ReadOnly = True
        Me.txtCode.ShowDecimal = False
        Me.txtCode.Size = New System.Drawing.Size(313, 23)
        Me.txtCode.TabIndex = 5
        Me.txtCode.TabStop = False
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCode.LabelId = 0
        Me.lblCode.Location = New System.Drawing.Point(37, 83)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(41, 17)
        Me.lblCode.TabIndex = 4
        Me.lblCode.Text = "Code"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblType.LabelId = 0
        Me.lblType.Location = New System.Drawing.Point(37, 29)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(40, 17)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Type"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblModel.LabelId = 0
        Me.lblModel.Location = New System.Drawing.Point(37, 56)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(46, 17)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model"
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 182)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(879, 357)
        Me.grpData.TabIndex = 7
        Me.grpData.TabStop = False
        Me.grpData.Text = "Search Result"
        '
        'clsVMstRackDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 561)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVMstRackDT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rack Number"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        Me.grpData.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSave As OPE_Controls.OpeButtonSave
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As OPE_Controls.OpeButtonNew
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As OPE_Controls.OpeButtonDeleteDoc
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents txtEndNo As OPE_Controls.OpeTextBox
    Friend WithEvents Label1 As OPE_Controls.OpeLabel
    Friend WithEvents txtInitialNo As OPE_Controls.OpeTextBox
    Friend WithEvents lblRangeNo As OPE_Controls.OpeLabel
    Friend WithEvents txtQty As OPE_Controls.OpeTextBox
    Friend WithEvents lblQty As OPE_Controls.OpeLabel
    Friend WithEvents txtRemark As OPE_Controls.OpeTextBox
    Friend WithEvents lblRemark As OPE_Controls.OpeLabel
    Friend WithEvents txtCode As OPE_Controls.OpeTextBox
    Friend WithEvents lblCode As OPE_Controls.OpeLabel
    Friend WithEvents lblType As OPE_Controls.OpeLabel
    Friend WithEvents lblModel As OPE_Controls.OpeLabel
    Friend WithEvents txtModel As OPE_Controls.OpeTextBox
    Friend WithEvents txtType As OPE_Controls.OpeTextBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents txtEndRackID As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel1 As OPE_Controls.OpeLabel
    Friend WithEvents txtInitialRackID As OPE_Controls.OpeTextBox
    Friend WithEvents OpeLabel2 As OPE_Controls.OpeLabel
End Class
