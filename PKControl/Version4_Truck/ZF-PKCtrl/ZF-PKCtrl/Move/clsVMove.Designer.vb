<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVMove
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
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.pnTop = New System.Windows.Forms.Panel
        Me.btnDelete = New System.Windows.Forms.Button
        Me.grdData = New System.Windows.Forms.DataGrid
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.pnButton.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnButton
        '
        Me.pnButton.BackColor = System.Drawing.Color.PaleGreen
        Me.pnButton.Controls.Add(Me.btnSave)
        Me.pnButton.Controls.Add(Me.btnExit)
        Me.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnButton.Location = New System.Drawing.Point(0, 199)
        Me.pnButton.Name = "pnButton"
        Me.pnButton.Size = New System.Drawing.Size(238, 48)
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.BackColor = System.Drawing.Color.Cyan
        Me.btnSave.Location = New System.Drawing.Point(6, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 37)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save (F4)"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(156, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 37)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Back (Esc)"
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.Color.PaleGreen
        Me.pnTop.Controls.Add(Me.btnDelete)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(238, 27)
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(176, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(59, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Del"
        '
        'grdData
        '
        Me.grdData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.Location = New System.Drawing.Point(0, 27)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(238, 172)
        Me.grdData.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'clsVMove
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
        Me.Name = "clsVMove"
        Me.Text = "clsVMove"
        Me.pnButton.ResumeLayout(False)
        Me.pnTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnButton As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents grdData As System.Windows.Forms.DataGrid
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
