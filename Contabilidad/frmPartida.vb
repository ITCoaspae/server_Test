Imports System.Globalization
Imports System.Threading

Public Class frmPartida
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form : 
    Public rsc As System.Resources.ResourceManager
    'Private vAccion As AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas
    Private vAccion As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas
    'Private vAccionDetalle As AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas
    Private vAccionDetalle As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas
    Private vdsDetalle As System.Data.DataSet, vCorrel As Integer
    Private vC As Decimal, vA As Decimal
    Private errorProvider1 As System.Windows.Forms.ErrorProvider = New System.Windows.Forms.ErrorProvider
    Private vIdModifica As String
    Private vPref As String
    'Private vTipo As AlcalaLibs.Contabilidad.clsPartida.TipoPartidaModulo
    Private vTipo As sifLib.Contabilidad.clsPartidas.TipoPartidaModulo
    Private pdrNueva As System.Data.DataRow
    Dim usuarios As New wrAdmin.wsLibAdmin
    Dim bancos As New wrBancos.wsLibBancos
    Dim Seguridad As New wrAdmin.wsLibAdmin
    Friend WithEvents C1fgrdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Dim contabilidad As New wrConta.wsLibContab
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Dim isHabilitar As Boolean
    Friend WithEvents btnAceptarLin1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelarLin1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnInsertarLin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificarLin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminarLin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCargarPl1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarPl1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtCentroCosto As TextBox
    Friend WithEvents Label10 As Label
    Dim consultarTodoCat As Boolean



#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)
        Me.Correlativo = 0
        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-SV")
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIdCuentaCB As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaCB As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoPartidas As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtIdCuentaBE As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuentaCC As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAbonos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCargos As System.Windows.Forms.TextBox
    Friend WithEvents chkInicial As System.Windows.Forms.CheckBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtAbono As C1.Win.C1Input.C1TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDif As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartida))
        Me.txtIdCuentaBE = New System.Windows.Forms.TextBox()
        Me.C1fgrdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtAbono = New C1.Win.C1Input.C1TextBox()
        Me.txtDif = New System.Windows.Forms.TextBox()
        Me.txtIdCuentaCC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalAbonos = New System.Windows.Forms.TextBox()
        Me.txtTotalCargos = New System.Windows.Forms.TextBox()
        Me.txtCargo = New C1.Win.C1Input.C1TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkInicial = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbTipoPartidas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdCuentaCB = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCuentaCB = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAceptarLin1 = New MetroFramework.Controls.MetroButton()
        Me.btnCancelarLin1 = New MetroFramework.Controls.MetroButton()
        Me.btnInsertarLin = New MetroFramework.Controls.MetroButton()
        Me.btnModificarLin = New MetroFramework.Controls.MetroButton()
        Me.btnEliminarLin = New MetroFramework.Controls.MetroButton()
        Me.btnCargarPl1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarPl1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar1 = New MetroFramework.Controls.MetroButton()
        Me.txtCentroCosto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdCuentaBE
        '
        Me.txtIdCuentaBE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIdCuentaBE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCuentaBE.Enabled = False
        Me.txtIdCuentaBE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCuentaBE.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtIdCuentaBE.Location = New System.Drawing.Point(484, 353)
        Me.txtIdCuentaBE.Name = "txtIdCuentaBE"
        Me.txtIdCuentaBE.Size = New System.Drawing.Size(12, 25)
        Me.txtIdCuentaBE.TabIndex = 32
        Me.txtIdCuentaBE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIdCuentaBE.Visible = False
        '
        'C1fgrdDetalle
        '
        Me.C1fgrdDetalle.AllowEditing = False
        Me.C1fgrdDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdDetalle.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdDetalle.BackColor = System.Drawing.Color.White
        Me.C1fgrdDetalle.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1fgrdDetalle.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdDetalle.Location = New System.Drawing.Point(31, 399)
        Me.C1fgrdDetalle.Name = "C1fgrdDetalle"
        Me.C1fgrdDetalle.Rows.DefaultSize = 21
        Me.C1fgrdDetalle.Size = New System.Drawing.Size(899, 177)
        Me.C1fgrdDetalle.StyleInfo = resources.GetString("C1fgrdDetalle.StyleInfo")
        Me.C1fgrdDetalle.TabIndex = 35
        '
        'txtAbono
        '
        Me.txtAbono.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAbono.BackColor = System.Drawing.Color.White
        Me.txtAbono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbono.DataType = GetType(Decimal)
        Me.txtAbono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAbono.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAbono.Location = New System.Drawing.Point(323, 361)
        Me.txtAbono.MaskInfo.ShowLiterals = C1.Win.C1Input.ShowLiteralsEnum.WhenNextStarted
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtAbono.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtAbono.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtAbono.Size = New System.Drawing.Size(153, 27)
        Me.txtAbono.TabIndex = 31
        Me.txtAbono.Tag = Nothing
        Me.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAbono.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDif
        '
        Me.txtDif.BackColor = System.Drawing.Color.White
        Me.txtDif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDif.Enabled = False
        Me.txtDif.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDif.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDif.Location = New System.Drawing.Point(118, 171)
        Me.txtDif.Name = "txtDif"
        Me.txtDif.Size = New System.Drawing.Size(134, 25)
        Me.txtDif.TabIndex = 9
        Me.txtDif.Text = "0"
        Me.txtDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIdCuentaCC
        '
        Me.txtIdCuentaCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIdCuentaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCuentaCC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCuentaCC.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtIdCuentaCC.Location = New System.Drawing.Point(107, 265)
        Me.txtIdCuentaCC.Name = "txtIdCuentaCC"
        Me.txtIdCuentaCC.Size = New System.Drawing.Size(233, 25)
        Me.txtIdCuentaCC.TabIndex = 24
        Me.txtIdCuentaCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(28, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 18)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Diferencia"
        '
        'txtTotalAbonos
        '
        Me.txtTotalAbonos.BackColor = System.Drawing.Color.White
        Me.txtTotalAbonos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAbonos.Enabled = False
        Me.txtTotalAbonos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAbonos.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTotalAbonos.Location = New System.Drawing.Point(607, 171)
        Me.txtTotalAbonos.Name = "txtTotalAbonos"
        Me.txtTotalAbonos.Size = New System.Drawing.Size(154, 25)
        Me.txtTotalAbonos.TabIndex = 13
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
        Me.txtTotalCargos.Location = New System.Drawing.Point(353, 171)
        Me.txtTotalCargos.Name = "txtTotalCargos"
        Me.txtTotalCargos.Size = New System.Drawing.Size(153, 25)
        Me.txtTotalCargos.TabIndex = 11
        Me.txtTotalCargos.Text = "0"
        Me.txtTotalCargos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCargo
        '
        Me.txtCargo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCargo.BackColor = System.Drawing.Color.White
        Me.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargo.DataType = GetType(Decimal)
        Me.txtCargo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtCargo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCargo.Location = New System.Drawing.Point(107, 361)
        Me.txtCargo.MaskInfo.ShowLiterals = C1.Win.C1Input.ShowLiteralsEnum.WhenNextStarted
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtCargo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtCargo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtCargo.Size = New System.Drawing.Size(153, 27)
        Me.txtCargo.TabIndex = 29
        Me.txtCargo.Tag = Nothing
        Me.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCargo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(514, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total Abonos"
        '
        'chkInicial
        '
        Me.chkInicial.Location = New System.Drawing.Point(820, 173)
        Me.chkInicial.Name = "chkInicial"
        Me.chkInicial.Size = New System.Drawing.Size(106, 19)
        Me.chkInicial.TabIndex = 14
        Me.chkInicial.Text = "Partida Inicial"
        Me.chkInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(259, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Cargos"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.Location = New System.Drawing.Point(268, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Abono"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(28, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción"
        '
        'txtConcepto
        '
        Me.txtConcepto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtConcepto.BackColor = System.Drawing.Color.White
        Me.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConcepto.Location = New System.Drawing.Point(107, 305)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConcepto.Size = New System.Drawing.Size(819, 41)
        Me.txtConcepto.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.Location = New System.Drawing.Point(24, 307)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 18)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Concepto"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 110)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(808, 54)
        Me.txtDescripcion.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.Location = New System.Drawing.Point(28, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Cargo"
        '
        'cmbTipoPartidas
        '
        Me.cmbTipoPartidas.BackColor = System.Drawing.Color.White
        Me.cmbTipoPartidas.Location = New System.Drawing.Point(593, 78)
        Me.cmbTipoPartidas.Name = "cmbTipoPartidas"
        Me.cmbTipoPartidas.Size = New System.Drawing.Size(333, 24)
        Me.cmbTipoPartidas.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(530, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 34)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Partida"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.Location = New System.Drawing.Point(24, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 36)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Cuenta " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contable"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(336, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha"
        '
        'txtIdCuentaCB
        '
        Me.txtIdCuentaCB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtIdCuentaCB.BackColor = System.Drawing.Color.White
        Me.txtIdCuentaCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCuentaCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCuentaCB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtIdCuentaCB.Location = New System.Drawing.Point(107, 242)
        Me.txtIdCuentaCB.Name = "txtIdCuentaCB"
        Me.txtIdCuentaCB.Size = New System.Drawing.Size(233, 25)
        Me.txtIdCuentaCB.TabIndex = 21
        Me.txtIdCuentaCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFecha
        '
        Me.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(390, 78)
        Me.dtpFecha.MinDate = New Date(1945, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(115, 22)
        Me.dtpFecha.TabIndex = 3
        '
        'txtCuentaCB
        '
        Me.txtCuentaCB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCuentaCB.BackColor = System.Drawing.Color.White
        Me.txtCuentaCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaCB.Enabled = False
        Me.txtCuentaCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaCB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCuentaCB.Location = New System.Drawing.Point(347, 242)
        Me.txtCuentaCB.Name = "txtCuentaCB"
        Me.txtCuentaCB.ReadOnly = True
        Me.txtCuentaCB.Size = New System.Drawing.Size(579, 25)
        Me.txtCuentaCB.TabIndex = 22
        Me.txtCuentaCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNumero.Location = New System.Drawing.Point(118, 78)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(211, 25)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Partida"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAceptarLin1
        '
        Me.btnAceptarLin1.Location = New System.Drawing.Point(677, 360)
        Me.btnAceptarLin1.Name = "btnAceptarLin1"
        Me.btnAceptarLin1.Size = New System.Drawing.Size(121, 32)
        Me.btnAceptarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptarLin1.TabIndex = 33
        Me.btnAceptarLin1.Text = "Aceptar"
        Me.btnAceptarLin1.UseSelectable = True
        Me.btnAceptarLin1.UseStyleColors = True
        '
        'btnCancelarLin1
        '
        Me.btnCancelarLin1.Location = New System.Drawing.Point(805, 360)
        Me.btnCancelarLin1.Name = "btnCancelarLin1"
        Me.btnCancelarLin1.Size = New System.Drawing.Size(121, 32)
        Me.btnCancelarLin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCancelarLin1.TabIndex = 34
        Me.btnCancelarLin1.Text = "Cancelar"
        Me.btnCancelarLin1.UseSelectable = True
        Me.btnCancelarLin1.UseStyleColors = True
        '
        'btnInsertarLin
        '
        Me.btnInsertarLin.Location = New System.Drawing.Point(28, 202)
        Me.btnInsertarLin.Name = "btnInsertarLin"
        Me.btnInsertarLin.Size = New System.Drawing.Size(134, 32)
        Me.btnInsertarLin.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnInsertarLin.TabIndex = 15
        Me.btnInsertarLin.Text = "Insertar Linea"
        Me.btnInsertarLin.UseSelectable = True
        Me.btnInsertarLin.UseStyleColors = True
        '
        'btnModificarLin
        '
        Me.btnModificarLin.Location = New System.Drawing.Point(169, 202)
        Me.btnModificarLin.Name = "btnModificarLin"
        Me.btnModificarLin.Size = New System.Drawing.Size(135, 32)
        Me.btnModificarLin.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificarLin.TabIndex = 16
        Me.btnModificarLin.Text = "Modificar Linea"
        Me.btnModificarLin.UseSelectable = True
        Me.btnModificarLin.UseStyleColors = True
        '
        'btnEliminarLin
        '
        Me.btnEliminarLin.Location = New System.Drawing.Point(311, 202)
        Me.btnEliminarLin.Name = "btnEliminarLin"
        Me.btnEliminarLin.Size = New System.Drawing.Size(134, 32)
        Me.btnEliminarLin.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminarLin.TabIndex = 17
        Me.btnEliminarLin.Text = "Eliminar Linea"
        Me.btnEliminarLin.UseSelectable = True
        Me.btnEliminarLin.UseStyleColors = True
        '
        'btnCargarPl1
        '
        Me.btnCargarPl1.Location = New System.Drawing.Point(452, 202)
        Me.btnCargarPl1.Name = "btnCargarPl1"
        Me.btnCargarPl1.Size = New System.Drawing.Size(135, 32)
        Me.btnCargarPl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCargarPl1.TabIndex = 18
        Me.btnCargarPl1.Text = "Cargar Plantilla"
        Me.btnCargarPl1.UseSelectable = True
        Me.btnCargarPl1.UseStyleColors = True
        '
        'btnGuardarPl1
        '
        Me.btnGuardarPl1.Location = New System.Drawing.Point(594, 202)
        Me.btnGuardarPl1.Name = "btnGuardarPl1"
        Me.btnGuardarPl1.Size = New System.Drawing.Size(134, 32)
        Me.btnGuardarPl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardarPl1.TabIndex = 19
        Me.btnGuardarPl1.Text = "Guardar Plantilla"
        Me.btnGuardarPl1.UseSelectable = True
        Me.btnGuardarPl1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(654, 583)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(134, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 36
        Me.btnGuardar1.Text = "Guardar Partida"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnCancelar1
        '
        Me.btnCancelar1.Location = New System.Drawing.Point(796, 583)
        Me.btnCancelar1.Name = "btnCancelar1"
        Me.btnCancelar1.Size = New System.Drawing.Size(134, 32)
        Me.btnCancelar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCancelar1.TabIndex = 37
        Me.btnCancelar1.Text = "Cancelar"
        Me.btnCancelar1.UseSelectable = True
        Me.btnCancelar1.UseStyleColors = True
        '
        'txtCentroCosto
        '
        Me.txtCentroCosto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCentroCosto.BackColor = System.Drawing.Color.White
        Me.txtCentroCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCentroCosto.Enabled = False
        Me.txtCentroCosto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentroCosto.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCentroCosto.Location = New System.Drawing.Point(347, 273)
        Me.txtCentroCosto.Name = "txtCentroCosto"
        Me.txtCentroCosto.ReadOnly = True
        Me.txtCentroCosto.Size = New System.Drawing.Size(579, 25)
        Me.txtCentroCosto.TabIndex = 25
        Me.txtCentroCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.Location = New System.Drawing.Point(24, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 29)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Centro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Costo:"
        '
        'frmPartida
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(958, 650)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCentroCosto)
        Me.Controls.Add(Me.btnCancelar1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btnGuardarPl1)
        Me.Controls.Add(Me.btnCargarPl1)
        Me.Controls.Add(Me.btnEliminarLin)
        Me.Controls.Add(Me.btnModificarLin)
        Me.Controls.Add(Me.btnInsertarLin)
        Me.Controls.Add(Me.btnCancelarLin1)
        Me.Controls.Add(Me.btnAceptarLin1)
        Me.Controls.Add(Me.txtIdCuentaBE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.C1fgrdDetalle)
        Me.Controls.Add(Me.txtIdCuentaCC)
        Me.Controls.Add(Me.txtAbono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtDif)
        Me.Controls.Add(Me.txtTotalAbonos)
        Me.Controls.Add(Me.cmbTipoPartidas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkInicial)
        Me.Controls.Add(Me.txtTotalCargos)
        Me.Controls.Add(Me.txtCuentaCB)
        Me.Controls.Add(Me.txtIdCuentaCB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(958, 650)
        Me.Name = "frmPartida"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Partida Contable"
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).EndInit()
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

    'Public Property Accion() As AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas
    Public Property Accion() As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas
        Get
            Return vAccion
        End Get
        'Set(ByVal Value As AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas)
        Set(ByVal Value As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas)
            vAccion = Value
        End Set
    End Property

    'Public Property AccionDetalle() As AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas
    Public Property AccionDetalle() As sifLib.Contabilidad.clsPartidas.TipoAccionPartidas
        Get
            Return vAccionDetalle
        End Get
        'Set(ByVal Value As AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas)
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

    'Public Property Tipo() As AlcalaLibs.Contabilidad.clsPartida.TipoPartidaModulo
    Public Property Tipo() As sifLib.Contabilidad.clsPartidas.TipoPartidaModulo
        Get
            Return vTipo
        End Get
        'Set(ByVal Value As AlcalaLibs.Contabilidad.clsPartida.TipoPartidaModulo)
        Set(ByVal Value As sifLib.Contabilidad.clsPartidas.TipoPartidaModulo)
            vTipo = Value
        End Set
    End Property

#End Region

#Region "Nuevas Funciones"
    Protected Function mostrarCatalogoContable() As DataSet
        Dim dts As New DataSet
        Dim codRol As String
        Dim dtsUsuriosRol As New DataSet
        dtsUsuriosRol = usuarios.ConsultarUsuarioxRol("a.codrol,a.usuario", " a.usuario = '" & sUsuario & "'", "a.codrol", sUsuario, sPassword, sSucursal)
        If dtsUsuriosRol.Tables.Count > 0 Then
            If dtsUsuriosRol.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To dtsUsuriosRol.Tables(0).Rows.Count - 1
                    dts = bancos.ConsultarBcCatCtasContablesCheques(sSucursal, dtsUsuriosRol.Tables(0).Rows(i).Item("codrol").ToString, 4)
                    If dts.Tables.Count > 0 Then
                        If dts.Tables(0).Rows.Count > 0 Then
                            Return dts
                            Exit For
                        End If
                    End If
                Next
            End If
        End If
    End Function
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
        Else
            txtIdCuentaCB.Enabled = False
            txtCuentaCB.Enabled = False
            txtConcepto.Enabled = False
            txtCargo.Enabled = False
            txtAbono.Enabled = False
            btnAceptarLin1.Enabled = False
            btnCancelarLin1.Enabled = False
        End If

    End Sub
#End Region
    Protected Sub validarCatalogoContable()
        Dim dtsRol As New DataSet
        dtsRol = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
        For i As Integer = 0 To dtsRol.Tables(0).Rows.Count - 1
            If Seguridad.ConsultarPermisoProcesos("CTD014", dtsRol.Tables(0).Rows(i).Item("CodRol").ToString.Trim, 4) Then
                consultarTodoCat = True
                Exit For
                Exit Sub
            Else
                consultarTodoCat = False
            End If
        Next
    End Sub

    Private Sub frmPartida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        validarCatalogoContable()
        Dim oPartida As New wrConta.wsLibContab
        Dim dsTipo As New DataSet, dr As DataRow, x As Integer
        deshabilitarDetPartida(False)
        'If Me.Tipo = AlcalaLibs.Contabilidad.clsPartida.TipoPartidaModulo.Bancos Then
        If Me.Tipo = sifLib.Contabilidad.clsPartidas.TipoPartidaModulo.Bancos Then
            dsTipo = oPartida.ObtenerTipoPartidasBC(sAnnio, sUsuario, sPassword, sSucursal)
            For Each dr In dsTipo.Tables("Tipo_Partidas").Rows
                If Trim(dr("Prefijo")) = "EG" Then
                    cmbTipoPartidas.Items.Add(CStr(dr("Prefijo")) & " - " & CStr(dr("Descripcion")))
                    cmbTipoPartidas.SelectedIndex = 0
                End If
            Next
            Me.dtpFecha.Enabled = False
        Else
            Dim s As Integer, g As Integer
            dsTipo = oPartida.ObtenerTipoPartidas(sAnnio, sUsuario, sPassword, sSucursal)
            s = 0
            For Each dr In dsTipo.Tables(0).Rows
                cmbTipoPartidas.Items.Add(CStr(dr("Prefijo")) & " - " & CStr(dr("Descripcion")))
                If Me.Prefijo.Trim = Trim(CStr(dr("Prefijo"))) Then g = s
                s = s + 1
            Next
            'Me.cmbTipoPartidas.SelectedIndex = g
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
        End If
        Select Case Me.Accion
            'Case Is = AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas.AgregarPartida
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
            'Case Is = AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas.ModificarPartida
            Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarPartida
                If Me.Tipo = sifLib.Contabilidad.clsPartidas.TipoPartidaModulo.Bancos Then
                    Me.Detalle = oPartida.CargaPartidaModulo(Me.IdModifica, sUsuario, sSucursal, sPassword, Me.Tipo)
                ElseIf Me.Tipo = sifLib.Contabilidad.clsPartidas.TipoPartidaModulo.Contabilidad Then
                    Me.Detalle = oPartida.CargaPartida(Me.IdModifica, sUsuario, sPassword, sSucursal)
                End If

                C1fgrdDetalle.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                C1fgrdDetalle.DataSource = Me.Detalle.Tables("Det_Diario")
                Me.txtNumero.Text = Trim(Me.Detalle.Tables("Diario").Rows(0)("Num_Partida"))
                Me.txtDescripcion.Text = Me.Detalle.Tables("Diario").Rows(0)("Descripcion")
                Me.dtpFecha.Value = Me.Detalle.Tables("Diario").Rows(0)("Fecha")
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtIdCuentaCB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuentaCB.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            'ds = mostrarCatalogoContable()
            If consultarTodoCat = True Then
                ds = oPerif.ObtenerCatContab("IdCuenta,Descripcion,Cod_CCosto",
                                             " Inhabilitado = 'N' ",
                                             "IdCuenta", sUsuario, sPassword, sSucursal)
            Else
                ds = oPerif.ObtenerCatContab("IdCuenta,Descripcion,Cod_CCosto",
                                           "  Inhabilitado = 'N' ",
                                           "IdCuenta", sUsuario, sPassword, sSucursal)
            End If
            'ds = oPerif.ObtenerCatContab("idCuenta,Descripcion,Cod_CCosto", "Final='S' and (cod_CCosto = '" & CentroCostoSucursal & "' or cuentaComun = '1') ", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtIdCuentaCB.Text = ofrm.Resultado.Trim
            txtCuentaCB.Text = ofrm.Resultado2.Trim
            txtIdCuentaCC.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtIdCuentaCC_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuentaCC.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Centro de Costos"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion,Comentario", "Final='S'", "Cod_CCosto", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtIdCuentaCC.Text = ofrm.Resultado.Trim
            txtCentroCosto.Text = ofrm.Resultado2.Trim
            ' txtCuentaCC.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cat_Costos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtIdCuentaBE_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
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
            'txtIdCuentaBE.Text = ofrm.Resultado.Trim
            'txtCuentaBE.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cat_Beneficios - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarDetalle()
        Me.txtIdCuentaCB.Text = ""
        Me.txtIdCuentaCC.Text = ""
        'Me.txtIdCuentaBE.Text = ""
        Me.txtCuentaCB.Text = ""
        'Me.txtCuentaCC.Text = ""
        'Me.txtCuentaBE.Text = ""
        Me.txtCargo.Value = 0
        Me.txtAbono.Value = 0
        'Me.txtConcepto.Text = ""
    End Sub

    Private Sub C1fgrdDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1fgrdDetalle.DoubleClick
        Dim x As Integer, dr As System.Data.DataRow
        Dim oPartida As New wrConta.wsLibContab
        Dim drCuenta As Data.DataRow
        Try

            'If GroupBox3.Enabled = False Then
            If isHabilitar = False Then
                x = C1fgrdDetalle.Row
                deshabilitarDetPartida(True)
                'GroupBox3.Enabled = True
                dr = Me.Detalle.Tables("Det_Diario").Rows(x - 1)
                txtIdCuentaCB.Text = dr("IdCuenta").trim
                drCuenta = oPartida.ObtenerCatContab("IdCuenta,Descripcion", "idCuenta='" & dr("IdCuenta") & "'", "idCuenta", sUsuario, sPassword, sSucursal).Tables(0).Rows(0)
                txtCuentaCB.Text = drCuenta("Descripcion").trim
                '********************
                txtIdCuentaCC.Text = dr("CodCosto").trim
                'If txtIdCuentaCC.Text.Length <> 0 Then
                '    drCuenta = oPartida.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion", "Cod_CCosto='" & dr("CodCosto") & "'", "Cod_CCosto", sUsuario, sPassword, sSucursal).Tables(0).Rows(0)
                '    'txtCuentaCC.Text = drCuenta("Descripcion").trim
                'End If
                '********************
                'txtIdCuentaBE.Text = dr("CodBeneficio").trim
                'If txtIdCuentaBE.Text.Length <> 0 Then
                '    drCuenta = oPartida.ObtenerCatBeneficio("Cod_CBeneficio,Descripcion", "Cod_CBeneficio='" & dr("CodBeneficio") & "'", "Cod_CBeneficio", sUsuario, sPassword, sSucursal).Tables(0).Rows(0)
                '    txtCuentaBE.Text = drCuenta("Descripcion")
                'End If
                txtCargo.Value = dr("Cargo")
                txtAbono.Value = dr("Abono")
                txtConcepto.Text = dr("Concepto")
                deshabilitarDetPartida(False)
                'GroupBox3.Enabled = False
                deshabilitarDetPartida(False)
                C1fgrdDetalle.Enabled = False
            End If
        Catch ex As Exception
            Debug.Write(ex.Message)
        End Try

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
    Dim ObjDataset As New DataSet
    Private Sub txtIdCuentaCB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCuentaCB.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then


            Dim ofrm As New frmAGenerico

            ofrm.Text = "Buscar Cuenta Contable"
            Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
            Try
                oPerif = New wrConta.wsLibContab
                ds = oPerif.ObtenerCatContab("idCuenta,Descripcion,Cod_CCosto", "Final='S' ", "idCuenta", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0
                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                txtIdCuentaCB.Text = ofrm.Resultado.Trim
                txtCuentaCB.Text = ofrm.Resultado2.Trim
                txtIdCuentaCC.Text = ofrm.Resultado3.Trim
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub txtIdCuentaCC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCuentaCC.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim ofrm As New frmAGenerico

            ofrm.Text = "Buscar Cuenta Centro de Costos"
            Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
            Try
                oPerif = New wrConta.wsLibContab
                ds = oPerif.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion,Comentario", "Final='S'", "Cod_CCosto", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0
                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                txtIdCuentaCC.Text = ofrm.Resultado.Trim
                'txtCuentaCC.Text = ofrm.Resultado2.Trim
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Cat_Costos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtIdCuentaBE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
                'txtIdCuentaBE.Text = ofrm.Resultado.Trim
                'txtCuentaBE.Text = ofrm.Resultado2.Trim
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Cat_Beneficios - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub txtIdCuentaCB_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIdCuentaCB.Validating
        Dim oPerif As New wrConta.wsLibContab, ds As New Data.DataSet, dr As DataRow
        If consultarTodoCat = True Then
            ds = oPerif.ObtenerCatContab("IdCuenta,Descripcion,Cod_CCosto",
                                         "IdCuenta='" & Me.txtIdCuentaCB.Text.Trim & "' and Inhabilitado = 'N' ",
                                         "IdCuenta", sUsuario, sPassword, sSucursal)
        Else
            ds = oPerif.ObtenerCatContab("IdCuenta,Descripcion,Cod_CCosto",
                                       "IdCuenta='" & Me.txtIdCuentaCB.Text.Trim & "'   and Inhabilitado = 'N' ",
                                       "IdCuenta", sUsuario, sPassword, sSucursal)
        End If
        'ds = oPerif.ObtenerCatContab("IdCuenta,Descripcion,Cod_CCosto", "IdCuenta='" & Me.txtIdCuentaCB.Text.Trim & "' and (Final='S' or (Final = 'N' and nivel>= '3')) and (cod_Ccosto <>'1' or cuentaComun='1') ", "IdCuenta", sUsuario, sPassword, sSucursal)
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
            Me.txtCuentaCB.Text = dr("Descripcion").ToString.Trim
            Me.txtIdCuentaCC.Text = dr("Cod_Ccosto").ToString.Trim
            Dim dtsCC As New DataSet
            'dtsCC = contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Descripcion", "Cod_CCosto='" & dr("Cod_Ccosto").ToString.Trim & "' ", "Cod_CCosto", sUsuario, sPassword, sSucursal)
            'If dtsCC.Tables.Count > 0 Then
            '    If dtsCC.Tables(0).Rows.Count > 0 Then
            '        ' Me.txtCuentaCC.Text = dtsCC.Tables(0).Rows(0).Item(0).ToString.Trim
            '    End If
            'End If
            If Me.txtIdCuentaCB.Text.Trim = "" Then
                e.Cancel = True
                Me.txtIdCuentaCB.Select(0, txtIdCuentaCB.Text.Length)
                txtIdCuentaCC.Text = IIf(dr("Cod_CCosto") Is DBNull.Value = True, "1", dr("Cod_CCosto"))
                errorProvider1.SetIconAlignment(Me.txtIdCuentaCB, ErrorIconAlignment.MiddleRight)
                errorProvider1.SetIconPadding(Me.txtIdCuentaCB, 2)
                errorProvider1.BlinkRate = 1000
                errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
                errorProvider1.SetError(txtIdCuentaCB, "Error de Validación")
            Else
                errorProvider1.SetError(Me.txtIdCuentaCB, "")
            End If
        End If

    End Sub

    Private Sub txtIdCuentaCC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuentaCC.TextChanged
        Dim oPerif As New wrConta.wsLibContab, ds As New Data.DataSet, dr As DataRow
        ds = oPerif.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion", "Cod_CCosto='" & Me.txtIdCuentaCC.Text.Trim & "' and Final='S'", "Cod_CCosto", sUsuario, sPassword, sSucursal)
        If ds.Tables("Catalogo").Rows.Count > 0 Then
            dr = ds.Tables("Catalogo").Rows(0)
            Me.txtCentroCosto.Text = dr("Descripcion")
            ' Me.txtCuentaCC.Text = dr("Descripcion")

        End If
    End Sub

    Private Sub txtIdCuentaCC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIdCuentaCC.Validating
        Dim oPerif As New wrConta.wsLibContab, ds As New Data.DataSet, dr As DataRow
        ds = oPerif.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion", "Cod_CCosto='" & Me.txtIdCuentaCC.Text.Trim & "' and Final='S'", "Cod_CCosto", sUsuario, sPassword, sSucursal)
        If ds.Tables("Catalogo").Rows.Count = 0 Then
            e.Cancel = True
            Me.txtIdCuentaCC.Select(0, txtIdCuentaCC.Text.Length)

            'errorProvider1.SetIconAlignment(Me.txtIdCuentaCC, ErrorIconAlignment.MiddleRight)
            'errorProvider1.SetIconPadding(Me.txtIdCuentaCC, 2)
            'errorProvider1.BlinkRate = 1000
            'errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
            'errorProvider1.SetError(txtIdCuentaCC, "Cuenta Costos no existe")
        Else
            dr = ds.Tables("Catalogo").Rows(0)
            Me.txtCentroCosto.Text = dr("descripcion")
            'Me.txtCuentaCC.Text = dr("Descripcion")
            If Me.txtIdCuentaCC.Text.Trim = "" Then
                e.Cancel = True
                Me.txtIdCuentaCC.Select(0, txtIdCuentaCC.Text.Length)
                'errorProvider1.SetIconAlignment(Me.txtIdCuentaCC, ErrorIconAlignment.MiddleRight)
                'errorProvider1.SetIconPadding(Me.txtIdCuentaCC, 2)
                'errorProvider1.BlinkRate = 1000
                'errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
                'errorProvider1.SetError(txtIdCuentaCC, "Error de Validación")
            Else
                errorProvider1.SetError(Me.txtIdCuentaCC, "")
            End If
        End If
    End Sub

    Private Sub btnAceptarLin1_Click(sender As Object, e As EventArgs) Handles btnAceptarLin1.Click
        If txtAbono.Text > 0 Or txtCargo.Text > 0 Then
            Dim dr As Data.DataRow
            Select Case Me.AccionDetalle
                'Case Is = AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas.AgregarLinea
                Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.AgregarLinea
                    dr = Me.Detalle.Tables("Det_Diario").NewRow()
                    Me.Correlativo += 1
                    dr(0) = Me.Correlativo
                    dr(1) = txtIdCuentaCB.Text.Trim
                    dr(2) = txtIdCuentaCC.Text.Trim
                    dr(3) = txtIdCuentaCC.Text.Trim 'txtIdCuentaBE.Text.Trim
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
                'Case Is = AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas.ModificarLinea
                Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarLinea
                    dr = Me.Detalle.Tables("Det_Diario").Rows(C1fgrdDetalle.Row - 1)
                    dr(1) = txtIdCuentaCB.Text.Trim
                    dr(2) = txtIdCuentaCC.Text.Trim
                    dr(3) = "11" 'txtIdCuentaBE.Text.Trim
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
            deshabilitarDetPartida(False)
            'GroupBox3.Enabled = False
            'Me.AccionDetalle = AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas.Ninguna
            Me.AccionDetalle = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.Ninguna
            'Me.MetroPanel1.Enabled = True
            'Me.pnlPpal.Enabled = True
            Me.C1fgrdDetalle.Enabled = True
        Else
            MsgBox("Por favor ingresar un monto mayor que cero.", MsgBoxStyle.Critical, "Módulo - Contabilidad")
        End If
    End Sub

    Private Sub btnCancelarLin1_Click(sender As Object, e As EventArgs) Handles btnCancelarLin1.Click
        ' GroupBox3.Enabled = False
        deshabilitarDetPartida(False)
        Me.LimpiarDetalle()
        'Me.MetroPanel1.Enabled = True
        ' Me.pnlPpal.Enabled = True
        Me.C1fgrdDetalle.Enabled = True
    End Sub

    Private Sub btnInsertarLin_Click(sender As Object, e As EventArgs) Handles btnInsertarLin.Click
        'GroupBox3.Enabled = True

        deshabilitarDetPartida(True)
        Me.LimpiarDetalle()
        'Me.AccionDetalle = AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas.AgregarLinea
        Me.AccionDetalle = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.AgregarLinea
        'Me.MetroPanel1.Enabled = False
        'Me.pnlPpal.Enabled = False
        Me.txtIdCuentaCB.Focus()
    End Sub

    Private Sub btnModificarLin_Click(sender As Object, e As EventArgs) Handles btnModificarLin.Click
        If txtIdCuentaCB.Text.Trim() = "" Then
        Else
            deshabilitarDetPartida(True)
            'GroupBox3.Enabled = True
            vC = Me.txtCargo.Text
            vA = Me.txtAbono.Text
            'Me.AccionDetalle = AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas.ModificarLinea
            Me.AccionDetalle = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarLinea
            ' Me.MetroPanel1.Enabled = False
            'Me.pnlPpal.Enabled = False
        End If

    End Sub

    Private Sub btnEliminarLin_Click(sender As Object, e As EventArgs) Handles btnEliminarLin.Click
        If txtIdCuentaCB.Text.Trim() = "" Then
            MessageBox.Show("Debe seleccionar una cuenta a eliminar en la sección de detalle de la partida", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
        Else
            Try
                If MessageBox.Show("¿Desea eliminar la línea seleccionada?", "Eliminar Línea", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
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
                                            MsgBox("La cuenta:" & row(0).ToString.Trim & ". No pertenece al cátalogo", MsgBoxStyle.Critical, "Módulo de Contabilidad")
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
                                    'dtsPartida.Tables(0).Rows.Add(dr)
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
                dr("Id_Estado") = "D"
                dr("Prefijo") = Me.cmbTipoPartidas.Text.Trim.Substring(0, 2)
                If Me.chkInicial.Checked = True Then
                    dr("Inicial") = "1"
                Else
                    dr("Inicial") = "0"
                End If
                dr("Annio") = Date.Now.Year
                Me.Detalle.Tables("Det_Diario").AcceptChanges()
                MessageBox.Show("La plantilla se guardará en: " & saveFileDialog1.FileName, "Guardar plantilla", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Detalle.WriteXml(saveFileDialog1.FileName)
            Else
                MessageBox.Show("Operación Cancelada", "Guardar plantilla", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show("Origen del Error: " & ex.Source & " --- Mensaje de Error: " & ex.Message, "Error Capturado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oPartida As New wrConta.wsLibContab, dr As System.Data.DataRow, drC As DataRow, ds As New DataSet
        Try

            ds = oPartida.ConsultaCierre("*", "Annio=" & Me.dtpFecha.Value.Year & "", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                drC = ds.Tables(0).Rows(0)
                If IIf(drC(MonthName(Month(Me.dtpFecha.Value))) Is System.DBNull.Value, "0", drC(MonthName(Month(Me.dtpFecha.Value)))) = "1" Then
                    MessageBox.Show("El mes se encuentra cerrado, no es posible agregar la partida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            Select Case Me.Accion
                'Case Is = AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas.AgregarPartida
                Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.AgregarPartida
                    'If Me.Tipo = AlcalaLibs.Contabilidad.clsPartida.TipoPartidaModulo.Bancos Then
                    If Me.Tipo = sifLib.Contabilidad.clsPartidas.TipoPartidaModulo.Bancos Then
                        If Me.cmbTipoPartidas.Text.Trim = "" Then
                            MessageBox.Show("El tipo de Partida no puede quedar vacío", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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
                        Me.txtNumero.Text = oPartida.InsertaPartidaModulo(sUsuario, sPassword, sSucursal, Me.Detalle, Me.Tipo)
                        If Me.txtNumero.Text.Trim <> "" Or Me.txtNumero.Text.Trim <> "Error" Then
                            MessageBox.Show(Me.txtNumero.Text, "Partida Guardada")
                            Me.Close()
                        End If
                    Else
                        If Me.cmbTipoPartidas.Text.Trim = "" Then
                            MessageBox.Show("El tipo de Partida no puede quedar vacío", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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
                        Me.txtNumero.Text = oPartida.InsertaPartida(sUsuario, sPassword, sSucursal, Me.Detalle)
                        If Me.txtNumero.Text.Trim <> "" Or Me.txtNumero.Text.Trim <> "Error" Then
                            MessageBox.Show(Me.txtNumero.Text, "Partida Guardada")
                            Me.Close()
                        End If
                    End If

                'Case Is = AlcalaLibs.Contabilidad.clsPartida.TipoAccionPartidas.ModificarPartida
                Case Is = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarPartida
                    'If Me.Tipo = AlcalaLibs.Contabilidad.clsPartida.TipoPartidaModulo.Bancos Then
                    If Me.Tipo = sifLib.Contabilidad.clsPartidas.TipoPartidaModulo.Bancos Then
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
                        If oPartida.ModificaPartidaModulo(sUsuario, sPassword, sSucursal, Me.Detalle, Me.Tipo) Then

                        End If
                    Else
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

                        Try
                            If oPartida.ModificaPartida(sUsuario, sPassword, sSucursal, Me.Detalle) Then
                            Else

                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message)
                        End Try


                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show("Origen del Error: " & ex.Source & " --- Mensaje de Error: " & ex.Message, "Error Capturado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnCancelar1_Click(sender As Object, e As EventArgs) Handles btnCancelar1.Click
        Me.Close()
    End Sub

    Private Sub txtDescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.LostFocus
        Me.txtConcepto.Text = Me.txtDescripcion.Text
    End Sub

    Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
        Dim oPartida As New wrConta.wsLibContab
        Dim dsTipo As New DataSet, dr As DataRow ', x As Integer, 
        Dim s As Integer, g As Integer
        Me.cmbTipoPartidas.Items.Clear()
        'If Me.Tipo = AlcalaLibs.Contabilidad.clsPartida.TipoPartidaModulo.Bancos Then
        If Me.Tipo = sifLib.Contabilidad.clsPartidas.TipoPartidaModulo.Bancos Then
            dsTipo = oPartida.ObtenerTipoPartidasBC(Me.dtpFecha.Value.Year, sUsuario, sPassword, sSucursal)
            For Each dr In dsTipo.Tables("Tipo_Partidas").Rows
                If Trim(dr("Prefijo")) = "EG" Then
                    cmbTipoPartidas.Items.Add(CStr(dr("Prefijo")) & " - " & CStr(dr("Descripcion")))
                    cmbTipoPartidas.SelectedIndex = 0
                End If
            Next
            Me.dtpFecha.Enabled = False
        Else
            dsTipo = oPartida.ObtenerTipoPartidas(Me.dtpFecha.Value.Year, sUsuario, sPassword, sSucursal)
            For Each dr In dsTipo.Tables(0).Rows
                cmbTipoPartidas.Items.Add(CStr(dr("Prefijo")) & " - " & CStr(dr("Descripcion")))
                If Me.Prefijo.Trim = Trim(CStr(dr("Prefijo"))) Then g = s
                s = s + 1
            Next
            Me.cmbTipoPartidas.SelectedIndex = g
        End If
    End Sub


End Class