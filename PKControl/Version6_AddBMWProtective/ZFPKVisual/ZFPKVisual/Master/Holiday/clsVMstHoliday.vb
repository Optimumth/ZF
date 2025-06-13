Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVMstHoliday
    Private cls As New clsCMstHoliday
#Region "Load"
    Private Sub clsVMstHoliday_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If
        LoadForm()
    End Sub
    Private Sub LoadForm()
        dtpSMonth.Value = CustomizeSetting.SystemDate
        dtpSMonth.LinkCheckedBox = chkSMonth

        Dim dt As DataTable = cls.GetData(True, 0, 0)
        grdData.DataSource = dt

    End Sub
#End Region

#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_TextBox("Holiday", "Holiday", "Holiday", 100)
        End With
    End Sub
#End Region

#Region "Toolbar Click"
    Private Sub btnSearch_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Click
        Dim dt As DataTable = cls.GetData(chkSMonth.Checked, dtpSMonth.Value.Month, dtpSMonth.Value.Year)
        grdData.DataSource = dt
        If dt.Rows.Count > 0 Then btnDelete.Enabled = True Else btnDelete.Enabled = False
    End Sub

    Private Sub btnNew_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnNew.Click
        Dim frm As New clsVAddHoliday
        frm.dtOldDate = grdData.DataSource
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            grdData.DataSource = frm.dtNewDate
        End If

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnDelete.Click
        If grdData.SelectedRow Is Nothing Then Exit Sub

        grdData.SelectedRow("_Status") = "D"
        Dim dt As DataTable = grdData.DataSource

        Dim ctl As New clsCMstHoliday
        If ctl.SaveData(dt) = True Then
            dt = cls.GetData(chkSMonth.Checked, dtpSMonth.Value.Month, dtpSMonth.Value.Year)
            grdData.DataSource = dt
        End If

    End Sub
#End Region


    Private Sub grdData_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.RowEnter
        If grdData.DataSource Is Nothing Then Exit Sub

        Dim dt As DataTable = grdData.DataSource
        If dt.Rows.Count > 0 Then
            btnDelete.Enabled = True
        Else
            btnDelete.Enabled = False
        End If
    End Sub
End Class