Imports System.Data
Imports ZFPKCtrlBMW.Barcode_System
Imports System.IO
Public Class Conn
    Public Sub ConnectDBWinCE()
        P_DB.ConnStr1 = "Data Source =" & System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName().CodeBase) & "\BMW.sdf "
        P_DB.runningDBCE()
    End Sub





End Class
