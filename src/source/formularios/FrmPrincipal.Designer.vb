<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.txtRecv = New System.Windows.Forms.TextBox()
        Me.txtComando = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        Me.pnlDock = New System.Windows.Forms.Panel()
        Me.tlpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.mnAyuda = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttmAyuGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttSeparador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ttmAyuManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ttmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.chkDebug = New System.Windows.Forms.CheckBox()
        Me.pblEstado = New System.Windows.Forms.Panel()
        Me.lblReloj = New System.Windows.Forms.Label()
        Me.trmReloj = New System.Windows.Forms.Timer(Me.components)
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlDebug = New System.Windows.Forms.Panel()
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlDock.SuspendLayout()
        Me.tlpMenu.SuspendLayout()
        Me.mnAyuda.SuspendLayout()
        Me.pblEstado.SuspendLayout()
        Me.pnlDebug.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtRecv.Size = New System.Drawing.Size(444, 397)
        Me.txtRecv.TabIndex = 7
        Me.txtRecv.TabStop = False
        Me.ttConsejo.SetToolTip(Me.txtRecv, "Hide debug panel")
        '
        'txtComando
        '
        Me.txtComando.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtComando.AutoCompleteCustomSource.AddRange(New String() {"h", "help", "?", "event", "event send", "event types", "event codes", "event text", "geo", "geo nmea", "geo fix", "gsm", "gsm list", "gsm call", "gsm busy", "gsm hold", "gsm accept", "gsm cancel", "gsm data unregistered", "gsm data home", "gsm data roaming", "gsm data searching", "gsm data denied", "gsm data off", "gsm data on", "gsm voice", "gsm voice unregistered", "gsm voice home", "gsm voice roaming", "gsm voice searching", "gsm voice denied", "gsm voice off", "gsm voice on", "gsm status", "gsm signal", "cdma", "cdma ssource", "cdma prl_version", "kill", "network", "network status", "network speed", "network delay", "network capture", "network capture start", "network capture stop", "power display", "power ac", "power ac on", "power ac off", "power status", "power status unknown", "power status charging", "power status discharging", "power status not-charging", "power present", "power present true", "power present false", "power health", "power health unknown", "power health good", "power health overheat", "power health dead", "power health overvoltage", "power health failure", "power capacity", "quit", "exit", "redir", "redir list", "redit add", "redir del", "sms", "sms send", "sms pdu", "avd", "avd stop", "avd start", "avd status", "avd name", "avd snapshot list", "avd snapshot save", "avd snapshot load", "avd snapshot del", "window", "window scale", "qemu", "qemu monitor", "sensor", "sensor status", "sensor get", "sensor get acceleration", "sensor get magnetic-field", "sensor get orientation", "sensor get temperature", "sensor get proximity", "sensor set", "sensor set acceleration", "sensor set magnetic-field", "sensor set orientation", "sensor set temperature", "sensor set proximity"})
        Me.txtComando.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtComando.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtComando.Enabled = False
        Me.txtComando.Location = New System.Drawing.Point(0, 405)
        Me.txtComando.Name = "txtComando"
        Me.txtComando.Size = New System.Drawing.Size(363, 20)
        Me.txtComando.TabIndex = 6
        '
        'btnEnviar
        '
        Me.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Location = New System.Drawing.Point(369, 403)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Send"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.BackColor = System.Drawing.Color.White
        Me.pnlPrincipal.Controls.Add(Me.pnlCentral)
        Me.pnlPrincipal.Controls.Add(Me.pnlDock)
        Me.pnlPrincipal.Controls.Add(Me.pblEstado)
        Me.pnlPrincipal.Location = New System.Drawing.Point(9, 10)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(280, 426)
        Me.pnlPrincipal.TabIndex = 0
        '
        'pnlCentral
        '
        Me.pnlCentral.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCentral.Location = New System.Drawing.Point(0, 32)
        Me.pnlCentral.Name = "pnlCentral"
        Me.pnlCentral.Size = New System.Drawing.Size(280, 338)
        Me.pnlCentral.TabIndex = 2
        '
        'pnlDock
        '
        Me.pnlDock.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlDock.Controls.Add(Me.tlpMenu)
        Me.pnlDock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDock.Location = New System.Drawing.Point(0, 370)
        Me.pnlDock.Name = "pnlDock"
        Me.pnlDock.Size = New System.Drawing.Size(280, 56)
        Me.pnlDock.TabIndex = 3
        '
        'tlpMenu
        '
        Me.tlpMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.tlpMenu.ColumnCount = 5
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMenu.Controls.Add(Me.btnConfiguracion, 0, 0)
        Me.tlpMenu.Controls.Add(Me.btnSalir, 4, 0)
        Me.tlpMenu.Controls.Add(Me.btnHome, 2, 0)
        Me.tlpMenu.Controls.Add(Me.btnAyuda, 1, 0)
        Me.tlpMenu.Controls.Add(Me.chkDebug, 3, 0)
        Me.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlpMenu.Name = "tlpMenu"
        Me.tlpMenu.RowCount = 1
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpMenu.Size = New System.Drawing.Size(280, 56)
        Me.tlpMenu.TabIndex = 0
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.ContextMenuStrip = Me.mnAyuda
        Me.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfiguracion.Enabled = False
        Me.btnConfiguracion.FlatAppearance.BorderSize = 0
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.Image = Global.Avm.My.Resources.Resources.icoConfig48
        Me.btnConfiguracion.Location = New System.Drawing.Point(3, 3)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(50, 50)
        Me.btnConfiguracion.TabIndex = 9
        Me.ttConsejo.SetToolTip(Me.btnConfiguracion, "Config")
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'mnAyuda
        '
        Me.mnAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.mnAyuda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttmAyuGeneral, Me.ttSeparador2, Me.ttmAyuManual, Me.ttSeparador1, Me.ttmAbout})
        Me.mnAyuda.Name = "mnAyuda"
        Me.mnAyuda.ShowImageMargin = False
        Me.mnAyuda.Size = New System.Drawing.Size(126, 94)
        '
        'ttmAyuGeneral
        '
        Me.ttmAyuGeneral.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ttmAyuGeneral.ForeColor = System.Drawing.Color.White
        Me.ttmAyuGeneral.Name = "ttmAyuGeneral"
        Me.ttmAyuGeneral.Padding = New System.Windows.Forms.Padding(2)
        Me.ttmAyuGeneral.Size = New System.Drawing.Size(129, 26)
        Me.ttmAyuGeneral.Text = "&General info"
        '
        'ttSeparador2
        '
        Me.ttSeparador2.Name = "ttSeparador2"
        Me.ttSeparador2.Size = New System.Drawing.Size(122, 6)
        '
        'ttmAyuManual
        '
        Me.ttmAyuManual.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ttmAyuManual.ForeColor = System.Drawing.Color.White
        Me.ttmAyuManual.Name = "ttmAyuManual"
        Me.ttmAyuManual.Padding = New System.Windows.Forms.Padding(2)
        Me.ttmAyuManual.Size = New System.Drawing.Size(129, 26)
        Me.ttmAyuManual.Text = "&Manual"
        '
        'ttSeparador1
        '
        Me.ttSeparador1.Name = "ttSeparador1"
        Me.ttSeparador1.Size = New System.Drawing.Size(122, 6)
        '
        'ttmAbout
        '
        Me.ttmAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ttmAbout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ttmAbout.ForeColor = System.Drawing.Color.White
        Me.ttmAbout.Name = "ttmAbout"
        Me.ttmAbout.Padding = New System.Windows.Forms.Padding(2)
        Me.ttmAbout.Size = New System.Drawing.Size(129, 26)
        Me.ttmAbout.Text = "&About..."
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.Avm.My.Resources.Resources.icoMenuSalir48
        Me.btnSalir.Location = New System.Drawing.Point(227, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(50, 50)
        Me.btnSalir.TabIndex = 7
        Me.ttConsejo.SetToolTip(Me.btnSalir, "Exit application")
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHome.Enabled = False
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Image = Global.Avm.My.Resources.Resources.icoMenuHome64
        Me.btnHome.Location = New System.Drawing.Point(115, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(50, 50)
        Me.btnHome.TabIndex = 5
        Me.ttConsejo.SetToolTip(Me.btnHome, "Main menu")
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnAyuda
        '
        Me.btnAyuda.ContextMenuStrip = Me.mnAyuda
        Me.btnAyuda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAyuda.FlatAppearance.BorderSize = 0
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Image = Global.Avm.My.Resources.Resources.mn_ayuda48
        Me.btnAyuda.Location = New System.Drawing.Point(59, 3)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(50, 50)
        Me.btnAyuda.TabIndex = 6
        Me.ttConsejo.SetToolTip(Me.btnAyuda, "Help")
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'chkDebug
        '
        Me.chkDebug.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkDebug.AutoSize = True
        Me.chkDebug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkDebug.FlatAppearance.BorderSize = 0
        Me.chkDebug.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.chkDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDebug.Image = Global.Avm.My.Resources.Resources.icoMenuDebug48
        Me.chkDebug.Location = New System.Drawing.Point(171, 3)
        Me.chkDebug.Name = "chkDebug"
        Me.chkDebug.Size = New System.Drawing.Size(50, 50)
        Me.chkDebug.TabIndex = 8
        Me.ttConsejo.SetToolTip(Me.chkDebug, "Show debug console")
        Me.chkDebug.UseVisualStyleBackColor = True
        '
        'pblEstado
        '
        Me.pblEstado.BackColor = System.Drawing.Color.Transparent
        Me.pblEstado.BackgroundImage = Global.Avm.My.Resources.Resources.superior
        Me.pblEstado.Controls.Add(Me.lblReloj)
        Me.pblEstado.Dock = System.Windows.Forms.DockStyle.Top
        Me.pblEstado.ForeColor = System.Drawing.Color.White
        Me.pblEstado.Location = New System.Drawing.Point(0, 0)
        Me.pblEstado.Name = "pblEstado"
        Me.pblEstado.Size = New System.Drawing.Size(280, 32)
        Me.pblEstado.TabIndex = 1
        '
        'lblReloj
        '
        Me.lblReloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReloj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblReloj.Location = New System.Drawing.Point(217, 5)
        Me.lblReloj.Name = "lblReloj"
        Me.lblReloj.Size = New System.Drawing.Size(60, 23)
        Me.lblReloj.TabIndex = 0
        Me.lblReloj.Text = "00:00"
        Me.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trmReloj
        '
        Me.trmReloj.Enabled = True
        Me.trmReloj.Interval = 60000
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttConsejo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'pnlDebug
        '
        Me.pnlDebug.Controls.Add(Me.txtRecv)
        Me.pnlDebug.Controls.Add(Me.txtComando)
        Me.pnlDebug.Controls.Add(Me.btnEnviar)
        Me.pnlDebug.Location = New System.Drawing.Point(295, 10)
        Me.pnlDebug.Name = "pnlDebug"
        Me.pnlDebug.Size = New System.Drawing.Size(444, 426)
        Me.pnlDebug.TabIndex = 9
        Me.pnlDebug.Visible = False
        '
        'FrmPrincipal
        '
        Me.AcceptButton = Me.btnEnviar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(749, 446)
        Me.Controls.Add(Me.pnlDebug)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(305, 457)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Android Virtual Management"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlDock.ResumeLayout(False)
        Me.tlpMenu.ResumeLayout(False)
        Me.tlpMenu.PerformLayout()
        Me.mnAyuda.ResumeLayout(False)
        Me.pblEstado.ResumeLayout(False)
        Me.pnlDebug.ResumeLayout(False)
        Me.pnlDebug.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRecv As System.Windows.Forms.TextBox
    Friend WithEvents txtComando As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents pnlDock As System.Windows.Forms.Panel
    Friend WithEvents pblEstado As System.Windows.Forms.Panel
    Friend WithEvents pnlCentral As System.Windows.Forms.Panel
    Friend WithEvents tlpMenu As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents lblReloj As System.Windows.Forms.Label
    Friend WithEvents trmReloj As System.Windows.Forms.Timer
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip
    Friend WithEvents mnAyuda As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ttmAyuGeneral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttmAyuManual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttmAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pnlDebug As System.Windows.Forms.Panel
    Friend WithEvents chkDebug As System.Windows.Forms.CheckBox
    Friend WithEvents btnConfiguracion As System.Windows.Forms.Button
    Friend WithEvents ttSeparador2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ttSeparador1 As System.Windows.Forms.ToolStripSeparator

End Class
