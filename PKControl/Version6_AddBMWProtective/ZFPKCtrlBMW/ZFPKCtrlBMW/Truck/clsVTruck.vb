Imports System.Data
Imports System.Windows.Forms
Imports ZFPKCtrlBMW.Barcode_System

Public Class clsVTruck
    Private dtGrid As DataTable = Nothing


#Region "Program Active"

    Private Sub grdData_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdData.CurrentCellChanged
        ShowOldTruck()
    End Sub
    Private Sub clsVTruck_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnExit.KeyUp, grdData.KeyUp, txtFreeRackQty.KeyUp, btnNewTruk.KeyDown, btnOldTruck.KeyUp, btnTruckDetail.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVTruck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click, grdData.Click, btnNewTruk.Click, btnOldTruck.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnExit.Name : ExitClick()
                Case btnNewTruk.Name
                    If btnNewTruk.Enabled = True Then
                        AddToNewTruck()
                    End If
                Case btnOldTruck.Name
                    If btnOldTruck.Enabled = True Then
                        AddToOldTruck()
                    End If
            End Select
        End If
    End Sub
#End Region

#Region "Call Function"
    Private Sub AddToNewTruck()
        If Convert.ToInt16(txtFreeRackQty.Text) = 0 Then Exit Sub
        If MessageBox.Show("Add to new truck?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            If clsCTruck.AddToTruck("") = True Then
                Dim iFreeRackQty As Integer = clsCTruck.GetFreeRackQty
                txtFreeRackQty.Text = iFreeRackQty.ToString

                dtGrid = clsCTruck.GetTruckData
                dtGrid.TableName = "Transaction"
                grdData.DataSource = dtGrid
            End If
        Else
            grdData.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub AddToOldTruck()
        If btnOldTruck.Text = "" Then Exit Sub
        If MessageBox.Show("Add to truck '" & btnOldTruck.Text.Trim & "' ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            If clsCTruck.AddToTruck(btnOldTruck.Text.Trim) = True Then
                Dim iFreeRackQty As Integer = clsCTruck.GetFreeRackQty
                txtFreeRackQty.Text = iFreeRackQty.ToString

                dtGrid = clsCTruck.GetTruckData
                dtGrid.TableName = "Transaction"
                grdData.DataSource = dtGrid
            End If
        Else
            grdData.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ExitClick()
        CloseForm()
    End Sub
#End Region

    Private Sub clsVTruck_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim iFreeRackQty As Integer = clsCTruck.GetFreeRackQty
            txtFreeRackQty.Text = iFreeRackQty.ToString

            dtGrid = clsCTruck.GetTruckData
            dtGrid.TableName = "Transaction"
            grdData.DataSource = dtGrid

            Dim col0 As New DataGridTextBoxColumn
            col0.MappingName = "TruckID"
            col0.HeaderText = "Truck ID"
            col0.Width = 250

            Dim col1 As New DataGridTextBoxColumn
            col1.MappingName = "RackQty"
            col1.HeaderText = "Rack Qty"
            col1.Width = 100

            Dim GridTBStyle As New DataGridTableStyle
            GridTBStyle.MappingName = "Transaction"
            With GridTBStyle.GridColumnStyles
                .Add(col0)
                .Add(col1)
            End With
            grdData.TableStyles.Add(GridTBStyle)

            ShowOldTruck()
            If clsCTruck.CheckPTC = True Then
                btnNewTruk.Enabled = True
                btnOldTruck.Enabled = True
            Else
                btnNewTruk.Enabled = False
                btnOldTruck.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ShowOldTruck()
        If grdData.DataSource Is Nothing Then Exit Sub
        If grdData.CurrentRowIndex < 0 Then Exit Sub

        btnOldTruck.Text = Convert.ToString(grdData(grdData.CurrentRowIndex, 0))
    End Sub

    Private Sub CloseForm()
        Me.Close()
    End Sub


    Private Sub btnTruckDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruckDetail.Click
        If btnOldTruck.Text.Trim = "" Then
            MessageBox.Show("Please select Truck before")
        Else
            Dim frm As New clsVTruckdetail
            frm.TruckID = btnOldTruck.Text.Trim

            frm.ShowDialog()
        End If
    End Sub
End Class