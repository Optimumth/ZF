Imports OPE_Controls.OpeStyle
Imports ZFRackVisual.CustomizeSetting

Public Class clsPSchedule
    Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" _
(ByVal hWnd As System.IntPtr, ByVal lpOperation As String, ByVal lpFile As String, _
ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer

    Dim cPrint As New OPE_Controls.clsBPrintForm

    Public Enum ePrintType
        OverviewExcel = 1
        OverviewPDF = 2
        AllPageExcel = 3
    End Enum

    Public Enum eCustomer
        MB = 1
        BMW = 2
    End Enum

#Region "Print"


    Public Function Print(ByVal frmSch As clsVSchedule, ByVal PrintType As Integer, ByVal Customer As Integer) As Boolean
        Dim Err As String = ""

        Dim NDay As Integer = GetNDayfromOverview(frmSch.dtOverview)
        If NDay <= 0 Then GoTo ExitFunction

        With cPrint
            .TemplateFileName = IIf(Customer = eCustomer.MB, "TemplateMB.xlsx", "TemplateBMW.xlsx")
            .TemplateFolder = Info.ProjectPath & "\Template\"
            .OutputFolder = Info.ProjectPath & "\Output"
            .OutputFileName = IIf(Customer = eCustomer.MB, "MB", "BMW") & "_" & Converts.ToStr(SystemDate, OPE_Controls.ConvertString.yyyyMMddHHmmssfff) & IIf(PrintType = ePrintType.OverviewPDF, ".pdf", ".xlsx")
            If .OpenTemplateExcelFile(Err) <> 0 Then GoTo ExitFunction

            Select Case PrintType
                Case ePrintType.OverviewExcel
                    SheetChartOverview(NDay, frmSch)
                Case ePrintType.OverviewPDF
                    SheetChartOverview(NDay, frmSch)
                Case ePrintType.AllPageExcel
                    SheetChartDay(NDay, frmSch)
                    SheetChartOverview(NDay, frmSch)
                    SheetSummary(NDay, frmSch)
            End Select

            If Not .PrintReport(True, False, Err) Then GoTo ExitFunction
        End With

        Return True

ExitFunction:
        Return False
    End Function


    Private Sub SheetChartDay(ByVal nDay As Integer, ByVal frmSch As clsVSchedule)
        Dim ColInsCusReturn As Integer = 27
        Dim ColInsCusFG As Integer = 22
        Dim ColInsZFFG As Integer = 13
        Dim ColInsZFEmpty As Integer = 8
        Dim ColDayLeft As Integer = 2
        Dim ColDayRight As Integer = 16
        Dim RowDay As Integer = 5

        Dim ColStart As Integer = 7
        Dim RowStart As Integer = 27
        Dim RowPerSet As Integer = 40

        With cPrint
            .TemplateSheetName = "TPChartDay"
            .OutputSheetName = "Chartday"
            .CreateSheet(.TemplateSheetName, .TemplateSheetName, .OutputSheetName)

            .setSheatHeader("C28", Converts.ToInt_NullIsZero(frmSch.txtCapacityZF.Text.Trim))
            .setSheatHeader("C29", Converts.ToInt_NullIsZero(frmSch.txtBreakTimeZF.Text.Trim))
            .setSheatHeader("C30", Converts.ToInt_NullIsZero(frmSch.txtWorkingHrsZF.Text.Trim))
            .setSheatHeader("C31", Converts.ToInt_NullIsZero(frmSch.txtWorkTimeZF.Text.Trim))
            .setSheatHeader("C32", Converts.ToInt_NullIsZero(frmSch.txtTotalCapacityZF.Text.Trim))
            .setSheatHeader("C33", Converts.ToInt_NullIsZero(frmSch.txtTrackTimeZF.Text.Trim))
            .setSheatHeader("C34", Converts.ToInt_NullIsZero(frmSch.txtBlockForSkiplot.Text.Trim))
            .setSheatHeader("C35", Converts.ToInt_NullIsZero(frmSch.txtBlockForMaintenance.Text.Trim))

            .setSheatHeader("Q28", Converts.ToInt_NullIsZero(frmSch.txtCapacityZF.Text.Trim))
            .setSheatHeader("Q29", Converts.ToInt_NullIsZero(frmSch.txtBreakTimeZF.Text.Trim))
            .setSheatHeader("Q30", Converts.ToInt_NullIsZero(frmSch.txtWorkingHrsZF.Text.Trim))
            .setSheatHeader("Q31", Converts.ToInt_NullIsZero(frmSch.txtWorkTimeZF.Text.Trim))
            .setSheatHeader("Q32", Converts.ToInt_NullIsZero(frmSch.txtTotalCapacityZF.Text.Trim))
            .setSheatHeader("Q33", Converts.ToInt_NullIsZero(frmSch.txtTrackTimeZF.Text.Trim))



            Dim nRange As Integer = 0
            Dim ColIns As Integer = 0
            For iLoop As Integer = 10 To 0 Step -1
                Select Case iLoop
                    Case clsCSchedule.eGridType.CusReturn : nRange = GetNRange(frmSch.dtCusEmptyReturn(0)) : ColIns = ColInsCusReturn
                    Case clsCSchedule.eGridType.CusFG : nRange = GetNRange(frmSch.dtCusFG(0)) : ColIns = ColInsCusFG
                    Case clsCSchedule.eGridType.ZFFG : nRange = GetNRange(frmSch.dtZFFG(0)) : ColIns = ColInsZFFG
                    Case clsCSchedule.eGridType.ZFEmptyRack : nRange = GetNRange(frmSch.dtZFEmptyRack(0)) : ColIns = ColInsZFEmpty
                    Case Else : GoTo NextLoop1
                End Select
                If nRange > 3 Then
                    For iIns As Integer = 4 To nRange
                        .InsertColumn(.OutputSheetName, ColIns, 1)
                        If iLoop = clsCSchedule.eGridType.ZFEmptyRack Or iLoop = clsCSchedule.eGridType.ZFFG Then
                            ColDayRight += 1
                        End If
                    Next
                End If
                .CellBackColor(.CellRange(RowStart + 3, ColIns - 1, 0, 0), Color.LawnGreen)

NextLoop1:
            Next
            If nDay > 1 Then
                For iDay As Integer = 2 To nDay
                    .CopyPasteRow(.OutputSheetName, "1:" & RowPerSet, .OutputSheetName, (RowPerSet * (iDay - 1)) + 1)
                    '2-16
                    .setSheatHeader(GetExcelCol(ColDayLeft) & (RowPerSet * (iDay - 1)) + 5, "Day " & iDay)
                    .setSheatHeader(GetExcelCol(ColDayRight) & (RowPerSet * (iDay - 1)) + 5, "Day " & iDay)
                Next
            End If

            For iDay As Integer = 1 To nDay
                Dim ExcelColumn As Integer = ColStart
                Dim ExcelRow As Integer = ((iDay - 1) * RowPerSet) + RowStart



                For iLoop As Integer = 0 To 10
                    Dim dt As DataTable = Nothing
                    Dim grd As OPE_Controls.opeDataGrid = Nothing
                    nRange = 0
                    Dim IDQty As Integer = 0
                    Dim IDAccum As Integer = 0
                    Dim IDResult As Integer = 0
                    Dim IDDeli As Integer = 0
                    Select Case iLoop
                        Case clsCSchedule.eGridType.ZFEmptyRack
                            dt = frmSch.dtZFEmptyRack(iDay - 1)
                            grd = GetGrid(clsCSchedule.eGridType.ZFEmptyRack, frmSch)
                            IDQty = clsCSchedule.eIDZFEmptyRack.Quantity
                            IDAccum = clsCSchedule.eIDZFEmptyRack.Accumulate
                            IDResult = clsCSchedule.eIDZFEmptyRack.EmptyRack
                            IDDeli = clsCSchedule.eIDZFEmptyRack.ReturnToZF
                        Case clsCSchedule.eGridType.ZFFG
                            dt = frmSch.dtZFFG(iDay - 1)
                            grd = GetGrid(clsCSchedule.eGridType.ZFFG, frmSch)
                            IDQty = clsCSchedule.eIDZFFG.Quantity
                            IDAccum = clsCSchedule.eIDZFFG.Accumulate
                            IDResult = clsCSchedule.eIDZFFG.InitialFG
                            IDDeli = clsCSchedule.eIDZFFG.Delivery
                        Case clsCSchedule.eGridType.CusFG
                            dt = frmSch.dtCusFG(iDay - 1)
                            grd = GetGrid(clsCSchedule.eGridType.CusFG, frmSch)
                            IDQty = clsCSchedule.eIDCusFG.Quantity
                            IDAccum = clsCSchedule.eIDCusFG.Accumulate
                            IDResult = clsCSchedule.eIDCusFG.InitialFG
                            IDDeli = clsCSchedule.eIDCusFG.DeliveryArrive
                        Case clsCSchedule.eGridType.CusReturn
                            dt = frmSch.dtCusEmptyReturn(iDay - 1)
                            grd = GetGrid(clsCSchedule.eGridType.CusReturn, frmSch)
                            IDQty = clsCSchedule.eIDCusEmptyReturn.Quantity
                            IDAccum = clsCSchedule.eIDCusEmptyReturn.Accumulate
                            IDResult = clsCSchedule.eIDCusEmptyReturn.EmptyRack
                            IDDeli = clsCSchedule.eIDCusEmptyReturn.ReturnToZF
                    End Select

                    If Not dt Is Nothing Then
                        Dim dr As DataRow = Nothing
                        Dim Range1 As Integer = ExcelColumn - 1
                        Dim Range2 As Integer = ExcelColumn
                        For iCol As Integer = 0 To dt.Columns.Count - 1
                            Dim ColName As String = dt.Columns(iCol).ColumnName
                            If Not (ColName = "ID" Or ColName = "Desc") Then
                                .setSheatHeader(GetExcelCol(ExcelColumn) & ExcelRow, ColName.Replace(".", ":"))
                                dr = dt.Select("ID=" & IDQty & "")(0)
                                If Converts.ToInt_NullIsZero(dr(iCol)) <> 0 Then .setSheatHeader(GetExcelCol(ExcelColumn) & ExcelRow + 1, dr(iCol))

                                Dim BGColor As Color = GetGridBackColor(grd, IDQty, ColName)
                                If Not (BGColor.A = 0 And BGColor.R = 0 And BGColor.G = 0 And BGColor.B = 0) Then _
                                    .SetBackgroundColor(GetExcelCol(ExcelColumn) & ExcelRow + 1, BGColor.R, BGColor.G, BGColor.B)

                                dr = dt.Select("ID=" & IDAccum & "")(0)
                                If Converts.ToInt_NullIsZero(dr(iCol)) <> 0 Then .setSheatHeader(GetExcelCol(ExcelColumn) & ExcelRow + 2, dr(iCol))

                                dr = dt.Select("ID=" & IDResult & "")(0)
                                If Converts.ToInt_NullIsZero(dr(iCol)) <> 0 Then .setSheatHeader(GetExcelCol(ExcelColumn) & ExcelRow + 3, dr(iCol))

                                dr = dt.Select("ID=" & IDDeli & "")(0)
                                If Converts.ToInt_NullIsZero(dr(iCol)) <> 0 Then .setSheatHeader(GetExcelCol(ExcelColumn) & ExcelRow + 5, dr(iCol))
                                Range2 = ExcelColumn
                                ExcelColumn += 1
                            End If
                        Next
                        Select Case iLoop
                            Case clsCSchedule.eGridType.ZFEmptyRack : ExcelColumn += 2
                            Case clsCSchedule.eGridType.ZFFG : ExcelColumn += 6
                            Case clsCSchedule.eGridType.CusFG : ExcelColumn += 2
                        End Select
                        Dim ChartName As String = "Chart" & iDay & iLoop
                        .AddChart(.OutputSheetName, GetExcelCol(Range1) & ExcelRow & ":" & GetExcelCol(Range2) & ExcelRow & "," & GetExcelCol(Range1) & ExcelRow + 3 & ":" & GetExcelCol(Range2) & ExcelRow + 3, GetExcelCol(Range1) & ExcelRow - 25, 50 + (25 * dt.Columns.Count - 2), 250, "Overview", Excel.XlRowCol.xlRows, ChartName, True)
                    End If
                Next
            Next


        End With
    End Sub
    Private Sub SheetChartDay_BK(ByVal nDay As Integer, ByVal frmSch As clsVSchedule)
        Dim ColInsCusReturn As Integer = 27
        Dim ColInsCusFG As Integer = 22
        Dim ColInsZFFG As Integer = 13
        Dim ColInsZFEmpty As Integer = 8
        Dim ColDayLeft As Integer = 2
        Dim ColDayRight As Integer = 16
        Dim RowDay As Integer = 5

        Dim ColStart As Integer = 7
        Dim RowStart As Integer = 27
        Dim RowPerSet As Integer = 40

        With cPrint
            .TemplateSheetName = "TPChartDay"
            .OutputSheetName = "Chartday"
            .CreateSheet(.TemplateSheetName, .TemplateSheetName, .OutputSheetName)

            .setSheatHeader("C28", Converts.ToInt_NullIsZero(frmSch.txtCapacityZF.Text.Trim))
            .setSheatHeader("C29", Converts.ToInt_NullIsZero(frmSch.txtBreakTimeZF.Text.Trim))
            .setSheatHeader("C30", Converts.ToInt_NullIsZero(frmSch.txtWorkingHrsZF.Text.Trim))
            .setSheatHeader("C31", Converts.ToInt_NullIsZero(frmSch.txtWorkTimeZF.Text.Trim))
            .setSheatHeader("C32", Converts.ToInt_NullIsZero(frmSch.txtTotalCapacityZF.Text.Trim))
            .setSheatHeader("C33", Converts.ToInt_NullIsZero(frmSch.txtTrackTimeZF.Text.Trim))
            .setSheatHeader("C34", Converts.ToInt_NullIsZero(frmSch.txtBlockForSkiplot.Text.Trim))
            .setSheatHeader("C35", Converts.ToInt_NullIsZero(frmSch.txtBlockForMaintenance.Text.Trim))

            .setSheatHeader("Q28", Converts.ToInt_NullIsZero(frmSch.txtCapacityZF.Text.Trim))
            .setSheatHeader("Q29", Converts.ToInt_NullIsZero(frmSch.txtBreakTimeZF.Text.Trim))
            .setSheatHeader("Q30", Converts.ToInt_NullIsZero(frmSch.txtWorkingHrsZF.Text.Trim))
            .setSheatHeader("Q31", Converts.ToInt_NullIsZero(frmSch.txtWorkTimeZF.Text.Trim))
            .setSheatHeader("Q32", Converts.ToInt_NullIsZero(frmSch.txtTotalCapacityZF.Text.Trim))
            .setSheatHeader("Q33", Converts.ToInt_NullIsZero(frmSch.txtTrackTimeZF.Text.Trim))



            Dim nRange As Integer = 0
            Dim ColIns As Integer = 0
            For iLoop As Integer = 10 To 0 Step -1
                Select Case iLoop
                    Case clsCSchedule.eGridType.CusReturn : nRange = GetNRange(frmSch.dtCusEmptyReturn(0)) : ColIns = ColInsCusReturn
                    Case clsCSchedule.eGridType.CusFG : nRange = GetNRange(frmSch.dtCusFG(0)) : ColIns = ColInsCusFG
                    Case clsCSchedule.eGridType.ZFFG : nRange = GetNRange(frmSch.dtZFFG(0)) : ColIns = ColInsZFFG
                    Case clsCSchedule.eGridType.ZFEmptyRack : nRange = GetNRange(frmSch.dtZFEmptyRack(0)) : ColIns = ColInsZFEmpty
                    Case Else : GoTo NextLoop1
                End Select
                If nRange > 3 Then
                    For iIns As Integer = 4 To nRange
                        .InsertColumn(.OutputSheetName, ColIns, 1)
                        If iLoop = clsCSchedule.eGridType.ZFEmptyRack Or iLoop = clsCSchedule.eGridType.ZFFG Then
                            ColDayRight += 1
                        End If
                    Next
                End If
                .CellBackColor(.CellRange(RowStart + 3, ColIns - 1, 0, 0), Color.LawnGreen)

NextLoop1:
            Next
            If nDay > 1 Then
                For iDay As Integer = 2 To nDay
                    .CopyPasteRow(.OutputSheetName, "1:" & RowPerSet, .OutputSheetName, (RowPerSet * (iDay - 1)) + 1)
                    '2-16
                    .setSheatHeader(GetExcelCol(ColDayLeft) & (RowPerSet * (iDay - 1)) + 5, "Day " & iDay)
                    .setSheatHeader(GetExcelCol(ColDayRight) & (RowPerSet * (iDay - 1)) + 5, "Day " & iDay)
                Next
            End If

            For iDay As Integer = 1 To nDay
                Dim ExcelColumn As Integer = ColStart
                Dim ExcelRow As Integer = ((iDay - 1) * RowPerSet) + RowStart



                For iLoop As Integer = 0 To 10
                    Dim dt As DataTable = Nothing
                    Dim grd As OPE_Controls.opeDataGrid = Nothing
                    nRange = 0
                    Dim IDQty As Integer = 0
                    Dim IDAccum As Integer = 0
                    Dim IDResult As Integer = 0
                    Dim IDDeli As Integer = 0
                    Select Case iLoop
                        Case clsCSchedule.eGridType.ZFEmptyRack
                            dt = frmSch.dtZFEmptyRack(iDay - 1)
                            grd = GetGrid(clsCSchedule.eGridType.ZFEmptyRack, frmSch)
                            IDQty = clsCSchedule.eIDZFEmptyRack.Quantity
                            IDAccum = clsCSchedule.eIDZFEmptyRack.Accumulate
                            IDResult = clsCSchedule.eIDZFEmptyRack.EmptyRack
                            IDDeli = clsCSchedule.eIDZFEmptyRack.ReturnToZF
                        Case clsCSchedule.eGridType.ZFFG
                            dt = frmSch.dtZFFG(iDay - 1)
                            grd = GetGrid(clsCSchedule.eGridType.ZFFG, frmSch)
                            IDQty = clsCSchedule.eIDZFFG.Quantity
                            IDAccum = clsCSchedule.eIDZFFG.Accumulate
                            IDResult = clsCSchedule.eIDZFFG.InitialFG
                            IDDeli = clsCSchedule.eIDZFFG.Delivery
                        Case clsCSchedule.eGridType.CusFG
                            dt = frmSch.dtCusFG(iDay - 1)
                            grd = GetGrid(clsCSchedule.eGridType.CusFG, frmSch)
                            IDQty = clsCSchedule.eIDCusFG.Quantity
                            IDAccum = clsCSchedule.eIDCusFG.Accumulate
                            IDResult = clsCSchedule.eIDCusFG.InitialFG
                            IDDeli = clsCSchedule.eIDCusFG.DeliveryArrive
                        Case clsCSchedule.eGridType.CusReturn
                            dt = frmSch.dtCusEmptyReturn(iDay - 1)
                            grd = GetGrid(clsCSchedule.eGridType.CusReturn, frmSch)
                            IDQty = clsCSchedule.eIDCusEmptyReturn.Quantity
                            IDAccum = clsCSchedule.eIDCusEmptyReturn.Accumulate
                            IDResult = clsCSchedule.eIDCusEmptyReturn.EmptyRack
                            IDDeli = clsCSchedule.eIDCusEmptyReturn.ReturnToZF
                    End Select

                    If Not dt Is Nothing Then
                        Dim dr As DataRow = Nothing
                        Dim Range1 As Integer = ExcelColumn
                        Dim Range2 As Integer = ExcelColumn

                        For iCol As Integer = 0 To dt.Columns.Count - 1
                            Dim ColName As String = dt.Columns(iCol).ColumnName
                            If Not (ColName = "ID" Or ColName = "Desc") Then
                                .setSheatHeader(GetExcelCol(ExcelColumn) & ExcelRow, ColName.Replace(".", ":"))
                                dr = dt.Select("ID=" & IDQty & "")(0)
                                If Converts.ToInt_NullIsZero(dr(iCol)) <> 0 Then .setSheatHeader(GetExcelCol(ExcelColumn) & ExcelRow + 1, dr(iCol))

                                Dim BGColor As Color = GetGridBackColor(grd, IDQty, ColName)
                                If Not (BGColor.A = 0 And BGColor.R = 0 And BGColor.G = 0 And BGColor.B = 0) Then _
                                    .SetBackgroundColor(GetExcelCol(ExcelColumn) & ExcelRow + 1, BGColor.R, BGColor.G, BGColor.B)

                                dr = dt.Select("ID=" & IDAccum & "")(0)
                                If Converts.ToInt_NullIsZero(dr(iCol)) <> 0 Then .setSheatHeader(GetExcelCol(ExcelColumn) & ExcelRow + 2, dr(iCol))

                                dr = dt.Select("ID=" & IDResult & "")(0)
                                If Converts.ToInt_NullIsZero(dr(iCol)) <> 0 Then .setSheatHeader(GetExcelCol(ExcelColumn) & ExcelRow + 3, dr(iCol))

                                dr = dt.Select("ID=" & IDDeli & "")(0)
                                If Converts.ToInt_NullIsZero(dr(iCol)) <> 0 Then .setSheatHeader(GetExcelCol(ExcelColumn) & ExcelRow + 5, dr(iCol))
                                Range2 = ExcelColumn
                                ExcelColumn += 1
                            End If
                        Next
                        Select Case iLoop
                            Case clsCSchedule.eGridType.ZFEmptyRack : ExcelColumn += 2
                            Case clsCSchedule.eGridType.ZFFG : ExcelColumn += 6
                            Case clsCSchedule.eGridType.CusFG : ExcelColumn += 2
                        End Select

                    End If
                Next
            Next


        End With
    End Sub
    Private Sub SheetChartOverview(ByVal nDay As Integer, ByVal frmSch As clsVSchedule)
        Dim ColIns As Integer = 3
        Dim RowStart As Integer = 23
        Dim ColStart As Integer = 3
        With cPrint
            .TemplateSheetName = "TPChartOverview"
            .OutputSheetName = "Overview"
            .CreateSheet(.TemplateSheetName, .TemplateSheetName, .OutputSheetName)

            Dim ExcelCol As Integer = ColStart
            Dim ExcelRow As Integer = RowStart
           
            For iDay As Integer = 1 To nDay
                Dim sDay As String = GetOverviewDay(frmSch.dtOverview, iDay)
                Dim ZFEmptyRackValue As Integer = GetOverViewValue(frmSch.dtOverview, clsCSchedule.eGridType.ZFEmptyRack, sDay)
                Dim ZFFGValue As Integer = GetOverViewValue(frmSch.dtOverview, clsCSchedule.eGridType.ZFFG, sDay)
                Dim CusFGValue As Integer = GetOverViewValue(frmSch.dtOverview, clsCSchedule.eGridType.CusFG, sDay)
                Dim CusReturnValue As Integer = GetOverViewValue(frmSch.dtOverview, clsCSchedule.eGridType.CusReturn, sDay)
                .setSheatHeader(GetExcelCol(ExcelCol) & ExcelRow, GetOverviewDay(frmSch.dtOverview, iDay))
                .setSheatHeader(GetExcelCol(ExcelCol) & ExcelRow + 1, ZFEmptyRackValue)
                .setSheatHeader(GetExcelCol(ExcelCol) & ExcelRow + 2, ZFFGValue)
                .setSheatHeader(GetExcelCol(ExcelCol) & ExcelRow + 3, CusFGValue)
                .setSheatHeader(GetExcelCol(ExcelCol) & ExcelRow + 4, CusReturnValue)
                If ZFEmptyRackValue < 0 Then .SetBackgroundColor(GetExcelCol(ExcelCol) & ExcelRow + 1, Color.Red.R, Color.Red.G, Color.Red.B)
                If ZFFGValue < 0 Then .SetBackgroundColor(GetExcelCol(ExcelCol) & ExcelRow + 2, Color.Red.R, Color.Red.G, Color.Red.B)
                If CusFGValue < 0 Then .SetBackgroundColor(GetExcelCol(ExcelCol) & ExcelRow + 3, Color.Red.R, Color.Red.G, Color.Red.B)
                If CusReturnValue < 0 Then .SetBackgroundColor(GetExcelCol(ExcelCol) & ExcelRow + 4, Color.Red.R, Color.Red.G, Color.Red.B)
                ExcelCol += 1
            Next
            Dim sCol As String = GetExcelCol(ColStart + nDay - 1)
            .AddChart(.OutputSheetName, "B23:" & sCol & "27", "B2", 200 + ((nDay - 1) * 50), 300, "Overview", Excel.XlRowCol.xlColumns, "ChartOverview", True)
        End With

    End Sub
    Private Sub SheetSummary(ByVal nDay As Integer, ByVal frmSch As clsVSchedule)
        Dim RowInsZF As Integer = 6
        Dim RowInsCus As Integer = 12
        Dim RowStart As Integer = 4

        With cPrint
            .TemplateSheetName = "TPSummary"
            .OutputSheetName = "Summary"
            .CreateSheet(.TemplateSheetName, .TemplateSheetName, .OutputSheetName)

            If nDay > 3 Then
                .InsertRow(RowInsCus, nDay - 3)
                .InsertRow(RowInsZF, nDay - 3)
            End If

            Dim ExcelRow As Integer = RowStart
            Dim TravelHRZF As Integer = Converts.ToInt_NullIsZero(frmSch.txtTravelMinsZF.Text.Trim) * 60
            Dim TravelHRCus As Integer = Converts.ToInt_NullIsZero(frmSch.txtTravelMinsCus.Text.Trim) * 60
            Dim StartDeliveryZF As String = GetDeliveryStart(True)
            Dim StartDeliveryCus As String = GetDeliveryStart(False)
            Dim BlockSkipLot As Integer = frmSch.txtBlockForSkiplot.Text.Trim
            Dim BlockMaintenance As Integer = frmSch.txtBlockForMaintenance.Text.Trim
            .setSheatHeader("N" & ExcelRow - 2, frmSch.txtTotalCapacityZF.Text.Trim)
            .setSheatHeader("N" & ExcelRow - 1, frmSch.txtWorkTimeZF.Text.Trim)
            .setSheatHeader("N" & ExcelRow, frmSch.txtBreakTimeZF.Text.Trim)

            For iDay As Integer = 1 To nDay
                Dim sDay As String = GetOverviewDay(frmSch.dtOverview, iDay)
                Dim iniEmptyRackZF As Integer = GetIniEmptyRack(frmSch.dtZFEmptyRack, iDay)
                Dim MinEmptyRackZF As Integer = GetOverViewValue(frmSch.dtOverview, clsCSchedule.eGridType.ZFEmptyRack, sDay)
                Dim iniZFFG As Integer = GetIniZFFG(frmSch.dtZFFG(iDay - 1))
                Dim MinZFFG As Integer = GetOverViewValue(frmSch.dtOverview, clsCSchedule.eGridType.ZFFG, sDay)

                .setSheatHeader("B" & ExcelRow, sDay)
                .setSheatHeader("C" & ExcelRow, iniEmptyRackZF)
                .setSheatHeader("D" & ExcelRow, MinEmptyRackZF)
                .setSheatHeader("E" & ExcelRow, iniZFFG)
                .setSheatHeader("F" & ExcelRow, MinZFFG)
                .setSheatHeader("G" & ExcelRow, frmSch.txtTripPerDayZF.Text.Trim)
                .setSheatHeader("H" & ExcelRow, frmSch.txtQtyPerTripZF.Text.Trim)
                .setSheatHeader("I" & ExcelRow, TravelHRZF)
                .setSheatHeader("J" & ExcelRow, StartDeliveryZF)
                .setSheatHeader("K" & ExcelRow, BlockSkipLot)
                .setSheatHeader("L" & ExcelRow, BlockMaintenance)

                ExcelRow += 1
            Next

            ExcelRow += 3
            .setSheatHeader("N" & ExcelRow - 2, frmSch.txtTotalCapacityCus.Text.Trim)
            .setSheatHeader("N" & ExcelRow - 1, frmSch.txtWorkTimeCus.Text.Trim)
            .setSheatHeader("N" & ExcelRow, frmSch.txtBreakTimeCus.Text.Trim)

            For iDay As Integer = 1 To nDay
                Dim sDay As String = GetOverviewDay(frmSch.dtOverview, iDay)
                Dim iniCusFG As Integer = GetIniCusFG(frmSch.dtCusFG(iDay - 1))
                Dim minCusFG As Integer = GetOverViewValue(frmSch.dtOverview, clsCSchedule.eGridType.CusFG, sDay)
                Dim iniCusEmptyReturn As Integer = GetIniEmptyReturn(frmSch.dtCusEmptyReturn(iDay - 1))
                Dim minCusEmptyReturn As Integer = GetOverViewValue(frmSch.dtOverview, clsCSchedule.eGridType.CusReturn, sDay)


                .setSheatHeader("B" & ExcelRow, sDay)
                .setSheatHeader("C" & ExcelRow, iniCusFG)
                .setSheatHeader("D" & ExcelRow, minCusFG)
                .setSheatHeader("E" & ExcelRow, iniCusEmptyReturn)
                .setSheatHeader("F" & ExcelRow, minCusEmptyReturn)
                .setSheatHeader("G" & ExcelRow, frmSch.txtTripPerDayCus.Text.Trim)
                .setSheatHeader("H" & ExcelRow, frmSch.txtQtyPerTripCus.Text.Trim)
                .setSheatHeader("I" & ExcelRow, TravelHRCus)
                .setSheatHeader("J" & ExcelRow, StartDeliveryCus)

                ExcelRow += 1
            Next

        End With
    End Sub
#End Region

#Region "Get initial value"
    Private Function GetIniEmptyRack(ByVal dtZFEmptyRack() As DataTable, ByVal iDay As Integer) As Integer
        Dim iniEmptyRackZF As Integer
        If iDay = 1 Then
            iniEmptyRackZF = Converts.ToInt_NullIsZero(dtZFEmptyRack)
        Else
            Dim FirstColEmptyRack As Integer = GetFirstColValue(dtZFEmptyRack(iDay - 1), clsCSchedule.eIDZFEmptyRack.EmptyRack)
            Dim FirstColReturnToZF As Integer = GetFirstColValue(dtZFEmptyRack(iDay - 1), clsCSchedule.eIDZFEmptyRack.ReturnToZF)
            Dim FirstColQty As Integer = GetFirstColValue(dtZFEmptyRack(iDay - 1), clsCSchedule.eIDZFEmptyRack.Quantity)
            iniEmptyRackZF = FirstColEmptyRack - FirstColReturnToZF + FirstColQty
        End If

        Return iniEmptyRackZF
    End Function

    Private Function GetIniZFFG(ByVal dtZFFG As DataTable) As Integer
        Dim iniZFFG As Integer = 0
        Dim FirstColIniFG As Integer = GetFirstColValue(dtZFFG, clsCSchedule.eIDZFFG.InitialFG)
        Dim FirstColDelivery As Integer = GetFirstColValue(dtZFFG, clsCSchedule.eIDZFFG.Delivery)
        iniZFFG = FirstColIniFG + FirstColDelivery

        Return iniZFFG
    End Function

    Private Function GetIniCusFG(ByVal dtCusFG As DataTable) As Integer
        Dim iniCusFG As Integer = 0
        Dim FirstColIniFG As Integer = GetFirstColValue(dtCusFG, clsCSchedule.eIDCusFG.InitialFG)
        Dim FirstColDeliArr As Integer = GetFirstColValue(dtCusFG, clsCSchedule.eIDCusFG.DeliveryArrive)
        iniCusFG = FirstColIniFG - FirstColDeliArr

        Return iniCusFG
    End Function

    Private Function GetIniEmptyReturn(ByVal dtCusEmptyReturn As DataTable) As Integer
        Dim iniEmptyReturn As Integer = 0
        Dim FirstColIniEmptyReturn As Integer = GetFirstColValue(dtCusEmptyReturn, clsCSchedule.eIDCusEmptyReturn.EmptyRack)
        Dim FirstColReturn As Integer = GetFirstColValue(dtCusEmptyReturn, clsCSchedule.eIDCusEmptyReturn.ReturnToZF)
        iniEmptyReturn = FirstColIniEmptyReturn + FirstColReturn

        Return iniEmptyReturn
    End Function
#End Region
    

    Private Function GetNDayfromOverview(ByVal dtOverview As DataTable) As Integer
        If dtOverview Is Nothing OrElse dtOverview.Rows.Count <= 0 Then Return 0

        Dim nDay As Integer = 0
        For iCol As Integer = 0 To dtOverview.Columns.Count - 1
            Dim ColName As String = dtOverview.Columns(iCol).ColumnName
            If Strings.Left(ColName.Trim, 3).ToUpper = "DAY" Then
                nDay += 1
            End If
        Next

        Return nDay
    End Function

    Private Function GetFirstColValue(ByVal dt As DataTable, ByVal ID As Integer) As Integer
        Dim dr As DataRow = dt.Select("ID=" & ID & "")(0)
        For iCol As Integer = 0 To dt.Columns.Count - 1
            Dim ColName As String = dt.Columns(iCol).ColumnName
            If Not (ColName = "ID" Or ColName = "Desc") Then
                Return Converts.ToInt_NullIsZero(dr(iCol))
            End If
        Next

        Return 0
    End Function

    Private Function GetOverviewDay(ByVal dt As DataTable, ByVal iDay As Integer) As String
        For iCol As Integer = 0 To dt.Columns.Count - 1
            Dim ColName As String = (dt.Columns(iCol).ColumnName).Trim
            If Strings.Left(ColName, 3) = "Day" AndAlso Strings.Right(ColName, ColName.Length - 4) = iDay.ToString Then
                Return ColName
            End If
        Next

        Return ""
    End Function

    Private Function GetOverViewValue(ByVal dt As DataTable, ByVal ID As Integer, ByVal sDay As String) As Integer
        Dim dr As DataRow = dt.Select("ID=" & ID & "")(0)
        For iCol As Integer = 0 To dt.Columns.Count - 1
            Dim ColName As String = dt.Columns(iCol).ColumnName.Trim
            If ColName = sDay Then
                Return dr(iCol)
            End If
        Next

        Return 0
    End Function

    Private Function GetDeliveryStart(ByVal fZF As Boolean) As String
        Dim cls As New clsCWorkPeriod
        Dim dt As DataTable = cls.getMasterDeliveryTime(fZF)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            Return ""
        Else
            Dim dr As DataRow = dt.Select("Period=1")(0)
            If dr Is Nothing Then
                Return ""
            Else
                Dim sTime As String = dr("Time")
                Dim dTime As Date = New Date(Now.Year, Now.Month, Now.Day, Strings.Left(sTime, 2), Strings.Right(sTime, 2), 0)
                Return Format(dTime, "HH:mm:ss")
            End If
        End If
    End Function

    Private Function GetNRange(ByVal dt As DataTable) As Integer
        Dim nRange As Integer = 0
        For iCol As Integer = 0 To dt.Columns.Count - 1
            Dim ColName As String = dt.Columns(iCol).ColumnName
            If Not (ColName = "ID" Or ColName = "Desc") Then
                nRange += 1
            End If
        Next

        Return nRange
    End Function

    Private Function GetExcelCol(ByVal iCol As Integer) As String
        '1-26 = "A-Z"
        'ASC("A") = 65

        Dim Remain As Integer = iCol Mod 26
        Dim nMulti As Integer = (iCol - Remain) / 26
        'nMulti = 0 "A", 1=B, 2=C
        Dim Prefix As String = "" 'Asc(nMulti + 65)

        If Remain = 0 Then nMulti = nMulti - 1
        If nMulti > 0 Then Prefix = Chr(nMulti + 64)

        '1-25, 0 = Z
        Dim LastString As String = ""
        If Remain = 0 Then LastString = "Z" Else LastString = Chr(Remain + 64)

        Return Prefix & LastString
    End Function

    Private Function GetGrid(ByVal GridType As Integer, ByVal frmSch As clsVSchedule) As OPE_Controls.opeDataGrid
        Dim pge As TabPage = Nothing
        Select Case GridType
            Case clsCSchedule.eGridType.ZFEmptyRack : pge = frmSch.pgeZFEmptyRack
            Case clsCSchedule.eGridType.ZFFG : pge = frmSch.pgeZFFG
            Case clsCSchedule.eGridType.CusFG : pge = frmSch.pgeCusFG
            Case clsCSchedule.eGridType.CusReturn : pge = frmSch.pgeCusEmptyReturn
        End Select

        If pge Is Nothing Then GoTo NoControl

        For Each ctrl1 As Control In pge.Controls
            If ctrl1.GetType() Is GetType(TableLayoutPanel) Then
                For Each ctrl2 As Control In ctrl1.Controls
                    If ctrl2.GetType() Is GetType(OPE_Controls.opeDataGrid) Then
                        Return ctrl2
                    End If
                Next
            End If
        Next

NoControl:
        Return Nothing
    End Function

    Private Function GetGridBackColor(ByVal grd As OPE_Controls.opeDataGrid, ByVal ID As Integer, ByVal ColName As String) As Color
        For iRow As Integer = 0 To grd.Rows.Count - 1
            If Converts.ToInt_NullIsZero(grd.Rows(iRow).Cells("ID").Value) = ID Then
                For iCol As Integer = 0 To grd.Columns.Count - 1
                    If grd.Columns(iCol).Name = ColName Then
                        Dim BGColor As Color = grd.Rows(iRow).Cells(iCol).Style.BackColor
                        If Not (BGColor.A = 0 And BGColor.R = 0 And BGColor.G = 0 And BGColor.B = 0) Then
                            Return BGColor
                        End If
                    End If
                Next
            End If
        Next
        Return Nothing
    End Function
End Class
