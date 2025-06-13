Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVTruck
    Private cls As New clsCTruck
    Private fNew As Boolean = False
    Private mRow As Integer = 0

#Region "Load"

    Private Sub clsVTruck_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckUpdateData() = False Then e.Cancel = True
    End Sub
    Private Sub clsVTruck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub clsVTruck_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        LoadForm()
        btnSearch.PerformClick()
    End Sub
    Private Sub LoadForm()
        ComboSet.DateTime(dtpSDate1, chkSDate, dtpSDate2)
        Dim CurDate As Date = SystemDate.Date
        Dim Date1 As Date = CurDate
        Dim Date2 As Date = CurDate
        dtpSDate1.Value = Date1
        dtpSDate2.Value = Date2
        chkSDate.Checked = True

        txtSTruckID.LinkCheckedBox = chkSTruckID
        txtSLicense.LinkCheckedBox = chkSLicense


        With cboSPrintStatus
            .ValueMember = "ID"
            .DisplayMember = "Name"
            .DataSource = DataBase.DataTable("select 0 as ID,'Not Yet' as Name union select 1 as ID,'Printed' as Name")
            .LinkCheckedBox = chkSPrintStatus
            .SelectedIndex = -1
        End With

        Dim dtLength As DataTable = ComboSet.GetColumnLength("PrgTruck")
        ComboSet.TextString(txtTruckID, dtLength, "TruckID")
        ComboSet.TextString(txtLicense, dtLength, "License")
        ComboSet.TextString(txtRemark, dtLength, "Remark")

        grpUpdateData.Visible = False
        btnSave.Enabled = False
    End Sub
#End Region

#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()

            .ColumnAdd_TextBox("TruckID", "ID", "TruckID", 150)
            .ColumnAdd_TextBox("License", "Truck ID", "License", 150)
            .ColumnAdd_TextBox("CreateDate", "Ship Date", "CreateDate", 150, , DataGridViewContentAlignment.MiddleCenter, Styles.DateCustomFormat)
            .ColumnAdd_TextBox("RackAmount", "Rack Amount", "RackAmount", 150, , DataGridViewContentAlignment.MiddleRight)
            .ColumnAdd_CheckBox("PrintFlag", "Printed", "PrintFlag", 80)
            .ColumnAdd_Picture("Rack", "Rack", My.Resources.BtnGridTruck, 80)
            .ColumnAdd_Picture("Print", "Print", My.Resources.BtnGridPrint, 80)
            .ColumnAdd_TextBox("Remark", "Remark", "Remark", 200)
            .ColumnAdd_TextBox("sta", "sta", "sta", , , , , False)
        End With
        'ComboSet.GridColumnSize(grdData)
    End Sub

    Private Sub grdData_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        btnEdit.PerformClick()
    End Sub
    Private Sub grdData_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellClick
        If grdData.DataSource Is Nothing Or grdData.SelectedRow Is Nothing Then Exit Sub
        If Not (e.ColumnIndex = grdData.Columns("Rack").Index Or e.ColumnIndex = grdData.Columns("Print").Index) Then Exit Sub

        Dim TruckID As String = Converts.ToStr(grdData.SelectedRow("TruckID"))
        If TruckID = "" OrElse grdData.SelectedRow("sta") <> "" Then
            MessageBox.Show("Please save this record, first")
        Else
            Select Case e.ColumnIndex
                Case grdData.Columns("Rack").Index
                    Dim frm As New clsVTruckDT
                    With frm
                        .RowTruck = grdData.SelectedRow
                        If .ShowDialog() = Windows.Forms.DialogResult.Yes Then
                            grdData.SelectedRow("RackAmount") = Converts.ToInt_NullIsZero(frm.txtRackAmount.Text.Trim)
                        End If
                    End With
                Case grdData.Columns("Print").Index
                    If Converts.ToInt_NullIsZero(grdData.SelectedRow("RackAmount")) = 0 Then MessageBox.Show("No Data") : Exit Sub
                    Me.Cursor = Cursors.WaitCursor
                    grdData.Rows(e.RowIndex).Cells("Print").Value = My.Resources.BtnGridHourglass1
                    Dim dtData As DataTable = cls.GetContainerData(TruckID)
                    Dim ctl As New clsPTruck
                    If ctl.Print(grdData.SelectedRow, dtData) = True Then
                        If cls.SavePrint(TruckID) = True Then
                            grdData.Rows(e.RowIndex).Cells("PrintFlag").Value = True
                        End If
                    End If
                    grdData.Rows(e.RowIndex).Cells("Print").Value = My.Resources.BtnGridPrint
                    Me.Cursor = Cursors.Default
            End Select

        End If
    End Sub
#End Region

#Region "Toolbar Click"
    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnSearch.Click
        If CheckUpdateData() = False Then Exit Sub

        Dim dt As DataTable = cls.GetData(chkSDate.Checked, dtpSDate1.Value.Date, dtpSDate2.Value.Date _
                                          , chkSTruckID.Checked, txtSTruckID.Text.Trim _
                                          , chkSLicense.Checked, txtSLicense.Text.Trim _
                                          , chkSPrintStatus.Checked, cboSPrintStatus.SelectedValue)
        Dim dv As DataView
        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv


        SetRowHight()

    End Sub
    Private Sub SetRowHight()
        With grdData
            For iRow As Integer = 0 To grdData.RowCount - 1
                .Rows(iRow).Height = 40
            Next
        End With
    End Sub

    Private Sub btnSearch_Validate(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnSearch.Validate
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        If chkSDate.Checked And dtpSDate1.Value.Date > dtpSDate2.Value.Date Then bTrue = bTrue And Messages.SetError(ErrProvider, dtpSDate2, OPE_Controls.MessageType.StartDateMustLessThanEndDate)

        If chkSPrintStatus.Checked AndAlso cboSPrintStatus.SelectedIndex < 0 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, cboSPrintStatus, OPE_Controls.MessageType.PleaseSelectDataInList)
        End If

        If Not bTrue Then e.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnSave.Click
        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable
        Dim dtTruck As DataTable = dt.Clone
        For Each dr As DataRow In dt.Select("sta<>''")
            If Not (dr("sta") = "D" And Converts.ToStr(dr("TruckID")) = "") Then
                dtTruck.ImportRow(dr)
            End If
        Next

        cls.SaveData(dtTruck)

        Dim dtnew As DataTable = cls.GetData(chkSDate.Checked, dtpSDate1.Value.Date, dtpSDate2.Value.Date _
                                           , chkSTruckID.Checked, txtSTruckID.Text.Trim _
                                           , chkSLicense.Checked, txtSLicense.Text.Trim _
                                           , chkSPrintStatus.Checked, cboSPrintStatus.SelectedValue)

        If Not dtnew Is Nothing Then
            dv = New DataView(dtnew, "sta<>'D'", "", DataViewRowState.CurrentRows)
            grdData.DataSource = dv

            SetRowHight()

            grpUpdateData.Visible = False
            btnSave.Enabled = False
        End If

        SetRowHight()
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnNew.Click
        fNew = True
        ClearControlDetail()
        grpUpdateData.Visible = True
        txtLicense.Focus()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnEdit.Click
        If CheckUpdateData() = False Then Exit Sub
        If grdData.SelectedRow Is Nothing OrElse grdData.CurrentRow Is Nothing Then Exit Sub

        DisplayUpdate(grdData.SelectedRow, grdData.CurrentRow.Index)
        grpUpdateData.Visible = True
        txtLicense.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnDelete.Click
        If CheckUpdateData() = False Then Exit Sub
        If grdData.SelectedRow Is Nothing Then Exit Sub

        If Strings.Left(grdData.SelectedRow("TruckID"), 1) = "T" Then
            MessageBox.Show("Can't remove ID 'T....'")
            e.DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
        End If
        If Converts.ToInt_NullIsZero(grdData.SelectedRow("RackAmount")) > 0 Then
            MessageBox.Show("Please remove rack in this truck first")
            e.DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
        End If

        grdData.SelectedRow("sta") = "D"
    End Sub

    Private Sub ClearControlDetail()
        txtTruckID.Clear()
        txtLicense.Clear()
        txtRemark.Clear()
        txtRackAmount.Clear()
        dtpDate.Value = SystemDate.Date
        chkPrintFlag.Checked = False
    End Sub

    Private Sub DisplayUpdate(ByVal rGrid As DataRow, ByVal RowIndex As Integer)
        mRow = RowIndex

        ClearControlDetail()

        txtTruckID.Text = rGrid("TruckID")
        txtLicense.Text = Converts.ToStr(rGrid("License"))
        txtRemark.Text = Converts.ToStr(rGrid("Remark"))
        txtRackAmount.Text = Converts.ToInt_NullIsZero(rGrid("RackAmount"))
        dtpDate.Value = rGrid("CreateDate")
        chkPrintFlag.Checked = Converts.ToInt_NullIsZero(rGrid("PrintFlag"))

    End Sub
#End Region

#Region "Data to Grid"
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If OKValidate() = False Then Exit Sub

        DataToGrid()

        SetRowHight()

        ClearControlDetail()
        ErrProvider.Clear()

        grpUpdateData.Visible = False
        fNew = False
        mRow = 0

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearControlDetail()
        ErrProvider.Clear()

        grpUpdateData.Visible = False

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Function OKValidate() As Boolean
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        Return bTrue
    End Function

    Private Sub DataToGrid()
        Dim dv As DataView = grdData.DataSource
        Dim dt As DataTable = dv.ToTable
        Dim drAdd As DataRow = Nothing
        If fNew = True Then
            drAdd = dt.NewRow
            drAdd("TruckID") = ""
            drAdd("RackAmount") = 0
            drAdd("sta") = "N"
        Else
            grdData.Rows(mRow).Selected = True
            drAdd = grdData.SelectedRow
            If drAdd("sta") = "" Then drAdd("sta") = "U"
        End If
        drAdd("License") = txtLicense.Text.Trim
        drAdd("Remark") = txtRemark.Text.Trim
        drAdd("CreateDate") = dtpDate.Value.Date
        drAdd("PrintFlag") = IIf(chkPrintFlag.Checked, 1, 0)

        If fNew = True Then
            dt.Rows.Add(drAdd)
            Dim dvNew As DataView
            dvNew = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
            grdData.DataSource = dvNew
        End If

        btnSave.Enabled = True
    End Sub
#End Region
    Private Function CheckUpdateData() As Boolean
        If grpUpdateData.Visible = True Then
            MessageBox.Show("Please click OK or Cancel to close editing area")
            Return False
        Else
            Return True
        End If
    End Function

End Class