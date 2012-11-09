Imports System.Net
Imports System.Net.Sockets
Imports System.Text


''' <summary>Clase de gesti�n de la interfaz gr�fica.</summary>
Public Class FrmPrincipal
    ''' <summary>Enumeraci�n con los tipos de ventana disponibles.</summary>
    Public Enum TipoApp
        ''' <summary>Ventana de gesti�n de energ�a.</summary>
        Power
        ''' <summary>Ventana de gesti�n de GPS.</summary>
        Gps
        ''' <summary>Ventana de estado GSM.</summary>
        GsmStatus
        ''' <summary>Ventana de gesti�n de llamadas.</summary>
        GsmCall
        ''' <summary>Ventana de gesti�n de sensores.</summary>
        Sensor
        ''' <summary>Ventana de gesti�n de SMS.</summary>
        Sms
        ''' <summary>Ventana de men� principal.</summary>
        Menu
        ''' <summary>Ventana conexi�n.</summary>
        Connect
    End Enum

    ''' <summary>Objeto de conexi�n a Telnet.</summary>
    Private objTelnet As New AndTelnet()
    ''' <summary>Indica si actualmente se est� en modo consulta.</summary>
    Private bModoConsulta As Boolean = False
    ''' <summary>Indica si es la primera carga. Para la gesti�n del reloj.</summary>
    Private bInicial As Boolean = True

    ' TODO mejorar control de formularios
    ''' <summary>Formulario de conexi�n.</summary>
    Private ctrConectar As New CtrConectar(Me)
    ''' <summary>Formulario de GPS.</summary>
    Private ctrGps As New CtrGps(Me)
    ''' <summary>Formulario de llamadas.</summary>
    Private ctrGsmCalls As New CtrGsmCalls(Me)
    ''' <summary>Formulario de estado GSM.</summary>
    Private ctrGsmStatus As New CtrGsmStatus(Me)
    ''' <summary>Formulario de men�.</summary>
    Private ctrMenu As New CtrMenu(Me)
    ''' <summary>Formulario de energ�a.</summary>
    Private ctrPower As New CtrPower(Me)
    ''' <summary>Formulario de sensores.</summary>
    Private ctrSensor As New CtrSensor(Me)
    ''' <summary>Formulario de mensajer�a.</summary>
    Private ctrSms As New CtrSms(Me)


    ''' <summary>Propiedad que obtiene o establece el modo consulta en la aplicaci�n.</summary>
    ''' <value>Establece si se est� en modo consulta.</value>
    ''' <returns>Indica si est� activo el modo consulta.</returns>
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
    ''' <summary>Controla el clic sobre el bot�n de env�o de comandos.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Dim sComando As String = txtComando.Text.Trim

        ' Tomamos el control para quit o exit y nos desconectamos del emulador.
        If sComando.ToLower = Comando.CQUIT Or sComando.ToLower = Comando.CEXIT Then
            If MessageBox.Show("Disconnect from emulator?", "Disconnect", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                conectar(0)
            End If
            Return
        End If

        ' Tomamos el control en kill para confirmar si desea finalizarse la instancia.
        If sComando.ToLower = Comando.CKILL Then
            If MessageBox.Show("Kill the Android emulator instance?", "Kill emulator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                enviarComando(txtComando.Text)
                txtRecv.Text &= vbNewLine & vbNewLine
                actualizarControles()
            End If

            Return
        End If

        enviarComando(txtComando.Text)
    End Sub

    ''' <summary>Controla el clic sobre el bot�n de men� Inicio.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        ctrGsmCalls.parar()
        lanzar(TipoApp.Menu)
    End Sub

    
    ''' <summary>Carga inicial del formulario.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.ProductName & " " & My.Application.Info.Version.ToString
        updateHora()
        trmReloj.Interval = 60000 - (TimeOfDay.Second * 1000)
        lanzar(TipoApp.Connect)
    End Sub

    ''' <summary>Cierra la aplicaci�n.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    ''' <summary>Controla el cierre de la aplicaci�n.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub frmPrincipal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If objTelnet.Conectado Then
            If MessageBox.Show("Currently connected to emulator. Do you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                objTelnet.desconectar()
            End If
        End If
    End Sub


    ''' <summary>Controla el tick del temporizador de reloj.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub trmReloj_Tick(sender As System.Object, e As System.EventArgs) Handles trmReloj.Tick
        If bInicial Then
            trmReloj.Interval = 60000
            bInicial = False
        End If
        updateHora()
    End Sub


    ''' <summary>Abre el formulario Acerca de...</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub ttmAbout_Click(sender As System.Object, e As System.EventArgs) Handles ttmAbout.Click
        FrmAcerca.ShowDialog(Me)
    End Sub


    ''' <summary>Abre el men� de ayuda.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnAyuda_Click(sender As System.Object, e As System.EventArgs) Handles btnAyuda.Click
        mnAyuda.Show(btnAyuda, 0, -80)
    End Sub


    ''' <summary>Abre la gu�a de usuario.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub ttmAyuManual_Click(sender As System.Object, e As System.EventArgs) Handles ttmAyuManual.Click
        System.Diagnostics.Process.Start(My.Resources.sUrlManual)
    End Sub


    ''' <summary>Abre la p�gina de la aplicaci�n.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub ttmAyuGeneral_Click(sender As System.Object, e As System.EventArgs) Handles ttmAyuGeneral.Click
        System.Diagnostics.Process.Start(My.Resources.sUrlAplicacion)
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


    ''' <summary>Env�a el comando que hay en la l�nea de comandos.</summary>
    ''' <param name="sComando">Comando a enviar en la consulta.</param>
    Public Sub enviarComando(ByVal sComando As String)
        If objTelnet.Conectado Then
            txtRecv.Text += sComando
            txtRecv.Text += vbNewLine
            txtRecv.Text += objTelnet.consultar(sComando)
            txtRecv.Select(txtRecv.Text.Length - 1, 1)
            txtRecv.ScrollToCaret()
        Else
            MessageBox.Show("There is no connection")
            actualizarControles()
        End If

        If txtComando.Text.Length > 0 Then
            txtComando.SelectAll()
        End If
    End Sub


    ''' <summary>Env�a una consulta a la m�quina virtual.</summary>
    ''' <param name="sConsulta">Consulta a realizar.</param>
    ''' <returns>Resultado de ejecuci�n de la consulta.</returns>
    Public Function consultar(ByRef sConsulta As String) As String
        Return objTelnet.consultar(sConsulta)
    End Function


    ''' <summary>Lanza la ventana correspondiente dependiendo del par�metro recibido.</summary>
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


    ''' <summary>Establece la conexi�n/desconexi�n con Android.</summary>
    ''' <param name="iPuerto">Puerto de conexi�n al emulador.</param>
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


    ''' <summary>Actualiza el estado de los controles dependiendo de la conexi�n.</summary>
    Private Sub actualizarControles()
        btnEnviar.Enabled = objTelnet.Conectado
        txtComando.Enabled = objTelnet.Conectado
        btnHome.Enabled = objTelnet.Conectado

        If objTelnet.Conectado Then
            lanzar(TipoApp.Menu)
        Else
            ctrGsmCalls.parar()
            lanzar(TipoApp.Connect)
        End If
    End Sub


    ''' <summary>Controla el estado del panel de depuraci�n dependiendo del estado del
    ''' checkbox.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub chkDebug_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDebug.CheckedChanged
        If chkDebug.Checked Then
            Me.pnlDebug.Visible = True
            ttConsejo.SetToolTip(chkDebug, "Hide debug console")
        Else
            Me.pnlDebug.Visible = False
            ttConsejo.SetToolTip(chkDebug, "Show debug console")
        End If
    End Sub
End Class


