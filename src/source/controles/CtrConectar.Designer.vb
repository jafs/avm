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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrConectar))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblPuerto = New System.Windows.Forms.Label()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        resources.ApplyResources(Me.lblInfo, "lblInfo")
        Me.lblInfo.Name = "lblInfo"
        '
        'btnConectar
        '
        resources.ApplyResources(Me.btnConectar, "btnConectar")
        Me.btnConectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnConectar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'lblError
        '
        resources.ApplyResources(Me.lblError, "lblError")
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblError.Name = "lblError"
        '
        'lblPuerto
        '
        resources.ApplyResources(Me.lblPuerto, "lblPuerto")
        Me.lblPuerto.Name = "lblPuerto"
        '
        'txtPuerto
        '
        resources.ApplyResources(Me.txtPuerto, "txtPuerto")
        Me.txtPuerto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPuerto.Name = "txtPuerto"
        '
        'CtrConectar
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.lblPuerto)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Name = "CtrConectar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblPuerto As System.Windows.Forms.Label
    Friend WithEvents txtPuerto As System.Windows.Forms.TextBox

End Class
