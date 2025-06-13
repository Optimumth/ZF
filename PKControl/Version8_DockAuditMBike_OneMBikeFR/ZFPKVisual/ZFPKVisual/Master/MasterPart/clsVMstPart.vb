Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVMstPart
    Private cls As New clsCMstPart
    Private fNew As Boolean = False
    Private mRow As Integer = 0
    Private Enum eCaliper
        NoCaliper = 0
        WithCaliper = 1
    End Enum

#Region "Load"

    Private Sub clsVMstPart_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckUpdateData() = False Then e.Cancel = True
    End Sub
    Private Sub clsVMstPart_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        LoadForm()
    End Sub
    Private Sub LoadForm()
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If

        With cboSVariant
            .ValueMember = "Variant"
            .DisplayMember = "Variant"
            .DataSource = DataBase.DataSelect("MstPart" _
                                              , "DelFlag=0" _
                                              , , , "distinct Variant" _
                                              , , , "Variant")

            .SelectedIndex = -1
            .LinkCheckedBox = chkSVariant
        End With

        With cboSAreaCode
            .ValueMember = "ID"
            .DisplayMember = "AreaName"
            .DataSource = DataBase.DataSelect("CstArea" _
                                              , , , , "ID,AreaName" _
                                              , , , "AreaName")
            .SelectedIndex = -1
            .LinkCheckedBox = chkSAreaCode
        End With

        With cboSPartType
            .ValueMember = "ID"
            .DisplayMember = "PartTypeName"
            .DataSource = DataBase.DataSelect("CstPartType" _
                                              , , , , "ID,PartTypeName" _
                                              , , , "ID")
            .SelectedIndex = -1
            .LinkCheckedBox = chkSPartType
        End With

        With cboSPartNo
            .ValueMember = "PartNo"
            .DisplayMember = "PartNo"
            .DataSource = DataBase.DataSelect("MstPart" _
                                              , "DelFlag=0" _
                                              , , , "distinct PartNo" _
                                              , , , "PartNo")

            .SelectedIndex = -1
            .LinkCheckedBox = chkSPartNo
        End With

        Dim iNoCaliper As Integer = eCaliper.NoCaliper
        Dim iWithCaliper As Integer = eCaliper.WithCaliper
        With cboSCaliper
            .ValueMember = "CaliperFlag"
            .DisplayMember = "CaliperText"
            .DataSource = DataBase.DataTable("select " & iWithCaliper & " as CaliperFlag, 'Yes' as CaliperText" & _
                                             " union select " & iNoCaliper & " as CaliperFlag,'No' as CaliperText")
            .LinkCheckedBox = chkSCaliper
            .SelectedIndex = -1
        End With

        With cboAreaCode
            .ValueMember = "ID"
            .DisplayMember = "AreaName"
            .DataSource = DataBase.DataSelect("CstArea" _
                                              , , , , "ID,AreaName,AreaCode" _
                                              , , , "AreaName")
            .SelectedIndex = -1
        End With

        With cboPartType
            .ValueMember = "ID"
            .DisplayMember = "PartTypeName"
            .DataSource = DataBase.DataSelect("CstPartType" _
                                              , , , , "ID,PartTypeName" _
                                              , , , "PartTypeName")
            .SelectedIndex = -1
        End With

        With cboModelDock
            .ValueMember = "ID"
            .DisplayMember = "ModelDock"
            .DataSource = DataBase.DataSelect("MstModelDock" _
                                             , "MstModel.MBikeFlag=1" _
                                             , , , "MstModelDock.ID,ModelDock" _
                                             , , "inner join MstModel on MstModelDock.ModelID=MstModel.ID" _
                                             , "ModelDock")
            .Enabled = False
        End With

        chkSActiveFlag.Checked = True

        Dim dtLength As DataTable = ComboSet.GetColumnLength("MstPart")
        ComboSet.TextString(txtVariant, dtLength, "Variant")
        ComboSet.TextString(txtPartNo, dtLength, "PartNo")

        Dim dt As DataTable = cls.GetData(True, "-", False, -1, False, -1, False, "", False, 0, 0)
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
            .ColumnAdd_TextBox("Variant", "Variant", "Variant", 120)
            .ColumnAdd_TextBox("AreaName", "Area", "AreaName", 120)
            .ColumnAdd_TextBox("PartTypeName", "Part Type", "PartTypeName", 120)
            .ColumnAdd_TextBox("PartNo", "Part No.", "PartNo", 120)
            .ColumnAdd_CheckBox("CaliperFlag", "Caliper", "CaliperFlag", 120)
            .ColumnAdd_TextBox("ModelDock", "Model(Dock Audit)", "ModelDock", 120)
            .ColumnAdd_CheckBox("ActiveFlag", "Active", "ActiveFlag", 120)
            .ColumnAdd_TextBox("ID", "ID", "ID", , , , , False)
            .ColumnAdd_TextBox("AreaID", "AreaID", "AreaID", , , , , False)
            .ColumnAdd_TextBox("PartTypeID", "PartTypeID", "PartTypeID", , , , , False)
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

        Dim sVariant As String = ""
        Dim AreaID As Integer = -1
        Dim PartTypeID As Integer = -1
        Dim PartNo As String = ""
        If chkSVariant.Checked = True And cboSVariant.SelectedIndex >= 0 Then sVariant = cboSVariant.SelectedValue
        If chkSAreaCode.Checked And cboSAreaCode.SelectedIndex >= 0 Then AreaID = cboSAreaCode.SelectedValue
        If chkSPartType.Checked And cboSPartType.SelectedIndex >= 0 Then PartTypeID = cboSPartType.SelectedValue
        If chkSPartNo.Checked And cboSPartNo.SelectedIndex >= 0 Then PartNo = cboSPartNo.SelectedValue

        Dim iCaliperFlag As Integer = 0
        If Not (cboSCaliper.SelectedRow Is Nothing) Then
            iCaliperFlag = cboSCaliper.SelectedValue
        End If
        Dim dt As DataTable = cls.GetData(chkSVariant.Checked, sVariant, chkSAreaCode.Checked, AreaID, chkSPartType.Checked, PartTypeID, chkSPartNo.Checked, PartNo, chkSCaliper.Checked, iCaliperFlag, chkSActiveFlag.Checked)
        Dim dv As DataView
        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSave.Click
        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable
        Dim dtPart As DataTable = dt.Clone
        For Each dr As DataRow In dt.Select("sta<>''")
            If Not (dr("sta") = "D" And Converts.ToInt_NullIsZero(dr("ID")) = 0) Then
                dtPart.ImportRow(dr)
            End If
        Next
        If cls.SaveData(dtPart) = True Then
            btnSave.Enabled = False
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnNew.Click
        fNew = True
        ClearControlDetail()
        grpUpdateData.Visible = True
        cboAreaCode.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnEdit.Click
        If grdData.SelectedRow Is Nothing Then Exit Sub
        If CheckUpdateData() = False Then Exit Sub
        DisplayUpdate(grdData.SelectedRow, grdData.CurrentRow.Index)
        grpUpdateData.Visible = True
        cboAreaCode.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnDelete.Click
        If CheckUpdateData() = False Then Exit Sub
        If grdData.SelectedRow Is Nothing Then Exit Sub

        grdData.SelectedRow("sta") = "D"

    End Sub

    Private Sub ClearControlDetail()
        txtVariant.Clear()
        cboAreaCode.SelectedIndex = -1
        cboPartType.SelectedIndex = -1
        txtPartNo.Clear()
        chkCaliperFlag.Checked = True
        cboModelDock.Clear()
        cboModelDock.Enabled = False
        chkActiveFlag.Checked = True
    End Sub

    Private Sub DisplayUpdate(rGrid As DataRow, RowIndex As Integer)
        mRow = RowIndex
        txtVariant.Text = Converts.ToStr(rGrid("Variant"))
        cboAreaCode.SelectedValue = rGrid("AreaID")
        cboPartType.SelectedValue = rGrid("PartTypeID")
        txtPartNo.Text = Converts.ToStr(rGrid("PartNo"))
        chkCaliperFlag.Checked = Converts.ToInt_NullIsZero(rGrid("CaliperFlag"))
        setModelDock()
        If Converts.ToStr(rGrid("ModelDock")) <> "" Then
            cboModelDock.Text = Converts.ToStr(rGrid("ModelDock"))
        End If
        If Converts.ToInt_NullIsZero(rGrid("ActiveFlag")) = 0 Then
            chkActiveFlag.Checked = False
        Else
            chkActiveFlag.Checked = True
        End If
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

        If txtVariant.Text.Trim = "" Then
            Messages.SetError(ErrProvider, txtVariant, OPE_Controls.MessageType.PleaseInputData)
            bTrue = False
        End If

        If cboAreaCode.SelectedIndex < 0 Then
            Messages.SetError(ErrProvider, cboAreaCode, OPE_Controls.MessageType.PleaseSelectDataInList)
            bTrue = False
        End If

        If cboPartType.SelectedIndex < 0 Then
            Messages.SetError(ErrProvider, cboPartType, OPE_Controls.MessageType.PleaseSelectDataInList)
            bTrue = False
        End If

        If txtPartNo.Text.Trim = "" Then
            Messages.SetError(ErrProvider, txtPartNo, OPE_Controls.MessageType.PleaseInputData)
            bTrue = False
        End If

        If bTrue = True Then
            If fNew Then
                Dim dv As DataView = grdData.DataSource
                Dim dt As DataTable = dv.ToTable

                If dt.Rows.Count > 0 AndAlso dt.Compute("count(ID)", "Variant = '" & txtVariant.Text.Trim & "' and AreaID = " & cboAreaCode.SelectedRow("ID") & " and PartTypeID = " & cboPartType.SelectedRow("ID") & "") > 0 Then
                    Messages.SetError(ErrProvider, txtVariant, OPE_Controls.MessageType.DataExistPleaseChange)
                    Messages.SetError(ErrProvider, cboAreaCode, OPE_Controls.MessageType.DataExistPleaseChange)
                    Messages.SetError(ErrProvider, cboPartType, OPE_Controls.MessageType.DataExistPleaseChange)
                    bTrue = False
                ElseIf dt.Rows.Count > 0 AndAlso dt.Compute("count(ID)", "PartNo = '" & txtPartNo.Text.Trim & "'") > 0 Then
                    Messages.SetError(ErrProvider, txtPartNo, OPE_Controls.MessageType.DataExistPleaseChange)
                Else
                    Dim dtPart As DataTable = DataBase.DataSelect("MstPart", "Variant='" & txtVariant.Text.Trim & "' and AreaID=" & cboAreaCode.SelectedRow("ID") & " and PartTypeID=" & cboPartType.SelectedRow("ID") & " and DelFlag=0")
                    If dtPart.Rows.Count > 0 Then
                        Messages.SetError(ErrProvider, txtVariant, OPE_Controls.MessageType.DataExistPleaseChange)
                        Messages.SetError(ErrProvider, cboAreaCode, OPE_Controls.MessageType.DataExistPleaseChange)
                        Messages.SetError(ErrProvider, cboPartType, OPE_Controls.MessageType.DataExistPleaseChange)
                        bTrue = False
                    Else
                        dtPart = DataBase.DataSelect("MstPart", "PartNo='" & txtPartNo.Text.Trim & "' and DelFlag=0")
                        If dtPart.Rows.Count > 0 Then
                            Messages.SetError(ErrProvider, txtPartNo, OPE_Controls.MessageType.DataExistPleaseChange)
                            bTrue = False
                        End If
                    End If
                End If
            Else
                Dim DuplicateData1 As Boolean = False
                Dim DuplicateData2 As Boolean = False
                For iRow As Integer = 0 To grdData.Rows.Count - 1
                    If iRow <> mRow Then
                        If Converts.ToStr(grdData.Rows(iRow).Cells("Variant").Value) = txtVariant.Text.Trim _
                            And Converts.ToInt_NullIsZero(grdData.Rows(iRow).Cells("AreaID").Value) = cboAreaCode.SelectedRow("ID") _
                            And Converts.ToInt_NullIsZero(grdData.Rows(iRow).Cells("PartTypeID").Value) = cboPartType.SelectedRow("ID")  Then
                            DuplicateData1 = True
                            Exit For
                        End If
                        If Converts.ToStr(grdData.Rows(iRow).Cells("PartNo").Value) = txtPartNo.Text.Trim Then
                            DuplicateData2 = True
                            Exit For
                        End If
                    End If
                Next
                If DuplicateData1 = True Then
                    Messages.SetError(ErrProvider, txtVariant, OPE_Controls.MessageType.DataExistPleaseChange)
                    Messages.SetError(ErrProvider, cboAreaCode, OPE_Controls.MessageType.DataExistPleaseChange)
                    Messages.SetError(ErrProvider, cboPartType, OPE_Controls.MessageType.DataExistPleaseChange)
                    bTrue = False
                ElseIf DuplicateData2 = True Then
                    Messages.SetError(ErrProvider, txtPartNo, OPE_Controls.MessageType.DataExistPleaseChange)
                    bTrue = False
                Else
                    Dim ID As Integer = Converts.ToInt_NullIsZero(grdData.Rows(mRow).Cells("ID").Value)
                    Dim dtPart As DataTable = DataBase.DataSelect("MstPart", "ID<> " & ID & " and Variant='" & txtVariant.Text.Trim & "' and AreaID=" & cboAreaCode.SelectedRow("ID") & " and PartTypeID=" & cboPartType.SelectedRow("ID") & "  and DelFlag=0")
                    If dtPart.Rows.Count > 0 Then
                        Messages.SetError(ErrProvider, txtVariant, OPE_Controls.MessageType.DataExistPleaseChange)
                        Messages.SetError(ErrProvider, cboAreaCode, OPE_Controls.MessageType.DataExistPleaseChange)
                        Messages.SetError(ErrProvider, cboPartType, OPE_Controls.MessageType.DataExistPleaseChange)
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


        drAdd("Variant") = txtVariant.Text.Trim
        drAdd("AreaID") = cboAreaCode.SelectedRow("ID")
        drAdd("PartTypeID") = cboPartType.SelectedRow("ID")
        drAdd("PartNo") = txtPartNo.Text.Trim
        drAdd("AreaName") = cboAreaCode.SelectedRow("AreaName")
        drAdd("PartTypeName") = cboPartType.SelectedRow("PartTypeName")
        drAdd("CaliperFlag") = IIf(chkCaliperFlag.Checked, 1, 0)
        If (cboPartType.SelectedRow("PartTypeName") = "MTB") Then
            drAdd("ModelDockID") = cboModelDock.SelectedRow("ID")
            drAdd("ModelDock") = cboModelDock.SelectedRow("ModelDock")
        End If
        drAdd("ActiveFlag") = chkActiveFlag.Checked

        If fNew = True Then
            dt.Rows.Add(drAdd)
            Dim dvNew As DataView
            dvNew = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
            grdData.DataSource = dvNew
        End If

        btnSave.Enabled = True
        'SetGridColor()
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

    Private Sub cboPartType_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboPartType.SelectedValueChanged, cboAreaCode.SelectedValueChanged
        If cboPartType.DataSource Is Nothing Then Exit Sub
        If cboPartType.SelectedRow Is Nothing Then Exit Sub
        If cboAreaCode.DataSource Is Nothing Then Exit Sub
        If cboAreaCode.SelectedRow Is Nothing Then Exit Sub

        setModelDock()
    End Sub

    Private Sub setModelDock()
        If cboPartType.SelectedRow("PartTypeName") = "MTB" Then
            With cboModelDock
                .ValueMember = "ID"
                .DisplayMember = "ModelDock"
                .DataSource = DataBase.DataSelect("MstModelDock" _
                                                 , "MstModel.MBikeFlag=1 and AreaCode='" & cboAreaCode.SelectedRow("AreaCode") & "'" _
                                                 , , , "MstModelDock.ID,ModelDock" _
                                                 , , "inner join MstModel on MstModelDock.ModelID=MstModel.ID" _
                                                 , "ModelDock")
                .Enabled = True
            End With
        Else
            cboModelDock.Clear()
            cboModelDock.Enabled = False
        End If
    End Sub
End Class