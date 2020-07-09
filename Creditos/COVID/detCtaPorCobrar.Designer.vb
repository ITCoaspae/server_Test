<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detCtaPorCobrar
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDui = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cbTipoCtaOrigen = New System.Windows.Forms.ComboBox()
        Me.cbCuentas = New System.Windows.Forms.ComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(191, 102)
        Me.txtDui.Mask = "00000000-0"
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(459, 22)
        Me.txtDui.TabIndex = 1
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 104)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(81, 20)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "No. de DUI:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 159)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(129, 20)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Tipo cuenta origén:"
        '
        'cbTipoCtaOrigen
        '
        Me.cbTipoCtaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoCtaOrigen.FormattingEnabled = True
        Me.cbTipoCtaOrigen.Location = New System.Drawing.Point(191, 159)
        Me.cbTipoCtaOrigen.Name = "cbTipoCtaOrigen"
        Me.cbTipoCtaOrigen.Size = New System.Drawing.Size(459, 24)
        Me.cbTipoCtaOrigen.TabIndex = 5
        '
        'cbCuentas
        '
        Me.cbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.Location = New System.Drawing.Point(191, 189)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(459, 24)
        Me.cbCuentas.TabIndex = 7
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 189)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(105, 20)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "No. Cta Origen:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 247)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(52, 20)
        Me.MetroLabel4.TabIndex = 10
        Me.MetroLabel4.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(191, 247)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(459, 22)
        Me.txtMonto.TabIndex = 11
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Location = New System.Drawing.Point(191, 275)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(459, 22)
        Me.txtSaldo.TabIndex = 13
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 277)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(45, 20)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Saldo:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(191, 219)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(459, 22)
        Me.TextBox3.TabIndex = 9
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 219)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(113, 20)
        Me.MetroLabel6.TabIndex = 8
        Me.MetroLabel6.Text = "No. Doc. Origén:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(582, 333)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(68, 21)
        Me.chkActivo.TabIndex = 14
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(550, 361)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(437, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(191, 130)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PromptText = "Nombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(459, 23)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMark = "Nombre"
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 130)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(124, 20)
        Me.MetroLabel7.TabIndex = 2
        Me.MetroLabel7.Text = "Nombre Asociado:"
        '
        'cbSucursal
        '
        Me.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(191, 303)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(459, 24)
        Me.cbSucursal.TabIndex = 16
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(23, 303)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(162, 20)
        Me.MetroLabel8.TabIndex = 17
        Me.MetroLabel8.Text = "Sucursal Cta. por Cobrar:"
        '
        'detCtaPorCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 463)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.cbSucursal)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.cbCuentas)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.cbTipoCtaOrigen)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtDui)
        Me.Name = "detCtaPorCobrar"
        Me.Text = "Detalle Cuentas Por Cobrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDui As MaskedTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbTipoCtaOrigen As ComboBox
    Friend WithEvents cbCuentas As ComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbSucursal As ComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
End Class
