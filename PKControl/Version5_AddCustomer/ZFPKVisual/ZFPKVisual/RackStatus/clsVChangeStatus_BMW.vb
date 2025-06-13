Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVChangeStatus_BMW
    Public mRackDTID As Integer

    Private cls As New clsCChangeStatus
    Private mCurStatus As String = ""
    Private mLoading As Boolean = True


    Private Sub clsVChangeStatus_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim dt As DataTable = cls.GetData(mRackDTID)
        Dim dr As DataRow = dt.Rows(0)
        txtType.Text = dr("Type")
        txtModel.Text = dr("Model")
        txtCode.Text = dr("Code")
        txtRemark.Text = Converts.ToStr(dr("Remark"))
        txtRunningNo.Text = dr("RackNo")
        txtRackID.Text = dr("RackID")
        mCurStatus = dr("RackStatus")
        Select Case dr("RackStatus")
            Case CustomizeSetting.INI.Status_ZF : rdoZF.Checked = True
            Case CustomizeSetting.INI.Status_Customer : rdoMB.Checked = True
            Case CustomizeSetting.INI.Status_OnTruck : rdoOnTruck.Checked = True
            Case CustomizeSetting.INI.Status_Supplier : rdoSupplier.Checked = True
            Case CustomizeSetting.INI.Status_ExtWH : rdoExtWH.Checked = True
            Case CustomizeSetting.INI.Status_FG : rdoFG.Checked = True
            Case CustomizeSetting.INI.Status_RepairInZF : rdoRepairInZF.Checked = True
        End Select
        If dr("LossFlag") = 1 Then
            rdoZF.Enabled = False
            rdoMB.Enabled = False
            rdoOnTruck.Enabled = False
            rdoSupplier.Enabled = False
            rdoExtWH.Enabled = False
            rdoFG.Enabled = False
            rdoRepairInZF.Enabled = False
            txtPassword.ReadOnly = True
        End If
    End Sub

    Private Sub clsVChangeStatus_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        mLoading = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnSave.Click
        Dim NewStatus As String = ""
        If rdoZF.Checked Then NewStatus = CustomizeSetting.INI.Status_ZF
        If rdoMB.Checked Then NewStatus = CustomizeSetting.INI.Status_Customer
        If rdoOnTruck.Checked Then NewStatus = CustomizeSetting.INI.Status_OnTruck
        If rdoSupplier.Checked Then NewStatus = CustomizeSetting.INI.Status_Supplier
        If rdoExtWH.Checked Then NewStatus = CustomizeSetting.INI.Status_ExtWH
        If rdoFG.Checked Then NewStatus = CustomizeSetting.INI.Status_FG
        If rdoRepairInZF.Checked Then NewStatus = CustomizeSetting.INI.Status_RepairInZF
        If mCurStatus <> NewStatus Then
            If Not (mCurStatus = CustomizeSetting.INI.Status_OnTruck And NewStatus = CustomizeSetting.INI.Status_Customer) Then
                If cls.Save(mRackDTID, mCurStatus, NewStatus) = True Then
                    Me.DialogResultData = NewStatus
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If
        End If
    End Sub
    Private Sub btnSave_Validate(sender As Object, e As OPE_Controls.EventArgs) Handles btnSave.Validate
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        If txtPassword.Text.Trim = "" Then
            bTrue = bTrue And Messages.SetError(ErrProvider, txtPassword, OPE_Controls.MessageType.PleaseInputData)
        ElseIf txtPassword.Text.Trim <> INI.RackStatusPassword Then
            bTrue = bTrue And Messages.SetError(ErrProvider, txtPassword, OPE_Controls.MessageType.None, "Invalid Password")
        End If

        If Not bTrue Then e.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub rdo_CheckedChanged(sender As Object, e As System.EventArgs) Handles rdoZF.CheckedChanged, rdoMB.CheckedChanged, rdoOnTruck.CheckedChanged, rdoSupplier.CheckedChanged, rdoExtWH.CheckedChanged
        If mLoading = False Then
            btnSave.Enabled = True
        End If
    End Sub


End Class