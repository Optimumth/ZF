Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCMstPart
    Public Function GetData(chkVariant As Boolean, sVariant As String _
                            , chkArea As Boolean, iAreaID As Integer _
                            , chkPartType As Boolean, iPartType As Integer _
                            , chkPartNo As Boolean, sPartNo As String _
                            , chkSCaliper As Boolean, iCaliperFlag As Integer) As DataTable

        Dim cond As String = "MstPart.DelFlag=0"
        If chkVariant = True Then Converts.ToStringSQLCond(cond, "Variant Like {0}", sVariant)
        If chkArea = True Then cond &= String.Format("and AreaID = {0}", iAreaID)
        If chkPartType = True Then cond &= String.Format("and PartTypeID = {0}", iPartType)
        If chkPartNo = True Then Converts.ToStringSQLCond(cond, "PartNo Like {0}", sPartNo)
        If chkSCaliper = True Then Converts.ToStringSQLCond(cond, "CaliperFlag = {0}", iCaliperFlag)

        Dim dt As DataTable = DataBase.DataSelect("MstPart" _
                                                  , cond _
                                                  , , , "MstPart.*" & _
                                                        ",CstArea.AreaName" & _
                                                        ",CstPartType.PartTypeName" & _
                                                        ",'' as sta" _
                                                  , , " inner join CstArea on MstPart.AreaID=CstArea.ID" & _
                                                      " inner join CstPartType on MstPart.PartTypeID=CstPartType.ID")

        Return dt
    End Function

    Public Function SaveData(dt As DataTable) As Boolean
        Try
            Dim ID As Integer = Converts.ToInt_NullIsZero(DataBase.DataMaximum("MstPart", "ID"))
            For Each dr As DataRow In dt.Select("sta<>''")
                Select Case dr("sta")
                    Case "N"
                        Dim dtDeleted As DataTable = DataBase.DataSelect("MstPart" _
                                                                         , "DelFlag=1 and Variant='" & dr("Variant") & "' and AreaID=" & dr("AreaID") & " and PartTypeID=" & dr("PartTypeID") & " and PartNo='" & dr("PartNo") & "'" _
                                                                         )
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
                DataBase.DataInsertUpdate("MstPart", dr)
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
