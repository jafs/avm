Public NotInheritable Class FrmAcerca
    ''' <summary>Carga los campos al cargar el formulario.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub FrmAcerca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Obtiene el título del formulario.
        Dim sTitulo As String
        If My.Application.Info.Title <> "" Then
            sTitulo = My.Application.Info.Title
        Else
            sTitulo = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        lblAbout.Text = String.Format("About {0}", sTitulo)

        ' Carga los valores del resto de campos
        lblProducto.Text = My.Application.Info.ProductName
        lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        lblCompania.Text = My.Application.Info.Copyright

        Utilidades.addControl(CType(btnCerrar, Control))
    End Sub


    ''' <summary>Cierra el formulario.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    ''' <summary>Abre una ventana de navegador con enlace a la información de la aplicación.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub lblCompania_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblCompania.LinkClicked
        System.Diagnostics.Process.Start(My.Resources.sUrlAplicacion)
    End Sub


    ''' <summary>Permite enviar un correo de contacto.</summary>
    ''' <param name="sender">Emisor del evento</param>
    ''' <param name="e">Datos del evento</param>
    Private Sub linkCorreo_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCorreo.LinkClicked
        System.Diagnostics.Process.Start("mailto:" & My.Resources.sUrlCorreo)
    End Sub
End Class
