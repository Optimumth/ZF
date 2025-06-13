Imports System.Data
Imports System.IO
Imports ZF_PKCtrl.Barcode_System

Public Class clsCTruck
    Public Shared Function GetFreeRackQty() As Integer
        Try
            Dim sql As String = "Select * from PrgTrans Where [To]='" & clsCMove.Status_OnTruck & "' and TruckID=''"
            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)

            Return dt.Rows.Count

        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Shared Function GetTruckData() As DataTable
        Try
            Dim sql As String = "select TruckID,count(Rack) as RackQty from PrgTrans where [To]='" & clsCMove.Status_OnTruck & "' and TruckID<>'' group by TruckID order by TruckID"
            'Dim sql As String = "select TruckID,0 as RackQty from PrgTrans where [To]='" & clsCMove.Status_OnTruck & "' and TruckID<>''"
            'sql &= " union select TruckID,0 as RackQty from PrgTruckToday"
            'sql &= " order by TruckID"
            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)

            'Dim dtRack As DataTable = P_DB.getDataTable_CE("select TruckID,count(Rack) as RackQty from PrgTrans where [To]='" & clsCMove.Status_OnTruck & "' and TruckID<>'' group by TruckID")
            'For Each drRack As DataRow In dtRack.Select()
            '    Dim dtRows As Integer = dt.Rows.Count - 1
            '    For i As Integer = 0 To dtRows
            '        If dt.Rows(i)("TruckID").ToString = drRack("TruckID").ToString Then
            '            dt.Rows(i)("RackQty") = Convert.ToInt16(drRack("RackQty"))
            '        End If
            '    Next
            'Next

            Return dt

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function AddToTruck(ByVal sTruckID As String) As Boolean
        Dim sql As String = ""
        Dim sErr As String = ""
        P_DB.beginTransCE()
        Try
            If sTruckID = "" Then
                sTruckID = GetNewTruckID()

                sql = "insert into PrgTruckToday(TruckID) select '" & sTruckID & "'"
                P_DB.runSQLCE(sql, sErr)
                If sErr <> "" Then GoTo Err
            End If

            sql = "update PrgTrans set TruckID='" & sTruckID & "' Where [To]='" & clsCMove.Status_OnTruck & "' and TruckID=''"
            P_DB.runSQLCE(sql, sErr)
            If sErr <> "" Then GoTo Err

            P_DB.commitTransCE()
            Return True

        Catch ex As Exception
            GoTo Err
        End Try

        Exit Function

Err:
        P_DB.rollbackTransCE()
        Return False
    End Function

    Private Shared Function GetNewTruckID() As String
        'T220127-001
        Dim NewTruckID As String = ""
        Try
            Dim sql As String = "select max(TruckID) as MaxTruckID from PrgTruckToday where TruckID like '" & Format(Now(), "TyyMMdd") & "%'"
            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)
            If dt.Rows.Count = 0 Then
                P_DB.runSQLCE("delete from PrgTruckToday")
                NewTruckID = "T" & Format(Now(), "yyMMdd") & "-001"
            ElseIf dt.Rows(0)("MaxTruckID").ToString = "" Then
                P_DB.runSQLCE("delete from PrgTruckToday")
                NewTruckID = "T" & Format(Now(), "yyMMdd") & "-001"
            Else
                Dim MaxTruckID As String = dt.Rows(0)("MaxTruckID").ToString
                Dim iRunning As Integer = Convert.ToInt16(Right(MaxTruckID, 3)) + 1
                Dim sRunning As String = iRunning.ToString
                Select Case sRunning.Length
                    Case 1 : sRunning = "00" & sRunning
                    Case 2 : sRunning = "0" & sRunning
                End Select
                NewTruckID = "T" & Format(Now(), "yyMMdd") & "-" & sRunning
            End If

            Return NewTruckID

        Catch ex As Exception
            Return ""

        End Try
    End Function


End Class
