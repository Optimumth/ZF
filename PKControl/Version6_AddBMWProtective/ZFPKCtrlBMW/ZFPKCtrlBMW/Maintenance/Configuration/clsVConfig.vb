Imports System.Data
Imports ZFPKCtrlBMW.Barcode_System
Imports System.Windows.Forms

Public Class clsVConfig

#Region "Program Active"
    Private Sub clsVConfig_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, txtScanLimit.KeyUp, txtAutoMB.KeyUp, txtAutoLogout.KeyUp, btnSave.KeyUp, btnExit.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : SaveClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVConfig_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnSave.Click, btnExit.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnSave.Name : SaveClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
#End Region

    Private Sub clsVConfig_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = GetConfig()
        If dt Is Nothing Then
            Exit Sub
        ElseIf dt.Rows.Count = 0 Then
            Exit Sub
        Else
            Dim dr As DataRow = dt.Rows(0)
            txtScanLimit.Text = dr("ScanLimit").ToString
            txtAutoMB.Text = dr("AutoMB").ToString
            txtAutoLogout.Text = dr("AutoLogoutMin").ToString
        End If
    End Sub

    

#Region "Call Function"
    Private Sub SaveClick()
        If SaveValidate() = True Then
            Dim sql As String = "update [Config] "
            sql &= "set ScanLimit = " & Convert.ToInt16(txtScanLimit.Text.Trim) & ""
            sql &= ",AutoMB = " & Convert.ToInt16(txtAutoMB.Text.Trim) & ""
            sql &= ",AutoLogoutMin = " & Convert.ToInt16(txtAutoLogout.Text.Trim) & ""


            If P_DB.runSQLCE(sql) = False Then
                MessageBox.Show("Save Error")
            Else
                MessageBox.Show("Save Successfull")
            End If
        End If
    End Sub

    Private Sub ExitClick()
        Me.Close()
    End Sub

    Private Function GetConfig() As DataTable
        Try
            Dim sql As String = "Select * from Config"

            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)

            Return dt

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function SaveValidate() As Boolean
        If Not IsNumeric(txtScanLimit.Text.Trim) Then
            MessageBox.Show("Invalid Scan Limit")
            Return False
            Exit Function
        ElseIf Not IsNumeric(txtAutoMB.Text.Trim) Then
            MessageBox.Show("Invalid Auto MB")
            Return False
            Exit Function
        ElseIf Not IsNumeric(txtAutoLogout.Text.Trim) Then
            MessageBox.Show("Invalid Auto Logout")
            Return False
            Exit Function
        End If

        Return True
    End Function
#End Region

    
End Class