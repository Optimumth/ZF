Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting


Public Class clsVSystemConfig
    Private ctrl As New clsCSystemConfig

#Region "Form Load"
    Private Sub clsVSystemConfig_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ComboSet.TextInt(txtRackColumn)
        ComboSet.TextInt(txtAutoMBHrs)
        ComboSet.TextInt(txtMBDue)

        Dim dtLength As DataTable = ComboSet.GetColumnLength("MstSystemConfig")
        ComboSet.TextString(txtOutlogPath, dtLength, "OutlogFile")
        ComboSet.TextString(txtReportPath, dtLength, "ReportPath")

        ReloadData()
    End Sub
#End Region

#Region "Reload Data"
    Private Sub ReloadData()
        Dim dt As DataTable = ctrl.MstSystemConfig
        If dt.Rows.Count = 0 Then Exit Sub
        Dim dr As DataRow = dt.Rows(0)
        txtRackColumn.Text = Converts.ToInt_NullIsZero(dr("RackColumn"))
        txtAutoMBHrs.Text = Converts.ToInt_NullIsZero(dr("AutoMBHR"))
        txtMBDue.Text = Converts.ToInt_NullIsZero(dr("MBDue"))
        txtOutlogPath.Text = Converts.ToStr(dr("OutlogFile"))
        txtReportPath.Text = Converts.ToStr(dr("ReportPath"))

        btnSave.Enabled = False
    End Sub
#End Region

#Region "Control Changed"
    Private Sub ControlChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRackColumn.TextChanged, txtAutoMBHrs.TextChanged, txtOutlogPath.TextChanged, txtReportPath.TextChanged, txtMBDue.TextChanged, txtCurPassword.TextChanged, txtNewPassword.TextChanged, txtConfirmPassword.TextChanged

        btnSave.Enabled = True

    End Sub
#End Region

#Region "Save Data"
    Private Sub btnSave_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnSave.Click
        If SaveData() = False Then
            Me.DialogResult = Windows.Forms.DialogResult.No
        Else
            btnSave.Enabled = False
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnSave_Validate(sender As Object, e As OPE_Controls.EventArgs) Handles btnSave.Validate
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        If Not IsNumeric(txtRackColumn.Text.Trim) Then bTrue = bTrue And Messages.SetError(ErrProvider, txtRackColumn, OPE_Controls.MessageType.InvalidFormat)
        If Not IsNumeric(txtAutoMBHrs.Text.Trim) Then bTrue = bTrue And Messages.SetError(ErrProvider, txtAutoMBHrs, OPE_Controls.MessageType.InvalidFormat)
        If Not IsNumeric(txtMBDue.Text.Trim) Then bTrue = bTrue And Messages.SetError(ErrProvider, txtMBDue, OPE_Controls.MessageType.InvalidFormat)

        If txtCurPassword.Text.Trim <> "" Or txtNewPassword.Text.Trim <> "" Or txtConfirmPassword.Text.Trim <> "" Then
            If txtCurPassword.Text.Trim <> INI.RackStatusPassword Then
                bTrue = bTrue And Messages.SetError(ErrProvider, txtCurPassword, OPE_Controls.MessageType.None, "Invalid Data")
            ElseIf txtNewPassword.Text.Trim = "" Then
                bTrue = bTrue And Messages.SetError(ErrProvider, txtNewPassword, OPE_Controls.MessageType.PleaseInputData)
            ElseIf txtConfirmPassword.Text.Trim = "" Then
                bTrue = bTrue And Messages.SetError(ErrProvider, txtConfirmPassword, OPE_Controls.MessageType.PleaseInputData)
            ElseIf txtNewPassword.Text.Trim <> txtConfirmPassword.Text.Trim Then
                bTrue = bTrue And Messages.SetError(ErrProvider, txtConfirmPassword, OPE_Controls.MessageType.None, "Invalid Data")
            End If
        End If


        If Not bTrue Then e.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Function SaveData() As Boolean
        Dim ret As Boolean = True

        Dim dt As DataTable = DataBase.DataSelect("MstSystemConfig")
        Dim drSystemConfig As DataRow
        If dt.Rows.Count = 0 Then
            drSystemConfig = dt.NewRow
        Else
            drSystemConfig = dt.Rows(0)
        End If

        drSystemConfig("RackColumn") = txtRackColumn.Text.Trim
        drSystemConfig("AutoMBHr") = txtAutoMBHrs.Text.Trim
        drSystemConfig("OutlogFile") = txtOutlogPath.Text.Trim
        drSystemConfig("ReportPath") = txtReportPath.Text.Trim
        drSystemConfig("MBDue") = txtMBDue.Text.Trim
        If txtNewPassword.Text.Trim <> "" Then
            drSystemConfig("AuthorRackStatus") = txtNewPassword.Text.Trim
        End If

        ret = ctrl.Save(drSystemConfig)

        Return ret
    End Function
#End Region
#Region "Select Document Path"
    Private Sub btnPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutlogPath.Click, btnReportPath.Click
        Dim fDia As New FolderBrowserDialog
        Select Case sender.name
            Case btnOutlogPath.Name
                If txtOutlogPath.Text.Trim <> "" Then fDia.SelectedPath = txtOutlogPath.Text.Trim
            Case btnReportPath.Name
                If txtReportPath.Text.Trim <> "" Then fDia.SelectedPath = txtReportPath.Text.Trim
        End Select

        If fDia.ShowDialog = Windows.Forms.DialogResult.OK Then
            Select Case sender.name
                Case btnOutlogPath.Name
                    txtOutlogPath.Text = fDia.SelectedPath : If Strings.Right(txtOutlogPath.Text, 1) = "\" Then txtOutlogPath.Text = Strings.Left(txtOutlogPath.Text.Trim, txtOutlogPath.TextLength - 1)
                Case btnReportPath.Name
                    txtReportPath.Text = fDia.SelectedPath : If Strings.Right(txtReportPath.Text, 1) = "\" Then txtReportPath.Text = Strings.Left(txtReportPath.Text.Trim, txtReportPath.TextLength - 1)
            End Select
            btnSave.Enabled = True
        End If
    End Sub

#End Region
End Class