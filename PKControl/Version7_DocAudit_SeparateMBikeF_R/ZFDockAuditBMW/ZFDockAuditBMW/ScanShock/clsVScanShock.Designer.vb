<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVScanShock
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
        Me.lblCheck7 = New System.Windows.Forms.Label
        Me.lblCheck6 = New System.Windows.Forms.Label
        Me.lblCheck5 = New System.Windows.Forms.Label
        Me.txtCheck7 = New System.Windows.Forms.TextBox
        Me.txtCheck6 = New System.Windows.Forms.TextBox
        Me.txtCheck5 = New System.Windows.Forms.TextBox
        Me.txtModelDock = New System.Windows.Forms.TextBox
        Me.txtArea = New System.Windows.Forms.TextBox
        Me.lblArea = New System.Windows.Forms.Label
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.lblItem = New System.Windows.Forms.Label
        Me.txtModelRack = New System.Windows.Forms.TextBox
        Me.lblModel = New System.Windows.Forms.Label
        Me.ActiveTimer = New System.Windows.Forms.Timer
        Me.lblBarcode = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.txtShockNo = New System.Windows.Forms.TextBox
        Me.lblShockNo = New System.Windows.Forms.Label
        Me.txtSide = New System.Windows.Forms.TextBox
        Me.lblSide = New System.Windows.Forms.Label
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
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save (F4)"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(156, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 37)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Back (Esc)"
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.Color.PaleGreen
        Me.pnTop.Controls.Add(Me.txtSide)
        Me.pnTop.Controls.Add(Me.lblSide)
        Me.pnTop.Controls.Add(Me.txtShockNo)
        Me.pnTop.Controls.Add(Me.lblShockNo)
        Me.pnTop.Controls.Add(Me.txtBarcode)
        Me.pnTop.Controls.Add(Me.lblBarcode)
        Me.pnTop.Controls.Add(Me.lblCheck7)
        Me.pnTop.Controls.Add(Me.lblCheck6)
        Me.pnTop.Controls.Add(Me.lblCheck5)
        Me.pnTop.Controls.Add(Me.txtCheck7)
        Me.pnTop.Controls.Add(Me.txtCheck6)
        Me.pnTop.Controls.Add(Me.txtCheck5)
        Me.pnTop.Controls.Add(Me.txtModelDock)
        Me.pnTop.Controls.Add(Me.txtArea)
        Me.pnTop.Controls.Add(Me.lblArea)
        Me.pnTop.Controls.Add(Me.txtItem)
        Me.pnTop.Controls.Add(Me.lblItem)
        Me.pnTop.Controls.Add(Me.txtModelRack)
        Me.pnTop.Controls.Add(Me.lblModel)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(238, 199)
        '
        'lblCheck7
        '
        Me.lblCheck7.ForeColor = System.Drawing.Color.Gray
        Me.lblCheck7.Location = New System.Drawing.Point(153, 156)
        Me.lblCheck7.Name = "lblCheck7"
        Me.lblCheck7.Size = New System.Drawing.Size(56, 15)
        Me.lblCheck7.Text = "Check 7"
        '
        'lblCheck6
        '
        Me.lblCheck6.ForeColor = System.Drawing.Color.Gray
        Me.lblCheck6.Location = New System.Drawing.Point(94, 156)
        Me.lblCheck6.Name = "lblCheck6"
        Me.lblCheck6.Size = New System.Drawing.Size(56, 15)
        Me.lblCheck6.Text = "Check 6"
        '
        'lblCheck5
        '
        Me.lblCheck5.ForeColor = System.Drawing.Color.Gray
        Me.lblCheck5.Location = New System.Drawing.Point(34, 156)
        Me.lblCheck5.Name = "lblCheck5"
        Me.lblCheck5.Size = New System.Drawing.Size(56, 15)
        Me.lblCheck5.Text = "Check 5"
        '
        'txtCheck7
        '
        Me.txtCheck7.BackColor = System.Drawing.Color.Blue
        Me.txtCheck7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCheck7.ForeColor = System.Drawing.Color.MistyRose
        Me.txtCheck7.Location = New System.Drawing.Point(165, 174)
        Me.txtCheck7.Name = "txtCheck7"
        Me.txtCheck7.ReadOnly = True
        Me.txtCheck7.Size = New System.Drawing.Size(20, 23)
        Me.txtCheck7.TabIndex = 9
        '
        'txtCheck6
        '
        Me.txtCheck6.BackColor = System.Drawing.Color.Blue
        Me.txtCheck6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCheck6.ForeColor = System.Drawing.Color.MistyRose
        Me.txtCheck6.Location = New System.Drawing.Point(106, 174)
        Me.txtCheck6.Name = "txtCheck6"
        Me.txtCheck6.ReadOnly = True
        Me.txtCheck6.Size = New System.Drawing.Size(20, 23)
        Me.txtCheck6.TabIndex = 8
        '
        'txtCheck5
        '
        Me.txtCheck5.BackColor = System.Drawing.Color.Blue
        Me.txtCheck5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCheck5.ForeColor = System.Drawing.Color.MistyRose
        Me.txtCheck5.Location = New System.Drawing.Point(47, 174)
        Me.txtCheck5.Name = "txtCheck5"
        Me.txtCheck5.ReadOnly = True
        Me.txtCheck5.Size = New System.Drawing.Size(20, 23)
        Me.txtCheck5.TabIndex = 7
        '
        'txtModelDock
        '
        Me.txtModelDock.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtModelDock.Location = New System.Drawing.Point(174, 3)
        Me.txtModelDock.Name = "txtModelDock"
        Me.txtModelDock.ReadOnly = True
        Me.txtModelDock.Size = New System.Drawing.Size(51, 23)
        Me.txtModelDock.TabIndex = 1
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtArea.Location = New System.Drawing.Point(64, 51)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(161, 23)
        Me.txtArea.TabIndex = 3
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(6, 52)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(52, 20)
        Me.lblArea.Text = "Area"
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtItem.Location = New System.Drawing.Point(64, 27)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(161, 23)
        Me.txtItem.TabIndex = 2
        '
        'lblItem
        '
        Me.lblItem.Location = New System.Drawing.Point(6, 28)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(52, 20)
        Me.lblItem.Text = "Item"
        '
        'txtModelRack
        '
        Me.txtModelRack.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtModelRack.Location = New System.Drawing.Point(64, 3)
        Me.txtModelRack.Name = "txtModelRack"
        Me.txtModelRack.ReadOnly = True
        Me.txtModelRack.Size = New System.Drawing.Size(108, 23)
        Me.txtModelRack.TabIndex = 0
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(6, 4)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(52, 20)
        Me.lblModel.Text = "Model"
        '
        'ActiveTimer
        '
        Me.ActiveTimer.Enabled = True
        Me.ActiveTimer.Interval = 1000
        '
        'lblBarcode
        '
        Me.lblBarcode.Location = New System.Drawing.Point(6, 79)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(61, 20)
        Me.lblBarcode.Text = "Barcode"
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Orange
        Me.txtBarcode.Location = New System.Drawing.Point(79, 78)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(146, 23)
        Me.txtBarcode.TabIndex = 4
        '
        'txtShockNo
        '
        Me.txtShockNo.BackColor = System.Drawing.Color.Orange
        Me.txtShockNo.Location = New System.Drawing.Point(79, 102)
        Me.txtShockNo.Name = "txtShockNo"
        Me.txtShockNo.ReadOnly = True
        Me.txtShockNo.Size = New System.Drawing.Size(146, 23)
        Me.txtShockNo.TabIndex = 5
        '
        'lblShockNo
        '
        Me.lblShockNo.Location = New System.Drawing.Point(6, 103)
        Me.lblShockNo.Name = "lblShockNo"
        Me.lblShockNo.Size = New System.Drawing.Size(70, 20)
        Me.lblShockNo.Text = "Shock No."
        '
        'txtSide
        '
        Me.txtSide.BackColor = System.Drawing.Color.Orange
        Me.txtSide.Location = New System.Drawing.Point(79, 126)
        Me.txtSide.Name = "txtSide"
        Me.txtSide.ReadOnly = True
        Me.txtSide.Size = New System.Drawing.Size(146, 23)
        Me.txtSide.TabIndex = 6
        '
        'lblSide
        '
        Me.lblSide.Location = New System.Drawing.Point(6, 127)
        Me.lblSide.Name = "lblSide"
        Me.lblSide.Size = New System.Drawing.Size(52, 20)
        Me.lblSide.Text = "Side"
        '
        'clsVScanShock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(238, 247)
        Me.Controls.Add(Me.pnTop)
        Me.Controls.Add(Me.pnButton)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "clsVScanShock"
        Me.Text = "Shock - Scan Dock Audit"
        Me.pnButton.ResumeLayout(False)
        Me.pnTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnButton As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents txtModelDock As System.Windows.Forms.TextBox
    Friend WithEvents txtModelRack As System.Windows.Forms.TextBox
    Friend WithEvents ActiveTimer As System.Windows.Forms.Timer
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtCheck7 As System.Windows.Forms.TextBox
    Friend WithEvents txtCheck6 As System.Windows.Forms.TextBox
    Friend WithEvents txtCheck5 As System.Windows.Forms.TextBox
    Friend WithEvents lblCheck7 As System.Windows.Forms.Label
    Friend WithEvents lblCheck6 As System.Windows.Forms.Label
    Friend WithEvents lblCheck5 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents lblBarcode As System.Windows.Forms.Label
    Friend WithEvents txtSide As System.Windows.Forms.TextBox
    Friend WithEvents lblSide As System.Windows.Forms.Label
    Friend WithEvents txtShockNo As System.Windows.Forms.TextBox
    Friend WithEvents lblShockNo As System.Windows.Forms.Label
End Class
