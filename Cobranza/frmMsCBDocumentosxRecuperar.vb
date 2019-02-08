Public Class frmMsCBDocumentosxRecuperar
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Dim oPr As New wrPrestamo.wsLibPrest
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnAceptar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private numSolicitud As String = ""

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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents chkCobroJudicial As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtDespacho As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaInteresMora As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoCtasxOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoCtasxOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoCtasxCobrar As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoCtaxCobrar As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoInteresMora As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoCapitalMora As System.Windows.Forms.TextBox
    Friend WithEvents txtCuota As System.Windows.Forms.TextBox
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents txtFecVencimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtFecApertura As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoOtorgado As System.Windows.Forms.TextBox
    Friend WithEvents chkDocxCobrar As System.Windows.Forms.CheckBox
    Friend WithEvents txtNoActaDxC As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecResDxC As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbDocSaneados As System.Windows.Forms.RadioButton
    Friend WithEvents rbDocSaneamiento As System.Windows.Forms.RadioButton
    Friend WithEvents chkDocProtesto As System.Windows.Forms.CheckBox
    Friend WithEvents txtNoActaDP As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecResDP As System.Windows.Forms.DateTimePicker
    Friend WithEvents c1nMontoRecuperadoTDS As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nMontoDemandaTDS As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNoActaTDS As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecResTDS As System.Windows.Forms.DateTimePicker
    Friend WithEvents c1nMontoRecuperadoDS As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nMontoDemandaDS As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNoActaDS As System.Windows.Forms.TextBox
    Friend WithEvents chkDocSaneado As System.Windows.Forms.CheckBox
    Friend WithEvents txtNoActaConsejoAdmon As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecResDS As System.Windows.Forms.DateTimePicker
    Friend WithEvents c1nCapitalSaneadoDS As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkLiquidado As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodDespacho As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkDeudor As System.Windows.Forms.CheckBox
    Friend WithEvents chkFiador As System.Windows.Forms.CheckBox
    Friend WithEvents chkCodeudor As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCBDocumentosxRecuperar))
        Me.txtDiaInteresMora = New System.Windows.Forms.TextBox()
        Me.txtSaldoCtasxOrden = New System.Windows.Forms.TextBox()
        Me.txtMontoCtasxOrden = New System.Windows.Forms.TextBox()
        Me.txtSaldoCtasxCobrar = New System.Windows.Forms.TextBox()
        Me.txtMontoCtaxCobrar = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSaldoInteresMora = New System.Windows.Forms.TextBox()
        Me.txtSaldoCapitalMora = New System.Windows.Forms.TextBox()
        Me.txtCuota = New System.Windows.Forms.TextBox()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.txtFecVencimiento = New System.Windows.Forms.TextBox()
        Me.txtFecApertura = New System.Windows.Forms.TextBox()
        Me.txtMontoOtorgado = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtDespacho = New System.Windows.Forms.TextBox()
        Me.txtCodDespacho = New System.Windows.Forms.TextBox()
        Me.chkDocxCobrar = New System.Windows.Forms.CheckBox()
        Me.txtNoActaDxC = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.dtpFecResDxC = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chkCobroJudicial = New System.Windows.Forms.CheckBox()
        Me.c1nMontoRecuperadoTDS = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nMontoDemandaTDS = New C1.Win.C1Input.C1NumericEdit()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtNoActaTDS = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.dtpFecResTDS = New System.Windows.Forms.DateTimePicker()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.rbDocSaneados = New System.Windows.Forms.RadioButton()
        Me.rbDocSaneamiento = New System.Windows.Forms.RadioButton()
        Me.chkDocProtesto = New System.Windows.Forms.CheckBox()
        Me.txtNoActaDP = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.dtpFecResDP = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.c1nCapitalSaneadoDS = New C1.Win.C1Input.C1NumericEdit()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.chkLiquidado = New System.Windows.Forms.CheckBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.c1nMontoRecuperadoDS = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nMontoDemandaDS = New C1.Win.C1Input.C1NumericEdit()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtNoActaDS = New System.Windows.Forms.TextBox()
        Me.chkDocSaneado = New System.Windows.Forms.CheckBox()
        Me.txtNoActaConsejoAdmon = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.dtpFecResDS = New System.Windows.Forms.DateTimePicker()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkDeudor = New System.Windows.Forms.CheckBox()
        Me.chkFiador = New System.Windows.Forms.CheckBox()
        Me.chkCodeudor = New System.Windows.Forms.CheckBox()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.btnAceptar1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoRecuperadoTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoDemandaTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCapitalSaneadoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoRecuperadoDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoDemandaDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDiaInteresMora
        '
        Me.txtDiaInteresMora.BackColor = System.Drawing.Color.White
        Me.txtDiaInteresMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaInteresMora.Location = New System.Drawing.Point(414, 257)
        Me.txtDiaInteresMora.Name = "txtDiaInteresMora"
        Me.txtDiaInteresMora.ReadOnly = True
        Me.txtDiaInteresMora.Size = New System.Drawing.Size(173, 22)
        Me.txtDiaInteresMora.TabIndex = 109
        '
        'txtSaldoCtasxOrden
        '
        Me.txtSaldoCtasxOrden.BackColor = System.Drawing.Color.White
        Me.txtSaldoCtasxOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoCtasxOrden.Location = New System.Drawing.Point(131, 257)
        Me.txtSaldoCtasxOrden.Name = "txtSaldoCtasxOrden"
        Me.txtSaldoCtasxOrden.ReadOnly = True
        Me.txtSaldoCtasxOrden.Size = New System.Drawing.Size(173, 22)
        Me.txtSaldoCtasxOrden.TabIndex = 108
        '
        'txtMontoCtasxOrden
        '
        Me.txtMontoCtasxOrden.BackColor = System.Drawing.Color.White
        Me.txtMontoCtasxOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoCtasxOrden.Location = New System.Drawing.Point(697, 216)
        Me.txtMontoCtasxOrden.Name = "txtMontoCtasxOrden"
        Me.txtMontoCtasxOrden.Size = New System.Drawing.Size(173, 22)
        Me.txtMontoCtasxOrden.TabIndex = 107
        '
        'txtSaldoCtasxCobrar
        '
        Me.txtSaldoCtasxCobrar.BackColor = System.Drawing.Color.White
        Me.txtSaldoCtasxCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoCtasxCobrar.Location = New System.Drawing.Point(414, 216)
        Me.txtSaldoCtasxCobrar.Name = "txtSaldoCtasxCobrar"
        Me.txtSaldoCtasxCobrar.ReadOnly = True
        Me.txtSaldoCtasxCobrar.Size = New System.Drawing.Size(173, 22)
        Me.txtSaldoCtasxCobrar.TabIndex = 106
        '
        'txtMontoCtaxCobrar
        '
        Me.txtMontoCtaxCobrar.BackColor = System.Drawing.Color.White
        Me.txtMontoCtaxCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoCtaxCobrar.Location = New System.Drawing.Point(131, 218)
        Me.txtMontoCtaxCobrar.Name = "txtMontoCtaxCobrar"
        Me.txtMontoCtaxCobrar.ReadOnly = True
        Me.txtMontoCtaxCobrar.Size = New System.Drawing.Size(173, 22)
        Me.txtMontoCtaxCobrar.TabIndex = 105
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(311, 257)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(81, 30)
        Me.Label31.TabIndex = 104
        Me.Label31.Text = "Día Interés Mora:"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(28, 254)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 33)
        Me.Label30.TabIndex = 103
        Me.Label30.Text = "Saldo Cuentas de Orden:"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(594, 218)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(107, 36)
        Me.Label29.TabIndex = 102
        Me.Label29.Text = "Monto Cuentas de Orden:"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(311, 218)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 36)
        Me.Label28.TabIndex = 101
        Me.Label28.Text = "Saldo Cuentas por Cobrar:"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(28, 218)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(105, 36)
        Me.Label27.TabIndex = 100
        Me.Label27.Text = "Monto Cuentas por Cobrar:"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(311, 190)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 19)
        Me.Label26.TabIndex = 99
        Me.Label26.Text = "Capital Mora:"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(594, 188)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 19)
        Me.Label25.TabIndex = 98
        Me.Label25.Text = "Total Intereses:"
        '
        'txtSaldoInteresMora
        '
        Me.txtSaldoInteresMora.BackColor = System.Drawing.Color.White
        Me.txtSaldoInteresMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoInteresMora.Location = New System.Drawing.Point(697, 186)
        Me.txtSaldoInteresMora.Name = "txtSaldoInteresMora"
        Me.txtSaldoInteresMora.ReadOnly = True
        Me.txtSaldoInteresMora.Size = New System.Drawing.Size(173, 22)
        Me.txtSaldoInteresMora.TabIndex = 97
        '
        'txtSaldoCapitalMora
        '
        Me.txtSaldoCapitalMora.BackColor = System.Drawing.Color.White
        Me.txtSaldoCapitalMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoCapitalMora.Location = New System.Drawing.Point(414, 186)
        Me.txtSaldoCapitalMora.Name = "txtSaldoCapitalMora"
        Me.txtSaldoCapitalMora.ReadOnly = True
        Me.txtSaldoCapitalMora.Size = New System.Drawing.Size(173, 22)
        Me.txtSaldoCapitalMora.TabIndex = 96
        '
        'txtCuota
        '
        Me.txtCuota.BackColor = System.Drawing.Color.White
        Me.txtCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuota.Location = New System.Drawing.Point(131, 186)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.ReadOnly = True
        Me.txtCuota.Size = New System.Drawing.Size(173, 22)
        Me.txtCuota.TabIndex = 95
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.Color.White
        Me.txtPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlazo.Location = New System.Drawing.Point(697, 156)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.Size = New System.Drawing.Size(173, 22)
        Me.txtPlazo.TabIndex = 94
        '
        'txtFecVencimiento
        '
        Me.txtFecVencimiento.BackColor = System.Drawing.Color.White
        Me.txtFecVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecVencimiento.Location = New System.Drawing.Point(414, 156)
        Me.txtFecVencimiento.Name = "txtFecVencimiento"
        Me.txtFecVencimiento.ReadOnly = True
        Me.txtFecVencimiento.Size = New System.Drawing.Size(173, 22)
        Me.txtFecVencimiento.TabIndex = 93
        '
        'txtFecApertura
        '
        Me.txtFecApertura.BackColor = System.Drawing.Color.White
        Me.txtFecApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecApertura.Location = New System.Drawing.Point(131, 156)
        Me.txtFecApertura.Name = "txtFecApertura"
        Me.txtFecApertura.ReadOnly = True
        Me.txtFecApertura.Size = New System.Drawing.Size(173, 22)
        Me.txtFecApertura.TabIndex = 92
        '
        'txtMontoOtorgado
        '
        Me.txtMontoOtorgado.BackColor = System.Drawing.Color.White
        Me.txtMontoOtorgado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoOtorgado.Location = New System.Drawing.Point(697, 123)
        Me.txtMontoOtorgado.Name = "txtMontoOtorgado"
        Me.txtMontoOtorgado.ReadOnly = True
        Me.txtMontoOtorgado.Size = New System.Drawing.Size(173, 22)
        Me.txtMontoOtorgado.TabIndex = 91
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.White
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Location = New System.Drawing.Point(414, 126)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(173, 22)
        Me.txtCategoria.TabIndex = 90
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(28, 188)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 19)
        Me.Label24.TabIndex = 89
        Me.Label24.Text = "Cuota:"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(594, 158)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 19)
        Me.Label23.TabIndex = 88
        Me.Label23.Text = "Plazo:"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(311, 158)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 19)
        Me.Label22.TabIndex = 87
        Me.Label22.Text = "Fec. Vcto:"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(28, 158)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 19)
        Me.Label21.TabIndex = 86
        Me.Label21.Text = "Fecha Apertura:"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(594, 126)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 30)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Monto Otorgado:"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(311, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 19)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "Categoría:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(348, 65)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(86, 23)
        Me.txtNoSocio.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(245, 69)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 19)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "No. Asociado:"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(28, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 18)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Asociado:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(131, 95)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(739, 25)
        Me.txtAsociado.TabIndex = 80
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(131, 65)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(105, 23)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(28, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 19)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "DUI:"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BackColor = System.Drawing.Color.White
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.Location = New System.Drawing.Point(131, 126)
        Me.txtCodPrestamo.MaxLength = 25
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(173, 23)
        Me.txtCodPrestamo.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(28, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 19)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Préstamo:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(450, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(515, 65)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(117, 22)
        Me.dtpFecha.TabIndex = 3
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(5, 88)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(105, 18)
        Me.Label36.TabIndex = 51
        Me.Label36.Text = "Despacho:"
        '
        'txtDespacho
        '
        Me.txtDespacho.BackColor = System.Drawing.Color.White
        Me.txtDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDespacho.Location = New System.Drawing.Point(259, 84)
        Me.txtDespacho.Name = "txtDespacho"
        Me.txtDespacho.ReadOnly = True
        Me.txtDespacho.Size = New System.Drawing.Size(588, 23)
        Me.txtDespacho.TabIndex = 50
        '
        'txtCodDespacho
        '
        Me.txtCodDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDespacho.Location = New System.Drawing.Point(156, 84)
        Me.txtCodDespacho.Name = "txtCodDespacho"
        Me.txtCodDespacho.Size = New System.Drawing.Size(96, 23)
        Me.txtCodDespacho.TabIndex = 4
        '
        'chkDocxCobrar
        '
        Me.chkDocxCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDocxCobrar.Location = New System.Drawing.Point(208, 16)
        Me.chkDocxCobrar.Name = "chkDocxCobrar"
        Me.chkDocxCobrar.Size = New System.Drawing.Size(182, 19)
        Me.chkDocxCobrar.TabIndex = 1
        Me.chkDocxCobrar.Text = "Documento por &Cobrar"
        '
        'txtNoActaDxC
        '
        Me.txtNoActaDxC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActaDxC.Location = New System.Drawing.Point(702, 54)
        Me.txtNoActaDxC.MaxLength = 10
        Me.txtNoActaDxC.Name = "txtNoActaDxC"
        Me.txtNoActaDxC.Size = New System.Drawing.Size(145, 23)
        Me.txtNoActaDxC.TabIndex = 3
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(551, 54)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(144, 19)
        Me.Label33.TabIndex = 46
        Me.Label33.Text = "No. Acta Comité Mora:"
        '
        'dtpFecResDxC
        '
        Me.dtpFecResDxC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecResDxC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecResDxC.Location = New System.Drawing.Point(156, 54)
        Me.dtpFecResDxC.Name = "dtpFecResDxC"
        Me.dtpFecResDxC.Size = New System.Drawing.Size(130, 23)
        Me.dtpFecResDxC.TabIndex = 2
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(5, 54)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(144, 19)
        Me.Label32.TabIndex = 44
        Me.Label32.Text = "Fecha de Resolución:"
        '
        'chkCobroJudicial
        '
        Me.chkCobroJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCobroJudicial.Location = New System.Drawing.Point(8, 16)
        Me.chkCobroJudicial.Name = "chkCobroJudicial"
        Me.chkCobroJudicial.Size = New System.Drawing.Size(192, 19)
        Me.chkCobroJudicial.TabIndex = 0
        Me.chkCobroJudicial.Text = "&Traslado a Cobro Judicial"
        '
        'c1nMontoRecuperadoTDS
        '
        Me.c1nMontoRecuperadoTDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoRecuperadoTDS.CustomFormat = "###,###,##0.00"
        Me.c1nMontoRecuperadoTDS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoRecuperadoTDS.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoRecuperadoTDS.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nMontoRecuperadoTDS.Location = New System.Drawing.Point(674, 143)
        Me.c1nMontoRecuperadoTDS.Name = "c1nMontoRecuperadoTDS"
        Me.c1nMontoRecuperadoTDS.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoRecuperadoTDS.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoRecuperadoTDS.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoRecuperadoTDS.Size = New System.Drawing.Size(173, 24)
        Me.c1nMontoRecuperadoTDS.TabIndex = 7
        Me.c1nMontoRecuperadoTDS.Tag = Nothing
        Me.c1nMontoRecuperadoTDS.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoRecuperadoTDS.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nMontoDemandaTDS
        '
        Me.c1nMontoDemandaTDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoDemandaTDS.CustomFormat = "###,###,##0.00"
        Me.c1nMontoDemandaTDS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoDemandaTDS.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoDemandaTDS.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nMontoDemandaTDS.Location = New System.Drawing.Point(163, 143)
        Me.c1nMontoDemandaTDS.Name = "c1nMontoDemandaTDS"
        Me.c1nMontoDemandaTDS.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoDemandaTDS.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoDemandaTDS.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoDemandaTDS.Size = New System.Drawing.Size(173, 24)
        Me.c1nMontoDemandaTDS.TabIndex = 6
        Me.c1nMontoDemandaTDS.Tag = Nothing
        Me.c1nMontoDemandaTDS.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoDemandaTDS.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(523, 149)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(130, 18)
        Me.Label41.TabIndex = 57
        Me.Label41.Text = "Monto Recuperado:"
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(12, 143)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(115, 19)
        Me.Label40.TabIndex = 56
        Me.Label40.Text = "Monto Demanda:"
        '
        'txtNoActaTDS
        '
        Me.txtNoActaTDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActaTDS.Location = New System.Drawing.Point(674, 84)
        Me.txtNoActaTDS.MaxLength = 10
        Me.txtNoActaTDS.Name = "txtNoActaTDS"
        Me.txtNoActaTDS.Size = New System.Drawing.Size(173, 23)
        Me.txtNoActaTDS.TabIndex = 5
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(523, 84)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(144, 19)
        Me.Label38.TabIndex = 54
        Me.Label38.Text = "No. Acta Comité Mora:"
        '
        'dtpFecResTDS
        '
        Me.dtpFecResTDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecResTDS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecResTDS.Location = New System.Drawing.Point(163, 84)
        Me.dtpFecResTDS.Name = "dtpFecResTDS"
        Me.dtpFecResTDS.Size = New System.Drawing.Size(173, 23)
        Me.dtpFecResTDS.TabIndex = 4
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(12, 91)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(125, 19)
        Me.Label39.TabIndex = 52
        Me.Label39.Text = "Fecha Resolución:"
        '
        'rbDocSaneados
        '
        Me.rbDocSaneados.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbDocSaneados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDocSaneados.Location = New System.Drawing.Point(4, 59)
        Me.rbDocSaneados.Name = "rbDocSaneados"
        Me.rbDocSaneados.Size = New System.Drawing.Size(240, 18)
        Me.rbDocSaneados.TabIndex = 3
        Me.rbDocSaneados.Text = "Traslado a Documentos saneados"
        '
        'rbDocSaneamiento
        '
        Me.rbDocSaneamiento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbDocSaneamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDocSaneamiento.Location = New System.Drawing.Point(0, 3)
        Me.rbDocSaneamiento.Name = "rbDocSaneamiento"
        Me.rbDocSaneamiento.Size = New System.Drawing.Size(269, 19)
        Me.rbDocSaneamiento.TabIndex = 0
        Me.rbDocSaneamiento.Text = "Documento en proceso de saneamiento"
        '
        'chkDocProtesto
        '
        Me.chkDocProtesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDocProtesto.Location = New System.Drawing.Point(4, 113)
        Me.chkDocProtesto.Name = "chkDocProtesto"
        Me.chkDocProtesto.Size = New System.Drawing.Size(259, 28)
        Me.chkDocProtesto.TabIndex = 8
        Me.chkDocProtesto.Text = "Documento en &protesto no saneado"
        '
        'txtNoActaDP
        '
        Me.txtNoActaDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActaDP.Location = New System.Drawing.Point(674, 29)
        Me.txtNoActaDP.MaxLength = 10
        Me.txtNoActaDP.Name = "txtNoActaDP"
        Me.txtNoActaDP.Size = New System.Drawing.Size(173, 23)
        Me.txtNoActaDP.TabIndex = 2
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(523, 32)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(144, 19)
        Me.Label34.TabIndex = 46
        Me.Label34.Text = "No. Acta Comité Mora:"
        '
        'dtpFecResDP
        '
        Me.dtpFecResDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecResDP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecResDP.Location = New System.Drawing.Point(163, 29)
        Me.dtpFecResDP.Name = "dtpFecResDP"
        Me.dtpFecResDP.Size = New System.Drawing.Size(173, 23)
        Me.dtpFecResDP.TabIndex = 1
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(12, 32)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(144, 19)
        Me.Label35.TabIndex = 44
        Me.Label35.Text = "Fecha de Resolución:"
        '
        'c1nCapitalSaneadoDS
        '
        Me.c1nCapitalSaneadoDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCapitalSaneadoDS.CustomFormat = "###,###,##0.00"
        Me.c1nCapitalSaneadoDS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCapitalSaneadoDS.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCapitalSaneadoDS.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nCapitalSaneadoDS.Location = New System.Drawing.Point(674, 77)
        Me.c1nCapitalSaneadoDS.Name = "c1nCapitalSaneadoDS"
        Me.c1nCapitalSaneadoDS.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCapitalSaneadoDS.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCapitalSaneadoDS.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCapitalSaneadoDS.Size = New System.Drawing.Size(173, 25)
        Me.c1nCapitalSaneadoDS.TabIndex = 7
        Me.c1nCapitalSaneadoDS.Tag = Nothing
        Me.c1nCapitalSaneadoDS.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCapitalSaneadoDS.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(572, 77)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(95, 33)
        Me.Label44.TabIndex = 67
        Me.Label44.Text = "Capital Saneado:"
        '
        'chkLiquidado
        '
        Me.chkLiquidado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLiquidado.Location = New System.Drawing.Point(751, 3)
        Me.chkLiquidado.Name = "chkLiquidado"
        Me.chkLiquidado.Size = New System.Drawing.Size(96, 19)
        Me.chkLiquidado.TabIndex = 1
        Me.chkLiquidado.Text = "&Liquidado"
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(288, 36)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(96, 31)
        Me.Label45.TabIndex = 65
        Me.Label45.Text = "No. Acta Consejo Admin:"
        '
        'c1nMontoRecuperadoDS
        '
        Me.c1nMontoRecuperadoDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoRecuperadoDS.CustomFormat = "###,###,##0.00"
        Me.c1nMontoRecuperadoDS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoRecuperadoDS.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoRecuperadoDS.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nMontoRecuperadoDS.Location = New System.Drawing.Point(391, 77)
        Me.c1nMontoRecuperadoDS.Name = "c1nMontoRecuperadoDS"
        Me.c1nMontoRecuperadoDS.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoRecuperadoDS.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoRecuperadoDS.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoRecuperadoDS.Size = New System.Drawing.Size(173, 25)
        Me.c1nMontoRecuperadoDS.TabIndex = 6
        Me.c1nMontoRecuperadoDS.Tag = Nothing
        Me.c1nMontoRecuperadoDS.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoRecuperadoDS.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nMontoDemandaDS
        '
        Me.c1nMontoDemandaDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoDemandaDS.CustomFormat = "###,###,##0.00"
        Me.c1nMontoDemandaDS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoDemandaDS.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoDemandaDS.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nMontoDemandaDS.Location = New System.Drawing.Point(108, 77)
        Me.c1nMontoDemandaDS.Name = "c1nMontoDemandaDS"
        Me.c1nMontoDemandaDS.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoDemandaDS.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoDemandaDS.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoDemandaDS.Size = New System.Drawing.Size(173, 25)
        Me.c1nMontoDemandaDS.TabIndex = 5
        Me.c1nMontoDemandaDS.Tag = Nothing
        Me.c1nMontoDemandaDS.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoDemandaDS.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(288, 77)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(96, 33)
        Me.Label42.TabIndex = 57
        Me.Label42.Text = "Monto Recuperado:"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(5, 77)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(96, 33)
        Me.Label43.TabIndex = 56
        Me.Label43.Text = "Monto Demanda:"
        '
        'txtNoActaDS
        '
        Me.txtNoActaDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActaDS.Location = New System.Drawing.Point(674, 36)
        Me.txtNoActaDS.MaxLength = 10
        Me.txtNoActaDS.Name = "txtNoActaDS"
        Me.txtNoActaDS.Size = New System.Drawing.Size(173, 23)
        Me.txtNoActaDS.TabIndex = 4
        '
        'chkDocSaneado
        '
        Me.chkDocSaneado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDocSaneado.Location = New System.Drawing.Point(4, 3)
        Me.chkDocSaneado.Name = "chkDocSaneado"
        Me.chkDocSaneado.Size = New System.Drawing.Size(230, 19)
        Me.chkDocSaneado.TabIndex = 0
        Me.chkDocSaneado.Text = "Documento en protesto &saneado"
        '
        'txtNoActaConsejoAdmon
        '
        Me.txtNoActaConsejoAdmon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActaConsejoAdmon.Location = New System.Drawing.Point(391, 36)
        Me.txtNoActaConsejoAdmon.MaxLength = 10
        Me.txtNoActaConsejoAdmon.Name = "txtNoActaConsejoAdmon"
        Me.txtNoActaConsejoAdmon.Size = New System.Drawing.Size(173, 23)
        Me.txtNoActaConsejoAdmon.TabIndex = 3
        Me.txtNoActaConsejoAdmon.Text = "2345"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(571, 36)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(96, 31)
        Me.Label46.TabIndex = 46
        Me.Label46.Text = "No. Acta Comité Mora:"
        '
        'dtpFecResDS
        '
        Me.dtpFecResDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecResDS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecResDS.Location = New System.Drawing.Point(108, 36)
        Me.dtpFecResDS.Name = "dtpFecResDS"
        Me.dtpFecResDS.Size = New System.Drawing.Size(173, 23)
        Me.dtpFecResDS.TabIndex = 2
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(5, 36)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(96, 31)
        Me.Label47.TabIndex = 44
        Me.Label47.Text = "Fecha de Resolución:"
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "3,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Caption:""Historial"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(28, 661)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(709, 0)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(29, 516)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Observaciones:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(31, 538)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(858, 47)
        Me.txtObs.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(28, 600)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 18)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Seleccione quien realiza el pago:"
        '
        'chkDeudor
        '
        Me.chkDeudor.Location = New System.Drawing.Point(241, 600)
        Me.chkDeudor.Name = "chkDeudor"
        Me.chkDeudor.Size = New System.Drawing.Size(135, 18)
        Me.chkDeudor.TabIndex = 5
        Me.chkDeudor.Text = "&Deudor Principal"
        '
        'chkFiador
        '
        Me.chkFiador.Location = New System.Drawing.Point(383, 600)
        Me.chkFiador.Name = "chkFiador"
        Me.chkFiador.Size = New System.Drawing.Size(77, 18)
        Me.chkFiador.TabIndex = 6
        Me.chkFiador.Text = "&Fiador"
        '
        'chkCodeudor
        '
        Me.chkCodeudor.Location = New System.Drawing.Point(467, 600)
        Me.chkCodeudor.Name = "chkCodeudor"
        Me.chkCodeudor.Size = New System.Drawing.Size(96, 18)
        Me.chkCodeudor.TabIndex = 7
        Me.chkCodeudor.Text = "&Codeudor"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(28, 291)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(866, 221)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 117
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.Color.White
        Me.MetroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage1.Controls.Add(Me.chkDocxCobrar)
        Me.MetroTabPage1.Controls.Add(Me.txtDespacho)
        Me.MetroTabPage1.Controls.Add(Me.Label36)
        Me.MetroTabPage1.Controls.Add(Me.txtCodDespacho)
        Me.MetroTabPage1.Controls.Add(Me.chkCobroJudicial)
        Me.MetroTabPage1.Controls.Add(Me.Label32)
        Me.MetroTabPage1.Controls.Add(Me.dtpFecResDxC)
        Me.MetroTabPage1.Controls.Add(Me.txtNoActaDxC)
        Me.MetroTabPage1.Controls.Add(Me.Label33)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 12
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(858, 179)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Documentos por cobrar"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 12
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.BackColor = System.Drawing.Color.White
        Me.MetroTabPage2.Controls.Add(Me.c1nMontoRecuperadoTDS)
        Me.MetroTabPage2.Controls.Add(Me.Label41)
        Me.MetroTabPage2.Controls.Add(Me.c1nMontoDemandaTDS)
        Me.MetroTabPage2.Controls.Add(Me.rbDocSaneamiento)
        Me.MetroTabPage2.Controls.Add(Me.Label35)
        Me.MetroTabPage2.Controls.Add(Me.Label40)
        Me.MetroTabPage2.Controls.Add(Me.dtpFecResDP)
        Me.MetroTabPage2.Controls.Add(Me.chkDocProtesto)
        Me.MetroTabPage2.Controls.Add(Me.txtNoActaTDS)
        Me.MetroTabPage2.Controls.Add(Me.Label34)
        Me.MetroTabPage2.Controls.Add(Me.Label38)
        Me.MetroTabPage2.Controls.Add(Me.txtNoActaDP)
        Me.MetroTabPage2.Controls.Add(Me.dtpFecResTDS)
        Me.MetroTabPage2.Controls.Add(Me.rbDocSaneados)
        Me.MetroTabPage2.Controls.Add(Me.Label39)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 12
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(858, 179)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Documentos en protesto"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 12
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.BackColor = System.Drawing.Color.White
        Me.MetroTabPage3.Controls.Add(Me.c1nCapitalSaneadoDS)
        Me.MetroTabPage3.Controls.Add(Me.Label44)
        Me.MetroTabPage3.Controls.Add(Me.c1nMontoRecuperadoDS)
        Me.MetroTabPage3.Controls.Add(Me.Label45)
        Me.MetroTabPage3.Controls.Add(Me.Label42)
        Me.MetroTabPage3.Controls.Add(Me.c1nMontoDemandaDS)
        Me.MetroTabPage3.Controls.Add(Me.chkLiquidado)
        Me.MetroTabPage3.Controls.Add(Me.chkDocSaneado)
        Me.MetroTabPage3.Controls.Add(Me.Label43)
        Me.MetroTabPage3.Controls.Add(Me.Label47)
        Me.MetroTabPage3.Controls.Add(Me.txtNoActaDS)
        Me.MetroTabPage3.Controls.Add(Me.dtpFecResDS)
        Me.MetroTabPage3.Controls.Add(Me.Label46)
        Me.MetroTabPage3.Controls.Add(Me.txtNoActaConsejoAdmon)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 12
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(858, 179)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Documentos saneados"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 12
        '
        'btnAceptar1
        '
        Me.btnAceptar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnAceptar1.Location = New System.Drawing.Point(31, 622)
        Me.btnAceptar1.Name = "btnAceptar1"
        Me.btnAceptar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAceptar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptar1.TabIndex = 1016
        Me.btnAceptar1.Text = "&Ver Historial"
        Me.btnAceptar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAceptar1.UseSelectable = True
        Me.btnAceptar1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardar1.Location = New System.Drawing.Point(727, 592)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(162, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1017
        Me.btnGuardar1.Text = "&Aperturar documento"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCBDocumentosxRecuperar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(760, 700)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btnAceptar1)
        Me.Controls.Add(Me.txtDiaInteresMora)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.txtSaldoCtasxOrden)
        Me.Controls.Add(Me.chkCodeudor)
        Me.Controls.Add(Me.txtMontoCtasxOrden)
        Me.Controls.Add(Me.chkFiador)
        Me.Controls.Add(Me.txtSaldoCtasxCobrar)
        Me.Controls.Add(Me.chkDeudor)
        Me.Controls.Add(Me.txtMontoCtaxCobrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtSaldoInteresMora)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtSaldoCapitalMora)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtCuota)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPlazo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFecVencimiento)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.txtFecApertura)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.txtMontoOtorgado)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCBDocumentosxRecuperar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Documentos en Proceso de Recuperación"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoRecuperadoTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoDemandaTDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCapitalSaneadoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoRecuperadoDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoDemandaDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim ds As New Data.DataSet
        Dim sResultado As String
        Dim ofrm As New frmAGenerico
        Dim dr As DataRow
        Try
            ofrm.Text = "Buscar Documentos Protesto"
            ds = oCred.ConsultarPrestamos("*", "Dui='" & Me.txtDui.Value & "' and Baja='0'", "", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sResultado = ofrm.Resultado
            ds.Tables.Clear()
            ds = oCred.ConsultarPrestamos("*", "CodPrestamo='" & Trim(sResultado) & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
            dr = ds.Tables(0).Rows(0)
            Me.txtCodPrestamo.Text = dr("CodPrestamo")
            Me.txtSaldoCapitalMora.Text = dr("SaldoDia_CapitalMora")
            Me.txtSaldoInteresMora.Text = Math.Round(CDbl(dr("SaldoDia_InteresMora") + dr("SaldoDia_Interes")))
            Me.txtMontoOtorgado.Text = dr("Monto")
            Me.txtCategoria.Text = dr("Categoria")
            Me.txtFecApertura.Text = dr("FechaOtorgamiento")
            Me.txtFecVencimiento.Text = dr("FechaVencimiento")
            Me.txtPlazo.Text = dr("PlazoMeses")
            Me.txtCuota.Text = dr("CuotaTotal")
            Me.txtDiaInteresMora.Text = dr("DiasMora")
            Me.txtSaldoCtasxCobrar.Text = dr("Saldo_Capital")
            Me.txtMontoCtaxCobrar.Text = dr("Saldo_Capital")
            numSolicitud = dr("NumSolicitud")
            Me.btnGuardar1.Enabled = True
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo Cobranza")
        End Try
    End Sub

    Private Sub CargarDatosPrestamo()
        Dim oCred As New wrPrestamo.wsLibPrest
        Dim ds As New Data.DataSet, dr As DataRow
        Try
            ds = oCred.CargaDatosPrestamoCB(Me.txtCodPrestamo.Text.Trim, sUsuario, sPassword, sSucursal)
            dr = ds.Tables("Prestamo").Rows(0)
            Me.txtCodPrestamo.Text = dr("CodPrestamo")
            Me.txtSaldoCapitalMora.Text = dr("SaldoDia_CapitalMora")
            Me.txtSaldoInteresMora.Text = Math.Round(CDbl(dr("SaldoDia_InteresMora") + dr("SaldoDia_Interes")), 2)
            Me.txtMontoOtorgado.Text = dr("Monto")
            Me.txtCategoria.Text = dr("Categoria")
            Me.txtFecApertura.Text = dr("FechaOtorgamiento")
            Me.txtFecVencimiento.Text = dr("FechaVencimiento")
            Me.txtPlazo.Text = dr("PlazoMeses")
            Me.txtCuota.Text = dr("CuotaTotal")
            Me.txtDiaInteresMora.Text = dr("DiasMora")
            Me.txtSaldoCtasxCobrar.Text = dr("Saldo_Capital")
            numSolicitud = dr("NumSolicitud")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo Cobranza")
        End Try
    End Sub



    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,Apellido1,Apellido2,Nombres", "", "Apellido1", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = Trim(dr("NoSocio"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoSocio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSocio.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("NoSocio,DUI,Apellido1,Apellido2,Nombres", "", "Apellido1", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "NoSocio='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = Trim(dr("NoSocio"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsCBDocumentosProtesto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.btnGuardar1.Text = "&Modificar" Then
            '    Dim sTexto As String,
            Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet, dr As DataRow
            Try
                ds = oCred.ConsultarCBDocumentosxRecuperar("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCodPrestamo.Text = dr("CodPrestamo")
                    Me.txtDui.Value = dr("Dui")
                    If dr("TipoDocumento") = "C" Then 'C: Documentos x Cobrar; 
                        Me.chkDocxCobrar.Checked = True
                        Me.dtpFecResDxC.Value = dr("FechaResolucion")
                        Me.txtNoActaDxC.Text = dr("NoActa_ComiteMora")
                        Me.txtNoActaConsejoAdmon.Text = ""
                        Me.chkLiquidado.Checked = False
                        Me.chkCobroJudicial.Checked = IIf(dr("SubTipo") = "1", True, False)
                    ElseIf dr("TipoDocumento") = "P" Then 'P: Documentos en Protesto; 
                        Me.chkDocProtesto.Checked = True
                        If dr("SubTipo") = "0" Then
                            Me.rbDocSaneamiento.Checked = True
                            Me.dtpFecResDP.Value = dr("FechaResolucion")
                            Me.txtNoActaDP.Text = dr("NoActa_ComiteMora")
                        ElseIf dr("SubTipo") = "1" Then
                            Me.rbDocSaneados.Checked = True
                            Me.dtpFecResTDS.Value = dr("FechaResolucion")
                            Me.txtNoActaTDS.Text = dr("NoActa_ComiteMora")
                        End If
                        Me.c1nMontoDemandaTDS.Value = dr("Monto_Demanda")
                        Me.c1nMontoRecuperadoTDS.Value = dr("Monto_Recuperado")
                        Me.txtNoActaConsejoAdmon.Text = ""
                        Me.chkLiquidado.Checked = False
                    ElseIf dr("TipoDocumento") = "S" Then 'S: Documentos(Saneados)
                        Me.chkDocSaneado.Checked = True
                        Me.dtpFecResDS.Value = dr("FechaResolucion")
                        Me.txtNoActaDS.Text = dr("NoActa_ComiteMora")
                        Me.txtNoActaConsejoAdmon.Text = dr("NoActa_ConsejoAdmon")
                        Me.c1nMontoDemandaDS.Value = dr("Monto_Demanda")
                        Me.c1nMontoRecuperadoDS.Value = dr("Monto_Recuperado")
                        Me.c1nCapitalSaneadoDS.Value = dr("Capital_Saneado")
                        Me.chkLiquidado.Checked = IIf(dr("Liquidado") = "0", False, True)
                    End If
                    Me.txtMontoCtasxOrden.Text = IIf(dr("MontoCuentasOrden") Is DBNull.Value, 0, dr("MontoCuentasOrden"))
                    Me.txtMontoCtaxCobrar.Text = IIf(dr("MontoCuentasxCobrar") Is DBNull.Value, 0, dr("MontoCuentasxCobrar"))
                    Me.txtSaldoCtasxOrden.Text = IIf(dr("SaldoCuentasOrden") Is DBNull.Value, 0, dr("SaldoCuentasOrden"))
                    Me.txtObs.Text = dr("Observacion")
                    Me.txtCodDespacho.Text = IIf(dr("CodDespacho") Is DBNull.Value, "", dr("CodDespacho"))
                    Me.chkDeudor.Checked = IIf(dr("Deudor") = "0", False, True)
                    Me.chkCodeudor.Checked = IIf(dr("CoDeudor") = "0", False, True)
                    Me.chkFiador.Checked = IIf(dr("Fiador") = "0", False, True)
                    txtDui_LostFocus(sender, e)
                    CargarDatosPrestamo()
                    If Me.txtCodDespacho.Text.Trim <> "" Then
                        ds = oCred.ConsultarDespacho("*", "CodDespacho='" & Me.txtCodDespacho.Text.Trim & "'", "CodDespacho", sUsuario, sPassword, sSucursal)
                        If ds.Tables(0).Rows.Count > 0 Then
                            dr = ds.Tables(0).Rows(0)
                            Me.txtDespacho.Text = dr("Descripcion")
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try
        Else
            Me.btnGuardar1.Enabled = False
        End If
    End Sub

    Private Sub txtDui_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.GotFocus
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkDocxCobrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDocxCobrar.CheckedChanged
        If Me.chkDocxCobrar.Checked = True Then
            Me.chkDocSaneado.Checked = False
            Me.chkDocProtesto.Checked = False
        End If
    End Sub

    Private Sub chkDocSaneado_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDocSaneado.CheckedChanged
        If Me.chkDocSaneado.Checked = True Then
            Me.chkDocxCobrar.Checked = False
            Me.chkDocProtesto.Checked = False
        End If
    End Sub

    Private Sub chkDocProtesto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDocProtesto.CheckedChanged
        If Me.chkDocProtesto.Checked = True Then
            Me.chkDocSaneado.Checked = False
            Me.chkDocxCobrar.Checked = False
        End If
    End Sub

    Private Sub txtCodDespacho_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodDespacho.DoubleClick
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

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus

        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Dim sTexto As String

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Value
            If sTexto = "" Then      'Filtrar Registros

            ElseIf sTexto <> "" Then

                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = Trim(dr("NoSocio"))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtMontoCtasxOrden_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoCtasxOrden.LostFocus
        Me.txtSaldoCtasxOrden.Text = Me.txtMontoCtasxOrden.Text
    End Sub



    Private Sub btnAceptar1_Click(sender As Object, e As EventArgs) Handles btnAceptar1.Click
        Try
            Dim oCred As New wrCredito.wsLibCred, ds As New DataSet
            ds = oCred.ConsultarCBHistDocumentosxRecuperar("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "Correlativo desc", sUsuario, sPassword, sSucursal)
            Me.fg.DataSource = ds.Tables(0)
            fg.Cols.Item("Correlativo").Width = 0
            fg.Cols.Item("CodPrestamo").Width = 0
            fg.Cols.Item("Dui").Width = 0
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New DataSet, dr As DataRow
            Dim Campos, Valores, CamposValores As String ', vTipo As String, 
            Dim oPrest As New wrPrestamo.wsLibPrest
            Dim pTipoDocumento As String, pLiquidado As String, pFecRes As Date, pNoActaComite As String, pNoActaConsejo As String, pCodDespacho As String, pMontoDemanda As Double, pMontoRecupera As Double, pCapitalSaneado As Double, pSubTipo As String

            If Me.chkDocxCobrar.Checked = True Then
                pTipoDocumento = "C"
                pLiquidado = "0"
                pNoActaComite = Me.txtNoActaDxC.Text.Trim
                pNoActaConsejo = ""
                pFecRes = Me.dtpFecResDxC.Value
                pCodDespacho = Me.txtCodDespacho.Text.Trim
                pMontoDemanda = 0
                pMontoRecupera = 0
                pCapitalSaneado = 0
                pSubTipo = IIf(Me.chkCobroJudicial.Checked = True, "1", "0")
            ElseIf Me.chkDocSaneado.Checked = True Then
                pTipoDocumento = "S"
                pNoActaComite = Me.txtNoActaDS.Text.Trim
                pNoActaConsejo = Me.txtNoActaConsejoAdmon.Text.Trim
                pFecRes = Me.dtpFecResDS.Value
                pCodDespacho = Me.txtCodDespacho.Text.Trim
                pMontoDemanda = Me.c1nMontoDemandaDS.Value
                pMontoRecupera = Me.c1nMontoRecuperadoDS.Value
                pCapitalSaneado = Me.c1nCapitalSaneadoDS.Value
                pSubTipo = ""
                If Me.chkLiquidado.Checked = True Then
                    pLiquidado = "1"
                Else
                    pLiquidado = "0"
                End If
            ElseIf Me.chkDocProtesto.Checked = True Then
                pTipoDocumento = "P"
                pLiquidado = "0"
                pNoActaConsejo = ""
                pCodDespacho = Me.txtCodDespacho.Text.Trim
                pMontoDemanda = Me.c1nMontoDemandaTDS.Value
                pMontoRecupera = Me.c1nMontoRecuperadoTDS.Value
                pCapitalSaneado = 0
                If Me.rbDocSaneamiento.Checked = True Then
                    pSubTipo = "0"
                    pFecRes = Me.dtpFecResDP.Value
                    pNoActaComite = Me.txtNoActaDP.Text.Trim
                ElseIf Me.rbDocSaneados.Checked = True Then
                    pSubTipo = "1"
                    pFecRes = Me.dtpFecResTDS.Value
                    pNoActaComite = Me.txtNoActaTDS.Text.Trim
                End If
            End If

            If Me.btnGuardar1.Text = "&Aperturar documento" Then
                Campos = "CodPrestamo,Dui,Fecha,TipoDocumento,FechaResolucion,NoActa_ComiteMora,NoActa_ConsejoAdmon,SubTipo,CodDespacho,Monto_Demanda,Monto_Recuperado,Capital_Saneado,Liquidado,Observacion,Deudor,CoDeudor,Fiador,MontoCuentasOrden,MontoCuentasxCobrar,SaldoCuentasOrden"
                Valores = "'" & Trim(Me.txtCodPrestamo.Text) & "','" & Me.txtDui.Value & "','" & Me.dtpFecha.Value.ToShortDateString & "','" & pTipoDocumento & "','" & pFecRes.ToShortDateString & "','" & pNoActaComite & "','" & pNoActaConsejo & "','" & pSubTipo & "','" & pCodDespacho & "'," & pMontoDemanda & "," & pMontoRecupera & "," & pCapitalSaneado & ",'" & pLiquidado & "','" & Me.txtObs.Text.Trim & "','" & IIf(Me.chkDeudor.Checked = True, "1", "0") & "','" & IIf(Me.chkCodeudor.Checked = True, "1", "0") & "','" & IIf(Me.chkFiador.Checked = True, "1", "0") & "'," & Me.txtMontoCtasxOrden.Text & "," & Me.txtMontoCtaxCobrar.Text & "," & Me.txtSaldoCtasxOrden.Text & ""
                If oCred.InsertarCBDocumentosxRecuperar(Campos, Valores, Trim(Me.txtCodPrestamo.Text), sUsuario, sPassword, sSucursal) = True Then
                    'Actualizar PrPrestamos
                    oCred.ModificarPrestamos(numSolicitud, "Tipo='" & pTipoDocumento & "',Baja='1',FechaBaja='" & Now.ToShortDateString & "'", sUsuario, sPassword, sSucursal)
                    If pTipoDocumento.Trim <> "" Then oPrest.TrasladoCarteraCobranza(Me.txtCodPrestamo.Text.Trim, sUsuario, sPassword, sSucursal)
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fueron ingresados correctamente.", MsgBoxStyle.Information, "Módulo Cobranza")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                'Guardar Historial
                ds = oCred.ConsultarCBDocumentosxRecuperar("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    If pTipoDocumento <> dr("TipoDocumento") Then
                        Campos = "CodPrestamo,Dui,Fecha,TipoDocumento,FechaResolucion,NoActa_ComiteMora,NoActa_ConsejoAdmon,SubTipo,CodDespacho,Monto_Demanda,Monto_Recuperado,Capital_Saneado,Liquidado,Observacion,Deudor,CoDeudor,Fiador"
                        Valores = "'" & Trim(Me.txtCodPrestamo.Text) & "','" & Me.txtDui.Value & "','" & dr("Fecha") & "','" & dr("TipoDocumento") & "','" & dr("FechaResolucion") & "','" & dr("NoActa_ComiteMora") & "','" & dr("NoActa_ConsejoAdmon") & "','" & dr("SubTipo") & "','" & dr("CodDespacho") & "'," & dr("Monto_Demanda") & "," & dr("Monto_Recuperado") & "," & dr("Capital_Saneado") & ",'" & dr("Liquidado") & "','" & dr("Observacion") & "','" & dr("Deudor") & "','" & dr("CoDeudor") & "','" & dr("Fiador") & "'"
                        oCred.InsertarCBHistDocumentosxRecuperar(Campos, Valores, sUsuario, sPassword, sSucursal)
                    End If
                End If
                CamposValores = "Fecha='" & Me.dtpFecha.Value.ToShortDateString & "',TipoDocumento='" & pTipoDocumento & "',FechaResolucion='" & pFecRes.ToShortDateString & "',NoActa_ComiteMora='" & pNoActaComite & "',NoActa_ConsejoAdmon='" & pNoActaConsejo & "',SubTipo='" & pSubTipo & "',CodDespacho='" & pCodDespacho & "',Monto_Demanda=" & pMontoDemanda & ",Monto_Recuperado=" & pMontoRecupera & ",Capital_Saneado=" & pCapitalSaneado & ",Liquidado='" & pLiquidado & "',Observacion='" & Me.txtObs.Text.Trim & "',Deudor='" & IIf(Me.chkDeudor.Checked = True, "1", "0") & "',Codeudor='" & IIf(Me.chkCodeudor.Checked = True, "1", "0") & "',Fiador='" & IIf(Me.chkFiador.Checked = True, "1", "0") & "',MontoCuentasOrden=" & Me.txtMontoCtasxOrden.Text & ""
                If oCred.ModificarCBDocumentosxRecuperar(CamposValores, "'" & Trim(Me.txtCodPrestamo.Text) & "'", pTipoDocumento, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fueron modificados correctamente", MsgBoxStyle.Information, "Módulo Cobranza")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class