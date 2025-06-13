<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVStaff
    Inherits OPE_Controls.frmMst007

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtSLoginId = New OPE_Controls.OpeTextBox()
        Me.chkSLoginId = New OPE_Controls.OpeCheckBox(Me.components)
        Me.txtSStaffId = New OPE_Controls.OpeTextBox()
        Me.chkSStaffId = New OPE_Controls.OpeCheckBox(Me.components)
        Me.txtSGivenName = New OPE_Controls.OpeTextBox()
        Me.chkSGivenName = New OPE_Controls.OpeCheckBox(Me.components)
        Me.txtSSurName = New OPE_Controls.OpeTextBox()
        Me.chkSSurName = New OPE_Controls.OpeCheckBox(Me.components)
        Me.txtSUserGroup = New OPE_Controls.OpeTextBox()
        Me.chkSUserGroupId = New OPE_Controls.OpeCheckBox(Me.components)
        Me.lblStaffDesc = New OPE_Controls.OpeLabel(Me.components)
        Me.txtRemark = New OPE_Controls.OpeTextBox()
        Me.cmbUserGroup = New OPE_Controls.OpeComboBox2()
        Me.lblUserGroupId = New OPE_Controls.OpeLabel(Me.components)
        Me.txtPasswd = New OPE_Controls.OpeTextBox()
        Me.lblPassword = New OPE_Controls.OpeLabel(Me.components)
        Me.txtLoginId = New OPE_Controls.OpeTextBox()
        Me.lblLogin = New OPE_Controls.OpeLabel(Me.components)
        Me.dtpJoinDate = New System.Windows.Forms.DateTimePicker()
        Me.lblJoinDate = New OPE_Controls.OpeLabel(Me.components)
        Me.lblGivenName = New OPE_Controls.OpeLabel(Me.components)
        Me.lblSurName = New OPE_Controls.OpeLabel(Me.components)
        Me.txtSurName = New OPE_Controls.OpeTextBox()
        Me.cmbTitle = New OPE_Controls.OpeComboBox2()
        Me.lblTitle = New OPE_Controls.OpeLabel(Me.components)
        Me.lblStaffId = New OPE_Controls.OpeLabel(Me.components)
        Me.txtGivenName = New OPE_Controls.OpeTextBox()
        Me.txtStaffId = New OPE_Controls.OpeTextBox()
        Me.lblTelNo = New OPE_Controls.OpeLabel(Me.components)
        Me.txtTelNo = New OPE_Controls.OpeTextBox()
        Me.lblNickName = New OPE_Controls.OpeLabel(Me.components)
        Me.txtNickName = New OPE_Controls.OpeTextBox()
        Me.txtSNickName = New OPE_Controls.OpeTextBox()
        Me.chkSNickName = New OPE_Controls.OpeCheckBox(Me.components)
        Me.btnHandy = New OPE_Controls.OpeButton(Me.components)
        Me.chkMB = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkBMW = New OPE_Controls.OpeCheckBox(Me.components)
        Me.chkCustomer = New OPE_Controls.OpeCheckBox(Me.components)
        Me.cboSCustomer = New OPE_Controls.OpeComboBox2()
        Me.gbUpdateData.SuspendLayout()
        CType(Me.msgError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSearch.SuspendLayout()
        Me.gbEntry.SuspendLayout()
        Me.TabControlResvHeader.SuspendLayout()
        Me.TabControlResvDetail.SuspendLayout()
        Me.TabPageDetail.SuspendLayout()
        Me.PlAllDeltail.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbUpdateData
        '
        Me.gbUpdateData.Location = New System.Drawing.Point(0, 368)
        Me.gbUpdateData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbUpdateData.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbUpdateData.Size = New System.Drawing.Size(955, 234)
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(0, 169)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(955, 199)
        '
        'gbSearch
        '
        Me.gbSearch.Controls.Add(Me.cboSCustomer)
        Me.gbSearch.Controls.Add(Me.chkCustomer)
        Me.gbSearch.Controls.Add(Me.btnHandy)
        Me.gbSearch.Controls.Add(Me.txtSNickName)
        Me.gbSearch.Controls.Add(Me.chkSNickName)
        Me.gbSearch.Controls.Add(Me.txtSUserGroup)
        Me.gbSearch.Controls.Add(Me.chkSUserGroupId)
        Me.gbSearch.Controls.Add(Me.txtSGivenName)
        Me.gbSearch.Controls.Add(Me.chkSGivenName)
        Me.gbSearch.Controls.Add(Me.txtSSurName)
        Me.gbSearch.Controls.Add(Me.chkSSurName)
        Me.gbSearch.Controls.Add(Me.txtSLoginId)
        Me.gbSearch.Controls.Add(Me.chkSLoginId)
        Me.gbSearch.Controls.Add(Me.txtSStaffId)
        Me.gbSearch.Controls.Add(Me.chkSStaffId)
        Me.gbSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbSearch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbSearch.Size = New System.Drawing.Size(955, 125)
        '
        'gbEntry
        '
        Me.gbEntry.Location = New System.Drawing.Point(0, 164)
        Me.gbEntry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbEntry.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbEntry.Size = New System.Drawing.Size(955, 5)
        Me.gbEntry.Visible = False
        '
        'txtResv1Header
        '
        Me.txtResv1Header.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv2Header
        '
        Me.txtResv2Header.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv3Header
        '
        Me.txtResv3Header.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv4Header
        '
        Me.txtResv4Header.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv5Header
        '
        Me.txtResv5Header.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv6Header
        '
        Me.txtResv6Header.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv7Header
        '
        Me.txtResv7Header.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv8Header
        '
        Me.txtResv8Header.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv9Header
        '
        Me.txtResv9Header.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'TabControlResvHeader
        '
        Me.TabControlResvHeader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControlResvHeader.Size = New System.Drawing.Size(876, 0)
        '
        'TabPageHeader
        '
        Me.TabPageHeader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageHeader.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageHeader.Size = New System.Drawing.Size(868, 0)
        '
        'TabControlResvDetail
        '
        Me.TabControlResvDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControlResvDetail.Size = New System.Drawing.Size(900, 211)
        '
        'TabPageDetail
        '
        Me.TabPageDetail.Controls.Add(Me.chkBMW)
        Me.TabPageDetail.Controls.Add(Me.chkMB)
        Me.TabPageDetail.Controls.Add(Me.lblNickName)
        Me.TabPageDetail.Controls.Add(Me.txtNickName)
        Me.TabPageDetail.Controls.Add(Me.lblTelNo)
        Me.TabPageDetail.Controls.Add(Me.txtTelNo)
        Me.TabPageDetail.Controls.Add(Me.lblStaffDesc)
        Me.TabPageDetail.Controls.Add(Me.txtRemark)
        Me.TabPageDetail.Controls.Add(Me.cmbUserGroup)
        Me.TabPageDetail.Controls.Add(Me.lblUserGroupId)
        Me.TabPageDetail.Controls.Add(Me.txtPasswd)
        Me.TabPageDetail.Controls.Add(Me.lblPassword)
        Me.TabPageDetail.Controls.Add(Me.txtLoginId)
        Me.TabPageDetail.Controls.Add(Me.lblLogin)
        Me.TabPageDetail.Controls.Add(Me.dtpJoinDate)
        Me.TabPageDetail.Controls.Add(Me.lblJoinDate)
        Me.TabPageDetail.Controls.Add(Me.lblGivenName)
        Me.TabPageDetail.Controls.Add(Me.lblSurName)
        Me.TabPageDetail.Controls.Add(Me.txtSurName)
        Me.TabPageDetail.Controls.Add(Me.cmbTitle)
        Me.TabPageDetail.Controls.Add(Me.lblTitle)
        Me.TabPageDetail.Controls.Add(Me.lblStaffId)
        Me.TabPageDetail.Controls.Add(Me.txtGivenName)
        Me.TabPageDetail.Controls.Add(Me.txtStaffId)
        Me.TabPageDetail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageDetail.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageDetail.Size = New System.Drawing.Size(892, 185)
        '
        'TabPageDetailReserve
        '
        Me.TabPageDetailReserve.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageDetailReserve.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageDetailReserve.Size = New System.Drawing.Size(892, 185)
        '
        'txtResv1Detail
        '
        Me.txtResv1Detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv2Detail
        '
        Me.txtResv2Detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv3Detail
        '
        Me.txtResv3Detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv4Detail
        '
        Me.txtResv4Detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv5Detail
        '
        Me.txtResv5Detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv6Detail
        '
        Me.txtResv6Detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv7Detail
        '
        Me.txtResv7Detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv8Detail
        '
        Me.txtResv8Detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'txtResv9Detail
        '
        Me.txtResv9Detail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'PlAllDeltail
        '
        Me.PlAllDeltail.Location = New System.Drawing.Point(4, 18)
        Me.PlAllDeltail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PlAllDeltail.Size = New System.Drawing.Size(900, 211)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(904, 18)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Size = New System.Drawing.Size(47, 211)
        '
        'txtSLoginId
        '
        Me.txtSLoginId.Add_Comma = False
        Me.txtSLoginId.DataSource = Nothing
        Me.txtSLoginId.DecimalDigit = 2
        Me.txtSLoginId.DisplayMember = ""
        Me.txtSLoginId.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSLoginId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSLoginId.ForeColor = System.Drawing.Color.Black
        Me.txtSLoginId.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtSLoginId.LinkCheckedBox = Nothing
        Me.txtSLoginId.Location = New System.Drawing.Point(538, 19)
        Me.txtSLoginId.MaxLength = 50
        Me.txtSLoginId.MaxValue = 99999.99R
        Me.txtSLoginId.MinValue = -99999.99R
        Me.txtSLoginId.Name = "txtSLoginId"
        Me.txtSLoginId.NotNull = False
        Me.txtSLoginId.ShowDecimal = False
        Me.txtSLoginId.Size = New System.Drawing.Size(250, 20)
        Me.txtSLoginId.TabIndex = 13
        '
        'chkSLoginId
        '
        Me.chkSLoginId.AutoSize = True
        Me.chkSLoginId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSLoginId.Location = New System.Drawing.Point(424, 21)
        Me.chkSLoginId.Name = "chkSLoginId"
        Me.chkSLoginId.Size = New System.Drawing.Size(66, 17)
        Me.chkSLoginId.TabIndex = 12
        Me.chkSLoginId.Text = "Login ID"
        Me.chkSLoginId.UseVisualStyleBackColor = True
        '
        'txtSStaffId
        '
        Me.txtSStaffId.Add_Comma = False
        Me.txtSStaffId.DataSource = Nothing
        Me.txtSStaffId.DecimalDigit = 2
        Me.txtSStaffId.DisplayMember = ""
        Me.txtSStaffId.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSStaffId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSStaffId.ForeColor = System.Drawing.Color.Black
        Me.txtSStaffId.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtSStaffId.LinkCheckedBox = Nothing
        Me.txtSStaffId.Location = New System.Drawing.Point(127, 19)
        Me.txtSStaffId.MaxLength = 50
        Me.txtSStaffId.MaxValue = 99999.99R
        Me.txtSStaffId.MinValue = -99999.99R
        Me.txtSStaffId.Name = "txtSStaffId"
        Me.txtSStaffId.NotNull = False
        Me.txtSStaffId.ShowDecimal = False
        Me.txtSStaffId.Size = New System.Drawing.Size(250, 20)
        Me.txtSStaffId.TabIndex = 11
        '
        'chkSStaffId
        '
        Me.chkSStaffId.AutoSize = True
        Me.chkSStaffId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSStaffId.Location = New System.Drawing.Point(21, 21)
        Me.chkSStaffId.Name = "chkSStaffId"
        Me.chkSStaffId.Size = New System.Drawing.Size(76, 17)
        Me.chkSStaffId.TabIndex = 10
        Me.chkSStaffId.Text = "Staff Code"
        Me.chkSStaffId.UseVisualStyleBackColor = True
        '
        'txtSGivenName
        '
        Me.txtSGivenName.Add_Comma = False
        Me.txtSGivenName.DataSource = Nothing
        Me.txtSGivenName.DecimalDigit = 2
        Me.txtSGivenName.DisplayMember = ""
        Me.txtSGivenName.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSGivenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSGivenName.ForeColor = System.Drawing.Color.Black
        Me.txtSGivenName.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtSGivenName.LinkCheckedBox = Nothing
        Me.txtSGivenName.Location = New System.Drawing.Point(538, 41)
        Me.txtSGivenName.MaxLength = 50
        Me.txtSGivenName.MaxValue = 99999.99R
        Me.txtSGivenName.MinValue = -99999.99R
        Me.txtSGivenName.Name = "txtSGivenName"
        Me.txtSGivenName.NotNull = False
        Me.txtSGivenName.ShowDecimal = False
        Me.txtSGivenName.Size = New System.Drawing.Size(250, 20)
        Me.txtSGivenName.TabIndex = 17
        '
        'chkSGivenName
        '
        Me.chkSGivenName.AutoSize = True
        Me.chkSGivenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSGivenName.Location = New System.Drawing.Point(424, 43)
        Me.chkSGivenName.Name = "chkSGivenName"
        Me.chkSGivenName.Size = New System.Drawing.Size(82, 17)
        Me.chkSGivenName.TabIndex = 16
        Me.chkSGivenName.Text = "GivenName"
        Me.chkSGivenName.UseVisualStyleBackColor = True
        '
        'txtSSurName
        '
        Me.txtSSurName.Add_Comma = False
        Me.txtSSurName.DataSource = Nothing
        Me.txtSSurName.DecimalDigit = 2
        Me.txtSSurName.DisplayMember = ""
        Me.txtSSurName.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSSurName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSurName.ForeColor = System.Drawing.Color.Black
        Me.txtSSurName.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtSSurName.LinkCheckedBox = Nothing
        Me.txtSSurName.Location = New System.Drawing.Point(127, 41)
        Me.txtSSurName.MaxLength = 50
        Me.txtSSurName.MaxValue = 99999.99R
        Me.txtSSurName.MinValue = -99999.99R
        Me.txtSSurName.Name = "txtSSurName"
        Me.txtSSurName.NotNull = False
        Me.txtSSurName.ShowDecimal = False
        Me.txtSSurName.Size = New System.Drawing.Size(250, 20)
        Me.txtSSurName.TabIndex = 15
        '
        'chkSSurName
        '
        Me.chkSSurName.AutoSize = True
        Me.chkSSurName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSurName.Location = New System.Drawing.Point(21, 43)
        Me.chkSSurName.Name = "chkSSurName"
        Me.chkSSurName.Size = New System.Drawing.Size(70, 17)
        Me.chkSSurName.TabIndex = 14
        Me.chkSSurName.Text = "SurName"
        Me.chkSSurName.UseVisualStyleBackColor = True
        '
        'txtSUserGroup
        '
        Me.txtSUserGroup.Add_Comma = False
        Me.txtSUserGroup.DataSource = Nothing
        Me.txtSUserGroup.DecimalDigit = 2
        Me.txtSUserGroup.DisplayMember = ""
        Me.txtSUserGroup.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSUserGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSUserGroup.ForeColor = System.Drawing.Color.Black
        Me.txtSUserGroup.Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
        Me.txtSUserGroup.LinkCheckedBox = Nothing
        Me.txtSUserGroup.Location = New System.Drawing.Point(538, 63)
        Me.txtSUserGroup.MaxLength = 50
        Me.txtSUserGroup.MaxValue = 99999.99R
        Me.txtSUserGroup.MinValue = -99999.99R
        Me.txtSUserGroup.Name = "txtSUserGroup"
        Me.txtSUserGroup.NotNull = False
        Me.txtSUserGroup.ShowDecimal = False
        Me.txtSUserGroup.Size = New System.Drawing.Size(250, 20)
        Me.txtSUserGroup.TabIndex = 19
        '
        'chkSUserGroupId
        '
        Me.chkSUserGroupId.AutoSize = True
        Me.chkSUserGroupId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSUserGroupId.Location = New System.Drawing.Point(424, 65)
        Me.chkSUserGroupId.Name = "chkSUserGroupId"
        Me.chkSUserGroupId.Size = New System.Drawing.Size(105, 17)
        Me.chkSUserGroupId.TabIndex = 18
        Me.chkSUserGroupId.Text = "StaffGroupName"
        Me.chkSUserGroupId.UseVisualStyleBackColor = True
        '
        'lblStaffDesc
        '
        Me.lblStaffDesc.AutoSize = True
        Me.lblStaffDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblStaffDesc.LabelId = 0
        Me.lblStaffDesc.Location = New System.Drawing.Point(16, 126)
        Me.lblStaffDesc.Name = "lblStaffDesc"
        Me.lblStaffDesc.Size = New System.Drawing.Size(49, 13)
        Me.lblStaffDesc.TabIndex = 20
        Me.lblStaffDesc.Text = "Remarks"
        '
        'txtRemark
        '
        Me.txtRemark.Add_Comma = False
        Me.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemark.DataSource = Nothing
        Me.txtRemark.DecimalDigit = 2
        Me.txtRemark.DisplayMember = ""
        Me.txtRemark.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.ForeColor = System.Drawing.Color.Black
        Me.txtRemark.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtRemark.LinkCheckedBox = Nothing
        Me.txtRemark.Location = New System.Drawing.Point(112, 121)
        Me.txtRemark.MaxLength = 50
        Me.txtRemark.MaxValue = 99999.99R
        Me.txtRemark.MinValue = -99999.99R
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.NotNull = False
        Me.txtRemark.ShowDecimal = False
        Me.txtRemark.Size = New System.Drawing.Size(697, 23)
        Me.txtRemark.TabIndex = 21
        '
        'cmbUserGroup
        '
        Me.cmbUserGroup.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.cmbUserGroup.BackColor = System.Drawing.Color.MistyRose
        Me.cmbUserGroup.Busy = True
        Me.cmbUserGroup.DataSource = Nothing
        Me.cmbUserGroup.DisplayMember = ""
        Me.cmbUserGroup.DisplayMemberLength = Nothing
        Me.cmbUserGroup.DisplayMemberList = ""
        Me.cmbUserGroup.DisplayMemberText = Nothing
        Me.cmbUserGroup.DisplayMemberText2 = Nothing
        Me.cmbUserGroup.DisplayMemberText3 = Nothing
        Me.cmbUserGroup.DisplayShowButton = False
        Me.cmbUserGroup.DropDownList = False
        Me.cmbUserGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbUserGroup.ForeColor = System.Drawing.Color.Black
        Me.cmbUserGroup.IsTextBox = False
        Me.cmbUserGroup.LinkCheck = Nothing
        Me.cmbUserGroup.LinkCheckedBox = Nothing
        Me.cmbUserGroup.LinkTextBox = Nothing
        Me.cmbUserGroup.LinkTextBox2 = Nothing
        Me.cmbUserGroup.LinkTextBox3 = Nothing
        Me.cmbUserGroup.Location = New System.Drawing.Point(112, 94)
        Me.cmbUserGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbUserGroup.MaximumSize = New System.Drawing.Size(800, 21)
        Me.cmbUserGroup.MaxLength = 32767
        Me.cmbUserGroup.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cmbUserGroup.Name = "cmbUserGroup"
        Me.cmbUserGroup.NotNull = False
        Me.cmbUserGroup.RefreshWidth = False
        Me.cmbUserGroup.RowFilter = ""
        Me.cmbUserGroup.SelectedIndex = -1
        Me.cmbUserGroup.SelectedValue = Nothing
        Me.cmbUserGroup.Size = New System.Drawing.Size(112, 21)
        Me.cmbUserGroup.TabIndex = 15
        Me.cmbUserGroup.ValueMember = ""
        '
        'lblUserGroupId
        '
        Me.lblUserGroupId.AutoSize = True
        Me.lblUserGroupId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserGroupId.LabelId = 0
        Me.lblUserGroupId.Location = New System.Drawing.Point(16, 97)
        Me.lblUserGroupId.Name = "lblUserGroupId"
        Me.lblUserGroupId.Size = New System.Drawing.Size(83, 13)
        Me.lblUserGroupId.TabIndex = 14
        Me.lblUserGroupId.Text = "StaffGroupCode"
        '
        'txtPasswd
        '
        Me.txtPasswd.Add_Comma = False
        Me.txtPasswd.BackColor = System.Drawing.Color.MistyRose
        Me.txtPasswd.DataSource = Nothing
        Me.txtPasswd.DecimalDigit = 2
        Me.txtPasswd.DisplayMember = ""
        Me.txtPasswd.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtPasswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswd.ForeColor = System.Drawing.Color.Black
        Me.txtPasswd.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtPasswd.LinkCheckedBox = Nothing
        Me.txtPasswd.Location = New System.Drawing.Point(589, 93)
        Me.txtPasswd.MaxLength = 25
        Me.txtPasswd.MaxValue = 99999.99R
        Me.txtPasswd.MinValue = -99999.99R
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.NotNull = False
        Me.txtPasswd.ShowDecimal = False
        Me.txtPasswd.Size = New System.Drawing.Size(220, 20)
        Me.txtPasswd.TabIndex = 19
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPassword.LabelId = 0
        Me.lblPassword.Location = New System.Drawing.Point(520, 96)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 18
        Me.lblPassword.Text = "Password"
        '
        'txtLoginId
        '
        Me.txtLoginId.Add_Comma = False
        Me.txtLoginId.BackColor = System.Drawing.Color.MistyRose
        Me.txtLoginId.DataSource = Nothing
        Me.txtLoginId.DecimalDigit = 2
        Me.txtLoginId.DisplayMember = ""
        Me.txtLoginId.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtLoginId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginId.ForeColor = System.Drawing.Color.Black
        Me.txtLoginId.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtLoginId.LinkCheckedBox = Nothing
        Me.txtLoginId.Location = New System.Drawing.Point(295, 92)
        Me.txtLoginId.MaxLength = 8
        Me.txtLoginId.MaxValue = 99999.99R
        Me.txtLoginId.MinValue = -99999.99R
        Me.txtLoginId.Name = "txtLoginId"
        Me.txtLoginId.NotNull = False
        Me.txtLoginId.ShowDecimal = False
        Me.txtLoginId.Size = New System.Drawing.Size(216, 20)
        Me.txtLoginId.TabIndex = 17
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLogin.LabelId = 0
        Me.lblLogin.Location = New System.Drawing.Point(237, 97)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(47, 13)
        Me.lblLogin.TabIndex = 16
        Me.lblLogin.Text = "Login ID"
        '
        'dtpJoinDate
        '
        Me.dtpJoinDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJoinDate.Location = New System.Drawing.Point(295, 15)
        Me.dtpJoinDate.Name = "dtpJoinDate"
        Me.dtpJoinDate.Size = New System.Drawing.Size(150, 20)
        Me.dtpJoinDate.TabIndex = 3
        '
        'lblJoinDate
        '
        Me.lblJoinDate.AutoSize = True
        Me.lblJoinDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblJoinDate.LabelId = 0
        Me.lblJoinDate.Location = New System.Drawing.Point(237, 18)
        Me.lblJoinDate.Name = "lblJoinDate"
        Me.lblJoinDate.Size = New System.Drawing.Size(52, 13)
        Me.lblJoinDate.TabIndex = 2
        Me.lblJoinDate.Text = "Join Date"
        '
        'lblGivenName
        '
        Me.lblGivenName.AutoSize = True
        Me.lblGivenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblGivenName.LabelId = 0
        Me.lblGivenName.Location = New System.Drawing.Point(520, 45)
        Me.lblGivenName.Name = "lblGivenName"
        Me.lblGivenName.Size = New System.Drawing.Size(63, 13)
        Me.lblGivenName.TabIndex = 8
        Me.lblGivenName.Text = "GivenName"
        '
        'lblSurName
        '
        Me.lblSurName.AutoSize = True
        Me.lblSurName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSurName.LabelId = 0
        Me.lblSurName.Location = New System.Drawing.Point(237, 45)
        Me.lblSurName.Name = "lblSurName"
        Me.lblSurName.Size = New System.Drawing.Size(51, 13)
        Me.lblSurName.TabIndex = 6
        Me.lblSurName.Text = "SurName"
        '
        'txtSurName
        '
        Me.txtSurName.Add_Comma = False
        Me.txtSurName.BackColor = System.Drawing.Color.MistyRose
        Me.txtSurName.DataSource = Nothing
        Me.txtSurName.DecimalDigit = 2
        Me.txtSurName.DisplayMember = ""
        Me.txtSurName.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSurName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurName.ForeColor = System.Drawing.Color.Black
        Me.txtSurName.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtSurName.LinkCheckedBox = Nothing
        Me.txtSurName.Location = New System.Drawing.Point(295, 41)
        Me.txtSurName.MaxLength = 30
        Me.txtSurName.MaxValue = 99999.99R
        Me.txtSurName.MinValue = -99999.99R
        Me.txtSurName.Name = "txtSurName"
        Me.txtSurName.NotNull = False
        Me.txtSurName.ShowDecimal = False
        Me.txtSurName.Size = New System.Drawing.Size(216, 20)
        Me.txtSurName.TabIndex = 7
        '
        'cmbTitle
        '
        Me.cmbTitle.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.cmbTitle.BackColor = System.Drawing.Color.MistyRose
        Me.cmbTitle.Busy = True
        Me.cmbTitle.DataSource = Nothing
        Me.cmbTitle.DisplayMember = ""
        Me.cmbTitle.DisplayMemberLength = Nothing
        Me.cmbTitle.DisplayMemberList = ""
        Me.cmbTitle.DisplayMemberText = Nothing
        Me.cmbTitle.DisplayMemberText2 = Nothing
        Me.cmbTitle.DisplayMemberText3 = Nothing
        Me.cmbTitle.DisplayShowButton = False
        Me.cmbTitle.DropDownList = False
        Me.cmbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbTitle.ForeColor = System.Drawing.Color.Black
        Me.cmbTitle.IsTextBox = False
        Me.cmbTitle.LinkCheck = Nothing
        Me.cmbTitle.LinkCheckedBox = Nothing
        Me.cmbTitle.LinkTextBox = Nothing
        Me.cmbTitle.LinkTextBox2 = Nothing
        Me.cmbTitle.LinkTextBox3 = Nothing
        Me.cmbTitle.Location = New System.Drawing.Point(112, 41)
        Me.cmbTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbTitle.MaximumSize = New System.Drawing.Size(800, 21)
        Me.cmbTitle.MaxLength = 32767
        Me.cmbTitle.MinimumSize = New System.Drawing.Size(10, 10)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.NotNull = False
        Me.cmbTitle.RefreshWidth = False
        Me.cmbTitle.RowFilter = ""
        Me.cmbTitle.SelectedIndex = -1
        Me.cmbTitle.SelectedValue = Nothing
        Me.cmbTitle.Size = New System.Drawing.Size(112, 21)
        Me.cmbTitle.TabIndex = 5
        Me.cmbTitle.ValueMember = ""
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTitle.LabelId = 0
        Me.lblTitle.Location = New System.Drawing.Point(16, 45)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title"
        '
        'lblStaffId
        '
        Me.lblStaffId.AutoSize = True
        Me.lblStaffId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblStaffId.LabelId = 0
        Me.lblStaffId.Location = New System.Drawing.Point(16, 16)
        Me.lblStaffId.Name = "lblStaffId"
        Me.lblStaffId.Size = New System.Drawing.Size(54, 13)
        Me.lblStaffId.TabIndex = 0
        Me.lblStaffId.Text = "StaffCode"
        '
        'txtGivenName
        '
        Me.txtGivenName.Add_Comma = False
        Me.txtGivenName.DataSource = Nothing
        Me.txtGivenName.DecimalDigit = 2
        Me.txtGivenName.DisplayMember = ""
        Me.txtGivenName.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtGivenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGivenName.ForeColor = System.Drawing.Color.Black
        Me.txtGivenName.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtGivenName.LinkCheckedBox = Nothing
        Me.txtGivenName.Location = New System.Drawing.Point(589, 41)
        Me.txtGivenName.MaxLength = 50
        Me.txtGivenName.MaxValue = 99999.99R
        Me.txtGivenName.MinValue = -99999.99R
        Me.txtGivenName.Name = "txtGivenName"
        Me.txtGivenName.NotNull = False
        Me.txtGivenName.ShowDecimal = False
        Me.txtGivenName.Size = New System.Drawing.Size(220, 20)
        Me.txtGivenName.TabIndex = 9
        '
        'txtStaffId
        '
        Me.txtStaffId.Add_Comma = False
        Me.txtStaffId.BackColor = System.Drawing.Color.MistyRose
        Me.txtStaffId.DataSource = Nothing
        Me.txtStaffId.DecimalDigit = 2
        Me.txtStaffId.DisplayMember = ""
        Me.txtStaffId.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtStaffId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffId.ForeColor = System.Drawing.Color.Black
        Me.txtStaffId.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtStaffId.LinkCheckedBox = Nothing
        Me.txtStaffId.Location = New System.Drawing.Point(112, 15)
        Me.txtStaffId.MaxLength = 50
        Me.txtStaffId.MaxValue = 99999.99R
        Me.txtStaffId.MinValue = -99999.99R
        Me.txtStaffId.Name = "txtStaffId"
        Me.txtStaffId.NotNull = False
        Me.txtStaffId.ShowDecimal = False
        Me.txtStaffId.Size = New System.Drawing.Size(112, 20)
        Me.txtStaffId.TabIndex = 1
        '
        'lblTelNo
        '
        Me.lblTelNo.AutoSize = True
        Me.lblTelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTelNo.LabelId = 0
        Me.lblTelNo.Location = New System.Drawing.Point(237, 71)
        Me.lblTelNo.Name = "lblTelNo"
        Me.lblTelNo.Size = New System.Drawing.Size(58, 13)
        Me.lblTelNo.TabIndex = 12
        Me.lblTelNo.Text = "Phone No."
        '
        'txtTelNo
        '
        Me.txtTelNo.Add_Comma = False
        Me.txtTelNo.DataSource = Nothing
        Me.txtTelNo.DecimalDigit = 2
        Me.txtTelNo.DisplayMember = ""
        Me.txtTelNo.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtTelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelNo.ForeColor = System.Drawing.Color.Black
        Me.txtTelNo.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtTelNo.LinkCheckedBox = Nothing
        Me.txtTelNo.Location = New System.Drawing.Point(295, 68)
        Me.txtTelNo.MaxLength = 50
        Me.txtTelNo.MaxValue = 99999.99R
        Me.txtTelNo.MinValue = -99999.99R
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.NotNull = False
        Me.txtTelNo.ShowDecimal = False
        Me.txtTelNo.Size = New System.Drawing.Size(514, 20)
        Me.txtTelNo.TabIndex = 13
        '
        'lblNickName
        '
        Me.lblNickName.AutoSize = True
        Me.lblNickName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNickName.LabelId = 0
        Me.lblNickName.Location = New System.Drawing.Point(16, 72)
        Me.lblNickName.Name = "lblNickName"
        Me.lblNickName.Size = New System.Drawing.Size(60, 13)
        Me.lblNickName.TabIndex = 10
        Me.lblNickName.Text = "Nick Name"
        '
        'txtNickName
        '
        Me.txtNickName.Add_Comma = False
        Me.txtNickName.DataSource = Nothing
        Me.txtNickName.DecimalDigit = 2
        Me.txtNickName.DisplayMember = ""
        Me.txtNickName.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtNickName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNickName.ForeColor = System.Drawing.Color.Black
        Me.txtNickName.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtNickName.LinkCheckedBox = Nothing
        Me.txtNickName.Location = New System.Drawing.Point(112, 68)
        Me.txtNickName.MaxLength = 50
        Me.txtNickName.MaxValue = 99999.99R
        Me.txtNickName.MinValue = -99999.99R
        Me.txtNickName.Name = "txtNickName"
        Me.txtNickName.NotNull = False
        Me.txtNickName.ShowDecimal = False
        Me.txtNickName.Size = New System.Drawing.Size(112, 20)
        Me.txtNickName.TabIndex = 11
        '
        'txtSNickName
        '
        Me.txtSNickName.Add_Comma = False
        Me.txtSNickName.DataSource = Nothing
        Me.txtSNickName.DecimalDigit = 2
        Me.txtSNickName.DisplayMember = ""
        Me.txtSNickName.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtSNickName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNickName.ForeColor = System.Drawing.Color.Black
        Me.txtSNickName.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtSNickName.LinkCheckedBox = Nothing
        Me.txtSNickName.Location = New System.Drawing.Point(127, 63)
        Me.txtSNickName.MaxLength = 50
        Me.txtSNickName.MaxValue = 99999.99R
        Me.txtSNickName.MinValue = -99999.99R
        Me.txtSNickName.Name = "txtSNickName"
        Me.txtSNickName.NotNull = False
        Me.txtSNickName.ShowDecimal = False
        Me.txtSNickName.Size = New System.Drawing.Size(250, 20)
        Me.txtSNickName.TabIndex = 21
        '
        'chkSNickName
        '
        Me.chkSNickName.AutoSize = True
        Me.chkSNickName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSNickName.Location = New System.Drawing.Point(21, 65)
        Me.chkSNickName.Name = "chkSNickName"
        Me.chkSNickName.Size = New System.Drawing.Size(79, 17)
        Me.chkSNickName.TabIndex = 20
        Me.chkSNickName.Text = "Nick Name"
        Me.chkSNickName.UseVisualStyleBackColor = True
        '
        'btnHandy
        '
        Me.btnHandy.Image = Global.ZFPKVisual.My.Resources.Resources.Handy
        Me.btnHandy.Location = New System.Drawing.Point(821, 19)
        Me.btnHandy.Name = "btnHandy"
        Me.btnHandy.Size = New System.Drawing.Size(54, 63)
        Me.btnHandy.TabIndex = 22
        Me.btnHandy.Text = "Export"
        Me.btnHandy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHandy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnHandy.UseVisualStyleBackColor = True
        '
        'chkMB
        '
        Me.chkMB.AutoSize = True
        Me.chkMB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMB.Location = New System.Drawing.Point(708, 150)
        Me.chkMB.Name = "chkMB"
        Me.chkMB.Size = New System.Drawing.Size(42, 17)
        Me.chkMB.TabIndex = 22
        Me.chkMB.Text = "MB"
        Me.chkMB.UseVisualStyleBackColor = True
        '
        'chkBMW
        '
        Me.chkBMW.AutoSize = True
        Me.chkBMW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBMW.Location = New System.Drawing.Point(756, 150)
        Me.chkBMW.Name = "chkBMW"
        Me.chkBMW.Size = New System.Drawing.Size(53, 17)
        Me.chkBMW.TabIndex = 23
        Me.chkBMW.Text = "BMW"
        Me.chkBMW.UseVisualStyleBackColor = True
        '
        'chkCustomer
        '
        Me.chkCustomer.AutoSize = True
        Me.chkCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCustomer.Location = New System.Drawing.Point(21, 88)
        Me.chkCustomer.Name = "chkCustomer"
        Me.chkCustomer.Size = New System.Drawing.Size(70, 17)
        Me.chkCustomer.TabIndex = 23
        Me.chkCustomer.Text = "Customer"
        Me.chkCustomer.UseVisualStyleBackColor = True
        Me.chkCustomer.Visible = False
        '
        'cboSCustomer
        '
        Me.cboSCustomer.BackColor = System.Drawing.Color.White
        Me.cboSCustomer.Busy = True
        Me.cboSCustomer.DataSource = Nothing
        Me.cboSCustomer.DisplayMember = ""
        Me.cboSCustomer.DisplayMemberLength = Nothing
        Me.cboSCustomer.DisplayMemberList = ""
        Me.cboSCustomer.DisplayMemberText = Nothing
        Me.cboSCustomer.DisplayMemberText2 = Nothing
        Me.cboSCustomer.DisplayMemberText3 = Nothing
        Me.cboSCustomer.DisplayShowButton = False
        Me.cboSCustomer.DropDownList = False
        Me.cboSCustomer.ForeColor = System.Drawing.Color.Black
        Me.cboSCustomer.IsTextBox = False
        Me.cboSCustomer.LinkCheck = Nothing
        Me.cboSCustomer.LinkCheckedBox = Nothing
        Me.cboSCustomer.LinkTextBox = Nothing
        Me.cboSCustomer.LinkTextBox2 = Nothing
        Me.cboSCustomer.LinkTextBox3 = Nothing
        Me.cboSCustomer.Location = New System.Drawing.Point(127, 88)
        Me.cboSCustomer.Margin = New System.Windows.Forms.Padding(0)
        Me.cboSCustomer.MaximumSize = New System.Drawing.Size(800, 20)
        Me.cboSCustomer.MaxLength = 32767
        Me.cboSCustomer.MinimumSize = New System.Drawing.Size(7, 6)
        Me.cboSCustomer.Name = "cboSCustomer"
        Me.cboSCustomer.NotNull = False
        Me.cboSCustomer.RefreshWidth = False
        Me.cboSCustomer.RowFilter = ""
        Me.cboSCustomer.SelectedIndex = -1
        Me.cboSCustomer.SelectedValue = Nothing
        Me.cboSCustomer.Size = New System.Drawing.Size(249, 20)
        Me.cboSCustomer.TabIndex = 24
        Me.cboSCustomer.ValueMember = ""
        Me.cboSCustomer.Visible = False
        '
        'clsVStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(955, 624)
        Me.EditAreaEnable = True
        Me.GridColumnHeight = 4
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "clsVStaff"
        Me.ShowPrint1Botton = False
        Me.ShowPrint2Botton = False
        Me.Text = "Staff"
        Me.gbUpdateData.ResumeLayout(False)
        CType(Me.msgError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        Me.gbEntry.ResumeLayout(False)
        Me.TabControlResvHeader.ResumeLayout(False)
        Me.TabControlResvDetail.ResumeLayout(False)
        Me.TabPageDetail.ResumeLayout(False)
        Me.TabPageDetail.PerformLayout()
        Me.PlAllDeltail.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSLoginId As OPE_Controls.opeTextBox
    Friend WithEvents chkSLoginId As OPE_Controls.OpeCheckBox
    Friend WithEvents txtSStaffId As OPE_Controls.opeTextBox
    Friend WithEvents chkSStaffId As OPE_Controls.OpeCheckBox
    Friend WithEvents txtSUserGroup As OPE_Controls.opeTextBox
    Friend WithEvents chkSUserGroupId As OPE_Controls.OpeCheckBox
    Friend WithEvents txtSGivenName As OPE_Controls.opeTextBox
    Friend WithEvents chkSGivenName As OPE_Controls.OpeCheckBox
    Friend WithEvents txtSSurName As OPE_Controls.opeTextBox
    Friend WithEvents chkSSurName As OPE_Controls.OpeCheckBox
    Friend WithEvents lblStaffDesc As OPE_Controls.OpeLabel
    Friend WithEvents txtRemark As OPE_Controls.opeTextBox
    Friend WithEvents cmbUserGroup As OPE_Controls.OpeComboBox2
    Friend WithEvents lblUserGroupId As OPE_Controls.OpeLabel
    Friend WithEvents txtPasswd As OPE_Controls.opeTextBox
    Friend WithEvents lblPassword As OPE_Controls.OpeLabel
    Friend WithEvents txtLoginId As OPE_Controls.opeTextBox
    Friend WithEvents lblLogin As OPE_Controls.OpeLabel
    Friend WithEvents dtpJoinDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblJoinDate As OPE_Controls.OpeLabel
    Friend WithEvents lblGivenName As OPE_Controls.OpeLabel
    Friend WithEvents lblSurName As OPE_Controls.OpeLabel
    Friend WithEvents txtSurName As OPE_Controls.opeTextBox
    Friend WithEvents cmbTitle As OPE_Controls.OpeComboBox2
    Friend WithEvents lblTitle As OPE_Controls.OpeLabel
    Friend WithEvents lblStaffId As OPE_Controls.OpeLabel
    Friend WithEvents txtGivenName As OPE_Controls.opeTextBox
    Friend WithEvents txtStaffId As OPE_Controls.OpeTextBox
    Friend WithEvents lblTelNo As OPE_Controls.OpeLabel
    Friend WithEvents txtTelNo As OPE_Controls.OpeTextBox
    Friend WithEvents lblNickName As OPE_Controls.OpeLabel
    Friend WithEvents txtNickName As OPE_Controls.OpeTextBox
    Friend WithEvents txtSNickName As OPE_Controls.OpeTextBox
    Friend WithEvents chkSNickName As OPE_Controls.OpeCheckBox
    Friend WithEvents btnHandy As OPE_Controls.OpeButton
    Friend WithEvents chkBMW As OPE_Controls.OpeCheckBox
    Friend WithEvents chkMB As OPE_Controls.OpeCheckBox
    Friend WithEvents chkCustomer As OPE_Controls.OpeCheckBox
    Friend WithEvents cboSCustomer As OPE_Controls.OpeComboBox2

End Class
