<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class clsVScanAxle
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
        Me.lblCheck4 = New System.Windows.Forms.Label
        Me.lblCheck3 = New System.Windows.Forms.Label
        Me.lblCheck2 = New System.Windows.Forms.Label
        Me.lblCheck1 = New System.Windows.Forms.Label
        Me.txtCheck4 = New System.Windows.Forms.TextBox
        Me.txtCheck3 = New System.Windows.Forms.TextBox
        Me.txtCheck2 = New System.Windows.Forms.TextBox
        Me.txtCheck1 = New System.Windows.Forms.TextBox
        Me.txtModelDock = New System.Windows.Forms.TextBox
        Me.txtSide = New System.Windows.Forms.TextBox
        Me.lblSide = New System.Windows.Forms.Label
        Me.txtAxle = New System.Windows.Forms.TextBox
        Me.lblAxle = New System.Windows.Forms.Label
        Me.txtLot = New System.Windows.Forms.TextBox
        Me.lblLot = New System.Windows.Forms.Label
        Me.txtVariant = New System.Windows.Forms.TextBox
        Me.lblVariant = New System.Windows.Forms.Label
        Me.txtArea = New System.Windows.Forms.TextBox
        Me.lblArea = New System.Windows.Forms.Label
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.lblItem = New System.Windows.Forms.Label
        Me.txtModelRack = New System.Windows.Forms.TextBox
        Me.lblModel = New System.Windows.Forms.Label
        Me.ActiveTimer = New System.Windows.Forms.Timer
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
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save (F4)"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(156, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 37)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Back (Esc)"
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.Color.PaleGreen
        Me.pnTop.Controls.Add(Me.lblCheck4)
        Me.pnTop.Controls.Add(Me.lblCheck3)
        Me.pnTop.Controls.Add(Me.lblCheck2)
        Me.pnTop.Controls.Add(Me.lblCheck1)
        Me.pnTop.Controls.Add(Me.txtCheck4)
        Me.pnTop.Controls.Add(Me.txtCheck3)
        Me.pnTop.Controls.Add(Me.txtCheck2)
        Me.pnTop.Controls.Add(Me.txtCheck1)
        Me.pnTop.Controls.Add(Me.txtModelDock)
        Me.pnTop.Controls.Add(Me.txtSide)
        Me.pnTop.Controls.Add(Me.lblSide)
        Me.pnTop.Controls.Add(Me.txtAxle)
        Me.pnTop.Controls.Add(Me.lblAxle)
        Me.pnTop.Controls.Add(Me.txtLot)
        Me.pnTop.Controls.Add(Me.lblLot)
        Me.pnTop.Controls.Add(Me.txtVariant)
        Me.pnTop.Controls.Add(Me.lblVariant)
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
        'lblCheck4
        '
        Me.lblCheck4.ForeColor = System.Drawing.Color.Gray
        Me.lblCheck4.Location = New System.Drawing.Point(179, 156)
        Me.lblCheck4.Name = "lblCheck4"
        Me.lblCheck4.Size = New System.Drawing.Size(56, 15)
        Me.lblCheck4.Text = "Check 4"
        '
        'lblCheck3
        '
        Me.lblCheck3.ForeColor = System.Drawing.Color.Gray
        Me.lblCheck3.Location = New System.Drawing.Point(120, 156)
        Me.lblCheck3.Name = "lblCheck3"
        Me.lblCheck3.Size = New System.Drawing.Size(56, 15)
        Me.lblCheck3.Text = "Check 3"
        '
        'lblCheck2
        '
        Me.lblCheck2.ForeColor = System.Drawing.Color.Gray
        Me.lblCheck2.Location = New System.Drawing.Point(61, 156)
        Me.lblCheck2.Name = "lblCheck2"
        Me.lblCheck2.Size = New System.Drawing.Size(56, 15)
        Me.lblCheck2.Text = "Check 2"
        '
        'lblCheck1
        '
        Me.lblCheck1.ForeColor = System.Drawing.Color.Gray
        Me.lblCheck1.Location = New System.Drawing.Point(1, 156)
        Me.lblCheck1.Name = "lblCheck1"
        Me.lblCheck1.Size = New System.Drawing.Size(56, 15)
        Me.lblCheck1.Text = "Check 1"
        '
        'txtCheck4
        '
        Me.txtCheck4.BackColor = System.Drawing.Color.Blue
        Me.txtCheck4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCheck4.ForeColor = System.Drawing.Color.MistyRose
        Me.txtCheck4.Location = New System.Drawing.Point(191, 174)
        Me.txtCheck4.Name = "txtCheck4"
        Me.txtCheck4.ReadOnly = True
        Me.txtCheck4.Size = New System.Drawing.Size(20, 23)
        Me.txtCheck4.TabIndex = 23
        '
        'txtCheck3
        '
        Me.txtCheck3.BackColor = System.Drawing.Color.Blue
        Me.txtCheck3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCheck3.ForeColor = System.Drawing.Color.MistyRose
        Me.txtCheck3.Location = New System.Drawing.Point(132, 174)
        Me.txtCheck3.Name = "txtCheck3"
        Me.txtCheck3.ReadOnly = True
        Me.txtCheck3.Size = New System.Drawing.Size(20, 23)
        Me.txtCheck3.TabIndex = 22
        '
        'txtCheck2
        '
        Me.txtCheck2.BackColor = System.Drawing.Color.Blue
        Me.txtCheck2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCheck2.ForeColor = System.Drawing.Color.MistyRose
        Me.txtCheck2.Location = New System.Drawing.Point(73, 174)
        Me.txtCheck2.Name = "txtCheck2"
        Me.txtCheck2.ReadOnly = True
        Me.txtCheck2.Size = New System.Drawing.Size(20, 23)
        Me.txtCheck2.TabIndex = 21
        '
        'txtCheck1
        '
        Me.txtCheck1.BackColor = System.Drawing.Color.Blue
        Me.txtCheck1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCheck1.ForeColor = System.Drawing.Color.MistyRose
        Me.txtCheck1.Location = New System.Drawing.Point(14, 174)
        Me.txtCheck1.Name = "txtCheck1"
        Me.txtCheck1.ReadOnly = True
        Me.txtCheck1.Size = New System.Drawing.Size(20, 23)
        Me.txtCheck1.TabIndex = 20
        '
        'txtModelDock
        '
        Me.txtModelDock.BackColor = System.Drawing.Color.Orange
        Me.txtModelDock.Location = New System.Drawing.Point(174, 3)
        Me.txtModelDock.Name = "txtModelDock"
        Me.txtModelDock.ReadOnly = True
        Me.txtModelDock.Size = New System.Drawing.Size(51, 23)
        Me.txtModelDock.TabIndex = 1
        '
        'txtSide
        '
        Me.txtSide.BackColor = System.Drawing.Color.Orange
        Me.txtSide.Location = New System.Drawing.Point(174, 123)
        Me.txtSide.Name = "txtSide"
        Me.txtSide.ReadOnly = True
        Me.txtSide.Size = New System.Drawing.Size(51, 23)
        Me.txtSide.TabIndex = 7
        '
        'lblSide
        '
        Me.lblSide.Location = New System.Drawing.Point(135, 124)
        Me.lblSide.Name = "lblSide"
        Me.lblSide.Size = New System.Drawing.Size(35, 20)
        Me.lblSide.Text = "Side"
        '
        'txtAxle
        '
        Me.txtAxle.BackColor = System.Drawing.Color.Orange
        Me.txtAxle.Location = New System.Drawing.Point(64, 123)
        Me.txtAxle.Name = "txtAxle"
        Me.txtAxle.ReadOnly = True
        Me.txtAxle.Size = New System.Drawing.Size(54, 23)
        Me.txtAxle.TabIndex = 6
        '
        'lblAxle
        '
        Me.lblAxle.Location = New System.Drawing.Point(6, 124)
        Me.lblAxle.Name = "lblAxle"
        Me.lblAxle.Size = New System.Drawing.Size(60, 20)
        Me.lblAxle.Text = "Axle No."
        '
        'txtLot
        '
        Me.txtLot.BackColor = System.Drawing.Color.Orange
        Me.txtLot.Location = New System.Drawing.Point(64, 99)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.ReadOnly = True
        Me.txtLot.Size = New System.Drawing.Size(161, 23)
        Me.txtLot.TabIndex = 5
        '
        'lblLot
        '
        Me.lblLot.Location = New System.Drawing.Point(6, 100)
        Me.lblLot.Name = "lblLot"
        Me.lblLot.Size = New System.Drawing.Size(52, 20)
        Me.lblLot.Text = "Lot"
        '
        'txtVariant
        '
        Me.txtVariant.BackColor = System.Drawing.Color.Orange
        Me.txtVariant.Location = New System.Drawing.Point(64, 75)
        Me.txtVariant.Name = "txtVariant"
        Me.txtVariant.ReadOnly = True
        Me.txtVariant.Size = New System.Drawing.Size(161, 23)
        Me.txtVariant.TabIndex = 4
        '
        'lblVariant
        '
        Me.lblVariant.Location = New System.Drawing.Point(6, 76)
        Me.lblVariant.Name = "lblVariant"
        Me.lblVariant.Size = New System.Drawing.Size(52, 20)
        Me.lblVariant.Text = "Variant"
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.Color.Orange
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
        'clsVScanAxle
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
        Me.Name = "clsVScanAxle"
        Me.Text = "Axle - Scan Dock Audit"
        Me.pnButton.ResumeLayout(False)
        Me.pnTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnButton As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents txtSide As System.Windows.Forms.TextBox
    Friend WithEvents lblSide As System.Windows.Forms.Label
    Friend WithEvents txtAxle As System.Windows.Forms.TextBox
    Friend WithEvents lblAxle As System.Windows.Forms.Label
    Friend WithEvents txtLot As System.Windows.Forms.TextBox
    Friend WithEvents lblLot As System.Windows.Forms.Label
    Friend WithEvents txtVariant As System.Windows.Forms.TextBox
    Friend WithEvents lblVariant As System.Windows.Forms.Label
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents txtModelDock As System.Windows.Forms.TextBox
    Friend WithEvents txtModelRack As System.Windows.Forms.TextBox
    Friend WithEvents ActiveTimer As System.Windows.Forms.Timer
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtCheck4 As System.Windows.Forms.TextBox
    Friend WithEvents txtCheck3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCheck2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCheck1 As System.Windows.Forms.TextBox
    Friend WithEvents lblCheck4 As System.Windows.Forms.Label
    Friend WithEvents lblCheck3 As System.Windows.Forms.Label
    Friend WithEvents lblCheck2 As System.Windows.Forms.Label
    Friend WithEvents lblCheck1 As System.Windows.Forms.Label
End Class
