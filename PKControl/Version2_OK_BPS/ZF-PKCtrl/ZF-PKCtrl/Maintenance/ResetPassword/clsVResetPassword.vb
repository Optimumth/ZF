Imports System.Data
Imports ZF_PKCtrl.Barcode_System
Imports System.Windows.Forms

Public Class clsVResetPassword
    Private CurPassword As String = ""

#Region "Program Active"
    Private Sub clsVResetPassword_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, txtCurPassword.KeyUp, txtNewPassword.KeyUp, txtConfirmNew.KeyUp, btnExit.KeyUp, btnSave.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : SaveClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVResetPassword_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click, btnSave.Click
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

#Region "Call Function"
    Private Sub SaveClick()
        If SaveValidate() = True Then
            Dim sql As String = "update [Config] "
            sql &= "set [Password] = " & Convert.ToInt16(txtNewPassword.Text.Trim) & ""

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
#End Region


    Private Sub clsVResetPassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable = GetConfig()
        If dt Is Nothing Then
            Exit Sub
        ElseIf dt.Rows.Count = 0 Then
            Exit Sub
        Else
            Dim dr As DataRow = dt.Rows(0)
            CurPassword = dr("Password").ToString
        End If
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
        If txtNewPassword.Text.Trim = "" Then
            MessageBox.Show("Please entry New Password")
            Return False
            Exit Function
        ElseIf txtConfirmNew.Text.Trim = "" Then
            MessageBox.Show("Please entry Confirm New Password")
            Return False
            Exit Function
        ElseIf txtCurPassword.Text.Trim <> CurPassword Then
            MessageBox.Show("Invalid Current Password")
            Return False
            Exit Function
        ElseIf txtNewPassword.Text.Trim <> txtConfirmNew.Text.Trim Then
            MessageBox.Show("Invalid Confirm New Password")
            Return False
            Exit Function
        End If

        Return True
    End Function
End Class