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
        Me.nudSenValor2 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor2 = New System.Windows.Forms.Label()
        Me.nudSenValor3 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor3 = New System.Windows.Forms.Label()
        Me.nudSenValor1 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor1 = New System.Windows.Forms.Label()
        Me.grpAcceleration = New System.Windows.Forms.GroupBox()
        Me.btnSetAcceleration = New System.Windows.Forms.Button()
        Me.grpMagnetic = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpOrientation = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpTemperature = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpProximity = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAcceleration.SuspendLayout()
        Me.grpMagnetic.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrientation.SuspendLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTemperature.SuspendLayout()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpProximity.SuspendLayout()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSenUpdate
        '
        Me.btnSenUpdate.Enabled = False
        Me.btnSenUpdate.Location = New System.Drawing.Point(4, 307)
        Me.btnSenUpdate.Name = "btnSenUpdate"
        Me.btnSenUpdate.Size = New System.Drawing.Size(70, 25)
        Me.btnSenUpdate.TabIndex = 29
        Me.btnSenUpdate.Text = "Update"
        Me.btnSenUpdate.UseVisualStyleBackColor = True
        '
        'nudSenValor2
        '
        Me.nudSenValor2.DecimalPlaces = 2
        Me.nudSenValor2.Enabled = False
        Me.nudSenValor2.Location = New System.Drawing.Point(54, 51)
        Me.nudSenValor2.Name = "nudSenValor2"
        Me.nudSenValor2.Size = New System.Drawing.Size(73, 23)
        Me.nudSenValor2.TabIndex = 22
        '
        'lblSenValor2
        '
        Me.lblSenValor2.AutoSize = True
        Me.lblSenValor2.Location = New System.Drawing.Point(3, 53)
        Me.lblSenValor2.Name = "lblSenValor2"
        Me.lblSenValor2.Size = New System.Drawing.Size(51, 17)
        Me.lblSenValor2.TabIndex = 26
        Me.lblSenValor2.Text = "Y-Axis:"
        '
        'nudSenValor3
        '
        Me.nudSenValor3.DecimalPlaces = 2
        Me.nudSenValor3.Enabled = False
        Me.nudSenValor3.Location = New System.Drawing.Point(54, 80)
        Me.nudSenValor3.Name = "nudSenValor3"
        Me.nudSenValor3.Size = New System.Drawing.Size(73, 23)
        Me.nudSenValor3.TabIndex = 23
        '
        'lblSenValor3
        '
        Me.lblSenValor3.AutoSize = True
        Me.lblSenValor3.Location = New System.Drawing.Point(3, 82)
        Me.lblSenValor3.Name = "lblSenValor3"
        Me.lblSenValor3.Size = New System.Drawing.Size(51, 17)
        Me.lblSenValor3.TabIndex = 25
        Me.lblSenValor3.Text = "Z-Axis:"
        '
        'nudSenValor1
        '
        Me.nudSenValor1.DecimalPlaces = 2
        Me.nudSenValor1.Enabled = False
        Me.nudSenValor1.Location = New System.Drawing.Point(54, 22)
        Me.nudSenValor1.Name = "nudSenValor1"
        Me.nudSenValor1.Size = New System.Drawing.Size(73, 23)
        Me.nudSenValor1.TabIndex = 20
        '
        'lblSenValor1
        '
        Me.lblSenValor1.AutoSize = True
        Me.lblSenValor1.Location = New System.Drawing.Point(3, 24)
        Me.lblSenValor1.Name = "lblSenValor1"
        Me.lblSenValor1.Size = New System.Drawing.Size(51, 17)
        Me.lblSenValor1.TabIndex = 21
        Me.lblSenValor1.Text = "X-Axis:"
        '
        'grpAcceleration
        '
        Me.grpAcceleration.Controls.Add(Me.btnSetAcceleration)
        Me.grpAcceleration.Controls.Add(Me.lblSenValor1)
        Me.grpAcceleration.Controls.Add(Me.nudSenValor1)
        Me.grpAcceleration.Controls.Add(Me.lblSenValor3)
        Me.grpAcceleration.Controls.Add(Me.nudSenValor3)
        Me.grpAcceleration.Controls.Add(Me.nudSenValor2)
        Me.grpAcceleration.Controls.Add(Me.lblSenValor2)
        Me.grpAcceleration.Location = New System.Drawing.Point(4, 5)
        Me.grpAcceleration.Name = "grpAcceleration"
        Me.grpAcceleration.Size = New System.Drawing.Size(133, 139)
        Me.grpAcceleration.TabIndex = 30
        Me.grpAcceleration.TabStop = False
        Me.grpAcceleration.Text = "Acceleration"
        '
        'btnSetAcceleration
        '
        Me.btnSetAcceleration.Location = New System.Drawing.Point(6, 109)
        Me.btnSetAcceleration.Name = "btnSetAcceleration"
        Me.btnSetAcceleration.Size = New System.Drawing.Size(121, 25)
        Me.btnSetAcceleration.TabIndex = 34
        Me.btnSetAcceleration.Text = "Set"
        Me.btnSetAcceleration.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSetAcceleration.UseVisualStyleBackColor = True
        '
        'grpMagnetic
        '
        Me.grpMagnetic.Controls.Add(Me.Button1)
        Me.grpMagnetic.Controls.Add(Me.NumericUpDown1)
        Me.grpMagnetic.Controls.Add(Me.NumericUpDown2)
        Me.grpMagnetic.Controls.Add(Me.NumericUpDown3)
        Me.grpMagnetic.Controls.Add(Me.Label3)
        Me.grpMagnetic.Controls.Add(Me.Label1)
        Me.grpMagnetic.Controls.Add(Me.Label2)
        Me.grpMagnetic.Location = New System.Drawing.Point(145, 5)
        Me.grpMagnetic.Name = "grpMagnetic"
        Me.grpMagnetic.Size = New System.Drawing.Size(132, 139)
        Me.grpMagnetic.TabIndex = 31
        Me.grpMagnetic.TabStop = False
        Me.grpMagnetic.Text = "Magnetic field"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 25)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Set"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(53, 22)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(73, 23)
        Me.NumericUpDown1.TabIndex = 20
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Location = New System.Drawing.Point(53, 80)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(73, 23)
        Me.NumericUpDown2.TabIndex = 23
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.DecimalPlaces = 2
        Me.NumericUpDown3.Enabled = False
        Me.NumericUpDown3.Location = New System.Drawing.Point(53, 51)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(73, 23)
        Me.NumericUpDown3.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Y-Axis:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "X-Axis:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Z-Axis:"
        '
        'grpOrientation
        '
        Me.grpOrientation.Controls.Add(Me.Button2)
        Me.grpOrientation.Controls.Add(Me.Label4)
        Me.grpOrientation.Controls.Add(Me.NumericUpDown4)
        Me.grpOrientation.Controls.Add(Me.Label5)
        Me.grpOrientation.Controls.Add(Me.NumericUpDown5)
        Me.grpOrientation.Controls.Add(Me.NumericUpDown6)
        Me.grpOrientation.Controls.Add(Me.Label6)
        Me.grpOrientation.Location = New System.Drawing.Point(4, 156)
        Me.grpOrientation.Name = "grpOrientation"
        Me.grpOrientation.Size = New System.Drawing.Size(133, 139)
        Me.grpOrientation.TabIndex = 31
        Me.grpOrientation.TabStop = False
        Me.grpOrientation.Text = "Orientation"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 25)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Set"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Azim:"
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.DecimalPlaces = 2
        Me.NumericUpDown4.Enabled = False
        Me.NumericUpDown4.Location = New System.Drawing.Point(54, 22)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(73, 23)
        Me.NumericUpDown4.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Roll:"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.DecimalPlaces = 2
        Me.NumericUpDown5.Enabled = False
        Me.NumericUpDown5.Location = New System.Drawing.Point(54, 80)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(73, 23)
        Me.NumericUpDown5.TabIndex = 23
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.DecimalPlaces = 2
        Me.NumericUpDown6.Enabled = False
        Me.NumericUpDown6.Location = New System.Drawing.Point(54, 51)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(73, 23)
        Me.NumericUpDown6.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Pitch:"
        '
        'grpTemperature
        '
        Me.grpTemperature.Controls.Add(Me.Button3)
        Me.grpTemperature.Controls.Add(Me.NumericUpDown7)
        Me.grpTemperature.Controls.Add(Me.Label7)
        Me.grpTemperature.Location = New System.Drawing.Point(145, 156)
        Me.grpTemperature.Name = "grpTemperature"
        Me.grpTemperature.Size = New System.Drawing.Size(132, 81)
        Me.grpTemperature.TabIndex = 32
        Me.grpTemperature.TabStop = False
        Me.grpTemperature.Text = "Temperature"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 25)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Set"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.DecimalPlaces = 2
        Me.NumericUpDown7.Enabled = False
        Me.NumericUpDown7.Location = New System.Drawing.Point(53, 22)
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(73, 23)
        Me.NumericUpDown7.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Temp:"
        '
        'grpProximity
        '
        Me.grpProximity.Controls.Add(Me.Button4)
        Me.grpProximity.Controls.Add(Me.NumericUpDown8)
        Me.grpProximity.Controls.Add(Me.Label8)
        Me.grpProximity.Location = New System.Drawing.Point(145, 248)
        Me.grpProximity.Name = "grpProximity"
        Me.grpProximity.Size = New System.Drawing.Size(132, 80)
        Me.grpProximity.TabIndex = 33
        Me.grpProximity.TabStop = False
        Me.grpProximity.Text = "Proximity"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 51)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 25)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Set"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.DecimalPlaces = 2
        Me.NumericUpDown8.Enabled = False
        Me.NumericUpDown8.Location = New System.Drawing.Point(53, 20)
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(73, 23)
        Me.NumericUpDown8.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Dist:"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(81, 307)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(56, 25)
        Me.btnHelp.TabIndex = 34
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'CtrSensor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.grpProximity)
        Me.Controls.Add(Me.grpTemperature)
        Me.Controls.Add(Me.grpOrientation)
        Me.Controls.Add(Me.grpMagnetic)
        Me.Controls.Add(Me.grpAcceleration)
        Me.Controls.Add(Me.btnSenUpdate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CtrSensor"
        Me.Size = New System.Drawing.Size(280, 338)
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAcceleration.ResumeLayout(False)
        Me.grpAcceleration.PerformLayout()
        Me.grpMagnetic.ResumeLayout(False)
        Me.grpMagnetic.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrientation.ResumeLayout(False)
        Me.grpOrientation.PerformLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTemperature.ResumeLayout(False)
        Me.grpTemperature.PerformLayout()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpProximity.ResumeLayout(False)
        Me.grpProximity.PerformLayout()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSenUpdate As System.Windows.Forms.Button
    Friend WithEvents nudSenValor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor2 As System.Windows.Forms.Label
    Friend WithEvents nudSenValor3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor3 As System.Windows.Forms.Label
    Friend WithEvents nudSenValor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor1 As System.Windows.Forms.Label
    Friend WithEvents grpAcceleration As System.Windows.Forms.GroupBox
    Friend WithEvents grpMagnetic As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpOrientation As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grpTemperature As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpProximity As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown8 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSetAcceleration As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button

End Class
