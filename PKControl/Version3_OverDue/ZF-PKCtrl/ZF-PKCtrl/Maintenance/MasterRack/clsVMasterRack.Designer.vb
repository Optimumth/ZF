<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVMasterRack
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.Text = "Receiving Master Rack"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(156, 207)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 37)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Close (F4)"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'clsVMasterRack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "clsVMasterRack"
        Me.Text = "Master Rack"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
