Public Class frmMsCrFiadores
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents tbSolic As System.Windows.Forms.TabControl
    Friend WithEvents tbDatosGral As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFiadorDesc As System.Windows.Forms.CheckBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txtMotivoDesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPropCasa As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents chkCasaPropia As System.Windows.Forms.CheckBox
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dtpFecNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNit As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDuidG As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtApe2dG As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtNombresdG As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtApe3dG As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtApe1dG As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents dtpFecExtDui As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtIsss As System.Windows.Forms.TextBox
    Friend WithEvents tbDatosTrab As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecCargoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecCargoDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCausaRetiro As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents txtTrabAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtSalAnt As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents dtpFecPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtSalario As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtLugTrabdG As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecIniTrab As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtDirTrabdG As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtCodProfdG As System.Windows.Forms.TextBox
    Friend WithEvents txtProfdG As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtExtOficdG As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTelOficdG As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents tbDatGralIII As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtLugTrabCy As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecIniTrabCy As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDirFam As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtTelTrabCy As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtApe2Cy As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtApe3Cy As System.Windows.Forms.TextBox
    Friend WithEvents txtApe1Cy As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents nuDGrupoFam As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtConyugue As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtSalarioC As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents tbRefFamPer As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents fgRefFam As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents fgRefPer As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tbRefComBan As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents fgRefBan As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents fgRefCom As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents fgGastos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents fgIngresos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents fgVehiculos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents fgBienes As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents fgOblig As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tbIngGastos As System.Windows.Forms.TabPage
    Friend WithEvents tbBienVeh As System.Windows.Forms.TabPage
    Friend WithEvents tbObligGar As System.Windows.Forms.TabPage
    Friend WithEvents txtDptoTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents btnSigTb1_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb1_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTb2_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb2_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTb2_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTb3_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb3_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTb3_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditRF1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelRF1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewRF1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditRP1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelRP1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewRP1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditRB1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelRB1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewRB1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditRC1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelRC1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewRC1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditGt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelGt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewGt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditIng1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelIng1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewIng1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditVh1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelVh1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewVh1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditBI1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelBI1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewBI1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditOb1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelOb1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewOb1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTab7_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTab7_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton8 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label112 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCrFiadores))
        Me.tbSolic = New System.Windows.Forms.TabControl()
        Me.tbDatosGral = New System.Windows.Forms.TabPage()
        Me.btnSigTb1_1 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb1_1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkFiadorDesc = New System.Windows.Forms.CheckBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txtMotivoDesc = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtPropCasa = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.chkCasaPropia = New System.Windows.Forms.CheckBox()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtNit = New C1.Win.C1Input.C1TextBox()
        Me.txtDuidG = New C1.Win.C1Input.C1TextBox()
        Me.txtApe2dG = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtNombresdG = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtApe3dG = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtApe1dG = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.dtpFecExtDui = New System.Windows.Forms.DateTimePicker()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtIsss = New System.Windows.Forms.TextBox()
        Me.tbDatosTrab = New System.Windows.Forms.TabPage()
        Me.btnSigTb2_1 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb2_1 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTb2_1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDptoTrabajo = New System.Windows.Forms.TextBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.dtpFecCargoHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecCargoDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtCausaRetiro = New System.Windows.Forms.TextBox()
        Me.txtCargoAnt = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.txtTrabAnt = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtSalAnt = New C1.Win.C1Input.C1TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.dtpFecPago = New System.Windows.Forms.DateTimePicker()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtSalario = New C1.Win.C1Input.C1TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtLugTrabdG = New System.Windows.Forms.TextBox()
        Me.dtpFecIniTrab = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtDirTrabdG = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtCodProfdG = New System.Windows.Forms.TextBox()
        Me.txtProfdG = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtExtOficdG = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTelOficdG = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.tbDatGralIII = New System.Windows.Forms.TabPage()
        Me.btnSigTb3_1 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb3_1 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTb3_1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtLugTrabCy = New System.Windows.Forms.TextBox()
        Me.dtpFecIniTrabCy = New System.Windows.Forms.DateTimePicker()
        Me.txtDirFam = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtTelTrabCy = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtApe2Cy = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtApe3Cy = New System.Windows.Forms.TextBox()
        Me.txtApe1Cy = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.nuDGrupoFam = New System.Windows.Forms.NumericUpDown()
        Me.txtConyugue = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtSalarioC = New C1.Win.C1Input.C1TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.tbRefFamPer = New System.Windows.Forms.TabPage()
        Me.btnSigTab7_1 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTab7_1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btEditRF1 = New MetroFramework.Controls.MetroButton()
        Me.btDelRF1 = New MetroFramework.Controls.MetroButton()
        Me.btNewRF1 = New MetroFramework.Controls.MetroButton()
        Me.fgRefFam = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btEditRP1 = New MetroFramework.Controls.MetroButton()
        Me.btDelRP1 = New MetroFramework.Controls.MetroButton()
        Me.btNewRP1 = New MetroFramework.Controls.MetroButton()
        Me.fgRefPer = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbRefComBan = New System.Windows.Forms.TabPage()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btEditRB1 = New MetroFramework.Controls.MetroButton()
        Me.btDelRB1 = New MetroFramework.Controls.MetroButton()
        Me.btNewRB1 = New MetroFramework.Controls.MetroButton()
        Me.fgRefBan = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btEditRC1 = New MetroFramework.Controls.MetroButton()
        Me.btDelRC1 = New MetroFramework.Controls.MetroButton()
        Me.btNewRC1 = New MetroFramework.Controls.MetroButton()
        Me.fgRefCom = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbIngGastos = New System.Windows.Forms.TabPage()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.btEditGt1 = New MetroFramework.Controls.MetroButton()
        Me.btDelGt1 = New MetroFramework.Controls.MetroButton()
        Me.btNewGt1 = New MetroFramework.Controls.MetroButton()
        Me.fgGastos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.btEditIng1 = New MetroFramework.Controls.MetroButton()
        Me.btDelIng1 = New MetroFramework.Controls.MetroButton()
        Me.btNewIng1 = New MetroFramework.Controls.MetroButton()
        Me.fgIngresos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbBienVeh = New System.Windows.Forms.TabPage()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.btEditVh1 = New MetroFramework.Controls.MetroButton()
        Me.btDelVh1 = New MetroFramework.Controls.MetroButton()
        Me.btNewVh1 = New MetroFramework.Controls.MetroButton()
        Me.fgVehiculos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.btEditBI1 = New MetroFramework.Controls.MetroButton()
        Me.btDelBI1 = New MetroFramework.Controls.MetroButton()
        Me.btNewBI1 = New MetroFramework.Controls.MetroButton()
        Me.fgBienes = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbObligGar = New System.Windows.Forms.TabPage()
        Me.MetroButton8 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.btEditOb1 = New MetroFramework.Controls.MetroButton()
        Me.btDelOb1 = New MetroFramework.Controls.MetroButton()
        Me.btNewOb1 = New MetroFramework.Controls.MetroButton()
        Me.fgOblig = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbSolic.SuspendLayout()
        Me.tbDatosGral.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuidG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDatosTrab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtSalAnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDatGralIII.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nuDGrupoFam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalarioC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRefFamPer.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.fgRefFam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.fgRefPer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRefComBan.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.fgRefBan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.fgRefCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbIngGastos.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.fgGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        CType(Me.fgIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBienVeh.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.fgVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        CType(Me.fgBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbObligGar.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.fgOblig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSolic
        '
        Me.tbSolic.Controls.Add(Me.tbDatosGral)
        Me.tbSolic.Controls.Add(Me.tbDatosTrab)
        Me.tbSolic.Controls.Add(Me.tbDatGralIII)
        Me.tbSolic.Controls.Add(Me.tbRefFamPer)
        Me.tbSolic.Controls.Add(Me.tbRefComBan)
        Me.tbSolic.Controls.Add(Me.tbIngGastos)
        Me.tbSolic.Controls.Add(Me.tbBienVeh)
        Me.tbSolic.Controls.Add(Me.tbObligGar)
        Me.tbSolic.ItemSize = New System.Drawing.Size(300, 18)
        Me.tbSolic.Location = New System.Drawing.Point(28, 73)
        Me.tbSolic.Multiline = True
        Me.tbSolic.Name = "tbSolic"
        Me.tbSolic.SelectedIndex = 0
        Me.tbSolic.Size = New System.Drawing.Size(854, 544)
        Me.tbSolic.TabIndex = 51
        '
        'tbDatosGral
        '
        Me.tbDatosGral.BackColor = System.Drawing.Color.White
        Me.tbDatosGral.Controls.Add(Me.btnSigTb1_1)
        Me.tbDatosGral.Controls.Add(Me.btnSaveTb1_1)
        Me.tbDatosGral.Controls.Add(Me.GroupBox6)
        Me.tbDatosGral.Controls.Add(Me.GroupBox4)
        Me.tbDatosGral.Location = New System.Drawing.Point(4, 40)
        Me.tbDatosGral.Name = "tbDatosGral"
        Me.tbDatosGral.Size = New System.Drawing.Size(846, 500)
        Me.tbDatosGral.TabIndex = 2
        Me.tbDatosGral.Text = "Datos Generales I"
        Me.tbDatosGral.Visible = False
        '
        'btnSigTb1_1
        '
        Me.btnSigTb1_1.Location = New System.Drawing.Point(638, 452)
        Me.btnSigTb1_1.Name = "btnSigTb1_1"
        Me.btnSigTb1_1.Size = New System.Drawing.Size(90, 33)
        Me.btnSigTb1_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTb1_1.TabIndex = 227
        Me.btnSigTb1_1.Text = "Siguiente"
        Me.btnSigTb1_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTb1_1.UseSelectable = True
        Me.btnSigTb1_1.UseStyleColors = True
        '
        'btnSaveTb1_1
        '
        Me.btnSaveTb1_1.Location = New System.Drawing.Point(736, 452)
        Me.btnSaveTb1_1.Name = "btnSaveTb1_1"
        Me.btnSaveTb1_1.Size = New System.Drawing.Size(90, 33)
        Me.btnSaveTb1_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb1_1.TabIndex = 226
        Me.btnSaveTb1_1.Text = "&Guardar"
        Me.btnSaveTb1_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb1_1.UseSelectable = True
        Me.btnSaveTb1_1.UseStyleColors = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.chkFiadorDesc)
        Me.GroupBox6.Controls.Add(Me.Label62)
        Me.GroupBox6.Controls.Add(Me.txtMotivoDesc)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox6.Location = New System.Drawing.Point(19, 294)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(807, 151)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos de Solicitud"
        '
        'chkFiadorDesc
        '
        Me.chkFiadorDesc.BackColor = System.Drawing.Color.White
        Me.chkFiadorDesc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFiadorDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiadorDesc.ForeColor = System.Drawing.Color.Black
        Me.chkFiadorDesc.Location = New System.Drawing.Point(13, 27)
        Me.chkFiadorDesc.Name = "chkFiadorDesc"
        Me.chkFiadorDesc.Size = New System.Drawing.Size(173, 18)
        Me.chkFiadorDesc.TabIndex = 1
        Me.chkFiadorDesc.Text = "&Fiador descartado"
        Me.chkFiadorDesc.UseVisualStyleBackColor = False
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.Location = New System.Drawing.Point(10, 48)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(124, 19)
        Me.Label62.TabIndex = 91
        Me.Label62.Text = "Motivo descartado:"
        '
        'txtMotivoDesc
        '
        Me.txtMotivoDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMotivoDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoDesc.Location = New System.Drawing.Point(7, 70)
        Me.txtMotivoDesc.MaxLength = 255
        Me.txtMotivoDesc.Multiline = True
        Me.txtMotivoDesc.Name = "txtMotivoDesc"
        Me.txtMotivoDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoDesc.Size = New System.Drawing.Size(781, 58)
        Me.txtMotivoDesc.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txtPropCasa)
        Me.GroupBox4.Controls.Add(Me.Label54)
        Me.GroupBox4.Controls.Add(Me.chkCasaPropia)
        Me.GroupBox4.Controls.Add(Me.txtCel)
        Me.GroupBox4.Controls.Add(Me.txtTelCasa)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txtDireccion)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.dtpFecNac)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.txtNit)
        Me.GroupBox4.Controls.Add(Me.txtDuidG)
        Me.GroupBox4.Controls.Add(Me.txtApe2dG)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.txtNombresdG)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.txtApe3dG)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.txtApe1dG)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.dtpFecExtDui)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.txtNoSocio)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.Label43)
        Me.GroupBox4.Controls.Add(Me.Label45)
        Me.GroupBox4.Controls.Add(Me.Label47)
        Me.GroupBox4.Controls.Add(Me.txtIsss)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(19, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(807, 278)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Personales"
        '
        'txtPropCasa
        '
        Me.txtPropCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPropCasa.Location = New System.Drawing.Point(516, 243)
        Me.txtPropCasa.MaxLength = 255
        Me.txtPropCasa.Name = "txtPropCasa"
        Me.txtPropCasa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPropCasa.Size = New System.Drawing.Size(278, 23)
        Me.txtPropCasa.TabIndex = 13
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(398, 243)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(116, 19)
        Me.Label54.TabIndex = 120
        Me.Label54.Text = "Propietario Casa:"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkCasaPropia
        '
        Me.chkCasaPropia.BackColor = System.Drawing.Color.White
        Me.chkCasaPropia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCasaPropia.ForeColor = System.Drawing.Color.Black
        Me.chkCasaPropia.Location = New System.Drawing.Point(13, 243)
        Me.chkCasaPropia.Name = "chkCasaPropia"
        Me.chkCasaPropia.Size = New System.Drawing.Size(106, 19)
        Me.chkCasaPropia.TabIndex = 12
        Me.chkCasaPropia.Text = "&Casa propia"
        Me.chkCasaPropia.UseVisualStyleBackColor = False
        '
        'txtCel
        '
        Me.txtCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCel.Location = New System.Drawing.Point(516, 213)
        Me.txtCel.MaxLength = 10
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(278, 23)
        Me.txtCel.TabIndex = 11
        '
        'txtTelCasa
        '
        Me.txtTelCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelCasa.Location = New System.Drawing.Point(113, 213)
        Me.txtTelCasa.MaxLength = 40
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(192, 23)
        Me.txtTelCasa.TabIndex = 10
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(451, 213)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 19)
        Me.Label18.TabIndex = 118
        Me.Label18.Text = "Celular:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(10, 213)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(105, 19)
        Me.Label24.TabIndex = 117
        Me.Label24.Text = "Teléfono Casa:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(113, 162)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(681, 45)
        Me.txtDireccion.TabIndex = 9
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(10, 162)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 18)
        Me.Label26.TabIndex = 114
        Me.Label26.Text = "Dirección:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNac.Location = New System.Drawing.Point(641, 55)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(153, 23)
        Me.dtpFecNac.TabIndex = 4
        Me.dtpFecNac.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(538, 57)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 21)
        Me.Label27.TabIndex = 112
        Me.Label27.Text = "Nacimiento:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNit
        '
        Me.txtNit.EditMask = "0000-000000-000-0"
        Me.txtNit.Location = New System.Drawing.Point(641, 22)
        Me.txtNit.MaxLength = 20
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NumericInput = False
        Me.txtNit.Size = New System.Drawing.Size(153, 21)
        Me.txtNit.TabIndex = 1
        Me.txtNit.Tag = Nothing
        '
        'txtDuidG
        '
        Me.txtDuidG.EditMask = "00000000-0"
        Me.txtDuidG.Location = New System.Drawing.Point(113, 22)
        Me.txtDuidG.MaxLength = 20
        Me.txtDuidG.Name = "txtDuidG"
        Me.txtDuidG.NumericInput = False
        Me.txtDuidG.Size = New System.Drawing.Size(153, 21)
        Me.txtDuidG.TabIndex = 0
        Me.txtDuidG.Tag = Nothing
        '
        'txtApe2dG
        '
        Me.txtApe2dG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe2dG.Location = New System.Drawing.Point(113, 132)
        Me.txtApe2dG.MaxLength = 25
        Me.txtApe2dG.Name = "txtApe2dG"
        Me.txtApe2dG.Size = New System.Drawing.Size(278, 23)
        Me.txtApe2dG.TabIndex = 7
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(10, 134)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 18)
        Me.Label34.TabIndex = 110
        Me.Label34.Text = "Apellido 2:"
        '
        'txtNombresdG
        '
        Me.txtNombresdG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombresdG.Location = New System.Drawing.Point(113, 102)
        Me.txtNombresdG.MaxLength = 50
        Me.txtNombresdG.Name = "txtNombresdG"
        Me.txtNombresdG.Size = New System.Drawing.Size(278, 23)
        Me.txtNombresdG.TabIndex = 5
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(10, 102)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(97, 23)
        Me.Label35.TabIndex = 109
        Me.Label35.Text = "* Nombres:"
        '
        'txtApe3dG
        '
        Me.txtApe3dG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe3dG.Location = New System.Drawing.Point(516, 132)
        Me.txtApe3dG.MaxLength = 30
        Me.txtApe3dG.Name = "txtApe3dG"
        Me.txtApe3dG.Size = New System.Drawing.Size(278, 23)
        Me.txtApe3dG.TabIndex = 8
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(398, 136)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(111, 19)
        Me.Label37.TabIndex = 103
        Me.Label37.Text = "Apellido Casada:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe1dG
        '
        Me.txtApe1dG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe1dG.Location = New System.Drawing.Point(516, 102)
        Me.txtApe1dG.MaxLength = 25
        Me.txtApe1dG.Name = "txtApe1dG"
        Me.txtApe1dG.Size = New System.Drawing.Size(278, 23)
        Me.txtApe1dG.TabIndex = 6
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(398, 99)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(96, 19)
        Me.Label38.TabIndex = 101
        Me.Label38.Text = "* Apellido 1:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecExtDui
        '
        Me.dtpFecExtDui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecExtDui.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecExtDui.Location = New System.Drawing.Point(113, 52)
        Me.dtpFecExtDui.Name = "dtpFecExtDui"
        Me.dtpFecExtDui.Size = New System.Drawing.Size(153, 23)
        Me.dtpFecExtDui.TabIndex = 2
        Me.dtpFecExtDui.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(10, 52)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(96, 18)
        Me.Label41.TabIndex = 89
        Me.Label41.Text = "Extensión DUI:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Location = New System.Drawing.Point(377, 22)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(153, 23)
        Me.txtNoSocio.TabIndex = 1
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(538, 22)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(96, 23)
        Me.Label42.TabIndex = 83
        Me.Label42.Text = "Nit:"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(274, 22)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(96, 18)
        Me.Label43.TabIndex = 81
        Me.Label43.Text = "No. Asociado:"
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(274, 59)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(48, 18)
        Me.Label45.TabIndex = 84
        Me.Label45.Text = "ISSS:"
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(10, 28)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(96, 18)
        Me.Label47.TabIndex = 79
        Me.Label47.Text = "* Dui:"
        '
        'txtIsss
        '
        Me.txtIsss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIsss.Location = New System.Drawing.Point(377, 55)
        Me.txtIsss.MaxLength = 20
        Me.txtIsss.Name = "txtIsss"
        Me.txtIsss.Size = New System.Drawing.Size(153, 23)
        Me.txtIsss.TabIndex = 3
        '
        'tbDatosTrab
        '
        Me.tbDatosTrab.BackColor = System.Drawing.Color.White
        Me.tbDatosTrab.Controls.Add(Me.btnSigTb2_1)
        Me.tbDatosTrab.Controls.Add(Me.btnSaveTb2_1)
        Me.tbDatosTrab.Controls.Add(Me.btnAtrasTb2_1)
        Me.tbDatosTrab.Controls.Add(Me.GroupBox2)
        Me.tbDatosTrab.Location = New System.Drawing.Point(4, 40)
        Me.tbDatosTrab.Name = "tbDatosTrab"
        Me.tbDatosTrab.Size = New System.Drawing.Size(846, 500)
        Me.tbDatosTrab.TabIndex = 3
        Me.tbDatosTrab.Text = "Datos Generales II"
        Me.tbDatosTrab.Visible = False
        '
        'btnSigTb2_1
        '
        Me.btnSigTb2_1.Location = New System.Drawing.Point(631, 448)
        Me.btnSigTb2_1.Name = "btnSigTb2_1"
        Me.btnSigTb2_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTb2_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTb2_1.TabIndex = 228
        Me.btnSigTb2_1.Text = "Siguiente"
        Me.btnSigTb2_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTb2_1.UseSelectable = True
        Me.btnSigTb2_1.UseStyleColors = True
        '
        'btnSaveTb2_1
        '
        Me.btnSaveTb2_1.Location = New System.Drawing.Point(728, 448)
        Me.btnSaveTb2_1.Name = "btnSaveTb2_1"
        Me.btnSaveTb2_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb2_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb2_1.TabIndex = 227
        Me.btnSaveTb2_1.Text = "Guardar"
        Me.btnSaveTb2_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb2_1.UseSelectable = True
        Me.btnSaveTb2_1.UseStyleColors = True
        '
        'btnAtrasTb2_1
        '
        Me.btnAtrasTb2_1.Location = New System.Drawing.Point(534, 448)
        Me.btnAtrasTb2_1.Name = "btnAtrasTb2_1"
        Me.btnAtrasTb2_1.Size = New System.Drawing.Size(90, 32)
        Me.btnAtrasTb2_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTb2_1.TabIndex = 226
        Me.btnAtrasTb2_1.Text = "Atras"
        Me.btnAtrasTb2_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTb2_1.UseSelectable = True
        Me.btnAtrasTb2_1.UseStyleColors = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtDptoTrabajo)
        Me.GroupBox2.Controls.Add(Me.Label112)
        Me.GroupBox2.Controls.Add(Me.dtpFecCargoHasta)
        Me.GroupBox2.Controls.Add(Me.dtpFecCargoDesde)
        Me.GroupBox2.Controls.Add(Me.txtCausaRetiro)
        Me.GroupBox2.Controls.Add(Me.txtCargoAnt)
        Me.GroupBox2.Controls.Add(Me.Label59)
        Me.GroupBox2.Controls.Add(Me.txtFormaPago)
        Me.GroupBox2.Controls.Add(Me.txtTrabAnt)
        Me.GroupBox2.Controls.Add(Me.Label57)
        Me.GroupBox2.Controls.Add(Me.txtSalAnt)
        Me.GroupBox2.Controls.Add(Me.Label56)
        Me.GroupBox2.Controls.Add(Me.dtpFecPago)
        Me.GroupBox2.Controls.Add(Me.Label55)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.txtCargo)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txtSalario)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.txtLugTrabdG)
        Me.GroupBox2.Controls.Add(Me.dtpFecIniTrab)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.txtDirTrabdG)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.txtCodProfdG)
        Me.GroupBox2.Controls.Add(Me.txtProfdG)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtExtOficdG)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtTelOficdG)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label63)
        Me.GroupBox2.Controls.Add(Me.Label64)
        Me.GroupBox2.Controls.Add(Me.Label66)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(19, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(807, 432)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Trabajo"
        '
        'txtDptoTrabajo
        '
        Me.txtDptoTrabajo.BackColor = System.Drawing.Color.White
        Me.txtDptoTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDptoTrabajo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDptoTrabajo.Location = New System.Drawing.Point(130, 92)
        Me.txtDptoTrabajo.MaxLength = 50
        Me.txtDptoTrabajo.Name = "txtDptoTrabajo"
        Me.txtDptoTrabajo.Size = New System.Drawing.Size(276, 23)
        Me.txtDptoTrabajo.TabIndex = 3
        '
        'Label112
        '
        Me.Label112.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.ForeColor = System.Drawing.Color.Black
        Me.Label112.Location = New System.Drawing.Point(7, 95)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(115, 50)
        Me.Label112.TabIndex = 204
        Me.Label112.Text = "Área, Sección / Departamento de trabajo:"
        '
        'dtpFecCargoHasta
        '
        Me.dtpFecCargoHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCargoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCargoHasta.Location = New System.Drawing.Point(130, 325)
        Me.dtpFecCargoHasta.Name = "dtpFecCargoHasta"
        Me.dtpFecCargoHasta.Size = New System.Drawing.Size(276, 23)
        Me.dtpFecCargoHasta.TabIndex = 16
        Me.dtpFecCargoHasta.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'dtpFecCargoDesde
        '
        Me.dtpFecCargoDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCargoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCargoDesde.Location = New System.Drawing.Point(523, 295)
        Me.dtpFecCargoDesde.Name = "dtpFecCargoDesde"
        Me.dtpFecCargoDesde.Size = New System.Drawing.Size(276, 23)
        Me.dtpFecCargoDesde.TabIndex = 14
        Me.dtpFecCargoDesde.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'txtCausaRetiro
        '
        Me.txtCausaRetiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCausaRetiro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCausaRetiro.Location = New System.Drawing.Point(523, 325)
        Me.txtCausaRetiro.MaxLength = 50
        Me.txtCausaRetiro.Name = "txtCausaRetiro"
        Me.txtCausaRetiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCausaRetiro.Size = New System.Drawing.Size(276, 23)
        Me.txtCausaRetiro.TabIndex = 15
        '
        'txtCargoAnt
        '
        Me.txtCargoAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargoAnt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargoAnt.Location = New System.Drawing.Point(130, 295)
        Me.txtCargoAnt.MaxLength = 50
        Me.txtCargoAnt.Name = "txtCargoAnt"
        Me.txtCargoAnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCargoAnt.Size = New System.Drawing.Size(276, 23)
        Me.txtCargoAnt.TabIndex = 13
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(7, 295)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(115, 21)
        Me.Label59.TabIndex = 105
        Me.Label59.Text = "Cargo Anterior:"
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFormaPago.Location = New System.Drawing.Point(130, 265)
        Me.txtFormaPago.MaxLength = 9
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.Size = New System.Drawing.Size(276, 23)
        Me.txtFormaPago.TabIndex = 10
        '
        'txtTrabAnt
        '
        Me.txtTrabAnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTrabAnt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrabAnt.Location = New System.Drawing.Point(130, 235)
        Me.txtTrabAnt.MaxLength = 255
        Me.txtTrabAnt.Name = "txtTrabAnt"
        Me.txtTrabAnt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTrabAnt.Size = New System.Drawing.Size(669, 23)
        Me.txtTrabAnt.TabIndex = 11
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(7, 235)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(115, 19)
        Me.Label57.TabIndex = 102
        Me.Label57.Text = "Trabajo anterior:"
        '
        'txtSalAnt
        '
        Me.txtSalAnt.DataType = GetType(Decimal)
        Me.txtSalAnt.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtSalAnt.Location = New System.Drawing.Point(523, 265)
        Me.txtSalAnt.Name = "txtSalAnt"
        Me.txtSalAnt.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtSalAnt.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtSalAnt.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtSalAnt.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtSalAnt.Size = New System.Drawing.Size(276, 21)
        Me.txtSalAnt.TabIndex = 12
        Me.txtSalAnt.Tag = Nothing
        Me.txtSalAnt.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(413, 268)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(105, 14)
        Me.Label56.TabIndex = 100
        Me.Label56.Text = "Salario anterior:"
        '
        'dtpFecPago
        '
        Me.dtpFecPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecPago.Location = New System.Drawing.Point(523, 175)
        Me.dtpFecPago.Name = "dtpFecPago"
        Me.dtpFecPago.Size = New System.Drawing.Size(276, 23)
        Me.dtpFecPago.TabIndex = 8
        Me.dtpFecPago.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(413, 175)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(105, 19)
        Me.Label55.TabIndex = 98
        Me.Label55.Text = "Fecha de Pago:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(413, 328)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(91, 18)
        Me.Label39.TabIndex = 96
        Me.Label39.Text = "Causa Retiro:"
        '
        'txtCargo
        '
        Me.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(130, 175)
        Me.txtCargo.MaxLength = 50
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCargo.Size = New System.Drawing.Size(276, 23)
        Me.txtCargo.TabIndex = 7
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(7, 178)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 18)
        Me.Label30.TabIndex = 92
        Me.Label30.Text = "Cargo:"
        '
        'txtSalario
        '
        Me.txtSalario.DataType = GetType(Decimal)
        Me.txtSalario.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtSalario.Location = New System.Drawing.Point(523, 145)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtSalario.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtSalario.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtSalario.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtSalario.Size = New System.Drawing.Size(276, 21)
        Me.txtSalario.TabIndex = 6
        Me.txtSalario.Tag = Nothing
        Me.txtSalario.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(413, 148)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 18)
        Me.Label29.TabIndex = 90
        Me.Label29.Text = "Salario:"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(7, 48)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(77, 19)
        Me.Label32.TabIndex = 89
        Me.Label32.Text = "Dirección:"
        '
        'txtLugTrabdG
        '
        Me.txtLugTrabdG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugTrabdG.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugTrabdG.Location = New System.Drawing.Point(130, 16)
        Me.txtLugTrabdG.MaxLength = 255
        Me.txtLugTrabdG.Name = "txtLugTrabdG"
        Me.txtLugTrabdG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLugTrabdG.Size = New System.Drawing.Size(276, 23)
        Me.txtLugTrabdG.TabIndex = 0
        '
        'dtpFecIniTrab
        '
        Me.dtpFecIniTrab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIniTrab.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIniTrab.Location = New System.Drawing.Point(523, 16)
        Me.dtpFecIniTrab.Name = "dtpFecIniTrab"
        Me.dtpFecIniTrab.Size = New System.Drawing.Size(276, 23)
        Me.dtpFecIniTrab.TabIndex = 1
        Me.dtpFecIniTrab.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(413, 18)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(115, 19)
        Me.Label33.TabIndex = 88
        Me.Label33.Text = "Fecha de Inicio:"
        '
        'txtDirTrabdG
        '
        Me.txtDirTrabdG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirTrabdG.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirTrabdG.Location = New System.Drawing.Point(130, 46)
        Me.txtDirTrabdG.MaxLength = 255
        Me.txtDirTrabdG.Multiline = True
        Me.txtDirTrabdG.Name = "txtDirTrabdG"
        Me.txtDirTrabdG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDirTrabdG.Size = New System.Drawing.Size(669, 39)
        Me.txtDirTrabdG.TabIndex = 2
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(7, 18)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(115, 19)
        Me.Label44.TabIndex = 87
        Me.Label44.Text = "Lugar de trabajo:"
        '
        'txtCodProfdG
        '
        Me.txtCodProfdG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodProfdG.Location = New System.Drawing.Point(130, 205)
        Me.txtCodProfdG.MaxLength = 10
        Me.txtCodProfdG.Name = "txtCodProfdG"
        Me.txtCodProfdG.Size = New System.Drawing.Size(108, 23)
        Me.txtCodProfdG.TabIndex = 9
        '
        'txtProfdG
        '
        Me.txtProfdG.BackColor = System.Drawing.Color.White
        Me.txtProfdG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProfdG.Location = New System.Drawing.Point(245, 205)
        Me.txtProfdG.MaxLength = 100
        Me.txtProfdG.Name = "txtProfdG"
        Me.txtProfdG.ReadOnly = True
        Me.txtProfdG.Size = New System.Drawing.Size(554, 23)
        Me.txtProfdG.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(7, 205)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 19)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Profesión:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExtOficdG
        '
        Me.txtExtOficdG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExtOficdG.Location = New System.Drawing.Point(130, 145)
        Me.txtExtOficdG.MaxLength = 15
        Me.txtExtOficdG.Name = "txtExtOficdG"
        Me.txtExtOficdG.Size = New System.Drawing.Size(276, 23)
        Me.txtExtOficdG.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(7, 145)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 19)
        Me.Label20.TabIndex = 74
        Me.Label20.Text = "Ext. de Oficina:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelOficdG
        '
        Me.txtTelOficdG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelOficdG.Location = New System.Drawing.Point(523, 95)
        Me.txtTelOficdG.MaxLength = 40
        Me.txtTelOficdG.Name = "txtTelOficdG"
        Me.txtTelOficdG.Size = New System.Drawing.Size(276, 23)
        Me.txtTelOficdG.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(413, 97)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 18)
        Me.Label23.TabIndex = 72
        Me.Label23.Text = "Teléfono Oficina:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(413, 298)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(105, 18)
        Me.Label63.TabIndex = 109
        Me.Label63.Text = "Cargo desde:"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Black
        Me.Label64.Location = New System.Drawing.Point(7, 268)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(106, 18)
        Me.Label64.TabIndex = 103
        Me.Label64.Text = "Forma de Pago:"
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(7, 325)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(106, 19)
        Me.Label66.TabIndex = 111
        Me.Label66.Text = "Cargo hasta:"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbDatGralIII
        '
        Me.tbDatGralIII.BackColor = System.Drawing.Color.White
        Me.tbDatGralIII.Controls.Add(Me.btnSigTb3_1)
        Me.tbDatGralIII.Controls.Add(Me.btnSaveTb3_1)
        Me.tbDatGralIII.Controls.Add(Me.btnAtrasTb3_1)
        Me.tbDatGralIII.Controls.Add(Me.GroupBox5)
        Me.tbDatGralIII.Location = New System.Drawing.Point(4, 40)
        Me.tbDatGralIII.Name = "tbDatGralIII"
        Me.tbDatGralIII.Size = New System.Drawing.Size(846, 500)
        Me.tbDatGralIII.TabIndex = 8
        Me.tbDatGralIII.Text = "Datos Generales III"
        Me.tbDatGralIII.Visible = False
        '
        'btnSigTb3_1
        '
        Me.btnSigTb3_1.Location = New System.Drawing.Point(638, 447)
        Me.btnSigTb3_1.Name = "btnSigTb3_1"
        Me.btnSigTb3_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTb3_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTb3_1.TabIndex = 228
        Me.btnSigTb3_1.Text = "Siguiente"
        Me.btnSigTb3_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTb3_1.UseSelectable = True
        Me.btnSigTb3_1.UseStyleColors = True
        '
        'btnSaveTb3_1
        '
        Me.btnSaveTb3_1.Location = New System.Drawing.Point(736, 447)
        Me.btnSaveTb3_1.Name = "btnSaveTb3_1"
        Me.btnSaveTb3_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb3_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb3_1.TabIndex = 227
        Me.btnSaveTb3_1.Text = "&Guardar"
        Me.btnSaveTb3_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb3_1.UseSelectable = True
        Me.btnSaveTb3_1.UseStyleColors = True
        '
        'btnAtrasTb3_1
        '
        Me.btnAtrasTb3_1.Location = New System.Drawing.Point(541, 447)
        Me.btnAtrasTb3_1.Name = "btnAtrasTb3_1"
        Me.btnAtrasTb3_1.Size = New System.Drawing.Size(90, 32)
        Me.btnAtrasTb3_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTb3_1.TabIndex = 226
        Me.btnAtrasTb3_1.Text = "Atras"
        Me.btnAtrasTb3_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTb3_1.UseSelectable = True
        Me.btnAtrasTb3_1.UseStyleColors = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.Label50)
        Me.GroupBox5.Controls.Add(Me.txtLugTrabCy)
        Me.GroupBox5.Controls.Add(Me.dtpFecIniTrabCy)
        Me.GroupBox5.Controls.Add(Me.txtDirFam)
        Me.GroupBox5.Controls.Add(Me.Label52)
        Me.GroupBox5.Controls.Add(Me.txtTelTrabCy)
        Me.GroupBox5.Controls.Add(Me.Label53)
        Me.GroupBox5.Controls.Add(Me.txtApe2Cy)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.txtApe3Cy)
        Me.GroupBox5.Controls.Add(Me.txtApe1Cy)
        Me.GroupBox5.Controls.Add(Me.Label48)
        Me.GroupBox5.Controls.Add(Me.nuDGrupoFam)
        Me.GroupBox5.Controls.Add(Me.txtConyugue)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.Label58)
        Me.GroupBox5.Controls.Add(Me.Label60)
        Me.GroupBox5.Controls.Add(Me.Label61)
        Me.GroupBox5.Controls.Add(Me.txtSalarioC)
        Me.GroupBox5.Controls.Add(Me.Label65)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox5.Location = New System.Drawing.Point(19, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(807, 368)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Grupo Familiar"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(7, 168)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(125, 39)
        Me.Label50.TabIndex = 126
        Me.Label50.Text = "Dirección de Familiar:"
        '
        'txtLugTrabCy
        '
        Me.txtLugTrabCy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugTrabCy.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugTrabCy.Location = New System.Drawing.Point(139, 76)
        Me.txtLugTrabCy.MaxLength = 255
        Me.txtLugTrabCy.Name = "txtLugTrabCy"
        Me.txtLugTrabCy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLugTrabCy.Size = New System.Drawing.Size(639, 23)
        Me.txtLugTrabCy.TabIndex = 4
        '
        'dtpFecIniTrabCy
        '
        Me.dtpFecIniTrabCy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIniTrabCy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIniTrabCy.Location = New System.Drawing.Point(139, 106)
        Me.dtpFecIniTrabCy.Name = "dtpFecIniTrabCy"
        Me.dtpFecIniTrabCy.Size = New System.Drawing.Size(250, 23)
        Me.dtpFecIniTrabCy.TabIndex = 5
        Me.dtpFecIniTrabCy.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'txtDirFam
        '
        Me.txtDirFam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirFam.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirFam.Location = New System.Drawing.Point(139, 166)
        Me.txtDirFam.MaxLength = 255
        Me.txtDirFam.Multiline = True
        Me.txtDirFam.Name = "txtDirFam"
        Me.txtDirFam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDirFam.Size = New System.Drawing.Size(639, 77)
        Me.txtDirFam.TabIndex = 8
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(7, 78)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(115, 19)
        Me.Label52.TabIndex = 124
        Me.Label52.Text = "Lugar de trabajo:"
        '
        'txtTelTrabCy
        '
        Me.txtTelTrabCy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelTrabCy.Location = New System.Drawing.Point(528, 106)
        Me.txtTelTrabCy.MaxLength = 40
        Me.txtTelTrabCy.Name = "txtTelTrabCy"
        Me.txtTelTrabCy.Size = New System.Drawing.Size(250, 23)
        Me.txtTelTrabCy.TabIndex = 6
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(396, 111)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(115, 18)
        Me.Label53.TabIndex = 120
        Me.Label53.Text = "Teléfono Trabajo:"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe2Cy
        '
        Me.txtApe2Cy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe2Cy.Location = New System.Drawing.Point(139, 46)
        Me.txtApe2Cy.MaxLength = 25
        Me.txtApe2Cy.Name = "txtApe2Cy"
        Me.txtApe2Cy.Size = New System.Drawing.Size(250, 23)
        Me.txtApe2Cy.TabIndex = 2
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(7, 51)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(77, 18)
        Me.Label36.TabIndex = 116
        Me.Label36.Text = "Apellido 2:"
        '
        'txtApe3Cy
        '
        Me.txtApe3Cy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe3Cy.Location = New System.Drawing.Point(528, 46)
        Me.txtApe3Cy.MaxLength = 30
        Me.txtApe3Cy.Name = "txtApe3Cy"
        Me.txtApe3Cy.Size = New System.Drawing.Size(250, 23)
        Me.txtApe3Cy.TabIndex = 3
        '
        'txtApe1Cy
        '
        Me.txtApe1Cy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe1Cy.Location = New System.Drawing.Point(528, 16)
        Me.txtApe1Cy.MaxLength = 25
        Me.txtApe1Cy.Name = "txtApe1Cy"
        Me.txtApe1Cy.Size = New System.Drawing.Size(250, 23)
        Me.txtApe1Cy.TabIndex = 1
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(396, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(125, 19)
        Me.Label48.TabIndex = 114
        Me.Label48.Text = "* Apellido 1:"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nuDGrupoFam
        '
        Me.nuDGrupoFam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nuDGrupoFam.Location = New System.Drawing.Point(528, 136)
        Me.nuDGrupoFam.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nuDGrupoFam.Name = "nuDGrupoFam"
        Me.nuDGrupoFam.Size = New System.Drawing.Size(250, 23)
        Me.nuDGrupoFam.TabIndex = 9
        Me.nuDGrupoFam.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtConyugue
        '
        Me.txtConyugue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConyugue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConyugue.Location = New System.Drawing.Point(139, 16)
        Me.txtConyugue.MaxLength = 100
        Me.txtConyugue.Name = "txtConyugue"
        Me.txtConyugue.Size = New System.Drawing.Size(250, 23)
        Me.txtConyugue.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(7, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(125, 19)
        Me.Label28.TabIndex = 64
        Me.Label28.Text = "Nombre Cónyugue:"
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(396, 46)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(125, 19)
        Me.Label58.TabIndex = 115
        Me.Label58.Text = "Apellido de Casada:"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(7, 111)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(106, 18)
        Me.Label60.TabIndex = 125
        Me.Label60.Text = "Fecha de Inicio:"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(396, 141)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(125, 18)
        Me.Label61.TabIndex = 65
        Me.Label61.Text = "Grupo familiar:"
        '
        'txtSalarioC
        '
        Me.txtSalarioC.DataType = GetType(Decimal)
        Me.txtSalarioC.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtSalarioC.Location = New System.Drawing.Point(139, 136)
        Me.txtSalarioC.Name = "txtSalarioC"
        Me.txtSalarioC.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtSalarioC.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtSalarioC.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtSalarioC.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtSalarioC.Size = New System.Drawing.Size(250, 21)
        Me.txtSalarioC.TabIndex = 7
        Me.txtSalarioC.Tag = Nothing
        Me.txtSalarioC.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.Location = New System.Drawing.Point(7, 136)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(63, 19)
        Me.Label65.TabIndex = 118
        Me.Label65.Text = "Salario:"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbRefFamPer
        '
        Me.tbRefFamPer.BackColor = System.Drawing.Color.White
        Me.tbRefFamPer.Controls.Add(Me.btnSigTab7_1)
        Me.tbRefFamPer.Controls.Add(Me.btnAtrasTab7_1)
        Me.tbRefFamPer.Controls.Add(Me.GroupBox7)
        Me.tbRefFamPer.Controls.Add(Me.GroupBox8)
        Me.tbRefFamPer.Location = New System.Drawing.Point(4, 40)
        Me.tbRefFamPer.Name = "tbRefFamPer"
        Me.tbRefFamPer.Size = New System.Drawing.Size(846, 500)
        Me.tbRefFamPer.TabIndex = 9
        Me.tbRefFamPer.Text = "Referencias Familiares - Personales"
        '
        'btnSigTab7_1
        '
        Me.btnSigTab7_1.Location = New System.Drawing.Point(745, 449)
        Me.btnSigTab7_1.Name = "btnSigTab7_1"
        Me.btnSigTab7_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTab7_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTab7_1.TabIndex = 231
        Me.btnSigTab7_1.Text = "Siguiente"
        Me.btnSigTab7_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTab7_1.UseSelectable = True
        Me.btnSigTab7_1.UseStyleColors = True
        '
        'btnAtrasTab7_1
        '
        Me.btnAtrasTab7_1.Location = New System.Drawing.Point(648, 449)
        Me.btnAtrasTab7_1.Name = "btnAtrasTab7_1"
        Me.btnAtrasTab7_1.Size = New System.Drawing.Size(90, 32)
        Me.btnAtrasTab7_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTab7_1.TabIndex = 229
        Me.btnAtrasTab7_1.Text = "Atras"
        Me.btnAtrasTab7_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTab7_1.UseSelectable = True
        Me.btnAtrasTab7_1.UseStyleColors = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.btEditRF1)
        Me.GroupBox7.Controls.Add(Me.btDelRF1)
        Me.GroupBox7.Controls.Add(Me.btNewRF1)
        Me.GroupBox7.Controls.Add(Me.fgRefFam)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox7.Location = New System.Drawing.Point(10, 17)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(825, 203)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Referencias Familiares"
        '
        'btEditRF1
        '
        Me.btEditRF1.Location = New System.Drawing.Point(104, 25)
        Me.btEditRF1.Name = "btEditRF1"
        Me.btEditRF1.Size = New System.Drawing.Size(90, 33)
        Me.btEditRF1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditRF1.TabIndex = 208
        Me.btEditRF1.Text = "Modificar"
        Me.btEditRF1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditRF1.UseSelectable = True
        Me.btEditRF1.UseStyleColors = True
        '
        'btDelRF1
        '
        Me.btDelRF1.Location = New System.Drawing.Point(202, 25)
        Me.btDelRF1.Name = "btDelRF1"
        Me.btDelRF1.Size = New System.Drawing.Size(90, 33)
        Me.btDelRF1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelRF1.TabIndex = 207
        Me.btDelRF1.Text = "Eliminar"
        Me.btDelRF1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelRF1.UseSelectable = True
        Me.btDelRF1.UseStyleColors = True
        '
        'btNewRF1
        '
        Me.btNewRF1.Location = New System.Drawing.Point(7, 25)
        Me.btNewRF1.Name = "btNewRF1"
        Me.btNewRF1.Size = New System.Drawing.Size(90, 33)
        Me.btNewRF1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewRF1.TabIndex = 206
        Me.btNewRF1.Text = "Agregar"
        Me.btNewRF1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewRF1.UseSelectable = True
        Me.btNewRF1.UseStyleColors = True
        '
        'fgRefFam
        '
        Me.fgRefFam.AllowEditing = False
        Me.fgRefFam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgRefFam.BackColor = System.Drawing.Color.White
        Me.fgRefFam.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRefFam.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgRefFam.ForeColor = System.Drawing.Color.Teal
        Me.fgRefFam.Location = New System.Drawing.Point(7, 65)
        Me.fgRefFam.Name = "fgRefFam"
        Me.fgRefFam.Rows.Count = 1
        Me.fgRefFam.Rows.DefaultSize = 22
        Me.fgRefFam.Size = New System.Drawing.Size(811, 129)
        Me.fgRefFam.StyleInfo = resources.GetString("fgRefFam.StyleInfo")
        Me.fgRefFam.TabIndex = 3
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.btEditRP1)
        Me.GroupBox8.Controls.Add(Me.btDelRP1)
        Me.GroupBox8.Controls.Add(Me.btNewRP1)
        Me.GroupBox8.Controls.Add(Me.fgRefPer)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox8.Location = New System.Drawing.Point(10, 230)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(825, 212)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Referencias Personales"
        '
        'btEditRP1
        '
        Me.btEditRP1.Location = New System.Drawing.Point(104, 22)
        Me.btEditRP1.Name = "btEditRP1"
        Me.btEditRP1.Size = New System.Drawing.Size(90, 32)
        Me.btEditRP1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditRP1.TabIndex = 208
        Me.btEditRP1.Text = "Modificar"
        Me.btEditRP1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditRP1.UseSelectable = True
        Me.btEditRP1.UseStyleColors = True
        '
        'btDelRP1
        '
        Me.btDelRP1.Location = New System.Drawing.Point(202, 22)
        Me.btDelRP1.Name = "btDelRP1"
        Me.btDelRP1.Size = New System.Drawing.Size(90, 32)
        Me.btDelRP1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelRP1.TabIndex = 207
        Me.btDelRP1.Text = "Eliminar"
        Me.btDelRP1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelRP1.UseSelectable = True
        Me.btDelRP1.UseStyleColors = True
        '
        'btNewRP1
        '
        Me.btNewRP1.Location = New System.Drawing.Point(7, 22)
        Me.btNewRP1.Name = "btNewRP1"
        Me.btNewRP1.Size = New System.Drawing.Size(90, 32)
        Me.btNewRP1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewRP1.TabIndex = 206
        Me.btNewRP1.Text = "Agregar"
        Me.btNewRP1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewRP1.UseSelectable = True
        Me.btNewRP1.UseStyleColors = True
        '
        'fgRefPer
        '
        Me.fgRefPer.AllowEditing = False
        Me.fgRefPer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgRefPer.BackColor = System.Drawing.Color.White
        Me.fgRefPer.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRefPer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgRefPer.ForeColor = System.Drawing.Color.Teal
        Me.fgRefPer.Location = New System.Drawing.Point(7, 65)
        Me.fgRefPer.Name = "fgRefPer"
        Me.fgRefPer.Rows.Count = 1
        Me.fgRefPer.Rows.DefaultSize = 22
        Me.fgRefPer.Size = New System.Drawing.Size(811, 138)
        Me.fgRefPer.StyleInfo = resources.GetString("fgRefPer.StyleInfo")
        Me.fgRefPer.TabIndex = 3
        '
        'tbRefComBan
        '
        Me.tbRefComBan.BackColor = System.Drawing.Color.White
        Me.tbRefComBan.Controls.Add(Me.MetroButton1)
        Me.tbRefComBan.Controls.Add(Me.MetroButton2)
        Me.tbRefComBan.Controls.Add(Me.GroupBox10)
        Me.tbRefComBan.Controls.Add(Me.GroupBox9)
        Me.tbRefComBan.ForeColor = System.Drawing.Color.Teal
        Me.tbRefComBan.Location = New System.Drawing.Point(4, 40)
        Me.tbRefComBan.Name = "tbRefComBan"
        Me.tbRefComBan.Size = New System.Drawing.Size(846, 500)
        Me.tbRefComBan.TabIndex = 10
        Me.tbRefComBan.Text = "Referencias Comerciales - Bancarias"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(745, 449)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 233
        Me.MetroButton1.Text = "Siguiente"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(648, 449)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 232
        Me.MetroButton2.Text = "Atras"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Controls.Add(Me.btEditRB1)
        Me.GroupBox10.Controls.Add(Me.btDelRB1)
        Me.GroupBox10.Controls.Add(Me.btNewRB1)
        Me.GroupBox10.Controls.Add(Me.fgRefBan)
        Me.GroupBox10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox10.Location = New System.Drawing.Point(10, 230)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(825, 212)
        Me.GroupBox10.TabIndex = 3
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Referencias Bancarias"
        '
        'btEditRB1
        '
        Me.btEditRB1.Location = New System.Drawing.Point(104, 22)
        Me.btEditRB1.Name = "btEditRB1"
        Me.btEditRB1.Size = New System.Drawing.Size(90, 32)
        Me.btEditRB1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditRB1.TabIndex = 208
        Me.btEditRB1.Text = "Modificar"
        Me.btEditRB1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditRB1.UseSelectable = True
        Me.btEditRB1.UseStyleColors = True
        '
        'btDelRB1
        '
        Me.btDelRB1.Location = New System.Drawing.Point(202, 22)
        Me.btDelRB1.Name = "btDelRB1"
        Me.btDelRB1.Size = New System.Drawing.Size(90, 32)
        Me.btDelRB1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelRB1.TabIndex = 207
        Me.btDelRB1.Text = "Eliminar"
        Me.btDelRB1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelRB1.UseSelectable = True
        Me.btDelRB1.UseStyleColors = True
        '
        'btNewRB1
        '
        Me.btNewRB1.Location = New System.Drawing.Point(7, 22)
        Me.btNewRB1.Name = "btNewRB1"
        Me.btNewRB1.Size = New System.Drawing.Size(90, 32)
        Me.btNewRB1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewRB1.TabIndex = 206
        Me.btNewRB1.Text = "Agregar"
        Me.btNewRB1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewRB1.UseSelectable = True
        Me.btNewRB1.UseStyleColors = True
        '
        'fgRefBan
        '
        Me.fgRefBan.AllowEditing = False
        Me.fgRefBan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgRefBan.BackColor = System.Drawing.Color.White
        Me.fgRefBan.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRefBan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgRefBan.ForeColor = System.Drawing.Color.Teal
        Me.fgRefBan.Location = New System.Drawing.Point(7, 65)
        Me.fgRefBan.Name = "fgRefBan"
        Me.fgRefBan.Rows.Count = 1
        Me.fgRefBan.Rows.DefaultSize = 22
        Me.fgRefBan.Size = New System.Drawing.Size(811, 129)
        Me.fgRefBan.StyleInfo = resources.GetString("fgRefBan.StyleInfo")
        Me.fgRefBan.TabIndex = 3
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.btEditRC1)
        Me.GroupBox9.Controls.Add(Me.btDelRC1)
        Me.GroupBox9.Controls.Add(Me.btNewRC1)
        Me.GroupBox9.Controls.Add(Me.fgRefCom)
        Me.GroupBox9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox9.Location = New System.Drawing.Point(10, 17)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(825, 213)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Referencias Comerciales"
        '
        'btEditRC1
        '
        Me.btEditRC1.Location = New System.Drawing.Point(104, 22)
        Me.btEditRC1.Name = "btEditRC1"
        Me.btEditRC1.Size = New System.Drawing.Size(90, 32)
        Me.btEditRC1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditRC1.TabIndex = 208
        Me.btEditRC1.Text = "Modificar"
        Me.btEditRC1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditRC1.UseSelectable = True
        Me.btEditRC1.UseStyleColors = True
        '
        'btDelRC1
        '
        Me.btDelRC1.Location = New System.Drawing.Point(202, 22)
        Me.btDelRC1.Name = "btDelRC1"
        Me.btDelRC1.Size = New System.Drawing.Size(90, 32)
        Me.btDelRC1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelRC1.TabIndex = 207
        Me.btDelRC1.Text = "Eliminar"
        Me.btDelRC1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelRC1.UseSelectable = True
        Me.btDelRC1.UseStyleColors = True
        '
        'btNewRC1
        '
        Me.btNewRC1.Location = New System.Drawing.Point(7, 22)
        Me.btNewRC1.Name = "btNewRC1"
        Me.btNewRC1.Size = New System.Drawing.Size(90, 32)
        Me.btNewRC1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewRC1.TabIndex = 206
        Me.btNewRC1.Text = "Agregar"
        Me.btNewRC1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewRC1.UseSelectable = True
        Me.btNewRC1.UseStyleColors = True
        '
        'fgRefCom
        '
        Me.fgRefCom.AllowEditing = False
        Me.fgRefCom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgRefCom.BackColor = System.Drawing.Color.White
        Me.fgRefCom.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRefCom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgRefCom.ForeColor = System.Drawing.Color.Teal
        Me.fgRefCom.Location = New System.Drawing.Point(7, 74)
        Me.fgRefCom.Name = "fgRefCom"
        Me.fgRefCom.Rows.Count = 1
        Me.fgRefCom.Rows.DefaultSize = 22
        Me.fgRefCom.Size = New System.Drawing.Size(811, 129)
        Me.fgRefCom.StyleInfo = resources.GetString("fgRefCom.StyleInfo")
        Me.fgRefCom.TabIndex = 3
        '
        'tbIngGastos
        '
        Me.tbIngGastos.BackColor = System.Drawing.Color.White
        Me.tbIngGastos.Controls.Add(Me.MetroButton3)
        Me.tbIngGastos.Controls.Add(Me.MetroButton4)
        Me.tbIngGastos.Controls.Add(Me.GroupBox12)
        Me.tbIngGastos.Controls.Add(Me.GroupBox11)
        Me.tbIngGastos.ForeColor = System.Drawing.Color.Teal
        Me.tbIngGastos.Location = New System.Drawing.Point(4, 40)
        Me.tbIngGastos.Name = "tbIngGastos"
        Me.tbIngGastos.Size = New System.Drawing.Size(846, 500)
        Me.tbIngGastos.TabIndex = 11
        Me.tbIngGastos.Text = "Ingresos - Gastos"
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(736, 441)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 235
        Me.MetroButton3.Text = "Siguiente"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(638, 441)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton4.TabIndex = 234
        Me.MetroButton4.Text = "Atras"
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Controls.Add(Me.btEditGt1)
        Me.GroupBox12.Controls.Add(Me.btDelGt1)
        Me.GroupBox12.Controls.Add(Me.btNewGt1)
        Me.GroupBox12.Controls.Add(Me.fgGastos)
        Me.GroupBox12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox12.Location = New System.Drawing.Point(10, 222)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(816, 212)
        Me.GroupBox12.TabIndex = 3
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Gastos"
        '
        'btEditGt1
        '
        Me.btEditGt1.Location = New System.Drawing.Point(104, 22)
        Me.btEditGt1.Name = "btEditGt1"
        Me.btEditGt1.Size = New System.Drawing.Size(90, 32)
        Me.btEditGt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditGt1.TabIndex = 208
        Me.btEditGt1.Text = "Modificar"
        Me.btEditGt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditGt1.UseSelectable = True
        Me.btEditGt1.UseStyleColors = True
        '
        'btDelGt1
        '
        Me.btDelGt1.Location = New System.Drawing.Point(202, 22)
        Me.btDelGt1.Name = "btDelGt1"
        Me.btDelGt1.Size = New System.Drawing.Size(90, 32)
        Me.btDelGt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelGt1.TabIndex = 207
        Me.btDelGt1.Text = "Eliminar"
        Me.btDelGt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelGt1.UseSelectable = True
        Me.btDelGt1.UseStyleColors = True
        '
        'btNewGt1
        '
        Me.btNewGt1.Location = New System.Drawing.Point(7, 22)
        Me.btNewGt1.Name = "btNewGt1"
        Me.btNewGt1.Size = New System.Drawing.Size(90, 32)
        Me.btNewGt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewGt1.TabIndex = 206
        Me.btNewGt1.Text = "Agregar"
        Me.btNewGt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewGt1.UseSelectable = True
        Me.btNewGt1.UseStyleColors = True
        '
        'fgGastos
        '
        Me.fgGastos.AllowEditing = False
        Me.fgGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgGastos.BackColor = System.Drawing.Color.White
        Me.fgGastos.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgGastos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgGastos.ForeColor = System.Drawing.Color.Teal
        Me.fgGastos.Location = New System.Drawing.Point(10, 65)
        Me.fgGastos.Name = "fgGastos"
        Me.fgGastos.Rows.Count = 1
        Me.fgGastos.Rows.DefaultSize = 22
        Me.fgGastos.Size = New System.Drawing.Size(796, 129)
        Me.fgGastos.StyleInfo = resources.GetString("fgGastos.StyleInfo")
        Me.fgGastos.TabIndex = 3
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.White
        Me.GroupBox11.Controls.Add(Me.btEditIng1)
        Me.GroupBox11.Controls.Add(Me.btDelIng1)
        Me.GroupBox11.Controls.Add(Me.btNewIng1)
        Me.GroupBox11.Controls.Add(Me.fgIngresos)
        Me.GroupBox11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox11.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(825, 213)
        Me.GroupBox11.TabIndex = 2
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Ingresos"
        '
        'btEditIng1
        '
        Me.btEditIng1.Location = New System.Drawing.Point(104, 22)
        Me.btEditIng1.Name = "btEditIng1"
        Me.btEditIng1.Size = New System.Drawing.Size(90, 32)
        Me.btEditIng1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditIng1.TabIndex = 208
        Me.btEditIng1.Text = "Modificar"
        Me.btEditIng1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditIng1.UseSelectable = True
        Me.btEditIng1.UseStyleColors = True
        '
        'btDelIng1
        '
        Me.btDelIng1.Location = New System.Drawing.Point(202, 22)
        Me.btDelIng1.Name = "btDelIng1"
        Me.btDelIng1.Size = New System.Drawing.Size(90, 32)
        Me.btDelIng1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelIng1.TabIndex = 207
        Me.btDelIng1.Text = "Eliminar"
        Me.btDelIng1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelIng1.UseSelectable = True
        Me.btDelIng1.UseStyleColors = True
        '
        'btNewIng1
        '
        Me.btNewIng1.Location = New System.Drawing.Point(7, 22)
        Me.btNewIng1.Name = "btNewIng1"
        Me.btNewIng1.Size = New System.Drawing.Size(90, 32)
        Me.btNewIng1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewIng1.TabIndex = 206
        Me.btNewIng1.Text = "Agregar"
        Me.btNewIng1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewIng1.UseSelectable = True
        Me.btNewIng1.UseStyleColors = True
        '
        'fgIngresos
        '
        Me.fgIngresos.AllowEditing = False
        Me.fgIngresos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgIngresos.BackColor = System.Drawing.Color.White
        Me.fgIngresos.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgIngresos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgIngresos.ForeColor = System.Drawing.Color.Teal
        Me.fgIngresos.Location = New System.Drawing.Point(10, 65)
        Me.fgIngresos.Name = "fgIngresos"
        Me.fgIngresos.Rows.Count = 1
        Me.fgIngresos.Rows.DefaultSize = 22
        Me.fgIngresos.Size = New System.Drawing.Size(806, 129)
        Me.fgIngresos.StyleInfo = resources.GetString("fgIngresos.StyleInfo")
        Me.fgIngresos.TabIndex = 3
        '
        'tbBienVeh
        '
        Me.tbBienVeh.BackColor = System.Drawing.Color.White
        Me.tbBienVeh.Controls.Add(Me.MetroButton5)
        Me.tbBienVeh.Controls.Add(Me.MetroButton6)
        Me.tbBienVeh.Controls.Add(Me.GroupBox14)
        Me.tbBienVeh.Controls.Add(Me.GroupBox13)
        Me.tbBienVeh.ForeColor = System.Drawing.Color.Teal
        Me.tbBienVeh.Location = New System.Drawing.Point(4, 40)
        Me.tbBienVeh.Name = "tbBienVeh"
        Me.tbBienVeh.Size = New System.Drawing.Size(846, 500)
        Me.tbBienVeh.TabIndex = 12
        Me.tbBienVeh.Text = "Bienes Inmuebles - Vehículos"
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(740, 449)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton5.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton5.TabIndex = 235
        Me.MetroButton5.Text = "Siguiente"
        Me.MetroButton5.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton5.UseSelectable = True
        Me.MetroButton5.UseStyleColors = True
        '
        'MetroButton6
        '
        Me.MetroButton6.Location = New System.Drawing.Point(643, 449)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton6.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton6.TabIndex = 234
        Me.MetroButton6.Text = "Atras"
        Me.MetroButton6.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton6.UseSelectable = True
        Me.MetroButton6.UseStyleColors = True
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.White
        Me.GroupBox14.Controls.Add(Me.btEditVh1)
        Me.GroupBox14.Controls.Add(Me.btDelVh1)
        Me.GroupBox14.Controls.Add(Me.btNewVh1)
        Me.GroupBox14.Controls.Add(Me.fgVehiculos)
        Me.GroupBox14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox14.Location = New System.Drawing.Point(14, 230)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(816, 212)
        Me.GroupBox14.TabIndex = 6
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Vehículos"
        '
        'btEditVh1
        '
        Me.btEditVh1.Location = New System.Drawing.Point(104, 22)
        Me.btEditVh1.Name = "btEditVh1"
        Me.btEditVh1.Size = New System.Drawing.Size(90, 32)
        Me.btEditVh1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditVh1.TabIndex = 208
        Me.btEditVh1.Text = "Modificar"
        Me.btEditVh1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditVh1.UseSelectable = True
        Me.btEditVh1.UseStyleColors = True
        '
        'btDelVh1
        '
        Me.btDelVh1.Location = New System.Drawing.Point(202, 22)
        Me.btDelVh1.Name = "btDelVh1"
        Me.btDelVh1.Size = New System.Drawing.Size(90, 32)
        Me.btDelVh1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelVh1.TabIndex = 207
        Me.btDelVh1.Text = "Eliminar"
        Me.btDelVh1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelVh1.UseSelectable = True
        Me.btDelVh1.UseStyleColors = True
        '
        'btNewVh1
        '
        Me.btNewVh1.Location = New System.Drawing.Point(7, 22)
        Me.btNewVh1.Name = "btNewVh1"
        Me.btNewVh1.Size = New System.Drawing.Size(90, 32)
        Me.btNewVh1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewVh1.TabIndex = 206
        Me.btNewVh1.Text = "Agregar"
        Me.btNewVh1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewVh1.UseSelectable = True
        Me.btNewVh1.UseStyleColors = True
        '
        'fgVehiculos
        '
        Me.fgVehiculos.AllowEditing = False
        Me.fgVehiculos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgVehiculos.BackColor = System.Drawing.Color.White
        Me.fgVehiculos.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgVehiculos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgVehiculos.ForeColor = System.Drawing.Color.Teal
        Me.fgVehiculos.Location = New System.Drawing.Point(10, 65)
        Me.fgVehiculos.Name = "fgVehiculos"
        Me.fgVehiculos.Rows.Count = 1
        Me.fgVehiculos.Rows.DefaultSize = 22
        Me.fgVehiculos.Size = New System.Drawing.Size(796, 129)
        Me.fgVehiculos.StyleInfo = resources.GetString("fgVehiculos.StyleInfo")
        Me.fgVehiculos.TabIndex = 3
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.White
        Me.GroupBox13.Controls.Add(Me.btEditBI1)
        Me.GroupBox13.Controls.Add(Me.btDelBI1)
        Me.GroupBox13.Controls.Add(Me.btNewBI1)
        Me.GroupBox13.Controls.Add(Me.fgBienes)
        Me.GroupBox13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox13.Location = New System.Drawing.Point(10, 17)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(825, 213)
        Me.GroupBox13.TabIndex = 5
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Bienes Inmuebles"
        '
        'btEditBI1
        '
        Me.btEditBI1.Location = New System.Drawing.Point(104, 22)
        Me.btEditBI1.Name = "btEditBI1"
        Me.btEditBI1.Size = New System.Drawing.Size(90, 32)
        Me.btEditBI1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditBI1.TabIndex = 208
        Me.btEditBI1.Text = "Modificar"
        Me.btEditBI1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditBI1.UseSelectable = True
        Me.btEditBI1.UseStyleColors = True
        '
        'btDelBI1
        '
        Me.btDelBI1.Location = New System.Drawing.Point(202, 22)
        Me.btDelBI1.Name = "btDelBI1"
        Me.btDelBI1.Size = New System.Drawing.Size(90, 32)
        Me.btDelBI1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelBI1.TabIndex = 207
        Me.btDelBI1.Text = "Eliminar"
        Me.btDelBI1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelBI1.UseSelectable = True
        Me.btDelBI1.UseStyleColors = True
        '
        'btNewBI1
        '
        Me.btNewBI1.Location = New System.Drawing.Point(7, 22)
        Me.btNewBI1.Name = "btNewBI1"
        Me.btNewBI1.Size = New System.Drawing.Size(90, 32)
        Me.btNewBI1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewBI1.TabIndex = 206
        Me.btNewBI1.Text = "Agregar"
        Me.btNewBI1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewBI1.UseSelectable = True
        Me.btNewBI1.UseStyleColors = True
        '
        'fgBienes
        '
        Me.fgBienes.AllowEditing = False
        Me.fgBienes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgBienes.BackColor = System.Drawing.Color.White
        Me.fgBienes.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgBienes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgBienes.ForeColor = System.Drawing.Color.Teal
        Me.fgBienes.Location = New System.Drawing.Point(10, 65)
        Me.fgBienes.Name = "fgBienes"
        Me.fgBienes.Rows.Count = 1
        Me.fgBienes.Rows.DefaultSize = 22
        Me.fgBienes.Size = New System.Drawing.Size(806, 129)
        Me.fgBienes.StyleInfo = resources.GetString("fgBienes.StyleInfo")
        Me.fgBienes.TabIndex = 3
        '
        'tbObligGar
        '
        Me.tbObligGar.BackColor = System.Drawing.Color.White
        Me.tbObligGar.Controls.Add(Me.MetroButton8)
        Me.tbObligGar.Controls.Add(Me.GroupBox15)
        Me.tbObligGar.ForeColor = System.Drawing.Color.Teal
        Me.tbObligGar.Location = New System.Drawing.Point(4, 40)
        Me.tbObligGar.Name = "tbObligGar"
        Me.tbObligGar.Size = New System.Drawing.Size(846, 500)
        Me.tbObligGar.TabIndex = 13
        Me.tbObligGar.Text = "Obligaciones"
        '
        'MetroButton8
        '
        Me.MetroButton8.Location = New System.Drawing.Point(745, 440)
        Me.MetroButton8.Name = "MetroButton8"
        Me.MetroButton8.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton8.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton8.TabIndex = 234
        Me.MetroButton8.Text = "Atras"
        Me.MetroButton8.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton8.UseSelectable = True
        Me.MetroButton8.UseStyleColors = True
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.White
        Me.GroupBox15.Controls.Add(Me.btEditOb1)
        Me.GroupBox15.Controls.Add(Me.btDelOb1)
        Me.GroupBox15.Controls.Add(Me.btNewOb1)
        Me.GroupBox15.Controls.Add(Me.fgOblig)
        Me.GroupBox15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox15.Location = New System.Drawing.Point(10, 17)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(825, 213)
        Me.GroupBox15.TabIndex = 5
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Obligaciones"
        '
        'btEditOb1
        '
        Me.btEditOb1.Location = New System.Drawing.Point(104, 22)
        Me.btEditOb1.Name = "btEditOb1"
        Me.btEditOb1.Size = New System.Drawing.Size(90, 32)
        Me.btEditOb1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditOb1.TabIndex = 208
        Me.btEditOb1.Text = "Modificar"
        Me.btEditOb1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditOb1.UseSelectable = True
        Me.btEditOb1.UseStyleColors = True
        '
        'btDelOb1
        '
        Me.btDelOb1.Location = New System.Drawing.Point(202, 22)
        Me.btDelOb1.Name = "btDelOb1"
        Me.btDelOb1.Size = New System.Drawing.Size(90, 32)
        Me.btDelOb1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelOb1.TabIndex = 207
        Me.btDelOb1.Text = "Eliminar"
        Me.btDelOb1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelOb1.UseSelectable = True
        Me.btDelOb1.UseStyleColors = True
        '
        'btNewOb1
        '
        Me.btNewOb1.Location = New System.Drawing.Point(7, 22)
        Me.btNewOb1.Name = "btNewOb1"
        Me.btNewOb1.Size = New System.Drawing.Size(90, 32)
        Me.btNewOb1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewOb1.TabIndex = 206
        Me.btNewOb1.Text = "Agregar"
        Me.btNewOb1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewOb1.UseSelectable = True
        Me.btNewOb1.UseStyleColors = True
        '
        'fgOblig
        '
        Me.fgOblig.AllowEditing = False
        Me.fgOblig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgOblig.BackColor = System.Drawing.Color.White
        Me.fgOblig.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgOblig.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgOblig.ForeColor = System.Drawing.Color.Teal
        Me.fgOblig.Location = New System.Drawing.Point(10, 65)
        Me.fgOblig.Name = "fgOblig"
        Me.fgOblig.Rows.Count = 1
        Me.fgOblig.Rows.DefaultSize = 22
        Me.fgOblig.Size = New System.Drawing.Size(806, 129)
        Me.fgOblig.StyleInfo = resources.GetString("fgOblig.StyleInfo")
        Me.fgOblig.TabIndex = 3
        '
        'frmMsCrFiadores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(902, 642)
        Me.Controls.Add(Me.tbSolic)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(902, 642)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(902, 642)
        Me.Name = "frmMsCrFiadores"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Fiadores"
        Me.tbSolic.ResumeLayout(False)
        Me.tbDatosGral.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuidG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDatosTrab.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtSalAnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDatGralIII.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nuDGrupoFam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalarioC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRefFamPer.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.fgRefFam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.fgRefPer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRefComBan.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.fgRefBan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.fgRefCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbIngGastos.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.fgGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        CType(Me.fgIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBienVeh.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        CType(Me.fgVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        CType(Me.fgBienes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbObligGar.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        CType(Me.fgOblig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public pNumSolicitud As Long, pAccion As String, pAsociado As Boolean, pCodEnlace As Long, vFiador As String






    Private Sub frmMsCrFiadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc ', x As Integer

            If Me.vFiador = 2 Then
                Me.chkFiadorDesc.Text = "&Codeudor descartado"
            End If
            Me.txtSalario.Value = 0
            Me.txtSalarioC.Value = 0
            Me.txtSalAnt.Value = 0
            Me.dtpFecCargoDesde.Value = Now
            Me.dtpFecCargoHasta.Value = Now
            Me.dtpFecExtDui.Value = Now
            Me.dtpFecIniTrab.Value = Now
            Me.dtpFecIniTrabCy.Value = Now
            Me.dtpFecNac.Value = Now
            Me.dtpFecPago.Value = Now
            Me.ControlTab(False, True)

            If Me.pAccion = "Modificar" Then
                ds = oPerif.ConsultarDatGral("*", "CodEnlace= " & Me.pCodEnlace & "", "CodEnlace", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtDuidG.Value = Filas.Item(0)("Dui")
                    Me.pNumSolicitud = IIf(IsDBNull(Filas.Item(0)("NumSolicitud")), 0, Filas.Item(0)("NumSolicitud"))
                    Me.txtNit.Value = IIf(IsDBNull(Filas.Item(0)("Nit")), "", Filas.Item(0)("Nit"))
                    Me.dtpFecExtDui.Value = IIf(IsDBNull(Filas.Item(0)("FechaExtenDUI")), Now, Filas.Item(0)("FechaExtenDUI"))
                    Me.txtIsss.Text = IIf(IsDBNull(Filas.Item(0)("Isss")), "", Filas.Item(0)("Isss"))
                    Me.dtpFecNac.Value = IIf(IsDBNull(Filas.Item(0)("FechaNac")), Now, Filas.Item(0)("FechaNac"))
                    Me.txtNombresdG.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres"))
                    Me.txtApe1dG.Text = IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1"))
                    Me.txtApe2dG.Text = IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                    Me.txtApe3dG.Text = IIf(IsDBNull(Filas.Item(0)("Apellido3")), "", Filas.Item(0)("Apellido3"))
                    Me.txtTelCasa.Text = IIf(IsDBNull(Filas.Item(0)("TelCasa")), "", Filas.Item(0)("TelCasa"))
                    Me.txtDireccion.Text = IIf(IsDBNull(Filas.Item(0)("Direccion")), "", Filas.Item(0)("Direccion"))
                    Me.txtCel.Text = IIf(IsDBNull(Filas.Item(0)("Celular")), "", Filas.Item(0)("Celular"))
                    Me.chkCasaPropia.Checked = IIf(IsDBNull(Filas.Item(0)("CasaPropia")), False, IIf(Filas.Item(0)("CasaPropia") = "1", True, False))
                    Me.txtPropCasa.Text = IIf(IsDBNull(Filas.Item(0)("PropietarioCasa")), "", Filas.Item(0)("PropietarioCasa"))

                    Me.chkFiadorDesc.Checked = IIf(IsDBNull(Filas.Item(0)("FiadorDescartado")), False, IIf(Filas.Item(0)("FiadorDescartado") = "1", True, False))
                    Me.txtMotivoDesc.Text = IIf(IsDBNull(Filas.Item(0)("MotivoDescartado")), "", Filas.Item(0)("MotivoDescartado"))

                    Me.txtLugTrabdG.Text = IIf(IsDBNull(Filas.Item(0)("LugarTrabajo")), "", Filas.Item(0)("LugarTrabajo"))
                    Me.dtpFecIniTrab.Value = IIf(IsDBNull(Filas.Item(0)("FechaInicioTrabajo")), Now, Filas.Item(0)("FechaInicioTrabajo"))
                    Me.txtDirTrabdG.Text = IIf(IsDBNull(Filas.Item(0)("DireccionTrabajo")), "", Filas.Item(0)("DireccionTrabajo"))
                    Me.txtSalario.Value = IIf(IsDBNull(Filas.Item(0)("Sueldo")), 0, Filas.Item(0)("Sueldo"))
                    Me.txtTelOficdG.Text = IIf(IsDBNull(Filas.Item(0)("TelOficina")), "", Filas.Item(0)("TelOficina"))
                    Me.txtExtOficdG.Text = IIf(IsDBNull(Filas.Item(0)("ExtensionOfic")), "", Filas.Item(0)("ExtensionOfic"))
                    Me.dtpFecPago.Value = IIf(IsDBNull(Filas.Item(0)("FechaPagoSueldo")), Now, Filas.Item(0)("FechaPagoSueldo"))
                    Me.txtCargo.Text = IIf(IsDBNull(Filas.Item(0)("Cargo")), "", Filas.Item(0)("Cargo"))
                    Me.txtFormaPago.Text = IIf(IsDBNull(Filas.Item(0)("FormaPago")), "", Filas.Item(0)("FormaPago"))
                    Me.txtCodProfdG.Text = IIf(IsDBNull(Filas.Item(0)("CodProfesion")), "", Filas.Item(0)("CodProfesion"))
                    Me.txtTrabAnt.Text = IIf(IsDBNull(Filas.Item(0)("TrabajoAnterior")), "", Filas.Item(0)("TrabajoAnterior"))
                    Me.txtSalAnt.Value = IIf(IsDBNull(Filas.Item(0)("SueldoTrabajoAnterior")), 0, Filas.Item(0)("SueldoTrabajoAnterior"))
                    Me.txtCargoAnt.Text = IIf(IsDBNull(Filas.Item(0)("CargoTrabajoAnterior")), "", Filas.Item(0)("CargoTrabajoAnterior"))
                    Me.dtpFecCargoDesde.Value = IIf(IsDBNull(Filas.Item(0)("FechaCargoDesde")), Now, Filas.Item(0)("FechaCargoDesde"))
                    Me.txtCausaRetiro.Text = IIf(IsDBNull(Filas.Item(0)("CausaRetiro")), "", Filas.Item(0)("CausaRetiro"))
                    Me.dtpFecCargoHasta.Value = IIf(IsDBNull(Filas.Item(0)("FechaCargoHasta")), Now, Filas.Item(0)("FechaCargoHasta"))

                    Me.txtConyugue.Text = IIf(IsDBNull(Filas.Item(0)("NombreConyugue")), "", Filas.Item(0)("NombreConyugue"))
                    Me.txtApe1Cy.Text = IIf(IsDBNull(Filas.Item(0)("Apellido1Conyugue")), "", Filas.Item(0)("Apellido1Conyugue"))
                    Me.txtApe2Cy.Text = IIf(IsDBNull(Filas.Item(0)("Apellido2Conyugue")), "", Filas.Item(0)("Apellido2Conyugue"))
                    Me.txtApe3Cy.Text = IIf(IsDBNull(Filas.Item(0)("Apellido3Conyugue")), "", Filas.Item(0)("Apellido3Conyugue"))
                    Me.txtLugTrabCy.Text = IIf(IsDBNull(Filas.Item(0)("LugarTrabConyugue")), "", Filas.Item(0)("LugarTrabConyugue"))
                    Me.dtpFecIniTrabCy.Value = IIf(IsDBNull(Filas.Item(0)("FechaDesdeTrabConyugue")), Now, Filas.Item(0)("FechaDesdeTrabConyugue"))
                    Me.txtTelTrabCy.Text = IIf(IsDBNull(Filas.Item(0)("TelTrabajoConyugue")), "", Filas.Item(0)("TelTrabajoConyugue"))
                    Me.txtSalarioC.Value = IIf(IsDBNull(Filas.Item(0)("SueldoConyugue")), 0, Filas.Item(0)("SueldoConyugue"))
                    Me.txtDirFam.Text = IIf(IsDBNull(Filas.Item(0)("DirecciondeFamiliar")), "", Filas.Item(0)("DirecciondeFamiliar"))
                    Me.nuDGrupoFam.Value = IIf(IsDBNull(Filas.Item(0)("NumGrupoFamiliar")), 0, Filas.Item(0)("NumGrupoFamiliar"))
                    Me.txtDptoTrabajo.Text = IIf(IsDBNull(Filas.Item(0)("DepartamentoTrabajo")), "", Filas.Item(0)("DepartamentoTrabajo"))
                    Me.ControlTab(True, True)
                    ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtCodProfdG.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                            Me.txtProfdG.Text = CStr(Filas.Item(0)("Descripcion"))
                        End If
                    End If

                    ds = oAsoc.ConsultarAsociado("NoSocio", "Dui='" & Me.txtDuidG.Value & "'", "DUI", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then Me.txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))

                    ds = oPerif.ConsultarRefFamiliar("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgRefFam.DataSource = ds.Tables(0)

                    ds = oPerif.ConsultarRefPersonal("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgRefPer.DataSource = ds.Tables(0)

                    ds = oPerif.ConsultarRefBancaria("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgRefBan.DataSource = ds.Tables(0)

                    ds = oPerif.ConsultarRefComercial("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgRefCom.DataSource = ds.Tables(0)

                    ds = oPerif.ConsultarIngresos("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgIngresos.DataSource = ds.Tables(0)

                    ds = oPerif.ConsultarGastos("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgGastos.DataSource = ds.Tables(0)

                    ds = oPerif.ConsultarBienInmueble("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgBienes.DataSource = ds.Tables(0)

                    ds = oPerif.ConsultarVehiculos("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgVehiculos.DataSource = ds.Tables(0)

                    ds = oPerif.ConsultarObligaciones("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgOblig.DataSource = ds.Tables(0)

                End If

            End If

            Me.tbObligGar.Visible = False

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodProfdG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodProfdG.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Try
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtCodProfdG.Text) & "'", "CodProfesion", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtProfdG.Text = CStr(Filas.Item(0)("Descripcion"))
                        Me.txtTrabAnt.Focus()
                    End If
                Else
                    txtCodProfdG_DoubleClick(sender, e)
                End If

            Catch ex As Exception
               MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub txtCodProfdG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProfdG.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Profesiones"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarProfesiones("*", "", "CodProfesion", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodProfdG.Text = ofrm.Resultado.Trim
            Me.txtProfdG.Text = ofrm.Resultado2.Trim
            Me.txtTrabAnt.Focus()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtDuidG_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuidG.LostFocus
        If Me.txtDuidG.Text.Trim = "" Then Exit Sub
        Dim ds As New Data.DataSet, Filas As Data.DataRowCollection
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            ds = oAsoc.ConsultarAsociado("NoSocio", "Dui='" & Me.txtDuidG.Value & "'", "DUI", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then Me.txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub fgRefPer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgRefPer.DoubleClick
        If Me.fgRefPer.Row <> -1 Then
            Dim frm As frmMsCrRefPers = New frmMsCrRefPers
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pCorrelativo = Me.fgRefPer.Item(Me.fgRefPer.Row, "Correlativo")
            frm.pAccion = "Modificar"
            frm.btnGuardar1.Text = "&Consultar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGridRefPer()
        End If
    End Sub

    Private Sub ActualizaGridRefPer()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarRefPersonal("*", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgRefPer.DataSource = ds.Tables(0)
            Me.fgRefPer.Cols.Item(0).Caption = "Correlativo"
            Me.fgRefPer.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgRefPer.Cols.Item(2).Caption = "Nombre"
            Me.fgRefPer.Cols.Item(3).Caption = "Dirección"
            Me.fgRefPer.Cols.Item(4).Caption = "Teléfono de Casa"
            Me.fgRefPer.Cols.Item(5).Caption = "Lugar de Trabajo"
            Me.fgRefPer.Cols.Item(6).Caption = "Dirección Trabajo"
            Me.fgRefPer.Cols.Item(7).Caption = "Cargo"
            Me.fgRefPer.Cols.Item(8).Caption = "Tel. Oficina"
            Me.fgRefPer.Cols.Item(9).Caption = "Cód. Enlace"

            Me.fgRefPer.Cols.Item(0).Width = 77
            Me.fgRefPer.Cols.Item(1).Width = 77
            Me.fgRefPer.Cols.Item(2).Width = 150
            Me.fgRefPer.Cols.Item(3).Width = 200
            Me.fgRefPer.Cols.Item(4).Width = 77
            Me.fgRefPer.Cols.Item(5).Width = 150
            Me.fgRefPer.Cols.Item(6).Width = 200
            Me.fgRefPer.Cols.Item(7).Width = 100
            Me.fgRefPer.Cols.Item(8).Width = 77
            Me.fgRefPer.Cols.Item(9).Width = 77
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ActualizaGridRefCom()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarRefComercial("*", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgRefCom.DataSource = ds.Tables(0)
            Me.fgRefCom.Cols.Item(0).Caption = "Correlativo"
            Me.fgRefCom.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgRefCom.Cols.Item(2).Caption = "Nombre de Empresa"
            Me.fgRefCom.Cols.Item(3).Caption = "Nombre"
            Me.fgRefCom.Cols.Item(4).Caption = "Dirección"
            Me.fgRefCom.Cols.Item(5).Caption = "Teléfonos"
            Me.fgRefCom.Cols.Item(6).Caption = "Cód. Enlace"

            Me.fgRefCom.Cols.Item(0).Width = 77
            Me.fgRefCom.Cols.Item(1).Width = 77
            Me.fgRefCom.Cols.Item(2).Width = 150
            Me.fgRefCom.Cols.Item(3).Width = 150
            Me.fgRefCom.Cols.Item(4).Width = 200
            Me.fgRefCom.Cols.Item(5).Width = 100
            Me.fgRefCom.Cols.Item(6).Width = 77

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ActualizaGridRefBan()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarRefBancaria("*", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgRefBan.DataSource = ds.Tables(0)
            Me.fgRefBan.Cols.Item(0).Caption = "Correlativo"
            Me.fgRefBan.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgRefBan.Cols.Item(2).Caption = "Institución"
            Me.fgRefBan.Cols.Item(3).Caption = "Tipo de Cuenta"
            Me.fgRefBan.Cols.Item(4).Caption = "Fecha de Apertura"
            Me.fgRefBan.Cols.Item(5).Caption = "Saldo"
            Me.fgRefBan.Cols.Item(6).Caption = "Cód. Enlace"

            Me.fgRefBan.Cols.Item(0).Width = 77
            Me.fgRefBan.Cols.Item(1).Width = 77
            Me.fgRefBan.Cols.Item(2).Width = 150
            Me.fgRefBan.Cols.Item(3).Width = 100
            Me.fgRefBan.Cols.Item(4).Width = 77
            Me.fgRefBan.Cols.Item(5).Width = 77
            Me.fgRefBan.Cols.Item(6).Width = 77

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ActualizaGridVh()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarVehiculos("*", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgVehiculos.DataSource = ds.Tables(0)
            Me.fgVehiculos.Cols.Item(0).Caption = "Correlativo"
            Me.fgVehiculos.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgVehiculos.Cols.Item(2).Caption = "Tipo de Vehículo"
            Me.fgVehiculos.Cols.Item(3).Caption = "No. de Placa"
            Me.fgVehiculos.Cols.Item(4).Caption = "Valor"
            Me.fgVehiculos.Cols.Item(5).Caption = "Cód. Enlace"

            Me.fgVehiculos.Cols.Item(0).Width = 77
            Me.fgVehiculos.Cols.Item(1).Width = 77
            Me.fgVehiculos.Cols.Item(2).Width = 150
            Me.fgVehiculos.Cols.Item(3).Width = 77
            Me.fgVehiculos.Cols.Item(4).Width = 77
            Me.fgVehiculos.Cols.Item(5).Width = 77

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub fgRefCom_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgRefCom.DoubleClick
        Me.btEditRC1_Click(sender, e)
    End Sub



    Private Sub ActualizaGridBI()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarBienInmueble("*", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgBienes.DataSource = ds.Tables(0)
            Me.fgBienes.Cols.Item(0).Caption = "Correlativo"
            Me.fgBienes.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgBienes.Cols.Item(2).Caption = "Dirección"
            Me.fgBienes.Cols.Item(3).Caption = "Valor"
            Me.fgBienes.Cols.Item(4).Caption = "Hipotecado"
            Me.fgBienes.Cols.Item(5).Caption = "Cód. Enlace"

            Me.fgBienes.Cols.Item(0).Width = 77
            Me.fgBienes.Cols.Item(1).Width = 77
            Me.fgBienes.Cols.Item(2).Width = 150
            Me.fgBienes.Cols.Item(3).Width = 77
            Me.fgBienes.Cols.Item(4).Width = 77
            Me.fgBienes.Cols.Item(5).Width = 77

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub ActualizaGridIng()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarIngresos("*", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgIngresos.DataSource = ds.Tables(0)
            Me.fgIngresos.Cols.Item(0).Caption = "Correlativo"
            Me.fgIngresos.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgIngresos.Cols.Item(2).Caption = "Cód. Tipo Ingreso"
            Me.fgIngresos.Cols.Item(3).Caption = "Monto"
            Me.fgIngresos.Cols.Item(4).Caption = "Cód. Enlace"
            Me.fgIngresos.Cols.Item(5).Caption = "Verificado"
            Me.fgIngresos.Cols.Item(6).Caption = "Declara Renta"
            Me.fgIngresos.Cols.Item(7).Caption = "Constancia"
            Me.fgIngresos.Cols.Item(8).Caption = "Estados Financieros"
            Me.fgIngresos.Cols.Item(9).Caption = "Declaraciones IVA"
            Me.fgIngresos.Cols.Item(10).Caption = "Visita Campo"

            Me.fgIngresos.Cols.Item(0).Width = 77
            Me.fgIngresos.Cols.Item(1).Width = 77
            Me.fgIngresos.Cols.Item(2).Width = 77
            Me.fgIngresos.Cols.Item(3).Width = 77
            Me.fgIngresos.Cols.Item(4).Width = 77
            Me.fgIngresos.Cols.Item(5).Width = 77
            Me.fgIngresos.Cols.Item(6).Width = 77
            Me.fgIngresos.Cols.Item(7).Width = 77
            Me.fgIngresos.Cols.Item(8).Width = 77
            Me.fgIngresos.Cols.Item(9).Width = 77
            Me.fgIngresos.Cols.Item(10).Width = 77

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ActualizaGridGt()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGastos("*", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgGastos.DataSource = ds.Tables(0)
            Me.fgGastos.Cols.Item(0).Caption = "Correlativo"
            Me.fgGastos.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgGastos.Cols.Item(2).Caption = "Cód. Tipo de Gasto"
            Me.fgGastos.Cols.Item(3).Caption = "Monto"
            Me.fgGastos.Cols.Item(4).Caption = "Cód. Enlace"

            Me.fgGastos.Cols.Item(0).Width = 77
            Me.fgGastos.Cols.Item(1).Width = 77
            Me.fgGastos.Cols.Item(2).Width = 77
            Me.fgGastos.Cols.Item(3).Width = 77
            Me.fgGastos.Cols.Item(4).Width = 77

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub fgGastos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgGastos.DoubleClick
        Me.btEditGt1_Click(sender, e)
    End Sub

    Private Sub fgIngresos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgIngresos.DoubleClick
        Me.btEditIng1_Click(sender, e)
    End Sub

    Private Sub fgVehiculos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgVehiculos.DoubleClick
        Me.btEditVh1_Click(sender, e)
    End Sub



    Private Sub fgBienes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgBienes.DoubleClick
        Me.btEditRF1_Click(sender, e)
    End Sub


    Private Sub ActualizaGridOb()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarObligaciones("*", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgOblig.DataSource = ds.Tables(0)
            Me.fgOblig.Cols.Item(0).Caption = "Correlativo"
            Me.fgOblig.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgOblig.Cols.Item(2).Caption = "Nombre Acreedor"
            Me.fgOblig.Cols.Item(3).Caption = "Teléfono"
            Me.fgOblig.Cols.Item(4).Caption = "Monto"
            Me.fgOblig.Cols.Item(5).Caption = "Saldo"
            Me.fgOblig.Cols.Item(6).Caption = "Cuota"
            Me.fgOblig.Cols.Item(7).Caption = "Cód. Enlace"

            Me.fgOblig.Cols.Item(0).Width = 77
            Me.fgOblig.Cols.Item(1).Width = 77
            Me.fgOblig.Cols.Item(2).Width = 150
            Me.fgOblig.Cols.Item(3).Width = 77
            Me.fgOblig.Cols.Item(4).Width = 77
            Me.fgOblig.Cols.Item(5).Width = 77
            Me.fgOblig.Cols.Item(6).Width = 77
            Me.fgOblig.Cols.Item(7).Width = 77

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub fgOblig_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgOblig.DoubleClick
        Me.btEditOb1_Click(sender, e)
    End Sub






    Private Sub ActualizaGridRefFam()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarRefFamiliar("*", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgRefFam.DataSource = ds.Tables(0)
            Me.fgRefFam.Cols.Item(0).Caption = "Correlativo"
            Me.fgRefFam.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgRefFam.Cols.Item(2).Caption = "Nombre"
            Me.fgRefFam.Cols.Item(3).Caption = "Dirección"
            Me.fgRefFam.Cols.Item(4).Caption = "Teléfono de Casa"
            Me.fgRefFam.Cols.Item(5).Caption = "Lugar de Trabajo"
            Me.fgRefFam.Cols.Item(6).Caption = "Dirección Trabajo"
            Me.fgRefFam.Cols.Item(7).Caption = "Cargo"
            Me.fgRefFam.Cols.Item(8).Caption = "Tel. Oficina"
            Me.fgRefFam.Cols.Item(9).Caption = "Cód. Enlace"

            Me.fgRefFam.Cols.Item(0).Width = 77
            Me.fgRefFam.Cols.Item(1).Width = 77
            Me.fgRefFam.Cols.Item(2).Width = 150
            Me.fgRefFam.Cols.Item(3).Width = 200
            Me.fgRefFam.Cols.Item(4).Width = 77
            Me.fgRefFam.Cols.Item(5).Width = 100
            Me.fgRefFam.Cols.Item(6).Width = 200
            Me.fgRefFam.Cols.Item(7).Width = 100
            Me.fgRefFam.Cols.Item(8).Width = 77
            Me.fgRefFam.Cols.Item(9).Width = 77
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub fgRefFam_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgRefFam.DoubleClick
        If Me.fgRefFam.Row <> -1 Then
            Dim frm As frmMsCrRefFam = New frmMsCrRefFam
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pCorrelativo = Me.fgRefFam.Item(Me.fgRefFam.Row, "Correlativo")
            frm.pAccion = "Modificar"
            frm.btnGuardar1.Text = "&Consultar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGridRefFam()
        End If
    End Sub

    Private Sub ControlTab(ByVal pValor As Boolean, ByVal pTb As Boolean)
        Me.tbSolic.TabPages(0).Enabled = pTb
        Me.tbSolic.TabPages(1).Enabled = pTb
        Me.tbSolic.TabPages(2).Enabled = pTb
        Me.tbSolic.TabPages(3).Enabled = pValor
        Me.tbSolic.TabPages(4).Enabled = pValor
        Me.tbSolic.TabPages(5).Enabled = pValor
        Me.tbSolic.TabPages(6).Enabled = pValor
        Me.tbSolic.TabPages(7).Enabled = pValor
    End Sub


    Private Sub btnSigTb1_1_Click(sender As Object, e As EventArgs) Handles btnSigTb1_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex() + 1
    End Sub

    Private Sub btnSaveTb1_1_Click(sender As Object, e As EventArgs) Handles btnSaveTb1_1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Me.txtNombresdG.Text, Me.txtApe1dG.Text, "x", Me.txtDuidG.Value, "x")
                Case 1
                    MsgBox("El Nombre no puede quedar vacío. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 2
                    MsgBox("El primer Apellido no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 4
                    MsgBox("El Dui no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If Me.btnSaveTb1_1.Text = "&Guardar" Then

                pCodEnlace = oCred.ObtenerCorrelativoDatGral("CodEnlace", sUsuario, sPassword, sSucursal)
                pCampos = "CodEnlace,NumSolicitud,NoSocio,Fiador,FiadorDescartado,MotivoDescartado,Nombres,Apellido1,Apellido2,Apellido3,FechaNac,Direccion,TelCasa,Celular,CasaPropia,PropietarioCasa,DUI,NIT,ISSS,FechaExtenDUI,LugarTrabajo,FechaInicioTrabajo,TelOficina,ExtensionOfic,DireccionTrabajo,Sueldo,FormaPago,FechaPagoSueldo,Cargo,CodProfesion,TrabajoAnterior,CargoTrabajoAnterior,CausaRetiro,FechaCargoDesde,FechaCargoHasta,SueldoTrabajoAnterior,NombreConyugue,Apellido1Conyugue,Apellido2Conyugue,Apellido3Conyugue,SueldoConyugue,LugarTrabConyugue,FechaDesdeTrabConyugue,TelTrabajoConyugue,NumGrupoFamiliar,DirecciondeFamiliar,DepartamentoTrabajo"

                pValores = "" & pCodEnlace & "," & pNumSolicitud & ",'" & Trim(Me.txtNoSocio.Text) & "','" & vFiador & "','" & IIf(Me.chkFiadorDesc.Checked = True, "1", "0") & "','" & Trim(Me.txtMotivoDesc.Text) & "','" & Trim(Me.txtNombresdG.Text) & "','" & Trim(Me.txtApe1dG.Text) & "','" & Trim(Me.txtApe2dG.Text) & "','" & Trim(Me.txtApe3dG.Text) & "','" & Format(Me.dtpFecNac.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtDireccion.Text) & "','" & Trim(Me.txtTelCasa.Text) & "','" & Trim(Me.txtCel.Text) & "','" & IIf(Me.chkCasaPropia.Checked = True, "1", "0") & "','" & Trim(Me.txtPropCasa.Text) & "','" & Trim(Me.txtDuidG.Text) & "','" & Trim(Me.txtNit.Text) & "','" & Trim(Me.txtIsss.Text) & "','" & Format(Me.dtpFecExtDui.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtLugTrabdG.Text) & "','" & Format(Me.dtpFecIniTrab.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtTelOficdG.Text) & "','" & Trim(Me.txtExtOficdG.Text) & "','" & Trim(Me.txtDirTrabdG.Text) & "'," & Val(Me.txtSalario.Value) & ",'" & Trim(Me.txtFormaPago.Text) & "','" & Format(Me.dtpFecPago.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtCargo.Text) & "','" & Trim(Me.txtCodProfdG.Text) & "','" & Trim(Me.txtTrabAnt.Text) & "','" & Trim(Me.txtCargoAnt.Text) & "','" & Trim(Me.txtCausaRetiro.Text) & "','" & Format(Me.dtpFecCargoDesde.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecCargoHasta.Value, "dd/MM/yyyy") & "'," & Val(txtSalAnt.Value) & ",'" & Trim(Me.txtConyugue.Text) & "','" & Trim(Me.txtApe1Cy.Text) & "','" & Trim(Me.txtApe2Cy.Text) & "','" & Trim(Me.txtApe3Cy.Text) & "'," & Val(Me.txtSalarioC.Value) & ",'" & Trim(Me.txtLugTrabCy.Text) & "','" & Format(Me.dtpFecIniTrabCy.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtTelTrabCy.Text) & "'," & Me.nuDGrupoFam.Value & ",'" & Trim(Me.txtDirFam.Text) & "','" & Me.txtDptoTrabajo.Text.Trim & "'"
                If oCred.InsertarDatGral(pCampos, pValores, sUsuario, sPassword, sSucursal) = False Then
                    MsgBox("Los datos del Fiador NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                Else
                    Me.ControlTab(True, True)
                    Me.btnSaveTb1_1.Text = "&Modificar"
                    Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
                End If

            ElseIf Me.btnSaveTb1_1.Text = "&Modificar" Then

                pCampos = "Fiador='" & vFiador & "',FiadorDescartado='" & IIf(Me.chkFiadorDesc.Checked = True, "1", "0") & "',MotivoDescartado='" & Trim(Me.txtMotivoDesc.Text) & "',Nombres='" & Trim(Me.txtNombresdG.Text) & "',Apellido1='" & Trim(Me.txtApe1dG.Text) & "',Apellido2='" & Trim(Me.txtApe2dG.Text) & "',Apellido3='" & Trim(Me.txtApe3dG.Text) & "',FechaNac='" & Format(Me.dtpFecNac.Value, "dd/MM/yyyy") & "',Direccion='" & Trim(Me.txtDireccion.Text) & "',TelCasa='" & Trim(Me.txtTelCasa.Text) & "',Celular='" & Trim(Me.txtCel.Text) & "',CasaPropia='" & IIf(Me.chkCasaPropia.Checked = True, "1", "0") & "',PropietarioCasa='" & Trim(Me.txtPropCasa.Text) & "',DUI='" & Trim(Me.txtDuidG.Text) & "',NIT='" & Trim(Me.txtNit.Text) & "',ISSS='" & Trim(Me.txtIsss.Text) & "',FechaExtenDui='" & Format(Me.dtpFecExtDui.Value, "dd/MM/yyyy") & "',LugarTrabajo='" & Trim(Me.txtLugTrabdG.Text) & "',FechaInicioTrabajo='" & Format(Me.dtpFecIniTrab.Value, "dd/MM/yyyy") & "',TelOficina='" & Trim(Me.txtTelOficdG.Text) & "',ExtensionOfic='" & Trim(Me.txtExtOficdG.Text) & "',DireccionTrabajo='" & Trim(Me.txtDirTrabdG.Text) & "',Sueldo=" & Val(Me.txtSalario.Value) & ",FormaPago='" & Trim(Me.txtFormaPago.Text) & "',FechaPagoSueldo='" & Format(Me.dtpFecPago.Value, "dd/MM/yyyy") & "',Cargo='" & Trim(Me.txtCargo.Text) & "',CodProfesion='" & Trim(Me.txtCodProfdG.Text) & "',TrabajoAnterior='" & Trim(Me.txtTrabAnt.Text) & "',CargoTrabajoAnterior='" & Trim(Me.txtCargoAnt.Text) & "',CausaRetiro='" & Trim(Me.txtCausaRetiro.Text) & "',FechaCargoDesde='" & Format(Me.dtpFecCargoDesde.Value, "dd/MM/yyyy") & "',FechaCargoHasta='" & Format(Me.dtpFecCargoHasta.Value, "dd/MM/yyyy") & "',SueldoTrabajoAnterior=" & Val(Me.txtSalAnt.Value) & ",NombreConyugue='" & Trim(Me.txtConyugue.Text) & "',Apellido1Conyugue='" & Trim(Me.txtApe1Cy.Text) & "',Apellido2Conyugue='" & Trim(Me.txtApe2Cy.Text) & "',Apellido3Conyugue='" & Trim(Me.txtApe3Cy.Text) & "',SueldoConyugue=" & Val(Me.txtSalarioC.Value) & ",LugarTrabConyugue='" & Trim(Me.txtLugTrabCy.Text) & "',FechaDesdeTrabConyugue='" & Format(Me.dtpFecIniTrabCy.Value, "dd/MM/yyyy") & "',TelTrabajoConyugue='" & Trim(Me.txtTelTrabCy.Text) & "',NumGrupoFamiliar=" & Me.nuDGrupoFam.Value & ",DirecciondeFamiliar='" & Trim(Me.txtDirFam.Text) & "',DepartamentoTrabajo='" & Me.txtDptoTrabajo.Text.Trim & "'"
                If oCred.ModificarDatGral(pCodEnlace, pCampos, sUsuario, sPassword, sSucursal) = False Then

                    MsgBox("Los datos del Fiador no han sido modificados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If

            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAtrasTb2_1_Click(sender As Object, e As EventArgs) Handles btnAtrasTb2_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub btnSigTb2_1_Click(sender As Object, e As EventArgs) Handles btnSigTb2_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex() + 1
    End Sub

    Private Sub btnSaveTb2_1_Click(sender As Object, e As EventArgs) Handles btnSaveTb2_1.Click
        Me.btnSaveTb1_1_Click(sender, e)
    End Sub

    Private Sub btnAtrasTb3_1_Click(sender As Object, e As EventArgs) Handles btnAtrasTb3_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub btnSigTb3_1_Click(sender As Object, e As EventArgs) Handles btnSigTb3_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub btnSaveTb3_1_Click(sender As Object, e As EventArgs) Handles btnSaveTb3_1.Click
        Me.btnSaveTb1_1_Click(sender, e)
    End Sub

    Private Sub btNewRF1_Click(sender As Object, e As EventArgs) Handles btNewRF1.Click
        Try
            Dim frm As frmMsCrRefFam = New frmMsCrRefFam
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridRefFam()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditRF1_Click(sender As Object, e As EventArgs) Handles btEditRF1.Click
        Try
            If Me.fgRefFam.Row <> -1 Then
                Dim frm As frmMsCrRefFam = New frmMsCrRefFam
                frm.pNoSolic = Me.pNumSolicitud
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCorrelativo = Me.fgRefFam.Item(Me.fgRefFam.Row, "Correlativo")
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridRefFam()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelRF1_Click(sender As Object, e As EventArgs) Handles btDelRF1.Click
        Try
            If Me.fgRefFam.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Referencia Familiar No. " & Me.fgRefFam.Item(Me.fgRefFam.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Referencia Familiar") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarRefFamiliar("" & Me.fgRefFam.Item(Me.fgRefFam.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridRefFam()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewRP1_Click(sender As Object, e As EventArgs) Handles btNewRP1.Click
        Try
            Dim frm As frmMsCrRefPers = New frmMsCrRefPers
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridRefPer()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditRP1_Click(sender As Object, e As EventArgs) Handles btEditRP1.Click
        Try
            If Me.fgRefPer.Row <> -1 Then
                Dim frm As frmMsCrRefPers = New frmMsCrRefPers
                frm.pNoSolic = Me.pNumSolicitud
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCorrelativo = Me.fgRefPer.Item(Me.fgRefPer.Row, "Correlativo")
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridRefPer()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelRP1_Click(sender As Object, e As EventArgs) Handles btDelRP1.Click
        Try
            If Me.fgRefPer.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Referencia Personal No. " & Me.fgRefPer.Item(Me.fgRefPer.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Referencia Personal") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarRefPersonal("" & Me.fgRefPer.Item(Me.fgRefPer.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridRefPer()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAtrasTab7_1_Click(sender As Object, e As EventArgs) Handles btnAtrasTab7_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub btnSigTab7_1_Click(sender As Object, e As EventArgs) Handles btnSigTab7_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub btNewRC1_Click(sender As Object, e As EventArgs) Handles btNewRC1.Click
        Try
            Dim frm As frmMsCrRefCom = New frmMsCrRefCom
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridRefCom()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditRC1_Click(sender As Object, e As EventArgs) Handles btEditRC1.Click
        Try
            If Me.fgRefCom.Row <> -1 Then
                Dim frm As frmMsCrRefCom = New frmMsCrRefCom
                frm.pNoSolic = Me.pNumSolicitud
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCorrelativo = Me.fgRefCom.Item(Me.fgRefCom.Row, "Correlativo")
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridRefCom()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelRC1_Click(sender As Object, e As EventArgs) Handles btDelRC1.Click
        Try
            If Me.fgRefCom.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Referencia Comercial No. " & Me.fgRefCom.Item(Me.fgRefCom.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Referencia Comercial") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarRefComercial("" & Me.fgRefCom.Item(Me.fgRefCom.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridRefCom()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewRB1_Click(sender As Object, e As EventArgs) Handles btNewRB1.Click
        Try
            Dim frm As frmMsCrRefBan = New frmMsCrRefBan
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridRefBan()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditRB1_Click(sender As Object, e As EventArgs) Handles btEditRB1.Click
        Try
            If Me.fgRefBan.Row <> -1 Then
                Dim frm As frmMsCrRefBan = New frmMsCrRefBan
                frm.pNoSolic = Me.pNumSolicitud
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCorrelativo = Me.fgRefBan.Item(Me.fgRefBan.Row, "Correlativo")
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridRefBan()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelRB1_Click(sender As Object, e As EventArgs) Handles btDelRB1.Click
        Try
            If Me.fgRefBan.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Referencia Bancaria No. " & Me.fgRefBan.Item(Me.fgRefBan.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Referencia Bancaria") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarRefBancaria("" & Me.fgRefBan.Item(Me.fgRefBan.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridRefBan()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub btNewGt1_Click(sender As Object, e As EventArgs) Handles btNewGt1.Click
        Try
            Dim frm As frmMsCrGastos = New frmMsCrGastos
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridGt()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewIng1_Click(sender As Object, e As EventArgs) Handles btNewIng1.Click
        Try
            Dim frm As frmMsCrIngresos = New frmMsCrIngresos
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridIng()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditIng1_Click(sender As Object, e As EventArgs) Handles btEditIng1.Click
        Try
            If Me.fgIngresos.Row <> -1 Then
                Dim frm As frmMsCrIngresos = New frmMsCrIngresos
                frm.pNoSolic = Me.pNumSolicitud
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCorrelativo = Me.fgIngresos.Item(Me.fgIngresos.Row, "Correlativo")
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridIng()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelIng1_Click(sender As Object, e As EventArgs) Handles btDelIng1.Click
        Try
            If Me.fgIngresos.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Ingreso No. " & Me.fgIngresos.Item(Me.fgIngresos.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Ingresos") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarIngresos("" & Me.fgIngresos.Item(Me.fgIngresos.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridIng()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditGt1_Click(sender As Object, e As EventArgs) Handles btEditGt1.Click
        Try
            If Me.fgGastos.Row <> -1 Then
                Dim frm As frmMsCrGastos = New frmMsCrGastos
                frm.pNoSolic = Me.pNumSolicitud
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCorrelativo = Me.fgGastos.Item(Me.fgGastos.Row, "Correlativo")
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridIng()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelGt1_Click(sender As Object, e As EventArgs) Handles btDelGt1.Click
        Try
            If Me.fgGastos.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Gasto No. " & Me.fgGastos.Item(Me.fgGastos.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Gastos") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarGastos("" & Me.fgGastos.Item(Me.fgGastos.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridGt()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewBI1_Click(sender As Object, e As EventArgs) Handles btNewBI1.Click
        Dim frm As frmMsCrBienInmueble = New frmMsCrBienInmueble
        frm.pNoSolic = Me.pNumSolicitud
        frm.pCodEnlace = Me.pCodEnlace
        frm.pAccion = "Guardar"
        frm.btnGuardar1.Text = "&Guardar"
        frm.ShowDialog()
        ActualizaGridBI()
    End Sub

    Private Sub btEditBI1_Click(sender As Object, e As EventArgs) Handles btEditBI1.Click
        Try
            If Me.fgBienes.Row <> -1 Then
                Dim frm As frmMsCrBienInmueble = New frmMsCrBienInmueble
                frm.pNoSolic = Me.pNumSolicitud
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCorrelativo = Me.fgBienes.Item(Me.fgBienes.Row, "Correlativo")
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridBI()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelBI1_Click(sender As Object, e As EventArgs) Handles btDelBI1.Click
        Try
            If Me.fgBienes.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Bien Inmueble No. " & Me.fgBienes.Item(Me.fgBienes.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Bien Inmueble") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarBienInmueble("" & Me.fgBienes.Item(Me.fgBienes.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridBI()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewVh1_Click(sender As Object, e As EventArgs) Handles btNewVh1.Click
        Try
            Dim frm As frmMsCrVehiculos = New frmMsCrVehiculos
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridVh()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditVh1_Click(sender As Object, e As EventArgs) Handles btEditVh1.Click
        Try

            If Me.fgVehiculos.Row <> -1 Then
                Dim frm As frmMsCrVehiculos = New frmMsCrVehiculos
                frm.pNoSolic = Me.pNumSolicitud
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCorrelativo = Me.fgVehiculos.Item(Me.fgVehiculos.Row, "Correlativo")
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridIng()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelVh1_Click(sender As Object, e As EventArgs) Handles btDelVh1.Click
        Try
            If Me.fgVehiculos.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Vehículo No. " & Me.fgVehiculos.Item(Me.fgVehiculos.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Vehículos") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarVehiculos("" & Me.fgVehiculos.Item(Me.fgVehiculos.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridVh()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewOb1_Click(sender As Object, e As EventArgs) Handles btNewOb1.Click
        Try
            Dim frm As frmMsCrObligaciones = New frmMsCrObligaciones
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridOb()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditOb1_Click(sender As Object, e As EventArgs) Handles btEditOb1.Click
        Try
            If Me.fgOblig.Row <> -1 Then
                Dim frm As frmMsCrObligaciones = New frmMsCrObligaciones
                frm.pNoSolic = Me.pNumSolicitud
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCorrelativo = Me.fgOblig.Item(Me.fgOblig.Row, "Correlativo")
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridOb()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelOb1_Click(sender As Object, e As EventArgs) Handles btDelOb1.Click
        Try
            If Me.fgOblig.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Obligación No. " & Me.fgOblig.Item(Me.fgOblig.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Obligaciones") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarObligaciones("" & Me.fgOblig.Item(Me.fgOblig.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridOb()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs)
        Dim frm As New frmVisorRS
        OpcionRS = 100
        With frm
            .dui = txtDuidG.Value.ToString
            .Show()
        End With
    End Sub

    Private Sub fgRefBan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgRefBan.DoubleClick
        Me.btEditRB1_Click(sender, e)
    End Sub

    Private Sub txtDuidG_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuidG.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDuidG.ValueIsDbNull, "", txtDuidG.Value)
            If Valor.Trim = "" Then
                Me.txtDuidG.SelectionStart = 0
                Me.txtDuidG.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDuidG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDuidG.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDuidG_LostFocus(sender, e)
    End Sub

    Private Sub txtDuidG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuidG.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Correlativo,NoSocio,Apellido1,Apellido2,Nombres", "EstadoIngreso='2'", "Correlativo", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("*", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))


                    Me.txtDuidG.Value = dr("Dui")
                    Me.txtNit.Value = IIf(IsDBNull(dr("Nit")), "", dr("Nit"))
                    Me.dtpFecExtDui.Value = IIf(IsDBNull(dr("FechaExtDUI")), Now, dr("FechaExtDUI"))
                    Me.txtIsss.Text = IIf(IsDBNull(dr("Isss")), "", dr("Isss"))
                    Me.dtpFecNac.Value = IIf(IsDBNull(dr("Fecha_Nac")), Now, dr("Fecha_Nac"))
                    Me.txtNombresdG.Text = IIf(IsDBNull(dr("Nombres")), "", dr("Nombres"))
                    Me.txtApe1dG.Text = IIf(IsDBNull(dr("Apellido1")), "", dr("Apellido1"))
                    Me.txtApe2dG.Text = IIf(IsDBNull(dr("Apellido2")), "", dr("Apellido2"))
                    Me.txtApe3dG.Text = IIf(IsDBNull(dr("ApellidoCas")), "", dr("ApellidoCas"))
                    Me.txtTelCasa.Text = IIf(IsDBNull(dr("TelCasa")), "", dr("TelCasa"))
                    Me.txtDireccion.Text = IIf(IsDBNull(dr("Direccion")), "", dr("Direccion"))
                    Me.txtCel.Text = IIf(IsDBNull(dr("Celular")), "", dr("Celular"))

                    Me.txtLugTrabdG.Text = IIf(IsDBNull(dr("LugarTrabajo")), "", dr("LugarTrabajo"))
                    Me.dtpFecIniTrab.Value = IIf(IsDBNull(dr("FechaInicioTrab")), Now, dr("FechaInicioTrab"))
                    Me.txtDirTrabdG.Text = IIf(IsDBNull(dr("DireccionTrabajo")), "", dr("DireccionTrabajo"))
                    Me.txtSalario.Value = IIf(IsDBNull(dr("Salario")), 0, dr("Salario"))
                    Me.txtTelOficdG.Text = IIf(IsDBNull(dr("TelOficina")), "", dr("TelOficina"))
                    Me.txtExtOficdG.Text = IIf(IsDBNull(dr("ExtensionOfic")), "", dr("ExtensionOfic"))
                    Me.txtCargo.Text = IIf(IsDBNull(dr("Cargo")), "", dr("Cargo"))
                    Me.txtCodProfdG.Text = IIf(IsDBNull(dr("CodProfesion")), "", dr("CodProfesion"))
                    Me.txtConyugue.Text = Mid(IIf(IsDBNull(dr("NombreConyugue")), "", dr("NombreConyugue")), 1, 50)
                    Me.nuDGrupoFam.Value = IIf(IsDBNull(dr("NumGrupoFam")), 0, dr("NumGrupoFam"))
                    Me.txtDptoTrabajo.Text = IIf(IsDBNull(dr("DepartamentoTrabajo")), "", dr("DepartamentoTrabajo"))
                    If Me.txtCodProfdG.Text.Trim <> "" Then
                        ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtCodProfdG.Text) & "'", "", sUsuario, sPassword, sSucursal)
                        If ds.Tables(0).Rows.Count > 0 Then
                            dr = ds.Tables(0).Rows(0)
                            If Not (dr("Descripcion") Is DBNull.Value) Then
                                Me.txtProfdG.Text = CStr(dr("Descripcion"))
                            End If
                        End If
                    End If


                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
