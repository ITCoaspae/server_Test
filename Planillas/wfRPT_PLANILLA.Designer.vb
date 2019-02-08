<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfRPT_PLANILLA
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
        Me.crPLANGENERAL = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lblCODPLANILLA = New System.Windows.Forms.Label()
        Me.lblTIPOPLANILLA = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbAreas = New System.Windows.Forms.RadioButton()
        Me.rbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbAreas = New System.Windows.Forms.ComboBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtCodPlanilla = New System.Windows.Forms.TextBox()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblPlanilla = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtTipoPlanilla = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'crPLANGENERAL
        '
        Me.crPLANGENERAL.ActiveViewIndex = -1
        Me.crPLANGENERAL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crPLANGENERAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crPLANGENERAL.Cursor = System.Windows.Forms.Cursors.Default
        Me.crPLANGENERAL.Location = New System.Drawing.Point(16, 252)
        Me.crPLANGENERAL.Name = "crPLANGENERAL"
        Me.crPLANGENERAL.SelectionFormula = ""
        Me.crPLANGENERAL.Size = New System.Drawing.Size(602, 231)
        Me.crPLANGENERAL.TabIndex = 0
        Me.crPLANGENERAL.ViewTimeSelectionFormula = ""
        '
        'lblCODPLANILLA
        '
        Me.lblCODPLANILLA.AutoSize = True
        Me.lblCODPLANILLA.Location = New System.Drawing.Point(390, 47)
        Me.lblCODPLANILLA.Name = "lblCODPLANILLA"
        Me.lblCODPLANILLA.Size = New System.Drawing.Size(39, 13)
        Me.lblCODPLANILLA.TabIndex = 1
        Me.lblCODPLANILLA.Text = "Label1"
        Me.lblCODPLANILLA.Visible = False
        '
        'lblTIPOPLANILLA
        '
        Me.lblTIPOPLANILLA.AutoSize = True
        Me.lblTIPOPLANILLA.Location = New System.Drawing.Point(321, 47)
        Me.lblTIPOPLANILLA.Name = "lblTIPOPLANILLA"
        Me.lblTIPOPLANILLA.Size = New System.Drawing.Size(39, 13)
        Me.lblTIPOPLANILLA.TabIndex = 2
        Me.lblTIPOPLANILLA.Text = "Label1"
        Me.lblTIPOPLANILLA.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtTipoPlanilla)
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbAreas)
        Me.Panel1.Controls.Add(Me.rbMostrarTodos)
        Me.Panel1.Controls.Add(Me.cbDepartamento)
        Me.Panel1.Controls.Add(Me.cbAreas)
        Me.Panel1.Controls.Add(Me.lblDepartamento)
        Me.Panel1.Controls.Add(Me.lblArea)
        Me.Panel1.Controls.Add(Me.dtpFechaFin)
        Me.Panel1.Controls.Add(Me.dtpFechaInicio)
        Me.Panel1.Controls.Add(Me.txtCodPlanilla)
        Me.Panel1.Controls.Add(Me.lblFechaFin)
        Me.Panel1.Controls.Add(Me.lblFechaInicio)
        Me.Panel1.Controls.Add(Me.lblPlanilla)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(504, 149)
        Me.Panel1.TabIndex = 3
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(225, 41)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(161, 18)
        Me.rbDepartamento.TabIndex = 14
        Me.rbDepartamento.TabStop = True
        Me.rbDepartamento.Text = "Filtrar por Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbAreas
        '
        Me.rbAreas.AutoSize = True
        Me.rbAreas.Location = New System.Drawing.Point(114, 41)
        Me.rbAreas.Name = "rbAreas"
        Me.rbAreas.Size = New System.Drawing.Size(106, 18)
        Me.rbAreas.TabIndex = 13
        Me.rbAreas.TabStop = True
        Me.rbAreas.Text = "Filtrar Por Area"
        Me.rbAreas.UseVisualStyleBackColor = True
        '
        'rbMostrarTodos
        '
        Me.rbMostrarTodos.AutoSize = True
        Me.rbMostrarTodos.Location = New System.Drawing.Point(6, 41)
        Me.rbMostrarTodos.Name = "rbMostrarTodos"
        Me.rbMostrarTodos.Size = New System.Drawing.Size(102, 18)
        Me.rbMostrarTodos.TabIndex = 12
        Me.rbMostrarTodos.TabStop = True
        Me.rbMostrarTodos.Text = "Mostrar Todos"
        Me.rbMostrarTodos.UseVisualStyleBackColor = True
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(98, 116)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(393, 22)
        Me.cbDepartamento.TabIndex = 10
        '
        'cbAreas
        '
        Me.cbAreas.FormattingEnabled = True
        Me.cbAreas.Location = New System.Drawing.Point(98, 65)
        Me.cbAreas.Name = "cbAreas"
        Me.cbAreas.Size = New System.Drawing.Size(393, 22)
        Me.cbAreas.TabIndex = 9
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(3, 110)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(89, 28)
        Me.lblDepartamento.TabIndex = 8
        Me.lblDepartamento.Text = "Seleccione el " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Departamento:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(3, 65)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(83, 28)
        Me.lblArea.TabIndex = 7
        Me.lblArea.Text = "Seleccione el " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Area:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(392, 7)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(99, 22)
        Me.dtpFechaFin.TabIndex = 6
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(219, 7)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(99, 22)
        Me.dtpFechaInicio.TabIndex = 5
        '
        'txtCodPlanilla
        '
        Me.txtCodPlanilla.Location = New System.Drawing.Point(88, 7)
        Me.txtCodPlanilla.Name = "txtCodPlanilla"
        Me.txtCodPlanilla.Size = New System.Drawing.Size(43, 22)
        Me.txtCodPlanilla.TabIndex = 4
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(324, 10)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(62, 14)
        Me.lblFechaFin.TabIndex = 3
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(137, 10)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(76, 14)
        Me.lblFechaInicio.TabIndex = 2
        Me.lblFechaInicio.Text = "Fecha Inicio:"
        '
        'lblPlanilla
        '
        Me.lblPlanilla.AutoSize = True
        Me.lblPlanilla.Location = New System.Drawing.Point(3, 10)
        Me.lblPlanilla.Name = "lblPlanilla"
        Me.lblPlanilla.Size = New System.Drawing.Size(79, 14)
        Me.lblPlanilla.TabIndex = 0
        Me.lblPlanilla.Text = "Cod. Planilla:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(452, 218)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 67
        Me.MetroButton1.Text = "Generar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtTipoPlanilla
        '
        Me.txtTipoPlanilla.Location = New System.Drawing.Point(448, 35)
        Me.txtTipoPlanilla.Name = "txtTipoPlanilla"
        Me.txtTipoPlanilla.Size = New System.Drawing.Size(43, 22)
        Me.txtTipoPlanilla.TabIndex = 15
        Me.txtTipoPlanilla.Visible = False
        '
        'wfRPT_PLANILLA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(630, 495)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.crPLANGENERAL)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTIPOPLANILLA)
        Me.Controls.Add(Me.lblCODPLANILLA)
        Me.Name = "wfRPT_PLANILLA"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consultar Planilla"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crPLANGENERAL As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblCODPLANILLA As System.Windows.Forms.Label
    Friend WithEvents lblTIPOPLANILLA As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblPlanilla As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents cbAreas As System.Windows.Forms.ComboBox
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents rbDepartamento As System.Windows.Forms.RadioButton
    Friend WithEvents rbAreas As System.Windows.Forms.RadioButton
    Friend WithEvents rbMostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtTipoPlanilla As TextBox
End Class
