Imports OPE_Controls.OpeStyle

Public Class clsCPrint
    Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" _
(ByVal hWnd As System.IntPtr, ByVal lpOperation As String, ByVal lpFile As String, _
ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer

    Public Function Print() As Boolean
        Dim cPrint As New OPE_Controls.clsBPrintForm
        Dim Err As String = ""
        
        With cPrint
            .TemplateFileName = "Test.xlsx"
            .TemplateFolder = "C:\ZF\Template\"
            .TemplateSheetName = "Sheet1"
            .OutputFolder = "C:\ZF\Output\"
            .OutputFileName = "TestOutput.pdf"
            If .OpenTemplateExcelFile(Err) <> 0 Then GoTo ExitFunction
            .CreateSheet()
            .setSheatHeader("A1", "Test")

            If Not .PrintReport(True, False, Err) Then GoTo ExitFunction
            'ShellExecute(0, "Print", "C:\ZF\Output\TestOutput.pdf", "", "", 0)
            'ShellExecute(nDT, "Open", strFile, "", "C:\", SW_SHOWNORMAL)
        End With

        Return True

ExitFunction:
        Return False

    End Function
End Class
