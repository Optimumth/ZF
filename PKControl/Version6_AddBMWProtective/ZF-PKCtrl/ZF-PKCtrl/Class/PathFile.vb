Imports BarcodeSystem.Barcode_System
Public Class PathFile
    Public Class PathFileAll
        'Public Shared PictureP As String = "\\OPE-douw\11\PicKumonoya\"
        'Public Shared pSrvPath As String = "\\OPE-douw\11\Casio\srv\" 'handy create
        'Public Shared pHdyPath As String = "\\OPE-douw\11\Casio\hdy\"
        'Public Shared pPicPath As String = "\\OPE-douw\11\Casio\pic\"
        'Public Shared psykPath As String = "\\OPE-douw\11\Casio\syk\"
        'Public Shared ptanaPath As String = "\\OPE-douw\11\Casio\tana\"
        'Public Shared pmst As String = "\\OPE-douw\11\Casio\mst"
        'Public Shared pcntPath As String = "\\OPE-douw\11\Casio\cnt\"

        Public Shared PictureP As String = "\\" & P_Sys.ServerName & "\" & P_Sys.PicturePath & "\"
        Public Shared pSrvPath As String = "\\" & P_Sys.ServerName & "\" & P_Sys.IFPath & "\" & P_Sys.srvPath & "\" 'handy create
        Public Shared pHdyPath As String = "\\" & P_Sys.ServerName & "\" & P_Sys.IFPath & "\" & P_Sys.HandyPath & "\"
        Public Shared pPicPath As String = "\\" & P_Sys.ServerName & "\" & P_Sys.IFPath & "\" & P_Sys.PicOdrPath & "\"
        Public Shared psykPath As String = "\\" & P_Sys.ServerName & "\" & P_Sys.IFPath & "\" & P_Sys.PicResPath & "\"
        Public Shared ptanaPath As String = "\\" & P_Sys.ServerName & "\" & P_Sys.IFPath & "\" & P_Sys.ShelfPaht & "\"
        Public Shared pInqPath As String = "\\" & P_Sys.ServerName & "\" & P_Sys.IFPath & "\" & P_Sys.InqPath & "\"
        Public Shared pmst As String = "\\" & P_Sys.ServerName & "\" & P_Sys.IFPath & "\" & P_Sys.MstPath
        Public Shared pcntPath As String = "\\" & P_Sys.ServerName & "\" & P_Sys.IFPath & "\" & P_Sys.CntPath & "\"
    End Class
End Class
