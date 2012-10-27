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
        Me.btnGpsSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnGpsSet.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGpsSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGpsSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGpsSet.ForeColor = System.Drawing.Color.White
        Me.btnGpsSet.Location = New System.Drawing.Point(15, 163)
        Me.btnGpsSet.Name = "btnGpsSet"
        Me.btnGpsSet.Size = New System.Drawing.Size(115, 32)
        Me.btnGpsSet.TabIndex = 50
        Me.btnGpsSet.Text = "Set location"
        Me.ttConsejo.SetToolTip(Me.btnGpsSet, "Send location to emulator")
        Me.btnGpsSet.UseVisualStyleBackColor = False
        '
        'chkGpsSatelites
        '
        Me.chkGpsSatelites.AutoSize = True
        Me.chkGpsSatelites.Enabled = False
        Me.chkGpsSatelites.Location = New System.Drawing.Point(15, 131)
        Me.chkGpsSatelites.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.chkGpsSatelites.Name = "chkGpsSatelites"
        Me.chkGpsSatelites.Size = New System.Drawing.Size(88, 21)
        Me.chkGpsSatelites.TabIndex = 49
        Me.chkGpsSatelites.Text = "Satellites:"
        Me.ttConsejo.SetToolTip(Me.chkGpsSatelites, "Check to send satellites number")
        Me.chkGpsSatelites.UseVisualStyleBackColor = True
        '
        'nudGpsSatelites
        '
        Me.nudGpsSatelites.Enabled = False
        Me.nudGpsSatelites.Location = New System.Drawing.Point(99, 130)
        Me.nudGpsSatelites.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudGpsSatelites.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGpsSatelites.Name = "nudGpsSatelites"
        Me.nudGpsSatelites.Size = New System.Drawing.Size(44, 23)
        Me.nudGpsSatelites.TabIndex = 48
        Me.ttConsejo.SetToolTip(Me.nudGpsSatelites, "Number of satellites")
        Me.nudGpsSatelites.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudGpsAltitude
        '
        Me.nudGpsAltitude.DecimalPlaces = 4
        Me.nudGpsAltitude.Enabled = False
        Me.nudGpsAltitude.Location = New System.Drawing.Point(99, 99)
        Me.nudGpsAltitude.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudGpsAltitude.Name = "nudGpsAltitude"
        Me.nudGpsAltitude.Size = New System.Drawing.Size(80, 23)
        Me.nudGpsAltitude.TabIndex = 47
        Me.ttConsejo.SetToolTip(Me.nudGpsAltitude, "Altitude in meters")
        '
        'chkGpsAltitude
        '
        Me.chkGpsAltitude.AutoSize = True
        Me.chkGpsAltitude.Location = New System.Drawing.Point(15, 100)
        Me.chkGpsAltitude.Name = "chkGpsAltitude"
        Me.chkGpsAltitude.Size = New System.Drawing.Size(78, 21)
        Me.chkGpsAltitude.TabIndex = 46
        Me.chkGpsAltitude.Text = "Altitude:"
        Me.ttConsejo.SetToolTip(Me.chkGpsAltitude, "Check to send altitude")
        Me.chkGpsAltitude.UseVisualStyleBackColor = True
        '
        'nudGpsLatSec
        '
        Me.nudGpsLatSec.Location = New System.Drawing.Point(218, 62)
        Me.nudGpsLatSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLatSec.Name = "nudGpsLatSec"
        Me.nudGpsLatSec.Size = New System.Drawing.Size(50, 23)
        Me.nudGpsLatSec.TabIndex = 45
        Me.ttConsejo.SetToolTip(Me.nudGpsLatSec, "Seconds")
        '
        'nudGpsLatMin
        '
        Me.nudGpsLatMin.Location = New System.Drawing.Point(158, 62)
        Me.nudGpsLatMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLatMin.Name = "nudGpsLatMin"
        Me.nudGpsLatMin.Size = New System.Drawing.Size(50, 23)
        Me.nudGpsLatMin.TabIndex = 44
        Me.ttConsejo.SetToolTip(Me.nudGpsLatMin, "Minutes")
        '
        'nudGpsLatGrados
        '
        Me.nudGpsLatGrados.Location = New System.Drawing.Point(99, 62)
        Me.nudGpsLatGrados.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.nudGpsLatGrados.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
        Me.nudGpsLatGrados.Name = "nudGpsLatGrados"
        Me.nudGpsLatGrados.Size = New System.Drawing.Size(50, 23)
        Me.nudGpsLatGrados.TabIndex = 43
        Me.ttConsejo.SetToolTip(Me.nudGpsLatGrados, "Degrees (between -90 and 90)")
        '
        'lblGpsLatitud
        '
        Me.lblGpsLatitud.AutoSize = True
        Me.lblGpsLatitud.Location = New System.Drawing.Point(12, 64)
        Me.lblGpsLatitud.Name = "lblGpsLatitud"
        Me.lblGpsLatitud.Size = New System.Drawing.Size(63, 17)
        Me.lblGpsLatitud.TabIndex = 42
        Me.lblGpsLatitud.Text = "Latitude:"
        Me.ttConsejo.SetToolTip(Me.lblGpsLatitud, "Latitude coordinates")
        '
        'nudGpsLonSec
        '
        Me.nudGpsLonSec.Location = New System.Drawing.Point(218, 23)
        Me.nudGpsLonSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLonSec.Name = "nudGpsLonSec"
        Me.nudGpsLonSec.Size = New System.Drawing.Size(50, 23)
        Me.nudGpsLonSec.TabIndex = 41
        Me.ttConsejo.SetToolTip(Me.nudGpsLonSec, "Seconds")
        '
        'nudGpsLonMin
        '
        Me.nudGpsLonMin.Location = New System.Drawing.Point(158, 23)
        Me.nudGpsLonMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudGpsLonMin.Name = "nudGpsLonMin"
        Me.nudGpsLonMin.Size = New System.Drawing.Size(50, 23)
        Me.nudGpsLonMin.TabIndex = 40
        Me.ttConsejo.SetToolTip(Me.nudGpsLonMin, "Minutes")
        '
        'nudGpsLonGrados
        '
        Me.nudGpsLonGrados.Location = New System.Drawing.Point(99, 23)
        Me.nudGpsLonGrados.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudGpsLonGrados.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.nudGpsLonGrados.Name = "nudGpsLonGrados"
        Me.nudGpsLonGrados.Size = New System.Drawing.Size(50, 23)
        Me.nudGpsLonGrados.TabIndex = 39
        Me.ttConsejo.SetToolTip(Me.nudGpsLonGrados, "Degrees (between -180 and 180)")
        '
        'lblGpsLongitud
        '
        Me.lblGpsLongitud.AutoSize = True
        Me.lblGpsLongitud.Location = New System.Drawing.Point(12, 25)
        Me.lblGpsLongitud.Name = "lblGpsLongitud"
        Me.lblGpsLongitud.Size = New System.Drawing.Size(75, 17)
        Me.lblGpsLongitud.TabIndex = 38
        Me.lblGpsLongitud.Text = "Longitude:"
        Me.ttConsejo.SetToolTip(Me.lblGpsLongitud, "Longitude coordinates")
        '
        'lblGpsDesc
        '
        Me.lblGpsDesc.AutoSize = True
        Me.lblGpsDesc.Location = New System.Drawing.Point(86, 216)
        Me.lblGpsDesc.Name = "lblGpsDesc"
        Me.lblGpsDesc.Size = New System.Drawing.Size(187, 102)
        Me.lblGpsDesc.TabIndex = 51
        Me.lblGpsDesc.Text = "Here you will be able to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "change the GPS location." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter the longitude and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lati" & _
    "tude coordinates to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "change the position. Altitude" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and satellites are optional." & _
    ""
        '
        'imgGps
        '
        Me.imgGps.Image = Global.Avm.My.Resources.Resources.icoGps64
        Me.imgGps.Location = New System.Drawing.Point(16, 238)
        Me.imgGps.Name = "imgGps"
        Me.imgGps.Size = New System.Drawing.Size(64, 64)
        Me.imgGps.TabIndex = 52
        Me.imgGps.TabStop = False
        '
        'CtrGps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CtrGps"
        Me.Size = New System.Drawing.Size(280, 338)
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
