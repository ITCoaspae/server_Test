<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCaTipoMovCaja
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
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.rbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.rbTransacciones = New System.Windows.Forms.RadioButton()
        Me.cbTransacciones = New System.Windows.Forms.ComboBox()
        Me.dgCatTipoMovCaja = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgCatTipoMovCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFiltros
        '
        Me.gbFiltros.BackColor = System.Drawing.Color.White
        Me.gbFiltros.Controls.Add(Me.btnBuscar)
        Me.gbFiltros.Controls.Add(Me.rbMostrarTodos)
        Me.gbFiltros.Controls.Add(Me.rbTransacciones)
        Me.gbFiltros.Controls.Add(Me.cbTransacciones)
        Me.gbFiltros.Location = New System.Drawing.Point(23, 63)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(526, 83)
        Me.gbFiltros.TabIndex = 164
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(434, 42)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 28)
        Me.btnBuscar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar.TabIndex = 163
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnBuscar.UseSelectable = True
        Me.btnBuscar.UseStyleColors = True
        '
        'rbMostrarTodos
        '
        Me.rbMostrarTodos.AutoSize = True
        Me.rbMostrarTodos.Location = New System.Drawing.Point(16, 42)
        Me.rbMostrarTodos.Name = "rbMostrarTodos"
        Me.rbMostrarTodos.Size = New System.Drawing.Size(96, 17)
        Me.rbMostrarTodos.TabIndex = 9
        Me.rbMostrarTodos.Text = "Mostrar Todos:"
        Me.rbMostrarTodos.UseVisualStyleBackColor = True
        '
        'rbTransacciones
        '
        Me.rbTransacciones.AutoSize = True
        Me.rbTransacciones.Checked = True
        Me.rbTransacciones.Location = New System.Drawing.Point(16, 19)
        Me.rbTransacciones.Name = "rbTransacciones"
        Me.rbTransacciones.Size = New System.Drawing.Size(127, 17)
        Me.rbTransacciones.TabIndex = 6
        Me.rbTransacciones.TabStop = True
        Me.rbTransacciones.Text = "Transacción Boveda:"
        Me.rbTransacciones.UseVisualStyleBackColor = True
        '
        'cbTransacciones
        '
        Me.cbTransacciones.BackColor = System.Drawing.Color.White
        Me.cbTransacciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTransacciones.FormattingEnabled = True
        Me.cbTransacciones.Location = New System.Drawing.Point(146, 15)
        Me.cbTransacciones.Name = "cbTransacciones"
        Me.cbTransacciones.Size = New System.Drawing.Size(363, 21)
        Me.cbTransacciones.TabIndex = 5
        '
        'dgCatTipoMovCaja
        '
        Me.dgCatTipoMovCaja.AllowUserToAddRows = False
        Me.dgCatTipoMovCaja.AllowUserToDeleteRows = False
        Me.dgCatTipoMovCaja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCatTipoMovCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCatTipoMovCaja.Location = New System.Drawing.Point(23, 186)
        Me.dgCatTipoMovCaja.Name = "dgCatTipoMovCaja"
        Me.dgCatTipoMovCaja.ReadOnly = True
        Me.dgCatTipoMovCaja.Size = New System.Drawing.Size(522, 115)
        Me.dgCatTipoMovCaja.TabIndex = 165
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(23, 152)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar.TabIndex = 164
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar.UseSelectable = True
        Me.btnAgregar.UseStyleColors = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(104, 152)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 28)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar.TabIndex = 165
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar.UseSelectable = True
        Me.btnModificar.UseStyleColors = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(185, 152)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar.TabIndex = 166
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar.UseSelectable = True
        Me.btnEliminar.UseStyleColors = True
        '
        'frmMCaTipoMovCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 351)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgCatTipoMovCaja)
        Me.Controls.Add(Me.gbFiltros)
        Me.Name = "frmMCaTipoMovCaja"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Catalogo Tipo de Movimientos Caja"
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.dgCatTipoMovCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents rbMostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbTransacciones As System.Windows.Forms.RadioButton
    Friend WithEvents cbTransacciones As System.Windows.Forms.ComboBox
    Friend WithEvents dgCatTipoMovCaja As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
End Class
