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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lblCopyrigth As System.Windows.Forms.Label

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
        Me.lblCopyrigth = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblCompania = New System.Windows.Forms.LinkLabel()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rctBorde = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(7, 42)
        Me.lblProducto.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.lblProducto.MaximumSize = New System.Drawing.Size(0, 21)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(138, 17)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Nombre de producto"
        Me.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(7, 70)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.lblVersion.MaximumSize = New System.Drawing.Size(0, 21)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(56, 17)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Versión"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCopyrigth
        '
        Me.lblCopyrigth.AutoSize = True
        Me.lblCopyrigth.Location = New System.Drawing.Point(7, 98)
        Me.lblCopyrigth.Margin = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.lblCopyrigth.MaximumSize = New System.Drawing.Size(0, 21)
        Me.lblCopyrigth.Name = "lblCopyrigth"
        Me.lblCopyrigth.Size = New System.Drawing.Size(68, 17)
        Me.lblCopyrigth.TabIndex = 0
        Me.lblCopyrigth.Text = "Copyright"
        Me.lblCopyrigth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(10, 154)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescripcion.Size = New System.Drawing.Size(295, 79)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.TabStop = False
        Me.txtDescripcion.Text = resources.GetString("txtDescripcion.Text")
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(282, 2)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(28, 27)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCompania
        '
        Me.lblCompania.AutoSize = True
        Me.lblCompania.LinkColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCompania.Location = New System.Drawing.Point(7, 126)
        Me.lblCompania.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(71, 17)
        Me.lblCompania.TabIndex = 1
        Me.lblCompania.TabStop = True
        Me.lblCompania.Text = "Compañía"
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.lblAbout)
        Me.pnlTitulo.Controls.Add(Me.btnCerrar)
        Me.pnlTitulo.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(314, 32)
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
        Me.ShapeContainer1.Size = New System.Drawing.Size(316, 246)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'rctBorde
        '
        Me.rctBorde.Location = New System.Drawing.Point(0, 0)
        Me.rctBorde.Name = "rctBorde"
        Me.rctBorde.Size = New System.Drawing.Size(315, 245)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Avm.My.Resources.Resources.gsm64
        Me.PictureBox1.Location = New System.Drawing.Point(240, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FrmAcerca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(316, 246)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.lblCompania)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblCopyrigth)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAcerca"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCompania As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlTitulo As System.Windows.Forms.Panel
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rctBorde As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
