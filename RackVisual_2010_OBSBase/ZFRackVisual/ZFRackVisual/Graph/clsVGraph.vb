Imports OPE_Controls.OpeStyle

Public Class clsVGraph

    Private Sub clsVGraph_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Chart1.Series.Clear()

        Dim dt As DataTable = DataBase.DataTable("select convert(date,ScanDateTime) as ScanDate,[To] as sTo,count([To]) as cTo from PrgTransaction group by convert(date,ScanDateTime),[To]")
        Chart1.DataSource = dt
        'Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
        'Chart1.Series(0).XValueMember = "sTo"
        'Chart1.Series(0).YValueMembers = "cTo"
        Chart1.DataBindCrossTable(dt.AsEnumerable, "sTo", "ScanDate", "cTo", Nothing)
    End Sub

    Private Sub OpeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpeButton1.Click
        Application.Exit()
    End Sub
End Class