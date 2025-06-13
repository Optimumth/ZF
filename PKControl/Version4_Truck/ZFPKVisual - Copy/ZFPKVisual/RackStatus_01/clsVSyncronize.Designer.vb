<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVSyncronize
    Inherits OPE_Controls.OpeForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblStatus = New OPE_Controls.OpeLabel(Me.components)
        Me.txtStatus = New OPE_Controls.OpeTextBox()
        Me.btnOperation = New OPE_Controls.OpeButton(Me.components)
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.btnSync = New OPE_Controls.OpeButtonStrip()
        Me.TimeSync = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonBoxH.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStatus.LabelId = 0
        Me.lblStatus.Location = New System.Drawing.Point(28, 80)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(95, 17)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Device Status"
        '
        'txtStatus
        '
        Me.txtStatus.Add_Comma = False
        Me.txtStatus.BackColor = System.Drawing.Color.Empty
        Me.txtStatus.DataSource = Nothing
        Me.txtStatus.DecimalDigit = 2
        Me.txtStatus.DisplayMember = Nothing
        Me.txtStatus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtStatus.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtStatus.LinkCheckedBox = Nothing
        Me.txtStatus.Location = New System.Drawing.Point(31, 110)
        Me.txtStatus.MaxValue = 99999.99R
        Me.txtStatus.MinValue = -99999.99R
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.NotNull = False
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.ShowDecimal = False
        Me.txtStatus.Size = New System.Drawing.Size(404, 103)
        Me.txtStatus.TabIndex = 4
        Me.txtStatus.TabStop = False
        Me.txtStatus.WordWrap = False
        '
        'btnOperation
        '
        Me.btnOperation.Location = New System.Drawing.Point(367, 229)
        Me.btnOperation.Name = "btnOperation"
        Me.btnOperation.Size = New System.Drawing.Size(68, 42)
        Me.btnOperation.TabIndex = 5
        Me.btnOperation.Text = "Close"
        Me.btnOperation.UseVisualStyleBackColor = True
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Nothing
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSync})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(463, 39)
        Me.ButtonBoxH.StatusBox = Nothing
        Me.ButtonBoxH.TabIndex = 6
        Me.ButtonBoxH.Text = "OpeButtonBox1"
        '
        'btnSync
        '
        Me.btnSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSync.Image = Global.ZFPKVisual.My.Resources.Resources.Handy
        Me.btnSync.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSync.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(36, 36)
        Me.btnSync.Text = "Syncronize"
        '
        'TimeSync
        '
        Me.TimeSync.Interval = 1000
        '
        'clsVSyncronize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 336)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Controls.Add(Me.btnOperation)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "clsVSyncronize"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Syncronize"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus As OPE_Controls.OpeLabel
    Friend WithEvents txtStatus As OPE_Controls.OpeTextBox
    Friend WithEvents btnOperation As OPE_Controls.OpeButton
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSync As OPE_Controls.OpeButtonStrip
    Friend WithEvents TimeSync As System.Windows.Forms.Timer
End Class
