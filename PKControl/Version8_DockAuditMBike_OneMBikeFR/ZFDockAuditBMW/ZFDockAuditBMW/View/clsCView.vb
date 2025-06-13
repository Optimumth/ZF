Imports System.Data
Imports System.IO
Imports ZFDockAuditBMW.Barcode_System

Public Class clsCView
    Private Enum AxleShockStatus
        Axle = 1
        Shock = 2
    End Enum

    Private Enum eSearchType
        All = 0
        Incomplete = 1
        Completed = 2
    End Enum

    Private Enum CheckStatus
        NotUse = -1
        OK = 0
        NG = 1
    End Enum

    Public Shared Function GetData(ByVal iAxleShockStatus As Integer, ByVal SearchType As Integer) As DataTable
        Try
            Dim sql As String = ""
            sql = "select MstModelDock.ModelDock, PrgDockAudit.Barcode, CompleteFlag"
            sql &= "      , PrgDockAudit.Check1, PrgDockAudit.Check2, PrgDockAudit.Check3, PrgDockAudit.Check4, PrgDockAudit.Check5, PrgDockAudit.Check6, PrgDockAudit.Check7"
            sql &= " from MstModelDock"
            sql &= " inner join PrgDockAudit on MstModelDock.ModelDockID=PrgDockAudit.ModelDockID"
            sql &= " where AxleShock = " & iAxleShockStatus & ""

            Dim dt1 As DataTable = P_DB.getDataTable_CE(sql)
            Dim dt2 As New DataTable
            dt2.Columns.Add("ModelDock", GetType(String))
            dt2.Columns.Add("Barcode", GetType(String))
            dt2.Columns.Add("Completed", GetType(String))
            dt2.Columns.Add("Result1", GetType(String))
            dt2.Columns.Add("Result2", GetType(String))
            dt2.Columns.Add("Result3", GetType(String))
            dt2.Columns.Add("Result4", GetType(String))
            dt2.Columns.Add("Result5", GetType(String))
            dt2.Columns.Add("Result6", GetType(String))
            dt2.Columns.Add("Result7", GetType(String))

            Dim dtBarcode As New DataTable
            dtBarcode.Columns.Add("Barcode", GetType(String))
            Dim dupBarcode As String = ""
            For Each dr1 As DataRow In dt1.Select("", "Barcode")
                If dupBarcode <> dr1("Barcode").ToString Then
                    dupBarcode = dr1("Barcode").ToString
                    Dim drAdd As DataRow = dtBarcode.NewRow
                    drAdd("BarCode") = dr1("Barcode")
                    dtBarcode.Rows.Add(drAdd)
                End If
            Next
            
            For Each drBarcode As DataRow In dtBarcode.Select("", "Barcode")
                Dim fImport As Boolean = False
                If SearchType = eSearchType.All Then
                    fImport = True
                Else
                    Dim CompleteFlag As Boolean = False
                    For Each drchk As DataRow In dt1.Select("Barcode='" & drBarcode("Barcode").ToString & "' and CompleteFlag=1")
                        CompleteFlag = True
                        Exit For
                    Next
                    If SearchType = eSearchType.Incomplete And CompleteFlag = False Then
                        fImport = True
                    ElseIf SearchType = eSearchType.Completed And CompleteFlag = True Then
                        fImport = True
                    End If
                End If
                If fImport = True Then
                    For Each drImport As DataRow In dt1.Select("Barcode='" & drBarcode("Barcode").ToString & "'")
                        
                        Dim drAdd As DataRow = dt2.NewRow
                        drAdd("ModelDock") = drImport("ModelDock").ToString
                        drAdd("Barcode") = drImport("Barcode").ToString
                        If CInt(drImport("CompleteFlag")) = 0 Then
                            drAdd("Completed") = ""
                        Else
                            drAdd("Completed") = "Y"
                        End If
                        For iChk As Integer = 1 To 7
                            Dim sCheck As String = "Check" & iChk.ToString
                            Dim sResult As String = "Result" & iChk.ToString
                            If CInt(drImport(sCheck)) = CheckStatus.OK Then
                                drAdd(sResult) = "OK"
                            ElseIf CInt(drImport(sCheck)) = CheckStatus.NG Then
                                drAdd(sResult) = "NG"
                            Else
                                drAdd(sResult) = ""
                            End If
                        Next
                        dt2.Rows.Add(drAdd)
                    Next
                End If
            Next

            Return dt2
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
