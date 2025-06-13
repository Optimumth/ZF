Imports System.Data
Imports System.Windows.Forms
Imports ZF_PKCtrl.Barcode_System

Public Class clsVView
    Private dtGrid As DataTable = Nothing
    Private SearchRackDTID As Integer = 0

    Public mScanType As Integer = 0
    Public Enum eScanType
        MB = 1
        Sup = 2
        Ext = 3
    End Enum
    Public Enum eQR
        Rack = 0
        Remark = 1
        Model = 2
        Code = 3
        Running = 4
    End Enum

#Region "Program Active"
    Private Sub clsVView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnExit.KeyUp, btnDeleteRack.KeyUp, btnDeleteTruck.KeyUp, btnSortA.KeyUp, btnSortD.KeyUp, grdData.KeyUp, txtRackQty.KeyUp, txtTruckQty.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click, btnDeleteRack.Click, btnDeleteTruck.Click, grdData.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnDeleteTruck.Name : DeleteTruck()
                Case btnDeleteRack.Name : DeleteRack()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
#End Region

#Region "Call Function"
    Private Sub DeleteRack()
        If grdData.CurrentRowIndex < 0 Then Exit Sub

        Dim frm As New clsVAuthor
        Dim Pssword As String = ""
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pssword = frm.txtPassword.Text.Trim
            frm.Dispose()
            If Pssword = clsCMove.GetPassword Then
                Dim ID As Integer = Convert.ToInt16(grdData(grdData.CurrentRowIndex, 0))
                P_DB.runSQLCE("delete from PrgTrans where ID=" & ID & "")
                Dim i As Integer = 1
                Dim dtPrgTrans As DataTable = clsCMove.GetPrgTrans(0, 0)
                If dtPrgTrans.Rows.Count > 0 Then
                    For Each drPrgTrans As DataRow In dtPrgTrans.Select("", "ID")
                        P_DB.runSQLCE("update PrgTrans set ID=" & i & " where ID=" & Convert.ToInt16(drPrgTrans("ID")) & "")
                        i = i + 1
                    Next
                End If
                dtGrid = clsCMove.GetPrgTrans(mScanType, SearchRackDTID)
                ShowGrid()
            Else
                MessageBox.Show("Invalid password")
            End If
        End If
    End Sub

    Private Sub DeleteTruck()
        If grdData.CurrentRowIndex < 0 Then Exit Sub
        If Convert.ToString(grdData(grdData.CurrentRowIndex, 0)) = "" Then Exit Sub

        Dim frm As New clsVAuthor
        Dim Pssword As String = ""
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Pssword = frm.txtPassword.Text.Trim
            frm.Dispose()
            If Pssword = clsCMove.GetPassword Then
                Dim ID As Integer = Convert.ToInt16(grdData(grdData.CurrentRowIndex, 0))
                P_DB.runSQLCE("update PrgTrans set TruckID='' where ID=" & ID & "")
                dtGrid = clsCMove.GetPrgTrans(mScanType, SearchRackDTID)
                ShowGrid()
            Else
                MessageBox.Show("Invalid password")
            End If
        End If
    End Sub

    Private Sub ExitClick()
        CloseForm()
    End Sub
#End Region

    Private Sub clsVView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtGrid = clsCMove.GetPrgTrans(mScanType, 0)
            ShowGrid()

            Dim col0 As New DataGridTextBoxColumn
            col0.MappingName = "ID"
            col0.HeaderText = "ID"
            col0.Width = 50

            Dim col1 As New DataGridTextBoxColumn
            col1.MappingName = "Item"
            col1.HeaderText = "Item"
            col1.Width = 120

            Dim col2 As New DataGridTextBoxColumn
            col2.MappingName = "From"
            col2.HeaderText = "From"
            col2.Width = 100

            Dim col3 As New DataGridTextBoxColumn
            col3.MappingName = "To"
            col3.HeaderText = "To"
            col3.Width = 100

            Dim col4 As New DataGridTextBoxColumn
            col4.MappingName = "ScanDateTime"
            col4.HeaderText = "Scan DateTime"
            col4.Width = 200

            Dim col5 As New DataGridTextBoxColumn
            col5.MappingName = "TruckID"
            col5.HeaderText = "Truck ID"
            col5.Width = 200

            Dim GridTBStyle As New DataGridTableStyle
            GridTBStyle.MappingName = "Transaction"
            With GridTBStyle.GridColumnStyles
                .Add(col0)
                .Add(col1)
                .Add(col2)
                .Add(col3)
                .Add(col4)
                .Add(col5)
            End With
            grdData.TableStyles.Add(GridTBStyle)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub clsVView_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'If isReaderInitiated Then
        '    myScanSampleAPI.DetachReadNotify()
        '    myScanSampleAPI.DetachStatusNotify()
        '    myScanSampleAPI.TermReader()
        'End If
    End Sub


    Private Sub ShowGrid()
        'Grid Datasource = Transaction --> ID,Item,Current,New
        'ID,Item,From,To,ScanDateTime
        Dim dtShowGrid As New DataTable
        dtShowGrid.TableName = "Transaction"
        dtShowGrid.Columns.Add("ID", GetType(Integer))
        dtShowGrid.Columns.Add("Item", GetType(String))
        dtShowGrid.Columns.Add("From", GetType(String))
        dtShowGrid.Columns.Add("To", GetType(String))
        dtShowGrid.Columns.Add("ScanDateTime", GetType(String))
        dtShowGrid.Columns.Add("TruckID", GetType(String))

        Dim drAdd As DataRow = Nothing
        For Each drTrans As DataRow In dtGrid.Select("", "ID")
            drAdd = dtShowGrid.NewRow
            drAdd("ID") = drTrans("ID")
            drAdd("Item") = String.Concat(drTrans("Code"), drTrans("Running"))
            drAdd("From") = drTrans("From")
            drAdd("To") = drTrans("To")
            drAdd("ScanDateTime") = Format(drTrans("ScanDateTime"), "dd-MM HH:mm:ss")
            drAdd("TruckID") = drTrans("TruckID")
            dtShowGrid.Rows.Add(drAdd)
        Next

        With grdData
            .DataSource = dtShowGrid
        End With

        txtRackQty.Text = dtShowGrid.Rows.Count.ToString

        Dim sTruckID As String = ""
        Dim nTruckID As Integer = 0
        For Each dr As DataRow In dtShowGrid.Select("", "TruckID")
            If Convert.ToString(dr("TruckID")) <> "" Then
                If sTruckID <> dr("TruckID").ToString Then
                    sTruckID = dr("TruckID").ToString
                    nTruckID += 1
                End If
            End If
        Next
        txtTruckQty.Text = nTruckID.ToString
    End Sub

    Private Sub CloseForm()
        Me.Close()
    End Sub


    Private Sub btnSortA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortA.Click
        If grdData.DataSource Is Nothing Then Exit Sub
        Dim ColNo As Integer = Convert.ToInt16(grdData.CurrentCell.ColumnNumber)
        Dim ColSort As String = ""
        Select Case ColNo
            Case 0 : ColSort = "ID"
            Case 1 : ColSort = "Code,Running"
            Case 2 : ColSort = "From"
            Case 3 : ColSort = "To"
            Case 4 : ColSort = "ScanDateTime"
            Case 5 : ColSort = "TruckID"
        End Select

        Dim dtShowGrid As New DataTable
        dtShowGrid.TableName = "Transaction"
        dtShowGrid.Columns.Add("ID", GetType(Integer))
        dtShowGrid.Columns.Add("Item", GetType(String))
        dtShowGrid.Columns.Add("From", GetType(String))
        dtShowGrid.Columns.Add("To", GetType(String))
        dtShowGrid.Columns.Add("ScanDateTime", GetType(String))
        dtShowGrid.Columns.Add("TruckID", GetType(String))

        Dim drAdd As DataRow = Nothing
        For Each drTrans As DataRow In dtGrid.Select("", ColSort)
            drAdd = dtShowGrid.NewRow
            drAdd("ID") = drTrans("ID")
            drAdd("Item") = String.Concat(drTrans("Code"), drTrans("Running"))
            drAdd("From") = drTrans("From")
            drAdd("To") = drTrans("To")
            drAdd("ScanDateTime") = Format(drTrans("ScanDateTime"), "dd-MM HH:mm:ss")
            drAdd("TruckID") = drTrans("TruckID")
            dtShowGrid.Rows.Add(drAdd)
        Next

        With grdData
            .DataSource = dtShowGrid
        End With

        txtRackQty.Text = dtShowGrid.Rows.Count.ToString
    End Sub

    Private Sub btnSortD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortD.Click
        If grdData.DataSource Is Nothing Then Exit Sub
        Dim ColNo As Integer = Convert.ToInt16(grdData.CurrentCell.ColumnNumber)
        Dim ColSort As String = ""
        Select Case ColNo
            Case 0 : ColSort = "ID desc"
            Case 1 : ColSort = "Code,Running desc"
            Case 2 : ColSort = "From desc"
            Case 3 : ColSort = "To desc"
            Case 4 : ColSort = "ScanDateTime desc"
            Case 5 : ColSort = "TruckID desc"
        End Select

        Dim dtShowGrid As New DataTable
        dtShowGrid.TableName = "Transaction"
        dtShowGrid.Columns.Add("ID", GetType(Integer))
        dtShowGrid.Columns.Add("Item", GetType(String))
        dtShowGrid.Columns.Add("From", GetType(String))
        dtShowGrid.Columns.Add("To", GetType(String))
        dtShowGrid.Columns.Add("ScanDateTime", GetType(String))
        dtShowGrid.Columns.Add("TruckID", GetType(String))

        Dim drAdd As DataRow = Nothing
        For Each drTrans As DataRow In dtGrid.Select("", ColSort)
            drAdd = dtShowGrid.NewRow
            drAdd("ID") = drTrans("ID")
            drAdd("Item") = String.Concat(drTrans("Code"), drTrans("Running"))
            drAdd("From") = drTrans("From")
            drAdd("To") = drTrans("To")
            drAdd("ScanDateTime") = Format(drTrans("ScanDateTime"), "dd-MM HH:mm:ss")
            drAdd("TruckID") = drTrans("TruckID")
            dtShowGrid.Rows.Add(drAdd)
        Next

        With grdData
            .DataSource = dtShowGrid
        End With

        txtRackQty.Text = dtShowGrid.Rows.Count.ToString
    End Sub
End Class