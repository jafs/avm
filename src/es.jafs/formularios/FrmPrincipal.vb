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


    ''' <summary>Indica si hay conexi�n.</summary>
    Private bConexion As Boolean = False
    ''' <summary>Objeto de conexi�n a Telnet.</summary>
    Private objTelnet As New AndTelnet()
    ''' <summary>Indica si actualmente se est� en modo consulta.</summary>
    Private bModoConsulta As Boolean = False
    ''' <summary>Indica si es la primera carga. Para la gesti�n del reloj.</summary
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
        If sComando.ToLower = "quit" Or sComando.ToLower = "exit" Then
            If MessageBox.Show("Disconnect from emulator?", "Disconnect", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                conectar(0)
            End If
            Return
        End If

        ' Tomamos el control en kill para confirmar si desea finalizarse la instancia.
        If sComando.ToLower = "kill" Then
            If MessageBox.Show("Kill the Android emulator instance?", "Kill emulator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                enviarComando(txtComando.Text)
                txtRecv.Text &= vbNewLine & vbNewLine
                bConexion = False
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
        Me.Text = "Android Virtual Management " & My.Application.Info.Version.ToString
        updateHora()
        trmReloj.Interval = 60000 - (TimeOfDay.Second * 1000)
        lanzar(TipoApp.Connect)
    End Sub


    ''' <summary>Controla el cierre de la aplicaci�n.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub frmPrincipal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If objTelnet.Conectado Then
            objTelnet.desconectar()
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
    Public Sub enviarComando(ByRef sComando As String)
        If (bConexion) Then
            txtRecv.Text += sComando
            txtRecv.Text += vbNewLine
            txtRecv.Text += objTelnet.consultar(sComando)
            txtRecv.Select(txtRecv.Text.Length - 1, 1)
            txtRecv.ScrollToCaret()
        Else
            MessageBox.Show("There is no connection")
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
            Case Else
                MessageBox.Show("Tipo no controlado: " & eTipo) ' TODO DELETE
        End Select
    End Sub


    ''' <summary>Establece la conexi�n/desconexi�n con Android.</summary>
    ''' <param name="iPuerto">Puerto de conexi�n al emulador.</param>
    Public Sub conectar(ByVal iPuerto As Integer)
        If bConexion Then
            objTelnet.desconectar()
            txtRecv.Text &= vbNewLine & vbNewLine
            bConexion = False
        Else
            'objTelnet.Puerto = CType(txtPuerto.Text, Integer)
            objTelnet.Puerto = CType(iPuerto, Integer)
            Dim sResultado As String = String.Empty

            sResultado = objTelnet.conectar()

            If sResultado Is Nothing Or sResultado.Length = 0 Then
                bConexion = False
            Else
                txtRecv.Text &= "-----------------------------------" & vbNewLine & _
                                Date.Now.ToString & vbNewLine & _
                                "-----------------------------------" & vbNewLine & _
                                sResultado
                txtRecv.Select(txtRecv.Text.Length - 1, 1)
                txtRecv.ScrollToCaret()

                bConexion = (sResultado.Contains(AndTelnet.RES_OK))
            End If
        End If

        actualizarControles()
    End Sub


    ''' <summary>Actualiza el estado de los controles dependiendo de la conexi�n.</summary>
    Private Sub actualizarControles()
        btnEnviar.Enabled = bConexion
        txtComando.Enabled = bConexion
        btnHome.Enabled = bConexion

        If bConexion Then
            lanzar(TipoApp.Menu)
        Else
            ctrGsmCalls.parar()
            lanzar(TipoApp.Connect)
        End If
    End Sub
End Class


