Imports System.IO
Imports System.IO.Ports
Imports System.Text


Public Class clsVLoad
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim cls As New clsCLoad
        cls.LoadIni()
        Me.Close()
    End Sub
End Class
