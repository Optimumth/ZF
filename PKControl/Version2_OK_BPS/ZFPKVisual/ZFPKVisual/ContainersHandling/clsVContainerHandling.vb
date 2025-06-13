Public Class clsVContainerHandling

    Private Sub OpeButtonPrint1_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles OpeButtonPrint1.Click
        Dim ctl As New clsCPrint
        ctl.Print()
    End Sub
End Class