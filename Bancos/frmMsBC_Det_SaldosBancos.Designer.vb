<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsBC_Det_SaldosBancos
    Inherits System.Windows.Forms.Form

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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnIngresar = New System.Windows.Forms.Button
        Me.txtRemesa = New System.Windows.Forms.TextBox
        Me.lblRemesa = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.gboxTipoMov = New System.Windows.Forms.GroupBox
        Me.rbCargo = New System.Windows.Forms.RadioButton
        Me.rbAbono = New System.Windows.Forms.RadioButton
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.lblFecha = New System.Windows.Forms.Label
        Me.cbBancos = New System.Windows.Forms.ComboBox
        Me.lblBanco = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.gboxTipoMov.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnIngresar)
        Me.Panel1.Controls.Add(Me.txtRemesa)
        Me.Panel1.Controls.Add(Me.lblRemesa)
        Me.Panel1.Controls.Add(Me.txtMonto)
        Me.Panel1.Controls.Add(Me.lblMonto)
        Me.Panel1.Controls.Add(Me.gboxTipoMov)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.cbBancos)
        Me.Panel1.Controls.Add(Me.lblBanco)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 109)
        Me.Panel1.TabIndex = 0
        '
        'btnIngresar
        '
        Me.btnIngresar.Image = My.Resources.resMain._001_03
        Me.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresar.Location = New System.Drawing.Point(398, 68)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(86, 29)
        Me.btnIngresar.TabIndex = 10
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtRemesa
        '
        Me.txtRemesa.Location = New System.Drawing.Point(207, 72)
        Me.txtRemesa.Name = "txtRemesa"
        Me.txtRemesa.Size = New System.Drawing.Size(142, 20)
        Me.txtRemesa.TabIndex = 9
        '
        'lblRemesa
        '
        Me.lblRemesa.AutoSize = True
        Me.lblRemesa.Location = New System.Drawing.Point(137, 75)
        Me.lblRemesa.Name = "lblRemesa"
        Me.lblRemesa.Size = New System.Drawing.Size(64, 13)
        Me.lblRemesa.TabIndex = 8
        Me.lblRemesa.Text = "N° Remesa:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(355, 42)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(129, 20)
        Me.txtMonto.TabIndex = 7
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(309, 45)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(40, 13)
        Me.lblMonto.TabIndex = 6
        Me.lblMonto.Text = "Monto:"
        '
        'gboxTipoMov
        '
        Me.gboxTipoMov.Controls.Add(Me.rbCargo)
        Me.gboxTipoMov.Controls.Add(Me.rbAbono)
        Me.gboxTipoMov.Location = New System.Drawing.Point(7, 39)
        Me.gboxTipoMov.Name = "gboxTipoMov"
        Me.gboxTipoMov.Size = New System.Drawing.Size(124, 49)
        Me.gboxTipoMov.TabIndex = 4
        Me.gboxTipoMov.TabStop = False
        Me.gboxTipoMov.Text = "Tipo de Movimiento"
        '
        'rbCargo
        '
        Me.rbCargo.AutoSize = True
        Me.rbCargo.Location = New System.Drawing.Point(68, 19)
        Me.rbCargo.Name = "rbCargo"
        Me.rbCargo.Size = New System.Drawing.Size(53, 17)
        Me.rbCargo.TabIndex = 3
        Me.rbCargo.TabStop = True
        Me.rbCargo.Text = "Cargo"
        Me.rbCargo.UseVisualStyleBackColor = True
        '
        'rbAbono
        '
        Me.rbAbono.AutoSize = True
        Me.rbAbono.Location = New System.Drawing.Point(6, 19)
        Me.rbAbono.Name = "rbAbono"
        Me.rbAbono.Size = New System.Drawing.Size(56, 17)
        Me.rbAbono.TabIndex = 2
        Me.rbAbono.TabStop = True
        Me.rbAbono.Text = "Abono"
        Me.rbAbono.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(207, 42)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 5
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(137, 45)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Fecha:"
        '
        'cbBancos
        '
        Me.cbBancos.FormattingEnabled = True
        Me.cbBancos.Location = New System.Drawing.Point(51, 12)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(433, 21)
        Me.cbBancos.TabIndex = 1
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(4, 15)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(41, 13)
        Me.lblBanco.TabIndex = 0
        Me.lblBanco.Text = "Banco:"
        '
        'frmMsBC_Det_SaldosBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 128)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(526, 300)
        Me.Name = "frmMsBC_Det_SaldosBancos"
        Me.Text = "Ingresar Movimiento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gboxTipoMov.ResumeLayout(False)
        Me.gboxTipoMov.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents gboxTipoMov As System.Windows.Forms.GroupBox
    Friend WithEvents rbCargo As System.Windows.Forms.RadioButton
    Friend WithEvents rbAbono As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents txtRemesa As System.Windows.Forms.TextBox
    Friend WithEvents lblRemesa As System.Windows.Forms.Label
End Class
