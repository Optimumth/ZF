Imports OPE_Controls.OpeStyle
Imports ZFRackVisual.CustomizeSetting
Imports System.Windows.Forms.DataVisualization.Charting

Public Class clsVSchedule
    Public cls As New clsCSchedule
    Public dtOverview As DataTable = Nothing
    Public dtZFEmptyRack() As DataTable = Nothing
    Public dtZFFG() As DataTable = Nothing
    Public dtCusFG() As DataTable = Nothing
    Public dtCusEmptyReturn() As DataTable = Nothing

    Private fShowConfig As Boolean = True
    Dim NDay As Integer = 0
    Dim Calculated As Boolean = False

#Region "Load"
    Private Sub clsVSchedule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'General()
        txtDays.Text = 5

        'ZF
        txtCapacityZF.Text = 0
        txtIniEmptyRackZF.Text = 0
        txtInitialFGZF.Text = 0
        txtQtyPerTripZF.Text = 0
        txtBlockForSkiplot.Text = 0
        txtBlockForMaintenance.Text = 0
        txtTravelMinsZF.Text = 0

        'Customer
        txtCapacityCus.Text = 0
        txtIniEmptyRackCus.Text = 0
        txtInitialFGCus.Text = 0
        txtQtyPerTripCus.Text = 0
        txtTravelMinsCus.Text = 0

        CalHeader()

        btnPrint.Enabled = False
    End Sub

    Private Sub btnChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChart.Click
        CalHeader()
        If CalValidate() = True Then
            NDay = txtDays.Text.Trim
            CalculateData()
            ShowChart()
            TabControl.SelectedIndex = clsCSchedule.eGridType.OverView
            Calculated = True
            btnPrint.Enabled = True
        End If
    End Sub

    Private Function CalValidate() As Boolean
        Dim bTrue As Boolean = True

        ErrProvider.Clear()
        If Converts.ToInt_NullIsZero(txtDays.Text.Trim) = 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, txtDays, OPE_Controls.MessageType.None, "Day must be > 0")
        If txtCapacityZF.Text.Trim = "" OrElse txtCapacityZF.Text.Trim <= 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, txtCapacityZF, OPE_Controls.MessageType.None, "Capacity must be > 0")
        If txtCapacityCus.Text.Trim = "" OrElse txtCapacityCus.Text.Trim <= 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, txtCapacityCus, OPE_Controls.MessageType.None, "Capacity must be > 0")
        If Converts.ToInt_NullIsZero(txtWorkTimeZF.Text.Trim) = 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, txtWorkTimeZF, OPE_Controls.MessageType.None, "Please entry master working time")
        If Converts.ToInt_NullIsZero(txtWorkTimeCus.Text.Trim) = 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, txtWorkTimeCus, OPE_Controls.MessageType.None, "Please entry master working time")

        Return bTrue
    End Function

    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCapacityZF.TextChanged, txtCapacityCus.TextChanged
        CalHeader()
    End Sub

    Private Sub CalHeader()
        txtBreakTimeZF.Text = cls.GetProdMinDay(True) - cls.GetProdMin(True)
        txtWorkingHrsZF.Text = cls.GetProdHr(True)
        txtWorkTimeZF.Text = cls.GetProdMin(True)
        Dim CapacityZF As Decimal = 0.0 : If txtCapacityZF.Text.Trim <> "" Then CapacityZF = txtCapacityZF.Text.Trim
        txtTotalCapacityZF.Text = Converts.ToInt_NullIsZero(txtWorkTimeZF.Text) / 60 * CapacityZF

        Dim TotalCapacityZF As Decimal = 0.0
        If txtTotalCapacityZF.Text.Trim <> "" Then
            TotalCapacityZF = txtTotalCapacityZF.Text.Trim
            If TotalCapacityZF <> 0 Then txtTrackTimeZF.Text = Converts.ToInt_NullIsZero(txtWorkTimeZF.Text) / TotalCapacityZF Else txtTrackTimeZF.Text = 0
        End If

        txtBreakTimeCus.Text = cls.GetProdMinDay(False) - cls.GetProdMin(False)
        txtWorkingHrsCus.Text = cls.GetProdHr(False)
        txtWorkTimeCus.Text = cls.GetProdMin(False)

        Dim CapacityCus As Decimal = 0.0 : If txtCapacityCus.Text.Trim <> "" Then CapacityCus = txtCapacityCus.Text.Trim
        txtTotalCapacityCus.Text = Converts.ToInt_NullIsZero(txtWorkTimeCus.Text) / 60 * CapacityCus

        Dim TotalCapacityCus As Decimal = 0.0
        If txtTotalCapacityCus.Text.Trim <> "" Then
            TotalCapacityCus = txtTotalCapacityCus.Text.Trim
            If TotalCapacityCus <> 0 Then txtTrackTimeCus.Text = Converts.ToInt_NullIsZero(txtWorkTimeCus.Text) / TotalCapacityCus Else txtTrackTimeCus.Text = 0
        End If

        Dim clsWorkPeriod As New clsCWorkPeriod
        Dim dtDeliZF As DataTable = clsWorkPeriod.getMasterDeliveryTime(True)
        Dim dtDeliCus As DataTable = clsWorkPeriod.getMasterDeliveryTime(False)
        txtTripPerDayZF.Text = dtDeliZF.Rows.Count
        txtTripPerDayCus.Text = dtDeliCus.Rows.Count
    End Sub
#End Region
#Region "Tab Page Change"
    Private Sub tabWorkPeriod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        Dim GridType As Integer = 0
        Dim pge As TabPage = Nothing
        Select Case TabControl.SelectedIndex
            Case 0 : pge = pgeOverview : GridType = clsCSchedule.eGridType.OverView
            Case 1 : pge = pgeZFEmptyRack : GridType = clsCSchedule.eGridType.ZFEmptyRack
            Case 2 : pge = pgeZFFG : GridType = clsCSchedule.eGridType.ZFFG
            Case 3 : pge = pgeCusFG : GridType = clsCSchedule.eGridType.CusFG
            Case 4 : pge = pgeCusEmptyReturn : GridType = clsCSchedule.eGridType.CusReturn
        End Select

        If pge Is Nothing Then Exit Sub

        Dim iDay As Integer = NDay
        For Each ctrl1 As Control In pge.Controls
            If ctrl1.GetType() Is GetType(TableLayoutPanel) Then
                For Each ctrl2 As Control In ctrl1.Controls
                    If ctrl2.GetType() Is GetType(OPE_Controls.opeDataGrid) Then
                        BindGrid(ctrl2, GridType, iDay)
                        iDay = iDay - 1
                    End If
                Next
            End If
        Next
    End Sub

#End Region
#Region "Binding Grid"
    Private Sub BindGrid(ByVal grd As OPE_Controls.opeDataGrid, ByVal GridType As Integer, ByVal iDay As Integer)
        With grd
            .Columns.Clear()
            If .DataSource Is Nothing Then Exit Sub
            Dim dt As DataTable = .DataSource

            For iCol As Integer = 0 To dt.Columns.Count - 1
                If dt.Columns(iCol).ColumnName = "ID" Then
                    .ColumnAdd_TextBox(dt.Columns(iCol).ColumnName, dt.Columns(iCol).ColumnName, dt.Columns(iCol).ColumnName, , True, , , False)
                ElseIf dt.Columns(iCol).ColumnName = "Desc" Then
                    .ColumnAdd_TextBox(dt.Columns(iCol).ColumnName, "Day " & iDay, dt.Columns(iCol).ColumnName, 100, True)
                ElseIf dt.Columns(iCol).ColumnName = "Bar Type" Then
                    .ColumnAdd_TextBox(dt.Columns(iCol).ColumnName, "", dt.Columns(iCol).ColumnName, 150)
                Else
                    .ColumnAdd_TextBox(dt.Columns(iCol).ColumnName, dt.Columns(iCol).ColumnName, dt.Columns(iCol).ColumnName, , , DataGridViewContentAlignment.MiddleRight)
                End If

            Next
            .AllowUserToAddRows = False
            ComboSet.GridColumnSize(grd)
            If Not (grd Is Nothing) AndAlso grd.RowCount > 0 Then
                If GridType = clsCSchedule.eGridType.OverView Then
                    SetGridColorOverview(grd)
                Else
                    SetGridColor(grd, GridType)
                End If
            End If
        End With
    End Sub

    Private Sub SetGridColor(ByVal grd As OPE_Controls.opeDataGrid, ByVal GridType As Integer)
        Dim clsTime As New clsCWorkPeriod
        Dim fZF As Boolean = False
        Dim RowIDQty As Integer = 0
        Select Case GridType
            Case clsCSchedule.eGridType.ZFEmptyRack
                fZF = True : RowIDQty = clsCSchedule.eIDZFEmptyRack.Quantity

            Case clsCSchedule.eGridType.ZFFG
                fZF = True : RowIDQty = clsCSchedule.eIDZFFG.Quantity

            Case clsCSchedule.eGridType.CusFG
                fZF = False : RowIDQty = clsCSchedule.eIDCusFG.Quantity

            Case clsCSchedule.eGridType.CusReturn
                fZF = False : RowIDQty = clsCSchedule.eIDCusEmptyReturn.Quantity

            Case Else
                Exit Sub
        End Select

        Dim dtTime As DataTable = clsTime.getMasterTime(fZF)
        Dim MaxPeriod As Integer = dtTime.Compute("max(Period)", "")
        Dim drTime As DataRow = dtTime.Select("Period=" & MaxPeriod & "")(0)
        Dim MaxTime As String = drTime("Stop")
        For iRow As Integer = 0 To grd.Rows.Count - 1
            If Converts.ToInt_NullIsZero(grd.Rows(iRow).Cells("ID").Value) = RowIDQty Then
                For iPeriod As Integer = 1 To dtTime.Rows.Count
                    If iPeriod > 1 Then
                        Dim drPrevious As DataRow = dtTime.Select("Period=" & iPeriod - 1 & "")(0)
                        Dim drNext As DataRow = dtTime.Select("Period=" & iPeriod & "")(0)
                        Dim PreviousStop As String = drPrevious("Stop")
                        Dim NextStart As String = drNext("Start")
                        Dim ColorPlotted As Boolean = False
                        For iCol As Integer = 0 To grd.Columns.Count - 1
                            Dim ColName As String = grd.Columns(iCol).Name
                            If Not (ColName = "ID" Or ColName = "Desc") Then
                                If (Replace(ColName, ":", ".") > PreviousStop And Replace(ColName, ":", ".") <= NextStart) Or Replace(ColName, ":", ".") > MaxTime Then
                                    grd.Rows(iRow).Cells(iCol).Style.BackColor = Color.Yellow
                                    If Replace(ColName, ":", ".") <= MaxTime Then ColorPlotted = True
                                End If
                            End If
                        Next
                        If ColorPlotted = False Then
                            For iCol As Integer = grd.Columns.Count - 1 To 0 Step -1
                                Dim ColName As String = grd.Columns(iCol).Name
                                If Not (ColName = "ID" Or ColName = "Desc") Then
                                    If Replace(ColName, ":", ".") <= PreviousStop Then
                                        grd.Rows(iRow).Cells(iCol).Style.BackColor = Color.Yellow
                                        Exit For
                                    End If
                                End If
                            Next
                        End If
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub SetGridColorOverview(ByVal grd As OPE_Controls.opeDataGrid)
        For iRow As Integer = 0 To grd.RowCount - 1
            For iCol As Integer = 0 To grd.Columns.Count - 1
                If IsNumeric(grd.Rows(iRow).Cells(iCol).Value) AndAlso grd.Rows(iRow).Cells(iCol).Value < 0 Then
                    grd.Rows(iRow).Cells(iCol).Style.BackColor = Color.Red
                End If
            Next
        Next
    End Sub
#End Region
#Region "Calculate Data"
    Private Sub CalculateData()
        'Dim nDay As Integer = Converts.ToInt_NullIsZero(txtDays.Text.Trim)
        If NDay = 0 Then Exit Sub
        ReDim dtZFEmptyRack(nDay), dtZFFG(nDay), dtCusFG(nDay), dtCusEmptyReturn(nDay)

        Dim IniEmptyRackZF As Integer = Converts.ToInt_NullIsZero(txtIniEmptyRackZF.Text.Trim)
        Dim InitialFGZF As Integer = Converts.ToInt_NullIsZero(txtInitialFGZF.Text.Trim)
        Dim InitialFGCus As Integer = Converts.ToInt_NullIsZero(txtInitialFGCus.Text.Trim)
        Dim IniEmptyRackCus As Integer = Converts.ToInt_NullIsZero(txtIniEmptyRackCus.Text.Trim)

        For iDay As Integer = 0 To nDay - 1
            CalculateDTDay(iDay, IniEmptyRackZF, InitialFGZF, InitialFGCus, IniEmptyRackCus)

            Dim RowIni As Integer = 0
            Dim dtData As DataTable = Nothing
            Dim GridType As Integer = 0
            For iLoop As Integer = 0 To 10
                Select Case iLoop
                    Case clsCSchedule.eGridType.ZFEmptyRack
                        RowIni = clsCSchedule.eIDZFEmptyRack.EmptyRack
                        dtData = dtZFEmptyRack(iDay)
                        GridType = clsCSchedule.eGridType.ZFEmptyRack
                        'Exit For
                    Case clsCSchedule.eGridType.ZFFG
                        RowIni = clsCSchedule.eIDZFFG.InitialFG
                        dtData = dtZFFG(iDay)
                        GridType = clsCSchedule.eGridType.ZFFG
                        'Exit For
                    Case clsCSchedule.eGridType.CusFG
                        RowIni = clsCSchedule.eIDCusFG.InitialFG
                        dtData = dtCusFG(iDay)
                        GridType = clsCSchedule.eGridType.CusFG
                        'Exit For
                    Case clsCSchedule.eGridType.CusReturn
                        RowIni = clsCSchedule.eIDCusEmptyReturn.EmptyRack
                        dtData = dtCusEmptyReturn(iDay)
                        GridType = clsCSchedule.eGridType.CusReturn
                        'Exit For
                    Case Else : GoTo NextLoop1
                End Select

                Dim drIniData As DataRow = dtData.Select("ID=" & RowIni & "")(0)
                For iCol As Integer = dtData.Columns.Count - 1 To 0 Step -1
                    If IsNumeric(drIniData(iCol)) Then
                        Select Case GridType
                            Case clsCSchedule.eGridType.ZFEmptyRack : IniEmptyRackZF = drIniData(iCol) : Exit For
                            Case clsCSchedule.eGridType.ZFFG : InitialFGZF = drIniData(iCol) : Exit For
                            Case clsCSchedule.eGridType.CusFG : InitialFGCus = drIniData(iCol) : Exit For
                            Case clsCSchedule.eGridType.CusReturn : IniEmptyRackCus = drIniData(iCol) : Exit For
                        End Select
                    End If
                Next
NextLoop1:
            Next
        Next

        'OverView
        dtOverview = Nothing
        dtOverview = New DataTable
        dtOverview.Columns.Add("ID", GetType(Integer))
        dtOverview.Columns.Add("Bar Type", GetType(String))
        For iDay As Integer = 1 To NDay
            dtOverview.Columns.Add("Day " & iDay, GetType(Integer))
        Next
        For iLoop As Integer = 0 To 10
            Dim sBarType As String = ""
            Dim dtData() As DataTable = Nothing
            Dim RowData As Integer = 0
            Select Case iLoop
                Case clsCSchedule.eGridType.ZFEmptyRack
                    sBarType = pgeZFEmptyRack.Text
                    dtData = dtZFEmptyRack
                    RowData = clsCSchedule.eIDZFEmptyRack.EmptyRack
                Case clsCSchedule.eGridType.ZFFG
                    sBarType = pgeZFFG.Text
                    dtData = dtZFFG
                    RowData = clsCSchedule.eIDZFFG.InitialFG
                Case clsCSchedule.eGridType.CusFG
                    sBarType = pgeCusFG.Text
                    dtData = dtCusFG
                    RowData = clsCSchedule.eIDCusFG.InitialFG
                Case clsCSchedule.eGridType.CusReturn
                    sBarType = pgeCusEmptyReturn.Text
                    dtData = dtCusEmptyReturn
                    RowData = clsCSchedule.eIDCusEmptyReturn.EmptyRack
                Case Else : GoTo NextLoop2
            End Select

            Dim drAdd As DataRow = dtOverview.NewRow
            drAdd("ID") = iLoop
            drAdd("Bar Type") = sBarType
            For iDay As Integer = 0 To NDay - 1
                Dim MinValue As Integer = Integer.MaxValue
                For iRow As Integer = 0 To dtData(iDay).Rows.Count - 1
                    If Converts.ToInt_NullIsZero(dtData(iDay).Rows(iRow)("ID")) = RowData Then
                        For iCol As Integer = 0 To dtData(iDay).Columns.Count - 1
                            Dim ColName As String = dtData(iDay).Columns(iCol).ColumnName
                            If Not (ColName = "ID" Or ColName = "Desc") Then
                                Dim CurValue As Integer = Converts.ToInt_NullIsZero(dtData(iDay).Rows(iRow)(iCol))
                                If CurValue < MinValue Then MinValue = CurValue
                            End If
                        Next
                    End If
                Next
                drAdd("Day " & iDay + 1) = MinValue
            Next
            dtOverview.Rows.Add(drAdd)

NextLoop2:
        Next
    End Sub
    Private Sub CalculateDTDay(ByVal iDay As Integer, ByVal IniEmptyRackZF As Integer, ByVal InitialFGZF As Integer, ByVal InitialFGCus As Integer, ByVal IniEmptyRackCus As Integer)
        'ZF Only
        Dim TrackMinZF As Integer = Converts.ToInt_NullIsZero(txtTrackTimeZF.Text.Trim)
        dtZFEmptyRack(iDay) = cls.GetTrackTime(TrackMinZF, Converts.ToInt_NullIsZero(txtTravelMinsCus.Text.Trim), clsCSchedule.eGridType.ZFEmptyRack)
        dtZFEmptyRack(iDay) = cls.GetQty(dtZFEmptyRack(iDay), True)
        dtZFEmptyRack(iDay) = cls.GetAccumulate(dtZFEmptyRack(iDay), True)
        dtZFEmptyRack(iDay) = cls.GetRemain(dtZFEmptyRack(iDay), IniEmptyRackZF, clsCSchedule.eGridType.ZFEmptyRack, Converts.ToInt_NullIsZero(txtBlockForSkiplot.Text.Trim), Converts.ToInt_NullIsZero(txtBlockForMaintenance.Text.Trim))


        dtZFFG(iDay) = Nothing
        dtZFFG(iDay) = cls.GetTrackTime(TrackMinZF, 0, clsCSchedule.eGridType.ZFFG)
        For Each drZFEmptyRack As DataRow In dtZFEmptyRack(iDay).Select()
            Select Case drZFEmptyRack("ID")
                Case clsCSchedule.eIDZFEmptyRack.Quantity, clsCSchedule.eIDZFEmptyRack.Accumulate
                    dtZFFG(iDay).ImportRow(drZFEmptyRack)
            End Select
        Next
        dtZFFG(iDay) = cls.GetRemain(dtZFFG(iDay), InitialFGZF, clsCSchedule.eGridType.ZFFG, 0, 0)

        'Cus Only
        Dim TrackMinCus As Integer = Converts.ToInt_NullIsZero(txtTrackTimeCus.Text.Trim)
        dtCusFG(iDay) = cls.GetTrackTime(TrackMinCus, Converts.ToInt_NullIsZero(txtTravelMinsZF.Text.Trim), clsCSchedule.eGridType.CusFG)
        dtCusFG(iDay) = cls.GetQty(dtCusFG(iDay), False)
        dtCusFG(iDay) = cls.GetAccumulate(dtCusFG(iDay), False)
        dtCusFG(iDay) = cls.GetRemain(dtCusFG(iDay), InitialFGCus, clsCSchedule.eGridType.CusFG, 0, 0)

        dtCusEmptyReturn(iDay) = Nothing
        dtCusEmptyReturn(iDay) = cls.GetTrackTime(TrackMinCus, 0, clsCSchedule.eGridType.CusReturn)
        For Each drCusFG As DataRow In dtCusFG(iDay).Select()
            Select Case drCusFG("ID")
                Case clsCSchedule.eIDCusFG.Quantity, clsCSchedule.eIDCusFG.Accumulate
                    dtCusEmptyReturn(iDay).ImportRow(drCusFG)
            End Select
        Next
        dtCusEmptyReturn(iDay) = cls.GetRemain(dtCusEmptyReturn(iDay), IniEmptyRackCus, clsCSchedule.eGridType.CusReturn, 0, 0)

        'Delivery ZF-Cus
        dtZFFG(iDay) = cls.GetDelivery(dtZFFG(iDay), Converts.ToInt_NullIsZero(txtQtyPerTripZF.Text.Trim), True)
        dtCusFG(iDay) = cls.GetDeliveryArrive(dtCusFG(iDay), dtZFFG(iDay).Select("ID=" & clsCSchedule.eIDZFFG.Delivery & "")(0), Converts.ToInt_NullIsZero(txtTravelMinsZF.Text.Trim), True)


        'Delivery Cus-ZF
        dtCusEmptyReturn(iDay) = cls.GetDelivery(dtCusEmptyReturn(iDay), Converts.ToInt_NullIsZero(txtQtyPerTripCus.Text.Trim), False)
        dtZFEmptyRack(iDay) = cls.GetDeliveryArrive(dtZFEmptyRack(iDay), dtCusEmptyReturn(iDay).Select("ID=" & clsCSchedule.eIDCusEmptyReturn.ReturnToZF & "")(0), Converts.ToInt_NullIsZero(txtTravelMinsCus.Text.Trim), False)


        'Clear Column
        dtZFEmptyRack(iDay) = cls.ClearColumn(dtZFEmptyRack(iDay), clsCSchedule.eGridType.ZFEmptyRack)
        dtCusFG(iDay) = cls.ClearColumn(dtCusFG(iDay), clsCSchedule.eGridType.CusFG)

    End Sub
#End Region
#Region "Show Chart"
    Private Sub ShowChart()
        ShowChart(pgeZFEmptyRack, clsCSchedule.eGridType.ZFEmptyRack)
        ShowChart(pgeZFFG, clsCSchedule.eGridType.ZFFG)
        ShowChart(pgeCusFG, clsCSchedule.eGridType.CusFG)
        ShowChart(pgeCusEmptyReturn, clsCSchedule.eGridType.CusReturn)
        ShowChartOverview()
    End Sub

    Private Sub ShowChart(ByVal pge As TabPage, ByVal GridType As Integer)
        pge.Controls.Clear()
        If Converts.ToInt_NullIsZero(NDay) > 0 Then
            Dim TabPageLayout(NDay) As TableLayoutPanel
            Dim cht(NDay) As System.Windows.Forms.DataVisualization.Charting.Chart
            Dim grd(NDay) As OPE_Controls.opeDataGrid
            Dim lbl(NDay) As OPE_Controls.OpeLabel

            For iLoop As Integer = Converts.ToInt(txtDays.Text.Trim) - 1 To 0 Step -1
                TabPageLayout(iLoop) = New System.Windows.Forms.TableLayoutPanel
                pge.Controls.Add(TabPageLayout(iLoop))
                TabPageLayout(iLoop).Size = New System.Drawing.Size(1219, 500)
                'TabPageLayout(iLoop).Size = New System.Drawing.Size(1219, 300)
                TabPageLayout(iLoop).Dock = DockStyle.Top
                TabPageLayout(iLoop).ColumnCount = 1
                TabPageLayout(iLoop).ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))

                TabPageLayout(iLoop).RowCount = 4  '2

                'TabPageLayout(iLoop).RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
                'TabPageLayout(iLoop).RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))

                TabPageLayout(iLoop).RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
                TabPageLayout(iLoop).RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
                TabPageLayout(iLoop).RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
                TabPageLayout(iLoop).RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))

                lbl(iLoop) = New OPE_Controls.OpeLabel
                lbl(iLoop).Text = "Day " & iLoop + 1
                lbl(iLoop).Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
                lbl(iLoop).TextAlign = ContentAlignment.MiddleCenter
                lbl(iLoop).BackColor = Color.Honeydew
                lbl(iLoop).ForeColor = Color.Green
                lbl(iLoop).Dock = DockStyle.Fill
                TabPageLayout(iLoop).Controls.Add(lbl(iLoop), 0, 0)


                Dim dtData As DataTable = Nothing
                Dim SeriesName As String = ""
                Dim xString As String = "Time"
                Dim yString As String = ""
                Select Case GridType
                    Case clsCSchedule.eGridType.ZFEmptyRack
                        dtData = dtZFEmptyRack(iLoop)
                        SeriesName = "ZFEmptyRack"
                        yString = "Empty Rack"
                    Case clsCSchedule.eGridType.ZFFG
                        dtData = dtZFFG(iLoop)
                        SeriesName = "ZFFG"
                        yString = "FG"
                    Case clsCSchedule.eGridType.CusFG
                        dtData = dtCusFG(iLoop)
                        SeriesName = "CusFG"
                        yString = "FG"
                    Case clsCSchedule.eGridType.CusReturn
                        dtData = dtCusEmptyReturn(iLoop)
                        SeriesName = "CusEmptyReturn"
                        yString = "Empty Return"
                End Select
                If dtData Is Nothing Then GoTo nextloop

                Dim dtTimePivot As DataTable = getPivotTable(dtData)
                cht(iLoop) = New System.Windows.Forms.DataVisualization.Charting.Chart
                cht(iLoop).Dock = DockStyle.Fill
                TabPageLayout(iLoop).Controls.Add(cht(iLoop), 0, 1)


                cht(iLoop).ChartAreas.Add("Area" & iLoop)
                cht(iLoop).Legends.Add("Legend" & iLoop)
                cht(iLoop).Series.Clear()
                cht(iLoop).Series.Add(SeriesName)
                cht(iLoop).Series(SeriesName).LegendText = "Day " & iLoop + 1
                cht(iLoop).Series(SeriesName).IsVisibleInLegend = False
                'cht(iLoop).Series(SeriesName).IsValueShownAsLabel = True
                cht(iLoop).Series(SeriesName).ChartType = SeriesChartType.Column
                Dim x As String() = (From p In dtTimePivot.AsEnumerable()
                                 Order By p.Field(Of String)(xString)
                                 Select p.Field(Of String)(xString)).ToArray()
                Dim y As Integer() = (From p In dtTimePivot.AsEnumerable()
                                      Order By p.Field(Of String)(xString)
                                      Select p.Field(Of Integer)(yString)).ToArray()
                cht(iLoop).Series(SeriesName).Points.DataBindXY(x, y)
                For Each Point As DataPoint In cht(iLoop).Series(SeriesName).Points
                    If Point.YValues(0) >= 0 Then
                        Point.Color = Color.LightGreen
                    Else
                        Point.Color = Color.Red
                    End If
                Next

                grd(iLoop) = New OPE_Controls.opeDataGrid
                grd(iLoop).DataSource = dtData
                BindGrid(grd(iLoop), GridType, iLoop + 1)
                grd(iLoop).Dock = DockStyle.Fill
                TabPageLayout(iLoop).Controls.Add(grd(iLoop), 0, 2)


NextLoop:

            Next

        End If
        TabControl.SelectedIndex = GridType
    End Sub

    Private Sub ShowChartOverview()
        TabLayOutOverview.Controls.Clear()
        Dim grd As New OPE_Controls.opeDataGrid
        grd.DataSource = dtOverview
        grd.Dock = DockStyle.Fill        
        BindGrid(grd, clsCSchedule.eGridType.OverView, 0)
        TabLayOutOverview.Controls.Add(grd, 0, 1)

        Dim chtOverview As New System.Windows.Forms.DataVisualization.Charting.Chart
        TabLayOutOverview.Controls.Add(chtOverview, 0, 0)
        chtOverview.ChartAreas.Add("Overview")
        chtOverview.Dock = DockStyle.Fill
        chtOverview.Legends.Add("OverviewLegends")
        Dim SeriesName As String = ""
        For iCol As Integer = 2 To dtOverview.Columns.Count - 1
            SeriesName = dtOverview.Columns(iCol).ColumnName
            chtOverview.Series.Add(SeriesName)
            chtOverview.Series(SeriesName).LegendText = SeriesName
            chtOverview.Series(SeriesName).ChartType = SeriesChartType.Column
            chtOverview.Series(SeriesName).IsVisibleInLegend = True
            'chtOverview.Series(SeriesName).IsValueShownAsLabel = True

            Dim xString As String = "Bar Type"
            Dim yString As String = SeriesName
            Dim dtTimePivot As DataTable = dtOverview
            Dim x As String() = (From p In dtTimePivot.AsEnumerable()
                         Order By p.Field(Of Integer)("ID")
                         Select p.Field(Of String)(xString)).ToArray()
            Dim y As Integer() = (From p In dtTimePivot.AsEnumerable()
                                  Order By p.Field(Of Integer)("ID")
                                  Select p.Field(Of Integer)(yString)).ToArray()
            chtOverview.Series(SeriesName).Points.DataBindXY(x, y)

            For Each Point As DataPoint In chtOverview.Series(SeriesName).Points
                If Point.YValues(0) < 0 Then
                    Point.Color = Color.Red
                End If
            Next
        Next
    End Sub
#End Region
#Region "PivotChatTable"
    Private Function getPivotTable(ByVal dtData As DataTable) As DataTable
        Dim dtTimePivot As New DataTable
        dtTimePivot.Columns.Add("Time", GetType(String))
        For Each drTime As DataRow In dtData.Select("", "ID")
            dtTimePivot.Columns.Add(drTime("Desc"), GetType(Integer))
        Next

        For Each drTime As DataRow In dtData.Select("", "ID")
            For iCol As Integer = 0 To dtData.Columns.Count - 1
                Dim ColName As String = dtData.Columns(iCol).ColumnName
                If Not (ColName = "ID" Or ColName = "Desc") Then
                    If dtTimePivot.Compute("count(Time)", "Time='" & ColName & "'") = 0 Then
                        Dim drAddPivot As DataRow = dtTimePivot.NewRow
                        drAddPivot("Time") = ColName
                        drAddPivot(drTime("Desc")) = Converts.ToInt_NullIsZero(drTime(ColName))
                        dtTimePivot.Rows.Add(drAddPivot)
                    Else
                        For Each drTimePivot As DataRow In dtTimePivot.Select("Time='" & ColName & "'")
                            drTimePivot(drTime("Desc")) = Converts.ToInt_NullIsZero(drTime(ColName))
                        Next
                    End If
                End If
            Next
        Next

        Return dtTimePivot
    End Function
    Private Function getPivotOverview(ByVal dtData As DataTable) As DataTable
        Dim dtTimePivot As New DataTable
        dtTimePivot.Columns.Add("Day", GetType(String))
        For Each drTime As DataRow In dtData.Select("", "ID")
            dtTimePivot.Columns.Add(drTime("Bar Type"), GetType(Integer))
        Next

        For Each drTime As DataRow In dtData.Select("", "ID")
            For iCol As Integer = 0 To dtData.Columns.Count - 1
                Dim ColName As String = dtData.Columns(iCol).ColumnName
                If Not (ColName = "ID" Or ColName = "Bar Type") Then
                    If dtTimePivot.Compute("count(Day)", "Day='" & ColName & "'") = 0 Then
                        Dim drAddPivot As DataRow = dtTimePivot.NewRow
                        drAddPivot("Day") = ColName
                        drAddPivot(drTime("Bar Type")) = Converts.ToInt_NullIsZero(drTime(ColName))
                        dtTimePivot.Rows.Add(drAddPivot)
                    Else
                        For Each drTimePivot As DataRow In dtTimePivot.Select("Day='" & ColName & "'")
                            drTimePivot(drTime("Bar Type")) = Converts.ToInt_NullIsZero(drTime(ColName))
                        Next
                    End If
                End If
            Next
        Next



        Return dtTimePivot
    End Function
#End Region
#Region "Hide/Show Config"
    Private Sub btnShowConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowConfig.Click
        If fShowConfig = True Then
            pnCondition.Width = btnShowConfig.Width
            btnShowConfig.Text = ">>"

        Else
            pnCondition.Width = 350
            btnShowConfig.Text = "<<"
        End If
        fShowConfig = Not fShowConfig
        grpRackVisual.Visible = fShowConfig
        grpDelivery.Visible = fShowConfig
        grpReturn.Visible = fShowConfig
        pnResult.Visible = fShowConfig
        'btnChart.Visible = fShowConfig
    End Sub
#End Region

#Region "Print"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnPrint.Click
        If Calculated = False Then Exit Sub

        Dim frm As New clsVExportSelection
        Dim iPrintType As Integer = 0
        Dim iCustomer As Integer = 0

        frm.ShowDialog()
        Dim OK As Boolean = frm.mOK
        If OK = True Then
            If frm.rdoMB.Checked Then
                iCustomer = clsPSchedule.eCustomer.MB
            Else
                iCustomer = clsPSchedule.eCustomer.BMW
            End If
            If frm.rdoOverviewOnlyExcel.Checked Then
                iPrintType = clsPSchedule.ePrintType.OverviewExcel
            ElseIf frm.rdoOverviewOnlyPDF.Checked Then
                iPrintType = clsPSchedule.ePrintType.OverviewPDF
            Else
                iPrintType = clsPSchedule.ePrintType.AllPageExcel
            End If
        End If
        frm = Nothing

        If OK = True Then
            Dim iIndex As Integer = TabControl.SelectedIndex
            For iPge As Integer = 0 To TabControl.TabCount - 1
                If iPge <> iIndex Then TabControl.SelectedIndex = iPge
            Next
            TabControl.SelectedIndex = iIndex

            Dim clsP As New clsPSchedule
            clsP.Print(Me, iPrintType, iCustomer)
        End If
    End Sub
    
#End Region
    
    
End Class