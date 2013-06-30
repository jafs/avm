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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrMenu))
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
        resources.ApplyResources(Me.tblMenu, "tblMenu")
        Me.tblMenu.Controls.Add(Me.btnDesconectar, 2, 1)
        Me.tblMenu.Controls.Add(Me.btnCalls, 0, 0)
        Me.tblMenu.Controls.Add(Me.btnSensors, 0, 0)
        Me.tblMenu.Controls.Add(Me.btnGsm, 2, 0)
        Me.tblMenu.Controls.Add(Me.btnSms, 1, 1)
        Me.tblMenu.Controls.Add(Me.btnGps, 1, 0)
        Me.tblMenu.Controls.Add(Me.btnPower, 0, 0)
        Me.tblMenu.Name = "tblMenu"
        '
        'btnDesconectar
        '
        resources.ApplyResources(Me.btnDesconectar, "btnDesconectar")
        Me.btnDesconectar.FlatAppearance.BorderSize = 0
        Me.btnDesconectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDesconectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDesconectar.Image = Global.Avm.My.Resources.Resources.icoMenuLogout64
        Me.btnDesconectar.Name = "btnDesconectar"
        Me.btnDesconectar.UseVisualStyleBackColor = True
        '
        'btnCalls
        '
        resources.ApplyResources(Me.btnCalls, "btnCalls")
        Me.btnCalls.FlatAppearance.BorderSize = 0
        Me.btnCalls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCalls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCalls.Image = Global.Avm.My.Resources.Resources.icoCall64
        Me.btnCalls.Name = "btnCalls"
        Me.btnCalls.UseVisualStyleBackColor = True
        '
        'btnSensors
        '
        resources.ApplyResources(Me.btnSensors, "btnSensors")
        Me.btnSensors.FlatAppearance.BorderSize = 0
        Me.btnSensors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSensors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSensors.Image = Global.Avm.My.Resources.Resources.icoSensores64
        Me.btnSensors.Name = "btnSensors"
        Me.btnSensors.UseVisualStyleBackColor = True
        '
        'btnGsm
        '
        resources.ApplyResources(Me.btnGsm, "btnGsm")
        Me.btnGsm.FlatAppearance.BorderSize = 0
        Me.btnGsm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGsm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGsm.Image = Global.Avm.My.Resources.Resources.icoGsm64
        Me.btnGsm.Name = "btnGsm"
        Me.btnGsm.UseVisualStyleBackColor = True
        '
        'btnSms
        '
        resources.ApplyResources(Me.btnSms, "btnSms")
        Me.btnSms.FlatAppearance.BorderSize = 0
        Me.btnSms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSms.Image = Global.Avm.My.Resources.Resources.icoSms64
        Me.btnSms.Name = "btnSms"
        Me.btnSms.UseVisualStyleBackColor = True
        '
        'btnGps
        '
        resources.ApplyResources(Me.btnGps, "btnGps")
        Me.btnGps.FlatAppearance.BorderSize = 0
        Me.btnGps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGps.Image = Global.Avm.My.Resources.Resources.icoGps64
        Me.btnGps.Name = "btnGps"
        Me.btnGps.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        resources.ApplyResources(Me.btnPower, "btnPower")
        Me.btnPower.FlatAppearance.BorderSize = 0
        Me.btnPower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPower.Image = Global.Avm.My.Resources.Resources.icoBateria64
        Me.btnPower.Name = "btnPower"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'CtrMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.Avm.My.Resources.Resources.fondo
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.tblMenu)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Name = "CtrMenu"
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
