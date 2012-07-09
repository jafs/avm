﻿''' <summary>Clase que contiene información de una llamada.</summary>
Public Class Llamada
    ''' <summary>Enumeración con los tipos de llamada.</summary>
    Public Enum TipoLlamada
        ''' <summary>Llamada entrante.</summary>
        inbound
        ''' <summary>Llamada saliente.</summary>
        outbound
    End Enum

    ''' <summary>Enumeración con el estado de las llamadas.</summary>
    Public Enum EstadoLlamada
        ''' <summary>Estado desconocido.</summary>
        unknown
        ''' <summary>Llamada entrante.</summary>
        incoming
        ''' <summary>Llamada activa.</summary>
        active
        ''' <summary>Llamada en espera.</summary>
        held
        ''' <summary>Llamando a destinatario.</summary>
        ringing
    End Enum

    ''' <summary>Número de teléfono.</summary>
    Private sNumero As String
    ''' <summary>Tipo de llamada.</summary>
    Private eTipo As TipoLlamada
    ''' <summary>Estado de la llamada.</summary>
    Private eEstado As EstadoLlamada
    ''' <summary>Array con el carácter de separación.</summary>
    Private arcChar() As String = {" "}


    ''' <summary>
    ''' Tipo de llamada actual.
    ''' </summary>
    ''' <value>Tipo de llamada.</value>
    ''' <returns>Devuelve el tipo de llamada.</returns>
    Public Property Tipo() As TipoLlamada
        Get
            Return eTipo
        End Get
        Set(ByVal eTipoR As TipoLlamada)
            eTipo = eTipoR
        End Set
    End Property


    ''' <summary>
    ''' Estado de la llamada actual.
    ''' </summary>
    ''' <value>Estado de la llamada.</value>
    ''' <returns>Devuelve el estado de la llamada.</returns>
    Public Property Estado() As EstadoLlamada
        Get
            Return eEstado
        End Get
        Set(ByVal eEstadoR As EstadoLlamada)
            eEstado = eEstadoR
        End Set
    End Property


    ''' <summary>
    ''' Estado de la llamada actual.
    ''' </summary>
    ''' <value>Estado de la llamada.</value>
    ''' <returns>Devuelve el estado de la llamada.</returns>
    Public Property Numero() As String
        Get
            Return sNumero
        End Get
        Set(ByVal sNumeroR As String)
            sNumero = sNumeroR
        End Set
    End Property


    ''' <summary>
    ''' Obtiene la imagen correspondiente al tipo de llamada.
    ''' </summary>
    ''' <returns>Imagen que representa el tipo de llamada actual.</returns>
    Public Function getTipoBitmap() As Bitmap
        Dim bmpImagen As Bitmap = Nothing

        If eTipo = TipoLlamada.inbound Then
            bmpImagen = My.Resources.outbound16
        Else
            bmpImagen = My.Resources.inbound16
        End If

        Return bmpImagen
    End Function


    ''' <summary>
    ''' Obtiene la imagen correspondiente al estado de la llamada.
    ''' </summary>
    ''' <returns>Imagen que representa el estado de la llamada actual.</returns>
    Public Function getEstadoBitmap() As Bitmap
        Dim bmpImagen As Bitmap = Nothing

        Select Case eEstado
            Case EstadoLlamada.active
                bmpImagen = My.Resources.gsm_active16
            Case EstadoLlamada.held
                bmpImagen = My.Resources.gsm_held16
            Case Else
                bmpImagen = My.Resources.gsm_incoming16
        End Select

        Return bmpImagen
    End Function


    ''' <summary>
    ''' Obtiene el array de datos con la información de llamada.
    ''' </summary>
    ''' <returns>Array de datos informativo.</returns>
    Public Function toArray() As Object()
        Dim aroDatos(7) As Object

        aroDatos(0) = getTipoBitmap()
        aroDatos(1) = getEstadoBitmap()
        aroDatos(2) = sNumero
        aroDatos(3) = eTipo.ToString
        aroDatos(4) = eEstado.ToString
        Select Case eEstado
            Case EstadoLlamada.active
                aroDatos(5) = My.Resources.gsm_hold16
            Case EstadoLlamada.held
                aroDatos(5) = My.Resources.gsm_accept16
            Case Else
                aroDatos(5) = My.Resources.gsm_incoming_status16
        End Select

        If eTipo = TipoLlamada.outbound Then
            aroDatos(6) = My.Resources.gsm_busy16
        Else
            aroDatos(6) = My.Resources.gsm_incoming_status16
        End If
        aroDatos(7) = My.Resources.gsm_cancel16


        Return aroDatos
    End Function


    ''' <summary>
    ''' Obtiene los valores de la llamada a partir de una cadena recibida.
    ''' </summary>
    ''' <param name="sCadena">Cadena de la que extraer los datos.</param>
    Public Function fromString(ByRef sCadena As String) As Boolean
        Dim bCorrecto As Boolean = False

        ' Separa la cadena por espacios y analizar si tiene las dimensiones correctas.
        If Not sCadena Is Nothing And sCadena.Length > 0 Then
            Dim arsPartes() As String = sCadena.Split(arcChar, System.StringSplitOptions.RemoveEmptyEntries)
            If Not arsPartes Is Nothing And arsPartes.Length = 5 Then
                Try
                    eTipo = DirectCast([Enum].Parse(GetType(TipoLlamada), arsPartes(0)), TipoLlamada)
                    eEstado = DirectCast([Enum].Parse(GetType(EstadoLlamada), arsPartes(4)), EstadoLlamada)
                    sNumero = arsPartes(2)
                    bCorrecto = True
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        End If

        Return bCorrecto
    End Function


    ''' <summary>
    ''' Devuelve una cadena que representa la Llamada actual.
    ''' </summary>
    ''' <returns>Cadena que representa el objeto actual.</returns>
    ''' <remarks></remarks>
    Public Overrides Function ToString() As String
        Return sNumero & ":" & eTipo.ToString & ":" & eEstado.ToString
    End Function

End Class
