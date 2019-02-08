Public Class frmMsCBGestionCredito
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim DatosFiador As DataSet


#Region "Variables privadas del formulario"
    Private vCodGestor, vCodPrestamo, Tipo As String, vCodEnlace As String, vCodEnlaceFiador As String, vCodEnlaceCodeudor As String
    Private NumSolicitud As Integer, vCodTablaAmortiza As String
    Friend WithEvents tb6 As System.Windows.Forms.TabPage
    Friend WithEvents tb1 As System.Windows.Forms.TabPage
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents txtGarantia As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents txtCapitalMora As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents lblCodPrestamo As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNIT As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoAsoc As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAditivosCobrar As System.Windows.Forms.TextBox
    Friend WithEvents txtCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtDiasEnMora As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtNoCuotasMora As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaAportacion As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaComision As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaSegDanios As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaSegDeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaInteresMora As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaInteres As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoCapital As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFechaVencimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtFechaOtorgamiento As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtFechaPrimeraCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTasaInteresMora As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMontoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents txtTasaInteres As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtCuotaTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents gbGestion As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaPactada As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtGestor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodDespacho As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents txtNoCuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblCompromiso As System.Windows.Forms.Label
    Friend WithEvents lblRango As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAcuerdo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCobranza As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoCobranza As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDespacho As System.Windows.Forms.TextBox
    Friend WithEvents lblDespacho As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents fgGestiones As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents txtOtros As System.Windows.Forms.TextBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnCobrosGestion1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnTablaSimulada1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultarTbAmortiza1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label121 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtDUICliente As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNITCliente As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnEstadoCta As MetroFramework.Controls.MetroButton
    Friend WithEvents fgCodeudor As C1.Win.C1FlexGrid.C1FlexGrid
#End Region

#Region "Propiedades públicas del formulario"

    Public Property CodGestor() As String
        Get
            Return vCodGestor
        End Get
        Set(ByVal Value As String)
            vCodGestor = Value
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

#End Region

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
    Friend WithEvents tbGestionCredito As System.Windows.Forms.TabControl
    Friend WithEvents tb3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents fgFiador As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tb5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCBGestionCredito))
        Me.tbGestionCredito = New System.Windows.Forms.TabControl()
        Me.tb1 = New System.Windows.Forms.TabPage()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtGarantia = New System.Windows.Forms.TextBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.txtNoAsoc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNIT = New C1.Win.C1Input.C1TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblCodPrestamo = New System.Windows.Forms.Label()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFechaOtorgamiento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFechaPrimeraCuota = New System.Windows.Forms.TextBox()
        Me.txtFechaVencimiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiasEnMora = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTasaInteres = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNoCuotasMora = New System.Windows.Forms.TextBox()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMontoGarantia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTasaInteresMora = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCuotaTotal = New System.Windows.Forms.TextBox()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.txtCuota = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaAhorro = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaAportacion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaInteres = New System.Windows.Forms.TextBox()
        Me.txtSaldoDiaInteresMora = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaComision = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaSegDeuda = New System.Windows.Forms.TextBox()
        Me.txtSaldoDiaSegDanios = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.txtCapitalMora = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtAditivosCobrar = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtSaldoCapital = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbGestion = New System.Windows.Forms.GroupBox()
        Me.btnEstadoCta = New MetroFramework.Controls.MetroButton()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.dtpFechaPactada = New System.Windows.Forms.DateTimePicker()
        Me.txtGestor = New System.Windows.Forms.TextBox()
        Me.btnAdd1 = New MetroFramework.Controls.MetroButton()
        Me.txtCodDespacho = New System.Windows.Forms.TextBox()
        Me.txtNoCuotas = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblCompromiso = New System.Windows.Forms.Label()
        Me.lblRango = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtHora = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtAcuerdo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTipoCobranza = New System.Windows.Forms.TextBox()
        Me.txtCodTipoCobranza = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDespacho = New System.Windows.Forms.TextBox()
        Me.lblDespacho = New System.Windows.Forms.Label()
        Me.tb6 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.fgGestiones = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tb3 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.fgCodeudor = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.fgFiador = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tb5 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnTablaSimulada1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultarTbAmortiza1 = New MetroFramework.Controls.MetroButton()
        Me.btnCobrosGestion1 = New MetroFramework.Controls.MetroButton()
        Me.txtDUICliente = New C1.Win.C1Input.C1TextBox()
        Me.txtNITCliente = New C1.Win.C1Input.C1TextBox()
        Me.tbGestionCredito.SuspendLayout()
        Me.tb1.SuspendLayout()
        Me.gbDatDoc.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.gbGestion.SuspendLayout()
        Me.tb6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.fgGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.fgCodeudor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.fgFiador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDUICliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNITCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbGestionCredito
        '
        Me.tbGestionCredito.Controls.Add(Me.tb1)
        Me.tbGestionCredito.Controls.Add(Me.tb6)
        Me.tbGestionCredito.Controls.Add(Me.tb3)
        Me.tbGestionCredito.Controls.Add(Me.tb5)
        Me.tbGestionCredito.Location = New System.Drawing.Point(28, 73)
        Me.tbGestionCredito.Name = "tbGestionCredito"
        Me.tbGestionCredito.SelectedIndex = 0
        Me.tbGestionCredito.Size = New System.Drawing.Size(931, 723)
        Me.tbGestionCredito.TabIndex = 0
        '
        'tb1
        '
        Me.tb1.BackColor = System.Drawing.Color.White
        Me.tb1.Controls.Add(Me.gbDatDoc)
        Me.tb1.Controls.Add(Me.gbGestion)
        Me.tb1.Location = New System.Drawing.Point(4, 25)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(923, 694)
        Me.tb1.TabIndex = 0
        Me.tb1.Text = "Gestión de Crédito"
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.lblTipoDocumento)
        Me.gbDatDoc.Controls.Add(Me.MetroTabControl1)
        Me.gbDatDoc.Controls.Add(Me.txtTotal)
        Me.gbDatDoc.Controls.Add(Me.Label87)
        Me.gbDatDoc.Controls.Add(Me.txtCapitalMora)
        Me.gbDatDoc.Controls.Add(Me.Label58)
        Me.gbDatDoc.Controls.Add(Me.txtAditivosCobrar)
        Me.gbDatDoc.Controls.Add(Me.Label27)
        Me.gbDatDoc.Controls.Add(Me.txtSaldoCapital)
        Me.gbDatDoc.Controls.Add(Me.Label18)
        Me.gbDatDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Teal
        Me.gbDatDoc.Location = New System.Drawing.Point(4, 329)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(907, 338)
        Me.gbDatDoc.TabIndex = 1
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Datos Generales del Préstamo"
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.BackColor = System.Drawing.Color.White
        Me.lblTipoDocumento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.lblTipoDocumento.Location = New System.Drawing.Point(601, 18)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(221, 19)
        Me.lblTipoDocumento.TabIndex = 1
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(10, 22)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 2
        Me.MetroTabControl1.Size = New System.Drawing.Size(902, 235)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.Color.White
        Me.MetroTabPage1.Controls.Add(Me.Label35)
        Me.MetroTabPage1.Controls.Add(Me.txtFormaPago)
        Me.MetroTabPage1.Controls.Add(Me.txtNombre)
        Me.MetroTabPage1.Controls.Add(Me.Label116)
        Me.MetroTabPage1.Controls.Add(Me.Label16)
        Me.MetroTabPage1.Controls.Add(Me.txtGarantia)
        Me.MetroTabPage1.Controls.Add(Me.Label115)
        Me.MetroTabPage1.Controls.Add(Me.txtNoAsoc)
        Me.MetroTabPage1.Controls.Add(Me.Label14)
        Me.MetroTabPage1.Controls.Add(Me.txtDui)
        Me.MetroTabPage1.Controls.Add(Me.txtNIT)
        Me.MetroTabPage1.Controls.Add(Me.Label29)
        Me.MetroTabPage1.Controls.Add(Me.Label31)
        Me.MetroTabPage1.Controls.Add(Me.lblCodPrestamo)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 12
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(894, 193)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Información General"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 12
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(4, 12)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(118, 21)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Nombre Asociado:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BackColor = System.Drawing.Color.White
        Me.txtFormaPago.Location = New System.Drawing.Point(126, 143)
        Me.txtFormaPago.Multiline = True
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(758, 32)
        Me.txtFormaPago.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(126, 13)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(758, 23)
        Me.txtNombre.TabIndex = 1
        '
        'Label116
        '
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.ForeColor = System.Drawing.Color.Black
        Me.Label116.Location = New System.Drawing.Point(4, 147)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(96, 47)
        Me.Label116.TabIndex = 12
        Me.Label116.Text = "Forma de pago:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(4, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 23)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "No. Asociado:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGarantia
        '
        Me.txtGarantia.BackColor = System.Drawing.Color.White
        Me.txtGarantia.Location = New System.Drawing.Point(126, 104)
        Me.txtGarantia.Multiline = True
        Me.txtGarantia.Name = "txtGarantia"
        Me.txtGarantia.ReadOnly = True
        Me.txtGarantia.Size = New System.Drawing.Size(758, 32)
        Me.txtGarantia.TabIndex = 11
        '
        'Label115
        '
        Me.Label115.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.ForeColor = System.Drawing.Color.Black
        Me.Label115.Location = New System.Drawing.Point(4, 113)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(76, 17)
        Me.Label115.TabIndex = 10
        Me.Label115.Text = "Garantía:"
        '
        'txtNoAsoc
        '
        Me.txtNoAsoc.BackColor = System.Drawing.Color.White
        Me.txtNoAsoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoAsoc.Location = New System.Drawing.Point(126, 44)
        Me.txtNoAsoc.MaxLength = 8
        Me.txtNoAsoc.Name = "txtNoAsoc"
        Me.txtNoAsoc.ReadOnly = True
        Me.txtNoAsoc.Size = New System.Drawing.Size(187, 23)
        Me.txtNoAsoc.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(320, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 19)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "DUI:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(437, 44)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.ReadOnly = True
        Me.txtDui.Size = New System.Drawing.Size(187, 21)
        Me.txtDui.TabIndex = 5
        Me.txtDui.Tag = Nothing
        '
        'txtNIT
        '
        Me.txtNIT.BackColor = System.Drawing.Color.White
        Me.txtNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNIT.EditMask = "0000-000000-000-0"
        Me.txtNIT.Location = New System.Drawing.Point(126, 74)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.NumericInput = False
        Me.txtNIT.ReadOnly = True
        Me.txtNIT.Size = New System.Drawing.Size(187, 21)
        Me.txtNIT.TabIndex = 7
        Me.txtNIT.Tag = Nothing
        Me.txtNIT.Value = ""
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(4, 77)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(38, 19)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "NIT:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(320, 77)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(110, 21)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Préstamo:"
        '
        'lblCodPrestamo
        '
        Me.lblCodPrestamo.BackColor = System.Drawing.Color.White
        Me.lblCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodPrestamo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPrestamo.ForeColor = System.Drawing.Color.Black
        Me.lblCodPrestamo.Location = New System.Drawing.Point(437, 77)
        Me.lblCodPrestamo.Name = "lblCodPrestamo"
        Me.lblCodPrestamo.Size = New System.Drawing.Size(187, 22)
        Me.lblCodPrestamo.TabIndex = 9
        Me.lblCodPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.Label30)
        Me.MetroTabPage2.Controls.Add(Me.txtMonto)
        Me.MetroTabPage2.Controls.Add(Me.Label12)
        Me.MetroTabPage2.Controls.Add(Me.txtFechaOtorgamiento)
        Me.MetroTabPage2.Controls.Add(Me.Label11)
        Me.MetroTabPage2.Controls.Add(Me.txtFechaPrimeraCuota)
        Me.MetroTabPage2.Controls.Add(Me.txtFechaVencimiento)
        Me.MetroTabPage2.Controls.Add(Me.Label5)
        Me.MetroTabPage2.Controls.Add(Me.txtDiasEnMora)
        Me.MetroTabPage2.Controls.Add(Me.Label20)
        Me.MetroTabPage2.Controls.Add(Me.txtTasaInteres)
        Me.MetroTabPage2.Controls.Add(Me.Label13)
        Me.MetroTabPage2.Controls.Add(Me.txtNoCuotasMora)
        Me.MetroTabPage2.Controls.Add(Me.txtPlazo)
        Me.MetroTabPage2.Controls.Add(Me.Label19)
        Me.MetroTabPage2.Controls.Add(Me.Label48)
        Me.MetroTabPage2.Controls.Add(Me.txtCategoria)
        Me.MetroTabPage2.Controls.Add(Me.Label6)
        Me.MetroTabPage2.Controls.Add(Me.txtMontoGarantia)
        Me.MetroTabPage2.Controls.Add(Me.Label8)
        Me.MetroTabPage2.Controls.Add(Me.Label7)
        Me.MetroTabPage2.Controls.Add(Me.txtTasaInteresMora)
        Me.MetroTabPage2.Controls.Add(Me.Label10)
        Me.MetroTabPage2.Controls.Add(Me.txtCuotaTotal)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 12
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(894, 193)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Datos Préstamo"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 12
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(4, 14)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(126, 21)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Monto:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(137, 15)
        Me.txtMonto.MaxLength = 20
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(125, 23)
        Me.txtMonto.TabIndex = 1
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(269, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 26)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Fecha Otorgamiento:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaOtorgamiento
        '
        Me.txtFechaOtorgamiento.BackColor = System.Drawing.Color.White
        Me.txtFechaOtorgamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaOtorgamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaOtorgamiento.Location = New System.Drawing.Point(403, 15)
        Me.txtFechaOtorgamiento.MaxLength = 25
        Me.txtFechaOtorgamiento.Name = "txtFechaOtorgamiento"
        Me.txtFechaOtorgamiento.ReadOnly = True
        Me.txtFechaOtorgamiento.Size = New System.Drawing.Size(125, 23)
        Me.txtFechaOtorgamiento.TabIndex = 9
        Me.txtFechaOtorgamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(535, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 24)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Fecha Primera Cuota:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaPrimeraCuota
        '
        Me.txtFechaPrimeraCuota.BackColor = System.Drawing.Color.White
        Me.txtFechaPrimeraCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaPrimeraCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaPrimeraCuota.Location = New System.Drawing.Point(689, 14)
        Me.txtFechaPrimeraCuota.MaxLength = 25
        Me.txtFechaPrimeraCuota.Name = "txtFechaPrimeraCuota"
        Me.txtFechaPrimeraCuota.ReadOnly = True
        Me.txtFechaPrimeraCuota.Size = New System.Drawing.Size(125, 23)
        Me.txtFechaPrimeraCuota.TabIndex = 17
        Me.txtFechaPrimeraCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.BackColor = System.Drawing.Color.White
        Me.txtFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(137, 45)
        Me.txtFechaVencimiento.MaxLength = 25
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.ReadOnly = True
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(125, 23)
        Me.txtFechaVencimiento.TabIndex = 3
        Me.txtFechaVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha Vencimiento:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiasEnMora
        '
        Me.txtDiasEnMora.BackColor = System.Drawing.Color.White
        Me.txtDiasEnMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiasEnMora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasEnMora.Location = New System.Drawing.Point(403, 105)
        Me.txtDiasEnMora.MaxLength = 25
        Me.txtDiasEnMora.Name = "txtDiasEnMora"
        Me.txtDiasEnMora.ReadOnly = True
        Me.txtDiasEnMora.Size = New System.Drawing.Size(125, 23)
        Me.txtDiasEnMora.TabIndex = 15
        Me.txtDiasEnMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(269, 106)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 22)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Días en Mora:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTasaInteres
        '
        Me.txtTasaInteres.BackColor = System.Drawing.Color.White
        Me.txtTasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTasaInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaInteres.Location = New System.Drawing.Point(403, 45)
        Me.txtTasaInteres.MaxLength = 10
        Me.txtTasaInteres.Name = "txtTasaInteres"
        Me.txtTasaInteres.ReadOnly = True
        Me.txtTasaInteres.Size = New System.Drawing.Size(125, 23)
        Me.txtTasaInteres.TabIndex = 11
        Me.txtTasaInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(535, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 20)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Plazo en Meses:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoCuotasMora
        '
        Me.txtNoCuotasMora.BackColor = System.Drawing.Color.White
        Me.txtNoCuotasMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuotasMora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuotasMora.Location = New System.Drawing.Point(403, 75)
        Me.txtNoCuotasMora.MaxLength = 25
        Me.txtNoCuotasMora.Name = "txtNoCuotasMora"
        Me.txtNoCuotasMora.ReadOnly = True
        Me.txtNoCuotasMora.Size = New System.Drawing.Size(125, 23)
        Me.txtNoCuotasMora.TabIndex = 13
        Me.txtNoCuotasMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.Color.White
        Me.txtPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlazo.Location = New System.Drawing.Point(689, 44)
        Me.txtPlazo.MaxLength = 25
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.Size = New System.Drawing.Size(125, 23)
        Me.txtPlazo.TabIndex = 19
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(269, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(121, 22)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Cuotas Mora:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.White
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(269, 45)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(105, 18)
        Me.Label48.TabIndex = 10
        Me.Label48.Text = "Tasa de Interés:"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.White
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(137, 75)
        Me.txtCategoria.MaxLength = 25
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(125, 23)
        Me.txtCategoria.TabIndex = 5
        Me.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 22)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Categoría:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMontoGarantia
        '
        Me.txtMontoGarantia.BackColor = System.Drawing.Color.White
        Me.txtMontoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoGarantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoGarantia.Location = New System.Drawing.Point(137, 105)
        Me.txtMontoGarantia.MaxLength = 20
        Me.txtMontoGarantia.Name = "txtMontoGarantia"
        Me.txtMontoGarantia.ReadOnly = True
        Me.txtMontoGarantia.Size = New System.Drawing.Size(125, 23)
        Me.txtMontoGarantia.TabIndex = 7
        Me.txtMontoGarantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Monto Garantía:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(535, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Tasa Interés Mora:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTasaInteresMora
        '
        Me.txtTasaInteresMora.BackColor = System.Drawing.Color.White
        Me.txtTasaInteresMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTasaInteresMora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaInteresMora.Location = New System.Drawing.Point(689, 74)
        Me.txtTasaInteresMora.MaxLength = 10
        Me.txtTasaInteresMora.Name = "txtTasaInteresMora"
        Me.txtTasaInteresMora.ReadOnly = True
        Me.txtTasaInteresMora.Size = New System.Drawing.Size(125, 23)
        Me.txtTasaInteresMora.TabIndex = 21
        Me.txtTasaInteresMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(535, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 21)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Cuota Total:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuotaTotal
        '
        Me.txtCuotaTotal.BackColor = System.Drawing.Color.White
        Me.txtCuotaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuotaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaTotal.Location = New System.Drawing.Point(689, 104)
        Me.txtCuotaTotal.MaxLength = 50
        Me.txtCuotaTotal.Name = "txtCuotaTotal"
        Me.txtCuotaTotal.ReadOnly = True
        Me.txtCuotaTotal.Size = New System.Drawing.Size(125, 23)
        Me.txtCuotaTotal.TabIndex = 23
        Me.txtCuotaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.BackColor = System.Drawing.Color.White
        Me.MetroTabPage3.Controls.Add(Me.txtOtros)
        Me.MetroTabPage3.Controls.Add(Me.Label120)
        Me.MetroTabPage3.Controls.Add(Me.txtCuota)
        Me.MetroTabPage3.Controls.Add(Me.Label28)
        Me.MetroTabPage3.Controls.Add(Me.txtSaldoDiaAhorro)
        Me.MetroTabPage3.Controls.Add(Me.Label26)
        Me.MetroTabPage3.Controls.Add(Me.txtSaldoDiaAportacion)
        Me.MetroTabPage3.Controls.Add(Me.Label15)
        Me.MetroTabPage3.Controls.Add(Me.txtSaldoDiaInteres)
        Me.MetroTabPage3.Controls.Add(Me.txtSaldoDiaInteresMora)
        Me.MetroTabPage3.Controls.Add(Me.Label21)
        Me.MetroTabPage3.Controls.Add(Me.txtSaldoDiaComision)
        Me.MetroTabPage3.Controls.Add(Me.Label22)
        Me.MetroTabPage3.Controls.Add(Me.Label25)
        Me.MetroTabPage3.Controls.Add(Me.txtSaldoDiaSegDeuda)
        Me.MetroTabPage3.Controls.Add(Me.txtSaldoDiaSegDanios)
        Me.MetroTabPage3.Controls.Add(Me.Label24)
        Me.MetroTabPage3.Controls.Add(Me.Label17)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 12
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(894, 193)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Pendiente de pagar"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 12
        '
        'txtOtros
        '
        Me.txtOtros.BackColor = System.Drawing.Color.White
        Me.txtOtros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtros.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtros.Location = New System.Drawing.Point(649, 78)
        Me.txtOtros.MaxLength = 8
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.ReadOnly = True
        Me.txtOtros.Size = New System.Drawing.Size(96, 23)
        Me.txtOtros.TabIndex = 17
        Me.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.BackColor = System.Drawing.Color.White
        Me.Label120.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.ForeColor = System.Drawing.Color.Black
        Me.Label120.Location = New System.Drawing.Point(510, 83)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(47, 16)
        Me.Label120.TabIndex = 16
        Me.Label120.Text = "Otros:"
        Me.Label120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuota
        '
        Me.txtCuota.BackColor = System.Drawing.Color.White
        Me.txtCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuota.Location = New System.Drawing.Point(149, 18)
        Me.txtCuota.MaxLength = 8
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.ReadOnly = True
        Me.txtCuota.Size = New System.Drawing.Size(96, 23)
        Me.txtCuota.TabIndex = 1
        Me.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(10, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(132, 23)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Cuota Normal:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoDiaAhorro
        '
        Me.txtSaldoDiaAhorro.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaAhorro.Location = New System.Drawing.Point(391, 18)
        Me.txtSaldoDiaAhorro.MaxLength = 8
        Me.txtSaldoDiaAhorro.Name = "txtSaldoDiaAhorro"
        Me.txtSaldoDiaAhorro.ReadOnly = True
        Me.txtSaldoDiaAhorro.Size = New System.Drawing.Size(96, 23)
        Me.txtSaldoDiaAhorro.TabIndex = 7
        Me.txtSaldoDiaAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(252, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(132, 21)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Ahorro:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoDiaAportacion
        '
        Me.txtSaldoDiaAportacion.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaAportacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaAportacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaAportacion.Location = New System.Drawing.Point(649, 18)
        Me.txtSaldoDiaAportacion.MaxLength = 8
        Me.txtSaldoDiaAportacion.Name = "txtSaldoDiaAportacion"
        Me.txtSaldoDiaAportacion.ReadOnly = True
        Me.txtSaldoDiaAportacion.Size = New System.Drawing.Size(96, 23)
        Me.txtSaldoDiaAportacion.TabIndex = 13
        Me.txtSaldoDiaAportacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(510, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 19)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Aportación:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoDiaInteres
        '
        Me.txtSaldoDiaInteres.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaInteres.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaInteres.Location = New System.Drawing.Point(149, 48)
        Me.txtSaldoDiaInteres.MaxLength = 8
        Me.txtSaldoDiaInteres.Name = "txtSaldoDiaInteres"
        Me.txtSaldoDiaInteres.ReadOnly = True
        Me.txtSaldoDiaInteres.Size = New System.Drawing.Size(96, 23)
        Me.txtSaldoDiaInteres.TabIndex = 3
        Me.txtSaldoDiaInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoDiaInteresMora
        '
        Me.txtSaldoDiaInteresMora.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaInteresMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaInteresMora.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaInteresMora.Location = New System.Drawing.Point(391, 48)
        Me.txtSaldoDiaInteresMora.MaxLength = 8
        Me.txtSaldoDiaInteresMora.Name = "txtSaldoDiaInteresMora"
        Me.txtSaldoDiaInteresMora.ReadOnly = True
        Me.txtSaldoDiaInteresMora.Size = New System.Drawing.Size(96, 23)
        Me.txtSaldoDiaInteresMora.TabIndex = 9
        Me.txtSaldoDiaInteresMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(252, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 19)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Interés Moratorio:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoDiaComision
        '
        Me.txtSaldoDiaComision.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaComision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaComision.Location = New System.Drawing.Point(391, 78)
        Me.txtSaldoDiaComision.MaxLength = 8
        Me.txtSaldoDiaComision.Name = "txtSaldoDiaComision"
        Me.txtSaldoDiaComision.ReadOnly = True
        Me.txtSaldoDiaComision.Size = New System.Drawing.Size(96, 23)
        Me.txtSaldoDiaComision.TabIndex = 11
        Me.txtSaldoDiaComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(252, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(132, 22)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Seg. Vehiculo;"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(10, 47)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(105, 22)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Interés Normal:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoDiaSegDeuda
        '
        Me.txtSaldoDiaSegDeuda.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaSegDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaSegDeuda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaSegDeuda.Location = New System.Drawing.Point(149, 78)
        Me.txtSaldoDiaSegDeuda.MaxLength = 8
        Me.txtSaldoDiaSegDeuda.Name = "txtSaldoDiaSegDeuda"
        Me.txtSaldoDiaSegDeuda.ReadOnly = True
        Me.txtSaldoDiaSegDeuda.Size = New System.Drawing.Size(96, 23)
        Me.txtSaldoDiaSegDeuda.TabIndex = 5
        Me.txtSaldoDiaSegDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoDiaSegDanios
        '
        Me.txtSaldoDiaSegDanios.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaSegDanios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaSegDanios.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaSegDanios.Location = New System.Drawing.Point(649, 48)
        Me.txtSaldoDiaSegDanios.MaxLength = 8
        Me.txtSaldoDiaSegDanios.Name = "txtSaldoDiaSegDanios"
        Me.txtSaldoDiaSegDanios.ReadOnly = True
        Me.txtSaldoDiaSegDanios.Size = New System.Drawing.Size(95, 23)
        Me.txtSaldoDiaSegDanios.TabIndex = 15
        Me.txtSaldoDiaSegDanios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(510, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 19)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Seg.Daños:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(11, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 21)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Seg. Deuda:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(803, 264)
        Me.txtTotal.MaxLength = 8
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(96, 23)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label87
        '
        Me.Label87.BackColor = System.Drawing.Color.White
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.Teal
        Me.Label87.Location = New System.Drawing.Point(670, 262)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(134, 23)
        Me.Label87.TabIndex = 8
        Me.Label87.Text = "Total a Cancelar:"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCapitalMora
        '
        Me.txtCapitalMora.BackColor = System.Drawing.Color.White
        Me.txtCapitalMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCapitalMora.Location = New System.Drawing.Point(116, 264)
        Me.txtCapitalMora.MaxLength = 20
        Me.txtCapitalMora.Name = "txtCapitalMora"
        Me.txtCapitalMora.ReadOnly = True
        Me.txtCapitalMora.Size = New System.Drawing.Size(96, 23)
        Me.txtCapitalMora.TabIndex = 3
        Me.txtCapitalMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.White
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Teal
        Me.Label58.Location = New System.Drawing.Point(10, 265)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(104, 22)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "Capital Mora:"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAditivosCobrar
        '
        Me.txtAditivosCobrar.BackColor = System.Drawing.Color.White
        Me.txtAditivosCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAditivosCobrar.Location = New System.Drawing.Point(570, 264)
        Me.txtAditivosCobrar.MaxLength = 8
        Me.txtAditivosCobrar.Name = "txtAditivosCobrar"
        Me.txtAditivosCobrar.ReadOnly = True
        Me.txtAditivosCobrar.Size = New System.Drawing.Size(96, 23)
        Me.txtAditivosCobrar.TabIndex = 7
        Me.txtAditivosCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Teal
        Me.Label27.Location = New System.Drawing.Point(430, 265)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(135, 38)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Aditivos a Cobrar:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoCapital
        '
        Me.txtSaldoCapital.BackColor = System.Drawing.Color.White
        Me.txtSaldoCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoCapital.Location = New System.Drawing.Point(330, 267)
        Me.txtSaldoCapital.MaxLength = 20
        Me.txtSaldoCapital.Name = "txtSaldoCapital"
        Me.txtSaldoCapital.ReadOnly = True
        Me.txtSaldoCapital.Size = New System.Drawing.Size(95, 23)
        Me.txtSaldoCapital.TabIndex = 5
        Me.txtSaldoCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Teal
        Me.Label18.Location = New System.Drawing.Point(218, 266)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 20)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Saldo Capital:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbGestion
        '
        Me.gbGestion.BackColor = System.Drawing.Color.White
        Me.gbGestion.Controls.Add(Me.btnEstadoCta)
        Me.gbGestion.Controls.Add(Me.Label121)
        Me.gbGestion.Controls.Add(Me.MetroButton7)
        Me.gbGestion.Controls.Add(Me.dtpFechaPactada)
        Me.gbGestion.Controls.Add(Me.txtGestor)
        Me.gbGestion.Controls.Add(Me.btnAdd1)
        Me.gbGestion.Controls.Add(Me.txtCodDespacho)
        Me.gbGestion.Controls.Add(Me.txtNoCuotas)
        Me.gbGestion.Controls.Add(Me.Label32)
        Me.gbGestion.Controls.Add(Me.Label23)
        Me.gbGestion.Controls.Add(Me.lblCompromiso)
        Me.gbGestion.Controls.Add(Me.lblRango)
        Me.gbGestion.Controls.Add(Me.txtObservaciones)
        Me.gbGestion.Controls.Add(Me.Label4)
        Me.gbGestion.Controls.Add(Me.dtHora)
        Me.gbGestion.Controls.Add(Me.Label3)
        Me.gbGestion.Controls.Add(Me.dtFecha)
        Me.gbGestion.Controls.Add(Me.txtAcuerdo)
        Me.gbGestion.Controls.Add(Me.Label9)
        Me.gbGestion.Controls.Add(Me.txtTipoCobranza)
        Me.gbGestion.Controls.Add(Me.txtCodTipoCobranza)
        Me.gbGestion.Controls.Add(Me.Label2)
        Me.gbGestion.Controls.Add(Me.Label1)
        Me.gbGestion.Controls.Add(Me.txtDespacho)
        Me.gbGestion.Controls.Add(Me.lblDespacho)
        Me.gbGestion.Location = New System.Drawing.Point(4, 3)
        Me.gbGestion.Name = "gbGestion"
        Me.gbGestion.Size = New System.Drawing.Size(914, 319)
        Me.gbGestion.TabIndex = 0
        Me.gbGestion.TabStop = False
        '
        'btnEstadoCta
        '
        Me.btnEstadoCta.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnEstadoCta.Location = New System.Drawing.Point(499, 273)
        Me.btnEstadoCta.Name = "btnEstadoCta"
        Me.btnEstadoCta.Size = New System.Drawing.Size(114, 33)
        Me.btnEstadoCta.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEstadoCta.TabIndex = 22
        Me.btnEstadoCta.Text = "&Estado de Cuenta"
        Me.btnEstadoCta.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEstadoCta.UseSelectable = True
        Me.btnEstadoCta.UseStyleColors = True
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Location = New System.Drawing.Point(8, 18)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(55, 17)
        Me.Label121.TabIndex = 0
        Me.Label121.Text = "Gestor:"
        '
        'MetroButton7
        '
        Me.MetroButton7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.MetroButton7.Location = New System.Drawing.Point(622, 273)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(114, 33)
        Me.MetroButton7.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton7.TabIndex = 23
        Me.MetroButton7.Text = "&Datos Asociado"
        Me.MetroButton7.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton7.UseSelectable = True
        Me.MetroButton7.UseStyleColors = True
        '
        'dtpFechaPactada
        '
        Me.dtpFechaPactada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPactada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPactada.Location = New System.Drawing.Point(503, 210)
        Me.dtpFechaPactada.Name = "dtpFechaPactada"
        Me.dtpFechaPactada.Size = New System.Drawing.Size(110, 23)
        Me.dtpFechaPactada.TabIndex = 16
        '
        'txtGestor
        '
        Me.txtGestor.BackColor = System.Drawing.Color.White
        Me.txtGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGestor.Location = New System.Drawing.Point(140, 18)
        Me.txtGestor.Name = "txtGestor"
        Me.txtGestor.Size = New System.Drawing.Size(766, 22)
        Me.txtGestor.TabIndex = 1
        '
        'btnAdd1
        '
        Me.btnAdd1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnAdd1.Location = New System.Drawing.Point(742, 273)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(164, 33)
        Me.btnAdd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd1.TabIndex = 24
        Me.btnAdd1.Text = "&Guardar Gestión"
        Me.btnAdd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd1.UseSelectable = True
        Me.btnAdd1.UseStyleColors = True
        '
        'txtCodDespacho
        '
        Me.txtCodDespacho.BackColor = System.Drawing.Color.White
        Me.txtCodDespacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDespacho.Location = New System.Drawing.Point(110, 241)
        Me.txtCodDespacho.Name = "txtCodDespacho"
        Me.txtCodDespacho.Size = New System.Drawing.Size(98, 23)
        Me.txtCodDespacho.TabIndex = 20
        Me.txtCodDespacho.Visible = False
        '
        'txtNoCuotas
        '
        Me.txtNoCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuotas.Location = New System.Drawing.Point(689, 210)
        Me.txtNoCuotas.MaxLength = 20
        Me.txtNoCuotas.Name = "txtNoCuotas"
        Me.txtNoCuotas.Size = New System.Drawing.Size(217, 22)
        Me.txtNoCuotas.TabIndex = 18
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(619, 215)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 19)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "Monto:"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(381, 213)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(116, 19)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Fecha Pactada:"
        '
        'lblCompromiso
        '
        Me.lblCompromiso.BackColor = System.Drawing.Color.White
        Me.lblCompromiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompromiso.ForeColor = System.Drawing.Color.Teal
        Me.lblCompromiso.Location = New System.Drawing.Point(11, 93)
        Me.lblCompromiso.Name = "lblCompromiso"
        Me.lblCompromiso.Size = New System.Drawing.Size(895, 19)
        Me.lblCompromiso.TabIndex = 5
        Me.lblCompromiso.Text = "Compromiso de pago no debe exceder de "
        '
        'lblRango
        '
        Me.lblRango.BackColor = System.Drawing.Color.White
        Me.lblRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRango.ForeColor = System.Drawing.Color.Teal
        Me.lblRango.Location = New System.Drawing.Point(12, 75)
        Me.lblRango.Name = "lblRango"
        Me.lblRango.Size = New System.Drawing.Size(894, 18)
        Me.lblRango.TabIndex = 6
        Me.lblRango.Text = "Rango de morosidad:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtObservaciones.Location = New System.Drawing.Point(110, 167)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(796, 37)
        Me.txtObservaciones.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Observaciones:"
        '
        'dtHora
        '
        Me.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHora.Location = New System.Drawing.Point(301, 210)
        Me.dtHora.Name = "dtHora"
        Me.dtHora.Size = New System.Drawing.Size(74, 22)
        Me.dtHora.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(256, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Hora:"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(131, 210)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(119, 22)
        Me.dtFecha.TabIndex = 12
        '
        'txtAcuerdo
        '
        Me.txtAcuerdo.BackColor = System.Drawing.Color.White
        Me.txtAcuerdo.Location = New System.Drawing.Point(110, 123)
        Me.txtAcuerdo.Multiline = True
        Me.txtAcuerdo.Name = "txtAcuerdo"
        Me.txtAcuerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcuerdo.Size = New System.Drawing.Size(796, 37)
        Me.txtAcuerdo.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 19)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Fecha Gestión:"
        '
        'txtTipoCobranza
        '
        Me.txtTipoCobranza.BackColor = System.Drawing.Color.White
        Me.txtTipoCobranza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCobranza.Location = New System.Drawing.Point(215, 48)
        Me.txtTipoCobranza.MaxLength = 100
        Me.txtTipoCobranza.Name = "txtTipoCobranza"
        Me.txtTipoCobranza.ReadOnly = True
        Me.txtTipoCobranza.Size = New System.Drawing.Size(691, 22)
        Me.txtTipoCobranza.TabIndex = 4
        '
        'txtCodTipoCobranza
        '
        Me.txtCodTipoCobranza.BackColor = System.Drawing.Color.White
        Me.txtCodTipoCobranza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoCobranza.Location = New System.Drawing.Point(140, 48)
        Me.txtCodTipoCobranza.MaxLength = 20
        Me.txtCodTipoCobranza.Name = "txtCodTipoCobranza"
        Me.txtCodTipoCobranza.Size = New System.Drawing.Size(68, 22)
        Me.txtCodTipoCobranza.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 37)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Acuerdo o Comentario:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de Cobranza:"
        '
        'txtDespacho
        '
        Me.txtDespacho.BackColor = System.Drawing.Color.White
        Me.txtDespacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDespacho.Location = New System.Drawing.Point(215, 243)
        Me.txtDespacho.MaxLength = 100
        Me.txtDespacho.Name = "txtDespacho"
        Me.txtDespacho.Size = New System.Drawing.Size(691, 22)
        Me.txtDespacho.TabIndex = 21
        Me.txtDespacho.Visible = False
        '
        'lblDespacho
        '
        Me.lblDespacho.BackColor = System.Drawing.Color.White
        Me.lblDespacho.Location = New System.Drawing.Point(11, 246)
        Me.lblDespacho.Name = "lblDespacho"
        Me.lblDespacho.Size = New System.Drawing.Size(77, 18)
        Me.lblDespacho.TabIndex = 19
        Me.lblDespacho.Text = "Despacho:"
        Me.lblDespacho.Visible = False
        '
        'tb6
        '
        Me.tb6.BackColor = System.Drawing.Color.White
        Me.tb6.Controls.Add(Me.GroupBox3)
        Me.tb6.Location = New System.Drawing.Point(4, 25)
        Me.tb6.Name = "tb6"
        Me.tb6.Size = New System.Drawing.Size(923, 694)
        Me.tb6.TabIndex = 5
        Me.tb6.Tag = ""
        Me.tb6.Text = "Gestiones"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.fgGestiones)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(11, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(899, 613)
        Me.GroupBox3.TabIndex = 117
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestiones Realizadas"
        '
        'fgGestiones
        '
        Me.fgGestiones.AllowEditing = False
        Me.fgGestiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgGestiones.BackColor = System.Drawing.Color.White
        Me.fgGestiones.ColumnInfo = resources.GetString("fgGestiones.ColumnInfo")
        Me.fgGestiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgGestiones.Location = New System.Drawing.Point(7, 20)
        Me.fgGestiones.Name = "fgGestiones"
        Me.fgGestiones.Rows.Count = 2
        Me.fgGestiones.Rows.DefaultSize = 22
        Me.fgGestiones.Size = New System.Drawing.Size(885, 583)
        Me.fgGestiones.StyleInfo = resources.GetString("fgGestiones.StyleInfo")
        Me.fgGestiones.TabIndex = 60
        '
        'tb3
        '
        Me.tb3.BackColor = System.Drawing.Color.White
        Me.tb3.Controls.Add(Me.GroupBox5)
        Me.tb3.Controls.Add(Me.GroupBox4)
        Me.tb3.Location = New System.Drawing.Point(4, 25)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(923, 694)
        Me.tb3.TabIndex = 2
        Me.tb3.Text = "Datos Fiadores / Codeudores"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fgCodeudor)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox5.Location = New System.Drawing.Point(7, 328)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(907, 317)
        Me.GroupBox5.TabIndex = 65
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Codeudores"
        '
        'fgCodeudor
        '
        Me.fgCodeudor.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgCodeudor.AllowEditing = False
        Me.fgCodeudor.AllowFiltering = True
        Me.fgCodeudor.BackColor = System.Drawing.Color.White
        Me.fgCodeudor.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;AllowDragging:False;AllowEditing:F" &
    "alse;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgCodeudor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgCodeudor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgCodeudor.ForeColor = System.Drawing.Color.Teal
        Me.fgCodeudor.Location = New System.Drawing.Point(3, 19)
        Me.fgCodeudor.Name = "fgCodeudor"
        Me.fgCodeudor.Rows.Count = 2
        Me.fgCodeudor.Rows.DefaultSize = 22
        Me.fgCodeudor.Size = New System.Drawing.Size(901, 295)
        Me.fgCodeudor.StyleInfo = resources.GetString("fgCodeudor.StyleInfo")
        Me.fgCodeudor.TabIndex = 59
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.fgFiador)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(914, 318)
        Me.GroupBox4.TabIndex = 64
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fiador Solidario"
        '
        'fgFiador
        '
        Me.fgFiador.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgFiador.AllowEditing = False
        Me.fgFiador.AllowFiltering = True
        Me.fgFiador.BackColor = System.Drawing.Color.White
        Me.fgFiador.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgFiador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgFiador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgFiador.ForeColor = System.Drawing.Color.Teal
        Me.fgFiador.Location = New System.Drawing.Point(3, 19)
        Me.fgFiador.Name = "fgFiador"
        Me.fgFiador.Rows.Count = 2
        Me.fgFiador.Rows.DefaultSize = 22
        Me.fgFiador.Size = New System.Drawing.Size(908, 296)
        Me.fgFiador.StyleInfo = resources.GetString("fgFiador.StyleInfo")
        Me.fgFiador.TabIndex = 58
        '
        'tb5
        '
        Me.tb5.BackColor = System.Drawing.Color.Teal
        Me.tb5.Controls.Add(Me.GroupBox1)
        Me.tb5.Location = New System.Drawing.Point(4, 25)
        Me.tb5.Name = "tb5"
        Me.tb5.Size = New System.Drawing.Size(923, 694)
        Me.tb5.TabIndex = 4
        Me.tb5.Text = "Detalle Pagos"
        Me.tb5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.fg)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(922, 683)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle Movimientos"
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.Location = New System.Drawing.Point(5, 20)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(912, 595)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 58
        '
        'btnTablaSimulada1
        '
        Me.btnTablaSimulada1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnTablaSimulada1.Location = New System.Drawing.Point(752, 802)
        Me.btnTablaSimulada1.Name = "btnTablaSimulada1"
        Me.btnTablaSimulada1.Size = New System.Drawing.Size(203, 33)
        Me.btnTablaSimulada1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnTablaSimulada1.TabIndex = 3
        Me.btnTablaSimulada1.Text = "Consulta Tabla de &Simulación"
        Me.btnTablaSimulada1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnTablaSimulada1.UseSelectable = True
        Me.btnTablaSimulada1.UseStyleColors = True
        '
        'btnConsultarTbAmortiza1
        '
        Me.btnConsultarTbAmortiza1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnConsultarTbAmortiza1.Location = New System.Drawing.Point(520, 802)
        Me.btnConsultarTbAmortiza1.Name = "btnConsultarTbAmortiza1"
        Me.btnConsultarTbAmortiza1.Size = New System.Drawing.Size(226, 33)
        Me.btnConsultarTbAmortiza1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultarTbAmortiza1.TabIndex = 2
        Me.btnConsultarTbAmortiza1.Text = "Consulta &Tabla de Amortización"
        Me.btnConsultarTbAmortiza1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultarTbAmortiza1.UseSelectable = True
        Me.btnConsultarTbAmortiza1.UseStyleColors = True
        '
        'btnCobrosGestion1
        '
        Me.btnCobrosGestion1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnCobrosGestion1.Location = New System.Drawing.Point(384, 803)
        Me.btnCobrosGestion1.Name = "btnCobrosGestion1"
        Me.btnCobrosGestion1.Size = New System.Drawing.Size(130, 32)
        Me.btnCobrosGestion1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCobrosGestion1.TabIndex = 1
        Me.btnCobrosGestion1.Text = "&Cobro por Gestión"
        Me.btnCobrosGestion1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCobrosGestion1.UseSelectable = True
        Me.btnCobrosGestion1.UseStyleColors = True
        Me.btnCobrosGestion1.Visible = False
        '
        'txtDUICliente
        '
        Me.txtDUICliente.BackColor = System.Drawing.Color.White
        Me.txtDUICliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDUICliente.EditMask = "00000000-0"
        Me.txtDUICliente.Location = New System.Drawing.Point(329, 47)
        Me.txtDUICliente.Name = "txtDUICliente"
        Me.txtDUICliente.NumericInput = False
        Me.txtDUICliente.ReadOnly = True
        Me.txtDUICliente.Size = New System.Drawing.Size(120, 20)
        Me.txtDUICliente.TabIndex = 194
        Me.txtDUICliente.Tag = Nothing
        '
        'txtNITCliente
        '
        Me.txtNITCliente.BackColor = System.Drawing.Color.White
        Me.txtNITCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNITCliente.EditMask = "0000-000000-000-0"
        Me.txtNITCliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNITCliente.Location = New System.Drawing.Point(600, 47)
        Me.txtNITCliente.Name = "txtNITCliente"
        Me.txtNITCliente.NumericInput = False
        Me.txtNITCliente.ReadOnly = True
        Me.txtNITCliente.Size = New System.Drawing.Size(152, 21)
        Me.txtNITCliente.TabIndex = 196
        Me.txtNITCliente.Tag = Nothing
        '
        'frmMsCBGestionCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(983, 873)
        Me.Controls.Add(Me.tbGestionCredito)
        Me.Controls.Add(Me.btnCobrosGestion1)
        Me.Controls.Add(Me.btnConsultarTbAmortiza1)
        Me.Controls.Add(Me.btnTablaSimulada1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCBGestionCredito"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Gestión de Crédito"
        Me.tbGestionCredito.ResumeLayout(False)
        Me.tb1.ResumeLayout(False)
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.gbGestion.ResumeLayout(False)
        Me.gbGestion.PerformLayout()
        Me.tb6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.fgGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.fgCodeudor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.fgFiador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDUICliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNITCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Métodos"

    Private Sub EncabezadoCBGestiones()
        fgGestiones.Cols.Item(1).Caption = "CodGestor"
        fgGestiones.Cols.Item(2).Caption = "CodPrestamo"
        fgGestiones.Cols.Item(3).Caption = "FechaGestion"
        fgGestiones.Cols.Item(4).Caption = "Comentario"
        fgGestiones.Cols.Item(5).Caption = "Observaciones"
        fgGestiones.Cols.Item(6).Caption = "FechaPactada"

    End Sub

    Private Sub EncabezadoPRPagos()

        'fg.Cols.Item(1).Caption = "Número"
        ''fg.Cols.Item(2).Caption = "Código de Préstamo"
        'fg.Cols.Item(3).Caption = "Número Factura"
        'fg.Cols.Item(4).Caption = "Fecha Movimiento"
        'fg.Cols.Item(5).Caption = "Cód. Transacción"
        'fg.Cols.Item(6).Caption = "Monto Pagado"
        'fg.Cols.Item(7).Caption = "Abono Capital"
        'fg.Cols.Item(8).Caption = "Abono Interés"
        'fg.Cols.Item(9).Caption = "Abono Capital Mora"
        'fg.Cols.Item(10).Caption = "Abono Interés Mora"
        'fg.Cols.Item(11).Caption = "Abono Seguro de Deuda"
        'fg.Cols.Item(12).Caption = "Abono Seguro de Daños"
        'fg.Cols.Item(13).Caption = "Abono Seguro de Vida"
        'fg.Cols.Item(14).Caption = "Abono Seguro de Desempleo"
        'fg.Cols.Item(15).Caption = "Abono Aportación"
        'fg.Cols.Item(16).Caption = "Abono Ahorro"
        'fg.Cols.Item(17).Caption = "Abono Comisión de Manejo"
        'fg.Cols.Item(18).Caption = "Abono Otros"
        'fg.Cols.Item(19).Caption = "Cancelada"
        'fg.Cols.Item(20).Caption = "Tipo"

        'fg.Cols.Item(0).Width = 20
        'fg.Cols.Item(1).Width = 100
        ''fg.Cols.Item(2).Width = 75
        'fg.Cols.Item(2).Visible = False
        'fg.Cols.Item(3).Width = 100
        'fg.Cols.Item(4).Width = 75
        'fg.Cols.Item(5).Width = 150
        'fg.Cols.Item(6).Width = 250
        'fg.Cols.Item(7).Width = 250
        'fg.Cols.Item(8).Width = 250
        'fg.Cols.Item(9).Width = 250
        'fg.Cols.Item(10).Width = 250
        'fg.Cols.Item(11).Width = 250
        'fg.Cols.Item(12).Width = 250
        'fg.Cols.Item(13).Width = 250
        'fg.Cols.Item(14).Width = 250
        'fg.Cols.Item(15).Width = 250
        'fg.Cols.Item(16).Width = 250
        'fg.Cols.Item(17).Width = 250
        'fg.Cols.Item(18).Width = 250
        'fg.Cols.Item(19).Width = 100
        'fg.Cols.Item(20).Width = 100

        'Me.fg.Cols.Item(6).Format = "##0.00"
        'Me.fg.Cols.Item(7).Format = "##0.00"
        'Me.fg.Cols.Item(8).Format = "##0.00"
        'Me.fg.Cols.Item(9).Format = "##0.00"
        'Me.fg.Cols.Item(10).Format = "##0.00"
        'Me.fg.Cols.Item(11).Format = "##0.00"
        'Me.fg.Cols.Item(12).Format = "##0.00"
        'Me.fg.Cols.Item(13).Format = "##0.00"
        'Me.fg.Cols.Item(14).Format = "##0.00"
        'Me.fg.Cols.Item(15).Format = "##0.00"
        'Me.fg.Cols.Item(16).Format = "##0.00"
        'Me.fg.Cols.Item(17).Format = "##0.00"
        'Me.fg.Cols.Item(18).Format = "##0.00"
        'Me.fg.Cols.Item(24).Format = "##0.00"
        'Me.fg.Cols.Item(25).Format = "##0.00"

    End Sub

    Private Sub frmCBMsGestionCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, dsTmp As New DataSet, drTmp As DataRow
        Dim oAso As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Dim oPres As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
        Dim ds As New Data.DataSet
        Dim dr As DataRow
        Dim tipoDoc As String

        ds = oCred.ConsultarPrestamos("*", "CodPrestamo = '" & Me.CodPrestamo.Trim & "'", "", sUsuario, sPassword, sSucursal)
        dr = ds.Tables("PRPrestamos").Rows(0)
        NumSolicitud = CInt(dr("NumSolicitud"))
        vCodTablaAmortiza = IIf(IsDBNull(dr("CodTablaAmortiza")), " ", dr("CodTablaAmortiza"))
        Me.lblCodPrestamo.Text = Me.CodPrestamo.Trim
        ' Me.lblCodPrestamotb2.Text = Me.CodPrestamo.Trim
        'Me.lblCodPrestamotb3.Text = Me.CodPrestamo.Trim
        'Me.lblCodPrestamotb4.Text = Me.CodPrestamo.Trim
        Me.txtMonto.Text = Format(IIf(IsDBNull(dr("Monto")), 0, dr("Monto")), "###,##0.00")
        Me.txtMontoGarantia.Text = Format(IIf(IsDBNull(dr("Monto_Garantia")), 0, dr("Monto_Garantia")), "###,##0.00")
        Me.txtTasaInteres.Text = IIf(IsDBNull(dr("Tasa_Interes")), 0, dr("Tasa_Interes"))
        Me.txtTasaInteresMora.Text = Format(IIf(IsDBNull(dr("Tasa_Interes_Mora")), 0, dr("Tasa_Interes_Mora")), "###,##0.00")

        '***************SE MODIFICA EL TEXTBOX DEL NoACTA POR LA CUOTA TOTAL
        'Me.txtNoActa.Text = IIf(IsDBNull(dr("NoActa")), " ", dr("NoActa"))
        Me.txtCuotaTotal.Text = Format(IIf(IsDBNull(dr("CuotaTotal")), 0, dr("CuotaTotal")), "###,##0.00")

        Me.txtPlazo.Text = IIf(IsDBNull(dr("PlazoMeses")), 0, dr("PlazoMeses"))
        If Not IsDBNull(dr("FechaPrimeraCuota")) Then
            Me.txtFechaPrimeraCuota.Text = dr("FechaPrimeraCuota")
        End If
        If Not IsDBNull(dr("FechaOtorgamiento")) Then
            Me.txtFechaOtorgamiento.Text = dr("FechaOtorgamiento")
        End If
        Me.txtCategoria.Text = IIf(IsDBNull(dr("Categoria")), " ", dr("Categoria"))
        If Not IsDBNull(dr("Fechavencimiento")) Then
            Me.txtFechaVencimiento.Text = dr("FechaVencimiento")
        End If

        'INFO
        '*************** ACA SE MUESTRA LOS ADITIVOS A COBRAR ANTES TOTAL A COBRAR
        'Me.txtTotCobrarr.Text = Format(IIf(IsDBNull(dr("CuotaTotal")), 0, dr("CuotaTotal")) + IIf(IsDBNull(dr("SaldoDia_CapitalMora")), 0, dr("SaldoDia_CapitalMora")), "###,##0.00")
        Me.txtAditivosCobrar.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_Interes")), 0, dr("SaldoDia_Interes")), 2) +
                                           Math.Round(IIf(IsDBNull(dr("SaldoDia_InteresMora")), 0, dr("SaldoDia_InteresMora")), 2) +
                                           Math.Round(IIf(IsDBNull(dr("SaldoDia_SeguroDeuda")), 0, dr("SaldoDia_SeguroDeuda")), 2) +
                                           Math.Round(IIf(IsDBNull(dr("SaldoDia_SeguroDaniosyLA")), 0, dr("SaldoDia_SeguroDaniosyLA")), 2) +
                                           Math.Round(IIf(IsDBNull(dr("SaldoDia_SeguroVida")), 0, dr("SaldoDia_SeguroVida")), 2) +
                                           Math.Round(IIf(IsDBNull(dr("SaldoDia_SeguroDesempleo")), 0, dr("SaldoDia_SeguroDesempleo")), 2) +
                                           Math.Round(IIf(IsDBNull(dr("SaldoDia_Aportacion")), 0, dr("SaldoDia_Aportacion")), 2) +
                                           Math.Round(IIf(IsDBNull(dr("SaldoDia_Ahorro")), 0, dr("SaldoDia_Ahorro")), 2) +
                                           Math.Round(IIf(IsDBNull(dr("SaldoDia_ComisionManejo")), 0, dr("SaldoDia_ComisionManejo")), 2) +
                                           Math.Round(IIf(IsDBNull(dr("SaldoDia_Otros")), 0, dr("SaldoDia_Otros")), 2), "###,##0.00")

        Me.txtCuota.Text = Format(IIf(IsDBNull(dr("Cuota")), 0, dr("cuota")), "###,##0.00")
        Me.txtSaldoDiaInteres.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_Interes")), 0, dr("SaldoDia_Interes")), 2), "###,##0.00")
        '===================================================================================================================================
        'Modificacion Javier Martinez 29/08/2012
        'Se modifican el campo int.Mora para que muestre el valor sin importar si se encuentra en sus dias gracias
        Me.txtSaldoDiaInteresMora.Text = Format(IIf(IsDBNull(dr("SaldoDia_InteresMora")), 0, dr("SaldoDia_InteresMora")), "###,##0.00")
        'If dr("DiaGracia").ToString.Trim = "S" Then
        '    Me.txtSaldoDiaInteresMora.Text = Format(Math.Round(IIf(IsDBNull(dr("Saldo_IntMoraGracia")), 0, dr("Saldo_IntMoraGracia")), 2), "###,##0.00")
        'Else
        '    Me.txtSaldoDiaInteresMora.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_InteresMora")), 0, dr("SaldoDia_InteresMora")), 2), "###,##0.00")
        'End If
        '===================================================================================================================================
        Me.txtSaldoDiaSegDeuda.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_SeguroDeuda")), 0, dr("SaldoDia_SeguroDeuda")), 2), "###,##0.00")
        Me.txtSaldoDiaAhorro.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_Ahorro")), 0, dr("SaldoDia_Ahorro")), 2), "###,##0.00")
        Me.txtSaldoDiaSegDanios.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_SeguroDaniosyLA")), 0, dr("SaldoDia_SeguroDaniosyLA")), 2), "###,##0.00")
        Me.txtSaldoDiaComision.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_ComisionManejo")), 0, dr("SaldoDia_ComisionManejo")), 2), "###,##0.00")
        Me.txtSaldoDiaAportacion.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_Aportacion")), 0, dr("SaldoDia_Aportacion")), 2), "###,##0.00")
        Me.txtSaldoCapital.Text = Format(Math.Round(IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital")), 2), "###,##0.00")
        Me.txtDiasEnMora.Text = IIf(IsDBNull(dr("DiasMora")), 0, dr("DiasMora"))
        Me.txtNoCuotasMora.Text = Format(IIf(IsDBNull(dr("SaldoDia_CapitalMora")), 0, dr("SaldoDia_CapitalMora")) / IIf(IsDBNull(dr("Cuota")), 0, dr("Cuota")), "###,##0.00")

        Me.txtCapitalMora.Text = Math.Round(IIf(IsDBNull(dr("SaldoDia_CapitalMora")), 0, dr("SaldoDia_CapitalMora")), 2)
        Me.txtOtros.Text = Math.Round(IIf(IsDBNull(dr("SaldoDia_Otros")), 0, dr("SaldoDia_Otros")), 2)
        Me.txtTotal.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_Interes")), 0, dr("SaldoDia_Interes")), 2) +
                                  Math.Round(IIf(IsDBNull(dr("SaldoDia_Ahorro")), 0, dr("SaldoDia_Ahorro")), 2) +
                                  Math.Round(IIf(IsDBNull(dr("SaldoDia_Aportacion")), 0, dr("SaldoDia_Aportacion")), 2) +
                                  Math.Round(IIf(IsDBNull(dr("SaldoDia_ComisionManejo")), 0, dr("SaldoDia_ComisionManejo")), 2) +
                                  Math.Round(IIf(IsDBNull(dr("SaldoDia_SeguroDeuda")), 0, dr("SaldoDia_SeguroDeuda")), 2) +
                                  Math.Round(IIf(IsDBNull(dr("SaldoDia_SeguroDaniosyLA")), 0, dr("SaldoDia_SeguroDaniosyLA")), 2) +
                                  Math.Round(IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital")), 2) +
                                  Math.Round(IIf(IsDBNull(dr("SaldoDia_InteresMora")), 0, dr("SaldoDia_InteresMora")), 2) +
                                  Math.Round(IIf(IsDBNull(dr("SaldoDia_Otros")), 0, dr("SaldoDia_Otros")), 2) _
                                  , "###,##0.00")

        dsTmp = oCred.ConsultarGestoresxCredito("*", "CodPrestamo='" & Me.CodPrestamo.Trim & "' and Estado='A'", "*", sUsuario, sPassword, sSucursal)
        If dsTmp.Tables(0).Rows.Count > 0 Then
            drTmp = dsTmp.Tables(0).Rows(0)
            Me.txtGestor.Text = "Despacho / Colector asignado:" & vbCrLf & IIf(IsDBNull(drTmp("Nombre")), 0, drTmp("Nombre"))
        End If

        tipoDoc = IIf(IsDBNull(dr("Tipo")), "", dr("Tipo"))
        If tipoDoc = "S" Then
            lblTipoDocumento.Text = "Documento Saneado"
        ElseIf tipoDoc = "P" Then
            lblTipoDocumento.Text = "Documento en Protesto"
        ElseIf tipoDoc = "N" Then
            lblTipoDocumento.Text = "Cartera Normal"
        ElseIf tipoDoc = "C" Then
            lblTipoDocumento.Text = "Documento x Cobrar"
        Else
            lblTipoDocumento.Text = ""
        End If

        ds = oAso.ConsultarAsociado("Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio,DUI,NIT,StatusEmpleado", "DUI='" & Trim(dr("DUI")) & "'", "", sUsuario, sPassword, sSucursal)
        dr = ds.Tables("CAT_Asociados").Rows(0)

        'INFO5:
        'SE AGREGA CODIGO PARA MOSTRAR EN TEXTBOX EL ESTATUS DEL EMPLEADO
        '****************************************************************
        If ds.Tables("CAT_ASOCIADOS").Rows.Count > 0 Then
            dr = ds.Tables("CAT_ASOCIADOS").Rows(0)
            Dim StatusEmpleado As String = ""
            If IsDBNull(dr("StatusEmpleado")) Then
                StatusEmpleado = "0"
            Else
                StatusEmpleado = dr("StatusEmpleado")
            End If

            'Select Case StatusEmpleado ' dr("StatusEmpleado")
            '    Case "0" 'Estado Laboral Actual es Empleado
            '        Me.txtStatusEmpleadoCliente.Text = "Empleado"
            '    Case "1" 'Estado Laboral Actual es Desempleado
            '        Me.txtStatusEmpleadoCliente.Text = "Desempleado"
            '    Case "2" 'Estado Laboral Actual es Pensionado
            '        Me.txtStatusEmpleadoCliente.Text = "Pensionado"
            '    Case Else 'Estado Laboral Actual Desconocido
            '        Me.txtStatusEmpleadoCliente.Text = "Otro"
            'End Select
        End If
        '*****************************************************************

        Me.txtNombre.Text = Trim(dr("Nombres")) & " " & Trim(dr("Apellido1")) & " " & Trim(dr("Apellido2")) & " " & Trim(dr("ApellidoCas"))
        Me.txtDui.Value = Trim(dr("DUI"))
        Me.txtNIT.Value = Trim(dr("NIT"))
        Me.txtNoAsoc.Text = Trim(dr("NoSocio"))

        ds = oCred.ConsultarSolP2Credito("FormaPago", "NumSolicitud=" & NumSolicitud & "", "NumSolicitud", sUsuario, sPassword, sSucursal)
        If ds.Tables("CRSolP2Credito").Rows.Count > 0 Then
            dr = ds.Tables("CRSolP2Credito").Rows(0)
            Select Case Convert.ToString(dr("FormaPago"))
                Case "0" 'Pago(personal)
                    Me.txtFormaPago.Text = "Pago personal"
                Case "1" 'Orden de descuento
                    Me.txtFormaPago.Text = "Orden de descuento"
                Case "2" 'Cobro(Directo)
                    Me.txtFormaPago.Text = "Cobro Directo"
                Case "3" 'Pago por Transferencia
                    Me.txtFormaPago.Text = "Pago por Transferencia"
            End Select
        End If

        ds = oPres.CargaDatosPrestamoxRango(Me.CodPrestamo.Trim, Date.Now.ToShortDateString, Date.Now.ToShortDateString, "Cancelada<>'N'", sUsuario, sPassword, sSucursal)
        fg.DataSource = ds.Tables("Pagos")
        EncabezadoPRPagos()

        'INFO:
        'SE AGREGA CODIGO PARA MOSTRAR lAS GESTIONES EN GRID DE DATOS
        '****************************************************************
        ds = oCred.ConsultarBitacoraGestores("CodGestor,CodPrestamo,Fecha,Comentario,Observaciones,FechaPactada", "CodPrestamo = '" & Me.CodPrestamo.Trim & "'", "", sUsuario, sPassword, sSucursal)
        fgGestiones.DataSource = ds.Tables("CBBitacoraGestores")
        EncabezadoCBGestiones()
        '*****************************************************************

        ds = oCred.ConsultarGarantiasxTipo("b.Descripcion as Tipo,a.Descripcion", "a.NumSolicitud=" & NumSolicitud & "", "a.Descripcion", sUsuario, sPassword, sSucursal)
        For Each dr In ds.Tables(0).Rows
            Me.txtGarantia.Text = Me.txtGarantia.Text & dr("Tipo") & " - " & dr("Descripcion")
        Next

        ds = oCred.ConsultarDatGral("*", "NumSolicitud = " & NumSolicitud & " AND Fiador='0'", "NoSocio", sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count >= 1 Then
            dr = ds.Tables(0).Rows(0)
            'Me.txtCliente.Text = IIf(IsDBNull(dr("Nombres")), "", Trim(dr("Nombres"))) & " " & IIf(IsDBNull(dr("Apellido1")), "", Trim(dr("Apellido1"))) & " " & IIf(IsDBNull(dr("Apellido2")), "", Trim(dr("Apellido2"))) & " " & IIf(IsDBNull(dr("Apellido3")), "", Trim(dr("Apellido3")))
            ' Me.txtNoCliente.Text = IIf(IsDBNull(dr("NoSocio")), "", dr("NoSocio"))
            vCodEnlace = dr("CodEnlace")
            Me.txtDUICliente.Value = IIf(IsDBNull(dr("DUI")), "", Trim(dr("DUI")))
            Me.txtNITCliente.Value = IIf(IsDBNull(dr("NIT")), "", Trim(dr("NIT")))
            'Me.txtDireccionCliente.Text = IIf(IsDBNull(dr("Direccion")), "", Trim(dr("Direccion")))
            '  Me.txtTelCasaCliente.Text = IIf(IsDBNull(dr("TelCasa")), "", Trim(dr("TelCasa")))

            'INFO5:
            'SE AGREGA CODIGO PARA MOSTRAR EN TEXTBOX EL ESTATUS DE LA VIVIENDA
            '********************************************************************
            'If ds.Tables("CRSolDatosGeneral").Rows.Count > 0 Then
            '    dr = ds.Tables("CRSolDatosGeneral").Rows(0)
            '    Select Case Convert.ToString(dr("CasaPropia"))
            '        Case "0" 'Estado de Vivienda es propia
            '            Me.txtCasaPropCliente.Text = "Propia"
            '        Case "1" 'Estado de Vivienda es Financiada
            '            Me.txtCasaPropCliente.Text = "Financiada"
            '        Case "2" 'Estado de Vivienda es Financiada o Pagandola
            '            Me.txtCasaPropCliente.Text = "Financiada o Pagandola"
            '        Case "3" 'Estado de Vivienda es Familiar
            '            Me.txtCasaPropCliente.Text = "Familiar"
            '        Case "4" 'Estado de Vivienda es Alquilada
            '            Me.txtCasaPropCliente.Text = "Alquilada"
            '    End Select
            'End If

            'Me.txtCasaPropCliente.Text = IIf(IsDBNull(dr("CasaPropia")), "", Trim(dr("CasaPropia")))

            'Me.txtCelularCliente.Text = IIf(IsDBNull(dr("Celular")), "", Trim(dr("Celular")))
            'Me.txtPropCasaCliente.Text = IIf(IsDBNull(dr("PropietarioCasa")), "", Trim(dr("PropietarioCasa")))
            'Me.txtLugarTrbCliente.Text = IIf(IsDBNull(dr("LugarTrabajo")), "", Trim(dr("LugarTrabajo")))
            'If Not IsDBNull(dr("FechaInicioTrabajo")) Then
            '    Me.txtFechIniTrabCliente.Text = dr("FechaInicioTrabajo")
            'End If
            'Me.txtDirTrbCliente.Text = IIf(IsDBNull(dr("DireccionTrabajo")), "", Trim(dr("DireccionTrabajo")))

            'INFO:
            'SE AGREGA CODIGO PARA MOSTRAR CAMPO ISSS
            '****************************************************************************
            ''Me.txtISSSCliente.Text = IIf(IsDBNull(dr("ISSS")), "", Trim(dr("ISSS")))
            '''****************************************************************************

            ''Me.txtTelOficCliente.Text = IIf(IsDBNull(dr("TelOficina")), "", Trim(dr("TelOficina")))
            ''Me.txtSueldoCliente.Text = Format(IIf(IsDBNull(dr("Sueldo")), "", dr("Sueldo")), "###,##0.00")
            ''Me.txtFormPagoCliente.Text = IIf(IsDBNull(dr("FormaPago")), "", Trim(dr("FormaPago")))
            ''Me.txtExtOficinaCliente.Text = IIf(IsDBNull(dr("ExtensionOfic")), "", Trim(dr("ExtensionOfic")))
            ''If Not IsDBNull(dr("FechaPagoSueldo")) Then
            ''    Me.txtFechPagoCliente.Text = dr("FechaPagoSueldo")
            ''End If
            ''Me.txtCargoCliente.Text = IIf(IsDBNull(dr("Cargo")), "", Trim(dr("Cargo")))
            ''Me.txtNomConyugeCliente.Text = IIf(IsDBNull(dr("NombreConyugue")), "", Trim(dr("NombreConyugue"))) & " " & IIf(IsDBNull(dr("Apellido1Conyugue")), "", Trim(dr("Apellido1Conyugue"))) & " " & IIf(IsDBNull(dr("Apellido2Conyugue")), "", Trim(dr("Apellido2Conyugue"))) & " " & IIf(IsDBNull(dr("Apellido3Conyugue")), "", Trim(dr("Apellido3Conyugue")))
            ''Me.txtSuelConyugeCliente.Text = Format(IIf(IsDBNull(dr("SueldoConyugue")), "", dr("SueldoConyugue")), "###,##0.00")
            ''Me.txtLugarTrabConyCliente.Text = IIf(IsDBNull(dr("LugarTrabConyugue")), "", Trim(dr("LugarTrabConyugue")))
            ''Me.txtTelTrbConyugeCliente.Text = IIf(IsDBNull(dr("TelTrabajoConyugue")), "", Trim(dr("TelTrabajoConyugue")))
            ''Me.txtDirecFamiliarConyugeCliente.Text = IIf(IsDBNull(dr("DirecciondeFamiliar")), "", Trim(dr("DirecciondeFamiliar")))
            ''Me.txtDeptoTrabajo.Text = IIf(IsDBNull(dr("DepartamentoTrabajo")), "", dr("DepartamentoTrabajo"))
            '''INFO:
            '''SE AGREGA CODIGO PARA MOSTRAR CAMPO ISSS
            ''Me.txtEmail.Text = IIf(IsDBNull(dr("email")), "", dr("email"))
            '****************************************************************
        End If

        'INFO
        '******************************************************
        'Aca se carga la informacion de los fiadores en el grid
        DatosFiador = oCred.ConsultarDatGral("*", "NumSolicitud = " & NumSolicitud & " AND Fiador='1' AND FiadorDescartado = '0'", "NumSolicitud", sUsuario, sPassword, sSucursal)
        fgFiador.DataSource = DatosFiador.Tables(0)
        'Dim P As Integer = fgFiador.RowSel
        'If DatosFiador.Tables(0).Rows.Count >= 1 Then
        '    dr = DatosFiador.Tables(0).Rows(P - 1)
        '    vCodEnlaceFiador = dr("CodEnlace")
        'Me.CargarFiador(dr)
        'End If


        ds = oCred.ConsultarDatGral("*", "NumSolicitud = " & NumSolicitud & " AND Fiador='2'", "NumSolicitud", sUsuario, sPassword, sSucursal)
        fgCodeudor.DataSource = ds.Tables(0)
        'If ds.Tables(0).Rows.Count >= 1 Then
        '    dr = ds.Tables(0).Rows(0)
        '    Me.txtCodeudor.Text = IIf(IsDBNull(dr("Nombres")), "", Trim(dr("Nombres"))) & " " & IIf(IsDBNull(dr("Apellido1")), "", Trim(dr("Apellido1"))) & " " & IIf(IsDBNull(dr("Apellido2")), "", Trim(dr("Apellido2"))) & " " & IIf(IsDBNull(dr("Apellido3")), "", Trim(dr("Apellido3")))
        '    Me.txtNoCodeudor.Text = IIf(IsDBNull(dr("NoSocio")), "", Trim(dr("NoSocio")))
        '    vCodEnlaceCodeudor = dr("CodEnlace")
        '    Me.txtDUICodeudor.Value = IIf(IsDBNull(dr("DUI")), "", Trim(dr("DUI")))
        '    Me.txtNITCodeudor.Value = IIf(IsDBNull(dr("NIT")), "", Trim(dr("NIT")))
        '    Me.txtDireccionCodeudor.Text = IIf(IsDBNull(dr("Direccion")), "", Trim(dr("Direccion")))
        '    Me.txtTelCasaCodeudor.Text = IIf(IsDBNull(dr("TelCasa")), "", Trim(dr("TelCasa")))
        '    Me.txtCasaPropiaCodeudor.Text = IIf(IsDBNull(dr("CasaPropia")), "", Trim(dr("CasaPropia")))
        '    Me.txtCelularCodeudor.Text = IIf(IsDBNull(dr("Celular")), "", Trim(dr("Celular")))
        '    Me.txtPropietarioCasaCodeudor.Text = IIf(IsDBNull(dr("PropietarioCasa")), "", Trim(dr("PropietarioCasa")))
        '    Me.txtLugTrbCodeudor.Text = IIf(IsDBNull(dr("LugarTrabajo")), "", Trim(dr("LugarTrabajo")))
        '    If Not IsDBNull(dr("FechaInicioTrabajo")) Then
        '        Me.txtFchIniTrabCodeudor.Text = dr("FechaInicioTrabajo")
        '    End If
        '    Me.txtDirecTrbCodeudor.Text = IIf(IsDBNull(dr("DireccionTrabajo")), "", Trim(dr("DireccionTrabajo")))
        '    Me.txtTelOficCodeudor.Text = IIf(IsDBNull(dr("TelOficina")), "", Trim(dr("TelOficina")))
        '    Me.txtSueldoCodeudor.Text = Format(IIf(IsDBNull(dr("Sueldo")), "", dr("Sueldo")), "###,##0.00")
        '    Me.txtFormaPagoCodeudor.Text = IIf(IsDBNull(dr("FormaPago")), "", Trim(dr("FormaPago")))
        '    Me.txtExtOficCodeudor.Text = IIf(IsDBNull(dr("ExtensionOfic")), "", Trim(dr("ExtensionOfic")))
        '    If Not IsDBNull(dr("FechaPagoSueldo")) Then
        '        Me.txtFechaPagoCodeudor.Text = dr("FechaPagoSueldo")
        '    End If
        '    Me.txtCargoCodeudor.Text = IIf(IsDBNull(dr("Cargo")), "", Trim(dr("Cargo")))
        '    Me.txtNombConyugeCodeudor.Text = IIf(IsDBNull(dr("NombreConyugue")), "", Trim(dr("NombreConyugue"))) & " " & IIf(IsDBNull(dr("Apellido1Conyugue")), "", Trim(dr("Apellido1Conyugue"))) & " " & IIf(IsDBNull(dr("Apellido2Conyugue")), "", Trim(dr("Apellido2Conyugue"))) & " " & IIf(IsDBNull(dr("Apellido3Conyugue")), "", Trim(dr("Apellido3Conyugue")))
        '    Me.txtSueldoConyugeCodeudor.Text = Format(IIf(IsDBNull(dr("SueldoConyugue")), "", dr("SueldoConyugue")), "###,##0.00")
        '    Me.txtLugTrbConyugeCodeudor.Text = IIf(IsDBNull(dr("LugarTrabConyugue")), "", Trim(dr("LugarTrabConyugue")))
        '    Me.txtTelTrbConyugeCodeudor.Text = IIf(IsDBNull(dr("TelTrabajoConyugue")), "", Trim(dr("TelTrabajoConyugue")))
        '    Me.txtDirecFamConyugeCodeudor.Text = IIf(IsDBNull(dr("DirecciondeFamiliar")), "", Trim(dr("DirecciondeFamiliar")))
        '    Me.txtDeptoTrabajoC.Text = IIf(IsDBNull(dr("DepartamentoTrabajo")), "", dr("DepartamentoTrabajo"))
        'End If
    End Sub

    Private Sub txtCodTipoCobranza_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoCobranza.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Tipo de Cobranza"
        Dim oPerif As wrCredito.wsLibCred, ds As New Data.DataSet

        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipoCobranza("CodTipoCobranza,DiaInicio,DiaFin,Descripcion,Tipo", "", "CodTipoCobranza", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Tipo = CStr(ofrm.Resultado5.Trim)
            If Tipo = "J" Then
                Me.txtCodDespacho.Visible = True
                Me.txtDespacho.Visible = True
                Me.lblDespacho.Visible = True
            Else
                Me.txtCodDespacho.Visible = False
                Me.txtDespacho.Visible = False
                Me.lblDespacho.Visible = False
            End If
            txtCodTipoCobranza.Text = ofrm.Resultado.Trim
            txtTipoCobranza.Text = ofrm.Resultado4.Trim
            lblRango.Text = "Rango de morosidad: De " & ofrm.Resultado2.Trim & " a " & ofrm.Resultado3.Trim & " días."
            lblCompromiso.Text = "Compromiso de pago no debe exceder de " & ofrm.Resultado5.Trim & " día(s)."
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipo Cobranza - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fgFiador_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgFiador.DoubleClick
        Dim ds As New Data.DataSet
        Dim dr As DataRow
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        If fgFiador.Row <> -1 Then
            Dim frm As New frmMsCrFiadores
            With frm
                .pAccion = "Modificar"
                .pCodEnlace = Me.fgCodeudor.Item(Me.fgCodeudor.Row, "codEnlace")
                .ShowDialog()
            End With

            'Dim p As Integer = fgFiador.RowSel
            'ds = oCred.ConsultarDatGral("*", "NumSolicitud = " & CInt(fgFiador.Item(fgFiador.Row, "NumSolicitud")) & " AND Fiador='1' AND FiadorDescartado = '0'", "", sUsuario, sPassword, sSucursal)
            'dr = ds.Tables(0).Rows(p - 1)
            'Me.txtFiador.Text = IIf(IsDBNull(dr("Nombres")), "", Trim(dr("Nombres"))) & " " & IIf(IsDBNull(dr("Apellido1")), "", Trim(dr("Apellido1"))) & " " & IIf(IsDBNull(dr("Apellido2")), "", Trim(dr("Apellido2"))) & " " & IIf(IsDBNull(dr("Apellido3")), "", Trim(dr("Apellido3")))
            'Me.txtNoFiador.Text = IIf(IsDBNull(dr("NoSocio")), "", Trim(dr("NoSocio")))
            'vCodEnlaceFiador = dr("CodEnlace")
            'Me.txtDUIFiador.Value = IIf(IsDBNull(dr("DUI")), "", Trim(dr("DUI")))
            'Me.txtNITFiador.Value = IIf(IsDBNull(dr("NIT")), "", Trim(dr("NIT")))
            'Me.txtDireccionFiador.Text = IIf(IsDBNull(dr("Direccion")), "", Trim(dr("Direccion")))
            'Me.txtTelCasaFiador.Text = IIf(IsDBNull(dr("TelCasa")), "", Trim(dr("TelCasa")))
            'Me.txtCasaPropiaFiador.Text = IIf(IsDBNull(dr("CasaPropia")), "", Trim(dr("CasaPropia")))
            'Me.txtCelularFiador.Text = IIf(IsDBNull(dr("Celular")), "", Trim(dr("Celular")))
            'Me.txtPropietarioCasaFiador.Text = IIf(IsDBNull(dr("PropietarioCasa")), "", Trim(dr("PropietarioCasa")))
            'Me.txtLugarTrbFiador.Text = IIf(IsDBNull(dr("LugarTrabajo")), "", Trim(dr("LugarTrabajo")))
            'If Not IsDBNull(dr("FechaInicioTrabajo")) Then
            '    Me.txtFchIniTrbFiador.Text = dr("FechaInicioTrabajo")
            'End If
            'Me.txtDirecTrabFiador.Text = IIf(IsDBNull(dr("DireccionTrabajo")), "", Trim(dr("DireccionTrabajo")))
            'Me.txtTelOficFiador.Text = IIf(IsDBNull(dr("TelOficina")), "", Trim(dr("TelOficina")))
            'Me.txtSueldoFiador.Text = Format(IIf(IsDBNull(dr("Sueldo")), "", dr("Sueldo")), "###,##0.00")
            'Me.txtFormaPagoFiador.Text = IIf(IsDBNull(dr("FormaPago")), "", Trim(dr("FormaPago")))
            'Me.txtExtOficFiador.Text = IIf(IsDBNull(dr("ExtensionOfic")), "", Trim(dr("ExtensionOfic")))
            'If Not IsDBNull(dr("FechaPagoSueldo")) Then
            '    Me.txtFechaPagoFiador.Text = dr("FechaPagoSueldo")
            'End If
            'Me.txtCargoFiador.Text = IIf(IsDBNull(dr("Cargo")), "", Trim(dr("Cargo")))
            'Me.txtNombConyugeFiador.Text = IIf(IsDBNull(dr("NombreConyugue")), "", Trim(dr("NombreConyugue"))) & " " & IIf(IsDBNull(dr("Apellido1Conyugue")), "", Trim(dr("Apellido1Conyugue"))) & " " & IIf(IsDBNull(dr("Apellido2Conyugue")), "", Trim(dr("Apellido2Conyugue"))) & " " & IIf(IsDBNull(dr("Apellido3Conyugue")), "", Trim(dr("Apellido3Conyugue")))
            'Me.txtSuelConyugeFiador.Text = Format(IIf(IsDBNull(dr("SueldoConyugue")), "", dr("SueldoConyugue")), "###,##0.00")
            'Me.txtLugarTrbConyugeFiador.Text = IIf(IsDBNull(dr("LugarTrabConyugue")), "", Trim(dr("LugarTrabConyugue")))
            'Me.txtTelTrabConyugeFiador.Text = IIf(IsDBNull(dr("TelTrabajoConyugue")), "", Trim(dr("TelTrabajoConyugue")))
            'Me.txtDirecFamiliarConyugeFiador.Text = IIf(IsDBNull(dr("DirecciondeFamiliar")), "", Trim(dr("DirecciondeFamiliar")))
        End If
    End Sub

    Private Sub fgCodeudor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgCodeudor.DoubleClick
        Dim ds As New Data.DataSet
        Dim dr As DataRow
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim p As Integer = fgCodeudor.RowSel
        If fgCodeudor.Row <> -1 Then
            Dim frm As New frmMsCrFiadores
            With frm
                .Text = "Codeudores"
                .pAccion = "Modificar"

                .pCodEnlace = Me.fgCodeudor.Item(Me.fgCodeudor.Row, "codEnlace")
                .ShowDialog()
            End With




            'ds = oCred.ConsultarDatGral("*", "NumSolicitud = " & CInt(fgCodeudor.Item(fgCodeudor.Row, "NumSolicitud")) & " AND Fiador='2'", "", sUsuario, sPassword, sSucursal)
            'dr = ds.Tables(0).Rows(p - 1)
            'Me.txtCodeudor.Text = IIf(IsDBNull(dr("Nombres")), "", Trim(dr("Nombres"))) & " " & IIf(IsDBNull(dr("Apellido1")), "", Trim(dr("Apellido1"))) & " " & IIf(IsDBNull(dr("Apellido2")), "", Trim(dr("Apellido2"))) & " " & IIf(IsDBNull(dr("Apellido3")), "", Trim(dr("Apellido3")))
            'Me.txtNoCodeudor.Text = IIf(IsDBNull(dr("NoSocio")), "", Trim(dr("NoSocio")))
            'vCodEnlaceCodeudor = dr("CodEnlace")
            'Me.txtDUICodeudor.Value = IIf(IsDBNull(dr("DUI")), "", Trim(dr("DUI")))
            'Me.txtNITCodeudor.Value = IIf(IsDBNull(dr("NIT")), "", Trim(dr("NIT")))
            'Me.txtDireccionCodeudor.Text = IIf(IsDBNull(dr("Direccion")), "", Trim(dr("Direccion")))
            'Me.txtTelCasaCodeudor.Text = IIf(IsDBNull(dr("TelCasa")), "", Trim(dr("TelCasa")))
            'Me.txtCasaPropiaCodeudor.Text = IIf(IsDBNull(dr("CasaPropia")), "", Trim(dr("CasaPropia")))
            'Me.txtCelularCodeudor.Text = IIf(IsDBNull(dr("Celular")), "", Trim(dr("Celular")))
            'Me.txtPropietarioCasaCodeudor.Text = IIf(IsDBNull(dr("PropietarioCasa")), "", Trim(dr("PropietarioCasa")))
            'Me.txtLugTrbCodeudor.Text = IIf(IsDBNull(dr("LugarTrabajo")), "", Trim(dr("LugarTrabajo")))
            'If Not IsDBNull(dr("FechaInicioTrabajo")) Then
            '    Me.txtFchIniTrabCodeudor.Text = dr("FechaInicioTrabajo")
            'End If
            'Me.txtDirecTrbCodeudor.Text = IIf(IsDBNull(dr("DireccionTrabajo")), "", Trim(dr("DireccionTrabajo")))
            'Me.txtTelOficCodeudor.Text = IIf(IsDBNull(dr("TelOficina")), "", Trim(dr("TelOficina")))
            'Me.txtSueldoCodeudor.Text = Format(IIf(IsDBNull(dr("Sueldo")), "", dr("Sueldo")), "###,##0.00")
            'Me.txtFormaPagoCodeudor.Text = IIf(IsDBNull(dr("FormaPago")), "", Trim(dr("FormaPago")))
            'Me.txtExtOficCodeudor.Text = IIf(IsDBNull(dr("ExtensionOfic")), "", Trim(dr("ExtensionOfic")))
            'If Not IsDBNull(dr("FechaPagoSueldo")) Then
            '    Me.txtFechaPagoCodeudor.Text = dr("FechaPagoSueldo")
            'End If
            'Me.txtCargoCodeudor.Text = IIf(IsDBNull(dr("Cargo")), "", Trim(dr("Cargo")))
            'Me.txtNombConyugeCodeudor.Text = IIf(IsDBNull(dr("NombreConyugue")), "", Trim(dr("NombreConyugue"))) & " " & IIf(IsDBNull(dr("Apellido1Conyugue")), "", Trim(dr("Apellido1Conyugue"))) & " " & IIf(IsDBNull(dr("Apellido2Conyugue")), "", Trim(dr("Apellido2Conyugue"))) & " " & IIf(IsDBNull(dr("Apellido3Conyugue")), "", Trim(dr("Apellido3Conyugue")))
            'Me.txtSueldoConyugeCodeudor.Text = Format(IIf(IsDBNull(dr("SueldoConyugue")), "", dr("SueldoConyugue")), "###,##0.00")
            'Me.txtLugTrbConyugeCodeudor.Text = IIf(IsDBNull(dr("LugarTrabConyugue")), "", Trim(dr("LugarTrabConyugue")))
            'Me.txtTelTrbConyugeCodeudor.Text = IIf(IsDBNull(dr("TelTrabajoConyugue")), "", Trim(dr("TelTrabajoConyugue")))
            'Me.txtDirecFamConyugeCodeudor.Text = IIf(IsDBNull(dr("DirecciondeFamiliar")), "", Trim(dr("DirecciondeFamiliar")))
        End If
    End Sub


    Private Sub txtNoCuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCuotas.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtCodDespacho_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDespacho.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Despachos"
        Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            ds = oCred.ConsultarDespacho("*", "", "CodDespacho", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodDespacho.Text = ofrm.Resultado.Trim
            txtDespacho.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Despachos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fgFiador_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgFiador.SelChange
        'Dim Tabla As C1.Win.C1FlexGrid.C1FlexGrid = DirectCast(sender, C1.Win.C1FlexGrid.C1FlexGrid)
        'Tabla.Row()
    End Sub




#End Region

#Region "Navegacion"




    Private Sub btnCobrosGestion1_Click(sender As Object, e As EventArgs) Handles btnCobrosGestion1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim ds As New Data.DataSet
            ds = oCred.CalculoCobroGestiones("'" & Me.CodGestor.Trim & "'", "'" & Me.CodPrestamo.Trim & "'", sUsuario, sPassword, sSucursal)
            If Not (ds Is Nothing) Then
                Dim ofrm As New frmVisor(ds, 14, 0)
                ofrm.Show()
            Else
                MsgBox("No existen Situaciones de gestión para este crédito.", MsgBoxStyle.OkOnly, "Cobros x Gestión")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnConsultarTbAmortiza1_Click(sender As Object, e As EventArgs) Handles btnConsultarTbAmortiza1.Click
        Try
            Dim ofrm As New frmCBConsultaTablaAmortiza
            ofrm.CodTablaAmortiza = vCodTablaAmortiza
            ofrm.vCodPrestamo = CodPrestamo
            ofrm.StartPosition = FormStartPosition.CenterScreen
            'ofrm.MdiParent = ofrmMain
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnTablaSimulada1_Click(sender As Object, e As EventArgs) Handles btnTablaSimulada1.Click
        Try

            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim dsPRPrest As New Data.DataSet
            Dim dr As DataRow

            dsPRPrest = oCred.ConsultarPrestamos("*", "CodPrestamo = '" & Me.CodPrestamo.Trim & "'", "", sUsuario, sPassword, sSucursal)
            dr = dsPRPrest.Tables("PRPrestamos").Rows(0)

            Dim ofrm As New frmCRTablaAmortSim
            ofrm.StartPosition = FormStartPosition.CenterScreen
            'ofrm.MdiParent = ofrmMain
            ofrm.pSaldo = dr("Saldo_Capital")
            ofrm.pSaldoDiaInteres = dr("SaldoDia_Interes")
            ofrm.pSaldoSeguroDeuda = dr("SaldoDia_SeguroDeuda")
            ofrm.pSaldoSeguroDaniosyLA = dr("SaldoDia_SeguroDaniosyLA")
            ofrm.pSaldoSeguroVida = dr("SaldoDia_SeguroVida")
            ofrm.pSaldoSeguroDesempleo = dr("SaldoDia_SeguroDesempleo")
            ofrm.pSaldoComisionManejo = dr("SaldoDia_ComisionManejo")
            ofrm.pSaldoOtros = dr("SaldoDia_Otros")
            ofrm.pTasaInteres = dr("Tasa_Interes")
            ofrm.ShowDialog()

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String, pTipo As String
            Dim oPrest As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
            Dim Filas As Data.DataRowCollection, ds As New DataSet

            If Me.btnAdd1.Text = "&Guardar Gestión" Then

                If Me.txtCodTipoCobranza.Text.Trim = "" Then
                    MsgBox("El Tipo de Cobranza no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Cobranzas")
                    Exit Sub
                End If
                If Tipo = "J" Then
                    pCampos = "CodGestor,CodPrestamo,CodTipoCobranza,Fecha,Hora,Comentario,CodDespacho,Observaciones,FechaPactada,PagoEfectuado"
                    pValores = "'" & Me.vCodGestor.Trim & "','" & Me.vCodPrestamo.Trim & "','" & Me.txtCodTipoCobranza.Text.Trim & "','" & Format(Me.dtFecha.Value, "dd/MM/yyyy") & "','" & Format(Me.dtHora.Value, "HH:mm") & "','" & Me.txtAcuerdo.Text.Trim & "','" & Me.txtCodDespacho.Text.Trim & "','" & Me.txtObservaciones.Text.Trim & "','" & Format(Me.dtpFechaPactada.Value, "dd/MM/yyyy") & "','0'"
                    If oCred.InsertarBitacoraGestores(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Registro ingresado satisfactoriamente", MsgBoxStyle.Information, "Módulo - Créditos")
                        Me.Dispose()
                        'If oCred.ModificarPrestamos(NumSolicitud, "Estado='C'", sUsuario, sPassword, sSucursal) = True Then
                        '    MsgBox("Registro ingresado satisfactoriamente", MsgBoxStyle.Information, "Módulo - Créditos")
                        '    Me.Dispose()
                        'End If
                    Else
                        MsgBox("El registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                    End If
                ElseIf Tipo = "N" Then
                    pCampos = "CodGestor,CodPrestamo,CodTipoCobranza,Fecha,Hora,Comentario,Observaciones,FechaPactada,PagoEfectuado"
                    pValores = "'" & Me.vCodGestor.Trim & "','" & Me.vCodPrestamo.Trim & "','" & Me.txtCodTipoCobranza.Text.Trim & "','" & Format(Me.dtFecha.Value, "dd/MM/yyyy") & "','" & Format(Me.dtHora.Value, "HH:mm") & "','" & Me.txtAcuerdo.Text.Trim & "','" & Me.txtObservaciones.Text.Trim & "','" & Format(Me.dtpFechaPactada.Value, "dd/MM/yyyy") & "','0'"
                    If oCred.InsertarBitacoraGestores(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Registro ingresado satisfactoriamente", MsgBoxStyle.Information, "Módulo - Créditos")
                        Me.Dispose()
                    Else
                        MsgBox("El registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSig1_Click(sender As Object, e As EventArgs)
        Me.tbGestionCredito.SelectedIndex = Me.tbGestionCredito.SelectedIndex() + 1
    End Sub



    Private Sub btnAtrasTb2_1_Click(sender As Object, e As EventArgs)
        Me.tbGestionCredito.SelectedIndex = Me.tbGestionCredito.SelectedIndex() - 1
    End Sub

    Private Sub btSigTb2_1_Click(sender As Object, e As EventArgs)
        Me.tbGestionCredito.SelectedIndex = Me.tbGestionCredito.SelectedIndex() + 1
    End Sub





    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Dim frm As New frmIngresoAsoc2
        With frm
            .txtDui.Text = Me.txtDUICliente.Value
            .accion = 2
            .Show()
        End With
    End Sub




    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)
        Me.tbGestionCredito.SelectedIndex = Me.tbGestionCredito.SelectedIndex() - 1
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs)
        Me.tbGestionCredito.SelectedIndex = Me.tbGestionCredito.SelectedIndex() + 1
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs)
        Me.tbGestionCredito.SelectedIndex = Me.tbGestionCredito.SelectedIndex() - 1
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs)
        Me.tbGestionCredito.SelectedIndex = Me.tbGestionCredito.SelectedIndex() + 1
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs)
        Me.tbGestionCredito.SelectedIndex = Me.tbGestionCredito.SelectedIndex() - 1
    End Sub


#End Region


End Class