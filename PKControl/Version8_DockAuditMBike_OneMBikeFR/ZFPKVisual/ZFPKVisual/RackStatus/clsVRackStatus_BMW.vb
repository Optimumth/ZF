Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports OBSWMC
Imports System.IO

Public Class clsVRackStatus_BMW
    Private cls As New clsCRackStatus
    Private ImgZF As Image
    Private OBSWMC As New OBSWMC.OBSWMC
    Private lsportableDevices As List(Of OBSWMC.PortableDevice)
    Private ColWidth As Integer = 250 '150
    Private dtStatus As DataTable = Nothing
    Private dtFront As DataTable = Nothing
    Private dtRear As DataTable = Nothing
    Private dtFrontRear As DataTable = Nothing
    Private dtSTB As DataTable = Nothing
    Private dtMBike As DataTable = Nothing
    Private dtPTC As DataTable = Nothing

#Region "Load"
    Private Sub clsVRackStatus_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If

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
            .DataSource = DataBase.DataSelect("MstModel" _
                                                  , "DelFlag=0" _
                                                  , , _
                                                  , "ID " & _
                                                    ",case when Model=ModelContainer then Model else Model + ' (' + ModelContainer + ')' end as Model" & _
                                                    ",FrontFlag,RearFlag,FrontRearFlag,STBFlag,MBikeFlag" & _
                                                    ",ColorA,ColorR,ColorG,ColorB" & _
                                                    ",ModelContainer,ModelContainerSeq,PTCFlag" & _
                                                    ",DelFlag" & _
                                                    ",CreateUser,CreateDate,UpdateUser,UpdateDate" _
                                                  , , _
                                                  , "Model")
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
                                             "union select '" & CustomizeSetting.INI.Status_FG & "' as RackStatus,2 as SortOrder " & _
                                             "union select '" & CustomizeSetting.INI.Status_Customer & "' as RackStatus,3 as SortOrder " & _
                                             "union select '" & CustomizeSetting.INI.Status_OnTruck & "' as RackStatus,4 as SortOrder " & _
                                             "union select '" & CustomizeSetting.INI.Status_Supplier & "' as RackStatus,5 as SortOrder " & _
                                             "union select '" & CustomizeSetting.INI.Status_ExtWH & "' as RackStatus,6 as SortOrder " & _
                                             "union select '" & CustomizeSetting.INI.Status_RepairInZF & "' as RackStatus,7 as SortOrder " & _
                                             "order by SortOrder")
            .LinkCheckedBox = chkSStatus
        End With

        chkMBOverDue.Text = "Rack pending at " & CustomerCode

        'btnSync.Enabled = INI.EnableSync
    End Sub
    Private Sub LoadData()
        Dim fSearchStatus As Boolean = chkSStatus.Checked
        Dim strRackStatus As String = cboSStatus.SelectedValue

        dtStatus = cls.GetData(chkSType.Checked, cboSType.SelectedValue _
                                , chkSModel.Checked, cboSModel.SelectedValue _
                                , chkSCode.Checked, cboSCode.SelectedValue _
                                , chkSRemark.Checked, cboSRemark.SelectedValue _
                                , fSearchStatus, strRackStatus _
                                , chkMBOverDue.Checked)
        dtFront = dtStatus.Clone
        dtRear = dtStatus.Clone
        dtFrontRear = dtStatus.Clone
        dtSTB = dtStatus.Clone
        dtMBike = dtStatus.Clone
        dtPTC = dtStatus.Clone

        If dtStatus.Rows.Count > 0 Then
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelTypeBMW.Front & "", "Code,RackNo")
                dtFront.ImportRow(dr)
            Next
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelTypeBMW.Rear & "", "Code,RackNo")
                dtRear.ImportRow(dr)
            Next
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelTypeBMW.FrontRear & "", "Code,RackNo")
                dtFrontRear.ImportRow(dr)
            Next
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelTypeBMW.STB & "", "Code,RackNo")
                dtSTB.ImportRow(dr)
            Next
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelTypeBMW.MBike & "", "Code,RackNo")
                dtMBike.ImportRow(dr)
            Next
            For Each dr As DataRow In dtStatus.Select("Type=" & SystemINI.ModelTypeBMW.PTC & "", "Code,RackNo")
                dtPTC.ImportRow(dr)
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
#Region " Grid Front & Rear "
    Private Sub grdFrontRear_BindingGridColumns() Handles grdFrontRear.BindingGridColumns
        With grdFrontRear
            .Columns.Clear()
            .Rows.Clear()
            For i As Integer = 0 To CustomizeSetting.INI.RackColumn - 1
                .ColumnAdd_Picture("Col" & i, "Col" & i, Nothing, ColWidth, , , , "Col" & i)
            Next
            .RowHeadersVisible = False
        End With
    End Sub
    Private Sub grdFrontRear_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFrontRear.CellDoubleClick
        btnEdit.PerformClick()
    End Sub
    Private Sub grdFrontRear_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFrontRear.CellEnter
        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        If e.RowIndex = 0 OrElse (e.RowIndex - 1) Mod 3 = 0 Then
            Dim DTRow As Integer = (((e.RowIndex - 1) / 3) * RackColumn) + e.ColumnIndex
            If DTRow >= 0 AndAlso DTRow <= dtFrontRear.Rows.Count - 1 Then btnEdit.Enabled = True Else btnEdit.Enabled = False
        Else
            btnEdit.Enabled = False
        End If
    End Sub
#End Region
#Region " Grid BPS "
    Private Sub grdSTB_BindingGridColumns() Handles grdSTB.BindingGridColumns
        With grdSTB
            .Columns.Clear()
            .Rows.Clear()
            For i As Integer = 0 To CustomizeSetting.INI.RackColumn - 1
                .ColumnAdd_Picture("Col" & i, "Col" & i, Nothing, ColWidth, , , , "Col" & i)
            Next
            .RowHeadersVisible = False
        End With
    End Sub
    Private Sub grdSTB_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSTB.CellDoubleClick
        btnEdit.PerformClick()
    End Sub
    Private Sub grdSTB_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSTB.CellEnter
        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        If e.RowIndex = 0 OrElse (e.RowIndex - 1) Mod 3 = 0 Then
            Dim DTRow As Integer = (((e.RowIndex - 1) / 3) * RackColumn) + e.ColumnIndex
            If DTRow >= 0 AndAlso DTRow <= dtSTB.Rows.Count - 1 Then btnEdit.Enabled = True Else btnEdit.Enabled = False
        Else
            btnEdit.Enabled = False
        End If
    End Sub
#End Region

#Region " Grid M-Bike Front "
    Private Sub grdMBikeFront_BindingGridColumns() Handles grdMBike.BindingGridColumns
        With grdMBike
            .Columns.Clear()
            .Rows.Clear()
            For i As Integer = 0 To CustomizeSetting.INI.RackColumn - 1
                .ColumnAdd_Picture("Col" & i, "Col" & i, Nothing, ColWidth, , , , "Col" & i)
            Next
            .RowHeadersVisible = False
        End With
    End Sub
    Private Sub grdMBikeFront_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdMBike.CellDoubleClick
        btnEdit.PerformClick()
    End Sub
    Private Sub grdMBike_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdMBike.CellEnter
        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        If e.RowIndex = 0 OrElse (e.RowIndex - 1) Mod 3 = 0 Then
            Dim DTRow As Integer = (((e.RowIndex - 1) / 3) * RackColumn) + e.ColumnIndex
            If DTRow >= 0 AndAlso DTRow <= dtMBike.Rows.Count - 1 Then btnEdit.Enabled = True Else btnEdit.Enabled = False
        Else
            btnEdit.Enabled = False
        End If
    End Sub
#End Region

#Region " Grid PTC "
    Private Sub grdPTC_BindingGridColumns() Handles grdPTC.BindingGridColumns
        With grdPTC
            .Columns.Clear()
            .Rows.Clear()
            For i As Integer = 0 To CustomizeSetting.INI.RackColumn - 1
                .ColumnAdd_Picture("Col" & i, "Col" & i, Nothing, ColWidth, , , , "Col" & i)
            Next
            .RowHeadersVisible = False
        End With
    End Sub
    Private Sub grdPTC_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPTC.CellDoubleClick
        btnEdit.PerformClick()
    End Sub
    Private Sub grdPTC_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPTC.CellEnter
        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        If e.RowIndex = 0 OrElse (e.RowIndex - 1) Mod 3 = 0 Then
            Dim DTRow As Integer = (((e.RowIndex - 1) / 3) * RackColumn) + e.ColumnIndex
            If DTRow >= 0 AndAlso DTRow <= dtPTC.Rows.Count - 1 Then btnEdit.Enabled = True Else btnEdit.Enabled = False
        Else
            btnEdit.Enabled = False
        End If
    End Sub
#End Region
    Private Sub clsVRackStatus_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ShowStatus()
    End Sub
    Private Sub ShowStatus()
        If dtStatus Is Nothing OrElse dtStatus.Rows.Count = 0 Then
            txtRackQty.Text = "" : txtFront.Text = "" : txtRear.Text = "" : txtFrontRear.Text = ""
            txtSTB.Text = "" : txtMBike.Text = "" : txtPTCQty.Text = ""
            Exit Sub
        End If
        If chkMBOverDue.Checked = False Then lblRackQty.Text = "Rack Qty" Else lblRackQty.Text = "Over Due"

        txtRackQty.Text = Format(dtStatus.Rows.Count - dtPTC.Rows.Count, "#,###")
        txtFront.Text = Format(dtFront.Rows.Count, "#,###")
        txtRear.Text = Format(dtRear.Rows.Count, "#,###")
        txtFrontRear.Text = Format(dtFrontRear.Rows.Count, "#,###")
        txtSTB.Text = Format(dtSTB.Rows.Count, "#,###")
        txtMBike.Text = Format(dtMBike.Rows.Count, "#,###")
        txtPTCQty.Text = Format(dtPTC.Rows.Count, "#,###")


        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn

        '=================================
        Dim RowFront As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelTypeBMW.Front)
        If RowFront > 0 Then
            If RowFront Mod RackColumn = 0 Then RowFront = RowFront / RackColumn Else RowFront = (RowFront - (RowFront Mod RackColumn)) / RackColumn + 1
        End If
        Dim RowRear As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelTypeBMW.Rear)
        If RowRear > 0 Then
            If RowRear Mod RackColumn = 0 Then RowRear = RowRear / RackColumn Else RowRear = (RowRear - (RowRear Mod RackColumn)) / RackColumn + 1
        End If
        Dim RowFrontRear As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelTypeBMW.FrontRear)
        If RowFrontRear > 0 Then
            If RowFrontRear Mod RackColumn = 0 Then RowFrontRear = RowFrontRear / RackColumn Else RowFrontRear = (RowFrontRear - (RowFrontRear Mod RackColumn)) / RackColumn + 1
        End If
        Dim RowSTB As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelTypeBMW.STB)
        If RowSTB > 0 Then
            If RowSTB Mod RackColumn = 0 Then RowSTB = RowSTB / RackColumn Else RowSTB = (RowSTB - (RowSTB Mod RackColumn)) / RackColumn + 1
        End If
        Dim RowMBike As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelTypeBMW.MBike)
        If RowMBike > 0 Then
            If RowMBike Mod RackColumn = 0 Then RowMBike = RowMBike / RackColumn Else RowMBike = (RowMBike - (RowMBike Mod RackColumn)) / RackColumn + 1
        End If
        Dim RowPTC As Integer = dtStatus.Compute("count(Type)", "Type=" & SystemINI.ModelTypeBMW.PTC)
        If RowPTC > 0 Then
            If RowPTC Mod RackColumn = 0 Then RowPTC = RowPTC / RackColumn Else RowPTC = (RowPTC - (RowPTC Mod RackColumn)) / RackColumn + 1
        End If

        Dim AllRow As Integer = RowFront + RowRear + RowFrontRear + RowSTB + RowMBike
        '=================================

        For iTypeLoop As Integer = 1 To 6
            Dim iType As Integer = 0
            Select Case iTypeLoop
                Case 1 : iType = SystemINI.ModelTypeBMW.Front
                Case 2 : iType = SystemINI.ModelTypeBMW.Rear
                Case 3 : iType = SystemINI.ModelTypeBMW.FrontRear
                Case 4 : iType = SystemINI.ModelTypeBMW.STB
                Case 5 : iType = SystemINI.ModelTypeBMW.MBike
                Case 6 : iType = SystemINI.ModelTypeBMW.PTC
            End Select
            Dim dtShow As DataTable = Nothing
            If iType = SystemINI.ModelTypeBMW.Front Then
                dtShow = dtFront
            ElseIf iType = SystemINI.ModelTypeBMW.Rear Then
                dtShow = dtRear
            ElseIf iType = SystemINI.ModelTypeBMW.FrontRear Then
                dtShow = dtFrontRear
            ElseIf iType = SystemINI.ModelTypeBMW.STB Then
                dtShow = dtSTB
            ElseIf iType = SystemINI.ModelTypeBMW.MBike Then
                dtShow = dtMBike
            Else
                dtShow = dtPTC
            End If

            Dim grdShow As OPE_Controls.opeDataGrid 'IIf(iType = SystemINI.ModelType.Front, grdFront, grdRear)
            Select Case iType
                Case SystemINI.ModelTypeBMW.Front : grdShow = grdFront
                Case SystemINI.ModelTypeBMW.Rear : grdShow = grdRear
                Case SystemINI.ModelTypeBMW.FrontRear : grdShow = grdFrontRear
                Case SystemINI.ModelTypeBMW.STB : grdShow = grdSTB
                Case SystemINI.ModelTypeBMW.MBike : grdShow = grdMBike
                Case Else : grdShow = grdPTC
            End Select

            With grdShow
                Dim RowAdd As Integer = 0 'IIf(iType = SystemINI.ModelType.Front, RowFront, RowRear)
                Select Case iType
                    Case SystemINI.ModelTypeBMW.Front : RowAdd = RowFront
                    Case SystemINI.ModelTypeBMW.Rear : RowAdd = RowRear
                    Case SystemINI.ModelTypeBMW.FrontRear : RowAdd = RowFrontRear
                    Case SystemINI.ModelTypeBMW.STB : RowAdd = RowSTB
                    Case SystemINI.ModelTypeBMW.MBike : RowAdd = RowMBike
                    Case Else : RowAdd = RowPTC
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
                        Dim fPic As Font = New Drawing.Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                        Dim fStyle As New SolidBrush(Color.White)
                        Dim PicSize As SizeF = PicGraphics.MeasureString(drRackStatus("Code") & drRackStatus("RackNo"), fPic)
                        PicGraphics.DrawString(drRackStatus("Code") & drRackStatus("RackNo"), fPic, fStyle, ((ColWidth - PicSize.Width) / 2), 15.0)
                        If RowData1 = 6 And iType = SystemINI.ModelTypeBMW.STB Then
                            Dim a As Integer
                            a = 1
                        End If
                        .Rows(RowData1).Height = 50
                        .Rows(RowData1).Cells(iCol).Value = Pic
                        '=====================================
                        Select Case drRackStatus("RackStatus")
                            Case CustomizeSetting.INI.Status_ZF : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateZF : .Rows(RowData2).DataGridView.BackgroundColor = Color.Gray
                            Case CustomizeSetting.INI.Status_Customer : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateBMW
                            Case CustomizeSetting.INI.Status_OnTruck : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateOntruck
                            Case CustomizeSetting.INI.Status_Supplier : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateSupplier
                            Case CustomizeSetting.INI.Status_ExtWH : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateExtWH
                            Case CustomizeSetting.INI.Status_FG : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateFG
                            Case CustomizeSetting.INI.Status_RepairInZF : .Rows(RowData2).Cells("Col" & iCol).Value = My.Resources.StateRepairInZF
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
                        Pic = New Bitmap(250, RowH) 'Pic = New Bitmap(150, RowH)
                        PicGraphics = Graphics.FromImage(Pic)
                        PicGraphics.FillRectangle(PicBrush, 0, 0, ColWidth, 30)
                        PicSize = PicGraphics.MeasureString(sDraw, fPic)
                        If drRackStatus("RackStatus") = CustomizeSetting.INI.Status_Customer Then
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
        If TabControl.SelectedIndex = SystemINI.ModelTypeBMW.Front Then
            grdShow = grdFront
            dtShow = dtFront
        ElseIf TabControl.SelectedIndex = SystemINI.ModelTypeBMW.Rear Then
            grdShow = grdRear
            dtShow = dtRear
        ElseIf TabControl.SelectedIndex = SystemINI.ModelTypeBMW.FrontRear Then
            grdShow = grdFrontRear
            dtShow = dtFrontRear
        ElseIf TabControl.SelectedIndex = SystemINI.ModelTypeBMW.STB Then
            grdShow = grdSTB
            dtShow = dtSTB
        ElseIf TabControl.SelectedIndex = SystemINI.ModelTypeBMW.MBike Then
            grdShow = grdMBike
            dtShow = dtMBike
        Else
            grdShow = grdPTC
            dtShow = dtPTC
        End If
        If grdShow.CurrentCell Is Nothing Then Exit Sub
        If grdShow.CurrentCell.RowIndex Mod 3 = 0 Then Exit Sub

        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        Dim Row As Integer = grdShow.CurrentCell.RowIndex
        Dim Col As Integer = grdShow.CurrentCell.ColumnIndex
        Dim DTRow As Integer = ((Row - 1) / 3 * RackColumn) + Col

        If DTRow > dtShow.Rows.Count - 1 Then Exit Sub


        Dim drStatus As DataRow = dtShow.Rows(DTRow)

        Dim frm As New clsVChangeStatus_BMW
        frm.mRackDTID = drStatus("RackDTID")
        If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            Dim RackStatus As String = frm.DialogResultData
            dtShow.Rows(DTRow)("RackStatus") = RackStatus
            With grdShow.Rows(Row).Cells(Col)
                Select Case RackStatus
                    Case CustomizeSetting.INI.Status_ZF : .Value = My.Resources.StateZF
                    Case CustomizeSetting.INI.Status_Customer : .Value = My.Resources.StateBMW
                    Case CustomizeSetting.INI.Status_OnTruck : .Value = My.Resources.StateOntruck
                    Case CustomizeSetting.INI.Status_Supplier : .Value = My.Resources.StateSupplier
                    Case CustomizeSetting.INI.Status_ExtWH : .Value = My.Resources.StateExtWH
                    Case CustomizeSetting.INI.Status_FG : .Value = My.Resources.StateFG
                    Case CustomizeSetting.INI.Status_RepairInZF : .Value = My.Resources.StateRepairInZF
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
                If drStatus("RackStatus") = CustomizeSetting.INI.Status_Customer Then
                    fStyle = New SolidBrush(Color.Black)
                Else
                    fStyle = New SolidBrush(Color.White)
                End If

                Dim Pic As New Bitmap(250, grdShow.Rows(Row + 1).Height)  'Dim Pic As New Bitmap(150, grdShow.Rows(Row + 1).Height)
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
        grdFrontRear_BindingGridColumns()
        grdSTB_BindingGridColumns()
        grdMBikeFront_BindingGridColumns()
        grdPTC_BindingGridColumns()

        LoadData()
        ShowStatus()


        If grdFront.RowCount > 0 Or grdFront.RowCount + grdRear.RowCount + grdFrontRear.RowCount + grdSTB.RowCount + grdMBike.RowCount + grdPTC.RowCount = 0 Then
            TabControl.SelectedIndex = 0
        ElseIf grdRear.RowCount > 0 Then
            TabControl.SelectedIndex = SystemINI.ModelTypeBMW.Rear
        ElseIf grdFrontRear.RowCount > 0 Then
            TabControl.SelectedIndex = SystemINI.ModelTypeBMW.FrontRear
        ElseIf grdSTB.RowCount > 0 Then
            TabControl.SelectedIndex = SystemINI.ModelTypeBMW.STB
        ElseIf grdMBike.RowCount > 0 Then
            TabControl.SelectedIndex = SystemINI.ModelTypeBMW.MBike
        Else
            TabControl.SelectedIndex = SystemINI.ModelTypeBMW.PTC
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
        'Dim frm As New clsVSyncronize
        Dim frm As New clsVSyncronize_Android
        frm.ShowDialog()
        DataBase.runSQL("exec TruckControl")
    End Sub

#End Region

End Class