Imports System.Windows.Forms

Public Class clsVViewMenu
#Region "Program Active"
    Private Sub clsVViewMenu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnMB.KeyUp, btnSup.KeyUp, btnExtWH.KeyUp, btnAll.KeyUp, btnExit.KeyUp, btnRepairInZF.KeyUp, btnFG.KeyUp
        clsCLogin.ActiveDateTime = Now

        clsCLogin.ActiveDateTime = Now
        Select Case e.KeyCode
            Case Keys.D1 : BMWClick()
            Case Keys.D2 : SupplierClick()
            Case Keys.D3 : ExtWHClick()
            Case Keys.D4 : RepairInZFClick()
            Case Keys.D5 : FGClick()
            Case Keys.D6 : AllStatusClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVViewMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnMB.Click, btnSup.Click, btnExtWH.Click, btnAll.Click, btnExit.Click, btnFG.Click, btnRepairInZF.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnMB.Name : BMWClick()
                Case btnSup.Name : SupplierClick()
                Case btnExtWH.Name : ExtWHClick()
                Case btnRepairInZF.Name : RepairInZFClick()
                Case btnFG.Name : FGClick()
                Case btnAll.Name : AllStatusClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
#End Region

#Region "Call Function"
    Private Sub BMWClick()
        Dim frm As New clsVView
        frm.Text = "BMW"
        frm.mScanType = clsVMove.eScanType.BMW
        frm.ShowDialog()
    End Sub
    Private Sub SupplierClick()
        Dim frm As New clsVView
        frm.Text = "Supplier"
        frm.mScanType = clsVMove.eScanType.Sup
        frm.ShowDialog()
    End Sub
    Private Sub ExtWHClick()
        Dim frm As New clsVView
        frm.Text = "External Warehouse"
        frm.mScanType = clsVMove.eScanType.Ext
        frm.ShowDialog()
    End Sub
    Private Sub RepairInZFClick()
        Dim frm As New clsVView
        frm.Text = "Repair in ZF"
        frm.mScanType = clsVMove.eScanType.RepainInZF
        frm.ShowDialog()
    End Sub
    Private Sub FGClick()
        Dim frm As New clsVView
        frm.Text = "FG"
        frm.mScanType = clsVMove.eScanType.FG
        frm.ShowDialog()
    End Sub
    Private Sub AllStatusClick()
        Dim frm As New clsVView
        frm.Text = "All Status"
        frm.mScanType = clsVMove.eScanType.All
        frm.ShowDialog()
    End Sub
    Private Sub ExitClick()
        Me.Close()
    End Sub
#End Region

End Class