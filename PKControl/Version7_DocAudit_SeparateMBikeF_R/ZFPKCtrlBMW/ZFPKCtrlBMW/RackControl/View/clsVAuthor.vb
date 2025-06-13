Imports System.Windows.Forms

Public Class clsVAuthor

    Private Sub clsVView_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnSave.KeyUp, btnExit.KeyUp, txtPassword.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : OK()
            Case Keys.Escape : Cancel()
        End Select
    End Sub

    Private Sub clsVView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnSave.Click, btnExit.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnSave.Name : OK()
                Case btnExit.Name : Cancel()
            End Select
        End If
    End Sub

    Private Sub clsVAuthor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.Focus()
    End Sub

    Private Sub OK()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub Cancel()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class