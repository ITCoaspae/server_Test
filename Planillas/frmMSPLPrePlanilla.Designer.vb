<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMSPLPrePlanilla
    Inherits MetroFramework.Forms.MetroForm

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
        Me.chMostrarTodos = New System.Windows.Forms.CheckBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipoPlanilla = New System.Windows.Forms.ComboBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.dgPlanillas = New System.Windows.Forms.DataGridView()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.lbTotales = New System.Windows.Forms.Label()
        CType(Me.dgPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chMostrarTodos
        '
        Me.chMostrarTodos.AutoSize = True
        Me.chMostrarTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chMostrarTodos.Location = New System.Drawing.Point(461, 56)
        Me.chMostrarTodos.Name = "chMostrarTodos"
        Me.chMostrarTodos.Size = New System.Drawing.Size(94, 17)
        Me.chMostrarTodos.TabIndex = 4
        Me.chMostrarTodos.Text = "Mostrar Todos"
        Me.chMostrarTodos.UseVisualStyleBackColor = True
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DisplayMember = "DESCRIPCION"
        Me.cbDepartamento.Enabled = False
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(139, 141)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(416, 22)
        Me.cbDepartamento.TabIndex = 10
        Me.cbDepartamento.ValueMember = "CODDEPARTAMENTO"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento.Location = New System.Drawing.Point(23, 144)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.lblDepartamento.TabIndex = 9
        Me.lblDepartamento.Text = "Departamento:"
        '
        'cbArea
        '
        Me.cbArea.DisplayMember = "DESCRIPCION"
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Location = New System.Drawing.Point(139, 113)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(416, 22)
        Me.cbArea.TabIndex = 8
        Me.cbArea.ValueMember = "CODTIPOPLANILLA"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(23, 116)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(32, 13)
        Me.lblArea.TabIndex = 7
        Me.lblArea.Text = "Área:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo de Planilla: "
        '
        'cbTipoPlanilla
        '
        Me.cbTipoPlanilla.DisplayMember = "DESCRIPCION"
        Me.cbTipoPlanilla.FormattingEnabled = True
        Me.cbTipoPlanilla.Location = New System.Drawing.Point(139, 85)
        Me.cbTipoPlanilla.Name = "cbTipoPlanilla"
        Me.cbTipoPlanilla.Size = New System.Drawing.Size(416, 22)
        Me.cbTipoPlanilla.TabIndex = 6
        Me.cbTipoPlanilla.ValueMember = "CODTIPOPLANILLA"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(306, 57)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(96, 22)
        Me.dtpFechaFin.TabIndex = 3
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(139, 57)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(96, 22)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.Location = New System.Drawing.Point(241, 60)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(54, 13)
        Me.lblFechaFin.TabIndex = 2
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicio.Location = New System.Drawing.Point(23, 60)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaInicio.TabIndex = 0
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'dgPlanillas
        '
        Me.dgPlanillas.AllowUserToAddRows = False
        Me.dgPlanillas.AllowUserToDeleteRows = False
        Me.dgPlanillas.AllowUserToOrderColumns = True
        Me.dgPlanillas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPlanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPlanillas.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgPlanillas.GridColor = System.Drawing.Color.Black
        Me.dgPlanillas.Location = New System.Drawing.Point(26, 209)
        Me.dgPlanillas.Name = "dgPlanillas"
        Me.dgPlanillas.ReadOnly = True
        Me.dgPlanillas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgPlanillas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgPlanillas.Size = New System.Drawing.Size(531, 115)
        Me.dgPlanillas.TabIndex = 1
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(26, 175)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 139
        Me.btnGuardar1.Text = "&Generar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(107, 175)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 140
        Me.MetroButton1.Text = "&Exportar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(188, 175)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 141
        Me.MetroButton2.Text = "&Guardar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'lbTotales
        '
        Me.lbTotales.AutoSize = True
        Me.lbTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotales.Location = New System.Drawing.Point(20, 353)
        Me.lbTotales.Name = "lbTotales"
        Me.lbTotales.Size = New System.Drawing.Size(0, 16)
        Me.lbTotales.TabIndex = 142
        '
        'frmMSPLPrePlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(580, 389)
        Me.Controls.Add(Me.lbTotales)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.chMostrarTodos)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.cbArea)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.cbTipoPlanilla)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgPlanillas)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "frmMSPLPrePlanilla"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Planilla"
        CType(Me.dgPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dgPlanillas As System.Windows.Forms.DataGridView
    Friend WithEvents cbTipoPlanilla As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents cbArea As System.Windows.Forms.ComboBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents chMostrarTodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents lbTotales As Label
End Class
