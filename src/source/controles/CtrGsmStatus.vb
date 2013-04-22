Public Class CtrGsmStatus
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
    ''' <summary>Establece el nivel de señal GSM.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub btnGsmSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGsmSet.Click
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

        frmPadre.enviarComando(Comando.GSM_SIGNAL & sSentencia)
    End Sub


    ''' <summary>Activa/desactiva el envío de datos de señal BER.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub chkGsmBerOn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGsmBerOn.CheckedChanged
        nudGsmBer.Enabled = chkGsmBerOn.Checked
        chkGsmNoBer.Enabled = chkGsmBerOn.Checked
    End Sub


    ''' <summary>Controla si está marcado el checkbox desconocido de RSSI, para evitar que se modifiquen los valores.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub chkGsmNoRssi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGsmNoRssi.CheckedChanged
        nudGsmRssi.Enabled = Not chkGsmNoRssi.Checked
    End Sub


    ''' <summary>Controla si está marcado el checkbox desconocido de BER, para evitar que se modifiquen los valores.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub chkGsmNoBer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGsmNoBer.CheckedChanged
        If chkGsmBerOn.Checked Then
            nudGsmBer.Enabled = Not chkGsmNoBer.Checked
        End If
    End Sub


    ''' <summary>Establece el estado de datos GSM.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub cmbGsmDatos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGsmDatos.SelectedIndexChanged
        If Not frmPadre.Consulta Then
            frmPadre.enviarComando(Comando.GSM_DATA + cmbGsmDatos.SelectedItem.ToString)
        End If
    End Sub


    ''' <summary>Establece el estado de voz GSM.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub cmbGsmVoz_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGsmVoz.SelectedIndexChanged
        If Not frmPadre.Consulta Then
            frmPadre.enviarComando(Comando.GSM_VOICE + cmbGsmVoz.SelectedItem.ToString)
        End If
    End Sub

    ''' <summary>Controla el click sobre el botón de actualización de datos GSM.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub btnGsmUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGsmUpdate.Click
        frmPadre.enviarComando(Comando.GSM_STATUS)
        getGsmStatus()
    End Sub


    ' ######################################
    ' GENERAL
    ' ######################################
    ''' <summary>Obtiene el estado de datos y voz GSM.</summary>
    Public Sub getGsmStatus()
        Dim sResultado As String = frmPadre.consultar(Comando.GSM_STATUS)

        If Not sResultado Is Nothing Then
            sResultado = sResultado.Replace(vbCr & "" & vbCrLf, vbNewLine)
            frmPadre.Consulta = True

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
            End If

            frmPadre.Consulta = False
        End If
    End Sub
End Class
