<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsAhMovimientosFlotantes
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblEncabezado = New System.Windows.Forms.Label
        Me.gbBusqueda = New System.Windows.Forms.GroupBox
        Me.gbFiltrarPor = New System.Windows.Forms.GroupBox
        Me.chkMostrarTodos = New System.Windows.Forms.CheckBox
        Me.chkNoCta = New System.Windows.Forms.CheckBox
        Me.chkSucursal = New System.Windows.Forms.CheckBox
        Me.chkFecha = New System.Windows.Forms.CheckBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtNoCta = New System.Windows.Forms.TextBox
        Me.lblNoCuenta = New System.Windows.Forms.Label
        Me.cbSucursal = New System.Windows.Forms.ComboBox
        Me.lblCodSucursal = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.lblFecha = New System.Windows.Forms.Label
        Me.dgMovimientosFlotantes = New System.Windows.Forms.DataGridView
        Me.Panel2.SuspendLayout()
        Me.gbBusqueda.SuspendLayout()
        Me.gbFiltrarPor.SuspendLayout()
        CType(Me.dgMovimientosFlotantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblEncabezado)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(742, 33)
        Me.Panel2.TabIndex = 158
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.Color.White
        Me.lblEncabezado.Location = New System.Drawing.Point(5, 5)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(218, 24)
        Me.lblEncabezado.TabIndex = 0
        Me.lblEncabezado.Text = "Movimientos Flotantes"
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.gbBusqueda.Controls.Add(Me.gbFiltrarPor)
        Me.gbBusqueda.Controls.Add(Me.btnBuscar)
        Me.gbBusqueda.Controls.Add(Me.txtNoCta)
        Me.gbBusqueda.Controls.Add(Me.lblNoCuenta)
        Me.gbBusqueda.Controls.Add(Me.cbSucursal)
        Me.gbBusqueda.Controls.Add(Me.lblCodSucursal)
        Me.gbBusqueda.Controls.Add(Me.dtpFecha)
        Me.gbBusqueda.Controls.Add(Me.lblFecha)
        Me.gbBusqueda.Location = New System.Drawing.Point(12, 38)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(712, 131)
        Me.gbBusqueda.TabIndex = 159
        Me.gbBusqueda.TabStop = False
        Me.gbBusqueda.Text = "Buscar:"
        '
        'gbFiltrarPor
        '
        Me.gbFiltrarPor.Controls.Add(Me.chkMostrarTodos)
        Me.gbFiltrarPor.Controls.Add(Me.chkNoCta)
        Me.gbFiltrarPor.Controls.Add(Me.chkSucursal)
        Me.gbFiltrarPor.Controls.Add(Me.chkFecha)
        Me.gbFiltrarPor.Location = New System.Drawing.Point(6, 19)
        Me.gbFiltrarPor.Name = "gbFiltrarPor"
        Me.gbFiltrarPor.Size = New System.Drawing.Size(700, 43)
        Me.gbFiltrarPor.TabIndex = 7
        Me.gbFiltrarPor.TabStop = False
        Me.gbFiltrarPor.Text = "Filtrar por:"
        '
        'chkMostrarTodos
        '
        Me.chkMostrarTodos.AutoSize = True
        Me.chkMostrarTodos.Location = New System.Drawing.Point(239, 19)
        Me.chkMostrarTodos.Name = "chkMostrarTodos"
        Me.chkMostrarTodos.Size = New System.Drawing.Size(94, 17)
        Me.chkMostrarTodos.TabIndex = 3
        Me.chkMostrarTodos.Text = "Mostrar Todos"
        Me.chkMostrarTodos.UseVisualStyleBackColor = True
        '
        'chkNoCta
        '
        Me.chkNoCta.AutoSize = True
        Me.chkNoCta.Location = New System.Drawing.Point(150, 19)
        Me.chkNoCta.Name = "chkNoCta"
        Me.chkNoCta.Size = New System.Drawing.Size(83, 17)
        Me.chkNoCta.TabIndex = 2
        Me.chkNoCta.Text = "No. Cuenta:"
        Me.chkNoCta.UseVisualStyleBackColor = True
        '
        'chkSucursal
        '
        Me.chkSucursal.AutoSize = True
        Me.chkSucursal.Location = New System.Drawing.Point(74, 19)
        Me.chkSucursal.Name = "chkSucursal"
        Me.chkSucursal.Size = New System.Drawing.Size(70, 17)
        Me.chkSucursal.TabIndex = 1
        Me.chkSucursal.Text = "Sucursal:"
        Me.chkSucursal.UseVisualStyleBackColor = True
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(9, 19)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(59, 17)
        Me.chkFecha.TabIndex = 0
        Me.chkFecha.Text = "Fecha:"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(6, 94)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 28)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtNoCta
        '
        Me.txtNoCta.BackColor = System.Drawing.Color.Khaki
        Me.txtNoCta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCta.Enabled = False
        Me.txtNoCta.Location = New System.Drawing.Point(532, 67)
        Me.txtNoCta.Name = "txtNoCta"
        Me.txtNoCta.Size = New System.Drawing.Size(174, 20)
        Me.txtNoCta.TabIndex = 5
        '
        'lblNoCuenta
        '
        Me.lblNoCuenta.AutoSize = True
        Me.lblNoCuenta.Location = New System.Drawing.Point(462, 69)
        Me.lblNoCuenta.Name = "lblNoCuenta"
        Me.lblNoCuenta.Size = New System.Drawing.Size(64, 13)
        Me.lblNoCuenta.TabIndex = 4
        Me.lblNoCuenta.Text = "No. Cuenta:"
        '
        'cbSucursal
        '
        Me.cbSucursal.BackColor = System.Drawing.Color.Khaki
        Me.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursal.Enabled = False
        Me.cbSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(215, 68)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(240, 21)
        Me.cbSucursal.TabIndex = 3
        '
        'lblCodSucursal
        '
        Me.lblCodSucursal.AutoSize = True
        Me.lblCodSucursal.Location = New System.Drawing.Point(158, 69)
        Me.lblCodSucursal.Name = "lblCodSucursal"
        Me.lblCodSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblCodSucursal.TabIndex = 2
        Me.lblCodSucursal.Text = "Sucursal:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(49, 68)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(101, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(3, 68)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha:"
        '
        'dgMovimientosFlotantes
        '
        Me.dgMovimientosFlotantes.AllowUserToAddRows = False
        Me.dgMovimientosFlotantes.AllowUserToDeleteRows = False
        Me.dgMovimientosFlotantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMovimientosFlotantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMovimientosFlotantes.Location = New System.Drawing.Point(8, 175)
        Me.dgMovimientosFlotantes.Name = "dgMovimientosFlotantes"
        Me.dgMovimientosFlotantes.ReadOnly = True
        Me.dgMovimientosFlotantes.Size = New System.Drawing.Size(716, 207)
        Me.dgMovimientosFlotantes.TabIndex = 160
        '
        'frmMsAhMovimientosFlotantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(736, 394)
        Me.Controls.Add(Me.dgMovimientosFlotantes)
        Me.Controls.Add(Me.gbBusqueda)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmMsAhMovimientosFlotantes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        Me.gbFiltrarPor.ResumeLayout(False)
        Me.gbFiltrarPor.PerformLayout()
        CType(Me.dgMovimientosFlotantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblCodSucursal As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtNoCta As System.Windows.Forms.TextBox
    Friend WithEvents lblNoCuenta As System.Windows.Forms.Label
    Friend WithEvents dgMovimientosFlotantes As System.Windows.Forms.DataGridView
    Friend WithEvents gbFiltrarPor As System.Windows.Forms.GroupBox
    Friend WithEvents chkSucursal As System.Windows.Forms.CheckBox
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoCta As System.Windows.Forms.CheckBox
    Friend WithEvents chkMostrarTodos As System.Windows.Forms.CheckBox
End Class
