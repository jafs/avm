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


    ''' <summary>Cambia el estilo de un control a activo o inactivo.</summary>
    ''' <param name="objControl">Control a modificar</param>
    ''' <param name="bActivo">Indica si será activado o desactivado</param>
    Public Shared Sub cambiarEstilo(ByRef objControl As Control, ByRef bActivo As Boolean)
        If Not objControl Is Nothing Then
            If bActivo Then
                objControl.ForeColor = Plantilla.ColorFondo
            Else
                objControl.ForeColor = Color.FromArgb(250, 250, 250)
            End If
        End If
    End Sub


    Public Shared Sub addControl(ByRef objControl As Control)
        If Not objControl Is Nothing Then
            AddHandler objControl.MouseEnter, AddressOf activarControl
            AddHandler objControl.MouseLeave, AddressOf desactivarControl
        End If
    End Sub


    Private Shared Sub activarControl(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Utilidades.cambiarEstilo(CType(sender, Control), True)
    End Sub

    Private Shared Sub desactivarControl(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Utilidades.cambiarEstilo(CType(sender, Control), False)
    End Sub
End Class
