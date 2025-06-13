<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVScanMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnShock = New System.Windows.Forms.Button
        Me.btnAxle = New System.Windows.Forms.Button
        Me.ActiveTimer = New System.Windows.Forms.Timer
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(29, 193)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(190, 37)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Back to Main (Esc)"
        '
        'btnShock
        '
        Me.btnShock.BackColor = System.Drawing.Color.MistyRose
        Me.btnShock.Location = New System.Drawing.Point(29, 56)
        Me.btnShock.Name = "btnShock"
        Me.btnShock.Size = New System.Drawing.Size(190, 37)
        Me.btnShock.TabIndex = 3
        Me.btnShock.Text = "2. Shock"
        '
        'btnAxle
        '
        Me.btnAxle.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAxle.Location = New System.Drawing.Point(29, 15)
        Me.btnAxle.Name = "btnAxle"
        Me.btnAxle.Size = New System.Drawing.Size(190, 37)
        Me.btnAxle.TabIndex = 3
        Me.btnAxle.Text = "1. Axle"
        '
        'ActiveTimer
        '
        Me.ActiveTimer.Enabled = True
        Me.ActiveTimer.Interval = 5000
        '
        'clsVScanMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.btnAxle)
        Me.Controls.Add(Me.btnShock)
        Me.Controls.Add(Me.btnExit)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "clsVScanMenu"
        Me.Text = "Scan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnShock As System.Windows.Forms.Button
    Friend WithEvents btnAxle As System.Windows.Forms.Button
    Friend WithEvents ActiveTimer As System.Windows.Forms.Timer
End Class
