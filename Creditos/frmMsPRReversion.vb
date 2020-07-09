Public Class frmMsPRReversion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbBancos As ComboBox
    Friend WithEvents lblCC As Label
    Friend WithEvents cbCC As ComboBox
    Dim prestamo As New wrPrestamo.wsLibPrest
    Dim bancos As New wrBancos.wsLibBancos
    Dim contabilidad As New wrConta.wsLibContab
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Dim asociados As New wrAsociados.wsLibAsoc

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbAbono As System.Windows.Forms.RadioButton
    Friend WithEvents rbCargo As System.Windows.Forms.RadioButton
    Friend WithEvents txtNoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents rbTransferencia As System.Windows.Forms.RadioButton
    Friend WithEvents rbCaja As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodReversion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDia As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents rbReversion As System.Windows.Forms.RadioButton
    Friend WithEvents btnReimpresion1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAplicar As MetroFramework.Controls.MetroButton
    Friend WithEvents ttip As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDia = New System.Windows.Forms.DateTimePicker()
        Me.rbReversion = New System.Windows.Forms.RadioButton()
        Me.rbTransferencia = New System.Windows.Forms.RadioButton()
        Me.rbCaja = New System.Windows.Forms.RadioButton()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoDocumento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodReversion = New System.Windows.Forms.TextBox()
        Me.rbCargo = New System.Windows.Forms.RadioButton()
        Me.rbAbono = New System.Windows.Forms.RadioButton()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnReimpresion1 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAplicar = New MetroFramework.Controls.MetroButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.lblCC = New System.Windows.Forms.Label()
        Me.cbCC = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(488, 57)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(56, 22)
        Me.txtOrigen.TabIndex = 30
        Me.txtOrigen.Visible = False
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(498, 57)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(55, 22)
        Me.txtAnio.TabIndex = 31
        Me.txtAnio.Visible = False
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(508, 57)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(55, 22)
        Me.txtTipo.TabIndex = 32
        Me.txtTipo.Visible = False
        '
        'txtDui
        '
        Me.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(127, 284)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(131, 23)
        Me.txtDui.TabIndex = 12
        Me.txtDui.Tag = Nothing
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(24, 285)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 18)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "DUI:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(433, 284)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(135, 23)
        Me.txtNoSocio.TabIndex = 14
        Me.txtNoSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(127, 320)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(441, 25)
        Me.txtAsociado.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fecha:"
        '
        'dtpDia
        '
        Me.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDia.Location = New System.Drawing.Point(127, 351)
        Me.dtpDia.Name = "dtpDia"
        Me.dtpDia.Size = New System.Drawing.Size(131, 22)
        Me.dtpDia.TabIndex = 18
        '
        'rbReversion
        '
        Me.rbReversion.Location = New System.Drawing.Point(7, 22)
        Me.rbReversion.Name = "rbReversion"
        Me.rbReversion.Size = New System.Drawing.Size(96, 28)
        Me.rbReversion.TabIndex = 0
        Me.rbReversion.Text = "&Reversión"
        '
        'rbTransferencia
        '
        Me.rbTransferencia.Location = New System.Drawing.Point(175, 22)
        Me.rbTransferencia.Name = "rbTransferencia"
        Me.rbTransferencia.Size = New System.Drawing.Size(125, 28)
        Me.rbTransferencia.TabIndex = 2
        Me.rbTransferencia.Text = "&Transferencia"
        '
        'rbCaja
        '
        Me.rbCaja.Checked = True
        Me.rbCaja.Location = New System.Drawing.Point(110, 22)
        Me.rbCaja.Name = "rbCaja"
        Me.rbCaja.Size = New System.Drawing.Size(58, 28)
        Me.rbCaja.TabIndex = 1
        Me.rbCaja.TabStop = True
        Me.rbCaja.Text = "Ca&ja"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(125, 408)
        Me.txtObs.MaxLength = 255
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(443, 37)
        Me.txtObs.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Observaciones:"
        '
        'txtNoDocumento
        '
        Me.txtNoDocumento.Location = New System.Drawing.Point(125, 379)
        Me.txtNoDocumento.MaxLength = 20
        Me.txtNoDocumento.Name = "txtNoDocumento"
        Me.txtNoDocumento.Size = New System.Drawing.Size(132, 22)
        Me.txtNoDocumento.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Código de Reversión:"
        '
        'txtCodReversion
        '
        Me.txtCodReversion.Location = New System.Drawing.Point(179, 105)
        Me.txtCodReversion.MaxLength = 25
        Me.txtCodReversion.Name = "txtCodReversion"
        Me.txtCodReversion.Size = New System.Drawing.Size(391, 22)
        Me.txtCodReversion.TabIndex = 5
        '
        'rbCargo
        '
        Me.rbCargo.Location = New System.Drawing.Point(265, 67)
        Me.rbCargo.Name = "rbCargo"
        Me.rbCargo.Size = New System.Drawing.Size(67, 30)
        Me.rbCargo.TabIndex = 2
        Me.rbCargo.Text = "&Cargo"
        '
        'rbAbono
        '
        Me.rbAbono.Checked = True
        Me.rbAbono.Location = New System.Drawing.Point(181, 73)
        Me.rbAbono.Name = "rbAbono"
        Me.rbAbono.Size = New System.Drawing.Size(77, 18)
        Me.rbAbono.TabIndex = 1
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
        Me.C1NEMonto.Location = New System.Drawing.Point(364, 379)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.Size = New System.Drawing.Size(204, 23)
        Me.C1NEMonto.TabIndex = 24
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(284, 381)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Monto:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(284, 354)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Código Préstamo:"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Location = New System.Drawing.Point(364, 351)
        Me.txtCodPrestamo.MaxLength = 25
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.ReadOnly = True
        Me.txtCodPrestamo.Size = New System.Drawing.Size(204, 22)
        Me.txtCodPrestamo.TabIndex = 20
        '
        'btnReimpresion1
        '
        Me.btnReimpresion1.Location = New System.Drawing.Point(397, 68)
        Me.btnReimpresion1.Name = "btnReimpresion1"
        Me.btnReimpresion1.Size = New System.Drawing.Size(62, 24)
        Me.btnReimpresion1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnReimpresion1.TabIndex = 3
        Me.btnReimpresion1.Text = "Imprimir Nuevamente"
        Me.btnReimpresion1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnReimpresion1.UseSelectable = True
        Me.btnReimpresion1.UseStyleColors = True
        Me.btnReimpresion1.Visible = False
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(478, 451)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(90, 33)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 28
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(473, 27)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(90, 24)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 29
        Me.btProcesar1.Text = "Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        Me.btProcesar1.Visible = False
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(382, 451)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(90, 33)
        Me.btnAplicar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAplicar.TabIndex = 27
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAplicar.UseSelectable = True
        Me.btnAplicar.UseStyleColors = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Tipo Transacción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbReversion)
        Me.GroupBox1.Controls.Add(Me.rbCaja)
        Me.GroupBox1.Controls.Add(Me.rbTransferencia)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 63)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origen"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Origen: "
        '
        'cbBancos
        '
        Me.cbBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancos.FormattingEnabled = True
        Me.cbBancos.Location = New System.Drawing.Point(125, 204)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(443, 24)
        Me.cbBancos.TabIndex = 8
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Location = New System.Drawing.Point(24, 235)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(68, 34)
        Me.lblCC.TabIndex = 9
        Me.lblCC.Text = "Centro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Costo:"
        Me.lblCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbCC
        '
        Me.cbCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCC.Enabled = False
        Me.cbCC.FormattingEnabled = True
        Me.cbCC.Location = New System.Drawing.Point(125, 241)
        Me.cbCC.Name = "cbCC"
        Me.cbCC.Size = New System.Drawing.Size(443, 24)
        Me.cbCC.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "No.Doc:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(335, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "No. Asociado"
        '
        'frmMsPRReversion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(595, 586)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbCC)
        Me.Controls.Add(Me.lblCC)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.txtCodReversion)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.dtpDia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.txtNoDocumento)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.C1NEMonto)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbCargo)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.btnReimpresion1)
        Me.Controls.Add(Me.rbAbono)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(595, 427)
        Me.Name = "frmMsPRReversion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Aplicaciones Valor Fecha (Reversiones)"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim pCodReversion As String, pTipoOper As String, pReimpresion As Boolean

    Private Sub llenarCentroCosto()
        Dim dts As New DataSet
        dts = contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        cbCC.DisplayMember = "Descripcion"
        cbCC.ValueMember = "Cod_CCosto"
        Me.cbCC.DataSource = dts.Tables(0)
        Me.cbCC.SelectedValue = CentroCostoSucursal
    End Sub
    Protected Sub llenarCtaOrigen()
        Dim dts As New DataSet
        Me.cbBancos.DisplayMember = "NOM_Cuenta"
        Me.cbBancos.ValueMember = "IdCuenta"
        dts = bancos.ObtenerCuentaBanco("IdCuenta,NOM_Cuenta", "", "NOM_Cuenta", sUsuario, sPassword, sSucursal)
        Me.cbBancos.DataSource = dts.Tables(0)

    End Sub
    Private Sub Limpiar()
        Me.txtCodPrestamo.Text = ""
        Me.txtNoDocumento.Text = ""
        Me.C1NEMonto.Value = 0
        Me.txtObs.Text = ""
        Me.txtCodReversion.Text = ""
        Me.txtDui.Text = ""
        Me.txtAsociado.Text = ""
        Me.txtNoSocio.Text = ""
        Me.txtAnio.Text = ""
        Me.txtTipo.Text = ""
        Me.dtpDia.Focus()
    End Sub

    Private Sub dtpDia_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim oCred As wrPrestamo.wsLibPrest, ds As New DataSet
            oCred = New wrPrestamo.wsLibPrest
            If Me.rbAbono.Checked = True Then
                Me.pTipoOper = "A"
                'Me.gbOrigen.Enabled = False
                Me.txtNoDocumento.ReadOnly = False
                Me.dtpDia.Enabled = True
                Me.C1NEMonto.Enabled = True
            ElseIf Me.rbCargo.Checked = True Then
                Me.pTipoOper = "C"
                'Me.gbOrigen.Enabled = True
                Me.txtNoDocumento.ReadOnly = True
                Me.dtpDia.Enabled = False
                Me.C1NEMonto.Enabled = False
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub dtpDia_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim oCred As wrPrestamo.wsLibPrest, ds As New DataSet
    '        oCred = New wrPrestamo.wsLibPrest
    '        If Me.rbAbono.Checked = True Then
    '            Me.pTipoOper = "A"
    '            'Me.gbOrigen.Enabled = False
    '            Me.txtNoDocumento.ReadOnly = False
    '            Me.dtpDia.Enabled = True
    '            Me.C1NEMonto.Enabled = True
    '        ElseIf Me.rbCargo.Checked = True Then
    '            Me.pTipoOper = "C"
    '            'Me.gbOrigen.Enabled = True
    '            Me.txtNoDocumento.ReadOnly = True
    '            Me.dtpDia.Enabled = False
    '            Me.C1NEMonto.Enabled = False
    '        End If
    '    Catch ex As Exception
    '       MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub rbCargo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCargo.CheckedChanged
        Try
            If rbCargo.Checked = True Then
                Me.rbCaja.Enabled = True
                Me.rbTransferencia.Enabled = True
                Me.rbReversion.Enabled = True
            Else
                Me.rbCaja.Enabled = False
                Me.rbTransferencia.Enabled = False
                Me.rbReversion.Enabled = False
                Me.dtpDia.Enabled = False
                Me.C1NEMonto.Enabled = False
                Me.txtNoDocumento.ReadOnly = False
            End If


            'Dim oCred As wrPrestamo.wsLibPrest, ds As New DataSet
            'oCred = New wrPrestamo.wsLibPrest
            'If Me.rbAbono.Checked = True Then
            '    Me.pTipoOper = "A"
            '    'Me.gbOrigen.Enabled = False
            '    Me.txtNoDocumento.ReadOnly = False
            '    Me.dtpDia.Enabled = True
            '    Me.C1NEMonto.Enabled = True
            'ElseIf Me.rbCargo.Checked = True Then
            '    Me.pTipoOper = "C"
            '    'Me.gbOrigen.Enabled = True
            '    Me.txtNoDocumento.ReadOnly = False
            '    Me.dtpDia.Enabled = False
            '    Me.C1NEMonto.Enabled = False
            'End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub rbAbono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAbono.CheckedChanged
    '    Try
    '        Dim oCred As wrPrestamo.wsLibPrest, ds As New DataSet
    '        oCred = New wrPrestamo.wsLibPrest
    '        If Me.rbAbono.Checked = True Then
    '            Me.pTipoOper = "A"
    '            'Me.gbOrigen.Enabled = False
    '            Me.txtNoDocumento.ReadOnly = False
    '            Me.dtpDia.Enabled = True
    '            Me.C1NEMonto.Enabled = True
    '        ElseIf Me.rbCargo.Checked = True Then
    '            Me.pTipoOper = "C"
    '            'Me.gbOrigen.Enabled = True
    '            Me.txtNoDocumento.ReadOnly = True
    '            Me.dtpDia.Enabled = False
    '            Me.C1NEMonto.Enabled = False
    '        End If
    '    Catch ex As Exception
    '       MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub frmMsPRReversion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.pTipoOper = "A"
        Me.txtOrigen.Text = "C"
        Me.dtpDia.Value = Now
        Me.txtCodReversion.Enabled = False
        llenarCentroCosto()
        llenarCtaOrigen()
        'Me.btnImprimir1.Enabled = False
        'Me.btnReimpresion1.Enabled = False

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
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
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = dr("NoSocio")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoDocumento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoDocumento.DoubleClick
        If Me.rbCargo.Checked = True Then
            Dim frm As New frmAGenerico, oAhorro As New wrAhorro.wsLibAhorro, oPrest As New wrPrestamo.wsLibPrest
            Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, pFecha As Date

            If Me.txtCodPrestamo.Text.Trim = "" Then Exit Sub

            frm.Text = "Buscar Documento"

            Try

                ds = oPrest.ConsultarPRPagos("IdMovimiento as No_Doc,FechaMov as Fecha,MontoPagado as Monto", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and Cancelada='S'", "FechaMov desc", sUsuario, sPassword, sSucursal)
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
                    Me.txtOrigen.Text = "R"
                    Me.C1NEMonto.Value = frm.Resultado3.Trim
                    Me.C1NEMonto.ReadOnly = True
                    Me.dtpDia.Value = pFecha
                End If

            Catch ex As Exception
                MessageBox.Show("System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Dim sTexto As String

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
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

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnReimpresion1.Click

        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oCred As wrPrestamo.wsLibPrest, ds As New Data.DataSet
        Try
            oCred = New wrPrestamo.wsLibPrest
            If Me.txtCodPrestamo.Text.Trim = "" Then
                ds = oCred.ConsultarPRReversiones("CodReversion,CodPrestamo,Fecha as FechaAplicacion,TipoMov,Monto,NoDocumento,FechaAplicacion", "", "FechaAplicacion desc", sUsuario, sPassword, sSucursal)
            Else
                ds = oCred.ConsultarPRReversiones("CodReversion,CodPrestamo,Fecha as FechaAplicacion,TipoMov,Monto,NoDocumento,FechaAplicacion", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "FechaAplicacion desc", sUsuario, sPassword, sSucursal)
            End If
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                Me.txtCodReversion.Text = frm.Resultado.Trim
                Me.btnImprimir1.Enabled = True
                Me.btProcesar1.Enabled = False
                pReimpresion = True
                If frm.Resultado4.Trim = "C" Then
                    Me.rbCargo.Checked = True
                ElseIf frm.Resultado4.Trim = "A" Then
                    Me.rbAbono.Checked = True
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        If txtCodReversion.Text.Trim.Length > 0 Then
            Dim tipo As Integer
            If rbAbono.Checked = True Then
                tipo = 1
            ElseIf rbCargo.Checked = True Then
                tipo = 2
            End If
            Try
                OpcionRS = 89
                Dim frm As New frmVisorRS
                With frm
                    .idTipo = tipo
                    .codReversion = txtCodReversion.Text.Trim
                    .Show()
                End With
            Catch ex As Exception
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Try
            Dim oCred As New wrPrestamo.wsLibPrest, ds As New DataSet, pResp As String, oItem As New wrCaja.wsLibCaja, oApp As New wrAdmin.wsLibAdmin, pAplicaAhorro As Boolean, pAplicaAport As Boolean, drTemp As DataRow, pCampos As String
            Me.Cursor = Cursors.WaitCursor
            If Trim(Me.txtCodPrestamo.Text) = "" Or Val(Me.C1NEMonto.Value) = 0 Or Trim(Me.txtNoDocumento.Text) = "" Then Exit Sub
            If Me.pTipoOper.Trim = "" Then Exit Sub
            pCodReversion = "RM" & Me.pTipoOper & Format(Month(dtpDia.Value.Date), "00") & Year(dtpDia.Value.Date) & oCred.CorrelativoReversion(sUsuario, sPassword, sSucursal)
            Me.txtCodReversion.Text = pCodReversion
            oCred.Timeout = -1
            pResp = oCred.ReversionProvisiones(pCodReversion, (Trim(txtCodPrestamo.Text)), dtpDia.Value.Date,
                                               Me.pTipoOper, Val(Me.C1NEMonto.Value), Trim(Me.txtNoDocumento.Text),
                                               txtObs.Text.Trim, "R", sUsuario, sPassword, sSucursal, txtDui.Text)
            If pTipoOper.Trim = "C" Then 'Solo si es cargo anular la factura o transferencia
                'Verificar si el abono a préstamo aplica abono o aportación
                pAplicaAhorro = False
                pAplicaAport = False
                pCampos = ""
                If Me.rbCaja.Checked = True Then
                    ds = oCred.ConsultarPRPagos("AbonoAportacion,AbonoAhorro", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and IdMovimiento='" & Trim(Me.txtNoDocumento.Text) & "' and Tipo='" & Me.txtTipo.Text.Trim & "' and Annio=" & Me.txtAnio.Text & " and FechaMov='" & Me.dtpDia.Value.ToShortDateString & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                Else
                    ds = oCred.ConsultarPRPagos("AbonoAportacion,AbonoAhorro", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and IdMovimiento='" & Trim(Me.txtNoDocumento.Text) & "' and FechaMov='" & Me.dtpDia.Value.ToShortDateString & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                End If
                If ds.Tables("PRPagos").Rows.Count > 0 Then
                    drTemp = ds.Tables("PRPagos").Rows(0)
                    If IIf(drTemp("AbonoAportacion") Is DBNull.Value, 0, drTemp("AbonoAportacion")) > 0 Then
                        pAplicaAport = True
                    Else
                        pAplicaAport = False
                    End If
                    If IIf(drTemp("AbonoAhorro") Is DBNull.Value, 0, drTemp("AbonoAhorro")) > 0 Then
                        pAplicaAhorro = True
                    Else
                        pAplicaAhorro = False
                    End If
                End If
                If pResp = "" And Me.rbCaja.Checked = True Then
                    If pAplicaAhorro = False And pAplicaAport = False Then
                        '=============================================
                        '19/11/2013
                        'Javier Martinez
                        'Se incluye campo de fecha de anulación
                        'pCampos = "Estado='A'"
                        '=============================================
                        pCampos = "Estado='A' ,Estado_Pr='A',fechaAnula = '" & Format(Now, "Short Date") & "'"
                    Else
                        pCampos = "Estado='A' ,Estado_Pr='A',fechaAnula = '" & Format(Now, "Short Date") & "'"
                        'pCampos = "Estado_Pr='A'"
                    End If
                    oItem.ModificaFactura("IdMovimiento='" & Me.txtNoDocumento.Text.Trim & "' and Annio=" & Me.txtAnio.Text.Trim & " and Tipo='" & Me.txtTipo.Text.Trim & "'", pCampos, sUsuario, sPassword, sSucursal)
                ElseIf pResp = "" And Me.rbTransferencia.Checked = True Then
                    oItem.ReversionTransferencia(Me.txtNoDocumento.Text.Trim, Me.dtpDia.Value, oApp.Fecha, 0, 0, "Reversión valor fecha de préstamos.", sUsuario, sPassword, sSucursal)
                End If
            End If
            Me.Cursor = Cursors.Default
            MessageBox.Show("Aplicación Valor / Fecha procesada con éxito.", "Aplicaciones Valor Fecha", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btnImprimir1.Enabled = True
            Me.btProcesar1.Enabled = False
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        If validacionesAplicacion() = True Then
            Dim origen As String
            Dim tipo As Integer
            If rbCaja.Checked = True Then
                origen = "C"
            ElseIf rbTransferencia.Checked = True Then
                origen = "T"
            Else
                origen = "R"
            End If
            If rbAbono.Checked = True Then
                tipo = 1
            ElseIf rbCargo.Checked = True Then
                tipo = 2
            End If

            Dim codReversion As String
            codReversion = prestamo.AplicacionesValorFechaPrestamos(dtpDia.Value.ToShortDateString, txtCodPrestamo.Text.Trim,
                                                     C1NEMonto.Value, txtObs.Text.Trim.ToUpper, sUsuario, origen,
                                                     txtNoDocumento.Text.Trim, tipo, txtDui.Value, sSucursal,
                                                                    cbBancos.SelectedValue, cbCC.SelectedValue)
            If codReversion.Trim.Length > 0 Then
                txtCodReversion.Text = codReversion
                MsgBox("Aplicación Valor Fecha Realizada Exitosamente", MsgBoxStyle.Information)
                Call btnImprimir1_Click(sender, e)
                Me.Close()
            Else
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Protected Function validacionesAplicacion() As Boolean
        Dim valido As Boolean = True
        'If DateTime.Compare(dtpDia.Value, Now) > 0 Then
        '    valido = False
        '    MsgBox("Fecha de aplicación no debe ser mayor que fecha actual.", MsgBoxStyle.Critical)
        'End If

        If fechaOtorgamiento > Format(dtpDia.Value, "Short date") Then
            valido = False
            MsgBox("Fecha de aplicación no puede ser menor que fecha de otorgamiento de préstamo.", MsgBoxStyle.Critical)
        End If
        If txtCodPrestamo.Text.Trim.Length = 0 Then
            valido = False
            MsgBox("Por favor seleccione un código de préstamo.", MsgBoxStyle.Critical)
        End If
        If C1NEMonto.Value <= 0 Then
            valido = False
            MsgBox("Monto no puede ser cero.", MsgBoxStyle.Critical)
        End If


        Return valido
    End Function
    Private Sub rbCaja_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbCaja.CheckedChanged
        Me.C1NEMonto.Value = 0
        Me.dtpDia.Value = Now
        Me.txtNoDocumento.Text = ""
    End Sub

    Private Sub rbTransferencia_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbTransferencia.CheckedChanged
        Me.C1NEMonto.Value = 0
        Me.dtpDia.Value = Now
        Me.txtNoDocumento.Text = ""
    End Sub
    Dim fechaOtorgamiento As DateTime
    Private Sub txtCodPrestamo_DoubleClick(sender As Object, e As EventArgs) Handles txtCodPrestamo.DoubleClick
        Try
            Dim dtsPrestamo As New DataSet
            dtsPrestamo = prestamo.ConsultarDatosPrestamos(txtDui.Text, "", 1)
            If dtsPrestamo.Tables.Count > 0 Then
                If dtsPrestamo.Tables(0).Rows.Count > 0 Then
                    Dim frm As New frmAGenerico
                    Dim sTexto As String
                    frm.Text = "Buscar Préstamo"
                    frm.Datos = dtsPrestamo
                    frm.ColSeleccion = 0
                    frm.RefrescarGrid()
                    frm.ShowDialog()
                    If frm.Resultado.Trim <> "" Then   'F
                        txtCodPrestamo.Text = frm.Resultado.Trim
                        fechaOtorgamiento = frm.Resultado3
                    End If
                Else
                     MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            Else
                MsgBox("Error en la recuperación de información, por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub
End Class