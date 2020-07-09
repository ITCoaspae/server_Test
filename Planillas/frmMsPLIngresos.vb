Public Class frmMsPLIngresos
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Private oPlan As New wrPlanilla.wsLibPlanilla
    Friend WithEvents cbTipoPlanilla As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoPLanilla As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cbAreas As System.Windows.Forms.ComboBox
    Friend WithEvents lblAreas As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDepartamento As System.Windows.Forms.RadioButton
    Friend WithEvents rbAreas As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents dgEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cbFORMAPAGO As ComboBox
    Public pCorrelativo As String
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents c1NoCuotas As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCodTipoIngreso As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoIngreso As System.Windows.Forms.TextBox
    Friend WithEvents c1Monto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFechaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumPlaza As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents cbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbFORMAPAGO = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.cbTipoPlanilla = New System.Windows.Forms.ComboBox()
        Me.lblTipoPLanilla = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbPeriodo = New System.Windows.Forms.ComboBox()
        Me.chkCancelado = New System.Windows.Forms.CheckBox()
        Me.txtNumPlaza = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtFechaF = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.c1NoCuotas = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodTipoIngreso = New System.Windows.Forms.TextBox()
        Me.txtTipoIngreso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreEmp = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c1Monto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.cbAreas = New System.Windows.Forms.ComboBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.rbAreas = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.lblAreas = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1NoCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Monto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbFORMAPAGO)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.cbTipoPlanilla)
        Me.GroupBox1.Controls.Add(Me.lblTipoPLanilla)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbPeriodo)
        Me.GroupBox1.Controls.Add(Me.chkCancelado)
        Me.GroupBox1.Controls.Add(Me.txtNumPlaza)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtFechaF)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.c1NoCuotas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoIngreso)
        Me.GroupBox1.Controls.Add(Me.txtTipoIngreso)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombreEmp)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtCodEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.c1Monto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cbFORMAPAGO
        '
        Me.cbFORMAPAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFORMAPAGO.Items.AddRange(New Object() {"", "Primera Quincena", "Segunda Quincena", "Ambas"})
        Me.cbFORMAPAGO.Location = New System.Drawing.Point(121, 212)
        Me.cbFORMAPAGO.Name = "cbFORMAPAGO"
        Me.cbFORMAPAGO.Size = New System.Drawing.Size(247, 21)
        Me.cbFORMAPAGO.TabIndex = 107
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Forma de Pago: "
        '
        'chkTodos
        '
        Me.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodos.ForeColor = System.Drawing.Color.Black
        Me.chkTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodos.Location = New System.Drawing.Point(400, 169)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(80, 33)
        Me.chkTodos.TabIndex = 105
        Me.chkTodos.Text = "&Todos los Empleados"
        '
        'cbTipoPlanilla
        '
        Me.cbTipoPlanilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPlanilla.Items.AddRange(New Object() {"1a. quincena", "2a. quincena"})
        Me.cbTipoPlanilla.Location = New System.Drawing.Point(121, 146)
        Me.cbTipoPlanilla.Name = "cbTipoPlanilla"
        Me.cbTipoPlanilla.Size = New System.Drawing.Size(329, 21)
        Me.cbTipoPlanilla.TabIndex = 104
        '
        'lblTipoPLanilla
        '
        Me.lblTipoPLanilla.AutoSize = True
        Me.lblTipoPLanilla.Location = New System.Drawing.Point(8, 149)
        Me.lblTipoPLanilla.Name = "lblTipoPLanilla"
        Me.lblTipoPLanilla.Size = New System.Drawing.Size(82, 13)
        Me.lblTipoPLanilla.TabIndex = 103
        Me.lblTipoPLanilla.Text = "Tipo de Planilla:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 28)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Período inicio del descuento:"
        Me.Label7.Visible = False
        '
        'cbPeriodo
        '
        Me.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeriodo.Items.AddRange(New Object() {"1a. quincena", "2a. quincena"})
        Me.cbPeriodo.Location = New System.Drawing.Point(121, 175)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(144, 21)
        Me.cbPeriodo.TabIndex = 101
        Me.cbPeriodo.Visible = False
        '
        'chkCancelado
        '
        Me.chkCancelado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCancelado.ForeColor = System.Drawing.Color.Black
        Me.chkCancelado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCancelado.Location = New System.Drawing.Point(288, 177)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(80, 16)
        Me.chkCancelado.TabIndex = 7
        Me.chkCancelado.Text = "&Cancelado"
        '
        'txtNumPlaza
        '
        Me.txtNumPlaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumPlaza.Location = New System.Drawing.Point(368, 16)
        Me.txtNumPlaza.MaxLength = 10
        Me.txtNumPlaza.Name = "txtNumPlaza"
        Me.txtNumPlaza.Size = New System.Drawing.Size(112, 21)
        Me.txtNumPlaza.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(272, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Número de Plaza:"
        '
        'dtFechaF
        '
        Me.dtFechaF.CustomFormat = "MMMM"
        Me.dtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaF.Location = New System.Drawing.Point(329, 112)
        Me.dtFechaF.Name = "dtFechaF"
        Me.dtFechaF.Size = New System.Drawing.Size(120, 21)
        Me.dtFechaF.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(326, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Fecha Fin:"
        '
        'c1NoCuotas
        '
        Me.c1NoCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.c1NoCuotas.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.c1NoCuotas.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        Me.c1NoCuotas.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        Me.c1NoCuotas.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1NoCuotas.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1NoCuotas.Location = New System.Drawing.Point(120, 112)
        Me.c1NoCuotas.Name = "c1NoCuotas"
        Me.c1NoCuotas.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1NoCuotas.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1NoCuotas.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1NoCuotas.Size = New System.Drawing.Size(64, 18)
        Me.c1NoCuotas.TabIndex = 4
        Me.c1NoCuotas.Tag = Nothing
        Me.c1NoCuotas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1NoCuotas.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.c1NoCuotas.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        Me.c1NoCuotas.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(120, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "No. Cuotas:"
        '
        'txtCodTipoIngreso
        '
        Me.txtCodTipoIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoIngreso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodTipoIngreso.Location = New System.Drawing.Point(120, 64)
        Me.txtCodTipoIngreso.MaxLength = 1
        Me.txtCodTipoIngreso.Name = "txtCodTipoIngreso"
        Me.txtCodTipoIngreso.Size = New System.Drawing.Size(64, 21)
        Me.txtCodTipoIngreso.TabIndex = 2
        '
        'txtTipoIngreso
        '
        Me.txtTipoIngreso.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoIngreso.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtTipoIngreso.Location = New System.Drawing.Point(192, 64)
        Me.txtTipoIngreso.MaxLength = 1
        Me.txtTipoIngreso.Name = "txtTipoIngreso"
        Me.txtTipoIngreso.ReadOnly = True
        Me.txtTipoIngreso.Size = New System.Drawing.Size(288, 21)
        Me.txtTipoIngreso.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Tipo de Ingreso:"
        '
        'txtNombreEmp
        '
        Me.txtNombreEmp.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEmp.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtNombreEmp.Location = New System.Drawing.Point(120, 40)
        Me.txtNombreEmp.MaxLength = 1
        Me.txtNombreEmp.Name = "txtNombreEmp"
        Me.txtNombreEmp.ReadOnly = True
        Me.txtNombreEmp.Size = New System.Drawing.Size(360, 21)
        Me.txtNombreEmp.TabIndex = 7
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "MMMM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(200, 112)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(120, 21)
        Me.dtpFecha.TabIndex = 5
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpleado.Location = New System.Drawing.Point(120, 16)
        Me.txtCodEmpleado.MaxLength = 12
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(104, 21)
        Me.txtCodEmpleado.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 21)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Código de Empleado:"
        '
        'c1Monto
        '
        Me.c1Monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.c1Monto.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.c1Monto.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        Me.c1Monto.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        Me.c1Monto.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1Monto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1Monto.Location = New System.Drawing.Point(8, 112)
        Me.c1Monto.Name = "c1Monto"
        Me.c1Monto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1Monto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1Monto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1Monto.Size = New System.Drawing.Size(96, 18)
        Me.c1Monto.TabIndex = 3
        Me.c1Monto.Tag = Nothing
        Me.c1Monto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1Monto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.c1Monto.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        Me.c1Monto.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(200, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Fecha Inicio:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Monto:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(20, 60)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGuardar1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MetroButton2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgEmpleados)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(531, 671)
        Me.SplitContainer1.SplitterDistance = 304
        Me.SplitContainer1.TabIndex = 3
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(431, 268)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 131
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(431, 294)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 132
        Me.MetroButton2.Text = "&Guardar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'dgEmpleados
        '
        Me.dgEmpleados.AllowUserToAddRows = False
        Me.dgEmpleados.AllowUserToDeleteRows = False
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Location = New System.Drawing.Point(10, 143)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.ReadOnly = True
        Me.dgEmpleados.Size = New System.Drawing.Size(496, 145)
        Me.dgEmpleados.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.rbDepartamento)
        Me.GroupBox2.Controls.Add(Me.cbAreas)
        Me.GroupBox2.Controls.Add(Me.cbDepartamento)
        Me.GroupBox2.Controls.Add(Me.rbAreas)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.lblAreas)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 105)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(398, 39)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 132
        Me.MetroButton1.Text = "Mostrar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(120, 20)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(95, 17)
        Me.rbDepartamento.TabIndex = 2
        Me.rbDepartamento.TabStop = True
        Me.rbDepartamento.Text = "Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'cbAreas
        '
        Me.cbAreas.FormattingEnabled = True
        Me.cbAreas.Location = New System.Drawing.Point(92, 43)
        Me.cbAreas.Name = "cbAreas"
        Me.cbAreas.Size = New System.Drawing.Size(276, 21)
        Me.cbAreas.TabIndex = 2
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(92, 70)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(276, 21)
        Me.cbDepartamento.TabIndex = 4
        '
        'rbAreas
        '
        Me.rbAreas.AutoSize = True
        Me.rbAreas.Location = New System.Drawing.Point(70, 20)
        Me.rbAreas.Name = "rbAreas"
        Me.rbAreas.Size = New System.Drawing.Size(47, 17)
        Me.rbAreas.TabIndex = 1
        Me.rbAreas.TabStop = True
        Me.rbAreas.Text = "Área"
        Me.rbAreas.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Departamento:"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(12, 20)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(52, 17)
        Me.rbTodos.TabIndex = 0
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'lblAreas
        '
        Me.lblAreas.AutoSize = True
        Me.lblAreas.Location = New System.Drawing.Point(9, 46)
        Me.lblAreas.Name = "lblAreas"
        Me.lblAreas.Size = New System.Drawing.Size(32, 13)
        Me.lblAreas.TabIndex = 1
        Me.lblAreas.Text = "Area:"
        '
        'frmMsPLIngresos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(571, 751)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsPLIngresos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Ingresos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1NoCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmMsPLIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '===========================================
        Me.SplitContainer1.Panel2Collapsed = True
        'Me.MaximumSize = New Size(534, 298)
        'Me.Size = New Size(534, 298)
        '===========================================
        Me.dtFechaF.Enabled = True
        Me.Label7.Visible = False
        Me.cbPeriodo.Visible = False

        Me.cbAreas.DisplayMember = "Descripcion"
        Me.cbDepartamento.DisplayMember = "Descripcion"
        Me.cbAreas.ValueMember = "CodArea"
        Me.cbDepartamento.ValueMember = "CodDepartamento"
        If Me.btnGuardar1.Text = "&Guardar" Then
            Me.cbTipoPlanilla.DisplayMember = "DESCRIPCION"
            Me.cbTipoPlanilla.ValueMember = "CODTIPOPLANILLA"
            LlenarTiposPlanillas()
        End If

        Dim btnColumn As New DataGridViewButtonColumn
        With btnColumn
            .Width = 50
            .UseColumnTextForButtonValue = True
            '.DefaultCellStyle.BackColor = Color.Teal
            .DefaultCellStyle.ForeColor = Color.Red
            .Text = "Remover"
            .Name = "Eliminar"
            .HeaderText = "Remover Empleado"
        End With
        Me.dgEmpleados.Columns.Add(btnColumn)
        '===================================================================
    End Sub

    Private Sub txtCodEmpleado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEmpleado.DoubleClick
        If Me.btnGuardar1.Text = "&Guardar" Then
            Dim ofrm As New frmAGenerico
            Dim ds As New Data.DataSet
            Dim CodEmp, Ape1, Ape2, Nom As String
            Try
                ofrm.Text = "Buscar Empleados..."
                ds = oPlan.ConsultarPLEmpleado("CodEmpleado,Apellido1,Apellido2,Nombres", "", "CodEmpleado", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0

                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                CodEmp = ofrm.Resultado.Trim
                Ape1 = ofrm.Resultado2.Trim
                Ape2 = ofrm.Resultado3.Trim
                Nom = ofrm.Resultado4.Trim
                Me.txtCodEmpleado.Text = CodEmp
                Me.txtNombreEmp.Text = Ape1 & " " & Ape2 & ", " & Nom
            Catch ex As Exception
                MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
            End Try
        End If
    End Sub
    Private Sub txtCodEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodEmpleado.Validating
        If Me.btnGuardar1.Text = "&Guardar" Then
            Try
                If Me.txtCodEmpleado.Text.Trim <> "" Then
                    Dim ds As New Data.DataSet
                    Dim Filas As Data.DataRowCollection
                    ds = oPlan.ConsultarPLEmpleado("*", "CodEmpleado LIKE '" & Trim(Me.txtCodEmpleado.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count <= 0 Then
                    Else
                        Filas = ds.Tables(0).Rows()
                        Me.txtCodEmpleado.Text = CStr(Filas.Item(0)("CodEmpleado")).Trim
                        Me.txtNombreEmp.Text = CStr(Filas.Item(0)("Apellido1")).Trim & " " & CStr(Filas.Item(0)("Apellido2")).Trim & ", " & CStr(Filas.Item(0)("Nombres")).Trim
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
            End Try
        End If
    End Sub
    Private Sub txtCodTipoIngreso_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoIngreso.DoubleClick

        Dim ofrm As New frmAGenerico
        Dim ds As New Data.DataSet

        Try
            ofrm.Text = "Buscar Tipos de Ingreso..."
            ds = oPlan.ConsultarPLTipoIngresos("*", "", "CodTipoIngreso", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodTipoIngreso.Text = ofrm.Resultado.Trim
            Me.txtTipoIngreso.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try

    End Sub

    Private Sub txtNumPlaza_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumPlaza.Validating
        If Me.btnGuardar1.Text = "&Guardar" Then
            Try
                If Me.txtCodEmpleado.Text.Trim = "" Then Exit Sub
                Dim ds As New Data.DataSet
                Dim Filas As Data.DataRowCollection
                ds = oPlan.ConsultarPLPlazas("*", "CodEmpleado = '" & Trim(Me.txtCodEmpleado.Text) & "' and NoPlaza='" & Me.txtNumPlaza.Text.Trim & "'", "CodEmpleado", False, sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count <= 0 Then
                Else
                    Filas = ds.Tables(0).Rows()
                    Me.txtNumPlaza.Text = CStr(Filas.Item(0)("NoPlaza")).Trim
                End If
            Catch ex As Exception
                MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
            End Try
        End If
    End Sub
    Private Sub txtNumPlaza_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumPlaza.DoubleClick
        Dim ds As New Data.DataSet
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Número de Plaza"
            ds = oPlan.ConsultarPLPlazas("*", "CodEmpleado='" & Me.txtCodEmpleado.Text.Trim & "'", "NoPlaza", False, sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado2.Trim = "" Then Exit Sub
            Me.txtNumPlaza.Text = ofrm.Resultado2
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub
    Public Sub LlenarTiposPlanillas()
        Try
            Dim Dts As New DataSet
            Dts = oPlan.CONSULTAR_PLTIPOPLANILLA(sUsuario, sPassword, sSucursal)
            Me.cbTipoPlanilla.DataSource = Dts.Tables(0)
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub
    '==========================================================================
    'Ingresos Masivos
    '==========================================================================
    Private Sub LlenarCbAreas()
        Try
            Dim Dts As New DataSet
            Dts = oPlan.Consultar_PlAreas(sUsuario, sPassword, sSucursal, 1, "")
            Me.cbAreas.DataSource = Dts.Tables(0)
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub
    Private Sub LlenarcbDepartamentos(ByVal CodArea As String)
        Try
            Dim Dts As New DataSet
            Dts = oPlan.CONSULTAR_PLDEPARTAMENTOS(sUsuario, sPassword, sSucursal, 2, CodArea, "", "") '2 MUESTRA TODOS LOS DEPARTAMENTOS DE UN AREÁ ESPECIFICA.
            Me.cbDepartamento.DataSource = Dts.Tables(0)
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub
    Private Sub cbAreas_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAreas.DropDownClosed
        Try
            If Me.rbDepartamento.Checked = True Then
                LlenarcbDepartamentos(Me.cbAreas.SelectedValue)
            End If
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub
    Private Sub EstiloDg()
        Try
            Me.dgEmpleados.Columns("CodEmpleado").HeaderText = "Cod. de Empleado"
            Me.dgEmpleados.Columns("Empleado").HeaderText = "Empleado"
            Me.dgEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            Me.dgEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.dgEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub
    Private Sub LlenarDgEmpleados(ByVal CodArea As String, ByVal CodDepartamento As String)
        Try
            Dim Dts As New DataSet
            If rbAreas.Checked = True Then
                Dts = oPlan.Consultar_PlEmpleados2(CodArea, CodDepartamento, "A", 2)
            ElseIf rbDepartamento.Checked = True Then
                Dts = oPlan.Consultar_PlEmpleados2(CodArea, CodDepartamento, "A", 3)
            ElseIf rbTodos.Checked = True Then
                Dts = oPlan.Consultar_PlEmpleados2(CodArea, CodDepartamento, "A", 1)
            End If
            Me.dgEmpleados.DataSource = Dts.Tables(0)
            EstiloDg()
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub

    Private Sub dgEmpleados_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEmpleados.CellContentClick
        Try
            If Me.dgEmpleados.Rows.Count > 0 Then
                If Me.dgEmpleados.Columns(e.ColumnIndex).Name = "Eliminar" Then
                    If MsgBox("Desea eliminar este empleado", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Planillas") = 6 Then
                        Me.dgEmpleados.Rows.RemoveAt(Me.dgEmpleados.CurrentRow.Index)

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub
    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        Try
            If Me.chkTodos.Checked = True Then
                Me.SplitContainer1.Panel2Collapsed = False
                Me.MaximumSize = New Size(534, 613)
                Me.Size = New Size(534, 613)
                Me.SplitContainer1.SplitterDistance = 220
                Me.btnGuardar1.Visible = False

                LlenarCbAreas()
                Me.txtCodEmpleado.Enabled = False
                Me.txtNombreEmp.Enabled = False
                Me.txtNumPlaza.Enabled = False
            Else
                Me.SplitContainer1.Panel2Collapsed = True
                Me.MaximumSize = New Size(534, 298)
                Me.Size = New Size(534, 298)
                Me.SplitContainer1.SplitterDistance = 261
                Me.btnGuardar1.Visible = True

                Me.txtCodEmpleado.Enabled = True
                Me.txtNombreEmp.Enabled = True
                Me.txtNumPlaza.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim Campos, Valores, CamposValores, Filtro As String
        Dim Resultado As Integer
        Try

            If Me.btnGuardar1.Text = "&Guardar" Then
                Dim PAGO As Int16 = Me.cbFORMAPAGO.SelectedIndex.ToString
                If Me.txtCodTipoIngreso.Text = "" Or Me.txtCodEmpleado.Text = "" Then
                    MsgBox("Debe de completar todos los campos.", MsgBoxStyle.Information, "Módulo - Planilla")
                Else
                    Resultado = oPlan.Insertar_PlIngresos(sUsuario, sPassword, sSucursal, Me.txtCodEmpleado.Text.Trim, Me.txtCodTipoIngreso.Text.Trim,
                                                           Me.txtNumPlaza.Text.Trim, Me.c1Monto.Value, Me.c1NoCuotas.Value, Me.dtpFecha.Value, Me.dtFechaF.Value,
                                                            IIf(Me.chkCancelado.Checked = True, "C", "N"), "1", cbTipoPlanilla.SelectedValue, CInt(PAGO))
                    If Resultado <> 0 Then
                        MsgBox("Registro ingresado.", MsgBoxStyle.Information, "Módulo - Planilla")
                    Else
                        MsgBox("Registro NO ingresado.", MsgBoxStyle.Information, "Módulo - Planilla")
                    End If
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                Dim PAGO As Int16 = Me.cbFORMAPAGO.SelectedIndex.ToString
                Resultado = oPlan.Modificar_PlIngresos(sUsuario, sPassword, sSucursal, Me.txtCodEmpleado.Text.Trim, Me.txtCodTipoIngreso.Text.Trim,
                                                           Me.txtNumPlaza.Text.Trim, Me.c1Monto.Value, Me.c1NoCuotas.Value, Me.dtpFecha.Value, Me.dtFechaF.Value,
                                                            IIf(Me.chkCancelado.Checked = True, "C", "N"), "1", pCorrelativo, cbTipoPlanilla.SelectedValue, CInt(PAGO))
                If Resultado <> 0 Then
                    MsgBox("Registro ingresado.", MsgBoxStyle.Information, "Módulo - Planilla")
                Else
                    MsgBox("Registro NO ingresado.", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            End If

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If rbAreas.Checked = True Then
                LlenarDgEmpleados(Me.cbAreas.SelectedValue, "")
            ElseIf rbDepartamento.Checked = True Then
                LlenarDgEmpleados(Me.cbAreas.SelectedValue, Me.cbDepartamento.SelectedValue)
            ElseIf rbTodos.Checked = True Then
                LlenarDgEmpleados("", "")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If Me.dgEmpleados.Rows.Count > 0 Then
                Dim Resultado As Integer
                Dim I As Integer
                For I = 0 To dgEmpleados.Rows.Count - 1
                    Dim PAGO As Int16 = Me.cbFORMAPAGO.SelectedIndex.ToString
                    Resultado = oPlan.Insertar_PlIngresos(sUsuario, sPassword, sSucursal,
                    Me.dgEmpleados.Item("CodEmpleado", I).Value, Me.txtCodTipoIngreso.Text.Trim, Me.txtNumPlaza.Text,
                    Me.c1Monto.Value, Me.c1NoCuotas.Value, Format(Me.dtpFecha.Value, "Short Date"), Format(Me.dtFechaF.Value, "Short Date"),
                     IIf(Me.chkCancelado.Checked = True, "C", "N"), "1", Me.cbTipoPlanilla.SelectedValue, CInt(PAGO))
                Next
                MsgBox("Se han creado " + I.ToString + "nuevos ingresos", MsgBoxStyle.Information, "Módulo - Planillas")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

End Class