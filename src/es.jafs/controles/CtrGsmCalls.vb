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
    ''' <summary>Realiza una llamada entrante con el número indicado.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnGsmCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGsmCall.Click
        Dim sNumero As String = Nothing
        Dim bValido As Boolean = True

        txtGsmNumero.Focus()

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
            ' Verifica si son todo valores numéricos.
            Dim bNumerico As Boolean = True
            Dim i As Integer = 0
            While bNumerico And i < txtGsmNumero.Text.Length
                Dim iNumero As Integer
                If Not Integer.TryParse(txtGsmNumero.Text(i), iNumero) Then
                    bNumerico = False
                End If
                i += 1
            End While

            ' Validación de número y realización de la llamada si todo es correcto.
            If bNumerico Then
                sNumero &= txtGsmNumero.Text
                frmPadre.enviarComando(Comando.GSM_CALL & sNumero)
                txtGsmNumero.Text = String.Empty
                txtGsmPrefijo.Text = String.Empty
            Else
                MessageBox.Show("Enter a valid phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        ' Controla los clics para las celdas 1, 5 y 6 que contienen los botones.
        If e.ColumnIndex > 3 Then
            Dim iFila As Integer = e.RowIndex
            Dim sNumero As String = dgvGsmLlamadas.Rows(iFila).Cells(1).Value.ToString

            Select Case e.ColumnIndex
                Case 4
                    ' Botón espera/aceptar
                    Dim sEstado As String = dgvGsmLlamadas.Rows(iFila).Cells(3).Value.ToString
                    If sEstado = Llamada.EstadoLlamada.active.ToString Then
                        frmPadre.enviarComando(Comando.GSM_HOLD & sNumero)
                    ElseIf sEstado = Llamada.EstadoLlamada.held.ToString Then
                        frmPadre.enviarComando(Comando.GSM_ACCEPT & sNumero)
                    End If

                Case 5
                    ' Botón ocupado
                    If dgvGsmLlamadas.Rows(iFila).Cells(2).Value.ToString = Llamada.TipoLlamada.outbound.ToString Then
                        frmPadre.enviarComando(Comando.GSM_BUSY & sNumero)
                    End If

                Case 6
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

        ' Si el resultado es nulo no hay conexión.
        If sResultado Is Nothing Then
            tmrGsm.Enabled = False
        Else
            ' Si se obtuvieron resultados se procede a su análisis.
            If sResultado.Length > 0 Then
                Dim lsActuales As New List(Of Llamada)
                Dim arsFilas() As String = sResultado.Split(CChar(vbNewLine))
                Dim objLlamada As Llamada = Nothing

                ' Analiza las filas una a una e intenta extraer los datos de cada llamada.
                For Each sFila As String In arsFilas
                    objLlamada = New Llamada()
                    If objLlamada.fromString(sFila) Then
                        lsActuales.Add(objLlamada)
                    End If
                Next

                ' Actualiza los datos de llamadas.
                dgvGsmLlamadas.Rows.Clear()
                Dim iActual As Integer = 0
                For Each objLlamada In lsActuales
                    iActual = dgvGsmLlamadas.Rows.Add(objLlamada.toArray())

                    ' Tooltip para columna de tipo
                    dgvGsmLlamadas.Rows(iActual).Cells(0).ToolTipText = objLlamada.Tipo.ToString

                    ' Tooltip para columna de estado
                    Select Case objLlamada.Estado
                        Case Llamada.EstadoLlamada.active
                            dgvGsmLlamadas.Rows(iActual).Cells(4).ToolTipText = Llamada.GSM_HOLD
                        Case Llamada.EstadoLlamada.held
                            dgvGsmLlamadas.Rows(iActual).Cells(4).ToolTipText = Llamada.GSM_ACCEPT
                        Case Llamada.EstadoLlamada.unknown
                            dgvGsmLlamadas.Rows(iActual).Cells(4).ToolTipText = Llamada.GSM_UNKNOWN
                        Case Else
                            dgvGsmLlamadas.Rows(iActual).Cells(4).ToolTipText = Llamada.GSM_CONNECTING
                    End Select

                    ' Tooltip para columna de ocupado
                    If objLlamada.Tipo = Llamada.TipoLlamada.outbound Then
                        dgvGsmLlamadas.Rows(iActual).Cells(5).ToolTipText = Llamada.GSM_BUSY
                    Else
                        dgvGsmLlamadas.Rows(iActual).Cells(5).ToolTipText = Llamada.GSM_NOT_ALLOWED
                    End If

                    ' Tooltip para columna de finalización de llamada
                    dgvGsmLlamadas.Rows(iActual).Cells(6).ToolTipText = Llamada.GSM_CANCEL
                Next
            Else
                dgvGsmLlamadas.Rows.Clear()
            End If
        End If
    End Sub


    ''' <summary>Inicia la monitorización de llamadas.</summary>
    Public Sub iniciar()
        tmrGsm.Enabled = True
        actualizarLlamadas()
    End Sub


    ''' <summary>Detiene la monitorización de llamadas.</summary>
    Public Sub parar()
        tmrGsm.Enabled = False
    End Sub
End Class
