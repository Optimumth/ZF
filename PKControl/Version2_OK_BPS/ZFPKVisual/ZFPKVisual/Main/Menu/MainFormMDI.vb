Imports MouseKeyboardLibrary
Imports OPE_Controls.OpeStyle
Public Class MainFormMDI
    Private formState As System.Windows.Forms.FormWindowState = FormWindowState.Normal
    Private FormHeight As Integer = 640 '830
    Private FormWidth As Integer = 830 '640

    Private MHook As New MouseHook()
    Private KHook As New KeyboardHook()
    Private TimeCounter As Integer = 0
    Private MaxTimeCounter As Integer = 60 * 10 ' 10 minute
    Private MyTimer As New Timer()

#Region " Not Edit Code "
    Protected Overrides Sub MDIParent1_Load(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim obj() As Control = Me.Controls.Find("ToolStrip2", True)
        If obj.Length > 0 Then
            obj(0).Visible = False
        End If
        cmbLanguage1.Visible = False
        Me.Controls.Find("pnHeightButton", True)(0).Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Controls.Find("TreeView1", True)(0).Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        
    End Sub

    Private Sub MyTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If (TimeCounter = MaxTimeCounter) Then
            'LOGOFF()
        Else
            TimeCounter += 1
            'Me.Text = String.Format("{0} : TimeCounter : {1} ", Application.ProductName, TimeCounter)
        End If
    End Sub

    Private Sub MouseHook_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        Me.TimeCounter = 0
    End Sub

    Private Sub KeyBoardHook_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Me.TimeCounter = 0
    End Sub
#End Region
#Region " Form Client "
    Protected Overrides Sub CreateNewForm(ByVal FormId As Integer, ByVal View As Integer, ByVal Add As Integer, ByVal Up As Integer, ByVal Del As Integer, ByVal Print As Integer, ByVal Other1 As Integer, ByVal Other2 As Integer, ByVal Other3 As Integer, ByVal ClassObject As String, ByVal FormName As String)
        If ClassObject = "" Then
            MessageBox.Show("Please Setup Database First")
            Exit Sub
        End If

        For Each frm As Form In Me.MdiChildren
            If Not IsNothing(frm.Tag) AndAlso frm.Tag = FormId Then
                frm.Select()
                Exit Sub
            End If

            Dim f As OPE_Controls.frmMst007 = TryCast(frm, OPE_Controls.frmMst007)
            If Not IsNothing(f) AndAlso f.FormId = FormId Then
                frm.Select()
                Exit Sub
            End If
        Next

        Try
            Dim aClass() As String = ClassObject.Split(":")
            Dim NameOfMyClass As String = ""
            If aClass.Length > 0 Then NameOfMyClass = aClass(0).Trim
            Dim MyInstance As Object = Info.CallObject(aClass(0))
            'MyInstance = Activator.CreateInstance(Type.GetType(NameOfMyClass))

            With MyInstance
                .MdiParent = Me
                .FormId = FormId
                .Tag = FormId
                .Text = FormName
                If aClass.Length > 1 Then .CustomCode = Converts.ToInt(aClass(1))
                'AddForm(MyInstance.Text, FormId)
                AddForm(FormName, FormId)
                .StartPosition = FormStartPosition.CenterScreen
                Try
                    Select Case MyInstance.GetType.BaseType.Name
                        Case "Object"
                        Case Else
                            Dim objBaseForm As Object = MyInstance.GetType.BaseType
                            For i As Integer = 0 To 10
                                If objBaseForm Is Nothing Then Exit For
                                Select Case objBaseForm.Name
                                    Case "Object" : Exit For
                                    Case Else
                                        If objBaseForm.Name = "Form" Then
                                            Dim frm As System.Windows.Forms.Form = MyInstance
                                            AddHandler frm.FormClosed, AddressOf ChildFormClose
                                            OPE_Controls.OpeStyle.Language.LanguageToControl(FormId, MyInstance)
                                            frm.WindowState = FormWindowState.Maximized
                                            Exit For
                                        Else
                                            objBaseForm = objBaseForm.BaseType
                                        End If
                                End Select
                            Next
                    End Select
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                .ShowForm(View, Add, Up, Del, Print, Other1, Other2, Other3)
            End With
        Catch ex As Exception
            Messages.SaveLogFile("Open Screen", "Setup Database Error" & vbCrLf & ex.Message, True)
            Exit Sub
        End Try
    End Sub

    Private Sub MainFormMDI_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.setDateFormat = Styles.DateCustomFormat
        Me.ProgramVersion = Application.ProductVersion
        Me.MenuWidth = 300
        Me.Refresh()
        AboutVisible = False
    End Sub

    Private Sub MainFormMDI_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        If tabPage.TabPages.Count <= 0 OrElse Me.MdiChildren.Count <= 0 Then Exit Sub

        Dim frm As System.Windows.Forms.Form = Me.ActiveMdiChild
        Dim FormId As Integer
        Try
            Dim frm2 As Object = frm
            FormId = frm2.FormId
        Catch ex As Exception
            FormId = Converts.ToInt(frm.Tag)
        End Try
        For i As Integer = 0 To tabPage.TabPages.Count - 1 'StatusStrip.Items.Count - 1
            With tabPage.TabPages(i)
                If .Name = FormId OrElse .Text = frm.Text Then
                    tabPage.SelectedIndex() = i
                    Exit For
                End If
            End With
        Next
    End Sub

    Public Sub ChildFormClose(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        Dim FormId As Integer
        Try
            FormId = sender.FormId
        Catch ex As Exception
            FormId = Converts.ToInt(sender.Tag)
        End Try
        If sender IsNot Nothing Then RemoveForm(sender.Text, FormId)
    End Sub
#End Region

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
        'Dim chk As New ProductDLL.clsCCheckProtectHasp
        'If Not chk.CheckProductData(CustomizeSetting.SystemDate) Then
        '    MessageBox.Show("Program Expire")
        '    Application.Exit()
        'End If
    End Sub
End Class