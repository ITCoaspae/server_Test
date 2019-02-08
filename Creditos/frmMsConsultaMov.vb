Public Class frmMsConsultaMov
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private oPrestamo As DataSet

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

    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid  'C1.Win.C1FlexGrid.Classic2
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIntPag As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtIntMora As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCapitalMora As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFecha1aCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents fg1 As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtFechaOtorgamiento As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtTasaInt As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtFechaVencimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtDiaPago As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtMontoGarantia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtFechaUltMov As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents c1nCuota As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoCtasOrden As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.fg1 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSaldoCtasOrden = New C1.Win.C1Input.C1NumericEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c1nCuota = New C1.Win.C1Input.C1NumericEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtFechaUltMov = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtMontoGarantia = New C1.Win.C1Input.C1NumericEdit()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtDiaPago = New C1.Win.C1Input.C1NumericEdit()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtFechaVencimiento = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtTasaInt = New C1.Win.C1Input.C1NumericEdit()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtFechaOtorgamiento = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIntPag = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.txtIntMora = New C1.Win.C1Input.C1NumericEdit()
        Me.txtCapitalMora = New C1.Win.C1Input.C1NumericEdit()
        Me.txtSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFecha1aCuota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.fg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSaldoCtasOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoGarantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasaInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCapitalMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Teal
        Me.Label20.Location = New System.Drawing.Point(6, 322)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(200, 16)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Movimientos:"
        '
        'fg1
        '
        Me.fg1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
        Me.fg1.BackColor = System.Drawing.SystemColors.Window
        Me.fg1.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fg1.BackColorBkg = System.Drawing.SystemColors.AppWorkspace
        Me.fg1.BackColorFixed = System.Drawing.Color.Teal
        Me.fg1.BackColorSel = System.Drawing.SystemColors.Highlight
        Me.fg1.Cols = 2
        Me.fg1.ColumnInfo = "2,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        'Me.fg1.ExplorerBar = CType(((C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExSort Or C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExMove) _
        '    Or C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.4),C1.Win.C1FlexGrid.Classic.ExplorerBarSettings)
        Me.fg1.ForeColorFixed = System.Drawing.Color.White
        Me.fg1.ForeColorSel = System.Drawing.SystemColors.HighlightText
        Me.fg1.GridColor = System.Drawing.SystemColors.Control
        Me.fg1.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fg1.Location = New System.Drawing.Point(6, 341)
        Me.fg1.Name = "fg1"
        Me.fg1.NodeClosedPicture = Nothing
        Me.fg1.NodeOpenPicture = Nothing
        Me.fg1.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarSimple
        Me.fg1.OutlineCol = -1
        Me.fg1.Rows = 2
        Me.fg1.SheetBorder = System.Drawing.SystemColors.WindowText
        Me.fg1.Size = New System.Drawing.Size(636, 235)
        Me.fg1.TabIndex = 6
        Me.fg1.TreeColor = System.Drawing.Color.DarkGray
        Me.fg1.WallPaper = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.fg1)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtSaldoCtasOrden)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.c1nCuota)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.txtFechaUltMov)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.txtMontoGarantia)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtDiaPago)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtPlazo)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtFechaVencimiento)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.txtTasaInt)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.txtFechaOtorgamiento)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtMensaje)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIntPag)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtIntMora)
        Me.GroupBox1.Controls.Add(Me.txtCapitalMora)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtFecha1aCuota)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAsociado)
        Me.GroupBox1.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 600)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtSaldoCtasOrden
        '
        Me.txtSaldoCtasOrden.BackColor = System.Drawing.Color.White
        Me.txtSaldoCtasOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoCtasOrden.Culture = 17418
        Me.txtSaldoCtasOrden.CustomFormat = "#0.00"
        Me.txtSaldoCtasOrden.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoCtasOrden.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSaldoCtasOrden.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSaldoCtasOrden.Location = New System.Drawing.Point(294, 202)
        Me.txtSaldoCtasOrden.Name = "txtSaldoCtasOrden"
        Me.txtSaldoCtasOrden.ReadOnly = True
        Me.txtSaldoCtasOrden.ShowDropDownButton = False
        Me.txtSaldoCtasOrden.ShowUpDownButtons = False
        Me.txtSaldoCtasOrden.Size = New System.Drawing.Size(112, 21)
        Me.txtSaldoCtasOrden.TabIndex = 207
        Me.txtSaldoCtasOrden.Tag = Nothing
        Me.txtSaldoCtasOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldoCtasOrden.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(222, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 206
        Me.Label7.Text = "Ctas. Orden:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'c1nCuota
        '
        Me.c1nCuota.BackColor = System.Drawing.Color.White
        Me.c1nCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCuota.Culture = 17418
        Me.c1nCuota.CustomFormat = "#0.00"
        Me.c1nCuota.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCuota.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nCuota.Location = New System.Drawing.Point(530, 175)
        Me.c1nCuota.Name = "c1nCuota"
        Me.c1nCuota.ReadOnly = True
        Me.c1nCuota.ShowDropDownButton = False
        Me.c1nCuota.ShowUpDownButtons = False
        Me.c1nCuota.Size = New System.Drawing.Size(112, 21)
        Me.c1nCuota.TabIndex = 205
        Me.c1nCuota.Tag = Nothing
        Me.c1nCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nCuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(412, 172)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(56, 16)
        Me.Label33.TabIndex = 204
        Me.Label33.Text = "Cuota:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaUltMov
        '
        Me.txtFechaUltMov.BackColor = System.Drawing.Color.White
        Me.txtFechaUltMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaUltMov.Location = New System.Drawing.Point(104, 202)
        Me.txtFechaUltMov.MaxLength = 8
        Me.txtFechaUltMov.Name = "txtFechaUltMov"
        Me.txtFechaUltMov.ReadOnly = True
        Me.txtFechaUltMov.Size = New System.Drawing.Size(112, 20)
        Me.txtFechaUltMov.TabIndex = 203
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(6, 204)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(68, 16)
        Me.Label32.TabIndex = 202
        Me.Label32.Text = "Último Pago:"
        '
        'txtMontoGarantia
        '
        Me.txtMontoGarantia.BackColor = System.Drawing.Color.White
        Me.txtMontoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoGarantia.Culture = 17418
        Me.txtMontoGarantia.CustomFormat = "#0.00"
        Me.txtMontoGarantia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoGarantia.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMontoGarantia.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtMontoGarantia.Location = New System.Drawing.Point(530, 148)
        Me.txtMontoGarantia.Name = "txtMontoGarantia"
        Me.txtMontoGarantia.ReadOnly = True
        Me.txtMontoGarantia.ShowDropDownButton = False
        Me.txtMontoGarantia.ShowUpDownButtons = False
        Me.txtMontoGarantia.Size = New System.Drawing.Size(112, 21)
        Me.txtMontoGarantia.TabIndex = 201
        Me.txtMontoGarantia.Tag = Nothing
        Me.txtMontoGarantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMontoGarantia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(412, 152)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 16)
        Me.Label31.TabIndex = 200
        Me.Label31.Text = "Monto Garantía:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiaPago
        '
        Me.txtDiaPago.BackColor = System.Drawing.Color.White
        Me.txtDiaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaPago.Culture = 17418
        Me.txtDiaPago.CustomFormat = "#,##0"
        Me.txtDiaPago.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaPago.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtDiaPago.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtDiaPago.Location = New System.Drawing.Point(104, 148)
        Me.txtDiaPago.Name = "txtDiaPago"
        Me.txtDiaPago.ReadOnly = True
        Me.txtDiaPago.ShowDropDownButton = False
        Me.txtDiaPago.ShowUpDownButtons = False
        Me.txtDiaPago.Size = New System.Drawing.Size(112, 21)
        Me.txtDiaPago.TabIndex = 199
        Me.txtDiaPago.Tag = Nothing
        Me.txtDiaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDiaPago.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(6, 154)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 16)
        Me.Label30.TabIndex = 198
        Me.Label30.Text = "Día Pago:"
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.Color.White
        Me.txtPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlazo.Culture = 17418
        Me.txtPlazo.CustomFormat = "#,##0.00"
        Me.txtPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtPlazo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtPlazo.Location = New System.Drawing.Point(294, 121)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.ShowDropDownButton = False
        Me.txtPlazo.ShowUpDownButtons = False
        Me.txtPlazo.Size = New System.Drawing.Size(112, 21)
        Me.txtPlazo.TabIndex = 197
        Me.txtPlazo.Tag = Nothing
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPlazo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(222, 121)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 16)
        Me.Label29.TabIndex = 196
        Me.Label29.Text = "Plazo:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.BackColor = System.Drawing.Color.White
        Me.txtFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(294, 95)
        Me.txtFechaVencimiento.MaxLength = 8
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.ReadOnly = True
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(112, 20)
        Me.txtFechaVencimiento.TabIndex = 195
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(222, 101)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 16)
        Me.Label28.TabIndex = 194
        Me.Label28.Text = "Vencimiento:"
        '
        'txtTasaInt
        '
        Me.txtTasaInt.BackColor = System.Drawing.Color.White
        Me.txtTasaInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTasaInt.Culture = 17418
        Me.txtTasaInt.CustomFormat = "#,##0.00"
        Me.txtTasaInt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaInt.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtTasaInt.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtTasaInt.Location = New System.Drawing.Point(104, 121)
        Me.txtTasaInt.Name = "txtTasaInt"
        Me.txtTasaInt.ReadOnly = True
        Me.txtTasaInt.ShowDropDownButton = False
        Me.txtTasaInt.ShowUpDownButtons = False
        Me.txtTasaInt.Size = New System.Drawing.Size(112, 21)
        Me.txtTasaInt.TabIndex = 193
        Me.txtTasaInt.Tag = Nothing
        Me.txtTasaInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTasaInt.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(6, 121)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 16)
        Me.Label27.TabIndex = 192
        Me.Label27.Text = "Tasa Int.:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaOtorgamiento
        '
        Me.txtFechaOtorgamiento.BackColor = System.Drawing.Color.White
        Me.txtFechaOtorgamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaOtorgamiento.Location = New System.Drawing.Point(530, 67)
        Me.txtFechaOtorgamiento.MaxLength = 8
        Me.txtFechaOtorgamiento.Name = "txtFechaOtorgamiento"
        Me.txtFechaOtorgamiento.ReadOnly = True
        Me.txtFechaOtorgamiento.Size = New System.Drawing.Size(112, 20)
        Me.txtFechaOtorgamiento.TabIndex = 191
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(412, 71)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(112, 16)
        Me.Label26.TabIndex = 190
        Me.Label26.Text = "Fecha Otorgamiento:"
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.White
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCategoria.Location = New System.Drawing.Point(294, 67)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(112, 20)
        Me.txtCategoria.TabIndex = 189
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(224, 71)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 16)
        Me.Label25.TabIndex = 188
        Me.Label25.Text = "Categoría:"
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.ForeColor = System.Drawing.Color.Navy
        Me.txtMensaje.Location = New System.Drawing.Point(9, 242)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(633, 24)
        Me.txtMensaje.TabIndex = 187
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(9, 287)
        Me.txtObs.MaxLength = 0
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ReadOnly = True
        Me.txtObs.Size = New System.Drawing.Size(633, 32)
        Me.txtObs.TabIndex = 186
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(6, 269)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 16)
        Me.Label24.TabIndex = 185
        Me.Label24.Text = "Observaciones:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(570, 19)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(72, 20)
        Me.txtNoSocio.TabIndex = 182
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(484, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "No. Asociado:"
        '
        'txtIntPag
        '
        Me.txtIntPag.BackColor = System.Drawing.Color.White
        Me.txtIntPag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntPag.Culture = 17418
        Me.txtIntPag.CustomFormat = "#,##0.00"
        Me.txtIntPag.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntPag.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtIntPag.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtIntPag.Location = New System.Drawing.Point(530, 121)
        Me.txtIntPag.Name = "txtIntPag"
        Me.txtIntPag.ReadOnly = True
        Me.txtIntPag.ShowDropDownButton = False
        Me.txtIntPag.ShowUpDownButtons = False
        Me.txtIntPag.Size = New System.Drawing.Size(112, 21)
        Me.txtIntPag.TabIndex = 155
        Me.txtIntPag.Tag = Nothing
        Me.txtIntPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIntPag.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(412, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Int. Pagados:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Culture = 17418
        Me.txtMonto.CustomFormat = "#0.00"
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMonto.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtMonto.Location = New System.Drawing.Point(294, 148)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.ShowDropDownButton = False
        Me.txtMonto.ShowUpDownButtons = False
        Me.txtMonto.Size = New System.Drawing.Size(112, 21)
        Me.txtMonto.TabIndex = 146
        Me.txtMonto.Tag = Nothing
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtIntMora
        '
        Me.txtIntMora.BackColor = System.Drawing.Color.White
        Me.txtIntMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntMora.Culture = 17418
        Me.txtIntMora.CustomFormat = "#0.00"
        Me.txtIntMora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntMora.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtIntMora.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtIntMora.Location = New System.Drawing.Point(294, 175)
        Me.txtIntMora.Name = "txtIntMora"
        Me.txtIntMora.ReadOnly = True
        Me.txtIntMora.ShowDropDownButton = False
        Me.txtIntMora.ShowUpDownButtons = False
        Me.txtIntMora.Size = New System.Drawing.Size(112, 21)
        Me.txtIntMora.TabIndex = 144
        Me.txtIntMora.Tag = Nothing
        Me.txtIntMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIntMora.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtCapitalMora
        '
        Me.txtCapitalMora.BackColor = System.Drawing.Color.White
        Me.txtCapitalMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCapitalMora.Culture = 17418
        Me.txtCapitalMora.CustomFormat = "#,##0.00"
        Me.txtCapitalMora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapitalMora.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCapitalMora.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtCapitalMora.Location = New System.Drawing.Point(104, 175)
        Me.txtCapitalMora.Name = "txtCapitalMora"
        Me.txtCapitalMora.ReadOnly = True
        Me.txtCapitalMora.ShowDropDownButton = False
        Me.txtCapitalMora.ShowUpDownButtons = False
        Me.txtCapitalMora.Size = New System.Drawing.Size(112, 21)
        Me.txtCapitalMora.TabIndex = 143
        Me.txtCapitalMora.Tag = Nothing
        Me.txtCapitalMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCapitalMora.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.Culture = 17418
        Me.txtSaldo.CustomFormat = "#0.00"
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSaldo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSaldo.Location = New System.Drawing.Point(530, 93)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.ShowDropDownButton = False
        Me.txtSaldo.ShowUpDownButtons = False
        Me.txtSaldo.Size = New System.Drawing.Size(112, 21)
        Me.txtSaldo.TabIndex = 142
        Me.txtSaldo.Tag = Nothing
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(104, 16)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(96, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Location = New System.Drawing.Point(6, 228)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(636, 8)
        Me.Panel3.TabIndex = 132
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(222, 172)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "Int.Mora:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(6, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 20)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "Capital Mora:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(412, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 16)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "Saldo:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(222, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Monto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFecha1aCuota
        '
        Me.txtFecha1aCuota.BackColor = System.Drawing.Color.White
        Me.txtFecha1aCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha1aCuota.Location = New System.Drawing.Point(104, 95)
        Me.txtFecha1aCuota.MaxLength = 8
        Me.txtFecha1aCuota.Name = "txtFecha1aCuota"
        Me.txtFecha1aCuota.ReadOnly = True
        Me.txtFecha1aCuota.Size = New System.Drawing.Size(112, 20)
        Me.txtFecha1aCuota.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "1a.Cuota:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(104, 42)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(538, 21)
        Me.txtAsociado.TabIndex = 20
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamo.Location = New System.Drawing.Point(104, 69)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodPrestamo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Préstamo:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(6, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "DUI:"
        '
        'frmMsConsultaMov
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(712, 670)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsConsultaMov"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta Saldos - Movimientos"
        CType(Me.fg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtSaldoCtasOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoGarantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasaInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCapitalMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property Prestamo() As DataSet
        Get
            Return oPrestamo
        End Get
        Set(ByVal Value As DataSet)
            oPrestamo = Value
        End Set
    End Property

    Private Sub frmMsConsProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCodPrestamo.Focus()
    End Sub

    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim sTexto As String
            Me.txtMensaje.Text = ""
            Me.txtObs.Text = ""
            Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, pTotal As Decimal
            Try
                oPrest = New wrPrestamo.wsLibPrest
                sTexto = Me.txtCodPrestamo.Text
                If sTexto = "" Then

                ElseIf sTexto <> "" Then
                    ds = oPrest.CargaDatosPrestamoxRangoCB(sTexto, Now, Now, "Cancelada='S'", sUsuario, sPassword, sSucursal)
                    Me.Prestamo = ds
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                    Me.txtMonto.Value = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
                    If Not IsDBNull(dr("FechaPrimeraCuota")) Then
                        Me.txtFecha1aCuota.Text = dr("FechaPrimeraCuota")
                    End If
                    Me.txtAsociado.Text = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
                    Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
                    Me.txtSaldo.Value = IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital"))
                    If IIf(IsDBNull(dr("DiaGracia")), "N", dr("DiaGracia")) = "S" Then
                        Me.txtCapitalMora.Value = IIf(IsDBNull(dr("Saldo_CapMoraGracia")), 0, dr("Saldo_CapMoraGracia"))
                        Me.txtIntMora.Value = IIf(IsDBNull(dr("Saldo_IntMoraGracia")), 0, dr("Saldo_IntMoraGracia"))
                    Else
                        Me.txtCapitalMora.Value = IIf(IsDBNull(dr("SaldoDia_CapitalMora")), 0, dr("SaldoDia_CapitalMora"))
                        Me.txtIntMora.Value = IIf(IsDBNull(dr("SaldoDia_InteresMora")), 0, dr("SaldoDia_InteresMora"))
                    End If
                    Me.txtIntPag.Value = IIf(IsDBNull(dr("Intereses_Pagados")), 0, dr("Intereses_Pagados"))
                    Me.txtObs.Text = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))

                    Me.txtFechaOtorgamiento.Text = dr("FechaOtorgamiento")
                    Me.txtFechaUltMov.Text = IIf(IsDBNull(dr("FechaUltimoPago")), Now, dr("FechaUltimoPago")) 'dr("FechaUltimoPago")
                    Me.txtFechaVencimiento.Text = dr("FechaVencimiento")
                    Me.txtCategoria.Text = dr("Categoria")
                    Me.txtPlazo.Value = dr("PlazoMeses")
                    Me.txtTasaInt.Value = dr("Tasa_Interes")
                    Me.txtMontoGarantia.Value = dr("Monto_Garantia")
                    Me.txtDiaPago.Value = CDate(dr("FechaPrimeraCuota")).Day
                    Me.c1nCuota.Value = dr("CuotaTotal")

                    fg1.DataSource = ds.Tables("Pagos")

                    Dim oCred As New wrCredito.wsLibCred, dsCB As New DataSet
                    dsCB = oCred.ConsultarCBDocumentosxRecuperar("TipoDocumento,SaldoCuentasOrden", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                    If dsCB.Tables(0).Rows.Count > 0 Then
                        dr = dsCB.Tables(0).Rows(0)
                        If IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "C" Then 'C: Documentos x Cobrar
                            Me.txtMensaje.Text = "Ver Cuentas por Cobrar"
                        ElseIf IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "P" Then 'P: Documentos en Protesto
                            Me.txtMensaje.Text = "Cobro Judicial --> ¡¡Informe a Cobros!!"
                        ElseIf IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "S" Then 'S: Documentos Saneados
                            Me.txtMensaje.Text = "Documento Saneado"
                        End If
                        Me.txtSaldoCtasOrden.Value = IIf(dr("SaldoCuentasOrden") Is DBNull.Value, 0, dr("SaldoCuentasOrden"))
                    End If

                    Encabezado()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.CargarListaPrestamosCB(False, "", "", Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                txtCodPrestamo.Text = sTexto.Trim
                txtCodPrestamo_LostFocus(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Encabezado()

        Me.fg1.ColumnCollection(6).Format = "##0.00"
        Me.fg1.ColumnCollection(7).Format = "##0.00"
        Me.fg1.ColumnCollection(8).Format = "##0.00"
        Me.fg1.ColumnCollection(9).Format = "##0.00"
        Me.fg1.ColumnCollection(10).Format = "##0.00"
        Me.fg1.ColumnCollection(11).Format = "##0.00"
        Me.fg1.ColumnCollection(12).Format = "##0.00"
        Me.fg1.ColumnCollection(13).Format = "##0.00"
        Me.fg1.ColumnCollection(14).Format = "##0.00"
        Me.fg1.ColumnCollection(15).Format = "##0.00"
        Me.fg1.ColumnCollection(16).Format = "##0.00"
        Me.fg1.ColumnCollection(17).Format = "##0.00"
        Me.fg1.ColumnCollection(18).Format = "##0.00"
        Me.fg1.ColumnCollection(22).Format = "##0.00"
        Me.fg1.ColumnCollection(23).Format = "##0.00"
        Me.fg1.ColumnCollection(24).Format = "##0.00"
        Me.fg1.ColumnCollection(25).Format = "##0.00"

    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Dim sTexto As String

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Text.Trim
            If sTexto = "" Then      'Filtrar Registros

            ElseIf sTexto <> "" Then

                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
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
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = dr("NoSocio")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPrestamo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.LostFocus
        Dim sTexto As String
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, pTotal As Decimal
        Try
            Me.txtMensaje.Text = ""
            Me.txtObs.Text = ""
            oPrest = New wrPrestamo.wsLibPrest
            sTexto = Me.txtCodPrestamo.Text
            If sTexto = "" Then

            ElseIf sTexto <> "" Then
                ds = oPrest.CargaDatosPrestamoxRangoCB(sTexto, Now, Now, "Cancelada='S'", sUsuario, sPassword, sSucursal)
                Me.Prestamo = ds
                dr = ds.Tables(0).Rows(0)
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                Me.txtMonto.Value = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
                If Not IsDBNull(dr("FechaPrimeraCuota")) Then
                    Me.txtFecha1aCuota.Text = dr("FechaPrimeraCuota")
                End If
                Me.txtAsociado.Text = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
                Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
                Me.txtSaldo.Value = IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital"))
                If IIf(IsDBNull(dr("DiaGracia")), "N", dr("DiaGracia")) = "S" Then
                    Me.txtCapitalMora.Value = IIf(IsDBNull(dr("Saldo_CapMoraGracia")), 0, dr("Saldo_CapMoraGracia"))
                    Me.txtIntMora.Value = IIf(IsDBNull(dr("Saldo_IntMoraGracia")), 0, dr("Saldo_IntMoraGracia"))
                Else
                    Me.txtCapitalMora.Value = IIf(IsDBNull(dr("SaldoDia_CapitalMora")), 0, dr("SaldoDia_CapitalMora"))
                    Me.txtIntMora.Value = IIf(IsDBNull(dr("SaldoDia_InteresMora")), 0, dr("SaldoDia_InteresMora"))
                End If
                Me.txtIntPag.Value = IIf(IsDBNull(dr("Intereses_Pagados")), 0, dr("Intereses_Pagados"))
                Me.txtObs.Text = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))

                Me.txtFechaOtorgamiento.Text = dr("FechaOtorgamiento")
                Me.txtFechaUltMov.Text = IIf(IsDBNull(dr("FechaUltimoPago")), Now, dr("FechaUltimoPago")) 'dr("FechaUltimoPago")
                Me.txtFechaVencimiento.Text = dr("FechaVencimiento")
                Me.txtCategoria.Text = dr("Categoria")
                Me.txtPlazo.Value = dr("PlazoMeses")
                Me.txtTasaInt.Value = dr("Tasa_Interes")
                Me.txtMontoGarantia.Value = dr("Monto_Garantia")
                Me.txtDiaPago.Value = CDate(dr("FechaPrimeraCuota")).Day
                Me.c1nCuota.Value = dr("CuotaTotal")

                fg1.DataSource = ds.Tables("Pagos")

                Dim oCred As New wrCredito.wsLibCred, dsCB As New DataSet
                dsCB = oCred.ConsultarCBDocumentosxRecuperar("TipoDocumento,SaldoCuentasOrden", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                If dsCB.Tables(0).Rows.Count > 0 Then
                    dr = dsCB.Tables(0).Rows(0)
                    If IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "C" Then 'C: Documentos x Cobrar
                        Me.txtMensaje.Text = "Ver Cuentas por Cobrar"
                    ElseIf IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "P" Then 'P: Documentos en Protesto
                        Me.txtMensaje.Text = "Cobro Judicial --> ¡¡Informe a Cobros!!"
                    ElseIf IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "S" Then 'S: Documentos Saneados
                        Me.txtMensaje.Text = "Documento Saneado"
                    End If
                    Me.txtSaldoCtasOrden.Value = IIf(dr("SaldoCuentasOrden") Is DBNull.Value, 0, dr("SaldoCuentasOrden"))
                End If
                Encabezado()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class