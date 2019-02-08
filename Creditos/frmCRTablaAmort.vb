Public Class frmCRTablaAmort
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Private ds As New DataSet, vCodPrestamo As String, vNombre As String, vReasignacion As Boolean, vVal As Boolean
    Public vCuota As Double
    Friend WithEvents btnLimpiar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btPlanPago1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAceptarLin1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnExportar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAsignar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents C1NEOtros As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkOtros As CheckBox
    Friend WithEvents C1NESeguroVehiculo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkSeguroVehiculo As CheckBox
    Friend WithEvents btEdit1 As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) '' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents C1NENumPagos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEInteres As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkSeguroDeuda As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C1fgrdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1NESeguroDeuda As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents C1NEComision As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NESeguroVida As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEMontoGarantia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NECuotasSoloInteres As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEAportacion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEAhorro As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEIntervalo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkComision As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeguroVida As System.Windows.Forms.CheckBox
    Friend WithEvents chkAportacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkAhorro As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents C1NESeguroDanios As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkSeguroDanios As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents c1nAbonoCapital As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nUltimaCuota As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkEdit As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCRTablaAmort))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.C1NEOtros = New C1.Win.C1Input.C1NumericEdit()
        Me.chkOtros = New System.Windows.Forms.CheckBox()
        Me.C1NESeguroVehiculo = New C1.Win.C1Input.C1NumericEdit()
        Me.chkSeguroVehiculo = New System.Windows.Forms.CheckBox()
        Me.btEdit1 = New MetroFramework.Controls.MetroButton()
        Me.chkEdit = New System.Windows.Forms.CheckBox()
        Me.c1nAbonoCapital = New C1.Win.C1Input.C1NumericEdit()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.c1nUltimaCuota = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C1NESeguroDanios = New C1.Win.C1Input.C1NumericEdit()
        Me.chkSeguroDanios = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.C1NEAhorro = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkAhorro = New System.Windows.Forms.CheckBox()
        Me.C1NEAportacion = New C1.Win.C1Input.C1NumericEdit()
        Me.chkAportacion = New System.Windows.Forms.CheckBox()
        Me.C1NEIntervalo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.C1NECuotasSoloInteres = New C1.Win.C1Input.C1NumericEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.C1NEMontoGarantia = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C1NEComision = New C1.Win.C1Input.C1NumericEdit()
        Me.chkComision = New System.Windows.Forms.CheckBox()
        Me.C1NESeguroVida = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NESeguroDeuda = New C1.Win.C1Input.C1NumericEdit()
        Me.chkSeguroVida = New System.Windows.Forms.CheckBox()
        Me.chkSeguroDeuda = New System.Windows.Forms.CheckBox()
        Me.C1NEInteres = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NENumPagos = New C1.Win.C1Input.C1NumericEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.C1fgrdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnLimpiar1 = New MetroFramework.Controls.MetroButton()
        Me.btPlanPago1 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btnAceptarLin1 = New MetroFramework.Controls.MetroButton()
        Me.btnExportar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAsignar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3.SuspendLayout()
        CType(Me.C1NEOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nAbonoCapital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nUltimaCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroDanios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEAhorro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEAportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEIntervalo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NECuotasSoloInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1NEMontoGarantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEComision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroVida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroDeuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NENumPagos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox3.Controls.Add(Me.btEdit1)
        Me.GroupBox3.Controls.Add(Me.chkEdit)
        Me.GroupBox3.Controls.Add(Me.c1nAbonoCapital)
        Me.GroupBox3.Controls.Add(Me.dtpFechaEmision)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.c1nUltimaCuota)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroDanios)
        Me.GroupBox3.Controls.Add(Me.chkSeguroDanios)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.C1NEAhorro)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.chkAhorro)
        Me.GroupBox3.Controls.Add(Me.C1NEAportacion)
        Me.GroupBox3.Controls.Add(Me.chkAportacion)
        Me.GroupBox3.Controls.Add(Me.C1NEIntervalo)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.dtpFecha)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.C1NECuotasSoloInteres)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.C1NEComision)
        Me.GroupBox3.Controls.Add(Me.chkComision)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroVida)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroDeuda)
        Me.GroupBox3.Controls.Add(Me.chkSeguroVida)
        Me.GroupBox3.Controls.Add(Me.chkSeguroDeuda)
        Me.GroupBox3.Controls.Add(Me.C1NEInteres)
        Me.GroupBox3.Controls.Add(Me.C1NEMonto)
        Me.GroupBox3.Controls.Add(Me.C1NENumPagos)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(738, 361)
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
        Me.C1NEOtros.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEOtros.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEOtros.Location = New System.Drawing.Point(529, 218)
        Me.C1NEOtros.Name = "C1NEOtros"
        Me.C1NEOtros.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEOtros.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEOtros.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEOtros.Size = New System.Drawing.Size(186, 23)
        Me.C1NEOtros.TabIndex = 172
        Me.C1NEOtros.Tag = Nothing
        Me.C1NEOtros.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEOtros.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkOtros
        '
        Me.chkOtros.Location = New System.Drawing.Point(374, 217)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(77, 18)
        Me.chkOtros.TabIndex = 171
        Me.chkOtros.Text = "Otros"
        '
        'C1NESeguroVehiculo
        '
        Me.C1NESeguroVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroVehiculo.CustomFormat = "#0.00"
        Me.C1NESeguroVehiculo.Enabled = False
        Me.C1NESeguroVehiculo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroVehiculo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroVehiculo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NESeguroVehiculo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroVehiculo.Location = New System.Drawing.Point(181, 217)
        Me.C1NESeguroVehiculo.Name = "C1NESeguroVehiculo"
        Me.C1NESeguroVehiculo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroVehiculo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroVehiculo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroVehiculo.Size = New System.Drawing.Size(186, 23)
        Me.C1NESeguroVehiculo.TabIndex = 170
        Me.C1NESeguroVehiculo.Tag = Nothing
        Me.C1NESeguroVehiculo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NESeguroVehiculo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkSeguroVehiculo
        '
        Me.chkSeguroVehiculo.Location = New System.Drawing.Point(11, 218)
        Me.chkSeguroVehiculo.Name = "chkSeguroVehiculo"
        Me.chkSeguroVehiculo.Size = New System.Drawing.Size(163, 19)
        Me.chkSeguroVehiculo.TabIndex = 169
        Me.chkSeguroVehiculo.Text = "Seguro de Vehiculo"
        '
        'btEdit1
        '
        Me.btEdit1.Location = New System.Drawing.Point(491, 316)
        Me.btEdit1.Name = "btEdit1"
        Me.btEdit1.Size = New System.Drawing.Size(224, 32)
        Me.btEdit1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEdit1.TabIndex = 168
        Me.btEdit1.Text = "Aplicar cambios a &última cuota"
        Me.btEdit1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEdit1.UseSelectable = True
        Me.btEdit1.UseStyleColors = True
        '
        'chkEdit
        '
        Me.chkEdit.Enabled = False
        Me.chkEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEdit.ForeColor = System.Drawing.Color.Teal
        Me.chkEdit.Location = New System.Drawing.Point(7, 295)
        Me.chkEdit.Name = "chkEdit"
        Me.chkEdit.Size = New System.Drawing.Size(163, 23)
        Me.chkEdit.TabIndex = 19
        Me.chkEdit.Text = "E&ditar última Cuota"
        '
        'c1nAbonoCapital
        '
        Me.c1nAbonoCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nAbonoCapital.CustomFormat = "###,###,##0.00"
        Me.c1nAbonoCapital.Enabled = False
        Me.c1nAbonoCapital.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nAbonoCapital.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nAbonoCapital.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nAbonoCapital.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nAbonoCapital.Location = New System.Drawing.Point(374, 325)
        Me.c1nAbonoCapital.Name = "c1nAbonoCapital"
        Me.c1nAbonoCapital.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nAbonoCapital.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nAbonoCapital.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nAbonoCapital.Size = New System.Drawing.Size(87, 21)
        Me.c1nAbonoCapital.TabIndex = 21
        Me.c1nAbonoCapital.Tag = Nothing
        Me.c1nAbonoCapital.Visible = False
        Me.c1nAbonoCapital.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(610, 53)
        Me.dtpFechaEmision.MinDate = New Date(1945, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(105, 22)
        Me.dtpFechaEmision.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(487, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 37)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Fecha Emisión Cuota:"
        '
        'c1nUltimaCuota
        '
        Me.c1nUltimaCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nUltimaCuota.CustomFormat = "###,###,##0.00"
        Me.c1nUltimaCuota.Enabled = False
        Me.c1nUltimaCuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nUltimaCuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nUltimaCuota.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nUltimaCuota.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nUltimaCuota.Location = New System.Drawing.Point(130, 325)
        Me.c1nUltimaCuota.Name = "c1nUltimaCuota"
        Me.c1nUltimaCuota.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nUltimaCuota.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nUltimaCuota.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nUltimaCuota.Size = New System.Drawing.Size(86, 21)
        Me.c1nUltimaCuota.TabIndex = 20
        Me.c1nUltimaCuota.Tag = Nothing
        Me.c1nUltimaCuota.Visible = False
        Me.c1nUltimaCuota.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(252, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Abono Capital:"
        Me.Label4.Visible = False
        '
        'C1NESeguroDanios
        '
        Me.C1NESeguroDanios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroDanios.CustomFormat = "#0.00"
        Me.C1NESeguroDanios.Enabled = False
        Me.C1NESeguroDanios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroDanios.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroDanios.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NESeguroDanios.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroDanios.Location = New System.Drawing.Point(529, 123)
        Me.C1NESeguroDanios.Name = "C1NESeguroDanios"
        Me.C1NESeguroDanios.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroDanios.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroDanios.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroDanios.Size = New System.Drawing.Size(186, 23)
        Me.C1NESeguroDanios.TabIndex = 9
        Me.C1NESeguroDanios.Tag = Nothing
        Me.C1NESeguroDanios.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NESeguroDanios.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkSeguroDanios
        '
        Me.chkSeguroDanios.Location = New System.Drawing.Point(374, 129)
        Me.chkSeguroDanios.Name = "chkSeguroDanios"
        Me.chkSeguroDanios.Size = New System.Drawing.Size(164, 19)
        Me.chkSeguroDanios.TabIndex = 8
        Me.chkSeguroDanios.Text = "Seguro de Daños (%)"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Teal
        Me.Label14.Location = New System.Drawing.Point(7, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 17)
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
        Me.C1NEAhorro.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEAhorro.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEAhorro.Location = New System.Drawing.Point(529, 186)
        Me.C1NEAhorro.Name = "C1NEAhorro"
        Me.C1NEAhorro.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEAhorro.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEAhorro.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEAhorro.Size = New System.Drawing.Size(186, 23)
        Me.C1NEAhorro.TabIndex = 17
        Me.C1NEAhorro.Tag = Nothing
        Me.C1NEAhorro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEAhorro.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Última Cuota:"
        Me.Label3.Visible = False
        '
        'chkAhorro
        '
        Me.chkAhorro.Location = New System.Drawing.Point(374, 187)
        Me.chkAhorro.Name = "chkAhorro"
        Me.chkAhorro.Size = New System.Drawing.Size(77, 18)
        Me.chkAhorro.TabIndex = 16
        Me.chkAhorro.Text = "Ahorro"
        '
        'C1NEAportacion
        '
        Me.C1NEAportacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEAportacion.CustomFormat = "#0.00"
        Me.C1NEAportacion.Enabled = False
        Me.C1NEAportacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEAportacion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEAportacion.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEAportacion.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEAportacion.Location = New System.Drawing.Point(181, 155)
        Me.C1NEAportacion.Name = "C1NEAportacion"
        Me.C1NEAportacion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEAportacion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEAportacion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEAportacion.Size = New System.Drawing.Size(186, 23)
        Me.C1NEAportacion.TabIndex = 11
        Me.C1NEAportacion.Tag = Nothing
        Me.C1NEAportacion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEAportacion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkAportacion
        '
        Me.chkAportacion.Location = New System.Drawing.Point(11, 158)
        Me.chkAportacion.Name = "chkAportacion"
        Me.chkAportacion.Size = New System.Drawing.Size(105, 19)
        Me.chkAportacion.TabIndex = 10
        Me.chkAportacion.Text = "Aportación"
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
        Me.C1NEIntervalo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEIntervalo.Location = New System.Drawing.Point(610, 83)
        Me.C1NEIntervalo.MaxLength = 3
        Me.C1NEIntervalo.Name = "C1NEIntervalo"
        Me.C1NEIntervalo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEIntervalo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEIntervalo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NEIntervalo.Size = New System.Drawing.Size(105, 23)
        Me.C1NEIntervalo.TabIndex = 5
        Me.C1NEIntervalo.Tag = Nothing
        Me.C1NEIntervalo.Value = CType(0, Short)
        Me.C1NEIntervalo.Visible = False
        Me.C1NEIntervalo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(487, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 18)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Intérvalo"
        Me.Label12.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(374, 54)
        Me.dtpFecha.MinDate = New Date(1945, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(106, 22)
        Me.dtpFecha.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(252, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 37)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Fecha Primera cuota:"
        '
        'C1NECuotasSoloInteres
        '
        Me.C1NECuotasSoloInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NECuotasSoloInteres.Calculator.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1NECuotasSoloInteres.CustomFormat = "##0"
        Me.C1NECuotasSoloInteres.DataType = GetType(Short)
        Me.C1NECuotasSoloInteres.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NECuotasSoloInteres.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NECuotasSoloInteres.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NECuotasSoloInteres.Location = New System.Drawing.Point(130, 54)
        Me.C1NECuotasSoloInteres.MaxLength = 3
        Me.C1NECuotasSoloInteres.Name = "C1NECuotasSoloInteres"
        Me.C1NECuotasSoloInteres.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NECuotasSoloInteres.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NECuotasSoloInteres.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NECuotasSoloInteres.Size = New System.Drawing.Size(115, 23)
        Me.C1NECuotasSoloInteres.TabIndex = 3
        Me.C1NECuotasSoloInteres.Tag = Nothing
        Me.C1NECuotasSoloInteres.Value = CType(0, Short)
        Me.C1NECuotasSoloInteres.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1NEMontoGarantia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 47)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Garantías "
        '
        'C1NEMontoGarantia
        '
        Me.C1NEMontoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMontoGarantia.CustomFormat = "###,###,##0.00"
        Me.C1NEMontoGarantia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMontoGarantia.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMontoGarantia.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEMontoGarantia.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMontoGarantia.Location = New System.Drawing.Point(142, 16)
        Me.C1NEMontoGarantia.Name = "C1NEMontoGarantia"
        Me.C1NEMontoGarantia.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMontoGarantia.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMontoGarantia.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMontoGarantia.Size = New System.Drawing.Size(124, 23)
        Me.C1NEMontoGarantia.TabIndex = 0
        Me.C1NEMontoGarantia.Tag = Nothing
        Me.C1NEMontoGarantia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEMontoGarantia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Monto de Garantía:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 30)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Número de cuotas sólo Intereses"
        '
        'C1NEComision
        '
        Me.C1NEComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEComision.CustomFormat = "#0.00"
        Me.C1NEComision.Enabled = False
        Me.C1NEComision.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEComision.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEComision.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEComision.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEComision.Location = New System.Drawing.Point(181, 186)
        Me.C1NEComision.Name = "C1NEComision"
        Me.C1NEComision.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEComision.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEComision.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEComision.Size = New System.Drawing.Size(186, 23)
        Me.C1NEComision.TabIndex = 15
        Me.C1NEComision.Tag = Nothing
        Me.C1NEComision.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEComision.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkComision
        '
        Me.chkComision.Location = New System.Drawing.Point(11, 188)
        Me.chkComision.Name = "chkComision"
        Me.chkComision.Size = New System.Drawing.Size(163, 19)
        Me.chkComision.TabIndex = 14
        Me.chkComision.Text = "Comisión por Manejo"
        '
        'C1NESeguroVida
        '
        Me.C1NESeguroVida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroVida.CustomFormat = "#0.00"
        Me.C1NESeguroVida.Enabled = False
        Me.C1NESeguroVida.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroVida.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroVida.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NESeguroVida.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroVida.Location = New System.Drawing.Point(529, 155)
        Me.C1NESeguroVida.Name = "C1NESeguroVida"
        Me.C1NESeguroVida.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroVida.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroVida.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroVida.Size = New System.Drawing.Size(186, 23)
        Me.C1NESeguroVida.TabIndex = 13
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
        Me.C1NESeguroDeuda.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NESeguroDeuda.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroDeuda.Location = New System.Drawing.Point(181, 123)
        Me.C1NESeguroDeuda.Name = "C1NESeguroDeuda"
        Me.C1NESeguroDeuda.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroDeuda.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroDeuda.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroDeuda.Size = New System.Drawing.Size(186, 23)
        Me.C1NESeguroDeuda.TabIndex = 7
        Me.C1NESeguroDeuda.Tag = Nothing
        Me.C1NESeguroDeuda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NESeguroDeuda.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkSeguroVida
        '
        Me.chkSeguroVida.Location = New System.Drawing.Point(374, 158)
        Me.chkSeguroVida.Name = "chkSeguroVida"
        Me.chkSeguroVida.Size = New System.Drawing.Size(154, 19)
        Me.chkSeguroVida.TabIndex = 12
        Me.chkSeguroVida.Text = "Seguro de Vida (%)"
        '
        'chkSeguroDeuda
        '
        Me.chkSeguroDeuda.Location = New System.Drawing.Point(11, 130)
        Me.chkSeguroDeuda.Name = "chkSeguroDeuda"
        Me.chkSeguroDeuda.Size = New System.Drawing.Size(163, 18)
        Me.chkSeguroDeuda.TabIndex = 6
        Me.chkSeguroDeuda.Text = "Seguro de Deuda (%)"
        '
        'C1NEInteres
        '
        Me.C1NEInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEInteres.CustomFormat = "#0.00"
        Me.C1NEInteres.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEInteres.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEInteres.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEInteres.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEInteres.Location = New System.Drawing.Point(374, 23)
        Me.C1NEInteres.Name = "C1NEInteres"
        Me.C1NEInteres.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEInteres.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEInteres.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEInteres.Size = New System.Drawing.Size(106, 23)
        Me.C1NEInteres.TabIndex = 1
        Me.C1NEInteres.Tag = Nothing
        Me.C1NEInteres.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(130, 23)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.Size = New System.Drawing.Size(115, 23)
        Me.C1NEMonto.TabIndex = 0
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NENumPagos
        '
        Me.C1NENumPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NENumPagos.Calculator.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1NENumPagos.CustomFormat = "##0"
        Me.C1NENumPagos.DataType = GetType(Short)
        Me.C1NENumPagos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NENumPagos.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NENumPagos.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NENumPagos.Location = New System.Drawing.Point(610, 22)
        Me.C1NENumPagos.MaxLength = 3
        Me.C1NENumPagos.Name = "C1NENumPagos"
        Me.C1NENumPagos.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NENumPagos.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NENumPagos.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NENumPagos.Size = New System.Drawing.Size(105, 23)
        Me.C1NENumPagos.TabIndex = 2
        Me.C1NENumPagos.Tag = Nothing
        Me.C1NENumPagos.Value = CType(0, Short)
        Me.C1NENumPagos.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(487, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Núm.Pagos"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(252, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Interés"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(7, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Monto del Crédito"
        '
        'C1fgrdDetalle
        '
        Me.C1fgrdDetalle.AllowEditing = False
        Me.C1fgrdDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdDetalle.BackColor = System.Drawing.Color.White
        Me.C1fgrdDetalle.ColumnInfo = "9,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1fgrdDetalle.Location = New System.Drawing.Point(28, 432)
        Me.C1fgrdDetalle.Name = "C1fgrdDetalle"
        Me.C1fgrdDetalle.Rows.Count = 2
        Me.C1fgrdDetalle.Rows.DefaultSize = 22
        Me.C1fgrdDetalle.Size = New System.Drawing.Size(739, 213)
        Me.C1fgrdDetalle.StyleInfo = resources.GetString("C1fgrdDetalle.StyleInfo")
        Me.C1fgrdDetalle.TabIndex = 1
        '
        'btnLimpiar1
        '
        Me.btnLimpiar1.Location = New System.Drawing.Point(402, 650)
        Me.btnLimpiar1.Name = "btnLimpiar1"
        Me.btnLimpiar1.Size = New System.Drawing.Size(90, 32)
        Me.btnLimpiar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnLimpiar1.TabIndex = 185
        Me.btnLimpiar1.Text = "&Limpiar"
        Me.btnLimpiar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLimpiar1.UseSelectable = True
        Me.btnLimpiar1.UseStyleColors = True
        '
        'btPlanPago1
        '
        Me.btPlanPago1.Location = New System.Drawing.Point(280, 650)
        Me.btPlanPago1.Name = "btPlanPago1"
        Me.btPlanPago1.Size = New System.Drawing.Size(115, 32)
        Me.btPlanPago1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btPlanPago1.TabIndex = 184
        Me.btPlanPago1.Text = "&Plan de Pago"
        Me.btPlanPago1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btPlanPago1.UseSelectable = True
        Me.btPlanPago1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(125, 650)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(147, 32)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 183
        Me.btnImprimir1.Text = "&Cálculo de Cuota"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btnAceptarLin1
        '
        Me.btnAceptarLin1.Location = New System.Drawing.Point(28, 650)
        Me.btnAceptarLin1.Name = "btnAceptarLin1"
        Me.btnAceptarLin1.Size = New System.Drawing.Size(90, 32)
        Me.btnAceptarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptarLin1.TabIndex = 182
        Me.btnAceptarLin1.Text = "Calcular"
        Me.btnAceptarLin1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAceptarLin1.UseSelectable = True
        Me.btnAceptarLin1.UseStyleColors = True
        '
        'btnExportar1
        '
        Me.btnExportar1.Location = New System.Drawing.Point(499, 650)
        Me.btnExportar1.Name = "btnExportar1"
        Me.btnExportar1.Size = New System.Drawing.Size(90, 32)
        Me.btnExportar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnExportar1.TabIndex = 186
        Me.btnExportar1.Text = "&Exportar"
        Me.btnExportar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnExportar1.UseSelectable = True
        Me.btnExportar1.UseStyleColors = True
        '
        'btnAsignar1
        '
        Me.btnAsignar1.Location = New System.Drawing.Point(596, 650)
        Me.btnAsignar1.Name = "btnAsignar1"
        Me.btnAsignar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAsignar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAsignar1.TabIndex = 187
        Me.btnAsignar1.Text = "&Asignar"
        Me.btnAsignar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAsignar1.UseSelectable = True
        Me.btnAsignar1.UseStyleColors = True
        '
        'frmCRTablaAmort
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(794, 692)
        Me.Controls.Add(Me.btnAsignar1)
        Me.Controls.Add(Me.btnExportar1)
        Me.Controls.Add(Me.btnLimpiar1)
        Me.Controls.Add(Me.btPlanPago1)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.btnAceptarLin1)
        Me.Controls.Add(Me.C1fgrdDetalle)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(794, 692)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(794, 692)
        Me.Name = "frmCRTablaAmort"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cálculo Tabla de Amortización y Cuotas"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.C1NEOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nAbonoCapital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nUltimaCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroDanios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEAhorro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEAportacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEIntervalo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NECuotasSoloInteres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1NEMontoGarantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEComision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroVida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroDeuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEInteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NENumPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Property cuotaTotal As Double
        Get
            Return vCuota
        End Get
        Set(value As Double)
            vCuota = value
        End Set
    End Property

    Public Property Reasignacion() As Boolean
        Get
            Return vReasignacion
        End Get
        Set(ByVal Value As Boolean)
            vReasignacion = Value
        End Set
    End Property

    Public Property TAmortiza() As DataSet
        Get
            Return ds
        End Get
        Set(ByVal Value As DataSet)
            ds = Value
        End Set
    End Property

    Public Property CodPrestamo() As String
        Get
            Return vCodPrestamo
        End Get
        Set(ByVal Value As String)
            vCodPrestamo = Value
        End Set
    End Property

    'LUIS ALVARENGA
    Public Property pNombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal Value As String)
            vNombre = Value
        End Set
    End Property

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

    Private Sub chkAportacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAportacion.CheckedChanged
        If Me.chkAportacion.Checked = False Then
            Me.C1NEAportacion.Enabled = False
        Else
            Me.C1NEAportacion.Enabled = True
        End If
    End Sub

    Private Sub chkAhorro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAhorro.CheckedChanged
        If Me.chkAhorro.Checked = False Then
            Me.C1NEAhorro.Enabled = False
        Else
            Me.C1NEAhorro.Enabled = True
        End If
    End Sub

    Private Sub C1NEMontoGarantia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1NEMontoGarantia.TextChanged
        If Me.C1NEMontoGarantia.Value > 0 Then
            Me.chkSeguroDanios.Checked = True
            Me.C1NESeguroDanios.Value = 0.0
        End If
    End Sub

    Private Sub chkSeguroDanios_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeguroDanios.CheckedChanged
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

    Public Function calculoValoresSoloIntCap(ByVal capital As Double, ByVal tasa As Double, ByVal plazo As Double) As DataSet
        'Dim capital As Double
        'Dim tasa As Double
        'Dim plazo As Integer
        Dim cuota As Double
        Dim abonoInt As Double
        Dim NuevoSaldo As Double
        'abonoInt = IPmt((tasa / 100) / 12, plazo, -capital, 0)
        cuota = Math.Round(Pmt((tasa / 100) / 12, plazo, -capital, 0), 2)
        Dim dt As New DataTable
        dt.Columns.Add("Plazo")
        dt.Columns.Add("Cuota")
        dt.Columns.Add("AbonoInteres")
        dt.Columns.Add("AbonoCapital")
        dt.Columns.Add("SaldoCapital")
        For i As Integer = 1 To plazo
            Dim fila As DataRow = dt.NewRow
            fila("Plazo") = i
            fila("Cuota") = cuota
            fila("AbonoInteres") = Math.Round(IPmt((tasa / 100) / 12, CDbl(i), plazo, -capital, 0), 2)
            fila("AbonoCapital") = Math.Round(cuota - IPmt((tasa / 100) / 12, CDbl(i), plazo, -capital, 0), 2)
            If i = 1 Then
                NuevoSaldo = Math.Round(capital - (cuota - IPmt((tasa / 100) / 12, CDbl(i), plazo, -capital, 0)), 2)
                fila("SaldoCapital") = NuevoSaldo
            Else
                NuevoSaldo = Math.Round(NuevoSaldo - (cuota - IPmt((tasa / 100) / 12, CDbl(i), plazo, -capital, 0)), 2)
                fila("SaldoCapital") = NuevoSaldo
            End If
            dt.Rows.Add(fila)
        Next
        Me.C1fgrdDetalle.DataSource = dt



        'MsgBox(cuota.ToString, MsgBoxStyle.Information)



    End Function


    Private Sub btEdit1_Click(sender As Object, e As EventArgs) Handles btEdit1.Click
        Try
            Dim ds As New DataSet, oPrest As New wrPrestamo.wsLibPrest
            ds = oPrest.EditarUltimaCuota(Me.c1nUltimaCuota.Value, Me.c1nAbonoCapital.Value, Me.TAmortiza, sUsuario, sPassword, sSucursal)
            Me.TAmortiza = ds
            C1fgrdDetalle.DataSource = Me.TAmortiza.Tables(0).DefaultView
            Me.c1nAbonoCapital.Enabled = False
            Me.c1nUltimaCuota.Enabled = False
            Me.btEdit1.Enabled = False
            Me.chkEdit.Checked = False
            vVal = False
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnAceptarLin1.Click
        Try

            Dim oPrest As New wrPrestamo.wsLibPrest
            If Me.C1NECuotasSoloInteres.Value < Me.C1NENumPagos.Value Then
                'calculoValoresSoloIntCap(C1NEMonto.Value, C1NEInteres.Value, C1NENumPagos.Value)
                'Exit Sub

                Me.TAmortiza = oPrest.GeneraTAmortiza(C1NEMonto.Text, C1NEInteres.Text, C1NENumPagos.Text, dtpFecha.Value, Me.C1NESeguroDeuda.Value, Me.C1NEMontoGarantia.Value, Me.C1NESeguroDanios.Value, Me.C1NESeguroVida.Value, 0, Me.C1NEAportacion.Value, Me.C1NEAhorro.Value, Me.C1NEComision.Value, Me.C1NECuotasSoloInteres.Value, Me.C1NEIntervalo.Value, sUsuario, sPassword, sSucursal, Me.C1NESeguroVehiculo.Value, Me.C1NEOtros.Value)
                C1fgrdDetalle.DataSource = Me.TAmortiza.Tables(0).DefaultView
                cuotaTotal = TAmortiza.Tables(0).Rows(0).Item("cuota_total")
                Me.chkEdit.Enabled = True
            Else
                MsgBox("El número de Cuotas con aplicación de sólo interés no puede ser igual o mayor al número de pagos del Préstamo.", MsgBoxStyle.Critical, "Validación del Sistema")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Try
            Dim frm As New frmMsReporteDUI
            frm.Titulo = "Cálculo de Cuota para Préstamos"
            frm.Monto = C1NEMonto.Text
            frm.MontoGarantia = Me.C1NEMontoGarantia.Value
            frm.NumPagos = C1NENumPagos.Text
            frm.dRep = Me.TAmortiza
            frm.NumReporte = "3"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btPlanPago1_Click(sender As Object, e As EventArgs) Handles btPlanPago1.Click
        Try
            Dim ds As New DataSet, oCred As New wrCredito.wsLibCred

            ds = oCred.Rep_TablaAmortizacion(Me.TAmortiza, sUsuario, sPassword, sSucursal, Me.pNombre, Me.CodPrestamo)
            Dim ofrm As New frmVisor(ds, 34, 0)
            ofrm.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
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
            saveFileDialog1.InitialDirectory = "c:"
            saveFileDialog1.Filter = "Archivos xml (*.xml)|*.xml"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            saveFileDialog1.ShowDialog()
            If saveFileDialog1.FileName.Trim <> "" Then
                MessageBox.Show("La Tabla de Amortización se Guardará en: " & saveFileDialog1.FileName, "Guardar Tabla de Amortización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.TAmortiza.WriteXml(saveFileDialog1.FileName)
            Else
                MessageBox.Show("Operación Cancelada", "Guardar Tabla de Amortización", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub C1fgrdDetalle_Click(sender As Object, e As EventArgs) Handles C1fgrdDetalle.Click

    End Sub

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

    Private Sub btnAsignar1_Click(sender As Object, e As EventArgs) Handles btnAsignar1.Click
        Dim oPrest As New wrPrestamo.wsLibPrest, s As String
        Try
            If Me.C1fgrdDetalle.Row <> -1 Then
                If vReasignacion = True Then
                    s = oPrest.ReasignarTablaAmortiza(Me.CodPrestamo, Me.TAmortiza, sUsuario, sPassword, sSucursal)
                    MessageBox.Show("Tabla de Amortización asignada.", "Tabla de Amortización Asignada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                ElseIf vReasignacion = False Then
                    s = oPrest.GuardarTablaAmortiza(Me.CodPrestamo, Me.TAmortiza, sUsuario, sPassword, sSucursal)
                    MessageBox.Show("Tabla de Amortización asignada bajo el Código: " & s & ", para el Código de Préstamo: " & Me.CodPrestamo, "Tabla de Amortización Asignada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub frmCRTablaAmort_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vVal = False
    End Sub

    Private Sub chkEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEdit.CheckedChanged
        If Me.chkEdit.Checked = True And vVal = False Then
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "CRY006"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                Me.c1nAbonoCapital.Enabled = True
                Me.c1nUltimaCuota.Enabled = True
                Me.btEdit1.Enabled = True
                ofrmAut.Autoriza = False
                vVal = True
                Me.c1nUltimaCuota.Value = 0
                Me.c1nAbonoCapital.Value = 0
                Me.c1nUltimaCuota.Focus()
                ofrmAut.Dispose()
            Else
                Me.chkEdit.Checked = False
                vVal = False
                ofrmAut.Dispose()
            End If
        End If
    End Sub

End Class