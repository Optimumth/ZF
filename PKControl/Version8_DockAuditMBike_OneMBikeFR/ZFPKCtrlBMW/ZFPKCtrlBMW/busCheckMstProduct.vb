Imports System.Data
Imports ZFPKCtrlBMW.Barcode_System

Public Class busCheckMstProduct
    '  Private SoundEff As New SoundEff
    Public Shared Function Test() As Boolean
        Dim sql As String = "Select ItemCode from MstItem where 1=1"
        Dim dt As DataTable = P_DB.getDataTable_CE(sql)
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function
    

End Class
