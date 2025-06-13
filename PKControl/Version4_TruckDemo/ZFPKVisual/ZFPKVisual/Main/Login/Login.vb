Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class Login
#Region " Load "
    Public Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Application.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en-US")
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim Err As New ZFPKVisual.EventArgs
        Me.Cursor = Cursors.WaitCursor
        Messages.LogFile = Info.ProjectPath & "\LogError\"
        Dim oINI As ArrayList = ComboSet.ReadTextFileList(Err, Info.ProjectPath & "\Config.INI")
        If oINI Is Nothing Then GoTo CloseApp
        For Each sINI As String In oINI
            Dim aINI() As String = sINI.Split("=")
            If aINI.Length <> 2 Then Continue For
            Select Case aINI(0).Trim.ToLower
                Case "server" : INI.Server = aINI(1).Trim
                    'Case "dbname" : INI.DBName = aINI(1).Trim
                Case "username" : INI.UserName = aINI(1).Trim
                Case "password" : INI.Password = aINI(1).Trim
                    'Case "mstfilename" : INI.MstFilename = aINI(1).Trim
                    'Case "stafffilename" : INI.StaffFilename = aINI(1).Trim
                    'Case "handyinterface" : INI.HandyInterface = aINI(1).Trim

            End Select
        Next
        oINI = Nothing
        INI.DBName = "PKCtrlDemo"
        INI.MstFilename = "\mst.txt"
        INI.StaffFilename = "\staff.txt"
        INI.HandyInterface = "/Program Files/ZF-PKCtrl/Interface"

        DataBase.DB_Type = OPE_Controls.Util.DBUtil.eDBType.SqlServer
        DataBase.DBName = INI.DBName
        DataBase.ConnString1 = String.Format("Server={0};Database={1};uid={2};pwd={3}", INI.Server, INI.DBName, INI.UserName, INI.Password)
        If Not DataBase.openDB(, False) Then
            Err.Message = "Connection To Server [" & INI.Server & "] Error Plese Check Config File"
            GoTo CloseApp
        End If
        RunSetting()

        Dim dtTrans As DataTable = DataBase.DataSelect("PrgTransaction", "UpdateDate>='2022-09-14'", , , "min(UpdateDate) as UpdateDate")
        If Converts.ToStr(dtTrans.Rows(0)("UpdateDate")) <> "" Then
            Dim CompareDate As Date = SystemDate.Date
            If DateAdd(DateInterval.Month, 1, dtTrans.Rows(0)("UpdateDate")) < CompareDate Then
                MsgBox("Demo Expired")
                End
            End If
        End If

        txtUserName.Text = "Demo"
        txtPassword.Text = "1234"

        Me.Cursor = Cursors.Default
        Exit Sub
CloseApp:
        Me.Cursor = Cursors.Default
        If Err.Message.Length > 0 Then Messages.ShowWarning(OPE_Controls.MessageType.None, Err.Message)
        Application.Exit()
        Me.Close()
    End Sub
#End Region
#Region " OK "
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'If Format(SystemDate, "yyyyMMdd") > "20211130" Then
        '    MsgBox("Demo Expire")
        '    End
        'End If
        Dim rLogin As DataRow = DataBase.DataRow("MstStaff", String.Format("LoginID = '{0}' And Password = '{1}'", txtUserName.Text, txtPassword.Text))
        If rLogin IsNot Nothing Then
            StaffID = rLogin("StaffID")
            LoginID = rLogin("LogInID")
            StaffCode = rLogin("StaffCode")
            StaffName = rLogin("GivenName") & "  " & rLogin("Surname")
            StaffNickName = rLogin("NickName")
            Dim iUserGroup As Integer = rLogin("StaffGroupCode")
            Me.Hide()
            Dim frmM As New MainFormMDI
            With frmM
                .StaffName = LoginID
                Language.CurrentLanguage = cmbLang.Text
                .WindowState = FormWindowState.Maximized
                .DBName = INI.DBName
                .showForm(iUserGroup)
            End With
            Me.Close()
        Else
            Messages.ShowWarning(OPE_Controls.MessageType.None, "Login Error, Please sign again.")
        End If
    End Sub
#End Region
#Region " Cancel "
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Application.Exit()
    End Sub
#End Region
#Region " Check Protect "
    Private Function CheckProtect(ByRef Err As String) As Boolean
        Return True
        'Try
        '    Dim chk As New ProductDLL.clsCCheckProtectHasp
        '    If Not chk.CheckProductData(SystemDate) Then
        '        Err = "Please insert USB key"
        '        Return False
        '    End If

        'Catch ex As Exception
        '    Err = ex.Message
        '    Return False
        'End Try
        'Return True
    End Function
#End Region

    Private Sub Login_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Dim Err As String = ""
        If Not CheckProtect(Err) Then GoTo CloseApp
        INI.EnableSync = True

        Exit Sub
CloseApp:
        Me.Cursor = Cursors.Default
    End Sub
End Class
