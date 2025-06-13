Imports System.Data
Imports System.IO
Imports ZFPKCtrlBMW.Barcode_System

Public Class clsCTruckDetail
    Public Shared Function GetPrgTruckToday(ByVal TruckID As String) As DataTable
        Try
            Dim sql As String = "Select * from PrgTruckToday Where TruckID='" & TruckID & "'"

            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)

            Return dt

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function SaveData(ByVal TruckID As String, ByVal sModel As String, ByVal sVarian As String _
                                   , ByVal sLot As String, ByVal sDeliveryNoteNo As String, ByVal sAxleNo As String) As Boolean
        P_DB.beginTransCE()
        If SaveDB(TruckID, sModel, sVarian, sLot, sDeliveryNoteNo, sAxleNo) = False Then
            P_DB.rollbackTransCE()
            Return False
        Else
            P_DB.commitTransCE()
            Return True
        End If
    End Function

    Private Shared Function SaveDB(ByVal TruckID As String, ByVal sModel As String, ByVal sVarian As String _
                                   , ByVal sLot As String, ByVal sDeliveryNoteNo As String, ByVal sAxleNo As String) As Boolean
        Try
            Dim sql As String = ""
            sql = " update PrgTruckToday set Model = '" & sModel & "'"
            sql = sql & " ,Varian = '" & sVarian & "'"
            sql = sql & " ,Lot = '" & sLot & "'"
            sql = sql & " ,DeliveryNoteNo = '" & sDeliveryNoteNo & "'"
            sql = sql & " ,AxleNo = '" & sAxleNo & "'"
            sql = sql & " where TruckID = '" & TruckID & "'"

            If P_DB.runSQLCE(sql) = False Then
                Return False
                Exit Function
            End If

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
