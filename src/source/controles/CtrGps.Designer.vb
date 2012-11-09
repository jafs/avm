<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrGps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrGps))
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
        Me.lblGpsDesc = New System.Windows.Forms.Label()
        Me.imgGps = New System.Windows.Forms.PictureBox()
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudGpsSatelites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsAltitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLatSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLatMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLatGrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLonSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLonMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGpsLonGrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgGps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGpsSet
        '
        resources.ApplyResources(Me.btnGpsSet, "btnGpsSet")
        Me.btnGpsSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnGpsSet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGpsSet.ForeColor = System.Drawing.Color.White
        Me.btnGpsSet.Name = "btnGpsSet"
        Me.ttConsejo.SetToolTip(Me.btnGpsSet, resources.GetString("btnGpsSet.ToolTip"))
        Me.btnGpsSet.UseVisualStyleBackColor = False
        '
        'chkGpsSatelites
        '
        resources.ApplyResources(Me.chkGpsSatelites, "chkGpsSatelites")
        Me.chkGpsSatelites.Name = "chkGpsSatelites"
        Me.ttConsejo.SetToolTip(Me.chkGpsSatelites, resources.GetString("chkGpsSatelites.ToolTip"))
        Me.chkGpsSatelites.UseVisualStyleBackColor = True
        '
        'nudGpsSatelites
        '
        resources.ApplyResources(Me.nudGpsSatelites, "nudGpsSatelites")
        Me.nudGpsSatelites.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudGpsSatelites.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGpsSatelites.Name = "nudGpsSatelites"
        Me.ttConsejo.SetToolTip(Me.nudGpsSatelites, resources.GetString("nudGpsSatelites.ToolTip"))
        Me.nudGpsSatelites.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudGpsAltitude
        '
        resources.ApplyResources(Me.nudGpsAltitude, "nudGpsAltitude")
        Me.nudGpsAltitude.DecimalPlaces = 4
        Me.nudGpsAltitude.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudGpsAltitude.Name = "nudGpsAltitude"
        Me.ttConsejo.SetToolTip(Me.nudGpsAltitude, resources.GetString("nudGpsAltitude.ToolTip"))
        '
        'chkGpsAltitude
        '
        resources.ApplyResources(Me.chkGpsAltitude, "chkGpsAltitude")
        Me.chkGpsAltitude.Name = "chkGpsAltitude"
        Me.ttConsejo.SetToolTip(Me.chkGpsAltitude, resources.GetString("chkGpsAltitude.ToolTip"))
        Me.chkGpsAltitude.UseVisualStyleBackColor = True
        '
        'nudGpsLatSec
        '
        resources.ApplyResources(Me.nudGpsLatSec, "nudGpsLatSec")
        Me.nudGpsLatSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLatSec.Name = "nudGpsLatSec"
        Me.ttConsejo.SetToolTip(Me.nudGpsLatSec, resources.GetString("nudGpsLatSec.ToolTip"))
        '
        'nudGpsLatMin
        '
        resources.ApplyResources(Me.nudGpsLatMin, "nudGpsLatMin")
        Me.nudGpsLatMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLatMin.Name = "nudGpsLatMin"
        Me.ttConsejo.SetToolTip(Me.nudGpsLatMin, resources.GetString("nudGpsLatMin.ToolTip"))
        '
        'nudGpsLatGrados
        '
        resources.ApplyResources(Me.nudGpsLatGrados, "nudGpsLatGrados")
        Me.nudGpsLatGrados.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.nudGpsLatGrados.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
        Me.nudGpsLatGrados.Name = "nudGpsLatGrados"
        Me.ttConsejo.SetToolTip(Me.nudGpsLatGrados, resources.GetString("nudGpsLatGrados.ToolTip"))
        '
        'lblGpsLatitud
        '
        resources.ApplyResources(Me.lblGpsLatitud, "lblGpsLatitud")
        Me.lblGpsLatitud.Name = "lblGpsLatitud"
        Me.ttConsejo.SetToolTip(Me.lblGpsLatitud, resources.GetString("lblGpsLatitud.ToolTip"))
        '
        'nudGpsLonSec
        '
        resources.ApplyResources(Me.nudGpsLonSec, "nudGpsLonSec")
        Me.nudGpsLonSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLonSec.Name = "nudGpsLonSec"
        Me.ttConsejo.SetToolTip(Me.nudGpsLonSec, resources.GetString("nudGpsLonSec.ToolTip"))
        '
        'nudGpsLonMin
        '
        resources.ApplyResources(Me.nudGpsLonMin, "nudGpsLonMin")
        Me.nudGpsLonMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLonMin.Name = "nudGpsLonMin"
        Me.ttConsejo.SetToolTip(Me.nudGpsLonMin, resources.GetString("nudGpsLonMin.ToolTip"))
        '
        'nudGpsLonGrados
        '
        resources.ApplyResources(Me.nudGpsLonGrados, "nudGpsLonGrados")
        Me.nudGpsLonGrados.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudGpsLonGrados.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.nudGpsLonGrados.Name = "nudGpsLonGrados"
        Me.ttConsejo.SetToolTip(Me.nudGpsLonGrados, resources.GetString("nudGpsLonGrados.ToolTip"))
        '
        'lblGpsLongitud
        '
        resources.ApplyResources(Me.lblGpsLongitud, "lblGpsLongitud")
        Me.lblGpsLongitud.Name = "lblGpsLongitud"
        Me.ttConsejo.SetToolTip(Me.lblGpsLongitud, resources.GetString("lblGpsLongitud.ToolTip"))
        '
        'lblGpsDesc
        '
        resources.ApplyResources(Me.lblGpsDesc, "lblGpsDesc")
        Me.lblGpsDesc.Name = "lblGpsDesc"
        Me.ttConsejo.SetToolTip(Me.lblGpsDesc, resources.GetString("lblGpsDesc.ToolTip"))
        '
        'imgGps
        '
        resources.ApplyResources(Me.imgGps, "imgGps")
        Me.imgGps.Image = Global.Avm.My.Resources.Resources.icoGps64
        Me.imgGps.Name = "imgGps"
        Me.imgGps.TabStop = False
        Me.ttConsejo.SetToolTip(Me.imgGps, resources.GetString("imgGps.ToolTip"))
        '
        'CtrGps
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblGpsDesc)
        Me.Controls.Add(Me.imgGps)
        Me.Controls.Add(Me.btnGpsSet)
        Me.Controls.Add(Me.nudGpsSatelites)
        Me.Controls.Add(Me.nudGpsAltitude)
        Me.Controls.Add(Me.chkGpsAltitude)
        Me.Controls.Add(Me.nudGpsLatSec)
        Me.Controls.Add(Me.nudGpsLatMin)
        Me.Controls.Add(Me.nudGpsLatGrados)
        Me.Controls.Add(Me.lblGpsLatitud)
        Me.Controls.Add(Me.nudGpsLonSec)
        Me.Controls.Add(Me.nudGpsLonMin)
        Me.Controls.Add(Me.nudGpsLonGrados)
        Me.Controls.Add(Me.lblGpsLongitud)
        Me.Controls.Add(Me.chkGpsSatelites)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Name = "CtrGps"
        Me.ttConsejo.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        CType(Me.nudGpsSatelites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsAltitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLatSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLatMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLatGrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLonSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLonMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGpsLonGrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgGps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents lblGpsDesc As System.Windows.Forms.Label
    Friend WithEvents imgGps As System.Windows.Forms.PictureBox
    Friend WithEvents ttConsejo As System.Windows.Forms.ToolTip

End Class
