''' <summary>Clase que contiene diversas utilidades.</summary>
Public Class Utilidades
    ''' <summary>
    ''' Convierte una cadena a un valor decimal. Para ello analiza si el separador de decimales
    ''' es el valor utilizado actualmente. Si no lo es, lo remplaza.
    ''' </summary>
    ''' <param name="sCadena">Cadena de la que obtener el valor decimal</param>
    ''' <returns>Valor decimal convertido</returns>
    Public Shared Function cadToDecimal(ByRef sCadena As String) As Decimal
        Dim dDecimal As Decimal = 0
        If Not sCadena Is Nothing Then
            Try
                If My.Application.Culture.NumberFormat.NumberDecimalSeparator.Equals(",") Then
                    If sCadena.Contains(".") Then
                        dDecimal = Decimal.Parse(sCadena.Replace(".", ","))
                    Else
                        dDecimal = Decimal.Parse(sCadena)
                    End If
                Else
                    If sCadena.Contains(",") Then
                        dDecimal = Decimal.Parse(sCadena.Replace(",", "."))
                    Else
                        dDecimal = Decimal.Parse(sCadena)
                    End If
                End If
            Catch ex As InvalidCastException
            End Try
        End If

        Return dDecimal
    End Function


    ''' <summary>
    ''' Convierte un valor decimal a una cadena. Para ello analiza si el separador de decimales
    ''' es el valor utilizado actualmente. Si no lo es, lo remplaza.
    ''' </summary>
    ''' <param name="dDecimal">Valor decimal del que obtener la cadena</param>
    ''' <returns>Valor decimal convertido</returns>
    Public Shared Function decimalToCad(ByVal dDecimal As Decimal) As String
        Dim sValor As String = "0"
        sValor = Format(dDecimal, "0.0000").ToString
        If My.Application.Culture.NumberFormat.NumberDecimalSeparator.Equals(",") And sValor.Contains(",") Then
            sValor = sValor.Replace(",", ".")
        End If

        Return sValor
    End Function
End Class
