Imports System.Data
Imports ZF_PKCtrl.Barcode_System
Imports System.IO
Public Class Conn
    Public Sub ConnectDBWinCE()
        P_DB.ConnStr1 = "Data Source =" & System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName().CodeBase) & "\PKCtrl.sdf "
        P_DB.runningDBCE()
    End Sub





End Class
