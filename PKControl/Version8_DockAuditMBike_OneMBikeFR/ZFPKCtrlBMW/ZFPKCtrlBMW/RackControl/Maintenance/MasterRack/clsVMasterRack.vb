Public Class clsVMasterRack

#Region "Program Active"
    Private Sub clsVMasterRack_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        clsCLogin.ActiveDateTime = Now
    End Sub
    Private Sub clsVMasterRack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        clsCLogin.ActiveDateTime = Now
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        clsCLogin.ActiveDateTime = Now
    End Sub
#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    
End Class