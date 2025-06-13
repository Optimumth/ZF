'--------------------------------------------------------------------
' FILENAME: API.cs
'
' Copyright ฉ 2011 Motorola Solutions, Inc. All rights reserved.
'
' DESCRIPTION: Implements the code which communicates with the 
'					EMDK for .NET scanner API - Symbol.Barcode2.
'
' NOTES:
'
' 
'--------------------------------------------------------------------

Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports Symbol.Barcode2

''' <summary>
''' The namespace for CS_Barcode2Sample1.
''' </summary>
Namespace ZFPKCtrl

    ''' <summary>
    ''' The class which communicates with the EMDK for .NET scanner API 
    ''' - Symbol.Barcode2. 
    ''' </summary>
    Friend Class API
        Private myBarcode2 As Barcode2 = Nothing

        ''' <summary>
        ''' Initialize the Barcode2 object.
        ''' </summary>
        Public Function InitBarcode() As Boolean
            ' If the Barcode2 object is already initialized then fail the initialization.
            If myBarcode2 IsNot Nothing Then
                Return False
            Else ' Else initialize the reader.
                Try
                    ' Get the device selected by the user.
                    Dim MyDevice As Device = SelectDevice.Select("Barcode", Symbol.Barcode2.Devices.SupportedDevices)

                    If MyDevice Is Nothing Then
                        MessageBox.Show(Resources.GetString("NoDeviceSelected"), Resources.GetString("SelectDevice"))
                        Return False
                    End If

                    ' Create the reader, based on selected device.
                    myBarcode2 = New Barcode2(MyDevice)

                    ' In this sample, we are setting the aim type to trigger. 
                    Select Case myBarcode2.Config.Reader.ReaderType
                        Case READER_TYPES.READER_TYPE_IMAGER
                            myBarcode2.Config.Reader.ReaderSpecific.ImagerSpecific.AimType = AIM_TYPE.AIM_TYPE_TRIGGER
                        Case READER_TYPES.READER_TYPE_LASER
                            myBarcode2.Config.Reader.ReaderSpecific.LaserSpecific.AimType = AIM_TYPE.AIM_TYPE_TRIGGER
                    End Select
                    myBarcode2.Config.Reader.Set()

                Catch ex As OperationFailureException
                    MessageBox.Show(Resources.GetString("InitBarcode") & vbLf & Resources.GetString("OperationFailure") & vbLf & ex.Message & vbLf & Resources.GetString("Result") & " = " & CType(ex.Result, Results).ToString())
                    Return False
                Catch ex As InvalidRequestException
                    MessageBox.Show(Resources.GetString("InitBarcode") & vbLf & Resources.GetString("InvalidRequest") & vbLf & ex.Message)

                    Return False
                Catch ex As InvalidIndexerException
                    MessageBox.Show(Resources.GetString("InitBarcode") & vbLf & Resources.GetString("InvalidIndexer") & vbLf & ex.Message)

                    Return False
                End Try

                Return True
            End If
        End Function

        ''' <summary>
        ''' Stop reading and disable/close the Barcode2 object.
        ''' </summary>
        Public Sub TermBarcode()
            ' If we have a reader
            If myBarcode2 IsNot Nothing Then
                Try
                    ' stop all the notifications.
                    StopScan()

                    ' Free it up.
                    myBarcode2.Dispose()

                    ' Make the reference null.
                    myBarcode2 = Nothing

                Catch ex As OperationFailureException
                    MessageBox.Show(Resources.GetString("TermBarcode") & vbLf & Resources.GetString("OperationFailure") & vbLf & ex.Message & vbLf & Resources.GetString("Result") & " = " & CType(ex.Result, Results).ToString())
                Catch ex As InvalidRequestException
                    MessageBox.Show(Resources.GetString("TermBarcode") & vbLf & Resources.GetString("InvalidRequest") & vbLf & ex.Message)
                Catch ex As InvalidIndexerException
                    MessageBox.Show(Resources.GetString("TermBarcode") & vbLf & Resources.GetString("InvalidIndexer") & vbLf & ex.Message)
                End Try
            End If
        End Sub

        ''' <summary>
        ''' Start a scan.
        ''' </summary>
        Public Sub StartScan(ByVal TriggerSoftAlways As Boolean)
            If myBarcode2 IsNot Nothing Then
                Try

                    If TriggerSoftAlways Then
                        If myBarcode2.Config.TriggerMode <> TRIGGERMODES.SOFT_ALWAYS Then
                            myBarcode2.Config.TriggerMode = TRIGGERMODES.SOFT_ALWAYS
                        End If
                    Else
                        myBarcode2.Config.TriggerMode = TRIGGERMODES.HARD
                    End If

                    'By default, the assemly Symbol.Barcode2 will decode the barcodes whose data length is less than or equal to 55.
                    'The user will have to increase ScanDataSize in order to get any longer lengths decoded.
                    myBarcode2.Config.ScanDataSize = Symbol.Barcode2.ReaderDataLengths.MaximumLabel
                    ' Submit a scan.
                    myBarcode2.Scan(5000)

                Catch ex As Symbol.Exceptions.OperationFailureException
                    MessageBox.Show(Resources.GetString("StartScan") & vbLf & Resources.GetString("OperationFailure") & vbLf & ex.Message & vbLf & Resources.GetString("Result") & " = " & CType(ex.Result, Results).ToString())
                Catch ex As Symbol.Exceptions.InvalidRequestException
                    MessageBox.Show(Resources.GetString("StartScan") & vbLf & Resources.GetString("InvalidRequest") & vbLf & ex.Message)

                Catch ex As Symbol.Exceptions.InvalidIndexerException
                    MessageBox.Show(Resources.GetString("StartScan") & vbLf & Resources.GetString("InvalidIndexer") & vbLf & ex.Message)

                End Try
            End If
        End Sub

        ''' <summary>
        ''' Stop all reads on the reader.
        ''' </summary>
        Public Sub StopScan()
            'If we have a reader
            If myBarcode2 IsNot Nothing Then
                Try
                    ' Flush (Cancel all pending reads).
                    myBarcode2.ScanCancel()

                Catch ex As OperationFailureException
                    MessageBox.Show(Resources.GetString("StopScan") & vbLf & Resources.GetString("OperationFailure") & vbLf & ex.Message & vbLf & Resources.GetString("Result") & " = " & CType(ex.Result, Results).ToString())
                Catch ex As InvalidRequestException
                    MessageBox.Show(Resources.GetString("StopScan") & vbLf & Resources.GetString("InvalidRequest") & vbLf & ex.Message)
                Catch ex As InvalidIndexerException
                    MessageBox.Show(Resources.GetString("StopScan") & vbLf & Resources.GetString("InvalidIndexer") & vbLf & ex.Message)
                End Try
            End If
        End Sub

        ''' <summary>
        ''' Provides the access to the Symbol.Barcode.Reader reference.
        ''' The user can use this reference for his additional Reader - related operations.
        ''' </summary>
        Public ReadOnly Property Barcode2() As Barcode2
            Get
                Return myBarcode2
            End Get
        End Property

        ''' <summary>
        ''' Attach a ScanNotify handler.
        ''' </summary>
        Public Sub AttachScanNotify(ByVal ScanNotifyHandler As Barcode2.OnScanHandler)
            ' If we have a reader
            If myBarcode2 IsNot Nothing Then
                ' Attach the read notification handler.
                AddHandler myBarcode2.OnScan, ScanNotifyHandler
            End If

        End Sub

        ''' <summary>
        ''' Detach the ScanNotify handler.
        ''' </summary>
        Public Sub DetachScanNotify(ByVal ScanNotifyHandler As Barcode2.OnScanHandler)
            If myBarcode2 IsNot Nothing Then
                ' Detach the read notification handler.
                RemoveHandler myBarcode2.OnScan, ScanNotifyHandler
            End If
        End Sub

        ''' <summary>
        ''' Attach a StatusNotify handler.
        ''' </summary>
        Public Sub AttachStatusNotify(ByVal StatusNotifyHandler As Barcode2.OnStatusHandler)
            ' If we have a reader
            If myBarcode2 IsNot Nothing Then
                ' Attach status notification handler.
                AddHandler myBarcode2.OnStatus, StatusNotifyHandler
            End If
        End Sub

        ''' <summary>
        ''' Detach a StatusNotify handler.
        ''' </summary>
        Public Sub DetachStatusNotify(ByVal StatusNotifyHandler As Barcode2.OnStatusHandler)
            ' If we have a reader registered for receiving the status notifications
            If myBarcode2 IsNot Nothing Then
                ' Detach the status notification handler.
                RemoveHandler myBarcode2.OnStatus, StatusNotifyHandler
            End If
        End Sub

    End Class

End Namespace
