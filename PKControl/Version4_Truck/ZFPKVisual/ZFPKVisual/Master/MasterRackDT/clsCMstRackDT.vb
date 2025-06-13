Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCMstRackDT
    Public Function GetHD(RackHDID As Integer) As DataTable
        Dim dt As DataTable = DataBase.DataSelect("MstRackHD", "RackHeaderID=" & RackHDID & "" _
                                                  , , , "MstRackHD.*,CstModelType.Name as TypeName,MstModel.Model" _
                                                  , , "inner join CstModelType on MstRackHD.Type=CstModelType.ID " & _
                                                      "inner join MstModel on MstRackHD.ModelID = MstModel.ID")

        Return dt
    End Function
    Public Function GetDT(RackHDID As Integer) As DataTable
        Dim dt As DataTable = DataBase.DataSelect("MstRackDT" _
                                                  , "MstRackDT.RackHeaderID=" & RackHDID & " and MstRackDT.DelFlag=0" _
                                                  , , , "MstRackDT.*,concat(MstRackHD.Code,MstRackDT.RackNo) as Show,'' as sta" _
                                                  , , "inner join MstRackHD on MstRackDT.RackHeaderID=MstRackHD.RackHeaderID")
        Return dt
    End Function
    Public Function SaveData(drHD As DataRow, dtDT As DataTable) As Boolean
        DataBase.BeginTrans()

        Try
            Dim RackDetailID As Integer = Converts.ToInt_NullIsZero(DataBase.DataMaximum("MstRackDT", "ID"))

            drHD("UpdateUser") = StaffID
            drHD("UpdateDate") = SystemDate
            If DataBase.DataUpdate("MstRackHD", drHD) = False Then GoTo SaveErr

            For Each drDT As DataRow In dtDT.Select("sta<>''")
                Select Case drDT("sta")
                    Case "N"
                        RackDetailID += 1
                        drDT("ID") = RackDetailID
                        drDT("DelFlag") = 0
                        drDT("CreateUser") = StaffID
                        drDT("CreateDate") = SystemDate
                        drDT("UpdateUser") = StaffID
                        drDT("UpdateDate") = SystemDate
                    Case "U"
                        drDT("UpdateUser") = StaffID
                        drDT("UpdateDate") = SystemDate
                    Case "D"
                        drDT("DelFlag") = 1
                        drDT("UpdateUser") = StaffID
                        drDT("UpdateDate") = SystemDate
                End Select
                If DataBase.DataInsertUpdate("MstRackDT", drDT) = False Then GoTo SaveErr
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
