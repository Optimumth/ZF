Imports System.Data
Imports System.IO
Imports ZFPKCtrlBMW.Barcode_System

Public Class clsCMove
    Public Shared Status_ZF As String = "ZF"
    Public Shared Status_BMW As String = "BMW"
    Public Shared Status_OnTruck As String = "On Truck"
    Public Shared Status_Supplier As String = "Supplier"
    Public Shared Status_ExtWH As String = "Ext WH"
    Public Shared Status_FG As String = "FG"
    Public Shared Status_RepairInZF As String = "Repair in ZF"

    Public Shared Function GetPrgTrans(ByVal ScanType As Integer, ByVal RackDTID As Integer) As DataTable
        Try
            Dim sql As String = "Select * from PrgTrans Where 1=1"
            If ScanType <> 0 Then sql &= " and ScanType=" & ScanType & ""
            If RackDTID <> 0 Then sql &= " and RackDTID=" & RackDTID & ""

            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)

            Return dt

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    
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
    Public Shared Function GetScanLimit() As Integer
        Try
            Dim sql As String = "select * from Config"

            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)
            Dim dr As DataRow = dt.Rows(0)

            Return Convert.ToInt16(dr("ScanLimit"))

        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Shared Function GetAutoMB() As Integer
        Try
            Dim sql As String = "select * from Config"

            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)
            Dim dr As DataRow = dt.Rows(0)

            Return Convert.ToInt16(dr("AutoMB"))

        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Shared Function GetPassword() As String
        Try
            Dim sql As String = "select * from Config"

            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)
            Dim dr As DataRow = dt.Rows(0)

            Return Convert.ToString(dr("Password"))

        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Shared Function GetTransRec() As Integer
        Try
            Dim sql As String = "select * from PrgTrans"

            Dim dt As DataTable
            dt = P_DB.getDataTable_CE(sql)
            Dim cTrans As Integer = dt.Rows.Count

            Return cTrans

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Public Shared Function SaveData(ByVal dt As DataTable, ByVal ScanType As Integer) As Boolean
        P_DB.beginTransCE()
        If SaveDB(dt, ScanType) = False Then
            P_DB.rollbackTransCE()
            Return False
        Else
            P_DB.commitTransCE()
            Return True
        End If
    End Function

    Private Shared Function SaveDB(ByVal dt As DataTable, ByVal ScanType As Integer) As Boolean
        Try
            For Each dr As DataRow In dt.Select("", "ID")
                Dim sql As String = ""
                sql = "insert into PrgTrans (ScanType,Rack,Remark,Model,Code,Running,ScanDateTime,[From],[To],ID,RackDTID,StaffCode,TruckID)"
                sql = sql & " select " & ScanType & ""
                sql = sql & ",'" & dr("Rack").ToString & "'"
                sql = sql & ",'" & dr("Remark").ToString & "'"
                sql = sql & ",'" & dr("Model").ToString & "'"
                sql = sql & ",'" & dr("Code").ToString & "'"
                sql = sql & ",'" & dr("Running").ToString & "'"
                sql = sql & ",'" & Format(dr("ScanDateTime"), "yyyy-MM-dd HH:mm:ss") & "'"
                sql = sql & ",'" & dr("From").ToString & "'"
                sql = sql & ",'" & dr("To").ToString & "'"
                sql = sql & "," & dr("ID").ToString & ""
                sql = sql & "," & dr("RackDTID").ToString & ""
                sql = sql & ",'" & dr("StaffCode").ToString & "'"
                sql = sql & ",''"

                If P_DB.runSQLCE(sql) = False Then
                    Return False
                    Exit Function
                End If
                sql = "update MstItem set [Current]='" & dr("To").ToString & "'"
                sql = sql & " where RackDTID=" & dr("RackDTID").ToString & ""

                If P_DB.runSQLCE(sql) = False Then
                    Return False
                    Exit Function
                End If
            Next

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
