Public Class Plantilla
    ''' <summary>Color de fondo para los componentes.</summary>
    Private Shared objClrFondo As Color = Color.FromArgb(58, 181, 227)
    ''' <summary>Color del texto.</summary>
    Private Shared objClrTexto As Color = Color.FromArgb(250, 250, 250)

    ''' <summary>Color de fondo para los componentes.</summary>
    ''' <returns>Color de fondo para los componentes.</returns>
    Public Shared ReadOnly Property ColorFondo() As Color
        Get
            Return objClrFondo
        End Get
    End Property

    ''' <summary>Color de los textos en la aplicación.</summary>
    ''' <returns>Color de los textos en la aplicación.</returns>
    Public Shared ReadOnly Property ColorTexto() As Color
        Get
            Return objClrTexto
        End Get
    End Property

End Class