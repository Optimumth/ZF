Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVMstDockAudit
    Private cls As New clsCMstDockAudit
    Private fNew As Boolean = False
    Private mRow As Integer = 0
    Private Enum eCaliper
        NoCaliper = 0
        WithCaliper = 1
    End Enum

#Region "Load"

    Private Sub clsVMstDockAudit_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckUpdateData() = False Then e.Cancel = True
    End Sub
    Private Sub clsVMstDockAudit_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        LoadForm()
    End Sub
    Private Sub LoadForm()
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If

        With cboSModel
            .ValueMember = "ID"
            .DisplayMember = "Model"
            .DataSource = DataBase.DataSelect("MstModel" _
                                              , "DelFlag=0" _
                                              , , , "ID,case when Model=ModelContainer then Model else Model + ' (' + ModelContainer + ')' end as Model" _
                                              , , , "ModelContainerSeq")

            .SelectedIndex = -1
            .LinkCheckedBox = chkSModel
        End With

        With cboModel
            .ValueMember = "ID"
            .DisplayMember = "Model"
            .DataSource = DataBase.DataSelect("MstModel" _
                                              , "DelFlag=0" _
                                              , , , "ID,case when Model=ModelContainer then Model else Model + ' (' + ModelContainer + ')' end as Model,MBikeFlag" _
                                              , , , "ModelContainerSeq")
            .SelectedIndex = -1
        End With

        With cboSModelDock
            .ValueMember = "ModelDock"
            .DisplayMember = "ModelDock"
            .DataSource = DataBase.DataSelect("MstModelDock", "DelFlag=0", , , "distinct ModelDock")
            .LinkCheckedBox = chkSModelDock
            .SelectedIndex = -1
        End With

        With cboSAreaCode
            .ValueMember = "AreaCode"
            .DisplayMember = "AreaCode"
            .DataSource = DataBase.DataTable("select 'F' as AreaCode union select 'R' as AreaCode")
            .LinkCheckedBox = chkSAreaCode
        End With

        Dim iNoCaliper As Integer = eCaliper.NoCaliper
        Dim iWithCaliper As Integer = eCaliper.WithCaliper
        With cboSCaliper
            .ValueMember = "CaliperFlag"
            .DisplayMember = "CaliperText"
            .DataSource = DataBase.DataTable("select " & iWithCaliper & " as CaliperFlag, 'Yes' as CaliperText" & _
                                             " union select " & iNoCaliper & " as CaliperFlag,'No' as CaliperText")
            .LinkCheckedBox = chkSCaliper
        End With

        With cboAreaCode
            .ValueMember = "AreaCode"
            .DisplayMember = "AreaCode"
            .DataSource = DataBase.DataTable("select 'F' as AreaCode union select 'R' as AreaCode")
        End With

        Dim dtLength As DataTable = ComboSet.GetColumnLength("MstModelDock")
        ComboSet.TextString(txtModelDockAudit, dtLength, "ModelDock")

        ComboSet.TextQty(txtRackAmount)

        Dim dt As DataTable = cls.GetData(True, -1, False, "", False, "", False, 0)
        Dim dv As DataView
        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv

        grpUpdateData.Visible = False
        btnSave.Enabled = False
    End Sub
#End Region

#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_TextBox("Model", "Model (Rack)", "Model", 120)
            .ColumnAdd_TextBox("ModelDock", "Model (Dock Audit)", "ModelDock", 120)
            .ColumnAdd_TextBox("AreaCode", "Area Code", "AreaCode", 120)
            .ColumnAdd_CheckBox("CaliperFlag", "Caliper", "CaliperFlag", 120)
            .ColumnAdd_CheckBox("Check1", "Check 1", "Check1")
            .ColumnAdd_CheckBox("Check2", "Check 2", "Check2")
            .ColumnAdd_CheckBox("Check3", "Check 3", "Check3")
            .ColumnAdd_CheckBox("Check4", "Check 4", "Check4")
            .ColumnAdd_CheckBox("Check5", "Check 5", "Check5")
            .ColumnAdd_CheckBox("Check6", "Check 6", "Check6")
            .ColumnAdd_CheckBox("Check7", "Check 7", "Check7")
            .ColumnAdd_CheckBox("ModelID", "ModelID", "ModelID", , , False)
            .ColumnAdd_CheckBox("ID", "ID", "ID", , , False)

        End With
    End Sub

    Private Sub grdData_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        btnEdit.PerformClick()
    End Sub

    Private Sub grdData_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.RowEnter
        Try
            If fNew = False And grpUpdateData.Visible = True Then
                DisplayUpdate(grdData.SelectedRow, grdData.SelectedCells.Item(0).RowIndex)
            End If
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "Toolbar Click"
    Private Sub btnSearch_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Click
        If CheckUpdateData() = False Then Exit Sub


        Dim ModelID As Integer = -1
        Dim ModelDockAudit As String = ""
        Dim AreaCode As String = ""

        If cboSModel.SelectedIndex >= 0 Then ModelID = cboSModel.SelectedRow("ID")
        If Not (cboSModelDock.SelectedRow Is Nothing) Then
            ModelDockAudit = cboSModelDock.SelectedValue
        End If
        If cboSAreaCode.SelectedIndex >= 0 Then AreaCode = cboSAreaCode.SelectedValue

        Dim iCaliperFlag As Integer = 0
        If Not (cboSCaliper.SelectedRow Is Nothing) Then
            iCaliperFlag = cboSCaliper.SelectedValue
        End If
        Dim dt As DataTable = cls.GetData(chkSModel.Checked, ModelID _
                                          , chkSModelDock.Checked, ModelDockAudit _
                                          , chkSAreaCode.Checked, AreaCode _
                                          , chkSCaliper.Checked, iCaliperFlag)
        Dim dv As DataView
        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSave.Click
        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable
        Dim dtModel As DataTable = dt.Clone
        For Each dr As DataRow In dt.Select("sta<>''")
            If Not (dr("sta") = "D" And Converts.ToInt_NullIsZero(dr("ID")) = 0) Then
                dtModel.ImportRow(dr)
            End If
        Next
        If cls.SaveData(dtModel) = True Then
            btnSave.Enabled = False
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnNew.Click
        fNew = True
        ClearControlDetail()
        grpUpdateData.Visible = True
        cboModel.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnEdit.Click
        fNew = False
        If grdData.SelectedRow Is Nothing Then Exit Sub
        If CheckUpdateData() = False Then Exit Sub
        DisplayUpdate(grdData.SelectedRow, grdData.CurrentRow.Index)
        grpUpdateData.Visible = True
        cboModel.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnDelete.Click
        If CheckUpdateData() = False Then Exit Sub
        If grdData.SelectedRow Is Nothing Then Exit Sub

        grdData.SelectedRow("sta") = "D"

    End Sub

    Private Sub ClearControlDetail()
        cboModel.SelectedIndex = -1
        txtModelDockAudit.Clear()
        txtRackAmount.Text = 6
        chkCaliperFlag.Checked = True
        Check1.Checked = False
        Check2.Checked = False
        Check3.Checked = False
        Check4.Checked = False
        Check5.Checked = False
        Check6.Checked = False
        Check7.Checked = False
        btnFormat1.Text = 1 : btnFormat1.Visible = False
        btnFormat2.Text = 1 : btnFormat2.Visible = False
        btnFormat3.Text = 1 : btnFormat3.Visible = False
        btnFormat4.Text = 1 : btnFormat4.Visible = False
        btnFormat5.Text = 1 : btnFormat5.Visible = False
        btnFormat6.Text = 1 : btnFormat6.Visible = False
        btnFormat7.Text = 1 : btnFormat7.Visible = False
    End Sub

    Private Sub DisplayUpdate(rGrid As DataRow, RowIndex As Integer)
        mRow = RowIndex

        cboModel.SelectedValue = rGrid("ModelID")
        txtModelDockAudit.Text = Converts.ToStr(rGrid("ModelDock"))
        cboAreaCode.SelectedValue = rGrid("AreaCode")
        txtRackAmount.Text = Converts.ToInt_NullIsZero(rGrid("RackAmount"))
        chkCaliperFlag.Checked = Converts.ToInt_NullIsZero(rGrid("CaliperFlag"))
        Check1.Checked = Converts.ToInt_NullIsZero(rGrid("Check1"))
        Check2.Checked = Converts.ToInt_NullIsZero(rGrid("Check2"))
        Check3.Checked = Converts.ToInt_NullIsZero(rGrid("Check3"))
        Check4.Checked = Converts.ToInt_NullIsZero(rGrid("Check4"))
        Check5.Checked = Converts.ToInt_NullIsZero(rGrid("Check5"))
        Check6.Checked = Converts.ToInt_NullIsZero(rGrid("Check6"))
        Check7.Checked = Converts.ToInt_NullIsZero(rGrid("Check7"))
        btnFormat1.Text = Converts.ToInt_NullIsZero(rGrid("Format1"))
        btnFormat2.Text = Converts.ToInt_NullIsZero(rGrid("Format2"))
        btnFormat3.Text = Converts.ToInt_NullIsZero(rGrid("Format3"))
        btnFormat4.Text = Converts.ToInt_NullIsZero(rGrid("Format4"))
        btnFormat5.Text = Converts.ToInt_NullIsZero(rGrid("Format5"))
        btnFormat6.Text = Converts.ToInt_NullIsZero(rGrid("Format6"))
        btnFormat7.Text = Converts.ToInt_NullIsZero(rGrid("Format7"))
    End Sub
#End Region

#Region "Data to Grid"
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If OKValidate() = False Then Exit Sub

        DataToGrid()

        ClearControlDetail()
        ErrProvider.Clear()

        grpUpdateData.Visible = False
        fNew = False
        mRow = 0

        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
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

        If cboModel.SelectedIndex < 0 Then
            Messages.SetError(ErrProvider, cboModel, OPE_Controls.MessageType.PleaseSelectDataInList)
            bTrue = False
        End If
        If txtModelDockAudit.Text.Trim = "" Then
            Messages.SetError(ErrProvider, txtModelDockAudit, OPE_Controls.MessageType.PleaseInputData)
            bTrue = False
        End If
        If cboAreaCode.SelectedIndex < 0 Then
            Messages.SetError(ErrProvider, cboAreaCode, OPE_Controls.MessageType.PleaseSelectDataInList)
            bTrue = False
        End If
        If Converts.ToInt_NullIsZero(txtRackAmount.Text.Trim) <= 0 Then
            Messages.SetError(ErrProvider, txtRackAmount, OPE_Controls.MessageType.None, "Qty must be more than zero")
            bTrue = False
        End If


        If bTrue = True Then
            Dim CaliperFlag As Integer = IIf(chkCaliperFlag.Checked, 1, 0)
            If fNew Then
                Dim dv As DataView = grdData.DataSource
                Dim dt As DataTable = dv.ToTable
                If dt.Rows.Count > 0 AndAlso dt.Compute("count(ID)", "ModelID= " & cboModel.SelectedValue & " and ModelDock='" & txtModelDockAudit.Text.Trim & "' and AreaCode='" & cboAreaCode.SelectedValue & "' and CaliperFlag=" & CaliperFlag & "") > 0 Then
                    Messages.SetError(ErrProvider, cboModel, OPE_Controls.MessageType.DataExistPleaseChange)
                    Messages.SetError(ErrProvider, txtModelDockAudit, OPE_Controls.MessageType.DataExistPleaseChange)
                    Messages.SetError(ErrProvider, cboAreaCode, OPE_Controls.MessageType.DataExistPleaseChange)
                    bTrue = False
                Else
                    Dim dtModel As DataTable = DataBase.DataSelect("MstModelDock", "DelFlag=0 and ModelID= " & cboModel.SelectedValue & " and ModelDock='" & txtModelDockAudit.Text.Trim & "' and AreaCode='" & cboAreaCode.SelectedValue & "' and CaliperFlag=" & CaliperFlag & "")
                    If dtModel.Rows.Count > 0 Then
                        Messages.SetError(ErrProvider, cboModel, OPE_Controls.MessageType.DataExistPleaseChange)
                        Messages.SetError(ErrProvider, txtModelDockAudit, OPE_Controls.MessageType.DataExistPleaseChange)
                        Messages.SetError(ErrProvider, cboAreaCode, OPE_Controls.MessageType.DataExistPleaseChange)
                        bTrue = False
                    End If
                End If
            Else
                Dim DuplicateData As Boolean = False
                For iRow As Integer = 0 To grdData.Rows.Count - 1
                    If iRow <> mRow Then
                        If Converts.ToInt_NullIsZero(grdData.Rows(iRow).Cells("ModelID").Value) = cboModel.SelectedValue _
                            And Converts.ToStr(grdData.Rows(iRow).Cells("ModelDock").Value) = txtModelDockAudit.Text.Trim _
                            And Converts.ToStr(grdData.Rows(iRow).Cells("AreaCode").Value) = cboAreaCode.SelectedValue _
                            And Converts.ToInt_NullIsZero(grdData.Rows(iRow).Cells("CaliperFlag").Value) = CaliperFlag Then
                            DuplicateData = True
                            Exit For
                        End If
                    End If
                Next
                If DuplicateData = True Then
                    Messages.SetError(ErrProvider, cboModel, OPE_Controls.MessageType.DataExistPleaseChange)
                    Messages.SetError(ErrProvider, txtModelDockAudit, OPE_Controls.MessageType.DataExistPleaseChange)
                    Messages.SetError(ErrProvider, cboAreaCode, OPE_Controls.MessageType.DataExistPleaseChange)
                    bTrue = False
                Else
                    Dim ID As Integer = Converts.ToInt_NullIsZero(grdData.Rows(mRow).Cells("ID").Value)
                    Dim dtModel As DataTable = DataBase.DataSelect("MstModelDock", "ID<>" & ID & " and DelFlag=0 and ModelID= " & cboModel.SelectedValue & " and ModelDock='" & txtModelDockAudit.Text.Trim & "' and AreaCode='" & cboAreaCode.SelectedValue & "' and CaliperFlag = " & CaliperFlag & "")
                    If dtModel.Rows.Count > 0 Then
                        Messages.SetError(ErrProvider, cboModel, OPE_Controls.MessageType.DataExistPleaseChange)
                        Messages.SetError(ErrProvider, txtModelDockAudit, OPE_Controls.MessageType.DataExistPleaseChange)
                        Messages.SetError(ErrProvider, cboAreaCode, OPE_Controls.MessageType.DataExistPleaseChange)
                        bTrue = False
                    End If
                End If
            End If
        End If


        Return bTrue
    End Function

    Private Sub DataToGrid()
        Dim dv As DataView = grdData.DataSource
        Dim dt As DataTable = dv.ToTable
        Dim drAdd As DataRow = Nothing
        If fNew = True Then
            drAdd = dt.NewRow
            drAdd("ID") = 0
            drAdd("sta") = "N"
        Else
            grdData.Rows(mRow).Selected = True
            drAdd = grdData.SelectedRow
            If drAdd("sta") = "" Then drAdd("sta") = "U"
        End If

        drAdd("ModelID") = cboModel.SelectedValue
        drAdd("ModelDock") = txtModelDockAudit.Text.Trim
        drAdd("AreaCode") = cboAreaCode.SelectedValue
        drAdd("RackAmount") = Converts.ToInt_NullIsZero(txtRackAmount.Text.Trim)
        drAdd("CaliperFlag") = IIf(chkCaliperFlag.Checked, 1, 0)
        drAdd("Check1") = Check1.Checked
        drAdd("Check2") = Check2.Checked
        drAdd("Check3") = Check3.Checked
        drAdd("Check4") = Check4.Checked
        drAdd("Check5") = Check5.Checked
        drAdd("Check6") = Check6.Checked
        drAdd("Check7") = Check7.Checked
        drAdd("Model") = cboModel.SelectedRow("Model")
        drAdd("Format1") = btnFormat1.Text.Trim
        drAdd("Format2") = btnFormat2.Text.Trim
        drAdd("Format3") = btnFormat3.Text.Trim
        drAdd("Format4") = btnFormat4.Text.Trim
        drAdd("Format5") = btnFormat5.Text.Trim
        drAdd("Format6") = btnFormat6.Text.Trim
        drAdd("Format7") = btnFormat7.Text.Trim

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

    Private Sub Check_CheckedChanged(sender As Object, e As System.EventArgs) Handles Check1.CheckedChanged, Check2.CheckedChanged, Check3.CheckedChanged, Check4.CheckedChanged, Check5.CheckedChanged, Check6.CheckedChanged, Check7.CheckedChanged
        Select Case sender.name
            Case Check1.Name : btnFormat1.Visible = sender.Checked
            Case Check2.Name : btnFormat2.Visible = sender.Checked
            Case Check3.Name : btnFormat3.Visible = sender.Checked
            Case Check4.Name : btnFormat4.Visible = sender.Checked
            Case Check5.Name : btnFormat5.Visible = sender.Checked
            Case Check6.Name : btnFormat6.Visible = sender.Checked
            Case Check7.Name : btnFormat7.Visible = sender.Checked
        End Select
    End Sub

    Private Sub btnFormat_Click(sender As System.Object, e As System.EventArgs) Handles btnFormat1.Click, btnFormat2.Click, btnFormat3.Click, btnFormat4.Click, btnFormat5.Click, btnFormat6.Click, btnFormat7.Click
        If cboAreaCode.SelectedRow Is Nothing Then Exit Sub

        Dim iBtn As Integer = sender.name.ToString.Replace("btnFormat", "")
        Dim frm As New clsVQCSelect
        frm.CheckID = iBtn
        frm.FormatID = sender.Text.Trim
        frm.AreaCode = cboAreaCode.SelectedValue
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            sender.Text = frm.cboFormatID.SelectedValue
        End If
        frm.Dispose()
    End Sub

    Private Sub cboModel_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboModel.SelectedValueChanged
        If cboModel.DataSource Is Nothing Then Exit Sub
        If cboModel.SelectedRow Is Nothing Then Exit Sub

        If Converts.ToInt_NullIsZero(cboModel.SelectedRow("MBikeFlag")) = 0 Then
            grbAxle.Text = "Axle"
            grbShock.Text = "Shock"
        Else
            grbAxle.Text = "Bike"
            grbShock.Text = "Bike"
        End If
    End Sub
End Class