Imports BarcodeSystem.Barcode_System
Public Class SoundEff
    Declare Function PlaySound Lib "coredll.dll" (ByVal pszSound As String, ByVal hMod As IntPtr, ByVal sf As SoundFlags) As Boolean

    Public Shared Sub ErrorMsg(ByVal Msg As String, Optional ByVal Msg2 As String = "")
        Dim frm As New S_MsgBox(Msg & vbCrLf & Msg2, , , , , "ErrorMsg")
        frm.ShowDialog()
    End Sub
    Public Shared Function AlertMsg(ByVal Msg As String, Optional ByVal Msg2 As String = "") As Boolean
        Dim frmD As New S_MsgBoxResult(Msg & vbCrLf & Msg2, , "AlertMsg")
        If frmD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Sub AlertMsgCoplete(ByVal Msg As String, Optional ByVal Msg2 As String = "")
        Dim frm As New S_MsgBox(Msg & vbCrLf & Msg2, , , , , "MsgCoplete")
        frm.ShowDialog()
    End Sub
    Public Shared Function ShortageMsg(ByVal Msg As String, Optional ByVal Msg2 As String = "", Optional ByVal OKButton As String = "") As Boolean
        Dim frmD As New S_MsgBoxResult(Msg & vbCrLf & Msg2, OKButton, "ShortageMsg")
        If frmD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Sub AddSoundFinish()
        Call PlaySound(P_Sys.PahtSound & "\" & P_Sys.DownUpSound & ".wav", IntPtr.Zero, SoundFlags.SND_SYNC)
    End Sub
    'Public Shared Sub AddSoundNextPicking()
    '    Call PlaySound(P_Sys.PahtSound & "\OK.wav", IntPtr.Zero, SoundFlags.SND_SYNC)
    'End Sub
End Class
