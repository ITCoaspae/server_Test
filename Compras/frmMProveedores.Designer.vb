<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMProveedores
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
        Me.dgProveedores = New System.Windows.Forms.DataGridView()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.txtNit = New System.Windows.Forms.MaskedTextBox()
        Me.rbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.rbNit = New System.Windows.Forms.RadioButton()
        Me.btnBuscar1 = New MetroFramework.Controls.MetroButton()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.txtNoRegistro = New System.Windows.Forms.TextBox()
        Me.rbNoRegistro = New System.Windows.Forms.RadioButton()
        Me.rbProveedor = New System.Windows.Forms.RadioButton()
        Me.btnAnular1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnMod1 = New MetroFramework.Controls.MetroButton()
        Me.btnAdd1 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgProveedores
        '
        Me.dgProveedores.AllowUserToAddRows = False
        Me.dgProveedores.AllowUserToDeleteRows = False
        Me.dgProveedores.AllowUserToOrderColumns = True
        Me.dgProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProveedores.Location = New System.Drawing.Point(23, 186)
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.ReadOnly = True
        Me.dgProveedores.Size = New System.Drawing.Size(666, 173)
        Me.dgProveedores.TabIndex = 0
        '
        'gbFiltros
        '
        Me.gbFiltros.BackColor = System.Drawing.Color.White
        Me.gbFiltros.Controls.Add(Me.txtNit)
        Me.gbFiltros.Controls.Add(Me.rbMostrarTodos)
        Me.gbFiltros.Controls.Add(Me.rbNit)
        Me.gbFiltros.Controls.Add(Me.btnBuscar1)
        Me.gbFiltros.Controls.Add(Me.txtProveedor)
        Me.gbFiltros.Controls.Add(Me.txtNoRegistro)
        Me.gbFiltros.Controls.Add(Me.rbNoRegistro)
        Me.gbFiltros.Controls.Add(Me.rbProveedor)
        Me.gbFiltros.Location = New System.Drawing.Point(23, 63)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(551, 83)
        Me.gbFiltros.TabIndex = 160
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(297, 53)
        Me.txtNit.Mask = "0000-000000-000-0"
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(139, 20)
        Me.txtNit.TabIndex = 161
        '
        'rbMostrarTodos
        '
        Me.rbMostrarTodos.AutoSize = True
        Me.rbMostrarTodos.Location = New System.Drawing.Point(442, 18)
        Me.rbMostrarTodos.Name = "rbMostrarTodos"
        Me.rbMostrarTodos.Size = New System.Drawing.Size(93, 17)
        Me.rbMostrarTodos.TabIndex = 7
        Me.rbMostrarTodos.TabStop = True
        Me.rbMostrarTodos.Text = "Mostrar Todos"
        Me.rbMostrarTodos.UseVisualStyleBackColor = True
        '
        'rbNit
        '
        Me.rbNit.AutoSize = True
        Me.rbNit.Location = New System.Drawing.Point(248, 52)
        Me.rbNit.Name = "rbNit"
        Me.rbNit.Size = New System.Drawing.Size(43, 17)
        Me.rbNit.TabIndex = 5
        Me.rbNit.TabStop = True
        Me.rbNit.Text = "NIT"
        Me.rbNit.UseVisualStyleBackColor = True
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(442, 45)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(70, 28)
        Me.btnBuscar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar1.TabIndex = 178
        Me.btnBuscar1.Text = "Buscar"
        Me.btnBuscar1.UseSelectable = True
        Me.btnBuscar1.UseStyleColors = True
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(86, 18)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(350, 20)
        Me.txtProveedor.TabIndex = 2
        '
        'txtNoRegistro
        '
        Me.txtNoRegistro.Location = New System.Drawing.Point(87, 53)
        Me.txtNoRegistro.Name = "txtNoRegistro"
        Me.txtNoRegistro.Size = New System.Drawing.Size(155, 20)
        Me.txtNoRegistro.TabIndex = 4
        '
        'rbNoRegistro
        '
        Me.rbNoRegistro.AutoSize = True
        Me.rbNoRegistro.Location = New System.Drawing.Point(7, 54)
        Me.rbNoRegistro.Name = "rbNoRegistro"
        Me.rbNoRegistro.Size = New System.Drawing.Size(78, 17)
        Me.rbNoRegistro.TabIndex = 3
        Me.rbNoRegistro.TabStop = True
        Me.rbNoRegistro.Text = "NoRegistro"
        Me.rbNoRegistro.UseVisualStyleBackColor = True
        '
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.Location = New System.Drawing.Point(6, 19)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(74, 17)
        Me.rbProveedor.TabIndex = 0
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'btnAnular1
        '
        Me.btnAnular1.Location = New System.Drawing.Point(251, 152)
        Me.btnAnular1.Name = "btnAnular1"
        Me.btnAnular1.Size = New System.Drawing.Size(70, 28)
        Me.btnAnular1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAnular1.TabIndex = 177
        Me.btnAnular1.Text = "Eliminar"
        Me.btnAnular1.UseSelectable = True
        Me.btnAnular1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(175, 152)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(70, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 176
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnMod1
        '
        Me.btnMod1.Location = New System.Drawing.Point(99, 152)
        Me.btnMod1.Name = "btnMod1"
        Me.btnMod1.Size = New System.Drawing.Size(70, 28)
        Me.btnMod1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod1.TabIndex = 175
        Me.btnMod1.Text = "Modificar"
        Me.btnMod1.UseSelectable = True
        Me.btnMod1.UseStyleColors = True
        '
        'btnAdd1
        '
        Me.btnAdd1.Location = New System.Drawing.Point(23, 152)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(70, 28)
        Me.btnAdd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd1.TabIndex = 174
        Me.btnAdd1.Text = "Agregar"
        Me.btnAdd1.UseSelectable = True
        Me.btnAdd1.UseStyleColors = True
        '
        'frmMProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(712, 382)
        Me.Controls.Add(Me.btnAnular1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnMod1)
        Me.Controls.Add(Me.btnAdd1)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.dgProveedores)
        Me.Name = "frmMProveedores"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Proveedores"
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents rbProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtNoRegistro As System.Windows.Forms.TextBox
    Friend WithEvents rbNoRegistro As System.Windows.Forms.RadioButton
    Friend WithEvents rbMostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbNit As System.Windows.Forms.RadioButton
    Friend WithEvents txtNit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAnular1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBuscar1 As MetroFramework.Controls.MetroButton
End Class
