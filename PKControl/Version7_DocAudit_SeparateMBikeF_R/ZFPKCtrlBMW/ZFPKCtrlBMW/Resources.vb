'--------------------------------------------------------------------
' FILENAME: Resources.cs
'
' Copyright ฉ 2011 Motorola Solutions, Inc. All rights reserved.
'
' DESCRIPTION:
'
' NOTES:
'
' 
'--------------------------------------------------------------------
Imports System
Imports System.Globalization
Imports System.Resources


Namespace ZFPKCtrlBMW
    Friend Class Resources
        Private Shared m_rmNameValues As System.Resources.ResourceManager

        Shared Sub New()
            m_rmNameValues = New System.Resources.ResourceManager("ZFPKCtrlBMW.Resources", GetType(Resources).Assembly)
        End Sub

        Public Shared Function GetString(ByVal name As String) As String
            Return m_rmNameValues.GetString(name)
        End Function
    End Class
End Namespace