Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVNewRack
    Private mRowRackHD As DataRow
    Private mDTCurrent As DataTable

    Public Property RowRackHD() As DataRow
        Get
            Return Nothing
        End Get
        Set(value As DataRow)
            mRowRackHD = value
        End Set
    End Property

    Public Property dtCurrent() As DataTable
        Get
            Return mDTCurrent
        End Get
        Set(value As DataTable)
            mDTCurrent = value
        End Set
    End Property


    Private Sub clsVNewRack_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If CustomerCode = "MB" Then
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Else
            btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        End If

        LoadForm()
    End Sub

    Private Sub LoadForm()
        Dim dtNew As DataTable = New DataTable
        dtNew.Columns.Add("chk", GetType(Integer))
        dtNew.Columns.Add("RackNo", GetType(String))

        Dim strIni As String = mRowRackHD("InitialNo")
        Dim strEnd As String = mRowRackHD("EndNo")
        Dim strPrefix As String = ""
        Dim RunDigit As Integer = 0
        For i As Integer = strIni.Length To 1 Step -1
            If IsNumeric(Strings.Right(strIni, i)) = True Then
                strPrefix = Strings.Left(strIni, strIni.Length - i)
                RunDigit = i
                Exit For
            End If
        Next

        Dim iIni As Integer = strIni.Replace(strPrefix, "")
        Dim iEnd As Integer = strEnd.Replace(strPrefix, "")
        For i As Integer = iIni To iEnd
            Dim strRackNo As String = strPrefix & i.ToString.PadLeft(RunDigit, "0")
            If dtCurrent.Compute("count(RackNo)", "RackNo='" & strRackNo & "'") = 0 Then
                Dim drNew As DataRow = dtNew.NewRow
                drNew("chk") = 1
                drNew("RackNo") = strRackNo
                dtNew.Rows.Add(drNew)
            End If
        Next

        grdData.DataSource = dtNew

    End Sub

#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_CheckBox("chk", "", "chk", , , , True)
            .ColumnAdd_TextBox("RackNo", "Rack No.", "RackNo")
        End With
        ComboSet.GridColumnSize(grdData)
    End Sub
#End Region

#Region "Select New Rack"
    Private Sub btnOK_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnOK.Click
        SelectRow()
    End Sub
    Private Sub SelectRow()
        Dim dtGrd As DataTable = grdData.DataSource
        Dim dtSelected As DataTable = dtGrd.Clone
        For Each drSelected As DataRow In dtGrd.Select()
            If Converts.ToInt_NullIsZero(drSelected("chk")) = 1 Then
                dtSelected.ImportRow(drSelected)
            End If
        Next

        Me.DialogResult = IIf(dtSelected.Rows.Count > 0, Windows.Forms.DialogResult.Yes, Windows.Forms.DialogResult.No)
        Me.DialogResultData = dtSelected
    End Sub
    Private Sub btnCheckAll_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnCheckAll.Click
        If grdData.DataSource Is Nothing Then Exit Sub
        For Each dr As DataRow In grdData.DataSource.select()
            dr("chk") = 1
        Next
    End Sub
    Private Sub btnReleaseAll_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnReleaseAll.Click
        If grdData.DataSource Is Nothing Then Exit Sub
        For Each dr As DataRow In grdData.DataSource.select()
            dr("chk") = 0
        Next
    End Sub
#End Region
    
End Class