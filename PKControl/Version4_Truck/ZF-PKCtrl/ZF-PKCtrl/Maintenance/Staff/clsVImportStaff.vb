Imports System.IO
Imports System.Data
Imports ZF_PKCtrl.Barcode_System
Imports System.Windows.Forms

Public Class clsVImportStaff
    Private InterfacePath As String = ""

#Region "Program Active"
    Private Sub clsVImportStaff_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, txtStatus.KeyUp, btnExit.KeyUp, btnSave.KeyUp
        clsCLogin.ActiveDateTime = Now

        Select Case e.KeyCode
            Case Keys.F4 : SaveClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVImportStaff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnExit.Click, btnSave.Click
        clsCLogin.ActiveDateTime = Now

        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnSave.Name : SaveClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
#End Region

#Region "Call Function"
    Private Sub SaveClick()
        If DownloadMaster() = True Then
            txtStatus.Text = "Finished"
        End If
    End Sub
    Private Sub ExitClick()
        Me.Close()
    End Sub
#End Region

    Private Sub clsVImportStaff_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InterfacePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName().CodeBase) & "\Interface\"
    End Sub
    Private Function DownloadMaster() As Boolean
        txtStatus.Text = "Start Import"

        P_DB.beginTransCE()
        Try
            If P_DB.runSQLCE("delete from MstStaff") = False Then
                Return False
                Exit Function
            End If

            Dim SourcePath As String = InterfacePath & "\Staff"
            Dim DestinationPath As String = SourcePath & "\BK"
            Dim MstFileName As String = "\Staff.txt"
            Dim Cmd As New FileStream(SourcePath & MstFileName, FileMode.Open, FileAccess.Read)
            Dim CmdR As New StreamReader(Cmd)

            Do
                Dim Line As String = ""
                Dim Lines() As String

                Line = CmdR.ReadLine
                Lines = Strings.Split(Line, "|")

                If Lines.Length = 1 Then
                    Dim sql As String = "insert into MstStaff (StaffCode)"
                    sql &= " select '" & Lines(0) & "'"

                    If P_DB.runSQLCE(sql) = False Then
                        Return False
                        Exit Function
                    End If
                End If

            Loop Until CmdR.Peek = -1

            P_DB.commitTransCE()
            Cmd.Close()

            If File.Exists(DestinationPath & MstFileName) = True Then
                File.Delete(DestinationPath & MstFileName)
            End If
            File.Move(SourcePath & MstFileName, DestinationPath & MstFileName)

            Return True
            Exit Function
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            P_DB.rollbackTransCE()
            Return False
            Exit Function
        End Try
    End Function

    
End Class