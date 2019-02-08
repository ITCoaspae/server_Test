<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPLBoletaPago
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
        Me.rbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.rbArea = New System.Windows.Forms.RadioButton()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.cbAreas = New System.Windows.Forms.ComboBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.cbEmpleados = New System.Windows.Forms.ComboBox()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbMostrarTodos
        '
        Me.rbMostrarTodos.AutoSize = True
        Me.rbMostrarTodos.ForeColor = System.Drawing.Color.Black
        Me.rbMostrarTodos.Location = New System.Drawing.Point(6, 19)
        Me.rbMostrarTodos.Name = "rbMostrarTodos"
        Me.rbMostrarTodos.Size = New System.Drawing.Size(93, 17)
        Me.rbMostrarTodos.TabIndex = 0
        Me.rbMostrarTodos.TabStop = True
        Me.rbMostrarTodos.Text = "Mostrar Todos"
        Me.rbMostrarTodos.UseVisualStyleBackColor = True
        '
        'rbArea
        '
        Me.rbArea.AutoSize = True
        Me.rbArea.ForeColor = System.Drawing.Color.Black
        Me.rbArea.Location = New System.Drawing.Point(105, 19)
        Me.rbArea.Name = "rbArea"
        Me.rbArea.Size = New System.Drawing.Size(47, 17)
        Me.rbArea.TabIndex = 1
        Me.rbArea.TabStop = True
        Me.rbArea.Text = "Area"
        Me.rbArea.UseVisualStyleBackColor = True
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.ForeColor = System.Drawing.Color.Black
        Me.rbDepartamento.Location = New System.Drawing.Point(158, 19)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(92, 17)
        Me.rbDepartamento.TabIndex = 2
        Me.rbDepartamento.TabStop = True
        Me.rbDepartamento.Text = "Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbEmpleado)
        Me.GroupBox1.Controls.Add(Me.rbArea)
        Me.GroupBox1.Controls.Add(Me.rbDepartamento)
        Me.GroupBox1.Controls.Add(Me.rbMostrarTodos)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(26, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 44)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'rbEmpleado
        '
        Me.rbEmpleado.AutoSize = True
        Me.rbEmpleado.ForeColor = System.Drawing.Color.Black
        Me.rbEmpleado.Location = New System.Drawing.Point(256, 19)
        Me.rbEmpleado.Name = "rbEmpleado"
        Me.rbEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.rbEmpleado.TabIndex = 3
        Me.rbEmpleado.TabStop = True
        Me.rbEmpleado.Text = "Empleado"
        Me.rbEmpleado.UseVisualStyleBackColor = True
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(28, 137)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(29, 13)
        Me.lblArea.TabIndex = 4
        Me.lblArea.Text = "Area"
        '
        'cbAreas
        '
        Me.cbAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAreas.FormattingEnabled = True
        Me.cbAreas.Location = New System.Drawing.Point(108, 137)
        Me.cbAreas.Name = "cbAreas"
        Me.cbAreas.Size = New System.Drawing.Size(376, 21)
        Me.cbAreas.TabIndex = 5
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(108, 164)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(376, 21)
        Me.cbDepartamento.TabIndex = 7
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(28, 164)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento.TabIndex = 6
        Me.lblDepartamento.Text = "Departamento"
        '
        'cbEmpleados
        '
        Me.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpleados.FormattingEnabled = True
        Me.cbEmpleados.Location = New System.Drawing.Point(108, 191)
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.Size = New System.Drawing.Size(376, 21)
        Me.cbEmpleados.TabIndex = 9
        '
        'lblEmpleados
        '
        Me.lblEmpleados.AutoSize = True
        Me.lblEmpleados.Location = New System.Drawing.Point(28, 191)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(59, 13)
        Me.lblEmpleados.TabIndex = 8
        Me.lblEmpleados.Text = "Empleados"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(23, 60)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaInicio.TabIndex = 10
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(94, 60)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(262, 60)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker2.TabIndex = 13
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(202, 60)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(54, 13)
        Me.lblFechaFin.TabIndex = 12
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(409, 218)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 67
        Me.MetroButton1.Text = "Generar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMPLBoletaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(505, 296)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.cbEmpleados)
        Me.Controls.Add(Me.lblEmpleados)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.cbAreas)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMPLBoletaPago"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Boletas de Pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbMostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbArea As System.Windows.Forms.RadioButton
    Friend WithEvents rbDepartamento As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbEmpleado As System.Windows.Forms.RadioButton
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents cbAreas As System.Windows.Forms.ComboBox
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents cbEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpleados As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
