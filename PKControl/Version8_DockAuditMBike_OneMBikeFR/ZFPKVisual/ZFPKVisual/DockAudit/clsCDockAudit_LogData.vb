Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCDockAudit_LogData
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
            " from PrgDockAudit {0}" & _
            " {1}" & _
            " order by case when convert(time(0),UpdateDate)>='00:00' and convert(time(0),UpdateDate)<='06:59' {0}" & _
            "                then DATEADD(d,-1,convert(date,UpdateDate)) {0}" & _
            "                else convert(date,UpdateDate) end {0}" & _
            "", vbCrLf, cond)

        Dim dt As DataTable = DataBase.DataTable(sql)
        Return dt
    End Function
    Public Function GetDailyLog(LogDate As Date) As DataTable
        Dim cond As String = "where 1=1"
        Dim sql As String = String.Format( _
            "select MstRackDT.RackID, 'BMW' as  Customer, MstModelDock.ModelDock,'Axle' as AxleShock, PrgDockAudit.Varian, isnull(MstPart.PartNo,'') as PartNo, PrgDockAudit.Lot, left(Barcode,2) as BarcodeType {0}" & _
            "       , Side {0}" & _
            "       , AxleNo {0}" & _
            "       ,'-' as ShockNo {0}" & _
            "       ,case when isnull(Check3_Caliper,'')='' then '-' else Check3_Caliper end as Caliper {0}" & _
            "       ,'-' as RandomShockNo {0}" & _
            "       ,case when PrgDockAudit.Check1=-1 then '-' when PrgDockAudit.Check1=0 then 'OK' else 'NG' end as QC1 {0}" & _
            "       ,case when PrgDockAudit.Check2=-1 then '-' when PrgDockAudit.Check2=0 then 'OK' else 'NG' end as QC2 {0}" & _
            "       ,case when PrgDockAudit.Check3=-1 then '-' when PrgDockAudit.Check3=0 then 'OK' else 'NG' end as QC3 {0}" & _
            "       ,case when PrgDockAudit.Check4=-1 then '-' when PrgDockAudit.Check4=0 then 'OK' else 'NG' end as QC4 {0}" & _
            "       ,case when PrgDockAudit.Check5=-1 then '-' when PrgDockAudit.Check5=0 then 'OK' else 'NG' end as QC5 {0}" & _
            "       ,case when PrgDockAudit.Check6=-1 then '-' when PrgDockAudit.Check6=0 then 'OK' else 'NG' end as QC6 {0}" & _
            "       ,case when PrgDockAudit.Check7=-1 then '-' when PrgDockAudit.Check7=0 then 'OK' else 'NG' end as QC7 {0}" & _
            "       ,convert(date,PrgDockAudit.ScanDateTime) as ScanDate,convert(varchar(5),convert(time(0),PrgDockAudit.ScanDateTime)) as ScanTime {0}" & _
            "       ,convert(date,PrgDockAudit.UpdateDate) as UploadDate,convert(varchar(5),convert(time(0),PrgDockAudit.UpdateDate)) as UploadTime {0}" & _
            "       ,isnull(ScanStaff.GivenName + '  ' + ScanStaff.SurName,'') as ScanUser {0}" & _
            "       ,UploadStaff.GivenName + '  ' + UploadStaff.SurName as UploadUser {0}" & _
            "from PrgDockAudit {0}" & _
            "inner join MstRackDT on PrgDockAudit.RackDTID=MstRackDT.ID {0}" & _
            "inner join MstModelDock on PrgDockAudit.ModelDockID=MstModelDock.ID {0}" & _
            "inner join MstStaff ScanStaff on PrgDockAudit.StaffCode=ScanStaff.StaffCode {0}" & _
            "inner join MstStaff UploadStaff on PrgDockAudit.UpdateUser = UploadStaff.StaffID {0}" & _
            "left join MstPart on PrgDockAudit.Varian=MstPart.Variant and PrgDockAudit.AreaID=MstPart.AreaID and PrgDockAudit.PartTypeID=MstPart.PartTypeID {0}" & _
            "where AxleShock = 1 {0}" & _
            "      and case when convert(time(0),PrgDockAudit.UpdateDate)>='00:00' and convert(time(0),PrgDockAudit.UpdateDate)<='06:59' {0}" & _
            "           then DATEADD(d,-1,convert(date,PrgDockAudit.UpdateDate)) {0}" & _
            "           else convert(date,PrgDockAudit.UpdateDate) end='" & Format(LogDate, "yyyy-MM-dd") & "' {0}" & _
            "union {0}" & _
            "select MstRackDT.RackID, 'BMW' as  Customer, MstModelDock.ModelDock,'Shock' as AxleShock, PrgDockAudit.Varian, isnull(MstPart.PartNo,'') as PartNo, PrgDockAudit.Lot, left(PrgDockAudit.Barcode,2) as BarcodeType {0}" & _
            "       ,Side {0}" & _
            "       , '-' as AxleNo {0}" & _
            "       , AxleNo as ShockNo {0}" & _
            "       ,'-' as Caliper {0}" & _
            "       ,PrgDockAuditShock.Barcode as RandomShockNo {0}" & _
            "       ,case when PrgDockAudit.Check1=-1 then '-' when PrgDockAudit.Check1=0 then 'OK' else 'NG' end as QC1 {0}" & _
            "       ,case when PrgDockAudit.Check2=-1 then '-' when PrgDockAudit.Check2=0 then 'OK' else 'NG' end as QC2 {0}" & _
            "       ,case when PrgDockAudit.Check3=-1 then '-' when PrgDockAudit.Check3=0 then 'OK' else 'NG' end as QC3 {0}" & _
            "       ,case when PrgDockAudit.Check4=-1 then '-' when PrgDockAudit.Check4=0 then 'OK' else 'NG' end as QC4 {0}" & _
            "       ,case when PrgDockAudit.Check5=-1 then '-' when PrgDockAudit.Check5=0 then 'OK' else 'NG' end as QC5 {0}" & _
            "       ,case when PrgDockAudit.Check6=-1 then '-' when PrgDockAudit.Check6=0 then 'OK' else 'NG' end as QC6 {0}" & _
            "       ,case when PrgDockAudit.Check7=-1 then '-' when PrgDockAudit.Check7=0 then 'OK' else 'NG' end as QC7 {0}" & _
            "       ,convert(date,PrgDockAudit.ScanDateTime) as ScanDate,convert(varchar(5),convert(time(0),PrgDockAudit.ScanDateTime)) as ScanTime {0}" & _
            "       ,convert(date,PrgDockAudit.UpdateDate) as UploadDate,convert(varchar(5),convert(time(0),PrgDockAudit.UpdateDate)) as UploadTime {0}" & _
            "       ,isnull(ScanStaff.GivenName + '  ' + ScanStaff.SurName,'') as ScanUser {0}" & _
            "       ,UploadStaff.GivenName + '  ' + UploadStaff.SurName as UploadUser {0}" & _
            "from PrgDockAudit  {0}" & _
            "inner join MstRackDT on PrgDockAudit.RackDTID=MstRackDT.ID {0}" & _
            "inner join MstModelDock on PrgDockAudit.ModelDockID=MstModelDock.ID {0}" & _
            "inner join MstStaff ScanStaff on PrgDockAudit.StaffCode=ScanStaff.StaffCode {0}" & _
            "inner join MstStaff UploadStaff on PrgDockAudit.UpdateUser = UploadStaff.StaffID {0}" & _
            "left join MstPart on PrgDockAudit.Varian=MstPart.Variant and PrgDockAudit.AreaID=MstPart.AreaID and PrgDockAudit.PartTypeID=MstPart.PartTypeID {0}" & _
            "inner join (select Main.BarcodeHD, left(Main.Barcode,len(Main.Barcode)-1) as Barcode {0}" & _
            "from (select distinct T2.BarcodeHD ,(select T1.Barcode + '-' as [text()] {0}" & _
            "                                     from (select BarcodeHD,SUBSTRING(Barcode,13,3) as Barcode from PrgDockAuditShock) as T1 {0}" & _
            "                                     where T1.BarcodeHD=T2.BarcodeHD {0}" & _
            "                                     order by T1.BarcodeHD {0}" & _
            "                                     for xml path('')) Barcode {0}" & _
            "      from PrgDockAuditShock T2) [Main]{0}" & _
            "      ) as PrgDockAuditShock on PrgDockAudit.Barcode=PrgDockAuditShock.BarcodeHD {0}" & _
            "where AxleShock=2 {0}" & _
            "      and case when convert(time(0),PrgDockAudit.UpdateDate)>='00:00' and convert(time(0),PrgDockAudit.UpdateDate)<='06:59' {0}" & _
            "           then DATEADD(d,-1,convert(date,PrgDockAudit.UpdateDate)) {0}" & _
            "           else convert(date,PrgDockAudit.UpdateDate) end='" & Format(LogDate, "yyyy-MM-dd") & "' {0}" & _
            "", vbCrLf, cond)

        Dim dt As DataTable = DataBase.DataTable(sql)
        Return dt
    End Function
End Class
