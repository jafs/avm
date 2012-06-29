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
End Class
