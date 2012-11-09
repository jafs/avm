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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrGsmCalls))
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
        resources.ApplyResources(Me.lblGsmLlamadas, "lblGsmLlamadas")
        Me.lblGsmLlamadas.Name = "lblGsmLlamadas"
        Me.ttConsejo.SetToolTip(Me.lblGsmLlamadas, resources.GetString("lblGsmLlamadas.ToolTip"))
        '
        'txtGsmPrefijo
        '
        resources.ApplyResources(Me.txtGsmPrefijo, "txtGsmPrefijo")
        Me.txtGsmPrefijo.Name = "txtGsmPrefijo"
        Me.ttConsejo.SetToolTip(Me.txtGsmPrefijo, resources.GetString("txtGsmPrefijo.ToolTip"))
        '
        'txtGsmNumero
        '
        resources.ApplyResources(Me.txtGsmNumero, "txtGsmNumero")
        Me.txtGsmNumero.Name = "txtGsmNumero"
        Me.ttConsejo.SetToolTip(Me.txtGsmNumero, resources.GetString("txtGsmNumero.ToolTip"))
        '
        'dgvGsmLlamadas
        '
        resources.ApplyResources(Me.dgvGsmLlamadas, "dgvGsmLlamadas")
        Me.dgvGsmLlamadas.AllowUserToAddRows = False
        Me.dgvGsmLlamadas.AllowUserToDeleteRows = False
        Me.dgvGsmLlamadas.AllowUserToResizeColumns = False
        Me.dgvGsmLlamadas.AllowUserToResizeRows = False
        Me.dgvGsmLlamadas.BackgroundColor = System.Drawing.Color.White
        Me.dgvGsmLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGsmLlamadas.ColumnHeadersVisible = False
        Me.dgvGsmLlamadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.colNumber, Me.colDataTipo, Me.colDataEstado, Me.colStatus, Me.colBusy, Me.colCancel})
        Me.dgvGsmLlamadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvGsmLlamadas.MultiSelect = False
        Me.dgvGsmLlamadas.Name = "dgvGsmLlamadas"
        Me.dgvGsmLlamadas.ReadOnly = True
        Me.dgvGsmLlamadas.RowHeadersVisible = False
        Me.dgvGsmLlamadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.dgvGsmLlamadas.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGsmLlamadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ttConsejo.SetToolTip(Me.dgvGsmLlamadas, resources.GetString("dgvGsmLlamadas.ToolTip"))
        '
        'colType
        '
        Me.colType.FillWeight = 20.0!
        resources.ApplyResources(Me.colType, "colType")
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colNumber
        '
        Me.colNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.colNumber, "colNumber")
        Me.colNumber.Name = "colNumber"
        Me.colNumber.ReadOnly = True
        Me.colNumber.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colDataTipo
        '
        resources.ApplyResources(Me.colDataTipo, "colDataTipo")
        Me.colDataTipo.Name = "colDataTipo"
        Me.colDataTipo.ReadOnly = True
        '
        'colDataEstado
        '
        resources.ApplyResources(Me.colDataEstado, "colDataEstado")
        Me.colDataEstado.Name = "colDataEstado"
        Me.colDataEstado.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.FillWeight = 20.0!
        resources.ApplyResources(Me.colStatus, "colStatus")
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colBusy
        '
        Me.colBusy.FillWeight = 20.0!
        resources.ApplyResources(Me.colBusy, "colBusy")
        Me.colBusy.Name = "colBusy"
        Me.colBusy.ReadOnly = True
        Me.colBusy.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colCancel
        '
        Me.colCancel.FillWeight = 20.0!
        resources.ApplyResources(Me.colCancel, "colCancel")
        Me.colCancel.Name = "colCancel"
        Me.colCancel.ReadOnly = True
        Me.colCancel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        Me.ttConsejo.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
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
        resources.ApplyResources(Me.btnGsmCall, "btnGsmCall")
        Me.btnGsmCall.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnGsmCall.BackgroundImage = Global.Avm.My.Resources.Resources.btnLlamar
        Me.btnGsmCall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnGsmCall.Name = "btnGsmCall"
        Me.ttConsejo.SetToolTip(Me.btnGsmCall, resources.GetString("btnGsmCall.ToolTip"))
        Me.btnGsmCall.UseVisualStyleBackColor = False
        '
        'lblPrefijo
        '
        resources.ApplyResources(Me.lblPrefijo, "lblPrefijo")
        Me.lblPrefijo.Name = "lblPrefijo"
        Me.ttConsejo.SetToolTip(Me.lblPrefijo, resources.GetString("lblPrefijo.ToolTip"))
        '
        'lblNumero
        '
        resources.ApplyResources(Me.lblNumero, "lblNumero")
        Me.lblNumero.Name = "lblNumero"
        Me.ttConsejo.SetToolTip(Me.lblNumero, resources.GetString("lblNumero.ToolTip"))
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.Avm.My.Resources.Resources.icoCall64
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        Me.ttConsejo.SetToolTip(Me.PictureBox1, resources.GetString("PictureBox1.ToolTip"))
        '
        'CtrGsmCalls
        '
        resources.ApplyResources(Me, "$this")
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
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Name = "CtrGsmCalls"
        Me.ttConsejo.SetToolTip(Me, resources.GetString("$this.ToolTip"))
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
