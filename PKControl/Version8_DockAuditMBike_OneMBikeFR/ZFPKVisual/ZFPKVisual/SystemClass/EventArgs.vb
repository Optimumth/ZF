Public Class EventArgs
    Inherits OPE_Controls.EventArgs
#Region " DialogResult "
    Public Overrides Property DialogResult() As System.Windows.Forms.DialogResult
        Get
            Return MyBase.DialogResult
        End Get
        Set(ByVal value As System.Windows.Forms.DialogResult)
            MyBase.DialogResult = value
        End Set
    End Property
#End Region
#Region " RowCount "
    Public Overrides Property RowCount() As Integer
        Get
            Return MyBase.RowCount
        End Get
        Set(ByVal value As Integer)
            MyBase.RowCount = value
        End Set
    End Property
#End Region
#Region " Message "
    Public Overrides Property Message() As String
        Get
            Return MyBase.Message
        End Get
        Set(ByVal value As String)
            MyBase.Message = value
        End Set
    End Property
#End Region
#Region " MessageIcon "
    Public Overrides Property MessageIcon() As MessageBoxIcon
        Get
            Return MyBase.MessageIcon
        End Get
        Set(ByVal value As MessageBoxIcon)
            MyBase.MessageIcon = value
        End Set
    End Property
#End Region
#Region " MessageFile "
    Public Overrides Property MessageFile() As String
        Get
            Return MyBase.MessageFile
        End Get
        Set(ByVal value As String)
            MyBase.MessageFile = value
        End Set
    End Property
#End Region
#Region " MessageFolder "
    Public Overrides Property MessageFolder() As String
        Get
            Return MyBase.MessageFolder
        End Get
        Set(ByVal value As String)
            MyBase.MessageFolder = value
        End Set
    End Property
#End Region
End Class
