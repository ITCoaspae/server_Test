Public Class frmMsAhCuentasDPF
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim libAhorro As New sifLib.Ahorro.clsAhorros
    Friend WithEvents MetroButton9 As MetroFramework.Controls.MetroButton
    Dim asociados As New wrAsociados.wsLibAsoc
    Friend WithEvents MetroButton11 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbNocuenta As MetroFramework.Controls.MetroComboBox
    Dim ahorro As New wrAhorro.wsLibAhorro

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
    Friend WithEvents tbDatGral As System.Windows.Forms.TabPage
    Friend WithEvents tabDatGralII As System.Windows.Forms.TabPage
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents tbCertDPF As System.Windows.Forms.TabPage
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents gbCancela As System.Windows.Forms.GroupBox
    Friend WithEvents cbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProf As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtpFecExtDui As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtLugDui As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtApe3 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtMotivoCancela As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents dtpFecCanc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtEjecMercadeoCanc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecCanc As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents cbAsentInt As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents fgRep As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTitular2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtPartida As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents tbPigRen As System.Windows.Forms.TabPage
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoPignorado As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtCelT2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEdadT2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents lblTelCasa As System.Windows.Forms.Label
    Friend WithEvents dtpFecNacT2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fgHist As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents fgBen As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtVenc As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtApertura As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtPignorada As System.Windows.Forms.TextBox
    Friend WithEvents fgPig As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gbPig As System.Windows.Forms.GroupBox
    Friend WithEvents cbParentesco As System.Windows.Forms.ComboBox
    Friend WithEvents cbPar As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtEjecApertura As TextBox
    Friend WithEvents c1nCaja As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCodEjecApertura As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents c1nRemesa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtEjecMercadeo As TextBox
    Friend WithEvents c1nRenovacion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label46 As Label
    Friend WithEvents c1nTransferencia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCodEjecMercadeo As TextBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbAutorizacion As ComboBox
    Friend WithEvents lblAutorizadoPor As Label
    Friend WithEvents btEdit As Button
    Friend WithEvents Label60 As Label
    Friend WithEvents txtCodAhorro As TextBox
    Friend WithEvents txtAhorro As TextBox
    Friend WithEvents txtFormaEntrega As TextBox
    Friend WithEvents txtPignorado As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents txtNoCertificado As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpFecVenc As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents c1nTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label20 As Label
    Friend WithEvents c1nPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label18 As Label
    Friend WithEvents c1nMontoApertura As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpFechaApertura As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNoCuenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFecIniApertura As Label
    Friend WithEvents dtpFecIniApertura As DateTimePicker
    Friend WithEvents Label59 As Label
    Friend WithEvents txtDigito As TextBox
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents dtpFecAnula As DateTimePicker
    Friend WithEvents lblAnula As Label
    Friend WithEvents chkAnulado As CheckBox
    Friend WithEvents lblComentario As Label
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNew As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewBen As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btTasaPactada As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnContrato As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton8 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton10 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label61 As Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhCuentasDPF))
        Me.tbSolic = New System.Windows.Forms.TabControl()
        Me.tbDatGral = New System.Windows.Forms.TabPage()
        Me.MetroButton9 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbPar = New System.Windows.Forms.ComboBox()
        Me.cbParentesco = New System.Windows.Forms.ComboBox()
        Me.txtCelT2 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtEdadT2 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.dtpFecNacT2 = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPartida = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtTitular2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.lblTelCasa = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApe3 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpFecExtDui = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLugDui = New System.Windows.Forms.TextBox()
        Me.txtProf = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.dtpFecAnula = New System.Windows.Forms.DateTimePicker()
        Me.lblAnula = New System.Windows.Forms.Label()
        Me.chkAnulado = New System.Windows.Forms.CheckBox()
        Me.lblComentario = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtEjecApertura = New System.Windows.Forms.TextBox()
        Me.c1nCaja = New C1.Win.C1Input.C1NumericEdit()
        Me.txtCodEjecApertura = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.c1nRemesa = New C1.Win.C1Input.C1NumericEdit()
        Me.txtEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.c1nRenovacion = New C1.Win.C1Input.C1NumericEdit()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.c1nTransferencia = New C1.Win.C1Input.C1NumericEdit()
        Me.txtCodEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btTasaPactada = New MetroFramework.Controls.MetroButton()
        Me.cbAutorizacion = New System.Windows.Forms.ComboBox()
        Me.lblAutorizadoPor = New System.Windows.Forms.Label()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtCodAhorro = New System.Windows.Forms.TextBox()
        Me.txtAhorro = New System.Windows.Forms.TextBox()
        Me.txtFormaEntrega = New System.Windows.Forms.TextBox()
        Me.txtPignorado = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtNoCertificado = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpFecVenc = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1nTasa = New C1.Win.C1Input.C1NumericEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.c1nPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.c1nMontoApertura = New C1.Win.C1Input.C1NumericEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFechaApertura = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFecIniApertura = New System.Windows.Forms.Label()
        Me.dtpFecIniApertura = New System.Windows.Forms.DateTimePicker()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtDigito = New System.Windows.Forms.TextBox()
        Me.tbCertDPF = New System.Windows.Forms.TabPage()
        Me.cbNocuenta = New MetroFramework.Controls.MetroComboBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbAsentInt = New System.Windows.Forms.ComboBox()
        Me.btnSaveTb4 = New MetroFramework.Controls.MetroButton()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.btnNew = New MetroFramework.Controls.MetroButton()
        Me.fgRep = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.tbPigRen = New System.Windows.Forms.TabPage()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtPignorada = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.fgPig = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.fgHist = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.tabDatGralII = New System.Windows.Forms.TabPage()
        Me.MetroButton11 = New MetroFramework.Controls.MetroButton()
        Me.btnContrato = New MetroFramework.Controls.MetroButton()
        Me.MetroButton8 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton10 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btDelBen = New MetroFramework.Controls.MetroButton()
        Me.btEditBen = New MetroFramework.Controls.MetroButton()
        Me.btNewBen = New MetroFramework.Controls.MetroButton()
        Me.fgBen = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gbCancela = New System.Windows.Forms.GroupBox()
        Me.dtpFecCanc = New System.Windows.Forms.DateTimePicker()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtEjecMercadeoCanc = New System.Windows.Forms.TextBox()
        Me.txtCodEjecCanc = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtMotivoCancela = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.tbSolic.SuspendLayout()
        Me.tbDatGral.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatDoc.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.c1nCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nRemesa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nRenovacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCertDPF.SuspendLayout()
        CType(Me.fgRep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbPigRen.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.fgPig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgHist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPig.SuspendLayout()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatGralII.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.fgBen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCancela.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSolic
        '
        Me.tbSolic.Controls.Add(Me.tbDatGral)
        Me.tbSolic.Controls.Add(Me.TabPage1)
        Me.tbSolic.Controls.Add(Me.tbCertDPF)
        Me.tbSolic.Controls.Add(Me.tbPigRen)
        Me.tbSolic.Controls.Add(Me.tabDatGralII)
        Me.tbSolic.ItemSize = New System.Drawing.Size(300, 18)
        Me.tbSolic.Location = New System.Drawing.Point(28, 73)
        Me.tbSolic.Multiline = True
        Me.tbSolic.Name = "tbSolic"
        Me.tbSolic.SelectedIndex = 0
        Me.tbSolic.Size = New System.Drawing.Size(933, 646)
        Me.tbSolic.TabIndex = 5
        '
        'tbDatGral
        '
        Me.tbDatGral.BackColor = System.Drawing.Color.White
        Me.tbDatGral.Controls.Add(Me.MetroButton9)
        Me.tbDatGral.Controls.Add(Me.MetroButton7)
        Me.tbDatGral.Controls.Add(Me.lblEstado)
        Me.tbDatGral.Controls.Add(Me.Label61)
        Me.tbDatGral.Controls.Add(Me.txtTipoAhorro)
        Me.tbDatGral.Controls.Add(Me.txtCodTipoAhorro)
        Me.tbDatGral.Controls.Add(Me.GroupBox2)
        Me.tbDatGral.Controls.Add(Me.gbDatDoc)
        Me.tbDatGral.Location = New System.Drawing.Point(4, 22)
        Me.tbDatGral.Name = "tbDatGral"
        Me.tbDatGral.Size = New System.Drawing.Size(925, 620)
        Me.tbDatGral.TabIndex = 0
        Me.tbDatGral.Text = "Datos Generales"
        '
        'MetroButton9
        '
        Me.MetroButton9.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.MetroButton9.Location = New System.Drawing.Point(685, 492)
        Me.MetroButton9.Name = "MetroButton9"
        Me.MetroButton9.Size = New System.Drawing.Size(114, 32)
        Me.MetroButton9.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton9.TabIndex = 1023
        Me.MetroButton9.Text = "&Datos Asociado"
        Me.MetroButton9.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton9.UseSelectable = True
        Me.MetroButton9.UseStyleColors = True
        '
        'MetroButton7
        '
        Me.MetroButton7.Location = New System.Drawing.Point(806, 492)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton7.TabIndex = 209
        Me.MetroButton7.Text = "Siguiente"
        Me.MetroButton7.UseSelectable = True
        Me.MetroButton7.UseStyleColors = True
        '
        'lblEstado
        '
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Green
        Me.lblEstado.Location = New System.Drawing.Point(716, 13)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(180, 18)
        Me.lblEstado.TabIndex = 155
        Me.lblEstado.Text = "Estado Cuenta"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(20, 15)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(105, 17)
        Me.Label61.TabIndex = 174
        Me.Label61.Text = "Tipo de Cuenta"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BackColor = System.Drawing.Color.White
        Me.txtTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAhorro.Location = New System.Drawing.Point(265, 12)
        Me.txtTipoAhorro.MaxLength = 110
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTipoAhorro.Size = New System.Drawing.Size(444, 23)
        Me.txtTipoAhorro.TabIndex = 16
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.AcceptsReturn = True
        Me.txtCodTipoAhorro.BackColor = System.Drawing.Color.White
        Me.txtCodTipoAhorro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(133, 12)
        Me.txtCodTipoAhorro.MaxLength = 10
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(125, 23)
        Me.txtCodTipoAhorro.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbPar)
        Me.GroupBox2.Controls.Add(Me.cbParentesco)
        Me.GroupBox2.Controls.Add(Me.txtCelT2)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.txtEdadT2)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.dtpFecNacT2)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtPartida)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cbDoc)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtTel)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.txtTitular2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(13, 333)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(883, 152)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Titular 2"
        '
        'cbPar
        '
        Me.cbPar.BackColor = System.Drawing.Color.White
        Me.cbPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPar.Location = New System.Drawing.Point(120, 52)
        Me.cbPar.Name = "cbPar"
        Me.cbPar.Size = New System.Drawing.Size(307, 25)
        Me.cbPar.TabIndex = 1
        '
        'cbParentesco
        '
        Me.cbParentesco.Location = New System.Drawing.Point(550, 52)
        Me.cbParentesco.Name = "cbParentesco"
        Me.cbParentesco.Size = New System.Drawing.Size(307, 25)
        Me.cbParentesco.TabIndex = 1
        Me.cbParentesco.Visible = False
        '
        'txtCelT2
        '
        Me.txtCelT2.AcceptsReturn = True
        Me.txtCelT2.BackColor = System.Drawing.Color.White
        Me.txtCelT2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCelT2.Location = New System.Drawing.Point(745, 114)
        Me.txtCelT2.MaxLength = 25
        Me.txtCelT2.Name = "txtCelT2"
        Me.txtCelT2.Size = New System.Drawing.Size(112, 23)
        Me.txtCelT2.TabIndex = 6
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(610, 114)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(124, 19)
        Me.Label34.TabIndex = 176
        Me.Label34.Text = "Teléfono Celular:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEdadT2
        '
        Me.txtEdadT2.AcceptsReturn = True
        Me.txtEdadT2.BackColor = System.Drawing.Color.White
        Me.txtEdadT2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEdadT2.Location = New System.Drawing.Point(120, 113)
        Me.txtEdadT2.MaxLength = 25
        Me.txtEdadT2.Name = "txtEdadT2"
        Me.txtEdadT2.ReadOnly = True
        Me.txtEdadT2.Size = New System.Drawing.Size(106, 23)
        Me.txtEdadT2.TabIndex = 7
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(8, 114)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(48, 19)
        Me.Label33.TabIndex = 174
        Me.Label33.Text = "Edad:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecNacT2
        '
        Me.dtpFecNacT2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNacT2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNacT2.Location = New System.Drawing.Point(550, 83)
        Me.dtpFecNacT2.Name = "dtpFecNacT2"
        Me.dtpFecNacT2.Size = New System.Drawing.Size(307, 23)
        Me.dtpFecNacT2.TabIndex = 5
        Me.dtpFecNacT2.Value = New Date(2017, 12, 26, 0, 0, 0, 0)
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(435, 71)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 36)
        Me.Label24.TabIndex = 169
        Me.Label24.Text = "Fec. Nacimiento:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPartida
        '
        Me.txtPartida.AcceptsReturn = True
        Me.txtPartida.BackColor = System.Drawing.Color.White
        Me.txtPartida.EditMask = "00000000-0"
        Me.txtPartida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida.Location = New System.Drawing.Point(120, 83)
        Me.txtPartida.MaxLength = 20
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.NumericInput = False
        Me.txtPartida.Size = New System.Drawing.Size(307, 21)
        Me.txtPartida.TabIndex = 4
        Me.txtPartida.Tag = Nothing
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 19)
        Me.Label13.TabIndex = 168
        Me.Label13.Text = "No. Documento"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbDoc
        '
        Me.cbDoc.BackColor = System.Drawing.Color.White
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoc.Items.AddRange(New Object() {"DUI", "NIT", "No. Licencia", "No. Residente", "No. Partida y No. Folio", "No. Pasaporte"})
        Me.cbDoc.Location = New System.Drawing.Point(550, 51)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(307, 24)
        Me.cbDoc.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(436, 52)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(106, 22)
        Me.Label22.TabIndex = 166
        Me.Label22.Text = "Documento:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTel
        '
        Me.txtTel.AcceptsReturn = True
        Me.txtTel.BackColor = System.Drawing.Color.White
        Me.txtTel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTel.Location = New System.Drawing.Point(438, 113)
        Me.txtTel.MaxLength = 25
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(109, 23)
        Me.txtTel.TabIndex = 2
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(319, 114)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(106, 19)
        Me.Label39.TabIndex = 164
        Me.Label39.Text = "Teléfono Casa:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(8, 55)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(87, 19)
        Me.Label40.TabIndex = 162
        Me.Label40.Text = "Parentesco:"
        '
        'txtTitular2
        '
        Me.txtTitular2.AcceptsReturn = True
        Me.txtTitular2.BackColor = System.Drawing.Color.White
        Me.txtTitular2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTitular2.Location = New System.Drawing.Point(120, 22)
        Me.txtTitular2.MaxLength = 100
        Me.txtTitular2.Name = "txtTitular2"
        Me.txtTitular2.Size = New System.Drawing.Size(737, 23)
        Me.txtTitular2.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(7, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 18)
        Me.Label12.TabIndex = 144
        Me.Label12.Text = "Nombre Titular 2:"
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.txtEdad)
        Me.gbDatDoc.Controls.Add(Me.txtDireccion)
        Me.gbDatDoc.Controls.Add(Me.Label32)
        Me.gbDatDoc.Controls.Add(Me.txtCel)
        Me.gbDatDoc.Controls.Add(Me.Label25)
        Me.gbDatDoc.Controls.Add(Me.txtTelCasa)
        Me.gbDatDoc.Controls.Add(Me.lblTelCasa)
        Me.gbDatDoc.Controls.Add(Me.Label23)
        Me.gbDatDoc.Controls.Add(Me.txtNoSocio)
        Me.gbDatDoc.Controls.Add(Me.Label6)
        Me.gbDatDoc.Controls.Add(Me.txtApe3)
        Me.gbDatDoc.Controls.Add(Me.Label21)
        Me.gbDatDoc.Controls.Add(Me.dtpFecNac)
        Me.gbDatDoc.Controls.Add(Me.Label17)
        Me.gbDatDoc.Controls.Add(Me.dtpFecExtDui)
        Me.gbDatDoc.Controls.Add(Me.Label5)
        Me.gbDatDoc.Controls.Add(Me.Label16)
        Me.gbDatDoc.Controls.Add(Me.txtLugDui)
        Me.gbDatDoc.Controls.Add(Me.txtProf)
        Me.gbDatDoc.Controls.Add(Me.Label19)
        Me.gbDatDoc.Controls.Add(Me.cbEstadoCivil)
        Me.gbDatDoc.Controls.Add(Me.Label1)
        Me.gbDatDoc.Controls.Add(Me.txtDui)
        Me.gbDatDoc.Controls.Add(Me.Label31)
        Me.gbDatDoc.Controls.Add(Me.txtApe2)
        Me.gbDatDoc.Controls.Add(Me.Label9)
        Me.gbDatDoc.Controls.Add(Me.txtNombres)
        Me.gbDatDoc.Controls.Add(Me.Label10)
        Me.gbDatDoc.Controls.Add(Me.txtApe1)
        Me.gbDatDoc.Controls.Add(Me.Label8)
        Me.gbDatDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbDatDoc.Location = New System.Drawing.Point(13, 42)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(883, 285)
        Me.gbDatDoc.TabIndex = 1
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Datos Personales"
        '
        'txtEdad
        '
        Me.txtEdad.AcceptsReturn = True
        Me.txtEdad.BackColor = System.Drawing.Color.White
        Me.txtEdad.Location = New System.Drawing.Point(550, 181)
        Me.txtEdad.MaxLength = 25
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(307, 23)
        Me.txtEdad.TabIndex = 173
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.Location = New System.Drawing.Point(120, 213)
        Me.txtDireccion.MaxLength = 100
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(737, 23)
        Me.txtDireccion.TabIndex = 172
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(8, 215)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(87, 18)
        Me.Label32.TabIndex = 171
        Me.Label32.Text = "Dirección:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCel
        '
        Me.txtCel.AcceptsReturn = True
        Me.txtCel.BackColor = System.Drawing.Color.White
        Me.txtCel.Location = New System.Drawing.Point(550, 243)
        Me.txtCel.MaxLength = 25
        Me.txtCel.Name = "txtCel"
        Me.txtCel.ReadOnly = True
        Me.txtCel.Size = New System.Drawing.Size(307, 23)
        Me.txtCel.TabIndex = 168
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(434, 245)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(108, 18)
        Me.Label25.TabIndex = 167
        Me.Label25.Text = "Celular:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelCasa
        '
        Me.txtTelCasa.AcceptsReturn = True
        Me.txtTelCasa.BackColor = System.Drawing.Color.White
        Me.txtTelCasa.Location = New System.Drawing.Point(120, 243)
        Me.txtTelCasa.MaxLength = 25
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.ReadOnly = True
        Me.txtTelCasa.Size = New System.Drawing.Size(307, 23)
        Me.txtTelCasa.TabIndex = 166
        '
        'lblTelCasa
        '
        Me.lblTelCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelCasa.ForeColor = System.Drawing.Color.Black
        Me.lblTelCasa.Location = New System.Drawing.Point(8, 245)
        Me.lblTelCasa.Name = "lblTelCasa"
        Me.lblTelCasa.Size = New System.Drawing.Size(106, 18)
        Me.lblTelCasa.TabIndex = 165
        Me.lblTelCasa.Text = "Teléfono Casa:"
        Me.lblTelCasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(434, 187)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 18)
        Me.Label23.TabIndex = 143
        Me.Label23.Text = "Edad:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.Location = New System.Drawing.Point(550, 22)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(307, 23)
        Me.txtNoSocio.TabIndex = 142
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(426, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 19)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "No. Asociado"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe3
        '
        Me.txtApe3.AcceptsReturn = True
        Me.txtApe3.BackColor = System.Drawing.Color.White
        Me.txtApe3.Location = New System.Drawing.Point(120, 113)
        Me.txtApe3.MaxLength = 25
        Me.txtApe3.Name = "txtApe3"
        Me.txtApe3.ReadOnly = True
        Me.txtApe3.Size = New System.Drawing.Size(307, 23)
        Me.txtApe3.TabIndex = 140
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(7, 110)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 33)
        Me.Label21.TabIndex = 139
        Me.Label21.Text = "Apellido de Casada"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Enabled = False
        Me.dtpFecNac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNac.Location = New System.Drawing.Point(120, 183)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(307, 23)
        Me.dtpFecNac.TabIndex = 136
        Me.dtpFecNac.Value = New Date(2017, 12, 26, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(7, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 31)
        Me.Label17.TabIndex = 137
        Me.Label17.Text = "Fec. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecExtDui
        '
        Me.dtpFecExtDui.Enabled = False
        Me.dtpFecExtDui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecExtDui.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecExtDui.Location = New System.Drawing.Point(550, 147)
        Me.dtpFecExtDui.Name = "dtpFecExtDui"
        Me.dtpFecExtDui.Size = New System.Drawing.Size(307, 23)
        Me.dtpFecExtDui.TabIndex = 133
        Me.dtpFecExtDui.Value = New Date(2017, 12, 26, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(434, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 34)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "extensión DUI:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(7, 147)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 34)
        Me.Label16.TabIndex = 134
        Me.Label16.Text = "Lugar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "extensión DUI:"
        '
        'txtLugDui
        '
        Me.txtLugDui.BackColor = System.Drawing.Color.White
        Me.txtLugDui.Location = New System.Drawing.Point(120, 147)
        Me.txtLugDui.MaxLength = 25
        Me.txtLugDui.Name = "txtLugDui"
        Me.txtLugDui.ReadOnly = True
        Me.txtLugDui.Size = New System.Drawing.Size(307, 23)
        Me.txtLugDui.TabIndex = 132
        '
        'txtProf
        '
        Me.txtProf.BackColor = System.Drawing.Color.White
        Me.txtProf.Location = New System.Drawing.Point(550, 115)
        Me.txtProf.MaxLength = 100
        Me.txtProf.Name = "txtProf"
        Me.txtProf.ReadOnly = True
        Me.txtProf.Size = New System.Drawing.Size(307, 23)
        Me.txtProf.TabIndex = 131
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(436, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 19)
        Me.Label19.TabIndex = 130
        Me.Label19.Text = "Ocupación:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.BackColor = System.Drawing.Color.White
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.Enabled = False
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Acompañado", "Viudo"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(550, 83)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(307, 24)
        Me.cbEstadoCivil.TabIndex = 127
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(434, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 19)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Estado Civil:"
        '
        'txtDui
        '
        Me.txtDui.AcceptsReturn = True
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDui.Location = New System.Drawing.Point(120, 22)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(125, 21)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(7, 27)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 18)
        Me.Label31.TabIndex = 126
        Me.Label31.Text = "Dui:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe2
        '
        Me.txtApe2.AcceptsReturn = True
        Me.txtApe2.BackColor = System.Drawing.Color.White
        Me.txtApe2.Location = New System.Drawing.Point(120, 83)
        Me.txtApe2.MaxLength = 25
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.ReadOnly = True
        Me.txtApe2.Size = New System.Drawing.Size(307, 23)
        Me.txtApe2.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 18)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Apellido 2"
        '
        'txtNombres
        '
        Me.txtNombres.AcceptsReturn = True
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Location = New System.Drawing.Point(120, 53)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(307, 23)
        Me.txtNombres.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 19)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Nombres"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe1
        '
        Me.txtApe1.AcceptsReturn = True
        Me.txtApe1.BackColor = System.Drawing.Color.White
        Me.txtApe1.Location = New System.Drawing.Point(550, 53)
        Me.txtApe1.MaxLength = 25
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(307, 23)
        Me.txtApe1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(434, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Apellido 1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MetroButton3)
        Me.TabPage1.Controls.Add(Me.btnSaveTb1)
        Me.TabPage1.Controls.Add(Me.MetroButton1)
        Me.TabPage1.Controls.Add(Me.txtComentario)
        Me.TabPage1.Controls.Add(Me.dtpFecAnula)
        Me.TabPage1.Controls.Add(Me.lblAnula)
        Me.TabPage1.Controls.Add(Me.chkAnulado)
        Me.TabPage1.Controls.Add(Me.lblComentario)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(925, 620)
        Me.TabPage1.TabIndex = 8
        Me.TabPage1.Text = "Datos de Cuenta"
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(707, 568)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton3.TabIndex = 212
        Me.MetroButton3.Text = "Siguiente"
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'btnSaveTb1
        '
        Me.btnSaveTb1.Location = New System.Drawing.Point(804, 568)
        Me.btnSaveTb1.Name = "btnSaveTb1"
        Me.btnSaveTb1.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSaveTb1.TabIndex = 211
        Me.btnSaveTb1.Text = "&Guardar"
        Me.btnSaveTb1.UseSelectable = True
        Me.btnSaveTb1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(610, 568)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 210
        Me.MetroButton1.Text = "Atras"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtComentario
        '
        Me.txtComentario.AcceptsReturn = True
        Me.txtComentario.BackColor = System.Drawing.Color.White
        Me.txtComentario.Enabled = False
        Me.txtComentario.Location = New System.Drawing.Point(143, 523)
        Me.txtComentario.MaxLength = 255
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(744, 38)
        Me.txtComentario.TabIndex = 176
        '
        'dtpFecAnula
        '
        Me.dtpFecAnula.Enabled = False
        Me.dtpFecAnula.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecAnula.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecAnula.Location = New System.Drawing.Point(227, 493)
        Me.dtpFecAnula.Name = "dtpFecAnula"
        Me.dtpFecAnula.Size = New System.Drawing.Size(224, 23)
        Me.dtpFecAnula.TabIndex = 175
        Me.dtpFecAnula.Value = New Date(2017, 12, 26, 0, 0, 0, 0)
        '
        'lblAnula
        '
        Me.lblAnula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnula.ForeColor = System.Drawing.Color.Black
        Me.lblAnula.Location = New System.Drawing.Point(139, 497)
        Me.lblAnula.Name = "lblAnula"
        Me.lblAnula.Size = New System.Drawing.Size(67, 14)
        Me.lblAnula.TabIndex = 177
        Me.lblAnula.Text = "Fecha anulación:"
        Me.lblAnula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkAnulado
        '
        Me.chkAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAnulado.ForeColor = System.Drawing.Color.Maroon
        Me.chkAnulado.Location = New System.Drawing.Point(11, 492)
        Me.chkAnulado.Name = "chkAnulado"
        Me.chkAnulado.Size = New System.Drawing.Size(86, 27)
        Me.chkAnulado.TabIndex = 174
        Me.chkAnulado.Text = "&Anulado"
        '
        'lblComentario
        '
        Me.lblComentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComentario.ForeColor = System.Drawing.Color.Black
        Me.lblComentario.Location = New System.Drawing.Point(18, 523)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(86, 18)
        Me.lblComentario.TabIndex = 178
        Me.lblComentario.Text = "Comentario:"
        Me.lblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtEjecApertura)
        Me.GroupBox4.Controls.Add(Me.c1nCaja)
        Me.GroupBox4.Controls.Add(Me.txtCodEjecApertura)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.Label44)
        Me.GroupBox4.Controls.Add(Me.c1nRemesa)
        Me.GroupBox4.Controls.Add(Me.txtEjecMercadeo)
        Me.GroupBox4.Controls.Add(Me.c1nRenovacion)
        Me.GroupBox4.Controls.Add(Me.Label46)
        Me.GroupBox4.Controls.Add(Me.c1nTransferencia)
        Me.GroupBox4.Controls.Add(Me.txtCodEjecMercadeo)
        Me.GroupBox4.Controls.Add(Me.txtObs)
        Me.GroupBox4.Controls.Add(Me.Label43)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(11, 285)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(883, 200)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle del Monto Apertura"
        '
        'txtEjecApertura
        '
        Me.txtEjecApertura.BackColor = System.Drawing.Color.White
        Me.txtEjecApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecApertura.Location = New System.Drawing.Point(216, 164)
        Me.txtEjecApertura.MaxLength = 100
        Me.txtEjecApertura.Name = "txtEjecApertura"
        Me.txtEjecApertura.ReadOnly = True
        Me.txtEjecApertura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEjecApertura.Size = New System.Drawing.Size(660, 23)
        Me.txtEjecApertura.TabIndex = 200
        '
        'c1nCaja
        '
        Me.c1nCaja.BackColor = System.Drawing.Color.White
        Me.c1nCaja.CustomFormat = "###,###,##0.00"
        Me.c1nCaja.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCaja.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCaja.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCaja.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCaja.Location = New System.Drawing.Point(132, 22)
        Me.c1nCaja.Name = "c1nCaja"
        Me.c1nCaja.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCaja.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCaja.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCaja.Size = New System.Drawing.Size(307, 21)
        Me.c1nCaja.TabIndex = 0
        Me.c1nCaja.Tag = Nothing
        Me.c1nCaja.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCaja.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtCodEjecApertura
        '
        Me.txtCodEjecApertura.AcceptsReturn = True
        Me.txtCodEjecApertura.BackColor = System.Drawing.Color.White
        Me.txtCodEjecApertura.Location = New System.Drawing.Point(132, 164)
        Me.txtCodEjecApertura.MaxLength = 10
        Me.txtCodEjecApertura.Name = "txtCodEjecApertura"
        Me.txtCodEjecApertura.Size = New System.Drawing.Size(77, 23)
        Me.txtCodEjecApertura.TabIndex = 1
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(7, 27)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(48, 18)
        Me.Label35.TabIndex = 125
        Me.Label35.Text = "Caja:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(7, 167)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(123, 20)
        Me.Label44.TabIndex = 198
        Me.Label44.Text = "Ejecutivo Apertura:"
        '
        'c1nRemesa
        '
        Me.c1nRemesa.BackColor = System.Drawing.Color.White
        Me.c1nRemesa.CustomFormat = "###,###,##0.00"
        Me.c1nRemesa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nRemesa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nRemesa.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nRemesa.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nRemesa.Location = New System.Drawing.Point(568, 52)
        Me.c1nRemesa.Name = "c1nRemesa"
        Me.c1nRemesa.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nRemesa.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nRemesa.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nRemesa.Size = New System.Drawing.Size(308, 21)
        Me.c1nRemesa.TabIndex = 3
        Me.c1nRemesa.Tag = Nothing
        Me.c1nRemesa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nRemesa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtEjecMercadeo
        '
        Me.txtEjecMercadeo.BackColor = System.Drawing.Color.White
        Me.txtEjecMercadeo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeo.Location = New System.Drawing.Point(216, 134)
        Me.txtEjecMercadeo.MaxLength = 100
        Me.txtEjecMercadeo.Name = "txtEjecMercadeo"
        Me.txtEjecMercadeo.ReadOnly = True
        Me.txtEjecMercadeo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEjecMercadeo.Size = New System.Drawing.Size(660, 23)
        Me.txtEjecMercadeo.TabIndex = 197
        '
        'c1nRenovacion
        '
        Me.c1nRenovacion.BackColor = System.Drawing.Color.White
        Me.c1nRenovacion.CustomFormat = "###,###,##0.00"
        Me.c1nRenovacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nRenovacion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nRenovacion.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nRenovacion.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nRenovacion.Location = New System.Drawing.Point(132, 52)
        Me.c1nRenovacion.Name = "c1nRenovacion"
        Me.c1nRenovacion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nRenovacion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nRenovacion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nRenovacion.Size = New System.Drawing.Size(307, 21)
        Me.c1nRenovacion.TabIndex = 2
        Me.c1nRenovacion.Tag = Nothing
        Me.c1nRenovacion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nRenovacion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(7, 141)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(118, 16)
        Me.Label46.TabIndex = 196
        Me.Label46.Text = "Ejecutivo Gestión:"
        '
        'c1nTransferencia
        '
        Me.c1nTransferencia.BackColor = System.Drawing.Color.White
        Me.c1nTransferencia.CustomFormat = "###,###,##0.00"
        Me.c1nTransferencia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTransferencia.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTransferencia.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTransferencia.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTransferencia.Location = New System.Drawing.Point(568, 22)
        Me.c1nTransferencia.Name = "c1nTransferencia"
        Me.c1nTransferencia.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTransferencia.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTransferencia.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTransferencia.Size = New System.Drawing.Size(308, 21)
        Me.c1nTransferencia.TabIndex = 1
        Me.c1nTransferencia.Tag = Nothing
        Me.c1nTransferencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTransferencia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtCodEjecMercadeo
        '
        Me.txtCodEjecMercadeo.AcceptsReturn = True
        Me.txtCodEjecMercadeo.BackColor = System.Drawing.Color.White
        Me.txtCodEjecMercadeo.Location = New System.Drawing.Point(132, 134)
        Me.txtCodEjecMercadeo.MaxLength = 10
        Me.txtCodEjecMercadeo.Name = "txtCodEjecMercadeo"
        Me.txtCodEjecMercadeo.Size = New System.Drawing.Size(77, 23)
        Me.txtCodEjecMercadeo.TabIndex = 0
        '
        'txtObs
        '
        Me.txtObs.AcceptsReturn = True
        Me.txtObs.BackColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(132, 82)
        Me.txtObs.MaxLength = 0
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(744, 45)
        Me.txtObs.TabIndex = 4
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(7, 85)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(106, 19)
        Me.Label43.TabIndex = 199
        Me.Label43.Text = "Observaciones:"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.White
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(463, 57)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(101, 18)
        Me.Label42.TabIndex = 128
        Me.Label42.Text = "Remesa:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.White
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(7, 57)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(101, 18)
        Me.Label38.TabIndex = 127
        Me.Label38.Text = "Renovación:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.White
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(463, 27)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(101, 18)
        Me.Label37.TabIndex = 126
        Me.Label37.Text = "Transferencia:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.btTasaPactada)
        Me.GroupBox3.Controls.Add(Me.cbAutorizacion)
        Me.GroupBox3.Controls.Add(Me.lblAutorizadoPor)
        Me.GroupBox3.Controls.Add(Me.btEdit)
        Me.GroupBox3.Controls.Add(Me.Label60)
        Me.GroupBox3.Controls.Add(Me.txtCodAhorro)
        Me.GroupBox3.Controls.Add(Me.txtAhorro)
        Me.GroupBox3.Controls.Add(Me.txtFormaEntrega)
        Me.GroupBox3.Controls.Add(Me.txtPignorado)
        Me.GroupBox3.Controls.Add(Me.Label49)
        Me.GroupBox3.Controls.Add(Me.Label48)
        Me.GroupBox3.Controls.Add(Me.txtNoCertificado)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.dtpFecVenc)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.c1nTasa)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.c1nPlazo)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.c1nMontoApertura)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.dtpFechaApertura)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lblFecIniApertura)
        Me.GroupBox3.Controls.Add(Me.dtpFecIniApertura)
        Me.GroupBox3.Controls.Add(Me.Label59)
        Me.GroupBox3.Controls.Add(Me.txtDigito)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(11, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(883, 271)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Cuenta"
        '
        'btTasaPactada
        '
        Me.btTasaPactada.Location = New System.Drawing.Point(467, 197)
        Me.btTasaPactada.Name = "btTasaPactada"
        Me.btTasaPactada.Size = New System.Drawing.Size(117, 29)
        Me.btTasaPactada.Style = MetroFramework.MetroColorStyle.Green
        Me.btTasaPactada.TabIndex = 213
        Me.btTasaPactada.Text = "Modificar Tasa"
        Me.btTasaPactada.UseSelectable = True
        Me.btTasaPactada.UseStyleColors = True
        '
        'cbAutorizacion
        '
        Me.cbAutorizacion.BackColor = System.Drawing.Color.White
        Me.cbAutorizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAutorizacion.Enabled = False
        Me.cbAutorizacion.FormattingEnabled = True
        Me.cbAutorizacion.Location = New System.Drawing.Point(132, 233)
        Me.cbAutorizacion.Name = "cbAutorizacion"
        Me.cbAutorizacion.Size = New System.Drawing.Size(721, 25)
        Me.cbAutorizacion.TabIndex = 204
        '
        'lblAutorizadoPor
        '
        Me.lblAutorizadoPor.AutoSize = True
        Me.lblAutorizadoPor.Location = New System.Drawing.Point(7, 237)
        Me.lblAutorizadoPor.Name = "lblAutorizadoPor"
        Me.lblAutorizadoPor.Size = New System.Drawing.Size(106, 17)
        Me.lblAutorizadoPor.TabIndex = 203
        Me.lblAutorizadoPor.Text = "Autorizado Por:"
        '
        'btEdit
        '
        Me.btEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.ForeColor = System.Drawing.Color.Black
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.Location = New System.Drawing.Point(385, 76)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(54, 28)
        Me.btEdit.TabIndex = 202
        Me.btEdit.Text = "&Modificar"
        Me.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.UseVisualStyleBackColor = False
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(7, 20)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(106, 18)
        Me.Label60.TabIndex = 201
        Me.Label60.Text = "Tipo de Ahorro:"
        '
        'txtCodAhorro
        '
        Me.txtCodAhorro.AcceptsReturn = True
        Me.txtCodAhorro.BackColor = System.Drawing.Color.White
        Me.txtCodAhorro.Location = New System.Drawing.Point(132, 16)
        Me.txtCodAhorro.MaxLength = 10
        Me.txtCodAhorro.Name = "txtCodAhorro"
        Me.txtCodAhorro.ReadOnly = True
        Me.txtCodAhorro.Size = New System.Drawing.Size(77, 23)
        Me.txtCodAhorro.TabIndex = 199
        '
        'txtAhorro
        '
        Me.txtAhorro.BackColor = System.Drawing.Color.White
        Me.txtAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAhorro.Location = New System.Drawing.Point(216, 16)
        Me.txtAhorro.MaxLength = 110
        Me.txtAhorro.Name = "txtAhorro"
        Me.txtAhorro.ReadOnly = True
        Me.txtAhorro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAhorro.Size = New System.Drawing.Size(660, 23)
        Me.txtAhorro.TabIndex = 200
        '
        'txtFormaEntrega
        '
        Me.txtFormaEntrega.AcceptsReturn = True
        Me.txtFormaEntrega.BackColor = System.Drawing.Color.White
        Me.txtFormaEntrega.Location = New System.Drawing.Point(132, 142)
        Me.txtFormaEntrega.Name = "txtFormaEntrega"
        Me.txtFormaEntrega.ReadOnly = True
        Me.txtFormaEntrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFormaEntrega.Size = New System.Drawing.Size(307, 23)
        Me.txtFormaEntrega.TabIndex = 187
        '
        'txtPignorado
        '
        Me.txtPignorado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPignorado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPignorado.Location = New System.Drawing.Point(568, 142)
        Me.txtPignorado.MaxLength = 20
        Me.txtPignorado.Name = "txtPignorado"
        Me.txtPignorado.ReadOnly = True
        Me.txtPignorado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPignorado.Size = New System.Drawing.Size(308, 25)
        Me.txtPignorado.TabIndex = 182
        Me.txtPignorado.Text = "No"
        Me.txtPignorado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.White
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(463, 145)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(71, 20)
        Me.Label49.TabIndex = 181
        Me.Label49.Text = "Pignorada:"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.White
        Me.Label48.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(7, 137)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(70, 34)
        Me.Label48.TabIndex = 180
        Me.Label48.Text = "Forma de Entrega:"
        '
        'txtNoCertificado
        '
        Me.txtNoCertificado.BackColor = System.Drawing.Color.White
        Me.txtNoCertificado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCertificado.Location = New System.Drawing.Point(132, 76)
        Me.txtNoCertificado.MaxLength = 20
        Me.txtNoCertificado.Name = "txtNoCertificado"
        Me.txtNoCertificado.ReadOnly = True
        Me.txtNoCertificado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoCertificado.Size = New System.Drawing.Size(246, 25)
        Me.txtNoCertificado.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(7, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 18)
        Me.Label15.TabIndex = 171
        Me.Label15.Text = "No. Certificado:"
        '
        'dtpFecVenc
        '
        Me.dtpFecVenc.Enabled = False
        Me.dtpFecVenc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecVenc.Location = New System.Drawing.Point(568, 107)
        Me.dtpFecVenc.Name = "dtpFecVenc"
        Me.dtpFecVenc.Size = New System.Drawing.Size(308, 23)
        Me.dtpFecVenc.TabIndex = 3
        Me.dtpFecVenc.Value = New Date(2017, 12, 26, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(463, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 32)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vencimiento:"
        '
        'c1nTasa
        '
        Me.c1nTasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasa.CustomFormat = "#0.00"
        Me.c1nTasa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTasa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasa.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTasa.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasa.Location = New System.Drawing.Point(132, 202)
        Me.c1nTasa.Name = "c1nTasa"
        Me.c1nTasa.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasa.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasa.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasa.ReadOnly = True
        Me.c1nTasa.Size = New System.Drawing.Size(308, 23)
        Me.c1nTasa.TabIndex = 6
        Me.c1nTasa.Tag = Nothing
        Me.c1nTasa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(7, 202)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 18)
        Me.Label20.TabIndex = 156
        Me.Label20.Text = "Tasa Interés:"
        '
        'c1nPlazo
        '
        Me.c1nPlazo.BackColor = System.Drawing.Color.White
        Me.c1nPlazo.CustomFormat = "#0"
        Me.c1nPlazo.DataType = GetType(Short)
        Me.c1nPlazo.Enabled = False
        Me.c1nPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nPlazo.Location = New System.Drawing.Point(568, 45)
        Me.c1nPlazo.Name = "c1nPlazo"
        Me.c1nPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nPlazo.ReadOnly = True
        Me.c1nPlazo.Size = New System.Drawing.Size(308, 23)
        Me.c1nPlazo.TabIndex = 5
        Me.c1nPlazo.Tag = Nothing
        Me.c1nPlazo.Value = CType(0, Short)
        Me.c1nPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(463, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 18)
        Me.Label18.TabIndex = 152
        Me.Label18.Text = "Plazo:"
        '
        'c1nMontoApertura
        '
        Me.c1nMontoApertura.BackColor = System.Drawing.Color.White
        Me.c1nMontoApertura.CustomFormat = "###,###,##0.00"
        Me.c1nMontoApertura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoApertura.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoApertura.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMontoApertura.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoApertura.Location = New System.Drawing.Point(568, 76)
        Me.c1nMontoApertura.Name = "c1nMontoApertura"
        Me.c1nMontoApertura.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoApertura.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoApertura.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoApertura.Size = New System.Drawing.Size(308, 23)
        Me.c1nMontoApertura.TabIndex = 1
        Me.c1nMontoApertura.Tag = Nothing
        Me.c1nMontoApertura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoApertura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(463, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 28)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Monto de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apertura:"
        '
        'dtpFechaApertura
        '
        Me.dtpFechaApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaApertura.Location = New System.Drawing.Point(132, 107)
        Me.dtpFechaApertura.Name = "dtpFechaApertura"
        Me.dtpFechaApertura.Size = New System.Drawing.Size(307, 23)
        Me.dtpFechaApertura.TabIndex = 2
        Me.dtpFechaApertura.Value = New Date(2017, 12, 26, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 18)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Fecha Apertura:"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BackColor = System.Drawing.Color.White
        Me.txtNoCuenta.Location = New System.Drawing.Point(132, 46)
        Me.txtNoCuenta.MaxLength = 20
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.ReadOnly = True
        Me.txtNoCuenta.Size = New System.Drawing.Size(307, 23)
        Me.txtNoCuenta.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "No. Cuenta:"
        '
        'lblFecIniApertura
        '
        Me.lblFecIniApertura.BackColor = System.Drawing.Color.White
        Me.lblFecIniApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecIniApertura.ForeColor = System.Drawing.Color.Black
        Me.lblFecIniApertura.Location = New System.Drawing.Point(7, 177)
        Me.lblFecIniApertura.Name = "lblFecIniApertura"
        Me.lblFecIniApertura.Size = New System.Drawing.Size(123, 18)
        Me.lblFecIniApertura.TabIndex = 124
        Me.lblFecIniApertura.Text = "Última Renovación:"
        Me.lblFecIniApertura.Visible = False
        '
        'dtpFecIniApertura
        '
        Me.dtpFecIniApertura.Enabled = False
        Me.dtpFecIniApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIniApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIniApertura.Location = New System.Drawing.Point(132, 172)
        Me.dtpFecIniApertura.Name = "dtpFecIniApertura"
        Me.dtpFecIniApertura.Size = New System.Drawing.Size(112, 23)
        Me.dtpFecIniApertura.TabIndex = 1
        Me.dtpFecIniApertura.Value = New Date(2017, 12, 26, 0, 0, 0, 0)
        Me.dtpFecIniApertura.Visible = False
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(7, 50)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(111, 18)
        Me.Label59.TabIndex = 131
        Me.Label59.Text = "No. Cuenta:"
        '
        'txtDigito
        '
        Me.txtDigito.Location = New System.Drawing.Point(442, 46)
        Me.txtDigito.Name = "txtDigito"
        Me.txtDigito.Size = New System.Drawing.Size(12, 23)
        Me.txtDigito.TabIndex = 198
        Me.txtDigito.Visible = False
        '
        'tbCertDPF
        '
        Me.tbCertDPF.BackColor = System.Drawing.Color.White
        Me.tbCertDPF.Controls.Add(Me.cbNocuenta)
        Me.tbCertDPF.Controls.Add(Me.MetroButton2)
        Me.tbCertDPF.Controls.Add(Me.Label27)
        Me.tbCertDPF.Controls.Add(Me.cbAsentInt)
        Me.tbCertDPF.Controls.Add(Me.btnSaveTb4)
        Me.tbCertDPF.Controls.Add(Me.Label36)
        Me.tbCertDPF.Controls.Add(Me.MetroButton5)
        Me.tbCertDPF.Controls.Add(Me.btnDel)
        Me.tbCertDPF.Controls.Add(Me.btnEdit)
        Me.tbCertDPF.Controls.Add(Me.btnNew)
        Me.tbCertDPF.Controls.Add(Me.fgRep)
        Me.tbCertDPF.Controls.Add(Me.Label41)
        Me.tbCertDPF.Location = New System.Drawing.Point(4, 22)
        Me.tbCertDPF.Name = "tbCertDPF"
        Me.tbCertDPF.Size = New System.Drawing.Size(925, 620)
        Me.tbCertDPF.TabIndex = 6
        Me.tbCertDPF.Text = "Pago de Interés y Reposición"
        '
        'cbNocuenta
        '
        Me.cbNocuenta.FormattingEnabled = True
        Me.cbNocuenta.ItemHeight = 24
        Me.cbNocuenta.Location = New System.Drawing.Point(359, 37)
        Me.cbNocuenta.Name = "cbNocuenta"
        Me.cbNocuenta.Size = New System.Drawing.Size(307, 30)
        Me.cbNocuenta.TabIndex = 192
        Me.cbNocuenta.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(718, 579)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton2.TabIndex = 219
        Me.MetroButton2.Text = "Siguiente"
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(356, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(176, 18)
        Me.Label27.TabIndex = 186
        Me.Label27.Text = "No. Cuenta pago Interes:"
        '
        'cbAsentInt
        '
        Me.cbAsentInt.BackColor = System.Drawing.Color.White
        Me.cbAsentInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAsentInt.Items.AddRange(New Object() {"Mensualmente", "Vencimiento del Depósito"})
        Me.cbAsentInt.Location = New System.Drawing.Point(19, 40)
        Me.cbAsentInt.Name = "cbAsentInt"
        Me.cbAsentInt.Size = New System.Drawing.Size(307, 24)
        Me.cbAsentInt.TabIndex = 0
        '
        'btnSaveTb4
        '
        Me.btnSaveTb4.Location = New System.Drawing.Point(814, 579)
        Me.btnSaveTb4.Name = "btnSaveTb4"
        Me.btnSaveTb4.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb4.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSaveTb4.TabIndex = 218
        Me.btnSaveTb4.Text = "&Guardar"
        Me.btnSaveTb4.UseSelectable = True
        Me.btnSaveTb4.UseStyleColors = True
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(16, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(112, 21)
        Me.Label36.TabIndex = 188
        Me.Label36.Text = "Forma de pago:"
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(622, 579)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton5.TabIndex = 217
        Me.MetroButton5.Text = "Atras"
        Me.MetroButton5.UseSelectable = True
        Me.MetroButton5.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(211, 120)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(90, 32)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Green
        Me.btnDel.TabIndex = 216
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(115, 120)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 32)
        Me.btnEdit.Style = MetroFramework.MetroColorStyle.Green
        Me.btnEdit.TabIndex = 215
        Me.btnEdit.Text = "Modificar"
        Me.btnEdit.UseSelectable = True
        Me.btnEdit.UseStyleColors = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(19, 120)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 32)
        Me.btnNew.Style = MetroFramework.MetroColorStyle.Green
        Me.btnNew.TabIndex = 214
        Me.btnNew.Text = "Nuevo"
        Me.btnNew.UseSelectable = True
        Me.btnNew.UseStyleColors = True
        '
        'fgRep
        '
        Me.fgRep.AllowEditing = False
        Me.fgRep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgRep.BackColor = System.Drawing.Color.White
        Me.fgRep.ColumnInfo = "10,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgRep.Location = New System.Drawing.Point(19, 158)
        Me.fgRep.Name = "fgRep"
        Me.fgRep.Rows.Count = 1
        Me.fgRep.Rows.DefaultSize = 22
        Me.fgRep.Size = New System.Drawing.Size(886, 391)
        Me.fgRep.StyleInfo = resources.GetString("fgRep.StyleInfo")
        Me.fgRep.TabIndex = 4
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Green
        Me.Label41.Location = New System.Drawing.Point(16, 99)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(202, 18)
        Me.Label41.TabIndex = 14
        Me.Label41.Text = "Reposición Certificados DPF"
        '
        'tbPigRen
        '
        Me.tbPigRen.BackColor = System.Drawing.Color.White
        Me.tbPigRen.Controls.Add(Me.MetroButton4)
        Me.tbPigRen.Controls.Add(Me.MetroButton6)
        Me.tbPigRen.Controls.Add(Me.GroupBox9)
        Me.tbPigRen.Controls.Add(Me.fgPig)
        Me.tbPigRen.Controls.Add(Me.Label47)
        Me.tbPigRen.Controls.Add(Me.fgHist)
        Me.tbPigRen.Controls.Add(Me.Label7)
        Me.tbPigRen.Controls.Add(Me.gbPig)
        Me.tbPigRen.Location = New System.Drawing.Point(4, 22)
        Me.tbPigRen.Name = "tbPigRen"
        Me.tbPigRen.Size = New System.Drawing.Size(925, 620)
        Me.tbPigRen.TabIndex = 7
        Me.tbPigRen.Text = "Pignoraciones/Renovaciones"
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(815, 569)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton4.TabIndex = 221
        Me.MetroButton4.Text = "Siguiente"
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'MetroButton6
        '
        Me.MetroButton6.Location = New System.Drawing.Point(718, 569)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton6.TabIndex = 220
        Me.MetroButton6.Text = "Atras"
        Me.MetroButton6.UseSelectable = True
        Me.MetroButton6.UseStyleColors = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtPignorada)
        Me.GroupBox9.Controls.Add(Me.Label57)
        Me.GroupBox9.Location = New System.Drawing.Point(19, 9)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(106, 121)
        Me.GroupBox9.TabIndex = 185
        Me.GroupBox9.TabStop = False
        '
        'txtPignorada
        '
        Me.txtPignorada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPignorada.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPignorada.Location = New System.Drawing.Point(29, 65)
        Me.txtPignorada.MaxLength = 20
        Me.txtPignorada.Name = "txtPignorada"
        Me.txtPignorada.ReadOnly = True
        Me.txtPignorada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPignorada.Size = New System.Drawing.Size(38, 25)
        Me.txtPignorada.TabIndex = 186
        Me.txtPignorada.Text = "No"
        Me.txtPignorada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.White
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label57.Location = New System.Drawing.Point(10, 18)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(86, 37)
        Me.Label57.TabIndex = 185
        Me.Label57.Text = "Cuenta Pignorada"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fgPig
        '
        Me.fgPig.AllowEditing = False
        Me.fgPig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgPig.BackColor = System.Drawing.Color.White
        Me.fgPig.ColumnInfo = "10,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgPig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgPig.Location = New System.Drawing.Point(19, 166)
        Me.fgPig.Name = "fgPig"
        Me.fgPig.Rows.Count = 1
        Me.fgPig.Rows.DefaultSize = 22
        Me.fgPig.Size = New System.Drawing.Size(886, 191)
        Me.fgPig.StyleInfo = resources.GetString("fgPig.StyleInfo")
        Me.fgPig.TabIndex = 22
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Green
        Me.Label47.Location = New System.Drawing.Point(19, 144)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(202, 19)
        Me.Label47.TabIndex = 21
        Me.Label47.Text = "Historial de Pignoraciones"
        '
        'fgHist
        '
        Me.fgHist.AllowEditing = False
        Me.fgHist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgHist.BackColor = System.Drawing.Color.White
        Me.fgHist.ColumnInfo = "10,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgHist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgHist.Location = New System.Drawing.Point(19, 389)
        Me.fgHist.Name = "fgHist"
        Me.fgHist.Rows.Count = 1
        Me.fgHist.Rows.DefaultSize = 22
        Me.fgHist.Size = New System.Drawing.Size(886, 191)
        Me.fgHist.StyleInfo = resources.GetString("fgHist.StyleInfo")
        Me.fgHist.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(16, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Historial de Renovaciones"
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
        Me.gbPig.Controls.Add(Me.Label51)
        Me.gbPig.Controls.Add(Me.Label50)
        Me.gbPig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPig.ForeColor = System.Drawing.Color.Green
        Me.gbPig.Location = New System.Drawing.Point(125, 9)
        Me.gbPig.Name = "gbPig"
        Me.gbPig.Size = New System.Drawing.Size(758, 121)
        Me.gbPig.TabIndex = 0
        Me.gbPig.TabStop = False
        Me.gbPig.Text = "Datos Préstamo"
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.Color.White
        Me.txtPlazo.Culture = 17418
        Me.txtPlazo.CustomFormat = "#0.00"
        Me.txtPlazo.Enabled = False
        Me.txtPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtPlazo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtPlazo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtPlazo.Location = New System.Drawing.Point(448, 53)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.Size = New System.Drawing.Size(252, 23)
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
        Me.Label58.Location = New System.Drawing.Point(383, 58)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(48, 18)
        Me.Label58.TabIndex = 200
        Me.Label58.Text = "Plazo:"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVenc
        '
        Me.txtVenc.BackColor = System.Drawing.Color.White
        Me.txtVenc.Enabled = False
        Me.txtVenc.Location = New System.Drawing.Point(124, 53)
        Me.txtVenc.Name = "txtVenc"
        Me.txtVenc.ReadOnly = True
        Me.txtVenc.Size = New System.Drawing.Size(252, 23)
        Me.txtVenc.TabIndex = 199
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(7, 53)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(89, 23)
        Me.Label55.TabIndex = 198
        Me.Label55.Text = "Vencimiento:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApertura
        '
        Me.txtApertura.BackColor = System.Drawing.Color.White
        Me.txtApertura.Enabled = False
        Me.txtApertura.Location = New System.Drawing.Point(448, 22)
        Me.txtApertura.Name = "txtApertura"
        Me.txtApertura.ReadOnly = True
        Me.txtApertura.Size = New System.Drawing.Size(252, 23)
        Me.txtApertura.TabIndex = 197
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(383, 24)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(67, 19)
        Me.Label56.TabIndex = 196
        Me.Label56.Text = "Apertura:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.AcceptsReturn = True
        Me.txtCodPrestamo.BackColor = System.Drawing.Color.White
        Me.txtCodPrestamo.Location = New System.Drawing.Point(124, 22)
        Me.txtCodPrestamo.MaxLength = 20
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(252, 23)
        Me.txtCodPrestamo.TabIndex = 194
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label52.Location = New System.Drawing.Point(7, 25)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(71, 18)
        Me.Label52.TabIndex = 195
        Me.Label52.Text = "Préstamo:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(448, 83)
        Me.txtSaldo.MaxLength = 20
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSaldo.Size = New System.Drawing.Size(252, 25)
        Me.txtSaldo.TabIndex = 193
        '
        'txtMontoPignorado
        '
        Me.txtMontoPignorado.BackColor = System.Drawing.Color.White
        Me.txtMontoPignorado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPignorado.Location = New System.Drawing.Point(124, 83)
        Me.txtMontoPignorado.MaxLength = 20
        Me.txtMontoPignorado.Name = "txtMontoPignorado"
        Me.txtMontoPignorado.ReadOnly = True
        Me.txtMontoPignorado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMontoPignorado.Size = New System.Drawing.Size(252, 25)
        Me.txtMontoPignorado.TabIndex = 192
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.White
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label51.Location = New System.Drawing.Point(383, 83)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(57, 19)
        Me.Label51.TabIndex = 191
        Me.Label51.Text = "Saldo:"
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.White
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label50.Location = New System.Drawing.Point(7, 89)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(109, 18)
        Me.Label50.TabIndex = 190
        Me.Label50.Text = "Monto Pignorado:"
        '
        'tabDatGralII
        '
        Me.tabDatGralII.BackColor = System.Drawing.Color.White
        Me.tabDatGralII.Controls.Add(Me.MetroButton11)
        Me.tabDatGralII.Controls.Add(Me.btnContrato)
        Me.tabDatGralII.Controls.Add(Me.MetroButton8)
        Me.tabDatGralII.Controls.Add(Me.btnSaveTb3)
        Me.tabDatGralII.Controls.Add(Me.MetroButton10)
        Me.tabDatGralII.Controls.Add(Me.GroupBox7)
        Me.tabDatGralII.Controls.Add(Me.gbCancela)
        Me.tabDatGralII.Location = New System.Drawing.Point(4, 22)
        Me.tabDatGralII.Name = "tabDatGralII"
        Me.tabDatGralII.Size = New System.Drawing.Size(925, 620)
        Me.tabDatGralII.TabIndex = 5
        Me.tabDatGralII.Text = "Beneficiarios / Cancelación"
        '
        'MetroButton11
        '
        Me.MetroButton11.Location = New System.Drawing.Point(720, 570)
        Me.MetroButton11.Name = "MetroButton11"
        Me.MetroButton11.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton11.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton11.TabIndex = 224
        Me.MetroButton11.Text = "Certificado"
        Me.MetroButton11.UseSelectable = True
        Me.MetroButton11.UseStyleColors = True
        '
        'btnContrato
        '
        Me.btnContrato.Location = New System.Drawing.Point(623, 570)
        Me.btnContrato.Name = "btnContrato"
        Me.btnContrato.Size = New System.Drawing.Size(90, 32)
        Me.btnContrato.Style = MetroFramework.MetroColorStyle.Green
        Me.btnContrato.TabIndex = 223
        Me.btnContrato.Text = "Contrato"
        Me.btnContrato.UseSelectable = True
        Me.btnContrato.UseStyleColors = True
        '
        'MetroButton8
        '
        Me.MetroButton8.Location = New System.Drawing.Point(412, 570)
        Me.MetroButton8.Name = "MetroButton8"
        Me.MetroButton8.Size = New System.Drawing.Size(204, 32)
        Me.MetroButton8.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton8.TabIndex = 222
        Me.MetroButton8.Text = "Autorización de Transferencia"
        Me.MetroButton8.UseSelectable = True
        Me.MetroButton8.UseStyleColors = True
        '
        'btnSaveTb3
        '
        Me.btnSaveTb3.Location = New System.Drawing.Point(817, 570)
        Me.btnSaveTb3.Name = "btnSaveTb3"
        Me.btnSaveTb3.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb3.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSaveTb3.TabIndex = 221
        Me.btnSaveTb3.Text = "&Guardar"
        Me.btnSaveTb3.UseSelectable = True
        Me.btnSaveTb3.UseStyleColors = True
        '
        'MetroButton10
        '
        Me.MetroButton10.Location = New System.Drawing.Point(314, 570)
        Me.MetroButton10.Name = "MetroButton10"
        Me.MetroButton10.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton10.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton10.TabIndex = 220
        Me.MetroButton10.Text = "Atras"
        Me.MetroButton10.UseSelectable = True
        Me.MetroButton10.UseStyleColors = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.btDelBen)
        Me.GroupBox7.Controls.Add(Me.btEditBen)
        Me.GroupBox7.Controls.Add(Me.btNewBen)
        Me.GroupBox7.Controls.Add(Me.fgBen)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox7.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(897, 381)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Beneficiarios"
        '
        'btDelBen
        '
        Me.btDelBen.Location = New System.Drawing.Point(202, 22)
        Me.btDelBen.Name = "btDelBen"
        Me.btDelBen.Size = New System.Drawing.Size(90, 32)
        Me.btDelBen.Style = MetroFramework.MetroColorStyle.Green
        Me.btDelBen.TabIndex = 216
        Me.btDelBen.Text = "Eliminar"
        Me.btDelBen.UseSelectable = True
        Me.btDelBen.UseStyleColors = True
        '
        'btEditBen
        '
        Me.btEditBen.Location = New System.Drawing.Point(104, 22)
        Me.btEditBen.Name = "btEditBen"
        Me.btEditBen.Size = New System.Drawing.Size(90, 32)
        Me.btEditBen.Style = MetroFramework.MetroColorStyle.Green
        Me.btEditBen.TabIndex = 215
        Me.btEditBen.Text = "Modificar"
        Me.btEditBen.UseSelectable = True
        Me.btEditBen.UseStyleColors = True
        '
        'btNewBen
        '
        Me.btNewBen.Location = New System.Drawing.Point(7, 22)
        Me.btNewBen.Name = "btNewBen"
        Me.btNewBen.Size = New System.Drawing.Size(90, 32)
        Me.btNewBen.Style = MetroFramework.MetroColorStyle.Green
        Me.btNewBen.TabIndex = 214
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
        Me.fgBen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgBen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.fgBen.Location = New System.Drawing.Point(7, 61)
        Me.fgBen.Name = "fgBen"
        Me.fgBen.Rows.Count = 1
        Me.fgBen.Rows.DefaultSize = 22
        Me.fgBen.Size = New System.Drawing.Size(883, 300)
        Me.fgBen.StyleInfo = resources.GetString("fgBen.StyleInfo")
        Me.fgBen.TabIndex = 3
        '
        'gbCancela
        '
        Me.gbCancela.BackColor = System.Drawing.Color.White
        Me.gbCancela.Controls.Add(Me.dtpFecCanc)
        Me.gbCancela.Controls.Add(Me.Label53)
        Me.gbCancela.Controls.Add(Me.txtEjecMercadeoCanc)
        Me.gbCancela.Controls.Add(Me.txtCodEjecCanc)
        Me.gbCancela.Controls.Add(Me.Label54)
        Me.gbCancela.Controls.Add(Me.txtMotivoCancela)
        Me.gbCancela.Controls.Add(Me.Label45)
        Me.gbCancela.Enabled = False
        Me.gbCancela.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCancela.ForeColor = System.Drawing.Color.Green
        Me.gbCancela.Location = New System.Drawing.Point(10, 397)
        Me.gbCancela.Name = "gbCancela"
        Me.gbCancela.Size = New System.Drawing.Size(897, 166)
        Me.gbCancela.TabIndex = 1
        Me.gbCancela.TabStop = False
        Me.gbCancela.Text = "Cancelación de Cuenta"
        '
        'dtpFecCanc
        '
        Me.dtpFecCanc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCanc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCanc.Location = New System.Drawing.Point(192, 37)
        Me.dtpFecCanc.Name = "dtpFecCanc"
        Me.dtpFecCanc.Size = New System.Drawing.Size(101, 23)
        Me.dtpFecCanc.TabIndex = 0
        Me.dtpFecCanc.Value = New Date(2017, 12, 26, 0, 0, 0, 0)
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(29, 120)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(115, 18)
        Me.Label53.TabIndex = 181
        Me.Label53.Text = "Código Ejecutivo:"
        '
        'txtEjecMercadeoCanc
        '
        Me.txtEjecMercadeoCanc.BackColor = System.Drawing.Color.White
        Me.txtEjecMercadeoCanc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeoCanc.Location = New System.Drawing.Point(278, 120)
        Me.txtEjecMercadeoCanc.MaxLength = 100
        Me.txtEjecMercadeoCanc.Name = "txtEjecMercadeoCanc"
        Me.txtEjecMercadeoCanc.ReadOnly = True
        Me.txtEjecMercadeoCanc.Size = New System.Drawing.Size(612, 23)
        Me.txtEjecMercadeoCanc.TabIndex = 3
        '
        'txtCodEjecCanc
        '
        Me.txtCodEjecCanc.AcceptsReturn = True
        Me.txtCodEjecCanc.BackColor = System.Drawing.Color.White
        Me.txtCodEjecCanc.Location = New System.Drawing.Point(192, 120)
        Me.txtCodEjecCanc.MaxLength = 10
        Me.txtCodEjecCanc.Name = "txtCodEjecCanc"
        Me.txtCodEjecCanc.Size = New System.Drawing.Size(77, 23)
        Me.txtCodEjecCanc.TabIndex = 2
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(29, 37)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(153, 18)
        Me.Label54.TabIndex = 179
        Me.Label54.Text = "Fecha de Cancelación:"
        '
        'txtMotivoCancela
        '
        Me.txtMotivoCancela.AcceptsReturn = True
        Me.txtMotivoCancela.BackColor = System.Drawing.Color.White
        Me.txtMotivoCancela.Location = New System.Drawing.Point(192, 74)
        Me.txtMotivoCancela.Multiline = True
        Me.txtMotivoCancela.Name = "txtMotivoCancela"
        Me.txtMotivoCancela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoCancela.Size = New System.Drawing.Size(698, 37)
        Me.txtMotivoCancela.TabIndex = 1
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(29, 74)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(153, 18)
        Me.Label45.TabIndex = 176
        Me.Label45.Text = "Motivo de Cancelación:"
        '
        'frmMsAhCuentasDPF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(986, 760)
        Me.Controls.Add(Me.tbSolic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhCuentasDPF"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Cuenta Deposito a Plazo Fijo"
        Me.tbSolic.ResumeLayout(False)
        Me.tbDatGral.ResumeLayout(False)
        Me.tbDatGral.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.c1nCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nRemesa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nRenovacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoApertura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCertDPF.ResumeLayout(False)
        CType(Me.fgRep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbPigRen.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.fgPig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgHist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPig.ResumeLayout(False)
        Me.gbPig.PerformLayout()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatGralII.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.fgBen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCancela.ResumeLayout(False)
        Me.gbCancela.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, vTipo As String, vConsulta As Boolean, vCancela As Boolean
    Private pTasaVigente As Boolean
    'Nuevas Variables 25/10/2013
    Dim ModificacionTasa As Boolean = False
    Dim ahorros As New wrAhorro.wsLibAhorro
    'Protected Sub validarContrato(ByVal codTipoAhorro As String)
    '    Dim dts As New DataSet
    '    dts = ahorros.consultarAhContratos_Ahorro(codTipoAhorro)
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

    Protected Sub llenarCbAutorizacion(ByVal codEmpleado As String, ByVal opcion As Integer, ByVal idAutorizacion As Integer)
        Dim dts As New DataSet
        dts = ahorros.consultarAhAutorizacionTasasDpf(codEmpleado, opcion, idAutorizacion)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbAutorizacion.DataSource = dts.Tables(0)
        End If
    End Sub
    Private Sub frmMsAhCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim oPerif As New wrAhorro.wsLibAhorro, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Dim oAsoc As New wrAsociados.wsLibAsoc, x As Integer, dr As DataRow, FechaNac As Date
            Dim oCred As New wrCredito.wsLibCred, oPrest As New wrPrestamo.wsLibPrest
            Dim oPl As New wrPlanilla.wsLibPlanilla, oBanco As New wrBancos.wsLibBancos

            Me.txtDui.Focus()

            Me.cbDoc.SelectedIndex = 0
            Me.dtpFechaApertura.Value = Now
            Me.dtpFecIniApertura.Value = Now
            Me.dtpFecVenc.Value = Now
            Me.lblEstado.Text = ""

            Dim dsTemp As New DataSet, drTemp As DataRow
            dsTemp = oAsoc.ConsultarParentescos("*", "", "CodParentesco", sUsuario, sPassword, sSucursal)

            cbParentesco.DisplayMember = "Descripcion"
            cbParentesco.ValueMember = "CodParentesco"
            cbParentesco.DataSource = dsTemp.Tables(0)
            cbPar.DisplayMember = "Descripcion"
            cbPar.ValueMember = "CodParentesco"
            cbPar.DataSource = dsTemp.Tables(0)

            'For Each drTemp In dsTemp.Tables(0).Rows
            '    cbParentesco.Items.Add(CStr(drTemp("CodParentesco")).Trim & " - " & CStr(drTemp("Descripcion")).Trim)
            '    cbPar.Items.Add(CStr(drTemp("Descripcion")).Trim)
            'Next

            Me.cbParentesco.SelectedIndex = 0
            Me.cbPar.SelectedIndex = 0
            llenarEstadoCivil()
            '=====================================================
            '25/10/2013 Javier Martinez
            'Se incluye cb para detalle de persona que autoriza cambio de tasa
            Me.cbAutorizacion.DisplayMember = "Empleado"
            Me.cbAutorizacion.ValueMember = "idAutorizacion"
            llenarCbAutorizacion("", 1, 0)
            Me.cbAutorizacion.Enabled = False
            '=====================================================

            If Me.pAccion = "Modificar" Then

                ds = oPerif.ConsultarCuentaAhorro("*", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    '==========================================================================
                    If IsDBNull(Filas.Item(0)("idAutorizacion")) = False Then
                        ModificacionTasa = True
                        Me.cbAutorizacion.SelectedValue = Filas.Item(0)("idAutorizacion")
                        Me.cbAutorizacion.Enabled = False
                    End If
                    '==========================================================================
                    Me.txtDui.Value = IIf(IsDBNull(Filas.Item(0)("Dui")), "", Filas.Item(0)("Dui"))
                    llenarCuentasPagoInt()
                    Me.txtNoCuenta.Text = pNoCuenta
                    Me.dtpFechaApertura.Value = IIf(IsDBNull(Filas.Item(0)("FechaApertura")), Now, Filas.Item(0)("FechaApertura"))
                    Me.dtpFecIniApertura.Value = IIf(IsDBNull(Filas.Item(0)("FechaInicioApertura")), Now, Filas.Item(0)("FechaInicioApertura"))
                    Me.txtCodTipoAhorro.Text = pCodTipoAhorro
                    Me.txtCodAhorro.Text = pCodTipoAhorro
                    ' validarContrato(pCodTipoAhorro)
                    Me.vTipo = "DPF"
                    Me.tbCertDPF.Enabled = True
                    Me.c1nPlazo.Enabled = True
                    Me.btEdit.Visible = False
                    Me.txtNoCertificado.Size = New Size(144, 21)
                    If IIf(IsDBNull(Filas.Item(0)("Estado")), "", Filas.Item(0)("Estado")) = "C" Then
                        Me.lblEstado.Text = "Cuenta Cancelada"
                    End If
                    If IIf(IsDBNull(Filas.Item(0)("Estado")), "", Filas.Item(0)("Estado")) = "D" Then
                        Me.chkAnulado.Visible = True
                        Me.lblAnula.Visible = True
                        Me.dtpFecAnula.Visible = True
                        Me.lblComentario.Visible = True
                        Me.txtComentario.Visible = True
                        Me.dtpFecAnula.Value = IIf(IsDBNull(Filas.Item(0)("FechaAnula")), Now, Filas.Item(0)("FechaAnula"))
                        If IIf(IsDBNull(Filas.Item(0)("Anulado")), "", Filas.Item(0)("Anulado")) = "1" Then
                            Me.chkAnulado.Checked = True
                        Else
                            Me.chkAnulado.Checked = False
                        End If
                        Me.txtComentario.Text = IIf(IsDBNull(Filas.Item(0)("Comentario")), "", Filas.Item(0)("Comentario"))
                    Else
                        Me.chkAnulado.Visible = False
                        Me.lblAnula.Visible = False
                        Me.dtpFecAnula.Visible = False
                        Me.lblComentario.Visible = False
                        Me.txtComentario.Visible = False
                    End If

                    Me.c1nMontoApertura.Value = IIf(IsDBNull(Filas.Item(0)("MontoApertura")), 0, Filas.Item(0)("MontoApertura"))
                    Me.c1nPlazo.Value = IIf(IsDBNull(Filas.Item(0)("Plazo")), 0, Filas.Item(0)("Plazo"))
                    Me.c1nTasa.Value = IIf(IsDBNull(Filas.Item(0)("TasaInteres")), 0, Filas.Item(0)("TasaInteres"))
                    Me.dtpFecIniApertura.Value = IIf(IsDBNull(Filas.Item(0)("FechaPrimeraCuota")), Now, Filas.Item(0)("FechaPrimeraCuota"))
                    Me.cbDoc.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("TipoDocTit2")), 0, Filas.Item(0)("TipoDocTit2"))
                    Me.txtTitular2.Text = IIf(IsDBNull(Filas.Item(0)("Titular2")), "", Filas.Item(0)("Titular2"))
                    Me.txtPartida.Value = IIf(IsDBNull(Filas.Item(0)("PartidaNacTitular2")), "", Filas.Item(0)("PartidaNacTitular2"))
                    Me.txtCodEjecMercadeo.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecutivo")), "", Filas.Item(0)("CodEjecutivo"))
                    Me.dtpFecVenc.Value = IIf(IsDBNull(Filas.Item(0)("FechaVencimiento")), Now, Filas.Item(0)("FechaVencimiento"))
                    Me.txtObs.Text = IIf(IsDBNull(Filas.Item(0)("Observacion")), "", Filas.Item(0)("Observacion"))
                    Me.txtMotivoCancela.Text = IIf(IsDBNull(Filas.Item(0)("MotivoCancelacion")), "", Filas.Item(0)("MotivoCancelacion"))
                    Me.dtpFecCanc.Value = IIf(IsDBNull(Filas.Item(0)("FechaCancelacion")), Now, Filas.Item(0)("FechaCancelacion"))
                    Me.txtCodEjecCanc.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecCanc")), "", Filas.Item(0)("CodEjecCanc"))
                    Me.txtSaldo.Text = IIf(IsDBNull(Filas.Item(0)("SaldoDisponible_CuentaAhorro")), "", Filas.Item(0)("SaldoDisponible_CuentaAhorro"))
                    Me.txtNoCertificado.Text = IIf(IsDBNull(Filas.Item(0)("IdCertificadoDPF")), "", Filas.Item(0)("IdCertificadoDPF"))
                    Me.txtPignorado.Text = IIf(IIf(IsDBNull(Filas.Item(0)("Pignorado")), "N", Filas.Item(0)("Pignorado")) = "S", "Si", "No")
                    Me.txtPignorada.Text = IIf(IIf(IsDBNull(Filas.Item(0)("Pignorado")), "N", Filas.Item(0)("Pignorado")) = "S", "Si", "No")
                    Me.txtTel.Text = IIf(IsDBNull(Filas.Item(0)("TelTit2")), "", Filas.Item(0)("TelTit2"))
                    Me.dtpFecNacT2.Value = IIf(IsDBNull(Filas.Item(0)("FechaNacTit2")), Now, Filas.Item(0)("FechaNacTit2"))
                    Me.txtCelT2.Text = IIf(IsDBNull(Filas.Item(0)("CelTit2")), "", Filas.Item(0)("CelTit2"))
                    Me.txtCodEjecApertura.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecApertura")), "", Filas.Item(0)("CodEjecApertura"))
                    Me.c1nCaja.Value = IIf(IsDBNull(Filas.Item(0)("MontoCaja")), 0, Filas.Item(0)("MontoCaja"))
                    Me.c1nTransferencia.Value = IIf(IsDBNull(Filas.Item(0)("MontoTransferencia")), 0, Filas.Item(0)("MontoTransferencia"))
                    Me.c1nRenovacion.Value = IIf(IsDBNull(Filas.Item(0)("MontoRenovacion")), 0, Filas.Item(0)("MontoRenovacion"))
                    Me.c1nRemesa.Value = IIf(IsDBNull(Filas.Item(0)("MontoRemesa")), 0, Filas.Item(0)("MontoRemesa"))

                    If DateTime.IsLeapYear(Me.dtpFecNacT2.Value.Year) = True And Me.dtpFecNacT2.Value.Day = 29 And Me.dtpFecNacT2.Value.Month = 2 Then
                        FechaNac = "28/" & dtpFecNacT2.Value.Month & "/" & Now().Year
                    Else
                        FechaNac = dtpFecNacT2.Value.Day & "/" & dtpFecNacT2.Value.Month & "/" & Now().Year
                    End If
                    Me.txtEdadT2.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNacT2.Value, Now())
                    Me.dtpFechaApertura.Enabled = False
                    Me.c1nMontoApertura.Enabled = False
                    Me.c1nCaja.Enabled = False
                    Me.c1nTransferencia.Enabled = False
                    Me.c1nRenovacion.Enabled = False
                    Me.c1nRemesa.Enabled = False

                    If Filas.Item(0)("CodParentesco") Is DBNull.Value = False Then
                        Me.cbParentesco.SelectedValue = Filas.Item(0)("CodParentesco")
                    End If

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

                    ds = oPerif.CargarDatosPrestamosPignorados("distinct a.CodPrestamo,b.FechaOtorgamiento as Fecha_Apertura,FechaVencimiento as Fecha_Vencimiento,b.Monto, b.PlazoMeses as Plazo", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", sUsuario, sPassword, sSucursal)
                    Me.fgPig.DataSource = ds.Tables("AhPignoraciones")

                    ds = oPerif.ConsultarTipoAhorro("*", "CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtTipoAhorro.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                        Me.txtAhorro.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
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

                    ds = oPerif.ConsultarBeneficiarios("*", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' and CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgBen.DataSource = ds.Tables(0)
                    ActualizaGridBen()

                    ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in('2','1') ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        ' txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                        txtNombres.Text = IIf((Filas.Item(0)("Nombres")) Is DBNull.Value, "", CStr(Filas.Item(0)("Nombres")))
                        txtApe1.Text = IIf((Filas.Item(0)("Apellido1")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido1")).Trim)
                        txtApe2.Text = IIf((Filas.Item(0)("Apellido2")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido2")))
                        txtApe3.Text = IIf((Filas.Item(0)("ApellidoCas")) Is DBNull.Value, "", Filas.Item(0)("ApellidoCas"))
                        direccionAsociado(txtDui.Value)
                        If Filas.Item(0)("codEstadoCivil") Is DBNull.Value = False Then
                            cbEstadoCivil.SelectedValue = Filas.Item(0)("codEstadoCivil")
                        End If
                        txtLugDui.Text = IIf((Filas.Item(0)("LugarExtDUI")) Is DBNull.Value, " ", Filas.Item(0)("LugarExtDUI"))
                        dtpFecExtDui.Value = IIf((Filas.Item(0)("FechaExtDUI")) Is DBNull.Value, Now, Filas.Item(0)("FechaExtDUI"))
                        dtpFecNac.Value = IIf((Filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, Filas.Item(0)("Fecha_Nac"))
                        txtTelCasa.Text = IIf((Filas.Item(0)("TelCasa")) Is DBNull.Value, " ", Filas.Item(0)("TelCasa"))
                        txtCel.Text = IIf((Filas.Item(0)("Celular")) Is DBNull.Value, " ", Filas.Item(0)("Celular"))
                        If Filas.Item(0)("CodProfesion") Is DBNull.Value = False Then
                            Dim dtsProfesiones As New DataSet
                            dtsProfesiones = asociados.ConsultarProfesiones("codProfesion,descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
                            txtProf.Text = dtsProfesiones.Tables(0).Rows(0).Item("descripcion").ToString.ToUpper.Trim
                        End If


                        If DateTime.IsLeapYear(Me.dtpFecNac.Value.Year) = True And Me.dtpFecNac.Value.Day = 29 And Me.dtpFecNac.Value.Month = 2 Then
                            FechaNac = "28/" & dtpFecNac.Value.Month & "/" & Now().Year
                        Else
                            FechaNac = dtpFecNac.Value.Day & "/" & dtpFecNac.Value.Month & "/" & Now().Year
                        End If
                        Me.txtEdad.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNac.Value, Now())
                        Me.dtpFechaApertura.Focus()
                    End If

                    ds = oPerif.ConsultarCertificadosDPF("*", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' and CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "IdCertificadoDPF", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then

                        Me.cbAsentInt.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("FormaAsentaInt")), "", Filas.Item(0)("FormaAsentaInt"))
                        'Me.txtDirEntInt.Text = IIf(IsDBNull(Filas.Item(0)("DireccionEntregaIntereses")), "", Filas.Item(0)("DireccionEntregaIntereses"))
                        'Me.txtCodBanco.Text = IIf(IsDBNull(Filas.Item(0)("BancoEntregaIntereses")), "", Filas.Item(0)("BancoEntregaIntereses"))
                        'Me.txtCodTipoAhorroInt.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoAhorroInt")), "", Filas.Item(0)("CodTipoAhorroInt"))
                        Me.cbNocuenta.SelectedValue = IIf(IsDBNull(Filas.Item(0)("NumCuentaBancoEntregaInt")), "", Filas.Item(0)("NumCuentaBancoEntregaInt"))
                        btnSaveTb4.Text = "&Modificar"
                        btnEdit.Enabled = True
                        If vConsulta = False Then btnDel.Enabled = True

                    End If

                    ds = oPerif.ConsultarCertificadosDPF("IdCertificadoDPF as No_Certificado,Fecha as Fecha_Apertura,FechaCancelacion as Fecha_Cancelacion,Monto,Plazo,TasaInteres as Tasa_Interes", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' and CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "IdCertificadoDPF", sUsuario, sPassword, sSucursal)
                    fgHist.DataSource = ds.Tables(0)

                    ds = oPerif.ConsultarReposicionCertificadosDPF("NoSolicitud as No_Solicitud,FechaSolicitud as Fecha,IdCertificadoDPF as No_Certificado,Fecha as Fecha_Repos,Causa,FechaPublicacion1 as Fecha_Pub1,PeriodicoPublic1 as Periodico_Pub1,NoPaginaPublic1 as NoPag1,FechaPublicacion2 as Fecha_Pub2,PeriodicoPublic2 as Periodico_Pub2,NoPaginaPublic2 as NoPag2,FechaPublicacion3 as Fecha_Pub3,PeriodicoPublic3 as Periodico_Pub3,NoPaginaPublic3 as NoPag3,Estado", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' and CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "Fecha", sUsuario, sPassword, sSucursal)
                    fgRep.DataSource = ds.Tables(0)

                    ds = oPerif.MostrarMovimientos("*", "Fecha", pNoCuenta.Trim, "", Me.dtpFecIniApertura.Value.ToShortDateString, Now.ToShortDateString, wrAhorro.TipoCuenta.Ahorro, sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables("AhMovimientos").Rows()
                    If Filas.Count > 0 Then
                        Me.c1nMontoApertura.Enabled = False
                    End If

                End If

                Me.txtDui.Enabled = False
                Me.txtNombres.Enabled = False
                Me.txtApe1.Enabled = False
                Me.txtApe2.Enabled = False
                Me.txtCodTipoAhorro.Enabled = False
                Me.txtNoCuenta.Enabled = False
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
            Else
                tbCertDPF.Enabled = False
                gbPig.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCerrarTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnSigTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub



    Private Sub btnSaveTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.btnSaveTb1_Click(sender, e)
    End Sub

    Private Sub c1nTasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub



    Private Sub dtpFechaApertura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = 13 Then
            Me.txtCodTipoAhorro.Focus()
        End If
    End Sub

    Private Sub btnCerrarTb6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnAtrasTb6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub llenarCuentasPagoInt()
        Dim dts As New DataSet
        Me.cbNocuenta.DisplayMember = "NoCuenta"
        Me.cbNocuenta.ValueMember = "NoCuenta"
        dts = ahorro.ConsultarCuentaAhorroTipoAhorro("a.NoCuenta ", "Left(a.CodTipoAhorro,1)='3' and a.Dui='" & Me.txtDui.Value & "' and a.Estado= 'A' ", "a.NoCuenta", sUsuario, sPassword, sSucursal)

        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbNocuenta.DataSource = dts.Tables(0)
            Else
                MsgBox("Asociado no posee cuenta de ahorro, por favor crear cuenta de ahorro.", MsgBoxStyle.Critical)
                Me.Close()
            End If
        Else
            MsgBox("Asociado no posee cuenta de ahorro, por favor crear cuenta de ahorro.", MsgBoxStyle.Critical)
            Me.Close()
        End If
    End Sub

    'Private Sub txtNoCuentaEntInt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuentaEntInt.DoubleClick
    '    Try
    '        Dim frm As New frmAGenerico, Fila As DataRowCollection
    '        Dim sTexto As String, vCodTipoAhorro As String, pCodPlanAhorro As String

    '        If Me.txtCodBanco.Text.Trim <> "" Then Exit Sub

    '        frm.Text = "Buscar Cuenta"
    '        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow

    '        oAh = New wrAhorro.wsLibAhorro
    '        ds = oAh.ConsultarCuentaAhorroTipoAhorro("a.CodTipoAhorro,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.NoCuentaAnterior,a.FechaApertura,a.Cuota,a.SaldoDisponible_CuentaAhorro as Saldo__", "Left(a.CodTipoAhorro,1)='3' and a.Dui='" & Me.txtDui.Value & "' and a.Estado<>'C' and a.Estado<>'B' and Pignorado='N'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
    '        frm.Datos = ds
    '        frm.ColSeleccion = 0
    '        frm.RefrescarGrid()
    '        frm.ShowDialog()
    '        If frm.Resultado.Trim = "" Then
    '        ElseIf frm.Resultado.Trim <> "" Then
    '            sTexto = frm.Resultado3.Trim
    '            ds = oAh.ConsultarCuentaAhorro("CodTipoAhorro,NoCuenta", "NoCuenta='" & sTexto.Trim & "' and Pignorado='N' and Estado<>'C' and Estado<>'B'", "NoCuenta", sUsuario, sPassword, sSucursal)
    '            dr = ds.Tables("AhCuentasAhorro").Rows(0)
    '            Me.txtNoCuentaEntInt.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
    '            Me.txtCodTipoAhorroInt.Text = IIf(IsDBNull(dr("CodTipoAhorro")), "", dr("CodTipoAhorro"))
    '            vCancela = False
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub cbEnt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEnt.SelectedIndexChanged
    '    If Me.cbEnt.SelectedIndex = 0 Then 'Cuenta de Ahorro
    '        Me.txtDirEntInt.ReadOnly = True
    '        Me.txtCodBanco.ReadOnly = True
    '        'Me.txtNoCuentaEntInt.ReadOnly = False
    '        Me.txtNoCuentaBanco.ReadOnly = True
    '        Me.txtNoCuentaBanco.Text = ""
    '        Me.txtDirEntInt.Text = ""
    '        Me.txtCodBanco.Text = ""
    '        Me.txtBanco.Text = ""
    '    ElseIf Me.cbEnt.SelectedIndex = 1 Then 'Oficina
    '        Me.txtDirEntInt.ReadOnly = False
    '        Me.txtCodBanco.ReadOnly = True
    '        Me.txtNoCuentaEntInt.ReadOnly = True
    '        Me.txtNoCuentaEntInt.Text = ""
    '        Me.txtNoCuentaBanco.ReadOnly = True
    '        Me.txtNoCuentaBanco.Text = ""
    '        Me.txtCodBanco.Text = ""
    '        Me.txtBanco.Text = ""
    '    ElseIf Me.cbEnt.SelectedIndex = 2 Then 'Casa
    '        Me.txtDirEntInt.ReadOnly = False
    '        Me.txtCodBanco.ReadOnly = True
    '        Me.txtNoCuentaEntInt.ReadOnly = True
    '        Me.txtNoCuentaEntInt.Text = ""
    '        Me.txtNoCuentaBanco.ReadOnly = True
    '        Me.txtNoCuentaBanco.Text = ""
    '        Me.txtCodBanco.Text = ""
    '        Me.txtBanco.Text = ""
    '    ElseIf Me.cbEnt.SelectedIndex = 3 Then 'Cuenta Banco Local
    '        Me.txtDirEntInt.ReadOnly = True
    '        Me.txtCodBanco.ReadOnly = False
    '        Me.txtNoCuentaEntInt.ReadOnly = True
    '        Me.txtNoCuentaEntInt.Text = ""
    '        Me.txtNoCuentaBanco.ReadOnly = False
    '        Me.txtNoCuentaBanco.Text = ""
    '        Me.txtDirEntInt.Text = ""
    '    End If
    'End Sub


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
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeoCanc.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtEjecMercadeoCanc.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                    End If
                Else
                    txtCodEjecCanc_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtCodEjecCanc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecCanc.DoubleClick
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
            txtCodEjecCanc.Text = ofrm.Resultado.Trim
            txtEjecMercadeoCanc.Text = ofrm.Resultado2.Trim
            Me.txtObs.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtCodEjecMercadeo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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



    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Try
            Dim ofrm As New frmAGenerico
            ofrm.Text = "Buscar Asociados"
            Dim Filas As Data.DataRowCollection
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2", "EstadoIngreso in('2','1') and EstadoAsociado='25'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtDui.Value = ofrm.Resultado.Trim
            Me.txtTitular2.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress

        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtDui.Text.Trim = "" Then
                    txtDui_DoubleClick(sender, e)
                Else
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                    ' ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,EstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Value & "' and EstadoIngreso in ('2','1') and EstadoAsociado='25' ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') and EstadoAsociado='25' ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        'txtDui.Text = IIf(CStr(Filas.Item(0)("DUI")).Trim Is DBNull.Value, "", Filas.Item(0)("DUI").ToString.Trim)
                        Me.txtTitular2.Focus()
                        '    txtNombres.Text = IIf(CStr(Filas.Item(0)("Nombres")).Trim Is DBNull.Value, "", CStr(Filas.Item(0)("Nombres")))
                        '    txtApe1.Text = IIf(CStr(Filas.Item(0)("Apellido1")).Trim Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido1")).Trim)
                        '    txtApe2.Text = IIf(CStr(Filas.Item(0)("Apellido2")).Trim Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido2")))
                        '    txtApe3.Text = IIf(CStr(Filas.Item(0)("ApellidoCas")).Trim Is DBNull.Value, "", Filas.Item(0)("ApellidoCas"))
                        '    direccionAsociado(txtDui.Text)
                        '    'txtDireccion.Text = IIf(CStr(Filas.Item(0)("Direccion")).Trim Is DBNull.Value, "", Filas.Item(0)("Direccion"))
                        '    cbEstadoCivil.SelectedValue = IIf(CStr(Filas.Item(0)("codEstadoCivil")) Is DBNull.Value, "", Filas.Item(0)("codEstadoCivil"))
                        '    Dim pCodProf As String
                        '    txtLugDui.Text = IIf(CStr(Filas.Item(0)("LugarExtDUI")).Trim Is DBNull.Value, "", Filas.Item(0)("LugarExtDUI"))
                        '    dtpFecExtDui.Value = IIf((Filas.Item(0)("FechaExtDUI")) Is DBNull.Value, Now, Filas.Item(0)("FechaExtDUI"))
                        '    dtpFecNac.Value = IIf((Filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, Filas.Item(0)("Fecha_Nac"))
                        '    txtTelCasa.Text = IIf(CStr(Filas.Item(0)("TelCasa")).Trim Is DBNull.Value, "", Filas.Item(0)("TelCasa"))
                        '    ' txtTelOfic.Text = IIf(CStr(Filas.Item(0)("TelOficina")).Trim Is DBNull.Value, "", Filas.Item(0)("TelOficina"))
                        '    txtCel.Text = IIf(CStr(Filas.Item(0)("Celular")).Trim Is DBNull.Value, "", Filas.Item(0)("Celular"))
                        '    pCodProf = IIf(CStr(Filas.Item(0)("CodProfesion")).Trim Is DBNull.Value, "", Filas.Item(0)("CodProfesion"))
                        '    Me.txtNoSocio.Text = IIf(CStr(Filas.Item(0)("NoSocio")).Trim Is DBNull.Value, "", Filas.Item(0)("NoSocio"))
                        '    ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(pCodProf) & "'", "", sUsuario, sPassword, sSucursal)

                        '    'Filas = ds.Tables(0).Rows()
                        '    'If Filas.Count > 0 Then
                        '    '    txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                        '    '    txtNombres.Text = CStr(Filas.Item(0)("Nombres")).Trim
                        '    '    txtApe1.Text = CStr(Filas.Item(0)("Apellido1")).Trim
                        '    '    txtApe2.Text = CStr(Filas.Item(0)("Apellido2")).Trim
                        '    '    cbEstadoCivil.SelectedIndex = CStr(Filas.Item(0)("EstadoCivil"))
                        '    '    txtProf.Text = CStr(Filas.Item(0)("CodProfesion")).Trim
                        '    '    txtLugDui.Text = CStr(Filas.Item(0)("LugarExtDUI")).Trim
                        '    '    dtpFecExtDui.Value = CDate(Filas.Item(0)("FechaExtDUI"))
                        '    '    dtpFecNac.Value = CDate(Filas.Item(0)("Fecha_Nac"))
                        '    '    txtDireccion.Text = CStr(Filas.Item(0)("Direccion")).Trim
                        '    '    txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                        '    '    txtTelCasa.Text = CStr(Filas.Item(0)("TelCasa")).Trim
                        '    '    txtTelOfic.Text = CStr(Filas.Item(0)("TelOficina")).Trim
                        '    '    txtCel.Text = CStr(Filas.Item(0)("Celular")).Trim
                        '    '    ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtProf.Text) & "'", "", sUsuario, sPassword, sSucursal)
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
                    Else
                        txtDui_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus

        Try
            If txtDui.Text.Trim <> "" Then

                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') and EstadoAsociado='25' ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    'Generamos # DE CUENTA
                    Me.txtNoCuenta.Text = ahorro.generarNoCuentaTipoAhorro(txtDui.Value.Trim, txtCodTipoAhorro.Text.Trim, sUsuario, sPassword, sSucursal)
                    Me.txtNoCertificado.Text = ahorro.ObtenerCorrelativoCuentaAhorro("IdCertificadoDPF", sUsuario, sPassword, sSucursal)
                    Me.txtDigito.Text = ahorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                    '=================================================================================================================dx
                    'txtDui.Text = IIf((Filas.Item(0)("DUI")) Is DBNull.Value, "", Filas.Item(0)("DUI").ToString.Trim)
                    txtNombres.Text = IIf((Filas.Item(0)("Nombres")) Is DBNull.Value, "", CStr(Filas.Item(0)("Nombres")))
                    txtApe1.Text = IIf((Filas.Item(0)("Apellido1")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido1")).Trim)
                    txtApe2.Text = IIf((Filas.Item(0)("Apellido2")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido2")))
                    txtApe3.Text = IIf((Filas.Item(0)("ApellidoCas")) Is DBNull.Value, "", Filas.Item(0)("ApellidoCas"))
                    direccionAsociado(txtDui.Text)
                    'txtDireccion.Text = IIf(CStr(Filas.Item(0)("Direccion")).Trim Is DBNull.Value, "", Filas.Item(0)("Direccion"))
                    If Filas.Item(0)("codEstadoCivil") Is DBNull.Value = False Then
                        cbEstadoCivil.SelectedValue = Filas.Item(0)("codEstadoCivil")
                    End If
                    '   cbEstadoCivil.SelectedValue = IIf(CStr(Filas.Item(0)("codEstadoCivil")) Is DBNull.Value, "", Filas.Item(0)("codEstadoCivil"))
                    Dim pCodProf As String
                    txtLugDui.Text = IIf((Filas.Item(0)("LugarExtDUI")) Is DBNull.Value, "", Filas.Item(0)("LugarExtDUI"))
                    dtpFecExtDui.Value = IIf((Filas.Item(0)("FechaExtDUI")) Is DBNull.Value, Now, Filas.Item(0)("FechaExtDUI"))
                    dtpFecNac.Value = IIf((Filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, Filas.Item(0)("Fecha_Nac"))
                    txtTelCasa.Text = IIf((Filas.Item(0)("TelCasa")) Is DBNull.Value, "", Filas.Item(0)("TelCasa"))
                    ' txtTelOfic.Text = IIf(CStr(Filas.Item(0)("TelOficina")).Trim Is DBNull.Value, "", Filas.Item(0)("TelOficina"))
                    txtCel.Text = IIf((Filas.Item(0)("Celular")) Is DBNull.Value, "", Filas.Item(0)("Celular"))
                    pCodProf = IIf((Filas.Item(0)("CodProfesion")) Is DBNull.Value, "", Filas.Item(0)("CodProfesion"))
                    Me.txtNoSocio.Text = IIf((Filas.Item(0)("NoSocio")) Is DBNull.Value, "", Filas.Item(0)("NoSocio"))

                    ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtProf.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                            Me.txtProf.Text = (Filas.Item(0)("Descripcion")).ToString.ToUpper
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
                    llenarCuentasPagoInt()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
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
    Private Sub txtApe1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApe1.DoubleClick

        Try
            If txtApe1.Text.Trim = "" Then Exit Sub

            Dim ofrm As New frmAGenerico
            ofrm.Text = "Buscar Asociados"
            Dim Filas As Data.DataRowCollection
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2", "Apellido1 like '" & txtApe1.Text.Trim & "' and EstadoIngreso='2'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtDui.Text = ofrm.Resultado.Trim
            txtNombres.Text = ofrm.Resultado2.Trim
            txtApe1.Text = ofrm.Resultado3.Trim
            txtApe2.Text = ofrm.Resultado4.Trim
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,EstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Apellido1 like '" & txtApe1.Text & "%' and EstadoIngreso='2'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtDui.Text = CStr(Filas.Item(0)("DUI")).Trim
                txtNombres.Text = CStr(Filas.Item(0)("Nombres")).Trim
                txtApe1.Text = CStr(Filas.Item(0)("Apellido1")).Trim
                txtApe2.Text = CStr(Filas.Item(0)("Apellido2")).Trim
                cbEstadoCivil.SelectedIndex = CStr(Filas.Item(0)("EstadoCivil"))
                txtProf.Text = CStr(Filas.Item(0)("CodProfesion")).Trim
                txtLugDui.Text = CStr(Filas.Item(0)("LugarExtDUI")).Trim
                dtpFecExtDui.Value = CDate(Filas.Item(0)("FechaExtDUI"))
                dtpFecNac.Value = CDate(Filas.Item(0)("Fecha_Nac"))
                txtDireccion.Text = CStr(Filas.Item(0)("Direccion")).Trim
                txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                txtTelCasa.Text = CStr(Filas.Item(0)("TelCasa")).Trim

                txtCel.Text = CStr(Filas.Item(0)("Celular")).Trim
                ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtProf.Text) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtProf.Text = CStr(Filas.Item(0)("Descripcion"))
                    End If
                End If

                Dim FechaNac As Date
                FechaNac = dtpFecNac.Value.Day & "/" & dtpFecNac.Value.Month & "/" & Now().Year
                Me.txtEdad.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNac.Value, Now())
                Me.dtpFechaApertura.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodTipoAhorro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.LostFocus
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, Filas As Data.DataRowCollection, dr As DataRow

            If txtCodTipoAhorro.Text.Trim = "" Then
            Else
                ds = oAhorro.ConsultarTipoAhorro("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtCodTipoAhorro.Text = CStr(Filas.Item(0)("CodTipoAhorro")).Trim
                    txtTipoAhorro.Text = CStr(Filas.Item(0)("Descripcion")).Trim
                    txtCodAhorro.Text = CStr(Filas.Item(0)("CodTipoAhorro")).Trim
                    txtAhorro.Text = CStr(Filas.Item(0)("Descripcion")).Trim
                    Me.vTipo = "DPF"
                    Me.txtNoCuenta.Text = oAhorro.GeneraNoCuenta(Trim(Me.txtCodTipoAhorro.Text), sSucursal, "03", Me.dtpFechaApertura.Value.Month, Me.dtpFechaApertura.Value.Year, sUsuario, sPassword, sSucursal)
                    Me.txtNoCertificado.Text = oAhorro.ObtenerCorrelativoCuentaAhorro("IdCertificadoDPF", sUsuario, sPassword, sSucursal)
                    Me.txtDigito.Text = oAhorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                    Me.c1nPlazo.Value = CStr(Filas.Item(0)("Plazo")).Trim
                    Me.dtpFecVenc.Value = Me.dtpFechaApertura.Value.AddDays(Me.c1nPlazo.Value - 1)
                    ds = oAhorro.ConsultarParametros("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables("AhParametros").Rows
                    If Filas.Count > 0 Then
                        dr = ds.Tables("AhParametros").Rows(0)
                        Me.c1nTasa.Value = IIf(IsDBNull(dr("TasaInteres")), 0, dr("TasaInteres"))
                        pTasaVigente = IIf(IIf(IsDBNull(dr("Promocion")), "0", dr("Promocion")) = "1", True, False)
                    End If
                    Me.c1nPlazo.Enabled = True
                    Me.txtDui.Focus()
                    ' validarContrato(txtCodTipoAhorro.Text.Trim)
                Else
                    txtCodTipoAhorro_DoubleClick(sender, e)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick
        Dim ofrm As New frmAGenerico
        Try
            'Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, 
            Dim ds As New Data.DataSet, dr As DataRow, Filas As Data.DataRowCollection
            ds = ahorros.consultarTiposAhorrosActivos("left(a.codtipoAhorro,1)= '" & libAhorro.tiposAhorro.dpf & "' ")

            ofrm.Text = "Buscar Tipos de Ahorro"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoAhorro.Text = ofrm.Resultado.Trim
            txtCodAhorro.Text = ofrm.Resultado.Trim
            If ofrm.Resultado.Trim = "" Then Exit Sub
            txtTipoAhorro.Text = ofrm.Resultado2.Trim
            txtAhorro.Text = ofrm.Resultado2.Trim
            Me.vTipo = "DPF"
            Me.txtNoCuenta.Text = ahorros.GeneraNoCuenta(Trim(Me.txtCodTipoAhorro.Text), sSucursal, "03", Me.dtpFechaApertura.Value.Month, Me.dtpFechaApertura.Value.Year, sUsuario, sPassword, sSucursal)
            Me.txtNoCertificado.Text = ahorros.ObtenerCorrelativoCuentaAhorro("IdCertificadoDPF", sUsuario, sPassword, sSucursal)
            Me.txtDigito.Text = ahorros.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
            Me.c1nPlazo.Value = ofrm.Resultado3.Trim
            Me.dtpFecVenc.Value = Me.dtpFechaApertura.Value.AddDays(Me.c1nPlazo.Value - 1)
            ds = ahorros.ConsultarParametros("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables("AhParametros").Rows
            If Filas.Count > 0 Then
                dr = ds.Tables("AhParametros").Rows(0)
                Me.c1nTasa.Value = IIf(IsDBNull(dr("TasaInteres")), 0, dr("TasaInteres"))
            End If
            Me.c1nPlazo.Enabled = True
            Me.txtDui.Focus()

            'validarContrato(txtCodTipoAhorro.Text.Trim)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodTipoAhorro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoAhorro.KeyPress
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, Filas As Data.DataRowCollection, dr As DataRow
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtCodTipoAhorro.Text.Trim = "" Then
                Else
                    ds = oAhorro.ConsultarTipoAhorro("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "' and Left(CodTipoAhorro,1)='" & libAhorro.tiposAhorro.dpf & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtCodTipoAhorro.Text = CStr(Filas.Item(0)("CodTipoAhorro")).Trim
                        txtCodAhorro.Text = CStr(Filas.Item(0)("CodTipoAhorro")).Trim
                        txtTipoAhorro.Text = CStr(Filas.Item(0)("Descripcion")).Trim
                        txtAhorro.Text = CStr(Filas.Item(0)("Descripcion")).Trim
                        Me.vTipo = "DPF"
                        Me.txtNoCuenta.Text = oAhorro.GeneraNoCuenta(Trim(Me.txtCodTipoAhorro.Text), sSucursal, "03", Me.dtpFechaApertura.Value.Month, Me.dtpFechaApertura.Value.Year, sUsuario, sPassword, sSucursal)
                        Me.txtNoCertificado.Text = oAhorro.ObtenerCorrelativoCuentaAhorro("IdCertificadoDPF", sUsuario, sPassword, sSucursal)
                        Me.txtDigito.Text = oAhorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                        Me.c1nPlazo.Value = CStr(Filas.Item(0)("Plazo")).Trim
                        Me.dtpFecVenc.Value = Me.dtpFechaApertura.Value.AddDays(Me.c1nPlazo.Value - 1)
                        ds = oAhorro.ConsultarParametros("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables("AhParametros").Rows
                        If Filas.Count > 0 Then
                            dr = ds.Tables("AhParametros").Rows(0)
                            Me.c1nTasa.Value = IIf(IsDBNull(dr("TasaInteres")), 0, dr("TasaInteres"))
                            pTasaVigente = IIf(IIf(IsDBNull(dr("Promocion")), "0", dr("Promocion")) = "1", True, False)
                        End If
                        Me.c1nPlazo.Enabled = True
                        Me.txtDui.Focus()
                        ' validarContrato(txtCodTipoAhorro.Text.Trim)
                    Else
                        txtCodTipoAhorro_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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

    Private Sub txtTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCelT2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelT2.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtCodEjecApertura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub dtpFecNacT2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecNacT2.ValueChanged
        Dim FechaNac As Date
        FechaNac = dtpFecNacT2.Value.Day & "/" & dtpFecNacT2.Value.Month & "/" & Now().Year
        Me.txtEdadT2.Text = IIf(DateDiff(DateInterval.Day, FechaNac, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNacT2.Value, Now())
    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String, pSaldoCapital As Double
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, oAhorro As New wrAhorro.wsLibAhorro
        Try
            oPrest = New wrPrestamo.wsLibPrest
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
                Else
                    Me.txtPignorada.Text = "No"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fgBen_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgBen.DoubleClick
        MetroButton2_Click_1(sender, e)
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

    Private Sub dtpFechaApertura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.dtpFecVenc.Value = Me.dtpFechaApertura.Value.AddDays(Me.c1nPlazo.Value - 1)
    End Sub

    Private Sub cbPar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPar.SelectedIndexChanged
        Me.cbParentesco.SelectedIndex = Me.cbPar.SelectedIndex
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkAnulado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.chkAnulado.Checked = True Then
            Me.dtpFecAnula.Enabled = True
            Me.txtComentario.Enabled = True
        Else
            Me.dtpFecAnula.Enabled = False
            Me.txtComentario.Enabled = False
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            Dim oPerif As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New DataSet
            Dim frm As frmMsAhRepCert = New frmMsAhRepCert
            frm.pNoCuenta = Me.pNoCuenta
            frm.pCodTipoAhorro = Me.pCodTipoAhorro
            frm.pNoCertificado = Me.txtNoCertificado.Text.Trim
            frm.pAccion = "Guardar"
            frm.btnSaveTb4.Text = "&Guardar"
            frm.ShowDialog()
            ds = oPerif.ConsultarReposicionCertificadosDPF("NoSolicitud as No_Solicitud,FechaSolicitud as Fecha,IdCertificadoDPF as No_Certificado,Fecha as Fecha_Repos,Causa,FechaPublicacion1 as Fecha_Pub1,PeriodicoPublic1 as Periodico_Pub1,NoPaginaPublic1 as NoPag1,FechaPublicacion2 as Fecha_Pub2,PeriodicoPublic2 as Periodico_Pub2,NoPaginaPublic2 as NoPag2,FechaPublicacion3 as Fecha_Pub3,PeriodicoPublic3 as Periodico_Pub3,NoPaginaPublic3 as NoPag3,Estado", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' and CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "Fecha desc", sUsuario, sPassword, sSucursal)
            fgRep.DataSource = ds.Tables(0)
            If ds.Tables(0).Rows.Count > 0 Then Me.txtNoCertificado.Text = Me.fgRep.Item(Me.fgRep.Row, "No_Certificado")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim oPerif As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New DataSet
        Try
            If Me.fgRep.Row <> -1 Then
                If Me.fgRep.Item(Me.fgRep.Row, "Estado") = "P" Then Exit Sub
                Dim frm As frmMsAhRepCert = New frmMsAhRepCert
                frm.pNoCuenta = Me.pNoCuenta
                frm.pNoCertificado = Me.txtNoCertificado.Text.Trim
                frm.txtNoSolicitud.ReadOnly = True
                frm.pCodTipoAhorro = Me.pCodTipoAhorro
                frm.pCorrelativo = Me.fgRep.Item(Me.fgRep.Row, "No_Solicitud")
                frm.pAccion = "Modificar"
                If Me.vConsulta = True Then frm.btnSaveTb4.Visible = False
                frm.btnSaveTb4.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ds = oPerif.ConsultarReposicionCertificadosDPF("NoSolicitud as No_Solicitud,FechaSolicitud as Fecha,IdCertificadoDPF as No_Certificado,Fecha as Fecha_Repos,Causa,FechaPublicacion1 as Fecha_Pub1,PeriodicoPublic1 as Periodico_Pub1,NoPaginaPublic1 as NoPag1,FechaPublicacion2 as Fecha_Pub2,PeriodicoPublic2 as Periodico_Pub2,NoPaginaPublic2 as NoPag2,FechaPublicacion3 as Fecha_Pub3,PeriodicoPublic3 as Periodico_Pub3,NoPaginaPublic3 as NoPag3,Estado", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' and CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "Fecha desc", sUsuario, sPassword, sSucursal)
                fgRep.DataSource = ds.Tables(0)
                Me.txtNoCertificado.Text = Me.fgRep.Item(Me.fgRep.Row, "No_Certificado")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Dim ds As New DataSet
            If Me.fgRep.Row <> -1 Then
                If Me.fgRep.Item(Me.fgRep.Row, "Estado") = "P" Then Exit Sub
                If MsgBox("¿Desea eliminar el Registro No. " & Trim(Me.fgRep.Item(Me.fgRep.Row, "No_Solicitud")) & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Registro") = MsgBoxResult.Yes Then
                    Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oAh.EliminarReposicionCertificadosDPF(Me.fgRep.Item(Me.fgRep.Row, "No_Solicitud"), sUsuario, sPassword, sSucursal)
                    ds = oAh.ConsultarReposicionCertificadosDPF("NoSolicitud as No_Solicitud,FechaSolicitud as Fecha,IdCertificadoDPF as No_Certificado,Fecha as Fecha_Repos,Causa,FechaPublicacion1 as Fecha_Pub1,PeriodicoPublic1 as Periodico_Pub1,NoPaginaPublic1 as NoPag1,FechaPublicacion2 as Fecha_Pub2,PeriodicoPublic2 as Periodico_Pub2,NoPaginaPublic2 as NoPag2,FechaPublicacion3 as Fecha_Pub3,PeriodicoPublic3 as Periodico_Pub3,NoPaginaPublic3 as NoPag3,Estado", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' and CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "Fecha desc", sUsuario, sPassword, sSucursal)
                    fgRep.DataSource = ds.Tables(0)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub MetroButton3_Click_1(sender As Object, e As EventArgs) Handles btNewBen.Click
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

    Private Sub MetroButton2_Click_1(sender As Object, e As EventArgs) Handles btEditBen.Click
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

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btDelBen.Click
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

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton3_Click_2(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub btnSaveTb1_Click(sender As Object, e As EventArgs) Handles btnSaveTb1.Click

        Try
            Dim oAh As New wrAhorro.wsLibAhorro, pCampos As String, pValores As String, dr As DataRow, pDocTitular As String
            Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection, pPignorado As String, vParentesco As String

            Select Case oAh.AutorizaDatos(txtDui.Text, "x", txtNoCuenta.Text, "x", txtCodTipoAhorro.Text)
                Case 1
                    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                Case 3
                    MsgBox("El campo No. Cuenta no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
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
                MsgBox("El Plazo no puede tener un valor negativo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                Exit Sub
            End If
            If Me.txtCodEjecMercadeo.Text.Trim.Length = 0 Then
                MsgBox("Por favor seleccionar el ejecutivo de mercadeo.", MsgBoxStyle.Critical, "Módulo Ahorros")
            End If

            ds = oAh.ConsultarParametros("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
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
            End If

            ds = oAsoc.ConsultarAsociado("*", "Dui='" & Trim(Me.txtDui.Text) & "' and EstadoAsociado='25' and EstadoIngreso in ('2','1') ", "DUI", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
            Else
                MsgBox("El Dui del Asociado no coincide con el Maestro de Asociados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                Exit Sub
            End If

            pDocTitular = Trim(Me.txtPartida.Text)
            vParentesco = cbParentesco.SelectedValue
            'vParentesco = Me.cbParentesco.Text.Substring(0, 5).Trim

            If Me.btnSaveTb1.Text = "&Guardar" Then
                Me.dtpFecIniApertura.Value = Me.dtpFechaApertura.Value
                pPignorado = "N"
                '==========================================
                If ModificacionTasa = True Then
                    pCampos = "Dui,CodTipoAhorro,NoCuenta,CodPrestamo,Titular2,PartidaNacTitular2,NoLibreta," &
                    "FechaInicioApertura,FechaApertura,FechaVencimiento,FechaPrimeraCuota,MontoApertura,Plazo, " &
                    "Monto,Cuota,NoCuotas,TasaInteres,CodEjecutivo,Estado,Observacion,Pignorado,Saldo_CuentaAhorro, " &
                    "SaldoDisponible_CuentaAhorro,TipoDocTit2,IdCertificadoDPF,Prorrogado,SaldoInteresPendiente, " &
                    "CodParentesco,TelTit2,Digito,CelTit2,CodEjecApertura,MontoCaja,MontoTransferencia,MontoRenovacion, " &
                    "MontoRemesa,NoSocio,idAutorizacion,FechaNacTit2"
                    pValores = "'" & Trim(Me.txtDui.Text) & "','" & Trim(Me.txtCodTipoAhorro.Text) &
                    "','" & Trim(Me.txtNoCuenta.Text) & "','','" & Trim(Me.txtTitular2.Text) &
                    "','" & pDocTitular & "','','" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") &
                    "','" & Format(Me.dtpFechaApertura.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") &
                    "','" & Format(Date.Today, "dd/MM/yyyy") & "'," & Val(Me.c1nMontoApertura.Value) &
                    "," & Val(Me.c1nPlazo.Value) & ",0,0,0," & Val(Me.c1nTasa.Value) &
                    ",'" & Trim(Me.txtCodEjecMercadeo.Text) & "','D','" & Trim(Me.txtObs.Text) &
                    "','" & pPignorado & "',0,0,'" & Me.cbDoc.SelectedIndex &
                    "','" & Me.txtNoCertificado.Text.Trim & "','N',0,'" & vParentesco &
                    "','" & Me.txtTel.Text.Trim & "','" & Me.txtDigito.Text.Trim &
                    "','" & Me.txtCelT2.Text.Trim & "','" & Me.txtCodEjecApertura.Text.Trim &
                    "'," & Val(c1nCaja.Value) & "," & Val(c1nTransferencia.Value) &
                    "," & Val(c1nRenovacion.Value) & "," & Val(c1nRemesa.Value) &
                    ",'" & Me.txtNoSocio.Text.Trim &
                    "', " & Me.cbAutorizacion.SelectedValue & ",  '" & Me.dtpFecNacT2.Value.ToShortDateString & "' "
                Else
                    pCampos = "Dui,CodTipoAhorro,NoCuenta,CodPrestamo,Titular2,PartidaNacTitular2,NoLibreta,FechaInicioApertura,FechaApertura,FechaVencimiento,FechaPrimeraCuota,MontoApertura,Plazo,Monto,Cuota,NoCuotas,TasaInteres,CodEjecutivo,Estado,Observacion,Pignorado,Saldo_CuentaAhorro,SaldoDisponible_CuentaAhorro,TipoDocTit2,IdCertificadoDPF,Prorrogado,SaldoInteresPendiente,CodParentesco,TelTit2,Digito,CelTit2,CodEjecApertura,MontoCaja,MontoTransferencia,MontoRenovacion,MontoRemesa,NoSocio,TasaVigente,FechaNacTit2"
                    pValores = "'" & Trim(Me.txtDui.Text) & "','" & Trim(Me.txtCodTipoAhorro.Text) & "','" & Trim(Me.txtNoCuenta.Text) & "','','" & Trim(Me.txtTitular2.Text) & "','" & pDocTitular & "','','" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFechaApertura.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") & "','" & Format(Date.Today, "dd/MM/yyyy") & "'," & Val(Me.c1nMontoApertura.Value) & "," & Val(Me.c1nPlazo.Value) & ",0,0,0," & Val(Me.c1nTasa.Value) & ",'" & Trim(Me.txtCodEjecMercadeo.Text) & "','D','" & Trim(Me.txtObs.Text) & "','" & pPignorado & "',0,0,'" & Me.cbDoc.SelectedIndex & "','" & Me.txtNoCertificado.Text.Trim & "','N',0,'" & vParentesco & "','" & Me.txtTel.Text.Trim & "','" & Me.txtDigito.Text.Trim & "','" & Me.txtCelT2.Text.Trim & "','" & Me.txtCodEjecApertura.Text.Trim & "'," & Val(c1nCaja.Value) & "," & Val(c1nTransferencia.Value) & "," & Val(c1nRenovacion.Value) & "," & Val(c1nRemesa.Value) & ",'" & Me.txtNoSocio.Text.Trim & "','1',  '" & Me.dtpFecNacT2.Value.ToShortDateString & "' "
                End If
                '==========================================

                If oAh.InsertarCuentaAhorro(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.txtDui.Enabled = False
                    Me.txtNombres.Enabled = False
                    Me.txtApe1.Enabled = False
                    Me.txtApe2.Enabled = False
                    Me.txtCodTipoAhorro.Enabled = False
                    Me.txtNoCuenta.Enabled = False
                    Me.btnNew.Enabled = True
                    Me.btnEdit.Enabled = True
                    Me.btDelBen.Enabled = True
                    Me.tbCertDPF.Enabled = True
                    Me.gbPig.Enabled = True
                    Me.dtpFechaApertura.Enabled = False
                    Me.btnSaveTb4.Enabled = True
                    btnSaveTb1.Text = "&Modificar"
                    Me.pCodTipoAhorro = Trim(Me.txtCodTipoAhorro.Text)
                    Me.pNoCuenta = Trim(Me.txtNoCuenta.Text)
                    Me.btEdit.Visible = False
                    Me.txtNoCertificado.Size = New Size(144, 21)
                    Me.txtNoCertificado.ReadOnly = True
                    Me.tbSolic.SelectedIndex = 1
                    vCancela = True
                    'Me.btnCerrarTb3.Enabled = False
                    'Me.btnCerrarTb1.Enabled = False
                    'Me.btnCerrarTb4.Enabled = False
                    'Me.btnCerrar2.Enabled = False
                Else
                    MsgBox("Los datos de la Cuenta de Ahorros NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            ElseIf Me.btnSaveTb1.Text = "&Modificar" Then
                Dim vAnul As String
                If Me.chkAnulado.Checked = True And Me.chkAnulado.Visible = True Then
                    vAnul = "1"
                Else
                    vAnul = "0"
                End If
                If ModificacionTasa = True Then
                    pCampos = "Titular2='" & Trim(Me.txtTitular2.Text) &
                                   "',PartidaNacTitular2='" & pDocTitular &
                                   "',Plazo=" & Val(Me.c1nPlazo.Value) &
                                   ",TasaInteres=" & Val(Me.c1nTasa.Value) &
                                   ",CodEjecutivo='" & Trim(Me.txtCodEjecMercadeo.Text) &
                                   "',Observacion='" & Trim(Me.txtObs.Text) &
                                   "',TipoDocTit2='" & Me.cbDoc.SelectedIndex &
                                   "',IdCertificadoDPF='" & Me.txtNoCertificado.Text.Trim &
                                   "',Prorrogado='N',SaldoInteresPendiente=0,CodParentesco='" & vParentesco &
                                   "',TelTit2='" & Me.txtTel.Text.Trim &
                                   "',CelTit2='" & Me.txtCelT2.Text.Trim &
                                   "',CodEjecApertura='" & Me.txtCodEjecApertura.Text.Trim &
                                   "',MontoCaja=" & Val(c1nCaja.Value) &
                                   ",MontoTransferencia=" & Val(c1nTransferencia.Value) &
                                   ",MontoRenovacion=" & Val(c1nRenovacion.Value) &
                                   ",MontoRemesa=" & Val(c1nRemesa.Value) &
                                   ",Anulado='" & vAnul &
                                   "',FechaAnula='" & Format(Me.dtpFecAnula.Value, "dd/MM/yyyy") &
                                   "',Comentario='" & Me.txtComentario.Text.Trim &
                                   "', idAutorizacion = " & Me.cbAutorizacion.SelectedValue &
                                   ", FechaNacTit2 = '" & dtpFecNacT2.Value.ToShortDateString & "'"
                Else
                    pCampos = "Titular2='" & Trim(Me.txtTitular2.Text) &
                                    "',PartidaNacTitular2='" & pDocTitular &
                                    "',Plazo=" & Val(Me.c1nPlazo.Value) &
                                    ",TasaInteres=" & Val(Me.c1nTasa.Value) &
                                    ",CodEjecutivo='" & Trim(Me.txtCodEjecMercadeo.Text) &
                                    "',Observacion='" & Trim(Me.txtObs.Text) &
                                    "',TipoDocTit2='" & Me.cbDoc.SelectedIndex &
                                    "',IdCertificadoDPF='" & Me.txtNoCertificado.Text.Trim &
                                    "',Prorrogado='N',SaldoInteresPendiente=0,CodParentesco='" & vParentesco &
                                    "',TelTit2='" & Me.txtTel.Text.Trim &
                                    "',CelTit2='" & Me.txtCelT2.Text.Trim &
                                    "',CodEjecApertura='" & Me.txtCodEjecApertura.Text.Trim &
                                    "',MontoCaja=" & Val(c1nCaja.Value) &
                                    ",MontoTransferencia=" & Val(c1nTransferencia.Value) &
                                    ",MontoRenovacion=" & Val(c1nRenovacion.Value) &
                                    ",MontoRemesa=" & Val(c1nRemesa.Value) &
                                    ",Anulado='" & vAnul &
                                    "',FechaAnula='" & Format(Me.dtpFecAnula.Value, "dd/MM/yyyy") &
                                    "',Comentario='" & Me.txtComentario.Text.Trim &
                                     ", FechaNacTit2 = '" & dtpFecNacT2.Value.ToShortDateString & "'"

                End If

                If oAh.ModificarCuentaAhorro(pNoCuenta, pCodTipoAhorro, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos de la Cuenta de Ahorros no han sido modificados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            ElseIf Me.btnSaveTb1.Text = "&Cancelar Cta." Then
                Dim val As String
                val = oAh.CancelarCuentaAhorro(pNoCuenta, pCodTipoAhorro, Me.txtMotivoCancela.Text.Trim, Me.txtCodEjecCanc.Text.Trim, 0, 0, Me.dtpFecCanc.Value, sUsuario, sPassword, sSucursal)
                If val = "" Then
                    Me.Dispose()
                Else
                    MessageBox.Show(val, "Cancelación DPF", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub MetroButton2_Click_2(sender As Object, e As EventArgs) Handles btTasaPactada.Click
        Dim ofrmAut As New frmMsAutorizacion
        ofrmAut.TipoPermiso = "P"
        ofrmAut.NumPrograma = "AHC002"
        ofrmAut.ShowDialog()
        If ofrmAut.Autoriza = True Then
            '=========================================================================================
            '25/10/2013 Javier Martines
            'Se incluye cb para detalle de persona que autoriza cambio de tasa
            ModificacionTasa = True
            MsgBox("Seleccionar la persona que autoriza la modificación de la tasa de interes.",
                   MsgBoxStyle.Information, "Módulo - Ahorros")
            Me.cbAutorizacion.Enabled = True
            '=========================================================================================
            Me.c1nTasa.ReadOnly = False
            Me.c1nTasa.Focus()
            ofrmAut.Autoriza = False
            ofrmAut.Dispose()
        Else
            ofrmAut.Dispose()
        End If
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton2_Click_3(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles btnSaveTb4.Click

        Try
            Dim oCred As New wrAhorro.wsLibAhorro, pCampos As String, pValores As String, vNumCuentaBanco As String, pFecCapitaliza As Date
            Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection

            'If Me.cbEnt.SelectedIndex = 3 Then
            '    vNumCuentaBanco = Me.txtNoCuentaBanco.Text.Trim
            'Else
            '    vNumCuentaBanco = Me.txtNoCuentaEntInt.Text.Trim
            'End If
            Select Case oCred.AutorizaDatos(Trim(Me.txtNoCertificado.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El No. de Certificado Depósito Plazo Fijo no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
            End Select

            If Me.cbAsentInt.SelectedIndex = 0 Then 'Intereses se asentan Mensualmente
                pFecCapitaliza = Me.dtpFechaApertura.Value.AddDays(29)
            Else 'Intereses se asentan al vencimiento del DPF (no se utiliza FechaCapitaliza)
                pFecCapitaliza = Format(Me.dtpFecVenc.Value, "Short Date")
            End If


            If Me.btnSaveTb4.Text = "&Guardar" Then
                pCampos = "IdCertificadoDPF,CodTipoAhorro," &
                "NoCuenta,Fecha," &
                "FechaCancelacion,Monto," &
                "Plazo,TasaInteres, " &
                "FormaEntregaInt,FormaAsentaInt," &
                "Estado,NumCuentaBancoEntregaInt"

                pValores = "'" & Trim(Me.txtNoCertificado.Text) &
                    "','" & Trim(Me.txtCodTipoAhorro.Text) &
                    "','" & Trim(Me.txtNoCuenta.Text) &
                    "','" & Format(Me.dtpFechaApertura.Value, "dd/MM/yyyy") &
                    "','" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") &
                    "'," & Val(Me.c1nMontoApertura.Value) &
                    "," & Val(Me.c1nPlazo.Value) &
                    "," & Val(Me.c1nTasa.Value) &
                    ",'" & 0 & "','" & Me.cbAsentInt.SelectedIndex &
                    "','N','" & cbNocuenta.SelectedValue & "'"

                If oCred.InsertarCertificadosDPF(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    btnSaveTb4.Text = "&Modificar"
                    oCred.ModificarAhCuentasAhorro("FechaCapitaliza='" & pFecCapitaliza.ToShortDateString &
                                                   "'", "NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", sUsuario, sPassword, sSucursal)
                Else
                    MsgBox("Los datos del Certificado NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            ElseIf Me.btnSaveTb4.Text = "&Modificar" Then
                pCampos = "FormaEntregaInt='" & 0 & "',FormaAsentaInt='" & Me.cbAsentInt.SelectedIndex &
                    "',NumCuentaBancoEntregaInt='" & cbNocuenta.SelectedValue & "'"

                If oCred.ModificarCertificadosDPF(Trim(Me.txtNoCertificado.Text), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    'oCred.ModificarAhCuentasAhorro("TasaVigente='" & IIf(Me.chkProm.Checked = True, "1", "0") & "'", "NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", sUsuario, sPassword, sSucursal)
                    'oCred.ModificarAhCuentasAhorro( "FechaCapitaliza='" & pFecCapitaliza.ToShortDateString & "'", "NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", sUsuario, sPassword, sSucursal)
                    Me.Dispose()
                Else
                    MsgBox("Los datos del Certificado DPF no han sido modificados. Verifique e intente de nuevo  .", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton4_Click_1(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton10_Click(sender As Object, e As EventArgs) Handles MetroButton10.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton9_Click(sender As Object, e As EventArgs) Handles btnSaveTb3.Click
        Me.btnSaveTb1_Click(sender, e)
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        Try
            Dim frmRpt As New frmVisorRS
            OpcionRS = 65
            frmRpt.dui = Me.txtDui.Text.Trim
            frmRpt.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton11_Click(sender As Object, e As EventArgs) Handles btnContrato.Click
        Try
            If txtNoCuenta.ToString.Trim = "" Then
                MsgBox("No hay una cuenta seleccionada, Favor Verifique.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
            ds = oAh.RptContratoDepositoPlazo(txtNoCuenta.Text)
            Dim ofrm As New frmVisor(ds, 221, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
        'Try
        '    Dim frmRpt As New frmVisorRs_Contratos
        '    Dim dts As New DataSet
        '    dts = ahorros.consultarAhContratos_Ahorro(txtCodTipoAhorro.Text.Trim)
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
        '    MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub frmMsAhCuentasDPF_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'If vCancela = True Then
        '    e.Cancel = True
        '    Me.Close()
        'Else
        '    e.Cancel = False
        '    Me.Close()
        'End If
    End Sub

    Private Sub MetroButton9_Click_1(sender As Object, e As EventArgs) Handles MetroButton9.Click
        Dim frm As New frmIngresoAsoc2
        With frm
            .txtDui.Text = Me.txtDui.Value
            .accion = 2
            .Show()
        End With
    End Sub

    Private Sub MetroButton11_Click_1(sender As Object, e As EventArgs) Handles MetroButton11.Click
        Try
            Dim frmRpt As New frmVisorRS
            OpcionRS = 110
            frmRpt.codPrstamo = Me.txtNoCuenta.Text.Trim
            frmRpt.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btEdit_Click_1(sender As Object, e As EventArgs) Handles btEdit.Click
        Dim ofrmAut As New frmMsAutorizacion
        ofrmAut.TipoPermiso = "P"
        ofrmAut.NumPrograma = "AHI002"
        ofrmAut.ShowDialog()
        If ofrmAut.Autoriza = True Then
            Me.txtNoCertificado.ReadOnly = False
            Me.txtNoCertificado.Focus()
            ofrmAut.Autoriza = False
            ofrmAut.Dispose()
        Else
            ofrmAut.Dispose()
        End If
    End Sub




    Private Sub txtCodEjecApertura_DoubleClick(sender As Object, e As EventArgs) Handles txtCodEjecApertura.DoubleClick
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

    Private Sub txtCodEjecMercadeo_DoubleClick(sender As Object, e As EventArgs) Handles txtCodEjecMercadeo.DoubleClick
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
End Class