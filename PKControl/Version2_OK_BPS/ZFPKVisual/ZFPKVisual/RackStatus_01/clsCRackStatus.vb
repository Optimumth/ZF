Imports OPE_Controls.OpeStyle

Public Class clsCRackStatus
    Public Function GetData(fType As Boolean, Type As Integer _
                            , fModel As Boolean, Model As String _
                            , fCode As Boolean, Code As String _
                            , fRemark As Boolean, Remark As String _
                            , fRackStatus As Boolean, RackStatus As String) As DataTable
        Dim cond1 As String = "where mRackHD.DelFlag = 0 And mRackDT.DelFlag = 0 And mRackDT.Replaced = 0"
        Dim cond2 As String = "where Trans.Replaced=0"
        If fType = True Then
            Converts.ToStringSQLCond(cond1, "mRackHD.Type = {0}", Type)
            Converts.ToStringSQLCond(cond2, "mRackHD.Type = {0}", Type)
        End If
        If fModel = True Then
            Converts.ToStringSQLCond(cond1, "mModel.Model like {0}", Model)
            Converts.ToStringSQLCond(cond2, "mModel.Model like {0}", Model)
        End If
        If fCode = True Then
            Converts.ToStringSQLCond(cond1, "mRackHD.Code like {0}", Code)
            Converts.ToStringSQLCond(cond2, "mRackHD.Code like {0}", Code)
        End If
        If fRemark = True Then
            Converts.ToStringSQLCond(cond1, "mRackHD.Remark like {0}", Remark)
            Converts.ToStringSQLCond(cond2, "mRackHD.Remark like {0}", Remark)
        End If
        If fRackStatus = True Then
            Converts.ToStringSQLCond(cond1, "'ZF' like {0}", RackStatus)
            Converts.ToStringSQLCond(cond2, "case when [To]='On Truck' and DATEDIFF(HOUR,ScanDateTime,GetDate())>=5 then 'MB' else [To] end like {0}", RackStatus)
        End If


        Dim sql As String = String.Format( _
            "select '1900-01-01' as ScanDateTime,Model,Code,RackNo,'ZF' as RackStatus,ColorA,ColorR,ColorG,ColorB,mRackDT.ID as RackDTID,RackID,Remark,Type {0}" & _
            "from MstModel mModel  {0}" & _
            "inner join MstRackHD as mRackHD on mModel.ID=mRackHD.ModelID  {0}" & _
            "inner join MstRackDT as mRackDT on mRackHD.RackHeaderID=mRackDT.RackHeaderID  {0}" & _
            "{1}{0}" & _
            "union {0}" & _
            "select ScanDateTime,Model,Code,RackNo {0}" & _
            "       ,case when [To]='On Truck' and DATEDIFF(HOUR,ScanDateTime,GetDate())>=5 then 'MB' else [To] end as RackStatus {0}" & _
            "       ,ColorA,ColorR,ColorG,ColorB,mRackDT.ID as RackDTID,RackID,Remark,Type {0}" & _
            "from PrgTransaction Trans {0}" & _
            "inner join MstRackDT mRackDT on Trans.RackDTID=mRackDT.ID {0}" & _
            "inner join MstRackHD mRackHD on mRackHD.RackHeaderID=mRackDT.RackHeaderID {0}" & _
            "inner join MstModel mModel on mRackHD.ModelID=mModel.ID {0}" & _
            "{2}{0}" & _
            " order by Type,Model,Code,Remark,RackNo " _
            , vbCrLf, cond1, cond2)

        Dim dt As DataTable = DataBase.DataTable(sql)

        Return dt
    End Function
End Class
