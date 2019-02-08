Public Class frmMsAhReversiones
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Dim pCodReversion As String, pTipoOper As String, pTipoDeposito As String, pReimpresion As Boolean
    Friend WithEvents btnReimpresion As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCargo As System.Windows.Forms.RadioButton
    Friend WithEvents rbAbono As System.Windows.Forms.RadioButton
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodReversion As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents dtpDia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents rbCaja As System.Windows.Forms.RadioButton
    Friend WithEvents rbTransferencia As System.Windows.Forms.RadioButton
    Friend WithEvents gbOrigen As System.Windows.Forms.GroupBox
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents rbReversion As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbOrigen = New System.Windows.Forms.GroupBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.rbReversion = New System.Windows.Forms.RadioButton()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.rbTransferencia = New System.Windows.Forms.RadioButton()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.rbCaja = New System.Windows.Forms.RadioButton()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.dtpDia = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoDocumento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodReversion = New System.Windows.Forms.TextBox()
        Me.rbCargo = New System.Windows.Forms.RadioButton()
        Me.rbAbono = New System.Windows.Forms.RadioButton()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodCuenta = New System.Windows.Forms.TextBox()
        Me.btnReimpresion = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.btProcesar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.gbOrigen.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.gbOrigen)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.dtpDia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtAsociado)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNoDocumento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.C1NEMonto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodCuenta)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 335)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'gbOrigen
        '
        Me.gbOrigen.Controls.Add(Me.txtOrigen)
        Me.gbOrigen.Controls.Add(Me.rbReversion)
        Me.gbOrigen.Controls.Add(Me.txtTipo)
        Me.gbOrigen.Controls.Add(Me.rbTransferencia)
        Me.gbOrigen.Controls.Add(Me.txtAnio)
        Me.gbOrigen.Controls.Add(Me.rbCaja)
        Me.gbOrigen.Enabled = False
        Me.gbOrigen.ForeColor = System.Drawing.Color.Green
        Me.gbOrigen.Location = New System.Drawing.Point(16, 84)
        Me.gbOrigen.Name = "gbOrigen"
        Me.gbOrigen.Size = New System.Drawing.Size(562, 44)
        Me.gbOrigen.TabIndex = 1
        Me.gbOrigen.TabStop = False
        Me.gbOrigen.Text = "Origen del documento:"
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(284, 16)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(8, 20)
        Me.txtOrigen.TabIndex = 175
        Me.txtOrigen.Visible = False
        '
        'rbReversion
        '
        Me.rbReversion.ForeColor = System.Drawing.Color.Black
        Me.rbReversion.Location = New System.Drawing.Point(88, 16)
        Me.rbReversion.Name = "rbReversion"
        Me.rbReversion.Size = New System.Drawing.Size(80, 24)
        Me.rbReversion.TabIndex = 2
        Me.rbReversion.Text = "&Reversión"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(292, 16)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(8, 20)
        Me.txtTipo.TabIndex = 174
        Me.txtTipo.Visible = False
        '
        'rbTransferencia
        '
        Me.rbTransferencia.ForeColor = System.Drawing.Color.Black
        Me.rbTransferencia.Location = New System.Drawing.Point(184, 16)
        Me.rbTransferencia.Name = "rbTransferencia"
        Me.rbTransferencia.Size = New System.Drawing.Size(104, 24)
        Me.rbTransferencia.TabIndex = 1
        Me.rbTransferencia.Text = "&Transferencia"
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(300, 16)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(8, 20)
        Me.txtAnio.TabIndex = 173
        Me.txtAnio.Visible = False
        '
        'rbCaja
        '
        Me.rbCaja.Checked = True
        Me.rbCaja.ForeColor = System.Drawing.Color.Black
        Me.rbCaja.Location = New System.Drawing.Point(6, 16)
        Me.rbCaja.Name = "rbCaja"
        Me.rbCaja.Size = New System.Drawing.Size(104, 24)
        Me.rbCaja.TabIndex = 0
        Me.rbCaja.TabStop = True
        Me.rbCaja.Text = "Ca&ja"
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(316, 138)
        Me.txtCodTipoAhorro.MaxLength = 25
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(8, 20)
        Me.txtCodTipoAhorro.TabIndex = 171
        Me.txtCodTipoAhorro.Visible = False
        '
        'dtpDia
        '
        Me.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDia.Location = New System.Drawing.Point(112, 187)
        Me.dtpDia.Name = "dtpDia"
        Me.dtpDia.Size = New System.Drawing.Size(169, 20)
        Me.dtpDia.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Fecha Documento:"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(112, 134)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(88, 20)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(13, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 169
        Me.Label14.Text = "DUI Asociado:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(492, 134)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(80, 20)
        Me.txtNoSocio.TabIndex = 168
        Me.txtNoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(412, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 167
        Me.Label7.Text = "No. Asociado:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(13, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 18)
        Me.Label8.TabIndex = 166
        Me.Label8.Text = "Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(112, 160)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(460, 21)
        Me.txtAsociado.TabIndex = 4
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(112, 239)
        Me.txtObs.MaxLength = 255
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(460, 82)
        Me.txtObs.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(13, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Observaciones:"
        '
        'txtNoDocumento
        '
        Me.txtNoDocumento.BackColor = System.Drawing.Color.White
        Me.txtNoDocumento.Location = New System.Drawing.Point(112, 213)
        Me.txtNoDocumento.MaxLength = 20
        Me.txtNoDocumento.Name = "txtNoDocumento"
        Me.txtNoDocumento.Size = New System.Drawing.Size(169, 20)
        Me.txtNoDocumento.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(13, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "No. Documento:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCodReversion)
        Me.GroupBox2.Controls.Add(Me.rbCargo)
        Me.GroupBox2.Controls.Add(Me.rbAbono)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(562, 70)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de operación:"
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 173
        Me.Label9.Text = "Fecha de Movimiento:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(132, 38)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(226, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Código de la Transacción:"
        '
        'txtCodReversion
        '
        Me.txtCodReversion.Location = New System.Drawing.Point(376, 38)
        Me.txtCodReversion.MaxLength = 25
        Me.txtCodReversion.Name = "txtCodReversion"
        Me.txtCodReversion.Size = New System.Drawing.Size(180, 20)
        Me.txtCodReversion.TabIndex = 3
        '
        'rbCargo
        '
        Me.rbCargo.ForeColor = System.Drawing.Color.Black
        Me.rbCargo.Location = New System.Drawing.Point(132, 16)
        Me.rbCargo.Name = "rbCargo"
        Me.rbCargo.Size = New System.Drawing.Size(56, 16)
        Me.rbCargo.TabIndex = 1
        Me.rbCargo.Text = "&Cargo"
        '
        'rbAbono
        '
        Me.rbAbono.Checked = True
        Me.rbAbono.ForeColor = System.Drawing.Color.Black
        Me.rbAbono.Location = New System.Drawing.Point(6, 19)
        Me.rbAbono.Name = "rbAbono"
        Me.rbAbono.Size = New System.Drawing.Size(64, 16)
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
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(403, 212)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.ShowDropDownButton = False
        Me.C1NEMonto.ShowUpDownButtons = False
        Me.C1NEMonto.Size = New System.Drawing.Size(169, 21)
        Me.C1NEMonto.TabIndex = 8
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(287, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Monto:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(287, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Código de Cuenta:"
        '
        'txtCodCuenta
        '
        Me.txtCodCuenta.Location = New System.Drawing.Point(403, 187)
        Me.txtCodCuenta.MaxLength = 25
        Me.txtCodCuenta.Name = "txtCodCuenta"
        Me.txtCodCuenta.Size = New System.Drawing.Size(169, 20)
        Me.txtCodCuenta.TabIndex = 6
        '
        'btnReimpresion
        '
        Me.btnReimpresion.Location = New System.Drawing.Point(465, 404)
        Me.btnReimpresion.Name = "btnReimpresion"
        Me.btnReimpresion.Size = New System.Drawing.Size(142, 28)
        Me.btnReimpresion.Style = MetroFramework.MetroColorStyle.Green
        Me.btnReimpresion.TabIndex = 212
        Me.btnReimpresion.Text = "Imprimir Nuevamente"
        Me.btnReimpresion.UseSelectable = True
        Me.btnReimpresion.UseStyleColors = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(379, 404)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(80, 28)
        Me.btnImprimir.Style = MetroFramework.MetroColorStyle.Green
        Me.btnImprimir.TabIndex = 213
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseSelectable = True
        Me.btnImprimir.UseStyleColors = True
        '
        'btProcesar
        '
        Me.btProcesar.Location = New System.Drawing.Point(293, 404)
        Me.btProcesar.Name = "btProcesar"
        Me.btProcesar.Size = New System.Drawing.Size(80, 28)
        Me.btProcesar.Style = MetroFramework.MetroColorStyle.Green
        Me.btProcesar.TabIndex = 214
        Me.btProcesar.Text = "Procesar"
        Me.btProcesar.UseSelectable = True
        Me.btProcesar.UseStyleColors = True
        '
        'frmMsAhReversiones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(630, 445)
        Me.Controls.Add(Me.btProcesar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnReimpresion)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhReversiones"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Aplicaciones Valor Fecha"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbOrigen.ResumeLayout(False)
        Me.gbOrigen.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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

    Private Sub txtCodCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCuenta.DoubleClick
        Dim frm As New frmAGenerico, Fila As DataRowCollection, sTexto As String

        frm.Text = "Buscar Cuenta"
        Dim oAh As New wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
        Try
            If pTipoDeposito = "0" Then 'Ahorros
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro", "Dui='" & Me.txtDui.Value & "' and left(CodTipoAhorro,1)<>'1'", "NoCuenta", sUsuario, sPassword, sSucursal)
            ElseIf pTipoDeposito = "1" Then 'Aportación
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro", "Dui='" & Me.txtDui.Value & "' and left(CodTipoAhorro,1)='1'", "NoCuenta", sUsuario, sPassword, sSucursal)
            End If
            frm.Datos = ds
            frm.C1fgrdResultado.Cols.Item(5).Format = "##0.00"
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado3.Trim
                Me.txtCodCuenta.Text = sTexto
                Me.txtCodTipoAhorro.Text = frm.Resultado2.Trim
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbAbono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAbono.CheckedChanged
        Try
            Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
            If Me.rbAbono.Checked = True Then
                Me.pTipoOper = "A"
                Me.gbOrigen.Enabled = False
                Me.txtNoDocumento.ReadOnly = False
                Me.dtpDia.Enabled = True
                Me.C1NEMonto.Enabled = True
            ElseIf Me.rbCargo.Checked = True Then
                Me.pTipoOper = "C"
                Me.gbOrigen.Enabled = True
                Me.txtNoDocumento.ReadOnly = True
                Me.dtpDia.Enabled = False
                Me.C1NEMonto.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbCargo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCargo.CheckedChanged
        Try
            Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
            If Me.rbAbono.Checked = True Then
                Me.pTipoOper = "A"
                Me.gbOrigen.Enabled = False
                Me.txtNoDocumento.ReadOnly = False
                Me.dtpDia.Enabled = True
                Me.C1NEMonto.Enabled = True
            ElseIf Me.rbCargo.Checked = True Then
                Me.pTipoOper = "C"
                Me.gbOrigen.Enabled = True
                Me.txtNoDocumento.ReadOnly = True
                Me.dtpDia.Enabled = False
                Me.C1NEMonto.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoDocumento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoDocumento.DoubleClick

        If Me.rbAbono.Checked = True Then Exit Sub

        Dim frm As New frmAGenerico, oAhorro As New wrAhorro.wsLibAhorro
        Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, dr As DataRow, pFecha As Date

        If Me.txtCodCuenta.Text.Trim = "" Then Exit Sub

        frm.Text = "Buscar Documento"

        Try
            If Me.rbCaja.Checked = True Then
                If Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1) = "1" And pTipoDeposito = "1" Then 'Aportación
                    ds = oCaja.ConsultarEncabezadoDetalleItemFacturas("a.IdMovimiento,a.Annio,a.Tipo,a.Fec_Mov as Fecha,b.SubTotal_SIva as Total_Item,a.Vta_Total as Total_Documento,b.Descripcion,b.NoCuenta", "(c.Tipo_Item='A' and a.Dui='" & Me.txtDui.Value & "' and c.IdRubro='2' and Estado_Pr='A' and Estado_Ap<>'A') or (b.NoCuenta='" & Me.txtCodCuenta.Text.Trim & "' and a.Estado<>'A' and b.Total_Vta=0)", "cast(a.IdMovimiento as int) asc", sUsuario, sPassword, sSucursal)
                ElseIf pTipoDeposito = "0" Then 'Ahorro
                    ds = oCaja.ConsultarEncabezadoDetalleItemFacturas("a.IdMovimiento,a.Annio,a.Tipo,a.Fec_Mov as Fecha,b.SubTotal_SIva as Total_Item,a.Vta_Total as Total_Documento,b.Descripcion,b.NoCuenta", "(c.Tipo_Item='H' and a.Dui='" & Me.txtDui.Value & "' and c.IdRubro='2' and Estado_Pr='A' and Estado_Ap='A' and Estado_Ah<>'A') or (b.NoCuenta='" & Me.txtCodCuenta.Text.Trim & "' and a.Estado<>'A' and b.Total_Vta=0)", "cast(a.IdMovimiento as int) asc", sUsuario, sPassword, sSucursal)
                End If
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
                    If Me.txtCodCuenta.Text.Trim.Equals(frm.Resultado8.Trim) = True Then 'Documento de esta cuenta
                        Me.C1NEMonto.Value = frm.Resultado6.Trim
                    Else 'Documento de préstamo
                        Me.C1NEMonto.Value = frm.Resultado5.Trim
                    End If
                    Me.txtOrigen.Text = "C"
                    Me.dtpDia.Value = pFecha
                End If
            ElseIf Me.rbTransferencia.Checked = True Then
                ds = oAhorro.ConsultarTransferencia("a.CodTransferencia as No_Doc,a.Fecha,b.Valor as Monto,a.Observacion", "b.NoCuenta='" & Me.txtCodCuenta.Text.Trim & "' and a.Estado='N'", "a.Fecha desc", "3", sUsuario, sPassword, sSucursal)
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
        Me.txtCodCuenta.Text = ""
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
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
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
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btProcesar.Click
        Try
            Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
            Me.Cursor = Cursors.WaitCursor
            If Trim(Me.txtCodCuenta.Text) = "" Or Val(Me.C1NEMonto.Value) = 0 Or Trim(Me.txtNoDocumento.Text) = "" Then Exit Sub
            If Me.pTipoOper.Trim = "" Then Exit Sub
            pCodReversion = "RM" & Me.pTipoOper & Format(Month(dtpDia.Value.Date), "00") & Year(dtpDia.Value.Date) & oAhorro.CorrelativoAhReversion(sUsuario, sPassword, sSucursal)
            Me.txtCodReversion.Text = pCodReversion
            If Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1) = "1" And pTipoDeposito = "1" Then 'Aportación
                oAhorro.ReversionAportaciones(pCodReversion, (Trim(Me.txtCodCuenta.Text)), Me.txtCodTipoAhorro.Text.Trim, dtpDia.Value.Date, Me.pTipoOper, Val(Me.C1NEMonto.Value), Trim(Me.txtNoDocumento.Text), IIf(Me.txtAnio.Text.Trim = "", 0, Me.txtAnio.Text.Trim), Me.txtTipo.Text.Trim, Me.txtOrigen.Text.Trim, txtObs.Text.Trim, sUsuario, sPassword, sSucursal)
            ElseIf pTipoDeposito = "0" Then 'Ahorro
                oAhorro.ReversionAhorros(pCodReversion, (Trim(Me.txtCodCuenta.Text)), Me.txtCodTipoAhorro.Text.Trim, dtpDia.Value.Date, Me.pTipoOper, Val(Me.C1NEMonto.Value), Trim(Me.txtNoDocumento.Text), IIf(Me.txtAnio.Text.Trim = "", 0, Me.txtAnio.Text.Trim), Me.txtTipo.Text.Trim, Me.txtOrigen.Text.Trim, txtObs.Text.Trim, sUsuario, sPassword, sSucursal)
            End If
            Me.Cursor = Cursors.Default
            MessageBox.Show("Aplicación Valor / Fecha procesada con éxito.", "Aplicaciones Valor Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btnImprimir.Enabled = True
            Me.btProcesar.Enabled = False
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtCodCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCuenta.LostFocus

        Dim oAh As New wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow
        Try

            ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaPrimeraCuota,Cuota,SaldoDisponible_CuentaAhorro", "NoCuenta='" & Me.txtCodCuenta.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtCodTipoAhorro.Text = dr("CodTipoAhorro")
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

End Class