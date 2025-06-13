Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVContainerHandling

    Private Sub OpeButtonPrint1_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles OpeButtonPrint1.Click
        Dim ctl As New clsCPrint
        ctl.Print()
    End Sub

    Private Sub clsVContainerHandling_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If
    End Sub
End Class