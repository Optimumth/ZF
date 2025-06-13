<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVTruckdetail
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
        Me.txtVarian = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAxleNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDeliveryNoteNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtLot = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.SuspendLayout()
        '
        'txtVarian
        '
        Me.txtVarian.Location = New System.Drawing.Point(129, 56)
        Me.txtVarian.Name = "txtVarian"
        Me.txtVarian.Size = New System.Drawing.Size(82, 23)
        Me.txtVarian.TabIndex = 2
        Me.txtVarian.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.Text = "Varian"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.BackColor = System.Drawing.Color.Cyan
        Me.btnSave.Location = New System.Drawing.Point(15, 204)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 37)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save (F4)"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(121, 204)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 37)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Cancel (Esc)"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(129, 31)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(82, 23)
        Me.txtModel.TabIndex = 1
        Me.txtModel.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "Model"
        '
        'txtAxleNo
        '
        Me.txtAxleNo.Location = New System.Drawing.Point(129, 131)
        Me.txtAxleNo.Name = "txtAxleNo"
        Me.txtAxleNo.Size = New System.Drawing.Size(82, 23)
        Me.txtAxleNo.TabIndex = 5
        Me.txtAxleNo.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.Text = "Axle No."
        '
        'txtDeliveryNoteNo
        '
        Me.txtDeliveryNoteNo.Location = New System.Drawing.Point(129, 106)
        Me.txtDeliveryNoteNo.Name = "txtDeliveryNoteNo"
        Me.txtDeliveryNoteNo.Size = New System.Drawing.Size(82, 23)
        Me.txtDeliveryNoteNo.TabIndex = 4
        Me.txtDeliveryNoteNo.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.Text = "Deli-Note No."
        '
        'txtLot
        '
        Me.txtLot.Location = New System.Drawing.Point(129, 81)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(82, 23)
        Me.txtLot.TabIndex = 3
        Me.txtLot.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.Text = "Lot"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'clsVTruckdetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.txtAxleNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDeliveryNoteNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLot)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVarian)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "clsVTruckdetail"
        Me.Text = "Truck Detail"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtVarian As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAxleNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDeliveryNoteNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLot As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
