Public Class frmTransferenciaManualCtaAhorros
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Private sNoCuenta As String, pSaldoOrigen As Double, pPignorado As String, vCancela As Boolean, pCodTransferencia As String, pCodTransaccion As String, vDPF As Boolean
    ', sSupervisor As String, pPassword As String
    Public dsDetalle As New DataSet
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCuenta As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCentroCosto As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCuentaContable As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Dim contabilidad As New wrConta.wsLibContab
    Friend WithEvents chkDPF As CheckBox
    Dim ahorro As New wrAhorro.wsLibAhorro

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
    Friend WithEvents btNProcesar As MetroFramework.Controls.MetroButton
    Friend WithEvents btBorrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents c1txtObservaciones As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtNoDoc As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtNombreAsoc As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    'Friend WithEvents btnModificar As System.Windows.Forms.Button
    'Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtCodTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferenciaManualCtaAhorros))
        Me.btNProcesar = New MetroFramework.Controls.MetroButton()
        Me.btBorrar = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtCodTipo = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.c1txtObservaciones = New C1.Win.C1Input.C1TextBox()
        Me.c1txtNoDoc = New C1.Win.C1Input.C1TextBox()
        Me.c1txtNombreAsoc = New C1.Win.C1Input.C1TextBox()
        Me.c1txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.cbCuenta = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.cbCentroCosto = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.cbCuentaContable = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.chkDPF = New System.Windows.Forms.CheckBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNombreAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btNProcesar
        '
        Me.btNProcesar.Location = New System.Drawing.Point(316, 556)
        Me.btNProcesar.Name = "btNProcesar"
        Me.btNProcesar.Size = New System.Drawing.Size(83, 27)
        Me.btNProcesar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNProcesar.TabIndex = 230
        Me.btNProcesar.Text = "Procesar"
        Me.btNProcesar.UseSelectable = True
        Me.btNProcesar.UseStyleColors = True
        '
        'btBorrar
        '
        Me.btBorrar.Location = New System.Drawing.Point(492, 556)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(83, 27)
        Me.btBorrar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btBorrar.TabIndex = 229
        Me.btBorrar.Text = "Limpiar"
        Me.btBorrar.UseSelectable = True
        Me.btBorrar.UseStyleColors = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(404, 556)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(83, 27)
        Me.btnImprimir.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir.TabIndex = 228
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseSelectable = True
        Me.btnImprimir.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(103, 400)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(84, 29)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 233
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(392, 354)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(185, 20)
        Me.txtTotal.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(16, 400)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 29)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 234
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(16, 434)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(561, 116)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 3
        '
        'txtCodTipo
        '
        Me.txtCodTipo.Location = New System.Drawing.Point(350, 16)
        Me.txtCodTipo.Name = "txtCodTipo"
        Me.txtCodTipo.Size = New System.Drawing.Size(8, 20)
        Me.txtCodTipo.TabIndex = 164
        Me.txtCodTipo.Visible = False
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(117, 134)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(170, 18)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(405, 132)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(170, 20)
        Me.txtNoSocio.TabIndex = 163
        '
        'c1txtObservaciones
        '
        Me.c1txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtObservaciones.Location = New System.Drawing.Point(118, 296)
        Me.c1txtObservaciones.MaxLength = 255
        Me.c1txtObservaciones.Multiline = True
        Me.c1txtObservaciones.Name = "c1txtObservaciones"
        Me.c1txtObservaciones.NumericInput = False
        Me.c1txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtObservaciones.Size = New System.Drawing.Size(459, 52)
        Me.c1txtObservaciones.TabIndex = 6
        Me.c1txtObservaciones.Tag = Nothing
        '
        'c1txtNoDoc
        '
        Me.c1txtNoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNoDoc.CustomFormat = "00000000000000000000"
        Me.c1txtNoDoc.DataType = GetType(Long)
        Me.c1txtNoDoc.Location = New System.Drawing.Point(117, 107)
        Me.c1txtNoDoc.MaxLength = 14
        Me.c1txtNoDoc.Name = "c1txtNoDoc"
        Me.c1txtNoDoc.NumericInput = False
        Me.c1txtNoDoc.Size = New System.Drawing.Size(170, 18)
        Me.c1txtNoDoc.TabIndex = 2
        Me.c1txtNoDoc.Tag = Nothing
        '
        'c1txtNombreAsoc
        '
        Me.c1txtNombreAsoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNombreAsoc.Location = New System.Drawing.Point(117, 157)
        Me.c1txtNombreAsoc.MaxLength = 14
        Me.c1txtNombreAsoc.Name = "c1txtNombreAsoc"
        Me.c1txtNombreAsoc.NumericInput = False
        Me.c1txtNombreAsoc.ReadOnly = True
        Me.c1txtNombreAsoc.Size = New System.Drawing.Size(458, 18)
        Me.c1txtNombreAsoc.TabIndex = 94
        Me.c1txtNombreAsoc.Tag = Nothing
        '
        'c1txtMonto
        '
        Me.c1txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtMonto.CustomFormat = "###,###,##0.00"
        Me.c1txtMonto.DataType = GetType(Double)
        Me.c1txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1txtMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1txtMonto.Location = New System.Drawing.Point(118, 354)
        Me.c1txtMonto.Name = "c1txtMonto"
        Me.c1txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(0R, Nothing, True, True)})
        Me.c1txtMonto.Size = New System.Drawing.Size(170, 19)
        Me.c1txtMonto.TabIndex = 5
        Me.c1txtMonto.Tag = Nothing
        Me.c1txtMonto.Value = 0R
        Me.c1txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(117, 81)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(458, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(-16, -16)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "MetroLabel1"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel2.Location = New System.Drawing.Point(19, 55)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(70, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel2.TabIndex = 8
        Me.MetroLabel2.Text = "Origen:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(-16, -16)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel3.TabIndex = 9
        Me.MetroLabel3.Text = "MetroLabel3"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(19, 87)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel4.TabIndex = 10
        Me.MetroLabel4.Text = "Fecha:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(19, 112)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel5.TabIndex = 11
        Me.MetroLabel5.Text = "No. Documento:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(19, 135)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel6.TabIndex = 165
        Me.MetroLabel6.Text = "DUI:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(322, 132)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel7.TabIndex = 166
        Me.MetroLabel7.Text = "No. Asociado:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(19, 157)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel8.TabIndex = 167
        Me.MetroLabel8.Text = "Asociado:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(21, 204)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel9.TabIndex = 168
        Me.MetroLabel9.Text = "Cuenta Cargo:"
        '
        'cbCuenta
        '
        Me.cbCuenta.FormattingEnabled = True
        Me.cbCuenta.ItemHeight = 23
        Me.cbCuenta.Location = New System.Drawing.Point(117, 203)
        Me.cbCuenta.Name = "cbCuenta"
        Me.cbCuenta.Size = New System.Drawing.Size(460, 29)
        Me.cbCuenta.TabIndex = 169
        Me.cbCuenta.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(21, 236)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel10.TabIndex = 170
        Me.MetroLabel10.Text = "Centro Costo:"
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.Enabled = False
        Me.cbCentroCosto.FormattingEnabled = True
        Me.cbCentroCosto.ItemHeight = 23
        Me.cbCentroCosto.Location = New System.Drawing.Point(118, 234)
        Me.cbCentroCosto.Name = "cbCentroCosto"
        Me.cbCentroCosto.Size = New System.Drawing.Size(459, 29)
        Me.cbCentroCosto.TabIndex = 171
        Me.cbCentroCosto.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(21, 266)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel11.TabIndex = 172
        Me.MetroLabel11.Text = "Cuenta Contable:"
        '
        'cbCuentaContable
        '
        Me.cbCuentaContable.Enabled = False
        Me.cbCuentaContable.FormattingEnabled = True
        Me.cbCuentaContable.ItemHeight = 23
        Me.cbCuentaContable.Location = New System.Drawing.Point(118, 265)
        Me.cbCuentaContable.Name = "cbCuentaContable"
        Me.cbCuentaContable.Size = New System.Drawing.Size(459, 29)
        Me.cbCuentaContable.TabIndex = 173
        Me.cbCuentaContable.UseSelectable = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(21, 296)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel12.TabIndex = 174
        Me.MetroLabel12.Text = "Observaciones:"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(19, 339)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(66, 38)
        Me.MetroLabel13.TabIndex = 175
        Me.MetroLabel13.Text = "Monto a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Transferir:"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel14.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel14.Location = New System.Drawing.Point(19, 376)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(123, 25)
        Me.MetroLabel14.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel14.TabIndex = 176
        Me.MetroLabel14.Text = "Destino          "
        Me.MetroLabel14.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel14.UseCustomBackColor = True
        Me.MetroLabel14.UseCustomForeColor = True
        Me.MetroLabel14.UseStyleColors = True
        '
        'chkDPF
        '
        Me.chkDPF.AutoSize = True
        Me.chkDPF.Location = New System.Drawing.Point(117, 179)
        Me.chkDPF.Name = "chkDPF"
        Me.chkDPF.Size = New System.Drawing.Size(151, 17)
        Me.chkDPF.TabIndex = 235
        Me.chkDPF.Text = "Cancelar Deposito a Plazo"
        Me.chkDPF.UseVisualStyleBackColor = True
        '
        'frmTransferenciaManualCtaAhorros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(722, 706)
        Me.Controls.Add(Me.chkDPF)
        Me.Controls.Add(Me.btNProcesar)
        Me.Controls.Add(Me.btBorrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cbCuentaContable)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.cbCentroCosto)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.cbCuenta)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.c1txtObservaciones)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.c1txtMonto)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.txtCodTipo)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.c1txtNoDoc)
        Me.Controls.Add(Me.c1txtNombreAsoc)
        Me.Location = New System.Drawing.Point(672, 456)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransferenciaManualCtaAhorros"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Transferencia Cuentas Auxiliares"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNombreAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "metodos"
    Protected Sub llenarCbCuentas()
        Dim dts As New DataSet
        cbCuenta.DisplayMember = "nocuenta"
        cbCuenta.ValueMember = "nocuenta"
        If chkDPF.Checked = True Then
            dts = ahorro.ConsultarCtasAhorroDUI("nocuenta", " a.DUI='" & Me.txtDui.Value & "' AND LEFT(A.CodTipoAhorro,1)='6' AND A.Saldo_CuentaAhorro > 0 AND (A.FechaVencimiento = '" & Now.ToShortDateString & "' OR A.Prorrogado ='S')", "", sUsuario, sPassword, sSucursal)
        Else
            dts = ahorro.ConsultarCtasAhorroDUI("nocuenta", " a.DUI='" & Me.txtDui.Value & "' AND LEFT(A.CodTipoAhorro,1) NOT IN ('6') and a.saldo_Cuentaahorro > 0", "", sUsuario, sPassword, sSucursal)
        End If

        cbCuenta.DataSource = dts.Tables(0)
    End Sub
    Protected Sub llenarDatosContables(ByVal nocuenta As String)
        Dim dts As New DataSet
        dts = ahorro.ConsultarCtasAhorroDUI("b.IdCuenta as Cuenta_Contable," &
                                            "a.codSucursal, d.Cod_CCosto, d.Descripcion", "a.nocuenta='" & nocuenta & "' ", "", sUsuario, sPassword, sSucursal)
        cbCentroCosto.DataSource = dts.Tables(0)
        cbCentroCosto.DisplayMember = "Descripcion"
        cbCentroCosto.ValueMember = "cod_ccosto"
        cbCuentaContable.DataSource = dts.Tables(0)
        cbCuentaContable.ValueMember = "Cuenta_Contable"
        cbCuentaContable.DisplayMember = "Cuenta_Contable"

    End Sub
    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "No."
        fg.Cols.Item(2).Caption = "No. Cuenta"
        fg.Cols.Item(3).Caption = "Cta. Contable"
        fg.Cols.Item(4).Caption = "Valor"
        fg.Cols.Item(5).Caption = "Tipo Movimiento"
        fg.Cols.Item(6).Caption = "Tipo Cuenta"
        fg.Cols.Item(7).Caption = "Fecha"
        fg.Cols.Item(4).Format = "##0.00"

        fg.Cols.Item(1).Width = 77
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 77
        fg.Cols.Item(5).Width = 0
        fg.Cols.Item(6).Width = 0
        fg.Cols.Item(7).Width = 0

    End Sub
    Private Sub Limpiar()
        Dim ds As New DataSet

        Me.dtpFecha.Value = Now
        Me.c1txtNoDoc.Value = 0
        Me.txtDui.Value = ""
        Me.txtNoSocio.Text = ""
        Me.c1txtNombreAsoc.Value = ""
        Me.c1txtObservaciones.Value = ""
        Me.c1txtMonto.Value = 0

        Me.btnAdd.Enabled = False
        Me.fg.DataSource = ds
        Me.dsDetalle.Clear()
        Me.txtDui.Focus()
        vCancela = False
        vDPF = False


        Me.c1txtMonto.Enabled = True
        Me.btBorrar.Enabled = True
        'Me.btSalir.Enabled = True
        Me.txtDui.Enabled = True
        pCodTransaccion = ""
        Me.btnImprimir.Enabled = False
        pCodTransferencia = ""
        Me.btNProcesar.Enabled = True

        ' Me.fgAnulaciones.Enabled = True
    End Sub



    Private Sub SumaDetalle()
        Dim pSum As Double, dr As DataRow, x As Integer
        x = 0
        For Each dr In dsDetalle.Tables(0).Rows
            x = x + 1
            pSum = pSum + dr("Valor")
        Next
        If x > 0 Then

            Me.c1txtMonto.Enabled = False
        Else

            Me.c1txtMonto.Enabled = True
        End If
        pSum = Me.c1txtMonto.Text - pSum
        Me.txtTotal.Text = "Pendiente: $" & pSum
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmTransferenciaManualCtaAhorros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAh As New wrAhorro.wsLibAhorro, oApp As New wrAdmin.wsLibAdmin
        'Me.txtResponsable.Text = sUsuario ' Me.Supervisor
        Me.dtpFecha.Value = oApp.Fecha
        dsDetalle = oAh.ObtenerDetalleTransferenciaVacio
        vCancela = False
        vDPF = False
    End Sub
    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Dim oAh As wrAhorro.wsLibAhorro, oAsoc As wrAsociados.wsLibAsoc
        Dim dr As DataRow, ds As New Data.DataSet

        Try
            oAh = New wrAhorro.wsLibAhorro
            oAsoc = New wrAsociados.wsLibAsoc

            ds = oAsoc.ConsultarAsociado("DUI,Nombres+' '+Apellido1+' '+Apellido2+' '+ApellidoCas as NombreAsociado,NoSocio", "Dui='" & Me.txtDui.Value & "'", "DUI", sUsuario, sPassword, sSucursal)
            If ds.Tables("Cat_Asociados").Rows.Count > 0 Then
                dr = ds.Tables("Cat_Asociados").Rows(0)
                Me.txtDui.Value = dr("Dui")
                Me.c1txtNombreAsoc.Value = dr("NombreAsociado")
                Me.txtNoSocio.Text = dr("NoSocio")
                llenarCbCuentas()
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sNomb, campos As String, var As Integer, corrDic As Integer
        Dim dr As DataRow, ds As New Data.DataSet
        Dim oAh As wrAhorro.wsLibAhorro, oAsoc As wrAsociados.wsLibAsoc
        Dim oCred As wrCredito.wsLibCred

        Try
            oAh = New wrAhorro.wsLibAhorro
            oCred = New wrCredito.wsLibCred
            oAsoc = New wrAsociados.wsLibAsoc

            campos = " DUI,Nombres+' '+Apellido1+' '+Apellido2+' '+ApellidoCas as NombreAsociado,"
            campos += "NoSocio,NIT,ISSS,LugarExtDUI,FechaExtDUI,NumPasaporte,EstadoIngreso,Fecha_Nac,Direccion "
            ds = oAsoc.ConsultarAsociado(campos, "", "DUI", sUsuario, sPassword, sSucursal)
            frm.Text = "Buscar Asociados"
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim <> "" Then
                Me.txtDui.Value = IIf(IsDBNull(frm.Resultado.Trim), "", frm.Resultado.Trim)
                sNomb = IIf(IsDBNull(frm.Resultado2.Trim), "", frm.Resultado2.Trim)
                Me.c1txtNombreAsoc.Value = sNomb
                Me.txtNoSocio.Text = IIf(IsDBNull(frm.Resultado3.Trim), "", frm.Resultado3.Trim)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region




    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub







    Private Sub CargaDatosCuentaCancelada()

        Dim ds As New DataSet, oAh As New wrAhorro.wsLibAhorro, dr As DataRow
        ds = oAh.ConsultarCtasAhorroDUI("a.CodTipoAhorro as Codigo,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.SaldoDisponible_CuentaAhorro as Saldo,b.IdCuenta as Cuenta_Contable,Pignorado", "a.Nocuenta='" & cbCuenta.SelectedValue & "'", "", sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count > 0 Then
            dr = ds.Tables(0).Rows(0)
            pSaldoOrigen = dr("Saldo")
            Me.c1txtMonto.Value = pSaldoOrigen
        End If

        Me.c1txtMonto.Enabled = False
        Me.btBorrar.Enabled = False
        'Me.btSalir.Enabled = False
        Me.txtDui.Enabled = False
        ' Me.fgAnulaciones.Enabled = False
        pCodTransaccion = "CAN"

    End Sub




    Private Sub frmTransferenciaManualCtaAhorros_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If vCancela = True Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txtDui_LostFocus(sender, e)
        End If
    End Sub

    Private Function VerificaPrestamo() As Boolean
        Dim pSum As Double, dr As DataRow

        For Each dr In dsDetalle.Tables(0).Rows
            If dr("TipoCuenta") = "P" Then
                Return True
            End If
        Next
        Return False
    End Function



    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim ds As New DataSet
            Dim oCaja As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
            If VerificaPrestamo() = False Then
                ds = oCaja.NotaCargo(pCodTransferencia, Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 56, 0)
                ofrm.ShowDialog()
            Else
                ds = oCaja.NotaCargoPrestamo(pCodTransferencia, Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 58, 0)
                ofrm.ShowDialog()
            End If
            Limpiar()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        Limpiar()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btNProcesar.Click

        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim dsDestino As New DataSet

        'Dim saldoCapDB, montoCtaDest

        Dim oAhorro As New wrAhorro.wsLibAhorro, oAsoc As New wrAsociados.wsLibAsoc
        Dim CamposValores As String, pFiltro As String, noCuentaDestino As String, noCuentaOrigen As String, pResponse As String
        Dim saldoCtaDispoDB As Double, saldoCtaDB As Double, saldoAnterior As Double, montoCtaOrig As Double, saldoActual As Double, pMontoParam As Double
        Dim dsOrigen As New DataSet, dr As DataRow, dsAhorro As New DataSet, drAhorro As DataRow, dsPar As New DataSet, drPar As DataRow

        Try
            'If Math.Round(pSaldoOrigen, 2) >= Math.Round(CDbl(Me.c1txtMonto.Text), 2) Then
            'Else
            '    MessageBox.Show("El Monto de Retiro es mayor que el Saldo disponible.", "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If



            If vCancela = False Then
                dsAhorro = oAhorro.ConsultarParametros("*", "CodTipoAhorro='" & Me.txtCodTipo.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                If dsAhorro.Tables("AhParametros").Rows.Count > 0 Then
                    drAhorro = dsAhorro.Tables("AhParametros").Rows(0)
                    If Math.Round(drAhorro("MontoSaldoMinimo"), 2) > Math.Round(pSaldoOrigen, 2) - Math.Round(CDbl(Me.c1txtMonto.Text), 2) Then
                        If MessageBox.Show("El Saldo mínimo debe ser de " & Math.Round(drAhorro("MontoSaldoMinimo"), 2) & ". ¿Desea cancelar la cuenta?", "Cancelación de Cuentas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                            Exit Sub
                        Else
                            If pPignorado = "S" Then
                                MessageBox.Show("La cuenta se encuentra pignorada, no se puede cancelar.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If

                            dsPar = oAsoc.ConsultarParametros("*", "", "SalarioMinimo", sUsuario, sPassword, sSucursal)
                            If dsPar.Tables(0).Rows.Count > 0 Then
                                drPar = dsPar.Tables(0).Rows(0)
                                pMontoParam = IIf(IsDBNull(drPar("MontoDPF")), 0, drPar("MontoDPF"))
                            Else
                                pMontoParam = 0
                            End If

                            Dim ofrmAut As New frmMsAutorizacion
                            ofrmAut.TipoPermiso = "P"
                            ofrmAut.NumPrograma = "AHG010"
                            ofrmAut.ShowDialog()
                            If ofrmAut.Autoriza = True Then
                                'Cancelar la Cuenta
                                Dim ofrmCC As New frmMsAhCancelaCuenta
                                If Me.txtCodTipo.Text.Trim.Substring(0, 1) = "6" Then
                                    If pSaldoOrigen >= pMontoParam Then
                                        ofrmCC.vAplicaAut = True
                                    Else
                                        ofrmCC.vAplicaAut = False
                                    End If
                                Else
                                    ofrmCC.vAplicaAut = False
                                End If
                                ofrmCC.vCUsuario = ofrmAut.Usuario
                                ofrmCC.vCPassword = ofrmAut.Password
                                ofrmCC.NoCaja = "0"
                                ofrmCC.CodCajero = "0"
                                ofrmCC.NoCuenta = cbCuenta.SelectedValue
                                ofrmCC.CodTipoAhorro = Me.txtCodTipo.Text.Trim
                                ofrmCC.ShowDialog()
                                If ofrmCC.Autorizado = False Then
                                    MessageBox.Show("La cuenta no se ha cancelado, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                Else
                                    vCancela = True
                                    CargaDatosCuentaCancelada()
                                    MessageBox.Show("Cuenta cancelada.", "Cancelación de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Exit Sub
                                End If
                                ofrmAut.Autoriza = False
                                ofrmAut.Dispose()
                            Else
                                ofrmAut.Dispose()
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
            If vCancela = False Then pCodTransaccion = "RET"
            'pCodTransferencia = oAhorro.ObtenerCorrelativoTransferencia("CodTransferencia", "3", sSupervisor, pPassword)
            pCodTransferencia = oAhorro.ObtenerCorrelativoTransferencia("CodTransferencia", "3", "(MONTH(Fecha) = '" & Me.dtpFecha.Value.Month & "')  AND (YEAR(Fecha) = " & Me.dtpFecha.Value.Year & ")", sUsuario, sPassword, sSucursal)
            pResponse = oAhorro.TransferenciaCuentas(Me.c1txtNoDoc.Text.Trim, "3", Me.dtpFecha.Value, Me.txtDui.Value, Me.txtNoSocio.Text.Trim, sUsuario, CDbl(Me.c1txtMonto.Text), Me.c1txtObservaciones.Text.Trim, cbCuenta.SelectedValue, pCodTransferencia, cbCuentaContable.SelectedValue, Me.txtCodTipo.Text.Trim, dsDetalle, pCodTransaccion, "M", Me.c1txtNombreAsoc.Text.Trim, "0", sUsuario, sPassword, sSucursal, cbCentroCosto.SelectedValue)
            If pResponse <> "" Then
                MessageBox.Show(pResponse, "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                MessageBox.Show("Transferencia realizada.", "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btnImprimir.Enabled = True
                Me.btNProcesar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub MetroButton3_Click_1(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If fg.Row > 0 Then
                Dim pNocuenta As String
                pNocuenta = Trim(fg.Item(fg.Row, "NoCuenta")).ToString
                If MessageBox.Show("¿Está seguro que desea eliminar la Cuenta " & pNocuenta & "?", "Transferencia Cuentas Auxiliares", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAh.EliminarDetalleTransferencia(dsDetalle, fg.Item(fg.Row, "Numero"))
                    dsDetalle.Clear()
                    dsDetalle = ds.Copy
                    fg.DataSource = dsDetalle.Tables(0)
                    Encabezado()
                    SumaDetalle()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click_2(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMsAhDetTransferencias
            ofrm.NoCuenta = cbCuenta.SelectedValue
            ofrm.Dui = Me.txtDui.Value
            ofrm.Fecha = Me.dtpFecha.Value
            ofrm.FrmT = Me
            If vDPF = True Then ofrm.c1txtMonto.Value = Me.c1txtMonto.Value
            ofrm.ShowDialog()
            fg.DataSource = dsDetalle.Tables(0)
            fg.Refresh()
            Encabezado()
            SumaDetalle()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click_2(sender As Object, e As EventArgs)
        Try
            If fg.Row > 0 Then
                Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
                ds = oAh.ModificarDetalleTransferencia(dsDetalle, fg.Item(fg.Row, "Numero"), Trim(fg.Item(fg.Row, "NoCuenta")).ToString, fg.Item(fg.Row, "Valor"), fg.Item(fg.Row, "TipoMovimiento"), fg.Item(fg.Row, "TipoCuenta"), fg.Item(fg.Row, "IdCuenta"), fg.Item(fg.Row, "Fecha"))
                dsDetalle.Clear()
                dsDetalle = ds.Copy
                fg.DataSource = dsDetalle.Tables(0)
                Encabezado()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub







    Private Sub frmTransferenciaManualCtaAhorros_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cbCuenta_Validated(sender As Object, e As EventArgs) Handles cbCuenta.Validated
        llenarDatosContables(cbCuenta.SelectedValue)
    End Sub

    Private Sub chkDPF_CheckedChanged(sender As Object, e As EventArgs) Handles chkDPF.CheckedChanged
        llenarCbCuentas()
    End Sub

    Private Sub c1txtMonto_Validated(sender As Object, e As EventArgs) Handles c1txtMonto.Validated
        Try
            If c1txtMonto.Value > 0 Then
                Dim dts As New DataSet
                Dim disponible As Double
                dts = ahorro.ConsultarCtasAhorroDUI("SaldoDisponible_CuentaAhorro ", " nocuenta = '" & cbCuenta.SelectedValue.ToString.Trim & "' ", "", sUsuario, sPassword, sSucursal)
                If dts.Tables.Count > 0 Then
                    If dts.Tables(0).Rows.Count > 0 Then
                        disponible = dts.Tables(0).Rows(0).Item(0)
                        If disponible < c1txtMonto.Value Then
                            c1txtMonto.Value = disponible
                            MetroFramework.MetroMessageBox.Show(Me, "El monto ingresado es superior al saldo disponible de la cuenta.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Error al recuperar información de la cuenta origen, comunicarse con el administrador de sistema.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Error al recuperar información de la cuenta origen, comunicarse con el administrador de sistema.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Error al recuperar información de la cuenta origen, comunicarse con el administrador de sistema.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub
End Class