Public Class frmMsAhParametros
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ahorro As New wrAhorro.wsLibAhorro
    Dim conta As New wrConta.wsLibContab
    Dim libAhorro As New sifLib.Ahorro.clsAhorros
    Public pCodTipoAhorro As String, pAccion As String
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents cbTransferencia As System.Windows.Forms.CheckBox


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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chbInactividad As System.Windows.Forms.CheckBox
    Friend WithEvents c1nPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCodCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents chkJunior As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents c1nAperturaMinima As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nMontoCuotaMinima As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nSaldoMinimo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents c1nAperturaMaxima As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents nudPlazoMaximo As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPlazoMinimo As System.Windows.Forms.NumericUpDown
    Friend WithEvents c1nMontComInact As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents c1nTmpMinComInact As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents c1nSaldoMinComInact As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents c1nPorcPig As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents c1nMontMinIntereses As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nuDiasGracia As System.Windows.Forms.NumericUpDown
    Friend WithEvents c1nTasaInteres As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpFecHastaMin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecDesdeMin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecHastaMax As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecDesdeMax As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkProm As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkJunior = New System.Windows.Forms.CheckBox()
        Me.txtCodCuenta = New C1.Win.C1Input.C1TextBox()
        Me.txtCuenta = New C1.Win.C1Input.C1TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.c1nPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chbInactividad = New System.Windows.Forms.CheckBox()
        Me.txtDesTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbTransferencia = New System.Windows.Forms.CheckBox()
        Me.chkProm = New System.Windows.Forms.CheckBox()
        Me.dtpFecHastaMax = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpFecDesdeMax = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpFecHastaMin = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFecDesdeMin = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.c1nTasaInteres = New C1.Win.C1Input.C1NumericEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nuDiasGracia = New System.Windows.Forms.NumericUpDown()
        Me.c1nPorcPig = New C1.Win.C1Input.C1NumericEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.c1nMontMinIntereses = New C1.Win.C1Input.C1NumericEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.c1nMontComInact = New C1.Win.C1Input.C1NumericEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.c1nTmpMinComInact = New C1.Win.C1Input.C1NumericEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.c1nSaldoMinComInact = New C1.Win.C1Input.C1NumericEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.nudPlazoMaximo = New System.Windows.Forms.NumericUpDown()
        Me.nudPlazoMinimo = New System.Windows.Forms.NumericUpDown()
        Me.c1nAperturaMaxima = New C1.Win.C1Input.C1NumericEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c1nAperturaMinima = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nMontoCuotaMinima = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nSaldoMinimo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtCodCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nTasaInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuDiasGracia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPorcPig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontMinIntereses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontComInact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTmpMinComInact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSaldoMinComInact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlazoMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlazoMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nAperturaMaxima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nAperturaMinima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoCuotaMinima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSaldoMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.chkJunior)
        Me.GroupBox3.Controls.Add(Me.txtCodCuenta)
        Me.GroupBox3.Controls.Add(Me.txtCuenta)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.c1nPlazo)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.chbInactividad)
        Me.GroupBox3.Controls.Add(Me.txtDesTipoAhorro)
        Me.GroupBox3.Controls.Add(Me.txtCodTipoAhorro)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(587, 105)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de tipo de ahorro"
        '
        'chkJunior
        '
        Me.chkJunior.Location = New System.Drawing.Point(302, 50)
        Me.chkJunior.Name = "chkJunior"
        Me.chkJunior.Size = New System.Drawing.Size(104, 16)
        Me.chkJunior.TabIndex = 5
        Me.chkJunior.Text = "Ahorro &Junior"
        Me.chkJunior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodCuenta
        '
        Me.txtCodCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCuenta.Location = New System.Drawing.Point(96, 72)
        Me.txtCodCuenta.MaxLength = 14
        Me.txtCodCuenta.Name = "txtCodCuenta"
        Me.txtCodCuenta.NumericInput = False
        Me.txtCodCuenta.Size = New System.Drawing.Size(64, 20)
        Me.txtCodCuenta.TabIndex = 1
        Me.txtCodCuenta.Tag = Nothing
        '
        'txtCuenta
        '
        Me.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(167, 72)
        Me.txtCuenta.MaxLength = 14
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.NumericInput = False
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(403, 20)
        Me.txtCuenta.TabIndex = 2
        Me.txtCuenta.Tag = Nothing
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 29)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Cuenta Contable:"
        '
        'c1nPlazo
        '
        Me.c1nPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPlazo.CustomFormat = "#0000"
        Me.c1nPlazo.DataType = GetType(Short)
        Me.c1nPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazo.Increment = CType(1, Short)
        Me.c1nPlazo.Location = New System.Drawing.Point(97, 45)
        Me.c1nPlazo.Name = "c1nPlazo"
        Me.c1nPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nPlazo.ShowDropDownButton = False
        Me.c1nPlazo.ShowUpDownButtons = False
        Me.c1nPlazo.Size = New System.Drawing.Size(199, 21)
        Me.c1nPlazo.TabIndex = 4
        Me.c1nPlazo.Tag = Nothing
        Me.c1nPlazo.Value = CType(0, Short)
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Plazo:"
        '
        'chbInactividad
        '
        Me.chbInactividad.Location = New System.Drawing.Point(412, 50)
        Me.chbInactividad.Name = "chbInactividad"
        Me.chbInactividad.Size = New System.Drawing.Size(120, 16)
        Me.chbInactividad.TabIndex = 6
        Me.chbInactividad.Text = "Aplica &Inactividad"
        '
        'txtDesTipoAhorro
        '
        Me.txtDesTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesTipoAhorro.Location = New System.Drawing.Point(167, 19)
        Me.txtDesTipoAhorro.Name = "txtDesTipoAhorro"
        Me.txtDesTipoAhorro.Size = New System.Drawing.Size(403, 20)
        Me.txtDesTipoAhorro.TabIndex = 2
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(97, 19)
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(64, 20)
        Me.txtCodTipoAhorro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Ahorro:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbTransferencia)
        Me.GroupBox1.Controls.Add(Me.chkProm)
        Me.GroupBox1.Controls.Add(Me.dtpFecHastaMax)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.dtpFecDesdeMax)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.dtpFecHastaMin)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpFecDesdeMin)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.c1nTasaInteres)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.nuDiasGracia)
        Me.GroupBox1.Controls.Add(Me.c1nPorcPig)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.c1nMontMinIntereses)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.c1nMontComInact)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.c1nTmpMinComInact)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.c1nSaldoMinComInact)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.nudPlazoMaximo)
        Me.GroupBox1.Controls.Add(Me.nudPlazoMinimo)
        Me.GroupBox1.Controls.Add(Me.c1nAperturaMaxima)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.c1nAperturaMinima)
        Me.GroupBox1.Controls.Add(Me.c1nMontoCuotaMinima)
        Me.GroupBox1.Controls.Add(Me.c1nSaldoMinimo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 311)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros de ahorro"
        '
        'cbTransferencia
        '
        Me.cbTransferencia.AutoSize = True
        Me.cbTransferencia.Location = New System.Drawing.Point(287, 46)
        Me.cbTransferencia.Name = "cbTransferencia"
        Me.cbTransferencia.Size = New System.Drawing.Size(147, 17)
        Me.cbTransferencia.TabIndex = 5
        Me.cbTransferencia.Text = "Transferencia Automatica"
        Me.cbTransferencia.UseVisualStyleBackColor = True
        '
        'chkProm
        '
        Me.chkProm.Location = New System.Drawing.Point(11, 46)
        Me.chkProm.Name = "chkProm"
        Me.chkProm.Size = New System.Drawing.Size(262, 23)
        Me.chkProm.TabIndex = 4
        Me.chkProm.Text = "Promocional (Aplica cambio a tasa vigente)"
        Me.chkProm.Visible = False
        '
        'dtpFecHastaMax
        '
        Me.dtpFecHastaMax.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecHastaMax.Location = New System.Drawing.Point(444, 154)
        Me.dtpFecHastaMax.Name = "dtpFecHastaMax"
        Me.dtpFecHastaMax.Size = New System.Drawing.Size(126, 20)
        Me.dtpFecHastaMax.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(284, 162)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Válido hasta:"
        '
        'dtpFecDesdeMax
        '
        Me.dtpFecDesdeMax.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDesdeMax.Location = New System.Drawing.Point(145, 156)
        Me.dtpFecDesdeMax.Name = "dtpFecDesdeMax"
        Me.dtpFecDesdeMax.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecDesdeMax.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(8, 162)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Válido desde:"
        '
        'dtpFecHastaMin
        '
        Me.dtpFecHastaMin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecHastaMin.Location = New System.Drawing.Point(442, 128)
        Me.dtpFecHastaMin.Name = "dtpFecHastaMin"
        Me.dtpFecHastaMin.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecHastaMin.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(284, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Válido hasta:"
        '
        'dtpFecDesdeMin
        '
        Me.dtpFecDesdeMin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDesdeMin.Location = New System.Drawing.Point(145, 128)
        Me.dtpFecDesdeMin.Name = "dtpFecDesdeMin"
        Me.dtpFecDesdeMin.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecDesdeMin.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(8, 133)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Válido desde:"
        '
        'c1nTasaInteres
        '
        Me.c1nTasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasaInteres.CustomFormat = "###,###,##0.00"
        Me.c1nTasaInteres.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTasaInteres.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasaInteres.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nTasaInteres.Location = New System.Drawing.Point(139, 278)
        Me.c1nTasaInteres.Name = "c1nTasaInteres"
        Me.c1nTasaInteres.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasaInteres.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasaInteres.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasaInteres.ShowDropDownButton = False
        Me.c1nTasaInteres.ShowUpDownButtons = False
        Me.c1nTasaInteres.Size = New System.Drawing.Size(134, 21)
        Me.c1nTasaInteres.TabIndex = 36
        Me.c1nTasaInteres.Tag = Nothing
        Me.c1nTasaInteres.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 278)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 21)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Tasa de Interés:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(306, 279)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(66, 20)
        Me.TextBox3.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(284, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 24)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Días de Gracia:"
        '
        'nuDiasGracia
        '
        Me.nuDiasGracia.Location = New System.Drawing.Point(442, 246)
        Me.nuDiasGracia.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nuDiasGracia.Name = "nuDiasGracia"
        Me.nuDiasGracia.Size = New System.Drawing.Size(128, 20)
        Me.nuDiasGracia.TabIndex = 34
        Me.nuDiasGracia.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nuDiasGracia.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'c1nPorcPig
        '
        Me.c1nPorcPig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPorcPig.CustomFormat = "###,###,##0.00"
        Me.c1nPorcPig.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nPorcPig.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPorcPig.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nPorcPig.Location = New System.Drawing.Point(142, 246)
        Me.c1nPorcPig.Name = "c1nPorcPig"
        Me.c1nPorcPig.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPorcPig.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPorcPig.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nPorcPig.ShowDropDownButton = False
        Me.c1nPorcPig.ShowUpDownButtons = False
        Me.c1nPorcPig.Size = New System.Drawing.Size(131, 21)
        Me.c1nPorcPig.TabIndex = 32
        Me.c1nPorcPig.Tag = Nothing
        Me.c1nPorcPig.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 32)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Porcentaje pignoración:"
        '
        'c1nMontMinIntereses
        '
        Me.c1nMontMinIntereses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontMinIntereses.CustomFormat = "###,###,##0.00"
        Me.c1nMontMinIntereses.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontMinIntereses.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontMinIntereses.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontMinIntereses.Location = New System.Drawing.Point(442, 214)
        Me.c1nMontMinIntereses.Name = "c1nMontMinIntereses"
        Me.c1nMontMinIntereses.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontMinIntereses.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontMinIntereses.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontMinIntereses.ShowDropDownButton = False
        Me.c1nMontMinIntereses.ShowUpDownButtons = False
        Me.c1nMontMinIntereses.Size = New System.Drawing.Size(128, 21)
        Me.c1nMontMinIntereses.TabIndex = 30
        Me.c1nMontMinIntereses.Tag = Nothing
        Me.c1nMontMinIntereses.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(284, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 24)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Monto Mínimo de Intereses:"
        '
        'c1nMontComInact
        '
        Me.c1nMontComInact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontComInact.CustomFormat = "###,###,##0.00"
        Me.c1nMontComInact.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontComInact.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontComInact.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontComInact.Location = New System.Drawing.Point(142, 214)
        Me.c1nMontComInact.Name = "c1nMontComInact"
        Me.c1nMontComInact.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontComInact.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontComInact.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontComInact.ShowDropDownButton = False
        Me.c1nMontComInact.ShowUpDownButtons = False
        Me.c1nMontComInact.Size = New System.Drawing.Size(131, 21)
        Me.c1nMontComInact.TabIndex = 28
        Me.c1nMontComInact.Tag = Nothing
        Me.c1nMontComInact.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 32)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Monto de Comisión por Inactividad:"
        '
        'c1nTmpMinComInact
        '
        Me.c1nTmpMinComInact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTmpMinComInact.CustomFormat = "###,###,##0"
        Me.c1nTmpMinComInact.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTmpMinComInact.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTmpMinComInact.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nTmpMinComInact.Location = New System.Drawing.Point(145, 182)
        Me.c1nTmpMinComInact.Name = "c1nTmpMinComInact"
        Me.c1nTmpMinComInact.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTmpMinComInact.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTmpMinComInact.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTmpMinComInact.ShowDropDownButton = False
        Me.c1nTmpMinComInact.ShowUpDownButtons = False
        Me.c1nTmpMinComInact.Size = New System.Drawing.Size(128, 21)
        Me.c1nTmpMinComInact.TabIndex = 24
        Me.c1nTmpMinComInact.Tag = Nothing
        Me.c1nTmpMinComInact.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 31)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Tiempo Mínimo de Comisión de Inactividad:"
        '
        'c1nSaldoMinComInact
        '
        Me.c1nSaldoMinComInact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldoMinComInact.CustomFormat = "###,###,##0.00"
        Me.c1nSaldoMinComInact.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSaldoMinComInact.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldoMinComInact.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nSaldoMinComInact.Location = New System.Drawing.Point(444, 180)
        Me.c1nSaldoMinComInact.Name = "c1nSaldoMinComInact"
        Me.c1nSaldoMinComInact.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldoMinComInact.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldoMinComInact.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldoMinComInact.ShowDropDownButton = False
        Me.c1nSaldoMinComInact.ShowUpDownButtons = False
        Me.c1nSaldoMinComInact.Size = New System.Drawing.Size(126, 21)
        Me.c1nSaldoMinComInact.TabIndex = 26
        Me.c1nSaldoMinComInact.Tag = Nothing
        Me.c1nSaldoMinComInact.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(284, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 31)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Saldo Mínimo de Comisión de Inactividad:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(287, 126)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(18, 20)
        Me.TextBox2.TabIndex = 182
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(320, 46)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(18, 23)
        Me.TextBox1.TabIndex = 6
        '
        'nudPlazoMaximo
        '
        Me.nudPlazoMaximo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPlazoMaximo.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPlazoMaximo.Location = New System.Drawing.Point(442, 75)
        Me.nudPlazoMaximo.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudPlazoMaximo.Name = "nudPlazoMaximo"
        Me.nudPlazoMaximo.Size = New System.Drawing.Size(128, 20)
        Me.nudPlazoMaximo.TabIndex = 10
        Me.nudPlazoMaximo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nudPlazoMaximo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPlazoMinimo
        '
        Me.nudPlazoMinimo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPlazoMinimo.Location = New System.Drawing.Point(145, 75)
        Me.nudPlazoMinimo.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nudPlazoMinimo.Name = "nudPlazoMinimo"
        Me.nudPlazoMinimo.Size = New System.Drawing.Size(56, 20)
        Me.nudPlazoMinimo.TabIndex = 8
        Me.nudPlazoMinimo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nudPlazoMinimo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'c1nAperturaMaxima
        '
        Me.c1nAperturaMaxima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nAperturaMaxima.CustomFormat = "###,###,##0.00"
        Me.c1nAperturaMaxima.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nAperturaMaxima.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nAperturaMaxima.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nAperturaMaxima.Location = New System.Drawing.Point(442, 101)
        Me.c1nAperturaMaxima.Name = "c1nAperturaMaxima"
        Me.c1nAperturaMaxima.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nAperturaMaxima.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nAperturaMaxima.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nAperturaMaxima.ShowDropDownButton = False
        Me.c1nAperturaMaxima.ShowUpDownButtons = False
        Me.c1nAperturaMaxima.Size = New System.Drawing.Size(128, 21)
        Me.c1nAperturaMaxima.TabIndex = 14
        Me.c1nAperturaMaxima.Tag = Nothing
        Me.c1nAperturaMaxima.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(284, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Plazo Máximo:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Plazo Mínimo:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(284, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Monto de Apertura Máxima:"
        '
        'c1nAperturaMinima
        '
        Me.c1nAperturaMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nAperturaMinima.CustomFormat = "###,###,##0.00"
        Me.c1nAperturaMinima.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nAperturaMinima.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nAperturaMinima.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nAperturaMinima.Location = New System.Drawing.Point(145, 101)
        Me.c1nAperturaMinima.Name = "c1nAperturaMinima"
        Me.c1nAperturaMinima.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nAperturaMinima.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nAperturaMinima.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nAperturaMinima.ShowDropDownButton = False
        Me.c1nAperturaMinima.ShowUpDownButtons = False
        Me.c1nAperturaMinima.Size = New System.Drawing.Size(128, 21)
        Me.c1nAperturaMinima.TabIndex = 12
        Me.c1nAperturaMinima.Tag = Nothing
        Me.c1nAperturaMinima.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nMontoCuotaMinima
        '
        Me.c1nMontoCuotaMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoCuotaMinima.CustomFormat = "###,###,##0.00"
        Me.c1nMontoCuotaMinima.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoCuotaMinima.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoCuotaMinima.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontoCuotaMinima.Location = New System.Drawing.Point(442, 19)
        Me.c1nMontoCuotaMinima.Name = "c1nMontoCuotaMinima"
        Me.c1nMontoCuotaMinima.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoCuotaMinima.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoCuotaMinima.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoCuotaMinima.ShowDropDownButton = False
        Me.c1nMontoCuotaMinima.ShowUpDownButtons = False
        Me.c1nMontoCuotaMinima.Size = New System.Drawing.Size(128, 21)
        Me.c1nMontoCuotaMinima.TabIndex = 3
        Me.c1nMontoCuotaMinima.Tag = Nothing
        Me.c1nMontoCuotaMinima.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nSaldoMinimo
        '
        Me.c1nSaldoMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldoMinimo.CustomFormat = "###,###,##0.00"
        Me.c1nSaldoMinimo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSaldoMinimo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldoMinimo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nSaldoMinimo.Location = New System.Drawing.Point(145, 19)
        Me.c1nSaldoMinimo.Name = "c1nSaldoMinimo"
        Me.c1nSaldoMinimo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldoMinimo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldoMinimo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldoMinimo.ShowDropDownButton = False
        Me.c1nSaldoMinimo.ShowUpDownButtons = False
        Me.c1nSaldoMinimo.Size = New System.Drawing.Size(128, 21)
        Me.c1nSaldoMinimo.TabIndex = 1
        Me.c1nSaldoMinimo.Tag = Nothing
        Me.c1nSaldoMinimo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Monto de Apertura Mínima:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(284, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Monto de la Cuota Mínima:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Monto del Saldo Mínimo:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(535, 491)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Green
        Me.btnGuardar.TabIndex = 172
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmMsAhParametros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(628, 526)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhParametros"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Parámetros"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtCodCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nTasaInteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuDiasGracia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPorcPig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontMinIntereses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontComInact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTmpMinComInact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSaldoMinComInact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlazoMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlazoMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nAperturaMaxima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nAperturaMinima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoCuotaMinima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSaldoMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmMsAhParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAhorro As New wrAhorro.wsLibAhorro, oPerif As New wrConta.wsLibContab
        Dim ds As New DataSet
        Dim Filas As Data.DataRowCollection
        Try
            Me.dtpFecDesdeMax.Value = Now
            Me.dtpFecDesdeMin.Value = Now
            Me.dtpFecHastaMax.Value = Now
            Me.dtpFecHastaMin.Value = Now

            If Me.pAccion = "Modificar" Then

                If Mid(pCodTipoAhorro, 1, 1) = "2" Then
                    Me.chkProm.Visible = True
                Else
                    Me.chkProm.Visible = False
                End If
                ds = oAhorro.ConsultarTipoAhorro("*", "CodTipoAhorro='" & pCodTipoAhorro & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtCodTipoAhorro.Text = pCodTipoAhorro
                    Me.txtCodTipoAhorro.ReadOnly = True
                    Me.txtDesTipoAhorro.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    Me.c1nPlazo.Value = IIf(IsDBNull(Filas.Item(0)("Plazo")), 0, Filas.Item(0)("Plazo"))
                    Me.chkJunior.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Junior")), "0", Filas.Item(0)("Junior")) = "1", True, False)
                    Me.txtCodCuenta.Value = IIf(IsDBNull(Filas.Item(0)("IdCuenta")), "", Filas.Item(0)("IdCuenta"))
                    If Trim(Me.txtCodCuenta.Text.Trim) <> "" Then
                        ds = oPerif.ObtenerCatContab("*", "Final='S' and IdCuenta='" & Me.txtCodCuenta.Text.Trim & "'", "idCuenta", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables("Catalogo").Rows()
                        If Filas.Count > 0 Then Me.txtCuenta.Value = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    End If
                End If

                ds.Clear()
                ds = oAhorro.ConsultarParametros("*", "CodTipoAhorro='" & pCodTipoAhorro & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                '=============================
                Dim transferencias As Boolean
                '=============================
                If Filas.Count > 0 Then
                    Me.txtCodTipoAhorro.Text = pCodTipoAhorro
                    Me.txtCodTipoAhorro.Enabled = True
                    Me.c1nSaldoMinimo.Value = IIf(IsDBNull(Filas.Item(0)("MontoSaldoMinimo")), 0, Filas.Item(0)("MontoSaldoMinimo"))
                    Me.c1nMontoCuotaMinima.Value = IIf(IsDBNull(Filas.Item(0)("MontoCuotaMinima")), 0, Filas.Item(0)("MontoCuotaMinima"))
                    Me.c1nAperturaMinima.Value = IIf(IsDBNull(Filas.Item(0)("MontoAperturaMinima")), 0, Filas.Item(0)("MontoAperturaMinima"))
                    Me.c1nAperturaMaxima.Value = IIf(IsDBNull(Filas.Item(0)("MontoAperturaMaxima")), 0, Filas.Item(0)("MontoAperturaMaxima"))
                    Me.nudPlazoMinimo.Value = IIf(IsDBNull(Filas.Item(0)("PlazoMinimo")), 0, Filas.Item(0)("PlazoMinimo"))
                    Me.nudPlazoMaximo.Value = IIf(IsDBNull(Filas.Item(0)("PlazoMaximo")), 0, Filas.Item(0)("PlazoMaximo"))
                    Me.nuDiasGracia.Value = IIf(IsDBNull(Filas.Item(0)("DiasGracia")), 0, Filas.Item(0)("DiasGracia"))
                    '=========================================================
                    'MODIFICACION
                    transferencias = IIf(IsDBNull(Filas.Item(0)("Transferencia")), 0, Filas.Item(0)("Transferencia"))
                    If transferencias = True Then
                        Me.cbTransferencia.Checked = True
                    Else
                        Me.cbTransferencia.Checked = False
                    End If
                    '=========================================================
                    If IsDBNull(Filas.Item(0)("AplicaInactividad")) = False Then
                        If (Filas.Item(0)("AplicaInactividad") = 1) Then
                            Me.chbInactividad.Checked = True
                        Else
                            Me.chbInactividad.Checked = False
                        End If
                    Else
                        Me.chbInactividad.Checked = False
                    End If
                    Me.c1nSaldoMinComInact.Value = IIf(IsDBNull(Filas.Item(0)("SaldoMin_ComisionInactividad")), 0, Filas.Item(0)("SaldoMin_ComisionInactividad"))
                    Me.c1nTmpMinComInact.Value = IIf(IsDBNull(Filas.Item(0)("TiempoMin_ComisionInactividad")), 0, Filas.Item(0)("TiempoMin_ComisionInactividad"))
                    Me.c1nMontComInact.Value = IIf(IsDBNull(Filas.Item(0)("Monto_ComisionInactividad")), 0, Filas.Item(0)("Monto_ComisionInactividad"))
                    Me.c1nMontMinIntereses.Value = IIf(IsDBNull(Filas.Item(0)("MontoMin_NoInteres")), 0, Filas.Item(0)("MontoMin_NoInteres"))
                    Me.c1nTasaInteres.Value = IIf(IsDBNull(Filas.Item(0)("TasaInteres")), 0, Filas.Item(0)("TasaInteres"))
                    Me.c1nPorcPig.Value = IIf(IsDBNull(Filas.Item(0)("PorcentajePignoracion")), 0, Filas.Item(0)("PorcentajePignoracion"))
                    Me.dtpFecDesdeMin.Value = IIf(IsDBNull(Filas.Item(0)("ValidoDesdeMin")), Now, Filas.Item(0)("ValidoDesdeMin"))
                    Me.dtpFecHastaMin.Value = IIf(IsDBNull(Filas.Item(0)("ValidoHastaMin")), Now, Filas.Item(0)("ValidoHastaMin"))
                    Me.dtpFecDesdeMax.Value = IIf(IsDBNull(Filas.Item(0)("ValidoDesdeMax")), Now, Filas.Item(0)("ValidoDesdeMax"))
                    Me.dtpFecHastaMax.Value = IIf(IsDBNull(Filas.Item(0)("ValidoHastaMax")), Now, Filas.Item(0)("ValidoHastaMax"))
                    If IsDBNull(Filas.Item(0)("Promocion")) = False Then
                        If (Filas.Item(0)("Promocion") = 1) Then
                            Me.chkProm.Checked = True
                        Else
                            Me.chkProm.Checked = False
                        End If
                    End If
                Else
                    Me.chkProm.Checked = False
                End If
                ds = oAhorro.ConsultarTipoAhorro("Descripcion", "CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtDesTipoAhorro.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If
            End If
            Me.txtCodTipoAhorro.Focus()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

    End Sub
    'Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    '    Dim oAhorro As New wrAhorro.wsLibAhorro
    '    Dim pCampos, pValores As String
    '    Try
    '        Select Case oAhorro.AutorizaDatos(Trim(txtCodTipoAhorro.Text), "x", "x", "x", "x")
    '            Case 1
    '                MsgBox("El Código de Tipo de Ahorro no puede quedar vacío. Verifique e intente de nuevo", MsgBoxStyle.Critical, "Módulo Ahorro")
    '                Exit Sub
    '            Case 2
    '                MsgBox("El Código de Cuenta Contable no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
    '                Exit Sub
    '        End Select

    '        If Me.btnGuardar.Text = "&Guardar" Then
    '            pCampos = "CodTipoAhorro,Descripcion,Plazo,Junior,IdCuenta"
    '            pValores = "'" & Trim(txtCodTipoAhorro.Text) & "','" & Trim(txtDesTipoAhorro.Text) & "'," & Val(Me.c1nPlazo.Value) & ",'" & IIf(Me.chkJunior.Checked = True, "1", "0") & "','" & Me.txtCodCuenta.Value & "'"
    '            If oAhorro.InsertarTipoAhorro(pCampos, pValores, sUsuario, sPassword,sSucursal) = True Then
    '                pCampos = "CodTipoAhorro,MontoSaldoMinimo,MontoCuotaMinima, MontoAperturaMaxima,MontoAperturaMinima,PlazoMinimo,PlazoMaximo,AplicaInactividad,SaldoMin_ComisionInactividad,TiempoMin_ComisionInactividad,Monto_ComisionInactividad,MontoMin_NoInteres,TasaInteres,DiasGracia,PorcentajePignoracion,ValidoDesdeMin,ValidoHastaMin,ValidoDesdeMax,ValidoHastaMax,Promocion"
    '                pValores = "'" & Trim(Me.txtCodTipoAhorro.Text) & "','" & Val(Me.c1nSaldoMinimo.Value) & "','" & Val(Me.c1nMontoCuotaMinima.Value) & "','" & Val(Me.c1nAperturaMinima.Value) & "','" & Val(Me.c1nAperturaMaxima.Value) & "','" & Val(Me.nudPlazoMinimo.Value) & "','" & Val(Me.nudPlazoMaximo.Value) & "','" & IIf(Me.chbInactividad.Checked = True, "1", "0") & "','" & Val(Me.c1nSaldoMinComInact.Value) & "','" & Val(Me.c1nTmpMinComInact.Value) & "','" & Val(Me.c1nMontComInact.Value) & "','" & Val(Me.c1nMontMinIntereses.Value) & "','" & Val(Me.c1nTasaInteres.Value) & "'," & Val(Me.nuDiasGracia.Value) & "," & Me.c1nPorcPig.Value & ",'" & Me.dtpFecDesdeMin.Value.ToShortDateString & "','" & Me.dtpFecHastaMin.Value.ToShortDateString & "','" & Me.dtpFecDesdeMax.Value.ToShortDateString & "','" & Me.dtpFecHastaMax.Value.ToShortDateString & "','" & IIf(Me.chkProm.Checked = True, "1", "0") & "'"
    '                If oAhorro.InsertaParametros(pCampos, pValores, sUsuario, sPassword,sSucursal) = True Then
    '                    Me.Dispose()
    '                Else
    '                    MsgBox("Los parámetros NO han sido agregados", MsgBoxStyle.Information, "Error de Validación/Derechos en Módulo Ahorros")
    '                    Me.btnGuardar.Text = "&Modificar"
    '                End If
    '            Else
    '                MsgBox("El tipo de Ahorro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
    '            End If
    '        ElseIf Me.btnGuardar.Text = "&Modificar" Then
    '            pCampos = "Descripcion='" & Trim(txtDesTipoAhorro.Text) & "',Plazo=" & Val(Me.c1nPlazo.Value) & ",Junior='" & IIf(Me.chkJunior.Checked = True, "1", "0") & "',IdCuenta='" & Me.txtCodCuenta.Value & "'"
    '            If oAhorro.ModificarTipoAhorro(Trim(pCodTipoAhorro), pCampos, sUsuario, sPassword,sSucursal) = True Then
    '                pValores = "MontoSaldoMinimo='" & Val(Me.c1nSaldoMinimo.Value) & "',MontoCuotaMinima='" & Val(Me.c1nMontoCuotaMinima.Value) & "',MontoAperturaMinima='" & Val(Me.c1nAperturaMinima.Value) & "',MontoAperturaMaxima='" & Val(Me.c1nAperturaMaxima.Value) & "',PlazoMinimo='" & Val(Me.nudPlazoMinimo.Value) & "',PlazoMaximo='" & Val(Me.nudPlazoMaximo.Value) & "',AplicaInactividad='" & IIf(Me.chbInactividad.Checked = True, "1", "0") & "',SaldoMin_ComisionInactividad='" & Val(Me.c1nSaldoMinComInact.Value) & "',TiempoMin_ComisionInactividad='" & Val(Me.c1nTmpMinComInact.Value) & "',Monto_ComisionInactividad='" & Val(Me.c1nMontComInact.Value) & "',MontoMin_NoInteres='" & Val(Me.c1nMontMinIntereses.Value) & "',TasaInteres='" & Val(Me.c1nTasaInteres.Value) & "',DiasGracia=" & Val(Me.nuDiasGracia.Value) & ",PorcentajePignoracion=" & Me.c1nPorcPig.Value & ",ValidoDesdeMin='" & Me.dtpFecDesdeMin.Value.ToShortDateString & "',ValidoHastaMin='" & Me.dtpFecHastaMin.Value.ToShortDateString & "',ValidoDesdeMax='" & Me.dtpFecDesdeMax.Value.ToShortDateString & "',ValidoHastaMax='" & Me.dtpFecHastaMax.Value.ToShortDateString & "',Promocion='" & IIf(Me.chkProm.Checked = True, "1", "0") & "'"
    '                If oAhorro.ModificaParametros(Trim(Me.txtCodTipoAhorro.Text), pValores, sUsuario, sPassword,sSucursal) = True Then
    '                    Me.Dispose()
    '                Else
    '                    MsgBox("Los parámetros del tipo de ahorro NO han sido agregados", MsgBoxStyle.Information, "Error de Validación/Derechos en Módulo Ahorros")
    '                End If
    '            Else
    '                MsgBox("El tipo de Ahorro no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim oAhorro As New wrAhorro.wsLibAhorro
        Dim pCampos, pValores As String

        Try
            Select Case oAhorro.AutorizaDatos(Trim(txtCodTipoAhorro.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Código de Tipo de Ahorro no puede quedar vacío. Verifique e intente de nuevo", MsgBoxStyle.Critical, "Módulo Ahorro")
                    Exit Sub
                Case 2
                    MsgBox("El Código de Cuenta Contable no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
            End Select

            If Me.btnGuardar.Text = "Guardar" Then
                pCampos = "CodTipoAhorro,Descripcion,Plazo,Junior,IdCuenta"
                pValores = "'" & Trim(txtCodTipoAhorro.Text) & "','" & Trim(txtDesTipoAhorro.Text) & "'," & Val(Me.c1nPlazo.Value) & ",'" & IIf(Me.chkJunior.Checked = True, "1", "0") & "','" & Me.txtCodCuenta.Value & "'"
                'If oAhorro.InsertarTipoAhorro(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                pCampos = "CodTipoAhorro,MontoSaldoMinimo," &
"MontoCuotaMinima, MontoAperturaMaxima, " &
"MontoAperturaMinima,PlazoMinimo, " &
"PlazoMaximo,AplicaInactividad, " &
"SaldoMin_ComisionInactividad," &
"TiempoMin_ComisionInactividad," &
"Monto_ComisionInactividad,MontoMin_NoInteres," &
"TasaInteres,DiasGracia," &
"PorcentajePignoracion,ValidoDesdeMin," &
"ValidoHastaMin,ValidoDesdeMax," &
"ValidoHastaMax,Promocion,transferencia"
                pValores = "'" & Trim(Me.txtCodTipoAhorro.Text) & "','" & Val(Me.c1nSaldoMinimo.Value) &
                    "','" & Val(Me.c1nMontoCuotaMinima.Value) & "','" & Val(Me.c1nAperturaMaxima.Value) &
                    "','" & Val(Me.c1nAperturaMinima.Value) & "','" & Val(Me.nudPlazoMinimo.Value) &
                    "','" & Val(Me.nudPlazoMaximo.Value) & "','" & IIf(Me.chbInactividad.Checked = True, "1", "0") & "','" &
                    Val(Me.c1nSaldoMinComInact.Value) & "','" & Val(Me.c1nTmpMinComInact.Value) &
                    "','" & Val(Me.c1nMontComInact.Value) & "','" & Val(Me.c1nMontMinIntereses.Value) &
                    "','" & Val(Me.c1nTasaInteres.Value) & "'," & Val(Me.nuDiasGracia.Value) &
                    "," & Me.c1nPorcPig.Value & ",'" & Me.dtpFecDesdeMin.Value.ToShortDateString &
                    "','" & Me.dtpFecHastaMin.Value.ToShortDateString &
                    "','" & Me.dtpFecDesdeMax.Value.ToShortDateString & "','" & Me.dtpFecHastaMax.Value.ToShortDateString &
                    "','" & IIf(Me.chkProm.Checked = True, "1", "0") & "','" & IIf(Me.cbTransferencia.Checked = True, 1, 0) & "'"
                If oAhorro.InsertaParametros(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                        Me.Dispose()
                    Else
                        MsgBox("Los parámetros NO han sido agregados", MsgBoxStyle.Information, "Error de Validación/Derechos en Módulo Ahorros")
                        Me.btnGuardar.Text = "&Modificar"
                    End If
                ' Else
                'MsgBox("El tipo de Ahorro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                'End If
            ElseIf Me.btnGuardar.Text = "&Modificar" Then
                'pCampos = "Descripcion='" & Trim(txtDesTipoAhorro.Text) & "',Plazo=" & Val(Me.c1nPlazo.Value) & ",Junior='" & IIf(Me.chkJunior.Checked = True, "1", "0") & "',IdCuenta='" & Me.txtCodCuenta.Value & "'"
                'If oAhorro.ModificarTipoAhorro(Trim(pCodTipoAhorro), pCampos, sUsuario, sPassword, sSucursal) = True Then
                pValores = "MontoSaldoMinimo='" & Val(Me.c1nSaldoMinimo.Value) & "',MontoCuotaMinima='" & Val(Me.c1nMontoCuotaMinima.Value) &
                    "',MontoAperturaMinima='" & Val(Me.c1nAperturaMinima.Value) & "',MontoAperturaMaxima='" & Val(Me.c1nAperturaMaxima.Value) &
                    "',PlazoMinimo='" & Val(Me.nudPlazoMinimo.Value) & "',PlazoMaximo='" & Val(Me.nudPlazoMaximo.Value) & "',AplicaInactividad='" &
                    IIf(Me.chbInactividad.Checked = True, "1", "0") & "',SaldoMin_ComisionInactividad='" & Val(Me.c1nSaldoMinComInact.Value) &
                    "',TiempoMin_ComisionInactividad='" & Val(Me.c1nTmpMinComInact.Value) & "',Monto_ComisionInactividad='" & Val(Me.c1nMontComInact.Value) &
                    "',MontoMin_NoInteres='" & Val(Me.c1nMontMinIntereses.Value) & "',TasaInteres='" & Val(Me.c1nTasaInteres.Value) & "',DiasGracia=" &
                    Val(Me.nuDiasGracia.Value) & ",PorcentajePignoracion=" & Me.c1nPorcPig.Value & ",ValidoDesdeMin='" & Me.dtpFecDesdeMin.Value.ToShortDateString &
                    "',ValidoHastaMin='" & Me.dtpFecHastaMin.Value.ToShortDateString & "',ValidoDesdeMax='" & Me.dtpFecDesdeMax.Value.ToShortDateString & "',ValidoHastaMax='" &
                    Me.dtpFecHastaMax.Value.ToShortDateString & "',Promocion='" & IIf(Me.chkProm.Checked = True, "1", "0") & "',Transferencia ='" & IIf(Me.cbTransferencia.Checked = True, 1, 0) & "'"
                    If oAhorro.ModificaParametros(Trim(Me.txtCodTipoAhorro.Text), pValores, sUsuario, sPassword, sSucursal) = True Then
                        Me.Dispose()
                    Else
                        MsgBox("Los parámetros del tipo de ahorro NO han sido agregados", MsgBoxStyle.Information, "Error de Validación/Derechos en Módulo Ahorros")
                    End If
                'Else
                'MsgBox("El tipo de Ahorro no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                'End If
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub txtCodCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCuenta.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("IDCUENTA,DESCRIPCION", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodCuenta.Value = ofrm.Resultado.Trim
            Me.txtCuenta.Value = ofrm.Resultado2.Trim

            'If Trim(Me.txtCodCuenta.Text.Trim) <> "" Then
            '    Dim dts As New DataSet
            '    dts = oPerif.ObtenerCatContab("descripcion", "IdCuenta='" & Me.txtCodCuenta.Text.Trim & "'", "idCuenta", sUsuario, sPassword, sSucursal)
            '    If dts.Tables(0).Rows.Count > 0 Then
            '        txtCuenta.Text = dts.Tables(0).Rows(0).Item("descripcion").ToString.ToUpper
            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodTipoAhorro_DoubleClick(sender As Object, e As EventArgs) Handles txtCodTipoAhorro.DoubleClick
        Dim ofrm As New frmAGenerico
        Try

            'Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, 
            Dim ds As New DataSet
            Dim Filas As Data.DataRowCollection, dr As DataRow
            ds = ahorro.ConsultarTipoAhorro("*", "", "descripcion", sUsuario, sPassword, sSucursal)


            ofrm.Text = "Buscar Tipos de Ahorro"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()

            If ofrm.Resultado.Trim = "" Then Exit Sub

            txtCodTipoAhorro.Text = ofrm.Resultado.Trim
            txtDesTipoAhorro.Text = ofrm.Resultado2.Trim
            Me.c1nPlazo.Value = ofrm.Resultado3
            If ofrm.Resultado4.Equals("1") Then
                chkJunior.Checked = True
            End If
            txtCodCuenta.Text = ofrm.Resultado5
            If Trim(Me.txtCodCuenta.Text.Trim) <> "" Then
                Dim dts As New DataSet
                dts = conta.ObtenerCatContab("descripcion", "IdCuenta='" & Me.txtCodCuenta.Text & "'", "idCuenta", sUsuario, sPassword, sSucursal)
                If dts.Tables(0).Rows.Count > 0 Then
                    txtCuenta.Text = dts.Tables(0).Rows(0).Item("descripcion").ToString.ToUpper
                End If
            End If



        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
