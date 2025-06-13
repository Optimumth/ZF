Imports OPE_Controls.OpeStyle

Public Class clsCSchedule
    Public Function GetProdHr() As Decimal
        Dim ProdMin As Integer = GetProdMin()
        Dim ProdHr As Decimal = Math.Round(ProdMin / 60, 1)
        Return ProdHr
    End Function

    Public Function GetProdMin() As Integer
        Dim clsTime As New clsCWorkPeriod
        Dim dt As DataTable = clsTime.getMasterTime
        Dim CurDate As Date = Now.Date
        Dim WorkMin As Integer = 0
        For Each dr As DataRow In dt.Select("Type='Production'", "Period")
            Dim WorkStart As Date = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(dr("Start"), 2)), Converts.ToInt(Strings.Right(dr("Start"), 2)), 0)
            Dim WorkStop As Date = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(dr("Stop"), 2)), Converts.ToInt(Strings.Right(dr("Stop"), 2)), 0)
            WorkMin += DateDiff(DateInterval.Minute, WorkStart, WorkStop)
        Next

        Return WorkMin
    End Function

    Public Function GetTrackTime(ByVal TrackMins As Integer) As DataTable
        Dim dt As New DataTable
        Dim clsTime As New clsCWorkPeriod
        Dim dtTime As DataTable = clsTime.getMasterTime
        Dim CurDate As Date = Now.Date
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Desc", GetType(String))

        Dim drAdd As DataRow = Nothing
        Dim WorkStart As Date
        Dim WorkStop As Date
        For Each drTime As DataRow In dtTime.Select("Type='Production'", "Period")
            WorkStart = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(drTime("Start"), 2)), Converts.ToInt(Strings.Right(drTime("Start"), 2)), 0)
            Exit For
        Next
        For Each drTime As DataRow In dtTime.Select("Type='Production'", "Period desc")
            WorkStop = New Date(CurDate.Year, CurDate.Month, CurDate.Day, Converts.ToInt(Strings.Left(drTime("Stop"), 2)), Converts.ToInt(Strings.Right(drTime("Stop"), 2)), 0)
            Exit For
        Next

        Do
            dt.Columns.Add(Format(WorkStart, "HH:mm"), GetType(Integer))
            WorkStart = DateAdd(DateInterval.Minute, TrackMins, WorkStart)
            If WorkStart >= WorkStop Then
                If WorkStart = WorkStop Then
                    dt.Columns.Add(Format(WorkStart, "HH:mm"), GetType(Integer))
                End If
                Exit Do
            End If
        Loop

        Return dt
    End Function

    Public Function GetProdQty(ByVal dt As DataTable) As DataTable
        Dim clsTime As New clsCWorkPeriod
        Dim dtTime As DataTable = clsTime.getMasterTime

        Dim RowID As Integer = dt.Rows.Count + 1
        Dim drAdd As DataRow = dt.NewRow
        drAdd("ID") = RowID
        drAdd("Desc") = "Quantity"

        For iCol As Integer = 0 To dt.Columns.Count - 1
            Dim ColName As String = dt.Columns(iCol).ColumnName
            If Not (ColName = "ID" Or ColName = "Desc") Then
                If dtTime.Compute("count(Type)", "Type='Production' and '" & Replace(ColName, ":", ".") & "' > Start and '" & Replace(ColName, ":", ".") & "' <= Stop") > 0 Then
                    drAdd(iCol) = 1
                End If
            End If
        Next

        dt.Rows.Add(drAdd)

        Return dt
    End Function

    Public Function GetProdAccumulate(ByVal dt As DataTable) As DataTable
        Dim AccQty As Integer = 0
        For Each drTime As DataRow In dt.Select("Desc='Quantity'")
            Dim RowID As Integer = dt.Rows.Count + 1
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

    Public Function GetProdEmptyRack(ByVal dt As DataTable, ByVal iniEmptyRack As Integer) As DataTable
        Dim RowID As Integer = dt.Rows.Count + 1
        Dim drAdd As DataRow = dt.NewRow
        Dim IsFirstTime As Integer = True
        For iCol As Integer = 0 To dt.Columns.Count - 1
            Dim ColName As String = dt.Columns(iCol).ColumnName
            Select Case ColName
                Case "ID" : drAdd(ColName) = RowID
                Case "Desc" : drAdd(ColName) = "Empty Rack"
                Case Else
                    If IsFirstTime = True Then
                        drAdd(ColName) = iniEmptyRack
                    Else

                    End If
            End Select
        Next

        Return dt
    End Function
End Class
