Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports System.IO

Public Class clsVStaff
    Private ctl As New clsCStaff
    Private ID As Integer = -1
    Private isUpdateProcess As Boolean = False
    Private dt As DataTable

    Private OBSWMC As New OBSWMC.OBSWMC
    Private lsportableDevices As List(Of OBSWMC.PortableDevice)

    Public Sub ShowForm(ByVal View As Integer, ByVal Add As Integer, ByVal Up As Integer, ByVal Del As Integer, ByVal Print As Integer, ByVal Other1 As Integer, ByVal Other2 As Integer, ByVal Other3 As Integer)
        ShowNewBotton = Add
        ShowUpdateBotton = Up
        ShowDeleteBotton = Del
        Me.Show()
    End Sub

    'Private Sub clsVStaff_ExportClick(sender As Object, e As System.EventArgs, ByRef Cancel As Boolean) Handles Me.ExportClick
    '    Cancel = True
    '    Converts.DataGridViewToCSV(grdData, , , CustomizeSetting.INI.ExportPath)
    'End Sub

    Private Sub clsVCompany_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim mForm As MainFormMDI = Me.ParentForm

        mForm.ChildFormClose(sender, e)
    End Sub

#Region " Overrides "
    Protected Overrides Sub LoadForm()
        ctl.DeletePrgLogging()
        LoadControl()
        DataSource = ctl.GetScreenData(, "-99999")

        Dim dtLength As DataTable = ComboSet.GetColumnLength("MstStaff")
        ComboSet.TextString(txtStaffId, dtLength, "StaffCode")
        ComboSet.TextString(txtSurName, dtLength, "SurName")
        ComboSet.TextString(txtGivenName, dtLength, "GivenName")
        ComboSet.TextString(txtNickName, dtLength, "NickName")
        ComboSet.TextString(txtLoginId, dtLength, "LoginID")
        ComboSet.TextString(txtPasswd, dtLength, "Password")
        ComboSet.TextString(txtTelNo, dtLength, "TelNo")
        ComboSet.TextString(txtRemark, dtLength, "Remark", True)


    End Sub

    Private Sub LoadControl()
        With txtSStaffId
            .DataSource = DataBase.DataSelect("MstStaff", "DelFlag = 0", , , "StaffCode")
            .DisplayMember = "StaffCode"
            .LinkCheckedBox = chkSStaffId
        End With
        With txtSLoginId
            .DataSource = DataBase.DataSelect("MstStaff", "DelFlag = 0", , , "LoginID")
            .DisplayMember = "LoginID"
            .LinkCheckedBox = chkSLoginId
        End With
        With txtSUserGroup
            .DataSource = DataBase.DataSelect("MstStaffGroup", "DelFlag = 0", , , , , , "StaffGroupCode")
            .DisplayMember = "StaffGroupName"
            .LinkCheckedBox = chkSUserGroupId
        End With
        With txtSSurName
            .DataSource = DataBase.DataSelect("MstStaff", "DelFlag = 0", , , "SurName")
            .DisplayMember = "SurName"
            .LinkCheckedBox = chkSSurName
        End With
        With txtSGivenName
            .DataSource = DataBase.DataSelect("MstStaff", "DelFlag = 0", , , "GivenName")
            .DisplayMember = "GivenName"
            .LinkCheckedBox = chkSGivenName
        End With
        With txtSNickName
            .DataSource = DataBase.DataSelect("MstStaff", "DelFlag = 0", , , "NickName")
            .DisplayMember = "NickName"
            .LinkCheckedBox = chkSNickName
        End With
        With cmbTitle
            .DisplayMember = "TitleName"
            .ValueMember = "TitleCode"
            .DisplayMemberList = "TitleCode,TitleName"
            .DataSource = DataBase.DataSelect("CstTitle", , , , , , , "TitleCode")
            .DropDownList = False
        End With
        With cmbUserGroup
            .DisplayMember = "StaffGroupName"
            .ValueMember = "StaffGroupCode"
            .DisplayMemberList = "StaffGroupCode,StaffGroupName"
            .DataSource = DataBase.DataSelect("MstStaffGroup", "DelFlag = 0", , , "StaffGroupCode,StaffGroupName", , , "StaffGroupCode")
            .DropDownList = False
        End With
        dtpJoinDate.CustomFormat = Styles.DateCustomFormat
        dtpJoinDate.Value = CustomizeSetting.SystemDate
    End Sub

    Protected Overrides Sub SetGridColumns()
        ColumnAdd_TextBox("StaffCode", "Staff Code", "StaffCode")
        ColumnAdd_TextBox("NickName", "NickName", "NickName")
        ColumnAdd_TextBox("TitleName", "Title", "TitleName", , True)
        ColumnAdd_TextBox("SurName", "SurName", "SurName")
        ColumnAdd_TextBox("GivenName", "GivenName", "GivenName")
        ColumnAdd_TextBox("TelNo", "Phone No.", "TelNo")
        ColumnAdd_TextBox("JoinDate", "Join Date", "JoinDate", , , DataGridViewContentAlignment.MiddleCenter, Styles.DateCustomFormat)
        ColumnAdd_TextBox("LoginID", "Login Id", "LoginID")
        ColumnAdd_TextBox("Password", "Password", "Password", , , , , False)
        ColumnAdd_TextBox("StaffGroupName", "User Group", "StaffGroupName")
        ColumnAdd_TextBox("Remark", "Remarks", "Remark")
        ColumnAdd_CheckBox("MBFlag", "MB", "MBFlag")
        ColumnAdd_CheckBox("BMWFlag", "BMW", "BMWFlag")
        ColumnAdd_TextBox("CreateDate", "Registered Date", "CreateDate", , , DataGridViewContentAlignment.MiddleCenter, Styles.DateCustomFormatDateTime)
        ColumnAdd_TextBox("CreateUserName", "Registered By", "CreateUserName")
        ColumnAdd_TextBox("UpdateDate", "Update Date", "UpdateDate", , , DataGridViewContentAlignment.MiddleCenter, Styles.DateCustomFormatDateTime)
        ColumnAdd_TextBox("UpdateUserName", "Update By", "UpdateUserName")

        CustomizeSetting.ComboSet.GridColumnSize(grdData)
    End Sub

#Region " Clear Data "
    Protected Overrides Sub clearData()
        Try
            txtStaffId.Text = ""
            cmbTitle.SelectedValue = -1
            cmbTitle.Text = ""
            txtSurName.Text = ""
            txtGivenName.Text = ""
            txtNickName.Text = ""
            cmbUserGroup.SelectedValue = -1
            cmbUserGroup.Text = ""
            dtpJoinDate.Value = Now
            txtLoginId.Text = ""
            txtPasswd.Text = ""
            txtRemark.Text = ""
            chkMB.Checked = False
            chkBMW.Checked = False
        Catch ex As Exception

        End Try

    End Sub
#End Region

#End Region

#Region " Search "
    Private Sub clsVStaff_SearchClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SearchClick
        If CheckUpdateData() = False Then Exit Sub

        Dim sCus As String = ""
        Dim sStaffId As String = ""
        Dim sLoginId As String = ""
        Dim sStaffGroupName As String = ""
        Dim sSurName As String = ""
        Dim sGivenName As String = ""
        Dim sNickName As String = ""

        If chkSStaffId.Checked Then
            sStaffId = txtSStaffId.Text.Trim
        End If
        If chkSLoginId.Checked Then
            sLoginId = txtSLoginId.Text.Trim.Replace("*", "%")
        End If
        If chkSUserGroupId.Checked Then
            sStaffGroupName = txtSUserGroup.Text.Trim
        End If
        If chkSSurName.Checked Then
            sSurName = txtSSurName.Text.Trim.Replace("*", "%")
        End If
        If chkSGivenName.Checked Then
            sGivenName = txtSGivenName.Text.Trim.Replace("*", "%")
        End If
        If chkSNickName.Checked Then
            sNickName = txtSNickName.Text.Trim.Replace("*", "%")
        End If
        DataSource = ctl.GetScreenData(sStaffId, sLoginId, sSurName, sGivenName, sNickName, sStaffGroupName)
    End Sub

    Private Sub chkSStaffId_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSStaffId.CheckedChanged
        If Not chkSStaffId.Checked Then
            txtStaffId.Text = ""
        End If
    End Sub

    Private Sub chkSSurName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSSurName.CheckedChanged
        If Not chkSSurName.Checked Then
            txtSSurName.Text = ""
        End If
    End Sub

    Private Sub chkSNickName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSNickName.CheckedChanged
        If Not chkSNickName.Checked Then
            txtSNickName.Text = ""
        End If
    End Sub

    Private Sub chkSLoginId_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSLoginId.CheckedChanged
        If Not chkSLoginId.Checked Then
            txtSLoginId.Text = ""
        End If
    End Sub

    Private Sub chkSGivenName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSGivenName.CheckedChanged
        If Not chkSGivenName.Checked Then
            txtSGivenName.Text = ""
        End If
    End Sub

    Private Sub chkSUserGroupId_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSUserGroupId.CheckedChanged
        If Not chkSUserGroupId.Checked Then
            txtSUserGroup.Text = ""
        End If
    End Sub
#End Region

#Region " New "
    Private Sub clsVStaff_NewClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.NewClick
        clearData()
        txtStaffId.Text = ""
        txtStaffId.Enabled = True
        txtStaffId.Focus()

        isUpdateProcess = False

    End Sub
#End Region

#Region " Update "
    Private Sub clsVStaff_UpdateClick(ByVal sender As Object, ByVal e As System.EventArgs, ByVal drGrd As System.Data.DataRow) Handles Me.UpdateClick

        isUpdateProcess = True
        clearData()
        txtStaffId.Text = OPE_Controls.OpeStyle.Converts.ToStr(drGrd("StaffCode"))
        txtStaffId.Enabled = False
        cmbTitle.SelectedValue = OPE_Controls.OpeStyle.Converts.ToInt_NullIsZero(drGrd("TitleCode"))
        txtSurName.Text = OPE_Controls.OpeStyle.Converts.ToStr(drGrd("SurName"))
        txtGivenName.Text = OPE_Controls.OpeStyle.Converts.ToStr(drGrd("GivenName"))
        txtNickName.Text = OPE_Controls.OpeStyle.Converts.ToStr(drGrd("NickName"))
        txtTelNo.Text = OPE_Controls.OpeStyle.Converts.ToStr(drGrd("TelNo"))
        dtpJoinDate.Value = OPE_Controls.OpeStyle.Converts.ToStr(drGrd("JoinDate"))
        txtLoginId.Text = OPE_Controls.OpeStyle.Converts.ToStr(drGrd("LoginID"))
        txtPasswd.Text = OPE_Controls.OpeStyle.Converts.ToStr(drGrd("Password"))
        cmbUserGroup.SelectedValue = OPE_Controls.OpeStyle.Converts.ToInt_NullIsZero(drGrd("StaffGroupCode"))
        txtRemark.Text = OPE_Controls.OpeStyle.Converts.ToStr(drGrd("REMARK"))
        chkMB.Checked = OPE_Controls.OpeStyle.Converts.ToInt_NullIsZero(drGrd("MBFlag"))
        chkBMW.Checked = OPE_Controls.OpeStyle.Converts.ToInt_NullIsZero(drGrd("BMWFlag"))
        txtStaffId.Focus()

        OKEnable = True

    End Sub

#End Region

#Region " OK "
    Private Sub clsVStaff_OKClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef drGrd As System.Data.DataRow, ByRef OkStatus As Boolean) Handles Me.OKClick
        If ValidateOK() Then
            drGrd("StaffCode") = txtStaffId.Text
            drGrd("TitleCode") = IIf(String.IsNullOrEmpty(cmbTitle.SelectedValue), "0", cmbTitle.SelectedValue)
            drGrd("TitleName") = cmbTitle.Text
            drGrd("SurName") = txtSurName.Text
            drGrd("GivenName") = txtGivenName.Text
            drGrd("NickName") = txtNickName.Text
            drGrd("TelNo") = txtTelNo.Text.Trim
            drGrd("JoinDate") = dtpJoinDate.Value
            drGrd("LoginID") = txtLoginId.Text
            drGrd("Password") = txtPasswd.Text
            drGrd("StaffGroupCode") = IIf(String.IsNullOrEmpty(cmbUserGroup.SelectedValue), "0", cmbUserGroup.SelectedValue)
            drGrd("StaffGroupName") = cmbUserGroup.Text
            drGrd("REMARK") = txtRemark.Text.Trim
            drGrd("MBFlag") = chkMB.Checked
            drGrd("BMWFlag") = chkBMW.Checked
            drGrd("UpdateDate") = CustomizeSetting.SystemDate
            drGrd("UpdateUser") = CustomizeSetting.StaffID
            drGrd("UpdateUserName") = CustomizeSetting.StaffNickName
            drGrd("DelFlag") = 0
            If drGrd("CreateDate") Is System.DBNull.Value Then
                drGrd("CreateDate") = drGrd("UpdateDate")
                drGrd("CreateUser") = drGrd("UpdateUser")
                drGrd("CreateUserName") = drGrd("UpdateUserName")
            End If
            OkStatus = True
            clearData()
        Else
            OkStatus = False
        End If
        isUpdateProcess = False
    End Sub
#End Region

#Region " Save "
    Private Sub clsVStaff_SaveClick(ByVal sender As Object, ByVal e As System.EventArgs, ByRef SaveStatus As Boolean) Handles Me.SaveClick
        OPE_Controls.OpeStyle.DataBase.BeginTrans()
        If ctl.SaveData(DataSource) Then
            OPE_Controls.OpeStyle.DataBase.CommitTrans()
        Else
            OPE_Controls.OpeStyle.DataBase.RollbackTrans()
        End If
    End Sub
#End Region

#Region " Check Before OK Click "
    Private Function ValidateOK() As Boolean
        Dim sta As Boolean = True
        Dim mForm As MainFormMDI = Me.ParentForm

        msgError.Clear()
        If txtStaffId.Text.Trim = "" Then
            msgError.SetError(txtStaffId, OPE_Controls.OpeStyle.Messages.Message(OPE_Controls.MessageType.PleaseInputData))
            sta = False
        End If

        If txtSurName.Text.Trim = "" Then
            msgError.SetError(txtSurName, OPE_Controls.OpeStyle.Messages.Message(OPE_Controls.MessageType.PleaseInputData))
            sta = False
        End If

        If txtLoginId.Text.Trim = "" Then
            msgError.SetError(txtLoginId, OPE_Controls.OpeStyle.Messages.Message(OPE_Controls.MessageType.PleaseInputData))
            sta = False
        End If

        If txtPasswd.Text.Trim = "" Then
            msgError.SetError(txtPasswd, OPE_Controls.OpeStyle.Messages.Message(OPE_Controls.MessageType.PleaseInputData))
            sta = False
        End If

        If cmbTitle.SelectedValue < 0 Or cmbTitle.SelectedValue Is Nothing Then
            msgError.SetError(cmbTitle, OPE_Controls.OpeStyle.Messages.Message(OPE_Controls.MessageType.PleaseSelectData))
            sta = False
        End If

        If cmbUserGroup.SelectedValue < 0 Or cmbUserGroup.SelectedValue Is Nothing Then
            msgError.SetError(cmbUserGroup, OPE_Controls.OpeStyle.Messages.Message(OPE_Controls.MessageType.PleaseSelectData))
            sta = False
        End If

        If isUpdateProcess Then
            Return True
            Exit Function
        End If

        If sta Then
            For Each dr As DataRow In DataSource.Rows
                If txtLoginId.Text.Trim <> "" AndAlso UCase(OPE_Controls.OpeStyle.Converts.ToStr(dr("LoginID"))) = UCase(txtLoginId.Text.Trim) Then
                    msgError.SetError(txtLoginId, OPE_Controls.OpeStyle.Messages.Message(OPE_Controls.MessageType.DataExistPleaseChange))
                    sta = False
                    Exit For
                End If

                If txtStaffId.Text.Trim <> "" AndAlso UCase(OPE_Controls.OpeStyle.Converts.ToStr(dr("StaffCode"))) = UCase(txtStaffId.Text.Trim) Then
                    msgError.SetError(txtStaffId, OPE_Controls.OpeStyle.Messages.Message(OPE_Controls.MessageType.DataExistPleaseChange))
                    sta = False
                    Exit For
                End If
            Next

            dt = ctl.GetScreenData(, txtLoginId.Text.Trim, , , , True)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                msgError.SetError(txtLoginId, OPE_Controls.OpeStyle.Messages.Message(OPE_Controls.MessageType.DataExistPleaseChange))
                sta = False
            End If

            dt = ctl.GetScreenData(txtStaffId.Text.Trim, , , , , , True)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                msgError.SetError(txtStaffId, OPE_Controls.OpeStyle.Messages.Message(OPE_Controls.MessageType.DataExistPleaseChange))
                sta = False
            End If

        End If

        Return sta
    End Function
#End Region

#Region "Transfer Master File to handy"
    Private Sub btnHandy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHandy.Click
        Do
            If DeviceConnect() = False Then
                If MsgBox("Please connect device", MsgBoxStyle.OkCancel, "Connection Alert") = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            Else
                Exit Do
            End If
        Loop

        If CreateMasterFile() = False Then
            MessageBox.Show("Create file error, please try again")
        End If


        If SendMasterFile() = True Then
            MessageBox.Show("Export Staff to handy successful")
        Else
            MessageBox.Show("Send file error, please try again")
        End If


    End Sub
    Private Function DeviceConnect() As Boolean
        lsportableDevices = OBSWMC.getDevices()
        If lsportableDevices.Count <= 0 Then Return False
        'MC92000
        Dim iPortable As Integer = -1
        For iLoop As Integer = 0 To lsportableDevices.Count - 1
            If InStr(lsportableDevices(iLoop).Name.ToUpper, "MC92000", CompareMethod.Text) Then
                iPortable = iLoop
            End If
        Next

        OBSWMC.PortableDevice = lsportableDevices(iPortable)
        If OBSWMC.Connect() Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function CreateMasterFile() As Boolean

        Try
            Dim dt As DataTable = DataBase.DataSelect("MstStaff", "DelFlag=0", , , "StaffCode")

            If Directory.Exists(INI.InterfaceStaff) = False Then
                Directory.CreateDirectory(INI.InterfaceStaff)
            End If
            If File.Exists(INI.InterfaceStaff & INI.StaffFilename) Then
                File.Delete(INI.InterfaceStaff & INI.StaffFilename)
            End If

            Dim RCHCmd As New FileStream(INI.InterfaceStaff & INI.StaffFilename, FileMode.OpenOrCreate, FileAccess.Write)
            Dim RCHCmdW As New StreamWriter(RCHCmd)
            For Each dr As DataRow In dt.Rows
                Dim str As String = dr("StaffCode").ToString

                RCHCmdW.WriteLine(str)
            Next
            RCHCmdW.Close()
            RCHCmd.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Function SendMasterFile() As Boolean
        Dim PCPath As String = INI.InterfaceStaff & INI.StaffFilename
        Dim HandyFile As String = INI.HandyInterface & "\Staff" & INI.StaffFilename


        Dim obj As Object = OBSWMC.getFile(HandyFile)
        If Not obj Is Nothing Then
            OBSWMC.DeleteFile(HandyFile)
            If (String.IsNullOrEmpty(OBSWMC.Err)) = False Then
                Return False
            End If
        End If

        OBSWMC.CopyFileToDevice(PCPath, INI.HandyInterface & "/Staff")
        If (String.IsNullOrEmpty(OBSWMC.Err)) Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
    Private Function CheckUpdateData() As Boolean
        If gbUpdateData.Visible = True Then
            MessageBox.Show("Please click OK or Cancel to close editing area")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub clsVStaff_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckUpdateData() = False Then e.Cancel = True
    End Sub
End Class
