Imports CrystalDecisions.CrystalReports.Engine
Public Class frmMsDetCaFactura
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private vPago As Decimal, vMontoItem As Decimal, pFechaApertura As Date
    'Private vDui As String, ofrm As frmCAFactura, vTipo As AlcalaLibs.Caja.clsCAFactura.TipoMovimiento, vFecha As Date, vRubro As String, vTipoMov As String, vTipoDoc As String
    Private vDui As String, ofrm As frmCAFactura, vTipo As sifLib.Caja.clsCAFacturas.TipoMovimiento, vFecha As Date, vRubro As String, vTipoMov As String, vTipoDoc As String
    Private vPagoLibreta As String, vFechaOtorgamiento As Date
    'Private vAccionDetalle As AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas, vValDiv As Double, pCE As String, pItemCE As String
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
    Dim vCodItemRubro As String


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
    Friend WithEvents txtNoLibreta As System.Windows.Forms.TextBox
    Friend WithEvents lblNoLibreta As System.Windows.Forms.Label
    Friend WithEvents txtSaldoPendiente As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents c1nCuota As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chkLibreta As System.Windows.Forms.CheckBox
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
    Friend WithEvents gbItem As System.Windows.Forms.GroupBox
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
        Me.txtCuotasNoPagadas = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.gbCheque = New System.Windows.Forms.GroupBox()
        Me.txtPaguese = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtGirador = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtNoLibreta = New System.Windows.Forms.TextBox()
        Me.lblNoLibreta = New System.Windows.Forms.Label()
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
        Me.txtSaldoPendiente = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.c1nCuota = New C1.Win.C1Input.C1NumericEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkLibreta = New System.Windows.Forms.CheckBox()
        Me.txtSaldoCtaAhorro = New C1.Win.C1Input.C1NumericEdit()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFecha1aCuota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodTipoCredito = New System.Windows.Forms.TextBox()
        Me.gbItem = New System.Windows.Forms.GroupBox()
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
        Me.gbDPF.SuspendLayout()
        CType(Me.c1nDPFSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAhorros.SuspendLayout()
        Me.gbCheque.SuspendLayout()
        Me.gbDocxCobrar.SuspendLayout()
        CType(Me.c1nSaldoCtasOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoCxC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nNoCuotasCxC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSaldoCxC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoCtaAhorro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPrestamo.SuspendLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCapitalMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.gbDPF.Location = New System.Drawing.Point(28, 73)
        Me.gbDPF.Name = "gbDPF"
        Me.gbDPF.Size = New System.Drawing.Size(487, 136)
        Me.gbDPF.TabIndex = 176
        Me.gbDPF.TabStop = False
        '
        'txtDPFCodTipoAhorro
        '
        Me.txtDPFCodTipoAhorro.BackColor = System.Drawing.Color.White
        Me.txtDPFCodTipoAhorro.Location = New System.Drawing.Point(319, 16)
        Me.txtDPFCodTipoAhorro.Name = "txtDPFCodTipoAhorro"
        Me.txtDPFCodTipoAhorro.Size = New System.Drawing.Size(10, 22)
        Me.txtDPFCodTipoAhorro.TabIndex = 176
        Me.txtDPFCodTipoAhorro.Visible = False
        '
        'txtDPFNoCert
        '
        Me.txtDPFNoCert.BackColor = System.Drawing.Color.White
        Me.txtDPFNoCert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDPFNoCert.Enabled = False
        Me.txtDPFNoCert.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txtDPFNoCert.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDPFNoCert.Location = New System.Drawing.Point(336, 45)
        Me.txtDPFNoCert.Name = "txtDPFNoCert"
        Me.txtDPFNoCert.ReadOnly = True
        Me.txtDPFNoCert.Size = New System.Drawing.Size(144, 23)
        Me.txtDPFNoCert.TabIndex = 175
        Me.txtDPFNoCert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDPFMonto
        '
        Me.txtDPFMonto.BackColor = System.Drawing.Color.White
        Me.txtDPFMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDPFMonto.Enabled = False
        Me.txtDPFMonto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPFMonto.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDPFMonto.Location = New System.Drawing.Point(106, 42)
        Me.txtDPFMonto.Name = "txtDPFMonto"
        Me.txtDPFMonto.ReadOnly = True
        Me.txtDPFMonto.Size = New System.Drawing.Size(153, 23)
        Me.txtDPFMonto.TabIndex = 174
        Me.txtDPFMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(7, 44)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(57, 21)
        Me.Label33.TabIndex = 173
        Me.Label33.Text = "Monto:"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(266, 45)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 18)
        Me.Label34.TabIndex = 172
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
        Me.c1nDPFSaldo.Location = New System.Drawing.Point(336, 14)
        Me.c1nDPFSaldo.Name = "c1nDPFSaldo"
        Me.c1nDPFSaldo.ReadOnly = True
        Me.c1nDPFSaldo.Size = New System.Drawing.Size(144, 23)
        Me.c1nDPFSaldo.TabIndex = 158
        Me.c1nDPFSaldo.Tag = Nothing
        Me.c1nDPFSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nDPFSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nDPFSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(269, 18)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 19)
        Me.Label36.TabIndex = 150
        Me.Label36.Text = "Saldo"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDPFNoCuenta
        '
        Me.txtDPFNoCuenta.BackColor = System.Drawing.Color.White
        Me.txtDPFNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDPFNoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDPFNoCuenta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDPFNoCuenta.Location = New System.Drawing.Point(106, 14)
        Me.txtDPFNoCuenta.Name = "txtDPFNoCuenta"
        Me.txtDPFNoCuenta.Size = New System.Drawing.Size(153, 23)
        Me.txtDPFNoCuenta.TabIndex = 0
        Me.txtDPFNoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(10, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(88, 19)
        Me.Label37.TabIndex = 146
        Me.Label37.Text = "No. Cuenta:"
        '
        'gbAhorros
        '
        Me.gbAhorros.BackColor = System.Drawing.Color.White
        Me.gbAhorros.Controls.Add(Me.txtCodTipoAhorro)
        Me.gbAhorros.Controls.Add(Me.lblDiaCuota)
        Me.gbAhorros.Controls.Add(Me.txtCuotasNoPagadas)
        Me.gbAhorros.Controls.Add(Me.Label21)
        Me.gbAhorros.Controls.Add(Me.gbCheque)
        Me.gbAhorros.Controls.Add(Me.txtNoLibreta)
        Me.gbAhorros.Controls.Add(Me.lblNoLibreta)
        Me.gbAhorros.Controls.Add(Me.gbDocxCobrar)
        Me.gbAhorros.Controls.Add(Me.txtSaldoPendiente)
        Me.gbAhorros.Controls.Add(Me.Label32)
        Me.gbAhorros.Controls.Add(Me.Label31)
        Me.gbAhorros.Controls.Add(Me.c1nCuota)
        Me.gbAhorros.Controls.Add(Me.Label18)
        Me.gbAhorros.Controls.Add(Me.chkLibreta)
        Me.gbAhorros.Controls.Add(Me.txtSaldoCtaAhorro)
        Me.gbAhorros.Controls.Add(Me.Label26)
        Me.gbAhorros.Controls.Add(Me.txtNoCuenta)
        Me.gbAhorros.Controls.Add(Me.Label28)
        Me.gbAhorros.Location = New System.Drawing.Point(31, 73)
        Me.gbAhorros.Name = "gbAhorros"
        Me.gbAhorros.Size = New System.Drawing.Size(487, 136)
        Me.gbAhorros.TabIndex = 177
        Me.gbAhorros.TabStop = False
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(259, 14)
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(10, 22)
        Me.txtCodTipoAhorro.TabIndex = 180
        Me.txtCodTipoAhorro.Visible = False
        '
        'lblDiaCuota
        '
        Me.lblDiaCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaCuota.Location = New System.Drawing.Point(134, 95)
        Me.lblDiaCuota.Name = "lblDiaCuota"
        Me.lblDiaCuota.Size = New System.Drawing.Size(116, 18)
        Me.lblDiaCuota.TabIndex = 179
        '
        'txtCuotasNoPagadas
        '
        Me.txtCuotasNoPagadas.BackColor = System.Drawing.Color.White
        Me.txtCuotasNoPagadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuotasNoPagadas.Enabled = False
        Me.txtCuotasNoPagadas.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txtCuotasNoPagadas.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCuotasNoPagadas.Location = New System.Drawing.Point(134, 69)
        Me.txtCuotasNoPagadas.Name = "txtCuotasNoPagadas"
        Me.txtCuotasNoPagadas.ReadOnly = True
        Me.txtCuotasNoPagadas.Size = New System.Drawing.Size(125, 23)
        Me.txtCuotasNoPagadas.TabIndex = 175
        Me.txtCuotasNoPagadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(10, 95)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 20)
        Me.Label21.TabIndex = 177
        Me.Label21.Text = "Día Abono Cuota:"
        '
        'gbCheque
        '
        Me.gbCheque.BackColor = System.Drawing.Color.White
        Me.gbCheque.Controls.Add(Me.txtPaguese)
        Me.gbCheque.Controls.Add(Me.Label24)
        Me.gbCheque.Controls.Add(Me.txtGirador)
        Me.gbCheque.Controls.Add(Me.Label43)
        Me.gbCheque.Location = New System.Drawing.Point(0, 0)
        Me.gbCheque.Name = "gbCheque"
        Me.gbCheque.Size = New System.Drawing.Size(487, 136)
        Me.gbCheque.TabIndex = 187
        Me.gbCheque.TabStop = False
        '
        'txtPaguese
        '
        Me.txtPaguese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaguese.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaguese.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtPaguese.Location = New System.Drawing.Point(10, 83)
        Me.txtPaguese.MaxLength = 100
        Me.txtPaguese.Name = "txtPaguese"
        Me.txtPaguese.Size = New System.Drawing.Size(336, 23)
        Me.txtPaguese.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(10, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(153, 20)
        Me.Label24.TabIndex = 173
        Me.Label24.Text = "Paguese a la Orden de:"
        '
        'txtGirador
        '
        Me.txtGirador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGirador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGirador.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtGirador.Location = New System.Drawing.Point(10, 37)
        Me.txtGirador.MaxLength = 100
        Me.txtGirador.Name = "txtGirador"
        Me.txtGirador.Size = New System.Drawing.Size(336, 23)
        Me.txtGirador.TabIndex = 0
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(10, 18)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(134, 19)
        Me.Label43.TabIndex = 146
        Me.Label43.Text = "Nombre del Girador:"
        '
        'txtNoLibreta
        '
        Me.txtNoLibreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoLibreta.Enabled = False
        Me.txtNoLibreta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoLibreta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoLibreta.Location = New System.Drawing.Point(346, 92)
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.Size = New System.Drawing.Size(134, 23)
        Me.txtNoLibreta.TabIndex = 3
        '
        'lblNoLibreta
        '
        Me.lblNoLibreta.Location = New System.Drawing.Point(269, 95)
        Me.lblNoLibreta.Name = "lblNoLibreta"
        Me.lblNoLibreta.Size = New System.Drawing.Size(77, 18)
        Me.lblNoLibreta.TabIndex = 176
        Me.lblNoLibreta.Text = "No. Libreta:"
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
        Me.gbDocxCobrar.Location = New System.Drawing.Point(2, 0)
        Me.gbDocxCobrar.Name = "gbDocxCobrar"
        Me.gbDocxCobrar.Size = New System.Drawing.Size(489, 136)
        Me.gbDocxCobrar.TabIndex = 188
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
        Me.c1nSaldoCtasOrden.Location = New System.Drawing.Point(144, 102)
        Me.c1nSaldoCtasOrden.Name = "c1nSaldoCtasOrden"
        Me.c1nSaldoCtasOrden.ReadOnly = True
        Me.c1nSaldoCtasOrden.Size = New System.Drawing.Size(106, 23)
        Me.c1nSaldoCtasOrden.TabIndex = 164
        Me.c1nSaldoCtasOrden.Tag = Nothing
        Me.c1nSaldoCtasOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nSaldoCtasOrden.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nSaldoCtasOrden.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "Saldo Ctas. Orden:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(250, 75)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(9, 22)
        Me.txtEstado.TabIndex = 162
        Me.txtEstado.Visible = False
        '
        'txtCodTipoCreditoCxC
        '
        Me.txtCodTipoCreditoCxC.Location = New System.Drawing.Point(278, 18)
        Me.txtCodTipoCreditoCxC.Name = "txtCodTipoCreditoCxC"
        Me.txtCodTipoCreditoCxC.Size = New System.Drawing.Size(10, 22)
        Me.txtCodTipoCreditoCxC.TabIndex = 161
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
        Me.c1nMontoCxC.Location = New System.Drawing.Point(326, 28)
        Me.c1nMontoCxC.Name = "c1nMontoCxC"
        Me.c1nMontoCxC.ReadOnly = True
        Me.c1nMontoCxC.Size = New System.Drawing.Size(144, 23)
        Me.c1nMontoCxC.TabIndex = 160
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
        Me.c1nNoCuotasCxC.Location = New System.Drawing.Point(115, 74)
        Me.c1nNoCuotasCxC.Name = "c1nNoCuotasCxC"
        Me.c1nNoCuotasCxC.ReadOnly = True
        Me.c1nNoCuotasCxC.Size = New System.Drawing.Size(135, 23)
        Me.c1nNoCuotasCxC.TabIndex = 159
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
        Me.c1nSaldoCxC.Location = New System.Drawing.Point(326, 55)
        Me.c1nSaldoCxC.Name = "c1nSaldoCxC"
        Me.c1nSaldoCxC.ReadOnly = True
        Me.c1nSaldoCxC.Size = New System.Drawing.Size(144, 23)
        Me.c1nSaldoCxC.TabIndex = 156
        Me.c1nSaldoCxC.Tag = Nothing
        Me.c1nSaldoCxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nSaldoCxC.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nSaldoCxC.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(10, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 23)
        Me.Label22.TabIndex = 155
        Me.Label22.Text = "No. Cuotas:"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(278, 55)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(48, 19)
        Me.Label35.TabIndex = 152
        Me.Label35.Text = "Saldo"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(278, 28)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(48, 18)
        Me.Label38.TabIndex = 151
        Me.Label38.Text = "Monto"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFechaCxC
        '
        Me.txtFechaCxC.BackColor = System.Drawing.Color.White
        Me.txtFechaCxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaCxC.Location = New System.Drawing.Point(115, 46)
        Me.txtFechaCxC.MaxLength = 8
        Me.txtFechaCxC.Name = "txtFechaCxC"
        Me.txtFechaCxC.ReadOnly = True
        Me.txtFechaCxC.Size = New System.Drawing.Size(135, 22)
        Me.txtFechaCxC.TabIndex = 150
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(10, 46)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(105, 23)
        Me.Label39.TabIndex = 149
        Me.Label39.Text = "Fecha:"
        '
        'txtCodPrestamoCxC
        '
        Me.txtCodPrestamoCxC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamoCxC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamoCxC.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamoCxC.Location = New System.Drawing.Point(115, 18)
        Me.txtCodPrestamoCxC.Name = "txtCodPrestamoCxC"
        Me.txtCodPrestamoCxC.Size = New System.Drawing.Size(163, 23)
        Me.txtCodPrestamoCxC.TabIndex = 147
        Me.txtCodPrestamoCxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(10, 18)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(96, 19)
        Me.Label40.TabIndex = 148
        Me.Label40.Text = "Cod.Préstamo:"
        '
        'txtSaldoPendiente
        '
        Me.txtSaldoPendiente.BackColor = System.Drawing.Color.White
        Me.txtSaldoPendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoPendiente.Enabled = False
        Me.txtSaldoPendiente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoPendiente.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtSaldoPendiente.Location = New System.Drawing.Point(134, 42)
        Me.txtSaldoPendiente.Name = "txtSaldoPendiente"
        Me.txtSaldoPendiente.ReadOnly = True
        Me.txtSaldoPendiente.Size = New System.Drawing.Size(125, 23)
        Me.txtSaldoPendiente.TabIndex = 174
        Me.txtSaldoPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(10, 42)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(115, 20)
        Me.Label32.TabIndex = 173
        Me.Label32.Text = "Saldo Pendiente:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(10, 69)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(134, 19)
        Me.Label31.TabIndex = 172
        Me.Label31.Text = "Cuotas no pagadas:"
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
        Me.c1nCuota.Location = New System.Drawing.Point(336, 42)
        Me.c1nCuota.Name = "c1nCuota"
        Me.c1nCuota.ReadOnly = True
        Me.c1nCuota.Size = New System.Drawing.Size(144, 23)
        Me.c1nCuota.TabIndex = 171
        Me.c1nCuota.Tag = Nothing
        Me.c1nCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nCuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCuota.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(269, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 21)
        Me.Label18.TabIndex = 170
        Me.Label18.Text = "Cuota"
        '
        'chkLibreta
        '
        Me.chkLibreta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLibreta.Location = New System.Drawing.Point(269, 72)
        Me.chkLibreta.Name = "chkLibreta"
        Me.chkLibreta.Size = New System.Drawing.Size(134, 18)
        Me.chkLibreta.TabIndex = 2
        Me.chkLibreta.Text = "Pago con Libreta"
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
        Me.txtSaldoCtaAhorro.Location = New System.Drawing.Point(336, 14)
        Me.txtSaldoCtaAhorro.Name = "txtSaldoCtaAhorro"
        Me.txtSaldoCtaAhorro.ReadOnly = True
        Me.txtSaldoCtaAhorro.Size = New System.Drawing.Size(144, 23)
        Me.txtSaldoCtaAhorro.TabIndex = 158
        Me.txtSaldoCtaAhorro.Tag = Nothing
        Me.txtSaldoCtaAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldoCtaAhorro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldoCtaAhorro.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(269, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 19)
        Me.Label26.TabIndex = 150
        Me.Label26.Text = "Saldo"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoCuenta.Location = New System.Drawing.Point(96, 14)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(163, 23)
        Me.txtNoCuenta.TabIndex = 0
        Me.txtNoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(10, 14)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 18)
        Me.Label28.TabIndex = 146
        Me.Label28.Text = "No. Cuenta:"
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
        Me.gbPrestamo.Controls.Add(Me.Label6)
        Me.gbPrestamo.Controls.Add(Me.txtFecha1aCuota)
        Me.gbPrestamo.Controls.Add(Me.Label5)
        Me.gbPrestamo.Controls.Add(Me.txtCodPrestamo)
        Me.gbPrestamo.Controls.Add(Me.Label4)
        Me.gbPrestamo.Controls.Add(Me.txtCodTipoCredito)
        Me.gbPrestamo.Location = New System.Drawing.Point(34, 73)
        Me.gbPrestamo.Name = "gbPrestamo"
        Me.gbPrestamo.Size = New System.Drawing.Size(488, 136)
        Me.gbPrestamo.TabIndex = 0
        Me.gbPrestamo.TabStop = False
        '
        'txtDespacho
        '
        Me.txtDespacho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDespacho.ForeColor = System.Drawing.Color.Teal
        Me.txtDespacho.Location = New System.Drawing.Point(91, 102)
        Me.txtDespacho.Name = "txtDespacho"
        Me.txtDespacho.Size = New System.Drawing.Size(385, 26)
        Me.txtDespacho.TabIndex = 206
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 205
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
        Me.txtMonto.Location = New System.Drawing.Point(348, 18)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(128, 23)
        Me.txtMonto.TabIndex = 203
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
        Me.txtCuota.Location = New System.Drawing.Point(404, 74)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.ReadOnly = True
        Me.txtCuota.Size = New System.Drawing.Size(76, 23)
        Me.txtCuota.TabIndex = 202
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
        Me.txtIntMora.Location = New System.Drawing.Point(262, 74)
        Me.txtIntMora.Name = "txtIntMora"
        Me.txtIntMora.ReadOnly = True
        Me.txtIntMora.Size = New System.Drawing.Size(78, 23)
        Me.txtIntMora.TabIndex = 201
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
        Me.txtCapitalMora.Location = New System.Drawing.Point(107, 74)
        Me.txtCapitalMora.Name = "txtCapitalMora"
        Me.txtCapitalMora.ReadOnly = True
        Me.txtCapitalMora.Size = New System.Drawing.Size(84, 23)
        Me.txtCapitalMora.TabIndex = 200
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
        Me.txtSaldo.Location = New System.Drawing.Point(347, 46)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(129, 23)
        Me.txtSaldo.TabIndex = 199
        Me.txtSaldo.Tag = Nothing
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(355, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 23)
        Me.Label17.TabIndex = 198
        Me.Label17.Text = "Cuota"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(196, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 18)
        Me.Label16.TabIndex = 197
        Me.Label16.Text = "Int.Mora"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(16, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 14)
        Me.Label15.TabIndex = 196
        Me.Label15.Text = "Capital Mora"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(284, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 19)
        Me.Label13.TabIndex = 195
        Me.Label13.Text = "Saldo"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(275, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "Monto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFecha1aCuota
        '
        Me.txtFecha1aCuota.BackColor = System.Drawing.Color.White
        Me.txtFecha1aCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha1aCuota.Location = New System.Drawing.Point(121, 42)
        Me.txtFecha1aCuota.MaxLength = 8
        Me.txtFecha1aCuota.Name = "txtFecha1aCuota"
        Me.txtFecha1aCuota.ReadOnly = True
        Me.txtFecha1aCuota.Size = New System.Drawing.Size(125, 22)
        Me.txtFecha1aCuota.TabIndex = 193
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 23)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "Fecha 1a.Cuota"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamo.Location = New System.Drawing.Point(121, 14)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(135, 23)
        Me.txtCodPrestamo.TabIndex = 0
        Me.txtCodPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 191
        Me.Label4.Text = "Cod.Préstamo"
        '
        'txtCodTipoCredito
        '
        Me.txtCodTipoCredito.Location = New System.Drawing.Point(256, 14)
        Me.txtCodTipoCredito.Name = "txtCodTipoCredito"
        Me.txtCodTipoCredito.Size = New System.Drawing.Size(9, 22)
        Me.txtCodTipoCredito.TabIndex = 204
        Me.txtCodTipoCredito.Visible = False
        '
        'gbItem
        '
        Me.gbItem.BackColor = System.Drawing.Color.White
        Me.gbItem.Controls.Add(Me.lblInactiva)
        Me.gbItem.Controls.Add(Me.GroupBox2)
        Me.gbItem.Controls.Add(Me.txtCodItem)
        Me.gbItem.Controls.Add(Me.txtItem)
        Me.gbItem.Controls.Add(Me.txtMensaje)
        Me.gbItem.Controls.Add(Me.Label19)
        Me.gbItem.Controls.Add(Me.txtPago)
        Me.gbItem.Controls.Add(Me.txtObservacion)
        Me.gbItem.Controls.Add(Me.Label12)
        Me.gbItem.Controls.Add(Me.Label9)
        Me.gbItem.Controls.Add(Me.Label8)
        Me.gbItem.Enabled = False
        Me.gbItem.Location = New System.Drawing.Point(22, 216)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(912, 261)
        Me.gbItem.TabIndex = 1
        Me.gbItem.TabStop = False
        '
        'lblInactiva
        '
        Me.lblInactiva.AutoSize = True
        Me.lblInactiva.BackColor = System.Drawing.Color.White
        Me.lblInactiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInactiva.ForeColor = System.Drawing.Color.Teal
        Me.lblInactiva.Location = New System.Drawing.Point(7, 18)
        Me.lblInactiva.Name = "lblInactiva"
        Me.lblInactiva.Size = New System.Drawing.Size(172, 20)
        Me.lblInactiva.TabIndex = 139
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
        Me.GroupBox2.Location = New System.Drawing.Point(473, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 103)
        Me.GroupBox2.TabIndex = 137
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Terceras Personas"
        '
        'rbTerceraPersona
        '
        Me.rbTerceraPersona.AutoSize = True
        Me.rbTerceraPersona.Location = New System.Drawing.Point(83, 22)
        Me.rbTerceraPersona.Name = "rbTerceraPersona"
        Me.rbTerceraPersona.Size = New System.Drawing.Size(86, 21)
        Me.rbTerceraPersona.TabIndex = 5
        Me.rbTerceraPersona.TabStop = True
        Me.rbTerceraPersona.Text = "Terceros"
        Me.rbTerceraPersona.UseVisualStyleBackColor = True
        '
        'rbTitular
        '
        Me.rbTitular.AutoSize = True
        Me.rbTitular.Location = New System.Drawing.Point(11, 22)
        Me.rbTitular.Name = "rbTitular"
        Me.rbTitular.Size = New System.Drawing.Size(69, 21)
        Me.rbTitular.TabIndex = 4
        Me.rbTitular.TabStop = True
        Me.rbTitular.Text = "Titular"
        Me.rbTitular.UseVisualStyleBackColor = True
        '
        'txtNombreTercero
        '
        Me.txtNombreTercero.BackColor = System.Drawing.Color.White
        Me.txtNombreTercero.Location = New System.Drawing.Point(110, 73)
        Me.txtNombreTercero.Name = "txtNombreTercero"
        Me.txtNombreTercero.Size = New System.Drawing.Size(296, 22)
        Me.txtNombreTercero.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(7, 73)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNoDocTerceros
        '
        Me.txtNoDocTerceros.BackColor = System.Drawing.Color.White
        Me.txtNoDocTerceros.Location = New System.Drawing.Point(113, 43)
        Me.txtNoDocTerceros.Name = "txtNoDocTerceros"
        Me.txtNoDocTerceros.Size = New System.Drawing.Size(146, 22)
        Me.txtNoDocTerceros.TabIndex = 1
        '
        'lblNoDoc
        '
        Me.lblNoDoc.AutoSize = True
        Me.lblNoDoc.Location = New System.Drawing.Point(7, 46)
        Me.lblNoDoc.Name = "lblNoDoc"
        Me.lblNoDoc.Size = New System.Drawing.Size(106, 17)
        Me.lblNoDoc.TabIndex = 0
        Me.lblNoDoc.Text = "No Documento:"
        '
        'txtCodItem
        '
        Me.txtCodItem.BackColor = System.Drawing.Color.White
        Me.txtCodItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodItem.Location = New System.Drawing.Point(7, 75)
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.Size = New System.Drawing.Size(58, 25)
        Me.txtCodItem.TabIndex = 0
        Me.txtCodItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.White
        Me.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtItem.Location = New System.Drawing.Point(74, 75)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(240, 25)
        Me.txtItem.TabIndex = 4
        Me.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMensaje.Location = New System.Drawing.Point(7, 205)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ReadOnly = True
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(881, 49)
        Me.txtMensaje.TabIndex = 134
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(7, 187)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(144, 15)
        Me.Label19.TabIndex = 135
        Me.Label19.Text = "Mensaje para Cajas:"
        '
        'txtPago
        '
        Me.txtPago.BackColor = System.Drawing.Color.White
        Me.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPago.Culture = 17418
        Me.txtPago.CustomFormat = "###,##0.00"
        Me.txtPago.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPago.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtPago.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtPago.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtPago.Location = New System.Drawing.Point(324, 75)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtPago.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtPago.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtPago.Size = New System.Drawing.Size(125, 23)
        Me.txtPago.TabIndex = 1
        Me.txtPago.Tag = Nothing
        Me.txtPago.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPago.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.White
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacion.Location = New System.Drawing.Point(7, 129)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(881, 54)
        Me.txtObservacion.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 18)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Observación:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(7, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Código Item:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(324, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Monto Transacción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblBanco)
        Me.GroupBox1.Controls.Add(Me.txtBanco)
        Me.GroupBox1.Controls.Add(Me.txtNoCtaBancaria)
        Me.GroupBox1.Controls.Add(Me.txtNoCheque)
        Me.GroupBox1.Controls.Add(Me.txtNoReserva)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Location = New System.Drawing.Point(529, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 136)
        Me.GroupBox1.TabIndex = 193
        Me.GroupBox1.TabStop = False
        '
        'lblBanco
        '
        Me.lblBanco.Location = New System.Drawing.Point(166, 70)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(222, 51)
        Me.lblBanco.TabIndex = 192
        '
        'txtBanco
        '
        Me.txtBanco.BackColor = System.Drawing.Color.White
        Me.txtBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBanco.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBanco.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtBanco.Location = New System.Drawing.Point(96, 70)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.ReadOnly = True
        Me.txtBanco.Size = New System.Drawing.Size(58, 23)
        Me.txtBanco.TabIndex = 187
        '
        'txtNoCtaBancaria
        '
        Me.txtNoCtaBancaria.BackColor = System.Drawing.Color.White
        Me.txtNoCtaBancaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCtaBancaria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCtaBancaria.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoCtaBancaria.Location = New System.Drawing.Point(218, 36)
        Me.txtNoCtaBancaria.Name = "txtNoCtaBancaria"
        Me.txtNoCtaBancaria.ReadOnly = True
        Me.txtNoCtaBancaria.Size = New System.Drawing.Size(166, 23)
        Me.txtNoCtaBancaria.TabIndex = 186
        '
        'txtNoCheque
        '
        Me.txtNoCheque.BackColor = System.Drawing.Color.White
        Me.txtNoCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCheque.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCheque.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoCheque.Location = New System.Drawing.Point(96, 43)
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.ReadOnly = True
        Me.txtNoCheque.Size = New System.Drawing.Size(112, 23)
        Me.txtNoCheque.TabIndex = 185
        '
        'txtNoReserva
        '
        Me.txtNoReserva.BackColor = System.Drawing.Color.White
        Me.txtNoReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoReserva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoReserva.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoReserva.Location = New System.Drawing.Point(96, 15)
        Me.txtNoReserva.Name = "txtNoReserva"
        Me.txtNoReserva.ReadOnly = True
        Me.txtNoReserva.Size = New System.Drawing.Size(110, 23)
        Me.txtNoReserva.TabIndex = 184
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(8, 70)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 19)
        Me.Label30.TabIndex = 191
        Me.Label30.Text = "Banco:"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(217, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(135, 19)
        Me.Label29.TabIndex = 190
        Me.Label29.Text = "No. Cuenta Bancaria:"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(8, 43)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 18)
        Me.Label27.TabIndex = 189
        Me.Label27.Text = "No. Cheque:"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 15)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 18)
        Me.Label25.TabIndex = 188
        Me.Label25.Text = "No. Reserva:"
        '
        'gbOtros
        '
        Me.gbOtros.BackColor = System.Drawing.Color.White
        Me.gbOtros.Location = New System.Drawing.Point(34, 73)
        Me.gbOtros.Name = "gbOtros"
        Me.gbOtros.Size = New System.Drawing.Size(484, 136)
        Me.gbOtros.TabIndex = 194
        Me.gbOtros.TabStop = False
        '
        'btnAceptarLin1
        '
        Me.btnAceptarLin1.Location = New System.Drawing.Point(649, 483)
        Me.btnAceptarLin1.Name = "btnAceptarLin1"
        Me.btnAceptarLin1.Size = New System.Drawing.Size(90, 33)
        Me.btnAceptarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptarLin1.TabIndex = 1012
        Me.btnAceptarLin1.Text = "Aceptar"
        Me.btnAceptarLin1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAceptarLin1.UseSelectable = True
        Me.btnAceptarLin1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(746, 483)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(90, 33)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 1012
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btnCancelarLin1
        '
        Me.btnCancelarLin1.Location = New System.Drawing.Point(844, 483)
        Me.btnCancelarLin1.Name = "btnCancelarLin1"
        Me.btnCancelarLin1.Size = New System.Drawing.Size(90, 33)
        Me.btnCancelarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCancelarLin1.TabIndex = 1013
        Me.btnCancelarLin1.Text = "Cancelar"
        Me.btnCancelarLin1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCancelarLin1.UseSelectable = True
        Me.btnCancelarLin1.UseStyleColors = True
        '
        'frmMsDetCaFactura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(954, 555)
        Me.Controls.Add(Me.btnCancelarLin1)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.btnAceptarLin1)
        Me.Controls.Add(Me.gbDPF)
        Me.Controls.Add(Me.gbAhorros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbPrestamo)
        Me.Controls.Add(Me.gbItem)
        Me.Controls.Add(Me.gbOtros)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(954, 555)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(954, 555)
        Me.Name = "frmMsDetCaFactura"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Movimiento"
        Me.gbDPF.ResumeLayout(False)
        Me.gbDPF.PerformLayout()
        CType(Me.c1nDPFSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAhorros.ResumeLayout(False)
        Me.gbAhorros.PerformLayout()
        Me.gbCheque.ResumeLayout(False)
        Me.gbCheque.PerformLayout()
        Me.gbDocxCobrar.ResumeLayout(False)
        Me.gbDocxCobrar.PerformLayout()
        CType(Me.c1nSaldoCtasOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoCxC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nNoCuotasCxC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSaldoCxC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoCtaAhorro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPrestamo.ResumeLayout(False)
        Me.gbPrestamo.PerformLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCapitalMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"

    'Public Property AccionDetalle() As AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas
    Public Property AccionDetalle() As sifLib.Caja.clsCAFacturas.TipoAccionFacturas
        Get
            Return vAccionDetalle
        End Get
        'Set(ByVal Value As AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas)
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

    'Public Property Tipo() As AlcalaLibs.Caja.clsCAFactura.TipoMovimiento
    Public Property Tipo() As sifLib.Caja.clsCAFacturas.TipoMovimiento
        Get
            Return vTipo
        End Get
        'Set(ByVal Value As AlcalaLibs.Caja.clsCAFactura.TipoMovimiento)
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

                dsTmp = oCred.ConsultarGestoresxCredito("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and Estado='A'", "*", sUsuario, sPassword, sSucursal)
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
                Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            Me.gbItem.Enabled = False
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
            'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Then
            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                ds = oAh.ConsultarCuentaAhorroTipoAhorro("a.CodTipoAhorro,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.Estado,a.NoCuentaAnterior,a.FechaApertura,a.Cuota,a.SaldoDisponible_CuentaAhorro as Saldo__", "Left(a.CodTipoAhorro,1)<>'1' and Left(a.CodTipoAhorro,1)<>'6' and a.Dui='" & vDui & "' and a.Estado<>'C' and a.Estado<>'B'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
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
                Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            Me.gbItem.Enabled = False
            Me.txtNoCuenta.Text = ""
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoCuenta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNoCuenta.Validating
        CargaDatosAhorro()
        Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, dr As DataRow
        'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
        If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
            ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and codItem = '" & codItemRubro & "' /* and IdApp=9 and Tipo_Item='P' */ ", sUsuario, sPassword, sSucursal)
            'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Then
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

    Private Sub chkLibreta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLibreta.CheckedChanged
        If Me.chkLibreta.Checked = True Then
            vPagoLibreta = "S"
            Me.txtNoLibreta.Enabled = True
        Else
            vPagoLibreta = "N"
            Me.txtNoLibreta.Enabled = False
        End If
    End Sub

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
                Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            Me.gbItem.Enabled = False
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

                dsTmp = oCred.ConsultarGestoresxCredito("*", "CodPrestamo='" & Me.txtCodPrestamoCxC.Text.Trim & "' and Estado='A'", "*", sUsuario, sPassword, sSucursal)
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
                Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            Me.gbItem.Enabled = False
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
                'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
                If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                    If Me.lblInactiva.Visible = False Then
                        ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "'", sUsuario, sPassword, sSucursal)
                    End If
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=9 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Cobranza Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=10 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
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
                    'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                    If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                    Else
                        Me.txtPago.Value = oCaja.Redondear(dr("Valor"), 2)
                    End If
                Else
                    'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                    If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                    Else
                        Me.txtPago.Value = 0
                    End If
                End If
                vTipoMov = Trim(dr("TipoMovimiento"))
            End If
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
            'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                If pCE = "1" Then
                    ds = oCaja.ObtenerListaItems("*", "CodItem='" & pItemCE.Trim & "' and IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                Else
                    ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                End If
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Then
                'ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.gestionMora Then
                '    Exit Sub
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "'", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=9 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Cobranza Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza Then
                ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=10 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
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
                'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
                If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                    ds = oCaja.ObtenerListaItems("*", "IdRubro='" & vRubro & "' and IdApp=9 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Cobranza Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza Then
                    ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=10 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
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
                    'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                    If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                    Else
                        Me.txtPago.Value = oCaja.Redondear(dr("Valor"), 2)
                    End If
                Else
                    'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos Then
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
                    Me.gbItem.Enabled = False
                    Me.txtCodPrestamo.Text = ""
                    Exit Sub
                End If
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))

                dsTmp = oCred.ConsultarGestoresxCredito("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and Estado='A'", "*", sUsuario, sPassword, sSucursal)
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
                Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            Me.gbItem.Enabled = False
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
            ' MsgBox(mensajeError, MsgBoxStyle.Critical)
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


            ofrm.txtDui.Enabled = False

            'If Me.AccionDetalle = AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas.ModificarLinea Then
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
                'Me.AccionDetalle = AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas.AgregarLinea
                Me.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.AgregarLinea
            End If
            'If Me.AccionDetalle = AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas.AgregarLinea Then
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
                'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
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

                    'Si el movimiento es un Depósito o Retiro de Cuenta de Ahorros
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Then
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
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
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

                    'Si el movimiento es Apertura de DPF
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
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
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Cobranza Then
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
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
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
                'ElseIf Me.AccionDetalle = AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas.EliminarLinea Then
            ElseIf Me.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.EliminarLinea Then

            End If
            Me.txtCodItem.Text = ""
            Me.txtItem.Text = ""
            Me.txtPago.Value = 0
            'Me.AccionDetalle = AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas.Ninguna
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
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtDPFNoCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtDPFNoCuenta.TextChanged

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
                'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Then
                If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                    ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaApertura,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,Estado,Pignorado,NoLibreta,Observacion", " NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and Dui='" & (vDui) & "' and Estado<>'C' and Estado<>'B'", "NoCuenta", sUsuario, sPassword, sSucursal)
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
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
                Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            Me.gbItem.Enabled = False
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
                Me.gbItem.Enabled = True
            End If
        Catch ex As Exception
            Me.gbItem.Enabled = False
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
                    Me.gbItem.Enabled = False
                    Me.txtCodPrestamoCxC.Text = ""
                    Exit Sub
                End If
                Me.txtCodPrestamoCxC.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))

                dsTmp = oCred.ConsultarGestoresxCredito("*", "CodPrestamo='" & Me.txtCodPrestamoCxC.Text.Trim & "' and Estado='A'", "*", sUsuario, sPassword, sSucursal)
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
                Me.gbItem.Enabled = True
            Else
                Me.gbItem.Enabled = False
                Me.txtCodPrestamoCxC.Text = ""
            End If
        Catch ex As Exception
            txtCodPrestamoCxC.Text = ""
            Me.gbItem.Enabled = False
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
            Me.gbItem.Enabled = True
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

            'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Then
            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,Estado,Pignorado,Observacion", " NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and Dui='" & (vDui) & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
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
            Me.gbItem.Enabled = True
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
            If vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
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
                        'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
                        If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                            'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Then
                        ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P' and TipoDoc='" & Me.vTipoDoc & "'", sUsuario, sPassword, sSucursal)
                            'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
                        ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=9 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                            'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
                        ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=8 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                            'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Cobranza Then
                        ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza Then
                            ds = oCaja.ObtenerItem(sTexto, "IdRubro='" & vRubro & "' and IdApp=10 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                            'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
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
                            'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                            Else
                                Me.txtPago.Value = oCaja.Redondear(dr("Valor"), 2)
                            End If
                        Else
                            'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos Then
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
        If Me.txtPago.Value >= 571.43 Then
            If vTipoDoc.Equals("D") Then
                MsgBox("Por favor ingresar DUI y nombre del depositante.", MsgBoxStyle.Information, "Módulo - Caja")
            End If
        End If
    End Sub
End Class