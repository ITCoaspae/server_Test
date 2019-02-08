Public Class frmCrTablaAmortEjec
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnExportar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLimpiar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAceptarLin1 As MetroFramework.Controls.MetroButton
    Friend WithEvents C1NESeguroVehiculo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkSeguroVehiculo As CheckBox
    Friend WithEvents C1NEOtros As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkOtros As CheckBox
    Private ds As New DataSet

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C1NEMontoGarantia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1NESeguroDanios As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkSeguroDanios As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents C1NEAhorro As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkAhorro As System.Windows.Forms.CheckBox
    Friend WithEvents C1NEAportacion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkAportacion As System.Windows.Forms.CheckBox
    Friend WithEvents C1NEIntervalo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents C1NECuotasSoloInteres As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C1NEComision As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkComision As System.Windows.Forms.CheckBox
    Friend WithEvents C1NESeguroVida As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NESeguroDeuda As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkSeguroVida As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeguroDeuda As System.Windows.Forms.CheckBox
    Friend WithEvents C1NEInteres As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents C1fgrdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtCodLineaCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtLineaCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoMin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoMax As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1nRangos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbTipoPlazo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents c1nPlazoMax As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nPlazoMin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrTablaAmortEjec))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.C1NEOtros = New C1.Win.C1Input.C1NumericEdit()
        Me.chkOtros = New System.Windows.Forms.CheckBox()
        Me.C1NESeguroVehiculo = New C1.Win.C1Input.C1NumericEdit()
        Me.chkSeguroVehiculo = New System.Windows.Forms.CheckBox()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbTipoPlazo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c1nRangos = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.C1NEMontoGarantia = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.C1NEIntervalo = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nPlazoMax = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1nMontoMax = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodLineaCredito = New System.Windows.Forms.TextBox()
        Me.txtLineaCredito = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.C1NESeguroDanios = New C1.Win.C1Input.C1NumericEdit()
        Me.chkSeguroDanios = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.C1NEAhorro = New C1.Win.C1Input.C1NumericEdit()
        Me.chkAhorro = New System.Windows.Forms.CheckBox()
        Me.C1NEAportacion = New C1.Win.C1Input.C1NumericEdit()
        Me.chkAportacion = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.C1NECuotasSoloInteres = New C1.Win.C1Input.C1NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C1NEComision = New C1.Win.C1Input.C1NumericEdit()
        Me.chkComision = New System.Windows.Forms.CheckBox()
        Me.C1NESeguroVida = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NESeguroDeuda = New C1.Win.C1Input.C1NumericEdit()
        Me.chkSeguroVida = New System.Windows.Forms.CheckBox()
        Me.chkSeguroDeuda = New System.Windows.Forms.CheckBox()
        Me.C1NEInteres = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nMontoMin = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nPlazoMin = New C1.Win.C1Input.C1NumericEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.C1fgrdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.btnExportar1 = New MetroFramework.Controls.MetroButton()
        Me.btnLimpiar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAceptarLin1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3.SuspendLayout()
        CType(Me.C1NEOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nRangos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1NEMontoGarantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEIntervalo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPlazoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroDanios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEAhorro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEAportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NECuotasSoloInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEComision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroVida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroDeuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPlazoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.C1NEOtros)
        Me.GroupBox3.Controls.Add(Me.chkOtros)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroVehiculo)
        Me.GroupBox3.Controls.Add(Me.chkSeguroVehiculo)
        Me.GroupBox3.Controls.Add(Me.dtpFechaEmision)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.cbTipoPlazo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.c1nRangos)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.c1nPlazoMax)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.c1nMontoMax)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtCodLineaCredito)
        Me.GroupBox3.Controls.Add(Me.txtLineaCredito)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroDanios)
        Me.GroupBox3.Controls.Add(Me.chkSeguroDanios)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.C1NEAhorro)
        Me.GroupBox3.Controls.Add(Me.chkAhorro)
        Me.GroupBox3.Controls.Add(Me.C1NEAportacion)
        Me.GroupBox3.Controls.Add(Me.chkAportacion)
        Me.GroupBox3.Controls.Add(Me.dtpFecha)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.C1NECuotasSoloInteres)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.C1NEComision)
        Me.GroupBox3.Controls.Add(Me.chkComision)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroVida)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroDeuda)
        Me.GroupBox3.Controls.Add(Me.chkSeguroVida)
        Me.GroupBox3.Controls.Add(Me.chkSeguroDeuda)
        Me.GroupBox3.Controls.Add(Me.C1NEInteres)
        Me.GroupBox3.Controls.Add(Me.c1nMontoMin)
        Me.GroupBox3.Controls.Add(Me.c1nPlazoMin)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(604, 304)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parámetros Generales"
        '
        'C1NEOtros
        '
        Me.C1NEOtros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEOtros.CustomFormat = "#0.00"
        Me.C1NEOtros.Enabled = False
        Me.C1NEOtros.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEOtros.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEOtros.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEOtros.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEOtros.Location = New System.Drawing.Point(435, 222)
        Me.C1NEOtros.Name = "C1NEOtros"
        Me.C1NEOtros.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEOtros.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEOtros.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEOtros.Size = New System.Drawing.Size(152, 19)
        Me.C1NEOtros.TabIndex = 98
        Me.C1NEOtros.Tag = Nothing
        Me.C1NEOtros.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEOtros.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkOtros
        '
        Me.chkOtros.Location = New System.Drawing.Point(307, 221)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(136, 15)
        Me.chkOtros.TabIndex = 97
        Me.chkOtros.Text = "Otros"
        '
        'C1NESeguroVehiculo
        '
        Me.C1NESeguroVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroVehiculo.CustomFormat = "#0.00"
        Me.C1NESeguroVehiculo.Enabled = False
        Me.C1NESeguroVehiculo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroVehiculo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroVehiculo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NESeguroVehiculo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroVehiculo.Location = New System.Drawing.Point(149, 222)
        Me.C1NESeguroVehiculo.Name = "C1NESeguroVehiculo"
        Me.C1NESeguroVehiculo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroVehiculo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroVehiculo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroVehiculo.Size = New System.Drawing.Size(152, 19)
        Me.C1NESeguroVehiculo.TabIndex = 96
        Me.C1NESeguroVehiculo.Tag = Nothing
        Me.C1NESeguroVehiculo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NESeguroVehiculo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkSeguroVehiculo
        '
        Me.chkSeguroVehiculo.Location = New System.Drawing.Point(8, 222)
        Me.chkSeguroVehiculo.Name = "chkSeguroVehiculo"
        Me.chkSeguroVehiculo.Size = New System.Drawing.Size(136, 15)
        Me.chkSeguroVehiculo.TabIndex = 95
        Me.chkSeguroVehiculo.Text = "Seguro de Vehiculo"
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(499, 100)
        Me.dtpFechaEmision.MinDate = New Date(1945, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaEmision.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(402, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 15)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Emisión Cuota:"
        '
        'cbTipoPlazo
        '
        Me.cbTipoPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPlazo.Items.AddRange(New Object() {"Meses", "Años"})
        Me.cbTipoPlazo.Location = New System.Drawing.Point(499, 15)
        Me.cbTipoPlazo.Name = "cbTipoPlazo"
        Me.cbTipoPlazo.Size = New System.Drawing.Size(88, 21)
        Me.cbTipoPlazo.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(402, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Tipo de Plazo:"
        '
        'c1nRangos
        '
        Me.c1nRangos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.c1nRangos.Calculator.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c1nRangos.CustomFormat = "####0"
        Me.c1nRangos.DataType = GetType(Short)
        Me.c1nRangos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nRangos.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nRangos.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nRangos.Location = New System.Drawing.Point(499, 73)
        Me.c1nRangos.MaxLength = 3
        Me.c1nRangos.Name = "c1nRangos"
        Me.c1nRangos.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nRangos.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nRangos.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nRangos.Size = New System.Drawing.Size(88, 19)
        Me.c1nRangos.TabIndex = 7
        Me.c1nRangos.Tag = Nothing
        Me.c1nRangos.Value = CType(0, Short)
        Me.c1nRangos.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(402, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Rangos de:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1NEMontoGarantia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.C1NEIntervalo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 45)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Garantías "
        '
        'C1NEMontoGarantia
        '
        Me.C1NEMontoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMontoGarantia.CustomFormat = "###,###,##0.00"
        Me.C1NEMontoGarantia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMontoGarantia.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMontoGarantia.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEMontoGarantia.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMontoGarantia.Location = New System.Drawing.Point(120, 20)
        Me.C1NEMontoGarantia.Name = "C1NEMontoGarantia"
        Me.C1NEMontoGarantia.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMontoGarantia.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMontoGarantia.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMontoGarantia.Size = New System.Drawing.Size(104, 19)
        Me.C1NEMontoGarantia.TabIndex = 23
        Me.C1NEMontoGarantia.Tag = Nothing
        Me.C1NEMontoGarantia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEMontoGarantia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Monto de Garantía"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(297, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Intérvalo"
        Me.Label12.Visible = False
        '
        'C1NEIntervalo
        '
        Me.C1NEIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NEIntervalo.Calculator.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1NEIntervalo.CustomFormat = "##0"
        Me.C1NEIntervalo.DataType = GetType(Short)
        Me.C1NEIntervalo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEIntervalo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEIntervalo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEIntervalo.Location = New System.Drawing.Point(427, 18)
        Me.C1NEIntervalo.MaxLength = 3
        Me.C1NEIntervalo.Name = "C1NEIntervalo"
        Me.C1NEIntervalo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEIntervalo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEIntervalo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NEIntervalo.Size = New System.Drawing.Size(146, 19)
        Me.C1NEIntervalo.TabIndex = 5
        Me.C1NEIntervalo.Tag = Nothing
        Me.C1NEIntervalo.Value = CType(0, Short)
        Me.C1NEIntervalo.Visible = False
        Me.C1NEIntervalo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nPlazoMax
        '
        Me.c1nPlazoMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.c1nPlazoMax.Calculator.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c1nPlazoMax.CustomFormat = "##0"
        Me.c1nPlazoMax.DataType = GetType(Short)
        Me.c1nPlazoMax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nPlazoMax.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazoMax.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nPlazoMax.Location = New System.Drawing.Point(308, 73)
        Me.c1nPlazoMax.MaxLength = 3
        Me.c1nPlazoMax.Name = "c1nPlazoMax"
        Me.c1nPlazoMax.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazoMax.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazoMax.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nPlazoMax.Size = New System.Drawing.Size(88, 19)
        Me.c1nPlazoMax.TabIndex = 6
        Me.c1nPlazoMax.Tag = Nothing
        Me.c1nPlazoMax.Value = CType(0, Short)
        Me.c1nPlazoMax.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(206, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Plazo máximo:"
        '
        'c1nMontoMax
        '
        Me.c1nMontoMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoMax.CustomFormat = "###,###,##0.00"
        Me.c1nMontoMax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoMax.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoMax.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nMontoMax.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoMax.Location = New System.Drawing.Point(104, 73)
        Me.c1nMontoMax.Name = "c1nMontoMax"
        Me.c1nMontoMax.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoMax.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoMax.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoMax.Size = New System.Drawing.Size(96, 19)
        Me.c1nMontoMax.TabIndex = 5
        Me.c1nMontoMax.Tag = Nothing
        Me.c1nMontoMax.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Monto máximo:"
        '
        'txtCodLineaCredito
        '
        Me.txtCodLineaCredito.BackColor = System.Drawing.Color.White
        Me.txtCodLineaCredito.Location = New System.Drawing.Point(104, 20)
        Me.txtCodLineaCredito.MaxLength = 10
        Me.txtCodLineaCredito.Name = "txtCodLineaCredito"
        Me.txtCodLineaCredito.Size = New System.Drawing.Size(64, 20)
        Me.txtCodLineaCredito.TabIndex = 0
        '
        'txtLineaCredito
        '
        Me.txtLineaCredito.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLineaCredito.Location = New System.Drawing.Point(176, 20)
        Me.txtLineaCredito.MaxLength = 255
        Me.txtLineaCredito.Name = "txtLineaCredito"
        Me.txtLineaCredito.Size = New System.Drawing.Size(220, 20)
        Me.txtLineaCredito.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Línea Crediticia:"
        '
        'C1NESeguroDanios
        '
        Me.C1NESeguroDanios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroDanios.CustomFormat = "#0.00"
        Me.C1NESeguroDanios.Enabled = False
        Me.C1NESeguroDanios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroDanios.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroDanios.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NESeguroDanios.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroDanios.Location = New System.Drawing.Point(435, 139)
        Me.C1NESeguroDanios.Name = "C1NESeguroDanios"
        Me.C1NESeguroDanios.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroDanios.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroDanios.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroDanios.Size = New System.Drawing.Size(152, 19)
        Me.C1NESeguroDanios.TabIndex = 14
        Me.C1NESeguroDanios.Tag = Nothing
        Me.C1NESeguroDanios.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NESeguroDanios.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkSeguroDanios
        '
        Me.chkSeguroDanios.Location = New System.Drawing.Point(308, 139)
        Me.chkSeguroDanios.Name = "chkSeguroDanios"
        Me.chkSeguroDanios.Size = New System.Drawing.Size(136, 16)
        Me.chkSeguroDanios.TabIndex = 13
        Me.chkSeguroDanios.Text = "Seguro de Daños (%)"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Teal
        Me.Label14.Location = New System.Drawing.Point(8, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Complementos:"
        '
        'C1NEAhorro
        '
        Me.C1NEAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEAhorro.CustomFormat = "#0.00"
        Me.C1NEAhorro.Enabled = False
        Me.C1NEAhorro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEAhorro.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEAhorro.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEAhorro.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEAhorro.Location = New System.Drawing.Point(435, 194)
        Me.C1NEAhorro.Name = "C1NEAhorro"
        Me.C1NEAhorro.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEAhorro.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEAhorro.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEAhorro.Size = New System.Drawing.Size(152, 19)
        Me.C1NEAhorro.TabIndex = 22
        Me.C1NEAhorro.Tag = Nothing
        Me.C1NEAhorro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEAhorro.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkAhorro
        '
        Me.chkAhorro.Location = New System.Drawing.Point(308, 194)
        Me.chkAhorro.Name = "chkAhorro"
        Me.chkAhorro.Size = New System.Drawing.Size(64, 16)
        Me.chkAhorro.TabIndex = 21
        Me.chkAhorro.Text = "Ahorro"
        '
        'C1NEAportacion
        '
        Me.C1NEAportacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEAportacion.CustomFormat = "#0.00"
        Me.C1NEAportacion.Enabled = False
        Me.C1NEAportacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEAportacion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEAportacion.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEAportacion.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEAportacion.Location = New System.Drawing.Point(150, 167)
        Me.C1NEAportacion.Name = "C1NEAportacion"
        Me.C1NEAportacion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEAportacion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEAportacion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEAportacion.Size = New System.Drawing.Size(152, 19)
        Me.C1NEAportacion.TabIndex = 16
        Me.C1NEAportacion.Tag = Nothing
        Me.C1NEAportacion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEAportacion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkAportacion
        '
        Me.chkAportacion.Location = New System.Drawing.Point(8, 172)
        Me.chkAportacion.Name = "chkAportacion"
        Me.chkAportacion.Size = New System.Drawing.Size(88, 16)
        Me.chkAportacion.TabIndex = 15
        Me.chkAportacion.Text = "Aportación"
        '
        'dtpFecha
        '
        Me.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(308, 101)
        Me.dtpFecha.MinDate = New Date(1945, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 9
        Me.dtpFecha.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(206, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Primera cuota:"
        Me.Label8.Visible = False
        '
        'C1NECuotasSoloInteres
        '
        Me.C1NECuotasSoloInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NECuotasSoloInteres.Calculator.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1NECuotasSoloInteres.CustomFormat = "####0"
        Me.C1NECuotasSoloInteres.DataType = GetType(Short)
        Me.C1NECuotasSoloInteres.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NECuotasSoloInteres.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NECuotasSoloInteres.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NECuotasSoloInteres.Location = New System.Drawing.Point(104, 100)
        Me.C1NECuotasSoloInteres.MaxLength = 3
        Me.C1NECuotasSoloInteres.Name = "C1NECuotasSoloInteres"
        Me.C1NECuotasSoloInteres.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NECuotasSoloInteres.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NECuotasSoloInteres.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NECuotasSoloInteres.Size = New System.Drawing.Size(88, 19)
        Me.C1NECuotasSoloInteres.TabIndex = 8
        Me.C1NECuotasSoloInteres.Tag = Nothing
        Me.C1NECuotasSoloInteres.Value = CType(0, Short)
        Me.C1NECuotasSoloInteres.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 26)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Número de cuotas sólo Intereses:"
        '
        'C1NEComision
        '
        Me.C1NEComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEComision.CustomFormat = "#0.00"
        Me.C1NEComision.Enabled = False
        Me.C1NEComision.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEComision.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEComision.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEComision.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEComision.Location = New System.Drawing.Point(150, 194)
        Me.C1NEComision.Name = "C1NEComision"
        Me.C1NEComision.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEComision.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEComision.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEComision.Size = New System.Drawing.Size(152, 19)
        Me.C1NEComision.TabIndex = 20
        Me.C1NEComision.Tag = Nothing
        Me.C1NEComision.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEComision.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkComision
        '
        Me.chkComision.Location = New System.Drawing.Point(8, 194)
        Me.chkComision.Name = "chkComision"
        Me.chkComision.Size = New System.Drawing.Size(136, 16)
        Me.chkComision.TabIndex = 19
        Me.chkComision.Text = "Comisión por Manejo"
        '
        'C1NESeguroVida
        '
        Me.C1NESeguroVida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroVida.CustomFormat = "#0.00"
        Me.C1NESeguroVida.Enabled = False
        Me.C1NESeguroVida.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroVida.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroVida.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NESeguroVida.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroVida.Location = New System.Drawing.Point(435, 166)
        Me.C1NESeguroVida.Name = "C1NESeguroVida"
        Me.C1NESeguroVida.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroVida.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroVida.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroVida.Size = New System.Drawing.Size(152, 19)
        Me.C1NESeguroVida.TabIndex = 18
        Me.C1NESeguroVida.Tag = Nothing
        Me.C1NESeguroVida.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NESeguroVida.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NESeguroDeuda
        '
        Me.C1NESeguroDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroDeuda.CustomFormat = "#0.00"
        Me.C1NESeguroDeuda.Enabled = False
        Me.C1NESeguroDeuda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroDeuda.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroDeuda.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NESeguroDeuda.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroDeuda.Location = New System.Drawing.Point(150, 140)
        Me.C1NESeguroDeuda.Name = "C1NESeguroDeuda"
        Me.C1NESeguroDeuda.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroDeuda.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroDeuda.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroDeuda.Size = New System.Drawing.Size(152, 19)
        Me.C1NESeguroDeuda.TabIndex = 12
        Me.C1NESeguroDeuda.Tag = Nothing
        Me.C1NESeguroDeuda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NESeguroDeuda.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkSeguroVida
        '
        Me.chkSeguroVida.Location = New System.Drawing.Point(308, 172)
        Me.chkSeguroVida.Name = "chkSeguroVida"
        Me.chkSeguroVida.Size = New System.Drawing.Size(128, 15)
        Me.chkSeguroVida.TabIndex = 17
        Me.chkSeguroVida.Text = "Seguro de Vida (%)"
        '
        'chkSeguroDeuda
        '
        Me.chkSeguroDeuda.Location = New System.Drawing.Point(8, 140)
        Me.chkSeguroDeuda.Name = "chkSeguroDeuda"
        Me.chkSeguroDeuda.Size = New System.Drawing.Size(136, 15)
        Me.chkSeguroDeuda.TabIndex = 11
        Me.chkSeguroDeuda.Text = "Seguro de Deuda (%)"
        '
        'C1NEInteres
        '
        Me.C1NEInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEInteres.CustomFormat = "#0.00"
        Me.C1NEInteres.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEInteres.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEInteres.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEInteres.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEInteres.Location = New System.Drawing.Point(499, 46)
        Me.C1NEInteres.Name = "C1NEInteres"
        Me.C1NEInteres.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEInteres.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEInteres.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEInteres.Size = New System.Drawing.Size(88, 19)
        Me.C1NEInteres.TabIndex = 4
        Me.C1NEInteres.Tag = Nothing
        Me.C1NEInteres.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nMontoMin
        '
        Me.c1nMontoMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoMin.CustomFormat = "###,###,##0.00"
        Me.c1nMontoMin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoMin.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoMin.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nMontoMin.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoMin.Location = New System.Drawing.Point(104, 46)
        Me.c1nMontoMin.Name = "c1nMontoMin"
        Me.c1nMontoMin.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoMin.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoMin.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoMin.Size = New System.Drawing.Size(96, 19)
        Me.c1nMontoMin.TabIndex = 2
        Me.c1nMontoMin.Tag = Nothing
        Me.c1nMontoMin.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nPlazoMin
        '
        Me.c1nPlazoMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.c1nPlazoMin.Calculator.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c1nPlazoMin.CustomFormat = "##0"
        Me.c1nPlazoMin.DataType = GetType(Short)
        Me.c1nPlazoMin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nPlazoMin.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazoMin.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nPlazoMin.Location = New System.Drawing.Point(308, 46)
        Me.c1nPlazoMin.MaxLength = 3
        Me.c1nPlazoMin.Name = "c1nPlazoMin"
        Me.c1nPlazoMin.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazoMin.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazoMin.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nPlazoMin.Size = New System.Drawing.Size(88, 19)
        Me.c1nPlazoMin.TabIndex = 3
        Me.c1nPlazoMin.Tag = Nothing
        Me.c1nPlazoMin.Value = CType(0, Short)
        Me.c1nPlazoMin.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(206, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Plazo mínimo:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(402, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Interés (%):"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Monto mínimo:"
        '
        'C1fgrdDetalle
        '
        Me.C1fgrdDetalle.AllowEditing = False
        Me.C1fgrdDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdDetalle.ColumnInfo = "9,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdDetalle.Location = New System.Drawing.Point(23, 354)
        Me.C1fgrdDetalle.Name = "C1fgrdDetalle"
        Me.C1fgrdDetalle.Rows.Count = 2
        Me.C1fgrdDetalle.Rows.DefaultSize = 19
        Me.C1fgrdDetalle.Size = New System.Drawing.Size(604, 179)
        Me.C1fgrdDetalle.StyleInfo = resources.GetString("C1fgrdDetalle.StyleInfo")
        Me.C1fgrdDetalle.TabIndex = 1
        '
        'btnExportar1
        '
        Me.btnExportar1.Location = New System.Drawing.Point(552, 539)
        Me.btnExportar1.Name = "btnExportar1"
        Me.btnExportar1.Size = New System.Drawing.Size(75, 28)
        Me.btnExportar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnExportar1.TabIndex = 187
        Me.btnExportar1.Text = "Exportar"
        Me.btnExportar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnExportar1.UseSelectable = True
        Me.btnExportar1.UseStyleColors = True
        '
        'btnLimpiar1
        '
        Me.btnLimpiar1.Location = New System.Drawing.Point(471, 539)
        Me.btnLimpiar1.Name = "btnLimpiar1"
        Me.btnLimpiar1.Size = New System.Drawing.Size(75, 28)
        Me.btnLimpiar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnLimpiar1.TabIndex = 186
        Me.btnLimpiar1.Text = "&Limpiar"
        Me.btnLimpiar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLimpiar1.UseSelectable = True
        Me.btnLimpiar1.UseStyleColors = True
        '
        'btnAceptarLin1
        '
        Me.btnAceptarLin1.Location = New System.Drawing.Point(390, 539)
        Me.btnAceptarLin1.Name = "btnAceptarLin1"
        Me.btnAceptarLin1.Size = New System.Drawing.Size(75, 28)
        Me.btnAceptarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptarLin1.TabIndex = 185
        Me.btnAceptarLin1.Text = "Calcular"
        Me.btnAceptarLin1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAceptarLin1.UseSelectable = True
        Me.btnAceptarLin1.UseStyleColors = True
        '
        'frmCrTablaAmortEjec
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(647, 600)
        Me.Controls.Add(Me.btnExportar1)
        Me.Controls.Add(Me.btnLimpiar1)
        Me.Controls.Add(Me.btnAceptarLin1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.C1fgrdDetalle)
        Me.MaximumSize = New System.Drawing.Size(647, 600)
        Me.MinimumSize = New System.Drawing.Size(647, 600)
        Me.Name = "frmCrTablaAmortEjec"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cálculo de tablas de cuotas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.C1NEOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nRangos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1NEMontoGarantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEIntervalo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPlazoMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroDanios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEAhorro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEAportacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NECuotasSoloInteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEComision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroVida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroDeuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEInteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPlazoMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property TAmortiza() As DataSet
        Get
            Return ds
        End Get
        Set(ByVal Value As DataSet)
            ds = Value
        End Set
    End Property

    Private Sub txtCodLineaCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodLineaCredito.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Try
                oPerif = New wrCredito.wsLibCred
                ds = oPerif.ConsultarLineaCreditos("*", "CodLineaCredito='" & Trim(Me.txtCodLineaCredito.Text) & "'", "CodLineaCredito", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtLineaCredito.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                Else
                    txtCodLineaCredito_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtCodLineaCredito_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodLineaCredito.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Líneas de Crédito"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarLineaCreditos("*", "", "CodLineaCredito", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodLineaCredito.Text = ofrm.Resultado.Trim
            Me.txtLineaCredito.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkSeguroDeuda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeguroDeuda.CheckedChanged
        If Me.chkSeguroDeuda.Checked = False Then
            Me.C1NESeguroDeuda.Value = 0
            Me.C1NESeguroDeuda.Enabled = False
        Else
            Dim oPar As New wrAsociados.wsLibAsoc, dsPar As New DataSet, dr As DataRow
            dsPar = oPar.ConsultarParametros("SeguroDeuda", "", "SeguroDeuda", sUsuario, sPassword, sSucursal)
            If dsPar.Tables(0).Rows.Count > 0 Then
                dr = dsPar.Tables(0).Rows(0)
                Me.C1NESeguroDeuda.Value = IIf(IsDBNull(dr("SeguroDeuda")), 0, dr("SeguroDeuda"))
            End If
            Me.chkSeguroDeuda.Enabled = True
            Me.C1NESeguroDeuda.ReadOnly = True
        End If
    End Sub

    Private Sub chkSeguroVida_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSeguroVida.CheckedChanged
        If Me.chkSeguroVida.Checked = False Then
            Me.C1NESeguroVida.Enabled = False
        Else
            Me.C1NESeguroVida.Enabled = True
        End If
    End Sub

    Private Sub chkComision_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkComision.CheckedChanged
        If Me.chkComision.Checked = False Then
            Me.C1NEComision.Enabled = False
        Else
            Me.C1NEComision.Enabled = True
        End If
    End Sub

    Private Sub chkAportacion_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAportacion.CheckedChanged
        If Me.chkAportacion.Checked = False Then
            Me.C1NEAportacion.Enabled = False
        Else
            Me.C1NEAportacion.Enabled = True
        End If
    End Sub

    Private Sub chkAhorro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAhorro.CheckedChanged
        If Me.chkAhorro.Checked = False Then
            Me.C1NEAhorro.Enabled = False
        Else
            Me.C1NEAhorro.Enabled = True
        End If
    End Sub

    Private Sub C1NEMontoGarantia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1NEMontoGarantia.TextChanged
        If Me.C1NEMontoGarantia.Value > 0 Then
            Me.chkSeguroDanios.Checked = True
            Me.C1NESeguroDanios.Value = 0.0
        End If
    End Sub

    Private Sub chkSeguroDanios_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSeguroDanios.CheckedChanged
        If Me.chkSeguroDanios.Checked = False Then
            Me.C1NESeguroDanios.Value = 0
            Me.C1NESeguroDanios.Enabled = False
        Else
            Dim oPar As New wrAsociados.wsLibAsoc, dsPar As New DataSet, dr As DataRow
            dsPar = oPar.ConsultarParametros("SeguroDanios", "", "SeguroDanios", sUsuario, sPassword, sSucursal)
            If dsPar.Tables(0).Rows.Count > 0 Then
                dr = dsPar.Tables(0).Rows(0)
                Me.C1NESeguroDanios.Value = IIf(IsDBNull(dr("SeguroDanios")), 0, dr("SeguroDanios"))
            End If
            Me.C1NESeguroDanios.Enabled = True
            Me.C1NESeguroDanios.ReadOnly = True
        End If
    End Sub



    Private Sub frmCrTablaAmortEjec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.dtpFechaEmision.Value = Now
        Me.cbTipoPlazo.SelectedIndex = 0
    End Sub

    Private Function Exportar(ByVal ds As DataSet) As String
        Dim f As Integer, mTitulo As String, x As Integer, y As Integer, mCadena As String, vArchivo As String, dr As DataRow, dt As DataColumn
        f = FreeFile()
        sfd.Filter = "Archivo Exportación a Excel (*.csv)|*.csv"
        sfd.FileName = ""
        sfd.DefaultExt = ".csv"
        sfd.Title = "Exportar Tabla de cuotas al Archivo..."
        sfd.ShowDialog()
        If Microsoft.VisualBasic.Right(sfd.FileName, 4) <> ".csv" Then
            MessageBox.Show("La extensión del archivo debe ser .csv", "Exportación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Function
            Return ""
        End If
        If Len(sfd.FileName) > 0 Then
            vArchivo = sfd.FileName
            FileOpen(f, vArchivo, OpenMode.Output)
            mTitulo = ""
            mCadena = ""
            x = 0
            For Each dt In ds.Tables(0).Columns
                x = x + 1
                If mTitulo.Trim = "" Then
                    mTitulo = dt.ColumnName
                Else
                    mTitulo = mTitulo & "," & dt.ColumnName
                End If
            Next
            PrintLine(f, "Fecha de Exportación:" & "," & "," & Now)
            PrintLine(f, "Tabla de Cuotas")
            PrintLine(f, mTitulo)
            For Each dr In ds.Tables(0).Rows
                For y = 0 To x - 1
                    If mCadena.Trim = "" Then
                        mCadena = dr(y)
                    Else
                        mCadena = mCadena & "," & dr(y)
                    End If
                Next
                PrintLine(f, mCadena)
                mCadena = ""
            Next
            FileClose(f)

        End If
        'HACK: Debe retornar algo en cualquier path
        Return ""
    End Function

    Private Sub btnAceptarLin1_Click(sender As Object, e As EventArgs) Handles btnAceptarLin1.Click
        Try
            Dim oPrest As New wrPrestamo.wsLibPrest
            If Me.C1NECuotasSoloInteres.Value < Me.c1nPlazoMax.Value Then
                Me.TAmortiza = oPrest.GeneraTAmortizaEjec(Me.c1nMontoMax.Text, Me.c1nMontoMin.Text, Me.c1nPlazoMin.Text, Me.c1nPlazoMax.Text, Me.cbTipoPlazo.SelectedIndex, Me.txtCodLineaCredito.Text.Trim, Me.txtLineaCredito.Text.Trim, C1NEInteres.Text, Me.c1nRangos.Text, dtpFecha.Value, Me.C1NESeguroDeuda.Value, Me.C1NEMontoGarantia.Value, Me.C1NESeguroDanios.Value, Me.C1NESeguroVida.Value, 0, Me.C1NEAportacion.Value, Me.C1NEAhorro.Value, Me.C1NEComision.Value, Me.C1NECuotasSoloInteres.Value, Me.C1NEIntervalo.Value, sUsuario, sPassword, sSucursal, C1NESeguroVehiculo.Value, C1NEOtros.Value)
                C1fgrdDetalle.DataSource = Me.TAmortiza.Tables(0).DefaultView
            Else
                MsgBox("El número de Cuotas con aplicación de sólo interés no puede ser igual o mayor al número de pagos del Préstamo.", MsgBoxStyle.Critical, "Validación del Sistema")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnLimpiar1_Click(sender As Object, e As EventArgs) Handles btnLimpiar1.Click
        Try
            C1fgrdDetalle.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
            C1fgrdDetalle.DataSource = Nothing
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnExportar1_Click(sender As Object, e As EventArgs) Handles btnExportar1.Click
        Dim saveFileDialog1 As New SaveFileDialog
        Try
            Exportar(Me.TAmortiza)
            MessageBox.Show("Archivo generdo con éxito.", "Exportación Tabla de Cuotas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    'LUIS ALVARENGA
    Private Sub chkOtros_CheckedChanged(sender As Object, e As EventArgs) Handles chkOtros.CheckedChanged
        If Me.chkOtros.Checked = False Then
            Me.C1NEOtros.Enabled = False
        Else
            Me.C1NEOtros.Enabled = True
        End If
    End Sub

    Private Sub chkSeguroVehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeguroVehiculo.CheckedChanged
        If Me.chkSeguroVehiculo.Checked = False Then
            Me.C1NESeguroVehiculo.Enabled = False
        Else
            Me.C1NESeguroVehiculo.Enabled = True
        End If
    End Sub
End Class