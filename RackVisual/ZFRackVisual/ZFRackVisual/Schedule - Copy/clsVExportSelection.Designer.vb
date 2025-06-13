<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVExportSelection
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVExportSelection))
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.grpSelection = New OPE_Controls.OpeGroupBox()
        Me.rdoOverviewOnlyPDF = New OPE_Controls.OpeRadioButton(Me.components)
        Me.rdoOverviewOnlyExcel = New OPE_Controls.OpeRadioButton(Me.components)
        Me.rdoAllPageExcel = New OPE_Controls.OpeRadioButton(Me.components)
        Me.btnOK = New OPE_Controls.OpeButtonStrip()
        Me.grpCustomer = New OPE_Controls.OpeGroupBox()
        Me.rdoBMW = New OPE_Controls.OpeRadioButton(Me.components)
        Me.rdoMB = New OPE_Controls.OpeRadioButton(Me.components)
        Me.ToolStrip.SuspendLayout()
        Me.grpSelection.SuspendLayout()
        Me.grpCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOK})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(590, 39)
        Me.ToolStrip.TabIndex = 1
        Me.ToolStrip.Text = "ToolStrip"
        '
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.rdoOverviewOnlyPDF)
        Me.grpSelection.Controls.Add(Me.rdoOverviewOnlyExcel)
        Me.grpSelection.Controls.Add(Me.rdoAllPageExcel)
        Me.grpSelection.Location = New System.Drawing.Point(26, 139)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSelection.Size = New System.Drawing.Size(540, 62)
        Me.grpSelection.TabIndex = 8
        Me.grpSelection.TabStop = False
        Me.grpSelection.Text = "Export Selection"
        '
        'rdoOverviewOnlyPDF
        '
        Me.rdoOverviewOnlyPDF.AutoSize = True
        Me.rdoOverviewOnlyPDF.Location = New System.Drawing.Point(199, 28)
        Me.rdoOverviewOnlyPDF.Name = "rdoOverviewOnlyPDF"
        Me.rdoOverviewOnlyPDF.Size = New System.Drawing.Size(127, 17)
        Me.rdoOverviewOnlyPDF.TabIndex = 8
        Me.rdoOverviewOnlyPDF.TabStop = True
        Me.rdoOverviewOnlyPDF.Text = "Overview only in PDF"
        Me.rdoOverviewOnlyPDF.UseVisualStyleBackColor = True
        '
        'rdoOverviewOnlyExcel
        '
        Me.rdoOverviewOnlyExcel.AutoSize = True
        Me.rdoOverviewOnlyExcel.Location = New System.Drawing.Point(22, 28)
        Me.rdoOverviewOnlyExcel.Name = "rdoOverviewOnlyExcel"
        Me.rdoOverviewOnlyExcel.Size = New System.Drawing.Size(132, 17)
        Me.rdoOverviewOnlyExcel.TabIndex = 7
        Me.rdoOverviewOnlyExcel.TabStop = True
        Me.rdoOverviewOnlyExcel.Text = "Overview only in Excel"
        Me.rdoOverviewOnlyExcel.UseVisualStyleBackColor = True
        '
        'rdoAllPageExcel
        '
        Me.rdoAllPageExcel.AutoSize = True
        Me.rdoAllPageExcel.Location = New System.Drawing.Point(393, 28)
        Me.rdoAllPageExcel.Name = "rdoAllPageExcel"
        Me.rdoAllPageExcel.Size = New System.Drawing.Size(108, 17)
        Me.rdoAllPageExcel.TabIndex = 6
        Me.rdoAllPageExcel.TabStop = True
        Me.rdoAllPageExcel.Text = "All pages in Excel"
        Me.rdoAllPageExcel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(36, 36)
        Me.btnOK.Text = "OK"
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.rdoBMW)
        Me.grpCustomer.Controls.Add(Me.rdoMB)
        Me.grpCustomer.Location = New System.Drawing.Point(26, 57)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpCustomer.Size = New System.Drawing.Size(540, 62)
        Me.grpCustomer.TabIndex = 9
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "Export Selection"
        '
        'rdoBMW
        '
        Me.rdoBMW.AutoSize = True
        Me.rdoBMW.Location = New System.Drawing.Point(199, 28)
        Me.rdoBMW.Name = "rdoBMW"
        Me.rdoBMW.Size = New System.Drawing.Size(52, 17)
        Me.rdoBMW.TabIndex = 8
        Me.rdoBMW.TabStop = True
        Me.rdoBMW.Text = "BMW"
        Me.rdoBMW.UseVisualStyleBackColor = True
        '
        'rdoMB
        '
        Me.rdoMB.AutoSize = True
        Me.rdoMB.Location = New System.Drawing.Point(22, 28)
        Me.rdoMB.Name = "rdoMB"
        Me.rdoMB.Size = New System.Drawing.Size(60, 17)
        Me.rdoMB.TabIndex = 7
        Me.rdoMB.TabStop = True
        Me.rdoMB.Text = "Daimler"
        Me.rdoMB.UseVisualStyleBackColor = True
        '
        'clsVExportSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 231)
        Me.Controls.Add(Me.grpCustomer)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.ToolStrip)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "clsVExportSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export to File"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.grpSelection.ResumeLayout(False)
        Me.grpSelection.PerformLayout()
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents grpSelection As OPE_Controls.OpeGroupBox
    Friend WithEvents rdoOverviewOnlyPDF As OPE_Controls.OpeRadioButton
    Friend WithEvents rdoOverviewOnlyExcel As OPE_Controls.OpeRadioButton
    Friend WithEvents rdoAllPageExcel As OPE_Controls.OpeRadioButton
    Friend WithEvents btnOK As OPE_Controls.OpeButtonStrip
    Friend WithEvents grpCustomer As OPE_Controls.OpeGroupBox
    Friend WithEvents rdoBMW As OPE_Controls.OpeRadioButton
    Friend WithEvents rdoMB As OPE_Controls.OpeRadioButton
End Class
