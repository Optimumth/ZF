Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVMstRackDT
    Private cls As New clsCMstRackDT
    Private mRowRackHD As DataRow

    Public Property RowRackHD() As DataRow
        Get
            Return Nothing
        End Get
        Set(value As DataRow)
            mRowRackHD = value
        End Set
    End Property

#Region "Load"
    Private Sub clsVMstRackDT_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If

        btnSearch.PerformClick()
    End Sub
    Private Sub LoadForm()
        txtType.Text = mRowRackHD("TypeName")
        txtModel.Text = mRowRackHD("Model")
        txtCode.Text = mRowRackHD("Code")
        txtRemark.Text = mRowRackHD("Remark")
        txtQty.Text = mRowRackHD("Qty")
        txtInitialNo.Text = mRowRackHD("InitialNo")
        txtEndNo.Text = mRowRackHD("EndNo")
        txtInitialRackID.Text = mRowRackHD("InitialRackID")
        txtEndRackID.Text = mRowRackHD("EndRackID")

        Dim dtDT As DataTable = cls.GetDT(mRowRackHD("RackHeaderID"))
        Dim dv As DataView
        dv = New DataView(dtDT, "sta<>'D'", "", DataViewRowState.CurrentRows)
        grdData.DataSource = dv

        btnSave.Enabled = False
    End Sub
#End Region

#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_TextBox("RackHeaderID", "RackHeaderID", "RackHeaderID", , , , , False)
            .ColumnAdd_TextBox("RackID", "RackID", "RackID", 100, , , , , True)
            .ColumnAdd_TextBox("RackNo", "RackNo", "RackNo")
            .ColumnAdd_TextBox("Show", "Show", "Show", 100)
            .ColumnAdd_CheckBox("ActiveFlag", "Active", "ActiveFlag", , , , True)
            .ColumnAdd_CheckBox("LossFlag", "Loss", "LossFlag", , , , True)
            .ColumnAdd_TextBox("LossDate", "Loss Date", "LossDate", 200, , DataGridViewContentAlignment.MiddleCenter, Styles.DateCustomFormatDateTime)
            .ColumnAdd_TextBox("LossRemark", "LossRemark", "LossRemark", 200, , , , , True)
            .ColumnAdd_TextBox("sta", "sta", "sta", , , , , False)
        End With
        ComboSet.GridColumnSize(grdData)
    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick
        If grdData.DataSource Is Nothing Then Exit Sub
        If e.ColumnIndex = grdData.Columns("ActiveFlag").Index Or e.ColumnIndex = grdData.Columns("LossFlag").Index Then
            If Converts.ToStr(grdData.Rows(e.RowIndex).Cells("sta").Value) = "" Then
                grdData.Rows(e.RowIndex).Cells("sta").Value = "U"
            End If
            grdData.EndEdit()

            If e.ColumnIndex = grdData.Columns("LossFlag").Index Then
                If Converts.ToInt_NullIsZero(grdData.Rows(e.RowIndex).Cells("LossFlag").Value) = 0 Then
                    grdData.Rows(e.RowIndex).Cells("LossDate").Value = DBNull.Value
                    grdData.Rows(e.RowIndex).Cells("LossRemark").Value = ""
                Else
                    grdData.Rows(e.RowIndex).Cells("LossDate").Value = SystemDate
                End If
            End If
        End If
    End Sub
    Private Sub grdData_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit
        If e.ColumnIndex = grdData.Columns("LossRemark").Index Then
            If Converts.ToInt_NullIsZero(grdData.Rows(e.RowIndex).Cells("LossFlag").Value) = 0 Then
                grdData.Rows(e.RowIndex).Cells("LossRemark").Value = ""
            End If
        End If
        If Converts.ToStr(grdData.Rows(e.RowIndex).Cells("sta").Value) = "" Then
            grdData.Rows(e.RowIndex).Cells("sta").Value = "U"
        End If
        btnSave.Enabled = True
    End Sub
#End Region

#Region "Toolbar Click"
    Private Sub btnSearch_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSearch.Click
        LoadForm()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnSave.Click
        If SaveValidate() = False Then Exit Sub

        Dim dv As DataView = grdData.DataSource
        dv.RowFilter = ""
        Dim dt As DataTable = dv.ToTable
        Dim dtRackDT As DataTable = dt.Clone
        For Each dr As DataRow In dt.Select("sta<>''")
            If IsDBNull(dr("ActiveFlag")) Then dr("ActiveFlag") = 0
            If IsDBNull(dr("LossFlag")) Then dr("LossFlag") = 0

            If Not (dr("sta") = "D" And Converts.ToInt_NullIsZero(dr("ID")) = 0) Then
                dtRackDT.ImportRow(dr)
            End If
        Next
        Dim OldQty As Integer = mRowRackHD("Qty")
        mRowRackHD("Qty") = Converts.ToInt_NullIsZero(txtQty.Text.Trim)
        If cls.SaveData(mRowRackHD, dtRackDT) = True Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        Else
            mRowRackHD("Qty") = OldQty
        End If
    End Sub

    Private Function SaveValidate() As Boolean
        Dim dv As DataView = grdData.DataSource
        Dim dt As DataTable = dv.ToTable

        If dt.Compute("count(RackID)", "RackID=''") > 0 Then
            MsgBox("Please input RackID")
            Return False
        Else
            For Each drGrd As DataRow In dt.Select()
                If dt.Compute("count(RackID)", "RackID='" & drGrd("RackID") & "'") > 1 Then
                    MsgBox("Dupplicate RackID '" & drGrd("RackID") & "' in grid")
                    Return False
                Else
                    Dim dtchkDupRack As DataTable = DataBase.DataSelect("MstRackDT" _
                                        , "RackHeaderID<>" & mRowRackHD("RackHeaderID") & " and RackID='" & drGrd("RackID") & "' and DelFlag=0")
                    If dtchkDupRack.Rows.Count > 0 Then
                        MsgBox("Dupplicate RackID '" & drGrd("RackID") & "' in database")
                        Return False
                    End If
                End If
            Next
        End If

        Return True
    End Function

    Private Sub btnNew_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnNew.Click
        Dim frm As New clsVNewRack
        Dim dv As DataView = grdData.DataSource
        frm.dtCurrent = dv.ToTable
        frm.RowRackHD = mRowRackHD
        If frm.ShowDialog = Windows.Forms.DialogResult.Yes Then
            Dim dt As DataTable = dv.ToTable
            Dim drAdd As DataRow = Nothing
            Dim AutoRackID As Boolean
            Dim RackRun As Integer = 0
            Dim RackLast As Integer = 0
            Dim iniPrefix As String = ""
            Dim EndPrefix As String = ""
            Dim iniRunDigit As Integer = 0
            Dim EndRunDigit As Integer = 0

            If dt.Rows.Count = 0 And txtInitialRackID.Text.Trim <> "" And txtEndRackID.Text.Trim <> "" Then
                AutoRackID = True
            Else
                AutoRackID = False
            End If
            If AutoRackID = True Then
                For i As Integer = txtInitialRackID.Text.Trim.Length To 1 Step -1
                    If IsNumeric(Strings.Right(txtInitialRackID.Text.Trim, i)) = True Then
                        iniPrefix = Strings.Left(txtInitialRackID.Text.Trim, txtInitialRackID.Text.Trim.Length - i)
                        iniRunDigit = i
                        Exit For
                    End If
                Next
                For i As Integer = txtEndRackID.Text.Trim.Length To 1 Step -1
                    If IsNumeric(Strings.Right(txtEndRackID.Text.Trim, i)) = True Then
                        EndPrefix = Strings.Left(txtEndRackID.Text.Trim, txtEndRackID.Text.Trim.Length - i)
                        EndRunDigit = i
                        Exit For
                    End If
                Next
                RackRun = Converts.ToInt_NullIsZero(Strings.Right(txtInitialRackID.Text.Trim, iniRunDigit))
                RackLast = Converts.ToInt_NullIsZero(Strings.Right(txtEndRackID.Text.Trim, EndRunDigit))
            End If

            For Each dr As DataRow In frm.DialogResultData.select()
                drAdd = dt.NewRow
                drAdd("ID") = 0
                If AutoRackID = True And RackRun <= RackLast Then
                    drAdd("RackID") = iniPrefix & RackRun.ToString.PadLeft(iniRunDigit, "0")
                    RackRun += 1
                Else
                    drAdd("RackID") = ""
                End If
                drAdd("RackHeaderID") = mRowRackHD("RackHeaderID")
                drAdd("RackNo") = dr("RackNo")
                drAdd("ActiveFlag") = 1
                drAdd("DelFlag") = 0
                drAdd("Show") = mRowRackHD("Code") & dr("RackNo")
                drAdd("sta") = "N"
                dt.Rows.Add(drAdd)
            Next

            Dim dvNew As DataView
            dvNew = New DataView(dt, "sta<>'D'", "", DataViewRowState.CurrentRows)
            grdData.DataSource = dvNew

            txtQty.Text = grdData.RowCount

            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnDelete.Click
        If grdData.SelectedRow Is Nothing Then Exit Sub

        grdData.SelectedRow("sta") = "D"

        txtQty.Text = grdData.RowCount
    End Sub
#End Region

    
    
End Class
