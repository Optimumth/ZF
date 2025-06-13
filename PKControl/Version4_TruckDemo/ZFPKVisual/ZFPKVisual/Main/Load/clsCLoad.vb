Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsCLoad
#Region " Load "
    Public Sub LoadIni()
        Application.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en-US")
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim Err As New ZFPKVisual.EventArgs

        Messages.LogFile = Info.ProjectPath & "\LogError\"
        Dim oINI As ArrayList = ComboSet.ReadTextFileList(Err, Info.ProjectPath & "\Config.INI")
        If oINI Is Nothing Then GoTo CloseApp
        For Each sINI As String In oINI
            Dim aINI() As String = sINI.Split("=")
            If aINI.Length <> 2 Then Continue For
            Select Case aINI(0).Trim.ToLower
                Case "server" : INI.Server = aINI(1).Trim
                Case "dbname" : INI.DBName = aINI(1).Trim
                Case "username" : INI.UserName = aINI(1).Trim
                Case "password" : INI.Password = aINI(1).Trim
                Case "rackcolumn" : INI.RackColumn = aINI(1).Trim
                Case "autombhr" : INI.AutoMBHr = aINI(1).Trim
                Case "mstfilename" : INI.MstFilename = aINI(1).Trim
                Case "handyinterface" : INI.HandyInterface = aINI(1).Trim
            End Select
        Next
        oINI = Nothing
        DataBase.DB_Type = OPE_Controls.Util.DBUtil.eDBType.SqlServer
        DataBase.DBName = INI.DBName
        DataBase.ConnString1 = String.Format("Server={0};Database={1};uid={2};pwd={3}", INI.Server, INI.DBName, INI.UserName, INI.Password)
        If Not DataBase.openDB(, False) Then
            Err.Message = "Connection To Server [" & INI.Server & "] Error Plese Check Config File"
            GoTo CloseApp
        End If
        RunSetting()

        Dim rLogin As DataRow = DataBase.DataRow("MstStaff", String.Format("LoginID = '{0}' And Password = '{1}'", "admin", "admin"))
        If rLogin IsNot Nothing Then
            StaffID = rLogin("StaffID")
            LoginID = rLogin("LogInID")
            StaffName = rLogin("GivenName") & "  " & rLogin("Surname")
            StaffNickName = rLogin("NickName")
            Dim iUserGroup As Integer = rLogin("StaffGroupCode")
            Dim frmM As New MainFormMDI
            With frmM
                .StaffName = LoginID
                Language.CurrentLanguage = ""
                .WindowState = FormWindowState.Maximized
                .DBName = INI.DBName
                .showForm(iUserGroup)
            End With
        End If

        Exit Sub
CloseApp:
        Application.Exit()
    End Sub
#End Region
End Class
