Imports System.Net
Imports System.Net.Sockets
Imports System.Text


''' <summary>Clase de gestión de la interfaz gráfica.</summary>
Public Class FrmPrincipal
    ''' <summary>Enumeración con los tipos de ventana disponibles.</summary>
    Public Enum TipoApp
        ''' <summary>Ventana de gestión de energía.</summary>
        Power
        ''' <summary>Ventana de gestión de GPS.</summary>
        Gps
        ''' <summary>Ventana de estado GSM.</summary>
        GsmStatus
        ''' <summary>Ventana de gestión de llamadas.</summary>
        GsmCall
        ''' <summary>Ventana de gestión de sensores.</summary>
        Sensor
        ''' <summary>Ventana de gestión de SMS.</summary>
        Sms
        ''' <summary>Ventana de menú principal.</summary>
        Menu
        ''' <summary>Ventana conexión.</summary>
        Connect
    End Enum

    ''' <summary>Objeto de conexión a Telnet.</summary>
    Private objTelnet As New AndTelnet()
    ''' <summary>Indica si actualmente se está en modo consulta.</summary>
    Private bModoConsulta As Boolean = False
    ''' <summary>Indica si es la primera carga. Para la gestión del reloj.</summary>
    Private bInicial As Boolean = True
    ''' <summary>Controla la posición del ratón para el desplazamiento de la ventana.</summary>
    Private objPosCursor As Point
    ''' <summary>Indica si el botón izquierdo del ratón está pulsado.</summary>
    Private bMouseDown As Boolean = False

    ' TODO mejorar control de formularios
    ''' <summary>Formulario de conexión.</summary>
    Private ctrConectar As New CtrConectar(Me)
    ''' <summary>Formulario de GPS.</summary>
    Private ctrGps As New CtrGps(Me)
    ''' <summary>Formulario de llamadas.</summary>
    Private ctrGsmCalls As New CtrGsmCalls(Me)
    ''' <summary>Formulario de estado GSM.</summary>
    Private ctrGsmStatus As New CtrGsmStatus(Me)
    ''' <summary>Formulario de menú.</summary>
    Private ctrMenu As New CtrMenu(Me)
    ''' <summary>Formulario de energía.</summary>
    Private ctrPower As New CtrPower(Me)
    ''' <summary>Formulario de sensores.</summary>
    Private ctrSensor As New CtrSensor(Me)
    ''' <summary>Formulario de mensajería.</summary>
    Private ctrSms As New CtrSms(Me)


    ''' <summary>Propiedad que obtiene o establece el modo consulta en la aplicación.</summary>
    ''' <value>Establece si se está en modo consulta.</value>
    ''' <returns>Indica si está activo el modo consulta.</returns>
    Public Property Consulta() As Boolean
        Get
            Return bModoConsulta
        End Get
        Set(ByVal bQuery As Boolean)
            bModoConsulta = bQuery
        End Set
    End Property


    ' ######################################
    ' MANEJADORES
    ' ######################################
    ''' <summary>Controla el clic sobre el botón de envío de comandos.</summary>
    Private Sub btnEnviar_Click() Handles btnEnviar.Click
        Dim sComando As String = txtComando.Text.Trim

        ' Tomamos el control para quit o exit y nos desconectamos del emulador.
        If sComando.ToLower = Comando.CQUIT Or sComando.ToLower = Comando.CEXIT Then
            If MessageBox.Show(Idioma.traducir("pop_disconnect_question"), Idioma.traducir("disconnect"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                conectar(0)
            End If
            Return
        End If

        ' Tomamos el control en kill para confirmar si desea finalizarse la instancia.
        If sComando.ToLower = Comando.CKILL Then
            If MessageBox.Show(Idioma.traducir("pop_kill_question"), Idioma.traducir("pop_kill_title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                enviarComando(txtComando.Text)
                txtRecv.Text &= vbNewLine & vbNewLine
                actualizarControles()
            End If

            Return
        End If

        enviarComando(txtComando.Text)
    End Sub


    ''' <summary>Al pulsar intro en el control de comando ejecuta la consulta.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento con la tecla</param>
    ''' <remarks></remarks>
    Private Sub txtComando_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtComando.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnEnviar_Click()
        End If
    End Sub


    ''' <summary>Activa o desactiva el botón de envío de comando dependiendo de si hay
    ''' valores introducidos en la cadena de comandos.</summary>
    Private Sub txtComando_TextChanged() Handles txtComando.TextChanged
        btnEnviar.Enabled = (txtComando.Text.Length > 0)
    End Sub


    ''' <summary>Controla el clic sobre el botón de menú Inicio.</summary>
    Private Sub btnHome_Click() Handles btnHome.Click
        ctrGsmCalls.parar()
        lanzar(TipoApp.Menu)
    End Sub

    
    ''' <summary>Carga inicial del formulario.</summary>
    Private Sub frmPrincipal_Load() Handles MyBase.Load
        Me.Text = My.Application.Info.ProductName & " " & My.Application.Info.Version.ToString
        updateHora()
        trmReloj.Interval = 60000 - (TimeOfDay.Second * 1000)
        lanzar(TipoApp.Connect)
    End Sub


    ''' <summary>Cierra la aplicación.</summary>
    Private Sub btnSalir_Click() Handles btnSalir.Click
        Me.Close()
    End Sub


    ''' <summary>Controla el cierre de la aplicación.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub frmPrincipal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If objTelnet.Conectado Then
            If MessageBox.Show(Idioma.traducir("pop_exit_question"), Idioma.traducir("pop_exit_title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                objTelnet.desconectar()
            End If
        End If
    End Sub


    ''' <summary>Controla el tick del temporizador de reloj.</summary>
    Private Sub trmReloj_Tick() Handles trmReloj.Tick
        If bInicial Then
            trmReloj.Interval = 60000
            bInicial = False
        End If
        updateHora()
    End Sub


    ''' <summary>Abre el formulario Acerca de...</summary>
    Private Sub ttmAbout_Click() Handles ttmAbout.Click
        FrmAcerca.ShowDialog(Me)
    End Sub


    ''' <summary>Abre el menú de ayuda.</summary>
    Private Sub btnAyuda_Click() Handles btnAyuda.Click
        mnAyuda.Show(btnAyuda, 0, -80)
    End Sub


    ''' <summary>Abre la guía de usuario.</summary>
    Private Sub ttmAyuManual_Click() Handles ttmAyuManual.Click
        System.Diagnostics.Process.Start(My.Resources.sUrlManual)
    End Sub


    ''' <summary>Abre la página de la aplicación.</summary>
    Private Sub ttmAyuGeneral_Click() Handles ttmAyuGeneral.Click
        System.Diagnostics.Process.Start(My.Resources.sUrlAplicacion)
    End Sub


    ''' <summary>Controla el estado del panel de depuración dependiendo del estado del checkbox.</summary>
    Private Sub chkDebug_CheckedChanged() Handles chkDebug.CheckedChanged
        If chkDebug.Checked Then
            Me.pnlDebug.Visible = True
            ttConsejo.SetToolTip(chkDebug, Idioma.traducir("frm_debug_hide"))
        Else
            Me.pnlDebug.Visible = False
            ttConsejo.SetToolTip(chkDebug, Idioma.traducir("frm_debug_show"))
        End If
    End Sub


    ''' <summary>Controla la pulsación del botón izquierdo sobre la barra de título.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub pblEstado_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pblEstado.MouseDown, lblReloj.MouseDown, lblTitulo.MouseDown
        If e.Button = MouseButtons.Left Then
            Dim objControl As Control = CType(sender, Control)
            If objControl.Name = lblReloj.Name Or objControl.Name = lblTitulo.Name Then
                objPosCursor = New Point(-e.X - objControl.Location.X, -e.Y - objControl.Location.Y)
            Else
                objPosCursor = New Point(-e.X, -e.Y)
            End If
            bMouseDown = True
        End If
    End Sub


    ''' <summary>Controla el movimiento del ratón sobre la barra de título.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub pblEstado_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pblEstado.MouseMove, lblReloj.MouseMove, lblTitulo.MouseMove
        If bMouseDown Then
            Dim objPosicion As Point = Control.MousePosition
            objPosicion.Offset(objPosCursor.X, objPosCursor.Y)
            Location = objPosicion
        End If
    End Sub


    ''' <summary>Controla el fin del evento de arrastre del ratón en la barra de título.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub pblEstado_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pblEstado.MouseUp, lblReloj.MouseUp, lblTitulo.MouseUp
        If e.Button = MouseButtons.Left Then
            bMouseDown = False
        End If
    End Sub


    ' ######################################
    ' GENERAL
    ' ######################################
    Private Sub updateHora()
        Dim sHora As String = String.Empty

        If TimeOfDay.Hour < 10 Then
            sHora &= "0"
        End If
        sHora &= TimeOfDay.Hour & ":"

        If TimeOfDay.Minute < 10 Then
            sHora &= "0"
        End If
        sHora &= TimeOfDay.Minute

        lblReloj.Text = sHora
    End Sub


    ''' <summary>Envía el comando que hay en la línea de comandos.</summary>
    ''' <param name="sComando">Comando a enviar en la consulta.</param>
    Public Sub enviarComando(ByVal sComando As String)
        If objTelnet.Conectado Then
            txtRecv.Text += sComando
            txtRecv.Text += vbNewLine
            txtRecv.Text += objTelnet.consultar(sComando)
            txtRecv.Select(txtRecv.Text.Length - 1, 1)
            txtRecv.ScrollToCaret()
        Else
            MessageBox.Show(Idioma.traducir("err_no_connection"))
            actualizarControles()
        End If

        If txtComando.Text.Length > 0 Then
            txtComando.SelectAll()
        End If
    End Sub


    ''' <summary>Envía una consulta a la máquina virtual.</summary>
    ''' <param name="sConsulta">Consulta a realizar.</param>
    ''' <returns>Resultado de ejecución de la consulta.</returns>
    Public Function consultar(ByRef sConsulta As String) As String
        Return objTelnet.consultar(sConsulta)
    End Function


    ''' <summary>Lanza la ventana correspondiente dependiendo del parámetro recibido.</summary>
    ''' <param name="eTipo">Tipo de ventana a mostrar.</param>
    Public Sub lanzar(ByVal eTipo As TipoApp)
        pnlCentral.Controls.Clear()
        AcceptButton = Nothing

        Select Case eTipo
            Case TipoApp.Gps
                pnlCentral.Controls.Add(ctrGps)
            Case TipoApp.GsmCall
                pnlCentral.Controls.Add(ctrGsmCalls)
                ctrGsmCalls.iniciar()
            Case TipoApp.GsmStatus
                pnlCentral.Controls.Add(ctrGsmStatus)
                ctrGsmStatus.getGsmStatus()
            Case TipoApp.Power
                pnlCentral.Controls.Add(ctrPower)
                ctrPower.getBateria()
            Case TipoApp.Sensor
                pnlCentral.Controls.Add(ctrSensor)
            Case TipoApp.Sms
                pnlCentral.Controls.Add(ctrSms)
            Case TipoApp.Connect
                pnlCentral.Controls.Add(ctrConectar)
                pnlCentral.Focus()
                ctrConectar.iniciar()
            Case TipoApp.Menu
                pnlCentral.Controls.Add(ctrMenu)
        End Select
    End Sub


    ''' <summary>Establece la conexión/desconexión con Android.</summary>
    ''' <param name="iPuerto">Puerto de conexión al emulador.</param>
    Public Sub conectar(ByVal iPuerto As Integer)
        If objTelnet.Conectado Then
            objTelnet.desconectar()
            txtRecv.Text &= vbNewLine & vbNewLine
            txtRecv.Select(txtRecv.Text.Length - 1, 1)
            txtRecv.ScrollToCaret()
        Else
            'objTelnet.Puerto = CType(txtPuerto.Text, Integer)
            objTelnet.Puerto = CType(iPuerto, Integer)
            Dim sResultado As String = String.Empty

            sResultado = objTelnet.conectar()

            If Not sResultado Is Nothing And sResultado.Length > 0 Then
                txtRecv.Text &= "-----------------------------------" & vbNewLine & _
                                Date.Now.ToString(My.Application.Culture.DateTimeFormat) & _
                                vbNewLine & "-----------------------------------" & _
                                vbNewLine & sResultado
                txtRecv.Select(txtRecv.Text.Length - 1, 1)
                txtRecv.ScrollToCaret()
            End If
        End If

        actualizarControles()
    End Sub


    ''' <summary>Actualiza el estado de los controles dependiendo de la conexión.</summary>
    Private Sub actualizarControles()
        btnEnviar.Enabled = (objTelnet.Conectado And txtComando.Text.Length > 0)
        txtComando.Enabled = objTelnet.Conectado
        btnHome.Enabled = objTelnet.Conectado

        If objTelnet.Conectado Then
            lanzar(TipoApp.Menu)
        Else
            ctrGsmCalls.parar()
            lanzar(TipoApp.Connect)
        End If
    End Sub
End Class


