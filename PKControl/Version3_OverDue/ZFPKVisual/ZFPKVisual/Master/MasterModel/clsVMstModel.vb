Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVMstModel
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
        txtSModel.LinkCheckedBox = chkSModel
        With cboSType
            .ValueMember = "ID"
            .DisplayMember = "Name"
            .DataSource = DataBase.DataSelect("CstModelType")
            .LinkCheckedBox = chkSType
        End With

        Dim dtLength As DataTable = ComboSet.GetColumnLength("MstModel")
        ComboSet.TextString(txtModel, dtLength, "Model")

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
            .ColumnAdd_TextBox("Model", "Model", "Model", 500)
            .ColumnAdd_CheckBox("FrontFlag", "Front", "FrontFlag")
            .ColumnAdd_CheckBox("RearFlag", "Rear", "RearFlag")
            .ColumnAdd_CheckBox("BPSFlag", "BPS", "BPSFlag")
            .ColumnAdd_TextBox("ColorA", "ColorA", "ColorA", , , , , False)
            .ColumnAdd_TextBox("ColorR", "ColorR", "ColorR", , , , , False)
            .ColumnAdd_TextBox("ColorG", "ColorG", "ColorG", , , , , False)
            .ColumnAdd_TextBox("ColorB", "ColorB", "ColorB", , , , , False)
        End With
        'ComboSet.GridColumnSize(grdData)
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

        grdData.SelectedRow("sta") = "D"

    End Sub

    Private Sub ClearControlDetail()
        txtModel.Clear()
        chkFront.Checked = True
        chkRear.Checked = True
        chkBPS.Checked = True
        btnColor.BackColor = Color.FromArgb(0, 0, 0, 0)
    End Sub

    Private Sub DisplayUpdate(rGrid As DataRow, RowIndex As Integer)
        mRow = RowIndex
        txtModel.Text = rGrid("Model")
        chkFront.Checked = rGrid("FrontFlag")
        chkRear.Checked = rGrid("RearFlag")
        chkBPS.Checked = rGrid("BPSFlag")
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
                If dt.Rows.Count > 0 AndAlso dt.Compute("count(Model)", "Model = '" & txtModel.Text.Trim & "'") > 0 Then
                    bTrue = bTrue And Messages.SetError(ErrProvider, txtModel, OPE_Controls.MessageType.DataExistPleaseChange)
                Else
                    Dim dtModel As DataTable = DataBase.DataSelect("MstModel", "Model='" & txtModel.Text.Trim & "'")
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
        drAdd("FrontFlag") = chkFront.Checked
        drAdd("RearFlag") = chkRear.Checked
        drAdd("BPSFlag") = chkBPS.Checked
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
            grdData.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(ColorA, ColorR, ColorG, ColorB)
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
End Class