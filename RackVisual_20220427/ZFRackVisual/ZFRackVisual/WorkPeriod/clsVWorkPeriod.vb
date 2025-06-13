Public Class clsVWorkPeriod
    Private cls As New clsCWorkPeriod

    Private Sub clsVWorkPeriod_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        grdData.DataSource = cls.getMasterTime
        SetRowHight()
    End Sub

    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_TextBox("Type", "Type", "Type", , , , , , True)
            .ColumnAdd_TextBox("Period", "Period", "Period", , , , , , True)
            .ColumnAdd_TextBox("Start", "Start", "Start", , , , , , True)
            .ColumnAdd_TextBox("Stop", "Stop", "Stop", , , , , , True)
        End With
    End Sub

    Private Sub SetRowHight()
        With grdData
            For iRow As Integer = 0 To grdData.RowCount - 1
                .Rows(iRow).Height = 40
            Next
        End With
    End Sub

    Private Sub grdData_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnSave.Click
        cls.WriteMstPeriod(grdData.DataSource)
    End Sub
End Class