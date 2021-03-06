Imports System.Globalization
Imports System.Threading

Public Class frmPartidasAut
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    'Private vAccion As Contabilidad.clsPartida.TipoAccionPartidas
    Private vAccion As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas
    'Private vAccionDetalle As Contabilidad.clsPartida.TipoAccionPartidas
    Private vAccionDetalle As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas
    Private vdsDetalle As System.Data.DataSet, vCorrel As Integer
    Private vC As Decimal, vA As Decimal
    Private errorProvider1 As System.Windows.Forms.ErrorProvider = New System.Windows.Forms.ErrorProvider
    Private vIdModifica As String
    Private vPref As String
    'Private vTipo As Contabilidad.clsPartida.TipoPartidaModulo
    Private vTipo As sifLib.Contabilidad.clsPartidas.TipoPartidaModulo
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private pdrNueva As System.Data.DataRow
    Dim contabilidad As New wrConta.wsLibContab
    Friend WithEvents btnAceptarLin1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelarLin1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnInsertarLin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificarLin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminarLin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCargarPl1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarPl1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cbCC As MetroFramework.Controls.MetroComboBox
    Dim isHabilitar As Boolean

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDif As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAbonos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCargos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkInicial As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoPartidas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1fgrdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtAbono As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCargo As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtIdCuentaBE As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaCB As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuentaCB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartidasAut))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardarPl1 = New MetroFramework.Controls.MetroButton()
        Me.txtIdCuentaCB = New System.Windows.Forms.TextBox()
        Me.btnCargarPl1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminarLin = New MetroFramework.Controls.MetroButton()
        Me.btnCancelarLin1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificarLin = New MetroFramework.Controls.MetroButton()
        Me.btnAceptarLin1 = New MetroFramework.Controls.MetroButton()
        Me.btnInsertarLin = New MetroFramework.Controls.MetroButton()
        Me.txtAbono = New C1.Win.C1Input.C1TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCargo = New C1.Win.C1Input.C1TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C1fgrdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.txtDif = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalAbonos = New System.Windows.Forms.TextBox()
        Me.txtTotalCargos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkInicial = New System.Windows.Forms.CheckBox()
        Me.txtCuentaCB = New System.Windows.Forms.TextBox()
        Me.cmbTipoPartidas = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdCuentaBE = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar1 = New MetroFramework.Controls.MetroButton()
        Me.cbCC = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtAbono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cbCC)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnGuardarPl1)
        Me.GroupBox1.Controls.Add(Me.txtIdCuentaCB)
        Me.GroupBox1.Controls.Add(Me.btnCargarPl1)
        Me.GroupBox1.Controls.Add(Me.btnEliminarLin)
        Me.GroupBox1.Controls.Add(Me.btnCancelarLin1)
        Me.GroupBox1.Controls.Add(Me.btnModificarLin)
        Me.GroupBox1.Controls.Add(Me.btnAceptarLin1)
        Me.GroupBox1.Controls.Add(Me.btnInsertarLin)
        Me.GroupBox1.Controls.Add(Me.txtAbono)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.C1fgrdDetalle)
        Me.GroupBox1.Controls.Add(Me.txtConcepto)
        Me.GroupBox1.Controls.Add(Me.txtDif)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtTotalAbonos)
        Me.GroupBox1.Controls.Add(Me.txtTotalCargos)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chkInicial)
        Me.GroupBox1.Controls.Add(Me.txtCuentaCB)
        Me.GroupBox1.Controls.Add(Me.cmbTipoPartidas)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(902, 556)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 34)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Centro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Costo:"
        '
        'btnGuardarPl1
        '
        Me.btnGuardarPl1.Location = New System.Drawing.Point(570, 516)
        Me.btnGuardarPl1.Name = "btnGuardarPl1"
        Me.btnGuardarPl1.Size = New System.Drawing.Size(133, 32)
        Me.btnGuardarPl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardarPl1.TabIndex = 41
        Me.btnGuardarPl1.Text = "Guardar Plantilla"
        Me.btnGuardarPl1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardarPl1.UseSelectable = True
        Me.btnGuardarPl1.UseStyleColors = True
        Me.btnGuardarPl1.Visible = False
        '
        'txtIdCuentaCB
        '
        Me.txtIdCuentaCB.BackColor = System.Drawing.Color.White
        Me.txtIdCuentaCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCuentaCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCuentaCB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtIdCuentaCB.Location = New System.Drawing.Point(83, 355)
        Me.txtIdCuentaCB.Name = "txtIdCuentaCB"
        Me.txtIdCuentaCB.Size = New System.Drawing.Size(199, 25)
        Me.txtIdCuentaCB.TabIndex = 18
        Me.txtIdCuentaCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCargarPl1
        '
        Me.btnCargarPl1.Location = New System.Drawing.Point(430, 517)
        Me.btnCargarPl1.Name = "btnCargarPl1"
        Me.btnCargarPl1.Size = New System.Drawing.Size(133, 32)
        Me.btnCargarPl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCargarPl1.TabIndex = 40
        Me.btnCargarPl1.Text = "Cargar Plantilla"
        Me.btnCargarPl1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCargarPl1.UseSelectable = True
        Me.btnCargarPl1.UseStyleColors = True
        Me.btnCargarPl1.Visible = False
        '
        'btnEliminarLin
        '
        Me.btnEliminarLin.Location = New System.Drawing.Point(289, 517)
        Me.btnEliminarLin.Name = "btnEliminarLin"
        Me.btnEliminarLin.Size = New System.Drawing.Size(133, 32)
        Me.btnEliminarLin.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminarLin.TabIndex = 39
        Me.btnEliminarLin.Text = "Eliminar Linea"
        Me.btnEliminarLin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminarLin.UseSelectable = True
        Me.btnEliminarLin.UseStyleColors = True
        '
        'btnCancelarLin1
        '
        Me.btnCancelarLin1.Location = New System.Drawing.Point(800, 458)
        Me.btnCancelarLin1.Name = "btnCancelarLin1"
        Me.btnCancelarLin1.Size = New System.Drawing.Size(90, 32)
        Me.btnCancelarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCancelarLin1.TabIndex = 36
        Me.btnCancelarLin1.Text = "Cancelar"
        Me.btnCancelarLin1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCancelarLin1.UseSelectable = True
        Me.btnCancelarLin1.UseStyleColors = True
        '
        'btnModificarLin
        '
        Me.btnModificarLin.Location = New System.Drawing.Point(149, 517)
        Me.btnModificarLin.Name = "btnModificarLin"
        Me.btnModificarLin.Size = New System.Drawing.Size(133, 32)
        Me.btnModificarLin.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificarLin.TabIndex = 38
        Me.btnModificarLin.Text = "Modificar Linea"
        Me.btnModificarLin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificarLin.UseSelectable = True
        Me.btnModificarLin.UseStyleColors = True
        '
        'btnAceptarLin1
        '
        Me.btnAceptarLin1.Location = New System.Drawing.Point(800, 419)
        Me.btnAceptarLin1.Name = "btnAceptarLin1"
        Me.btnAceptarLin1.Size = New System.Drawing.Size(90, 32)
        Me.btnAceptarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptarLin1.TabIndex = 35
        Me.btnAceptarLin1.Text = "Aceptar"
        Me.btnAceptarLin1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAceptarLin1.UseSelectable = True
        Me.btnAceptarLin1.UseStyleColors = True
        '
        'btnInsertarLin
        '
        Me.btnInsertarLin.Location = New System.Drawing.Point(8, 517)
        Me.btnInsertarLin.Name = "btnInsertarLin"
        Me.btnInsertarLin.Size = New System.Drawing.Size(134, 32)
        Me.btnInsertarLin.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnInsertarLin.TabIndex = 37
        Me.btnInsertarLin.Text = "Insertar Linea"
        Me.btnInsertarLin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnInsertarLin.UseSelectable = True
        Me.btnInsertarLin.UseStyleColors = True
        '
        'txtAbono
        '
        Me.txtAbono.BackColor = System.Drawing.Color.White
        Me.txtAbono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbono.DataType = GetType(Decimal)
        Me.txtAbono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAbono.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAbono.Location = New System.Drawing.Point(312, 487)
        Me.txtAbono.MaskInfo.ShowLiterals = C1.Win.C1Input.ShowLiteralsEnum.WhenNextStarted
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtAbono.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtAbono.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtAbono.Size = New System.Drawing.Size(154, 23)
        Me.txtAbono.TabIndex = 12
        Me.txtAbono.Tag = Nothing
        Me.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAbono.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(94, 50)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(799, 64)
        Me.txtDescripcion.TabIndex = 8
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.White
        Me.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargo.DataType = GetType(Decimal)
        Me.txtCargo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtCargo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCargo.Location = New System.Drawing.Point(85, 488)
        Me.txtCargo.MaskInfo.ShowLiterals = C1.Win.C1Input.ShowLiteralsEnum.WhenNextStarted
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtCargo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtCargo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtCargo.Size = New System.Drawing.Size(154, 23)
        Me.txtCargo.TabIndex = 23
        Me.txtCargo.Tag = Nothing
        Me.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCargo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripci�n"
        '
        'C1fgrdDetalle
        '
        Me.C1fgrdDetalle.AllowEditing = False
        Me.C1fgrdDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdDetalle.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdDetalle.BackColor = System.Drawing.Color.White
        Me.C1fgrdDetalle.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.C1fgrdDetalle.Location = New System.Drawing.Point(7, 155)
        Me.C1fgrdDetalle.Name = "C1fgrdDetalle"
        Me.C1fgrdDetalle.Rows.DefaultSize = 21
        Me.C1fgrdDetalle.Size = New System.Drawing.Size(883, 193)
        Me.C1fgrdDetalle.StyleInfo = resources.GetString("C1fgrdDetalle.StyleInfo")
        Me.C1fgrdDetalle.TabIndex = 16
        '
        'txtConcepto
        '
        Me.txtConcepto.BackColor = System.Drawing.Color.White
        Me.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConcepto.Location = New System.Drawing.Point(83, 419)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConcepto.Size = New System.Drawing.Size(702, 62)
        Me.txtConcepto.TabIndex = 21
        '
        'txtDif
        '
        Me.txtDif.BackColor = System.Drawing.Color.White
        Me.txtDif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDif.Enabled = False
        Me.txtDif.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDif.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDif.Location = New System.Drawing.Point(94, 123)
        Me.txtDif.Name = "txtDif"
        Me.txtDif.Size = New System.Drawing.Size(118, 25)
        Me.txtDif.TabIndex = 10
        Me.txtDif.Text = "0"
        Me.txtDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(10, 419)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 19)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Concepto"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(10, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 19)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Diferencia"
        '
        'txtTotalAbonos
        '
        Me.txtTotalAbonos.BackColor = System.Drawing.Color.White
        Me.txtTotalAbonos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAbonos.Enabled = False
        Me.txtTotalAbonos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAbonos.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTotalAbonos.Location = New System.Drawing.Point(552, 123)
        Me.txtTotalAbonos.Name = "txtTotalAbonos"
        Me.txtTotalAbonos.Size = New System.Drawing.Size(145, 25)
        Me.txtTotalAbonos.TabIndex = 14
        Me.txtTotalAbonos.Text = "0"
        Me.txtTotalAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCargos
        '
        Me.txtTotalCargos.BackColor = System.Drawing.Color.White
        Me.txtTotalCargos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalCargos.Enabled = False
        Me.txtTotalCargos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCargos.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTotalCargos.Location = New System.Drawing.Point(313, 123)
        Me.txtTotalCargos.Name = "txtTotalCargos"
        Me.txtTotalCargos.Size = New System.Drawing.Size(138, 25)
        Me.txtTotalCargos.TabIndex = 12
        Me.txtTotalCargos.Text = "0"
        Me.txtTotalCargos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(458, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total Abonos"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(220, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total Cargos"
        '
        'chkInicial
        '
        Me.chkInicial.Location = New System.Drawing.Point(704, 122)
        Me.chkInicial.Name = "chkInicial"
        Me.chkInicial.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkInicial.Size = New System.Drawing.Size(144, 19)
        Me.chkInicial.TabIndex = 15
        Me.chkInicial.Text = "Partida Inicial"
        Me.chkInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCuentaCB
        '
        Me.txtCuentaCB.BackColor = System.Drawing.Color.White
        Me.txtCuentaCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaCB.Enabled = False
        Me.txtCuentaCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaCB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCuentaCB.Location = New System.Drawing.Point(288, 354)
        Me.txtCuentaCB.Name = "txtCuentaCB"
        Me.txtCuentaCB.Size = New System.Drawing.Size(602, 25)
        Me.txtCuentaCB.TabIndex = 19
        Me.txtCuentaCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbTipoPartidas
        '
        Me.cmbTipoPartidas.BackColor = System.Drawing.Color.White
        Me.cmbTipoPartidas.Location = New System.Drawing.Point(647, 18)
        Me.cmbTipoPartidas.Name = "cmbTipoPartidas"
        Me.cmbTipoPartidas.Size = New System.Drawing.Size(246, 24)
        Me.cmbTipoPartidas.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(11, 354)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Cuenta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(529, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo de Partida"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(246, 488)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Abono"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(353, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 488)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Cargo"
        '
        'dtpFecha
        '
        Me.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(416, 18)
        Me.dtpFecha.MinDate = New Date(1945, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(104, 22)
        Me.dtpFecha.TabIndex = 4
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNumero.Location = New System.Drawing.Point(94, 18)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(252, 25)
        Me.txtNumero.TabIndex = 2
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "N�mero de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Partida"
        '
        'txtIdCuentaBE
        '
        Me.txtIdCuentaBE.BackColor = System.Drawing.Color.White
        Me.txtIdCuentaBE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCuentaBE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCuentaBE.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtIdCuentaBE.Location = New System.Drawing.Point(479, 23)
        Me.txtIdCuentaBE.Name = "txtIdCuentaBE"
        Me.txtIdCuentaBE.Size = New System.Drawing.Size(199, 25)
        Me.txtIdCuentaBE.TabIndex = 26
        Me.txtIdCuentaBE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIdCuentaBE.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(656, 636)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(134, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 42
        Me.btnGuardar1.Text = "&Guardar Partida"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnCancelar1
        '
        Me.btnCancelar1.Location = New System.Drawing.Point(797, 636)
        Me.btnCancelar1.Name = "btnCancelar1"
        Me.btnCancelar1.Size = New System.Drawing.Size(133, 32)
        Me.btnCancelar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCancelar1.TabIndex = 43
        Me.btnCancelar1.Text = "Cancelar"
        Me.btnCancelar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCancelar1.UseSelectable = True
        Me.btnCancelar1.UseStyleColors = True
        '
        'cbCC
        '
        Me.cbCC.FormattingEnabled = True
        Me.cbCC.ItemHeight = 24
        Me.cbCC.Location = New System.Drawing.Point(83, 386)
        Me.cbCC.Name = "cbCC"
        Me.cbCC.Size = New System.Drawing.Size(807, 30)
        Me.cbCC.TabIndex = 44
        Me.cbCC.UseSelectable = True
        '
        'frmPartidasAut
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(954, 674)
        Me.Controls.Add(Me.btnCancelar1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIdCuentaBE)
        Me.MaximumSize = New System.Drawing.Size(954, 674)
        Me.MinimumSize = New System.Drawing.Size(954, 674)
        Me.Name = "frmPartidasAut"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Partida Contable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtAbono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"

    Public Property drNueva() As System.Data.DataRow
        Get
            Return pdrNueva
        End Get
        Set(ByVal Value As System.Data.DataRow)
            pdrNueva = Value
        End Set
    End Property

    'Public Property Accion() As Contabilidad.clsPartida.TipoAccionPartidas
    Public Property Accion() As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas
        Get
            Return vAccion
        End Get
        'Set(ByVal Value As Contabilidad.clsPartida.TipoAccionPartidas)
        Set(ByVal Value As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas)
            vAccion = Value
        End Set
    End Property

    'Public Property AccionDetalle() As Contabilidad.clsPartida.TipoAccionPartidas
    Public Property AccionDetalle() As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas
        Get
            Return vAccionDetalle
        End Get
        'Set(ByVal Value As Contabilidad.clsPartida.TipoAccionPartidas)
        Set(ByVal Value As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas)
            vAccionDetalle = Value
        End Set
    End Property

    Public Property Detalle() As System.Data.DataSet
        Get
            Return vdsDetalle
        End Get
        Set(ByVal Value As System.Data.DataSet)
            vdsDetalle = Value
        End Set
    End Property

    Private Property Correlativo() As Integer
        Get
            Return vCorrel
        End Get
        Set(ByVal Value As Integer)
            vCorrel = Value
        End Set
    End Property

    Public Property IdModifica() As String
        Get
            Return vIdModifica
        End Get
        Set(ByVal Value As String)
            vIdModifica = Value
        End Set
    End Property

    Public Property Prefijo() As String
        Get
            Return vPref
        End Get
        Set(ByVal Value As String)
            vPref = Value
        End Set
    End Property

    'Public Property Tipo() As Contabilidad.clsPartida.TipoPartidaModulo
    Public Property Tipo() As sifLib.Contabilidad.clsPartidas.TipoPartidaModulo
        Get
            Return vTipo
        End Get
        'Set(ByVal Value As Contabilidad.clsPartida.TipoPartidaModulo)
        Set(ByVal Value As sifLib.Contabilidad.clsPartidas.TipoPartidaModulo)
            vTipo = Value
        End Set
    End Property

#End Region
    Protected Sub deshabilitarDetPartida(ByVal habilitar As Boolean)
        isHabilitar = habilitar
        If habilitar = True Then
            txtIdCuentaCB.Enabled = True
            txtCuentaCB.Enabled = True
            txtConcepto.Enabled = True
            txtCargo.Enabled = True
            txtAbono.Enabled = True
            btnAceptarLin1.Enabled = True
            btnCancelarLin1.Enabled = True
            Me.cbCC.Enabled = True
        Else
            Me.cbCC.Enabled = False
            txtIdCuentaCB.Enabled = False
            txtCuentaCB.Enabled = False
            txtConcepto.Enabled = False
            txtCargo.Enabled = False
            txtAbono.Enabled = False
            btnAceptarLin1.Enabled = False
            btnCancelarLin1.Enabled = False
        End If

    End Sub

    Private Sub frmPartidasAut_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCC()
        Dim oPartida As New wrConta.wsLibContab, oApp As New wrAdmin.wsLibAdmin
        Dim dsTipo As New DataSet, dr As DataRow, x As Integer
        deshabilitarDetPartida(False)
        dsTipo = oPartida.ObtenerTipoPartidasAut(oApp.Fecha.Year, sUsuario, sPassword, sSucursal)
        For Each dr In dsTipo.Tables(0).Rows
            cmbTipoPartidas.Items.Add(CStr(dr("Prefijo")) & " - " & CStr(dr("Descripcion")))
        Next
        If Me.Prefijo.Trim = "EG" Then
            Me.btnGuardarPl1.Enabled = False
            Me.btnGuardar1.Enabled = False
            Me.btnInsertarLin.Enabled = False
            Me.btnEliminarLin.Enabled = False
            Me.btnModificarLin.Enabled = False
            Me.btnCargarPl1.Enabled = False
            Me.btnCancelarLin1.Enabled = False
            Me.btnAceptarLin1.Enabled = False
        End If
        Select Case Me.Accion
            'Case Is = Contabilidad.clsPartida.TipoAccionPartidas.AgregarPartida
            Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.AgregarPartida
                Me.Detalle = oPartida.ObtenerPartidaVacia(sUsuario, sPassword, sSucursal)
                If Not (Me.drNueva Is Nothing) Then
                    If Not Me.drNueva.IsNull(0) Then
                        Dim drN As System.Data.DataRow
                        drN = Me.Detalle.Tables("Det_Diario").NewRow
                        drN("Correl") = Me.drNueva("Correl")
                        drN("IdCuenta") = Me.drNueva("IdCuenta")
                        drN("CodCosto") = Me.drNueva("CodCosto")
                        drN("CodBeneficio") = Me.drNueva("CodBeneficio")
                        drN("Descripcion") = Me.drNueva("Descripcion")
                        drN("Cargo") = Me.drNueva("Cargo")
                        drN("Abono") = Me.drNueva("Abono")
                        drN("Concepto") = Me.drNueva("Concepto")
                        Me.Detalle.Tables("Det_Diario").Rows.Add(drN)
                    End If
                End If
                C1fgrdDetalle.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                C1fgrdDetalle.DataSource = Me.Detalle.Tables(0)
            'Case Is = Contabilidad.clsPartida.TipoAccionPartidas.ModificarPartida
            Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarPartida

                Me.Detalle = oPartida.CargaPartidaAut(Me.IdModifica, sUsuario, sPassword, sSucursal)
                C1fgrdDetalle.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                C1fgrdDetalle.DataSource = Me.Detalle.Tables("Det_Diario")
                Me.txtNumero.Text = Trim(Me.Detalle.Tables("Diario").Rows(0)("Num_Partida"))
                Me.txtDescripcion.Text = Me.Detalle.Tables("Diario").Rows(0)("Descripcion")
                Me.dtpFecha.Value = Me.Detalle.Tables("Diario").Rows(0)("Fecha")
                'Me.cmbTipoPartidas.Text = Me.Detalle.Tables("Diario").Rows(0)("Prefijo")
                For x = 0 To Me.cmbTipoPartidas.Items.Count - 1
                    Me.cmbTipoPartidas.SelectedIndex = x
                    If Mid(Me.cmbTipoPartidas.Text, 1, 2) = IIf(IsDBNull(Me.Detalle.Tables("Diario").Rows(0)("Prefijo")), "", Me.Detalle.Tables("Diario").Rows(0)("Prefijo")) Then
                        Me.cmbTipoPartidas.SelectedIndex = x
                        Exit For
                    End If
                Next
                Me.txtTotalCargos.Text = Me.Detalle.Tables("Diario").Rows(0)("Cargo")
                Me.txtTotalAbonos.Text = Me.Detalle.Tables("Diario").Rows(0)("Abono")
                Me.txtDif.Text = Decimal.Parse(Me.txtTotalCargos.Text) - Decimal.Parse(Me.txtTotalAbonos.Text)
        End Select
    End Sub


    Private Sub txtIdCuentaCB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuentaCB.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("idCuenta,Descripcion,Cod_Ccosto", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtIdCuentaCB.Text = ofrm.Resultado.Trim
            txtCuentaCB.Text = ofrm.Resultado2.Trim

        Catch ex As Exception
            MessageBox.Show("Error en la recuperaci�n de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " M�todo: " & ex.TargetSite.Name, "Error de Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtIdCuentaBE_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuentaBE.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Centro de Beneficios"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatBeneficio("Cod_CBeneficio,Descripcion,Comentario", "Final='S'", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtIdCuentaBE.Text = ofrm.Resultado.Trim
            'txtCuentaBE.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperaci�n de datos tabla Cat_Beneficios - " & "System Error: " & ex.Message.ToString() & " M�todo: " & ex.TargetSite.Name, "Error de Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarDetalle()
        Me.txtIdCuentaCB.Text = ""
        Me.txtConcepto.Text = ""
        Me.txtIdCuentaBE.Text = ""
        Me.txtCuentaCB.Text = ""
        Me.txtCargo.Value = 0
        Me.txtAbono.Value = 0
    End Sub

    Private Sub C1fgrdDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1fgrdDetalle.DoubleClick

    End Sub

    Private Sub txtAbono_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbono.LostFocus
        If Me.txtAbono.Text <> 0 Then
            Me.txtCargo.Value = 0
            Me.txtConcepto.Focus()
        End If
    End Sub

    Private Sub txtCargo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCargo.LostFocus
        If Me.txtCargo.Text <> 0 Then
            Me.txtAbono.Value = 0
            Me.txtConcepto.Focus()
        End If
    End Sub
    Dim ObjDataset As New DataSet
    Public Function ImportarPartidaExcel(ByVal Ruta As String) As DataSet
        Dim ConecExcel As System.Data.OleDb.OleDbConnection
        Dim Dts As New DataSet
        Dim ObjAdapter As System.Data.OleDb.OleDbDataAdapter
        ConecExcel = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & Ruta & "';Extended Properties='Excel 12.0 Xml;HDR=YES';")
        ObjAdapter = New System.Data.OleDb.OleDbDataAdapter("select * from [Partida$]", ConecExcel)
        ObjAdapter.TableMappings.Add("Tabla", "Partida")
        ObjAdapter.Fill(Dts, "Partida")
        ConecExcel.Close()
        If ConecExcel.State <> ConnectionState.Closed Then
            ConecExcel.Dispose()
        End If
        Return Dts
    End Function



    Private Sub txtDescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.LostFocus
        Me.txtConcepto.Text = Me.txtDescripcion.Text
    End Sub



    Private Sub txtIdCuentaBE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIdCuentaBE.Validating
        Dim oPerif As New wrConta.wsLibContab, ds As New Data.DataSet, dr As DataRow
        ds = oPerif.ObtenerCatBeneficio("Cod_CBeneficio,Descripcion", "Cod_CBeneficio='" & Me.txtIdCuentaBE.Text.Trim & "' and Final='S'", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
        If ds.Tables("Catalogo").Rows.Count = 0 Then
            e.Cancel = True
            Me.txtIdCuentaBE.Select(0, txtIdCuentaBE.Text.Length)
            errorProvider1.SetIconAlignment(Me.txtIdCuentaBE, ErrorIconAlignment.MiddleRight)
            errorProvider1.SetIconPadding(Me.txtIdCuentaBE, 2)
            errorProvider1.BlinkRate = 1000
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
            errorProvider1.SetError(txtIdCuentaBE, "Cuenta Beneficios no existe")
        Else
            dr = ds.Tables("Catalogo").Rows(0)
            'Me.txtCuentaBE.Text = dr("Descripcion")
            If Me.txtIdCuentaBE.Text.Trim = "" Then
                e.Cancel = True
                Me.txtIdCuentaBE.Text = cbCC.SelectedValue
                errorProvider1.SetIconAlignment(Me.txtIdCuentaBE, ErrorIconAlignment.MiddleRight)
                errorProvider1.SetIconPadding(Me.txtIdCuentaBE, 2)
                errorProvider1.BlinkRate = 1000
                errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
                errorProvider1.SetError(txtIdCuentaBE, "Error de Validaci�n")
            Else
                errorProvider1.SetError(Me.txtIdCuentaBE, "")
            End If
        End If
    End Sub


    Private Sub txtIdCuentaCB_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIdCuentaCB.Validating
        Dim oPerif As New wrConta.wsLibContab, ds As New Data.DataSet, dr As DataRow
        ds = oPerif.ObtenerCatContab("IdCuenta,Descripcion,cod_Ccosto", "IdCuenta='" & Me.txtIdCuentaCB.Text.Trim & "' and Final='S'", "IdCuenta", sUsuario, sPassword, sSucursal)
        If ds.Tables("Catalogo").Rows.Count = 0 Then
            e.Cancel = True
            Me.txtIdCuentaCB.Select(0, txtIdCuentaCB.Text.Length)

            errorProvider1.SetIconAlignment(Me.txtIdCuentaCB, ErrorIconAlignment.MiddleRight)
            errorProvider1.SetIconPadding(Me.txtIdCuentaCB, 2)
            errorProvider1.BlinkRate = 1000
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
            errorProvider1.SetError(txtIdCuentaCB, "Cuenta Contable no existe")
        Else
            dr = ds.Tables("Catalogo").Rows(0)
            Me.txtCuentaCB.Text = dr("Descripcion")

            If Me.txtIdCuentaCB.Text.Trim = "" Then
                e.Cancel = True
                Me.txtIdCuentaCB.Select(0, txtIdCuentaCB.Text.Length)
                errorProvider1.SetIconAlignment(Me.txtIdCuentaCB, ErrorIconAlignment.MiddleRight)
                errorProvider1.SetIconPadding(Me.txtIdCuentaCB, 2)
                errorProvider1.BlinkRate = 1000
                errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
                errorProvider1.SetError(txtIdCuentaCB, "Error de Validaci�n")
            Else
                errorProvider1.SetError(Me.txtIdCuentaCB, "")
            End If
        End If
    End Sub

    Private Sub txtIdCuentaBE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCuentaBE.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim ofrm As New frmAGenerico

            ofrm.Text = "Buscar Cuenta Centro de Beneficios"
            Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
            Try
                oPerif = New wrConta.wsLibContab
                ds = oPerif.ObtenerCatBeneficio("Cod_CBeneficio,Descripcion,Comentario", "Final='S'", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0
                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                txtIdCuentaBE.Text = ofrm.Resultado.Trim
                'txtCuentaBE.Text = ofrm.Resultado2.Trim
            Catch ex As Exception
                MessageBox.Show("Error en la recuperaci�n de datos tabla Cat_Beneficios - " & "System Error: " & ex.Message.ToString() & " M�todo: " & ex.TargetSite.Name, "Error de Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub btnAceptarLin1_Click(sender As Object, e As EventArgs) Handles btnAceptarLin1.Click
        Dim dr As Data.DataRow
        Select Case Me.AccionDetalle

            Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.AgregarLinea
                dr = Me.Detalle.Tables("Det_Diario").NewRow()
                Me.Correlativo += 1
                dr(0) = Me.Correlativo
                dr(1) = txtIdCuentaCB.Text.Trim
                dr(2) = Me.cbCC.SelectedValue ' txtIdCuentaCC.Text.Trim
                dr(3) = txtIdCuentaBE.Text.Trim
                dr(4) = txtCuentaCB.Text.Trim  'Descripcion
                dr(5) = txtCargo.Text  'Cargo
                dr(6) = txtAbono.Text  'Abono
                dr(7) = txtConcepto.Text.Trim  'Concepto
                Me.Detalle.Tables("Det_Diario").Rows.Add(dr)
                Me.txtTotalCargos.Text = Decimal.Parse(Me.txtTotalCargos.Text) + Decimal.Parse(txtCargo.Text)
                Me.txtTotalAbonos.Text = Decimal.Parse(Me.txtTotalAbonos.Text) + Decimal.Parse(txtAbono.Text)
                Me.txtDif.Text = Decimal.Parse(Me.txtTotalCargos.Text) - Decimal.Parse(Me.txtTotalAbonos.Text)
                Me.Detalle.Tables("Diario").Rows(0)("Cargo") = Decimal.Parse(Me.txtTotalCargos.Text)
                Me.Detalle.Tables("Diario").Rows(0)("Abono") = Decimal.Parse(Me.txtTotalAbonos.Text)
                C1fgrdDetalle.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                C1fgrdDetalle.DataSource = Me.Detalle.Tables("Det_Diario")
                C1fgrdDetalle.Cols(0).Width = 5
                C1fgrdDetalle.Cols(1).Width = 40
                Me.LimpiarDetalle()

            Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarLinea
                dr = Me.Detalle.Tables("Det_Diario").Rows(C1fgrdDetalle.Row - 1)
                dr(1) = txtIdCuentaCB.Text.Trim
                dr(2) = cbCC.SelectedValue.ToString
                dr(3) = txtIdCuentaBE.Text.Trim
                dr(4) = txtCuentaCB.Text.Trim  'Descripcion
                dr(5) = txtCargo.Text  'Cargo
                dr(6) = txtAbono.Text  'Abono
                dr(7) = txtConcepto.Text.Trim  'Concepto
                Me.txtTotalCargos.Text = Decimal.Parse(Me.txtTotalCargos.Text) - vC + Decimal.Parse(Me.txtCargo.Text)
                Me.txtTotalAbonos.Text = Decimal.Parse(Me.txtTotalAbonos.Text) - vA + Decimal.Parse(Me.txtAbono.Text)
                Me.txtDif.Text = Decimal.Parse(Me.txtTotalCargos.Text) - Decimal.Parse(Me.txtTotalAbonos.Text)
                Me.Detalle.Tables("Diario").Rows(0)("Cargo") = Decimal.Parse(Me.txtTotalCargos.Text)
                Me.Detalle.Tables("Diario").Rows(0)("Abono") = Decimal.Parse(Me.txtTotalAbonos.Text)
                C1fgrdDetalle.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                Me.Detalle.AcceptChanges()
                C1fgrdDetalle.DataSource = Me.Detalle.Tables("Det_Diario")
                C1fgrdDetalle.Cols(0).Width = 5
                C1fgrdDetalle.Cols(1).Width = 40
                Me.LimpiarDetalle()
        End Select

        Me.AccionDetalle = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.Ninguna

        Me.C1fgrdDetalle.Enabled = True
    End Sub

    Private Sub btnCancelarLin1_Click(sender As Object, e As EventArgs) Handles btnCancelarLin1.Click
        isHabilitar = False
        Me.LimpiarDetalle()
        Me.C1fgrdDetalle.Enabled = True
    End Sub

    Private Sub btnInsertarLin_Click(sender As Object, e As EventArgs) Handles btnInsertarLin.Click
        Me.LimpiarDetalle()
        Me.AccionDetalle = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.AgregarLinea
        Me.txtIdCuentaCB.Focus()
    End Sub

    Private Sub btnModificarLin_Click(sender As Object, e As EventArgs) Handles btnModificarLin.Click
        If txtIdCuentaCB.Text.Trim() <> "" Then
            vC = Me.txtCargo.Text
            vA = Me.txtAbono.Text
            Me.AccionDetalle = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarLinea
        End If
    End Sub

    Private Sub btnEliminarLin_Click(sender As Object, e As EventArgs) Handles btnEliminarLin.Click
        If txtIdCuentaCB.Text.Trim() = "" Then
            MessageBox.Show("Debe seleccionar una cuenta a eliminar en la secci�n de detalle de la partida", "Error de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
        Else
            Try
                If MessageBox.Show("�Desea eliminar la l�nea seleccionada?", "Eliminar L�nea", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.Detalle.Tables("Det_Diario").Rows(C1fgrdDetalle.Row - 1).Delete()
                    Me.txtTotalCargos.Text = Decimal.Parse(Me.txtTotalCargos.Text) - Decimal.Parse(Me.txtCargo.Text)
                    Me.txtTotalAbonos.Text = Decimal.Parse(Me.txtTotalAbonos.Text) - Decimal.Parse(Me.txtAbono.Text)
                    Me.txtDif.Text = Decimal.Parse(Me.txtTotalCargos.Text) - Decimal.Parse(Me.txtTotalAbonos.Text)
                    Me.Detalle.Tables("Diario").Rows(0)("Cargo") = Decimal.Parse(Me.txtTotalCargos.Text)
                    Me.Detalle.Tables("Diario").Rows(0)("Abono") = Decimal.Parse(Me.txtTotalAbonos.Text)
                    C1fgrdDetalle.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                    Me.Detalle.AcceptChanges()
                    C1fgrdDetalle.DataSource = Me.Detalle.Tables("Det_Diario")
                    C1fgrdDetalle.Cols(0).Width = 5
                    C1fgrdDetalle.Cols(1).Width = 40
                    Me.LimpiarDetalle()
                    Me.C1fgrdDetalle.Enabled = True
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnCargarPl1_Click(sender As Object, e As EventArgs) Handles btnCargarPl1.Click

        Try
            Dim dt As New DataTable("detalle")
            Dim dtsPartida As New DataSet
            Dim cc As String
            Dim cb As String
            Dim dtsCatConta As New DataSet
            Dim i As Integer = 1
            Dim dr As DataRow
            Dim correlativo As New DataColumn("correlativo")
            correlativo.DataType = GetType(Integer)
            dtsPartida.Tables.Add(dt)
            Me.OpenFileDialog1.InitialDirectory = "C:"
            Me.OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            Me.OpenFileDialog1.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx||"
            If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ObjDataset = ImportarPartidaExcel(Me.OpenFileDialog1.FileName)
                If ObjDataset.Tables.Count > 0 Then
                    If ObjDataset.Tables(0).Rows.Count > 0 Then
                        For Each row As DataRow In ObjDataset.Tables(0).Rows
                            dr = Me.Detalle.Tables("Det_Diario").NewRow()
                            'dr = dtsPartida.Tables(0).NewRow
                            If IsDBNull(row(0)) = False Then

                                If IIf(IsDBNull(row(1)) = True, 0, row(1)) > 0 Or IIf(IsDBNull(row(2)) = True, 0, row(2)) > 0 Then
                                    dr(0) = i
                                    dr(1) = row(0)
                                    dtsCatConta = contabilidad.ObtenerCatContab("Descripcion,cod_Ccosto", "idCuenta = '" & row(0).ToString.Trim & "'", "idcuenta", sUsuario, sPassword, sSucursal)
                                    If dtsCatConta.Tables.Count > 0 Then
                                        If dtsCatConta.Tables(0).Rows.Count > 0 Then
                                            dr(2) = dtsCatConta.Tables(0).Rows(0).Item("Cod_CCosto").ToString
                                            dr(3) = dtsCatConta.Tables(0).Rows(0).Item("Cod_CCosto").ToString
                                            dr(4) = dtsCatConta.Tables(0).Rows(0).Item("Descripcion").ToString
                                        Else
                                            MsgBox("La cuenta:" & row(0).ToString.Trim & ". No pertenece al c�talogo", MsgBoxStyle.Critical, "M�dulo de Contabilidad")
                                            Exit Sub
                                        End If
                                    End If
                                    dr(5) = IIf(IsDBNull(row(1)) = True, 0, row(1)) 'row(1) 'cargo
                                    dr(6) = IIf(IsDBNull(row(2)) = True, 0, row(2)) 'row(2) ' abono
                                    dr(7) = row(3) 'concepto
                                    Me.txtTotalCargos.Text = CDbl((txtTotalCargos.Text + row(1)))
                                    Me.txtTotalAbonos.Text = CDbl((txtTotalAbonos.Text + row(2)))
                                    Me.txtDif.Text = Math.Round(Me.txtTotalCargos.Text - Me.txtTotalAbonos.Text, 2)
                                    Me.Detalle.Tables("Det_Diario").Rows.Add(dr)

                                    i = i + 1

                                End If

                            End If


                        Next
                        Me.txtTotalAbonos.Text = Math.Round(CDbl(txtTotalAbonos.Text), 2)
                        Me.txtTotalCargos.Text = Math.Round(CDbl(txtTotalCargos.Text), 2)
                        C1fgrdDetalle.DataSource = Me.Detalle.Tables("Det_Diario") 'dtsPartida.Tables(0)
                        C1fgrdDetalle.Cols(0).Width = 5
                        C1fgrdDetalle.Cols(1).Width = 40
                        Me.LimpiarDetalle()
                    End If
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Origen del Error: " & ex.Source & " --- Mensaje de Error: " & ex.Message, "Error Capturado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnGuardarPl1_Click(sender As Object, e As EventArgs) Handles btnGuardarPl1.Click
        Dim saveFileDialog1 As New SaveFileDialog, dr As DataRow
        Try
            saveFileDialog1.InitialDirectory = "c:"
            saveFileDialog1.Filter = "Archivos xml (*.xml)|*.xml"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            saveFileDialog1.ShowDialog()
            If saveFileDialog1.FileName.Trim <> "" Then
                dr = Me.Detalle.Tables("Diario").Rows(0)
                dr("Fecha") = dtpFecha.Value
                dr("Descripcion") = Me.txtDescripcion.Text.Trim
                dr("Tipo_Partida") = "M"
                dr("Cargo") = Decimal.Parse(Me.txtTotalCargos.Text)
                dr("Abono") = Decimal.Parse(Me.txtTotalAbonos.Text)
                dr("Autorizado") = "0"
                dr("Usu_Digita") = sUsuario
                dr("Usu_Autoriza") = ""
                dr("Fec_Autoriza") = DateTime.Now.Date
                dr("IdEstado") = "D"
                dr("Prefijo") = Me.cmbTipoPartidas.Text.Trim.Substring(0, 2)
                If Me.chkInicial.Checked = True Then
                    dr("Inicial") = "1"
                Else
                    dr("Inicial") = "0"
                End If
                dr("Annio") = Date.Now.Year
                Me.Detalle.Tables("Det_Diario").AcceptChanges()
                MessageBox.Show("La plantilla se guardar� en: " & saveFileDialog1.FileName, "Guardar plantilla", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Detalle.WriteXml(saveFileDialog1.FileName)
            Else
                MessageBox.Show("Operaci�n Cancelada", "Guardar plantilla", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show("Origen del Error: " & ex.Source & " --- Mensaje de Error: " & ex.Message, "Error Capturado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oPartida As New wrConta.wsLibContab, dr As System.Data.DataRow
        Try
            Select Case Me.Accion
                Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.AgregarPartida
                    If Me.cmbTipoPartidas.Text.Trim = "" Then
                        MessageBox.Show("El tipo de Partida no puede quedar vac�o", "Error de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                    dr = Me.Detalle.Tables("Diario").Rows(0)
                    dr("Fecha") = dtpFecha.Value
                    dr("Descripcion") = Me.txtDescripcion.Text.Trim
                    dr("Tipo_Partida") = "M"
                    dr("Cargo") = Decimal.Parse(Me.txtTotalCargos.Text)
                    dr("Abono") = Decimal.Parse(Me.txtTotalAbonos.Text)
                    dr("Autorizado") = "0"
                    dr("Usu_Digita") = sUsuario
                    dr("Usu_Autoriza") = ""
                    dr("Fec_Autoriza") = DateTime.Now.Date
                    dr("Id_Estado") = "D"
                    dr("Prefijo") = Me.cmbTipoPartidas.Text.Trim.Substring(0, 2)
                    If Me.chkInicial.Checked = True Then
                        dr("Inicial") = "1"
                    Else
                        dr("Inicial") = "0"
                    End If
                    dr("Annio") = Date.Now.Year
                    Me.txtNumero.Text = oPartida.InsertaPartidaAut(sUsuario, sPassword, sSucursal, Me.Detalle)
                    If Me.txtNumero.Text.Trim <> "" Or Me.txtNumero.Text.Trim <> "Error" Then
                        MessageBox.Show(Me.txtNumero.Text, "Partida Guardada")
                        Me.Close()
                    End If
                Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarPartida
                    dr = Me.Detalle.Tables("Diario").Rows(0)
                    dr("Num_Partida") = Me.txtNumero.Text
                    dr("Fecha") = dtpFecha.Value
                    dr("Descripcion") = Me.txtDescripcion.Text.Trim
                    dr("Tipo_Partida") = "M"
                    dr("Cargo") = Decimal.Parse(Me.txtTotalCargos.Text)
                    dr("Abono") = Decimal.Parse(Me.txtTotalAbonos.Text)
                    dr("Autorizado") = "0"
                    dr("Usu_Digita") = sUsuario
                    dr("Usu_Autoriza") = ""
                    dr("Fec_Autoriza") = DateTime.Now.Date
                    'dr("Id_Estado") = "D"
                    dr("Prefijo") = Me.cmbTipoPartidas.Text.Trim.Substring(0, 2)
                    If Me.chkInicial.Checked = True Then
                        dr("Inicial") = "1"
                    Else
                        dr("Inicial") = "0"
                    End If
                    dr("Annio") = Date.Now.Year
                    If oPartida.ModificaPartidaAut(sUsuario, sPassword, sSucursal, Me.Detalle) Then
                        MessageBox.Show("Partida Modificada")
                        Me.Close()
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show("Origen del Error: " & ex.Source & " --- Mensaje de Error: " & ex.Message, "Error Capturado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub C1fgrdDetalle_Click(sender As Object, e As EventArgs) Handles C1fgrdDetalle.Click
        Dim x As Integer, dr As DataRow
        Dim oPartida As New wrConta.wsLibContab
        Dim drCuenta As Data.DataRow
        Try
            If isHabilitar = False Then
                x = C1fgrdDetalle.Row
                deshabilitarDetPartida(True)
                dr = Me.Detalle.Tables("Det_Diario").Rows(x - 1)
                txtIdCuentaCB.Text = dr("IdCuenta").trim
                drCuenta = oPartida.ObtenerCatContab("IdCuenta,Descripcion", "idCuenta='" & dr("IdCuenta") & "'", "idCuenta", sUsuario, sPassword, sSucursal).Tables(0).Rows(0)
                txtCuentaCB.Text = drCuenta("Descripcion").trim
                Me.cbCC.SelectedValue = dr("CodCosto").trim
                txtIdCuentaBE.Text = dr("CodBeneficio").trim
                txtCargo.Value = dr("Cargo")
                txtAbono.Value = dr("Abono")
                txtConcepto.Text = dr("Concepto")
                C1fgrdDetalle.Enabled = False
            End If
        Catch ex As Exception
            Debug.Write(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar1_Click(sender As Object, e As EventArgs) Handles btnCancelar1.Click
        Me.Close()
    End Sub

    Private Sub txtIdCuentaCB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCuentaCB.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim ofrm As New frmAGenerico
            ofrm.Text = "Buscar Cuenta Contable"
            Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
            Try
                oPerif = New wrConta.wsLibContab
                ds = oPerif.ObtenerCatContab("*", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0
                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                txtIdCuentaCB.Text = ofrm.Resultado.Trim
                txtCuentaCB.Text = ofrm.Resultado2.Trim
            Catch ex As Exception
                MessageBox.Show("Error en la recuperaci�n de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " M�todo: " & ex.TargetSite.Name, "Error de Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
    Private Sub llenarCC()
        Dim dts As New DataSet
        Me.cbCC.DisplayMember = "Descripcion"
        Me.cbCC.ValueMember = "Cod_CCosto"
        dts = contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion", " Final='S' ", "Cod_CCosto", sUsuario, sPassword, sSucursal)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbCC.DataSource = dts.Tables(0)
        End If
    End Sub

End Class