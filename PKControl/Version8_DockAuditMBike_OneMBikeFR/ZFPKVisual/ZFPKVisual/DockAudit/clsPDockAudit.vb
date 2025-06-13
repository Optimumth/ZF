Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsPDockAudit
    Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" _
(ByVal hWnd As System.IntPtr, ByVal lpOperation As String, ByVal lpFile As String, _
ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer

    Public Enum eAxleShock
        Axle = 1
        Shock = 2
    End Enum

    Public Enum eCheckStatus
        NotUse = -1
        OK = 0
        NG = 1
    End Enum

    Public Function Print(ByVal drDockAudit As DataRow) As Boolean
        Select Case drDockAudit("AxleShockValue")
            Case eAxleShock.Axle
                Return PrintAxle(drDockAudit)
            Case eAxleShock.Shock
                Return PrintShock(drDockAudit)
            Case Else
                Return False
        End Select
    End Function

    Private Function PrintAxle(ByVal dr As DataRow) As Boolean
        'drDockAudit -> AuditDate, MinSide, Area, ModelDock, Varian, Lot, AxleShock, AxleShockValue, AxleShockName
        Dim cPrint As New OPE_Controls.clsBPrintForm
        Dim Err As String = ""

        With cPrint
            .TemplateFileName = "AuditCheckList.xlsx"
            .TemplateFolder = INI.ReportTemplatePath
            .TemplateSheetName = "Axle"
            .OutputFolder = INI.ReportOutputPath & "\AuditCheckList"
            .OutputFileName = "A_" & dr("ModelDock") & "_" & Left(dr("MinBarcode"), 12) & "_" & Format(SystemDate, "yyyyMMddHHmmss") & ".pdf"
            If .OpenTemplateExcelFile(Err) <> 0 Then GoTo ExitFunction

            .CreateSheet(.TemplateSheetName, .TemplateSheetName, "Sheet1")

            Dim sAreaType As String = IIf(dr("Area") = "F", "Front ", "Rear ") & Converts.ToStr(dr("AxleShockName"))

            .setSheatHeader("S2", sAreaType)
            .setSheatHeader("T4", Format(dr("AuditDate"), "yyyy-MM-dd"))
            .setSheatHeader("E4", dr("ModelDock"))
            .setSheatHeader("E5", dr("Varian"))
            .setSheatHeader("E7", dr("Lot"))

            'Dim RackID() As String = dr("RackID").ToString.Split(",")
            'Dim iColRack As Integer = Asc("B")
            'For i As Integer = 0 To RackID.Length - 1
            '    Dim sColRack As String = Chr(iColRack)
            '    .setSheatHeader(sColRack & 9, RackID(i))
            '    iColRack += 4
            'Next
            .setSheatHeader("B9", dr("RackID").ToString)

            'Audit Description
            Dim dtModelDock As DataTable = DataBase.DataSelect("MstModelDock", "ID=" & dr("ModelDockID") & "")
            Dim dtMstQC As DataTable = DataBase.DataSelect("MstQC")

            For Each drMstQC As DataRow In dtMstQC.Select("CheckID=1 and FormatID=" & dtModelDock.Rows(0)("Format1") & "")
                .setSheatHeader("B11", drMstQC("Desc1"))
                .setSheatHeader("B12", drMstQC("Desc2"))
                .setSheatHeader("B13", drMstQC("Desc3"))
            Next
            For Each drMstQC As DataRow In dtMstQC.Select("CheckID=2 and FormatID=" & dtModelDock.Rows(0)("Format2") & "")
                .setSheatHeader("B16", drMstQC("Desc1"))
                .setSheatHeader("B17", drMstQC("Desc2"))
            Next
            For Each drMstQC As DataRow In dtMstQC.Select("CheckID=3 and FormatID=" & dtModelDock.Rows(0)("Format3") & "")
                .setSheatHeader("B22", drMstQC("Desc1"))
                .setSheatHeader("B23", drMstQC("Desc2"))
            Next
            For Each drMstQC As DataRow In dtMstQC.Select("CheckID=4 and FormatID=" & dtModelDock.Rows(0)("Format4") & "")
                .setSheatHeader("B26", drMstQC("Desc1"))
                .setSheatHeader("B27", drMstQC("Desc2"))
            Next


            If dtModelDock.Rows(0)("Check1") = 0 Then
                .Font("A11:A11", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("B11:B11", , , , 0, "DarkGray")
                .Font("B12:B12", , , , 0, "DarkGray")
                .Font("B13:B13", , , , 0, "DarkGray")
                .Font("A14:A15", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
            End If
            If dtModelDock.Rows(0)("Check2") = 0 Then
                .Font("A16:A16", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("B16:B16", , , , 0, "DarkGray")
                .Font("B17:B17", , , , 0, "DarkGray")
            End If
            If dtModelDock.Rows(0)("Check3") = 0 Then
                .Font("A22:A22", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("B22:B22", , , , 0, "DarkGray")
                .Font("B23:B23", , , , 0, "DarkGray")
            End If
            If dtModelDock.Rows(0)("Check4") = 0 Then
                .Font("A26:A26", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("B26:B26", , , , 0, "DarkGray")
                .Font("B27:B27", , , , 0, "DarkGray")
            End If
            
            Dim dtDockAudit As DataTable = DataBase.DataSelect("PrgDockAudit" _
                                                               , "CompleteFlag = 1 and ModelDockID=" & dr("ModelDockID") & " and Varian='" & dr("Varian") & "' and Lot='" & dr("Lot") & "' and AxleShock=" & dr("AxleShock") & "" _
                                                               , , , "PrgDockAudit.*,GivenName" _
                                                               ,,"left join MstStaff on PrgDockAudit.StaffCode=MstStaff.StaffCode" _
                                                               )
            Dim iColAxle As Integer = Asc("B")
            Dim sColAxle As String = ""
            iColAxle = Asc("B")
            Dim dupAxleNo As String = ""
            For Each drDockAudit As DataRow In dtDockAudit.Select("Check1=0", "AxleNo")
                If dupAxleNo <> drDockAudit("AxleNo") Then
                    sColAxle = Chr(iColAxle)
                    .setSheatHeader(sColAxle & 14, drDockAudit("AxleNo"))
                    .setSheatHeader(sColAxle & 15, drDockAudit("AxleNo"))
                    iColAxle += 1
                    dupAxleNo = drDockAudit("AxleNo")
                End If
            Next


            'Check 2
            .setSheatHeader("B19", dr("Varian"))
            .setSheatHeader("D19", Converts.ToStr(dr("PartNo")))
            iColAxle = Asc("B")
            For Each drDockAudit As DataRow In dtDockAudit.Select("Check2=0", "AxleNo")
                sColAxle = Chr(iColAxle)
                .setSheatHeader(sColAxle & 21, drDockAudit("AxleNo"))
                iColAxle += 1
            Next

            iColAxle = Asc("B")
            For Each drDockAudit As DataRow In dtDockAudit.Select("Check3=0", "AxleNo")
                sColAxle = Chr(iColAxle)
                .setSheatHeader(sColAxle & 25, drDockAudit("AxleNo"))
                iColAxle += 1
            Next

            Dim dtSetDate As New DataTable
            dtSetDate.Columns.Add("Check4_Date", GetType(String))
            Dim dupDate As String = "n/a"
            For Each drDockAudit As DataRow In dtDockAudit.Select("Check4=0", "Check4_Date")
                If dupDate <> Converts.ToStr(drDockAudit("Check4_Date")) Then
                    dupDate = Converts.ToStr(drDockAudit("Check4_Date"))
                    Dim drAddSetDate As DataRow = dtSetDate.NewRow
                    If dupDate = "" Then
                        drAddSetDate("Check4_Date") = ""
                    Else
                        drAddSetDate("Check4_Date") = Format(drDockAudit("Check4_Date"), "yyyy-MM-dd")
                    End If
                    dtSetDate.Rows.Add(drAddSetDate)
                End If
            Next
            iColAxle = Asc("B")
            'For Each drSetDate As DataRow In dtSetDate.Select("", "Check4_Date")
            '    sColAxle = Chr(iColAxle)
            '    .setSheatHeader(sColAxle & 29, drSetDate("Check4_Date"))

            '    Dim iPlus As Integer = 0
            '    For Each drDockAudit As DataRow In dtDockAudit.Select("Check4=0", "Check4_Date,AxleNo")
            '        Dim sDockAuditDate As String = ""
            '        If Converts.ToStr(drDockAudit("Check4_Date")) <> "" Then
            '            sDockAuditDate = Format(drDockAudit("Check4_Date"), "yyyy-MM-dd")
            '        End If
            '        If drSetDate("Check4_Date") = sDockAuditDate Then
            '            sColAxle = Chr(iColAxle + iPlus)
            '            .setSheatHeader(sColAxle & 30, drDockAudit("AxleNo"))
            '            iPlus += 1
            '        End If
            '    Next
            '    iColAxle += 6
            'Next
            For Each drSetDate As DataRow In dtSetDate.Select("", "Check4_Date")
                Dim iPlus As Integer = 0
                For Each drDockAudit As DataRow In dtDockAudit.Select("Check4=0", "Check4_Date,AxleNo")
                    Dim sDockAuditDate As String = ""
                    If Converts.ToStr(drDockAudit("Check4_Date")) <> "" Then
                        sDockAuditDate = Format(drDockAudit("Check4_Date"), "yyyy-MM-dd")
                    End If
                    If drSetDate("Check4_Date") = sDockAuditDate Then
                        sColAxle = Chr(iColAxle + iPlus)
                        .setSheatHeader(sColAxle & 30, drDockAudit("AxleNo"))
                        iPlus += 1
                    End If
                Next
                Dim startCol As String = Chr(iColAxle) & "29"
                Dim endCol As String = Chr(iColAxle + iPlus - 1) & "29"
                .MergeCell(startCol & ":" & endCol, , OPE_Controls.clsBPrintForm.enWeight.xlHairLine)
                .setSheatHeader(startCol, drSetDate("Check4_Date"))
                iColAxle = iColAxle + iPlus
            Next

            iColAxle = Asc("B")
            Dim dupStaffCode As String = ""
            For Each drDockAudit As DataRow In dtDockAudit.Select("", "GivenName")
                If dupStaffCode <> drDockAudit("GivenName") Then
                    dupStaffCode = drDockAudit("GivenName")
                    sColAxle = Chr(iColAxle)
                    .setSheatHeader(sColAxle & 31, dupStaffCode)
                    iColAxle += 2
                End If
            Next

            If Not .PrintReport(True, False, Err) Then GoTo ExitFunction
        End With

        Return True

ExitFunction:
        Return False

    End Function

    Private Function PrintShock(ByVal dr As DataRow) As Boolean
        Dim cPrint As New OPE_Controls.clsBPrintForm
        Dim Err As String = ""

        With cPrint
            .TemplateFileName = "AuditCheckList.xlsx"
            .TemplateFolder = INI.ReportTemplatePath
            .TemplateSheetName = "Shock"
            .OutputFolder = INI.ReportOutputPath & "\AuditCheckList"
            .OutputFileName = "S_" & dr("ModelDock") & "_" & Left(dr("MinBarcode"), 12) & ".pdf"
            If .OpenTemplateExcelFile(Err) <> 0 Then GoTo ExitFunction

            .CreateSheet(.TemplateSheetName, .TemplateSheetName, "Sheet1")

            Dim sAreaType As String = IIf(dr("Area") = "F", "Front ", "Rear ") & Converts.ToStr(dr("AxleShockName"))
            .setSheatHeader("S2", sAreaType)
            .setSheatHeader("E4", dr("ModelDock"))
            .setSheatHeader("T4", Format(dr("AuditDate"), "yyyy-MM-dd"))
            .setSheatHeader("E5", dr("Varian"))
            .setSheatHeader("E7", dr("Lot"))

            'Dim RackID() As String = dr("RackID").ToString.Split(",")
            'Dim iColRack As Integer = Asc("B")
            'For i As Integer = 0 To RackID.Length - 1
            '    Dim sColRack As String = Chr(iColRack)
            '    .setSheatHeader(sColRack & 9, RackID(i))
            '    iColRack += 4
            'Next
            .setSheatHeader("B9", dr("RackID").ToString)

            Dim dtModelDock As DataTable = DataBase.DataSelect("MstModelDock", "ID=" & dr("ModelDockID") & "")
            Dim dtMstQC As DataTable = DataBase.DataSelect("MstQC")

            For Each drMstQC As DataRow In dtMstQC.Select("CheckID=5 and FormatID=" & dtModelDock.Rows(0)("Format5") & "")
                .setSheatHeader("B15", drMstQC("Desc1"))
                .setSheatHeader("B16", drMstQC("Desc2"))
            Next
            For Each drMstQC As DataRow In dtMstQC.Select("CheckID=6 and FormatID=" & dtModelDock.Rows(0)("Format6") & "")
                .setSheatHeader("B21", drMstQC("Desc1"))
                .setSheatHeader("B22", drMstQC("Desc2"))
            Next
            For Each drMstQC As DataRow In dtMstQC.Select("CheckID=7 and FormatID=" & dtModelDock.Rows(0)("Format7") & "")
                .setSheatHeader("B24", drMstQC("Desc1"))
                .setSheatHeader("B25", drMstQC("Desc2"))
            Next

            If dtModelDock.Rows(0)("Check5") = 0 Then
                .Font("A15:A15", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("B15:B15", , , , 0, "DarkGray")
                .Font("B16:B16", , , , 0, "DarkGray")
            End If
            If dtModelDock.Rows(0)("Check6") = 0 Then
                .Font("A21:A21", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("B21:B21", , , , 0, "DarkGray")
                .Font("B22:B22", , , , 0, "DarkGray")
                .Font("B23:B23", , , , 0, "DarkGray")
                .Font("H23:H23", , , , 0, "DarkGray")
                .Font("N23:N23", , , , 0, "DarkGray")
                .Font("Q23:Q23", , , , 0, "DarkGray")
                .Font("S23:S23", , , , 0, "DarkGray")
                .Font("W23:W23", , , , 0, "DarkGray")
            End If
            If dtModelDock.Rows(0)("Check7") = 0 Then
                .Font("A24:A24", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("B24:B24", , , , 0, "DarkGray")
                .Font("B25:B25", , , , 0, "DarkGray")
                .Font("A27:A28", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("B27:B28", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("H27:H28", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("N27:N28", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
                .Font("T27:T28", , , , 0, "DarkGray", Excel.XlHAlign.xlHAlignCenter, Excel.XlVAlign.xlVAlignCenter)
            End If

            Dim dtDockAudit As DataTable = DataBase.DataSelect("PrgDockAudit" _
                                                               , "CompleteFlag = 1 and ModelDockID=" & dr("ModelDockID") & " and Varian='" & dr("Varian") & "' and Lot='" & dr("Lot") & "' and AxleShock=" & dr("AxleShock") & "" _
                                                               , , , "PrgDockAudit.*,GivenName" _
                                                               , , "left join MstStaff on PrgDockAudit.StaffCode=MstStaff.StaffCode" _
                                                               )

            Dim iColAxle As Integer = Asc("B")
            Dim sColAxle As String = ""

            'Check5
            .setSheatHeader("B18", dr("Varian"))
            .setSheatHeader("D18", dr("PartNo"))
            'iColAxle = Asc("B")
            'For Each drDockAudit As DataRow In dtDockAudit.Select("Check5=0", "AxleNo")
            '    sColAxle = Chr(iColAxle)
            '    .setSheatHeader(sColAxle & 20, drDockAudit("AxleNo"))
            '    iColAxle += 1
            'Next

            'Check6 - Wingdings 2 --> P=Check, O=X
            If dtDockAudit.Compute("count(ModelDockID)", "Check6=0") > 0 Then
                .setSheatHeader("D23", dr("ModelDock"))
                .setSheatHeader("J23", dr("Lot"))
                .setSheatHeader("P23", "P")
                If dr("CorrectedFlag") = 1 Then
                    .setSheatHeader("V23", "P")
                Else
                    .setSheatHeader("V23", "O")
                End If
            End If

            'Check7
            'C27, I27, O27, U27
            'C28, I28, O28, U28
            For Each drDockAudit As DataRow In dtDockAudit.Select("Check7=0", "AxleNo")
                Dim dtBarcodeSub As DataTable = DataBase.DataSelect("PrgDockAuditShock", "BarcodeHD='" & drDockAudit("Barcode") & "'", , , , , , "Barcode")
                Dim iRow As Integer = IIf(Strings.Right(drDockAudit("Barcode"), 1) = "X" Or Strings.Right(drDockAudit("Barcode"), 1) = "L", 27, 28)
                Dim iData As Integer = 1
                Dim sCol1 As String = ""
                Dim sCol2 As String = ""
                For Each drBarcodeSub As DataRow In dtBarcodeSub.Select("", "Barcode")
                    Select Case iData
                        Case 1 : sCol1 = "B" : sCol2 = "C"
                        Case 2 : sCol1 = "H" : sCol2 = "I"
                        Case 3 : sCol1 = "N" : sCol2 = "O"
                        Case 4 : sCol1 = "T" : sCol2 = "U"
                    End Select
                    .setSheatHeader(sCol1 & iRow, Strings.Mid(drBarcodeSub("Barcode"), 13, 2))
                    .setSheatHeader(sCol2 & iRow, drBarcodeSub("Barcode"))

                    iData += 1
                Next
            Next

            iColAxle = Asc("B")
            Dim dupStaffCode As String = ""
            For Each drDockAudit As DataRow In dtDockAudit.Select("", "GivenName")
                If dupStaffCode <> drDockAudit("GivenName") Then
                    dupStaffCode = drDockAudit("GivenName")
                    sColAxle = Chr(iColAxle)
                    .setSheatHeader(sColAxle & 33, dupStaffCode)
                    iColAxle += 2
                End If
            Next

            If Not .PrintReport(True, False, Err) Then GoTo ExitFunction
        End With

        Return True

ExitFunction:
        Return False

    End Function
End Class
