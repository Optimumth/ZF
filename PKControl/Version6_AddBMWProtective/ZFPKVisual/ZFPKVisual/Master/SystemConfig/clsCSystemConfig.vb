Imports OPE_Controls.OpeStyle

Public Class clsCSystemConfig
    Public Function MstSystemConfig() As DataTable
        Dim dt As DataTable = DataBase.DataSelect("MstSystemConfig")
        Return dt
    End Function

    Public Function Save(drSystemConfig As DataRow) As Boolean
        Dim sErr As String = ""

        DataBase.BeginTrans()

        If DataBase.DataUpdate("MstSystemConfig", drSystemConfig, sErr) = False Then GoTo NotSuccess

        DataBase.CommitTrans()

        With CustomizeSetting.INI
            .RackColumn = drSystemConfig("RackColumn")
            .AutoMBHr = drSystemConfig("AutoMBHr")
            .OutLogPath = drSystemConfig("OutlogFile")
            .ReportOutputPath = drSystemConfig("ReportPath")
            .RackStatusPassword = drSystemConfig("AuthorRackStatus")
        End With

        Return True

NotSuccess:
        MsgBox("Save Failed")
        DataBase.RollbackTrans()
        Return False
    End Function
End Class
