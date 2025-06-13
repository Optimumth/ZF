Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVDockAudit_LogData
    Private cls As New clsCDockAudit_LogData
#Region "Load"
    Private Sub clsVDockAudit_LogData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
    Private Sub LoadForm()
        ComboSet.DateTime(dtpDate1, chkLogDate, dtpDate2)
        Dim CurDate As Date = SystemDate.Date
        Dim Date1 As Date = New Date(CurDate.Year, CurDate.Month, 1)
        Dim Date2 As Date = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, Date1))
        dtpDate1.Value = Date1
        dtpDate2.Value = Date2

        txtOutLogPath.Text = INI.OutLogDockAudit

        btnSearch.PerformClick()
    End Sub
#End Region
#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_CheckBox("chk", "Print", "chk", , , , True)
            .ColumnAdd_TextBox("LogDate", "LogDate", "LogDate")
        End With
        ComboSet.GridColumnSize(grdData)
    End Sub
#End Region
#Region "Toolbar Click"
    Private Sub btnSearch_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Click
        Dim dt As DataTable = cls.GetData(chkLogDate.Checked, dtpDate1.Value.Date, dtpDate2.Value.Date)
        grdData.DataSource = dt
        grdData_BindingGridColumns()

    End Sub

    Private Sub btnSearch_Validate(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Validate
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        If chkLogDate.Checked And dtpDate1.Value.Date > dtpDate2.Value.Date Then bTrue = bTrue And Messages.SetError(ErrProvider, dtpDate2, OPE_Controls.MessageType.StartDateMustLessThanEndDate)

        If Not bTrue Then e.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnPrint.Click
        Print()
    End Sub

    Private Sub Print()
        Try
            If grdData.DataSource Is Nothing Then MessageBox.Show("No Data") : Exit Sub
            Dim dt As DataTable = grdData.DataSource
            Dim Printed As Boolean = False
            For Each dr As DataRow In dt.Select()
                If Converts.ToInt_NullIsZero(dr("chk")) = 1 Then
                    If IO.Directory.Exists(txtOutLogPath.Text.Trim) = False Then
                        IO.Directory.CreateDirectory(txtOutLogPath.Text.Trim)
                    End If
                    Dim LogDate As Date = dr("LogDate")
                    Dim csvFilePath As String = txtOutLogPath.Text.Trim & "\Log" & Format(LogDate, "yyyyMMdd") & ".csv"
                    Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFilePath, False)
                    outFile.WriteLine("Rack ID.,Customer,Model from Dock Audit,Axle/Shock,Variant,Part No.,Lot No.,Type,Side,Axle/ShockNo,QC1,QC2,QC3,Caliper,QC4,QC5,QC6,QC7,Random Shock,Delivery Date,Scan Time,Scan User,Upload Date,Upload Time,Upload User")

                    Dim dtDaily As DataTable = cls.GetDailyLog(dr("LogDate"))
                    For Each drDaily As DataRow In dtDaily.Select()
                        Dim str As String = ""
                        str = Converts.ToStr(drDaily("RackID"))
                        str &= "," & CustomerCode
                        str &= "," & Converts.ToStr(drDaily("ModelDock"))
                        str &= "," & Converts.ToStr(drDaily("AxleShock"))
                        str &= "," & Converts.ToStr(drDaily("Varian"))
                        str &= "," & Converts.ToStr(drDaily("PartNo"))
                        str &= "," & Converts.ToStr(drDaily("Lot"))
                        str &= "," & Converts.ToStr(drDaily("BarcodeType"))
                        str &= "," & Converts.ToStr(drDaily("Side"))
                        If Converts.ToStr(drDaily("AxleShock")) = "Axle" Then
                            str &= "," & Converts.ToStr(drDaily("AxleNo"))
                        Else
                            str &= ",[1-24]"
                        End If

                        str &= "," & Converts.ToStr(drDaily("QC1"))
                        str &= "," & Converts.ToStr(drDaily("QC2"))
                        str &= "," & Converts.ToStr(drDaily("QC3"))
                        str &= "," & Converts.ToStr(drDaily("Caliper"))
                        str &= "," & Converts.ToStr(drDaily("QC4"))

                        str &= "," & Converts.ToStr(drDaily("QC5"))
                        str &= "," & Converts.ToStr(drDaily("QC6"))
                        str &= "," & Converts.ToStr(drDaily("QC7"))
                        str &= "," & Converts.ToStr(drDaily("RandomShockNo"))

                        str &= "," & drDaily("ScanDate")
                        str &= "," & drDaily("ScanTime")
                        str &= "," & Converts.ToStr(drDaily("ScanUser"))
                        str &= "," & drDaily("UploadDate")
                        str &= "," & drDaily("UploadTime")
                        str &= "," & Converts.ToStr(drDaily("UploadUser"))
                        outFile.WriteLine(str)
                    Next
                    outFile.Close()
                    Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFilePath))

                    Printed = True
                End If
            Next

            If Printed = True Then
                Process.Start(txtOutLogPath.Text.Trim)
            Else
                MessageBox.Show("No Data")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub btnCheckAll_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnCheckAll.Click
        If grdData.DataSource Is Nothing Then Exit Sub
        For Each dr As DataRow In grdData.DataSource.select()
            dr("chk") = 1
        Next
    End Sub
    Private Sub btnReleaseAll_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnReleaseAll.Click
        If grdData.DataSource Is Nothing Then Exit Sub
        For Each dr As DataRow In grdData.DataSource.select()
            dr("chk") = 0
        Next
    End Sub



End Class