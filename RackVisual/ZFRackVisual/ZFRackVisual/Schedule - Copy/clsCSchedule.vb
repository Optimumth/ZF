Imports OPE_Controls.OpeStyle

Public Class clsCSchedule
#Region "Enum"
    Public Enum eGridType
        OverView = 0
        ZFEmptyRack = 1
        ZFFG = 2
        CusFG = 3
        CusReturn = 4
    End Enum
    Public Enum eIDZFEmptyRack
        Quantity = 1
        Accumulate = 2
        EmptyRack = 3
        ReturnToZF = 4
    End Enum
    Public Enum eIDZFFG
        Quantity = 1
        Accumulate = 2
        InitialFG = 3
        Delivery = 4
    End Enum
    Public Enum eIDCusFG
        Quantity = 1
        Accumulate = 2
        InitialFG = 3
        DeliveryArrive = 4
    End Enum
    Public Enum eIDCusEmptyReturn
        Quantity = 1
        Accumulate = 2
        EmptyRack = 3
        ReturnToZF = 4
    End Enum
#End Region
#Region "1-Master"
    Public Function GetProdHr(ByVal fZF As Boolean) As Decimal
        Dim ProdMin As Integer = GetProdMin(fZF)
        Dim ProdHr As Decimal = Math.Round(ProdMin / 60, 1)
        Return ProdHr
    End Function

    Public Function GetProdMin(ByVal fZF As Boolean) As Integer
        Dim clsTime As New clsCWorkPeriod
        Dim dt As DataTable = clsTime.getMasterTime(fZF)
        Dim CurDate As Date = Now.Date
        Dim WorkMin As Integer = 0
        For Each dr As DataRow In dt.Select("", "Period")
            Dim WorkStart As Date = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(dr("Start"), 2)), Converts.ToInt(Strings.Right(dr("Start"), 2)), 0)
            Dim WorkStop As Date = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(dr("Stop"), 2)), Converts.ToInt(Strings.Right(dr("Stop"), 2)), 0)
            If WorkStart > WorkStop Then WorkStop = DateAdd(DateInterval.Day, 1, WorkStop)
            WorkMin += DateDiff(DateInterval.Minute, WorkStart, WorkStop)
        Next

        Return WorkMin
    End Function

    Public Function GetProdMinDay(ByVal fZF As Boolean) As Integer
        Dim clsTime As New clsCWorkPeriod
        Dim dt As DataTable = clsTime.getMasterTime(fZF)
        Dim CurDate As Date = Now.Date
        Dim WorkStart As Date
        Dim WorkStop As Date
        Dim Mins As Integer = 0
        For Each dr As DataRow In dt.Select("", "Period")
            WorkStart = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(dr("Start"), 2)), Converts.ToInt(Strings.Right(dr("Start"), 2)), 0)
            Exit For
        Next
        For Each dr As DataRow In dt.Select("", "Period desc")
            WorkStop = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(dr("Stop"), 2)), Converts.ToInt(Strings.Right(dr("Stop"), 2)), 0)
            Exit For
        Next
        If WorkStart > WorkStop Then
            WorkStop = DateAdd(DateInterval.Day, 1, WorkStop)
        End If
        Mins = DateDiff(DateInterval.Minute, WorkStart, WorkStop)

        Return Mins
    End Function
#End Region
#Region "2-TrackTime"
    Public Function GetTrackTime(ByVal TrackMins As Integer, ByVal TravelMins As Integer, ByVal GridType As Integer) As DataTable
        Dim dt As New DataTable
        Dim clsTime As New clsCWorkPeriod
        Dim dtTime As DataTable = clsTime.getMasterTime(IIf(GridType = eGridType.ZFEmptyRack Or GridType = eGridType.ZFFG, True, False))
        Dim CurDate As Date = Now.Date
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Desc", GetType(String))

        Dim drAdd As DataRow = Nothing
        Dim WorkStart As Date
        Dim WorkStop As Date
        For Each drTime As DataRow In dtTime.Select("", "Period")
            WorkStart = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(drTime("Start"), 2)), Converts.ToInt(Strings.Right(drTime("Start"), 2)), 0)
            Exit For
        Next
        For Each drTime As DataRow In dtTime.Select("", "Period desc")
            WorkStop = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(drTime("Stop"), 2)), Converts.ToInt(Strings.Right(drTime("Stop"), 2)), 0)
            Exit For
        Next

        Dim dtDeliTime As DataTable = clsTime.getMasterDeliveryTime(IIf(GridType = eGridType.ZFFG Or GridType = eGridType.CusFG, True, False))
        For Each drDeliTime As DataRow In dtDeliTime.Select("", "Period desc")
            Dim DeliTime As Date = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(drDeliTime("Time"), 2)), Converts.ToInt(Strings.Right(drDeliTime("Time"), 2)), 0)
            Dim PlotTime As Date = DateAdd(DateInterval.Minute, TravelMins, DeliTime)
            If PlotTime > WorkStop Then
                WorkStop = PlotTime
            End If
        Next

        Do
            dt.Columns.Add(Format(WorkStart, "HH.mm"), GetType(Integer))
            WorkStart = DateAdd(DateInterval.Minute, TrackMins, WorkStart)
            If WorkStart >= WorkStop Then
                If WorkStart = WorkStop Then
                    dt.Columns.Add(Format(WorkStart, "HH.mm"), GetType(Integer))
                End If
                Exit Do
            End If
        Loop
        Return dt
    End Function

#End Region
#Region "3-Both-Quantity+Accumulate"
    Public Function GetQty(ByVal dt As DataTable, ByVal fZF As Boolean) As DataTable
        Dim RowID As Integer = eIDZFEmptyRack.Quantity
        Dim clsTime As New clsCWorkPeriod
        Dim dtTime As DataTable = clsTime.getMasterTime(fZF)

        Dim drAdd As DataRow = dt.NewRow
        drAdd("ID") = RowID
        drAdd("Desc") = "Quantity"

        For iCol As Integer = 0 To dt.Columns.Count - 1
            Dim ColName As String = dt.Columns(iCol).ColumnName
            If Not (ColName = "ID" Or ColName = "Desc") Then
                If dtTime.Compute("count(Period)", "'" & Replace(ColName, ":", ".") & "' > Start and '" & Replace(ColName, ":", ".") & "' <= Stop") > 0 Then
                    drAdd(iCol) = 1
                End If
            End If
        Next

        dt.Rows.Add(drAdd)

        Return dt
    End Function

    Public Function GetAccumulate(ByVal dt As DataTable, ByVal fZF As Boolean) As DataTable
        Dim RowID As Integer = IIf(fZF = True, eIDZFEmptyRack.Accumulate, eIDCusFG.Accumulate)
        Dim AccQty As Integer = 0
        For Each drTime As DataRow In dt.Select("Desc='Quantity'")
            Dim drAdd As DataRow = dt.NewRow
            drAdd("ID") = RowID
            drAdd("Desc") = "Accumulate"

            For iCol As Integer = 1 To dt.Columns.Count - 1
                If Converts.ToInt_NullIsZero(drTime(iCol)) <> 0 Then
                    AccQty += drTime(iCol)
                End If
                If AccQty <> 0 Then drAdd(iCol) = AccQty
            Next
            dt.Rows.Add(drAdd)
        Next

        Return dt
    End Function

#End Region
#Region "4-EmptyRack and FG Remain"
    Public Function GetRemain(ByVal dt As DataTable, ByVal iniQty As Integer, ByVal GridType As Integer, ByVal BlockSkipLot As Integer, ByVal BlockMaintenance As Integer)
        Dim RowIDNew As Integer = 0
        Dim RowIDQty As Integer = 0
        Dim sDesc As String = ""
        Select Case GridType
            Case eGridType.ZFEmptyRack
                RowIDNew = eIDZFEmptyRack.EmptyRack
                RowIDQty = eIDZFEmptyRack.Quantity
                sDesc = "Empty Rack"
            Case eGridType.ZFFG
                RowIDNew = eIDZFFG.InitialFG
                RowIDQty = eIDZFFG.Quantity
                sDesc = "FG"
            Case eGridType.CusFG
                RowIDNew = eIDCusFG.InitialFG
                RowIDQty = eIDCusFG.Quantity
                sDesc = "FG"
            Case eGridType.CusReturn
                RowIDNew = eIDCusEmptyReturn.EmptyRack
                RowIDQty = eIDCusEmptyReturn.Quantity
                sDesc = "Empty Return"
        End Select

        Dim drAdd As DataRow = dt.NewRow
        Dim RemainQty As Integer = iniQty
        Dim drQty As DataRow = dt.Select("ID=" & RowIDQty & "")(0)
        Dim iTime As Integer = 0
        For iCol As Integer = 0 To dt.Columns.Count - 1
            Dim ColName As String = dt.Columns(iCol).ColumnName
            Select Case ColName
                Case "ID" : drAdd(ColName) = RowIDNew
                Case "Desc" : drAdd(ColName) = sDesc
                Case Else
                    iTime += 1
                    Select Case GridType
                        Case eGridType.ZFEmptyRack, eGridType.CusFG : RemainQty = RemainQty - Converts.ToInt_NullIsZero(drQty(ColName))
                        Case eGridType.ZFFG, eGridType.CusReturn : RemainQty += Converts.ToInt_NullIsZero(drQty(ColName))
                    End Select
                    If iTime = 2 And GridType = eGridType.ZFEmptyRack Then RemainQty = RemainQty - BlockSkipLot - BlockMaintenance
                    drAdd(ColName) = IIf(RemainQty = 0, DBNull.Value, RemainQty)
            End Select
        Next

        dt.Rows.Add(drAdd)

        Return dt
    End Function
#End Region
#Region "5-Delivery, Return and Arrive"
    Public Function GetDelivery(ByVal dt As DataTable, ByVal QtyPerTrip As Integer, ByVal fZFToCus As Boolean) As DataTable
        Dim cls As New clsCWorkPeriod
        Dim dtDeliveryTime As DataTable = cls.getMasterDeliveryTime(fZFToCus)
        Dim RowIniFG As Integer = IIf(fZFToCus = True, eIDZFFG.InitialFG, eIDCusEmptyReturn.EmptyRack)
        Dim drIniFG As DataRow = dt.Select("ID = " & RowIniFG & "")(0)
        Dim drAdd As DataRow = dt.NewRow()
        drAdd("ID") = IIf(fZFToCus = True, eIDZFFG.Delivery, eIDCusEmptyReturn.ReturnToZF)
        drAdd("Desc") = IIf(fZFToCus = True, "Delivery", "Return")

        For Each drDeliveryTime As DataRow In dtDeliveryTime.Select("", "Period")
            For iCol As Integer = 0 To dt.Columns.Count - 1
                Dim ColName As String = dt.Columns(iCol).ColumnName
                If Not (ColName = "ID" Or ColName = "Desc") And ColName >= drDeliveryTime("Time") Then
                    Dim DeliQty As Integer = 0
                    Dim IniFGQty As Integer = Converts.ToInt_NullIsZero(drIniFG(ColName))
                    If QtyPerTrip <= IniFGQty Then
                        DeliQty = QtyPerTrip
                    Else
                        DeliQty = IniFGQty
                    End If
                    If DeliQty <> 0 Then drAdd(ColName) = DeliQty

                    For iIniFGCol As Integer = iCol To dt.Columns.Count - 1
                        If Converts.ToInt_NullIsZero(drIniFG(iIniFGCol)) - DeliQty = 0 Then
                            drIniFG(iIniFGCol) = DBNull.Value
                        Else
                            drIniFG(iIniFGCol) = Converts.ToInt_NullIsZero(drIniFG(iIniFGCol)) - DeliQty
                        End If
                    Next
                    Exit For
                End If
            Next
        Next
        dt.Rows.Add(drAdd)

        Return dt
    End Function
    Public Function GetDeliveryArrive(ByVal dtArrive As DataTable, ByVal drDelivery As DataRow, ByVal TravelMins As Integer, ByVal fZFToCus As Boolean) As DataTable
        Dim RowDeliverID As Integer = IIf(fZFToCus = True, eIDCusFG.DeliveryArrive, eIDZFEmptyRack.ReturnToZF)
        Dim RowIniFG As Integer = IIf(fZFToCus = True, eIDCusFG.InitialFG, eIDZFEmptyRack.EmptyRack)
        Dim drArrIniFG As DataRow = dtArrive.Select("ID=" & RowIniFG & "")(0)
        Dim drAdd As DataRow = dtArrive.NewRow
        drAdd("ID") = RowDeliverID
        drAdd("Desc") = IIf(fZFToCus = True, "Delivery Arrive", "Return to ZF")

        For iColDeli As Integer = 0 To drDelivery.Table.Columns.Count - 1
            If Not (drDelivery.Table.Columns(iColDeli).ColumnName = "ID" Or drDelivery.Table.Columns(iColDeli).ColumnName = "Desc") Then
                Dim DeliveryQty As Integer = Converts.ToInt_NullIsZero(drDelivery(iColDeli))

                If DeliveryQty > 0 Then
                    Dim DeliveryColName As String = drDelivery.Table.Columns(iColDeli).ColumnName
                    Dim DeliveryTime As Date = New Date(Today.Year, Today.Month, Today.Day, Left(DeliveryColName, 2), Strings.Right(DeliveryColName, 2), 0)
                    Dim PlanTime As Date = DateAdd(DateInterval.Minute, TravelMins, DeliveryTime)
                    Dim ArrivalStartFlag As Boolean = False
                    Dim ArrivalStart As Date = Nothing
                    Dim DeliveryPlotted As Boolean = False
                    For iColArrive As Integer = 0 To dtArrive.Columns.Count - 1
                        If Not (dtArrive.Columns(iColArrive).ColumnName = "ID" Or dtArrive.Columns(iColArrive).ColumnName = "Desc") Then
                            If ArrivalStartFlag = False Then ArrivalStartFlag = True : ArrivalStart = New Date(Today.Year, Today.Month, Today.Day, Left(DeliveryColName, 2), Strings.Right(DeliveryColName, 2), 0)
                            Dim ArrivalColName As String = dtArrive.Columns(iColArrive).ColumnName
                            Dim ArrivalTime As Date = New Date(Today.Year, Today.Month, Today.Day, Left(ArrivalColName, 2), Strings.Right(ArrivalColName, 2), 0)
                            If ArrivalTime < ArrivalStart Then
                                If DeliveryPlotted = False Then
                                    GoTo NextLoop
                                Else
                                    ArrivalTime = DateAdd(DateInterval.Minute, TravelMins, ArrivalTime)
                                End If
                            End If

                            If ArrivalTime >= PlanTime Then
                                drArrIniFG(iColArrive) = Converts.ToInt_NullIsZero(drArrIniFG(iColArrive)) + DeliveryQty
                                If DeliveryPlotted = False Then
                                    drAdd(iColArrive) = DeliveryQty
                                    DeliveryPlotted = True
                                End If
                            End If
                        End If
NextLoop:
                    Next
                End If
            End If
        Next
        dtArrive.Rows.Add(drAdd)

        Return dtArrive
    End Function
#End Region
#Region "6-Clear Column"
    Public Function ClearColumn(ByVal dt As DataTable, ByVal GridType As Integer) As DataTable
        If Not (GridType = eGridType.ZFEmptyRack Or GridType = eGridType.CusFG) Then Return dt

        Dim MaxCol As Integer = dt.Columns.Count - 1
        For iCol As Integer = MaxCol To 0 Step -1
            Dim ColName As String = dt.Columns(iCol).ColumnName
            If Not (ColName = "ID" Or ColName = "Desc") Then
                Dim RowQty As Integer = 0
                Dim RowReturn As Integer = 0

                Select Case GridType
                    Case eGridType.ZFEmptyRack : RowQty = eIDZFEmptyRack.Quantity : RowReturn = eIDZFEmptyRack.ReturnToZF
                    Case eGridType.CusFG : RowQty = eIDCusFG.Quantity : RowReturn = eIDCusFG.DeliveryArrive
                End Select

                Dim drQty As DataRow = dt.Select("ID=" & RowQty & "")(0)
                Dim drReturn As DataRow = dt.Select("ID=" & RowReturn & "")(0)

                If Converts.ToInt_NullIsZero(drQty(ColName)) = 0 And Converts.ToInt_NullIsZero(drReturn(ColName)) = 0 Then
                    dt.Columns.Remove(ColName)
                Else
                    Exit For
                End If
            End If
        Next

        Return dt
    End Function
#End Region
    
End Class
