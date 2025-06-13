<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVScanDockAudit
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
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtModel = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLot = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDeliveryNoteNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAxleNo = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtItem.Location = New System.Drawing.Point(63, 28)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(160, 23)
        Me.txtItem.TabIndex = 2
        Me.txtItem.TabStop = False
        Me.txtItem.Text = "F44&U11R001"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.Text = "Item"
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
        Me.txtModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtModel.Location = New System.Drawing.Point(63, 5)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(160, 23)
        Me.txtModel.TabIndex = 1
        Me.txtModel.TabStop = False
        Me.txtModel.Text = "U11"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.Text = "Model"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.Text = "Area"
        '
        'txtLot
        '
        Me.txtLot.BackColor = System.Drawing.SystemColors.Info
        Me.txtLot.Location = New System.Drawing.Point(63, 53)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(160, 23)
        Me.txtLot.TabIndex = 3
        Me.txtLot.TabStop = False
        Me.txtLot.Text = "RA"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(11, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.Text = "Variant"
        '
        'txtDeliveryNoteNo
        '
        Me.txtDeliveryNoteNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtDeliveryNoteNo.Location = New System.Drawing.Point(63, 76)
        Me.txtDeliveryNoteNo.Name = "txtDeliveryNoteNo"
        Me.txtDeliveryNoteNo.Size = New System.Drawing.Size(160, 23)
        Me.txtDeliveryNoteNo.TabIndex = 4
        Me.txtDeliveryNoteNo.TabStop = False
        Me.txtDeliveryNoteNo.Text = "44EEB7"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.Text = "Lot"
        '
        'txtAxleNo
        '
        Me.txtAxleNo.BackColor = System.Drawing.SystemColors.Info
        Me.txtAxleNo.Location = New System.Drawing.Point(63, 99)
        Me.txtAxleNo.Name = "txtAxleNo"
        Me.txtAxleNo.Size = New System.Drawing.Size(160, 23)
        Me.txtAxleNo.TabIndex = 5
        Me.txtAxleNo.TabStop = False
        Me.txtAxleNo.Text = "4044"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(63, 122)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 23)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "01"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.Text = "Axle"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(63, 145)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(160, 23)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "L"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(11, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.Text = "Side"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(11, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 20)
        Me.Label8.Text = "Checked"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(71, 171)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(40, 21)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "4"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(109, 171)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(40, 21)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "5"
        '
        'clsVScanDockAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAxleNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDeliveryNoteNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLot)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "clsVScanDockAudit"
        Me.Text = "Dock Audit (Scan)"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLot As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDeliveryNoteNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAxleNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
