<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAcerca
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAcerca))
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblCompania = New System.Windows.Forms.LinkLabel()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rctBorde = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.linkCorreo = New System.Windows.Forms.LinkLabel()
        Me.lblIconos = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProducto
        '
        resources.ApplyResources(Me.lblProducto, "lblProducto")
        Me.lblProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblProducto.MaximumSize = New System.Drawing.Size(0, 21)
        Me.lblProducto.Name = "lblProducto"
        '
        'lblVersion
        '
        resources.ApplyResources(Me.lblVersion, "lblVersion")
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.MaximumSize = New System.Drawing.Size(0, 21)
        Me.lblVersion.Name = "lblVersion"
        '
        'btnCerrar
        '
        resources.ApplyResources(Me.btnCerrar, "btnCerrar")
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Name = "btnCerrar"
        '
        'lblCompania
        '
        resources.ApplyResources(Me.lblCompania, "lblCompania")
        Me.lblCompania.BackColor = System.Drawing.Color.Transparent
        Me.lblCompania.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblCompania.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.TabStop = True
        '
        'pnlTitulo
        '
        resources.ApplyResources(Me.pnlTitulo, "pnlTitulo")
        Me.pnlTitulo.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitulo.BackgroundImage = Global.Avm.My.Resources.Resources.superior
        Me.pnlTitulo.Controls.Add(Me.lblAbout)
        Me.pnlTitulo.Controls.Add(Me.btnCerrar)
        Me.pnlTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlTitulo.Name = "pnlTitulo"
        '
        'lblAbout
        '
        resources.ApplyResources(Me.lblAbout, "lblAbout")
        Me.lblAbout.Name = "lblAbout"
        '
        'ShapeContainer1
        '
        resources.ApplyResources(Me.ShapeContainer1, "ShapeContainer1")
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctBorde})
        Me.ShapeContainer1.TabStop = False
        '
        'rctBorde
        '
        resources.ApplyResources(Me.rctBorde, "rctBorde")
        Me.rctBorde.BackColor = System.Drawing.Color.Transparent
        Me.rctBorde.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.rctBorde.Name = "rctBorde"
        '
        'imgLogo
        '
        resources.ApplyResources(Me.imgLogo, "imgLogo")
        Me.imgLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgLogo.Image = Global.Avm.My.Resources.Resources.icono_tool64
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.TabStop = False
        '
        'linkCorreo
        '
        resources.ApplyResources(Me.linkCorreo, "linkCorreo")
        Me.linkCorreo.BackColor = System.Drawing.Color.Transparent
        Me.linkCorreo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.linkCorreo.Name = "linkCorreo"
        Me.linkCorreo.TabStop = True
        '
        'lblIconos
        '
        resources.ApplyResources(Me.lblIconos, "lblIconos")
        Me.lblIconos.BackColor = System.Drawing.Color.Transparent
        Me.lblIconos.Name = "lblIconos"
        '
        'FrmAcerca
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.CancelButton = Me.btnCerrar
        Me.Controls.Add(Me.lblIconos)
        Me.Controls.Add(Me.linkCorreo)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.lblCompania)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAcerca"
        Me.ShowInTaskbar = False
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCompania As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rctBorde As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents linkCorreo As System.Windows.Forms.LinkLabel
    Friend WithEvents lblIconos As System.Windows.Forms.Label

End Class
