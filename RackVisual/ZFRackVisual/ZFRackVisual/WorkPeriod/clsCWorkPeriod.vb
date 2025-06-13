Imports OPE_Controls.OpeStyle
Imports ZFRackVisual.CustomizeSetting
Imports System.IO

Public Class clsCWorkPeriod
    Private MstPeriodPath As String = Info.ProjectPath & "\MasterFile\"
    Private MstPeriodFileZF As String = "MasterPeriodZF.csv"
    Private MstPeriodFileCus As String = "MasterPeriodCus.csv"
    Private MstDeliveryTimeZF As String = "MasterDeliZF.csv"
    Private MstDeliveryTimeCus As String = "MasterDeliCus.csv"

    Public Function getMasterTime(ByVal fZF As Boolean) As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("Period", GetType(String))
        dt.Columns.Add("Start", GetType(String))
        dt.Columns.Add("Stop", GetType(String))

        Dim MstFile As String = IIf(fZF = True, MstPeriodFileZF, MstPeriodFileCus)

        Dim Err As New ZFRackVisual.EventArgs
        Dim oINI As ArrayList = ComboSet.ReadTextFileList(Err, MstPeriodPath & MstFile)
        If Not oINI Is Nothing Then
            For Each sINI As String In oINI
                Dim aINI() As String = sINI.Split(",")
                If aINI.Length <> 3 Then Continue For

                Dim sPeriod As String = aINI(0)
                Dim sStart As String = aINI(1)
                Dim sStop As String = aINI(2)

                If IsNumeric(sPeriod) Then
                    Dim drAdd As DataRow = dt.NewRow
                    drAdd("Period") = sPeriod
                    drAdd("Start") = sStart
                    drAdd("Stop") = sStop
                    dt.Rows.Add(drAdd)
                End If
            Next
        End If

        If dt.Rows.Count = 0 Then
            Dim drAdd As DataRow
            drAdd = dt.NewRow
            drAdd("Period") = 1
            drAdd("Start") = "08.00"
            drAdd("Stop") = "10.00"
            dt.Rows.Add(drAdd)

            drAdd = dt.NewRow
            drAdd("Period") = 2
            drAdd("Start") = "10.10"
            drAdd("Stop") = "12.00"
            dt.Rows.Add(drAdd)

            drAdd = dt.NewRow
            drAdd("Period") = 3
            drAdd("Start") = "13.00"
            drAdd("Stop") = "15.00"
            dt.Rows.Add(drAdd)

            drAdd = dt.NewRow
            drAdd("Period") = 4
            drAdd("Start") = "15.10"
            drAdd("Stop") = "17.30"
            dt.Rows.Add(drAdd)
        End If

        Return dt
    End Function

    Public Function getMasterDeliveryTime(ByVal fZF As Boolean) As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("Period", GetType(String))
        dt.Columns.Add("Time", GetType(String))

        Dim MstFile As String = IIf(fZF = True, MstDeliveryTimeZF, MstDeliveryTimeCus)

        Dim Err As New ZFRackVisual.EventArgs
        Dim oINI As ArrayList = ComboSet.ReadTextFileList(Err, MstPeriodPath & MstFile)
        If Not oINI Is Nothing Then
            For Each sINI As String In oINI
                Dim aINI() As String = sINI.Split(",")
                If aINI.Length <> 2 Then Continue For

                Dim sPeriod As String = aINI(0)
                Dim sDeliveryTime As String = aINI(1)

                If IsNumeric(sPeriod) Then
                    Dim drAdd As DataRow = dt.NewRow
                    drAdd("Period") = sPeriod
                    drAdd("Time") = sDeliveryTime
                    dt.Rows.Add(drAdd)
                End If
            Next
        End If

        If dt.Rows.Count = 0 Then
            Dim drAdd As DataRow
            drAdd = dt.NewRow
            drAdd("Period") = 1
            drAdd("Time") = "08.00"
            dt.Rows.Add(drAdd)

            drAdd = dt.NewRow
            drAdd("Period") = 2
            drAdd("Time") = "10.10"
            dt.Rows.Add(drAdd)

            drAdd = dt.NewRow
            drAdd("Period") = 3
            drAdd("Time") = "13.00"
            dt.Rows.Add(drAdd)

            drAdd = dt.NewRow
            drAdd("Period") = 4
            drAdd("Time") = "15.10"
            dt.Rows.Add(drAdd)
        End If

        Return dt
    End Function

    Public Sub WriteMstPeriod(ByVal dt As DataTable, ByVal fZF As Boolean)
        Try
            Dim MstPeriodFile As String = IIf(fZF = True, MstPeriodFileZF, MstPeriodFileCus)

            If Directory.Exists(MstPeriodPath) = False Then
                Directory.CreateDirectory(MstPeriodPath)
            End If
            If File.Exists(MstPeriodPath & MstPeriodFile) Then
                File.Delete(MstPeriodPath & MstPeriodFile)
            End If

            Dim RCHCmd As New FileStream(MstPeriodPath & MstPeriodFile, FileMode.OpenOrCreate, FileAccess.Write)
            Dim RCHCmdW As New StreamWriter(RCHCmd)

            Dim str As String = "Period,Start,Stop"
            RCHCmdW.WriteLine(str)

            For Each dr As DataRow In dt.Rows
                str = dr("Period")
                str &= "," & dr("Start")
                str &= "," & dr("Stop")
                RCHCmdW.WriteLine(str)
            Next
            RCHCmdW.Close()
            RCHCmd.Close()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub WriteMstDelivery(ByVal dt As DataTable, ByVal fZF As Boolean)
        Try
            Dim MstFile As String = IIf(fZF = True, MstDeliveryTimeZF, MstDeliveryTimeCus)

            If Directory.Exists(MstPeriodPath) = False Then
                Directory.CreateDirectory(MstPeriodPath)
            End If
            If File.Exists(MstPeriodPath & MstFile) Then
                File.Delete(MstPeriodPath & MstFile)
            End If

            Dim RCHCmd As New FileStream(MstPeriodPath & MstFile, FileMode.OpenOrCreate, FileAccess.Write)
            Dim RCHCmdW As New StreamWriter(RCHCmd)

            Dim str As String = "Period,Time"
            RCHCmdW.WriteLine(str)

            For Each dr As DataRow In dt.Rows
                str = dr("Period")
                str &= "," & dr("Time")
                RCHCmdW.WriteLine(str)
            Next
            RCHCmdW.Close()
            RCHCmd.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class
