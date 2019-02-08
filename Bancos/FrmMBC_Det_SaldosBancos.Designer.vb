<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMBC_Det_SaldosBancos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAgregarMov = New System.Windows.Forms.Button()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.rbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.rbOrigen = New System.Windows.Forms.RadioButton()
        Me.rbMov = New System.Windows.Forms.RadioButton()
        Me.rbBanco = New System.Windows.Forms.RadioButton()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtIdMov = New System.Windows.Forms.TextBox()
        Me.lblIdMov = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.cbOrigen = New System.Windows.Forms.ComboBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(23, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(756, 261)
        Me.DataGridView1.TabIndex = 6
        '
        'btnAgregarMov
        '
        Me.btnAgregarMov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarMov.Location = New System.Drawing.Point(603, 34)
        Me.btnAgregarMov.Name = "btnAgregarMov"
        Me.btnAgregarMov.Size = New System.Drawing.Size(140, 29)
        Me.btnAgregarMov.TabIndex = 0
        Me.btnAgregarMov.Text = "Agregar Movimiento"
        Me.btnAgregarMov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarMov.UseVisualStyleBackColor = True
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.rbMostrarTodos)
        Me.gbFiltros.Controls.Add(Me.rbOrigen)
        Me.gbFiltros.Controls.Add(Me.rbMov)
        Me.gbFiltros.Controls.Add(Me.rbBanco)
        Me.gbFiltros.Controls.Add(Me.rbFecha)
        Me.gbFiltros.Location = New System.Drawing.Point(23, 63)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(386, 43)
        Me.gbFiltros.TabIndex = 8
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros"
        '
        'rbMostrarTodos
        '
        Me.rbMostrarTodos.AutoSize = True
        Me.rbMostrarTodos.Location = New System.Drawing.Point(291, 19)
        Me.rbMostrarTodos.Name = "rbMostrarTodos"
        Me.rbMostrarTodos.Size = New System.Drawing.Size(93, 17)
        Me.rbMostrarTodos.TabIndex = 10
        Me.rbMostrarTodos.TabStop = True
        Me.rbMostrarTodos.Text = "Mostrar Todos"
        Me.rbMostrarTodos.UseVisualStyleBackColor = True
        '
        'rbOrigen
        '
        Me.rbOrigen.AutoSize = True
        Me.rbOrigen.Location = New System.Drawing.Point(229, 19)
        Me.rbOrigen.Name = "rbOrigen"
        Me.rbOrigen.Size = New System.Drawing.Size(56, 17)
        Me.rbOrigen.TabIndex = 9
        Me.rbOrigen.TabStop = True
        Me.rbOrigen.Text = "Origen"
        Me.rbOrigen.UseVisualStyleBackColor = True
        '
        'rbMov
        '
        Me.rbMov.AutoSize = True
        Me.rbMov.Location = New System.Drawing.Point(129, 19)
        Me.rbMov.Name = "rbMov"
        Me.rbMov.Size = New System.Drawing.Size(94, 17)
        Me.rbMov.TabIndex = 8
        Me.rbMov.TabStop = True
        Me.rbMov.Text = "Id. Movimiento"
        Me.rbMov.UseVisualStyleBackColor = True
        '
        'rbBanco
        '
        Me.rbBanco.AutoSize = True
        Me.rbBanco.Location = New System.Drawing.Point(67, 20)
        Me.rbBanco.Name = "rbBanco"
        Me.rbBanco.Size = New System.Drawing.Size(56, 17)
        Me.rbBanco.TabIndex = 7
        Me.rbBanco.TabStop = True
        Me.rbBanco.Text = "Banco"
        Me.rbBanco.UseVisualStyleBackColor = True
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(6, 19)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbFecha.TabIndex = 6
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(3, 11)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(68, 13)
        Me.lblFechaInicio.TabIndex = 0
        Me.lblFechaInicio.Text = "Fecha Inicio:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(77, 8)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtIdMov)
        Me.Panel2.Controls.Add(Me.lblIdMov)
        Me.Panel2.Controls.Add(Me.btnBuscar)
        Me.Panel2.Controls.Add(Me.cbBancos)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblOrigen)
        Me.Panel2.Controls.Add(Me.btnAgregarMov)
        Me.Panel2.Controls.Add(Me.cbOrigen)
        Me.Panel2.Controls.Add(Me.dtpFechaFin)
        Me.Panel2.Controls.Add(Me.lblFechaFin)
        Me.Panel2.Controls.Add(Me.lblFechaInicio)
        Me.Panel2.Controls.Add(Me.dtpFechaInicio)
        Me.Panel2.Location = New System.Drawing.Point(23, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(756, 72)
        Me.Panel2.TabIndex = 9
        '
        'txtIdMov
        '
        Me.txtIdMov.Location = New System.Drawing.Point(618, 8)
        Me.txtIdMov.Name = "txtIdMov"
        Me.txtIdMov.Size = New System.Drawing.Size(125, 20)
        Me.txtIdMov.TabIndex = 10
        '
        'lblIdMov
        '
        Me.lblIdMov.AutoSize = True
        Me.lblIdMov.Location = New System.Drawing.Point(533, 10)
        Me.lblIdMov.Name = "lblIdMov"
        Me.lblIdMov.Size = New System.Drawing.Size(79, 13)
        Me.lblIdMov.TabIndex = 9
        Me.lblIdMov.Text = "Id. Movimiento:"
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(516, 34)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(81, 29)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cbBancos
        '
        Me.cbBancos.FormattingEnabled = True
        Me.cbBancos.Location = New System.Drawing.Point(77, 39)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(433, 21)
        Me.cbBancos.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Banco:"
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Location = New System.Drawing.Point(348, 10)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(38, 13)
        Me.lblOrigen.TabIndex = 5
        Me.lblOrigen.Text = "Origen"
        '
        'cbOrigen
        '
        Me.cbOrigen.FormattingEnabled = True
        Me.cbOrigen.Items.AddRange(New Object() {"Cheque", "Remesa", "Transferencia"})
        Me.cbOrigen.Location = New System.Drawing.Point(392, 7)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(135, 21)
        Me.cbOrigen.TabIndex = 4
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(244, 8)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaFin.TabIndex = 3
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(181, 11)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(57, 13)
        Me.lblFechaFin.TabIndex = 2
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'FrmMBC_Det_SaldosBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(790, 474)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.DataGridView1)
        Me.MinimumSize = New System.Drawing.Size(790, 474)
        Me.Name = "FrmMBC_Det_SaldosBancos"
        Me.Text = "Detalle de Movimientos Saldos Bancos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregarMov As System.Windows.Forms.Button
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents cbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdMov As System.Windows.Forms.TextBox
    Friend WithEvents lblIdMov As System.Windows.Forms.Label
    Friend WithEvents lblOrigen As System.Windows.Forms.Label
    Friend WithEvents rbOrigen As System.Windows.Forms.RadioButton
    Friend WithEvents rbMov As System.Windows.Forms.RadioButton
    Friend WithEvents rbBanco As System.Windows.Forms.RadioButton
    Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbMostrarTodos As System.Windows.Forms.RadioButton
End Class
