<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVTopMenu
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.btnScan = New System.Windows.Forms.Button
        Me.btnReview = New System.Windows.Forms.Button
        Me.ActiveTimer = New System.Windows.Forms.Timer
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(133, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 37)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit (Esc)"
        '
        'btnScan
        '
        Me.btnScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnScan.Location = New System.Drawing.Point(21, 10)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(190, 41)
        Me.btnScan.TabIndex = 0
        Me.btnScan.Text = "1. Rack Control"
        '
        'btnReview
        '
        Me.btnReview.Location = New System.Drawing.Point(21, 68)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(190, 41)
        Me.btnReview.TabIndex = 1
        Me.btnReview.Text = "2. Dock Audit"
        '
        'ActiveTimer
        '
        Me.ActiveTimer.Enabled = True
        Me.ActiveTimer.Interval = 5000
        '
        'clsVTopMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.btnReview)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.btnExit)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.Name = "clsVTopMenu"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents mainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents btnScan As System.Windows.Forms.Button
    Friend WithEvents btnReview As System.Windows.Forms.Button
    Friend WithEvents ActiveTimer As System.Windows.Forms.Timer
End Class
