<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVRackSync
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
        Me.lblStatus = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TimeSync = New System.Windows.Forms.Timer
        Me.lblZF = New System.Windows.Forms.Label
        Me.lblMB = New System.Windows.Forms.Label
        Me.lblSuplier = New System.Windows.Forms.Label
        Me.lblOntruck = New System.Windows.Forms.Label
        Me.lblExtWH = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(145, 198)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 37)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Back (Esc)"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(20, 33)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(160, 20)
        Me.lblStatus.Text = "Synchronize"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePicker1.TabIndex = 0
        '
        'TimeSync
        '
        Me.TimeSync.Enabled = True
        Me.TimeSync.Interval = 1000
        '
        'lblZF
        '
        Me.lblZF.Location = New System.Drawing.Point(20, 62)
        Me.lblZF.Name = "lblZF"
        Me.lblZF.Size = New System.Drawing.Size(160, 20)
        Me.lblZF.Text = "ZF"
        '
        'lblMB
        '
        Me.lblMB.Location = New System.Drawing.Point(20, 82)
        Me.lblMB.Name = "lblMB"
        Me.lblMB.Size = New System.Drawing.Size(160, 20)
        Me.lblMB.Text = "MB"
        '
        'lblSuplier
        '
        Me.lblSuplier.Location = New System.Drawing.Point(20, 122)
        Me.lblSuplier.Name = "lblSuplier"
        Me.lblSuplier.Size = New System.Drawing.Size(160, 20)
        Me.lblSuplier.Text = "Supplier"
        '
        'lblOntruck
        '
        Me.lblOntruck.Location = New System.Drawing.Point(20, 102)
        Me.lblOntruck.Name = "lblOntruck"
        Me.lblOntruck.Size = New System.Drawing.Size(160, 20)
        Me.lblOntruck.Text = "On Truck"
        '
        'lblExtWH
        '
        Me.lblExtWH.Location = New System.Drawing.Point(20, 142)
        Me.lblExtWH.Name = "lblExtWH"
        Me.lblExtWH.Size = New System.Drawing.Size(160, 20)
        Me.lblExtWH.Text = "Ext WH"
        '
        'clsVRackSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.lblExtWH)
        Me.Controls.Add(Me.lblSuplier)
        Me.Controls.Add(Me.lblOntruck)
        Me.Controls.Add(Me.lblMB)
        Me.Controls.Add(Me.lblZF)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExit)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "clsVRackSync"
        Me.Text = "Rack Status Synchronize"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TimeSync As System.Windows.Forms.Timer
    Friend WithEvents lblZF As System.Windows.Forms.Label
    Friend WithEvents lblMB As System.Windows.Forms.Label
    Friend WithEvents lblSuplier As System.Windows.Forms.Label
    Friend WithEvents lblOntruck As System.Windows.Forms.Label
    Friend WithEvents lblExtWH As System.Windows.Forms.Label
End Class
