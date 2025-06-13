Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsPTruckBMW
    Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" _
(ByVal hWnd As System.IntPtr, ByVal lpOperation As String, ByVal lpFile As String, _
ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer

    Public Function Print(ByVal drTruck As DataRow, ByVal dtData As DataTable) As Boolean
        Dim cPrint As New OPE_Controls.clsBPrintForm
        Dim Err As String = ""
        Dim AllRow As Integer = 0
        Dim MaxCol As Integer = 6
        Dim MaxRow As Integer = 17
        Dim ExcelRowStart As Integer = 14
        Dim ExcelRowTotal As Integer = 23
        Dim ExcelRowSummary As Integer = 0

        With cPrint
            .TemplateFileName = "Container.xlsx"
            .TemplateFolder = INI.ReportTemplatePath
            .TemplateSheetName = "Template"
            .OutputFolder = INI.ReportOutputPath & "\Container"
            .OutputFileName = "Container_" & drTruck("TruckID") & ".pdf"
            If .OpenTemplateExcelFile(Err) <> 0 Then GoTo ExitFunction

            Dim dtModelContainer As New DataTable
            dtModelContainer.Columns.Add("ModelContainer", GetType(String))
            dtModelContainer.Columns.Add("ModelContainerSeq", GetType(Integer))
            dtModelContainer.Columns.Add("PageID", GetType(Integer))
            dtModelContainer.Columns.Add("FrontQty", GetType(Integer))
            dtModelContainer.Columns.Add("RearQty", GetType(Integer))
            dtModelContainer.Columns.Add("FrontRearQty", GetType(Integer))
            dtModelContainer.Columns.Add("STBQty", GetType(Integer))
            dtModelContainer.Columns.Add("MBikeQty", GetType(Integer))
            dtModelContainer.Columns.Add("PTCQty", GetType(Integer))
            dtModelContainer.Columns.Add("PTC101", GetType(Integer))
            dtModelContainer.Columns.Add("PTC102", GetType(Integer))
            dtModelContainer.Columns.Add("PTC103", GetType(Integer))
            dtModelContainer.Columns.Add("PTCFlag", GetType(Integer))

            Dim sGroup As String = ""
            Dim drAddGroup As DataRow = Nothing
            For Each drData As DataRow In dtData.Select("", "ModelContainer,ModelContainerSeq")
                If sGroup <> drData("ModelContainer") Then
                    sGroup = drData("ModelContainer")
                    drAddGroup = dtModelContainer.NewRow
                    drAddGroup("ModelContainer") = drData("ModelContainer")
                    drAddGroup("ModelContainerSeq") = drData("ModelContainerSeq")
                    drAddGroup("PageID") = 1
                    drAddGroup("FrontQty") = 0
                    drAddGroup("RearQty") = 0
                    drAddGroup("FrontRearQty") = 0
                    drAddGroup("STBQty") = 0
                    drAddGroup("MBikeQty") = 0
                    drAddGroup("PTCQty") = 0
                    drAddGroup("PTC101") = 0
                    drAddGroup("PTC102") = 0
                    drAddGroup("PTC103") = 0
                    drAddGroup("PTCFlag") = IIf(drData("Type") = SystemINI.ModelTypeBMW.PTC, 1, 0)
                    dtModelContainer.Rows.Add(drAddGroup)
                End If
            Next
            AllRow = dtModelContainer.Rows.Count

            Dim dtExcel1 As New DataTable
            dtExcel1.Columns.Add("ModelContainerSeq", GetType(Integer))
            dtExcel1.Columns.Add("ModelContainer", GetType(String))
            dtExcel1.Columns.Add("RowID", GetType(Integer))
            For iCol As Integer = 1 To MaxCol
                dtExcel1.Columns.Add("Rack" & iCol, GetType(String))
            Next

            Dim dtExcel2 As DataTable = dtExcel1.Clone

            For iLoop As Integer = 1 To 2
                Dim sWhere As String = IIf(iLoop = 1, "PTCFlag=0", "PTCFlag=1")
                Dim dtExcelTmp As DataTable = IIf(iLoop = 1, dtExcel1, dtExcel2)
                For Each drGroup As DataRow In dtModelContainer.Select(sWhere, "ModelContainer")
                    Dim iType As Integer = -1
                    Dim iCol As Integer = 0
                    Dim RowID As Integer = 0
                    Dim drAdd As DataRow = Nothing

                    For Each drData As DataRow In dtData.Select("ModelContainer='" & drGroup("ModelContainer") & "'", "Type,Rack")
                        If iType <> drData("Type") Then
                            If iType <> -1 Then
                                dtExcelTmp.Rows.Add(drAdd)
                            End If

                            iCol = 1
                            RowID += 1
                            iType = drData("Type")

                            drAdd = dtExcelTmp.NewRow
                            drAdd("ModelContainerSeq") = drGroup("ModelContainerSeq")
                            drAdd("ModelContainer") = drGroup("ModelContainer")
                        End If

                        If iCol > MaxCol Then
                            RowID += 1
                            iCol = 1

                            dtExcelTmp.Rows.Add(drAdd)

                            drAdd = dtExcelTmp.NewRow
                            drAdd("ModelContainerSeq") = drGroup("ModelContainerSeq")
                            drAdd("ModelContainer") = drGroup("ModelContainer")
                        End If

                        drAdd("RowID") = RowID
                        drAdd("Rack" & iCol) = drData("Rack")

                        iCol += 1
                    Next

                    dtExcelTmp.Rows.Add(drAdd)
                Next
            Next
            
            AllRow += (dtExcel1.Rows.Count + dtExcel2.Rows.Count)

            Dim AllPage As Integer = 1
            If AllRow > MaxRow Then
                Dim RowCountUp As Integer = 0
                For Each dr As DataRow In dtModelContainer.Select("PTCFlag=0", "ModelContainerSeq,ModelContainer")
                    Dim MaxGroupRowID As Integer = dtExcel1.Compute("max(RowID)", "ModelContainer='" & dr("ModelContainer") & "'")
                    If RowCountUp + MaxGroupRowID + 1 <= MaxRow Then
                        RowCountUp += MaxGroupRowID + 1
                    Else
                        AllPage += 1
                        RowCountUp = 0
                    End If
                    For Each drGroup As DataRow In dtModelContainer.Select("ModelContainer='" & dr("ModelContainer") & "'")
                        drGroup("PageID") = AllPage
                    Next
                Next
            End If

            For Each dr As DataRow In dtModelContainer.Select("", "ModelContainerSeq,ModelContainer")
                dr("FrontQty") = dtData.Compute("count(Rack)", "ModelContainer='" & dr("ModelContainer") & "' and Type=" & SystemINI.ModelTypeBMW.Front & "")
                dr("RearQty") = dtData.Compute("count(Rack)", "ModelContainer='" & dr("ModelContainer") & "' and Type=" & SystemINI.ModelTypeBMW.Rear & "")
                dr("FrontRearQty") = dtData.Compute("count(Rack)", "ModelContainer='" & dr("ModelContainer") & "' and Type=" & SystemINI.ModelTypeBMW.FrontRear & "")
                dr("STBQty") = dtData.Compute("count(Rack)", "ModelContainer='" & dr("ModelContainer") & "' and Type=" & SystemINI.ModelTypeBMW.STB & "")
                dr("MBikeQty") = dtData.Compute("count(Rack)", "ModelContainer='" & dr("ModelContainer") & "' and Type=" & SystemINI.ModelTypeBMW.MBike & "")
                dr("PTCQty") = dtData.Compute("count(Rack)", "ModelContainer='" & dr("ModelContainer") & "' and Type=" & SystemINI.ModelTypeBMW.PTC & "")
                If dr("PTCFlag") = 1 Then
                    dr("PTC101") = dtData.Compute("count(Rack)", "ModelContainerSeq=101")
                    dr("PTC102") = dtData.Compute("count(Rack)", "ModelContainerSeq=102")
                    dr("PTC103") = dtData.Compute("count(Rack)", "ModelContainerSeq=103")
                End If
            Next


            For iSheet As Integer = AllPage To 1 Step -1
                .CreateSheet(.TemplateSheetName, .TemplateSheetName, "Sheet" & iSheet)

                .setSheatHeader("E4", Format(drTruck("CreateDate"), "yyyy-MM-dd"))
                .setSheatHeader("U4", Converts.ToStr(drTruck("Model")))
                .setSheatHeader("E5", CustomizeSetting.SystemDate)
                .setSheatHeader("U5", Converts.ToStr(drTruck("Varian")))
                .setSheatHeader("E6", Converts.ToStr(drTruck("License")))
                .setSheatHeader("U6", Converts.ToStr(drTruck("Lot")))
                .setSheatHeader("X7", Converts.ToStr(drTruck("DeliveryNoteNo")))

                Select Case Converts.ToStr(drTruck("AxleNo"))
                    Case "1-6" : .setSheatHeader("D8", "√")
                    Case "7-12" : .setSheatHeader("G8", "√")
                    Case "13-18" : .setSheatHeader("J8", "√")
                    Case "19-24" : .setSheatHeader("M8", "√")
                    Case "1-24" : .setSheatHeader("D9", "√")
                    Case Else
                        .setSheatHeader("G9", "√")
                        .setSheatHeader("J9", Converts.ToStr(drTruck("AxleNo")))
                End Select

                .setSheatHeader("J36", Converts.ToStr(drTruck("DriverName")))
                .setSheatHeader("AB36", Converts.ToStr(drTruck("Tel")))
                .setSheatHeader("J37", Converts.ToStr(drTruck("ZFInCharge")))
                .setSheatHeader("J38", Converts.ToStr(drTruck("CusInCharge")))

                For iLoop As Integer = 1 To 2
                    Dim ExcelRow As Integer = IIf(iLoop = 1, ExcelRowStart, ExcelRowStart + 4)
                    Dim sWhere As String = IIf(iLoop = 1, "PTCFlag=0", "PTCFlag=1")
                    Dim dtExcelTmp As DataTable = IIf(iLoop = 1, dtExcel1, dtExcel2)
                    For Each drGroup As DataRow In dtModelContainer.Select("PageID=" & iSheet & " and " & sWhere, "ModelContainerSeq,ModelContainer")
                        .setSheatHeader("A" & ExcelRow, Converts.ToStr(drGroup("ModelContainer")))
                        ExcelRow += 1
                        For Each drExcel As DataRow In dtExcelTmp.Select("ModelContainer='" & drGroup("ModelContainer") & "'", "RowID")
                            If ExcelRow > IIf(iLoop = 1, ExcelRowStart + 1, ExcelRowStart + 4 + 1) Then
                                .CopyPasteRow(.TemplateSheetName, ExcelRowStart + 1 & ":" & ExcelRowStart + 1, .OutputSheetName, ExcelRow)
                            End If

                            For iCol As Integer = 1 To MaxCol
                                If Converts.ToStr(drExcel("Rack" & iCol)) = "" Then
                                    .SetBackgroundColor(GetRackCol(iCol) & ExcelRow, 16)
                                Else
                                    .setSheatHeader(GetRackCol(iCol) & ExcelRow, Converts.ToStr(drExcel("Rack" & iCol)))
                                End If
                            Next
                            ExcelRow += 1
                        Next
                        Exit For 'ใส่เพื่อบังคับให้แสดงแค่ Model เดียว ถ้าเอาออกต้องเปลี่ยนเทมเพลต
                    Next
                Next


                Dim RackQty As Integer = dtData.Compute("count(Rack)", "Type=" & SystemINI.ModelTypeBMW.Front & " or Type=" & SystemINI.ModelTypeBMW.Rear & " or Type=" & SystemINI.ModelTypeBMW.FrontRear & "")
                Dim STBQty As Integer = dtData.Compute("count(Rack)", "Type=" & SystemINI.ModelTypeBMW.STB & "")
                Dim MBikeQty As Integer = dtData.Compute("count(Rack)", "Type=" & SystemINI.ModelTypeBMW.MBike & "")
                Dim PTCQty As Integer = dtData.Compute("count(Rack)", "Type=" & SystemINI.ModelTypeBMW.PTC & "")
                .setSheatHeader("J" & ExcelRowTotal, RackQty)
                .setSheatHeader("R" & ExcelRowTotal, STBQty)
                .setSheatHeader("Z" & ExcelRowTotal, MBikeQty)
                .setSheatHeader("AF" & ExcelRowTotal, PTCQty)

                Dim iGroup As Integer = 0
                ExcelRowSummary = 24
                For Each drGroup As DataRow In dtModelContainer.Select("PTCFlag=0", "ModelContainerSeq,ModelContainer")
                    iGroup += 1
                    Dim sGroupCol As String = GetSummaryCol(iGroup)
                    .setSheatHeader(sGroupCol & ExcelRowSummary, Converts.ToStr(drGroup("ModelContainer")))
                    If Converts.ToInt_NullIsZero(drGroup("FrontQty")) > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 1, drGroup("FrontQty"))
                    If Converts.ToInt_NullIsZero(drGroup("RearQty")) > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 2, drGroup("RearQty"))
                    If Converts.ToInt_NullIsZero(drGroup("FrontRearQty")) > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 3, drGroup("FrontRearQty"))
                    If Converts.ToInt_NullIsZero(drGroup("STBQty")) > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 4, drGroup("STBQty"))
                    If Converts.ToInt_NullIsZero(drGroup("MBikeQty")) > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 5, drGroup("MBikeQty"))

                    Exit For 'ใส่เพื่อบังคับให้แสดงแค่ Model เดียว ถ้าเอาออกต้องเปลี่ยนเทมเพลต
                Next

                ExcelRowSummary = 25
                For Each drGroup As DataRow In dtModelContainer.Select("PTCFlag=1", "ModelContainerSeq,ModelContainer")
                    If Converts.ToInt_NullIsZero(drGroup("PTC101")) > 0 Then .setSheatHeader("AA" & ExcelRowSummary, drGroup("PTC101"))
                    If Converts.ToInt_NullIsZero(drGroup("PTC102")) > 0 Then .setSheatHeader("AA" & ExcelRowSummary + 1, drGroup("PTC102"))
                    If Converts.ToInt_NullIsZero(drGroup("PTC103")) > 0 Then .setSheatHeader("AA" & ExcelRowSummary + 2, drGroup("PTC103"))
                    Exit For
                Next
            Next

            If Not .PrintReport(True, False, Err) Then GoTo ExitFunction
        End With

        Return True

ExitFunction:
        Return False

    End Function

    Private Function GetRackCol(ByVal iCol As Integer) As String
        'Dim AscA As Integer = 65
        'Dim AscCol As Integer = AscA + iCol - 1
        'Dim sCol As String = Chr(AscCol)

        Dim sCol As String = ""
        Select Case iCol
            Case 1 : sCol = "A"
            Case 2 : sCol = "G"
            Case 3 : sCol = "M"
            Case 4 : sCol = "S"
            Case 5 : sCol = "Y"
            Case 6 : sCol = "AE"
        End Select

        Return sCol
    End Function

    Private Function GetSummaryCol(ByVal iGroup As Integer) As String
        'Dim AscB As Integer = 66
        'Dim AscCol As Integer = AscB + iGroup - 1
        'Dim sCol As String = Chr(AscCol)

        Dim sCol As String = "I"
        Return sCol
    End Function
End Class
