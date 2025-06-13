Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class clsVMainDockAudit
#Region "Program Active"
    Private Sub clsVMainDockAudit_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnScan.KeyUp, btnReview.KeyUp, btnSync.KeyUp, btnExit.KeyUp
        clsCLogin.ActiveDateTime = Now
        Select Case e.KeyCode
            Case Keys.D1 : ScanClick()
            Case Keys.D2 : ReviewClick()
            Case Keys.D3 : SyncClick()

            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVMainDockAudit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnScan.Click, btnReview.Click, btnSync.Click, btnExit.Click
        clsCLogin.ActiveDateTime = Now
        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnScan.Name : ScanClick()
                Case btnReview.Name : ReviewClick()
                Case btnSync.Name : SyncClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
    Private Sub ActiveTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ActiveTimer.Tick
        If clsCLogin.CheckActive = True Then Exit Sub

        ActiveTimer.Enabled = False
        If clsCLogin.ReLogin = True Then
            clsCLogin.ActiveDateTime = Now
        Else
            Application.Exit()
        End If
        ActiveTimer.Enabled = True
    End Sub
#End Region

    Private Sub clsVMainDockAudit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActiveTimer.Enabled = False
        Dim frmLogin As New clsVLogin
        frmLogin.WindowState = FormWindowState.Normal
        If frmLogin.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Application.Exit()
        End If
        ActiveTimer.Enabled = True
        clsCLogin.ActiveDateTime = Now
    End Sub

#Region "Call Function"
    Private Sub ScanClick()
        Dim frm As New clsVScanMenu
        frm.ShowDialog()
    End Sub

    Private Sub ReviewClick()
        Dim frm As New clsVViewMenu
        frm.ShowDialog()
    End Sub

    Private Sub SyncClick()
        If clsCMain.chkTruck = True Then
            Dim frm As New clsVRackSync
            frm.ShowDialog()
        Else
            MsgBox("Please entry TruckID")
        End If
    End Sub

    Private Sub ExitClick()
        Application.Exit()
        'Me.Close()
    End Sub
#End Region

End Class

