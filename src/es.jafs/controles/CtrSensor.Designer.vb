<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrSensor
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
        Me.btnSenUpdate = New System.Windows.Forms.Button()
        Me.lblSenDesc = New System.Windows.Forms.Label()
        Me.btnSenSet = New System.Windows.Forms.Button()
        Me.nudSenValor2 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor2 = New System.Windows.Forms.Label()
        Me.nudSenValor3 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor3 = New System.Windows.Forms.Label()
        Me.nudSenValor1 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor1 = New System.Windows.Forms.Label()
        Me.lblSensor = New System.Windows.Forms.Label()
        Me.cmbSensores = New System.Windows.Forms.ComboBox()
        Me.imgSensores = New System.Windows.Forms.PictureBox()
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSensores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSenUpdate
        '
        Me.btnSenUpdate.Enabled = False
        Me.btnSenUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSenUpdate.Location = New System.Drawing.Point(190, 127)
        Me.btnSenUpdate.Name = "btnSenUpdate"
        Me.btnSenUpdate.Size = New System.Drawing.Size(75, 32)
        Me.btnSenUpdate.TabIndex = 29
        Me.btnSenUpdate.Text = "Update"
        Me.btnSenUpdate.UseVisualStyleBackColor = True
        '
        'lblSenDesc
        '
        Me.lblSenDesc.AutoSize = True
        Me.lblSenDesc.Location = New System.Drawing.Point(82, 235)
        Me.lblSenDesc.Name = "lblSenDesc"
        Me.lblSenDesc.Size = New System.Drawing.Size(187, 68)
        Me.lblSenDesc.TabIndex = 27
        Me.lblSenDesc.Text = "In this tab you can set the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensor values. Select a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensor, set the values and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "press the Set Values button."
        '
        'btnSenSet
        '
        Me.btnSenSet.Enabled = False
        Me.btnSenSet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSenSet.Location = New System.Drawing.Point(190, 58)
        Me.btnSenSet.Name = "btnSenSet"
        Me.btnSenSet.Size = New System.Drawing.Size(75, 61)
        Me.btnSenSet.TabIndex = 24
        Me.btnSenSet.Text = "Set" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Values"
        Me.btnSenSet.UseVisualStyleBackColor = True
        '
        'nudSenValor2
        '
        Me.nudSenValor2.DecimalPlaces = 4
        Me.nudSenValor2.Enabled = False
        Me.nudSenValor2.Location = New System.Drawing.Point(92, 97)
        Me.nudSenValor2.Name = "nudSenValor2"
        Me.nudSenValor2.Size = New System.Drawing.Size(90, 23)
        Me.nudSenValor2.TabIndex = 22
        '
        'lblSenValor2
        '
        Me.lblSenValor2.AutoSize = True
        Me.lblSenValor2.Location = New System.Drawing.Point(16, 100)
        Me.lblSenValor2.Name = "lblSenValor2"
        Me.lblSenValor2.Size = New System.Drawing.Size(69, 17)
        Me.lblSenValor2.TabIndex = 26
        Me.lblSenValor2.Text = "Not used:"
        '
        'nudSenValor3
        '
        Me.nudSenValor3.DecimalPlaces = 4
        Me.nudSenValor3.Enabled = False
        Me.nudSenValor3.Location = New System.Drawing.Point(92, 135)
        Me.nudSenValor3.Name = "nudSenValor3"
        Me.nudSenValor3.Size = New System.Drawing.Size(90, 23)
        Me.nudSenValor3.TabIndex = 23
        '
        'lblSenValor3
        '
        Me.lblSenValor3.AutoSize = True
        Me.lblSenValor3.Location = New System.Drawing.Point(16, 138)
        Me.lblSenValor3.Name = "lblSenValor3"
        Me.lblSenValor3.Size = New System.Drawing.Size(69, 17)
        Me.lblSenValor3.TabIndex = 25
        Me.lblSenValor3.Text = "Not used:"
        '
        'nudSenValor1
        '
        Me.nudSenValor1.DecimalPlaces = 4
        Me.nudSenValor1.Enabled = False
        Me.nudSenValor1.Location = New System.Drawing.Point(92, 59)
        Me.nudSenValor1.Name = "nudSenValor1"
        Me.nudSenValor1.Size = New System.Drawing.Size(90, 23)
        Me.nudSenValor1.TabIndex = 20
        '
        'lblSenValor1
        '
        Me.lblSenValor1.AutoSize = True
        Me.lblSenValor1.Location = New System.Drawing.Point(16, 61)
        Me.lblSenValor1.Name = "lblSenValor1"
        Me.lblSenValor1.Size = New System.Drawing.Size(69, 17)
        Me.lblSenValor1.TabIndex = 21
        Me.lblSenValor1.Text = "Not used:"
        '
        'lblSensor
        '
        Me.lblSensor.AutoSize = True
        Me.lblSensor.Location = New System.Drawing.Point(16, 23)
        Me.lblSensor.Name = "lblSensor"
        Me.lblSensor.Size = New System.Drawing.Size(57, 17)
        Me.lblSensor.TabIndex = 19
        Me.lblSensor.Text = "Sensor:"
        '
        'cmbSensores
        '
        Me.cmbSensores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSensores.FormattingEnabled = True
        Me.cmbSensores.Items.AddRange(New Object() {"acceleration", "magnetic-field", "orientation", "temperature", "proximity"})
        Me.cmbSensores.Location = New System.Drawing.Point(92, 20)
        Me.cmbSensores.Name = "cmbSensores"
        Me.cmbSensores.Size = New System.Drawing.Size(173, 24)
        Me.cmbSensores.TabIndex = 18
        '
        'imgSensores
        '
        Me.imgSensores.Image = Global.avm.My.Resources.Resources.sensores64
        Me.imgSensores.Location = New System.Drawing.Point(12, 239)
        Me.imgSensores.Name = "imgSensores"
        Me.imgSensores.Size = New System.Drawing.Size(64, 64)
        Me.imgSensores.TabIndex = 28
        Me.imgSensores.TabStop = False
        '
        'CtrSensor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.btnSenUpdate)
        Me.Controls.Add(Me.lblSenDesc)
        Me.Controls.Add(Me.btnSenSet)
        Me.Controls.Add(Me.nudSenValor2)
        Me.Controls.Add(Me.lblSenValor2)
        Me.Controls.Add(Me.nudSenValor3)
        Me.Controls.Add(Me.lblSenValor3)
        Me.Controls.Add(Me.nudSenValor1)
        Me.Controls.Add(Me.lblSenValor1)
        Me.Controls.Add(Me.lblSensor)
        Me.Controls.Add(Me.cmbSensores)
        Me.Controls.Add(Me.imgSensores)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CtrSensor"
        Me.Size = New System.Drawing.Size(280, 338)
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSensores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSenUpdate As System.Windows.Forms.Button
    Friend WithEvents lblSenDesc As System.Windows.Forms.Label
    Friend WithEvents btnSenSet As System.Windows.Forms.Button
    Friend WithEvents nudSenValor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor2 As System.Windows.Forms.Label
    Friend WithEvents nudSenValor3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor3 As System.Windows.Forms.Label
    Friend WithEvents nudSenValor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor1 As System.Windows.Forms.Label
    Friend WithEvents lblSensor As System.Windows.Forms.Label
    Friend WithEvents cmbSensores As System.Windows.Forms.ComboBox
    Friend WithEvents imgSensores As System.Windows.Forms.PictureBox

End Class
