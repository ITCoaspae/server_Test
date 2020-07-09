Public Class frmMsGnParametros
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents tpModuloCobranza As System.Windows.Forms.TabPage
    Friend WithEvents lblReservaCtasInc As System.Windows.Forms.Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtMontoUifAcumuladoOM As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label37 As Label
    Friend WithEvents txtMontoOtrosMedios As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label36 As Label
    Friend WithEvents txtMontoUIFAcumulado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label35 As Label
    Friend WithEvents txtMontoUIF As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label34 As Label
    Friend WithEvents txtTasaSeguro As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtHipotecarios As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtResVoluntaria As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCtaIva As TextBox
    Friend WithEvents txtCtaTransitoria As TextBox
    Friend WithEvents txtCtaCargaPlanillas As TextBox
    Friend WithEvents txtCtaISR As TextBox
    Friend WithEvents txtCtaInt As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtAniosVigencia As NumericUpDown
    Friend WithEvents txtCambioContraseña As NumericUpDown
    Friend WithEvents txtRes_CtasInc As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents tpConfiguraciones As TabPage
    Friend WithEvents Label38 As Label
    Friend WithEvents txtRutaRs As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txtUrlRs As TextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label41 As Label
    Friend WithEvents txtContraseniaRS As MaskedTextBox
    Friend WithEvents txtUsuarioRs As TextBox
    Friend WithEvents Label40 As Label
    Private vModifica As Boolean

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents c1nIva As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1nSalarioMinimo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents c1MontoLeyLavado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents c1nMaxNumLib As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents tbGral As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents c1nTasaDPF As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents C1NESeguroDanios As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NESeguroDeuda As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nEdad As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents c1nCuotasSeguro As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbDetalle As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescCargo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCargo2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoF1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoF1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoF2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoF2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoF3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoF3 As System.Windows.Forms.TextBox
    Friend WithEvents txtComite1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFirma6 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodFirma6 As System.Windows.Forms.TextBox
    Friend WithEvents txtFirma5 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodFirma5 As System.Windows.Forms.TextBox
    Friend WithEvents txtFirma4 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodFirma4 As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtComite2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo3 As System.Windows.Forms.TextBox
    Friend WithEvents txtComite3 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoDPF As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents c1nTmpInact As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsGnParametros))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAniosVigencia = New System.Windows.Forms.NumericUpDown()
        Me.txtCambioContraseña = New System.Windows.Forms.NumericUpDown()
        Me.txtCtaInt = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtCtaCargaPlanillas = New System.Windows.Forms.TextBox()
        Me.txtCtaISR = New System.Windows.Forms.TextBox()
        Me.txtCtaIva = New System.Windows.Forms.TextBox()
        Me.txtCtaTransitoria = New System.Windows.Forms.TextBox()
        Me.txtTasaSeguro = New C1.Win.C1Input.C1NumericEdit()
        Me.txtHipotecarios = New C1.Win.C1Input.C1NumericEdit()
        Me.txtResVoluntaria = New C1.Win.C1Input.C1NumericEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.c1nIva = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.c1nSalarioMinimo = New C1.Win.C1Input.C1NumericEdit()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tbGral = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.c1nTasaDPF = New C1.Win.C1Input.C1NumericEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.C1NESeguroDanios = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NESeguroDeuda = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nEdad = New C1.Win.C1Input.C1NumericEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.c1nCuotasSeguro = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDetalle = New System.Windows.Forms.TabPage()
        Me.txtDescCargo2 = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtCodCargo2 = New System.Windows.Forms.TextBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescCargo = New System.Windows.Forms.TextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtCodCargo = New System.Windows.Forms.TextBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMontoUifAcumuladoOM = New C1.Win.C1Input.C1NumericEdit()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtMontoOtrosMedios = New C1.Win.C1Input.C1NumericEdit()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtMontoUIFAcumulado = New C1.Win.C1Input.C1NumericEdit()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtMontoUIF = New C1.Win.C1Input.C1NumericEdit()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.c1MontoLeyLavado = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.c1nTmpInact = New C1.Win.C1Input.C1NumericEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.c1nMontoDPF = New C1.Win.C1Input.C1NumericEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.c1nMaxNumLib = New C1.Win.C1Input.C1NumericEdit()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCargoF3 = New System.Windows.Forms.TextBox()
        Me.txtCargo3 = New System.Windows.Forms.TextBox()
        Me.txtComite3 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCodigoF3 = New System.Windows.Forms.TextBox()
        Me.txtCodigoF2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCargoF2 = New System.Windows.Forms.TextBox()
        Me.txtCargo2 = New System.Windows.Forms.TextBox()
        Me.txtComite2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCargoF1 = New System.Windows.Forms.TextBox()
        Me.txtCargo1 = New System.Windows.Forms.TextBox()
        Me.txtComite1 = New System.Windows.Forms.TextBox()
        Me.txtCodigoF1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFirma6 = New System.Windows.Forms.TextBox()
        Me.txtCodFirma6 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFirma5 = New System.Windows.Forms.TextBox()
        Me.txtCodFirma5 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFirma4 = New System.Windows.Forms.TextBox()
        Me.txtCodFirma4 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tpModuloCobranza = New System.Windows.Forms.TabPage()
        Me.txtRes_CtasInc = New C1.Win.C1Input.C1NumericEdit()
        Me.lblReservaCtasInc = New System.Windows.Forms.Label()
        Me.tpConfiguraciones = New System.Windows.Forms.TabPage()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtContraseniaRS = New System.Windows.Forms.MaskedTextBox()
        Me.txtUsuarioRs = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtUrlRs = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtRutaRs = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtAniosVigencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCambioContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasaSeguro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHipotecarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResVoluntaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nIva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSalarioMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tbGral.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1nTasaDPF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroDanios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NESeguroDeuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCuotasSeguro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDetalle.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtMontoUifAcumuladoOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoOtrosMedios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoUIFAcumulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoUIF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1MontoLeyLavado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.c1nTmpInact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoDPF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMaxNumLib, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tpModuloCobranza.SuspendLayout()
        CType(Me.txtRes_CtasInc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpConfiguraciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.tpModuloCobranza)
        Me.TabControl1.Controls.Add(Me.tpConfiguraciones)
        Me.TabControl1.Location = New System.Drawing.Point(28, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(700, 323)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(692, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtAniosVigencia)
        Me.GroupBox1.Controls.Add(Me.txtCambioContraseña)
        Me.GroupBox1.Controls.Add(Me.txtCtaInt)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtCtaCargaPlanillas)
        Me.GroupBox1.Controls.Add(Me.txtCtaISR)
        Me.GroupBox1.Controls.Add(Me.txtCtaIva)
        Me.GroupBox1.Controls.Add(Me.txtCtaTransitoria)
        Me.GroupBox1.Controls.Add(Me.txtTasaSeguro)
        Me.GroupBox1.Controls.Add(Me.txtHipotecarios)
        Me.GroupBox1.Controls.Add(Me.txtResVoluntaria)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.c1nIva)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.c1nSalarioMinimo)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtAniosVigencia
        '
        Me.txtAniosVigencia.Location = New System.Drawing.Point(511, 80)
        Me.txtAniosVigencia.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.txtAniosVigencia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtAniosVigencia.Name = "txtAniosVigencia"
        Me.txtAniosVigencia.Size = New System.Drawing.Size(154, 22)
        Me.txtAniosVigencia.TabIndex = 25
        Me.txtAniosVigencia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCambioContraseña
        '
        Me.txtCambioContraseña.Location = New System.Drawing.Point(511, 50)
        Me.txtCambioContraseña.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtCambioContraseña.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCambioContraseña.Name = "txtCambioContraseña"
        Me.txtCambioContraseña.Size = New System.Drawing.Size(154, 22)
        Me.txtCambioContraseña.TabIndex = 24
        Me.txtCambioContraseña.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCtaInt
        '
        Me.txtCtaInt.Location = New System.Drawing.Point(511, 142)
        Me.txtCtaInt.Name = "txtCtaInt"
        Me.txtCtaInt.Size = New System.Drawing.Size(154, 22)
        Me.txtCtaInt.TabIndex = 23
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(334, 142)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(154, 17)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Cuenta Interes Ahorros"
        '
        'txtCtaCargaPlanillas
        '
        Me.txtCtaCargaPlanillas.Location = New System.Drawing.Point(173, 201)
        Me.txtCtaCargaPlanillas.Name = "txtCtaCargaPlanillas"
        Me.txtCtaCargaPlanillas.Size = New System.Drawing.Size(153, 22)
        Me.txtCtaCargaPlanillas.TabIndex = 13
        '
        'txtCtaISR
        '
        Me.txtCtaISR.Location = New System.Drawing.Point(173, 171)
        Me.txtCtaISR.Name = "txtCtaISR"
        Me.txtCtaISR.Size = New System.Drawing.Size(153, 22)
        Me.txtCtaISR.TabIndex = 11
        '
        'txtCtaIva
        '
        Me.txtCtaIva.Location = New System.Drawing.Point(173, 142)
        Me.txtCtaIva.Name = "txtCtaIva"
        Me.txtCtaIva.Size = New System.Drawing.Size(153, 22)
        Me.txtCtaIva.TabIndex = 9
        '
        'txtCtaTransitoria
        '
        Me.txtCtaTransitoria.Location = New System.Drawing.Point(173, 112)
        Me.txtCtaTransitoria.Name = "txtCtaTransitoria"
        Me.txtCtaTransitoria.Size = New System.Drawing.Size(153, 22)
        Me.txtCtaTransitoria.TabIndex = 7
        '
        'txtTasaSeguro
        '
        Me.txtTasaSeguro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTasaSeguro.CustomFormat = "###,###,##0.00"
        Me.txtTasaSeguro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaSeguro.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtTasaSeguro.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtTasaSeguro.Location = New System.Drawing.Point(511, 112)
        Me.txtTasaSeguro.Name = "txtTasaSeguro"
        Me.txtTasaSeguro.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtTasaSeguro.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtTasaSeguro.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtTasaSeguro.Size = New System.Drawing.Size(154, 26)
        Me.txtTasaSeguro.TabIndex = 21
        Me.txtTasaSeguro.Tag = Nothing
        Me.txtTasaSeguro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTasaSeguro.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtHipotecarios
        '
        Me.txtHipotecarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHipotecarios.CustomFormat = "###,###,##0.00"
        Me.txtHipotecarios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHipotecarios.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtHipotecarios.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtHipotecarios.Location = New System.Drawing.Point(511, 18)
        Me.txtHipotecarios.Name = "txtHipotecarios"
        Me.txtHipotecarios.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtHipotecarios.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtHipotecarios.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtHipotecarios.Size = New System.Drawing.Size(154, 27)
        Me.txtHipotecarios.TabIndex = 15
        Me.txtHipotecarios.Tag = Nothing
        Me.txtHipotecarios.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtHipotecarios.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtResVoluntaria
        '
        Me.txtResVoluntaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResVoluntaria.CustomFormat = "###,###,##0.00"
        Me.txtResVoluntaria.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResVoluntaria.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtResVoluntaria.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtResVoluntaria.Location = New System.Drawing.Point(173, 81)
        Me.txtResVoluntaria.Name = "txtResVoluntaria"
        Me.txtResVoluntaria.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtResVoluntaria.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtResVoluntaria.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtResVoluntaria.Size = New System.Drawing.Size(153, 26)
        Me.txtResVoluntaria.TabIndex = 5
        Me.txtResVoluntaria.Tag = Nothing
        Me.txtResVoluntaria.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtResVoluntaria.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(334, 112)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(90, 17)
        Me.Label33.TabIndex = 20
        Me.Label33.Text = "Tasa Seguro"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(334, 81)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(125, 17)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "Años Vigencia DUI"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(334, 53)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(174, 17)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "Cambio Contraseña (Días)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(334, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(103, 17)
        Me.Label30.TabIndex = 14
        Me.Label30.Text = "% Hipotecarios"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 205)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(151, 17)
        Me.Label29.TabIndex = 12
        Me.Label29.Text = "Cuenta Carga Planillas"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 174)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(79, 17)
        Me.Label28.TabIndex = 10
        Me.Label28.Text = "Cuenta ISR"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 143)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 17)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Cuenta Iva"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(7, 112)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(125, 17)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Cuenta Transitoria"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(7, 81)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(129, 17)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Reserva Voluntaria"
        '
        'c1nIva
        '
        Me.c1nIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nIva.CustomFormat = "###,###,##0.00"
        Me.c1nIva.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nIva.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nIva.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nIva.Location = New System.Drawing.Point(173, 50)
        Me.c1nIva.Name = "c1nIva"
        Me.c1nIva.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nIva.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nIva.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nIva.Size = New System.Drawing.Size(153, 26)
        Me.c1nIva.TabIndex = 3
        Me.c1nIva.Tag = Nothing
        Me.c1nIva.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nIva.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Valor del IVA (%):"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Salario mínimo:"
        '
        'c1nSalarioMinimo
        '
        Me.c1nSalarioMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSalarioMinimo.CustomFormat = "###,###,##0.00"
        Me.c1nSalarioMinimo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSalarioMinimo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSalarioMinimo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nSalarioMinimo.Location = New System.Drawing.Point(173, 18)
        Me.c1nSalarioMinimo.Name = "c1nSalarioMinimo"
        Me.c1nSalarioMinimo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSalarioMinimo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSalarioMinimo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSalarioMinimo.Size = New System.Drawing.Size(153, 27)
        Me.c1nSalarioMinimo.TabIndex = 1
        Me.c1nSalarioMinimo.Tag = Nothing
        Me.c1nSalarioMinimo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nSalarioMinimo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage3.Controls.Add(Me.TabControl2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(692, 294)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Módulo Créditos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tbGral)
        Me.TabControl2.Controls.Add(Me.tbDetalle)
        Me.TabControl2.Location = New System.Drawing.Point(5, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(691, 295)
        Me.TabControl2.TabIndex = 0
        '
        'tbGral
        '
        Me.tbGral.BackColor = System.Drawing.Color.White
        Me.tbGral.Controls.Add(Me.GroupBox3)
        Me.tbGral.Location = New System.Drawing.Point(4, 25)
        Me.tbGral.Name = "tbGral"
        Me.tbGral.Size = New System.Drawing.Size(683, 266)
        Me.tbGral.TabIndex = 0
        Me.tbGral.Text = "Parámetros Generales"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.c1nTasaDPF)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroDanios)
        Me.GroupBox3.Controls.Add(Me.C1NESeguroDeuda)
        Me.GroupBox3.Controls.Add(Me.c1nEdad)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.c1nCuotasSeguro)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(662, 249)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'c1nTasaDPF
        '
        Me.c1nTasaDPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasaDPF.CustomFormat = "#0.00"
        Me.c1nTasaDPF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTasaDPF.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasaDPF.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTasaDPF.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nTasaDPF.Location = New System.Drawing.Point(254, 147)
        Me.c1nTasaDPF.Name = "c1nTasaDPF"
        Me.c1nTasaDPF.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasaDPF.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasaDPF.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasaDPF.Size = New System.Drawing.Size(154, 26)
        Me.c1nTasaDPF.TabIndex = 9
        Me.c1nTasaDPF.Tag = Nothing
        Me.c1nTasaDPF.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasaDPF.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(7, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(240, 31)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Cantidad de puntos establecidos para créditos con Garantía DPF:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(7, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 18)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Seguro de daños:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(7, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 19)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Seguro de deuda:"
        '
        'C1NESeguroDanios
        '
        Me.C1NESeguroDanios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroDanios.CustomFormat = "#0.00"
        Me.C1NESeguroDanios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroDanios.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroDanios.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NESeguroDanios.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroDanios.Location = New System.Drawing.Point(254, 115)
        Me.C1NESeguroDanios.Name = "C1NESeguroDanios"
        Me.C1NESeguroDanios.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroDanios.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroDanios.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroDanios.Size = New System.Drawing.Size(154, 27)
        Me.C1NESeguroDanios.TabIndex = 7
        Me.C1NESeguroDanios.Tag = Nothing
        Me.C1NESeguroDanios.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NESeguroDanios.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NESeguroDeuda
        '
        Me.C1NESeguroDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESeguroDeuda.CustomFormat = "#0.00"
        Me.C1NESeguroDeuda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NESeguroDeuda.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESeguroDeuda.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NESeguroDeuda.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NESeguroDeuda.Location = New System.Drawing.Point(254, 84)
        Me.C1NESeguroDeuda.Name = "C1NESeguroDeuda"
        Me.C1NESeguroDeuda.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESeguroDeuda.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESeguroDeuda.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESeguroDeuda.Size = New System.Drawing.Size(154, 27)
        Me.C1NESeguroDeuda.TabIndex = 5
        Me.C1NESeguroDeuda.Tag = Nothing
        Me.C1NESeguroDeuda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NESeguroDeuda.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nEdad
        '
        Me.c1nEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nEdad.CustomFormat = "###0"
        Me.c1nEdad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nEdad.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nEdad.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nEdad.Location = New System.Drawing.Point(254, 53)
        Me.c1nEdad.Name = "c1nEdad"
        Me.c1nEdad.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nEdad.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nEdad.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nEdad.Size = New System.Drawing.Size(154, 27)
        Me.c1nEdad.TabIndex = 3
        Me.c1nEdad.Tag = Nothing
        Me.c1nEdad.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nEdad.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Edad máxima aseguradora:"
        '
        'c1nCuotasSeguro
        '
        Me.c1nCuotasSeguro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCuotasSeguro.CustomFormat = "###,###,##0"
        Me.c1nCuotasSeguro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCuotasSeguro.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCuotasSeguro.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCuotasSeguro.Location = New System.Drawing.Point(254, 22)
        Me.c1nCuotasSeguro.Name = "c1nCuotasSeguro"
        Me.c1nCuotasSeguro.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCuotasSeguro.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCuotasSeguro.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCuotasSeguro.Size = New System.Drawing.Size(154, 26)
        Me.c1nCuotasSeguro.TabIndex = 1
        Me.c1nCuotasSeguro.Tag = Nothing
        Me.c1nCuotasSeguro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCuotasSeguro.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Número de cuotas a descontar seguro:"
        '
        'tbDetalle
        '
        Me.tbDetalle.BackColor = System.Drawing.Color.White
        Me.tbDetalle.Controls.Add(Me.txtDescCargo2)
        Me.tbDetalle.Controls.Add(Me.txtTipo)
        Me.tbDetalle.Controls.Add(Me.txtCodCargo2)
        Me.tbDetalle.Controls.Add(Me.MetroButton2)
        Me.tbDetalle.Controls.Add(Me.Label7)
        Me.tbDetalle.Controls.Add(Me.Label5)
        Me.tbDetalle.Controls.Add(Me.txtDescCargo)
        Me.tbDetalle.Controls.Add(Me.MetroButton1)
        Me.tbDetalle.Controls.Add(Me.txtCodCargo)
        Me.tbDetalle.Controls.Add(Me.fg)
        Me.tbDetalle.Controls.Add(Me.Label6)
        Me.tbDetalle.Location = New System.Drawing.Point(4, 25)
        Me.tbDetalle.Name = "tbDetalle"
        Me.tbDetalle.Size = New System.Drawing.Size(683, 266)
        Me.tbDetalle.TabIndex = 1
        Me.tbDetalle.Text = "Firmas detalle del crédito"
        '
        'txtDescCargo2
        '
        Me.txtDescCargo2.BackColor = System.Drawing.Color.White
        Me.txtDescCargo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescCargo2.Location = New System.Drawing.Point(142, 72)
        Me.txtDescCargo2.Name = "txtDescCargo2"
        Me.txtDescCargo2.ReadOnly = True
        Me.txtDescCargo2.Size = New System.Drawing.Size(374, 22)
        Me.txtDescCargo2.TabIndex = 7
        '
        'txtTipo
        '
        Me.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Location = New System.Drawing.Point(186, 14)
        Me.txtTipo.MaxLength = 1
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(38, 22)
        Me.txtTipo.TabIndex = 1
        '
        'txtCodCargo2
        '
        Me.txtCodCargo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCargo2.Location = New System.Drawing.Point(55, 72)
        Me.txtCodCargo2.MaxLength = 10
        Me.txtCodCargo2.Name = "txtCodCargo2"
        Me.txtCodCargo2.Size = New System.Drawing.Size(77, 22)
        Me.txtCodCargo2.TabIndex = 6
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(108, 102)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 9
        Me.MetroButton2.Text = "&Eliminar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Cargo:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Digite el Tipo de Crédito:"
        '
        'txtDescCargo
        '
        Me.txtDescCargo.BackColor = System.Drawing.Color.White
        Me.txtDescCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescCargo.Location = New System.Drawing.Point(142, 44)
        Me.txtDescCargo.Name = "txtDescCargo"
        Me.txtDescCargo.ReadOnly = True
        Me.txtDescCargo.Size = New System.Drawing.Size(374, 22)
        Me.txtDescCargo.TabIndex = 4
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(11, 102)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 8
        Me.MetroButton1.Text = "&Agregar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtCodCargo
        '
        Me.txtCodCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCargo.Location = New System.Drawing.Point(55, 44)
        Me.txtCodCargo.MaxLength = 10
        Me.txtCodCargo.Name = "txtCodCargo"
        Me.txtCodCargo.Size = New System.Drawing.Size(77, 22)
        Me.txtCodCargo.TabIndex = 3
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "2,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.Location = New System.Drawing.Point(10, 148)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(662, 107)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cargo:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(692, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Módulo Caja"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtMontoUifAcumuladoOM)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.txtMontoOtrosMedios)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.txtMontoUIFAcumulado)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.txtMontoUIF)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.c1MontoLeyLavado)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 279)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'txtMontoUifAcumuladoOM
        '
        Me.txtMontoUifAcumuladoOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoUifAcumuladoOM.CustomFormat = "###,###,##0.00"
        Me.txtMontoUifAcumuladoOM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoUifAcumuladoOM.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMontoUifAcumuladoOM.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMontoUifAcumuladoOM.Location = New System.Drawing.Point(282, 149)
        Me.txtMontoUifAcumuladoOM.Name = "txtMontoUifAcumuladoOM"
        Me.txtMontoUifAcumuladoOM.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMontoUifAcumuladoOM.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMontoUifAcumuladoOM.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMontoUifAcumuladoOM.Size = New System.Drawing.Size(154, 26)
        Me.txtMontoUifAcumuladoOM.TabIndex = 93
        Me.txtMontoUifAcumuladoOM.Tag = Nothing
        Me.txtMontoUifAcumuladoOM.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoUifAcumuladoOM.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(7, 149)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(223, 25)
        Me.Label37.TabIndex = 92
        Me.Label37.Text = "Monto UIF Acumulado Otros Medios:"
        '
        'txtMontoOtrosMedios
        '
        Me.txtMontoOtrosMedios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoOtrosMedios.CustomFormat = "###,###,##0.00"
        Me.txtMontoOtrosMedios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoOtrosMedios.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMontoOtrosMedios.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMontoOtrosMedios.Location = New System.Drawing.Point(282, 118)
        Me.txtMontoOtrosMedios.Name = "txtMontoOtrosMedios"
        Me.txtMontoOtrosMedios.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMontoOtrosMedios.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMontoOtrosMedios.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMontoOtrosMedios.Size = New System.Drawing.Size(154, 26)
        Me.txtMontoOtrosMedios.TabIndex = 91
        Me.txtMontoOtrosMedios.Tag = Nothing
        Me.txtMontoOtrosMedios.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoOtrosMedios.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(7, 121)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(197, 21)
        Me.Label36.TabIndex = 90
        Me.Label36.Text = "Monto UIF Otros Medios:"
        '
        'txtMontoUIFAcumulado
        '
        Me.txtMontoUIFAcumulado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoUIFAcumulado.CustomFormat = "###,###,##0.00"
        Me.txtMontoUIFAcumulado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoUIFAcumulado.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMontoUIFAcumulado.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMontoUIFAcumulado.Location = New System.Drawing.Point(282, 87)
        Me.txtMontoUIFAcumulado.Name = "txtMontoUIFAcumulado"
        Me.txtMontoUIFAcumulado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMontoUIFAcumulado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMontoUIFAcumulado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMontoUIFAcumulado.Size = New System.Drawing.Size(154, 26)
        Me.txtMontoUIFAcumulado.TabIndex = 89
        Me.txtMontoUIFAcumulado.Tag = Nothing
        Me.txtMontoUIFAcumulado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoUIFAcumulado.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(7, 92)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(144, 19)
        Me.Label35.TabIndex = 88
        Me.Label35.Text = "Monto UIF Acumulado:"
        '
        'txtMontoUIF
        '
        Me.txtMontoUIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoUIF.CustomFormat = "###,###,##0.00"
        Me.txtMontoUIF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoUIF.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMontoUIF.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMontoUIF.Location = New System.Drawing.Point(282, 55)
        Me.txtMontoUIF.Name = "txtMontoUIF"
        Me.txtMontoUIF.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMontoUIF.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMontoUIF.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMontoUIF.Size = New System.Drawing.Size(154, 27)
        Me.txtMontoUIF.TabIndex = 87
        Me.txtMontoUIF.Tag = Nothing
        Me.txtMontoUIF.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoUIF.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(7, 61)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(144, 19)
        Me.Label34.TabIndex = 86
        Me.Label34.Text = "Monto UIF:"
        '
        'c1MontoLeyLavado
        '
        Me.c1MontoLeyLavado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1MontoLeyLavado.CustomFormat = "###,###,##0.00"
        Me.c1MontoLeyLavado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1MontoLeyLavado.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1MontoLeyLavado.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1MontoLeyLavado.Location = New System.Drawing.Point(282, 24)
        Me.c1MontoLeyLavado.Name = "c1MontoLeyLavado"
        Me.c1MontoLeyLavado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1MontoLeyLavado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1MontoLeyLavado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1MontoLeyLavado.Size = New System.Drawing.Size(154, 27)
        Me.c1MontoLeyLavado.TabIndex = 85
        Me.c1MontoLeyLavado.Tag = Nothing
        Me.c1MontoLeyLavado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1MontoLeyLavado.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 19)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Ley lavado de dinero:"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(692, 294)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Módulo Ahorros"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.c1nTmpInact)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.c1nMontoDPF)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.c1nMaxNumLib)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(672, 278)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'c1nTmpInact
        '
        Me.c1nTmpInact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTmpInact.CustomFormat = "###,###,##0"
        Me.c1nTmpInact.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTmpInact.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTmpInact.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTmpInact.Location = New System.Drawing.Point(420, 90)
        Me.c1nTmpInact.Name = "c1nTmpInact"
        Me.c1nTmpInact.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTmpInact.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTmpInact.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTmpInact.Size = New System.Drawing.Size(86, 27)
        Me.c1nTmpInact.TabIndex = 2
        Me.c1nTmpInact.Tag = Nothing
        Me.c1nTmpInact.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTmpInact.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(19, 90)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(346, 38)
        Me.Label23.TabIndex = 81
        Me.Label23.Text = "Cantidad de días de inactividad en aportaciones para aplicar proceso de exclusión" &
    ":"
        '
        'c1nMontoDPF
        '
        Me.c1nMontoDPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoDPF.CustomFormat = "###,###,##0.00"
        Me.c1nMontoDPF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoDPF.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoDPF.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMontoDPF.Location = New System.Drawing.Point(420, 59)
        Me.c1nMontoDPF.Name = "c1nMontoDPF"
        Me.c1nMontoDPF.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoDPF.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoDPF.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoDPF.Size = New System.Drawing.Size(154, 26)
        Me.c1nMontoDPF.TabIndex = 1
        Me.c1nMontoDPF.Tag = Nothing
        Me.c1nMontoDPF.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoDPF.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(19, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(394, 18)
        Me.Label22.TabIndex = 80
        Me.Label22.Text = "Monto desde el cual aplica autorización para cancelar DPF:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(19, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(346, 18)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Máximo número de líneas impreso en libreta de ahorros:"
        '
        'c1nMaxNumLib
        '
        Me.c1nMaxNumLib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMaxNumLib.CustomFormat = "###0"
        Me.c1nMaxNumLib.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMaxNumLib.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMaxNumLib.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMaxNumLib.Location = New System.Drawing.Point(420, 22)
        Me.c1nMaxNumLib.Name = "c1nMaxNumLib"
        Me.c1nMaxNumLib.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMaxNumLib.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMaxNumLib.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMaxNumLib.Size = New System.Drawing.Size(67, 26)
        Me.c1nMaxNumLib.TabIndex = 0
        Me.c1nMaxNumLib.Tag = Nothing
        Me.c1nMaxNumLib.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMaxNumLib.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(692, 294)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Módulo Contabilidad"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.txtCargoF3)
        Me.GroupBox6.Controls.Add(Me.txtCargo3)
        Me.GroupBox6.Controls.Add(Me.txtComite3)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txtCodigoF3)
        Me.GroupBox6.Controls.Add(Me.txtCodigoF2)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.txtCargoF2)
        Me.GroupBox6.Controls.Add(Me.txtCargo2)
        Me.GroupBox6.Controls.Add(Me.txtComite2)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txtCargoF1)
        Me.GroupBox6.Controls.Add(Me.txtCargo1)
        Me.GroupBox6.Controls.Add(Me.txtComite1)
        Me.GroupBox6.Controls.Add(Me.txtCodigoF1)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.txtFirma6)
        Me.GroupBox6.Controls.Add(Me.txtCodFirma6)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.txtFirma5)
        Me.GroupBox6.Controls.Add(Me.txtCodFirma5)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.txtFirma4)
        Me.GroupBox6.Controls.Add(Me.txtCodFirma4)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Location = New System.Drawing.Point(14, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(668, 277)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Firmas para Estado de Resultados y Balance General:"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(326, 120)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(269, 18)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Seleccione Nombre/Cargo (Firma 3):"
        '
        'txtCargoF3
        '
        Me.txtCargoF3.BackColor = System.Drawing.Color.White
        Me.txtCargoF3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargoF3.Location = New System.Drawing.Point(326, 138)
        Me.txtCargoF3.MaxLength = 10
        Me.txtCargoF3.Name = "txtCargoF3"
        Me.txtCargoF3.Size = New System.Drawing.Size(39, 22)
        Me.txtCargoF3.TabIndex = 16
        '
        'txtCargo3
        '
        Me.txtCargo3.BackColor = System.Drawing.Color.White
        Me.txtCargo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargo3.Location = New System.Drawing.Point(374, 138)
        Me.txtCargo3.Name = "txtCargo3"
        Me.txtCargo3.ReadOnly = True
        Me.txtCargo3.Size = New System.Drawing.Size(279, 22)
        Me.txtCargo3.TabIndex = 17
        '
        'txtComite3
        '
        Me.txtComite3.BackColor = System.Drawing.Color.White
        Me.txtComite3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComite3.Location = New System.Drawing.Point(58, 138)
        Me.txtComite3.MaxLength = 100
        Me.txtComite3.Name = "txtComite3"
        Me.txtComite3.ReadOnly = True
        Me.txtComite3.Size = New System.Drawing.Size(259, 22)
        Me.txtComite3.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(10, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(288, 18)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Seleccione el Consejo o Comité para Firma 3:"
        '
        'txtCodigoF3
        '
        Me.txtCodigoF3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoF3.Location = New System.Drawing.Point(10, 138)
        Me.txtCodigoF3.MaxLength = 10
        Me.txtCodigoF3.Name = "txtCodigoF3"
        Me.txtCodigoF3.Size = New System.Drawing.Size(38, 22)
        Me.txtCodigoF3.TabIndex = 13
        '
        'txtCodigoF2
        '
        Me.txtCodigoF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoF2.Location = New System.Drawing.Point(10, 92)
        Me.txtCodigoF2.MaxLength = 10
        Me.txtCodigoF2.Name = "txtCodigoF2"
        Me.txtCodigoF2.Size = New System.Drawing.Size(38, 22)
        Me.txtCodigoF2.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(326, 74)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(269, 18)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Seleccione Nombre/Cargo (Firma 2):"
        '
        'txtCargoF2
        '
        Me.txtCargoF2.BackColor = System.Drawing.Color.White
        Me.txtCargoF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargoF2.Location = New System.Drawing.Point(326, 92)
        Me.txtCargoF2.MaxLength = 10
        Me.txtCargoF2.Name = "txtCargoF2"
        Me.txtCargoF2.Size = New System.Drawing.Size(39, 22)
        Me.txtCargoF2.TabIndex = 10
        '
        'txtCargo2
        '
        Me.txtCargo2.BackColor = System.Drawing.Color.White
        Me.txtCargo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargo2.Location = New System.Drawing.Point(374, 92)
        Me.txtCargo2.Name = "txtCargo2"
        Me.txtCargo2.ReadOnly = True
        Me.txtCargo2.Size = New System.Drawing.Size(279, 22)
        Me.txtCargo2.TabIndex = 11
        '
        'txtComite2
        '
        Me.txtComite2.BackColor = System.Drawing.Color.White
        Me.txtComite2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComite2.Location = New System.Drawing.Point(58, 92)
        Me.txtComite2.MaxLength = 100
        Me.txtComite2.Name = "txtComite2"
        Me.txtComite2.ReadOnly = True
        Me.txtComite2.Size = New System.Drawing.Size(259, 22)
        Me.txtComite2.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(10, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(288, 18)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Seleccione el Consejo o Comité para Firma 2:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(326, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(269, 18)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Seleccione Nombre/Cargo (Firma 1):"
        '
        'txtCargoF1
        '
        Me.txtCargoF1.BackColor = System.Drawing.Color.White
        Me.txtCargoF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargoF1.Location = New System.Drawing.Point(326, 46)
        Me.txtCargoF1.MaxLength = 10
        Me.txtCargoF1.Name = "txtCargoF1"
        Me.txtCargoF1.Size = New System.Drawing.Size(39, 22)
        Me.txtCargoF1.TabIndex = 4
        '
        'txtCargo1
        '
        Me.txtCargo1.BackColor = System.Drawing.Color.White
        Me.txtCargo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargo1.Location = New System.Drawing.Point(374, 46)
        Me.txtCargo1.Name = "txtCargo1"
        Me.txtCargo1.ReadOnly = True
        Me.txtCargo1.Size = New System.Drawing.Size(279, 22)
        Me.txtCargo1.TabIndex = 5
        '
        'txtComite1
        '
        Me.txtComite1.BackColor = System.Drawing.Color.White
        Me.txtComite1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComite1.Location = New System.Drawing.Point(58, 46)
        Me.txtComite1.MaxLength = 100
        Me.txtComite1.Name = "txtComite1"
        Me.txtComite1.ReadOnly = True
        Me.txtComite1.Size = New System.Drawing.Size(259, 22)
        Me.txtComite1.TabIndex = 2
        '
        'txtCodigoF1
        '
        Me.txtCodigoF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoF1.Location = New System.Drawing.Point(10, 46)
        Me.txtCodigoF1.MaxLength = 10
        Me.txtCodigoF1.Name = "txtCodigoF1"
        Me.txtCodigoF1.Size = New System.Drawing.Size(38, 22)
        Me.txtCodigoF1.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(10, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(288, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Seleccione el Consejo o Comité para Firma 1:"
        '
        'txtFirma6
        '
        Me.txtFirma6.BackColor = System.Drawing.Color.White
        Me.txtFirma6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirma6.Location = New System.Drawing.Point(163, 231)
        Me.txtFirma6.Name = "txtFirma6"
        Me.txtFirma6.ReadOnly = True
        Me.txtFirma6.Size = New System.Drawing.Size(490, 22)
        Me.txtFirma6.TabIndex = 26
        '
        'txtCodFirma6
        '
        Me.txtCodFirma6.BackColor = System.Drawing.Color.White
        Me.txtCodFirma6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodFirma6.Location = New System.Drawing.Point(77, 231)
        Me.txtCodFirma6.MaxLength = 10
        Me.txtCodFirma6.Name = "txtCodFirma6"
        Me.txtCodFirma6.Size = New System.Drawing.Size(77, 22)
        Me.txtCodFirma6.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(10, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 18)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Firma 6:"
        '
        'txtFirma5
        '
        Me.txtFirma5.BackColor = System.Drawing.Color.White
        Me.txtFirma5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirma5.Location = New System.Drawing.Point(163, 203)
        Me.txtFirma5.Name = "txtFirma5"
        Me.txtFirma5.ReadOnly = True
        Me.txtFirma5.Size = New System.Drawing.Size(490, 22)
        Me.txtFirma5.TabIndex = 23
        '
        'txtCodFirma5
        '
        Me.txtCodFirma5.BackColor = System.Drawing.Color.White
        Me.txtCodFirma5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodFirma5.Location = New System.Drawing.Point(77, 203)
        Me.txtCodFirma5.MaxLength = 10
        Me.txtCodFirma5.Name = "txtCodFirma5"
        Me.txtCodFirma5.Size = New System.Drawing.Size(77, 22)
        Me.txtCodFirma5.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(10, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 19)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Firma 5:"
        '
        'txtFirma4
        '
        Me.txtFirma4.BackColor = System.Drawing.Color.White
        Me.txtFirma4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirma4.Location = New System.Drawing.Point(163, 175)
        Me.txtFirma4.Name = "txtFirma4"
        Me.txtFirma4.ReadOnly = True
        Me.txtFirma4.Size = New System.Drawing.Size(490, 22)
        Me.txtFirma4.TabIndex = 20
        '
        'txtCodFirma4
        '
        Me.txtCodFirma4.BackColor = System.Drawing.Color.White
        Me.txtCodFirma4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodFirma4.Location = New System.Drawing.Point(77, 175)
        Me.txtCodFirma4.MaxLength = 10
        Me.txtCodFirma4.Name = "txtCodFirma4"
        Me.txtCodFirma4.Size = New System.Drawing.Size(77, 22)
        Me.txtCodFirma4.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(10, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 19)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Firma 4:"
        '
        'tpModuloCobranza
        '
        Me.tpModuloCobranza.BackColor = System.Drawing.Color.White
        Me.tpModuloCobranza.Controls.Add(Me.txtRes_CtasInc)
        Me.tpModuloCobranza.Controls.Add(Me.lblReservaCtasInc)
        Me.tpModuloCobranza.Location = New System.Drawing.Point(4, 25)
        Me.tpModuloCobranza.Name = "tpModuloCobranza"
        Me.tpModuloCobranza.Padding = New System.Windows.Forms.Padding(3)
        Me.tpModuloCobranza.Size = New System.Drawing.Size(692, 294)
        Me.tpModuloCobranza.TabIndex = 5
        Me.tpModuloCobranza.Text = "Módulo Cobranza"
        '
        'txtRes_CtasInc
        '
        Me.txtRes_CtasInc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRes_CtasInc.CustomFormat = "###,###,##0.00"
        Me.txtRes_CtasInc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRes_CtasInc.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtRes_CtasInc.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtRes_CtasInc.Location = New System.Drawing.Point(224, 35)
        Me.txtRes_CtasInc.Name = "txtRes_CtasInc"
        Me.txtRes_CtasInc.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtRes_CtasInc.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtRes_CtasInc.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtRes_CtasInc.Size = New System.Drawing.Size(154, 26)
        Me.txtRes_CtasInc.TabIndex = 6
        Me.txtRes_CtasInc.Tag = Nothing
        Me.txtRes_CtasInc.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRes_CtasInc.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblReservaCtasInc
        '
        Me.lblReservaCtasInc.AutoSize = True
        Me.lblReservaCtasInc.Location = New System.Drawing.Point(7, 35)
        Me.lblReservaCtasInc.Name = "lblReservaCtasInc"
        Me.lblReservaCtasInc.Size = New System.Drawing.Size(232, 17)
        Me.lblReservaCtasInc.TabIndex = 0
        Me.lblReservaCtasInc.Text = "Reserva Para Cuentas Incobrables:"
        '
        'tpConfiguraciones
        '
        Me.tpConfiguraciones.Controls.Add(Me.MetroLabel2)
        Me.tpConfiguraciones.Controls.Add(Me.MetroLabel1)
        Me.tpConfiguraciones.Controls.Add(Me.Label41)
        Me.tpConfiguraciones.Controls.Add(Me.txtContraseniaRS)
        Me.tpConfiguraciones.Controls.Add(Me.txtUsuarioRs)
        Me.tpConfiguraciones.Controls.Add(Me.Label40)
        Me.tpConfiguraciones.Controls.Add(Me.txtUrlRs)
        Me.tpConfiguraciones.Controls.Add(Me.Label39)
        Me.tpConfiguraciones.Controls.Add(Me.txtRutaRs)
        Me.tpConfiguraciones.Controls.Add(Me.Label38)
        Me.tpConfiguraciones.Location = New System.Drawing.Point(4, 25)
        Me.tpConfiguraciones.Name = "tpConfiguraciones"
        Me.tpConfiguraciones.Size = New System.Drawing.Size(692, 294)
        Me.tpConfiguraciones.TabIndex = 6
        Me.tpConfiguraciones.Text = "Configuraciones"
        Me.tpConfiguraciones.UseVisualStyleBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel2.Location = New System.Drawing.Point(7, 105)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(221, 20)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "Inicio de Sesión Servidor Reportes"
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel1.Location = New System.Drawing.Point(7, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(211, 20)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel1.TabIndex = 8
        Me.MetroLabel1.Text = "Configuración Servidor Reportes"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(4, 164)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(85, 17)
        Me.Label41.TabIndex = 7
        Me.Label41.Text = "Contraseña "
        '
        'txtContraseniaRS
        '
        Me.txtContraseniaRS.Location = New System.Drawing.Point(236, 160)
        Me.txtContraseniaRS.Name = "txtContraseniaRS"
        Me.txtContraseniaRS.Size = New System.Drawing.Size(394, 22)
        Me.txtContraseniaRS.TabIndex = 6
        '
        'txtUsuarioRs
        '
        Me.txtUsuarioRs.Location = New System.Drawing.Point(236, 130)
        Me.txtUsuarioRs.Name = "txtUsuarioRs"
        Me.txtUsuarioRs.Size = New System.Drawing.Size(394, 22)
        Me.txtUsuarioRs.TabIndex = 5
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(4, 134)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(61, 17)
        Me.Label40.TabIndex = 4
        Me.Label40.Text = "Usuario "
        '
        'txtUrlRs
        '
        Me.txtUrlRs.Location = New System.Drawing.Point(236, 78)
        Me.txtUrlRs.Name = "txtUrlRs"
        Me.txtUrlRs.Size = New System.Drawing.Size(394, 22)
        Me.txtUrlRs.TabIndex = 3
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(4, 82)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(179, 17)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "URL Servidor de Reportes:"
        '
        'txtRutaRs
        '
        Me.txtRutaRs.Location = New System.Drawing.Point(236, 48)
        Me.txtRutaRs.Name = "txtRutaRs"
        Me.txtRutaRs.Size = New System.Drawing.Size(394, 22)
        Me.txtRutaRs.TabIndex = 1
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(4, 48)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(247, 17)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Ruta Servidor de Reportes (/carpeta/)"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(638, 403)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsGnParametros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(755, 487)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(755, 487)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(755, 487)
        Me.Name = "frmMsGnParametros"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Parámetros Generales"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtAniosVigencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCambioContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasaSeguro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHipotecarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResVoluntaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nIva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSalarioMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tbGral.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.c1nTasaDPF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroDanios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NESeguroDeuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nEdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCuotasSeguro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDetalle.ResumeLayout(False)
        Me.tbDetalle.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtMontoUifAcumuladoOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoOtrosMedios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoUIFAcumulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoUIF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1MontoLeyLavado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.c1nTmpInact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoDPF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMaxNumLib, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tpModuloCobranza.ResumeLayout(False)
        Me.tpModuloCobranza.PerformLayout()
        CType(Me.txtRes_CtasInc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpConfiguraciones.ResumeLayout(False)
        Me.tpConfiguraciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMsGnParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Dim oPlan As New wrPlanilla.wsLibPlanilla, dsCargos As New DataSet
        Dim Filas As Data.DataRowCollection
        vModifica = False
        ds = oAsoc.ConsultarParametros("*", "", "SalarioMinimo", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        If Filas.Count > 0 Then
            vModifica = True
            Me.c1nSalarioMinimo.Value = IIf(IsDBNull(Filas.Item(0)("SalarioMinimo")), 0, Filas.Item(0)("SalarioMinimo"))
            Me.c1nIva.Value = IIf(IsDBNull(Filas.Item(0)("Iva")), 0, Filas.Item(0)("Iva"))
            Me.c1MontoLeyLavado.Value = IIf(IsDBNull(Filas.Item(0)("Ley_Lavado_Dinero")), 0, Filas.Item(0)("Ley_Lavado_Dinero"))
            Me.c1nCuotasSeguro.Value = IIf(IsDBNull(Filas.Item(0)("CuotasSeguro")), 0, Filas.Item(0)("CuotasSeguro"))
            Me.c1nMaxNumLib.Value = IIf(IsDBNull(Filas.Item(0)("MaxNumLibreta")), 52, Filas.Item(0)("MaxNumLibreta"))
            Me.c1nEdad.Value = IIf(IsDBNull(Filas.Item(0)("EdadMax")), 0, Filas.Item(0)("EdadMax"))
            Me.C1NESeguroDeuda.Value = IIf(IsDBNull(Filas.Item(0)("SeguroDeuda")), 0, Filas.Item(0)("SeguroDeuda"))
            Me.C1NESeguroDanios.Value = IIf(IsDBNull(Filas.Item(0)("SeguroDanios")), 0, Filas.Item(0)("SeguroDanios"))
            Me.c1nTasaDPF.Value = IIf(IsDBNull(Filas.Item(0)("PuntosDPF")), 0, Filas.Item(0)("PuntosDPF"))
            Me.txtCargoF1.Text = IIf(IsDBNull(Filas.Item(0)("Firma1")), "", Filas.Item(0)("Firma1"))
            Me.txtCargoF2.Text = IIf(IsDBNull(Filas.Item(0)("Firma2")), "", Filas.Item(0)("Firma2"))
            Me.txtCargoF3.Text = IIf(IsDBNull(Filas.Item(0)("Firma3")), "", Filas.Item(0)("Firma3"))
            Me.txtCodFirma4.Text = IIf(IsDBNull(Filas.Item(0)("Firma4")), "", Filas.Item(0)("Firma4"))
            Me.txtCodFirma5.Text = IIf(IsDBNull(Filas.Item(0)("Firma5")), "", Filas.Item(0)("Firma5"))
            Me.txtCodFirma6.Text = IIf(IsDBNull(Filas.Item(0)("Firma6")), "", Filas.Item(0)("Firma6"))
            Me.c1nMontoDPF.Value = IIf(IsDBNull(Filas.Item(0)("MontoDPF")), 0, Filas.Item(0)("MontoDPF"))
            Me.c1nTmpInact.Value = IIf(IsDBNull(Filas.Item(0)("TiempoInact")), 0, Filas.Item(0)("TiempoInact"))
            ''********************************************'********************************************'********************************
            'Modificacion 08-06-2012                                                                                                   *
            'Javier Martinez                                                                                                           *
            'Inclusion de campo ReservaCtaIncobrables                                                                                  *
            Me.txtRes_CtasInc.Value = IIf(IsDBNull(Filas.Item(0)("ReservaCtaIncobrables")), 0, Filas.Item(0)("ReservaCtaIncobrables")) '*
            Me.txtResVoluntaria.Value = IIf(IsDBNull(Filas.Item(0)("reservaVoluntaria")), 0, Filas.Item(0)("reservaVoluntaria")) '*
            Me.txtCtaTransitoria.Text = IIf(IsDBNull(Filas.Item(0)("ctaTransitoria")), "", Filas.Item(0)("ctaTransitoria")) '*
            Me.txtCtaIva.Text = IIf(IsDBNull(Filas.Item(0)("CtaIva")), "", Filas.Item(0)("CtaIva")) '*
            Me.txtCtaInt.Text = IIf(IsDBNull(Filas.Item(0)("CtaInt")), "", Filas.Item(0)("CtaInt")) '*
            Me.txtCtaISR.Text = IIf(IsDBNull(Filas.Item(0)("CtaIsr")), "", Filas.Item(0)("CtaIsr")) '*
            Me.txtCtaCargaPlanillas.Text = IIf(IsDBNull(Filas.Item(0)("CtaCargaPlanillas")), "", Filas.Item(0)("CtaCargaPlanillas")) '*
            Me.txtHipotecarios.Value = IIf(IsDBNull(Filas.Item(0)("PorcentajeHipo")), 0, Filas.Item(0)("PorcentajeHipo")) '*
            Me.txtCambioContraseña.Value = IIf(IsDBNull(Filas.Item(0)("CambioContraseña")), 1, Filas.Item(0)("CambioContraseña")) '*
            Me.txtAniosVigencia.Value = IIf(IsDBNull(Filas.Item(0)("AniosMaxDui")), 1, Filas.Item(0)("AniosMaxDui")) '*
            Me.txtMontoUIF.Value = IIf(IsDBNull(Filas.Item(0)("montoUIF")), 0, Filas.Item(0)("montoUIF")) '*
            Me.txtMontoUIFAcumulado.Value = IIf(IsDBNull(Filas.Item(0)("montoUIFacumulado")), 0, Filas.Item(0)("montoUIFacumulado")) '*
            Me.txtMontoOtrosMedios.Value = IIf(IsDBNull(Filas.Item(0)("montoUIFOtrosMedios")), 0, Filas.Item(0)("montoUIFOtrosMedios")) '*
            Me.txtMontoUifAcumuladoOM.Value = IIf(IsDBNull(Filas.Item(0)("montoUIFAcumuladoOM")), 0, Filas.Item(0)("montoUIFAcumuladoOM")) '*
            Me.txtTasaSeguro.Value = IIf(IsDBNull(Filas.Item(0)("tasaSeguro")), 0, Filas.Item(0)("tasaSeguro")) '*
            Me.txtRutaRs.Text = IIf(IsDBNull(Filas.Item(0)("rutaRS")), "", Filas.Item(0)("rutaRS")) '*
            Me.txtUrlRs.Text = IIf(IsDBNull(Filas.Item(0)("urlRS")), "", Filas.Item(0)("urlRS")) '*
            Me.txtUsuarioRs.Text = IIf(IsDBNull(Filas.Item(0)("usuarioRs")), "", Filas.Item(0)("usuarioRs")) '*
            Me.txtContraseniaRS.Text = IIf(IsDBNull(Filas.Item(0)("contraseniaRs")), "", Filas.Item(0)("contraseniaRs")) '*

            ''********************************************'********************************************'********************************
            If Me.txtCodFirma4.Text.Trim <> "" Then
                ds = oPlan.ConsultarPLCargos("Descripcion", "CodCargo='" & Me.txtCodFirma4.Text.Trim & "'", "CodCargo", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtFirma4.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                End If
            End If

            If Me.txtCodFirma5.Text.Trim <> "" Then
                ds = oPlan.ConsultarPLCargos("Descripcion", "CodCargo='" & Me.txtCodFirma5.Text.Trim & "'", "CodCargo", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtFirma5.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                End If
            End If

            If Me.txtCodFirma6.Text.Trim <> "" Then
                ds = oPlan.ConsultarPLCargos("Descripcion", "CodCargo='" & Me.txtCodFirma6.Text.Trim & "'", "CodCargo", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtFirma6.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                End If
            End If

            If Me.txtCargoF1.Text.Trim <> "" Then
                ds = oAsoc.ConsultarDetDirectivos("Codigo,Nombre", "Correlativo=" & Me.txtCargoF1.Text.Trim & "", "Correlativo", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCargo1.Text = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
                    ds = oAsoc.ConsultarDirectivos("Codigo,Descripcion", "Codigo='" & dr("Codigo") & "'", "Codigo", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Me.txtCodigoF1.Text = IIf(IsDBNull(dr("Codigo")), "", dr("Codigo"))
                        Me.txtComite1.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                    End If
                End If
            End If

            If Me.txtCargoF2.Text.Trim <> "" Then
                ds = oAsoc.ConsultarDetDirectivos("Codigo,Nombre", "Correlativo=" & Me.txtCargoF2.Text.Trim & "", "Correlativo", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCargo2.Text = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
                    ds = oAsoc.ConsultarDirectivos("Codigo,Descripcion", "Codigo='" & dr("Codigo") & "'", "Codigo", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Me.txtCodigoF2.Text = IIf(IsDBNull(dr("Codigo")), "", dr("Codigo"))
                        Me.txtComite2.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                    End If
                End If
            End If

            If Me.txtCargoF3.Text.Trim <> "" Then
                ds = oAsoc.ConsultarDetDirectivos("Codigo,Nombre", "Correlativo=" & Me.txtCargoF3.Text.Trim & "", "Correlativo", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCargo3.Text = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
                    ds = oAsoc.ConsultarDirectivos("Codigo,Descripcion", "Codigo='" & dr("Codigo") & "'", "Codigo", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Me.txtCodigoF3.Text = IIf(IsDBNull(dr("Codigo")), "", dr("Codigo"))
                        Me.txtComite3.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                    End If
                End If
            End If

            ds = oAsoc.ConsultarFirmas(sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        End If
    End Sub



    Private Sub txtCodCargo2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCargo2.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String
        Try
            ofrm.Text = "Buscar Cargos"
            ds = oPlan.ConsultarPLCargos("*", "", "CodCargo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                sResultado1 = ofrm.Resultado.Trim
                sResultado2 = ofrm.Resultado2.Trim
                Me.txtCodCargo2.Text = sResultado1
                Me.txtDescCargo2.Text = sResultado2
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos.", MsgBoxStyle.Critical, "Módulo General")
        End Try
    End Sub

    Private Sub txtCodCargo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCargo.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String
        Try
            ofrm.Text = "Buscar Cargos"
            ds = oPlan.ConsultarPLCargos("*", "", "CodCargo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                sResultado1 = ofrm.Resultado.Trim
                sResultado2 = ofrm.Resultado2.Trim
                Me.txtCodCargo.Text = sResultado1
                Me.txtDescCargo.Text = sResultado2
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos.", MsgBoxStyle.Critical, "Módulo General")
        End Try
    End Sub



    Private Sub txtCodigoF1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoF1.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Directivos - Comités"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarDirectivos("*", "", "Codigo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodigoF1.Text = ofrm.Resultado.Trim
            Me.txtComite1.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Directivos - Comités - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodigoF2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoF2.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Directivos - Comités"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarDirectivos("*", "", "Codigo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodigoF2.Text = ofrm.Resultado.Trim
            Me.txtComite2.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Directivos - Comités - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodigoF3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoF3.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Directivos - Comités"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarDirectivos("*", "", "Codigo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodigoF3.Text = ofrm.Resultado.Trim
            Me.txtComite3.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Directivos - Comités - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCargoF1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCargoF1.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Cargos - Comités"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarDetDirectivos("*", "Codigo=" & Me.txtCodigoF1.Text.Trim & "", "Codigo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCargoF1.Text = ofrm.Resultado.Trim
            Me.txtCargo1.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Directivos - Comités - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCargoF2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCargoF2.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Cargos - Comités"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarDetDirectivos("*", "Codigo=" & Me.txtCodigoF2.Text.Trim & "", "Codigo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCargoF2.Text = ofrm.Resultado.Trim
            Me.txtCargo2.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Directivos - Comités - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCargoF3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCargoF3.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Cargos - Comités"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarDetDirectivos("*", "Codigo=" & Me.txtCodigoF3.Text.Trim & "", "Codigo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCargoF3.Text = ofrm.Resultado.Trim
            Me.txtCargo3.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Directivos - Comités - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodFirma4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodFirma4.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String
        Try
            ofrm.Text = "Buscar Cargos"
            ds = oPlan.ConsultarPLCargos("*", "", "CodCargo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                sResultado1 = ofrm.Resultado.Trim
                sResultado2 = ofrm.Resultado2.Trim
                Me.txtCodFirma4.Text = sResultado1
                Me.txtFirma4.Text = sResultado2
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos.", MsgBoxStyle.Critical, "Módulo General")
        End Try
    End Sub

    Private Sub txtCodFirma5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodFirma5.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String
        Try
            ofrm.Text = "Buscar Cargos"
            ds = oPlan.ConsultarPLCargos("*", "", "CodCargo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                sResultado1 = ofrm.Resultado.Trim
                sResultado2 = ofrm.Resultado2.Trim
                Me.txtCodFirma5.Text = sResultado1
                Me.txtFirma5.Text = sResultado2
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos.", MsgBoxStyle.Critical, "Módulo General")
        End Try
    End Sub

    Private Sub txtCodFirma6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodFirma6.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String
        Try
            ofrm.Text = "Buscar Cargos"
            ds = oPlan.ConsultarPLCargos("*", "", "CodCargo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                sResultado1 = ofrm.Resultado.Trim
                sResultado2 = ofrm.Resultado2.Trim
                Me.txtCodFirma6.Text = sResultado1
                Me.txtFirma6.Text = sResultado2
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos.", MsgBoxStyle.Critical, "Módulo General")
        End Try
    End Sub
    Private Sub txtRes_CtasInc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim numero As Double
            numero = CDbl(Me.txtRes_CtasInc.Text)
        Catch ex As Exception
            MsgBox("Este campo solo admite valores de tipo numérico.", MsgBoxStyle.Critical, "Módulo General")
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String
            If vModifica = False Then
                '***************************************************
                'Modificacin 08-06-2012                         ****
                'Inclusión de campo MontoReservaIncobrabilidad  ****
                'Javier Martinez                                ****
                'Insert                                         ****
                'pCampos = "SalarioMinimo,Iva,Ley_Lavado_Dinero,CuotasSeguro,MaxNumLibreta,EdadMax,SeguroDeuda,SeguroDanios,PuntosDPF,Firma1,Firma2,Firma3,Firma4,Firma5,Firma6,MontoDPF,TiempoInact"
                'pValores = "" & Me.c1nSalarioMinimo.Value & "," & Me.c1nIva.Value & "," & Me.c1MontoLeyLavado.Value & "," & Me.c1nCuotasSeguro.Value & "," & c1nMaxNumLib.Value & "," & Me.c1nEdad.Value & "," & Me.C1NESeguroDeuda.Value & "," & Me.C1NESeguroDanios.Value & "," & Me.c1nTasaDPF.Value & ",'" & Me.txtCargoF1.Text.Trim & "','" & Me.txtCargoF2.Text.Trim & "','" & Me.txtCargoF3.Text.Trim & "','" & Me.txtCodFirma4.Text.Trim & "','" & Me.txtCodFirma5.Text.Trim & "','" & Me.txtCodFirma6.Text.Trim & "'," & Me.c1nMontoDPF.Value & "," & Me.c1nTmpInact.Value & ""
                'Update
                '   pCampos = "SalarioMinimo=" & Me.c1nSalarioMinimo.Value & ",Iva=" & Me.c1nIva.Value & ",Ley_Lavado_Dinero=" & Me.c1MontoLeyLavado.Value & ",CuotasSeguro=" & Me.c1nCuotasSeguro.Value & ",MaxNumLibreta=" & c1nMaxNumLib.Value & ",EdadMax=" & Me.c1nEdad.Value & ",SeguroDeuda=" & Me.C1NESeguroDeuda.Value & ",SeguroDanios=" & Me.C1NESeguroDanios.Value & ",PuntosDPF=" & Me.c1nTasaDPF.Value & ",Firma1='" & Me.txtCargoF1.Text.Trim & "',Firma2='" & Me.txtCargoF2.Text.Trim & "',Firma3='" & Me.txtCargoF3.Text.Trim & "',Firma4='" & Me.txtCodFirma4.Text.Trim & "',Firma5='" & Me.txtCodFirma5.Text.Trim & "',Firma6='" & Me.txtCodFirma6.Text.Trim & "',MontoDPF=" & Me.c1nMontoDPF.Value & ",TiempoInact=" & Me.c1nTmpInact.Value & ""
                '***************************************************
                pCampos = "SalarioMinimo,Iva," &
                    "Ley_Lavado_Dinero,CuotasSeguro, " &
                    "MaxNumLibreta,EdadMax, " &
                    "SeguroDeuda,SeguroDanios, " &
                    "PuntosDPF,Firma1, " &
                    "Firma2,Firma3, " &
                    "Firma4,Firma5, " &
                    "Firma6,MontoDPF, " &
                    "TiempoInact,ReservaCtaIncobrables," &
                    "ReservaVoluntaria,CtaTransitoria, " &
                    "CtaIva,CtaInt, " &
                    "CtaIsr,CtaCargaPlanillas, " &
                    "PorcentajeHipo,CambioContraseña, " &
                    "AniosMaxDui,tasaSeguro, " &
                    "montoUIFacumulado,montoUIFOtrosMedios, " &
                    "montoUIFAcumuladoOM,MontoUIF, " &
                    "rutaRS,urlRS, " &
                    "usuarioRs,contraseniaRs"

                pValores = "" & Me.c1nSalarioMinimo.Value & "," & Me.c1nIva.Value &
                    "," & Me.c1MontoLeyLavado.Value & "," & Me.c1nCuotasSeguro.Value &
                    "," & c1nMaxNumLib.Value & "," & Me.c1nEdad.Value &
                    "," & Me.C1NESeguroDeuda.Value & "," & Me.C1NESeguroDanios.Value &
                    "," & Me.c1nTasaDPF.Value & ",'" & Me.txtCargoF1.Text.Trim &
                    "','" & Me.txtCargoF2.Text.Trim & "','" & Me.txtCargoF3.Text.Trim &
                    "','" & Me.txtCodFirma4.Text.Trim & "','" & Me.txtCodFirma5.Text.Trim &
                    "','" & Me.txtCodFirma6.Text.Trim & "'," & Me.c1nMontoDPF.Value &
                    "," & Me.c1nTmpInact.Value & "," & Me.txtRes_CtasInc.Value &
                    ", " & txtResVoluntaria.Value & " , '" & txtCtaTransitoria.Text.Trim &
                    "','" & txtCtaIva.Text.Trim & "', '" & txtCtaInt.Text.Trim &
                    "','" & txtCtaISR.Text.Trim & "', '" & txtCtaCargaPlanillas.Text.Trim &
                    "','" & txtHipotecarios.Value & "', '" & txtCambioContraseña.Value &
                    "','" & txtAniosVigencia.Value & "', '" & txtTasaSeguro.Value &
                    "','" & txtMontoUIFAcumulado.Value & "', '" & txtMontoOtrosMedios.Value &
                    "','" & txtMontoUifAcumuladoOM.Value & "', '" & txtMontoUIF.Value &
                    "', '" & txtRutaRs.Text & "', '" & txtUrlRs.Text &
                    "', '" & txtUsuarioRs.Text & "', '" & txtContraseniaRS.Text & "' "
                If oAsoc.InsertarParametros(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                End If
            ElseIf vModifica = True Then
                pCampos = "SalarioMinimo=" & Me.c1nSalarioMinimo.Value &
                    ",Iva=" & Me.c1nIva.Value &
                    ",Ley_Lavado_Dinero=" & Me.c1MontoLeyLavado.Value &
                    ",CuotasSeguro=" & Me.c1nCuotasSeguro.Value &
                    ",MaxNumLibreta=" & c1nMaxNumLib.Value &
                    ",EdadMax=" & Me.c1nEdad.Value &
                    ",SeguroDeuda=" & Me.C1NESeguroDeuda.Value &
                    ",SeguroDanios=" & Me.C1NESeguroDanios.Value &
                    ",PuntosDPF=" & Me.c1nTasaDPF.Value &
                    ",Firma1='" & Me.txtCargoF1.Text.Trim &
                    "',Firma2='" & Me.txtCargoF2.Text.Trim &
                    "',Firma3='" & Me.txtCargoF3.Text.Trim &
                    "',Firma4='" & Me.txtCodFirma4.Text.Trim &
                    "',Firma5='" & Me.txtCodFirma5.Text.Trim &
                    "',Firma6='" & Me.txtCodFirma6.Text.Trim &
                    "',MontoDPF=" & Me.c1nMontoDPF.Value &
                    ",TiempoInact=" & Me.c1nTmpInact.Value &
                    ",ReservaCtaIncobrables=" & Me.txtRes_CtasInc.Text &
                    ",ReservaVoluntaria = '" & txtResVoluntaria.Value &
                    "', CtaTransitoria ='" & txtCtaTransitoria.Text.Trim &
                    "',CtaIva ='" & txtCtaIva.Text.Trim &
                    "',CtaInt = '" & txtCtaInt.Text.Trim &
                    "',CtaIsr='" & txtCtaISR.Text.Trim &
                    "',CtaCargaPlanillas = '" & txtCtaCargaPlanillas.Text &
                    "',PorcentajeHipo='" & txtHipotecarios.Value &
                    "',CambioContraseña = '" & txtCambioContraseña.Value &
                    "',AniosMaxDui = '" & txtAniosVigencia.Value &
                    "',tasaSeguro = '" & txtTasaSeguro.Value &
                    "',montoUIFacumulado = '" & txtMontoUIFAcumulado.Value &
                    "',montoUIFOtrosMedios = '" & txtMontoOtrosMedios.Value &
                    "',montoUIFAcumuladoOM = '" & txtMontoUifAcumuladoOM.Value &
                    "',MontoUIF = '" & txtMontoUIF.Value &
                    "',rutaRs = '" & txtRutaRs.Text &
                    "',urlRs = '" & txtUrlRs.Text &
                    "',usuarioRs = '" & txtUsuarioRs.Text &
                    "',contraseniaRs = '" & txtContraseniaRS.Text & "' "
                If oAsoc.ModificarParametros("", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.txtTipo.Text <> "" Then
                Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                oAsoc.InsertarFirmas("Tipo,CodCargo,CodCargo2", "'" & Me.txtTipo.Text.Trim & "','" & Me.txtCodCargo.Text.Trim & "','" & Me.txtCodCargo2.Text.Trim & "'", sUsuario, sPassword, sSucursal)
                Me.txtTipo.Text = ""
                Me.txtCodCargo.Text = ""
                Me.txtDescCargo.Text = ""
                Me.txtCodCargo2.Text = ""
                Me.txtDescCargo2.Text = ""
                ds = oAsoc.ConsultarFirmas(sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim ds As New DataSet
            If fg.Row <> -1 Then
                If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Firma") = MsgBoxResult.Yes Then
                    Dim oAsoc As New wrAsociados.wsLibAsoc
                    oAsoc.EliminarFirmas("Tipo='" & fg.Item(fg.Row, "Tipo") & "'", sUsuario, sPassword, sSucursal)
                    ds = oAsoc.ConsultarFirmas(sUsuario, sPassword, sSucursal)
                    fg.DataSource = ds.Tables(0)
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class