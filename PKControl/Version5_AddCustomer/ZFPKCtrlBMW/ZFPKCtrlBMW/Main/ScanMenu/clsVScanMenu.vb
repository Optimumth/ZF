Imports System.Windows.Forms

Public Class clsVScanMenu
#Region "Program Active"
    Private Sub clsVScanMenu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnBMW.KeyUp, btnSup.KeyUp, btnExtWH.KeyUp, btnTruck.KeyUp, btnExit.KeyUp, btnFG.KeyUp, btnRepairInZF.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.D1 : BMWClick()
            Case Keys.D2 : SupplierClick()
            Case Keys.D3 : ExtWHClick()
            Case Keys.D4 : RepainInZFClick()
            Case Keys.D5 : FGClick()
            Case Keys.D6 : TruckClick()

            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVScanMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnBMW.Click, btnSup.Click, btnExtWH.Click, btnTruck.Click, btnExit.Click, btnRepairInZF.Click, btnFG.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnBMW.Name : BMWClick()
                Case btnSup.Name : SupplierClick()
                Case btnExtWH.Name : ExtWHClick()
                Case btnTruck.Name : TruckClick()
                Case btnFG.Name : FGClick()
                Case btnRepairInZF.Name : RepainInZFClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
#End Region
#Region "Call Function"
    Private Sub BMWClick()
        Dim frm As New clsVMove
        frm.Text = "BMW"
        frm.mScanType = clsVMove.eScanType.BMW
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
    Private Sub FGClick()
        Dim frm As New clsVMove
        frm.Text = "FG"
        frm.mScanType = clsVMove.eScanType.FG
        frm.ShowDialog()
    End Sub
    Private Sub RepainInZFClick()
        Dim frm As New clsVMove
        frm.Text = "Repair in ZF"
        frm.mScanType = clsVMove.eScanType.RepainInZF
        frm.ShowDialog()
    End Sub
    Private Sub ExitClick()
        Me.Close()
    End Sub
#End Region
End Class