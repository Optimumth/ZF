Imports System.Data
Imports System.Windows.Forms
Imports ZFDockAuditBMW.Barcode_System

Public Class clsVModelDockList
    Private MoveActiveDateTime As DateTime
    Public dtGrid As DataTable = Nothing
    Public mModelDock As String = ""

#Region "Form Event"
    Private Sub clsVModelDockList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click
        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub

    Private Sub clsVModelDockList_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Timer1.Enabled = False
    End Sub

    Private Sub clsVModelDockList_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnExit.KeyUp, grdData.KeyUp
        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.D1 : GetData(1)
            Case Keys.D2 : GetData(2)
            Case Keys.D3 : GetData(3)
            Case Keys.D4 : GetData(4)
            Case Keys.D5 : GetData(5)
            Case Keys.D6 : GetData(6)
            Case Keys.D7 : GetData(7)
            Case Keys.D8 : GetData(8)
            Case Keys.D9 : GetData(9)
            Case Keys.Escape : ExitClick()
        End Select
    End Sub

    Private Sub GetData(ByVal iID As Integer)
        If grdData.DataSource Is Nothing Then Exit Sub

        Dim dtData As DataTable = grdData.DataSource
        Dim OK As Boolean = False
        Dim sModelDock As String = ""
        For Each drData As DataRow In dtData.Select()
            If CInt(drData("ID")) = iID Then
                sModelDock = drData("ModelDock").ToString
                OK = True
                Exit For
            End If
        Next

        If OK = True Then
            mModelDock = sModelDock
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub clsVModelDockList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowGrid()
        '==============================
        Dim col0 As New DataGridTextBoxColumn
        col0.MappingName = "ID"
        col0.HeaderText = "ID"
        col0.Width = 50

        Dim col1 As New DataGridTextBoxColumn
        col1.MappingName = "ModelDock"
        col1.HeaderText = "ModelDock"
        col1.Width = 200

        Dim GridTBStyle As New DataGridTableStyle
        GridTBStyle.MappingName = "Transaction"
        With GridTBStyle.GridColumnStyles
            .Add(col0)
            .Add(col1)
        End With
        grdData.TableStyles.Add(GridTBStyle)
        '==============================
        MoveActiveDateTime = Now

        Me.KeyPreview = True
        Timer1.Enabled = True
    End Sub
#End Region

#Region "Call Function"
    Private Sub ShowGrid()
        Dim dtShowGrid As New DataTable
        dtShowGrid.TableName = "ModelDock"
        dtShowGrid.Columns.Add("ID", GetType(Integer))
        dtShowGrid.Columns.Add("ModelDock", GetType(String))

        Dim drAdd As DataRow = Nothing
        Dim ID As Integer = 1
        For Each dr As DataRow In dtGrid.Select("", "ModelDock")
            drAdd = dtShowGrid.NewRow
            drAdd("ID") = ID
            drAdd("ModelDock") = dr("ModelDock")

            dtShowGrid.Rows.Add(drAdd)

            ID += 1
        Next

        With grdData
            .DataSource = dtShowGrid
        End With
    End Sub

    Private Sub ExitClick()
        DialogResult = Windows.Forms.DialogResult.Cancel
        CloseForm()
    End Sub

    Private Sub CloseForm()
        Me.Close()
    End Sub
#End Region
End Class