Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVMstModel_BMW
    Private cls As New clsCMstModel
    Private fNew As Boolean = False
    Private mRow As Integer = 0

#Region "Load"

    Private Sub clsVMstModel_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckUpdateData() = False Then e.Cancel = True
    End Sub
    Private Sub clsVMstRack_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
    Private Sub LoadForm()
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If
        txtSModel.LinkCheckedBox = chkSModel
        With cboSType
            .ValueMember = "ID"
            .DisplayMember = "Name"
            .DataSource = DataBase.DataSelect("CstModelType")
            .LinkCheckedBox = chkSType
        End With

        With cboSModelContainer
            .ValueMember = "ModelContainer"
            .DisplayMember = "ModelContainer"
            .DataSource = DataBase.DataSelect("MstModel", "DelFlag=0", , , "distinct ModelContainer", , , "ModelContainer")
            .LinkCheckedBox = chkSModelContainer
            .SelectedIndex = -1
        End With

        Dim dtLength As DataTable = ComboSet.GetColumnLength("MstModel")
        ComboSet.TextString(txtModel, dtLength, "Model")

        ComboSet.TextQty(txtModelContainerSeq)

        Dim dt As DataTable = cls.GetData(True, "N/A", False, 0)
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
            .ColumnAdd_TextBox("Model", "Model", "Model", 120)
            .ColumnAdd_CheckBox("FrontFlag", "Front", "FrontFlag")
            .ColumnAdd_CheckBox("RearFlag", "Rear", "RearFlag")
            .ColumnAdd_CheckBox("FrontRearFlag", "Front & Rear", "FrontRearFlag")
            .ColumnAdd_CheckBox("STBFlag", "STB", "STBFlag")
            .ColumnAdd_CheckBox("MBikeFrontFlag", "M-Bike Front", "MBikeFrontFlag")
            .ColumnAdd_CheckBox("MBikeRearFlag", "M-Bike Rear", "MBikeRearFlag")
            .ColumnAdd_CheckBox("PTCFlag", "PTC", "PTCFlag")
            .ColumnAdd_TextBox("ModelContainer", "Model Group", "ModelContainer", 120)
            .ColumnAdd_TextBox("ModelContainerSeq", "Group Seq", "ModelContainerSeq")
            .ColumnAdd_TextBox("ColorA", "ColorA", "ColorA", , , , , False)
            .ColumnAdd_TextBox("ColorR", "ColorR", "ColorR", , , , , False)
            .ColumnAdd_TextBox("ColorG", "ColorG", "ColorG", , , , , False)
            .ColumnAdd_TextBox("ColorB", "ColorB", "ColorB", , , , , False)
            .ColumnAdd_TextBox("ID", "ID", "ID", , , , , False)
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

        Dim dt As DataTable = cls.GetData(chkSModel.Checked, txtSModel.Text.Trim _
                                       , chkSType.Checked, IIf(cboSType.SelectedIndex >= 0, cboSType.SelectedValue, 0))
        Dim dv As DataView
        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv

        SetGridColor()
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
            LoadForm()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnNew.Click
        fNew = True
        ClearControlDetail()
        grpUpdateData.Visible = True
        txtModel.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnEdit.Click
        If grdData.SelectedRow Is Nothing Then Exit Sub
        If CheckUpdateData() = False Then Exit Sub
        DisplayUpdate(grdData.SelectedRow, grdData.CurrentRow.Index)
        grpUpdateData.Visible = True
        txtModel.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnDelete.Click
        If CheckUpdateData() = False Then Exit Sub
        If grdData.SelectedRow Is Nothing Then Exit Sub

        If CustomerCode <> "MB" Then
            Dim ID As Integer = grdData.SelectedRow("ID")
            Dim dtModelDock As DataTable = DataBase.DataSelect("MstModelDock", "DelFlag=0 and ModelID=" & ID & "")
            If dtModelDock.Rows.Count > 0 Then
                MsgBox("ลบ Model นี้ไม่ได้ เนื่องจากมีการนำไปทำ Model (Dock Audit) แล้ว")
                e.DialogResult = Windows.Forms.DialogResult.Cancel
                Exit Sub
            End If
        End If

        grdData.SelectedRow("sta") = "D"

    End Sub

    Private Sub ClearControlDetail()
        txtModel.Clear()
        txtModelContainer.Clear()
        chkFront.Checked = False
        chkRear.Checked = False
        chkSTB.Checked = False
        chkMBikeFront.Checked = False
        chkMBikeRear.Checked = False
        chkPTC.Checked = False
        btnColor.BackColor = Color.FromArgb(0, 0, 0, 0)
    End Sub

    Private Sub DisplayUpdate(rGrid As DataRow, RowIndex As Integer)
        mRow = RowIndex
        txtModel.Text = rGrid("Model")
        txtModelContainer.Text = Converts.ToStr(rGrid("ModelContainer"))
        txtModelContainerSeq.Text = Converts.ToInt_NullIsZero(rGrid("ModelContainerSeq"))
        chkFront.Checked = rGrid("FrontFlag")
        chkRear.Checked = rGrid("RearFlag")
        chkFrontRear.Checked = rGrid("FrontRearFlag")
        chkSTB.Checked = rGrid("STBFlag")
        chkMBikeFront.Checked = rGrid("MBikeFrontFlag")
        chkMBikeRear.Checked = rGrid("MBikeRearFlag")
        chkPTC.Checked = rGrid("PTCFlag")
        btnColor.BackColor = Color.FromArgb(rGrid("ColorA"), rGrid("ColorR"), rGrid("ColorG"), rGrid("ColorB"))

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

        If txtModel.Text.Trim = "" Then
            bTrue = bTrue And Messages.SetError(ErrProvider, txtModel, OPE_Controls.MessageType.PleaseInputData)
        Else
            If fNew Then
                Dim dv As DataView = grdData.DataSource
                Dim dt As DataTable = dv.ToTable
                If dt.Rows.Count > 0 AndAlso dt.Compute("count(Model)", "Model = '" & txtModel.Text.Trim & "' and ModelContainer='" & txtModelContainer.Text.Trim & "'") > 0 Then
                    bTrue = bTrue And Messages.SetError(ErrProvider, txtModel, OPE_Controls.MessageType.DataExistPleaseChange)
                Else
                    Dim dtModel As DataTable = DataBase.DataSelect("MstModel", "DelFlag=0 and Model='" & txtModel.Text.Trim & "' and ModelContainer='" & txtModelContainer.Text.Trim & "'")
                    If dtModel.Rows.Count > 0 Then
                        bTrue = bTrue And Messages.SetError(ErrProvider, txtModel, OPE_Controls.MessageType.DataExistPleaseChange)
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

        drAdd("Model") = txtModel.Text.Trim
        drAdd("ModelContainer") = txtModelContainer.Text.Trim
        drAdd("ModelContainerSeq") = Converts.ToInt_NullIsZero(txtModelContainerSeq.Text.Trim)
        drAdd("FrontFlag") = chkFront.Checked
        drAdd("RearFlag") = chkRear.Checked
        drAdd("FrontRearFlag") = chkFrontRear.Checked
        drAdd("STBFlag") = chkSTB.Checked
        drAdd("MBikeFrontFlag") = chkMBikeFront.Checked
        drAdd("MBikeRearFlag") = chkMBikeRear.Checked
        drAdd("PTCFlag") = chkPTC.Checked
        drAdd("ColorA") = btnColor.BackColor.A
        drAdd("ColorR") = btnColor.BackColor.R
        drAdd("ColorG") = btnColor.BackColor.G
        drAdd("ColorB") = btnColor.BackColor.B

        If fNew = True Then
            dt.Rows.Add(drAdd)
            Dim dvNew As DataView
            dvNew = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
            grdData.DataSource = dvNew
        End If

        btnSave.Enabled = True
        SetGridColor()
    End Sub

#End Region
#Region "Set Color"
    Private Sub btnColor_Click(sender As Object, e As System.EventArgs) Handles btnColor.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            btnColor.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub SetGridColor()
        For i As Integer = 0 To grdData.RowCount - 1
            Dim ColorA As Integer = Converts.ToInt_NullIsZero(grdData.Rows(i).Cells("ColorA").Value)
            Dim ColorR As Integer = Converts.ToInt_NullIsZero(grdData.Rows(i).Cells("ColorR").Value)
            Dim ColorG As Integer = Converts.ToInt_NullIsZero(grdData.Rows(i).Cells("ColorG").Value)
            Dim ColorB As Integer = Converts.ToInt_NullIsZero(grdData.Rows(i).Cells("ColorB").Value)
            'grdData.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(ColorA, ColorR, ColorG, ColorB)
            grdData.Rows(i).Cells("ModelContainerSeq").Style.BackColor = Color.FromArgb(ColorA, ColorR, ColorG, ColorB)
        Next
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

    Private Sub cboSType_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboSType.SelectedValueChanged

    End Sub
End Class