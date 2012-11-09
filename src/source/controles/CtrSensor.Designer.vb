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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrSensor))
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
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSensores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSenUpdate
        '
        resources.ApplyResources(Me.btnSenUpdate, "btnSenUpdate")
        Me.btnSenUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnSenUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSenUpdate.ForeColor = System.Drawing.Color.White
        Me.btnSenUpdate.Name = "btnSenUpdate"
        Me.ttConsejo.SetToolTip(Me.btnSenUpdate, resources.GetString("btnSenUpdate.ToolTip"))
        Me.btnSenUpdate.UseVisualStyleBackColor = False
        '
        'lblSenDesc
        '
        resources.ApplyResources(Me.lblSenDesc, "lblSenDesc")
        Me.lblSenDesc.Name = "lblSenDesc"
        Me.ttConsejo.SetToolTip(Me.lblSenDesc, resources.GetString("lblSenDesc.ToolTip"))
        '
        'btnSenSet
        '
        resources.ApplyResources(Me.btnSenSet, "btnSenSet")
        Me.btnSenSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnSenSet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSenSet.ForeColor = System.Drawing.Color.White
        Me.btnSenSet.Name = "btnSenSet"
        Me.ttConsejo.SetToolTip(Me.btnSenSet, resources.GetString("btnSenSet.ToolTip"))
        Me.btnSenSet.UseVisualStyleBackColor = False
        '
        'nudSenValor2
        '
        resources.ApplyResources(Me.nudSenValor2, "nudSenValor2")
        Me.nudSenValor2.DecimalPlaces = 4
        Me.nudSenValor2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.nudSenValor2.Name = "nudSenValor2"
        Me.ttConsejo.SetToolTip(Me.nudSenValor2, resources.GetString("nudSenValor2.ToolTip"))
        '
        'lblSenValor2
        '
        resources.ApplyResources(Me.lblSenValor2, "lblSenValor2")
        Me.lblSenValor2.Name = "lblSenValor2"
        Me.ttConsejo.SetToolTip(Me.lblSenValor2, resources.GetString("lblSenValor2.ToolTip"))
        '
        'nudSenValor3
        '
        resources.ApplyResources(Me.nudSenValor3, "nudSenValor3")
        Me.nudSenValor3.DecimalPlaces = 4
        Me.nudSenValor3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.nudSenValor3.Name = "nudSenValor3"
        Me.ttConsejo.SetToolTip(Me.nudSenValor3, resources.GetString("nudSenValor3.ToolTip"))
        '
        'lblSenValor3
        '
        resources.ApplyResources(Me.lblSenValor3, "lblSenValor3")
        Me.lblSenValor3.Name = "lblSenValor3"
        Me.ttConsejo.SetToolTip(Me.lblSenValor3, resources.GetString("lblSenValor3.ToolTip"))
        '
        'nudSenValor1
        '
        resources.ApplyResources(Me.nudSenValor1, "nudSenValor1")
        Me.nudSenValor1.DecimalPlaces = 4
        Me.nudSenValor1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.nudSenValor1.Name = "nudSenValor1"
        Me.ttConsejo.SetToolTip(Me.nudSenValor1, resources.GetString("nudSenValor1.ToolTip"))
        '
        'lblSenValor1
        '
        resources.ApplyResources(Me.lblSenValor1, "lblSenValor1")
        Me.lblSenValor1.Name = "lblSenValor1"
        Me.ttConsejo.SetToolTip(Me.lblSenValor1, resources.GetString("lblSenValor1.ToolTip"))
        '
        'lblSensor
        '
        resources.ApplyResources(Me.lblSensor, "lblSensor")
        Me.lblSensor.Name = "lblSensor"
        Me.ttConsejo.SetToolTip(Me.lblSensor, resources.GetString("lblSensor.ToolTip"))
        '
        'cmbSensores
        '
        resources.ApplyResources(Me.cmbSensores, "cmbSensores")
        Me.cmbSensores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSensores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbSensores.FormattingEnabled = True
        Me.cmbSensores.Items.AddRange(New Object() {resources.GetString("cmbSensores.Items"), resources.GetString("cmbSensores.Items1"), resources.GetString("cmbSensores.Items2"), resources.GetString("cmbSensores.Items3"), resources.GetString("cmbSensores.Items4")})
        Me.cmbSensores.Name = "cmbSensores"
        Me.ttConsejo.SetToolTip(Me.cmbSensores, resources.GetString("cmbSensores.ToolTip"))
        '
        'imgSensores
        '
        resources.ApplyResources(Me.imgSensores, "imgSensores")
        Me.imgSensores.Image = Global.Avm.My.Resources.Resources.icoSensores64
        Me.imgSensores.Name = "imgSensores"
        Me.imgSensores.TabStop = False
        Me.ttConsejo.SetToolTip(Me.imgSensores, resources.GetString("imgSensores.ToolTip"))
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttConsejo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        '
        'CtrSensor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.btnSenUpdate)
        Me.Controls.Add(Me.lblSenDesc)
        Me.Controls.Add(Me.btnSenSet)
        Me.Controls.Add(Me.nudSenValor2)
        Me.Controls.Add(Me.lblSenValor2)
        Me.Controls.Add(Me.nudSenValor3)
        Me.Controls.Add(Me.lblSenValor3)
        Me.Controls.Add(Me.nudSenValor1)
        Me.Controls.Add(Me.lblSenValor1)
        Me.Controls.Add(Me.lblSensor)
        Me.Controls.Add(Me.cmbSensores)
        Me.Controls.Add(Me.imgSensores)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Name = "CtrSensor"
        Me.ttConsejo.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        CType(Me.nudSenValor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSenValor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSensores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSenUpdate As System.Windows.Forms.Button
    Friend WithEvents lblSenDesc As System.Windows.Forms.Label
    Friend WithEvents btnSenSet As System.Windows.Forms.Button
    Friend WithEvents nudSenValor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor2 As System.Windows.Forms.Label
    Friend WithEvents nudSenValor3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor3 As System.Windows.Forms.Label
    Friend WithEvents nudSenValor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSenValor1 As System.Windows.Forms.Label
    Friend WithEvents lblSensor As System.Windows.Forms.Label
    Friend WithEvents cmbSensores As System.Windows.Forms.ComboBox
    Friend WithEvents imgSensores As System.Windows.Forms.PictureBox
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip

End Class
