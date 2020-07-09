Public Class frmGarantiasPrendarias
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Dim oItem As wrCredito.wsLibCred = New wrCredito.wsLibCred, vCorr As String
    Friend WithEvents btnSig1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btGuardarRegGar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btDel1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btAtras1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtNotario As System.Windows.Forms.TextBox
    Friend WithEvents txtNoEscritura As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents c1nTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOrdenLibro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaOtorgamiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbTipoGarantia As System.Windows.Forms.ComboBox
    Friend WithEvents gbVehiculo As System.Windows.Forms.GroupBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtCalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtChasisVIN As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents dtpYearV As System.Windows.Forms.DateTimePicker
    Friend WithEvents c1nMontoValuoV As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNoChasisV As System.Windows.Forms.TextBox
    Friend WithEvents txtNoMotorV As System.Windows.Forms.TextBox
    Friend WithEvents txtCapacidadV As System.Windows.Forms.TextBox
    Friend WithEvents txtClaseV As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtTipoV As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtMarcaV As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPlacaV As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtPropietarioV As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents gbOtro As System.Windows.Forms.GroupBox
    Friend WithEvents txtColorO As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents dtAnioO As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCapacidadO As System.Windows.Forms.TextBox
    Friend WithEvents txtModeloO As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtSerieO As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtMarcaO As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoO As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtPropietarioO As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents gbInmueble As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoValuoRI As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtUbicacionRI As System.Windows.Forms.TextBox
    Friend WithEvents txtAreaRI As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtPropietarioRI As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents gbMaquinaria As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoValuoRM As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSerieRM As System.Windows.Forms.TextBox
    Friend WithEvents txtModeloRM As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTipoMaquinaRM As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPropietarioRM As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents ttip As System.Windows.Forms.ToolTip
    Friend WithEvents txtNoPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecInscripcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFecPresentacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents cbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cbEstatusST As System.Windows.Forms.ComboBox
    Friend WithEvents dtFecPresentacionST As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObsST As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPresentacionST As System.Windows.Forms.TextBox
    Friend WithEvents dtFecInscripcionST As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents cbTipoDocEnt As System.Windows.Forms.ComboBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtDeptoRecibe As System.Windows.Forms.TextBox
    Friend WithEvents txtCodDeptoRecibe As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtResponsableEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtDeptoEntrega As System.Windows.Forms.TextBox
    Friend WithEvents txtCodDeptoEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents dtpFecEntDC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionO As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents dtpFecDev As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txtNoInsc As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIns As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGarantiasPrendarias))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtCuotas = New System.Windows.Forms.TextBox()
        Me.c1nPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNotario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoEscritura = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.txtOrdenLibro = New System.Windows.Forms.TextBox()
        Me.c1nTasa = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.c1nMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaOtorgamiento = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btDel1 = New MetroFramework.Controls.MetroButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbTipoGarantia = New System.Windows.Forms.ComboBox()
        Me.gbMaquinaria = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.c1nMontoValuoRM = New C1.Win.C1Input.C1NumericEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSerieRM = New System.Windows.Forms.TextBox()
        Me.txtModeloRM = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTipoMaquinaRM = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPropietarioRM = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.gbVehiculo = New System.Windows.Forms.GroupBox()
        Me.dtpFechaIns = New System.Windows.Forms.DateTimePicker()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtNoInsc = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.gbOtro = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionO = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txtColorO = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.gbInmueble = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.c1nMontoValuoRI = New C1.Win.C1Input.C1NumericEdit()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtUbicacionRI = New System.Windows.Forms.TextBox()
        Me.txtAreaRI = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPropietarioRI = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtAnioO = New System.Windows.Forms.DateTimePicker()
        Me.txtCapacidadO = New System.Windows.Forms.TextBox()
        Me.txtModeloO = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtSerieO = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtMarcaO = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.c1nMontoO = New C1.Win.C1Input.C1NumericEdit()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtPropietarioO = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtCalidad = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtChasisVIN = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.dtpYearV = New System.Windows.Forms.DateTimePicker()
        Me.c1nMontoValuoV = New C1.Win.C1Input.C1NumericEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNoChasisV = New System.Windows.Forms.TextBox()
        Me.txtNoMotorV = New System.Windows.Forms.TextBox()
        Me.txtCapacidadV = New System.Windows.Forms.TextBox()
        Me.txtClaseV = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtTipoV = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtMarcaV = New System.Windows.Forms.TextBox()
        Me.txtNoPlacaV = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtPropietarioV = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.cbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.dtFecPresentacion = New System.Windows.Forms.DateTimePicker()
        Me.txtNoPresentacion = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.dtpFecInscripcion = New System.Windows.Forms.DateTimePicker()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtObsST = New System.Windows.Forms.TextBox()
        Me.cbEstatusST = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.dtFecPresentacionST = New System.Windows.Forms.DateTimePicker()
        Me.txtNoPresentacionST = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.dtFecInscripcionST = New System.Windows.Forms.DateTimePicker()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dtpFecDev = New System.Windows.Forms.DateTimePicker()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.cbTipoDocEnt = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtDeptoRecibe = New System.Windows.Forms.TextBox()
        Me.txtCodDeptoRecibe = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtResponsableEntrega = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtDeptoEntrega = New System.Windows.Forms.TextBox()
        Me.txtCodDeptoEntrega = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.dtpFecEntDC = New System.Windows.Forms.DateTimePicker()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSig1 = New MetroFramework.Controls.MetroButton()
        Me.btGuardarRegGar1 = New MetroFramework.Controls.MetroButton()
        Me.btAtras1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMaquinaria.SuspendLayout()
        CType(Me.c1nMontoValuoRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVehiculo.SuspendLayout()
        Me.gbOtro.SuspendLayout()
        Me.gbInmueble.SuspendLayout()
        CType(Me.c1nMontoValuoRI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoValuoV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(23, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(643, 410)
        Me.TabControl1.TabIndex = 171
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.txtCuotas)
        Me.TabPage1.Controls.Add(Me.c1nPlazo)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtTipoCredito)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label65)
        Me.TabPage1.Controls.Add(Me.txtDui)
        Me.TabPage1.Controls.Add(Me.txtNotario)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtNoEscritura)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtNoSocio)
        Me.TabPage1.Controls.Add(Me.txtOrdenLibro)
        Me.TabPage1.Controls.Add(Me.c1nTasa)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtCodPrestamo)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.c1nMonto)
        Me.TabPage1.Controls.Add(Me.txtAsociado)
        Me.TabPage1.Controls.Add(Me.dtpFechaVencimiento)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.dtpFechaOtorgamiento)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(635, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        '
        'txtCuotas
        '
        Me.txtCuotas.BackColor = System.Drawing.Color.White
        Me.txtCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuotas.Enabled = False
        Me.txtCuotas.Location = New System.Drawing.Point(100, 146)
        Me.txtCuotas.Name = "txtCuotas"
        Me.txtCuotas.ReadOnly = True
        Me.txtCuotas.Size = New System.Drawing.Size(181, 20)
        Me.txtCuotas.TabIndex = 11
        '
        'c1nPlazo
        '
        Me.c1nPlazo.BackColor = System.Drawing.Color.White
        Me.c1nPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPlazo.CustomFormat = "#0"
        Me.c1nPlazo.DataType = GetType(Short)
        Me.c1nPlazo.Enabled = False
        Me.c1nPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazo.Increment = CType(1, Short)
        Me.c1nPlazo.Location = New System.Drawing.Point(451, 119)
        Me.c1nPlazo.MaxLength = 2
        Me.c1nPlazo.Name = "c1nPlazo"
        Me.c1nPlazo.ReadOnly = True
        Me.c1nPlazo.ShowDropDownButton = False
        Me.c1nPlazo.ShowUpDownButtons = False
        Me.c1nPlazo.Size = New System.Drawing.Size(181, 21)
        Me.c1nPlazo.TabIndex = 10
        Me.c1nPlazo.Tag = Nothing
        Me.c1nPlazo.Value = CType(0, Short)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Nº de Cuotas:"
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCredito.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCredito.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTipoCredito.Location = New System.Drawing.Point(100, 228)
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.ReadOnly = True
        Me.txtTipoCredito.Size = New System.Drawing.Size(532, 21)
        Me.txtTipoCredito.TabIndex = 174
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 169
        Me.Label14.Text = "DUI:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(343, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Plazo:"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(14, 231)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(84, 13)
        Me.Label65.TabIndex = 173
        Me.Label65.Text = "Tipo de Crédito:"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDui.Location = New System.Drawing.Point(100, 10)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(181, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtNotario
        '
        Me.txtNotario.BackColor = System.Drawing.Color.White
        Me.txtNotario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNotario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotario.Location = New System.Drawing.Point(100, 202)
        Me.txtNotario.Name = "txtNotario"
        Me.txtNotario.Size = New System.Drawing.Size(532, 20)
        Me.txtNotario.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "No. Asociado:"
        '
        'txtNoEscritura
        '
        Me.txtNoEscritura.BackColor = System.Drawing.Color.White
        Me.txtNoEscritura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoEscritura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoEscritura.Location = New System.Drawing.Point(451, 178)
        Me.txtNoEscritura.Name = "txtNoEscritura"
        Me.txtNoEscritura.Size = New System.Drawing.Size(181, 20)
        Me.txtNoEscritura.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Notario:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(451, 10)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(181, 20)
        Me.txtNoSocio.TabIndex = 1
        Me.txtNoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOrdenLibro
        '
        Me.txtOrdenLibro.BackColor = System.Drawing.Color.White
        Me.txtOrdenLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrdenLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenLibro.Location = New System.Drawing.Point(100, 176)
        Me.txtOrdenLibro.Name = "txtOrdenLibro"
        Me.txtOrdenLibro.Size = New System.Drawing.Size(181, 20)
        Me.txtOrdenLibro.TabIndex = 4
        '
        'c1nTasa
        '
        Me.c1nTasa.BackColor = System.Drawing.Color.White
        Me.c1nTasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasa.CustomFormat = "#0.00"
        Me.c1nTasa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTasa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasa.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nTasa.Location = New System.Drawing.Point(100, 119)
        Me.c1nTasa.Name = "c1nTasa"
        Me.c1nTasa.ReadOnly = True
        Me.c1nTasa.ShowDropDownButton = False
        Me.c1nTasa.ShowUpDownButtons = False
        Me.c1nTasa.Size = New System.Drawing.Size(181, 21)
        Me.c1nTasa.TabIndex = 12
        Me.c1nTasa.Tag = Nothing
        Me.c1nTasa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Orden de Libro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(343, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Escritura:"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.Location = New System.Drawing.Point(100, 67)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(181, 20)
        Me.txtCodPrestamo.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 166
        Me.Label11.Text = "Asociado:"
        '
        'c1nMonto
        '
        Me.c1nMonto.BackColor = System.Drawing.Color.White
        Me.c1nMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMonto.CustomFormat = "###,###,##0.00"
        Me.c1nMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMonto.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMonto.Location = New System.Drawing.Point(451, 92)
        Me.c1nMonto.Name = "c1nMonto"
        Me.c1nMonto.ReadOnly = True
        Me.c1nMonto.ShowDropDownButton = False
        Me.c1nMonto.ShowUpDownButtons = False
        Me.c1nMonto.Size = New System.Drawing.Size(181, 21)
        Me.c1nMonto.TabIndex = 9
        Me.c1nMonto.Tag = Nothing
        Me.c1nMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(100, 40)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(532, 21)
        Me.txtAsociado.TabIndex = 1
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(100, 93)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(181, 20)
        Me.dtpFechaVencimiento.TabIndex = 7
        Me.dtpFechaVencimiento.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "*Préstamo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = "Vencimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(343, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Otorgamiento:"
        '
        'dtpFechaOtorgamiento
        '
        Me.dtpFechaOtorgamiento.Enabled = False
        Me.dtpFechaOtorgamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaOtorgamiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaOtorgamiento.Location = New System.Drawing.Point(451, 67)
        Me.dtpFechaOtorgamiento.Name = "dtpFechaOtorgamiento"
        Me.dtpFechaOtorgamiento.Size = New System.Drawing.Size(181, 20)
        Me.dtpFechaOtorgamiento.TabIndex = 6
        Me.dtpFechaOtorgamiento.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Tasa:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(343, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Monto:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.btDel1)
        Me.TabPage2.Controls.Add(Me.fg)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.cbTipoGarantia)
        Me.TabPage2.Controls.Add(Me.gbVehiculo)
        Me.TabPage2.Controls.Add(Me.gbInmueble)
        Me.TabPage2.Controls.Add(Me.gbMaquinaria)
        Me.TabPage2.Controls.Add(Me.gbOtro)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(635, 384)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registro Garantías"
        '
        'btDel1
        '
        Me.btDel1.Location = New System.Drawing.Point(11, 230)
        Me.btDel1.Name = "btDel1"
        Me.btDel1.Size = New System.Drawing.Size(75, 28)
        Me.btDel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDel1.TabIndex = 213
        Me.btDel1.Text = "Eliminar"
        Me.btDel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDel1.UseSelectable = True
        Me.btDel1.UseStyleColors = True
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(11, 260)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Size = New System.Drawing.Size(612, 113)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 3
        Me.ttip.SetToolTip(Me.fg, "Presione doble clic para modificar registro seleccionado")
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "Tipo de garantía:"
        '
        'cbTipoGarantia
        '
        Me.cbTipoGarantia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoGarantia.Items.AddRange(New Object() {"Inmueble", "Vehículo", "Maquinaria", "Otro (a)"})
        Me.cbTipoGarantia.Location = New System.Drawing.Point(136, 8)
        Me.cbTipoGarantia.Name = "cbTipoGarantia"
        Me.cbTipoGarantia.Size = New System.Drawing.Size(256, 21)
        Me.cbTipoGarantia.TabIndex = 0
        '
        'gbMaquinaria
        '
        Me.gbMaquinaria.BackColor = System.Drawing.Color.White
        Me.gbMaquinaria.Controls.Add(Me.txtDescripcion)
        Me.gbMaquinaria.Controls.Add(Me.Label38)
        Me.gbMaquinaria.Controls.Add(Me.c1nMontoValuoRM)
        Me.gbMaquinaria.Controls.Add(Me.Label22)
        Me.gbMaquinaria.Controls.Add(Me.txtSerieRM)
        Me.gbMaquinaria.Controls.Add(Me.txtModeloRM)
        Me.gbMaquinaria.Controls.Add(Me.Label15)
        Me.gbMaquinaria.Controls.Add(Me.Label18)
        Me.gbMaquinaria.Controls.Add(Me.txtTipoMaquinaRM)
        Me.gbMaquinaria.Controls.Add(Me.Label19)
        Me.gbMaquinaria.Controls.Add(Me.txtPropietarioRM)
        Me.gbMaquinaria.Controls.Add(Me.Label17)
        Me.gbMaquinaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMaquinaria.ForeColor = System.Drawing.Color.Teal
        Me.gbMaquinaria.Location = New System.Drawing.Point(13, 43)
        Me.gbMaquinaria.Name = "gbMaquinaria"
        Me.gbMaquinaria.Size = New System.Drawing.Size(612, 130)
        Me.gbMaquinaria.TabIndex = 174
        Me.gbMaquinaria.TabStop = False
        Me.gbMaquinaria.Text = "Registro de Maquinaria"
        Me.gbMaquinaria.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(85, 76)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(511, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(8, 78)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(65, 13)
        Me.Label38.TabIndex = 45
        Me.Label38.Text = "Descripción:"
        '
        'c1nMontoValuoRM
        '
        Me.c1nMontoValuoRM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoValuoRM.CustomFormat = "###,###,##0.00"
        Me.c1nMontoValuoRM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoValuoRM.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontoValuoRM.Location = New System.Drawing.Point(380, 102)
        Me.c1nMontoValuoRM.Name = "c1nMontoValuoRM"
        Me.c1nMontoValuoRM.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoValuoRM.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoValuoRM.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoValuoRM.ShowDropDownButton = False
        Me.c1nMontoValuoRM.ShowUpDownButtons = False
        Me.c1nMontoValuoRM.Size = New System.Drawing.Size(216, 21)
        Me.c1nMontoValuoRM.TabIndex = 5
        Me.c1nMontoValuoRM.Tag = Nothing
        Me.c1nMontoValuoRM.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(304, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 13)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "Monto Valúo:"
        '
        'txtSerieRM
        '
        Me.txtSerieRM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerieRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieRM.Location = New System.Drawing.Point(85, 102)
        Me.txtSerieRM.Name = "txtSerieRM"
        Me.txtSerieRM.Size = New System.Drawing.Size(216, 20)
        Me.txtSerieRM.TabIndex = 4
        '
        'txtModeloRM
        '
        Me.txtModeloRM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModeloRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloRM.Location = New System.Drawing.Point(380, 50)
        Me.txtModeloRM.Name = "txtModeloRM"
        Me.txtModeloRM.Size = New System.Drawing.Size(216, 20)
        Me.txtModeloRM.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Serie:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(307, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Modelo:"
        '
        'txtTipoMaquinaRM
        '
        Me.txtTipoMaquinaRM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoMaquinaRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoMaquinaRM.Location = New System.Drawing.Point(85, 50)
        Me.txtTipoMaquinaRM.Name = "txtTipoMaquinaRM"
        Me.txtTipoMaquinaRM.Size = New System.Drawing.Size(216, 20)
        Me.txtTipoMaquinaRM.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(6, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Tipo Maquina:"
        '
        'txtPropietarioRM
        '
        Me.txtPropietarioRM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPropietarioRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietarioRM.Location = New System.Drawing.Point(85, 24)
        Me.txtPropietarioRM.Name = "txtPropietarioRM"
        Me.txtPropietarioRM.Size = New System.Drawing.Size(511, 20)
        Me.txtPropietarioRM.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(6, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Propietario:"
        '
        'gbVehiculo
        '
        Me.gbVehiculo.BackColor = System.Drawing.Color.White
        Me.gbVehiculo.Controls.Add(Me.dtpFechaIns)
        Me.gbVehiculo.Controls.Add(Me.Label67)
        Me.gbVehiculo.Controls.Add(Me.txtNoInsc)
        Me.gbVehiculo.Controls.Add(Me.Label66)
        Me.gbVehiculo.Controls.Add(Me.txtColor)
        Me.gbVehiculo.Controls.Add(Me.Label37)
        Me.gbVehiculo.Controls.Add(Me.txtCalidad)
        Me.gbVehiculo.Controls.Add(Me.Label36)
        Me.gbVehiculo.Controls.Add(Me.txtChasisVIN)
        Me.gbVehiculo.Controls.Add(Me.Label35)
        Me.gbVehiculo.Controls.Add(Me.dtpYearV)
        Me.gbVehiculo.Controls.Add(Me.c1nMontoValuoV)
        Me.gbVehiculo.Controls.Add(Me.Label16)
        Me.gbVehiculo.Controls.Add(Me.txtNoChasisV)
        Me.gbVehiculo.Controls.Add(Me.txtNoMotorV)
        Me.gbVehiculo.Controls.Add(Me.txtCapacidadV)
        Me.gbVehiculo.Controls.Add(Me.txtClaseV)
        Me.gbVehiculo.Controls.Add(Me.Label23)
        Me.gbVehiculo.Controls.Add(Me.Label24)
        Me.gbVehiculo.Controls.Add(Me.Label25)
        Me.gbVehiculo.Controls.Add(Me.Label26)
        Me.gbVehiculo.Controls.Add(Me.Label29)
        Me.gbVehiculo.Controls.Add(Me.txtTipoV)
        Me.gbVehiculo.Controls.Add(Me.Label27)
        Me.gbVehiculo.Controls.Add(Me.txtMarcaV)
        Me.gbVehiculo.Controls.Add(Me.txtNoPlacaV)
        Me.gbVehiculo.Controls.Add(Me.Label30)
        Me.gbVehiculo.Controls.Add(Me.txtPropietarioV)
        Me.gbVehiculo.Controls.Add(Me.Label33)
        Me.gbVehiculo.Controls.Add(Me.Label28)
        Me.gbVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVehiculo.ForeColor = System.Drawing.Color.Teal
        Me.gbVehiculo.Location = New System.Drawing.Point(14, 35)
        Me.gbVehiculo.Name = "gbVehiculo"
        Me.gbVehiculo.Size = New System.Drawing.Size(612, 189)
        Me.gbVehiculo.TabIndex = 1
        Me.gbVehiculo.TabStop = False
        Me.gbVehiculo.Text = "Registro de Vehículo:"
        Me.gbVehiculo.Visible = False
        '
        'dtpFechaIns
        '
        Me.dtpFechaIns.CustomFormat = ""
        Me.dtpFechaIns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIns.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIns.Location = New System.Drawing.Point(468, 149)
        Me.dtpFechaIns.Name = "dtpFechaIns"
        Me.dtpFechaIns.Size = New System.Drawing.Size(128, 20)
        Me.dtpFechaIns.TabIndex = 14
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(330, 151)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(132, 13)
        Me.Label67.TabIndex = 52
        Me.Label67.Text = "Fecha de Inscripción VMT:"
        '
        'txtNoInsc
        '
        Me.txtNoInsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoInsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoInsc.Location = New System.Drawing.Point(85, 149)
        Me.txtNoInsc.MaxLength = 20
        Me.txtNoInsc.Name = "txtNoInsc"
        Me.txtNoInsc.Size = New System.Drawing.Size(128, 20)
        Me.txtNoInsc.TabIndex = 13
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(8, 146)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(77, 26)
        Me.Label66.TabIndex = 50
        Me.Label66.Text = "No Inscripción " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VMT:"
        '
        'txtColor
        '
        Me.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(274, 123)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(128, 20)
        Me.txtColor.TabIndex = 11
        '
        'gbOtro
        '
        Me.gbOtro.BackColor = System.Drawing.Color.White
        Me.gbOtro.Controls.Add(Me.txtDescripcionO)
        Me.gbOtro.Controls.Add(Me.Label64)
        Me.gbOtro.Controls.Add(Me.txtColorO)
        Me.gbOtro.Controls.Add(Me.Label45)
        Me.gbOtro.Controls.Add(Me.dtAnioO)
        Me.gbOtro.Controls.Add(Me.txtCapacidadO)
        Me.gbOtro.Controls.Add(Me.txtModeloO)
        Me.gbOtro.Controls.Add(Me.Label46)
        Me.gbOtro.Controls.Add(Me.Label47)
        Me.gbOtro.Controls.Add(Me.Label48)
        Me.gbOtro.Controls.Add(Me.txtSerieO)
        Me.gbOtro.Controls.Add(Me.Label49)
        Me.gbOtro.Controls.Add(Me.txtMarcaO)
        Me.gbOtro.Controls.Add(Me.Label50)
        Me.gbOtro.Controls.Add(Me.c1nMontoO)
        Me.gbOtro.Controls.Add(Me.Label52)
        Me.gbOtro.Controls.Add(Me.txtPropietarioO)
        Me.gbOtro.Controls.Add(Me.Button1)
        Me.gbOtro.Controls.Add(Me.Button4)
        Me.gbOtro.Controls.Add(Me.Label55)
        Me.gbOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOtro.ForeColor = System.Drawing.Color.Teal
        Me.gbOtro.Location = New System.Drawing.Point(13, 43)
        Me.gbOtro.Name = "gbOtro"
        Me.gbOtro.Size = New System.Drawing.Size(612, 153)
        Me.gbOtro.TabIndex = 176
        Me.gbOtro.TabStop = False
        Me.gbOtro.Text = "Otro (a)"
        Me.gbOtro.Visible = False
        '
        'txtDescripcionO
        '
        Me.txtDescripcionO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionO.Location = New System.Drawing.Point(85, 125)
        Me.txtDescripcionO.Name = "txtDescripcionO"
        Me.txtDescripcionO.Size = New System.Drawing.Size(511, 20)
        Me.txtDescripcionO.TabIndex = 8
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Black
        Me.Label64.Location = New System.Drawing.Point(8, 127)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(65, 13)
        Me.Label64.TabIndex = 63
        Me.Label64.Text = "Descripción:"
        '
        'txtColorO
        '
        Me.txtColorO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColorO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColorO.Location = New System.Drawing.Point(468, 70)
        Me.txtColorO.Name = "txtColorO"
        Me.txtColorO.Size = New System.Drawing.Size(128, 20)
        Me.txtColorO.TabIndex = 6
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(408, 72)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(36, 13)
        Me.Label45.TabIndex = 61
        Me.Label45.Text = "Color:"
        '
        'gbInmueble
        '
        Me.gbInmueble.BackColor = System.Drawing.Color.White
        Me.gbInmueble.Controls.Add(Me.Label34)
        Me.gbInmueble.Controls.Add(Me.c1nMontoValuoRI)
        Me.gbInmueble.Controls.Add(Me.Label32)
        Me.gbInmueble.Controls.Add(Me.txtUbicacionRI)
        Me.gbInmueble.Controls.Add(Me.txtAreaRI)
        Me.gbInmueble.Controls.Add(Me.Label31)
        Me.gbInmueble.Controls.Add(Me.Label20)
        Me.gbInmueble.Controls.Add(Me.txtPropietarioRI)
        Me.gbInmueble.Controls.Add(Me.Button2)
        Me.gbInmueble.Controls.Add(Me.Button3)
        Me.gbInmueble.Controls.Add(Me.Label21)
        Me.gbInmueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInmueble.ForeColor = System.Drawing.Color.Teal
        Me.gbInmueble.Location = New System.Drawing.Point(11, 35)
        Me.gbInmueble.Name = "gbInmueble"
        Me.gbInmueble.Size = New System.Drawing.Size(612, 101)
        Me.gbInmueble.TabIndex = 173
        Me.gbInmueble.TabStop = False
        Me.gbInmueble.Text = "Inmueble"
        Me.gbInmueble.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(268, 78)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(33, 13)
        Me.Label34.TabIndex = 43
        Me.Label34.Text = "(mt2)"
        '
        'c1nMontoValuoRI
        '
        Me.c1nMontoValuoRI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoValuoRI.CustomFormat = "###,###,##0.00"
        Me.c1nMontoValuoRI.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoValuoRI.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontoValuoRI.Location = New System.Drawing.Point(380, 71)
        Me.c1nMontoValuoRI.Name = "c1nMontoValuoRI"
        Me.c1nMontoValuoRI.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoValuoRI.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoValuoRI.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoValuoRI.ShowDropDownButton = False
        Me.c1nMontoValuoRI.ShowUpDownButtons = False
        Me.c1nMontoValuoRI.Size = New System.Drawing.Size(216, 21)
        Me.c1nMontoValuoRI.TabIndex = 3
        Me.c1nMontoValuoRI.Tag = Nothing
        Me.c1nMontoValuoRI.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(304, 78)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 13)
        Me.Label32.TabIndex = 42
        Me.Label32.Text = "Monto Valúo:"
        '
        'txtUbicacionRI
        '
        Me.txtUbicacionRI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUbicacionRI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacionRI.Location = New System.Drawing.Point(85, 19)
        Me.txtUbicacionRI.Name = "txtUbicacionRI"
        Me.txtUbicacionRI.Size = New System.Drawing.Size(511, 20)
        Me.txtUbicacionRI.TabIndex = 1
        '
        'txtAreaRI
        '
        Me.txtAreaRI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAreaRI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaRI.Location = New System.Drawing.Point(85, 71)
        Me.txtAreaRI.Name = "txtAreaRI"
        Me.txtAreaRI.Size = New System.Drawing.Size(177, 20)
        Me.txtAreaRI.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(8, 21)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(56, 13)
        Me.Label31.TabIndex = 39
        Me.Label31.Text = "Ubicación:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(9, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 26)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Área del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inmueble:"
        '
        'txtPropietarioRI
        '
        Me.txtPropietarioRI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPropietarioRI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietarioRI.Location = New System.Drawing.Point(85, 45)
        Me.txtPropietarioRI.Name = "txtPropietarioRI"
        Me.txtPropietarioRI.Size = New System.Drawing.Size(511, 20)
        Me.txtPropietarioRI.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(544, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "     &Cerrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(456, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "&Guardar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(8, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Propietario:"
        '
        'dtAnioO
        '
        Me.dtAnioO.CustomFormat = "yyyy"
        Me.dtAnioO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAnioO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAnioO.Location = New System.Drawing.Point(85, 72)
        Me.dtAnioO.Name = "dtAnioO"
        Me.dtAnioO.Size = New System.Drawing.Size(128, 20)
        Me.dtAnioO.TabIndex = 4
        '
        'txtCapacidadO
        '
        Me.txtCapacidadO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCapacidadO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidadO.Location = New System.Drawing.Point(274, 70)
        Me.txtCapacidadO.Name = "txtCapacidadO"
        Me.txtCapacidadO.Size = New System.Drawing.Size(129, 20)
        Me.txtCapacidadO.TabIndex = 5
        '
        'txtModeloO
        '
        Me.txtModeloO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtModeloO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloO.Location = New System.Drawing.Point(468, 44)
        Me.txtModeloO.Name = "txtModeloO"
        Me.txtModeloO.Size = New System.Drawing.Size(128, 20)
        Me.txtModeloO.TabIndex = 3
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(216, 72)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(61, 13)
        Me.Label46.TabIndex = 60
        Me.Label46.Text = "Capacidad:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(8, 78)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(30, 13)
        Me.Label47.TabIndex = 59
        Me.Label47.Text = "Año:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(408, 48)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(45, 13)
        Me.Label48.TabIndex = 58
        Me.Label48.Text = "Modelo:"
        '
        'txtSerieO
        '
        Me.txtSerieO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerieO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieO.Location = New System.Drawing.Point(274, 44)
        Me.txtSerieO.Name = "txtSerieO"
        Me.txtSerieO.Size = New System.Drawing.Size(129, 20)
        Me.txtSerieO.TabIndex = 2
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(219, 48)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(35, 13)
        Me.Label49.TabIndex = 57
        Me.Label49.Text = "Serie:"
        '
        'txtMarcaO
        '
        Me.txtMarcaO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarcaO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaO.Location = New System.Drawing.Point(85, 46)
        Me.txtMarcaO.Name = "txtMarcaO"
        Me.txtMarcaO.Size = New System.Drawing.Size(128, 20)
        Me.txtMarcaO.TabIndex = 1
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(8, 48)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(40, 13)
        Me.Label50.TabIndex = 56
        Me.Label50.Text = "Marca:"
        '
        'c1nMontoO
        '
        Me.c1nMontoO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoO.CustomFormat = "###,###,##0.00"
        Me.c1nMontoO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoO.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontoO.Location = New System.Drawing.Point(85, 98)
        Me.c1nMontoO.Name = "c1nMontoO"
        Me.c1nMontoO.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoO.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoO.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoO.ShowDropDownButton = False
        Me.c1nMontoO.ShowUpDownButtons = False
        Me.c1nMontoO.Size = New System.Drawing.Size(128, 21)
        Me.c1nMontoO.TabIndex = 7
        Me.c1nMontoO.Tag = Nothing
        Me.c1nMontoO.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(8, 108)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(70, 13)
        Me.Label52.TabIndex = 42
        Me.Label52.Text = "Monto Valúo:"
        '
        'txtPropietarioO
        '
        Me.txtPropietarioO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPropietarioO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietarioO.Location = New System.Drawing.Point(85, 18)
        Me.txtPropietarioO.Name = "txtPropietarioO"
        Me.txtPropietarioO.Size = New System.Drawing.Size(511, 20)
        Me.txtPropietarioO.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(544, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "     &Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(456, 296)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "&Guardar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(6, 25)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(63, 13)
        Me.Label55.TabIndex = 22
        Me.Label55.Text = "Propietario:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(219, 125)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(36, 13)
        Me.Label37.TabIndex = 49
        Me.Label37.Text = "Color:"
        '
        'txtCalidad
        '
        Me.txtCalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalidad.Location = New System.Drawing.Point(85, 123)
        Me.txtCalidad.Name = "txtCalidad"
        Me.txtCalidad.Size = New System.Drawing.Size(128, 20)
        Me.txtCalidad.TabIndex = 10
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(6, 125)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(59, 13)
        Me.Label36.TabIndex = 47
        Me.Label36.Text = "En calidad:"
        '
        'txtChasisVIN
        '
        Me.txtChasisVIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChasisVIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChasisVIN.Location = New System.Drawing.Point(468, 97)
        Me.txtChasisVIN.Name = "txtChasisVIN"
        Me.txtChasisVIN.Size = New System.Drawing.Size(128, 20)
        Me.txtChasisVIN.TabIndex = 9
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(408, 94)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(57, 26)
        Me.Label35.TabIndex = 45
        Me.Label35.Text = "No Chasis " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VIN:"
        '
        'dtpYearV
        '
        Me.dtpYearV.CustomFormat = "yyyy"
        Me.dtpYearV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpYearV.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYearV.Location = New System.Drawing.Point(274, 71)
        Me.dtpYearV.Name = "dtpYearV"
        Me.dtpYearV.Size = New System.Drawing.Size(128, 20)
        Me.dtpYearV.TabIndex = 5
        '
        'c1nMontoValuoV
        '
        Me.c1nMontoValuoV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoValuoV.CustomFormat = "###,###,##0.00"
        Me.c1nMontoValuoV.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoValuoV.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontoValuoV.Location = New System.Drawing.Point(468, 122)
        Me.c1nMontoValuoV.Name = "c1nMontoValuoV"
        Me.c1nMontoValuoV.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoValuoV.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoValuoV.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoValuoV.ShowDropDownButton = False
        Me.c1nMontoValuoV.ShowUpDownButtons = False
        Me.c1nMontoValuoV.Size = New System.Drawing.Size(128, 21)
        Me.c1nMontoValuoV.TabIndex = 12
        Me.c1nMontoValuoV.Tag = Nothing
        Me.c1nMontoValuoV.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(408, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 26)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Monto " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Valúo:"
        '
        'txtNoChasisV
        '
        Me.txtNoChasisV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoChasisV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoChasisV.Location = New System.Drawing.Point(274, 97)
        Me.txtNoChasisV.Name = "txtNoChasisV"
        Me.txtNoChasisV.Size = New System.Drawing.Size(128, 20)
        Me.txtNoChasisV.TabIndex = 8
        '
        'txtNoMotorV
        '
        Me.txtNoMotorV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoMotorV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoMotorV.Location = New System.Drawing.Point(85, 97)
        Me.txtNoMotorV.Name = "txtNoMotorV"
        Me.txtNoMotorV.Size = New System.Drawing.Size(128, 20)
        Me.txtNoMotorV.TabIndex = 7
        '
        'txtCapacidadV
        '
        Me.txtCapacidadV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCapacidadV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidadV.Location = New System.Drawing.Point(468, 71)
        Me.txtCapacidadV.Name = "txtCapacidadV"
        Me.txtCapacidadV.Size = New System.Drawing.Size(128, 20)
        Me.txtCapacidadV.TabIndex = 6
        '
        'txtClaseV
        '
        Me.txtClaseV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClaseV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaseV.Location = New System.Drawing.Point(85, 71)
        Me.txtClaseV.Name = "txtClaseV"
        Me.txtClaseV.Size = New System.Drawing.Size(128, 20)
        Me.txtClaseV.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(219, 94)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 26)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "No Chasis " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gravado:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(6, 99)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 13)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "No de Motor:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(408, 73)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 13)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Capacidad:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(219, 73)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(30, 13)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "Año:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(6, 73)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(37, 13)
        Me.Label29.TabIndex = 32
        Me.Label29.Text = "Clase:"
        '
        'txtTipoV
        '
        Me.txtTipoV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoV.Location = New System.Drawing.Point(468, 45)
        Me.txtTipoV.Name = "txtTipoV"
        Me.txtTipoV.Size = New System.Drawing.Size(128, 20)
        Me.txtTipoV.TabIndex = 3
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(408, 47)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 13)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Tipo:"
        '
        'txtMarcaV
        '
        Me.txtMarcaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarcaV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaV.Location = New System.Drawing.Point(274, 45)
        Me.txtMarcaV.Name = "txtMarcaV"
        Me.txtMarcaV.Size = New System.Drawing.Size(128, 20)
        Me.txtMarcaV.TabIndex = 2
        '
        'txtNoPlacaV
        '
        Me.txtNoPlacaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPlacaV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPlacaV.Location = New System.Drawing.Point(85, 45)
        Me.txtNoPlacaV.Name = "txtNoPlacaV"
        Me.txtNoPlacaV.Size = New System.Drawing.Size(128, 20)
        Me.txtNoPlacaV.TabIndex = 1
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(6, 47)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(52, 13)
        Me.Label30.TabIndex = 26
        Me.Label30.Text = "No Placa:"
        '
        'txtPropietarioV
        '
        Me.txtPropietarioV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPropietarioV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietarioV.Location = New System.Drawing.Point(85, 19)
        Me.txtPropietarioV.Name = "txtPropietarioV"
        Me.txtPropietarioV.Size = New System.Drawing.Size(511, 20)
        Me.txtPropietarioV.TabIndex = 0
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(6, 21)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 13)
        Me.Label33.TabIndex = 24
        Me.Label33.Text = "Propietario:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(219, 47)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 13)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "Marca:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.txtObs)
        Me.TabPage3.Controls.Add(Me.cbEstatus)
        Me.TabPage3.Controls.Add(Me.Label51)
        Me.TabPage3.Controls.Add(Me.dtFecPresentacion)
        Me.TabPage3.Controls.Add(Me.txtNoPresentacion)
        Me.TabPage3.Controls.Add(Me.Label58)
        Me.TabPage3.Controls.Add(Me.dtpFecInscripcion)
        Me.TabPage3.Controls.Add(Me.Label53)
        Me.TabPage3.Controls.Add(Me.Label54)
        Me.TabPage3.Controls.Add(Me.Label44)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(635, 384)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Proceso CNR"
        '
        'txtObs
        '
        Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(129, 66)
        Me.txtObs.MaxLength = 255
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(427, 48)
        Me.txtObs.TabIndex = 4
        '
        'cbEstatus
        '
        Me.cbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstatus.Items.AddRange(New Object() {"Observada", "Inscrita", "En Calificación", "Retirada sin inscribir"})
        Me.cbEstatus.Location = New System.Drawing.Point(356, 39)
        Me.cbEstatus.Name = "cbEstatus"
        Me.cbEstatus.Size = New System.Drawing.Size(200, 21)
        Me.cbEstatus.TabIndex = 3
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(3, 68)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(82, 13)
        Me.Label51.TabIndex = 3
        Me.Label51.Text = "Observaciones:"
        '
        'dtFecPresentacion
        '
        Me.dtFecPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecPresentacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecPresentacion.Location = New System.Drawing.Point(129, 13)
        Me.dtFecPresentacion.Name = "dtFecPresentacion"
        Me.dtFecPresentacion.Size = New System.Drawing.Size(122, 20)
        Me.dtFecPresentacion.TabIndex = 0
        Me.dtFecPresentacion.Value = New Date(2017, 12, 11, 0, 0, 0, 0)
        '
        'txtNoPresentacion
        '
        Me.txtNoPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPresentacion.Location = New System.Drawing.Point(356, 13)
        Me.txtNoPresentacion.MaxLength = 25
        Me.txtNoPresentacion.Name = "txtNoPresentacion"
        Me.txtNoPresentacion.Size = New System.Drawing.Size(122, 20)
        Me.txtNoPresentacion.TabIndex = 1
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(257, 43)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(47, 13)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "Estatus:"
        '
        'dtpFecInscripcion
        '
        Me.dtpFecInscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecInscripcion.Location = New System.Drawing.Point(129, 39)
        Me.dtpFecInscripcion.Name = "dtpFecInscripcion"
        Me.dtpFecInscripcion.Size = New System.Drawing.Size(122, 20)
        Me.dtpFecInscripcion.TabIndex = 2
        Me.dtpFecInscripcion.Value = New Date(2017, 12, 11, 0, 0, 0, 0)
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(3, 43)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(109, 13)
        Me.Label53.TabIndex = 4
        Me.Label53.Text = "Fecha de Inscripción:"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(3, 13)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(120, 13)
        Me.Label54.TabIndex = 2
        Me.Label54.Text = "Fecha de Presentación:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(257, 13)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(93, 13)
        Me.Label44.TabIndex = 1
        Me.Label44.Text = "No. Presentación:"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.txtObsST)
        Me.TabPage4.Controls.Add(Me.cbEstatusST)
        Me.TabPage4.Controls.Add(Me.Label40)
        Me.TabPage4.Controls.Add(Me.dtFecPresentacionST)
        Me.TabPage4.Controls.Add(Me.txtNoPresentacionST)
        Me.TabPage4.Controls.Add(Me.Label43)
        Me.TabPage4.Controls.Add(Me.dtFecInscripcionST)
        Me.TabPage4.Controls.Add(Me.Label41)
        Me.TabPage4.Controls.Add(Me.Label42)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(635, 384)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Proceso SERTRACEN"
        '
        'txtObsST
        '
        Me.txtObsST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsST.Location = New System.Drawing.Point(129, 62)
        Me.txtObsST.MaxLength = 255
        Me.txtObsST.Multiline = True
        Me.txtObsST.Name = "txtObsST"
        Me.txtObsST.Size = New System.Drawing.Size(432, 48)
        Me.txtObsST.TabIndex = 4
        '
        'cbEstatusST
        '
        Me.cbEstatusST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstatusST.Items.AddRange(New Object() {"Observada", "Inscrita", "En Calificación", "Retirada sin inscribir"})
        Me.cbEstatusST.Location = New System.Drawing.Point(361, 33)
        Me.cbEstatusST.Name = "cbEstatusST"
        Me.cbEstatusST.Size = New System.Drawing.Size(200, 21)
        Me.cbEstatusST.TabIndex = 3
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(3, 64)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(82, 13)
        Me.Label40.TabIndex = 3
        Me.Label40.Text = "Observaciones:"
        '
        'dtFecPresentacionST
        '
        Me.dtFecPresentacionST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecPresentacionST.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecPresentacionST.Location = New System.Drawing.Point(129, 10)
        Me.dtFecPresentacionST.Name = "dtFecPresentacionST"
        Me.dtFecPresentacionST.Size = New System.Drawing.Size(127, 20)
        Me.dtFecPresentacionST.TabIndex = 0
        Me.dtFecPresentacionST.Value = New Date(2017, 12, 11, 0, 0, 0, 0)
        '
        'txtNoPresentacionST
        '
        Me.txtNoPresentacionST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPresentacionST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPresentacionST.Location = New System.Drawing.Point(361, 8)
        Me.txtNoPresentacionST.MaxLength = 25
        Me.txtNoPresentacionST.Name = "txtNoPresentacionST"
        Me.txtNoPresentacionST.Size = New System.Drawing.Size(127, 20)
        Me.txtNoPresentacionST.TabIndex = 1
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(262, 36)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(47, 13)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "Estatus:"
        '
        'dtFecInscripcionST
        '
        Me.dtFecInscripcionST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecInscripcionST.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecInscripcionST.Location = New System.Drawing.Point(129, 36)
        Me.dtFecInscripcionST.Name = "dtFecInscripcionST"
        Me.dtFecInscripcionST.Size = New System.Drawing.Size(127, 20)
        Me.dtFecInscripcionST.TabIndex = 2
        Me.dtFecInscripcionST.Value = New Date(2017, 12, 11, 0, 0, 0, 0)
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(3, 36)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(109, 13)
        Me.Label41.TabIndex = 4
        Me.Label41.Text = "Fecha de Inscripción:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(3, 10)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(120, 13)
        Me.Label42.TabIndex = 2
        Me.Label42.Text = "Fecha de Presentación:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(262, 10)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(93, 13)
        Me.Label39.TabIndex = 1
        Me.Label39.Text = "No. Presentación:"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.dtpFecDev)
        Me.TabPage5.Controls.Add(Me.Label63)
        Me.TabPage5.Controls.Add(Me.cbTipoDocEnt)
        Me.TabPage5.Controls.Add(Me.Label56)
        Me.TabPage5.Controls.Add(Me.txtDeptoRecibe)
        Me.TabPage5.Controls.Add(Me.txtCodDeptoRecibe)
        Me.TabPage5.Controls.Add(Me.Label57)
        Me.TabPage5.Controls.Add(Me.txtResponsableEntrega)
        Me.TabPage5.Controls.Add(Me.Label59)
        Me.TabPage5.Controls.Add(Me.txtDeptoEntrega)
        Me.TabPage5.Controls.Add(Me.txtCodDeptoEntrega)
        Me.TabPage5.Controls.Add(Me.Label60)
        Me.TabPage5.Controls.Add(Me.dtpFecEntDC)
        Me.TabPage5.Controls.Add(Me.Label61)
        Me.TabPage5.Controls.Add(Me.txtResponsable)
        Me.TabPage5.Controls.Add(Me.Label62)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(635, 384)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Entrega Documentos"
        '
        'dtpFecDev
        '
        Me.dtpFecDev.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecDev.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecDev.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecDev.Location = New System.Drawing.Point(387, 103)
        Me.dtpFecDev.Name = "dtpFecDev"
        Me.dtpFecDev.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecDev.TabIndex = 172
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(253, 100)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(128, 16)
        Me.Label63.TabIndex = 171
        Me.Label63.Text = "Fecha de Devolución:"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbTipoDocEnt
        '
        Me.cbTipoDocEnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDocEnt.Items.AddRange(New Object() {"Pagare", "Pagare y mutuo", "Otros"})
        Me.cbTipoDocEnt.Location = New System.Drawing.Point(19, 229)
        Me.cbTipoDocEnt.Name = "cbTipoDocEnt"
        Me.cbTipoDocEnt.Size = New System.Drawing.Size(499, 21)
        Me.cbTipoDocEnt.TabIndex = 162
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(16, 210)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(216, 16)
        Me.Label56.TabIndex = 170
        Me.Label56.Text = "Tipo de documentos entregados:"
        '
        'txtDeptoRecibe
        '
        Me.txtDeptoRecibe.BackColor = System.Drawing.Color.White
        Me.txtDeptoRecibe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeptoRecibe.Location = New System.Drawing.Point(106, 77)
        Me.txtDeptoRecibe.Name = "txtDeptoRecibe"
        Me.txtDeptoRecibe.ReadOnly = True
        Me.txtDeptoRecibe.Size = New System.Drawing.Size(402, 20)
        Me.txtDeptoRecibe.TabIndex = 169
        '
        'txtCodDeptoRecibe
        '
        Me.txtCodDeptoRecibe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDeptoRecibe.Location = New System.Drawing.Point(19, 77)
        Me.txtCodDeptoRecibe.MaxLength = 10
        Me.txtCodDeptoRecibe.Name = "txtCodDeptoRecibe"
        Me.txtCodDeptoRecibe.Size = New System.Drawing.Size(80, 20)
        Me.txtCodDeptoRecibe.TabIndex = 158
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(16, 58)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(216, 16)
        Me.Label57.TabIndex = 168
        Me.Label57.Text = "*Departamento responsable que recibe:"
        '
        'txtResponsableEntrega
        '
        Me.txtResponsableEntrega.Location = New System.Drawing.Point(19, 145)
        Me.txtResponsableEntrega.Name = "txtResponsableEntrega"
        Me.txtResponsableEntrega.Size = New System.Drawing.Size(489, 20)
        Me.txtResponsableEntrega.TabIndex = 160
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(16, 126)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(144, 16)
        Me.Label59.TabIndex = 167
        Me.Label59.Text = "Responsable que entrega:"
        '
        'txtDeptoEntrega
        '
        Me.txtDeptoEntrega.BackColor = System.Drawing.Color.White
        Me.txtDeptoEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeptoEntrega.Location = New System.Drawing.Point(105, 187)
        Me.txtDeptoEntrega.Name = "txtDeptoEntrega"
        Me.txtDeptoEntrega.ReadOnly = True
        Me.txtDeptoEntrega.Size = New System.Drawing.Size(403, 20)
        Me.txtDeptoEntrega.TabIndex = 166
        '
        'txtCodDeptoEntrega
        '
        Me.txtCodDeptoEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDeptoEntrega.Location = New System.Drawing.Point(19, 187)
        Me.txtCodDeptoEntrega.MaxLength = 10
        Me.txtCodDeptoEntrega.Name = "txtCodDeptoEntrega"
        Me.txtCodDeptoEntrega.Size = New System.Drawing.Size(80, 20)
        Me.txtCodDeptoEntrega.TabIndex = 161
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(16, 168)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(216, 16)
        Me.Label60.TabIndex = 165
        Me.Label60.Text = "*Departamento responsable que entrega:"
        '
        'dtpFecEntDC
        '
        Me.dtpFecEntDC.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecEntDC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecEntDC.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecEntDC.Location = New System.Drawing.Point(126, 103)
        Me.dtpFecEntDC.Name = "dtpFecEntDC"
        Me.dtpFecEntDC.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecEntDC.TabIndex = 159
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(16, 100)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(104, 16)
        Me.Label61.TabIndex = 164
        Me.Label61.Text = "Fecha de Entrega:"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtResponsable
        '
        Me.txtResponsable.Location = New System.Drawing.Point(19, 35)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(489, 20)
        Me.txtResponsable.TabIndex = 157
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.Location = New System.Drawing.Point(16, 16)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(152, 16)
        Me.Label62.TabIndex = 163
        Me.Label62.Text = "Responsable que recibe:"
        '
        'btnSig1
        '
        Me.btnSig1.Location = New System.Drawing.Point(509, 479)
        Me.btnSig1.Name = "btnSig1"
        Me.btnSig1.Size = New System.Drawing.Size(75, 28)
        Me.btnSig1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSig1.TabIndex = 211
        Me.btnSig1.Text = "Siguiente"
        Me.btnSig1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSig1.UseSelectable = True
        Me.btnSig1.UseStyleColors = True
        '
        'btGuardarRegGar1
        '
        Me.btGuardarRegGar1.Location = New System.Drawing.Point(590, 479)
        Me.btGuardarRegGar1.Name = "btGuardarRegGar1"
        Me.btGuardarRegGar1.Size = New System.Drawing.Size(75, 28)
        Me.btGuardarRegGar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btGuardarRegGar1.TabIndex = 210
        Me.btGuardarRegGar1.Text = "&Guardar"
        Me.btGuardarRegGar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btGuardarRegGar1.UseSelectable = True
        Me.btGuardarRegGar1.UseStyleColors = True
        '
        'btAtras1
        '
        Me.btAtras1.Location = New System.Drawing.Point(428, 479)
        Me.btAtras1.Name = "btAtras1"
        Me.btAtras1.Size = New System.Drawing.Size(75, 28)
        Me.btAtras1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btAtras1.TabIndex = 209
        Me.btAtras1.Text = "Atrás"
        Me.btAtras1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btAtras1.UseSelectable = True
        Me.btAtras1.UseStyleColors = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(590, 480)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 212
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmGarantiasPrendarias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(689, 545)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSig1)
        Me.Controls.Add(Me.btGuardarRegGar1)
        Me.Controls.Add(Me.btAtras1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(683, 531)
        Me.Name = "frmGarantiasPrendarias"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Garantías Prendarias"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMaquinaria.ResumeLayout(False)
        Me.gbMaquinaria.PerformLayout()
        CType(Me.c1nMontoValuoRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVehiculo.ResumeLayout(False)
        Me.gbVehiculo.PerformLayout()
        Me.gbOtro.ResumeLayout(False)
        Me.gbOtro.PerformLayout()
        Me.gbInmueble.ResumeLayout(False)
        Me.gbInmueble.PerformLayout()
        CType(Me.c1nMontoValuoRI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoValuoV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub Encabezado(ByVal vTipo As String)

        Select Case vTipo
            Case "I" 'Inmueble
                fg.Cols.Item(3).Width = 0
                fg.Cols.Item(4).Width = 0
                fg.Cols.Item(5).Width = 0
                fg.Cols.Item(6).Width = 0
                fg.Cols.Item(7).Width = 0
                fg.Cols.Item(8).Width = 0
                fg.Cols.Item(9).Width = 0
                fg.Cols.Item(10).Width = 0
                fg.Cols.Item(11).Caption = "Propietario"
                fg.Cols.Item(12).Width = 0
                fg.Cols.Item(13).Width = 0
                fg.Cols.Item(14).Caption = "Monto Valúo"
                fg.Cols.Item(14).Format = "##0.00"
                fg.Cols.Item(15).Caption = "Ubicación"
                fg.Cols.Item(16).Caption = "Área"
                fg.Cols.Item(17).Width = 0
                fg.Cols.Item(18).Width = 0
                fg.Cols.Item(19).Width = 0
                fg.Cols.Item(20).Width = 0
                fg.Cols.Item(21).Width = 0
                fg.Cols.Item(22).Width = 0
                fg.Cols.Item(23).Width = 0
                fg.Cols.Item(24).Width = 0
            Case "V" 'Vehículo
                fg.Cols.Item(3).Caption = "No.Placa"
                fg.Cols.Item(4).Caption = "Clase"
                fg.Cols.Item(5).Caption = "Marca"
                fg.Cols.Item(6).Caption = "Tipo"
                fg.Cols.Item(7).Caption = "Año"
                fg.Cols.Item(8).Caption = "Capacidad"
                fg.Cols.Item(9).Caption = "No.Motor"
                fg.Cols.Item(10).Caption = "No.Chasis"
                fg.Cols.Item(11).Caption = "Propietario"
                fg.Cols.Item(12).Width = 0
                fg.Cols.Item(13).Width = 0
                fg.Cols.Item(14).Caption = "Monto Valúo"
                fg.Cols.Item(14).Format = "##0.00"
                fg.Cols.Item(15).Width = 0
                fg.Cols.Item(16).Width = 0
                fg.Cols.Item(17).Width = 0
                fg.Cols.Item(18).Width = 0
                fg.Cols.Item(19).Caption = "No.ChasisVIN"
                fg.Cols.Item(20).Caption = "Color"
                fg.Cols.Item(21).Caption = "Calidad"
                fg.Cols.Item(22).Width = 0
            Case "M" 'Maquinaria
                fg.Cols.Item(3).Width = 0
                fg.Cols.Item(4).Width = 0
                fg.Cols.Item(5).Width = 0
                fg.Cols.Item(6).Width = 0
                fg.Cols.Item(7).Width = 0
                fg.Cols.Item(8).Width = 0
                fg.Cols.Item(9).Width = 0
                fg.Cols.Item(10).Width = 0
                fg.Cols.Item(11).Caption = "Propietario"
                fg.Cols.Item(12).Caption = "Modelo"
                fg.Cols.Item(13).Caption = "Serie"
                fg.Cols.Item(14).Caption = "Monto Valúo"
                fg.Cols.Item(14).Format = "##0.00"
                fg.Cols.Item(15).Width = 0
                fg.Cols.Item(16).Width = 0
                fg.Cols.Item(17).Caption = "Tipo Máquina"
                fg.Cols.Item(18).Width = 0
                fg.Cols.Item(19).Width = 0
                fg.Cols.Item(20).Width = 0
                fg.Cols.Item(21).Width = 0
                fg.Cols.Item(22).Caption = "Descripción"
                fg.Cols.Item(23).Width = 0
                fg.Cols.Item(24).Width = 0
            Case "O" 'Otro(a)
                fg.Cols.Item(3).Width = 0
                fg.Cols.Item(4).Caption = "Clase"
                fg.Cols.Item(5).Caption = "Marca"
                fg.Cols.Item(6).Caption = "Tipo"
                fg.Cols.Item(7).Caption = "Año"
                fg.Cols.Item(8).Caption = "Capacidad"
                fg.Cols.Item(9).Width = 0
                fg.Cols.Item(10).Width = 0
                fg.Cols.Item(11).Caption = "Propietario"
                fg.Cols.Item(12).Width = 0
                fg.Cols.Item(13).Width = 0
                fg.Cols.Item(14).Caption = "Monto Valúo"
                fg.Cols.Item(14).Format = "##0.00"
                fg.Cols.Item(15).Width = 0
                fg.Cols.Item(16).Width = 0
                fg.Cols.Item(17).Width = 0
                fg.Cols.Item(18).Width = 0
                fg.Cols.Item(19).Width = 0
                fg.Cols.Item(20).Caption = "Color"
                fg.Cols.Item(21).Width = 0
                fg.Cols.Item(22).Caption = "Descripción"
                fg.Cols.Item(23).Width = 0
                fg.Cols.Item(24).Width = 0
        End Select

        fg.Cols.Item(1).Width = 0
        fg.Cols.Item(2).Width = 0

    End Sub


    Private Sub LimpiaCampos()
        txtNoPlacaV.Text = ""
        txtClaseV.Text = ""
        txtMarcaV.Text = ""
        txtTipoV.Text = ""
        dtpYearV.Value = Now
        txtCapacidadV.Text = ""
        txtNoMotorV.Text = ""
        txtNoChasisV.Text = ""
        txtChasisVIN.Text = ""
        Me.txtNoInsc.Text = ""
        Me.dtpFechaIns.Value = Now
        txtColor.Text = ""
        txtCalidad.Text = ""
        txtDescripcion.Text = ""
        txtPropietarioRI.Text = ""
        txtPropietarioRM.Text = ""
        txtPropietarioV.Text = ""
        txtModeloRM.Text = ""
        txtSerieRM.Text = ""
        Me.c1nMontoValuoRI.Value = 0
        Me.c1nMontoValuoRM.Value = 0
        Me.c1nMontoValuoV.Value = 0
        txtUbicacionRI.Text = ""
        txtAreaRI.Text = ""
        txtTipoMaquinaRM.Text = ""
        txtDescripcionO.Text = ""
        Me.gbOtro.Visible = False
        Me.gbVehiculo.Visible = False
        Me.gbMaquinaria.Visible = False
        Me.gbInmueble.Visible = False
    End Sub

    Private Sub cbTipoGarantia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoGarantia.SelectedIndexChanged
        Dim vTipoDet As String
        Select Case Me.cbTipoGarantia.SelectedIndex
            Case 0 'Inmueble
                Me.gbInmueble.Visible = True
                Me.gbMaquinaria.Visible = False
                Me.gbVehiculo.Visible = False
                Me.gbOtro.Visible = False
                vTipoDet = "I"
            Case 1 'Vehículo
                Me.gbInmueble.Visible = False
                Me.gbMaquinaria.Visible = False
                Me.gbVehiculo.Visible = True
                Me.gbOtro.Visible = False
                vTipoDet = "V"
            Case 2 'Maquinaria
                Me.gbInmueble.Visible = False
                Me.gbMaquinaria.Visible = True
                Me.gbVehiculo.Visible = False
                Me.gbOtro.Visible = False
                vTipoDet = "M"
            Case 3 'Otro(a)
                Me.gbInmueble.Visible = False
                Me.gbMaquinaria.Visible = False
                Me.gbVehiculo.Visible = False
                Me.gbOtro.Visible = True
                vTipoDet = "O"
        End Select
        If Me.txtCodPrestamo.Text.Trim <> "" Then
            fg.DataSource = oItem.ConsultarDetGarantiasPr("*", "CodPrestamo='" & txtCodPrestamo.Text.Trim & "' and TipoDetalle='" & vTipoDet & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
            Encabezado(vTipoDet)
        End If
        Me.btGuardarRegGar1.Enabled = True
    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.CargarListaPrestamos(False, "", "", Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                dr = ds.Tables("Prestamo").Rows(0)
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                Me.dtpFechaOtorgamiento.Value = IIf(IsDBNull(dr("FechaOtorgamiento")), Now, dr("FechaOtorgamiento"))
                Me.dtpFechaVencimiento.Value = IIf(IsDBNull(dr("FechaVencimiento")), Now, dr("FechaVencimiento"))
                Me.c1nMonto.Value = dr("Monto")
                Me.c1nPlazo.Value = dr("PlazoMeses")
                Me.c1nTasa.Value = dr("Tasa_Interes")
                Me.txtCuotas.Text = Math.Round(dr("Saldo_Capital") / dr("Cuota"), 1)
                ds = oPrest.ConsultarPRPrestamosTipoCredito("b.Descripcion", "a.CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtTipoCredito.Text = dr("Descripcion")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Dim sTexto As String
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Dim oAh As New wrAhorro.wsLibAhorro
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Value
            If sTexto = "" Then      'Filtrar Registros

            ElseIf sTexto <> "" Then

                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Correlativo,NoSocio,Apellido1,Apellido2,Nombres", "", "Correlativo", sUsuario, sPassword, sSucursal)
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
                Me.txtNoSocio.Text = dr("NoSocio")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
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



    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        If fg.Row > 0 Then
            Select Case Trim(fg.Item(fg.Row, "TipoDetalle"))
                Case "V" 'Vehículo
                    Me.gbInmueble.Visible = False
                    Me.gbMaquinaria.Visible = False
                    Me.gbVehiculo.Visible = True
                    Me.gbOtro.Visible = False
                    Me.txtPropietarioV.Text = Trim(fg.Item(fg.Row, "Propietario"))
                    Me.txtMarcaV.Text = Trim(fg.Item(fg.Row, "Marca"))
                    Me.txtTipoV.Text = Trim(fg.Item(fg.Row, "Tipo"))
                    Me.txtNoPlacaV.Text = Trim(fg.Item(fg.Row, "NoPlaca"))
                    Me.txtClaseV.Text = Trim(fg.Item(fg.Row, "Clase"))
                    Me.dtpYearV.Value = CDate("01/01/" & Trim(fg.Item(fg.Row, "Anno")))
                    Me.txtCapacidadV.Text = Trim(fg.Item(fg.Row, "Capacidad"))
                    Me.txtNoMotorV.Text = Trim(fg.Item(fg.Row, "NoMotor"))
                    Me.txtNoChasisV.Text = Trim(fg.Item(fg.Row, "NoChasis"))
                    Me.txtChasisVIN.Text = Trim(fg.Item(fg.Row, "NoChasisVIN"))
                    Me.txtCalidad.Text = Trim(fg.Item(fg.Row, "Calidad"))
                    Me.txtColor.Text = Trim(fg.Item(fg.Row, "Color"))
                    Me.c1nMontoValuoV.Value = CDbl(fg.Item(fg.Row, "ValorValuacion"))
                    Me.txtNoInsc.Text = IIf(fg.Item(fg.Row, "NoInscripcionVMT") Is DBNull.Value, "", fg.Item(fg.Row, "NoInscripcionVMT"))
                    Me.dtpFechaIns.Value = IIf(fg.Item(fg.Row, "FechaInscripcionVMT") Is DBNull.Value, Now, fg.Item(fg.Row, "FechaInscripcionVMT"))
                    Me.cbTipoGarantia.SelectedIndex = 1
                Case "M" 'Maquinaria
                    Me.gbInmueble.Visible = False
                    Me.gbMaquinaria.Visible = True
                    Me.gbVehiculo.Visible = False
                    Me.gbOtro.Visible = False
                    Me.txtPropietarioRM.Text = Trim(fg.Item(fg.Row, "Propietario"))
                    Me.txtTipoMaquinaRM.Text = Trim(fg.Item(fg.Row, "TipoMaquina"))
                    Me.txtModeloRM.Text = Trim(fg.Item(fg.Row, "Modelo"))
                    Me.txtDescripcion.Text = Trim(fg.Item(fg.Row, "Descripcion"))
                    Me.txtSerieRM.Text = Trim(fg.Item(fg.Row, "Serie"))
                    Me.c1nMontoValuoRM.Value = CDbl(fg.Item(fg.Row, "ValorValuacion"))
                    Me.cbTipoGarantia.SelectedIndex = 2
                Case "I" 'Inmueble
                    Me.gbInmueble.Visible = True
                    Me.gbMaquinaria.Visible = False
                    Me.gbVehiculo.Visible = False
                    Me.gbOtro.Visible = False
                    Me.txtAreaRI.Text = Trim(fg.Item(fg.Row, "Area"))
                    Me.txtUbicacionRI.Text = Trim(fg.Item(fg.Row, "Ubicacion"))
                    Me.txtPropietarioRI.Text = Trim(fg.Item(fg.Row, "Propietario"))
                    Me.c1nMontoValuoRI.Value = CDbl(fg.Item(fg.Row, "ValorValuacion"))
                    Me.cbTipoGarantia.SelectedIndex = 0
                Case "O" 'Otro(a)
                    Me.gbInmueble.Visible = False
                    Me.gbMaquinaria.Visible = False
                    Me.gbVehiculo.Visible = False
                    Me.gbOtro.Visible = True
                    Me.txtPropietarioO.Text = Trim(fg.Item(fg.Row, "Propietario"))
                    Me.txtMarcaO.Text = Trim(fg.Item(fg.Row, "Marca"))
                    Me.txtSerieO.Text = Trim(fg.Item(fg.Row, "Tipo"))
                    Me.txtModeloO.Text = Trim(fg.Item(fg.Row, "Clase"))
                    Me.dtAnioO.Value = CDate("01/01/" & Trim(fg.Item(fg.Row, "Anno")))
                    Me.txtCapacidadO.Text = Trim(fg.Item(fg.Row, "Capacidad"))
                    Me.txtColorO.Text = Trim(fg.Item(fg.Row, "Color"))
                    Me.txtDescripcionO.Text = Trim(fg.Item(fg.Row, "Descripcion"))
                    Me.c1nMontoO.Value = CDbl(fg.Item(fg.Row, "ValorValuacion"))
                    Me.cbTipoGarantia.SelectedIndex = 3
            End Select
            vCorr = fg.Item(fg.Row, "Correlativo")
            Me.btGuardarRegGar1.Enabled = True
            Me.btGuardarRegGar1.Text = "&Modificar"
        End If
    End Sub

    Private Sub txtCodDeptoRecibe_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDeptoRecibe.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet

        Try
            ofrm.Text = "Buscar Departamentos..."
            ds = oPlan.ConsultarPLDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado2.Trim <> "" Then
                Me.txtCodDeptoRecibe.Text = ofrm.Resultado2.Trim
                Me.txtDeptoRecibe.Text = ofrm.Resultado3.Trim
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtCodDeptoEntrega_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDeptoEntrega.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet

        Try
            ofrm.Text = "Buscar Departamentos..."
            ds = oPlan.ConsultarPLDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado2.Trim <> "" Then
                Me.txtCodDeptoEntrega.Text = ofrm.Resultado2.Trim
                Me.txtDeptoEntrega.Text = ofrm.Resultado3.Trim
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub



    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If Me.TabControl1.SelectedIndex = 1 Then
            Me.btGuardarRegGar1.Visible = True
            Me.btnGuardar.Visible = False
        Else
            Me.btnGuardar.Visible = True
            Me.btGuardarRegGar1.Visible = False
        End If
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub txtNoPresentacionST_TextChanged(sender As Object, e As EventArgs) Handles txtNoPresentacionST.TextChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btAtras1_Click(sender As Object, e As EventArgs) Handles btAtras1.Click
        If Me.TabControl1.SelectedIndex > 0 Then Me.TabControl1.SelectedIndex = Me.TabControl1.SelectedIndex() - 1
    End Sub

    Private Sub btnSig1_Click(sender As Object, e As EventArgs) Handles btnSig1.Click
        If Me.TabControl1.SelectedIndex < Me.TabControl1.TabCount - 1 Then Me.TabControl1.SelectedIndex = Me.TabControl1.SelectedIndex() + 1
    End Sub

    Private Sub btGuardarRegGar1_Click(sender As Object, e As EventArgs) Handles btGuardarRegGar1.Click
        Try
            Dim Campos, Valores As String, vPropietario As String, vTipo As String, vMontoValuo As Double, ds As New DataSet
            Dim vMarca As String, vColor As String, vSerie As String, vModelo As String, vCapacidad As String, vAnio As Integer, vDescripcion As String

            If Me.cbTipoGarantia.SelectedIndex = 0 Then 'Inmueble
                vTipo = "I"
                vPropietario = Me.txtPropietarioRI.Text.Trim
                vMontoValuo = Me.c1nMontoValuoRI.Value
                vDescripcion = ""
            ElseIf Me.cbTipoGarantia.SelectedIndex = 1 Then 'Vehículo
                vTipo = "V"
                vPropietario = Me.txtPropietarioV.Text.Trim
                vMontoValuo = Me.c1nMontoValuoV.Value
                vMarca = Me.txtMarcaV.Text.Trim
                vColor = Me.txtColor.Text.Trim
                vSerie = Me.txtTipoV.Text.Trim
                vModelo = Me.txtClaseV.Text.Trim
                vCapacidad = Me.txtCapacidadV.Text.Trim
                vAnio = Me.dtpYearV.Value.Year
                vDescripcion = ""
            ElseIf Me.cbTipoGarantia.SelectedIndex = 2 Then 'Maquinaria
                vTipo = "M"
                vPropietario = Me.txtPropietarioRM.Text.Trim
                vMontoValuo = Me.c1nMontoValuoRM.Value
                vDescripcion = Me.txtDescripcion.Text.Trim
            ElseIf Me.cbTipoGarantia.SelectedIndex = 3 Then 'Otro(a)
                vTipo = "O"
                vPropietario = Me.txtPropietarioO.Text.Trim
                vMontoValuo = Me.c1nMontoO.Value
                vMarca = Me.txtMarcaO.Text.Trim
                vColor = Me.txtColorO.Text.Trim
                vSerie = Me.txtSerieO.Text.Trim
                vModelo = Me.txtModeloO.Text.Trim
                vCapacidad = Me.txtCapacidadO.Text.Trim
                vAnio = Me.dtAnioO.Value.Year
                vDescripcion = Me.txtDescripcionO.Text.Trim
            End If

            Select Case Me.TabControl1.SelectedIndex
                Case 1
                    If Me.btGuardarRegGar1.Text = "&Guardar" Or Me.btGuardarRegGar1.Text = "Guardar" Then
                        Campos = "CodPrestamo,NoPlaca,Clase,Marca,Tipo,Anno,Capacidad,NoMotor,NoChasis,Propietario,Modelo,Serie,ValorValuacion,Ubicacion,Area,TipoMaquina,TipoDetalle,NoChasisVIN,Color,Calidad,Descripcion,NoInscripcionVMT,FechaInscripcionVMT"
                        Valores = "'" & txtCodPrestamo.Text.Trim & "','" & Me.txtNoPlacaV.Text.Trim & "','" & vModelo & "','" & vMarca & "','" & vSerie & "'," & vAnio & ",'" & vCapacidad & "','" & Me.txtNoMotorV.Text.Trim & "','" & Me.txtNoChasisV.Text.Trim & "','" & vPropietario & "','" & Me.txtModeloRM.Text.Trim & "','" & Me.txtSerieRM.Text.Trim & "'," & vMontoValuo & ",'" & Me.txtUbicacionRI.Text.Trim & "','" & Me.txtAreaRI.Text.Trim & "','" & Me.txtTipoMaquinaRM.Text.Trim & "','" & vTipo & "','" & Me.txtChasisVIN.Text.Trim & "','" & vColor & "','" & Me.txtCalidad.Text.Trim & "','" & vDescripcion & "','" & Me.txtNoInsc.Text.Trim & "','" & Format(Me.dtpFechaIns.Value, "dd/MM/yyyy") & "'"
                        If oItem.InsertarDetGarantiasPr(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                            LimpiaCampos()
                            fg.DataSource = oItem.ConsultarDetGarantiasPr("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and TipoDetalle='" & vTipo & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                            Encabezado(vTipo)
                        Else
                            MessageBox.Show("Los datos no fueron agregados, verifique.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    ElseIf btGuardarRegGar1.Text = "&Modificar" Or btGuardarRegGar1.Text = "Modificar" Then
                        Campos = "NoPlaca='" & Me.txtNoPlacaV.Text.Trim & "',Clase='" & vModelo & "',Marca='" & vMarca & "',Tipo='" & vSerie & "',Anno=" & vAnio & ",Capacidad='" & vCapacidad & "',NoMotor='" & Me.txtNoMotorV.Text.Trim & "',NoChasis='" & Me.txtNoChasisV.Text.Trim & "',Propietario='" & vPropietario & "',Modelo='" & Me.txtModeloRM.Text.Trim & "',Serie='" & Me.txtSerieRM.Text.Trim & "',ValorValuacion=" & vMontoValuo & ",Ubicacion='" & Me.txtUbicacionRI.Text.Trim & "',Area='" & Me.txtAreaRI.Text.Trim & "',TipoMaquina='" & Me.txtTipoMaquinaRM.Text.Trim & "',NoChasisVIN='" & Me.txtChasisVIN.Text.Trim & "',Color='" & vColor & "',Calidad='" & Me.txtCalidad.Text.Trim & "',Descripcion='" & vDescripcion & "',NoInscripcionVMT='" & Me.txtNoInsc.Text.Trim & "',FechaInscripcionVMT='" & Format(Me.dtpFechaIns.Value, "dd/MM/yyyy") & "'"
                        If oItem.ModificarDetGarantiasPr(Campos, "Correlativo=" & vCorr & "", sUsuario, sPassword, sSucursal) = True Then
                            LimpiaCampos()
                            fg.DataSource = oItem.ConsultarDetGarantiasPr("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and TipoDetalle='" & vTipo & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                            Encabezado(vTipo)
                            Me.btGuardarRegGar1.Text = "&Guardar"
                        Else
                            MessageBox.Show("Los datos no fueron agregados, verifique.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
            End Select
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Campos, Valores, CamposValores As String, vPropietario As String, vTipo As String, vMontoValuo As Double, ds As New DataSet
            Dim vMarca As String, vColor As String, vSerie As String, vModelo As String, vCapacidad As String, vAnio As Integer, vDescripcion As String

            If Me.cbTipoGarantia.SelectedIndex = 0 Then 'Inmueble
                vTipo = "I"
                vPropietario = Me.txtPropietarioRI.Text.Trim
                vMontoValuo = Me.c1nMontoValuoRI.Value
                vDescripcion = ""
            ElseIf Me.cbTipoGarantia.SelectedIndex = 1 Then 'Vehículo
                vTipo = "V"
                vPropietario = Me.txtPropietarioV.Text.Trim
                vMontoValuo = Me.c1nMontoValuoV.Value
                vMarca = Me.txtMarcaV.Text.Trim
                vColor = Me.txtColor.Text.Trim
                vSerie = Me.txtTipoV.Text.Trim
                vModelo = Me.txtClaseV.Text.Trim
                vCapacidad = Me.txtCapacidadV.Text.Trim
                vAnio = Me.dtpYearV.Value.Year
                vDescripcion = ""
            ElseIf Me.cbTipoGarantia.SelectedIndex = 2 Then 'Maquinaria
                vTipo = "M"
                vPropietario = Me.txtPropietarioRM.Text.Trim
                vMontoValuo = Me.c1nMontoValuoRM.Value
                vDescripcion = Me.txtDescripcion.Text.Trim
            ElseIf Me.cbTipoGarantia.SelectedIndex = 3 Then 'Otro(a)
                vTipo = "O"
                vPropietario = Me.txtPropietarioO.Text.Trim
                vMontoValuo = Me.c1nMontoO.Value
                vMarca = Me.txtMarcaO.Text.Trim
                vColor = Me.txtColorO.Text.Trim
                vSerie = Me.txtSerieO.Text.Trim
                vModelo = Me.txtModeloO.Text.Trim
                vCapacidad = Me.txtCapacidadO.Text.Trim
                vAnio = Me.dtAnioO.Value.Year
                vDescripcion = Me.txtDescripcionO.Text.Trim
            End If

            Select Case Me.TabControl1.SelectedIndex
                Case 0, 2, 3, 4
                    If btnGuardar.Text = "&Guardar" Or btnGuardar.Text = "Guardar" Then
                        ds = oItem.ConsultarGarantiasPr("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                        If ds.Tables(0).Rows.Count > 0 Then 'Ya está registrado el encabezado
                            CamposValores = "NoEscritura='" & txtNoEscritura.Text.Trim & "', OrdenLibro='" & txtOrdenLibro.Text.Trim & "', Notario='" & txtNotario.Text.Trim & "' , Fecha='" & Now.ToShortDateString & "',FechaPresentacion='" & Me.dtFecPresentacion.Value.ToShortDateString & "',NoPresentacion='" & Me.txtNoPresentacion.Text.Trim & "',FechaInscripcion='" & Me.dtpFecInscripcion.Value.ToShortDateString & "',Estatus='" & Me.cbEstatus.SelectedIndex & "',Observaciones='" & Me.txtObs.Text.Trim & "',FechaPresentacionST='" & Me.dtFecPresentacionST.Value.ToShortDateString & "',NoPresentacionST='" & Me.txtNoPresentacionST.Text.Trim & "',FechaInscripcionST='" & Me.dtFecInscripcionST.Value.ToShortDateString & "',EstatusST='" & Me.cbEstatusST.SelectedIndex & "',ObservacionesST='" & Me.txtObsST.Text.Trim & "',Responsable_Recibe='" & Me.txtResponsable.Text.Trim & "',Fecha_Entrega='" & Me.dtpFecEntDC.Value.ToShortDateString & "',CodDepartamento_Recibe='" & Me.txtCodDeptoRecibe.Text.Trim & "',Fecha_Dev='" & Me.dtpFecDev.Value.ToShortDateString & "',Responsable_Entrega='" & Me.txtResponsableEntrega.Text.Trim & "',CodDepartamento_Entrega='" & Me.txtCodDeptoEntrega.Text.Trim & "',TipoDocumento_Entregado='" & Me.cbTipoDocEnt.SelectedIndex & "'"
                            If oItem.ModificarGarantiasPr(CamposValores, "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", sUsuario, sPassword, sSucursal) Then
                                TabControl1.TabPages(1).Enabled = True
                            Else
                                MessageBox.Show("Los datos no fueron agregados, verifique.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            Campos = "CodPrestamo,NoEscritura,OrdenLibro,Notario,Fecha,FechaPresentacion,NoPresentacion,FechaInscripcion,Estatus,Observaciones,FechaPresentacionST,NoPresentacionST,FechaInscripcionST,EstatusST,ObservacionesST,Responsable_Recibe,Fecha_Entrega,CodDepartamento_Recibe,Fecha_Dev,Responsable_Entrega,CodDepartamento_Entrega,TipoDocumento_Entregado"
                            Valores = "'" & txtCodPrestamo.Text.Trim & "','" & txtNoEscritura.Text.Trim & "','" & txtOrdenLibro.Text.Trim & "','" & txtNotario.Text.Trim & "','" & Now.ToShortDateString & "','" & Me.dtFecPresentacion.Value.ToShortDateString & "','" & Me.txtNoPresentacion.Text.Trim & "','" & Me.dtpFecInscripcion.Value.ToShortDateString & "','" & Me.cbEstatus.SelectedIndex & "','" & Me.txtObs.Text.Trim & "','" & Me.dtFecPresentacionST.Value.ToShortDateString & "','" & Me.txtNoPresentacionST.Text.Trim & "','" & Me.dtFecInscripcionST.Value.ToShortDateString & "','" & Me.cbEstatusST.SelectedIndex & "','" & Me.txtObsST.Text.Trim & "','" & Me.txtResponsable.Text.Trim & "','" & Me.dtpFecEntDC.Value.ToShortDateString & "','" & Me.txtCodDeptoRecibe.Text.Trim & "','" & Me.dtpFecDev.Value.ToShortDateString & "','" & Me.txtResponsableEntrega.Text.Trim & "','" & Me.txtCodDeptoEntrega.Text.Trim & "','" & Me.cbTipoDocEnt.SelectedIndex & "'"
                            If oItem.InsertarGarantiasPr(Campos, Valores, sUsuario, sPassword, sSucursal) Then
                                TabControl1.TabPages(1).Enabled = True
                            Else
                                MessageBox.Show("Los datos no fueron agregados, verifique.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    ElseIf btnGuardar.Text = "&Modificar" Then
                        ds = oItem.ConsultarGarantiasPr("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                        If ds.Tables(0).Rows.Count > 0 Then 'Ya está registrado el encabezado
                            CamposValores = "NoEscritura='" & txtNoEscritura.Text.Trim & "', OrdenLibro='" & txtOrdenLibro.Text.Trim & "', Notario='" & txtNotario.Text.Trim & "' , Fecha='" & Now.ToShortDateString & "',FechaPresentacion='" & Me.dtFecPresentacion.Value.ToShortDateString & "',NoPresentacion='" & Me.txtNoPresentacion.Text.Trim & "',FechaInscripcion='" & Me.dtpFecInscripcion.Value.ToShortDateString & "',Estatus='" & Me.cbEstatus.SelectedIndex & "',Observaciones='" & Me.txtObs.Text.Trim & "',FechaPresentacionST='" & Me.dtFecPresentacionST.Value.ToShortDateString & "',NoPresentacionST='" & Me.txtNoPresentacionST.Text.Trim & "',FechaInscripcionST='" & Me.dtFecInscripcionST.Value.ToShortDateString & "',EstatusST='" & Me.cbEstatusST.SelectedIndex & "',ObservacionesST='" & Me.txtObsST.Text.Trim & "',Responsable_Recibe='" & Me.txtResponsable.Text.Trim & "',Fecha_Entrega='" & Me.dtpFecEntDC.Value.ToShortDateString & "',CodDepartamento_Recibe='" & Me.txtCodDeptoRecibe.Text.Trim & "',Fecha_Dev='" & Me.dtpFecDev.Value.ToShortDateString & "',Responsable_Entrega='" & Me.txtResponsableEntrega.Text.Trim & "',CodDepartamento_Entrega='" & Me.txtCodDeptoEntrega.Text.Trim & "',TipoDocumento_Entregado='" & Me.cbTipoDocEnt.SelectedIndex & "'"
                            If oItem.ModificarGarantiasPr(CamposValores, "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", sUsuario, sPassword, sSucursal) Then
                            Else
                                MessageBox.Show("Los datos no fueron agregados, verifique.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    ElseIf btnGuardar.Text = "Modificar" Then
                        ds = oItem.ConsultarGarantiasPr("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                        If ds.Tables(0).Rows.Count > 0 Then 'Ya está registrado el encabezado
                            CamposValores = "NoEscritura='" & txtNoEscritura.Text.Trim & "', OrdenLibro='" & txtOrdenLibro.Text.Trim & "', Notario='" & txtNotario.Text.Trim & "' , Fecha='" & Now.ToShortDateString & "',FechaPresentacion='" & Me.dtFecPresentacion.Value.ToShortDateString & "',NoPresentacion='" & Me.txtNoPresentacion.Text.Trim & "',FechaInscripcion='" & Me.dtpFecInscripcion.Value.ToShortDateString & "',Estatus='" & Me.cbEstatus.SelectedIndex & "',Observaciones='" & Me.txtObs.Text.Trim & "',FechaPresentacionST='" & Me.dtFecPresentacionST.Value.ToShortDateString & "',NoPresentacionST='" & Me.txtNoPresentacionST.Text.Trim & "',FechaInscripcionST='" & Me.dtFecInscripcionST.Value.ToShortDateString & "',EstatusST='" & Me.cbEstatusST.SelectedIndex & "',ObservacionesST='" & Me.txtObsST.Text.Trim & "',Responsable_Recibe='" & Me.txtResponsable.Text.Trim & "',Fecha_Entrega='" & Me.dtpFecEntDC.Value.ToShortDateString & "',CodDepartamento_Recibe='" & Me.txtCodDeptoRecibe.Text.Trim & "',Fecha_Dev='" & Me.dtpFecDev.Value.ToShortDateString & "',Responsable_Entrega='" & Me.txtResponsableEntrega.Text.Trim & "',CodDepartamento_Entrega='" & Me.txtCodDeptoEntrega.Text.Trim & "',TipoDocumento_Entregado='" & Me.cbTipoDocEnt.SelectedIndex & "'"
                            If oItem.ModificarGarantiasPr(CamposValores, "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", sUsuario, sPassword, sSucursal) Then
                            Else
                                MessageBox.Show("Los datos no fueron agregados, verifique.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    End If
            End Select
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDel1_Click(sender As Object, e As EventArgs) Handles btDel1.Click
        Try
            If Me.fg.Row > 0 Then
                If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Detalle Registro de Garantías", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim oCred As New wrCredito.wsLibCred
                    oCred.EliminarDetGarantiasPr("Correlativo=" & Me.fg.Item(Me.fg.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    fg.DataSource = oItem.ConsultarDetGarantiasPr("*", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                    Dim vTipoDet As String
                    Select Case Me.cbTipoGarantia.SelectedIndex
                        Case 0 'Inmueble
                            vTipoDet = "I"
                        Case 1 'Vehículo
                            vTipoDet = "V"
                        Case 2 'Maquinaria
                            vTipoDet = "M"
                        Case 3 'Otro(a)
                            vTipoDet = "O"
                    End Select
                    Encabezado(vTipoDet)
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs) Handles Label67.Click

    End Sub

    Private Sub frmGarantiasPrendarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet, dr As DataRow
        If Me.txtCodDeptoEntrega.Text.Trim <> "" Then
            ds = oPlan.ConsultarPLDepartamentos("*", "CodDepartamento='" & Me.txtCodDeptoEntrega.Text.Trim & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtDeptoEntrega.Text = dr("Descripcion")
            End If
        End If
        If Me.txtCodDeptoRecibe.Text.Trim <> "" Then
            ds = oPlan.ConsultarPLDepartamentos("*", "CodDepartamento='" & Me.txtCodDeptoRecibe.Text.Trim & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtDeptoRecibe.Text = dr("Descripcion")
            End If
        End If
    End Sub

End Class