<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVSample
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVSample))
        Me.picWorkingTime = New OPE_Controls.OpeGroupBox()
        Me.PicDelivery = New OPE_Controls.OpeGroupBox()
        Me.SuspendLayout()
        '
        'picWorkingTime
        '
        Me.picWorkingTime.BackgroundImage = CType(resources.GetObject("picWorkingTime.BackgroundImage"), System.Drawing.Image)
        Me.picWorkingTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWorkingTime.Location = New System.Drawing.Point(24, 12)
        Me.picWorkingTime.Name = "picWorkingTime"
        Me.picWorkingTime.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.picWorkingTime.Size = New System.Drawing.Size(249, 156)
        Me.picWorkingTime.TabIndex = 0
        Me.picWorkingTime.TabStop = False
        Me.picWorkingTime.Visible = False
        '
        'PicDelivery
        '
        Me.PicDelivery.BackgroundImage = CType(resources.GetObject("PicDelivery.BackgroundImage"), System.Drawing.Image)
        Me.PicDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicDelivery.Location = New System.Drawing.Point(83, 12)
        Me.PicDelivery.Name = "PicDelivery"
        Me.PicDelivery.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.PicDelivery.Size = New System.Drawing.Size(144, 206)
        Me.PicDelivery.TabIndex = 1
        Me.PicDelivery.TabStop = False
        Me.PicDelivery.Visible = False
        '
        'clsVSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 224)
        Me.Controls.Add(Me.PicDelivery)
        Me.Controls.Add(Me.picWorkingTime)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "clsVSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sample Data"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picWorkingTime As OPE_Controls.OpeGroupBox
    Friend WithEvents PicDelivery As OPE_Controls.OpeGroupBox
End Class
