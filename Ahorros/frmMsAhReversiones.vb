Public Class frmMsAhReversiones
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ahorro As New wrAhorro.wsLibAhorro
    Dim pCodReversion As String, pTipoOper As String, pTipoDeposito As String, pReimpresion As Boolean
    Friend WithEvents btnReimpresion As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbNoCuenta As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btProcesar As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtNoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents rbCargo As System.Windows.Forms.RadioButton
    Friend WithEvents rbAbono As System.Windows.Forms.RadioButton
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodReversion As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents dtpDia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents rbCaja As System.Windows.Forms.RadioButton
    Friend WithEvents rbTransferencia As System.Windows.Forms.RadioButton
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents rbReversion As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.rbReversion = New System.Windows.Forms.RadioButton()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.rbTransferencia = New System.Windows.Forms.RadioButton()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.rbCaja = New System.Windows.Forms.RadioButton()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.dtpDia = New System.Windows.Forms.DateTimePicker()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtNoDocumento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodReversion = New System.Windows.Forms.TextBox()
        Me.rbCargo = New System.Windows.Forms.RadioButton()
        Me.rbAbono = New System.Windows.Forms.RadioButton()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.btnReimpresion = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.btProcesar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.cbNoCuenta = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOrigen
        '
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Location = New System.Drawing.Point(877, 72)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(9, 22)
        Me.txtOrigen.TabIndex = 175
        Me.txtOrigen.Visible = False
        '
        'rbReversion
        '
        Me.rbReversion.ForeColor = System.Drawing.Color.Black
        Me.rbReversion.Location = New System.Drawing.Point(272, 103)
        Me.rbReversion.Name = "rbReversion"
        Me.rbReversion.Size = New System.Drawing.Size(93, 28)
        Me.rbReversion.TabIndex = 2
        Me.rbReversion.Text = "&Reversión"
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(886, 72)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(10, 22)
        Me.txtTipo.TabIndex = 174
        Me.txtTipo.Visible = False
        '
        'rbTransferencia
        '
        Me.rbTransferencia.ForeColor = System.Drawing.Color.Black
        Me.rbTransferencia.Location = New System.Drawing.Point(371, 103)
        Me.rbTransferencia.Name = "rbTransferencia"
        Me.rbTransferencia.Size = New System.Drawing.Size(125, 28)
        Me.rbTransferencia.TabIndex = 1
        Me.rbTransferencia.Text = "&Transferencia"
        '
        'txtAnio
        '
        Me.txtAnio.Enabled = False
        Me.txtAnio.Location = New System.Drawing.Point(896, 72)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(10, 22)
        Me.txtAnio.TabIndex = 173
        Me.txtAnio.Visible = False
        '
        'rbCaja
        '
        Me.rbCaja.Checked = True
        Me.rbCaja.ForeColor = System.Drawing.Color.Black
        Me.rbCaja.Location = New System.Drawing.Point(189, 103)
        Me.rbCaja.Name = "rbCaja"
        Me.rbCaja.Size = New System.Drawing.Size(68, 28)
        Me.rbCaja.TabIndex = 0
        Me.rbCaja.TabStop = True
        Me.rbCaja.Text = "Ca&ja"
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.Enabled = False
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(1273, 36)
        Me.txtCodTipoAhorro.MaxLength = 25
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(10, 22)
        Me.txtCodTipoAhorro.TabIndex = 171
        Me.txtCodTipoAhorro.Visible = False
        '
        'dtpDia
        '
        Me.dtpDia.Location = New System.Drawing.Point(145, 198)
        Me.dtpDia.Name = "dtpDia"
        Me.dtpDia.Size = New System.Drawing.Size(520, 22)
        Me.dtpDia.TabIndex = 5
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(145, 139)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(201, 20)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(452, 140)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(213, 23)
        Me.txtNoSocio.TabIndex = 168
        Me.txtNoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.Color.Black
        Me.txtAsociado.Location = New System.Drawing.Point(145, 167)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(520, 25)
        Me.txtAsociado.TabIndex = 4
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(145, 294)
        Me.txtObs.MaxLength = 255
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(520, 135)
        Me.txtObs.TabIndex = 9
        '
        'txtNoDocumento
        '
        Me.txtNoDocumento.BackColor = System.Drawing.Color.White
        Me.txtNoDocumento.Location = New System.Drawing.Point(145, 262)
        Me.txtNoDocumento.MaxLength = 20
        Me.txtNoDocumento.Name = "txtNoDocumento"
        Me.txtNoDocumento.Size = New System.Drawing.Size(201, 22)
        Me.txtNoDocumento.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Enabled = False
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(521, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 18)
        Me.Label9.TabIndex = 173
        Me.Label9.Text = "Fecha de Movimiento:"
        Me.Label9.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(394, 40)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(106, 22)
        Me.dtpFecha.TabIndex = 2
        Me.dtpFecha.Visible = False
        '
        'Label4
        '
        Me.Label4.Enabled = False
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(698, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 18)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Código de la Transacción:"
        Me.Label4.Visible = False
        '
        'txtCodReversion
        '
        Me.txtCodReversion.Enabled = False
        Me.txtCodReversion.Location = New System.Drawing.Point(877, 44)
        Me.txtCodReversion.MaxLength = 25
        Me.txtCodReversion.Name = "txtCodReversion"
        Me.txtCodReversion.Size = New System.Drawing.Size(216, 22)
        Me.txtCodReversion.TabIndex = 3
        Me.txtCodReversion.Visible = False
        '
        'rbCargo
        '
        Me.rbCargo.ForeColor = System.Drawing.Color.Black
        Me.rbCargo.Location = New System.Drawing.Point(272, 79)
        Me.rbCargo.Name = "rbCargo"
        Me.rbCargo.Size = New System.Drawing.Size(68, 19)
        Me.rbCargo.TabIndex = 1
        Me.rbCargo.Text = "&Cargo"
        '
        'rbAbono
        '
        Me.rbAbono.Checked = True
        Me.rbAbono.ForeColor = System.Drawing.Color.Black
        Me.rbAbono.Location = New System.Drawing.Point(189, 79)
        Me.rbAbono.Name = "rbAbono"
        Me.rbAbono.Size = New System.Drawing.Size(77, 18)
        Me.rbAbono.TabIndex = 0
        Me.rbAbono.TabStop = True
        Me.rbAbono.Text = "&Abono"
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(464, 262)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.Size = New System.Drawing.Size(201, 23)
        Me.C1NEMonto.TabIndex = 8
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'btnReimpresion
        '
        Me.btnReimpresion.Location = New System.Drawing.Point(495, 435)
        Me.btnReimpresion.Name = "btnReimpresion"
        Me.btnReimpresion.Size = New System.Drawing.Size(170, 32)
        Me.btnReimpresion.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnReimpresion.TabIndex = 212
        Me.btnReimpresion.Text = "Imprimir Nuevamente"
        Me.btnReimpresion.UseSelectable = True
        Me.btnReimpresion.UseStyleColors = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(392, 435)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 32)
        Me.btnImprimir.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir.TabIndex = 213
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseSelectable = True
        Me.btnImprimir.UseStyleColors = True
        '
        'btProcesar
        '
        Me.btProcesar.Location = New System.Drawing.Point(289, 435)
        Me.btProcesar.Name = "btProcesar"
        Me.btProcesar.Size = New System.Drawing.Size(96, 32)
        Me.btProcesar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar.TabIndex = 214
        Me.btProcesar.Text = "Procesar"
        Me.btProcesar.UseSelectable = True
        Me.btProcesar.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 76)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(108, 20)
        Me.MetroLabel1.TabIndex = 215
        Me.MetroLabel1.Text = "Tipo Operación:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 103)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(151, 20)
        Me.MetroLabel2.TabIndex = 216
        Me.MetroLabel2.Text = "Origen de Transacción:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 138)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(35, 20)
        Me.MetroLabel3.TabIndex = 217
        Me.MetroLabel3.Text = "DUI:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(352, 138)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(94, 20)
        Me.MetroLabel4.TabIndex = 218
        Me.MetroLabel4.Text = "No. Asociado:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 164)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(68, 20)
        Me.MetroLabel5.TabIndex = 219
        Me.MetroLabel5.Text = "Asociado:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 195)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(116, 20)
        Me.MetroLabel6.TabIndex = 220
        Me.MetroLabel6.Text = "Fecha Aplicación:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 226)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(82, 20)
        Me.MetroLabel7.TabIndex = 221
        Me.MetroLabel7.Text = "No. Cuenta:"
        '
        'cbNoCuenta
        '
        Me.cbNoCuenta.FormattingEnabled = True
        Me.cbNoCuenta.ItemHeight = 24
        Me.cbNoCuenta.Location = New System.Drawing.Point(145, 226)
        Me.cbNoCuenta.Name = "cbNoCuenta"
        Me.cbNoCuenta.Size = New System.Drawing.Size(520, 30)
        Me.cbNoCuenta.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbNoCuenta.TabIndex = 222
        Me.cbNoCuenta.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(23, 262)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(111, 20)
        Me.MetroLabel8.TabIndex = 223
        Me.MetroLabel8.Text = "No. Documento:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(352, 264)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(89, 20)
        Me.MetroLabel9.TabIndex = 224
        Me.MetroLabel9.Text = "Valor Aplicar:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(23, 294)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(91, 20)
        Me.MetroLabel10.TabIndex = 225
        Me.MetroLabel10.Text = "Observación:"
        '
        'frmMsAhReversiones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(691, 524)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.cbNoCuenta)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtCodTipoAhorro)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.dtpDia)
        Me.Controls.Add(Me.C1NEMonto)
        Me.Controls.Add(Me.txtNoDocumento)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.rbReversion)
        Me.Controls.Add(Me.rbTransferencia)
        Me.Controls.Add(Me.txtCodReversion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rbCaja)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btProcesar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnReimpresion)
        Me.Controls.Add(Me.rbCargo)
        Me.Controls.Add(Me.rbAbono)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhReversiones"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Aplicaciones Valor Fecha"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"

    Public Property TipoDeposito() As String
        Get
            Return pTipoDeposito
        End Get
        Set(ByVal Value As String)
            pTipoDeposito = Value
        End Set
    End Property

#End Region

    Private Sub frmMsAhReversiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.pTipoOper = "A"
        Me.txtOrigen.Text = "C"
        Me.dtpDia.Value = Now
        Me.dtpFecha.Value = Now
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
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = dr("NoSocio")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub
    Protected Sub llenarCuentas()
        Try
            Dim dts As New DataSet
            dts = ahorro.ConsultarCuentaAhorro("Nocuenta", "Dui='" & Me.txtDui.Value & "' and saldo_Cuentaahorro > 0  and estado not in ('C',D) ", "NoCuenta", sUsuario, sPassword, sSucursal)
            cbNoCuenta.DataSource = dts.Tables(0)
            cbNoCuenta.DisplayMember = "NoCuenta"
            cbNoCuenta.ValueMember = "NoCuenta"
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Private Sub txtCodCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    'Dim frm As New frmAGenerico, Fila As DataRowCollection, sTexto As String

    '    frm.Text = "Buscar Cuenta"
    '    Dim oAh As New wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
    '    Try
    '        If pTipoDeposito = "0" Then 'Ahorros
    '            ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro", "Dui='" & Me.txtDui.Value & "' and left(CodTipoAhorro,1)<>'1'", "NoCuenta", sUsuario, sPassword, sSucursal)
    '        ElseIf pTipoDeposito = "1" Then 'Aportación
    '            ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro", "Dui='" & Me.txtDui.Value & "' and left(CodTipoAhorro,1)='1'", "NoCuenta", sUsuario, sPassword, sSucursal)
    '        End If
    '        frm.Datos = ds
    '        frm.C1fgrdResultado.Cols.Item(5).Format = "##0.00"
    '        frm.ColSeleccion = 0
    '        frm.RefrescarGrid()
    '        frm.ShowDialog()
    '        If frm.Resultado.Trim = "" Then
    '        ElseIf frm.Resultado.Trim <> "" Then
    '            sTexto = frm.Resultado3.Trim
    '            Me.txtCodCuenta.Text = sTexto
    '            Me.txtCodTipoAhorro.Text = frm.Resultado2.Trim
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbAbono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAbono.CheckedChanged
        Try
            Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
            If Me.rbAbono.Checked = True Then
                Me.pTipoOper = "A"
                'Me.gbOrigen.Enabled = False
                Me.txtNoDocumento.ReadOnly = False
                Me.dtpDia.Enabled = True
                Me.C1NEMonto.Enabled = True
            ElseIf Me.rbCargo.Checked = True Then
                Me.pTipoOper = "C"
                ' Me.gbOrigen.Enabled = True
                Me.txtNoDocumento.ReadOnly = True
                Me.dtpDia.Enabled = False
                Me.C1NEMonto.Enabled = False
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbCargo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCargo.CheckedChanged
        Try
            Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
            If Me.rbAbono.Checked = True Then
                Me.pTipoOper = "A"
                '  Me.gbOrigen.Enabled = False
                Me.txtNoDocumento.ReadOnly = False
                Me.dtpDia.Enabled = True
                Me.C1NEMonto.Enabled = True
            ElseIf Me.rbCargo.Checked = True Then
                Me.pTipoOper = "C"
                '  Me.gbOrigen.Enabled = True
                Me.txtNoDocumento.ReadOnly = True
                Me.dtpDia.Enabled = False
                Me.C1NEMonto.Enabled = False
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoDocumento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoDocumento.DoubleClick

        If Me.rbAbono.Checked = True Then Exit Sub

        Dim frm As New frmAGenerico, oAhorro As New wrAhorro.wsLibAhorro
        Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, dr As DataRow, pFecha As Date


        frm.Text = "Buscar Documento"

        Try
            If Me.rbCaja.Checked = True Then
                '  If Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1) = "1" And pTipoDeposito = "1" Then 'Aportación
                ds = oCaja.ConsultarEncabezadoDetalleItemFacturas("a.IdMovimiento,a.Annio,a.Tipo,a.Fec_Mov as Fecha,b.SubTotal_SIva as Total_Item,a.Vta_Total as Total_Documento,b.Descripcion,b.NoCuenta", "(c.Tipo_Item='A' and a.Dui='" & Me.txtDui.Value & "' and c.IdRubro='2' and Estado_Pr='A' and Estado_Ap<>'A') or (b.NoCuenta='" & cbNoCuenta.SelectedValue & "' and a.Estado<>'A' and b.Total_Vta=0)", "cast(a.IdMovimiento as int) asc", sUsuario, sPassword, sSucursal)
                ' ElseIf pTipoDeposito = "0" Then 'Ahorro
                ' ds = oCaja.ConsultarEncabezadoDetalleItemFacturas("a.IdMovimiento,a.Annio,a.Tipo,a.Fec_Mov as Fecha,b.SubTotal_SIva as Total_Item,a.Vta_Total as Total_Documento,b.Descripcion,b.NoCuenta", "(c.Tipo_Item='H' and a.Dui='" & Me.txtDui.Value & "' and c.IdRubro='2' and Estado_Pr='A' and Estado_Ap='A' and Estado_Ah<>'A') or (b.NoCuenta='" & Me.txtCodCuenta.Text.Trim & "' and a.Estado<>'A' and b.Total_Vta=0)", "cast(a.IdMovimiento as int) asc", sUsuario, sPassword, sSucursal)
                'End If
                frm.Datos = ds
                frm.ColSeleccion = 0
                frm.RefrescarGrid()
                frm.ShowDialog()
                If frm.Resultado.Trim = "" Then
                ElseIf frm.Resultado.Trim <> "" Then
                    pFecha = CDate(frm.Resultado4.Trim)
                    Me.txtNoDocumento.Text = frm.Resultado.Trim
                    Me.txtAnio.Text = frm.Resultado2.Trim
                    Me.txtTipo.Text = frm.Resultado3.Trim
                    If cbNoCuenta.SelectedValue.ToString.Equals(frm.Resultado8.Trim) = True Then 'Documento de esta cuenta
                        Me.C1NEMonto.Value = frm.Resultado6.Trim
                    Else 'Documento de préstamo
                        Me.C1NEMonto.Value = frm.Resultado5.Trim
                    End If
                    Me.txtOrigen.Text = "C"
                    Me.dtpDia.Value = pFecha
                End If
            ElseIf Me.rbTransferencia.Checked = True Then
                ds = oAhorro.ConsultarTransferencia("a.CodTransferencia as No_Doc,a.Fecha,b.Valor as Monto,a.Observacion", "b.NoCuenta='" & cbNoCuenta.SelectedValue & "' and a.Estado='N'", "a.Fecha desc", "3", sUsuario, sPassword, sSucursal)
                frm.Datos = ds
                frm.ColSeleccion = 0
                frm.RefrescarGrid()
                frm.ShowDialog()
                If frm.Resultado.Trim = "" Then
                ElseIf frm.Resultado.Trim <> "" Then
                    pFecha = CDate(frm.Resultado2.Trim)
                    Me.txtNoDocumento.Text = frm.Resultado.Trim
                    Me.txtAnio.Text = 0
                    Me.txtTipo.Text = ""
                    Me.txtOrigen.Text = "T"
                    Me.C1NEMonto.Value = frm.Resultado3.Trim
                    Me.dtpDia.Value = pFecha
                End If
            ElseIf Me.rbReversion.Checked = True Then
                Me.txtOrigen.Text = "R"
            End If
        Catch ex As Exception
            MessageBox.Show("System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Dim sTexto As String

        If Me.txtDui.Text = "________-_" Then
            Exit Sub
        End If

        If Me.txtDui.Value Is DBNull.Value Then Exit Sub

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Dim oAh As New wrAhorro.wsLibAhorro
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
                    llenarCuentas()
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Limpiar()
        Me.txtDui.Text = ""
        Me.txtAsociado.Text = ""
        Me.txtNoSocio.Text = ""
        Me.txtCodTipoAhorro.Text = ""
        cbNoCuenta.DataSource = Nothing
        'Me.txtCodCuenta.Text = ""
        Me.txtNoDocumento.Text = ""
        Me.C1NEMonto.Value = 0
        Me.txtObs.Text = ""
        Me.txtCodReversion.Text = ""
        Me.txtAnio.Text = ""
        Me.txtTipo.Text = ""
        Me.dtpDia.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnReimpresion.Click
        Try
            Me.btnImprimir.Enabled = True
            Me.btProcesar.Enabled = False
            pReimpresion = True
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If Me.txtCodReversion.Text.Trim = "" Then Exit Sub
            Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
            ds = oAhorro.Comp_Reversiones_Ahorros(Me.txtCodReversion.Text.Trim, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 116, 0)
            ofrm.ShowDialog()
            Limpiar()
            Me.btProcesar.Enabled = True
            Me.btnImprimir.Enabled = False

            If pReimpresion = True Then
                Me.btnImprimir.Enabled = False
                Me.btProcesar.Enabled = True
                pReimpresion = False
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btProcesar.Click
        Try
            Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
            Me.Cursor = Cursors.WaitCursor
            If Val(Me.C1NEMonto.Value) = 0 Or Trim(Me.txtNoDocumento.Text) = "" Then Exit Sub
            If Me.pTipoOper.Trim = "" Then Exit Sub
            pCodReversion = "RM" & Me.pTipoOper & Format(Month(dtpDia.Value.Date), "00") & Year(dtpDia.Value.Date) & oAhorro.CorrelativoAhReversion(sUsuario, sPassword, sSucursal)
            Me.txtCodReversion.Text = pCodReversion
            If Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1) = "1" And pTipoDeposito = "1" Then 'Aportación
                oAhorro.ReversionAportaciones(pCodReversion, cbNoCuenta.SelectedValue, Me.txtCodTipoAhorro.Text.Trim, dtpDia.Value.Date, Me.pTipoOper, Val(Me.C1NEMonto.Value), Trim(Me.txtNoDocumento.Text), IIf(Me.txtAnio.Text.Trim = "", 0, Me.txtAnio.Text.Trim), Me.txtTipo.Text.Trim, Me.txtOrigen.Text.Trim, txtObs.Text.Trim, sUsuario, sPassword, sSucursal)
            ElseIf pTipoDeposito = "0" Then 'Ahorro
                oAhorro.ReversionAhorros(pCodReversion, cbNoCuenta.SelectedValue, Me.txtCodTipoAhorro.Text.Trim, dtpDia.Value.Date, Me.pTipoOper, Val(Me.C1NEMonto.Value), Trim(Me.txtNoDocumento.Text), IIf(Me.txtAnio.Text.Trim = "", 0, Me.txtAnio.Text.Trim), Me.txtTipo.Text.Trim, Me.txtOrigen.Text.Trim, txtObs.Text.Trim, sUsuario, sPassword, sSucursal)
            End If
            Me.Cursor = Cursors.Default
            MessageBox.Show("Aplicación Valor / Fecha procesada con éxito.", "Aplicaciones Valor Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btnImprimir.Enabled = True
            Me.btProcesar.Enabled = False
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbReversion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbReversion.CheckedChanged
        If Me.rbReversion.Checked = True Then
            Me.txtNoDocumento.ReadOnly = False
            Me.dtpDia.Enabled = True
            Me.C1NEMonto.Enabled = True
        Else
            Me.txtNoDocumento.ReadOnly = True
            Me.dtpDia.Enabled = False
            Me.C1NEMonto.Enabled = False
        End If
    End Sub

    Private Sub btnReimpresion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbNoCuenta_Validated(sender As Object, e As EventArgs) Handles cbNoCuenta.Validated

        Dim ds As New Data.DataSet("Ahorro"), dr As DataRow
        Try
            ds = ahorro.ConsultarCuentaAhorro("CodTipoAhorro", "NoCuenta='" & cbNoCuenta.SelectedValue & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtCodTipoAhorro.Text = dr("CodTipoAhorro")
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsAhReversiones_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class