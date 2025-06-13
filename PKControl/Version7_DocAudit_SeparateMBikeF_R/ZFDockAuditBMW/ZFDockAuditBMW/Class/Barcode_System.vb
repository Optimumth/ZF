Imports OPE_UtilDB
Imports System.Data
Imports System
Imports System.Windows.Forms

Public Class Barcode_System

    Public Shared P_DB As New OPE_UtilDB.Util.DBUtil
    Public Shared P_Sys As New clsSystem

End Class
Public Enum SoundFlags As Integer
    SND_SYNC = &H0  ' play synchronously (default) 
    SND_ASYNC = &H1  ' play asynchronously 
    SND_NODEFAULT = &H2  ' silence (!default) if sound not found 
    SND_MEMORY = &H4  ' pszSound points to a memory file
    SND_LOOP = &H8  ' loop the sound until next sndPlaySound 
    SND_NOSTOP = &H10  ' don't stop any currently playing sound 
    SND_NOWAIT = &H2000 ' don't wait if the driver is busy 
    SND_ALIAS = &H10000 ' name is a registry alias 
    SND_ALIAS_ID = &H110000 ' alias is a predefined ID
    SND_FILENAME = &H20000 ' name is file name 
    SND_RESOURCE = &H40004  ' name is resource name or atom 
End Enum



#Region " Convert"
Public Class clsConvert
    Public Function Integer_(ByVal Value As Object) As Integer
        If DBNull.Value.Equals(Value) Then Return 0

        Try
            Return CInt(Value)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function String_(ByVal Value As Object, Optional ByVal sFormat As String = "") As String
        If DBNull.Value.Equals(Value) Then Return ""
        If Value Is Nothing Then Return ""

        Try
            If sFormat = "" Then
                Return CStr(Value)
            Else
                Return Format(Value, sFormat)
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function Double_(ByVal Value As Object) As Double
        If DBNull.Value.Equals(Value) Then Return 0.0
        Try
            Return CDbl(Value)
        Catch ex As Exception
            Return 0.0
        End Try
    End Function
#Region "Spell Number"
    Public Function Currency_(ByVal dblMyNumber As Double, ByVal sUnitName As String, ByVal sCentName As String) As String
        Dim Dollars, Cents, Temp As Object
        Dim DecimalPlace, Count As Object
        Dim Place(9) As String
        Dim MyNumber As String
        Place(2) = " Thousand "
        Place(3) = " Million "
        Place(4) = " Billion "
        Place(5) = " Trillion "
        ' String representation of amount.
        MyNumber = dblMyNumber.ToString("0.00")
        ' Position of decimal place 0 if none.
        DecimalPlace = MyNumber.IndexOf("."c)
        ' Convert cents and set MyNumber to dollar amount.
        Cents = ""
        If DecimalPlace > 0 Then
            Cents = MyNumber.Substring(DecimalPlace + 1)
            If Cents = "00" Then Cents = "xx"
            Cents &= "/100"
            MyNumber = MyNumber.Substring(0, DecimalPlace)
        End If
        Count = 1
        Dollars = ""
        Do While MyNumber <> ""
            Temp = GetHundreds(Right(MyNumber, 3))
            If Temp <> "" Then Dollars = Temp & Place(Count) & Dollars
            If Len(MyNumber) > 3 Then
                MyNumber = Left(MyNumber, Len(MyNumber) - 3)
            Else
                MyNumber = ""
            End If
            Count = Count + 1
        Loop
        Select Case CStr(Dollars)
            Case ""
                Dollars = "No " & sUnitName
            Case "One"
                Dollars = "One " & sUnitName
            Case Else
                Dollars = Dollars & " " & sUnitName
        End Select

        Return Dollars & " and " & Cents
    End Function

    ' Converts a number from 100-999 into text
    Private Function GetHundreds(ByVal MyNumber As String) As String
        Dim Result As String = ""
        If Val(MyNumber) <> 0 Then
            MyNumber = Right("000" & MyNumber, 3)
            ' Convert the hundreds place.
            If Mid(MyNumber, 1, 1) <> "0" Then Result = GetDigit(Mid(MyNumber, 1, 1)) & " Hundred "
            ' Convert the tens and ones place.
            If Mid(MyNumber, 2, 1) <> "0" Then
                Result &= GetTens(Mid(MyNumber, 2))
            Else
                Result &= GetDigit(Mid(MyNumber, 3))
            End If
        End If
        Return Result
    End Function

    ' Converts a number from 10 to 99 into text.
    Private Function GetTens(ByVal TensText As String) As String
        Dim Result As String
        Result = ""           ' Null out the temporary function value.
        If Val(Left(TensText, 1)) = 1 Then   ' If value between 10-19...
            Select Case Val(TensText)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else                                 ' If value between 20-99...
            Select Case Val(Left(TensText, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select
            Result = Result & GetDigit _
                (Right(TensText, 1))  ' Retrieve ones place.
        End If
        GetTens = Result
    End Function

    ' Converts a number from 1 to 9 into text.
    Private Function GetDigit(ByVal Digit As String) As String
        Select Case Val(Digit)
            Case 1 : GetDigit = "One"
            Case 2 : GetDigit = "Two"
            Case 3 : GetDigit = "Three"
            Case 4 : GetDigit = "Four"
            Case 5 : GetDigit = "Five"
            Case 6 : GetDigit = "Six"
            Case 7 : GetDigit = "Seven"
            Case 8 : GetDigit = "Eight"
            Case 9 : GetDigit = "Nine"
            Case Else : GetDigit = ""
        End Select
    End Function

#End Region

End Class
#End Region
#Region " GetDate"
Public Class clsGetDate

    'Public Function GetDate() As Date
    '    Dim r As DataRow = Barcode_System.P_DB.getDataRow("SELECT GETDATE() DB_Date")
    '    If r Is Nothing Then
    '        Return Now
    '    Else
    '        Return r("DB_Date")
    '    End If
    'End Function

    'Public Function GetDate(ByVal YYYYMMDDxxxxxx As String) As Date
    '    Dim sDate As String = Me.DateFormat(YYYYMMDDxxxxxx)
    '    Return Barcode_System.P_Convert.Date_(sDate)
    'End Function

    'Public Function TimeFormat(ByVal dtData As Date) As String
    '    Return dtData.ToString("HH:mm")
    'End Function

    'Public Function DateTimeFormat() As String
    '    Return GetDate.ToString("yyyy/MM/dd HH:mm:ss")
    'End Function

    'Public Function DateTimeFormat(ByVal dtData As Date) As String
    '    Return dtData.ToString("yyyy/MM/dd HH:mm:ss")
    'End Function

    'Public Function DateFormat() As String
    '    Try
    '        Return GetDate.ToString("yyyy/MM/dd")
    '    Catch ex As Exception
    '        Return ""
    '    End Try
    'End Function

    'Public Function DateFormat(ByVal YYYYMMDDxxxxxx As String) As String
    '    Try
    '        If YYYYMMDDxxxxxx.Length < 6 Then Return ""

    '        Dim sDate As String = YYYYMMDDxxxxxx.Substring(0, 4) + "/" + YYYYMMDDxxxxxx.Substring(4, 2)
    '        If YYYYMMDDxxxxxx.Length < 8 Then Return sDate

    '        sDate &= "/" + YYYYMMDDxxxxxx.Substring(6, 2)
    '        If YYYYMMDDxxxxxx.Length < 12 Then Return sDate

    '        sDate &= " " + YYYYMMDDxxxxxx.Substring(8, 2) & ":" & YYYYMMDDxxxxxx.Substring(10, 2)
    '        Return sDate
    '    Catch ex As Exception
    '        Return ""
    '    End Try
    'End Function

    Public Function DateFormat(ByVal dtData As Date) As String
        Try
            Return dtData.ToString("yyyy/MM/dd")
        Catch ex As Exception
            Return ""
        End Try
    End Function

    'Public Function IsDate(ByVal YYYYMMDD As String) As Boolean
    '    Try
    '        Dim sData As String = YYYYMMDD.Substring(0, 4) + "/" + YYYYMMDD.Substring(4, 2) + "/" + YYYYMMDD.Substring(6, 2)
    '        Dim d As Date = CDate(sData)
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function
    'Public Function HHMI(ByVal dtData As Date) As String
    '    Return dtData.ToString("HHmm")
    'End Function
    'Public Function HHMI() As String
    '    Return GetDate.ToString("HHmm")
    'End Function
    'Public Function YYYYMM() As String
    '    Return GetDate.ToString("yyyyMM")
    'End Function

    'Public Function YYYY_MM() As String
    '    Return GetDate.ToString("yyyy/MM")
    'End Function

    'Public Function YYYY_MM(ByVal dtData As Date) As String
    '    Return dtData.ToString("yyyy/MM")
    'End Function

    'Public Function YYYYMM(ByVal dtData As Date) As String
    '    Return dtData.ToString("yyyyMM")
    'End Function

    'Public Function YYYYMMDD() As String
    '    Return GetDate.ToString("yyyyMMdd")
    'End Function
    'Public Function YYYYMMDD(ByVal dtData As Date) As String
    '    Return dtData.ToString("yyyyMMdd")
    'End Function

    'Public Function YYYYMMDDHHMISS() As String
    '    Return GetDate.ToString("yyyyMMddHHmmss")
    'End Function

    'Public Function YYYYMMDDHHMISS(ByVal dtData As Date) As String
    '    Return dtData.ToString("yyyyMMddHHmmss")
    'End Function

    Public Function YYYYMMDDHHMI(ByVal dtData As Date) As String
        Return dtData.ToString("yyyyMMddHHmm")
    End Function
End Class
#End Region
#Region " System"

Public Class clsSystem
    Public StaffID As String

    Public TerminalName As String
    Public AdminID As String
    Public AdminPass As String

    Public DBName As String
    Public DBID As String
    Public DBPass As String
    Public ServerIP As String

    Public ServerName As String
    Public IFPath As String
    Public HandyPath As String
    Public PicOdrPath As String
    Public PicResPath As String
    Public ShelfPaht As String
    Public CntPath As String
    Public MstPath As String

    Public FileRetryQty As Integer
    Public FileRetryTem As Decimal
    Public SOKOCode As Integer
    Public Alphabet As String
    Public srvPath As String
    Public PicturePath As String
    Public InqPath As String


    Public ErrSound As String
    Public AlertSound As String
    Public DownUpSound As String
    Public ShortagSound As String
    Public PahtSound As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName().CodeBase)
    ' Count Data
    Public SettingF1 As String = "F1 : M(#)"
    Public SettingF2 As String = "F2 : +(-)"
End Class


#End Region
#Region "LoadScreen"
Public Class LoadScreenData
    Private UsedFlag As Integer
    Public Sub CustomizeForm(ByRef frm As System.Windows.Forms.Form, ByVal dt As DataTable, ByVal FormName As String, Optional ByVal lang As Integer = 1, Optional ByVal ChkRefresh As Integer = 0)
        If Not dt Is Nothing Then

            Dim ctls As Control.ControlCollection = frm.Controls

            frm.Text = dt.Rows(0).Item("ScreenText").ToString
            For Each ctl As Control In ctls
                UsedFlag = 0
                If ChkRefresh = 1 And UCase(ctl.GetType.Name) = "Panel" Then
                    GoTo NextStep
                End If
                Select Case UCase(ctl.GetType.Name)
                    Case UCase("Panel")
                        Dim plctls As Control.ControlCollection = ctl.Controls

                        For Each plctl As Control In plctls
                            Select Case UCase(plctl.GetType.Name)

                                Case UCase("Panel")
                                    Dim plctl_sub As Control.ControlCollection = plctl.Controls
                                    For Each plctl1 As Control In plctl_sub
                                        Select Case UCase(plctl1.GetType.Name)
                                            Case UCase("label"), UCase("CheckBox"), UCase("RadioButton")
                                                Dim str As String = GetLabel(plctl1.Name, FormName, dt)
                                                If str <> "err" Then
                                                    If UsedFlag = 1 Then
                                                        plctl1.Text = str
                                                    ElseIf UsedFlag = 2 Then
                                                        plctl1.Text = str
                                                        If UCase(plctl1.GetType.Name) = UCase("CheckBox") Then
                                                            Dim chkBox As CheckBox = plctl1
                                                            chkBox.Enabled = False
                                                        ElseIf UCase(plctl1.GetType.Name) = UCase("RadioButton") Then
                                                            Dim rdButton As RadioButton = plctl1
                                                            rdButton.Enabled = False
                                                        Else
                                                            Dim ToolType As String = plctl_sub.Item(0).GetType.Name
                                                            If UCase(ToolType) = UCase("textbox") Then
                                                                Dim txt As TextBox = plctl_sub.Item(0)
                                                                txt.ReadOnly = True
                                                            ElseIf UCase(ToolType) = UCase("Combobox") Then
                                                                Dim cmb As ComboBox = plctl_sub.Item(0)
                                                                cmb.Enabled = False
                                                            ElseIf UCase(ToolType) = UCase("DateTimePicker") Then
                                                                Dim dtp As DateTimePicker = plctl_sub.Item(0)
                                                                dtp.Enabled = False
                                                            End If
                                                        End If
                                                    Else
                                                        If UCase(plctl1.GetType.Name) = UCase("CheckBox") Then
                                                            Dim chkBox As CheckBox = plctl1
                                                            chkBox.Visible = False
                                                        ElseIf UCase(plctl1.GetType.Name) = UCase("RadioButton") Then
                                                            Dim rdButton As RadioButton = plctl1
                                                            rdButton.Visible = False
                                                        Else
                                                            Dim pl As Panel = plctl
                                                            pl.Hide()
                                                        End If

                                                    End If
                                                End If
                                            Case UCase("button")
                                                Dim str As String = GetLabel(plctl1.Name, FormName, dt)
                                                If str <> "err" Then
                                                    If UsedFlag = 1 Then
                                                        plctl.Text = str
                                                    ElseIf UsedFlag = 2 Then
                                                        plctl.Enabled = False
                                                    Else
                                                        Dim pl As Panel = plctl
                                                        pl.Hide()
                                                    End If
                                                End If
                                        End Select
                                    Next

                                Case UCase("label"), UCase("CheckBox"), UCase("RadioButton")
                                    Dim str As String = GetLabel(plctl.Name, FormName, dt)
                                    If str <> "err" Then
                                        If UsedFlag = 1 Then
                                            plctl.Text = str
                                        ElseIf UsedFlag = 2 Then
                                            plctl.Text = str
                                            If UCase(plctl.GetType.Name) = UCase("CheckBox") Then
                                                Dim chkBox As CheckBox = plctl
                                                chkBox.Enabled = False
                                            ElseIf UCase(plctl.GetType.Name) = UCase("RadioButton") Then
                                                Dim rdButton As RadioButton = plctl
                                                rdButton.Enabled = False
                                            Else
                                                Dim ToolType As String = plctls.Item(0).GetType.Name
                                                If UCase(ToolType) = UCase("textbox") Then
                                                    Dim txt As TextBox = plctls.Item(0)
                                                    txt.ReadOnly = True
                                                ElseIf UCase(ToolType) = UCase("Combobox") Then
                                                    Dim cmb As ComboBox = plctls.Item(0)
                                                    cmb.Enabled = False
                                                ElseIf UCase(ToolType) = UCase("DateTimePicker") Then
                                                    Dim dtp As DateTimePicker = plctls.Item(0)
                                                    dtp.Enabled = False
                                                End If
                                            End If
                                        Else
                                            If UCase(plctl.GetType.Name) = UCase("CheckBox") Then
                                                Dim chkBox As CheckBox = plctl
                                                chkBox.Visible = False
                                            ElseIf UCase(plctl.GetType.Name) = UCase("RadioButton") Then
                                                Dim rdButton As RadioButton = plctl
                                                rdButton.Visible = False
                                            Else
                                                Dim pl As Panel = ctl
                                                pl.Hide()
                                            End If

                                        End If
                                    End If
                                Case UCase("button")
                                    Dim str As String = GetLabel(plctl.Name, FormName, dt)
                                    If str <> "err" Then
                                        If UsedFlag = 1 Then
                                            plctl.Text = str
                                        ElseIf UsedFlag = 2 Then
                                            plctl.Enabled = False
                                        Else
                                            Dim pl As Panel = ctl
                                            pl.Hide()
                                        End If
                                    End If
                            End Select

                        Next
                    Case UCase("DataGrid")
                        Dim grd As DataGrid = ctl
                        If Not grd.DataSource Is Nothing Then
                            Dim dt1 As DataTable = grd.DataSource
                            dt1.TableName = "ScanList"
                            grd.DataSource = dt1
                            Dim ts As New DataGridTableStyle
                            ts.MappingName = "ScanList"

                            Dim DataSize As Integer = 0
                            For i As Integer = 0 To dt1.Columns.Count - 1
                                Dim str As String = GetLabel(dt1.Columns(i).ColumnName.ToString, FormName, dt, DataSize)
                                If str <> "err" Then
                                    grd.TableStyles.Clear()
                                    grd.TableStyles.Add(ts)
                                    If UsedFlag = 1 Then

                                        grd.TableStyles(0).GridColumnStyles(i).HeaderText = str
                                        grd.TableStyles(0).GridColumnStyles(i).Width = DataSize
                                    ElseIf UsedFlag = 2 Then
                                        grd.TableStyles(0).GridColumnStyles.IsReadOnly.ToString()
                                    Else
                                        grd.TableStyles(0).GridColumnStyles(i).Width = 0
                                    End If

                                End If
                            Next
                        End If
                    Case Else
                End Select
NextStep:
            Next


        End If
    End Sub
    Private Function GetLabel(ByVal sName As String, ByVal FormName As String, ByVal Dt As DataTable, Optional ByRef Datasize As Integer = 0) As String
        For Each dr As DataRow In Dt.Select("ScreenName = '" & Trim(FormName) & "' AND DataName = '" & sName & "'")
            UsedFlag = dr("DUsedFlag")
            Datasize = IIf(IsDBNull(dr("Datasize")), 0, dr("Datasize"))
            Return dr("DataText")
        Next
        Return "err"
    End Function
End Class
#End Region
#Region " SetControl"
Public Class clsControl
#Region " Customize: TextBox"
    Public Sub CustomizeNumeric(ByVal txt As TextBox, Optional ByVal bFormat As Boolean = True)
        txt.TextAlign = HorizontalAlignment.Right
        AddHandler txt.KeyDown, AddressOf NextWhenEnter
        AddHandler txt.KeyPress, AddressOf NextWhenKeyPressInteger
        If bFormat Then
            AddHandler txt.GotFocus, AddressOf TextBoxGotFocus_Numeric
            AddHandler txt.LostFocus, AddressOf TextBoxGotFocus_Numeric
        End If
    End Sub


    Private Sub TextBoxGotFocus_Numeric(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim P_Convert As New clsConvert
        Dim sVal As String = CType(sender, TextBox).Text
        CType(sender, TextBox).Text = P_Convert.Double_(sVal).ToString("#,##0")

        If sender.GetType() Is GetType(TextBox) Then
            Dim obj As TextBox = CType(sender, TextBox)
            obj.SelectAll()
            Exit Sub
        End If
    End Sub
    Private Sub NextWhenEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then

            e.Handled = True
        End If
    End Sub
    Private Sub NextWhenKeyPressInteger(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 8 OrElse (e.KeyChar >= "0" And e.KeyChar <= "9") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
#Region " Customize: Combo"
    Public Sub CustomizeCombo(ByRef cbo As System.Windows.Forms.ComboBox, Optional ByVal dtSource As DataTable = Nothing, Optional ByVal DispMember As String = "", Optional ByVal ValMember As String = "", Optional ByVal bSorted As Boolean = True)
        AddHandler cbo.KeyDown, AddressOf NextWhenEnter

        If dtSource IsNot Nothing Then
            If bSorted Then dtSource.DefaultView.Sort = DispMember
            cbo.DataSource = dtSource
            cbo.ValueMember = ValMember
            cbo.DisplayMember = DispMember
            cbo.SelectedIndex = 0
        End If
    End Sub
    'Public Sub CustomizeComboFix(ByRef cbo As System.Windows.Forms.ComboBox, Optional ByVal dtSource As DataTable = Nothing, Optional ByVal DispMember As String = "", Optional ByVal ValMember As String = "", Optional ByVal bSorted As Boolean = True)
    '    AddHandler cbo.KeyDown, AddressOf NextWhenEnter

    '    If dtSource IsNot Nothing Then
    '        ' If bSorted Then dtSource.DefaultView.Sort = DispMember
    '        cbo.DataSource = dtSource
    '        cbo.ValueMember = ValMember
    '        cbo.DisplayMember = DispMember
    '        cbo.SelectedIndex = 0
    '    End If
    'End Sub
#End Region


End Class
#End Region




