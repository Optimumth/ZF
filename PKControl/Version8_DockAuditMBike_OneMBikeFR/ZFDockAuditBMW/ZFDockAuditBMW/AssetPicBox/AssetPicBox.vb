Imports System.Data
Imports System.Windows.Forms
Imports ZFDockAuditBMW.Barcode_System

Public Class AssetPicBox
    Private MoveActiveDateTime As DateTime

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        OKClick()
    End Sub

    Private Sub btnNg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNg.Click
        ExitClick()
    End Sub

    Private Sub AssetPicBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp ', btnOK.KeyUp, btnNg.KeyUp
        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : OKClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub

    Private Sub AssetPicBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        MyBase.Focus()
    End Sub

    Private Sub OKClick()
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ExitClick()
        DialogResult = Windows.Forms.DialogResult.No
    End Sub
End Class
