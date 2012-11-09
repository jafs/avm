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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrPower))
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
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudBatCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBateria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBatDesc
        '
        resources.ApplyResources(Me.lblBatDesc, "lblBatDesc")
        Me.lblBatDesc.Name = "lblBatDesc"
        Me.ttConsejo.SetToolTip(Me.lblBatDesc, resources.GetString("lblBatDesc.ToolTip"))
        '
        'btnBatActualiza
        '
        resources.ApplyResources(Me.btnBatActualiza, "btnBatActualiza")
        Me.btnBatActualiza.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnBatActualiza.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBatActualiza.ForeColor = System.Drawing.Color.White
        Me.btnBatActualiza.Name = "btnBatActualiza"
        Me.ttConsejo.SetToolTip(Me.btnBatActualiza, resources.GetString("btnBatActualiza.ToolTip"))
        Me.btnBatActualiza.UseVisualStyleBackColor = False
        '
        'btnBatCapacity
        '
        resources.ApplyResources(Me.btnBatCapacity, "btnBatCapacity")
        Me.btnBatCapacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnBatCapacity.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBatCapacity.ForeColor = System.Drawing.Color.White
        Me.btnBatCapacity.Name = "btnBatCapacity"
        Me.ttConsejo.SetToolTip(Me.btnBatCapacity, resources.GetString("btnBatCapacity.ToolTip"))
        Me.btnBatCapacity.UseVisualStyleBackColor = False
        '
        'lblBatCapacity
        '
        resources.ApplyResources(Me.lblBatCapacity, "lblBatCapacity")
        Me.lblBatCapacity.Name = "lblBatCapacity"
        Me.ttConsejo.SetToolTip(Me.lblBatCapacity, resources.GetString("lblBatCapacity.ToolTip"))
        '
        'cmbBatHealth
        '
        resources.ApplyResources(Me.cmbBatHealth, "cmbBatHealth")
        Me.cmbBatHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatHealth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbBatHealth.FormattingEnabled = True
        Me.cmbBatHealth.Items.AddRange(New Object() {resources.GetString("cmbBatHealth.Items"), resources.GetString("cmbBatHealth.Items1"), resources.GetString("cmbBatHealth.Items2"), resources.GetString("cmbBatHealth.Items3"), resources.GetString("cmbBatHealth.Items4"), resources.GetString("cmbBatHealth.Items5")})
        Me.cmbBatHealth.Name = "cmbBatHealth"
        Me.ttConsejo.SetToolTip(Me.cmbBatHealth, resources.GetString("cmbBatHealth.ToolTip"))
        '
        'lblBatHealth
        '
        resources.ApplyResources(Me.lblBatHealth, "lblBatHealth")
        Me.lblBatHealth.Name = "lblBatHealth"
        Me.ttConsejo.SetToolTip(Me.lblBatHealth, resources.GetString("lblBatHealth.ToolTip"))
        '
        'chkBatPresent
        '
        resources.ApplyResources(Me.chkBatPresent, "chkBatPresent")
        Me.chkBatPresent.Name = "chkBatPresent"
        Me.ttConsejo.SetToolTip(Me.chkBatPresent, resources.GetString("chkBatPresent.ToolTip"))
        Me.chkBatPresent.UseVisualStyleBackColor = True
        '
        'nudBatCapacity
        '
        resources.ApplyResources(Me.nudBatCapacity, "nudBatCapacity")
        Me.nudBatCapacity.Name = "nudBatCapacity"
        Me.ttConsejo.SetToolTip(Me.nudBatCapacity, resources.GetString("nudBatCapacity.ToolTip"))
        Me.nudBatCapacity.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'cmbBatStat
        '
        resources.ApplyResources(Me.cmbBatStat, "cmbBatStat")
        Me.cmbBatStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBatStat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbBatStat.FormattingEnabled = True
        Me.cmbBatStat.Items.AddRange(New Object() {resources.GetString("cmbBatStat.Items"), resources.GetString("cmbBatStat.Items1"), resources.GetString("cmbBatStat.Items2"), resources.GetString("cmbBatStat.Items3"), resources.GetString("cmbBatStat.Items4")})
        Me.cmbBatStat.Name = "cmbBatStat"
        Me.ttConsejo.SetToolTip(Me.cmbBatStat, resources.GetString("cmbBatStat.ToolTip"))
        '
        'lblEstado
        '
        resources.ApplyResources(Me.lblEstado, "lblEstado")
        Me.lblEstado.Name = "lblEstado"
        Me.ttConsejo.SetToolTip(Me.lblEstado, resources.GetString("lblEstado.ToolTip"))
        '
        'chkCargaAc
        '
        resources.ApplyResources(Me.chkCargaAc, "chkCargaAc")
        Me.chkCargaAc.Name = "chkCargaAc"
        Me.ttConsejo.SetToolTip(Me.chkCargaAc, resources.GetString("chkCargaAc.ToolTip"))
        Me.chkCargaAc.UseVisualStyleBackColor = True
        '
        'imgBateria
        '
        resources.ApplyResources(Me.imgBateria, "imgBateria")
        Me.imgBateria.Image = Global.Avm.My.Resources.Resources.icoBateria64
        Me.imgBateria.Name = "imgBateria"
        Me.imgBateria.TabStop = False
        Me.ttConsejo.SetToolTip(Me.imgBateria, resources.GetString("imgBateria.ToolTip"))
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttConsejo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        '
        'CtrPower
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.nudBatCapacity)
        Me.Controls.Add(Me.imgBateria)
        Me.Controls.Add(Me.lblBatDesc)
        Me.Controls.Add(Me.btnBatActualiza)
        Me.Controls.Add(Me.btnBatCapacity)
        Me.Controls.Add(Me.lblBatCapacity)
        Me.Controls.Add(Me.cmbBatHealth)
        Me.Controls.Add(Me.lblBatHealth)
        Me.Controls.Add(Me.chkBatPresent)
        Me.Controls.Add(Me.cmbBatStat)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.chkCargaAc)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Name = "CtrPower"
        Me.ttConsejo.SetToolTip(Me, resources.GetString("$this.ToolTip"))
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
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip

End Class
