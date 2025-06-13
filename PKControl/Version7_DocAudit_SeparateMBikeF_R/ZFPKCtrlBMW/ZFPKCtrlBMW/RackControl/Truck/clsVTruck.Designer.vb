<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVTruck
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
        Me.btnTruckDetail = New System.Windows.Forms.Button
        Me.btnOldTruck = New System.Windows.Forms.Button
        Me.btnNewTruk = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.pnTop = New System.Windows.Forms.Panel
        Me.txtFreeRackQty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grdData = New System.Windows.Forms.DataGrid
        Me.pnButton.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnButton
        '
        Me.pnButton.BackColor = System.Drawing.Color.Turquoise
        Me.pnButton.Controls.Add(Me.btnTruckDetail)
        Me.pnButton.Controls.Add(Me.btnOldTruck)
        Me.pnButton.Controls.Add(Me.btnNewTruk)
        Me.pnButton.Controls.Add(Me.btnExit)
        Me.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnButton.Location = New System.Drawing.Point(0, 164)
        Me.pnButton.Name = "pnButton"
        Me.pnButton.Size = New System.Drawing.Size(238, 83)
        '
        'btnTruckDetail
        '
        Me.btnTruckDetail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnTruckDetail.BackColor = System.Drawing.Color.Blue
        Me.btnTruckDetail.Location = New System.Drawing.Point(10, 40)
        Me.btnTruckDetail.Name = "btnTruckDetail"
        Me.btnTruckDetail.Size = New System.Drawing.Size(140, 37)
        Me.btnTruckDetail.TabIndex = 5
        Me.btnTruckDetail.Text = "Edit Truck Detail"
        '
        'btnOldTruck
        '
        Me.btnOldTruck.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOldTruck.Location = New System.Drawing.Point(10, 4)
        Me.btnOldTruck.Name = "btnOldTruck"
        Me.btnOldTruck.Size = New System.Drawing.Size(140, 34)
        Me.btnOldTruck.TabIndex = 3
        '
        'btnNewTruk
        '
        Me.btnNewTruk.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNewTruk.Location = New System.Drawing.Point(156, 4)
        Me.btnNewTruk.Name = "btnNewTruk"
        Me.btnNewTruk.Size = New System.Drawing.Size(79, 34)
        Me.btnNewTruk.TabIndex = 2
        Me.btnNewTruk.Text = "New Truck"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(156, 40)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 37)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Back (Esc)"
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.Color.Turquoise
        Me.pnTop.Controls.Add(Me.txtFreeRackQty)
        Me.pnTop.Controls.Add(Me.Label2)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(238, 39)
        '
        'txtFreeRackQty
        '
        Me.txtFreeRackQty.Location = New System.Drawing.Point(95, 8)
        Me.txtFreeRackQty.Name = "txtFreeRackQty"
        Me.txtFreeRackQty.Size = New System.Drawing.Size(78, 23)
        Me.txtFreeRackQty.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.Text = "Free rack qty"
        '
        'grdData
        '
        Me.grdData.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.Location = New System.Drawing.Point(0, 39)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(238, 125)
        Me.grdData.TabIndex = 2
        '
        'clsVTruck
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
        Me.Name = "clsVTruck"
        Me.Text = "BMW Truck"
        Me.pnButton.ResumeLayout(False)
        Me.pnTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnButton As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents grdData As System.Windows.Forms.DataGrid
    Friend WithEvents txtFreeRackQty As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnNewTruk As System.Windows.Forms.Button
    Friend WithEvents btnOldTruck As System.Windows.Forms.Button
    Friend WithEvents btnTruckDetail As System.Windows.Forms.Button
End Class
