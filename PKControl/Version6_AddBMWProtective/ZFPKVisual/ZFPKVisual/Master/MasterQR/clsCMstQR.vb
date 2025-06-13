Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports ZXing

Public Class clsCMstQR
    Public Function GetData(chkHeader As Boolean, sHeader As String _
                            , chkValue As Boolean, sValue As Integer _
                            ) As DataTable
        Dim dt As DataTable = Nothing
        Dim cond As String = "where 1=1"
        If chkHeader = True Then
            Converts.ToStringSQLCond(cond, "MstQR.QRHeader Like {0}", sHeader)
        End If
        If chkValue = True Then
            Converts.ToStringSQLCond(cond, "QRValue Like {0}", sValue)
        End If

        Dim sql As String = String.Format( _
            "select MstQR.QRHeader,QRValue,QRIndex,0 as chk,'' as sta {0}" & _
            "from MstQR {0}" & _
            "inner join CstQRHeader on MstQR.QRHeader=CstQRHeader.QRHeader {0}" & _
            "{1}", vbCrLf, cond)
        dt = DataBase.DataTable(sql)

        Return dt
    End Function

    Public Function SaveData(dt As DataTable) As DataTable
        DataBase.BeginTrans()

        Try
            For Each dr As DataRow In dt.Select("sta<>''")
                Select Case dr("sta")
                    Case "N"
                        dr("sta") = ""
                        DataBase.DataInsertUpdate("MstQR", dr)
                    Case "D"
                        DataBase.DataDelete("MstQR", dr)
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

    Public Function PrintTag(dtData As DataTable) As Boolean
        Dim cPrint As New OPE_Controls.clsBPrintForm
        Dim Err As String = ""
        Dim ItemsPerPage As Integer = 16
        Dim AllItems As Integer = dtData.Rows.Count
        Dim RemainItems As Integer = 0
        Dim AllPages As Integer = 0
        Dim ExcelRowStart As Integer = 2

        With cPrint
            .TemplateFileName = "TemplateQR.xlsx"
            .TemplateFolder = INI.ReportTemplatePath
            .TemplateSheetName = "Template"
            .OutputFolder = INI.ReportOutputPath & "\QRTag"
            .OutputFileName = "QRTag.pdf"
            If .OpenTemplateExcelFile(Err) <> 0 Then GoTo ExitFunction
            RemainItems = AllItems Mod ItemsPerPage
            AllPages = (AllItems - RemainItems) / ItemsPerPage + IIf(RemainItems = 0, 0, 1)

            Dim iDataRow As Integer = 0
            For iSheet As Integer = 1 To AllPages
                Dim OutputSheetName As String = "Sheet" & iSheet
                .CreateSheet(.TemplateSheetName, .TemplateSheetName, OutputSheetName)
                Dim ExcelRow As Integer = ExcelRowStart

                For iItem As Integer = 1 To ItemsPerPage
                    Dim drData As DataRow = dtData.Rows(iDataRow)
                    Dim simg As String = "QR" & iDataRow
                    Dim txt As String = drData("QRIndex") & "|" & drData("QRHeader") & "|" & drData("QRValue")
                    GetQRBarcode(simg, txt)

                    If iItem Mod 2 > 0 Then
                        If iItem >= 3 Then
                            .CopyPasteRow(.TemplateSheetName, ExcelRowStart - 1 & ":" & ExcelRowStart + 1, .OutputSheetName, ExcelRow - 1)
                        End If
                        .setSheatHeader("A" & ExcelRow, Converts.ToStr(drData("QRHeader")))
                        .setSheatHeader("A" & ExcelRow + 1, Converts.ToStr(drData("QRValue")))

                        .AddPicture(OutputSheetName, "C" & ExcelRow, INI.ReportTemplatePath & "\Barcode\" & simg & ".bmp", 80, 80, 4, 2)
                        IO.File.Delete(INI.ReportTemplatePath & "\Barcode\" & simg & ".bmp")
                    Else
                        .setSheatHeader("F" & ExcelRow, Converts.ToStr(drData("QRHeader")))
                        .setSheatHeader("F" & ExcelRow + 1, Converts.ToStr(drData("QRValue")))

                        .AddPicture(OutputSheetName, "H" & ExcelRow, INI.ReportTemplatePath & "\Barcode\" & simg & ".bmp", 80, 80, 4, 2)
                        IO.File.Delete(INI.ReportTemplatePath & "\Barcode\" & simg & ".bmp")

                        ExcelRow += 3
                    End If

                    iDataRow += 1
                    If iDataRow = dtData.Rows.Count Then GoTo RunoutData
                Next
            Next

RunoutData:

            If Not .PrintReport(True, False, Err) Then GoTo ExitFunction
        End With

        Return True

ExitFunction:
        Return False
    End Function

    Private Sub GetQRBarcode(ByRef simg As String, ByVal text As String)

        Dim width As Integer = 250
        Dim height As Integer = 250
        Dim bitMatrix As ZXing.Common.BitMatrix
        bitMatrix = New ZXing.QrCode.QRCodeWriter().encode(text, BarcodeFormat.QR_CODE, width, height)
        Dim Bitmap As Bitmap = bitMatrix.ToBitmap()
        Dim path As String = INI.ReportTemplatePath & "\Barcode"
        If Not IO.Directory.Exists(path) Then
            IO.Directory.CreateDirectory(path)
        End If
        Bitmap.Save(path & "\" & simg & "." & "bmp", System.Drawing.Imaging.ImageFormat.Bmp) 'can use any image format 

    End Sub
End Class
