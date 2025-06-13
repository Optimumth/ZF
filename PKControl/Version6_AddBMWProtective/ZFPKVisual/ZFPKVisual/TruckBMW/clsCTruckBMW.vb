Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCTruckBMW
    Public Function GetData(ByVal chkSDate As Boolean, ByVal SDate1 As Date, ByVal SDate2 As Date _
                            , ByVal chkSTruckID As Boolean, ByVal sTruckID As String _
                            , ByVal chkSLicense As Boolean, ByVal sLicense As String _
                            , ByVal chkSPrintStatus As Boolean, ByVal sPrintStatus As Integer _
                            ) As DataTable

        Dim cond As String = "1=1"
        If chkSDate = True Then
            Converts.ToStringAnd(cond, "({0} And {1})", _
                                Converts.ToStringSQLDateDiff(SDate1, "PrgTruck.CreateDate", 0), _
                                Converts.ToStringSQLDateDiff(SDate2, "PrgTruck.CreateDate", 0, , OPE_Controls.OperationSymbol.IsLessThanOrEqualTo))
        End If
        If chkSTruckID = True Then Converts.ToStringSQLCond(cond, "PrgTruck.TruckID Like {0}", sTruckID)
        If chkSLicense = True Then Converts.ToStringSQLCond(cond, "PrgTruck.License Like {0}", sLicense)
        If chkSPrintStatus = True Then Converts.ToStringSQLCond(cond, "PrgTruck.PrintFlag={0}", sPrintStatus)

        DataBase.runSQL("exec TruckControl")
        Dim dt As DataTable = DataBase.DataSelect("PrgTruck" _
                                                  , cond, , , "PrgTruck.*,count(PrgTransaction.ID) as RackAmount,'' as sta" _
                                                  , , "left join PrgTransaction on PrgTruck.TruckID=PrgTransaction.TruckID" _
                                                  , "PrgTruck.CreateDate,PrgTruck.TruckID" _
                                                  , "PrgTruck.CreateDate,PrgTruck.TruckID,PrgTruck.License,PrgTruck.PrintFlag,PrgTruck.Remark,PrgTruck.Model" & _
                                                    ",PrgTruck.Varian,PrgTruck.Lot,PrgTruck.DeliveryNoteNo,PrgTruck.AxleNo,PrgTruck.AxleCompleted" & _
                                                    ",PrgTruck.DriverName, PrgTruck.Tel, PrgTruck.ZFInCharge, PrgTruck.CusInCharge,PrgTruck.UpdateDate")
        Return dt
    End Function

    Public Function GetContainerData(ByVal TruckID As String) As DataTable
        Dim sql As String = String.Format("select ModelContainerSeq,ModelContainer                                           {0}" & _
                                          "       ,case when Model<>'ZFRACK'                                                 {0}" & _
                                          "             then CONCAT(Code,RackNo)                                             {0}" & _
                                          "             else case when RHD.Remark='V223' then 'S'+RackNo else 'C'+RackNo end {0}" & _
                                          "         end as Rack                                                              {0}" & _
                                          "       ,RHD.Type                                                                  {0}" & _
                                          " from PrgTransaction Trans                                                        {0}" & _
                                          " inner join MstRackDT RDT on Trans.RackDTID=RDT.ID                                {0}" & _
                                          " inner join MstRackHD RHD on RDT.RackHeaderID=RHD.RackHeaderID                    {0}" & _
                                          " inner join MstModel mModel on RHD.ModelID=mModel.ID                              {0}" & _
                                          " where TruckID='" & TruckID & "'                                                  {0}" & _
                                          " order by ModelContainerSeq,ModelContainer,RHD.Type                               {0}" & _
                                          "", vbCrLf)
        Dim dt As DataTable = DataBase.DataTable(sql)
        For Each dr As DataRow In dt.Select()
            Dim RackNo As String = dr("Rack")
            For i As Integer = 1 To RackNo.Length
                If Not IsNumeric(Strings.Right(RackNo, i)) Then
                    RackNo = Strings.Left(RackNo, RackNo.Length - i + 1) & "-" & Right(RackNo, i - 1)
                    dr("Rack") = RackNo
                    Exit For
                End If
            Next
        Next

        Return dt
    End Function

    Public Function SaveData(ByVal dt As DataTable) As Boolean
        DataBase.BeginTrans()

        Try
            Dim TruckFormat As String = "M" & Format(SystemDate, "yyMMdd") & "-"
            Dim TruckID As String = Converts.ToStr(DataBase.DataMaximum("PrgTruck", "TruckID", "TruckID like '" & TruckFormat & "%' "))
            Dim iTruckID As Integer = 0
            If TruckID <> "" Then
                iTruckID = Right(TruckID, 3)
            End If

            For Each dr As DataRow In dt.Select("sta<>''")
                Select Case dr("sta")
                    Case "N"
                        iTruckID += 1
                        dr("TruckID") = TruckFormat & iTruckID.ToString.PadLeft(3, "0")
                        dr("UpdateDate") = CustomizeSetting.SystemDate
                        dr("sta") = ""
                        DataBase.DataInsert("PrgTruck", dr)
                    Case "U"
                        dr("sta") = ""
                        dr("UpdateDate") = CustomizeSetting.SystemDate
                        DataBase.DataUpdate("PrgTruck", dr)
                    Case "D"
                        DataBase.DataDelete("PrgTruck", dr)
                End Select

            Next

            DataBase.CommitTrans()

            Return True

            'Dim dtNew As DataTable = dt.Clone
            'For Each drNew As DataRow In dt.Select("sta<>'D'")
            '    dtNew.ImportRow(drNew)
            'Next

            'Return dtNew

        Catch ex As Exception
            GoTo SaveErr
        End Try

SaveErr:
        DataBase.RollbackTrans()
        Return False

    End Function

    Public Function SavePrint(ByVal TruckID As String) As Boolean
        DataBase.BeginTrans()

        Try
            If DataBase.runSQL("update PrgTruck set PrintFlag=1 where TruckID='" & TruckID & "'") = False Then GoTo SaveErr

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
