Public Class Plantilla
    Private Shared objClrFondo As Color = Color.FromArgb(58, 181, 227)

    Public Shared ReadOnly Property ColorFondo() As Color
        Get
            Return objClrFondo
        End Get
    End Property

End Class