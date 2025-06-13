Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVAuditList
#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_CheckBox("chk", "", "chk", , , , True)
            .ColumnAdd_TextBox("Axle", "Axle", "Axle", 100)
            .ColumnAdd_TextBox("Side", "Side", "Side")
            .ColumnAdd_TextBox("sta", "sta", "sta", , , , , False)
        End With
        ComboSet.GridColumnSize(grdData)
    End Sub
#End Region
    Private Sub clsVAuditList_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim dt As New DataTable
        dt.Columns.Add("chk", GetType(String))
        dt.Columns.Add("Axle", GetType(String))
        dt.Columns.Add("Variant", GetType(String))
        dt.Columns.Add("Side", GetType(String))

        Dim dr As DataRow = dt.NewRow
        dr("chk") = 0
        dr("Axle") = "02"
        dr("Side") = "X"
        dt.Rows.Add(dr)

        grdData.DataSource = dt

    End Sub

    Private Sub SetRowHight()
        With grdData
            For iRow As Integer = 0 To grdData.RowCount - 1
                .Rows(iRow).Height = 40
            Next
        End With
    End Sub

    Private Sub clsVAuditList_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        SetRowHight()
    End Sub
End Class