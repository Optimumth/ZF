<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartPage
    Inherits System.Windows.Forms.Form

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

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
        Me.btnMB = New System.Windows.Forms.Button()
        Me.btnBMW = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMB
        '
        Me.btnMB.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMB.BackgroundImage = Global.ZFPKVisual.My.Resources.Resources.StateMB
        Me.btnMB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMB.Location = New System.Drawing.Point(141, 133)
        Me.btnMB.Name = "btnMB"
        Me.btnMB.Size = New System.Drawing.Size(120, 120)
        Me.btnMB.TabIndex = 0
        Me.btnMB.UseVisualStyleBackColor = False
        '
        'btnBMW
        '
        Me.btnBMW.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBMW.BackgroundImage = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        Me.btnBMW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBMW.Location = New System.Drawing.Point(391, 133)
        Me.btnBMW.Name = "btnBMW"
        Me.btnBMW.Size = New System.Drawing.Size(120, 120)
        Me.btnBMW.TabIndex = 1
        Me.btnBMW.UseVisualStyleBackColor = False
        '
        'StartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ZFPKVisual.My.Resources.Resources.ZFSplash
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(685, 357)
        Me.Controls.Add(Me.btnBMW)
        Me.Controls.Add(Me.btnMB)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartPage"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Packaging Tracking"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMB As System.Windows.Forms.Button
    Friend WithEvents btnBMW As System.Windows.Forms.Button

End Class
