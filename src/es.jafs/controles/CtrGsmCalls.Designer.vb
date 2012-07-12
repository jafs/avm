<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrGsmCalls
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblGsmLlamadas = New System.Windows.Forms.Label()
        Me.txtGsmPrefijo = New System.Windows.Forms.TextBox()
        Me.btnGsmCall = New System.Windows.Forms.Button()
        Me.txtGsmNumero = New System.Windows.Forms.TextBox()
        Me.dgvGsmLlamadas = New System.Windows.Forms.DataGridView()
        Me.colType = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDataTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDataEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHold = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colBusy = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colCancel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.chkGsmTimer = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrGsm = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvGsmLlamadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGsmLlamadas
        '
        Me.lblGsmLlamadas.AutoSize = True
        Me.lblGsmLlamadas.Location = New System.Drawing.Point(14, 25)
        Me.lblGsmLlamadas.Name = "lblGsmLlamadas"
        Me.lblGsmLlamadas.Size = New System.Drawing.Size(91, 17)
        Me.lblGsmLlamadas.TabIndex = 31
        Me.lblGsmLlamadas.Text = "Current calls:"
        '
        'txtGsmPrefijo
        '
        Me.txtGsmPrefijo.Location = New System.Drawing.Point(17, 169)
        Me.txtGsmPrefijo.Name = "txtGsmPrefijo"
        Me.txtGsmPrefijo.Size = New System.Drawing.Size(38, 23)
        Me.txtGsmPrefijo.TabIndex = 28
        Me.txtGsmPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGsmCall
        '
        Me.btnGsmCall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnGsmCall.Location = New System.Drawing.Point(213, 168)
        Me.btnGsmCall.Name = "btnGsmCall"
        Me.btnGsmCall.Size = New System.Drawing.Size(55, 26)
        Me.btnGsmCall.TabIndex = 30
        Me.btnGsmCall.Text = "Call"
        Me.btnGsmCall.UseVisualStyleBackColor = True
        '
        'txtGsmNumero
        '
        Me.txtGsmNumero.Location = New System.Drawing.Point(61, 169)
        Me.txtGsmNumero.Name = "txtGsmNumero"
        Me.txtGsmNumero.Size = New System.Drawing.Size(146, 23)
        Me.txtGsmNumero.TabIndex = 29
        Me.txtGsmNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvGsmLlamadas
        '
        Me.dgvGsmLlamadas.AllowUserToAddRows = False
        Me.dgvGsmLlamadas.AllowUserToDeleteRows = False
        Me.dgvGsmLlamadas.AllowUserToResizeColumns = False
        Me.dgvGsmLlamadas.AllowUserToResizeRows = False
        Me.dgvGsmLlamadas.BackgroundColor = System.Drawing.Color.White
        Me.dgvGsmLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGsmLlamadas.ColumnHeadersVisible = False
        Me.dgvGsmLlamadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.colStatus, Me.colNumber, Me.colDataTipo, Me.colDataEstado, Me.colHold, Me.colBusy, Me.colCancel})
        Me.dgvGsmLlamadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvGsmLlamadas.Location = New System.Drawing.Point(17, 48)
        Me.dgvGsmLlamadas.MultiSelect = False
        Me.dgvGsmLlamadas.Name = "dgvGsmLlamadas"
        Me.dgvGsmLlamadas.ReadOnly = True
        Me.dgvGsmLlamadas.RowHeadersVisible = False
        Me.dgvGsmLlamadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.dgvGsmLlamadas.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGsmLlamadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvGsmLlamadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGsmLlamadas.Size = New System.Drawing.Size(251, 106)
        Me.dgvGsmLlamadas.TabIndex = 27
        '
        'colType
        '
        Me.colType.FillWeight = 20.0!
        Me.colType.HeaderText = "Tipo"
        Me.colType.MinimumWidth = 20
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colType.Width = 20
        '
        'colStatus
        '
        Me.colStatus.FillWeight = 20.0!
        Me.colStatus.HeaderText = "Estado"
        Me.colStatus.MinimumWidth = 20
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colStatus.Width = 20
        '
        'colNumber
        '
        Me.colNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNumber.HeaderText = "Numero"
        Me.colNumber.MinimumWidth = 100
        Me.colNumber.Name = "colNumber"
        Me.colNumber.ReadOnly = True
        Me.colNumber.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colDataTipo
        '
        Me.colDataTipo.HeaderText = "DTipo"
        Me.colDataTipo.Name = "colDataTipo"
        Me.colDataTipo.ReadOnly = True
        Me.colDataTipo.Visible = False
        '
        'colDataEstado
        '
        Me.colDataEstado.HeaderText = "DEstado"
        Me.colDataEstado.Name = "colDataEstado"
        Me.colDataEstado.ReadOnly = True
        Me.colDataEstado.Visible = False
        '
        'colHold
        '
        Me.colHold.FillWeight = 20.0!
        Me.colHold.HeaderText = "Hold"
        Me.colHold.MinimumWidth = 20
        Me.colHold.Name = "colHold"
        Me.colHold.ReadOnly = True
        Me.colHold.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colHold.Width = 20
        '
        'colBusy
        '
        Me.colBusy.FillWeight = 20.0!
        Me.colBusy.HeaderText = "Busy"
        Me.colBusy.MinimumWidth = 20
        Me.colBusy.Name = "colBusy"
        Me.colBusy.ReadOnly = True
        Me.colBusy.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colBusy.Width = 20
        '
        'colCancel
        '
        Me.colCancel.FillWeight = 20.0!
        Me.colCancel.HeaderText = "Cancel"
        Me.colCancel.MinimumWidth = 20
        Me.colCancel.Name = "colCancel"
        Me.colCancel.ReadOnly = True
        Me.colCancel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colCancel.Width = 20
        '
        'chkGsmTimer
        '
        Me.chkGsmTimer.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkGsmTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.chkGsmTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkGsmTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.chkGsmTimer.Location = New System.Drawing.Point(131, 14)
        Me.chkGsmTimer.Name = "chkGsmTimer"
        Me.chkGsmTimer.Size = New System.Drawing.Size(137, 28)
        Me.chkGsmTimer.TabIndex = 26
        Me.chkGsmTimer.Text = "Enable Monitor"
        Me.chkGsmTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkGsmTimer.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 85)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "This second GSM tab," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "allows you to control the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "calls status and view the list" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
    "of current calls. Firts, you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "need to enable Call Monitor."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.avm.My.Resources.Resources.gsm64
        Me.PictureBox1.Location = New System.Drawing.Point(17, 241)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'tmrGsm
        '
        Me.tmrGsm.Interval = 1000
        '
        'CtrGsmCalls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblGsmLlamadas)
        Me.Controls.Add(Me.txtGsmPrefijo)
        Me.Controls.Add(Me.btnGsmCall)
        Me.Controls.Add(Me.txtGsmNumero)
        Me.Controls.Add(Me.dgvGsmLlamadas)
        Me.Controls.Add(Me.chkGsmTimer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CtrGsmCalls"
        Me.Size = New System.Drawing.Size(280, 338)
        CType(Me.dgvGsmLlamadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGsmLlamadas As System.Windows.Forms.Label
    Friend WithEvents txtGsmPrefijo As System.Windows.Forms.TextBox
    Friend WithEvents btnGsmCall As System.Windows.Forms.Button
    Friend WithEvents txtGsmNumero As System.Windows.Forms.TextBox
    Friend WithEvents dgvGsmLlamadas As System.Windows.Forms.DataGridView
    Friend WithEvents colType As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDataTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDataEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHold As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colBusy As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colCancel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents chkGsmTimer As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrGsm As System.Windows.Forms.Timer

End Class
