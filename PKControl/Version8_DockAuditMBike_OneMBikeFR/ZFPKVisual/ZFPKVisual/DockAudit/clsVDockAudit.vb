Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVDockAudit
    Private cls As New clsCDockAudit
#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_TextBox("AuditDate", "Audit Date", "AuditDate", 150)
            .ColumnAdd_TextBox("AxleShockName", "Axle/Shock", "AxleShockName", 150)
            .ColumnAdd_TextBox("Area", "Area", "Area", 150)
            .ColumnAdd_TextBox("ModelDock", "Model", "ModelDock", 150)
            .ColumnAdd_TextBox("Varian", "Variant", "Varian", 150)
            .ColumnAdd_TextBox("PartNo", "Part No.", "PartNo", 150)
            .ColumnAdd_TextBox("Lot", "Lot No", "Lot", 150)
            .ColumnAdd_CheckBox("CorrectedFlag", "Corrected", "CorrectedFlag", , , , True)
            .ColumnAdd_Picture("SetDate", "Set Date", My.Resources.BtnCalendar, 80)
            .ColumnAdd_Picture("Print", "Print", My.Resources.BtnGridPrint, 80)

            .ColumnAdd_TextBox("sta", "sta", "sta", , , , , False)
        End With
    End Sub
#End Region

    Private Sub SetRowHight()
        With grdData
            For iRow As Integer = 0 To grdData.RowCount - 1
                .Rows(iRow).Height = 40
            Next
        End With
    End Sub

    Private Sub clsVDockAudit_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        ComboSet.DateTime(dtpSAuditDate1, chkSAuditDate, dtpSAuditDate2)
        Dim CurDate As Date = SystemDate.Date
        'Dim Date1 As Date = New Date(CurDate.Year, CurDate.Month, 1)
        'Dim Date2 As Date = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, Date1))
        dtpSAuditDate1.Value = CurDate
        dtpSAuditDate2.Value = CurDate
        chkSAuditDate.Checked = True


        With cboSArea
            .ValueMember = "ID"
            .DisplayMember = "AreaName"
            .DataSource = DataBase.DataSelect("CstArea" _
                                              , , , , "ID,AreaName" _
                                              , , , "AreaName")
            .SelectedIndex = -1
            .LinkCheckedBox = chkSArea
        End With

        With cboSModelDock
            .ValueMember = "ModelDock"
            .DisplayMember = "ModelDock"
            .DataSource = DataBase.DataTable("select distinct ModelDock from MstModelDock order by ModelDock")
            .SelectedIndex = -1
            .LinkCheckedBox = chkSModelDock
        End With

        With cboSVariant
            .ValueMember = "Variant"
            .DisplayMember = "Variant"
            .DataSource = DataBase.DataTable("select distinct Variant from MstPart order by Variant")
            .SelectedIndex = -1
            .LinkCheckedBox = chkSModelDock
        End With

        With cboAxleShock
            .ValueMember = "AxleShockValue"
            .DisplayMember = "AxleShockName"
            .DataSource = DataBase.DataSelect("CstAxleShock", , , , , , , "AxleShockValue")
            .SelectedIndex = -1
            .LinkCheckedBox = chkSAxleShock
        End With

        btnDelete.Visible = True
        btnSync.Enabled = INI.EnableSync
        btnNew.Visible = False
    End Sub

    Private Sub clsVDockAudit_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        btnEdit.Visible = False
        SetRowHight()
    End Sub

    Private Sub grdData_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellClick
        If grdData.DataSource Is Nothing Or grdData.SelectedRow Is Nothing Then Exit Sub
        If Not (e.ColumnIndex = grdData.Columns("SetDate").Index Or e.ColumnIndex = grdData.Columns("Print").Index) Then Exit Sub

        Select Case e.ColumnIndex
            Case grdData.Columns("SetDate").Index
                If grdData.SelectedRow("AxleShockName") = "Axle" Then
                    Me.Cursor = Cursors.WaitCursor
                    Dim frm As New clsVSetDate
                    frm.mRowDockAudit = grdData.SelectedRow
                    frm.ShowDialog()
                    grdData.Rows(e.RowIndex).Cells("SetDate").Value = My.Resources.BtnCalendar
                    Me.Cursor = Cursors.Default
                Else
                    MsgBox("Please set date for Axle")
                End If

            Case grdData.Columns("Print").Index
                Me.Cursor = Cursors.WaitCursor
                grdData.Rows(e.RowIndex).Cells("Print").Value = My.Resources.BtnGridHourglass1
                Dim ctl As New clsPDockAudit
                ctl.Print(grdData.SelectedRow)
                grdData.Rows(e.RowIndex).Cells("Print").Value = My.Resources.BtnGridPrint
                Me.Cursor = Cursors.Default
        End Select
    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick
        If grdData.DataSource Is Nothing Or grdData.SelectedRow Is Nothing Then Exit Sub
        If Not (e.ColumnIndex = grdData.Columns("CorrectedFlag").Index) Then Exit Sub

        btnSave.Enabled = True
    End Sub

    Private Sub btnSync_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSync.Click
        Dim frm As New clsVSynDockAudit
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSearch.Click
        Dim iArea As Integer = 0
        If cboSArea.SelectedIndex >= 0 Then iArea = cboSArea.SelectedValue

        Dim sModelDock As String = ""
        If cboSModelDock.SelectedIndex >= 0 Then sModelDock = cboSModelDock.SelectedValue

        Dim sVariant As String = ""
        If cboSVariant.SelectedIndex >= 0 Then sVariant = cboSVariant.SelectedValue

        Dim iAxleShockValue As Integer = 0
        If cboAxleShock.SelectedIndex >= 0 Then iAxleShockValue = cboAxleShock.SelectedValue

        Dim dt As DataTable = cls.getDockAudit(chkSAuditDate.Checked, dtpSAuditDate1.Value.Date, dtpSAuditDate2.Value.Date _
                                               , chkSArea.Checked, iArea _
                                               , chkSModelDock.Checked, sModelDock _
                                               , chkSVaraint.Checked, sVariant _
                                               , chkSLot.Checked, txtSLot.Text.Trim _
                                               , chkSAxleShock.Checked, iAxleShockValue)
        grdData.DataSource = dt
        grdData_BindingGridColumns()

        SetRowHight()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSave.Click
        Dim dtGrd As DataTable = grdData.DataSource
        Dim sql As String = ""
        Dim iCorreced As Integer = 0
        For Each drGrd As DataRow In dtGrd.Select()
            iCorreced = Converts.ToInt_NullIsZero(drGrd("CorrectedFlag"))
            Dim str() As String = getPrgDockAudit(drGrd, True)
            For i As Integer = 0 To str.Length - 1
                If Converts.ToStr(str(i)) <> "" Then
                    sql = "update PrgDockAudit set CorrectedFlag=" & iCorreced & " where ID=" & str(i) & ""
                    DataBase.runSQL(sql)
                End If
            Next
        Next
    End Sub

    Private Function getPrgDockAudit(drGrd As DataRow, CheckComplete As Boolean) As String()
        Dim sRackID() As String = Strings.Split(drGrd("RackID"), ",")

        Dim cond As String = "where MstRackDT.RackID in ("
        For i As Integer = 0 To sRackID.Length - 1
            If i > 0 Then cond &= ","
            cond &= "'" & sRackID(i) & "'"
        Next
        cond &= ")"
        If CheckComplete = True Then 'ถ้าไม่เช็ค Complete คือ เอาทั้งหมด
            cond &= "and CompleteFlag=1"
        End If
        Dim sModelDockID As Integer = drGrd("ModelDockID")
        Dim sVarian As String = drGrd("Varian")
        Dim iAxleShock_Axle As Integer = drGrd("AxleShockValue")
        Dim sql As String = String.Format( _
            "select PrgDockAudit.ID {0}" & _
            "from PrgDockAudit {0}" & _
            "inner join MstRackDT on PrgDockAudit.RackDTID=MstRackDT.ID and MstRackDT.DelFlag=0 {0}" & _
            "{1}{0}" & _
            "and ModelDockID=" & sModelDockID & " {0}" & _
            "and Varian='" & sVarian & "' {0}" & _
            "order by Barcode {0}" & _
            "", vbCrLf, cond)
        Dim dt As DataTable = DataBase.DataTable(sql)
        Dim str(dt.Rows.Count) As String
        For i As Integer = 0 To dt.Rows.Count - 1
            str(i) = dt.Rows(i)("ID")
        Next

        Return str
    End Function

    Private Sub btnDelete_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnDelete.Click
        If btnSave.Enabled = True Then
            MsgBox("Please save data before delete")
            Exit Sub
        End If
        If grdData.SelectedRow Is Nothing Then Exit Sub

        Dim strPass As String = InputBox("Please enter password for remove data")
        If strPass = INI.AuthorRemove Then
            Dim str() As String = getPrgDockAudit(grdData.SelectedRow, False)
            If Delete(getPrgDockAudit(grdData.SelectedRow, False)) = True Then
                btnSearch.PerformClick()
            End If
        Else
            MsgBox("Invalid Password")
        End If
    End Sub

    Private Function Delete(str() As String) As Boolean
        Dim sql As String = ""
        DataBase.BeginTrans()

        Try
            For i As Integer = 0 To str.Length - 1
                If Converts.ToStr(str(i)) <> "" Then
                    Dim dt1 As DataTable = DataBase.DataSelect("PrgDockAudit", "ID=" & str(i) & "")
                    For Each dr1 As DataRow In dt1.Select()
                        Dim dt2 As DataTable = DataBase.DataSelect("PrgDockAuditShock", "BarcodeHD='" & dr1("Barcode") & "' and Rev=" & dr1("Rev") & "")
                        'Result,UpdateUser,UdpateDate
                        For Each dr2 As DataRow In dt2.Select()
                            Dim chkdup As DataTable = DataBase.DataSelect("PrgDockAuditShock_deleted", "BarcodeHD='" & dr2("BarcodeHD") & "' and Rev=" & dr2("Rev") & " and Barcode='" & dr2("Barcode") & "'")
                            If chkdup.Rows.Count = 0 Then
                                If DataBase.DataInsert("PrgDockAuditShock_deleted", dr2) = False Then GoTo Err
                            Else
                                Dim drdup As DataRow = chkdup.Rows(0)
                                If DataBase.runSQL("update PrgDockAuditShock_deleted set Result='" & dr2("Result") & "', UpdateUser=" & dr2("UpdateUser") & ",UpdateDate=getdate() where BarcodeHD='" & dr2("BarcodeHD") & "' and Rev=" & dr2("Rev") & " and Barcode='" & dr2("Barcode") & "'") = False Then GoTo Err
                            End If
                            If DataBase.DataDelete("PrgDockAuditShock", dr2) = False Then GoTo Err
                        Next

                        If DataBase.DataInsertUpdate("PrgDockAudit_deleted", dr1) = False Then GoTo Err
                        If DataBase.DataDelete("PrgDockAudit", dr1) = False Then GoTo Err
                    Next
                End If
            Next

            DataBase.CommitTrans()
            Return True
        Catch ex As Exception
            GoTo Err
        End Try
Err:
        DataBase.RollbackTrans()
        Return False
    End Function
End Class