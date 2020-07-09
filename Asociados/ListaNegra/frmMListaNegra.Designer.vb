<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMListaNegra
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnEliminar2 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.dgListaNegra1 = New MetroFramework.Controls.MetroGrid()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtInstitucion = New System.Windows.Forms.TextBox()
        Me.rbReportado = New System.Windows.Forms.RadioButton()
        Me.rbInstitucion = New System.Windows.Forms.RadioButton()
        Me.rbOficio = New System.Windows.Forms.RadioButton()
        Me.txtOficio = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        CType(Me.dgListaNegra1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar2
        '
        Me.btnEliminar2.Location = New System.Drawing.Point(246, 157)
        Me.btnEliminar2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar2.Name = "btnEliminar2"
        Me.btnEliminar2.Size = New System.Drawing.Size(100, 34)
        Me.btnEliminar2.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar2.TabIndex = 6
        Me.btnEliminar2.Text = "Desactivar"
        Me.btnEliminar2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar2.UseSelectable = True
        Me.btnEliminar2.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(138, 157)
        Me.btnModificar1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(100, 34)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 5
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(30, 157)
        Me.btnAgregar1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(100, 34)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 4
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'dgListaNegra1
        '
        Me.dgListaNegra1.AllowUserToAddRows = False
        Me.dgListaNegra1.AllowUserToDeleteRows = False
        Me.dgListaNegra1.AllowUserToResizeRows = False
        Me.dgListaNegra1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgListaNegra1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgListaNegra1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgListaNegra1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgListaNegra1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgListaNegra1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgListaNegra1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgListaNegra1.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgListaNegra1.EnableHeadersVisualStyles = False
        Me.dgListaNegra1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgListaNegra1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgListaNegra1.Location = New System.Drawing.Point(29, 211)
        Me.dgListaNegra1.Margin = New System.Windows.Forms.Padding(4)
        Me.dgListaNegra1.Name = "dgListaNegra1"
        Me.dgListaNegra1.ReadOnly = True
        Me.dgListaNegra1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgListaNegra1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgListaNegra1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgListaNegra1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaNegra1.Size = New System.Drawing.Size(707, 158)
        Me.dgListaNegra1.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgListaNegra1.TabIndex = 162
        Me.dgListaNegra1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(200, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(541, 22)
        Me.txtNombre.TabIndex = 164
        '
        'txtInstitucion
        '
        Me.txtInstitucion.Location = New System.Drawing.Point(200, 101)
        Me.txtInstitucion.Name = "txtInstitucion"
        Me.txtInstitucion.Size = New System.Drawing.Size(541, 22)
        Me.txtInstitucion.TabIndex = 166
        '
        'rbReportado
        '
        Me.rbReportado.AutoSize = True
        Me.rbReportado.Location = New System.Drawing.Point(30, 74)
        Me.rbReportado.Name = "rbReportado"
        Me.rbReportado.Size = New System.Drawing.Size(150, 21)
        Me.rbReportado.TabIndex = 167
        Me.rbReportado.TabStop = True
        Me.rbReportado.Text = "Nombre Reportado"
        Me.rbReportado.UseVisualStyleBackColor = True
        '
        'rbInstitucion
        '
        Me.rbInstitucion.AutoSize = True
        Me.rbInstitucion.Location = New System.Drawing.Point(30, 102)
        Me.rbInstitucion.Name = "rbInstitucion"
        Me.rbInstitucion.Size = New System.Drawing.Size(147, 21)
        Me.rbInstitucion.TabIndex = 168
        Me.rbInstitucion.TabStop = True
        Me.rbInstitucion.Text = "Institución Reporta"
        Me.rbInstitucion.UseVisualStyleBackColor = True
        '
        'rbOficio
        '
        Me.rbOficio.AutoSize = True
        Me.rbOficio.Location = New System.Drawing.Point(30, 129)
        Me.rbOficio.Name = "rbOficio"
        Me.rbOficio.Size = New System.Drawing.Size(164, 21)
        Me.rbOficio.TabIndex = 169
        Me.rbOficio.TabStop = True
        Me.rbOficio.Text = "No. Oficio/Referencia"
        Me.rbOficio.UseVisualStyleBackColor = True
        '
        'txtOficio
        '
        Me.txtOficio.Location = New System.Drawing.Point(200, 129)
        Me.txtOficio.Name = "txtOficio"
        Me.txtOficio.Size = New System.Drawing.Size(307, 22)
        Me.txtOficio.TabIndex = 170
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(641, 129)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 34)
        Me.btnBuscar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar.TabIndex = 171
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnBuscar.UseSelectable = True
        Me.btnBuscar.UseStyleColors = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(513, 130)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(121, 21)
        Me.rbTodos.TabIndex = 172
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Mostrar Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'frmMListaNegra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(767, 411)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtOficio)
        Me.Controls.Add(Me.rbOficio)
        Me.Controls.Add(Me.rbInstitucion)
        Me.Controls.Add(Me.rbReportado)
        Me.Controls.Add(Me.txtInstitucion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnEliminar2)
        Me.Controls.Add(Me.dgListaNegra1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMListaNegra"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Lista Negra Interna"
        CType(Me.dgListaNegra1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dgListaNegra1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents rbReportado As RadioButton
    Friend WithEvents rbInstitucion As RadioButton
    Friend WithEvents rbOficio As RadioButton
    Friend WithEvents txtOficio As TextBox
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtInstitucion As TextBox
    Friend WithEvents rbTodos As RadioButton
End Class
