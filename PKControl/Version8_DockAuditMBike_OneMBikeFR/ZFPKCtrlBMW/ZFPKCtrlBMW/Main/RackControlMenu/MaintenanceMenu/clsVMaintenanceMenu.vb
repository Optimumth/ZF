Imports System.Windows.Forms

Public Class clsVMaintenanceMenu
#Region "Program Active"
    Private Sub clsVMaintenanceMenu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnConfig.KeyUp, btnResetPassword.KeyUp, btnStaff.KeyUp, btnExit.KeyUp
        clsCLogin.ActiveDateTime = Now
        Select Case e.KeyCode
            Case Keys.D1 : ConfigClick()
            Case Keys.D2 : RetsetPassClick()
            Case Keys.D3 : ImportStaffClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVMaintenanceMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnConfig.Click, btnResetPassword.Click, btnStaff.Click, btnExit.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnConfig.Name : ConfigClick()
                Case btnResetPassword.Name : RetsetPassClick()
                Case btnStaff.Name : ImportStaffClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
#End Region

#Region "Click"
    Private Sub ConfigClick()
        Dim frm As New clsVConfig
        frm.ShowDialog()
    End Sub
    Private Sub RetsetPassClick()
        Dim frm As New clsVResetPassword
        frm.ShowDialog()
    End Sub
    Private Sub ImportStaffClick()
        Dim frm As New clsVImportStaff
        frm.ShowDialog()
    End Sub
    Private Sub ExitClick()
        Me.Close()
    End Sub
#End Region
End Class