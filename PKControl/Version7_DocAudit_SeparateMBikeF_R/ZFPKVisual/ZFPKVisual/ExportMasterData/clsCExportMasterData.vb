Imports OPE_Controls.OpeStyle

Public Class clsCExportMasterData
    Public Function GetMstItem() As DataTable
        'Dim sql As String = String.Format( _
        '    " select mRackDT.ID as RackDTID,RackID,Remark,Model,Code,RackNo {0}" & _
        '    " from MstModel mModel {0}" & _
        '    " inner join MstRackHD as mRackHD on mModel.ID=mRackHD.ModelID and mRackHD.DelFlag=0 {0}" & _
        '    " inner join MstRackDT as mRackDT on mRackHD.RackHeaderID=mRackDT.RackHeaderID and mRackDT.DelFlag=0 {0}" _
        '    , vbCrLf)
        'Dim dt As DataTable = DataBase.DataTable(sql)
        'Return dt
        Dim cls As New clsCRackStatus
        Dim dt As DataTable = cls.GetData(False, 0 _
                                           , False, 0 _
                                           , False, "" _
                                           , False, "" _
                                           , False, "" _
                                           , False)
        Return dt
    End Function

    Public Function GetMstModelDock() As DataTable
        Dim sql As String = String.Format( _
            " select MstModel.Model as ModelRack,ModelDock,AreaCode,CaliperFlag,Check1,Check2,Check3,Check4,Check5,Check6,Check7,Format1,Format2,Format3,Format4,Format5,Format6,Format7,MstModelDock.ID as ModelDockID {0}" & _
            " from MstModel {0}" & _
            " inner join MstModelDock on MstModel.ID=MstModelDock.ModelID and MstModelDock.DelFlag=0 {0}" & _
            " where MstModel.DelFlag=0 {0}" _
            , vbCrLf)
        Dim dt As DataTable = DataBase.DataTable(sql)
        Return dt
    End Function

    Public Function GetMstPart() As DataTable
        Dim sql As String = String.Format( _
            " select Variant,AreaID,PartTypeID,CaliperFlag,PartNo from MstPart where DelFlag=0 {0}" _
            , vbCrLf)
        Dim dt As DataTable = DataBase.DataTable(sql)
        Return dt
    End Function

    Public Function GetMstStaff() As DataTable
        Dim sql As String = String.Format( _
            " select StaffCode from MstStaff where DelFlag=0 {0}" _
            , vbCrLf)
        Dim dt As DataTable = DataBase.DataTable(sql)
        Return dt
    End Function

    Public Function GetMstQC() As DataTable
        Dim sql As String = String.Format( _
            " select CheckID,FormatID,Desc1,Desc2,Desc3 " & _
            "        ,FrontFlag, RearFlag {0}" & _
            " from MstQC where DelFlag=0 {0}" _
            , vbCrLf)
        Dim dt As DataTable = DataBase.DataTable(sql)
        Return dt
    End Function
End Class
