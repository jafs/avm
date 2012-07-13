Public Class CtrSensor
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
    ''' <summary>Controla el cambio de sensor.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub cmbSensores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSensores.SelectedIndexChanged
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
    Private Sub btnSenUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSenUpdate.Click
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
    Private Sub btnSenSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSenSet.Click
        If cmbSensores.SelectedItem Is Nothing Then
            MessageBox.Show("You must to select a sensor.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbSensores.Focus()
        Else
            frmPadre.enviarComando(Comando.SENSOR_SET & cmbSensores.SelectedItem.ToString & " " & _
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


    ' ######################################
    ' GENERAL
    ' ######################################
    ''' <summary>Obtiene el estado del sensor recibido como argumento.</summary>
    ''' <param name="sSensor">Nombre del sensor</param>
    Private Sub getSensor(ByRef sSensor As String)
        Dim sResultado As String = frmPadre.consultar(Comando.SENSOR_GET & sSensor)

        If Not sResultado Is Nothing Then
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
        End If
    End Sub
End Class
