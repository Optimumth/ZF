Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCMstHoliday
    Public Function GetData(chkSMonth As Boolean, sMonth As Integer, sYear As Integer) As DataTable

        Dim cond As String = "1=1"
        If chkSMonth = True Then
            cond &= " and month(Holiday)=" & sMonth & " and year(Holiday)=" & sYear & ""
        End If
        
        Dim dt As DataTable = DataBase.DataSelect("MstHoliday" _
                                                  , cond _
                                                  , , , "MstHoliday.*")
        Return dt
    End Function

    Public Function SaveData(dt As DataTable) As Boolean
        For Each dr As DataRow In dt.Select()
            Select Case dr("_Status")
                Case "N"
                    DataBase.DataInsert("MstHoliday", dr)
                Case "D"
                    DataBase.DataDelete("MstHoliday", dr)
            End Select
        Next

        Return True
    End Function
End Class
