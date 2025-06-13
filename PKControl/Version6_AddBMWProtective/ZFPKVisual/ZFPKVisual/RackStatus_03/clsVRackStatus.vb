Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports OBSWMC
Imports System.IO

Public Class clsVRackStatus
    Private cls As New clsCRackStatus
    Private ImgZF As Image
    Private OBSWMC As New OBSWMC.OBSWMC
    Private lsportableDevices As List(Of OBSWMC.PortableDevice)
    Private ColWidth As Integer = 150
    Private dtStatus As DataTable = Nothing
    Private dtFront As DataTable = Nothing
    Private dtRear As DataTable = Nothing

#Region "Load"
    Private Sub clsVRackStatus_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
    Private Sub LoadForm()
        With cboSType
            .ValueMember = "ID"
            .DisplayMember = "Name"
            .DataSource = DataBase.DataSelect("CstModelType")
            .LinkCheckedBox = chkSType
        End With
        With cboSModel
            .ValueMember = "ID"
            .DisplayMember = "Model"
            .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0", , , , , , "Model")
            .LinkCheckedBox = chkSModel
        End With
        With cboSCode
            .ValueMember = "Code"
            .DisplayMember = "Code"
            .DataSource = DataBase.DataSelect("MstRackHD", "DelFlag=0", , , "distinct Code", , , "Code")
            .LinkCheckedBox = chkSCode
        End With
        With cboSRemark
            .ValueMember = "Remark"
            .DisplayMember = "Remark"
            .DataSource = DataBase.DataSelect("MstRackHD", "DelFlag=0", , , "distinct Remark", , , "Remark")
            .LinkCheckedBox = chkSRemark
        End With
        With cboSStatus
            .ValueMember = "RackStatus"
            .DisplayMember = "RackStatus"
            .DataSource = DataBase.DataTable("select '" & CustomizeSetting.INI.Status_ZF & "' as RackStatus,1 as SortOrder " & _
                                             "union select '" & CustomizeSetting.INI.Status_MB & "' as RackStatus,2 as SortOrder " & _
                                             "union select '" & CustomizeSetting.INI.Status_OnTruck & "' as RackStatus,3 as SortOrder " & _
                                             "union select '" & CustomizeSetting.INI.Status_Supplier & "' as RackStatus,4 as SortOrder " & _
                                             "union select '" & CustomizeSetting.INI.Status_ExtWH & "' as RackStatus,5 as SortOrder " & _
                                             "order by SortOrder")
            .LinkCheckedBox = chkSStatus
        End With

    End Sub
    Private Sub LoadData()
        Dim fSearchStatus As Boolean = chkSStatus.Checked
        Dim strRackStatus As String = cboSStatus.SelectedValue

        dtStatus = cls.GetData(chkSType.Checked, cboSType.SelectedValue _
                                , chkSModel.Checked, cboSModel.SelectedValue _
                                , chkSCode.Checked, cboSCode.SelectedValue _
                                , chkSRemark.Checked, cboSRemark.SelectedValue _
                                , fSearchStatus, strRackStatus)
        dtFront = dtStatus.Clone
        dtRear = dtStatus.Clone

        If dtStatus.Rows.Count > 0 Then
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelType.Front & "", "Model,Code,Remark,RackNo")
                dtFront.ImportRow(dr)
            Next
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelType.Rear & "", "Model,Code,Remark,RackNo")
                dtRear.ImportRow(dr)
            Next
            btnEdit.Enabled = True
        End If
    End Sub
#End Region
#Region " Grid Font "
    Private Sub grdFront_BindingGridColumns() Handles grdFront.BindingGridColumns
        With grdFront
            .Columns.Clear()
            .Rows.Clear()
            For i As Integer = 0 To CustomizeSetting.INI.RackColumn - 1
                .ColumnAdd_Picture("Col" & i, "Col" & i, Nothing, ColWidth, , , , "Col" & i)
            Next
            .RowHeadersVisible = False
        End With
    End Sub
    Private Sub grdFront_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFront.CellDoubleClick
        btnEdit.PerformClick()
    End Sub
    Private Sub grdFront_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFront.CellEnter
        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        If e.RowIndex = 0 OrElse (e.RowIndex - 1) Mod 3 = 0 Then
            Dim DTRow As Integer = (((e.RowIndex - 1) / 3) * RackColumn) + e.ColumnIndex
            If DTRow >= 0 AndAlso DTRow <= dtFront.Rows.Count - 1 Then btnEdit.Enabled = True Else btnEdit.Enabled = False
        Else
            btnEdit.Enabled = False
        End If
    End Sub
#End Region
#Region " Grid Rear "
    Private Sub grdRear_BindingGridColumns() Handles grdRear.BindingGridColumns
        With grdRear
            .Columns.Clear()
            .Rows.Clear()
            For i As Integer = 0 To CustomizeSetting.INI.RackColumn - 1
                .ColumnAdd_Picture("Col" & i, "Col" & i, Nothing, ColWidth, , , , "Col" & i)
            Next
            .RowHeadersVisible = False
        End With
    End Sub
    Private Sub grdRear_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRear.CellDoubleClick
        btnEdit.PerformClick()
    End Sub
    Private Sub grdRear_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRear.CellEnter
        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        If e.RowIndex = 0 OrElse (e.RowIndex - 1) Mod 3 = 0 Then
            Dim DTRow As Integer = (((e.RowIndex - 1) / 3) * RackColumn) + e.ColumnIndex
            If DTRow >= 0 AndAlso DTRow <= dtRear.Rows.Count - 1 Then btnEdit.Enabled = True Else btnEdit.Enabled = False
        Else
            btnEdit.Enabled = False
        End If
    End Sub
#End Region

    Private Sub clsVRackStatus_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        ShowStatus()
    End Sub
    Private Sub ShowStatus()
        If dtStatus Is Nothing OrElse dtStatus.Rows.Count = 0 Then txtRackQty.Text = "" : txtFront.Text = "" : txtRear.Text = "" : Exit Sub

        txtRackQty.Text = Format(dtStatus.Rows.Count, "#,###")
        txtFront.Text = Format(dtFront.Rows.Count, "#,###")
        txtRear.Text = Format(dtRear.Rows.Count, "#,###")

        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn

        '=================================
        Dim RowFront As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelType.Front)
        If RowFront > 0 Then
            If RowFront Mod RackColumn = 0 Then RowFront = RowFront / RackColumn Else RowFront = (RowFront - (RowFront Mod RackColumn)) / RackColumn + 1
        End If
        Dim RowRear As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelType.Rear)
        If RowRear > 0 Then
            If RowRear Mod RackColumn = 0 Then RowRear = RowRear / RackColumn Else RowRear = (RowRear - (RowRear Mod RackColumn)) / RackColumn + 1
        End If
        Dim AllRow As Integer = RowFront + RowRear
        '=================================




        For iTypeLoop As Integer = 1 To 2
            Dim iType As Integer = IIf(iTypeLoop = 1, SystemINI.ModelType.Front, SystemINI.ModelType.Rear)
            Dim dtShow As DataTable = IIf(iType = SystemINI.ModelType.Front, dtFront, dtRear)
            Dim grdShow As OPE_Controls.opeDataGrid = IIf(iType = SystemINI.ModelType.Front, grdFront, grdRear)

            With grdShow
                Dim RowAdd As Integer = IIf(iType = SystemINI.ModelType.Front, RowFront, RowRear)
                If RowAdd > 0 Then
                    .Rows.Add(RowAdd * 3)

                    Dim iRow As Integer = 0
                    Dim iCol As Integer = 0

                    For Each drRackStatus As DataRow In dtShow.Select()
                        Dim RowData1 As Integer = iRow
                        Dim RowData2 As Integer = iRow + 1
                        Dim RowData3 As Integer = iRow + 2

                        '=====================================
                        Dim PicBrush As New SolidBrush(Color.FromArgb(drRackStatus("ColorA"), drRackStatus("ColorR"), drRackStatus("ColorG"), drRackStatus("ColorB")))
                        '=====================================
                        Dim Pic As New Bitmap(ColWidth, 50)
                        Dim PicGraphics As Graphics = Graphics.FromImage(Pic)
                        PicGraphics.FillRectangle(PicBrush, 0, 0, ColWidth, 50)
                        Dim fPic As Font = New Drawing.Font("Microsoft Sans Serif", 14, FontStyle.Bold)
                        Dim fStyle As New SolidBrush(Color.White)
                        Dim PicSize As SizeF = PicGraphics.MeasureString(drRackStatus("Code") & drRackStatus("RackNo"), fPic)
                        PicGraphics.DrawString(drRackStatus("Code") & drRackStatus("RackNo"), fPic, fStyle, ((ColWidth - PicSize.Width) / 2), 15.0)
                        .Rows(RowData1).Height = 50
                        .Rows(RowData1).Cells(iCol).Value = Pic
                        '=====================================
                        Select Case drRackStatus("RackStatus")
                            Case CustomizeSetting.INI.Status_ZF : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateZF
                            Case CustomizeSetting.INI.Status_MB : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateMB
                            Case CustomizeSetting.INI.Status_OnTruck : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateOntruck
                            Case CustomizeSetting.INI.Status_Supplier : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateSupplier
                            Case CustomizeSetting.INI.Status_ExtWH : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateExtWH
                        End Select
                        .Rows(RowData2).Height = 80
                        '=====================================
                        Dim RowH As Integer = IIf(RowData3 = (AllRow * 3) - 1, 30, 40)
                        Pic = New Bitmap(150, RowH)
                        PicGraphics = Graphics.FromImage(Pic)
                        PicGraphics.FillRectangle(PicBrush, 0, 0, ColWidth, 30)
                        PicSize = PicGraphics.MeasureString(drRackStatus("RackStatus"), fPic)
                        PicGraphics.DrawString(drRackStatus("RackStatus"), fPic, fStyle, (ColWidth - PicSize.Width) / 2, 7.0)
                        .Rows(RowData3).Cells(iCol).Value = Pic
                        .Rows(RowData3).Height = RowH
                        '===========End====================

                        iCol += 1
                        If iCol >= RackColumn Then
                            iRow += 3
                            iCol = 0
                        End If
                    Next
                    If .Rows.Count > 0 AndAlso iCol <> 0 Then
                        Dim LastRow As Integer = iRow + 3
                        If LastRow = 3 Then
                            For iCol2 As Integer = RackColumn - 1 To iCol Step -1
                                .Columns.Remove("Col" & iCol2)
                            Next
                        Else
                            Dim iRow2 As Integer = LastRow - 3
                            For iCol2 As Integer = iCol To RackColumn - 1
                                Dim Pic = New Bitmap(ColWidth, 30)
                                Dim PicGraphics As Graphics = Graphics.FromImage(Pic)
                                PicGraphics.FillRectangle(Brushes.White, 0, 0, ColWidth, 30)
                                .Rows(iRow2).Cells(iCol2).Value = Pic
                                '====================================
                                Pic = New Bitmap(ColWidth, 80)
                                PicGraphics = Graphics.FromImage(Pic)
                                PicGraphics.FillRectangle(Brushes.White, 0, 0, ColWidth, 80)
                                .Rows(iRow2 + 1).Cells(iCol2).Value = Pic
                                '====================================
                                Pic = New Bitmap(ColWidth, 30)
                                PicGraphics = Graphics.FromImage(Pic)
                                PicGraphics.FillRectangle(Brushes.White, 0, 0, ColWidth, 30)
                                .Rows(iRow2 + 2).Cells(iCol2).Value = Pic
                                '====================================
                            Next
                        End If

                        iRow += 3
                        iCol = 0
                    End If
                End If
            End With
        Next

    End Sub

    Private Sub ShowStatus_BK()
        If dtStatus Is Nothing OrElse dtStatus.Rows.Count = 0 Then txtRackQty.Text = "" : Exit Sub

        txtRackQty.Text = Format(dtStatus.Rows.Count, "#,###")
        txtFront.Text = Format(dtFront.Rows.Count, "#,###")
        txtRear.Text = Format(dtRear.Rows.Count, "#,###")

        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn

        '=================================
        Dim RowFront As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelType.Front)
        If RowFront > 0 Then
            If RowFront Mod RackColumn = 0 Then RowFront = RowFront / RackColumn Else RowFront = (RowFront - (RowFront Mod RackColumn)) / RackColumn + 1
        End If
        Dim RowRear As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelType.Rear)
        If RowRear > 0 Then
            If RowRear Mod RackColumn = 0 Then RowRear = RowRear / RackColumn Else RowRear = (RowRear - (RowRear Mod RackColumn)) / RackColumn + 1
        End If
        Dim AllRow As Integer = RowFront + RowRear
        '=================================




        For iTypeLoop As Integer = 1 To 2
            Dim iType As Integer = IIf(iTypeLoop = 1, SystemINI.ModelType.Front, SystemINI.ModelType.Rear)
            Dim dtShow As DataTable = IIf(iType = SystemINI.ModelType.Front, dtFront, dtRear)
            Dim grdShow As OPE_Controls.opeDataGrid = IIf(iType = SystemINI.ModelType.Front, grdFront, grdRear)

            With grdShow
                Dim RowAdd As Integer = IIf(iType = SystemINI.ModelType.Front, RowFront, RowRear)
                If RowAdd > 0 Then
                    .Rows.Add(RowAdd * 3)

                    Dim iRow As Integer = 0
                    Dim iCol As Integer = 0

                    For Each drRackStatus As DataRow In dtShow.Select()
                        Dim RowData1 As Integer = iRow
                        Dim RowData2 As Integer = iRow + 1
                        Dim RowData3 As Integer = iRow + 2

                        '=====================================
                        Dim PicBrush As New SolidBrush(Color.FromArgb(drRackStatus("ColorA"), drRackStatus("ColorR"), drRackStatus("ColorG"), drRackStatus("ColorB")))
                        '=====================================
                        Dim Pic As New Bitmap(ColWidth, 30)
                        Dim PicGraphics As Graphics = Graphics.FromImage(Pic)
                        PicGraphics.FillRectangle(PicBrush, 0, 0, ColWidth, 30)
                        Dim fPic As Font = New Drawing.Font("Microsoft Sans Serif", 14, FontStyle.Bold)
                        Dim fStyle As New SolidBrush(Color.White)
                        Dim PicSize As SizeF = PicGraphics.MeasureString(drRackStatus("Code") & drRackStatus("RackNo"), fPic)
                        PicGraphics.DrawString(drRackStatus("Code") & drRackStatus("RackNo"), fPic, fStyle, (ColWidth - PicSize.Width) / 2, 7.0)
                        .Rows(RowData1).Cells(iCol).Value = Pic
                        '=====================================
                        Select Case drRackStatus("RackStatus")
                            Case CustomizeSetting.INI.Status_ZF : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateZF
                            Case CustomizeSetting.INI.Status_MB : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateMB
                            Case CustomizeSetting.INI.Status_OnTruck : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateOntruck
                            Case CustomizeSetting.INI.Status_Supplier : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateSupplier
                            Case CustomizeSetting.INI.Status_ExtWH : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateExtWH
                        End Select
                        .Rows(RowData2).Height = 80
                        '=====================================
                        Dim RowH As Integer = IIf(RowData3 = (AllRow * 3) - 1, 30, 40)
                        Pic = New Bitmap(150, RowH)
                        PicGraphics = Graphics.FromImage(Pic)
                        PicGraphics.FillRectangle(PicBrush, 0, 0, ColWidth, 30)
                        PicSize = PicGraphics.MeasureString(drRackStatus("RackStatus"), fPic)
                        PicGraphics.DrawString(drRackStatus("RackStatus"), fPic, fStyle, (ColWidth - PicSize.Width) / 2, 7.0)
                        .Rows(RowData3).Cells(iCol).Value = Pic
                        .Rows(RowData3).Height = RowH
                        '===========End====================

                        iCol += 1
                        If iCol >= RackColumn Then
                            iRow += 3
                            iCol = 0
                        End If
                    Next
                    If .Rows.Count > 0 AndAlso iCol <> 0 Then
                        Dim LastRow As Integer = iRow + 3
                        If LastRow = 3 Then
                            For iCol2 As Integer = RackColumn - 1 To iCol Step -1
                                .Columns.Remove("Col" & iCol2)
                            Next
                        Else
                            Dim iRow2 As Integer = LastRow - 3
                            For iCol2 As Integer = iCol To RackColumn - 1
                                Dim Pic = New Bitmap(ColWidth, 30)
                                Dim PicGraphics As Graphics = Graphics.FromImage(Pic)
                                PicGraphics.FillRectangle(Brushes.White, 0, 0, ColWidth, 30)
                                .Rows(iRow2).Cells(iCol2).Value = Pic
                                '====================================
                                Pic = New Bitmap(ColWidth, 80)
                                PicGraphics = Graphics.FromImage(Pic)
                                PicGraphics.FillRectangle(Brushes.White, 0, 0, ColWidth, 80)
                                .Rows(iRow2 + 1).Cells(iCol2).Value = Pic
                                '====================================
                                Pic = New Bitmap(ColWidth, 30)
                                PicGraphics = Graphics.FromImage(Pic)
                                PicGraphics.FillRectangle(Brushes.White, 0, 0, ColWidth, 30)
                                .Rows(iRow2 + 2).Cells(iCol2).Value = Pic
                                '====================================
                            Next
                        End If

                        iRow += 3
                        iCol = 0
                    End If
                End If
            End With
        Next

    End Sub


    Private Sub btnEdit_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnEdit.Click
        Dim grdShow As OPE_Controls.opeDataGrid
        Dim dtShow As DataTable
        If TabControl1.SelectedIndex = 0 Then
            grdShow = grdFront
            dtShow = dtFront
        Else
            grdShow = grdRear
            dtShow = dtRear
        End If
        If grdShow.CurrentCell Is Nothing Then Exit Sub
        If grdShow.CurrentCell.RowIndex Mod 3 = 0 Then Exit Sub

        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        Dim Row As Integer = grdShow.CurrentCell.RowIndex
        Dim Col As Integer = grdShow.CurrentCell.ColumnIndex
        Dim DTRow As Integer = ((Row - 1) / 3 * RackColumn) + Col

        If DTRow > dtShow.Rows.Count - 1 Then Exit Sub


        Dim drStatus As DataRow = dtShow.Rows(DTRow)

        Dim frm As New clsVChangeStatus
        frm.mRackDTID = drStatus("RackDTID")
        If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            Dim RackStatus As String = frm.DialogResultData
            dtShow.Rows(DTRow)("RackStatus") = RackStatus
            With grdShow.Rows(Row).Cells(Col)
                Select Case RackStatus
                    Case CustomizeSetting.INI.Status_ZF : .Value = My.Resources.StateZF
                    Case CustomizeSetting.INI.Status_MB : .Value = My.Resources.StateMB
                    Case CustomizeSetting.INI.Status_OnTruck : .Value = My.Resources.StateOntruck
                    Case CustomizeSetting.INI.Status_Supplier : .Value = My.Resources.StateSupplier
                    Case CustomizeSetting.INI.Status_ExtWH : .Value = My.Resources.StateExtWH
                End Select
            End With
        End If


    End Sub
    
    Private Sub btnSearch_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Click
        grdFront_BindingGridColumns()
        grdRear_BindingGridColumns()
        LoadData()
        ShowStatus()

        If grdFront.RowCount = 0 And grdRear.RowCount > 0 Then
            TabControl1.SelectedIndex = 1
        Else
            TabControl1.SelectedIndex = 0
        End If
        
    End Sub

    Private Sub btnSearch_Validate(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Validate
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        If chkSType.Checked And cboSType.SelectedIndex < 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, cboSType, OPE_Controls.MessageType.PleaseSelectDataInList)
        If chkSModel.Checked And cboSModel.SelectedIndex < 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, cboSModel, OPE_Controls.MessageType.PleaseSelectDataInList)
        If chkSCode.Checked And cboSCode.SelectedIndex < 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, cboSCode, OPE_Controls.MessageType.PleaseSelectDataInList)
        If chkSRemark.Checked And cboSRemark.SelectedIndex < 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, cboSType, OPE_Controls.MessageType.PleaseSelectDataInList)
        If chkSStatus.Checked And cboSStatus.SelectedIndex < 0 Then bTrue = bTrue And Messages.SetError(ErrProvider, cboSStatus, OPE_Controls.MessageType.PleaseSelectDataInList)

        If Not bTrue Then e.DialogResult = Windows.Forms.DialogResult.No
    End Sub

#Region "Sync"
    Private Sub btnSync_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSync.Click
        Dim frm As New clsVSyncronize
        frm.ShowDialog()

        'If DeviceConnect() = False Then
        '    MessageBox.Show("No Device")
        'ElseIf LoadTransaction() = False Then
        '    MessageBox.Show("Load Transaction Error")
        'ElseIf UpdateTransaction() = False Then
        '    MessageBox.Show("Update Transaction Error")
        'ElseIf CreateMasterFile() = False Then
        '    MessageBox.Show("Create Master File Error")
        'ElseIf SendMasterFile() = False Then
        '    MessageBox.Show("Send Master To Handy Error")
        'ElseIf BackupTransactionFile() = False Then
        '    MessageBox.Show("Backup Transfer file Error")
        'Else
        '    MessageBox.Show("Syncronize successfully")
        'End If

    End Sub
    Private Function DeviceConnect() As Boolean
        lsportableDevices = OBSWMC.getDevices()
        If lsportableDevices.Count <= 0 Then Return False
        'MC92000
        Dim iPortable As Integer = -1
        For iLoop As Integer = 0 To lsportableDevices.Count - 1
            If InStr(lsportableDevices(iLoop).Name.ToUpper, "MC92000", CompareMethod.Text) Then
                iPortable = iLoop
            End If
        Next

        OBSWMC.PortableDevice = lsportableDevices(iPortable)
        If OBSWMC.Connect() Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function LoadTransaction() As Boolean
        'File from handy
        'ID,RackDTID,StaffCode,Rack,Ramark,Model,Code,Running,ScanDateTime,From,To

        Return True
    End Function

    Private Function UpdateTransaction() As Boolean

        Return True
    End Function
    Private Function CreateMasterFile() As Boolean
        'RackDTID,Rack,Remark,Model,Code,Running,Current
        'ScanDateTiem,Model,Code,RackNo,RackStatus,ColorA,ColorR,ColorG,ColorB,RackDTID
        Try
            Dim dt As DataTable = cls.GetData(False, 0 _
                                           , False, "" _
                                           , False, "" _
                                           , False, "" _
                                           , False, "")

            If Directory.Exists(INI.InterfaceMst) = False Then
                Directory.CreateDirectory(INI.InterfaceMst)
            End If
            If File.Exists(INI.InterfaceMst & INI.MstFilename) Then
                File.Delete(INI.InterfaceMst & INI.MstFilename)
            End If

            Dim RCHCmd As New FileStream(INI.InterfaceMst & INI.MstFilename, FileMode.OpenOrCreate, FileAccess.Write)
            Dim RCHCmdW As New StreamWriter(RCHCmd)
            'RackDTID,Rack,Remark,Model,Code,Running,Current--->Handy's DB
            'ScanDateTiem,Model,Code,RackNo,RackStatus,ColorA,ColorR,ColorG,ColorB,RackDTID -->
            For Each dr As DataRow In dt.Rows
                Dim str As String = dr("RackDTID").ToString
                str = str & "|" & dr("RackID").ToString '= Rack in handy
                str = str & "|" & dr("Remark").ToString
                str = str & "|" & dr("Model").ToString
                str = str & "|" & dr("Code").ToString
                str = str & "|" & dr("RackNo").ToString '= Running in handy
                str = str & "|" & dr("RackStatus").ToString

                RCHCmdW.WriteLine(str)
            Next
            RCHCmdW.Close()
            RCHCmd.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function
    Private Function SendMasterFile() As Boolean
        Dim PCPath As String = INI.InterfaceMst & INI.MstFilename
        Dim HandyFile As String = INI.HandyInterface & INI.MstFilename


        Dim obj As Object = OBSWMC.getFile(HandyFile)
        If Not obj Is Nothing Then
            OBSWMC.DeleteFile(HandyFile)
            If (String.IsNullOrEmpty(OBSWMC.Err)) = False Then
                Return False
            End If
        End If

        OBSWMC.CopyFileToDevice(PCPath, INI.HandyInterface)
        If (String.IsNullOrEmpty(OBSWMC.Err)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function BackupTransactionFile() As Boolean
        Return True
    End Function

#End Region

    
End Class