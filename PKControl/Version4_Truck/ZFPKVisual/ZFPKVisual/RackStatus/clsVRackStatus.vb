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
    Private dtBPS As DataTable = Nothing

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

        btnSync.Enabled = INI.EnableSync
    End Sub
    Private Sub LoadData()
        Dim fSearchStatus As Boolean = chkSStatus.Checked
        Dim strRackStatus As String = cboSStatus.SelectedValue

        Dim dt As DataTable = cls.GetData(False, 0 _
                                           , False, 0 _
                                           , False, "" _
                                           , False, "" _
                                           , False, "" _
                                           , False)
        dtStatus = cls.GetData(chkSType.Checked, cboSType.SelectedValue _
                                , chkSModel.Checked, cboSModel.SelectedValue _
                                , chkSCode.Checked, cboSCode.SelectedValue _
                                , chkSRemark.Checked, cboSRemark.SelectedValue _
                                , fSearchStatus, strRackStatus _
                                , chkMBOverDue.Checked)
        dtFront = dtStatus.Clone
        dtRear = dtStatus.Clone
        dtBPS = dtStatus.Clone

        If dtStatus.Rows.Count > 0 Then
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelType.Front & "", "Model,Code,Remark,RackNo")
                dtFront.ImportRow(dr)
            Next
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelType.Rear & "", "Model,Code,Remark,RackNo")
                dtRear.ImportRow(dr)
            Next
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelType.BPS & "", "Model,Code,Remark,RackNo")
                dtBPS.ImportRow(dr)
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
#Region " Grid BPS "
    Private Sub grdBPS_BindingGridColumns() Handles grdBPS.BindingGridColumns
        With grdBPS
            .Columns.Clear()
            .Rows.Clear()
            For i As Integer = 0 To CustomizeSetting.INI.RackColumn - 1
                .ColumnAdd_Picture("Col" & i, "Col" & i, Nothing, ColWidth, , , , "Col" & i)
            Next
            .RowHeadersVisible = False
        End With
    End Sub
    Private Sub grdBPS_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdBPS.CellDoubleClick
        btnEdit.PerformClick()
    End Sub
    Private Sub grdBPS_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdBPS.CellEnter
        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        If e.RowIndex = 0 OrElse (e.RowIndex - 1) Mod 3 = 0 Then
            Dim DTRow As Integer = (((e.RowIndex - 1) / 3) * RackColumn) + e.ColumnIndex
            If DTRow >= 0 AndAlso DTRow <= dtBPS.Rows.Count - 1 Then btnEdit.Enabled = True Else btnEdit.Enabled = False
        Else
            btnEdit.Enabled = False
        End If
    End Sub
#End Region

    Private Sub clsVRackStatus_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ShowStatus()
    End Sub
    Private Sub ShowStatus()
        If dtStatus Is Nothing OrElse dtStatus.Rows.Count = 0 Then txtRackQty.Text = "" : txtFront.Text = "" : txtRear.Text = "" : Exit Sub
        If chkMBOverDue.Checked = False Then lblRackQty.Text = "Rack Qty" Else lblRackQty.Text = "Over Due"

        txtRackQty.Text = Format(dtStatus.Rows.Count, "#,###")
        txtFront.Text = Format(dtFront.Rows.Count, "#,###")
        txtRear.Text = Format(dtRear.Rows.Count, "#,###")
        txtBPS.Text = Format(dtBPS.Rows.Count, "#,###")

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
        Dim RowBPS As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelType.BPS)
        If RowBPS > 0 Then
            If RowBPS Mod RackColumn = 0 Then RowBPS = RowBPS / RackColumn Else RowBPS = (RowBPS - (RowBPS Mod RackColumn)) / RackColumn + 1
        End If
        Dim AllRow As Integer = RowFront + RowRear + RowBPS
        '=================================




        For iTypeLoop As Integer = 1 To 3
            Dim iType As Integer = 0 'IIf(iTypeLoop = 1, SystemINI.ModelType.Front, SystemINI.ModelType.Rear)
            Select Case iTypeLoop
                Case 1 : iType = SystemINI.ModelType.Front
                Case 2 : iType = SystemINI.ModelType.Rear
                Case 3 : iType = SystemINI.ModelType.BPS
            End Select
            Dim dtShow As DataTable = Nothing 'IIf(iType = SystemINI.ModelType.Front, dtFront, dtRear)
            If iType = SystemINI.ModelType.Front Then
                dtShow = dtFront
            ElseIf iType = SystemINI.ModelType.Rear Then
                dtShow = dtRear
            Else
                dtShow = dtBPS
            End If

            Dim grdShow As OPE_Controls.opeDataGrid 'IIf(iType = SystemINI.ModelType.Front, grdFront, grdRear)
            Select Case iType
                Case SystemINI.ModelType.Front : grdShow = grdFront
                Case SystemINI.ModelType.Rear : grdShow = grdRear
                Case Else : grdShow = grdBPS
            End Select

            With grdShow
                Dim RowAdd As Integer = 0 'IIf(iType = SystemINI.ModelType.Front, RowFront, RowRear)
                Select Case iType
                    Case SystemINI.ModelType.Front : RowAdd = RowFront
                    Case SystemINI.ModelType.Rear : RowAdd = RowRear
                    Case Else : RowAdd = RowBPS
                End Select
                If RowAdd > 0 Then
                    .Rows.Add(RowAdd * 3)

                    Dim iRow As Integer = 0
                    Dim iCol As Integer = 0

                    For Each drRackStatus As DataRow In dtShow.Select()
                        Dim RowData1 As Integer = iRow
                        Dim RowData2 As Integer = iRow + 1
                        Dim RowData3 As Integer = iRow + 2

                        '=====================================
                        Dim PicBrush As SolidBrush
                        If drRackStatus("LossFlag") = 0 Then
                            PicBrush = New SolidBrush(Color.FromArgb(drRackStatus("ColorA"), drRackStatus("ColorR"), drRackStatus("ColorG"), drRackStatus("ColorB")))
                        Else
                            PicBrush = New SolidBrush(Color.Gray)
                        End If

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
                            Case CustomizeSetting.INI.Status_ZF : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateZF : .Rows(RowData2).DataGridView.BackgroundColor = Color.Gray
                            Case CustomizeSetting.INI.Status_MB : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateMB
                            Case CustomizeSetting.INI.Status_OnTruck : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateOntruck
                            Case CustomizeSetting.INI.Status_Supplier : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateSupplier
                            Case CustomizeSetting.INI.Status_ExtWH : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateExtWH
                        End Select
                        .Rows(RowData2).Height = 80
                        '=====================================
                        Dim sDraw As String = ""
                        If chkMBOverDue.Checked = False Then
                            sDraw = drRackStatus("RackStatus")
                        Else
                            sDraw = Format(drRackStatus("ScanDateTime"), "dd-MMM")
                        End If

                        Dim RowH As Integer = IIf(RowData3 = (AllRow * 3) - 1, 30, 40)
                        Pic = New Bitmap(150, RowH)
                        PicGraphics = Graphics.FromImage(Pic)
                        PicGraphics.FillRectangle(PicBrush, 0, 0, ColWidth, 30)
                        PicSize = PicGraphics.MeasureString(sDraw, fPic)
                        If drRackStatus("RackStatus") = CustomizeSetting.INI.Status_MB Then
                            fStyle = New SolidBrush(Color.Black)
                        Else
                            fStyle = New SolidBrush(Color.White)
                        End If
                        
                        PicGraphics.DrawString(sDraw, fPic, fStyle, (ColWidth - PicSize.Width) / 2, 7.0)
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

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnEdit.Click
        Dim grdShow As OPE_Controls.opeDataGrid
        Dim dtShow As DataTable
        If TabControl.SelectedIndex = 0 Then
            grdShow = grdFront
            dtShow = dtFront
        ElseIf TabControl.SelectedIndex = 1 Then
            grdShow = grdRear
            dtShow = dtRear
        Else
            grdShow = grdBPS
            dtShow = dtBPS
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

            With grdShow.Rows(Row + 1).Cells(Col)
                Dim PicBrush As SolidBrush
                If drStatus("LossFlag") = 0 Then
                    PicBrush = New SolidBrush(Color.FromArgb(drStatus("ColorA"), drStatus("ColorR"), drStatus("ColorG"), drStatus("ColorB")))
                Else
                    PicBrush = New SolidBrush(Color.Gray)
                End If

                Dim fPic As Font = New Drawing.Font("Microsoft Sans Serif", 14, FontStyle.Bold)
                Dim fStyle As New SolidBrush(Color.White)
                If drStatus("RackStatus") = CustomizeSetting.INI.Status_MB Then
                    fStyle = New SolidBrush(Color.Black)
                Else
                    fStyle = New SolidBrush(Color.White)
                End If

                Dim Pic As New Bitmap(150, grdShow.Rows(Row + 1).Height)
                Dim PicGraphics As Graphics = Graphics.FromImage(Pic)
                PicGraphics.FillRectangle(PicBrush, 0, 0, ColWidth, 30)
                Dim PicSize As SizeF = PicGraphics.MeasureString(drStatus("RackStatus"), fPic)
                PicGraphics.DrawString(drStatus("RackStatus"), fPic, fStyle, (ColWidth - PicSize.Width) / 2, 7.0)

                .Value = Pic
            End With

        End If


    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnSearch.Click
        grdFront_BindingGridColumns()
        grdRear_BindingGridColumns()
        grdBPS_BindingGridColumns()
        LoadData()
        ShowStatus()

        If grdFront.RowCount = 0 And grdRear.RowCount > 0 Then
            TabControl.SelectedIndex = 1
        Else
            TabControl.SelectedIndex = 0
        End If
        If grdFront.RowCount > 0 Or grdFront.RowCount + grdRear.RowCount + grdBPS.RowCount = 0 Then
            TabControl.SelectedIndex = 0
        ElseIf grdRear.RowCount > 0 Then
            TabControl.SelectedIndex = 1
        Else
            TabControl.SelectedIndex = 2
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
        DataBase.runSQL("exec TruckControl")
        'Try
        '    Dim chk As New ProductDLL.clsCCheckProtectHasp
        '    If Not chk.CheckProductData(CustomizeSetting.SystemDate) Then
        '        MessageBox.Show("Please plug in USB key")
        '        Exit Sub
        '    Else
        '        MessageBox.Show("OK")
        '        Exit Sub
        '        'Dim frm As New clsVSyncronize
        '        'frm.ShowDialog()
        '    End If
        'Catch ex As Exception
        '    If ex.Message = "Dongle initialization error" Then
        '        MessageBox.Show("Please plug in USB key")
        '        Exit Sub
        '    End If
        'End Try
    End Sub
   
#End Region

End Class