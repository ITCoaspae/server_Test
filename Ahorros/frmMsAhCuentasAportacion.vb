Public Class frmMsAhCuentasAportacion
    Inherits MetroFramework.Forms.MetroForm
    Dim asociados As New wrAsociados.wsLibAsoc
    Public rsc As System.Resources.ResourceManager
    Dim libAhorro As New sifLib.Ahorro.clsAhorros
    Dim Ahorro As New wrAhorro.wsLibAhorro
    Dim codApor As String

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
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents tbDatGral As System.Windows.Forms.TabPage
    Friend WithEvents tbBeneficiarios As System.Windows.Forms.TabPage
    Friend WithEvents tabDatGralII As System.Windows.Forms.TabPage
    Friend WithEvents btnCerrarTb3 As System.Windows.Forms.Button
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar2 As System.Windows.Forms.Button
    Friend WithEvents fgBen As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tbLibRep As System.Windows.Forms.TabPage
    Friend WithEvents dtpFecExtDui As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLugDui As System.Windows.Forms.TextBox
    Friend WithEvents txtApe3 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtProfesion As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpFecNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents c1nTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoApertura As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaApertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoLibreta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbCancela As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecCanc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtEjecMercadeoCanc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecCanc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMotivoCancela As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents ckbCobroDomicilio As System.Windows.Forms.CheckBox
    Friend WithEvents grbRutaCobro As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodCobrador As System.Windows.Forms.TextBox
    Friend WithEvents txtCobrador As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
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
    Friend WithEvents txtPignorado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents fgR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnCerrarTb7 As System.Windows.Forms.Button
    Friend WithEvents txtDigito As System.Windows.Forms.TextBox
    Friend WithEvents txtPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtVenc As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtApertura As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents fgPig As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCelT2 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtEdadT2 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents dtpFecNacT2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPartida As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtTitular2 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtTelOfic As System.Windows.Forms.TextBox
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents lblTelCasa As System.Windows.Forms.Label
    Friend WithEvents txtMontoPignorado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents txtEjecApertura As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecApertura As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents gbPig As System.Windows.Forms.GroupBox
    Friend WithEvents cbParentesco As System.Windows.Forms.ComboBox
    Friend WithEvents cbPar As System.Windows.Forms.ComboBox
    Friend WithEvents gbDepositosAutomaticos As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoCuentaDepAut As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecFinDA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecIniDA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtCodTipoAhorroDepAut As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoTransf As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnSigTb1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelR As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditR As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewR As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents lblEstado As Label
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb7 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhCuentasAportacion))
        Me.tbSolic = New System.Windows.Forms.TabControl()
        Me.tbDatGral = New System.Windows.Forms.TabPage()
        Me.btnSigTb1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbPar = New System.Windows.Forms.ComboBox()
        Me.cbParentesco = New System.Windows.Forms.ComboBox()
        Me.txtCelT2 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtEdadT2 = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.dtpFecNacT2 = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPartida = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtTitular2 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtTelOfic = New System.Windows.Forms.TextBox()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.lblTelCasa = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtProfesion = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtApe3 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpFecExtDui = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLugDui = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb1 = New MetroFramework.Controls.MetroButton()
        Me.gbDepositosAutomaticos = New System.Windows.Forms.GroupBox()
        Me.c1nMontoTransf = New C1.Win.C1Input.C1NumericEdit()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtNoCuentaDepAut = New System.Windows.Forms.TextBox()
        Me.dtpFecFinDA = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecIniDA = New System.Windows.Forms.DateTimePicker()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cbTipoDeposito = New System.Windows.Forms.ComboBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtCodTipoAhorroDepAut = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPignorado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoLibreta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.c1nTasa = New C1.Win.C1Input.C1NumericEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.c1nMontoApertura = New C1.Win.C1Input.C1NumericEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFechaApertura = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDigito = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEjecApertura = New System.Windows.Forms.TextBox()
        Me.txtCodEjecApertura = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.txtCodEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.tabDatGralII = New System.Windows.Forms.TabPage()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb3 = New MetroFramework.Controls.MetroButton()
        Me.fgPig = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gbPig = New System.Windows.Forms.GroupBox()
        Me.txtPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtVenc = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtApertura = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtMontoPignorado = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbCancela = New System.Windows.Forms.GroupBox()
        Me.dtpFecCanc = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtEjecMercadeoCanc = New System.Windows.Forms.TextBox()
        Me.txtCodEjecCanc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMotivoCancela = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btnCerrarTb3 = New System.Windows.Forms.Button()
        Me.tbBeneficiarios = New System.Windows.Forms.TabPage()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.btnCerrar2 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btDelBen = New MetroFramework.Controls.MetroButton()
        Me.btEditBen = New MetroFramework.Controls.MetroButton()
        Me.btNewBen = New MetroFramework.Controls.MetroButton()
        Me.fgBen = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbLibRep = New System.Windows.Forms.TabPage()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb7 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btDelR = New MetroFramework.Controls.MetroButton()
        Me.btEditR = New MetroFramework.Controls.MetroButton()
        Me.btNewR = New MetroFramework.Controls.MetroButton()
        Me.fgR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnCerrarTb7 = New System.Windows.Forms.Button()
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
        Me.tbSolic.SuspendLayout()
        Me.tbDatGral.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatDoc.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.gbDepositosAutomaticos.SuspendLayout()
        CType(Me.c1nMontoTransf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tabDatGralII.SuspendLayout()
        CType(Me.fgPig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPig.SuspendLayout()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCancela.SuspendLayout()
        Me.tbBeneficiarios.SuspendLayout()
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
        Me.tbSolic.Location = New System.Drawing.Point(28, 73)
        Me.tbSolic.Multiline = True
        Me.tbSolic.Name = "tbSolic"
        Me.tbSolic.SelectedIndex = 0
        Me.tbSolic.Size = New System.Drawing.Size(703, 639)
        Me.tbSolic.TabIndex = 51
        '
        'tbDatGral
        '
        Me.tbDatGral.BackColor = System.Drawing.Color.White
        Me.tbDatGral.Controls.Add(Me.btnSigTb1)
        Me.tbDatGral.Controls.Add(Me.GroupBox2)
        Me.tbDatGral.Controls.Add(Me.gbDatDoc)
        Me.tbDatGral.Location = New System.Drawing.Point(4, 40)
        Me.tbDatGral.Name = "tbDatGral"
        Me.tbDatGral.Size = New System.Drawing.Size(695, 595)
        Me.tbDatGral.TabIndex = 0
        Me.tbDatGral.Text = "Datos Generales"
        '
        'btnSigTb1
        '
        Me.btnSigTb1.Location = New System.Drawing.Point(592, 545)
        Me.btnSigTb1.Name = "btnSigTb1"
        Me.btnSigTb1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTb1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSigTb1.TabIndex = 201
        Me.btnSigTb1.Text = "Siguiente"
        Me.btnSigTb1.UseSelectable = True
        Me.btnSigTb1.UseStyleColors = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbPar)
        Me.GroupBox2.Controls.Add(Me.cbParentesco)
        Me.GroupBox2.Controls.Add(Me.txtCelT2)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.txtEdadT2)
        Me.GroupBox2.Controls.Add(Me.txtTel)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.dtpFecNacT2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtPartida)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cbDoc)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.txtTitular2)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(10, 340)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 198)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Titular 2"
        '
        'cbPar
        '
        Me.cbPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPar.Location = New System.Drawing.Point(112, 58)
        Me.cbPar.Name = "cbPar"
        Me.cbPar.Size = New System.Drawing.Size(211, 25)
        Me.cbPar.TabIndex = 3
        '
        'cbParentesco
        '
        Me.cbParentesco.Location = New System.Drawing.Point(112, 58)
        Me.cbParentesco.Name = "cbParentesco"
        Me.cbParentesco.Size = New System.Drawing.Size(210, 25)
        Me.cbParentesco.TabIndex = 1
        Me.cbParentesco.Visible = False
        '
        'txtCelT2
        '
        Me.txtCelT2.AcceptsReturn = True
        Me.txtCelT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCelT2.Location = New System.Drawing.Point(112, 162)
        Me.txtCelT2.MaxLength = 25
        Me.txtCelT2.Name = "txtCelT2"
        Me.txtCelT2.Size = New System.Drawing.Size(211, 23)
        Me.txtCelT2.TabIndex = 14
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(12, 165)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(77, 23)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Celular:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEdadT2
        '
        Me.txtEdadT2.AcceptsReturn = True
        Me.txtEdadT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEdadT2.Location = New System.Drawing.Point(440, 132)
        Me.txtEdadT2.MaxLength = 25
        Me.txtEdadT2.Name = "txtEdadT2"
        Me.txtEdadT2.ReadOnly = True
        Me.txtEdadT2.Size = New System.Drawing.Size(210, 23)
        Me.txtEdadT2.TabIndex = 12
        '
        'txtTel
        '
        Me.txtTel.AcceptsReturn = True
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTel.Location = New System.Drawing.Point(440, 162)
        Me.txtTel.MaxLength = 25
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(210, 23)
        Me.txtTel.TabIndex = 0
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(337, 136)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(48, 19)
        Me.Label33.TabIndex = 11
        Me.Label33.Text = "Edad:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(337, 162)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(106, 18)
        Me.Label39.TabIndex = 16
        Me.Label39.Text = "Teléfono Casa:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecNacT2
        '
        Me.dtpFecNacT2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNacT2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNacT2.Location = New System.Drawing.Point(112, 132)
        Me.dtpFecNacT2.Name = "dtpFecNacT2"
        Me.dtpFecNacT2.Size = New System.Drawing.Size(211, 23)
        Me.dtpFecNacT2.TabIndex = 10
        Me.dtpFecNacT2.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 42)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPartida
        '
        Me.txtPartida.AcceptsReturn = True
        Me.txtPartida.EditMask = "00000000-0"
        Me.txtPartida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida.Location = New System.Drawing.Point(440, 91)
        Me.txtPartida.MaxLength = 20
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.NumericInput = False
        Me.txtPartida.Size = New System.Drawing.Size(210, 24)
        Me.txtPartida.TabIndex = 8
        Me.txtPartida.Tag = Nothing
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(337, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "No. Documento"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbDoc
        '
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoc.Items.AddRange(New Object() {"DUI", "NIT", "No. Licencia", "No. Residente", "No. Partida y No. Folio", "No. Pasaporte"})
        Me.cbDoc.Location = New System.Drawing.Point(112, 89)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(211, 24)
        Me.cbDoc.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(12, 89)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 34)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Documento " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Identidad"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(12, 63)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(86, 19)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "Parentesco:"
        '
        'txtTitular2
        '
        Me.txtTitular2.AcceptsReturn = True
        Me.txtTitular2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitular2.Location = New System.Drawing.Point(112, 27)
        Me.txtTitular2.MaxLength = 50
        Me.txtTitular2.Name = "txtTitular2"
        Me.txtTitular2.Size = New System.Drawing.Size(538, 23)
        Me.txtTitular2.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(12, 29)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 34)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Nombre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Titular 2:"
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.Label29)
        Me.gbDatDoc.Controls.Add(Me.txtTelOfic)
        Me.gbDatDoc.Controls.Add(Me.txtCel)
        Me.gbDatDoc.Controls.Add(Me.Label35)
        Me.gbDatDoc.Controls.Add(Me.txtTelCasa)
        Me.gbDatDoc.Controls.Add(Me.lblTelCasa)
        Me.gbDatDoc.Controls.Add(Me.Label22)
        Me.gbDatDoc.Controls.Add(Me.txtEdad)
        Me.gbDatDoc.Controls.Add(Me.txtNoSocio)
        Me.gbDatDoc.Controls.Add(Me.Label21)
        Me.gbDatDoc.Controls.Add(Me.txtDireccion)
        Me.gbDatDoc.Controls.Add(Me.Label27)
        Me.gbDatDoc.Controls.Add(Me.cbEstadoCivil)
        Me.gbDatDoc.Controls.Add(Me.Label26)
        Me.gbDatDoc.Controls.Add(Me.txtProfesion)
        Me.gbDatDoc.Controls.Add(Me.Label25)
        Me.gbDatDoc.Controls.Add(Me.dtpFecNac)
        Me.gbDatDoc.Controls.Add(Me.Label24)
        Me.gbDatDoc.Controls.Add(Me.txtApe3)
        Me.gbDatDoc.Controls.Add(Me.Label15)
        Me.gbDatDoc.Controls.Add(Me.dtpFecExtDui)
        Me.gbDatDoc.Controls.Add(Me.Label7)
        Me.gbDatDoc.Controls.Add(Me.txtLugDui)
        Me.gbDatDoc.Controls.Add(Me.txtDui)
        Me.gbDatDoc.Controls.Add(Me.Label31)
        Me.gbDatDoc.Controls.Add(Me.txtApe2)
        Me.gbDatDoc.Controls.Add(Me.Label9)
        Me.gbDatDoc.Controls.Add(Me.txtNombres)
        Me.gbDatDoc.Controls.Add(Me.Label10)
        Me.gbDatDoc.Controls.Add(Me.txtApe1)
        Me.gbDatDoc.Controls.Add(Me.Label8)
        Me.gbDatDoc.Controls.Add(Me.Label6)
        Me.gbDatDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Green
        Me.gbDatDoc.Location = New System.Drawing.Point(10, 3)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(672, 334)
        Me.gbDatDoc.TabIndex = 0
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Datos Personales"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(12, 299)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 26)
        Me.Label29.TabIndex = 31
        Me.Label29.Text = "Tel. Oficina:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelOfic
        '
        Me.txtTelOfic.AcceptsReturn = True
        Me.txtTelOfic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelOfic.Location = New System.Drawing.Point(112, 302)
        Me.txtTelOfic.MaxLength = 25
        Me.txtTelOfic.Name = "txtTelOfic"
        Me.txtTelOfic.ReadOnly = True
        Me.txtTelOfic.Size = New System.Drawing.Size(211, 23)
        Me.txtTelOfic.TabIndex = 32
        '
        'txtCel
        '
        Me.txtCel.AcceptsReturn = True
        Me.txtCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCel.Location = New System.Drawing.Point(440, 272)
        Me.txtCel.MaxLength = 25
        Me.txtCel.Name = "txtCel"
        Me.txtCel.ReadOnly = True
        Me.txtCel.Size = New System.Drawing.Size(210, 23)
        Me.txtCel.TabIndex = 30
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(337, 272)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 19)
        Me.Label35.TabIndex = 29
        Me.Label35.Text = "Celular:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelCasa
        '
        Me.txtTelCasa.AcceptsReturn = True
        Me.txtTelCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelCasa.Location = New System.Drawing.Point(112, 272)
        Me.txtTelCasa.MaxLength = 25
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.ReadOnly = True
        Me.txtTelCasa.Size = New System.Drawing.Size(211, 23)
        Me.txtTelCasa.TabIndex = 28
        '
        'lblTelCasa
        '
        Me.lblTelCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelCasa.ForeColor = System.Drawing.Color.Black
        Me.lblTelCasa.Location = New System.Drawing.Point(10, 272)
        Me.lblTelCasa.Name = "lblTelCasa"
        Me.lblTelCasa.Size = New System.Drawing.Size(67, 19)
        Me.lblTelCasa.TabIndex = 27
        Me.lblTelCasa.Text = "Tel. Casa:"
        Me.lblTelCasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(12, 217)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 18)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Edad:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEdad
        '
        Me.txtEdad.AcceptsReturn = True
        Me.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEdad.Location = New System.Drawing.Point(112, 212)
        Me.txtEdad.MaxLength = 25
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(211, 23)
        Me.txtEdad.TabIndex = 22
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(440, 18)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(210, 23)
        Me.txtNoSocio.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(337, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 19)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "No. Asociado"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDireccion
        '
        Me.txtDireccion.AcceptsReturn = True
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(112, 242)
        Me.txtDireccion.MaxLength = 25
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(538, 23)
        Me.txtDireccion.TabIndex = 26
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(12, 249)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 19)
        Me.Label27.TabIndex = 25
        Me.Label27.Text = "Dirección:"
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.Enabled = False
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Acompañado", "Viudo"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(440, 78)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(210, 24)
        Me.cbEstadoCivil.TabIndex = 11
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(337, 83)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 19)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Estado Civil:"
        '
        'txtProfesion
        '
        Me.txtProfesion.AcceptsReturn = True
        Me.txtProfesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProfesion.Location = New System.Drawing.Point(440, 212)
        Me.txtProfesion.MaxLength = 25
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.ReadOnly = True
        Me.txtProfesion.Size = New System.Drawing.Size(210, 23)
        Me.txtProfesion.TabIndex = 24
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(337, 217)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(87, 18)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "Ocupación:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Enabled = False
        Me.dtpFecNac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNac.Location = New System.Drawing.Point(440, 178)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(210, 23)
        Me.dtpFecNac.TabIndex = 20
        Me.dtpFecNac.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(337, 178)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 33)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe3
        '
        Me.txtApe3.AcceptsReturn = True
        Me.txtApe3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe3.Location = New System.Drawing.Point(112, 117)
        Me.txtApe3.MaxLength = 25
        Me.txtApe3.Name = "txtApe3"
        Me.txtApe3.ReadOnly = True
        Me.txtApe3.Size = New System.Drawing.Size(210, 23)
        Me.txtApe3.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(10, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 36)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Apellido de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Casada"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecExtDui
        '
        Me.dtpFecExtDui.Enabled = False
        Me.dtpFecExtDui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecExtDui.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecExtDui.Location = New System.Drawing.Point(112, 177)
        Me.dtpFecExtDui.Name = "dtpFecExtDui"
        Me.dtpFecExtDui.Size = New System.Drawing.Size(210, 23)
        Me.dtpFecExtDui.TabIndex = 18
        Me.dtpFecExtDui.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 34)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Lugar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "extensión DUI:"
        '
        'txtLugDui
        '
        Me.txtLugDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugDui.Location = New System.Drawing.Point(112, 147)
        Me.txtLugDui.MaxLength = 25
        Me.txtLugDui.Name = "txtLugDui"
        Me.txtLugDui.ReadOnly = True
        Me.txtLugDui.Size = New System.Drawing.Size(538, 23)
        Me.txtLugDui.TabIndex = 16
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(112, 18)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(211, 25)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(10, 23)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 19)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Dui:"
        '
        'txtApe2
        '
        Me.txtApe2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe2.Location = New System.Drawing.Point(112, 80)
        Me.txtApe2.MaxLength = 25
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.ReadOnly = True
        Me.txtApe2.Size = New System.Drawing.Size(210, 23)
        Me.txtApe2.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Apellido 2"
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(112, 48)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(211, 23)
        Me.txtNombres.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(10, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 18)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Nombres"
        '
        'txtApe1
        '
        Me.txtApe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe1.Location = New System.Drawing.Point(440, 48)
        Me.txtApe1.MaxLength = 25
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(210, 23)
        Me.txtApe1.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(337, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Apellido 1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 32)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "extensión DUI:"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.lblEstado)
        Me.TabPage1.Controls.Add(Me.MetroButton2)
        Me.TabPage1.Controls.Add(Me.MetroButton4)
        Me.TabPage1.Controls.Add(Me.btnSaveTb1)
        Me.TabPage1.Controls.Add(Me.gbDepositosAutomaticos)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 40)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(695, 595)
        Me.TabPage1.TabIndex = 9
        Me.TabPage1.Text = "Datos de la cuenta"
        '
        'lblEstado
        '
        Me.lblEstado.BackColor = System.Drawing.Color.White
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Green
        Me.lblEstado.Location = New System.Drawing.Point(540, 5)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(134, 18)
        Me.lblEstado.TabIndex = 204
        Me.lblEstado.Text = "Estado Cuenta"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstado.Visible = False
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(406, 543)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 33)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton2.TabIndex = 207
        Me.MetroButton2.Text = "Atrás"
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(503, 543)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(90, 33)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton4.TabIndex = 206
        Me.MetroButton4.Text = "Siguiente"
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'btnSaveTb1
        '
        Me.btnSaveTb1.Location = New System.Drawing.Point(600, 543)
        Me.btnSaveTb1.Name = "btnSaveTb1"
        Me.btnSaveTb1.Size = New System.Drawing.Size(90, 33)
        Me.btnSaveTb1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSaveTb1.TabIndex = 205
        Me.btnSaveTb1.Text = "Guardar"
        Me.btnSaveTb1.UseSelectable = True
        Me.btnSaveTb1.UseStyleColors = True
        '
        'gbDepositosAutomaticos
        '
        Me.gbDepositosAutomaticos.BackColor = System.Drawing.Color.White
        Me.gbDepositosAutomaticos.Controls.Add(Me.c1nMontoTransf)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label37)
        Me.gbDepositosAutomaticos.Controls.Add(Me.txtNoCuentaDepAut)
        Me.gbDepositosAutomaticos.Controls.Add(Me.dtpFecFinDA)
        Me.gbDepositosAutomaticos.Controls.Add(Me.dtpFecIniDA)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label57)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label4)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label16)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label36)
        Me.gbDepositosAutomaticos.Controls.Add(Me.cbTipoDeposito)
        Me.gbDepositosAutomaticos.Controls.Add(Me.Label61)
        Me.gbDepositosAutomaticos.Controls.Add(Me.txtCodTipoAhorroDepAut)
        Me.gbDepositosAutomaticos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDepositosAutomaticos.ForeColor = System.Drawing.Color.Navy
        Me.gbDepositosAutomaticos.Location = New System.Drawing.Point(4, 329)
        Me.gbDepositosAutomaticos.Name = "gbDepositosAutomaticos"
        Me.gbDepositosAutomaticos.Size = New System.Drawing.Size(670, 115)
        Me.gbDepositosAutomaticos.TabIndex = 4
        Me.gbDepositosAutomaticos.TabStop = False
        Me.gbDepositosAutomaticos.Visible = False
        '
        'c1nMontoTransf
        '
        Me.c1nMontoTransf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoTransf.CustomFormat = "###,###,##0.00"
        Me.c1nMontoTransf.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoTransf.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoTransf.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nMontoTransf.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoTransf.Location = New System.Drawing.Point(476, 78)
        Me.c1nMontoTransf.Name = "c1nMontoTransf"
        Me.c1nMontoTransf.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoTransf.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoTransf.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoTransf.Size = New System.Drawing.Size(106, 27)
        Me.c1nMontoTransf.TabIndex = 4
        Me.c1nMontoTransf.Tag = Nothing
        Me.c1nMontoTransf.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoTransf.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.White
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(415, 78)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(48, 19)
        Me.Label37.TabIndex = 216
        Me.Label37.Text = "Monto:"
        '
        'txtNoCuentaDepAut
        '
        Me.txtNoCuentaDepAut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuentaDepAut.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuentaDepAut.Location = New System.Drawing.Point(419, 13)
        Me.txtNoCuentaDepAut.MaxLength = 20
        Me.txtNoCuentaDepAut.Name = "txtNoCuentaDepAut"
        Me.txtNoCuentaDepAut.ReadOnly = True
        Me.txtNoCuentaDepAut.Size = New System.Drawing.Size(163, 23)
        Me.txtNoCuentaDepAut.TabIndex = 1
        '
        'dtpFecFinDA
        '
        Me.dtpFecFinDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecFinDA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFinDA.Location = New System.Drawing.Point(284, 80)
        Me.dtpFecFinDA.Name = "dtpFecFinDA"
        Me.dtpFecFinDA.Size = New System.Drawing.Size(101, 23)
        Me.dtpFecFinDA.TabIndex = 3
        Me.dtpFecFinDA.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'dtpFecIniDA
        '
        Me.dtpFecIniDA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIniDA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIniDA.Location = New System.Drawing.Point(109, 78)
        Me.dtpFecIniDA.Name = "dtpFecIniDA"
        Me.dtpFecIniDA.Size = New System.Drawing.Size(101, 23)
        Me.dtpFecIniDA.TabIndex = 2
        Me.dtpFecIniDA.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(217, 78)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(48, 19)
        Me.Label57.TabIndex = 215
        Me.Label57.Text = "Hasta:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 214
        Me.Label4.Text = "Desde:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(7, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(211, 18)
        Me.Label16.TabIndex = 213
        Me.Label16.Text = "Período del Depósito Automático:"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(7, 15)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(95, 18)
        Me.Label36.TabIndex = 210
        Me.Label36.Text = "Tipo Depósito:"
        '
        'cbTipoDeposito
        '
        Me.cbTipoDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoDeposito.Items.AddRange(New Object() {"Personal", "Por Transferencia"})
        Me.cbTipoDeposito.Location = New System.Drawing.Point(109, 13)
        Me.cbTipoDeposito.Name = "cbTipoDeposito"
        Me.cbTipoDeposito.Size = New System.Drawing.Size(192, 25)
        Me.cbTipoDeposito.TabIndex = 0
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(325, 18)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(77, 19)
        Me.Label61.TabIndex = 158
        Me.Label61.Text = "Cuenta:"
        '
        'txtCodTipoAhorroDepAut
        '
        Me.txtCodTipoAhorroDepAut.Location = New System.Drawing.Point(292, 50)
        Me.txtCodTipoAhorroDepAut.Name = "txtCodTipoAhorroDepAut"
        Me.txtCodTipoAhorroDepAut.Size = New System.Drawing.Size(9, 23)
        Me.txtCodTipoAhorroDepAut.TabIndex = 212
        Me.txtCodTipoAhorroDepAut.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtPignorado)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtNoLibreta)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.c1nTasa)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.c1nMontoApertura)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.dtpFechaApertura)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtDigito)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Green
        Me.GroupBox3.Location = New System.Drawing.Point(4, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(670, 123)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Cuenta"
        '
        'txtPignorado
        '
        Me.txtPignorado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPignorado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPignorado.Location = New System.Drawing.Point(500, 83)
        Me.txtPignorado.MaxLength = 20
        Me.txtPignorado.Name = "txtPignorado"
        Me.txtPignorado.ReadOnly = True
        Me.txtPignorado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPignorado.Size = New System.Drawing.Size(164, 25)
        Me.txtPignorado.TabIndex = 190
        Me.txtPignorado.Text = "No"
        Me.txtPignorado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(407, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 36)
        Me.Label5.TabIndex = 189
        Me.Label5.Text = "Cuenta " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pignorada:"
        '
        'txtNoLibreta
        '
        Me.txtNoLibreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoLibreta.Location = New System.Drawing.Point(500, 15)
        Me.txtNoLibreta.MaxLength = 20
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.Size = New System.Drawing.Size(164, 23)
        Me.txtNoLibreta.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(407, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "No. Libreta:"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.Location = New System.Drawing.Point(101, 15)
        Me.txtNoCuenta.MaxLength = 20
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.ReadOnly = True
        Me.txtNoCuenta.Size = New System.Drawing.Size(211, 26)
        Me.txtNoCuenta.TabIndex = 157
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "No. Cuenta:"
        '
        'c1nTasa
        '
        Me.c1nTasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasa.CustomFormat = "#0.00"
        Me.c1nTasa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTasa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasa.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nTasa.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nTasa.Location = New System.Drawing.Point(101, 83)
        Me.c1nTasa.Name = "c1nTasa"
        Me.c1nTasa.Size = New System.Drawing.Size(211, 27)
        Me.c1nTasa.TabIndex = 11
        Me.c1nTasa.Tag = Nothing
        Me.c1nTasa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasa.Visible = False
        Me.c1nTasa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(7, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 18)
        Me.Label20.TabIndex = 156
        Me.Label20.Text = "Tasa Interés:"
        Me.Label20.Visible = False
        '
        'c1nMontoApertura
        '
        Me.c1nMontoApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoApertura.CustomFormat = "###,###,##0.00"
        Me.c1nMontoApertura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoApertura.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoApertura.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nMontoApertura.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoApertura.Location = New System.Drawing.Point(500, 50)
        Me.c1nMontoApertura.Name = "c1nMontoApertura"
        Me.c1nMontoApertura.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoApertura.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoApertura.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoApertura.Size = New System.Drawing.Size(164, 26)
        Me.c1nMontoApertura.TabIndex = 1
        Me.c1nMontoApertura.Tag = Nothing
        Me.c1nMontoApertura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoApertura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(407, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 36)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Monto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apertura:"
        '
        'dtpFechaApertura
        '
        Me.dtpFechaApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaApertura.Location = New System.Drawing.Point(101, 51)
        Me.dtpFechaApertura.Name = "dtpFechaApertura"
        Me.dtpFechaApertura.Size = New System.Drawing.Size(211, 23)
        Me.dtpFechaApertura.TabIndex = 0
        Me.dtpFechaApertura.Value = New Date(2018, 11, 1, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 36)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apertura:"
        '
        'txtDigito
        '
        Me.txtDigito.Location = New System.Drawing.Point(319, 15)
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(10, 23)
        Me.txtDigito.TabIndex = 193
        Me.txtDigito.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtEjecApertura)
        Me.GroupBox1.Controls.Add(Me.txtCodEjecApertura)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.txtEjecMercadeo)
        Me.GroupBox1.Controls.Add(Me.txtCodEjecMercadeo)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(4, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 172)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtEjecApertura
        '
        Me.txtEjecApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecApertura.Location = New System.Drawing.Point(263, 44)
        Me.txtEjecApertura.MaxLength = 100
        Me.txtEjecApertura.Name = "txtEjecApertura"
        Me.txtEjecApertura.ReadOnly = True
        Me.txtEjecApertura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEjecApertura.Size = New System.Drawing.Size(401, 23)
        Me.txtEjecApertura.TabIndex = 203
        '
        'txtCodEjecApertura
        '
        Me.txtCodEjecApertura.AcceptsReturn = True
        Me.txtCodEjecApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecApertura.Location = New System.Drawing.Point(179, 44)
        Me.txtCodEjecApertura.MaxLength = 10
        Me.txtCodEjecApertura.Name = "txtCodEjecApertura"
        Me.txtCodEjecApertura.Size = New System.Drawing.Size(77, 23)
        Me.txtCodEjecApertura.TabIndex = 1
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(7, 44)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(173, 18)
        Me.Label44.TabIndex = 202
        Me.Label44.Text = "Código Ejecutivo Apertura:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(178, 74)
        Me.txtObs.MaxLength = 255
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(486, 84)
        Me.txtObs.TabIndex = 2
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(7, 77)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(106, 19)
        Me.Label43.TabIndex = 171
        Me.Label43.Text = "Observaciones:"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(7, 18)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(163, 19)
        Me.Label46.TabIndex = 170
        Me.Label46.Text = "Código Ejecutivo Gestión:"
        '
        'txtEjecMercadeo
        '
        Me.txtEjecMercadeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecMercadeo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeo.Location = New System.Drawing.Point(262, 14)
        Me.txtEjecMercadeo.MaxLength = 100
        Me.txtEjecMercadeo.Name = "txtEjecMercadeo"
        Me.txtEjecMercadeo.ReadOnly = True
        Me.txtEjecMercadeo.Size = New System.Drawing.Size(402, 23)
        Me.txtEjecMercadeo.TabIndex = 169
        '
        'txtCodEjecMercadeo
        '
        Me.txtCodEjecMercadeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecMercadeo.Location = New System.Drawing.Point(178, 14)
        Me.txtCodEjecMercadeo.MaxLength = 10
        Me.txtCodEjecMercadeo.Name = "txtCodEjecMercadeo"
        Me.txtCodEjecMercadeo.Size = New System.Drawing.Size(76, 23)
        Me.txtCodEjecMercadeo.TabIndex = 0
        '
        'tabDatGralII
        '
        Me.tabDatGralII.BackColor = System.Drawing.Color.White
        Me.tabDatGralII.Controls.Add(Me.MetroButton1)
        Me.tabDatGralII.Controls.Add(Me.MetroButton3)
        Me.tabDatGralII.Controls.Add(Me.btnSaveTb3)
        Me.tabDatGralII.Controls.Add(Me.fgPig)
        Me.tabDatGralII.Controls.Add(Me.Label19)
        Me.tabDatGralII.Controls.Add(Me.gbPig)
        Me.tabDatGralII.Controls.Add(Me.gbCancela)
        Me.tabDatGralII.Controls.Add(Me.btnCerrarTb3)
        Me.tabDatGralII.Location = New System.Drawing.Point(4, 40)
        Me.tabDatGralII.Name = "tabDatGralII"
        Me.tabDatGralII.Size = New System.Drawing.Size(695, 595)
        Me.tabDatGralII.TabIndex = 5
        Me.tabDatGralII.Text = "Pignoraciones / Cancelaciones"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(392, 545)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 210
        Me.MetroButton1.Text = "Atrás"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(490, 545)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton3.TabIndex = 209
        Me.MetroButton3.Text = "Siguiente"
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'btnSaveTb3
        '
        Me.btnSaveTb3.Location = New System.Drawing.Point(587, 545)
        Me.btnSaveTb3.Name = "btnSaveTb3"
        Me.btnSaveTb3.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb3.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSaveTb3.TabIndex = 208
        Me.btnSaveTb3.Text = "Guardar"
        Me.btnSaveTb3.UseSelectable = True
        Me.btnSaveTb3.UseStyleColors = True
        '
        'fgPig
        '
        Me.fgPig.AllowEditing = False
        Me.fgPig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgPig.BackColor = System.Drawing.Color.White
        Me.fgPig.ColumnInfo = "10,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgPig.Location = New System.Drawing.Point(10, 185)
        Me.fgPig.Name = "fgPig"
        Me.fgPig.Rows.Count = 1
        Me.fgPig.Rows.DefaultSize = 21
        Me.fgPig.Size = New System.Drawing.Size(669, 163)
        Me.fgPig.StyleInfo = resources.GetString("fgPig.StyleInfo")
        Me.fgPig.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Green
        Me.Label19.Location = New System.Drawing.Point(6, 163)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(202, 18)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Historial de Pignoraciones"
        '
        'gbPig
        '
        Me.gbPig.Controls.Add(Me.txtPlazo)
        Me.gbPig.Controls.Add(Me.Label58)
        Me.gbPig.Controls.Add(Me.txtVenc)
        Me.gbPig.Controls.Add(Me.Label55)
        Me.gbPig.Controls.Add(Me.txtApertura)
        Me.gbPig.Controls.Add(Me.Label56)
        Me.gbPig.Controls.Add(Me.txtCodPrestamo)
        Me.gbPig.Controls.Add(Me.Label52)
        Me.gbPig.Controls.Add(Me.txtSaldo)
        Me.gbPig.Controls.Add(Me.txtMontoPignorado)
        Me.gbPig.Controls.Add(Me.Label17)
        Me.gbPig.Controls.Add(Me.Label18)
        Me.gbPig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPig.ForeColor = System.Drawing.Color.Green
        Me.gbPig.Location = New System.Drawing.Point(10, 9)
        Me.gbPig.Name = "gbPig"
        Me.gbPig.Size = New System.Drawing.Size(669, 150)
        Me.gbPig.TabIndex = 0
        Me.gbPig.TabStop = False
        Me.gbPig.Text = "Datos Préstamo Pignorado:"
        '
        'txtPlazo
        '
        Me.txtPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlazo.Culture = 17418
        Me.txtPlazo.CustomFormat = "#0.00"
        Me.txtPlazo.Enabled = False
        Me.txtPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtPlazo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtPlazo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtPlazo.Location = New System.Drawing.Point(439, 75)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.Size = New System.Drawing.Size(210, 27)
        Me.txtPlazo.TabIndex = 201
        Me.txtPlazo.Tag = Nothing
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPlazo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(362, 81)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(48, 18)
        Me.Label58.TabIndex = 200
        Me.Label58.Text = "Plazo:"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVenc
        '
        Me.txtVenc.Enabled = False
        Me.txtVenc.Location = New System.Drawing.Point(142, 76)
        Me.txtVenc.Name = "txtVenc"
        Me.txtVenc.ReadOnly = True
        Me.txtVenc.Size = New System.Drawing.Size(213, 23)
        Me.txtVenc.TabIndex = 199
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(7, 81)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(106, 18)
        Me.Label55.TabIndex = 198
        Me.Label55.Text = "Vencimiento:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApertura
        '
        Me.txtApertura.Enabled = False
        Me.txtApertura.Location = New System.Drawing.Point(439, 39)
        Me.txtApertura.Name = "txtApertura"
        Me.txtApertura.ReadOnly = True
        Me.txtApertura.Size = New System.Drawing.Size(210, 23)
        Me.txtApertura.TabIndex = 197
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(362, 39)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(68, 19)
        Me.Label56.TabIndex = 196
        Me.Label56.Text = "Apertura:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.AcceptsReturn = True
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Location = New System.Drawing.Point(142, 39)
        Me.txtCodPrestamo.MaxLength = 20
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(210, 23)
        Me.txtCodPrestamo.TabIndex = 0
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(7, 28)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(106, 41)
        Me.Label52.TabIndex = 195
        Me.Label52.Text = "Cód. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Préstamo:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldo
        '
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(439, 111)
        Me.txtSaldo.MaxLength = 20
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSaldo.Size = New System.Drawing.Size(210, 25)
        Me.txtSaldo.TabIndex = 193
        '
        'txtMontoPignorado
        '
        Me.txtMontoPignorado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoPignorado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPignorado.Location = New System.Drawing.Point(142, 111)
        Me.txtMontoPignorado.MaxLength = 20
        Me.txtMontoPignorado.Name = "txtMontoPignorado"
        Me.txtMontoPignorado.ReadOnly = True
        Me.txtMontoPignorado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMontoPignorado.Size = New System.Drawing.Size(213, 25)
        Me.txtMontoPignorado.TabIndex = 192
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(362, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 18)
        Me.Label17.TabIndex = 191
        Me.Label17.Text = "Saldo:"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(10, 114)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 24)
        Me.Label18.TabIndex = 190
        Me.Label18.Text = "Monto Pignorado:"
        '
        'gbCancela
        '
        Me.gbCancela.BackColor = System.Drawing.Color.White
        Me.gbCancela.Controls.Add(Me.dtpFecCanc)
        Me.gbCancela.Controls.Add(Me.Label30)
        Me.gbCancela.Controls.Add(Me.txtEjecMercadeoCanc)
        Me.gbCancela.Controls.Add(Me.txtCodEjecCanc)
        Me.gbCancela.Controls.Add(Me.Label1)
        Me.gbCancela.Controls.Add(Me.txtMotivoCancela)
        Me.gbCancela.Controls.Add(Me.Label45)
        Me.gbCancela.Enabled = False
        Me.gbCancela.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCancela.ForeColor = System.Drawing.Color.Green
        Me.gbCancela.Location = New System.Drawing.Point(10, 340)
        Me.gbCancela.Name = "gbCancela"
        Me.gbCancela.Size = New System.Drawing.Size(669, 169)
        Me.gbCancela.TabIndex = 2
        Me.gbCancela.TabStop = False
        Me.gbCancela.Text = "Cancelación de Cuenta"
        '
        'dtpFecCanc
        '
        Me.dtpFecCanc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCanc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCanc.Location = New System.Drawing.Point(181, 47)
        Me.dtpFecCanc.Name = "dtpFecCanc"
        Me.dtpFecCanc.Size = New System.Drawing.Size(101, 23)
        Me.dtpFecCanc.TabIndex = 0
        Me.dtpFecCanc.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(18, 130)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(115, 19)
        Me.Label30.TabIndex = 176
        Me.Label30.Text = "Código Ejecutivo:"
        '
        'txtEjecMercadeoCanc
        '
        Me.txtEjecMercadeoCanc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecMercadeoCanc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeoCanc.Location = New System.Drawing.Point(268, 130)
        Me.txtEjecMercadeoCanc.MaxLength = 100
        Me.txtEjecMercadeoCanc.Name = "txtEjecMercadeoCanc"
        Me.txtEjecMercadeoCanc.ReadOnly = True
        Me.txtEjecMercadeoCanc.Size = New System.Drawing.Size(381, 23)
        Me.txtEjecMercadeoCanc.TabIndex = 175
        '
        'txtCodEjecCanc
        '
        Me.txtCodEjecCanc.AcceptsReturn = True
        Me.txtCodEjecCanc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecCanc.Location = New System.Drawing.Point(181, 130)
        Me.txtCodEjecCanc.MaxLength = 10
        Me.txtCodEjecCanc.Name = "txtCodEjecCanc"
        Me.txtCodEjecCanc.Size = New System.Drawing.Size(77, 23)
        Me.txtCodEjecCanc.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 19)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "Fecha de Cancelación:"
        '
        'txtMotivoCancela
        '
        Me.txtMotivoCancela.AcceptsReturn = True
        Me.txtMotivoCancela.Location = New System.Drawing.Point(181, 84)
        Me.txtMotivoCancela.Multiline = True
        Me.txtMotivoCancela.Name = "txtMotivoCancela"
        Me.txtMotivoCancela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoCancela.Size = New System.Drawing.Size(468, 37)
        Me.txtMotivoCancela.TabIndex = 1
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(18, 84)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(154, 19)
        Me.Label45.TabIndex = 172
        Me.Label45.Text = "Motivo de Cancelación:"
        '
        'btnCerrarTb3
        '
        Me.btnCerrarTb3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrarTb3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrarTb3.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarTb3.Image = CType(resources.GetObject("btnCerrarTb3.Image"), System.Drawing.Image)
        Me.btnCerrarTb3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarTb3.Location = New System.Drawing.Point(724, 545)
        Me.btnCerrarTb3.Name = "btnCerrarTb3"
        Me.btnCerrarTb3.Size = New System.Drawing.Size(96, 26)
        Me.btnCerrarTb3.TabIndex = 6
        Me.btnCerrarTb3.Text = "     &Cerrar"
        Me.btnCerrarTb3.UseVisualStyleBackColor = False
        '
        'tbBeneficiarios
        '
        Me.tbBeneficiarios.BackColor = System.Drawing.Color.White
        Me.tbBeneficiarios.Controls.Add(Me.MetroButton6)
        Me.tbBeneficiarios.Controls.Add(Me.MetroButton7)
        Me.tbBeneficiarios.Controls.Add(Me.btnCerrar2)
        Me.tbBeneficiarios.Controls.Add(Me.GroupBox7)
        Me.tbBeneficiarios.Location = New System.Drawing.Point(4, 40)
        Me.tbBeneficiarios.Name = "tbBeneficiarios"
        Me.tbBeneficiarios.Size = New System.Drawing.Size(695, 595)
        Me.tbBeneficiarios.TabIndex = 4
        Me.tbBeneficiarios.Text = "Beneficiarios"
        Me.tbBeneficiarios.Visible = False
        '
        'MetroButton6
        '
        Me.MetroButton6.Location = New System.Drawing.Point(494, 543)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(90, 33)
        Me.MetroButton6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton6.TabIndex = 209
        Me.MetroButton6.Text = "Atrás"
        Me.MetroButton6.UseSelectable = True
        Me.MetroButton6.UseStyleColors = True
        '
        'MetroButton7
        '
        Me.MetroButton7.Location = New System.Drawing.Point(592, 543)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(90, 33)
        Me.MetroButton7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton7.TabIndex = 208
        Me.MetroButton7.Text = "Siguiente"
        Me.MetroButton7.UseSelectable = True
        Me.MetroButton7.UseStyleColors = True
        '
        'btnCerrar2
        '
        Me.btnCerrar2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar2.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar2.Image = CType(resources.GetObject("btnCerrar2.Image"), System.Drawing.Image)
        Me.btnCerrar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar2.Location = New System.Drawing.Point(702, 545)
        Me.btnCerrar2.Name = "btnCerrar2"
        Me.btnCerrar2.Size = New System.Drawing.Size(96, 26)
        Me.btnCerrar2.TabIndex = 3
        Me.btnCerrar2.Text = "     &Cerrar"
        Me.btnCerrar2.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.btDelBen)
        Me.GroupBox7.Controls.Add(Me.btEditBen)
        Me.GroupBox7.Controls.Add(Me.btNewBen)
        Me.GroupBox7.Controls.Add(Me.fgBen)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Green
        Me.GroupBox7.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(672, 528)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Beneficiarios"
        '
        'btDelBen
        '
        Me.btDelBen.Location = New System.Drawing.Point(202, 25)
        Me.btDelBen.Name = "btDelBen"
        Me.btDelBen.Size = New System.Drawing.Size(90, 33)
        Me.btDelBen.Style = MetroFramework.MetroColorStyle.Green
        Me.btDelBen.TabIndex = 213
        Me.btDelBen.Text = "Eliminar"
        Me.btDelBen.UseSelectable = True
        Me.btDelBen.UseStyleColors = True
        '
        'btEditBen
        '
        Me.btEditBen.Location = New System.Drawing.Point(104, 25)
        Me.btEditBen.Name = "btEditBen"
        Me.btEditBen.Size = New System.Drawing.Size(90, 33)
        Me.btEditBen.Style = MetroFramework.MetroColorStyle.Green
        Me.btEditBen.TabIndex = 212
        Me.btEditBen.Text = "Modificar"
        Me.btEditBen.UseSelectable = True
        Me.btEditBen.UseStyleColors = True
        '
        'btNewBen
        '
        Me.btNewBen.Location = New System.Drawing.Point(7, 25)
        Me.btNewBen.Name = "btNewBen"
        Me.btNewBen.Size = New System.Drawing.Size(90, 33)
        Me.btNewBen.Style = MetroFramework.MetroColorStyle.Green
        Me.btNewBen.TabIndex = 211
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
        Me.fgBen.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgBen.ForeColor = System.Drawing.Color.Green
        Me.fgBen.Location = New System.Drawing.Point(7, 65)
        Me.fgBen.Name = "fgBen"
        Me.fgBen.Rows.Count = 1
        Me.fgBen.Rows.DefaultSize = 22
        Me.fgBen.Size = New System.Drawing.Size(658, 444)
        Me.fgBen.StyleInfo = resources.GetString("fgBen.StyleInfo")
        Me.fgBen.TabIndex = 3
        '
        'tbLibRep
        '
        Me.tbLibRep.BackColor = System.Drawing.Color.White
        Me.tbLibRep.Controls.Add(Me.MetroButton5)
        Me.tbLibRep.Controls.Add(Me.btnSaveTb7)
        Me.tbLibRep.Controls.Add(Me.GroupBox4)
        Me.tbLibRep.Controls.Add(Me.btnCerrarTb7)
        Me.tbLibRep.Controls.Add(Me.ckbCobroDomicilio)
        Me.tbLibRep.Controls.Add(Me.grbRutaCobro)
        Me.tbLibRep.Location = New System.Drawing.Point(4, 40)
        Me.tbLibRep.Name = "tbLibRep"
        Me.tbLibRep.Size = New System.Drawing.Size(695, 595)
        Me.tbLibRep.TabIndex = 8
        Me.tbLibRep.Text = "Reposición de Libreta / Cobro a Domicilio"
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(503, 545)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton5.TabIndex = 209
        Me.MetroButton5.Text = "Atrás"
        Me.MetroButton5.UseSelectable = True
        Me.MetroButton5.UseStyleColors = True
        '
        'btnSaveTb7
        '
        Me.btnSaveTb7.Location = New System.Drawing.Point(600, 543)
        Me.btnSaveTb7.Name = "btnSaveTb7"
        Me.btnSaveTb7.Size = New System.Drawing.Size(90, 33)
        Me.btnSaveTb7.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSaveTb7.TabIndex = 208
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
        Me.GroupBox4.ForeColor = System.Drawing.Color.Green
        Me.GroupBox4.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(680, 301)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reposición de Libreta"
        '
        'btDelR
        '
        Me.btDelR.Location = New System.Drawing.Point(202, 22)
        Me.btDelR.Name = "btDelR"
        Me.btDelR.Size = New System.Drawing.Size(90, 32)
        Me.btDelR.Style = MetroFramework.MetroColorStyle.Green
        Me.btDelR.TabIndex = 216
        Me.btDelR.Text = "Eliminar"
        Me.btDelR.UseSelectable = True
        Me.btDelR.UseStyleColors = True
        '
        'btEditR
        '
        Me.btEditR.Location = New System.Drawing.Point(104, 22)
        Me.btEditR.Name = "btEditR"
        Me.btEditR.Size = New System.Drawing.Size(90, 32)
        Me.btEditR.Style = MetroFramework.MetroColorStyle.Green
        Me.btEditR.TabIndex = 215
        Me.btEditR.Text = "Modificar"
        Me.btEditR.UseSelectable = True
        Me.btEditR.UseStyleColors = True
        '
        'btNewR
        '
        Me.btNewR.Location = New System.Drawing.Point(7, 22)
        Me.btNewR.Name = "btNewR"
        Me.btNewR.Size = New System.Drawing.Size(90, 32)
        Me.btNewR.Style = MetroFramework.MetroColorStyle.Green
        Me.btNewR.TabIndex = 214
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
        Me.fgR.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgR.ForeColor = System.Drawing.Color.Green
        Me.fgR.Location = New System.Drawing.Point(7, 61)
        Me.fgR.Name = "fgR"
        Me.fgR.Rows.Count = 1
        Me.fgR.Rows.DefaultSize = 22
        Me.fgR.Size = New System.Drawing.Size(666, 222)
        Me.fgR.StyleInfo = resources.GetString("fgR.StyleInfo")
        Me.fgR.TabIndex = 3
        '
        'btnCerrarTb7
        '
        Me.btnCerrarTb7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrarTb7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrarTb7.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarTb7.Image = CType(resources.GetObject("btnCerrarTb7.Image"), System.Drawing.Image)
        Me.btnCerrarTb7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarTb7.Location = New System.Drawing.Point(734, 545)
        Me.btnCerrarTb7.Name = "btnCerrarTb7"
        Me.btnCerrarTb7.Size = New System.Drawing.Size(96, 26)
        Me.btnCerrarTb7.TabIndex = 5
        Me.btnCerrarTb7.Text = "     &Cerrar"
        Me.btnCerrarTb7.UseVisualStyleBackColor = False
        '
        'ckbCobroDomicilio
        '
        Me.ckbCobroDomicilio.Enabled = False
        Me.ckbCobroDomicilio.Location = New System.Drawing.Point(10, 317)
        Me.ckbCobroDomicilio.Name = "ckbCobroDomicilio"
        Me.ckbCobroDomicilio.Size = New System.Drawing.Size(182, 19)
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
        Me.grbRutaCobro.ForeColor = System.Drawing.Color.Green
        Me.grbRutaCobro.Location = New System.Drawing.Point(10, 343)
        Me.grbRutaCobro.Name = "grbRutaCobro"
        Me.grbRutaCobro.Size = New System.Drawing.Size(680, 194)
        Me.grbRutaCobro.TabIndex = 2
        Me.grbRutaCobro.TabStop = False
        Me.grbRutaCobro.Text = "Datos Ruta de Cobro:"
        '
        'txtCodCobrador
        '
        Me.txtCodCobrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCobrador.Location = New System.Drawing.Point(192, 157)
        Me.txtCodCobrador.MaxLength = 2
        Me.txtCodCobrador.Name = "txtCodCobrador"
        Me.txtCodCobrador.Size = New System.Drawing.Size(77, 22)
        Me.txtCodCobrador.TabIndex = 5
        '
        'txtCobrador
        '
        Me.txtCobrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCobrador.Location = New System.Drawing.Point(278, 157)
        Me.txtCobrador.MaxLength = 30
        Me.txtCobrador.Name = "txtCobrador"
        Me.txtCobrador.ReadOnly = True
        Me.txtCobrador.Size = New System.Drawing.Size(395, 22)
        Me.txtCobrador.TabIndex = 120
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(10, 157)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(105, 18)
        Me.Label32.TabIndex = 119
        Me.Label32.Text = "Cobrador:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(192, 120)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(58, 22)
        Me.txtDia.TabIndex = 3
        '
        'txtDireccionCobro
        '
        Me.txtDireccionCobro.Location = New System.Drawing.Point(192, 83)
        Me.txtDireccionCobro.Multiline = True
        Me.txtDireccionCobro.Name = "txtDireccionCobro"
        Me.txtDireccionCobro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccionCobro.Size = New System.Drawing.Size(481, 28)
        Me.txtDireccionCobro.TabIndex = 2
        '
        'Label51
        '
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(10, 87)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(134, 26)
        Me.Label51.TabIndex = 117
        Me.Label51.Text = "Dirección de Cobro:"
        '
        'Label50
        '
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(275, 120)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(134, 27)
        Me.Label50.TabIndex = 116
        Me.Label50.Text = "Fecha de Caducidad:"
        '
        'Label49
        '
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(10, 114)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(153, 27)
        Me.Label49.TabIndex = 115
        Me.Label49.Text = "Día:"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaCuota
        '
        Me.dtpFechaCuota.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCuota.Location = New System.Drawing.Point(416, 118)
        Me.dtpFechaCuota.Name = "dtpFechaCuota"
        Me.dtpFechaCuota.Size = New System.Drawing.Size(116, 22)
        Me.dtpFechaCuota.TabIndex = 4
        '
        'txtCodDpto
        '
        Me.txtCodDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDpto.Location = New System.Drawing.Point(192, 28)
        Me.txtCodDpto.MaxLength = 2
        Me.txtCodDpto.Name = "txtCodDpto"
        Me.txtCodDpto.Size = New System.Drawing.Size(77, 22)
        Me.txtCodDpto.TabIndex = 0
        '
        'txtDpto
        '
        Me.txtDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDpto.Location = New System.Drawing.Point(278, 28)
        Me.txtDpto.MaxLength = 30
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.ReadOnly = True
        Me.txtDpto.Size = New System.Drawing.Size(395, 22)
        Me.txtDpto.TabIndex = 112
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(10, 28)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(172, 18)
        Me.Label47.TabIndex = 111
        Me.Label47.Text = "*Departamento Residencia:"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodMun
        '
        Me.txtCodMun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMun.Location = New System.Drawing.Point(192, 55)
        Me.txtCodMun.MaxLength = 2
        Me.txtCodMun.Name = "txtCodMun"
        Me.txtCodMun.Size = New System.Drawing.Size(77, 22)
        Me.txtCodMun.TabIndex = 1
        '
        'txtMunicipio
        '
        Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMunicipio.Location = New System.Drawing.Point(278, 55)
        Me.txtMunicipio.MaxLength = 100
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.ReadOnly = True
        Me.txtMunicipio.Size = New System.Drawing.Size(395, 22)
        Me.txtMunicipio.TabIndex = 110
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(10, 55)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(172, 19)
        Me.Label48.TabIndex = 109
        Me.Label48.Text = "*Municipio Residencia:"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMsAhCuentasAportacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(785, 732)
        Me.Controls.Add(Me.tbSolic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhCuentasAportacion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Cuentas de Aportación"
        Me.tbSolic.ResumeLayout(False)
        Me.tbDatGral.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.gbDepositosAutomaticos.ResumeLayout(False)
        Me.gbDepositosAutomaticos.PerformLayout()
        CType(Me.c1nMontoTransf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoApertura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabDatGralII.ResumeLayout(False)
        CType(Me.fgPig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPig.ResumeLayout(False)
        Me.gbPig.PerformLayout()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCancela.ResumeLayout(False)
        Me.gbCancela.PerformLayout()
        Me.tbBeneficiarios.ResumeLayout(False)
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

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, vConsulta As Boolean
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
    Private Sub frmMsAhCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim dtsCodAport As New DataSet
            dtsCodAport = Ahorro.ConsultarTipoAhorro("codTipoAhorro", "left(codTipoAhorro,1)= '" & libAhorro.tiposAhorro.aportaciones & "'",
                                                 "codTipoAhorro", sUsuario, sPassword, sSucursal)
            codApor = dtsCodAport.Tables(0).Rows(0).Item("codTipoAhorro").ToString



            Dim oPerif As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, x As Integer, oPrest As New wrPrestamo.wsLibPrest
            Dim oPl As New wrPlanilla.wsLibPlanilla, dr As DataRow, FechaNac As Date

            Me.txtDui.Focus()

            Me.cbTipoDeposito.SelectedIndex = 0
            Me.dtpFecIniDA.Value = Now
            Me.dtpFecFinDA.Value = Now
            Me.cbDoc.SelectedIndex = 0
            Me.dtpFechaApertura.Value = Now

            ds = oPerif.ConsultarParametros("*", "CodTipoAhorro='" & codApor & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables("AhParametros").Rows
            If Filas.Count > 0 Then
                dr = ds.Tables("AhParametros").Rows(0)
                Me.c1nTasa.Value = IIf(IsDBNull(dr("TasaInteres")), 0, dr("TasaInteres"))
            End If

            Dim dsTemp As New DataSet, drTemp As DataRow
            dsTemp = oAsoc.ConsultarParentescos("*", "", "CodParentesco", sUsuario, sPassword, sSucursal)
            For Each drTemp In dsTemp.Tables(0).Rows
                cbParentesco.Items.Add(CStr(drTemp("CodParentesco")).Trim & " - " & CStr(drTemp("Descripcion")).Trim)
                cbPar.Items.Add(CStr(drTemp("Descripcion")).Trim)
            Next

            Me.cbParentesco.SelectedIndex = 0
            Me.cbPar.SelectedIndex = 0
            llenarEstadoCivil()
            If Me.pAccion = "Modificar" Then

                ds = oPerif.ConsultarCuentaAhorro("*", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtDui.Value = IIf(IsDBNull(Filas.Item(0)("Dui")), "", Filas.Item(0)("Dui"))
                    Me.txtNoCuenta.Text = pNoCuenta
                    Me.dtpFechaApertura.Value = IIf(IsDBNull(Filas.Item(0)("FechaApertura")), Now, Filas.Item(0)("FechaApertura"))
                    Me.c1nMontoApertura.Value = IIf(IsDBNull(Filas.Item(0)("MontoApertura")), 0, Filas.Item(0)("MontoApertura"))
                    Me.c1nTasa.Value = IIf(IsDBNull(Filas.Item(0)("TasaInteres")), 0, Filas.Item(0)("TasaInteres"))
                    Me.txtTitular2.Text = IIf(IsDBNull(Filas.Item(0)("Titular2")), "", Filas.Item(0)("Titular2"))
                    Me.cbDoc.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("TipoDocTit2")), 5, Filas.Item(0)("TipoDocTit2"))
                    Me.txtPartida.Text = IIf(IsDBNull(Filas.Item(0)("PartidaNacTitular2")), "", Filas.Item(0)("PartidaNacTitular2"))
                    Me.txtNoLibreta.Text = IIf(IsDBNull(Filas.Item(0)("NoLibreta")), "", Filas.Item(0)("NoLibreta"))
                    Me.txtCodEjecMercadeo.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecutivo")), "", Filas.Item(0)("CodEjecutivo"))
                    Me.txtPignorado.Text = IIf(IIf(IsDBNull(Filas.Item(0)("Pignorado")), "N", Filas.Item(0)("Pignorado")) = "S", "Si", "No")
                    Me.txtCelT2.Text = IIf(IsDBNull(Filas.Item(0)("CelTit2")), "", Filas.Item(0)("CelTit2"))
                    Me.txtCodEjecApertura.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecApertura")), "", Filas.Item(0)("CodEjecApertura"))
                    Me.txtObs.Text = IIf(IsDBNull(Filas.Item(0)("Observacion")), "", Filas.Item(0)("Observacion"))
                    FechaNac = dtpFecNacT2.Value.Day & "/" & dtpFecNacT2.Value.Month & "/" & Now().Year
                    Me.txtEdadT2.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNacT2.Value, Now())

                    Me.cbTipoDeposito.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("TipoDeposito")), 0, Filas.Item(0)("TipoDeposito"))
                    Me.txtNoCuentaDepAut.Text = IIf(IsDBNull(Filas.Item(0)("NoCuentaDeposito")), "", Filas.Item(0)("NoCuentaDeposito"))
                    Me.txtCodTipoAhorroDepAut.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoAhorroDep")), "", Filas.Item(0)("CodTipoAhorroDep"))
                    Me.dtpFecIniDA.Value = IIf(IsDBNull(Filas.Item(0)("FecIniDep")), Now, Filas.Item(0)("FecIniDep"))
                    Me.dtpFecFinDA.Value = IIf(IsDBNull(Filas.Item(0)("FecFinDep")), Now, Filas.Item(0)("FecFinDep"))
                    Me.c1nMontoTransf.Value = IIf(IsDBNull(Filas.Item(0)("Cuota")), 0, Filas.Item(0)("Cuota"))

                    For x = 0 To cbParentesco.Items.Count - 1
                        cbParentesco.SelectedIndex = x
                        If Mid(cbParentesco.Text, 1, 5).Trim = Trim(IIf(IsDBNull(Filas.Item(0)("CodParentesco")), "", Filas.Item(0)("CodParentesco"))) Then
                            cbParentesco.SelectedIndex = x
                            cbPar.SelectedIndex = x
                            Exit For
                        End If
                    Next

                    If Me.txtPignorado.Text.Trim = "Si" Then
                        ds = oPerif.ConsultarCuentaPignorada("*", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "' and Estado='N'", "Correlativo", sUsuario, sPassword, sSucursal)
                        If ds.Tables("AhPignoraciones").Rows.Count > 0 Then
                            dr = ds.Tables("AhPignoraciones").Rows(0)
                            txtCodPrestamo.Text = dr("CodPrestamo")
                            ds = oPrest.CargaDatosPrestamo(Me.txtCodPrestamo.Text.Trim, sUsuario, sPassword, sSucursal)
                            If ds.Tables("Prestamo").Rows.Count > 0 Then
                                dr = ds.Tables("Prestamo").Rows(0)
                                Me.txtSaldo.Text = IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital"))
                                Me.txtPlazo.Value = IIf(IsDBNull(dr("PlazoMeses")), 0, dr("PlazoMeses"))
                                Me.txtMontoPignorado.Text = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
                                Me.txtApertura.Text = IIf(IsDBNull(dr("FechaOtorgamiento")), "", dr("FechaOtorgamiento"))
                                Me.txtVenc.Text = IIf(IsDBNull(dr("FechaVencimiento")), "", dr("FechaVencimiento"))
                            End If
                        End If
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

                    ds = oPerif.CargarDatosPrestamosPignorados("distinct a.CodPrestamo,b.FechaOtorgamiento as Fecha_Apertura,FechaVencimiento as Fecha_Vencimiento,b.Monto, b.PlazoMeses as Plazo", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", sUsuario, sPassword, sSucursal)
                    Me.fgPig.DataSource = ds.Tables("AhPignoraciones")

                    ds = oPerif.ConsultarBeneficiarios("*", "NoCuenta=" & Trim(txtNoCuenta.Text) & " and CodTipoAhorro='" & codApor & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgBen.DataSource = ds.Tables(0)
                    ActualizaGridBen()

                    ds = oPerif.ConsultarReposicionLibreta("*", "NoCuenta=" & Trim(txtNoCuenta.Text) & " and CodTipoAhorro='" & codApor & "'", "NoSolicitud", sUsuario, sPassword, sSucursal)
                    Me.fgR.DataSource = ds.Tables(0)
                    ActualizaGridR()

                    Dim pCodProf As String

                    ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,telCasa,celular,nosocio", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then

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


                        Me.txtNoSocio.Text = IIf((Filas.Item(0)("NoSocio")) Is DBNull.Value, " ", Filas.Item(0)("NoSocio"))


                        If DateTime.IsLeapYear(Me.dtpFecNac.Value.Year) = True And Me.dtpFecNac.Value.Day = 29 And Me.dtpFecNac.Value.Month = 2 Then
                            FechaNac = "28/" & dtpFecNac.Value.Month & "/" & Now().Year
                        Else
                            FechaNac = dtpFecNac.Value.Day & "/" & dtpFecNac.Value.Month & "/" & Now().Year
                        End If
                        Me.txtEdad.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNac.Value, Now())

                    End If

                    Dim dsRutasCobro As Data.DataSet, drRutasCobro As DataRow, dsGen As DataSet, drGen As DataRow, dsGenI As DataSet, drGenI As DataRow
                    dsRutasCobro = oPerif.ConsultarRutasCobro("*", "CodTipoAhorro='" & pCodTipoAhorro & "' and NoCuenta='" & pNoCuenta & "'", "CodRutaCobro", sUsuario, sPassword, sSucursal)
                    If dsRutasCobro.Tables("AhRutasCobro").Rows.Count > 0 Then
                        Me.ckbCobroDomicilio.Checked = True
                        Me.ckbCobroDomicilio_CheckedChanged(sender, e)
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
                End If

                Me.txtDui.Enabled = False
                Me.txtNombres.Enabled = False
                Me.txtApe1.Enabled = False
                Me.txtApe2.Enabled = False
                Me.txtNoCuenta.Enabled = False
                btnSaveTb1.Text = "&Modificar"
                btnSaveTb3.Text = "&Modificar"
                Me.dtpFechaApertura.Focus()
                '=========================================================================
                '18/04/2012 Javier Escobar
                'Deshabilitamos el control para que no puedan modificar al ejecutivo
                Me.txtCodEjecApertura.ReadOnly = True
                Me.txtCodEjecApertura.Enabled = False
                Me.txtCodEjecMercadeo.ReadOnly = True
                Me.txtCodEjecMercadeo.Enabled = False
                Me.txtEjecApertura.Enabled = False
                Me.txtEjecMercadeo.Enabled = False
                '=========================================================================
            Else 'Guardar
                'Me.txtNoCuenta.Text = oPerif.GeneraNoCuenta(codApor, sSucursal, "04", Me.dtpFechaApertura.Value.Month, Me.dtpFechaApertura.Value.Year, sUsuario, sPassword, sSucursal)
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
    Private Sub btnCerrarTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarTb3.Click
        Me.Dispose()
    End Sub

    Private Sub btnCerrar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar2.Click
        Me.Dispose()
    End Sub

    Private Sub btnCerrarTb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
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
            Me.fgBen.Cols.Item(7).Caption = "Nombres"
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
                If vConsulta = True Then
                    Me.btDelBen.Enabled = False
                Else
                    Me.btDelBen.Enabled = True
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnSigTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub btnSaveTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub c1nTasa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles c1nTasa.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub btDelBen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btEditBen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btNewBen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub fgBen_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgBen.DoubleClick
        btEditBen_Click(sender, e)
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Try
            Dim ofrm As New frmAGenerico

            ofrm.Text = "Buscar Asociados"
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection, pCodProf As String

            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2", "EstadoIngreso='2' and EstadoAsociado='25'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtDui.Value = ofrm.Resultado.Trim
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,EstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso='2' and EstadoAsociado='25'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                txtNombres.Text = CStr(Filas.Item(0)("Nombres")).Trim
                txtApe1.Text = CStr(Filas.Item(0)("Apellido1")).Trim
                txtApe2.Text = CStr(Filas.Item(0)("Apellido2")).Trim
                txtApe3.Text = CStr(Filas.Item(0)("ApellidoCas")).Trim
                txtDireccion.Text = CStr(Filas.Item(0)("Direccion")).Trim
                cbEstadoCivil.SelectedIndex = CStr(Filas.Item(0)("EstadoCivil"))
                txtLugDui.Text = CStr(Filas.Item(0)("LugarExtDUI")).Trim
                dtpFecExtDui.Value = CDate(Filas.Item(0)("FechaExtDUI"))
                dtpFecNac.Value = CDate(Filas.Item(0)("Fecha_Nac"))
                txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                txtTelCasa.Text = CStr(Filas.Item(0)("TelCasa")).Trim
                txtTelOfic.Text = CStr(Filas.Item(0)("TelOficina")).Trim
                txtCel.Text = CStr(Filas.Item(0)("Celular")).Trim
                pCodProf = CStr(Filas.Item(0)("CodProfesion")).Trim
                ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(pCodProf) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtProfesion.Text = CStr(Filas.Item(0)("Descripcion"))
                    End If
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress

        Dim pCodProf As String
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,EstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Value & "' and EstadoIngreso='2' and EstadoAsociado='25'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                    txtNombres.Text = CStr(Filas.Item(0)("Nombres")).Trim
                    txtApe1.Text = CStr(Filas.Item(0)("Apellido1")).Trim
                    txtApe2.Text = CStr(Filas.Item(0)("Apellido2")).Trim
                    txtApe3.Text = CStr(Filas.Item(0)("ApellidoCas")).Trim
                    txtDireccion.Text = CStr(Filas.Item(0)("Direccion")).Trim
                    cbEstadoCivil.SelectedIndex = CStr(Filas.Item(0)("EstadoCivil"))
                    txtLugDui.Text = CStr(Filas.Item(0)("LugarExtDUI")).Trim
                    dtpFecExtDui.Value = CDate(Filas.Item(0)("FechaExtDUI"))
                    dtpFecNac.Value = CDate(Filas.Item(0)("Fecha_Nac"))
                    txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                    txtTelCasa.Text = CStr(Filas.Item(0)("TelCasa")).Trim
                    txtTelOfic.Text = CStr(Filas.Item(0)("TelOficina")).Trim
                    txtCel.Text = CStr(Filas.Item(0)("Celular")).Trim
                    pCodProf = CStr(Filas.Item(0)("CodProfesion")).Trim
                    ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(pCodProf) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                            Me.txtProfesion.Text = CStr(Filas.Item(0)("Descripcion"))
                        End If
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

    Private Sub txtApe1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe1.KeyPress

        Dim pCodProf As String
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtApe1.Text.Trim = "" Then
                    txtApe1_DoubleClick(sender, e)
                Else
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                    ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,EstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "EstadoIngreso='2'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtDui.Text = CStr(Filas.Item(0)("DUI")).Trim
                        txtNombres.Text = CStr(Filas.Item(0)("Nombres")).Trim
                        txtApe1.Text = CStr(Filas.Item(0)("Apellido1")).Trim
                        txtApe2.Text = CStr(Filas.Item(0)("Apellido2")).Trim
                        txtApe3.Text = CStr(Filas.Item(0)("ApellidoCas")).Trim
                        txtDireccion.Text = CStr(Filas.Item(0)("Direccion")).Trim
                        cbEstadoCivil.SelectedIndex = CStr(Filas.Item(0)("EstadoCivil"))
                        txtLugDui.Text = CStr(Filas.Item(0)("LugarExtDUI")).Trim
                        dtpFecExtDui.Value = CDate(Filas.Item(0)("FechaExtDUI"))
                        dtpFecNac.Value = CDate(Filas.Item(0)("Fecha_Nac"))
                        txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                        txtTelCasa.Text = CStr(Filas.Item(0)("TelCasa")).Trim
                        txtTelOfic.Text = CStr(Filas.Item(0)("TelOficina")).Trim
                        txtCel.Text = CStr(Filas.Item(0)("Celular")).Trim
                        pCodProf = CStr(Filas.Item(0)("CodProfesion")).Trim
                        ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(pCodProf) & "'", "", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                                Me.txtProfesion.Text = CStr(Filas.Item(0)("Descripcion"))
                            End If
                        End If
                        Dim FechaNac As Date
                        FechaNac = dtpFecNac.Value.Day & "/" & dtpFecNac.Value.Month & "/" & Now().Year

                        Me.txtEdad.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNac.Value, Now())
                        Me.txtTitular2.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtApe1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApe1.DoubleClick

        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Dim ofrm As New frmAGenerico, pCodProf As String

            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,EstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "EstadoIngreso='2'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtDui.Text = CStr(Filas.Item(0)("DUI")).Trim
                txtNombres.Text = CStr(Filas.Item(0)("Nombres")).Trim
                txtApe1.Text = CStr(Filas.Item(0)("Apellido1")).Trim
                txtApe2.Text = CStr(Filas.Item(0)("Apellido2")).Trim
                txtApe3.Text = CStr(Filas.Item(0)("ApellidoCas")).Trim
                txtDireccion.Text = CStr(Filas.Item(0)("Direccion")).Trim
                cbEstadoCivil.SelectedIndex = CStr(Filas.Item(0)("EstadoCivil"))
                txtLugDui.Text = CStr(Filas.Item(0)("LugarExtDUI")).Trim
                dtpFecExtDui.Value = CDate(Filas.Item(0)("FechaExtDUI"))
                dtpFecNac.Value = CDate(Filas.Item(0)("Fecha_Nac"))
                txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                txtTelCasa.Text = CStr(Filas.Item(0)("TelCasa")).Trim
                txtTelOfic.Text = CStr(Filas.Item(0)("TelOficina")).Trim
                txtCel.Text = CStr(Filas.Item(0)("Celular")).Trim
                pCodProf = CStr(Filas.Item(0)("CodProfesion")).Trim
                ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(pCodProf) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtProfesion.Text = CStr(Filas.Item(0)("Descripcion"))
                    End If
                End If
                Dim FechaNac As Date
                FechaNac = dtpFecNac.Value.Day & "/" & dtpFecNac.Value.Month & "/" & Now().Year

                Me.txtEdad.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNac.Value, Now())
                Me.txtTitular2.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtpFechaApertura_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaApertura.LostFocus

        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro

            Me.txtNoCuenta.Text = oAhorro.GeneraNoCuenta(codApor, sSucursal, "04", Me.dtpFechaApertura.Value.Month, Me.dtpFechaApertura.Value.Year, sUsuario, sPassword, sSucursal)
            Me.txtDigito.Text = oAhorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus

        Dim pCodProf As String
        Try
            If txtDui.Text.Trim <> "" Then
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,EstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Value & "' and EstadoIngreso='2' and EstadoAsociado='25'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtNoCuenta.Text = Ahorro.generarNoCuentaTipoAhorro(txtDui.Value.Trim, "1101", sUsuario, sPassword, sSucursal)
                    Me.txtDigito.Text = Ahorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                    txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                    txtNombres.Text = CStr(Filas.Item(0)("Nombres")).Trim
                    txtApe1.Text = CStr(Filas.Item(0)("Apellido1")).Trim
                    txtApe2.Text = CStr(Filas.Item(0)("Apellido2")).Trim
                    txtApe3.Text = CStr(Filas.Item(0)("ApellidoCas")).Trim
                    txtDireccion.Text = CStr(Filas.Item(0)("Direccion")).Trim
                    cbEstadoCivil.SelectedIndex = CStr(Filas.Item(0)("EstadoCivil"))
                    txtLugDui.Text = CStr(Filas.Item(0)("LugarExtDUI")).Trim
                    dtpFecExtDui.Value = CDate(Filas.Item(0)("FechaExtDUI"))
                    dtpFecNac.Value = CDate(Filas.Item(0)("Fecha_Nac"))
                    txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                    txtTelCasa.Text = CStr(Filas.Item(0)("TelCasa")).Trim
                    txtTelOfic.Text = CStr(Filas.Item(0)("TelOficina")).Trim
                    txtCel.Text = CStr(Filas.Item(0)("Celular")).Trim
                    pCodProf = CStr(Filas.Item(0)("CodProfesion")).Trim
                    ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(pCodProf) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                            Me.txtProfesion.Text = CStr(Filas.Item(0)("Descripcion"))
                        End If
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

    Private Sub btNewR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ActualizaGridR()

        Dim oAh As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarReposicionLibreta("*", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & codApor & "'", "NoSolicitud", sUsuario, sPassword, sSucursal)

            Me.fgR.DataSource = ds.Tables(0)
            Me.fgR.Cols.Item(0).Caption = "No. Solicitud"
            Me.fgR.Cols.Item(1).Caption = "Tipo Ahorro"
            Me.fgR.Cols.Item(2).Caption = "No. Cuenta"
            Me.fgR.Cols.Item(3).Caption = "Causa"
            Me.fgR.Cols.Item(4).Caption = "Cancela Comisión"
            Me.fgR.Cols.Item(5).Caption = "No. Libreta Anterior"
            Me.fgR.Cols.Item(6).Caption = "No. Libreta a Reponer"
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
                If vConsulta = True Then
                    Me.btDelR.Enabled = False
                Else
                    Me.btDelR.Enabled = True
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btEditR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btDelR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub fgR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgR.DoubleClick
        btEditR_Click(sender, e)
    End Sub

    Private Sub btnAtrasTb7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCerrarTb7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarTb7.Click
        Me.Dispose()
    End Sub

    Private Sub btnSaveTb7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ckbCobroDomicilio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbCobroDomicilio.CheckedChanged
        If Me.ckbCobroDomicilio.Checked = True Then
            Me.grbRutaCobro.Enabled = True
            Me.btnSaveTb7.Enabled = True
        Else
            Me.grbRutaCobro.Enabled = False
            Me.btnSaveTb7.Enabled = False
        End If
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

    Private Sub txtCodMun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodMun.KeyPress
        Try
            Dim oPerif As wrAsociados.wsLibAsoc
            Dim ds As New Data.DataSet
            Dim filas As Data.DataRowCollection

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

    Private Sub dtpFecNacT2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecNacT2.ValueChanged
        Dim FechaNac As Date
        FechaNac = dtpFecNacT2.Value.Day & "/" & dtpFecNacT2.Value.Month & "/" & Now().Year
        Me.txtEdadT2.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNacT2.Value, Now())
    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String, pSaldoCapital As Double
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, oAhorro As wrAhorro.wsLibAhorro
        Try
            oPrest = New wrPrestamo.wsLibPrest
            oAhorro = New wrAhorro.wsLibAhorro
            ds = oPrest.CargarListaPrestamos(False, "", "", Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                dr = ds.Tables("Prestamo").Rows(0)
                pSaldoCapital = IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital"))
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                ds = oAhorro.CargarDatosPrestamosPignorados("distinct a.CodPrestamo,b.FechaOtorgamiento as Fecha_Apertura,FechaVencimiento as Fecha_Vencimiento,b.Monto, b.PlazoMeses as Plazo", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", sUsuario, sPassword, sSucursal)
                If ds.Tables("AhPignoraciones").Rows.Count > 0 Then
                    dr = ds.Tables("AhPignoraciones").Rows(0)
                    Me.txtSaldo.Text = pSaldoCapital
                    Me.txtPlazo.Value = IIf(IsDBNull(dr("Plazo")), 0, dr("Plazo"))
                    Me.txtMontoPignorado.Text = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
                    Me.txtApertura.Text = IIf(IsDBNull(dr("Fecha_Apertura")), "", dr("Fecha_Apertura"))
                    Me.txtVenc.Text = IIf(IsDBNull(dr("Fecha_Vencimiento")), "", dr("Fecha_Vencimiento"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEjecMercadeo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecMercadeo.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Try
                Dim oPl As New wrPlanilla.wsLibPlanilla
                Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection

                oPerif = New wrAsociados.wsLibAsoc
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
                        txtCodEjecApertura.Focus()
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
            txtCodEjecApertura.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEjecApertura_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecApertura.DoubleClick
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
            txtCodEjecApertura.Text = ofrm.Resultado.Trim
            txtEjecApertura.Text = ofrm.Resultado2.Trim
            Me.txtObs.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEjecApertura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecApertura.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Try
                Dim oPl As New wrPlanilla.wsLibPlanilla
                Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection

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
                MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

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

    Private Sub gbDatDoc_Enter(sender As Object, e As EventArgs) Handles gbDatDoc.Enter

    End Sub

    Private Sub gbDepositosAutomaticos_Enter(sender As Object, e As EventArgs) Handles gbDepositosAutomaticos.Enter

    End Sub

    Private Sub tbDatGral_Click(sender As Object, e As EventArgs) Handles tbDatGral.Click

    End Sub

    Private Sub btnSiguiente2_Click(sender As Object, e As EventArgs) Handles btnSigTb1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub


    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles btnSaveTb3.Click
        Me.btnSaveTb1_Click(sender, e)
    End Sub

    Private Sub btnSaveTb1_Click(sender As Object, e As EventArgs) Handles btnSaveTb1.Click
        Try
            Dim oCred As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, pCampos As String, pValores As String
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection, dr As DataRow, CobroDomicilio As String

            Select Case oCred.AutorizaDatos(txtDui.Text, "x", txtNoCuenta.Text, Me.txtNoLibreta.Text, "x")
                Case 1
                    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Aportaciones")
                    Exit Sub
                Case 3
                    MsgBox("El campo No. Cuenta no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Aportaciones")
                    Exit Sub
                Case 4
                    MsgBox("El campo No. Libreta no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Aportaciones")
                    Exit Sub
            End Select
            Dim dtsAportacion As New DataSet
            Dim codAportacion As String
            dtsAportacion = Ahorro.ConsultarTipoAhorro("CodTipoAhorro", " Left(CodTipoAhorro,1)='" & libAhorro.tiposAhorro.aportaciones & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            If dtsAportacion.Tables(0).Rows.Count > 0 Then
                codAportacion = dtsAportacion.Tables(0).Rows(0).Item(0).ToString
            End If
            ds = oCred.ConsultarParametros("*", "CodTipoAhorro='" & codAportacion & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables("AhParametros").Rows
            If Filas.Count > 0 Then
                dr = ds.Tables("AhParametros").Rows(0)
                If Val(c1nMontoApertura.Value) < Val(dr("MontoAperturaMinima")) And (CDate(Me.dtpFechaApertura.Value.ToShortDateString) >= dr("ValidoDesdeMin") And CDate(Me.dtpFechaApertura.Value.ToShortDateString) <= dr("ValidoHastaMin")) Then
                    MsgBox("El Monto de Apertura no puede ser menor que el Monto de Apertura Mínima.", MsgBoxStyle.Critical, "Módulo Aportaciones")
                    Exit Sub
                End If
                If Val(c1nMontoApertura.Value) > Val(dr("MontoAperturaMaxima")) And (CDate(Me.dtpFechaApertura.Value.ToShortDateString) >= dr("ValidoDesdeMax") And CDate(Me.dtpFechaApertura.Value.ToShortDateString) <= dr("ValidoHastaMax")) Then
                    MsgBox("El Monto de Apertura no puede ser mayor que el Monto de Apertura Máximo.", MsgBoxStyle.Critical, "Módulo Aportaciones")
                    Exit Sub
                End If
            End If

            ds = oAsoc.ConsultarAsociado("*", "Dui='" & Trim(Me.txtDui.Text) & "' and EstadoAsociado='25' and EstadoIngreso='2'", "DUI", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
            Else
                MsgBox("El Dui del Asociado no coincide con el Maestro de Asociados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Aportaciones")
                Exit Sub
            End If

            If Me.ckbCobroDomicilio.Checked = True Then
                CobroDomicilio = "S"
            Else
                CobroDomicilio = "N"
            End If

            If Me.btnSaveTb1.Text = "&Guardar" Then
                pCampos = "Dui,CodTipoAhorro,NoCuenta,CodPrestamo,Titular2,PartidaNacTitular2,NoLibreta,FechaInicioApertura,FechaApertura,MontoApertura,Plazo,Monto,NoCuotas,CodDestino,TasaInteres,CodEjecutivo,Pignorado,Saldo_CuentaAhorro,SaldoDisponible_CuentaAhorro,Observacion,Estado,CobroDomicilio,TipoDocTit2,Digito,CelTit2,CodEjecApertura,CodParentesco,NoSocio,TipoDeposito,NoCuentaDeposito,CodTipoAhorroDep,FecIniDep,FecFinDep,Cuota"
                pValores = "'" & Trim(Me.txtDui.Text) & "','" & codApor & "','" & Trim(Me.txtNoCuenta.Text) & "','','" & Trim(Me.txtTitular2.Text) & "','" & Trim(Me.txtPartida.Text) & "','" & Trim(Me.txtNoLibreta.Text) & "','" & Format(Now, "dd/MM/yyyy") & "','" & Format(Me.dtpFechaApertura.Value, "dd/MM/yyyy") & "'," & Val(Me.c1nMontoApertura.Value) & ",0,0,0,'00000'," & Val(Me.c1nTasa.Value) & ",'" & Trim(Me.txtCodEjecMercadeo.Text) & "','N',0,0,'" & Me.txtObs.Text.Trim & "','D','" & CobroDomicilio & "','" & Me.cbDoc.SelectedIndex & "','" & Me.txtDigito.Text.Trim & "','" & Me.txtCelT2.Text.Trim & "','" & Me.txtCodEjecApertura.Text.Trim & "','" & Me.cbParentesco.Text.Substring(0, 5).Trim & "','" & Me.txtNoSocio.Text.Trim & "','" & Me.cbTipoDeposito.SelectedIndex & "','" & Me.txtNoCuentaDepAut.Text.Trim & "','" & Me.txtCodTipoAhorroDepAut.Text.Trim & "','" & Format(Me.dtpFecIniDA.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecFinDA.Value, "dd/MM/yyyy") & "'," & Me.c1nMontoTransf.Value & ""
                If oCred.InsertarCuentaAhorro(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    txtDui.Enabled = False
                    txtNombres.Enabled = False
                    txtApe1.Enabled = False
                    txtApe2.Enabled = False
                    txtNoCuenta.Enabled = False
                    btNewBen.Enabled = True
                    btNewR.Enabled = True
                    btnSaveTb1.Text = "&Modificar"
                    btnSaveTb3.Text = "&Modificar"
                    ckbCobroDomicilio.Enabled = True
                    gbPig.Enabled = True
                    Me.pCodTipoAhorro = codApor
                    Me.pNoCuenta = Trim(Me.txtNoCuenta.Text)
                Else
                    MsgBox("Los datos de la Cuenta de Ahorros NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Aportaciones")
                End If
            ElseIf Me.btnSaveTb1.Text = "&Modificar" Then
                pCampos = "Titular2='" & Trim(Me.txtTitular2.Text) & "',PartidaNacTitular2='" & Trim(Me.txtPartida.Text) & "',NoLibreta='" & Trim(Me.txtNoLibreta.Text) & "',FechaApertura='" & Format(Me.dtpFechaApertura.Value, "dd/MM/yyyy") & "',MontoApertura=" & Val(Me.c1nMontoApertura.Value) & ",TasaInteres=" & Val(Me.c1nTasa.Value) & ",CodEjecutivo='" & Trim(Me.txtCodEjecMercadeo.Text) & "',Observacion='" & Me.txtObs.Text.Trim & "',CobroDomicilio='" & CobroDomicilio & "',TipoDocTit2='" & Me.cbDoc.SelectedIndex & "',CelTit2='" & Me.txtCelT2.Text.Trim & "',CodEjecApertura='" & Me.txtCodEjecApertura.Text.Trim & "',CodParentesco='" & Me.cbParentesco.Text.Substring(0, 5).Trim & "',TipoDeposito='" & Me.cbTipoDeposito.SelectedIndex & "',NoCuentaDeposito='" & Me.txtNoCuentaDepAut.Text.Trim & "',CodTipoAhorroDep='" & Me.txtCodTipoAhorroDepAut.Text.Trim & "',FecIniDep='" & Format(Me.dtpFecIniDA.Value, "dd/MM/yyyy") & "',FecFinDep='" & Format(Me.dtpFecFinDA.Value, "dd/MM/yyyy") & "',Cuota=" & Me.c1nMontoTransf.Value & ""
                If oCred.ModificarCuentaAhorro(pNoCuenta, pCodTipoAhorro, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos de la Cuenta de Ahorros no han sido modificados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Aportaciones")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles btNewBen.Click
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

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles btEditBen.Click
        Try

            If Me.fgBen.Row <> -1 Then
                Dim frm As frmMsAhBeneficiarios = New frmMsAhBeneficiarios
                frm.pNoCuenta = Me.pNoCuenta
                frm.txtDui.Value = Me.fgBen.Item(Me.fgBen.Row, "DuiBeneficiario")
                frm.pCodTipoAhorro = Me.pCodTipoAhorro
                frm.pCorrelativo = Me.fgBen.Item(Me.fgBen.Row, "Correlativo")
                frm.pAccion = "Modificar"
                If vConsulta = True Then frm.btnGuardar1.Visible = False
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridBen()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton5_Click_1(sender As Object, e As EventArgs) Handles btDelBen.Click
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

    Private Sub MetroButton7_Click_1(sender As Object, e As EventArgs) Handles btNewR.Click
        Try
            Dim frm As frmMsAhRepLibreta = New frmMsAhRepLibreta
            frm.pNoLibreta = Me.txtNoLibreta.Text
            frm.Text = "Reposición de Libreta de Aportaciones"
            frm.gbRepLib.Text = "Solicitud de Reposición de Libreta de Aportaciones"
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

    Private Sub MetroButton6_Click_1(sender As Object, e As EventArgs) Handles btEditR.Click
        Try
            If Me.fgR.Row <> -1 Then
                Dim frm As frmMsAhRepLibreta = New frmMsAhRepLibreta
                frm.pNoCuenta = Me.pNoCuenta
                frm.pCodTipoAhorro = Me.pCodTipoAhorro
                frm.pNoLibreta = Me.txtNoLibreta.Text
                frm.pCorrelativo = Me.fgR.Item(Me.fgR.Row, "NoSolicitud")
                frm.pAccion = "Modificar"
                If vConsulta = True Then frm.btnGuardar.Visible = False
                frm.btnGuardar.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridR()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MetroButton5_Click_2(sender As Object, e As EventArgs) Handles btDelR.Click
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

    Private Sub tbSolic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbSolic.SelectedIndexChanged

    End Sub

    Private Sub tbLibRep_Click(sender As Object, e As EventArgs) Handles tbLibRep.Click

    End Sub

    Private Sub MetroButton5_Click_3(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton6_Click_2(sender As Object, e As EventArgs) Handles btnSaveTb7.Click
        Try
            Dim oCred As wrAhorro.wsLibAhorro
            Dim ds As New Data.DataSet
            oCred = New wrAhorro.wsLibAhorro
            Dim pCampos As String, pValores As String
            Dim pCamposValores As String

            ds = oCred.ConsultarRutasCobro("*", "CodTipoAhorro = '" & codApor & "' and NoCuenta='" & pNoCuenta.Trim & "'", "", sUsuario, sPassword, sSucursal)
            pCampos = "CodTipoAhorro,NoCuenta,DireccionCobro,CodDepartamento,CodMunicipio,Dia,FechaCaducidad,CodCobrador"
            pValores = "'" & codApor & "','" & pNoCuenta & "','" & Trim(Me.txtDireccionCobro.Text) & "','" & Trim(Me.txtCodDpto.Text) & "','" & Trim(Me.txtCodMun.Text) & "'," & Val(Me.txtDia.Text) & ",'" & Me.dtpFechaCuota.Value.ToShortDateString & "'," & Me.txtCodCobrador.Text.Trim & ""
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

    Private Sub MetroButton6_Click_3(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton7_Click_2(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
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

    Private Sub cbTipoDeposito_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoDeposito.SelectedIndexChanged
        If Me.cbTipoDeposito.SelectedIndex = 1 Then
            Me.txtNoCuentaDepAut.Enabled = True
            Me.dtpFecIniDA.Enabled = True
            Me.dtpFecFinDA.Enabled = True
        ElseIf Me.cbTipoDeposito.SelectedIndex = 0 Then
            Me.txtNoCuentaDepAut.Text = ""
            Me.txtCodTipoAhorroDepAut.Text = ""
            Me.txtNoCuentaDepAut.Enabled = False
            Me.dtpFecIniDA.Enabled = False
            Me.dtpFecFinDA.Enabled = False
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

    Private Sub frmMsAhCuentasAportacion_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate

    End Sub
End Class