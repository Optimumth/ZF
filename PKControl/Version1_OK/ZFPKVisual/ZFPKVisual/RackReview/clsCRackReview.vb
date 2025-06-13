Imports OPE_Controls.OpeStyle

Public Class clsCRackReview
    Public Function GetData(fType As Boolean, Type As Integer _
                            , fModel As Boolean, Model As Integer _
                            , fCode As Boolean, Code As String _
                            , fRemark As Boolean, Remark As String) As DataTable

        Dim cond As String = "where mRackHD.DelFlag = 0 And mRackDT.DelFlag = 0"
        If fType = True Then
            Converts.ToStringSQLCond(cond, "mRackHD.Type = {0}", Type)
        End If
        If fModel = True Then
            Converts.ToStringSQLCond(cond, "mModel.ID = {0}", Model)
        End If
        If fCode = True Then
            Converts.ToStringSQLCond(cond, "mRackHD.Code like {0}", Code)
        End If
        If fRemark = True Then
            Converts.ToStringSQLCond(cond, "mRackHD.Remark like {0}", Remark)
        End If

        Dim sql As String = String.Format( _
            "select Name as TypeName,Model,Code,Remark,RackNo,RackID,Concat(Code,RackNo) as Show,ActiveFlag,LossFlag,LossDate,LossRemark {0}" & _
            "from MstModel mModel {0}" & _
            "inner join MstRackHD mRackHD on mModel.ID=mRackHD.ModelID  {0}" & _
            "inner join MstRackDT mRackDT on mRackHD.RackHeaderID=mRackDT.RackHeaderID {0}" & _
            "inner join CstModelType cType on mRackHD.Type=cType.ID {0}" & _
            "{1}" & _
            "order by Name,Model,Code,Remark,RackNo {0}" _
            , vbCrLf, cond)
        Dim dt As DataTable = DataBase.DataTable(sql)
        Return dt
    End Function
End Class
