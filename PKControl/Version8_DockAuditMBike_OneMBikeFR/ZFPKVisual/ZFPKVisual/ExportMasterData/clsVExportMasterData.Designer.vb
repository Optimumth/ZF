<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVExportMasterData
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
        Me.txtStatus = New OPE_Controls.OpeTextBox()
        Me.TimeSync = New System.Windows.Forms.Timer(Me.components)
        Me.btnClose = New OPE_Controls.OpeButton(Me.components)
        Me.btnStart = New OPE_Controls.OpeButton(Me.components)
        Me.SuspendLayout()
        '
        'txtStatus
        '
        Me.txtStatus.Add_Comma = False
        Me.txtStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.BackColor = System.Drawing.Color.Empty
        Me.txtStatus.DataSource = Nothing
        Me.txtStatus.DecimalDigit = 2
        Me.txtStatus.DisplayMember = Nothing
        Me.txtStatus.EntryType = OPE_Controls.OpeTextBox.enEntryType.None
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtStatus.Language = OPE_Controls.OpeTextBox.LanguageType.ThaiAndEng
        Me.txtStatus.LinkCheckedBox = Nothing
        Me.txtStatus.Location = New System.Drawing.Point(29, 16)
        Me.txtStatus.MaxValue = 99999.99R
        Me.txtStatus.MinValue = -99999.99R
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.NotNull = False
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.ShowDecimal = False
        Me.txtStatus.Size = New System.Drawing.Size(815, 448)
        Me.txtStatus.TabIndex = 6
        Me.txtStatus.TabStop = False
        Me.txtStatus.WordWrap = False
        '
        'TimeSync
        '
        Me.TimeSync.Interval = 1000
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(776, 470)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(68, 42)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(29, 470)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(68, 42)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'clsVExportMasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtStatus)
        Me.Name = "clsVExportMasterData"
        Me.Text = "Export Master Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStatus As OPE_Controls.OpeTextBox
    Friend WithEvents TimeSync As System.Windows.Forms.Timer
    Friend WithEvents btnClose As OPE_Controls.OpeButton
    Friend WithEvents btnStart As OPE_Controls.OpeButton
End Class
