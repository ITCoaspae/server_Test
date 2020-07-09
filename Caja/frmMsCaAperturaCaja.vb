Public Class frmMsCaAperturaCaja
    Inherits MetroFramework.Forms.MetroForm '  Inherits System.Windows.Forms.Form : 
    Public rsc As System.Resources.ResourceManager

    Private vCodCajero As String, vCajero As String, vUsuario As String
    Dim caja As New wrCaja.wsLibCaja
    Dim Bancos As New wrBancos.wsLibBancos
    Dim dtsMovCaja As New DataSet
    Friend WithEvents C1nMonedaUno As C1.Win.C1Input.C1NumericEdit
    Dim vOrigen As Integer
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbCaja As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtpFechaApertura As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblFechaApertura As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNoCaja As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTipoCaja As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbTipoCaja As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblTipoMov As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbTipoMov As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblMonto As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label11 As Label
    Dim vCodSolicitud As Integer


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
    Friend WithEvents C1NEMontoApertura As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents c1nTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCien As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCincuenta As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nVeinte As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nFraccion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nDiez As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCinco As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nUno As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblEncabezado2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.C1NEMontoApertura = New C1.Win.C1Input.C1NumericEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.C1nMonedaUno = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.c1nCien = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCincuenta = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nVeinte = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nFraccion = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nDiez = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCinco = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nUno = New C1.Win.C1Input.C1NumericEdit()
        Me.lblEncabezado2 = New System.Windows.Forms.Label()
        Me.c1nTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.cbCaja = New MetroFramework.Controls.MetroComboBox()
        Me.dtpFechaApertura = New MetroFramework.Controls.MetroDateTime()
        Me.lblFechaApertura = New MetroFramework.Controls.MetroLabel()
        Me.lblNoCaja = New MetroFramework.Controls.MetroLabel()
        Me.lblTipoCaja = New MetroFramework.Controls.MetroLabel()
        Me.cbTipoCaja = New MetroFramework.Controls.MetroComboBox()
        Me.lblTipoMov = New MetroFramework.Controls.MetroLabel()
        Me.cbTipoMov = New MetroFramework.Controls.MetroComboBox()
        Me.lblMonto = New MetroFramework.Controls.MetroLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.C1NEMontoApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1nMonedaUno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCincuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nVeinte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nFraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nDiez, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCinco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nUno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1NEMontoApertura
        '
        Me.C1NEMontoApertura.BackColor = System.Drawing.Color.White
        Me.C1NEMontoApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMontoApertura.CustomFormat = "###,###,##0.00"
        Me.C1NEMontoApertura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMontoApertura.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMontoApertura.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEMontoApertura.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMontoApertura.Location = New System.Drawing.Point(137, 207)
        Me.C1NEMontoApertura.Name = "C1NEMontoApertura"
        Me.C1NEMontoApertura.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMontoApertura.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMontoApertura.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMontoApertura.Size = New System.Drawing.Size(457, 23)
        Me.C1NEMontoApertura.TabIndex = 9
        Me.C1NEMontoApertura.Tag = Nothing
        Me.C1NEMontoApertura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEMontoApertura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.MetroLabel14)
        Me.GroupBox2.Controls.Add(Me.MetroLabel13)
        Me.GroupBox2.Controls.Add(Me.MetroLabel12)
        Me.GroupBox2.Controls.Add(Me.MetroLabel11)
        Me.GroupBox2.Controls.Add(Me.C1nMonedaUno)
        Me.GroupBox2.Controls.Add(Me.MetroLabel10)
        Me.GroupBox2.Controls.Add(Me.MetroLabel9)
        Me.GroupBox2.Controls.Add(Me.MetroLabel8)
        Me.GroupBox2.Controls.Add(Me.MetroLabel6)
        Me.GroupBox2.Controls.Add(Me.c1nCien)
        Me.GroupBox2.Controls.Add(Me.c1nCincuenta)
        Me.GroupBox2.Controls.Add(Me.c1nVeinte)
        Me.GroupBox2.Controls.Add(Me.c1nFraccion)
        Me.GroupBox2.Controls.Add(Me.c1nDiez)
        Me.GroupBox2.Controls.Add(Me.c1nCinco)
        Me.GroupBox2.Controls.Add(Me.c1nUno)
        Me.GroupBox2.Controls.Add(Me.lblEncabezado2)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 229)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(281, 84)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(64, 20)
        Me.MetroLabel14.TabIndex = 15
        Me.MetroLabel14.Text = "Fracción:"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(281, 55)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(72, 20)
        Me.MetroLabel13.TabIndex = 13
        Me.MetroLabel13.Text = "Moneda 1:"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(10, 200)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(74, 20)
        Me.MetroLabel12.TabIndex = 11
        Me.MetroLabel12.Text = "Billete 100:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(10, 171)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(69, 20)
        Me.MetroLabel11.TabIndex = 9
        Me.MetroLabel11.Text = "Billete 50:"
        '
        'C1nMonedaUno
        '
        Me.C1nMonedaUno.BackColor = System.Drawing.Color.White
        Me.C1nMonedaUno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1nMonedaUno.CustomFormat = "###,###,##0.00"
        Me.C1nMonedaUno.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1nMonedaUno.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1nMonedaUno.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1nMonedaUno.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1nMonedaUno.Location = New System.Drawing.Point(384, 55)
        Me.C1nMonedaUno.Name = "C1nMonedaUno"
        Me.C1nMonedaUno.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1nMonedaUno.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1nMonedaUno.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1nMonedaUno.Size = New System.Drawing.Size(186, 23)
        Me.C1nMonedaUno.TabIndex = 14
        Me.C1nMonedaUno.Tag = Nothing
        Me.C1nMonedaUno.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1nMonedaUno.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(10, 142)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(69, 20)
        Me.MetroLabel10.TabIndex = 7
        Me.MetroLabel10.Text = "Billete 20:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(10, 113)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(66, 20)
        Me.MetroLabel9.TabIndex = 5
        Me.MetroLabel9.Text = "Billete 10:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(10, 84)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(61, 20)
        Me.MetroLabel8.TabIndex = 3
        Me.MetroLabel8.Text = "Billete 5:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(10, 55)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(58, 20)
        Me.MetroLabel6.TabIndex = 1
        Me.MetroLabel6.Text = "Billete 1:"
        '
        'c1nCien
        '
        Me.c1nCien.BackColor = System.Drawing.Color.White
        Me.c1nCien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCien.CustomFormat = "###,###,##0.00"
        Me.c1nCien.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nCien.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCien.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCien.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCien.Location = New System.Drawing.Point(89, 200)
        Me.c1nCien.Name = "c1nCien"
        Me.c1nCien.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCien.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCien.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCien.Size = New System.Drawing.Size(186, 23)
        Me.c1nCien.TabIndex = 12
        Me.c1nCien.Tag = Nothing
        Me.c1nCien.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCien.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nCincuenta
        '
        Me.c1nCincuenta.BackColor = System.Drawing.Color.White
        Me.c1nCincuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCincuenta.CustomFormat = "###,###,##0.00"
        Me.c1nCincuenta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nCincuenta.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCincuenta.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCincuenta.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCincuenta.Location = New System.Drawing.Point(89, 171)
        Me.c1nCincuenta.Name = "c1nCincuenta"
        Me.c1nCincuenta.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCincuenta.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCincuenta.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCincuenta.Size = New System.Drawing.Size(186, 23)
        Me.c1nCincuenta.TabIndex = 10
        Me.c1nCincuenta.Tag = Nothing
        Me.c1nCincuenta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCincuenta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nVeinte
        '
        Me.c1nVeinte.BackColor = System.Drawing.Color.White
        Me.c1nVeinte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nVeinte.CustomFormat = "###,###,##0.00"
        Me.c1nVeinte.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nVeinte.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nVeinte.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nVeinte.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nVeinte.Location = New System.Drawing.Point(89, 142)
        Me.c1nVeinte.Name = "c1nVeinte"
        Me.c1nVeinte.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nVeinte.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nVeinte.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nVeinte.Size = New System.Drawing.Size(186, 23)
        Me.c1nVeinte.TabIndex = 8
        Me.c1nVeinte.Tag = Nothing
        Me.c1nVeinte.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nVeinte.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nFraccion
        '
        Me.c1nFraccion.BackColor = System.Drawing.Color.White
        Me.c1nFraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nFraccion.CustomFormat = "###,###,##0.00"
        Me.c1nFraccion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nFraccion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nFraccion.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nFraccion.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nFraccion.Location = New System.Drawing.Point(384, 84)
        Me.c1nFraccion.Name = "c1nFraccion"
        Me.c1nFraccion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nFraccion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nFraccion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nFraccion.Size = New System.Drawing.Size(186, 23)
        Me.c1nFraccion.TabIndex = 16
        Me.c1nFraccion.Tag = Nothing
        Me.c1nFraccion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nFraccion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nDiez
        '
        Me.c1nDiez.BackColor = System.Drawing.Color.White
        Me.c1nDiez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nDiez.CustomFormat = "###,###,##0.00"
        Me.c1nDiez.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nDiez.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nDiez.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nDiez.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nDiez.Location = New System.Drawing.Point(89, 113)
        Me.c1nDiez.Name = "c1nDiez"
        Me.c1nDiez.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nDiez.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nDiez.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nDiez.Size = New System.Drawing.Size(186, 23)
        Me.c1nDiez.TabIndex = 6
        Me.c1nDiez.Tag = Nothing
        Me.c1nDiez.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nDiez.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nCinco
        '
        Me.c1nCinco.BackColor = System.Drawing.Color.White
        Me.c1nCinco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCinco.CustomFormat = "###,###,##0.00"
        Me.c1nCinco.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nCinco.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCinco.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCinco.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCinco.Location = New System.Drawing.Point(89, 84)
        Me.c1nCinco.Name = "c1nCinco"
        Me.c1nCinco.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCinco.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCinco.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCinco.Size = New System.Drawing.Size(186, 23)
        Me.c1nCinco.TabIndex = 4
        Me.c1nCinco.Tag = Nothing
        Me.c1nCinco.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCinco.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nUno
        '
        Me.c1nUno.BackColor = System.Drawing.Color.White
        Me.c1nUno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nUno.CustomFormat = "###,###,##0.00"
        Me.c1nUno.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nUno.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nUno.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nUno.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nUno.Location = New System.Drawing.Point(89, 55)
        Me.c1nUno.Name = "c1nUno"
        Me.c1nUno.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nUno.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nUno.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nUno.Size = New System.Drawing.Size(186, 23)
        Me.c1nUno.TabIndex = 2
        Me.c1nUno.Tag = Nothing
        Me.c1nUno.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nUno.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblEncabezado2
        '
        Me.lblEncabezado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado2.ForeColor = System.Drawing.Color.Black
        Me.lblEncabezado2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEncabezado2.Location = New System.Drawing.Point(6, 18)
        Me.lblEncabezado2.Name = "lblEncabezado2"
        Me.lblEncabezado2.Size = New System.Drawing.Size(269, 27)
        Me.lblEncabezado2.TabIndex = 0
        Me.lblEncabezado2.Text = "Detalle Apertura Caja"
        '
        'c1nTotal
        '
        Me.c1nTotal.BackColor = System.Drawing.Color.White
        Me.c1nTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotal.CustomFormat = "###,###,##0.00"
        Me.c1nTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTotal.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotal.Location = New System.Drawing.Point(230, 478)
        Me.c1nTotal.Name = "c1nTotal"
        Me.c1nTotal.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotal.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotal.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotal.ReadOnly = True
        Me.c1nTotal.Size = New System.Drawing.Size(364, 23)
        Me.c1nTotal.TabIndex = 13
        Me.c1nTotal.Tag = Nothing
        Me.c1nTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(502, 514)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 33)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 0
        Me.btnGuardar1.Text = "Aceptar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'cbCaja
        '
        Me.cbCaja.FormattingEnabled = True
        Me.cbCaja.ItemHeight = 24
        Me.cbCaja.Location = New System.Drawing.Point(137, 63)
        Me.cbCaja.Name = "cbCaja"
        Me.cbCaja.Size = New System.Drawing.Size(457, 30)
        Me.cbCaja.TabIndex = 1
        Me.cbCaja.UseSelectable = True
        '
        'dtpFechaApertura
        '
        Me.dtpFechaApertura.Location = New System.Drawing.Point(137, 99)
        Me.dtpFechaApertura.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaApertura.Name = "dtpFechaApertura"
        Me.dtpFechaApertura.Size = New System.Drawing.Size(457, 30)
        Me.dtpFechaApertura.TabIndex = 3
        '
        'lblFechaApertura
        '
        Me.lblFechaApertura.AutoSize = True
        Me.lblFechaApertura.Location = New System.Drawing.Point(18, 99)
        Me.lblFechaApertura.Name = "lblFechaApertura"
        Me.lblFechaApertura.Size = New System.Drawing.Size(108, 20)
        Me.lblFechaApertura.TabIndex = 2
        Me.lblFechaApertura.Text = "Fecha Apertura:"
        '
        'lblNoCaja
        '
        Me.lblNoCaja.AutoSize = True
        Me.lblNoCaja.Location = New System.Drawing.Point(18, 63)
        Me.lblNoCaja.Name = "lblNoCaja"
        Me.lblNoCaja.Size = New System.Drawing.Size(84, 20)
        Me.lblNoCaja.TabIndex = 0
        Me.lblNoCaja.Text = "No. de Caja:"
        '
        'lblTipoCaja
        '
        Me.lblTipoCaja.AutoSize = True
        Me.lblTipoCaja.Location = New System.Drawing.Point(18, 135)
        Me.lblTipoCaja.Name = "lblTipoCaja"
        Me.lblTipoCaja.Size = New System.Drawing.Size(89, 20)
        Me.lblTipoCaja.TabIndex = 4
        Me.lblTipoCaja.Text = "Tipo de Caja:"
        '
        'cbTipoCaja
        '
        Me.cbTipoCaja.Enabled = False
        Me.cbTipoCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoCaja.FormattingEnabled = True
        Me.cbTipoCaja.ItemHeight = 24
        Me.cbTipoCaja.Items.AddRange(New Object() {"Fija"})
        Me.cbTipoCaja.Location = New System.Drawing.Point(137, 135)
        Me.cbTipoCaja.Name = "cbTipoCaja"
        Me.cbTipoCaja.Size = New System.Drawing.Size(457, 30)
        Me.cbTipoCaja.TabIndex = 5
        Me.cbTipoCaja.UseSelectable = True
        '
        'lblTipoMov
        '
        Me.lblTipoMov.AutoSize = True
        Me.lblTipoMov.Location = New System.Drawing.Point(18, 155)
        Me.lblTipoMov.Name = "lblTipoMov"
        Me.lblTipoMov.Size = New System.Drawing.Size(85, 40)
        Me.lblTipoMov.TabIndex = 6
        Me.lblTipoMov.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Movimiento:"
        '
        'cbTipoMov
        '
        Me.cbTipoMov.FormattingEnabled = True
        Me.cbTipoMov.ItemHeight = 24
        Me.cbTipoMov.Location = New System.Drawing.Point(137, 171)
        Me.cbTipoMov.Name = "cbTipoMov"
        Me.cbTipoMov.Size = New System.Drawing.Size(457, 30)
        Me.cbTipoMov.TabIndex = 7
        Me.cbTipoMov.UseSelectable = True
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(18, 195)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(52, 20)
        Me.lblMonto.TabIndex = 8
        Me.lblMonto.Text = "Monto:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(14, 478)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(210, 33)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Total Detalle de Apertura:"
        '
        'frmMsCaAperturaCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(615, 603)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.C1NEMontoApertura)
        Me.Controls.Add(Me.c1nTotal)
        Me.Controls.Add(Me.cbTipoMov)
        Me.Controls.Add(Me.lblTipoMov)
        Me.Controls.Add(Me.cbTipoCaja)
        Me.Controls.Add(Me.lblTipoCaja)
        Me.Controls.Add(Me.lblNoCaja)
        Me.Controls.Add(Me.lblFechaApertura)
        Me.Controls.Add(Me.dtpFechaApertura)
        Me.Controls.Add(Me.cbCaja)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCaAperturaCaja"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Apertura de caja"
        CType(Me.C1NEMontoApertura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1nMonedaUno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCincuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nVeinte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nFraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nDiez, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCinco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nUno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "Propiedades"
    Public Property Usuario() As String
        Get
            Return vUsuario
        End Get
        Set(ByVal Value As String)
            vUsuario = Value
        End Set
    End Property
    Public Property CodCajero() As String
        Get
            Return vCodCajero
        End Get
        Set(ByVal Value As String)
            vCodCajero = Value
        End Set
    End Property
    Public Property Cajero() As String
        Get
            Return vCajero
        End Get
        Set(ByVal Value As String)
            vCajero = Value
        End Set
    End Property
    Public Property Origen() As Integer '1 FrmaCaLoginCajero,2 Solicitudes Boveda
        Get
            Return vOrigen
        End Get
        Set(ByVal value As Integer)
            vOrigen = value
        End Set
    End Property
    Public Property codSolicitud() As Integer '1 FrmaCaLoginCajero,2 Solicitudes Boveda
        Get
            Return vCodSolicitud
        End Get
        Set(ByVal value As Integer)
            vCodSolicitud = value
        End Set
    End Property
#End Region
#Region "Eventos"
    Private Sub frmMsCaAperturaCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim oApp As New wrAdmin.wsLibAdmin
        'Me.dtpFechaApertura.Value = oApp.Fecha
        Me.cbTipoCaja.SelectedIndex = 0
        Me.cbTipoCaja.Enabled = False
        consultarCajasxSucursal(sSucursal)
        If Origen = 2 Then
            Me.cbTipoMov.DisplayMember = "descripcion"
            Me.cbTipoMov.ValueMember = "idTipoMovCaja"
            llenarCbTipoMovCaja(1, 0, 0)

        End If
    End Sub


    Protected Sub generarReporte(ByVal correlativo As Integer)
        Dim frmVisorRpt As New frmVisorRS
        OpcionRS = 38

        With frmVisorRpt
            .noCaja = pNocaja
            .fecha = Format(Me.dtpFechaApertura.Value, "short date")
            .CorrelativoMovCaja = correlativo
            .ShowDialog()
        End With
        '================================================================

    End Sub
    Private Sub c1nCien_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCien.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub

    Private Sub c1nCinco_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCinco.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub

    Private Sub c1nCincuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCincuenta.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub

    Private Sub c1nDiez_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nDiez.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub

    Private Sub c1nFraccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nFraccion.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub

    Private Sub c1nTotal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nTotal.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub

    Private Sub c1nUno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nUno.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub

    Private Sub c1nVeinte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nVeinte.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Dim pCampos As String, pValores As String, pCamposMov As String, pValoresMov As String, ds As New DataSet, Filas As Data.DataRowCollection
        Dim oItem As New wrCaja.wsLibCaja
        Try

            If vOrigen = 1 Then
                If valicarDenominaciones() > 0 Then
                    If IsNumeric(Me.cbCaja.SelectedValue) = False Then Exit Sub
                    If Me.C1NEMontoApertura.Value <> Me.c1nTotal.Value Then
                        MessageBox.Show("El Monto no coincide con el total del detalle, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    ds = oItem.ConsultarCAParametros("MontoMinimo_Apertura,MontoMaximo_Apertura", "", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()

                    If Filas.Count > 0 Then
                        If CDbl(Me.C1NEMontoApertura.Value) < CDbl(Filas.Item(0)("MontoMinimo_Apertura")) Then
                            MessageBox.Show("El monto de apertura no puede ser menor al monto mínimo establecido.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                        If CDbl(Me.C1NEMontoApertura.Value) > CDbl(Filas.Item(0)("MontoMaximo_Apertura")) Then
                            MessageBox.Show("El monto de apertura no puede ser mayor al monto máximo establecido.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If
                    pNocaja = Me.cbCaja.SelectedValue
                    ds = oItem.ConsultarAperturaCaja("CodCajero,correlativo", "FechaApertura='" & Me.dtpFechaApertura.Value.ToShortDateString & "' and NoCaja='" & Trim(Me.cbCaja.SelectedValue) & "' and CajaCerrada<>'1'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        If Filas.Item(0)("CodCajero") = vCodCajero Then
                        Else
                            MessageBox.Show("Acceso denegado.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                        'Banco s.ModificarBcSolicitudes_Boveda(vCodSolicitud, 0, 0, Now, 0, "", False, "", "", "", sUsuario, sPassword, sSucursal, 2, Filas.Item(0)("Correlativo"), "", Now, "", 0)
                        Dim frm As New frmCAFactura
                        frm.StartPosition = FormStartPosition.CenterScreen
                        frm.NoCaja = Me.cbCaja.SelectedValue
                        frm.CodCajero = vCodCajero
                        frm.Usuario = Me.vUsuario
                        frm.Text = frm.Text & ", Cajero: " & Me.CodCajero & " - " & Me.Cajero
                        frm.Show()
                        Me.Hide()
                    Else
                        'pCampos = "NoCaja,CodCajero,FechaApertura,HoraApertura,MontoApertura,TipoCaja,CajaCerrada"
                        'pValores = "'" & Trim(Me.txtNoCaja.Text) & "','" & vCodCajero & "','" & Date.Now.ToShortDateString & "','" & Mid(Date.Now.ToShortTimeString, 1, 5) & "'," & Me.C1NEMontoApertura.Value & ",'" & Me.cbTipoCaja.SelectedIndex & "','0'"
                        'pCamposMov = "NoCaja,CodCajero,Fecha,Monto,TipoMov,CantidadUno,CantidadCinco,CantidadDiez,CantidadVeinte,CantidadCincuenta,CantidadCien,CantidadFraccion"
                        'pValoresMov = "" & Trim(Me.txtNoCaja.Text) & ",'" & vCodCajero & "','" & Me.dtpFechaApertura.Value.ToShortDateString & "'," & Me.c1nTotal.Value & ",'A'," & Me.c1nUno.Value & "," & Me.c1nCinco.Value & "," & Me.c1nDiez.Value & "," & Me.c1nVeinte.Value & "," & Me.c1nCincuenta.Value & "," & Me.c1nCien.Value & "," & Me.c1nFraccion.Value & ""
                        'If oItem.InsertarAperturaCaja(pCampos, pValores, pCamposMov, pValoresMov, sUsuario, sPassword, sSucursal) = True Then
                        Dim Correlativo As Integer
                        Correlativo = caja.AperturaCaja(cbCaja.SelectedValue, vCodCajero, Format(dtpFechaApertura.Value, "Short Date"), vCodSolicitud,
                                             Now.Hour.ToString.PadLeft(2, "0") + ":" + Now.Minute.ToString.PadLeft(2, "0"),
                                             Me.C1NEMontoApertura.Value, "", Me.cbTipoCaja.SelectedIndex, "", "A",
                                             Me.c1nUno.Value, Me.c1nCinco.Value, Me.c1nDiez.Value, Me.c1nVeinte.Value,
                                             Me.c1nCincuenta.Value, Me.c1nCien.Value, Me.c1nFraccion.Value,
                                             0, 0, 0, 0, 0, 0, 0, 1, Me.C1nMonedaUno.Value)
                        'Bancos.ModificarBcSolicitudes_Boveda(vCodSolicitud, 0, 0, Now, 0, "", False, "", "", "", sUsuario, sPassword, sSucursal, 2, Correlativo, "", Now, "", 0)
                        If Correlativo <> 0 Then

                            '================================================================
                            '26/09/2013
                            'mostramos reporte con detalle de solicitud de efectivo.
                            '================================================================
                            ' Proceso que Actuliza el Correlativo de la Solicitud a Boveda  23/06/2020  PROG01
                            Dim resultado As Integer
                            resultado = Bancos.ActivarSolicitudBoveda(Space(1), True, "ActivarSol", Format(Now, "short date"), Now.Hour.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.PadLeft(2, "0"), vCodSolicitud)
                            '================================================================

                            Dim frmVisorRpt As New frmVisorRS
                            OpcionRS = 38

                            With frmVisorRpt
                                .noCaja = pNocaja
                                .fecha = Format(Me.dtpFechaApertura.Value, "short date")
                                .CorrelativoMovCaja = Correlativo
                                .Show()
                            End With
                            '================================================================
                            'LA SOLICITUD SE IMPRIMIRA DESPUES DE SER APROBADA
                            'CAMBIO APLICADO 03/06/2020 PROG01
                            'Dim frm As New frmCAFactura
                            'frm.StartPosition = FormStartPosition.CenterScreen
                            'frm.NoCaja = cbCaja.SelectedValue
                            'frm.CodCajero = vCodCajero
                            'frm.Usuario = Me.vUsuario
                            'frm.Text = frm.Text & ", Cajero: " & Me.CodCajero & " - " & Me.Cajero
                            'frm.Show()
                            'Me.Hide()
                        Else
                            MessageBox.Show("Los datos no fueron ingresados, verifíque.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    End If
                End If

            ElseIf Origen = 2 Then
                    If c1nTotal.Value = C1NEMontoApertura.Value Then
                        Dim CorrMovCaja
                    CorrMovCaja = caja.InsertarCaMovimientosCaja(pNocaja, pCodCajero, Format(Me.dtpFechaApertura.Value, "short date"), vCodSolicitud,
                                                                     Me.C1NEMontoApertura.Value, "C",
                                                                      Me.c1nUno.Value, Me.c1nCinco.Value, Me.c1nDiez.Value, Me.c1nVeinte.Value,
                                                                      Me.c1nCincuenta.Value, Me.c1nCien.Value, Me.c1nFraccion.Value, 0,
                                                                      0, 0, 0, 0, 0, 0, Me.cbTipoMov.SelectedValue, Me.C1nMonedaUno.Value)
                    If CorrMovCaja <> 0 Then
                            Dim resultadoSolicitud As Integer
                            resultadoSolicitud = Bancos.InsertarBcSolicitudes_Boveda(pCodCajero, Format(Me.dtpFechaApertura.Value, "short date"),
                                                                                     Me.C1NEMontoApertura.Value, Me.cbTipoMov.SelectedText.Trim,
                                                                                     False, Now.Hour.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.Trim.PadLeft(2, "0"),
                                                                                     sSucursal, sUsuario, sUsuario, sPassword, sSucursal, Me.cbTipoMov.SelectedValue, CorrMovCaja)
                            If resultadoSolicitud <> 0 Then
                            'LA SOLICITUD SE IMPRIMIRA DESPUES DE SER APROBADA
                            ' CAMBIO APLICADO 03/06/2020 PROG01
                            ' generarReporte(CorrMovCaja)

                            Me.Dispose()
                            Else
                                MessageBox.Show("Los datos no fueron ingresados, verifíque.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If

                    End If
                End If



        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub C1nMonedaUno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1nMonedaUno.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
#End Region
#Region "Metodos"
    Private Sub consultarCajasxSucursal(codSucursal As String)
        Dim dts As New DataSet
        dts = caja.ConsultarCajas("noCaja", "codSucursal = '" & sSucursal & "'", "", sUsuario, sPassword, sSucursal)
        If dts.Tables(0).Rows.Count > 0 Then
            cbCaja.DataSource = dts.Tables(0)
            Me.cbCaja.DisplayMember = "noCaja"
            Me.cbCaja.ValueMember = "noCaja"
        End If
    End Sub
    Public Sub llenarCbTipoMovCaja(ByVal opcion As Integer, ByVal idTipoMov As Integer, ByVal codTransaccion As Integer)

        dtsMovCaja = caja.consultarCaTipoMovCaja(opcion, idTipoMov, codTransaccion, sUsuario, sPassword, sSucursal)
        If dtsMovCaja.Tables.Count > 0 Then
            If dtsMovCaja.Tables(0).Rows.Count > 0 Then
                Me.cbTipoMov.DataSource = dtsMovCaja.Tables(0)
            End If
        End If
    End Sub
    Private Function valicarDenominaciones() As Integer
        Dim valido As Integer = 0
        Dim dtsBoveda As New DataSet
        dtsBoveda = Bancos.ConsultarBcBoveda(0, 2, sSucursal)
        If dtsBoveda.Tables(0).Rows.Count > 0 Then
            valido = Bancos.validarDenominacionesBoveda(dtsBoveda.Tables(0).Rows(0).Item("Id_Boveda").ToString,
                                                        cbTipoMov.SelectedValue,
                                                     c1nUno.Value, c1nCinco.Value,
                                                     c1nDiez.Value, c1nVeinte.Value,
                                                     c1nCincuenta.Value, c1nCien.Value,
                                                     C1nMonedaUno.Value, c1nFraccion.Value)
            If valido = 0 Then
                Me.btnGuardar1.Enabled = False
            Else
                Me.btnGuardar1.Enabled = True
            End If
        End If

        Return valido
    End Function
#End Region


End Class