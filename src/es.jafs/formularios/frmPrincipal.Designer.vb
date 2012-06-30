<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.txtRecv = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblPuerto = New System.Windows.Forms.Label()
        Me.txtPuerto = New System.Windows.Forms.MaskedTextBox()
        Me.txtComando = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.tcPestanas = New System.Windows.Forms.TabControl()
        Me.tpBattery = New System.Windows.Forms.TabPage()
        Me.btnBatEstado = New System.Windows.Forms.Button()
        Me.btnBatCapacity = New System.Windows.Forms.Button()
        Me.lblBatCapacity = New System.Windows.Forms.Label()
        Me.cmbBatHealth = New System.Windows.Forms.ComboBox()
        Me.lblBatHealth = New System.Windows.Forms.Label()
        Me.chkBatPresent = New System.Windows.Forms.CheckBox()
        Me.nudBatCapacity = New System.Windows.Forms.NumericUpDown()
        Me.cmbBatStat = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.chkCargaAc = New System.Windows.Forms.CheckBox()
        Me.imIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.imMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.scDivisor = New System.Windows.Forms.SplitContainer()
        Me.lblBattery = New System.Windows.Forms.Label()
        Me.tpSensors = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbSensores = New System.Windows.Forms.ComboBox()
        Me.lblSensor = New System.Windows.Forms.Label()
        Me.lblSenValor1 = New System.Windows.Forms.Label()
        Me.nudSenValor1 = New System.Windows.Forms.NumericUpDown()
        Me.nudSenValor3 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor3 = New System.Windows.Forms.Label()
        Me.nudSenValor2 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor2 = New System.Windows.Forms.Label()
        Me.btnSenSet = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSenUpdate = New System.Windows.Forms.Button()
        Me.tcPestanas.SuspendLayout()
        Me.tpBattery.SuspendLayout()
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scDivisor.Panel1.SuspendLayout()
        Me.scDivisor.Panel2.SuspendLayout()
        Me.scDivisor.SuspendLayout()
        Me.tpSensors.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(8, 5)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(98, 27)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Connect"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'txtRecv
        '
        Me.txtRecv.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecv.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRecv.Location = New System.Drawing.Point(0, 0)
        Me.txtRecv.Multiline = True
        Me.txtRecv.Name = "txtRecv"
        Me.txtRecv.ReadOnly = True
        Me.txtRecv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecv.Size = New System.Drawing.Size(461, 189)
        Me.txtRecv.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(390, 6)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 24)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Exit"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblPuerto
        '
        Me.lblPuerto.AutoSize = True
        Me.lblPuerto.Location = New System.Drawing.Point(112, 12)
        Me.lblPuerto.Name = "lblPuerto"
        Me.lblPuerto.Size = New System.Drawing.Size(29, 13)
        Me.lblPuerto.TabIndex = 4
        Me.lblPuerto.Text = "Port:"
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(139, 9)
        Me.txtPuerto.Mask = "99999"
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPuerto.Size = New System.Drawing.Size(50, 20)
        Me.txtPuerto.TabIndex = 1
        Me.txtPuerto.Text = "5554"
        '
        'txtComando
        '
        Me.txtComando.AutoCompleteCustomSource.AddRange(New String() {"avd", "cdma", "event", "exit", "geo", "gsm", "h", "help", "kill", "network", "power", "power display", "power ac", "power ac on", "power ac off", "qemu", "quit", "redir", "sensor", "sensor status", "sensor get", "sensor get acceleration", "sensor get magnetic-field", "sensor get orientation", "sensor get temperature", "sensor get proximity", "sensor set", "sms", "window", "?"})
        Me.txtComando.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtComando.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtComando.Enabled = False
        Me.txtComando.Location = New System.Drawing.Point(0, 195)
        Me.txtComando.Name = "txtComando"
        Me.txtComando.Size = New System.Drawing.Size(380, 20)
        Me.txtComando.TabIndex = 6
        '
        'btnEnviar
        '
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Location = New System.Drawing.Point(386, 193)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Send"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'tcPestanas
        '
        Me.tcPestanas.Controls.Add(Me.tpBattery)
        Me.tcPestanas.Controls.Add(Me.tpSensors)
        Me.tcPestanas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcPestanas.Enabled = False
        Me.tcPestanas.HotTrack = True
        Me.tcPestanas.ImageList = Me.imIconos
        Me.tcPestanas.Location = New System.Drawing.Point(0, 0)
        Me.tcPestanas.Name = "tcPestanas"
        Me.tcPestanas.SelectedIndex = 0
        Me.tcPestanas.Size = New System.Drawing.Size(461, 160)
        Me.tcPestanas.TabIndex = 8
        '
        'tpBattery
        '
        Me.tpBattery.Controls.Add(Me.PictureBox1)
        Me.tpBattery.Controls.Add(Me.lblBattery)
        Me.tpBattery.Controls.Add(Me.btnBatEstado)
        Me.tpBattery.Controls.Add(Me.btnBatCapacity)
        Me.tpBattery.Controls.Add(Me.lblBatCapacity)
        Me.tpBattery.Controls.Add(Me.cmbBatHealth)
        Me.tpBattery.Controls.Add(Me.lblBatHealth)
        Me.tpBattery.Controls.Add(Me.chkBatPresent)
        Me.tpBattery.Controls.Add(Me.nudBatCapacity)
        Me.tpBattery.Controls.Add(Me.cmbBatStat)
        Me.tpBattery.Controls.Add(Me.lblEstado)
        Me.tpBattery.Controls.Add(Me.chkCargaAc)
        Me.tpBattery.ImageIndex = 0
        Me.tpBattery.Location = New System.Drawing.Point(4, 23)
        Me.tpBattery.Name = "tpBattery"
        Me.tpBattery.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBattery.Size = New System.Drawing.Size(453, 133)
        Me.tpBattery.TabIndex = 0
        Me.tpBattery.Text = "Battery"
        Me.tpBattery.UseVisualStyleBackColor = True
        '
        'btnBatEstado
        '
        Me.btnBatEstado.Location = New System.Drawing.Point(144, 103)
        Me.btnBatEstado.Name = "btnBatEstado"
        Me.btnBatEstado.Size = New System.Drawing.Size(75, 23)
        Me.btnBatEstado.TabIndex = 7
        Me.btnBatEstado.Text = "Update"
        Me.btnBatEstado.UseVisualStyleBackColor = True
        '
        'btnBatCapacity
        '
        Me.btnBatCapacity.Location = New System.Drawing.Point(151, 60)
        Me.btnBatCapacity.Name = "btnBatCapacity"
        Me.btnBatCapacity.Size = New System.Drawing.Size(68, 20)
        Me.btnBatCapacity.TabIndex = 4
        Me.btnBatCapacity.Text = "Set"
        Me.btnBatCapacity.UseVisualStyleBackColor = True
        '
        'lblBatCapacity
        '
        Me.lblBatCapacity.AutoSize = True
        Me.lblBatCapacity.Location = New System.Drawing.Point(6, 62)
        Me.lblBatCapacity.Name = "lblBatCapacity"
        Me.lblBatCapacity.Size = New System.Drawing.Size(86, 13)
        Me.lblBatCapacity.TabIndex = 10
        Me.lblBatCapacity.Text = "Battery capacity:"
        '
        'cmbBatHealth
        '
        Me.cmbBatHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatHealth.FormattingEnabled = True
        Me.cmbBatHealth.Items.AddRange(New Object() {"Unknown", "Good", "Overheat", "Dead", "Overvoltage", "Failure"})
        Me.cmbBatHealth.Location = New System.Drawing.Point(98, 33)
        Me.cmbBatHealth.Name = "cmbBatHealth"
        Me.cmbBatHealth.Size = New System.Drawing.Size(121, 21)
        Me.cmbBatHealth.TabIndex = 2
        '
        'lblBatHealth
        '
        Me.lblBatHealth.AutoSize = True
        Me.lblBatHealth.Location = New System.Drawing.Point(6, 36)
        Me.lblBatHealth.Name = "lblBatHealth"
        Me.lblBatHealth.Size = New System.Drawing.Size(75, 13)
        Me.lblBatHealth.TabIndex = 8
        Me.lblBatHealth.Text = "Battery health:"
        '
        'chkBatPresent
        '
        Me.chkBatPresent.AutoSize = True
        Me.chkBatPresent.Location = New System.Drawing.Point(9, 86)
        Me.chkBatPresent.Name = "chkBatPresent"
        Me.chkBatPresent.Size = New System.Drawing.Size(97, 17)
        Me.chkBatPresent.TabIndex = 5
        Me.chkBatPresent.Text = "Battery present"
        Me.chkBatPresent.UseVisualStyleBackColor = True
        '
        'nudBatCapacity
        '
        Me.nudBatCapacity.Location = New System.Drawing.Point(98, 60)
        Me.nudBatCapacity.Name = "nudBatCapacity"
        Me.nudBatCapacity.Size = New System.Drawing.Size(47, 20)
        Me.nudBatCapacity.TabIndex = 3
        Me.nudBatCapacity.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'cmbBatStat
        '
        Me.cmbBatStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatStat.FormattingEnabled = True
        Me.cmbBatStat.Items.AddRange(New Object() {"Unknown", "Charging", "Discharging", "Not-charging", "Full"})
        Me.cmbBatStat.Location = New System.Drawing.Point(98, 6)
        Me.cmbBatStat.Name = "cmbBatStat"
        Me.cmbBatStat.Size = New System.Drawing.Size(121, 21)
        Me.cmbBatStat.TabIndex = 1
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(6, 9)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(74, 13)
        Me.lblEstado.TabIndex = 3
        Me.lblEstado.Text = "Battery status:"
        '
        'chkCargaAc
        '
        Me.chkCargaAc.AutoSize = True
        Me.chkCargaAc.Location = New System.Drawing.Point(9, 109)
        Me.chkCargaAc.Name = "chkCargaAc"
        Me.chkCargaAc.Size = New System.Drawing.Size(85, 17)
        Me.chkCargaAc.TabIndex = 6
        Me.chkCargaAc.Text = "AC Charging"
        Me.chkCargaAc.UseVisualStyleBackColor = True
        '
        'imIconos
        '
        Me.imIconos.ImageStream = CType(resources.GetObject("imIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imIconos.Images.SetKeyName(0, "bateria16.png")
        Me.imIconos.Images.SetKeyName(1, "sensores16.png")
        '
        'imMenu
        '
        Me.imMenu.ImageStream = CType(resources.GetObject("imMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.imMenu.Images.SetKeyName(0, "battery_plugged_56x56.png")
        '
        'scDivisor
        '
        Me.scDivisor.IsSplitterFixed = True
        Me.scDivisor.Location = New System.Drawing.Point(8, 38)
        Me.scDivisor.Name = "scDivisor"
        Me.scDivisor.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scDivisor.Panel1
        '
        Me.scDivisor.Panel1.Controls.Add(Me.tcPestanas)
        '
        'scDivisor.Panel2
        '
        Me.scDivisor.Panel2.Controls.Add(Me.txtRecv)
        Me.scDivisor.Panel2.Controls.Add(Me.txtComando)
        Me.scDivisor.Panel2.Controls.Add(Me.btnEnviar)
        Me.scDivisor.Size = New System.Drawing.Size(461, 381)
        Me.scDivisor.SplitterDistance = 160
        Me.scDivisor.SplitterWidth = 2
        Me.scDivisor.TabIndex = 9
        '
        'lblBattery
        '
        Me.lblBattery.AutoSize = True
        Me.lblBattery.Location = New System.Drawing.Point(305, 36)
        Me.lblBattery.Name = "lblBattery"
        Me.lblBattery.Size = New System.Drawing.Size(142, 65)
        Me.lblBattery.TabIndex = 13
        Me.lblBattery.Text = "In this tab you can control all" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the battery settings. The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "update button allows " & _
    "to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "refresh de battery info in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fields."
        '
        'tpSensors
        '
        Me.tpSensors.Controls.Add(Me.btnSenUpdate)
        Me.tpSensors.Controls.Add(Me.PictureBox2)
        Me.tpSensors.Controls.Add(Me.Label1)
        Me.tpSensors.Controls.Add(Me.btnSenSet)
        Me.tpSensors.Controls.Add(Me.nudSenValor2)
        Me.tpSensors.Controls.Add(Me.lblSenValor2)
        Me.tpSensors.Controls.Add(Me.nudSenValor3)
        Me.tpSensors.Controls.Add(Me.lblSenValor3)
        Me.tpSensors.Controls.Add(Me.nudSenValor1)
        Me.tpSensors.Controls.Add(Me.lblSenValor1)
        Me.tpSensors.Controls.Add(Me.lblSensor)
        Me.tpSensors.Controls.Add(Me.cmbSensores)
        Me.tpSensors.ImageIndex = 1
        Me.tpSensors.Location = New System.Drawing.Point(4, 23)
        Me.tpSensors.Name = "tpSensors"
        Me.tpSensors.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSensors.Size = New System.Drawing.Size(453, 133)
        Me.tpSensors.TabIndex = 1
        Me.tpSensors.Text = "Sensors"
        Me.tpSensors.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.avm.My.Resources.Resources.bateria64
        Me.PictureBox1.Location = New System.Drawing.Point(240, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'cmbSensores
        '
        Me.cmbSensores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSensores.FormattingEnabled = True
        Me.cmbSensores.Items.AddRange(New Object() {"acceleration", "magnetic-field", "orientation", "temperature", "proximity"})
        Me.cmbSensores.Location = New System.Drawing.Point(60, 7)
        Me.cmbSensores.Name = "cmbSensores"
        Me.cmbSensores.Size = New System.Drawing.Size(158, 21)
        Me.cmbSensores.TabIndex = 0
        '
        'lblSensor
        '
        Me.lblSensor.AutoSize = True
        Me.lblSensor.Location = New System.Drawing.Point(7, 10)
        Me.lblSensor.Name = "lblSensor"
        Me.lblSensor.Size = New System.Drawing.Size(43, 13)
        Me.lblSensor.TabIndex = 1
        Me.lblSensor.Text = "Sensor:"
        '
        'lblSenValor1
        '
        Me.lblSenValor1.AutoSize = True
        Me.lblSenValor1.Location = New System.Drawing.Point(10, 42)
        Me.lblSenValor1.Name = "lblSenValor1"
        Me.lblSenValor1.Size = New System.Drawing.Size(53, 13)
        Me.lblSenValor1.TabIndex = 2
        Me.lblSenValor1.Text = "Not used:"
        '
        'nudSenValor1
        '
        Me.nudSenValor1.DecimalPlaces = 2
        Me.nudSenValor1.Enabled = False
        Me.nudSenValor1.Location = New System.Drawing.Point(60, 40)
        Me.nudSenValor1.Name = "nudSenValor1"
        Me.nudSenValor1.Size = New System.Drawing.Size(73, 20)
        Me.nudSenValor1.TabIndex = 1
        '
        'nudSenValor3
        '
        Me.nudSenValor3.DecimalPlaces = 2
        Me.nudSenValor3.Enabled = False
        Me.nudSenValor3.Location = New System.Drawing.Point(60, 92)
        Me.nudSenValor3.Name = "nudSenValor3"
        Me.nudSenValor3.Size = New System.Drawing.Size(73, 20)
        Me.nudSenValor3.TabIndex = 3
        '
        'lblSenValor3
        '
        Me.lblSenValor3.AutoSize = True
        Me.lblSenValor3.Location = New System.Drawing.Point(10, 94)
        Me.lblSenValor3.Name = "lblSenValor3"
        Me.lblSenValor3.Size = New System.Drawing.Size(53, 13)
        Me.lblSenValor3.TabIndex = 5
        Me.lblSenValor3.Text = "Not used:"
        '
        'nudSenValor2
        '
        Me.nudSenValor2.DecimalPlaces = 2
        Me.nudSenValor2.Enabled = False
        Me.nudSenValor2.Location = New System.Drawing.Point(60, 66)
        Me.nudSenValor2.Name = "nudSenValor2"
        Me.nudSenValor2.Size = New System.Drawing.Size(73, 20)
        Me.nudSenValor2.TabIndex = 2
        '
        'lblSenValor2
        '
        Me.lblSenValor2.AutoSize = True
        Me.lblSenValor2.Location = New System.Drawing.Point(10, 68)
        Me.lblSenValor2.Name = "lblSenValor2"
        Me.lblSenValor2.Size = New System.Drawing.Size(53, 13)
        Me.lblSenValor2.TabIndex = 7
        Me.lblSenValor2.Text = "Not used:"
        '
        'btnSenSet
        '
        Me.btnSenSet.Enabled = False
        Me.btnSenSet.Location = New System.Drawing.Point(143, 38)
        Me.btnSenSet.Name = "btnSenSet"
        Me.btnSenSet.Size = New System.Drawing.Size(75, 43)
        Me.btnSenSet.TabIndex = 4
        Me.btnSenSet.Text = "Set" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Values"
        Me.btnSenSet.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.avm.My.Resources.Resources.sensores64
        Me.PictureBox2.Location = New System.Drawing.Point(240, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 52)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "In this tab you can set the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensor values. Select a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensor, set the values and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "press the Set Values button."
        '
        'btnSenUpdate
        '
        Me.btnSenUpdate.Enabled = False
        Me.btnSenUpdate.Location = New System.Drawing.Point(143, 87)
        Me.btnSenUpdate.Name = "btnSenUpdate"
        Me.btnSenUpdate.Size = New System.Drawing.Size(75, 25)
        Me.btnSenUpdate.TabIndex = 17
        Me.btnSenUpdate.Text = "Update"
        Me.btnSenUpdate.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AcceptButton = Me.btnEnviar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(486, 431)
        Me.Controls.Add(Me.scDivisor)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.lblPuerto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConectar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(492, 457)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(492, 457)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Android Virtual Management"
        Me.tcPestanas.ResumeLayout(False)
        Me.tpBattery.ResumeLayout(False)
        Me.tpBattery.PerformLayout()
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scDivisor.Panel1.ResumeLayout(False)
        Me.scDivisor.Panel2.ResumeLayout(False)
        Me.scDivisor.Panel2.PerformLayout()
        Me.scDivisor.ResumeLayout(False)
        Me.tpSensors.ResumeLayout(False)
        Me.tpSensors.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents txtRecv As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblPuerto As System.Windows.Forms.Label
    Friend WithEvents txtPuerto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtComando As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents tcPestanas As System.Windows.Forms.TabControl
    Friend WithEvents tpBattery As System.Windows.Forms.TabPage
    Friend WithEvents chkCargaAc As System.Windows.Forms.CheckBox
    Friend WithEvents cmbBatStat As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents chkBatPresent As System.Windows.Forms.CheckBox
    Friend WithEvents nudBatCapacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblBatCapacity As System.Windows.Forms.Label
    Friend WithEvents cmbBatHealth As System.Windows.Forms.ComboBox
    Friend WithEvents lblBatHealth As System.Windows.Forms.Label
    Friend WithEvents btnBatCapacity As System.Windows.Forms.Button
    Friend WithEvents imIconos As System.Windows.Forms.ImageList
    Friend WithEvents imMenu As System.Windows.Forms.ImageList
    Friend WithEvents btnBatEstado As System.Windows.Forms.Button
    Friend WithEvents scDivisor As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblBattery As System.Windows.Forms.Label
    Friend WithEvents tpSensors As System.Windows.Forms.TabPage
    Friend WithEvents lblSensor As System.Windows.Forms.Label
    Friend WithEvents cmbSensores As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSenSet As System.Windows.Forms.Button
    Friend WithEvents nudSenValor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor2 As System.Windows.Forms.Label
    Friend WithEvents nudSenValor3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor3 As System.Windows.Forms.Label
    Friend WithEvents nudSenValor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor1 As System.Windows.Forms.Label
    Friend WithEvents btnSenUpdate As System.Windows.Forms.Button

End Class
