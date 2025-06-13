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
        Me.txtTruckQty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRackQty = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.pnTop = New System.Windows.Forms.Panel
        Me.btnDeleteTruck = New System.Windows.Forms.Button
        Me.btnSortD = New System.Windows.Forms.Button
        Me.btnSortA = New System.Windows.Forms.Button
        Me.btnDeleteRack = New System.Windows.Forms.Button
        Me.grdData = New System.Windows.Forms.DataGrid
        Me.pnButton.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnButton
        '
        Me.pnButton.BackColor = System.Drawing.Color.MistyRose
        Me.pnButton.Controls.Add(Me.txtTruckQty)
        Me.pnButton.Controls.Add(Me.Label2)
        Me.pnButton.Controls.Add(Me.txtRackQty)
        Me.pnButton.Controls.Add(Me.Label1)
        Me.pnButton.Controls.Add(Me.btnExit)
        Me.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnButton.Location = New System.Drawing.Point(0, 179)
        Me.pnButton.Name = "pnButton"
        Me.pnButton.Size = New System.Drawing.Size(238, 68)
        '
        'txtTruckQty
        '
        Me.txtTruckQty.Location = New System.Drawing.Point(72, 38)
        Me.txtTruckQty.Name = "txtTruckQty"
        Me.txtTruckQty.Size = New System.Drawing.Size(78, 23)
        Me.txtTruckQty.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.Text = "Truck Qty"
        '
        'txtRackQty
        '
        Me.txtRackQty.Location = New System.Drawing.Point(72, 10)
        Me.txtRackQty.Name = "txtRackQty"
        Me.txtRackQty.Size = New System.Drawing.Size(78, 23)
        Me.txtRackQty.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.Text = "Rack Qty"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(156, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 51)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Back (Esc)"
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.Color.MistyRose
        Me.pnTop.Controls.Add(Me.btnDeleteTruck)
        Me.pnTop.Controls.Add(Me.btnSortD)
        Me.pnTop.Controls.Add(Me.btnSortA)
        Me.pnTop.Controls.Add(Me.btnDeleteRack)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(238, 27)
        '
        'btnDeleteTruck
        '
        Me.btnDeleteTruck.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDeleteTruck.BackColor = System.Drawing.Color.Blue
        Me.btnDeleteTruck.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.btnDeleteTruck.Location = New System.Drawing.Point(111, 1)
        Me.btnDeleteTruck.Name = "btnDeleteTruck"
        Me.btnDeleteTruck.Size = New System.Drawing.Size(59, 23)
        Me.btnDeleteTruck.TabIndex = 7
        Me.btnDeleteTruck.Text = "Del Truck"
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
        'btnDeleteRack
        '
        Me.btnDeleteRack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDeleteRack.BackColor = System.Drawing.Color.Red
        Me.btnDeleteRack.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.btnDeleteRack.Location = New System.Drawing.Point(176, 1)
        Me.btnDeleteRack.Name = "btnDeleteRack"
        Me.btnDeleteRack.Size = New System.Drawing.Size(59, 23)
        Me.btnDeleteRack.TabIndex = 4
        Me.btnDeleteRack.Text = "Del Rack"
        '
        'grdData
        '
        Me.grdData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.Location = New System.Drawing.Point(0, 27)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(238, 152)
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
    Friend WithEvents btnDeleteRack As System.Windows.Forms.Button
    Friend WithEvents txtRackQty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSortD As System.Windows.Forms.Button
    Friend WithEvents btnSortA As System.Windows.Forms.Button
    Friend WithEvents btnDeleteTruck As System.Windows.Forms.Button
    Friend WithEvents txtTruckQty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
