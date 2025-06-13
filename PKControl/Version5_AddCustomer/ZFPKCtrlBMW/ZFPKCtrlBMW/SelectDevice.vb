Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Threading
Imports System.Runtime.InteropServices
Imports Symbol

Namespace ZFPKCtrl
    ''' <summary>
    ''' The SelectDevice class provides a dialog for displaying and selecting a
    ''' list of available Symbol.Barcode2.Device objects.
    ''' </summary>
    ''' <remarks>
    ''' A SelectDevice dialog is displayed with the list of device choices 
    ''' and the user selects one of them to be accessed.
    ''' </remarks>
    Public Class SelectDevice
        Inherits System.Windows.Forms.Form
        Private WithEvents CancelButton As System.Windows.Forms.Button
        Private AvailableDevicesListBox As System.Windows.Forms.ListBox
        Private AvailableDevicesLabel As System.Windows.Forms.Label
        Private mainMenu1 As System.Windows.Forms.MainMenu
        Private WithEvents OKButton As System.Windows.Forms.Button
        Private MySelection As Integer = -1

        Private Shared OurAvailableDevices() As Symbol.Barcode2.Device = Nothing
        Private Shared OurTitle As String
        Private Shared DefaultIndex As Integer

        Private Shared bPortrait As Boolean = True ' The default dispaly orientation
        ' has been set to Portrait.

        Private bSkipMaxLen As Boolean = False ' The restriction on the maximum
        ' physical length is considered by default.

        Private bInitialScale As Boolean = True ' The flag to track whether the
        ' scaling logic is applied for
        ' the first time (from scatch) or not.
        ' Based on that, the (outer) width/height values
        ' of the form will be set or not.
        ' Initially set to true.

        Private resWidthReference As Integer = 248 ' The (cached) width of the form.
        ' INITIALLY HAS TO BE SET TO THE WIDTH OF THE FORM AT DESIGN TIME (IN PIXELS).
        ' This setting is also obtained from the platform only on
        ' Windows CE devices before running the application on the device, as a verification.
        ' For PocketPC (& Windows Mobile) devices, the failure to set this properly may result in the distortion of GUI/viewability.

        Private resHeightReference As Integer = 289 ' The (cached) height of the form.
        ' INITIALLY HAS TO BE SET TO THE HEIGHT OF THE FORM AT DESIGN TIME (IN PIXELS).
        ' This setting is also obtained from the platform only on
        ' Windows CE devices before running the application on the device, as a verification.
        ' For PocketPC (& Windows Mobile) devices, the failure to set this properly may result in the distortion of GUI/viewability.

        Private Const maxLength As Double = 4 ' The maximum physical width/height of the sample (in inches).
        ' The actual value on the device may slightly deviate from this
        ' since the calculations based on the (received) DPI & resolution values 
        ' would provide only an approximation, so not 100% accurate.


        ''' <summary>
        ''' This function does the (initial) scaling of the form
        ''' by re-setting the related parameters (if required) and
        ''' then calling the Scale(...) internally. 
        ''' </summary>
        ''' 
        Public Sub DoScale()
            If Screen.PrimaryScreen.Bounds.Width > Screen.PrimaryScreen.Bounds.Height Then
                bPortrait = False ' If the display orientation is not portrait (so it's landscape), set the flag to false.
            End If

            If Me.WindowState = FormWindowState.Maximized Then ' If the form is maximized by default.
                Me.bSkipMaxLen = True ' we need to skip the max. length restriction
            End If

            If (Symbol.Win32.PlatformType.IndexOf("WinCE") <> -1) OrElse (Symbol.Win32.PlatformType.IndexOf("WindowsCE") <> -1) OrElse (Symbol.Win32.PlatformType.IndexOf("Windows CE") <> -1) Then ' Only on Windows CE devices
                Me.resWidthReference = Me.Width ' The width of the form at design time (in pixels) is obtained from the platorm.
                Me.resHeightReference = Me.Height ' The height of the form at design time (in pixels) is obtained from the platform.
            End If

            Scale(Me) ' Initial scaling of the GUI
        End Sub

        ''' <summary>
        ''' This function scales the given Form and its child controls in order to
        ''' make them completely viewable, based on the screen width and height.
        ''' </summary>
        Private Overloads Shared Sub Scale(ByVal frm As SelectDevice)
            Dim PSWAW As Integer = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width ' The width of the working area (in pixels).
            Dim PSWAH As Integer = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height ' The height of the working area (in pixels).

            ' The entire screen has been taken in to account below 
            ' in order to decide the half (S)VGA settings etc.
            If Not ((Screen.PrimaryScreen.Bounds.Width <= (1.5) * (Screen.PrimaryScreen.Bounds.Height)) AndAlso (Screen.PrimaryScreen.Bounds.Height <= (1.5) * (Screen.PrimaryScreen.Bounds.Width))) Then
                If (Screen.PrimaryScreen.Bounds.Width) > (Screen.PrimaryScreen.Bounds.Height) Then
                    PSWAW = CInt(Fix((1.33) * PSWAH)) ' If the width/height ratio goes beyond 1.5,
                    ' the (longer) effective width is made shorter.
                End If

            End If

            Dim dpiX As Single = GetDPIX() ' Get the horizontal DPI value.

            If frm.bInitialScale = True Then ' If an initial scale (from scratch)
                If Symbol.Win32.PlatformType.IndexOf("PocketPC") <> -1 Then ' If the platform is either Pocket PC or Windows Mobile
                    frm.Width = PSWAW ' Set the form width. However this setting
                    ' would be the ultimate one for Pocket PC (& Windows Mobile)devices.
                    ' Just for the sake of consistency, it's explicitely specified here.
                Else
                    frm.Width = CInt(Fix((frm.Width) * (PSWAW))) / (frm.resWidthReference) ' Set the form width for others (Windows CE devices).

                End If
            End If
            If (frm.Width <= maxLength * dpiX) OrElse frm.bSkipMaxLen = True Then ' The calculation of the width & left values for each control
                ' without taking the maximum length restriction into consideration.
                For Each cntrl As System.Windows.Forms.Control In frm.Controls
                    cntrl.Width = ((cntrl.Width) * (frm.Width)) / (frm.resWidthReference)
                    cntrl.Left = ((cntrl.Left) * (frm.Width)) / (frm.resWidthReference)

                    If TypeOf cntrl Is System.Windows.Forms.TabControl Then
                        For Each tabPg As System.Windows.Forms.TabPage In cntrl.Controls
                            For Each cntrl2 As System.Windows.Forms.Control In tabPg.Controls
                                cntrl2.Width = (((cntrl2.Width) * (frm.Width)) / (frm.resWidthReference))
                                cntrl2.Left = (((cntrl2.Left) * (frm.Width)) / (frm.resWidthReference))
                            Next cntrl2
                        Next tabPg
                    End If
                Next cntrl

            Else
                ' with the maximum length restriction taken into consideration.
                For Each cntrl As System.Windows.Forms.Control In frm.Controls
                    cntrl.Width = CInt(Fix(((cntrl.Width) * (PSWAW) * (maxLength * dpiX)) / (frm.resWidthReference * (frm.Width))))
                    cntrl.Left = CInt(Fix(((cntrl.Left) * (PSWAW) * (maxLength * dpiX)) / (frm.resWidthReference * (frm.Width))))

                    If TypeOf cntrl Is System.Windows.Forms.TabControl Then
                        For Each tabPg As System.Windows.Forms.TabPage In cntrl.Controls
                            For Each cntrl2 As System.Windows.Forms.Control In tabPg.Controls
                                cntrl2.Width = CInt(Fix(((cntrl2.Width) * (PSWAW) * (maxLength * dpiX)) / (frm.resWidthReference * (frm.Width))))
                                cntrl2.Left = CInt(Fix(((cntrl2.Left) * (PSWAW) * (maxLength * dpiX)) / (frm.resWidthReference * (frm.Width))))
                            Next cntrl2
                        Next tabPg
                    End If
                Next cntrl

                frm.Width = CInt(Fix((frm.Width) * (maxLength * dpiX))) / (frm.Width)

            End If

            frm.resWidthReference = frm.Width ' Set the reference width to the new value.


            ' A similar calculation is performed below for the height & top values for each control ...

            If Not ((Screen.PrimaryScreen.Bounds.Width <= (1.5) * (Screen.PrimaryScreen.Bounds.Height)) AndAlso (Screen.PrimaryScreen.Bounds.Height <= (1.5) * (Screen.PrimaryScreen.Bounds.Width))) Then
                If (Screen.PrimaryScreen.Bounds.Height) > (Screen.PrimaryScreen.Bounds.Width) Then
                    PSWAH = CInt(Fix((1.33) * PSWAW))
                End If

            End If

            Dim dpiY As Single = GetDPIY()

            If frm.bInitialScale = True Then
                If Symbol.Win32.PlatformType.IndexOf("PocketPC") <> -1 Then
                    frm.Height = PSWAH
                Else
                    frm.Height = CInt(Fix((frm.Height) * (PSWAH))) / (frm.resHeightReference)

                End If
            End If

            If (frm.Height <= maxLength * dpiY) OrElse frm.bSkipMaxLen = True Then
                For Each cntrl As System.Windows.Forms.Control In frm.Controls

                    cntrl.Height = ((cntrl.Height) * (frm.Height)) / (frm.resHeightReference)
                    cntrl.Top = ((cntrl.Top) * (frm.Height)) / (frm.resHeightReference)


                    If TypeOf cntrl Is System.Windows.Forms.TabControl Then
                        For Each tabPg As System.Windows.Forms.TabPage In cntrl.Controls
                            For Each cntrl2 As System.Windows.Forms.Control In tabPg.Controls
                                cntrl2.Height = ((cntrl2.Height) * (frm.Height)) / (frm.resHeightReference)
                                cntrl2.Top = ((cntrl2.Top) * (frm.Height)) / (frm.resHeightReference)
                            Next cntrl2
                        Next tabPg
                    End If

                Next cntrl

            Else
                For Each cntrl As System.Windows.Forms.Control In frm.Controls

                    cntrl.Height = CInt(Fix(((cntrl.Height) * (PSWAH) * (maxLength * dpiY)) / (frm.resHeightReference * (frm.Height))))
                    cntrl.Top = CInt(Fix(((cntrl.Top) * (PSWAH) * (maxLength * dpiY)) / (frm.resHeightReference * (frm.Height))))


                    If TypeOf cntrl Is System.Windows.Forms.TabControl Then
                        For Each tabPg As System.Windows.Forms.TabPage In cntrl.Controls
                            For Each cntrl2 As System.Windows.Forms.Control In tabPg.Controls
                                cntrl2.Height = CInt(Fix(((cntrl2.Height) * (PSWAH) * (maxLength * dpiY)) / (frm.resHeightReference * (frm.Height))))
                                cntrl2.Top = CInt(Fix(((cntrl2.Top) * (PSWAH) * (maxLength * dpiY)) / (frm.resHeightReference * (frm.Height))))
                            Next cntrl2
                        Next tabPg
                    End If

                Next cntrl

                frm.Height = CInt(Fix((frm.Height) * (maxLength * dpiY))) / (frm.Height)

            End If

            frm.resHeightReference = frm.Height

            If frm.bInitialScale = True Then
                frm.bInitialScale = False ' If this was the initial scaling (from scratch), it's now complete.
            End If
            If frm.bSkipMaxLen = True Then
                frm.bSkipMaxLen = False ' No need to consider the maximum length restriction now.
            End If


        End Sub


        ' DPI values have to be taken via PInvokes on VS2003/CF1.0. The 2 proerties, System.Drawing.Graphics.DpiX
        ' & System.Drawing.Graphics.DpiY, are not supported by VS2003/CF1.0.

        ' For DpiX
        Private Shared Function GetDPIX() As Single
            Dim hwnd As IntPtr = CType(GetCapture(), IntPtr)

            Dim dpiX As Single = GetDeviceCaps(hwnd, 88) ' 88 for DPIX value

            Return dpiX

        End Function

        ' For DpiY
        Private Shared Function GetDPIY() As Single
            Dim hwnd As IntPtr = CType(GetCapture(), IntPtr)

            Dim dpiY As Single = GetDeviceCaps(hwnd, 90) ' 90 for DPIY value

            Return dpiY

        End Function


        ''' <summary>
        ''' The static Select method is the recommended way to create the SelectDevice
        ''' dialog.
        ''' </summary>
        ''' <remarks>
        ''' This method will display the SelectDevice dialog and block until a 
        ''' selection has been made.
        ''' </remarks>
        ''' <param name="Title">A string that will be displayed as the title to the
        ''' SelectDevice dialog.</param>
        ''' <param name="AvailableDevices">An array of available Symbol.Device objects.
        ''' </param>
        ''' <returns>The selected device object.</returns>
        Public Overloads Shared Function [Select](ByVal Title As String, ByVal AvailableDevices() As Symbol.Barcode2.Device) As Symbol.Barcode2.Device
            OurAvailableDevices = AvailableDevices

            If OurAvailableDevices.Length = 0 Then
                Return Nothing
            End If

            If OurAvailableDevices.Length = 1 Then
                Return OurAvailableDevices(0)
            End If

            OurTitle = Title
            DefaultIndex = 0

            Dim nSelection As Integer = New SelectDevice().Selection

            If nSelection < 0 Then
                Return Nothing
            End If

            Return OurAvailableDevices(nSelection)
        End Function

        ''' <summary>
        ''' The static Select method is the recommended way to create the SelectDevice
        ''' dialog.
        ''' </summary>
        ''' <remarks>
        ''' This method will display the SelectDevice dialog and block until a 
        ''' selection has been made.
        ''' </remarks>
        ''' <param name="Title">A string that will be displayed as the title to the
        ''' SelectDevice dialog.</param>
        ''' <param name="AvailableDevices">An array of available Symbol.Device objects.
        ''' </param>
        ''' <param name="SelectIndex">The index of the initially selected device
        ''' object.</param>
        ''' <returns>The selected device object.</returns>
        Public Overloads Shared Function [Select](ByVal Title As String, ByVal AvailableDevices() As Symbol.Barcode2.Device, ByVal SelectIndex As Integer) As Symbol.Barcode2.Device
            OurAvailableDevices = AvailableDevices

            If OurAvailableDevices.Length = 0 Then
                Return Nothing
            End If

            If OurAvailableDevices.Length = 1 Then
                Return OurAvailableDevices(0)
            End If

            OurTitle = Title
            DefaultIndex = SelectIndex

            Dim nSelection As Integer = New SelectDevice().Selection

            If nSelection < 0 Then
                Return Nothing
            End If

            Return OurAvailableDevices(nSelection)
        End Function

        ''' <summary>
        ''' Default SelectDevice constructor.
        ''' </summary>
        Friend Sub New()
            InitializeComponent()
            Me.DoScale()
            Me.OKButton.Focus()
        End Sub


#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.CancelButton = New System.Windows.Forms.Button
            Me.OKButton = New System.Windows.Forms.Button
            Me.AvailableDevicesListBox = New System.Windows.Forms.ListBox
            Me.AvailableDevicesLabel = New System.Windows.Forms.Label
            Me.mainMenu1 = New System.Windows.Forms.MainMenu
            Me.SuspendLayout()
            '
            'CancelButton
            '
            Me.CancelButton.Location = New System.Drawing.Point(8, 232)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(64, 25)
            Me.CancelButton.TabIndex = 2
            Me.CancelButton.Text = "Cancel"
            '
            'OKButton
            '
            Me.OKButton.Location = New System.Drawing.Point(168, 232)
            Me.OKButton.Name = "OKButton"
            Me.OKButton.Size = New System.Drawing.Size(64, 25)
            Me.OKButton.TabIndex = 3
            Me.OKButton.Text = "OK"
            '
            'AvailableDevicesListBox
            '
            Me.AvailableDevicesListBox.Location = New System.Drawing.Point(8, 40)
            Me.AvailableDevicesListBox.Name = "AvailableDevicesListBox"
            Me.AvailableDevicesListBox.Size = New System.Drawing.Size(224, 170)
            Me.AvailableDevicesListBox.TabIndex = 1
            '
            'AvailableDevicesLabel
            '
            Me.AvailableDevicesLabel.Location = New System.Drawing.Point(8, 8)
            Me.AvailableDevicesLabel.Name = "AvailableDevicesLabel"
            Me.AvailableDevicesLabel.Size = New System.Drawing.Size(224, 24)
            Me.AvailableDevicesLabel.Text = "Available Devices:"
            '
            'SelectDevice
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.ClientSize = New System.Drawing.Size(242, 264)
            Me.Controls.Add(Me.AvailableDevicesLabel)
            Me.Controls.Add(Me.AvailableDevicesListBox)
            Me.Controls.Add(Me.CancelButton)
            Me.Controls.Add(Me.OKButton)
            Me.Menu = Me.mainMenu1
            Me.Name = "SelectDevice"
            Me.Text = "Select"
            Me.ResumeLayout(False)

        End Sub
#End Region


        ' Private: SelectDevice_Load
        Private Sub SelectDevice_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            '// Set wait cursor.
            'bool SaveWaitCursor = Symbol.Win32.WaitCursor;
            'Symbol.Win32.WaitCursor = true;

            Try

                Me.AvailableDevicesListBox.Hide()

                For Each d As Symbol.Barcode2.Device In OurAvailableDevices

                    If d.DeviceType <> Symbol.Barcode2.DEVICETYPES.UNKNOWN Then
                        Me.AvailableDevicesListBox.Items.Add(d.DeviceType.ToString() & " - " & d.FriendlyName)
                    Else
                        Me.AvailableDevicesListBox.Items.Add(d.FriendlyName)
                    End If
                Next d

                Me.AvailableDevicesListBox.SelectedIndex = 0
                Me.AvailableDevicesListBox.Show()
                AddHandler KeyDown, AddressOf SelectDevice_KeyDown

                ' Add MainMenu if Pocket PC
                If Symbol.Win32.PlatformType.IndexOf("PocketPC") <> -1 Then
                    Me.Menu = New MainMenu()
                End If

            Finally
                ' restore wait cursor
                'Symbol.Win32.WaitCursor = SaveWaitCursor;
            End Try
        End Sub

        ' Private: Selection
        Private ReadOnly Property Selection() As Integer
            Get
                Me.AvailableDevicesLabel.Text = "Select " & OurTitle & ":"
                Me.ShowDialog()
                Return MySelection
            End Get
        End Property

        ' Private: OKButton_Click
        Private Sub OKButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OKButton.Click
            MySelection = AvailableDevicesListBox.SelectedIndex

            Me.Close()
        End Sub

        ' Private: CancelButton_Click
        Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelButton.Click
            MySelection = -1
            Me.Close()
        End Sub

        Private Sub OKButton_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles OKButton.KeyDown
            ' Checks if the key pressed was an enter button (character code 13)
            If e.KeyValue = 13 Then
                OKButton_Click(Me, e)
            End If
        End Sub

        Private Sub CancelButton_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles CancelButton.KeyDown
            ' Checks if the key pressed was an enter button (character code 13)
            If e.KeyValue = 13 Then
                CancelButton_Click(Me, e)
            End If
        End Sub

        Private Sub SelectDevice_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyUp
            Me.OKButton.Focus()
        End Sub

        ' Private: SelectDevice_KeyDown
        Private Sub SelectDevice_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Select Case e.KeyCode
                Case Keys.Enter
                    Me.OKButton_Click(Me, EventArgs.Empty)
                    Return
                Case Keys.Up
                    If Me.AvailableDevicesListBox.SelectedIndex > 0 Then
                        Me.AvailableDevicesListBox.SelectedIndex -= 1
                    End If
                    Return
                Case Keys.Down
                    If Me.AvailableDevicesListBox.SelectedIndex < Me.AvailableDevicesListBox.Items.Count - 1 Then
                        Me.AvailableDevicesListBox.SelectedIndex += 1
                    End If
                    Return
            End Select
        End Sub

        Private Sub SelectDevice_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
            If bInitialScale = True Then
                Return ' Return if the initial scaling (from scratch)is not complete.
            End If

            If Screen.PrimaryScreen.Bounds.Width > Screen.PrimaryScreen.Bounds.Height Then ' If landscape orientation
                If bPortrait <> False Then ' If an orientation change has occured to landscape
                    bPortrait = False ' Set the orientation flag accordingly.
                    bInitialScale = True ' An initial scaling is required due to orientation change.
                    Scale(Me) ' Scale the GUI.
                Else
                    bSkipMaxLen = True ' Initial scaling is now complete, so skipping the max. length restriction is now possible.
                    Scale(Me) ' Scale the GUI.
                End If
            Else
                ' Similarly for the portrait orientation...
                If bPortrait <> True Then
                    bPortrait = True
                    bInitialScale = True
                    Scale(Me)
                Else
                    bSkipMaxLen = True
                    Scale(Me)
                End If
            End If
        End Sub

        <DllImport("coredll.dll")> _
        Friend Shared Function GetDeviceCaps(ByVal hdc As IntPtr, ByVal index As Int32) As Int32
        End Function

        <DllImport("coredll.dll")> _
        Friend Shared Function GetCapture() As Int32
        End Function
    End Class
End Namespace
