Public Class CtrGsmCalls
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
    ''' <summary>Activa/desactiva el monitor de llamadas.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub chkGsmTimer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGsmTimer.CheckedChanged
        tmrGsm.Enabled = chkGsmTimer.Checked

        If chkGsmTimer.Checked Then
            chkGsmTimer.Text = "Disable Monitor"
            chkGsmTimer.BackColor = Drawing.Color.FromArgb(255, 220, 230)
            actualizarLlamadas()
        Else
            chkGsmTimer.Text = "Enable Monitor"
            chkGsmTimer.BackColor = Drawing.Color.FromArgb(220, 255, 230)
        End If
    End Sub


    ''' <summary>Realiza una llamada entrante con el número indicado.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnGsmCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGsmCall.Click
        Dim sNumero As String = Nothing
        Dim bValido As Boolean = True

        ' Validación de prefijo.
        If txtGsmPrefijo.Text.Length > 0 Then
            Dim iNumero As Integer = 0
            If Integer.TryParse(txtGsmPrefijo.Text, iNumero) Then
                sNumero = "+" & iNumero
            Else
                MessageBox.Show("Enter a valid prefix", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtGsmPrefijo.Focus()
                txtGsmPrefijo.SelectAll()
                bValido = False
            End If
        End If

        If bValido Then
            Dim iNumero As Integer = 0
            If Integer.TryParse(txtGsmNumero.Text, iNumero) Then
                ' Validación de número y realización de la llamada si todo es correcto.
                sNumero &= iNumero
                frmPadre.enviarComando(Comando.GSM_CALL & sNumero)
                txtGsmNumero.Text = String.Empty
                txtGsmPrefijo.Text = String.Empty
            Else
                MessageBox.Show("Enter a valid phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtGsmNumero.Focus()
                txtGsmNumero.SelectAll()
            End If
        End If
    End Sub


    ''' <summary>
    ''' Realiza la actualización de llamadas actuales en cada tick de reloj.
    ''' </summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub tmrGsm_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGsm.Tick
        actualizarLlamadas()
    End Sub


    ''' <summary>
    ''' Controla el click sobre los botones de acción de la lista.
    ''' </summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub dgvGsmLlamadas_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGsmLlamadas.CellClick
        ' Controla los clics para las celdas 5 a 7 que contienen los botones.
        If e.ColumnIndex > 4 Then
            Dim iFila As Integer = e.RowIndex
            Dim sNumero As String = dgvGsmLlamadas.Rows(iFila).Cells(2).Value.ToString

            Select Case e.ColumnIndex
                Case 5
                    ' Botón espera/aceptar
                    Dim sEstado As String = dgvGsmLlamadas.Rows(iFila).Cells(4).Value.ToString
                    If sEstado = Llamada.EstadoLlamada.active.ToString Then
                        frmPadre.enviarComando(Comando.GSM_HOLD & sNumero)
                    ElseIf sEstado = Llamada.EstadoLlamada.held.ToString Then
                        frmPadre.enviarComando(Comando.GSM_ACCEPT & sNumero)
                    End If

                Case 6
                    ' Botón ocupado
                    If dgvGsmLlamadas.Rows(iFila).Cells(3).Value.ToString = Llamada.TipoLlamada.outbound.ToString Then
                        frmPadre.enviarComando(Comando.GSM_BUSY & sNumero)
                    End If

                Case 7
                    ' Botón cancelar
                    frmPadre.enviarComando(Comando.GSM_CANCEL & sNumero)
            End Select
        End If
    End Sub


    ' ######################################
    ' GENERAL
    ' ######################################
    ''' <summary>
    ''' Actualiza la lista de llamadas.
    ''' </summary>
    Private Sub actualizarLlamadas()
        Dim sResultado As String = frmPadre.consultar(Comando.GSM_LIST)

        ' Si se obtuvieron resultados se procede a su análisis.
        If sResultado.Length > 0 Then
            Dim mActuales As New Hashtable()
            Dim arsFilas() As String = sResultado.Split(CChar(vbNewLine))
            Dim objLlamada As Llamada = Nothing

            ' Analiza las filas una a una e intenta extraer los datos de cada llamada.
            For Each sFila As String In arsFilas
                objLlamada = New Llamada()
                If objLlamada.fromString(sFila) Then
                    mActuales.Add(objLlamada.Numero, objLlamada)
                End If
            Next

            ' Actualiza los datos de llamadas.
            dgvGsmLlamadas.Rows.Clear()
            For Each objLlamada In mActuales.Values
                dgvGsmLlamadas.Rows.Add(objLlamada.toArray())
            Next
        Else
            dgvGsmLlamadas.Rows.Clear()
        End If
    End Sub
End Class
