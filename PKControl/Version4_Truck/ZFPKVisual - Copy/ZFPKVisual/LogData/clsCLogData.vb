Imports OPE_Controls.OpeStyle

Public Class clsCLogData
    Public Function GetData(chkLogDate As Boolean, Date1 As Date, Date2 As Date) As DataTable
        Dim cond As String = "where 1=1"
        If chkLogDate = True Then
            Converts.ToStringAnd(cond, "({0} And {1})", _
                                  Converts.ToStringSQLDateDiff(Date1, "case when convert(time(0),UpdateDate)>='00:00' and convert(time(0),UpdateDate)<='06:59' then DATEADD(d,-1,convert(date,UpdateDate)) else convert(date,UpdateDate) end", 0), _
                                  Converts.ToStringSQLDateDiff(Date2, "case when convert(time(0),UpdateDate)>='00:00' and convert(time(0),UpdateDate)<='06:59' then DATEADD(d,-1,convert(date,UpdateDate)) else convert(date,UpdateDate) end", 0, , OPE_Controls.OperationSymbol.IsLessThanOrEqualTo))
        End If
        Dim sql As String = String.Format( _
            "select distinct 1 as chk {0}" & _
            "                ,case when convert(time(0),UpdateDate)>='00:00' and convert(time(0),UpdateDate)<='06:59' {0}" & _
            "                then DATEADD(d,-1,convert(date,UpdateDate)) {0}" & _
            "                else convert(date,UpdateDate) end as LogDate {0}" & _
            " from PrgTransaction {0}" & _
            " {1}" & _
            " order by case when convert(time(0),UpdateDate)>='00:00' and convert(time(0),UpdateDate)<='06:59' {0}" & _
            "                then DATEADD(d,-1,convert(date,UpdateDate)) {0}" & _
            "                else convert(date,UpdateDate) end {0}" & _
            "", vbCrLf, cond)

        Dim dt As DataTable = DataBase.DataTable(sql)
        Return dt
    End Function
    Public Function GetDailyLog(LogDate As Date) As DataTable
        Dim sql As String = String.Format( _
            "select RackID,Model,RackNo,CONCAT(Code,RackNo) as Show,mRackHD.Remark,[To] as RackStatus {0}" & _
            "       ,convert(date,ScanDateTime) as ScanDate,convert(varchar(5),convert(time(0),ScanDateTime)) as ScanTime {0}" & _
            "       ,convert(date,Trans.UpdateDate) as UploadDate,convert(varchar(5),convert(time(0),Trans.UpdateDate)) as UploadTime {0}" & _
            "       ,isnull(ScanStaff.GivenName + '  ' + ScanStaff.SurName,'') as ScanUser {0}" & _
            "       ,UploadStaff.GivenName + '  ' + UploadStaff.SurName as UploadUser {0}" & _
            "       ,Case when ActiveFlag=1 then 'Active' else 'Inactive' end as ActiveStatus {0}" & _
            "       ,LossFlag,LossDate,LossRemark,License,PrgTruck.CreateDate as ShipDate {0}" & _
            "from PrgTransaction Trans {0}" & _
            "inner join MstRackDT mRackDT on Trans.RackDTID=mRackDT.ID {0}" & _
            "inner join MstRackHD mRackHD on mRackDT.RackHeaderID=mRackHD.RackHeaderID {0}" & _
            "inner join MstModel mModel on mRackHD.ModelID=mModel.ID {0}" & _
            "inner join MstStaff ScanStaff on Trans.StaffCode=ScanStaff.StaffCode {0}" & _
            "inner join MstStaff UploadStaff on Trans.UpdateUser = UploadStaff.StaffID {0}" & _
            "left join PrgTruck on Trans.TruckID=PrgTruck.TruckID {0}" & _
            "where case when convert(time(0),Trans.UpdateDate)>='00:00' and convert(time(0),Trans.UpdateDate)<='06:59' {0}" & _
            "           then DATEADD(d,-1,convert(date,Trans.UpdateDate)) {0}" & _
            "           else convert(date,Trans.UpdateDate) end='" & Format(LogDate, "yyyy-MM-dd") & "' {0}" & _
            "order by Trans.ID {0}" & _
            "", vbCrLf)

        Dim dt As DataTable = DataBase.DataTable(sql)
        Return dt

    End Function

End Class
