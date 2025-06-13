<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class AssetPicBox
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
        Me.AssyPic = New System.Windows.Forms.PictureBox
        Me.btnNg = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'AssyPic
        '
        Me.AssyPic.Location = New System.Drawing.Point(13, 17)
        Me.AssyPic.Name = "AssyPic"
        Me.AssyPic.Size = New System.Drawing.Size(212, 200)
        Me.AssyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'btnNg
        '
        Me.btnNg.BackColor = System.Drawing.Color.Yellow
        Me.btnNg.Location = New System.Drawing.Point(138, 223)
        Me.btnNg.Name = "btnNg"
        Me.btnNg.Size = New System.Drawing.Size(87, 36)
        Me.btnNg.TabIndex = 1
        Me.btnNg.Text = "NG (Esc)"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Cyan
        Me.btnOK.Location = New System.Drawing.Point(13, 223)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(91, 36)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK (F4)"
        '
        'AssetPicBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(241, 270)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnNg)
        Me.Controls.Add(Me.AssyPic)
        Me.Name = "AssetPicBox"
        Me.Text = "Audit"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AssyPic As System.Windows.Forms.PictureBox
    Friend WithEvents btnNg As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
