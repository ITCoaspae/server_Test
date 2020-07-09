Public Class frmMSPLDescuentos
#Region "VARIABLES Y CONSTRUCTORES PUBLICOS"
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Public vAccion As String, vCorrelativo As Integer
    Friend WithEvents txtOBSERVACION As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbFORMAPAGO As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbTIPOPLANILLA As System.Windows.Forms.ComboBox
    Friend WithEvents lblTIPOPLANILLA As System.Windows.Forms.Label
    Friend WithEvents scDescuentos As System.Windows.Forms.SplitContainer
    Friend WithEvents dgEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDepartamento As System.Windows.Forms.RadioButton
    Friend WithEvents cbAreas As System.Windows.Forms.ComboBox
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents rbAreas As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents lblAreas As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla
#End Region
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly
        rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() :
        'Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly 
        ': rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNumPlaza As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents nudCuota As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNoCuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents c1nMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionDesc As System.Windows.Forms.TextBox
    Friend WithEvents chkFijo As System.Windows.Forms.CheckBox
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents c1nSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.cbTIPOPLANILLA = New System.Windows.Forms.ComboBox()
        Me.lblTIPOPLANILLA = New System.Windows.Forms.Label()
        Me.cbFORMAPAGO = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtOBSERVACION = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.c1nSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkCancelado = New System.Windows.Forms.CheckBox()
        Me.chkFijo = New System.Windows.Forms.CheckBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1nMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcionDesc = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreEmp = New System.Windows.Forms.TextBox()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNumPlaza = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudCuota = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoCuotas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.scDescuentos = New System.Windows.Forms.SplitContainer()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.cbAreas = New System.Windows.Forms.ComboBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.rbAreas = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.lblAreas = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scDescuentos.Panel1.SuspendLayout()
        Me.scDescuentos.Panel2.SuspendLayout()
        Me.scDescuentos.SuspendLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnGuardar1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.cbTIPOPLANILLA)
        Me.GroupBox1.Controls.Add(Me.lblTIPOPLANILLA)
        Me.GroupBox1.Controls.Add(Me.cbFORMAPAGO)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtOBSERVACION)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.txtReferencia)
        Me.GroupBox1.Controls.Add(Me.c1nSaldo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.chkCancelado)
        Me.GroupBox1.Controls.Add(Me.chkFijo)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.c1nMonto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionDesc)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNombreEmp)
        Me.GroupBox1.Controls.Add(Me.txtCodEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtNumPlaza)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.nudCuota)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNoCuotas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 376)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(553, 346)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 125
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(589, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'chkTodos
        '
        Me.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodos.ForeColor = System.Drawing.Color.Black
        Me.chkTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodos.Location = New System.Drawing.Point(384, 204)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(134, 16)
        Me.chkTodos.TabIndex = 27
        Me.chkTodos.Text = "&Todos los Empleados"
        '
        'cbTIPOPLANILLA
        '
        Me.cbTIPOPLANILLA.FormattingEnabled = True
        Me.cbTIPOPLANILLA.Items.AddRange(New Object() {"", "Primera Quincena", "Segunda Quincena", "Ambas"})
        Me.cbTIPOPLANILLA.Location = New System.Drawing.Point(133, 252)
        Me.cbTIPOPLANILLA.Name = "cbTIPOPLANILLA"
        Me.cbTIPOPLANILLA.Size = New System.Drawing.Size(495, 21)
        Me.cbTIPOPLANILLA.TabIndex = 31
        '
        'lblTIPOPLANILLA
        '
        Me.lblTIPOPLANILLA.AutoSize = True
        Me.lblTIPOPLANILLA.Location = New System.Drawing.Point(16, 255)
        Me.lblTIPOPLANILLA.Name = "lblTIPOPLANILLA"
        Me.lblTIPOPLANILLA.Size = New System.Drawing.Size(99, 13)
        Me.lblTIPOPLANILLA.TabIndex = 30
        Me.lblTIPOPLANILLA.Text = "Planilla a descontar"
        '
        'cbFORMAPAGO
        '
        Me.cbFORMAPAGO.FormattingEnabled = True
        Me.cbFORMAPAGO.Items.AddRange(New Object() {"", "Primera Quincena", "Segunda Quincena", "Ambas"})
        Me.cbFORMAPAGO.Location = New System.Drawing.Point(133, 225)
        Me.cbFORMAPAGO.Name = "cbFORMAPAGO"
        Me.cbFORMAPAGO.Size = New System.Drawing.Size(495, 21)
        Me.cbFORMAPAGO.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 225)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Forma de pago:"
        '
        'txtOBSERVACION
        '
        Me.txtOBSERVACION.Location = New System.Drawing.Point(133, 304)
        Me.txtOBSERVACION.Multiline = True
        Me.txtOBSERVACION.Name = "txtOBSERVACION"
        Me.txtOBSERVACION.Size = New System.Drawing.Size(495, 35)
        Me.txtOBSERVACION.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(18, 309)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Observación:"
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.White
        Me.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargo.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtCargo.Location = New System.Drawing.Point(228, 41)
        Me.txtCargo.MaxLength = 1
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(400, 20)
        Me.txtCargo.TabIndex = 7
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(133, 278)
        Me.txtReferencia.MaxLength = 100
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReferencia.Size = New System.Drawing.Size(495, 20)
        Me.txtReferencia.TabIndex = 33
        '
        'c1nSaldo
        '
        Me.c1nSaldo.BackColor = System.Drawing.Color.White
        Me.c1nSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nSaldo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nSaldo.Location = New System.Drawing.Point(133, 118)
        Me.c1nSaldo.Name = "c1nSaldo"
        Me.c1nSaldo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldo.ReadOnly = True
        Me.c1nSaldo.Size = New System.Drawing.Size(166, 18)
        Me.c1nSaldo.TabIndex = 16
        Me.c1nSaldo.Tag = Nothing
        Me.c1nSaldo.Value = New Decimal(New Integer() {9, 0, 0, 0})
        Me.c1nSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Saldo:"
        '
        'chkCancelado
        '
        Me.chkCancelado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCancelado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCancelado.Location = New System.Drawing.Point(286, 200)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(77, 24)
        Me.chkCancelado.TabIndex = 26
        Me.chkCancelado.Text = "&Cancelado"
        '
        'chkFijo
        '
        Me.chkFijo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFijo.Location = New System.Drawing.Point(131, 202)
        Me.chkFijo.Name = "chkFijo"
        Me.chkFijo.Size = New System.Drawing.Size(105, 22)
        Me.chkFijo.TabIndex = 25
        Me.chkFijo.Text = "&Descuento Fijo"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(133, 177)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(166, 20)
        Me.dtpFechaFin.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(13, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Fec. de fin descuento:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(462, 118)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(166, 20)
        Me.dtpFechaInicio.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(305, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Fecha de Inicio descuento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Número de Cuotas:"
        '
        'c1nMonto
        '
        Me.c1nMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMonto.Location = New System.Drawing.Point(462, 92)
        Me.c1nMonto.Name = "c1nMonto"
        Me.c1nMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMonto.Size = New System.Drawing.Size(166, 18)
        Me.c1nMonto.TabIndex = 14
        Me.c1nMonto.Tag = Nothing
        Me.c1nMonto.Value = New Decimal(New Integer() {8, 0, 0, 0})
        Me.c1nMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(305, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Monto total a descontar:"
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.Color.White
        Me.txtTipo.Location = New System.Drawing.Point(133, 92)
        Me.txtTipo.MaxLength = 10
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(166, 20)
        Me.txtTipo.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tipo de descuento:"
        '
        'txtDescripcionDesc
        '
        Me.txtDescripcionDesc.BackColor = System.Drawing.Color.White
        Me.txtDescripcionDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionDesc.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtDescripcionDesc.Location = New System.Drawing.Point(228, 66)
        Me.txtDescripcionDesc.MaxLength = 1
        Me.txtDescripcionDesc.Name = "txtDescripcionDesc"
        Me.txtDescripcionDesc.ReadOnly = True
        Me.txtDescripcionDesc.Size = New System.Drawing.Size(400, 20)
        Me.txtDescripcionDesc.TabIndex = 10
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(133, 65)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(89, 20)
        Me.txtCodigo.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descuento:"
        '
        'txtNombreEmp
        '
        Me.txtNombreEmp.BackColor = System.Drawing.Color.White
        Me.txtNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEmp.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtNombreEmp.Location = New System.Drawing.Point(228, 13)
        Me.txtNombreEmp.MaxLength = 1
        Me.txtNombreEmp.Name = "txtNombreEmp"
        Me.txtNombreEmp.ReadOnly = True
        Me.txtNombreEmp.Size = New System.Drawing.Size(400, 20)
        Me.txtNombreEmp.TabIndex = 3
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.Location = New System.Drawing.Point(134, 13)
        Me.txtCodEmpleado.MaxLength = 12
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(88, 20)
        Me.txtCodEmpleado.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(13, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Empleado:"
        '
        'txtNumPlaza
        '
        Me.txtNumPlaza.Location = New System.Drawing.Point(134, 39)
        Me.txtNumPlaza.MaxLength = 10
        Me.txtNumPlaza.Name = "txtNumPlaza"
        Me.txtNumPlaza.Size = New System.Drawing.Size(88, 20)
        Me.txtNumPlaza.TabIndex = 6
        Me.txtNumPlaza.Text = "01"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(13, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Plaza:"
        '
        'nudCuota
        '
        Me.nudCuota.DecimalPlaces = 2
        Me.nudCuota.Location = New System.Drawing.Point(462, 144)
        Me.nudCuota.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudCuota.Name = "nudCuota"
        Me.nudCuota.Size = New System.Drawing.Size(166, 20)
        Me.nudCuota.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(305, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Cuota por planilla:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoCuotas
        '
        Me.txtNoCuotas.Location = New System.Drawing.Point(133, 144)
        Me.txtNoCuotas.MaxLength = 20
        Me.txtNoCuotas.Name = "txtNoCuotas"
        Me.txtNoCuotas.Size = New System.Drawing.Size(166, 20)
        Me.txtNoCuotas.TabIndex = 20
        Me.txtNoCuotas.Text = "0"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Referencia:"
        '
        'scDescuentos
        '
        Me.scDescuentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scDescuentos.Location = New System.Drawing.Point(20, 60)
        Me.scDescuentos.Name = "scDescuentos"
        Me.scDescuentos.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scDescuentos.Panel1
        '
        Me.scDescuentos.Panel1.Controls.Add(Me.GroupBox1)
        '
        'scDescuentos.Panel2
        '
        Me.scDescuentos.Panel2.Controls.Add(Me.MetroButton1)
        Me.scDescuentos.Panel2.Controls.Add(Me.dgEmpleados)
        Me.scDescuentos.Panel2.Controls.Add(Me.GroupBox2)
        Me.scDescuentos.Size = New System.Drawing.Size(664, 670)
        Me.scDescuentos.SplitterDistance = 380
        Me.scDescuentos.TabIndex = 1
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(556, 229)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 126
        Me.MetroButton1.Text = "&Guardar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'dgEmpleados
        '
        Me.dgEmpleados.AllowUserToAddRows = False
        Me.dgEmpleados.AllowUserToDeleteRows = False
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Location = New System.Drawing.Point(12, 101)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.ReadOnly = True
        Me.dgEmpleados.Size = New System.Drawing.Size(644, 122)
        Me.dgEmpleados.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton2)
        Me.GroupBox2.Controls.Add(Me.rbDepartamento)
        Me.GroupBox2.Controls.Add(Me.cbAreas)
        Me.GroupBox2.Controls.Add(Me.cbDepartamento)
        Me.GroupBox2.Controls.Add(Me.rbAreas)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.lblAreas)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(644, 92)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(553, 57)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 127
        Me.MetroButton2.Text = "&Mostrar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(123, 20)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(92, 17)
        Me.rbDepartamento.TabIndex = 41
        Me.rbDepartamento.TabStop = True
        Me.rbDepartamento.Text = "Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'cbAreas
        '
        Me.cbAreas.FormattingEnabled = True
        Me.cbAreas.ItemHeight = 13
        Me.cbAreas.Location = New System.Drawing.Point(92, 40)
        Me.cbAreas.Name = "cbAreas"
        Me.cbAreas.Size = New System.Drawing.Size(455, 21)
        Me.cbAreas.TabIndex = 3
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(92, 64)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(455, 21)
        Me.cbDepartamento.TabIndex = 45
        '
        'rbAreas
        '
        Me.rbAreas.AutoSize = True
        Me.rbAreas.Location = New System.Drawing.Point(70, 20)
        Me.rbAreas.Name = "rbAreas"
        Me.rbAreas.Size = New System.Drawing.Size(47, 17)
        Me.rbAreas.TabIndex = 40
        Me.rbAreas.TabStop = True
        Me.rbAreas.Text = "Área"
        Me.rbAreas.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Departamento:"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(9, 19)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 39
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'lblAreas
        '
        Me.lblAreas.AutoSize = True
        Me.lblAreas.Location = New System.Drawing.Point(16, 40)
        Me.lblAreas.Name = "lblAreas"
        Me.lblAreas.Size = New System.Drawing.Size(32, 13)
        Me.lblAreas.TabIndex = 42
        Me.lblAreas.Text = "Area:"
        '
        'frmMSPLDescuentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(704, 750)
        Me.Controls.Add(Me.scDescuentos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMSPLDescuentos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Ingreso de Descuentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCuota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scDescuentos.Panel1.ResumeLayout(False)
        Me.scDescuentos.Panel2.ResumeLayout(False)
        Me.scDescuentos.ResumeLayout(False)
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtNumPlaza_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumPlaza.DoubleClick
        Dim ds As New Data.DataSet, oPlan As New wrPlanilla.wsLibPlanilla, dr As DataRow
        Dim sResultado1 As String, sResultado2 As String
        Dim ofrm As New frmAGenerico

        Try
            ofrm.Text = "Buscar Número de Plaza"
            ds = oPlan.ConsultarPLPlazas("NoPlaza,FechaInicial,FechaFinal,CodCargo,TipoPlanilla,Estatus",
                                         "CodEmpleado='" & Me.txtCodEmpleado.Text.Trim & "'", "NoPlaza", False, sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim = "" Then Exit Sub
            Me.txtNumPlaza.Text = ofrm.Resultado
            Me.txtCargo.Text = ofrm.Resultado4
            ds = oPlan.ConsultarPLCargos("*", "CodCargo='" & Me.txtCargo.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
            If ds.Tables("PLCargos").Rows.Count > 0 Then
                dr = ds.Tables("PLCargos").Rows(0)
                Me.txtCargo.Text = dr("Descripcion")
            End If

        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub
    Private Sub txtCodigo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.DoubleClick
        Dim ds As New Data.DataSet
        Dim sResultado1 As String, sResultado2 As String
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Descuento"
            ds = oPlan.ConsultarPLTipoDescuentos("*", "", "CodTipoDescuento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim = "" Then Exit Sub
            Me.txtCodigo.Text = ofrm.Resultado
            Me.txtDescripcionDesc.Text = ofrm.Resultado2
            If ofrm.Resultado3.Trim = "E" Then
                Me.txtTipo.Text = "Externo"
            Else
                Me.txtTipo.Text = "Interno"
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub
    Private Sub txtCodEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodEmpleado.Validating
        If Me.btnGuardar1.Text = "&Guardar" Then
            Try
                If Me.txtCodEmpleado.Text.Trim = "" Then Exit Sub
                Dim ds As New Data.DataSet, dr As DataRow
                Dim Filas As Data.DataRowCollection
                ds = oPlan.ConsultarPLEmpleado("*", "CodEmpleado LIKE '" & Trim(Me.txtCodEmpleado.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count <= 0 Then
                Else
                    Filas = ds.Tables(0).Rows()
                    Me.txtCodEmpleado.Text = CStr(Filas.Item(0)("CodEmpleado")).Trim
                    Me.txtNombreEmp.Text = CStr(Filas.Item(0)("Apellido1")).Trim & " " & CStr(Filas.Item(0)("Apellido2")).Trim &
                    ", " & CStr(Filas.Item(0)("Nombres")).Trim
                    Me.txtCargo.Text = Filas.Item(0)("CodCargo")
                    ds = oPlan.ConsultarPLCargos("*", "CodCargo='" & Me.txtCargo.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
                    If ds.Tables("PLCargos").Rows.Count > 0 Then
                        dr = ds.Tables("PLCargos").Rows(0)
                        Me.txtCargo.Text = dr("Descripcion")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
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
                If ofrm.Resultado.Trim = "" Then Exit Sub
                CodEmp = ofrm.Resultado.Trim
                Ape1 = ofrm.Resultado2.Trim
                Ape2 = ofrm.Resultado3.Trim
                Nom = ofrm.Resultado4.Trim
                Me.txtCodEmpleado.Text = CodEmp
                Me.txtNombreEmp.Text = Ape1 & " " & Ape2 & ", " & Nom
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub txtNumPlaza_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumPlaza.Validating
        If Me.btnGuardar1.Text = "&Guardar" Then
            Try
                If Me.txtCodEmpleado.Text.Trim = "" Then Exit Sub
                Dim ds As New Data.DataSet
                Dim Filas As Data.DataRowCollection
                ds = oPlan.ConsultarPLPlazas("*", "CodEmpleado = '" & Trim(Me.txtCodEmpleado.Text) &
                                             "' and NoPlaza='" & Me.txtNumPlaza.Text.Trim & "'", "CodEmpleado", False, sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count <= 0 Then
                Else
                    Filas = ds.Tables(0).Rows()
                    Me.txtNumPlaza.Text = CStr(Filas.Item(0)("NoPlaza")).Trim
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub txtCodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigo.Validating
        If Me.btnGuardar1.Text = "&Guardar" Then
            Try
                If Me.txtCodigo.Text = "" Then Exit Sub
                Dim ds As New Data.DataSet
                Dim Filas As Data.DataRowCollection
                ds = oPlan.ConsultarPLTipoDescuentos("*", "CodTipoDescuento LIKE '" & Trim(Me.txtCodigo.Text) & "'", "CodTipoDescuento", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count <= 0 Then
                Else
                    Filas = ds.Tables(0).Rows()
                    Me.txtCodigo.Text = CStr(Filas.Item(0)("CodTipoDescuento")).Trim
                    Me.txtDescripcionDesc.Text = CStr(Filas.Item(0)("Descripcion")).Trim
                    If CStr(Filas.Item(0)("Tipo")).Trim = "E" Then
                        Me.txtTipo.Text = "Externo"
                    Else
                        Me.txtTipo.Text = "Interno"
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub frmMSPLDescuentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbTIPOPLANILLA.DataSource = LLENAR_TIPOSPLANILLA().Tables(0)
        Me.cbTIPOPLANILLA.DisplayMember = "DESCRIPCION"
        Me.cbTIPOPLANILLA.ValueMember = "CODTIPOPLANILLA"
        If vAccion <> "Agregar" Then
            '==============================================
            'Oculta el checkbox de todos los empleados
            'porque solo se pueden modificar uno por uno.
            Me.chkTodos.Visible = False
            '==============================================
            Dim DTS As New DataSet
            Dim CODIGO_EMPLEADO, TIPOPLANILLA, NUMPLAZA, CARGO, CODDESCUENTO, DESC_DESCUENTO, TIPODESCUENTO As String
            Dim MONTOTOTAL, SALDO, CUOTA As Double
            Dim FECHAI, FECHAF As DateTime
            Dim DESC_FIJO, FORMAPAGO, NOCUOTAS As Integer
            Dim REFERENCIA, OBSERVACION, CANCELADO, EMPLEADO As String
            DTS = Me.MOSTRAR_INFDESCUENTOS
            CODIGO_EMPLEADO = IIf(DTS.Tables(0).Rows(0).Item("CODEMPLEADO") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("CODEMPLEADO"))
            EMPLEADO = IIf(DTS.Tables(0).Rows(0).Item("EMPLEADO") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("EMPLEADO"))
            CARGO = IIf(DTS.Tables(0).Rows(0).Item("CARGO") Is DBNull.Value, " ", DTS.Tables(0).Rows(0).Item("CARGO"))
            TIPOPLANILLA = IIf(DTS.Tables(0).Rows(0).Item("TIPOPLANILLA") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("TIPOPLANILLA"))
            NUMPLAZA = IIf(DTS.Tables(0).Rows(0).Item("NOPLAZA") Is DBNull.Value, " ", DTS.Tables(0).Rows(0).Item("NOPLAZA"))
            CODDESCUENTO = IIf(DTS.Tables(0).Rows(0).Item("CODTIPODESCUENTO") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("CODTIPODESCUENTO"))
            DESC_DESCUENTO = IIf(DTS.Tables(0).Rows(0).Item("TIPODESC") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("TIPODESC"))
            TIPODESCUENTO = IIf(DTS.Tables(0).Rows(0).Item("TIPO") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("TIPO"))
            MONTOTOTAL = IIf(DTS.Tables(0).Rows(0).Item("MONTO") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("MONTO"))
            SALDO = IIf(DTS.Tables(0).Rows(0).Item("SALDO") Is DBNull.Value, 0, DTS.Tables(0).Rows(0).Item("SALDO"))
            CUOTA = IIf(DTS.Tables(0).Rows(0).Item("MONTOCUOTA") Is DBNull.Value, 0, DTS.Tables(0).Rows(0).Item("MONTOCUOTA"))
            FECHAI = IIf(DTS.Tables(0).Rows(0).Item("FECHAINICIO") Is DBNull.Value, Now, DTS.Tables(0).Rows(0).Item("FECHAINICIO"))
            FECHAF = IIf(DTS.Tables(0).Rows(0).Item("FECHAFIN") Is DBNull.Value, Now, DTS.Tables(0).Rows(0).Item("FECHAFIN"))
            DESC_FIJO = IIf(DTS.Tables(0).Rows(0).Item("FIJO") Is DBNull.Value, 0, DTS.Tables(0).Rows(0).Item("FIJO"))
            CANCELADO = IIf(DTS.Tables(0).Rows(0).Item("ESTADO") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("ESTADO"))
            FORMAPAGO = IIf(DTS.Tables(0).Rows(0).Item("PAGO") Is DBNull.Value, 0, DTS.Tables(0).Rows(0).Item("PAGO"))
            REFERENCIA = IIf(DTS.Tables(0).Rows(0).Item("REFERENCIA") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("REFERENCIA"))
            OBSERVACION = IIf(DTS.Tables(0).Rows(0).Item("OBSERVACION") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("OBSERVACION"))
            NOCUOTAS = IIf(DTS.Tables(0).Rows(0).Item("NOCUOTAS") Is DBNull.Value, 0, DTS.Tables(0).Rows(0).Item("NOCUOTAS"))
            'ASIGNAMOS LOS VALORES A LOS CONTROLES
            Me.txtCodEmpleado.Text = CODIGO_EMPLEADO
            Me.txtNombreEmp.Text = EMPLEADO
            Me.txtCargo.Text = CARGO
            Me.txtNumPlaza.Text = NUMPLAZA
            Me.txtCodigo.Text = CODDESCUENTO
            Me.txtDescripcionDesc.Text = DESC_DESCUENTO
            Me.txtTipo.Text = TIPODESCUENTO
            Me.Label1.Text = TIPOPLANILLA
            c1nMonto.Value = MONTOTOTAL
            c1nSaldo.Value = SALDO
            dtpFechaInicio.Value = FECHAI
            Me.cbTIPOPLANILLA.SelectedValue = TIPOPLANILLA
            dtpFechaFin.Value = FECHAF
            nudCuota.Value = CUOTA
            txtNoCuotas.Text = NOCUOTAS
            Me.cbFORMAPAGO.SelectedIndex = FORMAPAGO
            Me.txtOBSERVACION.Text = OBSERVACION
            Me.txtReferencia.Text = REFERENCIA
            If CANCELADO.Trim <> "N" Then
                Me.chkCancelado.Checked = True
            End If
            If DESC_FIJO = 1 Then
                Me.chkFijo.Checked = True
            End If
            Dim a As String = vAccion
            If a = "Modificar " Then

            ElseIf a = "Consultar" Then
                SOLOLECTURA()
            End If
        End If
        '===========================================
        'Me.scDescuentos.Panel2Collapsed = True
        'Me.MaximumSize = New Size(568, 430)
        'Me.Size = New Size(568, 430)
        '===========================================
        '===================================================================
        Dim btnColumn As New DataGridViewButtonColumn
        With btnColumn
            .Width = 50
            .UseColumnTextForButtonValue = True
            '.DefaultCellStyle.BackColor = Color.Teal
            .DefaultCellStyle.ForeColor = Color.Red
            .Text = "Remover"
            .Name = "Eliminar"
            .HeaderText = "Remover Empleado"
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End With
        Me.dgEmpleados.Columns.Add(btnColumn)
        Me.cbAreas.DisplayMember = "Descripcion"
        Me.cbDepartamento.DisplayMember = "Descripcion"
        Me.cbAreas.ValueMember = "CodArea"
        Me.cbDepartamento.ValueMember = "CodDepartamento"
        '===================================================================
    End Sub
    Private Sub chkFijo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFijo.CheckedChanged
        If Me.chkFijo.Checked = True Then
            Me.c1nMonto.Enabled = False
            Me.txtNoCuotas.Enabled = False
            Me.txtNoCuotas.Text = 0
            Me.nudCuota.Value = Me.c1nMonto.Value
        Else
            Me.c1nMonto.Enabled = True
            Me.txtNoCuotas.Enabled = True
        End If
    End Sub

    Private Sub txtNoCuotas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuotas.LostFocus
        Me.dtpFechaFin.Value = DateAdd(DateInterval.Month, Val(Me.txtNoCuotas.Text), Me.dtpFechaInicio.Value)
    End Sub
    Protected Function MOSTRAR_INFDESCUENTOS() As DataSet
        Dim DTS As New DataSet
        DTS = oPlan.CONSULTAR_PLDESCUENTOS2(sUsuario, sPassword, sSucursal, vCorrelativo)
        Return DTS
    End Function
    Private Sub SOLOLECTURA()
        Me.txtCodEmpleado.ReadOnly = True
        Me.txtNombreEmp.ReadOnly = True
        Me.txtCargo.ReadOnly = True
        Me.txtNumPlaza.ReadOnly = True
        Me.txtCodigo.ReadOnly = True
        Me.txtDescripcionDesc.ReadOnly = True
        Me.txtTipo.ReadOnly = True
        c1nMonto.ReadOnly = True
        c1nSaldo.ReadOnly = True
        dtpFechaInicio.Enabled = False
        dtpFechaFin.Enabled = False
        nudCuota.ReadOnly = True
        txtNoCuotas.ReadOnly = True
        Me.cbFORMAPAGO.Enabled = False
        Me.txtOBSERVACION.ReadOnly = True
        Me.txtReferencia.ReadOnly = True
        Me.chkCancelado.Enabled = False
        Me.chkFijo.Enabled = False
        Me.cbTIPOPLANILLA.Enabled = False
    End Sub
    Protected Function LLENAR_TIPOSPLANILLA() As DataSet
        Dim DTS As New DataSet
        DTS = oPlan.CONSULTAR_PLTIPOPLANILLA(sUsuario, sPassword, sSucursal)
        Return DTS
    End Function
    Private Sub c1nMonto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nMonto.LostFocus
        Me.c1nSaldo.Value = Me.c1nMonto.Value
    End Sub
    '============================
    'Ingreso Masivo de Descuentos
    '============================  
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
                Me.scDescuentos.Panel2Collapsed = False
                Me.MaximumSize = New Size(568, 700)
                Me.Size = New Size(568, 700)
                Me.scDescuentos.SplitterDistance = 380
                Me.btnGuardar1.Visible = False

                LlenarCbAreas()
                Me.txtCodEmpleado.Enabled = False
                Me.txtNombreEmp.Enabled = False
                Me.txtNumPlaza.Enabled = False
                Me.txtCargo.Enabled = False
            Else
                Me.scDescuentos.Panel2Collapsed = True
                Me.MaximumSize = New Size(568, 430)
                Me.Size = New Size(568, 430)
                Me.scDescuentos.SplitterDistance = 400
                Me.btnGuardar1.Visible = True
                '  Me.btnCerrar.Visible = True
                Me.txtCodEmpleado.Enabled = True
                Me.txtNombreEmp.Enabled = True
                Me.txtNumPlaza.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" _
                   + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub

    Private Function ValidarIngreso() As Boolean
        If Me.txtCodigo.Text.Trim <> "" And Me.txtTipo.Text.Trim <> "" And Me.c1nSaldo.Value > 0 _
        And Me.nudCuota.Value > 0 And Me.cbFORMAPAGO.SelectedIndex > -1 And Me.cbTIPOPLANILLA.SelectedIndex > -1 _
        And c1nMonto.Value >= nudCuota.Value Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos As String, Valores As String, CamposValores As String
            Dim valido As Boolean
            ' Me.cbTipoPlanilla.SelectedIndex = 0
            If Me.txtNoCuotas.Text.Trim = "" Then Me.txtNoCuotas.Text = 0
            If Me.txtNumPlaza.Text.Trim = "" Then
                MessageBox.Show("Debe seleccionar la plaza del empleado.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'validamos que el nuevo descuento no sobrepase el porcentaje de ley permitido.
            If Me.chkCancelado.Checked = True Then
                valido = True
            Else
                valido = oPlan.ValidarIngresoDescuento(Me.txtCodEmpleado.Text.Trim, nudCuota.Value)
            End If
            If valido = True Then
                If Me.btnGuardar1.Text = "&Guardar" Then
                    Dim CODEMPLEADO As String = Me.txtCodEmpleado.Text.Trim
                    Dim TIPODESC As String = Me.txtCodigo.Text.Trim
                    Dim PLAZA As String = Me.txtNumPlaza.Text.Trim
                    Dim MONTO As Double = Me.c1nMonto.Value
                    Dim SALDO As Double = Me.c1nMonto.Value
                    Dim MONTOCUOTA As Double = nudCuota.Value
                    Dim NOCUOTAS As Integer = Me.txtNoCuotas.Text.Trim
                    Dim FECHAINICIO As Date = Me.dtpFechaInicio.Value.Date
                    Dim FECHAFIN As Date = Me.dtpFechaFin.Value.Date
                    Dim REFERENCIA As String = Me.txtReferencia.Text.Trim
                    Dim ESTADO As Char
                    If Me.chkCancelado.Checked = True Then
                        ESTADO = "C"
                    Else
                        ESTADO = "N"
                    End If
                    Dim FIJO As Char
                    If Me.chkFijo.Checked = True Then
                        FIJO = "1"
                    Else
                        FIJO = "0"
                    End If
                    Dim APLICA As String = "0"
                    Dim CUOTASPAGADAS As Integer = 0
                    Dim OBSERVACION As String = txtOBSERVACION.Text.Trim
                    Dim PAGO As Char = Me.cbFORMAPAGO.SelectedIndex.ToString
                    If oPlan.InsertarPLDescuentos(sUsuario, sPassword, sSucursal, CODEMPLEADO, TIPODESC, PLAZA, MONTO, SALDO, Me.cbTIPOPLANILLA.SelectedValue, MONTOCUOTA _
                                                  , NOCUOTAS, FECHAINICIO, REFERENCIA, FECHAFIN, ESTADO, FIJO, APLICA, CUOTASPAGADAS, OBSERVACION,
                                                  PAGO) = True Then
                        MsgBox("Los datos fueron ingresados correctamente en el sistema.", MsgBoxStyle.Information, "Módulo - Planilla")
                        Me.Dispose()
                    Else
                        MsgBox("Los datos fueron ingresados correctamente en el sistema.", MsgBoxStyle.Critical, "Módulo - Planilla")
                    End If
                ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                    Dim estado As String
                    If Me.chkCancelado.Checked = True Then
                        estado = "C"
                    Else
                        estado = "N"
                    End If
                    Dim FIJO As Char
                    If Me.chkFijo.Checked = True Then
                        FIJO = "1"
                    Else
                        FIJO = "0"
                    End If
                    Try
                        oPlan.MODIFICAR_PLDESCUENTOS(sUsuario, sPassword, sSucursal, vCorrelativo, txtCodEmpleado.Text, txtCodigo.Text, txtNumPlaza.Text, c1nMonto.Value,
                                                c1nSaldo.Value, Me.cbTIPOPLANILLA.SelectedValue, nudCuota.Value, txtNoCuotas.Text, dtpFechaInicio.Value, txtReferencia.Text,
                                                dtpFechaFin.Value, estado, FIJO, txtOBSERVACION.Text.Trim, Me.cbFORMAPAGO.SelectedIndex, Now)
                        MsgBox("Modificación realizada Exitosamente", MsgBoxStyle.Information, "Modulo - Planilla")
                        Me.Dispose()
                    Catch ex As Exception
                        MsgBox("Los datos no fueron modificados correctamente." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planilla")
                    End Try
                End If
            Else
                MsgBox("El descuento sobrepasa el monto maximo a descontar.", MsgBoxStyle.Critical, "Módulo - Planilla")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If ValidarIngreso() = True Then
                If Me.dgEmpleados.Rows.Count > 0 Then
                    Dim estado As String
                    Dim FIJO As Char
                    Dim I As Integer
                    Dim APLICA As String = "0"
                    Dim CuotasPagadas As Integer = 0
                    If Me.chkCancelado.Checked = True Then
                        estado = "C"
                    Else
                        estado = "N"
                    End If
                    If Me.chkFijo.Checked = True Then
                        FIJO = "1"
                    Else
                        FIJO = "0"
                    End If
                    For I = 0 To Me.dgEmpleados.Rows.Count - 1
                        oPlan.InsertarPLDescuentos(sUsuario, sPassword, sSucursal, Me.dgEmpleados.Item("CodEmpleado", I).Value.ToString, Me.txtCodigo.Text.Trim,
                                                   Me.txtNumPlaza.Text.Trim, Me.c1nMonto.Value, Me.c1nSaldo.Value, Me.cbTIPOPLANILLA.SelectedValue,
                                                   nudCuota.Value, Me.txtNoCuotas.Text.Trim, Format(Me.dtpFechaInicio.Value, "Short Date"), Me.txtReferencia.Text.Trim,
                                                   Format(Me.dtpFechaFin.Value, "Short Date"), estado, FIJO, APLICA, 0, Me.txtOBSERVACION.Text.Trim,
                                                   Me.cbFORMAPAGO.SelectedIndex.ToString)
                    Next
                    MsgBox("Se han ingresado " + I.ToString + "nuevos Descuentos", MsgBoxStyle.Information, "Módulo - Planillas")
                End If
            Else
                MsgBox("Por favor no dejar ningun campo vacio.", MsgBoxStyle.Information, "Módulo - Planillas")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
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

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub cbFORMAPAGO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFORMAPAGO.SelectedIndexChanged

    End Sub

    Private Sub nudCuota_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudCuota.LostFocus
        If Me.c1nMonto.ValueIsDbNull = False Then
            If Me.nudCuota.Value > c1nMonto.Value Then
                MsgBox("La cuota no puede ser mayor que el monto total a descontar", MsgBoxStyle.Information, "Módulo - Planillas")
            End If
        End If
    End Sub
End Class