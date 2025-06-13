Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCChangeStatus
    Public Function GetData(RackDTID As Integer) As DataTable
        Dim sql As String = String.Format( _
            "select Model,cModelType.Name as Type,Code,Remark,RackNo,RackID,'ZF' as RackStatus {0}" & _
            "from MstModel mModel {0}" & _
            "inner join MstRackHD mRackHD on mModel.ID=mRackHD.ModelID {0}" & _
            "inner join MstRackDT mRackDT on mRackHD.RackHeaderID=mRackDT.RackHeaderID {0}" & _
            "inner join CstModelType cModelType on mRackHD.Type=cModelType.ID {0}" & _
            "where mRackDT.ID = {1} And mRackDT.Replaced = 0 {0}" & _
            "union {0}" & _
            "select Model,cModelType.Name as Type,Code,Remark,RackNo,RackID {0}" & _
            "       ,case when [To]='On Truck' and DATEDIFF(HOUR,ScanDateTime,GetDate())>=5 then 'MB' else [To] end as RackStatus {0}" & _
            "from MstModel mModel {0}" & _
            "inner join MstRackHD mRackHD on mModel.ID=mRackHD.ModelID {0}" & _
            "inner join MstRackDT mRackDT on mRackHD.RackHeaderID=mRackDT.RackHeaderID {0}" & _
            "inner join CstModelType cModelType on mRackHD.Type=cModelType.ID {0}" & _
            "inner join PrgTransaction Trans on mRackDT.ID=Trans.RackDTID and Trans.Replaced=0 {0}" & _
            "inner join (select RackDTID,max(ID) as ID from PrgTransaction where Replaced=0 group by RackDTID) as MaxTrans on Trans.RackDTID=MaxTrans.RackDTID and Trans.ID=MaxTrans.ID {0}" & _
            "where mRackDT.ID={1} " _
            , vbCrLf, RackDTID)

        Dim dt As DataTable = DataBase.DataTable(sql)

        Return dt
    End Function

    Public Function Save(RackDTID As Integer, CurStatus As String, NewStatus As String) As Boolean
        Dim ScanType As Integer = SystemINI.eScanType.PC
        DataBase.BeginTrans()
        Try
            Dim dtRackDT As DataTable = DataBase.DataSelect("MstRackDT", "ID=" & RackDTID & " and Replaced=0")
            If dtRackDT.Rows.Count > 0 Then
                Dim drRackDT As DataRow = dtRackDT.Rows(0)
                drRackDT("Replaced") = 1
                If DataBase.DataUpdate("MstRackDT", drRackDT) = False Then GoTo SaveErr
            Else
                Dim dtOldTrans As DataTable = DataBase.DataSelect("PrgTransaction", "RackDTID=" & RackDTID & " and Replaced=0")
                For Each drOldTrans As DataRow In dtOldTrans.Select()
                    Dim sqlTrans As String = "update PrgTransaction set Replaced=1 where ID=" & drOldTrans("ID") & ""
                    If DataBase.runSQL(sqlTrans) = False Then GoTo SaveErr
                Next
            End If

            Dim sql As String = String.Format( _
                "insert into PrgTransaction(ScanType,RackDTID,[From],[To],StaffCode,ScanDateTime,UpdateUser,UpdateDate,Replaced) {0}" & _
                "select {1},{2},'{3}','{4}','{5}',getdate(),{6},getdate(),0 " _
                , vbCrLf, ScanType, RackDTID, CurStatus, NewStatus, LoginID, StaffID)
            If DataBase.runSQL(sql) = False Then GoTo SaveErr

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
