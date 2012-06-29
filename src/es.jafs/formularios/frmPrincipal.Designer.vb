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
        Me.lblConsola = New System.Windows.Forms.Label()
        Me.imMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.tcPestanas.SuspendLayout()
        Me.tpBattery.SuspendLayout()
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtRecv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecv.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecv.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRecv.Location = New System.Drawing.Point(269, 55)
        Me.txtRecv.Multiline = True
        Me.txtRecv.Name = "txtRecv"
        Me.txtRecv.ReadOnly = True
        Me.txtRecv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecv.Size = New System.Drawing.Size(306, 157)
        Me.txtRecv.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(486, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 24)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Exit"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblPuerto
        '
        Me.lblPuerto.AutoSize = True
        Me.lblPuerto.Location = New System.Drawing.Point(162, 12)
        Me.lblPuerto.Name = "lblPuerto"
        Me.lblPuerto.Size = New System.Drawing.Size(29, 13)
        Me.lblPuerto.TabIndex = 4
        Me.lblPuerto.Text = "Port:"
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(197, 9)
        Me.txtPuerto.Mask = "99999"
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPuerto.Size = New System.Drawing.Size(50, 20)
        Me.txtPuerto.TabIndex = 5
        Me.txtPuerto.Text = "5554"
        '
        'txtComando
        '
        Me.txtComando.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComando.AutoCompleteCustomSource.AddRange(New String() {"avd", "cdma", "event", "exit", "geo", "gsm", "h", "help", "kill", "network", "power", "power display", "power ac", "power ac on", "power ac off", "qemu", "quit", "redir", "sensor", "sensor status", "sensor get", "sensor set", "sms", "window", "?"})
        Me.txtComando.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtComando.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtComando.Enabled = False
        Me.txtComando.Location = New System.Drawing.Point(269, 220)
        Me.txtComando.Name = "txtComando"
        Me.txtComando.Size = New System.Drawing.Size(225, 20)
        Me.txtComando.TabIndex = 6
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Location = New System.Drawing.Point(500, 218)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Send"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'tcPestanas
        '
        Me.tcPestanas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tcPestanas.Controls.Add(Me.tpBattery)
        Me.tcPestanas.Enabled = False
        Me.tcPestanas.HotTrack = True
        Me.tcPestanas.ImageList = Me.imIconos
        Me.tcPestanas.Location = New System.Drawing.Point(8, 39)
        Me.tcPestanas.Name = "tcPestanas"
        Me.tcPestanas.SelectedIndex = 0
        Me.tcPestanas.Size = New System.Drawing.Size(243, 202)
        Me.tcPestanas.TabIndex = 8
        '
        'tpBattery
        '
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
        Me.tpBattery.Size = New System.Drawing.Size(235, 175)
        Me.tpBattery.TabIndex = 0
        Me.tpBattery.Text = "Battery"
        '
        'btnBatEstado
        '
        Me.btnBatEstado.Location = New System.Drawing.Point(146, 110)
        Me.btnBatEstado.Name = "btnBatEstado"
        Me.btnBatEstado.Size = New System.Drawing.Size(75, 23)
        Me.btnBatEstado.TabIndex = 12
        Me.btnBatEstado.Text = "Status"
        Me.btnBatEstado.UseVisualStyleBackColor = True
        '
        'btnBatCapacity
        '
        Me.btnBatCapacity.Location = New System.Drawing.Point(153, 84)
        Me.btnBatCapacity.Name = "btnBatCapacity"
        Me.btnBatCapacity.Size = New System.Drawing.Size(68, 20)
        Me.btnBatCapacity.TabIndex = 11
        Me.btnBatCapacity.Text = "Set"
        Me.btnBatCapacity.UseVisualStyleBackColor = True
        '
        'lblBatCapacity
        '
        Me.lblBatCapacity.AutoSize = True
        Me.lblBatCapacity.Location = New System.Drawing.Point(8, 86)
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
        Me.cmbBatHealth.Location = New System.Drawing.Point(100, 57)
        Me.cmbBatHealth.Name = "cmbBatHealth"
        Me.cmbBatHealth.Size = New System.Drawing.Size(121, 21)
        Me.cmbBatHealth.TabIndex = 9
        '
        'lblBatHealth
        '
        Me.lblBatHealth.AutoSize = True
        Me.lblBatHealth.Location = New System.Drawing.Point(6, 60)
        Me.lblBatHealth.Name = "lblBatHealth"
        Me.lblBatHealth.Size = New System.Drawing.Size(75, 13)
        Me.lblBatHealth.TabIndex = 8
        Me.lblBatHealth.Text = "Battery health:"
        '
        'chkBatPresent
        '
        Me.chkBatPresent.AutoSize = True
        Me.chkBatPresent.Location = New System.Drawing.Point(124, 6)
        Me.chkBatPresent.Name = "chkBatPresent"
        Me.chkBatPresent.Size = New System.Drawing.Size(97, 17)
        Me.chkBatPresent.TabIndex = 7
        Me.chkBatPresent.Text = "Battery present"
        Me.chkBatPresent.UseVisualStyleBackColor = True
        '
        'nudBatCapacity
        '
        Me.nudBatCapacity.Location = New System.Drawing.Point(100, 84)
        Me.nudBatCapacity.Name = "nudBatCapacity"
        Me.nudBatCapacity.Size = New System.Drawing.Size(47, 20)
        Me.nudBatCapacity.TabIndex = 6
        Me.nudBatCapacity.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'cmbBatStat
        '
        Me.cmbBatStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatStat.FormattingEnabled = True
        Me.cmbBatStat.Items.AddRange(New Object() {"Unknown", "Charging", "Discharging", "Not-charging", "Full"})
        Me.cmbBatStat.Location = New System.Drawing.Point(100, 29)
        Me.cmbBatStat.Name = "cmbBatStat"
        Me.cmbBatStat.Size = New System.Drawing.Size(121, 21)
        Me.cmbBatStat.TabIndex = 4
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(6, 32)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(74, 13)
        Me.lblEstado.TabIndex = 3
        Me.lblEstado.Text = "Battery status:"
        '
        'chkCargaAc
        '
        Me.chkCargaAc.AutoSize = True
        Me.chkCargaAc.Location = New System.Drawing.Point(9, 6)
        Me.chkCargaAc.Name = "chkCargaAc"
        Me.chkCargaAc.Size = New System.Drawing.Size(85, 17)
        Me.chkCargaAc.TabIndex = 2
        Me.chkCargaAc.Text = "AC Charging"
        Me.chkCargaAc.UseVisualStyleBackColor = True
        '
        'imIconos
        '
        Me.imIconos.ImageStream = CType(resources.GetObject("imIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imIconos.Images.SetKeyName(0, "battery-caution.png")
        '
        'lblConsola
        '
        Me.lblConsola.AutoSize = True
        Me.lblConsola.Location = New System.Drawing.Point(266, 39)
        Me.lblConsola.Name = "lblConsola"
        Me.lblConsola.Size = New System.Drawing.Size(48, 13)
        Me.lblConsola.TabIndex = 9
        Me.lblConsola.Text = "Console:"
        '
        'imMenu
        '
        Me.imMenu.ImageStream = CType(resources.GetObject("imMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.imMenu.Images.SetKeyName(0, "battery-caution.png")
        Me.imMenu.Images.SetKeyName(1, "utilities-terminal.png")
        Me.imMenu.Images.SetKeyName(2, "preferences-desktop-remote-desktop.png")
        '
        'frmPrincipal
        '
        Me.AcceptButton = Me.btnEnviar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(587, 254)
        Me.Controls.Add(Me.lblConsola)
        Me.Controls.Add(Me.tcPestanas)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtComando)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.lblPuerto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtRecv)
        Me.Controls.Add(Me.btnConectar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Android Virtual Management"
        Me.tcPestanas.ResumeLayout(False)
        Me.tpBattery.ResumeLayout(False)
        Me.tpBattery.PerformLayout()
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblConsola As System.Windows.Forms.Label
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

End Class
