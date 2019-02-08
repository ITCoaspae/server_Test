<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsBC_CatTransaccionesSucursalesBov
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDescCtaCargo = New System.Windows.Forms.TextBox()
        Me.txtDescCtaAbono = New System.Windows.Forms.TextBox()
        Me.txtCtaCargos = New System.Windows.Forms.TextBox()
        Me.lblCtaCargos = New System.Windows.Forms.Label()
        Me.txtCtaAbono = New System.Windows.Forms.TextBox()
        Me.lblCtaA = New System.Windows.Forms.Label()
        Me.cbTransaccion = New System.Windows.Forms.ComboBox()
        Me.lblTipoTransaccion = New System.Windows.Forms.Label()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnGuardar1)
        Me.Panel2.Controls.Add(Me.txtDescCtaCargo)
        Me.Panel2.Controls.Add(Me.txtDescCtaAbono)
        Me.Panel2.Controls.Add(Me.txtCtaCargos)
        Me.Panel2.Controls.Add(Me.lblCtaCargos)
        Me.Panel2.Controls.Add(Me.txtCtaAbono)
        Me.Panel2.Controls.Add(Me.lblCtaA)
        Me.Panel2.Controls.Add(Me.cbTransaccion)
        Me.Panel2.Controls.Add(Me.lblTipoTransaccion)
        Me.Panel2.Controls.Add(Me.cbSucursal)
        Me.Panel2.Controls.Add(Me.lblSucursal)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(559, 153)
        Me.Panel2.TabIndex = 156
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(466, 115)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 181
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'txtDescCtaCargo
        '
        Me.txtDescCtaCargo.Enabled = False
        Me.txtDescCtaCargo.Location = New System.Drawing.Point(213, 89)
        Me.txtDescCtaCargo.Name = "txtDescCtaCargo"
        Me.txtDescCtaCargo.Size = New System.Drawing.Size(328, 20)
        Me.txtDescCtaCargo.TabIndex = 9
        '
        'txtDescCtaAbono
        '
        Me.txtDescCtaAbono.Enabled = False
        Me.txtDescCtaAbono.Location = New System.Drawing.Point(213, 63)
        Me.txtDescCtaAbono.Name = "txtDescCtaAbono"
        Me.txtDescCtaAbono.Size = New System.Drawing.Size(328, 20)
        Me.txtDescCtaAbono.TabIndex = 6
        '
        'txtCtaCargos
        '
        Me.txtCtaCargos.Location = New System.Drawing.Point(127, 89)
        Me.txtCtaCargos.Name = "txtCtaCargos"
        Me.txtCtaCargos.Size = New System.Drawing.Size(80, 20)
        Me.txtCtaCargos.TabIndex = 8
        '
        'lblCtaCargos
        '
        Me.lblCtaCargos.AutoSize = True
        Me.lblCtaCargos.Location = New System.Drawing.Point(13, 92)
        Me.lblCtaCargos.Name = "lblCtaCargos"
        Me.lblCtaCargos.Size = New System.Drawing.Size(80, 13)
        Me.lblCtaCargos.TabIndex = 7
        Me.lblCtaCargos.Text = "Cuenta Cargos:"
        '
        'txtCtaAbono
        '
        Me.txtCtaAbono.Location = New System.Drawing.Point(127, 63)
        Me.txtCtaAbono.Name = "txtCtaAbono"
        Me.txtCtaAbono.Size = New System.Drawing.Size(80, 20)
        Me.txtCtaAbono.TabIndex = 5
        '
        'lblCtaA
        '
        Me.lblCtaA.AutoSize = True
        Me.lblCtaA.Location = New System.Drawing.Point(13, 66)
        Me.lblCtaA.Name = "lblCtaA"
        Me.lblCtaA.Size = New System.Drawing.Size(98, 13)
        Me.lblCtaA.TabIndex = 4
        Me.lblCtaA.Text = "Cuenta de Abonos:"
        '
        'cbTransaccion
        '
        Me.cbTransaccion.FormattingEnabled = True
        Me.cbTransaccion.Location = New System.Drawing.Point(127, 36)
        Me.cbTransaccion.Name = "cbTransaccion"
        Me.cbTransaccion.Size = New System.Drawing.Size(414, 21)
        Me.cbTransaccion.TabIndex = 3
        '
        'lblTipoTransaccion
        '
        Me.lblTipoTransaccion.AutoSize = True
        Me.lblTipoTransaccion.Location = New System.Drawing.Point(13, 39)
        Me.lblTipoTransaccion.Name = "lblTipoTransaccion"
        Me.lblTipoTransaccion.Size = New System.Drawing.Size(105, 13)
        Me.lblTipoTransaccion.TabIndex = 2
        Me.lblTipoTransaccion.Text = "Tipo de Transaccion"
        '
        'cbSucursal
        '
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(127, 9)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(414, 21)
        Me.cbSucursal.TabIndex = 1
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(13, 12)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 0
        Me.lblSucursal.Text = "Sucursal:"
        '
        'frmMsBC_CatTransaccionesSucursalesBov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(599, 239)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(599, 239)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(599, 239)
        Me.Name = "frmMsBC_CatTransaccionesSucursalesBov"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tipos de Movimientos Bóveda"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbTransaccion As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoTransaccion As System.Windows.Forms.Label
    Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents txtCtaCargos As System.Windows.Forms.TextBox
    Friend WithEvents lblCtaCargos As System.Windows.Forms.Label
    Friend WithEvents txtCtaAbono As System.Windows.Forms.TextBox
    Friend WithEvents lblCtaA As System.Windows.Forms.Label
    Friend WithEvents txtDescCtaCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescCtaAbono As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
