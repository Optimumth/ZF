Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVRackReview
    Private cls As New clsCRackReview

#Region "Load"
    Private Sub clsVRackReview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
    Private Sub LoadForm()
        With cboSType
            .ValueMember = "ID"
            .DisplayMember = "Name"
            .DataSource = DataBase.DataSelect("CstModelType")
            .LinkCheckedBox = chkSType
        End With
        With cboSModel
            .ValueMember = "ID"
            .DisplayMember = "Model"
            .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0", , , , , , "Model")
            .LinkCheckedBox = chkSModel
        End With
        With cboSCode
            .ValueMember = "Code"
            .DisplayMember = "Code"
            .DataSource = DataBase.DataSelect("MstRackHD", "DelFlag=0", , , "distinct Code", , , "Code")
            .LinkCheckedBox = chkSCode
        End With
        With cboSRemark
            .ValueMember = "Remark"
            .DisplayMember = "Remark"
            .DataSource = DataBase.DataSelect("MstRackHD", "DelFlag=0", , , "distinct Remark", , , "Remark")
            .LinkCheckedBox = chkSRemark
        End With

        Dim dt As DataTable = cls.GetData(True, 99, False, 0, False, "", False, "")
        grdData.DataSource = dt
    End Sub
#End Region
#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_TextBox("TypeName", "Type", "TypeName")
            .ColumnAdd_TextBox("Model", "Model", "Model")
            .ColumnAdd_TextBox("Code", "Code", "Code")
            .ColumnAdd_TextBox("Remark", "Remark", "Remark")
            .ColumnAdd_TextBox("RackNo", "Running No.", "RackNo")
            .ColumnAdd_TextBox("RackID", "Rack ID", "RackID", 100)
            .ColumnAdd_TextBox("Show", "Show", "Show", 100)
            .ColumnAdd_CheckBox("ActiveFlag", "Active", "ActiveFlag")
            .ColumnAdd_CheckBox("LossFlag", "Loss", "LossFlag")
            .ColumnAdd_TextBox("LossDate", "Loss Date", "LossDate", 100, , DataGridViewContentAlignment.MiddleCenter, Styles.DateCustomFormatDateTime)
            .ColumnAdd_TextBox("LossRemark", "Loss Remark", "LossRemark", 200)
        End With
        ComboSet.GridColumnSize(grdData)
    End Sub
#End Region
#Region "Toolbar Click"
    Private Sub btnSearch_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Click
        Dim dt As DataTable = cls.GetData(chkSType.Checked, cboSType.SelectedValue _
                                          , chkSModel.Checked, cboSModel.SelectedValue _
                                          , chkSCode.Checked, cboSCode.SelectedValue _
                                          , chkSRemark.Checked, cboSRemark.SelectedValue)
        grdData.DataSource = dt
        grdData_BindingGridColumns()
    End Sub
    Private Sub btnSearch_Validate(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Validate
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        If chkSType.Checked And cboSType.SelectedIndex < 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, cboSType, OPE_Controls.MessageType.PleaseSelectDataInList)
        If chkSModel.Checked And cboSModel.SelectedIndex < 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, cboSModel, OPE_Controls.MessageType.PleaseSelectDataInList)
        If chkSCode.Checked And cboSCode.SelectedIndex < 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, cboSCode, OPE_Controls.MessageType.PleaseSelectDataInList)
        If chkSRemark.Checked And cboSRemark.SelectedIndex < 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, cboSType, OPE_Controls.MessageType.PleaseSelectDataInList)

        If Not bTrue Then e.DialogResult = Windows.Forms.DialogResult.No
    End Sub
#End Region
End Class