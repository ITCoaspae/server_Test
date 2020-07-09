Public Class frmMsCBGestionCredito
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim DatosFiador As DataSet
    Dim credito As New wrCredito.wsLibCred

#Region "Variables privadas del formulario"
    Private vCodGestor, vCodPrestamo, Tipo As String, vCodEnlace As String, vCodEnlaceFiador As String, vCodEnlaceCodeudor As String
    Private NumSolicitud As Integer, vCodTablaAmortiza As String
    Friend WithEvents tb6 As System.Windows.Forms.TabPage
    Friend WithEvents tb1 As System.Windows.Forms.TabPage
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents txtGarantia As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCapitalMora As System.Windows.Forms.TextBox
    Friend WithEvents lblCodPrestamo As System.Windows.Forms.Label
    Friend WithEvents txtNIT As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoAsoc As System.Windows.Forms.TextBox
    Friend WithEvents txtAditivosCobrar As System.Windows.Forms.TextBox
    Friend WithEvents txtCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtNoCuotasMora As System.Windows.Forms.TextBox
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
    Friend WithEvents txtFechaVencimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaOtorgamiento As System.Windows.Forms.TextBox
    Friend WithEvents txtTasaInteresMora As System.Windows.Forms.TextBox
    Friend WithEvents txtTasaInteres As System.Windows.Forms.TextBox
    Friend WithEvents txtCuotaTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents gbGestion As System.Windows.Forms.GroupBox
    Friend WithEvents txtGestor As System.Windows.Forms.TextBox
    Friend WithEvents txtNoCuotas As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtAcuerdo As System.Windows.Forms.TextBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
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
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtDUICliente As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNITCliente As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnEstadoCta As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpFechaPactada As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCobranza As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel28 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel27 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel25 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel24 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCBGestionCredito))
        Me.tbGestionCredito = New System.Windows.Forms.TabControl()
        Me.tb1 = New System.Windows.Forms.TabPage()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtGarantia = New System.Windows.Forms.TextBox()
        Me.txtNoAsoc = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNIT = New C1.Win.C1Input.C1TextBox()
        Me.lblCodPrestamo = New System.Windows.Forms.Label()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel28 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel27 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.txtFechaOtorgamiento = New System.Windows.Forms.TextBox()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel24 = New MetroFramework.Controls.MetroLabel()
        Me.txtFechaVencimiento = New System.Windows.Forms.TextBox()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.txtTasaInteres = New System.Windows.Forms.TextBox()
        Me.txtNoCuotasMora = New System.Windows.Forms.TextBox()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtTasaInteresMora = New System.Windows.Forms.TextBox()
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
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.gbGestion = New System.Windows.Forms.GroupBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaPactada = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dtFecha = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cbCobranza = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnEstadoCta = New MetroFramework.Controls.MetroButton()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.txtGestor = New System.Windows.Forms.TextBox()
        Me.btnAdd1 = New MetroFramework.Controls.MetroButton()
        Me.txtNoCuotas = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtAcuerdo = New System.Windows.Forms.TextBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.txtAditivosCobrar = New System.Windows.Forms.TextBox()
        Me.txtCapitalMora = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtSaldoCapital = New System.Windows.Forms.TextBox()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.tb6 = New System.Windows.Forms.TabPage()
        Me.fgGestiones = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tb3 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.fgCodeudor = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.fgFiador = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tb5 = New System.Windows.Forms.TabPage()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnTablaSimulada1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultarTbAmortiza1 = New MetroFramework.Controls.MetroButton()
        Me.btnCobrosGestion1 = New MetroFramework.Controls.MetroButton()
        Me.txtDUICliente = New C1.Win.C1Input.C1TextBox()
        Me.txtNITCliente = New C1.Win.C1Input.C1TextBox()
        Me.tbGestionCredito.SuspendLayout()
        Me.tb1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.gbGestion.SuspendLayout()
        Me.tb6.SuspendLayout()
        CType(Me.fgGestiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.fgCodeudor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.fgFiador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tb5.SuspendLayout()
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
        Me.tbGestionCredito.Location = New System.Drawing.Point(23, 63)
        Me.tbGestionCredito.Name = "tbGestionCredito"
        Me.tbGestionCredito.SelectedIndex = 0
        Me.tbGestionCredito.Size = New System.Drawing.Size(655, 627)
        Me.tbGestionCredito.TabIndex = 0
        '
        'tb1
        '
        Me.tb1.BackColor = System.Drawing.Color.White
        Me.tb1.Controls.Add(Me.MetroTabControl1)
        Me.tb1.Controls.Add(Me.MetroLabel19)
        Me.tb1.Controls.Add(Me.gbGestion)
        Me.tb1.Controls.Add(Me.MetroLabel17)
        Me.tb1.Controls.Add(Me.MetroLabel18)
        Me.tb1.Controls.Add(Me.txtAditivosCobrar)
        Me.tb1.Controls.Add(Me.txtCapitalMora)
        Me.tb1.Controls.Add(Me.txtTotal)
        Me.tb1.Controls.Add(Me.txtSaldoCapital)
        Me.tb1.Controls.Add(Me.MetroLabel16)
        Me.tb1.Location = New System.Drawing.Point(4, 22)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(647, 601)
        Me.tb1.TabIndex = 0
        Me.tb1.Text = "Gestión de Crédito"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(8, 284)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(629, 204)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.Color.White
        Me.MetroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel15)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel14)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel13)
        Me.MetroTabPage1.Controls.Add(Me.txtFormaPago)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel12)
        Me.MetroTabPage1.Controls.Add(Me.txtNombre)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel10)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel9)
        Me.MetroTabPage1.Controls.Add(Me.txtGarantia)
        Me.MetroTabPage1.Controls.Add(Me.txtNoAsoc)
        Me.MetroTabPage1.Controls.Add(Me.txtDui)
        Me.MetroTabPage1.Controls.Add(Me.txtNIT)
        Me.MetroTabPage1.Controls.Add(Me.lblCodPrestamo)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(621, 162)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Información General"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(0, 118)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel15.TabIndex = 35
        Me.MetroLabel15.Text = "Forma  Pago:"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(0, 85)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel14.TabIndex = 34
        Me.MetroLabel14.Text = "Garantía:"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(312, 62)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel13.TabIndex = 33
        Me.MetroLabel13.Text = "Cod. Prestamo:"
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BackColor = System.Drawing.Color.White
        Me.txtFormaPago.Location = New System.Drawing.Point(100, 118)
        Me.txtFormaPago.Multiline = True
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.ReadOnly = True
        Me.txtFormaPago.Size = New System.Drawing.Size(507, 28)
        Me.txtFormaPago.TabIndex = 13
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(2, 62)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel12.TabIndex = 32
        Me.MetroLabel12.Text = "NIT:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(100, 9)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(507, 20)
        Me.txtNombre.TabIndex = 1
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(312, 34)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel11.TabIndex = 31
        Me.MetroLabel11.Text = "DUI:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(2, 36)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel10.TabIndex = 30
        Me.MetroLabel10.Text = "No. Asociado:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(2, 11)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel9.TabIndex = 29
        Me.MetroLabel9.Text = "Nombre:"
        '
        'txtGarantia
        '
        Me.txtGarantia.BackColor = System.Drawing.Color.White
        Me.txtGarantia.Location = New System.Drawing.Point(100, 85)
        Me.txtGarantia.Multiline = True
        Me.txtGarantia.Name = "txtGarantia"
        Me.txtGarantia.ReadOnly = True
        Me.txtGarantia.Size = New System.Drawing.Size(507, 28)
        Me.txtGarantia.TabIndex = 11
        '
        'txtNoAsoc
        '
        Me.txtNoAsoc.BackColor = System.Drawing.Color.White
        Me.txtNoAsoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoAsoc.Location = New System.Drawing.Point(100, 34)
        Me.txtNoAsoc.MaxLength = 8
        Me.txtNoAsoc.Name = "txtNoAsoc"
        Me.txtNoAsoc.ReadOnly = True
        Me.txtNoAsoc.Size = New System.Drawing.Size(207, 20)
        Me.txtNoAsoc.TabIndex = 3
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(400, 36)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.ReadOnly = True
        Me.txtDui.Size = New System.Drawing.Size(207, 18)
        Me.txtDui.TabIndex = 5
        Me.txtDui.Tag = Nothing
        '
        'txtNIT
        '
        Me.txtNIT.BackColor = System.Drawing.Color.White
        Me.txtNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNIT.EditMask = "0000-000000-000-0"
        Me.txtNIT.Location = New System.Drawing.Point(100, 62)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.NumericInput = False
        Me.txtNIT.ReadOnly = True
        Me.txtNIT.Size = New System.Drawing.Size(207, 18)
        Me.txtNIT.TabIndex = 7
        Me.txtNIT.Tag = Nothing
        Me.txtNIT.Value = ""
        '
        'lblCodPrestamo
        '
        Me.lblCodPrestamo.BackColor = System.Drawing.Color.White
        Me.lblCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodPrestamo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPrestamo.ForeColor = System.Drawing.Color.Black
        Me.lblCodPrestamo.Location = New System.Drawing.Point(400, 62)
        Me.lblCodPrestamo.Name = "lblCodPrestamo"
        Me.lblCodPrestamo.Size = New System.Drawing.Size(207, 19)
        Me.lblCodPrestamo.TabIndex = 9
        Me.lblCodPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel28)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel27)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel26)
        Me.MetroTabPage2.Controls.Add(Me.txtMonto)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel25)
        Me.MetroTabPage2.Controls.Add(Me.txtFechaOtorgamiento)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel22)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel24)
        Me.MetroTabPage2.Controls.Add(Me.txtFechaVencimiento)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel23)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel21)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel20)
        Me.MetroTabPage2.Controls.Add(Me.txtTasaInteres)
        Me.MetroTabPage2.Controls.Add(Me.txtNoCuotasMora)
        Me.MetroTabPage2.Controls.Add(Me.txtPlazo)
        Me.MetroTabPage2.Controls.Add(Me.txtCategoria)
        Me.MetroTabPage2.Controls.Add(Me.txtTasaInteresMora)
        Me.MetroTabPage2.Controls.Add(Me.txtCuotaTotal)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(621, 165)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Datos Préstamo"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroLabel28
        '
        Me.MetroLabel28.AutoSize = True
        Me.MetroLabel28.Location = New System.Drawing.Point(4, 104)
        Me.MetroLabel28.Name = "MetroLabel28"
        Me.MetroLabel28.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel28.TabIndex = 44
        Me.MetroLabel28.Text = "Cuota Total:"
        '
        'MetroLabel27
        '
        Me.MetroLabel27.AutoSize = True
        Me.MetroLabel27.Location = New System.Drawing.Point(312, 62)
        Me.MetroLabel27.Name = "MetroLabel27"
        Me.MetroLabel27.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel27.TabIndex = 43
        Me.MetroLabel27.Text = "Tasa Interes Mora:"
        '
        'MetroLabel26
        '
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.Location = New System.Drawing.Point(312, 87)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel26.TabIndex = 42
        Me.MetroLabel26.Text = "Cuotas Mora:"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(117, 11)
        Me.txtMonto.MaxLength = 20
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(175, 20)
        Me.txtMonto.TabIndex = 1
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroLabel25
        '
        Me.MetroLabel25.AutoSize = True
        Me.MetroLabel25.Location = New System.Drawing.Point(4, 87)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel25.TabIndex = 41
        Me.MetroLabel25.Text = "Categoria"
        '
        'txtFechaOtorgamiento
        '
        Me.txtFechaOtorgamiento.BackColor = System.Drawing.Color.White
        Me.txtFechaOtorgamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaOtorgamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaOtorgamiento.Location = New System.Drawing.Point(432, 11)
        Me.txtFechaOtorgamiento.MaxLength = 25
        Me.txtFechaOtorgamiento.Name = "txtFechaOtorgamiento"
        Me.txtFechaOtorgamiento.ReadOnly = True
        Me.txtFechaOtorgamiento.Size = New System.Drawing.Size(175, 20)
        Me.txtFechaOtorgamiento.TabIndex = 9
        Me.txtFechaOtorgamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.Location = New System.Drawing.Point(4, 63)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel22.TabIndex = 38
        Me.MetroLabel22.Text = "Plazo (meses);"
        '
        'MetroLabel24
        '
        Me.MetroLabel24.AutoSize = True
        Me.MetroLabel24.Location = New System.Drawing.Point(312, 36)
        Me.MetroLabel24.Name = "MetroLabel24"
        Me.MetroLabel24.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel24.TabIndex = 40
        Me.MetroLabel24.Text = "Tasa Interes:"
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.BackColor = System.Drawing.Color.White
        Me.txtFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(117, 36)
        Me.txtFechaVencimiento.MaxLength = 25
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.ReadOnly = True
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(175, 20)
        Me.txtFechaVencimiento.TabIndex = 3
        Me.txtFechaVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.Location = New System.Drawing.Point(4, 39)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(121, 19)
        Me.MetroLabel23.TabIndex = 39
        Me.MetroLabel23.Text = "Fecha Vencimiento:"
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.Location = New System.Drawing.Point(312, 9)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(134, 19)
        Me.MetroLabel21.TabIndex = 37
        Me.MetroLabel21.Text = "Fecha Otorgamiento:"
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(4, 11)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel20.TabIndex = 36
        Me.MetroLabel20.Text = "Monto:"
        '
        'txtTasaInteres
        '
        Me.txtTasaInteres.BackColor = System.Drawing.Color.White
        Me.txtTasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTasaInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaInteres.Location = New System.Drawing.Point(432, 36)
        Me.txtTasaInteres.MaxLength = 10
        Me.txtTasaInteres.Name = "txtTasaInteres"
        Me.txtTasaInteres.ReadOnly = True
        Me.txtTasaInteres.Size = New System.Drawing.Size(175, 20)
        Me.txtTasaInteres.TabIndex = 11
        Me.txtTasaInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNoCuotasMora
        '
        Me.txtNoCuotasMora.BackColor = System.Drawing.Color.White
        Me.txtNoCuotasMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuotasMora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuotasMora.Location = New System.Drawing.Point(432, 87)
        Me.txtNoCuotasMora.MaxLength = 25
        Me.txtNoCuotasMora.Name = "txtNoCuotasMora"
        Me.txtNoCuotasMora.ReadOnly = True
        Me.txtNoCuotasMora.Size = New System.Drawing.Size(175, 20)
        Me.txtNoCuotasMora.TabIndex = 13
        Me.txtNoCuotasMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.Color.White
        Me.txtPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlazo.Location = New System.Drawing.Point(117, 62)
        Me.txtPlazo.MaxLength = 25
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.Size = New System.Drawing.Size(175, 20)
        Me.txtPlazo.TabIndex = 19
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.White
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(117, 87)
        Me.txtCategoria.MaxLength = 25
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(175, 20)
        Me.txtCategoria.TabIndex = 5
        Me.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTasaInteresMora
        '
        Me.txtTasaInteresMora.BackColor = System.Drawing.Color.White
        Me.txtTasaInteresMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTasaInteresMora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaInteresMora.Location = New System.Drawing.Point(432, 62)
        Me.txtTasaInteresMora.MaxLength = 10
        Me.txtTasaInteresMora.Name = "txtTasaInteresMora"
        Me.txtTasaInteresMora.ReadOnly = True
        Me.txtTasaInteresMora.Size = New System.Drawing.Size(175, 20)
        Me.txtTasaInteresMora.TabIndex = 21
        Me.txtTasaInteresMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCuotaTotal
        '
        Me.txtCuotaTotal.BackColor = System.Drawing.Color.White
        Me.txtCuotaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuotaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaTotal.Location = New System.Drawing.Point(117, 112)
        Me.txtCuotaTotal.MaxLength = 50
        Me.txtCuotaTotal.Name = "txtCuotaTotal"
        Me.txtCuotaTotal.ReadOnly = True
        Me.txtCuotaTotal.Size = New System.Drawing.Size(175, 20)
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
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(621, 165)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Pendiente de pagar"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'txtOtros
        '
        Me.txtOtros.BackColor = System.Drawing.Color.White
        Me.txtOtros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtros.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtros.Location = New System.Drawing.Point(541, 68)
        Me.txtOtros.MaxLength = 8
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.ReadOnly = True
        Me.txtOtros.Size = New System.Drawing.Size(80, 20)
        Me.txtOtros.TabIndex = 17
        Me.txtOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.BackColor = System.Drawing.Color.White
        Me.Label120.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.ForeColor = System.Drawing.Color.Black
        Me.Label120.Location = New System.Drawing.Point(425, 72)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(37, 14)
        Me.Label120.TabIndex = 16
        Me.Label120.Text = "Otros:"
        Me.Label120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuota
        '
        Me.txtCuota.BackColor = System.Drawing.Color.White
        Me.txtCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuota.Location = New System.Drawing.Point(124, 16)
        Me.txtCuota.MaxLength = 8
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.ReadOnly = True
        Me.txtCuota.Size = New System.Drawing.Size(80, 20)
        Me.txtCuota.TabIndex = 1
        Me.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(8, 14)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(110, 20)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Cuota Normal:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoDiaAhorro
        '
        Me.txtSaldoDiaAhorro.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaAhorro.Location = New System.Drawing.Point(326, 16)
        Me.txtSaldoDiaAhorro.MaxLength = 8
        Me.txtSaldoDiaAhorro.Name = "txtSaldoDiaAhorro"
        Me.txtSaldoDiaAhorro.ReadOnly = True
        Me.txtSaldoDiaAhorro.Size = New System.Drawing.Size(80, 20)
        Me.txtSaldoDiaAhorro.TabIndex = 7
        Me.txtSaldoDiaAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(210, 15)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(110, 18)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Ahorro:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoDiaAportacion
        '
        Me.txtSaldoDiaAportacion.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaAportacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaAportacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaAportacion.Location = New System.Drawing.Point(541, 16)
        Me.txtSaldoDiaAportacion.MaxLength = 8
        Me.txtSaldoDiaAportacion.Name = "txtSaldoDiaAportacion"
        Me.txtSaldoDiaAportacion.ReadOnly = True
        Me.txtSaldoDiaAportacion.Size = New System.Drawing.Size(80, 20)
        Me.txtSaldoDiaAportacion.TabIndex = 13
        Me.txtSaldoDiaAportacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(425, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 16)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Aportación:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoDiaInteres
        '
        Me.txtSaldoDiaInteres.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaInteres.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaInteres.Location = New System.Drawing.Point(124, 42)
        Me.txtSaldoDiaInteres.MaxLength = 8
        Me.txtSaldoDiaInteres.Name = "txtSaldoDiaInteres"
        Me.txtSaldoDiaInteres.ReadOnly = True
        Me.txtSaldoDiaInteres.Size = New System.Drawing.Size(80, 20)
        Me.txtSaldoDiaInteres.TabIndex = 3
        Me.txtSaldoDiaInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoDiaInteresMora
        '
        Me.txtSaldoDiaInteresMora.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaInteresMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaInteresMora.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaInteresMora.Location = New System.Drawing.Point(326, 42)
        Me.txtSaldoDiaInteresMora.MaxLength = 8
        Me.txtSaldoDiaInteresMora.Name = "txtSaldoDiaInteresMora"
        Me.txtSaldoDiaInteresMora.ReadOnly = True
        Me.txtSaldoDiaInteresMora.Size = New System.Drawing.Size(80, 20)
        Me.txtSaldoDiaInteresMora.TabIndex = 9
        Me.txtSaldoDiaInteresMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(210, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 16)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Interés Moratorio:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoDiaComision
        '
        Me.txtSaldoDiaComision.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaComision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaComision.Location = New System.Drawing.Point(326, 68)
        Me.txtSaldoDiaComision.MaxLength = 8
        Me.txtSaldoDiaComision.Name = "txtSaldoDiaComision"
        Me.txtSaldoDiaComision.ReadOnly = True
        Me.txtSaldoDiaComision.Size = New System.Drawing.Size(80, 20)
        Me.txtSaldoDiaComision.TabIndex = 11
        Me.txtSaldoDiaComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(210, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 19)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Seg. Vehiculo;"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(8, 41)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 19)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Interés Normal:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldoDiaSegDeuda
        '
        Me.txtSaldoDiaSegDeuda.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaSegDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaSegDeuda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaSegDeuda.Location = New System.Drawing.Point(124, 68)
        Me.txtSaldoDiaSegDeuda.MaxLength = 8
        Me.txtSaldoDiaSegDeuda.Name = "txtSaldoDiaSegDeuda"
        Me.txtSaldoDiaSegDeuda.ReadOnly = True
        Me.txtSaldoDiaSegDeuda.Size = New System.Drawing.Size(80, 20)
        Me.txtSaldoDiaSegDeuda.TabIndex = 5
        Me.txtSaldoDiaSegDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoDiaSegDanios
        '
        Me.txtSaldoDiaSegDanios.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaSegDanios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDiaSegDanios.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaSegDanios.Location = New System.Drawing.Point(541, 42)
        Me.txtSaldoDiaSegDanios.MaxLength = 8
        Me.txtSaldoDiaSegDanios.Name = "txtSaldoDiaSegDanios"
        Me.txtSaldoDiaSegDanios.ReadOnly = True
        Me.txtSaldoDiaSegDanios.Size = New System.Drawing.Size(79, 20)
        Me.txtSaldoDiaSegDanios.TabIndex = 15
        Me.txtSaldoDiaSegDanios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(425, 42)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Seg.Daños:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(9, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 18)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Seg. Deuda:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(322, 551)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel19.TabIndex = 39
        Me.MetroLabel19.Text = "Total a Cancelar"
        '
        'gbGestion
        '
        Me.gbGestion.BackColor = System.Drawing.Color.White
        Me.gbGestion.Controls.Add(Me.MetroLabel7)
        Me.gbGestion.Controls.Add(Me.dtpFechaPactada)
        Me.gbGestion.Controls.Add(Me.MetroLabel6)
        Me.gbGestion.Controls.Add(Me.dtFecha)
        Me.gbGestion.Controls.Add(Me.MetroLabel5)
        Me.gbGestion.Controls.Add(Me.MetroLabel4)
        Me.gbGestion.Controls.Add(Me.MetroLabel3)
        Me.gbGestion.Controls.Add(Me.cbCobranza)
        Me.gbGestion.Controls.Add(Me.MetroLabel2)
        Me.gbGestion.Controls.Add(Me.MetroLabel1)
        Me.gbGestion.Controls.Add(Me.btnEstadoCta)
        Me.gbGestion.Controls.Add(Me.MetroButton7)
        Me.gbGestion.Controls.Add(Me.txtGestor)
        Me.gbGestion.Controls.Add(Me.btnAdd1)
        Me.gbGestion.Controls.Add(Me.txtNoCuotas)
        Me.gbGestion.Controls.Add(Me.txtObservaciones)
        Me.gbGestion.Controls.Add(Me.txtAcuerdo)
        Me.gbGestion.Location = New System.Drawing.Point(3, 3)
        Me.gbGestion.Name = "gbGestion"
        Me.gbGestion.Size = New System.Drawing.Size(634, 276)
        Me.gbGestion.TabIndex = 0
        Me.gbGestion.TabStop = False
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(5, 182)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel7.TabIndex = 27
        Me.MetroLabel7.Text = "Monto Acordado:"
        '
        'dtpFechaPactada
        '
        Me.dtpFechaPactada.Location = New System.Drawing.Point(412, 148)
        Me.dtpFechaPactada.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpFechaPactada.Name = "dtpFechaPactada"
        Me.dtpFechaPactada.Size = New System.Drawing.Size(206, 29)
        Me.dtpFechaPactada.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtpFechaPactada.TabIndex = 5
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(323, 148)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel6.TabIndex = 7
        Me.MetroLabel6.Text = "Fecha Pactada:"
        '
        'dtFecha
        '
        Me.dtFecha.Enabled = False
        Me.dtFecha.Location = New System.Drawing.Point(112, 148)
        Me.dtFecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(206, 29)
        Me.dtFecha.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtFecha.TabIndex = 4
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(5, 148)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Fecha:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(5, 111)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel4.TabIndex = 26
        Me.MetroLabel4.Text = "Observación:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(5, 74)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel3.TabIndex = 25
        Me.MetroLabel3.Text = "Acuerdo:"
        '
        'cbCobranza
        '
        Me.cbCobranza.FormattingEnabled = True
        Me.cbCobranza.ItemHeight = 23
        Me.cbCobranza.Location = New System.Drawing.Point(112, 42)
        Me.cbCobranza.Name = "cbCobranza"
        Me.cbCobranza.Size = New System.Drawing.Size(506, 29)
        Me.cbCobranza.TabIndex = 4
        Me.cbCobranza.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(5, 42)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel2.TabIndex = 6
        Me.MetroLabel2.Text = "Tipo de Cobranza:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(5, 16)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Gestor Asignado:"
        '
        'btnEstadoCta
        '
        Me.btnEstadoCta.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnEstadoCta.Location = New System.Drawing.Point(279, 205)
        Me.btnEstadoCta.Name = "btnEstadoCta"
        Me.btnEstadoCta.Size = New System.Drawing.Size(95, 28)
        Me.btnEstadoCta.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEstadoCta.TabIndex = 22
        Me.btnEstadoCta.Text = "&Estado de Cuenta"
        Me.btnEstadoCta.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEstadoCta.UseSelectable = True
        Me.btnEstadoCta.UseStyleColors = True
        '
        'MetroButton7
        '
        Me.MetroButton7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.MetroButton7.Location = New System.Drawing.Point(382, 205)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(95, 28)
        Me.MetroButton7.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton7.TabIndex = 23
        Me.MetroButton7.Text = "&Datos Asociado"
        Me.MetroButton7.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton7.UseSelectable = True
        Me.MetroButton7.UseStyleColors = True
        '
        'txtGestor
        '
        Me.txtGestor.BackColor = System.Drawing.Color.White
        Me.txtGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGestor.Location = New System.Drawing.Point(112, 18)
        Me.txtGestor.Name = "txtGestor"
        Me.txtGestor.Size = New System.Drawing.Size(506, 20)
        Me.txtGestor.TabIndex = 1
        '
        'btnAdd1
        '
        Me.btnAdd1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnAdd1.Location = New System.Drawing.Point(482, 205)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(136, 28)
        Me.btnAdd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd1.TabIndex = 24
        Me.btnAdd1.Text = "&Guardar Gestión"
        Me.btnAdd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd1.UseSelectable = True
        Me.btnAdd1.UseStyleColors = True
        '
        'txtNoCuotas
        '
        Me.txtNoCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuotas.Location = New System.Drawing.Point(112, 179)
        Me.txtNoCuotas.MaxLength = 20
        Me.txtNoCuotas.Name = "txtNoCuotas"
        Me.txtNoCuotas.Size = New System.Drawing.Size(206, 20)
        Me.txtNoCuotas.TabIndex = 18
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtObservaciones.Location = New System.Drawing.Point(112, 111)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(506, 32)
        Me.txtObservaciones.TabIndex = 10
        '
        'txtAcuerdo
        '
        Me.txtAcuerdo.BackColor = System.Drawing.Color.White
        Me.txtAcuerdo.Location = New System.Drawing.Point(112, 74)
        Me.txtAcuerdo.Multiline = True
        Me.txtAcuerdo.Name = "txtAcuerdo"
        Me.txtAcuerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcuerdo.Size = New System.Drawing.Size(506, 32)
        Me.txtAcuerdo.TabIndex = 8
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(8, 526)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel17.TabIndex = 37
        Me.MetroLabel17.Text = "Saldo Préstamo:"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(8, 547)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel18.TabIndex = 38
        Me.MetroLabel18.Text = "Aditivos:"
        '
        'txtAditivosCobrar
        '
        Me.txtAditivosCobrar.BackColor = System.Drawing.Color.White
        Me.txtAditivosCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAditivosCobrar.Location = New System.Drawing.Point(115, 547)
        Me.txtAditivosCobrar.MaxLength = 8
        Me.txtAditivosCobrar.Name = "txtAditivosCobrar"
        Me.txtAditivosCobrar.ReadOnly = True
        Me.txtAditivosCobrar.Size = New System.Drawing.Size(207, 20)
        Me.txtAditivosCobrar.TabIndex = 7
        Me.txtAditivosCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCapitalMora
        '
        Me.txtCapitalMora.BackColor = System.Drawing.Color.White
        Me.txtCapitalMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCapitalMora.Location = New System.Drawing.Point(415, 523)
        Me.txtCapitalMora.MaxLength = 20
        Me.txtCapitalMora.Name = "txtCapitalMora"
        Me.txtCapitalMora.ReadOnly = True
        Me.txtCapitalMora.Size = New System.Drawing.Size(207, 20)
        Me.txtCapitalMora.TabIndex = 3
        Me.txtCapitalMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(415, 549)
        Me.txtTotal.MaxLength = 8
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(207, 20)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoCapital
        '
        Me.txtSaldoCapital.BackColor = System.Drawing.Color.White
        Me.txtSaldoCapital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoCapital.Location = New System.Drawing.Point(115, 522)
        Me.txtSaldoCapital.MaxLength = 20
        Me.txtSaldoCapital.Name = "txtSaldoCapital"
        Me.txtSaldoCapital.ReadOnly = True
        Me.txtSaldoCapital.Size = New System.Drawing.Size(207, 20)
        Me.txtSaldoCapital.TabIndex = 5
        Me.txtSaldoCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(327, 522)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel16.TabIndex = 36
        Me.MetroLabel16.Text = "Capital Mora"
        '
        'tb6
        '
        Me.tb6.BackColor = System.Drawing.Color.White
        Me.tb6.Controls.Add(Me.fgGestiones)
        Me.tb6.Location = New System.Drawing.Point(4, 22)
        Me.tb6.Name = "tb6"
        Me.tb6.Size = New System.Drawing.Size(647, 601)
        Me.tb6.TabIndex = 5
        Me.tb6.Tag = ""
        Me.tb6.Text = "Gestiones"
        '
        'fgGestiones
        '
        Me.fgGestiones.AllowEditing = False
        Me.fgGestiones.BackColor = System.Drawing.Color.White
        Me.fgGestiones.ColumnInfo = resources.GetString("fgGestiones.ColumnInfo")
        Me.fgGestiones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgGestiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgGestiones.ForeColor = System.Drawing.Color.Black
        Me.fgGestiones.Location = New System.Drawing.Point(0, 0)
        Me.fgGestiones.Name = "fgGestiones"
        Me.fgGestiones.Rows.Count = 2
        Me.fgGestiones.Rows.DefaultSize = 19
        Me.fgGestiones.Size = New System.Drawing.Size(647, 601)
        Me.fgGestiones.StyleInfo = resources.GetString("fgGestiones.StyleInfo")
        Me.fgGestiones.TabIndex = 60
        '
        'tb3
        '
        Me.tb3.BackColor = System.Drawing.Color.White
        Me.tb3.Controls.Add(Me.GroupBox5)
        Me.tb3.Controls.Add(Me.GroupBox4)
        Me.tb3.Location = New System.Drawing.Point(4, 22)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(647, 601)
        Me.tb3.TabIndex = 2
        Me.tb3.Text = "Datos Fiadores / Codeudores"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fgCodeudor)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox5.Location = New System.Drawing.Point(21, 303)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(610, 275)
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
        Me.fgCodeudor.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.fgCodeudor.ForeColor = System.Drawing.Color.Black
        Me.fgCodeudor.Location = New System.Drawing.Point(3, 16)
        Me.fgCodeudor.Name = "fgCodeudor"
        Me.fgCodeudor.Rows.Count = 2
        Me.fgCodeudor.Rows.DefaultSize = 19
        Me.fgCodeudor.Size = New System.Drawing.Size(604, 256)
        Me.fgCodeudor.StyleInfo = resources.GetString("fgCodeudor.StyleInfo")
        Me.fgCodeudor.TabIndex = 59
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.fgFiador)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(21, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(610, 276)
        Me.GroupBox4.TabIndex = 64
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fiadores:"
        '
        'fgFiador
        '
        Me.fgFiador.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgFiador.AllowEditing = False
        Me.fgFiador.AllowFiltering = True
        Me.fgFiador.BackColor = System.Drawing.Color.White
        Me.fgFiador.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgFiador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fgFiador.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.fgFiador.ForeColor = System.Drawing.Color.Black
        Me.fgFiador.Location = New System.Drawing.Point(3, 16)
        Me.fgFiador.Name = "fgFiador"
        Me.fgFiador.Rows.Count = 2
        Me.fgFiador.Rows.DefaultSize = 19
        Me.fgFiador.Size = New System.Drawing.Size(604, 257)
        Me.fgFiador.StyleInfo = resources.GetString("fgFiador.StyleInfo")
        Me.fgFiador.TabIndex = 58
        '
        'tb5
        '
        Me.tb5.BackColor = System.Drawing.Color.Teal
        Me.tb5.Controls.Add(Me.fg)
        Me.tb5.Location = New System.Drawing.Point(4, 22)
        Me.tb5.Name = "tb5"
        Me.tb5.Size = New System.Drawing.Size(647, 601)
        Me.tb5.TabIndex = 4
        Me.tb5.Text = "Detalle Pagos"
        Me.tb5.UseVisualStyleBackColor = True
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(0, 0)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(647, 601)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 58
        '
        'btnTablaSimulada1
        '
        Me.btnTablaSimulada1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnTablaSimulada1.Location = New System.Drawing.Point(506, 696)
        Me.btnTablaSimulada1.Name = "btnTablaSimulada1"
        Me.btnTablaSimulada1.Size = New System.Drawing.Size(169, 29)
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
        Me.btnConsultarTbAmortiza1.Location = New System.Drawing.Point(312, 696)
        Me.btnConsultarTbAmortiza1.Name = "btnConsultarTbAmortiza1"
        Me.btnConsultarTbAmortiza1.Size = New System.Drawing.Size(189, 29)
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
        Me.btnCobrosGestion1.Location = New System.Drawing.Point(199, 696)
        Me.btnCobrosGestion1.Name = "btnCobrosGestion1"
        Me.btnCobrosGestion1.Size = New System.Drawing.Size(108, 28)
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
        Me.txtDUICliente.Size = New System.Drawing.Size(120, 18)
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
        Me.txtNITCliente.Size = New System.Drawing.Size(152, 18)
        Me.txtNITCliente.TabIndex = 196
        Me.txtNITCliente.Tag = Nothing
        '
        'frmMsCBGestionCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(693, 788)
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
        Me.tb1.PerformLayout()
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
        CType(Me.fgGestiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.fgCodeudor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.fgFiador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tb5.ResumeLayout(False)
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


    Private Sub frmCBMsGestionCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, dsTmp As New DataSet, drTmp As DataRow
        Dim oAso As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Dim oPres As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
        Dim ds As New Data.DataSet
        Dim dr As DataRow
        Dim tipoDoc As String

        llenarTipoCobranza()
        ds = oCred.ConsultarPrestamos("*", "CodPrestamo = '" & Me.CodPrestamo.Trim & "'", "", sUsuario, sPassword, sSucursal)
        dr = ds.Tables("PRPrestamos").Rows(0)
        NumSolicitud = CInt(dr("NumSolicitud"))
        vCodTablaAmortiza = IIf(IsDBNull(dr("CodTablaAmortiza")), " ", dr("CodTablaAmortiza"))
        Me.lblCodPrestamo.Text = Me.CodPrestamo.Trim

        Me.txtMonto.Text = Format(IIf(IsDBNull(dr("Monto")), 0, dr("Monto")), "###,##0.00")

        Me.txtTasaInteres.Text = IIf(IsDBNull(dr("Tasa_Interes")), 0, dr("Tasa_Interes"))
        Me.txtTasaInteresMora.Text = Format(IIf(IsDBNull(dr("Tasa_Interes_Mora")), 0, dr("Tasa_Interes_Mora")), "###,##0.00")

        Me.txtCuotaTotal.Text = Format(IIf(IsDBNull(dr("CuotaTotal")), 0, dr("CuotaTotal")), "###,##0.00")

        Me.txtPlazo.Text = IIf(IsDBNull(dr("PlazoMeses")), 0, dr("PlazoMeses"))

        If Not IsDBNull(dr("FechaOtorgamiento")) Then
            Me.txtFechaOtorgamiento.Text = dr("FechaOtorgamiento")
        End If
        Me.txtCategoria.Text = IIf(IsDBNull(dr("Categoria")), " ", dr("Categoria"))
        If Not IsDBNull(dr("Fechavencimiento")) Then
            Me.txtFechaVencimiento.Text = dr("FechaVencimiento")
        End If


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

        '===================================================================================================================================
        Me.txtSaldoDiaSegDeuda.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_SeguroDeuda")), 0, dr("SaldoDia_SeguroDeuda")), 2), "###,##0.00")
        Me.txtSaldoDiaAhorro.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_Ahorro")), 0, dr("SaldoDia_Ahorro")), 2), "###,##0.00")
        Me.txtSaldoDiaSegDanios.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_SeguroDaniosyLA")), 0, dr("SaldoDia_SeguroDaniosyLA")), 2), "###,##0.00")
        Me.txtSaldoDiaComision.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_ComisionManejo")), 0, dr("SaldoDia_ComisionManejo")), 2), "###,##0.00")
        Me.txtSaldoDiaAportacion.Text = Format(Math.Round(IIf(IsDBNull(dr("SaldoDia_Aportacion")), 0, dr("SaldoDia_Aportacion")), 2), "###,##0.00")
        Me.txtSaldoCapital.Text = Format(Math.Round(IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital")), 2), "###,##0.00")
        ' Me.txtDiasEnMora.Text = IIf(IsDBNull(dr("DiasMora")), 0, dr("DiasMora"))
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

        dsTmp = oCred.ConsultarGestoresxCredito("*", "pr.CodPrestamo='" & Me.CodPrestamo.Trim & "' and pr.Estado='A'", "*", sUsuario, sPassword, sSucursal)
        If dsTmp.Tables(0).Rows.Count > 0 Then
            drTmp = dsTmp.Tables(0).Rows(0)
            Me.txtGestor.Text = "Despacho / Colector asignado:" & vbCrLf & IIf(IsDBNull(drTmp("Nombre")), 0, drTmp("Nombre"))
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


        DatosFiador = oCred.ConsultarDatGral("codEnlace,CONCAT(rtrim(Nombres),' ',rtrim(Apellido1),' ',rtrim(Apellido2),' ',rtrim(Apellido3)) [Fiador]", "NumSolicitud = " & NumSolicitud & " AND Fiador='1' AND FiadorDescartado = '0'", "codEnlace", sUsuario, sPassword, sSucursal)
        fgFiador.DataSource = DatosFiador.Tables(0)



        ds = oCred.ConsultarDatGral("codEnlace,CONCAT(rtrim(Nombres),' ',rtrim(Apellido1),' ',rtrim(Apellido2),' ',rtrim(Apellido3)) [Fiador] ", "NumSolicitud = " & NumSolicitud & " AND Fiador='2'", "codEnlace", sUsuario, sPassword, sSucursal)
        fgCodeudor.DataSource = ds.Tables(0)

    End Sub
    Protected Sub llenarTipoCobranza()
        Dim dts As New DataSet
        dts = credito.ConsultarTipoCobranza("CodTipoCobranza,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        cbCobranza.DataSource = dts.Tables(0)
        cbCobranza.DisplayMember = "Descripcion"
        cbCobranza.ValueMember = "CodTipoCobranza"
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
        End If
    End Sub


    Private Sub txtNoCuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCuotas.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
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
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultarTbAmortiza1_Click(sender As Object, e As EventArgs) Handles btnConsultarTbAmortiza1.Click
        Try
            Dim ofrm As New frmCBConsultaTablaAmortiza
            ofrm.CodTablaAmortiza = vCodTablaAmortiza
            ofrm.vCodPrestamo = CodPrestamo
            ofrm.StartPosition = FormStartPosition.CenterScreen
            '
            ofrm.ShowDialog()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
            '
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
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Protected Function recuperarGestor(usuario As String) As String
        Dim dts As New DataSet
        dts = credito.ConsultarGestores("codGestor", " usuario = '" & usuario & "'", "", sUsuario, sPassword, sSucursal)
        Return dts.Tables(0).Rows(0).Item(0).ToString.Trim
    End Function
    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String, pTipo As String
            Dim oPrest As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
            Dim Filas As Data.DataRowCollection, ds As New DataSet
            Dim codGestor As String
            codGestor = recuperarGestor(sUsuario)
            If Me.btnAdd1.Text = "&Guardar Gestión" Then
                pCampos = "CodGestor,CodPrestamo,CodTipoCobranza,Fecha,Hora,Comentario,Observaciones,FechaPactada,PagoEfectuado"
                pValores = "'" & codGestor & "','" & Me.vCodPrestamo.Trim & "','" & cbCobranza.SelectedValue & "','" & Format(Me.dtFecha.Value, "dd/MM/yyyy") & "','" & Now.ToShortTimeString & "','" & Me.txtAcuerdo.Text.Trim & "','" & Me.txtObservaciones.Text.Trim & "','" & Format(Me.dtpFechaPactada.Value, "dd/MM/yyyy") & "','0'"
                If oCred.InsertarBitacoraGestores(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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

    Private Sub gbGestion_Enter(sender As Object, e As EventArgs) Handles gbGestion.Enter

    End Sub

    Private Sub MetroTabPage1_Click(sender As Object, e As EventArgs) Handles MetroTabPage1.Click

    End Sub

    Private Sub btnEstadoCta_Click(sender As Object, e As EventArgs) Handles btnEstadoCta.Click
        Dim frm As New frmRepPREstadoCuenta
        With frm
            .txtDui.Value = txtDui.Value
            .txtAsociado.Text = txtNoAsoc.Text
            .llenarPrestamos()
            .cbPrestamo.SelectedValue = lblCodPrestamo.Text
            .cbPrestamo.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Dim frm As New frmIngresoAsoc2
        With frm
            .txtDui.Text = txtDui.Value
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