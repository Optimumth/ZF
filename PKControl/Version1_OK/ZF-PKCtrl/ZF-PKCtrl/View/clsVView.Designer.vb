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
        Me.txtRackQty = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.pnTop = New System.Windows.Forms.Panel
        Me.btnSortD = New System.Windows.Forms.Button
        Me.btnSortA = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.grdData = New System.Windows.Forms.DataGrid
        Me.pnButton.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnButton
        '
        Me.pnButton.BackColor = System.Drawing.Color.MistyRose
        Me.pnButton.Controls.Add(Me.txtRackQty)
        Me.pnButton.Controls.Add(Me.Label1)
        Me.pnButton.Controls.Add(Me.btnExit)
        Me.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnButton.Location = New System.Drawing.Point(0, 199)
        Me.pnButton.Name = "pnButton"
        Me.pnButton.Size = New System.Drawing.Size(238, 48)
        '
        'txtRackQty
        '
        Me.txtRackQty.Location = New System.Drawing.Point(72, 13)
        Me.txtRackQty.Name = "txtRackQty"
        Me.txtRackQty.Size = New System.Drawing.Size(78, 23)
        Me.txtRackQty.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.Text = "Rack Qty"
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
        Me.pnTop.BackColor = System.Drawing.Color.MistyRose
        Me.pnTop.Controls.Add(Me.btnSortD)
        Me.pnTop.Controls.Add(Me.btnSortA)
        Me.pnTop.Controls.Add(Me.btnDelete)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(238, 27)
        '
        'btnSortD
        '
        Me.btnSortD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSortD.Location = New System.Drawing.Point(50, 1)
        Me.btnSortD.Name = "btnSortD"
        Me.btnSortD.Size = New System.Drawing.Size(41, 23)
        Me.btnSortD.TabIndex = 6
        Me.btnSortD.Text = "Z-A"
        '
        'btnSortA
        '
        Me.btnSortA.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSortA.Location = New System.Drawing.Point(3, 1)
        Me.btnSortA.Name = "btnSortA"
        Me.btnSortA.Size = New System.Drawing.Size(41, 23)
        Me.btnSortA.TabIndex = 5
        Me.btnSortA.Text = "A-Z"
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
        Me.Text = "Scan Review"
        Me.pnButton.ResumeLayout(False)
        Me.pnTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnButton As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents grdData As System.Windows.Forms.DataGrid
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtRackQty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSortD As System.Windows.Forms.Button
    Friend WithEvents btnSortA As System.Windows.Forms.Button
End Class
