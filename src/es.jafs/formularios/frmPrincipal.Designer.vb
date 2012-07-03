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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblBattery = New System.Windows.Forms.Label()
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
        Me.tpSensors = New System.Windows.Forms.TabPage()
        Me.btnSenUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSenSet = New System.Windows.Forms.Button()
        Me.nudSenValor2 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor2 = New System.Windows.Forms.Label()
        Me.nudSenValor3 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor3 = New System.Windows.Forms.Label()
        Me.nudSenValor1 = New System.Windows.Forms.NumericUpDown()
        Me.lblSenValor1 = New System.Windows.Forms.Label()
        Me.lblSensor = New System.Windows.Forms.Label()
        Me.cmbSensores = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tpSms = New System.Windows.Forms.TabPage()
        Me.txtSmsNumero = New System.Windows.Forms.TextBox()
        Me.txtSmsPrefijo = New System.Windows.Forms.TextBox()
        Me.btnSmsSend = New System.Windows.Forms.Button()
        Me.lblSmsTotal = New System.Windows.Forms.Label()
        Me.lblSmsRest = New System.Windows.Forms.Label()
        Me.txtSmsMessage = New System.Windows.Forms.TextBox()
        Me.lblSmsMessage = New System.Windows.Forms.Label()
        Me.lblSmsNumber = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.scDivisor = New System.Windows.Forms.SplitContainer()
        Me.tcPestanas.SuspendLayout()
        Me.tpBattery.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSensors.SuspendLayout()
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSms.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scDivisor.Panel1.SuspendLayout()
        Me.scDivisor.Panel2.SuspendLayout()
        Me.scDivisor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(8, 5)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(98, 24)
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
        Me.txtRecv.Size = New System.Drawing.Size(564, 189)
        Me.txtRecv.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(483, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 24)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Exit"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblPuerto
        '
        Me.lblPuerto.AutoSize = True
        Me.lblPuerto.Location = New System.Drawing.Point(112, 11)
        Me.lblPuerto.Name = "lblPuerto"
        Me.lblPuerto.Size = New System.Drawing.Size(29, 13)
        Me.lblPuerto.TabIndex = 4
        Me.lblPuerto.Text = "Port:"
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(147, 8)
        Me.txtPuerto.Mask = "99999"
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPuerto.Size = New System.Drawing.Size(50, 20)
        Me.txtPuerto.TabIndex = 1
        Me.txtPuerto.Text = "5554"
        '
        'txtComando
        '
        Me.txtComando.AutoCompleteCustomSource.AddRange(New String() {"h", "help", "?", "event", "event send", "event types", "event codes", "event text", "geo", "geo nmea", "geo fix", "gsm", "gsm list", "gsm call", "gsm busy", "gsm hold", "gsm accept", "gsm cancel", "gsm data", "gsm voice", "gsm status", "cdma", "cdma ssource", "cdma prl_version", "kill", "network", "network status", "network speed", "network delay", "network capture", "network capture start", "network capture stop", "power display", "power ac", "power ac on", "power ac off", "power status", "power status unknown", "power status charging", "power status discharging", "power status not-charging", "power present", "power present true", "power present false", "power health", "power health unknown", "power health good", "power health overheat", "power health dead", "power health overvoltage", "power health failure", "power capacity", "quit", "exit", "redir", "redir list", "redit add", "redir del", "sms", "sms send", "sms pdu", "avd", "avd stop", "avd start", "avd status", "avd name", "avd snapshot list", "avd snapshot save", "avd snapshot load", "avd snapshot del", "window", "window scale", "qemu", "qemu monitor", "sensor", "sensor status", "sensor get", "sensor get acceleration", "sensor get magnetic-field", "sensor get orientation", "sensor get temperature", "sensor get proximity", "sensor set", "sensor set acceleration", "sensor set magnetic-field", "sensor set orientation", "sensor set temperature", "sensor set proximity"})
        Me.txtComando.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtComando.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtComando.Enabled = False
        Me.txtComando.Location = New System.Drawing.Point(0, 195)
        Me.txtComando.Name = "txtComando"
        Me.txtComando.Size = New System.Drawing.Size(483, 20)
        Me.txtComando.TabIndex = 6
        '
        'btnEnviar
        '
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Location = New System.Drawing.Point(489, 193)
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
        Me.tcPestanas.Controls.Add(Me.tpSms)
        Me.tcPestanas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcPestanas.Enabled = False
        Me.tcPestanas.HotTrack = True
        Me.tcPestanas.ImageList = Me.imIconos
        Me.tcPestanas.Location = New System.Drawing.Point(0, 0)
        Me.tcPestanas.Name = "tcPestanas"
        Me.tcPestanas.SelectedIndex = 0
        Me.tcPestanas.Size = New System.Drawing.Size(564, 160)
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
        Me.tpBattery.Size = New System.Drawing.Size(556, 133)
        Me.tpBattery.TabIndex = 0
        Me.tpBattery.Text = "Battery"
        Me.tpBattery.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.avm.My.Resources.Resources.bateria64
        Me.PictureBox1.Location = New System.Drawing.Point(235, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'lblBattery
        '
        Me.lblBattery.AutoSize = True
        Me.lblBattery.Location = New System.Drawing.Point(305, 34)
        Me.lblBattery.Name = "lblBattery"
        Me.lblBattery.Size = New System.Drawing.Size(142, 65)
        Me.lblBattery.TabIndex = 13
        Me.lblBattery.Text = "In this tab you can control all" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the battery settings. The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "update button allows " & _
    "to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "refresh de battery info in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fields."
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
        'tpSensors
        '
        Me.tpSensors.Controls.Add(Me.btnSenUpdate)
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
        Me.tpSensors.Controls.Add(Me.PictureBox2)
        Me.tpSensors.ImageIndex = 1
        Me.tpSensors.Location = New System.Drawing.Point(4, 23)
        Me.tpSensors.Name = "tpSensors"
        Me.tpSensors.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSensors.Size = New System.Drawing.Size(463, 133)
        Me.tpSensors.TabIndex = 1
        Me.tpSensors.Text = "Sensors"
        Me.tpSensors.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 52)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "In this tab you can set the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensor values. Select a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensor, set the values and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "press the Set Values button."
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
        'nudSenValor1
        '
        Me.nudSenValor1.DecimalPlaces = 2
        Me.nudSenValor1.Enabled = False
        Me.nudSenValor1.Location = New System.Drawing.Point(60, 40)
        Me.nudSenValor1.Name = "nudSenValor1"
        Me.nudSenValor1.Size = New System.Drawing.Size(73, 20)
        Me.nudSenValor1.TabIndex = 1
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
        'lblSensor
        '
        Me.lblSensor.AutoSize = True
        Me.lblSensor.Location = New System.Drawing.Point(7, 10)
        Me.lblSensor.Name = "lblSensor"
        Me.lblSensor.Size = New System.Drawing.Size(43, 13)
        Me.lblSensor.TabIndex = 1
        Me.lblSensor.Text = "Sensor:"
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
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.avm.My.Resources.Resources.sensores64
        Me.PictureBox2.Location = New System.Drawing.Point(237, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'tpSms
        '
        Me.tpSms.Controls.Add(Me.txtSmsNumero)
        Me.tpSms.Controls.Add(Me.txtSmsPrefijo)
        Me.tpSms.Controls.Add(Me.btnSmsSend)
        Me.tpSms.Controls.Add(Me.lblSmsTotal)
        Me.tpSms.Controls.Add(Me.lblSmsRest)
        Me.tpSms.Controls.Add(Me.txtSmsMessage)
        Me.tpSms.Controls.Add(Me.lblSmsMessage)
        Me.tpSms.Controls.Add(Me.lblSmsNumber)
        Me.tpSms.Controls.Add(Me.PictureBox3)
        Me.tpSms.Controls.Add(Me.Label2)
        Me.tpSms.ImageIndex = 2
        Me.tpSms.Location = New System.Drawing.Point(4, 23)
        Me.tpSms.Name = "tpSms"
        Me.tpSms.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSms.Size = New System.Drawing.Size(463, 133)
        Me.tpSms.TabIndex = 2
        Me.tpSms.Text = "SMS"
        Me.tpSms.UseVisualStyleBackColor = True
        '
        'txtSmsNumero
        '
        Me.txtSmsNumero.Location = New System.Drawing.Point(110, 7)
        Me.txtSmsNumero.MaxLength = 12
        Me.txtSmsNumero.Name = "txtSmsNumero"
        Me.txtSmsNumero.Size = New System.Drawing.Size(115, 20)
        Me.txtSmsNumero.TabIndex = 1
        Me.txtSmsNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSmsPrefijo
        '
        Me.txtSmsPrefijo.Location = New System.Drawing.Point(59, 7)
        Me.txtSmsPrefijo.MaxLength = 4
        Me.txtSmsPrefijo.Name = "txtSmsPrefijo"
        Me.txtSmsPrefijo.Size = New System.Drawing.Size(45, 20)
        Me.txtSmsPrefijo.TabIndex = 0
        Me.txtSmsPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSmsSend
        '
        Me.btnSmsSend.Enabled = False
        Me.btnSmsSend.Location = New System.Drawing.Point(150, 104)
        Me.btnSmsSend.Name = "btnSmsSend"
        Me.btnSmsSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSmsSend.TabIndex = 3
        Me.btnSmsSend.Text = "Send"
        Me.btnSmsSend.UseVisualStyleBackColor = True
        '
        'lblSmsTotal
        '
        Me.lblSmsTotal.AutoSize = True
        Me.lblSmsTotal.Location = New System.Drawing.Point(185, 34)
        Me.lblSmsTotal.Name = "lblSmsTotal"
        Me.lblSmsTotal.Size = New System.Drawing.Size(37, 13)
        Me.lblSmsTotal.TabIndex = 25
        Me.lblSmsTotal.Text = "of 160"
        '
        'lblSmsRest
        '
        Me.lblSmsRest.Location = New System.Drawing.Point(152, 34)
        Me.lblSmsRest.Name = "lblSmsRest"
        Me.lblSmsRest.Size = New System.Drawing.Size(35, 13)
        Me.lblSmsRest.TabIndex = 24
        Me.lblSmsRest.Text = "0"
        Me.lblSmsRest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSmsMessage
        '
        Me.txtSmsMessage.Location = New System.Drawing.Point(12, 51)
        Me.txtSmsMessage.MaxLength = 160
        Me.txtSmsMessage.Multiline = True
        Me.txtSmsMessage.Name = "txtSmsMessage"
        Me.txtSmsMessage.Size = New System.Drawing.Size(213, 47)
        Me.txtSmsMessage.TabIndex = 2
        '
        'lblSmsMessage
        '
        Me.lblSmsMessage.AutoSize = True
        Me.lblSmsMessage.Location = New System.Drawing.Point(9, 34)
        Me.lblSmsMessage.Name = "lblSmsMessage"
        Me.lblSmsMessage.Size = New System.Drawing.Size(53, 13)
        Me.lblSmsMessage.TabIndex = 22
        Me.lblSmsMessage.Text = "Message:"
        '
        'lblSmsNumber
        '
        Me.lblSmsNumber.AutoSize = True
        Me.lblSmsNumber.Location = New System.Drawing.Point(6, 10)
        Me.lblSmsNumber.Name = "lblSmsNumber"
        Me.lblSmsNumber.Size = New System.Drawing.Size(47, 13)
        Me.lblSmsNumber.TabIndex = 19
        Me.lblSmsNumber.Text = "Number:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.avm.My.Resources.Resources.sms64
        Me.PictureBox3.Location = New System.Drawing.Point(251, 34)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 65)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Here you can send sms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "messages to the virtual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "machine. Specify the origin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "numb" & _
    "er, write the message," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and press Send button."
        '
        'imIconos
        '
        Me.imIconos.ImageStream = CType(resources.GetObject("imIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imIconos.Images.SetKeyName(0, "bateria16.png")
        Me.imIconos.Images.SetKeyName(1, "sensores16.png")
        Me.imIconos.Images.SetKeyName(2, "sms16.png")
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
        Me.scDivisor.Size = New System.Drawing.Size(564, 381)
        Me.scDivisor.SplitterDistance = 160
        Me.scDivisor.SplitterWidth = 2
        Me.scDivisor.TabIndex = 9
        '
        'frmPrincipal
        '
        Me.AcceptButton = Me.btnEnviar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(579, 431)
        Me.Controls.Add(Me.scDivisor)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.lblPuerto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConectar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(492, 457)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Android Virtual Management"
        Me.tcPestanas.ResumeLayout(False)
        Me.tpBattery.ResumeLayout(False)
        Me.tpBattery.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSensors.ResumeLayout(False)
        Me.tpSensors.PerformLayout()
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSms.ResumeLayout(False)
        Me.tpSms.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scDivisor.Panel1.ResumeLayout(False)
        Me.scDivisor.Panel2.ResumeLayout(False)
        Me.scDivisor.Panel2.PerformLayout()
        Me.scDivisor.ResumeLayout(False)
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
    Friend WithEvents tpSms As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSmsNumber As System.Windows.Forms.Label
    Friend WithEvents lblSmsTotal As System.Windows.Forms.Label
    Friend WithEvents lblSmsRest As System.Windows.Forms.Label
    Friend WithEvents txtSmsMessage As System.Windows.Forms.TextBox
    Friend WithEvents lblSmsMessage As System.Windows.Forms.Label
    Friend WithEvents btnSmsSend As System.Windows.Forms.Button
    Friend WithEvents txtSmsNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtSmsPrefijo As System.Windows.Forms.TextBox

End Class
