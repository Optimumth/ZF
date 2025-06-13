Imports System.Data
Imports System.Windows.Forms
Imports ZFDockAuditBMW.Barcode_System

Public Class clsVView
    Private dtGrid As DataTable = Nothing
    Private SearchRackDTID As Integer = 0

    Public mAxleShockStatus As Integer = 0
    Public mSearchType As Integer = 0
    Private MoveActiveDateTime As DateTime

    Private Enum AxleShockStatus
        Axle = 1
        Shock = 2
    End Enum
    Private Enum eSearchType
        All = 0
        Incomplete = 1
        Completed = 2
    End Enum
    Private Sub clsVView_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, grdData.KeyUp ', btnExit.KeyUp, btnAll.KeyUp, btnIncomplete.KeyUp, btnCompleted.KeyUp
        clsCLogin.ActiveDateTime = Now
        MoveActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.Escape : ExitClick()
            Case Keys.D1 : ViewAll()
            Case Keys.D2 : ViewIncomplete()
            Case Keys.D3 : ViewCompleted()
        End Select
    End Sub
    Private Sub clsVView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click, grdData.Click, btnAll.Click, btnIncomplete.Click, btnCompleted.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnExit.Name : ExitClick()
                Case btnAll.Name : ViewAll()
                Case btnIncomplete.Name : ViewIncomplete()
                Case btnCompleted.Name : ViewCompleted()
            End Select
        End If
    End Sub
    Private Sub ViewAll()
        mSearchType = eSearchType.All
        ShowData()
    End Sub
    Private Sub ViewIncomplete()
        mSearchType = eSearchType.Incomplete
        ShowData()
    End Sub
    Private Sub ViewCompleted()
        mSearchType = eSearchType.Completed
        ShowData()
    End Sub

#Region "Call Function"
    Private Sub ExitClick()
        CloseForm()
    End Sub
#End Region

    Private Sub clsVView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mSearchType = eSearchType.All

            Dim col0 As New DataGridTextBoxColumn
            col0.MappingName = "Barcode"
            If mAxleShockStatus = AxleShockStatus.Axle Then
                col0.HeaderText = "Axle"
            Else
                col0.HeaderText = "Shock"
            End If
            col0.Width = 200

            Dim col1 As New DataGridTextBoxColumn
            col1.MappingName = "Completed"
            col1.HeaderText = "Completed"
            col1.Width = 110

            Dim col2 As New DataGridTextBoxColumn
            col2.MappingName = "Result1"
            col2.HeaderText = "1"
            col2.Width = 50

            Dim col3 As New DataGridTextBoxColumn
            col3.MappingName = "Result2"
            col3.HeaderText = "2"
            col3.Width = 50

            Dim col4 As New DataGridTextBoxColumn
            col4.MappingName = "Result3"
            col4.HeaderText = "3"
            col4.Width = 50

            Dim col5 As New DataGridTextBoxColumn
            col5.MappingName = "Result4"
            col5.HeaderText = "4"
            col5.Width = 50

            Dim col6 As New DataGridTextBoxColumn
            col6.MappingName = "Result5"
            col6.HeaderText = "5"
            col6.Width = 50

            Dim col7 As New DataGridTextBoxColumn
            col7.MappingName = "Result6"
            col7.HeaderText = "6"
            col7.Width = 50

            Dim col8 As New DataGridTextBoxColumn
            col8.MappingName = "Result7"
            col8.HeaderText = "7"
            col8.Width = 50

            Dim GridTBStyle As New DataGridTableStyle
            GridTBStyle.MappingName = "ScanView"

            With GridTBStyle.GridColumnStyles
                .Add(col0)
                .Add(col1)
                If mAxleShockStatus = AxleShockStatus.Axle Then
                    .Add(col2)
                    .Add(col3)
                    .Add(col4)
                    .Add(col5)
                Else
                    .Add(col6)
                    .Add(col7)
                    .Add(col8)
                End If
            End With
            grdData.TableStyles.Add(GridTBStyle)

            ShowData()

            Me.KeyPreview = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowData()
        Select Case mSearchType
            Case eSearchType.All
                btnAll.BackColor = Drawing.Color.Red
                btnIncomplete.BackColor = Drawing.Color.MistyRose
                btnCompleted.BackColor = Drawing.Color.MistyRose
            Case eSearchType.Incomplete
                btnAll.BackColor = Drawing.Color.MistyRose
                btnIncomplete.BackColor = Drawing.Color.Red
                btnCompleted.BackColor = Drawing.Color.MistyRose
            Case eSearchType.Completed
                btnAll.BackColor = Drawing.Color.MistyRose
                btnIncomplete.BackColor = Drawing.Color.MistyRose
                btnCompleted.BackColor = Drawing.Color.Red
        End Select
        dtGrid = clsCView.GetData(mAxleShockStatus, mSearchType)
        dtGrid.TableName = "ScanView"
        grdData.DataSource = dtGrid

        txtTotal.Text = dtGrid.Rows.Count.ToString
    End Sub

    Private Sub CloseForm()
        Me.Close()
    End Sub
End Class