Public Class frmMsItemsFact
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Private ValorGravado As String = ""
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbAplicacion As ComboBox
    Private NoValorGravado As String = ""
    Dim asociado As New wrAsociados.wsLibAsoc
    Dim administracion As New wrAdmin.wsLibAdmin
    Dim caja As New wrCaja.wsLibCaja

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
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdCuentaA As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuentaC As System.Windows.Forms.TextBox
    Friend WithEvents la As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCodItem As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTipoItem As System.Windows.Forms.TextBox
    Friend WithEvents txtOrden As C1.Win.C1Input.C1TextBox
    Friend WithEvents rbtNoGravNoExen As System.Windows.Forms.RadioButton
    Friend WithEvents rbtGravado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtExcento As System.Windows.Forms.RadioButton
    Friend WithEvents txtTipoMovimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAplicaCuenta As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents cbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1nValor As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c1nValor = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkAplicaCuenta = New System.Windows.Forms.CheckBox()
        Me.txtTipoMovimiento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbtExcento = New System.Windows.Forms.RadioButton()
        Me.rbtNoGravNoExen = New System.Windows.Forms.RadioButton()
        Me.rbtGravado = New System.Windows.Forms.RadioButton()
        Me.txtOrden = New C1.Win.C1Input.C1TextBox()
        Me.txtTipoItem = New System.Windows.Forms.TextBox()
        Me.txtIdCuentaA = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtIdCuentaC = New System.Windows.Forms.TextBox()
        Me.la = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodItem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.cbAplicacion = New System.Windows.Forms.ComboBox()
        Me.gbDatDoc.SuspendLayout()
        CType(Me.c1nValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.cbAplicacion)
        Me.gbDatDoc.Controls.Add(Me.cbEstado)
        Me.gbDatDoc.Controls.Add(Me.Label7)
        Me.gbDatDoc.Controls.Add(Me.Label6)
        Me.gbDatDoc.Controls.Add(Me.c1nValor)
        Me.gbDatDoc.Controls.Add(Me.Label5)
        Me.gbDatDoc.Controls.Add(Me.cbDoc)
        Me.gbDatDoc.Controls.Add(Me.cbRubro)
        Me.gbDatDoc.Controls.Add(Me.Label4)
        Me.gbDatDoc.Controls.Add(Me.Label3)
        Me.gbDatDoc.Controls.Add(Me.chkAplicaCuenta)
        Me.gbDatDoc.Controls.Add(Me.txtTipoMovimiento)
        Me.gbDatDoc.Controls.Add(Me.Label1)
        Me.gbDatDoc.Controls.Add(Me.rbtExcento)
        Me.gbDatDoc.Controls.Add(Me.rbtNoGravNoExen)
        Me.gbDatDoc.Controls.Add(Me.rbtGravado)
        Me.gbDatDoc.Controls.Add(Me.txtOrden)
        Me.gbDatDoc.Controls.Add(Me.txtTipoItem)
        Me.gbDatDoc.Controls.Add(Me.txtIdCuentaA)
        Me.gbDatDoc.Controls.Add(Me.Label15)
        Me.gbDatDoc.Controls.Add(Me.Label31)
        Me.gbDatDoc.Controls.Add(Me.Label19)
        Me.gbDatDoc.Controls.Add(Me.txtDesc)
        Me.gbDatDoc.Controls.Add(Me.txtIdCuentaC)
        Me.gbDatDoc.Controls.Add(Me.la)
        Me.gbDatDoc.Controls.Add(Me.Label9)
        Me.gbDatDoc.Controls.Add(Me.txtCodItem)
        Me.gbDatDoc.Controls.Add(Me.Label10)
        Me.gbDatDoc.Controls.Add(Me.Label8)
        Me.gbDatDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Black
        Me.gbDatDoc.Location = New System.Drawing.Point(23, 63)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(572, 277)
        Me.gbDatDoc.TabIndex = 0
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Información Personal"
        '
        'cbEstado
        '
        Me.cbEstado.BackColor = System.Drawing.Color.White
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Items.AddRange(New Object() {"0 - Ninguno", "1 - Cartera Normal", "2 - Doc. x Cobrar", "3 - Doc. en Protesto (Cobro Judicial)", "4 - Doc. en Protesto Saneados", "5 - Cuentas de Orden"})
        Me.cbEstado.Location = New System.Drawing.Point(369, 73)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(183, 22)
        Me.cbEstado.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(283, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 32)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "Estado (Aplica " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Préstamos):"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 26)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Clasificación " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de IVA:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'c1nValor
        '
        Me.c1nValor.BackColor = System.Drawing.Color.White
        Me.c1nValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nValor.CustomFormat = "###,###,##0.00"
        Me.c1nValor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nValor.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nValor.Location = New System.Drawing.Point(369, 101)
        Me.c1nValor.Name = "c1nValor"
        Me.c1nValor.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nValor.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nValor.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nValor.Size = New System.Drawing.Size(183, 19)
        Me.c1nValor.TabIndex = 7
        Me.c1nValor.Tag = Nothing
        Me.c1nValor.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nValor.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(283, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Valor:"
        '
        'cbDoc
        '
        Me.cbDoc.BackColor = System.Drawing.Color.White
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.Items.AddRange(New Object() {"F - Factura", "C - Crédito Fiscal", "R - Comprobante Retiro", "D - Comprobante Depósito", "P - Comprobante de Pago o Recibo", "H - Comprobante de Cambio de Cheque"})
        Me.cbDoc.Location = New System.Drawing.Point(94, 71)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(183, 22)
        Me.cbDoc.TabIndex = 4
        '
        'cbRubro
        '
        Me.cbRubro.BackColor = System.Drawing.Color.White
        Me.cbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubro.Items.AddRange(New Object() {"1 - Aportaciones", "2 - Préstamos", "3 - Ahorros", "4 - Depósito Plazo Fijo", "5 - Movimientos Contables", "6 - Dividendos", "7 - Cobranza", "9 - Otros", "12- Ingreso Asociados"})
        Me.cbRubro.Location = New System.Drawing.Point(369, 45)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(183, 22)
        Me.cbRubro.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Tipo Doc.:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(283, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Cód. Rubro:"
        '
        'chkAplicaCuenta
        '
        Me.chkAplicaCuenta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAplicaCuenta.Location = New System.Drawing.Point(10, 149)
        Me.chkAplicaCuenta.Name = "chkAplicaCuenta"
        Me.chkAplicaCuenta.Size = New System.Drawing.Size(156, 18)
        Me.chkAplicaCuenta.TabIndex = 10
        Me.chkAplicaCuenta.Text = "Aplica Cuenta Contable:"
        '
        'txtTipoMovimiento
        '
        Me.txtTipoMovimiento.BackColor = System.Drawing.Color.White
        Me.txtTipoMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoMovimiento.Location = New System.Drawing.Point(94, 99)
        Me.txtTipoMovimiento.MaxLength = 2
        Me.txtTipoMovimiento.Name = "txtTipoMovimiento"
        Me.txtTipoMovimiento.Size = New System.Drawing.Size(183, 20)
        Me.txtTipoMovimiento.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Tipo Movimiento:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbtExcento
        '
        Me.rbtExcento.Location = New System.Drawing.Point(205, 224)
        Me.rbtExcento.Name = "rbtExcento"
        Me.rbtExcento.Size = New System.Drawing.Size(72, 24)
        Me.rbtExcento.TabIndex = 14
        Me.rbtExcento.Text = "Excento"
        '
        'rbtNoGravNoExen
        '
        Me.rbtNoGravNoExen.Location = New System.Drawing.Point(313, 228)
        Me.rbtNoGravNoExen.Name = "rbtNoGravNoExen"
        Me.rbtNoGravNoExen.Size = New System.Drawing.Size(192, 17)
        Me.rbtNoGravNoExen.TabIndex = 15
        Me.rbtNoGravNoExen.Text = "No Aplica Gravado ni Excento"
        '
        'rbtGravado
        '
        Me.rbtGravado.Location = New System.Drawing.Point(94, 224)
        Me.rbtGravado.Name = "rbtGravado"
        Me.rbtGravado.Size = New System.Drawing.Size(72, 24)
        Me.rbtGravado.TabIndex = 13
        Me.rbtGravado.Text = "Gravado"
        '
        'txtOrden
        '
        Me.txtOrden.BackColor = System.Drawing.Color.White
        Me.txtOrden.DataType = GetType(Integer)
        Me.txtOrden.FormatType = C1.Win.C1Input.FormatTypeEnum.[Integer]
        Me.txtOrden.Location = New System.Drawing.Point(94, 125)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtOrden.Size = New System.Drawing.Size(183, 18)
        Me.txtOrden.TabIndex = 8
        Me.txtOrden.Tag = Nothing
        Me.txtOrden.Value = 0
        '
        'txtTipoItem
        '
        Me.txtTipoItem.BackColor = System.Drawing.Color.White
        Me.txtTipoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoItem.Location = New System.Drawing.Point(94, 45)
        Me.txtTipoItem.MaxLength = 1
        Me.txtTipoItem.Name = "txtTipoItem"
        Me.txtTipoItem.Size = New System.Drawing.Size(183, 20)
        Me.txtTipoItem.TabIndex = 2
        '
        'txtIdCuentaA
        '
        Me.txtIdCuentaA.BackColor = System.Drawing.Color.White
        Me.txtIdCuentaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCuentaA.Enabled = False
        Me.txtIdCuentaA.Location = New System.Drawing.Point(369, 175)
        Me.txtIdCuentaA.MaxLength = 20
        Me.txtIdCuentaA.Name = "txtIdCuentaA"
        Me.txtIdCuentaA.Size = New System.Drawing.Size(183, 20)
        Me.txtIdCuentaA.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(283, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 130
        Me.Label15.Text = "Cuenta Abono:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(6, 47)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 13)
        Me.Label31.TabIndex = 126
        Me.Label31.Text = "Tipo Item:"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(6, 125)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 121
        Me.Label19.Text = "Orden:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Location = New System.Drawing.Point(238, 19)
        Me.txtDesc.MaxLength = 255
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDesc.Size = New System.Drawing.Size(314, 20)
        Me.txtDesc.TabIndex = 1
        '
        'txtIdCuentaC
        '
        Me.txtIdCuentaC.BackColor = System.Drawing.Color.White
        Me.txtIdCuentaC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCuentaC.Enabled = False
        Me.txtIdCuentaC.Location = New System.Drawing.Point(94, 173)
        Me.txtIdCuentaC.MaxLength = 20
        Me.txtIdCuentaC.Name = "txtIdCuentaC"
        Me.txtIdCuentaC.Size = New System.Drawing.Size(183, 20)
        Me.txtIdCuentaC.TabIndex = 11
        '
        'la
        '
        Me.la.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la.ForeColor = System.Drawing.Color.Black
        Me.la.Location = New System.Drawing.Point(12, 170)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(82, 13)
        Me.la.TabIndex = 113
        Me.la.Text = "Cuenta Cargo:"
        Me.la.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(166, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Descripción:"
        '
        'txtCodItem
        '
        Me.txtCodItem.BackColor = System.Drawing.Color.White
        Me.txtCodItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodItem.Location = New System.Drawing.Point(94, 19)
        Me.txtCodItem.MaxLength = 10
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.Size = New System.Drawing.Size(64, 20)
        Me.txtCodItem.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Código Item:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(283, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Cód. Aplicación:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(520, 346)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1013
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'cbAplicacion
        '
        Me.cbAplicacion.BackColor = System.Drawing.Color.White
        Me.cbAplicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAplicacion.Items.AddRange(New Object() {"1 - Aportaciones", "2 - Préstamos", "3 - Ahorros", "4 - Depósito Plazo Fijo", "5 - Movimientos Contables", "6 - Dividendos", "7 - Cobranza", "9 - Otros", "12- Ingreso Asociados"})
        Me.cbAplicacion.Location = New System.Drawing.Point(369, 126)
        Me.cbAplicacion.Name = "cbAplicacion"
        Me.cbAplicacion.Size = New System.Drawing.Size(183, 22)
        Me.cbAplicacion.TabIndex = 149
        '
        'frmMsItemsFact
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(617, 406)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.gbDatDoc)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsItemsFact"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Items Facturables"
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        CType(Me.c1nValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub llenarCbRubros()
        Try
            Dim dts As New DataSet
            dts = caja.ObtenerListaRubros("idRubro,Descripcion", "", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.cbRubro.DataSource = dts.Tables(0)
                    Me.cbRubro.DisplayMember = "Descripcion"
                    Me.cbRubro.ValueMember = "idRubro"
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub llenarcbAplicaciones()
        Try
            Dim dts As New DataSet
            dts = administracion.ConsultarApp("idApp,descripcion")
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.cbAplicacion.DataSource = dts.Tables(0)
                    Me.cbAplicacion.DisplayMember = "descripcion"
                    Me.cbAplicacion.ValueMember = "idApp"
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub txtIdApp_DoubleClick1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim oApp As wrAdmin.wsLibAdmin = New wrAdmin.wsLibAdmin
        'Dim ds As New Data.DataSet
        'Dim ofrm As New frmAGenerico
        'Dim Resultado As String

        'Try
        '    ds = oApp.ConsultarApp("*")
        '    ofrm.Datos = ds
        '    ofrm.ColSeleccion = 0
        '    ofrm.RefrescarGrid()
        '    ofrm.ShowDialog()
        '    Resultado = ofrm.Resultado
        '    Me.txtIdApp.Text = Resultado
        'Catch ex As Exception
        '    MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Caja")
        'End Try
    End Sub

    Private Sub txtIdApp_Validating1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'Dim oApp As wrAdmin.wsLibAdmin = New wrAdmin.wsLibAdmin
        'Dim ds As New Data.DataSet
        'Dim Filas As Data.DataRowCollection
        'ds = oApp.ConsultarApp("*")
        'Filas = ds.Tables(0).Rows()
        'Me.txtIdApp.Text = Filas.Item(0)("IdApp")
    End Sub


    Private Sub chkAplicaCuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAplicaCuenta.CheckedChanged
        If Me.txtIdCuentaA.Enabled = True Then
            Me.txtIdCuentaA.Enabled = False
        Else
            Me.txtIdCuentaA.Enabled = True
        End If
        If Me.txtIdCuentaC.Enabled = True Then
            Me.txtIdCuentaC.Enabled = False
        Else
            Me.txtIdCuentaC.Enabled = True
        End If
    End Sub

    Private Sub frmMsItemsFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.btnGuardar1.Text = "&Guardar" Then
            llenarCbRubros()
            llenarcbAplicaciones()
        End If

    End Sub

    Private Sub txtIdCuentaA_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuentaA.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("*", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtIdCuentaA.Text = ofrm.Resultado.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtIdCuentaC_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuentaC.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("*", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtIdCuentaC.Text = ofrm.Resultado.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Dim oItem As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
        Dim oCtb As New wrConta.wsLibContab, ds As New DataSet ', dr As DataRow
        Dim Campos, Valores, CamposValores As String, AplicaCta As String
        Try
            If Me.chkAplicaCuenta.Checked = True Then
                AplicaCta = "1"
            ElseIf Me.chkAplicaCuenta.Checked = False Then
                AplicaCta = "0"
            End If

            If Me.txtIdCuentaA.Text.Trim <> "" Then
                ds = oCtb.ObtenerCatContab("*", "Final='S' and IdCuenta='" & Me.txtIdCuentaA.Text.Trim & "'", "idCuenta", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                Else
                    MessageBox.Show("El código de cuenta contable no existe, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            If Me.txtIdCuentaC.Text.Trim <> "" Then
                ds = oCtb.ObtenerCatContab("*", "Final='S' and IdCuenta='" & Me.txtIdCuentaC.Text.Trim & "'", "idCuenta", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                Else
                    MessageBox.Show("El código de cuenta contable no existe, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then

                If Me.rbtGravado.Checked = True Then
                    ValorGravado = "S"
                    NoValorGravado = "N"
                ElseIf Me.rbtExcento.Checked = True Then
                    ValorGravado = "N"
                    NoValorGravado = "N"
                ElseIf Me.rbtNoGravNoExen.Checked = True Then
                    NoValorGravado = "S"
                    ValorGravado = "N"
                End If

                Campos = "CodItem,Descripcion,Tipo_Item,idApp,Gravado,idCuentaC,idCuentaA,Orden,NoAplicaGravado,TipoMovimiento,AplicaCuenta,IdRubro,TipoDoc,Valor,Estado"
                Valores = "'" & Trim(Me.txtCodItem.Text) & "','" & Trim(Me.txtDesc.Text) & "','" & Trim(Me.txtTipoItem.Text) & "'," & Val(cbAplicacion.SelectedValue) & ",'" & ValorGravado & "','" & Trim(Me.txtIdCuentaC.Text) & "','" & Trim(Me.txtIdCuentaA.Text) & "'," & Val(Me.txtOrden.Text) & ",'" & Trim(NoValorGravado) & "','" & Trim(Me.txtTipoMovimiento.Text) & "','" & AplicaCta & "','" & Me.cbRubro.SelectedValue & "','" & Mid(Me.cbDoc.Text, 1, 1) & "'," & Val(Me.c1nValor.Value) & "," & Me.cbEstado.SelectedIndex & ""
                If oItem.InsertarCAItemsFact(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fueron ingresados correctamente.", MsgBoxStyle.Information, "Módulo - Caja")
                End If

            ElseIf Me.btnGuardar1.Text = "&Modificar" Then

                If Me.rbtGravado.Checked = True Then
                    ValorGravado = "S"
                    NoValorGravado = "N"
                ElseIf Me.rbtExcento.Checked = True Then
                    ValorGravado = "N"
                    NoValorGravado = "N"
                ElseIf Me.rbtNoGravNoExen.Checked = True Then
                    NoValorGravado = "S"
                    ValorGravado = "N"
                End If

                CamposValores = "Descripcion='" & Trim(Me.txtDesc.Text) & "',Tipo_Item='" & Trim(Me.txtTipoItem.Text) & "',idApp=" & Val(Me.cbAplicacion.SelectedValue) & ",Gravado='" & ValorGravado & "',idCuentaC='" & Trim(Me.txtIdCuentaC.Text) & "',idCuentaA='" & Trim(Me.txtIdCuentaA.Text) & "',Orden=" & Val(Me.txtOrden.Text) & ",NoAplicaGravado='" & Trim(NoValorGravado) & "',TipoMovimiento='" & Trim(Me.txtTipoMovimiento.Text) & "',AplicaCuenta ='" & AplicaCta & "',IdRubro='" & Me.cbRubro.SelectedValue & "',TipoDoc='" & Mid(Me.cbDoc.Text, 1, 1) & "',Valor=" & Val(Me.c1nValor.Value) & ",Estado=" & Me.cbEstado.SelectedIndex & ""

                If oItem.ModificarCAItemsFact(CamposValores, "'" & Trim(Me.txtCodItem.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fueron modificados correctamente.", MsgBoxStyle.Information, "Módulo - Caja")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class