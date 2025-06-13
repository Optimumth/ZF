Imports OPE_Controls.OpeStyle

Public Class clsCStaff
    Public Function GetScreenData(Optional ByVal StaffId As String = "", Optional ByVal LoginId As String = "", _
                                  Optional ByVal SurName As String = "", Optional ByVal GivenName As String = "", _
                                  Optional ByVal NickName As String = "", _
                                  Optional ByVal GroupName As String = "", Optional ByVal chk As Boolean = False) As DataTable
        Dim sSel As String = String.Format( _
            "MstU.*, {0}GetUserNickName(MstU.CreateUser) as CreateUserName, {0}GetUserNickName(MstU.UpdateUser) as UpdateUserName" & vbCrLf & _
            "      , MstS3.TitleName, MstS5.StaffGroupName", _
            IIf(OPE_Controls.OpeStyle.DataBase.DB_Type = OPE_Controls.Util.DBUtil.eDBType.MySql, "", "dbo."))
        Dim sFrom As String = _
            "MstStaff MstU" & vbCrLf & _
            "Left Join CstTitle MstS3 on MstU.TitleCode= MstS3.TitleCode" & vbCrLf & _
            "Left Join MstStaffGroup MstS5 on MstU.StaffGroupCode= MstS5.StaffGroupCode"

        Dim sWhere As String = "MstU.DelFlag=0 "
        If StaffId.Trim <> "" Then sWhere &= " AND MstU.StaffCode like '" & StaffId.Replace("*", "%") & "'"
        If LoginId.Trim <> "" Then sWhere &= " AND MstU.LoginId like '" & LoginId.Replace("*", "%") & "'"
        If SurName.Trim <> "" Then sWhere &= " AND MstU.SurName like '" & SurName.Replace("*", "%") & "'"
        If GivenName.Trim <> "" Then sWhere &= " AND MstU.GivenName like '" & GivenName.Replace("*", "%") & "'"
        If GroupName.Trim <> "" Then sWhere &= " AND MstS5.StaffGroupName like '" & GroupName.Replace("*", "%") & "'"

        Dim dt As New DataTable
        OPE_Controls.OpeStyle.DataBase.getData(sSel, sFrom, sWhere, "MstU.StaffCode", dt)
        Return dt
    End Function

    Public Function SaveData(ByVal dt As DataTable) As Boolean
        Dim sERR As String = ""
        For Each dr As DataRow In dt.Rows
            Select Case dr("StaGrd").ToUpper
                Case "N"
                    Dim dtNew As DataTable = DataBase.DataSelect("MstStaff", , , , "isnull(max(StaffID),0) as LastID")
                    dr("StaffID") = dtNew.Rows(0)("LastID") + 1
                    dr("UpdateDate") = CustomizeSetting.SystemDate
                    dr("DelFlag") = 0
                    If Not OPE_Controls.OpeStyle.DataBase.DataInsertUpdate("MstStaff", dr, sERR) Then GoTo Exit_FN
                    dr("StaGrd") = ""

                Case "U"
                    dr("UpdateDate") = CustomizeSetting.SystemDate
                    dr("DelFlag") = 0
                    If Not OPE_Controls.OpeStyle.DataBase.DataInsertUpdate("MstStaff", dr, sERR) Then GoTo Exit_FN
                    dr("StaGrd") = ""

                Case "D"
                    dr("UpdateDate") = CustomizeSetting.SystemDate
                    dr("DelFlag") = 1
                    If Not OPE_Controls.OpeStyle.DataBase.DataUpdate("MstStaff", dr, sERR) Then GoTo Exit_FN

            End Select
        Next
        Return True
Exit_FN:
        OPE_Controls.OpeStyle.Messages.SaveLogFile("Staff Master", sERR, True)
        Return False
    End Function

    Public Sub DeletePrgLogging()
        DataBase.runSQL("delete from prglogging")
    End Sub
End Class
