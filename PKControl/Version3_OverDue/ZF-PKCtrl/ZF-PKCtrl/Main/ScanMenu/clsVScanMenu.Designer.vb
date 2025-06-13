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
        Me.btnExtWH = New System.Windows.Forms.Button
        Me.btnSup = New System.Windows.Forms.Button
        Me.btnMB = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnExtWH
        '
        Me.btnExtWH.BackColor = System.Drawing.Color.PaleGreen
        Me.btnExtWH.Location = New System.Drawing.Point(29, 103)
        Me.btnExtWH.Name = "btnExtWH"
        Me.btnExtWH.Size = New System.Drawing.Size(190, 37)
        Me.btnExtWH.TabIndex = 2
        Me.btnExtWH.Text = "3. Ext WH"
        '
        'btnSup
        '
        Me.btnSup.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSup.Location = New System.Drawing.Point(29, 59)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(190, 37)
        Me.btnSup.TabIndex = 1
        Me.btnSup.Text = "2. Supplier"
        '
        'btnMB
        '
        Me.btnMB.BackColor = System.Drawing.Color.PaleGreen
        Me.btnMB.Location = New System.Drawing.Point(29, 15)
        Me.btnMB.Name = "btnMB"
        Me.btnMB.Size = New System.Drawing.Size(190, 37)
        Me.btnMB.TabIndex = 0
        Me.btnMB.Text = "1. MB"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(29, 193)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(190, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Back to Main (Esc)"
        '
        'clsVScanMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExtWH)
        Me.Controls.Add(Me.btnSup)
        Me.Controls.Add(Me.btnMB)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "clsVScanMenu"
        Me.Text = "Scan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExtWH As System.Windows.Forms.Button
    Friend WithEvents btnSup As System.Windows.Forms.Button
    Friend WithEvents btnMB As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
