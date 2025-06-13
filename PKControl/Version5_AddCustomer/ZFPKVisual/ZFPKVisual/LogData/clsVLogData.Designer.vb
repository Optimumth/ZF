<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVLogData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVLogData))
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.grdData = New OPE_Controls.opeDataGrid()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCheckAll = New OPE_Controls.OpeButtonStrip()
        Me.btnReleaseAll = New OPE_Controls.OpeButtonStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New OPE_Controls.OpeButtonPrint()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.chkSumDate = New OPE_Controls.OpeCheckBox(Me.components)
        Me.lblOutLogPath = New OPE_Controls.OpeLabel(Me.components)
        Me.txtOutLogPath = New OPE_Controls.OpeTextBox()
        Me.chkLogDate = New OPE_Controls.OpeCheckBox(Me.components)
        Me.OpeLabel3 = New OPE_Controls.OpeLabel(Me.components)
        Me.dtpDate2 = New OPE_Controls.OpeDateTime(Me.components)
        Me.dtpDate1 = New OPE_Controls.OpeDateTime(Me.components)
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.btnLogo = New System.Windows.Forms.ToolStripButton()
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchCondition.SuspendLayout()
        Me.grpData.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 350)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(834, 22)
        Me.StatusBox.TabIndex = 8
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Me.grdData
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.ToolStripSeparator1, Me.btnCheckAll, Me.btnReleaseAll, Me.ToolStripSeparator2, Me.btnPrint, Me.btnLogo})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(834, 57)
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
        Me.grdData.Size = New System.Drawing.Size(818, 179)
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
        'btnCheckAll
        '
        Me.btnCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCheckAll.Image = CType(resources.GetObject("btnCheckAll.Image"), System.Drawing.Image)
        Me.btnCheckAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(36, 54)
        Me.btnCheckAll.Text = "Select All"
        '
        'btnReleaseAll
        '
        Me.btnReleaseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReleaseAll.Image = CType(resources.GetObject("btnReleaseAll.Image"), System.Drawing.Image)
        Me.btnReleaseAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReleaseAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReleaseAll.Name = "btnReleaseAll"
        Me.btnReleaseAll.Size = New System.Drawing.Size(36, 54)
        Me.btnReleaseAll.Text = "Release All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 57)
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.EnableOnly = False
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(36, 54)
        Me.btnPrint.Text = "Print"
        Me.btnPrint.ToolTipText = "Print"
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.chkSumDate)
        Me.grpSearchCondition.Controls.Add(Me.lblOutLogPath)
        Me.grpSearchCondition.Controls.Add(Me.txtOutLogPath)
        Me.grpSearchCondition.Controls.Add(Me.chkLogDate)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel3)
        Me.grpSearchCondition.Controls.Add(Me.dtpDate2)
        Me.grpSearchCondition.Controls.Add(Me.dtpDate1)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 57)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(834, 93)
        Me.grpSearchCondition.TabIndex = 1
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'chkSumDate
        '
        Me.chkSumDate.AutoSize = True
        Me.chkSumDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSumDate.Location = New System.Drawing.Point(375, 28)
        Me.chkSumDate.Name = "chkSumDate"
        Me.chkSumDate.Size = New System.Drawing.Size(86, 21)
        Me.chkSumDate.TabIndex = 4
        Me.chkSumDate.Text = "Summary"
        Me.chkSumDate.UseVisualStyleBackColor = True
        '
        'lblOutLogPath
        '
        Me.lblOutLogPath.AutoSize = True
        Me.lblOutLogPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblOutLogPath.LabelId = 0
        Me.lblOutLogPath.Location = New System.Drawing.Point(22, 59)
        Me.lblOutLogPath.Name = "lblOutLogPath"
        Me.lblOutLogPath.Size = New System.Drawing.Size(92, 17)
        Me.lblOutLogPath.TabIndex = 5
        Me.lblOutLogPath.Text = "Out Log Path"
        '
        'txtOutLogPath
        '
        Me.txtOutLogPath.Add_Comma = False
        Me.txtOutLogPath.BackColor = System.Drawing.Color.Empty
        Me.txtOutLogPath.DataSource = Nothing
        Me.txtOutLogPath.DecimalDigit = 2
        Me.txtOutLogPath.DisplayMember = Nothing
        Me.txtOutLogPath.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtOutLogPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtOutLogPath.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtOutLogPath.LinkCheckedBox = Nothing
        Me.txtOutLogPath.Location = New System.Drawing.Point(132, 56)
        Me.txtOutLogPath.MaxValue = 99999.99R
        Me.txtOutLogPath.MinValue = -99999.99R
        Me.txtOutLogPath.Name = "txtOutLogPath"
        Me.txtOutLogPath.NotNull = False
        Me.txtOutLogPath.ReadOnly = True
        Me.txtOutLogPath.ShowDecimal = False
        Me.txtOutLogPath.Size = New System.Drawing.Size(648, 23)
        Me.txtOutLogPath.TabIndex = 6
        Me.txtOutLogPath.TabStop = False
        '
        'chkLogDate
        '
        Me.chkLogDate.AutoSize = True
        Me.chkLogDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkLogDate.Location = New System.Drawing.Point(22, 28)
        Me.chkLogDate.Name = "chkLogDate"
        Me.chkLogDate.Size = New System.Drawing.Size(85, 21)
        Me.chkLogDate.TabIndex = 4
        Me.chkLogDate.Text = "Log Date"
        Me.chkLogDate.UseVisualStyleBackColor = True
        '
        'OpeLabel3
        '
        Me.OpeLabel3.AutoSize = True
        Me.OpeLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel3.LabelId = 0
        Me.OpeLabel3.Location = New System.Drawing.Point(227, 30)
        Me.OpeLabel3.Name = "OpeLabel3"
        Me.OpeLabel3.Size = New System.Drawing.Size(16, 17)
        Me.OpeLabel3.TabIndex = 2
        Me.OpeLabel3.Text = "~"
        '
        'dtpDate2
        '
        Me.dtpDate2.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate2.HideButton = False
        Me.dtpDate2.LinkCheckedBox = Nothing
        Me.dtpDate2.LinkDateTime = Nothing
        Me.dtpDate2.Location = New System.Drawing.Point(246, 27)
        Me.dtpDate2.Name = "dtpDate2"
        Me.dtpDate2.Size = New System.Drawing.Size(93, 23)
        Me.dtpDate2.TabIndex = 3
        Me.dtpDate2.TextValue = "20180530"
        Me.dtpDate2.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'dtpDate1
        '
        Me.dtpDate1.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate1.HideButton = False
        Me.dtpDate1.LinkCheckedBox = Nothing
        Me.dtpDate1.LinkDateTime = Nothing
        Me.dtpDate1.Location = New System.Drawing.Point(132, 27)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(93, 23)
        Me.dtpDate1.TabIndex = 1
        Me.dtpDate1.TextValue = "20180530"
        Me.dtpDate1.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 150)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(834, 200)
        Me.grpData.TabIndex = 2
        Me.grpData.TabStop = False
        Me.grpData.Text = "Search Result"
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
        'clsVLogData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 372)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVLogData"
        Me.Text = "Log Data"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        Me.grpData.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents btnPrint As OPE_Controls.OpeButtonPrint
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents OpeLabel3 As OPE_Controls.OpeLabel
    Friend WithEvents dtpDate2 As OPE_Controls.OpeDateTime
    Friend WithEvents dtpDate1 As OPE_Controls.OpeDateTime
    Friend WithEvents chkLogDate As OPE_Controls.OpeCheckBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCheckAll As OPE_Controls.OpeButtonStrip
    Friend WithEvents btnReleaseAll As OPE_Controls.OpeButtonStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtOutLogPath As OPE_Controls.OpeTextBox
    Friend WithEvents lblOutLogPath As OPE_Controls.OpeLabel
    Friend WithEvents chkSumDate As OPE_Controls.OpeCheckBox
    Friend WithEvents btnLogo As System.Windows.Forms.ToolStripButton
End Class
