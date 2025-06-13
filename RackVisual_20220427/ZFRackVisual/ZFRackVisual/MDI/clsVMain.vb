Imports System.Windows.Forms

Public Class clsVMain
    Private Sub btnWorkingPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWorkingPeriod.Click
        With clsVWorkPeriod
            If Application.OpenForms().OfType(Of clsVWorkPeriod).Any Then
                .Activate()
            Else
                .MdiParent = Me
                .Show()
            End If
        End With
    End Sub

    Private Sub btnSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchedule.Click
        With clsVSchedule
            If Application.OpenForms().OfType(Of clsVSchedule).Any Then
                .Activate()
            Else
                .MdiParent = Me
                .Show()
            End If
        End With
    End Sub
End Class
