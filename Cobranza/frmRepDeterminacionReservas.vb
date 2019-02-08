Public Class frmRepDeterminacionReservas
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Dim pTipo As wrCredito.TipoAgrupacionCreditos

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
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents c1nReservaCI As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents c1nNo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nReserva As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents c1nNoCP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nSaldoCP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nReservaCP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents c1nNoDP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nSaldoDP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nReservaDP As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkIndice As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.c1nNoDP = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nSaldoDP = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nReservaDP = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.c1nNoCP = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nSaldoCP = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nReservaCP = New C1.Win.C1Input.C1NumericEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.c1nNo = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nReserva = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.c1nReservaCI = New C1.Win.C1Input.C1NumericEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkIndice = New System.Windows.Forms.CheckBox()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox4.SuspendLayout()
        CType(Me.c1nNoDP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSaldoDP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nReservaDP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1nNoCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSaldoCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nReservaCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.c1nNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nReservaCI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.c1nNoDP)
        Me.GroupBox4.Controls.Add(Me.c1nSaldoDP)
        Me.GroupBox4.Controls.Add(Me.c1nReservaDP)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(28, 245)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(504, 56)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Documentos por Cobrar:"
        '
        'c1nNoDP
        '
        Me.c1nNoDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nNoDP.CalculatorButtonStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c1nNoDP.CustomFormat = "##0"
        Me.c1nNoDP.DataType = GetType(Short)
        Me.c1nNoDP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nNoDP.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nNoDP.Increment = CType(1, Short)
        Me.c1nNoDP.Location = New System.Drawing.Point(40, 24)
        Me.c1nNoDP.MaxLength = 3
        Me.c1nNoDP.Name = "c1nNoDP"
        Me.c1nNoDP.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nNoDP.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nNoDP.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nNoDP.ShowDropDownButton = False
        Me.c1nNoDP.ShowUpDownButtons = False
        Me.c1nNoDP.Size = New System.Drawing.Size(80, 21)
        Me.c1nNoDP.TabIndex = 0
        Me.c1nNoDP.Tag = Nothing
        Me.c1nNoDP.Value = CType(0, Short)
        '
        'c1nSaldoDP
        '
        Me.c1nSaldoDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldoDP.CustomFormat = "###,###,##0.00"
        Me.c1nSaldoDP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSaldoDP.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldoDP.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nSaldoDP.Location = New System.Drawing.Point(184, 24)
        Me.c1nSaldoDP.Name = "c1nSaldoDP"
        Me.c1nSaldoDP.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldoDP.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldoDP.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldoDP.ShowDropDownButton = False
        Me.c1nSaldoDP.ShowUpDownButtons = False
        Me.c1nSaldoDP.Size = New System.Drawing.Size(112, 21)
        Me.c1nSaldoDP.TabIndex = 1
        Me.c1nSaldoDP.Tag = Nothing
        Me.c1nSaldoDP.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nReservaDP
        '
        Me.c1nReservaDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nReservaDP.CustomFormat = "###,###,##0.00"
        Me.c1nReservaDP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nReservaDP.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nReservaDP.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nReservaDP.Location = New System.Drawing.Point(376, 24)
        Me.c1nReservaDP.Name = "c1nReservaDP"
        Me.c1nReservaDP.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nReservaDP.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nReservaDP.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nReservaDP.ShowDropDownButton = False
        Me.c1nReservaDP.ShowUpDownButtons = False
        Me.c1nReservaDP.Size = New System.Drawing.Size(112, 21)
        Me.c1nReservaDP.TabIndex = 2
        Me.c1nReservaDP.Tag = Nothing
        Me.c1nReservaDP.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(312, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Reserva:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(128, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Saldo:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "No:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.c1nNoCP)
        Me.GroupBox3.Controls.Add(Me.c1nSaldoCP)
        Me.GroupBox3.Controls.Add(Me.c1nReservaCP)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(28, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(504, 56)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Costas Procesales:"
        '
        'c1nNoCP
        '
        Me.c1nNoCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nNoCP.CalculatorButtonStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c1nNoCP.CustomFormat = "##0"
        Me.c1nNoCP.DataType = GetType(Short)
        Me.c1nNoCP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nNoCP.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nNoCP.Increment = CType(1, Short)
        Me.c1nNoCP.Location = New System.Drawing.Point(40, 24)
        Me.c1nNoCP.MaxLength = 3
        Me.c1nNoCP.Name = "c1nNoCP"
        Me.c1nNoCP.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nNoCP.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nNoCP.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nNoCP.ShowDropDownButton = False
        Me.c1nNoCP.ShowUpDownButtons = False
        Me.c1nNoCP.Size = New System.Drawing.Size(80, 21)
        Me.c1nNoCP.TabIndex = 0
        Me.c1nNoCP.Tag = Nothing
        Me.c1nNoCP.Value = CType(0, Short)
        '
        'c1nSaldoCP
        '
        Me.c1nSaldoCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldoCP.CustomFormat = "###,###,##0.00"
        Me.c1nSaldoCP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSaldoCP.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldoCP.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nSaldoCP.Location = New System.Drawing.Point(184, 24)
        Me.c1nSaldoCP.Name = "c1nSaldoCP"
        Me.c1nSaldoCP.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldoCP.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldoCP.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldoCP.ShowDropDownButton = False
        Me.c1nSaldoCP.ShowUpDownButtons = False
        Me.c1nSaldoCP.Size = New System.Drawing.Size(112, 21)
        Me.c1nSaldoCP.TabIndex = 1
        Me.c1nSaldoCP.Tag = Nothing
        Me.c1nSaldoCP.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nReservaCP
        '
        Me.c1nReservaCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nReservaCP.CustomFormat = "###,###,##0.00"
        Me.c1nReservaCP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nReservaCP.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nReservaCP.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nReservaCP.Location = New System.Drawing.Point(376, 24)
        Me.c1nReservaCP.Name = "c1nReservaCP"
        Me.c1nReservaCP.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nReservaCP.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nReservaCP.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nReservaCP.ShowDropDownButton = False
        Me.c1nReservaCP.ShowUpDownButtons = False
        Me.c1nReservaCP.Size = New System.Drawing.Size(112, 21)
        Me.c1nReservaCP.TabIndex = 2
        Me.c1nReservaCP.Tag = Nothing
        Me.c1nReservaCP.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(312, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Reserva:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(128, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Saldo:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.c1nNo)
        Me.GroupBox2.Controls.Add(Me.c1nReserva)
        Me.GroupBox2.Controls.Add(Me.c1nSaldo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(26, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 56)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asignación de Reservas (Documentos en Protesto):"
        '
        'c1nNo
        '
        Me.c1nNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nNo.CalculatorButtonStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c1nNo.CustomFormat = "##0"
        Me.c1nNo.DataType = GetType(Short)
        Me.c1nNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nNo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nNo.Increment = CType(1, Short)
        Me.c1nNo.Location = New System.Drawing.Point(40, 24)
        Me.c1nNo.MaxLength = 3
        Me.c1nNo.Name = "c1nNo"
        Me.c1nNo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nNo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nNo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nNo.ShowDropDownButton = False
        Me.c1nNo.ShowUpDownButtons = False
        Me.c1nNo.Size = New System.Drawing.Size(80, 21)
        Me.c1nNo.TabIndex = 0
        Me.c1nNo.Tag = Nothing
        Me.c1nNo.Value = CType(0, Short)
        '
        'c1nReserva
        '
        Me.c1nReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nReserva.CustomFormat = "###,###,##0.00"
        Me.c1nReserva.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nReserva.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nReserva.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nReserva.Location = New System.Drawing.Point(376, 24)
        Me.c1nReserva.Name = "c1nReserva"
        Me.c1nReserva.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nReserva.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nReserva.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nReserva.ShowDropDownButton = False
        Me.c1nReserva.ShowUpDownButtons = False
        Me.c1nReserva.Size = New System.Drawing.Size(112, 21)
        Me.c1nReserva.TabIndex = 2
        Me.c1nReserva.Tag = Nothing
        Me.c1nReserva.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nSaldo
        '
        Me.c1nSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldo.CustomFormat = "###,###,##0.00"
        Me.c1nSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nSaldo.Location = New System.Drawing.Point(184, 24)
        Me.c1nSaldo.Name = "c1nSaldo"
        Me.c1nSaldo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldo.ShowDropDownButton = False
        Me.c1nSaldo.ShowUpDownButtons = False
        Me.c1nSaldo.Size = New System.Drawing.Size(112, 21)
        Me.c1nSaldo.TabIndex = 1
        Me.c1nSaldo.Tag = Nothing
        Me.c1nSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(312, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Reserva:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(136, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Saldo:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "No:"
        '
        'c1nReservaCI
        '
        Me.c1nReservaCI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nReservaCI.CustomFormat = "###,###,##0.00"
        Me.c1nReservaCI.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nReservaCI.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nReservaCI.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nReservaCI.Location = New System.Drawing.Point(213, 94)
        Me.c1nReservaCI.Name = "c1nReservaCI"
        Me.c1nReservaCI.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nReservaCI.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nReservaCI.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nReservaCI.ShowDropDownButton = False
        Me.c1nReservaCI.ShowUpDownButtons = False
        Me.c1nReservaCI.Size = New System.Drawing.Size(109, 21)
        Me.c1nReservaCI.TabIndex = 1
        Me.c1nReservaCI.Tag = Nothing
        Me.c1nReservaCI.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(23, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 16)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Reserva para Cuentas Incobrables:"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(25, 68)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(96, 16)
        Me.lblFecha.TabIndex = 38
        Me.lblFecha.Text = "Saldos a la fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(213, 68)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(109, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'chkIndice
        '
        Me.chkIndice.Location = New System.Drawing.Point(28, 307)
        Me.chkIndice.Name = "chkIndice"
        Me.chkIndice.Size = New System.Drawing.Size(152, 16)
        Me.chkIndice.TabIndex = 3
        Me.chkIndice.Text = "&Guardar Índice de Mora"
        Me.chkIndice.Visible = False
        '
        'btnProcesar1
        '
        Me.btnProcesar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnProcesar1.Location = New System.Drawing.Point(457, 307)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 1024
        Me.btnProcesar1.Text = "&Generar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmRepDeterminacionReservas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(555, 368)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.chkIndice)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.c1nReservaCI)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(555, 368)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(555, 368)
        Me.Name = "frmRepDeterminacionReservas"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Determinación de Reserva"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.c1nNoDP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSaldoDP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nReservaDP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.c1nNoCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSaldoCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nReservaCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.c1nNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nReserva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nReservaCI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"

    Public Property Tipo() As wrCredito.TipoAgrupacionCreditos
        Get
            Return pTipo
        End Get
        Set(ByVal Value As wrCredito.TipoAgrupacionCreditos)
            pTipo = Value
        End Set
    End Property

#End Region

    Private Sub frmRepDeterminacionReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
    End Sub



    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            Dim oCred As New wrCredito.wsLibCred, ds As New DataSet
            oCred.Timeout = -1
            If pTipo = wrCredito.TipoAgrupacionCreditos.TipoCredito Then
                ds = oCred.Determinacion_Reservas_Consolidado(Me.dtpFecha.Value, wrCredito.TipoAgrupacionCreditos.TipoCredito, Me.c1nSaldo.Value, Me.c1nNo.Value, Me.c1nReserva.Value, Me.c1nSaldoCP.Value, Me.c1nNoCP.Value, Me.c1nReservaCP.Value, Me.c1nReservaCI.Value, Me.c1nNoDP.Value, Me.c1nSaldoDP.Value, Me.c1nReservaDP.Value, Me.chkIndice.Checked, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 102, 0)
                ofrm.ShowDialog()
            ElseIf pTipo = wrCredito.TipoAgrupacionCreditos.TipoGarantia Then
                ds = oCred.Determinacion_Reservas_Consolidado(Me.dtpFecha.Value, wrCredito.TipoAgrupacionCreditos.TipoGarantia, Me.c1nSaldo.Value, Me.c1nNo.Value, Me.c1nReserva.Value, Me.c1nSaldoCP.Value, Me.c1nNoCP.Value, Me.c1nReservaCP.Value, Me.c1nReservaCI.Value, Me.c1nNoDP.Value, Me.c1nSaldoDP.Value, Me.c1nReservaDP.Value, Me.chkIndice.Checked, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 124, 0)
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class