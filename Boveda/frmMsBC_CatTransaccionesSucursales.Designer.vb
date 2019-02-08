<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsBC_CatTransaccionesSucursales
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
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.btnBuscar1 = New MetroFramework.Controls.MetroButton()
        Me.rbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.rbTipoTransaccion = New System.Windows.Forms.RadioButton()
        Me.rbSucursal = New System.Windows.Forms.RadioButton()
        Me.cbTransacciones = New System.Windows.Forms.ComboBox()
        Me.cbSucursales = New System.Windows.Forms.ComboBox()
        Me.dgTranSucursales = New System.Windows.Forms.DataGridView()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgTranSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFiltros
        '
        Me.gbFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltros.BackColor = System.Drawing.Color.White
        Me.gbFiltros.Controls.Add(Me.btnBuscar1)
        Me.gbFiltros.Controls.Add(Me.rbMostrarTodos)
        Me.gbFiltros.Controls.Add(Me.rbTipoTransaccion)
        Me.gbFiltros.Controls.Add(Me.rbSucursal)
        Me.gbFiltros.Controls.Add(Me.cbTransacciones)
        Me.gbFiltros.Controls.Add(Me.cbSucursales)
        Me.gbFiltros.Location = New System.Drawing.Point(31, 78)
        Me.gbFiltros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbFiltros.Size = New System.Drawing.Size(693, 132)
        Me.gbFiltros.TabIndex = 0
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros"
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(565, 86)
        Me.btnBuscar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(100, 34)
        Me.btnBuscar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar1.TabIndex = 180
        Me.btnBuscar1.Text = "Buscar"
        Me.btnBuscar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnBuscar1.UseSelectable = True
        Me.btnBuscar1.UseStyleColors = True
        '
        'rbMostrarTodos
        '
        Me.rbMostrarTodos.AutoSize = True
        Me.rbMostrarTodos.Location = New System.Drawing.Point(8, 82)
        Me.rbMostrarTodos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbMostrarTodos.Name = "rbMostrarTodos"
        Me.rbMostrarTodos.Size = New System.Drawing.Size(125, 21)
        Me.rbMostrarTodos.TabIndex = 6
        Me.rbMostrarTodos.Text = "Mostrar Todos:"
        Me.rbMostrarTodos.UseVisualStyleBackColor = True
        '
        'rbTipoTransaccion
        '
        Me.rbTipoTransaccion.AutoSize = True
        Me.rbTipoTransaccion.Location = New System.Drawing.Point(8, 54)
        Me.rbTipoTransaccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbTipoTransaccion.Name = "rbTipoTransaccion"
        Me.rbTipoTransaccion.Size = New System.Drawing.Size(159, 21)
        Me.rbTipoTransaccion.TabIndex = 5
        Me.rbTipoTransaccion.Text = "Tipo de Transacción"
        Me.rbTipoTransaccion.UseVisualStyleBackColor = True
        '
        'rbSucursal
        '
        Me.rbSucursal.AutoSize = True
        Me.rbSucursal.Checked = True
        Me.rbSucursal.Location = New System.Drawing.Point(8, 25)
        Me.rbSucursal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbSucursal.Name = "rbSucursal"
        Me.rbSucursal.Size = New System.Drawing.Size(88, 21)
        Me.rbSucursal.TabIndex = 4
        Me.rbSucursal.TabStop = True
        Me.rbSucursal.Text = "Sucursal:"
        Me.rbSucursal.UseVisualStyleBackColor = True
        '
        'cbTransacciones
        '
        Me.cbTransacciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTransacciones.FormattingEnabled = True
        Me.cbTransacciones.Location = New System.Drawing.Point(180, 53)
        Me.cbTransacciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTransacciones.Name = "cbTransacciones"
        Me.cbTransacciones.Size = New System.Drawing.Size(484, 24)
        Me.cbTransacciones.TabIndex = 3
        '
        'cbSucursales
        '
        Me.cbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursales.FormattingEnabled = True
        Me.cbSucursales.Location = New System.Drawing.Point(180, 20)
        Me.cbSucursales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbSucursales.Name = "cbSucursales"
        Me.cbSucursales.Size = New System.Drawing.Size(484, 24)
        Me.cbSucursales.TabIndex = 1
        '
        'dgTranSucursales
        '
        Me.dgTranSucursales.AllowUserToAddRows = False
        Me.dgTranSucursales.AllowUserToDeleteRows = False
        Me.dgTranSucursales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTranSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTranSucursales.Location = New System.Drawing.Point(31, 258)
        Me.dgTranSucursales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgTranSucursales.Name = "dgTranSucursales"
        Me.dgTranSucursales.ReadOnly = True
        Me.dgTranSucursales.Size = New System.Drawing.Size(853, 209)
        Me.dgTranSucursales.TabIndex = 2
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(247, 217)
        Me.btnConsultar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(100, 34)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 183
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(355, 217)
        Me.btnEliminar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(100, 34)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 182
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(139, 217)
        Me.btnModificar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(100, 34)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 181
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(31, 217)
        Me.btnAgregar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(100, 34)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 180
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMsBC_CatTransaccionesSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(915, 528)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.dgTranSucursales)
        Me.Controls.Add(Me.gbFiltros)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(915, 528)
        Me.Name = "frmMsBC_CatTransaccionesSucursales"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Movimientos de Boveda por Sucursal"
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.dgTranSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents rbMostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbTipoTransaccion As System.Windows.Forms.RadioButton
    Friend WithEvents rbSucursal As System.Windows.Forms.RadioButton
    Friend WithEvents cbTransacciones As System.Windows.Forms.ComboBox
    Friend WithEvents cbSucursales As System.Windows.Forms.ComboBox
    Friend WithEvents dgTranSucursales As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
End Class
