Imports OPE_Controls.OpeStyle
Imports ZFRackVisual.CustomizeSetting
Imports System.IO

Public Class clsCWorkPeriod
    Private MstPeriodPath As String = Info.ProjectPath & "\MasterFile\"
    Private MstPeriodFile As String = "MasterPeriod.csv"

    Public Function getMasterTime() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("Type", GetType(String))
        dt.Columns.Add("Period", GetType(String))
        dt.Columns.Add("Start", GetType(String))
        dt.Columns.Add("Stop", GetType(String))



        Dim Err As New ZFRackVisual.EventArgs
        Dim oINI As ArrayList = ComboSet.ReadTextFileList(Err, MstPeriodPath & MstPeriodFile)
        If Not oINI Is Nothing Then
            For Each sINI As String In oINI
                Dim aINI() As String = sINI.Split(",")
                If aINI.Length <> 4 Then Continue For

                Dim sType As String = aINI(0)
                Dim sPeriod As String = aINI(1)
                Dim sStart As String = aINI(2)
                Dim sStop As String = aINI(3)

                If sType.Trim.ToLower = "production" Or sType.Trim.ToLower = "zfdelivery" Or sType.Trim.ToLower = "cusreturn" Then
                    Dim drAdd As DataRow = dt.NewRow
                    drAdd("Type") = sType
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
            drAdd("Type") = "Production"
            drAdd("Period") = 1
            drAdd("Start") = "08.00"
            drAdd("Stop") = "12.00"
            dt.Rows.Add(drAdd)

            drAdd = dt.NewRow
            drAdd("Type") = "Production"
            drAdd("Period") = 2
            drAdd("Start") = "13.00"
            drAdd("Stop") = "17.30"
            dt.Rows.Add(drAdd)

            drAdd = dt.NewRow
            drAdd("Type") = "ZFDelivery"
            drAdd("Period") = 1
            drAdd("Start") = "08.59"
            drAdd("Stop") = "11.59"
            dt.Rows.Add(drAdd)

            drAdd = dt.NewRow
            drAdd("Type") = "ZFDelivery"
            drAdd("Period") = 2
            drAdd("Start") = "13.00"
            drAdd("Stop") = "17.30"
            dt.Rows.Add(drAdd)

            drAdd = dt.NewRow
            drAdd("Type") = "CusReturn"
            drAdd("Period") = 1
            drAdd("Start") = "11.00"
            drAdd("Stop") = "17.30"
            dt.Rows.Add(drAdd)
        End If

        Return dt
    End Function

    Public Sub WriteMstPeriod(ByVal dt As DataTable)
        Try
            If Directory.Exists(MstPeriodPath) = False Then
                Directory.CreateDirectory(MstPeriodPath)
            End If
            If File.Exists(MstPeriodPath & MstPeriodFile) Then
                File.Delete(MstPeriodPath & MstPeriodFile)
            End If

            Dim RCHCmd As New FileStream(MstPeriodPath & MstPeriodFile, FileMode.OpenOrCreate, FileAccess.Write)
            Dim RCHCmdW As New StreamWriter(RCHCmd)

            Dim str As String = "Type,Period,Start,Stop"
            RCHCmdW.WriteLine(str)

            For Each dr As DataRow In dt.Rows
                str = dr("Type")
                str &= "," & dr("Period")
                str &= "," & dr("Start")
                str &= "," & dr("Stop")
                RCHCmdW.WriteLine(str)
            Next
            RCHCmdW.Close()
            RCHCmd.Close()

            

        Catch ex As Exception

        End Try
    End Sub
End Class
