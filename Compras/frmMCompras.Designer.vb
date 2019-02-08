<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCompras
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
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.chkSucursal = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.rbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.dgCompras = New System.Windows.Forms.DataGridView()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnMod1 = New MetroFramework.Controls.MetroButton()
        Me.btnAdd1 = New MetroFramework.Controls.MetroButton()
        Me.btnAnular1 = New MetroFramework.Controls.MetroButton()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFiltros
        '
        Me.gbFiltros.BackColor = System.Drawing.Color.White
        Me.gbFiltros.Controls.Add(Me.btnBuscar1)
        Me.gbFiltros.Controls.Add(Me.lblFechaFin)
        Me.gbFiltros.Controls.Add(Me.lblFechaInicio)
        Me.gbFiltros.Controls.Add(Me.DateTimePicker2)
        Me.gbFiltros.Controls.Add(Me.cbSucursal)
        Me.gbFiltros.Controls.Add(Me.chkSucursal)
        Me.gbFiltros.Controls.Add(Me.DateTimePicker1)
        Me.gbFiltros.Controls.Add(Me.chkFecha)
        Me.gbFiltros.Controls.Add(Me.rbMostrarTodos)
        Me.gbFiltros.Location = New System.Drawing.Point(23, 63)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(544, 83)
        Me.gbFiltros.TabIndex = 164
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros"
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(409, 42)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(70, 28)
        Me.btnBuscar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar1.TabIndex = 173
        Me.btnBuscar1.Text = "Buscar"
        Me.btnBuscar1.UseSelectable = True
        Me.btnBuscar1.UseStyleColors = True
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(245, 20)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(57, 13)
        Me.lblFechaFin.TabIndex = 8
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(69, 20)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(68, 13)
        Me.lblFechaInicio.TabIndex = 7
        Me.lblFechaInicio.Text = "Fecha Inicio:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(308, 16)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker2.TabIndex = 6
        '
        'cbSucursal
        '
        Me.cbSucursal.BackColor = System.Drawing.Color.White
        Me.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(82, 42)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(305, 21)
        Me.cbSucursal.TabIndex = 3
        '
        'chkSucursal
        '
        Me.chkSucursal.AutoSize = True
        Me.chkSucursal.Location = New System.Drawing.Point(6, 46)
        Me.chkSucursal.Name = "chkSucursal"
        Me.chkSucursal.Size = New System.Drawing.Size(70, 17)
        Me.chkSucursal.TabIndex = 2
        Me.chkSucursal.Text = "Sucursal:"
        Me.chkSucursal.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(143, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(6, 19)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(59, 17)
        Me.chkFecha.TabIndex = 0
        Me.chkFecha.Text = "Fecha:"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'rbMostrarTodos
        '
        Me.rbMostrarTodos.AutoSize = True
        Me.rbMostrarTodos.Location = New System.Drawing.Point(409, 16)
        Me.rbMostrarTodos.Name = "rbMostrarTodos"
        Me.rbMostrarTodos.Size = New System.Drawing.Size(93, 17)
        Me.rbMostrarTodos.TabIndex = 4
        Me.rbMostrarTodos.TabStop = True
        Me.rbMostrarTodos.Text = "Mostrar Todos"
        Me.rbMostrarTodos.UseVisualStyleBackColor = True
        '
        'dgCompras
        '
        Me.dgCompras.AllowUserToAddRows = False
        Me.dgCompras.AllowUserToDeleteRows = False
        Me.dgCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCompras.Location = New System.Drawing.Point(23, 186)
        Me.dgCompras.Name = "dgCompras"
        Me.dgCompras.ReadOnly = True
        Me.dgCompras.Size = New System.Drawing.Size(547, 155)
        Me.dgCompras.TabIndex = 161
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(175, 152)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(70, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 171
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
        Me.btnMod1.TabIndex = 170
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
        Me.btnAdd1.TabIndex = 169
        Me.btnAdd1.Text = "Agregar"
        Me.btnAdd1.UseSelectable = True
        Me.btnAdd1.UseStyleColors = True
        '
        'btnAnular1
        '
        Me.btnAnular1.Location = New System.Drawing.Point(251, 152)
        Me.btnAnular1.Name = "btnAnular1"
        Me.btnAnular1.Size = New System.Drawing.Size(70, 28)
        Me.btnAnular1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAnular1.TabIndex = 172
        Me.btnAnular1.Text = "Anular"
        Me.btnAnular1.UseSelectable = True
        Me.btnAnular1.UseStyleColors = True
        '
        'frmMCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(593, 372)
        Me.Controls.Add(Me.dgCompras)
        Me.Controls.Add(Me.btnAnular1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnMod1)
        Me.Controls.Add(Me.btnAdd1)
        Me.Controls.Add(Me.gbFiltros)
        Me.Name = "frmMCompras"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Compras"
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.dgCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents rbMostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents dgCompras As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents chkSucursal As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAnular1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBuscar1 As MetroFramework.Controls.MetroButton
End Class
