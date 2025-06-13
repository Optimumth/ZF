Imports System.Windows.Forms

Public Class clsVScanMenu
#Region "Program Active"
    Private Sub clsVScanMenu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnShock.KeyUp, btnExit.KeyUp, btnAxle.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.D1 : AxleClick()
            Case Keys.D2 : ShockClick()

            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVScanMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnShock.Click, btnExit.Click, btnAxle.Click
        clsCLogin.ActiveDateTime = Now
        ActiveTimer.Enabled = False

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnAxle.Name : AxleClick()
                Case btnShock.Name : ShockClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If

        ActiveTimer.Enabled = True
    End Sub
#End Region
#Region "Call Function"
    Private Sub AxleClick()
        Dim frm As New clsVScanAxle
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub ShockClick()
        Dim frm As New clsVScanShock
        frm.ShowDialog()
        frm.Dispose()

    End Sub

    Private Sub ExitClick()
        Me.Close()
    End Sub
#End Region

    Private Sub ActiveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If clsCLogin.CheckActive = True Then Exit Sub

        ActiveTimer.Enabled = False
        If clsCLogin.ReLogin = True Then
            clsCLogin.ActiveDateTime = Now
            ActiveTimer.Enabled = True
        Else
            Application.Exit()
        End If
    End Sub
End Class