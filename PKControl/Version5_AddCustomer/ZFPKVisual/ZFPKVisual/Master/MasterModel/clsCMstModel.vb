Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCMstModel
    Public Function GetData(chkSModel As Boolean, sModel As String _
                            , chkSType As Boolean, iType As Integer) As DataTable

        Dim cond As String = "DelFlag=0"
        If chkSModel = True Then Converts.ToStringSQLCond(cond, "Model Like {0}", sModel)
        If chkSType = True Then
            Select Case CustomerCode
                Case "MB"
                    Select Case iType
                        Case SystemINI.ModelTypeMB.Front : Converts.ToStringSQLCond(cond, "FrontFlag=1")
                        Case SystemINI.ModelTypeMB.Rear : Converts.ToStringSQLCond(cond, "RearFlag=1")
                        Case SystemINI.ModelTypeMB.BPS : Converts.ToStringSQLCond(cond, "BPSFlag=1")
                    End Select
                Case "BMW"
                    Select Case iType
                        Case SystemINI.ModelTypeBMW.Front : Converts.ToStringSQLCond(cond, "FrontFlag=1")
                        Case SystemINI.ModelTypeBMW.Rear : Converts.ToStringSQLCond(cond, "RearFlag=1")
                        Case SystemINI.ModelTypeBMW.FrontRear : Converts.ToStringSQLCond(cond, "FrontRearFlag=1")
                        Case SystemINI.ModelTypeBMW.STB : Converts.ToStringSQLCond(cond, "STBFlag=1")
                        Case SystemINI.ModelTypeBMW.MBikeFront : Converts.ToStringSQLCond(cond, "MBikeFrontFlag=1")
                        Case SystemINI.ModelTypeBMW.MBikeRear : Converts.ToStringSQLCond(cond, "MBikeRearFlag=1")
                    End Select
            End Select
        End If

        Dim dt As DataTable = DataBase.DataSelect("MstModel" _
                                                  , cond _
                                                  , , , "MstModel.*,'' as sta")
        Return dt
    End Function

    Public Function SaveData(dt As DataTable) As Boolean
        Try
            Dim ID As Integer = Converts.ToInt_NullIsZero(DataBase.DataMaximum("MstModel", "ID"))
            For Each dr As DataRow In dt.Select("sta<>''")
                Select Case dr("sta")
                    Case "N"
                        ID += 1
                        dr("ID") = ID
                        dr("DelFlag") = 0
                        dr("CreateUser") = StaffID
                        dr("CreateDate") = SystemDate
                        dr("UpdateUser") = StaffID
                        dr("UpdateDate") = SystemDate
                    Case "U"
                        dr("UpdateUser") = StaffID
                        dr("UpdateDate") = SystemDate
                    Case "D"
                        dr("DelFlag") = 1
                End Select
                DataBase.DataInsertUpdate("MstModel", dr)
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
