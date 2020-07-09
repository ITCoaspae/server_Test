Public Class frmCertificacionExtractada
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim vCodPrestamo As String, vDui As String, vNoSocio As String, vNumSolicitud As Long, vAccion As String, pNoDoc As String
    Dim CREDITO As New wrCredito.wsLibCred '   SIF_ERP.wrCredito.wsLibCred
    Friend WithEvents btEditAcreedor1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDelAcreedor1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewAcreedor1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditInmueble1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelInmueble1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewInmueble1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditPres1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelPres1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewPres1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditRest1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelRest1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewRest1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSig1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btAtras1 As MetroFramework.Controls.MetroButton
    Public vORIGEN As Integer
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
    Friend WithEvents tb As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents fgAcreedor As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgInmueble As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents fgRestriccion As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblConcedido As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodDpto As System.Windows.Forms.TextBox
    Friend WithEvents txtDpto As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtCodMun As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fgPresentacion As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNocomprobante As System.Windows.Forms.TextBox
    Friend WithEvents gbAcreedores As System.Windows.Forms.GroupBox
    Friend WithEvents gbInmueble As System.Windows.Forms.GroupBox
    Friend WithEvents gbPresentaciones As System.Windows.Forms.GroupBox
    Friend WithEvents gbRestricciones As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodSeccion As System.Windows.Forms.TextBox
    Friend WithEvents txtSeccionRegistro As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertificacionExtractada))
        Me.tb = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCodSeccion = New System.Windows.Forms.TextBox()
        Me.txtSeccionRegistro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodDpto = New System.Windows.Forms.TextBox()
        Me.txtDpto = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtCodMun = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoAsiento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNoMatricula = New System.Windows.Forms.TextBox()
        Me.txtNoLibro = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNoInscripcion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNocomprobante = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbAcreedores = New System.Windows.Forms.GroupBox()
        Me.btEditAcreedor1 = New MetroFramework.Controls.MetroButton()
        Me.btnDelAcreedor1 = New MetroFramework.Controls.MetroButton()
        Me.fgAcreedor = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btNewAcreedor1 = New MetroFramework.Controls.MetroButton()
        Me.gbInmueble = New System.Windows.Forms.GroupBox()
        Me.btEditInmueble1 = New MetroFramework.Controls.MetroButton()
        Me.btDelInmueble1 = New MetroFramework.Controls.MetroButton()
        Me.btNewInmueble1 = New MetroFramework.Controls.MetroButton()
        Me.fgInmueble = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gbPresentaciones = New System.Windows.Forms.GroupBox()
        Me.btEditPres1 = New MetroFramework.Controls.MetroButton()
        Me.btDelPres1 = New MetroFramework.Controls.MetroButton()
        Me.btNewPres1 = New MetroFramework.Controls.MetroButton()
        Me.fgPresentacion = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gbRestricciones = New System.Windows.Forms.GroupBox()
        Me.btEditRest1 = New MetroFramework.Controls.MetroButton()
        Me.btDelRest1 = New MetroFramework.Controls.MetroButton()
        Me.btNewRest1 = New MetroFramework.Controls.MetroButton()
        Me.fgRestriccion = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcedido = New System.Windows.Forms.Label()
        Me.btnSig1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btAtras1 = New MetroFramework.Controls.MetroButton()
        Me.tb.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbAcreedores.SuspendLayout()
        CType(Me.fgAcreedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInmueble.SuspendLayout()
        CType(Me.fgInmueble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.gbPresentaciones.SuspendLayout()
        CType(Me.fgPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRestricciones.SuspendLayout()
        CType(Me.fgRestriccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb
        '
        Me.tb.Controls.Add(Me.TabPage1)
        Me.tb.Controls.Add(Me.TabPage2)
        Me.tb.Controls.Add(Me.TabPage3)
        Me.tb.Location = New System.Drawing.Point(28, 135)
        Me.tb.Name = "tb"
        Me.tb.SelectedIndex = 0
        Me.tb.Size = New System.Drawing.Size(758, 449)
        Me.tb.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(750, 420)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtCodSeccion)
        Me.GroupBox3.Controls.Add(Me.txtSeccionRegistro)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtCodDpto)
        Me.GroupBox3.Controls.Add(Me.txtDpto)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.txtCodMun)
        Me.GroupBox3.Controls.Add(Me.txtMunicipio)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtArea)
        Me.GroupBox3.Controls.Add(Me.txtUbicacion)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtNoAsiento)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtNoMatricula)
        Me.GroupBox3.Controls.Add(Me.txtNoLibro)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtNoInscripcion)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(10, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(729, 337)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS DE LA INSCRIPCIÓN"
        '
        'txtCodSeccion
        '
        Me.txtCodSeccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSeccion.Location = New System.Drawing.Point(128, 272)
        Me.txtCodSeccion.MaxLength = 2
        Me.txtCodSeccion.Name = "txtCodSeccion"
        Me.txtCodSeccion.Size = New System.Drawing.Size(77, 23)
        Me.txtCodSeccion.TabIndex = 8
        '
        'txtSeccionRegistro
        '
        Me.txtSeccionRegistro.BackColor = System.Drawing.Color.White
        Me.txtSeccionRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeccionRegistro.Location = New System.Drawing.Point(214, 272)
        Me.txtSeccionRegistro.MaxLength = 100
        Me.txtSeccionRegistro.Name = "txtSeccionRegistro"
        Me.txtSeccionRegistro.ReadOnly = True
        Me.txtSeccionRegistro.Size = New System.Drawing.Size(496, 23)
        Me.txtSeccionRegistro.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 32)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Sección del Registro:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodDpto
        '
        Me.txtCodDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDpto.Location = New System.Drawing.Point(130, 212)
        Me.txtCodDpto.MaxLength = 2
        Me.txtCodDpto.Name = "txtCodDpto"
        Me.txtCodDpto.Size = New System.Drawing.Size(76, 23)
        Me.txtCodDpto.TabIndex = 6
        '
        'txtDpto
        '
        Me.txtDpto.BackColor = System.Drawing.Color.White
        Me.txtDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDpto.Location = New System.Drawing.Point(214, 212)
        Me.txtDpto.MaxLength = 30
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.ReadOnly = True
        Me.txtDpto.Size = New System.Drawing.Size(496, 23)
        Me.txtDpto.TabIndex = 102
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(7, 212)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(96, 19)
        Me.Label38.TabIndex = 101
        Me.Label38.Text = "Departamento:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodMun
        '
        Me.txtCodMun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMun.Location = New System.Drawing.Point(128, 242)
        Me.txtCodMun.MaxLength = 2
        Me.txtCodMun.Name = "txtCodMun"
        Me.txtCodMun.Size = New System.Drawing.Size(77, 23)
        Me.txtCodMun.TabIndex = 7
        '
        'txtMunicipio
        '
        Me.txtMunicipio.BackColor = System.Drawing.Color.White
        Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMunicipio.Location = New System.Drawing.Point(212, 242)
        Me.txtMunicipio.MaxLength = 100
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.ReadOnly = True
        Me.txtMunicipio.Size = New System.Drawing.Size(498, 23)
        Me.txtMunicipio.TabIndex = 100
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(10, 242)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(86, 19)
        Me.Label37.TabIndex = 99
        Me.Label37.Text = "Municipio:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(7, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Computarizada"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(10, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Manual"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(130, 182)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(142, 23)
        Me.txtArea.TabIndex = 5
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(128, 138)
        Me.txtUbicacion.Multiline = True
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUbicacion.Size = New System.Drawing.Size(582, 37)
        Me.txtUbicacion.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Área (mt2):"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 38)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Ubicación Inmueble:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(454, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "No. de Asiento"
        '
        'txtNoAsiento
        '
        Me.txtNoAsiento.Location = New System.Drawing.Point(566, 108)
        Me.txtNoAsiento.Name = "txtNoAsiento"
        Me.txtNoAsiento.Size = New System.Drawing.Size(144, 23)
        Me.txtNoAsiento.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 19)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "No. de Matrícula"
        '
        'txtNoMatricula
        '
        Me.txtNoMatricula.Location = New System.Drawing.Point(130, 108)
        Me.txtNoMatricula.Name = "txtNoMatricula"
        Me.txtNoMatricula.Size = New System.Drawing.Size(144, 23)
        Me.txtNoMatricula.TabIndex = 2
        '
        'txtNoLibro
        '
        Me.txtNoLibro.Location = New System.Drawing.Point(566, 52)
        Me.txtNoLibro.Name = "txtNoLibro"
        Me.txtNoLibro.Size = New System.Drawing.Size(144, 23)
        Me.txtNoLibro.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(454, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "No. de Libro"
        '
        'txtNoInscripcion
        '
        Me.txtNoInscripcion.Location = New System.Drawing.Point(128, 52)
        Me.txtNoInscripcion.Name = "txtNoInscripcion"
        Me.txtNoInscripcion.Size = New System.Drawing.Size(144, 23)
        Me.txtNoInscripcion.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(7, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "No. de Inscripción"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtNocomprobante)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 65)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GENERALES DEL INMUEBLE"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(605, 28)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(105, 23)
        Me.dtpFecha.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(470, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 18)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Fecha de Solicitud:"
        '
        'txtNocomprobante
        '
        Me.txtNocomprobante.Location = New System.Drawing.Point(230, 28)
        Me.txtNocomprobante.Name = "txtNocomprobante"
        Me.txtNocomprobante.Size = New System.Drawing.Size(125, 23)
        Me.txtNocomprobante.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comprobante de Cert. Extratada:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.gbAcreedores)
        Me.TabPage2.Controls.Add(Me.gbInmueble)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(750, 420)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dueños del Inmueble - Acreedores"
        Me.TabPage2.Visible = False
        '
        'gbAcreedores
        '
        Me.gbAcreedores.BackColor = System.Drawing.Color.White
        Me.gbAcreedores.Controls.Add(Me.btEditAcreedor1)
        Me.gbAcreedores.Controls.Add(Me.btnDelAcreedor1)
        Me.gbAcreedores.Controls.Add(Me.fgAcreedor)
        Me.gbAcreedores.Controls.Add(Me.btNewAcreedor1)
        Me.gbAcreedores.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAcreedores.ForeColor = System.Drawing.Color.Teal
        Me.gbAcreedores.Location = New System.Drawing.Point(8, 219)
        Me.gbAcreedores.Name = "gbAcreedores"
        Me.gbAcreedores.Size = New System.Drawing.Size(730, 204)
        Me.gbAcreedores.TabIndex = 1
        Me.gbAcreedores.TabStop = False
        Me.gbAcreedores.Text = "ACREEDORES (GRAVAMENES)"
        '
        'btEditAcreedor1
        '
        Me.btEditAcreedor1.Location = New System.Drawing.Point(104, 22)
        Me.btEditAcreedor1.Name = "btEditAcreedor1"
        Me.btEditAcreedor1.Size = New System.Drawing.Size(90, 32)
        Me.btEditAcreedor1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditAcreedor1.TabIndex = 208
        Me.btEditAcreedor1.Text = "Modificar"
        Me.btEditAcreedor1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditAcreedor1.UseSelectable = True
        Me.btEditAcreedor1.UseStyleColors = True
        '
        'btnDelAcreedor1
        '
        Me.btnDelAcreedor1.Location = New System.Drawing.Point(202, 22)
        Me.btnDelAcreedor1.Name = "btnDelAcreedor1"
        Me.btnDelAcreedor1.Size = New System.Drawing.Size(90, 32)
        Me.btnDelAcreedor1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDelAcreedor1.TabIndex = 207
        Me.btnDelAcreedor1.Text = "Eliminar"
        Me.btnDelAcreedor1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDelAcreedor1.UseSelectable = True
        Me.btnDelAcreedor1.UseStyleColors = True
        '
        'fgAcreedor
        '
        Me.fgAcreedor.AllowEditing = False
        Me.fgAcreedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgAcreedor.BackColor = System.Drawing.Color.White
        Me.fgAcreedor.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgAcreedor.ForeColor = System.Drawing.Color.Teal
        Me.fgAcreedor.Location = New System.Drawing.Point(7, 61)
        Me.fgAcreedor.Name = "fgAcreedor"
        Me.fgAcreedor.Rows.Count = 1
        Me.fgAcreedor.Rows.DefaultSize = 22
        Me.fgAcreedor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.fgAcreedor.Size = New System.Drawing.Size(715, 129)
        Me.fgAcreedor.StyleInfo = resources.GetString("fgAcreedor.StyleInfo")
        Me.fgAcreedor.TabIndex = 3
        '
        'btNewAcreedor1
        '
        Me.btNewAcreedor1.Location = New System.Drawing.Point(7, 22)
        Me.btNewAcreedor1.Name = "btNewAcreedor1"
        Me.btNewAcreedor1.Size = New System.Drawing.Size(90, 32)
        Me.btNewAcreedor1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewAcreedor1.TabIndex = 206
        Me.btNewAcreedor1.Text = "Agregar"
        Me.btNewAcreedor1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewAcreedor1.UseSelectable = True
        Me.btNewAcreedor1.UseStyleColors = True
        '
        'gbInmueble
        '
        Me.gbInmueble.BackColor = System.Drawing.Color.White
        Me.gbInmueble.Controls.Add(Me.btEditInmueble1)
        Me.gbInmueble.Controls.Add(Me.btDelInmueble1)
        Me.gbInmueble.Controls.Add(Me.btNewInmueble1)
        Me.gbInmueble.Controls.Add(Me.fgInmueble)
        Me.gbInmueble.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInmueble.ForeColor = System.Drawing.Color.Teal
        Me.gbInmueble.Location = New System.Drawing.Point(10, 8)
        Me.gbInmueble.Name = "gbInmueble"
        Me.gbInmueble.Size = New System.Drawing.Size(729, 204)
        Me.gbInmueble.TabIndex = 0
        Me.gbInmueble.TabStop = False
        Me.gbInmueble.Text = "DUEÑOS DEL INMUEBLE"
        '
        'btEditInmueble1
        '
        Me.btEditInmueble1.Location = New System.Drawing.Point(104, 22)
        Me.btEditInmueble1.Name = "btEditInmueble1"
        Me.btEditInmueble1.Size = New System.Drawing.Size(90, 32)
        Me.btEditInmueble1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditInmueble1.TabIndex = 205
        Me.btEditInmueble1.Text = "Modificar"
        Me.btEditInmueble1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditInmueble1.UseSelectable = True
        Me.btEditInmueble1.UseStyleColors = True
        '
        'btDelInmueble1
        '
        Me.btDelInmueble1.Location = New System.Drawing.Point(202, 22)
        Me.btDelInmueble1.Name = "btDelInmueble1"
        Me.btDelInmueble1.Size = New System.Drawing.Size(90, 32)
        Me.btDelInmueble1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelInmueble1.TabIndex = 204
        Me.btDelInmueble1.Text = "Eliminar"
        Me.btDelInmueble1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelInmueble1.UseSelectable = True
        Me.btDelInmueble1.UseStyleColors = True
        '
        'btNewInmueble1
        '
        Me.btNewInmueble1.Location = New System.Drawing.Point(7, 22)
        Me.btNewInmueble1.Name = "btNewInmueble1"
        Me.btNewInmueble1.Size = New System.Drawing.Size(90, 32)
        Me.btNewInmueble1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewInmueble1.TabIndex = 203
        Me.btNewInmueble1.Text = "Agregar"
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
        Me.fgInmueble.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgInmueble.ForeColor = System.Drawing.Color.Teal
        Me.fgInmueble.Location = New System.Drawing.Point(7, 65)
        Me.fgInmueble.Name = "fgInmueble"
        Me.fgInmueble.Rows.Count = 1
        Me.fgInmueble.Rows.DefaultSize = 22
        Me.fgInmueble.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgInmueble.Size = New System.Drawing.Size(714, 129)
        Me.fgInmueble.StyleInfo = resources.GetString("fgInmueble.StyleInfo")
        Me.fgInmueble.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gbPresentaciones)
        Me.TabPage3.Controls.Add(Me.gbRestricciones)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(750, 420)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Restricciones - Presentaciones"
        Me.TabPage3.Visible = False
        '
        'gbPresentaciones
        '
        Me.gbPresentaciones.BackColor = System.Drawing.Color.White
        Me.gbPresentaciones.Controls.Add(Me.btEditPres1)
        Me.gbPresentaciones.Controls.Add(Me.btDelPres1)
        Me.gbPresentaciones.Controls.Add(Me.btNewPres1)
        Me.gbPresentaciones.Controls.Add(Me.fgPresentacion)
        Me.gbPresentaciones.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPresentaciones.ForeColor = System.Drawing.Color.Teal
        Me.gbPresentaciones.Location = New System.Drawing.Point(10, 210)
        Me.gbPresentaciones.Name = "gbPresentaciones"
        Me.gbPresentaciones.Size = New System.Drawing.Size(729, 194)
        Me.gbPresentaciones.TabIndex = 1
        Me.gbPresentaciones.TabStop = False
        Me.gbPresentaciones.Text = "PRESENTACIONES"
        '
        'btEditPres1
        '
        Me.btEditPres1.Location = New System.Drawing.Point(104, 22)
        Me.btEditPres1.Name = "btEditPres1"
        Me.btEditPres1.Size = New System.Drawing.Size(90, 32)
        Me.btEditPres1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditPres1.TabIndex = 205
        Me.btEditPres1.Text = "Modificar"
        Me.btEditPres1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditPres1.UseSelectable = True
        Me.btEditPres1.UseStyleColors = True
        '
        'btDelPres1
        '
        Me.btDelPres1.Location = New System.Drawing.Point(202, 22)
        Me.btDelPres1.Name = "btDelPres1"
        Me.btDelPres1.Size = New System.Drawing.Size(90, 32)
        Me.btDelPres1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelPres1.TabIndex = 204
        Me.btDelPres1.Text = "Eliminar"
        Me.btDelPres1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelPres1.UseSelectable = True
        Me.btDelPres1.UseStyleColors = True
        '
        'btNewPres1
        '
        Me.btNewPres1.Location = New System.Drawing.Point(7, 22)
        Me.btNewPres1.Name = "btNewPres1"
        Me.btNewPres1.Size = New System.Drawing.Size(90, 32)
        Me.btNewPres1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewPres1.TabIndex = 203
        Me.btNewPres1.Text = "Agregar"
        Me.btNewPres1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewPres1.UseSelectable = True
        Me.btNewPres1.UseStyleColors = True
        '
        'fgPresentacion
        '
        Me.fgPresentacion.AllowEditing = False
        Me.fgPresentacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgPresentacion.BackColor = System.Drawing.Color.White
        Me.fgPresentacion.ColumnInfo = "10,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fgPresentacion.ForeColor = System.Drawing.Color.Black
        Me.fgPresentacion.Location = New System.Drawing.Point(7, 61)
        Me.fgPresentacion.Name = "fgPresentacion"
        Me.fgPresentacion.Rows.Count = 1
        Me.fgPresentacion.Rows.DefaultSize = 21
        Me.fgPresentacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgPresentacion.Size = New System.Drawing.Size(715, 120)
        Me.fgPresentacion.StyleInfo = resources.GetString("fgPresentacion.StyleInfo")
        Me.fgPresentacion.TabIndex = 5
        '
        'gbRestricciones
        '
        Me.gbRestricciones.BackColor = System.Drawing.Color.White
        Me.gbRestricciones.Controls.Add(Me.btEditRest1)
        Me.gbRestricciones.Controls.Add(Me.btDelRest1)
        Me.gbRestricciones.Controls.Add(Me.btNewRest1)
        Me.gbRestricciones.Controls.Add(Me.fgRestriccion)
        Me.gbRestricciones.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRestricciones.ForeColor = System.Drawing.Color.Teal
        Me.gbRestricciones.Location = New System.Drawing.Point(10, 9)
        Me.gbRestricciones.Name = "gbRestricciones"
        Me.gbRestricciones.Size = New System.Drawing.Size(729, 194)
        Me.gbRestricciones.TabIndex = 0
        Me.gbRestricciones.TabStop = False
        Me.gbRestricciones.Text = "RESTRICCIONES"
        '
        'btEditRest1
        '
        Me.btEditRest1.Location = New System.Drawing.Point(104, 22)
        Me.btEditRest1.Name = "btEditRest1"
        Me.btEditRest1.Size = New System.Drawing.Size(90, 32)
        Me.btEditRest1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditRest1.TabIndex = 205
        Me.btEditRest1.Text = "Modificar"
        Me.btEditRest1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditRest1.UseSelectable = True
        Me.btEditRest1.UseStyleColors = True
        '
        'btDelRest1
        '
        Me.btDelRest1.Location = New System.Drawing.Point(202, 22)
        Me.btDelRest1.Name = "btDelRest1"
        Me.btDelRest1.Size = New System.Drawing.Size(90, 32)
        Me.btDelRest1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelRest1.TabIndex = 204
        Me.btDelRest1.Text = "Eliminar"
        Me.btDelRest1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelRest1.UseSelectable = True
        Me.btDelRest1.UseStyleColors = True
        '
        'btNewRest1
        '
        Me.btNewRest1.Location = New System.Drawing.Point(7, 22)
        Me.btNewRest1.Name = "btNewRest1"
        Me.btNewRest1.Size = New System.Drawing.Size(90, 32)
        Me.btNewRest1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewRest1.TabIndex = 203
        Me.btNewRest1.Text = "Agregar"
        Me.btNewRest1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewRest1.UseSelectable = True
        Me.btNewRest1.UseStyleColors = True
        '
        'fgRestriccion
        '
        Me.fgRestriccion.AllowEditing = False
        Me.fgRestriccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgRestriccion.BackColor = System.Drawing.Color.White
        Me.fgRestriccion.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRestriccion.ForeColor = System.Drawing.Color.Teal
        Me.fgRestriccion.Location = New System.Drawing.Point(7, 65)
        Me.fgRestriccion.Name = "fgRestriccion"
        Me.fgRestriccion.Rows.Count = 1
        Me.fgRestriccion.Rows.DefaultSize = 22
        Me.fgRestriccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgRestriccion.Size = New System.Drawing.Size(715, 120)
        Me.fgRestriccion.StyleInfo = resources.GetString("fgRestriccion.StyleInfo")
        Me.fgRestriccion.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.lblPlazo)
        Me.GroupBox4.Controls.Add(Me.lblMonto)
        Me.GroupBox4.Controls.Add(Me.lblConcedido)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(758, 55)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'lblPlazo
        '
        Me.lblPlazo.Location = New System.Drawing.Point(662, 18)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(77, 19)
        Me.lblPlazo.TabIndex = 3
        Me.lblPlazo.Text = "Plazo:"
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(499, 18)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(144, 19)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto:"
        '
        'lblConcedido
        '
        Me.lblConcedido.Location = New System.Drawing.Point(10, 18)
        Me.lblConcedido.Name = "lblConcedido"
        Me.lblConcedido.Size = New System.Drawing.Size(480, 28)
        Me.lblConcedido.TabIndex = 1
        Me.lblConcedido.Text = "Crédito concedido a:"
        '
        'btnSig1
        '
        Me.btnSig1.Location = New System.Drawing.Point(599, 591)
        Me.btnSig1.Name = "btnSig1"
        Me.btnSig1.Size = New System.Drawing.Size(90, 32)
        Me.btnSig1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSig1.TabIndex = 208
        Me.btnSig1.Text = "Siguiente"
        Me.btnSig1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSig1.UseSelectable = True
        Me.btnSig1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(696, 591)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 207
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btAtras1
        '
        Me.btAtras1.Location = New System.Drawing.Point(502, 591)
        Me.btAtras1.Name = "btAtras1"
        Me.btAtras1.Size = New System.Drawing.Size(90, 32)
        Me.btAtras1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btAtras1.TabIndex = 206
        Me.btAtras1.Text = "Atrás"
        Me.btAtras1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btAtras1.UseSelectable = True
        Me.btAtras1.UseStyleColors = True
        '
        'frmCertificacionExtractada
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(811, 650)
        Me.Controls.Add(Me.btnSig1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btAtras1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.tb)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(811, 650)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(811, 650)
        Me.Name = "frmCertificacionExtractada"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Certificación Extractada"
        Me.tb.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gbAcreedores.ResumeLayout(False)
        CType(Me.fgAcreedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInmueble.ResumeLayout(False)
        CType(Me.fgInmueble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.gbPresentaciones.ResumeLayout(False)
        CType(Me.fgPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRestricciones.ResumeLayout(False)
        CType(Me.fgRestriccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCertificacionExtractada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.gbAcreedores.Enabled = False
        Me.gbInmueble.Enabled = False
        Me.gbPresentaciones.Enabled = False
        Me.gbRestricciones.Enabled = False
        CargaDatosIniciales()
    End Sub
    Private Sub CargaDatosIniciales()
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection, oAsoc As New wrAsociados.wsLibAsoc, dr As DataRow, vDui As String
            If Me.btnGuardar1.Text = "&Modificar" Then
                ds = oCred.ConsultarCertificacionExtractada("*", "NumSolicitud=" & vNumSolicitud & " and NoComprobante='" & pNoDoc & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.vAccion = "Modificar"
                    Me.txtNocomprobante.Text = IIf(IsDBNull(Filas.Item(0)("NoComprobante")), "", Filas.Item(0)("NoComprobante"))
                    Me.pNoDoc = Me.txtNocomprobante.Text.Trim
                    Me.vNumSolicitud = IIf(IsDBNull(Filas.Item(0)("NumSolicitud")), "", Filas.Item(0)("NumSolicitud"))
                    Me.dtpFecha.Value = IIf(IsDBNull(Filas.Item(0)("Fecha")), Now, Filas.Item(0)("Fecha"))
                    Me.txtNoInscripcion.Text = IIf(IsDBNull(Filas.Item(0)("NoInscripcion")), "", Filas.Item(0)("NoInscripcion"))
                    Me.txtNoLibro.Text = IIf(IsDBNull(Filas.Item(0)("NoLibro")), "", Filas.Item(0)("NoLibro"))
                    Me.txtNoMatricula.Text = IIf(IsDBNull(Filas.Item(0)("NoMatricula")), "", Filas.Item(0)("NoMatricula"))
                    Me.txtNoAsiento.Text = IIf(IsDBNull(Filas.Item(0)("NoAsiento")), "", Filas.Item(0)("NoAsiento"))
                    Me.txtUbicacion.Text = IIf(IsDBNull(Filas.Item(0)("Ubicacion")), "", Filas.Item(0)("Ubicacion"))
                    Me.txtArea.Text = IIf(IsDBNull(Filas.Item(0)("Area")), "", Filas.Item(0)("Area"))
                    Me.txtCodDpto.Text = IIf(IsDBNull(Filas.Item(0)("CodDepartamento")), "", Filas.Item(0)("CodDepartamento"))
                    Me.txtCodMun.Text = IIf(IsDBNull(Filas.Item(0)("CodMunicipio")), "", Filas.Item(0)("CodMunicipio"))
                    Me.txtCodSeccion.Text = IIf(IsDBNull(Filas.Item(0)("CodSeccion")), "", Filas.Item(0)("CodSeccion"))

                    Me.fgAcreedor.DataSource = oCred.CONSULTARACREEDORES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0).Tables(0)
                    Me.fgInmueble.DataSource = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 1, Me.pNoDoc, 0).Tables(0)
                    '                    Me.fgInmueble.DataSource = oCred.ConsultarDuenosInmueble("Correlativo,Nombre,Porcentaje,Asociado", "NoComprobante='" & Me.pNoDoc & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                    Me.fgRestriccion.DataSource = oCred.CONSULTARRESTRICCIONES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0).Tables(0)
                    Me.fgPresentacion.DataSource = oCred.CONSULTARPRESENTACIONES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0).Tables(0)
                    fgAcreedor.Cols.Item(0).Width = 0
                    fgInmueble.Cols.Item(0).Width = 0
                    fgRestriccion.Cols.Item(0).Width = 0
                    fgPresentacion.Cols.Item(0).Width = 0
                    Me.btnGuardar1.Text = "&Modificar"
                    Me.gbAcreedores.Enabled = True
                    Me.gbInmueble.Enabled = True
                    Me.gbPresentaciones.Enabled = True
                    Me.gbRestricciones.Enabled = True
                    If Me.txtCodMun.Text.Trim <> "" Then
                        ds = oAsoc.ConsultarMunicipios("*", "CodMunicipio='" & Trim(Me.txtCodMun.Text) & "' and CodDepartamento='" & Trim(Me.txtCodDpto.Text) & "'", "", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            If Not (Filas.Item(0)("Municipio") Is DBNull.Value) Then
                                Me.txtMunicipio.Text = CStr(Filas.Item(0)("Municipio"))
                            End If
                        End If
                    End If
                    If Me.txtCodDpto.Text.Trim <> "" Then
                        ds = oAsoc.ConsultarDepartamentos("*", "CodDepartamento='" & Trim(Me.txtCodDpto.Text) & "'", "", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            If Not (Filas.Item(0)("Departamento") Is DBNull.Value) Then
                                Me.txtDpto.Text = CStr(Filas.Item(0)("Departamento"))
                            End If
                        End If
                    End If
                End If
                ds.Clear()
                If Me.txtCodSeccion.Text.Trim <> "" Then
                    ds = oCred.ConsultarSeccionRegistro("*", "CodSeccion='" & Me.txtCodSeccion.Text.Trim & "'", "CodSeccion", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Me.txtSeccionRegistro.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                    End If
                End If
            End If
            ds = oCred.ConsultarPRPrestamos("Dui,Monto,PlazoMeses", "NumSolicitud=" & vNumSolicitud & "", "NumSolicitud", False, sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vDui = dr("Dui")
                Me.lblMonto.Text = "Monto: $" & IIf(IsDBNull(dr("Monto")), "$0.00", Format(dr("Monto"), "##0.00"))
                Me.lblPlazo.Text = "Plazo: " & IIf(IsDBNull(dr("PlazoMeses")), "0", dr("PlazoMeses"))
            End If
            ds.Clear()
            ds = oAsoc.ConsultarAsociado("Nombres,Apellido1,Apellido2", "Dui='" & vDui & "'", "Dui", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.lblConcedido.Text = "Crédito concedido a: " & dr("Nombres") & " " & dr("Apellido1") & " " & dr("Apellido2")
            End If

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNocomprobante_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNocomprobante.LostFocus
        Me.pNoDoc = Me.txtNocomprobante.Text.Trim
    End Sub

    Protected Sub INGRESARCERTIFICACION(ByVal NOCOMPROBANTE As String, ByVal FECHA As Date, ByVal NOINSCRIPCION As String, ByVal NOLIBRO As String,
                                         ByVal NOMATRICULA As String, ByVal NOASIENTO As String, ByVal UBICACION As String, ByVal AREA As String,
                                         ByVal CODDEPARTAMENTO As String, ByVal CODMUNICIPIO As String, ByVal CODSECCION As String,
                                         ByVal NUMSOLICITUD As Integer, ByVal TIPO As Char)
        Dim RESULTADO As Integer
        RESULTADO = CREDITO.INSERTARCERTIFICACIONEXTRACTADA(sUsuario, sPassword, sSucursal, NOCOMPROBANTE, FECHA, NOINSCRIPCION, NOLIBRO, NOMATRICULA, NOASIENTO,
                                                  UBICACION, AREA, CODDEPARTAMENTO, CODMUNICIPIO, CODSECCION, NUMSOLICITUD, TIPO, Now)
        If RESULTADO = 1 Then
            MsgBox("Certificación ingresada exitosamente.", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
        Else
            MsgBox("El registro no ha sido Ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
        End If
    End Sub
    Protected Sub MODIFICARCERTIFICACION(ByVal NOCOMPROBANTE As String, ByVal FECHA As Date, ByVal NOINSCRIPCION As String, ByVal NOLIBRO As String,
                                         ByVal NOMATRICULA As String, ByVal NOASIENTO As String, ByVal UBICACION As String, ByVal AREA As String,
                                         ByVal CODDEPARTAMENTO As String, ByVal CODMUNICIPIO As String, ByVal CODSECCION As String,
                                         ByVal NUMSOLICITUD As Integer, ByVal TIPO As Char)
        Dim RESULTADO As Integer
        RESULTADO = CREDITO.MODIFICARCERTIFICACIONEXTRACTADA(sUsuario, sPassword, sSucursal, NOCOMPROBANTE, FECHA, NOINSCRIPCION, NOLIBRO, NOMATRICULA, NOASIENTO,
                                                  UBICACION, AREA, CODDEPARTAMENTO, CODMUNICIPIO, CODSECCION, NUMSOLICITUD, TIPO, Now, 1)
        If RESULTADO = 1 Then
            MsgBox("Certificación actualizada exitosamente.", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
        Else
            MsgBox("El registro no ha sido modificado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
        End If
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

    Private Sub btNewRest1_Click(sender As Object, e As EventArgs) Handles btNewRest1.Click
        Try
            Dim ofrm As New fmMsGrRestricciones
            ofrm.NoDoc = Me.pNoDoc
            ofrm.Tipo = "C"
            ofrm.Accion = "Guardar"
            ofrm.ShowDialog()
            Dim oCred As New wrCredito.wsLibCred
            Me.fgRestriccion.DataSource = oCred.CONSULTARRESTRICCIONES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0).Tables(0)
            fgRestriccion.Cols.Item(0).Width = 0
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditRest1_Click(sender As Object, e As EventArgs) Handles btEditRest1.Click
        Try
            If Me.fgRestriccion.Row > 0 Then
                Dim ofrm As New fmMsGrRestricciones
                ofrm.NoDoc = Me.pNoDoc
                Dim CORRELATIVO As Integer = Me.fgRestriccion.Item(Me.fgRestriccion.Row, "Correlativo")
                ofrm.Correlativo = CORRELATIVO
                ofrm.Tipo = "C"
                ofrm.Accion = "Modificar"
                ofrm.ShowDialog()
                Dim oCred As New wrCredito.wsLibCred
                Me.fgRestriccion.DataSource = oCred.CONSULTARRESTRICCIONES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, CORRELATIVO).Tables(0)
                Me.fgRestriccion.Cols.Item(0).Width = 0
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gbRestricciones_Enter(sender As Object, e As EventArgs) Handles gbRestricciones.Enter

    End Sub

    Private Sub btDelRest1_Click(sender As Object, e As EventArgs) Handles btDelRest1.Click
        Try
            If Me.fgRestriccion.Row > 0 Then
                If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Restricciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim oCred As New wrCredito.wsLibCred
                    oCred.EliminarRestricciones(Me.fgRestriccion.Item(Me.fgRestriccion.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                    Me.fgRestriccion.DataSource = oCred.CONSULTARRESTRICCIONES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0).Tables(0)
                    Me.fgRestriccion.Cols.Item(0).Width = 0
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewPres1_Click(sender As Object, e As EventArgs) Handles btNewPres1.Click
        Try
            Dim ofrm As New frmMsGrPresentaciones
            ofrm.NoDoc = Me.pNoDoc
            ofrm.Tipo = "C"
            ofrm.Accion = "Guardar"
            ofrm.ShowDialog()
            Dim oCred As New wrCredito.wsLibCred
            Me.fgPresentacion.DataSource = oCred.CONSULTARPRESENTACIONES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0).Tables(0)
            fgPresentacion.Cols.Item(0).Width = 0
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditPres1_Click(sender As Object, e As EventArgs) Handles btEditPres1.Click
        Try
            If Me.fgPresentacion.Row > 0 Then
                Dim CORRELATIVO As Integer
                CORRELATIVO = Me.fgPresentacion.Item(Me.fgPresentacion.Row, "Correlativo")
                Dim ofrm As New frmMsGrPresentaciones
                ofrm.NoDoc = Me.pNoDoc
                ofrm.Correlativo = CORRELATIVO
                ofrm.Tipo = "C"
                ofrm.Accion = "Modificar"
                ofrm.ShowDialog()
                Dim oCred As New wrCredito.wsLibCred
                Me.fgPresentacion.DataSource = oCred.CONSULTARPRESENTACIONES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0).Tables(0)
                Me.fgPresentacion.Cols.Item(0).Width = 0
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDelPres1_Click(sender As Object, e As EventArgs) Handles btDelPres1.Click
        Try
            If Me.fgPresentacion.Row > 0 Then
                If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Presentaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim oCred As New wrCredito.wsLibCred
                    oCred.EliminarPresentaciones(Me.fgPresentacion.Item(Me.fgPresentacion.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                    Me.fgPresentacion.DataSource = oCred.CONSULTARPRESENTACIONES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0).Tables(0)
                    Me.fgPresentacion.Cols.Item(0).Width = 0
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewInmueble1_Click(sender As Object, e As EventArgs) Handles btNewInmueble1.Click
        Try
            Dim ofrm As New fmMsGrDuenosInmueble
            ofrm.NoDoc = Me.pNoDoc
            ofrm.Tipo = "C"
            ofrm.Accion = "Guardar"
            ofrm.ShowDialog()
            Dim oCred As New wrCredito.wsLibCred
            Me.fgInmueble.DataSource = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 1, Me.pNoDoc, 0).Tables(0)
            '        Me.fgInmueble.DataSource = oCred.ConsultarDuenosInmueble("Correlativo,Nombre,Porcentaje,Asociado", "NoComprobante='" & Me.pNoDoc & "'", "Correlativo", sUsuario, sPassword,sSucursal).Tables(0)
            fgInmueble.Cols.Item(0).Width = 0
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditInmueble1_Click(sender As Object, e As EventArgs) Handles btEditInmueble1.Click
        Try
            If fgInmueble.Row > 0 Then
                Dim CORRELATIVO As Integer
                CORRELATIVO = fgInmueble.Item(fgInmueble.Row, "Correlativo")
                Dim ofrm As New fmMsGrDuenosInmueble
                ofrm.NoDoc = Me.pNoDoc
                ofrm.Correlativo = CORRELATIVO
                ofrm.Tipo = "C"
                ofrm.Accion = "Modificar"
                ofrm.ShowDialog()
                Dim oCred As New wrCredito.wsLibCred
                Me.fgInmueble.DataSource = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 1, Me.pNoDoc, 0).Tables(0)
                fgInmueble.Cols.Item(0).Width = 0
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelAcreedor1_Click(sender As Object, e As EventArgs) Handles btnDelAcreedor1.Click
        Try
            If Me.fgAcreedor.Row > 0 Then
                If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Acreedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim oCred As New wrCredito.wsLibCred
                    oCred.EliminarAcreedores(Me.fgAcreedor.Item(Me.fgAcreedor.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                    Me.fgAcreedor.DataSource = oCred.CONSULTARACREEDORES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0).Tables(0)
                    fgAcreedor.Cols.Item(0).Width = 0
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewAcreedor1_Click(sender As Object, e As EventArgs) Handles btNewAcreedor1.Click
        Try
            Dim dts As New DataSet
            Dim ofrm As New frmMsGrAcreedores
            ofrm.NoDoc = Me.pNoDoc
            ofrm.Tipo = "C"
            ofrm.Accion = "Guardar"
            ofrm.ShowDialog()

            Dim oCred As New wrCredito.wsLibCred
            dts = oCred.CONSULTARACREEDORES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0)
            Me.fgAcreedor.DataSource = dts.Tables(0)
            fgAcreedor.Cols.Item(0).Width = 0
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditAcreedor1_Click(sender As Object, e As EventArgs) Handles btEditAcreedor1.Click
        Try
            If fgAcreedor.Row > 0 Then
                Dim CORRELATIVO As Integer
                CORRELATIVO = fgAcreedor.Item(fgAcreedor.Row, "Correlativo")
                Dim ofrm As New frmMsGrAcreedores
                ofrm.NoDoc = Me.pNoDoc
                ofrm.Correlativo = CORRELATIVO
                ofrm.Tipo = "C"
                ofrm.Accion = "Modificar"
                ofrm.ShowDialog()
                Dim oCred As New wrCredito.wsLibCred
                Me.fgAcreedor.DataSource = oCred.CONSULTARACREEDORES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 1, 0).Tables(0)
                fgAcreedor.Cols.Item(0).Width = 0
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btAtras1_Click(sender As Object, e As EventArgs) Handles btAtras1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub btnSig1_Click(sender As Object, e As EventArgs) Handles btnSig1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Trim(Me.txtNocomprobante.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El No. de Comprobante no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Garantías")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                INGRESARCERTIFICACION(txtNocomprobante.Text.Trim, Format(Me.dtpFecha.Value, "SHORT DATE"), Me.txtNoInscripcion.Text.Trim,
                                        Me.txtNoLibro.Text.Trim, Me.txtNoMatricula.Text.Trim, Me.txtNoAsiento.Text.Trim, Me.txtUbicacion.Text.Trim,
                                        Me.txtArea.Text.Trim, Me.txtCodDpto.Text.Trim, Me.txtCodMun.Text.Trim, Me.txtCodSeccion.Text.Trim,
                                        vNumSolicitud, "C")
                Me.gbAcreedores.Enabled = True
                Me.gbInmueble.Enabled = True
                Me.gbPresentaciones.Enabled = True
                Me.gbRestricciones.Enabled = True
                Me.btnGuardar1.Text = "&Modificar"

            ElseIf Me.btnGuardar1.Text = "&Modificar" Then

                MODIFICARCERTIFICACION(txtNocomprobante.Text.Trim, Format(Me.dtpFecha.Value, "SHORT DATE"), Me.txtNoInscripcion.Text.Trim,
                                        Me.txtNoLibro.Text.Trim, Me.txtNoMatricula.Text.Trim, Me.txtNoAsiento.Text.Trim, Me.txtUbicacion.Text.Trim,
                                        Me.txtArea.Text.Trim, Me.txtCodDpto.Text.Trim, Me.txtCodMun.Text.Trim, Me.txtCodSeccion.Text.Trim,
                                        vNumSolicitud, "C")
                If vORIGEN = 1 Then ' FORM DE ORIGEN ANOTACIONPREV
                    My.Forms.frmMsGrAnotacionPreventiva.txtNoInscripcion.Text = txtNoInscripcion.Text.Trim
                    My.Forms.frmMsGrAnotacionPreventiva.txtNoLibro.Text = txtNoLibro.Text.Trim
                    My.Forms.frmMsGrAnotacionPreventiva.txtNoMatricula.Text = txtNoMatricula.Text.Trim
                    My.Forms.frmMsGrAnotacionPreventiva.txtNoAsiento.Text = txtNoAsiento.Text.Trim
                    My.Forms.frmMsGrAnotacionPreventiva.txtArea.Text = txtArea.Text.Trim
                    My.Forms.frmMsGrAnotacionPreventiva.txtUbicacion.Text = txtUbicacion.Text.Trim

                End If
                Me.gbAcreedores.Enabled = True
                Me.gbInmueble.Enabled = True
                Me.gbPresentaciones.Enabled = True
                Me.gbRestricciones.Enabled = True
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
End Class