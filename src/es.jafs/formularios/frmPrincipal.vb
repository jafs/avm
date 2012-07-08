Imports System.Net
Imports System.Net.Sockets
Imports System.Text


''' <summary>Clase de gestión de la interfaz gráfica.</summary>
Public Class frmPrincipal
    ''' <summary>Indica si hay conexión.</summary>
    Dim bConexion As Boolean = False
    ''' <summary>Objeto de conexión a Telnet.</summary>
    Dim objTelnet As New AndTelnet()
    ''' <summary>Indica si actualmente se está en modo consulta.</summary>
    Dim bModoConsulta As Boolean = False


    ''' <summary>Controla el clic sobre el botón de conexión.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        conectar()
    End Sub


    ''' <summary>Controla el clic sobre el botón de cierre de la aplicación.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub cmdQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        objTelnet.desconectar()
        Close()
    End Sub


    ''' <summary>Controla el clic sobre el botón de envío de comandos.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        enviarComando(txtComando.Text)
    End Sub



    ' ######################################
    ' BATERÍA
    ' ######################################
    ''' <summary>Controla cambios del checkbox de carga AC.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub chkCargaAc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCargaAc.CheckedChanged
        If Not bModoConsulta Then
            If (chkCargaAc.Checked) Then
                enviarComando(Comando.POWER_AC_ON)
            Else
                enviarComando(Comando.POWER_AC_OFF)
            End If
        End If
    End Sub


    ''' <summary>Controla cambios en el combo de estado de la batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub cmbBatStat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatStat.SelectedIndexChanged
        If Not bModoConsulta Then
            enviarComando(Comando.POWER_STATUS + cmbBatStat.SelectedItem.ToString)
        End If
    End Sub


    ''' <summary>Controla cambios en el checkbox de presencia de batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub chkBatPresent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBatPresent.CheckedChanged
        If Not bModoConsulta Then
            enviarComando(Comando.POWER_PRESENT + chkBatPresent.Checked.ToString)
        End If
    End Sub


    ''' <summary>Controla cambios en el combo de salud de la batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub cmbBatHealth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatHealth.SelectedIndexChanged
        If Not bModoConsulta Then
            enviarComando(Comando.POWER_HEALTH + cmbBatHealth.SelectedItem.ToString)
        End If
    End Sub


    ''' <summary>Controla el clic sobre el cambio de capacidad de la batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnBatCapacity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatCapacity.Click
        enviarComando(Comando.POWER_CAPACITY + nudBatCapacity.Value.ToString)
    End Sub


    ''' <summary>Controla el clic sobre el bótón de estado de batería.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub btnBatEstado_Click(sender As System.Object, e As System.EventArgs) Handles btnBatEstado.Click
        enviarComando(Comando.POWER_DISPLAY)
        getBateria()
    End Sub


    ''' <summary>Obtiene el estado de la batería.</summary>
    Private Sub getBateria()
        Dim sResultado As String = objTelnet.consultar(Comando.POWER_DISPLAY)
        sResultado = sResultado.Replace(vbCr & "" & vbCrLf, vbNewLine)
        bModoConsulta = True

        Dim arsValores As String() = sResultado.Split(CChar(vbNewLine))

        If arsValores.Length > 0 Then
            For Each sValor As String In arsValores
                If sValor.Contains("AC:") Then
                    chkCargaAc.Checked = sValor.Contains("online")
                ElseIf sValor.Contains("status:") Then
                    Dim arsEstado As String() = sValor.Split(CChar(" "))
                    cmbBatStat.SelectedItem = arsEstado(1)
                ElseIf sValor.Contains("health:") Then
                    If sValor.Contains("failure") Then
                        cmbBatHealth.SelectedItem = "Failure"
                    Else
                        Dim arsEstado As String() = sValor.Split(CChar(" "))
                        cmbBatHealth.SelectedItem = arsEstado(1)
                    End If
                ElseIf sValor.Contains("present:") Then
                        chkBatPresent.Checked = sValor.Contains("true")
                ElseIf sValor.Contains("capacity:") Then
                        Dim arsEstado As String() = sValor.Split(CChar(" "))
                        nudBatCapacity.Value = Integer.Parse(arsEstado(1))
                    End If
            Next
        Else
            MessageBox.Show("There is no values")
        End If

        bModoConsulta = False
    End Sub



    ' ######################################
    ' GENERALES
    ' ######################################
    ''' <summary>Envía el comando que hay en la línea de comandos.</summary>
    Private Sub enviarComando(ByRef sComando As String)
        If (bConexion) Then
            txtRecv.Text += sComando
            txtRecv.Text += vbNewLine
            txtRecv.Text += objTelnet.consultar(sComando)
            txtRecv.Select(txtRecv.Text.Length - 1, 1)
            txtRecv.ScrollToCaret()
        Else
            MessageBox.Show("There is no connection")
            btnConectar.Focus()
        End If

        txtComando.SelectAll()
    End Sub


    ''' <summary>Establece la conexión/desconexión con Android.</summary>
    Private Sub conectar()
        If bConexion Then
            objTelnet.desconectar()
            bConexion = False
        Else
            objTelnet.Puerto = CType(txtPuerto.Text, Integer)
            Dim sResultado As String = String.Empty

            sResultado = objTelnet.conectar()

            If sResultado Is Nothing Or sResultado.Length = 0 Then
                bConexion = False
            Else
                txtRecv.Text += sResultado

                bConexion = (sResultado.Contains(AndTelnet.RES_OK))

                If bConexion Then
                    getBateria()
                    getGsmStatus()
                End If
            End If
        End If
        actualizarControles()
    End Sub


    ''' <summary>Actualiza el estado de los controles dependiendo de la conexión.</summary>
    Private Sub actualizarControles()
        tcPestanas.Enabled = bConexion
        btnEnviar.Enabled = bConexion
        txtComando.Enabled = bConexion

        txtPuerto.Enabled = Not bConexion

        If bConexion Then
            btnConectar.Text = "Disconnect"
        Else
            btnConectar.Text = "Connect"
        End If
    End Sub



    ' ######################################
    ' SENSORES
    ' ######################################
    ''' <summary>Controla el cambio de sensor.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub cmbSensores_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbSensores.SelectedIndexChanged
        If cmbSensores.SelectedItem Is Nothing Then
            btnSenSet.Enabled = False
            btnSenUpdate.Enabled = False
        Else
            cambiarSensor(cmbSensores.SelectedItem.ToString)
            If Not btnSenSet.Enabled Then
                btnSenSet.Enabled = True
            End If
            If Not btnSenUpdate.Enabled Then
                btnSenUpdate.Enabled = True
            End If
        End If
    End Sub


    ''' <summary>Controla el clic en el botón de actualización de valores de sensor.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnSenUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnSenUpdate.Click
        If cmbSensores.SelectedItem Is Nothing Then
            MessageBox.Show("You must to select a sensor.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSensores.Focus()
        Else
            getSensor(cmbSensores.SelectedItem.ToString)
        End If
    End Sub


    ''' <summary>Controla el clic en el botón de guardado de valores del sensor.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnSenSet_Click(sender As System.Object, e As System.EventArgs) Handles btnSenSet.Click
        If cmbSensores.SelectedItem Is Nothing Then
            MessageBox.Show("You must to select a sensor.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSensores.Focus()
        Else
            enviarComando(Comando.SENSOR_SET & cmbSensores.SelectedItem.ToString & " " & _
                          Utilidades.decimalToCad(nudSenValor1.Value) & ":" & _
                          Utilidades.decimalToCad(nudSenValor2.Value) & ":" & _
                          Utilidades.decimalToCad(nudSenValor3.Value))
        End If
    End Sub


    ''' <summary>Actualiza el estado de sensores así como sus valores.</summary>
    ''' <param name="sSensor">Nombre del sensor</param>
    Private Sub cambiarSensor(ByRef sSensor As String)
        Select Case sSensor
            Case Comando.SEN_ACCELERATION, Comando.SEN_MAGNETIC_FIELD
                lblSenValor1.Text = "X-Axis:"
                nudSenValor1.Enabled = True
                nudSenValor1.Minimum = -100
                nudSenValor1.Maximum = 100
                lblSenValor2.Text = "Y-Axis:"
                nudSenValor2.Enabled = True
                nudSenValor2.Minimum = -100
                nudSenValor2.Maximum = 100
                lblSenValor3.Text = "Z-Axis:"
                nudSenValor3.Enabled = True
                nudSenValor3.Minimum = -100
                nudSenValor3.Maximum = 100
            Case Comando.SEN_ORIENTATION
                lblSenValor1.Text = "Azimuth:"
                nudSenValor1.Enabled = True
                nudSenValor1.Minimum = 0
                nudSenValor1.Maximum = 359
                lblSenValor2.Text = "Pitch:"
                nudSenValor2.Enabled = True
                nudSenValor2.Minimum = -180
                nudSenValor2.Maximum = 180
                lblSenValor3.Text = "Roll:"
                nudSenValor3.Enabled = True
                nudSenValor3.Minimum = -90
                nudSenValor3.Maximum = 90
            Case Comando.SEN_TEMPERATURE
                lblSenValor1.Text = "Temp:"
                nudSenValor1.Enabled = True
                nudSenValor1.Minimum = 0
                nudSenValor1.Maximum = 359
                lblSenValor2.Text = "Not used:"
                nudSenValor2.Enabled = False
                nudSenValor2.Value = 0
                lblSenValor3.Text = "Not used:"
                nudSenValor3.Enabled = False
                nudSenValor3.Value = 0
            Case Comando.SEN_PROXIMITY
                lblSenValor1.Text = "Distance:"
                nudSenValor1.Enabled = True
                nudSenValor1.Minimum = 0
                nudSenValor1.Maximum = 359
                lblSenValor2.Text = "Not used:"
                nudSenValor2.Enabled = False
                nudSenValor2.Value = 0
                lblSenValor3.Text = "Not used:"
                nudSenValor3.Enabled = False
                nudSenValor3.Value = 0
        End Select

        getSensor(sSensor)
    End Sub


    ''' <summary>Obtiene el estado del sensor recibido como argumento.</summary>
    ''' <param name="sSensor">Nombre del sensor</param>
    Private Sub getSensor(ByRef sSensor As String)
        Dim sResultado As String = objTelnet.consultar(Comando.SENSOR_GET & sSensor)
        sResultado = sResultado.Replace(vbCr & "" & vbCrLf, vbNewLine)

        If sResultado.Contains(AndTelnet.RES_OK) Then
            Dim arsValores As String() = sResultado.Split(CChar(vbNewLine))

            If arsValores.Length > 0 Then
                For Each sValor As String In arsValores
                    If sValor.Contains(sSensor) Then
                        Dim sValores As String = sValor.Substring(sValor.IndexOf("=") + 2)
                        Dim arsDatos As String() = sValores.Split(CChar(":"))

                        Try
                            Select Case sSensor
                                Case Comando.SEN_ACCELERATION, Comando.SEN_MAGNETIC_FIELD, Comando.SEN_ORIENTATION
                                    nudSenValor1.Value = Utilidades.cadToDecimal(arsDatos(0))
                                    nudSenValor2.Value = Utilidades.cadToDecimal(arsDatos(1))
                                    nudSenValor3.Value = Utilidades.cadToDecimal(arsDatos(2))
                                Case Else
                                    nudSenValor1.Value = Utilidades.cadToDecimal(arsDatos(0))
                                    nudSenValor2.Value = 0
                                    nudSenValor3.Value = 0
                            End Select
                        Catch e As ArgumentException
                            MessageBox.Show("Error when read some value of sensor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                Next
            Else
                MessageBox.Show("There is no values")
            End If
        End If
    End Sub



    ' ######################################
    ' SMS
    ' ######################################
    ''' <summary>Controla el cambio en el texto de mensaje.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub txtSmsMessage_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSmsMessage.TextChanged
        lblSmsRest.Text = txtSmsMessage.Text.Length.ToString
        btnSmsSend.Enabled = (txtSmsNumero.Text.Length > 0 And txtSmsMessage.Text.Length > 0)
    End Sub


    ''' <summary>Controla el cambio en el texto del número de teléfono.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub mtbSmsNumero_TextChanged(sender As System.Object, e As System.EventArgs)
        btnSmsSend.Enabled = (txtSmsNumero.Text.Length > 0 And txtSmsMessage.Text.Length > 0)
    End Sub


    ''' <summary>Clic sobre el botón de envío de SMS.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnSmsSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSmsSend.Click
        enviarSms()
    End Sub


    ''' <summary>Envía un SMS con los datos actuales.</summary>
    Private Sub enviarSms()
        Dim bValido As Boolean = True
        Dim sNumero As String = Nothing

        ' Validación de prefijo.
        If txtSmsPrefijo.Text.Length > 0 Then
            Dim iNumero As Integer = 0
            bValido = Integer.TryParse(txtSmsPrefijo.Text, iNumero)
            If bValido Then
                sNumero = "+" & iNumero
            Else
                MessageBox.Show("Enter a valid prefix", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSmsPrefijo.Focus()
                txtSmsPrefijo.SelectAll()
            End If
        End If

        ' Validación de número.
        If bValido Then
            Dim iNumero As Integer = 0
            bValido = Integer.TryParse(txtSmsNumero.Text, iNumero)
            If bValido Then
                sNumero &= iNumero
            Else
                MessageBox.Show("Enter a valid phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSmsNumero.Focus()
                txtSmsNumero.SelectAll()
            End If
        End If

        ' Envío de mensaje si todo es correcto.
        If bValido Then
            If txtSmsMessage.Text.Length = 0 Then
                MessageBox.Show("Enter a message to send.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSmsMessage.Focus()
            Else
                enviarComando(Comando.SMS_SEND & sNumero & " " & txtSmsMessage.Text)
            End If
        End If
    End Sub



    ' ######################################
    ' GPS
    ' ######################################
    ''' <summary>Controla el estado de envío de Altitud.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub chkGpsAltitude_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGpsAltitude.CheckedChanged
        nudGpsAltitude.Enabled = chkGpsAltitude.Checked
        chkGpsSatelites.Enabled = chkGpsAltitude.Checked
    End Sub


    ''' <summary>Controla el estado de envío de satélites.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub chkGpsSatelites_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGpsSatelites.CheckedChanged
        nudGpsSatelites.Enabled = chkGpsSatelites.Checked
    End Sub


    ''' <summary>Envía la información de GPS al sistema.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub btnGpsSet_Click(sender As System.Object, e As System.EventArgs) Handles btnGpsSet.Click
        Dim dLontitud As Decimal
        Dim dLatitud As Decimal
        Dim sSentencia As String = String.Empty

        dLontitud = nudGpsLonGrados.Value + (nudGpsLonMin.Value / 60) + (nudGpsLonSec.Value / 3600)
        dLatitud = nudGpsLatGrados.Value + (nudGpsLatMin.Value / 60) + (nudGpsLatSec.Value / 3600)

        sSentencia = Utilidades.decimalToCad(dLontitud) & " " & Utilidades.decimalToCad(dLatitud)

        If chkGpsAltitude.Checked Then
            sSentencia &= " " & Utilidades.decimalToCad(nudGpsAltitude.Value)

            If chkGpsSatelites.Checked Then
                sSentencia &= " " & nudGpsSatelites.Value
            End If
        End If

        enviarComando(Comando.GEO_FIX & sSentencia)
    End Sub



    ' ######################################
    ' GSM
    ' ######################################
    ''' <summary>Establece el nivel de señal GSM.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub btnGsmSet_Click(sender As System.Object, e As System.EventArgs) Handles btnGsmSet.Click
        Dim sSentencia As String = String.Empty

        If chkGsmNoRssi.Checked Then
            sSentencia &= Comando.GSM_SIGNAL_UNKNOWN & " "
        Else
            sSentencia &= nudGsmRssi.Value & " "
        End If

        If chkGsmBerOn.Checked Then
            If chkGsmNoBer.Checked Then
                sSentencia &= Comando.GSM_SIGNAL_UNKNOWN
            Else
                sSentencia &= nudGsmBer.Value
            End If
        End If

        enviarComando(Comando.GSM_SIGNAL & sSentencia)
    End Sub


    ''' <summary>Activa/desactiva el envío de datos de señal BER.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub chkGsmBerOn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGsmBerOn.CheckedChanged
        nudGsmBer.Enabled = chkGsmBerOn.Checked
        chkGsmNoBer.Enabled = chkGsmBerOn.Checked
    End Sub


    ''' <summary>Establece el estado de datos GSM.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub cmbGsmDatos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbGsmDatos.SelectedIndexChanged
        If Not bModoConsulta Then
            enviarComando(Comando.GSM_DATA + cmbGsmDatos.SelectedItem.ToString)
        End If
    End Sub


    ''' <summary>Establece el estado de voz GSM.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub cmbGsmVoz_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbGsmVoz.SelectedIndexChanged
        If Not bModoConsulta Then
            enviarComando(Comando.GSM_VOICE + cmbGsmVoz.SelectedItem.ToString)
        End If
    End Sub

    Private Sub btnGsmUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnGsmUpdate.Click
        enviarComando(Comando.GSM_STATUS)
        getGsmStatus()
    End Sub


    ''' <summary>Obtiene el estado de datos y voz GSM.</summary>
    Private Sub getGsmStatus()
        Dim sResultado As String = objTelnet.consultar(Comando.GSM_STATUS)
        sResultado = sResultado.Replace(vbCr & "" & vbCrLf, vbNewLine)
        bModoConsulta = True

        Dim arsValores As String() = sResultado.Split(CChar(vbNewLine))

        ' Recorre los valores y establece los parámetros leídos.
        If arsValores.Length > 0 Then
            For Each sValor As String In arsValores
                If sValor.Contains("voice") Then
                    cmbGsmVoz.SelectedItem = sValor.Substring(sValor.IndexOf(":") + 1).Trim
                ElseIf sValor.Contains("data") Then
                    cmbGsmDatos.SelectedItem = sValor.Substring(sValor.IndexOf(":") + 1).Trim
                End If
            Next
        Else
            MessageBox.Show("There is no values")
        End If

        bModoConsulta = False
    End Sub
End Class
