Imports System.Xml
Imports System.IO


''' <summary>Extrae las cadenas de traducción de un fichero XML.</summary>
Public Class XmlParser
    ''' <summary>Indica un elemento de idioma</summary>
    Private Const ELEMENTO As String = "tag"
    ''' <summary>Nombre del atributo clave del elemento.</summary>
    Private Const AT_CLAVE As String = "clave"
    ''' <summary>Nombre del atributo valor del elemento.</summary>
    Private Const AT_VALOR As String = "valor"


    ''' <summary>Carga el diccionario de idioma actual.</summary>
    ''' <param name="dicIdioma">Diccionario de idioma a cargar</param>
    ''' <param name="sValores">Cadena con los datos</param>
    Public Shared Sub cargar(ByRef dicIdioma As Dictionary(Of String, String), ByRef sValores As String)
        ' Lector de flujo para cadenas
        Dim objFlujo As New StringReader(sValores)
        ' Lector de XML
        Dim objLector As XmlTextReader = New XmlTextReader(objFlujo)
        ' Elemento actual
        Dim sActual As String
        ' Clave actual
        Dim sClave As String
        ' Valor actual
        Dim sValor As String

        ' Inicializa el diccionario
        dicIdioma.Clear()

        Do While (objLector.Read())
            Try
                ' Analiza el elemento actual.
                If objLector.NodeType = XmlNodeType.Element Then
                    sActual = objLector.Name
                    sClave = String.Empty
                    sValor = String.Empty

                    ' Si hay atributos se mira si está en un elemento tag.
                    If objLector.HasAttributes And sActual = ELEMENTO Then
                        While objLector.MoveToNextAttribute()
                            If objLector.Name = "clave" Then
                                sClave = objLector.Value
                            ElseIf objLector.Name = "valor" Then
                                sValor = objLector.Value
                            End If

                            If Not dicIdioma.ContainsKey(sClave) And sValor.Length > 0 Then
                                dicIdioma.Add(sClave, sValor)
                            End If
                        End While
                    End If
                End If
            Catch e As Exception
            End Try
        Loop
    End Sub
End Class
