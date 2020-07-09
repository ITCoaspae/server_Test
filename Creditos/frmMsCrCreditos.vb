Public Class frmMsCrCreditos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblPag As System.Windows.Forms.Label
    Dim Creditos As New wrCredito.wsLibCred
    Dim clientes As New wrAsociados.wsLibAsoc

    Friend WithEvents txtTasaMora As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label87 As Label
    Friend WithEvents btTasaPactada1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditRF1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelRF1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewRF1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditRP1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelRP1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewRP1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditGt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelGt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewGt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditIng1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelIng1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewIng1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditOA1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelOA1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewOA1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditOb1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelOb1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewOb1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditRB1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelRB1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewRB1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditRC1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelRC1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewRC1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditCd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelCd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewCd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditFd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelFd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewFd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditGr1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelGr1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewGr1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditVh1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelVh1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewVh1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditBI1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelBI1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewBI1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb9_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTab9_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btConsultaGarantiasInt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTab9_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb11_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTab11_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton22 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb7_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton24 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTab10_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb10_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTab10_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTab8_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb8_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTab8_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTab6_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb61 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTab6_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTb5_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb5_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTb5_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTb1_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb1_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton12 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTb2_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb2_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTb2_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label80 As Label
    Friend WithEvents txtNoSocio As TextBox
    Friend WithEvents txtCodProfdG As TextBox
    Friend WithEvents txtProfdG As TextBox
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGenerarCuota As MetroFramework.Controls.MetroButton
    Friend WithEvents txtCodTipoCredP2 As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnSolCredito As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Dim prestamos As New wrPrestamo.wsLibPrest

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) '' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbSolic As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents tbEntrega As System.Windows.Forms.TabPage
    Friend WithEvents tbRefFam As System.Windows.Forms.TabPage
    Friend WithEvents tbRefPers As System.Windows.Forms.TabPage
    Friend WithEvents tbRecibido As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecRec As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecConc As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbDatGralIII As System.Windows.Forms.TabPage
    Friend WithEvents txtTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents dtpFecEnt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombresE As System.Windows.Forms.TextBox
    Friend WithEvents txtApe3E As System.Windows.Forms.TextBox
    Friend WithEvents txtApe1E As System.Windows.Forms.TextBox
    Friend WithEvents txtTelOficE As System.Windows.Forms.TextBox
    Friend WithEvents txtDuiE As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtLugTrabE As System.Windows.Forms.TextBox
    Friend WithEvents txtDirE As System.Windows.Forms.TextBox
    Friend WithEvents txtApe2E As System.Windows.Forms.TextBox
    Friend WithEvents txtEjecMercadeoE As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecMercadeoE As System.Windows.Forms.TextBox
    Friend WithEvents txtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodSuc As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSolic As System.Windows.Forms.TextBox
    Friend WithEvents chkRecibida As System.Windows.Forms.CheckBox
    Friend WithEvents txtEjecMercR As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecMercR As System.Windows.Forms.TextBox
    Friend WithEvents tbIngGas As System.Windows.Forms.TabPage
    Friend WithEvents tbBienesVehiculos As System.Windows.Forms.TabPage
    Friend WithEvents tbObligObs As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents fgRefFam As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgRefPer As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgRefBan As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgRefCom As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgGastos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgIngresos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents fgBienes As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents fgVehiculos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents fgOblig As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents fgObsxAnal As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents C1NEPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtDestinoP2 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCredP2 As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents tbGarantias As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents fgGr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents fgFd As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents fgCd As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtTelCasaE As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalIng As System.Windows.Forms.Label
    Friend WithEvents cbFormaPagoP2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents c1nCuota As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCodPagaduria As System.Windows.Forms.TextBox
    Friend WithEvents txtPagaduria As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecAp As System.Windows.Forms.TextBox
    Friend WithEvents txtNomCodEjecAp As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents txtNitE As C1.Win.C1Input.C1TextBox
    Friend WithEvents chkAsociado As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents txtPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtTasaInteres As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoSolicitado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cbEstadoCivilE As System.Windows.Forms.ComboBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtIntMora As System.Windows.Forms.TextBox
    Friend WithEvents txtGeneraReserva As System.Windows.Forms.TextBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents txtDiaPago As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents c1nTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents c1nTasaDPF As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCrCreditos))
        Me.tbSolic = New System.Windows.Forms.TabControl()
        Me.tbEntrega = New System.Windows.Forms.TabPage()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.txtTelOficE = New System.Windows.Forms.TextBox()
        Me.txtPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.btnSigTb1_1 = New MetroFramework.Controls.MetroButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkAsociado = New System.Windows.Forms.CheckBox()
        Me.txtTasaInteres = New System.Windows.Forms.TextBox()
        Me.dtpFecEnt = New System.Windows.Forms.DateTimePicker()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.txtEjecMercadeoE = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMontoSolicitado = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txtCodTipoCredito = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodEjecMercadeoE = New System.Windows.Forms.TextBox()
        Me.txtDuiE = New C1.Win.C1Input.C1TextBox()
        Me.txtLugTrabE = New System.Windows.Forms.TextBox()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
        Me.txtNitE = New C1.Win.C1Input.C1TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnSaveTb1_1 = New MetroFramework.Controls.MetroButton()
        Me.txtDirE = New System.Windows.Forms.TextBox()
        Me.MetroButton12 = New MetroFramework.Controls.MetroButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtNombresE = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelCasaE = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtApe1E = New System.Windows.Forms.TextBox()
        Me.txtApe2E = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbEstadoCivilE = New System.Windows.Forms.ComboBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtApe3E = New System.Windows.Forms.TextBox()
        Me.tbRecibido = New System.Windows.Forms.TabPage()
        Me.btnSigTb2_1 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb2_1 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTb2_1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.dtpFecConc = New System.Windows.Forms.DateTimePicker()
        Me.cbConclusion = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txtCodEjecAp = New System.Windows.Forms.TextBox()
        Me.txtNoSolic = New System.Windows.Forms.TextBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkRecibida = New System.Windows.Forms.CheckBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txtNomCodEjecAp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecRec = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCodSuc = New System.Windows.Forms.TextBox()
        Me.txtEjecMercR = New System.Windows.Forms.TextBox()
        Me.txtCodEjecMercR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbDatGralIII = New System.Windows.Forms.TabPage()
        Me.btnSigTb5_1 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb5_1 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTb5_1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.btnGenerarCuota = New MetroFramework.Controls.MetroButton()
        Me.btTasaPactada1 = New MetroFramework.Controls.MetroButton()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.txtTasaMora = New C1.Win.C1Input.C1NumericEdit()
        Me.lblPag = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.c1nTasaDPF = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCuota = New C1.Win.C1Input.C1NumericEdit()
        Me.txtPagaduria = New System.Windows.Forms.TextBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.txtCodPagaduria = New System.Windows.Forms.TextBox()
        Me.txtDiaPago = New C1.Win.C1Input.C1TextBox()
        Me.cbFormaPagoP2 = New System.Windows.Forms.ComboBox()
        Me.txtTipoCredP2 = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.c1nTasa = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NEPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.txtCodTipoCredP2 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtDestinoP2 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbRefFam = New System.Windows.Forms.TabPage()
        Me.btnSigTab6_1 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb61 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTab6_1 = New MetroFramework.Controls.MetroButton()
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
        Me.tbIngGas = New System.Windows.Forms.TabPage()
        Me.btnSigTab8_1 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb8_1 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTab8_1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.btEditGt1 = New MetroFramework.Controls.MetroButton()
        Me.btDelGt1 = New MetroFramework.Controls.MetroButton()
        Me.btNewGt1 = New MetroFramework.Controls.MetroButton()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.fgGastos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.btEditIng1 = New MetroFramework.Controls.MetroButton()
        Me.btDelIng1 = New MetroFramework.Controls.MetroButton()
        Me.btNewIng1 = New MetroFramework.Controls.MetroButton()
        Me.lblTotalIng = New System.Windows.Forms.Label()
        Me.fgIngresos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbObligObs = New System.Windows.Forms.TabPage()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnSigTab10_1 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb10_1 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTab10_1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.btEditOA1 = New MetroFramework.Controls.MetroButton()
        Me.btDelOA1 = New MetroFramework.Controls.MetroButton()
        Me.btNewOA1 = New MetroFramework.Controls.MetroButton()
        Me.fgObsxAnal = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.btEditOb1 = New MetroFramework.Controls.MetroButton()
        Me.btDelOb1 = New MetroFramework.Controls.MetroButton()
        Me.btNewOb1 = New MetroFramework.Controls.MetroButton()
        Me.fgOblig = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbRefPers = New System.Windows.Forms.TabPage()
        Me.MetroButton22 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb7_1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton24 = New MetroFramework.Controls.MetroButton()
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
        Me.tbGarantias = New System.Windows.Forms.TabPage()
        Me.btnSolCredito = New MetroFramework.Controls.MetroButton()
        Me.btnSigTab9_1 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb11_1 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTab11_1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.btEditCd1 = New MetroFramework.Controls.MetroButton()
        Me.btDelCd1 = New MetroFramework.Controls.MetroButton()
        Me.btNewCd1 = New MetroFramework.Controls.MetroButton()
        Me.fgCd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.btEditFd1 = New MetroFramework.Controls.MetroButton()
        Me.btDelFd1 = New MetroFramework.Controls.MetroButton()
        Me.btNewFd1 = New MetroFramework.Controls.MetroButton()
        Me.fgFd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.btConsultaGarantiasInt1 = New MetroFramework.Controls.MetroButton()
        Me.btEditGr1 = New MetroFramework.Controls.MetroButton()
        Me.btDelGr1 = New MetroFramework.Controls.MetroButton()
        Me.btNewGr1 = New MetroFramework.Controls.MetroButton()
        Me.fgGr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbBienesVehiculos = New System.Windows.Forms.TabPage()
        Me.btnSaveTb9_1 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTab9_1 = New MetroFramework.Controls.MetroButton()
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
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtGeneraReserva = New System.Windows.Forms.TextBox()
        Me.txtIntMora = New System.Windows.Forms.TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.txtCodProfdG = New System.Windows.Forms.TextBox()
        Me.txtProfdG = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tbSolic.SuspendLayout()
        Me.tbEntrega.SuspendLayout()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoSolicitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuiE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNitE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRecibido.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbDatGralIII.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.txtTasaMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTasaDPF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRefFam.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.fgRefFam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.fgRefPer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbIngGas.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.fgGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        CType(Me.fgIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbObligObs.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.fgObsxAnal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        CType(Me.fgOblig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRefPers.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.fgRefBan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.fgRefCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbGarantias.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        CType(Me.fgCd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox19.SuspendLayout()
        CType(Me.fgFd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox18.SuspendLayout()
        CType(Me.fgGr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBienesVehiculos.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.fgVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        CType(Me.fgBienes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSolic
        '
        Me.tbSolic.Controls.Add(Me.tbEntrega)
        Me.tbSolic.Controls.Add(Me.tbRecibido)
        Me.tbSolic.Controls.Add(Me.tbDatGralIII)
        Me.tbSolic.Controls.Add(Me.tbRefFam)
        Me.tbSolic.Controls.Add(Me.tbIngGas)
        Me.tbSolic.Controls.Add(Me.tbObligObs)
        Me.tbSolic.Controls.Add(Me.tbRefPers)
        Me.tbSolic.Controls.Add(Me.tbGarantias)
        Me.tbSolic.Controls.Add(Me.tbBienesVehiculos)
        Me.tbSolic.ItemSize = New System.Drawing.Size(300, 18)
        Me.tbSolic.Location = New System.Drawing.Point(28, 73)
        Me.tbSolic.Multiline = True
        Me.tbSolic.Name = "tbSolic"
        Me.tbSolic.SelectedIndex = 0
        Me.tbSolic.Size = New System.Drawing.Size(916, 532)
        Me.tbSolic.TabIndex = 0
        '
        'tbEntrega
        '
        Me.tbEntrega.BackColor = System.Drawing.Color.White
        Me.tbEntrega.Controls.Add(Me.MetroButton7)
        Me.tbEntrega.Controls.Add(Me.txtTelOficE)
        Me.tbEntrega.Controls.Add(Me.txtPlazo)
        Me.tbEntrega.Controls.Add(Me.btnSigTb1_1)
        Me.tbEntrega.Controls.Add(Me.Label19)
        Me.tbEntrega.Controls.Add(Me.chkAsociado)
        Me.tbEntrega.Controls.Add(Me.txtTasaInteres)
        Me.tbEntrega.Controls.Add(Me.dtpFecEnt)
        Me.tbEntrega.Controls.Add(Me.Label83)
        Me.tbEntrega.Controls.Add(Me.Label46)
        Me.tbEntrega.Controls.Add(Me.txtDestino)
        Me.tbEntrega.Controls.Add(Me.txtEjecMercadeoE)
        Me.tbEntrega.Controls.Add(Me.Label25)
        Me.tbEntrega.Controls.Add(Me.Label15)
        Me.tbEntrega.Controls.Add(Me.txtMontoSolicitado)
        Me.tbEntrega.Controls.Add(Me.Label2)
        Me.tbEntrega.Controls.Add(Me.Label84)
        Me.tbEntrega.Controls.Add(Me.txtCodTipoCredito)
        Me.tbEntrega.Controls.Add(Me.Label6)
        Me.tbEntrega.Controls.Add(Me.txtCodEjecMercadeoE)
        Me.tbEntrega.Controls.Add(Me.txtDuiE)
        Me.tbEntrega.Controls.Add(Me.txtLugTrabE)
        Me.tbEntrega.Controls.Add(Me.txtTipoCredito)
        Me.tbEntrega.Controls.Add(Me.txtNitE)
        Me.tbEntrega.Controls.Add(Me.Label22)
        Me.tbEntrega.Controls.Add(Me.btnSaveTb1_1)
        Me.tbEntrega.Controls.Add(Me.txtDirE)
        Me.tbEntrega.Controls.Add(Me.MetroButton12)
        Me.tbEntrega.Controls.Add(Me.Label21)
        Me.tbEntrega.Controls.Add(Me.txtCelular)
        Me.tbEntrega.Controls.Add(Me.txtNombresE)
        Me.tbEntrega.Controls.Add(Me.Label31)
        Me.tbEntrega.Controls.Add(Me.Label81)
        Me.tbEntrega.Controls.Add(Me.Label10)
        Me.tbEntrega.Controls.Add(Me.txtTelCasaE)
        Me.tbEntrega.Controls.Add(Me.Label14)
        Me.tbEntrega.Controls.Add(Me.Label82)
        Me.tbEntrega.Controls.Add(Me.Label8)
        Me.tbEntrega.Controls.Add(Me.txtApe1E)
        Me.tbEntrega.Controls.Add(Me.txtApe2E)
        Me.tbEntrega.Controls.Add(Me.Label9)
        Me.tbEntrega.Controls.Add(Me.cbEstadoCivilE)
        Me.tbEntrega.Controls.Add(Me.Label80)
        Me.tbEntrega.Controls.Add(Me.Label11)
        Me.tbEntrega.Controls.Add(Me.txtApe3E)
        Me.tbEntrega.Location = New System.Drawing.Point(4, 40)
        Me.tbEntrega.Name = "tbEntrega"
        Me.tbEntrega.Size = New System.Drawing.Size(908, 488)
        Me.tbEntrega.TabIndex = 0
        Me.tbEntrega.Text = "Datos de Entrega"
        '
        'MetroButton7
        '
        Me.MetroButton7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.MetroButton7.Location = New System.Drawing.Point(354, 439)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(114, 32)
        Me.MetroButton7.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton7.TabIndex = 41
        Me.MetroButton7.Text = "&Datos Asociado"
        Me.MetroButton7.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton7.UseSelectable = True
        Me.MetroButton7.UseStyleColors = True
        '
        'txtTelOficE
        '
        Me.txtTelOficE.BackColor = System.Drawing.Color.White
        Me.txtTelOficE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelOficE.Location = New System.Drawing.Point(543, 197)
        Me.txtTelOficE.MaxLength = 40
        Me.txtTelOficE.Name = "txtTelOficE"
        Me.txtTelOficE.Size = New System.Drawing.Size(173, 23)
        Me.txtTelOficE.TabIndex = 23
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.Color.White
        Me.txtPlazo.CustomFormat = "###"
        Me.txtPlazo.DataType = GetType(Short)
        Me.txtPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtPlazo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtPlazo.Location = New System.Drawing.Point(185, 384)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.txtPlazo.Size = New System.Drawing.Size(173, 23)
        Me.txtPlazo.TabIndex = 40
        Me.txtPlazo.Tag = Nothing
        Me.txtPlazo.Value = CType(0, Short)
        '
        'btnSigTb1_1
        '
        Me.btnSigTb1_1.Location = New System.Drawing.Point(678, 438)
        Me.btnSigTb1_1.Name = "btnSigTb1_1"
        Me.btnSigTb1_1.Size = New System.Drawing.Size(90, 33)
        Me.btnSigTb1_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTb1_1.TabIndex = 43
        Me.btnSigTb1_1.Text = "Siguiente"
        Me.btnSigTb1_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTb1_1.UseSelectable = True
        Me.btnSigTb1_1.UseStyleColors = True
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(182, 363)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(151, 18)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "*Plazo (meses):"
        '
        'chkAsociado
        '
        Me.chkAsociado.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.chkAsociado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkAsociado.Location = New System.Drawing.Point(725, 75)
        Me.chkAsociado.Name = "chkAsociado"
        Me.chkAsociado.Size = New System.Drawing.Size(96, 18)
        Me.chkAsociado.TabIndex = 24
        Me.chkAsociado.Text = "Asociado"
        Me.chkAsociado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTasaInteres
        '
        Me.txtTasaInteres.BackColor = System.Drawing.Color.White
        Me.txtTasaInteres.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaInteres.Location = New System.Drawing.Point(719, 337)
        Me.txtTasaInteres.Name = "txtTasaInteres"
        Me.txtTasaInteres.ReadOnly = True
        Me.txtTasaInteres.Size = New System.Drawing.Size(179, 23)
        Me.txtTasaInteres.TabIndex = 36
        '
        'dtpFecEnt
        '
        Me.dtpFecEnt.Enabled = False
        Me.dtpFecEnt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecEnt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecEnt.Location = New System.Drawing.Point(6, 384)
        Me.dtpFecEnt.Name = "dtpFecEnt"
        Me.dtpFecEnt.Size = New System.Drawing.Size(173, 23)
        Me.dtpFecEnt.TabIndex = 38
        Me.dtpFecEnt.Value = New Date(2014, 3, 12, 0, 0, 0, 0)
        '
        'Label83
        '
        Me.Label83.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.Black
        Me.Label83.Location = New System.Drawing.Point(719, 318)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(70, 18)
        Me.Label83.TabIndex = 35
        Me.Label83.Text = "*Tasa:"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(3, 223)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(77, 18)
        Me.Label46.TabIndex = 25
        Me.Label46.Text = "*Ejecutivo:"
        '
        'txtDestino
        '
        Me.txtDestino.BackColor = System.Drawing.Color.White
        Me.txtDestino.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestino.Location = New System.Drawing.Point(185, 338)
        Me.txtDestino.MaxLength = 255
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDestino.Size = New System.Drawing.Size(528, 23)
        Me.txtDestino.TabIndex = 34
        '
        'txtEjecMercadeoE
        '
        Me.txtEjecMercadeoE.BackColor = System.Drawing.Color.White
        Me.txtEjecMercadeoE.Enabled = False
        Me.txtEjecMercadeoE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeoE.Location = New System.Drawing.Point(185, 244)
        Me.txtEjecMercadeoE.MaxLength = 110
        Me.txtEjecMercadeoE.Name = "txtEjecMercadeoE"
        Me.txtEjecMercadeoE.ReadOnly = True
        Me.txtEjecMercadeoE.Size = New System.Drawing.Size(716, 23)
        Me.txtEjecMercadeoE.TabIndex = 27
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(185, 316)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 18)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "*Destino:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(540, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(176, 19)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Teléfono Oficina:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMontoSolicitado
        '
        Me.txtMontoSolicitado.BackColor = System.Drawing.Color.White
        Me.txtMontoSolicitado.CustomFormat = "###,###,##0.00"
        Me.txtMontoSolicitado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoSolicitado.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMontoSolicitado.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMontoSolicitado.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMontoSolicitado.Location = New System.Drawing.Point(6, 337)
        Me.txtMontoSolicitado.Name = "txtMontoSolicitado"
        Me.txtMontoSolicitado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMontoSolicitado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMontoSolicitado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMontoSolicitado.Size = New System.Drawing.Size(173, 23)
        Me.txtMontoSolicitado.TabIndex = 33
        Me.txtMontoSolicitado.Tag = Nothing
        Me.txtMontoSolicitado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "*Tipo de Crédito:"
        '
        'Label84
        '
        Me.Label84.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.Black
        Me.Label84.Location = New System.Drawing.Point(3, 316)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(64, 18)
        Me.Label84.TabIndex = 31
        Me.Label84.Text = "*Monto:"
        '
        'txtCodTipoCredito
        '
        Me.txtCodTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtCodTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoCredito.Location = New System.Drawing.Point(6, 290)
        Me.txtCodTipoCredito.MaxLength = 10
        Me.txtCodTipoCredito.Name = "txtCodTipoCredito"
        Me.txtCodTipoCredito.Size = New System.Drawing.Size(173, 23)
        Me.txtCodTipoCredito.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Fecha entrega:"
        '
        'txtCodEjecMercadeoE
        '
        Me.txtCodEjecMercadeoE.BackColor = System.Drawing.Color.White
        Me.txtCodEjecMercadeoE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEjecMercadeoE.Location = New System.Drawing.Point(6, 244)
        Me.txtCodEjecMercadeoE.MaxLength = 10
        Me.txtCodEjecMercadeoE.Name = "txtCodEjecMercadeoE"
        Me.txtCodEjecMercadeoE.Size = New System.Drawing.Size(173, 23)
        Me.txtCodEjecMercadeoE.TabIndex = 26
        '
        'txtDuiE
        '
        Me.txtDuiE.BackColor = System.Drawing.Color.White
        Me.txtDuiE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuiE.EditMask = "AAAA0000-0"
        Me.txtDuiE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuiE.Location = New System.Drawing.Point(6, 27)
        Me.txtDuiE.MaxLength = 20
        Me.txtDuiE.Name = "txtDuiE"
        Me.txtDuiE.NumericInput = False
        Me.txtDuiE.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtDuiE.PreValidation.Inherit = CType(((C1.Win.C1Input.PreValidationInheritFlags.CaseSensitive Or C1.Win.C1Input.PreValidationInheritFlags.TrimStart) _
            Or C1.Win.C1Input.PreValidationInheritFlags.TrimEnd), C1.Win.C1Input.PreValidationInheritFlags)
        Me.txtDuiE.Size = New System.Drawing.Size(173, 21)
        Me.txtDuiE.TabIndex = 1
        Me.txtDuiE.Tag = Nothing
        Me.txtDuiE.TrimStart = True
        '
        'txtLugTrabE
        '
        Me.txtLugTrabE.BackColor = System.Drawing.Color.White
        Me.txtLugTrabE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugTrabE.Location = New System.Drawing.Point(6, 197)
        Me.txtLugTrabE.MaxLength = 255
        Me.txtLugTrabE.Name = "txtLugTrabE"
        Me.txtLugTrabE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLugTrabE.Size = New System.Drawing.Size(531, 23)
        Me.txtLugTrabE.TabIndex = 21
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtTipoCredito.Enabled = False
        Me.txtTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCredito.Location = New System.Drawing.Point(185, 290)
        Me.txtTipoCredito.MaxLength = 100
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.ReadOnly = True
        Me.txtTipoCredito.Size = New System.Drawing.Size(713, 23)
        Me.txtTipoCredito.TabIndex = 30
        '
        'txtNitE
        '
        Me.txtNitE.BackColor = System.Drawing.Color.White
        Me.txtNitE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNitE.EditMask = "0000-000000-000-0"
        Me.txtNitE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNitE.Location = New System.Drawing.Point(185, 75)
        Me.txtNitE.MaxLength = 20
        Me.txtNitE.Name = "txtNitE"
        Me.txtNitE.NumericInput = False
        Me.txtNitE.Size = New System.Drawing.Size(173, 21)
        Me.txtNitE.TabIndex = 13
        Me.txtNitE.Tag = Nothing
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(3, 175)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(176, 19)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Lugar de Trabajo:"
        '
        'btnSaveTb1_1
        '
        Me.btnSaveTb1_1.Location = New System.Drawing.Point(775, 438)
        Me.btnSaveTb1_1.Name = "btnSaveTb1_1"
        Me.btnSaveTb1_1.Size = New System.Drawing.Size(90, 33)
        Me.btnSaveTb1_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb1_1.TabIndex = 44
        Me.btnSaveTb1_1.Text = "Guardar"
        Me.btnSaveTb1_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb1_1.UseSelectable = True
        Me.btnSaveTb1_1.UseStyleColors = True
        '
        'txtDirE
        '
        Me.txtDirE.BackColor = System.Drawing.Color.White
        Me.txtDirE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirE.Location = New System.Drawing.Point(6, 124)
        Me.txtDirE.MaxLength = 255
        Me.txtDirE.Multiline = True
        Me.txtDirE.Name = "txtDirE"
        Me.txtDirE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDirE.Size = New System.Drawing.Size(892, 39)
        Me.txtDirE.TabIndex = 19
        '
        'MetroButton12
        '
        Me.MetroButton12.Location = New System.Drawing.Point(474, 438)
        Me.MetroButton12.Name = "MetroButton12"
        Me.MetroButton12.Size = New System.Drawing.Size(197, 33)
        Me.MetroButton12.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton12.TabIndex = 42
        Me.MetroButton12.Text = "Aut. Consulta Información"
        Me.MetroButton12.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton12.UseSelectable = True
        Me.MetroButton12.UseStyleColors = True
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(3, 102)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 19)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Dirección:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.Color.White
        Me.txtCelular.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(543, 75)
        Me.txtCelular.MaxLength = 20
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(173, 23)
        Me.txtCelular.TabIndex = 17
        '
        'txtNombresE
        '
        Me.txtNombresE.BackColor = System.Drawing.Color.White
        Me.txtNombresE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombresE.Location = New System.Drawing.Point(185, 28)
        Me.txtNombresE.MaxLength = 50
        Me.txtNombresE.Name = "txtNombresE"
        Me.txtNombresE.Size = New System.Drawing.Size(173, 23)
        Me.txtNombresE.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(3, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 18)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "* Dui:"
        '
        'Label81
        '
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.Black
        Me.Label81.Location = New System.Drawing.Point(542, 54)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(57, 18)
        Me.Label81.TabIndex = 16
        Me.Label81.Text = "Celular:"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(182, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "*Nombres:"
        '
        'txtTelCasaE
        '
        Me.txtTelCasaE.BackColor = System.Drawing.Color.White
        Me.txtTelCasaE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelCasaE.Location = New System.Drawing.Point(364, 76)
        Me.txtTelCasaE.MaxLength = 50
        Me.txtTelCasaE.Name = "txtTelCasaE"
        Me.txtTelCasaE.Size = New System.Drawing.Size(173, 23)
        Me.txtTelCasaE.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(361, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 18)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Teléfono Casa:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label82
        '
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.Black
        Me.Label82.Location = New System.Drawing.Point(185, 54)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(39, 18)
        Me.Label82.TabIndex = 12
        Me.Label82.Text = "*Nit:"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(361, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "* Apellido 1:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe1E
        '
        Me.txtApe1E.BackColor = System.Drawing.Color.White
        Me.txtApe1E.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe1E.Location = New System.Drawing.Point(364, 27)
        Me.txtApe1E.MaxLength = 25
        Me.txtApe1E.Name = "txtApe1E"
        Me.txtApe1E.Size = New System.Drawing.Size(173, 23)
        Me.txtApe1E.TabIndex = 5
        '
        'txtApe2E
        '
        Me.txtApe2E.BackColor = System.Drawing.Color.White
        Me.txtApe2E.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe2E.Location = New System.Drawing.Point(543, 27)
        Me.txtApe2E.MaxLength = 25
        Me.txtApe2E.Name = "txtApe2E"
        Me.txtApe2E.Size = New System.Drawing.Size(173, 23)
        Me.txtApe2E.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(542, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Apellido 2:"
        '
        'cbEstadoCivilE
        '
        Me.cbEstadoCivilE.BackColor = System.Drawing.Color.White
        Me.cbEstadoCivilE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivilE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCivilE.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Acompañado", "Viudo"})
        Me.cbEstadoCivilE.Location = New System.Drawing.Point(6, 75)
        Me.cbEstadoCivilE.Name = "cbEstadoCivilE"
        Me.cbEstadoCivilE.Size = New System.Drawing.Size(173, 24)
        Me.cbEstadoCivilE.TabIndex = 11
        '
        'Label80
        '
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.Black
        Me.Label80.Location = New System.Drawing.Point(3, 55)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(130, 18)
        Me.Label80.TabIndex = 10
        Me.Label80.Text = "*Estado Civil:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(722, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 18)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Apellido Casada:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe3E
        '
        Me.txtApe3E.BackColor = System.Drawing.Color.White
        Me.txtApe3E.Enabled = False
        Me.txtApe3E.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe3E.Location = New System.Drawing.Point(725, 27)
        Me.txtApe3E.MaxLength = 30
        Me.txtApe3E.Name = "txtApe3E"
        Me.txtApe3E.Size = New System.Drawing.Size(173, 23)
        Me.txtApe3E.TabIndex = 9
        '
        'tbRecibido
        '
        Me.tbRecibido.BackColor = System.Drawing.Color.White
        Me.tbRecibido.Controls.Add(Me.btnSigTb2_1)
        Me.tbRecibido.Controls.Add(Me.btnSaveTb2_1)
        Me.tbRecibido.Controls.Add(Me.btnAtrasTb2_1)
        Me.tbRecibido.Controls.Add(Me.GroupBox1)
        Me.tbRecibido.Location = New System.Drawing.Point(4, 40)
        Me.tbRecibido.Name = "tbRecibido"
        Me.tbRecibido.Size = New System.Drawing.Size(908, 488)
        Me.tbRecibido.TabIndex = 1
        Me.tbRecibido.Text = "Información de Recibido"
        '
        'btnSigTb2_1
        '
        Me.btnSigTb2_1.Location = New System.Drawing.Point(689, 437)
        Me.btnSigTb2_1.Name = "btnSigTb2_1"
        Me.btnSigTb2_1.Size = New System.Drawing.Size(90, 33)
        Me.btnSigTb2_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTb2_1.TabIndex = 225
        Me.btnSigTb2_1.Text = "Siguiente"
        Me.btnSigTb2_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTb2_1.UseSelectable = True
        Me.btnSigTb2_1.UseStyleColors = True
        '
        'btnSaveTb2_1
        '
        Me.btnSaveTb2_1.Location = New System.Drawing.Point(786, 437)
        Me.btnSaveTb2_1.Name = "btnSaveTb2_1"
        Me.btnSaveTb2_1.Size = New System.Drawing.Size(90, 33)
        Me.btnSaveTb2_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb2_1.TabIndex = 224
        Me.btnSaveTb2_1.Text = "Guardar"
        Me.btnSaveTb2_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb2_1.UseSelectable = True
        Me.btnSaveTb2_1.UseStyleColors = True
        '
        'btnAtrasTb2_1
        '
        Me.btnAtrasTb2_1.Location = New System.Drawing.Point(592, 437)
        Me.btnAtrasTb2_1.Name = "btnAtrasTb2_1"
        Me.btnAtrasTb2_1.Size = New System.Drawing.Size(90, 33)
        Me.btnAtrasTb2_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTb2_1.TabIndex = 223
        Me.btnAtrasTb2_1.Text = "Atras"
        Me.btnAtrasTb2_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTb2_1.UseSelectable = True
        Me.btnAtrasTb2_1.UseStyleColors = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.dtpFecConc)
        Me.GroupBox1.Controls.Add(Me.cbConclusion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSucursal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label79)
        Me.GroupBox1.Controls.Add(Me.txtCodEjecAp)
        Me.GroupBox1.Controls.Add(Me.txtNoSolic)
        Me.GroupBox1.Controls.Add(Me.cbEstado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.chkRecibida)
        Me.GroupBox1.Controls.Add(Me.Label78)
        Me.GroupBox1.Controls.Add(Me.txtNomCodEjecAp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecRec)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtCodSuc)
        Me.GroupBox1.Controls.Add(Me.txtEjecMercR)
        Me.GroupBox1.Controls.Add(Me.txtCodEjecMercR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(19, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 421)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recibo de Solicitud"
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.White
        Me.txtObs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(11, 230)
        Me.txtObs.MaxLength = 255
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(827, 172)
        Me.txtObs.TabIndex = 8
        '
        'dtpFecConc
        '
        Me.dtpFecConc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecConc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecConc.Location = New System.Drawing.Point(562, 171)
        Me.dtpFecConc.Name = "dtpFecConc"
        Me.dtpFecConc.Size = New System.Drawing.Size(276, 23)
        Me.dtpFecConc.TabIndex = 7
        Me.dtpFecConc.Value = New Date(2017, 1, 28, 0, 0, 0, 0)
        '
        'cbConclusion
        '
        Me.cbConclusion.BackColor = System.Drawing.Color.Khaki
        Me.cbConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConclusion.Enabled = False
        Me.cbConclusion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConclusion.ForeColor = System.Drawing.Color.Navy
        Me.cbConclusion.Items.AddRange(New Object() {"(P) = En Proceso", "(R) = Rechazada", "(A) = Admitida"})
        Me.cbConclusion.Location = New System.Drawing.Point(96, 168)
        Me.cbConclusion.Name = "cbConclusion"
        Me.cbConclusion.Size = New System.Drawing.Size(276, 24)
        Me.cbConclusion.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(442, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 15)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Fecha conclusión:"
        '
        'txtSucursal
        '
        Me.txtSucursal.BackColor = System.Drawing.Color.White
        Me.txtSucursal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.Location = New System.Drawing.Point(142, 46)
        Me.txtSucursal.MaxLength = 100
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.ReadOnly = True
        Me.txtSucursal.Size = New System.Drawing.Size(230, 23)
        Me.txtSucursal.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "*Estado:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 173)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 19)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Conclusión:"
        '
        'Label79
        '
        Me.Label79.BackColor = System.Drawing.Color.White
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Black
        Me.Label79.Location = New System.Drawing.Point(7, 208)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(106, 18)
        Me.Label79.TabIndex = 142
        Me.Label79.Text = "Observaciones:"
        '
        'txtCodEjecAp
        '
        Me.txtCodEjecAp.BackColor = System.Drawing.Color.White
        Me.txtCodEjecAp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEjecAp.Location = New System.Drawing.Point(147, 105)
        Me.txtCodEjecAp.MaxLength = 10
        Me.txtCodEjecAp.Name = "txtCodEjecAp"
        Me.txtCodEjecAp.Size = New System.Drawing.Size(76, 23)
        Me.txtCodEjecAp.TabIndex = 4
        '
        'txtNoSolic
        '
        Me.txtNoSolic.BackColor = System.Drawing.Color.White
        Me.txtNoSolic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSolic.Location = New System.Drawing.Point(96, 17)
        Me.txtNoSolic.MaxLength = 10
        Me.txtNoSolic.Name = "txtNoSolic"
        Me.txtNoSolic.ReadOnly = True
        Me.txtNoSolic.Size = New System.Drawing.Size(173, 23)
        Me.txtNoSolic.TabIndex = 0
        '
        'cbEstado
        '
        Me.cbEstado.BackColor = System.Drawing.Color.Khaki
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Enabled = False
        Me.cbEstado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.Items.AddRange(New Object() {"(F) = Faltan Datos", "(E) = Entrega Completa", "(L) = Analizada", "(A) = Aprobada", "(D) = Denegado", "(P) = Pendiente", "(M) = Desembolso"})
        Me.cbEstado.Location = New System.Drawing.Point(96, 136)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(276, 24)
        Me.cbEstado.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Solicitud:"
        '
        'chkRecibida
        '
        Me.chkRecibida.BackColor = System.Drawing.Color.White
        Me.chkRecibida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecibida.ForeColor = System.Drawing.Color.Black
        Me.chkRecibida.Location = New System.Drawing.Point(338, 17)
        Me.chkRecibida.Name = "chkRecibida"
        Me.chkRecibida.Size = New System.Drawing.Size(96, 19)
        Me.chkRecibida.TabIndex = 2
        Me.chkRecibida.Text = "Recibida"
        Me.chkRecibida.UseVisualStyleBackColor = False
        '
        'Label78
        '
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.Black
        Me.Label78.Location = New System.Drawing.Point(7, 110)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(131, 18)
        Me.Label78.TabIndex = 139
        Me.Label78.Text = "Ejecutivo Apertura:"
        '
        'txtNomCodEjecAp
        '
        Me.txtNomCodEjecAp.BackColor = System.Drawing.Color.White
        Me.txtNomCodEjecAp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomCodEjecAp.Location = New System.Drawing.Point(229, 106)
        Me.txtNomCodEjecAp.MaxLength = 110
        Me.txtNomCodEjecAp.Name = "txtNomCodEjecAp"
        Me.txtNomCodEjecAp.ReadOnly = True
        Me.txtNomCodEjecAp.Size = New System.Drawing.Size(607, 23)
        Me.txtNomCodEjecAp.TabIndex = 141
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(442, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 18)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Fecha Recibido:"
        '
        'dtpFecRec
        '
        Me.dtpFecRec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecRec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRec.Location = New System.Drawing.Point(562, 17)
        Me.dtpFecRec.Name = "dtpFecRec"
        Me.dtpFecRec.Size = New System.Drawing.Size(276, 23)
        Me.dtpFecRec.TabIndex = 0
        Me.dtpFecRec.Value = New Date(2017, 1, 28, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(7, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 18)
        Me.Label12.TabIndex = 135
        Me.Label12.Text = "Sucursal:"
        '
        'txtCodSuc
        '
        Me.txtCodSuc.BackColor = System.Drawing.Color.White
        Me.txtCodSuc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSuc.Location = New System.Drawing.Point(96, 47)
        Me.txtCodSuc.MaxLength = 2
        Me.txtCodSuc.Name = "txtCodSuc"
        Me.txtCodSuc.Size = New System.Drawing.Size(38, 23)
        Me.txtCodSuc.TabIndex = 1
        '
        'txtEjecMercR
        '
        Me.txtEjecMercR.BackColor = System.Drawing.Color.White
        Me.txtEjecMercR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercR.Location = New System.Drawing.Point(229, 76)
        Me.txtEjecMercR.MaxLength = 110
        Me.txtEjecMercR.Name = "txtEjecMercR"
        Me.txtEjecMercR.ReadOnly = True
        Me.txtEjecMercR.Size = New System.Drawing.Size(607, 23)
        Me.txtEjecMercR.TabIndex = 9
        '
        'txtCodEjecMercR
        '
        Me.txtCodEjecMercR.BackColor = System.Drawing.Color.White
        Me.txtCodEjecMercR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEjecMercR.Location = New System.Drawing.Point(147, 76)
        Me.txtCodEjecMercR.MaxLength = 10
        Me.txtCodEjecMercR.Name = "txtCodEjecMercR"
        Me.txtCodEjecMercR.Size = New System.Drawing.Size(76, 23)
        Me.txtCodEjecMercR.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 18)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Ejecutivo Gestión:"
        '
        'tbDatGralIII
        '
        Me.tbDatGralIII.BackColor = System.Drawing.Color.White
        Me.tbDatGralIII.Controls.Add(Me.btnSigTb5_1)
        Me.tbDatGralIII.Controls.Add(Me.btnSaveTb5_1)
        Me.tbDatGralIII.Controls.Add(Me.btnAtrasTb5_1)
        Me.tbDatGralIII.Controls.Add(Me.GroupBox17)
        Me.tbDatGralIII.Location = New System.Drawing.Point(4, 40)
        Me.tbDatGralIII.Name = "tbDatGralIII"
        Me.tbDatGralIII.Size = New System.Drawing.Size(908, 488)
        Me.tbDatGralIII.TabIndex = 8
        Me.tbDatGralIII.Text = "Datos"
        '
        'btnSigTb5_1
        '
        Me.btnSigTb5_1.Location = New System.Drawing.Point(689, 433)
        Me.btnSigTb5_1.Name = "btnSigTb5_1"
        Me.btnSigTb5_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTb5_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTb5_1.TabIndex = 3
        Me.btnSigTb5_1.Text = "Siguiente"
        Me.btnSigTb5_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTb5_1.UseSelectable = True
        Me.btnSigTb5_1.UseStyleColors = True
        '
        'btnSaveTb5_1
        '
        Me.btnSaveTb5_1.Location = New System.Drawing.Point(786, 433)
        Me.btnSaveTb5_1.Name = "btnSaveTb5_1"
        Me.btnSaveTb5_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb5_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb5_1.TabIndex = 0
        Me.btnSaveTb5_1.Text = "&Guardar"
        Me.btnSaveTb5_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb5_1.UseSelectable = True
        Me.btnSaveTb5_1.UseStyleColors = True
        '
        'btnAtrasTb5_1
        '
        Me.btnAtrasTb5_1.Location = New System.Drawing.Point(592, 433)
        Me.btnAtrasTb5_1.Name = "btnAtrasTb5_1"
        Me.btnAtrasTb5_1.Size = New System.Drawing.Size(90, 32)
        Me.btnAtrasTb5_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTb5_1.TabIndex = 2
        Me.btnAtrasTb5_1.Text = "Atras"
        Me.btnAtrasTb5_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTb5_1.UseSelectable = True
        Me.btnAtrasTb5_1.UseStyleColors = True
        '
        'GroupBox17
        '
        Me.GroupBox17.BackColor = System.Drawing.Color.White
        Me.GroupBox17.Controls.Add(Me.btnGenerarCuota)
        Me.GroupBox17.Controls.Add(Me.btTasaPactada1)
        Me.GroupBox17.Controls.Add(Me.Label87)
        Me.GroupBox17.Controls.Add(Me.txtTasaMora)
        Me.GroupBox17.Controls.Add(Me.lblPag)
        Me.GroupBox17.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox17.Controls.Add(Me.c1nTasaDPF)
        Me.GroupBox17.Controls.Add(Me.c1nCuota)
        Me.GroupBox17.Controls.Add(Me.txtPagaduria)
        Me.GroupBox17.Controls.Add(Me.lblCategoria)
        Me.GroupBox17.Controls.Add(Me.Label76)
        Me.GroupBox17.Controls.Add(Me.Label69)
        Me.GroupBox17.Controls.Add(Me.Label86)
        Me.GroupBox17.Controls.Add(Me.Label91)
        Me.GroupBox17.Controls.Add(Me.txtCodPagaduria)
        Me.GroupBox17.Controls.Add(Me.txtDiaPago)
        Me.GroupBox17.Controls.Add(Me.cbFormaPagoP2)
        Me.GroupBox17.Controls.Add(Me.txtTipoCredP2)
        Me.GroupBox17.Controls.Add(Me.Label68)
        Me.GroupBox17.Controls.Add(Me.c1nTasa)
        Me.GroupBox17.Controls.Add(Me.C1NEPlazo)
        Me.GroupBox17.Controls.Add(Me.txtCodTipoCredP2)
        Me.GroupBox17.Controls.Add(Me.Label51)
        Me.GroupBox17.Controls.Add(Me.Label67)
        Me.GroupBox17.Controls.Add(Me.Label49)
        Me.GroupBox17.Controls.Add(Me.txtDestinoP2)
        Me.GroupBox17.Controls.Add(Me.Label40)
        Me.GroupBox17.Controls.Add(Me.C1NEMonto)
        Me.GroupBox17.Controls.Add(Me.Label17)
        Me.GroupBox17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.ForeColor = System.Drawing.Color.Black
        Me.GroupBox17.Location = New System.Drawing.Point(4, 18)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(856, 395)
        Me.GroupBox17.TabIndex = 1
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Solicitud"
        '
        'btnGenerarCuota
        '
        Me.btnGenerarCuota.Location = New System.Drawing.Point(746, 138)
        Me.btnGenerarCuota.Name = "btnGenerarCuota"
        Me.btnGenerarCuota.Size = New System.Drawing.Size(104, 24)
        Me.btnGenerarCuota.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGenerarCuota.TabIndex = 4
        Me.btnGenerarCuota.Text = "Generar Cuota"
        Me.btnGenerarCuota.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGenerarCuota.UseSelectable = True
        Me.btnGenerarCuota.UseStyleColors = True
        '
        'btTasaPactada1
        '
        Me.btTasaPactada1.Location = New System.Drawing.Point(760, 78)
        Me.btTasaPactada1.Name = "btTasaPactada1"
        Me.btTasaPactada1.Size = New System.Drawing.Size(90, 24)
        Me.btTasaPactada1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btTasaPactada1.TabIndex = 11
        Me.btTasaPactada1.Text = "Cambiar Tasa"
        Me.btTasaPactada1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btTasaPactada1.UseSelectable = True
        Me.btTasaPactada1.UseStyleColors = True
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(439, 171)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(83, 16)
        Me.Label87.TabIndex = 22
        Me.Label87.Text = "No. Cuenta:"
        '
        'txtTasaMora
        '
        Me.txtTasaMora.BackColor = System.Drawing.Color.White
        Me.txtTasaMora.CustomFormat = "#0.00"
        Me.txtTasaMora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaMora.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtTasaMora.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtTasaMora.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTasaMora.Location = New System.Drawing.Point(145, 110)
        Me.txtTasaMora.Name = "txtTasaMora"
        Me.txtTasaMora.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtTasaMora.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtTasaMora.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtTasaMora.ReadOnly = True
        Me.txtTasaMora.Size = New System.Drawing.Size(277, 23)
        Me.txtTasaMora.TabIndex = 13
        Me.txtTasaMora.Tag = Nothing
        Me.txtTasaMora.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPag
        '
        Me.lblPag.AutoSize = True
        Me.lblPag.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPag.Location = New System.Drawing.Point(13, 198)
        Me.lblPag.Name = "lblPag"
        Me.lblPag.Size = New System.Drawing.Size(77, 16)
        Me.lblPag.TabIndex = 24
        Me.lblPag.Text = "Pagaduria:"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BackColor = System.Drawing.Color.White
        Me.txtNoCuenta.Enabled = False
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.Location = New System.Drawing.Point(571, 167)
        Me.txtNoCuenta.MaxLength = 25
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.ReadOnly = True
        Me.txtNoCuenta.Size = New System.Drawing.Size(279, 23)
        Me.txtNoCuenta.TabIndex = 23
        Me.txtNoCuenta.Visible = False
        '
        'c1nTasaDPF
        '
        Me.c1nTasaDPF.BackColor = System.Drawing.Color.White
        Me.c1nTasaDPF.CustomFormat = "#0.00"
        Me.c1nTasaDPF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTasaDPF.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasaDPF.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTasaDPF.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasaDPF.Location = New System.Drawing.Point(145, 138)
        Me.c1nTasaDPF.Name = "c1nTasaDPF"
        Me.c1nTasaDPF.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasaDPF.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasaDPF.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasaDPF.ReadOnly = True
        Me.c1nTasaDPF.Size = New System.Drawing.Size(277, 23)
        Me.c1nTasaDPF.TabIndex = 17
        Me.c1nTasaDPF.Tag = Nothing
        Me.c1nTasaDPF.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nCuota
        '
        Me.c1nCuota.BackColor = System.Drawing.Color.White
        Me.c1nCuota.CustomFormat = "###,###,##0.00"
        Me.c1nCuota.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCuota.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCuota.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCuota.Location = New System.Drawing.Point(571, 138)
        Me.c1nCuota.Name = "c1nCuota"
        Me.c1nCuota.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCuota.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCuota.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCuota.Size = New System.Drawing.Size(168, 23)
        Me.c1nCuota.TabIndex = 19
        Me.c1nCuota.Tag = Nothing
        Me.c1nCuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtPagaduria
        '
        Me.txtPagaduria.BackColor = System.Drawing.Color.White
        Me.txtPagaduria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagaduria.Location = New System.Drawing.Point(272, 195)
        Me.txtPagaduria.MaxLength = 100
        Me.txtPagaduria.Name = "txtPagaduria"
        Me.txtPagaduria.ReadOnly = True
        Me.txtPagaduria.Size = New System.Drawing.Size(519, 23)
        Me.txtPagaduria.TabIndex = 26
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.BackColor = System.Drawing.Color.White
        Me.lblCategoria.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.Teal
        Me.lblCategoria.Location = New System.Drawing.Point(798, 195)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(52, 29)
        Me.lblCategoria.TabIndex = 27
        Me.lblCategoria.Text = "P/E"
        Me.lblCategoria.Visible = False
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.Black
        Me.Label76.Location = New System.Drawing.Point(439, 142)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(87, 18)
        Me.Label76.TabIndex = 18
        Me.Label76.Text = "Cuota Total:"
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Black
        Me.Label69.Location = New System.Drawing.Point(13, 168)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(87, 19)
        Me.Label69.TabIndex = 20
        Me.Label69.Text = "Día de Pago:"
        '
        'Label86
        '
        Me.Label86.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.Black
        Me.Label86.Location = New System.Drawing.Point(13, 142)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(77, 18)
        Me.Label86.TabIndex = 16
        Me.Label86.Text = "Tasa DPF:"
        '
        'Label91
        '
        Me.Label91.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.Color.Black
        Me.Label91.Location = New System.Drawing.Point(13, 113)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(79, 19)
        Me.Label91.TabIndex = 12
        Me.Label91.Text = "Tasa Mora:"
        '
        'txtCodPagaduria
        '
        Me.txtCodPagaduria.BackColor = System.Drawing.Color.White
        Me.txtCodPagaduria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPagaduria.Location = New System.Drawing.Point(145, 195)
        Me.txtCodPagaduria.MaxLength = 10
        Me.txtCodPagaduria.Name = "txtCodPagaduria"
        Me.txtCodPagaduria.ReadOnly = True
        Me.txtCodPagaduria.Size = New System.Drawing.Size(120, 23)
        Me.txtCodPagaduria.TabIndex = 25
        '
        'txtDiaPago
        '
        Me.txtDiaPago.BackColor = System.Drawing.Color.White
        Me.txtDiaPago.DataType = GetType(Short)
        Me.txtDiaPago.DateTimeInput = False
        Me.txtDiaPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaPago.FormatType = C1.Win.C1Input.FormatTypeEnum.[Integer]
        Me.txtDiaPago.Location = New System.Drawing.Point(145, 167)
        Me.txtDiaPago.MaxLength = 2
        Me.txtDiaPago.Name = "txtDiaPago"
        Me.txtDiaPago.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtDiaPago.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtDiaPago.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtDiaPago.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.txtDiaPago.Size = New System.Drawing.Size(277, 21)
        Me.txtDiaPago.TabIndex = 21
        Me.txtDiaPago.Tag = Nothing
        Me.txtDiaPago.Value = CType(0, Short)
        '
        'cbFormaPagoP2
        '
        Me.cbFormaPagoP2.BackColor = System.Drawing.Color.Khaki
        Me.cbFormaPagoP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPagoP2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPagoP2.Items.AddRange(New Object() {"Pago personal", "Orden de descuento"})
        Me.cbFormaPagoP2.Location = New System.Drawing.Point(571, 48)
        Me.cbFormaPagoP2.Name = "cbFormaPagoP2"
        Me.cbFormaPagoP2.Size = New System.Drawing.Size(279, 24)
        Me.cbFormaPagoP2.TabIndex = 6
        '
        'txtTipoCredP2
        '
        Me.txtTipoCredP2.BackColor = System.Drawing.Color.White
        Me.txtTipoCredP2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCredP2.Location = New System.Drawing.Point(209, 18)
        Me.txtTipoCredP2.MaxLength = 100
        Me.txtTipoCredP2.Name = "txtTipoCredP2"
        Me.txtTipoCredP2.ReadOnly = True
        Me.txtTipoCredP2.Size = New System.Drawing.Size(641, 23)
        Me.txtTipoCredP2.TabIndex = 2
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(439, 57)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(125, 18)
        Me.Label68.TabIndex = 5
        Me.Label68.Text = "*Forma de Pago:"
        '
        'c1nTasa
        '
        Me.c1nTasa.BackColor = System.Drawing.Color.White
        Me.c1nTasa.CustomFormat = "#0.00"
        Me.c1nTasa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTasa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasa.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTasa.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasa.Location = New System.Drawing.Point(571, 81)
        Me.c1nTasa.Name = "c1nTasa"
        Me.c1nTasa.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasa.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasa.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasa.ReadOnly = True
        Me.c1nTasa.Size = New System.Drawing.Size(181, 23)
        Me.c1nTasa.TabIndex = 10
        Me.c1nTasa.Tag = Nothing
        Me.c1nTasa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'C1NEPlazo
        '
        Me.C1NEPlazo.BackColor = System.Drawing.Color.White
        Me.C1NEPlazo.CustomFormat = "###"
        Me.C1NEPlazo.DataType = GetType(Short)
        Me.C1NEPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEPlazo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEPlazo.Location = New System.Drawing.Point(571, 110)
        Me.C1NEPlazo.Name = "C1NEPlazo"
        Me.C1NEPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NEPlazo.Size = New System.Drawing.Size(279, 23)
        Me.C1NEPlazo.TabIndex = 15
        Me.C1NEPlazo.Tag = Nothing
        Me.C1NEPlazo.Value = CType(0, Short)
        '
        'txtCodTipoCredP2
        '
        Me.txtCodTipoCredP2.BackColor = System.Drawing.Color.White
        Me.txtCodTipoCredP2.Location = New System.Drawing.Point(144, 18)
        Me.txtCodTipoCredP2.MaxLength = 10
        Me.txtCodTipoCredP2.Name = "txtCodTipoCredP2"
        Me.txtCodTipoCredP2.Size = New System.Drawing.Size(58, 23)
        Me.txtCodTipoCredP2.TabIndex = 1
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(13, 18)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(111, 19)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "*Tipo de Crédito:"
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(439, 113)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(96, 19)
        Me.Label67.TabIndex = 14
        Me.Label67.Text = "Plazo (meses):"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(13, 50)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(58, 18)
        Me.Label49.TabIndex = 3
        Me.Label49.Text = "Destino:"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDestinoP2
        '
        Me.txtDestinoP2.BackColor = System.Drawing.Color.White
        Me.txtDestinoP2.Location = New System.Drawing.Point(144, 48)
        Me.txtDestinoP2.MaxLength = 255
        Me.txtDestinoP2.Name = "txtDestinoP2"
        Me.txtDestinoP2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDestinoP2.Size = New System.Drawing.Size(278, 23)
        Me.txtDestinoP2.TabIndex = 4
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(13, 83)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(125, 19)
        Me.Label40.TabIndex = 7
        Me.Label40.Text = "Monto solicitado:"
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BackColor = System.Drawing.Color.White
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(145, 81)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.Size = New System.Drawing.Size(279, 23)
        Me.C1NEMonto.TabIndex = 8
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(439, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 19)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Tasa de Interés:"
        '
        'tbRefFam
        '
        Me.tbRefFam.BackColor = System.Drawing.Color.White
        Me.tbRefFam.Controls.Add(Me.btnSigTab6_1)
        Me.tbRefFam.Controls.Add(Me.btnSaveTb61)
        Me.tbRefFam.Controls.Add(Me.btnAtrasTab6_1)
        Me.tbRefFam.Controls.Add(Me.GroupBox7)
        Me.tbRefFam.Controls.Add(Me.GroupBox8)
        Me.tbRefFam.Location = New System.Drawing.Point(4, 40)
        Me.tbRefFam.Name = "tbRefFam"
        Me.tbRefFam.Size = New System.Drawing.Size(908, 488)
        Me.tbRefFam.TabIndex = 4
        Me.tbRefFam.Text = "Ref. Familiares - Personales"
        '
        'btnSigTab6_1
        '
        Me.btnSigTab6_1.Location = New System.Drawing.Point(689, 436)
        Me.btnSigTab6_1.Name = "btnSigTab6_1"
        Me.btnSigTab6_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTab6_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTab6_1.TabIndex = 222
        Me.btnSigTab6_1.Text = "Siguiente"
        Me.btnSigTab6_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTab6_1.UseSelectable = True
        Me.btnSigTab6_1.UseStyleColors = True
        '
        'btnSaveTb61
        '
        Me.btnSaveTb61.Location = New System.Drawing.Point(786, 436)
        Me.btnSaveTb61.Name = "btnSaveTb61"
        Me.btnSaveTb61.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb61.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb61.TabIndex = 221
        Me.btnSaveTb61.Text = "Guardar"
        Me.btnSaveTb61.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb61.UseSelectable = True
        Me.btnSaveTb61.UseStyleColors = True
        '
        'btnAtrasTab6_1
        '
        Me.btnAtrasTab6_1.Location = New System.Drawing.Point(592, 436)
        Me.btnAtrasTab6_1.Name = "btnAtrasTab6_1"
        Me.btnAtrasTab6_1.Size = New System.Drawing.Size(90, 32)
        Me.btnAtrasTab6_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTab6_1.TabIndex = 220
        Me.btnAtrasTab6_1.Text = "Atras"
        Me.btnAtrasTab6_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTab6_1.UseSelectable = True
        Me.btnAtrasTab6_1.UseStyleColors = True
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
        Me.GroupBox7.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(866, 203)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Referencias Familiares"
        '
        'btEditRF1
        '
        Me.btEditRF1.Location = New System.Drawing.Point(104, 22)
        Me.btEditRF1.Name = "btEditRF1"
        Me.btEditRF1.Size = New System.Drawing.Size(90, 32)
        Me.btEditRF1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditRF1.TabIndex = 205
        Me.btEditRF1.Text = "Modificar"
        Me.btEditRF1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditRF1.UseSelectable = True
        Me.btEditRF1.UseStyleColors = True
        '
        'btDelRF1
        '
        Me.btDelRF1.Location = New System.Drawing.Point(202, 22)
        Me.btDelRF1.Name = "btDelRF1"
        Me.btDelRF1.Size = New System.Drawing.Size(90, 32)
        Me.btDelRF1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelRF1.TabIndex = 204
        Me.btDelRF1.Text = "Eliminar"
        Me.btDelRF1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelRF1.UseSelectable = True
        Me.btDelRF1.UseStyleColors = True
        '
        'btNewRF1
        '
        Me.btNewRF1.Location = New System.Drawing.Point(7, 22)
        Me.btNewRF1.Name = "btNewRF1"
        Me.btNewRF1.Size = New System.Drawing.Size(90, 32)
        Me.btNewRF1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewRF1.TabIndex = 203
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
        Me.fgRefFam.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRefFam.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgRefFam.ForeColor = System.Drawing.Color.Teal
        Me.fgRefFam.Location = New System.Drawing.Point(7, 61)
        Me.fgRefFam.Name = "fgRefFam"
        Me.fgRefFam.Rows.Count = 1
        Me.fgRefFam.Rows.DefaultSize = 22
        Me.fgRefFam.Size = New System.Drawing.Size(852, 135)
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
        Me.GroupBox8.Location = New System.Drawing.Point(10, 217)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(866, 212)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Referencias Personales"
        '
        'btEditRP1
        '
        Me.btEditRP1.Location = New System.Drawing.Point(104, 22)
        Me.btEditRP1.Name = "btEditRP1"
        Me.btEditRP1.Size = New System.Drawing.Size(90, 32)
        Me.btEditRP1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditRP1.TabIndex = 205
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
        Me.btDelRP1.TabIndex = 204
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
        Me.btNewRP1.TabIndex = 203
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
        Me.fgRefPer.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRefPer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgRefPer.ForeColor = System.Drawing.Color.Teal
        Me.fgRefPer.Location = New System.Drawing.Point(7, 61)
        Me.fgRefPer.Name = "fgRefPer"
        Me.fgRefPer.Rows.Count = 1
        Me.fgRefPer.Rows.DefaultSize = 22
        Me.fgRefPer.Size = New System.Drawing.Size(852, 142)
        Me.fgRefPer.StyleInfo = resources.GetString("fgRefPer.StyleInfo")
        Me.fgRefPer.TabIndex = 3
        '
        'tbIngGas
        '
        Me.tbIngGas.BackColor = System.Drawing.Color.White
        Me.tbIngGas.Controls.Add(Me.btnSigTab8_1)
        Me.tbIngGas.Controls.Add(Me.btnSaveTb8_1)
        Me.tbIngGas.Controls.Add(Me.btnAtrasTab8_1)
        Me.tbIngGas.Controls.Add(Me.GroupBox12)
        Me.tbIngGas.Controls.Add(Me.GroupBox11)
        Me.tbIngGas.Location = New System.Drawing.Point(4, 40)
        Me.tbIngGas.Name = "tbIngGas"
        Me.tbIngGas.Size = New System.Drawing.Size(908, 488)
        Me.tbIngGas.TabIndex = 9
        Me.tbIngGas.Text = "Ingresos - Gastos"
        '
        'btnSigTab8_1
        '
        Me.btnSigTab8_1.Location = New System.Drawing.Point(689, 441)
        Me.btnSigTab8_1.Name = "btnSigTab8_1"
        Me.btnSigTab8_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTab8_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTab8_1.TabIndex = 219
        Me.btnSigTab8_1.Text = "Siguiente"
        Me.btnSigTab8_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTab8_1.UseSelectable = True
        Me.btnSigTab8_1.UseStyleColors = True
        '
        'btnSaveTb8_1
        '
        Me.btnSaveTb8_1.Location = New System.Drawing.Point(786, 441)
        Me.btnSaveTb8_1.Name = "btnSaveTb8_1"
        Me.btnSaveTb8_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb8_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb8_1.TabIndex = 218
        Me.btnSaveTb8_1.Text = "Guardar"
        Me.btnSaveTb8_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb8_1.UseSelectable = True
        Me.btnSaveTb8_1.UseStyleColors = True
        '
        'btnAtrasTab8_1
        '
        Me.btnAtrasTab8_1.Location = New System.Drawing.Point(592, 441)
        Me.btnAtrasTab8_1.Name = "btnAtrasTab8_1"
        Me.btnAtrasTab8_1.Size = New System.Drawing.Size(90, 32)
        Me.btnAtrasTab8_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTab8_1.TabIndex = 217
        Me.btnAtrasTab8_1.Text = "Atras"
        Me.btnAtrasTab8_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTab8_1.UseSelectable = True
        Me.btnAtrasTab8_1.UseStyleColors = True
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Controls.Add(Me.btEditGt1)
        Me.GroupBox12.Controls.Add(Me.btDelGt1)
        Me.GroupBox12.Controls.Add(Me.btNewGt1)
        Me.GroupBox12.Controls.Add(Me.lblTotal)
        Me.GroupBox12.Controls.Add(Me.fgGastos)
        Me.GroupBox12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox12.Location = New System.Drawing.Point(10, 225)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(866, 209)
        Me.GroupBox12.TabIndex = 1
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Gastos"
        '
        'btEditGt1
        '
        Me.btEditGt1.Location = New System.Drawing.Point(107, 25)
        Me.btEditGt1.Name = "btEditGt1"
        Me.btEditGt1.Size = New System.Drawing.Size(90, 33)
        Me.btEditGt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditGt1.TabIndex = 205
        Me.btEditGt1.Text = "Modificar"
        Me.btEditGt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditGt1.UseSelectable = True
        Me.btEditGt1.UseStyleColors = True
        '
        'btDelGt1
        '
        Me.btDelGt1.Location = New System.Drawing.Point(204, 25)
        Me.btDelGt1.Name = "btDelGt1"
        Me.btDelGt1.Size = New System.Drawing.Size(90, 33)
        Me.btDelGt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelGt1.TabIndex = 204
        Me.btDelGt1.Text = "Eliminar"
        Me.btDelGt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelGt1.UseSelectable = True
        Me.btDelGt1.UseStyleColors = True
        '
        'btNewGt1
        '
        Me.btNewGt1.Location = New System.Drawing.Point(10, 25)
        Me.btNewGt1.Name = "btNewGt1"
        Me.btNewGt1.Size = New System.Drawing.Size(90, 33)
        Me.btNewGt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewGt1.TabIndex = 203
        Me.btNewGt1.Text = "Agregar"
        Me.btNewGt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewGt1.UseSelectable = True
        Me.btNewGt1.UseStyleColors = True
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(662, 28)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(135, 26)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fgGastos
        '
        Me.fgGastos.AllowEditing = False
        Me.fgGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgGastos.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgGastos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgGastos.ForeColor = System.Drawing.Color.Teal
        Me.fgGastos.Location = New System.Drawing.Point(10, 65)
        Me.fgGastos.Name = "fgGastos"
        Me.fgGastos.Rows.Count = 1
        Me.fgGastos.Rows.DefaultSize = 22
        Me.fgGastos.Size = New System.Drawing.Size(847, 125)
        Me.fgGastos.StyleInfo = resources.GetString("fgGastos.StyleInfo")
        Me.fgGastos.TabIndex = 3
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.White
        Me.GroupBox11.Controls.Add(Me.btEditIng1)
        Me.GroupBox11.Controls.Add(Me.btDelIng1)
        Me.GroupBox11.Controls.Add(Me.btNewIng1)
        Me.GroupBox11.Controls.Add(Me.lblTotalIng)
        Me.GroupBox11.Controls.Add(Me.fgIngresos)
        Me.GroupBox11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox11.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(866, 213)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Ingresos"
        '
        'btEditIng1
        '
        Me.btEditIng1.Location = New System.Drawing.Point(107, 25)
        Me.btEditIng1.Name = "btEditIng1"
        Me.btEditIng1.Size = New System.Drawing.Size(90, 33)
        Me.btEditIng1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditIng1.TabIndex = 205
        Me.btEditIng1.Text = "Modificar"
        Me.btEditIng1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditIng1.UseSelectable = True
        Me.btEditIng1.UseStyleColors = True
        '
        'btDelIng1
        '
        Me.btDelIng1.Location = New System.Drawing.Point(204, 25)
        Me.btDelIng1.Name = "btDelIng1"
        Me.btDelIng1.Size = New System.Drawing.Size(90, 33)
        Me.btDelIng1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelIng1.TabIndex = 204
        Me.btDelIng1.Text = "Eliminar"
        Me.btDelIng1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelIng1.UseSelectable = True
        Me.btDelIng1.UseStyleColors = True
        '
        'btNewIng1
        '
        Me.btNewIng1.Location = New System.Drawing.Point(10, 25)
        Me.btNewIng1.Name = "btNewIng1"
        Me.btNewIng1.Size = New System.Drawing.Size(90, 33)
        Me.btNewIng1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewIng1.TabIndex = 203
        Me.btNewIng1.Text = "Agregar"
        Me.btNewIng1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewIng1.UseSelectable = True
        Me.btNewIng1.UseStyleColors = True
        '
        'lblTotalIng
        '
        Me.lblTotalIng.Location = New System.Drawing.Point(672, 28)
        Me.lblTotalIng.Name = "lblTotalIng"
        Me.lblTotalIng.Size = New System.Drawing.Size(134, 26)
        Me.lblTotalIng.TabIndex = 5
        Me.lblTotalIng.Text = "Total:"
        Me.lblTotalIng.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fgIngresos
        '
        Me.fgIngresos.AllowEditing = False
        Me.fgIngresos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgIngresos.BackColor = System.Drawing.Color.White
        Me.fgIngresos.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgIngresos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgIngresos.ForeColor = System.Drawing.Color.Teal
        Me.fgIngresos.Location = New System.Drawing.Point(10, 65)
        Me.fgIngresos.Name = "fgIngresos"
        Me.fgIngresos.Rows.Count = 1
        Me.fgIngresos.Rows.DefaultSize = 22
        Me.fgIngresos.Size = New System.Drawing.Size(847, 129)
        Me.fgIngresos.StyleInfo = resources.GetString("fgIngresos.StyleInfo")
        Me.fgIngresos.TabIndex = 3
        '
        'tbObligObs
        '
        Me.tbObligObs.BackColor = System.Drawing.Color.White
        Me.tbObligObs.Controls.Add(Me.MetroButton1)
        Me.tbObligObs.Controls.Add(Me.btnSigTab10_1)
        Me.tbObligObs.Controls.Add(Me.btnSaveTb10_1)
        Me.tbObligObs.Controls.Add(Me.btnAtrasTab10_1)
        Me.tbObligObs.Controls.Add(Me.GroupBox16)
        Me.tbObligObs.Controls.Add(Me.GroupBox15)
        Me.tbObligObs.Location = New System.Drawing.Point(4, 40)
        Me.tbObligObs.Name = "tbObligObs"
        Me.tbObligObs.Size = New System.Drawing.Size(908, 488)
        Me.tbObligObs.TabIndex = 11
        Me.tbObligObs.Text = "Obligaciones - Obs. por Análisis"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(433, 442)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(151, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 217
        Me.MetroButton1.Text = "Análisis de Crédito"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnSigTab10_1
        '
        Me.btnSigTab10_1.Location = New System.Drawing.Point(689, 442)
        Me.btnSigTab10_1.Name = "btnSigTab10_1"
        Me.btnSigTab10_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTab10_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTab10_1.TabIndex = 216
        Me.btnSigTab10_1.Text = "Siguiente"
        Me.btnSigTab10_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTab10_1.UseSelectable = True
        Me.btnSigTab10_1.UseStyleColors = True
        '
        'btnSaveTb10_1
        '
        Me.btnSaveTb10_1.Location = New System.Drawing.Point(786, 442)
        Me.btnSaveTb10_1.Name = "btnSaveTb10_1"
        Me.btnSaveTb10_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb10_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb10_1.TabIndex = 215
        Me.btnSaveTb10_1.Text = "Guardar"
        Me.btnSaveTb10_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb10_1.UseSelectable = True
        Me.btnSaveTb10_1.UseStyleColors = True
        '
        'btnAtrasTab10_1
        '
        Me.btnAtrasTab10_1.Location = New System.Drawing.Point(592, 442)
        Me.btnAtrasTab10_1.Name = "btnAtrasTab10_1"
        Me.btnAtrasTab10_1.Size = New System.Drawing.Size(90, 32)
        Me.btnAtrasTab10_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTab10_1.TabIndex = 214
        Me.btnAtrasTab10_1.Text = "Atras"
        Me.btnAtrasTab10_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTab10_1.UseSelectable = True
        Me.btnAtrasTab10_1.UseStyleColors = True
        '
        'GroupBox16
        '
        Me.GroupBox16.BackColor = System.Drawing.Color.White
        Me.GroupBox16.Controls.Add(Me.btEditOA1)
        Me.GroupBox16.Controls.Add(Me.btDelOA1)
        Me.GroupBox16.Controls.Add(Me.btNewOA1)
        Me.GroupBox16.Controls.Add(Me.fgObsxAnal)
        Me.GroupBox16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox16.ForeColor = System.Drawing.Color.Black
        Me.GroupBox16.Location = New System.Drawing.Point(10, 226)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(866, 212)
        Me.GroupBox16.TabIndex = 1
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Observaciones x Análisis"
        '
        'btEditOA1
        '
        Me.btEditOA1.Location = New System.Drawing.Point(107, 28)
        Me.btEditOA1.Name = "btEditOA1"
        Me.btEditOA1.Size = New System.Drawing.Size(90, 32)
        Me.btEditOA1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditOA1.TabIndex = 205
        Me.btEditOA1.Text = "Modificar"
        Me.btEditOA1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditOA1.UseSelectable = True
        Me.btEditOA1.UseStyleColors = True
        '
        'btDelOA1
        '
        Me.btDelOA1.Location = New System.Drawing.Point(204, 28)
        Me.btDelOA1.Name = "btDelOA1"
        Me.btDelOA1.Size = New System.Drawing.Size(90, 32)
        Me.btDelOA1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelOA1.TabIndex = 204
        Me.btDelOA1.Text = "Eliminar"
        Me.btDelOA1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelOA1.UseSelectable = True
        Me.btDelOA1.UseStyleColors = True
        '
        'btNewOA1
        '
        Me.btNewOA1.Location = New System.Drawing.Point(10, 28)
        Me.btNewOA1.Name = "btNewOA1"
        Me.btNewOA1.Size = New System.Drawing.Size(90, 32)
        Me.btNewOA1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewOA1.TabIndex = 203
        Me.btNewOA1.Text = "Agregar"
        Me.btNewOA1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewOA1.UseSelectable = True
        Me.btNewOA1.UseStyleColors = True
        '
        'fgObsxAnal
        '
        Me.fgObsxAnal.AllowEditing = False
        Me.fgObsxAnal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgObsxAnal.BackColor = System.Drawing.Color.White
        Me.fgObsxAnal.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgObsxAnal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgObsxAnal.ForeColor = System.Drawing.Color.Black
        Me.fgObsxAnal.Location = New System.Drawing.Point(10, 65)
        Me.fgObsxAnal.Name = "fgObsxAnal"
        Me.fgObsxAnal.Rows.Count = 1
        Me.fgObsxAnal.Rows.DefaultSize = 22
        Me.fgObsxAnal.Size = New System.Drawing.Size(847, 129)
        Me.fgObsxAnal.StyleInfo = resources.GetString("fgObsxAnal.StyleInfo")
        Me.fgObsxAnal.TabIndex = 3
        '
        'GroupBox15
        '
        Me.GroupBox15.BackColor = System.Drawing.Color.White
        Me.GroupBox15.Controls.Add(Me.btEditOb1)
        Me.GroupBox15.Controls.Add(Me.btDelOb1)
        Me.GroupBox15.Controls.Add(Me.btNewOb1)
        Me.GroupBox15.Controls.Add(Me.fgOblig)
        Me.GroupBox15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.ForeColor = System.Drawing.Color.Black
        Me.GroupBox15.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(866, 213)
        Me.GroupBox15.TabIndex = 0
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Obligaciones"
        '
        'btEditOb1
        '
        Me.btEditOb1.Location = New System.Drawing.Point(107, 28)
        Me.btEditOb1.Name = "btEditOb1"
        Me.btEditOb1.Size = New System.Drawing.Size(90, 32)
        Me.btEditOb1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditOb1.TabIndex = 205
        Me.btEditOb1.Text = "Modificar"
        Me.btEditOb1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditOb1.UseSelectable = True
        Me.btEditOb1.UseStyleColors = True
        '
        'btDelOb1
        '
        Me.btDelOb1.Location = New System.Drawing.Point(204, 28)
        Me.btDelOb1.Name = "btDelOb1"
        Me.btDelOb1.Size = New System.Drawing.Size(90, 32)
        Me.btDelOb1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelOb1.TabIndex = 204
        Me.btDelOb1.Text = "Eliminar"
        Me.btDelOb1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelOb1.UseSelectable = True
        Me.btDelOb1.UseStyleColors = True
        '
        'btNewOb1
        '
        Me.btNewOb1.Location = New System.Drawing.Point(10, 25)
        Me.btNewOb1.Name = "btNewOb1"
        Me.btNewOb1.Size = New System.Drawing.Size(90, 33)
        Me.btNewOb1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewOb1.TabIndex = 203
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
        Me.fgOblig.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgOblig.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgOblig.ForeColor = System.Drawing.Color.Black
        Me.fgOblig.Location = New System.Drawing.Point(10, 65)
        Me.fgOblig.Name = "fgOblig"
        Me.fgOblig.Rows.Count = 1
        Me.fgOblig.Rows.DefaultSize = 22
        Me.fgOblig.Size = New System.Drawing.Size(847, 129)
        Me.fgOblig.StyleInfo = resources.GetString("fgOblig.StyleInfo")
        Me.fgOblig.TabIndex = 3
        '
        'tbRefPers
        '
        Me.tbRefPers.BackColor = System.Drawing.Color.White
        Me.tbRefPers.Controls.Add(Me.MetroButton22)
        Me.tbRefPers.Controls.Add(Me.btnSaveTb7_1)
        Me.tbRefPers.Controls.Add(Me.MetroButton24)
        Me.tbRefPers.Controls.Add(Me.GroupBox10)
        Me.tbRefPers.Controls.Add(Me.GroupBox9)
        Me.tbRefPers.Location = New System.Drawing.Point(4, 40)
        Me.tbRefPers.Name = "tbRefPers"
        Me.tbRefPers.Size = New System.Drawing.Size(908, 488)
        Me.tbRefPers.TabIndex = 5
        Me.tbRefPers.Text = "Ref. Comerciales - Bancarias"
        '
        'MetroButton22
        '
        Me.MetroButton22.Location = New System.Drawing.Point(673, 442)
        Me.MetroButton22.Name = "MetroButton22"
        Me.MetroButton22.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton22.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton22.TabIndex = 213
        Me.MetroButton22.Text = "Siguiente"
        Me.MetroButton22.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton22.UseSelectable = True
        Me.MetroButton22.UseStyleColors = True
        '
        'btnSaveTb7_1
        '
        Me.btnSaveTb7_1.Location = New System.Drawing.Point(770, 442)
        Me.btnSaveTb7_1.Name = "btnSaveTb7_1"
        Me.btnSaveTb7_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb7_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb7_1.TabIndex = 212
        Me.btnSaveTb7_1.Text = "Guardar"
        Me.btnSaveTb7_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb7_1.UseSelectable = True
        Me.btnSaveTb7_1.UseStyleColors = True
        '
        'MetroButton24
        '
        Me.MetroButton24.Location = New System.Drawing.Point(576, 442)
        Me.MetroButton24.Name = "MetroButton24"
        Me.MetroButton24.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton24.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton24.TabIndex = 211
        Me.MetroButton24.Text = "Atras"
        Me.MetroButton24.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton24.UseSelectable = True
        Me.MetroButton24.UseStyleColors = True
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
        Me.GroupBox10.Location = New System.Drawing.Point(10, 222)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(850, 214)
        Me.GroupBox10.TabIndex = 1
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Referencias Bancarias"
        '
        'btEditRB1
        '
        Me.btEditRB1.Location = New System.Drawing.Point(121, 22)
        Me.btEditRB1.Name = "btEditRB1"
        Me.btEditRB1.Size = New System.Drawing.Size(90, 32)
        Me.btEditRB1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditRB1.TabIndex = 205
        Me.btEditRB1.Text = "Modificar"
        Me.btEditRB1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditRB1.UseSelectable = True
        Me.btEditRB1.UseStyleColors = True
        '
        'btDelRB1
        '
        Me.btDelRB1.Location = New System.Drawing.Point(218, 22)
        Me.btDelRB1.Name = "btDelRB1"
        Me.btDelRB1.Size = New System.Drawing.Size(90, 32)
        Me.btDelRB1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelRB1.TabIndex = 204
        Me.btDelRB1.Text = "Eliminar"
        Me.btDelRB1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelRB1.UseSelectable = True
        Me.btDelRB1.UseStyleColors = True
        '
        'btNewRB1
        '
        Me.btNewRB1.Location = New System.Drawing.Point(24, 22)
        Me.btNewRB1.Name = "btNewRB1"
        Me.btNewRB1.Size = New System.Drawing.Size(90, 32)
        Me.btNewRB1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewRB1.TabIndex = 203
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
        Me.fgRefBan.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRefBan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgRefBan.ForeColor = System.Drawing.Color.Teal
        Me.fgRefBan.Location = New System.Drawing.Point(24, 61)
        Me.fgRefBan.Name = "fgRefBan"
        Me.fgRefBan.Rows.Count = 1
        Me.fgRefBan.Rows.DefaultSize = 22
        Me.fgRefBan.Size = New System.Drawing.Size(803, 135)
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
        Me.GroupBox9.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(850, 213)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Referencias Comerciales"
        '
        'btEditRC1
        '
        Me.btEditRC1.Location = New System.Drawing.Point(121, 28)
        Me.btEditRC1.Name = "btEditRC1"
        Me.btEditRC1.Size = New System.Drawing.Size(90, 32)
        Me.btEditRC1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditRC1.TabIndex = 205
        Me.btEditRC1.Text = "Modificar"
        Me.btEditRC1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditRC1.UseSelectable = True
        Me.btEditRC1.UseStyleColors = True
        '
        'btDelRC1
        '
        Me.btDelRC1.Location = New System.Drawing.Point(218, 28)
        Me.btDelRC1.Name = "btDelRC1"
        Me.btDelRC1.Size = New System.Drawing.Size(90, 32)
        Me.btDelRC1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelRC1.TabIndex = 204
        Me.btDelRC1.Text = "Eliminar"
        Me.btDelRC1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelRC1.UseSelectable = True
        Me.btDelRC1.UseStyleColors = True
        '
        'btNewRC1
        '
        Me.btNewRC1.Location = New System.Drawing.Point(24, 28)
        Me.btNewRC1.Name = "btNewRC1"
        Me.btNewRC1.Size = New System.Drawing.Size(90, 32)
        Me.btNewRC1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewRC1.TabIndex = 203
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
        Me.fgRefCom.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRefCom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgRefCom.ForeColor = System.Drawing.Color.Teal
        Me.fgRefCom.Location = New System.Drawing.Point(24, 67)
        Me.fgRefCom.Name = "fgRefCom"
        Me.fgRefCom.Rows.Count = 1
        Me.fgRefCom.Rows.DefaultSize = 22
        Me.fgRefCom.Size = New System.Drawing.Size(803, 129)
        Me.fgRefCom.StyleInfo = resources.GetString("fgRefCom.StyleInfo")
        Me.fgRefCom.TabIndex = 3
        '
        'tbGarantias
        '
        Me.tbGarantias.BackColor = System.Drawing.Color.White
        Me.tbGarantias.Controls.Add(Me.btnSolCredito)
        Me.tbGarantias.Controls.Add(Me.btnSigTab9_1)
        Me.tbGarantias.Controls.Add(Me.btnSaveTb11_1)
        Me.tbGarantias.Controls.Add(Me.btnAtrasTab11_1)
        Me.tbGarantias.Controls.Add(Me.GroupBox20)
        Me.tbGarantias.Controls.Add(Me.GroupBox19)
        Me.tbGarantias.Controls.Add(Me.GroupBox18)
        Me.tbGarantias.Location = New System.Drawing.Point(4, 40)
        Me.tbGarantias.Name = "tbGarantias"
        Me.tbGarantias.Size = New System.Drawing.Size(908, 488)
        Me.tbGarantias.TabIndex = 12
        Me.tbGarantias.Text = "Garantías - Fiadores"
        '
        'btnSolCredito
        '
        Me.btnSolCredito.Location = New System.Drawing.Point(390, 440)
        Me.btnSolCredito.Name = "btnSolCredito"
        Me.btnSolCredito.Size = New System.Drawing.Size(176, 32)
        Me.btnSolCredito.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSolCredito.TabIndex = 211
        Me.btnSolCredito.Text = "Solicitud de crédito"
        Me.btnSolCredito.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSolCredito.UseSelectable = True
        Me.btnSolCredito.UseStyleColors = True
        '
        'btnSigTab9_1
        '
        Me.btnSigTab9_1.Location = New System.Drawing.Point(671, 440)
        Me.btnSigTab9_1.Name = "btnSigTab9_1"
        Me.btnSigTab9_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTab9_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTab9_1.TabIndex = 210
        Me.btnSigTab9_1.Text = "Siguiente"
        Me.btnSigTab9_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTab9_1.UseSelectable = True
        Me.btnSigTab9_1.UseStyleColors = True
        '
        'btnSaveTb11_1
        '
        Me.btnSaveTb11_1.Location = New System.Drawing.Point(768, 440)
        Me.btnSaveTb11_1.Name = "btnSaveTb11_1"
        Me.btnSaveTb11_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb11_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb11_1.TabIndex = 209
        Me.btnSaveTb11_1.Text = "Guardar"
        Me.btnSaveTb11_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb11_1.UseSelectable = True
        Me.btnSaveTb11_1.UseStyleColors = True
        '
        'btnAtrasTab11_1
        '
        Me.btnAtrasTab11_1.Location = New System.Drawing.Point(574, 440)
        Me.btnAtrasTab11_1.Name = "btnAtrasTab11_1"
        Me.btnAtrasTab11_1.Size = New System.Drawing.Size(90, 32)
        Me.btnAtrasTab11_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTab11_1.TabIndex = 208
        Me.btnAtrasTab11_1.Text = "Atras"
        Me.btnAtrasTab11_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTab11_1.UseSelectable = True
        Me.btnAtrasTab11_1.UseStyleColors = True
        '
        'GroupBox20
        '
        Me.GroupBox20.BackColor = System.Drawing.Color.White
        Me.GroupBox20.Controls.Add(Me.btEditCd1)
        Me.GroupBox20.Controls.Add(Me.btDelCd1)
        Me.GroupBox20.Controls.Add(Me.btNewCd1)
        Me.GroupBox20.Controls.Add(Me.fgCd)
        Me.GroupBox20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox20.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox20.Location = New System.Drawing.Point(10, 293)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(848, 148)
        Me.GroupBox20.TabIndex = 7
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Codeudores"
        '
        'btEditCd1
        '
        Me.btEditCd1.Location = New System.Drawing.Point(107, 16)
        Me.btEditCd1.Name = "btEditCd1"
        Me.btEditCd1.Size = New System.Drawing.Size(90, 23)
        Me.btEditCd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditCd1.TabIndex = 205
        Me.btEditCd1.Text = "Modificar"
        Me.btEditCd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditCd1.UseSelectable = True
        Me.btEditCd1.UseStyleColors = True
        '
        'btDelCd1
        '
        Me.btDelCd1.Location = New System.Drawing.Point(204, 16)
        Me.btDelCd1.Name = "btDelCd1"
        Me.btDelCd1.Size = New System.Drawing.Size(90, 23)
        Me.btDelCd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelCd1.TabIndex = 204
        Me.btDelCd1.Text = "Eliminar"
        Me.btDelCd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelCd1.UseSelectable = True
        Me.btDelCd1.UseStyleColors = True
        '
        'btNewCd1
        '
        Me.btNewCd1.Location = New System.Drawing.Point(10, 16)
        Me.btNewCd1.Name = "btNewCd1"
        Me.btNewCd1.Size = New System.Drawing.Size(90, 23)
        Me.btNewCd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewCd1.TabIndex = 203
        Me.btNewCd1.Text = "Agregar"
        Me.btNewCd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewCd1.UseSelectable = True
        Me.btNewCd1.UseStyleColors = True
        '
        'fgCd
        '
        Me.fgCd.AllowEditing = False
        Me.fgCd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgCd.BackColor = System.Drawing.Color.White
        Me.fgCd.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgCd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgCd.ForeColor = System.Drawing.Color.Teal
        Me.fgCd.Location = New System.Drawing.Point(10, 46)
        Me.fgCd.Name = "fgCd"
        Me.fgCd.Rows.Count = 1
        Me.fgCd.Rows.DefaultSize = 22
        Me.fgCd.Size = New System.Drawing.Size(829, 92)
        Me.fgCd.StyleInfo = resources.GetString("fgCd.StyleInfo")
        Me.fgCd.TabIndex = 3
        '
        'GroupBox19
        '
        Me.GroupBox19.BackColor = System.Drawing.Color.White
        Me.GroupBox19.Controls.Add(Me.btEditFd1)
        Me.GroupBox19.Controls.Add(Me.btDelFd1)
        Me.GroupBox19.Controls.Add(Me.btNewFd1)
        Me.GroupBox19.Controls.Add(Me.fgFd)
        Me.GroupBox19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox19.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox19.Location = New System.Drawing.Point(10, 148)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(848, 147)
        Me.GroupBox19.TabIndex = 6
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Fiadores"
        '
        'btEditFd1
        '
        Me.btEditFd1.Location = New System.Drawing.Point(107, 22)
        Me.btEditFd1.Name = "btEditFd1"
        Me.btEditFd1.Size = New System.Drawing.Size(90, 23)
        Me.btEditFd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditFd1.TabIndex = 205
        Me.btEditFd1.Text = "Modificar"
        Me.btEditFd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditFd1.UseSelectable = True
        Me.btEditFd1.UseStyleColors = True
        '
        'btDelFd1
        '
        Me.btDelFd1.Location = New System.Drawing.Point(204, 22)
        Me.btDelFd1.Name = "btDelFd1"
        Me.btDelFd1.Size = New System.Drawing.Size(90, 23)
        Me.btDelFd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelFd1.TabIndex = 204
        Me.btDelFd1.Text = "Eliminar"
        Me.btDelFd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelFd1.UseSelectable = True
        Me.btDelFd1.UseStyleColors = True
        '
        'btNewFd1
        '
        Me.btNewFd1.Location = New System.Drawing.Point(10, 22)
        Me.btNewFd1.Name = "btNewFd1"
        Me.btNewFd1.Size = New System.Drawing.Size(90, 23)
        Me.btNewFd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewFd1.TabIndex = 203
        Me.btNewFd1.Text = "Agregar"
        Me.btNewFd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewFd1.UseSelectable = True
        Me.btNewFd1.UseStyleColors = True
        '
        'fgFd
        '
        Me.fgFd.AllowEditing = False
        Me.fgFd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgFd.BackColor = System.Drawing.Color.White
        Me.fgFd.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgFd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgFd.ForeColor = System.Drawing.Color.Teal
        Me.fgFd.Location = New System.Drawing.Point(10, 46)
        Me.fgFd.Name = "fgFd"
        Me.fgFd.Rows.Count = 1
        Me.fgFd.Rows.DefaultSize = 22
        Me.fgFd.Size = New System.Drawing.Size(829, 92)
        Me.fgFd.StyleInfo = resources.GetString("fgFd.StyleInfo")
        Me.fgFd.TabIndex = 3
        '
        'GroupBox18
        '
        Me.GroupBox18.BackColor = System.Drawing.Color.White
        Me.GroupBox18.Controls.Add(Me.btConsultaGarantiasInt1)
        Me.GroupBox18.Controls.Add(Me.btEditGr1)
        Me.GroupBox18.Controls.Add(Me.btDelGr1)
        Me.GroupBox18.Controls.Add(Me.btNewGr1)
        Me.GroupBox18.Controls.Add(Me.fgGr)
        Me.GroupBox18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox18.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox18.Location = New System.Drawing.Point(10, 0)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(848, 148)
        Me.GroupBox18.TabIndex = 1
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Garantías"
        '
        'btConsultaGarantiasInt1
        '
        Me.btConsultaGarantiasInt1.Location = New System.Drawing.Point(301, 18)
        Me.btConsultaGarantiasInt1.Name = "btConsultaGarantiasInt1"
        Me.btConsultaGarantiasInt1.Size = New System.Drawing.Size(136, 24)
        Me.btConsultaGarantiasInt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btConsultaGarantiasInt1.TabIndex = 206
        Me.btConsultaGarantiasInt1.Text = "Garantías Internas"
        Me.btConsultaGarantiasInt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btConsultaGarantiasInt1.UseSelectable = True
        Me.btConsultaGarantiasInt1.UseStyleColors = True
        '
        'btEditGr1
        '
        Me.btEditGr1.Location = New System.Drawing.Point(107, 18)
        Me.btEditGr1.Name = "btEditGr1"
        Me.btEditGr1.Size = New System.Drawing.Size(90, 24)
        Me.btEditGr1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditGr1.TabIndex = 205
        Me.btEditGr1.Text = "Modificar"
        Me.btEditGr1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditGr1.UseSelectable = True
        Me.btEditGr1.UseStyleColors = True
        '
        'btDelGr1
        '
        Me.btDelGr1.Location = New System.Drawing.Point(204, 18)
        Me.btDelGr1.Name = "btDelGr1"
        Me.btDelGr1.Size = New System.Drawing.Size(90, 24)
        Me.btDelGr1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelGr1.TabIndex = 204
        Me.btDelGr1.Text = "Eliminar"
        Me.btDelGr1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelGr1.UseSelectable = True
        Me.btDelGr1.UseStyleColors = True
        '
        'btNewGr1
        '
        Me.btNewGr1.Location = New System.Drawing.Point(10, 18)
        Me.btNewGr1.Name = "btNewGr1"
        Me.btNewGr1.Size = New System.Drawing.Size(90, 24)
        Me.btNewGr1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewGr1.TabIndex = 203
        Me.btNewGr1.Text = "Agregar"
        Me.btNewGr1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewGr1.UseSelectable = True
        Me.btNewGr1.UseStyleColors = True
        '
        'fgGr
        '
        Me.fgGr.AllowEditing = False
        Me.fgGr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgGr.BackColor = System.Drawing.Color.White
        Me.fgGr.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgGr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgGr.ForeColor = System.Drawing.Color.Teal
        Me.fgGr.Location = New System.Drawing.Point(10, 46)
        Me.fgGr.Name = "fgGr"
        Me.fgGr.Rows.Count = 1
        Me.fgGr.Rows.DefaultSize = 22
        Me.fgGr.Size = New System.Drawing.Size(829, 92)
        Me.fgGr.StyleInfo = resources.GetString("fgGr.StyleInfo")
        Me.fgGr.TabIndex = 3
        '
        'tbBienesVehiculos
        '
        Me.tbBienesVehiculos.BackColor = System.Drawing.Color.White
        Me.tbBienesVehiculos.Controls.Add(Me.btnSaveTb9_1)
        Me.tbBienesVehiculos.Controls.Add(Me.btnAtrasTab9_1)
        Me.tbBienesVehiculos.Controls.Add(Me.GroupBox14)
        Me.tbBienesVehiculos.Controls.Add(Me.GroupBox13)
        Me.tbBienesVehiculos.Location = New System.Drawing.Point(4, 40)
        Me.tbBienesVehiculos.Name = "tbBienesVehiculos"
        Me.tbBienesVehiculos.Size = New System.Drawing.Size(908, 488)
        Me.tbBienesVehiculos.TabIndex = 10
        Me.tbBienesVehiculos.Text = "Bienes Inmuebles - Vehículos"
        '
        'btnSaveTb9_1
        '
        Me.btnSaveTb9_1.Location = New System.Drawing.Point(745, 432)
        Me.btnSaveTb9_1.Name = "btnSaveTb9_1"
        Me.btnSaveTb9_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb9_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb9_1.TabIndex = 207
        Me.btnSaveTb9_1.Text = "Guardar"
        Me.btnSaveTb9_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb9_1.UseSelectable = True
        Me.btnSaveTb9_1.UseStyleColors = True
        '
        'btnAtrasTab9_1
        '
        Me.btnAtrasTab9_1.Location = New System.Drawing.Point(648, 432)
        Me.btnAtrasTab9_1.Name = "btnAtrasTab9_1"
        Me.btnAtrasTab9_1.Size = New System.Drawing.Size(90, 32)
        Me.btnAtrasTab9_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTab9_1.TabIndex = 206
        Me.btnAtrasTab9_1.Text = "Atras"
        Me.btnAtrasTab9_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTab9_1.UseSelectable = True
        Me.btnAtrasTab9_1.UseStyleColors = True
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
        Me.GroupBox14.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(823, 197)
        Me.GroupBox14.TabIndex = 1
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Vehículos"
        '
        'btEditVh1
        '
        Me.btEditVh1.Location = New System.Drawing.Point(104, 22)
        Me.btEditVh1.Name = "btEditVh1"
        Me.btEditVh1.Size = New System.Drawing.Size(90, 32)
        Me.btEditVh1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditVh1.TabIndex = 205
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
        Me.btDelVh1.TabIndex = 204
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
        Me.btNewVh1.TabIndex = 203
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
        Me.fgVehiculos.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgVehiculos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgVehiculos.ForeColor = System.Drawing.Color.Teal
        Me.fgVehiculos.Location = New System.Drawing.Point(7, 61)
        Me.fgVehiculos.Name = "fgVehiculos"
        Me.fgVehiculos.Rows.Count = 1
        Me.fgVehiculos.Rows.DefaultSize = 22
        Me.fgVehiculos.Size = New System.Drawing.Size(804, 128)
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
        Me.GroupBox13.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(825, 213)
        Me.GroupBox13.TabIndex = 0
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Bienes Inmuebles"
        '
        'btEditBI1
        '
        Me.btEditBI1.Location = New System.Drawing.Point(104, 22)
        Me.btEditBI1.Name = "btEditBI1"
        Me.btEditBI1.Size = New System.Drawing.Size(90, 32)
        Me.btEditBI1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditBI1.TabIndex = 205
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
        Me.btDelBI1.TabIndex = 204
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
        Me.btNewBI1.TabIndex = 203
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
        Me.fgBienes.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgBienes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgBienes.ForeColor = System.Drawing.Color.Teal
        Me.fgBienes.Location = New System.Drawing.Point(7, 61)
        Me.fgBienes.Name = "fgBienes"
        Me.fgBienes.Rows.Count = 1
        Me.fgBienes.Rows.DefaultSize = 22
        Me.fgBienes.Size = New System.Drawing.Size(807, 144)
        Me.fgBienes.StyleInfo = resources.GetString("fgBienes.StyleInfo")
        Me.fgBienes.TabIndex = 3
        '
        'lbl
        '
        Me.lbl.BackColor = System.Drawing.Color.White
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Teal
        Me.lbl.Location = New System.Drawing.Point(365, 24)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(250, 20)
        Me.lbl.TabIndex = 148
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.BackColor = System.Drawing.Color.LightGray
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(864, 36)
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.ReadOnly = True
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(122, 22)
        Me.txtCodTipoAhorro.TabIndex = 6
        Me.txtCodTipoAhorro.Visible = False
        '
        'txtGeneraReserva
        '
        Me.txtGeneraReserva.BackColor = System.Drawing.Color.LightGray
        Me.txtGeneraReserva.Location = New System.Drawing.Point(839, 36)
        Me.txtGeneraReserva.Name = "txtGeneraReserva"
        Me.txtGeneraReserva.ReadOnly = True
        Me.txtGeneraReserva.Size = New System.Drawing.Size(19, 22)
        Me.txtGeneraReserva.TabIndex = 5
        Me.txtGeneraReserva.Visible = False
        '
        'txtIntMora
        '
        Me.txtIntMora.BackColor = System.Drawing.Color.LightGray
        Me.txtIntMora.Location = New System.Drawing.Point(793, 36)
        Me.txtIntMora.Name = "txtIntMora"
        Me.txtIntMora.ReadOnly = True
        Me.txtIntMora.Size = New System.Drawing.Size(19, 22)
        Me.txtIntMora.TabIndex = 4
        Me.txtIntMora.Visible = False
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.LightGray
        Me.txtNoSocio.Location = New System.Drawing.Point(745, 36)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(19, 22)
        Me.txtNoSocio.TabIndex = 51
        Me.txtNoSocio.Visible = False
        '
        'txtCodProfdG
        '
        Me.txtCodProfdG.BackColor = System.Drawing.Color.LightGray
        Me.txtCodProfdG.Location = New System.Drawing.Point(689, 36)
        Me.txtCodProfdG.Name = "txtCodProfdG"
        Me.txtCodProfdG.ReadOnly = True
        Me.txtCodProfdG.Size = New System.Drawing.Size(19, 22)
        Me.txtCodProfdG.TabIndex = 52
        Me.txtCodProfdG.Visible = False
        '
        'txtProfdG
        '
        Me.txtProfdG.BackColor = System.Drawing.Color.LightGray
        Me.txtProfdG.Location = New System.Drawing.Point(647, 36)
        Me.txtProfdG.Name = "txtProfdG"
        Me.txtProfdG.ReadOnly = True
        Me.txtProfdG.Size = New System.Drawing.Size(19, 22)
        Me.txtProfdG.TabIndex = 53
        Me.txtProfdG.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMsCrCreditos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(962, 675)
        Me.Controls.Add(Me.txtProfdG)
        Me.Controls.Add(Me.txtCodProfdG)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.tbSolic)
        Me.Controls.Add(Me.txtIntMora)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtGeneraReserva)
        Me.Controls.Add(Me.txtCodTipoAhorro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCrCreditos"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Solicitud de Crédito "
        Me.tbSolic.ResumeLayout(False)
        Me.tbEntrega.ResumeLayout(False)
        Me.tbEntrega.PerformLayout()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoSolicitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuiE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNitE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRecibido.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbDatGralIII.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        CType(Me.txtTasaMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTasaDPF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRefFam.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.fgRefFam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.fgRefPer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbIngGas.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.fgGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        CType(Me.fgIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbObligObs.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        CType(Me.fgObsxAnal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        CType(Me.fgOblig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRefPers.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.fgRefBan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.fgRefCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbGarantias.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        CType(Me.fgCd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox19.ResumeLayout(False)
        CType(Me.fgFd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox18.ResumeLayout(False)
        CType(Me.fgGr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBienesVehiculos.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        CType(Me.fgVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        CType(Me.fgBienes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Declaraciones"

    Public pNumSolicitud As Long, pCodEnlace As Long, pCorrelativo As Long, pAccion As String, pTab As Integer, vCarga As Boolean
    Private vnosolic As String 'revisar

#End Region
    '==========================
    'Modificaion 12/03/2014
    'Javier Martinez
    Dim tab2 As Boolean
    Dim tab3 As Boolean
    Dim tab4 As Boolean
    Dim datosPendientes As Boolean
    '===========================


    Public Sub llenarEstadoCivil()
        Dim dts As New DataSet
        Me.cbEstadoCivilE.DisplayMember = "Descripcion"
        Me.cbEstadoCivilE.ValueMember = "idCatalogo"
        dts = clientes.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoCivil,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoCivilE.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub frmMsCrCreditos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.cbFormaPagoP2.SelectedIndex = 1
            Me.txtSucursal.Visible = False
            Me.txtCodSuc.Enabled = False
            Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, x As Integer
            Dim oPl As New wrPlanilla.wsLibPlanilla, vTipoGar As String

            Me.dtpFecEnt.Value = Now
            Me.dtpFecConc.Value = Now
            Me.dtpFecRec.Value = Now


            vTipoGar = ""
            Me.cbConclusion.SelectedIndex = 0
            Me.ControlTab(False, False)
            vCarga = False
            llenarEstadoCivil()
            Me.cbEstado.SelectedIndex = 3

            If Me.pAccion = "Modificar" Then
                '""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
                '""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
                recuperarDatosPrestamo(pNumSolicitud)
                '""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
                '""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
                ds = oPerif.ConsultarSolCred("*", "Correlativo=" & pCorrelativo & "", "Correlativo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtNombresE.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres"))
                    Me.txtApe1E.Text = IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1"))
                    Me.txtApe2E.Text = IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                    Me.txtApe3E.Text = IIf(IsDBNull(Filas.Item(0)("Apellido3")), "", Filas.Item(0)("Apellido3"))
                    Me.txtTelCasaE.Text = IIf(IsDBNull(Filas.Item(0)("Tels")), "", Filas.Item(0)("Tels"))
                    Me.txtCelular.Text = IIf(IsDBNull(Filas.Item(0)("Celular")), "", Filas.Item(0)("Celular"))
                    Me.txtDirE.Text = IIf(IsDBNull(Filas.Item(0)("Direccion")), "", Filas.Item(0)("Direccion"))
                    Me.dtpFecEnt.Value = IIf(IsDBNull(Filas.Item(0)("FechaEntrega")), Now, Filas.Item(0)("FechaEntrega"))
                    Me.txtLugTrabE.Text = IIf(IsDBNull(Filas.Item(0)("LugarTrabajo")), "", Filas.Item(0)("LugarTrabajo"))
                    Me.txtTelOficE.Text = IIf(IsDBNull(Filas.Item(0)("TelsTrabajo")), "", Filas.Item(0)("TelsTrabajo"))

                    Me.cbEstadoCivilE.SelectedValue = IIf(IsDBNull(Filas.Item(0)("EstadoCivil")), 0, Filas.Item(0)("EstadoCivil"))

                    Me.txtDestino.Text = IIf(IsDBNull(Filas.Item(0)("Destino")), "", Filas.Item(0)("Destino"))
                    Me.txtMontoSolicitado.Value = IIf(IsDBNull(Filas.Item(0)("MontoSolicitado")), 0, Filas.Item(0)("MontoSolicitado"))
                    Me.txtPlazo.Value = IIf(IsDBNull(Filas.Item(0)("Plazo")), 0, Filas.Item(0)("Plazo"))
                    Me.txtTasaInteres.Text = IIf(IsDBNull(Filas.Item(0)("Interes")), 0, Filas.Item(0)("Interes"))

                    Me.txtNitE.Value = IIf(IsDBNull(Filas.Item(0)("Nit")), "", Filas.Item(0)("Nit"))
                    Me.chkAsociado.Checked = IIf(IsDBNull(Filas.Item(0)("Asociado")), False, IIf(Filas.Item(0)("Asociado") = "1", True, False))
                    Me.txtDuiE.Value = IIf(IsDBNull(Filas.Item(0)("Dui")), "", Filas.Item(0)("Dui"))

                    Me.txtCodTipoCredito.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoCredito")), "", Filas.Item(0)("CodTipoCredito"))
                    Me.chkRecibida.Checked = IIf(IsDBNull(Filas.Item(0)("Recibida")), False, IIf(Filas.Item(0)("Recibida") = "1", True, False))
                    Me.ControlTab(Me.chkRecibida.Checked, True)
                    Me.ControlTabDat(False)
                    Me.txtCodEjecMercadeoE.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecutivo")), "", Filas.Item(0)("CodEjecutivo"))
                    Me.txtNoSolic.Text = IIf(IsDBNull(Filas.Item(0)("NumSolicitud")), 0, Filas.Item(0)("NumSolicitud"))

                    ds = oPerif.ConsultarTipoCreditos("*", "CodTipoCredito='" & Trim(Me.txtCodTipoCredito.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtTipoCredito.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    End If

                    ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecMercadeoE.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                            Me.txtEjecMercadeoE.Text = CStr(Filas.Item(0)("CodEmpleado"))
                            ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeoE.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                            Filas = ds.Tables(0).Rows()
                            If Filas.Count > 0 Then
                                Me.txtEjecMercadeoE.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                            End If
                        End If
                    End If

                    ds = oPerif.ConsultarSolCredR("*", "NumSolicitud = " & Me.pNumSolicitud & "", "NumSolicitud", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.dtpFecRec.Value = IIf(IsDBNull(Filas.Item(0)("FechaSol")), Now, Filas.Item(0)("FechaSol"))
                        Me.txtCodSuc.Text = IIf(IsDBNull(Filas.Item(0)("CodSucursal")), "", Filas.Item(0)("CodSucursal"))
                        If Trim(IIf(IsDBNull(Filas.Item(0)("Estado")), "", Filas.Item(0)("Estado"))) = "M" Then
                            vCarga = True
                            Me.cbEstado.SelectedIndex = 6
                            Me.cbEstado.Enabled = False
                            lbl.Text = "Solicitud Activada."
                        Else
                            vCarga = False
                            lbl.Text = "Solicitud NO Activada."
                        End If
                        For x = 0 To Me.cbEstado.Items.Count - 1
                            Me.cbEstado.SelectedIndex = x
                            If Mid(Me.cbEstado.Text, 2, 1) = IIf(IsDBNull(Filas.Item(0)("Estado")), "", Filas.Item(0)("Estado")) Then
                                Me.cbEstado.SelectedIndex = x
                                Exit For
                            End If
                        Next
                        If Trim(IIf(IsDBNull(Filas.Item(0)("Estado")), "", Filas.Item(0)("Estado"))) = "M" Then Me.cbEstado.Enabled = False
                        For x = 0 To Me.cbConclusion.Items.Count - 1
                            Me.cbConclusion.SelectedIndex = x
                            If Mid(Me.cbConclusion.Text, 2, 1) = IIf(IsDBNull(Filas.Item(0)("Conclusion")), "", Filas.Item(0)("Conclusion")) Then
                                Me.cbConclusion.SelectedIndex = x
                                Exit For
                            End If
                        Next
                        Me.dtpFecConc.Value = IIf(IsDBNull(Filas.Item(0)("FechaConclusion")), Now, Filas.Item(0)("FechaConclusion"))
                        Me.txtCodEjecMercR.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecMercadeo")), "", Filas.Item(0)("CodEjecMercadeo"))
                        Me.txtCodEjecAp.Text = IIf(IsDBNull(Filas.Item(0)("CodEjecApertura")), "", Filas.Item(0)("CodEjecApertura"))
                        Me.txtObs.Text = IIf(IsDBNull(Filas.Item(0)("Observacion")), "", Filas.Item(0)("Observacion"))

                        ds = oAsoc.ConsultarSucursales("*", "CodSucursal='" & Trim(Me.txtCodSuc.Text) & "'", "", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            If Not (Filas.Item(0)("CodSucursal") Is DBNull.Value) Then
                                Me.txtSucursal.Text = CStr(Filas.Item(0)("Nom_Sucursal"))
                            End If
                        End If

                        ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecMercR.Text) & "'", "", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                                ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Filas.Item(0)("CodEmpleado") & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                                Filas = ds.Tables(0).Rows()
                                If Filas.Count > 0 Then
                                    Me.txtEjecMercR.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                                End If
                            End If
                        End If

                        ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecAp.Text) & "'", "", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                                Me.txtCodEjecAp.Text = CStr(Filas.Item(0)("CodEjecMercadeo"))
                                ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Filas.Item(0)("CodEmpleado") & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                                Filas = ds.Tables(0).Rows()
                                If Filas.Count > 0 Then
                                    Me.txtNomCodEjecAp.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                                End If
                            End If
                        End If


                        'Modificación 12 03 2014
                        'Javier Martinez
                        If Me.chkRecibida.Checked = False Then
                            Dim dtsDatosGeneral As New DataSet
                            dtsDatosGeneral = oPerif.ConsultarDatGral("numSolicitud", "NumSolicitud = '" & pNumSolicitud & "'", "", sUsuario, sPassword, sSucursal)
                            If dtsDatosGeneral.Tables.Count > 0 Then
                                If dtsDatosGeneral.Tables(0).Rows.Count = 0 Then
                                    datosPendientes = True
                                    dtsDatosAsoc = Creditos.ConsultarDatosAsociado(Me.txtDuiE.Text.Trim)
                                    If dtsDatosAsoc.Tables.Count > 0 Then
                                        If dtsDatosAsoc.Tables(0).Rows.Count > 0 Then
                                            '======================================================================================
                                            'Pestaña1
                                            'Información Personal
                                            Me.txtNombresE.Text = dtsDatosAsoc.Tables(0).Rows(0).Item("nombres")
                                            Me.txtApe1E.Text = dtsDatosAsoc.Tables(0).Rows(0).Item("apellido1")
                                            Me.txtApe2E.Text = dtsDatosAsoc.Tables(0).Rows(0).Item("apellido2")
                                            Me.cbEstadoCivilE.SelectedIndex = dtsDatosAsoc.Tables(0).Rows(0).Item("EstadoCivil")
                                            Me.txtApe3E.Text = dtsDatosAsoc.Tables(0).Rows(0).Item("apellidoCas")
                                            Me.txtNitE.Text = dtsDatosAsoc.Tables(0).Rows(0).Item("NIT")
                                            Me.txtTelCasaE.Text = dtsDatosAsoc.Tables(0).Rows(0).Item("TelCasa")
                                            Me.txtCelular.Text = dtsDatosAsoc.Tables(0).Rows(0).Item("celular")
                                            Me.txtDirE.Text = dtsDatosAsoc.Tables(0).Rows(0).Item("Direccion")
                                            Me.txtLugTrabE.Text = dtsDatosAsoc.Tables(0).Rows(0).Item("LugarTrabajo")
                                            Me.txtTelOficE.Text = dtsDatosAsoc.Tables(0).Rows(0).Item("TelOficina")
                                            Me.chkAsociado.Checked = True
                                            '======================================================================================

                                        End If
                                    End If
                                End If
                            End If

                        ElseIf Me.chkRecibida.Checked = True Then
                            ds = oPerif.ConsultarDatGral("*", "NumSolicitud= " & Me.pNumSolicitud & "", "NumSolicitud", sUsuario, sPassword, sSucursal)
                            Filas = ds.Tables(0).Rows()
                            If Filas.Count > 0 Then
                                Me.pCodEnlace = IIf(IsDBNull(Filas.Item(0)("CodEnlace")), 0, Filas.Item(0)("CodEnlace"))
                                Me.txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                                Me.txtCodProfdG.Text = IIf(IsDBNull(Filas.Item(0)("CodProfesion")), "", Filas.Item(0)("CodProfesion"))
                                If Me.txtNombresE.Text.Trim = "" Then CargarDatos()

                                ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtCodProfdG.Text) & "'", "", sUsuario, sPassword, sSucursal)
                                Filas = ds.Tables(0).Rows()
                                If Filas.Count > 0 Then
                                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                                        Me.txtProfdG.Text = CStr(Filas.Item(0)("Descripcion"))
                                    End If
                                End If

                                If Me.chkAsociado.Checked = True Then
                                    ds = oAsoc.ConsultarAsociado("NoSocio", "Dui='" & Me.txtDuiE.Value & "'", "DUI", sUsuario, sPassword, sSucursal)
                                    Filas = ds.Tables(0).Rows()
                                    If Filas.Count > 0 Then Me.txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                                End If
                                Me.ControlTabDat(Me.chkRecibida.Checked)

                                ds = oPerif.ConsultarSolP2Credito("*", "NumSolicitud=" & Me.pNumSolicitud & "", "NumSolicitud", sUsuario, sPassword, sSucursal)
                                Filas = ds.Tables(0).Rows()
                                If Filas.Count > 0 Then
                                    Me.txtCodTipoCredP2.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoCredito")), "", Filas.Item(0)("CodTipoCredito"))
                                    Me.txtDestinoP2.Text = IIf(IsDBNull(Filas.Item(0)("Destino")), "", Filas.Item(0)("Destino"))
                                    Me.cbFormaPagoP2.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("FormaPago")), "", Filas.Item(0)("FormaPago"))
                                    Me.C1NEMonto.Value = IIf(IsDBNull(Filas.Item(0)("MontoSolicitado")), 0, Filas.Item(0)("MontoSolicitado"))
                                    Me.C1NEPlazo.Value = IIf(IsDBNull(Filas.Item(0)("Plazo")), 0, Filas.Item(0)("Plazo"))
                                    Me.txtDiaPago.Value = IIf(IsDBNull(Filas.Item(0)("DiaMesPago")), 0, Filas.Item(0)("DiaMesPago"))
                                    Me.c1nTasa.Value = IIf(IsDBNull(Filas.Item(0)("Interes")), 0, Filas.Item(0)("Interes"))
                                    Me.c1nCuota.Value = IIf(IsDBNull(Filas.Item(0)("CuotaTotal")), 0, Filas.Item(0)("CuotaTotal"))
                                    Me.txtCodPagaduria.Text = IIf(IsDBNull(Filas.Item(0)("CodPagaduria")), "", Filas.Item(0)("CodPagaduria"))
                                Else
                                    Me.txtCodTipoCredP2.Text = Me.txtCodTipoCredito.Text
                                    Me.txtDestinoP2.Text = Me.txtDestino.Text
                                    Me.c1nTasa.Value = Me.txtTasaInteres.Text
                                    Me.C1NEMonto.Value = Me.txtMontoSolicitado.Value
                                    Me.C1NEPlazo.Value = Me.txtPlazo.Value
                                End If

                                ds = oPerif.ConsultarTipoCreditos("*", "CodTipoCredito='" & Trim(Me.txtCodTipoCredP2.Text) & "'", "", sUsuario, sPassword, sSucursal)
                                Filas = ds.Tables(0).Rows()
                                If Filas.Count > 0 Then
                                    Me.txtTipoCredP2.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                                    vTipoGar = IIf(IsDBNull(Filas.Item(0)("CodTipoGarantias")), "", Filas.Item(0)("CodTipoGarantias"))
                                    If vTipoGar.Trim = "00002" Then Puntos_DPF()
                                    Me.txtIntMora.Text = IIf(IsDBNull(Filas.Item(0)("InteresMoratorio")), "", Filas.Item(0)("InteresMoratorio"))
                                End If

                                ds = oPerif.ConsultarPagaduria("*", "CodPagaduria='" & Trim(Me.txtCodPagaduria.Text) & "'", "", sUsuario, sPassword, sSucursal)
                                Filas = ds.Tables(0).Rows()
                                If Filas.Count > 0 Then
                                    Me.txtPagaduria.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                                    Me.lblCategoria.Text = IIf(IsDBNull(Filas.Item(0)("categoria")), "Pendiente Evaluar", Filas.Item(0)("categoria"))
                                End If

                                ds = oPerif.ConsultarRefFamiliar("Correlativo,NumSolicitud,Nombre + ' ' + Apellido1 + ' ' + Apellido2 + ' ' + Apellido3 as Nombre,Direccion,TelCasa,LugarTrabajo,DireccionTrabajo,Cargo,TelOficina,CodEnlace,CodParentesco,Otro,Celular", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                                Me.fgRefFam.DataSource = ds.Tables(0)

                                ds = oPerif.ConsultarRefPersonal("Correlativo,NumSolicitud,Nombre + ' ' + Apellido1 + ' ' + Apellido2 + ' ' + Apellido3 as Nombre,Direccion,TelCasa,LugarTrabajo,DireccionTrabajo,Cargo,TelOficina,CodEnlace", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                                Me.fgRefPer.DataSource = ds.Tables(0)

                                ds = oPerif.ConsultarRefBancaria("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                                Me.fgRefBan.DataSource = ds.Tables(0)

                                ds = oPerif.ConsultarRefComercial("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                                Me.fgRefCom.DataSource = ds.Tables(0)

                                ds = oPerif.ConsultarIngresos("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                                Me.fgIngresos.DataSource = ds.Tables(0)
                                ActualizaGridIng()

                                ds = oPerif.ConsultarGastos("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                                Me.fgGastos.DataSource = ds.Tables(0)
                                ActualizaGridGt()

                                ds = oPerif.ConsultarBienInmueble("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                                Me.fgBienes.DataSource = ds.Tables(0)

                                ds = oPerif.ConsultarVehiculos("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                                Me.fgVehiculos.DataSource = ds.Tables(0)

                                ds = oPerif.ConsultarObligaciones("*", "CodEnlace=" & pCodEnlace & "", "Correlativo", sUsuario, sPassword, sSucursal)
                                Me.fgOblig.DataSource = ds.Tables(0)

                                ds = oPerif.ConsultarObservacionesxAnalisis("*", "NumSolicitud=" & Me.pNumSolicitud & "", "Correlativo", sUsuario, sPassword, sSucursal)
                                Me.fgObsxAnal.DataSource = ds.Tables(0)

                                ds = oPerif.ConsultarGarantias("*", "CodEnlace=" & pCodEnlace & "", "CodGarantia", sUsuario, sPassword, sSucursal)
                                Me.fgGr.DataSource = ds.Tables(0)

                                ds = oPerif.ConsultarDatGral("*", "NumSolicitud=" & Me.pNumSolicitud & " and Fiador='1'", "CodEnlace", sUsuario, sPassword, sSucursal)
                                Me.fgFd.DataSource = ds.Tables(0)

                                ds = oPerif.ConsultarDatGral("*", "NumSolicitud=" & Me.pNumSolicitud & " and Fiador='2'", "CodEnlace", sUsuario, sPassword, sSucursal)
                                Me.fgCd.DataSource = ds.Tables(0)

                            Else

                                ds = oAsoc.ConsultarAsociado("NoSocio", "Dui='" & Me.txtDuiE.Value & "'", "Dui", sUsuario, sPassword, sSucursal)
                                Filas = ds.Tables("Cat_Asociados").Rows
                                If Filas.Count > 0 Then
                                    If Not (Filas.Item(0)("NoSocio") Is DBNull.Value) Then
                                        Me.txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio"))
                                    End If
                                End If


                                Me.txtCodTipoCredP2.Text = Me.txtCodTipoCredito.Text
                                Me.txtDestinoP2.Text = Me.txtDestino.Text
                                Me.c1nTasa.Value = Me.txtTasaInteres.Text
                                Me.C1NEMonto.Value = Me.txtMontoSolicitado.Value
                                Me.C1NEPlazo.Value = Me.txtPlazo.Value

                                ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtCodProfdG.Text) & "'", "", sUsuario, sPassword, sSucursal)
                                Filas = ds.Tables(0).Rows()
                                If Filas.Count > 0 Then
                                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                                        Me.txtProfdG.Text = CStr(Filas.Item(0)("Descripcion"))
                                    End If
                                End If

                            End If
                        End If
                    End If
                End If
                '=========================================================================
                '18/04/2012 Javier Escobar
                'Deshabilitamos el control para que no puedan modificar al ejecutivo
                If Me.txtCodEjecMercR.Text.Trim.Equals("") = False Then
                    Me.txtCodEjecAp.ReadOnly = True
                    Me.txtCodEjecAp.Enabled = False
                    Me.txtCodEjecMercadeoE.ReadOnly = True
                    Me.txtCodEjecMercadeoE.Enabled = False
                    Me.txtCodEjecMercR.ReadOnly = True
                    Me.txtCodEjecMercR.Enabled = False
                    Me.txtEjecMercR.Enabled = False
                    Me.txtEjecMercadeoE.Enabled = False
                    Me.txtNomCodEjecAp.Enabled = False
                End If
                '=========================================================================
                If Me.btnSaveTb1_1.Enabled = False Then Me.EnabledTabs(False)
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodEjecMercadeoE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecMercadeoE.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim oAsoc As New wrAsociados.wsLibAsoc
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim oPl As New wrPlanilla.wsLibPlanilla, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Try
                ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecMercadeoE.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtEjecMercadeoE.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeoE.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtEjecMercadeoE.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                            txtCodSuc.Text = IIf(IsDBNull(Filas.Item(0)("codSucursal")), "01", Filas.Item(0)("codSucursal"))
                        End If
                        txtCodTipoCredito.Focus()
                    End If
                Else
                    txtCodEjecMercadeoE_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub txtCodEjecMercadeoE_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecMercadeoE.DoubleClick

        Dim ofrm As New frmAGenerico
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet ', Filas As Data.DataRowCollection

        ofrm.Text = "Buscar Ejecutivos de Mercadeo"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecMercadeoE.Text = ofrm.Resultado.Trim
            txtEjecMercadeoE.Text = ofrm.Resultado2.Trim
            txtCodSuc.Text = ofrm.Resultado4.Trim
            txtCodTipoCredito.Focus()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodTipoCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoCredito.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection, oApp As New wrAdmin.wsLibAdmin
            Try
                oPerif = New wrCredito.wsLibCred
                ds = oPerif.ConsultarTipoCreditos("*", "CodTipoCredito='" & Trim(txtCodTipoCredito.Text) & "' and ((FechaIniProm<='" & oApp.Fecha.ToShortDateString & "' and FechaFinProm>='" & oApp.Fecha.ToShortDateString & "' and Promocion='1') or (Promocion<>'1' or Promocion is null))", "CodTipoCredito", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtTipoCredito.Text = CStr(Filas.Item(0)("Descripcion"))
                        txtTasaInteres.Text = CStr(Filas.Item(0)("interesActual"))
                        Me.txtMontoSolicitado.Focus()
                    End If
                Else
                    Me.txtCodTipoCredito.Text = ""
                    Me.txtTipoCredito.Text = ""
                End If

            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub txtCodTipoCredito_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoCredito.DoubleClick

        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipo de Crédito"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, oApp As New wrAdmin.wsLibAdmin
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipoCreditos("CodTipoCredito,Descripcion,PlazoMaximo,interesActual,interesMoratorio", "(FechaIniProm<='" & oApp.Fecha.ToShortDateString & "' and FechaFinProm>='" & oApp.Fecha.ToShortDateString & "' and Promocion='1') or (Promocion<>'1' or Promocion is null)", "CodTipoCredito", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoCredito.Text = ofrm.Resultado.Trim
            txtTipoCredito.Text = ofrm.Resultado2.Trim
            txtTasaInteres.Text = ofrm.Resultado4.Trim
            txtTasaMora.Value = ofrm.Resultado5
            txtMontoSolicitado.Focus()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ControlTab(ByVal pValor As Boolean, ByVal pTb As Boolean)
        Me.tbSolic.TabPages(1).Enabled = pTb
        Me.tbSolic.TabPages(2).Enabled = pValor
        Me.tbSolic.TabPages(3).Enabled = pValor
        Me.tbSolic.TabPages(4).Enabled = pValor
        Me.tbSolic.TabPages(5).Enabled = pValor
        Me.tbSolic.TabPages(6).Enabled = pValor
        Me.tbSolic.TabPages(7).Enabled = pValor
        Me.tbSolic.TabPages(8).Enabled = pValor
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

    Private Sub ActualizaGridRefFam()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarRefFamiliar("Correlativo,NumSolicitud,Nombre + ' ' + Apellido1 + ' ' + Apellido2 + ' ' + Apellido3 as Nombre,Direccion,TelCasa,LugarTrabajo,DireccionTrabajo,Cargo,TelOficina,CodEnlace,CodParentesco,Otro,Celular", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

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
            Me.fgRefFam.Cols.Item(10).Caption = "Parentesco"
            Me.fgRefFam.Cols.Item(11).Caption = "Otro"
            Me.fgRefFam.Cols.Item(12).Caption = "Celular"

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
            Me.fgRefFam.Cols.Item(10).Width = 77
            Me.fgRefFam.Cols.Item(11).Width = 77
            Me.fgRefFam.Cols.Item(12).Width = 77

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub


    Public Sub ControlTabDat(ByVal pValor As Boolean)
        Me.tbSolic.TabPages(3).Enabled = pValor
        Me.tbSolic.TabPages(4).Enabled = pValor
        Me.tbSolic.TabPages(5).Enabled = pValor
        Me.tbSolic.TabPages(6).Enabled = pValor
        Me.tbSolic.TabPages(7).Enabled = pValor
        Me.tbSolic.TabPages(8).Enabled = pValor

    End Sub

    Private Sub txtCodProfdG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Try
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtCodProfdG.Text) & "'", "CodProfesion", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtProfdG.Text = CStr(Filas.Item(0)("Descripcion"))

                    End If
                Else
                    txtCodProfdG_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub txtCodProfdG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

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
            chkAsociado.Focus()
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
            ds = oCred.ConsultarRefPersonal("Correlativo,NumSolicitud,Nombre + ' ' + Apellido1 + ' ' + Apellido2 + ' ' + Apellido3 as Nombre,Direccion,TelCasa,LugarTrabajo,DireccionTrabajo,Cargo,TelOficina,CodEnlace", "CodEnlace='" & pCodEnlace & "'", "Correlativo", sUsuario, sPassword, sSucursal)

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
        Dim dr As DataRow, vTotal As Double

        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarIngresos("Descrip", "a.CodEnlace='" & pCodEnlace & "'", "a.Correlativo", sUsuario, sPassword, sSucursal)
            For Each dr In ds.Tables(0).Rows
                vTotal = vTotal + dr("Monto")
            Next
            Me.lblTotalIng.Text = "Total: $" & Format(Math.Round(vTotal, 2), "##,###,###.00")

            Me.fgIngresos.DataSource = ds.Tables(0)
            Me.fgIngresos.Cols.Item(0).Caption = "Correlativo"
            Me.fgIngresos.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgIngresos.Cols.Item(2).Caption = "Cód. Tipo Ingreso"
            Me.fgIngresos.Cols.Item(3).Caption = "Tipo Ingreso"
            Me.fgIngresos.Cols.Item(4).Caption = "Monto"
            Me.fgIngresos.Cols.Item(5).Caption = "Cód. Enlace"
            Me.fgIngresos.Cols.Item(6).Caption = "Verificado"
            Me.fgIngresos.Cols.Item(7).Caption = "Declara Renta"
            Me.fgIngresos.Cols.Item(8).Caption = "Constancia"
            Me.fgIngresos.Cols.Item(9).Caption = "Estados Financieros"
            Me.fgIngresos.Cols.Item(10).Caption = "Declaraciones IVA"
            Me.fgIngresos.Cols.Item(11).Caption = "Visita Campo"

            Me.fgIngresos.Cols.Item(0).Width = 77
            Me.fgIngresos.Cols.Item(1).Width = 77
            Me.fgIngresos.Cols.Item(2).Width = 100
            Me.fgIngresos.Cols.Item(3).Width = 100
            Me.fgIngresos.Cols.Item(4).Width = 77
            Me.fgIngresos.Cols.Item(5).Width = 77
            Me.fgIngresos.Cols.Item(6).Width = 77
            Me.fgIngresos.Cols.Item(7).Width = 77
            Me.fgIngresos.Cols.Item(8).Width = 77
            Me.fgIngresos.Cols.Item(9).Width = 77
            Me.fgIngresos.Cols.Item(10).Width = 77
            Me.fgIngresos.Cols.Item(11).Width = 77

            Me.fgIngresos.Cols.Item(4).Format = "##0.00"

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub ActualizaGridGt()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Dim dr As DataRow, vTotal As Double
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGastos("Descrip", "a.CodEnlace='" & pCodEnlace & "'", "a.Correlativo", sUsuario, sPassword, sSucursal)
            For Each dr In ds.Tables(0).Rows
                vTotal = vTotal + dr("Monto")
            Next
            Me.lblTotal.Text = "Total: $" & Format(Math.Round(vTotal, 2), "##,###,###.00")

            Me.fgGastos.DataSource = ds.Tables(0)
            Me.fgGastos.Cols.Item(0).Caption = "Correlativo"
            Me.fgGastos.Cols.Item(1).Caption = "No. Solicitud"
            Me.fgGastos.Cols.Item(2).Caption = "Cód. Tipo Gasto"
            Me.fgGastos.Cols.Item(3).Caption = "Tipo de Gasto"
            Me.fgGastos.Cols.Item(4).Caption = "Monto"
            Me.fgGastos.Cols.Item(5).Caption = "Cód. Enlace"

            Me.fgGastos.Cols.Item(4).Format = "##0.00"
            Me.fgGastos.Cols.Item(0).Width = 77
            Me.fgGastos.Cols.Item(1).Width = 77
            Me.fgGastos.Cols.Item(2).Width = 100
            Me.fgGastos.Cols.Item(3).Width = 100
            Me.fgGastos.Cols.Item(4).Width = 77
            Me.fgGastos.Cols.Item(5).Width = 77

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub fgGastos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgGastos.DoubleClick
        'Me.btEditGt_Click(sender, e)
    End Sub

    Private Sub fgIngresos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgIngresos.DoubleClick
        Me.btEditIng1_Click(sender, e)
    End Sub

    Private Sub fgVehiculos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgVehiculos.DoubleClick
        Me.btEditVh1_Click(sender, e)
    End Sub




    Private Sub fgBienes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgBienes.DoubleClick
        Me.btEditBI1_Click(sender, e)
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



    Private Sub fgObsxAnal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgObsxAnal.DoubleClick
        Me.btEditOA1_Click(sender, e)
    End Sub



    Private Sub ActualizaGridOA()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarObservacionesxAnalisis("*", "NumSolicitud='" & Me.pNumSolicitud & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgObsxAnal.DataSource = ds.Tables(0)


        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub txtCodEjecMercR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecMercR.DoubleClick

        Dim ofrm As New frmAGenerico
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet ', Filas As Data.DataRowCollection

        ofrm.Text = "Buscar Ejecutivos de Mercadeo"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecMercR.Text = ofrm.Resultado.Trim
            txtEjecMercR.Text = ofrm.Resultado2.Trim
            txtCodSuc.Text = ofrm.Resultado4.Trim
            btnAtrasTb2_1.Focus()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodEjecMercR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecMercR.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim oPl As New wrPlanilla.wsLibPlanilla
            Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Try
                ds = oPerif.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecMercR.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtEjecMercR.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        Me.txtCodSuc.Text = Filas.Item(0)("codSucursal")
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercR.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtEjecMercR.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                        txtCodTipoCredito.Focus()
                    End If
                Else
                    txtCodEjecMercR_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtCodTipoCredP2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoCredP2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection, oApp As New wrAdmin.wsLibAdmin
            Try
                oPerif = New wrCredito.wsLibCred
                ds = oPerif.ConsultarTipoCreditos("*", "CodTipoCredito='" & Trim(Me.txtCodTipoCredP2.Text) & "' and ((FechaIniProm<='" & oApp.Fecha.ToShortDateString & "' and FechaFinProm>='" & oApp.Fecha.ToShortDateString & "' and Promocion='1') or (Promocion<>'1' or Promocion is null))", "CodTipoCredito", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtTipoCredP2.Text = CStr(Filas.Item(0)("Descripcion"))
                        Me.c1nTasa.Value = IIf(IsDBNull(Filas.Item(0)("InteresActual")), 0, Filas.Item(0)("InteresActual"))
                        Me.txtIntMora.Text = IIf(IsDBNull(Filas.Item(0)("InteresMoratorio")), "", Filas.Item(0)("InteresMoratorio"))
                        Me.txtGeneraReserva.Text = IIf(IsDBNull(Filas.Item(0)("GeneraReserva")), "", Filas.Item(0)("GeneraReserva"))
                        If IIf(IsDBNull(Filas.Item(0)("CodTipoGarantias")), "", Filas.Item(0)("CodTipoGarantias")) = "00002" Then
                            Puntos_DPF()
                        End If
                        btnSigTb1_1.Focus()
                    End If
                Else
                    Me.txtCodTipoCredP2.Text = ""
                    Me.txtTipoCredP2.Text = ""
                End If

            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtCodTipoCredP2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoCredP2.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipo de Crédito"
        Dim oPerif As wrCredito.wsLibCred, ds As New Data.DataSet, oApp As New wrAdmin.wsLibAdmin

        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipoCreditos("CodTipoCredito as Codigo,Descripcion,InteresActual as Tasa_Interes,InteresMoratorio,GeneraReserva,CodTipoGarantias", "(FechaIniProm<='" & oApp.Fecha.ToShortDateString & "' and FechaFinProm>='" & oApp.Fecha.ToShortDateString & "' and Promocion='1') or (Promocion<>'1' or Promocion is null)", "CodTipoCredito", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodTipoCredP2.Text = ofrm.Resultado.Trim
            Me.txtTipoCredP2.Text = ofrm.Resultado2.Trim
            Me.c1nTasa.Value = ofrm.Resultado3.Trim
            Me.txtIntMora.Text = ofrm.Resultado4.Trim
            Me.txtGeneraReserva.Text = ofrm.Resultado5.Trim
            If ofrm.Resultado6.Trim = "00002" Then
                Puntos_DPF()
            End If
            btnSigTb1_1.Focus()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Puntos_DPF() As Double
        Try
            Dim oAh As New wrAhorro.wsLibAhorro, oAsoc As New wrAsociados.wsLibAsoc, vPuntosDPF As Double
            Dim dsG As New DataSet, dr As DataRow, oCred As New wrCredito.wsLibCred, ds As New Data.DataSet

            ds = oAsoc.ConsultarParametros("*", "", "SalarioMinimo", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vPuntosDPF = IIf(IsDBNull(dr("PuntosDPF")), 0, dr("PuntosDPF"))
            End If

            dsG = oCred.ConsultarGarantias("NoCuenta", "CodTipoGarantia='00002' and NumSolicitud=" & Me.pNumSolicitud & "", "CodGarantia", sUsuario, sPassword, sSucursal)
            If dsG.Tables(0).Rows.Count > 0 Then
                dr = dsG.Tables(0).Rows(0)
                If Not dr("NoCuenta") Is DBNull.Value Then
                    dsG = oAh.ConsultarCuentaAhorro("TasaInteres", "NoCuenta='" & dr("NoCuenta") & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                    If dsG.Tables(0).Rows.Count > 0 Then
                        dr = dsG.Tables(0).Rows(0)
                        If Not dr("TasaInteres") Is DBNull.Value Then
                            Me.c1nTasaDPF.Value = dr("TasaInteres") + vPuntosDPF
                        End If
                    End If
                End If
            Else
                Me.c1nTasaDPF.Value = 0
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Function


    Private Sub ActualizaGridGr()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGarantias("*", "CodEnlace='" & pCodEnlace & "'", "CodGarantia", sUsuario, sPassword, sSucursal)

            Me.fgGr.DataSource = ds.Tables(0)
            Me.fgGr.Cols.Item(0).Caption = "Código"
            Me.fgGr.Cols.Item(1).Caption = "Descripción"
            Me.fgGr.Cols.Item(2).Caption = "No. Solicitud"
            Me.fgGr.Cols.Item(3).Caption = "Tipo Garantía"
            Me.fgGr.Cols.Item(4).Caption = "Cód. Enlace"
            Me.fgGr.Cols.Item(5).Caption = "No. Factura"
            Me.fgGr.Cols.Item(6).Caption = "No. Valúo"

            Me.fgGr.Cols.Item(0).Width = 77
            Me.fgGr.Cols.Item(1).Width = 150
            Me.fgGr.Cols.Item(2).Width = 77
            Me.fgGr.Cols.Item(3).Width = 77
            Me.fgGr.Cols.Item(4).Width = 77
            Me.fgGr.Cols.Item(5).Width = 77
            Me.fgGr.Cols.Item(6).Width = 77

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEstado.SelectedIndexChanged
        If Me.cbEstado.SelectedIndex = 6 And vCarga = False Then Me.cbEstado.SelectedIndex = 0
        Select Case Me.cbEstado.SelectedIndex
            Case 0
                Me.cbConclusion.SelectedIndex = 0
            Case 1
                Me.cbConclusion.SelectedIndex = 0
            Case 2
                Me.cbConclusion.SelectedIndex = 0
            Case 3
                Me.cbConclusion.SelectedIndex = 2
            Case 4
                Me.cbConclusion.SelectedIndex = 1
            Case 5
                Me.cbConclusion.SelectedIndex = 2
            Case 6
                Me.cbConclusion.SelectedIndex = 2
        End Select
    End Sub


    Private Sub ActualizaGridFd()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarDatGral("*", "NumSolicitud='" & pNumSolicitud & "' and Fiador='1'", "CodEnlace", sUsuario, sPassword, sSucursal)

            Me.fgFd.DataSource = ds.Tables(0)

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ActualizaGridCd()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarDatGral("*", "NumSolicitud='" & pNumSolicitud & "' and Fiador='2'", "CodEnlace", sUsuario, sPassword, sSucursal)

            Me.fgCd.DataSource = ds.Tables(0)

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub fgGr_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgGr.DoubleClick
        Me.btEditGr1_Click(sender, e)
    End Sub

    Private Sub fgRefBan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgRefBan.DoubleClick
        Me.btEditRB1_Click(sender, e)
    End Sub

    Private Sub EnabledTabs(ByVal pValor As Boolean)
        Me.btNewRF1.Enabled = pValor
        Me.btNewRP1.Enabled = pValor
        Me.btDelRF1.Enabled = pValor
        Me.btDelRP1.Enabled = pValor
        Me.btEditRF1.Enabled = pValor
        Me.btEditRP1.Enabled = pValor
        Me.btNewRC1.Enabled = pValor
        Me.btNewRB1.Enabled = pValor
        Me.btDelRC1.Enabled = pValor
        Me.btDelRB1.Enabled = pValor
        Me.btEditRC1.Enabled = pValor
        Me.btEditRB1.Enabled = pValor
        Me.btNewIng1.Enabled = pValor
        Me.btNewGt1.Enabled = pValor
        Me.btDelIng1.Enabled = pValor
        Me.btDelGt1.Enabled = pValor
        Me.btEditIng1.Enabled = pValor
        Me.btEditGt1.Enabled = pValor
        Me.btNewBI1.Enabled = pValor
        Me.btNewVh1.Enabled = pValor
        Me.btDelBI1.Enabled = pValor
        Me.btDelVh1.Enabled = pValor
        Me.btEditBI1.Enabled = pValor
        Me.btEditVh1.Enabled = pValor
        Me.btNewOb1.Enabled = pValor
        Me.btNewOA1.Enabled = pValor
        Me.btDelOb1.Enabled = pValor
        Me.btDelOA1.Enabled = pValor
        Me.btEditOb1.Enabled = pValor
        Me.btEditOA1.Enabled = pValor
        Me.btNewGr1.Enabled = pValor
        Me.btNewFd1.Enabled = pValor
        Me.btDelGr1.Enabled = pValor
        Me.btDelFd1.Enabled = pValor
        Me.btEditGr1.Enabled = pValor
        Me.btEditFd1.Enabled = pValor
    End Sub

    Private Sub fgFd_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgFd.DoubleClick
        If Me.fgFd.Row <> -1 Then
            Dim frm As frmMsCrFiadores = New frmMsCrFiadores
            frm.pNumSolicitud = Me.pNumSolicitud
            frm.pCodEnlace = Me.fgFd.Item(Me.fgFd.Row, "CodEnlace")
            frm.pAccion = "Modificar"
            frm.btnSaveTb1_1.Text = "&Consultar"
            frm.btnSaveTb2_1.Text = "&Consultar"
            frm.btnSaveTb3_1.Text = "&Consultar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGridFd()
        End If
    End Sub



    Private Sub txtTelCasaE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelCasaE.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelCasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelOficdG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtExtOficdG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtTelOficE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelOficE.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombresE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombresE.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApe1E_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe1E.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApe2E_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe2E.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApe3E_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApe3E.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombresdG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApe1dG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApe2dG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApe3dG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtDuiE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuiE.GotFocus
        Me.txtDuiE.SelectionLength = 0
        Me.txtDuiE.SelectionStart = 0
    End Sub

    Private Sub txtDuiE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuiE.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDuiE.ValueIsDbNull, "", txtDuiE.Value)
            If Valor.Trim = "" Then
                Me.txtDuiE.SelectionStart = 0
                Me.txtDuiE.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CargarDatos()

        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            ds = oAsoc.ConsultarAsociado("*", "Dui='" & Me.txtDuiE.Text & "'", "Dui", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtDuiE.Value = IIf(IsDBNull(Filas.Item(0)("Dui")), "", Filas.Item(0)("Dui"))
                Me.txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodSuc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodSuc.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Sucursales"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            ds = oPerif.ConsultarSucursales("*", "", "CodSucursal", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodSuc.Text = ofrm.Resultado.Trim
            Me.txtSucursal.Text = ofrm.Resultado2.Trim
            Me.C1NEMonto.Focus()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPagaduria_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPagaduria.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Pagaduría"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            ds = oPerif.ConsultarPagaduria("codPagaduria,Nombre,Categoria", "", "CodPagaduria", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodPagaduria.Text = ofrm.Resultado.Trim
            Me.txtPagaduria.Text = ofrm.Resultado2.Trim
            Me.lblCategoria.Text = IIf(ofrm.Resultado3.Trim.Length = 0, "P/E", ofrm.Resultado3.Trim)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cbFormaPagoP2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFormaPagoP2.SelectedIndexChanged
        If Me.cbFormaPagoP2.SelectedIndex = 1 Then
            Me.txtCodPagaduria.ReadOnly = False
        Else
            Me.txtCodPagaduria.ReadOnly = True
        End If
        If Me.cbFormaPagoP2.SelectedIndex = 3 Then
            Me.txtNoCuenta.Enabled = True
        Else
            Me.txtNoCuenta.Enabled = False
        End If
    End Sub



    Private Sub cbEstadoCivilE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEstadoCivilE.SelectedIndexChanged
        If Me.cbEstadoCivilE.SelectedIndex = 1 Or Me.cbEstadoCivilE.SelectedIndex = 3 Then
            Me.txtApe3E.Enabled = True
        Else
            Me.txtApe3E.Enabled = False
        End If
    End Sub

    Private Sub txtCodEjecAp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecAp.DoubleClick

        Dim ofrm As New frmAGenerico
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet ', Filas As Data.DataRowCollection

        ofrm.Text = "Buscar Ejecutivos de Mercadeo"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecAp.Text = ofrm.Resultado.Trim
            txtNomCodEjecAp.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEjecAp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecAp.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim oAsoc As New wrAsociados.wsLibAsoc
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim oPl As New wrPlanilla.wsLibPlanilla, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Try
                ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecAp.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtNomCodEjecAp.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtNomCodEjecAp.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtNomCodEjecAp.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                    End If
                Else
                    txtCodEjecAp_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub txtNoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.DoubleClick
        Dim frm As New frmAGenerico, sTexto As String ', Fila As DataRowCollection,  vCodTipoAhorro As String
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow

        Try

            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarCuentaAhorroTipoAhorro("a.CodTipoAhorro,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.NoCuentaAnterior,a.FechaApertura,a.Cuota,a.SaldoDisponible_CuentaAhorro as Saldo__", "a.Dui='" & Me.txtDuiE.Value & "' and a.Estado<>'C' and a.Estado<>'B' and Estado<>'D'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
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
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaApertura,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,NoLibreta,Estado,Pignorado", "NoCuenta='" & sTexto.Trim & "' and Estado<>'C' and Estado<>'B'", "NoCuenta", sUsuario, sPassword, sSucursal)
                dr = ds.Tables("AhCuentasAhorro").Rows(0)
                Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
                Me.txtCodTipoAhorro.Text = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Dim dtsDatosAsoc As New DataSet
    Private Sub txtDuiE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuiE.LostFocus

        Try
            If Me.pAccion <> "Modificar" Then


                dtsDatosAsoc = Creditos.ConsultarDatosAsociado(Me.txtDuiE.Text.Trim)
                If dtsDatosAsoc.Tables.Count > 0 Then
                    If dtsDatosAsoc.Tables(0).Rows.Count > 0 Then
                        '======================================================================================
                        'Pestaña1
                        'Información Personal
                        Me.txtNombresE.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("nombres") Is DBNull.Value, " ", dtsDatosAsoc.Tables(0).Rows(0).Item("nombres").ToString.ToUpper)
                        Me.txtApe1E.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("apellido1") Is DBNull.Value, " ", dtsDatosAsoc.Tables(0).Rows(0).Item("apellido1").ToString.ToUpper)
                        Me.txtApe2E.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("apellido2") Is DBNull.Value, " ", dtsDatosAsoc.Tables(0).Rows(0).Item("apellido2").ToString.ToUpper)
                        If dtsDatosAsoc.Tables(0).Rows(0).Item("CodEstadoCivil") Is DBNull.Value = False Then
                            Me.cbEstadoCivilE.SelectedValue = dtsDatosAsoc.Tables(0).Rows(0).Item("CodEstadoCivil")
                        End If

                        Me.txtApe3E.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("apellidoCas") Is DBNull.Value, " ", dtsDatosAsoc.Tables(0).Rows(0).Item("apellidoCas").ToString.ToUpper)
                        Me.txtNitE.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("NIT") Is DBNull.Value, "", dtsDatosAsoc.Tables(0).Rows(0).Item("NIT"))
                        Me.txtTelCasaE.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("TelCasa") Is DBNull.Value, "", dtsDatosAsoc.Tables(0).Rows(0).Item("TelCasa"))
                        Me.txtCelular.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("celular") Is DBNull.Value, "", dtsDatosAsoc.Tables(0).Rows(0).Item("celular"))
                        Me.txtDirE.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("Direccion") Is DBNull.Value, "", dtsDatosAsoc.Tables(0).Rows(0).Item("Direccion").ToString.ToUpper)
                        Me.txtLugTrabE.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("LugarTrabajo") Is DBNull.Value, "", dtsDatosAsoc.Tables(0).Rows(0).Item("LugarTrabajo").ToString.ToUpper)
                        Me.txtTelOficE.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("TelOficina") Is DBNull.Value, "", dtsDatosAsoc.Tables(0).Rows(0).Item("TelOficina"))
                        Me.chkAsociado.Checked = True
                        '======================================================================================



                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox("Error al recuperar la información, comunicarse con el adminstrador del sistema.")
        End Try

    End Sub


    Private Sub llenarDatosAsociado(ByVal tab As Integer)
        '=====================================================================================
        'Pestaña 3 (Datos Personales)
        If Me.dtsDatosAsoc.Tables.Count > 0 Then
            If Me.dtsDatosAsoc.Tables(0).Rows.Count > 0 Then
                If tab = 2 And tab2 = False Then
                    txtDuiE.ReadOnly = False
                    txtDuiE.Value = dtsDatosAsoc.Tables(0).Rows(0).Item("DUI")
                    txtNoSocio.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("NoSocio") Is DBNull.Value, "", dtsDatosAsoc.Tables(0).Rows(0).Item("NoSocio"))


                    tab2 = True
                ElseIf tab = 3 And tab3 = False Then


                    txtCodProfdG.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("CodProfesion") Is DBNull.Value, "", dtsDatosAsoc.Tables(0).Rows(0).Item("CodProfesion"))
                    txtProfdG.Text = IIf(dtsDatosAsoc.Tables(0).Rows(0).Item("profesion") Is DBNull.Value, "", dtsDatosAsoc.Tables(0).Rows(0).Item("profesion"))

                    tab3 = True
                ElseIf tab = 4 And tab4 = False Then

                    'DatosCredito
                    Me.txtCodTipoCredP2.Text = txtCodTipoCredito.Text
                    txtTipoCredP2.Text = txtTipoCredito.Text
                    txtDestinoP2.Text = txtDestino.Text
                    C1NEMonto.Value = txtMontoSolicitado.Value
                    C1NEPlazo.Value = txtPlazo.Value
                    tab4 = True
                End If
            End If
        End If
    End Sub



    Private Sub btTasaPactada1_Click(sender As Object, e As EventArgs) Handles btTasaPactada1.Click
        Try
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "CRV006"
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
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAtrasTab9_1_Click(sender As Object, e As EventArgs) Handles btnAtrasTab9_1.Click
        Try
            Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveTb9_1_Click(sender As Object, e As EventArgs) Handles btnSaveTb9_1.Click
        Try
            pTab = 9
            'Me.btnSaveTb3_1_Click(sender, e)
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

    Private Sub btNewBI1_Click(sender As Object, e As EventArgs) Handles btNewBI1.Click
        Try
            Dim frm As frmMsCrBienInmueble = New frmMsCrBienInmueble
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridBI()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
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

    Private Sub btNewCd1_Click(sender As Object, e As EventArgs) Handles btNewCd1.Click
        Try
            Dim frm As frmMsCrFiadores = New frmMsCrFiadores
            frm.vFiador = 2
            frm.Text = "Mantenimiento de Codeudores"
            frm.pNumSolicitud = Me.pNumSolicitud
            frm.pAccion = "Guardar"
            frm.btnSaveTb1_1.Text = "&Guardar"
            frm.btnSaveTb2_1.Text = "&Guardar"
            frm.btnSaveTb3_1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridCd()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditCd1_Click(sender As Object, e As EventArgs) Handles btEditCd1.Click
        Try
            If Me.fgCd.Row <> -1 Then
                Dim frm As frmMsCrFiadores = New frmMsCrFiadores
                frm.vFiador = 2
                frm.Text = "Mantenimiento de Codeudores"
                frm.pNumSolicitud = Me.pNumSolicitud
                frm.pCodEnlace = Me.fgCd.Item(Me.fgCd.Row, "CodEnlace")
                frm.pAccion = "Modificar"
                frm.btnSaveTb1_1.Text = "&Modificar"
                frm.btnSaveTb2_1.Text = "&Modificar"
                frm.btnSaveTb3_1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridCd()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelCd1_Click(sender As Object, e As EventArgs) Handles btDelCd1.Click
        Try
            If Me.fgCd.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Codeudor " & Me.fgCd.Item(Me.fgCd.Row, "CodEnlace") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Codeudor") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarDatGral("" & Me.fgCd.Item(Me.fgCd.Row, "CodEnlace") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridCd()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewFd1_Click(sender As Object, e As EventArgs) Handles btNewFd1.Click
        Try
            Dim frm As frmMsCrFiadores = New frmMsCrFiadores
            frm.vFiador = 1
            frm.pNumSolicitud = Me.pNumSolicitud
            frm.pAccion = "Guardar"
            frm.btnSaveTb1_1.Text = "&Guardar"
            frm.btnSaveTb2_1.Text = "&Guardar"
            frm.btnSaveTb3_1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridFd()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditFd1_Click(sender As Object, e As EventArgs) Handles btEditFd1.Click
        Try
            If Me.fgFd.Row <> -1 Then
                Dim frm As frmMsCrFiadores = New frmMsCrFiadores
                frm.vFiador = 1
                frm.pNumSolicitud = Me.pNumSolicitud
                frm.pCodEnlace = Me.fgFd.Item(Me.fgFd.Row, "CodEnlace")
                frm.pAccion = "Modificar"
                frm.btnSaveTb1_1.Text = "&Modificar"
                frm.btnSaveTb2_1.Text = "&Modificar"
                frm.btnSaveTb3_1.Text = "&Modificar"
                frm.txtDuidG.Enabled = False
                frm.txtNit.Enabled = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridFd()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelFd1_Click(sender As Object, e As EventArgs) Handles btDelFd1.Click
        Try
            If Me.fgFd.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Fiador " & Me.fgFd.Item(Me.fgFd.Row, "CodEnlace") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Fiador") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarDatGral("" & Me.fgFd.Item(Me.fgFd.Row, "CodEnlace") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridFd()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewGr1_Click(sender As Object, e As EventArgs) Handles btNewGr1.Click
        Try
            Dim frm As frmMsCrGarantias = New frmMsCrGarantias
            frm.pNoSolic = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.pDui = Me.txtDuiE.Text.Trim
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridGr()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditGr1_Click(sender As Object, e As EventArgs) Handles btEditGr1.Click
        Try
            If Me.fgGr.Row <> -1 Then
                Dim frm As frmMsCrGarantias = New frmMsCrGarantias
                frm.pNoSolic = Me.pNumSolicitud
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCodigo = Me.fgGr.Item(Me.fgGr.Row, "CodGarantia")
                frm.pDui = Me.txtDuiE.Text.Trim
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridGr()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelGr1_Click(sender As Object, e As EventArgs) Handles btDelGr1.Click
        Try
            If Me.fgGr.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Garantía " & Me.fgGr.Item(Me.fgGr.Row, "CodGarantia") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Garantía") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarGarantias("" & Me.fgGr.Item(Me.fgGr.Row, "CodGarantia") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridGr()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btConsultaGarantiasInt1_Click(sender As Object, e As EventArgs) Handles btConsultaGarantiasInt1.Click
        Try
            Dim ofrm As New frmMsCrConsultaGarInt
            ofrm.NoSolicitud = Me.pNumSolicitud
            ofrm.NoSocio = Me.txtNoSocio.Text
            ofrm.Dui = Me.txtDuiE.Value
            ofrm.Nombre = Me.txtNombresE.Text.Trim & " " & Me.txtApe1E.Text.Trim & " " & Me.txtApe1E.Text.Trim
            ofrm.ShowDialog()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAtrasTab11_1_Click(sender As Object, e As EventArgs) Handles btnAtrasTab11_1.Click
        Try
            Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSigTab9_1_Click(sender As Object, e As EventArgs) Handles btnSigTab9_1.Click
        Try
            Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveTb11_1_Click(sender As Object, e As EventArgs) Handles btnSaveTb11_1.Click
        Try
            'Me.btnSaveTb3_1_Click(sender, e)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton24_Click(sender As Object, e As EventArgs) Handles MetroButton24.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton22_Click(sender As Object, e As EventArgs) Handles MetroButton22.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton23_Click(sender As Object, e As EventArgs) Handles btnSaveTb7_1.Click
        Try
            pTab = 7
            'Me.btnSaveTb3_1_Click(sender, e)
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

    Private Sub MetroButton17_Click(sender As Object, e As EventArgs) Handles btDelRC1.Click
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

    Private Sub MetroButton18_Click(sender As Object, e As EventArgs) Handles btnAtrasTab10_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton16_Click(sender As Object, e As EventArgs) Handles btnSigTab10_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub btnSaveTb10_1_Click(sender As Object, e As EventArgs) Handles btnSaveTb10_1.Click
        Try
            pTab = 10
            'Me.btnSaveTb3_1_Click(sender, e)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewOA1_Click(sender As Object, e As EventArgs) Handles btNewOA1.Click

        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            Dim frm As frmMsCrObsxAnal = New frmMsCrObsxAnal
            frm.NumSolicitud = Me.pNumSolicitud
            frm.pCodEnlace = Me.pCodEnlace
            frm.accion = 1
            frm.btnGuardar.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridOA()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditOA1_Click(sender As Object, e As EventArgs) Handles btEditOA1.Click
        Try
            If Me.fgObsxAnal.Row <> -1 Then
                Dim frm As frmMsCrObsxAnal = New frmMsCrObsxAnal
                frm.NumSolicitud = pNumSolicitud
                'frm.pNoSolic = Me.pNumSolicitud
                'frm.pCodEnlace = Me.pCodEnlace
                frm.Correlativo = Me.fgObsxAnal.Item(Me.fgObsxAnal.Row, "Correlativo")
                frm.accion = 2
                frm.btnGuardar.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridOA()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelOA1_Click(sender As Object, e As EventArgs) Handles btDelOA1.Click
        Try
            If Me.fgObsxAnal.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Observación No. " & Me.fgObsxAnal.Item(Me.fgObsxAnal.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Observación") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred
                    oCred.EliminarObservacionesxAnalisis("" & Me.fgObsxAnal.Item(Me.fgObsxAnal.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridOA()
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

    Private Sub btnAtrasTab8_1_Click(sender As Object, e As EventArgs) Handles btnAtrasTab8_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub btnSigTab8_1_Click(sender As Object, e As EventArgs) Handles btnSigTab8_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub btnSaveTb8_1_Click(sender As Object, e As EventArgs) Handles btnSaveTb8_1.Click
        Try
            pTab = 8
            'Me.btnSaveTb3_1_Click(sender, e)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
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
                ActualizaGridGt()
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

    Private Sub btnSigTab6_1_Click(sender As Object, e As EventArgs) Handles btnSigTab6_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub btnAtrasTab6_1_Click(sender As Object, e As EventArgs) Handles btnAtrasTab6_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub btnSaveTb61_Click(sender As Object, e As EventArgs) Handles btnSaveTb61.Click
        Try
            pTab = 6
            'Me.btnSaveTb3_1_Click(sender, e)
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

    Private Sub btnAtrasTb5_1_Click(sender As Object, e As EventArgs) Handles btnAtrasTb5_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub btnSigTb5_1_Click(sender As Object, e As EventArgs) Handles btnSigTb5_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub btnSaveTb5_1_Click(sender As Object, e As EventArgs) Handles btnSaveTb5_1.Click
        Try

            btnSaveTb2_1_Click(sender, e)

            Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
            Dim pvalor As Boolean
            pvalor = True
            Me.tbSolic.TabPages(3).Enabled = pvalor
            Me.tbSolic.TabPages(4).Enabled = pvalor
            Me.tbSolic.TabPages(5).Enabled = pvalor
            Me.tbSolic.TabPages(6).Enabled = pvalor
            Me.tbSolic.TabPages(7).Enabled = pvalor
            Me.tbSolic.TabPages(8).Enabled = pvalor
            'Me.btnSaveTb3_1_Click(sender, e)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton12_Click(sender As Object, e As EventArgs) Handles MetroButton12.Click
        Try
            Dim ds As New DataSet, oCred As New wrCredito.wsLibCred

            ds = oCred.RptContratoInvestigacion(txtDuiE.Value)
            Dim ofrm As New frmVisor(ds, 219, 0)

            ofrm.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSigTb1_1_Click(sender As Object, e As EventArgs) Handles btnSigTb1_1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex() + 1
    End Sub

    Private Sub btnSaveTb1_1_Click(sender As Object, e As EventArgs) Handles btnSaveTb1_1.Click

        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection

            Select Case oCred.AutorizarDatos(txtDuiE.Text, Me.txtNitE.Value, txtCodEjecMercadeoE.Text, txtApe1E.Text, txtNombresE.Text)
                Case 1
                    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 2
                    MsgBox("El Nit del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 3
                    MsgBox("El campo Ejecutivo de Mercadeo no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 4
                    MsgBox("El campo Apellido del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 5
                    MsgBox("El campo Nombres del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            'Validamos campos requeridos 
            Me.ErrorProvider1.Clear()
            Dim valido As Boolean = True
            If txtDuiE.Value.ToString.Trim.Length = 0 Then

                Me.ErrorProvider1.SetError(txtDuiE, "Campo Requerido")
                Exit Sub
            End If

            If txtNitE.Value.ToString.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(txtNitE, "Campo Requerido")
                Exit Sub
            End If
            If txtCodEjecMercadeoE.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(txtCodEjecMercadeoE, "Campo Requerido")
                Exit Sub
            End If
            If txtCodTipoCredito.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(txtCodTipoCredito, "Campo Requerido")
                Exit Sub
            End If
            If Me.txtMontoSolicitado.Value = 0 Then
                Me.ErrorProvider1.SetError(txtMontoSolicitado, "Monto debe ser mayor a cero.")
                Exit Sub
            End If
            If Me.txtDestino.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(txtDestino, "Campo Requerido")
                Exit Sub
            End If

            If Me.txtPlazo.Value = 0 Then
                Me.ErrorProvider1.SetError(txtPlazo, "Plazo debe ser mayor a cero.")
                Exit Sub
            End If


            If Me.chkAsociado.Checked = True Then
                ds = oAsoc.ConsultarAsociado("*", "Dui='" & Trim(Me.txtDuiE.Text) & "'", "DUI", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                Else
                    MsgBox("El Dui del Asociado no coincide con el Maestro de Asociados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                End If
            End If

            If Me.btnSaveTb1_1.Text = "Guardar" Then
                pCorrelativo = oCred.ObtenerCorrelativoSolCred("Correlativo", sUsuario, sPassword, sSucursal)
                pCampos = "Correlativo,Nombres,Apellido1,Apellido2,Apellido3,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,CodEjecutivo,Recibida,EstadoCivil,Nit,MontoSolicitado,Plazo,Destino,Interes,Celular"
                pValores = "" & pCorrelativo & ",'" & Trim(Me.txtNombresE.Text) & "','" & Trim(Me.txtApe1E.Text) & "','" & Trim(Me.txtApe2E.Text) & "','" & Trim(Me.txtApe3E.Text) & "','" & Trim(Me.txtTelCasaE.Text) & "','" & Trim(Me.txtDirE.Text) & "','" & Format(Me.dtpFecEnt.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtLugTrabE.Text) & "','" & Trim(Me.txtTelOficE.Text) & "','" & IIf(Me.chkAsociado.Checked = True, "1", "0") & "','" & Trim(Me.txtDuiE.Text) & "','" & Trim(Me.txtCodTipoCredito.Text) & "','" & Trim(Me.txtCodEjecMercadeoE.Text) & "',0,'" & Me.cbEstadoCivilE.SelectedValue & "','" & Trim(Me.txtNitE.Text) & "'," & Val(Me.txtMontoSolicitado.Value) & "," & Val(Me.txtPlazo.Value) & ",'" & Trim(Me.txtDestino.Text) & "'," & Val(Me.txtTasaInteres.Text) & ",'" & Me.txtCelular.Text.Trim & "'"
                If oCred.InsertarSolCred(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    ' Me.txtDuidG.Value = Me.txtDuiE.Value
                    pNumSolicitud = oCred.ObtenerCorrelativoSolCredR("NumSolicitud", sUsuario, sPassword, sSucursal)
                    pCampos = "NumSolicitud,Estado,Conclusion,FechaConclusion"
                    pValores = "" & pNumSolicitud & ",'F','P','" & Format(Now, "dd/MM/yyyy") & "'"
                    If oCred.InsertarSolCredR(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                        pCampos = "NumSolicitud=" & pNumSolicitud & ""
                        oCred.ModificarSolCred(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal)
                        Me.txtNoSolic.Text = pNumSolicitud
                        Me.tbSolic.TabPages(1).Enabled = True
                        Me.tbSolic.SelectedIndex = 1
                        btnSaveTb1_1.Text = "&Modificar"
                        '"""""""""""""""""""""""""""""""""""""""""""""""""""""
                        '28/01/2017
                        '2 pestaña 
                        Me.chkRecibida.Checked = True
                        Me.txtCodEjecMercR.Text = txtCodEjecMercadeoE.Text
                        Me.txtEjecMercR.Text = txtEjecMercadeoE.Text
                        txtCodEjecAp.Text = txtCodEjecMercadeoE.Text
                        txtNomCodEjecAp.Text = txtEjecMercadeoE.Text

                        txtCodTipoCredP2.Text = txtCodTipoCredito.Text
                        txtTipoCredP2.Text = txtTipoCredito.Text
                        C1NEMonto.Value = txtMontoSolicitado.Value
                        c1nTasa.Value = txtTasaInteres.Text
                        txtDestinoP2.Text = txtDestino.Text
                        C1NEPlazo.Value = txtPlazo.Text
                        '"""""""""""""""""""""""""""""""""""""""""""""""""""""
                        MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Los datos de la solicitud NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnSaveTb1_1.Text = "&Modificar" Then
                pCampos = "Nombres='" & Trim(Me.txtNombresE.Text) & "',Apellido1='" & Trim(Me.txtApe1E.Text) & "',Apellido2='" & Trim(Me.txtApe2E.Text) & "',Apellido3='" & Trim(Me.txtApe3E.Text) & "',Tels='" & Trim(Me.txtTelCasaE.Text) & "',Direccion='" & Trim(Me.txtDirE.Text) & "',FechaEntrega='" & Format(Me.dtpFecEnt.Value, "dd/MM/yyyy") & "',LugarTrabajo='" & Trim(Me.txtLugTrabE.Text) & "',TelsTrabajo='" & Trim(Me.txtTelOficE.Text) & "',Asociado='" & IIf(Me.chkAsociado.Checked = True, "1", "0") & "',Dui='" & Trim(Me.txtDuiE.Text) & "',CodTipoCredito='" & Trim(Me.txtCodTipoCredito.Text) & "',CodEjecutivo='" & Trim(Me.txtCodEjecMercadeoE.Text) & "',EstadoCivil='" & Me.cbEstadoCivilE.SelectedValue & "',Nit='" & Trim(Me.txtNitE.Text) & "',MontoSolicitado=" & Val(Me.txtMontoSolicitado.Value) & ",Plazo=" & Val(Me.txtPlazo.Value) & ",Destino='" & Trim(Me.txtDestino.Text) & "',Interes=" & Val(Me.txtTasaInteres.Text) & ",Celular='" & Me.txtCelular.Text.Trim & "'"
                If oCred.ModificarSolCred(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.tbSolic.SelectedIndex = 1
                Else
                    MsgBox("Los datos de la solicitud no han sido modificados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
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
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String ', pValores As String

            Select Case oCred.AutorizarDatos(Me.txtCodSuc.Text, "x", Me.txtCodEjecMercR.Text, Me.txtCodEjecAp.Text, "x")
                Case 1
                    MsgBox("La sucursal no puede quedar vacía. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 3
                    MsgBox("El campo Ejecutivo de Gestión no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 4
                    MsgBox("El campo Ejecutivo de Apertura no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            pCampos = "FechaSol='" & Format(Me.dtpFecRec.Value, "dd/MM/yyyy") & "',CodSucursal='" & Trim(Me.txtCodSuc.Text) & "',Estado='" & Mid(Me.cbEstado.Text, 2, 1) & "',Conclusion='" & Mid(Me.cbConclusion.Text, 2, 1) & "',FechaConclusion='" & Format(Me.dtpFecConc.Value, "dd/MM/yyyy") & "',CodEjecMercadeo='" & Trim(Me.txtCodEjecMercR.Text) & "',Observacion='" & Me.txtObs.Text & "',CodEjecApertura='" & Trim(Me.txtCodEjecAp.Text) & "'"
            If oCred.ModificarSolCredR(pNumSolicitud, pCampos, sUsuario, sPassword, sSucursal) = True Then
                oCred.ModificarSolCred(pCorrelativo, "Recibida='" & IIf(Me.chkRecibida.Checked = True, "1", "0") & "'", sUsuario, sPassword, sSucursal)
                Me.ControlTab(Me.chkRecibida.Checked, True)
                Me.ControlTabDat(True)
                CargarDatos()





                Dim dtsGen As New DataSet
                Dim dtsSol As New DataSet
                Dim camposGen, camposSol As String
                Dim valoresGen, valoresSol As String
                dtsGen = Creditos.ConsultarDatGral("numsolicitud", " numSolicitud = '" & pNumSolicitud & "' ", "", sUsuario, sPassword, sSucursal)
                If dtsGen.Tables.Count > 0 Then
                    If dtsGen.Tables(0).Rows.Count > 0 Then
                        dtsSol = Creditos.ConsultarSolP2Credito("numSolicitud", "numsolicitud = '" & pNumSolicitud & "'", "", sUsuario, sPassword, sSucursal)
                        If dtsSol.Tables.Count > 0 Then
                            If dtsSol.Tables(0).Rows.Count > 0 Then
                                If Me.txtCodPagaduria.Text.Trim = "" Then Me.txtCodPagaduria.Text = "0"
                                camposSol = "CodTipoCredito='" & Trim(Me.txtCodTipoCredP2.Text) & "',MontoSolicitado=" & Val(Me.C1NEMonto.Value) & ",Plazo=" & Val(Me.C1NEPlazo.Value) & ",Destino='" & Trim(Me.txtDestinoP2.Text) & "',FormaPago='" & Me.cbFormaPagoP2.SelectedIndex & "',DiaMesPago=" & Me.txtDiaPago.Value & ",Interes=" & c1nTasa.Value & ",CuotaTotal=" & Val(Me.c1nCuota.Value) & ",CodPagaduria='" & Me.txtCodPagaduria.Text.Trim & "',InteresMoratorio=" & Val(Me.txtIntMora.Text) & ",GeneraReserva='" & Me.txtGeneraReserva.Text.Trim & "',NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'"
                                oCred.ModificarSolP2Credito(Me.pNumSolicitud, camposSol, sUsuario, sPassword, sSucursal)
                            Else
                                If Me.txtCodPagaduria.Text.Trim = "" Then Me.txtCodPagaduria.Text = "0"
                                camposSol = "NumSolicitud,CodTipoCredito,MontoSolicitado,Plazo,Destino,FormaPago,DiaMesPago,CodEnlace,Interes,CuotaTotal,CodPagaduria,InteresMoratorio,GeneraReserva,NoCuenta"
                                valoresSol = "" & pNumSolicitud & ",'" & Trim(Me.txtCodTipoCredP2.Text) & "'," & Val(Me.C1NEMonto.Value) & "," & Val(Me.C1NEPlazo.Value) & ",'" & Trim(Me.txtDestinoP2.Text) & "','" & Me.cbFormaPagoP2.SelectedIndex & "'," & Me.txtDiaPago.Value & "," & pCodEnlace & "," & c1nTasa.Value & "," & Val(Me.c1nCuota.Value) & ",'" & Me.txtCodPagaduria.Text.Trim & "'," & Val(Me.txtIntMora.Text) & ",'" & Me.txtGeneraReserva.Text.Trim & "','" & Me.txtNoCuenta.Text.Trim & "'"
                                oCred.InsertarSolP2Credito(camposSol, valoresSol, sUsuario, sPassword, sSucursal)
                            End If
                        End If

                    Else
                        pCodEnlace = oCred.ObtenerCorrelativoDatGral("CodEnlace", sUsuario, sPassword, sSucursal)
                        camposGen = "CodEnlace,NumSolicitud,NoSocio,Fiador"
                        valoresGen = " " & pCodEnlace & ", '" & pNumSolicitud & "', '" & txtNoSocio.Text.Trim & "','0' "
                        'pValores = "" & pCodEnlace & "," & pNumSolicitud & ",'" & Trim(Me.txtNoSocio.Text) & "','" & IIf(Me.chkFiador.Checked = True, "1", "0") & "','" & IIf(Me.chkFiadorDesc.Checked = True, "1", "0") & "','" & Trim(Me.txtMotivoDesc.Text) & "','" & Trim(Me.txtNombresdG.Text) & "','" & Trim(Me.txtApe1dG.Text) & "','" & Trim(Me.txtApe2dG.Text) & "','" & Trim(Me.txtApe3dG.Text) & "','" & Format(Me.dtpFecNac.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtDireccion.Text) & "','" & Trim(Me.txtTelCasa.Text) & "','" & Trim(Me.txtCel.Text) & "','" & Me.cbEstatusPropiedad.SelectedIndex & "','" & Trim(Me.txtPropCasa.Text) & "','" & Trim(Me.txtDuidG.Text) & "','" & Trim(Me.txtNit.Text) & "','" & Trim(Me.txtIsss.Text) & "','" & Format(Me.dtpFecExtDui.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtLugTrabdG.Text) & "','" & Format(Me.dtpFecIniTrab.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtTelOficdG.Text) & "','" & Trim(Me.txtExtOficdG.Text) & "','" & Trim(Me.txtDirTrabdG.Text) & "'," & Val(Me.txtSalario.Value) & ",'" & Me.cbPeriodoPago.SelectedIndex & "','" & Format(Me.dtpFecPago.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtCargo.Text) & "','" & Trim(Me.txtCodProfdG.Text) & "','" & Trim(Me.txtTrabAnt.Text) & "','" & Trim(Me.txtCargoAnt.Text) & "','" & Trim(Me.txtCausaRetiro.Text) & "','" & Format(Me.dtpFecCargoDesde.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecCargoHasta.Value, "dd/MM/yyyy") & "'," & Val(txtSalAnt.Value) & ",'" & Trim(Me.txtConyugue.Text) & "','" & Trim(Me.txtApe1Cy.Text) & "','" & Trim(Me.txtApe2Cy.Text) & "','" & Trim(Me.txtApe3Cy.Text) & "'," & Val(Me.txtSalarioC.Value) & ",'" & Trim(Me.txtLugTrabCy.Text) & "','" & Format(Me.dtpFecIniTrabCy.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtTelTrabCy.Text) & "'," & Me.nuDGrupoFam.Value & ",'" & Trim(Me.txtDirFam.Text) & "','" & Me.txtEmail.Text.Trim & "','" & Me.txtTelProp.Text.Trim & "','" & Me.txtDirProp.Text.Trim & "','" & Me.cbEstadoCivil.SelectedIndex & "','" & Me.txtDirCorresp.Text.Trim & "'"
                        If oCred.InsertarDatGral(camposGen, valoresGen, sUsuario, sPassword, sSucursal) = True Then
                            If Me.txtCodPagaduria.Text.Trim = "" Then Me.txtCodPagaduria.Text = "0"
                            camposSol = "NumSolicitud,CodTipoCredito,MontoSolicitado,Plazo,Destino,FormaPago,DiaMesPago,CodEnlace,Interes,CuotaTotal,CodPagaduria,InteresMoratorio,GeneraReserva,NoCuenta"
                            valoresSol = "" & pNumSolicitud & ",'" & Trim(Me.txtCodTipoCredP2.Text) & "'," & Val(Me.C1NEMonto.Value) & "," & Val(Me.C1NEPlazo.Value) & ",'" & Trim(Me.txtDestinoP2.Text) & "','" & Me.cbFormaPagoP2.SelectedIndex & "'," & Me.txtDiaPago.Value & "," & pCodEnlace & "," & c1nTasa.Value & "," & Val(Me.c1nCuota.Value) & ",'" & Me.txtCodPagaduria.Text.Trim & "'," & Val(Me.txtIntMora.Text) & ",'" & Me.txtGeneraReserva.Text.Trim & "','" & Me.txtNoCuenta.Text.Trim & "'"
                            oCred.InsertarSolP2Credito(camposSol, valoresSol, sUsuario, sPassword, sSucursal)
                            Me.tbSolic.SelectedIndex = pTab
                            Me.ControlTabDat(True)
                            Me.tbSolic.SelectedIndex = 2
                            '  Me.btnSaveTb3_1.Text = "&Modificar"
                        Else
                            MsgBox("Los datos de la solicitud NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                        End If
                    End If
                Else
                    pCodEnlace = oCred.ObtenerCorrelativoDatGral("CodEnlace", sUsuario, sPassword, sSucursal)
                    camposGen = "CodEnlace,NumSolicitud,NoSocio,Fiador"
                    valoresGen = " " & pCodEnlace & ", '" & pNumSolicitud & "', '" & txtNoSocio.Text.Trim & "','0' "
                    'pValores = "" & pCodEnlace & "," & pNumSolicitud & ",'" & Trim(Me.txtNoSocio.Text) & "','" & IIf(Me.chkFiador.Checked = True, "1", "0") & "','" & IIf(Me.chkFiadorDesc.Checked = True, "1", "0") & "','" & Trim(Me.txtMotivoDesc.Text) & "','" & Trim(Me.txtNombresdG.Text) & "','" & Trim(Me.txtApe1dG.Text) & "','" & Trim(Me.txtApe2dG.Text) & "','" & Trim(Me.txtApe3dG.Text) & "','" & Format(Me.dtpFecNac.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtDireccion.Text) & "','" & Trim(Me.txtTelCasa.Text) & "','" & Trim(Me.txtCel.Text) & "','" & Me.cbEstatusPropiedad.SelectedIndex & "','" & Trim(Me.txtPropCasa.Text) & "','" & Trim(Me.txtDuidG.Text) & "','" & Trim(Me.txtNit.Text) & "','" & Trim(Me.txtIsss.Text) & "','" & Format(Me.dtpFecExtDui.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtLugTrabdG.Text) & "','" & Format(Me.dtpFecIniTrab.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtTelOficdG.Text) & "','" & Trim(Me.txtExtOficdG.Text) & "','" & Trim(Me.txtDirTrabdG.Text) & "'," & Val(Me.txtSalario.Value) & ",'" & Me.cbPeriodoPago.SelectedIndex & "','" & Format(Me.dtpFecPago.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtCargo.Text) & "','" & Trim(Me.txtCodProfdG.Text) & "','" & Trim(Me.txtTrabAnt.Text) & "','" & Trim(Me.txtCargoAnt.Text) & "','" & Trim(Me.txtCausaRetiro.Text) & "','" & Format(Me.dtpFecCargoDesde.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecCargoHasta.Value, "dd/MM/yyyy") & "'," & Val(txtSalAnt.Value) & ",'" & Trim(Me.txtConyugue.Text) & "','" & Trim(Me.txtApe1Cy.Text) & "','" & Trim(Me.txtApe2Cy.Text) & "','" & Trim(Me.txtApe3Cy.Text) & "'," & Val(Me.txtSalarioC.Value) & ",'" & Trim(Me.txtLugTrabCy.Text) & "','" & Format(Me.dtpFecIniTrabCy.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtTelTrabCy.Text) & "'," & Me.nuDGrupoFam.Value & ",'" & Trim(Me.txtDirFam.Text) & "','" & Me.txtEmail.Text.Trim & "','" & Me.txtTelProp.Text.Trim & "','" & Me.txtDirProp.Text.Trim & "','" & Me.cbEstadoCivil.SelectedIndex & "','" & Me.txtDirCorresp.Text.Trim & "'"
                    If oCred.InsertarDatGral(camposGen, valoresGen, sUsuario, sPassword, sSucursal) = True Then
                        If Me.txtCodPagaduria.Text.Trim = "" Then Me.txtCodPagaduria.Text = "0"
                        camposSol = "NumSolicitud,CodTipoCredito,MontoSolicitado,Plazo,Destino,FormaPago,DiaMesPago,CodEnlace,Interes,CuotaTotal,CodPagaduria,InteresMoratorio,GeneraReserva,NoCuenta"
                        valoresSol = "" & pNumSolicitud & ",'" & Trim(Me.txtCodTipoCredP2.Text) & "'," & Val(Me.C1NEMonto.Value) & "," & Val(Me.C1NEPlazo.Value) & ",'" & Trim(Me.txtDestinoP2.Text) & "','" & Me.cbFormaPagoP2.SelectedIndex & "'," & Me.txtDiaPago.Value & "," & pCodEnlace & "," & c1nTasa.Value & "," & Val(Me.c1nCuota.Value) & ",'" & Me.txtCodPagaduria.Text.Trim & "'," & Val(Me.txtIntMora.Text) & ",'" & Me.txtGeneraReserva.Text.Trim & "','" & Me.txtNoCuenta.Text.Trim & "'"
                        oCred.InsertarSolP2Credito(camposSol, valoresSol, sUsuario, sPassword, sSucursal)
                        Me.tbSolic.SelectedIndex = pTab
                        Me.ControlTabDat(True)
                        Me.tbSolic.SelectedIndex = 2
                        '  Me.btnSaveTb3_1.Text = "&Modificar"
                    Else
                        MsgBox("Los datos de la solicitud NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                    End If
                End If

            Else
                MsgBox("Los datos de la solicitud no han sido modificados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
            End If


        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex() + 1
    End Sub

    Private Sub btnAtrasTb3_1_Click(sender As Object, e As EventArgs)
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex() - 1
    End Sub

    Private Sub btnAtrasTb4_1_Click(sender As Object, e As EventArgs)
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub txtCodEjecMercadeoE_TextChanged(sender As Object, e As EventArgs) Handles txtCodEjecMercadeoE.TextChanged

    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Dim frm As New frmIngresoAsoc2
        With frm
            .txtDui.Text = Me.txtDuiE.Value
            .accion = 2
            .Show()
        End With
    End Sub

    Private Sub btnGenerarCuota_Click(sender As Object, e As EventArgs) Handles btnGenerarCuota.Click
        Dim frm As New frmCRTablaAmort
        With frm
            .C1NENumPagos.Value = C1NEPlazo.Value
            .C1NEInteres.Value = c1nTasa.Value
            .C1NEMonto.Value = C1NEMonto.Value
            .dtpFecha.Value = DateAdd(DateInterval.Month, 1, Now)
            .btnImprimir1.Visible = False
            .btPlanPago1.Visible = False
            .btnLimpiar1.Visible = False
            '.btnExportar1.Visible = False
            .btnAsignar1.Visible = False
            .ShowDialog()
        End With
        c1nCuota.Value = frm.cuotaTotal
    End Sub

    Private Sub btnSigTb4_1_Click(sender As Object, e As EventArgs)
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub btnSolCredito_Click(sender As Object, e As EventArgs) Handles btnSolCredito.Click
        Dim frm As New frmVisorRS
        OpcionRS = 96
        With frm
            .dui = txtDuiE.Value.ToString
            .codPrstamo = txtNoSolic.Text
            .Show()
        End With
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim frm As New frmVisorRS
        OpcionRS = 99
        With frm
            .dui = txtDuiE.Value.ToString
            .codPrstamo = txtNoSolic.Text
            .Show()
        End With
    End Sub

    Private Sub txtCodEjecMercR_TextChanged(sender As Object, e As EventArgs) Handles txtCodEjecMercR.TextChanged

    End Sub

    Private Sub txtNoSolic_TextChanged(sender As Object, e As EventArgs) Handles txtNoSolic.TextChanged

    End Sub

    Private Sub txtCodEjecAp_TextChanged(sender As Object, e As EventArgs) Handles txtCodEjecAp.TextChanged

    End Sub

    Private Sub tbRecibido_Click(sender As Object, e As EventArgs) Handles tbRecibido.Click

    End Sub

    Private Sub btnSaveTb4_1_Click(sender As Object, e As EventArgs)
        Try
            pTab = 4
            'Me.btnSaveTb3_1_Click(sender, e)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbSolic_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSolic.SelectedIndexChanged
        If Me.pAccion <> "Modificar" And datosPendientes = False Then
            llenarDatosAsociado(tbSolic.SelectedIndex)
        ElseIf Me.pAccion = "Modificar" And datosPendientes = True Then
            llenarDatosAsociado(tbSolic.SelectedIndex)
        End If
    End Sub


    Protected Sub recuperarDatosPrestamo(ByVal numSolicitud As Integer)
        Try
            Dim dts As New DataSet
            Dim campos As String = "codPrestamo,NumSolicitud," &
               "codTipoCredito,NoSocio," &
               "DUI,cuota," &
               "cuotaTotal,monto," &
               "tasa_interes,isnull(tasa_interes_mora,0) as tasa_interes_mora," &
               "plazoMeses,fechaOtorgamiento," &
               "fechaVencimiento,Categoria," &
               "codPagaduria,fechaUltimoPago," &
               "Saldo_capital,SaldoDIa_interes," &
               "Estado,Baja,fechaprimeraCuota,isnull(saldodia_Capitalmora,0) as saldodia_Capitalmora, isnull(saldodia_interesMora,0) as saldodia_interesMora"
            dts = Creditos.ConsultarPRPrestamos(campos, " numSolicitud = '" & numSolicitud & "' ", "", False, sUsuario, sPassword, sSucursal)

        Catch ex As Exception

        End Try

    End Sub
    Protected Sub crearPrestamo(ByVal codPrestamo As String, ByVal numSolicitud As Integer,
                                ByVal codTipoCredito As String, ByVal nosocio As Integer,
                                ByVal dui As String, ByVal cuota As Double,
                                ByVal cuotaTotal As Double, ByVal monto As Double,
                                ByVal tasaInteres As Double, ByVal tasaInteresMora As Double,
                                ByVal plazoMeses As Integer, ByVal fechaOtorgamiento As DateTime,
                                ByVal fechaVencimiento As DateTime, ByVal categoria As String,
                                ByVal codPagaduria As String, ByVal fechaUltimoPago As DateTime,
                                ByVal saldoCapital As Double, ByVal saldoInteres As Double,
                                ByVal fechaPrimCuota As DateTime, ByVal capitalMora As Double,
                                ByVal interesMora As Double)
        Dim dts As New DataSet
        dts = Creditos.ConsultarPRPrestamos("numSolicitud", " numSolicitud = '" & numSolicitud & "' ", "", False, sUsuario, sPassword, sSucursal)
        If dts.Tables(0).Rows.Count > 0 Then
            Dim camposValores As String = ""
            camposValores = "codprestamo = '" & codPrestamo &
            "', codTipoCredito = '" & codTipoCredito &
            "', dui = '" & dui &
            "', cuota = '" & cuota &
            "', cuotaTotal = '" & cuotaTotal &
            "', monto = '" & monto &
            "', tasa_interes ='" & tasaInteres &
            "', tasa_interes_mora = '" & tasaInteresMora &
            "', plazoMeses = '" & plazoMeses &
            "', fechaOtorgamiento = '" & fechaOtorgamiento &
            "', fechaVencimiento = '" & fechaVencimiento &
            "', categoria = '" & categoria &
            "', codPagaduria = '" & codPagaduria &
            "', fechaUltimoPago = '" & fechaUltimoPago &
            "', Saldo_capital = '" & saldoCapital &
            "', SaldoDia_Interes = '" & saldoInteres &
            "', fechaPrimeraCuota = '" & fechaPrimCuota &
            "', SaldoDia_CapitalMora = '" & capitalMora &
            "', SaldoDia_InteresMora = '" & interesMora &
            "', codTablaAmortiza = '' "
            Creditos.ModificarPrestamos(numSolicitud.ToString, camposValores, sUsuario, sPassword, sSucursal)
        Else

            Dim campos As String = "codPrestamo,NumSolicitud," &
            "codTipoCredito,NoSocio," &
            "DUI,cuota," &
            "cuotaTotal,monto," &
            "tasa_interes,tasa_interes_mora," &
            "plazoMeses,fechaOtorgamiento," &
            "fechaVencimiento,Categoria," &
            "codPagaduria,fechaUltimoPago," &
            "Saldo_capital,SaldoDIa_interes," &
            "Estado,Baja,codTablaAmortiza," &
            "fechaPrimeraCuota,Monto_Garantia," &
            "SaldoDia_SeguroDeuda,SaldoDia_SeguroDaniosyLA," &
            "SaldoDia_SeguroVida,SaldoDia_SeguroDesempleo," &
            "SaldoDia_Aportacion,SaldoDia_Ahorro," &
            "SaldoDia_ComisionManejo,SaldoDia_Otros, " &
            "SaldoDia_CapitalMora,SaldoDia_InteresMora"
            '"SaldoDia_CapitalMora,SaldoDia_InteresMora," & _
            Dim valores As String
            valores = " '" & codPrestamo & "', '" & numSolicitud & "', " &
            "'" & codTipoCredito & "', '" & nosocio & "'," &
            " '" & dui & "', '" & cuota & "'," &
            " '" & cuotaTotal & "', '" & monto & "'," &
            " '" & tasaInteres & "', '" & tasaInteresMora & "'," &
            " '" & plazoMeses & "', '" & fechaOtorgamiento & "'," &
            " '" & fechaVencimiento & "', 'A', " &
            " '" & codPagaduria & "', '" & fechaUltimoPago & "', " &
            " '" & saldoCapital & "', '" & saldoInteres & "' , " &
            " 'A','0','','" & fechaPrimCuota & "',0,0,0,0,0,0,0,0,0,'" & capitalMora & "','" & interesMora & "' "
            Creditos.InsertarPrestamos(campos, valores, sUsuario, sPassword, sSucursal)
        End If


    End Sub

    Private Sub txtDuiE_DoubleClick(sender As Object, e As EventArgs) Handles txtDuiE.DoubleClick
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
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDuiE.Value = Trim(dr("DUI"))
                'Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

End Class