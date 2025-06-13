Imports System.Windows.Forms

Public Class clsVMaintenanceMenu
#Region "Program Active"
    Private Sub clsVMaintenanceMenu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnConfig.KeyUp, btnImportMaster.KeyUp, btnExit.KeyUp
        clsCLogin.ActiveDateTime = Now
        ActiveTimer.Enabled = False
        Select Case e.KeyCode
            Case Keys.D1 : ConfigClick()
            Case Keys.D2 : ImportMasterData()
            Case Keys.Escape : ExitClick()
        End Select
        ActiveTimer.Enabled = True
        clsCLogin.ActiveDateTime = Now
    End Sub
    Private Sub clsVMaintenanceMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnConfig.Click, btnImportMaster.Click, btnExit.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnConfig.Name : ConfigClick()
                Case btnImportMaster.Name : ImportMasterData()
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
    Private Sub ImportMasterData()
        Dim frm As New clsVImportMasterData
        frm.ShowDialog()
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

    Private Sub clsVMaintenanceMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActiveTimer.Enabled = True
    End Sub
End Class