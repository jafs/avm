<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrConectar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblPuerto = New System.Windows.Forms.Label()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInfo.Location = New System.Drawing.Point(35, 22)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(210, 80)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = "Welcome to Android Virtual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Management. To start, enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a valid port for connect" & _
    " to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "emulator and press connect."
        '
        'btnConectar
        '
        Me.btnConectar.FlatAppearance.BorderSize = 0
        Me.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConectar.Image = Global.Avm.My.Resources.Resources.icoGps64
        Me.btnConectar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConectar.Location = New System.Drawing.Point(95, 175)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(90, 90)
        Me.btnConectar.TabIndex = 2
        Me.btnConectar.Text = "Connect"
        Me.btnConectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblError.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblError.Location = New System.Drawing.Point(46, 285)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(186, 40)
        Me.lblError.TabIndex = 4
        Me.lblError.Text = "Enter a valid port number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(between 1 and 65535)"
        Me.lblError.Visible = False
        '
        'lblPuerto
        '
        Me.lblPuerto.AutoSize = True
        Me.lblPuerto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPuerto.Location = New System.Drawing.Point(83, 145)
        Me.lblPuerto.Name = "lblPuerto"
        Me.lblPuerto.Size = New System.Drawing.Size(42, 20)
        Me.lblPuerto.TabIndex = 0
        Me.lblPuerto.Text = "Port:"
        '
        'txtPuerto
        '
        Me.txtPuerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPuerto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtPuerto.Location = New System.Drawing.Point(131, 142)
        Me.txtPuerto.MaxLength = 5
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(67, 26)
        Me.txtPuerto.TabIndex = 1
        Me.txtPuerto.Text = "5554"
        Me.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CtrConectar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.lblPuerto)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CtrConectar"
        Me.Size = New System.Drawing.Size(280, 338)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblPuerto As System.Windows.Forms.Label
    Friend WithEvents txtPuerto As System.Windows.Forms.TextBox

End Class
