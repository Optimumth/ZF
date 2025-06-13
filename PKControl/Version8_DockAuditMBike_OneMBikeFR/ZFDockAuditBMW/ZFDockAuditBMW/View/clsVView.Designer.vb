<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVView
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
        Me.pnButton = New System.Windows.Forms.Panel
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.pnTop = New System.Windows.Forms.Panel
        Me.grdData = New System.Windows.Forms.DataGrid
        Me.btnAll = New System.Windows.Forms.Button
        Me.btnIncomplete = New System.Windows.Forms.Button
        Me.btnCompleted = New System.Windows.Forms.Button
        Me.pnButton.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnButton
        '
        Me.pnButton.BackColor = System.Drawing.Color.PaleGreen
        Me.pnButton.Controls.Add(Me.txtTotal)
        Me.pnButton.Controls.Add(Me.Label2)
        Me.pnButton.Controls.Add(Me.btnExit)
        Me.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnButton.Location = New System.Drawing.Point(0, 204)
        Me.pnButton.Name = "pnButton"
        Me.pnButton.Size = New System.Drawing.Size(238, 43)
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(48, 11)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(52, 23)
        Me.txtTotal.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 23)
        Me.Label2.Text = "Total"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(156, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Back (Esc)"
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.Color.PaleGreen
        Me.pnTop.Controls.Add(Me.btnCompleted)
        Me.pnTop.Controls.Add(Me.btnIncomplete)
        Me.pnTop.Controls.Add(Me.btnAll)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(238, 37)
        '
        'grdData
        '
        Me.grdData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.Location = New System.Drawing.Point(0, 37)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(238, 167)
        Me.grdData.TabIndex = 3
        '
        'btnAll
        '
        Me.btnAll.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAll.BackColor = System.Drawing.Color.Red
        Me.btnAll.Location = New System.Drawing.Point(3, 3)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(37, 30)
        Me.btnAll.TabIndex = 6
        Me.btnAll.Text = "1. All"
        '
        'btnIncomplete
        '
        Me.btnIncomplete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnIncomplete.BackColor = System.Drawing.Color.MistyRose
        Me.btnIncomplete.Location = New System.Drawing.Point(41, 3)
        Me.btnIncomplete.Name = "btnIncomplete"
        Me.btnIncomplete.Size = New System.Drawing.Size(97, 30)
        Me.btnIncomplete.TabIndex = 7
        Me.btnIncomplete.Text = "2. Incomplete"
        '
        'btnCompleted
        '
        Me.btnCompleted.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCompleted.BackColor = System.Drawing.Color.MistyRose
        Me.btnCompleted.Location = New System.Drawing.Point(139, 3)
        Me.btnCompleted.Name = "btnCompleted"
        Me.btnCompleted.Size = New System.Drawing.Size(96, 30)
        Me.btnCompleted.TabIndex = 8
        Me.btnCompleted.Text = "3. Completed"
        '
        'clsVView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.pnTop)
        Me.Controls.Add(Me.pnButton)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "clsVView"
        Me.Text = "Review Axle / Shock"
        Me.pnButton.ResumeLayout(False)
        Me.pnTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnButton As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents grdData As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnCompleted As System.Windows.Forms.Button
    Friend WithEvents btnIncomplete As System.Windows.Forms.Button
    Friend WithEvents btnAll As System.Windows.Forms.Button
End Class
