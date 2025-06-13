Imports OPE_Controls.OpeStyle
Imports ZFRackVisual.CustomizeSetting

Public Class clsVWorkPeriod
    Private cls As New clsCWorkPeriod

    Private Sub clsVWorkPeriod_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            grdWorkingZF.ReadOnly = True
            grdWorkingCustomer.ReadOnly = True
            grdDeliZF.ReadOnly = True
            grdDeliCus.ReadOnly = True
            grdWorkingZF.DataSource = cls.getMasterTime(True)
            grdWorkingCustomer.DataSource = cls.getMasterTime(False)
            grdDeliZF.DataSource = cls.getMasterDeliveryTime(True)
            grdDeliCus.DataSource = cls.getMasterDeliveryTime(False)
            btnSaveWorkZF.Enabled = False
            btnSaveWorkCus.Enabled = False
            btnSaveDeliZF.Enabled = False
            btnSaveDeliCus.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdWorkingZF_BindingGridColumns() Handles grdWorkingZF.BindingGridColumns
        Try
            BindGrid(grdWorkingZF)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdWorkingCustomer_BindingGridColumns() Handles grdWorkingCustomer.BindingGridColumns
        Try
            BindGrid(grdWorkingCustomer)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdDeliZF_BindingGridColumns() Handles grdDeliZF.BindingGridColumns
        Try
            BindGrid(grdDeliZF)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdDeliCus_BindingGridColumns() Handles grdDeliCus.BindingGridColumns
        Try
            BindGrid(grdDeliCus)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BindGrid(ByVal grd As OPE_Controls.opeDataGrid)
        Try
            If grd.Name = grdWorkingZF.Name Or grd.Name = grdWorkingCustomer.Name Then
                With grd
                    .Columns.Clear()
                    .ColumnAdd_TextBox("Period", "Period", "Period", , , , , , True)
                    .ColumnAdd_TextBox("Start", "Start", "Start", , , , , , True)
                    .ColumnAdd_TextBox("Stop", "Stop", "Stop", , , , , , True)
                    '.ReadOnly = True
                End With
            Else
                With grd
                    .Columns.Clear()
                    .ColumnAdd_TextBox("Period", "Trip No.", "Period", , , , , , True)
                    .ColumnAdd_TextBox("Time", "Time", "Time", , , , , , True)

                    '.ReadOnly = True
                End With
            End If

            setGridColor(grd)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setGridColor(ByVal grd As OPE_Controls.opeDataGrid)
        If Not grd Is Nothing AndAlso grd.RowCount > 0 Then
            Dim Color As Color = IIf(grd.ReadOnly = True, Color.LightGray, Color.White)
            For iRow As Integer = 0 To grd.RowCount - 1
                grd.Rows(iRow).DefaultCellStyle.BackColor = Color
            Next
        End If
    End Sub

    Private Sub tabWorkPeriod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabTimeControl.SelectedIndexChanged
        Try
            Select Case tabTimeControl.SelectedIndex
                Case 0 : BindGrid(grdWorkingZF)
                Case 1 : BindGrid(grdWorkingCustomer)
                Case 2 : BindGrid(grdDeliZF)
                Case 3 : BindGrid(grdDeliCus)
            End Select
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As OPE_Controls.EventArgs) Handles btnEditWorkZF.Click, btnEditWorkCus.Click, btnEditDeliZF.Click, btnEditDeliCus.Click
        Try
            Dim grd As OPE_Controls.opeDataGrid = Nothing

            Select Case sender.name
                Case btnEditWorkZF.Name
                    grd = grdWorkingZF
                    btnSaveWorkZF.Enabled = True
                    btnEditWorkZF.Enabled = False
                Case btnEditWorkCus.Name
                    grd = grdWorkingCustomer
                    btnSaveWorkCus.Enabled = True
                    btnEditWorkCus.Enabled = False
                Case btnEditDeliZF.Name
                    grd = grdDeliZF
                    btnSaveDeliZF.Enabled = True
                    btnEditDeliZF.Enabled = False
                Case btnEditDeliCus.Name
                    grd = grdDeliCus
                    btnSaveDeliCus.Enabled = True
                    btnEditDeliCus.Enabled = False
            End Select

            If grd Is Nothing Then Exit Sub
            With grd
                .AllowUserToAddRows = True
                .AllowUserToDeleteRows = True
                .ReadOnly = False
                setGridColor(grd)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnSaveWorkZF.Click, btnSaveWorkCus.Click, btnSaveDeliZF.Click, btnSaveDeliCus.Click
        Try
            Dim grd As OPE_Controls.opeDataGrid = Nothing
            Dim fZF As Boolean = False

            Select Case sender.name
                Case btnSaveWorkZF.Name
                    grd = grdWorkingZF
                    fZF = True
                    btnSaveWorkZF.Enabled = False
                    btnEditWorkZF.Enabled = True
                Case btnSaveWorkCus.Name
                    grd = grdWorkingCustomer
                    fZF = False
                    btnSaveWorkCus.Enabled = False
                    btnEditWorkCus.Enabled = True
                Case btnSaveDeliZF.Name
                    grd = grdDeliZF
                    fZF = True
                    btnSaveDeliZF.Enabled = False
                    btnEditDeliZF.Enabled = True
                Case btnSaveDeliCus.Name
                    grd = grdDeliCus
                    fZF = False
                    btnSaveDeliCus.Enabled = False
                    btnEditDeliCus.Enabled = True
            End Select

            If grd Is Nothing Then Exit Sub

            With grd
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
            End With

            For iRow As Integer = 0 To grd.RowCount - 1
                If grd.Rows(iRow).Cells(0).Value.ToString = "" Then
                    grd.Rows.RemoveAt(iRow)
                End If
            Next

            Dim dt As DataTable = grd.DataSource

            If sender.name = btnSaveWorkZF.Name Or sender.name = btnSaveWorkCus.Name Then
                Call cls.WriteMstPeriod(dt, fZF)
            Else
                Call cls.WriteMstDelivery(dt, fZF)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Validate(ByVal sender As Object, ByVal e As OPE_Controls.EventArgs) Handles btnSaveWorkZF.Validate, btnSaveWorkCus.Validate, btnSaveDeliZF.Validate, btnSaveDeliCus.Validate
        Try
            Dim bTrue As Boolean = True

            Dim grd As OPE_Controls.opeDataGrid = Nothing
            Select Case sender.name
                Case btnSaveWorkZF.Name : grd = grdWorkingZF
                Case btnSaveWorkCus.Name : grd = grdWorkingCustomer
                Case btnSaveDeliZF.Name : grd = grdDeliZF
                Case btnSaveDeliCus.Name : grd = grdDeliCus
            End Select

            grd.EndEdit()
            grd.Refresh()
            Dim dt As DataTable = grd.DataSource
            dt.Columns.Add("iPeriod", GetType(Integer))
            For Each dr As DataRow In dt.Select()
                dr("iPeriod") = dr("Period")
            Next

            For iRow As Integer = 0 To grd.Rows.Count - 1
                For iCol As Integer = 0 To grd.Columns.Count - 1
                    grd.Rows(iRow).Cells(iCol).ErrorText = ""
                Next
            Next

            If bTrue = True Then
                For iRow As Integer = 0 To dt.Rows.Count - 1
                    Dim dr As DataRow = dt.Rows(iRow)
                    For iCol As Integer = 0 To IIf(sender.name = grdWorkingZF.Name Or sender.name = grdWorkingCustomer.Name, 2, 1)
                        If Converts.ToStr(dr(iCol)) = "" Then
                            grd.Rows(iRow).Cells(iCol).ErrorText = "Invalid Data"
                            bTrue = False
                        End If
                    Next
                Next
            End If


            If bTrue = True Then
                Dim iPeriod As Integer = -1
                For Each dr As DataRow In dt.Select("", "iPeriod")
                    If iPeriod = dr("Period") Then
                        For iRow As Integer = 0 To grd.Rows.Count - 1
                            If iPeriod = Converts.ToInt_NullIsZero(grd.Rows(iRow).Cells(0).Value) Then
                                grd.Rows(iRow).Cells("Period").ErrorText = "Invalid Period (Dupplicate)"
                            End If
                        Next
                        bTrue = False
                        Exit For
                    Else
                        iPeriod = dr("Period")
                    End If
                Next
            End If

            If bTrue = True Then
                Dim iPeriod As Integer = 1
                For Each dr As DataRow In dt.Select("", "iPeriod")
                    If iPeriod = dr("Period") Then
                        iPeriod += 1
                    Else
                        For iRow As Integer = 0 To grd.Rows.Count - 1
                            If iPeriod < Converts.ToInt_NullIsZero(grd.Rows(iRow).Cells("Period").Value) Then
                                grd.Rows(iRow).ErrorText = "Invalid Period (Skip)"
                            End If
                        Next
                        bTrue = False
                        Exit For
                    End If
                Next
            End If
            If bTrue = True Then
                If sender.name = btnSaveWorkZF.Name Or sender.name = btnSaveWorkCus.Name Then
                    Dim sStart As String = ""
                    Dim sStop As String = ""
                    For Each dr As DataRow In dt.Select("", "iPeriod")
                        If sStop <> "" AndAlso sStop > dr("Start") Then
                            For iRow As Integer = 0 To grd.Rows.Count
                                If dr("Period") = Converts.ToInt_NullIsZero(grd.Rows(iRow).Cells("Period").Value) Then
                                    grd.Rows(iRow).Cells("Start").ErrorText = "Invalid Time"
                                    Exit For
                                End If
                            Next
                            bTrue = False
                            'ElseIf dr("Start") >= dr("Stop") Then
                            '    For iRow As Integer = 0 To grd.Rows.Count
                            '        If dr("Period") = Converts.ToInt_NullIsZero(grd.Rows(iRow).Cells("Period").Value) Then
                            '            grd.Rows(iRow).Cells("Stop").ErrorText = "Invalid Time"
                            '            Exit For
                            '        End If
                            '    Next
                            '    bTrue = False
                        End If

                        sStart = dr("Start")
                        sStop = dr("Stop")
                    Next
                Else
                    'Dim sStart As String = ""
                    'For Each dr As DataRow In dt.Select("", "iPeriod")
                    '    If sStart <> "" AndAlso sStart > dr("Time") Then
                    '        For iRow As Integer = 0 To grd.Rows.Count
                    '            If dr("Period") = Converts.ToInt_NullIsZero(grd.Rows(iRow).Cells("Period").Value) Then
                    '                grd.Rows(iRow).Cells("Time").ErrorText = "Invalid Time"
                    '                Exit For
                    '            End If
                    '        Next
                    '        bTrue = False
                    '    End If
                    '    sStart = dr("Time")
                    'Next
                End If
            End If

            dt.Columns.Remove("iPeriod")

            If Not bTrue Then e.DialogResult = Windows.Forms.DialogResult.No
        Catch ex As Exception
            e.DialogResult = Windows.Forms.DialogResult.No
        End Try
    End Sub

    Private Sub grd_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdWorkingZF.CellEnter, grdWorkingCustomer.CellEnter, grdDeliZF.CellEnter, grdDeliCus.CellEnter
        Try
            Dim grd As OPE_Controls.opeDataGrid = Nothing
            Select Case sender.name
                Case grdWorkingZF.Name : grd = grdWorkingZF
                Case grdWorkingCustomer.Name : grd = grdWorkingCustomer
                Case grdDeliZF.Name : grd = grdDeliZF
                Case grdDeliCus.Name : grd = grdDeliCus
            End Select

            If grd Is Nothing OrElse grd.DataSource Is Nothing OrElse grd.DataSource.rows.count = 0 Then Exit Sub

            Select Case sender.name
                Case grdWorkingZF.Name : btnEditWorkZF.Enabled = True
                Case grdWorkingCustomer.Name : btnEditWorkCus.Enabled = True
                Case grdDeliZF.Name : btnEditDeliZF.Enabled = True
                Case grdDeliCus.Name : btnEditDeliCus.Enabled = True
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grd_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grdWorkingZF.CellValidating, grdWorkingCustomer.CellValidating
        Try
            Dim grd As OPE_Controls.opeDataGrid = Nothing
            Select Case sender.name
                Case grdWorkingZF.Name : grd = grdWorkingZF
                Case grdWorkingCustomer.Name : grd = grdWorkingCustomer
                Case grdDeliZF.Name : grd = grdDeliZF
                Case grdDeliCus.Name : grd = grdDeliCus
            End Select

            If grd Is Nothing Then Exit Sub
            If e.FormattedValue.ToString = "" Then Exit Sub
            Select Case e.ColumnIndex
                Case 0
                    If Not IsNumeric(e.FormattedValue) Then e.Cancel = True
                Case 1, 2
                    Dim str As String = e.FormattedValue.ToString
                    If str.Length <> 5 Then
                        e.Cancel = True
                    ElseIf IsNumeric(Strings.Left(str, 2)) = False OrElse IsNumeric(Strings.Right(str, 2)) = False Then
                        e.Cancel = True
                    ElseIf str.Substring(2, 1) <> "." Then
                        e.Cancel = True
                    ElseIf Not (Converts.ToInt_NullIsZero(Strings.Left(str, 2)) >= 0 And Converts.ToInt_NullIsZero(Strings.Left(str, 2)) <= 23 And Converts.ToInt_NullIsZero(Strings.Right(str, 2)) >= 0 And Converts.ToInt_NullIsZero(Strings.Right(str, 2)) <= 59) Then
                        e.Cancel = True
                    End If
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelpWorkTimeZF.Click, btnHelpWorkTimeCus.Click, btnHelpDeliCus.Click, btnHelpDeliZF.Click
        Try
            Dim frm As New clsVSample
            Select Case sender.name
                Case btnHelpWorkTimeZF.Name, btnHelpWorkTimeCus.Name
                    frm.picWorkingTime.Visible = True
                    frm.ShowDialog()
                Case btnHelpDeliCus.Name, btnHelpDeliZF.Name
                    frm.PicDelivery.Visible = True
                    frm.ShowDialog()
            End Select

            frm = Nothing
        Catch ex As Exception

        End Try

    End Sub
End Class