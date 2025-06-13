Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCTruckDT
    Public Function GetDT(ByVal TruckID As String) As DataTable
        Dim dt As DataTable = DataBase.DataSelect("PrgTransaction" _
                                                  , "TruckID='" & TruckID & "'" _
                                                  , , , "0 as chk,PrgTransaction.*,RackID,RackNo,concat(MstRackHD.Code,MstRackDT.RackNo) as Show,MstRackHD.Type,'' as sta" _
                                                  , , " inner join MstRackDT on PrgTransaction.RackDTID=MstRackDT.ID" & _
                                                    " inner join MstRackHD on MstRackDT.RackHeaderID=MstRackHD.RackHeaderID" _
                                                  , "RackID")
        Return dt
    End Function

    Public Function GetTransEmpty(ByVal chkLogDate As Boolean, ByVal LogDate1 As Date, ByVal LogDate2 As Date) As DataTable
        Dim cond As String = "where isnull(TruckID,'')='' and [From] = '" & INI.Status_ZF & "' and [To] = '" & INI.Status_OnTruck & "'"
        If chkLogDate = True Then
            Converts.ToStringAnd(cond, "({0} And {1})", _
                                  Converts.ToStringSQLDateDiff(LogDate1, "case when convert(time(0),PrgTransaction.UpdateDate)>='00:00' and convert(time(0),PrgTransaction.UpdateDate)<='06:59' then DATEADD(d,-1,convert(date,PrgTransaction.UpdateDate)) else convert(date,PrgTransaction.UpdateDate) end", 0), _
                                  Converts.ToStringSQLDateDiff(LogDate2, "case when convert(time(0),PrgTransaction.UpdateDate)>='00:00' and convert(time(0),PrgTransaction.UpdateDate)<='06:59' then DATEADD(d,-1,convert(date,PrgTransaction.UpdateDate)) else convert(date,PrgTransaction.UpdateDate) end", 0, , OPE_Controls.OperationSymbol.IsLessThanOrEqualTo))
        End If
        Dim sql As String = String.Format("select 0 as chk,PrgTransaction.*,RackID,RackNo,concat(MstRackHD.Code,MstRackDT.RackNo) as Show,MstRackHD.Type,'' as sta         {0}" & _
                                          "       ,case when convert(time(0),PrgTransaction.UpdateDate)>='00:00' and convert(time(0),PrgTransaction.UpdateDate)<='06:59'   {0}" & _
                                          "             then DATEADD(d,-1,convert(date,PrgTransaction.UpdateDate))                                                         {0}" & _
                                          "             else convert(date,PrgTransaction.UpdateDate) end as LogDate                                                        {0}" & _
                                          " from PrgTransaction                                                                                                            {0}" & _
                                          " inner join MstRackDT on PrgTransaction.RackDTID=MstRackDT.ID                                                                   {0}" & _
                                          " inner join MstRackHD on MstRackDT.RackHeaderID=MstRackHD.RackHeaderID                                                          {0}" & _
                                          " {1}                                                                                                                            {0}" & _
                                          " order by case when convert(time(0),PrgTransaction.UpdateDate)>='00:00' and convert(time(0),PrgTransaction.UpdateDate)<='06:59' {0}" & _
                                          "               then DATEADD(d,-1,convert(date,PrgTransaction.UpdateDate))                                                       {0}" & _
                                          "               else convert(date,PrgTransaction.UpdateDate) end                                                                 {0}" & _
                                          "          ,RackID                                                                                                               {0}" & _
                                          "", vbCrLf, cond)

        Dim dt As DataTable = DataBase.DataTable(sql)

        Return dt
    End Function

    Public Function GetLastLogDate() As Date
        Dim dt As DataTable = DataBase.DataTable("select max(case when convert(time(0),PrgTransaction.UpdateDate)>='00:00' and convert(time(0),PrgTransaction.UpdateDate)<='06:59'" & _
                                                 "                then DATEADD(d,-1,convert(date,PrgTransaction.UpdateDate))" & _
                                                 "                else convert(date,PrgTransaction.UpdateDate) end) as LastLogDate" & _
                                                 " from PrgTransaction" & _
                                                 " where isnull(TruckID,'')='' and [From] = '" & INI.Status_ZF & "' and [To] = '" & INI.Status_OnTruck & "'")
        If Converts.ToStr(dt.Rows(0)("LastLogDate")) = "" Then
            Return SystemDate.Date
        Else
            Return dt.Rows(0)("LastLogDate")
        End If
    End Function

    Public Function SaveData(ByVal dtTrans As DataTable) As Boolean
        DataBase.BeginTrans()

        Try
            For Each drTrans As DataRow In dtTrans.Select("sta<>''")
                If DataBase.runSQL("update PrgTransaction set TruckID='" & Converts.ToStr(drTrans("TruckID")) & "' where ID=" & drTrans("ID") & "") = False Then GoTo SaveErr
            Next

            DataBase.CommitTrans()
            Return True

        Catch ex As Exception
            GoTo SaveErr
        End Try

SaveErr:
        DataBase.RollbackTrans()
        Return False
    End Function
End Class
