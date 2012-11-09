Public Class CtrSms
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
    ''' <summary>Controla el cambio en el texto de mensaje.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub txtSmsMessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSmsMessage.TextChanged
        lblSmsRest.Text = txtSmsMessage.Text.Length.ToString
        btnSmsSend.Enabled = (txtSmsNumero.Text.Length > 0 And txtSmsMessage.Text.Length > 0)
    End Sub


    ''' <summary>Controla el cambio en el texto de número de teléfono.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub txtSmsNumero_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSmsNumero.TextChanged
        btnSmsSend.Enabled = (txtSmsNumero.Text.Length > 0 And txtSmsMessage.Text.Length > 0)
    End Sub


    ''' <summary>Clic sobre el botón de envío de SMS.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnSmsSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSmsSend.Click
        enviarSms()
    End Sub


    ' ######################################
    ' GENERAL
    ' ######################################
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
                MessageBox.Show(Idioma.traducir("err_call_prefix"), Idioma.traducir("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSmsPrefijo.Focus()
                txtSmsPrefijo.SelectAll()
                bValido = False
            End If
        End If

        ' Validación de número.
        If bValido Then
            If Llamada.isNumber(txtSmsNumero.Text) Then
                sNumero &= txtSmsNumero.Text
            Else
                MessageBox.Show(Idioma.traducir("err_call_number"), Idioma.traducir("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSmsNumero.Focus()
                txtSmsNumero.SelectAll()
                bValido = False
            End If
        End If

        ' Envío de mensaje si todo es correcto.
        If bValido Then
            If txtSmsMessage.Text.Length = 0 Then
                MessageBox.Show(Idioma.traducir("err_sms_send"), Idioma.traducir("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSmsMessage.Focus()
            Else
                frmPadre.enviarComando(Comando.SMS_SEND & sNumero & " " & txtSmsMessage.Text)
            End If
        End If
    End Sub
End Class
