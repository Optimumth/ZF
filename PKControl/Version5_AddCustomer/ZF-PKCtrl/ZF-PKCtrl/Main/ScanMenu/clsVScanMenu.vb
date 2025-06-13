Imports System.Windows.Forms

Public Class clsVScanMenu
#Region "Program Active"
    Private Sub clsVScanMenu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnMB.KeyUp, btnSup.KeyUp, btnExtWH.KeyUp, btnTruck.KeyUp, btnExit.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.D1 : MBClick()
            Case Keys.D2 : SupplierClick()
            Case Keys.D3 : ExtWHClick()
            Case Keys.D4 : TruckClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVScanMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnMB.Click, btnSup.Click, btnExtWH.Click, btnTruck.Click, btnExit.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnMB.Name : MBClick()
                Case btnSup.Name : SupplierClick()
                Case btnExtWH.Name : ExtWHClick()
                Case btnTruck.Name : TruckClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
#End Region
#Region "Call Function"
    Private Sub MBClick()
        Dim frm As New clsVMove
        frm.Text = "MB"
        frm.mScanType = clsVMove.eScanType.MB
        frm.ShowDialog()
    End Sub

    Private Sub SupplierClick()
        Dim frm As New clsVMove
        frm.Text = "Supplier"
        frm.mScanType = clsVMove.eScanType.Sup
        frm.ShowDialog()
    End Sub
    Private Sub ExtWHClick()
        Dim frm As New clsVMove
        frm.Text = "External Warehouse"
        frm.mScanType = clsVMove.eScanType.Ext
        frm.ShowDialog()
    End Sub
    Private Sub TruckClick()
        Dim frm As New clsVTruck
        frm.ShowDialog()
    End Sub
    Private Sub ExitClick()
        Me.Close()
    End Sub
#End Region
End Class