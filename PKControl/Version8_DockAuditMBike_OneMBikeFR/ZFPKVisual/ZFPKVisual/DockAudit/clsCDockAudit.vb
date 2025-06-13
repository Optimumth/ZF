Imports OPE_Controls.OpeStyle

Public Class clsCDockAudit
    Public Enum eArea
        Front = 1
        Rear = 2
    End Enum
    Public Function getDockAudit(chkAuditDate As Boolean, dtpAuditDate1 As Date, dtpAuditDate2 As Date _
                                 , chkArea As Boolean, iCstAreaID As Integer _
                                 , chkModelDock As Boolean, sModelDock As String _
                                 , chkVariant As Boolean, sVariant As String _
                                 , chkLot As Boolean, sLot As String _
                                 , chkAxleShock As Boolean, iAxleShockValue As Integer _
                                 ) As DataTable
        Dim cond As String = String.Format("where prgDockAudit.CompleteFlag=1 {0}", vbCrLf)
        If chkAuditDate = True Then
            Converts.ToStringAnd(cond, "({0} And {1})", _
                                      Converts.ToStringSQLDateDiff(dtpAuditDate1, "case when convert(time(0),ScanDateTime)>='00:00' and convert(time(0),ScanDateTime)<='06:59' then DATEADD(d,-1,convert(date,ScanDateTime)) else convert(date,ScanDateTime) end", 0), _
                                      Converts.ToStringSQLDateDiff(dtpAuditDate2, "case when convert(time(0),ScanDateTime)>='00:00' and convert(time(0),ScanDateTime)<='06:59' then DATEADD(d,-1,convert(date,ScanDateTime)) else convert(date,ScanDateTime) end", 0, , OPE_Controls.OperationSymbol.IsLessThanOrEqualTo))
        End If
        If chkArea = True Then
            cond &= String.Format(" and MstModelDock.AreaCode = '" & IIf(iCstAreaID = eArea.Front, "F", "R") & "' {0}", vbCrLf)
        End If
        If chkModelDock = True Then
            cond &= String.Format(" and MstModelDock.ModelDock = '" & sModelDock & "' {0}", vbCrLf)
        End If
        If chkVariant = True Then
            cond &= String.Format(" and PrgDockAudit.Variant = '" & sVariant & "' {0}", vbCrLf)
        End If
        If chkLot = True Then
            cond &= String.Format(" and PrgDockAudit.Lot like '%" & sLot & "%' {0}", vbCrLf)
        End If
        If chkAxleShock = True Then
            cond &= String.Format(" and CstAxleShock.AxleShockValue = " & iAxleShockValue & " {0}", vbCrLf)
        End If
        Dim sql As String = String.Format( _
            "select max(DATEADD(dd, 0, DATEDIFF(dd, 0, ScanDateTime))) as AuditDate {0}" & _
            "       ,min(PrgDockAudit.Side) as MinSide {0}" & _
            "       ,min(PrgDockAudit.Barcode) as MinBarcode {0}" & _
            "       ,min(M.RackID) as RackID {0}" & _
            "       ,max(PrgDockAudit.CorrectedFlag) as CorrectedFlag {0}" & _
            "       ,MstModelDock.AreaCode as Area {0}" & _
            "       ,MstModelDock.ModelDock, PrgDockAudit.ModelDockID {0}" & _
            "       ,PrgDockAudit.Varian {0}" & _
            "       ,PrgDockAudit.Lot {0}" & _
            "       ,PrgDockAudit.AxleShock, CstAxleShock.AxleShockValue, CstAxleShock.AxleShockName {0}" & _
            "       ,MstPart.PartNo {0}" & _
            "from PrgDockAudit {0}" & _
            "inner join MstModelDock on PrgDockAudit.ModelDockID = MstModelDock.ID {0}" & _
            "inner join CstAxleShock on PrgDockAudit.AxleShock=CstAxleShock.AxleShockValue {0}" & _
            "inner join CstArea on MstModelDock.AreaCode=CstArea.AreaCode {0}" & _
            "inner join MstRackDT on PrgDockAudit.RackDTID=MstRackDT.ID {0}" & _
            "inner join (select *, case when Type<>3 then 1 else 2 end as PartTypeID from MstRackHD) as MstRackHD on MstRackDT.RackHeaderID=MstRackHD.RackHeaderID  {0}" & _
            "left join MstPart on PrgDockAudit.Varian=MstPart.Variant and CstArea.ID=MstPart.AreaID and MstRackHD.PartTypeID=MstPart.PartTypeID {0}" & _
            "inner join (select Main.ModelDockID, Main.Varian, Main.Lot, Main.AxleShock, left(Main.RackID,Len(Main.RackID)-1) as RackID {0}" & _
            "            from (select distinct M2.ModelDockID, M2.Varian, M2.Lot, M2.AxleShock{0}" & _
            "                         , (select M1.RackID + ',' as [text()]{0}" & _
            "                            from (select distinct ModelDockID,Varian,Lot,AxleShock,RackID{0}" & _
            "                                  from MstRackDT{0}" & _
            "                                  inner join PrgDockAudit on MstRackDT.ID=PrgDockAudit.RackDTID) as M1{0}" & _
            "                            where M1.ModelDockID=M2.ModelDockID and M1.Varian=M2.Varian and M1.Lot=M2.Lot and M1.AxleShock=M2.AxleShock{0}" & _
            "                            order by M1.RackID{0}" & _
            "                            for xml path('')) RackID{0}" & _
            "                  from PrgDockAudit M2) [Main] {0}" & _
            "            ) as M on PrgDockAudit.ModelDockID=M.ModelDockID and PrgDockAudit.Varian=M.Varian and PrgDockAudit.Lot=M.Lot and PrgDockAudit.AxleShock=M.AxleShock{0}" & _
            "{1}" & _
            "group by CstAxleShock.AxleShockValue, MstModelDock.AreaCode, MstModelDock.ModelDock, PrgDockAudit.ModelDockID, PrgDockAudit.Varian, PrgDockAudit.Lot, PrgDockAudit.AxleShock,  CstAxleShock.AxleShockName,MstPart.PartNo {0}" & _
            "order by max(DATEADD(dd, 0, DATEDIFF(dd, 0, ScanDateTime))), CstAxleShock.AxleShockValue, MstModelDock.AreaCode, MstModelDock.ModelDock, PrgDockAudit.Varian, PrgDockAudit.Lot, PrgDockAudit.AxleShock, CstAxleShock.AxleShockName,MstPart.PartNo {0}" & _
            "", vbCrLf, cond)

        Dim dt As DataTable = DataBase.DataTable(sql)
        Return dt
    End Function
End Class
