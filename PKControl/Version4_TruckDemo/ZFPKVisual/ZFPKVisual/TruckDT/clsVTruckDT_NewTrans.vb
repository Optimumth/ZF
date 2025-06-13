Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVTruckDT_NewTrans
    Dim cls As New clsCTruckDT

    Private Sub clsVTruckDT_NewTrans_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadForm()
    End Sub

    Private Sub LoadForm()
        ComboSet.DateTime(dtpDate1, chkLogDate, dtpDate2)
        Dim LastLogDate As Date = cls.GetLastLogDate
        Dim Date1 As Date = LastLogDate
        Dim Date2 As Date = LastLogDate
        dtpDate1.Value = Date1
        dtpDate2.Value = Date2

        grdData.DataSource = cls.GetTransEmpty(chkLogDate.Checked, dtpDate1.Value.Date, dtpDate2.Value.Date)
    End Sub

#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_CheckBox("chk", "", "chk", , , , True)
            .ColumnAdd_TextBox("LogDate", "Log Date", "LogDate", 200, , DataGridViewContentAlignment.MiddleCenter, Styles.DateCustomFormatDateTime)
            .ColumnAdd_TextBox("RackID", "RackID", "RackID", 100)
            .ColumnAdd_TextBox("RackNo", "RackNo", "RackNo")
            .ColumnAdd_TextBox("Show", "Show", "Show", 100)
            .ColumnAdd_TextBox("ScanDateTime", "Scan Date Time", "ScanDateTime", 200, , DataGridViewContentAlignment.MiddleCenter, Styles.DateCustomFormatDateTime)

        End With
        ComboSet.GridColumnSize(grdData)
    End Sub
#End Region

#Region "Select New Rack"
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnOK.Click
        SelectRow()
    End Sub
    Private Sub SelectRow()
        Dim dtGrd As DataTable = grdData.DataSource
        Dim dtSelected As DataTable = dtGrd.Clone
        For Each drSelected As DataRow In dtGrd.Select()
            If Converts.ToInt_NullIsZero(drSelected("chk")) = 1 Then
                dtSelected.ImportRow(drSelected)
            End If
        Next

        Me.DialogResult = IIf(dtSelected.Rows.Count > 0, Windows.Forms.DialogResult.Yes, Windows.Forms.DialogResult.No)
        Me.DialogResultData = dtSelected
    End Sub
    Private Sub btnCheckAll_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnCheckAll.Click
        If grdData.DataSource Is Nothing Then Exit Sub
        For Each dr As DataRow In grdData.DataSource.select()
            dr("chk") = 1
        Next
    End Sub
    Private Sub btnReleaseAll_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnReleaseAll.Click
        If grdData.DataSource Is Nothing Then Exit Sub
        For Each dr As DataRow In grdData.DataSource.select()
            dr("chk") = 0
        Next
    End Sub
#End Region

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnSearch.Click
        grdData.DataSource = cls.GetTransEmpty(chkLogDate.Checked, dtpDate1.Value.Date, dtpDate2.Value.Date)
    End Sub
End Class