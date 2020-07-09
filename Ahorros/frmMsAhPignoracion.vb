Public Class frmMsAhPignoracion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents cbPrestamos As MetroFramework.Controls.MetroComboBox
    Dim ahorro As New wrAhorro.wsLibAhorro
    Dim prestamo As New wrPrestamo.wsLibPrest
    Dim asociado As New wrAsociados.wsLibAsoc
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSaldoDisponible As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPctPermitidoPig As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Pignorado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtdispPignoracion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDispoPigno As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMontoPignorado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Dim codTipoAhorro As String
    Friend WithEvents TxtNombreAhorro As TextBox
    Dim TextTipoAhorro As String
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
    Friend WithEvents c1nMontoPignorado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ttip As System.Windows.Forms.ToolTip
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpVencimientoPrestamo As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCuentas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.c1nMontoPignorado = New C1.Win.C1Input.C1NumericEdit()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dtpVencimientoPrestamo = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.cbCuentas = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.cbPrestamos = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtSaldoDisponible = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.txtPctPermitidoPig = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.Pignorado = New C1.Win.C1Input.C1NumericEdit()
        Me.txtdispPignoracion = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.txtDispoPigno = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txtMontoPignorado = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.TxtNombreAhorro = New System.Windows.Forms.TextBox()
        CType(Me.c1nMontoPignorado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPctPermitidoPig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pignorado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdispPignoracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDispoPigno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPignorado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1nMontoPignorado
        '
        Me.c1nMontoPignorado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoPignorado.CustomFormat = "###,###,##0.00"
        Me.c1nMontoPignorado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoPignorado.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMontoPignorado.Location = New System.Drawing.Point(379, 341)
        Me.c1nMontoPignorado.Name = "c1nMontoPignorado"
        Me.c1nMontoPignorado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoPignorado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoPignorado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoPignorado.Size = New System.Drawing.Size(172, 19)
        Me.c1nMontoPignorado.TabIndex = 2
        Me.c1nMontoPignorado.Tag = Nothing
        Me.c1nMontoPignorado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoPignorado.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(109, 64)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(172, 18)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.Color.Black
        Me.txtNoSocio.Location = New System.Drawing.Point(379, 64)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(172, 20)
        Me.txtNoSocio.TabIndex = 162
        Me.txtNoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.Color.Black
        Me.txtAsociado.Location = New System.Drawing.Point(109, 89)
        Me.txtAsociado.Multiline = True
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(442, 25)
        Me.txtAsociado.TabIndex = 1
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(396, 395)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 172
        Me.MetroButton3.Text = "Pignorar"
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(476, 395)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 173
        Me.MetroButton1.Text = "Despignorar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        Me.MetroButton1.Visible = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 67)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel1.TabIndex = 175
        Me.MetroLabel1.Text = "DUI:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(286, 64)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel2.TabIndex = 176
        Me.MetroLabel2.Text = "No. Asociado:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(19, 89)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel3.TabIndex = 177
        Me.MetroLabel3.Text = "Asociado:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(19, 116)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel4.TabIndex = 178
        Me.MetroLabel4.Text = "Cod. Préstamo:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(19, 144)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(84, 38)
        Me.MetroLabel6.TabIndex = 180
        Me.MetroLabel6.Text = "Vencimiento " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Préstamo:"
        '
        'dtpVencimientoPrestamo
        '
        Me.dtpVencimientoPrestamo.Enabled = False
        Me.dtpVencimientoPrestamo.Location = New System.Drawing.Point(109, 150)
        Me.dtpVencimientoPrestamo.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpVencimientoPrestamo.Name = "dtpVencimientoPrestamo"
        Me.dtpVencimientoPrestamo.Size = New System.Drawing.Size(442, 29)
        Me.dtpVencimientoPrestamo.TabIndex = 181
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(287, 343)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(82, 38)
        Me.MetroLabel7.TabIndex = 182
        Me.MetroLabel7.Text = "Monto " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pignoración:"
        '
        'cbCuentas
        '
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.ItemHeight = 23
        Me.cbCuentas.Location = New System.Drawing.Point(109, 185)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(442, 29)
        Me.cbCuentas.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCuentas.TabIndex = 183
        Me.cbCuentas.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cbCuentas.UseCustomBackColor = True
        Me.cbCuentas.UseCustomForeColor = True
        Me.cbCuentas.UseSelectable = True
        Me.cbCuentas.UseStyleColors = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(19, 185)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(65, 38)
        Me.MetroLabel8.TabIndex = 184
        Me.MetroLabel8.Text = "Cuenta a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pignorar:"
        '
        'cbPrestamos
        '
        Me.cbPrestamos.FormattingEnabled = True
        Me.cbPrestamos.ItemHeight = 23
        Me.cbPrestamos.Location = New System.Drawing.Point(109, 119)
        Me.cbPrestamos.Name = "cbPrestamos"
        Me.cbPrestamos.Size = New System.Drawing.Size(442, 29)
        Me.cbPrestamos.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbPrestamos.TabIndex = 185
        Me.cbPrestamos.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(19, 228)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel5.TabIndex = 186
        Me.MetroLabel5.Text = "Saldo:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.CustomFormat = "###,###,##0.00"
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtSaldo.Location = New System.Drawing.Point(109, 225)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtSaldo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtSaldo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtSaldo.Size = New System.Drawing.Size(172, 19)
        Me.txtSaldo.TabIndex = 187
        Me.txtSaldo.Tag = Nothing
        Me.txtSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(286, 213)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(73, 38)
        Me.MetroLabel9.TabIndex = 188
        Me.MetroLabel9.Text = "Saldo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Disponible:"
        '
        'txtSaldoDisponible
        '
        Me.txtSaldoDisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoDisponible.CustomFormat = "###,###,##0.00"
        Me.txtSaldoDisponible.Enabled = False
        Me.txtSaldoDisponible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDisponible.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtSaldoDisponible.Location = New System.Drawing.Point(379, 225)
        Me.txtSaldoDisponible.Name = "txtSaldoDisponible"
        Me.txtSaldoDisponible.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtSaldoDisponible.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtSaldoDisponible.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtSaldoDisponible.Size = New System.Drawing.Size(172, 19)
        Me.txtSaldoDisponible.TabIndex = 189
        Me.txtSaldoDisponible.Tag = Nothing
        Me.txtSaldoDisponible.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSaldoDisponible.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(22, 299)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(85, 38)
        Me.MetroLabel10.TabIndex = 190
        Me.MetroLabel10.Text = "% Permitido " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pignoración:"
        '
        'txtPctPermitidoPig
        '
        Me.txtPctPermitidoPig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPctPermitidoPig.CustomFormat = "###,###,##0.00"
        Me.txtPctPermitidoPig.Enabled = False
        Me.txtPctPermitidoPig.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPctPermitidoPig.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtPctPermitidoPig.Location = New System.Drawing.Point(109, 299)
        Me.txtPctPermitidoPig.Name = "txtPctPermitidoPig"
        Me.txtPctPermitidoPig.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtPctPermitidoPig.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtPctPermitidoPig.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtPctPermitidoPig.Size = New System.Drawing.Size(172, 19)
        Me.txtPctPermitidoPig.TabIndex = 191
        Me.txtPctPermitidoPig.Tag = Nothing
        Me.txtPctPermitidoPig.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPctPermitidoPig.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(19, 250)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel11.TabIndex = 192
        Me.MetroLabel11.Text = "% Pignorado:"
        '
        'Pignorado
        '
        Me.Pignorado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pignorado.CustomFormat = "###,###,##0.00"
        Me.Pignorado.Enabled = False
        Me.Pignorado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pignorado.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Pignorado.Location = New System.Drawing.Point(109, 250)
        Me.Pignorado.Name = "Pignorado"
        Me.Pignorado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.Pignorado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.Pignorado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.Pignorado.Size = New System.Drawing.Size(172, 19)
        Me.Pignorado.TabIndex = 193
        Me.Pignorado.Tag = Nothing
        Me.Pignorado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Pignorado.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtdispPignoracion
        '
        Me.txtdispPignoracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdispPignoracion.CustomFormat = "###,###,##0.00"
        Me.txtdispPignoracion.Enabled = False
        Me.txtdispPignoracion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdispPignoracion.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtdispPignoracion.Location = New System.Drawing.Point(109, 343)
        Me.txtdispPignoracion.Name = "txtdispPignoracion"
        Me.txtdispPignoracion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtdispPignoracion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtdispPignoracion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtdispPignoracion.Size = New System.Drawing.Size(172, 19)
        Me.txtdispPignoracion.TabIndex = 195
        Me.txtdispPignoracion.Tag = Nothing
        Me.txtdispPignoracion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtdispPignoracion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(19, 343)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel12.TabIndex = 194
        Me.MetroLabel12.Text = "% Disponible:"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(287, 299)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(82, 38)
        Me.MetroLabel13.TabIndex = 196
        Me.MetroLabel13.Text = "Disponible" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pignoración:"
        '
        'txtDispoPigno
        '
        Me.txtDispoPigno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDispoPigno.CustomFormat = "###,###,##0.00"
        Me.txtDispoPigno.Enabled = False
        Me.txtDispoPigno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispoPigno.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtDispoPigno.Location = New System.Drawing.Point(379, 299)
        Me.txtDispoPigno.Name = "txtDispoPigno"
        Me.txtDispoPigno.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtDispoPigno.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtDispoPigno.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtDispoPigno.Size = New System.Drawing.Size(172, 19)
        Me.txtDispoPigno.TabIndex = 197
        Me.txtDispoPigno.Tag = Nothing
        Me.txtDispoPigno.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDispoPigno.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(287, 250)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(74, 38)
        Me.MetroLabel14.TabIndex = 198
        Me.MetroLabel14.Text = "Monto " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pignorado:"
        '
        'txtMontoPignorado
        '
        Me.txtMontoPignorado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoPignorado.CustomFormat = "###,###,##0.00"
        Me.txtMontoPignorado.Enabled = False
        Me.txtMontoPignorado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPignorado.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMontoPignorado.Location = New System.Drawing.Point(379, 250)
        Me.txtMontoPignorado.Name = "txtMontoPignorado"
        Me.txtMontoPignorado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMontoPignorado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMontoPignorado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMontoPignorado.Size = New System.Drawing.Size(172, 19)
        Me.txtMontoPignorado.TabIndex = 199
        Me.txtMontoPignorado.Tag = Nothing
        Me.txtMontoPignorado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoPignorado.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(20, 386)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel15.TabIndex = 200
        Me.MetroLabel15.Text = "Tipo Ahorro:"
        '
        'TxtNombreAhorro
        '
        Me.TxtNombreAhorro.BackColor = System.Drawing.Color.White
        Me.TxtNombreAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreAhorro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreAhorro.ForeColor = System.Drawing.Color.Black
        Me.TxtNombreAhorro.Location = New System.Drawing.Point(109, 384)
        Me.TxtNombreAhorro.Multiline = True
        Me.TxtNombreAhorro.Name = "TxtNombreAhorro"
        Me.TxtNombreAhorro.ReadOnly = True
        Me.TxtNombreAhorro.Size = New System.Drawing.Size(268, 25)
        Me.TxtNombreAhorro.TabIndex = 201
        '
        'frmMsAhPignoracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(685, 535)
        Me.Controls.Add(Me.TxtNombreAhorro)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.txtMontoPignorado)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.txtDispoPigno)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.txtdispPignoracion)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.Pignorado)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.txtPctPermitidoPig)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.txtSaldoDisponible)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.cbPrestamos)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.cbCuentas)
        Me.Controls.Add(Me.c1nMontoPignorado)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.dtpVencimientoPrestamo)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroButton3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhPignoracion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = " "
        CType(Me.c1nMontoPignorado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPctPermitidoPig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pignorado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdispPignoracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDispoPigno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPignorado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private pSaldo As Double, pDisponible As Double, pFecVenc As Date, pMaximo As Double, vSumPignoradoxCuenta As Double
    Private pAccion, pId As Integer
#Region "Propiedades"

    Public Property Saldo() As Double
        Get
            Return pSaldo
        End Get
        Set(ByVal Value As Double)
            pSaldo = Value
        End Set
    End Property

    Public Property Disponible() As Double
        Get
            Return pDisponible
        End Get
        Set(ByVal Value As Double)
            pDisponible = Value
        End Set
    End Property
    Public Property accion() As Integer
        Get
            Return pAccion
        End Get
        Set(value As Integer)
            pAccion = value
        End Set
    End Property
    Public Property id() As Integer
        Get
            Return pId
        End Get
        Set(value As Integer)
            pId = value
        End Set
    End Property
#End Region
#Region "Listas"

    Protected Sub llenarPrestamos()
        Dim dts As New DataSet
        dts = prestamo.CargarListaPrestamos(False, "", "", Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
        cbPrestamos.DisplayMember = "codPrestamo"
        cbPrestamos.ValueMember = "codPrestamo"
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbPrestamos.DataSource = dts.Tables(0)
            Else
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Me.Close()
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
    Protected Sub llenarCuentas()
        Dim dts As New DataSet
        cbCuentas.DisplayMember = "NoCuenta"
        cbCuentas.ValueMember = "NoCuenta"
        dts = ahorro.ConsultarCuentaAhorroTipoAhorro("a.NoCuenta,a.codTipoahorro ", " a.Dui='" & Me.txtDui.Value & "' and a.Estado= 'A'  and a.SaldoDisponible_CuentaAhorro > 0 ", "a.NoCuenta", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbCuentas.DataSource = dts.Tables(0)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Asociado no posee cuenta de ahorro, por favor crear cuenta de ahorro.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Me.Close()
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Asociado no posee cuenta de ahorro, por favor crear cuenta de ahorro.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Me.Close()
        End If

    End Sub
#End Region
    Protected Sub inhabilitarControles()
        txtDui.Enabled = False
        txtNoSocio.Enabled = False
        txtAsociado.Enabled = False
        cbPrestamos.Enabled = False
        dtpVencimientoPrestamo.Enabled = False
        cbCuentas.Enabled = False
        c1nMontoPignorado.Enabled = False
    End Sub
    Private Sub frmMsAhPignoracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If accion = 2 Then
                Dim dts As New DataSet
                dts = ahorro.ConsultarCuentaAhorro("P", "b.correlativo ='" & pId & "' ", " b.correlativo ", sUsuario, sPassword, sSucursal)
                If dts.Tables(0).Rows.Count > 0 Then
                    txtDui.Text = dts.Tables(0).Rows(0).Item("dui").ToString.Trim
                    txtNoSocio.Text = dts.Tables(0).Rows(0).Item("nosocio")
                    txtAsociado.Text = dts.Tables(0).Rows(0).Item("asociado")
                    TxtNombreAhorro.Text = dts.Tables(0).Rows(0).Item("TipoAhorro")
                    llenarCuentas()

                    llenarPrestamos()

                    cbPrestamos.SelectedValue = dts.Tables(0).Rows(0).Item("codPrestamo")
                    dtpVencimientoPrestamo.Value = dts.Tables(0).Rows(0).Item("Vencimiento")
                    cbCuentas.SelectedValue = dts.Tables(0).Rows(0).Item("NoCuenta")
                    c1nMontoPignorado.Value = dts.Tables(0).Rows(0).Item("Monto")
                    'Recuperamos informacion de asociado

                    inhabilitarControles()
                End If
                '  dts = ahorro.ConsultarPignoracion()
            End If
        Catch ex As Exception

        End Try

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
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
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
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Dim sTexto As String
            If Me.txtDui.Value Is DBNull.Value Then Exit Sub

            Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
            Dim oAh As New wrAhorro.wsLibAhorro
            Try
                oAsoc = New wrAsociados.wsLibAsoc
                sTexto = Me.txtDui.Value
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
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If ahorro.despignorarCuentaAhorro(id, sUsuario, sPassword, sSucursal) > 0 Then
                MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
            Me.Close()

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ingresoValido() As Boolean
        If txtDispoPigno.Value < c1nMontoPignorado.Value Then
            MetroFramework.MetroMessageBox.Show(Me, "Monto a pignorar mayor que monto disponible", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return False
        End If
        If c1nMontoPignorado.Value = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "Monto a pignorar debe ser mayor que cero", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click

        Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
        Dim pCodTipoAhorro As String, pPorcPig As Double, pDisponible As Double, dr As DataRow
        Dim pMontoPignorado As Double, vSumPign As Double, vTotPorcPig As Double, vPorPigPar As Double

        Try

            If codTipoAhorro = 3101 Then
                MetroFramework.MetroMessageBox.Show(Me, "Seguro que PIGNORA una cuenta de AHORRO A LA VISTA", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
            If ingresoValido() = True Then
                If ahorro.pignorarCuentaAhorro(cbCuentas.SelectedValue.ToString.Trim, cbPrestamos.SelectedValue.ToString.Trim,
                                               c1nMontoPignorado.Value, Now.ToShortDateString,
                                               dtpVencimientoPrestamo.Value.ToShortDateString, "N", sUsuario) > 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                End If
            End If

            Me.Close()

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbCuentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCuentas.SelectedIndexChanged

    End Sub

    Private Sub c1nMontoPignorado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nMontoPignorado.LostFocus
        'Me.lblMax.Text = "Porcentaje a pignorar: " & CStr(Math.Round((Me.c1nMontoPignorado.Value / (Saldo * vSumPignoradoxCuenta)) * 100, 2)) & "%"
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Dim sTexto As String
        If Me.txtDui.Text.Trim = "" Then Exit Sub

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Dim oAh As New wrAhorro.wsLibAhorro
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Value
            If sTexto = "" Then      'Filtrar Registros

            ElseIf sTexto <> "" Then

                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                    llenarCuentas()
                    cbCuentas.SelectedIndex = 0
                    llenarPrestamos()
                    cbPrestamos.SelectedIndex = 0
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbPrestamos_Validated(sender As Object, e As EventArgs) Handles cbPrestamos.Validated
        Dim dts As New DataSet
        dts = prestamo.ConsultarDatosPrestamos(txtDui.Text, cbPrestamos.SelectedValue, 2)
        dtpVencimientoPrestamo.Value = dts.Tables(0).Rows(0).Item("FECHAVENCIMIENTO")
    End Sub

    Private Sub cbCuentas_Validated(sender As Object, e As EventArgs) Handles cbCuentas.Validated
        Dim dts As New DataSet
        Dim dtsParametros As New DataSet

        dts = ahorro.ConsultarCuentaAhorro("Saldo_CuentaAhorro,SaldoDisponible_CuentaAhorro,isnull(MontoPignorado,0)[montoPignorado]",
                                           " nocuenta = '" & cbCuentas.SelectedValue.trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
        codTipoAhorro = dts.Tables(0).Rows(0).Item(0)
        txtSaldo.Value = dts.Tables(0).Rows(0).Item(1)
        txtSaldoDisponible.Value = dts.Tables(0).Rows(0).Item(2)
        txtMontoPignorado.Value = dts.Tables(0).Rows(0).Item(3)
        TxtNombreAhorro.Text = Trim(dts.Tables(0).Rows(0).Item(4))

        dtsParametros = ahorro.ConsultarParametros("PorcentajePignoracion", "CodTipoAhorro='" & codTipoAhorro & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
        If dtsParametros.Tables(0).Rows.Count > 0 Then
            txtPctPermitidoPig.Value = dtsParametros.Tables(0).Rows(0).Item(0)
        End If
        Dim disponible As Double
        If dts.Tables(0).Rows(0).Item(3) > 0 Then

            Pignorado.Value = Math.Round((dts.Tables(0).Rows(0).Item(3) / txtSaldo.Value) * 100, 2)
            txtdispPignoracion.Value = Math.Round(txtPctPermitidoPig.Value - Pignorado.Value, 2)
            disponible = ((txtSaldo.Value * (txtPctPermitidoPig.Value / 100))) - txtMontoPignorado.Value
            txtDispoPigno.Value = disponible
        Else
            txtdispPignoracion.Value = txtPctPermitidoPig.Value
            txtDispoPigno.Value = Math.Round((txtSaldo.Value * (txtPctPermitidoPig.Value / 100)), 2)
        End If

    End Sub

    Private Sub frmMsAhPignoracion_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class