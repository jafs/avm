<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrPower
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
        Me.lblBatDesc = New System.Windows.Forms.Label()
        Me.btnBatActualiza = New System.Windows.Forms.Button()
        Me.btnBatCapacity = New System.Windows.Forms.Button()
        Me.lblBatCapacity = New System.Windows.Forms.Label()
        Me.cmbBatHealth = New System.Windows.Forms.ComboBox()
        Me.lblBatHealth = New System.Windows.Forms.Label()
        Me.chkBatPresent = New System.Windows.Forms.CheckBox()
        Me.nudBatCapacity = New System.Windows.Forms.NumericUpDown()
        Me.cmbBatStat = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.chkCargaAc = New System.Windows.Forms.CheckBox()
        Me.imgBateria = New System.Windows.Forms.PictureBox()
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBateria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBatDesc
        '
        Me.lblBatDesc.AutoSize = True
        Me.lblBatDesc.Location = New System.Drawing.Point(80, 225)
        Me.lblBatDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBatDesc.Name = "lblBatDesc"
        Me.lblBatDesc.Size = New System.Drawing.Size(195, 85)
        Me.lblBatDesc.TabIndex = 25
        Me.lblBatDesc.Text = "In this section you can control" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all the battery and energy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "settings. The update" & _
    " button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "allows to refresh de battery" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "info into fields."
        '
        'btnBatActualiza
        '
        Me.btnBatActualiza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBatActualiza.Location = New System.Drawing.Point(12, 172)
        Me.btnBatActualiza.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBatActualiza.Name = "btnBatActualiza"
        Me.btnBatActualiza.Size = New System.Drawing.Size(100, 27)
        Me.btnBatActualiza.TabIndex = 22
        Me.btnBatActualiza.Text = "Update"
        Me.btnBatActualiza.UseVisualStyleBackColor = True
        '
        'btnBatCapacity
        '
        Me.btnBatCapacity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBatCapacity.Location = New System.Drawing.Point(178, 95)
        Me.btnBatCapacity.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBatCapacity.Name = "btnBatCapacity"
        Me.btnBatCapacity.Size = New System.Drawing.Size(90, 26)
        Me.btnBatCapacity.TabIndex = 19
        Me.btnBatCapacity.Text = "Set"
        Me.btnBatCapacity.UseVisualStyleBackColor = True
        '
        'lblBatCapacity
        '
        Me.lblBatCapacity.AutoSize = True
        Me.lblBatCapacity.Location = New System.Drawing.Point(9, 99)
        Me.lblBatCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBatCapacity.Name = "lblBatCapacity"
        Me.lblBatCapacity.Size = New System.Drawing.Size(66, 17)
        Me.lblBatCapacity.TabIndex = 24
        Me.lblBatCapacity.Text = "Capacity:"
        '
        'cmbBatHealth
        '
        Me.cmbBatHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatHealth.FormattingEnabled = True
        Me.cmbBatHealth.Items.AddRange(New Object() {"Unknown", "Good", "Overheat", "Dead", "Overvoltage", "Failure"})
        Me.cmbBatHealth.Location = New System.Drawing.Point(108, 55)
        Me.cmbBatHealth.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBatHealth.Name = "cmbBatHealth"
        Me.cmbBatHealth.Size = New System.Drawing.Size(160, 24)
        Me.cmbBatHealth.TabIndex = 16
        '
        'lblBatHealth
        '
        Me.lblBatHealth.AutoSize = True
        Me.lblBatHealth.Location = New System.Drawing.Point(9, 58)
        Me.lblBatHealth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBatHealth.Name = "lblBatHealth"
        Me.lblBatHealth.Size = New System.Drawing.Size(100, 17)
        Me.lblBatHealth.TabIndex = 23
        Me.lblBatHealth.Text = "Battery health:"
        '
        'chkBatPresent
        '
        Me.chkBatPresent.AutoSize = True
        Me.chkBatPresent.Location = New System.Drawing.Point(12, 138)
        Me.chkBatPresent.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBatPresent.Name = "chkBatPresent"
        Me.chkBatPresent.Size = New System.Drawing.Size(124, 21)
        Me.chkBatPresent.TabIndex = 20
        Me.chkBatPresent.Text = "Battery present"
        Me.chkBatPresent.UseVisualStyleBackColor = True
        '
        'nudBatCapacity
        '
        Me.nudBatCapacity.Location = New System.Drawing.Point(108, 97)
        Me.nudBatCapacity.Margin = New System.Windows.Forms.Padding(4)
        Me.nudBatCapacity.Name = "nudBatCapacity"
        Me.nudBatCapacity.Size = New System.Drawing.Size(62, 23)
        Me.nudBatCapacity.TabIndex = 17
        Me.nudBatCapacity.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'cmbBatStat
        '
        Me.cmbBatStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatStat.FormattingEnabled = True
        Me.cmbBatStat.Items.AddRange(New Object() {"Unknown", "Charging", "Discharging", "Not-charging", "Full"})
        Me.cmbBatStat.Location = New System.Drawing.Point(108, 14)
        Me.cmbBatStat.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBatStat.Name = "cmbBatStat"
        Me.cmbBatStat.Size = New System.Drawing.Size(160, 24)
        Me.cmbBatStat.TabIndex = 15
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(9, 17)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(99, 17)
        Me.lblEstado.TabIndex = 18
        Me.lblEstado.Text = "Battery status:"
        '
        'chkCargaAc
        '
        Me.chkCargaAc.AutoSize = True
        Me.chkCargaAc.Location = New System.Drawing.Point(162, 138)
        Me.chkCargaAc.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCargaAc.Name = "chkCargaAc"
        Me.chkCargaAc.Size = New System.Drawing.Size(106, 21)
        Me.chkCargaAc.TabIndex = 21
        Me.chkCargaAc.Text = "AC Charging"
        Me.chkCargaAc.UseVisualStyleBackColor = True
        '
        'imgBateria
        '
        Me.imgBateria.Image = Global.Avm.My.Resources.Resources.icoBateria64
        Me.imgBateria.Location = New System.Drawing.Point(10, 234)
        Me.imgBateria.Margin = New System.Windows.Forms.Padding(4)
        Me.imgBateria.Name = "imgBateria"
        Me.imgBateria.Size = New System.Drawing.Size(64, 64)
        Me.imgBateria.TabIndex = 26
        Me.imgBateria.TabStop = False
        '
        'CtrPower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.imgBateria)
        Me.Controls.Add(Me.lblBatDesc)
        Me.Controls.Add(Me.btnBatActualiza)
        Me.Controls.Add(Me.btnBatCapacity)
        Me.Controls.Add(Me.lblBatCapacity)
        Me.Controls.Add(Me.cmbBatHealth)
        Me.Controls.Add(Me.lblBatHealth)
        Me.Controls.Add(Me.chkBatPresent)
        Me.Controls.Add(Me.nudBatCapacity)
        Me.Controls.Add(Me.cmbBatStat)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.chkCargaAc)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CtrPower"
        Me.Size = New System.Drawing.Size(280, 338)
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBateria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgBateria As System.Windows.Forms.PictureBox
    Friend WithEvents lblBatDesc As System.Windows.Forms.Label
    Friend WithEvents btnBatActualiza As System.Windows.Forms.Button
    Friend WithEvents btnBatCapacity As System.Windows.Forms.Button
    Friend WithEvents lblBatCapacity As System.Windows.Forms.Label
    Friend WithEvents cmbBatHealth As System.Windows.Forms.ComboBox
    Friend WithEvents lblBatHealth As System.Windows.Forms.Label
    Friend WithEvents chkBatPresent As System.Windows.Forms.CheckBox
    Friend WithEvents nudBatCapacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbBatStat As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents chkCargaAc As System.Windows.Forms.CheckBox

End Class
