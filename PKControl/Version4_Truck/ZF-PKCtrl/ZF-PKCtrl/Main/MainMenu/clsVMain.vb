Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class clsVMain
#Region "Program Active"
    Private Sub clsVMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, btnScan.KeyUp, btnReview.KeyUp, btnSync.KeyUp, btnMaintenance.KeyUp, btnExit.KeyUp
        clsCLogin.ActiveDateTime = Now
        Select Case e.KeyCode
            Case Keys.D1 : ScanClick()
            Case Keys.D2 : ReviewClick()
            Case Keys.D3 : SyncClick()
            Case Keys.D4 : MaintenanceClick()
            Case Keys.Escape : ExitClick()
        End Select
    End Sub
    Private Sub clsVMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnScan.Click, btnReview.Click, btnSync.Click, btnMaintenance.Click, btnExit.Click
        clsCLogin.ActiveDateTime = Now
        If sender.ToString = "System.Windows.Forms.Button" Then
            Dim btn As Button = CType(sender, Button)
            Select Case btn.Name
                Case btnScan.Name : ScanClick()
                Case btnReview.Name : ReviewClick()
                Case btnSync.Name : SyncClick()
                Case btnMaintenance.Name : MaintenanceClick()
                Case btnExit.Name : ExitClick()
            End Select
        End If
    End Sub
    Private Sub ActiveTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ActiveTimer.Tick
        If clsCLogin.CheckActive = True Then Exit Sub

        ActiveTimer.Enabled = False
        If clsCLogin.ReLogin = True Then
            clsCLogin.ActiveDateTime = Now
        Else
            Application.Exit()
        End If
        ActiveTimer.Enabled = True
    End Sub
#End Region

    Private Sub clsVMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActiveTimer.Enabled = False
        Dim frmLogin As New clsVLogin
        frmLogin.WindowState = FormWindowState.Normal
        If frmLogin.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Application.Exit()
        End If
        ActiveTimer.Enabled = True
        clsCLogin.ActiveDateTime = Now
    End Sub

#Region "Call Function"
    Private Sub ScanClick()
        Dim frm As New clsVScanMenu
        frm.ShowDialog()
    End Sub

    Private Sub ReviewClick()
        Dim frm As New clsVViewMenu
        frm.ShowDialog()
    End Sub

    Private Sub SyncClick()
        If clsCMain.chkTruck = True Then
            Dim frm As New clsVRackSync
            frm.ShowDialog()
        Else
            MsgBox("Please entry TruckID")
        End If
    End Sub

    Private Sub MaintenanceClick()
        Dim frm As New clsVMaintenanceMenu
        frm.ShowDialog()
    End Sub

    Private Sub ExitClick()
        Me.Close()
    End Sub
#End Region
    
End Class


Namespace SingleInstance

    Public Class Program
        Private Const ERROR_ALREADY_EXISTS As Integer = 183
        <DllImport("coredll.dll", SetLastError:=True)> _
        Private Shared Function CreateEvent(ByVal lpEventAttributes As IntPtr, ByVal bManualReset As Boolean, ByVal bInitialState As Boolean, ByVal lpName As String) As IntPtr
        End Function
        <DllImport("coredll.dll", SetLastError:=True)> _
         Private Shared Function CloseHandle(ByVal hObject As IntPtr) As Boolean
        End Function

        <DllImport("coredll.dll", SetLastError:=True)> _
        Private Shared Function FindWindow(ByVal className As String, ByVal wndName As String) As IntPtr
        End Function

        Public Shared Sub Main(ByVal commandLineArg() As String)
            Try

                Dim conn As New Conn
                conn.ConnectDBWinCE()

            Catch ex As Exception
                MessageBox.Show("Connection Database Fail.")
            End Try

            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
            Dim handle As IntPtr = CreateEvent(IntPtr.Zero, False, False, path)
            Dim Err As Integer = System.Runtime.InteropServices.Marshal.GetLastWin32Error()
            If (handle <> 0 And (Err <> ERROR_ALREADY_EXISTS)) Then


                Application.Run(New clsVMain())
            Else

                Dim hWnd As IntPtr = FindWindow("#NETCF_AGL_PARK_" + path, String.Empty)
                If (hWnd <> IntPtr.Zero) Then

                    Dim msg As Microsoft.WindowsCE.Forms.Message = Microsoft.WindowsCE.Forms.Message.Create(hWnd, 0, 0, 0)
                    Microsoft.WindowsCE.Forms.MessageWindow.SendMessage(msg)
                    CloseHandle(handle)
                End If
            End If
        End Sub
    End Class
End Namespace