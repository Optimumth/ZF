Imports System.Data
Imports System.IO
Imports ZFDockAuditBMW.Barcode_System

Public Class clsCScanShock
    Public Shared Function CheckPrgCompleted(ByVal Barcode As String) As Boolean
        Try
            Dim Ret As Boolean
            Dim sql As String = Strings.Format( _
            "select CompleteFlag " & _
            " from PrgDockAudit " & _
            " where Barcode='" & Barcode & "'" & _
            "       and CompleteFlag=1")

            Dim dt As DataTable = P_DB.getDataTable_CE(sql)
            If dt.Rows.Count = 0 Then
                Ret = False
            Else
                Ret = True
            End If

            Return Ret
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function GetModelDock(ByVal ModelRack As String, ByVal AreaCode As String) As DataTable
        Try
            Dim sql As String = "select ModelDock from MstModelDock where ModelRack='" & ModelRack & "' and AreaCode='" & AreaCode & "'"

            Dim dt1 As DataTable
            dt1 = P_DB.getDataTable_CE(sql)

            Dim dt2 As DataTable = dt1.Clone
            Dim strDup As String = ""
            For Each dr As DataRow In dt1.Select("", "ModelDock")
                If strDup <> dr("ModelDock").ToString Then
                    strDup = dr("ModelDock").ToString
                    dt2.ImportRow(dr)
                End If
            Next

            Return dt2

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
