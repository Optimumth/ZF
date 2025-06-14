'--------------------------------------------------------------------
' FILENAME: API.vb
'
' Copyright � 2011 Motorola Solutions, Inc. All rights reserved.
'
' DESCRIPTION: Implements the code which communicates with the 
'					EMDK for .NET scanner API - Symbol.Barcode.
'
' NOTES:
'
' 
'--------------------------------------------------------------------
Imports System
Imports System.Windows.Forms

''' <summary>
''' The namespace for VB_BarcodeSample1.
''' </summary>
Namespace ZFPKCtrlBMW

    ''' <summary>
    ''' The class which communicates with the EMDK for .NET scanner API 
    ''' - Symbol.Barcode. 
    ''' </summary>
    Class API

        Private myReader As Symbol.Barcode.Reader = Nothing
        Private myReaderData As Symbol.Barcode.ReaderData = Nothing
        Private myReadNotifyHandler As System.EventHandler = Nothing
        Private myStatusNotifyHandler As System.EventHandler = Nothing

        Public isBackground As Boolean = False 'The flag used to track whether the application is in background or not (in foreground).

        ''' <summary>
        ''' Initialize the reader.
        ''' </summary>
        Public Function InitReader() As Boolean
            ' If the reader is already initialized then fail the initialization.
            If Not (myReader Is Nothing) Then
                Return False
                ' Else initialize the reader.
            Else
                Try
                    ' Get the device selected by the user.
                    Dim MyDevice As Symbol.Generic.Device = Symbol.StandardForms.SelectDevice.Select(Symbol.Barcode.Device.Title, Symbol.Barcode.Device.AvailableDevices)

                    If MyDevice Is Nothing Then
                        MessageBox.Show(Resources.GetString("NoDeviceSelected"), Resources.GetString("SelectDevice"))
                        Return False
                    End If

                    ' Create the reader, based on selected device.
                    myReader = New Symbol.Barcode.Reader(MyDevice)

                    ' Create the reader data.
                    myReaderData = New Symbol.Barcode.ReaderData(Symbol.Barcode.ReaderDataTypes.Text, Symbol.Barcode.ReaderDataLengths.MaximumLabel)

                    ' Enable the Reader.
                    myReader.Actions.Enable()

                    ' In this sample, we are setting the aim type to trigger. 
                    Select Case myReader.ReaderParameters.ReaderType
                        Case Symbol.Barcode.READER_TYPE.READER_TYPE_IMAGER
                            myReader.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Symbol.Barcode.AIM_TYPE.AIM_TYPE_TRIGGER
                        Case Symbol.Barcode.READER_TYPE.READER_TYPE_LASER
                            myReader.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Symbol.Barcode.AIM_TYPE.AIM_TYPE_TRIGGER
                        Case Symbol.Barcode.READER_TYPE.READER_TYPE_CONTACT
                            ' AimType is not supported by the contact readers.
                    End Select
                    myReader.Actions.SetParameters()

                Catch ex As Symbol.Exceptions.OperationFailureException

                    MessageBox.Show((Resources.GetString("InitReader") + vbCrLf _
                    + Resources.GetString("OperationFailure") + vbCrLf _
                    + ex.Message + vbCrLf _
                    + Resources.GetString("Result") + " = " + CType(CType(ex.Result, System.UInt32), Symbol.Results).ToString()))

                    Return False

                Catch ex As Symbol.Exceptions.InvalidRequestException

                    MessageBox.Show((Resources.GetString("InitReader") + vbCrLf _
                    + Resources.GetString("InvalidRequest") + vbCrLf _
                    + ex.Message))

                    Return False
                Catch ex As Symbol.Exceptions.InvalidIndexerException

                    MessageBox.Show((Resources.GetString("InitReader") + vbCrLf _
                    + Resources.GetString("InvalidIndexer") + vbCrLf _
                    + ex.Message))

                    Return False

                End Try

                Return True
            End If
        End Function 'InitReader


        ''' <summary>
        ''' Stop reading and disable/close the reader.
        ''' </summary>
        Public Sub TermReader()
            ' If we have a reader
            If Not (myReader Is Nothing) Then
                Try
                    ' stop all the notifications.
                    StopRead()

                    'Detach all the notification handler if the user has not done it already.
                    DetachReadNotify()
                    DetachStatusNotify()

                    ' Disable the reader.
                    myReader.Actions.Disable()

                    ' Free it up.
                    myReader.Dispose()

                    ' Make the reference null.
                    myReader = Nothing

                Catch ex As Symbol.Exceptions.OperationFailureException

                    MessageBox.Show((Resources.GetString("TermReader") + vbCrLf _
                    + Resources.GetString("OperationFailure") + vbCrLf _
                    + ex.Message + vbCrLf _
                    + Resources.GetString("Result") + " = " + CType(CType(ex.Result, System.UInt32), Symbol.Results).ToString()))

                Catch ex As Symbol.Exceptions.InvalidRequestException

                    MessageBox.Show((Resources.GetString("TermReader") + vbCrLf _
                    + Resources.GetString("InvalidRequest") + vbCrLf _
                    + ex.Message))

                Catch ex As Symbol.Exceptions.InvalidIndexerException

                    MessageBox.Show((Resources.GetString("TermReader") + vbCrLf _
                    + Resources.GetString("InvalidIndexer") + vbCrLf _
                    + ex.Message))

                End Try

            End If

            ' After disposing the reader, dispose the reader data. 
            If Not (myReaderData Is Nothing) Then
                Try
                    ' Free it up.
                    myReaderData.Dispose()

                    ' Make the reference null.
                    myReaderData = Nothing

                Catch ex As Symbol.Exceptions.OperationFailureException

                    MessageBox.Show((Resources.GetString("TermReader") + vbCrLf _
                    + Resources.GetString("OperationFailure") + vbCrLf _
                    + ex.Message + vbCrLf _
                    + Resources.GetString("Result") + " = " + CType(CType(ex.Result, System.UInt32), Symbol.Results).ToString()))

                Catch ex As Symbol.Exceptions.InvalidRequestException

                    MessageBox.Show((Resources.GetString("TermReader") + vbCrLf _
                    + Resources.GetString("InvalidRequest") + vbCrLf _
                    + ex.Message))

                Catch ex As Symbol.Exceptions.InvalidIndexerException

                    MessageBox.Show((Resources.GetString("TermReader") + vbCrLf _
                    + Resources.GetString("InvalidIndexer") + vbCrLf _
                    + ex.Message))

                End Try

            End If
        End Sub 'TermReader


        ''' <summary>
        ''' Start a read on the reader.
        ''' </summary>
        Public Sub StartRead(ByVal toggleSoftTrigger As Boolean)
            ' If we have both a reader and a reader data
            If Not (myReader Is Nothing) And Not (myReaderData Is Nothing) And (isBackground = False) Then

                Try
                    If Not myReaderData.IsPending Then
                        ' Submit a read.
                        myReader.Actions.Read(myReaderData)
                        If ((toggleSoftTrigger = True) And (myReader.Info.SoftTrigger = False)) Then

                            myReader.Info.SoftTrigger = True

                        End If
                    End If

                Catch ex As Symbol.Exceptions.OperationFailureException

                    MessageBox.Show((Resources.GetString("StartRead") + vbCrLf _
                    + Resources.GetString("OperationFailure") + vbCrLf _
                    + ex.Message + vbCrLf _
                    + Resources.GetString("Result") + " = " + CType(CType(ex.Result, System.UInt32), Symbol.Results).ToString()))

                Catch ex As Symbol.Exceptions.InvalidRequestException

                    MessageBox.Show((Resources.GetString("StartRead") + vbCrLf _
                    + Resources.GetString("InvalidRequest") + vbCrLf _
                    + ex.Message))

                Catch ex As Symbol.Exceptions.InvalidIndexerException

                    MessageBox.Show((Resources.GetString("StartRead") + vbCrLf _
                    + Resources.GetString("InvalidIndexer") + vbCrLf _
                    + ex.Message))

                End Try

            End If

        End Sub 'StartRead


        ''' <summary>
        ''' Stop all reads on the reader.
        ''' </summary>
        Public Sub StopRead()
            'If we have a reader
            If Not (myReader Is Nothing) Then
                Try
                    If (myReader.Info.SoftTrigger = True) Then

                        myReader.Info.SoftTrigger = False

                    End If

                    ' Flush (Cancel all pending reads).
                    myReader.Actions.Flush()

                Catch ex As Symbol.Exceptions.OperationFailureException

                    MessageBox.Show((Resources.GetString("StopRead") + vbCrLf _
                    + Resources.GetString("OperationFailure") + vbCrLf _
                    + ex.Message + vbCrLf _
                    + Resources.GetString("Result") + " = " + CType(CType(ex.Result, System.UInt32), Symbol.Results).ToString()))

                Catch ex As Symbol.Exceptions.InvalidRequestException

                    MessageBox.Show((Resources.GetString("StopRead") + vbCrLf _
                    + Resources.GetString("InvalidRequest") + vbCrLf _
                    + ex.Message))

                Catch ex As Symbol.Exceptions.InvalidIndexerException

                    MessageBox.Show((Resources.GetString("StopRead") + vbCrLf _
                    + Resources.GetString("InvalidIndexer") + vbCrLf _
                    + ex.Message))

                End Try
            End If

        End Sub 'StopRead

        ''' <summary>
        ''' Provides the access to the Symbol.Barcode.Reader reference.
        ''' The user can use this reference for his additional Reader - related operations.
        ''' </summary>
        Public ReadOnly Property Reader() As Symbol.Barcode.Reader
            Get
                Return myReader
            End Get
        End Property


        ''' <summary>
        ''' Attach a ReadNotify handler.
        ''' </summary>
        Public Sub AttachReadNotify(ByVal ReadNotifyHandler As System.EventHandler)
            ' If we have a reader
            If Not (myReader Is Nothing) Then
                ' Attach the read notification handler.
                AddHandler myReader.ReadNotify, ReadNotifyHandler
                myReadNotifyHandler = ReadNotifyHandler
            End If
        End Sub 'AttachReadNotify


        ''' <summary>
        ''' Detach the ReadNotify handler.
        ''' </summary>
        Public Sub DetachReadNotify()
            If Not (myReader Is Nothing) And Not (myReadNotifyHandler Is Nothing) Then
                ' Detach the read notification handler.
                RemoveHandler myReader.ReadNotify, myReadNotifyHandler
                myReadNotifyHandler = Nothing
            End If
        End Sub 'DetachReadNotify


        ''' <summary>
        ''' Attach a StatusNotify handler.
        ''' </summary>
        Public Sub AttachStatusNotify(ByVal StatusNotifyHandler As System.EventHandler)
            ' If we have a reader
            If Not (myReader Is Nothing) Then
                ' Attach status notification handler.
                AddHandler myReader.StatusNotify, StatusNotifyHandler
                myStatusNotifyHandler = StatusNotifyHandler
            End If
        End Sub 'AttachStatusNotify


        ''' <summary>
        ''' Detach a StatusNotify handler.
        ''' </summary>
        Public Sub DetachStatusNotify()
            ' If we have a reader registered for receiving the status notifications
            If Not (myReader Is Nothing) And Not (myStatusNotifyHandler Is Nothing) Then
                ' Detach the status notification handler.
                RemoveHandler myReader.StatusNotify, myStatusNotifyHandler
                myStatusNotifyHandler = Nothing
            End If
        End Sub 'DetachStatusNotify
    End Class 'API 
End Namespace 'VB_BarcodeSample1
