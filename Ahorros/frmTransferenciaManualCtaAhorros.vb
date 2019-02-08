Public Class frmTransferenciaManualCtaAhorros
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Private sNoCuenta As String, pSaldoOrigen As Double, pPignorado As String, vCancela As Boolean, pCodTransferencia As String, pCodTransaccion As String, vDPF As Boolean
    ', sSupervisor As String, pPassword As String
    Public dsDetalle As New DataSet
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents txtCodCosto As TextBox
    Friend WithEvents txtNombCosto As TextBox
    Friend WithEvents Label13 As Label
    Dim contabilidad As New wrConta.wsLibContab

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
    Friend WithEvents btNProcesar As MetroFramework.Controls.MetroButton
    Friend WithEvents btBorrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    'Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    'Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbCtas As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents c1txtObservaciones As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents c1txtNoDoc As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1txtCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1txtNombreAsoc As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbDestino As System.Windows.Forms.GroupBox
    'Friend WithEvents btnModificar As System.Windows.Forms.Button
    'Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtCodTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents tbAnul As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents fgAnulaciones As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferenciaManualCtaAhorros))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbCtas = New System.Windows.Forms.TabPage()
        Me.btNProcesar = New MetroFramework.Controls.MetroButton()
        Me.btBorrar = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.gbDestino = New System.Windows.Forms.GroupBox()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodCosto = New System.Windows.Forms.TextBox()
        Me.txtNombCosto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodTipo = New System.Windows.Forms.TextBox()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.c1txtObservaciones = New C1.Win.C1Input.C1TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c1txtNoDoc = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1txtCuenta = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1txtNombreAsoc = New C1.Win.C1Input.C1TextBox()
        Me.c1txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbAnul = New System.Windows.Forms.TabPage()
        Me.fgAnulaciones = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tbCtas.SuspendLayout()
        Me.gbDestino.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNombreAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbAnul.SuspendLayout()
        CType(Me.fgAnulaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tbCtas)
        Me.TabControl1.Controls.Add(Me.tbAnul)
        Me.TabControl1.Location = New System.Drawing.Point(28, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(732, 680)
        Me.TabControl1.TabIndex = 6
        '
        'tbCtas
        '
        Me.tbCtas.BackColor = System.Drawing.Color.White
        Me.tbCtas.Controls.Add(Me.btNProcesar)
        Me.tbCtas.Controls.Add(Me.btBorrar)
        Me.tbCtas.Controls.Add(Me.btnImprimir)
        Me.tbCtas.Controls.Add(Me.gbDestino)
        Me.tbCtas.Controls.Add(Me.GroupBox1)
        Me.tbCtas.Location = New System.Drawing.Point(4, 28)
        Me.tbCtas.Name = "tbCtas"
        Me.tbCtas.Size = New System.Drawing.Size(724, 648)
        Me.tbCtas.TabIndex = 0
        Me.tbCtas.Text = "Transferencia Cuentas"
        '
        'btNProcesar
        '
        Me.btNProcesar.Location = New System.Drawing.Point(601, 593)
        Me.btNProcesar.Name = "btNProcesar"
        Me.btNProcesar.Size = New System.Drawing.Size(100, 32)
        Me.btNProcesar.Style = MetroFramework.MetroColorStyle.Green
        Me.btNProcesar.TabIndex = 230
        Me.btNProcesar.Text = "Procesar"
        Me.btNProcesar.UseSelectable = True
        Me.btNProcesar.UseStyleColors = True
        '
        'btBorrar
        '
        Me.btBorrar.Location = New System.Drawing.Point(494, 593)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(100, 32)
        Me.btBorrar.Style = MetroFramework.MetroColorStyle.Green
        Me.btBorrar.TabIndex = 229
        Me.btBorrar.Text = "Limpiar"
        Me.btBorrar.UseSelectable = True
        Me.btBorrar.UseStyleColors = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(388, 593)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(99, 32)
        Me.btnImprimir.Style = MetroFramework.MetroColorStyle.Green
        Me.btnImprimir.TabIndex = 228
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseSelectable = True
        Me.btnImprimir.UseStyleColors = True
        '
        'gbDestino
        '
        Me.gbDestino.Controls.Add(Me.btnDel)
        Me.gbDestino.Controls.Add(Me.btnMod)
        Me.gbDestino.Controls.Add(Me.txtTotal)
        Me.gbDestino.Controls.Add(Me.btnAdd)
        Me.gbDestino.Controls.Add(Me.fg)
        Me.gbDestino.ForeColor = System.Drawing.Color.Black
        Me.gbDestino.Location = New System.Drawing.Point(10, 346)
        Me.gbDestino.Name = "gbDestino"
        Me.gbDestino.Size = New System.Drawing.Size(691, 240)
        Me.gbDestino.TabIndex = 1
        Me.gbDestino.TabStop = False
        Me.gbDestino.Text = "Cuenta(s) de Destino:"
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(224, 25)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(100, 33)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Green
        Me.btnDel.TabIndex = 233
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(118, 25)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(99, 33)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Green
        Me.btnMod.TabIndex = 235
        Me.btnMod.Text = "Modificar"
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(362, 32)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(221, 22)
        Me.txtTotal.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(11, 25)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 33)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Green
        Me.btnAdd.TabIndex = 234
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.Location = New System.Drawing.Point(12, 65)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(672, 166)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodCosto)
        Me.GroupBox1.Controls.Add(Me.txtNombCosto)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.txtIdCuenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCodTipo)
        Me.GroupBox1.Controls.Add(Me.txtResponsable)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.c1txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.c1txtNoDoc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.c1txtCuenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.c1txtNombreAsoc)
        Me.GroupBox1.Controls.Add(Me.c1txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta de Origen"
        '
        'txtCodCosto
        '
        Me.txtCodCosto.BackColor = System.Drawing.Color.White
        Me.txtCodCosto.Location = New System.Drawing.Point(132, 181)
        Me.txtCodCosto.Name = "txtCodCosto"
        Me.txtCodCosto.ReadOnly = True
        Me.txtCodCosto.Size = New System.Drawing.Size(60, 22)
        Me.txtCodCosto.TabIndex = 173
        '
        'txtNombCosto
        '
        Me.txtNombCosto.BackColor = System.Drawing.Color.White
        Me.txtNombCosto.Location = New System.Drawing.Point(200, 181)
        Me.txtNombCosto.Name = "txtNombCosto"
        Me.txtNombCosto.ReadOnly = True
        Me.txtNombCosto.Size = New System.Drawing.Size(338, 22)
        Me.txtNombCosto.TabIndex = 172
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 22)
        Me.Label13.TabIndex = 171
        Me.Label13.Text = "Centro Costos:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(228, 217)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(456, 22)
        Me.txtCuenta.TabIndex = 166
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Location = New System.Drawing.Point(131, 217)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.ReadOnly = True
        Me.txtIdCuenta.Size = New System.Drawing.Size(86, 22)
        Me.txtIdCuenta.TabIndex = 165
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 18)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "Cuenta Contable:"
        '
        'txtCodTipo
        '
        Me.txtCodTipo.Location = New System.Drawing.Point(458, 24)
        Me.txtCodTipo.Name = "txtCodTipo"
        Me.txtCodTipo.Size = New System.Drawing.Size(10, 22)
        Me.txtCodTipo.TabIndex = 164
        Me.txtCodTipo.Visible = False
        '
        'txtResponsable
        '
        Me.txtResponsable.Location = New System.Drawing.Point(134, 54)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(550, 22)
        Me.txtResponsable.TabIndex = 1
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(134, 84)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(204, 20)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(480, 84)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(204, 23)
        Me.txtNoSocio.TabIndex = 163
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(7, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 23)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Asociado:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(346, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 18)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "No. Asociado:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 18)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Responsable:"
        '
        'c1txtObservaciones
        '
        Me.c1txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtObservaciones.Location = New System.Drawing.Point(131, 247)
        Me.c1txtObservaciones.MaxLength = 255
        Me.c1txtObservaciones.Multiline = True
        Me.c1txtObservaciones.Name = "c1txtObservaciones"
        Me.c1txtObservaciones.NumericInput = False
        Me.c1txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtObservaciones.Size = New System.Drawing.Size(553, 60)
        Me.c1txtObservaciones.TabIndex = 6
        Me.c1txtObservaciones.Tag = Nothing
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 18)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Observaciones:"
        '
        'c1txtNoDoc
        '
        Me.c1txtNoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNoDoc.CustomFormat = "00000000000000000000"
        Me.c1txtNoDoc.DataType = GetType(Long)
        Me.c1txtNoDoc.Location = New System.Drawing.Point(480, 24)
        Me.c1txtNoDoc.MaxLength = 14
        Me.c1txtNoDoc.Name = "c1txtNoDoc"
        Me.c1txtNoDoc.NumericInput = False
        Me.c1txtNoDoc.Size = New System.Drawing.Size(204, 20)
        Me.c1txtNoDoc.TabIndex = 2
        Me.c1txtNoDoc.Tag = Nothing
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(346, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "No. Documento:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(346, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Valor Transferencia:"
        '
        'c1txtCuenta
        '
        Me.c1txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtCuenta.Location = New System.Drawing.Point(134, 144)
        Me.c1txtCuenta.MaxLength = 14
        Me.c1txtCuenta.Name = "c1txtCuenta"
        Me.c1txtCuenta.NumericInput = False
        Me.c1txtCuenta.ReadOnly = True
        Me.c1txtCuenta.Size = New System.Drawing.Size(204, 20)
        Me.c1txtCuenta.TabIndex = 4
        Me.c1txtCuenta.Tag = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Cuenta:"
        '
        'c1txtNombreAsoc
        '
        Me.c1txtNombreAsoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNombreAsoc.Location = New System.Drawing.Point(134, 114)
        Me.c1txtNombreAsoc.MaxLength = 14
        Me.c1txtNombreAsoc.Name = "c1txtNombreAsoc"
        Me.c1txtNombreAsoc.NumericInput = False
        Me.c1txtNombreAsoc.ReadOnly = True
        Me.c1txtNombreAsoc.Size = New System.Drawing.Size(550, 20)
        Me.c1txtNombreAsoc.TabIndex = 94
        Me.c1txtNombreAsoc.Tag = Nothing
        '
        'c1txtMonto
        '
        Me.c1txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtMonto.CustomFormat = "###,##0.00"
        Me.c1txtMonto.DataType = GetType(Double)
        Me.c1txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1txtMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1txtMonto.Location = New System.Drawing.Point(480, 144)
        Me.c1txtMonto.Name = "c1txtMonto"
        Me.c1txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(0R, Nothing, True, True)})
        Me.c1txtMonto.Size = New System.Drawing.Size(204, 23)
        Me.c1txtMonto.TabIndex = 5
        Me.c1txtMonto.Tag = Nothing
        Me.c1txtMonto.Value = 0R
        Me.c1txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "DUI:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(134, 24)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(204, 22)
        Me.dtpFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Fecha Movimiento:"
        '
        'tbAnul
        '
        Me.tbAnul.BackColor = System.Drawing.Color.White
        Me.tbAnul.Controls.Add(Me.fgAnulaciones)
        Me.tbAnul.Controls.Add(Me.chkTodos)
        Me.tbAnul.Controls.Add(Me.txtUsuario)
        Me.tbAnul.Controls.Add(Me.Label12)
        Me.tbAnul.Controls.Add(Me.dtpFechaEmision)
        Me.tbAnul.Controls.Add(Me.Label9)
        Me.tbAnul.ForeColor = System.Drawing.Color.Black
        Me.tbAnul.Location = New System.Drawing.Point(4, 28)
        Me.tbAnul.Name = "tbAnul"
        Me.tbAnul.Size = New System.Drawing.Size(724, 648)
        Me.tbAnul.TabIndex = 1
        Me.tbAnul.Text = "Anulaciones"
        '
        'fgAnulaciones
        '
        Me.fgAnulaciones.AllowEditing = False
        Me.fgAnulaciones.BackColor = System.Drawing.Color.White
        Me.fgAnulaciones.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgAnulaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgAnulaciones.Location = New System.Drawing.Point(16, 97)
        Me.fgAnulaciones.Name = "fgAnulaciones"
        Me.fgAnulaciones.Rows.Count = 1
        Me.fgAnulaciones.Rows.DefaultSize = 22
        Me.fgAnulaciones.Size = New System.Drawing.Size(688, 443)
        Me.fgAnulaciones.StyleInfo = resources.GetString("fgAnulaciones.StyleInfo")
        Me.fgAnulaciones.TabIndex = 5
        '
        'chkTodos
        '
        Me.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodos.ForeColor = System.Drawing.Color.Black
        Me.chkTodos.Location = New System.Drawing.Point(541, 16)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(77, 28)
        Me.chkTodos.TabIndex = 4
        Me.chkTodos.Text = "&Todos"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(157, 45)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(461, 22)
        Me.txtUsuario.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Responsable:"
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(157, 15)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(106, 22)
        Me.dtpFechaEmision.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Fecha de Movimiento:"
        '
        'frmTransferenciaManualCtaAhorros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(775, 772)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(672, 456)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransferenciaManualCtaAhorros"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Transferencia Cuentas Auxiliares"
        Me.TabControl1.ResumeLayout(False)
        Me.tbCtas.ResumeLayout(False)
        Me.gbDestino.ResumeLayout(False)
        Me.gbDestino.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNombreAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbAnul.ResumeLayout(False)
        Me.tbAnul.PerformLayout()
        CType(Me.fgAnulaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTransferenciaManualCtaAhorros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAh As New wrAhorro.wsLibAhorro, oApp As New wrAdmin.wsLibAdmin
        Me.txtResponsable.Text = sUsuario ' Me.Supervisor
        Me.dtpFecha.Value = oApp.Fecha
        dsDetalle = oAh.ObtenerDetalleTransferenciaVacio
        vCancela = False
        vDPF = False
    End Sub

    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "No."
        fg.Cols.Item(2).Caption = "No. Cuenta"
        fg.Cols.Item(3).Caption = "Cta. Contable"
        fg.Cols.Item(4).Caption = "Valor"
        fg.Cols.Item(5).Caption = "Tipo Movimiento"
        fg.Cols.Item(6).Caption = "Tipo Cuenta"
        fg.Cols.Item(7).Caption = "Fecha"
        fg.Cols.Item(4).Format = "##0.00"

        fg.Cols.Item(1).Width = 77
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 77
        fg.Cols.Item(5).Width = 0
        fg.Cols.Item(6).Width = 0
        fg.Cols.Item(7).Width = 0

    End Sub

    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Dim oAh As wrAhorro.wsLibAhorro, oAsoc As wrAsociados.wsLibAsoc
        Dim dr As DataRow, ds As New Data.DataSet

        Try
            oAh = New wrAhorro.wsLibAhorro
            oAsoc = New wrAsociados.wsLibAsoc

            ds = oAsoc.ConsultarAsociado("DUI,Nombres+' '+Apellido1+' '+Apellido2+' '+ApellidoCas as NombreAsociado,NoSocio", "Dui='" & Me.txtDui.Value & "'", "DUI", sUsuario, sPassword, sSucursal)
            If ds.Tables("Cat_Asociados").Rows.Count > 0 Then
                dr = ds.Tables("Cat_Asociados").Rows(0)
                Me.txtDui.Value = dr("Dui")
                Me.c1txtNombreAsoc.Value = dr("NombreAsociado")
                Me.txtNoSocio.Text = dr("NoSocio")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sNomb, campos As String, var As Integer, corrDic As Integer
        Dim dr As DataRow, ds As New Data.DataSet
        Dim oAh As wrAhorro.wsLibAhorro, oAsoc As wrAsociados.wsLibAsoc
        Dim oCred As wrCredito.wsLibCred

        Try
            oAh = New wrAhorro.wsLibAhorro
            oCred = New wrCredito.wsLibCred
            oAsoc = New wrAsociados.wsLibAsoc

            campos = " DUI,Nombres+' '+Apellido1+' '+Apellido2+' '+ApellidoCas as NombreAsociado,"
            campos += "NoSocio,NIT,ISSS,LugarExtDUI,FechaExtDUI,NumPasaporte,EstadoIngreso,Fecha_Nac,Direccion "
            ds = oAsoc.ConsultarAsociado(campos, "", "DUI", sUsuario, sPassword, sSucursal)
            frm.Text = "Buscar Asociados"
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim <> "" Then
                Me.txtDui.Value = IIf(IsDBNull(frm.Resultado.Trim), "", frm.Resultado.Trim)
                sNomb = IIf(IsDBNull(frm.Resultado2.Trim), "", frm.Resultado2.Trim)
                Me.c1txtNombreAsoc.Value = sNomb
                Me.txtNoSocio.Text = IIf(IsDBNull(frm.Resultado3.Trim), "", frm.Resultado3.Trim)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        Dim ds As New DataSet
        Me.c1txtCuenta.Value = ""
        Me.dtpFecha.Value = Now
        Me.c1txtNoDoc.Value = 0
        Me.txtDui.Value = ""
        Me.txtNoSocio.Text = ""
        Me.c1txtNombreAsoc.Value = ""
        Me.c1txtObservaciones.Value = ""
        Me.c1txtMonto.Value = 0
        txtCodCosto.Text = ""
        txtNombCosto.Text = ""
        Me.btnAdd.Enabled = False
        Me.fg.DataSource = ds
        Me.dsDetalle.Clear()
        Me.txtDui.Focus()
        vCancela = False
        vDPF = False
        Me.txtIdCuenta.Text = ""
        Me.txtCuenta.Text = ""
        Me.c1txtCuenta.Enabled = True
        Me.c1txtMonto.Enabled = True
        Me.btBorrar.Enabled = True
        'Me.btSalir.Enabled = True
        Me.txtDui.Enabled = True
        pCodTransaccion = ""
        Me.btnImprimir.Enabled = False
        pCodTransferencia = ""
        Me.btNProcesar.Enabled = True
        Me.c1txtCuenta.Enabled = True
        Me.fgAnulaciones.Enabled = True
    End Sub



    Private Sub SumaDetalle()
        Dim pSum As Double, dr As DataRow, x As Integer
        x = 0
        For Each dr In dsDetalle.Tables(0).Rows
            x = x + 1
            pSum = pSum + dr("Valor")
        Next
        If x > 0 Then
            Me.c1txtCuenta.Enabled = False
            Me.c1txtMonto.Enabled = False
        Else
            Me.c1txtCuenta.Enabled = True
            Me.c1txtMonto.Enabled = True
        End If
        pSum = Me.c1txtMonto.Text - pSum
        Me.txtTotal.Text = "Pendiente: $" & pSum
    End Sub

    Private Sub c1txtCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1txtCuenta.DoubleClick
        Dim ds As New DataSet, oAh As New wrAhorro.wsLibAhorro, dr As DataRow
        Dim frm As New frmAGenerico, oPerif As New wrConta.wsLibContab
        ds = oAh.ConsultarCtasAhorroDUI("a.CodTipoAhorro as Codigo, " &
                                        "b.Descripcion as Tipo_Ahorro, " &
                                        "a.NoCuenta, " &
                                        "a.NoCuentaAnterior, " &
                                        "a.IdCertificadoDPF as No_Certificado," &
                                        "a.SaldoDisponible_CuentaAhorro as Saldo, " &
                                        "b.IdCuenta as Cuenta_Contable," &
                                        "Pignorado," &
                                        "a.codSucursal, d.Cod_CCosto, d.Descripcion", "a.DUI='" & Me.txtDui.Value & "' AND a.Estado <> 'C'", "", sUsuario, sPassword, sSucursal)
        frm.Text = "Buscar Cuentas Auxiliares"
        frm.Datos = ds
        frm.ColSeleccion = 0
        frm.RefrescarGrid()
        frm.ShowDialog()
        If frm.Resultado.Trim <> "" Then
            Me.c1txtCuenta.Value = frm.Resultado3.Trim
            Me.txtCodTipo.Text = frm.Resultado.Trim
            txtCodCosto.Text = frm.Resultado10
            txtNombCosto.Text = frm.Resultado11
            Me.txtIdCuenta.Text = contabilidad.Recuperar_Cta_x_Centro_Costo(frm.Resultado9, frm.Resultado7.Trim)
            ' Me.txtIdCuenta.Text = frm.Resultado7.Trim
            pSaldoOrigen = frm.Resultado6
            If Me.txtCodTipo.Text.Trim.Substring(0, 1) = "6" Then 'DPF
                Me.c1txtMonto.Value = pSaldoOrigen
                Me.c1txtMonto.Enabled = False
                vDPF = True
            Else
                vDPF = False
            End If
            pPignorado = frm.Resultado8.Trim
            If Trim(Me.txtIdCuenta.Text.Trim) <> "" Then
                ds = oPerif.ObtenerCatContab("*", "Final='S' and IdCuenta='" & Me.txtIdCuenta.Text.Trim & "'", "idCuenta", sUsuario, sPassword, sSucursal)
                If ds.Tables("Catalogo").Rows.Count > 0 Then
                    dr = ds.Tables("Catalogo").Rows(0)
                    Me.txtCuenta.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                End If
            End If
        End If
    End Sub

    Private Sub CargaDatosCuentaCancelada()

        Dim ds As New DataSet, oAh As New wrAhorro.wsLibAhorro, dr As DataRow
        ds = oAh.ConsultarCtasAhorroDUI("a.CodTipoAhorro as Codigo,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.SaldoDisponible_CuentaAhorro as Saldo,b.IdCuenta as Cuenta_Contable,Pignorado", "a.Nocuenta='" & Me.c1txtCuenta.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count > 0 Then
            dr = ds.Tables(0).Rows(0)
            pSaldoOrigen = dr("Saldo")
            Me.c1txtMonto.Value = pSaldoOrigen
        End If
        Me.c1txtCuenta.Enabled = False
        Me.c1txtMonto.Enabled = False
        Me.btBorrar.Enabled = False
        'Me.btSalir.Enabled = False
        Me.txtDui.Enabled = False
        Me.fgAnulaciones.Enabled = False
        pCodTransaccion = "CAN"

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub c1txtCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1txtCuenta.LostFocus
        If Me.c1txtCuenta.Text.Trim <> "" Then
            Me.btnAdd.Enabled = True
        Else
            Me.btnAdd.Enabled = False
        End If
    End Sub


    Private Sub frmTransferenciaManualCtaAhorros_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If vCancela = True Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txtDui_LostFocus(sender, e)
        End If
    End Sub

    Private Function VerificaPrestamo() As Boolean
        Dim pSum As Double, dr As DataRow

        For Each dr In dsDetalle.Tables(0).Rows
            If dr("TipoCuenta") = "P" Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub dtpFechaEmision_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaEmision.LostFocus
        Me.chkTodos.Checked = False
        Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
        ds = oAh.ConsultarTransferencia("distinct a.CodTransferencia,a.Fecha,a.NoDocumento,a.NoSocio,a.Dui,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,ValorTransferencia as Valor,Observacion,a.Responsable,a.Estado", "a.Fecha='" & Me.dtpFechaEmision.Value.ToShortDateString & "'", "a.Fecha desc,a.CodTransferencia", 3, sUsuario, sPassword, sSucursal)
        Me.fgAnulaciones.DataSource = ds.Tables(0)
        EncabezadoAnulaciones()
    End Sub

    Private Sub txtUsuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.LostFocus
        Me.chkTodos.Checked = False
        If Me.txtUsuario.Text.Trim = "" Then Exit Sub
        Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
        ds = oAh.ConsultarTransferencia("distinct a.CodTransferencia,a.Fecha,a.NoDocumento,a.NoSocio,a.Dui,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,ValorTransferencia as Valor,Observacion,a.Responsable,a.Estado", "a.Responsable like '%" & Me.txtUsuario.Text.Trim & "%'", "a.Fecha desc,a.CodTransferencia", 3, sUsuario, sPassword, sSucursal)
        Me.fgAnulaciones.DataSource = ds.Tables(0)
        EncabezadoAnulaciones()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtResponsable_TextChanged(sender As Object, e As EventArgs) Handles txtResponsable.TextChanged

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim ds As New DataSet
            Dim oCaja As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
            If VerificaPrestamo() = False Then
                ds = oCaja.NotaCargo(pCodTransferencia, Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 56, 0)
                ofrm.ShowDialog()
            Else
                ds = oCaja.NotaCargoPrestamo(pCodTransferencia, Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 58, 0)
                ofrm.ShowDialog()
            End If
            Limpiar()
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        Limpiar()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btNProcesar.Click

        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim dsDestino As New DataSet

        'Dim saldoCapDB, montoCtaDest

        Dim oAhorro As New wrAhorro.wsLibAhorro, oAsoc As New wrAsociados.wsLibAsoc
        Dim CamposValores As String, pFiltro As String, noCuentaDestino As String, noCuentaOrigen As String, pResponse As String
        Dim saldoCtaDispoDB As Double, saldoCtaDB As Double, saldoAnterior As Double, montoCtaOrig As Double, saldoActual As Double, pMontoParam As Double
        Dim dsOrigen As New DataSet, dr As DataRow, dsAhorro As New DataSet, drAhorro As DataRow, dsPar As New DataSet, drPar As DataRow

        Try
            If Math.Round(pSaldoOrigen, 2) >= Math.Round(CDbl(Me.c1txtMonto.Text), 2) Then
            Else
                MessageBox.Show("El Monto de Retiro es mayor que el Saldo disponible.", "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Me.txtIdCuenta.Text.Trim = "" Then
                MessageBox.Show("La Cuenta Contable no puede quedar vacía.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If vCancela = False Then
                dsAhorro = oAhorro.ConsultarParametros("*", "CodTipoAhorro='" & Me.txtCodTipo.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                If dsAhorro.Tables("AhParametros").Rows.Count > 0 Then
                    drAhorro = dsAhorro.Tables("AhParametros").Rows(0)
                    If Math.Round(drAhorro("MontoSaldoMinimo"), 2) > Math.Round(pSaldoOrigen, 2) - Math.Round(CDbl(Me.c1txtMonto.Text), 2) Then
                        If MessageBox.Show("El Saldo mínimo debe ser de " & Math.Round(drAhorro("MontoSaldoMinimo"), 2) & ". ¿Desea cancelar la cuenta?", "Cancelación de Cuentas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                            Exit Sub
                        Else
                            If pPignorado = "S" Then
                                MessageBox.Show("La cuenta se encuentra pignorada, no se puede cancelar.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If

                            dsPar = oAsoc.ConsultarParametros("*", "", "SalarioMinimo", sUsuario, sPassword, sSucursal)
                            If dsPar.Tables(0).Rows.Count > 0 Then
                                drPar = dsPar.Tables(0).Rows(0)
                                pMontoParam = IIf(IsDBNull(drPar("MontoDPF")), 0, drPar("MontoDPF"))
                            Else
                                pMontoParam = 0
                            End If

                            Dim ofrmAut As New frmMsAutorizacion
                            ofrmAut.TipoPermiso = "P"
                            ofrmAut.NumPrograma = "AHG010"
                            ofrmAut.ShowDialog()
                            If ofrmAut.Autoriza = True Then
                                'Cancelar la Cuenta
                                Dim ofrmCC As New frmMsAhCancelaCuenta
                                If Me.txtCodTipo.Text.Trim.Substring(0, 1) = "6" Then
                                    If pSaldoOrigen >= pMontoParam Then
                                        ofrmCC.vAplicaAut = True
                                    Else
                                        ofrmCC.vAplicaAut = False
                                    End If
                                Else
                                    ofrmCC.vAplicaAut = False
                                End If
                                ofrmCC.vCUsuario = ofrmAut.Usuario
                                ofrmCC.vCPassword = ofrmAut.Password
                                ofrmCC.NoCaja = "0"
                                ofrmCC.CodCajero = "0"
                                ofrmCC.NoCuenta = Me.c1txtCuenta.Text.Trim
                                ofrmCC.CodTipoAhorro = Me.txtCodTipo.Text.Trim
                                ofrmCC.ShowDialog()
                                If ofrmCC.Autorizado = False Then
                                    MessageBox.Show("La cuenta no se ha cancelado, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                Else
                                    vCancela = True
                                    CargaDatosCuentaCancelada()
                                    MessageBox.Show("Cuenta cancelada.", "Cancelación de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Exit Sub
                                End If
                                ofrmAut.Autoriza = False
                                ofrmAut.Dispose()
                            Else
                                ofrmAut.Dispose()
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
            If vCancela = False Then pCodTransaccion = "RET"
            'pCodTransferencia = oAhorro.ObtenerCorrelativoTransferencia("CodTransferencia", "3", sSupervisor, pPassword)
            pCodTransferencia = oAhorro.ObtenerCorrelativoTransferencia("CodTransferencia", "3", "(MONTH(Fecha) = '" & Me.dtpFecha.Value.Month & "')  AND (YEAR(Fecha) = " & Me.dtpFecha.Value.Year & ")", sUsuario, sPassword, sSucursal)
            pResponse = oAhorro.TransferenciaCuentas(Me.c1txtNoDoc.Text.Trim, "3", Me.dtpFecha.Value, Me.txtDui.Value, Me.txtNoSocio.Text.Trim, Me.txtResponsable.Text.Trim, CDbl(Me.c1txtMonto.Text), Me.c1txtObservaciones.Text.Trim, Me.c1txtCuenta.Text.Trim, pCodTransferencia, Me.txtIdCuenta.Text.Trim, Me.txtCodTipo.Text.Trim, dsDetalle, pCodTransaccion, "M", Me.c1txtNombreAsoc.Text.Trim, "0", sUsuario, sPassword, sSucursal, txtCodCosto.Text)
            If pResponse <> "" Then
                MessageBox.Show(pResponse, "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                MessageBox.Show("Transferencia realizada.", "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btnImprimir.Enabled = True
                Me.btNProcesar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub MetroButton3_Click_1(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If fg.Row > 0 Then
                Dim pNocuenta As String
                pNocuenta = Trim(fg.Item(fg.Row, "NoCuenta")).ToString
                If MessageBox.Show("¿Está seguro que desea eliminar la Cuenta " & pNocuenta & "?", "Transferencia Cuentas Auxiliares", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAh.EliminarDetalleTransferencia(dsDetalle, fg.Item(fg.Row, "Numero"))
                    dsDetalle.Clear()
                    dsDetalle = ds.Copy
                    fg.DataSource = dsDetalle.Tables(0)
                    Encabezado()
                    SumaDetalle()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click_2(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMsAhDetTransferencias
            ofrm.NoCuenta = Me.c1txtCuenta.Value
            ofrm.Dui = Me.txtDui.Value
            ofrm.Fecha = Me.dtpFecha.Value
            ofrm.FrmT = Me
            If vDPF = True Then ofrm.c1txtMonto.Value = Me.c1txtMonto.Value
            ofrm.ShowDialog()
            fg.DataSource = dsDetalle.Tables(0)
            fg.Refresh()
            Encabezado()
            SumaDetalle()
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click_2(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            If fg.Row > 0 Then
                Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
                ds = oAh.ModificarDetalleTransferencia(dsDetalle, fg.Item(fg.Row, "Numero"), Trim(fg.Item(fg.Row, "NoCuenta")).ToString, fg.Item(fg.Row, "Valor"), fg.Item(fg.Row, "TipoMovimiento"), fg.Item(fg.Row, "TipoCuenta"), fg.Item(fg.Row, "IdCuenta"), fg.Item(fg.Row, "Fecha"))
                dsDetalle.Clear()
                dsDetalle = ds.Copy
                fg.DataSource = dsDetalle.Tables(0)
                Encabezado()
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtIdCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtIdCuenta.TextChanged

    End Sub

    Private Sub c1txtObservaciones_TextChanged(sender As Object, e As EventArgs) Handles c1txtObservaciones.TextChanged

    End Sub

    Private Sub c1txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles c1txtCuenta.TextChanged

    End Sub

    Private Sub dtpFechaEmision_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEmision.ValueChanged

    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        Me.chkTodos.Checked = False
        If Me.txtUsuario.Text.Trim = "" Then Exit Sub
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
            ds = oAh.ConsultarTransferencia("distinct a.CodTransferencia,a.Fecha,a.NoDocumento,a.NoSocio,a.Dui,a.NoSocio,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,ValorTransferencia as Valor,Observacion,a.Responsable,a.Estado", "a.Responsable like '%" & Me.txtUsuario.Text.Trim & "%'", "a.Fecha desc,a.CodTransferencia", 3, sUsuario, sPassword, sSucursal)
            Me.fgAnulaciones.DataSource = ds.Tables(0)
            EncabezadoAnulaciones()
        End If
    End Sub

    Private Sub dtpFechaEmision_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaEmision.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.chkTodos.Checked = False
            Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
            ds = oAh.ConsultarTransferencia("distinct a.CodTransferencia,a.Fecha,a.NoDocumento,a.NoSocio,a.Dui,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,ValorTransferencia as Valor,Observacion,a.Responsable,a.Estado", "a.Fecha='" & Me.dtpFechaEmision.Value.ToShortDateString & "'", "a.Fecha desc,a.CodTransferencia", 3, sUsuario, sPassword, sSucursal)
            Me.fgAnulaciones.DataSource = ds.Tables(0)
            EncabezadoAnulaciones()
        End If
    End Sub

    Private Sub chkTodos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTodos.LostFocus
        If Me.chkTodos.Checked = True Then
            Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
            ds = oAh.ConsultarTransferencia("distinct a.CodTransferencia,a.Fecha,a.NoDocumento,a.NoSocio,a.Dui,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,ValorTransferencia as Valor,Observacion,a.Responsable,a.Estado", "", "a.Fecha desc,a.CodTransferencia", 3, sUsuario, sPassword, sSucursal)
            Me.fgAnulaciones.DataSource = ds.Tables(0)
            EncabezadoAnulaciones()
        End If
    End Sub

    Private Sub EncabezadoAnulaciones()

        fgAnulaciones.Cols.Item(1).Caption = "No.Transferencia"
        fgAnulaciones.Cols.Item(2).Caption = "Fecha"
        fgAnulaciones.Cols.Item(3).Caption = "No. Documento"
        fgAnulaciones.Cols.Item(4).Caption = "No. Socio"
        fgAnulaciones.Cols.Item(5).Caption = "Dui"
        fgAnulaciones.Cols.Item(6).Caption = "Nombre"
        fgAnulaciones.Cols.Item(7).Caption = "Valor"
        fgAnulaciones.Cols.Item(8).Caption = "Observación"
        fgAnulaciones.Cols.Item(9).Caption = "Responsable"
        fgAnulaciones.Cols.Item(10).Caption = "Estado"
        fgAnulaciones.Cols.Item(7).Format = "##0.00"

        fgAnulaciones.Cols.Item(1).Width = 100
        fgAnulaciones.Cols.Item(2).Width = 100
        fgAnulaciones.Cols.Item(3).Width = 100
        fgAnulaciones.Cols.Item(4).Width = 77
        fgAnulaciones.Cols.Item(5).Width = 77
        fgAnulaciones.Cols.Item(6).Width = 150
        fgAnulaciones.Cols.Item(7).Width = 100
        fgAnulaciones.Cols.Item(8).Width = 200
        fgAnulaciones.Cols.Item(9).Width = 100
        fgAnulaciones.Cols.Item(10).Width = 100

    End Sub

    Private Sub fgAnulaciones_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgAnulaciones.DoubleClick
        Try
            Dim ofrm As New frmMsCAConsultaTransferencia
            ofrm.pCodTransferencia = fgAnulaciones.Item(fgAnulaciones.Row, "CodTransferencia")
            ofrm.txtResponsable.Text = fgAnulaciones.Item(fgAnulaciones.Row, "Responsable")
            ofrm.txtNoSocio.Text = fgAnulaciones.Item(fgAnulaciones.Row, "NoSocio")
            ofrm.c1txtNombreAsoc.Value = fgAnulaciones.Item(fgAnulaciones.Row, "Nombres")
            ofrm.dtpFecha.Value = fgAnulaciones.Item(fgAnulaciones.Row, "Fecha")
            ofrm.c1txtNoDoc.Value = fgAnulaciones.Item(fgAnulaciones.Row, "NoDocumento")
            ofrm.txtDui.Value = fgAnulaciones.Item(fgAnulaciones.Row, "Dui")
            ofrm.c1txtObservaciones.Value = fgAnulaciones.Item(fgAnulaciones.Row, "Observacion")
            ofrm.c1txtMonto.Value = fgAnulaciones.Item(fgAnulaciones.Row, "Valor")
            ofrm.pEstado = fgAnulaciones.Item(fgAnulaciones.Row, "Estado")
            ofrm.ShowDialog()
            dtpFechaEmision_LostFocus(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fgAnulaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fgAnulaciones.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            fgAnulaciones_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub txtCuenta_DoubleClick(sender As Object, e As EventArgs) Handles txtCuenta.DoubleClick

    End Sub
End Class