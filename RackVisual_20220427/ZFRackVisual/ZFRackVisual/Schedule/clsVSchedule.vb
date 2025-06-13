Imports OPE_Controls.OpeStyle
Imports ZFRackVisual.CustomizeSetting

Public Class clsVSchedule
    Public cls As New clsCSchedule
    Public dtProduction As DataTable = Nothing

    Private Sub clsVSchedule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'General
        dtpStartDate.Value = Now.Date
        txtDays.Text = 5
        txtCapacity.Text = 4
        'ZF Delivery
        txtIniEmptyRack.Text = 0
        txtInitialFG.Text = 0
        txtTripPerDay.Text = 6
        txtQtyPerTrip.Text = 0
        'Return to ZF
        txtEmptyRack.Text = 0
        txtBlockForSkiplot.Text = 0
        txtBlockForMaintenance.Text = 0

        CalHeader()
    End Sub

    Private Sub btnChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChart.Click
        CalHeader()
        ShowChart()
    End Sub

    Private Sub CalHeader()
        txtWorkingHrs.Text = cls.GetProdHr
        txtWorkTime.Text = cls.GetProdMin
        txtTotalCapacity.Text = Converts.ToInt_NullIsZero(txtWorkTime.Text) / 60 * Converts.ToInt_NullIsZero(txtCapacity.Text)
        txtTrackTime.Text = Converts.ToInt_NullIsZero(txtWorkTime.Text) / Converts.ToInt_NullIsZero(txtTotalCapacity.Text)
    End Sub

    Private Sub ShowChart()
        Dim TrackMin As Integer = Converts.ToInt_NullIsZero(txtTrackTime.Text.Trim)
        dtProduction = cls.GetTrackTime(TrackMin)
        dtProduction = cls.GetProdQty(dtProduction)
        dtProduction = cls.GetProdAccumulate(dtProduction)
        grdEmptyRack.DataSource = dtProduction
        grdEmptyRack_BindingGridColumns()

        Dim dtTimePivot As New DataTable
        dtTimePivot.Columns.Add("Time", GetType(String))
        For Each drTime As DataRow In dtProduction.Select("", "ID")
            dtTimePivot.Columns.Add(drTime("Desc"), GetType(Integer))
        Next

        For Each drTime As DataRow In dtProduction.Select("", "ID")
            For iCol As Integer = 0 To dtProduction.Columns.Count - 1
                Dim ColName As String = dtProduction.Columns(iCol).ColumnName
                If Not (ColName = "ID" Or ColName = "Desc") Then
                    If dtTimePivot.Compute("count(Time)", "Time='" & ColName & "'") = 0 Then
                        Dim drAddPivot As DataRow = dtTimePivot.NewRow
                        drAddPivot("Time") = ColName
                        drAddPivot(drTime("Desc")) = drTime(ColName)
                        dtTimePivot.Rows.Add(drAddPivot)
                    Else
                        For Each drTimePivot As DataRow In dtTimePivot.Select("Time='" & ColName & "'")
                            drTimePivot(drTime("Desc")) = drTime(ColName)
                        Next
                    End If
                End If
            Next
        Next

        'With chtEmptyRack
        '    .Series.Clear()
        '    .DataSource = dtTimePivot
        '    .Series.Add("Accumulate")
        '    .Series("Accumulate").XValueMember = "Time"
        '    .Series("Accumulate").XValueType = DataVisualization.Charting.ChartValueType.String
        '    .Series("Accumulate").YValueMembers = "Accumulate"
        '    .Series("Accumulate").YValueType = DataVisualization.Charting.ChartValueType.Int32
        'End With
        With chtEmptyRack.ChartAreas(0)
            .AxisX.Title = "Time"
            .AxisY.Title = "Quantity"
        End With
    End Sub

#Region "Empty Rack"
    Private Sub grdEmptyRack_BindingGridColumns() Handles grdEmptyRack.BindingGridColumns
        With grdEmptyRack
            .Columns.Clear()
            If .DataSource Is Nothing Then Exit Sub
            Dim dt As DataTable = .DataSource

            For iCol As Integer = 0 To dt.Columns.Count - 1
                If dt.Columns(iCol).ColumnName = "ID" Then
                ElseIf dt.Columns(iCol).ColumnName = "Desc" Then
                    .ColumnAdd_TextBox(dt.Columns(iCol).ColumnName, dt.Columns(iCol).ColumnName, dt.Columns(iCol).ColumnName, 100)
                Else
                    .ColumnAdd_TextBox(dt.Columns(iCol).ColumnName, dt.Columns(iCol).ColumnName, dt.Columns(iCol).ColumnName)
                End If

            Next
            .AllowUserToAddRows = False
        End With
        ComboSet.GridColumnSize(grdEmptyRack)
    End Sub
#End Region
    
End Class