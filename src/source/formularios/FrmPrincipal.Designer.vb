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
        resources.ApplyResources(Me.txtRecv, "txtRecv")
        Me.txtRecv.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRecv.Name = "txtRecv"
        Me.txtRecv.ReadOnly = True
        Me.txtRecv.TabStop = False
        Me.ttConsejo.SetToolTip(Me.txtRecv, resources.GetString("txtRecv.ToolTip"))
        '
        'txtComando
        '
        resources.ApplyResources(Me.txtComando, "txtComando")
        Me.txtComando.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("txtComando.AutoCompleteCustomSource"), resources.GetString("txtComando.AutoCompleteCustomSource1"), resources.GetString("txtComando.AutoCompleteCustomSource2"), resources.GetString("txtComando.AutoCompleteCustomSource3"), resources.GetString("txtComando.AutoCompleteCustomSource4"), resources.GetString("txtComando.AutoCompleteCustomSource5"), resources.GetString("txtComando.AutoCompleteCustomSource6"), resources.GetString("txtComando.AutoCompleteCustomSource7"), resources.GetString("txtComando.AutoCompleteCustomSource8"), resources.GetString("txtComando.AutoCompleteCustomSource9"), resources.GetString("txtComando.AutoCompleteCustomSource10"), resources.GetString("txtComando.AutoCompleteCustomSource11"), resources.GetString("txtComando.AutoCompleteCustomSource12"), resources.GetString("txtComando.AutoCompleteCustomSource13"), resources.GetString("txtComando.AutoCompleteCustomSource14"), resources.GetString("txtComando.AutoCompleteCustomSource15"), resources.GetString("txtComando.AutoCompleteCustomSource16"), resources.GetString("txtComando.AutoCompleteCustomSource17"), resources.GetString("txtComando.AutoCompleteCustomSource18"), resources.GetString("txtComando.AutoCompleteCustomSource19"), resources.GetString("txtComando.AutoCompleteCustomSource20"), resources.GetString("txtComando.AutoCompleteCustomSource21"), resources.GetString("txtComando.AutoCompleteCustomSource22"), resources.GetString("txtComando.AutoCompleteCustomSource23"), resources.GetString("txtComando.AutoCompleteCustomSource24"), resources.GetString("txtComando.AutoCompleteCustomSource25"), resources.GetString("txtComando.AutoCompleteCustomSource26"), resources.GetString("txtComando.AutoCompleteCustomSource27"), resources.GetString("txtComando.AutoCompleteCustomSource28"), resources.GetString("txtComando.AutoCompleteCustomSource29"), resources.GetString("txtComando.AutoCompleteCustomSource30"), resources.GetString("txtComando.AutoCompleteCustomSource31"), resources.GetString("txtComando.AutoCompleteCustomSource32"), resources.GetString("txtComando.AutoCompleteCustomSource33"), resources.GetString("txtComando.AutoCompleteCustomSource34"), resources.GetString("txtComando.AutoCompleteCustomSource35"), resources.GetString("txtComando.AutoCompleteCustomSource36"), resources.GetString("txtComando.AutoCompleteCustomSource37"), resources.GetString("txtComando.AutoCompleteCustomSource38"), resources.GetString("txtComando.AutoCompleteCustomSource39"), resources.GetString("txtComando.AutoCompleteCustomSource40"), resources.GetString("txtComando.AutoCompleteCustomSource41"), resources.GetString("txtComando.AutoCompleteCustomSource42"), resources.GetString("txtComando.AutoCompleteCustomSource43"), resources.GetString("txtComando.AutoCompleteCustomSource44"), resources.GetString("txtComando.AutoCompleteCustomSource45"), resources.GetString("txtComando.AutoCompleteCustomSource46"), resources.GetString("txtComando.AutoCompleteCustomSource47"), resources.GetString("txtComando.AutoCompleteCustomSource48"), resources.GetString("txtComando.AutoCompleteCustomSource49"), resources.GetString("txtComando.AutoCompleteCustomSource50"), resources.GetString("txtComando.AutoCompleteCustomSource51"), resources.GetString("txtComando.AutoCompleteCustomSource52"), resources.GetString("txtComando.AutoCompleteCustomSource53"), resources.GetString("txtComando.AutoCompleteCustomSource54"), resources.GetString("txtComando.AutoCompleteCustomSource55"), resources.GetString("txtComando.AutoCompleteCustomSource56"), resources.GetString("txtComando.AutoCompleteCustomSource57"), resources.GetString("txtComando.AutoCompleteCustomSource58"), resources.GetString("txtComando.AutoCompleteCustomSource59"), resources.GetString("txtComando.AutoCompleteCustomSource60"), resources.GetString("txtComando.AutoCompleteCustomSource61"), resources.GetString("txtComando.AutoCompleteCustomSource62"), resources.GetString("txtComando.AutoCompleteCustomSource63"), resources.GetString("txtComando.AutoCompleteCustomSource64"), resources.GetString("txtComando.AutoCompleteCustomSource65"), resources.GetString("txtComando.AutoCompleteCustomSource66"), resources.GetString("txtComando.AutoCompleteCustomSource67"), resources.GetString("txtComando.AutoCompleteCustomSource68"), resources.GetString("txtComando.AutoCompleteCustomSource69"), resources.GetString("txtComando.AutoCompleteCustomSource70"), resources.GetString("txtComando.AutoCompleteCustomSource71"), resources.GetString("txtComando.AutoCompleteCustomSource72"), resources.GetString("txtComando.AutoCompleteCustomSource73"), resources.GetString("txtComando.AutoCompleteCustomSource74"), resources.GetString("txtComando.AutoCompleteCustomSource75"), resources.GetString("txtComando.AutoCompleteCustomSource76"), resources.GetString("txtComando.AutoCompleteCustomSource77"), resources.GetString("txtComando.AutoCompleteCustomSource78"), resources.GetString("txtComando.AutoCompleteCustomSource79"), resources.GetString("txtComando.AutoCompleteCustomSource80"), resources.GetString("txtComando.AutoCompleteCustomSource81"), resources.GetString("txtComando.AutoCompleteCustomSource82"), resources.GetString("txtComando.AutoCompleteCustomSource83"), resources.GetString("txtComando.AutoCompleteCustomSource84"), resources.GetString("txtComando.AutoCompleteCustomSource85"), resources.GetString("txtComando.AutoCompleteCustomSource86"), resources.GetString("txtComando.AutoCompleteCustomSource87"), resources.GetString("txtComando.AutoCompleteCustomSource88"), resources.GetString("txtComando.AutoCompleteCustomSource89"), resources.GetString("txtComando.AutoCompleteCustomSource90"), resources.GetString("txtComando.AutoCompleteCustomSource91"), resources.GetString("txtComando.AutoCompleteCustomSource92"), resources.GetString("txtComando.AutoCompleteCustomSource93"), resources.GetString("txtComando.AutoCompleteCustomSource94"), resources.GetString("txtComando.AutoCompleteCustomSource95"), resources.GetString("txtComando.AutoCompleteCustomSource96"), resources.GetString("txtComando.AutoCompleteCustomSource97"), resources.GetString("txtComando.AutoCompleteCustomSource98"), resources.GetString("txtComando.AutoCompleteCustomSource99"), resources.GetString("txtComando.AutoCompleteCustomSource100"), resources.GetString("txtComando.AutoCompleteCustomSource101")})
        Me.txtComando.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtComando.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtComando.Name = "txtComando"
        Me.ttConsejo.SetToolTip(Me.txtComando, resources.GetString("txtComando.ToolTip"))
        '
        'btnEnviar
        '
        resources.ApplyResources(Me.btnEnviar, "btnEnviar")
        Me.btnEnviar.Name = "btnEnviar"
        Me.ttConsejo.SetToolTip(Me.btnEnviar, resources.GetString("btnEnviar.ToolTip"))
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'pnlPrincipal
        '
        resources.ApplyResources(Me.pnlPrincipal, "pnlPrincipal")
        Me.pnlPrincipal.BackColor = System.Drawing.Color.White
        Me.pnlPrincipal.Controls.Add(Me.pnlCentral)
        Me.pnlPrincipal.Controls.Add(Me.pnlDock)
        Me.pnlPrincipal.Controls.Add(Me.pblEstado)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.ttConsejo.SetToolTip(Me.pnlPrincipal, resources.GetString("pnlPrincipal.ToolTip"))
        '
        'pnlCentral
        '
        resources.ApplyResources(Me.pnlCentral, "pnlCentral")
        Me.pnlCentral.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.pnlCentral.Name = "pnlCentral"
        Me.ttConsejo.SetToolTip(Me.pnlCentral, resources.GetString("pnlCentral.ToolTip"))
        '
        'pnlDock
        '
        resources.ApplyResources(Me.pnlDock, "pnlDock")
        Me.pnlDock.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlDock.Controls.Add(Me.tlpMenu)
        Me.pnlDock.Name = "pnlDock"
        Me.ttConsejo.SetToolTip(Me.pnlDock, resources.GetString("pnlDock.ToolTip"))
        '
        'tlpMenu
        '
        resources.ApplyResources(Me.tlpMenu, "tlpMenu")
        Me.tlpMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.tlpMenu.Controls.Add(Me.btnConfiguracion, 0, 0)
        Me.tlpMenu.Controls.Add(Me.btnSalir, 4, 0)
        Me.tlpMenu.Controls.Add(Me.btnHome, 2, 0)
        Me.tlpMenu.Controls.Add(Me.btnAyuda, 1, 0)
        Me.tlpMenu.Controls.Add(Me.chkDebug, 3, 0)
        Me.tlpMenu.Name = "tlpMenu"
        Me.ttConsejo.SetToolTip(Me.tlpMenu, resources.GetString("tlpMenu.ToolTip"))
        '
        'btnConfiguracion
        '
        resources.ApplyResources(Me.btnConfiguracion, "btnConfiguracion")
        Me.btnConfiguracion.ContextMenuStrip = Me.mnAyuda
        Me.btnConfiguracion.FlatAppearance.BorderSize = 0
        Me.btnConfiguracion.Image = Global.Avm.My.Resources.Resources.icoConfig48
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.ttConsejo.SetToolTip(Me.btnConfiguracion, resources.GetString("btnConfiguracion.ToolTip"))
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'mnAyuda
        '
        resources.ApplyResources(Me.mnAyuda, "mnAyuda")
        Me.mnAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.mnAyuda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttmAyuGeneral, Me.ttSeparador2, Me.ttmAyuManual, Me.ttSeparador1, Me.ttmAbout})
        Me.mnAyuda.Name = "mnAyuda"
        Me.mnAyuda.ShowImageMargin = False
        Me.ttConsejo.SetToolTip(Me.mnAyuda, resources.GetString("mnAyuda.ToolTip"))
        '
        'ttmAyuGeneral
        '
        resources.ApplyResources(Me.ttmAyuGeneral, "ttmAyuGeneral")
        Me.ttmAyuGeneral.ForeColor = System.Drawing.Color.White
        Me.ttmAyuGeneral.Name = "ttmAyuGeneral"
        Me.ttmAyuGeneral.Padding = New System.Windows.Forms.Padding(2)
        '
        'ttSeparador2
        '
        resources.ApplyResources(Me.ttSeparador2, "ttSeparador2")
        Me.ttSeparador2.Name = "ttSeparador2"
        '
        'ttmAyuManual
        '
        resources.ApplyResources(Me.ttmAyuManual, "ttmAyuManual")
        Me.ttmAyuManual.ForeColor = System.Drawing.Color.White
        Me.ttmAyuManual.Name = "ttmAyuManual"
        Me.ttmAyuManual.Padding = New System.Windows.Forms.Padding(2)
        '
        'ttSeparador1
        '
        resources.ApplyResources(Me.ttSeparador1, "ttSeparador1")
        Me.ttSeparador1.Name = "ttSeparador1"
        '
        'ttmAbout
        '
        resources.ApplyResources(Me.ttmAbout, "ttmAbout")
        Me.ttmAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ttmAbout.ForeColor = System.Drawing.Color.White
        Me.ttmAbout.Name = "ttmAbout"
        Me.ttmAbout.Padding = New System.Windows.Forms.Padding(2)
        '
        'btnSalir
        '
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.Image = Global.Avm.My.Resources.Resources.icoMenuSalir48
        Me.btnSalir.Name = "btnSalir"
        Me.ttConsejo.SetToolTip(Me.btnSalir, resources.GetString("btnSalir.ToolTip"))
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        resources.ApplyResources(Me.btnHome, "btnHome")
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.Image = Global.Avm.My.Resources.Resources.icoMenuHome64
        Me.btnHome.Name = "btnHome"
        Me.ttConsejo.SetToolTip(Me.btnHome, resources.GetString("btnHome.ToolTip"))
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnAyuda
        '
        resources.ApplyResources(Me.btnAyuda, "btnAyuda")
        Me.btnAyuda.ContextMenuStrip = Me.mnAyuda
        Me.btnAyuda.FlatAppearance.BorderSize = 0
        Me.btnAyuda.Image = Global.Avm.My.Resources.Resources.mn_ayuda48
        Me.btnAyuda.Name = "btnAyuda"
        Me.ttConsejo.SetToolTip(Me.btnAyuda, resources.GetString("btnAyuda.ToolTip"))
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'chkDebug
        '
        resources.ApplyResources(Me.chkDebug, "chkDebug")
        Me.chkDebug.FlatAppearance.BorderSize = 0
        Me.chkDebug.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.chkDebug.Image = Global.Avm.My.Resources.Resources.icoMenuDebug48
        Me.chkDebug.Name = "chkDebug"
        Me.ttConsejo.SetToolTip(Me.chkDebug, resources.GetString("chkDebug.ToolTip"))
        Me.chkDebug.UseVisualStyleBackColor = True
        '
        'pblEstado
        '
        resources.ApplyResources(Me.pblEstado, "pblEstado")
        Me.pblEstado.BackColor = System.Drawing.Color.Transparent
        Me.pblEstado.BackgroundImage = Global.Avm.My.Resources.Resources.superior
        Me.pblEstado.Controls.Add(Me.lblReloj)
        Me.pblEstado.ForeColor = System.Drawing.Color.White
        Me.pblEstado.Name = "pblEstado"
        Me.ttConsejo.SetToolTip(Me.pblEstado, resources.GetString("pblEstado.ToolTip"))
        '
        'lblReloj
        '
        resources.ApplyResources(Me.lblReloj, "lblReloj")
        Me.lblReloj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblReloj.Name = "lblReloj"
        Me.ttConsejo.SetToolTip(Me.lblReloj, resources.GetString("lblReloj.ToolTip"))
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
        resources.ApplyResources(Me.pnlDebug, "pnlDebug")
        Me.pnlDebug.Controls.Add(Me.txtRecv)
        Me.pnlDebug.Controls.Add(Me.txtComando)
        Me.pnlDebug.Controls.Add(Me.btnEnviar)
        Me.pnlDebug.Name = "pnlDebug"
        Me.ttConsejo.SetToolTip(Me.pnlDebug, resources.GetString("pnlDebug.ToolTip"))
        '
        'FrmPrincipal
        '
        Me.AcceptButton = Me.btnEnviar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlDebug)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.ttConsejo.SetToolTip(Me, resources.GetString("$this.ToolTip"))
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
