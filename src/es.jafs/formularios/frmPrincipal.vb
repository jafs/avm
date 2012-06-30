' Icons by: GNOME icon artistsAuthor http://gnome.org
'


Imports System.Net
Imports System.Net.Sockets
Imports System.Text


''' <summary>Clase de gestión de la interfaz gráfica.</summary>
Public Class frmPrincipal
    ''' <summary>Indica si hay conexión.</summary>
    Dim bConexion As Boolean = False
    ''' <summary>Objeto de conexión a Telnet.</summary>
    Dim objTelnet As New AndTelnet()


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
        If tcPestanas.Enabled Then
            If (chkCargaAc.Checked) Then
                enviarComando("power ac on")
            Else
                enviarComando("power ac off")
            End If
        End If
    End Sub


    ''' <summary>Controla cambios en el combo de estado de la batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub cmbBatStat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatStat.SelectedIndexChanged
        If tcPestanas.Enabled Then
            enviarComando("power status " + cmbBatStat.SelectedItem.ToString)
        End If
    End Sub


    ''' <summary>Controla cambios en el checkbox de presencia de batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub chkBatPresent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBatPresent.CheckedChanged
        If tcPestanas.Enabled Then
            enviarComando("power present " + chkBatPresent.Checked.ToString)
        End If
    End Sub


    ''' <summary>Controla cambios en el combo de salud de la batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub cmbBatHealth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatHealth.SelectedIndexChanged
        If tcPestanas.Enabled Then
            enviarComando("power health " + cmbBatHealth.SelectedItem.ToString)
        End If
    End Sub


    ''' <summary>Controla el clic sobre el cambio de capacidad de la batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnBatCapacity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatCapacity.Click
        enviarComando("power capacity " + nudBatCapacity.Value.ToString)
    End Sub


    ''' <summary>Controla el clic sobre el bótón de estado de batería.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub btnBatEstado_Click(sender As System.Object, e As System.EventArgs) Handles btnBatEstado.Click
        enviarComando("power display")
        getBateria()
    End Sub


    ''' <summary>Obtiene el estado de la batería.</summary>
    Private Sub getBateria()
        Dim sResultado As String = objTelnet.consultar("power display")
        sResultado = sResultado.Replace(vbCr & "" & vbCrLf, vbNewLine)

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
            MessageBox.Show("No hay valores")
        End If
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
        End If
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
            txtRecv.Text += sResultado

            bConexion = (sResultado.Contains("OK"))

            If bConexion Then
                getBateria()
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
        Else
            enviarComando("sensor set " & cmbSensores.SelectedItem.ToString & " " & _
                          Utilidades.decimalToCad(nudSenValor1.Value) & ":" & _
                          Utilidades.decimalToCad(nudSenValor2.Value) & ":" & _
                          Utilidades.decimalToCad(nudSenValor3.Value))
        End If
    End Sub


    ''' <summary>Actualiza el estado de sensores así como sus valores.</summary>
    ''' <param name="sSensor">Nombre del sensor</param>
    Private Sub cambiarSensor(ByRef sSensor As String)
        Select Case sSensor
            Case "acceleration", "magnetic-field"
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
            Case "orientation"
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
            Case "temperature"
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
            Case "proximity"
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
        Dim sResultado As String = objTelnet.consultar("sensor get " & sSensor)
        sResultado = sResultado.Replace(vbCr & "" & vbCrLf, vbNewLine)

        If sResultado.Contains("OK") Then
            Dim arsValores As String() = sResultado.Split(CChar(vbNewLine))

            If arsValores.Length > 0 Then
                For Each sValor As String In arsValores
                    If sValor.Contains(sSensor) Then
                        Dim sValores As String = sValor.Substring(sValor.IndexOf("=") + 2)
                        Dim arsDatos As String() = sValores.Split(CChar(":"))

                        Try
                            Select Case sSensor
                                Case "acceleration", "magnetic-field", "orientation"
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
End Class
