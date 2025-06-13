Imports OPE_Controls.OpeStyle

Public Class CustomizeSetting
    Public Shared ComboSet As New CustomizeSettingControls
    Public Shared INI As New CustomizeINI
    Public Shared StaffID As Integer
    Public Shared LoginID As String = ""
    Public Shared StaffCode As String = ""
    Public Shared StaffName As String = ""
    Public Shared StaffNickName As String = ""
    Public Shared FormatExchangeRate As String = "#,##0.00000"
    Public Shared MaxDescLine As Integer = 5


    Public Shared ReadOnly Property SystemDate() As DateTime
        Get
            Dim sql As String = ""
            If DataBase Is Nothing OrElse Not DataBase.isOpen(False) Then
                Return Now
            ElseIf DataBase.DB_Type = OPE_Controls.Util.DBUtil.eDBType.SqlServer Then
                sql = " SELECT GETDATE() "
            ElseIf DataBase.DB_Type = OPE_Controls.Util.DBUtil.eDBType.MySql Then
                sql = " SELECT NOW() "
            Else
                Return Now
            End If
            Dim dt As DataTable = DataBase.DataTable(sql)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso dt.Rows(0)(0) IsNot DBNull.Value Then
                Return dt.Rows(0)(0)
            Else
                Return Now
            End If
        End Get
    End Property
    Public Shared Sub RecordUpdateBy(ByRef DataRow As DataRow)
        If DataRow Is Nothing Then Exit Sub
        Dim Table As DataTable = DataRow.Table
        Dim dDate As Date = SystemDate
        If Table Is Nothing OrElse Table.Columns.Count = 0 Then Exit Sub
        If Table.Columns.IndexOf("UpdateDate") > -1 Then DataRow("UpdateDate") = dDate
        If Table.Columns.IndexOf("UpdateUser") > -1 Then DataRow("UpdateUser") = StaffID
        If Table.Columns.IndexOf("UpdateUserName") > -1 Then DataRow("UpdateUserName") = StaffNickName
        If Table.Columns.IndexOf("CreateDate") > -1 AndAlso DataRow("CreateDate") Is System.DBNull.Value Then
            If Table.Columns.IndexOf("CreateDate") > -1 Then DataRow("CreateDate") = dDate
            If Table.Columns.IndexOf("CreateUser") > -1 Then DataRow("CreateUser") = StaffID
            If Table.Columns.IndexOf("CreateUserName") > -1 Then DataRow("CreateUserName") = StaffNickName
        End If
    End Sub
    Public Shared Sub RunSetting()
        Info.ProjectName = "ZFPKVisual"
        Info.AddAssembly("ZFPKVisual", "ZFPKVisual.exe", "ZFPKVisual", , True)
        Dim rPath As DataRow = DataBase.DataRow("MstSystemConfig")

        With INI
            .QtyDigit = 0
            .ReportTemplatePath = Info.ProjectPath & "\ReportTemplate"
            .ReportOutputPath = Info.ProjectPath & "\ReportOutput"
            .PicturePath = Info.ProjectPath & "\Picture"
            .InterfaceMst = Info.ProjectPath & "\Interface\Mst"
            .InterfaceTrn = Info.ProjectPath & "\Interface\Trans"
            .InterfaceStaff = Info.ProjectPath & "\Interface\Staff"
            .RackColumn = rPath("RackColumn")
            .AutoMBHr = rPath("AutoMBHR")
            .OutLogPath = rPath("OutlogFile")
            .RackStatusPassword = rPath("AuthorRackStatus")
        End With
        With Styles
            .ReadOnlyBackColor = SystemColors.Control
            .ReadOnlyForeColor = Color.Blue
            .NotNullBackColor = Color.MistyRose
            .DateCustomMonth = "MM/yyyy" '"yyyy/MM"
            .DateCustomFormat = "dd/MM/yyyy"
            .DateCustomFormatDateTime = "dd/MM/yyyy HH:mm" '"yyyy/MM/dd HH:mm"
            .DateCustomFormatFull = "dd/MM/yyyy HH:mm:ss"  '"yyyy/MM/dd HH:mm:ss"
            .FormatQty = "#,##0"
            .FormatMoney = "#,##0.00#"
            .IsSearchWithSymbol = False
        End With

    End Sub
End Class

Public Class CustomizeINI
    Public Server As String
    Public DBName As String
    Public UserName As String
    Public Password As String
    Public ReportTemplatePath As String = ""
    Public ReportOutputPath As String = ""
    Public QtyDigit As Integer = 2


    '============MstSystemConfig============
    Public sFront As String = "Front"
    Public sRear As String = "Rear"
    Public sBPS As String = "BPS"

    Public Status_ZF As String = "ZF"
    Public Status_MB As String = "MB"
    Public Status_OnTruck As String = "On Truck"
    Public Status_Supplier As String = "Supplier"
    Public Status_ExtWH As String = "Ext WH"

    Public PicturePath As String = ""
    Public RackColumn As Integer = 0
    Public AutoMBHr As Integer = 0
    Public InterfaceMst As String = ""
    Public InterfaceTrn As String = ""
    Public InterfaceStaff As String = ""
    Public MstFilename As String = ""
    Public StaffFilename As String = ""
    Public HandyInterface As String = ""
    Public OutLogPath As String = ""
    Public RackStatusPassword As String = ""
    Public EnableSync As Boolean = False
    '=======================================
End Class
Public Class CustomizeSettingControls
#Region " Text "

    Public Sub TextQty(ByRef obj As OPE_Controls.OpeTextBox)
        With obj
            .ShowDecimal = True
            .Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
            .MaxLength = 19
            .MinValue = 0
            .DecimalDigit = CustomizeSetting.INI.QtyDigit
            .TextAlign = HorizontalAlignment.Right
        End With
    End Sub

    Public Sub TextInt(ByRef obj As OPE_Controls.OpeTextBox, Optional ByVal IsNegative As Boolean = False)
        With obj
            .ShowDecimal = False
            .Language = OPE_Controls.OpeTextBox.LanguageType.NumberOnly
            .MaxLength = 19
            .MinValue = IIf(Not IsNegative, 0, -19)
            .DecimalDigit = 0
            .TextAlign = HorizontalAlignment.Right
        End With
    End Sub

    Public Sub TextString(ByRef obj As OPE_Controls.OpeTextBox, dtLength As DataTable, ColName As String, Optional IsMultiLine As Boolean = False)
        With obj
            .Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
            .MaxLength = dtLength.Compute("min(MaxLength)", "ColName='" & ColName & "'")
            .Multiline = IsMultiLine
        End With
    End Sub

    Public Function DecimalFormat(ByVal Digit As Integer) As String
        Dim sDigit As String = ""
        For i As Integer = 1 To Digit
            sDigit &= "0"
        Next

        Return "#,##0." & sDigit
    End Function

    Public Function DecimalMaxValue(ByVal Digit As Integer) As String
        Dim sValue As String = DecimalFormat(Digit)
        sValue = sValue.Replace("0", "9")
        sValue = sValue.Replace(",", "")
        sValue = sValue.Replace("#", "9")
        Return sValue
    End Function
#End Region
#Region " Grid "
    Public Sub GridColumnSize(ByRef obj As OPE_Controls.opeDataGrid)
        obj.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False
        Dim lWidth As Long = 0
        For Each c As DataGridViewColumn In obj.Columns
            lWidth = c.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, True)
            If lWidth > 300 Then
                c.Width = 300
            Else
                If c.Width < lWidth Then
                    c.Width = lWidth
                End If
            End If
        Next
    End Sub

    Public Sub GridSetting(ByRef obj As OPE_Controls.opeDataGrid, ByVal IsRecordNo As Boolean, ByVal Parent As Control, Optional ByVal SelectionMode As DataGridViewSelectionMode = DataGridViewSelectionMode.CellSelect)
        obj.DefaultCellStyle.Font = New System.Drawing.Font(Parent.Font.Name, Parent.Font.Size + 0.5, System.Drawing.FontStyle.Regular, Parent.Font.Unit, Parent.Font.GdiCharSet)
        obj.SelectionMode = SelectionMode
        obj.AlternatingRowsDefaultCellStyle.BackColor = Color.Empty
        obj.RowHeadersVisible = IsRecordNo
        obj.AutoGenerateRecordNo = IsRecordNo
    End Sub
#End Region
#Region " Date "
    Public Sub DateTime(ByRef obj As OPE_Controls.OpeDateTime, Optional ByRef chk As OPE_Controls.OpeCheckBox = Nothing, Optional ByRef obj2 As OPE_Controls.OpeDateTime = Nothing)
        Dim sDate As Date = CustomizeSetting.SystemDate
        obj.Value = sDate
        obj.HideButton = True
        obj.Format = DateTimePickerFormat.Custom
        obj.CustomFormat = Styles.DateCustomFormat
        If chk IsNot Nothing Then obj.LinkCheckedBox = chk
        If obj2 IsNot Nothing Then
            obj2.Value = sDate
            obj2.HideButton = True
            obj2.Format = DateTimePickerFormat.Custom
            obj2.CustomFormat = Styles.DateCustomFormat
            'obj.LinkDateTime = obj2
            If chk IsNot Nothing Then obj.LinkCheckedBox = chk
        End If
    End Sub
#End Region
#Region "Util"
    Public Function MaxValue(ByVal Keyword As String, ByVal DataSource As DataTable) As String
        If DataSource Is Nothing OrElse DataSource.Rows.Count = 0 Then Return ""
        If DataSource.Columns(Keyword) Is Nothing Then Return ""
        Dim sValueS As String = ""
        Dim sValueS0 As String = ""
        Dim sValueS1 As Integer = 0
        Dim sValueR0 As String = ""
        Dim sValueR1 As Integer = 0
        Dim sValueRX As String = ""
        For Each r As DataRow In DataSource.Rows
            sValueS = Converts.ToStr(r(Keyword))
            Dim a() As String = sValueS.Split("-")
            sValueS0 = a(0)
            If a.Length >= 2 Then
                sValueS1 = Converts.ToInteger(a(1))
            Else
                sValueS1 = 0
            End If
            If sValueS0.Length > sValueR0.Length OrElse sValueS0 > sValueR0 OrElse (sValueS0 = sValueR0 AndAlso sValueS1 > sValueR1) Then
                sValueR0 = sValueS0
                sValueR1 = sValueS1
                sValueRX = sValueS
            End If
        Next
        Return sValueRX.Trim
    End Function

    Public Function Round(ByVal Value As Object, ByVal Decimals As Integer) As Double
        Dim dValue As Decimal = Converts.ToDouble(Value)
        Return Math.Round(dValue, Decimals, MidpointRounding.AwayFromZero)
    End Function

    Public Function ReadTextFileList(ByRef e As OPE_Controls.EventArgs, ByVal FileName As String) As ArrayList
        Dim aData As New ArrayList
        Dim sr As IO.StreamReader = Nothing
        Try
            sr = New IO.StreamReader(FileName)
            Do While sr.Peek() >= 0
                aData.Add(sr.ReadLine())
            Loop
            e.Message = ""
        Catch ex As Exception
            e.Message = ex.Message
        End Try
        If sr IsNot Nothing Then
            sr.Close()
            sr.Dispose()
        End If
        If e.Message.Length > 0 Then
            e.DialogResult = DialogResult.Retry
            aData = Nothing
        End If

        Return aData
    End Function

    Public Function GetColumnLength(TB As String) As DataTable
        Dim dt As DataTable = Nothing
        Dim sql As String = "select column_name as ColName,character_maximum_length as MaxLength" & _
                            " from information_schema.columns" & _
                            " where table_name = '{0}'"
        sql = String.Format(sql, TB)
        dt = DataBase.DataTable(sql)
        Return dt
    End Function

    Public Sub OpenFolder(Path As String, Folder As String)
        If Path = "" Then MsgBox("Blank Path in Master System Config.") : Exit Sub
        'If Folder = "" Then MsgBox("Blank Folder") : Exit Sub
        If Not System.IO.Directory.Exists(Path & Folder) Then MsgBox("Directory isn't exists") : Exit Sub
        Process.Start(Path & Folder)
    End Sub

    Public Sub OpenFile(Path As String, FileName As String)
        If Path = "" Then MsgBox("Blank Path in Master System Config.") : Exit Sub
        If FileName = "" Then MsgBox("Blank File Name") : Exit Sub
        If Not System.IO.File.Exists(Path & FileName) Then MsgBox("Not existing file") : Exit Sub
        Process.Start(Path & FileName)
    End Sub

    Public Function GetDWGOriginalFolder(ProjectNo As String) As String
        Dim dt As DataTable = DataBase.DataSelect("PrgProject", "ProjectNo = '" & ProjectNo & "'", , , "DrawingFolder")
        If dt.Rows.Count = 0 Then Return "" Else Return Converts.ToStr(dt.Rows(0)("DrawingFolder"))
    End Function

    Public Function GetDWGRunningItemFolder(ProjectNo As String) As String
        Dim dt As DataTable = DataBase.DataSelect("PrgProject", "ProjectNo = '" & ProjectNo & "'", , , "DWGRunningItemFolder")
        If dt.Rows.Count = 0 Then Return "" Else Return Converts.ToStr(dt.Rows(0)("DWGRunningItemFolder"))
    End Function

    Public Function GetCusPOFileName(OrderNo As String) As String
        Dim dt As DataTable = DataBase.DataSelect("PrgOrderHeader", "OrderNo = '" & OrderNo & "'", , , "CustomerPOFileName")
        If dt.Rows.Count = 0 Then Return "" Else Return Converts.ToStr(dt.Rows(0)("CustomerPOFileName"))
    End Function
    Public Function GetSupQTFolder(PONo As String, SeqNo As Integer) As String
        Dim dt As DataTable = DataBase.DataSelect("PrgPurchaseOrderDetail", "PONo = '" & PONo & "' and SeqNo = " & SeqNo & "", , , "SupplierQTFolder")
        If Converts.ToStr(dt.Rows(0)("SupplierQTFolder")) = "" Then
            dt = DataBase.DataSelect("PrgPurchaseOrderDetail", "isnull(SupplierQTFolder,'')<>'' and PONo = '" & PONo & "'", , , "SupplierQTFolder")
        End If
        If dt.Rows.Count = 0 Then Return "" Else Return Converts.ToStr(dt.Rows(0)("SupplierQTFolder"))
    End Function
#End Region
End Class