<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRutasMercadeo
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
        Me.gbFiltros = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSucursales = New System.Windows.Forms.Label
        Me.chkMostrarTodos = New System.Windows.Forms.CheckBox
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFin = New System.Windows.Forms.Label
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.cbEjecutivo = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.cbSucursal = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblEncabezado = New System.Windows.Forms.Label
        Me.dgRutas = New System.Windows.Forms.DataGridView
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.gbFiltros.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgRutas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbFiltros
        '
        Me.gbFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltros.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.gbFiltros.Controls.Add(Me.Label1)
        Me.gbFiltros.Controls.Add(Me.lblSucursales)
        Me.gbFiltros.Controls.Add(Me.chkMostrarTodos)
        Me.gbFiltros.Controls.Add(Me.dtpFechaFin)
        Me.gbFiltros.Controls.Add(Me.lblFechaFin)
        Me.gbFiltros.Controls.Add(Me.dtpFechaIni)
        Me.gbFiltros.Controls.Add(Me.lblFechaInicio)
        Me.gbFiltros.Controls.Add(Me.cbEjecutivo)
        Me.gbFiltros.Controls.Add(Me.btnBuscar)
        Me.gbFiltros.Controls.Add(Me.cbSucursal)
        Me.gbFiltros.Location = New System.Drawing.Point(12, 37)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(559, 96)
        Me.gbFiltros.TabIndex = 166
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Asesor:"
        '
        'lblSucursales
        '
        Me.lblSucursales.AutoSize = True
        Me.lblSucursales.Location = New System.Drawing.Point(6, 16)
        Me.lblSucursales.Name = "lblSucursales"
        Me.lblSucursales.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursales.TabIndex = 23
        Me.lblSucursales.Text = "Sucursal:"
        '
        'chkMostrarTodos
        '
        Me.chkMostrarTodos.AutoSize = True
        Me.chkMostrarTodos.Enabled = False
        Me.chkMostrarTodos.Location = New System.Drawing.Point(456, 20)
        Me.chkMostrarTodos.Name = "chkMostrarTodos"
        Me.chkMostrarTodos.Size = New System.Drawing.Size(94, 17)
        Me.chkMostrarTodos.TabIndex = 22
        Me.chkMostrarTodos.Text = "Mostrar Todos"
        Me.chkMostrarTodos.UseVisualStyleBackColor = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(248, 70)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaFin.TabIndex = 16
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(185, 74)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(57, 13)
        Me.lblFechaFin.TabIndex = 15
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(80, 70)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaIni.TabIndex = 14
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(6, 74)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(68, 13)
        Me.lblFechaInicio.TabIndex = 13
        Me.lblFechaInicio.Text = "Fecha Inicio:"
        '
        'cbEjecutivo
        '
        Me.cbEjecutivo.BackColor = System.Drawing.Color.Khaki
        Me.cbEjecutivo.Enabled = False
        Me.cbEjecutivo.FormattingEnabled = True
        Me.cbEjecutivo.Location = New System.Drawing.Point(57, 43)
        Me.cbEjecutivo.Name = "cbEjecutivo"
        Me.cbEjecutivo.Size = New System.Drawing.Size(393, 21)
        Me.cbEjecutivo.TabIndex = 11
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.SysFinCoop.resMain.search
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(468, 59)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(82, 28)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cbSucursal
        '
        Me.cbSucursal.BackColor = System.Drawing.Color.Khaki
        Me.cbSucursal.Enabled = False
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(57, 16)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(393, 21)
        Me.cbSucursal.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblEncabezado)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 33)
        Me.Panel1.TabIndex = 167
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.Color.White
        Me.lblEncabezado.Location = New System.Drawing.Point(3, 6)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(165, 24)
        Me.lblEncabezado.TabIndex = 0
        Me.lblEncabezado.Text = "Control de Rutas"
        '
        'dgRutas
        '
        Me.dgRutas.AllowUserToAddRows = False
        Me.dgRutas.AllowUserToDeleteRows = False
        Me.dgRutas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRutas.Location = New System.Drawing.Point(12, 139)
        Me.dgRutas.Name = "dgRutas"
        Me.dgRutas.ReadOnly = True
        Me.dgRutas.Size = New System.Drawing.Size(559, 216)
        Me.dgRutas.TabIndex = 168
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnAgregar)
        Me.Panel3.Controls.Add(Me.btnModificar)
        Me.Panel3.Location = New System.Drawing.Point(7, 361)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(564, 36)
        Me.Panel3.TabIndex = 169
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = Global.SysFinCoop.resMain.add
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(107, 28)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar Ruta"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = Global.SysFinCoop.resMain._001_45
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(116, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(149, 28)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Agregar Nueva Visita"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'frmMRutasMercadeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(583, 409)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgRutas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbFiltros)
        Me.Name = "frmMRutasMercadeo"
        Me.ShowIcon = False
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgRutas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents cbEjecutivo As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents dgRutas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSucursales As System.Windows.Forms.Label
    Friend WithEvents chkMostrarTodos As System.Windows.Forms.CheckBox
End Class
