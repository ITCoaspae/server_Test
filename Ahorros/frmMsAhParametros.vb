Public Class frmMsAhParametros
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ahorro As New wrAhorro.wsLibAhorro
    Dim conta As New wrConta.wsLibContab
    Dim libAhorro As New sifLib.Ahorro.clsAhorros
    Public pCodTipoAhorro As String, pAccion As String
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents cbTipoAhorro As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCtaContable As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpDesde As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpHasta As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
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
    Friend WithEvents chbInactividad As System.Windows.Forms.CheckBox
    Friend WithEvents c1nPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkJunior As System.Windows.Forms.CheckBox
    Friend WithEvents c1nAperturaMinima As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nMontoCuotaMinima As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nSaldoMinimo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nAperturaMaxima As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents nudPlazoMaximo As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPlazoMinimo As System.Windows.Forms.NumericUpDown
    Friend WithEvents c1nPorcPig As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents nuDiasGracia As System.Windows.Forms.NumericUpDown
    Friend WithEvents c1nTasaInteres As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkProm As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkJunior = New System.Windows.Forms.CheckBox()
        Me.c1nPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.chbInactividad = New System.Windows.Forms.CheckBox()
        Me.cbTransferencia = New System.Windows.Forms.CheckBox()
        Me.chkProm = New System.Windows.Forms.CheckBox()
        Me.c1nTasaInteres = New C1.Win.C1Input.C1NumericEdit()
        Me.nuDiasGracia = New System.Windows.Forms.NumericUpDown()
        Me.c1nPorcPig = New C1.Win.C1Input.C1NumericEdit()
        Me.nudPlazoMaximo = New System.Windows.Forms.NumericUpDown()
        Me.nudPlazoMinimo = New System.Windows.Forms.NumericUpDown()
        Me.c1nAperturaMaxima = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nAperturaMinima = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nMontoCuotaMinima = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nSaldoMinimo = New C1.Win.C1Input.C1NumericEdit()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.cbTipoAhorro = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cbCtaContable = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.dtpDesde = New MetroFramework.Controls.MetroDateTime()
        Me.dtpHasta = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTasaInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuDiasGracia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPorcPig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlazoMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlazoMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nAperturaMaxima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nAperturaMinima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoCuotaMinima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSaldoMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkJunior
        '
        Me.chkJunior.Location = New System.Drawing.Point(435, 96)
        Me.chkJunior.Name = "chkJunior"
        Me.chkJunior.Size = New System.Drawing.Size(125, 18)
        Me.chkJunior.TabIndex = 31
        Me.chkJunior.Text = "Ahorro &Junior"
        Me.chkJunior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkJunior.Visible = False
        '
        'c1nPlazo
        '
        Me.c1nPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPlazo.CustomFormat = "#0000"
        Me.c1nPlazo.DataType = GetType(Short)
        Me.c1nPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nPlazo.Location = New System.Drawing.Point(141, 96)
        Me.c1nPlazo.Name = "c1nPlazo"
        Me.c1nPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nPlazo.Size = New System.Drawing.Size(239, 26)
        Me.c1nPlazo.TabIndex = 3
        Me.c1nPlazo.Tag = Nothing
        Me.c1nPlazo.Value = CType(0, Short)
        Me.c1nPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chbInactividad
        '
        Me.chbInactividad.Location = New System.Drawing.Point(586, 96)
        Me.chbInactividad.Name = "chbInactividad"
        Me.chbInactividad.Size = New System.Drawing.Size(144, 18)
        Me.chbInactividad.TabIndex = 32
        Me.chbInactividad.Text = "Aplica &Inactividad"
        Me.chbInactividad.Visible = False
        '
        'cbTransferencia
        '
        Me.cbTransferencia.AutoSize = True
        Me.cbTransferencia.Location = New System.Drawing.Point(556, 30)
        Me.cbTransferencia.Name = "cbTransferencia"
        Me.cbTransferencia.Size = New System.Drawing.Size(192, 21)
        Me.cbTransferencia.TabIndex = 33
        Me.cbTransferencia.Text = "Transferencia Automatica"
        Me.cbTransferencia.UseVisualStyleBackColor = True
        Me.cbTransferencia.Visible = False
        '
        'chkProm
        '
        Me.chkProm.Location = New System.Drawing.Point(250, 27)
        Me.chkProm.Name = "chkProm"
        Me.chkProm.Size = New System.Drawing.Size(315, 27)
        Me.chkProm.TabIndex = 30
        Me.chkProm.Text = "Promocional (Aplica cambio a tasa vigente)"
        Me.chkProm.Visible = False
        '
        'c1nTasaInteres
        '
        Me.c1nTasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasaInteres.CustomFormat = "###,###,##0.00"
        Me.c1nTasaInteres.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTasaInteres.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasaInteres.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nTasaInteres.Location = New System.Drawing.Point(141, 345)
        Me.c1nTasaInteres.Name = "c1nTasaInteres"
        Me.c1nTasaInteres.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasaInteres.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasaInteres.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasaInteres.Size = New System.Drawing.Size(231, 26)
        Me.c1nTasaInteres.TabIndex = 24
        Me.c1nTasaInteres.Tag = Nothing
        Me.c1nTasaInteres.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasaInteres.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'nuDiasGracia
        '
        Me.nuDiasGracia.Location = New System.Drawing.Point(499, 345)
        Me.nuDiasGracia.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nuDiasGracia.Name = "nuDiasGracia"
        Me.nuDiasGracia.Size = New System.Drawing.Size(231, 22)
        Me.nuDiasGracia.TabIndex = 26
        Me.nuDiasGracia.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nuDiasGracia.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'c1nPorcPig
        '
        Me.c1nPorcPig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPorcPig.CustomFormat = "###,###,##0.00"
        Me.c1nPorcPig.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nPorcPig.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPorcPig.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nPorcPig.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nPorcPig.Location = New System.Drawing.Point(141, 377)
        Me.c1nPorcPig.Name = "c1nPorcPig"
        Me.c1nPorcPig.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPorcPig.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPorcPig.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nPorcPig.Size = New System.Drawing.Size(231, 26)
        Me.c1nPorcPig.TabIndex = 28
        Me.c1nPorcPig.Tag = Nothing
        Me.c1nPorcPig.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nPorcPig.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'nudPlazoMaximo
        '
        Me.nudPlazoMaximo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPlazoMaximo.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudPlazoMaximo.Location = New System.Drawing.Point(499, 248)
        Me.nudPlazoMaximo.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudPlazoMaximo.Name = "nudPlazoMaximo"
        Me.nudPlazoMaximo.Size = New System.Drawing.Size(231, 23)
        Me.nudPlazoMaximo.TabIndex = 14
        Me.nudPlazoMaximo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nudPlazoMaximo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPlazoMinimo
        '
        Me.nudPlazoMinimo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPlazoMinimo.Location = New System.Drawing.Point(141, 248)
        Me.nudPlazoMinimo.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nudPlazoMinimo.Name = "nudPlazoMinimo"
        Me.nudPlazoMinimo.Size = New System.Drawing.Size(231, 23)
        Me.nudPlazoMinimo.TabIndex = 12
        Me.nudPlazoMinimo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nudPlazoMinimo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'c1nAperturaMaxima
        '
        Me.c1nAperturaMaxima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nAperturaMaxima.CustomFormat = "###,###,##0.00"
        Me.c1nAperturaMaxima.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nAperturaMaxima.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nAperturaMaxima.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nAperturaMaxima.Location = New System.Drawing.Point(499, 277)
        Me.c1nAperturaMaxima.Name = "c1nAperturaMaxima"
        Me.c1nAperturaMaxima.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nAperturaMaxima.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nAperturaMaxima.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nAperturaMaxima.Size = New System.Drawing.Size(231, 26)
        Me.c1nAperturaMaxima.TabIndex = 18
        Me.c1nAperturaMaxima.Tag = Nothing
        Me.c1nAperturaMaxima.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nAperturaMaxima.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nAperturaMinima
        '
        Me.c1nAperturaMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nAperturaMinima.CustomFormat = "###,###,##0.00"
        Me.c1nAperturaMinima.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nAperturaMinima.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nAperturaMinima.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nAperturaMinima.Location = New System.Drawing.Point(141, 277)
        Me.c1nAperturaMinima.Name = "c1nAperturaMinima"
        Me.c1nAperturaMinima.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nAperturaMinima.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nAperturaMinima.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nAperturaMinima.Size = New System.Drawing.Size(231, 26)
        Me.c1nAperturaMinima.TabIndex = 16
        Me.c1nAperturaMinima.Tag = Nothing
        Me.c1nAperturaMinima.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nAperturaMinima.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nMontoCuotaMinima
        '
        Me.c1nMontoCuotaMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoCuotaMinima.CustomFormat = "###,###,##0.00"
        Me.c1nMontoCuotaMinima.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoCuotaMinima.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoCuotaMinima.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nMontoCuotaMinima.Location = New System.Drawing.Point(499, 216)
        Me.c1nMontoCuotaMinima.Name = "c1nMontoCuotaMinima"
        Me.c1nMontoCuotaMinima.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoCuotaMinima.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoCuotaMinima.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoCuotaMinima.Size = New System.Drawing.Size(231, 26)
        Me.c1nMontoCuotaMinima.TabIndex = 10
        Me.c1nMontoCuotaMinima.Tag = Nothing
        Me.c1nMontoCuotaMinima.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoCuotaMinima.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nSaldoMinimo
        '
        Me.c1nSaldoMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldoMinimo.CustomFormat = "###,###,##0.00"
        Me.c1nSaldoMinimo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSaldoMinimo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldoMinimo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nSaldoMinimo.Location = New System.Drawing.Point(141, 216)
        Me.c1nSaldoMinimo.Name = "c1nSaldoMinimo"
        Me.c1nSaldoMinimo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldoMinimo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldoMinimo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldoMinimo.Size = New System.Drawing.Size(231, 26)
        Me.c1nSaldoMinimo.TabIndex = 8
        Me.c1nSaldoMinimo.Tag = Nothing
        Me.c1nSaldoMinimo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nSaldoMinimo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(640, 373)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'cbTipoAhorro
        '
        Me.cbTipoAhorro.FormattingEnabled = True
        Me.cbTipoAhorro.ItemHeight = 24
        Me.cbTipoAhorro.Location = New System.Drawing.Point(141, 60)
        Me.cbTipoAhorro.Name = "cbTipoAhorro"
        Me.cbTipoAhorro.Size = New System.Drawing.Size(589, 30)
        Me.cbTipoAhorro.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbTipoAhorro.TabIndex = 1
        Me.cbTipoAhorro.UseCustomBackColor = True
        Me.cbTipoAhorro.UseCustomForeColor = True
        Me.cbTipoAhorro.UseSelectable = True
        Me.cbTipoAhorro.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 20)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Tipo Ahorro:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 99)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(45, 20)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Plazo:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 128)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(112, 20)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Cuenta Contable"
        '
        'cbCtaContable
        '
        Me.cbCtaContable.FormattingEnabled = True
        Me.cbCtaContable.ItemHeight = 24
        Me.cbCtaContable.Location = New System.Drawing.Point(141, 128)
        Me.cbCtaContable.Name = "cbCtaContable"
        Me.cbCtaContable.Size = New System.Drawing.Size(589, 30)
        Me.cbCtaContable.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCtaContable.TabIndex = 5
        Me.cbCtaContable.UseCustomBackColor = True
        Me.cbCtaContable.UseCustomForeColor = True
        Me.cbCtaContable.UseSelectable = True
        Me.cbCtaContable.UseStyleColors = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 178)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(107, 25)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Parametros"
        Me.MetroLabel4.UseStyleColors = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 216)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(92, 20)
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "Saldo Minimo"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(378, 216)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(97, 20)
        Me.MetroLabel6.TabIndex = 9
        Me.MetroLabel6.Text = "Cuota Minima:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 248)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(95, 20)
        Me.MetroLabel7.TabIndex = 11
        Me.MetroLabel7.Text = "Plazo Minimo:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(378, 248)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(97, 20)
        Me.MetroLabel8.TabIndex = 13
        Me.MetroLabel8.Text = "Plazo Maximo:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(23, 277)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(116, 20)
        Me.MetroLabel9.TabIndex = 15
        Me.MetroLabel9.Text = "Apertura Minima:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(378, 277)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(115, 20)
        Me.MetroLabel10.TabIndex = 17
        Me.MetroLabel10.Text = "Apertura Maxima"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(23, 309)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(92, 20)
        Me.MetroLabel11.TabIndex = 19
        Me.MetroLabel11.Text = "Valido Desde:"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(378, 312)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(86, 20)
        Me.MetroLabel12.TabIndex = 21
        Me.MetroLabel12.Text = "Valido Hasta:"
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(141, 309)
        Me.dtpDesde.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(231, 30)
        Me.dtpDesde.TabIndex = 20
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(499, 309)
        Me.dtpHasta.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(231, 30)
        Me.dtpHasta.TabIndex = 22
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(23, 373)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(85, 40)
        Me.MetroLabel13.TabIndex = 27
        Me.MetroLabel13.Text = "Porcentaje " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pignoración:"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(378, 345)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(81, 20)
        Me.MetroLabel14.TabIndex = 25
        Me.MetroLabel14.Text = "Días Gracia:"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(23, 345)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(81, 20)
        Me.MetroLabel15.TabIndex = 23
        Me.MetroLabel15.Text = "Tasa Interes"
        '
        'frmMsAhParametros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(755, 537)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.c1nTasaInteres)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.nuDiasGracia)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.c1nPorcPig)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.cbTransferencia)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.chkProm)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.cbCtaContable)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.chkJunior)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.cbTipoAhorro)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.chbInactividad)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.c1nPlazo)
        Me.Controls.Add(Me.c1nSaldoMinimo)
        Me.Controls.Add(Me.c1nMontoCuotaMinima)
        Me.Controls.Add(Me.nudPlazoMinimo)
        Me.Controls.Add(Me.nudPlazoMaximo)
        Me.Controls.Add(Me.c1nAperturaMinima)
        Me.Controls.Add(Me.c1nAperturaMaxima)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhParametros"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Parámetros"
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTasaInteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuDiasGracia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPorcPig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlazoMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlazoMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nAperturaMaxima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nAperturaMinima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoCuotaMinima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSaldoMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Listas"
    Protected Sub llenarTiposahorro()
        Dim dts As New DataSet
        dts = ahorro.ConsultarTipoAhorro("codTipoAhorro,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        cbTipoAhorro.DisplayMember = "Descripcion"
        cbTipoAhorro.ValueMember = "codTipoAhorro"
        cbTipoAhorro.DataSource = dts.Tables(0)
    End Sub
    Protected Sub llenarCatalogoCtaContable()
        Dim dts As New DataSet
        dts = conta.ObtenerCatContab("IDCUENTA,DESCRIPCION", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
        cbCtaContable.DisplayMember = "DESCRIPCION"
        cbCtaContable.ValueMember = "IDCUENTA"
        cbCtaContable.DataSource = dts.Tables(0)
    End Sub
#End Region
    Private Sub frmMsAhParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            llenarCatalogoCtaContable()
            llenarTiposahorro()

            If Me.pAccion = "Modificar" Then

                Dim dts As New DataSet
                Dim Filas As DataRowCollection
                dts = ahorro.ConsultarTipoAhorro("plazo,idCuenta", "CodTipoAhorro='" & pCodTipoAhorro & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                If dts.Tables(0).Rows.Count > 0 Then
                    Filas = dts.Tables(0).Rows()
                    cbTipoAhorro.SelectedValue = pCodTipoAhorro
                    c1nPlazo.Value = IIf(IsDBNull(Filas.Item(0)("Plazo")), 0, Filas.Item(0)("Plazo"))
                    cbCtaContable.SelectedValue = IIf(IsDBNull(Filas.Item(0)("IdCuenta")), "", Filas.Item(0)("IdCuenta"))
                End If
                dts.Clear()
                dts = ahorro.ConsultarParametros("*", "CodTipoAhorro='" & pCodTipoAhorro & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                Filas = dts.Tables(0).Rows()
                '=============================
                Dim transferencias As Boolean
                '=============================
                If Filas.Count > 0 Then
                    Me.c1nSaldoMinimo.Value = IIf(IsDBNull(Filas.Item(0)("MontoSaldoMinimo")), 0, Filas.Item(0)("MontoSaldoMinimo"))
                    Me.c1nMontoCuotaMinima.Value = IIf(IsDBNull(Filas.Item(0)("MontoCuotaMinima")), 0, Filas.Item(0)("MontoCuotaMinima"))
                    Me.c1nAperturaMinima.Value = IIf(IsDBNull(Filas.Item(0)("MontoAperturaMinima")), 0, Filas.Item(0)("MontoAperturaMinima"))
                    Me.c1nAperturaMaxima.Value = IIf(IsDBNull(Filas.Item(0)("MontoAperturaMaxima")), 0, Filas.Item(0)("MontoAperturaMaxima"))
                    Me.nudPlazoMinimo.Value = IIf(IsDBNull(Filas.Item(0)("PlazoMinimo")), 0, Filas.Item(0)("PlazoMinimo"))
                    Me.nudPlazoMaximo.Value = IIf(IsDBNull(Filas.Item(0)("PlazoMaximo")), 0, Filas.Item(0)("PlazoMaximo"))
                    Me.nuDiasGracia.Value = IIf(IsDBNull(Filas.Item(0)("DiasGracia")), 0, Filas.Item(0)("DiasGracia"))
                    c1nTasaInteres.Value = IIf(IsDBNull(Filas.Item(0)("TasaInteres")), 0, Filas.Item(0)("TasaInteres"))
                    c1nPorcPig.Value = IIf(IsDBNull(Filas.Item(0)("PorcentajePignoracion")), 0, Filas.Item(0)("PorcentajePignoracion"))
                    dtpDesde.Value = IIf(IsDBNull(Filas.Item(0)("ValidoDesdeMin")), Now, Filas.Item(0)("ValidoDesdeMin"))
                    dtpHasta.Value = IIf(IsDBNull(Filas.Item(0)("ValidoHastaMin")), Now, Filas.Item(0)("ValidoHastaMin"))
                Else

                End If

            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim pCampos, pValores As String
        Try

            If Me.btnGuardar.Text = "Guardar" Then

                pCampos = "CodTipoAhorro,MontoSaldoMinimo," &
                "MontoCuotaMinima, MontoAperturaMaxima, " &
                "MontoAperturaMinima,PlazoMinimo, " &
                "PlazoMaximo,AplicaInactividad, " &
                "TasaInteres,DiasGracia," &
                "PorcentajePignoracion,ValidoDesdeMin," &
                "ValidoHastaMin,ValidoDesdeMax," &
                "ValidoHastaMax,Promocion,transferencia"
                pValores = "'" & cbTipoAhorro.SelectedValue & "','" & Val(Me.c1nSaldoMinimo.Value) &
                    "','" & Val(Me.c1nMontoCuotaMinima.Value) & "','" & Val(Me.c1nAperturaMaxima.Value) &
                    "','" & Val(Me.c1nAperturaMinima.Value) & "','" & Val(Me.nudPlazoMinimo.Value) &
                    "','" & Val(Me.nudPlazoMaximo.Value) & "','" & IIf(Me.chbInactividad.Checked = True, "1", "0") &
                    "','" & Val(Me.c1nTasaInteres.Value) & "'," & Val(Me.nuDiasGracia.Value) &
                    "," & Me.c1nPorcPig.Value & ",'" & Me.dtpDesde.Value.ToShortDateString &
                    "','" & Me.dtpHasta.Value.ToShortDateString &
                    "','" & Me.dtpDesde.Value.ToShortDateString & "','" & Me.dtpHasta.Value.ToShortDateString &
                    "','" & IIf(Me.chkProm.Checked = True, "1", "0") & "','" & IIf(Me.cbTransferencia.Checked = True, 1, 0) & "'"
                If ahorro.InsertaParametros(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Me.btnGuardar.Text = "&Modificar"
                End If

            ElseIf Me.btnGuardar.Text = "&Modificar" Then

                pValores = "MontoSaldoMinimo='" & Val(Me.c1nSaldoMinimo.Value) & "',MontoCuotaMinima='" & Val(Me.c1nMontoCuotaMinima.Value) &
                    "',MontoAperturaMinima='" & Val(Me.c1nAperturaMinima.Value) & "',MontoAperturaMaxima='" & Val(Me.c1nAperturaMaxima.Value) &
                    "',PlazoMinimo='" & Val(Me.nudPlazoMinimo.Value) & "',PlazoMaximo='" & Val(Me.nudPlazoMaximo.Value) & "',AplicaInactividad='" &
                    IIf(Me.chbInactividad.Checked = True, "1", "0") &
                    "',TasaInteres='" & Val(Me.c1nTasaInteres.Value) & "',DiasGracia=" &
                    Val(Me.nuDiasGracia.Value) & ",PorcentajePignoracion=" & Me.c1nPorcPig.Value & ",ValidoDesdeMin='" & dtpDesde.Value.ToShortDateString &
                    "',ValidoHastaMin='" & dtpHasta.Value.ToShortDateString & "',ValidoDesdeMax='" & dtpDesde.Value.ToShortDateString & "',ValidoHastaMax='" &
                    Me.dtpHasta.Value.ToShortDateString & "',Promocion='" & IIf(Me.chkProm.Checked = True, "1", "0") & "',Transferencia ='" & IIf(Me.cbTransferencia.Checked = True, 1, 0) & "'"
                If ahorro.ModificaParametros(Trim(cbTipoAhorro.SelectedValue), pValores, sUsuario, sPassword, sSucursal) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If

            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsAhParametros_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
