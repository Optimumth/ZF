Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsPTruck
    Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" _
(ByVal hWnd As System.IntPtr, ByVal lpOperation As String, ByVal lpFile As String, _
ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer

    Public Function Print(ByVal drTruck As DataRow, ByVal dtData As DataTable) As Boolean
        Dim cPrint As New OPE_Controls.clsBPrintForm
        Dim Err As String = ""
        Dim AllRow As Integer = 0
        Dim MaxCol As Integer = 9
        Dim MaxRow As Integer = 17
        Dim ExcelRowStart As Integer = 14
        Dim ExcelRowTotal As Integer = 34
        Dim ExcelRowSummary As Integer = 36

        With cPrint
            .TemplateFileName = "Container.xlsx"
            .TemplateFolder = INI.ReportTemplatePath
            .TemplateSheetName = "Template"
            .OutputFolder = INI.ReportOutputPath & "\Container"
            '.OutputFileName = "Container_" & Converts.ToStr(drTruck("CreateDate"), OPE_Controls.ConvertString.yyyyMMdd) & ".pdf"
            .OutputFileName = "Container_" & drTruck("TruckID") & ".pdf"
            If .OpenTemplateExcelFile(Err) <> 0 Then GoTo ExitFunction

            Dim dtModelContainer As New DataTable
            dtModelContainer.Columns.Add("ModelContainer", GetType(String))
            dtModelContainer.Columns.Add("ModelContainerSeq", GetType(Integer))
            dtModelContainer.Columns.Add("PageID", GetType(Integer))
            dtModelContainer.Columns.Add("FrontQty", GetType(Integer))
            dtModelContainer.Columns.Add("RearQty", GetType(Integer))
            dtModelContainer.Columns.Add("BPSQty", GetType(Integer))
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
                    drAddGroup("BPSQty") = 0
                    dtModelContainer.Rows.Add(drAddGroup)
                End If
            Next
            AllRow = dtModelContainer.Rows.Count

            Dim dtExcel As New DataTable
            dtExcel.Columns.Add("ModelContainerSeq", GetType(Integer))
            dtExcel.Columns.Add("ModelContainer", GetType(String))
            dtExcel.Columns.Add("RowID", GetType(Integer))
            For iCol As Integer = 1 To MaxCol
                dtExcel.Columns.Add("Rack" & iCol, GetType(String))
            Next

            For Each drGroup As DataRow In dtModelContainer.Select("", "ModelContainer")
                Dim iType As Integer = -1
                Dim iCol As Integer = 0
                Dim RowID As Integer = 0
                Dim drAdd As DataRow = Nothing

                For Each drData As DataRow In dtData.Select("ModelContainer='" & drGroup("ModelContainer") & "'", "Type,Rack")
                    If iType <> drData("Type") Then
                        If iType <> -1 Then
                            dtExcel.Rows.Add(drAdd)
                        End If

                        iCol = 1
                        RowID += 1
                        iType = drData("Type")

                        drAdd = dtExcel.NewRow
                        drAdd("ModelContainerSeq") = drGroup("ModelContainerSeq")
                        drAdd("ModelContainer") = drGroup("ModelContainer")
                    End If

                    If iCol > MaxCol Then
                        RowID += 1
                        iCol = 1

                        dtExcel.Rows.Add(drAdd)

                        drAdd = dtExcel.NewRow
                        drAdd("ModelContainerSeq") = drGroup("ModelContainerSeq")
                        drAdd("ModelContainer") = drGroup("ModelContainer")
                    End If

                    drAdd("RowID") = RowID
                    drAdd("Rack" & iCol) = drData("Rack")

                    iCol += 1
                Next

                dtExcel.Rows.Add(drAdd)
            Next
            AllRow += dtExcel.Rows.Count

            Dim AllPage As Integer = 1
            If AllRow > MaxRow Then
                Dim RowCountUp As Integer = 0
                For Each dr As DataRow In dtModelContainer.Select("", "ModelContainerSeq,ModelContainer")
                    Dim MaxGroupRowID As Integer = dtExcel.Compute("max(RowID)", "ModelContainer='" & dr("ModelContainer") & "'")
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
                dr("FrontQty") = dtData.Compute("count(Rack)", "ModelContainer='" & dr("ModelContainer") & "' and Type=" & SystemINI.ModelType.Front & "")
                dr("RearQty") = dtData.Compute("count(Rack)", "ModelContainer='" & dr("ModelContainer") & "' and Type=" & SystemINI.ModelType.Rear & "")
                dr("BPSQty") = dtData.Compute("count(Rack)", "ModelContainer='" & dr("ModelContainer") & "' and Type=" & SystemINI.ModelType.BPS & "")
            Next


            For iSheet As Integer = AllPage To 1 Step -1
                .CreateSheet(.TemplateSheetName, .TemplateSheetName, "Sheet" & iSheet)

                .setSheatHeader("B7", Format(drTruck("CreateDate"), "yyyy-MM-dd"))
                .setSheatHeader("B9", Converts.ToStr(drTruck("License")))

                Dim ExcelRow As Integer = ExcelRowStart
                For Each drGroup As DataRow In dtModelContainer.Select("PageID=" & iSheet & "", "ModelContainerSeq,ModelContainer")
                    If ExcelRow > ExcelRowStart Then
                        .CopyPasteRow(.TemplateSheetName, ExcelRowStart & ":" & ExcelRowStart, .OutputSheetName, ExcelRow)
                    End If
                    .setSheatHeader("A" & ExcelRow, Converts.ToStr(drGroup("ModelContainer")))
                    ExcelRow += 1
                    For Each drExcel As DataRow In dtExcel.Select("ModelContainer='" & drGroup("ModelContainer") & "'", "RowID")
                        If ExcelRow > ExcelRowStart + 1 Then
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
                Next

                Dim RackQty As Integer = dtData.Compute("count(Rack)", "Type=" & SystemINI.ModelType.Front & " or Type=" & SystemINI.ModelType.Rear & "")
                Dim BPSQty As Integer = dtData.Compute("count(Rack)", "Type=" & SystemINI.ModelType.BPS & "")
                .setSheatHeader("E" & ExcelRowTotal, RackQty)
                .setSheatHeader("H" & ExcelRowTotal, BPSQty)

                Dim iGroup As Integer = 0
                For Each drGroup As DataRow In dtModelContainer.Select("", "ModelContainerSeq,ModelContainer")
                    iGroup += 1
                    Dim sGroupCol As String = GetSummaryCol(iGroup)
                    .setSheatHeader(sGroupCol & ExcelRowSummary, Converts.ToStr(drGroup("ModelContainer")))
                    If Converts.ToInt_NullIsZero(drGroup("FrontQty")) > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 2, drGroup("FrontQty"))
                    If Converts.ToInt_NullIsZero(drGroup("RearQty")) > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 4, drGroup("RearQty"))
                    If Converts.ToInt_NullIsZero(drGroup("BPSQty")) > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 6, drGroup("BPSQty"))
                Next
            Next

            If Not .PrintReport(True, False, Err) Then GoTo ExitFunction
        End With

        Return True

ExitFunction:
        Return False

    End Function

    Public Function Print_BK(ByVal drTruck As DataRow, ByVal dtData As DataTable) As Boolean
        Dim cPrint As New OPE_Controls.clsBPrintForm
        Dim Err As String = ""
        Dim AllRow As Integer = 0
        Dim MaxCol As Integer = 15
        Dim MaxRow As Integer = 67
        Dim ExcelRowStart As Integer = 15
        Dim ExcelRowTotal As Integer = 83
        Dim ExcelRowSummary As Integer = 85

        With cPrint
            .TemplateFileName = "Container.xlsx"
            .TemplateFolder = INI.ReportTemplatePath
            .TemplateSheetName = "Template"
            .OutputFolder = INI.ReportOutputPath & "\Container"
            .OutputFileName = "Container_" & Converts.ToStr(drTruck("CreateDate"), OPE_Controls.ConvertString.yyyyMMdd) & ".pdf"
            If .OpenTemplateExcelFile(Err) <> 0 Then GoTo ExitFunction

            .OutputSheetName = "Sheet1"
            .CreateSheet(.TemplateSheetName, .TemplateSheetName, .OutputSheetName)

            Dim dtModelContainer As New DataTable
            dtModelContainer.Columns.Add("ModelContainer", GetType(String))
            dtModelContainer.Columns.Add("ModelContainerSeq", GetType(Integer))
            Dim sGroup As String = ""
            Dim drAddGroup As DataRow = Nothing
            For Each drData As DataRow In dtData.Select("", "ModelContainer,ModelContainerSeq")
                If sGroup <> drData("ModelContainer") Then
                    sGroup = drData("ModelContainer")
                    drAddGroup = dtModelContainer.NewRow
                    drAddGroup("ModelContainer") = drData("ModelContainer")
                    drAddGroup("ModelContainerSeq") = drData("ModelContainerSeq")
                    dtModelContainer.Rows.Add(drAddGroup)
                End If
            Next
            AllRow = dtModelContainer.Rows.Count

            Dim dtExcel As New DataTable
            dtExcel.Columns.Add("ModelContainerSeq", GetType(Integer))
            dtExcel.Columns.Add("ModelContainer", GetType(String))
            dtExcel.Columns.Add("RowID", GetType(Integer))
            For iCol As Integer = 1 To MaxCol
                dtExcel.Columns.Add("Rack" & iCol, GetType(String))
            Next

            For Each drGroup As DataRow In dtModelContainer.Select("", "ModelContainer")
                Dim iType As Integer = -1
                Dim iCol As Integer = 0
                Dim RowID As Integer = 0
                Dim drAdd As DataRow = Nothing

                For Each drData As DataRow In dtData.Select("ModelContainer='" & drGroup("ModelContainer") & "'", "Type,Rack")
                    If iType <> drData("Type") Then
                        If iType <> -1 Then
                            dtExcel.Rows.Add(drAdd)
                        End If

                        iCol = 1
                        RowID += 1
                        iType = drData("Type")

                        drAdd = dtExcel.NewRow
                        drAdd("ModelContainerSeq") = drGroup("ModelContainerSeq")
                        drAdd("ModelContainer") = drGroup("ModelContainer")
                    End If

                    If iCol > MaxCol Then
                        RowID += 1
                        iCol = 1

                        dtExcel.Rows.Add(drAdd)

                        drAdd = dtExcel.NewRow
                        drAdd("ModelContainerSeq") = drGroup("ModelContainerSeq")
                        drAdd("ModelContainer") = drGroup("ModelContainer")
                    End If

                    drAdd("RowID") = RowID
                    drAdd("Rack" & iCol) = drData("Rack")

                    iCol += 1
                Next

                dtExcel.Rows.Add(drAdd)
            Next
            AllRow += dtExcel.Rows.Count

            If AllRow > MaxRow Then
                .InsertRow(20, AllRow - MaxRow)
                ExcelRowTotal = ExcelRowTotal + (AllRow - MaxRow)
                ExcelRowSummary = ExcelRowSummary + (AllRow - MaxRow)
            End If

            .setSheatHeader("C7", Format(drTruck("CreateDate"), "yyyy-MM-dd"))
            .setSheatHeader("C9", Converts.ToStr(drTruck("License")))

            Dim ExcelRow As Integer = ExcelRowStart
            Dim iGroup As Integer = 1
            For Each drGroup As DataRow In dtModelContainer.Select("", "ModelContainerSeq")
                If ExcelRow > ExcelRowStart Then
                    .CopyPasteRow(.TemplateSheetName, ExcelRowStart & ":" & ExcelRowStart, .OutputSheetName, ExcelRow)
                End If
                .setSheatHeader("A" & ExcelRow, Converts.ToStr(drGroup("ModelContainer")))
                ExcelRow += 1
                For Each drExcel As DataRow In dtExcel.Select("ModelContainer='" & drGroup("ModelContainer") & "'", "RowID")
                    If ExcelRow > ExcelRowStart + 1 Then
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

                Dim sGroupCol As String = GetSummaryCol(iGroup)
                Dim iFrontQty As Integer = dtData.Compute("count(Rack)", "ModelContainer='" & drGroup("ModelContainer") & "' and Type=" & SystemINI.ModelType.Front & "")
                Dim iRearQty As Integer = dtData.Compute("count(Rack)", "ModelContainer='" & drGroup("ModelContainer") & "' and Type=" & SystemINI.ModelType.Rear & "")
                Dim iBPSQty As Integer = dtData.Compute("count(Rack)", "ModelContainer='" & drGroup("ModelContainer") & "' and Type=" & SystemINI.ModelType.BPS & "")
                .setSheatHeader(sGroupCol & ExcelRowSummary, Converts.ToStr(drGroup("ModelContainer")))
                If iFrontQty > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 1, iFrontQty)
                If iRearQty > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 3, iRearQty)
                If iBPSQty > 0 Then .setSheatHeader(sGroupCol & ExcelRowSummary + 5, iBPSQty)

                iGroup += 1
            Next

            .setSheatHeader("L" & ExcelRowTotal, dtData.Rows.Count)



            If Not .PrintReport(True, False, Err) Then GoTo ExitFunction
        End With

        Return True

ExitFunction:
        Return False

    End Function

    Private Function GetRackCol(ByVal iCol As Integer) As String
        Dim AscA As Integer = 65
        Dim AscCol As Integer = AscA + iCol - 1
        Dim sCol As String = Chr(AscCol)

        Return sCol
    End Function

    Private Function GetSummaryCol(ByVal iGroup As Integer) As String
        Dim AscB As Integer = 66
        Dim AscCol As Integer = AscB + iGroup - 1
        Dim sCol As String = Chr(AscCol)

        Return sCol
    End Function
End Class
