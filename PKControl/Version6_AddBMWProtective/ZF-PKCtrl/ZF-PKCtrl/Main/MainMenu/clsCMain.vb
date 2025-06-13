Imports System.Data
Imports System.IO
Imports ZF_PKCtrl.Barcode_System

Public Class clsCMain
    Public Shared Function chkTruck() As Boolean
        Try
            Dim sql As String = "Select * from PrgTrans Where [To]='" & clsCMove.Status_OnTruck & "' and TruckID=''"

            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)

            If dt.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
