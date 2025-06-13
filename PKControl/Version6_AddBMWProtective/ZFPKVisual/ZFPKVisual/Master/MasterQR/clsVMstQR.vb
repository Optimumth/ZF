'Server=WINDOWS-9FQLVMQ;uid=sa;pwd=abc123!;Database=PCS_TEST
'admin@Tom!@#123

Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVMstQR
    Private cls As New clsCMstQR
    Private mRow As Integer = 0

#Region "Load"

    Private Sub clsVMstQR_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CheckUpdateData() = False Then e.Cancel = True
    End Sub
    Private Sub clsVMstQR_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If
        LoadForm()
    End Sub
    Private Sub LoadForm()
        With cboSHeader
            .ValueMember = "QRHeader"
            .DisplayMember = "QRHeader"
            .DataSource = DataBase.DataSelect("MstQR", , , , "distinct QRHeader", , , "QRHeader")
            .LinkCheckedBox = chkSHeader
        End With
        With cboSValue
            .ValueMember = "QRValue"
            .DisplayMember = "QRValue"
            .DataSource = DataBase.DataSelect("MstQR", , , , "distinct QRValue", , , "QRValue")
            .LinkCheckedBox = chkSValue
        End With

        Dim dtLength As DataTable = ComboSet.GetColumnLength("MstQR")
        ComboSet.TextString(txtValue, dtLength, "QRValue")

        Dim dt As DataTable = cls.GetData(True, "-", False, 0)
        Dim dv As DataView
        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv

        grpUpdateData.Visible = False
        btnSave.Enabled = False
        btnPrint.Visible = True
    End Sub
#End Region

#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_CheckBox("chk", "", "chk", , , , True)
            .ColumnAdd_TextBox("QRHeader", "Header", "QRHeader", 120)
            .ColumnAdd_TextBox("QRValue", "Value", "QRValue", 120)
            .ColumnAdd_TextBox("sta", "sta", "sta", , , , , False)
        End With
    End Sub
#End Region

#Region "Toolbar Click"
    Private Sub btnSearch_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Click
        If CheckUpdateData() = False Then Exit Sub

        Dim dt As DataTable = cls.GetData(chkSHeader.Checked, cboSHeader.SelectedValue, chkSValue.Checked, cboSValue.SelectedValue)
        Dim dv As DataView
        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv
    End Sub

    Private Sub btnSearch_Validate(sender As Object, e As OPE_Controls.EventArgs) Handles btnSearch.Validate
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        If chkSHeader.Checked AndAlso cboSHeader.SelectedIndex < 0 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, cboSHeader, OPE_Controls.MessageType.PleaseSelectDataInList)
        End If
        If chkSValue.Checked AndAlso cboSValue.SelectedIndex < 0 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, cboSValue, OPE_Controls.MessageType.PleaseSelectDataInList)
        End If

        If Not bTrue Then e.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSave.Click
        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable

        Dim dtNew As DataTable = cls.SaveData(dt)
        If Not dtNew Is Nothing Then
            dv = New DataView(dtNew, "sta<>'D'", "", DataViewRowState.CurrentRows)
            grdData.DataSource = dv

            grpUpdateData.Visible = False
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnNew.Click
        ClearControlDetail()
        grpUpdateData.Visible = True
        cboHeader.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnDelete.Click
        If CheckUpdateData() = False Then Exit Sub
        If grdData.SelectedRow Is Nothing Then Exit Sub

        grdData.SelectedRow("sta") = "D"

    End Sub

    Private Sub ClearControlDetail()
        
        With cboHeader
            .ValueMember = "QRHeader"
            .DisplayMember = "QRHeader"
            .DataSource = DataBase.DataSelect("CstQRHeader", , , , "QRHeader,QRIndex", , , "QRIndex")
            .Enabled = True
            .SelectedIndex = 0
        End With
        With txtValue
            .Clear()
            .ReadOnly = False
        End With
    End Sub

    Private Sub DisplayUpdate(rGrid As DataRow, RowIndex As Integer)
        mRow = RowIndex

        ClearControlDetail()

        cboHeader.SelectedValue = Converts.ToStr(rGrid("QRHeader"))
        txtValue.Text = Converts.ToStr(rGrid("QRValue"))
    End Sub
#End Region

#Region "Data to Grid"
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If OKValidate() = False Then Exit Sub

        DataToGrid()

        ClearControlDetail()
        ErrProvider.Clear()

        grpUpdateData.Visible = False
        mRow = 0

        btnNew.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        ClearControlDetail()
        ErrProvider.Clear()

        grpUpdateData.Visible = False

        btnNew.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Function OKValidate() As Boolean
        Dim bTrue As Boolean = True
        ErrProvider.Clear()

        If cboHeader.SelectedIndex < 0 Then
            bTrue = bTrue And Messages.SetError(ErrProvider, cboHeader, OPE_Controls.MessageType.PleaseSelectDataInList)
        End If
        If txtValue.Text.Trim = "" Then
            bTrue = bTrue And Messages.SetError(ErrProvider, txtValue, OPE_Controls.MessageType.PleaseInputData)
        End If

        Return bTrue
    End Function

    Private Sub DataToGrid()
        Dim dv As DataView = grdData.DataSource
        Dim dt As DataTable = dv.ToTable
        Dim drAdd As DataRow = Nothing
        drAdd = dt.NewRow
        drAdd("chk") = 0
        drAdd("QRHeader") = cboHeader.SelectedValue
        drAdd("QRValue") = txtValue.Text.Trim
        drAdd("QRIndex") = cboHeader.SelectedRow("QRIndex")
        drAdd("sta") = "N"
        
        dt.Rows.Add(drAdd)
        Dim dvNew As DataView
        dvNew = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dvNew
        
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

    Private Sub btnPrint_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnPrint.Click
        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dtGrid As DataTable = dv.ToTable

        If dtGrid Is Nothing OrElse dtGrid.Rows.Count = 0 Then Exit Sub

        Dim dtPrint As DataTable = dtGrid.Clone
        For Each drGrid As DataRow In dtGrid.Select()
            If Converts.ToInt_NullIsZero(drGrid("chk")) = 1 Then
                dtPrint.ImportRow(drGrid)
            End If
        Next

        If dtPrint.Rows.Count > 0 Then
            cls.PrintTag(dtPrint)
        Else
            MessageBox.Show("Please select data to print")
        End If
    End Sub

    Private Sub btnCheckAll_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnCheckAll.Click
        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Sub
        For Each dr As DataRow In dt.Select()
            dr("chk") = 1
        Next

        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv
    End Sub
    Private Sub btnReleaseAll_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnReleaseAll.Click
        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Sub
        For Each dr As DataRow In dt.Select()
            dr("chk") = 0
        Next

        dv = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv
    End Sub
End Class