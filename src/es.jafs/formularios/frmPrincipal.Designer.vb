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
        Me.imgBateria = New System.Windows.Forms.PictureBox()
        Me.lblBatDesc = New System.Windows.Forms.Label()
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
        Me.tpSms = New System.Windows.Forms.TabPage()
        Me.txtSmsNumero = New System.Windows.Forms.TextBox()
        Me.txtSmsPrefijo = New System.Windows.Forms.TextBox()
        Me.btnSmsSend = New System.Windows.Forms.Button()
        Me.lblSmsTotal = New System.Windows.Forms.Label()
        Me.lblSmsRest = New System.Windows.Forms.Label()
        Me.txtSmsMessage = New System.Windows.Forms.TextBox()
        Me.lblSmsMessage = New System.Windows.Forms.Label()
        Me.lblSmsNumber = New System.Windows.Forms.Label()
        Me.imgSms = New System.Windows.Forms.PictureBox()
        Me.lblSmsDesc = New System.Windows.Forms.Label()
        Me.tpGps = New System.Windows.Forms.TabPage()
        Me.btnGpsSet = New System.Windows.Forms.Button()
        Me.chkGpsSatelites = New System.Windows.Forms.CheckBox()
        Me.nudGpsSatelites = New System.Windows.Forms.NumericUpDown()
        Me.nudGpsAltitude = New System.Windows.Forms.NumericUpDown()
        Me.chkGpsAltitude = New System.Windows.Forms.CheckBox()
        Me.nudGpsLatSec = New System.Windows.Forms.NumericUpDown()
        Me.nudGpsLatMin = New System.Windows.Forms.NumericUpDown()
        Me.nudGpsLatGrados = New System.Windows.Forms.NumericUpDown()
        Me.lblGpsLatitud = New System.Windows.Forms.Label()
        Me.nudGpsLonSec = New System.Windows.Forms.NumericUpDown()
        Me.nudGpsLonMin = New System.Windows.Forms.NumericUpDown()
        Me.nudGpsLonGrados = New System.Windows.Forms.NumericUpDown()
        Me.lblGpsLongitud = New System.Windows.Forms.Label()
        Me.imgGps = New System.Windows.Forms.PictureBox()
        Me.lblGpsDesc = New System.Windows.Forms.Label()
        Me.imIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.scDivisor = New System.Windows.Forms.SplitContainer()
        Me.tcPestanas.SuspendLayout()
        Me.tpBattery.SuspendLayout()
        CType(Me.imgBateria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSensors.SuspendLayout()
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSensores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSms.SuspendLayout()
        CType(Me.imgSms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpGps.SuspendLayout()
        CType(Me.nudGpsSatelites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsAltitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLatSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLatMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLatGrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLonSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLonMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLonGrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgGps, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtRecv.Size = New System.Drawing.Size(467, 189)
        Me.txtRecv.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(386, 5)
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
        Me.txtComando.Size = New System.Drawing.Size(386, 20)
        Me.txtComando.TabIndex = 6
        '
        'btnEnviar
        '
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Location = New System.Drawing.Point(392, 193)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Send"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'tcPestanas
        '
        Me.tcPestanas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcPestanas.Controls.Add(Me.tpBattery)
        Me.tcPestanas.Controls.Add(Me.tpSensors)
        Me.tcPestanas.Controls.Add(Me.tpSms)
        Me.tcPestanas.Controls.Add(Me.tpGps)
        Me.tcPestanas.Enabled = False
        Me.tcPestanas.HotTrack = True
        Me.tcPestanas.ImageList = Me.imIconos
        Me.tcPestanas.Location = New System.Drawing.Point(0, 0)
        Me.tcPestanas.Name = "tcPestanas"
        Me.tcPestanas.SelectedIndex = 0
        Me.tcPestanas.Size = New System.Drawing.Size(467, 160)
        Me.tcPestanas.TabIndex = 8
        '
        'tpBattery
        '
        Me.tpBattery.Controls.Add(Me.imgBateria)
        Me.tpBattery.Controls.Add(Me.lblBatDesc)
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
        Me.tpBattery.Size = New System.Drawing.Size(459, 133)
        Me.tpBattery.TabIndex = 0
        Me.tpBattery.Text = "Battery"
        Me.tpBattery.UseVisualStyleBackColor = True
        '
        'imgBateria
        '
        Me.imgBateria.Image = Global.avm.My.Resources.Resources.bateria64
        Me.imgBateria.Location = New System.Drawing.Point(251, 34)
        Me.imgBateria.Name = "imgBateria"
        Me.imgBateria.Size = New System.Drawing.Size(64, 64)
        Me.imgBateria.TabIndex = 14
        Me.imgBateria.TabStop = False
        '
        'lblBatDesc
        '
        Me.lblBatDesc.AutoSize = True
        Me.lblBatDesc.Location = New System.Drawing.Point(321, 34)
        Me.lblBatDesc.Name = "lblBatDesc"
        Me.lblBatDesc.Size = New System.Drawing.Size(134, 65)
        Me.lblBatDesc.TabIndex = 13
        Me.lblBatDesc.Text = "In this tab you can control" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all the battery settings. The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "update button allows " & _
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
        Me.tpSensors.Controls.Add(Me.lblSenDesc)
        Me.tpSensors.Controls.Add(Me.btnSenSet)
        Me.tpSensors.Controls.Add(Me.nudSenValor2)
        Me.tpSensors.Controls.Add(Me.lblSenValor2)
        Me.tpSensors.Controls.Add(Me.nudSenValor3)
        Me.tpSensors.Controls.Add(Me.lblSenValor3)
        Me.tpSensors.Controls.Add(Me.nudSenValor1)
        Me.tpSensors.Controls.Add(Me.lblSenValor1)
        Me.tpSensors.Controls.Add(Me.lblSensor)
        Me.tpSensors.Controls.Add(Me.cmbSensores)
        Me.tpSensors.Controls.Add(Me.imgSensores)
        Me.tpSensors.ImageIndex = 1
        Me.tpSensors.Location = New System.Drawing.Point(4, 23)
        Me.tpSensors.Name = "tpSensors"
        Me.tpSensors.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSensors.Size = New System.Drawing.Size(459, 133)
        Me.tpSensors.TabIndex = 1
        Me.tpSensors.Text = "Sensors"
        Me.tpSensors.UseVisualStyleBackColor = True
        '
        'btnSenUpdate
        '
        Me.btnSenUpdate.Enabled = False
        Me.btnSenUpdate.Location = New System.Drawing.Point(143, 94)
        Me.btnSenUpdate.Name = "btnSenUpdate"
        Me.btnSenUpdate.Size = New System.Drawing.Size(75, 25)
        Me.btnSenUpdate.TabIndex = 17
        Me.btnSenUpdate.Text = "Update"
        Me.btnSenUpdate.UseVisualStyleBackColor = True
        '
        'lblSenDesc
        '
        Me.lblSenDesc.AutoSize = True
        Me.lblSenDesc.Location = New System.Drawing.Point(321, 40)
        Me.lblSenDesc.Name = "lblSenDesc"
        Me.lblSenDesc.Size = New System.Drawing.Size(140, 52)
        Me.lblSenDesc.TabIndex = 15
        Me.lblSenDesc.Text = "In this tab you can set the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensor values. Select a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sensor, set the values and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "press the Set Values button."
        '
        'btnSenSet
        '
        Me.btnSenSet.Enabled = False
        Me.btnSenSet.Location = New System.Drawing.Point(143, 45)
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
        Me.nudSenValor2.Location = New System.Drawing.Point(60, 73)
        Me.nudSenValor2.Name = "nudSenValor2"
        Me.nudSenValor2.Size = New System.Drawing.Size(73, 20)
        Me.nudSenValor2.TabIndex = 2
        '
        'lblSenValor2
        '
        Me.lblSenValor2.AutoSize = True
        Me.lblSenValor2.Location = New System.Drawing.Point(10, 75)
        Me.lblSenValor2.Name = "lblSenValor2"
        Me.lblSenValor2.Size = New System.Drawing.Size(53, 13)
        Me.lblSenValor2.TabIndex = 7
        Me.lblSenValor2.Text = "Not used:"
        '
        'nudSenValor3
        '
        Me.nudSenValor3.DecimalPlaces = 2
        Me.nudSenValor3.Enabled = False
        Me.nudSenValor3.Location = New System.Drawing.Point(60, 99)
        Me.nudSenValor3.Name = "nudSenValor3"
        Me.nudSenValor3.Size = New System.Drawing.Size(73, 20)
        Me.nudSenValor3.TabIndex = 3
        '
        'lblSenValor3
        '
        Me.lblSenValor3.AutoSize = True
        Me.lblSenValor3.Location = New System.Drawing.Point(10, 101)
        Me.lblSenValor3.Name = "lblSenValor3"
        Me.lblSenValor3.Size = New System.Drawing.Size(53, 13)
        Me.lblSenValor3.TabIndex = 5
        Me.lblSenValor3.Text = "Not used:"
        '
        'nudSenValor1
        '
        Me.nudSenValor1.DecimalPlaces = 2
        Me.nudSenValor1.Enabled = False
        Me.nudSenValor1.Location = New System.Drawing.Point(60, 47)
        Me.nudSenValor1.Name = "nudSenValor1"
        Me.nudSenValor1.Size = New System.Drawing.Size(73, 20)
        Me.nudSenValor1.TabIndex = 1
        '
        'lblSenValor1
        '
        Me.lblSenValor1.AutoSize = True
        Me.lblSenValor1.Location = New System.Drawing.Point(10, 49)
        Me.lblSenValor1.Name = "lblSenValor1"
        Me.lblSenValor1.Size = New System.Drawing.Size(53, 13)
        Me.lblSenValor1.TabIndex = 2
        Me.lblSenValor1.Text = "Not used:"
        '
        'lblSensor
        '
        Me.lblSensor.AutoSize = True
        Me.lblSensor.Location = New System.Drawing.Point(11, 17)
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
        Me.cmbSensores.Location = New System.Drawing.Point(60, 14)
        Me.cmbSensores.Name = "cmbSensores"
        Me.cmbSensores.Size = New System.Drawing.Size(158, 21)
        Me.cmbSensores.TabIndex = 0
        '
        'imgSensores
        '
        Me.imgSensores.Image = Global.avm.My.Resources.Resources.sensores64
        Me.imgSensores.Location = New System.Drawing.Point(251, 34)
        Me.imgSensores.Name = "imgSensores"
        Me.imgSensores.Size = New System.Drawing.Size(64, 64)
        Me.imgSensores.TabIndex = 16
        Me.imgSensores.TabStop = False
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
        Me.tpSms.Controls.Add(Me.imgSms)
        Me.tpSms.Controls.Add(Me.lblSmsDesc)
        Me.tpSms.ImageIndex = 2
        Me.tpSms.Location = New System.Drawing.Point(4, 23)
        Me.tpSms.Name = "tpSms"
        Me.tpSms.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSms.Size = New System.Drawing.Size(459, 133)
        Me.tpSms.TabIndex = 2
        Me.tpSms.Text = "SMS"
        Me.tpSms.UseVisualStyleBackColor = True
        '
        'txtSmsNumero
        '
        Me.txtSmsNumero.Location = New System.Drawing.Point(110, 6)
        Me.txtSmsNumero.MaxLength = 12
        Me.txtSmsNumero.Name = "txtSmsNumero"
        Me.txtSmsNumero.Size = New System.Drawing.Size(115, 20)
        Me.txtSmsNumero.TabIndex = 1
        Me.txtSmsNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSmsPrefijo
        '
        Me.txtSmsPrefijo.Location = New System.Drawing.Point(59, 6)
        Me.txtSmsPrefijo.MaxLength = 4
        Me.txtSmsPrefijo.Name = "txtSmsPrefijo"
        Me.txtSmsPrefijo.Size = New System.Drawing.Size(45, 20)
        Me.txtSmsPrefijo.TabIndex = 0
        Me.txtSmsPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSmsSend
        '
        Me.btnSmsSend.Enabled = False
        Me.btnSmsSend.Location = New System.Drawing.Point(150, 103)
        Me.btnSmsSend.Name = "btnSmsSend"
        Me.btnSmsSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSmsSend.TabIndex = 3
        Me.btnSmsSend.Text = "Send"
        Me.btnSmsSend.UseVisualStyleBackColor = True
        '
        'lblSmsTotal
        '
        Me.lblSmsTotal.AutoSize = True
        Me.lblSmsTotal.Location = New System.Drawing.Point(185, 33)
        Me.lblSmsTotal.Name = "lblSmsTotal"
        Me.lblSmsTotal.Size = New System.Drawing.Size(37, 13)
        Me.lblSmsTotal.TabIndex = 25
        Me.lblSmsTotal.Text = "of 160"
        '
        'lblSmsRest
        '
        Me.lblSmsRest.Location = New System.Drawing.Point(152, 33)
        Me.lblSmsRest.Name = "lblSmsRest"
        Me.lblSmsRest.Size = New System.Drawing.Size(35, 13)
        Me.lblSmsRest.TabIndex = 24
        Me.lblSmsRest.Text = "0"
        Me.lblSmsRest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSmsMessage
        '
        Me.txtSmsMessage.Location = New System.Drawing.Point(12, 50)
        Me.txtSmsMessage.MaxLength = 160
        Me.txtSmsMessage.Multiline = True
        Me.txtSmsMessage.Name = "txtSmsMessage"
        Me.txtSmsMessage.Size = New System.Drawing.Size(213, 47)
        Me.txtSmsMessage.TabIndex = 2
        '
        'lblSmsMessage
        '
        Me.lblSmsMessage.AutoSize = True
        Me.lblSmsMessage.Location = New System.Drawing.Point(9, 33)
        Me.lblSmsMessage.Name = "lblSmsMessage"
        Me.lblSmsMessage.Size = New System.Drawing.Size(53, 13)
        Me.lblSmsMessage.TabIndex = 22
        Me.lblSmsMessage.Text = "Message:"
        '
        'lblSmsNumber
        '
        Me.lblSmsNumber.AutoSize = True
        Me.lblSmsNumber.Location = New System.Drawing.Point(9, 9)
        Me.lblSmsNumber.Name = "lblSmsNumber"
        Me.lblSmsNumber.Size = New System.Drawing.Size(47, 13)
        Me.lblSmsNumber.TabIndex = 19
        Me.lblSmsNumber.Text = "Number:"
        '
        'imgSms
        '
        Me.imgSms.Image = Global.avm.My.Resources.Resources.sms64
        Me.imgSms.Location = New System.Drawing.Point(251, 34)
        Me.imgSms.Name = "imgSms"
        Me.imgSms.Size = New System.Drawing.Size(64, 64)
        Me.imgSms.TabIndex = 18
        Me.imgSms.TabStop = False
        '
        'lblSmsDesc
        '
        Me.lblSmsDesc.AutoSize = True
        Me.lblSmsDesc.Location = New System.Drawing.Point(321, 34)
        Me.lblSmsDesc.Name = "lblSmsDesc"
        Me.lblSmsDesc.Size = New System.Drawing.Size(136, 65)
        Me.lblSmsDesc.TabIndex = 17
        Me.lblSmsDesc.Text = "Here you can send sms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "messages to the virtual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "machine. Specify the origin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "numb" & _
    "er, write the message," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and press Send button."
        '
        'tpGps
        '
        Me.tpGps.Controls.Add(Me.btnGpsSet)
        Me.tpGps.Controls.Add(Me.chkGpsSatelites)
        Me.tpGps.Controls.Add(Me.nudGpsSatelites)
        Me.tpGps.Controls.Add(Me.nudGpsAltitude)
        Me.tpGps.Controls.Add(Me.chkGpsAltitude)
        Me.tpGps.Controls.Add(Me.nudGpsLatSec)
        Me.tpGps.Controls.Add(Me.nudGpsLatMin)
        Me.tpGps.Controls.Add(Me.nudGpsLatGrados)
        Me.tpGps.Controls.Add(Me.lblGpsLatitud)
        Me.tpGps.Controls.Add(Me.nudGpsLonSec)
        Me.tpGps.Controls.Add(Me.nudGpsLonMin)
        Me.tpGps.Controls.Add(Me.nudGpsLonGrados)
        Me.tpGps.Controls.Add(Me.lblGpsLongitud)
        Me.tpGps.Controls.Add(Me.imgGps)
        Me.tpGps.Controls.Add(Me.lblGpsDesc)
        Me.tpGps.ImageIndex = 3
        Me.tpGps.Location = New System.Drawing.Point(4, 23)
        Me.tpGps.Name = "tpGps"
        Me.tpGps.Size = New System.Drawing.Size(459, 133)
        Me.tpGps.TabIndex = 3
        Me.tpGps.Text = "GPS"
        Me.tpGps.UseVisualStyleBackColor = True
        '
        'btnGpsSet
        '
        Me.btnGpsSet.Location = New System.Drawing.Point(141, 69)
        Me.btnGpsSet.Name = "btnGpsSet"
        Me.btnGpsSet.Size = New System.Drawing.Size(56, 46)
        Me.btnGpsSet.TabIndex = 37
        Me.btnGpsSet.Text = "Set" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "location"
        Me.btnGpsSet.UseVisualStyleBackColor = True
        '
        'chkGpsSatelites
        '
        Me.chkGpsSatelites.AutoSize = True
        Me.chkGpsSatelites.Enabled = False
        Me.chkGpsSatelites.Location = New System.Drawing.Point(9, 96)
        Me.chkGpsSatelites.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkGpsSatelites.Name = "chkGpsSatelites"
        Me.chkGpsSatelites.Size = New System.Drawing.Size(71, 17)
        Me.chkGpsSatelites.TabIndex = 36
        Me.chkGpsSatelites.Text = "Satellites:"
        Me.chkGpsSatelites.UseVisualStyleBackColor = True
        '
        'nudGpsSatelites
        '
        Me.nudGpsSatelites.Enabled = False
        Me.nudGpsSatelites.Location = New System.Drawing.Point(90, 95)
        Me.nudGpsSatelites.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudGpsSatelites.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGpsSatelites.Name = "nudGpsSatelites"
        Me.nudGpsSatelites.Size = New System.Drawing.Size(44, 20)
        Me.nudGpsSatelites.TabIndex = 35
        Me.nudGpsSatelites.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudGpsAltitude
        '
        Me.nudGpsAltitude.DecimalPlaces = 2
        Me.nudGpsAltitude.Enabled = False
        Me.nudGpsAltitude.Location = New System.Drawing.Point(69, 69)
        Me.nudGpsAltitude.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudGpsAltitude.Name = "nudGpsAltitude"
        Me.nudGpsAltitude.Size = New System.Drawing.Size(65, 20)
        Me.nudGpsAltitude.TabIndex = 33
        '
        'chkGpsAltitude
        '
        Me.chkGpsAltitude.AutoSize = True
        Me.chkGpsAltitude.Location = New System.Drawing.Point(9, 70)
        Me.chkGpsAltitude.Name = "chkGpsAltitude"
        Me.chkGpsAltitude.Size = New System.Drawing.Size(64, 17)
        Me.chkGpsAltitude.TabIndex = 32
        Me.chkGpsAltitude.Text = "Altitude:"
        Me.chkGpsAltitude.UseVisualStyleBackColor = True
        '
        'nudGpsLatSec
        '
        Me.nudGpsLatSec.Location = New System.Drawing.Point(161, 43)
        Me.nudGpsLatSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLatSec.Name = "nudGpsLatSec"
        Me.nudGpsLatSec.Size = New System.Drawing.Size(36, 20)
        Me.nudGpsLatSec.TabIndex = 28
        '
        'nudGpsLatMin
        '
        Me.nudGpsLatMin.Location = New System.Drawing.Point(119, 43)
        Me.nudGpsLatMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLatMin.Name = "nudGpsLatMin"
        Me.nudGpsLatMin.Size = New System.Drawing.Size(36, 20)
        Me.nudGpsLatMin.TabIndex = 27
        '
        'nudGpsLatGrados
        '
        Me.nudGpsLatGrados.Location = New System.Drawing.Point(69, 43)
        Me.nudGpsLatGrados.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.nudGpsLatGrados.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
        Me.nudGpsLatGrados.Name = "nudGpsLatGrados"
        Me.nudGpsLatGrados.Size = New System.Drawing.Size(44, 20)
        Me.nudGpsLatGrados.TabIndex = 26
        '
        'lblGpsLatitud
        '
        Me.lblGpsLatitud.AutoSize = True
        Me.lblGpsLatitud.Location = New System.Drawing.Point(6, 45)
        Me.lblGpsLatitud.Name = "lblGpsLatitud"
        Me.lblGpsLatitud.Size = New System.Drawing.Size(48, 13)
        Me.lblGpsLatitud.TabIndex = 25
        Me.lblGpsLatitud.Text = "Latitude:"
        '
        'nudGpsLonSec
        '
        Me.nudGpsLonSec.Location = New System.Drawing.Point(161, 17)
        Me.nudGpsLonSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLonSec.Name = "nudGpsLonSec"
        Me.nudGpsLonSec.Size = New System.Drawing.Size(36, 20)
        Me.nudGpsLonSec.TabIndex = 24
        '
        'nudGpsLonMin
        '
        Me.nudGpsLonMin.Location = New System.Drawing.Point(119, 17)
        Me.nudGpsLonMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLonMin.Name = "nudGpsLonMin"
        Me.nudGpsLonMin.Size = New System.Drawing.Size(36, 20)
        Me.nudGpsLonMin.TabIndex = 23
        '
        'nudGpsLonGrados
        '
        Me.nudGpsLonGrados.Location = New System.Drawing.Point(69, 17)
        Me.nudGpsLonGrados.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudGpsLonGrados.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.nudGpsLonGrados.Name = "nudGpsLonGrados"
        Me.nudGpsLonGrados.Size = New System.Drawing.Size(44, 20)
        Me.nudGpsLonGrados.TabIndex = 22
        '
        'lblGpsLongitud
        '
        Me.lblGpsLongitud.AutoSize = True
        Me.lblGpsLongitud.Location = New System.Drawing.Point(6, 19)
        Me.lblGpsLongitud.Name = "lblGpsLongitud"
        Me.lblGpsLongitud.Size = New System.Drawing.Size(57, 13)
        Me.lblGpsLongitud.TabIndex = 21
        Me.lblGpsLongitud.Text = "Longitude:"
        '
        'imgGps
        '
        Me.imgGps.Image = Global.avm.My.Resources.Resources.gps64
        Me.imgGps.Location = New System.Drawing.Point(251, 34)
        Me.imgGps.Name = "imgGps"
        Me.imgGps.Size = New System.Drawing.Size(64, 64)
        Me.imgGps.TabIndex = 20
        Me.imgGps.TabStop = False
        '
        'lblGpsDesc
        '
        Me.lblGpsDesc.AutoSize = True
        Me.lblGpsDesc.Location = New System.Drawing.Point(321, 27)
        Me.lblGpsDesc.Name = "lblGpsDesc"
        Me.lblGpsDesc.Size = New System.Drawing.Size(141, 78)
        Me.lblGpsDesc.TabIndex = 19
        Me.lblGpsDesc.Text = "Here you will be able to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "change the GPS location." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter the longitude and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lati" & _
    "tude coordinates to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "change the position. Altitude" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and satellites are optional." & _
    ""
        '
        'imIconos
        '
        Me.imIconos.ImageStream = CType(resources.GetObject("imIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imIconos.Images.SetKeyName(0, "bateria16.png")
        Me.imIconos.Images.SetKeyName(1, "sensores16.png")
        Me.imIconos.Images.SetKeyName(2, "sms16.png")
        Me.imIconos.Images.SetKeyName(3, "gps16.png")
        '
        'scDivisor
        '
        Me.scDivisor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.scDivisor.Size = New System.Drawing.Size(467, 381)
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
        Me.ClientSize = New System.Drawing.Size(486, 431)
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
        CType(Me.imgBateria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSensors.ResumeLayout(False)
        Me.tpSensors.PerformLayout()
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSensores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSms.ResumeLayout(False)
        Me.tpSms.PerformLayout()
        CType(Me.imgSms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpGps.ResumeLayout(False)
        Me.tpGps.PerformLayout()
        CType(Me.nudGpsSatelites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsAltitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLatSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLatMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLatGrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLonSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLonMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLonGrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgGps, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents imgBateria As System.Windows.Forms.PictureBox
    Friend WithEvents lblBatDesc As System.Windows.Forms.Label
    Friend WithEvents tpSensors As System.Windows.Forms.TabPage
    Friend WithEvents lblSensor As System.Windows.Forms.Label
    Friend WithEvents cmbSensores As System.Windows.Forms.ComboBox
    Friend WithEvents imgSensores As System.Windows.Forms.PictureBox
    Friend WithEvents lblSenDesc As System.Windows.Forms.Label
    Friend WithEvents btnSenSet As System.Windows.Forms.Button
    Friend WithEvents nudSenValor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor2 As System.Windows.Forms.Label
    Friend WithEvents nudSenValor3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor3 As System.Windows.Forms.Label
    Friend WithEvents nudSenValor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor1 As System.Windows.Forms.Label
    Friend WithEvents btnSenUpdate As System.Windows.Forms.Button
    Friend WithEvents tpSms As System.Windows.Forms.TabPage
    Friend WithEvents imgSms As System.Windows.Forms.PictureBox
    Friend WithEvents lblSmsDesc As System.Windows.Forms.Label
    Friend WithEvents lblSmsNumber As System.Windows.Forms.Label
    Friend WithEvents lblSmsTotal As System.Windows.Forms.Label
    Friend WithEvents lblSmsRest As System.Windows.Forms.Label
    Friend WithEvents txtSmsMessage As System.Windows.Forms.TextBox
    Friend WithEvents lblSmsMessage As System.Windows.Forms.Label
    Friend WithEvents btnSmsSend As System.Windows.Forms.Button
    Friend WithEvents txtSmsNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtSmsPrefijo As System.Windows.Forms.TextBox
    Friend WithEvents tpGps As System.Windows.Forms.TabPage
    Friend WithEvents imgGps As System.Windows.Forms.PictureBox
    Friend WithEvents lblGpsDesc As System.Windows.Forms.Label
    Friend WithEvents btnGpsSet As System.Windows.Forms.Button
    Friend WithEvents chkGpsSatelites As System.Windows.Forms.CheckBox
    Friend WithEvents nudGpsSatelites As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudGpsAltitude As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkGpsAltitude As System.Windows.Forms.CheckBox
    Friend WithEvents nudGpsLatSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudGpsLatMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudGpsLatGrados As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGpsLatitud As System.Windows.Forms.Label
    Friend WithEvents nudGpsLonSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudGpsLonMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudGpsLonGrados As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGpsLongitud As System.Windows.Forms.Label

End Class
