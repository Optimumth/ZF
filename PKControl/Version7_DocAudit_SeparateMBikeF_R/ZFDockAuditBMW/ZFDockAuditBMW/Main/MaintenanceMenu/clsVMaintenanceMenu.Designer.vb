<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVMaintenanceMenu
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
        Me.btnConfig = New System.Windows.Forms.Button
        Me.btnImportMaster = New System.Windows.Forms.Button
        Me.ActiveTimer = New System.Windows.Forms.Timer
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(28, 197)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(190, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Back to Main (Esc)"
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnConfig.Location = New System.Drawing.Point(28, 20)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(190, 37)
        Me.btnConfig.TabIndex = 0
        Me.btnConfig.Text = "1. Configuration"
        '
        'btnImportMaster
        '
        Me.btnImportMaster.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnImportMaster.Location = New System.Drawing.Point(28, 64)
        Me.btnImportMaster.Name = "btnImportMaster"
        Me.btnImportMaster.Size = New System.Drawing.Size(190, 37)
        Me.btnImportMaster.TabIndex = 2
        Me.btnImportMaster.Text = "2. Import Master Data"
        '
        'ActiveTimer
        '
        Me.ActiveTimer.Enabled = True
        Me.ActiveTimer.Interval = 5000
        '
        'clsVMaintenanceMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.btnImportMaster)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.btnExit)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "clsVMaintenanceMenu"
        Me.Text = "Maintenance"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnConfig As System.Windows.Forms.Button
    Friend WithEvents btnImportMaster As System.Windows.Forms.Button
    Friend WithEvents ActiveTimer As System.Windows.Forms.Timer
End Class
