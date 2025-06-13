Public Class clsVExportSelection

    Public mOK As Boolean = False

    Private Sub clsVExportSelection_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadCtrl()
    End Sub

    Private Sub LoadCtrl()
        rdoMB.Checked = True
        rdoOverviewOnlyExcel.Checked = True
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnOK.Click
        mOK = True
        Me.Hide()
    End Sub
End Class