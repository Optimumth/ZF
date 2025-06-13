Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVMstQC
    Private cls As New clsCMstQC
    Private fNew As Boolean = False
    Private mRow As Integer = 0

#Region "Load"

    Private Sub clsVMstQC_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckUpdateData() = False Then e.Cancel = True
    End Sub
    Private Sub clsVMstQC_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        LoadForm()
    End Sub
    Private Sub LoadForm()
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If
        cboCheckNo.LinkCheckedBox = chkSCheckNo
        With cboCheckNo
            .ValueMember = "CheckID"
            .DisplayMember = "CheckID"
            .DataSource = DataBase.DataTable("select 1 as CheckID union select 2 as CheckID union select 3 as CheckID union select 4 as CheckID union select 5 as CheckID union select 6 as CheckID union select 7 as CheckID")
            .LinkCheckedBox = chkSCheckNo
        End With

        chkSFront.Checked = True
        chkSRear.Checked = True

        Dim dt As DataTable = cls.GetData(True, -1, False, 0)
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
            .ColumnAdd_TextBox("CheckID", "Check Number", "CheckID")
            .ColumnAdd_TextBox("FormatID", "Format Number", "FormatID")
            .ColumnAdd_CheckBox("FrontFlag", "Front", "FrontFlag")
            .ColumnAdd_CheckBox("RearFlag", "Rear", "RearFlag")
            .ColumnAdd_TextBox("Desc1", "Description 1", "Desc1")
            .ColumnAdd_TextBox("Desc2", "Description 2", "Desc2")
            .ColumnAdd_TextBox("Desc3", "Description 3", "Desc3")
            .ColumnAdd_TextBox("Remark", "Remark", "Remark")
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
        If chkSFront.Checked = False And chkSRear.Checked = False Then
            MsgBox("Please select Front or Rear or both")
            Exit Sub
        End If
        Dim sCheckNo As String = ""
        If Not cboCheckNo.SelectedRow Is Nothing Then sCheckNo = cboCheckNo.SelectedValue
        Dim dt As DataTable = cls.GetData(chkSCheckNo.Checked, sCheckNo, chkSFront.Checked, chkSRear.Checked)

        Dim dv As DataView
        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSave.Click
        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable
        Dim dtQC As DataTable = dt.Clone
        For Each dr As DataRow In dt.Select("sta<>''")
            dtQC.ImportRow(dr)
        Next
        If cls.SaveData(dtQC) = True Then
            LoadForm()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnNew.Click
        fNew = True
        ClearControlDetail()
        grpUpdateData.Visible = True
        txtCheckNo.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnEdit.Click
        If grdData.SelectedRow Is Nothing Then Exit Sub
        If CheckUpdateData() = False Then Exit Sub
        DisplayUpdate(grdData.SelectedRow, grdData.CurrentRow.Index)
        grpUpdateData.Visible = True
        txtDesc1.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnDelete.Click
        If CheckUpdateData() = False Then Exit Sub
        If grdData.SelectedRow Is Nothing Then Exit Sub

        grdData.SelectedRow("sta") = "D"

    End Sub

    Private Sub ClearControlDetail()
        txtCheckNo.Clear()
        txtFormatNo.Clear()
        chkFront.Checked = False
        chkRear.Checked = False
        txtDesc1.Clear()
        txtDesc2.Clear()
        txtDesc3.Clear()
        txtRemark.Clear()
    End Sub

    Private Sub DisplayUpdate(rGrid As DataRow, RowIndex As Integer)
        mRow = RowIndex
        
        txtCheckNo.Text = rGrid("CheckID")
        txtFormatNo.Text = rGrid("FormatID")
        chkFront.Checked = rGrid("FrontFlag")
        chkRear.Checked = rGrid("RearFlag")
        txtDesc1.Text = Converts.ToStr(rGrid("Desc1"))
        txtDesc2.Text = Converts.ToStr(rGrid("Desc2"))
        txtDesc3.Text = Converts.ToStr(rGrid("Desc3"))
        txtRemark.Text = Converts.ToStr(rGrid("Remark"))

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

        If txtCheckNo.Text = "" Then
            bTrue = bTrue And Messages.SetError(ErrProvider, txtCheckNo, OPE_Controls.MessageType.PleaseInputData)
        ElseIf Not IsNumeric(txtCheckNo.Text.Trim) And Converts.ToInt_NullIsZero(txtCheckNo.Text.Trim) < 1 And Converts.ToInt_NullIsZero(txtCheckNo.Text.Trim) > 7 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, txtCheckNo, OPE_Controls.MessageType.None, "Please input number 1 - 7")
        End If
        If Converts.ToInt_NullIsZero(txtFormatNo.Text.Trim) < 1 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, txtFormatNo, OPE_Controls.MessageType.None, "Please input number >= 1")
        End If
        If chkFront.Checked = False And chkRear.Checked = False Then
            bTrue = bTrue And Messages.SetError(ErrProvider, chkFront, OPE_Controls.MessageType.None, "Please check Front or Rear or Both")
        End If

        If bTrue = True And fNew = True Then
            Dim dv As DataView = grdData.DataSource
            Dim dt As DataTable = dv.ToTable
            If dt.Rows.Count > 0 AndAlso dt.Compute("count(CheckID)", "CheckID=" & txtCheckNo.Text.Trim & " and FormatID=" & txtFormatNo.Text.Trim & "") > 0 Then
                bTrue = bTrue And Messages.SetError(ErrProvider, txtFormatNo, OPE_Controls.MessageType.DataExistPleaseChange)
            Else
                Dim dtQC As DataTable = DataBase.DataSelect("MstQC", "DelFlag=0 and CheckID=" & txtCheckNo.Text.Trim & " and FormatID=" & txtFormatNo.Text.Trim & "")
                If dtQC.Rows.Count > 0 Then
                    bTrue = bTrue And Messages.SetError(ErrProvider, txtFormatNo, OPE_Controls.MessageType.DataExistPleaseChange)
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
            drAdd("CheckID") = txtCheckNo.Text.Trim
            drAdd("FormatID") = txtFormatNo.Text.Trim
            drAdd("sta") = "N"
        Else
            grdData.Rows(mRow).Selected = True
            drAdd = grdData.SelectedRow
            If drAdd("sta") = "" Then drAdd("sta") = "U"
        End If
        drAdd("FrontFlag") = IIf(chkFront.Checked = True, 1, 0)
        drAdd("RearFlag") = IIf(chkRear.Checked = True, 1, 0)
        drAdd("Desc1") = txtDesc1.Text.Trim
        drAdd("Desc2") = txtDesc2.Text.Trim
        drAdd("Desc3") = IIf(txtDesc3.Visible = True, txtDesc3.Text.Trim, "")
        drAdd("Remark") = txtRemark.Text.Trim


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

    Private Sub txtCheckNo_TextChanged(sender As Object, e As System.EventArgs) Handles txtCheckNo.TextChanged
        If Converts.ToInt_NullIsZero(txtCheckNo.Text.Trim) = 1 Then
            lblDesc3.Visible = True
            txtDesc3.Visible = True
        Else
            lblDesc3.Visible = False
            txtDesc3.Visible = False
        End If
    End Sub
End Class