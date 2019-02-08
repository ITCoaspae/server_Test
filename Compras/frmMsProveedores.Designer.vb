<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsProveedores
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

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
        Me.txtDui = New System.Windows.Forms.MaskedTextBox()
        Me.txtNit = New System.Windows.Forms.MaskedTextBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtRepresentante = New System.Windows.Forms.TextBox()
        Me.lblRepresentanteLegal = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.cbMunicipio = New System.Windows.Forms.ComboBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblDui = New System.Windows.Forms.Label()
        Me.lblNit = New System.Windows.Forms.Label()
        Me.txtNoRegistro = New System.Windows.Forms.TextBox()
        Me.lblNoRegistro = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipoContri = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cbTipoContri)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtDui)
        Me.Panel2.Controls.Add(Me.txtNit)
        Me.Panel2.Controls.Add(Me.cbDepartamento)
        Me.Panel2.Controls.Add(Me.txtRepresentante)
        Me.Panel2.Controls.Add(Me.lblRepresentanteLegal)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.lblEmail)
        Me.Panel2.Controls.Add(Me.txtTelefono)
        Me.Panel2.Controls.Add(Me.lblTelefono)
        Me.Panel2.Controls.Add(Me.cbMunicipio)
        Me.Panel2.Controls.Add(Me.lblMunicipio)
        Me.Panel2.Controls.Add(Me.lblDepartamento)
        Me.Panel2.Controls.Add(Me.txtDireccion)
        Me.Panel2.Controls.Add(Me.lblDireccion)
        Me.Panel2.Controls.Add(Me.txtProveedor)
        Me.Panel2.Controls.Add(Me.lblProveedor)
        Me.Panel2.Controls.Add(Me.lblDui)
        Me.Panel2.Controls.Add(Me.lblNit)
        Me.Panel2.Controls.Add(Me.txtNoRegistro)
        Me.Panel2.Controls.Add(Me.lblNoRegistro)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(427, 335)
        Me.Panel2.TabIndex = 161
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.Location = New System.Drawing.Point(78, 35)
        Me.txtDui.Mask = "00000000-0"
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(119, 20)
        Me.txtDui.TabIndex = 5
        '
        'txtNit
        '
        Me.txtNit.BackColor = System.Drawing.Color.White
        Me.txtNit.Location = New System.Drawing.Point(237, 10)
        Me.txtNit.Mask = "0000-000000-000-0"
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(177, 20)
        Me.txtNit.TabIndex = 3
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(78, 117)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(336, 21)
        Me.cbDepartamento.TabIndex = 9
        '
        'txtRepresentante
        '
        Me.txtRepresentante.BackColor = System.Drawing.Color.White
        Me.txtRepresentante.Location = New System.Drawing.Point(78, 253)
        Me.txtRepresentante.Name = "txtRepresentante"
        Me.txtRepresentante.Size = New System.Drawing.Size(336, 20)
        Me.txtRepresentante.TabIndex = 19
        '
        'lblRepresentanteLegal
        '
        Me.lblRepresentanteLegal.AutoSize = True
        Me.lblRepresentanteLegal.Location = New System.Drawing.Point(3, 253)
        Me.lblRepresentanteLegal.Name = "lblRepresentanteLegal"
        Me.lblRepresentanteLegal.Size = New System.Drawing.Size(80, 26)
        Me.lblRepresentanteLegal.TabIndex = 18
        Me.lblRepresentanteLegal.Text = "Representante " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Legal:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(233, 227)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(181, 20)
        Me.txtEmail.TabIndex = 17
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(192, 227)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email:"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.White
        Me.txtTelefono.Location = New System.Drawing.Point(78, 227)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefono.TabIndex = 15
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(3, 227)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 14
        Me.lblTelefono.Text = "Teléfono"
        '
        'cbMunicipio
        '
        Me.cbMunicipio.FormattingEnabled = True
        Me.cbMunicipio.Location = New System.Drawing.Point(78, 144)
        Me.cbMunicipio.Name = "cbMunicipio"
        Me.cbMunicipio.Size = New System.Drawing.Size(336, 21)
        Me.cbMunicipio.TabIndex = 11
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(3, 144)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(55, 13)
        Me.lblMunicipio.TabIndex = 10
        Me.lblMunicipio.Text = "Municipio:"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(3, 117)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.lblDepartamento.TabIndex = 8
        Me.lblDepartamento.Text = "Departamento:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.Location = New System.Drawing.Point(78, 171)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(336, 50)
        Me.txtDireccion.TabIndex = 13
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(3, 171)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 12
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtProveedor
        '
        Me.txtProveedor.BackColor = System.Drawing.Color.White
        Me.txtProveedor.Location = New System.Drawing.Point(78, 61)
        Me.txtProveedor.Multiline = True
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(336, 50)
        Me.txtProveedor.TabIndex = 7
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(3, 61)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(62, 26)
        Me.lblProveedor.TabIndex = 6
        Me.lblProveedor.Text = "Nombre de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveedor:"
        '
        'lblDui
        '
        Me.lblDui.AutoSize = True
        Me.lblDui.Location = New System.Drawing.Point(3, 35)
        Me.lblDui.Name = "lblDui"
        Me.lblDui.Size = New System.Drawing.Size(29, 13)
        Me.lblDui.TabIndex = 4
        Me.lblDui.Text = "DUI:"
        '
        'lblNit
        '
        Me.lblNit.AutoSize = True
        Me.lblNit.Location = New System.Drawing.Point(203, 13)
        Me.lblNit.Name = "lblNit"
        Me.lblNit.Size = New System.Drawing.Size(28, 13)
        Me.lblNit.TabIndex = 2
        Me.lblNit.Text = "NIT:"
        '
        'txtNoRegistro
        '
        Me.txtNoRegistro.BackColor = System.Drawing.Color.White
        Me.txtNoRegistro.Location = New System.Drawing.Point(78, 10)
        Me.txtNoRegistro.Name = "txtNoRegistro"
        Me.txtNoRegistro.Size = New System.Drawing.Size(119, 20)
        Me.txtNoRegistro.TabIndex = 1
        '
        'lblNoRegistro
        '
        Me.lblNoRegistro.AutoSize = True
        Me.lblNoRegistro.Location = New System.Drawing.Point(3, 13)
        Me.lblNoRegistro.Name = "lblNoRegistro"
        Me.lblNoRegistro.Size = New System.Drawing.Size(69, 13)
        Me.lblNoRegistro.TabIndex = 0
        Me.lblNoRegistro.Text = "No. Registro:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(380, 404)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(70, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 182
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Tipo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contribuyente:"
        '
        'cbTipoContri
        '
        Me.cbTipoContri.FormattingEnabled = True
        Me.cbTipoContri.Location = New System.Drawing.Point(78, 297)
        Me.cbTipoContri.Name = "cbTipoContri"
        Me.cbTipoContri.Size = New System.Drawing.Size(336, 21)
        Me.cbTipoContri.TabIndex = 21
        '
        'frmMsProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(468, 456)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 384)
        Me.Name = "frmMsProveedores"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Proveedores"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblNit As System.Windows.Forms.Label
    Friend WithEvents txtNoRegistro As System.Windows.Forms.TextBox
    Friend WithEvents lblNoRegistro As System.Windows.Forms.Label
    Friend WithEvents lblDui As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents cbMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents lblMunicipio As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents txtRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents lblRepresentanteLegal As System.Windows.Forms.Label
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents txtNit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDui As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTipoContri As ComboBox
End Class
