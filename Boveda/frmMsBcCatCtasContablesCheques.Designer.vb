<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsBcCatCtasContablesCheques
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsBcCatCtasContablesCheques))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblEncabezado = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.ldlDescripcion = New System.Windows.Forms.Label
        Me.txtDescCtaContable = New System.Windows.Forms.TextBox
        Me.txtCodCtaContable = New System.Windows.Forms.TextBox
        Me.lblCtaContable = New System.Windows.Forms.Label
        Me.cbRoles = New System.Windows.Forms.ComboBox
        Me.lblRol = New System.Windows.Forms.Label
        Me.cbSucursales = New System.Windows.Forms.ComboBox
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblEncabezado)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 33)
        Me.Panel1.TabIndex = 164
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.Color.White
        Me.lblEncabezado.Location = New System.Drawing.Point(5, 5)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(546, 24)
        Me.lblEncabezado.TabIndex = 0
        Me.lblEncabezado.Text = "Catalogo de Cuentas Contables para emisión de cheques"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.ldlDescripcion)
        Me.Panel2.Controls.Add(Me.txtDescCtaContable)
        Me.Panel2.Controls.Add(Me.txtCodCtaContable)
        Me.Panel2.Controls.Add(Me.lblCtaContable)
        Me.Panel2.Controls.Add(Me.cbRoles)
        Me.Panel2.Controls.Add(Me.lblRol)
        Me.Panel2.Controls.Add(Me.cbSucursales)
        Me.Panel2.Controls.Add(Me.lblSucursal)
        Me.Panel2.Location = New System.Drawing.Point(12, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 155)
        Me.Panel2.TabIndex = 165
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(95, 89)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(445, 47)
        Me.txtDescripcion.TabIndex = 8
        '
        'ldlDescripcion
        '
        Me.ldlDescripcion.AutoSize = True
        Me.ldlDescripcion.Location = New System.Drawing.Point(3, 95)
        Me.ldlDescripcion.Name = "ldlDescripcion"
        Me.ldlDescripcion.Size = New System.Drawing.Size(81, 26)
        Me.ldlDescripcion.TabIndex = 7
        Me.ldlDescripcion.Text = "Descripción de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cuenta:"
        '
        'txtDescCtaContable
        '
        Me.txtDescCtaContable.Enabled = False
        Me.txtDescCtaContable.Location = New System.Drawing.Point(226, 63)
        Me.txtDescCtaContable.Name = "txtDescCtaContable"
        Me.txtDescCtaContable.Size = New System.Drawing.Size(314, 20)
        Me.txtDescCtaContable.TabIndex = 6
        '
        'txtCodCtaContable
        '
        Me.txtCodCtaContable.Location = New System.Drawing.Point(95, 63)
        Me.txtCodCtaContable.Name = "txtCodCtaContable"
        Me.txtCodCtaContable.Size = New System.Drawing.Size(125, 20)
        Me.txtCodCtaContable.TabIndex = 5
        '
        'lblCtaContable
        '
        Me.lblCtaContable.AutoSize = True
        Me.lblCtaContable.Location = New System.Drawing.Point(3, 66)
        Me.lblCtaContable.Name = "lblCtaContable"
        Me.lblCtaContable.Size = New System.Drawing.Size(86, 13)
        Me.lblCtaContable.TabIndex = 4
        Me.lblCtaContable.Text = "Cuenta Contable"
        '
        'cbRoles
        '
        Me.cbRoles.FormattingEnabled = True
        Me.cbRoles.Location = New System.Drawing.Point(95, 36)
        Me.cbRoles.Name = "cbRoles"
        Me.cbRoles.Size = New System.Drawing.Size(445, 21)
        Me.cbRoles.TabIndex = 3
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(3, 42)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(26, 13)
        Me.lblRol.TabIndex = 2
        Me.lblRol.Text = "Rol:"
        '
        'cbSucursales
        '
        Me.cbSucursales.FormattingEnabled = True
        Me.cbSucursales.Location = New System.Drawing.Point(95, 9)
        Me.cbSucursales.Name = "cbSucursales"
        Me.cbSucursales.Size = New System.Drawing.Size(445, 21)
        Me.cbSucursales.TabIndex = 1
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(3, 12)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 0
        Me.lblSucursal.Text = "Sucursal:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(12, 199)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(82, 28)
        Me.btnGuardar.TabIndex = 166
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmMsBcCatCtasContablesCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(578, 231)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
         
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsBcCatCtasContablesCheques"
        Me.ShowIcon = False
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtCodCtaContable As System.Windows.Forms.TextBox
    Friend WithEvents lblCtaContable As System.Windows.Forms.Label
    Friend WithEvents cbRoles As System.Windows.Forms.ComboBox
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents cbSucursales As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ldlDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtDescCtaContable As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
