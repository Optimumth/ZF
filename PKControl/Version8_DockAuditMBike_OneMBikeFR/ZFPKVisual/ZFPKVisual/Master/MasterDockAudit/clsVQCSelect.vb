Imports OPE_Controls.OpeStyle
Imports ZFPKVisual.CustomizeSetting

Public Class clsVQCSelect
    Public CheckID As Integer
    Public FormatID As Integer
    Public AreaCode As String


    Private Sub clsVQCSelect_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        txtAreaCode.Text = AreaCode
        txtCheckNumber.Text = CheckID
        With cboFormatID
            .ValueMember = "FormatID"
            .DisplayMember = "FormatID"
            If AreaCode = "F" Then
                .DataSource = DataBase.DataTable("select * from MstQC where CheckID=" & CheckID & " and FrontFlag=1 and DelFlag=0 order by FormatID")
            Else
                .DataSource = DataBase.DataTable("select * from MstQC where CheckID=" & CheckID & " and RearFlag=1 and DelFlag=0 order by FormatID")
            End If
            .SelectedValue = FormatID
        End With
    End Sub

    Private Sub cboFormatID_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboFormatID.SelectedValueChanged
        If cboFormatID.SelectedRow Is Nothing Then Exit Sub
        Dim dr As DataRow = cboFormatID.SelectedRow
        txtDesc1.Text = dr("Desc1")
        txtDesc2.Text = dr("Desc2")
        txtDesc3.Text = dr("Desc3")
        txtRemark.Text = dr("Remark")
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As OPE_Controls.EventArgs) Handles btnOK.Click
        If cboFormatID.SelectedIndex < 0 Then Exit Sub
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
End Class