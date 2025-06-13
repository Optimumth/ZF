Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCMstQC
    Public Function GetData(chkSCheckNo As Boolean, sCheckNo As String, chkSFront As Boolean, chkSRear As Boolean) As DataTable

        Dim cond As String = String.Format("DelFlag=0 {0}", vbCrLf)
        If chkSCheckNo = True Then cond &= String.Format(" and CheckID=" & sCheckNo & " {0}", vbCrLf)
        If chkSFront = True And chkSRear = False Then
            cond &= String.Format(" and FrontFlag=1 {0}", vbCrLf)
        ElseIf chkSFront = False And chkSRear = True Then
            cond &= String.Format(" and RearFlag=1 {0}", vbCrLf)
        ElseIf chkSFront = True And chkSRear = True Then
            cond &= String.Format(" and (FrontFlag=1 or RearFlag=1) {0}", vbCrLf)
        End If

        Dim dt As DataTable = DataBase.DataSelect("MstQC" _
                                                  , cond _
                                                  , , , "MstQC.*,'' as sta")

        Return dt
    End Function

    Public Function SaveData(dt As DataTable) As Boolean
        Try
            For Each dr As DataRow In dt.Select("sta<>''")
                Select Case dr("sta")
                    Case "N"
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
                DataBase.DataInsertUpdate("MstQC", dr)
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
