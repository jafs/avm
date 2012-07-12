Public Class CtrMenu
    ''' <summary>Formulario padre.</summary>
    Dim frmPadre As FrmPrincipal


    ''' <summary>Constructor por defecto de la clase.</summary>
    ''' <param name="frmParent">Formulario padre.</param>
    Public Sub New(ByRef frmParent As FrmPrincipal)
        InitializeComponent()
        frmPadre = frmParent
    End Sub


    ''' <summary>Lanza la ventana de energía.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPower.Click
        frmPadre.lanzar(FrmPrincipal.TipoApp.Power)
    End Sub


    ''' <summary>Lanza la ventana de sensores.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnSensors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSensors.Click
        frmPadre.lanzar(FrmPrincipal.TipoApp.Sensor)
    End Sub


    ''' <summary>Lanza la ventana de llamadas.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnCalls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalls.Click
        frmPadre.lanzar(FrmPrincipal.TipoApp.GsmCall)
    End Sub


    ''' <summary>Lanza la ventana de GPS.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnGps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGps.Click
        frmPadre.lanzar(FrmPrincipal.TipoApp.Gps)
    End Sub


    ''' <summary>Lanza la ventana de estado GSM.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnGsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGsm.Click
        frmPadre.lanzar(FrmPrincipal.TipoApp.GsmStatus)
    End Sub


    ''' <summary>Lanza la ventana de mensajería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnSms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSms.Click
        frmPadre.lanzar(FrmPrincipal.TipoApp.Sms)
    End Sub


    ''' <summary>Desconecta la aplicación.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnDesconectar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesconectar.Click
        frmPadre.conectar(0)
    End Sub
End Class
