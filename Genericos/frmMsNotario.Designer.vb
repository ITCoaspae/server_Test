<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsNotario
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
        Me.cbTIPO = New System.Windows.Forms.ComboBox()
        Me.txtCEL = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.txtDespacho = New System.Windows.Forms.TextBox()
        Me.lblDespacho = New System.Windows.Forms.Label()
        Me.lblTIPO = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtDirecOficina = New System.Windows.Forms.TextBox()
        Me.lblDirecOficina = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'cbTIPO
        '
        Me.cbTIPO.BackColor = System.Drawing.Color.White
        Me.cbTIPO.FormattingEnabled = True
        Me.cbTIPO.Items.AddRange(New Object() {"Externo", "Interno"})
        Me.cbTIPO.Location = New System.Drawing.Point(138, 209)
        Me.cbTIPO.Name = "cbTIPO"
        Me.cbTIPO.Size = New System.Drawing.Size(390, 21)
        Me.cbTIPO.TabIndex = 15
        '
        'txtCEL
        '
        Me.txtCEL.BackColor = System.Drawing.Color.White
        Me.txtCEL.Location = New System.Drawing.Point(384, 160)
        Me.txtCEL.Mask = "0000-0000"
        Me.txtCEL.Name = "txtCEL"
        Me.txtCEL.Size = New System.Drawing.Size(144, 20)
        Me.txtCEL.TabIndex = 11
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.White
        Me.txtTelefono.Location = New System.Drawing.Point(138, 157)
        Me.txtTelefono.Mask = "0000-0000"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(144, 20)
        Me.txtTelefono.TabIndex = 9
        '
        'txtDespacho
        '
        Me.txtDespacho.BackColor = System.Drawing.Color.White
        Me.txtDespacho.Location = New System.Drawing.Point(138, 236)
        Me.txtDespacho.Multiline = True
        Me.txtDespacho.Name = "txtDespacho"
        Me.txtDespacho.Size = New System.Drawing.Size(390, 50)
        Me.txtDespacho.TabIndex = 17
        '
        'lblDespacho
        '
        Me.lblDespacho.AutoSize = True
        Me.lblDespacho.Location = New System.Drawing.Point(23, 239)
        Me.lblDespacho.Name = "lblDespacho"
        Me.lblDespacho.Size = New System.Drawing.Size(56, 13)
        Me.lblDespacho.TabIndex = 16
        Me.lblDespacho.Text = "Despacho"
        '
        'lblTIPO
        '
        Me.lblTIPO.AutoSize = True
        Me.lblTIPO.Location = New System.Drawing.Point(23, 212)
        Me.lblTIPO.Name = "lblTIPO"
        Me.lblTIPO.Size = New System.Drawing.Size(28, 13)
        Me.lblTIPO.TabIndex = 14
        Me.lblTIPO.Text = "Tipo"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(138, 183)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(390, 20)
        Me.txtEmail.TabIndex = 13
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(23, 186)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.BackColor = System.Drawing.Color.White
        Me.lblCelular.Location = New System.Drawing.Point(288, 160)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 10
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(23, 160)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 8
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtDirecOficina
        '
        Me.txtDirecOficina.BackColor = System.Drawing.Color.White
        Me.txtDirecOficina.Location = New System.Drawing.Point(138, 109)
        Me.txtDirecOficina.Multiline = True
        Me.txtDirecOficina.Name = "txtDirecOficina"
        Me.txtDirecOficina.Size = New System.Drawing.Size(390, 42)
        Me.txtDirecOficina.TabIndex = 7
        '
        'lblDirecOficina
        '
        Me.lblDirecOficina.AutoSize = True
        Me.lblDirecOficina.Location = New System.Drawing.Point(23, 112)
        Me.lblDirecOficina.Name = "lblDirecOficina"
        Me.lblDirecOficina.Size = New System.Drawing.Size(103, 13)
        Me.lblDirecOficina.TabIndex = 6
        Me.lblDirecOficina.Text = "Dirección de Oficina"
        '
        'txtApellido2
        '
        Me.txtApellido2.BackColor = System.Drawing.Color.White
        Me.txtApellido2.Location = New System.Drawing.Point(384, 83)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(144, 20)
        Me.txtApellido2.TabIndex = 5
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.BackColor = System.Drawing.Color.White
        Me.lblApellido2.Location = New System.Drawing.Point(288, 86)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(90, 13)
        Me.lblApellido2.TabIndex = 4
        Me.lblApellido2.Text = "Segundo Apellido"
        '
        'txtApellido1
        '
        Me.txtApellido1.BackColor = System.Drawing.Color.White
        Me.txtApellido1.Location = New System.Drawing.Point(138, 83)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(144, 20)
        Me.txtApellido1.TabIndex = 3
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(23, 86)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(76, 13)
        Me.lblApellido1.TabIndex = 2
        Me.lblApellido1.Text = "Primer Apellido"
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Location = New System.Drawing.Point(138, 57)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(390, 20)
        Me.txtNombres.TabIndex = 1
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(23, 60)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(49, 13)
        Me.lblNombres.TabIndex = 0
        Me.lblNombres.Text = "Nombres"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(453, 292)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 169
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsNotario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(554, 358)
        Me.Controls.Add(Me.txtDespacho)
        Me.Controls.Add(Me.lblDespacho)
        Me.Controls.Add(Me.cbTIPO)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.lblTIPO)
        Me.Controls.Add(Me.txtCEL)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblNombres)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.txtDirecOficina)
        Me.Controls.Add(Me.lblDirecOficina)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsNotario"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Notario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents lblNombres As System.Windows.Forms.Label
    Friend WithEvents lblTIPO As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtDirecOficina As System.Windows.Forms.TextBox
    Friend WithEvents lblDirecOficina As System.Windows.Forms.Label
    Friend WithEvents txtDespacho As System.Windows.Forms.TextBox
    Friend WithEvents lblDespacho As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCEL As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbTIPO As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
