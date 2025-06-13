Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting
Imports OBSWMC
Imports System.IO

Public Class clsVRackStatus
    Private cls As New clsCRackStatus
    Private ImgZF As Image
    Private dtStatus As DataTable = Nothing
    Private OBSWMC As New OBSWMC.OBSWMC
    Private lsportableDevices As List(Of OBSWMC.PortableDevice)
    Private ColWidth As Integer = 150

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

        If dtStatus.Rows.Count > 0 Then
            btnEdit.Enabled = True
        End If
    End Sub
#End Region
#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .Rows.Clear()
            For i As Integer = 0 To CustomizeSetting.INI.RackColumn - 1
                .ColumnAdd_Picture("Col" & i, "Col" & i, Nothing, ColWidth, , , , "Col" & i)
            Next
            .RowHeadersVisible = False
        End With
    End Sub
    Private Sub grdData_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        btnEdit.PerformClick()
    End Sub
    Private Sub grdData_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEnter
        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        If e.RowIndex = 0 OrElse (e.RowIndex - 1) Mod 3 = 0 Then
            Dim DTRow As Integer = (((e.RowIndex - 1) / 3) * RackColumn) + e.ColumnIndex
            If DTRow >= 0 AndAlso DTRow <= dtStatus.Rows.Count - 1 Then btnEdit.Enabled = True Else btnEdit.Enabled = False
        Else
            btnEdit.Enabled = False
        End If
    End Sub
#End Region

    Private Sub clsVRackStatus_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        ShowStatus()
    End Sub
    Private Sub ShowStatus()
        If dtStatus Is Nothing OrElse dtStatus.Rows.Count = 0 Then txtRackQty.Text = "" : Exit Sub

        txtRackQty.Text = Format(dtStatus.Rows.Count, "#,###")

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

        With grdData
            .Rows.Add((AllRow) * 3)

            Dim iRow As Integer = 0
            Dim iCol As Integer = 0

            For iTypeLoop As Integer = 1 To 2
                Dim iType As Integer : If iTypeLoop = 1 Then iType = SystemINI.ModelType.Front Else iType = SystemINI.ModelType.Rear

                For Each drRackStatus As DataRow In dtStatus.Select("Type=" & iType & "")
                    Dim RowData1 As Integer = iRow
                    Dim RowData2 As Integer = iRow + 1
                    Dim RowData3 As Integer = iRow + 2

                    '=====================================
                    Dim PicBrush As New SolidBrush(Color.FromArgb(drRackStatus("ColorA"), drRackStatus("ColorR"), drRackStatus("ColorG"), drRackStatus("ColorB")))
                    '=====================================
                    Dim Pic As New Bitmap(ColWidth, 30)
                    Dim PicGraphics As Graphics = Graphics.FromImage(Pic)
                    PicGraphics.FillRectangle(PicBrush, 0, 0, ColWidth, 30)
                    Dim fPic As Font = New Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                    Dim fStyle As New SolidBrush(Color.Black)
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
                With grdData
                    If .Rows.Count > 0 AndAlso iCol <> 0 Then
                        Dim LastRow As Integer = iRow + 3
                        If LastRow = 3 Then
                            For iCol2 As Integer = RackColumn - 1 To iCol Step -1
                                grdData.Columns.Remove("Col" & iCol2)
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
                End With
            Next
        End With

    End Sub
    Private Sub ShowStatus_BK2()
        If dtStatus Is Nothing OrElse dtStatus.Rows.Count = 0 Then txtRackQty.Text = "" : Exit Sub

        txtRackQty.Text = Format(dtStatus.Rows.Count, "#,###")
        Dim AllRow As Integer = 0
        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        If dtStatus.Rows.Count Mod RackColumn = 0 Then
            AllRow = dtStatus.Rows.Count / RackColumn
        Else
            AllRow = (dtStatus.Rows.Count - (dtStatus.Rows.Count Mod RackColumn)) / RackColumn + 1
        End If
        With grdData
            .Rows.Add(AllRow * 3)
            Dim iRow As Integer = 0
            Dim iCol As Integer = 0
            For Each drRackStatus As DataRow In dtStatus.Select()
                Dim RowHeader As Integer = iRow
                Dim RowPicture As Integer = iRow + 1
                Dim RowFooter As Integer = iRow + 2
                Dim YMaxValue As Integer = 150

                '===========Header====================
                Dim RackHeader As New Bitmap(YMaxValue, 30)
                Dim RackGraphics As Graphics = Graphics.FromImage(RackHeader)
                Dim RackGraphicsBrush As New SolidBrush(Color.FromArgb(drRackStatus("ColorA"), drRackStatus("ColorR"), drRackStatus("ColorG"), drRackStatus("ColorB")))
                RackGraphics.FillRectangle(RackGraphicsBrush, 0, 0, 150, 30)
                Dim fHeader As Font = New Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                Dim fStyle As Brush
                fStyle = New SolidBrush(Color.Black)
                Dim HDSize As SizeF = RackGraphics.MeasureString(drRackStatus("Code") & drRackStatus("RackNo"), fHeader)
                RackGraphics.DrawString(drRackStatus("Code") & drRackStatus("RackNo"), fHeader, fStyle, (YMaxValue - HDSize.Width) / 2, 7.0)

                .Rows(RowHeader).Cells(iCol).Value = RackHeader
                '===========Status=================
                Select Case drRackStatus("RackStatus")
                    Case CustomizeSetting.INI.Status_ZF : .Rows(RowPicture).Cells("Col" & iCol).Value = My.Resources.StateZF
                    Case CustomizeSetting.INI.Status_MB : .Rows(RowPicture).Cells("Col" & iCol).Value = My.Resources.StateMB
                    Case CustomizeSetting.INI.Status_OnTruck : .Rows(RowPicture).Cells("Col" & iCol).Value = My.Resources.StateOntruck
                    Case CustomizeSetting.INI.Status_Supplier : .Rows(RowPicture).Cells("Col" & iCol).Value = My.Resources.StateSupplier
                    Case CustomizeSetting.INI.Status_ExtWH : .Rows(RowPicture).Cells("Col" & iCol).Value = My.Resources.StateExtWH
                End Select
                .Rows(RowPicture).Height = 80
                '===========Footer====================
                Dim RowH As Integer = IIf(RowFooter = (AllRow * 3) - 1, 30, 40)
                Dim RackFooter As New Bitmap(150, RowH)
                Dim RackFGraphics As Graphics = Graphics.FromImage(RackFooter)
                Dim RackFGraphicsBrush As New SolidBrush(Color.FromArgb(drRackStatus("ColorA"), drRackStatus("ColorR"), drRackStatus("ColorG"), drRackStatus("ColorB")))
                RackFGraphics.FillRectangle(RackFGraphicsBrush, 0, 0, 150, 30)
                Dim fFooterFont As Font = New Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                Dim fFooterStyle As Brush
                fFooterStyle = New SolidBrush(Color.Black)
                Dim FSize As SizeF = RackGraphics.MeasureString(drRackStatus("RackStatus"), fFooterFont)
                RackFGraphics.DrawString(drRackStatus("RackStatus"), fFooterFont, fFooterStyle, (YMaxValue - FSize.Width) / 2, 7)
                .Rows(RowFooter).Cells(iCol).Value = RackFooter
                .Rows(RowFooter).Height = RowH
                '===========End====================

                iCol += 1
                If iCol >= RackColumn Then
                    iRow += 3
                    iCol = 0
                End If
            Next

            With grdData
                If .Rows.Count > 0 AndAlso iCol <> 0 Then
                    If grdData.Rows.Count = 3 Then
                        For iCol2 As Integer = RackColumn - 1 To iCol Step -1
                            grdData.Columns.Remove("Col" & iCol2)
                        Next
                    Else
                        Dim iRow2 As Integer = .Rows.Count - 3
                        Dim YMaxValue As Integer = 150
                        For iCol2 As Integer = iCol To RackColumn - 1
                            Dim RackHeader = New Bitmap(YMaxValue, 30)
                            Dim RackGraphics As Graphics = Graphics.FromImage(RackHeader)
                            RackGraphics.FillRectangle(Brushes.White, 0, 0, 150, 30)
                            .Rows(iRow2).Cells(iCol2).Value = RackHeader
                            '====================================
                            RackHeader = New Bitmap(YMaxValue, 80)
                            RackGraphics = Graphics.FromImage(RackHeader)
                            RackGraphics.FillRectangle(Brushes.White, 0, 0, 150, 80)
                            .Rows(iRow2 + 1).Cells(iCol2).Value = RackHeader
                            '====================================
                            RackHeader = New Bitmap(YMaxValue, 30)
                            RackGraphics = Graphics.FromImage(RackHeader)
                            RackGraphics.FillRectangle(Brushes.White, 0, 0, 150, 30)
                            .Rows(iRow2 + 2).Cells(iCol2).Value = RackHeader
                            '====================================
                        Next
                    End If
                End If
            End With

        End With
    End Sub

    Private Sub ShowStatus_BK1()
        If dtStatus Is Nothing OrElse dtStatus.Rows.Count = 0 Then txtRackQty.Text = "" : Exit Sub

        txtRackQty.Text = dtStatus.Rows.Count
        Dim AllRow As Integer = 0
        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        If dtStatus.Rows.Count Mod RackColumn = 0 Then
            AllRow = dtStatus.Rows.Count / RackColumn
        Else
            AllRow = (dtStatus.Rows.Count - (dtStatus.Rows.Count Mod RackColumn)) / RackColumn + 1
        End If
        With grdData
            .Rows.Add(AllRow * 2)
            Dim iRow As Integer = 0
            Dim iCol As Integer = 0
            For Each drRackStatus As DataRow In dtStatus.Select()
                '===========Header====================
                Dim RackHeader As New Bitmap(150, 30)
                Dim RackGraphics As Graphics = Graphics.FromImage(RackHeader)
                RackGraphics.FillRectangle(Brushes.White, 0, 0, 150, 30)
                Dim fHeader As Font = New Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                Dim fStyle As Brush
                If drRackStatus("ColorA") = 255 And drRackStatus("ColorR") = 255 And drRackStatus("ColorG") = 255 And drRackStatus("ColorB") = 255 Then
                    fStyle = New SolidBrush(Color.Black)
                Else
                    fStyle = New SolidBrush(Color.FromArgb(drRackStatus("ColorA"), drRackStatus("ColorR"), drRackStatus("ColorG"), drRackStatus("ColorB")))
                End If
                RackGraphics.DrawString(drRackStatus("Code") & drRackStatus("RackNo"), fHeader, fStyle, 30.0, 7.0)
                .Rows(iRow).Cells(iCol).Value = RackHeader
                '===========Status=================
                Select Case drRackStatus("RackStatus")
                    Case CustomizeSetting.INI.Status_ZF : .Rows(iRow + 1).Cells("Col" & iCol).Value = My.Resources.StateZF
                    Case CustomizeSetting.INI.Status_MB : .Rows(iRow + 1).Cells("Col" & iCol).Value = My.Resources.StateMB
                    Case CustomizeSetting.INI.Status_OnTruck : .Rows(iRow + 1).Cells("Col" & iCol).Value = My.Resources.StateOntruck
                    Case CustomizeSetting.INI.Status_Supplier : .Rows(iRow + 1).Cells("Col" & iCol).Value = My.Resources.StateSupplier
                    Case CustomizeSetting.INI.Status_ExtWH : .Rows(iRow + 1).Cells("Col" & iCol).Value = My.Resources.StateExtWH
                End Select
                .Rows(iRow + 1).Height = 80
                .Rows(iRow + 1).Cells("Col" & iCol).Style.BackColor = Color.FromArgb(drRackStatus("ColorA"), drRackStatus("ColorR"), drRackStatus("ColorG"), drRackStatus("ColorB"))
                '===========End====================

                iCol += 1
                If iCol >= RackColumn Then
                    iRow += 2
                    iCol = 0
                End If
            Next
        End With
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnEdit.Click
        If grdData.CurrentCell Is Nothing Then Exit Sub
        If grdData.CurrentCell.RowIndex Mod 3 = 0 Then Exit Sub

        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        Dim Row As Integer = grdData.CurrentCell.RowIndex
        Dim Col As Integer = grdData.CurrentCell.ColumnIndex
        Dim DTRow As Integer = ((Row - 1) / 3 * RackColumn) + Col

        If DTRow > dtStatus.Rows.Count - 1 Then Exit Sub


        Dim drStatus As DataRow = dtStatus.Rows(DTRow)

        Dim frm As New clsVChangeStatus
        frm.mRackDTID = drStatus("RackDTID")
        If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            Dim RackStatus As String = frm.DialogResultData
            dtStatus.Rows(DTRow)("RackStatus") = RackStatus
            With grdData.Rows(Row).Cells(Col)
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
    Private Sub btnEdit_BK_Click(sender As System.Object, e As OPE_Controls.EventArgs)
        If grdData.CurrentCell Is Nothing Then Exit Sub
        If grdData.CurrentCell.RowIndex Mod 2 = 0 Then Exit Sub

        Dim RackColumn As Integer = CustomizeSetting.INI.RackColumn
        Dim Row As Integer = grdData.CurrentCell.RowIndex
        Dim Col As Integer = grdData.CurrentCell.ColumnIndex
        Dim DTRow As Integer = ((Row - 1) / 2 * RackColumn) + Col

        If DTRow > dtStatus.Rows.Count - 1 Then Exit Sub


        Dim drStatus As DataRow = dtStatus.Rows(DTRow)

        Dim frm As New clsVChangeStatus
        frm.mRackDTID = drStatus("RackDTID")
        If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            Dim RackStatus As String = frm.DialogResultData
            dtStatus.Rows(DTRow)("RackStatus") = RackStatus
            With grdData.Rows(Row).Cells(Col)
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
        grdData_BindingGridColumns()
        LoadData()
        ShowStatus()
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
        Dim HandyFile As String = INI.MstHandyPath & INI.MstFilename


        Dim obj As Object = OBSWMC.getFile(HandyFile)
        If Not obj Is Nothing Then
            OBSWMC.DeleteFile(HandyFile)
            If (String.IsNullOrEmpty(OBSWMC.Err)) = False Then
                Return False
            End If
        End If

        OBSWMC.CopyFileToDevice(PCPath, INI.MstHandyPath)
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