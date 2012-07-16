<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrMenu
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
        Me.tblMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDesconectar = New System.Windows.Forms.Button()
        Me.btnCalls = New System.Windows.Forms.Button()
        Me.btnSensors = New System.Windows.Forms.Button()
        Me.btnGsm = New System.Windows.Forms.Button()
        Me.btnSms = New System.Windows.Forms.Button()
        Me.btnGps = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.tblMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblMenu
        '
        Me.tblMenu.ColumnCount = 4
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblMenu.Controls.Add(Me.btnDesconectar, 2, 1)
        Me.tblMenu.Controls.Add(Me.btnCalls, 0, 0)
        Me.tblMenu.Controls.Add(Me.btnSensors, 0, 0)
        Me.tblMenu.Controls.Add(Me.btnGsm, 2, 0)
        Me.tblMenu.Controls.Add(Me.btnSms, 1, 1)
        Me.tblMenu.Controls.Add(Me.btnGps, 1, 0)
        Me.tblMenu.Controls.Add(Me.btnPower, 0, 0)
        Me.tblMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMenu.Location = New System.Drawing.Point(0, 0)
        Me.tblMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.tblMenu.Name = "tblMenu"
        Me.tblMenu.RowCount = 4
        Me.tblMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblMenu.Size = New System.Drawing.Size(278, 336)
        Me.tblMenu.TabIndex = 0
        '
        'btnDesconectar
        '
        Me.btnDesconectar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDesconectar.FlatAppearance.BorderSize = 0
        Me.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesconectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDesconectar.Image = Global.Avm.My.Resources.Resources.icoMenuDesconectar64
        Me.btnDesconectar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDesconectar.Location = New System.Drawing.Point(141, 103)
        Me.btnDesconectar.Name = "btnDesconectar"
        Me.btnDesconectar.Size = New System.Drawing.Size(63, 94)
        Me.btnDesconectar.TabIndex = 13
        Me.btnDesconectar.Text = "Logout"
        Me.btnDesconectar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDesconectar.UseVisualStyleBackColor = True
        '
        'btnCalls
        '
        Me.btnCalls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCalls.FlatAppearance.BorderSize = 0
        Me.btnCalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalls.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCalls.Image = Global.Avm.My.Resources.Resources.icoGsm64
        Me.btnCalls.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCalls.Location = New System.Drawing.Point(72, 3)
        Me.btnCalls.Name = "btnCalls"
        Me.btnCalls.Size = New System.Drawing.Size(63, 94)
        Me.btnCalls.TabIndex = 12
        Me.btnCalls.Text = "Calls"
        Me.btnCalls.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCalls.UseVisualStyleBackColor = True
        '
        'btnSensors
        '
        Me.btnSensors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSensors.FlatAppearance.BorderSize = 0
        Me.btnSensors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSensors.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSensors.Image = Global.Avm.My.Resources.Resources.icoSensores64
        Me.btnSensors.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSensors.Location = New System.Drawing.Point(3, 3)
        Me.btnSensors.Name = "btnSensors"
        Me.btnSensors.Size = New System.Drawing.Size(63, 94)
        Me.btnSensors.TabIndex = 11
        Me.btnSensors.Text = "Sensors"
        Me.btnSensors.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSensors.UseVisualStyleBackColor = True
        '
        'btnGsm
        '
        Me.btnGsm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGsm.FlatAppearance.BorderSize = 0
        Me.btnGsm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGsm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGsm.Image = Global.Avm.My.Resources.Resources.icoGsm64
        Me.btnGsm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGsm.Location = New System.Drawing.Point(3, 103)
        Me.btnGsm.Name = "btnGsm"
        Me.btnGsm.Size = New System.Drawing.Size(63, 94)
        Me.btnGsm.TabIndex = 6
        Me.btnGsm.Text = "GSM"
        Me.btnGsm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGsm.UseVisualStyleBackColor = True
        '
        'btnSms
        '
        Me.btnSms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSms.FlatAppearance.BorderSize = 0
        Me.btnSms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSms.Image = Global.Avm.My.Resources.Resources.icoSms64
        Me.btnSms.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSms.Location = New System.Drawing.Point(72, 103)
        Me.btnSms.Name = "btnSms"
        Me.btnSms.Size = New System.Drawing.Size(63, 94)
        Me.btnSms.TabIndex = 5
        Me.btnSms.Text = "SMS"
        Me.btnSms.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSms.UseVisualStyleBackColor = True
        '
        'btnGps
        '
        Me.btnGps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGps.FlatAppearance.BorderSize = 0
        Me.btnGps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnGps.Image = Global.Avm.My.Resources.Resources.icoGps64
        Me.btnGps.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGps.Location = New System.Drawing.Point(210, 3)
        Me.btnGps.Name = "btnGps"
        Me.btnGps.Size = New System.Drawing.Size(65, 94)
        Me.btnGps.TabIndex = 1
        Me.btnGps.Text = "GPS"
        Me.btnGps.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGps.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPower.FlatAppearance.BorderSize = 0
        Me.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnPower.Image = Global.Avm.My.Resources.Resources.icoBateria64
        Me.btnPower.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPower.Location = New System.Drawing.Point(141, 3)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(63, 94)
        Me.btnPower.TabIndex = 0
        Me.btnPower.Text = "Power"
        Me.btnPower.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'CtrMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.tblMenu)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaximumSize = New System.Drawing.Size(280, 338)
        Me.MinimumSize = New System.Drawing.Size(280, 338)
        Me.Name = "CtrMenu"
        Me.Size = New System.Drawing.Size(278, 336)
        Me.tblMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblMenu As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSms As System.Windows.Forms.Button
    Friend WithEvents btnGps As System.Windows.Forms.Button
    Friend WithEvents btnPower As System.Windows.Forms.Button
    Friend WithEvents btnGsm As System.Windows.Forms.Button
    Friend WithEvents btnCalls As System.Windows.Forms.Button
    Friend WithEvents btnSensors As System.Windows.Forms.Button
    Friend WithEvents btnDesconectar As System.Windows.Forms.Button

End Class
