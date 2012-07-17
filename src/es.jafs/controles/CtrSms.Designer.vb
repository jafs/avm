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
        Me.txtSmsNumero.Location = New System.Drawing.Point(124, 14)
        Me.txtSmsNumero.MaxLength = 20
        Me.txtSmsNumero.Name = "txtSmsNumero"
        Me.txtSmsNumero.Size = New System.Drawing.Size(147, 23)
        Me.txtSmsNumero.TabIndex = 27
        Me.txtSmsNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttConsejo.SetToolTip(Me.txtSmsNumero, "Phone number of the sender")
        '
        'txtSmsPrefijo
        '
        Me.txtSmsPrefijo.Location = New System.Drawing.Point(73, 14)
        Me.txtSmsPrefijo.MaxLength = 4
        Me.txtSmsPrefijo.Name = "txtSmsPrefijo"
        Me.txtSmsPrefijo.Size = New System.Drawing.Size(45, 23)
        Me.txtSmsPrefijo.TabIndex = 26
        Me.txtSmsPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttConsejo.SetToolTip(Me.txtSmsPrefijo, "International prefix")
        '
        'btnSmsSend
        '
        Me.btnSmsSend.Enabled = False
        Me.btnSmsSend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSmsSend.Location = New System.Drawing.Point(193, 200)
        Me.btnSmsSend.Name = "btnSmsSend"
        Me.btnSmsSend.Size = New System.Drawing.Size(78, 26)
        Me.btnSmsSend.TabIndex = 29
        Me.btnSmsSend.Text = "Send"
        Me.ttConsejo.SetToolTip(Me.btnSmsSend, "Send message to emulator")
        Me.btnSmsSend.UseVisualStyleBackColor = True
        '
        'lblSmsTotal
        '
        Me.lblSmsTotal.AutoSize = True
        Me.lblSmsTotal.Location = New System.Drawing.Point(223, 51)
        Me.lblSmsTotal.Name = "lblSmsTotal"
        Me.lblSmsTotal.Size = New System.Drawing.Size(48, 17)
        Me.lblSmsTotal.TabIndex = 33
        Me.lblSmsTotal.Text = "of 160"
        '
        'lblSmsRest
        '
        Me.lblSmsRest.Location = New System.Drawing.Point(191, 47)
        Me.lblSmsRest.Name = "lblSmsRest"
        Me.lblSmsRest.Size = New System.Drawing.Size(35, 24)
        Me.lblSmsRest.TabIndex = 32
        Me.lblSmsRest.Text = "0"
        Me.lblSmsRest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSmsMessage
        '
        Me.txtSmsMessage.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSmsMessage.Location = New System.Drawing.Point(8, 72)
        Me.txtSmsMessage.MaxLength = 160
        Me.txtSmsMessage.Multiline = True
        Me.txtSmsMessage.Name = "txtSmsMessage"
        Me.txtSmsMessage.Size = New System.Drawing.Size(263, 122)
        Me.txtSmsMessage.TabIndex = 28
        '
        'lblSmsMessage
        '
        Me.lblSmsMessage.AutoSize = True
        Me.lblSmsMessage.Location = New System.Drawing.Point(5, 51)
        Me.lblSmsMessage.Name = "lblSmsMessage"
        Me.lblSmsMessage.Size = New System.Drawing.Size(69, 17)
        Me.lblSmsMessage.TabIndex = 31
        Me.lblSmsMessage.Text = "Message:"
        '
        'lblSmsNumber
        '
        Me.lblSmsNumber.AutoSize = True
        Me.lblSmsNumber.Location = New System.Drawing.Point(5, 17)
        Me.lblSmsNumber.Name = "lblSmsNumber"
        Me.lblSmsNumber.Size = New System.Drawing.Size(62, 17)
        Me.lblSmsNumber.TabIndex = 30
        Me.lblSmsNumber.Text = "Number:"
        '
        'lblSmsDesc
        '
        Me.lblSmsDesc.AutoSize = True
        Me.lblSmsDesc.Location = New System.Drawing.Point(75, 238)
        Me.lblSmsDesc.Name = "lblSmsDesc"
        Me.lblSmsDesc.Size = New System.Drawing.Size(204, 85)
        Me.lblSmsDesc.TabIndex = 34
        Me.lblSmsDesc.Text = "This function allows to send" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sms messages to the emulator." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter the sender pho" & _
    "ne, write" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the message, and press Send" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "button."
        '
        'imgSms
        '
        Me.imgSms.Image = Global.Avm.My.Resources.Resources.icoSms64
        Me.imgSms.Location = New System.Drawing.Point(8, 248)
        Me.imgSms.Name = "imgSms"
        Me.imgSms.Size = New System.Drawing.Size(64, 64)
        Me.imgSms.TabIndex = 35
        Me.imgSms.TabStop = False
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttConsejo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        '
        'CtrSms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CtrSms"
        Me.Size = New System.Drawing.Size(280, 338)
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
