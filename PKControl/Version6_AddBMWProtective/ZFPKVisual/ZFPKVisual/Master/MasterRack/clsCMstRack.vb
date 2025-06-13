Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCMstRack
    Public Function GetData(chkSType As Boolean, iType As Integer _
                            , chkSModel As Boolean, sModel As Integer _
                            , chkSCode As Boolean, sCode As String _
                            , chkSRemark As Boolean, sRemark As String _
                            ) As DataTable

        Dim cond As String = "MstRackHD.DelFlag=0"
        If chkSType = True Then
            Converts.ToStringSQLCond(cond, "MstRackHD.Type = {0}", iType)
        End If
        If chkSModel = True Then Converts.ToStringSQLCond(cond, "MstModel.ID = {0}", sModel)
        If chkSCode = True Then Converts.ToStringSQLCond(cond, "Code Like {0}", sCode)
        If chkSRemark = True Then Converts.ToStringSQLCond(cond, "Remark Like {0}", sRemark)

        Dim dt As DataTable = Nothing
        If CustomerCode = "MB" Then
            Dim iFront As Integer = SystemINI.ModelTypeMB.Front
            Dim iRear As Integer = SystemINI.ModelTypeMB.Rear
            Dim iBPS As Integer = SystemINI.ModelTypeMB.BPS

            dt = DataBase.DataSelect("MstRackHD" _
                                                      , cond _
                                                      , , , "MstRackHD.*" & _
                                                            ",MstModel.Model" & _
                                                            ",case when Type = " & iFront & " then '" & INI.sFront & "'" & _
                                                            "      when Type = " & iRear & " then '" & INI.sRear & "'" & _
                                                            "      when Type = " & iBPS & " then '" & INI.sBPS & "' end as TypeName" & _
                                                            ",0 as DetailFlag" & _
                                                            ",'' as sta" _
                                                      , , "inner join MstModel on MstRackHD.ModelID=MstModel.ID" _
                                                      , "Model,Code,InitialNo")
        Else
            Dim iFront As Integer = SystemINI.ModelTypeBMW.Front
            Dim iRear As Integer = SystemINI.ModelTypeBMW.Rear
            Dim iFrontRear As Integer = SystemINI.ModelTypeBMW.FrontRear
            Dim iSTB As Integer = SystemINI.ModelTypeBMW.STB
            Dim iMBikeFront As Integer = SystemINI.ModelTypeBMW.MBikeFront
            Dim iMBikeRear As Integer = SystemINI.ModelTypeBMW.MBikeRear
            Dim iPTC As Integer = SystemINI.ModelTypeBMW.PTC


            dt = DataBase.DataSelect("MstRackHD" _
                                                      , cond _
                                                      , , , "MstRackHD.*" & _
                                                            ",case when MstModel.Model=MstModel.ModelContainer then MstModel.Model else MstModel.Model + ' (' + MstModel.ModelContainer + ')' end as Model" & _
                                                            ",case when Type = " & iFront & " then '" & INI.sFront & "'" & _
                                                            "      when Type = " & iRear & " then '" & INI.sRear & "'" & _
                                                            "      when Type = " & iFrontRear & " then '" & INI.sFrontRear & "'" & _
                                                            "      when Type = " & iSTB & " then '" & INI.sSTB & "'" & _
                                                            "      when Type = " & iMBikeFront & " then '" & INI.sMBikeFront & "'" & _
                                                            "      when Type = " & iMBikeRear & " then '" & INI.sMBikeRear & "'" & _
                                                            "      when Type = " & iPTC & " then '" & INI.sPTC & "' end as TypeName" & _
                                                            ",0 as DetailFlag" & _
                                                            ",'' as sta" _
                                                      , , "inner join MstModel on MstRackHD.ModelID=MstModel.ID" _
                                                      , "Model,Code,InitialNo")
        End If
        

        Dim dtRackDT As DataTable = DataBase.DataSelect("MstRackDT", "DelFlag=0", , , "distinct RackHeaderID")
        For Each drRackDT As DataRow In dtRackDT.Select()
            For Each drRackHD As DataRow In dt.Select("RackHeaderID=" & drRackDT("RackHeaderID") & "")
                drRackHD("DetailFlag") = 1
            Next
        Next

        Return dt
    End Function

    Public Function SaveData(dt As DataTable) As DataTable
        DataBase.BeginTrans()

        Try
            Dim RackHeaderID As Integer = Converts.ToInt_NullIsZero(DataBase.DataMaximum("MstRackHD", "RackHeaderID"))
            For Each dr As DataRow In dt.Select("sta<>''")
                Select Case dr("sta")
                    Case "N"
                        RackHeaderID += 1
                        dr("RackHeaderID") = RackHeaderID
                        dr("DelFlag") = 0
                        dr("CreateUser") = StaffID
                        dr("CreateDate") = SystemDate
                        dr("UpdateUser") = StaffID
                        dr("UpdateDate") = SystemDate
                        dr("sta") = ""
                        DataBase.DataInsert("MstRackHD", dr)
                    Case "U"
                        dr("UpdateUser") = StaffID
                        dr("UpdateDate") = SystemDate
                        dr("sta") = ""
                        DataBase.DataUpdate("MstRackHD", dr)
                    Case "D"
                        dr("DelFlag") = 1
                        dr("UpdateUser") = StaffID
                        dr("UpdateDate") = SystemDate
                        If dr("Qty") = 0 Then
                            DataBase.DataDelete("MstRackHD", dr)
                        Else
                            DataBase.DataUpdate("MstRackHD", dr)
                            Dim dtRackDT As DataTable = DataBase.DataSelect("MstRackDT", "RackHeaderID=" & dr("RackHeaderID") & "")
                            For Each drRackDT As DataRow In dtRackDT.Select()
                                drRackDT("DelFlag") = 1
                                DataBase.DataUpdate("MstRackDT", drRackDT)
                            Next
                        End If
                End Select

            Next

            DataBase.CommitTrans()

            Dim dtNew As DataTable = dt.Clone
            For Each drNew As DataRow In dt.Select("sta<>'D'")
                dtNew.ImportRow(drNew)
            Next

            Return dtNew

        Catch ex As Exception
            GoTo SaveErr
        End Try

SaveErr:
        DataBase.RollbackTrans()
        Return Nothing
    End Function
End Class
