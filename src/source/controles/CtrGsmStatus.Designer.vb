<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrGsmStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrGsmStatus))
        Me.chkGsmBerOn = New System.Windows.Forms.CheckBox()
        Me.btnGsmSet = New System.Windows.Forms.Button()
        Me.chkGsmNoBer = New System.Windows.Forms.CheckBox()
        Me.nudGsmBer = New System.Windows.Forms.NumericUpDown()
        Me.chkGsmNoRssi = New System.Windows.Forms.CheckBox()
        Me.nudGsmRssi = New System.Windows.Forms.NumericUpDown()
        Me.lblGsmRssi = New System.Windows.Forms.Label()
        Me.btnGsmUpdate = New System.Windows.Forms.Button()
        Me.cmbGsmVoz = New System.Windows.Forms.ComboBox()
        Me.lblGsmVoz = New System.Windows.Forms.Label()
        Me.cmbGsmDatos = New System.Windows.Forms.ComboBox()
        Me.lblGsmDatos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgGsm = New System.Windows.Forms.PictureBox()
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudGsmBer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGsmRssi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgGsm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkGsmBerOn
        '
        resources.ApplyResources(Me.chkGsmBerOn, "chkGsmBerOn")
        Me.chkGsmBerOn.Name = "chkGsmBerOn"
        Me.ttConsejo.SetToolTip(Me.chkGsmBerOn, resources.GetString("chkGsmBerOn.ToolTip"))
        Me.chkGsmBerOn.UseVisualStyleBackColor = True
        '
        'btnGsmSet
        '
        resources.ApplyResources(Me.btnGsmSet, "btnGsmSet")
        Me.btnGsmSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnGsmSet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGsmSet.ForeColor = System.Drawing.Color.White
        Me.btnGsmSet.Name = "btnGsmSet"
        Me.ttConsejo.SetToolTip(Me.btnGsmSet, resources.GetString("btnGsmSet.ToolTip"))
        Me.btnGsmSet.UseVisualStyleBackColor = False
        '
        'chkGsmNoBer
        '
        resources.ApplyResources(Me.chkGsmNoBer, "chkGsmNoBer")
        Me.chkGsmNoBer.Name = "chkGsmNoBer"
        Me.ttConsejo.SetToolTip(Me.chkGsmNoBer, resources.GetString("chkGsmNoBer.ToolTip"))
        Me.chkGsmNoBer.UseVisualStyleBackColor = True
        '
        'nudGsmBer
        '
        resources.ApplyResources(Me.nudGsmBer, "nudGsmBer")
        Me.nudGsmBer.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.nudGsmBer.Name = "nudGsmBer"
        Me.ttConsejo.SetToolTip(Me.nudGsmBer, resources.GetString("nudGsmBer.ToolTip"))
        '
        'chkGsmNoRssi
        '
        resources.ApplyResources(Me.chkGsmNoRssi, "chkGsmNoRssi")
        Me.chkGsmNoRssi.Name = "chkGsmNoRssi"
        Me.ttConsejo.SetToolTip(Me.chkGsmNoRssi, resources.GetString("chkGsmNoRssi.ToolTip"))
        Me.chkGsmNoRssi.UseVisualStyleBackColor = True
        '
        'nudGsmRssi
        '
        resources.ApplyResources(Me.nudGsmRssi, "nudGsmRssi")
        Me.nudGsmRssi.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nudGsmRssi.Name = "nudGsmRssi"
        Me.ttConsejo.SetToolTip(Me.nudGsmRssi, resources.GetString("nudGsmRssi.ToolTip"))
        '
        'lblGsmRssi
        '
        resources.ApplyResources(Me.lblGsmRssi, "lblGsmRssi")
        Me.lblGsmRssi.Name = "lblGsmRssi"
        Me.ttConsejo.SetToolTip(Me.lblGsmRssi, resources.GetString("lblGsmRssi.ToolTip"))
        '
        'btnGsmUpdate
        '
        resources.ApplyResources(Me.btnGsmUpdate, "btnGsmUpdate")
        Me.btnGsmUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnGsmUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGsmUpdate.ForeColor = System.Drawing.Color.White
        Me.btnGsmUpdate.Name = "btnGsmUpdate"
        Me.ttConsejo.SetToolTip(Me.btnGsmUpdate, resources.GetString("btnGsmUpdate.ToolTip"))
        Me.btnGsmUpdate.UseVisualStyleBackColor = False
        '
        'cmbGsmVoz
        '
        resources.ApplyResources(Me.cmbGsmVoz, "cmbGsmVoz")
        Me.cmbGsmVoz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGsmVoz.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbGsmVoz.FormattingEnabled = True
        Me.cmbGsmVoz.Items.AddRange(New Object() {resources.GetString("cmbGsmVoz.Items"), resources.GetString("cmbGsmVoz.Items1"), resources.GetString("cmbGsmVoz.Items2"), resources.GetString("cmbGsmVoz.Items3"), resources.GetString("cmbGsmVoz.Items4"), resources.GetString("cmbGsmVoz.Items5"), resources.GetString("cmbGsmVoz.Items6")})
        Me.cmbGsmVoz.Name = "cmbGsmVoz"
        Me.ttConsejo.SetToolTip(Me.cmbGsmVoz, resources.GetString("cmbGsmVoz.ToolTip"))
        '
        'lblGsmVoz
        '
        resources.ApplyResources(Me.lblGsmVoz, "lblGsmVoz")
        Me.lblGsmVoz.Name = "lblGsmVoz"
        Me.ttConsejo.SetToolTip(Me.lblGsmVoz, resources.GetString("lblGsmVoz.ToolTip"))
        '
        'cmbGsmDatos
        '
        resources.ApplyResources(Me.cmbGsmDatos, "cmbGsmDatos")
        Me.cmbGsmDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGsmDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbGsmDatos.FormattingEnabled = True
        Me.cmbGsmDatos.Items.AddRange(New Object() {resources.GetString("cmbGsmDatos.Items"), resources.GetString("cmbGsmDatos.Items1"), resources.GetString("cmbGsmDatos.Items2"), resources.GetString("cmbGsmDatos.Items3"), resources.GetString("cmbGsmDatos.Items4"), resources.GetString("cmbGsmDatos.Items5"), resources.GetString("cmbGsmDatos.Items6")})
        Me.cmbGsmDatos.Name = "cmbGsmDatos"
        Me.ttConsejo.SetToolTip(Me.cmbGsmDatos, resources.GetString("cmbGsmDatos.ToolTip"))
        '
        'lblGsmDatos
        '
        resources.ApplyResources(Me.lblGsmDatos, "lblGsmDatos")
        Me.lblGsmDatos.Name = "lblGsmDatos"
        Me.ttConsejo.SetToolTip(Me.lblGsmDatos, resources.GetString("lblGsmDatos.ToolTip"))
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        Me.ttConsejo.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'imgGsm
        '
        resources.ApplyResources(Me.imgGsm, "imgGsm")
        Me.imgGsm.Image = Global.Avm.My.Resources.Resources.icoGsm64
        Me.imgGsm.Name = "imgGsm"
        Me.imgGsm.TabStop = False
        Me.ttConsejo.SetToolTip(Me.imgGsm, resources.GetString("imgGsm.ToolTip"))
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttConsejo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        '
        'CtrGsmStatus
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgGsm)
        Me.Controls.Add(Me.btnGsmSet)
        Me.Controls.Add(Me.chkGsmNoBer)
        Me.Controls.Add(Me.nudGsmBer)
        Me.Controls.Add(Me.chkGsmNoRssi)
        Me.Controls.Add(Me.nudGsmRssi)
        Me.Controls.Add(Me.lblGsmRssi)
        Me.Controls.Add(Me.btnGsmUpdate)
        Me.Controls.Add(Me.cmbGsmVoz)
        Me.Controls.Add(Me.lblGsmVoz)
        Me.Controls.Add(Me.cmbGsmDatos)
        Me.Controls.Add(Me.lblGsmDatos)
        Me.Controls.Add(Me.chkGsmBerOn)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Name = "CtrGsmStatus"
        Me.ttConsejo.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        CType(Me.nudGsmBer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGsmRssi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgGsm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkGsmBerOn As System.Windows.Forms.CheckBox
    Friend WithEvents btnGsmSet As System.Windows.Forms.Button
    Friend WithEvents chkGsmNoBer As System.Windows.Forms.CheckBox
    Friend WithEvents nudGsmBer As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkGsmNoRssi As System.Windows.Forms.CheckBox
    Friend WithEvents nudGsmRssi As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGsmRssi As System.Windows.Forms.Label
    Friend WithEvents btnGsmUpdate As System.Windows.Forms.Button
    Friend WithEvents cmbGsmVoz As System.Windows.Forms.ComboBox
    Friend WithEvents lblGsmVoz As System.Windows.Forms.Label
    Friend WithEvents cmbGsmDatos As System.Windows.Forms.ComboBox
    Friend WithEvents lblGsmDatos As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents imgGsm As System.Windows.Forms.PictureBox
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip

End Class
