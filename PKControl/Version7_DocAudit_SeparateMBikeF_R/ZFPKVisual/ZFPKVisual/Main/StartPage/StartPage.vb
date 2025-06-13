Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class StartPage
#Region " Cancel "
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Application.Exit()
    End Sub
#End Region

#Region "Enter"
    Private Sub btnMB_Click(sender As System.Object, e As System.EventArgs) Handles btnMB.Click
        CustomizeSetting.CustomerCode = "MB"
        Login()
    End Sub

    Private Sub btnBMW_Click(sender As System.Object, e As System.EventArgs) Handles btnBMW.Click
        CustomizeSetting.CustomerCode = "BMW"
        Login()
    End Sub
    Private Sub Login()
        Me.Hide()
        Dim frm As New Login
        frm.ShowDialog()
        Me.Show()
    End Sub
#End Region
End Class
