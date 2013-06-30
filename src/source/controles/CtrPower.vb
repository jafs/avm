Public Class CtrPower
    ''' <summary>Formulario padre del actual.</summary>
    Private frmPadre As FrmPrincipal


    ''' <summary>Constructor por defecto para la clase.</summary>
    ''' <param name="frmPadreR">Formulario padre.</param>
    Public Sub New(ByRef frmPadreR As FrmPrincipal)
        InitializeComponent()
        frmPadre = frmPadreR
    End Sub


    ' ######################################
    ' MANEJADORES
    ' ######################################
    ''' <summary>Controla cambios del checkbox de carga AC.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub chkCargaAc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCargaAc.CheckedChanged
        If Not frmPadre.Consulta Then
            If (chkCargaAc.Checked) Then
                frmPadre.enviarComando(Comando.POWER_AC_ON)
            Else
                frmPadre.enviarComando(Comando.POWER_AC_OFF)
            End If
        End If
    End Sub


    ''' <summary>Controla cambios en el combo de estado de la batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub cmbBatStat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatStat.SelectedIndexChanged
        If Not frmPadre.Consulta Then
            frmPadre.enviarComando(Comando.POWER_STATUS + cmbBatStat.SelectedItem.ToString)
        End If
    End Sub


    ''' <summary>Controla cambios en el checkbox de presencia de batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub chkBatPresent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBatPresent.CheckedChanged
        If Not frmPadre.Consulta Then
            frmPadre.enviarComando(Comando.POWER_PRESENT + chkBatPresent.Checked.ToString)
        End If
    End Sub


    ''' <summary>Controla cambios en el combo de salud de la batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub cmbBatHealth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBatHealth.SelectedIndexChanged
        If Not frmPadre.Consulta Then
            frmPadre.enviarComando(Comando.POWER_HEALTH + cmbBatHealth.SelectedItem.ToString)
        End If
    End Sub


    ''' <summary>Controla el clic sobre el cambio de capacidad de la batería.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnBatCapacity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatCapacity.Click
        frmPadre.enviarComando(Comando.POWER_CAPACITY + nudBatCapacity.Value.ToString)
    End Sub


    ''' <summary>Controla el clic sobre el bótón de estado de batería.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub btnBatEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatActualiza.Click
        frmPadre.enviarComando(Comando.POWER_DISPLAY)
        getBateria()
    End Sub


    ' ######################################
    ' GENERAL
    ' ######################################
    ''' <summary>Obtiene el estado de la batería.</summary>
    Public Sub getBateria()
        Dim sResultado As String = frmPadre.consultar(Comando.POWER_DISPLAY)

        If Not sResultado Is Nothing Then
            frmPadre.Consulta = True

            Dim arsValores As String() = sResultado.Split(CChar(vbNewLine))

            If arsValores.Length > 0 Then
                For Each sValor As String In arsValores
                    If sValor.Contains("AC:") Then
                        chkCargaAc.Checked = sValor.Contains("online")
                    ElseIf sValor.Contains("status:") Then
                        Dim arsEstado As String() = sValor.Split(CChar(" "))
                        cmbBatStat.SelectedItem = arsEstado(1)
                    ElseIf sValor.Contains("health:") Then
                        ' Cuando hay un fallo la cadena es distinta.
                        If sValor.Contains("failure") Then
                            cmbBatHealth.SelectedItem = "Failure"
                        Else
                            Dim arsEstado As String() = sValor.Split(CChar(" "))

                            ' Controla el bug de estado.
                            If "Overhead" = arsEstado(1) Then
                                arsEstado(1) = "Overheat"
                            End If

                            cmbBatHealth.SelectedItem = arsEstado(1)
                        End If
                    ElseIf sValor.Contains("present:") Then
                        chkBatPresent.Checked = sValor.Contains("true")
                    ElseIf sValor.Contains("capacity:") Then
                        Dim arsEstado As String() = sValor.Split(CChar(" "))
                        nudBatCapacity.Value = Integer.Parse(arsEstado(1))
                    End If
                Next
            End If

            ' Establece el valor de energía con los valores cargados actualmente.
            Try
                frmPadre.setPower(chkCargaAc.Checked, AndroidStatus.getPowerStatus(cmbBatStat.SelectedItem.ToString), _
                                AndroidStatus.getPowerHealth(cmbBatHealth.SelectedItem.ToString), chkBatPresent.Checked, _
                                Convert.ToInt32(nudBatCapacity.Value))
            Catch exception As Exception
            End Try

            frmPadre.Consulta = False
        End If
    End Sub
End Class
