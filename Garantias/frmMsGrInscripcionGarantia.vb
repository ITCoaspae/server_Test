Public Class frmMsGrInscripcionGarantia
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Public vIDANOTACION As Integer
    Public vNOCOMPROBANTE_CERTIFICACION As String
    Public vNOCOMPROBANTE As String
    Dim CRED As New wrCredito.wsLibCred
    Dim vCodPrestamo As String, vDui As String, vNoSocio As String, vNumSolicitud As Long, vAccion As String, pNoDoc As String
    Public vOPERACION As Integer
    Dim monto As Double
    Dim plazo As Integer
    Dim tasa As Double
#Region "codigo generado por el editor"
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecCons As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtNoPres As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpFecCNR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents c1nTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtObsMH As System.Windows.Forms.TextBox
    Friend WithEvents txtNoInscMH As System.Windows.Forms.TextBox
    Friend WithEvents c1nMontoMH As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFecInscMH As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents dtpFecPresMH As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents dtpFecOtorgMH As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cbTipoHipoteca As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents fgInmueble As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents rbNOTARIOEXTERNO As System.Windows.Forms.RadioButton
    Friend WithEvents rbNOTARIOINTERNO As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodMun As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCodDpto As System.Windows.Forms.TextBox
    Friend WithEvents txtDpto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodSeccion As System.Windows.Forms.TextBox
    Friend WithEvents txtSeccionRegistro As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecNotario As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtNocomprobante As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNumLibro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNoEscritura As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbTipoTransaccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNoAsiento As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNoMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtNoLibro As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNoInscripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dgINSCRIPCIONPRESTAMOS As System.Windows.Forms.DataGridView
    Friend WithEvents cbMODIF_DATOS_CERTIFICACION As System.Windows.Forms.CheckBox
    Friend WithEvents cbNOTARIOS As System.Windows.Forms.ComboBox
    Friend WithEvents btDelInmueble1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditInmueble1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewInmueble1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDel1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btAdd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnGUARDAR_MODIF1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnVER_HISTO1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSig1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btAtras1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCertExt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents lblESTADO As System.Windows.Forms.Label
#End Region
    ' VOPERACION : 0 = CONSULTAR, 1 = INGRESAR, 2 = MODIFICAR 
#Region "Propiedades"

    Public Property NoDoc() As String
        Get
            Return pNoDoc
        End Get
        Set(ByVal Value As String)
            pNoDoc = Value
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

    Public Property Dui() As String
        Get
            Return vDui
        End Get
        Set(ByVal Value As String)
            vDui = Value
        End Set
    End Property

    Public Property NoSocio() As String
        Get
            Return vNoSocio
        End Get
        Set(ByVal Value As String)
            vNoSocio = Value
        End Set
    End Property

    Public Property NumSolicitud() As Long
        Get
            Return vNumSolicitud
        End Get
        Set(ByVal Value As Long)
            vNumSolicitud = Value
        End Set
    End Property

    Public Property Accion() As String
        Get
            Return vAccion
        End Get
        Set(ByVal Value As String)
            vAccion = Value
        End Set
    End Property

#End Region
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblConcedido As System.Windows.Forms.Label
    Friend WithEvents c1nSegDesembolsoHA As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoHA As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents dtpFecOtorgHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents C1nPlazoHA As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblTasaInt As System.Windows.Forms.Label
    Friend WithEvents lblFechaOtorg As System.Windows.Forms.Label
    Friend WithEvents lblFechaVenc As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsGrInscripcionGarantia))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblESTADO = New System.Windows.Forms.Label()
        Me.lblFechaVenc = New System.Windows.Forms.Label()
        Me.lblFechaOtorg = New System.Windows.Forms.Label()
        Me.lblTasaInt = New System.Windows.Forms.Label()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcedido = New System.Windows.Forms.Label()
        Me.C1nPlazoHA = New C1.Win.C1Input.C1NumericEdit()
        Me.dtpFecOtorgHA = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.c1nMontoHA = New C1.Win.C1Input.C1NumericEdit()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.c1nSegDesembolsoHA = New C1.Win.C1Input.C1NumericEdit()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtNoPres = New System.Windows.Forms.TextBox()
        Me.dtpFecCNR = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.dtpFecCons = New System.Windows.Forms.DateTimePicker()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnGUARDAR_MODIF1 = New MetroFramework.Controls.MetroButton()
        Me.btnVER_HISTO1 = New MetroFramework.Controls.MetroButton()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.c1nTasa = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.txtObsMH = New System.Windows.Forms.TextBox()
        Me.txtNoInscMH = New System.Windows.Forms.TextBox()
        Me.c1nMontoMH = New C1.Win.C1Input.C1NumericEdit()
        Me.dtpFecInscMH = New System.Windows.Forms.DateTimePicker()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.dtpFecPresMH = New System.Windows.Forms.DateTimePicker()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.dtpFecOtorgMH = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgINSCRIPCIONPRESTAMOS = New System.Windows.Forms.DataGridView()
        Me.btDel1 = New MetroFramework.Controls.MetroButton()
        Me.btAdd1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cbTipoHipoteca = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btDelInmueble1 = New MetroFramework.Controls.MetroButton()
        Me.btEditInmueble1 = New MetroFramework.Controls.MetroButton()
        Me.btNewInmueble1 = New MetroFramework.Controls.MetroButton()
        Me.fgInmueble = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rbNOTARIOINTERNO = New System.Windows.Forms.RadioButton()
        Me.rbNOTARIOEXTERNO = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtpFecNotario = New System.Windows.Forms.DateTimePicker()
        Me.cbNOTARIOS = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtNoFolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNocomprobante = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNoLibro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoInscripcion = New System.Windows.Forms.TextBox()
        Me.cbMODIF_DATOS_CERTIFICACION = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtNoAsiento = New System.Windows.Forms.TextBox()
        Me.txtNoMatricula = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSeccionRegistro = New System.Windows.Forms.TextBox()
        Me.txtCodSeccion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtCodMun = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDpto = New System.Windows.Forms.TextBox()
        Me.txtCodDpto = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtNumLibro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoEscritura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbTipoTransaccion = New System.Windows.Forms.ComboBox()
        Me.tb = New System.Windows.Forms.TabControl()
        Me.btnSig1 = New MetroFramework.Controls.MetroButton()
        Me.btAtras1 = New MetroFramework.Controls.MetroButton()
        Me.btnCertExt1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox4.SuspendLayout()
        CType(Me.C1nPlazoHA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoHA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSegDesembolsoHA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoMH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgINSCRIPCIONPRESTAMOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.fgInmueble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tb.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.lblESTADO)
        Me.GroupBox4.Controls.Add(Me.lblFechaVenc)
        Me.GroupBox4.Controls.Add(Me.lblFechaOtorg)
        Me.GroupBox4.Controls.Add(Me.lblTasaInt)
        Me.GroupBox4.Controls.Add(Me.lblPlazo)
        Me.GroupBox4.Controls.Add(Me.lblMonto)
        Me.GroupBox4.Controls.Add(Me.lblConcedido)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(672, 80)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'lblESTADO
        '
        Me.lblESTADO.AutoSize = True
        Me.lblESTADO.Location = New System.Drawing.Point(10, 59)
        Me.lblESTADO.Name = "lblESTADO"
        Me.lblESTADO.Size = New System.Drawing.Size(50, 14)
        Me.lblESTADO.TabIndex = 7
        Me.lblESTADO.Text = "Estado :"
        '
        'lblFechaVenc
        '
        Me.lblFechaVenc.Location = New System.Drawing.Point(448, 32)
        Me.lblFechaVenc.Name = "lblFechaVenc"
        Me.lblFechaVenc.Size = New System.Drawing.Size(208, 16)
        Me.lblFechaVenc.TabIndex = 6
        Me.lblFechaVenc.Text = "Fecha de Vencimiento:"
        '
        'lblFechaOtorg
        '
        Me.lblFechaOtorg.Location = New System.Drawing.Point(192, 32)
        Me.lblFechaOtorg.Name = "lblFechaOtorg"
        Me.lblFechaOtorg.Size = New System.Drawing.Size(248, 16)
        Me.lblFechaOtorg.TabIndex = 5
        Me.lblFechaOtorg.Text = "Fecha de Otorgamiento:"
        '
        'lblTasaInt
        '
        Me.lblTasaInt.Location = New System.Drawing.Point(8, 32)
        Me.lblTasaInt.Name = "lblTasaInt"
        Me.lblTasaInt.Size = New System.Drawing.Size(160, 16)
        Me.lblTasaInt.TabIndex = 4
        Me.lblTasaInt.Text = "Tasa de Interés:"
        '
        'lblPlazo
        '
        Me.lblPlazo.Location = New System.Drawing.Point(560, 8)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(104, 16)
        Me.lblPlazo.TabIndex = 3
        Me.lblPlazo.Text = "Plazo:"
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(416, 8)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(104, 16)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto:"
        '
        'lblConcedido
        '
        Me.lblConcedido.Location = New System.Drawing.Point(8, 8)
        Me.lblConcedido.Name = "lblConcedido"
        Me.lblConcedido.Size = New System.Drawing.Size(400, 16)
        Me.lblConcedido.TabIndex = 1
        Me.lblConcedido.Text = "Nombre de Asociado:"
        '
        'C1nPlazoHA
        '
        Me.C1nPlazoHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1nPlazoHA.CustomFormat = "###"
        Me.C1nPlazoHA.DataType = GetType(Short)
        Me.C1nPlazoHA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1nPlazoHA.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1nPlazoHA.Increment = CType(1, Short)
        Me.C1nPlazoHA.Location = New System.Drawing.Point(970, 408)
        Me.C1nPlazoHA.Name = "C1nPlazoHA"
        Me.C1nPlazoHA.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1nPlazoHA.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1nPlazoHA.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1nPlazoHA.ShowDropDownButton = False
        Me.C1nPlazoHA.ShowUpDownButtons = False
        Me.C1nPlazoHA.Size = New System.Drawing.Size(80, 21)
        Me.C1nPlazoHA.TabIndex = 3
        Me.C1nPlazoHA.Tag = Nothing
        Me.C1nPlazoHA.Value = CType(0, Short)
        '
        'dtpFecOtorgHA
        '
        Me.dtpFecOtorgHA.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecOtorgHA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecOtorgHA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecOtorgHA.Location = New System.Drawing.Point(1029, 369)
        Me.dtpFecOtorgHA.Name = "dtpFecOtorgHA"
        Me.dtpFecOtorgHA.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecOtorgHA.TabIndex = 1
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(940, 368)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(112, 16)
        Me.Label32.TabIndex = 129
        Me.Label32.Text = "Fecha Otorgamiento:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(916, 408)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 16)
        Me.Label31.TabIndex = 127
        Me.Label31.Text = "Plazo:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'c1nMontoHA
        '
        Me.c1nMontoHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoHA.CustomFormat = "###,###,##0.00"
        Me.c1nMontoHA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoHA.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoHA.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoHA.Location = New System.Drawing.Point(798, 408)
        Me.c1nMontoHA.Name = "c1nMontoHA"
        Me.c1nMontoHA.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoHA.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoHA.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoHA.ShowDropDownButton = False
        Me.c1nMontoHA.ShowUpDownButtons = False
        Me.c1nMontoHA.Size = New System.Drawing.Size(112, 21)
        Me.c1nMontoHA.TabIndex = 2
        Me.c1nMontoHA.Tag = Nothing
        Me.c1nMontoHA.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(744, 408)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 16)
        Me.Label30.TabIndex = 125
        Me.Label30.Text = "Monto:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'c1nSegDesembolsoHA
        '
        Me.c1nSegDesembolsoHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSegDesembolsoHA.CustomFormat = "#######0"
        Me.c1nSegDesembolsoHA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSegDesembolsoHA.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSegDesembolsoHA.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nSegDesembolsoHA.Location = New System.Drawing.Point(864, 368)
        Me.c1nSegDesembolsoHA.Name = "c1nSegDesembolsoHA"
        Me.c1nSegDesembolsoHA.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSegDesembolsoHA.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSegDesembolsoHA.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSegDesembolsoHA.ShowDropDownButton = False
        Me.c1nSegDesembolsoHA.ShowUpDownButtons = False
        Me.c1nSegDesembolsoHA.Size = New System.Drawing.Size(88, 21)
        Me.c1nSegDesembolsoHA.TabIndex = 0
        Me.c1nSegDesembolsoHA.Tag = Nothing
        Me.c1nSegDesembolsoHA.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(744, 368)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(128, 16)
        Me.Label29.TabIndex = 123
        Me.Label29.Text = "Número de desembolso:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Controls.Add(Me.Label27)
        Me.TabPage6.Controls.Add(Me.txtObs)
        Me.TabPage6.Controls.Add(Me.dtpFecha)
        Me.TabPage6.Controls.Add(Me.cbEstado)
        Me.TabPage6.Controls.Add(Me.Label24)
        Me.TabPage6.Controls.Add(Me.Label58)
        Me.TabPage6.Controls.Add(Me.Label25)
        Me.TabPage6.Controls.Add(Me.txtNoPres)
        Me.TabPage6.Controls.Add(Me.dtpFecCNR)
        Me.TabPage6.Controls.Add(Me.Label26)
        Me.TabPage6.Controls.Add(Me.Label53)
        Me.TabPage6.Controls.Add(Me.dtpFecCons)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(664, 443)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Proceso CNR"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(12, 118)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 16)
        Me.Label27.TabIndex = 149
        Me.Label27.Text = "Observación:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(168, 117)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(484, 69)
        Me.txtObs.TabIndex = 5
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(170, 65)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(143, 20)
        Me.dtpFecha.TabIndex = 4
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.Items.AddRange(New Object() {"Trámite", "Detenida", "Retirada sin inscribir", "Inscrita"})
        Me.cbEstado.Location = New System.Drawing.Point(372, 91)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(280, 22)
        Me.cbEstado.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(12, 13)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(152, 16)
        Me.Label24.TabIndex = 143
        Me.Label24.Text = "Fecha presentación en CNR:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(319, 94)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(47, 13)
        Me.Label58.TabIndex = 2
        Me.Label58.Text = "Estatus:"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(12, 92)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 16)
        Me.Label25.TabIndex = 144
        Me.Label25.Text = "No. Presentación:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoPres
        '
        Me.txtNoPres.Location = New System.Drawing.Point(170, 91)
        Me.txtNoPres.MaxLength = 15
        Me.txtNoPres.Name = "txtNoPres"
        Me.txtNoPres.Size = New System.Drawing.Size(143, 20)
        Me.txtNoPres.TabIndex = 1
        '
        'dtpFecCNR
        '
        Me.dtpFecCNR.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecCNR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCNR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecCNR.Location = New System.Drawing.Point(170, 13)
        Me.dtpFecCNR.Name = "dtpFecCNR"
        Me.dtpFecCNR.Size = New System.Drawing.Size(143, 20)
        Me.dtpFecCNR.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(12, 39)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(109, 16)
        Me.Label26.TabIndex = 145
        Me.Label26.Text = "Fecha de consulta:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(12, 70)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(109, 13)
        Me.Label53.TabIndex = 4
        Me.Label53.Text = "Fecha de Inscripción:"
        '
        'dtpFecCons
        '
        Me.dtpFecCons.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecCons.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCons.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecCons.Location = New System.Drawing.Point(170, 39)
        Me.dtpFecCons.Name = "dtpFecCons"
        Me.dtpFecCons.Size = New System.Drawing.Size(143, 20)
        Me.dtpFecCons.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.btnGUARDAR_MODIF1)
        Me.TabPage4.Controls.Add(Me.btnVER_HISTO1)
        Me.TabPage4.Controls.Add(Me.Label44)
        Me.TabPage4.Controls.Add(Me.Label43)
        Me.TabPage4.Controls.Add(Me.c1nTasa)
        Me.TabPage4.Controls.Add(Me.c1nPlazo)
        Me.TabPage4.Controls.Add(Me.txtObsMH)
        Me.TabPage4.Controls.Add(Me.txtNoInscMH)
        Me.TabPage4.Controls.Add(Me.c1nMontoMH)
        Me.TabPage4.Controls.Add(Me.dtpFecInscMH)
        Me.TabPage4.Controls.Add(Me.Label40)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Controls.Add(Me.dtpFecPresMH)
        Me.TabPage4.Controls.Add(Me.Label37)
        Me.TabPage4.Controls.Add(Me.dtpFecOtorgMH)
        Me.TabPage4.Controls.Add(Me.Label33)
        Me.TabPage4.Controls.Add(Me.Label34)
        Me.TabPage4.Controls.Add(Me.Label35)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(664, 443)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Modificación Hipoteca"
        '
        'btnGUARDAR_MODIF1
        '
        Me.btnGUARDAR_MODIF1.Location = New System.Drawing.Point(469, 184)
        Me.btnGUARDAR_MODIF1.Name = "btnGUARDAR_MODIF1"
        Me.btnGUARDAR_MODIF1.Size = New System.Drawing.Size(139, 28)
        Me.btnGUARDAR_MODIF1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGUARDAR_MODIF1.TabIndex = 231
        Me.btnGUARDAR_MODIF1.Text = "&Guardar Modificaciones"
        Me.btnGUARDAR_MODIF1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGUARDAR_MODIF1.UseSelectable = True
        Me.btnGUARDAR_MODIF1.UseStyleColors = True
        '
        'btnVER_HISTO1
        '
        Me.btnVER_HISTO1.Location = New System.Drawing.Point(388, 184)
        Me.btnVER_HISTO1.Name = "btnVER_HISTO1"
        Me.btnVER_HISTO1.Size = New System.Drawing.Size(75, 28)
        Me.btnVER_HISTO1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnVER_HISTO1.TabIndex = 230
        Me.btnVER_HISTO1.Text = "&Historial"
        Me.btnVER_HISTO1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnVER_HISTO1.UseSelectable = True
        Me.btnVER_HISTO1.UseStyleColors = True
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(328, 56)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(88, 16)
        Me.Label44.TabIndex = 147
        Me.Label44.Text = "Tasa de Interés:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(328, 24)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(40, 16)
        Me.Label43.TabIndex = 146
        Me.Label43.Text = "Plazo:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'c1nTasa
        '
        Me.c1nTasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasa.CustomFormat = "##0.00"
        Me.c1nTasa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTasa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasa.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTasa.Location = New System.Drawing.Point(432, 51)
        Me.c1nTasa.Name = "c1nTasa"
        Me.c1nTasa.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasa.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasa.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasa.ShowDropDownButton = False
        Me.c1nTasa.ShowUpDownButtons = False
        Me.c1nTasa.Size = New System.Drawing.Size(80, 21)
        Me.c1nTasa.TabIndex = 3
        Me.c1nTasa.Tag = Nothing
        Me.c1nTasa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nPlazo
        '
        Me.c1nPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPlazo.CustomFormat = "#,##0"
        Me.c1nPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazo.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nPlazo.Location = New System.Drawing.Point(432, 24)
        Me.c1nPlazo.Name = "c1nPlazo"
        Me.c1nPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nPlazo.ShowDropDownButton = False
        Me.c1nPlazo.ShowUpDownButtons = False
        Me.c1nPlazo.Size = New System.Drawing.Size(80, 21)
        Me.c1nPlazo.TabIndex = 1
        Me.c1nPlazo.Tag = Nothing
        Me.c1nPlazo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtObsMH
        '
        Me.txtObsMH.Location = New System.Drawing.Point(160, 146)
        Me.txtObsMH.Multiline = True
        Me.txtObsMH.Name = "txtObsMH"
        Me.txtObsMH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsMH.Size = New System.Drawing.Size(448, 32)
        Me.txtObsMH.TabIndex = 7
        '
        'txtNoInscMH
        '
        Me.txtNoInscMH.Location = New System.Drawing.Point(432, 120)
        Me.txtNoInscMH.Name = "txtNoInscMH"
        Me.txtNoInscMH.Size = New System.Drawing.Size(80, 20)
        Me.txtNoInscMH.TabIndex = 6
        '
        'c1nMontoMH
        '
        Me.c1nMontoMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoMH.CustomFormat = "###,###,##0.00"
        Me.c1nMontoMH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoMH.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoMH.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoMH.Location = New System.Drawing.Point(160, 56)
        Me.c1nMontoMH.Name = "c1nMontoMH"
        Me.c1nMontoMH.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoMH.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoMH.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoMH.ShowDropDownButton = False
        Me.c1nMontoMH.ShowUpDownButtons = False
        Me.c1nMontoMH.Size = New System.Drawing.Size(80, 21)
        Me.c1nMontoMH.TabIndex = 2
        Me.c1nMontoMH.Tag = Nothing
        Me.c1nMontoMH.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dtpFecInscMH
        '
        Me.dtpFecInscMH.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecInscMH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecInscMH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecInscMH.Location = New System.Drawing.Point(160, 120)
        Me.dtpFecInscMH.Name = "dtpFecInscMH"
        Me.dtpFecInscMH.Size = New System.Drawing.Size(80, 20)
        Me.dtpFecInscMH.TabIndex = 5
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(16, 120)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(128, 16)
        Me.Label40.TabIndex = 143
        Me.Label40.Text = "Fecha de Inscripción:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(328, 120)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(104, 16)
        Me.Label39.TabIndex = 141
        Me.Label39.Text = "No. de Inscripción:"
        '
        'dtpFecPresMH
        '
        Me.dtpFecPresMH.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecPresMH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecPresMH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecPresMH.Location = New System.Drawing.Point(160, 88)
        Me.dtpFecPresMH.Name = "dtpFecPresMH"
        Me.dtpFecPresMH.Size = New System.Drawing.Size(80, 20)
        Me.dtpFecPresMH.TabIndex = 4
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(16, 88)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(128, 16)
        Me.Label37.TabIndex = 140
        Me.Label37.Text = "Fecha de Presentación:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecOtorgMH
        '
        Me.dtpFecOtorgMH.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecOtorgMH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecOtorgMH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecOtorgMH.Location = New System.Drawing.Point(160, 24)
        Me.dtpFecOtorgMH.Name = "dtpFecOtorgMH"
        Me.dtpFecOtorgMH.Size = New System.Drawing.Size(80, 20)
        Me.dtpFecOtorgMH.TabIndex = 0
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(16, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(112, 16)
        Me.Label33.TabIndex = 137
        Me.Label33.Text = "Fecha Modificación:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(16, 146)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(104, 16)
        Me.Label34.TabIndex = 135
        Me.Label34.Text = "Observaciones:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(16, 56)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 16)
        Me.Label35.TabIndex = 134
        Me.Label35.Text = "Nuevo Monto:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.dgINSCRIPCIONPRESTAMOS)
        Me.TabPage3.Controls.Add(Me.btDel1)
        Me.TabPage3.Controls.Add(Me.btAdd1)
        Me.TabPage3.Controls.Add(Me.MetroLabel1)
        Me.TabPage3.Controls.Add(Me.Label42)
        Me.TabPage3.Controls.Add(Me.cbTipoHipoteca)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(664, 443)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Registro Hipoteca"
        '
        'dgINSCRIPCIONPRESTAMOS
        '
        Me.dgINSCRIPCIONPRESTAMOS.AllowUserToAddRows = False
        Me.dgINSCRIPCIONPRESTAMOS.AllowUserToDeleteRows = False
        Me.dgINSCRIPCIONPRESTAMOS.AllowUserToOrderColumns = True
        Me.dgINSCRIPCIONPRESTAMOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgINSCRIPCIONPRESTAMOS.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgINSCRIPCIONPRESTAMOS.Location = New System.Drawing.Point(11, 102)
        Me.dgINSCRIPCIONPRESTAMOS.Name = "dgINSCRIPCIONPRESTAMOS"
        Me.dgINSCRIPCIONPRESTAMOS.ReadOnly = True
        Me.dgINSCRIPCIONPRESTAMOS.Size = New System.Drawing.Size(649, 323)
        Me.dgINSCRIPCIONPRESTAMOS.TabIndex = 3
        '
        'btDel1
        '
        Me.btDel1.Location = New System.Drawing.Point(92, 68)
        Me.btDel1.Name = "btDel1"
        Me.btDel1.Size = New System.Drawing.Size(75, 28)
        Me.btDel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDel1.TabIndex = 229
        Me.btDel1.Text = "&Borrar"
        Me.btDel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDel1.UseSelectable = True
        Me.btDel1.UseStyleColors = True
        '
        'btAdd1
        '
        Me.btAdd1.Location = New System.Drawing.Point(11, 68)
        Me.btAdd1.Name = "btAdd1"
        Me.btAdd1.Size = New System.Drawing.Size(75, 28)
        Me.btAdd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btAdd1.TabIndex = 228
        Me.btAdd1.Text = "&Agregar"
        Me.btAdd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btAdd1.UseSelectable = True
        Me.btAdd1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel1.Location = New System.Drawing.Point(11, 42)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel1.TabIndex = 132
        Me.MetroLabel1.Text = "Préstamos:"
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(8, 15)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(96, 16)
        Me.Label42.TabIndex = 131
        Me.Label42.Text = "Tipo de Hipoteca:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbTipoHipoteca
        '
        Me.cbTipoHipoteca.DisplayMember = "DESCRIPCION"
        Me.cbTipoHipoteca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoHipoteca.Location = New System.Drawing.Point(112, 15)
        Me.cbTipoHipoteca.Name = "cbTipoHipoteca"
        Me.cbTipoHipoteca.Size = New System.Drawing.Size(251, 21)
        Me.cbTipoHipoteca.TabIndex = 4
        Me.cbTipoHipoteca.ValueMember = "ID_TIPOHIPOTECA"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.btDelInmueble1)
        Me.TabPage2.Controls.Add(Me.btEditInmueble1)
        Me.TabPage2.Controls.Add(Me.btNewInmueble1)
        Me.TabPage2.Controls.Add(Me.fgInmueble)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(664, 443)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dueños del Inmueble"
        Me.TabPage2.Visible = False
        '
        'btDelInmueble1
        '
        Me.btDelInmueble1.Location = New System.Drawing.Point(169, 12)
        Me.btDelInmueble1.Name = "btDelInmueble1"
        Me.btDelInmueble1.Size = New System.Drawing.Size(75, 28)
        Me.btDelInmueble1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelInmueble1.TabIndex = 228
        Me.btDelInmueble1.Text = "&Eliminar"
        Me.btDelInmueble1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelInmueble1.UseSelectable = True
        Me.btDelInmueble1.UseStyleColors = True
        '
        'btEditInmueble1
        '
        Me.btEditInmueble1.Location = New System.Drawing.Point(88, 12)
        Me.btEditInmueble1.Name = "btEditInmueble1"
        Me.btEditInmueble1.Size = New System.Drawing.Size(75, 28)
        Me.btEditInmueble1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditInmueble1.TabIndex = 227
        Me.btEditInmueble1.Text = "&Modificar"
        Me.btEditInmueble1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditInmueble1.UseSelectable = True
        Me.btEditInmueble1.UseStyleColors = True
        '
        'btNewInmueble1
        '
        Me.btNewInmueble1.Location = New System.Drawing.Point(7, 12)
        Me.btNewInmueble1.Name = "btNewInmueble1"
        Me.btNewInmueble1.Size = New System.Drawing.Size(75, 28)
        Me.btNewInmueble1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewInmueble1.TabIndex = 226
        Me.btNewInmueble1.Text = "&Agregar"
        Me.btNewInmueble1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewInmueble1.UseSelectable = True
        Me.btNewInmueble1.UseStyleColors = True
        '
        'fgInmueble
        '
        Me.fgInmueble.AllowEditing = False
        Me.fgInmueble.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgInmueble.BackColor = System.Drawing.Color.White
        Me.fgInmueble.ColumnInfo = "10,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgInmueble.Location = New System.Drawing.Point(7, 46)
        Me.fgInmueble.Name = "fgInmueble"
        Me.fgInmueble.Rows.Count = 1
        Me.fgInmueble.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgInmueble.Size = New System.Drawing.Size(645, 394)
        Me.fgInmueble.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgInmueble.Styles"))
        Me.fgInmueble.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.rbNOTARIOINTERNO)
        Me.TabPage1.Controls.Add(Me.rbNOTARIOEXTERNO)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.dtpFecNotario)
        Me.TabPage1.Controls.Add(Me.cbNOTARIOS)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.cbMODIF_DATOS_CERTIFICACION)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.txtSeccionRegistro)
        Me.TabPage1.Controls.Add(Me.txtCodSeccion)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtMunicipio)
        Me.TabPage1.Controls.Add(Me.txtCodMun)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtUbicacion)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtDpto)
        Me.TabPage1.Controls.Add(Me.txtCodDpto)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtArea)
        Me.TabPage1.Controls.Add(Me.txtNumLibro)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label38)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtNoEscritura)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.cbTipoTransaccion)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(664, 443)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        '
        'rbNOTARIOINTERNO
        '
        Me.rbNOTARIOINTERNO.AutoSize = True
        Me.rbNOTARIOINTERNO.BackColor = System.Drawing.Color.White
        Me.rbNOTARIOINTERNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNOTARIOINTERNO.Location = New System.Drawing.Point(535, 356)
        Me.rbNOTARIOINTERNO.Name = "rbNOTARIOINTERNO"
        Me.rbNOTARIOINTERNO.Size = New System.Drawing.Size(58, 18)
        Me.rbNOTARIOINTERNO.TabIndex = 150
        Me.rbNOTARIOINTERNO.TabStop = True
        Me.rbNOTARIOINTERNO.Text = "Interno"
        Me.rbNOTARIOINTERNO.UseVisualStyleBackColor = False
        '
        'rbNOTARIOEXTERNO
        '
        Me.rbNOTARIOEXTERNO.AutoSize = True
        Me.rbNOTARIOEXTERNO.BackColor = System.Drawing.Color.White
        Me.rbNOTARIOEXTERNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNOTARIOEXTERNO.Location = New System.Drawing.Point(599, 356)
        Me.rbNOTARIOEXTERNO.Name = "rbNOTARIOEXTERNO"
        Me.rbNOTARIOEXTERNO.Size = New System.Drawing.Size(62, 18)
        Me.rbNOTARIOEXTERNO.TabIndex = 151
        Me.rbNOTARIOEXTERNO.TabStop = True
        Me.rbNOTARIOEXTERNO.Text = "Externo"
        Me.rbNOTARIOEXTERNO.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(6, 383)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(89, 41)
        Me.Label28.TabIndex = 142
        Me.Label28.Text = "Fecha Notario entrega testimonio:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecNotario
        '
        Me.dtpFecNotario.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecNotario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNotario.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecNotario.Location = New System.Drawing.Point(101, 382)
        Me.dtpFecNotario.Name = "dtpFecNotario"
        Me.dtpFecNotario.Size = New System.Drawing.Size(203, 20)
        Me.dtpFecNotario.TabIndex = 21
        '
        'cbNOTARIOS
        '
        Me.cbNOTARIOS.BackColor = System.Drawing.Color.White
        Me.cbNOTARIOS.DisplayMember = "Notario"
        Me.cbNOTARIOS.FormattingEnabled = True
        Me.cbNOTARIOS.Location = New System.Drawing.Point(101, 355)
        Me.cbNOTARIOS.Name = "cbNOTARIOS"
        Me.cbNOTARIOS.Size = New System.Drawing.Size(428, 21)
        Me.cbNOTARIOS.TabIndex = 154
        Me.cbNOTARIOS.ValueMember = "IDNOTARIO"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtNoFolio)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txtNocomprobante)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtNoLibro)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtNoInscripcion)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(414, 68)
        Me.GroupBox5.TabIndex = 152
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Manual"
        '
        'txtNoFolio
        '
        Me.txtNoFolio.Location = New System.Drawing.Point(310, 40)
        Me.txtNoFolio.Name = "txtNoFolio"
        Me.txtNoFolio.Size = New System.Drawing.Size(90, 20)
        Me.txtNoFolio.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Correlativo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNocomprobante
        '
        Me.txtNocomprobante.Location = New System.Drawing.Point(110, 15)
        Me.txtNocomprobante.Name = "txtNocomprobante"
        Me.txtNocomprobante.Size = New System.Drawing.Size(90, 20)
        Me.txtNocomprobante.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(206, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "No. de Inscripción"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(6, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "No. de Libro"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoLibro
        '
        Me.txtNoLibro.Location = New System.Drawing.Point(110, 41)
        Me.txtNoLibro.Name = "txtNoLibro"
        Me.txtNoLibro.Size = New System.Drawing.Size(90, 20)
        Me.txtNoLibro.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(206, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Folio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoInscripcion
        '
        Me.txtNoInscripcion.Location = New System.Drawing.Point(310, 14)
        Me.txtNoInscripcion.Name = "txtNoInscripcion"
        Me.txtNoInscripcion.Size = New System.Drawing.Size(90, 20)
        Me.txtNoInscripcion.TabIndex = 1
        '
        'cbMODIF_DATOS_CERTIFICACION
        '
        Me.cbMODIF_DATOS_CERTIFICACION.AutoSize = True
        Me.cbMODIF_DATOS_CERTIFICACION.BackColor = System.Drawing.Color.White
        Me.cbMODIF_DATOS_CERTIFICACION.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMODIF_DATOS_CERTIFICACION.Location = New System.Drawing.Point(9, 139)
        Me.cbMODIF_DATOS_CERTIFICACION.Name = "cbMODIF_DATOS_CERTIFICACION"
        Me.cbMODIF_DATOS_CERTIFICACION.Size = New System.Drawing.Size(232, 18)
        Me.cbMODIF_DATOS_CERTIFICACION.TabIndex = 153
        Me.cbMODIF_DATOS_CERTIFICACION.Text = "Modificar datos de certificación extractada"
        Me.cbMODIF_DATOS_CERTIFICACION.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtNoAsiento)
        Me.GroupBox6.Controls.Add(Me.txtNoMatricula)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 77)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(414, 56)
        Me.GroupBox6.TabIndex = 130
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Computarizada"
        '
        'txtNoAsiento
        '
        Me.txtNoAsiento.Location = New System.Drawing.Point(310, 19)
        Me.txtNoAsiento.Name = "txtNoAsiento"
        Me.txtNoAsiento.Size = New System.Drawing.Size(90, 20)
        Me.txtNoAsiento.TabIndex = 5
        '
        'txtNoMatricula
        '
        Me.txtNoMatricula.Location = New System.Drawing.Point(110, 19)
        Me.txtNoMatricula.Name = "txtNoMatricula"
        Me.txtNoMatricula.Size = New System.Drawing.Size(90, 20)
        Me.txtNoMatricula.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "No. de Matrícula"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(206, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "No. de Asiento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSeccionRegistro
        '
        Me.txtSeccionRegistro.BackColor = System.Drawing.Color.White
        Me.txtSeccionRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeccionRegistro.Location = New System.Drawing.Point(163, 275)
        Me.txtSeccionRegistro.MaxLength = 100
        Me.txtSeccionRegistro.Name = "txtSeccionRegistro"
        Me.txtSeccionRegistro.ReadOnly = True
        Me.txtSeccionRegistro.Size = New System.Drawing.Size(497, 20)
        Me.txtSeccionRegistro.TabIndex = 144
        '
        'txtCodSeccion
        '
        Me.txtCodSeccion.BackColor = System.Drawing.Color.White
        Me.txtCodSeccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSeccion.Location = New System.Drawing.Point(101, 275)
        Me.txtCodSeccion.MaxLength = 2
        Me.txtCodSeccion.Name = "txtCodSeccion"
        Me.txtCodSeccion.Size = New System.Drawing.Size(56, 20)
        Me.txtCodSeccion.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "Municipio:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMunicipio
        '
        Me.txtMunicipio.BackColor = System.Drawing.Color.White
        Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMunicipio.Location = New System.Drawing.Point(163, 249)
        Me.txtMunicipio.MaxLength = 100
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.ReadOnly = True
        Me.txtMunicipio.Size = New System.Drawing.Size(497, 20)
        Me.txtMunicipio.TabIndex = 149
        '
        'txtCodMun
        '
        Me.txtCodMun.BackColor = System.Drawing.Color.White
        Me.txtCodMun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMun.Location = New System.Drawing.Point(101, 249)
        Me.txtCodMun.MaxLength = 2
        Me.txtCodMun.Name = "txtCodMun"
        Me.txtCodMun.Size = New System.Drawing.Size(56, 20)
        Me.txtCodMun.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(6, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 31)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Ubicación Inmueble:"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.BackColor = System.Drawing.Color.White
        Me.txtUbicacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(101, 163)
        Me.txtUbicacion.Multiline = True
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUbicacion.Size = New System.Drawing.Size(559, 28)
        Me.txtUbicacion.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(6, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Área:"
        '
        'txtDpto
        '
        Me.txtDpto.BackColor = System.Drawing.Color.White
        Me.txtDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDpto.Location = New System.Drawing.Point(163, 223)
        Me.txtDpto.MaxLength = 30
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.ReadOnly = True
        Me.txtDpto.Size = New System.Drawing.Size(497, 20)
        Me.txtDpto.TabIndex = 146
        '
        'txtCodDpto
        '
        Me.txtCodDpto.BackColor = System.Drawing.Color.White
        Me.txtCodDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDpto.Location = New System.Drawing.Point(101, 223)
        Me.txtCodDpto.MaxLength = 2
        Me.txtCodDpto.Name = "txtCodDpto"
        Me.txtCodDpto.Size = New System.Drawing.Size(56, 20)
        Me.txtCodDpto.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(8, 356)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 16)
        Me.Label17.TabIndex = 116
        Me.Label17.Text = "Notario:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.Color.White
        Me.txtArea.Location = New System.Drawing.Point(101, 197)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(203, 20)
        Me.txtArea.TabIndex = 7
        '
        'txtNumLibro
        '
        Me.txtNumLibro.BackColor = System.Drawing.Color.White
        Me.txtNumLibro.Location = New System.Drawing.Point(101, 329)
        Me.txtNumLibro.Name = "txtNumLibro"
        Me.txtNumLibro.Size = New System.Drawing.Size(203, 20)
        Me.txtNumLibro.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 330)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 17)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "No. Libro:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.White
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(6, 223)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(80, 16)
        Me.Label38.TabIndex = 101
        Me.Label38.Text = "Departamento:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Sección CNR:"
        '
        'txtNoEscritura
        '
        Me.txtNoEscritura.BackColor = System.Drawing.Color.White
        Me.txtNoEscritura.Location = New System.Drawing.Point(457, 301)
        Me.txtNoEscritura.Name = "txtNoEscritura"
        Me.txtNoEscritura.Size = New System.Drawing.Size(203, 20)
        Me.txtNoEscritura.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Tipo de Registro:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(310, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 17)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "No. Escritura:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbTipoTransaccion
        '
        Me.cbTipoTransaccion.BackColor = System.Drawing.Color.White
        Me.cbTipoTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoTransaccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoTransaccion.Items.AddRange(New Object() {"No. de Asiento de Compraventa", "No. de Asiento de Hipoteca", "No. de Asiento de Modificación"})
        Me.cbTipoTransaccion.Location = New System.Drawing.Point(101, 301)
        Me.cbTipoTransaccion.Name = "cbTipoTransaccion"
        Me.cbTipoTransaccion.Size = New System.Drawing.Size(203, 22)
        Me.cbTipoTransaccion.TabIndex = 11
        '
        'tb
        '
        Me.tb.Controls.Add(Me.TabPage1)
        Me.tb.Controls.Add(Me.TabPage2)
        Me.tb.Controls.Add(Me.TabPage3)
        Me.tb.Controls.Add(Me.TabPage6)
        Me.tb.Controls.Add(Me.TabPage4)
        Me.tb.Location = New System.Drawing.Point(23, 149)
        Me.tb.Name = "tb"
        Me.tb.SelectedIndex = 0
        Me.tb.Size = New System.Drawing.Size(672, 469)
        Me.tb.TabIndex = 10
        '
        'btnSig1
        '
        Me.btnSig1.Location = New System.Drawing.Point(539, 624)
        Me.btnSig1.Name = "btnSig1"
        Me.btnSig1.Size = New System.Drawing.Size(75, 28)
        Me.btnSig1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSig1.TabIndex = 231
        Me.btnSig1.Text = "&Siguiente"
        Me.btnSig1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSig1.UseSelectable = True
        Me.btnSig1.UseStyleColors = True
        '
        'btAtras1
        '
        Me.btAtras1.Location = New System.Drawing.Point(458, 624)
        Me.btAtras1.Name = "btAtras1"
        Me.btAtras1.Size = New System.Drawing.Size(75, 28)
        Me.btAtras1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btAtras1.TabIndex = 230
        Me.btAtras1.Text = "&Atras"
        Me.btAtras1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btAtras1.UseSelectable = True
        Me.btAtras1.UseStyleColors = True
        '
        'btnCertExt1
        '
        Me.btnCertExt1.Location = New System.Drawing.Point(308, 624)
        Me.btnCertExt1.Name = "btnCertExt1"
        Me.btnCertExt1.Size = New System.Drawing.Size(144, 28)
        Me.btnCertExt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCertExt1.TabIndex = 229
        Me.btnCertExt1.Text = "&Certificación Extractada"
        Me.btnCertExt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCertExt1.UseSelectable = True
        Me.btnCertExt1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(620, 624)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 232
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsGrInscripcionGarantia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(718, 690)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btnSig1)
        Me.Controls.Add(Me.btAtras1)
        Me.Controls.Add(Me.btnCertExt1)
        Me.Controls.Add(Me.C1nPlazoHA)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dtpFecOtorgHA)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.c1nMontoHA)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.c1nSegDesembolsoHA)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsGrInscripcionGarantia"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Inscripción de Garantía"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.C1nPlazoHA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoHA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSegDesembolsoHA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoMH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgINSCRIPCIONPRESTAMOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.fgInmueble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tb.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub frmMsGrInscripcionGarantia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.dtpFecNotario.Visible = False
            Me.Label28.Visible = False
            If Me.vOPERACION = 0 Then
                CARGARNOTARIOS()
                Me.btnGUARDAR_MODIF1.Enabled = False
                llenarTIPOSHIPOTECAS()
                CARGARDATOSCERTIFICACION(1) 'MUESTRA LOS DATOS CORRESPONDIENTES A LA CERTIFICACIÓN EXTRACTADA
                CARGARDATOS_DUENOSINMUEBLE(1) ' MUESTRA LOS DATOS CORRESPONDIENTE A LOS DUEÑOS DEL INMUEBLE DA LA GARANTIA CONSULTADA
                CARGAR_DATOS_GENERALES_PRESTAMO()
                CARGARDATOS_GARANTIAS(vNOCOMPROBANTE)
                Me.cbMODIF_DATOS_CERTIFICACION.Enabled = False
                SOLO_LECTURA_CE()
                SOLO_LECTURA()
                CARGAR_DATOSINSCRIPCIONPRESTAMOS(vNOCOMPROBANTE)
                Me.btAdd1.Enabled = False
                Me.btDel1.Enabled = False
                Me.btnGuardar1.Enabled = False
            ElseIf Me.vOPERACION = 1 Then
                CARGARNOTARIOS()
                Me.btnGUARDAR_MODIF1.Enabled = False
                CARGARDATOS_DUENOSINMUEBLE(1)
                DESHABILITAR_MODIFICACION_HIPOTECA()
                CARGARDATOSCERTIFICACION(1) 'MUESTRA LOS DATOS CORRESPONDIENTES A LA CERTIFICACIÓN EXTRACTADA
                CARGAR_DATOS_GENERALES_PRESTAMO()
                SOLO_LECTURA_CE()
                llenarTIPOSHIPOTECAS()
                Me.btAdd1.Enabled = False
                Me.btDel1.Enabled = False
                Me.btnGuardar1.Text = "&Guardar"
            ElseIf Me.vOPERACION = 2 Then
                CARGARNOTARIOS()
                llenarTIPOSHIPOTECAS()
                SOLO_LECTURA_CE()
                CARGARDATOSCERTIFICACION(1) 'MUESTRA LOS DATOS CORRESPONDIENTES A LA CERTIFICACIÓN EXTRACTADA
                CARGARDATOS_GARANTIAS(vNOCOMPROBANTE)
                CARGAR_DATOS_GENERALES_PRESTAMO()
                CARGARDATOS_DUENOSINMUEBLE(1)
                Me.btnGuardar1.Text = "&Modificar"
                CARGAR_DATOSINSCRIPCIONPRESTAMOS(vNOCOMPROBANTE)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub llenarTIPOSHIPOTECAS()
        Dim DTS As New DataSet
        DTS = CRED.CONSULTAR_GRTIPOHIPOTECAS(sUsuario, sPassword, sSucursal)
        Me.cbTipoHipoteca.DataSource = DTS.Tables(0)
    End Sub
    Private Sub CARGARDATOSCERTIFICACION(ByVal OPCION As Integer)
        'OPCION 1
        Dim DTS As New DataSet
        DTS = CRED.CONSULTARDET_CERTIFICACIONEXTRACTADA(sUsuario, sPassword, sSucursal, vNumSolicitud, OPCION, vNOCOMPROBANTE_CERTIFICACION.Trim)
        Me.txtCodDpto.Text = DTS.Tables(0).Rows(0).Item("CODDEPARTAMENTO").ToString.Trim
        Me.txtDpto.Text = DTS.Tables(0).Rows(0).Item("DEPARTAMENTO").ToString.Trim
        Me.txtCodMun.Text = DTS.Tables(0).Rows(0).Item("CODMUNICIPIO").ToString.Trim
        Me.txtMunicipio.Text = DTS.Tables(0).Rows(0).Item("MUNICIPIO").ToString.Trim
        Me.txtCodSeccion.Text = DTS.Tables(0).Rows(0).Item("CODSECCION").ToString.Trim
        Me.txtSeccionRegistro.Text = DTS.Tables(0).Rows(0).Item("SECCION").ToString.Trim
        Me.txtArea.Text = DTS.Tables(0).Rows(0).Item("AREA").ToString.Trim
        Me.txtUbicacion.Text = DTS.Tables(0).Rows(0).Item("UBICACION").ToString.Trim
        Me.txtNoMatricula.Text = DTS.Tables(0).Rows(0).Item("NOMATRICULA").ToString.Trim
    End Sub
    Private Sub CARGAR_DATOS_GENERALES_PRESTAMO()
        Dim DTS As New DataSet
        DTS = CRED.CONSULTAR_DATOSGENERALESASOCIADOS(sUsuario, sPassword, sSucursal, vNumSolicitud)
        Me.lblConcedido.Text = Me.lblConcedido.Text + " " + DTS.Tables(0).Rows(0).Item("ASOCIADO").ToString.Trim
        Me.lblMonto.Text = Me.lblMonto.Text + " " + DTS.Tables(0).Rows(0).Item("MONTO").ToString.Trim
        Me.lblPlazo.Text = Me.lblPlazo.Text + " " + DTS.Tables(0).Rows(0).Item("PLAZO").ToString.Trim
        Me.lblTasaInt.Text = Me.lblTasaInt.Text + " " + DTS.Tables(0).Rows(0).Item("TASA_INTERES").ToString.Trim
        Me.lblFechaOtorg.Text = Me.lblFechaOtorg.Text + " " + DTS.Tables(0).Rows(0).Item("FECHAOTORGAMIENTO").ToString.Trim
        Me.lblFechaVenc.Text = Me.lblFechaVenc.Text + " " + DTS.Tables(0).Rows(0).Item("FECHAVENCIMIENTO").ToString.Trim
        Me.lblESTADO.Text = Me.lblESTADO.Text + " " + DTS.Tables(0).Rows(0).Item("ESTADO").ToString.Trim
        'CONSULTAMOS SI LA GARANTIA TIENE ALGUN HISTORICO
        If vOPERACION = 2 Then
            Dim DTS_HISTO As New DataSet
            DTS_HISTO = CRED.CONSULTAR_GRHISTOINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, txtNocomprobante.Text.Trim)
            Me.monto = DTS.Tables(0).Rows(0).Item("MONTO")
            Me.plazo = DTS.Tables(0).Rows(0).Item("PLAZO")
            Me.tasa = DTS.Tables(0).Rows(0).Item("TASA_INTERES")
        ElseIf vOPERACION = 1 Then
            Me.monto = DTS.Tables(0).Rows(0).Item("MONTO")
            Me.plazo = DTS.Tables(0).Rows(0).Item("PLAZO")
            Me.tasa = DTS.Tables(0).Rows(0).Item("TASA_INTERES")
        End If
        vDui = DTS.Tables(0).Rows(0).Item("DUI")

    End Sub
    Private Sub CARGARDATOS_DUENOSINMUEBLE(ByVal OPCION As Integer)
        Dim DTS As New DataSet
        DTS = CRED.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, OPCION, vNOCOMPROBANTE_CERTIFICACION, 0)
        Me.fgInmueble.DataSource = DTS.Tables(0)
    End Sub
    Private Sub DESHABILITAR_MODIFICACION_HIPOTECA()
        Me.dtpFecOtorgMH.Enabled = False
        Me.c1nPlazo.Enabled = False
        Me.c1nMontoMH.Enabled = False
        Me.c1nTasa.Enabled = False
        Me.dtpFecPresMH.Enabled = False
        Me.dtpFecInscMH.Enabled = False
        Me.txtNoInscMH.Enabled = False
        Me.txtObsMH.Enabled = False
    End Sub
    Private Sub CARGARDATOS_GARANTIAS(ByVal NOCOMPROBANTE As String)
        Dim DTS As New DataSet
        Dim TIPONOTARIO As Integer
        DTS = CRED.CONSULTARINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, 0, 2, NOCOMPROBANTE, " ", " ")
        Me.txtNocomprobante.Text = DTS.Tables(0).Rows(0).Item("NOCOMPROBANTE").ToString.Trim
        Me.txtNoInscripcion.Text = DTS.Tables(0).Rows(0).Item("NOINSCRIPCION").ToString.Trim
        Me.txtNoLibro.Text = DTS.Tables(0).Rows(0).Item("NOLIBRO").ToString.Trim
        Me.txtNoFolio.Text = DTS.Tables(0).Rows(0).Item("NOFOLIO").ToString.Trim
        Me.txtNoMatricula.Text = DTS.Tables(0).Rows(0).Item("NOMATRICULA").ToString.Trim
        Me.txtNoAsiento.Text = DTS.Tables(0).Rows(0).Item("NOASIENTO").ToString.Trim
        cbTipoTransaccion.SelectedIndex = DTS.Tables(0).Rows(0).Item("TIPOTRANSACCION").ToString.Trim
        Me.txtNoEscritura.Text = DTS.Tables(0).Rows(0).Item("NOESCRITURA").ToString.Trim
        Me.txtNumLibro.Text = DTS.Tables(0).Rows(0).Item("NUMLIBRO").ToString.Trim
        Me.cbTipoHipoteca.SelectedIndex = DTS.Tables(0).Rows(0).Item("TIPOHIPOTECA").ToString.Trim
        Me.dtpFecCNR.Value = DTS.Tables(0).Rows(0).Item("FECCNR").ToString.Trim
        Me.txtNoPres.Text = DTS.Tables(0).Rows(0).Item("NOPRESENTACION").ToString.Trim
        Me.dtpFecCons.Value = DTS.Tables(0).Rows(0).Item("FECCONSULTA").ToString.Trim
        Me.cbEstado.SelectedIndex = DTS.Tables(0).Rows(0).Item("SITUACION").ToString.Trim
        Me.dtpFecha.Value = DTS.Tables(0).Rows(0).Item("FECHA").ToString.Trim
        Me.txtObs.Text = DTS.Tables(0).Rows(0).Item("OBS").ToString.Trim
        c1nPlazo.Value = DTS.Tables(0).Rows(0).Item("PLAZO").ToString.Trim
        Me.c1nMontoMH.Value = DTS.Tables(0).Rows(0).Item("MONTO_HIPOTECAA").ToString.Trim
        Me.c1nTasa.Value = DTS.Tables(0).Rows(0).Item("TASA_INTERES").ToString.Trim
        Me.dtpFecPresMH.Value = DTS.Tables(0).Rows(0).Item("FECCNR").ToString.Trim
        Me.dtpFecInscMH.Value = DTS.Tables(0).Rows(0).Item("FECHA").ToString.Trim
        Me.txtNoInscMH.Text = DTS.Tables(0).Rows(0).Item("NOINSCRIPCION").ToString.Trim
        Me.txtObsMH.Text = DTS.Tables(0).Rows(0).Item("OBS").ToString.Trim
        TIPONOTARIO = DTS.Tables(0).Rows(0).Item("TIPONOTARIO")
        cbNOTARIOS.SelectedValue = DTS.Tables(0).Rows(0).Item("IDNOTARIO")
        If TIPONOTARIO = 0 Then
            Me.rbNOTARIOINTERNO.Checked = True
        Else
            Me.rbNOTARIOEXTERNO.Checked = True
            Me.dtpFecNotario.Value = DTS.Tables(0).Rows(0).Item("FECHA_ENTREGATEST")
        End If

    End Sub
    Protected Sub SOLO_LECTURA()
        Me.txtNocomprobante.ReadOnly = True
        Me.txtNoInscripcion.ReadOnly = True
        Me.txtNoLibro.ReadOnly = True
        Me.txtNoFolio.ReadOnly = True
        Me.txtNoMatricula.ReadOnly = True
        Me.txtNoAsiento.ReadOnly = True
        Me.cbTipoTransaccion.Enabled = False
        Me.txtNoEscritura.ReadOnly = True
        Me.txtNumLibro.ReadOnly = True
        Me.cbTipoHipoteca.Enabled = False
        Me.dtpFecCNR.Enabled = False
        Me.txtNoPres.ReadOnly = True
        Me.dtpFecCons.Enabled = False
        Me.cbEstado.Enabled = False
        Me.dtpFecha.Enabled = False
        Me.txtObs.ReadOnly = True
        Me.c1nPlazo.ReadOnly = True
        Me.c1nMontoMH.ReadOnly = True
        Me.c1nTasa.ReadOnly = True
        Me.dtpFecPresMH.Enabled = False
        Me.dtpFecInscMH.Enabled = False
        Me.txtNoInscMH.ReadOnly = True
        Me.txtObsMH.ReadOnly = True
        Me.rbNOTARIOINTERNO.Enabled = False
        Me.rbNOTARIOEXTERNO.Enabled = False
    End Sub
    Protected Sub HABILITAR_CE()
        Me.txtCodDpto.Enabled = True
        Me.txtDpto.Enabled = True
        Me.txtCodMun.Enabled = True
        Me.txtMunicipio.ReadOnly = False
        Me.txtCodSeccion.Enabled = True
        Me.txtSeccionRegistro.ReadOnly = False
        Me.txtArea.ReadOnly = False
        Me.txtUbicacion.ReadOnly = False
    End Sub
    Protected Sub SOLO_LECTURA_CE()
        Me.txtCodDpto.Enabled = False
        Me.txtDpto.Enabled = False
        Me.txtCodMun.Enabled = False
        Me.txtMunicipio.ReadOnly = True
        Me.txtCodSeccion.Enabled = False
        Me.txtSeccionRegistro.ReadOnly = True
        Me.txtArea.ReadOnly = True
        Me.txtUbicacion.ReadOnly = True
    End Sub
    Private Sub txtNocomprobante_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNocomprobante.LostFocus
        Me.pNoDoc = Me.txtNocomprobante.Text.Trim
    End Sub

    Private Sub txtCodDeptoEntrega_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet, Filas As Data.DataRowCollection

        Try
            ofrm.Text = "Buscar Departamentos..."
            ds = oPlan.ConsultarPLDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado2.Trim <> "" Then
                ' Me.txtCodDeptoEntrega.Text = ofrm.Resultado2.Trim
                'Me.txtDeptoEntrega.Text = ofrm.Resultado3.Trim
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub
    Private Sub txtCodDeptoRecibe_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet, Filas As Data.DataRowCollection

        Try
            ofrm.Text = "Buscar Departamentos..."
            ds = oPlan.ConsultarPLDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado2.Trim <> "" Then
                'Me.txtCodDeptoRecibe.Text = ofrm.Resultado2.Trim
                'Me.txtDeptoRecibe.Text = ofrm.Resultado3.Trim
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub
    Private Sub txtCodSeccion_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodSeccion.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Sección del Registro"
        Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            ds = oCred.ConsultarSeccionRegistro("*", "", "CodSeccion", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodSeccion.Text = ofrm.Resultado.Trim
            txtSeccionRegistro.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Sección del Registro - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCodMun_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodMun.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Municipios"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
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
            txtCodMun.Text = ofrm.Resultado2.Trim
            txtMunicipio.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Municipios - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCodMun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodMun.KeyPress
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarMunicipios("*", "CodDepartamento ='" & Trim(txtCodDpto.Text) & "' and  CodMunicipio='" & Trim(txtCodMun.Text) & "'", "CodMunicipio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Municipio") Is DBNull.Value) Then
                        txtMunicipio.Text = CStr(Filas.Item(0)("Municipio"))
                    End If
                Else
                    txtCodMun_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Municipios  - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCodDpto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodDpto.KeyPress
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarDepartamentos("*", "CodDepartamento='" & Trim(txtCodDpto.Text) & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Departamento") Is DBNull.Value) Then
                        txtDpto.Text = CStr(Filas.Item(0)("Departamento"))
                        Me.txtCodMun.Text = ""
                        Me.txtMunicipio.Text = ""
                        txtCodMun.Focus()
                    End If
                Else
                    txtCodDpto_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Departamentos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCodDpto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDpto.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Departamentos"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodDpto.Text = ofrm.Resultado.Trim
            Me.txtDpto.Text = ofrm.Resultado2.Trim
            Me.txtCodMun.Text = ""
            Me.txtMunicipio.Text = ""
            txtCodMun.Focus()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Departamentos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function INSERTAR_INSCRIPCIONPRESTAMOS(ByVal CODPRESTAMO As String, ByVal NUMSOLICITUD As Integer) As Integer
        Dim RESULTADO As Integer
        Try
            RESULTADO = CRED.INSERTARPRESTAMOSINSCRIPCION(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, NUMSOLICITUD)
            If RESULTADO = 1 Then
                MsgBox("Prestamo asigando exitosamente.", MsgBoxStyle.Information, "MODÚLO - GARANTÍAS")
            End If
        Catch ex As Exception
        End Try
        Return RESULTADO
    End Function
    Private Sub rbNOTARIOEXTERNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rbNOTARIOEXTERNO.Checked = True Then
            Me.Label28.Visible = True
            Me.dtpFecNotario.Visible = True
        End If
    End Sub
    Private Sub rbNOTARIOEXTERNO_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNOTARIOEXTERNO.CheckedChanged
        If Me.rbNOTARIOEXTERNO.Checked = True Then
            Me.Label28.Visible = True
            Me.dtpFecNotario.Visible = True
        End If
    End Sub
    Private Sub rbNOTARIOINTERNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNOTARIOINTERNO.CheckedChanged
        If Me.rbNOTARIOINTERNO.Checked = True Then
            Me.Label28.Visible = False
            Me.dtpFecNotario.Visible = False
        End If
    End Sub

    Private Sub btNewInmueble1_Click(sender As Object, e As EventArgs) Handles btNewInmueble1.Click
        Try
            Dim ofrm As New fmMsGrDuenosInmueble
            ofrm.NoDoc = Me.pNoDoc
            ofrm.Tipo = "I"
            ofrm.Accion = "Guardar"
            ofrm.ShowDialog()
            Dim oCred As New wrCredito.wsLibCred
            Me.fgInmueble.DataSource = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 1, Me.pNoDoc, 0).Tables(0)

            fgInmueble.Cols.Item(0).Width = 0
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btEditInmueble1_Click(sender As Object, e As EventArgs) Handles btEditInmueble1.Click
        Try
            If fgInmueble.Row > 0 Then
                Dim ofrm As New fmMsGrDuenosInmueble
                ofrm.NoDoc = Me.pNoDoc
                ofrm.Correlativo = fgInmueble.Item(fgInmueble.Row, "Correlativo")
                ofrm.Tipo = "I"
                ofrm.Accion = "Modificar"
                ofrm.ShowDialog()
                Dim oCred As New wrCredito.wsLibCred
                Me.fgInmueble.DataSource = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 1, Me.pNoDoc, 0).Tables(0)
                'Me.fgInmueble.DataSource = oCred.ConsultarDuenosInmueble("Correlativo,Nombre,Porcentaje,Asociado", "NoComprobante='" & Me.pNoDoc & "'", "Correlativo", sUsuario, sPassword,sSucursal).Tables(0)
                fgInmueble.Cols.Item(0).Width = 0
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btDelInmueble1_Click(sender As Object, e As EventArgs) Handles btDelInmueble1.Click
        Try
            If Me.fgInmueble.Row > 0 Then
                If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Bien Inmueble", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim oCred As New wrCredito.wsLibCred
                    oCred.EliminarDuenosInmueble(Me.fgInmueble.Item(Me.fgInmueble.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                    Me.fgInmueble.DataSource = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 1, Me.pNoDoc, 0).Tables(0)
                    'Me.fgInmueble.DataSource = oCred.ConsultarDuenosInmueble("Correlativo,Nombre,Porcentaje,Asociado", "NoComprobante='" & Me.pNoDoc & "'", "Correlativo", sUsuario, sPassword,sSucursal).Tables(0)
                    fgInmueble.Cols.Item(0).Width = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btAdd1_Click(sender As Object, e As EventArgs) Handles btAdd1.Click
        Dim frm As New frmMsConsultarPrestamos
        Dim sTexto As String
        Try
            frm.vNOCOMPROBATE = vNOCOMPROBANTE
            frm.vDUI = vDui
            frm.ShowDialog()
            CARGAR_DATOSINSCRIPCIONPRESTAMOS(vNOCOMPROBANTE)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btDel1_Click(sender As Object, e As EventArgs) Handles btDel1.Click
        Try
            If Me.dgINSCRIPCIONPRESTAMOS.RowCount > 0 Then
                Dim CORRELATIVO As Integer
                Dim RESULTADO As Integer
                CORRELATIVO = Me.dgINSCRIPCIONPRESTAMOS.CurrentRow.Cells("CORRELATIVO").Value
                If MsgBox("¿Está seguro que desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Registro") = MsgBoxResult.Yes Then
                    RESULTADO = CRED.ELIMINARPRESTAMOSINSCRIPCION(sUsuario, sPassword, sSucursal, CORRELATIVO)
                    If RESULTADO = 1 Then
                        CARGAR_DATOSINSCRIPCIONPRESTAMOS(vNOCOMPROBANTE)
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnVER_HISTO1_Click(sender As Object, e As EventArgs) Handles btnVER_HISTO1.Click
        Try
            Dim NOCOMPROBANTE As String
            Dim FRMHG As New frmMsGrHistorialGarantias
            NOCOMPROBANTE = txtNocomprobante.Text.Trim
            FRMHG.vNOCOMPROBANTE = NOCOMPROBANTE
            FRMHG.vNUMSOLICITUD = vNumSolicitud
            FRMHG.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGUARDAR_MODIF1_Click(sender As Object, e As EventArgs) Handles btnGUARDAR_MODIF1.Click
        Try
            Dim DTS As New DataSet
            Dim MODIFICACION As Integer
            Dim RESULTADO, PLAZO As Integer
            Dim FECHA_MODIFICACION, FEC_PRESENTACION_HIPOTECA, FEC_INSCRIPCION_HIPOTECA As DateTime
            Dim MONTO, TASA_INTERES As Double
            Dim NOINSCRIPCION, OBSERVACION As String
            DTS = CRED.CONSULTARINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, 0, 2, vNOCOMPROBANTE, " ", " ")
            FECHA_MODIFICACION = Now
            MONTO = DTS.Tables(0).Rows(0).Item("MONTO_HIPOTECAA")
            FEC_PRESENTACION_HIPOTECA = DTS.Tables(0).Rows(0).Item("FECCNR")
            FEC_INSCRIPCION_HIPOTECA = DTS.Tables(0).Rows(0).Item("FECHA")
            NOINSCRIPCION = DTS.Tables(0).Rows(0).Item("NOINSCRIPCION")
            OBSERVACION = DTS.Tables(0).Rows(0).Item("OBS")
            TASA_INTERES = DTS.Tables(0).Rows(0).Item("TASA_INTERES")
            PLAZO = DTS.Tables(0).Rows(0).Item("PLAZO")
            'INGRESAMOS LOS DATOS ORIGINALES EN LA TABLA HISTORICA
            RESULTADO = CRED.INSERTAR_GRHISTOINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, Me.vNOCOMPROBANTE,
                                                                  Format(FECHA_MODIFICACION, "SHORT DATE"), MONTO, Format(FEC_PRESENTACION_HIPOTECA, "SHORT DATE"), Format(FEC_INSCRIPCION_HIPOTECA, "SHORT DATE"),
                                                                  NOINSCRIPCION, OBSERVACION, TASA_INTERES, PLAZO, Now)
            'ACTUALIZAMOS LOS VALORES MODIFICADOS EN GRINSCRIPCIONGARANTIA
            MODIFICACION = CRED.MODIFICAR_DATOSCNR_GRINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, Format(Me.dtpFecOtorgMH.Value, "SHORT DATE"), Me.c1nPlazo.Value,
                                                                          c1nMontoMH.Value, c1nTasa.Value, Format(dtpFecPresMH.Value, "SHORT DATE"), Format(Me.dtpFecInscMH.Value, "SHORT DATE"),
                                                                          Me.txtNoInscMH.Text.Trim, Me.txtObsMH.Text.Trim, Me.vNOCOMPROBANTE, Now)
            If MODIFICACION <> 0 And RESULTADO <> 0 Then
                MsgBox("Modificación realizada exitosamente", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
            ElseIf MODIFICACION <> 0 And RESULTADO = 0 Then
                MsgBox("Error al guardar el registro historico, Modificación realizada exitosamente", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
            Else
                MsgBox("Error al realizar la Modificación.", MsgBoxStyle.Critical, "MÓDULO - GARANTÍAS")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCertExt1_Click(sender As Object, e As EventArgs) Handles btnCertExt1.Click
        Try
            Dim frm As New frmMsCertificacionExtractada
            frm.NumSolicitud = vNumSolicitud
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btAtras1_Click(sender As Object, e As EventArgs) Handles btAtras1.Click
        Try
            Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnSig1_Click(sender As Object, e As EventArgs) Handles btnSig1.Click
        Try
            Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim TIPONOTARIO As Integer
            If Me.rbNOTARIOINTERNO.Checked = True Then
                TIPONOTARIO = 0
            Else
                TIPONOTARIO = 1
            End If
            Select Case CRED.AutorizarDatos(Trim(Me.txtNocomprobante.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El No. de Comprobante no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Garantías")
                    Exit Sub
            End Select
            'Dim i As Integer = Me.fgPr.RowSel
            Dim RESULTADO As Integer
            If vOPERACION = 1 Then
                RESULTADO = CRED.INSERTARINSCRIPCIONGARANTIA(
                sUsuario, sPassword, sSucursal, txtNocomprobante.Text.Trim, Format(dtpFecha.Value, "SHORT DATE"), Me.txtNoInscripcion.Text.Trim,
                Me.txtNoLibro.Text.Trim, Me.txtNoMatricula.Text.Trim, txtNoAsiento.Text.Trim, txtNoFolio.Text.Trim, cbTipoTransaccion.SelectedIndex,
                Me.txtNoEscritura.Text.Trim, Me.txtNumLibro.Text.Trim, Format(Me.dtpFecCNR.Value, "SHORT DATE"), Me.txtNoPres.Text.Trim,
                Format(Me.dtpFecCons.Value, "SHORT DATE"), Me.cbEstado.SelectedIndex, Me.txtObs.Text.Trim, vNumSolicitud, "I",
                Format(dtpFecNotario.Value, "SHORT DATE"), cbTipoHipoteca.SelectedIndex, Me.plazo, Me.tasa,
                Now, Me.monto, Me.plazo, vIDANOTACION,
                vNOCOMPROBANTE_CERTIFICACION, TIPONOTARIO, sUsuario, Now, Me.cbNOTARIOS.SelectedValue)
                If RESULTADO <> 0 Then
                    'INGRESAMOS EL GRINSCRIPCIONPRESTAMOS EL CODIGO DEL PRESTAMO CORRESPONDIENTE A LA GARANTIA.
                    Dim RESULTADO2 As Integer
                    RESULTADO2 = CRED.INSERTARPRESTAMOSINSCRIPCION(sUsuario, sPassword, sSucursal, txtNocomprobante.Text.Trim, vNumSolicitud)
                    If RESULTADO2 <> 0 Then
                        MsgBox("Garantía agregada exitosamente", MsgBoxStyle.Information, "Módulo - Garantías")
                    End If
                End If
            ElseIf vOPERACION = 2 Then
                RESULTADO = CRED.MODIFICARINSCRIPCIONGARANTIA(
                sUsuario, sPassword, sSucursal, txtNocomprobante.Text.Trim, Format(dtpFecha.Value, "SHORT DATE"), Me.txtNoInscripcion.Text.Trim,
                Me.txtNoLibro.Text.Trim, Me.txtNoMatricula.Text.Trim, txtNoAsiento.Text.Trim, txtNoFolio.Text.Trim, cbTipoTransaccion.SelectedIndex,
                Me.txtNoEscritura.Text.Trim, Me.txtNumLibro.Text.Trim, Format(Me.dtpFecCNR.Value, "SHORT DATE"), Me.txtNoPres.Text.Trim,
                Format(Me.dtpFecCons.Value, "SHORT DATE"), Me.cbEstado.SelectedIndex, Me.txtObs.Text.Trim, vNumSolicitud, "I",
                Format(dtpFecNotario.Value, "SHORT DATE"), cbTipoHipoteca.SelectedIndex, Me.plazo, Me.tasa,
                Now, Me.monto, Me.plazo, vIDANOTACION,
                vNOCOMPROBANTE_CERTIFICACION, TIPONOTARIO, sUsuario, Now, Me.cbNOTARIOS.SelectedValue)
                If RESULTADO <> 0 Then
                    If Me.cbMODIF_DATOS_CERTIFICACION.Checked = True Then
                        MODIFICAR_CERTIFICACIONEXTRACTADA()
                    End If
                    MsgBox("Datos generales de garantía modificados exitosamente.", MsgBoxStyle.Information, "Módulo - Garantías")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub CARGAR_DATOSINSCRIPCIONPRESTAMOS(ByVal NOCOMPROBANTE)
        Dim DTS As New DataSet
        DTS = CRED.CONSULTARGRPRESTAMOSINSCRIPCION(sUsuario, sPassword, sSucursal, NOCOMPROBANTE, 1)
        If DTS.Tables(0).Rows.Count > 0 Then
            Me.dgINSCRIPCIONPRESTAMOS.DataSource = DTS.Tables(0)
        End If
        HEADERDG_INSCRIPCIONPRESTAMOS()
    End Sub
    Protected Sub HEADERDG_INSCRIPCIONPRESTAMOS()
        If Me.dgINSCRIPCIONPRESTAMOS.Rows.Count > 0 Then
            Me.dgINSCRIPCIONPRESTAMOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Me.dgINSCRIPCIONPRESTAMOS.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            Me.dgINSCRIPCIONPRESTAMOS.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            Me.dgINSCRIPCIONPRESTAMOS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.dgINSCRIPCIONPRESTAMOS.Columns.Item("CORRELATIVO").Visible = False
        End If
    End Sub
    Protected Sub MODIFICAR_CERTIFICACIONEXTRACTADA()
        CRED.MODIFICARCERTIFICACIONEXTRACTADA(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE_CERTIFICACION, "01/01/1900", "", "", Me.txtNoMatricula.Text, "", _
                                              Me.txtUbicacion.Text.Trim, Me.txtArea.Text.Trim, Me.txtCodDpto.Text.Trim, Me.txtCodMun.Text.Trim, Me.txtCodSeccion.Text.Trim, _
                                              0, "", Now, 3)
    End Sub
    Private Sub cbMODIF_DATOS_CERTIFICACION_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMODIF_DATOS_CERTIFICACION.CheckedChanged
        If Me.cbMODIF_DATOS_CERTIFICACION.Checked = True Then
            HABILITAR_CE()
        Else
            SOLO_LECTURA_CE()
        End If
    End Sub
    Protected Sub CARGARNOTARIOS()
        Dim DTS As New DataSet
        DTS = CRED.CONSULTARGRNOTARIO(sUsuario, sPassword, sSucursal, 6, 0, "", "", "")
        cbNOTARIOS.DataSource = DTS.Tables(0)
    End Sub
End Class