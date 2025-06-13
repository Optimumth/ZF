<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVSyncronize_Android
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
        Me.btnOperation = New OPE_Controls.OpeButton(Me.components)
        Me.txtStatus = New OPE_Controls.OpeTextBox()
        Me.lblStatus = New OPE_Controls.OpeLabel(Me.components)
        Me.TimeSync = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnOperation
        '
        Me.btnOperation.Location = New System.Drawing.Point(366, 309)
        Me.btnOperation.Name = "btnOperation"
        Me.btnOperation.Size = New System.Drawing.Size(68, 42)
        Me.btnOperation.TabIndex = 8
        Me.btnOperation.Text = "Close"
        Me.btnOperation.UseVisualStyleBackColor = True
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
        Me.txtStatus.Location = New System.Drawing.Point(30, 52)
        Me.txtStatus.MaxValue = 99999.99R
        Me.txtStatus.MinValue = -99999.99R
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.NotNull = False
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.ShowDecimal = False
        Me.txtStatus.Size = New System.Drawing.Size(404, 235)
        Me.txtStatus.TabIndex = 7
        Me.txtStatus.TabStop = False
        Me.txtStatus.WordWrap = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStatus.LabelId = 0
        Me.lblStatus.Location = New System.Drawing.Point(27, 22)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(95, 17)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Device Status"
        '
        'TimeSync
        '
        Me.TimeSync.Interval = 1000
        '
        'clsVSyncronize_Android
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(472, 373)
        Me.Controls.Add(Me.btnOperation)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Name = "clsVSyncronize_Android"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Syncronize"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOperation As OPE_Controls.OpeButton
    Friend WithEvents txtStatus As OPE_Controls.OpeTextBox
    Friend WithEvents lblStatus As OPE_Controls.OpeLabel
    Friend WithEvents TimeSync As System.Windows.Forms.Timer
End Class
