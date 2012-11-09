<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrSms
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrSms))
        Me.txtSmsNumero = New System.Windows.Forms.TextBox()
        Me.txtSmsPrefijo = New System.Windows.Forms.TextBox()
        Me.btnSmsSend = New System.Windows.Forms.Button()
        Me.lblSmsTotal = New System.Windows.Forms.Label()
        Me.lblSmsRest = New System.Windows.Forms.Label()
        Me.txtSmsMessage = New System.Windows.Forms.TextBox()
        Me.lblSmsMessage = New System.Windows.Forms.Label()
        Me.lblSmsNumber = New System.Windows.Forms.Label()
        Me.lblSmsDesc = New System.Windows.Forms.Label()
        Me.imgSms = New System.Windows.Forms.PictureBox()
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.imgSms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSmsNumero
        '
        resources.ApplyResources(Me.txtSmsNumero, "txtSmsNumero")
        Me.txtSmsNumero.Name = "txtSmsNumero"
        Me.ttConsejo.SetToolTip(Me.txtSmsNumero, resources.GetString("txtSmsNumero.ToolTip"))
        '
        'txtSmsPrefijo
        '
        resources.ApplyResources(Me.txtSmsPrefijo, "txtSmsPrefijo")
        Me.txtSmsPrefijo.Name = "txtSmsPrefijo"
        Me.ttConsejo.SetToolTip(Me.txtSmsPrefijo, resources.GetString("txtSmsPrefijo.ToolTip"))
        '
        'btnSmsSend
        '
        resources.ApplyResources(Me.btnSmsSend, "btnSmsSend")
        Me.btnSmsSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnSmsSend.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSmsSend.ForeColor = System.Drawing.Color.White
        Me.btnSmsSend.Name = "btnSmsSend"
        Me.ttConsejo.SetToolTip(Me.btnSmsSend, resources.GetString("btnSmsSend.ToolTip"))
        Me.btnSmsSend.UseVisualStyleBackColor = False
        '
        'lblSmsTotal
        '
        resources.ApplyResources(Me.lblSmsTotal, "lblSmsTotal")
        Me.lblSmsTotal.Name = "lblSmsTotal"
        Me.ttConsejo.SetToolTip(Me.lblSmsTotal, resources.GetString("lblSmsTotal.ToolTip"))
        '
        'lblSmsRest
        '
        resources.ApplyResources(Me.lblSmsRest, "lblSmsRest")
        Me.lblSmsRest.Name = "lblSmsRest"
        Me.ttConsejo.SetToolTip(Me.lblSmsRest, resources.GetString("lblSmsRest.ToolTip"))
        '
        'txtSmsMessage
        '
        resources.ApplyResources(Me.txtSmsMessage, "txtSmsMessage")
        Me.txtSmsMessage.Name = "txtSmsMessage"
        Me.ttConsejo.SetToolTip(Me.txtSmsMessage, resources.GetString("txtSmsMessage.ToolTip"))
        '
        'lblSmsMessage
        '
        resources.ApplyResources(Me.lblSmsMessage, "lblSmsMessage")
        Me.lblSmsMessage.Name = "lblSmsMessage"
        Me.ttConsejo.SetToolTip(Me.lblSmsMessage, resources.GetString("lblSmsMessage.ToolTip"))
        '
        'lblSmsNumber
        '
        resources.ApplyResources(Me.lblSmsNumber, "lblSmsNumber")
        Me.lblSmsNumber.Name = "lblSmsNumber"
        Me.ttConsejo.SetToolTip(Me.lblSmsNumber, resources.GetString("lblSmsNumber.ToolTip"))
        '
        'lblSmsDesc
        '
        resources.ApplyResources(Me.lblSmsDesc, "lblSmsDesc")
        Me.lblSmsDesc.Name = "lblSmsDesc"
        Me.ttConsejo.SetToolTip(Me.lblSmsDesc, resources.GetString("lblSmsDesc.ToolTip"))
        '
        'imgSms
        '
        resources.ApplyResources(Me.imgSms, "imgSms")
        Me.imgSms.Image = Global.Avm.My.Resources.Resources.icoSms64
        Me.imgSms.Name = "imgSms"
        Me.imgSms.TabStop = False
        Me.ttConsejo.SetToolTip(Me.imgSms, resources.GetString("imgSms.ToolTip"))
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttConsejo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        '
        'CtrSms
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblSmsDesc)
        Me.Controls.Add(Me.imgSms)
        Me.Controls.Add(Me.txtSmsNumero)
        Me.Controls.Add(Me.txtSmsPrefijo)
        Me.Controls.Add(Me.btnSmsSend)
        Me.Controls.Add(Me.lblSmsTotal)
        Me.Controls.Add(Me.lblSmsRest)
        Me.Controls.Add(Me.txtSmsMessage)
        Me.Controls.Add(Me.lblSmsMessage)
        Me.Controls.Add(Me.lblSmsNumber)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Name = "CtrSms"
        Me.ttConsejo.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        CType(Me.imgSms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSmsNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtSmsPrefijo As System.Windows.Forms.TextBox
    Friend WithEvents btnSmsSend As System.Windows.Forms.Button
    Friend WithEvents lblSmsTotal As System.Windows.Forms.Label
    Friend WithEvents lblSmsRest As System.Windows.Forms.Label
    Friend WithEvents txtSmsMessage As System.Windows.Forms.TextBox
    Friend WithEvents lblSmsMessage As System.Windows.Forms.Label
    Friend WithEvents lblSmsNumber As System.Windows.Forms.Label
    Friend WithEvents lblSmsDesc As System.Windows.Forms.Label
    Friend WithEvents imgSms As System.Windows.Forms.PictureBox
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip

End Class
