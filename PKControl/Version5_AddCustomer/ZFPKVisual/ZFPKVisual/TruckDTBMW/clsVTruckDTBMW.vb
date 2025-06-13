Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVTruckDTBMW
    Private cls As New clsCTruckDTBMW
    Private mRowTruck As DataRow

    Public Property RowTruck() As DataRow
        Get
            Return Nothing
        End Get
        Set(ByVal value As DataRow)
            mRowTruck = value
        End Set
    End Property

#Region "Load"
    Private Sub clsVTruckDT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        btnSave.Enabled = False
        btnSearch.PerformClick()
    End Sub
    Private Sub LoadForm()
        txtTruckID.Text = mRowTruck("TruckID")
        txtLicense.Text = Converts.ToStr(mRowTruck("License"))
        txtRackAmount.Text = mRowTruck("RackAmount")

        Dim dtDT As DataTable = cls.GetDT(mRowTruck("TruckID"))
        Dim dv As DataView
        dv = New DataView(dtDT, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv

        Summary()

        btnSave.Enabled = False
    End Sub
#End Region

#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_CheckBox("chk", "", "chk", , , , True)
            .ColumnAdd_TextBox("RackID", "RackID", "RackID", 100)
            .ColumnAdd_TextBox("RackNo", "RackNo", "RackNo")
            .ColumnAdd_TextBox("Show", "Show", "Show", 100)
            .ColumnAdd_TextBox("ScanDateTime", "Scan Date", "ScanDateTime", 200, , DataGridViewContentAlignment.MiddleCenter, Styles.DateCustomFormatDateTime)
            .ColumnAdd_TextBox("sta", "sta", "sta", , , , , False)
        End With
        ComboSet.GridColumnSize(grdData)
    End Sub
#End Region

#Region "Toolbar Click"
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnSearch.Click
        LoadForm()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnSave.Click
        If SaveValidate() = False Then Exit Sub

        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable
        Dim dtTrans As DataTable = dt.Clone
        For Each dr As DataRow In dt.Select("sta<>''")
            If Not (dr("sta") = "D" And Converts.ToInt_NullIsZero(dr("ID")) = 0) Then
                dtTrans.ImportRow(dr)
            End If
        Next

        If cls.SaveData(dtTrans) = True Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Function SaveValidate() As Boolean
        If grdData.DataSource Is Nothing Then Return False

        Dim dv As DataView = grdData.DataSource
        Dim dt As DataTable = dv.ToTable
        Dim RackDTID As Integer = 0
        For Each dr As DataRow In dt.Select("", "RackDTID")
            If RackDTID = dr("RackDTID") Then
                MessageBox.Show("Dupplicate Rack " & dr("Show") & "")
                Return False
            Else
                RackDTID = dr("RackDTID")
            End If
        Next

        Return True
    End Function

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnNew.Click
        Dim frm As New clsVTruckDT_NewTransBMW
        Dim dv As DataView = grdData.DataSource
        If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            Dim dt As DataTable = dv.ToTable
            Dim drAdd As DataRow = Nothing

            For Each dr As DataRow In frm.DialogResultData.select()
                'PrgTransaction.*,RackID,RackNo,concat(MstRackHD.Code,MstRackDT.RackNo) as Show,'' as sta
                'ID,ScanType,RackDTID,From,To,StaffCode,ScanDateTime,UpdateUser,UpdateDate,Replaced,TruckID
                drAdd = dt.NewRow
                drAdd("ID") = dr("ID")
                drAdd("ScanType") = dr("ScanType")
                drAdd("RackDTID") = dr("RackDTID")
                drAdd("From") = dr("From")
                drAdd("To") = dr("To")
                drAdd("StaffCode") = dr("StaffCode")
                drAdd("ScanDateTime") = dr("ScanDateTime")
                drAdd("UpdateUser") = dr("UpdateUser")
                drAdd("UpdateDate") = dr("UpdateDate")
                drAdd("Replaced") = dr("Replaced")
                drAdd("TruckID") = txtTruckID.Text.Trim
                drAdd("RackID") = dr("RackID")
                drAdd("RackNo") = dr("RackNo")
                drAdd("Show") = dr("Show")
                drAdd("Type") = dr("Type")
                drAdd("sta") = "N"
                dt.Rows.Add(drAdd)
            Next

            Dim dvNew As DataView
            dvNew = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
            grdData.DataSource = dvNew

            Summary()

            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnDelete.Click
        'If grdData.SelectedRow Is Nothing Then Exit Sub


        'grdData.SelectedRow("TruckID") = ""
        'grdData.SelectedRow("sta") = "D"

        If grdData.DataSource Is Nothing Then Exit Sub

        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable
        For Each dr As DataRow In dt.Select()
            If dr("chk") = 1 Then
                dr("chk") = 0
                dr("TruckID") = ""
                dr("sta") = "D"
            End If
        Next

        Dim dvNew As DataView
        dvNew = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dvNew

        'For i As Integer = 0 To grdData.RowCount - 1
        '    If grdData.Rows(i).Cells("chk").Value = 1 Then
        '        grdData.Rows(i).Cells("sta").Value = "D"
        '    End If
        'Next


        Summary()
    End Sub
#End Region
#Region "Summary"
    Private Sub Summary()
        Dim dv As DataView = grdData.DataSource
        Dim dt As DataTable = dv.ToTable
        txtRackAmount.Text = dt.Rows.Count
        txtFront.Text = dt.Compute("count(ID)", "Type=" & SystemINI.ModelTypeBMW.Front & " and sta<>'D'")
        txtRear.Text = dt.Compute("count(ID)", "Type=" & SystemINI.ModelTypeBMW.Rear & " and sta<>'D'")
        txtFrontRear.Text = dt.Compute("count(ID)", "Type=" & SystemINI.ModelTypeBMW.FrontRear & " and sta<>'D'")
        txtSTB.Text = dt.Compute("count(ID)", "Type=" & SystemINI.ModelTypeBMW.STB & " and sta<>'D'")
        txtMBikeFront.Text = dt.Compute("count(ID)", "Type=" & SystemINI.ModelTypeBMW.MBikeFront & " and sta<>'D'")
        txtMBikeRear.Text = dt.Compute("count(ID)", "Type=" & SystemINI.ModelTypeBMW.MBikeRear & " and sta<>'D'")
    End Sub
#End Region

    Private Sub btnCheckAll_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnCheckAll.Click
        If grdData.DataSource Is Nothing Then Exit Sub
        For i As Integer = 0 To grdData.Rows.Count - 1
            grdData.Rows(i).Cells("chk").Value = 1
        Next
        btnDelete.Enabled = True
    End Sub

    Private Sub btnReleaseAll_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnReleaseAll.Click
        If grdData.DataSource Is Nothing Then Exit Sub
        For i As Integer = 0 To grdData.Rows.Count - 1
            grdData.Rows(i).Cells("chk").Value = 0
        Next
    End Sub
End Class