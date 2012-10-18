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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblGsmLlamadas = New System.Windows.Forms.Label()
        Me.txtGsmPrefijo = New System.Windows.Forms.TextBox()
        Me.txtGsmNumero = New System.Windows.Forms.TextBox()
        Me.dgvGsmLlamadas = New System.Windows.Forms.DataGridView()
        Me.colType = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDataTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDataEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colBusy = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colCancel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrGsm = New System.Windows.Forms.Timer(Me.components)
        Me.ttConsejo = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGsmCall = New System.Windows.Forms.Button()
        Me.lblPrefijo = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvGsmLlamadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGsmLlamadas
        '
        Me.lblGsmLlamadas.AutoSize = True
        Me.lblGsmLlamadas.Location = New System.Drawing.Point(15, 16)
        Me.lblGsmLlamadas.Name = "lblGsmLlamadas"
        Me.lblGsmLlamadas.Size = New System.Drawing.Size(91, 17)
        Me.lblGsmLlamadas.TabIndex = 31
        Me.lblGsmLlamadas.Text = "Current calls:"
        '
        'txtGsmPrefijo
        '
        Me.txtGsmPrefijo.Location = New System.Drawing.Point(17, 178)
        Me.txtGsmPrefijo.MaxLength = 4
        Me.txtGsmPrefijo.Name = "txtGsmPrefijo"
        Me.txtGsmPrefijo.Size = New System.Drawing.Size(47, 23)
        Me.txtGsmPrefijo.TabIndex = 28
        Me.txtGsmPrefijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGsmNumero
        '
        Me.txtGsmNumero.Location = New System.Drawing.Point(76, 178)
        Me.txtGsmNumero.MaxLength = 20
        Me.txtGsmNumero.Name = "txtGsmNumero"
        Me.txtGsmNumero.Size = New System.Drawing.Size(150, 23)
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
        Me.dgvGsmLlamadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.colNumber, Me.colDataTipo, Me.colDataEstado, Me.colStatus, Me.colBusy, Me.colCancel})
        Me.dgvGsmLlamadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvGsmLlamadas.Location = New System.Drawing.Point(17, 37)
        Me.dgvGsmLlamadas.MultiSelect = False
        Me.dgvGsmLlamadas.Name = "dgvGsmLlamadas"
        Me.dgvGsmLlamadas.ReadOnly = True
        Me.dgvGsmLlamadas.RowHeadersVisible = False
        Me.dgvGsmLlamadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.dgvGsmLlamadas.RowsDefaultCellStyle = DataGridViewCellStyle2
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
        'colBusy
        '
        Me.colBusy.FillWeight = 20.0!
        Me.colBusy.HeaderText = "Busy"
        Me.colBusy.MinimumWidth = 20
        Me.colBusy.Name = "colBusy"
        Me.colBusy.ReadOnly = True
        Me.colBusy.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colBusy.ToolTipText = "Finalize current call as busy"
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
        Me.colCancel.ToolTipText = "Cancel current call"
        Me.colCancel.Width = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 51)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "In this section you can" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "manage the current calls, as" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "well as make incoming call" & _
            "s."
        '
        'tmrGsm
        '
        Me.tmrGsm.Interval = 1000
        '
        'ttConsejo
        '
        Me.ttConsejo.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttConsejo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(115, Byte), Integer))
        '
        'btnGsmCall
        '
        Me.btnGsmCall.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnGsmCall.BackgroundImage = Global.Avm.My.Resources.Resources.btnLlamar
        Me.btnGsmCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGsmCall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnGsmCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGsmCall.Location = New System.Drawing.Point(234, 172)
        Me.btnGsmCall.Name = "btnGsmCall"
        Me.btnGsmCall.Size = New System.Drawing.Size(34, 34)
        Me.btnGsmCall.TabIndex = 30
        Me.ttConsejo.SetToolTip(Me.btnGsmCall, "Make a call")
        Me.btnGsmCall.UseVisualStyleBackColor = False
        '
        'lblPrefijo
        '
        Me.lblPrefijo.AutoSize = True
        Me.lblPrefijo.Location = New System.Drawing.Point(14, 159)
        Me.lblPrefijo.Name = "lblPrefijo"
        Me.lblPrefijo.Size = New System.Drawing.Size(47, 17)
        Me.lblPrefijo.TabIndex = 34
        Me.lblPrefijo.Text = "Prefix:"
        Me.ttConsejo.SetToolTip(Me.lblPrefijo, "International prefix")
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(73, 159)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(105, 17)
        Me.lblNumero.TabIndex = 35
        Me.lblNumero.Text = "Phone number:"
        Me.ttConsejo.SetToolTip(Me.lblNumero, "Phone number of the caller")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Avm.My.Resources.Resources.icoGsm64
        Me.PictureBox1.Location = New System.Drawing.Point(14, 257)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'CtrGsmCalls
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblPrefijo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblGsmLlamadas)
        Me.Controls.Add(Me.txtGsmPrefijo)
        Me.Controls.Add(Me.btnGsmCall)
        Me.Controls.Add(Me.txtGsmNumero)
        Me.Controls.Add(Me.dgvGsmLlamadas)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrGsm As System.Windows.Forms.Timer
    Friend WithEvents colType As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDataTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDataEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colBusy As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colCancel As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents lblPrefijo As System.Windows.Forms.Label
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Private WithEvents ttConsejo As System.Windows.Forms.ToolTip

End Class
