<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVTruckBMW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVTruckBMW))
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
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.grpUpdateData = New OPE_Controls.OpeGroupBox()
        Me.txtZFInCharge = New OPE_Controls.OpeTextBox()
        Me.lblZFInCharge = New OPE_Controls.OpeLabel(Me.components)
        Me.chkAxleCompleted = New OPE_Controls.OpeCheckBox(Me.components)
        Me.txtAxleNo = New OPE_Controls.OpeTextBox()
        Me.lblAxleNo = New OPE_Controls.OpeLabel(Me.components)
        Me.txtDeliveryNoteNo = New OPE_Controls.OpeTextBox()
        Me.lblDeliveryNoteNo = New OPE_Controls.OpeLabel(Me.components)
        Me.txtLot = New OPE_Controls.OpeTextBox()
        Me.lblLot = New OPE_Controls.OpeLabel(Me.components)
        Me.txtVarian = New OPE_Controls.OpeTextBox()
        Me.lblVarian = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTel = New OPE_Controls.OpeTextBox()
        Me.lblTel = New OPE_Controls.OpeLabel(Me.components)
        Me.txtDriverName = New OPE_Controls.OpeTextBox()
        Me.lblDriverName = New OPE_Controls.OpeLabel(Me.components)
        Me.txtModel = New OPE_Controls.OpeTextBox()
        Me.lblModel = New OPE_Controls.OpeLabel(Me.components)
        Me.txtRemark = New OPE_Controls.OpeTextBox()
        Me.lblRemark = New OPE_Controls.OpeLabel(Me.components)
        Me.OpeLabel2 = New OPE_Controls.OpeLabel(Me.components)
        Me.dtpDate = New OPE_Controls.OpeDateTime(Me.components)
        Me.txtLicense = New OPE_Controls.OpeTextBox()
        Me.chkPrintFlag = New OPE_Controls.OpeCheckBox(Me.components)
        Me.txtRackAmount = New OPE_Controls.OpeTextBox()
        Me.lblRackAmount = New OPE_Controls.OpeLabel(Me.components)
        Me.lblLicense = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTruckID = New OPE_Controls.OpeTextBox()
        Me.lblTruckID = New OPE_Controls.OpeLabel(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.txtSLicense = New OPE_Controls.OpeTextBox()
        Me.chkSLicense = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSPrintStatus = New OPE_Controls.OpeComboBox2()
        Me.chkSPrintStatus = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSDate = New OPE_Controls.OpeCheckBox(Me.components)
        Me.OpeLabel3 = New OPE_Controls.OpeLabel(Me.components)
        Me.dtpSDate2 = New OPE_Controls.OpeDateTime(Me.components)
        Me.dtpSDate1 = New OPE_Controls.OpeDateTime(Me.components)
        Me.txtSTruckID = New OPE_Controls.OpeTextBox()
        Me.chkSTruckID = New OPE_Controls.OpeCheckBox(Me.components)
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtCusInCharge = New OPE_Controls.OpeTextBox()
        Me.lblCusInCharge = New OPE_Controls.OpeLabel(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpData.SuspendLayout()
        Me.grpUpdateData.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpSearchCondition.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Me.grdData
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.ToolStripSeparator1, Me.btnSave, Me.ToolStripSeparator2, Me.btnNew, Me.btnEdit, Me.ToolStripSeparator3, Me.btnDelete, Me.ToolStripSeparator4})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(1380, 39)
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
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
        Me.grdData.Size = New System.Drawing.Size(1364, 294)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 653)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(1380, 22)
        Me.StatusBox.TabIndex = 5
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 116)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1380, 315)
        Me.grpData.TabIndex = 2
        Me.grpData.TabStop = False
        Me.grpData.Text = "Search Result"
        '
        'grpUpdateData
        '
        Me.grpUpdateData.Controls.Add(Me.txtCusInCharge)
        Me.grpUpdateData.Controls.Add(Me.lblCusInCharge)
        Me.grpUpdateData.Controls.Add(Me.txtZFInCharge)
        Me.grpUpdateData.Controls.Add(Me.lblZFInCharge)
        Me.grpUpdateData.Controls.Add(Me.chkAxleCompleted)
        Me.grpUpdateData.Controls.Add(Me.txtAxleNo)
        Me.grpUpdateData.Controls.Add(Me.lblAxleNo)
        Me.grpUpdateData.Controls.Add(Me.txtDeliveryNoteNo)
        Me.grpUpdateData.Controls.Add(Me.lblDeliveryNoteNo)
        Me.grpUpdateData.Controls.Add(Me.txtLot)
        Me.grpUpdateData.Controls.Add(Me.lblLot)
        Me.grpUpdateData.Controls.Add(Me.txtVarian)
        Me.grpUpdateData.Controls.Add(Me.lblVarian)
        Me.grpUpdateData.Controls.Add(Me.txtTel)
        Me.grpUpdateData.Controls.Add(Me.lblTel)
        Me.grpUpdateData.Controls.Add(Me.txtDriverName)
        Me.grpUpdateData.Controls.Add(Me.lblDriverName)
        Me.grpUpdateData.Controls.Add(Me.txtModel)
        Me.grpUpdateData.Controls.Add(Me.lblModel)
        Me.grpUpdateData.Controls.Add(Me.txtRemark)
        Me.grpUpdateData.Controls.Add(Me.lblRemark)
        Me.grpUpdateData.Controls.Add(Me.OpeLabel2)
        Me.grpUpdateData.Controls.Add(Me.dtpDate)
        Me.grpUpdateData.Controls.Add(Me.txtLicense)
        Me.grpUpdateData.Controls.Add(Me.chkPrintFlag)
        Me.grpUpdateData.Controls.Add(Me.txtRackAmount)
        Me.grpUpdateData.Controls.Add(Me.lblRackAmount)
        Me.grpUpdateData.Controls.Add(Me.lblLicense)
        Me.grpUpdateData.Controls.Add(Me.txtTruckID)
        Me.grpUpdateData.Controls.Add(Me.lblTruckID)
        Me.grpUpdateData.Controls.Add(Me.Panel1)
        Me.grpUpdateData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpUpdateData.Location = New System.Drawing.Point(0, 431)
        Me.grpUpdateData.Name = "grpUpdateData"
        Me.grpUpdateData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpUpdateData.Size = New System.Drawing.Size(1380, 222)
        Me.grpUpdateData.TabIndex = 3
        Me.grpUpdateData.TabStop = False
        '
        'txtZFInCharge
        '
        Me.txtZFInCharge.Add_Comma = False
        Me.txtZFInCharge.DataSource = Nothing
        Me.txtZFInCharge.DecimalDigit = 2
        Me.txtZFInCharge.DisplayMember = Nothing
        Me.txtZFInCharge.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtZFInCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtZFInCharge.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtZFInCharge.LinkCheckedBox = Nothing
        Me.txtZFInCharge.Location = New System.Drawing.Point(180, 180)
        Me.txtZFInCharge.MaxValue = 99999.99R
        Me.txtZFInCharge.MinValue = -99999.99R
        Me.txtZFInCharge.Name = "txtZFInCharge"
        Me.txtZFInCharge.NotNull = False
        Me.txtZFInCharge.ShowDecimal = False
        Me.txtZFInCharge.Size = New System.Drawing.Size(185, 23)
        Me.txtZFInCharge.TabIndex = 28
        '
        'lblZFInCharge
        '
        Me.lblZFInCharge.AutoSize = True
        Me.lblZFInCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblZFInCharge.LabelId = 0
        Me.lblZFInCharge.Location = New System.Drawing.Point(34, 183)
        Me.lblZFInCharge.Name = "lblZFInCharge"
        Me.lblZFInCharge.Size = New System.Drawing.Size(88, 17)
        Me.lblZFInCharge.TabIndex = 27
        Me.lblZFInCharge.Text = "ZF in charge"
        '
        'chkAxleCompleted
        '
        Me.chkAxleCompleted.AutoSize = True
        Me.chkAxleCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkAxleCompleted.Location = New System.Drawing.Point(785, 181)
        Me.chkAxleCompleted.Name = "chkAxleCompleted"
        Me.chkAxleCompleted.Size = New System.Drawing.Size(98, 21)
        Me.chkAxleCompleted.TabIndex = 31
        Me.chkAxleCompleted.Text = "Axle สมบูรณ์"
        Me.chkAxleCompleted.UseVisualStyleBackColor = True
        '
        'txtAxleNo
        '
        Me.txtAxleNo.Add_Comma = False
        Me.txtAxleNo.DataSource = Nothing
        Me.txtAxleNo.DecimalDigit = 2
        Me.txtAxleNo.DisplayMember = Nothing
        Me.txtAxleNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtAxleNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtAxleNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtAxleNo.LinkCheckedBox = Nothing
        Me.txtAxleNo.Location = New System.Drawing.Point(698, 86)
        Me.txtAxleNo.MaxValue = 99999.99R
        Me.txtAxleNo.MinValue = -99999.99R
        Me.txtAxleNo.Name = "txtAxleNo"
        Me.txtAxleNo.NotNull = False
        Me.txtAxleNo.ShowDecimal = False
        Me.txtAxleNo.Size = New System.Drawing.Size(185, 23)
        Me.txtAxleNo.TabIndex = 20
        '
        'lblAxleNo
        '
        Me.lblAxleNo.AutoSize = True
        Me.lblAxleNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAxleNo.LabelId = 0
        Me.lblAxleNo.Location = New System.Drawing.Point(604, 89)
        Me.lblAxleNo.Name = "lblAxleNo"
        Me.lblAxleNo.Size = New System.Drawing.Size(60, 17)
        Me.lblAxleNo.TabIndex = 19
        Me.lblAxleNo.Text = "Axle No."
        '
        'txtDeliveryNoteNo
        '
        Me.txtDeliveryNoteNo.Add_Comma = False
        Me.txtDeliveryNoteNo.DataSource = Nothing
        Me.txtDeliveryNoteNo.DecimalDigit = 2
        Me.txtDeliveryNoteNo.DisplayMember = Nothing
        Me.txtDeliveryNoteNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtDeliveryNoteNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDeliveryNoteNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtDeliveryNoteNo.LinkCheckedBox = Nothing
        Me.txtDeliveryNoteNo.Location = New System.Drawing.Point(180, 86)
        Me.txtDeliveryNoteNo.MaxValue = 99999.99R
        Me.txtDeliveryNoteNo.MinValue = -99999.99R
        Me.txtDeliveryNoteNo.Name = "txtDeliveryNoteNo"
        Me.txtDeliveryNoteNo.NotNull = False
        Me.txtDeliveryNoteNo.ShowDecimal = False
        Me.txtDeliveryNoteNo.Size = New System.Drawing.Size(383, 23)
        Me.txtDeliveryNoteNo.TabIndex = 18
        '
        'lblDeliveryNoteNo
        '
        Me.lblDeliveryNoteNo.AutoSize = True
        Me.lblDeliveryNoteNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDeliveryNoteNo.LabelId = 0
        Me.lblDeliveryNoteNo.Location = New System.Drawing.Point(34, 89)
        Me.lblDeliveryNoteNo.Name = "lblDeliveryNoteNo"
        Me.lblDeliveryNoteNo.Size = New System.Drawing.Size(119, 17)
        Me.lblDeliveryNoteNo.TabIndex = 17
        Me.lblDeliveryNoteNo.Text = "Delivery Note No."
        '
        'txtLot
        '
        Me.txtLot.Add_Comma = False
        Me.txtLot.DataSource = Nothing
        Me.txtLot.DecimalDigit = 2
        Me.txtLot.DisplayMember = Nothing
        Me.txtLot.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLot.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtLot.LinkCheckedBox = Nothing
        Me.txtLot.Location = New System.Drawing.Point(698, 55)
        Me.txtLot.MaxValue = 99999.99R
        Me.txtLot.MinValue = -99999.99R
        Me.txtLot.Name = "txtLot"
        Me.txtLot.NotNull = False
        Me.txtLot.ShowDecimal = False
        Me.txtLot.Size = New System.Drawing.Size(185, 23)
        Me.txtLot.TabIndex = 16
        '
        'lblLot
        '
        Me.lblLot.AutoSize = True
        Me.lblLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLot.LabelId = 0
        Me.lblLot.Location = New System.Drawing.Point(604, 58)
        Me.lblLot.Name = "lblLot"
        Me.lblLot.Size = New System.Drawing.Size(28, 17)
        Me.lblLot.TabIndex = 15
        Me.lblLot.Text = "Lot"
        '
        'txtVarian
        '
        Me.txtVarian.Add_Comma = False
        Me.txtVarian.DataSource = Nothing
        Me.txtVarian.DecimalDigit = 2
        Me.txtVarian.DisplayMember = Nothing
        Me.txtVarian.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtVarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtVarian.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtVarian.LinkCheckedBox = Nothing
        Me.txtVarian.Location = New System.Drawing.Point(386, 55)
        Me.txtVarian.MaxValue = 99999.99R
        Me.txtVarian.MinValue = -99999.99R
        Me.txtVarian.Name = "txtVarian"
        Me.txtVarian.NotNull = False
        Me.txtVarian.ShowDecimal = False
        Me.txtVarian.Size = New System.Drawing.Size(177, 23)
        Me.txtVarian.TabIndex = 14
        '
        'lblVarian
        '
        Me.lblVarian.AutoSize = True
        Me.lblVarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblVarian.LabelId = 0
        Me.lblVarian.Location = New System.Drawing.Point(323, 58)
        Me.lblVarian.Name = "lblVarian"
        Me.lblVarian.Size = New System.Drawing.Size(49, 17)
        Me.lblVarian.TabIndex = 13
        Me.lblVarian.Text = "Varian"
        '
        'txtTel
        '
        Me.txtTel.Add_Comma = False
        Me.txtTel.DataSource = Nothing
        Me.txtTel.DecimalDigit = 2
        Me.txtTel.DisplayMember = Nothing
        Me.txtTel.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTel.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtTel.LinkCheckedBox = Nothing
        Me.txtTel.Location = New System.Drawing.Point(554, 149)
        Me.txtTel.MaxValue = 99999.99R
        Me.txtTel.MinValue = -99999.99R
        Me.txtTel.Name = "txtTel"
        Me.txtTel.NotNull = False
        Me.txtTel.ShowDecimal = False
        Me.txtTel.Size = New System.Drawing.Size(185, 23)
        Me.txtTel.TabIndex = 26
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTel.LabelId = 0
        Me.lblTel.Location = New System.Drawing.Point(410, 152)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(28, 17)
        Me.lblTel.TabIndex = 25
        Me.lblTel.Text = "Tel"
        '
        'txtDriverName
        '
        Me.txtDriverName.Add_Comma = False
        Me.txtDriverName.DataSource = Nothing
        Me.txtDriverName.DecimalDigit = 2
        Me.txtDriverName.DisplayMember = Nothing
        Me.txtDriverName.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtDriverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDriverName.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtDriverName.LinkCheckedBox = Nothing
        Me.txtDriverName.Location = New System.Drawing.Point(180, 149)
        Me.txtDriverName.MaxValue = 99999.99R
        Me.txtDriverName.MinValue = -99999.99R
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.NotNull = False
        Me.txtDriverName.ShowDecimal = False
        Me.txtDriverName.Size = New System.Drawing.Size(185, 23)
        Me.txtDriverName.TabIndex = 24
        '
        'lblDriverName
        '
        Me.lblDriverName.AutoSize = True
        Me.lblDriverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDriverName.LabelId = 0
        Me.lblDriverName.Location = New System.Drawing.Point(34, 152)
        Me.lblDriverName.Name = "lblDriverName"
        Me.lblDriverName.Size = New System.Drawing.Size(87, 17)
        Me.lblDriverName.TabIndex = 23
        Me.lblDriverName.Text = "Driver Name"
        '
        'txtModel
        '
        Me.txtModel.Add_Comma = False
        Me.txtModel.DataSource = Nothing
        Me.txtModel.DecimalDigit = 2
        Me.txtModel.DisplayMember = Nothing
        Me.txtModel.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtModel.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtModel.LinkCheckedBox = Nothing
        Me.txtModel.Location = New System.Drawing.Point(97, 55)
        Me.txtModel.MaxValue = 99999.99R
        Me.txtModel.MinValue = -99999.99R
        Me.txtModel.Name = "txtModel"
        Me.txtModel.NotNull = False
        Me.txtModel.ShowDecimal = False
        Me.txtModel.Size = New System.Drawing.Size(185, 23)
        Me.txtModel.TabIndex = 12
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblModel.LabelId = 0
        Me.lblModel.Location = New System.Drawing.Point(34, 58)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(46, 17)
        Me.lblModel.TabIndex = 11
        Me.lblModel.Text = "Model"
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
        Me.txtRemark.Location = New System.Drawing.Point(180, 117)
        Me.txtRemark.MaxValue = 99999.99R
        Me.txtRemark.MinValue = -99999.99R
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.NotNull = False
        Me.txtRemark.ShowDecimal = False
        Me.txtRemark.Size = New System.Drawing.Size(703, 23)
        Me.txtRemark.TabIndex = 22
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRemark.LabelId = 0
        Me.lblRemark.Location = New System.Drawing.Point(34, 120)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(57, 17)
        Me.lblRemark.TabIndex = 21
        Me.lblRemark.Text = "Remark"
        '
        'OpeLabel2
        '
        Me.OpeLabel2.AutoSize = True
        Me.OpeLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel2.LabelId = 0
        Me.OpeLabel2.Location = New System.Drawing.Point(939, 27)
        Me.OpeLabel2.Name = "OpeLabel2"
        Me.OpeLabel2.Size = New System.Drawing.Size(70, 17)
        Me.OpeLabel2.TabIndex = 6
        Me.OpeLabel2.Text = "Ship Date"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.HideButton = False
        Me.dtpDate.LinkCheckedBox = Nothing
        Me.dtpDate.LinkDateTime = Nothing
        Me.dtpDate.Location = New System.Drawing.Point(1019, 24)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(93, 23)
        Me.dtpDate.TabIndex = 7
        Me.dtpDate.TextValue = "20180530"
        Me.dtpDate.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'txtLicense
        '
        Me.txtLicense.Add_Comma = False
        Me.txtLicense.DataSource = Nothing
        Me.txtLicense.DecimalDigit = 2
        Me.txtLicense.DisplayMember = Nothing
        Me.txtLicense.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtLicense.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtLicense.LinkCheckedBox = Nothing
        Me.txtLicense.Location = New System.Drawing.Point(386, 24)
        Me.txtLicense.MaxValue = 99999.99R
        Me.txtLicense.MinValue = -99999.99R
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.NotNull = False
        Me.txtLicense.ShowDecimal = False
        Me.txtLicense.Size = New System.Drawing.Size(177, 23)
        Me.txtLicense.TabIndex = 3
        '
        'chkPrintFlag
        '
        Me.chkPrintFlag.AutoSize = True
        Me.chkPrintFlag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkPrintFlag.Location = New System.Drawing.Point(939, 56)
        Me.chkPrintFlag.Name = "chkPrintFlag"
        Me.chkPrintFlag.Size = New System.Drawing.Size(72, 21)
        Me.chkPrintFlag.TabIndex = 8
        Me.chkPrintFlag.Text = "Printed"
        Me.chkPrintFlag.UseVisualStyleBackColor = True
        '
        'txtRackAmount
        '
        Me.txtRackAmount.Add_Comma = False
        Me.txtRackAmount.BackColor = System.Drawing.Color.Empty
        Me.txtRackAmount.DataSource = Nothing
        Me.txtRackAmount.DecimalDigit = 0
        Me.txtRackAmount.DisplayMember = Nothing
        Me.txtRackAmount.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRackAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtRackAmount.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtRackAmount.LinkCheckedBox = Nothing
        Me.txtRackAmount.Location = New System.Drawing.Point(698, 24)
        Me.txtRackAmount.MaxValue = 99999.99R
        Me.txtRackAmount.MinValue = -99999.99R
        Me.txtRackAmount.Name = "txtRackAmount"
        Me.txtRackAmount.NotNull = False
        Me.txtRackAmount.ReadOnly = True
        Me.txtRackAmount.ShowDecimal = False
        Me.txtRackAmount.Size = New System.Drawing.Size(185, 23)
        Me.txtRackAmount.TabIndex = 5
        Me.txtRackAmount.TabStop = False
        Me.txtRackAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRackAmount
        '
        Me.lblRackAmount.AutoSize = True
        Me.lblRackAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblRackAmount.LabelId = 0
        Me.lblRackAmount.Location = New System.Drawing.Point(604, 27)
        Me.lblRackAmount.Name = "lblRackAmount"
        Me.lblRackAmount.Size = New System.Drawing.Size(92, 17)
        Me.lblRackAmount.TabIndex = 4
        Me.lblRackAmount.Text = "Rack Amount"
        '
        'lblLicense
        '
        Me.lblLicense.AutoSize = True
        Me.lblLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLicense.LabelId = 0
        Me.lblLicense.Location = New System.Drawing.Point(323, 27)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(61, 17)
        Me.lblLicense.TabIndex = 2
        Me.lblLicense.Text = "Truck ID"
        '
        'txtTruckID
        '
        Me.txtTruckID.Add_Comma = False
        Me.txtTruckID.BackColor = System.Drawing.Color.MistyRose
        Me.txtTruckID.DataSource = Nothing
        Me.txtTruckID.DecimalDigit = 2
        Me.txtTruckID.DisplayMember = Nothing
        Me.txtTruckID.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTruckID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtTruckID.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtTruckID.LinkCheckedBox = Nothing
        Me.txtTruckID.Location = New System.Drawing.Point(97, 24)
        Me.txtTruckID.MaxValue = 99999.99R
        Me.txtTruckID.MinValue = -99999.99R
        Me.txtTruckID.Name = "txtTruckID"
        Me.txtTruckID.NotNull = False
        Me.txtTruckID.ReadOnly = True
        Me.txtTruckID.ShowDecimal = False
        Me.txtTruckID.Size = New System.Drawing.Size(185, 23)
        Me.txtTruckID.TabIndex = 1
        Me.txtTruckID.TabStop = False
        '
        'lblTruckID
        '
        Me.lblTruckID.AutoSize = True
        Me.lblTruckID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTruckID.LabelId = 0
        Me.lblTruckID.Location = New System.Drawing.Point(34, 27)
        Me.lblTruckID.Name = "lblTruckID"
        Me.lblTruckID.Size = New System.Drawing.Size(21, 17)
        Me.lblTruckID.TabIndex = 0
        Me.lblTruckID.Text = "ID"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Location = New System.Drawing.Point(1272, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(50, 98)
        Me.Panel1.TabIndex = 25
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
        Me.grpSearchCondition.Controls.Add(Me.txtSLicense)
        Me.grpSearchCondition.Controls.Add(Me.chkSLicense)
        Me.grpSearchCondition.Controls.Add(Me.cboSPrintStatus)
        Me.grpSearchCondition.Controls.Add(Me.chkSPrintStatus)
        Me.grpSearchCondition.Controls.Add(Me.chkSDate)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel3)
        Me.grpSearchCondition.Controls.Add(Me.dtpSDate2)
        Me.grpSearchCondition.Controls.Add(Me.dtpSDate1)
        Me.grpSearchCondition.Controls.Add(Me.txtSTruckID)
        Me.grpSearchCondition.Controls.Add(Me.chkSTruckID)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 39)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(1380, 77)
        Me.grpSearchCondition.TabIndex = 1
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'txtSLicense
        '
        Me.txtSLicense.Add_Comma = False
        Me.txtSLicense.DataSource = Nothing
        Me.txtSLicense.DecimalDigit = 2
        Me.txtSLicense.DisplayMember = Nothing
        Me.txtSLicense.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSLicense.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtSLicense.LinkCheckedBox = Nothing
        Me.txtSLicense.Location = New System.Drawing.Point(782, 27)
        Me.txtSLicense.MaxValue = 99999.99R
        Me.txtSLicense.MinValue = -99999.99R
        Me.txtSLicense.Name = "txtSLicense"
        Me.txtSLicense.NotNull = False
        Me.txtSLicense.ShowDecimal = False
        Me.txtSLicense.Size = New System.Drawing.Size(141, 23)
        Me.txtSLicense.TabIndex = 16
        '
        'chkSLicense
        '
        Me.chkSLicense.AutoSize = True
        Me.chkSLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSLicense.Location = New System.Drawing.Point(697, 28)
        Me.chkSLicense.Name = "chkSLicense"
        Me.chkSLicense.Size = New System.Drawing.Size(80, 21)
        Me.chkSLicense.TabIndex = 15
        Me.chkSLicense.Text = "Truck ID"
        Me.chkSLicense.UseVisualStyleBackColor = True
        '
        'cboSPrintStatus
        '
        Me.cboSPrintStatus.BackColor = System.Drawing.Color.White
        Me.cboSPrintStatus.Busy = True
        Me.cboSPrintStatus.DataSource = Nothing
        Me.cboSPrintStatus.DisplayMember = ""
        Me.cboSPrintStatus.DisplayMemberLength = Nothing
        Me.cboSPrintStatus.DisplayMemberList = ""
        Me.cboSPrintStatus.DisplayMemberText = Nothing
        Me.cboSPrintStatus.DisplayMemberText2 = Nothing
        Me.cboSPrintStatus.DisplayMemberText3 = Nothing
        Me.cboSPrintStatus.DisplayShowButton = False
        Me.cboSPrintStatus.DropDownList = False
        Me.cboSPrintStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSPrintStatus.ForeColor = System.Drawing.Color.Black
        Me.cboSPrintStatus.IsTextBox = False
        Me.cboSPrintStatus.LinkCheck = Nothing
        Me.cboSPrintStatus.LinkCheckedBox = Nothing
        Me.cboSPrintStatus.LinkTextBox = Nothing
        Me.cboSPrintStatus.LinkTextBox2 = Nothing
        Me.cboSPrintStatus.LinkTextBox3 = Nothing
        Me.cboSPrintStatus.Location = New System.Drawing.Point(1106, 27)
        Me.cboSPrintStatus.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSPrintStatus.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSPrintStatus.MaxLength = 32767
        Me.cboSPrintStatus.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSPrintStatus.Name = "cboSPrintStatus"
        Me.cboSPrintStatus.NotNull = False
        Me.cboSPrintStatus.RefreshWidth = False
        Me.cboSPrintStatus.RowFilter = ""
        Me.cboSPrintStatus.SelectedIndex = -1
        Me.cboSPrintStatus.SelectedValue = Nothing
        Me.cboSPrintStatus.Size = New System.Drawing.Size(182, 23)
        Me.cboSPrintStatus.TabIndex = 14
        Me.cboSPrintStatus.ValueMember = ""
        '
        'chkSPrintStatus
        '
        Me.chkSPrintStatus.AutoSize = True
        Me.chkSPrintStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSPrintStatus.Location = New System.Drawing.Point(993, 28)
        Me.chkSPrintStatus.Name = "chkSPrintStatus"
        Me.chkSPrintStatus.Size = New System.Drawing.Size(100, 21)
        Me.chkSPrintStatus.TabIndex = 6
        Me.chkSPrintStatus.Text = "Print Status"
        Me.chkSPrintStatus.UseVisualStyleBackColor = True
        '
        'chkSDate
        '
        Me.chkSDate.AutoSize = True
        Me.chkSDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSDate.Location = New System.Drawing.Point(26, 28)
        Me.chkSDate.Name = "chkSDate"
        Me.chkSDate.Size = New System.Drawing.Size(89, 21)
        Me.chkSDate.TabIndex = 0
        Me.chkSDate.Text = "Ship Date"
        Me.chkSDate.UseVisualStyleBackColor = True
        '
        'OpeLabel3
        '
        Me.OpeLabel3.AutoSize = True
        Me.OpeLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel3.LabelId = 0
        Me.OpeLabel3.Location = New System.Drawing.Point(213, 30)
        Me.OpeLabel3.Name = "OpeLabel3"
        Me.OpeLabel3.Size = New System.Drawing.Size(16, 17)
        Me.OpeLabel3.TabIndex = 2
        Me.OpeLabel3.Text = "~"
        '
        'dtpSDate2
        '
        Me.dtpSDate2.CustomFormat = "dd/MM/yyyy"
        Me.dtpSDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpSDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSDate2.HideButton = False
        Me.dtpSDate2.LinkCheckedBox = Nothing
        Me.dtpSDate2.LinkDateTime = Nothing
        Me.dtpSDate2.Location = New System.Drawing.Point(232, 27)
        Me.dtpSDate2.Name = "dtpSDate2"
        Me.dtpSDate2.Size = New System.Drawing.Size(93, 23)
        Me.dtpSDate2.TabIndex = 3
        Me.dtpSDate2.TextValue = "20180530"
        Me.dtpSDate2.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'dtpSDate1
        '
        Me.dtpSDate1.CustomFormat = "dd/MM/yyyy"
        Me.dtpSDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpSDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSDate1.HideButton = False
        Me.dtpSDate1.LinkCheckedBox = Nothing
        Me.dtpSDate1.LinkDateTime = Nothing
        Me.dtpSDate1.Location = New System.Drawing.Point(118, 27)
        Me.dtpSDate1.Name = "dtpSDate1"
        Me.dtpSDate1.Size = New System.Drawing.Size(93, 23)
        Me.dtpSDate1.TabIndex = 1
        Me.dtpSDate1.TextValue = "20180530"
        Me.dtpSDate1.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'txtSTruckID
        '
        Me.txtSTruckID.Add_Comma = False
        Me.txtSTruckID.DataSource = Nothing
        Me.txtSTruckID.DecimalDigit = 2
        Me.txtSTruckID.DisplayMember = Nothing
        Me.txtSTruckID.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSTruckID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSTruckID.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtSTruckID.LinkCheckedBox = Nothing
        Me.txtSTruckID.Location = New System.Drawing.Point(488, 27)
        Me.txtSTruckID.MaxValue = 99999.99R
        Me.txtSTruckID.MinValue = -99999.99R
        Me.txtSTruckID.Name = "txtSTruckID"
        Me.txtSTruckID.NotNull = False
        Me.txtSTruckID.ShowDecimal = False
        Me.txtSTruckID.Size = New System.Drawing.Size(141, 23)
        Me.txtSTruckID.TabIndex = 5
        '
        'chkSTruckID
        '
        Me.chkSTruckID.AutoSize = True
        Me.chkSTruckID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSTruckID.Location = New System.Drawing.Point(404, 28)
        Me.chkSTruckID.Name = "chkSTruckID"
        Me.chkSTruckID.Size = New System.Drawing.Size(40, 21)
        Me.chkSTruckID.TabIndex = 4
        Me.chkSTruckID.Text = "ID"
        Me.chkSTruckID.UseVisualStyleBackColor = True
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'txtCusInCharge
        '
        Me.txtCusInCharge.Add_Comma = False
        Me.txtCusInCharge.DataSource = Nothing
        Me.txtCusInCharge.DecimalDigit = 2
        Me.txtCusInCharge.DisplayMember = Nothing
        Me.txtCusInCharge.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtCusInCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCusInCharge.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtCusInCharge.LinkCheckedBox = Nothing
        Me.txtCusInCharge.Location = New System.Drawing.Point(554, 180)
        Me.txtCusInCharge.MaxValue = 99999.99R
        Me.txtCusInCharge.MinValue = -99999.99R
        Me.txtCusInCharge.Name = "txtCusInCharge"
        Me.txtCusInCharge.NotNull = False
        Me.txtCusInCharge.ShowDecimal = False
        Me.txtCusInCharge.Size = New System.Drawing.Size(185, 23)
        Me.txtCusInCharge.TabIndex = 30
        '
        'lblCusInCharge
        '
        Me.lblCusInCharge.AutoSize = True
        Me.lblCusInCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCusInCharge.LabelId = 0
        Me.lblCusInCharge.Location = New System.Drawing.Point(410, 183)
        Me.lblCusInCharge.Name = "lblCusInCharge"
        Me.lblCusInCharge.Size = New System.Drawing.Size(131, 17)
        Me.lblCusInCharge.TabIndex = 29
        Me.lblCusInCharge.Text = "Customer in charge"
        '
        'clsVTruckBMW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 675)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpUpdateData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVTruckBMW"
        Me.Text = "Truck"
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
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As OPE_Controls.OpeButtonSave
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As OPE_Controls.OpeButtonNew
    Friend WithEvents btnEdit As OPE_Controls.OpeButtonEdit
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As OPE_Controls.OpeButtonDeleteDoc
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents grpUpdateData As OPE_Controls.OpeGroupBox
    Friend WithEvents lblLicense As OPE_Controls.OpeLabel
    Friend WithEvents txtTruckID As OPE_Controls.OpeTextBox
    Friend WithEvents lblTruckID As OPE_Controls.OpeLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents txtSTruckID As OPE_Controls.OpeTextBox
    Friend WithEvents chkSTruckID As OPE_Controls.OpeCheckBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkSDate As OPE_Controls.OpeCheckBox
    Friend WithEvents OpeLabel3 As OPE_Controls.OpeLabel
    Friend WithEvents dtpSDate2 As OPE_Controls.OpeDateTime
    Friend WithEvents dtpSDate1 As OPE_Controls.OpeDateTime
    Friend WithEvents txtRackAmount As OPE_Controls.OpeTextBox
    Friend WithEvents lblRackAmount As OPE_Controls.OpeLabel
    Friend WithEvents chkSPrintStatus As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSPrintStatus As OPE_Controls.OpeComboBox2
    Friend WithEvents chkPrintFlag As OPE_Controls.OpeCheckBox
    Friend WithEvents txtLicense As OPE_Controls.OpeTextBox
    Friend WithEvents txtSLicense As OPE_Controls.OpeTextBox
    Friend WithEvents chkSLicense As OPE_Controls.OpeCheckBox
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents OpeLabel2 As OPE_Controls.OpeLabel
    Friend WithEvents dtpDate As OPE_Controls.OpeDateTime
    Friend WithEvents txtRemark As OPE_Controls.OpeTextBox
    Friend WithEvents lblRemark As OPE_Controls.OpeLabel
    Friend WithEvents txtAxleNo As OPE_Controls.OpeTextBox
    Friend WithEvents lblAxleNo As OPE_Controls.OpeLabel
    Friend WithEvents txtDeliveryNoteNo As OPE_Controls.OpeTextBox
    Friend WithEvents lblDeliveryNoteNo As OPE_Controls.OpeLabel
    Friend WithEvents txtLot As OPE_Controls.OpeTextBox
    Friend WithEvents lblLot As OPE_Controls.OpeLabel
    Friend WithEvents txtVarian As OPE_Controls.OpeTextBox
    Friend WithEvents lblVarian As OPE_Controls.OpeLabel
    Friend WithEvents txtModel As OPE_Controls.OpeTextBox
    Friend WithEvents lblModel As OPE_Controls.OpeLabel
    Friend WithEvents chkAxleCompleted As OPE_Controls.OpeCheckBox
    Friend WithEvents txtZFInCharge As OPE_Controls.OpeTextBox
    Friend WithEvents lblZFInCharge As OPE_Controls.OpeLabel
    Friend WithEvents txtTel As OPE_Controls.OpeTextBox
    Friend WithEvents lblTel As OPE_Controls.OpeLabel
    Friend WithEvents txtDriverName As OPE_Controls.OpeTextBox
    Friend WithEvents lblDriverName As OPE_Controls.OpeLabel
    Friend WithEvents txtCusInCharge As OPE_Controls.OpeTextBox
    Friend WithEvents lblCusInCharge As OPE_Controls.OpeLabel
End Class
