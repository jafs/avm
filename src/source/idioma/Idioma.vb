''' <summary>Clase de obtención de cadenas traducidas.</summary>
Public Class Idioma
    ''' <summary>Idioma por defecto</summary>
    Public Const IDIOMA_DEF As String = "en"

    ''' <summary>Instancia de la clase.</summary>
    Private Shared objInstancia As Idioma = Nothing
    ''' <summary>Diccionario que contiene el par clave-valor para el idioma.</summary>
    Private dicIdioma As New Dictionary(Of String, String)


    ''' <summary>Constructor de la clase.</summary>
    Private Sub New()
        cargar()
    End Sub


    ''' <summary>Realiza la carga del idioma.</summary>
    ''' <remarks>En un futuro recibirá el idioma a cargar.</remarks>
    Private Sub cargar()
        Dim bCargado As Boolean = False
        Dim sIdiomas As New List(Of String)
        sIdiomas.AddRange(My.Resources.sIdiomas.Split(CChar(";")))

        ' Si el idioma existe en la lista de idiomas lo carga
        If sIdiomas.Contains(My.Application.Culture.TwoLetterISOLanguageName.ToLower) Then
            Select Case My.Application.Culture.TwoLetterISOLanguageName.ToLower
                Case "es"
                    XmlParser.cargar(dicIdioma, My.Resources.es)
                    bCargado = True
            End Select
        End If

        ' En caso de no cargase el idioma, carga por defecto Inglés.
        If Not bCargado Then
            XmlParser.cargar(dicIdioma, My.Resources.en)
        End If
    End Sub


    ''' <summary>Obtiene la instancia de la clase.</summary>
    ''' <returns>Instancia de la clase.</returns>
    Private Shared Function getInstancia() As Idioma
        If objInstancia Is Nothing Then
            objInstancia = New Idioma
        End If

        Return objInstancia
    End Function


    ''' <summary>Obtiene la traducción de la clave recibida como parámetro.</summary>
    ''' <param name="sClave">Clave a traducir.</param>
    ''' <returns>Cadena con la traducción.</returns>
    Public Shared Function traducir(ByRef sClave As String) As String
        Return getInstancia.getCadena(sClave)
    End Function


    ''' <summary>Obtiene la cadena de traducción correspondiente a la clave recibida.</summary>
    ''' <param name="sClave">Clave a traducir.</param>
    ''' <returns>Cadena con la traducción.</returns>
    Private Function getCadena(ByRef sClave As String) As String
        Dim sValor As String

        If dicIdioma.ContainsKey(sClave) Then
            sValor = dicIdioma.Item(sClave)
        Else
            sValor = sClave
        End If

        Return sValor
    End Function
End Class

