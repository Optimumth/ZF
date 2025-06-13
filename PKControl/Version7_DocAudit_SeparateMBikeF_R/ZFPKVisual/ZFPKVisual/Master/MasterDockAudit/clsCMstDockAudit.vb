Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCMstDockAudit
    Public Function GetData(chkSModel As Boolean, iModelID As Integer _
                            , chkSModelDock As Boolean, sModelDock As String _
                            , chkSAreaCode As Boolean, sAreaCode As String _
                            , chkSCaliper As Boolean, iCaliperFlag As Integer) As DataTable

        Dim cond As String = "MstModelDock.DelFlag=0"
        If chkSModel = True Then cond &= String.Format("and ModelID = {0}", iModelID)
        If chkSModelDock = True Then Converts.ToStringSQLCond(cond, "ModelDock Like {0}", sModelDock)
        If chkSAreaCode = True Then Converts.ToStringSQLCond(cond, "AreaCode Like {0}", sAreaCode)
        If chkSCaliper = True Then Converts.ToStringSQLCond(cond, "CaliperFlag = {0}", iCaliperFlag)

        Dim dt As DataTable = DataBase.DataSelect("MstModelDock" _
                                                  , cond _
                                                  , , , "MstModelDock.*" & _
                                                        ",case when MstModel.Model=MstModel.ModelContainer then MstModel.Model else MstModel.Model + ' (' + MstModel.ModelContainer + ')' end as Model" & _
                                                        ",'' as sta" _
                                                  , , " inner join MstModel on MstModelDock.ModelID=MstModel.ID")

        Return dt
    End Function

    Public Function SaveData(dt As DataTable) As Boolean
        Try
            Dim ID As Integer = Converts.ToInt_NullIsZero(DataBase.DataMaximum("MstModelDock", "ID"))
            For Each dr As DataRow In dt.Select("sta<>''")
                Select Case dr("sta")
                    Case "N"
                        Dim dtDeleted As DataTable = DataBase.DataSelect("MstModelDock", "DelFlag=1 and ModelID=" & dr("ModelID") & " and ModelDock='" & dr("ModelDock") & "' and AreaCode='" & dr("AreaCode") & "'")
                        If dtDeleted.Rows.Count = 0 Then
                            ID += 1
                            dr("ID") = ID
                            dr("DelFlag") = 0
                            dr("CreateUser") = StaffID
                            dr("CreateDate") = SystemDate
                            dr("UpdateUser") = StaffID
                            dr("UpdateDate") = SystemDate
                        Else
                            dr("ID") = dtDeleted.Rows(0)("ID")
                            dr("DelFlag") = 0
                            dr("CreateUser") = StaffID
                            dr("CreateDate") = SystemDate
                            dr("UpdateUser") = StaffID
                            dr("UpdateDate") = SystemDate
                        End If
                    Case "U"
                        dr("UpdateUser") = StaffID
                        dr("UpdateDate") = SystemDate
                    Case "D"
                        dr("DelFlag") = 1
                End Select
                DataBase.DataInsertUpdate("MstModelDock", dr)
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
