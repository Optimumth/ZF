Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVLogData
    Private cls As New clsCLogData
#Region "Load"
    Private Sub clsVLogData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If
        LoadForm()
    End Sub
    Private Sub LoadForm()
        ComboSet.DateTime(dtpDate1, chkLogDate, dtpDate2)
        Dim CurDate As Date = SystemDate.Date
        Dim Date1 As Date = New Date(CurDate.Year, CurDate.Month, 1)
        Dim Date2 As Date = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, Date1))
        dtpDate1.Value = Date1
        dtpDate2.Value = Date2

        txtOutLogPath.Text = INI.OutLogPath

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
        If chkSumDate.Checked = False Then
            PrintNormal()
        Else
            PrintSum()
        End If
    End Sub

    Private Sub PrintNormal()
        Try
            If grdData.DataSource Is Nothing Then MessageBox.Show("No Data") : Exit Sub
            Dim dt As DataTable = grdData.DataSource
            Dim Printed As Boolean = False
            For Each dr As DataRow In dt.Select()
                If Converts.ToInt_NullIsZero(dr("chk")) = 1 Then
                    Dim LogDate As Date = dr("LogDate")
                    Dim csvFilePath As String = INI.OutLogPath & "\Log" & Format(LogDate, "yyyyMMdd") & ".csv"
                    Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFilePath, False)
                    If CustomerCode = "MB" Then
                        outFile.WriteLine("Customer,LOG Date,Rack ID.,Model,Rack No.,Show,Remark,Rack Status,Date Scan,Time Scan,Scan User,Date Upload,Time Upload,User Upload, Status, Loss Date, Loss Remark,Truck,ShipDate,Truck Remark")
                    Else
                        outFile.WriteLine("Customer,LOG Date,Rack ID.,Model Rack,Model,Varian,Lot,Delivery Note No., Axle No.,Rack No.,Show,Remark,Rack Status,Date Scan,Time Scan,Scan User,Date Upload,Time Upload,User Upload, Status, Loss Date, Loss Remark,Truck,ShipDate,Truck Remark")
                    End If

                    Dim dtDaily As DataTable = cls.GetDailyLog(dr("LogDate"))
                    For Each drDaily As DataRow In dtDaily.Select()
                        Dim str As String = ""
                        str = CustomerCode
                        str &= "," & dr("LogDate")
                        str &= "," & Converts.ToStr(drDaily("RackID"))
                        str &= "," & Converts.ToStr(drDaily("Model"))

                        If CustomerCode = "BMW" Then
                            str &= "," & Converts.ToStr(drDaily("TruckModel"))
                            str &= "," & Converts.ToStr(drDaily("Varian"))
                            str &= "," & Converts.ToStr(drDaily("Lot"))
                            str &= "," & Converts.ToStr(drDaily("DeliveryNoteNo"))
                            str &= "," & Converts.ToStr(drDaily("AxleNo"))
                        End If

                        str &= "," & Converts.ToStr(drDaily("RackNo"))
                        str &= "," & Converts.ToStr(drDaily("Show"))
                        str &= "," & Converts.ToStr(drDaily("Remark"))
                        str &= "," & Converts.ToStr(drDaily("RackStatus"))
                        str &= "," & drDaily("ScanDate")
                        str &= "," & drDaily("ScanTime")
                        str &= "," & Converts.ToStr(drDaily("ScanUser"))
                        str &= "," & drDaily("UploadDate")
                        str &= "," & drDaily("UploadTime")
                        str &= "," & Converts.ToStr(drDaily("UploadUser"))
                        str &= "," & Converts.ToStr(drDaily("ActiveStatus"))
                        If Converts.ToInt_NullIsZero(drDaily("LossFlag")) = 1 Then
                            str &= "," & drDaily("LossDate")
                            str &= "," & Converts.ToStr(drDaily("LossRemark"))
                        Else
                            str &= ","
                            str &= ","
                        End If
                        str &= "," & Converts.ToStr(drDaily("License"))
                        If Converts.ToStr(drDaily("ShipDate")) <> "" Then
                            str &= "," & drDaily("ShipDate")
                        Else
                            str &= ","
                        End If
                        If Converts.ToStr(drDaily("TruckRemark")) <> "" Then
                            str &= "," & drDaily("TruckRemark")
                        Else
                            str &= ","
                        End If
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

    Private Sub PrintSum()
        Try
            If grdData.DataSource Is Nothing Then MessageBox.Show("No Data") : Exit Sub
            Dim chkDataExists As Boolean = False
            Dim dt As DataTable = grdData.DataSource
            For Each dr As DataRow In dt.Select()
                If Converts.ToInt_NullIsZero(dr("chk")) = 1 Then
                    chkDataExists = True
                    Exit For
                End If
            Next

            Dim Printed As Boolean = False

            Dim csvFilePath As String = INI.OutLogPath & "\Sum" & Format(SystemDate, "yyyyMMddHHmmss") & ".csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFilePath, False)
            outFile.WriteLine("Customer,LOG Date,Rack ID.,Model,Rack No.,Show,Remark,Rack Status,Date Scan,Time Scan,Scan User,Date Upload,Time Upload,User Upload, Status, Loss Date, Loss Remark,Truck,ShipDate,Truck Remark")

            For Each dr As DataRow In dt.Select()
                Dim str As String = ""
                If Converts.ToInt_NullIsZero(dr("chk")) = 1 Then
                    Dim dtDaily As DataTable = cls.GetDailyLog(dr("LogDate"))
                    For Each drDaily As DataRow In dtDaily.Select()
                        Str = "MB"
                        Str &= "," & dr("LogDate")
                        Str &= "," & Converts.ToStr(drDaily("RackID"))
                        Str &= "," & Converts.ToStr(drDaily("Model"))
                        Str &= "," & Converts.ToStr(drDaily("RackNo"))
                        Str &= "," & Converts.ToStr(drDaily("Show"))
                        Str &= "," & Converts.ToStr(drDaily("Remark"))
                        Str &= "," & Converts.ToStr(drDaily("RackStatus"))
                        Str &= "," & drDaily("ScanDate")
                        Str &= "," & drDaily("ScanTime")
                        Str &= "," & Converts.ToStr(drDaily("ScanUser"))
                        Str &= "," & drDaily("UploadDate")
                        Str &= "," & drDaily("UploadTime")
                        Str &= "," & Converts.ToStr(drDaily("UploadUser"))
                        Str &= "," & Converts.ToStr(drDaily("ActiveStatus"))
                        If Converts.ToInt_NullIsZero(drDaily("LossFlag")) = 1 Then
                            Str &= "," & drDaily("LossDate")
                            Str &= "," & Converts.ToStr(drDaily("LossRemark"))
                        Else
                            Str &= ","
                            Str &= ","
                        End If
                        Str &= "," & Converts.ToStr(drDaily("License"))
                        If Converts.ToStr(drDaily("ShipDate")) <> "" Then
                            Str &= "," & drDaily("ShipDate")
                        Else
                            Str &= ","
                        End If
                        If Converts.ToStr(drDaily("TruckRemark")) <> "" Then
                            str &= "," & drDaily("TruckRemark")
                        Else
                            str &= ","
                        End If
                        outFile.WriteLine(str)
                    Next
                End If

            Next

            outFile.Close()
            Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFilePath))

            Printed = True

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