Imports CrystalDecisions.CrystalReports.Engine
Public Class frmMsDetCaFactura
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private vPago As Decimal, vMontoItem As Decimal, pFechaApertura As Date
    'Private vDui As String, ofrm As frmCAFactura, vTipo As Caja.clsCAFactura.TipoMovimiento, vFecha As Date, vRubro As String, vTipoMov As String, vTipoDoc As String
    Private vDui As String, ofrm As frmCAFactura, vTipo As sifLib.Caja.clsCAFacturas.TipoMovimiento, vFecha As Date, vRubro As String, vTipoMov As String, vTipoDoc As String
    Private vPagoLibreta As String, vFechaOtorgamiento As Date
    'Private vAccionDetalle As Caja.clsCAFactura.TipoAccionFacturas, vValDiv As Double, pCE As String, pItemCE As String
    Private vAccionDetalle As sifLib.Caja.clsCAFacturas.TipoAccionFacturas, vValDiv As Double, pCE As String, pItemCE As String
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTerceraPersona As System.Windows.Forms.RadioButton
    Friend WithEvents rbTitular As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombreTercero As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNoDocTerceros As System.Windows.Forms.TextBox
    Friend WithEvents lblNoDoc As System.Windows.Forms.Label
    Dim IdCuenta As String
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim ahorros As New wrAhorro.wsLibAhorro
    Private vNombAsociado As String
    Dim vCodTipoAhorro As String
    Friend WithEvents lblInactiva As System.Windows.Forms.Label
    Dim vFormaPago As Integer
    Friend WithEvents btnAceptarLin1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelarLin1 As MetroFramework.Controls.MetroButton
    Dim vSaldoGestion As Double
    Friend WithEvents Label3 As Label
    Friend WithEvents gbCxC As GroupBox
    Friend WithEvents txtSaldoCxC As TextBox
    Friend WithEvents txtNoCxC As TextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNoCxC As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMontoCxC As TextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFechaCreaCxC As TextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCtaOrigen As TextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Dim vCodItemRubro As String
    Friend WithEvents txtNoLibreta As TextBox
    Dim contabilidad As New wrConta.wsLibContab
    Dim facturacion As New wrCaja.wsLibCaja


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents gbDPF As System.Windows.Forms.GroupBox
    Friend WithEvents txtDPFCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtDPFNoCert As System.Windows.Forms.TextBox
    Friend WithEvents txtDPFMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents c1nDPFSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtDPFNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents gbAhorros As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents lblDiaCuota As System.Windows.Forms.Label
    Friend WithEvents txtCuotasNoPagadas As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoPendiente As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents c1nCuota As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoCtaAhorro As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents gbCheque As System.Windows.Forms.GroupBox
    Friend WithEvents txtPaguese As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtGirador As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents gbDocxCobrar As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodTipoCreditoCxC As System.Windows.Forms.TextBox
    Friend WithEvents c1nMontoCxC As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nNoCuotasCxC As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nSaldoCxC As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtFechaCxC As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtCodPrestamoCxC As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents gbPrestamo As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCuota As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtIntMora As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCapitalMora As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFecha1aCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtPago As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtCodItem As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtNoCtaBancaria As System.Windows.Forms.TextBox
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtNoReserva As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents gbOtros As System.Windows.Forms.GroupBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1nSaldoCtasOrden As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtDespacho As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbDPF = New System.Windows.Forms.GroupBox()
        Me.txtDPFCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtDPFNoCert = New System.Windows.Forms.TextBox()
        Me.txtDPFMonto = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.c1nDPFSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtDPFNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.gbAhorros = New System.Windows.Forms.GroupBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.lblDiaCuota = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSaldoCtaAhorro = New C1.Win.C1Input.C1NumericEdit()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCuotasNoPagadas = New System.Windows.Forms.TextBox()
        Me.txtSaldoPendiente = New System.Windows.Forms.TextBox()
        Me.c1nCuota = New C1.Win.C1Input.C1NumericEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.gbCheque = New System.Windows.Forms.GroupBox()
        Me.txtPaguese = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtGirador = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.gbDocxCobrar = New System.Windows.Forms.GroupBox()
        Me.c1nSaldoCtasOrden = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtCodTipoCreditoCxC = New System.Windows.Forms.TextBox()
        Me.c1nMontoCxC = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nNoCuotasCxC = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nSaldoCxC = New C1.Win.C1Input.C1NumericEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtFechaCxC = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtCodPrestamoCxC = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.gbPrestamo = New System.Windows.Forms.GroupBox()
        Me.txtDespacho = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.txtCuota = New C1.Win.C1Input.C1NumericEdit()
        Me.txtIntMora = New C1.Win.C1Input.C1NumericEdit()
        Me.txtCapitalMora = New C1.Win.C1Input.C1NumericEdit()
        Me.txtSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCodTipoCredito = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFecha1aCuota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblInactiva = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbTerceraPersona = New System.Windows.Forms.RadioButton()
        Me.rbTitular = New System.Windows.Forms.RadioButton()
        Me.txtNombreTercero = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNoDocTerceros = New System.Windows.Forms.TextBox()
        Me.lblNoDoc = New System.Windows.Forms.Label()
        Me.txtCodItem = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPago = New C1.Win.C1Input.C1NumericEdit()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.txtNoCtaBancaria = New System.Windows.Forms.TextBox()
        Me.txtNoCheque = New System.Windows.Forms.TextBox()
        Me.txtNoReserva = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.gbOtros = New System.Windows.Forms.GroupBox()
        Me.btnAceptarLin1 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btnCancelarLin1 = New MetroFramework.Controls.MetroButton()
        Me.gbCxC = New System.Windows.Forms.GroupBox()
        Me.txtMontoCxC = New System.Windows.Forms.TextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtFechaCreaCxC = New System.Windows.Forms.TextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtCtaOrigen = New System.Windows.Forms.TextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtSaldoCxC = New System.Windows.Forms.TextBox()
        Me.txtNoCxC = New System.Windows.Forms.TextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblNoCxC = New MetroFramework.Controls.MetroLabel()
        Me.txtNoLibreta = New System.Windows.Forms.TextBox()
        Me.gbDPF.SuspendLayout()
        CType(Me.c1nDPFSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAhorros.SuspendLayout()
        CType(Me.txtSaldoCtaAhorro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCheque.SuspendLayout()
        Me.gbDocxCobrar.SuspendLayout()
        CType(Me.c1nSaldoCtasOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoCxC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nNoCuotasCxC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSaldoCxC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPrestamo.SuspendLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCapitalMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbCxC.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDPF
        '
        Me.gbDPF.BackColor = System.Drawing.Color.White
        Me.gbDPF.Controls.Add(Me.txtDPFCodTipoAhorro)
        Me.gbDPF.Controls.Add(Me.txtDPFNoCert)
        Me.gbDPF.Controls.Add(Me.txtDPFMonto)
        Me.gbDPF.Controls.Add(Me.Label33)
        Me.gbDPF.Controls.Add(Me.Label34)
        Me.gbDPF.Controls.Add(Me.c1nDPFSaldo)
        Me.gbDPF.Controls.Add(Me.Label36)
        Me.gbDPF.Controls.Add(Me.txtDPFNoCuenta)
        Me.gbDPF.Controls.Add(Me.Label37)
        Me.gbDPF.Location = New System.Drawing.Point(19, 60)
        Me.gbDPF.Name = "gbDPF"
        Me.gbDPF.Size = New System.Drawing.Size(406, 177)
        Me.gbDPF.TabIndex = 4
        Me.gbDPF.TabStop = False
        '
        'txtDPFCodTipoAhorro
        '
        Me.txtDPFCodTipoAhorro.BackColor = System.Drawing.Color.White
        Me.txtDPFCodTipoAhorro.Location = New System.Drawing.Point(70, 87)
        Me.txtDPFCodTipoAhorro.Name = "txtDPFCodTipoAhorro"
        Me.txtDPFCodTipoAhorro.Size = New System.Drawing.Size(8, 20)
        Me.txtDPFCodTipoAhorro.TabIndex = 7
        Me.txtDPFCodTipoAhorro.Visible = False
        '
        'txtDPFNoCert
        '
        Me.txtDPFNoCert.BackColor = System.Drawing.Color.White
        Me.txtDPFNoCert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDPFNoCert.Enabled = False
        Me.txtDPFNoCert.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txtDPFNoCert.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDPFNoCert.Location = New System.Drawing.Point(83, 63)
        Me.txtDPFNoCert.Name = "txtDPFNoCert"
        Me.txtDPFNoCert.ReadOnly = True
        Me.txtDPFNoCert.Size = New System.Drawing.Size(317, 20)
        Me.txtDPFNoCert.TabIndex = 5
        Me.txtDPFNoCert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDPFMonto
        '
        Me.txtDPFMonto.BackColor = System.Drawing.Color.White
        Me.txtDPFMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDPFMonto.Enabled = False
        Me.txtDPFMonto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPFMonto.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDPFMonto.Location = New System.Drawing.Point(83, 38)
        Me.txtDPFMonto.Name = "txtDPFMonto"
        Me.txtDPFMonto.ReadOnly = True
        Me.txtDPFMonto.Size = New System.Drawing.Size(317, 20)
        Me.txtDPFMonto.TabIndex = 3
        Me.txtDPFMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(5, 39)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 18)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Monto:"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(5, 65)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(73, 16)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "Certificado:"
        '
        'c1nDPFSaldo
        '
        Me.c1nDPFSaldo.BackColor = System.Drawing.Color.White
        Me.c1nDPFSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nDPFSaldo.Culture = 17418
        Me.c1nDPFSaldo.CustomFormat = "#0.00"
        Me.c1nDPFSaldo.Enabled = False
        Me.c1nDPFSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nDPFSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nDPFSaldo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nDPFSaldo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nDPFSaldo.Location = New System.Drawing.Point(83, 88)
        Me.c1nDPFSaldo.Name = "c1nDPFSaldo"
        Me.c1nDPFSaldo.ReadOnly = True
        Me.c1nDPFSaldo.Size = New System.Drawing.Size(317, 17)
        Me.c1nDPFSaldo.TabIndex = 8
        Me.c1nDPFSaldo.Tag = Nothing
        Me.c1nDPFSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nDPFSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nDPFSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(5, 90)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(40, 17)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Saldo"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDPFNoCuenta
        '
        Me.txtDPFNoCuenta.BackColor = System.Drawing.Color.White
        Me.txtDPFNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDPFNoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPFNoCuenta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDPFNoCuenta.Location = New System.Drawing.Point(83, 13)
        Me.txtDPFNoCuenta.Name = "txtDPFNoCuenta"
        Me.txtDPFNoCuenta.Size = New System.Drawing.Size(317, 20)
        Me.txtDPFNoCuenta.TabIndex = 1
        Me.txtDPFNoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(5, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(73, 16)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "No. Cuenta:"
        '
        'gbAhorros
        '
        Me.gbAhorros.BackColor = System.Drawing.Color.White
        Me.gbAhorros.Controls.Add(Me.txtCodTipoAhorro)
        Me.gbAhorros.Controls.Add(Me.lblDiaCuota)
        Me.gbAhorros.Controls.Add(Me.txtNoCuenta)
        Me.gbAhorros.Controls.Add(Me.Label28)
        Me.gbAhorros.Controls.Add(Me.Label21)
        Me.gbAhorros.Controls.Add(Me.txtSaldoCtaAhorro)
        Me.gbAhorros.Controls.Add(Me.Label26)
        Me.gbAhorros.Controls.Add(Me.Label32)
        Me.gbAhorros.Controls.Add(Me.txtCuotasNoPagadas)
        Me.gbAhorros.Controls.Add(Me.txtSaldoPendiente)
        Me.gbAhorros.Controls.Add(Me.c1nCuota)
        Me.gbAhorros.Controls.Add(Me.Label18)
        Me.gbAhorros.Controls.Add(Me.Label31)
        Me.gbAhorros.Location = New System.Drawing.Point(19, 60)
        Me.gbAhorros.Name = "gbAhorros"
        Me.gbAhorros.Size = New System.Drawing.Size(406, 177)
        Me.gbAhorros.TabIndex = 2
        Me.gbAhorros.TabStop = False
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(392, 144)
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(9, 20)
        Me.txtCodTipoAhorro.TabIndex = 12
        Me.txtCodTipoAhorro.Visible = False
        '
        'lblDiaCuota
        '
        Me.lblDiaCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaCuota.Location = New System.Drawing.Point(123, 144)
        Me.lblDiaCuota.Name = "lblDiaCuota"
        Me.lblDiaCuota.Size = New System.Drawing.Size(207, 17)
        Me.lblDiaCuota.TabIndex = 11
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoCuenta.Location = New System.Drawing.Point(126, 16)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(271, 20)
        Me.txtNoCuenta.TabIndex = 1
        Me.txtNoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(8, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 18)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "No. Cuenta:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(8, 144)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 17)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Día Abono Cuota:"
        '
        'txtSaldoCtaAhorro
        '
        Me.txtSaldoCtaAhorro.BackColor = System.Drawing.Color.White
        Me.txtSaldoCtaAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoCtaAhorro.Culture = 17418
        Me.txtSaldoCtaAhorro.CustomFormat = "#0.00"
        Me.txtSaldoCtaAhorro.Enabled = False
        Me.txtSaldoCtaAhorro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldoCtaAhorro.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSaldoCtaAhorro.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtSaldoCtaAhorro.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSaldoCtaAhorro.Location = New System.Drawing.Point(126, 41)
        Me.txtSaldoCtaAhorro.Name = "txtSaldoCtaAhorro"
        Me.txtSaldoCtaAhorro.ReadOnly = True
        Me.txtSaldoCtaAhorro.Size = New System.Drawing.Size(271, 16)
        Me.txtSaldoCtaAhorro.TabIndex = 3
        Me.txtSaldoCtaAhorro.Tag = Nothing
        Me.txtSaldoCtaAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldoCtaAhorro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldoCtaAhorro.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(11, 42)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 17)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Saldo"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(8, 67)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(99, 17)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "Saldo Pendiente:"
        '
        'txtCuotasNoPagadas
        '
        Me.txtCuotasNoPagadas.BackColor = System.Drawing.Color.White
        Me.txtCuotasNoPagadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuotasNoPagadas.Enabled = False
        Me.txtCuotasNoPagadas.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txtCuotasNoPagadas.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCuotasNoPagadas.Location = New System.Drawing.Point(126, 117)
        Me.txtCuotasNoPagadas.Name = "txtCuotasNoPagadas"
        Me.txtCuotasNoPagadas.ReadOnly = True
        Me.txtCuotasNoPagadas.Size = New System.Drawing.Size(271, 20)
        Me.txtCuotasNoPagadas.TabIndex = 9
        Me.txtCuotasNoPagadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoPendiente
        '
        Me.txtSaldoPendiente.BackColor = System.Drawing.Color.White
        Me.txtSaldoPendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoPendiente.Enabled = False
        Me.txtSaldoPendiente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoPendiente.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtSaldoPendiente.Location = New System.Drawing.Point(126, 66)
        Me.txtSaldoPendiente.Name = "txtSaldoPendiente"
        Me.txtSaldoPendiente.ReadOnly = True
        Me.txtSaldoPendiente.Size = New System.Drawing.Size(271, 20)
        Me.txtSaldoPendiente.TabIndex = 5
        Me.txtSaldoPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'c1nCuota
        '
        Me.c1nCuota.BackColor = System.Drawing.Color.White
        Me.c1nCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCuota.Culture = 17418
        Me.c1nCuota.CustomFormat = "#0.00"
        Me.c1nCuota.Enabled = False
        Me.c1nCuota.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nCuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCuota.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCuota.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nCuota.Location = New System.Drawing.Point(126, 91)
        Me.c1nCuota.Name = "c1nCuota"
        Me.c1nCuota.ReadOnly = True
        Me.c1nCuota.Size = New System.Drawing.Size(271, 16)
        Me.c1nCuota.TabIndex = 7
        Me.c1nCuota.Tag = Nothing
        Me.c1nCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nCuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCuota.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(11, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 18)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Cuota"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(8, 118)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(113, 21)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Cuotas pendientes:"
        '
        'gbCheque
        '
        Me.gbCheque.BackColor = System.Drawing.Color.White
        Me.gbCheque.Controls.Add(Me.txtPaguese)
        Me.gbCheque.Controls.Add(Me.Label24)
        Me.gbCheque.Controls.Add(Me.txtGirador)
        Me.gbCheque.Controls.Add(Me.Label43)
        Me.gbCheque.Location = New System.Drawing.Point(19, 60)
        Me.gbCheque.Name = "gbCheque"
        Me.gbCheque.Size = New System.Drawing.Size(406, 177)
        Me.gbCheque.TabIndex = 3
        Me.gbCheque.TabStop = False
        '
        'txtPaguese
        '
        Me.txtPaguese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaguese.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaguese.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtPaguese.Location = New System.Drawing.Point(11, 85)
        Me.txtPaguese.MaxLength = 100
        Me.txtPaguese.Name = "txtPaguese"
        Me.txtPaguese.Size = New System.Drawing.Size(386, 20)
        Me.txtPaguese.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(8, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(128, 17)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Paguese a la Orden de:"
        '
        'txtGirador
        '
        Me.txtGirador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGirador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGirador.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtGirador.Location = New System.Drawing.Point(11, 35)
        Me.txtGirador.MaxLength = 100
        Me.txtGirador.Name = "txtGirador"
        Me.txtGirador.Size = New System.Drawing.Size(386, 20)
        Me.txtGirador.TabIndex = 2
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(8, 16)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(199, 16)
        Me.Label43.TabIndex = 1
        Me.Label43.Text = "Nombre del Girador:"
        '
        'gbDocxCobrar
        '
        Me.gbDocxCobrar.BackColor = System.Drawing.Color.White
        Me.gbDocxCobrar.Controls.Add(Me.c1nSaldoCtasOrden)
        Me.gbDocxCobrar.Controls.Add(Me.Label2)
        Me.gbDocxCobrar.Controls.Add(Me.txtEstado)
        Me.gbDocxCobrar.Controls.Add(Me.txtCodTipoCreditoCxC)
        Me.gbDocxCobrar.Controls.Add(Me.c1nMontoCxC)
        Me.gbDocxCobrar.Controls.Add(Me.c1nNoCuotasCxC)
        Me.gbDocxCobrar.Controls.Add(Me.c1nSaldoCxC)
        Me.gbDocxCobrar.Controls.Add(Me.Label22)
        Me.gbDocxCobrar.Controls.Add(Me.Label35)
        Me.gbDocxCobrar.Controls.Add(Me.Label38)
        Me.gbDocxCobrar.Controls.Add(Me.txtFechaCxC)
        Me.gbDocxCobrar.Controls.Add(Me.Label39)
        Me.gbDocxCobrar.Controls.Add(Me.txtCodPrestamoCxC)
        Me.gbDocxCobrar.Controls.Add(Me.Label40)
        Me.gbDocxCobrar.Location = New System.Drawing.Point(19, 60)
        Me.gbDocxCobrar.Name = "gbDocxCobrar"
        Me.gbDocxCobrar.Size = New System.Drawing.Size(406, 177)
        Me.gbDocxCobrar.TabIndex = 5
        Me.gbDocxCobrar.TabStop = False
        '
        'c1nSaldoCtasOrden
        '
        Me.c1nSaldoCtasOrden.BackColor = System.Drawing.Color.White
        Me.c1nSaldoCtasOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldoCtasOrden.Culture = 17418
        Me.c1nSaldoCtasOrden.CustomFormat = "#0.00"
        Me.c1nSaldoCtasOrden.Enabled = False
        Me.c1nSaldoCtasOrden.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nSaldoCtasOrden.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldoCtasOrden.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nSaldoCtasOrden.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nSaldoCtasOrden.Location = New System.Drawing.Point(78, 93)
        Me.c1nSaldoCtasOrden.Name = "c1nSaldoCtasOrden"
        Me.c1nSaldoCtasOrden.ReadOnly = True
        Me.c1nSaldoCtasOrden.Size = New System.Drawing.Size(120, 16)
        Me.c1nSaldoCtasOrden.TabIndex = 11
        Me.c1nSaldoCtasOrden.Tag = Nothing
        Me.c1nSaldoCtasOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nSaldoCtasOrden.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nSaldoCtasOrden.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Saldo Ctas. Orden:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(211, 94)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(7, 20)
        Me.txtEstado.TabIndex = 12
        Me.txtEstado.Visible = False
        '
        'txtCodTipoCreditoCxC
        '
        Me.txtCodTipoCreditoCxC.Location = New System.Drawing.Point(223, 94)
        Me.txtCodTipoCreditoCxC.Name = "txtCodTipoCreditoCxC"
        Me.txtCodTipoCreditoCxC.Size = New System.Drawing.Size(9, 20)
        Me.txtCodTipoCreditoCxC.TabIndex = 13
        Me.txtCodTipoCreditoCxC.Visible = False
        '
        'c1nMontoCxC
        '
        Me.c1nMontoCxC.BackColor = System.Drawing.Color.White
        Me.c1nMontoCxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoCxC.Culture = 17418
        Me.c1nMontoCxC.CustomFormat = "#0.00"
        Me.c1nMontoCxC.Enabled = False
        Me.c1nMontoCxC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nMontoCxC.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoCxC.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMontoCxC.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nMontoCxC.Location = New System.Drawing.Point(78, 43)
        Me.c1nMontoCxC.Name = "c1nMontoCxC"
        Me.c1nMontoCxC.ReadOnly = True
        Me.c1nMontoCxC.Size = New System.Drawing.Size(120, 17)
        Me.c1nMontoCxC.TabIndex = 3
        Me.c1nMontoCxC.Tag = Nothing
        Me.c1nMontoCxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nMontoCxC.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoCxC.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nNoCuotasCxC
        '
        Me.c1nNoCuotasCxC.BackColor = System.Drawing.Color.White
        Me.c1nNoCuotasCxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nNoCuotasCxC.Culture = 17418
        Me.c1nNoCuotasCxC.CustomFormat = "#0.00"
        Me.c1nNoCuotasCxC.Enabled = False
        Me.c1nNoCuotasCxC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nNoCuotasCxC.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nNoCuotasCxC.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nNoCuotasCxC.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nNoCuotasCxC.Location = New System.Drawing.Point(277, 68)
        Me.c1nNoCuotasCxC.Name = "c1nNoCuotasCxC"
        Me.c1nNoCuotasCxC.ReadOnly = True
        Me.c1nNoCuotasCxC.Size = New System.Drawing.Size(120, 17)
        Me.c1nNoCuotasCxC.TabIndex = 9
        Me.c1nNoCuotasCxC.Tag = Nothing
        Me.c1nNoCuotasCxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nNoCuotasCxC.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nNoCuotasCxC.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nSaldoCxC
        '
        Me.c1nSaldoCxC.BackColor = System.Drawing.Color.White
        Me.c1nSaldoCxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldoCxC.Culture = 17418
        Me.c1nSaldoCxC.CustomFormat = "#0.00"
        Me.c1nSaldoCxC.Enabled = False
        Me.c1nSaldoCxC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nSaldoCxC.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldoCxC.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nSaldoCxC.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nSaldoCxC.Location = New System.Drawing.Point(277, 43)
        Me.c1nSaldoCxC.Name = "c1nSaldoCxC"
        Me.c1nSaldoCxC.ReadOnly = True
        Me.c1nSaldoCxC.Size = New System.Drawing.Size(120, 17)
        Me.c1nSaldoCxC.TabIndex = 5
        Me.c1nSaldoCxC.Tag = Nothing
        Me.c1nSaldoCxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nSaldoCxC.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nSaldoCxC.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(208, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 20)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "No. Cuotas:"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(208, 45)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(40, 17)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Saldo"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(10, 45)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(40, 16)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "Monto"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFechaCxC
        '
        Me.txtFechaCxC.BackColor = System.Drawing.Color.White
        Me.txtFechaCxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaCxC.Location = New System.Drawing.Point(78, 68)
        Me.txtFechaCxC.MaxLength = 8
        Me.txtFechaCxC.Name = "txtFechaCxC"
        Me.txtFechaCxC.ReadOnly = True
        Me.txtFechaCxC.Size = New System.Drawing.Size(120, 20)
        Me.txtFechaCxC.TabIndex = 7
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(8, 68)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(61, 17)
        Me.Label39.TabIndex = 6
        Me.Label39.Text = "Fecha:"
        '
        'txtCodPrestamoCxC
        '
        Me.txtCodPrestamoCxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamoCxC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamoCxC.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamoCxC.Location = New System.Drawing.Point(78, 18)
        Me.txtCodPrestamoCxC.Name = "txtCodPrestamoCxC"
        Me.txtCodPrestamoCxC.Size = New System.Drawing.Size(319, 20)
        Me.txtCodPrestamoCxC.TabIndex = 1
        Me.txtCodPrestamoCxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(8, 16)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(61, 20)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Préstamo:"
        '
        'gbPrestamo
        '
        Me.gbPrestamo.BackColor = System.Drawing.Color.White
        Me.gbPrestamo.Controls.Add(Me.txtDespacho)
        Me.gbPrestamo.Controls.Add(Me.Label1)
        Me.gbPrestamo.Controls.Add(Me.txtMonto)
        Me.gbPrestamo.Controls.Add(Me.txtCuota)
        Me.gbPrestamo.Controls.Add(Me.txtIntMora)
        Me.gbPrestamo.Controls.Add(Me.txtCapitalMora)
        Me.gbPrestamo.Controls.Add(Me.txtSaldo)
        Me.gbPrestamo.Controls.Add(Me.Label17)
        Me.gbPrestamo.Controls.Add(Me.Label16)
        Me.gbPrestamo.Controls.Add(Me.Label15)
        Me.gbPrestamo.Controls.Add(Me.Label13)
        Me.gbPrestamo.Controls.Add(Me.txtCodTipoCredito)
        Me.gbPrestamo.Controls.Add(Me.Label6)
        Me.gbPrestamo.Controls.Add(Me.txtFecha1aCuota)
        Me.gbPrestamo.Controls.Add(Me.Label5)
        Me.gbPrestamo.Controls.Add(Me.txtCodPrestamo)
        Me.gbPrestamo.Controls.Add(Me.Label4)
        Me.gbPrestamo.Location = New System.Drawing.Point(19, 60)
        Me.gbPrestamo.Name = "gbPrestamo"
        Me.gbPrestamo.Size = New System.Drawing.Size(406, 177)
        Me.gbPrestamo.TabIndex = 7
        Me.gbPrestamo.TabStop = False
        '
        'txtDespacho
        '
        Me.txtDespacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDespacho.ForeColor = System.Drawing.Color.Black
        Me.txtDespacho.Location = New System.Drawing.Point(74, 119)
        Me.txtDespacho.Name = "txtDespacho"
        Me.txtDespacho.Size = New System.Drawing.Size(323, 39)
        Me.txtDespacho.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Despacho:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Culture = 17418
        Me.txtMonto.CustomFormat = "#0.00"
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMonto.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtMonto.Location = New System.Drawing.Point(74, 42)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(125, 16)
        Me.txtMonto.TabIndex = 3
        Me.txtMonto.Tag = Nothing
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtCuota
        '
        Me.txtCuota.BackColor = System.Drawing.Color.White
        Me.txtCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuota.Culture = 17418
        Me.txtCuota.CustomFormat = "#0.00"
        Me.txtCuota.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtCuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCuota.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtCuota.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtCuota.Location = New System.Drawing.Point(272, 67)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.ReadOnly = True
        Me.txtCuota.Size = New System.Drawing.Size(125, 16)
        Me.txtCuota.TabIndex = 9
        Me.txtCuota.Tag = Nothing
        Me.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCuota.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtIntMora
        '
        Me.txtIntMora.BackColor = System.Drawing.Color.White
        Me.txtIntMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntMora.Culture = 17418
        Me.txtIntMora.CustomFormat = "#0.00"
        Me.txtIntMora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtIntMora.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtIntMora.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtIntMora.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtIntMora.Location = New System.Drawing.Point(272, 92)
        Me.txtIntMora.Name = "txtIntMora"
        Me.txtIntMora.ReadOnly = True
        Me.txtIntMora.Size = New System.Drawing.Size(125, 16)
        Me.txtIntMora.TabIndex = 13
        Me.txtIntMora.Tag = Nothing
        Me.txtIntMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIntMora.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIntMora.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtCapitalMora
        '
        Me.txtCapitalMora.BackColor = System.Drawing.Color.White
        Me.txtCapitalMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCapitalMora.Culture = 17418
        Me.txtCapitalMora.CustomFormat = "#,##0.00"
        Me.txtCapitalMora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtCapitalMora.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCapitalMora.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtCapitalMora.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtCapitalMora.Location = New System.Drawing.Point(74, 91)
        Me.txtCapitalMora.Name = "txtCapitalMora"
        Me.txtCapitalMora.ReadOnly = True
        Me.txtCapitalMora.Size = New System.Drawing.Size(125, 16)
        Me.txtCapitalMora.TabIndex = 11
        Me.txtCapitalMora.Tag = Nothing
        Me.txtCapitalMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCapitalMora.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCapitalMora.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.Culture = 17418
        Me.txtSaldo.CustomFormat = "#0.00"
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSaldo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtSaldo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSaldo.Location = New System.Drawing.Point(272, 42)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(125, 16)
        Me.txtSaldo.TabIndex = 5
        Me.txtSaldo.Tag = Nothing
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(204, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 18)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Cuota"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(204, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 16)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Int.Mora"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 12)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Saldo Mora"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(204, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Saldo"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodTipoCredito
        '
        Me.txtCodTipoCredito.Location = New System.Drawing.Point(62, 138)
        Me.txtCodTipoCredito.Name = "txtCodTipoCredito"
        Me.txtCodTipoCredito.Size = New System.Drawing.Size(7, 20)
        Me.txtCodTipoCredito.TabIndex = 16
        Me.txtCodTipoCredito.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Monto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFecha1aCuota
        '
        Me.txtFecha1aCuota.BackColor = System.Drawing.Color.White
        Me.txtFecha1aCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha1aCuota.Location = New System.Drawing.Point(74, 67)
        Me.txtFecha1aCuota.MaxLength = 8
        Me.txtFecha1aCuota.Name = "txtFecha1aCuota"
        Me.txtFecha1aCuota.ReadOnly = True
        Me.txtFecha1aCuota.Size = New System.Drawing.Size(125, 20)
        Me.txtFecha1aCuota.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha 1a.Cuota"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamo.Location = New System.Drawing.Point(74, 16)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(323, 20)
        Me.txtCodPrestamo.TabIndex = 1
        Me.txtCodPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Préstamo:"
        '
        'lblInactiva
        '
        Me.lblInactiva.AutoSize = True
        Me.lblInactiva.BackColor = System.Drawing.Color.White
        Me.lblInactiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInactiva.ForeColor = System.Drawing.Color.Teal
        Me.lblInactiva.Location = New System.Drawing.Point(19, 239)
        Me.lblInactiva.Name = "lblInactiva"
        Me.lblInactiva.Size = New System.Drawing.Size(144, 17)
        Me.lblInactiva.TabIndex = 9
        Me.lblInactiva.Text = "CUENTA INACTIVA"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.rbTerceraPersona)
        Me.GroupBox2.Controls.Add(Me.rbTitular)
        Me.GroupBox2.Controls.Add(Me.txtNombreTercero)
        Me.GroupBox2.Controls.Add(Me.lblNombre)
        Me.GroupBox2.Controls.Add(Me.txtNoDocTerceros)
        Me.GroupBox2.Controls.Add(Me.lblNoDoc)
        Me.GroupBox2.Location = New System.Drawing.Point(441, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 90)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Abono/Retiro Terceros"
        '
        'rbTerceraPersona
        '
        Me.rbTerceraPersona.AutoSize = True
        Me.rbTerceraPersona.Location = New System.Drawing.Point(69, 19)
        Me.rbTerceraPersona.Name = "rbTerceraPersona"
        Me.rbTerceraPersona.Size = New System.Drawing.Size(67, 17)
        Me.rbTerceraPersona.TabIndex = 0
        Me.rbTerceraPersona.TabStop = True
        Me.rbTerceraPersona.Text = "Terceros"
        Me.rbTerceraPersona.UseVisualStyleBackColor = True
        '
        'rbTitular
        '
        Me.rbTitular.AutoSize = True
        Me.rbTitular.Location = New System.Drawing.Point(9, 19)
        Me.rbTitular.Name = "rbTitular"
        Me.rbTitular.Size = New System.Drawing.Size(54, 17)
        Me.rbTitular.TabIndex = 0
        Me.rbTitular.TabStop = True
        Me.rbTitular.Text = "Titular"
        Me.rbTitular.UseVisualStyleBackColor = True
        '
        'txtNombreTercero
        '
        Me.txtNombreTercero.BackColor = System.Drawing.Color.White
        Me.txtNombreTercero.Location = New System.Drawing.Point(92, 63)
        Me.txtNombreTercero.Name = "txtNombreTercero"
        Me.txtNombreTercero.Size = New System.Drawing.Size(240, 20)
        Me.txtNombreTercero.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 63)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNoDocTerceros
        '
        Me.txtNoDocTerceros.BackColor = System.Drawing.Color.White
        Me.txtNoDocTerceros.Location = New System.Drawing.Point(94, 37)
        Me.txtNoDocTerceros.Name = "txtNoDocTerceros"
        Me.txtNoDocTerceros.Size = New System.Drawing.Size(238, 20)
        Me.txtNoDocTerceros.TabIndex = 3
        '
        'lblNoDoc
        '
        Me.lblNoDoc.AutoSize = True
        Me.lblNoDoc.Location = New System.Drawing.Point(6, 40)
        Me.lblNoDoc.Name = "lblNoDoc"
        Me.lblNoDoc.Size = New System.Drawing.Size(82, 13)
        Me.lblNoDoc.TabIndex = 2
        Me.lblNoDoc.Text = "No Documento:"
        '
        'txtCodItem
        '
        Me.txtCodItem.BackColor = System.Drawing.Color.White
        Me.txtCodItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodItem.Location = New System.Drawing.Point(102, 263)
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.Size = New System.Drawing.Size(49, 21)
        Me.txtCodItem.TabIndex = 11
        Me.txtCodItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.White
        Me.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtItem.Location = New System.Drawing.Point(156, 263)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(269, 21)
        Me.txtItem.TabIndex = 12
        Me.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMensaje.Location = New System.Drawing.Point(19, 395)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ReadOnly = True
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(759, 35)
        Me.txtMensaje.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(17, 380)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Mensaje para Cajas:"
        '
        'txtPago
        '
        Me.txtPago.BackColor = System.Drawing.Color.White
        Me.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPago.Culture = 17418
        Me.txtPago.CustomFormat = "###,###,##0.00"
        Me.txtPago.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPago.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtPago.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtPago.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtPago.Location = New System.Drawing.Point(102, 289)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtPago.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtPago.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtPago.Size = New System.Drawing.Size(323, 17)
        Me.txtPago.TabIndex = 14
        Me.txtPago.Tag = Nothing
        Me.txtPago.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPago.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.White
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacion.Location = New System.Drawing.Point(19, 342)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(759, 35)
        Me.txtObservacion.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(17, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Observación:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(20, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Código Item:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(20, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 33)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Monto:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblBanco)
        Me.GroupBox1.Controls.Add(Me.txtBanco)
        Me.GroupBox1.Controls.Add(Me.txtNoCtaBancaria)
        Me.GroupBox1.Controls.Add(Me.txtNoCheque)
        Me.GroupBox1.Controls.Add(Me.txtNoReserva)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Location = New System.Drawing.Point(441, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 172)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Datos Cheque"
        '
        'lblBanco
        '
        Me.lblBanco.Location = New System.Drawing.Point(9, 140)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(323, 19)
        Me.lblBanco.TabIndex = 9
        '
        'txtBanco
        '
        Me.txtBanco.BackColor = System.Drawing.Color.White
        Me.txtBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBanco.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBanco.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtBanco.Location = New System.Drawing.Point(92, 117)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.ReadOnly = True
        Me.txtBanco.Size = New System.Drawing.Size(240, 20)
        Me.txtBanco.TabIndex = 8
        '
        'txtNoCtaBancaria
        '
        Me.txtNoCtaBancaria.BackColor = System.Drawing.Color.White
        Me.txtNoCtaBancaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCtaBancaria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCtaBancaria.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoCtaBancaria.Location = New System.Drawing.Point(92, 92)
        Me.txtNoCtaBancaria.Name = "txtNoCtaBancaria"
        Me.txtNoCtaBancaria.ReadOnly = True
        Me.txtNoCtaBancaria.Size = New System.Drawing.Size(240, 20)
        Me.txtNoCtaBancaria.TabIndex = 6
        '
        'txtNoCheque
        '
        Me.txtNoCheque.BackColor = System.Drawing.Color.White
        Me.txtNoCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCheque.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCheque.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoCheque.Location = New System.Drawing.Point(92, 67)
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.ReadOnly = True
        Me.txtNoCheque.Size = New System.Drawing.Size(240, 20)
        Me.txtNoCheque.TabIndex = 4
        '
        'txtNoReserva
        '
        Me.txtNoReserva.BackColor = System.Drawing.Color.White
        Me.txtNoReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoReserva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoReserva.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoReserva.Location = New System.Drawing.Point(92, 42)
        Me.txtNoReserva.Name = "txtNoReserva"
        Me.txtNoReserva.ReadOnly = True
        Me.txtNoReserva.Size = New System.Drawing.Size(240, 20)
        Me.txtNoReserva.TabIndex = 2
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(7, 119)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 16)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "Banco:"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(7, 94)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 16)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "No. Cuenta Bancaria:"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(7, 68)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 16)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "No. Cheque:"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(7, 43)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 16)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "No. Reserva:"
        '
        'gbOtros
        '
        Me.gbOtros.BackColor = System.Drawing.Color.White
        Me.gbOtros.Location = New System.Drawing.Point(19, 60)
        Me.gbOtros.Name = "gbOtros"
        Me.gbOtros.Size = New System.Drawing.Size(406, 177)
        Me.gbOtros.TabIndex = 0
        Me.gbOtros.TabStop = False
        '
        'btnAceptarLin1
        '
        Me.btnAceptarLin1.Location = New System.Drawing.Point(543, 444)
        Me.btnAceptarLin1.Name = "btnAceptarLin1"
        Me.btnAceptarLin1.Size = New System.Drawing.Size(75, 28)
        Me.btnAceptarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptarLin1.TabIndex = 20
        Me.btnAceptarLin1.Text = "Aceptar"
        Me.btnAceptarLin1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAceptarLin1.UseSelectable = True
        Me.btnAceptarLin1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(623, 444)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(75, 28)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 21
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btnCancelarLin1
        '
        Me.btnCancelarLin1.Location = New System.Drawing.Point(703, 444)
        Me.btnCancelarLin1.Name = "btnCancelarLin1"
        Me.btnCancelarLin1.Size = New System.Drawing.Size(75, 28)
        Me.btnCancelarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCancelarLin1.TabIndex = 1
        Me.btnCancelarLin1.Text = "Cancelar"
        Me.btnCancelarLin1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCancelarLin1.UseSelectable = True
        Me.btnCancelarLin1.UseStyleColors = True
        '
        'gbCxC
        '
        Me.gbCxC.BackColor = System.Drawing.Color.White
        Me.gbCxC.Controls.Add(Me.txtMontoCxC)
        Me.gbCxC.Controls.Add(Me.MetroLabel4)
        Me.gbCxC.Controls.Add(Me.txtFechaCreaCxC)
        Me.gbCxC.Controls.Add(Me.MetroLabel3)
        Me.gbCxC.Controls.Add(Me.txtCtaOrigen)
        Me.gbCxC.Controls.Add(Me.MetroLabel2)
        Me.gbCxC.Controls.Add(Me.txtSaldoCxC)
        Me.gbCxC.Controls.Add(Me.txtNoCxC)
        Me.gbCxC.Controls.Add(Me.MetroLabel1)
        Me.gbCxC.Controls.Add(Me.lblNoCxC)
        Me.gbCxC.Location = New System.Drawing.Point(19, 60)
        Me.gbCxC.Name = "gbCxC"
        Me.gbCxC.Size = New System.Drawing.Size(406, 177)
        Me.gbCxC.TabIndex = 6
        Me.gbCxC.TabStop = False
        '
        'txtMontoCxC
        '
        Me.txtMontoCxC.Enabled = False
        Me.txtMontoCxC.Location = New System.Drawing.Point(117, 115)
        Me.txtMontoCxC.Name = "txtMontoCxC"
        Me.txtMontoCxC.Size = New System.Drawing.Size(281, 20)
        Me.txtMontoCxC.TabIndex = 9
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(5, 115)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Monto"
        '
        'txtFechaCreaCxC
        '
        Me.txtFechaCreaCxC.Enabled = False
        Me.txtFechaCreaCxC.Location = New System.Drawing.Point(117, 91)
        Me.txtFechaCreaCxC.Name = "txtFechaCreaCxC"
        Me.txtFechaCreaCxC.Size = New System.Drawing.Size(281, 20)
        Me.txtFechaCreaCxC.TabIndex = 7
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(5, 91)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Fecha Creación"
        '
        'txtCtaOrigen
        '
        Me.txtCtaOrigen.Enabled = False
        Me.txtCtaOrigen.Location = New System.Drawing.Point(117, 67)
        Me.txtCtaOrigen.Name = "txtCtaOrigen"
        Me.txtCtaOrigen.Size = New System.Drawing.Size(281, 20)
        Me.txtCtaOrigen.TabIndex = 5
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(5, 67)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Cta. Origen:"
        '
        'txtSaldoCxC
        '
        Me.txtSaldoCxC.Enabled = False
        Me.txtSaldoCxC.Location = New System.Drawing.Point(117, 42)
        Me.txtSaldoCxC.Name = "txtSaldoCxC"
        Me.txtSaldoCxC.Size = New System.Drawing.Size(281, 20)
        Me.txtSaldoCxC.TabIndex = 3
        '
        'txtNoCxC
        '
        Me.txtNoCxC.Location = New System.Drawing.Point(117, 18)
        Me.txtNoCxC.Name = "txtNoCxC"
        Me.txtNoCxC.Size = New System.Drawing.Size(281, 20)
        Me.txtNoCxC.TabIndex = 1
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(5, 40)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Saldo:"
        '
        'lblNoCxC
        '
        Me.lblNoCxC.AutoSize = True
        Me.lblNoCxC.Location = New System.Drawing.Point(5, 18)
        Me.lblNoCxC.Name = "lblNoCxC"
        Me.lblNoCxC.Size = New System.Drawing.Size(126, 19)
        Me.lblNoCxC.TabIndex = 0
        Me.lblNoCxC.Text = "No. Cta por cobrar:"
        '
        'txtNoLibreta
        '
        Me.txtNoLibreta.BackColor = System.Drawing.Color.White
        Me.txtNoLibreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoLibreta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoLibreta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoLibreta.Location = New System.Drawing.Point(167, 240)
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.Size = New System.Drawing.Size(49, 21)
        Me.txtNoLibreta.TabIndex = 12
        Me.txtNoLibreta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNoLibreta.Visible = False
        '
        'frmMsDetCaFactura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(954, 580)
        Me.Controls.Add(Me.txtNoLibreta)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblInactiva)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCodItem)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.gbDPF)
        Me.Controls.Add(Me.gbCxC)
        Me.Controls.Add(Me.btnCancelarLin1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.btnAceptarLin1)
        Me.Controls.Add(Me.gbCheque)
        Me.Controls.Add(Me.gbAhorros)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gbDocxCobrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbPrestamo)
        Me.Controls.Add(Me.gbOtros)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(795, 481)
        Me.Name = "frmMsDetCaFactura"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Movimiento"
        Me.gbDPF.ResumeLayout(False)
        Me.gbDPF.PerformLayout()
        CType(Me.c1nDPFSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAhorros.ResumeLayout(False)
        Me.gbAhorros.PerformLayout()
        CType(Me.txtSaldoCtaAhorro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCheque.ResumeLayout(False)
        Me.gbCheque.PerformLayout()
        Me.gbDocxCobrar.ResumeLayout(False)
        Me.gbDocxCobrar.PerformLayout()
        CType(Me.c1nSaldoCtasOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoCxC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nNoCuotasCxC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSaldoCxC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPrestamo.ResumeLayout(False)
        Me.gbPrestamo.PerformLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCapitalMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbCxC.ResumeLayout(False)
        Me.gbCxC.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"

    'Public Property AccionDetalle() As Caja.clsCAFactura.TipoAccionFacturas
    Public Property AccionDetalle() As sifLib.Caja.clsCAFacturas.TipoAccionFacturas
        Get
            Return vAccionDetalle
        End Get
        'Set(ByVal Value As Caja.clsCAFactura.TipoAccionFacturas)
        Set(ByVal Value As sifLib.Caja.clsCAFacturas.TipoAccionFacturas)
            vAccionDetalle = Value
        End Set
    End Property
    Public Property codItemRubro() As String
        Get
            Return vCodItemRubro
        End Get
        Set(value As String)
            vCodItemRubro = value
        End Set
    End Property

    Public Property NombreAsociado() As String
        Get
            Return vNombAsociado
        End Get
        Set(ByVal value As String)
            vNombAsociado = value
        End Set
    End Property
    Public Property saldoGestion() As Double
        Get
            Return vSaldoGestion
        End Get
        Set(ByVal value As Double)
            vSaldoGestion = value
        End Set
    End Property


    Public Property TipoDoc() As String
        Get
            Return vTipoDoc
        End Get
        Set(ByVal Value As String)
            vTipoDoc = Value
        End Set
    End Property

    Public Property TipoMov() As String
        Get
            Return vTipoMov
        End Get
        Set(ByVal Value As String)
            vTipoMov = Value
        End Set
    End Property

    Public Property Rubro() As String
        Get
            Return vRubro
        End Get
        Set(ByVal Value As String)
            vRubro = Value
        End Set
    End Property

    Public Property PagoLibreta() As String
        Get
            Return vPagoLibreta
        End Get
        Set(ByVal Value As String)
            vPagoLibreta = Value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return vFecha
        End Get
        Set(ByVal Value As Date)
            vFecha = Value
        End Set
    End Property

    Public Property frm() As frmCAFactura
        Get
            Return ofrm
        End Get
        Set(ByVal Value As frmCAFactura)
            ofrm = Value
        End Set
    End Property

    'Public Property Tipo() As Caja.clsCAFactura.TipoMovimiento
    Public Property Tipo() As sifLib.Caja.clsCAFacturas.TipoMovimiento
        Get
            Return vTipo
        End Get
        'Set(ByVal Value As Caja.clsCAFactura.TipoMovimiento)
        Set(ByVal Value As sifLib.Caja.clsCAFacturas.TipoMovimiento)
            vTipo = Value
        End Set
    End Property

    Public Property Dui() As String
        Get
            Return vDui
        End Get
        Set(ByVal Value As String)
            vDui = Value
        End Set
    End Property

    Public Property ValDiv() As Double
        Get
            Return vValDiv
        End Get
        Set(ByVal Value As Double)
            vValDiv = Value
        End Set
    End Property
    Public Property FormaPago() As Integer
        Get
            Return vFormaPago
        End Get
        Set(ByVal value As Integer)
            vFormaPago = value
        End Set
    End Property
#End Region
#Region "Funciones"
    Protected Function GenerarComprobanteRetiro(ByVal Asociado As String, ByVal Dui As String, ByVal Nocuenta As String, ByVal TipoCuenta As String,
                                             ByVal MontoLetras As String, ByVal FormaRetiro As Boolean, ByVal Paguese As String,
                                             ByVal Usuario As String, ByVal NoCaja As Integer, ByVal Sucursal As String, ByVal TipoAhorro As String, ByVal Monto As Double) As DataSet
        Dim RptRecibo As New rptReciboRetAboAhorros
        Dim Dts As New DataSet("RetiroAhorros")
        Dim Dt As DataTable = Dts.Tables.Add("Comprobante")
        Dim Dr As DataRow
        With Dt
            .Columns.Add("Asociado", Type.GetType("System.String"))
            .Columns.Add("DUI", Type.GetType("System.String"))
            .Columns.Add("NoCuenta", Type.GetType("System.String"))
            .Columns.Add("TipoCuenta", Type.GetType("System.String"))
            .Columns.Add("MontoLetras", Type.GetType("System.String"))
            .Columns.Add("FormaRetiro", Type.GetType("System.Boolean"))
            .Columns.Add("Paguese", Type.GetType("System.String"))
            .Columns.Add("Usuario", Type.GetType("System.String"))
            .Columns.Add("NoCaja", Type.GetType("System.Int32"))
            .Columns.Add("Sucursal", Type.GetType("System.String"))
            .Columns.Add("Monto", Type.GetType("System.Double"))
        End With
        Dr = Dt.NewRow()
        Dr("Asociado") = Asociado.ToUpper
        Dr("DUI") = Dui
        Dr("NoCuenta") = Nocuenta
        Dr("TipoCuenta") = TipoAhorro.ToUpper
        Dr("MontoLetras") = MontoLetras.ToUpper
        Dr("FormaRetiro") = FormaRetiro
        Dr("Paguese") = Paguese.ToUpper
        Dr("Usuario") = Usuario.ToUpper
        Dr("NoCaja") = NoCaja
        Dr("Sucursal") = Sucursal.ToUpper
        Dr("Monto") = Monto
        Dt.Rows.Add(Dr)
        Return Dts
    End Function
#End Region

#Region "Cuentas por cobrar"
    Protected Sub MostrarCtasPorCobrar()
        Dim dts As New DataSet
        dts = contabilidad.consultarCuentaPorCobrar(Dui, 5, Now, Now, "", 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Dim frm As New frmAGenerico
                frm.Text = "Buscar Cuenta"
                frm.Datos = dts
                frm.ColSeleccion = 0

                frm.RefrescarGrid()
                frm.ShowDialog()
                If frm.Resultado <> "" Then
                    txtNoCxC.Text = frm.Resultado
                    txtSaldoCxC.Text = Math.Round(CDbl(frm.Resultado6), 2)
                    txtFechaCreaCxC.Text = frm.Resultado2
                    txtMontoCxC.Text = Math.Round(CDbl(frm.Resultado5), 2)
                    txtCtaOrigen.Text = frm.Resultado7
                End If
            End If
        End If
    End Sub
    Private Sub txtNoCxC_DoubleClick(sender As Object, e As EventArgs) Handles txtNoCxC.DoubleClick
        MostrarCtasPorCobrar()
    End Sub
#End Region

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String, dsTmp As New DataSet, drTmp As DataRow
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, oCaja As New wrCaja.wsLibCaja, oCred As New wrCredito.wsLibCred
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.ConsultarPRPrestamosTipoCredito("a.CodPrestamo,a.CodAnteriorPrestamo,a.CodTipoCredito,b.Descripcion as Tipo_Credito,a.Monto,a.Saldo_Capital as Saldo,a.FechaOtorgamiento as Fecha_Apertura,a.FechaVencimiento", "a.Dui='" & vDui & "' and a.Baja='0' and a.Estado='A' and a.Saldo_Capital>0", "a.FechaOtorgamiento", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                ofrm.Prestamo = ds
                dr = ds.Tables("Prestamo").Rows(0)
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))

                dsTmp = oCred.ConsultarGestoresxCredito("*", "pr.CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and pr.Estado='A'", "*", sUsuario, sPassword, sSucursal)
                If dsTmp.Tables(0).Rows.Count > 0 Then
                    drTmp = dsTmp.Tables(0).Rows(0)
                    Me.txtDespacho.Text = IIf(IsDBNull(drTmp("Nombre")), 0, drTmp("Nombre"))
                End If

                vFechaOtorgamiento = IIf(IsDBNull(dr("FechaOtorgamiento")), Now, dr("FechaOtorgamiento"))
                ofrm.pNoCuenta = Me.txtCodPrestamo.Text.Trim
                ofrm.pCodTipoAhorro = ""
                ofrm.pNoCuentaAnterior = IIf(IsDBNull(dr("CodAnteriorPrestamo")), 0, dr("CodAnteriorPrestamo"))
                ofrm.pMensajeCajas = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                Me.txtMensaje.Text = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                Me.txtCodTipoCredito.Text = IIf(IsDBNull(dr("CodTipoCredito")), "", dr("CodTipoCredito"))
                'Verificar si es caso especial para filtrar item facturable que aplica:
                If IIf(IsDBNull(dr("CasoEspecial")), "0", dr("CasoEspecial")) = "1" Then
                    pCE = "1"
                    pItemCE = IIf(IsDBNull(dr("CodItem")), "", dr("CodItem"))
                Else
                    pCE = "0"
                    pItemCE = ""
                End If
                Me.txtMonto.Value = oCaja.Redondear(IIf(IsDBNull(dr("Monto")), 0, dr("Monto")), 2)
                If Not IsDBNull(dr("FechaPrimeraCuota")) Then
                    Me.txtFecha1aCuota.Text = CDate(dr("FechaPrimeraCuota")).ToShortDateString
                End If
                Me.txtCuota.Value = oCaja.Redondear(IIf(IsDBNull(dr("CuotaTotal")), 0, dr("CuotaTotal")), 2)
                Me.txtSaldo.Value = oCaja.Redondear(IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital")), 2)
                If IIf(IsDBNull(dr("DiaGracia")), "N", dr("DiaGracia")) = "S" Then
                    Me.txtIntMora.Value = oCaja.Redondear(IIf(IsDBNull(dr("Saldo_IntMoraGracia")), 0, dr("Saldo_IntMoraGracia")), 2)
                    Me.txtCapitalMora.Value = oCaja.Redondear(IIf(IsDBNull(dr("Saldo_CapMoraGracia")), 0, dr("Saldo_CapMoraGracia")), 2)
                Else
                    Me.txtIntMora.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDia_InteresMora")), 0, dr("SaldoDia_InteresMora")), 2)
                    Me.txtCapitalMora.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDia_CapitalMora")), 0, dr("SaldoDia_CapitalMora")), 2)
                End If
                'Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            'Me.gbItem.Enabled = False
            Me.txtCodPrestamo.Text = ""
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPrestamo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodPrestamo.Validating
        CargaDatosPrestamo()
        Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, dr As DataRow

        If pCE = "1" Then
            ds = oCaja.ObtenerListaItems("*", "CodItem='" & pItemCE.Trim & "' and IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "'", sUsuario, sPassword, sSucursal)
        Else
            ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and codItem = '" & codItemRubro & "'  /* and IdApp=3 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "' */ ", sUsuario, sPassword, sSucursal)
        End If
        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows.Count > 1 Then
                dr = ds.Tables(0).Rows(1)
                Me.txtCodItem.Text = dr("CodItem")
            Else
                dr = ds.Tables(0).Rows(0)
                Me.txtCodItem.Text = dr("CodItem")
            End If
        End If
        txtCodItem_Validating(sender, e)
        Me.txtPago.Focus()
    End Sub

    Private Sub txtNoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.DoubleClick

        Dim frm As New frmAGenerico, Fila As DataRowCollection, sTexto As String, vCodTipoAhorro As String, pCodPlanAhorro As String
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow, oCaja As New wrCaja.wsLibCaja

        Try

            oAh = New wrAhorro.wsLibAhorro
            'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Ahorro Then
            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                ds = oAh.ConsultarCuentaAhorroTipoAhorro("a.CodTipoAhorro,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.Estado,a.NoCuentaAnterior,a.FechaApertura,a.Cuota,a.SaldoDisponible_CuentaAhorro as Saldo__", "Left(a.CodTipoAhorro,1)<>'1' and Left(a.CodTipoAhorro,1)<>'6' and a.Dui='" & vDui & "' and a.Estado<>'C' and a.Estado<>'B'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                ds = oAh.ConsultarCuentaAhorroTipoAhorro("a.CodTipoAhorro,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.Estado,a.NoCuentaAnterior,a.FechaApertura,a.Cuota,a.SaldoDisponible_CuentaAhorro as Saldo__", "Left(a.CodTipoAhorro,1)='1' and a.Dui='" & vDui & "' and a.Estado<>'C' and a.Estado<>'B'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
            End If
            frm.Text = "Buscar Cuenta"
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.C1fgrdResultado.Cols.Item(6).Format = "##0.00"
            frm.C1fgrdResultado.Cols.Item(7).Format = "##0.00"
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then

            ElseIf frm.Resultado.Trim <> "" Then

                sTexto = frm.Resultado3.Trim
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaApertura,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,NoLibreta,Estado,Pignorado,Observacion,estado", "NoCuenta='" & sTexto.Trim & "' and Estado<>'C' and Estado<>'B'", "NoCuenta", sUsuario, sPassword, sSucursal)
                ofrm.Prestamo = ds
                dr = ds.Tables("AhCuentasAhorro").Rows(0)
                If dr("estado") = "I" Then
                    Me.lblInactiva.Visible = True
                    Me.txtCodItem.Enabled = False
                    ' Me.txtPago.Enabled = False
                End If
                Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
                ofrm.pNoCuenta = Me.txtNoCuenta.Text.Trim
                vCodTipoAhorro = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
                Me.txtCodTipoAhorro.Text = vCodTipoAhorro
                ofrm.pCodTipoAhorro = vCodTipoAhorro
                Me.txtSaldoCtaAhorro.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDisponible_CuentaAhorro")), 0, dr("SaldoDisponible_CuentaAhorro")), 2)
                Me.txtSaldoPendiente.Text = 0
                Me.txtCuotasNoPagadas.Text = 0
                Me.txtNoLibreta.Text = IIf(IsDBNull(dr("NoLibreta")), "", dr("NoLibreta"))
                ofrm.pNoLibreta = Me.txtNoLibreta.Text.Trim
                ofrm.pMensajeCajas = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
                Me.txtMensaje.Text = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
                pFechaApertura = IIf(IsDBNull(dr("FechaApertura")), Now, dr("FechaApertura"))
                Me.c1nCuota.Value = 0
                If Mid(vCodTipoAhorro, 1, 1) = "4" Then 'Ahorro Programado
                    Me.c1nCuota.Value = oCaja.Redondear(IIf(IsDBNull(dr("Cuota")), 0, dr("Cuota")), 2)
                    Fila = oAh.ConsultarPlanAhorro("CodPlanAhorro", "CodTipoAhorro='" & vCodTipoAhorro & "' and NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", "CodPlanAhorro", sUsuario, sPassword, sSucursal).Tables("AhPlanAhorro").Rows()
                    If Fila.Count > 0 Then
                        If Not (Fila.Item(0)(0) Is DBNull.Value) Then
                            pCodPlanAhorro = CStr(Fila.Item(0)("CodPlanAhorro"))
                        End If
                        Fila = oAh.ConsultarDet_PlanAhorro("CuotasNoPagadas", "Cancelada='N' and CodPlanAhorro='" & pCodPlanAhorro & "' and FechaCuota<='" & vFecha.ToShortDateString & "'", "CodPlanAhorro", sUsuario, sPassword, sSucursal).Tables("AhDet_PlanAhorro").Rows()
                        If Fila.Count > 0 Then
                            If Not (Fila.Item(0)(0) Is DBNull.Value) Then
                                Me.txtCuotasNoPagadas.Text = CStr(Fila.Item(0)("CuotasNoCanceladas"))
                                Me.txtSaldoPendiente.Text = Val(Me.txtCuotasNoPagadas.Text) * Val(Me.c1nCuota.Value)
                                Me.lblDiaCuota.Text = CStr(Fila.Item(0)("DiaPago")) & " de cada mes"
                            End If
                        End If
                    End If
                End If
                '  Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            'Me.gbItem.Enabled = False
            Me.txtNoCuenta.Text = ""
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoCuenta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNoCuenta.Validating
        CargaDatosAhorro()
        Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, dr As DataRow
        'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
        If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
            ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and codItem = '" & codItemRubro & "' /* and IdApp=9 and Tipo_Item='P' */ ", sUsuario, sPassword, sSucursal)
            'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Ahorro Then
        ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
            If vTipoDoc = "R" Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "'  and codItem = '" & codItemRubro & "' /* and IdApp=8 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "' */   ", sUsuario, sPassword, sSucursal)
            ElseIf vTipoDoc = "D" Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and codItem = '" & codItemRubro & "' /* and IdApp=8 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "' and idCuentaA = '" & Me.IdCuenta & "' */  ", sUsuario, sPassword, sSucursal)
            Else
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and codItem = '" & codItemRubro & "' /* and IdApp=8 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "'  */  ", sUsuario, sPassword, sSucursal)
            End If
        End If
        If lblInactiva.Visible = False Then
            If ds.Tables(0).Rows.Count > 0 Then
                If CDate(pFechaApertura.ToShortDateString) = CDate(vFecha.ToShortDateString) Then
                    If ds.Tables(0).Rows.Count > 1 Then
                        dr = ds.Tables(0).Rows(1)
                        Me.txtCodItem.Text = dr("CodItem")
                    End If
                Else
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCodItem.Text = dr("CodItem")
                End If


                Me.txtPago.Focus()
                txtCodItem_Validating(sender, e)

            End If
        End If

    End Sub

    'Private Sub chkLibreta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.chkLibreta.Checked = True Then
    '        vPagoLibreta = "S"
    '        Me.txtNoLibreta.Enabled = True
    '    Else
    '        vPagoLibreta = "N"
    '        Me.txtNoLibreta.Enabled = False
    '    End If
    'End Sub

    Private Sub txtDPFNoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDPFNoCuenta.DoubleClick

        Dim frm As New frmAGenerico, Fila As DataRowCollection
        Dim sTexto As String, vCodTipoAhorro As String, pCodPlanAhorro As String
        frm.Text = "Buscar Cuenta"
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow, oCaja As New wrCaja.wsLibCaja
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarCuentaAhorroTipoAhorro("a.CodTipoAhorro,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.NoCuentaAnterior,a.FechaApertura,a.Cuota,a.SaldoDisponible_CuentaAhorro as Saldo__,IdCertificadoDPF as No_Certificado,Monto", "Left(a.CodTipoAhorro,1)='6' and a.Dui='" & vDui & "' and a.Estado='D'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.C1fgrdResultado.Cols.Item(6).Format = "##0.00"
            frm.C1fgrdResultado.Cols.Item(7).Format = "##0.00"
            frm.C1fgrdResultado.Cols.Item(8).Format = "##0.00"
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then

            ElseIf frm.Resultado.Trim <> "" Then

                sTexto = frm.Resultado3.Trim
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,IdCertificadoDPF,MontoApertura as Monto,Estado,Pignorado,Observacion", "Left(CodTipoAhorro,1)='6' and NoCuenta='" & sTexto.Trim & "' and Estado='D'", "NoCuenta", sUsuario, sPassword, sSucursal)
                ofrm.Prestamo = ds
                dr = ds.Tables("AhCuentasAhorro").Rows(0)
                Me.txtDPFNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
                ofrm.pNoCuenta = Me.txtDPFNoCuenta.Text.Trim
                vCodTipoAhorro = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
                ofrm.pCodTipoAhorro = vCodTipoAhorro
                Me.txtDPFCodTipoAhorro.Text = vCodTipoAhorro
                ofrm.pMensajeCajas = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
                Me.txtMensaje.Text = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
                Me.txtDPFNoCert.Text = IIf(IsDBNull(dr("IdCertificadoDPF")), "", dr("IdCertificadoDPF"))
                Me.txtDPFMonto.Text = oCaja.Redondear(IIf(IsDBNull(dr("Monto")), 0, dr("Monto")), 2)
                Me.c1nDPFSaldo.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDisponible_CuentaAhorro")), 0, dr("SaldoDisponible_CuentaAhorro")), 2)
                ' Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            'Me.gbItem.Enabled = False
            Me.txtDPFNoCuenta.Text = ""
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtDPFNoCuenta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDPFNoCuenta.Validating
        CargaDatosDPF()
        Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, dr As DataRow
        ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count > 0 Then
            If CDate(pFechaApertura.ToShortDateString) = CDate(vFecha.ToShortDateString) Then
                If ds.Tables(0).Rows.Count > 1 Then
                    dr = ds.Tables(0).Rows(1)
                    Me.txtCodItem.Text = dr("CodItem")
                End If
            Else
                dr = ds.Tables(0).Rows(0)
                Me.txtCodItem.Text = dr("CodItem")
            End If
            txtCodItem_Validating(sender, e)
            Me.txtPago.Focus()
        End If
    End Sub

    Private Sub txtCodPrestamoCxC_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamoCxC.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String, drTmp As DataRow, dsTmp As New DataSet, oCred As New wrCredito.wsLibCred
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, oCaja As New wrCaja.wsLibCaja
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.ConsultarCBPrestamosTipoCredito("a.CodPrestamo,a.CodAnteriorPrestamo,a.CodTipoCredito,b.Descripcion as Tipo_Credito,a.Monto,a.Saldo_Capital as Saldo,a.FechaVencimiento", "a.Dui='" & vDui & "' and Baja='1' and a.Estado<>'C'", "a.FechaOtorgamiento", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oPrest.CargaDatosPrestamoCB(sTexto, sUsuario, sPassword, sSucursal)
                ofrm.Prestamo = ds
                dr = ds.Tables("Prestamo").Rows(0)
                Me.txtCodPrestamoCxC.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))

                dsTmp = oCred.ConsultarGestoresxCredito("*", "pr.CodPrestamo='" & Me.txtCodPrestamoCxC.Text.Trim & "' and pr.Estado='A'", "*", sUsuario, sPassword, sSucursal)
                If dsTmp.Tables(0).Rows.Count > 0 Then
                    drTmp = dsTmp.Tables(0).Rows(0)
                    Me.txtDespacho.Text = IIf(IsDBNull(drTmp("Nombre")), 0, drTmp("Nombre"))
                End If

                ofrm.pNoCuenta = Me.txtCodPrestamoCxC.Text.Trim
                ofrm.pCodTipoAhorro = ""
                ofrm.pMensajeCajas = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                Me.txtMensaje.Text = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                Me.txtCodTipoCreditoCxC.Text = IIf(IsDBNull(dr("CodTipoCredito")), "", dr("CodTipoCredito"))
                'Verificar si es caso especial para filtrar item facturable que aplica:
                If IIf(IsDBNull(dr("CasoEspecial")), "0", dr("CasoEspecial")) = "1" Then
                    pCE = "1"
                    pItemCE = IIf(IsDBNull(dr("CodItem")), "", dr("CodItem"))
                Else
                    pCE = "0"
                    pItemCE = ""
                End If
                Me.c1nMontoCxC.Value = oCaja.Redondear(IIf(IsDBNull(dr("Monto")), 0, dr("Monto")), 2)
                If Not IsDBNull(dr("FechaPrimeraCuota")) Then
                    Me.txtFechaCxC.Text = dr("FechaPrimeraCuota")
                End If
                If Not IsDBNull(dr("Tipo")) Then
                    Me.txtEstado.Text = dr("Tipo")
                Else
                    Me.txtEstado.Text = ""
                End If
                Me.c1nNoCuotasCxC.Value = oCaja.Redondear(IIf(IsDBNull(dr("CuotaTotal")), 0, dr("CuotaTotal")), 2)
                Me.c1nSaldoCxC.Value = oCaja.Redondear(IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital")), 2)
                Me.c1nSaldoCtasOrden.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoCuentasOrden")), 0, dr("SaldoCuentasOrden")), 2)
                '    Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            'Me.gbItem.Enabled = False
            Me.txtCodPrestamoCxC.Text = ""
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodItem_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodItem.Validating
        Dim sTexto As String

        Dim oCaja As wrCaja.wsLibCaja, ds As New Data.DataSet("Items"), dr As DataRow
        Try
            oCaja = New wrCaja.wsLibCaja
            sTexto = Me.txtCodItem.Text.Trim
            If sTexto = "" Then
            ElseIf sTexto <> "" Then
                'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
                If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Ahorro Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                    If Me.lblInactiva.Visible = False Then
                        ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "'", sUsuario, sPassword, sSucursal)
                    End If
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=9 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Cobranza Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=10 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.IngresoAsociados Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=1 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.gestionMora Then
                    '    Exit Sub
                Else
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                End If
                dr = ds.Tables("CAItemsFact").Rows(0)
                ofrm.Item = dr
                Me.txtCodItem.Text = Trim(dr("CodItem"))
                Me.txtItem.Text = Trim(dr("Descripcion"))
                ofrm.txtCuenta.Value = Trim(IIf(IsDBNull(dr("IdCuentaC")), "", dr("IdCuentaC")))
                If ofrm.txtCuenta.Text.Trim = "" Then ofrm.txtCuenta.Value = Trim(IIf(IsDBNull(dr("IdCuentaA")), "", dr("IdCuentaA")))
                If Not dr("Valor") Is DBNull.Value Then
                    'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                    If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                    Else
                        Me.txtPago.Value = oCaja.Redondear(dr("Valor"), 2)
                    End If
                Else
                    'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                    If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                    Else
                        Me.txtPago.Value = 0
                    End If
                End If
                vTipoMov = Trim(dr("TipoMovimiento"))
            End If
            ''-- MODIFICACION PARA CANCELACION DE CUENTAS DE AHORRO  PROG01  23/08/2019
            If sTexto = "1019" Then
                Me.txtPago.Value = txtSaldoCtaAhorro.Value
                Me.txtPago.Enabled = False
            Else
                Me.txtPago.Value = 0.00
                Me.txtPago.Enabled = True
            End If
            '--- FIN DE LA MODIFICACION 23/08/2019
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla CAItemsFact - " & "System Error: No Existe el Item digitado --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodItem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodItem.DoubleClick
        Dim oCaja As wrCaja.wsLibCaja, ds As New Data.DataSet("Items"), dr As DataRow
        Dim frm As New frmAGenerico, sTexto As String
        frm.Text = "Buscar Item para Facturar"

        Try
            oCaja = New wrCaja.wsLibCaja
            'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                If pCE = "1" Then
                    ds = oCaja.ObtenerListaItems("*", "CodItem='" & pItemCE.Trim & "' and IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                Else
                    ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                End If
                'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Ahorro Then
                'ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.gestionMora Then
                '    Exit Sub
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "'", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=9 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Cobranza Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=10 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.IngresoAsociados Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "'  and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
            Else
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
            End If
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
                If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Ahorro Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                    ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=9 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Cobranza Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=10 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.IngresoAsociados Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "'  and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                Else
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                End If
                dr = ds.Tables("CAItemsFact").Rows(0)
                ofrm.Item = dr
                Me.txtCodItem.Text = Trim(dr("CodItem"))
                Me.txtItem.Text = Trim(dr("Descripcion"))
                ofrm.txtCuenta.Value = Trim(dr("IdCuentaC"))
                If Not dr("Valor") Is DBNull.Value Then
                    'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                    If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                    Else
                        Me.txtPago.Value = oCaja.Redondear(dr("Valor"), 2)
                    End If
                Else
                    'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                    If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                    Else
                        Me.txtPago.Value = 0
                    End If
                End If
                If ofrm.txtCuenta.Text.Trim = "" Then ofrm.txtCuenta.Value = Trim(dr("IdCuentaA"))
                vTipoMov = Trim(dr("TipoMovimiento"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla CAItemsFact- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtBanco_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBanco.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Bancos"
        Dim oAsoc As wrBancos.wsLibBancos, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrBancos.wsLibBancos
            ds = oAsoc.ObtenerBanco("*", "", "IdBanco", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ObtenerBanco("*", "IdBanco='" & sTexto & "'", "IdBanco", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtBanco.Text = dr("IdBanco")
                Me.lblBanco.Text = dr("Nom_Banco")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Bancos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#Region "Validaciones"
    Protected Function ValidarCamposCheque() As Boolean
        If Me.txtNoCheque.Text.Length > 0 And txtNoCtaBancaria.Text.Length > 0 And txtBanco.Text.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Protected Sub limpiarDetallePago()
        ofrm.Factura.Tables("CADet_Facturas").Rows.Clear()
        ofrm.vTotalFactura = 0
        ofrm.vTotalNoGravado = 0
        ofrm.vTotalGravado = 0
        ofrm.vTotalSIva = 0
        ofrm.vTotalIVA = 0
        ofrm.vPagoCapital = 0
        ofrm.vPagoInteres = 0
        ofrm.vPagoCapitalMora = 0
        ofrm.vPagoInteresMora = 0
        ofrm.vPagoSeguroDeuda = 0
        ofrm.vPagoSeguroDanios = 0
        ofrm.vPagoSeguroVida = 0
        ofrm.vPagoSeguroDesempleo = 0
        ofrm.vPagoAportacion = 0
        ofrm.vPagoAhorro = 0
        ofrm.vPagoComision = 0
        ofrm.vPagoOtros = 0
        ofrm.vCancela = False
        vPago = 0
        vMontoItem = 0

        Me.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.AgregarLinea
    End Sub
#End Region

    Public Sub CargaDatosPrestamo()

        Dim sTexto As String, dsTmp As New DataSet, drTmp As DataRow
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, oCaja As New wrCaja.wsLibCaja, oCred As New wrCredito.wsLibCred
        Try
            oPrest = New wrPrestamo.wsLibPrest
            sTexto = Me.txtCodPrestamo.Text
            If sTexto = "" Then

            ElseIf sTexto <> "" Then
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                ofrm.Prestamo = ds
                dr = ds.Tables(0).Rows(0)
                If IIf(IsDBNull(dr("Baja")), 0, dr("Baja")) = "1" Then
                    ' Me.gbItem.Enabled = False
                    Me.txtCodPrestamo.Text = ""
                    Exit Sub
                End If
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))

                dsTmp = oCred.ConsultarGestoresxCredito("*", "pr.CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and pr.Estado='A'", "*", sUsuario, sPassword, sSucursal)
                If dsTmp.Tables(0).Rows.Count > 0 Then
                    drTmp = dsTmp.Tables(0).Rows(0)
                    Me.txtDespacho.Text = IIf(IsDBNull(drTmp("Nombre")), 0, drTmp("Nombre"))
                End If

                vFechaOtorgamiento = IIf(IsDBNull(dr("FechaOtorgamiento")), Now, dr("FechaOtorgamiento"))
                ofrm.pNoCuenta = Me.txtCodPrestamo.Text.Trim
                ofrm.pCodTipoAhorro = ""
                ofrm.pMensajeCajas = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                Me.txtMensaje.Text = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                ofrm.pNoCuentaAnterior = IIf(IsDBNull(dr("CodAnteriorPrestamo")), 0, dr("CodAnteriorPrestamo"))
                Me.txtCodTipoCredito.Text = IIf(IsDBNull(dr("CodTipoCredito")), "", dr("CodTipoCredito"))
                'Verificar si es caso especial para filtrar item facturable que aplica:
                If IIf(IsDBNull(dr("CasoEspecial")), "0", dr("CasoEspecial")) = "1" Then
                    pCE = "1"
                    pItemCE = IIf(IsDBNull(dr("CodItem")), "", dr("CodItem"))
                Else
                    pCE = "0"
                    pItemCE = ""
                End If
                Me.txtMonto.Value = oCaja.Redondear(IIf(IsDBNull(dr("Monto")), 0, dr("Monto")), 2)
                If Not IsDBNull(dr("FechaPrimeraCuota")) Then
                    Me.txtFecha1aCuota.Text = CDate(dr("FechaPrimeraCuota")).ToShortDateString
                End If
                Me.txtCuota.Value = oCaja.Redondear(IIf(IsDBNull(dr("CuotaTotal")), 0, dr("CuotaTotal")), 2)
                Me.txtSaldo.Value = oCaja.Redondear(IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital")), 2)

                If IIf(IsDBNull(dr("DiaGracia")), "N", dr("DiaGracia")) = "S" Then
                    Me.txtIntMora.Value = oCaja.Redondear(IIf(IsDBNull(dr("Saldo_IntMoraGracia")), 0, dr("Saldo_IntMoraGracia")), 2)
                    Me.txtCapitalMora.Value = oCaja.Redondear(IIf(IsDBNull(dr("Saldo_CapMoraGracia")), 0, dr("Saldo_CapMoraGracia")), 2)
                Else
                    Me.txtIntMora.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDia_InteresMora")), 0, dr("SaldoDia_InteresMora")), 2)
                    Me.txtCapitalMora.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDia_CapitalMora")), 0, dr("SaldoDia_CapitalMora")), 2)
                End If
                ' Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            'Me.gbItem.Enabled = False
            Me.txtCodPrestamo.Text = ""
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: NO EXISTE EL CODIGO DE PRESTAMO --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Try
            Dim Dts As New DataSet
            Dim TipoCuenta As String
            Dim MontoLetras As String
            Dim Sucursal As String
            Dim dtsTipoAhorro As New DataSet
            If vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                Dim ds As New DataSet
                ds = ahorros.ConsultarCuentaAhorro("CodTipoAhorro", "NoCuenta='" & Me.txtDPFNoCuenta.Text.Trim & "' and Dui='" & vDui & "' and Left(CodTipoAhorro,1)='" & sifLib.Ahorro.clsAhorros.tiposAhorro.dpf & "' and Estado='D'", "NoCuenta", sUsuario, sPassword, sSucursal)
                If ds.Tables.Count > 0 Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        vCodTipoAhorro = ds.Tables(0).Rows(0).Item(0).ToString.Trim
                        dtsTipoAhorro = ahorros.ConsultarTipoAhorro("codtipoahorro,descripcion", "codtipoahorro  = '" & vCodTipoAhorro.Trim & "'", "", sUsuario, sPassword, sSucursal)
                        If dtsTipoAhorro.Tables.Count > 0 Then
                            If dtsTipoAhorro.Tables(0).Rows.Count > 0 Then
                                TipoCuenta = dtsTipoAhorro.Tables(0).Rows(0).Item("Descripcion").ToString.Trim
                            End If
                        End If
                    End If
                End If
            Else
                dtsTipoAhorro = ahorros.ConsultarTipoAhorro("codtipoahorro,descripcion", "codtipoahorro  = '" & Me.txtCodTipoAhorro.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
                If dtsTipoAhorro.Tables.Count > 0 Then
                    If dtsTipoAhorro.Tables(0).Rows.Count > 0 Then
                        TipoCuenta = dtsTipoAhorro.Tables(0).Rows(0).Item("Descripcion").ToString.Trim
                    End If
                End If
            End If

            Sucursal = asociados.ConsultarSucursales("Nom_Sucursal", "CodSucursal = '" & sSucursal & "'", "", sUsuario, sPassword, sSucursal).Tables(0).Rows(0).Item("Nom_Sucursal")
            MontoLetras = sifLib.Lector.ProcesarCantidadEnteros(Me.txtPago.Value.ToString.Trim) & " D" & ChrW(211) & "LARES CON " &
            sifLib.Lector.ProcesarCantidadDecimales(Me.txtPago.Value.ToString.Trim) & " / 100 CENTAVOS"


            Dim rpt As New rptReciboRetAboAhorros
            Dim encabezado As TextObject
            Dim encabezadoRetiro As TextObject
            Dim lblEfectivo As TextObject
            Dim chkEfectivo As TextObject
            Dim lblCheque As TextObject
            Dim chkCheque As TextObject
            Dim txtpaguese As TextObject
            Dim nombreyFirma As TextObject
            Dim monto As TextObject
            'Dim montoNum As TextObject
            Dim lblMonto As TextObject
            Dim lblNoDoc As TextObject
            Dim lblNombre As TextObject
            Dim txtNoDocTitular As TextObject
            Dim txtNombreTitular As TextObject
            Dim txtDui As TextObject
            Dim lblBancotpt As TextObject
            Dim txtNoCuenta As TextObject
            Dim txtCodCajero As TextObject

            txtDui = rpt.PageHeaderSection1.ReportObjects("txtDui")
            txtNoCuenta = rpt.PageHeaderSection1.ReportObjects("txtNoCuenta")
            txtDui.Text = vDui.Trim
            txtNoCuenta.Text = IIf(vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF, Me.txtDPFNoCuenta.Text.Trim, Me.txtNoCuenta.Text.Trim)
            If vTipoDoc.Equals("D") Then
                Dts = GenerarComprobanteRetiro(vNombAsociado.ToUpper, vDui.Trim, IIf(vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF, Me.txtDPFNoCuenta.Text.Trim, Me.txtNoCuenta.Text.Trim),
                                          TipoCuenta.ToUpper, MontoLetras, IIf(vFormaPago = 0, False, True), "", sUsuario,
                                          pNocaja, Sucursal, TipoCuenta, Me.txtPago.Value)
                encabezado = rpt.PageHeaderSection1.ReportObjects("encabezado")
                encabezadoRetiro = rpt.PageHeaderSection1.ReportObjects("encabezadoRetiro")
                lblEfectivo = rpt.PageHeaderSection1.ReportObjects("lblEfectivo")
                chkEfectivo = rpt.PageHeaderSection1.ReportObjects("chkEfectivo")
                lblCheque = rpt.PageHeaderSection1.ReportObjects("lblCheque")
                chkCheque = rpt.PageHeaderSection1.ReportObjects("chkCheque")
                txtpaguese = rpt.PageHeaderSection1.ReportObjects("txtpaguese")
                lblMonto = rpt.PageHeaderSection1.ReportObjects("lblMonto")
                monto = rpt.PageHeaderSection1.ReportObjects("monto")
                txtCodCajero = rpt.PageHeaderSection1.ReportObjects("txtCodCajero")
                lblBancotpt = rpt.PageHeaderSection1.ReportObjects("lblBanco")
                lblNoDoc = rpt.PageHeaderSection1.ReportObjects("lblNoDoc")
                lblNombre = rpt.PageHeaderSection1.ReportObjects("lblNombre")
                txtNoDocTitular = rpt.PageHeaderSection1.ReportObjects("txtNoDocTitular")
                txtNombreTitular = rpt.PageHeaderSection1.ReportObjects("txtNombreTitular")
                txtCodCajero.Text = pCodCajero
                encabezado.Text = "COMPROBANTE DE DEPOSITO EN CUENTA"
                encabezadoRetiro.Text = "FORMA DEL DEPOSITO"
                lblEfectivo.Text = "EFECTIVO"
                chkEfectivo.Text = IIf(vFormaPago = 0, "X", "")
                lblCheque.Text = "CHEQUE"
                chkCheque.Text = IIf(vFormaPago <> 0, "X", "")
                txtpaguese.Text = ""
                lblMonto.Text = "VALOR DEPOSITADO:"
                lblBancotpt.Text = IIf(vFormaPago <> 0, Me.lblBanco.Text.ToUpper + ":    No.CHEQUE:" + Me.txtNoCheque.Text.Trim, "")
                monto.Text = MontoLetras.ToUpper & "; $" & txtPago.Value.ToString
                ' montoNum.Text = txtPago.Value
                If Me.rbTerceraPersona.Checked = True Then
                    If Me.txtNombreTercero.Text.Length > 0 And Me.txtNoDocTerceros.Text.Length Then
                        lblNombre.Text = "NOMBRE DE DEPOSITANTE:"
                        lblNoDoc.Text = "NÚMERO DE DOCUMENTO:"
                        txtNombreTitular.Text = Me.txtNombreTercero.Text.Trim.ToUpper
                        txtNoDocTitular.Text = Me.txtNoDocTerceros.Text
                    Else
                        lblNoDoc.Text = ""
                        lblNombre.Text = ""
                        txtNoDocTitular.Text = ""
                        txtNombreTitular.Text = ""
                    End If
                ElseIf Me.rbTitular.Checked = True Then
                    If Me.txtNombreTercero.Text.Length > 0 And Me.txtNoDocTerceros.Text.Length Then
                        lblNombre.Text = "NOMBRE TITULAR"
                        lblNoDoc.Text = "NÚMERO DE DOCUMENTO"
                        txtNombreTitular.Text = Me.txtNombreTercero.Text.Trim.ToUpper
                        txtNoDocTitular.Text = Me.txtNoDocTerceros.Text
                    Else
                        lblNoDoc.Text = ""
                        lblNombre.Text = ""
                        txtNoDocTitular.Text = ""
                        txtNombreTitular.Text = ""
                    End If
                Else
                    lblNoDoc.Text = ""
                    lblNombre.Text = ""
                    txtNoDocTitular.Text = ""
                    txtNombreTitular.Text = ""
                End If
            ElseIf vTipoDoc.Equals("R") Then

                lblMonto = rpt.PageHeaderSection1.ReportObjects("lblMonto")
                monto = rpt.PageHeaderSection1.ReportObjects("monto")
                encabezadoRetiro = rpt.PageHeaderSection1.ReportObjects("encabezadoRetiro")
                txtCodCajero = rpt.PageHeaderSection1.ReportObjects("txtCodCajero")
                monto.Text = MontoLetras.ToUpper & "; $" & txtPago.Value.ToString
                txtCodCajero.Text = pCodCajero
                lblMonto.Text = "VALOR RETIRADO:"
                encabezadoRetiro.Text = "FORMA DEL RETIRO"
                Dts = GenerarComprobanteRetiro(vNombAsociado.ToUpper, vDui.Trim, IIf(vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF, Me.txtDPFNoCuenta.Text.Trim, Me.txtNoCuenta.Text.Trim),
                                          TipoCuenta.ToUpper, MontoLetras, IIf(vFormaPago = 0, False, True), "", sUsuario,
                                          pNocaja, Sucursal, TipoCuenta, Me.txtPago.Value)
                lblNoDoc = rpt.PageHeaderSection1.ReportObjects("lblNoDoc")
                lblNombre = rpt.PageHeaderSection1.ReportObjects("lblNombre")
                txtNoDocTitular = rpt.PageHeaderSection1.ReportObjects("txtNoDocTitular")
                txtNombreTitular = rpt.PageHeaderSection1.ReportObjects("txtNombreTitular")
                txtpaguese = rpt.PageHeaderSection1.ReportObjects("txtpaguese")
                txtpaguese.Text = ""
                If Me.rbTitular.Checked = True Then
                    If Me.txtNombreTercero.Text.Length > 0 And Me.txtNoDocTerceros.Text.Length Then
                        lblNombre.Text = "NOMBRE TITULAR"
                        lblNoDoc.Text = "NÚMERO DE DOCUMENTO"
                        txtNombreTitular.Text = Me.txtNombreTercero.Text.Trim.ToUpper
                        txtNoDocTitular.Text = Me.txtNoDocTerceros.Text
                    Else
                        lblNombre.Text = ""
                        lblNoDoc.Text = ""
                        txtNombreTitular.Text = ""
                        txtNoDocTitular.Text = ""
                    End If
                ElseIf Me.rbTerceraPersona.Checked = True Then
                    If Me.txtNombreTercero.Text.Length > 0 And Me.txtNoDocTerceros.Text.Length Then
                        lblNoDoc.Text = "DUI:"
                        lblNombre.Text = "NOMBRE:"
                        txtNombreTitular.Text = Me.txtNombreTercero.Text.Trim.ToUpper
                        txtNoDocTitular.Text = Me.txtNoDocTerceros.Text
                    Else
                        lblNoDoc.Text = ""
                        lblNombre.Text = ""
                        txtNoDocTitular.Text = ""
                        txtNombreTitular.Text = ""
                    End If
                End If
            ElseIf vTipoDoc.Equals("F") Then

            End If

            rpt.SetDataSource(Dts.Tables(0))
            Dim ofrm As New frmVisor(Dts, 219, 0)
            With ofrm
                .crView.ReportSource = rpt
                .ShowDialog()

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            '  MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptarLin1_Click(sender As Object, e As EventArgs) Handles btnAceptarLin1.Click
        Try

            If Me.txtPago.Value = 0 Then
                MsgBox("Debe digitar un valor para el monto de la transacción.", MsgBoxStyle.Critical, "Módulo Caja")
                Exit Sub
            End If
            '20/03/2014
            'Javier Martinez
            'Validación de campos de cheque no queden incompletos
            If Me.FormaPago = 2 Then
                If ValidarCamposCheque() = False Then
                    MsgBox("Los datos del cheque no pueden quedar vacios, por favor ingresar toda la información.", MsgBoxStyle.Critical, "Módulo Caja")
                    Exit Sub
                End If
            End If
            ' MONTO A ABONAR NO PUEDE SER MAYOR QUE SALDO DE CUENTA POR CORBRAR
            If vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.CuentaporCobrar Then
                If txtSaldoCxC.Text < txtPago.Value Then
                    MetroFramework.MetroMessageBox.Show(Me, "Monto a pagar no puede ser mayor que saldo pendiente.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    txtPago.Focus()
                    Exit Sub
                End If
            End If
            ofrm.txtDui.Enabled = False

            'If Me.AccionDetalle = Caja.clsCAFactura.TipoAccionFacturas.ModificarLinea Then
            If Me.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.ModificarLinea Then
                ofrm.Factura.Tables("CADet_Facturas").Rows.Clear()
                ofrm.vTotalFactura = 0
                ofrm.vTotalNoGravado = 0
                ofrm.vTotalGravado = 0
                ofrm.vTotalSIva = 0
                ofrm.vTotalIVA = 0
                ofrm.vPagoCapital = 0
                ofrm.vPagoInteres = 0
                ofrm.vPagoCapitalMora = 0
                ofrm.vPagoInteresMora = 0
                ofrm.vPagoSeguroDeuda = 0
                ofrm.vPagoSeguroDanios = 0
                ofrm.vPagoSeguroVida = 0
                ofrm.vPagoSeguroDesempleo = 0
                ofrm.vPagoAportacion = 0
                ofrm.vPagoAhorro = 0
                ofrm.vPagoComision = 0
                ofrm.vPagoOtros = 0
                ofrm.vPagoSeguroVehiculo = 0
                ofrm.vCancela = False
                vPago = 0
                vMontoItem = 0
                'Me.AccionDetalle = Caja.clsCAFactura.TipoAccionFacturas.AgregarLinea
                Me.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.AgregarLinea
            End If
            'If Me.AccionDetalle = Caja.clsCAFactura.TipoAccionFacturas.AgregarLinea Then
            If Me.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.AgregarLinea Then
                Dim dr As DataRow, drB As DataRow, drC As DataRow, drPrestamo As DataRow, drAhorro As DataRow
                Dim oCaja As wrCaja.wsLibCaja, ds As New Data.DataSet("Items"), dsAhorro As New DataSet("Parametros")
                Dim oApp As New wrAdmin.wsLibAdmin, oAhorro As New wrAhorro.wsLibAhorro
                Dim x As Integer, bAgrega As Boolean, oAsoc As New wrAsociados.wsLibAsoc, dsPar As New DataSet, pMontoParam As Double, drPar As DataRow

                vPago = Me.txtPago.Value
                ofrm.pObservacion = Me.txtObservacion.Text.Trim
                ofrm.pNoReserva = Me.txtNoReserva.Text.Trim
                ofrm.pNoCheque = Me.txtNoCheque.Text.Trim
                ofrm.pNoCtaBanco = Me.txtNoCtaBancaria.Text.Trim
                ofrm.pBanco = Me.txtBanco.Text.Trim
                ofrm.pMontoPagado = Me.txtPago.Value
                ofrm.pGirador = Me.txtGirador.Text.Trim
                ofrm.pPaguese = Me.txtPaguese.Text.Trim


                'Si el Item a Facturar es un pago a préstamo
                'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
                If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then

                    'If ofrm.Item("IdApp") = 3 And ofrm.Item("Tipo_Item") = "P" Then
                    If Me.txtCodPrestamo.Text.Trim = "" Then
                        MsgBox("DEBE DIGITAR EL CÓDIGO DEL PRÉSTAMO.", MsgBoxStyle.Critical, "Módulo Caja")
                        Exit Sub
                    End If
                    '--------------------------------------------------------------------
                    'Lista de Items Facturables para Préstamos
                    oCaja = New wrCaja.wsLibCaja
                    ds = oCaja.ObtenerListaItems("*", "idApp=3 and Tipo_Item<>'P' and TipoMovimiento='" & ofrm.Item("TipoMovimiento") & "'", sUsuario, sPassword, sSucursal)
                    '--------------------------------------------------------------------
                    'Nueva Linea para Detalle de Factura
                    dr = ofrm.Factura.Tables("CADet_Facturas").NewRow
                    x = ofrm.Factura.Tables("CADet_Facturas").Rows.Count + 1
                    dr("Correlativo") = x
                    dr("TipoMov") = CInt(vTipo)
                    dr("CodItem") = Me.txtCodItem.Text.Trim
                    dr("Descripcion") = Me.txtItem.Text.Trim
                    dr("Cantidad") = 1
                    dr("TipoItem") = "P"
                    dr("Monto_Pago") = Me.txtPago.Value
                    dr("SubTotal_Gravado") = 0
                    dr("SubTotal_Exento") = 0
                    dr("SubTotal_SIva") = 0
                    dr("Total_Iva") = 0
                    dr("Total_Vta") = 0
                    dr("Mes") = Date.Now.Month
                    dr("Annio") = Fecha.Date.Year
                    dr("Observacion") = Me.txtObservacion.Text.Trim
                    dr("CodTipo") = Me.txtCodTipoCredito.Text.Trim
                    dr("NoCuenta") = Me.txtCodPrestamo.Text.Trim
                    dr("NoLibreta") = ""
                    dr("PagoLibreta") = ""
                    ofrm.Factura.Tables("CADet_Facturas").Rows.Add(dr)

                    'Se agrega un item por cada detalle del pago al préstamo
                    drPrestamo = ofrm.Prestamo.Tables(0).Rows(0)
                    'ds.Tables("CAItemsFact").Select("", "Orden")
                    For Each drB In ds.Tables("CAItemsFact").Rows
                        Select Case Convert.ToString(drB("Tipo_Item"))
                            Case Is = "I" 'Interés
                                If oCaja.Redondear(drPrestamo("SaldoDia_Interes"), 2) > 0 And vPago > 0 Then
                                    bAgrega = True
                                    If vPago > oCaja.Redondear(drPrestamo("SaldoDia_Interes"), 2) Then
                                        ofrm.vPagoInteres = oCaja.Redondear(drPrestamo("SaldoDia_Interes"), 2)
                                        vPago = vPago - oCaja.Redondear(drPrestamo("SaldoDia_Interes"), 2)
                                        vMontoItem = ofrm.vPagoInteres
                                    Else
                                        ofrm.vPagoInteres = vPago
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoInteres
                                    End If
                                End If
                            Case Is = "M" 'Interés Moratorio
                                If IIf(IsDBNull(drPrestamo("DiaGracia")), "N", drPrestamo("DiaGracia")) = "S" Then
                                    If oCaja.Redondear(drPrestamo("Saldo_IntMoraGracia"), 2) > 0 And vPago > 0 Then
                                        bAgrega = True
                                        If vPago > oCaja.Redondear(drPrestamo("Saldo_IntMoraGracia"), 2) Then
                                            ofrm.vPagoInteresMora = oCaja.Redondear(drPrestamo("Saldo_IntMoraGracia"), 2)
                                            vPago = vPago - oCaja.Redondear(drPrestamo("Saldo_IntMoraGracia"), 2)
                                            vMontoItem = ofrm.vPagoInteresMora
                                        Else
                                            ofrm.vPagoInteresMora = vPago
                                            vPago = 0
                                            vMontoItem = ofrm.vPagoInteresMora
                                            Exit Select
                                        End If
                                    End If
                                Else
                                    If oCaja.Redondear(drPrestamo("SaldoDia_InteresMora"), 2) > 0 And vPago > 0 Then
                                        bAgrega = True
                                        If vPago > oCaja.Redondear(drPrestamo("SaldoDia_InteresMora"), 2) Then
                                            ofrm.vPagoInteresMora = oCaja.Redondear(drPrestamo("SaldoDia_InteresMora"), 2)
                                            vPago = vPago - oCaja.Redondear(drPrestamo("SaldoDia_InteresMora"), 2)
                                            vMontoItem = ofrm.vPagoInteresMora
                                        Else
                                            ofrm.vPagoInteresMora = vPago
                                            vPago = 0
                                            vMontoItem = ofrm.vPagoInteresMora
                                            Exit Select
                                        End If
                                    End If
                                End If
                            Case Is = "C" ' Capital
                                If oCaja.Redondear(drPrestamo("Saldo_Capital"), 2) > 0 And vPago > 0 Then
                                    bAgrega = True
                                    If vPago < oCaja.Redondear(drPrestamo("Saldo_Capital"), 2) Then
                                        ofrm.vPagoCapital = vPago 'oCaja.Redondear(drPrestamo("Saldo_Capital"), 2)
                                        vPago = 0 'vPago - oCaja.Redondear(drPrestamo("Saldo_Capital"), 2)
                                        vMontoItem = ofrm.vPagoCapital
                                        Exit Select
                                    ElseIf vPago > oCaja.Redondear(drPrestamo("Saldo_Capital"), 2) Then
                                        MsgBox("El monto ingresado es mayor que el saldo del prestamo." + vbCrLf + "Diferencia:" & Math.Round(vPago - oCaja.Redondear(drPrestamo("Saldo_Capital"), 2), 2).ToString, MsgBoxStyle.Critical, "Módulo - Caja")
                                        limpiarDetallePago()
                                        Exit Sub
                                    ElseIf Math.Round(vPago, 2) = oCaja.Redondear(drPrestamo("Saldo_Capital"), 2) Then
                                        ofrm.vPagoCapital = vPago 'oCaja.Redondear(drPrestamo("Saldo_Capital"), 2)
                                        vPago = 0 'vPago - oCaja.Redondear(drPrestamo("Saldo_Capital"), 2)
                                        vMontoItem = ofrm.vPagoCapital
                                        ofrm.cancelacion = True
                                        ofrm.lblNotCan.Visible = True

                                        Exit Select
                                    End If
                                End If
                            'Case Is = "C" ' Capital
                            '    If oCaja.Redondear(drPrestamo("Saldo_Capital"), 2) > 0 And vPago > 0 Then
                            '        bAgrega = True
                            '        If vPago > oCaja.Redondear(drPrestamo("Saldo_Capital"), 2) Then
                            '            ofrm.vPagoCapital = oCaja.Redondear(drPrestamo("Saldo_Capital"), 2)
                            '            vPago = vPago - oCaja.Redondear(drPrestamo("Saldo_Capital"), 2)
                            '            vMontoItem = ofrm.vPagoCapital
                            '        Else
                            '            ofrm.vPagoCapital = vPago
                            '            vPago = 0
                            '            vMontoItem = ofrm.vPagoCapital
                            '            Exit Select
                            '        End If
                            '    End If
                            Case Is = "R" 'Capital Moratorio
                                If IIf(IsDBNull(drPrestamo("DiaGracia")), "N", drPrestamo("DiaGracia")) = "S" Then
                                    If oCaja.Redondear(drPrestamo("Saldo_CapMoraGracia"), 2) > 0 And vPago > 0 Then
                                        bAgrega = True
                                        If vPago > oCaja.Redondear(drPrestamo("Saldo_CapMoraGracia"), 2) Then
                                            ofrm.vPagoCapitalMora = oCaja.Redondear(drPrestamo("Saldo_CapMoraGracia"), 2)
                                            vPago = vPago - oCaja.Redondear(drPrestamo("Saldo_CapMoraGracia"), 2)
                                            vMontoItem = ofrm.vPagoCapitalMora
                                        Else
                                            ofrm.vPagoCapitalMora = vPago
                                            vPago = 0
                                            vMontoItem = ofrm.vPagoCapitalMora
                                            Exit Select
                                        End If
                                    End If
                                Else
                                    If oCaja.Redondear(drPrestamo("SaldoDia_CapitalMora"), 2) > 0 And vPago > 0 Then
                                        bAgrega = True
                                        If vPago > oCaja.Redondear(drPrestamo("SaldoDia_CapitalMora"), 2) Then
                                            ofrm.vPagoCapitalMora = oCaja.Redondear(drPrestamo("SaldoDia_CapitalMora"), 2)
                                            vPago = vPago - oCaja.Redondear(drPrestamo("SaldoDia_CapitalMora"), 2)
                                            vMontoItem = ofrm.vPagoCapitalMora
                                        Else
                                            ofrm.vPagoCapitalMora = vPago
                                            vPago = 0
                                            vMontoItem = ofrm.vPagoCapitalMora
                                            Exit Select
                                        End If
                                    End If
                                End If
                            Case Is = "H" 'Ahorro
                                If oCaja.Redondear(drPrestamo("SaldoDia_Ahorro"), 2) > 0 And vPago > 0 Then
                                    bAgrega = True
                                    If vPago > oCaja.Redondear(drPrestamo("SaldoDia_Ahorro"), 2) Then
                                        ofrm.vPagoAhorro = oCaja.Redondear(drPrestamo("SaldoDia_Ahorro"), 2)
                                        vPago = vPago - oCaja.Redondear(drPrestamo("SaldoDia_Ahorro"), 2)
                                        vMontoItem = ofrm.vPagoAhorro
                                    Else
                                        ofrm.vPagoAhorro = vPago
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoAhorro
                                        Exit Select
                                    End If
                                End If
                            Case Is = "A" ' Aportacion
                                If oCaja.Redondear(drPrestamo("SaldoDia_Aportacion"), 2) > 0 And vPago > 0 Then
                                    bAgrega = True
                                    If vPago > oCaja.Redondear(drPrestamo("SaldoDia_Aportacion"), 2) Then
                                        ofrm.vPagoAportacion = oCaja.Redondear(drPrestamo("SaldoDia_Aportacion"), 2)
                                        vPago = vPago - oCaja.Redondear(drPrestamo("SaldoDia_Aportacion"), 2)
                                        vMontoItem = ofrm.vPagoAportacion
                                    Else
                                        ofrm.vPagoAportacion = vPago
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoAportacion
                                        Exit Select
                                    End If
                                End If
                            Case Is = "S" ' Seguro Deuda
                                If oCaja.Redondear(drPrestamo("SaldoDia_SeguroDeuda"), 2) > 0 And vPago > 0 Then
                                    bAgrega = True
                                    If vPago > oCaja.Redondear(drPrestamo("SaldoDia_SeguroDeuda"), 2) Then
                                        ofrm.vPagoSeguroDeuda = oCaja.Redondear(drPrestamo("SaldoDia_SeguroDeuda"), 2)
                                        vPago = vPago - oCaja.Redondear(drPrestamo("SaldoDia_SeguroDeuda"), 2)
                                        vMontoItem = ofrm.vPagoSeguroDeuda
                                    Else
                                        ofrm.vPagoSeguroDeuda = vPago
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoSeguroDeuda
                                        Exit Select
                                    End If
                                End If
                            Case Is = "D" ' Seguro Daños
                                If oCaja.Redondear(drPrestamo("SaldoDia_SeguroDaniosyLA"), 2) > 0 And vPago > 0 Then
                                    bAgrega = True
                                    If vPago > oCaja.Redondear(drPrestamo("SaldoDia_SeguroDaniosyLA"), 2) Then
                                        ofrm.vPagoSeguroDanios = oCaja.Redondear(drPrestamo("SaldoDia_SeguroDaniosyLA"), 2)
                                        vPago = vPago - oCaja.Redondear(drPrestamo("SaldoDia_SeguroDaniosyLA"), 2)
                                        vMontoItem = ofrm.vPagoSeguroDanios
                                    Else
                                        ofrm.vPagoSeguroDanios = vPago
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoSeguroDanios
                                        Exit Select
                                    End If
                                End If
                            Case Is = "J" ' Comisión
                                If oCaja.Redondear(drPrestamo("SaldoDia_ComisionManejo"), 2) > 0 And vPago > 0 Then
                                    bAgrega = True
                                    If vPago > oCaja.Redondear(drPrestamo("SaldoDia_ComisionManejo"), 2) Then
                                        ofrm.vPagoComision = oCaja.Redondear(drPrestamo("SaldoDia_ComisionManejo"), 2)
                                        vPago = vPago - oCaja.Redondear(drPrestamo("SaldoDia_ComisionManejo"), 2)
                                        vMontoItem = ofrm.vPagoComision
                                    Else
                                        ofrm.vPagoComision = vPago
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoComision
                                        Exit Select
                                    End If
                                End If
                            Case Is = "O" 'Otros
                                If oCaja.Redondear(drPrestamo("SaldoDia_Otros"), 2) > 0 And vPago > 0 Then
                                    bAgrega = True
                                    If vPago > oCaja.Redondear(drPrestamo("SaldoDia_Otros"), 2) Then
                                        ofrm.vPagoOtros = oCaja.Redondear(drPrestamo("SaldoDia_Otros"), 2)
                                        vPago = vPago - oCaja.Redondear(drPrestamo("SaldoDia_Otros"), 2)
                                        vMontoItem = ofrm.vPagoOtros
                                    Else
                                        ofrm.vPagoOtros = vPago
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoOtros
                                        Exit Select
                                    End If
                                End If
                            Case Is = "U" 'Seguro Vehiculo
                                If oCaja.Redondear(drPrestamo("saldodia_seguroVehiculo"), 2) > 0 And vPago > 0 Then
                                    bAgrega = True
                                    If vPago > oCaja.Redondear(drPrestamo("saldodia_seguroVehiculo"), 2) Then
                                        ofrm.vPagoSeguroVehiculo = oCaja.Redondear(drPrestamo("saldodia_seguroVehiculo"), 2)
                                        vPago = vPago - oCaja.Redondear(drPrestamo("saldodia_seguroVehiculo"), 2)
                                        vMontoItem = ofrm.vPagoSeguroVehiculo
                                    Else
                                        ofrm.vPagoSeguroVehiculo = vPago
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoSeguroVehiculo
                                        Exit Select
                                    End If
                                End If
                            Case Is = "G" 'Pago Seguro Deuda adelantado
                                If CDate(vFechaOtorgamiento.ToShortDateString) = CDate(vFecha.ToShortDateString) Then
                                    If vPago > 0 Then
                                        bAgrega = True
                                        ofrm.vPagoSeguroDeuda = vPago 'Abonar el total al Seguro Deuda
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoSeguroDeuda
                                        Exit Select
                                    End If
                                Else
                                    MessageBox.Show("El item solo se puede facturar el día del otorgamiento.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    ofrm.Factura.Tables("CADet_Facturas").Rows.Clear()
                                    ofrm.vTotalFactura = 0
                                    ofrm.vTotalNoGravado = 0
                                    ofrm.vTotalGravado = 0
                                    ofrm.vTotalSIva = 0
                                    ofrm.vTotalIVA = 0
                                    ofrm.vPagoCapital = 0
                                    ofrm.vPagoInteres = 0
                                    ofrm.vPagoCapitalMora = 0
                                    ofrm.vPagoInteresMora = 0
                                    ofrm.vPagoSeguroDeuda = 0
                                    ofrm.vPagoSeguroDanios = 0
                                    ofrm.vPagoSeguroVida = 0
                                    ofrm.vPagoSeguroDesempleo = 0
                                    ofrm.vPagoAportacion = 0
                                    ofrm.vPagoAhorro = 0
                                    ofrm.vPagoComision = 0
                                    ofrm.vPagoOtros = 0
                                    ofrm.vPagoSeguroVehiculo = 0
                                    ofrm.vCancela = False
                                    vPago = 0
                                    vMontoItem = 0
                                    frm.vTotalGravado = 0
                                    frm.vTotalNoGravado = 0
                                    frm.vTotalSIva = 0
                                    frm.vTotalIVA = 0
                                    frm.vTotalFactura = 0
                                    frm.txtTotalFactura.ReadOnly = False
                                    frm.txtTotalFactura.Enabled = True
                                    frm.txtTotalFactura.Value = 0
                                    frm.txtTotalFactura.ReadOnly = True
                                    frm.txtTotalFactura.Enabled = False
                                End If
                        End Select
                        If bAgrega = True Then
                            x += 1
                            drC = ofrm.Factura.Tables("CADet_Facturas").NewRow
                            drC("Correlativo") = x
                            drC("TipoMov") = CInt(vTipo)
                            drC("CodItem") = drB("CodItem")
                            drC("Descripcion") = drB("Descripcion")
                            drC("Cantidad") = 1
                            drC("TipoItem") = drB("Tipo_Item")
                            drC("Monto_Pago") = 0
                            If drB("NoAplicaGravado") = "N" Then
                                If drB("Gravado") = "S" Then
                                    drC("SubTotal_Gravado") = Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                    'drC("SubTotal_Gravado") = Format(vMontoItem, "#,###,##0.00")
                                    drC("SubTotal_Exento") = 0
                                    drC("SubTotal_SIva") = 0
                                    drC("Total_Iva") = Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                    drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                    'drC("Total_Vta") = Format(vMontoItem + (vMontoItem * oApp.PorcentajeIVA), "#,###,##0.00")
                                    drC("SubTotal_SIva") = 0
                                    'Totales para encabezado Factura
                                    'ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem, "#,###,##0.00")
                                    ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                    ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                    ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                                ElseIf drB("Gravado") = "N" Then
                                    drC("SubTotal_Gravado") = 0
                                    drC("SubTotal_Exento") = Format(vMontoItem, "#,###,##0.00")
                                    drC("SubTotal_SIva") = 0
                                    drC("Total_Iva") = 0
                                    drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                    'Totales para encabezado Factura
                                    ofrm.vTotalNoGravado = ofrm.vTotalNoGravado + Format(vMontoItem, "#,###,##0.00")
                                    ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                                End If
                            Else 'No Aplica Gravado ni Exento
                                drC("SubTotal_Gravado") = 0
                                drC("SubTotal_Exento") = 0
                                drC("SubTotal_SIva") = Format(vMontoItem, "#,###,##0.00")
                                drC("Total_Iva") = 0
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'drC("Total_Vta") = Format(vMontoItem + (vMontoItem * oApp.PorcentajeIVA), "#,###,##0.00")
                                'Totales para encabezado Factura
                                ofrm.vTotalSIva = ofrm.vTotalSIva + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            End If
                            drC("Mes") = Date.Now.Month
                            drC("Annio") = Fecha.Date.Year
                            drC("Observacion") = Me.txtObservacion.Text.Trim
                            drC("CodTipo") = Me.txtCodTipoCredito.Text.Trim
                            drC("NoCuenta") = Me.txtCodPrestamo.Text.Trim
                            drC("NoLibreta") = ""
                            drC("PagoLibreta") = ""
                            ofrm.Factura.Tables("CADet_Facturas").Rows.Add(drC)
                        End If
                        bAgrega = False
                    Next
                    ofrm.txtTotalFactura.Value = ofrm.vTotalFactura

                    'cambio para los Otros pagos en Contabilidad  22/05/2020
                ElseIf vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Contables Then

                    '--------------------------------------------------------------------
                    'Lista de Items Facturables para Préstamos
                    oCaja = New wrCaja.wsLibCaja
                    ds = oCaja.ObtenerListaItems("*", "Tipo_Item<>'P' and TipoMovimiento='" & ofrm.Item("TipoMovimiento") & "'", sUsuario, sPassword, sSucursal)
                    '--------------------------------------------------------------------
                    'Nueva Linea para Detalle de Factura
                    dr = ofrm.Factura.Tables("CADet_Facturas").NewRow
                    x = ofrm.Factura.Tables("CADet_Facturas").Rows.Count + 1
                    dr("Correlativo") = x
                    dr("TipoMov") = CInt(vTipo)
                    dr("CodItem") = Me.txtCodItem.Text.Trim
                    dr("Descripcion") = Me.txtItem.Text.Trim
                    dr("Cantidad") = 1
                    dr("TipoItem") = "P"
                    dr("Monto_Pago") = Me.txtPago.Value
                    dr("SubTotal_Gravado") = 0
                    dr("SubTotal_Exento") = 0
                    dr("SubTotal_SIva") = 0
                    dr("Total_Iva") = 0
                    dr("Total_Vta") = 0
                    dr("Mes") = Date.Now.Month
                    dr("Annio") = Fecha.Date.Year
                    dr("Observacion") = Me.txtObservacion.Text.Trim
                    dr("CodTipo") = ""
                    dr("NoCuenta") = ofrm.txtCuenta.Text.Trim
                    dr("NoLibreta") = ""
                    ofrm.Factura.Tables("CADet_Facturas").Rows.Add(dr)

                    'Se agrega un item por cada detalle del pago 
                    drB = ds.Tables("CAItemsFact").Rows(0)
                    bAgrega = True
                    vMontoItem = vPago

                    If bAgrega = True Then
                        x += 1
                        drC = ofrm.Factura.Tables("CADet_Facturas").NewRow
                        drC("Correlativo") = x
                        drC("TipoMov") = CInt(vTipo)
                        drC("CodItem") = drB("CodItem")
                        drC("Descripcion") = drB("Descripcion")
                        drC("Cantidad") = 1
                        drC("TipoItem") = drB("Tipo_Item")
                        drC("Monto_Pago") = 0
                        If drB("NoAplicaGravado") = "N" Then
                            If drB("Gravado") = "S" Then
                                drC("SubTotal_Gravado") = Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                drC("SubTotal_Exento") = 0
                                drC("SubTotal_SIva") = 0
                                drC("Total_Iva") = Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'Totales para encabezdo Factura
                                ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            ElseIf drB("Gravado") = "N" Then
                                drC("SubTotal_Gravado") = 0
                                drC("SubTotal_Exento") = Format(vMontoItem, "#,###,##0.00")
                                drC("SubTotal_SIva") = 0
                                drC("Total_Iva") = 0
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'Totales para encabezdo Factura
                                ofrm.vTotalNoGravado = ofrm.vTotalNoGravado + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            End If
                        Else
                            drC("SubTotal_Gravado") = 0
                            drC("SubTotal_Exento") = 0
                            drC("SubTotal_SIva") = Format(vMontoItem, "#,###,##0.00")
                            drC("Total_Iva") = 0
                            drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                            'Totales para encabezado Factura
                            ofrm.vTotalSIva = ofrm.vTotalSIva + Format(vMontoItem, "#,###,##0.00")
                            ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                        End If
                        drC("Mes") = Date.Now.Month
                        drC("Annio") = Fecha.Date.Year
                        drC("Observacion") = Me.txtObservacion.Text.Trim
                        dr("CodTipo") = ""
                        drC("NoCuenta") = ofrm.txtCuenta.Text.Trim
                        drC("NoLibreta") = ""
                        drC("PagoLibreta") = ""
                        ofrm.Factura.Tables("CADet_Facturas").Rows.Add(drC)
                    End If
                    bAgrega = False

                    ofrm.txtTotalFactura.Value = ofrm.vTotalFactura

                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then

                    If Me.txtNoCuenta.Text.Trim = "" Then
                        MsgBox("DEBE DIGITAR EL NO. DE CUENTA DE AHORRO.", MsgBoxStyle.Critical, "Módulo Caja")
                        Exit Sub
                    End If

                    '--------------------------------------------------------------------
                    'Lista de Items Facturables para Préstamos
                    oCaja = New wrCaja.wsLibCaja
                    ds = oCaja.ObtenerListaItems("*", "idApp=8 and Tipo_Item<>'P' and TipoMovimiento='" & ofrm.Item("TipoMovimiento") & "'", sUsuario, sPassword, sSucursal)
                    drB = ds.Tables("CAItemsFact").Rows(0)
                    '--------------------------------------------------------------------

                    'Validación solo para RETIRO
                    drPrestamo = ofrm.Prestamo.Tables(0).Rows(0)
                    If drB("Tipo_Item") = "R" Then
                        ofrm.pTipoTransaccion = "R"
                        If oCaja.Redondear(drPrestamo("SaldoDisponible_CuentaAhorro"), 2) >= oCaja.Redondear(vPago, 2) Then
                            bAgrega = True
                            vMontoItem = vPago
                        Else
                            MsgBox("El Monto de Retiro es mayor que el Saldo disponible.", MsgBoxStyle.Critical, "Módulo Caja")
                            Exit Sub
                        End If

                        If ofrm.vCancela = False Then

                            dsAhorro = oAhorro.ConsultarParametros("*", "CodTipoAhorro='" & drPrestamo("CodTipoAhorro") & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                            If dsAhorro.Tables("AhParametros").Rows.Count > 0 Then
                                drAhorro = dsAhorro.Tables("AhParametros").Rows(0)
                                If oCaja.Redondear(drAhorro("MontoSaldoMinimo"), 2) > oCaja.Redondear(drPrestamo("SaldoDisponible_CuentaAhorro"), 2) - Math.Round(vPago, 2) Then
                                    ofrm.vCancela = True
                                    If MessageBox.Show("El Saldo mínimo debe ser de " & oCaja.Redondear(drAhorro("MontoSaldoMinimo"), 2) & ". ¿Desea cancelar la cuenta?", "Cancelación de Cuentas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                                        ofrm.vCancela = False
                                        Exit Sub
                                    Else
                                        If drPrestamo("Pignorado") = "S" Then
                                            MessageBox.Show("La cuenta se encuentra pignorada, no se puede cancelar.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            ofrm.vCancela = False
                                            Exit Sub
                                        End If

                                        dsPar = oAsoc.ConsultarParametros("*", "", "SalarioMinimo", sUsuario, sPassword, sSucursal)
                                        If dsPar.Tables(0).Rows.Count > 0 Then
                                            drPar = dsPar.Tables(0).Rows(0)
                                            pMontoParam = IIf(IsDBNull(drPar("MontoDPF")), 0, drPar("MontoDPF"))
                                        Else
                                            pMontoParam = 0
                                        End If

                                        Dim ofrmAut As New frmMsAutorizacion
                                        ofrmAut.TipoPermiso = "P"
                                        ofrmAut.NumPrograma = "AHG010"
                                        ofrmAut.ShowDialog()
                                        If ofrmAut.Autoriza = True Then
                                            'Cancelar la Cuenta
                                            Dim ofrmCC As New frmMsAhCancelaCuenta
                                            If CStr(drPrestamo("CodTipoAhorro")).Trim.Substring(0, 1) = "2" Then
                                                If oCaja.Redondear(drPrestamo("SaldoDisponible_CuentaAhorro"), 2) >= pMontoParam Then
                                                    ofrmCC.vAplicaAut = True
                                                Else
                                                    ofrmCC.vAplicaAut = False
                                                End If
                                            Else
                                                ofrmCC.vAplicaAut = False
                                            End If
                                            ofrmCC.vCUsuario = ofrmAut.Usuario
                                            ofrmCC.vCPassword = ofrmAut.Password
                                            ofrmCC.NoCaja = ofrm.NoCaja
                                            ofrmCC.CodCajero = ofrm.CodCajero
                                            ofrmCC.NoCuenta = drPrestamo("NoCuenta")
                                            ofrmCC.CodTipoAhorro = drPrestamo("CodTipoAhorro")
                                            ofrmCC.ShowDialog()
                                            If ofrmCC.Autorizado = False Then
                                                MessageBox.Show("La cuenta no se ha cancelado, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                ofrm.vCancela = False
                                                Exit Sub
                                            Else
                                                ofrm.vCancela = True
                                                MessageBox.Show("Cuenta cancelada.", "Cancelación de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                CargaDatosCuentaCancelada()
                                                EstadoCuentaCancelada()
                                                ofrm.pCodTransaccion = "CAN"
                                                Exit Sub
                                            End If
                                            ofrmAut.Autoriza = False
                                            ofrmAut.Dispose()
                                        Else
                                            ofrm.vCancela = False
                                            ofrmAut.Dispose()
                                            Exit Sub
                                        End If
                                    End If
                                Else
                                    ofrm.pCodTransaccion = "RET"
                                End If
                            End If
                        End If
                    ElseIf drB("Tipo_Item") = "C" Then
                        ofrm.pTipoTransaccion = "C"
                        If drPrestamo("Estado") = "D" Then
                            ofrm.pCodTransaccion = "APE"
                        Else
                            ofrm.pCodTransaccion = "DEP"
                        End If
                    End If

                    'Nueva Linea para Detalle de Factura
                    dr = ofrm.Factura.Tables("CADet_Facturas").NewRow
                    x = ofrm.Factura.Tables("CADet_Facturas").Rows.Count + 1
                    dr("Correlativo") = x
                    dr("TipoMov") = CInt(vTipo)
                    dr("CodItem") = Me.txtCodItem.Text.Trim
                    dr("Descripcion") = Me.txtItem.Text.Trim
                    dr("Cantidad") = 1
                    dr("TipoItem") = "P"
                    dr("Monto_Pago") = Me.txtPago.Value
                    dr("SubTotal_Gravado") = 0
                    dr("SubTotal_Exento") = 0
                    dr("SubTotal_SIva") = 0
                    dr("Total_Iva") = 0
                    dr("Total_Vta") = 0
                    dr("Mes") = Date.Now.Month
                    dr("Annio") = Fecha.Date.Year
                    dr("Observacion") = Me.txtObservacion.Text.Trim
                    dr("CodTipo") = Me.txtCodTipoAhorro.Text.Trim
                    dr("NoCuenta") = Me.txtNoCuenta.Text.Trim
                    dr("NoLibreta") = Me.txtNoLibreta.Text.Trim
                    dr("PagoLibreta") = vPagoLibreta
                    ofrm.Factura.Tables("CADet_Facturas").Rows.Add(dr)

                    drPrestamo = ofrm.Prestamo.Tables(0).Rows(0)
                    bAgrega = True
                    vMontoItem = vPago

                    If bAgrega = True Then
                        x += 1
                        drC = ofrm.Factura.Tables("CADet_Facturas").NewRow
                        drC("Correlativo") = x
                        drC("TipoMov") = CInt(vTipo)
                        drC("CodItem") = drB("CodItem")
                        drC("Descripcion") = drB("Descripcion")
                        drC("Cantidad") = 1
                        drC("TipoItem") = drB("Tipo_Item")
                        drC("Monto_Pago") = 0
                        If drB("NoAplicaGravado") = "N" Then
                            If drB("Gravado") = "S" Then
                                drC("SubTotal_Gravado") = Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                'drC("SubTotal_Gravado") = Format(vMontoItem, "#,###,##0.00")
                                drC("SubTotal_Exento") = 0
                                drC("SubTotal_SIva") = 0
                                drC("Total_Iva") = Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                'drC("Total_Iva") = Format(vMontoItem * oApp.PorcentajeIVA, "#,###,##0.00")
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'drC("Total_Vta") = Format(vMontoItem + (vMontoItem * oApp.PorcentajeIVA), "#,###,##0.00")
                                'Totales para encabezado Factura
                                ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                'ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                'ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem * oApp.PorcentajeIVA, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            ElseIf drB("Gravado") = "N" Then
                                drC("SubTotal_Gravado") = 0
                                drC("SubTotal_Exento") = Format(vMontoItem, "#,###,##0.00")
                                drC("SubTotal_SIva") = 0
                                drC("Total_Iva") = 0
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'Totales para encabezado Factura
                                ofrm.vTotalNoGravado = ofrm.vTotalNoGravado + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            End If
                        Else
                            drC("SubTotal_Gravado") = 0
                            drC("SubTotal_Exento") = 0
                            drC("SubTotal_SIva") = Format(vMontoItem, "#,###,##0.00")
                            drC("Total_Iva") = 0
                            drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                            'Totales para encabezado Factura
                            ofrm.vTotalSIva = ofrm.vTotalSIva + Format(vMontoItem, "#,###,##0.00")
                            ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                        End If
                        drC("Mes") = Date.Now.Month
                        drC("Annio") = Fecha.Date.Year
                        drC("Observacion") = Me.txtObservacion.Text.Trim
                        drC("CodTipo") = Me.txtCodTipoAhorro.Text.Trim
                        drC("NoCuenta") = Me.txtNoCuenta.Text.Trim
                        drC("NoLibreta") = Me.txtNoLibreta.Text.Trim
                        drC("PagoLibreta") = vPagoLibreta
                        ofrm.Factura.Tables("CADet_Facturas").Rows.Add(drC)
                    End If
                    bAgrega = False

                    ofrm.txtTotalFactura.Value = ofrm.vTotalFactura

                    'Si el movimiento es un Pago de Aportaciones
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then

                    If Me.txtNoCuenta.Text.Trim = "" Then
                        MsgBox("DEBE DIGITAR EL NO. DE CUENTA.", MsgBoxStyle.Critical, "Módulo Caja")
                        Exit Sub
                    End If

                    '--------------------------------------------------------------------
                    oCaja = New wrCaja.wsLibCaja
                    ds = oCaja.ObtenerListaItems("*", "idApp=9 and Tipo_Item<>'P' and TipoMovimiento='" & ofrm.Item("TipoMovimiento") & "'", sUsuario, sPassword, sSucursal)
                    '--------------------------------------------------------------------
                    'Nueva Linea para Detalle de Factura
                    dr = ofrm.Factura.Tables("CADet_Facturas").NewRow
                    x = ofrm.Factura.Tables("CADet_Facturas").Rows.Count + 1
                    dr("Correlativo") = x
                    dr("TipoMov") = CInt(vTipo)
                    dr("CodItem") = Me.txtCodItem.Text.Trim
                    dr("Descripcion") = Me.txtItem.Text.Trim
                    dr("Cantidad") = 1
                    dr("TipoItem") = "P"
                    dr("Monto_Pago") = Me.txtPago.Value
                    dr("SubTotal_Gravado") = 0
                    dr("SubTotal_Exento") = 0
                    dr("SubTotal_SIva") = 0
                    dr("Total_Iva") = 0
                    dr("Total_Vta") = 0
                    dr("Mes") = Date.Now.Month
                    dr("Annio") = Fecha.Date.Year
                    dr("Observacion") = Me.txtObservacion.Text.Trim
                    dr("CodTipo") = Me.txtCodTipoAhorro.Text.Trim
                    dr("NoCuenta") = Me.txtNoCuenta.Text.Trim
                    dr("NoLibreta") = Me.txtNoLibreta.Text.Trim
                    dr("PagoLibreta") = vPagoLibreta
                    ofrm.Factura.Tables("CADet_Facturas").Rows.Add(dr)

                    'Se agrega un item por cada detalle del pago al préstamo
                    drPrestamo = ofrm.Prestamo.Tables(0).Rows(0)
                    drB = ds.Tables("CAItemsFact").Rows(0)
                    bAgrega = True
                    vMontoItem = vPago

                    If drB("Tipo_Item") = "C" Then ofrm.pCodTransaccion = "DEP"

                    If bAgrega = True Then
                        x += 1
                        drC = ofrm.Factura.Tables("CADet_Facturas").NewRow
                        drC("Correlativo") = x
                        drC("TipoMov") = CInt(vTipo)
                        drC("CodItem") = drB("CodItem")
                        drC("Descripcion") = drB("Descripcion")
                        drC("Cantidad") = 1
                        drC("TipoItem") = drB("Tipo_Item")
                        drC("Monto_Pago") = 0
                        If drB("NoAplicaGravado") = "N" Then
                            If drB("Gravado") = "S" Then
                                drC("SubTotal_Gravado") = Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                'drC("SubTotal_Gravado") = Format(vMontoItem, "#,###,##0.00")
                                drC("SubTotal_Exento") = 0
                                drC("SubTotal_SIva") = 0
                                drC("Total_Iva") = Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                'drC("Total_Iva") = Format(vMontoItem * oApp.PorcentajeIVA, "#,###,##0.00")
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'drC("Total_Vta") = Format(vMontoItem + (vMontoItem * oApp.PorcentajeIVA), "#,###,##0.00")
                                'Totales para encabezado Factura
                                ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                'ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                'ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem * oApp.PorcentajeIVA, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            ElseIf drB("Gravado") = "N" Then
                                drC("SubTotal_Gravado") = 0
                                drC("SubTotal_Exento") = Format(vMontoItem, "#,###,##0.00")
                                drC("SubTotal_SIva") = 0
                                drC("Total_Iva") = 0
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'Totales para encabezado Factura
                                ofrm.vTotalNoGravado = ofrm.vTotalNoGravado + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            End If
                        Else
                            drC("SubTotal_Gravado") = 0
                            drC("SubTotal_Exento") = 0
                            drC("SubTotal_SIva") = Format(vMontoItem, "#,###,##0.00")
                            drC("Total_Iva") = 0
                            drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                            'Totales para encabezado Factura
                            ofrm.vTotalSIva = ofrm.vTotalSIva + Format(vMontoItem, "#,###,##0.00")
                            ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                        End If
                        drC("Mes") = Date.Now.Month
                        drC("Annio") = Fecha.Date.Year
                        drC("Observacion") = Me.txtObservacion.Text.Trim
                        drC("CodTipo") = Me.txtCodTipoAhorro.Text.Trim
                        drC("NoCuenta") = Me.txtNoCuenta.Text.Trim
                        drC("NoLibreta") = Me.txtNoLibreta.Text.Trim
                        drC("PagoLibreta") = vPagoLibreta
                        ofrm.Factura.Tables("CADet_Facturas").Rows.Add(drC)
                    End If
                    bAgrega = False

                    ofrm.txtTotalFactura.Value = ofrm.vTotalFactura
                    'detalle cuenta por cobrar 
                ElseIf vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.CuentaporCobrar Then
                    Dim dts As New DataSet
                    Dim dtsItem As New DataSet

                    dts = contabilidad.distribucionCxC(txtNoCxC.Text, txtPago.Value, ofrm.Item("TipoMovimiento"))
                    If dts.Tables.Count > 0 Then
                        If dts.Tables(0).Rows.Count > 0 Then
                            'Nueva Linea para Detalle de Factura
                            dr = ofrm.Factura.Tables("CADet_Facturas").NewRow
                            x = ofrm.Factura.Tables("CADet_Facturas").Rows.Count + 1
                            dr("Correlativo") = x
                            dr("TipoMov") = CInt(vTipo)
                            dr("CodItem") = Me.txtCodItem.Text.Trim
                            dr("Descripcion") = Me.txtItem.Text.Trim
                            dr("Cantidad") = 1
                            dr("TipoItem") = "P"
                            dr("Monto_Pago") = Me.txtPago.Value
                            dr("SubTotal_Gravado") = 0
                            dr("SubTotal_Exento") = 0
                            dr("SubTotal_SIva") = 0
                            dr("Total_Iva") = 0
                            dr("Total_Vta") = 0
                            dr("Mes") = Date.Now.Month
                            dr("Annio") = Fecha.Date.Year
                            dr("Observacion") = Me.txtObservacion.Text.Trim
                            dr("CodTipo") = ""
                            dr("NoCuenta") = txtNoCxC.Text ' ofrm.txt.Text.Trim
                            dr("NoLibreta") = ""
                            ofrm.Factura.Tables("CADet_Facturas").Rows.Add(dr)

                            'Se agrega un item por cada detalle del pago 

                            'drB = ds.Tables("CAItemsFact").Rows(0)
                            bAgrega = True
                            'vMontoItem = vPago

                            For Each row As DataRow In dts.Tables(0).Rows


                                'Se agrega un item por cada detalle del pago 


                                vMontoItem = row("abono")

                                If bAgrega = True Then
                                    x += 1
                                    drC = ofrm.Factura.Tables("CADet_Facturas").NewRow
                                    drC("Correlativo") = x
                                    drC("TipoMov") = CInt(vTipo)
                                    drC("CodItem") = row("CodItem")
                                    drC("Descripcion") = row("Descripcion")
                                    drC("Cantidad") = 1
                                    drC("TipoItem") = row("Tipo_Item")
                                    drC("Monto_Pago") = row("abono")
                                    If row("NoAplicaGravado") = "N" Then
                                        If row("Gravado") = "S" Then
                                            drC("SubTotal_Gravado") = Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                            'drC("SubTotal_Gravado") = Format(vMontoItem, "#,###,##0.00")
                                            drC("SubTotal_Exento") = 0
                                            drC("SubTotal_SIva") = 0
                                            drC("Total_Iva") = Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                            'drC("Total_Iva") = Format(vMontoItem * oApp.PorcentajeIVA, "#,###,##0.00")
                                            drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                            'drC("Total_Vta") = Format(vMontoItem + (vMontoItem * oApp.PorcentajeIVA), "#,###,##0.00")
                                            'Totales para encabezado Factura
                                            ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                            'ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem, "#,###,##0.00")
                                            ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                            'ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem * oApp.PorcentajeIVA, "#,###,##0.00")
                                            ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                                        ElseIf row("Gravado") = "N" Then
                                            drC("SubTotal_Gravado") = 0
                                            drC("SubTotal_Exento") = Format(vMontoItem, "#,###,##0.00")
                                            drC("SubTotal_SIva") = 0
                                            drC("Total_Iva") = 0
                                            drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                            'Totales para encabezado Factura
                                            ofrm.vTotalNoGravado = ofrm.vTotalNoGravado + Format(vMontoItem, "#,###,##0.00")
                                            ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                                        End If
                                    Else
                                        drC("SubTotal_Gravado") = 0
                                        drC("SubTotal_Exento") = 0
                                        drC("SubTotal_SIva") = Format(vMontoItem, "#,###,##0.00")
                                        drC("Total_Iva") = 0
                                        drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                        'Totales para encabezado Factura
                                        ofrm.vTotalSIva = ofrm.vTotalSIva + Format(vMontoItem, "#,###,##0.00")
                                        ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                                    End If
                                    drC("Mes") = Fecha.Month
                                    drC("Annio") = Fecha.Year
                                    drC("Observacion") = Me.txtObservacion.Text.Trim
                                    drC("CodTipo") = ""
                                    drC("NoCuenta") = ofrm.txtCuenta.Text.Trim
                                    drC("NoLibreta") = ""
                                    drC("PagoLibreta") = ""
                                    ofrm.Factura.Tables("CADet_Facturas").Rows.Add(drC)
                                End If
                            Next
                            bAgrega = False

                            ofrm.txtTotalFactura.Value = ofrm.vTotalFactura
                        End If
                    End If

                    'Si el movimiento es Apertura de DPF
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then

                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                    If Me.txtDPFNoCuenta.Text.Trim = "" Then
                        MsgBox("DEBE DIGITAR EL NO. DE CUENTA.", MsgBoxStyle.Critical, "Módulo Caja")
                        Exit Sub
                    End If

                    '--------------------------------------------------------------------
                    'Lista de Items Facturables para Préstamos
                    oCaja = New wrCaja.wsLibCaja
                    ds = oCaja.ObtenerListaItems("*", "idApp=8 and Tipo_Item<>'P' and TipoMovimiento='" & ofrm.Item("TipoMovimiento") & "'", sUsuario, sPassword, sSucursal)
                    drB = ds.Tables("CAItemsFact").Rows(0)
                    '--------------------------------------------------------------------

                    'Validación solo para RETIRO
                    drPrestamo = ofrm.Prestamo.Tables(0).Rows(0)
                    If drB("Tipo_Item") = "R" Then

                        If oCaja.Redondear(drPrestamo("SaldoDisponible_CuentaAhorro"), 2) >= oCaja.Redondear(vPago, 2) Then
                            bAgrega = True
                            vMontoItem = vPago
                        Else
                            MsgBox("El Monto de Retiro es mayor que el Saldo disponible.", MsgBoxStyle.Critical, "Módulo Caja")
                            Exit Sub
                        End If

                        If ofrm.vCancela = False Then
                            dsAhorro = oAhorro.ConsultarParametros("*", "CodTipoAhorro='" & drPrestamo("CodTipoAhorro") & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                            If dsAhorro.Tables("AhParametros").Rows.Count > 0 Then
                                drAhorro = dsAhorro.Tables("AhParametros").Rows(0)
                                If oCaja.Redondear(drAhorro("MontoSaldoMinimo"), 2) > oCaja.Redondear(drPrestamo("SaldoDisponible_CuentaAhorro"), 2) - oCaja.Redondear(vPago, 2) Then
                                    ofrm.vCancela = True
                                    If MessageBox.Show("El Saldo mínimo debe ser de " & oCaja.Redondear(drAhorro("MontoSaldoMinimo"), 2) & ". ¿Desea cancelar la cuenta?", "Cancelación de Cuentas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                                        ofrm.vCancela = False
                                        Exit Sub
                                    Else
                                        If drPrestamo("Pignorado") = "S" Then
                                            MessageBox.Show("La cuenta se encuentra pignorada, no se puede cancelar.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            ofrm.vCancela = False
                                            Exit Sub
                                        End If
                                        Dim ofrmAut As New frmMsAutorizacion
                                        ofrmAut.TipoPermiso = "P"
                                        ofrmAut.NumPrograma = "AHG010"
                                        ofrmAut.ShowDialog()
                                        If ofrmAut.Autoriza = True Then
                                            'Cancelar la Cuenta
                                            Dim ofrmCC As New frmMsAhCancelaCuenta
                                            ofrmCC.vCUsuario = ofrmAut.Usuario
                                            ofrmCC.vCPassword = ofrmAut.Password
                                            ofrmCC.NoCaja = ofrm.NoCaja
                                            ofrmCC.CodCajero = ofrm.CodCajero
                                            ofrmCC.NoCuenta = drPrestamo("NoCuenta")
                                            ofrmCC.CodTipoAhorro = drPrestamo("CodTipoAhorro")
                                            ofrmCC.ShowDialog()
                                            If ofrmCC.Autorizado = False Then
                                                MessageBox.Show("La cuenta no se ha cancelado, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                ofrm.vCancela = False
                                                Exit Sub
                                            Else
                                                ofrm.vCancela = True
                                                MessageBox.Show("Cuenta cancelada.", "Cancelación de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                CargaDatosDPFCancelado()
                                                EstadoCuentaCancelada()
                                                ofrm.pCodTransaccion = "CAN"
                                                Exit Sub
                                            End If
                                            ofrmAut.Autoriza = False
                                            ofrmAut.Dispose()
                                        Else
                                            ofrm.vCancela = False
                                            ofrmAut.Dispose()
                                            Exit Sub
                                        End If
                                    End If
                                Else
                                    ofrm.pCodTransaccion = "RET"
                                End If
                            End If
                        End If

                    ElseIf drB("Tipo_Item") = "T" Then
                        If drPrestamo("Estado") = "D" Then
                            ofrm.pCodTransaccion = "APE"
                        Else
                            ofrm.pCodTransaccion = "DEP"
                        End If
                    End If

                    'Nueva Linea para Detalle de Factura
                    dr = ofrm.Factura.Tables("CADet_Facturas").NewRow
                    x = ofrm.Factura.Tables("CADet_Facturas").Rows.Count + 1
                    dr("Correlativo") = x
                    dr("TipoMov") = CInt(vTipo)
                    dr("CodItem") = Me.txtCodItem.Text.Trim
                    dr("Descripcion") = Me.txtItem.Text.Trim
                    dr("Cantidad") = 1
                    dr("TipoItem") = "P"
                    dr("Monto_Pago") = Me.txtPago.Value
                    dr("SubTotal_Gravado") = 0
                    dr("SubTotal_Exento") = 0
                    dr("SubTotal_SIva") = 0
                    dr("Total_Iva") = 0
                    dr("Total_Vta") = 0
                    dr("Mes") = Date.Now.Month
                    dr("Annio") = Fecha.Date.Year
                    dr("Observacion") = Me.txtObservacion.Text.Trim
                    dr("CodTipo") = Me.txtDPFCodTipoAhorro.Text.Trim
                    dr("NoCuenta") = Me.txtDPFNoCuenta.Text.Trim
                    dr("NoLibreta") = Me.txtDPFNoCert.Text.Trim
                    dr("PagoLibreta") = vPagoLibreta
                    ofrm.Factura.Tables("CADet_Facturas").Rows.Add(dr)

                    'Se agrega un item por cada detalle del pago al préstamo
                    drPrestamo = ofrm.Prestamo.Tables(0).Rows(0)
                    drB = ds.Tables("CAItemsFact").Rows(0)
                    bAgrega = True
                    vMontoItem = vPago

                    If bAgrega = True Then
                        x += 1
                        drC = ofrm.Factura.Tables("CADet_Facturas").NewRow
                        drC("Correlativo") = x
                        drC("TipoMov") = CInt(vTipo)
                        drC("CodItem") = drB("CodItem")
                        drC("Descripcion") = drB("Descripcion")
                        drC("Cantidad") = 1
                        drC("TipoItem") = drB("Tipo_Item")
                        drC("Monto_Pago") = 0
                        If drB("NoAplicaGravado") = "N" Then
                            If drB("Gravado") = "S" Then
                                drC("SubTotal_Gravado") = Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                'drC("SubTotal_Gravado") = Format(vMontoItem, "#,###,##0.00")
                                drC("SubTotal_Exento") = 0
                                drC("SubTotal_SIva") = 0
                                drC("Total_Iva") = Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                'drC("Total_Iva") = Format(vMontoItem * oApp.PorcentajeIVA, "#,###,##0.00")
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'drC("Total_Vta") = Format(vMontoItem + (vMontoItem * oApp.PorcentajeIVA), "#,###,##0.00")
                                'Totales para encabezado Factura
                                ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                'ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                'ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem * oApp.PorcentajeIVA, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            ElseIf drB("Gravado") = "N" Then
                                drC("SubTotal_Gravado") = 0
                                drC("SubTotal_Exento") = Format(vMontoItem, "#,###,##0.00")
                                drC("SubTotal_SIva") = 0
                                drC("Total_Iva") = 0
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'Totales para encabezado Factura
                                ofrm.vTotalNoGravado = ofrm.vTotalNoGravado + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            End If
                        Else
                            drC("SubTotal_Gravado") = 0
                            drC("SubTotal_Exento") = 0
                            drC("SubTotal_SIva") = Format(vMontoItem, "#,###,##0.00")
                            drC("Total_Iva") = 0
                            drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                            'Totales para encabezado Factura
                            ofrm.vTotalSIva = ofrm.vTotalSIva + Format(vMontoItem, "#,###,##0.00")
                            ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                        End If
                        drC("Mes") = Date.Now.Month
                        drC("Annio") = Fecha.Date.Year
                        drC("Observacion") = Me.txtObservacion.Text.Trim
                        drC("CodTipo") = Me.txtDPFCodTipoAhorro.Text.Trim
                        drC("NoCuenta") = Me.txtDPFNoCuenta.Text.Trim
                        drC("NoLibreta") = Me.txtDPFNoCert.Text.Trim
                        drC("PagoLibreta") = ""
                        ofrm.Factura.Tables("CADet_Facturas").Rows.Add(drC)
                    End If
                    bAgrega = False

                    ofrm.txtTotalFactura.Value = ofrm.vTotalFactura

                    'Si el movimiento es Documento x Cobrar o Si el movimiento es Protesto No Saneado o Si el movimiento es Protesto Saneado
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Cobranza Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza Then
                    If Me.txtCodPrestamoCxC.Text.Trim = "" Then
                        MsgBox("Debe digitar el Código de Préstamo.", MsgBoxStyle.Critical, "Módulo Caja")
                        Exit Sub
                    End If
                    oCaja = New wrCaja.wsLibCaja
                    ds = oCaja.ObtenerListaItems("*", "idApp=10 and Tipo_Item<>'P' and TipoMovimiento='" & ofrm.Item("TipoMovimiento") & "'", sUsuario, sPassword, sSucursal)
                    dr = ofrm.Factura.Tables("CADet_Facturas").NewRow
                    x = ofrm.Factura.Tables("CADet_Facturas").Rows.Count + 1
                    dr("Correlativo") = x
                    dr("TipoMov") = CInt(vTipo)
                    dr("CodItem") = Me.txtCodItem.Text.Trim
                    dr("Descripcion") = Me.txtItem.Text.Trim
                    dr("Cantidad") = 1
                    dr("TipoItem") = "P"
                    dr("Monto_Pago") = Me.txtPago.Value
                    dr("SubTotal_Gravado") = 0
                    dr("SubTotal_Exento") = 0
                    dr("SubTotal_SIva") = 0
                    dr("Total_Iva") = 0
                    dr("Total_Vta") = 0
                    dr("Mes") = Date.Now.Month
                    dr("Annio") = Fecha.Date.Year
                    dr("Observacion") = Me.txtObservacion.Text.Trim
                    dr("CodTipo") = Me.txtCodTipoCreditoCxC.Text.Trim
                    dr("NoCuenta") = Me.txtCodPrestamoCxC.Text.Trim
                    dr("NoLibreta") = ""
                    ofrm.Factura.Tables("CADet_Facturas").Rows.Add(dr)

                    drPrestamo = ofrm.Prestamo.Tables(0).Rows(0)
                    ds.Tables("CAItemsFact").Select("", "Orden")
                    For Each drB In ds.Tables("CAItemsFact").Rows
                        Select Case Convert.ToString(drB("Tipo_Item"))
                            Case Is = "C" ' Capital
                                If (oCaja.Redondear(drPrestamo("Saldo_Capital"), 2) > 0) And vPago > 0 Then
                                    bAgrega = True
                                    If vPago > oCaja.Redondear(drPrestamo("Saldo_Capital"), 2) Then
                                        ofrm.vPagoCapital = oCaja.Redondear(drPrestamo("Saldo_Capital"), 2)
                                        vPago = vPago - oCaja.Redondear(drPrestamo("Saldo_Capital"), 2)
                                        vMontoItem = ofrm.vPagoCapital
                                    Else
                                        ofrm.vPagoCapital = vPago
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoCapital
                                        Exit Select
                                    End If
                                ElseIf (Me.c1nSaldoCtasOrden.Value > 0) And vPago > 0 Then
                                    bAgrega = True
                                    If vPago > oCaja.Redondear(Me.c1nSaldoCtasOrden.Value, 2) Then
                                        ofrm.vPagoCapital = oCaja.Redondear(Me.c1nSaldoCtasOrden.Value, 2)
                                        vPago = vPago - oCaja.Redondear(Me.c1nSaldoCtasOrden.Value, 2)
                                        vMontoItem = ofrm.vPagoCapital
                                    Else
                                        ofrm.vPagoCapital = vPago
                                        vPago = 0
                                        vMontoItem = ofrm.vPagoCapital
                                        Exit Select
                                    End If
                                End If
                        End Select

                        If bAgrega = True Then
                            x += 1
                            drC = ofrm.Factura.Tables("CADet_Facturas").NewRow
                            drC("Correlativo") = x
                            drC("TipoMov") = CInt(vTipo)
                            drC("CodItem") = drB("CodItem")
                            drC("Descripcion") = drB("Descripcion")
                            drC("Cantidad") = 1
                            drC("TipoItem") = drB("Tipo_Item")
                            drC("Monto_Pago") = 0
                            If drB("NoAplicaGravado") = "N" Then
                                If drB("Gravado") = "S" Then
                                    drC("SubTotal_Gravado") = Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                    drC("SubTotal_Exento") = 0
                                    drC("SubTotal_SIva") = 0
                                    drC("Total_Iva") = Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                    drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                    drC("SubTotal_SIva") = 0
                                    ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                    ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                    ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                                ElseIf drB("Gravado") = "N" Then
                                    drC("SubTotal_Gravado") = 0
                                    drC("SubTotal_Exento") = Format(vMontoItem, "#,###,##0.00")
                                    drC("SubTotal_SIva") = 0
                                    drC("Total_Iva") = 0
                                    drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                    ofrm.vTotalNoGravado = ofrm.vTotalNoGravado + Format(vMontoItem, "#,###,##0.00")
                                    ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                                End If
                            Else
                                drC("SubTotal_Gravado") = 0
                                drC("SubTotal_Exento") = 0
                                drC("SubTotal_SIva") = Format(vMontoItem, "#,###,##0.00")
                                drC("Total_Iva") = 0
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalSIva = ofrm.vTotalSIva + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            End If
                            drC("Mes") = Date.Now.Month
                            drC("Annio") = Fecha.Date.Year
                            drC("Observacion") = Me.txtObservacion.Text.Trim
                            drC("CodTipo") = Me.txtCodTipoCreditoCxC.Text.Trim
                            drC("NoCuenta") = Me.txtCodPrestamoCxC.Text.Trim
                            drC("NoLibreta") = ""
                            drC("PagoLibreta") = ""
                            ofrm.Factura.Tables("CADet_Facturas").Rows.Add(drC)
                        End If
                        bAgrega = False
                    Next
                    ofrm.txtTotalFactura.Value = ofrm.vTotalFactura


                    'Si el movimiento es Ingreso Asociado
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.IngresoAsociados Then
                    If ofrm.txtCuenta.Text.Trim = "" Then
                        MsgBox("No hay Código de Cuenta Contable relacionado.", MsgBoxStyle.Critical, "Módulo Caja")
                        Exit Sub
                    End If

                    '--------------------------------------------------------------------
                    'Lista de Items Facturables para Préstamos
                    oCaja = New wrCaja.wsLibCaja
                    ds = oCaja.ObtenerListaItems("*", "idApp=1 and Tipo_Item<>'P' and TipoMovimiento='" & ofrm.Item("TipoMovimiento") & "'", sUsuario, sPassword, sSucursal)
                    '--------------------------------------------------------------------
                    'Nueva Linea para Detalle de Factura
                    dr = ofrm.Factura.Tables("CADet_Facturas").NewRow
                    x = ofrm.Factura.Tables("CADet_Facturas").Rows.Count + 1
                    dr("Correlativo") = x
                    dr("TipoMov") = CInt(vTipo)
                    dr("CodItem") = Me.txtCodItem.Text.Trim
                    dr("Descripcion") = Me.txtItem.Text.Trim
                    dr("Cantidad") = 1
                    dr("TipoItem") = "P"
                    dr("Monto_Pago") = Me.txtPago.Value
                    dr("SubTotal_Gravado") = 0
                    dr("SubTotal_Exento") = 0
                    dr("SubTotal_SIva") = 0
                    dr("Total_Iva") = 0
                    dr("Total_Vta") = 0
                    dr("Mes") = Date.Now.Month
                    dr("Annio") = Fecha.Date.Year
                    dr("Observacion") = Me.txtObservacion.Text.Trim
                    dr("CodTipo") = ""
                    dr("NoCuenta") = ofrm.txtCuenta.Text.Trim
                    dr("NoLibreta") = ""
                    ofrm.Factura.Tables("CADet_Facturas").Rows.Add(dr)

                    'Se agrega un item por cada detalle del pago 

                    drB = ds.Tables("CAItemsFact").Rows(0)
                    bAgrega = True
                    'vMontoItem = vPago

                    For Each row As DataRow In ds.Tables(0).Rows


                        'Se agrega un item por cada detalle del pago 


                        vMontoItem = row("valor") 'vPago

                        If bAgrega = True Then
                            x += 1
                            drC = ofrm.Factura.Tables("CADet_Facturas").NewRow
                            drC("Correlativo") = x
                            drC("TipoMov") = CInt(vTipo)
                            drC("CodItem") = row("CodItem")
                            drC("Descripcion") = row("Descripcion")
                            drC("Cantidad") = 1
                            drC("TipoItem") = row("Tipo_Item")
                            drC("Monto_Pago") = row("valor")
                            If row("NoAplicaGravado") = "N" Then
                                If row("Gravado") = "S" Then
                                    drC("SubTotal_Gravado") = Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                    'drC("SubTotal_Gravado") = Format(vMontoItem, "#,###,##0.00")
                                    drC("SubTotal_Exento") = 0
                                    drC("SubTotal_SIva") = 0
                                    drC("Total_Iva") = Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                    'drC("Total_Iva") = Format(vMontoItem * oApp.PorcentajeIVA, "#,###,##0.00")
                                    drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                    'drC("Total_Vta") = Format(vMontoItem + (vMontoItem * oApp.PorcentajeIVA), "#,###,##0.00")
                                    'Totales para encabezado Factura
                                    ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                    'ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem, "#,###,##0.00")
                                    ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                    'ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem * oApp.PorcentajeIVA, "#,###,##0.00")
                                    ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                                ElseIf row("Gravado") = "N" Then
                                    drC("SubTotal_Gravado") = 0
                                    drC("SubTotal_Exento") = Format(vMontoItem, "#,###,##0.00")
                                    drC("SubTotal_SIva") = 0
                                    drC("Total_Iva") = 0
                                    drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                    'Totales para encabezado Factura
                                    ofrm.vTotalNoGravado = ofrm.vTotalNoGravado + Format(vMontoItem, "#,###,##0.00")
                                    ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                                End If
                            Else
                                drC("SubTotal_Gravado") = 0
                                drC("SubTotal_Exento") = 0
                                drC("SubTotal_SIva") = Format(vMontoItem, "#,###,##0.00")
                                drC("Total_Iva") = 0
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'Totales para encabezado Factura
                                ofrm.vTotalSIva = ofrm.vTotalSIva + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            End If
                            drC("Mes") = Date.Now.Month
                            drC("Annio") = Fecha.Date.Year
                            drC("Observacion") = Me.txtObservacion.Text.Trim
                            drC("CodTipo") = ""
                            drC("NoCuenta") = ofrm.txtCuenta.Text.Trim
                            drC("NoLibreta") = ""
                            drC("PagoLibreta") = ""
                            ofrm.Factura.Tables("CADet_Facturas").Rows.Add(drC)
                        End If
                    Next
                    bAgrega = False

                    ofrm.txtTotalFactura.Value = ofrm.vTotalFactura



                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Generico Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then

                    'If ofrm.txtCuenta.Text.Trim = "" Then
                    '    MsgBox("No hay Código de Cuenta Contable relacionado.", MsgBoxStyle.Critical, "Módulo Caja")
                    '    Exit Sub
                    'End If

                    '--------------------------------------------------------------------
                    'Lista de Items Facturables para Préstamos
                    oCaja = New wrCaja.wsLibCaja
                    ds = oCaja.ObtenerListaItems("*", "Tipo_Item<>'P' and TipoMovimiento='" & ofrm.Item("TipoMovimiento") & "'", sUsuario, sPassword, sSucursal)
                    '--------------------------------------------------------------------
                    'Nueva Linea para Detalle de Factura
                    dr = ofrm.Factura.Tables("CADet_Facturas").NewRow
                    x = ofrm.Factura.Tables("CADet_Facturas").Rows.Count + 1
                    dr("Correlativo") = x
                    dr("TipoMov") = CInt(vTipo)
                    dr("CodItem") = Me.txtCodItem.Text.Trim
                    dr("Descripcion") = Me.txtItem.Text.Trim
                    dr("Cantidad") = 1
                    dr("TipoItem") = "P"
                    dr("Monto_Pago") = Me.txtPago.Value
                    dr("SubTotal_Gravado") = 0
                    dr("SubTotal_Exento") = 0
                    dr("SubTotal_SIva") = 0
                    dr("Total_Iva") = 0
                    dr("Total_Vta") = 0
                    dr("Mes") = Date.Now.Month
                    dr("Annio") = Fecha.Date.Year
                    dr("Observacion") = Me.txtObservacion.Text.Trim
                    dr("CodTipo") = ""
                    dr("NoCuenta") = ofrm.txtCuenta.Text.Trim
                    dr("NoLibreta") = ""
                    ofrm.Factura.Tables("CADet_Facturas").Rows.Add(dr)

                    'Se agrega un item por cada detalle del pago 
                    drB = ds.Tables("CAItemsFact").Rows(0)
                    bAgrega = True
                    vMontoItem = vPago

                    If bAgrega = True Then
                        x += 1
                        drC = ofrm.Factura.Tables("CADet_Facturas").NewRow
                        drC("Correlativo") = x
                        drC("TipoMov") = CInt(vTipo)
                        drC("CodItem") = drB("CodItem")
                        drC("Descripcion") = drB("Descripcion")
                        drC("Cantidad") = 1
                        drC("TipoItem") = drB("Tipo_Item")
                        drC("Monto_Pago") = 0
                        If drB("NoAplicaGravado") = "N" Then
                            If drB("Gravado") = "S" Then
                                drC("SubTotal_Gravado") = Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                drC("SubTotal_Exento") = 0
                                drC("SubTotal_SIva") = 0
                                drC("Total_Iva") = Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'Totales para encabezdo Factura
                                ofrm.vTotalGravado = ofrm.vTotalGravado + Format(vMontoItem / (1 + oApp.PorcentajeIVA), "#,###,##0.00")
                                ofrm.vTotalIVA = ofrm.vTotalIVA + Format(vMontoItem - (vMontoItem / (1 + oApp.PorcentajeIVA)), "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            ElseIf drB("Gravado") = "N" Then
                                drC("SubTotal_Gravado") = 0
                                drC("SubTotal_Exento") = Format(vMontoItem, "#,###,##0.00")
                                drC("SubTotal_SIva") = 0
                                drC("Total_Iva") = 0
                                drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                                'Totales para encabezdo Factura
                                ofrm.vTotalNoGravado = ofrm.vTotalNoGravado + Format(vMontoItem, "#,###,##0.00")
                                ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                            End If
                        Else
                            drC("SubTotal_Gravado") = 0
                            drC("SubTotal_Exento") = 0
                            drC("SubTotal_SIva") = Format(vMontoItem, "#,###,##0.00")
                            drC("Total_Iva") = 0
                            drC("Total_Vta") = Format(vMontoItem, "#,###,##0.00")
                            'Totales para encabezado Factura
                            ofrm.vTotalSIva = ofrm.vTotalSIva + Format(vMontoItem, "#,###,##0.00")
                            ofrm.vTotalFactura = ofrm.vTotalFactura + Format(vMontoItem, "#,###,##0.00")
                        End If
                        drC("Mes") = Date.Now.Month
                        drC("Annio") = Fecha.Date.Year
                        drC("Observacion") = Me.txtObservacion.Text.Trim
                        dr("CodTipo") = ""
                        drC("NoCuenta") = ofrm.txtCuenta.Text.Trim
                        drC("NoLibreta") = ""
                        drC("PagoLibreta") = ""
                        ofrm.Factura.Tables("CADet_Facturas").Rows.Add(drC)
                    End If
                    bAgrega = False

                    ofrm.txtTotalFactura.Value = ofrm.vTotalFactura

                End If
                'ElseIf Me.AccionDetalle = Caja.clsCAFactura.TipoAccionFacturas.EliminarLinea Then
            ElseIf Me.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.EliminarLinea Then

            End If
            Me.txtCodItem.Text = ""
            Me.txtItem.Text = ""
            Me.txtPago.Value = 0
            'Me.AccionDetalle = Caja.clsCAFactura.TipoAccionFacturas.Ninguna
            'LUIS ALVARENGA

            If Me.rbTerceraPersona.Checked = True Then
                If Me.txtNombreTercero.Text.Length > 0 And Me.txtNoDocTerceros.Text.Length Then
                    lblNombre.Text = "NOMBRE DE DEPOSITANTE:"
                    lblNoDoc.Text = "NÚMERO DE DOCUMENTO:"

                    ofrm.DuiTercero = txtNombreTercero.Text
                    ofrm.NombreTercero = txtNoDocTerceros.Text
                Else
                    lblNoDoc.Text = ""
                    lblNombre.Text = ""

                    ofrm.DuiTercero = txtNombreTercero.Text
                    ofrm.NombreTercero = txtNoDocTerceros.Text
                End If
            ElseIf Me.rbTitular.Checked = True Then
                If Me.txtNombreTercero.Text.Length > 0 And Me.txtNoDocTerceros.Text.Length Then
                    lblNombre.Text = "NOMBRE TITULAR"
                    lblNoDoc.Text = "NÚMERO DE DOCUMENTO"

                    ofrm.DuiTercero = txtNombreTercero.Text
                    ofrm.NombreTercero = txtNoDocTerceros.Text
                Else
                    lblNoDoc.Text = ""
                    lblNombre.Text = ""

                    ofrm.DuiTercero = txtNombreTercero.Text
                    ofrm.NombreTercero = txtNoDocTerceros.Text
                End If
            Else
                lblNoDoc.Text = ""
                lblNombre.Text = ""

                ofrm.DuiTercero = txtNombreTercero.Text
                ofrm.NombreTercero = txtNoDocTerceros.Text
            End If


            Me.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.Ninguna
            Me.Dispose()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDPFNoCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtDPFNoCuenta.TextChanged

    End Sub

    Private Sub txtCodItem_TextChanged(sender As Object, e As EventArgs) Handles txtCodItem.TextChanged

    End Sub

    Private Sub btnCancelarLin1_Click(sender As Object, e As EventArgs) Handles btnCancelarLin1.Click
        Me.Dispose()
    End Sub

    Public Sub CargaDatosAhorro()

        Dim sTexto As String, Fila As DataRowCollection, vCodTipoAhorro As String, pCodPlanAhorro As String, oCaja As New wrCaja.wsLibCaja
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow

        Try
            oAh = New wrAhorro.wsLibAhorro
            If vDui.Trim = "" Then Exit Sub

            sTexto = Me.txtNoCuenta.Text
            If sTexto = "" Then

            ElseIf sTexto <> "" Then
                'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Ahorro Then
                If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                    ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaApertura,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,Estado,Pignorado,NoLibreta,Observacion", " NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and Dui='" & (vDui) & "' and Estado<>'C' and Estado<>'B'", "NoCuenta", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                    ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaApertura,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,Estado,Pignorado,NoLibreta,Observacion", " NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and Dui='" & (vDui) & "' and Estado<>'C' and Estado<>'B'", "NoCuenta", sUsuario, sPassword, sSucursal)
                End If

                ofrm.Prestamo = ds
                dr = ds.Tables(0).Rows(0)
                Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
                ofrm.pNoCuenta = Me.txtNoCuenta.Text.Trim
                vCodTipoAhorro = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
                ofrm.pCodTipoAhorro = vCodTipoAhorro

                '=============================================================================================================================
                '=============================================================================================================================
                '25/06/2013 Javier Martinez
                'Recuperamos la cuenta contable  del tipo de ahorro seleccionado
                'para poder enlazarlo al item facturable correspondiente.
                Dim DtsCta As New DataSet
                DtsCta = oAh.ConsultarTipoAhorro("IdCuenta", " CodTipoAhorro ='" & vCodTipoAhorro & "' ", "", sUsuario, sPassword, sSucursal)
                If DtsCta.Tables(0).Rows.Count > 0 Then
                    IdCuenta = DtsCta.Tables(0).Rows(0).Item(0)
                End If
                '=============================================================================================================================
                '=============================================================================================================================

                Me.txtNoLibreta.Text = IIf(IsDBNull(dr("NoLibreta")), "", dr("NoLibreta"))
                ofrm.pNoLibreta = Me.txtNoLibreta.Text.Trim
                Me.txtCodTipoAhorro.Text = vCodTipoAhorro
                pFechaApertura = IIf(IsDBNull(dr("FechaApertura")), Now, dr("FechaApertura"))
                ofrm.pMensajeCajas = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
                Me.txtMensaje.Text = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
                Me.txtSaldoCtaAhorro.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDisponible_CuentaAhorro")), 0, dr("SaldoDisponible_CuentaAhorro")), 2)
                Me.txtSaldoPendiente.Text = 0
                Me.txtCuotasNoPagadas.Text = 0
                Me.c1nCuota.Value = 0
                If Mid(vCodTipoAhorro, 1, 1) = "5" Then 'Ahorro Programado
                    Me.c1nCuota.Value = oCaja.Redondear(IIf(IsDBNull(dr("Cuota")), 0, dr("Cuota")), 2)
                    Fila = oAh.ConsultarPlanAhorro("CodPlanAhorro", "CodTipoAhorro='" & vCodTipoAhorro & "' and NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", "CodPlanAhorro", sUsuario, sPassword, sSucursal).Tables("AhPlanAhorro").Rows()
                    If Fila.Count > 0 Then
                        If Not (Fila.Item(0)(0) Is DBNull.Value) Then
                            pCodPlanAhorro = CStr(Fila.Item(0)("CodPlanAhorro"))
                        End If
                        Fila = oAh.ConsultarDet_PlanAhorro("CuotasNoPagadas", "Cancelada='N' and CodPlanAhorro='" & pCodPlanAhorro & "' and FechaCuota<='" & vFecha.ToShortDateString & "'", "CodPlanAhorro", sUsuario, sPassword, sSucursal).Tables("AhDet_PlanAhorro").Rows()
                        If Fila.Count > 0 Then
                            If Not (Fila.Item(0)(0) Is DBNull.Value) Then
                                Me.txtCuotasNoPagadas.Text = CStr(Fila.Item(0)("CuotasNoCanceladas"))
                                Me.txtSaldoPendiente.Text = Val(Me.txtCuotasNoPagadas.Text) * Val(Me.c1nCuota.Value)
                                Me.lblDiaCuota.Text = CStr(Fila.Item(0)("DiaPago")) & " de cada mes"
                            End If
                        End If
                    End If
                End If
                ' Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            'Me.gbItem.Enabled = False
            Me.txtNoCuenta.Text = ""
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: NO EXISTE EL NO. DE CUENTA --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub CargaDatosDPF()
        Dim sTexto As String, Fila As DataRowCollection, vCodTipoAhorro As String, pCodPlanAhorro As String, oCaja As New wrCaja.wsLibCaja
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
        Try
            oAh = New wrAhorro.wsLibAhorro
            If vDui.Trim = "" Then Exit Sub
            '======================================
            '03/10/2013 Javier Escobar
            'Modificacíon error en objeto txt
            'sTexto = Me.txtnocuenta.text
            sTexto = Me.txtDPFNoCuenta.Text
            '======================================

            If sTexto = "" Then

            ElseIf sTexto <> "" Then
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,IdCertificadoDPF,MontoApertura as Monto,Estado,Pignorado,Observacion", "NoCuenta='" & Me.txtDPFNoCuenta.Text.Trim & "' and Dui='" & vDui & "'  and Estado='D'", "NoCuenta", sUsuario, sPassword, sSucursal)
                ofrm.Prestamo = ds
                dr = ds.Tables(0).Rows(0)
                Me.txtDPFNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
                ofrm.pNoCuenta = Me.txtDPFNoCuenta.Text.Trim
                vCodTipoAhorro = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
                ofrm.pCodTipoAhorro = vCodTipoAhorro
                Me.txtDPFCodTipoAhorro.Text = vCodTipoAhorro
                Me.txtDPFNoCert.Text = IIf(IsDBNull(dr("IdCertificadoDPF")), "", dr("IdCertificadoDPF"))
                Me.txtDPFMonto.Text = oCaja.Redondear(IIf(IsDBNull(dr("Monto")), 0, dr("Monto")), 2)
                ofrm.pMensajeCajas = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
                Me.txtMensaje.Text = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
                Me.c1nDPFSaldo.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDisponible_CuentaAhorro")), 0, dr("SaldoDisponible_CuentaAhorro")), 2)
                '  Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            'Me.gbItem.Enabled = False
            Me.txtDPFNoCuenta.Text = ""
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: NO EXISTE EL NO. DE CUENTA --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CargaBanco()
        Dim oAsoc As wrBancos.wsLibBancos, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrBancos.wsLibBancos
            ds = oAsoc.ObtenerBanco("*", "IdBanco='" & Me.txtBanco.Text.Trim & "'", "IdBanco", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtBanco.Text = dr("IdBanco")
                Me.lblBanco.Text = dr("Nom_Banco")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Bancos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CargaDatosPrestamoCxC()
        Dim sTexto As String, drTmp As DataRow, dsTmp As New DataSet
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, oCaja As New wrCaja.wsLibCaja, oCred As New wrCredito.wsLibCred
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.CargaDatosPrestamoCB(Me.txtCodPrestamoCxC.Text.Trim, sUsuario, sPassword, sSucursal)
            If ds.Tables("Prestamo").Rows.Count > 0 Then
                dr = ds.Tables("Prestamo").Rows(0)
                If IIf(IsDBNull(dr("Baja")), 0, dr("Baja")) = "0" Then
                    ' Me.gbItem.Enabled = False
                    Me.txtCodPrestamoCxC.Text = ""
                    Exit Sub
                End If
                Me.txtCodPrestamoCxC.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))

                dsTmp = oCred.ConsultarGestoresxCredito("*", "pr.CodPrestamo='" & Me.txtCodPrestamoCxC.Text.Trim & "' and pr.Estado='A'", "*", sUsuario, sPassword, sSucursal)
                If dsTmp.Tables(0).Rows.Count > 0 Then
                    drTmp = dsTmp.Tables(0).Rows(0)
                    Me.txtDespacho.Text = IIf(IsDBNull(drTmp("Nombre")), 0, drTmp("Nombre"))
                End If

                ofrm.pNoCuenta = Me.txtCodPrestamoCxC.Text.Trim
                ofrm.pCodTipoAhorro = ""
                If Not IsDBNull(dr("Tipo")) Then
                    Me.txtEstado.Text = dr("Tipo")
                Else
                    Me.txtEstado.Text = ""
                End If
                Me.txtCodTipoCreditoCxC.Text = IIf(IsDBNull(dr("CodTipoCredito")), "", dr("CodTipoCredito"))
                'Verificar si es caso especial para filtrar item facturable que aplica:
                If IIf(IsDBNull(dr("CasoEspecial")), "0", dr("CasoEspecial")) = "1" Then
                    pCE = "1"
                    pItemCE = IIf(IsDBNull(dr("CodItem")), "", dr("CodItem"))
                Else
                    pCE = "0"
                    pItemCE = ""
                End If
                Me.c1nMontoCxC.Value = oCaja.Redondear(IIf(IsDBNull(dr("Monto")), 0, dr("Monto")), 2)
                ofrm.pMensajeCajas = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                Me.txtMensaje.Text = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                If Not IsDBNull(dr("FechaPrimeraCuota")) Then Me.txtFechaCxC.Text = dr("FechaPrimeraCuota")
                Me.c1nNoCuotasCxC.Value = IIf(IsDBNull(dr("CuotaTotal")), 0, dr("CuotaTotal"))
                Me.c1nSaldoCxC.Value = oCaja.Redondear(IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital")), 2)
                Me.c1nSaldoCtasOrden.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoCuentasOrden")), 0, dr("SaldoCuentasOrden")), 2)
                'Me.gbItem.Enabled = True
            Else
                'Me.gbItem.Enabled = False
                Me.txtCodPrestamoCxC.Text = ""
            End If
        Catch ex As Exception
            txtCodPrestamoCxC.Text = ""
            ' Me.gbItem.Enabled = False
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPrestamoCxC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodPrestamoCxC.Validating
        CargaDatosPrestamoCxC()
        Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, dr As DataRow, pEstadoCC As String
        Select Case Me.txtEstado.Text.Trim
            Case "S" 'S: Documento Saneado  
                pEstadoCC = "4"
            Case "C" ' C: Documento x Cobrar
                pEstadoCC = "2"
            Case "P" 'P: Documento en Protesto
                pEstadoCC = "3"
            Case "N" 'N: Cartera Normal
                pEstadoCC = "1"
        End Select
        If pCE = "1" Then
            ds = oCaja.ObtenerListaItems("*", "CodItem='" & pItemCE.Trim & "' and IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "'", sUsuario, sPassword, sSucursal)
        Else
            ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and codItem = '" & codItemRubro & "' /* and IdApp=10 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "' and Estado='" & pEstadoCC & "' */", sUsuario, sPassword, sSucursal)
        End If
        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows.Count > 1 Then
                dr = ds.Tables(0).Rows(1)
                Me.txtCodItem.Text = dr("CodItem")
            Else
                dr = ds.Tables(0).Rows(0)
                Me.txtCodItem.Text = dr("CodItem")
            End If
        End If
        txtCodItem_Validating(sender, e)
        Me.txtPago.Focus()
    End Sub

    Private Sub txtBanco_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBanco.Validating
        CargaBanco()
    End Sub

    Private Sub CargaDatosDPFCancelado()
        Dim Fila As DataRowCollection, vCodTipoAhorro As String, pCodPlanAhorro As String, oCaja As New wrCaja.wsLibCaja
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
        Try
            oAh = New wrAhorro.wsLibAhorro
            If vDui.Trim = "" Then Exit Sub
            ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,IdCertificadoDPF,MontoApertura as Monto,Estado,Pignorado,Observacion", "NoCuenta='" & Me.txtDPFNoCuenta.Text.Trim & "' and Dui='" & vDui & "' ", "NoCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Prestamo = ds
            dr = ds.Tables(0).Rows(0)
            Me.txtDPFNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
            ofrm.pNoCuenta = Me.txtDPFNoCuenta.Text.Trim
            ofrm.pMensajeCajas = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
            Me.txtMensaje.Text = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
            vCodTipoAhorro = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
            Me.txtDPFCodTipoAhorro.Text = vCodTipoAhorro
            ofrm.pCodTipoAhorro = vCodTipoAhorro
            Me.txtDPFNoCert.Text = IIf(IsDBNull(dr("IdCertificadoDPF")), "", dr("IdCertificadoDPF"))
            Me.txtDPFMonto.Text = oCaja.Redondear(IIf(IsDBNull(dr("Monto")), 0, dr("Monto")), 2)
            Me.c1nDPFSaldo.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDisponible_CuentaAhorro")), 0, dr("SaldoDisponible_CuentaAhorro")), 2)
            Me.txtSaldoCtaAhorro.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDisponible_CuentaAhorro")), 0, dr("SaldoDisponible_CuentaAhorro")), 2)
            ' Me.gbItem.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: NO EXISTE EL NO. DE CUENTA --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargaDatosCuentaCancelada()
        Dim Fila As DataRowCollection, vCodTipoAhorro As String, pCodPlanAhorro As String, oCaja As New wrCaja.wsLibCaja
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
        Try
            oAh = New wrAhorro.wsLibAhorro
            If vDui.Trim = "" Then Exit Sub

            'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Ahorro Then
            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,Estado,Pignorado,Observacion", " NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and Dui='" & (vDui) & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,Estado,Pignorado,Observacion", "NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and Dui='" & (vDui) & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
            End If

            ofrm.Prestamo = ds
            dr = ds.Tables(0).Rows(0)
            Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
            ofrm.pNoCuenta = Me.txtNoCuenta.Text.Trim
            ofrm.pMensajeCajas = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
            Me.txtMensaje.Text = IIf(IsDBNull(dr("Observacion")), "", dr("Observacion"))
            vCodTipoAhorro = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
            Me.txtCodTipoAhorro.Text = vCodTipoAhorro
            ofrm.pCodTipoAhorro = vCodTipoAhorro
            Me.txtSaldoCtaAhorro.Value = oCaja.Redondear(IIf(IsDBNull(dr("SaldoDisponible_CuentaAhorro")), 0, dr("SaldoDisponible_CuentaAhorro")), 2)
            Me.txtSaldoPendiente.Text = 0
            Me.txtCuotasNoPagadas.Text = 0
            Me.c1nCuota.Value = 0
            If Mid(vCodTipoAhorro, 1, 1) = sifLib.Ahorro.clsAhorros.tiposAhorro.programado Then 'Ahorro Programado
                Me.c1nCuota.Value = oCaja.Redondear(IIf(IsDBNull(dr("Cuota")), 0, dr("Cuota")), 2)
                Fila = oAh.ConsultarPlanAhorro("CodPlanAhorro", "CodTipoAhorro='" & vCodTipoAhorro & "' and NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", "CodPlanAhorro", sUsuario, sPassword, sSucursal).Tables("AhPlanAhorro").Rows()
                If Fila.Count > 0 Then
                    If Not (Fila.Item(0)(0) Is DBNull.Value) Then
                        pCodPlanAhorro = CStr(Fila.Item(0)("CodPlanAhorro"))
                    End If
                    Fila = oAh.ConsultarDet_PlanAhorro("CuotasNoPagadas", "Cancelada='N' and CodPlanAhorro='" & pCodPlanAhorro & "' and FechaCuota<='" & vFecha.ToShortDateString & "'", "CodPlanAhorro", sUsuario, sPassword, sSucursal).Tables("AhDet_PlanAhorro").Rows()
                    If Fila.Count > 0 Then
                        If Not (Fila.Item(0)(0) Is DBNull.Value) Then
                            Me.txtCuotasNoPagadas.Text = CStr(Fila.Item(0)("CuotasNoCanceladas"))
                            Me.txtSaldoPendiente.Text = Val(Me.txtCuotasNoPagadas.Text) * Val(Me.c1nCuota.Value)
                            Me.lblDiaCuota.Text = CStr(Fila.Item(0)("DiaPago")) & " de cada mes"
                        End If
                    End If
                End If
            End If
            ' Me.gbItem.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: NO EXISTE EL NO. DE CUENTA --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub EstadoCuentaCancelada()
        Me.btnCancelarLin1.Enabled = False
        Me.txtPago.Value = Me.txtSaldoCtaAhorro.Value
        'Me.txtPago.ReadOnly = True
        Me.txtNoCuenta.Enabled = False
        'Me.txtCodItem.Enabled = False
        ofrm.vTotalFactura = 0
        ofrm.vTotalNoGravado = 0
        ofrm.vTotalGravado = 0
        ofrm.vTotalSIva = 0
        ofrm.vTotalIVA = 0
        ofrm.vPagoCapital = 0
        ofrm.vPagoInteres = 0
        ofrm.vPagoCapitalMora = 0
        ofrm.vPagoInteresMora = 0
        ofrm.vPagoSeguroDeuda = 0
        ofrm.vPagoSeguroDanios = 0
        ofrm.vPagoSeguroVida = 0
        ofrm.vPagoSeguroDesempleo = 0
        ofrm.vPagoAportacion = 0
        ofrm.vPagoAhorro = 0
        ofrm.vPagoComision = 0
        ofrm.vPagoOtros = 0
        vPago = 0
        vMontoItem = 0
    End Sub

    Private Sub frmMsDetCaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.lblInactiva.Visible = False
            '================================================
            '04/10/2013
            'Javier Escobar
            If vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Or vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Or vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                Me.btnImprimir1.Visible = True
            End If
            If vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Or vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.cuentaPorCobrar Then
                Me.btnImprimir1.Visible = False
            End If


            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Generico Then
                Dim oCaja As New wrCaja.wsLibCaja, dsT As New DataSet, dr As DataRow, ds As New Data.DataSet("Items"), sTexto As String
                dsT = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                If dsT.Tables(0).Rows.Count > 0 Then
                    dr = dsT.Tables(0).Rows(0)
                    Me.txtCodItem.Text = dr("CodItem")
                    oCaja = New wrCaja.wsLibCaja
                    sTexto = Me.txtCodItem.Text.Trim
                    If sTexto = "" Then
                    ElseIf sTexto <> "" Then
                        'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
                        If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                            'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Ahorro Then
                        ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "'", sUsuario, sPassword, sSucursal)
                            'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
                        ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=9 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                            'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
                        ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                            'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Cobranza Then
                        ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=10 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                            'ElseIf Me.vTipo = Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
                        ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.IngresoAsociados Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=12 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)


                        Else
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                        End If
                        dr = ds.Tables("CAItemsFact").Rows(0)
                        ofrm.Item = dr
                        Me.txtCodItem.Text = Trim(dr("CodItem"))
                        Me.txtItem.Text = Trim(dr("Descripcion"))
                        ofrm.txtCuenta.Value = Trim(dr("IdCuentaC"))
                        If ofrm.txtCuenta.Text.Trim = "" Then ofrm.txtCuenta.Value = Trim(dr("IdCuentaA"))
                        If Not dr("Valor") Is DBNull.Value Then
                            'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                            Else
                                Me.txtPago.Value = oCaja.Redondear(dr("Valor"), 2)
                            End If
                        Else
                            'If Me.vTipo = Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                            Else
                                Me.txtPago.Value = 0
                            End If
                        End If
                        vTipoMov = Trim(dr("TipoMovimiento"))
                    End If
                    Me.txtPago.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla CAItemsFact - " & "System Error: No Existe el Item digitado --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtPago_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPago.LostFocus
        If vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.cuentaPorCobrar Then
            If txtSaldoCxC.Text < txtPago.Value Then
                MetroFramework.MetroMessageBox.Show(Me, "Monto a pagar no puede ser mayor que saldo pendiente.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                txtPago.Focus()
            End If
        End If
        If Me.txtPago.Value >= 571.43 Then
            If vTipoDoc.Equals("D") Then
                MsgBox("Por favor ingresar DUI y nombre del depositante.", MsgBoxStyle.Information, "Módulo - Caja")
            End If
        End If
    End Sub
End Class