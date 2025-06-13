Imports System.Data
Imports System.IO
Imports ZFDockAuditBMW.Barcode_System

Public Class clsCScanAxle
    Public Shared Function GetMstItem(ByVal Rack As String, ByVal Remark As String, ByVal Model As String, ByVal Code As String, ByVal Running As String) As DataTable
        Try

            Dim sql As String = "Select * from MstItem Where Rack='" & Rack & "' and Remark='" & Remark & "' and Model='" & Model & "' and Code='" & Code & "' and Running='" & Running & "'"

            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)

            Return dt

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetModelDock(ByVal ModelRack As String) As DataTable
        Try
            Dim sql As String = "select ModelDock from MstModelDock where ModelRack='" & ModelRack & "'"

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

    Public Shared Function tbModelDock(ByVal ModelRack As String, ByVal ModelDock As String, ByVal AreaCode As String) As DataTable
        Try
            Dim sql As String = Strings.Format( _
            "select ModelDockID,Check1,Check2,Check3,Check4,Check5,Check6,Check7 " & _
            " from MstModelDock " & _
            " where ModelRack='" & ModelRack & "'" & _
            "       and ModelDock='" & ModelDock & "'" & _
            "       and AreaCode='" & AreaCode & "'")

            Dim dt As DataTable = P_DB.getDataTable_CE(sql)

            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function CheckPrgCompleted(ByVal RackDTID As Integer, ByVal ModelDockID As Integer _
                                          , ByVal Varian As String, ByVal Lot As String, ByVal AxleNo As String, ByVal Side As String _
                                          , ByVal AxleShock As Integer) As Boolean
        Try
            Dim Ret As Boolean
            Dim sql As String = Strings.Format( _
            "select CompleteFlag " & _
            " from PrgDockAudit " & _
            " where RackDTID=" & RackDTID & "" & _
            "       and ModelDockID=" & ModelDockID & "" & _
            "       and Varian='" & Varian & "'" & _
            "       and Lot='" & Lot & "'" & _
            "       and AxleNo='" & AxleNo & "'" & _
            "       and Side='" & Side & "'" & _
            "       and AxleShock=" & AxleShock & "" & _
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
End Class
