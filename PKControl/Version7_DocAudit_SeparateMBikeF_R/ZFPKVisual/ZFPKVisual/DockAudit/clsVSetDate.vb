Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVSetDate
    Public mRowDockAudit As DataRow
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_TextBox("Barcode", "Barcode", "Barcode", 200)
            .ColumnAdd_TextBox("Check4_Date", "Set Date", "Check4_Date", 200, , DataGridViewContentAlignment.MiddleCenter, Styles.DateCustomFormat, , True)
            .ColumnAdd_TextBox("ID", "ID", "ID", , , , , False)
        End With
        ComboSet.GridColumnSize(grdData)
    End Sub

    Private Sub clsVSetDate_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sRackID() As String = Strings.Split(mRowDockAudit("RackID"), ",")

        Dim cond As String = "where MstRackDT.RackID in ("
        For i As Integer = 0 To sRackID.Length - 1
            If i > 0 Then cond &= ","
            cond &= "'" & sRackID(i) & "'"
        Next
        cond &= ")"
        Dim sModelDockID As Integer = mRowDockAudit("ModelDockID")
        Dim sVarian As String = mRowDockAudit("Varian")
        Dim sLot As String = mRowDockAudit("Lot")
        Dim iAxleShock_Axle As Integer = 1
        Dim sql As String = String.Format( _
            "select PrgDockAudit.ID, Barcode, Check4_Date {0}" & _
            "from PrgDockAudit {0}" & _
            "inner join MstRackDT on PrgDockAudit.RackDTID=MstRackDT.ID and MstRackDT.DelFlag=0 {0}" & _
            "{1}{0}" & _
            "and ModelDockID=" & sModelDockID & " {0}" & _
            "and Varian='" & sVarian & "' {0}" & _
            "and Lot='" & sLot & "' {0}" & _
            "and CompleteFlag=1 and AxleShock=1  {0}" & _
            "order by Barcode {0}" & _
            "", vbCrLf, cond)
        Dim dt As DataTable = DataBase.DataTable(sql)
        grdData.DataSource = dt
        SetRowHight()
        btnSave.Enabled = True
    End Sub

    Private Sub SetRowHight()
        With grdData
            For iRow As Integer = 0 To grdData.RowCount - 1
                .Rows(iRow).Height = 40
            Next
        End With
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSave.Click
        If grdData.RowCount = 0 Then Exit Sub
        For i As Integer = 0 To grdData.RowCount - 1
            Dim ID As Long = grdData.Rows(i).Cells("ID").Value
            Dim sDate As String = ""
            If Converts.ToStr(grdData.Rows(i).Cells("Check4_Date").Value) = "" Then
                DataBase.runSQL("update PrgDockAudit set Check4_Date=null where ID=" & ID & "")
            Else
                sDate = Strings.Format(grdData.Rows(i).Cells("Check4_Date").Value, "yyyy-MM-dd")
                DataBase.runSQL("update PrgDockAudit set Check4_Date='" & sDate & "'  where ID=" & ID & "")
            End If
        Next
        btnSave.Enabled = False
        Me.Close()
    End Sub
End Class