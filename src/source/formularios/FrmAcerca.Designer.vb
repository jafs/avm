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
        Me.lblProducto.AutoSize = True
        Me.lblProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(7, 42)
        Me.lblProducto.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.lblProducto.MaximumSize = New System.Drawing.Size(0, 21)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(172, 20)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Nombre de producto"
        Me.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Location = New System.Drawing.Point(7, 62)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.lblVersion.MaximumSize = New System.Drawing.Size(0, 21)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(56, 17)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Versión"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(281, 2)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCompania
        '
        Me.lblCompania.AutoSize = True
        Me.lblCompania.BackColor = System.Drawing.Color.Transparent
        Me.lblCompania.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.lblCompania.LinkColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.lblCompania.Location = New System.Drawing.Point(7, 92)
        Me.lblCompania.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(71, 17)
        Me.lblCompania.TabIndex = 1
        Me.lblCompania.TabStop = True
        Me.lblCompania.Text = "Compañía"
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitulo.BackgroundImage = Global.Avm.My.Resources.Resources.superior
        Me.pnlTitulo.Controls.Add(Me.lblAbout)
        Me.pnlTitulo.Controls.Add(Me.btnCerrar)
        Me.pnlTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlTitulo.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(312, 32)
        Me.pnlTitulo.TabIndex = 2
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Location = New System.Drawing.Point(7, 8)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(45, 17)
        Me.lblAbout.TabIndex = 1
        Me.lblAbout.Text = "About"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctBorde})
        Me.ShapeContainer1.Size = New System.Drawing.Size(314, 163)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'rctBorde
        '
        Me.rctBorde.BackColor = System.Drawing.Color.Transparent
        Me.rctBorde.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.rctBorde.Location = New System.Drawing.Point(0, 0)
        Me.rctBorde.Name = "rctBorde"
        Me.rctBorde.Size = New System.Drawing.Size(313, 162)
        '
        'imgLogo
        '
        Me.imgLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgLogo.Image = Global.Avm.My.Resources.Resources.icono_tool64
        Me.imgLogo.Location = New System.Drawing.Point(240, 42)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(64, 64)
        Me.imgLogo.TabIndex = 4
        Me.imgLogo.TabStop = False
        '
        'linkCorreo
        '
        Me.linkCorreo.AutoSize = True
        Me.linkCorreo.BackColor = System.Drawing.Color.Transparent
        Me.linkCorreo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.linkCorreo.Location = New System.Drawing.Point(8, 114)
        Me.linkCorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkCorreo.Name = "linkCorreo"
        Me.linkCorreo.Size = New System.Drawing.Size(85, 17)
        Me.linkCorreo.TabIndex = 5
        Me.linkCorreo.TabStop = True
        Me.linkCorreo.Text = "jafs@jafs.es"
        '
        'lblIconos
        '
        Me.lblIconos.AutoSize = True
        Me.lblIconos.BackColor = System.Drawing.Color.Transparent
        Me.lblIconos.Location = New System.Drawing.Point(8, 136)
        Me.lblIconos.Name = "lblIconos"
        Me.lblIconos.Size = New System.Drawing.Size(207, 17)
        Me.lblIconos.TabIndex = 6
        Me.lblIconos.Text = "Icons by: http://www.gnome.org/"
        '
        'FrmAcerca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(314, 163)
        Me.Controls.Add(Me.lblIconos)
        Me.Controls.Add(Me.linkCorreo)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.lblCompania)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAcerca"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
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
