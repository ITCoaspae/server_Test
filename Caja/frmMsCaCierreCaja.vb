Public Class frmMsCaCierreCaja
    Inherits MetroFramework.Forms.MetroForm '  Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private vCodCajero As String

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents c1txtNoCaja As C1.Win.C1Input.C1TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents c1nTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCien As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCincuenta As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nVeinte As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nFraccion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nDiez As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCinco As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nUno As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCajero As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents c1nTotalDeposito As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents c1nTotalFacturas As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents c1nTotalDividendos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nTotalRetiros As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nSubTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents c1nTotalCierre As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents c1nTotalCreditosFiscales As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents c1nDeteriorados As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nTotalChequesPropios As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents c1nTotalChequeAjenos As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents c1nTotalCambioCheque As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents c1nSubTotalIng As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nSubTotalEg As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCajero = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.c1txtNoCaja = New C1.Win.C1Input.C1TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.c1nSubTotalEg = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nSubTotalIng = New C1.Win.C1Input.C1NumericEdit()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.c1nTotalCambioCheque = New C1.Win.C1Input.C1NumericEdit()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.c1nTotalChequeAjenos = New C1.Win.C1Input.C1NumericEdit()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.c1nDeteriorados = New C1.Win.C1Input.C1NumericEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.c1nTotalCreditosFiscales = New C1.Win.C1Input.C1NumericEdit()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.c1nTotalCierre = New C1.Win.C1Input.C1NumericEdit()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.c1nSubTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nTotalRetiros = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nTotalDividendos = New C1.Win.C1Input.C1NumericEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.c1nTotalFacturas = New C1.Win.C1Input.C1NumericEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.c1nTotalDeposito = New C1.Win.C1Input.C1NumericEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.c1nTotalChequesPropios = New C1.Win.C1Input.C1NumericEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.c1nTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCien = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCincuenta = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nVeinte = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nFraccion = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nDiez = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCinco = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nUno = New C1.Win.C1Input.C1NumericEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1nSubTotalEg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSubTotalIng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotalCambioCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotalChequeAjenos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nDeteriorados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotalCreditosFiscales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotalCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotalRetiros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotalDividendos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotalFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotalDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotalChequesPropios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCincuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nVeinte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nFraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nDiez, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCinco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nUno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtCajero)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.c1txtNoCaja)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtCajero
        '
        Me.txtCajero.BackColor = System.Drawing.Color.White
        Me.txtCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajero.Location = New System.Drawing.Point(112, 32)
        Me.txtCajero.MaxLength = 20
        Me.txtCajero.Name = "txtCajero"
        Me.txtCajero.ReadOnly = True
        Me.txtCajero.Size = New System.Drawing.Size(136, 20)
        Me.txtCajero.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(112, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 139
        Me.Label12.Text = "Código de Cajero:"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.CustomFormat = "###,###,##0.00"
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMonto.Location = New System.Drawing.Point(272, 32)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMonto.ShowDropDownButton = False
        Me.txtMonto.ShowUpDownButtons = False
        Me.txtMonto.Size = New System.Drawing.Size(88, 21)
        Me.txtMonto.TabIndex = 2
        Me.txtMonto.Tag = Nothing
        Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(272, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 138
        Me.Label14.Text = "Monto de Cierre:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'c1txtNoCaja
        '
        Me.c1txtNoCaja.BackColor = System.Drawing.Color.White
        Me.c1txtNoCaja.DataType = GetType(Short)
        Me.c1txtNoCaja.Location = New System.Drawing.Point(16, 32)
        Me.c1txtNoCaja.Name = "c1txtNoCaja"
        Me.c1txtNoCaja.Size = New System.Drawing.Size(72, 20)
        Me.c1txtNoCaja.TabIndex = 0
        Me.c1txtNoCaja.Tag = Nothing
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(384, 32)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "No. de Caja:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(384, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.c1nSubTotalEg)
        Me.GroupBox2.Controls.Add(Me.c1nSubTotalIng)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.c1nTotalCambioCheque)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.c1nTotalChequeAjenos)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.c1nDeteriorados)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.c1nTotalCreditosFiscales)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.c1nTotalCierre)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.c1nSubTotal)
        Me.GroupBox2.Controls.Add(Me.c1nTotalRetiros)
        Me.GroupBox2.Controls.Add(Me.c1nTotalDividendos)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.c1nTotalFacturas)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.c1nTotalDeposito)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.c1nTotalChequesPropios)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.c1nTotal)
        Me.GroupBox2.Controls.Add(Me.c1nCien)
        Me.GroupBox2.Controls.Add(Me.c1nCincuenta)
        Me.GroupBox2.Controls.Add(Me.c1nVeinte)
        Me.GroupBox2.Controls.Add(Me.c1nFraccion)
        Me.GroupBox2.Controls.Add(Me.c1nDiez)
        Me.GroupBox2.Controls.Add(Me.c1nCinco)
        Me.GroupBox2.Controls.Add(Me.c1nUno)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 440)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'c1nSubTotalEg
        '
        Me.c1nSubTotalEg.BackColor = System.Drawing.Color.White
        Me.c1nSubTotalEg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSubTotalEg.CustomFormat = "###,###,##0.00"
        Me.c1nSubTotalEg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nSubTotalEg.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSubTotalEg.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nSubTotalEg.Location = New System.Drawing.Point(416, 296)
        Me.c1nSubTotalEg.Name = "c1nSubTotalEg"
        Me.c1nSubTotalEg.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSubTotalEg.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSubTotalEg.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSubTotalEg.ReadOnly = True
        Me.c1nSubTotalEg.ShowDropDownButton = False
        Me.c1nSubTotalEg.ShowUpDownButtons = False
        Me.c1nSubTotalEg.Size = New System.Drawing.Size(80, 21)
        Me.c1nSubTotalEg.TabIndex = 16
        Me.c1nSubTotalEg.Tag = Nothing
        Me.c1nSubTotalEg.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nSubTotalIng
        '
        Me.c1nSubTotalIng.BackColor = System.Drawing.Color.White
        Me.c1nSubTotalIng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSubTotalIng.CustomFormat = "###,###,##0.00"
        Me.c1nSubTotalIng.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nSubTotalIng.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSubTotalIng.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nSubTotalIng.Location = New System.Drawing.Point(144, 408)
        Me.c1nSubTotalIng.Name = "c1nSubTotalIng"
        Me.c1nSubTotalIng.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSubTotalIng.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSubTotalIng.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSubTotalIng.ReadOnly = True
        Me.c1nSubTotalIng.ShowDropDownButton = False
        Me.c1nSubTotalIng.ShowUpDownButtons = False
        Me.c1nSubTotalIng.Size = New System.Drawing.Size(80, 21)
        Me.c1nSubTotalIng.TabIndex = 18
        Me.c1nSubTotalIng.Tag = Nothing
        Me.c1nSubTotalIng.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(248, 304)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 16)
        Me.Label29.TabIndex = 43
        Me.Label29.Text = "Subtotal Egresos:"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(16, 408)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 16)
        Me.Label28.TabIndex = 42
        Me.Label28.Text = "Subtotal Ingresos:"
        '
        'c1nTotalCambioCheque
        '
        Me.c1nTotalCambioCheque.BackColor = System.Drawing.Color.White
        Me.c1nTotalCambioCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotalCambioCheque.CustomFormat = "###,###,##0.00"
        Me.c1nTotalCambioCheque.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTotalCambioCheque.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotalCambioCheque.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotalCambioCheque.Location = New System.Drawing.Point(144, 280)
        Me.c1nTotalCambioCheque.Name = "c1nTotalCambioCheque"
        Me.c1nTotalCambioCheque.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotalCambioCheque.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotalCambioCheque.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotalCambioCheque.ShowDropDownButton = False
        Me.c1nTotalCambioCheque.ShowUpDownButtons = False
        Me.c1nTotalCambioCheque.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotalCambioCheque.TabIndex = 10
        Me.c1nTotalCambioCheque.Tag = Nothing
        Me.c1nTotalCambioCheque.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label27
        '
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(16, 280)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(128, 16)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "Cambios con cheque:"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Teal
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(352, 208)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 16)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "EGRESOS"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Teal
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(80, 208)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 16)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "INGRESOS"
        '
        'c1nTotalChequeAjenos
        '
        Me.c1nTotalChequeAjenos.BackColor = System.Drawing.Color.White
        Me.c1nTotalChequeAjenos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotalChequeAjenos.CustomFormat = "###,###,##0.00"
        Me.c1nTotalChequeAjenos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTotalChequeAjenos.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotalChequeAjenos.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotalChequeAjenos.Location = New System.Drawing.Point(144, 232)
        Me.c1nTotalChequeAjenos.Name = "c1nTotalChequeAjenos"
        Me.c1nTotalChequeAjenos.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotalChequeAjenos.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotalChequeAjenos.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotalChequeAjenos.ShowDropDownButton = False
        Me.c1nTotalChequeAjenos.ShowUpDownButtons = False
        Me.c1nTotalChequeAjenos.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotalChequeAjenos.TabIndex = 8
        Me.c1nTotalChequeAjenos.Tag = Nothing
        Me.c1nTotalChequeAjenos.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label24
        '
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(16, 232)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(128, 16)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "Total Cheques Ajenos:"
        '
        'c1nDeteriorados
        '
        Me.c1nDeteriorados.BackColor = System.Drawing.Color.White
        Me.c1nDeteriorados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nDeteriorados.CustomFormat = "###,###,##0.00"
        Me.c1nDeteriorados.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nDeteriorados.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nDeteriorados.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nDeteriorados.Location = New System.Drawing.Point(416, 136)
        Me.c1nDeteriorados.Name = "c1nDeteriorados"
        Me.c1nDeteriorados.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nDeteriorados.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nDeteriorados.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nDeteriorados.ShowDropDownButton = False
        Me.c1nDeteriorados.ShowUpDownButtons = False
        Me.c1nDeteriorados.Size = New System.Drawing.Size(80, 21)
        Me.c1nDeteriorados.TabIndex = 7
        Me.c1nDeteriorados.Tag = Nothing
        Me.c1nDeteriorados.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label23
        '
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(304, 138)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 12)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Billetes deteriorados"
        '
        'c1nTotalCreditosFiscales
        '
        Me.c1nTotalCreditosFiscales.BackColor = System.Drawing.Color.White
        Me.c1nTotalCreditosFiscales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotalCreditosFiscales.CustomFormat = "###,###,##0.00"
        Me.c1nTotalCreditosFiscales.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTotalCreditosFiscales.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotalCreditosFiscales.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotalCreditosFiscales.Location = New System.Drawing.Point(144, 376)
        Me.c1nTotalCreditosFiscales.Name = "c1nTotalCreditosFiscales"
        Me.c1nTotalCreditosFiscales.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotalCreditosFiscales.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotalCreditosFiscales.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotalCreditosFiscales.ShowDropDownButton = False
        Me.c1nTotalCreditosFiscales.ShowUpDownButtons = False
        Me.c1nTotalCreditosFiscales.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotalCreditosFiscales.TabIndex = 13
        Me.c1nTotalCreditosFiscales.Tag = Nothing
        Me.c1nTotalCreditosFiscales.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label22
        '
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(16, 368)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 24)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Total Créditos Fiscales:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(400, 376)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 1)
        Me.Panel2.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(408, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 1)
        Me.Panel1.TabIndex = 32
        '
        'c1nTotalCierre
        '
        Me.c1nTotalCierre.BackColor = System.Drawing.Color.White
        Me.c1nTotalCierre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotalCierre.CustomFormat = "###,###,##0.00"
        Me.c1nTotalCierre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTotalCierre.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotalCierre.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotalCierre.Location = New System.Drawing.Point(416, 392)
        Me.c1nTotalCierre.Name = "c1nTotalCierre"
        Me.c1nTotalCierre.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotalCierre.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotalCierre.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotalCierre.ReadOnly = True
        Me.c1nTotalCierre.ShowDropDownButton = False
        Me.c1nTotalCierre.ShowUpDownButtons = False
        Me.c1nTotalCierre.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotalCierre.TabIndex = 19
        Me.c1nTotalCierre.Tag = Nothing
        Me.c1nTotalCierre.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(264, 392)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 16)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "Total Detalle de Cierre:"
        '
        'c1nSubTotal
        '
        Me.c1nSubTotal.BackColor = System.Drawing.Color.White
        Me.c1nSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSubTotal.CustomFormat = "###,###,##0.00"
        Me.c1nSubTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSubTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSubTotal.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nSubTotal.Location = New System.Drawing.Point(416, 336)
        Me.c1nSubTotal.Name = "c1nSubTotal"
        Me.c1nSubTotal.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSubTotal.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSubTotal.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSubTotal.ReadOnly = True
        Me.c1nSubTotal.ShowDropDownButton = False
        Me.c1nSubTotal.ShowUpDownButtons = False
        Me.c1nSubTotal.Size = New System.Drawing.Size(80, 21)
        Me.c1nSubTotal.TabIndex = 17
        Me.c1nSubTotal.Tag = Nothing
        Me.c1nSubTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nTotalRetiros
        '
        Me.c1nTotalRetiros.BackColor = System.Drawing.Color.White
        Me.c1nTotalRetiros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotalRetiros.CustomFormat = "###,###,##0.00"
        Me.c1nTotalRetiros.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTotalRetiros.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotalRetiros.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotalRetiros.Location = New System.Drawing.Point(416, 264)
        Me.c1nTotalRetiros.Name = "c1nTotalRetiros"
        Me.c1nTotalRetiros.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotalRetiros.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotalRetiros.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotalRetiros.ShowDropDownButton = False
        Me.c1nTotalRetiros.ShowUpDownButtons = False
        Me.c1nTotalRetiros.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotalRetiros.TabIndex = 15
        Me.c1nTotalRetiros.Tag = Nothing
        Me.c1nTotalRetiros.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nTotalDividendos
        '
        Me.c1nTotalDividendos.BackColor = System.Drawing.Color.White
        Me.c1nTotalDividendos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotalDividendos.CustomFormat = "###,###,##0.00"
        Me.c1nTotalDividendos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTotalDividendos.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotalDividendos.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotalDividendos.Location = New System.Drawing.Point(416, 232)
        Me.c1nTotalDividendos.Name = "c1nTotalDividendos"
        Me.c1nTotalDividendos.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotalDividendos.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotalDividendos.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotalDividendos.ShowDropDownButton = False
        Me.c1nTotalDividendos.ShowUpDownButtons = False
        Me.c1nTotalDividendos.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotalDividendos.TabIndex = 14
        Me.c1nTotalDividendos.Tag = Nothing
        Me.c1nTotalDividendos.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(248, 336)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(160, 16)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Subtotal (Ingresos-Egresos):"
        '
        'Label19
        '
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(248, 264)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 32)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Total Comprobantes de Retiro:"
        '
        'Label18
        '
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(248, 232)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 32)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Total Dividendos pagados:"
        '
        'c1nTotalFacturas
        '
        Me.c1nTotalFacturas.BackColor = System.Drawing.Color.White
        Me.c1nTotalFacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotalFacturas.CustomFormat = "###,###,##0.00"
        Me.c1nTotalFacturas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTotalFacturas.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotalFacturas.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotalFacturas.Location = New System.Drawing.Point(144, 344)
        Me.c1nTotalFacturas.Name = "c1nTotalFacturas"
        Me.c1nTotalFacturas.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotalFacturas.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotalFacturas.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotalFacturas.ShowDropDownButton = False
        Me.c1nTotalFacturas.ShowUpDownButtons = False
        Me.c1nTotalFacturas.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotalFacturas.TabIndex = 12
        Me.c1nTotalFacturas.Tag = Nothing
        Me.c1nTotalFacturas.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(16, 344)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Total Facturas:"
        '
        'c1nTotalDeposito
        '
        Me.c1nTotalDeposito.BackColor = System.Drawing.Color.White
        Me.c1nTotalDeposito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotalDeposito.CustomFormat = "###,###,##0.00"
        Me.c1nTotalDeposito.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTotalDeposito.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotalDeposito.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotalDeposito.Location = New System.Drawing.Point(144, 312)
        Me.c1nTotalDeposito.Name = "c1nTotalDeposito"
        Me.c1nTotalDeposito.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotalDeposito.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotalDeposito.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotalDeposito.ShowDropDownButton = False
        Me.c1nTotalDeposito.ShowUpDownButtons = False
        Me.c1nTotalDeposito.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotalDeposito.TabIndex = 11
        Me.c1nTotalDeposito.Tag = Nothing
        Me.c1nTotalDeposito.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(16, 304)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 32)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Total Comprobantes    de Depósito:"
        '
        'c1nTotalChequesPropios
        '
        Me.c1nTotalChequesPropios.BackColor = System.Drawing.Color.White
        Me.c1nTotalChequesPropios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotalChequesPropios.CustomFormat = "###,###,##0.00"
        Me.c1nTotalChequesPropios.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTotalChequesPropios.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotalChequesPropios.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotalChequesPropios.Location = New System.Drawing.Point(144, 256)
        Me.c1nTotalChequesPropios.Name = "c1nTotalChequesPropios"
        Me.c1nTotalChequesPropios.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotalChequesPropios.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotalChequesPropios.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotalChequesPropios.ShowDropDownButton = False
        Me.c1nTotalChequesPropios.ShowUpDownButtons = False
        Me.c1nTotalChequesPropios.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotalChequesPropios.TabIndex = 9
        Me.c1nTotalChequesPropios.Tag = Nothing
        Me.c1nTotalChequesPropios.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(16, 256)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 16)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Total Cheques Propios:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Teal
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(8, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(496, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Detalle de Documentos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'c1nTotal
        '
        Me.c1nTotal.BackColor = System.Drawing.Color.White
        Me.c1nTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotal.CustomFormat = "###,###,##0.00"
        Me.c1nTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotal.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotal.Location = New System.Drawing.Point(416, 168)
        Me.c1nTotal.Name = "c1nTotal"
        Me.c1nTotal.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotal.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotal.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotal.ReadOnly = True
        Me.c1nTotal.ShowDropDownButton = False
        Me.c1nTotal.ShowUpDownButtons = False
        Me.c1nTotal.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotal.TabIndex = 20
        Me.c1nTotal.Tag = Nothing
        Me.c1nTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nCien
        '
        Me.c1nCien.BackColor = System.Drawing.Color.White
        Me.c1nCien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCien.CustomFormat = "###,###,##0.00"
        Me.c1nCien.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCien.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCien.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCien.Location = New System.Drawing.Point(416, 104)
        Me.c1nCien.Name = "c1nCien"
        Me.c1nCien.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCien.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCien.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCien.ShowDropDownButton = False
        Me.c1nCien.ShowUpDownButtons = False
        Me.c1nCien.Size = New System.Drawing.Size(80, 21)
        Me.c1nCien.TabIndex = 6
        Me.c1nCien.Tag = Nothing
        Me.c1nCien.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nCincuenta
        '
        Me.c1nCincuenta.BackColor = System.Drawing.Color.White
        Me.c1nCincuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCincuenta.CustomFormat = "###,###,##0.00"
        Me.c1nCincuenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCincuenta.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCincuenta.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCincuenta.Location = New System.Drawing.Point(416, 72)
        Me.c1nCincuenta.Name = "c1nCincuenta"
        Me.c1nCincuenta.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCincuenta.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCincuenta.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCincuenta.ShowDropDownButton = False
        Me.c1nCincuenta.ShowUpDownButtons = False
        Me.c1nCincuenta.Size = New System.Drawing.Size(80, 21)
        Me.c1nCincuenta.TabIndex = 5
        Me.c1nCincuenta.Tag = Nothing
        Me.c1nCincuenta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nVeinte
        '
        Me.c1nVeinte.BackColor = System.Drawing.Color.White
        Me.c1nVeinte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nVeinte.CustomFormat = "###,###,##0.00"
        Me.c1nVeinte.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nVeinte.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nVeinte.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nVeinte.Location = New System.Drawing.Point(416, 40)
        Me.c1nVeinte.Name = "c1nVeinte"
        Me.c1nVeinte.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nVeinte.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nVeinte.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nVeinte.ShowDropDownButton = False
        Me.c1nVeinte.ShowUpDownButtons = False
        Me.c1nVeinte.Size = New System.Drawing.Size(80, 21)
        Me.c1nVeinte.TabIndex = 4
        Me.c1nVeinte.Tag = Nothing
        Me.c1nVeinte.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nFraccion
        '
        Me.c1nFraccion.BackColor = System.Drawing.Color.White
        Me.c1nFraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nFraccion.CustomFormat = "###,###,##0.00"
        Me.c1nFraccion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nFraccion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nFraccion.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nFraccion.Location = New System.Drawing.Point(136, 136)
        Me.c1nFraccion.Name = "c1nFraccion"
        Me.c1nFraccion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nFraccion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nFraccion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nFraccion.ShowDropDownButton = False
        Me.c1nFraccion.ShowUpDownButtons = False
        Me.c1nFraccion.Size = New System.Drawing.Size(80, 21)
        Me.c1nFraccion.TabIndex = 3
        Me.c1nFraccion.Tag = Nothing
        Me.c1nFraccion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nDiez
        '
        Me.c1nDiez.BackColor = System.Drawing.Color.White
        Me.c1nDiez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nDiez.CustomFormat = "###,###,##0.00"
        Me.c1nDiez.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nDiez.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nDiez.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nDiez.Location = New System.Drawing.Point(136, 104)
        Me.c1nDiez.Name = "c1nDiez"
        Me.c1nDiez.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nDiez.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nDiez.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nDiez.ShowDropDownButton = False
        Me.c1nDiez.ShowUpDownButtons = False
        Me.c1nDiez.Size = New System.Drawing.Size(80, 21)
        Me.c1nDiez.TabIndex = 2
        Me.c1nDiez.Tag = Nothing
        Me.c1nDiez.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nCinco
        '
        Me.c1nCinco.BackColor = System.Drawing.Color.White
        Me.c1nCinco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCinco.CustomFormat = "###,###,##0.00"
        Me.c1nCinco.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCinco.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCinco.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCinco.Location = New System.Drawing.Point(136, 72)
        Me.c1nCinco.Name = "c1nCinco"
        Me.c1nCinco.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCinco.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCinco.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCinco.ShowDropDownButton = False
        Me.c1nCinco.ShowUpDownButtons = False
        Me.c1nCinco.Size = New System.Drawing.Size(80, 21)
        Me.c1nCinco.TabIndex = 1
        Me.c1nCinco.Tag = Nothing
        Me.c1nCinco.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nUno
        '
        Me.c1nUno.BackColor = System.Drawing.Color.White
        Me.c1nUno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nUno.CustomFormat = "###,###,##0.00"
        Me.c1nUno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nUno.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nUno.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nUno.Location = New System.Drawing.Point(136, 40)
        Me.c1nUno.Name = "c1nUno"
        Me.c1nUno.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nUno.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nUno.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nUno.ShowDropDownButton = False
        Me.c1nUno.ShowUpDownButtons = False
        Me.c1nUno.Size = New System.Drawing.Size(80, 21)
        Me.c1nUno.TabIndex = 0
        Me.c1nUno.Tag = Nothing
        Me.c1nUno.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(280, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Subtotal:"
        '
        'Label10
        '
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(16, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 23)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Moneda Fraccionaria:"
        '
        'Label9
        '
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(304, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Billetes de $100.00"
        '
        'Label8
        '
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(304, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Billetes de $50.00"
        '
        'Label7
        '
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(304, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Billetes de $20.00"
        '
        'Label6
        '
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(16, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Billetes de $10.00"
        '
        'Label5
        '
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(16, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Billetes de $5.00"
        '
        'Label3
        '
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Billetes de $1.00"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(520, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Detalle Monto de Cierre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(484, 578)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 62
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCaCierreCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(582, 629)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCaCierreCaja"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Datos Cierre de Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1nSubTotalEg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSubTotalIng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotalCambioCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotalChequeAjenos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nDeteriorados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotalCreditosFiscales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotalCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotalRetiros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotalDividendos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotalFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotalDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotalChequesPropios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCincuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nVeinte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nFraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nDiez, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCinco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nUno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property CodCajero() As String
        Get
            Return vCodCajero
        End Get
        Set(ByVal Value As String)
            vCodCajero = Value
        End Set
    End Property

    Private Sub frmMsCaCierreCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oApp As New wrAdmin.wsLibAdmin
        Me.txtCajero.Text = Me.CodCajero
        Me.dtpFecha.Value = oApp.Fecha
    End Sub



    Private Sub c1nUno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nUno.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + Me.c1nDeteriorados.Value
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nCinco_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCinco.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + Me.c1nDeteriorados.Value
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nDiez_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nDiez.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + Me.c1nDeteriorados.Value
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nVeinte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nVeinte.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + Me.c1nDeteriorados.Value
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nCincuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCincuenta.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + Me.c1nDeteriorados.Value
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nCien_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCien.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + Me.c1nDeteriorados.Value
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nFraccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nFraccion.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + Me.c1nDeteriorados.Value
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nTotalDeposito_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nTotalDeposito.LostFocus
        Me.c1nSubTotalIng.Value = c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value
        Me.c1nSubTotalEg.Value = c1nTotalDividendos.Value + c1nTotalRetiros.Value
        Me.c1nSubTotal.Value = (c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value) - (c1nTotalDividendos.Value + c1nTotalRetiros.Value)
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nTotalFacturas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nTotalFacturas.LostFocus
        Me.c1nSubTotalIng.Value = c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value
        Me.c1nSubTotalEg.Value = c1nTotalDividendos.Value + c1nTotalRetiros.Value
        Me.c1nSubTotal.Value = (c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value) - (c1nTotalDividendos.Value + c1nTotalRetiros.Value)
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nTotalDividendos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nTotalDividendos.LostFocus
        Me.c1nSubTotalIng.Value = c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value
        Me.c1nSubTotalEg.Value = c1nTotalDividendos.Value + c1nTotalRetiros.Value
        Me.c1nSubTotal.Value = (c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value) - (c1nTotalDividendos.Value + c1nTotalRetiros.Value)
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nTotalRetiros_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nTotalRetiros.LostFocus
        Me.c1nSubTotalIng.Value = c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value
        Me.c1nSubTotalEg.Value = c1nTotalDividendos.Value + c1nTotalRetiros.Value
        Me.c1nSubTotal.Value = (c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value) - (c1nTotalDividendos.Value + c1nTotalRetiros.Value)
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nTotalCreditosFiscales_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nTotalCreditosFiscales.LostFocus
        Me.c1nSubTotalIng.Value = c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value
        Me.c1nSubTotalEg.Value = c1nTotalDividendos.Value + c1nTotalRetiros.Value
        Me.c1nSubTotal.Value = (c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value) - (c1nTotalDividendos.Value + c1nTotalRetiros.Value)
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nDeteriorados_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nDeteriorados.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + Me.c1nDeteriorados.Value
    End Sub

    Private Sub c1txtNoCaja_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1txtNoCaja.LostFocus
        If Trim(c1txtNoCaja.Text) = "" Then Exit Sub
        Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, dr As DataRow
        ds = oCaja.ArqueoCierreCaja(dtpFecha.Value, Trim(c1txtNoCaja.Value), False, sUsuario, sPassword, sSucursal)
        If ds.Tables(1).Rows.Count > 0 Then
            dr = ds.Tables(1).Rows(0)
            'MsgBox("Cambio Cheque: " & dr("CambioCheque") & vbCrLf & "Ingresos Efectivo: " & dr("IngresosEfectivo") & vbCrLf & "Cheques Ajenos: " & dr("IngresosChequesAjenos") & vbCrLf & "Cheques Propios: " & dr("IngresosChequesPropios") & vbCrLf & "Ingresos Remesas: " & dr("IngresosRemesas") & vbCrLf & "Comprobantes Retiro: " & dr("ComprobantesRetiro") & vbCrLf & "Egresos Remesas: " & dr("EgresosRemesas") & vbCrLf & "Dividendos: " & dr("DividendosPagados"))
            Me.txtMonto.Value = dr("CambioCheque") + dr("IngresosEfectivo") + dr("IngresosRemesas") + dr("IngresosChequesAjenos") - (dr("ComprobantesRetiro") + dr("EgresosRemesas") + dr("DividendosPagados"))
        End If
    End Sub

    Private Sub c1nTotalChequeAjenos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nTotalChequeAjenos.LostFocus
        Me.c1nSubTotalIng.Value = c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value
        Me.c1nSubTotalEg.Value = c1nTotalDividendos.Value + c1nTotalRetiros.Value
        Me.c1nSubTotal.Value = (c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value) - (c1nTotalDividendos.Value + c1nTotalRetiros.Value)
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nTotalCambioCheque_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nTotalCambioCheque.LostFocus
        Me.c1nSubTotalIng.Value = c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value
        Me.c1nSubTotalEg.Value = c1nTotalDividendos.Value + c1nTotalRetiros.Value
        Me.c1nSubTotal.Value = (c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value) - (c1nTotalDividendos.Value + c1nTotalRetiros.Value)
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub c1nTotalChequesPropios_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nTotalChequesPropios.LostFocus
        Me.c1nSubTotalIng.Value = c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value
        Me.c1nSubTotalEg.Value = c1nTotalDividendos.Value + c1nTotalRetiros.Value
        Me.c1nSubTotal.Value = (c1nTotalChequeAjenos.Value + c1nTotalChequesPropios.Value + c1nTotalCambioCheque.Value + c1nTotalDeposito.Value + c1nTotalFacturas.Value + c1nTotalCreditosFiscales.Value) - (c1nTotalDividendos.Value + c1nTotalRetiros.Value)
        Me.c1nTotalCierre.Value = Me.c1nTotal.Value + Me.c1nSubTotal.Value
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oItem As New wrCaja.wsLibCaja, pCampos As String, pValores As String
        Dim pNoCaja As String
        Try

            If IsNumeric(Me.c1txtNoCaja.Text.Trim) = False Then Exit Sub
            If Me.txtMonto.Value <> Me.c1nTotalCierre.Value Then
                MessageBox.Show("El Monto no coincide con el total del detalle, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            pNoCaja = "'" & Trim(Me.c1txtNoCaja.Value) & "'"
            pCampos = "NoCaja,CodCajero,Fecha,Monto,TipoMov,CantidadUno,CantidadCinco,CantidadDiez,CantidadVeinte,CantidadCincuenta,CantidadCien,CantidadFraccion,MontoDeteriorados,TotalCheques,TotalDepositos,TotalFacturas,TotalCreditoFiscal,TotalDividendos,TotalRetiros"
            pValores = "" & pNoCaja & ",'" & Me.CodCajero & "','" & Me.dtpFecha.Value.ToShortDateString & "'," & Me.c1nTotalCierre.Value & ",'C'," & Me.c1nUno.Value & "," & Me.c1nCinco.Value & "," & Me.c1nDiez.Value & "," & Me.c1nVeinte.Value & "," & Me.c1nCincuenta.Value & "," & Me.c1nCien.Value & "," & Me.c1nFraccion.Value & "," & Me.c1nDeteriorados.Value & "," & Me.c1nTotalChequeAjenos.Value + Me.c1nTotalChequesPropios.Value & "," & Me.c1nTotalDeposito.Value & "," & Me.c1nTotalFacturas.Value & "," & Me.c1nTotalCreditosFiscales.Value & "," & Me.c1nTotalDividendos.Value & "," & Me.c1nTotalRetiros.Value & ""
            If oItem.CierreCaja(Me.dtpFecha.Value.ToShortDateString, pNoCaja, pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                MessageBox.Show("Cierre de caja Realizado con éxito.", "Cierre de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Else
                MessageBox.Show("Cierre de caja NO realizado, verifíque.", "Cierre de Caja", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class