Imports System.Drawing.Font
Public Class frmMsGrAnotacionPreventiva
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm)

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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblConcedido As System.Windows.Forms.Label
    Friend WithEvents lblTasaInt As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents gbPresentaciones As System.Windows.Forms.GroupBox
    Friend WithEvents fgPresentacion As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gbRestricciones As System.Windows.Forms.GroupBox
    Friend WithEvents fgRestriccion As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gbAcreedores As System.Windows.Forms.GroupBox
    Friend WithEvents fgAcreedor As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents gbInmueble As System.Windows.Forms.GroupBox
    Friend WithEvents fgInmueble As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents txtNoInscripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNoLibro As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNoMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoAsiento As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFECHAFANOTACION As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFECHAINIANOTACION As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAFIN_ANOTACION As System.Windows.Forms.Label
    Friend WithEvents lblFECHAINI_ANOTACION As System.Windows.Forms.Label
    Friend WithEvents txtCodSeccion As System.Windows.Forms.TextBox
    Friend WithEvents txtSeccionRegistro As System.Windows.Forms.TextBox
    Friend WithEvents txtNoOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInsc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaPresent As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents txtDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb As System.Windows.Forms.TabControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNOASIENTOANOTACION As System.Windows.Forms.TextBox
    Friend WithEvents CBMODIF_CE As System.Windows.Forms.CheckBox
    Friend WithEvents btnCertExt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btAtras1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSig1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton8 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton9 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelInmueble1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditInmueble1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewInmueble1 As MetroFramework.Controls.MetroButton
    Friend WithEvents lblDui As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsGrAnotacionPreventiva))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblDui = New System.Windows.Forms.Label()
        Me.lblTasaInt = New System.Windows.Forms.Label()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcedido = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gbPresentaciones = New System.Windows.Forms.GroupBox()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton8 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton9 = New MetroFramework.Controls.MetroButton()
        Me.fgPresentacion = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gbRestricciones = New System.Windows.Forms.GroupBox()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.fgRestriccion = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbAcreedores = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.fgAcreedor = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.gbInmueble = New System.Windows.Forms.GroupBox()
        Me.btDelInmueble1 = New MetroFramework.Controls.MetroButton()
        Me.btEditInmueble1 = New MetroFramework.Controls.MetroButton()
        Me.btNewInmueble1 = New MetroFramework.Controls.MetroButton()
        Me.fgInmueble = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.txtNoInscripcion = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNoLibro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNoMatricula = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoAsiento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBMODIF_CE = New System.Windows.Forms.CheckBox()
        Me.txtNOASIENTOANOTACION = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtFECHAFANOTACION = New System.Windows.Forms.DateTimePicker()
        Me.dtFECHAINIANOTACION = New System.Windows.Forms.DateTimePicker()
        Me.lblFECHAFIN_ANOTACION = New System.Windows.Forms.Label()
        Me.lblFECHAINI_ANOTACION = New System.Windows.Forms.Label()
        Me.txtCodSeccion = New System.Windows.Forms.TextBox()
        Me.txtSeccionRegistro = New System.Windows.Forms.TextBox()
        Me.txtNoOrden = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaInsc = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaPresent = New System.Windows.Forms.DateTimePicker()
        Me.txtNoPresentacion = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb = New System.Windows.Forms.TabControl()
        Me.btnCertExt1 = New MetroFramework.Controls.MetroButton()
        Me.btAtras1 = New MetroFramework.Controls.MetroButton()
        Me.btnSig1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gbPresentaciones.SuspendLayout()
        CType(Me.fgPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRestricciones.SuspendLayout()
        CType(Me.fgRestriccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.gbAcreedores.SuspendLayout()
        CType(Me.fgAcreedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInmueble.SuspendLayout()
        CType(Me.fgInmueble, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tb.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblDui)
        Me.GroupBox4.Controls.Add(Me.lblTasaInt)
        Me.GroupBox4.Controls.Add(Me.lblPlazo)
        Me.GroupBox4.Controls.Add(Me.lblMonto)
        Me.GroupBox4.Controls.Add(Me.lblConcedido)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(752, 72)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'lblDui
        '
        Me.lblDui.Location = New System.Drawing.Point(8, 16)
        Me.lblDui.Name = "lblDui"
        Me.lblDui.Size = New System.Drawing.Size(160, 16)
        Me.lblDui.TabIndex = 0
        Me.lblDui.Text = "Dui:"
        '
        'lblTasaInt
        '
        Me.lblTasaInt.Location = New System.Drawing.Point(224, 16)
        Me.lblTasaInt.Name = "lblTasaInt"
        Me.lblTasaInt.Size = New System.Drawing.Size(160, 16)
        Me.lblTasaInt.TabIndex = 1
        Me.lblTasaInt.Text = "Tasa de Interés:"
        '
        'lblPlazo
        '
        Me.lblPlazo.Location = New System.Drawing.Point(672, 16)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(64, 16)
        Me.lblPlazo.TabIndex = 3
        Me.lblPlazo.Text = "Plazo:"
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(520, 16)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(120, 16)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto:"
        '
        'lblConcedido
        '
        Me.lblConcedido.Location = New System.Drawing.Point(8, 40)
        Me.lblConcedido.Name = "lblConcedido"
        Me.lblConcedido.Size = New System.Drawing.Size(720, 24)
        Me.lblConcedido.TabIndex = 0
        Me.lblConcedido.Text = "Nombre de Asociado:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gbPresentaciones)
        Me.TabPage3.Controls.Add(Me.gbRestricciones)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(744, 331)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Restricciones-Present."
        '
        'gbPresentaciones
        '
        Me.gbPresentaciones.BackColor = System.Drawing.Color.White
        Me.gbPresentaciones.Controls.Add(Me.MetroButton7)
        Me.gbPresentaciones.Controls.Add(Me.MetroButton8)
        Me.gbPresentaciones.Controls.Add(Me.MetroButton9)
        Me.gbPresentaciones.Controls.Add(Me.fgPresentacion)
        Me.gbPresentaciones.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPresentaciones.ForeColor = System.Drawing.Color.Black
        Me.gbPresentaciones.Location = New System.Drawing.Point(8, 169)
        Me.gbPresentaciones.Name = "gbPresentaciones"
        Me.gbPresentaciones.Size = New System.Drawing.Size(728, 160)
        Me.gbPresentaciones.TabIndex = 0
        Me.gbPresentaciones.TabStop = False
        Me.gbPresentaciones.Text = "PRESENTACIONES"
        '
        'MetroButton7
        '
        Me.MetroButton7.Location = New System.Drawing.Point(178, 19)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(80, 28)
        Me.MetroButton7.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton7.TabIndex = 227
        Me.MetroButton7.Text = "&Eliminar"
        Me.MetroButton7.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton7.UseSelectable = True
        Me.MetroButton7.UseStyleColors = True
        '
        'MetroButton8
        '
        Me.MetroButton8.Location = New System.Drawing.Point(92, 19)
        Me.MetroButton8.Name = "MetroButton8"
        Me.MetroButton8.Size = New System.Drawing.Size(80, 28)
        Me.MetroButton8.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton8.TabIndex = 226
        Me.MetroButton8.Text = "&Modificar"
        Me.MetroButton8.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton8.UseSelectable = True
        Me.MetroButton8.UseStyleColors = True
        '
        'MetroButton9
        '
        Me.MetroButton9.Location = New System.Drawing.Point(6, 19)
        Me.MetroButton9.Name = "MetroButton9"
        Me.MetroButton9.Size = New System.Drawing.Size(80, 28)
        Me.MetroButton9.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton9.TabIndex = 225
        Me.MetroButton9.Text = "&Agregar"
        Me.MetroButton9.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton9.UseSelectable = True
        Me.MetroButton9.UseStyleColors = True
        '
        'fgPresentacion
        '
        Me.fgPresentacion.AllowEditing = False
        Me.fgPresentacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgPresentacion.BackColor = System.Drawing.Color.White
        Me.fgPresentacion.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgPresentacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgPresentacion.ForeColor = System.Drawing.Color.Black
        Me.fgPresentacion.Location = New System.Drawing.Point(6, 56)
        Me.fgPresentacion.Name = "fgPresentacion"
        Me.fgPresentacion.Rows.Count = 1
        Me.fgPresentacion.Rows.DefaultSize = 19
        Me.fgPresentacion.Size = New System.Drawing.Size(716, 90)
        Me.fgPresentacion.StyleInfo = resources.GetString("fgPresentacion.StyleInfo")
        Me.fgPresentacion.TabIndex = 3
        '
        'gbRestricciones
        '
        Me.gbRestricciones.BackColor = System.Drawing.Color.White
        Me.gbRestricciones.Controls.Add(Me.MetroButton4)
        Me.gbRestricciones.Controls.Add(Me.MetroButton5)
        Me.gbRestricciones.Controls.Add(Me.MetroButton6)
        Me.gbRestricciones.Controls.Add(Me.fgRestriccion)
        Me.gbRestricciones.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRestricciones.ForeColor = System.Drawing.Color.Black
        Me.gbRestricciones.Location = New System.Drawing.Point(8, 8)
        Me.gbRestricciones.Name = "gbRestricciones"
        Me.gbRestricciones.Size = New System.Drawing.Size(728, 160)
        Me.gbRestricciones.TabIndex = 0
        Me.gbRestricciones.TabStop = False
        Me.gbRestricciones.Text = "RESTRICCIONES"
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(178, 19)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(80, 28)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton4.TabIndex = 227
        Me.MetroButton4.Text = "&Eliminar"
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(92, 19)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(80, 28)
        Me.MetroButton5.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton5.TabIndex = 226
        Me.MetroButton5.Text = "&Modificar"
        Me.MetroButton5.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton5.UseSelectable = True
        Me.MetroButton5.UseStyleColors = True
        '
        'MetroButton6
        '
        Me.MetroButton6.Location = New System.Drawing.Point(6, 19)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(80, 28)
        Me.MetroButton6.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton6.TabIndex = 225
        Me.MetroButton6.Text = "&Agregar"
        Me.MetroButton6.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton6.UseSelectable = True
        Me.MetroButton6.UseStyleColors = True
        '
        'fgRestriccion
        '
        Me.fgRestriccion.AllowEditing = False
        Me.fgRestriccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgRestriccion.BackColor = System.Drawing.Color.White
        Me.fgRestriccion.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRestriccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgRestriccion.ForeColor = System.Drawing.Color.Black
        Me.fgRestriccion.Location = New System.Drawing.Point(6, 56)
        Me.fgRestriccion.Name = "fgRestriccion"
        Me.fgRestriccion.Rows.Count = 1
        Me.fgRestriccion.Rows.DefaultSize = 19
        Me.fgRestriccion.Size = New System.Drawing.Size(716, 90)
        Me.fgRestriccion.StyleInfo = resources.GetString("fgRestriccion.StyleInfo")
        Me.fgRestriccion.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gbAcreedores)
        Me.TabPage2.Controls.Add(Me.gbInmueble)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(744, 331)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dueños Inmueble-Acreedores"
        '
        'gbAcreedores
        '
        Me.gbAcreedores.BackColor = System.Drawing.Color.White
        Me.gbAcreedores.Controls.Add(Me.MetroButton1)
        Me.gbAcreedores.Controls.Add(Me.MetroButton2)
        Me.gbAcreedores.Controls.Add(Me.MetroButton3)
        Me.gbAcreedores.Controls.Add(Me.fgAcreedor)
        Me.gbAcreedores.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAcreedores.ForeColor = System.Drawing.Color.Black
        Me.gbAcreedores.Location = New System.Drawing.Point(8, 169)
        Me.gbAcreedores.Name = "gbAcreedores"
        Me.gbAcreedores.Size = New System.Drawing.Size(728, 152)
        Me.gbAcreedores.TabIndex = 1
        Me.gbAcreedores.TabStop = False
        Me.gbAcreedores.Text = "ACREEDORES (GRAVAMENES)"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(178, 19)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(80, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 227
        Me.MetroButton1.Text = "&Eliminar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(92, 19)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(80, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 226
        Me.MetroButton2.Text = "&Modificar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(6, 19)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(80, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 225
        Me.MetroButton3.Text = "&Agregar"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'fgAcreedor
        '
        Me.fgAcreedor.AllowEditing = False
        Me.fgAcreedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgAcreedor.BackColor = System.Drawing.Color.White
        Me.fgAcreedor.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgAcreedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgAcreedor.ForeColor = System.Drawing.Color.Black
        Me.fgAcreedor.Location = New System.Drawing.Point(6, 53)
        Me.fgAcreedor.Name = "fgAcreedor"
        Me.fgAcreedor.Rows.Count = 1
        Me.fgAcreedor.Rows.DefaultSize = 19
        Me.fgAcreedor.Size = New System.Drawing.Size(716, 90)
        Me.fgAcreedor.StyleInfo = resources.GetString("fgAcreedor.StyleInfo")
        Me.fgAcreedor.TabIndex = 3
        '
        'gbInmueble
        '
        Me.gbInmueble.BackColor = System.Drawing.Color.White
        Me.gbInmueble.Controls.Add(Me.btDelInmueble1)
        Me.gbInmueble.Controls.Add(Me.btEditInmueble1)
        Me.gbInmueble.Controls.Add(Me.btNewInmueble1)
        Me.gbInmueble.Controls.Add(Me.fgInmueble)
        Me.gbInmueble.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInmueble.ForeColor = System.Drawing.Color.Black
        Me.gbInmueble.Location = New System.Drawing.Point(8, 7)
        Me.gbInmueble.Name = "gbInmueble"
        Me.gbInmueble.Size = New System.Drawing.Size(728, 160)
        Me.gbInmueble.TabIndex = 0
        Me.gbInmueble.TabStop = False
        Me.gbInmueble.Text = "DUEÑOS DEL INMUEBLE"
        '
        'btDelInmueble1
        '
        Me.btDelInmueble1.Location = New System.Drawing.Point(178, 19)
        Me.btDelInmueble1.Name = "btDelInmueble1"
        Me.btDelInmueble1.Size = New System.Drawing.Size(80, 28)
        Me.btDelInmueble1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelInmueble1.TabIndex = 224
        Me.btDelInmueble1.Text = "&Eliminar"
        Me.btDelInmueble1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelInmueble1.UseSelectable = True
        Me.btDelInmueble1.UseStyleColors = True
        '
        'btEditInmueble1
        '
        Me.btEditInmueble1.Location = New System.Drawing.Point(92, 19)
        Me.btEditInmueble1.Name = "btEditInmueble1"
        Me.btEditInmueble1.Size = New System.Drawing.Size(80, 28)
        Me.btEditInmueble1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditInmueble1.TabIndex = 223
        Me.btEditInmueble1.Text = "&Modificar"
        Me.btEditInmueble1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditInmueble1.UseSelectable = True
        Me.btEditInmueble1.UseStyleColors = True
        '
        'btNewInmueble1
        '
        Me.btNewInmueble1.Location = New System.Drawing.Point(6, 19)
        Me.btNewInmueble1.Name = "btNewInmueble1"
        Me.btNewInmueble1.Size = New System.Drawing.Size(80, 28)
        Me.btNewInmueble1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewInmueble1.TabIndex = 222
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
        Me.fgInmueble.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{AllowSorting:Fal" &
    "se;AllowDragging:False;AllowResizing:False;AllowEditing:False;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgInmueble.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.fgInmueble.ForeColor = System.Drawing.Color.Black
        Me.fgInmueble.Location = New System.Drawing.Point(6, 53)
        Me.fgInmueble.Name = "fgInmueble"
        Me.fgInmueble.Rows.Count = 1
        Me.fgInmueble.Rows.DefaultSize = 19
        Me.fgInmueble.Size = New System.Drawing.Size(716, 90)
        Me.fgInmueble.StyleInfo = resources.GetString("fgInmueble.StyleInfo")
        Me.fgInmueble.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(744, 331)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Gral."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtUbicacion)
        Me.GroupBox3.Controls.Add(Me.txtNoInscripcion)
        Me.GroupBox3.Controls.Add(Me.txtArea)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtNoLibro)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtNoMatricula)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtNoAsiento)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(8, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(728, 122)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS DE LA INSCRIPCIÓN"
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(130, 81)
        Me.txtUbicacion.Multiline = True
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(592, 32)
        Me.txtUbicacion.TabIndex = 11
        '
        'txtNoInscripcion
        '
        Me.txtNoInscripcion.Location = New System.Drawing.Point(16, 46)
        Me.txtNoInscripcion.Name = "txtNoInscripcion"
        Me.txtNoInscripcion.Size = New System.Drawing.Size(120, 20)
        Me.txtNoInscripcion.TabIndex = 1
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(597, 46)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(120, 20)
        Me.txtArea.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(163, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "No. de Libro"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "No. de Inscripción"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNoLibro
        '
        Me.txtNoLibro.Location = New System.Drawing.Point(166, 46)
        Me.txtNoLibro.Name = "txtNoLibro"
        Me.txtNoLibro.Size = New System.Drawing.Size(120, 20)
        Me.txtNoLibro.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(594, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Área:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNoMatricula
        '
        Me.txtNoMatricula.Location = New System.Drawing.Point(312, 46)
        Me.txtNoMatricula.Name = "txtNoMatricula"
        Me.txtNoMatricula.Size = New System.Drawing.Size(120, 20)
        Me.txtNoMatricula.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(309, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "No. de Matrícula"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Ubicación Inmueble:"
        '
        'txtNoAsiento
        '
        Me.txtNoAsiento.Location = New System.Drawing.Point(458, 46)
        Me.txtNoAsiento.Name = "txtNoAsiento"
        Me.txtNoAsiento.Size = New System.Drawing.Size(120, 20)
        Me.txtNoAsiento.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(455, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "No. de Asiento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.CBMODIF_CE)
        Me.GroupBox1.Controls.Add(Me.txtNOASIENTOANOTACION)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.dtFECHAFANOTACION)
        Me.GroupBox1.Controls.Add(Me.dtFECHAINIANOTACION)
        Me.GroupBox1.Controls.Add(Me.lblFECHAFIN_ANOTACION)
        Me.GroupBox1.Controls.Add(Me.lblFECHAINI_ANOTACION)
        Me.GroupBox1.Controls.Add(Me.txtCodSeccion)
        Me.GroupBox1.Controls.Add(Me.txtSeccionRegistro)
        Me.GroupBox1.Controls.Add(Me.txtNoOrden)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInsc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFechaPresent)
        Me.GroupBox1.Controls.Add(Me.txtNoPresentacion)
        Me.GroupBox1.Controls.Add(Me.txtDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 177)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS GENERALES"
        '
        'CBMODIF_CE
        '
        Me.CBMODIF_CE.AutoSize = True
        Me.CBMODIF_CE.Location = New System.Drawing.Point(11, 45)
        Me.CBMODIF_CE.Name = "CBMODIF_CE"
        Me.CBMODIF_CE.Size = New System.Drawing.Size(239, 18)
        Me.CBMODIF_CE.TabIndex = 7
        Me.CBMODIF_CE.Text = "Modificar datos de  Certificación Extractada."
        Me.CBMODIF_CE.UseVisualStyleBackColor = True
        '
        'txtNOASIENTOANOTACION
        '
        Me.txtNOASIENTOANOTACION.Location = New System.Drawing.Point(473, 90)
        Me.txtNOASIENTOANOTACION.Name = "txtNOASIENTOANOTACION"
        Me.txtNOASIENTOANOTACION.Size = New System.Drawing.Size(239, 20)
        Me.txtNOASIENTOANOTACION.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(389, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 14)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "No. de Asiento"
        '
        'dtFECHAFANOTACION
        '
        Me.dtFECHAFANOTACION.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFECHAFANOTACION.Location = New System.Drawing.Point(614, 20)
        Me.dtFECHAFANOTACION.Name = "dtFECHAFANOTACION"
        Me.dtFECHAFANOTACION.Size = New System.Drawing.Size(98, 20)
        Me.dtFECHAFANOTACION.TabIndex = 6
        '
        'dtFECHAINIANOTACION
        '
        Me.dtFECHAINIANOTACION.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFECHAINIANOTACION.Location = New System.Drawing.Point(371, 20)
        Me.dtFECHAINIANOTACION.Name = "dtFECHAINIANOTACION"
        Me.dtFECHAINIANOTACION.Size = New System.Drawing.Size(95, 20)
        Me.dtFECHAINIANOTACION.TabIndex = 4
        '
        'lblFECHAFIN_ANOTACION
        '
        Me.lblFECHAFIN_ANOTACION.AutoSize = True
        Me.lblFECHAFIN_ANOTACION.Location = New System.Drawing.Point(503, 24)
        Me.lblFECHAFIN_ANOTACION.Name = "lblFECHAFIN_ANOTACION"
        Me.lblFECHAFIN_ANOTACION.Size = New System.Drawing.Size(105, 14)
        Me.lblFECHAFIN_ANOTACION.TabIndex = 5
        Me.lblFECHAFIN_ANOTACION.Text = "Fecha fin anotación:"
        '
        'lblFECHAINI_ANOTACION
        '
        Me.lblFECHAINI_ANOTACION.Location = New System.Drawing.Point(244, 24)
        Me.lblFECHAINI_ANOTACION.Name = "lblFECHAINI_ANOTACION"
        Me.lblFECHAINI_ANOTACION.Size = New System.Drawing.Size(121, 16)
        Me.lblFECHAINI_ANOTACION.TabIndex = 3
        Me.lblFECHAINI_ANOTACION.Text = "Fecha inicio anotación:"
        '
        'txtCodSeccion
        '
        Me.txtCodSeccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSeccion.Location = New System.Drawing.Point(144, 66)
        Me.txtCodSeccion.MaxLength = 2
        Me.txtCodSeccion.Name = "txtCodSeccion"
        Me.txtCodSeccion.Size = New System.Drawing.Size(64, 20)
        Me.txtCodSeccion.TabIndex = 9
        '
        'txtSeccionRegistro
        '
        Me.txtSeccionRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeccionRegistro.Location = New System.Drawing.Point(216, 66)
        Me.txtSeccionRegistro.MaxLength = 100
        Me.txtSeccionRegistro.Name = "txtSeccionRegistro"
        Me.txtSeccionRegistro.ReadOnly = True
        Me.txtSeccionRegistro.Size = New System.Drawing.Size(496, 20)
        Me.txtSeccionRegistro.TabIndex = 10
        '
        'txtNoOrden
        '
        Me.txtNoOrden.Location = New System.Drawing.Point(92, 21)
        Me.txtNoOrden.Name = "txtNoOrden"
        Me.txtNoOrden.Size = New System.Drawing.Size(116, 20)
        Me.txtNoOrden.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "No. Anotación:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(144, 138)
        Me.txtObs.MaxLength = 255
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(568, 32)
        Me.txtObs.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Observación:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(496, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Fecha de inscripción:"
        '
        'dtpFechaInsc
        '
        Me.dtpFechaInsc.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaInsc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInsc.Location = New System.Drawing.Point(616, 114)
        Me.dtpFechaInsc.Name = "dtpFechaInsc"
        Me.dtpFechaInsc.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaInsc.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(264, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Fecha de presentación:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "No. de presentación:"
        '
        'dtpFechaPresent
        '
        Me.dtpFechaPresent.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaPresent.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaPresent.Location = New System.Drawing.Point(392, 114)
        Me.dtpFechaPresent.Name = "dtpFechaPresent"
        Me.dtpFechaPresent.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaPresent.TabIndex = 18
        '
        'txtNoPresentacion
        '
        Me.txtNoPresentacion.Location = New System.Drawing.Point(144, 114)
        Me.txtNoPresentacion.Name = "txtNoPresentacion"
        Me.txtNoPresentacion.Size = New System.Drawing.Size(112, 20)
        Me.txtNoPresentacion.TabIndex = 16
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(144, 90)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(239, 20)
        Me.txtDepartamento.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Departamento:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Sección del CNR:"
        '
        'tb
        '
        Me.tb.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tb.Controls.Add(Me.TabPage1)
        Me.tb.Controls.Add(Me.TabPage2)
        Me.tb.Controls.Add(Me.TabPage3)
        Me.tb.Location = New System.Drawing.Point(23, 143)
        Me.tb.Name = "tb"
        Me.tb.SelectedIndex = 0
        Me.tb.Size = New System.Drawing.Size(752, 360)
        Me.tb.TabIndex = 0
        '
        'btnCertExt1
        '
        Me.btnCertExt1.Location = New System.Drawing.Point(345, 505)
        Me.btnCertExt1.Name = "btnCertExt1"
        Me.btnCertExt1.Size = New System.Drawing.Size(168, 28)
        Me.btnCertExt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCertExt1.TabIndex = 220
        Me.btnCertExt1.Text = "&Certificación Extractada"
        Me.btnCertExt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCertExt1.UseSelectable = True
        Me.btnCertExt1.UseStyleColors = True
        '
        'btAtras1
        '
        Me.btAtras1.Location = New System.Drawing.Point(519, 505)
        Me.btAtras1.Name = "btAtras1"
        Me.btAtras1.Size = New System.Drawing.Size(80, 28)
        Me.btAtras1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btAtras1.TabIndex = 221
        Me.btAtras1.Text = "&Atrás"
        Me.btAtras1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btAtras1.UseSelectable = True
        Me.btAtras1.UseStyleColors = True
        '
        'btnSig1
        '
        Me.btnSig1.Location = New System.Drawing.Point(605, 505)
        Me.btnSig1.Name = "btnSig1"
        Me.btnSig1.Size = New System.Drawing.Size(80, 28)
        Me.btnSig1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSig1.TabIndex = 222
        Me.btnSig1.Text = "&Siguiente"
        Me.btnSig1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSig1.UseSelectable = True
        Me.btnSig1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(691, 505)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(80, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 223
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsGrAnotacionPreventiva
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(811, 583)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btnSig1)
        Me.Controls.Add(Me.btAtras1)
        Me.Controls.Add(Me.btnCertExt1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.tb)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(811, 583)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(811, 583)
        Me.Name = "frmMsGrAnotacionPreventiva"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Control de Anotaciones Preventivas"
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.gbPresentaciones.ResumeLayout(False)
        CType(Me.fgPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRestricciones.ResumeLayout(False)
        CType(Me.fgRestriccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.gbAcreedores.ResumeLayout(False)
        CType(Me.fgAcreedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInmueble.ResumeLayout(False)
        CType(Me.fgInmueble, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tb.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim CRED As New wrCredito.wsLibCred
    Dim vCodPrestamo As String, vDui As String, vNoSocio As String, vNumSolicitud As Long, pNoDoc As String
    Public vNOCOMPROBANTE As String
    Public ORIGEN As Integer
    Public IDANOTACION As Integer
    Public vACCION As Integer '1 CONSULTAR, 2 INSERTAR, 3 MODIFICAR
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
            Return vACCION
        End Get
        Set(ByVal Value As String)
            vACCION = Value
        End Set
    End Property

#End Region

    Private Sub frmMsGrAnotacionPreventiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MOSTRAR_DATOSASOCIADO(vNumSolicitud)
            SOLOLECTURA_DATOSCERTIFICACIONEXTRACTADA()
            If Me.ORIGEN = 1 Then 'ORIGEN 
                CargarDatos_Certificacion(1)
            ElseIf Me.ORIGEN = 2 Then
                CargarDatos_Certificacion(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comuniquese con el Administrador del sistema.")
        End Try

    End Sub
    Private Sub CargarDatos_Certificacion(ByVal OPCION As Integer)
        Dim DTS As DataSet
        Dim ANOTACION As New DataSet
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim Nocomprobante As String
        If vNOCOMPROBANTE Is Nothing Then
            Nocomprobante = " "
        Else
            Nocomprobante = vNOCOMPROBANTE
        End If
        Dim oAsoc As New wrAsociados.wsLibAsoc
        Dim oCred As New wrCredito.wsLibCred
        DTS = CRED.CONSULTARDET_CERTIFICACIONEXTRACTADA(sUsuario, sPassword, sSucursal, vNumSolicitud, OPCION, Nocomprobante)
        If DTS.Tables(0).Rows.Count > 0 Then
            txtCodSeccion.Text = DTS.Tables(0).Rows(0).Item("CODSECCION")
            txtSeccionRegistro.Text = DTS.Tables(0).Rows(0).Item("SECCION")
            txtDepartamento.Text = DTS.Tables(0).Rows(0).Item("DEPARTAMENTO")
            txtNoInscripcion.Text = DTS.Tables(0).Rows(0).Item("NOINSCRIPCION")
            txtNoLibro.Text = DTS.Tables(0).Rows(0).Item("NOLIBRO")
            txtNoMatricula.Text = DTS.Tables(0).Rows(0).Item("NOMATRICULA")
            txtNoAsiento.Text = DTS.Tables(0).Rows(0).Item("NOASIENTO")
            txtUbicacion.Text = DTS.Tables(0).Rows(0).Item("UBICACION")
            txtArea.Text = DTS.Tables(0).Rows(0).Item("AREA")
            Me.fgAcreedor.DataSource = oCred.CONSULTARACREEDORES(sUsuario, sPassword, sSucursal, DTS.Tables(0).Rows(0).Item("NOCOMPROBANTE"), 1, 0).Tables(0)
            Me.fgInmueble.DataSource = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 1, DTS.Tables(0).Rows(0).Item("NOCOMPROBANTE"), 0).Tables(0)
            Me.fgRestriccion.DataSource = oCred.CONSULTARRESTRICCIONES(sUsuario, sPassword, sSucursal, DTS.Tables(0).Rows(0).Item("NOCOMPROBANTE"), 1, 0).Tables(0)
            Me.fgPresentacion.DataSource = oCred.CONSULTARPRESENTACIONES(sUsuario, sPassword, sSucursal, DTS.Tables(0).Rows(0).Item("NOCOMPROBANTE"), 1, 0).Tables(0)
            If vACCION = 2 Then
                Me.btnGuardar1.Text = "&Guardar"
            ElseIf vACCION = 1 Then
                If ORIGEN = 1 Then
                    LLENAR_DATOS_ANOTACION(2)
                Else
                    LLENAR_DATOS_ANOTACION(1)
                End If
                SOLOLECTURA()
            ElseIf vACCION = 3 Then
                If ORIGEN = 1 Then
                    LLENAR_DATOS_ANOTACION(2)
                Else
                    LLENAR_DATOS_ANOTACION(1)
                End If
                Me.btnGuardar1.Text = "&Modificar"
            End If
        Else
            MsgBox("Falta certificación extractada", MsgBoxStyle.Information, "Módulo - Garantías")
            Me.Dispose()
        End If
    End Sub
    Protected Sub LLENAR_DATOS_ANOTACION(ByVal OPCION As Integer)
        Dim ANOTACION As New DataSet
        ANOTACION = CRED.CONSULTARANOTACIONPREVENTIVA(sUsuario, sPassword, sSucursal, vNumSolicitud, IDANOTACION, OPCION)
        txtNoOrden.Text = ANOTACION.Tables(0).Rows(0).Item("NOANOTACION")
        txtNoPresentacion.Text = ANOTACION.Tables(0).Rows(0).Item("NOPRESENTACION")
        dtpFechaPresent.Value = ANOTACION.Tables(0).Rows(0).Item("FECHAPRESENTACION")
        txtObs.Text = ANOTACION.Tables(0).Rows(0).Item("OBSERVACION")
        txtNoInscripcion.Text = ANOTACION.Tables(0).Rows(0).Item("NOINSCRIPCION")
        dtFECHAINIANOTACION.Value = ANOTACION.Tables(0).Rows(0).Item("FECHAINICIOANOTACION")
        dtFECHAFANOTACION.Value = ANOTACION.Tables(0).Rows(0).Item("FECHAFINANOTACION")
    End Sub
    Protected Sub MOSTRAR_DATOSASOCIADO(ByVal NUMSOLICITUD As Integer)
        Dim DTS As New DataSet
        Dim DUI As String
        Dim TASA As Double
        Dim PLAZO As Integer
        Dim MONTO As Double
        Dim ASOCIADO As String
        DTS = CRED.CONSULTAR_DATOSGENERALESASOCIADOS(sUsuario, sPassword, sSucursal, NUMSOLICITUD)
        DUI = DTS.Tables(0).Rows(0).Item("DUI")
        TASA = DTS.Tables(0).Rows(0).Item("TASA_INTERES")
        PLAZO = DTS.Tables(0).Rows(0).Item("PLAZO")
        MONTO = (DTS.Tables(0).Rows(0).Item("MONTO"))
        ASOCIADO = DTS.Tables(0).Rows(0).Item("ASOCIADO")
        Me.lblDui.Text = lblDui.Text & " " & DUI
        Me.lblTasaInt.Text = Me.lblTasaInt.Text & " " & TASA
        Me.lblPlazo.Text = Me.lblPlazo.Text & " " & PLAZO
        Me.lblMonto.Text = Me.lblMonto.Text & " " & MONTO
        Me.lblConcedido.Text = Me.lblConcedido.Text & " " & ASOCIADO
    End Sub
    Protected Sub SOLOLECTURA()
        txtNoOrden.ReadOnly = True
        txtNoPresentacion.ReadOnly = True
        dtpFechaPresent.Enabled = False
        txtObs.ReadOnly = True
        txtNoInscripcion.ReadOnly = True
        dtFECHAINIANOTACION.Enabled = False
        dtFECHAFANOTACION.Enabled = False
        Me.txtNOASIENTOANOTACION.ReadOnly = True
    End Sub
    Private Function Guardar_CertificacionesExtractadas(ByVal NOCOMPROBANTE As String, ByVal NOANOTACION As String, ByVal NUMSOLICITUD As Integer) As Boolean
        Dim oCred As New wrCredito.wsLibCred
        Dim flag As Boolean
        flag = oCred.INSERTAR_GRCERTIFICACION_ANOTACION(sUsuario, sPassword, sSucursal, NOCOMPROBANTE, NOANOTACION, NUMSOLICITUD)
        Return flag
    End Function


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
    Private Sub dtFECHAINIANOTACION_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFECHAINIANOTACION.ValueChanged
        Me.dtFECHAFANOTACION.Value = Me.dtFECHAINIANOTACION.Value.AddDays(90)
    End Sub

    Private Sub btnCertExt1_Click(sender As Object, e As EventArgs) Handles btnCertExt1.Click
        Dim frm As New frmMsCertificacionExtractada
        frm.NumSolicitud = vNumSolicitud
        frm.Show()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btAtras1.Click
        If Me.tb.SelectedIndex > 0 Then
            Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
        End If
    End Sub

    Private Sub btnSig1_Click(sender As Object, e As EventArgs) Handles btnSig1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim TOTAL_CERTIFICACIONES As Integer
            Dim NOCOMPROBANTE As String
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String
            Select Case oCred.AutorizarDatos(Trim(Me.txtNoOrden.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El No. de Anotación no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Garantías")
                    Exit Sub
            End Select
            If Me.btnGuardar1.Text = "&Guardar" Then
                If oCred.INSERTARANOACIONPREVENTIVA(sUsuario, sPassword, sSucursal, Me.vNumSolicitud, Trim(Me.txtNoOrden.Text) _
                                                    , Me.txtNoPresentacion.Text, Format(Me.dtpFechaPresent.Value, "SHORT DATE"),
                                                    Me.txtObs.Text.Trim, Me.txtNoInscripcion.Text, sUsuario, Now,
                                                    Format(Me.dtFECHAINIANOTACION.Value, "SHORT DATE"),
                                                    Format(Me.dtFECHAFANOTACION.Value, "SHORT DATE"), vNOCOMPROBANTE, Me.txtNOASIENTOANOTACION.Text
                                                    ) = True Then

                    Me.gbAcreedores.Enabled = True
                    Me.gbInmueble.Enabled = True
                    Me.gbPresentaciones.Enabled = True
                    Me.gbRestricciones.Enabled = True
                    MsgBox("Anotación ingresada exitosamente.", MsgBoxStyle.Information, "Módulo Garantías")
                Else
                    MsgBox("El registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Garantías")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                Dim resultado As Integer
                resultado = CRED.MODIFICARANOTACIONPREVENTIVA(sUsuario, sPassword, sSucursal, IDANOTACION, Trim(Me.txtNoOrden.Text),
                                                  txtNoPresentacion.Text.Trim, Format(Me.dtpFechaPresent.Value, "SHORT DATE"),
                                                  txtObs.Text.Trim, sUsuario, Now, Format(dtFECHAINIANOTACION.Value, "SHORT DATE"),
                                                  Format(dtFECHAFANOTACION.Value, "SHORT DATE")
                                                  )
                If resultado <> 0 Then
                    If Me.CBMODIF_CE.Checked = True Then
                        MODIFICAR_CERTIFICACIONEXTRACTADA()
                    End If
                    MsgBox("Anotación modificada exitosamente.", MsgBoxStyle.Information, "Módulo Garantías")
                Else
                    MsgBox("Error en la modificación.", MsgBoxStyle.Information, "Módulo - Garantías")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNewInmueble1_Click(sender As Object, e As EventArgs) Handles btNewInmueble1.Click
        Dim ofrm As New fmMsGrDuenosInmueble
        ofrm.NoDoc = Me.vNOCOMPROBANTE
        ofrm.Tipo = "A"
        ofrm.Accion = "Guardar"
        ofrm.ShowDialog()
        Dim oCred As New wrCredito.wsLibCred
        Me.fgInmueble.DataSource = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 1, vNOCOMPROBANTE, 0).Tables(0)
        fgInmueble.Cols.Item(0).Width = 0
    End Sub

    Private Sub btEditInmueble1_Click(sender As Object, e As EventArgs) Handles btEditInmueble1.Click
        If fgInmueble.Row > 0 Then
            Dim ofrm As New fmMsGrDuenosInmueble
            ofrm.NoDoc = vNOCOMPROBANTE
            ofrm.Correlativo = fgInmueble.Item(fgInmueble.Row, "Correlativo")
            ofrm.Tipo = "C"
            ofrm.Accion = "Modificar"
            ofrm.ShowDialog()
            Dim oCred As New wrCredito.wsLibCred
            Me.fgInmueble.DataSource = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 1, vNOCOMPROBANTE, 0).Tables(0)

            fgInmueble.Cols.Item(0).Width = 0
        End If
    End Sub

    Private Sub btDelInmueble1_Click(sender As Object, e As EventArgs) Handles btDelInmueble1.Click
        If Me.fgInmueble.Row > 0 Then
            If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Bien Inmueble", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim oCred As New wrCredito.wsLibCred
                oCred.EliminarDuenosInmueble(Me.fgInmueble.Item(Me.fgInmueble.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                Me.fgInmueble.DataSource = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 1, Me.vNOCOMPROBANTE, 0).Tables(0)
                'Me.fgInmueble.DataSource = oCred.ConsultarDuenosInmueble("Correlativo,Nombre,Porcentaje,Asociado", "NoComprobante='" & Me.pNoDoc & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                fgInmueble.Cols.Item(0).Width = 0
            End If
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim ofrm As New frmMsGrAcreedores
        ofrm.NoDoc = Me.pNoDoc
        ofrm.Tipo = "A"
        ofrm.Accion = "Guardar"
        ofrm.ShowDialog()
        Dim oCred As New wrCredito.wsLibCred
        Me.fgAcreedor.DataSource = oCred.CONSULTARACREEDORES(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, 1, 0).Tables(0)
        fgAcreedor.Cols.Item(0).Width = 0
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If fgAcreedor.Row > 0 Then
            Dim CORRELATIVO As Integer
            CORRELATIVO = fgAcreedor.Item(fgAcreedor.Row, "Correlativo")
            Dim ofrm As New frmMsGrAcreedores
            ofrm.NoDoc = vNOCOMPROBANTE
            ofrm.Correlativo = CORRELATIVO
            ofrm.Tipo = "C"
            ofrm.Accion = "Modificar"
            ofrm.ShowDialog()
            Dim oCred As New wrCredito.wsLibCred
            Me.fgAcreedor.DataSource = oCred.CONSULTARACREEDORES(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, 2, CORRELATIVO).Tables(0)
            fgAcreedor.Cols.Item(0).Width = 0
        End If
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If Me.fgAcreedor.Row > 0 Then
            If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Acreedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim oCred As New wrCredito.wsLibCred
                oCred.EliminarAcreedores(Me.fgAcreedor.Item(Me.fgAcreedor.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                Me.fgAcreedor.DataSource = oCred.CONSULTARACREEDORES(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, 1, 0).Tables(0)
                fgAcreedor.Cols.Item(0).Width = 0
            End If
        End If
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Dim ofrm As New fmMsGrRestricciones
        ofrm.NoDoc = Me.vNOCOMPROBANTE
        ofrm.Tipo = "A"
        ofrm.Accion = "Guardar"
        ofrm.ShowDialog()
        Dim oCred As New wrCredito.wsLibCred
        Me.fgRestriccion.DataSource = oCred.CONSULTARRESTRICCIONES(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, 1, 0).Tables(0)
        fgRestriccion.Cols.Item(0).Width = 0
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        If Me.fgRestriccion.Row > 0 Then
            If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Restricciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim oCred As New wrCredito.wsLibCred
                oCred.EliminarRestricciones(Me.fgRestriccion.Item(Me.fgRestriccion.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                Me.fgRestriccion.DataSource = oCred.CONSULTARRESTRICCIONES("Correlativo,NoComprobante,Descripcion,FechaIni,FechaFin", "NoComprobante='" & Me.vNOCOMPROBANTE & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                Me.fgRestriccion.Cols.Item(0).Width = 0
            End If
        End If
    End Sub

    Private Sub MetroButton9_Click(sender As Object, e As EventArgs) Handles MetroButton9.Click
        Dim ofrm As New frmMsGrPresentaciones
        ofrm.NoDoc = Me.pNoDoc
        ofrm.Tipo = "A"
        ofrm.Accion = "Guardar"
        ofrm.ShowDialog()
        Dim oCred As New wrCredito.wsLibCred
        Me.fgPresentacion.DataSource = oCred.CONSULTARPRESENTACIONES(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, 1, 0).Tables(0)
        fgPresentacion.Cols.Item(0).Width = 0
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        If Me.fgPresentacion.Row > 0 Then
            Dim CORRELATIVO As Integer
            CORRELATIVO = Me.fgPresentacion.Item(Me.fgPresentacion.Row, "Correlativo")
            Dim ofrm As New frmMsGrPresentaciones
            ofrm.NoDoc = vNOCOMPROBANTE
            ofrm.Correlativo = CORRELATIVO
            ofrm.Tipo = "C"
            ofrm.Accion = "Modificar"
            ofrm.ShowDialog()
            Dim oCred As New wrCredito.wsLibCred
            Me.fgPresentacion.DataSource = oCred.CONSULTARPRESENTACIONES(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, 2, CORRELATIVO).Tables(0)
            Me.fgPresentacion.Cols.Item(0).Width = 0
        End If
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        If Me.fgPresentacion.Row > 0 Then
            If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Presentaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim oCred As New wrCredito.wsLibCred
                oCred.EliminarPresentaciones(Me.fgPresentacion.Item(Me.fgPresentacion.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                Me.fgPresentacion.DataSource = oCred.CONSULTARPRESENTACIONES("Correlativo,NoPresentacion,Descripcion", "NoComprobante='" & Me.pNoDoc & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                Me.fgPresentacion.Cols.Item(0).Width = 0
            End If
        End If
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        If Me.fgRestriccion.Row > 0 Then
            Dim CORRELATIVO As Integer
            CORRELATIVO = Me.fgRestriccion.Item(Me.fgRestriccion.Row, "Correlativo")
            Dim ofrm As New fmMsGrRestricciones
            ofrm.NoDoc = vNOCOMPROBANTE
            ofrm.Correlativo = CORRELATIVO
            ofrm.Tipo = "C"
            ofrm.Accion = "Modificar"
            ofrm.ShowDialog()
            Dim oCred As New wrCredito.wsLibCred
            Me.fgRestriccion.DataSource = oCred.CONSULTARRESTRICCIONES(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, 2, CORRELATIVO).Tables(0)
            Me.fgRestriccion.Cols.Item(0).Width = 0
        End If
    End Sub

    Protected Sub HABILITAR_DATOSCERTIFICACIONEXTRACTADA()
        txtCodSeccion.Enabled = True
        txtSeccionRegistro.ReadOnly = False
        txtDepartamento.ReadOnly = False
        txtNoInscripcion.ReadOnly = False
        txtNoLibro.ReadOnly = False
        txtNoMatricula.ReadOnly = False
        txtNoAsiento.ReadOnly = False
        txtUbicacion.ReadOnly = False
        txtArea.ReadOnly = False
    End Sub
    Protected Sub SOLOLECTURA_DATOSCERTIFICACIONEXTRACTADA()
        txtCodSeccion.Enabled = False
        txtSeccionRegistro.ReadOnly = True
        txtDepartamento.ReadOnly = True
        txtNoInscripcion.ReadOnly = True
        txtNoLibro.ReadOnly = True
        txtNoMatricula.ReadOnly = True
        txtNoAsiento.ReadOnly = True
        txtUbicacion.ReadOnly = True
        txtArea.ReadOnly = True
    End Sub
    Protected Sub MODIFICAR_CERTIFICACIONEXTRACTADA()
        CRED.MODIFICARCERTIFICACIONEXTRACTADA(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, "01/01/1990", Me.txtNoInscripcion.Text, Me.txtNoLibro.Text.Trim, Me.txtNoMatricula.Text, _
                                                           Me.txtNoAsiento.Text.Trim, Me.txtUbicacion.Text.Trim, Me.txtArea.Text.Trim, " ", " ", Me.txtCodSeccion.Text.Trim, 0, " ", _
                                                           Now, 2)
    End Sub
    Private Sub CBMODIF_CE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBMODIF_CE.CheckedChanged
        If Me.CBMODIF_CE.Checked = True Then
            HABILITAR_DATOSCERTIFICACIONEXTRACTADA()
        Else
            SOLOLECTURA_DATOSCERTIFICACIONEXTRACTADA()
        End If

    End Sub
End Class