Public Class CtrGps
    ''' <summary>Formulario padre.</summary>
    Dim frmPadre As FrmPrincipal


    ''' <summary>Constructor por defecto de la clase.</summary>
    ''' <param name="frmParent">Formulario padre.</param>
    Public Sub New(ByRef frmParent As FrmPrincipal)
        InitializeComponent()
        frmPadre = frmParent
    End Sub


    ' ######################################
    ' MANEJADORES
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
    Private Sub chkGpsSatelites_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGpsSatelites.CheckedChanged
        nudGpsSatelites.Enabled = chkGpsSatelites.Checked
    End Sub


    ''' <summary>Envía la información de GPS al sistema.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub btnGpsSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGpsSet.Click
        Dim dLontitud As Decimal
        Dim dLatitud As Decimal
        Dim sSentencia As String = String.Empty

        ' Obtiene longitud y latitud, y compone la sentencia.
        dLontitud = nudGpsLonGrados.Value + (nudGpsLonMin.Value / 60) + (nudGpsLonSec.Value / 3600)
        dLatitud = nudGpsLatGrados.Value + (nudGpsLatMin.Value / 60) + (nudGpsLatSec.Value / 3600)
        sSentencia = Utilidades.decimalToCad(dLontitud) & " " & Utilidades.decimalToCad(dLatitud)

        ' Añade los datos de altitud y satélites si están activos.
        If chkGpsAltitude.Checked Then
            sSentencia &= " " & Utilidades.decimalToCad(nudGpsAltitude.Value)

            If chkGpsSatelites.Checked Then
                sSentencia &= " " & nudGpsSatelites.Value
            End If
        End If

        frmPadre.enviarComando(Comando.GEO_FIX & sSentencia)
    End Sub
End Class
