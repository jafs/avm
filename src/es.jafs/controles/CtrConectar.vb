''' <summary>Clase que gestiona la pantalla de conexión al emulador.</summary>
Public Class CtrConectar
    ''' <summary>Formulario padre del actual.</summary>
    Private frmPadre As FrmPrincipal


    ''' <summary>Constructor por defecto para la clase.</summary>
    ''' <param name="frmPadreR">Formulario padre.</param>
    Public Sub New(ByRef frmPadreR As FrmPrincipal)
        InitializeComponent()
        frmPadre = frmPadreR
    End Sub


    ''' <summary>Controla el clic sobre el botón conectar.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnConectar_Click(sender As System.Object, e As System.EventArgs) Handles btnConectar.Click
        ' Puerto de conexión
        Dim iPuerto As Integer = 0

        ' Analiza si el puerto recibido es correcto.
        If Integer.TryParse(txtPuerto.Text, iPuerto) And iPuerto > 0 And iPuerto < 65536 Then
            lblError.Visible = False
            frmPadre.conectar(iPuerto)
        Else
            lblError.Visible = True
        End If
    End Sub


    ''' <summary>Prepara el control para su carga inicial.</summary>
    Public Sub iniciar()
        lblError.Visible = False
        txtPuerto.Focus()
        txtPuerto.SelectAll()
        frmPadre.AcceptButton = btnConectar
    End Sub
End Class
