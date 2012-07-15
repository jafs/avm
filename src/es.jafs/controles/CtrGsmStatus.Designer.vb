<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrGsmStatus
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
        Me.chkGsmBerOn = New System.Windows.Forms.CheckBox()
        Me.btnGsmSet = New System.Windows.Forms.Button()
        Me.chkGsmNoBer = New System.Windows.Forms.CheckBox()
        Me.nudGsmBer = New System.Windows.Forms.NumericUpDown()
        Me.chkGsmNoRssi = New System.Windows.Forms.CheckBox()
        Me.nudGsmRssi = New System.Windows.Forms.NumericUpDown()
        Me.lblGsmRssi = New System.Windows.Forms.Label()
        Me.btnGsmUpdate = New System.Windows.Forms.Button()
        Me.cmbGsmVoz = New System.Windows.Forms.ComboBox()
        Me.lblGsmVoz = New System.Windows.Forms.Label()
        Me.cmbGsmDatos = New System.Windows.Forms.ComboBox()
        Me.lblGsmDatos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgGsm = New System.Windows.Forms.PictureBox()
        CType(Me.nudGsmBer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGsmRssi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgGsm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkGsmBerOn
        '
        Me.chkGsmBerOn.AutoSize = True
        Me.chkGsmBerOn.Location = New System.Drawing.Point(9, 125)
        Me.chkGsmBerOn.Name = "chkGsmBerOn"
        Me.chkGsmBerOn.Size = New System.Drawing.Size(59, 21)
        Me.chkGsmBerOn.TabIndex = 47
        Me.chkGsmBerOn.Text = "BER:"
        Me.chkGsmBerOn.UseVisualStyleBackColor = True
        '
        'btnGsmSet
        '
        Me.btnGsmSet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnGsmSet.Location = New System.Drawing.Point(222, 90)
        Me.btnGsmSet.Name = "btnGsmSet"
        Me.btnGsmSet.Size = New System.Drawing.Size(47, 58)
        Me.btnGsmSet.TabIndex = 46
        Me.btnGsmSet.Text = "Set"
        Me.btnGsmSet.UseVisualStyleBackColor = True
        '
        'chkGsmNoBer
        '
        Me.chkGsmNoBer.AutoSize = True
        Me.chkGsmNoBer.Enabled = False
        Me.chkGsmNoBer.Location = New System.Drawing.Point(131, 125)
        Me.chkGsmNoBer.Name = "chkGsmNoBer"
        Me.chkGsmNoBer.Size = New System.Drawing.Size(85, 21)
        Me.chkGsmNoBer.TabIndex = 45
        Me.chkGsmNoBer.Text = "Unknown"
        Me.chkGsmNoBer.UseVisualStyleBackColor = True
        '
        'nudGsmBer
        '
        Me.nudGsmBer.Enabled = False
        Me.nudGsmBer.Location = New System.Drawing.Point(74, 125)
        Me.nudGsmBer.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.nudGsmBer.Name = "nudGsmBer"
        Me.nudGsmBer.Size = New System.Drawing.Size(48, 23)
        Me.nudGsmBer.TabIndex = 44
        '
        'chkGsmNoRssi
        '
        Me.chkGsmNoRssi.AutoSize = True
        Me.chkGsmNoRssi.Location = New System.Drawing.Point(131, 91)
        Me.chkGsmNoRssi.Name = "chkGsmNoRssi"
        Me.chkGsmNoRssi.Size = New System.Drawing.Size(85, 21)
        Me.chkGsmNoRssi.TabIndex = 43
        Me.chkGsmNoRssi.Text = "Unknown"
        Me.chkGsmNoRssi.UseVisualStyleBackColor = True
        '
        'nudGsmRssi
        '
        Me.nudGsmRssi.Location = New System.Drawing.Point(74, 90)
        Me.nudGsmRssi.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nudGsmRssi.Name = "nudGsmRssi"
        Me.nudGsmRssi.Size = New System.Drawing.Size(48, 23)
        Me.nudGsmRssi.TabIndex = 42
        '
        'lblGsmRssi
        '
        Me.lblGsmRssi.AutoSize = True
        Me.lblGsmRssi.Location = New System.Drawing.Point(6, 92)
        Me.lblGsmRssi.Name = "lblGsmRssi"
        Me.lblGsmRssi.Size = New System.Drawing.Size(43, 17)
        Me.lblGsmRssi.TabIndex = 41
        Me.lblGsmRssi.Text = "RSSI:"
        '
        'btnGsmUpdate
        '
        Me.btnGsmUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnGsmUpdate.Location = New System.Drawing.Point(9, 172)
        Me.btnGsmUpdate.Name = "btnGsmUpdate"
        Me.btnGsmUpdate.Size = New System.Drawing.Size(130, 32)
        Me.btnGsmUpdate.TabIndex = 40
        Me.btnGsmUpdate.Text = "Update"
        Me.btnGsmUpdate.UseVisualStyleBackColor = True
        '
        'cmbGsmVoz
        '
        Me.cmbGsmVoz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGsmVoz.FormattingEnabled = True
        Me.cmbGsmVoz.Items.AddRange(New Object() {"unregistered", "home", "roaming", "searching", "denied", "off", "on"})
        Me.cmbGsmVoz.Location = New System.Drawing.Point(61, 54)
        Me.cmbGsmVoz.Name = "cmbGsmVoz"
        Me.cmbGsmVoz.Size = New System.Drawing.Size(208, 24)
        Me.cmbGsmVoz.TabIndex = 39
        '
        'lblGsmVoz
        '
        Me.lblGsmVoz.AutoSize = True
        Me.lblGsmVoz.Location = New System.Drawing.Point(6, 55)
        Me.lblGsmVoz.Name = "lblGsmVoz"
        Me.lblGsmVoz.Size = New System.Drawing.Size(47, 17)
        Me.lblGsmVoz.TabIndex = 38
        Me.lblGsmVoz.Text = "Voice:"
        '
        'cmbGsmDatos
        '
        Me.cmbGsmDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGsmDatos.FormattingEnabled = True
        Me.cmbGsmDatos.Items.AddRange(New Object() {"unregistered", "home", "roaming", "searching", "denied", "off", "on"})
        Me.cmbGsmDatos.Location = New System.Drawing.Point(61, 18)
        Me.cmbGsmDatos.Name = "cmbGsmDatos"
        Me.cmbGsmDatos.Size = New System.Drawing.Size(208, 24)
        Me.cmbGsmDatos.TabIndex = 37
        '
        'lblGsmDatos
        '
        Me.lblGsmDatos.AutoSize = True
        Me.lblGsmDatos.Location = New System.Drawing.Point(6, 21)
        Me.lblGsmDatos.Name = "lblGsmDatos"
        Me.lblGsmDatos.Size = New System.Drawing.Size(42, 17)
        Me.lblGsmDatos.TabIndex = 36
        Me.lblGsmDatos.Text = "Data:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 68)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "The first GSM tab, allows to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "change the status of data and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "voice, and set the s" & _
    "ignal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "levels."
        '
        'imgGsm
        '
        Me.imgGsm.Image = Global.Avm.My.Resources.Resources.gsm64
        Me.imgGsm.Location = New System.Drawing.Point(9, 253)
        Me.imgGsm.Name = "imgGsm"
        Me.imgGsm.Size = New System.Drawing.Size(64, 64)
        Me.imgGsm.TabIndex = 49
        Me.imgGsm.TabStop = False
        '
        'CtrGsmStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgGsm)
        Me.Controls.Add(Me.btnGsmSet)
        Me.Controls.Add(Me.chkGsmNoBer)
        Me.Controls.Add(Me.nudGsmBer)
        Me.Controls.Add(Me.chkGsmNoRssi)
        Me.Controls.Add(Me.nudGsmRssi)
        Me.Controls.Add(Me.lblGsmRssi)
        Me.Controls.Add(Me.btnGsmUpdate)
        Me.Controls.Add(Me.cmbGsmVoz)
        Me.Controls.Add(Me.lblGsmVoz)
        Me.Controls.Add(Me.cmbGsmDatos)
        Me.Controls.Add(Me.lblGsmDatos)
        Me.Controls.Add(Me.chkGsmBerOn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CtrGsmStatus"
        Me.Size = New System.Drawing.Size(280, 338)
        CType(Me.nudGsmBer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGsmRssi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgGsm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkGsmBerOn As System.Windows.Forms.CheckBox
    Friend WithEvents btnGsmSet As System.Windows.Forms.Button
    Friend WithEvents chkGsmNoBer As System.Windows.Forms.CheckBox
    Friend WithEvents nudGsmBer As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkGsmNoRssi As System.Windows.Forms.CheckBox
    Friend WithEvents nudGsmRssi As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGsmRssi As System.Windows.Forms.Label
    Friend WithEvents btnGsmUpdate As System.Windows.Forms.Button
    Friend WithEvents cmbGsmVoz As System.Windows.Forms.ComboBox
    Friend WithEvents lblGsmVoz As System.Windows.Forms.Label
    Friend WithEvents cmbGsmDatos As System.Windows.Forms.ComboBox
    Friend WithEvents lblGsmDatos As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents imgGsm As System.Windows.Forms.PictureBox

End Class
