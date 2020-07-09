Public Class frmMsConsProv
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents lblArreglo As System.Windows.Forms.Label
    Friend WithEvents btnProv1 As MetroFramework.Controls.MetroButton
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSaldoOtros As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtComisionxManejo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtAhorro As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtAportacion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtSeguroDesempleo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtSeguroVida As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtSeguroDanios As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtSeguroDeuda As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtIntereses As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtIntPag As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents fg2 As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg1 As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents c1nTotal As C1.Win.C1Input.C1NumericEdit
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
    Friend WithEvents txtCasoEspecial As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsConsProv))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.fg1 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblArreglo = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtCasoEspecial = New System.Windows.Forms.TextBox()
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
        Me.c1nTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldoOtros = New C1.Win.C1Input.C1NumericEdit()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtComisionxManejo = New C1.Win.C1Input.C1NumericEdit()
        Me.txtAhorro = New C1.Win.C1Input.C1NumericEdit()
        Me.txtAportacion = New C1.Win.C1Input.C1NumericEdit()
        Me.txtSeguroDesempleo = New C1.Win.C1Input.C1NumericEdit()
        Me.txtSeguroVida = New C1.Win.C1Input.C1NumericEdit()
        Me.txtSeguroDanios = New C1.Win.C1Input.C1NumericEdit()
        Me.txtSeguroDeuda = New C1.Win.C1Input.C1NumericEdit()
        Me.txtIntereses = New C1.Win.C1Input.C1NumericEdit()
        Me.txtIntPag = New C1.Win.C1Input.C1NumericEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnProv1 = New MetroFramework.Controls.MetroButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpR2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpR1 = New System.Windows.Forms.DateTimePicker()
        Me.fg2 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.fg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoGarantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTasaInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComisionxManejo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAhorro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeguroDesempleo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeguroVida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeguroDanios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeguroDeuda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntereses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntPag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCapitalMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(28, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(912, 739)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.fg1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(904, 710)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Saldos - Movimientos"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 482)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(240, 19)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Movimientos:"
        '
        'fg1
        '
        Me.fg1.BackColorAlternate = System.Drawing.Color.White
        Me.fg1.BackColorFixed = System.Drawing.Color.Teal
        Me.fg1.Cols = 2
        Me.fg1.ColumnInfo = "2,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg1.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fg1.Location = New System.Drawing.Point(0, 504)
        Me.fg1.Name = "fg1"
        Me.fg1.NodeClosedPicture = Nothing
        Me.fg1.NodeOpenPicture = Nothing
        Me.fg1.OutlineCol = -1
        Me.fg1.Rows = 2
        Me.fg1.SheetBorder = System.Drawing.SystemColors.WindowText
        Me.fg1.Size = New System.Drawing.Size(883, 202)
        Me.fg1.StyleInfo = resources.GetString("fg1.StyleInfo")
        Me.fg1.TabIndex = 6
        Me.fg1.TreeColor = System.Drawing.Color.DarkGray
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblArreglo)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtCasoEspecial)
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
        Me.GroupBox1.Controls.Add(Me.c1nTotal)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSaldoOtros)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtComisionxManejo)
        Me.GroupBox1.Controls.Add(Me.txtAhorro)
        Me.GroupBox1.Controls.Add(Me.txtAportacion)
        Me.GroupBox1.Controls.Add(Me.txtSeguroDesempleo)
        Me.GroupBox1.Controls.Add(Me.txtSeguroVida)
        Me.GroupBox1.Controls.Add(Me.txtSeguroDanios)
        Me.GroupBox1.Controls.Add(Me.txtSeguroDeuda)
        Me.GroupBox1.Controls.Add(Me.txtIntereses)
        Me.GroupBox1.Controls.Add(Me.txtIntPag)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
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
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(883, 470)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'lblArreglo
        '
        Me.lblArreglo.AutoSize = True
        Me.lblArreglo.BackColor = System.Drawing.Color.Teal
        Me.lblArreglo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArreglo.ForeColor = System.Drawing.Color.White
        Me.lblArreglo.Location = New System.Drawing.Point(703, 410)
        Me.lblArreglo.Name = "lblArreglo"
        Me.lblArreglo.Size = New System.Drawing.Size(66, 17)
        Me.lblArreglo.TabIndex = 208
        Me.lblArreglo.Text = "Label34"
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.Teal
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.Color.White
        Me.txtEstado.Location = New System.Drawing.Point(518, 406)
        Me.txtEstado.Multiline = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(173, 19)
        Me.txtEstado.TabIndex = 207
        '
        'txtCasoEspecial
        '
        Me.txtCasoEspecial.BackColor = System.Drawing.Color.White
        Me.txtCasoEspecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCasoEspecial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCasoEspecial.ForeColor = System.Drawing.Color.Red
        Me.txtCasoEspecial.Location = New System.Drawing.Point(16, 374)
        Me.txtCasoEspecial.Multiline = True
        Me.txtCasoEspecial.Name = "txtCasoEspecial"
        Me.txtCasoEspecial.Size = New System.Drawing.Size(858, 28)
        Me.txtCasoEspecial.TabIndex = 206
        Me.txtCasoEspecial.Visible = False
        '
        'c1nCuota
        '
        Me.c1nCuota.BackColor = System.Drawing.Color.White
        Me.c1nCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCuota.Culture = 17418
        Me.c1nCuota.CustomFormat = "#0.00"
        Me.c1nCuota.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCuota.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nCuota.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nCuota.Location = New System.Drawing.Point(698, 172)
        Me.c1nCuota.Name = "c1nCuota"
        Me.c1nCuota.ReadOnly = True
        Me.c1nCuota.Size = New System.Drawing.Size(176, 26)
        Me.c1nCuota.TabIndex = 205
        Me.c1nCuota.Tag = Nothing
        Me.c1nCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nCuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCuota.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(586, 170)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(67, 18)
        Me.Label33.TabIndex = 204
        Me.Label33.Text = "Cuota:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaUltMov
        '
        Me.txtFechaUltMov.BackColor = System.Drawing.Color.White
        Me.txtFechaUltMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaUltMov.Location = New System.Drawing.Point(96, 202)
        Me.txtFechaUltMov.MaxLength = 8
        Me.txtFechaUltMov.Name = "txtFechaUltMov"
        Me.txtFechaUltMov.ReadOnly = True
        Me.txtFechaUltMov.Size = New System.Drawing.Size(175, 22)
        Me.txtFechaUltMov.TabIndex = 203
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(12, 204)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(79, 19)
        Me.Label32.TabIndex = 202
        Me.Label32.Text = "Úlimo Pago:"
        '
        'txtMontoGarantia
        '
        Me.txtMontoGarantia.BackColor = System.Drawing.Color.White
        Me.txtMontoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoGarantia.Culture = 17418
        Me.txtMontoGarantia.CustomFormat = "#0.00"
        Me.txtMontoGarantia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoGarantia.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMontoGarantia.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtMontoGarantia.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtMontoGarantia.Location = New System.Drawing.Point(698, 141)
        Me.txtMontoGarantia.Name = "txtMontoGarantia"
        Me.txtMontoGarantia.ReadOnly = True
        Me.txtMontoGarantia.Size = New System.Drawing.Size(176, 26)
        Me.txtMontoGarantia.TabIndex = 201
        Me.txtMontoGarantia.Tag = Nothing
        Me.txtMontoGarantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMontoGarantia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoGarantia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(586, 140)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(105, 18)
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
        Me.txtDiaPago.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtDiaPago.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtDiaPago.Location = New System.Drawing.Point(96, 140)
        Me.txtDiaPago.Name = "txtDiaPago"
        Me.txtDiaPago.ReadOnly = True
        Me.txtDiaPago.Size = New System.Drawing.Size(175, 26)
        Me.txtDiaPago.TabIndex = 199
        Me.txtDiaPago.Tag = Nothing
        Me.txtDiaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDiaPago.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDiaPago.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(12, 143)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(67, 19)
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
        Me.txtPlazo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtPlazo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtPlazo.Location = New System.Drawing.Point(406, 108)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.Size = New System.Drawing.Size(172, 27)
        Me.txtPlazo.TabIndex = 197
        Me.txtPlazo.Tag = Nothing
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPlazo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(278, 108)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 19)
        Me.Label29.TabIndex = 196
        Me.Label29.Text = "Plazo:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.BackColor = System.Drawing.Color.White
        Me.txtFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(406, 78)
        Me.txtFechaVencimiento.MaxLength = 8
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.ReadOnly = True
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(172, 22)
        Me.txtFechaVencimiento.TabIndex = 195
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(278, 78)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(116, 19)
        Me.Label28.TabIndex = 194
        Me.Label28.Text = "Fec. Vencimiento:"
        '
        'txtTasaInt
        '
        Me.txtTasaInt.BackColor = System.Drawing.Color.White
        Me.txtTasaInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTasaInt.Culture = 17418
        Me.txtTasaInt.CustomFormat = "#,##0.00"
        Me.txtTasaInt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaInt.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtTasaInt.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtTasaInt.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtTasaInt.Location = New System.Drawing.Point(96, 108)
        Me.txtTasaInt.Name = "txtTasaInt"
        Me.txtTasaInt.ReadOnly = True
        Me.txtTasaInt.Size = New System.Drawing.Size(175, 27)
        Me.txtTasaInt.TabIndex = 193
        Me.txtTasaInt.Tag = Nothing
        Me.txtTasaInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTasaInt.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTasaInt.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(12, 108)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 19)
        Me.Label27.TabIndex = 192
        Me.Label27.Text = "Tasa Int.:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaOtorgamiento
        '
        Me.txtFechaOtorgamiento.BackColor = System.Drawing.Color.White
        Me.txtFechaOtorgamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFechaOtorgamiento.Location = New System.Drawing.Point(406, 48)
        Me.txtFechaOtorgamiento.MaxLength = 8
        Me.txtFechaOtorgamiento.Name = "txtFechaOtorgamiento"
        Me.txtFechaOtorgamiento.ReadOnly = True
        Me.txtFechaOtorgamiento.Size = New System.Drawing.Size(172, 22)
        Me.txtFechaOtorgamiento.TabIndex = 191
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(272, 53)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(135, 19)
        Me.Label26.TabIndex = 190
        Me.Label26.Text = "Fecha Otorgamiento:"
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.White
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCategoria.Location = New System.Drawing.Point(96, 48)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(175, 23)
        Me.txtCategoria.TabIndex = 189
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(12, 45)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 18)
        Me.Label25.TabIndex = 188
        Me.Label25.Text = "Categoría:"
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.ForeColor = System.Drawing.Color.Navy
        Me.txtMensaje.Location = New System.Drawing.Point(16, 339)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(858, 28)
        Me.txtMensaje.TabIndex = 187
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(10, 432)
        Me.txtObs.MaxLength = 0
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ReadOnly = True
        Me.txtObs.Size = New System.Drawing.Size(864, 31)
        Me.txtObs.TabIndex = 186
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(10, 410)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(115, 18)
        Me.Label24.TabIndex = 185
        Me.Label24.Text = "Observaciones:"
        '
        'c1nTotal
        '
        Me.c1nTotal.BackColor = System.Drawing.Color.White
        Me.c1nTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotal.Culture = 17418
        Me.c1nTotal.CustomFormat = "#0.00"
        Me.c1nTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotal.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nTotal.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nTotal.Location = New System.Drawing.Point(406, 202)
        Me.c1nTotal.Name = "c1nTotal"
        Me.c1nTotal.ReadOnly = True
        Me.c1nTotal.Size = New System.Drawing.Size(172, 26)
        Me.c1nTotal.TabIndex = 184
        Me.c1nTotal.Tag = Nothing
        Me.c1nTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.c1nTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(278, 204)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 19)
        Me.Label23.TabIndex = 183
        Me.Label23.Text = "Total:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(276, 18)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(86, 23)
        Me.txtNoSocio.TabIndex = 182
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(173, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "No. Asociado:"
        '
        'txtSaldoOtros
        '
        Me.txtSaldoOtros.BackColor = System.Drawing.Color.White
        Me.txtSaldoOtros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoOtros.Culture = 17418
        Me.txtSaldoOtros.CustomFormat = "#,##0.00"
        Me.txtSaldoOtros.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoOtros.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSaldoOtros.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtSaldoOtros.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSaldoOtros.Location = New System.Drawing.Point(698, 308)
        Me.txtSaldoOtros.Name = "txtSaldoOtros"
        Me.txtSaldoOtros.ReadOnly = True
        Me.txtSaldoOtros.Size = New System.Drawing.Size(176, 27)
        Me.txtSaldoOtros.TabIndex = 166
        Me.txtSaldoOtros.Tag = Nothing
        Me.txtSaldoOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldoOtros.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldoOtros.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(586, 308)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 19)
        Me.Label19.TabIndex = 165
        Me.Label19.Text = "Otros:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(278, 308)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 19)
        Me.Label18.TabIndex = 164
        Me.Label18.Text = "Comisión Manejo:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtComisionxManejo
        '
        Me.txtComisionxManejo.BackColor = System.Drawing.Color.White
        Me.txtComisionxManejo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComisionxManejo.Culture = 17418
        Me.txtComisionxManejo.CustomFormat = "#,##0.00"
        Me.txtComisionxManejo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComisionxManejo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtComisionxManejo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtComisionxManejo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtComisionxManejo.Location = New System.Drawing.Point(406, 308)
        Me.txtComisionxManejo.Name = "txtComisionxManejo"
        Me.txtComisionxManejo.ReadOnly = True
        Me.txtComisionxManejo.Size = New System.Drawing.Size(172, 27)
        Me.txtComisionxManejo.TabIndex = 163
        Me.txtComisionxManejo.Tag = Nothing
        Me.txtComisionxManejo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtComisionxManejo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtComisionxManejo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtAhorro
        '
        Me.txtAhorro.BackColor = System.Drawing.Color.White
        Me.txtAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAhorro.Culture = 17418
        Me.txtAhorro.CustomFormat = "#,##0.00"
        Me.txtAhorro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAhorro.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtAhorro.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtAhorro.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtAhorro.Location = New System.Drawing.Point(96, 308)
        Me.txtAhorro.Name = "txtAhorro"
        Me.txtAhorro.ReadOnly = True
        Me.txtAhorro.Size = New System.Drawing.Size(175, 27)
        Me.txtAhorro.TabIndex = 162
        Me.txtAhorro.Tag = Nothing
        Me.txtAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAhorro.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAhorro.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtAportacion
        '
        Me.txtAportacion.BackColor = System.Drawing.Color.White
        Me.txtAportacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAportacion.Culture = 17418
        Me.txtAportacion.CustomFormat = "#,##0.00"
        Me.txtAportacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAportacion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtAportacion.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtAportacion.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtAportacion.Location = New System.Drawing.Point(698, 277)
        Me.txtAportacion.Name = "txtAportacion"
        Me.txtAportacion.ReadOnly = True
        Me.txtAportacion.Size = New System.Drawing.Size(178, 26)
        Me.txtAportacion.TabIndex = 161
        Me.txtAportacion.Tag = Nothing
        Me.txtAportacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAportacion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAportacion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtSeguroDesempleo
        '
        Me.txtSeguroDesempleo.BackColor = System.Drawing.Color.White
        Me.txtSeguroDesempleo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeguroDesempleo.Culture = 17418
        Me.txtSeguroDesempleo.CustomFormat = "#,##0.00"
        Me.txtSeguroDesempleo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeguroDesempleo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSeguroDesempleo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtSeguroDesempleo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSeguroDesempleo.Location = New System.Drawing.Point(406, 277)
        Me.txtSeguroDesempleo.Name = "txtSeguroDesempleo"
        Me.txtSeguroDesempleo.ReadOnly = True
        Me.txtSeguroDesempleo.Size = New System.Drawing.Size(172, 26)
        Me.txtSeguroDesempleo.TabIndex = 160
        Me.txtSeguroDesempleo.Tag = Nothing
        Me.txtSeguroDesempleo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSeguroDesempleo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSeguroDesempleo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtSeguroVida
        '
        Me.txtSeguroVida.BackColor = System.Drawing.Color.White
        Me.txtSeguroVida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeguroVida.Culture = 17418
        Me.txtSeguroVida.CustomFormat = "#,##0.00"
        Me.txtSeguroVida.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeguroVida.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSeguroVida.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtSeguroVida.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSeguroVida.Location = New System.Drawing.Point(96, 277)
        Me.txtSeguroVida.Name = "txtSeguroVida"
        Me.txtSeguroVida.ReadOnly = True
        Me.txtSeguroVida.Size = New System.Drawing.Size(175, 26)
        Me.txtSeguroVida.TabIndex = 159
        Me.txtSeguroVida.Tag = Nothing
        Me.txtSeguroVida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSeguroVida.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSeguroVida.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtSeguroDanios
        '
        Me.txtSeguroDanios.BackColor = System.Drawing.Color.White
        Me.txtSeguroDanios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeguroDanios.Culture = 17418
        Me.txtSeguroDanios.CustomFormat = "#,##0.00"
        Me.txtSeguroDanios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeguroDanios.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSeguroDanios.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtSeguroDanios.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSeguroDanios.Location = New System.Drawing.Point(698, 246)
        Me.txtSeguroDanios.Name = "txtSeguroDanios"
        Me.txtSeguroDanios.ReadOnly = True
        Me.txtSeguroDanios.Size = New System.Drawing.Size(176, 26)
        Me.txtSeguroDanios.TabIndex = 158
        Me.txtSeguroDanios.Tag = Nothing
        Me.txtSeguroDanios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSeguroDanios.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSeguroDanios.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtSeguroDeuda
        '
        Me.txtSeguroDeuda.BackColor = System.Drawing.Color.White
        Me.txtSeguroDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeguroDeuda.Culture = 17418
        Me.txtSeguroDeuda.CustomFormat = "#,##0.00"
        Me.txtSeguroDeuda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeguroDeuda.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSeguroDeuda.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtSeguroDeuda.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSeguroDeuda.Location = New System.Drawing.Point(406, 246)
        Me.txtSeguroDeuda.Name = "txtSeguroDeuda"
        Me.txtSeguroDeuda.ReadOnly = True
        Me.txtSeguroDeuda.Size = New System.Drawing.Size(172, 26)
        Me.txtSeguroDeuda.TabIndex = 157
        Me.txtSeguroDeuda.Tag = Nothing
        Me.txtSeguroDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSeguroDeuda.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSeguroDeuda.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtIntereses
        '
        Me.txtIntereses.BackColor = System.Drawing.Color.White
        Me.txtIntereses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntereses.Culture = 17418
        Me.txtIntereses.CustomFormat = "#,##0.00"
        Me.txtIntereses.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntereses.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtIntereses.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtIntereses.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtIntereses.Location = New System.Drawing.Point(96, 246)
        Me.txtIntereses.Name = "txtIntereses"
        Me.txtIntereses.ReadOnly = True
        Me.txtIntereses.Size = New System.Drawing.Size(175, 26)
        Me.txtIntereses.TabIndex = 156
        Me.txtIntereses.Tag = Nothing
        Me.txtIntereses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIntereses.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIntereses.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtIntPag
        '
        Me.txtIntPag.BackColor = System.Drawing.Color.White
        Me.txtIntPag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntPag.Culture = 17418
        Me.txtIntPag.CustomFormat = "#,##0.00"
        Me.txtIntPag.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntPag.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtIntPag.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtIntPag.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtIntPag.Location = New System.Drawing.Point(698, 110)
        Me.txtIntPag.Name = "txtIntPag"
        Me.txtIntPag.ReadOnly = True
        Me.txtIntPag.Size = New System.Drawing.Size(176, 26)
        Me.txtIntPag.TabIndex = 155
        Me.txtIntPag.Tag = Nothing
        Me.txtIntPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIntPag.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIntPag.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(278, 283)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(135, 18)
        Me.Label17.TabIndex = 154
        Me.Label17.Text = "Seguro Desempleo:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 19)
        Me.Label12.TabIndex = 153
        Me.Label12.Text = "Ahorro:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(586, 283)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 18)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "Aportación:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 18)
        Me.Label10.TabIndex = 151
        Me.Label10.Text = "Seg. de Vida:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(586, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 18)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "Seguro de Daños:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(278, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 18)
        Me.Label8.TabIndex = 149
        Me.Label8.Text = "Seguro de Deuda:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 18)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "Intereses:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(586, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
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
        Me.txtMonto.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtMonto.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtMonto.Location = New System.Drawing.Point(406, 140)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(172, 26)
        Me.txtMonto.TabIndex = 146
        Me.txtMonto.Tag = Nothing
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtIntMora
        '
        Me.txtIntMora.BackColor = System.Drawing.Color.White
        Me.txtIntMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntMora.Culture = 17418
        Me.txtIntMora.CustomFormat = "#0.00"
        Me.txtIntMora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntMora.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtIntMora.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtIntMora.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtIntMora.Location = New System.Drawing.Point(406, 171)
        Me.txtIntMora.Name = "txtIntMora"
        Me.txtIntMora.ReadOnly = True
        Me.txtIntMora.Size = New System.Drawing.Size(172, 26)
        Me.txtIntMora.TabIndex = 144
        Me.txtIntMora.Tag = Nothing
        Me.txtIntMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIntMora.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIntMora.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtCapitalMora
        '
        Me.txtCapitalMora.BackColor = System.Drawing.Color.White
        Me.txtCapitalMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCapitalMora.Culture = 17418
        Me.txtCapitalMora.CustomFormat = "#,##0.00"
        Me.txtCapitalMora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapitalMora.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCapitalMora.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtCapitalMora.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtCapitalMora.Location = New System.Drawing.Point(96, 171)
        Me.txtCapitalMora.Name = "txtCapitalMora"
        Me.txtCapitalMora.ReadOnly = True
        Me.txtCapitalMora.Size = New System.Drawing.Size(175, 26)
        Me.txtCapitalMora.TabIndex = 143
        Me.txtCapitalMora.Tag = Nothing
        Me.txtCapitalMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCapitalMora.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCapitalMora.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.Culture = 17418
        Me.txtSaldo.CustomFormat = "#0.00"
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtSaldo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtSaldo.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtSaldo.Location = New System.Drawing.Point(698, 78)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(176, 27)
        Me.txtSaldo.TabIndex = 142
        Me.txtSaldo.Tag = Nothing
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(50, 18)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(116, 24)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Location = New System.Drawing.Point(16, 233)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(864, 9)
        Me.Panel3.TabIndex = 132
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(278, 172)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 18)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "Int.Mora:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(12, 167)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 23)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "Capital Mora:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(586, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 19)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "Saldo:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(278, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 18)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Monto:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFecha1aCuota
        '
        Me.txtFecha1aCuota.BackColor = System.Drawing.Color.White
        Me.txtFecha1aCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha1aCuota.Location = New System.Drawing.Point(96, 78)
        Me.txtFecha1aCuota.MaxLength = 8
        Me.txtFecha1aCuota.Name = "txtFecha1aCuota"
        Me.txtFecha1aCuota.ReadOnly = True
        Me.txtFecha1aCuota.Size = New System.Drawing.Size(175, 22)
        Me.txtFecha1aCuota.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "1a.Cuota:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(370, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(454, 17)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(420, 25)
        Me.txtAsociado.TabIndex = 20
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BackColor = System.Drawing.Color.White
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamo.Location = New System.Drawing.Point(698, 48)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(176, 23)
        Me.txtCodPrestamo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(586, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cod.Préstamo:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(7, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 19)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "DUI:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.btnProv1)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.dtpR2)
        Me.TabPage2.Controls.Add(Me.dtpR1)
        Me.TabPage2.Controls.Add(Me.fg2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(904, 710)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Provisiones"
        '
        'btnProv1
        '
        Me.btnProv1.Location = New System.Drawing.Point(314, 16)
        Me.btnProv1.Name = "btnProv1"
        Me.btnProv1.Size = New System.Drawing.Size(90, 32)
        Me.btnProv1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProv1.TabIndex = 239
        Me.btnProv1.Text = "Provisiones"
        Me.btnProv1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProv1.UseSelectable = True
        Me.btnProv1.UseStyleColors = True
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(173, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 18)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "al"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(10, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 18)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Del"
        '
        'dtpR2
        '
        Me.dtpR2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR2.Location = New System.Drawing.Point(202, 23)
        Me.dtpR2.Name = "dtpR2"
        Me.dtpR2.Size = New System.Drawing.Size(105, 22)
        Me.dtpR2.TabIndex = 11
        '
        'dtpR1
        '
        Me.dtpR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR1.Location = New System.Drawing.Point(48, 23)
        Me.dtpR1.Name = "dtpR1"
        Me.dtpR1.Size = New System.Drawing.Size(106, 22)
        Me.dtpR1.TabIndex = 10
        '
        'fg2
        '
        Me.fg2.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fg2.BackColorFixed = System.Drawing.Color.Teal
        Me.fg2.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg2.ForeColorFixed = System.Drawing.Color.White
        Me.fg2.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fg2.Location = New System.Drawing.Point(13, 55)
        Me.fg2.Name = "fg2"
        Me.fg2.NodeClosedPicture = Nothing
        Me.fg2.NodeOpenPicture = Nothing
        Me.fg2.OutlineCol = -1
        Me.fg2.SheetBorder = System.Drawing.SystemColors.WindowText
        Me.fg2.Size = New System.Drawing.Size(874, 641)
        Me.fg2.StyleInfo = resources.GetString("fg2.StyleInfo")
        Me.fg2.TabIndex = 5
        Me.fg2.TreeColor = System.Drawing.Color.DarkGray
        '
        'frmMsConsProv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(961, 790)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsConsProv"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta Provisión de Intereses"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.fg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoGarantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTasaInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoOtros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComisionxManejo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAhorro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAportacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeguroDesempleo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeguroVida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeguroDanios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeguroDeuda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntereses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntPag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCapitalMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.lblArreglo.Visible = False
        Me.txtCodPrestamo.Focus()
    End Sub

    Private Sub btnProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim sTexto As String
            Me.txtMensaje.Text = ""
            Me.txtObs.Text = ""
            Me.txtCasoEspecial.Text = ""
            Me.txtCasoEspecial.Visible = False
            Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, pTotal As Decimal
            Dim oCred As New wrCredito.wsLibCred, dsCB As New DataSet, oCaja As New wrCaja.wsLibCaja

            Try
                oPrest = New wrPrestamo.wsLibPrest
                sTexto = Me.txtCodPrestamo.Text
                If sTexto = "" Then

                ElseIf sTexto <> "" Then
                    ds = oPrest.CargaDatosPrestamoxRango(sTexto, dtpR1.Value.Date, dtpR2.Value.Date, "Cancelada='S'", sUsuario, sPassword, sSucursal)
                    Me.Prestamo = ds
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                    Me.txtMonto.Value = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
                    If Not IsDBNull(dr("FechaPrimeraCuota")) Then
                        Me.txtFecha1aCuota.Text = dr("FechaPrimeraCuota")
                    End If
                    If IIf(IsDBNull(dr("Estado")), "", dr("Estado")) = "D" Then
                        Me.txtEstado.Text = "Digitado"
                    ElseIf IIf(IsDBNull(dr("Estado")), "", dr("Estado")) = "A" Then
                        Me.txtEstado.Text = "Activo"
                    ElseIf IIf(IsDBNull(dr("Estado")), "", dr("Estado")) = "C" Then
                        Me.txtEstado.Text = "Cancelado"
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
                    Me.txtIntereses.Value = IIf(IsDBNull(dr("SaldoDia_Interes")), 0, dr("SaldoDia_Interes"))
                    Me.txtSeguroDeuda.Value = IIf(IsDBNull(dr("SaldoDia_SeguroDeuda")), 0, dr("SaldoDia_SeguroDeuda"))
                    Me.txtSeguroDanios.Value = IIf(IsDBNull(dr("SaldoDia_SeguroDaniosyLA")), 0, dr("SaldoDia_SeguroDaniosyLA"))
                    Me.txtSeguroVida.Value = IIf(IsDBNull(dr("SaldoDia_SeguroVida")), 0, dr("SaldoDia_SeguroVida"))
                    Me.txtSeguroDesempleo.Value = IIf(IsDBNull(dr("SaldoDia_SeguroDesempleo")), 0, dr("SaldoDia_SeguroDesempleo"))
                    Me.txtAportacion.Value = IIf(IsDBNull(dr("SaldoDia_Aportacion")), 0, dr("SaldoDia_Aportacion"))
                    Me.txtAhorro.Value = IIf(IsDBNull(dr("SaldoDia_Ahorro")), 0, dr("SaldoDia_Ahorro"))
                    Me.txtComisionxManejo.Value = IIf(IsDBNull(dr("SaldoDia_ComisionManejo")), 0, dr("SaldoDia_ComisionManejo"))
                    Me.txtSaldoOtros.Value = IIf(IsDBNull(dr("SaldoDia_Otros")), 0, dr("SaldoDia_Otros"))
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

                    '*********************************
                    'Modificacion 08/10/2012        **
                    'Javier Martinez                **
                    'Se incluyo en campo arreglo    **
                    '*********************************
                    '***************************************************************
                    Dim Arreglo As Boolean
                    Arreglo = IIf(IsDBNull(dr("Arreglo")), False, dr("Arreglo"))
                    If Arreglo = True Then
                        Me.lblArreglo.Visible = True
                        Me.lblArreglo.Text = "ARREGLO POR MORA"
                    Else
                        Me.lblArreglo.Visible = False
                    End If
                    '***************************************************************

                    If IIf(IsDBNull(dr("CasoEspecial")), "0", dr("CasoEspecial")) = "1" Then
                        Me.txtCasoEspecial.Visible = True
                        Me.txtCasoEspecial.Text = "Caso Especial"
                        dsCB = oCaja.ConsultarCAItemsFact("Descripcion", "CodItem='" & IIf(IsDBNull(dr("CodItem")), "", dr("CodItem")) & "'", "CodItem", sUsuario, sPassword, sSucursal)
                        If dsCB.Tables(0).Rows.Count > 0 Then
                            dr = dsCB.Tables(0).Rows(0)
                            Me.txtCasoEspecial.Text = "Caso Especial: " & dr("Descripcion")
                        End If
                    End If

                    fg1.DataSource = ds.Tables("Pagos")
                    pTotal = Math.Round(Me.txtSeguroDanios.Value, 2) + Math.Round(Me.txtSeguroDesempleo.Value, 2) + Math.Round(Me.txtSeguroDeuda.Value, 2) + Math.Round(Me.txtSeguroVida.Value, 2) + Math.Round(Me.txtSaldoOtros.Value, 2) + Math.Round(Me.txtComisionxManejo.Value, 2) + Math.Round(Me.txtAhorro.Value, 2) + Math.Round(Me.txtAportacion.Value, 2) + Math.Round(Me.txtIntereses.Value, 2) + Math.Round(Me.txtIntMora.Value, 2)
                    Me.c1nTotal.Value = pTotal

                    dsCB = oCred.ConsultarCBDocumentosxRecuperar("TipoDocumento", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                    If dsCB.Tables(0).Rows.Count > 0 Then
                        dr = dsCB.Tables(0).Rows(0)
                        If IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "C" Then 'C: Documentos x Cobrar
                            Me.txtMensaje.Text = "Trasladado a Cartera de Cobranza. Ver Cuentas por Cobrar"
                        ElseIf IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "P" Then 'P: Documentos en Protesto
                            Me.txtMensaje.Text = "Trasladado a Cartera de Cobranza. Cobro Judicial --> ¡¡Informe a Jurídico!!"
                        ElseIf IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "S" Then 'S: Documentos Saneados
                            Me.txtMensaje.Text = "Trasladado a Cartera de Cobranza. Documento Saneado"
                        End If
                    End If

                    Encabezado()
                End If
            Catch ex As Exception
               MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo")
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.CargarListaPrestamos(False, "", "", Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
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
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPrestamo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.LostFocus
        Dim sTexto As String
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, pTotal As Decimal
        Dim oCred As New wrCredito.wsLibCred, dsCB As New DataSet, oCaja As New wrCaja.wsLibCaja
        Try
            Me.txtMensaje.Text = ""
            Me.txtObs.Text = ""
            Me.txtCasoEspecial.Text = ""
            Me.txtCasoEspecial.Visible = False
            oPrest = New wrPrestamo.wsLibPrest
            sTexto = Me.txtCodPrestamo.Text
            If sTexto = "" Then

            ElseIf sTexto <> "" Then
                ds = oPrest.CargaDatosPrestamoxRango(sTexto, DateAdd(DateInterval.Day, -30, dtpR1.Value).ToShortDateString, dtpR2.Value.ToShortDateString, "Cancelada='S'", sUsuario, sPassword, sSucursal)

                Me.Prestamo = ds
                dr = ds.Tables(0).Rows(0)
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                Me.txtMonto.Value = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
                If Not IsDBNull(dr("FechaPrimeraCuota")) Then
                    Me.txtFecha1aCuota.Text = dr("FechaPrimeraCuota")
                End If
                If IIf(IsDBNull(dr("Estado")), "", dr("Estado")) = "D" Then
                    Me.txtEstado.Text = "Digitado"
                ElseIf IIf(IsDBNull(dr("Estado")), "", dr("Estado")) = "A" Then
                    Me.txtEstado.Text = "Activo"
                ElseIf IIf(IsDBNull(dr("Estado")), "", dr("Estado")) = "C" Then
                    Me.txtEstado.Text = "Cancelado"
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
                Me.txtIntereses.Value = IIf(IsDBNull(dr("SaldoDia_Interes")), 0, dr("SaldoDia_Interes"))
                Me.txtSeguroDeuda.Value = IIf(IsDBNull(dr("SaldoDia_SeguroDeuda")), 0, dr("SaldoDia_SeguroDeuda"))
                Me.txtSeguroDanios.Value = IIf(IsDBNull(dr("SaldoDia_SeguroDaniosyLA")), 0, dr("SaldoDia_SeguroDaniosyLA"))
                Me.txtSeguroVida.Value = IIf(IsDBNull(dr("SaldoDia_SeguroVida")), 0, dr("SaldoDia_SeguroVida"))
                Me.txtSeguroDesempleo.Value = IIf(IsDBNull(dr("SaldoDia_SeguroDesempleo")), 0, dr("SaldoDia_SeguroDesempleo"))
                Me.txtAportacion.Value = IIf(IsDBNull(dr("SaldoDia_Aportacion")), 0, dr("SaldoDia_Aportacion"))
                Me.txtAhorro.Value = IIf(IsDBNull(dr("SaldoDia_Ahorro")), 0, dr("SaldoDia_Ahorro"))
                Me.txtComisionxManejo.Value = IIf(IsDBNull(dr("SaldoDia_ComisionManejo")), 0, dr("SaldoDia_ComisionManejo"))
                Me.txtSaldoOtros.Value = IIf(IsDBNull(dr("SaldoDia_Otros")), 0, dr("SaldoDia_Otros"))
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


                '*********************************
                'Modificacion 08/10/2012        **
                'Javier Martinez                **
                'Se incluyo en campo arreglo    **
                '*********************************
                '***************************************************************
                Dim Arreglo As Boolean
                Arreglo = IIf(IsDBNull(dr("Arreglo")), False, dr("Arreglo"))
                If Arreglo = True Then
                    Me.lblArreglo.Visible = True
                    Me.lblArreglo.Text = "ARREGLO POR MORA"
                Else
                    Me.lblArreglo.Visible = False
                End If
                '***************************************************************


                If IIf(IsDBNull(dr("CasoEspecial")), "0", dr("CasoEspecial")) = "1" Then
                    Me.txtCasoEspecial.Visible = True
                    Me.txtCasoEspecial.Text = "Caso Especial"
                    dsCB = oCaja.ConsultarCAItemsFact("Descripcion", "CodItem='" & IIf(IsDBNull(dr("CodItem")), "", dr("CodItem")) & "'", "CodItem", sUsuario, sPassword, sSucursal)
                    If dsCB.Tables(0).Rows.Count > 0 Then
                        dr = dsCB.Tables(0).Rows(0)
                        Me.txtCasoEspecial.Text = "Caso Especial: " & dr("Descripcion")
                    End If
                End If

                fg1.DataSource = ds.Tables("Pagos")
                pTotal = Math.Round(Me.txtSeguroDanios.Value, 2) + Math.Round(Me.txtSeguroDesempleo.Value, 2) + Math.Round(Me.txtSeguroDeuda.Value, 2) + Math.Round(Me.txtSeguroVida.Value, 2) + Math.Round(Me.txtSaldoOtros.Value, 2) + Math.Round(Me.txtComisionxManejo.Value, 2) + Math.Round(Me.txtAhorro.Value, 2) + Math.Round(Me.txtAportacion.Value, 2) + Math.Round(Me.txtIntereses.Value, 2) + Math.Round(Me.txtIntMora.Value, 2)
                Me.c1nTotal.Value = pTotal

                dsCB = oCred.ConsultarCBDocumentosxRecuperar("TipoDocumento", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                If dsCB.Tables(0).Rows.Count > 0 Then
                    dr = dsCB.Tables(0).Rows(0)
                    If IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "C" Then 'C: Documentos x Cobrar
                        Me.txtMensaje.Text = "Trasladado a Cartera de Cobranza. Ver Cuentas por Cobrar"
                    ElseIf IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "P" Then 'P: Documentos en Protesto
                        Me.txtMensaje.Text = "Trasladado a Cartera de Cobranza. Cobro Judicial --> ¡¡Informe a Cobros!!"
                    ElseIf IIf(IsDBNull(dr("TipoDocumento")), "", dr("TipoDocumento")) = "S" Then 'S: Documentos Saneados
                        Me.txtMensaje.Text = "Trasladado a Cartera de Cobranza. Documento Saneado"
                    End If
                End If

                Encabezado()

            End If
            oCaja = Nothing
            oPrest = Nothing
            oCred = Nothing
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnProv1_Click(sender As Object, e As EventArgs) Handles btnProv1.Click

        Dim sTexto As String
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo")
        Try
            oPrest = New wrPrestamo.wsLibPrest
            sTexto = Me.txtCodPrestamo.Text
            If sTexto = "" Then

            ElseIf sTexto <> "" Then
                ds = oPrest.CargaDatosPrestamoxRango(sTexto, Me.dtpR1.Value.Date, Me.dtpR2.Value.Date, "Cancelada='S'", sUsuario, sPassword, sSucursal)
                fg2.DataSource = ds.Tables("Provisiones")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class