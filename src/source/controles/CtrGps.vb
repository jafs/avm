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
    Private Sub chkGpsAltitudeCheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkGpsAltitude.CheckedChanged
        nudGpsAltitude.Enabled = chkGpsAltitude.Checked
        chkGpsSatelites.Enabled = chkGpsAltitude.Checked
    End Sub


    ''' <summary>Controla el estado de envío de satélites.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub chkGpsSatelitesCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGpsSatelites.CheckedChanged
        nudGpsSatelites.Enabled = chkGpsSatelites.Checked
    End Sub


    ''' <summary>Envía la información de GPS al sistema.</summary>
    ''' <param name="sender">Emisor del evento.</param>
    ''' <param name="e">Datos del evento.</param>
    Private Sub btnGpsSetClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGpsSet.Click
        Dim dLontitud As Decimal
        Dim dLatitud As Decimal
        Dim sSentencia As String = String.Empty

        ' Obtiene longitud y latitud, y compone la sentencia.
        dLontitud = nudGpsLonGrados.Value
        If dLontitud > 0 Then
            dLontitud += (nudGpsLonMin.Value / 60) + (nudGpsLonSec.Value / 3600)
        Else
            dLontitud -= (nudGpsLonMin.Value / 60) + (nudGpsLonSec.Value / 3600)
        End If

        dLatitud = nudGpsLatGrados.Value
        If dLatitud > 0 Then
            dLatitud += (nudGpsLatMin.Value / 60) + (nudGpsLatSec.Value / 3600)
        Else
            dLatitud -= (nudGpsLatMin.Value / 60) + (nudGpsLatSec.Value / 3600)
        End If


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


    ''' <summary>Controla los cambios en los grados de longitud.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub nudGpsLonGradosValueChanged(sender As System.Object, e As System.EventArgs) Handles nudGpsLonGrados.ValueChanged
        ' Si los grados han llegado a su límite se ponen los valores de minutos y segundos a 0, ya
        ' que no se pueden superar dichos valores. Además se desactivan los controles.
        If nudGpsLonGrados.Value = 180 Or nudGpsLonGrados.Value = -180 Then
            nudGpsLonMin.Value = 0
            nudGpsLonSec.Value = 0
            nudGpsLonMin.Enabled = False
            nudGpsLonSec.Enabled = False
        Else
            ' Si los valores de grados no son los límites se permite la edición de minutos y
            ' segundos.
            If Not nudGpsLonMin.Enabled Then
                nudGpsLonMin.Enabled = True
            End If
            If Not nudGpsLonSec.Enabled Then
                nudGpsLonSec.Enabled = True
            End If
        End If
    End Sub


    ''' <summary>Controla los cambios en los grados de latitud.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub nudGpsLatGradosValueChanged(sender As System.Object, e As System.EventArgs) Handles nudGpsLatGrados.ValueChanged
        ' Si los grados han llegado a su límite se ponen los valores de minutos y segundos a 0, ya
        ' que no se pueden superar dichos valores. Además se desactivan los controles.
        If nudGpsLatGrados.Value = 90 Or nudGpsLatGrados.Value = -90 Then
            nudGpsLatMin.Value = 0
            nudGpsLatSec.Value = 0
            nudGpsLatMin.Enabled = False
            nudGpsLatSec.Enabled = False
        Else
            ' Si los valores de grados no son los límites se permite la edición de minutos y
            ' segundos.
            If Not nudGpsLatMin.Enabled Then
                nudGpsLatMin.Enabled = True
            End If
            If Not nudGpsLatSec.Enabled Then
                nudGpsLatSec.Enabled = True
            End If
        End If
    End Sub
End Class
