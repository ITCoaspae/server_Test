Public Class frmMsAhCuentas
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim Prestamos As New wrPrestamo.wsLibPrest
    Dim Ahorro As New wrAhorro.wsLibAhorro
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim libAhorro As New sifLib.Ahorro.clsAhorros
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Siguiente As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSiguiente2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btTasaPactada As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsPlanAh As MetroFramework.Controls.MetroButton
    Friend WithEvents btModificaPlanAh As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnContrato As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton8 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton9 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb7 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEditAut As MetroFramework.Controls.MetroButton
    Friend WithEvents btNew As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelR As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditR As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewR As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    ' Friend WithEvents btModificaPlanAh As MetroFramework.Controls.MetroButton
    Dim bandera As Boolean
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents tbSolic As System.Windows.Forms.TabControl
    Friend WithEvents btnSaveTb1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbDatGral As System.Windows.Forms.TabPage
    Friend WithEvents tbBeneficiarios As System.Windows.Forms.TabPage
    Friend WithEvents tabDatGralII As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents nuDNoCuotas As System.Windows.Forms.NumericUpDown
    Friend WithEvents c1nCuota As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFec1Cuota As System.Windows.Forms.DateTimePicker
    Friend WithEvents c1nTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCodDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents c1nMontoApertura As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFechaApertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecIniApertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents fgBen As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tbLibRep As System.Windows.Forms.TabPage
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents lblFecIniApertura As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtMotivoCancela As System.Windows.Forms.TextBox
    Friend WithEvents gbCancela As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoLibreta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents grbRutaCobro As System.Windows.Forms.GroupBox
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionCobro As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCuota As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodDpto As System.Windows.Forms.TextBox
    Friend WithEvents txtDpto As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtCodMun As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents ckbCobroDomicilio As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecCanc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEjecMercadeoCanc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecCanc As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtCodCobrador As System.Windows.Forms.TextBox
    Friend WithEvents txtCobrador As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fgAut As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents fgR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtDigito As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtCodEjecApertura As System.Windows.Forms.TextBox
    Friend WithEvents txtEjecApertura As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTelOfic As System.Windows.Forms.TextBox
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents lblTelCasa As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtApe3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFecNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpFecExtDui As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtLugDui As System.Windows.Forms.TextBox
    Friend WithEvents txtProf As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCelT2 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtEdadT2 As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents dtpFecNacT2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtPartida As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtCodAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtTitular2 As System.Windows.Forms.TextBox
    Friend WithEvents cbParentesco As System.Windows.Forms.ComboBox
    Friend WithEvents cbPar As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents MetroButton3 As System.Windows.Forms.Button
    Friend WithEvents gbDepositosAutomaticos As System.Windows.Forms.GroupBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtNoCuentaDepAut As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecIniDA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecFinDA As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodTipoAhorroDepAut As System.Windows.Forms.TextBox
    Friend WithEvents c1nMontoTransf As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbAsignarAhorro As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodPrestamo As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhCuentas))
        Me.tbSolic = New System.Windows.Forms.TabControl()
        Me.tbDatGral = New System.Windows.Forms.TabPage()
        Me.Siguiente = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cbPar = New System.Windows.Forms.ComboBox()
        Me.cbParentesco = New System.Windows.Forms.ComboBox()
        Me.txtTitular2 = New System.Windows.Forms.TextBox()
        Me.txtCelT2 = New System.Windows.Forms.TextBox()
        Me.btnSaveTb1 = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtEdadT2 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.dtpFecNacT2 = New System.Windows.Forms.DateTimePicker()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtPartida = New C1.Win.C1Input.C1TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelOfic = New System.Windows.Forms.TextBox()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.lblTelCasa = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtApe3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFecExtDui = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLugDui = New System.Windows.Forms.TextBox()
        Me.txtProf = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnSiguiente2 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnConsPlanAh = New MetroFramework.Controls.MetroButton()
        Me.btModificaPlanAh = New MetroFramework.Controls.MetroButton()
        Me.btTasaPactada = New MetroFramework.Controls.MetroButton()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtCodAhorro = New System.Windows.Forms.TextBox()
        Me.txtAhorro = New System.Windows.Forms.TextBox()
        Me.dtpFecVenc = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoLibreta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nuDNoCuotas = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.c1nCuota = New C1.Win.C1Input.C1NumericEdit()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpFec1Cuota = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.c1nTasa = New C1.Win.C1Input.C1NumericEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.c1nMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.c1nPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCodDestino = New System.Windows.Forms.TextBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.c1nMontoApertura = New C1.Win.C1Input.C1NumericEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFechaApertura = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFecIniApertura = New System.Windows.Forms.Label()
        Me.dtpFecIniApertura = New System.Windows.Forms.DateTimePicker()
        Me.gbDepositosAutomaticos = New System.Windows.Forms.GroupBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.c1nMontoTransf = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNoCuentaDepAut = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.dtpFecFinDA = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecIniDA = New System.Windows.Forms.DateTimePicker()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtDigito = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtCodTipoAhorroDepAut = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTipoDeposito = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.tabDatGralII = New System.Windows.Forms.TabPage()
        Me.btnSaveTb3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbAsignarAhorro = New System.Windows.Forms.CheckBox()
        Me.gbCancela = New System.Windows.Forms.GroupBox()
        Me.dtpFecCanc = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtEjecMercadeoCanc = New System.Windows.Forms.TextBox()
        Me.txtCodEjecCanc = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMotivoCancela = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.lblCodPrestamo = New System.Windows.Forms.Label()
        Me.txtEjecApertura = New System.Windows.Forms.TextBox()
        Me.txtCodEjecApertura = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.txtCodEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.tbBeneficiarios = New System.Windows.Forms.TabPage()
        Me.btnContrato = New MetroFramework.Controls.MetroButton()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton8 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btDel = New MetroFramework.Controls.MetroButton()
        Me.btnEditAut = New MetroFramework.Controls.MetroButton()
        Me.btNew = New MetroFramework.Controls.MetroButton()
        Me.fgAut = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btDelBen = New MetroFramework.Controls.MetroButton()
        Me.btEditBen = New MetroFramework.Controls.MetroButton()
        Me.btNewBen = New MetroFramework.Controls.MetroButton()
        Me.fgBen = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbLibRep = New System.Windows.Forms.TabPage()
        Me.MetroButton9 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb7 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btDelR = New MetroFramework.Controls.MetroButton()
        Me.btEditR = New MetroFramework.Controls.MetroButton()
        Me.btNewR = New MetroFramework.Controls.MetroButton()
        Me.fgR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ckbCobroDomicilio = New System.Windows.Forms.CheckBox()
        Me.grbRutaCobro = New System.Windows.Forms.GroupBox()
        Me.txtCodCobrador = New System.Windows.Forms.TextBox()
        Me.txtCobrador = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtDireccionCobro = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.dtpFechaCuota = New System.Windows.Forms.DateTimePicker()
        Me.txtCodDpto = New System.Windows.Forms.TextBox()
        Me.txtDpto = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtCodMun = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.tbSolic.SuspendLayout()
        Me.tbDatGral.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatDoc.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nuDNoCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDepositosAutomaticos.SuspendLayout()
        CType(Me.c1nMontoTransf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatGralII.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCancela.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbBeneficiarios.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fgAut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.fgBen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbLibRep.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.fgR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbRutaCobro.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSolic
        '
        Me.tbSolic.Controls.Add(Me.tbDatGral)
        Me.tbSolic.Controls.Add(Me.TabPage1)
        Me.tbSolic.Controls.Add(Me.tabDatGralII)
        Me.tbSolic.Controls.Add(Me.tbBeneficiarios)
        Me.tbSolic.Controls.Add(Me.tbLibRep)
        Me.tbSolic.ItemSize = New System.Drawing.Size(300, 18)
        Me.tbSolic.Location = New System.Drawing.Point(23, 63)
        Me.tbSolic.Multiline = True
        Me.tbSolic.Name = "tbSolic"
        Me.tbSolic.SelectedIndex = 0
        Me.tbSolic.Size = New System.Drawing.Size(682, 536)
        Me.tbSolic.TabIndex = 0
        '
        'tbDatGral
        '
        Me.tbDatGral.BackColor = System.Drawing.Color.White
        Me.tbDatGral.Controls.Add(Me.MetroButton5)
        Me.tbDatGral.Controls.Add(Me.Siguiente)
        Me.tbDatGral.Controls.Add(Me.Label1)
        Me.tbDatGral.Controls.Add(Me.txtTipoAhorro)
        Me.tbDatGral.Controls.Add(Me.txtCodTipoAhorro)
        Me.tbDatGral.Controls.Add(Me.GroupBox6)
        Me.tbDatGral.Controls.Add(Me.gbDatDoc)
        Me.tbDatGral.Location = New System.Drawing.Point(4, 22)
        Me.tbDatGral.Name = "tbDatGral"
        Me.tbDatGral.Size = New System.Drawing.Size(674, 510)
        Me.tbDatGral.TabIndex = 0
        Me.tbDatGral.Text = "Datos Generales"
        '
        'Siguiente
        '
        Me.Siguiente.Location = New System.Drawing.Point(585, 473)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(75, 28)
        Me.Siguiente.Style = MetroFramework.MetroColorStyle.Green
        Me.Siguiente.TabIndex = 0
        Me.Siguiente.Text = "Siguiente"
        Me.Siguiente.UseSelectable = True
        Me.Siguiente.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Cuenta:"
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BackColor = System.Drawing.Color.White
        Me.txtTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAhorro.Location = New System.Drawing.Point(186, 15)
        Me.txtTipoAhorro.MaxLength = 110
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.Size = New System.Drawing.Size(403, 20)
        Me.txtTipoAhorro.TabIndex = 2
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.AcceptsReturn = True
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(100, 15)
        Me.txtCodTipoAhorro.MaxLength = 10
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(80, 20)
        Me.txtCodTipoAhorro.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.cbPar)
        Me.GroupBox6.Controls.Add(Me.cbParentesco)
        Me.GroupBox6.Controls.Add(Me.txtTitular2)
        Me.GroupBox6.Controls.Add(Me.txtCelT2)
        Me.GroupBox6.Controls.Add(Me.btnSaveTb1)
        Me.GroupBox6.Controls.Add(Me.Label33)
        Me.GroupBox6.Controls.Add(Me.txtEdadT2)
        Me.GroupBox6.Controls.Add(Me.Label39)
        Me.GroupBox6.Controls.Add(Me.dtpFecNacT2)
        Me.GroupBox6.Controls.Add(Me.Label40)
        Me.GroupBox6.Controls.Add(Me.txtPartida)
        Me.GroupBox6.Controls.Add(Me.Label42)
        Me.GroupBox6.Controls.Add(Me.cbDoc)
        Me.GroupBox6.Controls.Add(Me.Label44)
        Me.GroupBox6.Controls.Add(Me.txtTel)
        Me.GroupBox6.Controls.Add(Me.Label52)
        Me.GroupBox6.Controls.Add(Me.Label53)
        Me.GroupBox6.Controls.Add(Me.Label54)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(16, 317)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(644, 150)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos del Titular 2"
        '
        'cbPar
        '
        Me.cbPar.BackColor = System.Drawing.Color.White
        Me.cbPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPar.Location = New System.Drawing.Point(409, 30)
        Me.cbPar.Name = "cbPar"
        Me.cbPar.Size = New System.Drawing.Size(224, 21)
        Me.cbPar.TabIndex = 3
        '
        'cbParentesco
        '
        Me.cbParentesco.Location = New System.Drawing.Point(409, 30)
        Me.cbParentesco.Name = "cbParentesco"
        Me.cbParentesco.Size = New System.Drawing.Size(224, 21)
        Me.cbParentesco.TabIndex = 1
        Me.cbParentesco.Visible = False
        '
        'txtTitular2
        '
        Me.txtTitular2.Location = New System.Drawing.Point(77, 31)
        Me.txtTitular2.Name = "txtTitular2"
        Me.txtTitular2.Size = New System.Drawing.Size(224, 20)
        Me.txtTitular2.TabIndex = 1
        '
        'txtCelT2
        '
        Me.txtCelT2.AcceptsReturn = True
        Me.txtCelT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCelT2.Location = New System.Drawing.Point(409, 113)
        Me.txtCelT2.MaxLength = 25
        Me.txtCelT2.Name = "txtCelT2"
        Me.txtCelT2.Size = New System.Drawing.Size(224, 20)
        Me.txtCelT2.TabIndex = 16
        '
        'btnSaveTb1
        '
        Me.btnSaveTb1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveTb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveTb1.ForeColor = System.Drawing.Color.Black
        Me.btnSaveTb1.Image = CType(resources.GetObject("btnSaveTb1.Image"), System.Drawing.Image)
        Me.btnSaveTb1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveTb1.Location = New System.Drawing.Point(505, 88)
        Me.btnSaveTb1.Name = "btnSaveTb1"
        Me.btnSaveTb1.Size = New System.Drawing.Size(8, 8)
        Me.btnSaveTb1.TabIndex = 12
        Me.btnSaveTb1.Text = "&Guardar"
        Me.btnSaveTb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveTb1.UseVisualStyleBackColor = False
        Me.btnSaveTb1.Visible = False
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(307, 113)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(96, 20)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "Teléfono Celular:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEdadT2
        '
        Me.txtEdadT2.AcceptsReturn = True
        Me.txtEdadT2.BackColor = System.Drawing.Color.White
        Me.txtEdadT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEdadT2.Location = New System.Drawing.Point(409, 81)
        Me.txtEdadT2.MaxLength = 25
        Me.txtEdadT2.Name = "txtEdadT2"
        Me.txtEdadT2.ReadOnly = True
        Me.txtEdadT2.Size = New System.Drawing.Size(80, 20)
        Me.txtEdadT2.TabIndex = 11
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(307, 86)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(40, 16)
        Me.Label39.TabIndex = 10
        Me.Label39.Text = "Edad:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecNacT2
        '
        Me.dtpFecNacT2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNacT2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNacT2.Location = New System.Drawing.Point(76, 83)
        Me.dtpFecNacT2.Name = "dtpFecNacT2"
        Me.dtpFecNacT2.Size = New System.Drawing.Size(225, 20)
        Me.dtpFecNacT2.TabIndex = 9
        Me.dtpFecNacT2.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(6, 80)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(64, 25)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPartida
        '
        Me.txtPartida.AcceptsReturn = True
        Me.txtPartida.EditMask = "00000000-0"
        Me.txtPartida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida.Location = New System.Drawing.Point(409, 55)
        Me.txtPartida.MaxLength = 20
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.NumericInput = False
        Me.txtPartida.Size = New System.Drawing.Size(224, 18)
        Me.txtPartida.TabIndex = 7
        Me.txtPartida.Tag = Nothing
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(307, 53)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(88, 16)
        Me.Label42.TabIndex = 6
        Me.Label42.Text = "No. Documento"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbDoc
        '
        Me.cbDoc.BackColor = System.Drawing.Color.White
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoc.Items.AddRange(New Object() {"DUI", "NIT", "No. Licencia", "No. Residente", "No. Partida y No. Folio", "No. Pasaporte"})
        Me.cbDoc.Location = New System.Drawing.Point(76, 55)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(225, 22)
        Me.cbDoc.TabIndex = 5
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(6, 52)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(70, 19)
        Me.Label44.TabIndex = 4
        Me.Label44.Text = "Documento :"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTel
        '
        Me.txtTel.AcceptsReturn = True
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTel.Location = New System.Drawing.Point(76, 113)
        Me.txtTel.MaxLength = 25
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(225, 20)
        Me.txtTel.TabIndex = 14
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(6, 113)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(60, 24)
        Me.Label52.TabIndex = 13
        Me.Label52.Text = "Teléfono " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Casa:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(307, 31)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(64, 16)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "Parentesco:"
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(6, 19)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(60, 33)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "Nombre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Titular 2:"
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.lblEstado)
        Me.gbDatDoc.Controls.Add(Me.txtEdad)
        Me.gbDatDoc.Controls.Add(Me.txtDireccion)
        Me.gbDatDoc.Controls.Add(Me.Label6)
        Me.gbDatDoc.Controls.Add(Me.Label7)
        Me.gbDatDoc.Controls.Add(Me.txtTelOfic)
        Me.gbDatDoc.Controls.Add(Me.txtCel)
        Me.gbDatDoc.Controls.Add(Me.Label25)
        Me.gbDatDoc.Controls.Add(Me.txtTelCasa)
        Me.gbDatDoc.Controls.Add(Me.lblTelCasa)
        Me.gbDatDoc.Controls.Add(Me.Label23)
        Me.gbDatDoc.Controls.Add(Me.txtNoSocio)
        Me.gbDatDoc.Controls.Add(Me.Label8)
        Me.gbDatDoc.Controls.Add(Me.txtApe3)
        Me.gbDatDoc.Controls.Add(Me.Label9)
        Me.gbDatDoc.Controls.Add(Me.dtpFecNac)
        Me.gbDatDoc.Controls.Add(Me.Label10)
        Me.gbDatDoc.Controls.Add(Me.dtpFecExtDui)
        Me.gbDatDoc.Controls.Add(Me.Label12)
        Me.gbDatDoc.Controls.Add(Me.Label15)
        Me.gbDatDoc.Controls.Add(Me.txtLugDui)
        Me.gbDatDoc.Controls.Add(Me.txtProf)
        Me.gbDatDoc.Controls.Add(Me.Label24)
        Me.gbDatDoc.Controls.Add(Me.cbEstadoCivil)
        Me.gbDatDoc.Controls.Add(Me.Label26)
        Me.gbDatDoc.Controls.Add(Me.txtDui)
        Me.gbDatDoc.Controls.Add(Me.Label31)
        Me.gbDatDoc.Controls.Add(Me.txtApe2)
        Me.gbDatDoc.Controls.Add(Me.Label27)
        Me.gbDatDoc.Controls.Add(Me.txtNombres)
        Me.gbDatDoc.Controls.Add(Me.Label28)
        Me.gbDatDoc.Controls.Add(Me.txtApe1)
        Me.gbDatDoc.Controls.Add(Me.Label29)
        Me.gbDatDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Black
        Me.gbDatDoc.Location = New System.Drawing.Point(16, 41)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(644, 270)
        Me.gbDatDoc.TabIndex = 3
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Datos Personales"
        '
        'lblEstado
        '
        Me.lblEstado.BackColor = System.Drawing.Color.White
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Green
        Me.lblEstado.Location = New System.Drawing.Point(512, 16)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(121, 17)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Text = "Estado Cuenta"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEdad
        '
        Me.txtEdad.AcceptsReturn = True
        Me.txtEdad.BackColor = System.Drawing.Color.White
        Me.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEdad.Location = New System.Drawing.Point(409, 172)
        Me.txtEdad.MaxLength = 25
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(60, 20)
        Me.txtEdad.TabIndex = 24
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(76, 203)
        Me.txtDireccion.MaxLength = 100
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(557, 20)
        Me.txtDireccion.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Dirección:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(327, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 34)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Teléfono " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Oficina:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'txtTelOfic
        '
        Me.txtTelOfic.AcceptsReturn = True
        Me.txtTelOfic.BackColor = System.Drawing.Color.White
        Me.txtTelOfic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelOfic.Location = New System.Drawing.Point(409, 236)
        Me.txtTelOfic.MaxLength = 25
        Me.txtTelOfic.Name = "txtTelOfic"
        Me.txtTelOfic.ReadOnly = True
        Me.txtTelOfic.Size = New System.Drawing.Size(87, 20)
        Me.txtTelOfic.TabIndex = 32
        Me.txtTelOfic.Visible = False
        '
        'txtCel
        '
        Me.txtCel.AcceptsReturn = True
        Me.txtCel.BackColor = System.Drawing.Color.White
        Me.txtCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCel.Location = New System.Drawing.Point(230, 236)
        Me.txtCel.MaxLength = 25
        Me.txtCel.Name = "txtCel"
        Me.txtCel.ReadOnly = True
        Me.txtCel.Size = New System.Drawing.Size(88, 20)
        Me.txtCel.TabIndex = 30
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(170, 232)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 24)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "Teléfono " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Celular:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelCasa
        '
        Me.txtTelCasa.AcceptsReturn = True
        Me.txtTelCasa.BackColor = System.Drawing.Color.White
        Me.txtTelCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelCasa.Location = New System.Drawing.Point(77, 236)
        Me.txtTelCasa.MaxLength = 25
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.ReadOnly = True
        Me.txtTelCasa.Size = New System.Drawing.Size(87, 20)
        Me.txtTelCasa.TabIndex = 28
        '
        'lblTelCasa
        '
        Me.lblTelCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelCasa.ForeColor = System.Drawing.Color.Black
        Me.lblTelCasa.Location = New System.Drawing.Point(6, 229)
        Me.lblTelCasa.Name = "lblTelCasa"
        Me.lblTelCasa.Size = New System.Drawing.Size(60, 31)
        Me.lblTelCasa.TabIndex = 27
        Me.lblTelCasa.Text = "Teléfono " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Casa:"
        Me.lblTelCasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(307, 175)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 16)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "Edad:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.Location = New System.Drawing.Point(241, 24)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(80, 20)
        Me.txtNoSocio.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(155, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "No. Asociado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe3
        '
        Me.txtApe3.AcceptsReturn = True
        Me.txtApe3.BackColor = System.Drawing.Color.White
        Me.txtApe3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe3.Location = New System.Drawing.Point(77, 109)
        Me.txtApe3.MaxLength = 25
        Me.txtApe3.Name = "txtApe3"
        Me.txtApe3.ReadOnly = True
        Me.txtApe3.Size = New System.Drawing.Size(224, 20)
        Me.txtApe3.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 32)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Apellido de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Casada"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Enabled = False
        Me.dtpFecNac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNac.Location = New System.Drawing.Point(76, 172)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(225, 20)
        Me.dtpFecNac.TabIndex = 22
        Me.dtpFecNac.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 33)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecExtDui
        '
        Me.dtpFecExtDui.Enabled = False
        Me.dtpFecExtDui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecExtDui.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecExtDui.Location = New System.Drawing.Point(409, 140)
        Me.dtpFecExtDui.Name = "dtpFecExtDui"
        Me.dtpFecExtDui.Size = New System.Drawing.Size(224, 20)
        Me.dtpFecExtDui.TabIndex = 20
        Me.dtpFecExtDui.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(307, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 33)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Fecha extensión " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DUI:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 35)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Extensión " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DUI:"
        '
        'txtLugDui
        '
        Me.txtLugDui.BackColor = System.Drawing.Color.White
        Me.txtLugDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugDui.Location = New System.Drawing.Point(76, 140)
        Me.txtLugDui.MaxLength = 25
        Me.txtLugDui.Name = "txtLugDui"
        Me.txtLugDui.ReadOnly = True
        Me.txtLugDui.Size = New System.Drawing.Size(225, 20)
        Me.txtLugDui.TabIndex = 18
        '
        'txtProf
        '
        Me.txtProf.BackColor = System.Drawing.Color.White
        Me.txtProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProf.Location = New System.Drawing.Point(409, 109)
        Me.txtProf.MaxLength = 100
        Me.txtProf.Name = "txtProf"
        Me.txtProf.ReadOnly = True
        Me.txtProf.Size = New System.Drawing.Size(224, 20)
        Me.txtProf.TabIndex = 16
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(307, 109)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Ocupación:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.BackColor = System.Drawing.Color.White
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.Enabled = False
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Acompañado", "Viudo"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(409, 73)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(224, 22)
        Me.cbEstadoCivil.TabIndex = 12
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(307, 77)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 16)
        Me.Label26.TabIndex = 11
        Me.Label26.Text = "Estado Civil:"
        '
        'txtDui
        '
        Me.txtDui.AcceptsReturn = True
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(45, 23)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(104, 18)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(6, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 16)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Dui:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe2
        '
        Me.txtApe2.AcceptsReturn = True
        Me.txtApe2.BackColor = System.Drawing.Color.White
        Me.txtApe2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe2.Location = New System.Drawing.Point(77, 75)
        Me.txtApe2.MaxLength = 25
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.ReadOnly = True
        Me.txtApe2.Size = New System.Drawing.Size(224, 20)
        Me.txtApe2.TabIndex = 10
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(6, 77)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "Apellido 2"
        '
        'txtNombres
        '
        Me.txtNombres.AcceptsReturn = True
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(77, 49)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(224, 20)
        Me.txtNombres.TabIndex = 6
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(6, 49)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 16)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Nombres"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe1
        '
        Me.txtApe1.AcceptsReturn = True
        Me.txtApe1.BackColor = System.Drawing.Color.White
        Me.txtApe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe1.Location = New System.Drawing.Point(409, 49)
        Me.txtApe1.MaxLength = 25
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.ReadOnly = True
        Me.txtApe1.Size = New System.Drawing.Size(224, 20)
        Me.txtApe1.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(307, 49)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 16)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Apellido 1"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MetroButton1)
        Me.TabPage1.Controls.Add(Me.btnSiguiente2)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.gbDepositosAutomaticos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(674, 510)
        Me.TabPage1.TabIndex = 9
        Me.TabPage1.Text = "Datos de Cuenta"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(515, 466)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 3
        Me.MetroButton1.Text = "Atrás"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnSiguiente2
        '
        Me.btnSiguiente2.Location = New System.Drawing.Point(596, 466)
        Me.btnSiguiente2.Name = "btnSiguiente2"
        Me.btnSiguiente2.Size = New System.Drawing.Size(75, 28)
        Me.btnSiguiente2.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSiguiente2.TabIndex = 0
        Me.btnSiguiente2.Text = "Siguiente"
        Me.btnSiguiente2.UseSelectable = True
        Me.btnSiguiente2.UseStyleColors = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.btnConsPlanAh)
        Me.GroupBox3.Controls.Add(Me.btModificaPlanAh)
        Me.GroupBox3.Controls.Add(Me.btTasaPactada)
        Me.GroupBox3.Controls.Add(Me.Label60)
        Me.GroupBox3.Controls.Add(Me.txtCodAhorro)
        Me.GroupBox3.Controls.Add(Me.txtAhorro)
        Me.GroupBox3.Controls.Add(Me.dtpFecVenc)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtNoLibreta)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.nuDNoCuotas)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.c1nCuota)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.dtpFec1Cuota)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.c1nTasa)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.c1nMonto)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.c1nPlazo)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtCodDestino)
        Me.GroupBox3.Controls.Add(Me.txtDestino)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.c1nMontoApertura)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.dtpFechaApertura)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblFecIniApertura)
        Me.GroupBox3.Controls.Add(Me.dtpFecIniApertura)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(668, 284)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Cuenta"
        '
        'btnConsPlanAh
        '
        Me.btnConsPlanAh.Location = New System.Drawing.Point(6, 247)
        Me.btnConsPlanAh.Name = "btnConsPlanAh"
        Me.btnConsPlanAh.Size = New System.Drawing.Size(164, 28)
        Me.btnConsPlanAh.Style = MetroFramework.MetroColorStyle.Green
        Me.btnConsPlanAh.TabIndex = 28
        Me.btnConsPlanAh.Text = "Consultar Plan de Ahorro"
        Me.btnConsPlanAh.UseSelectable = True
        Me.btnConsPlanAh.UseStyleColors = True
        '
        'btModificaPlanAh
        '
        Me.btModificaPlanAh.Location = New System.Drawing.Point(176, 247)
        Me.btModificaPlanAh.Name = "btModificaPlanAh"
        Me.btModificaPlanAh.Size = New System.Drawing.Size(164, 28)
        Me.btModificaPlanAh.Style = MetroFramework.MetroColorStyle.Green
        Me.btModificaPlanAh.TabIndex = 29
        Me.btModificaPlanAh.Text = "Modificar Plan de Ahorro"
        Me.btModificaPlanAh.UseSelectable = True
        Me.btModificaPlanAh.UseStyleColors = True
        '
        'btTasaPactada
        '
        Me.btTasaPactada.Location = New System.Drawing.Point(570, 47)
        Me.btTasaPactada.Name = "btTasaPactada"
        Me.btTasaPactada.Size = New System.Drawing.Size(75, 20)
        Me.btTasaPactada.Style = MetroFramework.MetroColorStyle.Green
        Me.btTasaPactada.TabIndex = 7
        Me.btTasaPactada.Text = "Tasa Pactada"
        Me.btTasaPactada.UseSelectable = True
        Me.btTasaPactada.UseStyleColors = True
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(4, 21)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(82, 16)
        Me.Label60.TabIndex = 0
        Me.Label60.Text = "Tipo de Ahorro:"
        '
        'txtCodAhorro
        '
        Me.txtCodAhorro.AcceptsReturn = True
        Me.txtCodAhorro.BackColor = System.Drawing.Color.White
        Me.txtCodAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodAhorro.Location = New System.Drawing.Point(89, 19)
        Me.txtCodAhorro.MaxLength = 10
        Me.txtCodAhorro.Name = "txtCodAhorro"
        Me.txtCodAhorro.ReadOnly = True
        Me.txtCodAhorro.Size = New System.Drawing.Size(64, 20)
        Me.txtCodAhorro.TabIndex = 1
        '
        'txtAhorro
        '
        Me.txtAhorro.BackColor = System.Drawing.Color.White
        Me.txtAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAhorro.Location = New System.Drawing.Point(159, 19)
        Me.txtAhorro.MaxLength = 110
        Me.txtAhorro.Name = "txtAhorro"
        Me.txtAhorro.ReadOnly = True
        Me.txtAhorro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAhorro.Size = New System.Drawing.Size(486, 20)
        Me.txtAhorro.TabIndex = 2
        '
        'dtpFecVenc
        '
        Me.dtpFecVenc.Enabled = False
        Me.dtpFecVenc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecVenc.Location = New System.Drawing.Point(89, 137)
        Me.dtpFecVenc.Name = "dtpFecVenc"
        Me.dtpFecVenc.Size = New System.Drawing.Size(192, 20)
        Me.dtpFecVenc.TabIndex = 17
        Me.dtpFecVenc.Value = New Date(2017, 11, 27, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 28)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vencimiento:"
        '
        'txtNoLibreta
        '
        Me.txtNoLibreta.AcceptsReturn = True
        Me.txtNoLibreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoLibreta.Location = New System.Drawing.Point(453, 71)
        Me.txtNoLibreta.MaxLength = 20
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.Size = New System.Drawing.Size(192, 20)
        Me.txtNoLibreta.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(375, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "No. Libreta:"
        '
        'nuDNoCuotas
        '
        Me.nuDNoCuotas.BackColor = System.Drawing.Color.White
        Me.nuDNoCuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nuDNoCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuDNoCuotas.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nuDNoCuotas.Location = New System.Drawing.Point(89, 175)
        Me.nuDNoCuotas.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nuDNoCuotas.Name = "nuDNoCuotas"
        Me.nuDNoCuotas.ReadOnly = True
        Me.nuDNoCuotas.Size = New System.Drawing.Size(192, 20)
        Me.nuDNoCuotas.TabIndex = 21
        Me.nuDNoCuotas.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nuDNoCuotas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(4, 179)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "No. Cuotas:"
        '
        'c1nCuota
        '
        Me.c1nCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCuota.CustomFormat = "###,###,##0.00"
        Me.c1nCuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCuota.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCuota.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCuota.Location = New System.Drawing.Point(452, 171)
        Me.c1nCuota.Name = "c1nCuota"
        Me.c1nCuota.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCuota.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCuota.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCuota.Size = New System.Drawing.Size(193, 18)
        Me.c1nCuota.TabIndex = 23
        Me.c1nCuota.Tag = Nothing
        Me.c1nCuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCuota.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(375, 175)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 16)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Cuota:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFec1Cuota
        '
        Me.dtpFec1Cuota.Enabled = False
        Me.dtpFec1Cuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFec1Cuota.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFec1Cuota.Location = New System.Drawing.Point(477, 205)
        Me.dtpFec1Cuota.Name = "dtpFec1Cuota"
        Me.dtpFec1Cuota.Size = New System.Drawing.Size(168, 20)
        Me.dtpFec1Cuota.TabIndex = 27
        Me.dtpFec1Cuota.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(375, 210)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 16)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Fecha 1a. Cuota:"
        '
        'c1nTasa
        '
        Me.c1nTasa.BackColor = System.Drawing.Color.White
        Me.c1nTasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasa.CustomFormat = "#0.00"
        Me.c1nTasa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTasa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasa.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTasa.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nTasa.Location = New System.Drawing.Point(453, 45)
        Me.c1nTasa.Name = "c1nTasa"
        Me.c1nTasa.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasa.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasa.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasa.ReadOnly = True
        Me.c1nTasa.Size = New System.Drawing.Size(111, 19)
        Me.c1nTasa.TabIndex = 6
        Me.c1nTasa.Tag = Nothing
        Me.c1nTasa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(375, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 16)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Tasa Interés:"
        '
        'c1nMonto
        '
        Me.c1nMonto.BackColor = System.Drawing.Color.White
        Me.c1nMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMonto.CustomFormat = "###,###,##0.00"
        Me.c1nMonto.Enabled = False
        Me.c1nMonto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMonto.Location = New System.Drawing.Point(89, 210)
        Me.c1nMonto.Name = "c1nMonto"
        Me.c1nMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMonto.ReadOnly = True
        Me.c1nMonto.Size = New System.Drawing.Size(192, 18)
        Me.c1nMonto.TabIndex = 25
        Me.c1nMonto.Tag = Nothing
        Me.c1nMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(6, 210)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 34)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Saldo al final " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de plazo:"
        '
        'c1nPlazo
        '
        Me.c1nPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPlazo.CustomFormat = "#0"
        Me.c1nPlazo.DataType = GetType(Short)
        Me.c1nPlazo.Enabled = False
        Me.c1nPlazo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nPlazo.Location = New System.Drawing.Point(453, 137)
        Me.c1nPlazo.MaxLength = 2
        Me.c1nPlazo.Name = "c1nPlazo"
        Me.c1nPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nPlazo.Size = New System.Drawing.Size(192, 18)
        Me.c1nPlazo.TabIndex = 19
        Me.c1nPlazo.Tag = Nothing
        Me.c1nPlazo.Value = CType(0, Short)
        Me.c1nPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(375, 141)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Plazo:"
        '
        'txtCodDestino
        '
        Me.txtCodDestino.AcceptsReturn = True
        Me.txtCodDestino.BackColor = System.Drawing.Color.White
        Me.txtCodDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDestino.Enabled = False
        Me.txtCodDestino.Location = New System.Drawing.Point(453, 231)
        Me.txtCodDestino.MaxLength = 10
        Me.txtCodDestino.Name = "txtCodDestino"
        Me.txtCodDestino.Size = New System.Drawing.Size(40, 20)
        Me.txtCodDestino.TabIndex = 31
        Me.txtCodDestino.Visible = False
        '
        'txtDestino
        '
        Me.txtDestino.BackColor = System.Drawing.Color.White
        Me.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestino.Enabled = False
        Me.txtDestino.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestino.Location = New System.Drawing.Point(499, 231)
        Me.txtDestino.MaxLength = 110
        Me.txtDestino.Multiline = True
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.ReadOnly = True
        Me.txtDestino.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDestino.Size = New System.Drawing.Size(146, 44)
        Me.txtDestino.TabIndex = 32
        Me.txtDestino.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Enabled = False
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(375, 235)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 16)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Destino:"
        Me.Label16.Visible = False
        '
        'c1nMontoApertura
        '
        Me.c1nMontoApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoApertura.CustomFormat = "###,###,##0.00"
        Me.c1nMontoApertura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoApertura.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoApertura.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMontoApertura.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoApertura.Location = New System.Drawing.Point(89, 73)
        Me.c1nMontoApertura.Name = "c1nMontoApertura"
        Me.c1nMontoApertura.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoApertura.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoApertura.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoApertura.Size = New System.Drawing.Size(192, 19)
        Me.c1nMontoApertura.TabIndex = 9
        Me.c1nMontoApertura.Tag = Nothing
        Me.c1nMontoApertura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoApertura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(4, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 30)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Monto de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apertura:"
        '
        'dtpFechaApertura
        '
        Me.dtpFechaApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaApertura.Location = New System.Drawing.Point(453, 105)
        Me.dtpFechaApertura.Name = "dtpFechaApertura"
        Me.dtpFechaApertura.Size = New System.Drawing.Size(192, 20)
        Me.dtpFechaApertura.TabIndex = 15
        Me.dtpFechaApertura.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(375, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 28)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apertura:"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BackColor = System.Drawing.Color.White
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.Location = New System.Drawing.Point(89, 45)
        Me.txtNoCuenta.MaxLength = 20
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.ReadOnly = True
        Me.txtNoCuenta.Size = New System.Drawing.Size(192, 22)
        Me.txtNoCuenta.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No. Cuenta:"
        '
        'lblFecIniApertura
        '
        Me.lblFecIniApertura.BackColor = System.Drawing.Color.White
        Me.lblFecIniApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecIniApertura.ForeColor = System.Drawing.Color.Black
        Me.lblFecIniApertura.Location = New System.Drawing.Point(4, 103)
        Me.lblFecIniApertura.Name = "lblFecIniApertura"
        Me.lblFecIniApertura.Size = New System.Drawing.Size(78, 28)
        Me.lblFecIniApertura.TabIndex = 12
        Me.lblFecIniApertura.Text = "Fecha Inicio Apertura:"
        '
        'dtpFecIniApertura
        '
        Me.dtpFecIniApertura.Enabled = False
        Me.dtpFecIniApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIniApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIniApertura.Location = New System.Drawing.Point(89, 105)
        Me.dtpFecIniApertura.Name = "dtpFecIniApertura"
        Me.dtpFecIniApertura.Size = New System.Drawing.Size(192, 20)
        Me.dtpFecIniApertura.TabIndex = 13
        Me.dtpFecIniApertura.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'gbDepositosAutomaticos
        '
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label58)
        Me.gbDepositosAutomaticos.Controls.Add(Me.c1nMontoTransf)
        Me.gbDepositosAutomaticos.Controls.Add(Me.txtNoCuentaDepAut)
        Me.gbDepositosAutomaticos.Controls.Add(Me.TextBox3)
        Me.gbDepositosAutomaticos.Controls.Add(Me.dtpFecFinDA)
        Me.gbDepositosAutomaticos.Controls.Add(Me.dtpFecIniDA)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label57)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label56)
        Me.gbDepositosAutomaticos.Controls.Add(Me.txtDigito)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label55)
        Me.gbDepositosAutomaticos.Controls.Add(Me.txtCodTipoAhorroDepAut)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label5)
        Me.gbDepositosAutomaticos.Controls.Add(Me.cbTipoDeposito)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label61)
        Me.gbDepositosAutomaticos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDepositosAutomaticos.ForeColor = System.Drawing.Color.Navy
        Me.gbDepositosAutomaticos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gbDepositosAutomaticos.Location = New System.Drawing.Point(3, 295)
        Me.gbDepositosAutomaticos.Name = "gbDepositosAutomaticos"
        Me.gbDepositosAutomaticos.Size = New System.Drawing.Size(668, 104)
        Me.gbDepositosAutomaticos.TabIndex = 2
        Me.gbDepositosAutomaticos.TabStop = False
        Me.gbDepositosAutomaticos.Visible = False
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(284, 66)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(40, 16)
        Me.Label58.TabIndex = 12
        Me.Label58.Text = "Monto:"
        '
        'c1nMontoTransf
        '
        Me.c1nMontoTransf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoTransf.CustomFormat = "###,###,##0.00"
        Me.c1nMontoTransf.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoTransf.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoTransf.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMontoTransf.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoTransf.Location = New System.Drawing.Point(327, 66)
        Me.c1nMontoTransf.Name = "c1nMontoTransf"
        Me.c1nMontoTransf.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoTransf.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoTransf.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoTransf.Size = New System.Drawing.Size(64, 18)
        Me.c1nMontoTransf.TabIndex = 13
        Me.c1nMontoTransf.Tag = Nothing
        Me.c1nMontoTransf.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoTransf.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtNoCuentaDepAut
        '
        Me.txtNoCuentaDepAut.BackColor = System.Drawing.Color.White
        Me.txtNoCuentaDepAut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuentaDepAut.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuentaDepAut.Location = New System.Drawing.Point(397, 16)
        Me.txtNoCuentaDepAut.MaxLength = 20
        Me.txtNoCuentaDepAut.Name = "txtNoCuentaDepAut"
        Me.txtNoCuentaDepAut.ReadOnly = True
        Me.txtNoCuentaDepAut.Size = New System.Drawing.Size(96, 20)
        Me.txtNoCuentaDepAut.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(571, 19)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(16, 20)
        Me.TextBox3.TabIndex = 5
        '
        'dtpFecFinDA
        '
        Me.dtpFecFinDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecFinDA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFinDA.Location = New System.Drawing.Point(191, 66)
        Me.dtpFecFinDA.Name = "dtpFecFinDA"
        Me.dtpFecFinDA.Size = New System.Drawing.Size(84, 20)
        Me.dtpFecFinDA.TabIndex = 11
        Me.dtpFecFinDA.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'dtpFecIniDA
        '
        Me.dtpFecIniDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIniDA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIniDA.Location = New System.Drawing.Point(52, 66)
        Me.dtpFecIniDA.Name = "dtpFecIniDA"
        Me.dtpFecIniDA.Size = New System.Drawing.Size(84, 20)
        Me.dtpFecIniDA.TabIndex = 9
        Me.dtpFecIniDA.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(145, 66)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(40, 16)
        Me.Label57.TabIndex = 10
        Me.Label57.Text = "Hasta:"
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(6, 66)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(40, 16)
        Me.Label56.TabIndex = 8
        Me.Label56.Text = "Desde:"
        '
        'txtDigito
        '
        Me.txtDigito.Location = New System.Drawing.Point(556, 19)
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(8, 20)
        Me.txtDigito.TabIndex = 6
        Me.txtDigito.Visible = False
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(6, 40)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(176, 16)
        Me.Label55.TabIndex = 7
        Me.Label55.Text = "Período del Depósito Automático:"
        '
        'txtCodTipoAhorroDepAut
        '
        Me.txtCodTipoAhorroDepAut.Location = New System.Drawing.Point(499, 16)
        Me.txtCodTipoAhorroDepAut.Name = "txtCodTipoAhorroDepAut"
        Me.txtCodTipoAhorroDepAut.Size = New System.Drawing.Size(8, 20)
        Me.txtCodTipoAhorroDepAut.TabIndex = 4
        Me.txtCodTipoAhorroDepAut.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tipo Depósito a Cuenta:"
        '
        'cbTipoDeposito
        '
        Me.cbTipoDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoDeposito.Items.AddRange(New Object() {"Personal", "Por Transferencia"})
        Me.cbTipoDeposito.Location = New System.Drawing.Point(135, 16)
        Me.cbTipoDeposito.Name = "cbTipoDeposito"
        Me.cbTipoDeposito.Size = New System.Drawing.Size(112, 21)
        Me.cbTipoDeposito.TabIndex = 1
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(287, 16)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(104, 16)
        Me.Label61.TabIndex = 2
        Me.Label61.Text = "Número de Cuenta:"
        '
        'tabDatGralII
        '
        Me.tabDatGralII.BackColor = System.Drawing.Color.White
        Me.tabDatGralII.Controls.Add(Me.btnSaveTb3)
        Me.tabDatGralII.Controls.Add(Me.MetroButton2)
        Me.tabDatGralII.Controls.Add(Me.MetroButton4)
        Me.tabDatGralII.Controls.Add(Me.GroupBox8)
        Me.tabDatGralII.Controls.Add(Me.gbCancela)
        Me.tabDatGralII.Controls.Add(Me.GroupBox1)
        Me.tabDatGralII.Location = New System.Drawing.Point(4, 22)
        Me.tabDatGralII.Name = "tabDatGralII"
        Me.tabDatGralII.Size = New System.Drawing.Size(674, 510)
        Me.tabDatGralII.TabIndex = 5
        Me.tabDatGralII.Text = "Otros Datos"
        '
        'btnSaveTb3
        '
        Me.btnSaveTb3.Location = New System.Drawing.Point(596, 477)
        Me.btnSaveTb3.Name = "btnSaveTb3"
        Me.btnSaveTb3.Size = New System.Drawing.Size(75, 28)
        Me.btnSaveTb3.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSaveTb3.TabIndex = 0
        Me.btnSaveTb3.Text = "Guardar"
        Me.btnSaveTb3.UseSelectable = True
        Me.btnSaveTb3.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(434, 477)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton2.TabIndex = 4
        Me.MetroButton2.Text = "Atrás"
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(515, 477)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton4.TabIndex = 5
        Me.MetroButton4.Text = "Siguiente"
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DataGridView1)
        Me.GroupBox8.Controls.Add(Me.cbAsignarAhorro)
        Me.GroupBox8.Location = New System.Drawing.Point(17, 351)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(545, 102)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Asignación de prestamo para Transferencia Automatica"
        Me.GroupBox8.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(513, 30)
        Me.DataGridView1.TabIndex = 3
        '
        'cbAsignarAhorro
        '
        Me.cbAsignarAhorro.AutoSize = True
        Me.cbAsignarAhorro.Location = New System.Drawing.Point(323, 31)
        Me.cbAsignarAhorro.Name = "cbAsignarAhorro"
        Me.cbAsignarAhorro.Size = New System.Drawing.Size(206, 17)
        Me.cbAsignarAhorro.TabIndex = 2
        Me.cbAsignarAhorro.Text = "Asignar Prestamo a Cuenta de Ahorro."
        Me.cbAsignarAhorro.UseVisualStyleBackColor = True
        '
        'gbCancela
        '
        Me.gbCancela.BackColor = System.Drawing.Color.White
        Me.gbCancela.Controls.Add(Me.dtpFecCanc)
        Me.gbCancela.Controls.Add(Me.Label30)
        Me.gbCancela.Controls.Add(Me.txtEjecMercadeoCanc)
        Me.gbCancela.Controls.Add(Me.txtCodEjecCanc)
        Me.gbCancela.Controls.Add(Me.Label13)
        Me.gbCancela.Controls.Add(Me.txtMotivoCancela)
        Me.gbCancela.Controls.Add(Me.Label45)
        Me.gbCancela.Enabled = False
        Me.gbCancela.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCancela.ForeColor = System.Drawing.Color.Black
        Me.gbCancela.Location = New System.Drawing.Point(8, 155)
        Me.gbCancela.Name = "gbCancela"
        Me.gbCancela.Size = New System.Drawing.Size(644, 119)
        Me.gbCancela.TabIndex = 2
        Me.gbCancela.TabStop = False
        Me.gbCancela.Text = "Cancelación de Cuenta"
        '
        'dtpFecCanc
        '
        Me.dtpFecCanc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCanc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCanc.Location = New System.Drawing.Point(108, 19)
        Me.dtpFecCanc.Name = "dtpFecCanc"
        Me.dtpFecCanc.Size = New System.Drawing.Size(108, 20)
        Me.dtpFecCanc.TabIndex = 2
        Me.dtpFecCanc.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(6, 88)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(59, 28)
        Me.Label30.TabIndex = 5
        Me.Label30.Text = "Código " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ejecutivo:"
        '
        'txtEjecMercadeoCanc
        '
        Me.txtEjecMercadeoCanc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecMercadeoCanc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeoCanc.Location = New System.Drawing.Point(178, 83)
        Me.txtEjecMercadeoCanc.MaxLength = 100
        Me.txtEjecMercadeoCanc.Name = "txtEjecMercadeoCanc"
        Me.txtEjecMercadeoCanc.ReadOnly = True
        Me.txtEjecMercadeoCanc.Size = New System.Drawing.Size(460, 20)
        Me.txtEjecMercadeoCanc.TabIndex = 0
        '
        'txtCodEjecCanc
        '
        Me.txtCodEjecCanc.AcceptsReturn = True
        Me.txtCodEjecCanc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecCanc.Location = New System.Drawing.Point(108, 83)
        Me.txtCodEjecCanc.MaxLength = 10
        Me.txtCodEjecCanc.Name = "txtCodEjecCanc"
        Me.txtCodEjecCanc.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEjecCanc.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 32)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cancelación:"
        '
        'txtMotivoCancela
        '
        Me.txtMotivoCancela.AcceptsReturn = True
        Me.txtMotivoCancela.Location = New System.Drawing.Point(108, 45)
        Me.txtMotivoCancela.Multiline = True
        Me.txtMotivoCancela.Name = "txtMotivoCancela"
        Me.txtMotivoCancela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoCancela.Size = New System.Drawing.Size(530, 32)
        Me.txtMotivoCancela.TabIndex = 4
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(6, 52)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(78, 25)
        Me.Label45.TabIndex = 3
        Me.Label45.Text = "Motivo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cancelación:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.lblCodPrestamo)
        Me.GroupBox1.Controls.Add(Me.txtEjecApertura)
        Me.GroupBox1.Controls.Add(Me.txtCodEjecApertura)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.txtEjecMercadeo)
        Me.GroupBox1.Controls.Add(Me.txtCodEjecMercadeo)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 141)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Location = New System.Drawing.Point(108, 113)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(257, 20)
        Me.txtCodPrestamo.TabIndex = 1
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(6, 51)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(96, 29)
        Me.Label41.TabIndex = 3
        Me.Label41.Text = "Código Ejecutivo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apertura:"
        '
        'lblCodPrestamo
        '
        Me.lblCodPrestamo.AutoSize = True
        Me.lblCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPrestamo.ForeColor = System.Drawing.Color.Black
        Me.lblCodPrestamo.Location = New System.Drawing.Point(6, 116)
        Me.lblCodPrestamo.Name = "lblCodPrestamo"
        Me.lblCodPrestamo.Size = New System.Drawing.Size(58, 14)
        Me.lblCodPrestamo.TabIndex = 0
        Me.lblCodPrestamo.Text = "Préstamo: "
        '
        'txtEjecApertura
        '
        Me.txtEjecApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecApertura.Location = New System.Drawing.Point(178, 51)
        Me.txtEjecApertura.MaxLength = 100
        Me.txtEjecApertura.Name = "txtEjecApertura"
        Me.txtEjecApertura.ReadOnly = True
        Me.txtEjecApertura.Size = New System.Drawing.Size(460, 20)
        Me.txtEjecApertura.TabIndex = 5
        '
        'txtCodEjecApertura
        '
        Me.txtCodEjecApertura.AcceptsReturn = True
        Me.txtCodEjecApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecApertura.Location = New System.Drawing.Point(108, 51)
        Me.txtCodEjecApertura.MaxLength = 10
        Me.txtCodEjecApertura.Name = "txtCodEjecApertura"
        Me.txtCodEjecApertura.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEjecApertura.TabIndex = 4
        '
        'txtObs
        '
        Me.txtObs.AcceptsReturn = True
        Me.txtObs.Location = New System.Drawing.Point(108, 77)
        Me.txtObs.MaxLength = 0
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(530, 30)
        Me.txtObs.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(6, 80)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 16)
        Me.Label43.TabIndex = 6
        Me.Label43.Text = "Observaciones:"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(6, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(96, 25)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "Código Ejecutivo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gestión:"
        '
        'txtEjecMercadeo
        '
        Me.txtEjecMercadeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecMercadeo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeo.Location = New System.Drawing.Point(178, 19)
        Me.txtEjecMercadeo.MaxLength = 100
        Me.txtEjecMercadeo.Name = "txtEjecMercadeo"
        Me.txtEjecMercadeo.ReadOnly = True
        Me.txtEjecMercadeo.Size = New System.Drawing.Size(460, 20)
        Me.txtEjecMercadeo.TabIndex = 2
        '
        'txtCodEjecMercadeo
        '
        Me.txtCodEjecMercadeo.AcceptsReturn = True
        Me.txtCodEjecMercadeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecMercadeo.Location = New System.Drawing.Point(108, 19)
        Me.txtCodEjecMercadeo.MaxLength = 10
        Me.txtCodEjecMercadeo.Name = "txtCodEjecMercadeo"
        Me.txtCodEjecMercadeo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEjecMercadeo.TabIndex = 1
        '
        'tbBeneficiarios
        '
        Me.tbBeneficiarios.BackColor = System.Drawing.Color.White
        Me.tbBeneficiarios.Controls.Add(Me.btnContrato)
        Me.tbBeneficiarios.Controls.Add(Me.MetroButton7)
        Me.tbBeneficiarios.Controls.Add(Me.MetroButton8)
        Me.tbBeneficiarios.Controls.Add(Me.GroupBox2)
        Me.tbBeneficiarios.Controls.Add(Me.GroupBox7)
        Me.tbBeneficiarios.Location = New System.Drawing.Point(4, 22)
        Me.tbBeneficiarios.Name = "tbBeneficiarios"
        Me.tbBeneficiarios.Size = New System.Drawing.Size(674, 510)
        Me.tbBeneficiarios.TabIndex = 4
        Me.tbBeneficiarios.Text = "Beneficiarios"
        Me.tbBeneficiarios.Visible = False
        '
        'btnContrato
        '
        Me.btnContrato.Location = New System.Drawing.Point(434, 477)
        Me.btnContrato.Name = "btnContrato"
        Me.btnContrato.Size = New System.Drawing.Size(75, 28)
        Me.btnContrato.Style = MetroFramework.MetroColorStyle.Green
        Me.btnContrato.TabIndex = 2
        Me.btnContrato.Text = "Contrato"
        Me.btnContrato.UseSelectable = True
        Me.btnContrato.UseStyleColors = True
        '
        'MetroButton7
        '
        Me.MetroButton7.Location = New System.Drawing.Point(515, 477)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton7.TabIndex = 3
        Me.MetroButton7.Text = "Atrás"
        Me.MetroButton7.UseSelectable = True
        Me.MetroButton7.UseStyleColors = True
        '
        'MetroButton8
        '
        Me.MetroButton8.Location = New System.Drawing.Point(596, 477)
        Me.MetroButton8.Name = "MetroButton8"
        Me.MetroButton8.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton8.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton8.TabIndex = 4
        Me.MetroButton8.Text = "Siguiente"
        Me.MetroButton8.UseSelectable = True
        Me.MetroButton8.UseStyleColors = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btDel)
        Me.GroupBox2.Controls.Add(Me.btnEditAut)
        Me.GroupBox2.Controls.Add(Me.btNew)
        Me.GroupBox2.Controls.Add(Me.fgAut)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(644, 208)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Autorizados a realizar retiros"
        '
        'btDel
        '
        Me.btDel.Location = New System.Drawing.Point(186, 22)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(75, 28)
        Me.btDel.Style = MetroFramework.MetroColorStyle.Green
        Me.btDel.TabIndex = 2
        Me.btDel.Text = "Eliminar"
        Me.btDel.UseSelectable = True
        Me.btDel.UseStyleColors = True
        '
        'btnEditAut
        '
        Me.btnEditAut.Location = New System.Drawing.Point(105, 22)
        Me.btnEditAut.Name = "btnEditAut"
        Me.btnEditAut.Size = New System.Drawing.Size(75, 28)
        Me.btnEditAut.Style = MetroFramework.MetroColorStyle.Green
        Me.btnEditAut.TabIndex = 1
        Me.btnEditAut.Text = "Modificar"
        Me.btnEditAut.UseSelectable = True
        Me.btnEditAut.UseStyleColors = True
        '
        'btNew
        '
        Me.btNew.Location = New System.Drawing.Point(24, 22)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(75, 28)
        Me.btNew.Style = MetroFramework.MetroColorStyle.Green
        Me.btNew.TabIndex = 0
        Me.btNew.Text = "Nuevo"
        Me.btNew.UseSelectable = True
        Me.btNew.UseStyleColors = True
        '
        'fgAut
        '
        Me.fgAut.AllowEditing = False
        Me.fgAut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgAut.BackColor = System.Drawing.Color.White
        Me.fgAut.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgAut.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgAut.ForeColor = System.Drawing.Color.Black
        Me.fgAut.Location = New System.Drawing.Point(24, 56)
        Me.fgAut.Name = "fgAut"
        Me.fgAut.Rows.Count = 1
        Me.fgAut.Rows.DefaultSize = 19
        Me.fgAut.Size = New System.Drawing.Size(614, 136)
        Me.fgAut.StyleInfo = resources.GetString("fgAut.StyleInfo")
        Me.fgAut.TabIndex = 3
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.btDelBen)
        Me.GroupBox7.Controls.Add(Me.btEditBen)
        Me.GroupBox7.Controls.Add(Me.btNewBen)
        Me.GroupBox7.Controls.Add(Me.fgBen)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(644, 216)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Beneficiarios"
        '
        'btDelBen
        '
        Me.btDelBen.Location = New System.Drawing.Point(186, 22)
        Me.btDelBen.Name = "btDelBen"
        Me.btDelBen.Size = New System.Drawing.Size(75, 28)
        Me.btDelBen.Style = MetroFramework.MetroColorStyle.Green
        Me.btDelBen.TabIndex = 2
        Me.btDelBen.Text = "Eliminar"
        Me.btDelBen.UseSelectable = True
        Me.btDelBen.UseStyleColors = True
        '
        'btEditBen
        '
        Me.btEditBen.Location = New System.Drawing.Point(105, 22)
        Me.btEditBen.Name = "btEditBen"
        Me.btEditBen.Size = New System.Drawing.Size(75, 28)
        Me.btEditBen.Style = MetroFramework.MetroColorStyle.Green
        Me.btEditBen.TabIndex = 1
        Me.btEditBen.Text = "Modificar"
        Me.btEditBen.UseSelectable = True
        Me.btEditBen.UseStyleColors = True
        '
        'btNewBen
        '
        Me.btNewBen.Location = New System.Drawing.Point(24, 22)
        Me.btNewBen.Name = "btNewBen"
        Me.btNewBen.Size = New System.Drawing.Size(75, 28)
        Me.btNewBen.Style = MetroFramework.MetroColorStyle.Green
        Me.btNewBen.TabIndex = 0
        Me.btNewBen.Text = "Nuevo"
        Me.btNewBen.UseSelectable = True
        Me.btNewBen.UseStyleColors = True
        '
        'fgBen
        '
        Me.fgBen.AllowEditing = False
        Me.fgBen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgBen.BackColor = System.Drawing.Color.White
        Me.fgBen.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgBen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgBen.ForeColor = System.Drawing.Color.Black
        Me.fgBen.Location = New System.Drawing.Point(24, 56)
        Me.fgBen.Name = "fgBen"
        Me.fgBen.Rows.Count = 1
        Me.fgBen.Rows.DefaultSize = 19
        Me.fgBen.Size = New System.Drawing.Size(614, 144)
        Me.fgBen.StyleInfo = resources.GetString("fgBen.StyleInfo")
        Me.fgBen.TabIndex = 3
        '
        'tbLibRep
        '
        Me.tbLibRep.BackColor = System.Drawing.Color.White
        Me.tbLibRep.Controls.Add(Me.MetroButton9)
        Me.tbLibRep.Controls.Add(Me.btnSaveTb7)
        Me.tbLibRep.Controls.Add(Me.GroupBox4)
        Me.tbLibRep.Controls.Add(Me.ckbCobroDomicilio)
        Me.tbLibRep.Controls.Add(Me.grbRutaCobro)
        Me.tbLibRep.Location = New System.Drawing.Point(4, 22)
        Me.tbLibRep.Name = "tbLibRep"
        Me.tbLibRep.Size = New System.Drawing.Size(674, 510)
        Me.tbLibRep.TabIndex = 8
        Me.tbLibRep.Text = "Reposición de Libreta / Cobro a Domicilio"
        '
        'MetroButton9
        '
        Me.MetroButton9.Location = New System.Drawing.Point(515, 477)
        Me.MetroButton9.Name = "MetroButton9"
        Me.MetroButton9.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton9.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton9.TabIndex = 3
        Me.MetroButton9.Text = "Atrás"
        Me.MetroButton9.UseSelectable = True
        Me.MetroButton9.UseStyleColors = True
        '
        'btnSaveTb7
        '
        Me.btnSaveTb7.Location = New System.Drawing.Point(596, 477)
        Me.btnSaveTb7.Name = "btnSaveTb7"
        Me.btnSaveTb7.Size = New System.Drawing.Size(75, 28)
        Me.btnSaveTb7.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSaveTb7.TabIndex = 4
        Me.btnSaveTb7.Text = "Guardar"
        Me.btnSaveTb7.UseSelectable = True
        Me.btnSaveTb7.UseStyleColors = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.btDelR)
        Me.GroupBox4.Controls.Add(Me.btEditR)
        Me.GroupBox4.Controls.Add(Me.btNewR)
        Me.GroupBox4.Controls.Add(Me.fgR)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(644, 200)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reposición de Libreta"
        '
        'btDelR
        '
        Me.btDelR.Location = New System.Drawing.Point(186, 22)
        Me.btDelR.Name = "btDelR"
        Me.btDelR.Size = New System.Drawing.Size(75, 28)
        Me.btDelR.Style = MetroFramework.MetroColorStyle.Green
        Me.btDelR.TabIndex = 2
        Me.btDelR.Text = "Eliminar"
        Me.btDelR.UseSelectable = True
        Me.btDelR.UseStyleColors = True
        '
        'btEditR
        '
        Me.btEditR.Location = New System.Drawing.Point(105, 22)
        Me.btEditR.Name = "btEditR"
        Me.btEditR.Size = New System.Drawing.Size(75, 28)
        Me.btEditR.Style = MetroFramework.MetroColorStyle.Green
        Me.btEditR.TabIndex = 1
        Me.btEditR.Text = "Modificar"
        Me.btEditR.UseSelectable = True
        Me.btEditR.UseStyleColors = True
        '
        'btNewR
        '
        Me.btNewR.Location = New System.Drawing.Point(24, 22)
        Me.btNewR.Name = "btNewR"
        Me.btNewR.Size = New System.Drawing.Size(75, 28)
        Me.btNewR.Style = MetroFramework.MetroColorStyle.Green
        Me.btNewR.TabIndex = 0
        Me.btNewR.Text = "Nuevo"
        Me.btNewR.UseSelectable = True
        Me.btNewR.UseStyleColors = True
        '
        'fgR
        '
        Me.fgR.AllowEditing = False
        Me.fgR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgR.BackColor = System.Drawing.Color.White
        Me.fgR.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgR.ForeColor = System.Drawing.Color.Black
        Me.fgR.Location = New System.Drawing.Point(24, 56)
        Me.fgR.Name = "fgR"
        Me.fgR.Rows.Count = 1
        Me.fgR.Rows.DefaultSize = 19
        Me.fgR.Size = New System.Drawing.Size(614, 128)
        Me.fgR.StyleInfo = resources.GetString("fgR.StyleInfo")
        Me.fgR.TabIndex = 3
        '
        'ckbCobroDomicilio
        '
        Me.ckbCobroDomicilio.Location = New System.Drawing.Point(16, 216)
        Me.ckbCobroDomicilio.Name = "ckbCobroDomicilio"
        Me.ckbCobroDomicilio.Size = New System.Drawing.Size(152, 16)
        Me.ckbCobroDomicilio.TabIndex = 1
        Me.ckbCobroDomicilio.Text = "Cobro a Domicilio"
        '
        'grbRutaCobro
        '
        Me.grbRutaCobro.Controls.Add(Me.txtCodCobrador)
        Me.grbRutaCobro.Controls.Add(Me.txtCobrador)
        Me.grbRutaCobro.Controls.Add(Me.Label32)
        Me.grbRutaCobro.Controls.Add(Me.txtDia)
        Me.grbRutaCobro.Controls.Add(Me.txtDireccionCobro)
        Me.grbRutaCobro.Controls.Add(Me.Label51)
        Me.grbRutaCobro.Controls.Add(Me.Label50)
        Me.grbRutaCobro.Controls.Add(Me.Label49)
        Me.grbRutaCobro.Controls.Add(Me.dtpFechaCuota)
        Me.grbRutaCobro.Controls.Add(Me.txtCodDpto)
        Me.grbRutaCobro.Controls.Add(Me.txtDpto)
        Me.grbRutaCobro.Controls.Add(Me.Label47)
        Me.grbRutaCobro.Controls.Add(Me.txtCodMun)
        Me.grbRutaCobro.Controls.Add(Me.txtMunicipio)
        Me.grbRutaCobro.Controls.Add(Me.Label48)
        Me.grbRutaCobro.Enabled = False
        Me.grbRutaCobro.Location = New System.Drawing.Point(16, 240)
        Me.grbRutaCobro.Name = "grbRutaCobro"
        Me.grbRutaCobro.Size = New System.Drawing.Size(636, 208)
        Me.grbRutaCobro.TabIndex = 2
        Me.grbRutaCobro.TabStop = False
        Me.grbRutaCobro.Text = "Datos Ruta de Cobro:"
        '
        'txtCodCobrador
        '
        Me.txtCodCobrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCobrador.Location = New System.Drawing.Point(160, 176)
        Me.txtCodCobrador.MaxLength = 2
        Me.txtCodCobrador.Name = "txtCodCobrador"
        Me.txtCodCobrador.Size = New System.Drawing.Size(64, 20)
        Me.txtCodCobrador.TabIndex = 13
        '
        'txtCobrador
        '
        Me.txtCobrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCobrador.Location = New System.Drawing.Point(232, 176)
        Me.txtCobrador.MaxLength = 30
        Me.txtCobrador.Name = "txtCobrador"
        Me.txtCobrador.ReadOnly = True
        Me.txtCobrador.Size = New System.Drawing.Size(368, 20)
        Me.txtCobrador.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(8, 176)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 16)
        Me.Label32.TabIndex = 12
        Me.Label32.Text = "Cobrador:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(160, 144)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(48, 20)
        Me.txtDia.TabIndex = 9
        '
        'txtDireccionCobro
        '
        Me.txtDireccionCobro.Location = New System.Drawing.Point(160, 72)
        Me.txtDireccionCobro.Multiline = True
        Me.txtDireccionCobro.Name = "txtDireccionCobro"
        Me.txtDireccionCobro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccionCobro.Size = New System.Drawing.Size(440, 64)
        Me.txtDireccionCobro.TabIndex = 7
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(8, 75)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(112, 23)
        Me.Label51.TabIndex = 6
        Me.Label51.Text = "Dirección de Cobro:"
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(376, 144)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(112, 23)
        Me.Label50.TabIndex = 10
        Me.Label50.Text = "Fecha de Caducidad:"
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(8, 139)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(128, 23)
        Me.Label49.TabIndex = 8
        Me.Label49.Text = "Día:"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaCuota
        '
        Me.dtpFechaCuota.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCuota.Location = New System.Drawing.Point(488, 144)
        Me.dtpFechaCuota.Name = "dtpFechaCuota"
        Me.dtpFechaCuota.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaCuota.TabIndex = 11
        '
        'txtCodDpto
        '
        Me.txtCodDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDpto.Location = New System.Drawing.Point(160, 24)
        Me.txtCodDpto.MaxLength = 2
        Me.txtCodDpto.Name = "txtCodDpto"
        Me.txtCodDpto.Size = New System.Drawing.Size(64, 20)
        Me.txtCodDpto.TabIndex = 1
        '
        'txtDpto
        '
        Me.txtDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDpto.Location = New System.Drawing.Point(232, 24)
        Me.txtDpto.MaxLength = 30
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.ReadOnly = True
        Me.txtDpto.Size = New System.Drawing.Size(368, 20)
        Me.txtDpto.TabIndex = 2
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(8, 24)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(144, 16)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "*Departamento Residencia:"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodMun
        '
        Me.txtCodMun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMun.Location = New System.Drawing.Point(160, 48)
        Me.txtCodMun.MaxLength = 2
        Me.txtCodMun.Name = "txtCodMun"
        Me.txtCodMun.Size = New System.Drawing.Size(64, 20)
        Me.txtCodMun.TabIndex = 4
        '
        'txtMunicipio
        '
        Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMunicipio.Location = New System.Drawing.Point(232, 48)
        Me.txtMunicipio.MaxLength = 100
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.ReadOnly = True
        Me.txtMunicipio.Size = New System.Drawing.Size(368, 20)
        Me.txtMunicipio.TabIndex = 5
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(8, 48)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(144, 16)
        Me.Label48.TabIndex = 3
        Me.Label48.Text = "*Municipio Residencia:"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroButton5
        '
        Me.MetroButton5.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.MetroButton5.Location = New System.Drawing.Point(484, 473)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(95, 28)
        Me.MetroButton5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton5.TabIndex = 1024
        Me.MetroButton5.Text = "&Datos Asociado"
        Me.MetroButton5.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton5.UseSelectable = True
        Me.MetroButton5.UseStyleColors = True
        '
        'frmMsAhCuentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(723, 619)
        Me.Controls.Add(Me.tbSolic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhCuentas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Cuentas de Ahorro"
        Me.tbSolic.ResumeLayout(False)
        Me.tbDatGral.ResumeLayout(False)
        Me.tbDatGral.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nuDNoCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoApertura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDepositosAutomaticos.ResumeLayout(False)
        Me.gbDepositosAutomaticos.PerformLayout()
        CType(Me.c1nMontoTransf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatGralII.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCancela.ResumeLayout(False)
        Me.gbCancela.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbBeneficiarios.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.fgAut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.fgBen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbLibRep.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.fgR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbRutaCobro.ResumeLayout(False)
        Me.grbRutaCobro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, vTipo As String
    Private vAhorroJunior As Boolean, vAutorizaModificarPlan As Boolean

#Region "Propiedades"

    Public Property AhorroJunior() As Boolean
        Get
            Return vAhorroJunior
        End Get
        Set(ByVal Value As Boolean)
            vAhorroJunior = Value
        End Set
    End Property

#End Region
    Public Sub llenarEstadoCivil()
        Dim dts As New DataSet
        Me.cbEstadoCivil.DisplayMember = "Descripcion"
        Me.cbEstadoCivil.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoCivil,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoCivil.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    'Protected Sub validarContrato(ByVal codTipoAhorro As String)
    '    Dim dts As New DataSet
    '    dts = Ahorro.consultarAhContratos_Ahorro(codTipoAhorro)
    '    If dts.Tables.Count > 0 Then
    '        If dts.Tables(0).Rows.Count > 0 Then
    '            Me.btnContrato.Enabled = True
    '        Else
    '            Me.btnContrato.Enabled = False
    '        End If
    '    Else
    '        Me.btnContrato.Enabled = False
    '    End If
    'End Sub
    Protected Sub ActivarControlesTransferencia(ByVal bandera As Boolean)
        If bandera = True Then
            Me.txtCodPrestamo.Enabled = True
            Me.DataGridView1.Enabled = True
            Me.cbAsignarAhorro.Enabled = True
        Else
            ' Me.txtCodPrestamo.Enabled = False
            Me.DataGridView1.Enabled = False
            Me.cbAsignarAhorro.Enabled = False
        End If
    End Sub
    Private Sub frmMsAhCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            HeaderDg()
            ActivarControlesTransferencia(False)
            Dim oPerif As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, Filas As Data.DataRowCollection, dr As DataRow
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, x As Integer, FechaNac As Date, pEstado As String
            Dim oPl As New wrPlanilla.wsLibPlanilla
            Dim oPrest As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
            vAutorizaModificarPlan = False
            Me.txtDui.Focus()
            Me.cbTipoDeposito.SelectedIndex = 0
            Me.dtpFecIniDA.Value = Now
            Me.dtpFecFinDA.Value = Now
            Me.dtpFec1Cuota.Value = Now
            Me.dtpFechaApertura.Value = Now
            Me.dtpFecIniApertura.Value = Now
            Me.dtpFecVenc.Value = Now
            Me.dtpFecNacT2.Value = Now
            Me.cbDoc.SelectedIndex = 0
            Me.dtpFec1Cuota.Visible = False
            Me.c1nMonto.Visible = False
            Me.c1nCuota.Visible = False
            Me.Label17.Visible = False
            Me.Label21.Visible = False
            Me.Label19.Visible = False
            Me.nuDNoCuotas.Visible = False
            Me.Label22.Visible = False
            Me.c1nPlazo.Visible = False
            Me.Label18.Visible = False
            Me.btnConsPlanAh.Visible = False
            'Me.txtCodPrestamo.Visible = False
            'Me.lblCodPrestamo.Visible = False
            Me.lblEstado.Text = ""
            Dim dsTemp As New DataSet, drTemp As DataRow
            dsTemp = oAsoc.ConsultarParentescos("*", "", "CodParentesco", sUsuario, sPassword, sSucursal)



            cbParentesco.DisplayMember = "Descripcion"
            cbParentesco.ValueMember = "CodParentesco"
            cbParentesco.DataSource = dsTemp.Tables(0)
            cbPar.DisplayMember = "Descripcion"
            cbPar.ValueMember = "CodParentesco"
            cbPar.DataSource = dsTemp.Tables(0)


            Me.cbParentesco.SelectedIndex = 0
            Me.cbPar.SelectedIndex = 0
            llenarEstadoCivil()

            If Me.pAccion = "Modificar" Then

                ds = oPerif.ConsultarCuentaAhorro("*", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtDui.Value = IIf(IsDBNull(Filas.Item(0)("Dui")), "", Filas.Item(0)("Dui"))
                    Me.txtNoCuenta.Text = pNoCuenta
                    Me.txtCodPrestamo.Text = IIf(IsDBNull(Filas.Item(0)("CodPrestamo")), "", Filas.Item(0)("CodPrestamo"))
                    Me.dtpFechaApertura.Value = IIf(IsDBNull(Filas.Item(0)("FechaApertura")), Now, Filas.Item(0)("FechaApertura"))
                    Me.dtpFecIniApertura.Value = IIf(IsDBNull(Filas.Item(0)("FechaInicioApertura")), Now, Filas.Item(0)("FechaInicioApertura"))
                    Me.txtCodTipoAhorro.Text = pCodTipoAhorro
                    Me.txtCodAhorro.Text = pCodTipoAhorro
                    '==================================================
                    '==================================================
                    '//* Modificado 17-02-2012 
                    'VERIFICA SI EL TIPO DE CTA. PERMITE TRANSFERENCIAS.
                    bandera = Ahorro.ValidarCtas_TransferenciasAutomaticas(Me.txtCodTipoAhorro.Text.Trim)
                    ActivarControlesTransferencia(bandera)
                    'MUESTRA EL PRESTAMO ASIGNADO A LA CTA. DE AHORRO
                    Dim Transferencia As Boolean
                    Transferencia = IIf(IsDBNull(Filas.Item(0)("Transferencia")), False, Filas.Item(0)("Transferencia"))
                    If Transferencia = True Then
                        tbSolic.Controls.Add(New TabPage("tbTransPrestamo"))
                        Me.cbAsignarAhorro.Checked = True
                        If Me.txtCodPrestamo.Text.Length > 1 Then
                            LLENAR_DG(Me.txtCodPrestamo.Text)
                        End If
                    End If
                    '==================================================
                    '==================================================
                    Select Case Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1)
                        Case "3" 'Ahorro a la Vista
                            Me.vTipo = "Vista"
                        Case "5" 'Ahorro Restringido
                            Me.vTipo = "Rest"
                        Case "4" 'Ahorro Programado
                            Me.vTipo = "Prog"
                            btModificaPlanAh.Enabled = True
                    End Select
                    ActualizaControlesxTipo()
                    pEstado = IIf(IsDBNull(Filas.Item(0)("Estado")), "", Filas.Item(0)("Estado"))
                    If pEstado = "C" Then
                        Me.lblEstado.Text = "Cuenta Cancelada"
                        Me.btnSaveTb1.Enabled = False
                    End If

                    Me.cbTipoDeposito.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("TipoDeposito")), 0, Filas.Item(0)("TipoDeposito"))
                    Me.txtNoCuentaDepAut.Text = IIf(IsDBNull(Filas.Item(0)("NoCuentaDeposito")), "", Filas.Item(0)("NoCuentaDeposito"))
                    Me.txtCodTipoAhorroDepAut.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoAhorroDep")), "", Filas.Item(0)("CodTipoAhorroDep"))
                    Me.dtpFecIniDA.Value = IIf(IsDBNull(Filas.Item(0)("FecIniDep")), Now, Filas.Item(0)("FecIniDep"))
                    Me.dtpFecFinDA.Value = IIf(IsDBNull(Filas.Item(0)("FecFinDep")), Now, Filas.Item(0)("FecFinDep"))
                    Me.c1nMontoTransf.Value = IIf(IsDBNull(Filas.Item(0)("Cuota")), 0, Filas.Item(0)("Cuota"))
                    If Me.vTipo = "Prog" Then
                        Me.c1nMontoTransf.Enabled = False
                        Me.c1nMonto.Value = IIf(IsDBNull(Filas.Item(0)("Monto")), 0, Filas.Item(0)("Monto"))
                    Else
                        Me.c1nMonto.Value = IIf(IsDBNull(Filas.Item(0)("Saldo_CuentaAhorro")), 0, Filas.Item(0)("Saldo_CuentaAhorro"))
                    End If
                    Me.c1nMontoApertura.Value = IIf(IsDBNull(Filas.Item(0)("MontoApertura")), 0, Filas.Item(0)("MontoApertura"))
                    Me.c1nCuota.Value = IIf(IsDBNull(Filas.Item(0)("Cuota")), 0, Filas.Item(0)("Cuota"))
                    Me.c1nPlazo.Value = IIf(IsDBNull(Filas.Item(0)("Plazo")), 0, Filas.Item(0)("Plazo"))
                    Me.c1nPlazo.Enabled = False
                    Me.c1nTasa.Value = IIf(IsDBNull(Filas.Item(0)("TasaInteres")), 0, Filas.Item(0)("TasaInteres"))
                    Me.nuDNoCuotas.Value = IIf(IsDBNull(Filas.Item(0)("NoCuotas")), 0, Filas.Item(0)("NoCuotas"))
                    Me.dtpFecIniApertura.Value = IIf(IsDBNull(Filas.Item(0)("FechaInicioApertura")), Now, Filas.Item(0)("FechaInicioApertura"))
                    Me.dtpFec1Cuota.Value = IIf(IsDBNull(Filas.Item(0)("FechaPrimeraCuota")), Now, Filas.Item(0)("FechaPrimeraCuota"))
                    Me.txtCodDestino.Text = IIf(IsDBNull(Filas.Item(0)("CodDestino")), "", Filas.Item(0)("CodDestino"))
                    Me.cbDoc.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("TipoDocTit2")), 0, Filas.Item(0)("TipoDocTit2"))
                    Me.txtTitular2.Text = IIf(IsDBNull(Filas.Item(0)("Titular2")), "", Filas.Item(0)("Titular2"))
                    Me.txtTitular2.ReadOnly = True
                    Me.txtPartida.Text = IIf(IsDBNull(Filas.Item(0)("PartidaNacTitular2")), "", Filas.Item(0)("PartidaNacTitular2").trim)
                    Me.txtNoLibreta.Text = IIf(IsDBNull(Filas.Item(0)("NoLibreta")), "", Filas.Item(0)("NoLibreta"))
                    Me.txtCodEjecMercadeo.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecutivo")), "", Filas.Item(0)("CodEjecutivo"))
                    Me.dtpFecVenc.Value = IIf(IsDBNull(Filas.Item(0)("FechaVencimiento")), Now, Filas.Item(0)("FechaVencimiento"))
                    Me.txtMotivoCancela.Text = IIf(IsDBNull(Filas.Item(0)("MotivoCancelacion")), "", Filas.Item(0)("MotivoCancelacion"))
                    Me.dtpFecCanc.Value = IIf(IsDBNull(Filas.Item(0)("FechaCancelacion")), Now, Filas.Item(0)("FechaCancelacion"))
                    Me.txtCodEjecCanc.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecCanc")), "", Filas.Item(0)("CodEjecCanc"))
                    Me.txtCodEjecApertura.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecApertura")), "", Filas.Item(0)("CodEjecApertura"))
                    Me.txtObs.Text = IIf(IsDBNull(Filas.Item(0)("Observacion")), "", Filas.Item(0)("Observacion"))
                    Me.dtpFecNacT2.Value = IIf(IsDBNull(Filas.Item(0)("FechaNacTit2")), Now, Filas.Item(0)("FechaNacTit2"))

                    If DateTime.IsLeapYear(Me.dtpFecNacT2.Value.Year) = True And Me.dtpFecNacT2.Value.Day = 29 And Me.dtpFecNacT2.Value.Month = 2 Then
                        FechaNac = "28/" & dtpFecNacT2.Value.Month & "/" & Now().Year
                    Else
                        FechaNac = dtpFecNacT2.Value.Day & "/" & dtpFecNacT2.Value.Month & "/" & Now().Year
                    End If
                    Me.txtEdadT2.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNacT2.Value, Now())
                    Me.dtpFechaApertura.Enabled = False


                    If Filas.Item(0)("CodParentesco") Is DBNull.Value = False Then
                        Me.cbParentesco.SelectedValue = Filas.Item(0)("CodParentesco")
                    End If


                    Me.txtTel.Text = IIf(IsDBNull(Filas.Item(0)("TelTit2")), "", Filas.Item(0)("TelTit2"))
                    Me.txtCelT2.Text = IIf(IsDBNull(Filas.Item(0)("CelTit2")), "", Filas.Item(0)("CelTit2"))



                    If btnSaveTb1.Text = "&Cancelar Cta." Then
                        Me.tbLibRep.Enabled = False
                        Me.tbBeneficiarios.Enabled = False
                        tbSolic.SelectedIndex = 1
                        txtMotivoCancela.Focus()
                    End If

                    ds = oPerif.ConsultarTipoAhorro("*", "CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtTipoAhorro.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                        Me.txtAhorro.Text = Me.txtTipoAhorro.Text.Trim
                        AhorroJunior = IIf(IIf(IsDBNull(Filas.Item(0)("Junior")), "0", Filas.Item(0)("Junior")) = "1", True, False)
                    End If

                    ds = oPerif.ConsultarDestino("*", "CodDestino='" & Trim(Me.txtCodDestino.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtDestino.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    End If

                    ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecMercadeo.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                            Me.txtEjecMercadeo.Text = CStr(Filas.Item(0)("CodEmpleado"))
                            ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeo.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                            Filas = ds.Tables(0).Rows()
                            If Filas.Count > 0 Then
                                Me.txtEjecMercadeo.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                            End If
                        End If
                    End If

                    ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecApertura.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                            Me.txtEjecApertura.Text = CStr(Filas.Item(0)("CodEmpleado"))
                            ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecApertura.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                            Filas = ds.Tables(0).Rows()
                            If Filas.Count > 0 Then
                                Me.txtEjecApertura.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                            End If
                        End If
                    End If

                    ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecCanc.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                            Me.txtEjecMercadeoCanc.Text = CStr(Filas.Item(0)("CodEmpleado"))
                            ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeoCanc.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                            Filas = ds.Tables(0).Rows()
                            If Filas.Count > 0 Then
                                Me.txtEjecMercadeoCanc.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                            End If
                        End If
                    End If

                    ds = oPerif.ConsultarBeneficiarios("*", "NoCuenta=" & Trim(txtNoCuenta.Text) & " and CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgBen.DataSource = ds.Tables(0)
                    ActualizaGridBen()

                    ds = oPerif.ConsultarAutorizadoRetiro("*", "NoCuenta=" & Trim(txtNoCuenta.Text) & " and CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgAut.DataSource = ds.Tables(0)
                    ActualizaGridAut()

                    ds = oPerif.ConsultarReposicionLibreta("*", "NoCuenta=" & Trim(txtNoCuenta.Text) & " and CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "NoSolicitud", sUsuario, sPassword, sSucursal)
                    Me.fgR.DataSource = ds.Tables(0)
                    ActualizaGridR()

                    Dim pCodProf As String
                    ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,telCasa,celular,nosocio", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then

                        'txtDui.Text = IIf(CStr(Filas.Item(0)("DUI")).Trim Is DBNull.Value, "", Filas.Item(0)("DUI").ToString.Trim)
                        txtNombres.Text = IIf((Filas.Item(0)("Nombres")) Is DBNull.Value, "", CStr(Filas.Item(0)("Nombres")))
                        txtApe1.Text = IIf((Filas.Item(0)("Apellido1")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido1")).Trim)
                        txtApe2.Text = IIf((Filas.Item(0)("Apellido2")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido2")))
                        txtApe3.Text = IIf((Filas.Item(0)("ApellidoCas")) Is DBNull.Value, "", Filas.Item(0)("ApellidoCas"))
                        direccionAsociado(txtDui.Value)
                        'txtDireccion.Text = IIf(CStr(Filas.Item(0)("Direccion")).Trim Is DBNull.Value, "", Filas.Item(0)("Direccion"))
                        If Filas.Item(0)("codEstadoCivil") Is DBNull.Value = False Then
                            cbEstadoCivil.SelectedValue = Filas.Item(0)("codEstadoCivil") ' IIf(CStr(Filas.Item(0)("codEstadoCivil")) Is DBNull.Value, "", Filas.Item(0)("codEstadoCivil"))
                        End If


                        txtLugDui.Text = IIf((Filas.Item(0)("LugarExtDUI")) Is DBNull.Value, " ", Filas.Item(0)("LugarExtDUI"))
                        dtpFecExtDui.Value = IIf((Filas.Item(0)("FechaExtDUI")) Is DBNull.Value, Now, Filas.Item(0)("FechaExtDUI"))
                        dtpFecNac.Value = IIf((Filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, Filas.Item(0)("Fecha_Nac"))
                        txtTelCasa.Text = IIf((Filas.Item(0)("TelCasa")) Is DBNull.Value, " ", Filas.Item(0)("TelCasa"))
                        'txtTelOfic.Text = IIf(CStr(Filas.Item(0)("TelOficina")).Trim Is DBNull.Value, "", Filas.Item(0)("TelOficina"))
                        txtCel.Text = IIf((Filas.Item(0)("Celular")) Is DBNull.Value, " ", Filas.Item(0)("Celular"))

                        If Filas.Item(0)("CodProfesion") Is DBNull.Value = False Then
                            Dim dtsProfesiones As New DataSet
                            dtsProfesiones = asociados.ConsultarProfesiones("codProfesion,descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
                            txtProf.Text = dtsProfesiones.Tables(0).Rows(0).Item("descripcion").ToString.ToUpper.Trim
                        End If


                        Me.txtNoSocio.Text = IIf((Filas.Item(0)("NoSocio")) Is DBNull.Value, " ", Filas.Item(0)("NoSocio"))


                        If DateTime.IsLeapYear(Me.dtpFecNac.Value.Year) = True And Me.dtpFecNac.Value.Day = 29 And Me.dtpFecNac.Value.Month = 2 Then
                            FechaNac = "28/" & dtpFecNac.Value.Month & "/" & Now().Year
                        Else
                            FechaNac = dtpFecNac.Value.Day & "/" & dtpFecNac.Value.Month & "/" & Now().Year
                        End If
                        Me.txtEdad.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNac.Value, Now())
                    End If

                    'Código agregado para cargar los datos de ruta de cobro segun NoCuenta y CodTipoAhorro
                    Dim dsRutasCobro As Data.DataSet, drRutasCobro As DataRow, dsGen As DataSet, drGen As DataRow, dsGenI As DataSet, drGenI As DataRow
                    dsRutasCobro = oPerif.ConsultarRutasCobro("*", "CodTipoAhorro='" & pCodTipoAhorro & "' and NoCuenta='" & pNoCuenta & "'", "CodRutaCobro", sUsuario, sPassword, sSucursal)
                    If dsRutasCobro.Tables("AhRutasCobro").Rows.Count > 0 Then
                        Me.ckbCobroDomicilio.Checked = True
                        ckbCobroDomicilio_Click(sender, e)
                        drRutasCobro = dsRutasCobro.Tables("AhRutasCobro").Rows(0)
                        Me.txtCodDpto.Text = drRutasCobro("CodDepartamento")
                        Me.txtCodMun.Text = drRutasCobro("CodMunicipio")
                        Me.txtDireccionCobro.Text = drRutasCobro("DireccionCobro")
                        Me.txtDia.Text = drRutasCobro("Dia")
                        Me.dtpFechaCuota.Value = drRutasCobro("FechaCaducidad")
                        Me.txtCodCobrador.Text = IIf(IsDBNull(drRutasCobro("CodCobrador")), "", drRutasCobro("CodCobrador"))
                        If Me.txtCodCobrador.Text.Trim <> "" Then
                            ds = oAsoc.ConsultarCobradoresxNombre(Me.txtCodCobrador.Text.Trim, sUsuario, sPassword, sSucursal)
                            Filas = ds.Tables(0).Rows()
                            If Filas.Count > 0 Then
                                Me.txtCobrador.Text = CStr(Filas.Item(0)("Nombres")).Trim
                            End If
                        End If
                        dsGen = oAsoc.ConsultarMunicipios("*", "CodDepartamento='" & Me.txtCodDpto.Text.Trim & "' and CodMunicipio='" & Me.txtCodMun.Text.Trim & "'", "CodDepartamento,CodMunicipio", sUsuario, sPassword, sSucursal)
                        If dsGen.Tables(0).Rows.Count > 0 Then
                            drGen = dsGen.Tables(0).Rows(0)
                            Me.txtMunicipio.Text = drGen("Municipio")
                        End If
                        dsGenI = oAsoc.ConsultarDepartamentos("*", "CodDepartamento='" & Me.txtCodDpto.Text.Trim & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
                        If dsGenI.Tables(0).Rows.Count > 0 Then
                            drGenI = dsGenI.Tables(0).Rows(0)
                            Me.txtDpto.Text = drGenI("Departamento")
                        End If
                    End If

                    If pEstado = "A" Then
                        Me.c1nMontoApertura.Enabled = False
                        Me.c1nPlazo.Enabled = False
                        Me.c1nCuota.Enabled = False
                    End If
                    Me.btnSaveTb7.Enabled = True

                End If
                Me.dtpFechaApertura.Enabled = False
                Me.txtDui.Enabled = False
                Me.txtNombres.Enabled = False
                Me.txtApe1.Enabled = False
                Me.txtApe2.Enabled = False
                Me.txtCodTipoAhorro.Enabled = False
                Me.txtNoLibreta.Enabled = False
                Me.txtNoCuenta.Enabled = False
                If btnSaveTb1.Visible = True Then Me.btNewBen.Enabled = True
                Me.btNew.Enabled = True
                Me.btNewR.Enabled = True
                Me.dtpFechaApertura.Focus()

                'validarContrato(txtCodTipoAhorro.Text.Trim)
                'Código Agregado para cargar el dato de la fecha de vencimiento de del pago en el control dtpFechaCuota
                Dim dsFecCuota As New Data.DataSet
                dsFecCuota = oPerif.ConsultarFechaCuotaPlanAhorro(pCodTipoAhorro, pNoCuenta, sUsuario, sPassword, sSucursal)
                If dsFecCuota.Tables(0).Rows.Count > 0 Then
                    dr = dsFecCuota.Tables(0).Rows(0)
                    Me.dtpFechaCuota.Value = dr("FechaCuota")
                End If
                '=========================================================================
                '18/04/2012 Javier Escobar
                'Deshabilitamos el control para que no puedan modificar al ejecutivo
                Me.txtCodEjecMercadeo.ReadOnly = True
                Me.txtCodEjecMercadeo.Enabled = False
                Me.txtCodEjecApertura.ReadOnly = True
                Me.txtCodEjecApertura.Enabled = False
                Me.txtEjecApertura.Enabled = False
                Me.txtEjecMercadeo.Enabled = False
                '=========================================================================
            Else
                Me.btNewBen.Enabled = False
                Me.btNew.Enabled = False
                Me.btNewR.Enabled = False
                Me.tbLibRep.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub txtCodEjecMercadeo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecMercadeo.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Try
                Dim oPl As New wrPlanilla.wsLibPlanilla
                Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection

                ds = oPerif.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecMercadeo.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtEjecMercadeo.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeo.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtEjecMercadeo.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                        Me.txtObs.Focus()
                    End If
                Else
                    txtCodEjecMercadeo_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtCodEjecMercadeo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecMercadeo.DoubleClick

        Try
            Dim ofrm As New frmAGenerico, ds As New Data.DataSet
            ofrm.Text = "Buscar Ejecutivos de Mercadeo"
            Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecMercadeo.Text = ofrm.Resultado.Trim
            txtEjecMercadeo.Text = ofrm.Resultado2.Trim
            Me.txtObs.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ActualizaGridBen()

        Dim oAh As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarBeneficiarios("*", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgBen.DataSource = ds.Tables(0)
            Me.fgBen.Cols.Item(0).Caption = "Correlativo"
            Me.fgBen.Cols.Item(1).Caption = "Dui"
            Me.fgBen.Cols.Item(2).Caption = "Partida Nac."
            Me.fgBen.Cols.Item(3).Caption = "Tipo Ahorro"
            Me.fgBen.Cols.Item(4).Caption = "No. Cuenta"
            Me.fgBen.Cols.Item(5).Caption = "Apellido1"
            Me.fgBen.Cols.Item(6).Caption = "Apellido2"
            Me.fgBen.Cols.Item(7).Caption = "Ape_Casada"
            Me.fgBen.Cols.Item(8).Caption = "Nombres"
            Me.fgBen.Cols.Item(9).Caption = "Parentesco"
            Me.fgBen.Cols.Item(10).Caption = "Porcentaje"
            Me.fgBen.Cols.Item(11).Caption = "Direccion"
            Me.fgBen.Cols.Item(12).Caption = "Tel. Casa"
            Me.fgBen.Cols.Item(13).Caption = "Tel. Oficina"
            Me.fgBen.Cols.Item(14).Caption = "Email"
            Me.fgBen.Cols.Item(15).Caption = "Tipo"

            Me.fgBen.Cols.Item(0).Width = 77
            Me.fgBen.Cols.Item(1).Width = 77
            Me.fgBen.Cols.Item(2).Width = 150
            Me.fgBen.Cols.Item(3).Width = 77
            Me.fgBen.Cols.Item(4).Width = 77
            Me.fgBen.Cols.Item(5).Width = 77
            Me.fgBen.Cols.Item(6).Width = 77
            Me.fgBen.Cols.Item(7).Width = 77
            Me.fgBen.Cols.Item(8).Width = 77
            Me.fgBen.Cols.Item(9).Width = 77
            Me.fgBen.Cols.Item(10).Width = 77
            Me.fgBen.Cols.Item(11).Width = 77
            Me.fgBen.Cols.Item(12).Width = 77
            Me.fgBen.Cols.Item(13).Width = 77
            Me.fgBen.Cols.Item(14).Width = 77
            Me.fgBen.Cols.Item(15).Width = 77

            If Me.fgBen.Row <> -1 Then
                Me.btEditBen.Enabled = True
                If btnSaveTb1.Visible = True Then Me.btDelBen.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnSaveTb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTb1.Click
        Try
            Dim oCred As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, pCampos As String, pValores As String
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection, pPignorado As String, dr As DataRow, CobroDomicilio As String

            Select Case oCred.AutorizaDatos(txtDui.Text, "x", txtNoCuenta.Text, Me.txtNoLibreta.Text, txtCodTipoAhorro.Text)
                Case 1
                    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                Case 3
                    MsgBox("El campo No. Cuenta no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                'Case 4
                'If vTipo <> "DPF" Then
                'MsgBox("El campo No. Libreta no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                'Me.txtNoLibreta.Focus()
                'Exit Sub
                'End If
                Case 5
                    MsgBox("El campo Tipo de Ahorro no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
            End Select

            If Me.c1nMontoApertura.Value <= 0 Then
                MsgBox("El Monto de Apertura no puede tener un valor de cero o negativo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                Exit Sub
            End If

            If Me.c1nTasa.Value <= 0 Then
                MsgBox("La Tasa de Interés no puede tener un valor de cero o negativo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                Exit Sub
            End If

            If Me.c1nPlazo.Value < 0 Then
                MsgBox("El plazo no puede tener un valor negativo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                Exit Sub
            End If

            If AhorroJunior = True Then
                If Me.txtTitular2.Text.Trim = "" Then
                    MsgBox("Debe ingresar el Titular 2.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                End If

                Dim FechaNacTit2 As Date, pEdad As Integer
                FechaNacTit2 = dtpFecNacT2.Value.Day & "/" & dtpFecNacT2.Value.Month & "/" & Now().Year

                pEdad = CInt(IIf(DateDiff(DateInterval.Day, FechaNacTit2, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNacT2.Value, Now()))
                If pEdad >= 18 Then
                    MsgBox("El niño tiene más de 18 años.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                End If

            End If

            'If Me.vTipo = "Rest" Then
            '    If Me.txtCodPrestamo.Text.Trim = "" Then
            '        MessageBox.Show("Debe seleccionar el préstamo.", "Ahorro Restringido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        Exit Sub
            '    End If
            'End If

            ds = oCred.ConsultarParametros("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables("AhParametros").Rows
            If Filas.Count > 0 Then
                dr = ds.Tables("AhParametros").Rows(0)
                If Val(c1nMontoApertura.Value) < Val(dr("MontoAperturaMinima")) And (CDate(Me.dtpFechaApertura.Value.ToShortDateString) >= dr("ValidoDesdeMin") And CDate(Me.dtpFechaApertura.Value.ToShortDateString) <= dr("ValidoHastaMin")) Then
                    MsgBox("El Monto de Apertura no puede ser menor que el Monto de Apertura Mínima.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                End If
                If Val(c1nMontoApertura.Value) > Val(dr("MontoAperturaMaxima")) And (CDate(Me.dtpFechaApertura.Value.ToShortDateString) >= dr("ValidoDesdeMax") And CDate(Me.dtpFechaApertura.Value.ToShortDateString) <= dr("ValidoHastaMax")) Then
                    MsgBox("El Monto de Apertura no puede ser mayor que el Monto de Apertura Máximo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                End If
                If Val(Me.c1nPlazo.Value) > Val(dr("PlazoMaximo")) Then
                    MsgBox("El Plazo no puede ser mayor que el Plazo Máximo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                End If
                If Val(Me.c1nPlazo.Value) < Val(dr("PlazoMinimo")) Then
                    MsgBox("El Plazo no puede ser menor que el Plazo Mínimo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                End If
            End If

            ds = oAsoc.ConsultarAsociado("*", "Dui='" & Trim(Me.txtDui.Text) & "' and EstadoAsociado='25' and EstadoIngreso in ('2','1') ", "DUI", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
            Else
                MsgBox("El Dui del Asociado no coincide con el Maestro de Asociados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                Exit Sub
            End If

            If Me.ckbCobroDomicilio.Checked = True Then
                CobroDomicilio = "S"
            Else
                CobroDomicilio = "N"
            End If
            If Me.btnSaveTb1.Text = "&Guardar" Then
                If bandera = True And Me.cbAsignarAhorro.Checked = True And Me.txtCodPrestamo.Text.Length > 1 Then 'evalua que se este asignando un prestamo a la cta. de ahorro.
                    Dim Transferencia As Int16
                    Transferencia = 1
                    pPignorado = "N"
                    pCampos = "Dui,CodTipoAhorro,NoCuenta,Titular2,PartidaNacTitular2," &
                    "NoLibreta,FechaInicioApertura,FechaApertura,FechaVencimiento,FechaPrimeraCuota," &
                    "MontoApertura,Plazo,Monto,Cuota,NoCuotas,CodDestino,TasaInteres,CodEjecutivo,Saldo_CuentaAhorro, " &
                    "SaldoDisponible_CuentaAhorro,NoCuotasPagadas,SaldoInteresPendiente,Estado,Observacion,Pignorado," &
                    "CobroDomicilio,TipoDocTit2,FechaNacTit2,CodParentesco,TelTit2,NoSocio,Digito,CodEjecApertura," &
                    "TipoDeposito,NoCuentaDeposito,CodTipoAhorroDep,FecIniDep,FecFinDep,Codprestamo,Transferencia"
                    pValores = "'" & Trim(Me.txtDui.Text) & "','" & Trim(Me.txtCodTipoAhorro.Text) & "','" & Trim(Me.txtNoCuenta.Text) & "','" & Trim(Me.txtTitular2.Text) & "','" & Trim(Me.txtPartida.Text) &
                    "','" & Trim(Me.txtNoLibreta.Text) & "','" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFechaApertura.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFec1Cuota.Value, "dd/MM/yyyy") &
                    "'," & Val(Me.c1nMontoApertura.Value) & "," & Val(Me.c1nPlazo.Value) & "," & Val(Me.c1nMonto.Value) & "," & Val(Me.c1nCuota.Value) & "," & Val(Me.nuDNoCuotas.Value) & ",'" & Trim(Me.txtCodDestino.Text) & "'," & Val(Me.c1nTasa.Value) & ",'" & Trim(Me.txtCodEjecMercadeo.Text) & "',0,0,0,0,'D','" &
                    Trim(Me.txtObs.Text) & "','" & pPignorado & "','" & CobroDomicilio & "','" & Me.cbDoc.SelectedIndex & "','" & Format(Me.dtpFecNacT2.Value, "dd/MM/yyyy") & "','" & Me.cbParentesco.SelectedValue & "','" & Me.txtTel.Text.Trim & "','" & Me.txtNoSocio.Text.Trim &
                    "','" & Me.txtDigito.Text.Trim & "','" & Me.txtCodEjecApertura.Text.Trim & "','" & Me.cbTipoDeposito.SelectedIndex & "','" & Me.txtNoCuentaDepAut.Text.Trim & "','" & Me.txtCodTipoAhorroDepAut.Text.Trim &
                    "','" & Format(Me.dtpFecIniDA.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecFinDA.Value, "dd/MM/yyyy") & "','" & Me.txtCodPrestamo.Text.Trim & "','" & Transferencia & "'"
                Else
                    pPignorado = "N"
                    pCampos = "Dui,CodTipoAhorro,NoCuenta,CodPrestamo,Titular2,PartidaNacTitular2,NoLibreta,FechaInicioApertura,FechaApertura,FechaVencimiento,FechaPrimeraCuota,MontoApertura,Plazo,Monto,Cuota,NoCuotas,CodDestino,TasaInteres,CodEjecutivo,Saldo_CuentaAhorro,SaldoDisponible_CuentaAhorro,NoCuotasPagadas,SaldoInteresPendiente,Estado,Observacion,Pignorado,CobroDomicilio,TipoDocTit2,FechaNacTit2,CodParentesco,TelTit2,NoSocio,Digito,CodEjecApertura,TipoDeposito,NoCuentaDeposito,CodTipoAhorroDep,FecIniDep,FecFinDep"
                    pValores = "'" & Trim(Me.txtDui.Text) &
                        "','" & Trim(Me.txtCodTipoAhorro.Text) &
                        "','" & Trim(Me.txtNoCuenta.Text) &
                        "','" & Trim(Me.txtCodPrestamo.Text) &
                        "','" & Trim(Me.txtTitular2.Text) &
                        "','" & Trim(Me.txtPartida.Text) &
                        "','" & Trim(Me.txtNoLibreta.Text) &
                        "','" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") &
                        "','" & Format(Me.dtpFechaApertura.Value, "dd/MM/yyyy") &
                        "','" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") &
                        "','" & Format(Me.dtpFec1Cuota.Value, "dd/MM/yyyy") &
                        "'," & (Me.c1nMontoApertura.Value) &
                        "," & (Me.c1nPlazo.Value) &
                        "," & (Me.c1nMonto.Value) &
                        "," & (Me.c1nCuota.Value) &
                        "," & (Me.nuDNoCuotas.Value) &
                        ",'" & Trim(Me.txtCodDestino.Text) &
                        "'," & Me.c1nTasa.Value &
                        ",'" & Trim(Me.txtCodEjecMercadeo.Text) &
                        "',0,0,0,0,'D','" &
                        Trim(Me.txtObs.Text) &
                        "','" & pPignorado &
                        "','" & CobroDomicilio &
                        "','" & Me.cbDoc.SelectedIndex &
                        "','" & Format(Me.dtpFecNacT2.Value, "dd/MM/yyyy") &
                        "','" & Me.cbParentesco.SelectedValue & 'Text.Substring(0, 5).Trim &
                        "','" & Me.txtTel.Text.Trim &
                        "','" & Me.txtNoSocio.Text.Trim &
                        "','" & Me.txtDigito.Text.Trim &
                        "','" & Me.txtCodEjecApertura.Text.Trim &
                        "','" & Me.cbTipoDeposito.SelectedIndex &
                        "','" & Me.txtNoCuentaDepAut.Text.Trim &
                        "','" & Me.txtCodTipoAhorroDepAut.Text.Trim &
                        "','" & Format(Me.dtpFecIniDA.Value, "dd/MM/yyyy") &
                        "','" & Format(Me.dtpFecFinDA.Value, "dd/MM/yyyy") & "'"
                End If

                If oCred.InsertarCuentaAhorro(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    If vTipo = "Prog" Then GuardarPlanAhorro()
                    Me.txtDui.Enabled = False
                    Me.txtNombres.Enabled = False
                    Me.txtApe1.Enabled = False
                    Me.txtApe2.Enabled = False
                    Me.txtCodTipoAhorro.Enabled = False
                    Me.txtNoCuenta.Enabled = False
                    Me.btNewBen.Enabled = True
                    Me.btNew.Enabled = True
                    btnSaveTb1.Text = "&Modificar"
                    btnSaveTb3.Text = "&Modificar"
                    Me.pCodTipoAhorro = Trim(Me.txtCodTipoAhorro.Text)
                    Me.pNoCuenta = Trim(Me.txtNoCuenta.Text)
                    Me.btnConsPlanAh.Enabled = True
                    Me.tbLibRep.Enabled = True
                    Me.GroupBox4.Enabled = False
                    Me.grbRutaCobro.Enabled = False
                    Me.ckbCobroDomicilio.Enabled = True
                    MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information)
                End If
            ElseIf Me.btnSaveTb1.Text = "&Modificar" Then
                pCampos = "Titular2='" & Trim(Me.txtTitular2.Text) & "',PartidaNacTitular2='" & Trim(Me.txtPartida.Text) &
                "',NoLibreta='" & Trim(Me.txtNoLibreta.Text) & "',FechaInicioApertura='" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") &
                "',FechaApertura='" & Format(Me.dtpFechaApertura.Value, "dd/MM/yyyy") & "',FechaVencimiento='" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") &
                "',FechaPrimeraCuota='" & Format(Me.dtpFec1Cuota.Value, "dd/MM/yyyy") & "',MontoApertura=" & Val(Me.c1nMontoApertura.Value) &
                ",Plazo=" & Val(Me.c1nPlazo.Value) & ",Monto=" & Val(Me.c1nMonto.Value) & ",Cuota=" & Val(Me.c1nCuota.Value) &
                ",NoCuotas=" & Val(Me.nuDNoCuotas.Value) & ",CodDestino='" & Trim(Me.txtCodDestino.Text) & "',TasaInteres=" & Val(Me.c1nTasa.Value) &
                ",CodEjecutivo='" & Trim(Me.txtCodEjecMercadeo.Text) & "',Observacion='" & Trim(Me.txtObs.Text) & "',CobroDomicilio= '" & CobroDomicilio &
                "',TipoDocTit2='" & Me.cbDoc.SelectedIndex & "',FechaNacTit2='" & Format(Me.dtpFecNacT2.Value, "dd/MM/yyyy") &
                "',CodParentesco='" & Me.cbParentesco.SelectedValue & "',TelTit2='" & Me.txtTel.Text.Trim &
                "',CodEjecApertura='" & Me.txtCodEjecApertura.Text.Trim & "',TipoDeposito='" & Me.cbTipoDeposito.SelectedIndex &
                "',NoCuentaDeposito='" & Me.txtNoCuentaDepAut.Text.Trim & "',CodTipoAhorroDep='" & Me.txtCodTipoAhorroDepAut.Text.Trim &
                "',FecIniDep='" & Format(Me.dtpFecIniDA.Value, "dd/MM/yyyy") & "',FecFinDep='" & Format(Me.dtpFecFinDA.Value, "dd/MM/yyyy") & "', codprestamo = '" & txtCodPrestamo.Text.Trim & "' "
                If oCred.ModificarCuentaAhorro(pNoCuenta, pCodTipoAhorro, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    If vAutorizaModificarPlan = True Then ModificaPlanAhorro()
                    Me.c1nTasa.ReadOnly = True
                    Me.Dispose()
                Else
                    MsgBox("Los datos de la Cuenta de Ahorros no han sido modificados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            ElseIf Me.btnSaveTb1.Text = "&Cancelar Cta." Then
                Dim val As String
                val = oCred.CancelarCuentaAhorro(pNoCuenta, pCodTipoAhorro, Me.txtMotivoCancela.Text.Trim, Me.txtCodEjecCanc.Text.Trim, 0, 0, Me.dtpFecCanc.Value, sUsuario, sPassword, sSucursal)
                If val = "" Then
                    Me.Dispose()
                Else
                    MessageBox.Show(val, "Cancelación DPF", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'Private Sub fgBen_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgBen.DoubleClick
    '    btEditBen_Click(sender, e)
    'End Sub

    Private Sub txtCodDestino_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodDestino.KeyPress

        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, Filas As Data.DataRowCollection
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtCodDestino.Text.Trim = "" Then
                    txtCodDestino_DoubleClick(sender, e)
                Else
                    ds = oAhorro.ConsultarDestino("*", "CodDestino='" & txtCodDestino.Text.Trim & "'", "CodDestino", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtCodDestino.Text = CStr(Filas.Item(0)("CodDestino")).Trim
                        txtDestino.Text = CStr(Filas.Item(0)("Descripcion")).Trim
                        Me.txtNoLibreta.Focus()
                    Else
                        txtCodDestino_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodDestino_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDestino.DoubleClick

        Dim ofrm As New frmAGenerico

        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
            ds = oAhorro.ConsultarDestino("*", "", "CodDestino", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Buscar Destinos"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodDestino.Text = ofrm.Resultado.Trim
            txtDestino.Text = ofrm.Resultado2.Trim
            Me.txtNoLibreta.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ActualizaControlesxTipo()
        Select Case vTipo
            Case "Vista", "Rest"
                Me.Label17.Visible = False
                Me.dtpFec1Cuota.Visible = False
                Me.dtpFecIniApertura.Visible = False
                Me.c1nPlazo.Enabled = False
                Me.c1nMonto.Enabled = False
                Me.txtNoLibreta.Enabled = True
                Me.lblFecIniApertura.Visible = False
                Me.btnConsPlanAh.Enabled = False
                If vTipo = "Vista" Then
                    Me.gbDepositosAutomaticos.Visible = True
                    'Me.gbDepositosAutomaticos.Size = New Size(736, 53)
                    'Me.gbDepositosAutomaticos.Location = New Point(8, 440)
                ElseIf vTipo = "Rest" Then
                    Me.gbDepositosAutomaticos.Visible = False
                End If
            Case "Prog"

                Label4.Visible = True
                dtpFecVenc.Visible = True
                Label18.Visible = True
                c1nPlazo.Visible = True
                Label22.Visible = True
                nuDNoCuotas.Visible = True
                Label21.Visible = True
                c1nCuota.Visible = True
                Label19.Visible = True
                c1nMonto.Visible = True
                Label17.Visible = True
                dtpFec1Cuota.Visible = True
                btnConsPlanAh.Visible = True
                btModificaPlanAh.Visible = True

                Label4.Enabled = True
                dtpFecVenc.Enabled = True
                Label18.Enabled = True
                c1nPlazo.Enabled = True
                Label22.Enabled = True
                nuDNoCuotas.Enabled = True
                Label21.Enabled = True
                c1nCuota.Enabled = True
                Label19.Enabled = True
                c1nMonto.Enabled = True
                Label17.Enabled = True
                dtpFec1Cuota.Enabled = True
                btnConsPlanAh.Enabled = True
                'btModificaPlanAh.Enabled = True


                'Me.Label17.Visible = True
                'Me.dtpFec1Cuota.Visible = True
                'Me.dtpFec1Cuota.Enabled = True
                'Me.dtpFecIniApertura.Visible = False
                'Me.c1nPlazo.Enabled = True
                'Me.c1nPlazo.Visible = True
                'Me.c1nMonto.Enabled = True
                'Me.c1nMonto.Visible = True
                'Me.txtNoLibreta.Enabled = True
                'Me.lblFecIniApertura.Visible = False
                'Me.btnConsPlanAh.Enabled = True
                'Me.btnConsPlanAh.Visible = True
                'Me.gbDepositosAutomaticos.Visible = True
                'Me.dtpFec1Cuota.Visible = True
                'Me.c1nMonto.Visible = True
                'Me.c1nCuota.Visible = True
                'Me.Label17.Visible = True
                'Me.Label21.Visible = True
                'Me.Label19.Visible = True
                'Me.nuDNoCuotas.Visible = True
                'Me.Label22.Visible = True
                'Me.c1nPlazo.Visible = True
                'Me.Label18.Visible = True
                'Me.btnConsPlanAh.Visible = True
                'Me.gbDepositosAutomaticos.Size = New Size(590, 65) '(592, 53)
                'Me.gbDepositosAutomaticos.Location = New Point(8, 552) '(8, 440)
        End Select
    End Sub

    Private Sub dtpFechaApertura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaApertura.KeyDown
        If e.KeyValue = 13 Then
            Me.txtCodTipoAhorro.Focus()
            Me.dtpFec1Cuota.Value = Me.dtpFechaApertura.Value
        End If
    End Sub



    Private Sub ckbCobroDomicilio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ckbCobroDomicilio.Click
        If ckbCobroDomicilio.Checked = True Then
            grbRutaCobro.Enabled = True
            btnSaveTb7.Enabled = True
        Else
            grbRutaCobro.Enabled = False
            btnSaveTb7.Enabled = False
        End If
    End Sub

    Private Sub txtCodMun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodMun.KeyPress
        Dim oPerif As wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet
        Dim filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarMunicipios("*", "CodDepartamento='" & Trim(Me.txtCodDpto.Text) & "' and CodMunicipio='" & Trim(Me.txtCodMun.Text) & "'", "CodMunicipio", sUsuario, sPassword, sSucursal)
                filas = ds.Tables(0).Rows
                If Not (filas.Item(0)("Municipio") Is DBNull.Value) Then
                    txtMunicipio.Text = CStr(filas.Item(0)("Municipio"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodMun_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodMun.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim oPerif As wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet
        ofrm.Text = "Buscar Municipios"
        Try
            oPerif = New wrAsociados.wsLibAsoc
            If Trim(Me.txtCodDpto.Text) <> "" Then
                ds = oPerif.ConsultarMunicipios("*", "CodDepartamento='" & Trim(Me.txtCodDpto.Text) & "'", "CodMunicipio", sUsuario, sPassword, sSucursal)
            Else
                ds = oPerif.ConsultarMunicipios("*", "", "CodDepartamento,CodMunicipio", sUsuario, sPassword, sSucursal)
            End If
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodMun.Text = ofrm.Resultado2.Trim
            Me.txtMunicipio.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodDpto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodDpto.KeyPress
        Try
            Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
            Dim ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                ds = oPerif.ConsultarDepartamentos("*", "CodDepartamento='" & Me.txtCodDpto.Text.Trim & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Departamento") Is DBNull.Value) Then
                        txtDpto.Text = CStr(Filas.Item(0)("Departamento"))
                        Me.txtCodMun.Text = ""
                        Me.txtMunicipio.Text = ""
                        txtCodMun.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodDpto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDpto.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim oPerif As wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet
        ofrm.Text = "Buscar Departamento"
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodDpto.Text = ofrm.Resultado.Trim
            Me.txtDpto.Text = ofrm.Resultado2.Trim
            Me.txtCodMun.Text = ""
            Me.txtMunicipio.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtCodPrestamo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub



    Private Sub txtCodEjecCanc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecCanc.DoubleClick

        Dim ofrm As New frmAGenerico, ds As New Data.DataSet
        Try
            ofrm.Text = "Buscar Ejecutivos de Mercadeo"
            Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecCanc.Text = ofrm.Resultado.Trim
            txtEjecMercadeoCanc.Text = ofrm.Resultado2.Trim
            Me.txtObs.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodEjecCanc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecCanc.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Try
                Dim oPl As New wrPlanilla.wsLibPlanilla
                Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oPerif.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecCanc.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtEjecMercadeoCanc.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtCodEjecCanc.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtEjecMercadeoCanc.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                        Me.txtObs.Focus()
                    End If
                Else
                    txtCodEjecCanc_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub txtCodCobrador_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCobrador.DoubleClick
        Dim ofrm As New frmAGenerico, ds As New Data.DataSet
        Try
            ofrm.Text = "Buscar Cobradores"
            Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarCobradoresxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodCobrador.Text = ofrm.Resultado.Trim
            txtCobrador.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub c1nPlazo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nPlazo.LostFocus
        Me.dtpFecVenc.Value = Me.dtpFechaApertura.Value.AddDays((Me.c1nPlazo.Value * 30) - 1)
        Me.nuDNoCuotas.Value = Me.c1nPlazo.Value
    End Sub




    Private Sub ActualizaGridAut()

        Dim oAh As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarAutorizadoRetiro("*", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgAut.DataSource = ds.Tables(0)
            Me.fgAut.Cols.Item(0).Caption = "Correlativo"
            Me.fgAut.Cols.Item(1).Caption = "Tipo Ahorro"
            Me.fgAut.Cols.Item(2).Caption = "No. Cuenta"
            Me.fgAut.Cols.Item(3).Caption = "Nombre"
            Me.fgAut.Cols.Item(4).Caption = "Tipo Documento"

            Me.fgAut.Cols.Item(0).Width = 77
            Me.fgAut.Cols.Item(1).Width = 77
            Me.fgAut.Cols.Item(2).Width = 150
            Me.fgAut.Cols.Item(3).Width = 300
            Me.fgAut.Cols.Item(4).Width = 100

            If Me.fgAut.Row <> -1 Then
                Me.btDel.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtpFechaApertura_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaApertura.LostFocus
        Me.dtpFec1Cuota.Value = Me.dtpFechaApertura.Value
    End Sub



    Private Sub ActualizaGridR()

        Dim oAh As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarReposicionLibreta("*", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", "NoSolicitud", sUsuario, sPassword, sSucursal)

            Me.fgR.DataSource = ds.Tables(0)
            Me.fgR.Cols.Item(0).Caption = "No. Solicitud"
            Me.fgR.Cols.Item(1).Caption = "Tipo Ahorro"
            Me.fgR.Cols.Item(2).Caption = "No. Cuenta"
            Me.fgR.Cols.Item(3).Caption = "Causa"
            Me.fgR.Cols.Item(4).Caption = "Cancela Comisión"
            Me.fgR.Cols.Item(5).Caption = "No. Libreta Repone"
            Me.fgR.Cols.Item(6).Caption = "No. Libreta"
            Me.fgR.Cols.Item(7).Caption = "Fecha"

            Me.fgR.Cols.Item(0).Width = 77
            Me.fgR.Cols.Item(1).Width = 77
            Me.fgR.Cols.Item(2).Width = 77
            Me.fgR.Cols.Item(3).Width = 77
            Me.fgR.Cols.Item(4).Width = 77
            Me.fgR.Cols.Item(5).Width = 77
            Me.fgR.Cols.Item(6).Width = 77
            Me.fgR.Cols.Item(7).Width = 77

            If Me.fgR.Row <> -1 Then
                Me.btEditR.Enabled = True
                Me.btDelR.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub fgR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgR.DoubleClick
        MetroButton12_Click(sender, e)
    End Sub

    Private Sub ckbCobroDomicilio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbCobroDomicilio.CheckedChanged
        If Me.ckbCobroDomicilio.Checked = True Then
            Me.grbRutaCobro.Enabled = True
            btnSaveTb7.Enabled = True
        Else
            Me.grbRutaCobro.Enabled = False
            btnSaveTb7.Enabled = False
        End If
    End Sub

    Private Sub txtTel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If e.KeyChar.IsLetter(e.KeyChar) = True Then
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodEjecApertura_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecApertura.DoubleClick
        Dim ofrm As New frmAGenerico, ds As New Data.DataSet

        ofrm.Text = "Buscar Ejecutivos de Mercadeo"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecApertura.Text = ofrm.Resultado.Trim
            txtEjecApertura.Text = ofrm.Resultado2.Trim
            Me.txtObs.Focus()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEjecApertura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecApertura.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim oPl As New wrPlanilla.wsLibPlanilla
            Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Try
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecApertura.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtEjecApertura.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecApertura.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtEjecApertura.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                        Me.txtObs.Focus()
                    End If
                Else
                    txtCodEjecApertura_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    ''Corregidos

    Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick

        Dim ofrm As New frmAGenerico
        Try

            'Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, 
            Dim ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection, dr As DataRow
            ds = Ahorro.consultarTiposAhorrosActivos("left(a.codtipoAhorro,1) in ('" & libAhorro.tiposAhorro.vista & "','" & libAhorro.tiposAhorro.restringido & "', '" & libAhorro.tiposAhorro.programado & "')")

            ofrm.Text = "Buscar Tipos de Ahorro"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()

            If ofrm.Resultado.Trim = "" Then Exit Sub

            txtCodTipoAhorro.Text = ofrm.Resultado.Trim
            txtTipoAhorro.Text = ofrm.Resultado2.Trim
            txtCodAhorro.Text = ofrm.Resultado.Trim
            txtAhorro.Text = ofrm.Resultado2.Trim
            ' validarContrato(txtCodTipoAhorro.Text.Trim)
            AhorroJunior = IIf(IIf(IsDBNull(ofrm.Resultado4.Trim), "0", ofrm.Resultado4.Trim) = "1", True, False)
            Select Case Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1)
                Case "3" 'Ahorro a la Vista
                    Me.vTipo = "Vista"
                Case "5" 'Ahorro Restringido
                    Me.vTipo = "Rest"
                Case "4" 'Ahorro Programado
                    Me.vTipo = "Prog"
            End Select

            'Me.txtNoCuenta.Text = Ahorro.GeneraNoCuenta(Trim(Me.txtCodTipoAhorro.Text), sSucursal, "02", Me.dtpFechaApertura.Value.Month, Me.dtpFechaApertura.Value.Year, sUsuario, sPassword, sSucursal)
            'Me.txtDigito.Text = Ahorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
            'Aquí Consultar TasasInteresActiva y poner valor en tasa de interés como sugerencia.
            ds = Ahorro.ConsultarParametros("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables("AhParametros").Rows
            If Filas.Count > 0 Then
                dr = ds.Tables("AhParametros").Rows(0)
                Me.c1nTasa.Value = IIf(IsDBNull(dr("TasaInteres")), 0, dr("TasaInteres"))
            End If

            ActualizaControlesxTipo()
            txtCodPrestamo.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodTipoAhorro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoAhorro.KeyPress
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, Filas As Data.DataRowCollection, dr As DataRow
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then

                If txtCodTipoAhorro.Text.Trim = "" Then
                    txtCodTipoAhorro_DoubleClick(sender, e)
                Else

                    ds = oAhorro.ConsultarTipoAhorro("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "' and left(codtipoahorro,1) in ('" & libAhorro.tiposAhorro.programado & "', '" & libAhorro.tiposAhorro.vista & "','" & libAhorro.tiposAhorro.restringido & "') )", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtCodTipoAhorro.Text = CStr(Filas.Item(0)("CodTipoAhorro")).Trim
                        txtTipoAhorro.Text = CStr(Filas.Item(0)("Descripcion")).Trim
                        txtCodAhorro.Text = CStr(Filas.Item(0)("CodTipoAhorro")).Trim
                        txtAhorro.Text = CStr(Filas.Item(0)("Descripcion")).Trim
                        ' validarContrato(txtCodTipoAhorro.Text.Trim)
                        AhorroJunior = IIf(IIf(IsDBNull(Filas.Item(0)("Junior")), "0", Filas.Item(0)("Junior")) = "1", True, False)
                        Select Case Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1)
                            Case "3" 'Ahorro a la Vista
                                Me.vTipo = "Vista"
                            Case "5" 'Ahorro Restringido
                                Me.vTipo = "Rest"
                            Case "4" 'Ahorro Programado
                                Me.vTipo = "Prog"
                        End Select

                        'Me.txtNoCuenta.Text = oAhorro.GeneraNoCuenta(Trim(Me.txtCodTipoAhorro.Text), sSucursal, "02", Me.dtpFechaApertura.Value.Month, Me.dtpFechaApertura.Value.Year, sUsuario, sPassword, sSucursal)
                        'Me.txtDigito.Text = oAhorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                        'Aquí Consultar TasasInteresActiva y poner valor en tasa de interés como sugerencia.
                        ds = oAhorro.ConsultarParametros("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables("AhParametros").Rows
                        If Filas.Count > 0 Then
                            dr = ds.Tables("AhParametros").Rows(0)
                            Me.c1nTasa.Value = IIf(IsDBNull(dr("TasaInteres")), 0, dr("TasaInteres"))
                        End If
                        ActualizaControlesxTipo()
                        txtCodPrestamo.Focus()
                        'validarContrato(txtCodTipoAhorro.Text.Trim)
                    Else
                        'txtCodTipoAhorro_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub direccionAsociado(dui As String)
        Dim dts As New DataSet
        dts = asociados.ConsultarDomicilios(dui)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dts.Tables(0).Rows
                    If row("Estado").Equals(True) Then
                        txtDireccion.Text = row("Direccion").ToString
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Try
            Dim ofrm As New frmAGenerico

            ofrm.Text = "Buscar Asociados"
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection, pCodProf As String
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2", " EstadoIngreso in ('2','1') and EstadoAsociado='25' ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtDui.Text = ofrm.Resultado.Trim
            'ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') and EstadoAsociado='25' ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            'Filas = ds.Tables(0).Rows()
            'If Filas.Count > 0 Then
            '    txtDui.Text = IIf(CStr(Filas.Item(0)("DUI")).Trim Is DBNull.Value, "", Filas.Item(0)("DUI").ToString.Trim)
            '    txtNombres.Text = IIf(CStr(Filas.Item(0)("Nombres")).Trim Is DBNull.Value, "", CStr(Filas.Item(0)("Nombres")))
            '    txtApe1.Text = IIf(CStr(Filas.Item(0)("Apellido1")).Trim Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido1")).Trim)
            '    txtApe2.Text = IIf(CStr(Filas.Item(0)("Apellido2")).Trim Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido2")))
            '    txtApe3.Text = IIf(CStr(Filas.Item(0)("ApellidoCas")).Trim Is DBNull.Value, "", Filas.Item(0)("ApellidoCas"))
            '    direccionAsociado(txtDui.Text)
            '    'txtDireccion.Text = IIf(CStr(Filas.Item(0)("Direccion")).Trim Is DBNull.Value, "", Filas.Item(0)("Direccion"))
            '    cbEstadoCivil.SelectedValue = IIf(CStr(Filas.Item(0)("codEstadoCivil")) Is DBNull.Value, "", Filas.Item(0)("codEstadoCivil"))

            '    txtLugDui.Text = IIf(CStr(Filas.Item(0)("LugarExtDUI")).Trim Is DBNull.Value, "", Filas.Item(0)("LugarExtDUI"))
            '    dtpFecExtDui.Value = IIf((Filas.Item(0)("FechaExtDUI")) Is DBNull.Value, Now, Filas.Item(0)("FechaExtDUI"))
            '    dtpFecNac.Value = IIf((Filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, Filas.Item(0)("Fecha_Nac"))
            '    txtTelCasa.Text = IIf(CStr(Filas.Item(0)("TelCasa")).Trim Is DBNull.Value, "", Filas.Item(0)("TelCasa"))
            '    ' txtTelOfic.Text = IIf(CStr(Filas.Item(0)("TelOficina")).Trim Is DBNull.Value, "", Filas.Item(0)("TelOficina"))
            '    txtCel.Text = IIf(CStr(Filas.Item(0)("Celular")).Trim Is DBNull.Value, "", Filas.Item(0)("Celular"))
            '    pCodProf = IIf(CStr(Filas.Item(0)("CodProfesion")).Trim Is DBNull.Value, "", Filas.Item(0)("CodProfesion"))
            '    Me.txtNoSocio.Text = IIf(CStr(Filas.Item(0)("NoSocio")).Trim Is DBNull.Value, "", Filas.Item(0)("NoSocio"))
            '    ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(pCodProf) & "'", "", sUsuario, sPassword, sSucursal)
            '    Filas = ds.Tables(0).Rows()
            '    If Filas.Count > 0 Then
            '        If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
            '            Me.txtProf.Text = CStr(Filas.Item(0)("Descripcion"))
            '        End If
            '    End If
            '    Dim FechaNac As Date
            '    If DateTime.IsLeapYear(Me.dtpFecNac.Value.Year) = True And Me.dtpFecNac.Value.Day = 29 And Me.dtpFecNac.Value.Month = 2 Then
            '        FechaNac = "28/" & dtpFecNac.Value.Month & "/" & Now().Year
            '    Else
            '        FechaNac = dtpFecNac.Value.Day & "/" & dtpFecNac.Value.Month & "/" & Now().Year
            '    End If
            '    Me.txtEdad.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNac.Value, Now())
            '    Me.txtTitular2.Focus()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        Dim pCodProf As String
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') and EstadoAsociado='25'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtDui.Value = IIf(CStr(Filas.Item(0)("DUI")).Trim Is DBNull.Value, "", Filas.Item(0)("DUI").ToString.Trim)
                    'txtNombres.Text = IIf(CStr(Filas.Item(0)("Nombres")).Trim Is DBNull.Value, "", CStr(Filas.Item(0)("Nombres")))
                    'txtApe1.Text = IIf(CStr(Filas.Item(0)("Apellido1")).Trim Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido1")).Trim)
                    'txtApe2.Text = IIf(CStr(Filas.Item(0)("Apellido2")).Trim Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido2")))
                    'txtApe3.Text = IIf(CStr(Filas.Item(0)("ApellidoCas")).Trim Is DBNull.Value, "", Filas.Item(0)("ApellidoCas"))
                    'direccionAsociado(txtDui.Text)
                    ''txtDireccion.Text = IIf(CStr(Filas.Item(0)("Direccion")).Trim Is DBNull.Value, "", Filas.Item(0)("Direccion"))
                    'cbEstadoCivil.SelectedValue = IIf(CStr(Filas.Item(0)("codEstadoCivil")) Is DBNull.Value, "", Filas.Item(0)("codEstadoCivil"))

                    'txtLugDui.Text = IIf(CStr(Filas.Item(0)("LugarExtDUI")).Trim Is DBNull.Value, "", Filas.Item(0)("LugarExtDUI"))
                    'dtpFecExtDui.Value = IIf((Filas.Item(0)("FechaExtDUI")) Is DBNull.Value, Now, Filas.Item(0)("FechaExtDUI"))
                    'dtpFecNac.Value = IIf((Filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, Filas.Item(0)("Fecha_Nac"))
                    'txtTelCasa.Text = IIf(CStr(Filas.Item(0)("TelCasa")).Trim Is DBNull.Value, "", Filas.Item(0)("TelCasa"))
                    '' txtTelOfic.Text = IIf(CStr(Filas.Item(0)("TelOficina")).Trim Is DBNull.Value, "", Filas.Item(0)("TelOficina"))
                    'txtCel.Text = IIf(CStr(Filas.Item(0)("Celular")).Trim Is DBNull.Value, "", Filas.Item(0)("Celular"))
                    'pCodProf = IIf(CStr(Filas.Item(0)("CodProfesion")).Trim Is DBNull.Value, "", Filas.Item(0)("CodProfesion"))
                    'Me.txtNoSocio.Text = IIf(CStr(Filas.Item(0)("NoSocio")).Trim Is DBNull.Value, "", Filas.Item(0)("NoSocio"))
                    'ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(pCodProf) & "'", "", sUsuario, sPassword, sSucursal)
                    'Filas = ds.Tables(0).Rows()
                    'If Filas.Count > 0 Then
                    '    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                    '        Me.txtProf.Text = CStr(Filas.Item(0)("Descripcion"))
                    '    End If
                    'End If
                    'Dim FechaNac As Date
                    'If DateTime.IsLeapYear(Me.dtpFecNac.Value.Year) = True And Me.dtpFecNac.Value.Day = 29 And Me.dtpFecNac.Value.Month = 2 Then
                    '    FechaNac = "28/" & dtpFecNac.Value.Month & "/" & Now().Year
                    'Else
                    '    FechaNac = dtpFecNac.Value.Day & "/" & dtpFecNac.Value.Month & "/" & Now().Year
                    'End If
                    'Me.txtEdad.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNac.Value, Now())
                    'Me.txtTitular2.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodTipoAhorro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.TextChanged
        bandera = Ahorro.ValidarCtas_TransferenciasAutomaticas(Me.txtCodTipoAhorro.Text.Trim)
        ActivarControlesTransferencia(bandera)
        If Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1) = "3" Then
            Me.dtpFec1Cuota.Visible = False
            Me.c1nMonto.Visible = False
            Me.c1nCuota.Visible = False
            Me.Label17.Visible = False
            Me.Label21.Visible = False
            Me.Label19.Visible = False
            Me.nuDNoCuotas.Visible = False
            Me.Label22.Visible = False
            Me.c1nPlazo.Visible = False
            Me.Label18.Visible = False
            Me.btnConsPlanAh.Visible = False
            Me.btTasaPactada.Visible = False
            'Me.txtCodPrestamo.Visible = False
            'Me.lblCodPrestamo.Visible = False
            'Me.gbPrestamo.Visible = False
            'Me.GroupBox3.Height = 117 '97
            Me.btModificaPlanAh.Visible = False
        ElseIf Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1) = "4" Then
            Me.dtpFec1Cuota.Visible = False
            Me.c1nMonto.Visible = False
            Me.c1nCuota.Visible = False
            Me.Label17.Visible = False
            Me.Label21.Visible = False
            Me.Label19.Visible = False
            Me.nuDNoCuotas.Visible = False
            Me.Label22.Visible = False
            Me.c1nPlazo.Visible = False
            Me.Label18.Visible = False
            Me.btnConsPlanAh.Visible = False
            Me.btTasaPactada.Visible = False
            'Me.txtCodPrestamo.Visible = True
            'Me.lblCodPrestamo.Visible = True
            'Me.gbPrestamo.Visible = True
            'Me.GroupBox3.Height = 117 '97
            Me.btModificaPlanAh.Visible = False
        ElseIf Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1) = "5" Then
            Me.dtpFec1Cuota.Visible = True
            Me.c1nMonto.Visible = True
            Me.c1nCuota.Visible = True
            Me.Label17.Visible = True
            Me.Label21.Visible = True
            Me.Label19.Visible = True
            Me.nuDNoCuotas.Visible = True
            Me.Label22.Visible = True
            Me.c1nPlazo.Visible = True
            Me.Label18.Visible = True
            Me.btnConsPlanAh.Visible = True
            Me.btTasaPactada.Visible = True
            'Me.txtCodPrestamo.Visible = False
            'Me.lblCodPrestamo.Visible = False
            'Me.gbPrestamo.Visible = False
            'Me.GroupBox3.Height = 169 '143
            Me.btModificaPlanAh.Visible = True
        End If
    End Sub







    Private Sub cbDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDoc.SelectedIndexChanged
        If cbDoc.SelectedIndex = 0 Then
            Me.txtPartida.EditMask = "00000000-0"
        ElseIf cbDoc.SelectedIndex = 1 Or cbDoc.SelectedIndex = 2 Then
            Me.txtPartida.EditMask = "0000-000000-000-0"
        Else
            Me.txtPartida.EditMask = ""
        End If
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

    Private Sub cbPar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPar.SelectedIndexChanged
        Me.cbParentesco.SelectedIndex = Me.cbPar.SelectedIndex
    End Sub

    Private Sub dtpFecNacT2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecNacT2.ValueChanged
        Dim FechaNac As Date
        FechaNac = dtpFecNacT2.Value.Day & "/" & dtpFecNacT2.Value.Month & "/" & Now().Year
        Me.txtEdadT2.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNacT2.Value, Now())
    End Sub

    Private Sub GuardarPlanAhorro()
        Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
        Dim pCampos As String, pValores As String, pCodPlanAhorro As String, dr As DataRow, vPlan As New DataSet
        Try
            vPlan = oAh.PlanAhorro(Me.c1nMontoApertura.Value, Me.c1nTasa.Value, Me.c1nCuota.Value, Me.c1nPlazo.Value, Me.dtpFechaApertura.Value, Me.txtCodTipoAhorro.Text.Trim, sUsuario, sPassword, sSucursal)
            pCodPlanAhorro = oAh.ObtenerCorrelativoPlanAhorro("CodPlanAhorro", sUsuario, sPassword, sSucursal)
            pCampos = "CodPlanAhorro,CodTipoAhorro,NoCuenta,Fecha"
            pValores = "'" & pCodPlanAhorro & "','" & Me.txtCodTipoAhorro.Text.Trim & "','" & Me.txtNoCuenta.Text.Trim & "','" & Me.dtpFechaApertura.Value.ToShortDateString & "'"
            oAh.InsertarPlanAhorro(pCampos, pValores, sUsuario, sPassword, sSucursal)
            pCampos = "CodPlanAhorro,FechaCuota,MontoCuota,Saldo,TasaInteres,Cancelada"
            For Each dr In vPlan.Tables(0).Rows
                pValores = "'" & pCodPlanAhorro & "','" & Format(dr("FechaPago"), "dd/MM/yyyy") & "'," & dr("MontoCuota") & "," & dr("Saldo") & "," & dr("Interes") & ",'N'"
                oAh.InsertarDet_PlanAhorro(pCampos, pValores, sUsuario, sPassword, sSucursal)
            Next
            btModificaPlanAh.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ModificaPlanAhorro()
        Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
        Dim pCampos As String, pValores As String, pCodPlanAhorro As String, dr As DataRow, vPlan As New DataSet
        vPlan = oAh.PlanAhorro(Me.c1nMontoApertura.Value, Me.c1nTasa.Value, Me.c1nCuota.Value, Me.c1nPlazo.Value, Me.dtpFechaApertura.Value, Me.txtCodTipoAhorro.Text.Trim, sUsuario, sPassword, sSucursal)
        ds = oAh.ConsultarPlanAhorro("*", "NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count > 0 Then
            dr = ds.Tables(0).Rows(0)
            pCodPlanAhorro = dr("CodPlanAhorro")
            oAh.EliminarDet_PlanAhorro(pCodPlanAhorro.Trim, sUsuario, sPassword, sSucursal)
            pCampos = "CodPlanAhorro,FechaCuota,MontoCuota,Saldo,TasaInteres,Cancelada"
            For Each dr In vPlan.Tables(0).Rows
                pValores = "'" & pCodPlanAhorro & "','" & Format(dr("FechaPago"), "dd/MM/yyyy") & "'," & dr("MontoCuota") & "," & dr("Saldo") & "," & dr("Interes") & ",'N'"
                oAh.InsertarDet_PlanAhorro(pCampos, pValores, sUsuario, sPassword, sSucursal)
            Next
            vAutorizaModificarPlan = False
        End If
    End Sub



    Private Sub cbTipoDeposito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoDeposito.SelectedIndexChanged
        If Me.cbTipoDeposito.SelectedIndex = 1 Then
            Me.txtNoCuentaDepAut.Enabled = True
            Me.dtpFecIniDA.Enabled = True
            Me.dtpFecFinDA.Enabled = True
            If Me.vTipo = "Vista" Then Me.c1nMontoTransf.Enabled = True
        ElseIf Me.cbTipoDeposito.SelectedIndex = 0 Then
            Me.txtNoCuentaDepAut.Text = ""
            Me.txtCodTipoAhorroDepAut.Text = ""
            Me.txtNoCuentaDepAut.Enabled = False
            Me.dtpFecIniDA.Enabled = False
            Me.dtpFecFinDA.Enabled = False
            Me.c1nMontoTransf.Enabled = False
        End If
    End Sub

    Private Sub txtNoCuentaDepAut_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuentaDepAut.DoubleClick

        Dim ds As New DataSet, oAh As New wrAhorro.wsLibAhorro, frm As New frmAGenerico
        ds = oAh.ConsultarCtasAhorroDUI("a.CodTipoAhorro as Codigo,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.NoCuentaAnterior,a.SaldoDisponible_CuentaAhorro as Saldo,b.IdCuenta as Cuenta_Contable,Pignorado", "a.DUI='" & Me.txtDui.Value & "' and Estado<>'C' and Estado<>'B' and Left(a.CodTipoAhorro,1)='3'", "", sUsuario, sPassword, sSucursal)
        frm.Text = "Buscar Cuentas Auxiliares"
        frm.Datos = ds
        frm.ColSeleccion = 0
        frm.RefrescarGrid()
        frm.ShowDialog()
        If frm.Resultado.Trim <> "" Then
            Me.txtNoCuentaDepAut.Text = frm.Resultado3.Trim
            Me.txtCodTipoAhorroDepAut.Text = frm.Resultado.Trim
        End If
    End Sub

    Private Sub c1nCuota_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCuota.LostFocus
        Me.c1nMontoTransf.Value = Me.c1nCuota.Value
    End Sub

    Private Sub txtCodPrestamo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.txtCodPrestamo.Text.Trim = "" Then Exit Sub
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo")
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.ConsultarPRPrestamos("CodPrestamo", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and Dui='" & Me.txtDui.Value & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
            Else
                MessageBox.Show("Código de Préstamo no existe, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtCodPrestamo.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function pCalculaFechaVencimiento(ByVal pFechaApertura As Date, ByVal pPlazo As Integer, ByVal pTipoPlazo As String) As Date
        Dim nDias As Integer, nAnios As Integer, x As Integer, pFechaVencimiento As Date
        If pTipoPlazo = "d" Then
            pFechaVencimiento = pFechaApertura.AddDays(pPlazo)
        ElseIf pTipoPlazo = "m" Then
            pFechaVencimiento = pFechaApertura.AddMonths(pPlazo)
        End If

        If DateTime.IsLeapYear(pFechaApertura.Year) = True Then 'Bisiesto
            If pFechaApertura.Month > 2 Then nDias = nDias + 1
        End If
        nAnios = DateDiff(DateInterval.Year, pFechaApertura, pFechaVencimiento)
        For x = 1 To nAnios
            If x = nAnios Then
                If DateTime.IsLeapYear(pFechaVencimiento.Year) = True Then
                    If pFechaVencimiento.Month > 2 Then nDias = nDias + 1
                End If
            Else
                If DateTime.IsLeapYear(pFechaApertura.Year + 1) = True Then
                    nDias = nDias + 1
                End If
            End If
        Next
        Return pFechaVencimiento.AddDays(nDias)
    End Function
    Protected Sub LLENAR_DG(ByVal CODPRESTAMO As String)
        Dim dts As New DataSet
        dts = Prestamos.ConsultarDatosPrestamos("", CODPRESTAMO.Trim, 2)
        Me.DataGridView1.DataSource = dts.Tables(0)
        HeaderDg()
    End Sub


    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        If Me.vAhorroJunior = True Then
            Dim FechaNac As Date
            FechaNac = dtpFecNacT2.Value.Day & "/" & dtpFecNacT2.Value.Month & "/" & Now().Year
            Me.txtEdadT2.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNacT2.Value, Now())
            If CDbl(Me.txtEdadT2.Text) > 18 Then
                MsgBox("La edad debe ser menor de 18 años.")
                Me.dtpFecNacT2.Focus()
            Else
                Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
            End If
        Else
            Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
        End If
    End Sub

    Private Sub btnSiguiente2_Click(sender As Object, e As EventArgs) Handles btnSiguiente2.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btTasaPactada.Click
        Try
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "AHC002"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                Me.c1nTasa.ReadOnly = False
                Me.c1nTasa.Focus()
                ofrmAut.Autoriza = False
                ofrmAut.Dispose()
            Else
                ofrmAut.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click_1(sender As Object, e As EventArgs) Handles btnConsPlanAh.Click
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
            Dim ofrm As frmMsAhPlanAhorro = New frmMsAhPlanAhorro, ds As New Data.DataSet, dsDet As New DataSet, vNoPlan As String, Filas As DataRowCollection
            If Me.c1nMontoApertura.Value = 0 Or Me.c1nPlazo.Value = 0 Then
                MsgBox("El monto de apertura y el plazo no pueden ser cero.")
                Exit Sub
            End If
            ofrm.Cuenta = Trim(Me.txtNoCuenta.Text)
            ofrm.CodAhorro = Trim(Me.txtCodTipoAhorro.Text)
            ofrm.Ahorro = Trim(Me.txtTipoAhorro.Text)
            ofrm.MontoApertura = Me.c1nMontoApertura.Value
            ofrm.TasaInteres = Me.c1nTasa.Value
            ofrm.Monto = Me.c1nCuota.Value
            ofrm.NoCuotas = Me.c1nPlazo.Value
            ofrm.Fecha = Me.dtpFechaApertura.Value
            ofrm.FrmCtas = Me
            ofrm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click_2(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles btnSaveTb3.Click
        Me.btnSaveTb1_Click(sender, e)
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles btnContrato.Click
        Try
            If txtNoCuenta.ToString.Trim = "" Then
                MsgBox("No hay una cuenta seleccionada, Favor Verifique.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
            ds = oAh.RptContratoAhorros(txtNoCuenta.Text)
            Dim ofrm As New frmVisor(ds, 220, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
        'Try
        '    Dim frmRpt As New frmVisorRs_Contratos
        '    Dim dts As New DataSet
        '    dts = Ahorro.consultarAhContratos_Ahorro(txtCodTipoAhorro.Text.Trim)
        '    If dts.Tables.Count > 0 Then
        '        If dts.Tables(0).Rows.Count > 0 Then
        '            With frmRpt
        '                .ruta = dts.Tables(0).Rows(0).Item("ruta").ToString.Trim
        '                .nocuenta = txtNoCuenta.Text.Trim
        '                .ShowDialog()
        '            End With
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        'End Try
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton10_Click(sender As Object, e As EventArgs) Handles btnSaveTb7.Click
        Try
            Dim oCred As wrAhorro.wsLibAhorro
            Dim ds As New Data.DataSet
            oCred = New wrAhorro.wsLibAhorro
            Dim pCampos As String, pValores As String
            Dim pCamposValores As String
            ds = oCred.ConsultarRutasCobro("*", "CodTipoAhorro = '" & pCodTipoAhorro.Trim & "' and NoCuenta='" & pNoCuenta.Trim & "'", "", sUsuario, sPassword, sSucursal)
            pCampos = "CodTipoAhorro,NoCuenta,DireccionCobro,CodDepartamento,CodMunicipio,Dia,FechaCaducidad,CodCobrador"
            pValores = "'" & pCodTipoAhorro & "','" & pNoCuenta & "','" & Trim(Me.txtDireccionCobro.Text) & "','" & Trim(Me.txtCodDpto.Text) & "','" & Trim(Me.txtCodMun.Text) & "'," & Val(Me.txtDia.Text) & ",'" & Me.dtpFechaCuota.Value.ToShortDateString & "'," & Me.txtCodCobrador.Text.Trim & ""
            If ds.Tables(0).Rows.Count <= 0 Then
                oCred.InsertarRutasCobro(pCampos, pValores, sUsuario, sPassword, sSucursal)
            Else
                pCamposValores = "DireccionCobro='" & Trim(Me.txtDireccionCobro.Text) & "',CodDepartamento='" & Trim(Me.txtCodDpto.Text) & "',CodMunicipio='" & Trim(Me.txtCodMun.Text) & "',Dia=" & Val(Me.txtDia.Text) & ",FechaCaducidad='" & Me.dtpFechaCuota.Value.ToShortDateString & "',CodCobrador=" & Me.txtCodCobrador.Text.Trim & ""
                oCred.ModificarRutasCobro(pCamposValores, pNoCuenta, sUsuario, sPassword, sSucursal)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton9_Click(sender As Object, e As EventArgs) Handles MetroButton9.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton5_Click_1(sender As Object, e As EventArgs) Handles btNewBen.Click
        Try
            Dim frm As frmMsAhBeneficiarios = New frmMsAhBeneficiarios
            frm.pNoCuenta = Me.pNoCuenta
            frm.pCodTipoAhorro = Me.pCodTipoAhorro
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridBen()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton6_Click_1(sender As Object, e As EventArgs) Handles btEditBen.Click
        Try

            If Me.fgBen.Row <> -1 Then
                Dim frm As frmMsAhBeneficiarios = New frmMsAhBeneficiarios
                frm.pNoCuenta = Me.pNoCuenta
                frm.txtDui.Value = Me.fgBen.Item(Me.fgBen.Row, "DuiBeneficiario")
                frm.pCodTipoAhorro = Me.pCodTipoAhorro
                frm.pCorrelativo = Me.fgBen.Item(Me.fgBen.Row, "Correlativo")
                frm.pAccion = "Modificar"
                If Me.btnSaveTb1.Enabled = False And Me.btnSaveTb1.Visible = False Then frm.btnGuardar1.Enabled = False
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridBen()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton10_Click_1(sender As Object, e As EventArgs) Handles btDelBen.Click
        Try
            If Me.fgBen.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Beneficiario No. " & Me.fgBen.Item(Me.fgBen.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Beneficiarios") = MsgBoxResult.Yes Then
                    Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oAh.EliminarBeneficiarios("Correlativo=" & Me.fgBen.Item(Me.fgBen.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridBen()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton13_Click(sender As Object, e As EventArgs) Handles btNew.Click
        Try
            Dim frm As frmMsAhAutorizaRetiro = New frmMsAhAutorizaRetiro
            frm.pNoCuenta = Me.pNoCuenta
            frm.pCodTipoAhorro = Me.pCodTipoAhorro
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridAut()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton12_Click(sender As Object, e As EventArgs) Handles btnEditAut.Click
        Try
            If Me.fgAut.Row <> -1 Then
                Dim ofrmAut As New frmMsAutorizacion
                ofrmAut.TipoPermiso = "P"
                ofrmAut.NumPrograma = "AHO001"
                ofrmAut.ShowDialog()
                If ofrmAut.Autoriza = True Then
                    Dim frm As frmMsAhAutorizaRetiro = New frmMsAhAutorizaRetiro
                    frm.pUsuario = ofrmAut.Usuario
                    frm.pPassword = ofrmAut.Password
                    frm.pNoCuenta = Me.pNoCuenta
                    frm.pCodTipoAhorro = Me.pCodTipoAhorro
                    frm.pCorrelativo = Me.fgAut.Item(Me.fgAut.Row, "Correlativo")
                    frm.pAccion = "Modificar"
                    frm.btnGuardar1.Text = "&Modificar"
                    frm.StartPosition = FormStartPosition.CenterScreen
                    frm.ShowDialog()
                    ActualizaGridAut()
                    ofrmAut.Autoriza = False
                    ofrmAut.Dispose()
                Else
                    ofrmAut.Dispose()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton11_Click(sender As Object, e As EventArgs) Handles btDel.Click
        Try
            If Me.fgAut.Row <> -1 Then
                If MsgBox("¿Desea eliminar el registro No. " & Me.fgAut.Item(Me.fgAut.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Autorizados Retiro") = MsgBoxResult.Yes Then
                    Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oAh.EliminarAutorizadoRetiro(Me.fgAut.Item(Me.fgAut.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                    ActualizaGridAut()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton16_Click(sender As Object, e As EventArgs) Handles btNewR.Click
        Try
            Dim frm As frmMsAhRepLibreta = New frmMsAhRepLibreta
            frm.pNoLibreta = Me.txtNoLibreta.Text
            frm.pNoCuenta = Me.pNoCuenta
            frm.pCodTipoAhorro = Me.pCodTipoAhorro
            frm.pAccion = "Guardar"
            frm.btnGuardar.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridR()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton15_Click(sender As Object, e As EventArgs) Handles btEditR.Click
        Try

            If Me.fgR.Row <> -1 Then
                Dim frm As frmMsAhRepLibreta = New frmMsAhRepLibreta
                frm.pNoCuenta = Me.pNoCuenta
                frm.pCodTipoAhorro = Me.pCodTipoAhorro
                frm.pNoLibreta = Me.txtNoLibreta.Text
                frm.pCorrelativo = Me.fgR.Item(Me.fgR.Row, "NoSolicitud")
                frm.pAccion = "Modificar"
                If Me.btnSaveTb1.Enabled = False Then frm.btnGuardar.Enabled = False
                frm.btnGuardar.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridR()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton14_Click(sender As Object, e As EventArgs) Handles btDelR.Click
        Try
            If Me.fgR.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Solicitud No. " & Me.fgR.Item(Me.fgR.Row, "NoSolicitud") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Solicitud") = MsgBoxResult.Yes Then
                    Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oAh.EliminarReposicionLibreta(Me.fgR.Item(Me.fgR.Row, "NoSolicitud"), sUsuario, sPassword, sSucursal)
                    ActualizaGridR()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btModificaPlanAh_Click(sender As Object, e As EventArgs) Handles btModificaPlanAh.Click
        Try
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "AHK002"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                Me.c1nCuota.Enabled = True
                Me.c1nPlazo.Enabled = True
                Me.c1nPlazo.Focus()
                vAutorizaModificarPlan = True
                ofrmAut.Autoriza = False
                ofrmAut.Dispose()
            Else
                ofrmAut.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub MetroButton5_Click_2(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Dim frm As New frmIngresoAsoc2
        With frm
            .txtDui.Text = Me.txtDui.Value
            .accion = 2
            .Show()
        End With
    End Sub

    Protected Sub HeaderDg()
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Green
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtCodPrestamo_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim dts As New DataSet
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        dts = Prestamos.ConsultarDatosPrestamos(Me.txtDui.Text.Trim, " ", 1)
        Try
            frm.Datos = dts
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim <> "" Then
                Me.txtCodPrestamo.Text = frm.Resultado.Trim
            End If
        Catch ex As Exception
            MsgBox("Error al momento de asignar el prestamo, Por favor comuniquese con el administrador del sistema.", MsgBoxStyle.Information, "Modúlo - Ahorros")
        End Try
    End Sub
    Private Sub cbAsignarAhorro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAsignarAhorro.Click
        Dim accion As Integer
        If Me.btnSaveTb3.Text = "&Modificar" Then
            If Me.cbAsignarAhorro.Checked = True Then
                accion = MsgBox("Desea asignar este prestamo a la cta. de ahorro", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Modúlo - Ahorros")
                If accion = 6 Then
                    Dim resultado As Integer
                    resultado = Ahorro.AsignarPrestamo_Transferencia(Me.txtNoCuenta.Text.Trim, Me.txtCodPrestamo.Text.Trim, True)
                    If resultado = 1 Then
                        MsgBox("Prestamo asignado exitosamente", MsgBoxStyle.Information, "Modúlo - Ahorros")
                        LLENAR_DG(Me.txtCodPrestamo.Text.Trim)
                    Else
                        MsgBox("Error al momento de asignar el prestamo, Por favor comuniquese con el administrador del sistema.", MsgBoxStyle.Information, "Modúlo - Ahorros")
                    End If
                Else
                    Me.cbAsignarAhorro.Checked = False
                End If
            ElseIf Me.cbAsignarAhorro.Checked = False Then
                accion = MsgBox("Desea retirar este prestamo de la cta. de ahorro", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Modúlo - Ahorros")
                If accion = 6 Then
                    Dim resultado As Integer
                    resultado = Ahorro.AsignarPrestamo_Transferencia(Me.txtNoCuenta.Text.Trim, Me.txtCodPrestamo.Text.Trim, False)
                    If resultado = 1 Then
                        MsgBox("Prestamo retirado exitosamente", MsgBoxStyle.Information, "Modúlo - Ahorros")
                        LLENAR_DG(Me.txtCodPrestamo.Text.Trim)
                    Else
                        MsgBox("Error al momento de asignar el prestamo, Por favor comuniquese con el administrador del sistema.", MsgBoxStyle.Information, "Modúlo - Ahorros")
                    End If
                Else
                    Me.cbAsignarAhorro.Checked = False
                End If
            End If
        End If
    End Sub


    Private Sub txtDui_Validated(sender As Object, e As EventArgs) Handles txtDui.Validated
        Try

            If Me.pAccion <> "Modificar" Then
                Dim ds As New DataSet
                Dim Filas As DataRowCollection
                Dim pCodProf As String
                ds = asociados.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,telCasa,celular,nosocio", " Dui='" & txtDui.Value & "' and EstadoIngreso in ('2','1') ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                'ds = asociados.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') and EstadoAsociado='25' ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then

                    '=================================================================================================================
                    'Generamos # DE CUENTA
                    Me.txtNoCuenta.Text = Ahorro.generarNoCuentaTipoAhorro(txtDui.Value.Trim, txtCodTipoAhorro.Text.Trim, sUsuario, sPassword, sSucursal)
                    'Me.txtNoCuenta.Text = Ahorro.GeneraNoCuenta(Trim(Me.txtCodTipoAhorro.Text), sSucursal, "02", Me.dtpFechaApertura.Value.Month, Me.dtpFechaApertura.Value.Year, sUsuario, sPassword, sSucursal)
                    Me.txtDigito.Text = Ahorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                    '=================================================================================================================
                    txtNombres.Text = IIf((Filas.Item(0)("Nombres")) Is DBNull.Value, "", CStr(Filas.Item(0)("Nombres")))
                    txtApe1.Text = IIf((Filas.Item(0)("Apellido1")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido1")).Trim)
                    txtApe2.Text = IIf((Filas.Item(0)("Apellido2")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido2")))
                    txtApe3.Text = IIf((Filas.Item(0)("ApellidoCas")) Is DBNull.Value, "", Filas.Item(0)("ApellidoCas"))
                    direccionAsociado(txtDui.Text)
                    'txtDireccion.Text = IIf(CStr(Filas.Item(0)("Direccion")).Trim Is DBNull.Value, "", Filas.Item(0)("Direccion"))
                    If Filas.Item(0)("codEstadoCivil") Is DBNull.Value = False Then
                        cbEstadoCivil.SelectedValue = Filas.Item(0)("codEstadoCivil")
                    End If


                    txtLugDui.Text = IIf((Filas.Item(0)("LugarExtDUI")) Is DBNull.Value, " ", Filas.Item(0)("LugarExtDUI"))
                    dtpFecExtDui.Value = IIf((Filas.Item(0)("FechaExtDUI")) Is DBNull.Value, Now, Filas.Item(0)("FechaExtDUI"))
                    dtpFecNac.Value = IIf((Filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, Filas.Item(0)("Fecha_Nac"))
                    txtTelCasa.Text = IIf((Filas.Item(0)("TelCasa")) Is DBNull.Value, " ", Filas.Item(0)("TelCasa"))
                    ' txtTelOfic.Text = IIf(CStr(Filas.Item(0)("TelOficina")).Trim Is DBNull.Value, "", Filas.Item(0)("TelOficina"))
                    txtCel.Text = IIf((Filas.Item(0)("Celular")) Is DBNull.Value, " ", Filas.Item(0)("Celular"))
                    pCodProf = IIf((Filas.Item(0)("CodProfesion")) Is DBNull.Value, " ", Filas.Item(0)("CodProfesion"))
                    Me.txtNoSocio.Text = IIf(CStr(Filas.Item(0)("NoSocio")) Is DBNull.Value, " ", Filas.Item(0)("NoSocio"))

                    If Filas.Item(0)("CodProfesion") Is DBNull.Value = False Then
                        Dim dtsProfesiones As New DataSet
                        dtsProfesiones = asociados.ConsultarProfesiones("codProfesion,descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
                        txtProf.Text = dtsProfesiones.Tables(0).Rows(0).Item("descripcion").ToString.ToUpper.Trim
                    End If


                    Dim FechaNac As Date
                    If DateTime.IsLeapYear(Me.dtpFecNac.Value.Year) = True And Me.dtpFecNac.Value.Day = 29 And Me.dtpFecNac.Value.Month = 2 Then
                        FechaNac = "28/" & dtpFecNac.Value.Month & "/" & Now().Year
                    Else
                        FechaNac = dtpFecNac.Value.Day & "/" & dtpFecNac.Value.Month & "/" & Now().Year
                    End If
                    Me.txtEdad.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNac.Value, Now())
                    Me.txtTitular2.Focus()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class