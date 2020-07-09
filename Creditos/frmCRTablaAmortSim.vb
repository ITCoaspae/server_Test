Public Class frmCRTablaAmortSim
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pTasaInteres As Double
    Public pSaldo As Double, pSaldoSeguroDeuda As Double, pSaldoSeguroDaniosyLA As Double
    Public pSaldoSeguroVida As Double, pSaldoSeguroDesempleo As Double
    Public pSaldoComisionManejo As Double, pSaldoOtros As Double
    Public pSaldoDiaInteres As Double
    Friend WithEvents btnAceptarLin1 As MetroFramework.Controls.MetroButton
    Friend WithEvents C1NEOtros As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkOtros As CheckBox
    Friend WithEvents C1NESeguroVehiculo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkSeguroVehiculo As CheckBox
    Private vCodPrestamo As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents C1NEComision As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkComision As System.Windows.Forms.CheckBox
    Friend WithEvents C1NESeguroVida As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents C1NESeguroDeuda As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkSeguroVida As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeguroDeuda As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C1NESeguroDanios As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents C1NEMontoGarantia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkSeguroDanios As System.Windows.Forms.CheckBox
    Friend WithEvents C1NENumPagos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.C1NEOtros = New C1.Win.C1Input.C1NumericEdit()
        Me.chkOtros = New System.Windows.Forms.CheckBox()
        Me.C1NESeguroVehiculo = New C1.Win.C1Input.C1NumericEdit()
        Me.chkSeguroVehiculo = New System.Windows.Forms.CheckBox()
        Me.btnAceptarLin1 = New MetroFramework.Controls.MetroButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.C1NEComision = New C1.Win.C1Input.C1NumericEdit()
        Me.chkComision = New System.Windows.Forms.CheckBox()
        Me.C1NESeguroVida = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C1NESeguroDeuda = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkSeguroVida = New System.Windows.Forms.CheckBox()
        Me.chkSeguroDeuda = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.C1NESeguroDanios = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.C1NEMontoGarantia = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkSeguroDanios = New System.Windows.Forms.CheckBox()
        Me.C1NENumPagos = New C1.Win.C1Input.C1NumericEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.C1NEOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEComision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroVida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroDeuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1NESeguroDanios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMontoGarantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NENumPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.C1NEOtros)
        Me.GroupBox3.Controls.Add(Me.chkOtros)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroVehiculo)
        Me.GroupBox3.Controls.Add(Me.chkSeguroVehiculo)
        Me.GroupBox3.Controls.Add(Me.btnAceptarLin1)
        Me.GroupBox3.Controls.Add(Me.dtpFecha)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.C1NEComision)
        Me.GroupBox3.Controls.Add(Me.chkComision)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroVida)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroDeuda)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.chkSeguroVida)
        Me.GroupBox3.Controls.Add(Me.chkSeguroDeuda)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.C1NENumPagos)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 197)
        Me.GroupBox3.TabIndex = 25
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
        Me.C1NEOtros.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEOtros.Location = New System.Drawing.Point(432, 51)
        Me.C1NEOtros.Name = "C1NEOtros"
        Me.C1NEOtros.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEOtros.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEOtros.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEOtros.ShowDropDownButton = False
        Me.C1NEOtros.ShowUpDownButtons = False
        Me.C1NEOtros.Size = New System.Drawing.Size(88, 21)
        Me.C1NEOtros.TabIndex = 190
        Me.C1NEOtros.Tag = Nothing
        Me.C1NEOtros.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'chkOtros
        '
        Me.chkOtros.Location = New System.Drawing.Point(270, 56)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(112, 16)
        Me.chkOtros.TabIndex = 189
        Me.chkOtros.Text = "Otros"
        '
        'C1NESeguroVehiculo
        '
        Me.C1NESeguroVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroVehiculo.CustomFormat = "#0.00"
        Me.C1NESeguroVehiculo.Enabled = False
        Me.C1NESeguroVehiculo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroVehiculo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroVehiculo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroVehiculo.Location = New System.Drawing.Point(168, 110)
        Me.C1NESeguroVehiculo.Name = "C1NESeguroVehiculo"
        Me.C1NESeguroVehiculo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroVehiculo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroVehiculo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroVehiculo.ShowDropDownButton = False
        Me.C1NESeguroVehiculo.ShowUpDownButtons = False
        Me.C1NESeguroVehiculo.Size = New System.Drawing.Size(88, 21)
        Me.C1NESeguroVehiculo.TabIndex = 188
        Me.C1NESeguroVehiculo.Tag = Nothing
        Me.C1NESeguroVehiculo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'chkSeguroVehiculo
        '
        Me.chkSeguroVehiculo.Location = New System.Drawing.Point(6, 109)
        Me.chkSeguroVehiculo.Name = "chkSeguroVehiculo"
        Me.chkSeguroVehiculo.Size = New System.Drawing.Size(120, 19)
        Me.chkSeguroVehiculo.TabIndex = 187
        Me.chkSeguroVehiculo.Text = "Seguro de Vehiculo"
        '
        'btnAceptarLin1
        '
        Me.btnAceptarLin1.Location = New System.Drawing.Point(446, 110)
        Me.btnAceptarLin1.Name = "btnAceptarLin1"
        Me.btnAceptarLin1.Size = New System.Drawing.Size(75, 28)
        Me.btnAceptarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptarLin1.TabIndex = 186
        Me.btnAceptarLin1.Text = "Calcular"
        Me.btnAceptarLin1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAceptarLin1.UseSelectable = True
        Me.btnAceptarLin1.UseStyleColors = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(433, 81)
        Me.dtpFecha.MinDate = New Date(1945, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(270, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Fecha Primera cuota:"
        '
        'C1NEComision
        '
        Me.C1NEComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEComision.CustomFormat = "#0.00"
        Me.C1NEComision.Enabled = False
        Me.C1NEComision.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEComision.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEComision.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEComision.Location = New System.Drawing.Point(432, 24)
        Me.C1NEComision.Name = "C1NEComision"
        Me.C1NEComision.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEComision.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEComision.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEComision.ShowDropDownButton = False
        Me.C1NEComision.ShowUpDownButtons = False
        Me.C1NEComision.Size = New System.Drawing.Size(88, 21)
        Me.C1NEComision.TabIndex = 11
        Me.C1NEComision.Tag = Nothing
        Me.C1NEComision.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'chkComision
        '
        Me.chkComision.Location = New System.Drawing.Point(272, 24)
        Me.chkComision.Name = "chkComision"
        Me.chkComision.Size = New System.Drawing.Size(136, 16)
        Me.chkComision.TabIndex = 10
        Me.chkComision.Text = "Comisión por Manejo"
        '
        'C1NESeguroVida
        '
        Me.C1NESeguroVida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroVida.CustomFormat = "#0.00"
        Me.C1NESeguroVida.Enabled = False
        Me.C1NESeguroVida.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroVida.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroVida.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroVida.Location = New System.Drawing.Point(168, 80)
        Me.C1NESeguroVida.Name = "C1NESeguroVida"
        Me.C1NESeguroVida.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroVida.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroVida.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroVida.ShowDropDownButton = False
        Me.C1NESeguroVida.ShowUpDownButtons = False
        Me.C1NESeguroVida.Size = New System.Drawing.Size(88, 21)
        Me.C1NESeguroVida.TabIndex = 9
        Me.C1NESeguroVida.Tag = Nothing
        Me.C1NESeguroVida.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(136, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "--> %"
        '
        'C1NESeguroDeuda
        '
        Me.C1NESeguroDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroDeuda.CustomFormat = "#0.00"
        Me.C1NESeguroDeuda.Enabled = False
        Me.C1NESeguroDeuda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroDeuda.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroDeuda.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroDeuda.Location = New System.Drawing.Point(168, 51)
        Me.C1NESeguroDeuda.Name = "C1NESeguroDeuda"
        Me.C1NESeguroDeuda.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroDeuda.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroDeuda.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroDeuda.ShowDropDownButton = False
        Me.C1NESeguroDeuda.ShowUpDownButtons = False
        Me.C1NESeguroDeuda.Size = New System.Drawing.Size(88, 21)
        Me.C1NESeguroDeuda.TabIndex = 7
        Me.C1NESeguroDeuda.Tag = Nothing
        Me.C1NESeguroDeuda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(136, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "--> %"
        '
        'chkSeguroVida
        '
        Me.chkSeguroVida.Location = New System.Drawing.Point(6, 79)
        Me.chkSeguroVida.Name = "chkSeguroVida"
        Me.chkSeguroVida.Size = New System.Drawing.Size(112, 16)
        Me.chkSeguroVida.TabIndex = 8
        Me.chkSeguroVida.Text = "Seguro de Vida"
        '
        'chkSeguroDeuda
        '
        Me.chkSeguroDeuda.Location = New System.Drawing.Point(6, 51)
        Me.chkSeguroDeuda.Name = "chkSeguroDeuda"
        Me.chkSeguroDeuda.Size = New System.Drawing.Size(112, 16)
        Me.chkSeguroDeuda.TabIndex = 6
        Me.chkSeguroDeuda.Text = "Seguro de Deuda"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1NESeguroDanios)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.C1NEMontoGarantia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkSeguroDanios)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 56)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Garantías "
        '
        'C1NESeguroDanios
        '
        Me.C1NESeguroDanios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroDanios.CustomFormat = "#0.00"
        Me.C1NESeguroDanios.Enabled = False
        Me.C1NESeguroDanios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroDanios.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroDanios.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroDanios.Location = New System.Drawing.Point(440, 24)
        Me.C1NESeguroDanios.Name = "C1NESeguroDanios"
        Me.C1NESeguroDanios.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroDanios.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroDanios.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroDanios.ShowDropDownButton = False
        Me.C1NESeguroDanios.ShowUpDownButtons = False
        Me.C1NESeguroDanios.Size = New System.Drawing.Size(88, 21)
        Me.C1NESeguroDanios.TabIndex = 19
        Me.C1NESeguroDanios.Tag = Nothing
        Me.C1NESeguroDanios.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(408, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "--> %"
        '
        'C1NEMontoGarantia
        '
        Me.C1NEMontoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMontoGarantia.CustomFormat = "###,###,##0.00"
        Me.C1NEMontoGarantia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMontoGarantia.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMontoGarantia.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMontoGarantia.Location = New System.Drawing.Point(120, 24)
        Me.C1NEMontoGarantia.Name = "C1NEMontoGarantia"
        Me.C1NEMontoGarantia.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMontoGarantia.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMontoGarantia.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMontoGarantia.ShowDropDownButton = False
        Me.C1NEMontoGarantia.ShowUpDownButtons = False
        Me.C1NEMontoGarantia.Size = New System.Drawing.Size(136, 21)
        Me.C1NEMontoGarantia.TabIndex = 17
        Me.C1NEMontoGarantia.Tag = Nothing
        Me.C1NEMontoGarantia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Monto de Garantía"
        '
        'chkSeguroDanios
        '
        Me.chkSeguroDanios.Location = New System.Drawing.Point(280, 26)
        Me.chkSeguroDanios.Name = "chkSeguroDanios"
        Me.chkSeguroDanios.Size = New System.Drawing.Size(112, 16)
        Me.chkSeguroDanios.TabIndex = 18
        Me.chkSeguroDanios.Text = "Seguro de Daños"
        '
        'C1NENumPagos
        '
        Me.C1NENumPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NENumPagos.CalculatorButtonStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1NENumPagos.CustomFormat = "##0"
        Me.C1NENumPagos.DataType = GetType(Short)
        Me.C1NENumPagos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NENumPagos.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NENumPagos.Increment = CType(1, Short)
        Me.C1NENumPagos.Location = New System.Drawing.Point(168, 24)
        Me.C1NENumPagos.MaxLength = 3
        Me.C1NENumPagos.Name = "C1NENumPagos"
        Me.C1NENumPagos.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NENumPagos.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NENumPagos.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NENumPagos.ShowDropDownButton = False
        Me.C1NENumPagos.ShowUpDownButtons = False
        Me.C1NENumPagos.Size = New System.Drawing.Size(88, 21)
        Me.C1NENumPagos.TabIndex = 3
        Me.C1NENumPagos.Tag = Nothing
        Me.C1NENumPagos.Value = CType(0, Short)
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Núm.Pagos"
        '
        'frmCRTablaAmortSim
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(610, 264)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(610, 264)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(610, 264)
        Me.Name = "frmCRTablaAmortSim"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Amortización - Créditos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.C1NEOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEComision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroVida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroDeuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1NESeguroDanios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMontoGarantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NENumPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property CodPrestamo() As String
        Get
            Return vCodPrestamo
        End Get
        Set(ByVal Value As String)
            vCodPrestamo = Value
        End Set
    End Property


    Private Sub btnAceptarLin1_Click(sender As Object, e As EventArgs) Handles btnAceptarLin1.Click
        Try
            Dim oPrest As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim dsPRPrest As New Data.DataSet
            Dim dsTAm As New Data.DataSet
            'Dim dr As DataRow
            Dim ofrm As New frmCBConsultaTablaAmortizaSimulada

            dsTAm = oPrest.GeneraTAmortizaSimulada(pSaldo, pTasaInteres, C1NENumPagos.Text, dtpFecha.Value, Me.C1NESeguroDeuda.Value, Me.C1NEMontoGarantia.Value, Me.C1NESeguroDanios.Value, Me.C1NESeguroVida.Value, pSaldoSeguroDesempleo, 0, 0, Me.C1NEComision.Value, 1, 1, sUsuario, sPassword, sSucursal, C1NESeguroVehiculo.Value, C1NEOtros.Value)
            ofrm.Datos = dsTAm
            ofrm.CodPrestamo = vCodPrestamo
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub chkSeguroDeuda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeguroDeuda.CheckedChanged
        If Me.chkSeguroDeuda.Checked = False Then
            Me.C1NESeguroDeuda.Enabled = False
        Else
            Me.C1NESeguroDeuda.Enabled = True
        End If
    End Sub



    Private Sub chkSeguroVida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeguroVida.CheckedChanged
        If Me.chkSeguroVida.Checked = False Then
            Me.C1NESeguroVida.Enabled = False
        Else
            Me.C1NESeguroVida.Enabled = True
        End If
    End Sub

    Private Sub chkComision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkComision.CheckedChanged
        If Me.chkComision.Checked = False Then
            Me.C1NEComision.Enabled = False
        Else
            Me.C1NEComision.Enabled = True
        End If
    End Sub

    Private Sub chkSeguroDanios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeguroDanios.CheckedChanged
        If Me.chkSeguroDanios.Checked = False Then
            Me.C1NESeguroDanios.Enabled = False
        Else
            Me.C1NESeguroDanios.Enabled = True
        End If
    End Sub
    'LUIS ALVARENGA

    Private Sub chkSeguroVehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeguroVehiculo.CheckedChanged
        If Me.chkSeguroVehiculo.Checked = False Then
            Me.C1NESeguroVehiculo.Enabled = False
        Else
            Me.C1NESeguroVehiculo.Enabled = True
        End If
    End Sub
    Private Sub chkOtros_CheckedChanged(sender As Object, e As EventArgs) Handles chkOtros.CheckedChanged
        If Me.chkOtros.Checked = False Then
            Me.C1NEOtros.Enabled = False
        Else
            Me.C1NEOtros.Enabled = True
        End If
    End Sub
End Class
