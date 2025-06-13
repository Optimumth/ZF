<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVTruckDT_NewTransBMW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVTruckDT_NewTransBMW))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.btnOK = New OPE_Controls.OpeButtonOK()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCheckAll = New OPE_Controls.OpeButtonStrip()
        Me.btnReleaseAll = New OPE_Controls.OpeButtonStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.grdData = New OPE_Controls.opeDataGrid()
        Me.chkLogDate = New OPE_Controls.OpeCheckBox(Me.components)
        Me.OpeLabel3 = New OPE_Controls.OpeLabel(Me.components)
        Me.dtpDate2 = New OPE_Controls.OpeDateTime(Me.components)
        Me.dtpDate1 = New OPE_Controls.OpeDateTime(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        Me.grpSearchCondition.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 476)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(908, 22)
        Me.StatusBox.TabIndex = 10
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Me.grdData
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.ToolStripSeparator1, Me.btnOK, Me.ToolStripSeparator2, Me.btnCheckAll, Me.btnReleaseAll, Me.ToolStripSeparator3})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(908, 39)
        Me.ButtonBoxH.StatusBox = Me.StatusBox
        Me.ButtonBoxH.TabIndex = 9
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.chkLogDate)
        Me.grpSearchCondition.Controls.Add(Me.OpeLabel3)
        Me.grpSearchCondition.Controls.Add(Me.dtpDate2)
        Me.grpSearchCondition.Controls.Add(Me.dtpDate1)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 39)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(908, 81)
        Me.grpSearchCondition.TabIndex = 11
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
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
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightCyan
        Me.grdData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.grdData.AutoGenerateRecordNo = False
        Me.grdData.ChangeEnterToTab = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.EnableHeadersVisualStyles = False
        Me.grdData.IsStatus = False
        Me.grdData.Location = New System.Drawing.Point(0, 120)
        Me.grdData.Name = "grdData"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(908, 356)
        Me.grdData.TabIndex = 12
        '
        'chkLogDate
        '
        Me.chkLogDate.AutoSize = True
        Me.chkLogDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkLogDate.Location = New System.Drawing.Point(33, 34)
        Me.chkLogDate.Name = "chkLogDate"
        Me.chkLogDate.Size = New System.Drawing.Size(85, 21)
        Me.chkLogDate.TabIndex = 8
        Me.chkLogDate.Text = "Log Date"
        Me.chkLogDate.UseVisualStyleBackColor = True
        '
        'OpeLabel3
        '
        Me.OpeLabel3.AutoSize = True
        Me.OpeLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OpeLabel3.LabelId = 0
        Me.OpeLabel3.Location = New System.Drawing.Point(238, 36)
        Me.OpeLabel3.Name = "OpeLabel3"
        Me.OpeLabel3.Size = New System.Drawing.Size(16, 17)
        Me.OpeLabel3.TabIndex = 6
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
        Me.dtpDate2.Location = New System.Drawing.Point(257, 33)
        Me.dtpDate2.Name = "dtpDate2"
        Me.dtpDate2.Size = New System.Drawing.Size(93, 23)
        Me.dtpDate2.TabIndex = 7
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
        Me.dtpDate1.Location = New System.Drawing.Point(143, 33)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(93, 23)
        Me.dtpDate1.TabIndex = 5
        Me.dtpDate1.TextValue = "20180530"
        Me.dtpDate1.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'clsVTruckDT_NewTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 498)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVTruckDT_NewTrans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Rack"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnOK As OPE_Controls.OpeButtonOK
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCheckAll As OPE_Controls.OpeButtonStrip
    Friend WithEvents btnReleaseAll As OPE_Controls.OpeButtonStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents chkLogDate As OPE_Controls.OpeCheckBox
    Friend WithEvents OpeLabel3 As OPE_Controls.OpeLabel
    Friend WithEvents dtpDate2 As OPE_Controls.OpeDateTime
    Friend WithEvents dtpDate1 As OPE_Controls.OpeDateTime
End Class
