<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVViewMenu
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
        Me.btnAll = New System.Windows.Forms.Button
        Me.btnRepairInZF = New System.Windows.Forms.Button
        Me.btnFG = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnExtWH
        '
        Me.btnExtWH.BackColor = System.Drawing.Color.MistyRose
        Me.btnExtWH.Location = New System.Drawing.Point(29, 58)
        Me.btnExtWH.Name = "btnExtWH"
        Me.btnExtWH.Size = New System.Drawing.Size(90, 37)
        Me.btnExtWH.TabIndex = 2
        Me.btnExtWH.Text = "3. Ext WH"
        '
        'btnSup
        '
        Me.btnSup.BackColor = System.Drawing.Color.MistyRose
        Me.btnSup.Location = New System.Drawing.Point(129, 15)
        Me.btnSup.Name = "btnSup"
        Me.btnSup.Size = New System.Drawing.Size(90, 37)
        Me.btnSup.TabIndex = 1
        Me.btnSup.Text = "2. Supplier"
        '
        'btnMB
        '
        Me.btnMB.BackColor = System.Drawing.Color.MistyRose
        Me.btnMB.Location = New System.Drawing.Point(29, 15)
        Me.btnMB.Name = "btnMB"
        Me.btnMB.Size = New System.Drawing.Size(90, 37)
        Me.btnMB.TabIndex = 0
        Me.btnMB.Text = "1. BMW"
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
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.MistyRose
        Me.btnAll.Location = New System.Drawing.Point(29, 144)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(190, 37)
        Me.btnAll.TabIndex = 3
        Me.btnAll.Text = "6. Review - All Status"
        '
        'btnRepairInZF
        '
        Me.btnRepairInZF.BackColor = System.Drawing.Color.MistyRose
        Me.btnRepairInZF.Location = New System.Drawing.Point(129, 58)
        Me.btnRepairInZF.Name = "btnRepairInZF"
        Me.btnRepairInZF.Size = New System.Drawing.Size(90, 37)
        Me.btnRepairInZF.TabIndex = 1
        Me.btnRepairInZF.Text = "4. ZF Repair"
        '
        'btnFG
        '
        Me.btnFG.BackColor = System.Drawing.Color.MistyRose
        Me.btnFG.Location = New System.Drawing.Point(29, 101)
        Me.btnFG.Name = "btnFG"
        Me.btnFG.Size = New System.Drawing.Size(190, 37)
        Me.btnFG.TabIndex = 1
        Me.btnFG.Text = "5. FG"
        '
        'clsVViewMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExtWH)
        Me.Controls.Add(Me.btnFG)
        Me.Controls.Add(Me.btnRepairInZF)
        Me.Controls.Add(Me.btnSup)
        Me.Controls.Add(Me.btnMB)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "clsVViewMenu"
        Me.Text = "View"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExtWH As System.Windows.Forms.Button
    Friend WithEvents btnSup As System.Windows.Forms.Button
    Friend WithEvents btnMB As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents btnRepairInZF As System.Windows.Forms.Button
    Friend WithEvents btnFG As System.Windows.Forms.Button
End Class
