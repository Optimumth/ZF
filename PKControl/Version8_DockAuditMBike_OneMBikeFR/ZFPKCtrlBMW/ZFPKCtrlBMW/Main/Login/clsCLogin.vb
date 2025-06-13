Imports System.Data
Imports ZFPKCtrlBMW.Barcode_System
Imports System.Windows.Forms

Public Class clsCLogin
    Public Shared ActiveDateTime As DateTime
    Public Shared AutoLogoutMin As Integer = 0

    Public Shared Function CheckActive() As Boolean
        'User requested 1 hour
        If DateDiff(DateInterval.Minute, clsCLogin.ActiveDateTime, Now()) < AutoLogoutMin Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function ReLogin() As Boolean
        Dim frmLogin As New clsVLogin
        frmLogin.WindowState = FormWindowState.Normal
        If frmLogin.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function Login(ByVal staffcode As String) As Boolean
        'P_DB.runSQLCE("delete from prgtrucktoday")
        Dim dt As DataTable = GetStaff(staffcode)
        If dt Is Nothing Then
            Return False
            Exit Function
        ElseIf dt.Rows.Count = 0 Then
            Return False
            Exit Function
        Else
            P_Sys.StaffID = staffcode
            Return True
        End If
    End Function

    Public Shared Function GetStaff(ByVal StaffCode As String) As DataTable
        Try
            Dim sql As String = "Select * from MstStaff Where StaffCode='" & StaffCode & "'"

            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)

            Return dt

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetAutoLogoutMin() As Integer
        Dim dt As DataTable = P_DB.getDataTable_CE("select * from Config")
        If dt Is Nothing Then
            Return 0
            Exit Function
        ElseIf dt.Rows.Count = 0 Then
            Return 0
            Exit Function
        Else
            Dim dr As DataRow = dt.Rows(0)
            Return Convert.ToInt16(dr("AutoLogoutMin"))
            Exit Function
        End If
    End Function
End Class
