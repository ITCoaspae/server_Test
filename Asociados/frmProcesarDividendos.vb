Public Class frmProcesarDividendos
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private ds As New DataSet, dsVr As New DataSet
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAplicacion As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents c1nInteres As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nAportaciones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents c1nDistribuye As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCapitaliza As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1nExcedentes As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkIndividual As System.Windows.Forms.CheckBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpFecVerif As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents fgExp As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents c1nNoCuotasMora As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcesarDividendos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.c1nNoCuotasMora = New C1.Win.C1Input.C1NumericEdit()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkIndividual = New System.Windows.Forms.CheckBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.c1nInteres = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nAportaciones = New C1.Win.C1Input.C1NumericEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.c1nDistribuye = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCapitaliza = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c1nExcedentes = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fgExp = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.dtpFecVerif = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnAplicacion = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1nNoCuotasMora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nAportaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nDistribuye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCapitaliza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nExcedentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cbTipo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.c1nNoCuotasMora)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.chkIndividual)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(759, 142)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aplicación de Dividendos"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(148, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(240, 18)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Aplicación de Dividendos a Cuentas:"
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Items.AddRange(New Object() {"Aportaciones", "Ahorros", "Préstamos"})
        Me.cbTipo.Location = New System.Drawing.Point(151, 50)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(259, 25)
        Me.cbTipo.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(414, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 18)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Número cuotas en mora:"
        '
        'c1nNoCuotasMora
        '
        Me.c1nNoCuotasMora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nNoCuotasMora.CustomFormat = "###,##0.00"
        Me.c1nNoCuotasMora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nNoCuotasMora.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nNoCuotasMora.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nNoCuotasMora.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nNoCuotasMora.Location = New System.Drawing.Point(418, 50)
        Me.c1nNoCuotasMora.Name = "c1nNoCuotasMora"
        Me.c1nNoCuotasMora.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nNoCuotasMora.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nNoCuotasMora.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nNoCuotasMora.Size = New System.Drawing.Size(134, 23)
        Me.c1nNoCuotasMora.TabIndex = 2
        Me.c1nNoCuotasMora.Tag = Nothing
        Me.c1nNoCuotasMora.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nNoCuotasMora.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(23, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 23)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 20)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Fecha de aplicación:"
        '
        'chkIndividual
        '
        Me.chkIndividual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIndividual.Location = New System.Drawing.Point(418, 100)
        Me.chkIndividual.Name = "chkIndividual"
        Me.chkIndividual.Size = New System.Drawing.Size(249, 19)
        Me.chkIndividual.TabIndex = 3
        Me.chkIndividual.Text = "Aplicación individual de dividendos"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Enabled = False
        Me.txtDui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDui.Location = New System.Drawing.Point(257, 100)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(125, 21)
        Me.txtDui.TabIndex = 5
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(257, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 19)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "Dui:"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.Enabled = False
        Me.txtNoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.Location = New System.Drawing.Point(23, 100)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(227, 23)
        Me.txtNoCuenta.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 19)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "No. de Cuenta:"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(247, 130)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(275, 34)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "(Rango de fechas en el que será permitida la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entrega de dividendos en caja)"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(176, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 19)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Hasta:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 19)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Desde:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(251, 167)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(105, 22)
        Me.dtpHasta.TabIndex = 7
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(68, 167)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(106, 22)
        Me.dtpDesde.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(240, 28)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Período entrega de Dividendos:"
        '
        'c1nInteres
        '
        Me.c1nInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nInteres.CustomFormat = "#00.00"
        Me.c1nInteres.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nInteres.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nInteres.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nInteres.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nInteres.Location = New System.Drawing.Point(251, 95)
        Me.c1nInteres.Name = "c1nInteres"
        Me.c1nInteres.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nInteres.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nInteres.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nInteres.Size = New System.Drawing.Size(96, 23)
        Me.c1nInteres.TabIndex = 3
        Me.c1nInteres.Tag = Nothing
        Me.c1nInteres.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nInteres.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nAportaciones
        '
        Me.c1nAportaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nAportaciones.CustomFormat = "#00.00"
        Me.c1nAportaciones.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nAportaciones.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nAportaciones.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nAportaciones.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nAportaciones.Location = New System.Drawing.Point(251, 67)
        Me.c1nAportaciones.Name = "c1nAportaciones"
        Me.c1nAportaciones.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nAportaciones.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nAportaciones.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nAportaciones.Size = New System.Drawing.Size(96, 23)
        Me.c1nAportaciones.TabIndex = 2
        Me.c1nAportaciones.Tag = Nothing
        Me.c1nAportaciones.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nAportaciones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 19)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "% de Rentabilidad para Intereses:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(4, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 18)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "% de Rentabilidad para Aportaciones:"
        '
        'c1nDistribuye
        '
        Me.c1nDistribuye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nDistribuye.CustomFormat = "#00.00"
        Me.c1nDistribuye.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nDistribuye.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nDistribuye.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nDistribuye.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nDistribuye.Location = New System.Drawing.Point(652, 95)
        Me.c1nDistribuye.Name = "c1nDistribuye"
        Me.c1nDistribuye.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nDistribuye.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nDistribuye.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nDistribuye.Size = New System.Drawing.Size(96, 23)
        Me.c1nDistribuye.TabIndex = 5
        Me.c1nDistribuye.Tag = Nothing
        Me.c1nDistribuye.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nDistribuye.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nCapitaliza
        '
        Me.c1nCapitaliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCapitaliza.CustomFormat = "#00.00"
        Me.c1nCapitaliza.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nCapitaliza.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCapitaliza.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCapitaliza.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nCapitaliza.Location = New System.Drawing.Point(652, 67)
        Me.c1nCapitaliza.Name = "c1nCapitaliza"
        Me.c1nCapitaliza.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCapitaliza.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCapitaliza.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCapitaliza.Size = New System.Drawing.Size(96, 23)
        Me.c1nCapitaliza.TabIndex = 4
        Me.c1nCapitaliza.Tag = Nothing
        Me.c1nCapitaliza.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCapitaliza.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(454, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "% a Distribuir:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(454, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "% a Capitalizar:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(454, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 19)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Factores de Distribución de Dividendos:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(355, 18)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Factores de Cálculo para Aplicación de Dividendos:"
        '
        'c1nExcedentes
        '
        Me.c1nExcedentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nExcedentes.CustomFormat = "###,###,##0.00"
        Me.c1nExcedentes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nExcedentes.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nExcedentes.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nExcedentes.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nExcedentes.Location = New System.Drawing.Point(457, 18)
        Me.c1nExcedentes.Name = "c1nExcedentes"
        Me.c1nExcedentes.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nExcedentes.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nExcedentes.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nExcedentes.Size = New System.Drawing.Size(115, 23)
        Me.c1nExcedentes.TabIndex = 1
        Me.c1nExcedentes.Tag = Nothing
        Me.c1nExcedentes.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nExcedentes.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(268, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 21)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Total Excedentes a Distribuir:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(193, 18)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.ShowUpDown = True
        Me.dtpFecha.Size = New System.Drawing.Size(67, 22)
        Me.dtpFecha.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 21)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Año del Ejercicio a Distribuir:"
        '
        'fgExp
        '
        Me.fgExp.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgExp.AllowEditing = False
        Me.fgExp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgExp.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.fgExp.ColumnInfo = "3,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.fgExp.Location = New System.Drawing.Point(1530, 202)
        Me.fgExp.Name = "fgExp"
        Me.fgExp.Rows.Count = 1
        Me.fgExp.Rows.DefaultSize = 21
        Me.fgExp.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fgExp.Size = New System.Drawing.Size(0, 148)
        Me.fgExp.StyleInfo = resources.GetString("fgExp.StyleInfo")
        Me.fgExp.TabIndex = 14
        Me.fgExp.Visible = False
        '
        'dtpFecVerif
        '
        Me.dtpFecVerif.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecVerif.Location = New System.Drawing.Point(366, 12)
        Me.dtpFecVerif.Name = "dtpFecVerif"
        Me.dtpFecVerif.Size = New System.Drawing.Size(106, 22)
        Me.dtpFecVerif.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(301, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 18)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Fecha:"
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.fg.ColumnInfo = "3,0,0,0,0,105,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.fg.Location = New System.Drawing.Point(4, 51)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(631, 250)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 4
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(28, 73)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(771, 529)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 12
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroButton1)
        Me.MetroTabPage1.Controls.Add(Me.btnAplicacion)
        Me.MetroTabPage1.Controls.Add(Me.btnGuardar1)
        Me.MetroTabPage1.Controls.Add(Me.btnProcesar1)
        Me.MetroTabPage1.Controls.Add(Me.Label18)
        Me.MetroTabPage1.Controls.Add(Me.dtpHasta)
        Me.MetroTabPage1.Controls.Add(Me.Label12)
        Me.MetroTabPage1.Controls.Add(Me.GroupBox2)
        Me.MetroTabPage1.Controls.Add(Me.Label4)
        Me.MetroTabPage1.Controls.Add(Me.Label11)
        Me.MetroTabPage1.Controls.Add(Me.dtpDesde)
        Me.MetroTabPage1.Controls.Add(Me.dtpFecha)
        Me.MetroTabPage1.Controls.Add(Me.Label1)
        Me.MetroTabPage1.Controls.Add(Me.c1nExcedentes)
        Me.MetroTabPage1.Controls.Add(Me.Label10)
        Me.MetroTabPage1.Controls.Add(Me.Label5)
        Me.MetroTabPage1.Controls.Add(Me.c1nDistribuye)
        Me.MetroTabPage1.Controls.Add(Me.c1nInteres)
        Me.MetroTabPage1.Controls.Add(Me.Label3)
        Me.MetroTabPage1.Controls.Add(Me.c1nCapitaliza)
        Me.MetroTabPage1.Controls.Add(Me.Label9)
        Me.MetroTabPage1.Controls.Add(Me.Label8)
        Me.MetroTabPage1.Controls.Add(Me.Label2)
        Me.MetroTabPage1.Controls.Add(Me.c1nAportaciones)
        Me.MetroTabPage1.Controls.Add(Me.Label6)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 12
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(763, 487)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Distribución de dividendos"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 12
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(515, 359)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(117, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 69
        Me.MetroButton1.Text = "Imprimir"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        Me.MetroButton1.Visible = False
        '
        'btnAplicacion
        '
        Me.btnAplicacion.Location = New System.Drawing.Point(346, 359)
        Me.btnAplicacion.Name = "btnAplicacion"
        Me.btnAplicacion.Size = New System.Drawing.Size(162, 32)
        Me.btnAplicacion.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAplicacion.TabIndex = 68
        Me.btnAplicacion.Text = "3. &Aplicar Dividendos"
        Me.btnAplicacion.UseSelectable = True
        Me.btnAplicacion.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(176, 359)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(162, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 67
        Me.btnGuardar1.Text = "2. &Guardar Matriz"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(7, 359)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(162, 32)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 66
        Me.btnProcesar1.Text = "1. G&enerar Matriz"
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroButton6)
        Me.MetroTabPage2.Controls.Add(Me.MetroButton5)
        Me.MetroTabPage2.Controls.Add(Me.MetroButton4)
        Me.MetroTabPage2.Controls.Add(Me.MetroButton3)
        Me.MetroTabPage2.Controls.Add(Me.MetroButton2)
        Me.MetroTabPage2.Controls.Add(Me.dtpFecVerif)
        Me.MetroTabPage2.Controls.Add(Me.fg)
        Me.MetroTabPage2.Controls.Add(Me.Label17)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 12
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(763, 487)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Verificación - Aplicación de dividendos no cobrados"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 12
        '
        'MetroButton6
        '
        Me.MetroButton6.Location = New System.Drawing.Point(582, 380)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(113, 32)
        Me.MetroButton6.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton6.TabIndex = 71
        Me.MetroButton6.Text = "Imprimir"
        Me.MetroButton6.UseSelectable = True
        Me.MetroButton6.UseStyleColors = True
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(244, 380)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(331, 32)
        Me.MetroButton5.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton5.TabIndex = 70
        Me.MetroButton5.Text = "&Imprimir (Registros en los que no se capitalizará)"
        Me.MetroButton5.UseSelectable = True
        Me.MetroButton5.UseStyleColors = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(124, 380)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(112, 32)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton4.TabIndex = 69
        Me.MetroButton4.Text = "Exportar"
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(4, 380)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(112, 32)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 68
        Me.MetroButton3.Text = "Capitalizar"
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(4, 12)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(290, 32)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 67
        Me.MetroButton2.Text = " &Verificación de dividendos no cobrados   "
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'frmProcesarDividendos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(812, 628)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.fgExp)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProcesarDividendos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "  Proceso de Distribución de Dividendos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1nNoCuotasMora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nInteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nAportaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nDistribuye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCapitaliza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nExcedentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmProcesarDividendos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbTipo.SelectedIndex = 0
        Me.dtpFecha.Value = Now
        Me.dtpFecVerif.Value = Now
    End Sub




    Private Sub chkIndividual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIndividual.CheckedChanged
        If Me.chkIndividual.Checked = True Then
            Me.txtDui.Enabled = True
            Me.txtNoCuenta.Enabled = True
        Else
            Me.txtDui.Enabled = False
            Me.txtNoCuenta.Enabled = False
            Me.txtNoCuenta.Text = ""
        End If
    End Sub


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Dim oItem As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            oItem.Timeout = -1
            Me.Cursor = Cursors.WaitCursor
            ds = oItem.ProcesoDividendo(Me.dtpFecha.Value.ToShortDateString, "1", c1nAportaciones.Value, Me.c1nInteres.Value, Me.c1nExcedentes.Value, Me.c1nCapitaliza.Value, Me.c1nDistribuye.Value, Me.c1nNoCuotasMora.Value, sUsuario, sPassword, sSucursal)
            Dim openDlg As SaveFileDialog = New SaveFileDialog, Resultado As DialogResult
            openDlg.Filter = "Archivos Excel (*.csv)|*.csv"
            openDlg.FileName = "Dividendos"
            Resultado = openDlg.ShowDialog()
            If Resultado = DialogResult.OK Then
                If openDlg.FileName.Trim = "" Then
                    MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Me.fgExp.DataSource = ds.Tables(0)
                    Me.fgExp.SaveGrid(openDlg.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                    MessageBox.Show("Proceso finalizado con éxito.", "Cálculo y Aplicación de Dividendos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            Me.Cursor = Cursors.Default
            Me.btnGuardar1.Enabled = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAplicacion_Click(sender As Object, e As EventArgs) Handles btnAplicacion.Click
        Try
            Dim oAsoc As New wrAsociados.wsLibAsoc, pResp As String
            oAsoc.Timeout = -1
            Me.Cursor = Cursors.WaitCursor
            If Me.chkIndividual.Checked AndAlso (Me.txtNoCuenta.Text.Trim = "" Or Me.txtDui.Text.Trim = "") Then
                MessageBox.Show("Debe digitar el No. Cuenta y el dui.", "Aplicación de Dividendos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            pResp = oAsoc.Aplicacion_Dividendos_Cuentas(Me.cbTipo.SelectedIndex, Me.dtpFecha.Value.Year, Me.c1nNoCuotasMora.Value, "1", Me.chkIndividual.Checked, Trim(txtDui.Text), Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
            If pResp.Trim = "" Then
                MessageBox.Show("Dividendos aplicados.", "Cálculo y Aplicación de Dividendos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(pResp, "Aplicación de Dividendos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar1_Click_1(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oItem As New wrAsociados.wsLibAsoc, pResp As String
            oItem.Timeout = -1
            Me.Cursor = Cursors.WaitCursor
            pResp = oItem.AlmacenarMatrizDividendos(Me.dtpFecha.Value.Year, Me.c1nAportaciones.Value, Me.c1nInteres.Value, Me.c1nExcedentes.Value, Me.c1nCapitaliza.Value, Me.c1nDistribuye.Value, Me.c1nNoCuotasMora.Value, Me.dtpDesde.Value, Me.dtpHasta.Value, sUsuario, sPassword, sSucursal)
            If pResp.Trim = "" Then
                MessageBox.Show("Datos almacenados.", "Cálculo y Aplicación de Dividendos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btnAplicacion.Enabled = True
                Me.btnProcesar1.Enabled = False
            Else
                MessageBox.Show(pResp, "Cálculo y Aplicación de Dividendos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim oAsoc As New wrAsociados.wsLibAsoc
            oAsoc.Timeout = -1
            Me.Cursor = Cursors.WaitCursor
            dsVr = oAsoc.Verificacion_DividendosNoCobrados(Me.dtpFecVerif.Value.Year, sUsuario, sPassword, sSucursal)
            Me.fg.DataSource = dsVr.Tables(0)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If fg.Row <> -1 Then
                Dim oAsoc As New wrAsociados.wsLibAsoc, pResp As String
                Me.Cursor = Cursors.WaitCursor
                oAsoc.Timeout = -1
                pResp = oAsoc.Aplicacion_Dividendos_NoCobrados(dtpFecVerif.Value.Year, dsVr, Me.dtpFecVerif.Value, sUsuario, sPassword, sSucursal)
                If pResp = "" Then
                    MessageBox.Show("Dividendos aplicados.", "Aplicación de Dividendos no cobrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs) Handles MetroTabPage2.Click

    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Try
            If fg.Row <> -1 Then
                Me.Cursor = Cursors.WaitCursor
                Dim openDlg As SaveFileDialog = New SaveFileDialog
                Dim Resultado As DialogResult
                openDlg.Filter = "Archivos Excel (*.csv)|*.csv"
                openDlg.FileName = "Dividendos_NoCobrados"
                Resultado = openDlg.ShowDialog()
                If Resultado = DialogResult.OK Then
                    If openDlg.FileName.Trim = "" Then
                        MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    Else
                        Me.fg.SaveGrid(openDlg.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                        MessageBox.Show("El archivo ha sido generado.", "Exportación datos Dividendos no cobrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exportación datos Dividendos no cobrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        If fg.Row <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            Dim oAsoc As New wrAsociados.wsLibAsoc, dsI As New DataSet
            dsI = oAsoc.Impresion_DividendosNoCobrados(Me.dtpFecVerif.Value.Year, "SinAportacion", sUsuario, sPassword, sSucursal)
            Me.Cursor = Cursors.Default
            Dim ofrm As New frmVisor(dsI, 177, 0)
            ofrm.ShowDialog()
        End If
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        If fg.Row <> -1 Then
            Me.Cursor = Cursors.WaitCursor
            Dim oAsoc As New wrAsociados.wsLibAsoc, dsI As New DataSet
            dsI = oAsoc.Impresion_DividendosNoCobrados(Me.dtpFecVerif.Value.Year, "ConAportacion", sUsuario, sPassword, sSucursal)
            Me.Cursor = Cursors.Default
            Dim ofrm As New frmVisor(dsI, 177, 0)
            ofrm.ShowDialog()
        End If
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
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub c1nCapitaliza_TextChanged(sender As Object, e As EventArgs) Handles c1nCapitaliza.TextChanged

    End Sub

    Private Sub frmProcesarDividendos_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class