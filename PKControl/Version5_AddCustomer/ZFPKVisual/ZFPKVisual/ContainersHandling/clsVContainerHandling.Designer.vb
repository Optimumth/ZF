<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clsVContainerHandling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clsVContainerHandling))
        Me.ButtonBoxH = New OPE_Controls.OpeButtonBox()
        Me.btnSearch = New OPE_Controls.OpeButtonSearch()
        Me.OpeButtonPrint1 = New OPE_Controls.OpeButtonPrint()
        Me.StatusBox = New OPE_Controls.OpeStatusBox()
        Me.grpSearchCondition = New OPE_Controls.OpeGroupBox()
        Me.lblOutLogPath = New OPE_Controls.OpeLabel(Me.components)
        Me.dtpDate1 = New OPE_Controls.OpeDateTime(Me.components)
        Me.btnLogo = New System.Windows.Forms.ToolStripButton()
        Me.ButtonBoxH.SuspendLayout()
        Me.grpSearchCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonBoxH
        '
        Me.ButtonBoxH.ButtonBoxMain = Nothing
        Me.ButtonBoxH.EntryBox = Nothing
        Me.ButtonBoxH.GridData = Nothing
        Me.ButtonBoxH.GridDataTree = Nothing
        Me.ButtonBoxH.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSearch, Me.OpeButtonPrint1, Me.btnLogo})
        Me.ButtonBoxH.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBoxH.Name = "ButtonBoxH"
        Me.ButtonBoxH.Size = New System.Drawing.Size(982, 57)
        Me.ButtonBoxH.StatusBox = Nothing
        Me.ButtonBoxH.TabIndex = 6
        Me.ButtonBoxH.Text = "OpeButtonBox1"
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.IsWaitThread = False
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(36, 54)
        Me.btnSearch.Text = "Search"
        Me.btnSearch.ToolTipText = "Search"
        '
        'OpeButtonPrint1
        '
        Me.OpeButtonPrint1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpeButtonPrint1.EnableOnly = False
        Me.OpeButtonPrint1.Image = CType(resources.GetObject("OpeButtonPrint1.Image"), System.Drawing.Image)
        Me.OpeButtonPrint1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpeButtonPrint1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpeButtonPrint1.Name = "OpeButtonPrint1"
        Me.OpeButtonPrint1.Size = New System.Drawing.Size(36, 54)
        Me.OpeButtonPrint1.Text = "Print"
        Me.OpeButtonPrint1.ToolTipText = "Print"
        '
        'StatusBox
        '
        Me.StatusBox.IsEditMode = False
        Me.StatusBox.Location = New System.Drawing.Point(0, 571)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.ProgressValue = 0
        Me.StatusBox.Size = New System.Drawing.Size(982, 22)
        Me.StatusBox.TabIndex = 7
        Me.StatusBox.Text = "OpeStatusBox1"
        '
        'grpSearchCondition
        '
        Me.grpSearchCondition.Controls.Add(Me.lblOutLogPath)
        Me.grpSearchCondition.Controls.Add(Me.dtpDate1)
        Me.grpSearchCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearchCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCondition.Location = New System.Drawing.Point(0, 57)
        Me.grpSearchCondition.Name = "grpSearchCondition"
        Me.grpSearchCondition.Padding = New System.Windows.Forms.Padding(6, 0, 10, 6)
        Me.grpSearchCondition.Size = New System.Drawing.Size(982, 95)
        Me.grpSearchCondition.TabIndex = 8
        Me.grpSearchCondition.TabStop = False
        Me.grpSearchCondition.Text = "Search Condition"
        '
        'lblOutLogPath
        '
        Me.lblOutLogPath.AutoSize = True
        Me.lblOutLogPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblOutLogPath.LabelId = 0
        Me.lblOutLogPath.Location = New System.Drawing.Point(48, 40)
        Me.lblOutLogPath.Name = "lblOutLogPath"
        Me.lblOutLogPath.Size = New System.Drawing.Size(66, 17)
        Me.lblOutLogPath.TabIndex = 20
        Me.lblOutLogPath.Text = "Log Date"
        '
        'dtpDate1
        '
        Me.dtpDate1.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate1.HideButton = False
        Me.dtpDate1.LinkCheckedBox = Nothing
        Me.dtpDate1.LinkDateTime = Nothing
        Me.dtpDate1.Location = New System.Drawing.Point(175, 35)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(93, 23)
        Me.dtpDate1.TabIndex = 19
        Me.dtpDate1.TextValue = "20180530"
        Me.dtpDate1.Value = New Date(2018, 5, 30, 0, 0, 0, 0)
        '
        'btnLogo
        '
        Me.btnLogo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLogo.Image = Global.ZFPKVisual.My.Resources.Resources.StateBMW
        Me.btnLogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLogo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(54, 54)
        Me.btnLogo.Text = "ToolStripButton1"
        '
        'clsVContainerHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 593)
        Me.Controls.Add(Me.grpSearchCondition)
        Me.Controls.Add(Me.StatusBox)
        Me.Controls.Add(Me.ButtonBoxH)
        Me.Name = "clsVContainerHandling"
        Me.Text = "clsVContainerHandling"
        Me.ButtonBoxH.ResumeLayout(False)
        Me.ButtonBoxH.PerformLayout()
        Me.grpSearchCondition.ResumeLayout(False)
        Me.grpSearchCondition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonBoxH As OPE_Controls.OpeButtonBox
    Friend WithEvents btnSearch As OPE_Controls.OpeButtonSearch
    Friend WithEvents OpeButtonPrint1 As OPE_Controls.OpeButtonPrint
    Friend WithEvents StatusBox As OPE_Controls.OpeStatusBox
    Friend WithEvents grpSearchCondition As OPE_Controls.OpeGroupBox
    Friend WithEvents lblOutLogPath As OPE_Controls.OpeLabel
    Friend WithEvents dtpDate1 As OPE_Controls.OpeDateTime
    Friend WithEvents btnLogo As System.Windows.Forms.ToolStripButton
End Class
