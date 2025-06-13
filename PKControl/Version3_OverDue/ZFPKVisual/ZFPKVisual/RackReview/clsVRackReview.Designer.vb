<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVRackReview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVRackReview))
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.grdData = New OPE_Controls.opeDataGrid()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.cboSRemark = New OPE_Controls.OpeComboBox2()
        Me.cboSCode = New OPE_Controls.OpeComboBox2()
        Me.cboSModel = New OPE_Controls.OpeComboBox2()
        Me.chkSRemark = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSCode = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSType = New OPE_Controls.OpeComboBox2()
        Me.chkSModel = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkSType = New OPE_Controls.OpeCheckBox(Me.components)
        Me.grpData = New OPE_Controls.OpeGroupBox()
        Me.ErrProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chkMBOverDue = New OPE_Controls.OpeCheckBox(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchCondition.SuspendLayout()
        Me.grpData.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Me.grdData
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(1001, 39)
        Me.ButtonBoxH.StatusBox = Me.StatusBox
        Me.ButtonBoxH.TabIndex = 5
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
        Me.grdData.Size = New System.Drawing.Size(985, 384)
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
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 539)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(1001, 22)
        Me.StatusBox.TabIndex = 6
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.chkMBOverDue)
        Me.grpSearchCondition.Controls.Add(Me.cboSRemark)
        Me.grpSearchCondition.Controls.Add(Me.cboSCode)
        Me.grpSearchCondition.Controls.Add(Me.cboSModel)
        Me.grpSearchCondition.Controls.Add(Me.chkSRemark)
        Me.grpSearchCondition.Controls.Add(Me.chkSCode)
        Me.grpSearchCondition.Controls.Add(Me.cboSType)
        Me.grpSearchCondition.Controls.Add(Me.chkSModel)
        Me.grpSearchCondition.Controls.Add(Me.chkSType)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 39)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(1001, 95)
        Me.grpSearchCondition.TabIndex = 7
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'cboSRemark
        '
        Me.cboSRemark.BackColor = System.Drawing.Color.White
        Me.cboSRemark.Busy = True
        Me.cboSRemark.DataSource = Nothing
        Me.cboSRemark.DisplayMember = ""
        Me.cboSRemark.DisplayMemberLength = Nothing
        Me.cboSRemark.DisplayMemberList = ""
        Me.cboSRemark.DisplayMemberText = Nothing
        Me.cboSRemark.DisplayMemberText2 = Nothing
        Me.cboSRemark.DisplayMemberText3 = Nothing
        Me.cboSRemark.DisplayShowButton = False
        Me.cboSRemark.DropDownList = False
        Me.cboSRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSRemark.ForeColor = System.Drawing.Color.Black
        Me.cboSRemark.IsTextBox = False
        Me.cboSRemark.LinkCheck = Nothing
        Me.cboSRemark.LinkCheckedBox = Nothing
        Me.cboSRemark.LinkTextBox = Nothing
        Me.cboSRemark.LinkTextBox2 = Nothing
        Me.cboSRemark.LinkTextBox3 = Nothing
        Me.cboSRemark.Location = New System.Drawing.Point(461, 57)
        Me.cboSRemark.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSRemark.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSRemark.MaxLength = 32767
        Me.cboSRemark.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSRemark.Name = "cboSRemark"
        Me.cboSRemark.NotNull = False
        Me.cboSRemark.RefreshWidth = False
        Me.cboSRemark.RowFilter = ""
        Me.cboSRemark.SelectedIndex = -1
        Me.cboSRemark.SelectedValue = Nothing
        Me.cboSRemark.Size = New System.Drawing.Size(182, 23)
        Me.cboSRemark.TabIndex = 7
        Me.cboSRemark.ValueMember = ""
        '
        'cboSCode
        '
        Me.cboSCode.BackColor = System.Drawing.Color.White
        Me.cboSCode.Busy = True
        Me.cboSCode.DataSource = Nothing
        Me.cboSCode.DisplayMember = ""
        Me.cboSCode.DisplayMemberLength = Nothing
        Me.cboSCode.DisplayMemberList = ""
        Me.cboSCode.DisplayMemberText = Nothing
        Me.cboSCode.DisplayMemberText2 = Nothing
        Me.cboSCode.DisplayMemberText3 = Nothing
        Me.cboSCode.DisplayShowButton = False
        Me.cboSCode.DropDownList = False
        Me.cboSCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSCode.ForeColor = System.Drawing.Color.Black
        Me.cboSCode.IsTextBox = False
        Me.cboSCode.LinkCheck = Nothing
        Me.cboSCode.LinkCheckedBox = Nothing
        Me.cboSCode.LinkTextBox = Nothing
        Me.cboSCode.LinkTextBox2 = Nothing
        Me.cboSCode.LinkTextBox3 = Nothing
        Me.cboSCode.Location = New System.Drawing.Point(461, 28)
        Me.cboSCode.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSCode.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSCode.MaxLength = 32767
        Me.cboSCode.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSCode.Name = "cboSCode"
        Me.cboSCode.NotNull = False
        Me.cboSCode.RefreshWidth = False
        Me.cboSCode.RowFilter = ""
        Me.cboSCode.SelectedIndex = -1
        Me.cboSCode.SelectedValue = Nothing
        Me.cboSCode.Size = New System.Drawing.Size(182, 23)
        Me.cboSCode.TabIndex = 5
        Me.cboSCode.ValueMember = ""
        '
        'cboSModel
        '
        Me.cboSModel.BackColor = System.Drawing.Color.White
        Me.cboSModel.Busy = True
        Me.cboSModel.DataSource = Nothing
        Me.cboSModel.DisplayMember = ""
        Me.cboSModel.DisplayMemberLength = Nothing
        Me.cboSModel.DisplayMemberList = ""
        Me.cboSModel.DisplayMemberText = Nothing
        Me.cboSModel.DisplayMemberText2 = Nothing
        Me.cboSModel.DisplayMemberText3 = Nothing
        Me.cboSModel.DisplayShowButton = False
        Me.cboSModel.DropDownList = False
        Me.cboSModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboSModel.ForeColor = System.Drawing.Color.Black
        Me.cboSModel.IsTextBox = False
        Me.cboSModel.LinkCheck = Nothing
        Me.cboSModel.LinkCheckedBox = Nothing
        Me.cboSModel.LinkTextBox = Nothing
        Me.cboSModel.LinkTextBox2 = Nothing
        Me.cboSModel.LinkTextBox3 = Nothing
        Me.cboSModel.Location = New System.Drawing.Point(115, 57)
        Me.cboSModel.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSModel.MaximumSize = New System.Drawing.Size(800, 23)
        Me.cboSModel.MaxLength = 32767
        Me.cboSModel.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cboSModel.Name = "cboSModel"
        Me.cboSModel.NotNull = False
        Me.cboSModel.RefreshWidth = False
        Me.cboSModel.RowFilter = ""
        Me.cboSModel.SelectedIndex = -1
        Me.cboSModel.SelectedValue = Nothing
        Me.cboSModel.Size = New System.Drawing.Size(182, 23)
        Me.cboSModel.TabIndex = 3
        Me.cboSModel.ValueMember = ""
        '
        'chkSRemark
        '
        Me.chkSRemark.AutoSize = True
        Me.chkSRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSRemark.Location = New System.Drawing.Point(377, 58)
        Me.chkSRemark.Name = "chkSRemark"
        Me.chkSRemark.Size = New System.Drawing.Size(76, 21)
        Me.chkSRemark.TabIndex = 6
        Me.chkSRemark.Text = "Remark"
        Me.chkSRemark.UseVisualStyleBackColor = True
        '
        'chkSCode
        '
        Me.chkSCode.AutoSize = True
        Me.chkSCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSCode.Location = New System.Drawing.Point(377, 29)
        Me.chkSCode.Name = "chkSCode"
        Me.chkSCode.Size = New System.Drawing.Size(60, 21)
        Me.chkSCode.TabIndex = 4
        Me.chkSCode.Text = "Code"
        Me.chkSCode.UseVisualStyleBackColor = True
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
        Me.cboSType.Location = New System.Drawing.Point(115, 28)
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
        Me.cboSType.Size = New System.Drawing.Size(182, 23)
        Me.cboSType.TabIndex = 1
        Me.cboSType.ValueMember = ""
        '
        'chkSModel
        '
        Me.chkSModel.AutoSize = True
        Me.chkSModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSModel.Location = New System.Drawing.Point(31, 58)
        Me.chkSModel.Name = "chkSModel"
        Me.chkSModel.Size = New System.Drawing.Size(65, 21)
        Me.chkSModel.TabIndex = 2
        Me.chkSModel.Text = "Model"
        Me.chkSModel.UseVisualStyleBackColor = True
        '
        'chkSType
        '
        Me.chkSType.AutoSize = True
        Me.chkSType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkSType.Location = New System.Drawing.Point(31, 29)
        Me.chkSType.Name = "chkSType"
        Me.chkSType.Size = New System.Drawing.Size(59, 21)
        Me.chkSType.TabIndex = 0
        Me.chkSType.Text = "Type"
        Me.chkSType.UseVisualStyleBackColor = True
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.grdData)
        Me.grpData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpData.Location = New System.Drawing.Point(0, 134)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpData.Size = New System.Drawing.Size(1001, 405)
        Me.grpData.TabIndex = 8
        Me.grpData.TabStop = False
        Me.grpData.Text = "Search Result"
        '
        'ErrProvider
        '
        Me.ErrProvider.ContainerControl = Me
        '
        'chkMBOverDue
        '
        Me.chkMBOverDue.AutoSize = True
        Me.chkMBOverDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.chkMBOverDue.Location = New System.Drawing.Point(718, 58)
        Me.chkMBOverDue.Name = "chkMBOverDue"
        Me.chkMBOverDue.Size = New System.Drawing.Size(112, 21)
        Me.chkMBOverDue.TabIndex = 8
        Me.chkMBOverDue.Text = "MB Over Due"
        Me.chkMBOverDue.UseVisualStyleBackColor = True
        '
        'clsVRackReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 561)
        Me.Controls.Add(Me.grpData)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVRackReview"
        Me.Text = "Rack Review"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        Me.grpData.ResumeLayout(False)
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents cboSRemark As OPE_Controls.OpeComboBox2
    Friend WithEvents cboSCode As OPE_Controls.OpeComboBox2
    Friend WithEvents cboSModel As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSRemark As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSCode As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSType As OPE_Controls.OpeComboBox2
    Friend WithEvents chkSModel As OPE_Controls.OpeCheckBox
    Friend WithEvents chkSType As OPE_Controls.OpeCheckBox
    Friend WithEvents grdData As OPE_Controls.opeDataGrid
    Friend WithEvents grpData As OPE_Controls.OpeGroupBox
    Friend WithEvents ErrProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents chkMBOverDue As OPE_Controls.OpeCheckBox
End Class
