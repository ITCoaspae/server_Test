Public Class frmMsCrTipoCred
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private vInteresMinimo As Double

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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodLineaCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtLineaCredito As System.Windows.Forms.TextBox
    Friend WithEvents C1NEInteres As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkGeneraReserva As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkProm As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTipoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents C1NEPlazoMin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCodCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents c1nIntMora As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nuDiasGracia As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nuDiasGracia = New System.Windows.Forms.NumericUpDown()
        Me.c1nIntMora = New C1.Win.C1Input.C1NumericEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodCuenta = New C1.Win.C1Input.C1TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCuenta = New C1.Win.C1Input.C1TextBox()
        Me.txtTipoGarantia = New System.Windows.Forms.TextBox()
        Me.txtCodTipoGarantia = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.chkProm = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.C1NEPlazoMin = New C1.Win.C1Input.C1NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkGeneraReserva = New System.Windows.Forms.CheckBox()
        Me.C1NEPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NEInteres = New C1.Win.C1Input.C1NumericEdit()
        Me.txtCodLineaCredito = New System.Windows.Forms.TextBox()
        Me.txtLineaCredito = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.nuDiasGracia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nIntMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEPlazoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTipo
        '
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Location = New System.Drawing.Point(567, 180)
        Me.txtTipo.MaxLength = 1
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(95, 20)
        Me.txtTipo.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(453, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Tipo:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(453, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Días de Gracia:"
        '
        'nuDiasGracia
        '
        Me.nuDiasGracia.Location = New System.Drawing.Point(567, 154)
        Me.nuDiasGracia.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nuDiasGracia.Name = "nuDiasGracia"
        Me.nuDiasGracia.Size = New System.Drawing.Size(95, 20)
        Me.nuDiasGracia.TabIndex = 11
        Me.nuDiasGracia.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nuDiasGracia.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'c1nIntMora
        '
        Me.c1nIntMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nIntMora.CustomFormat = "#0.00"
        Me.c1nIntMora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nIntMora.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nIntMora.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nIntMora.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nIntMora.Location = New System.Drawing.Point(352, 178)
        Me.c1nIntMora.Name = "c1nIntMora"
        Me.c1nIntMora.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nIntMora.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nIntMora.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nIntMora.Size = New System.Drawing.Size(95, 19)
        Me.c1nIntMora.TabIndex = 15
        Me.c1nIntMora.Tag = Nothing
        Me.c1nIntMora.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nIntMora.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(238, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tasa moratorio:"
        '
        'txtCodCuenta
        '
        Me.txtCodCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCuenta.Location = New System.Drawing.Point(137, 257)
        Me.txtCodCuenta.MaxLength = 14
        Me.txtCodCuenta.Name = "txtCodCuenta"
        Me.txtCodCuenta.NumericInput = False
        Me.txtCodCuenta.Size = New System.Drawing.Size(95, 18)
        Me.txtCodCuenta.TabIndex = 25
        Me.txtCodCuenta.Tag = Nothing
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(23, 257)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 16)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Cuenta Contable:"
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(238, 257)
        Me.txtCuenta.MaxLength = 14
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.NumericInput = False
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(424, 18)
        Me.txtCuenta.TabIndex = 26
        Me.txtCuenta.Tag = Nothing
        '
        'txtTipoGarantia
        '
        Me.txtTipoGarantia.BackColor = System.Drawing.Color.White
        Me.txtTipoGarantia.ForeColor = System.Drawing.Color.Black
        Me.txtTipoGarantia.Location = New System.Drawing.Point(238, 231)
        Me.txtTipoGarantia.MaxLength = 100
        Me.txtTipoGarantia.Name = "txtTipoGarantia"
        Me.txtTipoGarantia.ReadOnly = True
        Me.txtTipoGarantia.Size = New System.Drawing.Size(424, 20)
        Me.txtTipoGarantia.TabIndex = 23
        '
        'txtCodTipoGarantia
        '
        Me.txtCodTipoGarantia.BackColor = System.Drawing.Color.White
        Me.txtCodTipoGarantia.Location = New System.Drawing.Point(137, 231)
        Me.txtCodTipoGarantia.MaxLength = 10
        Me.txtCodTipoGarantia.Name = "txtCodTipoGarantia"
        Me.txtCodTipoGarantia.Size = New System.Drawing.Size(95, 20)
        Me.txtCodTipoGarantia.TabIndex = 22
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(377, 283)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(184, 16)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Fecha de Finalización promoción:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(23, 280)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(184, 16)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Fecha de Inicio promoción:"
        '
        'dtpFin
        '
        Me.dtpFin.Enabled = False
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(567, 283)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(95, 20)
        Me.dtpFin.TabIndex = 30
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(213, 283)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(95, 20)
        Me.dtpInicio.TabIndex = 28
        '
        'chkProm
        '
        Me.chkProm.Location = New System.Drawing.Point(23, 121)
        Me.chkProm.Name = "chkProm"
        Me.chkProm.Size = New System.Drawing.Size(96, 24)
        Me.chkProm.TabIndex = 4
        Me.chkProm.Text = "&Promoción"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(23, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Tipo de Garantía:"
        '
        'C1NEPlazoMin
        '
        Me.C1NEPlazoMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEPlazoMin.CustomFormat = "##0"
        Me.C1NEPlazoMin.DataType = GetType(Short)
        Me.C1NEPlazoMin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEPlazoMin.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEPlazoMin.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEPlazoMin.Location = New System.Drawing.Point(137, 151)
        Me.C1NEPlazoMin.Name = "C1NEPlazoMin"
        Me.C1NEPlazoMin.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEPlazoMin.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEPlazoMin.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NEPlazoMin.Size = New System.Drawing.Size(95, 19)
        Me.C1NEPlazoMin.TabIndex = 7
        Me.C1NEPlazoMin.Tag = Nothing
        Me.C1NEPlazoMin.Value = CType(0, Short)
        Me.C1NEPlazoMin.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Plazo Mínimo:"
        '
        'chkGeneraReserva
        '
        Me.chkGeneraReserva.Location = New System.Drawing.Point(125, 121)
        Me.chkGeneraReserva.Name = "chkGeneraReserva"
        Me.chkGeneraReserva.Size = New System.Drawing.Size(120, 24)
        Me.chkGeneraReserva.TabIndex = 5
        Me.chkGeneraReserva.Text = "&Genera Reserva"
        '
        'C1NEPlazo
        '
        Me.C1NEPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEPlazo.CustomFormat = "##0"
        Me.C1NEPlazo.DataType = GetType(Short)
        Me.C1NEPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEPlazo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEPlazo.Location = New System.Drawing.Point(352, 151)
        Me.C1NEPlazo.Name = "C1NEPlazo"
        Me.C1NEPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NEPlazo.Size = New System.Drawing.Size(95, 19)
        Me.C1NEPlazo.TabIndex = 9
        Me.C1NEPlazo.Tag = Nothing
        Me.C1NEPlazo.Value = CType(0, Short)
        Me.C1NEPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NEInteres
        '
        Me.C1NEInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEInteres.CustomFormat = "#0.00"
        Me.C1NEInteres.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEInteres.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEInteres.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEInteres.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEInteres.Location = New System.Drawing.Point(137, 178)
        Me.C1NEInteres.Name = "C1NEInteres"
        Me.C1NEInteres.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEInteres.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEInteres.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEInteres.Size = New System.Drawing.Size(95, 19)
        Me.C1NEInteres.TabIndex = 13
        Me.C1NEInteres.Tag = Nothing
        Me.C1NEInteres.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEInteres.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtCodLineaCredito
        '
        Me.txtCodLineaCredito.BackColor = System.Drawing.Color.White
        Me.txtCodLineaCredito.Location = New System.Drawing.Point(137, 205)
        Me.txtCodLineaCredito.MaxLength = 10
        Me.txtCodLineaCredito.Name = "txtCodLineaCredito"
        Me.txtCodLineaCredito.Size = New System.Drawing.Size(95, 20)
        Me.txtCodLineaCredito.TabIndex = 19
        '
        'txtLineaCredito
        '
        Me.txtLineaCredito.BackColor = System.Drawing.Color.White
        Me.txtLineaCredito.Location = New System.Drawing.Point(238, 205)
        Me.txtLineaCredito.MaxLength = 255
        Me.txtLineaCredito.Name = "txtLineaCredito"
        Me.txtLineaCredito.Size = New System.Drawing.Size(424, 20)
        Me.txtLineaCredito.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Línea de Crédito:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tasa de Interés:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(238, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Plazo Máximo:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(137, 95)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(525, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(137, 69)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(80, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(587, 309)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 31
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrTipoCred
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(690, 366)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtCodCuenta)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtTipoGarantia)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCodTipoGarantia)
        Me.Controls.Add(Me.c1nIntMora)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nuDiasGracia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLineaCredito)
        Me.Controls.Add(Me.txtCodLineaCredito)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.chkProm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkGeneraReserva)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.C1NEPlazoMin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.C1NEPlazo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.C1NEInteres)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(690, 366)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(690, 366)
        Me.Name = "frmMsCrTipoCred"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tipo de Crédito"
        CType(Me.nuDiasGracia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nIntMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEPlazoMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEInteres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub frmMsCrLineasCred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection, oPerif As New wrConta.wsLibContab

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarTipoCreditos("*", "CodTipoCredito='" & pCodigo & "'", "CodTipoCredito", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtCodigo.Text = pCodigo
                    Me.txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    Me.C1NEPlazo.Value = IIf(IsDBNull(Filas.Item(0)("PlazoMaximo")), 0, Filas.Item(0)("PlazoMaximo"))
                    Me.C1NEInteres.Value = IIf(IsDBNull(Filas.Item(0)("InteresActual")), 0, Filas.Item(0)("InteresActual"))
                    Me.c1nIntMora.Value = IIf(IsDBNull(Filas.Item(0)("InteresMoratorio")), 0, Filas.Item(0)("InteresMoratorio"))
                    Me.txtCodLineaCredito.Text = IIf(IsDBNull(Filas.Item(0)("CodLineaCredito")), "", Filas.Item(0)("CodLineaCredito"))
                    Me.txtCodTipoGarantia.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoGarantias")), "", Filas.Item(0)("CodTipoGarantias"))
                    Me.txtCodCuenta.Value = IIf(IsDBNull(Filas.Item(0)("IdCuenta")), "", Filas.Item(0)("IdCuenta"))
                    Me.nuDiasGracia.Value = IIf(IsDBNull(Filas.Item(0)("DiasGracia")), 0, Filas.Item(0)("DiasGracia"))
                    Me.txtTipo.Text = IIf(IsDBNull(Filas.Item(0)("Tipo")), 0, Filas.Item(0)("Tipo"))
                    If IsDBNull(Filas.Item(0)("GeneraReserva")) = False Then
                        Me.chkGeneraReserva.Checked = IIf(Filas.Item(0)("GeneraReserva") = 1, True, False)
                    End If
                    If IsDBNull(Filas.Item(0)("Promocion")) = False Then
                        Me.chkProm.Checked = IIf(Filas.Item(0)("Promocion") = 1, True, False)
                    End If
                    Me.dtpInicio.Value = IIf(IsDBNull(Filas.Item(0)("FechaIniProm")), Now, Filas.Item(0)("FechaIniProm"))
                    Me.dtpFin.Value = IIf(IsDBNull(Filas.Item(0)("FechaFinProm")), Now, Filas.Item(0)("FechaFinProm"))
                    If Trim(Me.txtCodTipoGarantia.Text) <> "" Then
                        ds = oCred.ConsultarTipGarant("*", "CodTipoGarantias='" & Trim(Me.txtCodTipoGarantia.Text) & "'", "CodTipoGarantias", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtTipoGarantia.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                        End If
                    End If
                    If Trim(Me.txtCodLineaCredito.Text) <> "" Then
                        ds = oCred.ConsultarLineaCreditos("*", "CodLineaCredito='" & Trim(Me.txtCodLineaCredito.Text) & "'", "CodLineaCredito", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtLineaCredito.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                        End If
                    End If
                    If Trim(Me.txtCodCuenta.Text.Trim) <> "" Then
                        ds = oPerif.ObtenerCatContab("*", "Final='S' and IdCuenta='" & Me.txtCodCuenta.Text.Trim & "'", "idCuenta", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables("Catalogo").Rows()
                        If Filas.Count > 0 Then Me.txtCuenta.Value = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    End If
                End If

            Else
                Dim vCod As String
                vCod = oCred.ObtenerCorrelativoTipoCreditos("CodTipoCredito", sUsuario, sPassword, sSucursal)
                Me.txtCodigo.Text = vCod
                Me.dtpFin.Value = Now
                Me.dtpInicio.Value = Now
            End If
            txtCodigo.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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

    Private Sub txtCodTipoGarantia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoGarantia.KeyPress
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrCredito.wsLibCred
                ds = oPerif.ConsultarTipGarant("*", "CodTipoGarantias='" & Trim(Me.txtCodTipoGarantia.Text) & "'", "CodTipoGarantias", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtTipoGarantia.Text = CStr(Filas.Item(0)("Descripcion"))
                    End If
                Else
                    txtCodTipoGarantia_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodTipoGarantia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoGarantia.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipos de Garantía"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipGarant("*", "", "CodTipoGarantias", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodTipoGarantia.Text = ofrm.Resultado.Trim
            Me.txtTipoGarantia.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkProm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProm.CheckedChanged
        If Me.chkProm.Checked = True Then
            Me.dtpInicio.Enabled = True
            Me.dtpFin.Enabled = True
        Else
            Me.dtpInicio.Enabled = False
            Me.dtpFin.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            Select Case oCred.AutorizarDatos(Trim(txtCodigo.Text), Trim(Me.txtDescripcion.Text), Trim(Me.txtCodLineaCredito.Text), "x", "x")
                Case 1
                    MsgBox("El Código de Tipo de Crédito no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 2
                    MsgBox("La Descripción del Tipo de Crédito no puede quedar vacía. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 3
                    MsgBox("El Código de Línea de Crédito no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            ds = oCred.ConsultarLineaCreditos("InteresMinimo", "CodLineaCredito='" & Trim(Me.txtCodLineaCredito.Text) & "'", "CodLineaCredito", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.vInteresMinimo = IIf(IsDBNull(Filas.Item(0)("InteresMinimo")), 0, Filas.Item(0)("InteresMinimo"))
                If Me.C1NEInteres.Value >= Me.vInteresMinimo Then
                Else
                    MsgBox("El Interés Actual debe ser mayor o igual al Interés Mínimo de la Línea de Crédito. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                End If
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "CodTipoCredito,Descripcion,PlazoMaximo,InteresActual,CodLineaCredito,GeneraReserva,PlazoMinimo,Promocion,FechaIniProm,FechaFinProm,CodTipoGarantias,IdCuenta,interesMoratorio,DiasGracia,Tipo"
                pValores = "'" & Trim(txtCodigo.Text) & "','" & Trim(txtDescripcion.Text) & "'," & Me.C1NEPlazo.Value & "," & Me.C1NEInteres.Value & ",'" & Trim(Me.txtCodLineaCredito.Text) & "','" & IIf(Me.chkGeneraReserva.Checked = True, "1", "0") & "'," & Me.C1NEPlazoMin.Value & ",'" & IIf(Me.chkProm.Checked = True, "1", "0") & "','" & Format(Me.dtpInicio.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFin.Value, "dd/MM/yyyy") & "','" & Me.txtCodTipoGarantia.Text.Trim & "','" & Me.txtCodCuenta.Text.Trim & "'," & Me.c1nIntMora.Value & "," & Me.nuDiasGracia.Value & ",'" & Me.txtTipo.Text.Trim & "'"
                If oCred.InsertarTipoCreditos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Tipo de Crédito NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Descripcion='" & Trim(txtDescripcion.Text) & "',PlazoMaximo=" & Me.C1NEPlazo.Value & ",InteresActual=" & Me.C1NEInteres.Value & ",CodLineaCredito='" & Trim(Me.txtCodLineaCredito.Text) & "',GeneraReserva='" & IIf(Me.chkGeneraReserva.Checked = True, "1", "0") & "',PlazoMinimo=" & Me.C1NEPlazoMin.Value & ",Promocion='" & IIf(Me.chkProm.Checked = True, "1", "0") & "',FechaIniProm='" & Format(Me.dtpInicio.Value, "dd/MM/yyyy") & "',FechaFinProm='" & Format(Me.dtpFin.Value, "dd/MM/yyyy") & "',CodTipoGarantias='" & Me.txtCodTipoGarantia.Text.Trim & "',IdCuenta='" & Me.txtCodCuenta.Text.Trim & "',interesMoratorio=" & Me.c1nIntMora.Value & ",DiasGracia=" & Me.nuDiasGracia.Value & ",Tipo='" & Me.txtTipo.Text.Trim & "'"
                If oCred.ModificarTipoCreditos(Trim(pCodigo), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Tipo de Crédito no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtCodCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCuenta.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("*", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodCuenta.Value = ofrm.Resultado.Trim
            Me.txtCuenta.Value = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
