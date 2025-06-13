Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVAddHoliday
    Public dtOldDate As DataTable
    Public dtNewDate As DataTable

    Private Sub clsVAddHoliday_Load(sender As Object, e As System.EventArgs) Handles Me.Load


    End Sub

    Private Sub ShowDate()
        If dtOldDate Is Nothing Then Exit Sub

        Dim dtShowDate As New DataTable
        dtShowDate.Columns.Add("chk", GetType(Integer))
        dtShowDate.Columns.Add("Holiday", GetType(Date))

        Dim iMonth As Integer = dtpSMonth.Value.Month
        Dim iYear As Integer = dtpSMonth.Value.Year

        Dim nDays As Integer = System.DateTime.DaysInMonth(iYear, iMonth)
        For i As Integer = 1 To nDays
            Dim iDay As Date = New Date(iYear, iMonth, i)
            If dtOldDate.Compute("count(Holiday)", "Holiday='" & Format(iDay, "yyyy-MM-dd") & "'") = 0 Then
                Dim drAdd As DataRow = dtShowDate.NewRow
                drAdd("chk") = 0
                drAdd("Holiday") = iDay
                dtShowDate.Rows.Add(drAdd)
            End If
        Next

        grdData.DataSource = dtShowDate
    End Sub

    Private Sub dtpSMonth_ValueChanged(sender As Object, e As System.EventArgs) Handles dtpSMonth.ValueChanged
        ShowDate()
    End Sub

#Region " Data Grid "
    Private Sub grdData_BindingGridColumns() Handles grdData.BindingGridColumns
        With grdData
            .Columns.Clear()
            .ColumnAdd_CheckBox("chk", "", "chk", , , , True)
            .ColumnAdd_TextBox("Holiday", "Holiday", "Holiday", 150)
        End With
        ComboSet.GridColumnSize(grdData)
    End Sub
#End Region

    Private Sub btnOK_Click(sender As Object, e As OPE_Controls.EventArgs) Handles btnOK.Click
        dtNewDate = dtOldDate.Copy
        Dim dtGrd As DataTable = grdData.DataSource
        For Each drGrd As DataRow In dtGrd.Select()
            If Converts.ToInt_NullIsZero(drGrd("chk")) = 1 Then
                Dim drAdd As DataRow = dtNewDate.NewRow
                drAdd("Holiday") = drGrd("Holiday")
                drAdd("_Status") = "N"
                dtNewDate.Rows.Add(drAdd)
            End If
        Next

        Dim cls As New clsCMstHoliday
        If cls.SaveData(dtNewDate) = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub clsVAddHoliday_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        dtpSMonth.Value = CustomizeSetting.SystemDate
    End Sub
End Class