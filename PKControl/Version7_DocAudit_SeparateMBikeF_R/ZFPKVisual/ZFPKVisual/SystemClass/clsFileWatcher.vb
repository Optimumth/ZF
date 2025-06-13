Imports System.IO

Public Class clsFileWatcher
    Private watcher As FileSystemWatcher

    Public Event FileDetected As Action(Of String)

    Public Sub StartWatching(directoryToWatch As String)
        If Not Directory.Exists(directoryToWatch) Then
            Throw New DirectoryNotFoundException("The directory '" & directoryToWatch & "'' does not exist.")
        End If

        watcher = New FileSystemWatcher(directoryToWatch)
        watcher.NotifyFilter = NotifyFilters.FileName Or NotifyFilters.LastWrite

        AddHandler watcher.Created, AddressOf OnChanged
        AddHandler watcher.Changed, AddressOf OnChanged
        AddHandler watcher.Renamed, AddressOf OnRenamed

        watcher.EnableRaisingEvents = True
    End Sub

    Public Sub StopWatching()
        If watcher IsNot Nothing Then
            watcher.EnableRaisingEvents = False
            watcher.Dispose()
        End If
    End Sub

    Private Sub OnChanged(sender As Object, e As FileSystemEventArgs)
        If e.Name.Equals("dockAudit.txt", StringComparison.OrdinalIgnoreCase) Or e.Name.Equals("dockAuditShock.txt", StringComparison.OrdinalIgnoreCase) Then
            RaiseEvent FileDetected(e.FullPath)
        End If
    End Sub

    Private Sub OnRenamed(sender As Object, e As RenamedEventArgs)
        If e.Name.Equals("dockAudit.txt", StringComparison.OrdinalIgnoreCase) Or e.Name.Equals("dockAuditShock.txt", StringComparison.OrdinalIgnoreCase) Then
            RaiseEvent FileDetected(e.FullPath)
        End If
    End Sub
End Class