Imports CrystalDecisions.CrystalReports.Engine
Public Class frmMsCaConsultaFactura
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim prestamos As New wrPrestamo.wsLibPrest
    Dim caja As New wrCaja.wsLibCaja
    Dim MontoLetras As String
    Dim vFormaPago As Integer
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripTipoMov As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoMov As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFactura As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents C1fgrdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cbTipoTrans As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRevertir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCaConsultaFactura))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbTipoTrans = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtDescripTipoMov = New System.Windows.Forms.TextBox()
        Me.txtTipoMov = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New C1.Win.C1Input.C1TextBox()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalFactura = New C1.Win.C1Input.C1NumericEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.C1fgrdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btnRevertir1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cbTipoTrans)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.cbTipoDoc)
        Me.GroupBox1.Controls.Add(Me.txtDescripTipoMov)
        Me.GroupBox1.Controls.Add(Me.txtTipoMov)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.cmbFormaPago)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtMensaje)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAsociado)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 229)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultar Factura"
        '
        'cbTipoTrans
        '
        Me.cbTipoTrans.BackColor = System.Drawing.Color.Khaki
        Me.cbTipoTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoTrans.Items.AddRange(New Object() {"Abono", "Cambio", "Abono - Cambio"})
        Me.cbTipoTrans.Location = New System.Drawing.Point(484, 83)
        Me.cbTipoTrans.Name = "cbTipoTrans"
        Me.cbTipoTrans.Size = New System.Drawing.Size(276, 24)
        Me.cbTipoTrans.TabIndex = 189
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(388, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 190
        Me.Label4.Text = "Transacción:"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(388, 55)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 19)
        Me.Label23.TabIndex = 185
        Me.Label23.Text = "Documento:"
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.BackColor = System.Drawing.Color.Khaki
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.Items.AddRange(New Object() {"Factura Consumidor Final", "Crédito Fiscal", "Comprobante Retiro de Ahorro", "Comprobante Depósito de Ahorro", "Recibo de Pago Excedente", "Comprobante Cambio de Cheque"})
        Me.cbTipoDoc.Location = New System.Drawing.Point(484, 52)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(276, 24)
        Me.cbTipoDoc.TabIndex = 4
        '
        'txtDescripTipoMov
        '
        Me.txtDescripTipoMov.BackColor = System.Drawing.Color.White
        Me.txtDescripTipoMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripTipoMov.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripTipoMov.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtDescripTipoMov.Location = New System.Drawing.Point(160, 52)
        Me.txtDescripTipoMov.Name = "txtDescripTipoMov"
        Me.txtDescripTipoMov.ReadOnly = True
        Me.txtDescripTipoMov.Size = New System.Drawing.Size(220, 25)
        Me.txtDescripTipoMov.TabIndex = 3
        '
        'txtTipoMov
        '
        Me.txtTipoMov.BackColor = System.Drawing.Color.White
        Me.txtTipoMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoMov.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoMov.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTipoMov.Location = New System.Drawing.Point(104, 52)
        Me.txtTipoMov.Name = "txtTipoMov"
        Me.txtTipoMov.Size = New System.Drawing.Size(48, 25)
        Me.txtTipoMov.TabIndex = 2
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Location = New System.Drawing.Point(104, 148)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.NumericInput = False
        Me.txtCuenta.Size = New System.Drawing.Size(276, 23)
        Me.txtCuenta.TabIndex = 10
        Me.txtCuenta.Tag = Nothing
        Me.txtCuenta.Visible = False
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.BackColor = System.Drawing.Color.Khaki
        Me.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormaPago.ItemHeight = 16
        Me.cmbFormaPago.Items.AddRange(New Object() {"Efectivo", "Cheque propio", "Cheque ajeno", "Tarjeta", "Cta.Ahorro", "Otro"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(104, 83)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(276, 24)
        Me.cmbFormaPago.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(7, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 18)
        Me.Label10.TabIndex = 151
        Me.Label10.Text = "Forma de Pago:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(7, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 19)
        Me.Label20.TabIndex = 150
        Me.Label20.Text = "Movimiento:"
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(104, 22)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(116, 23)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 181)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 34)
        Me.Label19.TabIndex = 133
        Me.Label19.Text = "Mensaje " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para Cajas:"
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMensaje.Location = New System.Drawing.Point(104, 178)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(656, 37)
        Me.txtMensaje.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(227, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.Color.Black
        Me.txtAsociado.Location = New System.Drawing.Point(302, 22)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(458, 25)
        Me.txtAsociado.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(7, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 17)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "DUI:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(388, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(484, 114)
        Me.dtpFecha.MinDate = New Date(1945, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(276, 23)
        Me.dtpFecha.TabIndex = 7
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNumero.Location = New System.Drawing.Point(104, 114)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(276, 25)
        Me.txtNumero.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. de Doc.:"
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.BackColor = System.Drawing.Color.White
        Me.txtTotalFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalFactura.Culture = 17418
        Me.txtTotalFactura.CustomFormat = "#0.00"
        Me.txtTotalFactura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFactura.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtTotalFactura.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtTotalFactura.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtTotalFactura.Location = New System.Drawing.Point(620, 480)
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.ReadOnly = True
        Me.txtTotalFactura.Size = New System.Drawing.Size(183, 32)
        Me.txtTotalFactura.TabIndex = 148
        Me.txtTotalFactura.Tag = Nothing
        Me.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalFactura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalFactura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(431, 480)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 18)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "TOTAL FACTURA:"
        '
        'C1fgrdDetalle
        '
        Me.C1fgrdDetalle.AllowEditing = False
        Me.C1fgrdDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdDetalle.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdDetalle.BackColor = System.Drawing.Color.White
        Me.C1fgrdDetalle.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdDetalle.Location = New System.Drawing.Point(28, 310)
        Me.C1fgrdDetalle.Name = "C1fgrdDetalle"
        Me.C1fgrdDetalle.Rows.Count = 3
        Me.C1fgrdDetalle.Rows.DefaultSize = 21
        Me.C1fgrdDetalle.Size = New System.Drawing.Size(778, 165)
        Me.C1fgrdDetalle.StyleInfo = resources.GetString("C1fgrdDetalle.StyleInfo")
        Me.C1fgrdDetalle.TabIndex = 1
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(572, 517)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(134, 32)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 149
        Me.btnImprimir1.Text = "&Imprimir Factura"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btnRevertir1
        '
        Me.btnRevertir1.Location = New System.Drawing.Point(713, 517)
        Me.btnRevertir1.Name = "btnRevertir1"
        Me.btnRevertir1.Size = New System.Drawing.Size(90, 32)
        Me.btnRevertir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnRevertir1.TabIndex = 150
        Me.btnRevertir1.Text = "&Revertir"
        Me.btnRevertir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnRevertir1.UseSelectable = True
        Me.btnRevertir1.UseStyleColors = True
        '
        'frmMsCaConsultaFactura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(834, 625)
        Me.Controls.Add(Me.btnRevertir1)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalFactura)
        Me.Controls.Add(Me.C1fgrdDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(834, 625)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(834, 625)
        Me.Name = "frmMsCaConsultaFactura"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consultar Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Private pIdMovimiento As String, pAnnio As Integer, pTipo As String, pNoCaja As String, pCodCajero As String, pNoCuenta As String, vTipoDoc As String, vTipo As AlcalaLibs.Caja.clsCAFactura.TipoMovimiento, pConsolidada As Boolean
    Private pIdMovimiento As String, pAnnio As Integer, pTipo As String, pNoCaja As String, pCodCajero As String, pNoCuenta As String, vTipoDoc As String, vTipo As sifLib.Caja.clsCAFacturas.TipoMovimiento, pConsolidada As Boolean
    Private pCodSucursal As String
#Region "Propiedades"
    Public Property codSucursal() As String
        Get
            Return pCodSucursal
        End Get
        Set(ByVal value As String)
            pCodSucursal = value
        End Set
    End Property
    Private vdsFactura As New DataSet
    Public Property Factura() As System.Data.DataSet
        Get
            Return vdsFactura
        End Get
        Set(ByVal Value As System.Data.DataSet)
            vdsFactura = Value
        End Set
    End Property
    Public Property NoCaja() As String
        Get
            Return pNoCaja
        End Get
        Set(ByVal Value As String)
            pNoCaja = Value
        End Set
    End Property
    'LUIS ALVARENGA
    Dim sDuiTercero As String
    Public Property DuiTercero() As String
        Get
            Return sDuiTercero
        End Get
        Set(ByVal Value As String)
            sDuiTercero = Value
        End Set
    End Property
    Dim sNombreTercero As String
    Public Property NombreTercero() As String
        Get
            Return sNombreTercero
        End Get
        Set(ByVal Value As String)
            sNombreTercero = Value
        End Set
    End Property
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub C1fgrdDetalle_Click(sender As Object, e As EventArgs) Handles C1fgrdDetalle.Click

    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Dim oItems As wrCaja.wsLibCaja = New wrCaja.wsLibCaja, ds As New Data.DataSet
        'Dim ofrmAut As New frmMsAutorizacion
        'ofrmAut.TipoPermiso = "P"
        'ofrmAut.NumPrograma = "CAI006"
        'ofrmAut.ShowDialog()
        'If ofrmAut.Autoriza = True Then
        Try
            'Comprobante de Retiro y Depósito
            'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro And vTipoDoc <> "F" Then
            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro And vTipoDoc <> "F" Then
                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "' and codSucursal = '" & pCodSucursal & "' ", "Impreso='S'", sUsuario, sPassword, sSucursal)
                ds = oItems.ConsultarDatosAhorro("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, pCodSucursal)
                Dim ofrm As New frmVisor(ds, 17, 0)
                ofrm.Show()
                'Factura de Consumidor Final para Aportaciones
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro And vTipoDoc = "F" And pConsolidada = False Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro And vTipoDoc = "F" And pConsolidada = False Then
                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "' and codSucursal = '" & pCodSucursal & "'", "Impreso='S' ", sUsuario, sPassword, sSucursal)
                ds = oItems.ConsultarDatosAhorro("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, pCodSucursal)
                Dim ofrm As New frmVisor(ds, 23, 0)
                ofrm.Show()
                'ElseIf (Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Or Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF) And vTipoDoc = "F" And pConsolidada = False Then
            ElseIf (Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF) And vTipoDoc = "F" And pConsolidada = False Then
                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "' and codSucursal = '" & pCodSucursal & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)
                ds = oItems.ConsultarDatosAhorro("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, pCodSucursal)
                Dim ofrm As New frmVisor(ds, 23, 0)
                ofrm.Show()
                'Factura de Consumidor Final para Abonos a Préstamos
                'ElseIf (Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Or Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Cobranza) And vTipoDoc = "F" Then
            ElseIf (Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza) And vTipoDoc = "F" Then
                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "' and codSucursal = '" & pCodSucursal & "' ", "Impreso='S'", sUsuario, sPassword, sSucursal)
                ds = oItems.ConsultarDatosPrestamo(Me.pNoCuenta, Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, pCodSucursal)
                Dim ofrm As New frmVisor(ds, 13, 0)
                ofrm.Show()
                'Crédito Fiscal para Abonos a Préstamos
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo And vTipoDoc = "C" Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo And vTipoDoc = "C" Then
                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "' and codSucursal = '" & pCodSucursal & "'", "Impreso='S' ", sUsuario, sPassword, sSucursal)
                ds = oItems.ConsultarDatosPrestamo(Me.pNoCuenta, Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, pCodSucursal)
                Dim ofrm As New frmVisor(ds, 24, 0)
                ofrm.Show()
                'Crédito Fiscal para Aportaciones
                'ElseIf Me.vTipo = (AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Or Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF) And vTipoDoc = "C" Then
            ElseIf Me.vTipo = (sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF) And vTipoDoc = "C" Then
                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "' and codSucursal = '" & pCodSucursal & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)
                ds = oItems.ConsultarDatosAhorro("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, pCodSucursal)
                Dim ofrm As New frmVisor(ds, 26, 0)
                ofrm.Show()
                'Dividendos
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                Dim oAsociado As New wrAsociados.wsLibAsoc
                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "' and codSucursal = '" & pCodSucursal & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)
                ds = oAsociado.Recibo_Dividendos(Me.dtpFecha.Value, Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, Me.txtDui.Value, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 81, 0)
                ofrm.Show()
                'Otros Ingresos, genérico
            ElseIf (Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF) And vTipoDoc <> "F" And pConsolidada = False Then
                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "' and codSucursal = '" & pCodSucursal & "' ", "Impreso='S'", sUsuario, sPassword, sSucursal)
                ds = oItems.ConsultarDatosAhorro("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, pCodSucursal)
                Dim ofrm As New frmVisor(ds, 17, 0)
                ofrm.Show()
            ElseIf (vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo And vTipoDoc <> "F") Then
                Dim dtsMovPrestamo As New DataSet
                dtsMovPrestamo = prestamos.ConsultarPRPagos("codprestamo,idmovimiento,fechamov,saldoAnterior,saldo_capital", " idmovimiento = '" & txtNumero.Text & "' and codprestamo = '" & pNoCuenta & "' and  fechamov = '" & dtpFecha.Value.ToShortDateString & "'", "", sUsuario, sPassword, sSucursal)
                If dtsMovPrestamo.Tables(0).Rows.Count > 0 Then
                    oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)
                    Dim Dts As New DataSet
                    Dim rpt As New rptReciboComAbonoPrestamo
                    Dim encabezado As TextObject
                    Dim encabezadoRetiro As TextObject
                    Dim lblEfectivo As TextObject
                    Dim chkEfectivo As TextObject
                    Dim lblCheque As TextObject
                    Dim chkCheque As TextObject
                    Dim txtpaguese As TextObject
                    Dim nombreyFirma As TextObject
                    Dim monto As TextObject
                    Dim lblMonto As TextObject
                    Dim lblNoDoc As TextObject
                    Dim lblNombre As TextObject
                    Dim txtNoDocTitular As TextObject
                    Dim txtNombreTitular As TextObject
                    Dim txtDuiReporte As TextObject
                    Dim ValorLetras As TextObject
                    Dim lblBancotpt As TextObject
                    Dim txtNoCuenta As TextObject
                    Dim Sucursal As String
                    Sucursal = asociados.ConsultarSucursales("Nom_Sucursal", "CodSucursal = '" & sSucursal & "'", "", sUsuario, sPassword, sSucursal).Tables(0).Rows(0).Item("Nom_Sucursal")
                    MontoLetras = sifLib.Lector.ProcesarCantidadEnteros(Me.txtTotalFactura.Text.ToString.Trim) & " D" & ChrW(211) & "LARES CON " &
                          sifLib.Lector.ProcesarCantidadDecimales(Me.txtTotalFactura.Text.ToString.Trim) & " / 100 CENTAVOS"
                    txtDuiReporte = rpt.PageHeaderSection1.ReportObjects("txtDui")

                    txtDuiReporte.Text = txtDui.Text
                    Dts = GenerarComprobanteRetiro(Me.Factura, txtAsociado.Text.ToUpper, txtDui.Text.Trim, IIf(vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF, "", ""),
                                           txtDescripTipoMov.Text.ToUpper, IIf(vFormaPago = 0, False, True), "", sUsuario,
                                           pNoCaja, Sucursal, txtDescripTipoMov.Text.ToUpper)
                    encabezado = rpt.PageHeaderSection1.ReportObjects("encabezado")
                    encabezadoRetiro = rpt.PageHeaderSection1.ReportObjects("encabezadoRetiro")
                    lblEfectivo = rpt.PageHeaderSection1.ReportObjects("lblEfectivo")
                    chkEfectivo = rpt.PageHeaderSection1.ReportObjects("chkEfectivo")
                    lblCheque = rpt.PageHeaderSection1.ReportObjects("lblCheque")
                    chkCheque = rpt.PageHeaderSection1.ReportObjects("chkCheque")
                    txtpaguese = rpt.PageHeaderSection1.ReportObjects("txtpaguese")
                    lblBancotpt = rpt.PageHeaderSection1.ReportObjects("lblBanco")
                    lblNoDoc = rpt.PageHeaderSection1.ReportObjects("lblNoDoc")
                    lblNombre = rpt.PageHeaderSection1.ReportObjects("lblNombre")
                    txtNoDocTitular = rpt.PageHeaderSection1.ReportObjects("txtNoDocTitular")
                    txtNombreTitular = rpt.PageHeaderSection1.ReportObjects("txtNombreTitular")
                    ValorLetras = rpt.PageHeaderSection1.ReportObjects("txtValorLetras")
                    encabezado.Text = "COMPROBANTE "
                    encabezadoRetiro.Text = "FORMA DEL ABONO"
                    lblEfectivo.Text = "EFECTIVO"
                    chkEfectivo.Text = IIf(cmbFormaPago.SelectedIndex = 0, "X", "")
                    lblCheque.Text = "CHEQUE"
                    chkCheque.Text = IIf(cmbFormaPago.SelectedIndex > 0, "X", "")
                    txtpaguese.Text = "Saldo Anterior: $ " & dtsMovPrestamo.Tables(0).Rows(0).Item("saldoAnterior").ToString
                    lblBancotpt.Text = "Nuevo Saldo:    $ " & dtsMovPrestamo.Tables(0).Rows(0).Item("saldo_Capital").ToString
                    ' txtNoCuenta.Text = pNoCuenta.ToString.ToUpper
                    ValorLetras.Text = MontoLetras.ToString
                    If sDuiTercero = "" Then
                        txtNoDocTitular.Text = ""
                        txtNombreTitular.Text = ""
                        lblNoDoc.Text = ""
                        lblNombre.Text = ""
                    Else
                        txtNoDocTitular.Text = sDuiTercero
                        txtNombreTitular.Text = sNombreTercero
                    End If

                    oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)
                    rpt.SetDataSource(Dts.Tables(0))
                    Dim ofrm As New frmVisor(Dts, 219, 0)
                    With ofrm
                        .crView.ReportSource = rpt
                        .ShowDialog()
                    End With
                Else
                    MsgBox(mensajeError, MsgBoxStyle.Information, "No existe movimiento.")
                End If

            Else ' OTROS
                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)
                Dim Dts As New DataSet

                Dim rpt As New rptReciboComAbonoPrestamo
                Dim encabezado As TextObject
                Dim encabezadoRetiro As TextObject
                Dim lblEfectivo As TextObject
                Dim chkEfectivo As TextObject
                Dim lblCheque As TextObject
                Dim chkCheque As TextObject
                Dim txtpaguese As TextObject
                Dim nombreyFirma As TextObject
                Dim monto As TextObject
                Dim lblMonto As TextObject
                Dim lblNoDoc As TextObject
                Dim lblNombre As TextObject
                Dim txtNoDocTitular As TextObject
                Dim txtNombreTitular As TextObject
                Dim txtDuiReporte As TextObject
                Dim ValorLetras As TextObject
                Dim lblBancotpt As TextObject
                Dim txtNoCuenta As TextObject
                Dim Sucursal As String
                Sucursal = asociados.ConsultarSucursales("Nom_Sucursal", "CodSucursal = '" & sSucursal & "'", "", sUsuario, sPassword, sSucursal).Tables(0).Rows(0).Item("Nom_Sucursal")
                MontoLetras = sifLib.Lector.ProcesarCantidadEnteros(Me.txtTotalFactura.Text.ToString.Trim) & " D" & ChrW(211) & "LARES CON " &
                      sifLib.Lector.ProcesarCantidadDecimales(Me.txtTotalFactura.Text.ToString.Trim) & " / 100 CENTAVOS"
                txtDuiReporte = rpt.PageHeaderSection1.ReportObjects("txtDui")
                'txtNoCuenta = rpt.PageHeaderSection1.ReportObjects("txtNoCuenta")
                txtDuiReporte.Text = txtDui.Text



                Dts = GenerarComprobanteRetiro(Me.Factura, txtAsociado.Text.ToUpper, txtDui.Text.Trim, IIf(vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF, "", ""),
                                       txtDescripTipoMov.Text.ToUpper, IIf(vFormaPago = 0, False, True), "", sUsuario,
                                       pNoCaja, Sucursal, txtDescripTipoMov.Text.ToUpper)


                encabezado = rpt.PageHeaderSection1.ReportObjects("encabezado")
                encabezadoRetiro = rpt.PageHeaderSection1.ReportObjects("encabezadoRetiro")
                lblEfectivo = rpt.PageHeaderSection1.ReportObjects("lblEfectivo")
                chkEfectivo = rpt.PageHeaderSection1.ReportObjects("chkEfectivo")
                lblCheque = rpt.PageHeaderSection1.ReportObjects("lblCheque")
                chkCheque = rpt.PageHeaderSection1.ReportObjects("chkCheque")
                txtpaguese = rpt.PageHeaderSection1.ReportObjects("txtpaguese")

                lblBancotpt = rpt.PageHeaderSection1.ReportObjects("lblBanco")
                lblNoDoc = rpt.PageHeaderSection1.ReportObjects("lblNoDoc")
                lblNombre = rpt.PageHeaderSection1.ReportObjects("lblNombre")
                txtNoDocTitular = rpt.PageHeaderSection1.ReportObjects("txtNoDocTitular")
                txtNombreTitular = rpt.PageHeaderSection1.ReportObjects("txtNombreTitular")
                ValorLetras = rpt.PageHeaderSection1.ReportObjects("txtValorLetras")
                encabezado.Text = "COMPROBANTE "
                encabezadoRetiro.Text = "FORMA DEL ABONO"
                lblEfectivo.Text = "EFECTIVO"
                chkEfectivo.Text = IIf(vFormaPago = 0, "X", "")
                lblCheque.Text = "CHEQUE"
                chkCheque.Text = IIf(vFormaPago <> 0, "X", "")
                txtpaguese.Text = ""
                ValorLetras.Text = MontoLetras.ToString
                If sDuiTercero = "" Then
                    txtNoDocTitular.Text = ""
                    txtNombreTitular.Text = ""
                    lblNoDoc.Text = ""
                    lblNombre.Text = ""
                Else
                    txtNoDocTitular.Text = sDuiTercero
                    txtNombreTitular.Text = sNombreTercero
                End If

                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)
                'ds = oItems.ConsultarDatosPrestamo(Me.pNoCuenta, Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, sSucursal)
                'Dim ofrm As New frmVisor(ds, 13, 0)
                'ofrm.Show()
                rpt.SetDataSource(Dts.Tables(0))
                Dim ofrm As New frmVisor(Dts, 219, 0)
                With ofrm
                    .crView.ReportSource = rpt
                    .ShowDialog()
                End With


            End If

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try

    End Sub


    Private Sub btnRevertir1_Click(sender As Object, e As EventArgs) Handles btnRevertir1.Click
        Try
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "CAK001"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                Dim oCaja As New wrAhorro.wsLibAhorro, pResp As String, oCred As New wrPrestamo.wsLibPrest, oApp As New wrAdmin.wsLibAdmin, pCodReversion As String, oItem As New wrCaja.wsLibCaja, pAplicaAhorro As Boolean, pAplicaAport As Boolean, pCampos As String, ds As New DataSet, drTemp As DataRow
                Dim observacion As String
                If Me.txtTipoMov.Text.Trim = "3" Then
                    observacion = "Anulacion de movimiento de ahorros, No. de comprobante:" & pIdMovimiento & " caja: " & pNoCaja & " No. cajero: " & pCodCajero & " anulación realizada por: " & sUsuario.Trim
                ElseIf txtTipoMov.Text.Trim = "2" Then
                    observacion = "Anulacion de Factura por pago de préstamos No:" & pIdMovimiento & " caja: " & pNoCaja & " No. cajero: " & pCodCajero & " anulación realizada por: " & sUsuario.Trim
                ElseIf txtTipoMov.Text.Trim = "4" Then
                    observacion = "Anulacion de movimiento de apertura de DPF, No. de comprobante:" & pIdMovimiento & " caja: " & pNoCaja & " no. Cajero: " & pCodCajero & " anulación realizada por: " & sUsuario.Trim
                ElseIf txtTipoMov.Text.Trim = "1" Then
                    observacion = "Anulacion de movimiento de pago de aportación, No. de comprobante:" & pIdMovimiento & " caja: " & pNoCaja & " No. cajero: " & pCodCajero & " anulación realizada por: " & sUsuario.Trim
                Else 'txtTipoMov.Text.Trim = "4" Then
                    observacion = "Anulacion de Factura No:" & pIdMovimiento & " caja: " & pNoCaja & " No. cajero: " & pCodCajero & " anulación realizada por: " & sUsuario.Trim
                End If

                Select Case Me.txtTipoMov.Text.Trim
                    Case "2" 'AbonoPrestamo
                        If (caja.reversionMovimientosCaja(txtNumero.Text.Trim, vTipoDoc, dtpFecha.Value.ToShortDateString, pCodSucursal, txtTotalFactura.Value, observacion, sUsuario, pNoCaja, pCodCajero, 2)) > 0 Then
                            pResp = ""
                        Else
                            pResp = mensajeError
                        End If
                        'pAplicaAhorro = False
                        'pAplicaAport = False
                        'pCampos = ""
                        ''Verificar si el abono a préstamo aplica abono o aportación
                        'ds = oCred.ConsultarPRPagos("AbonoAportacion,AbonoAhorro", "CodPrestamo='" & pNoCuenta.Trim & "' and IdMovimiento='" & Trim(Me.txtNumero.Text) & "' and FechaMov='" & Me.dtpFecha.Value.ToShortDateString & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                        'If ds.Tables("PRPagos").Rows.Count > 0 Then
                        '    drTemp = ds.Tables("PRPagos").Rows(0)
                        '    If IIf(drTemp("AbonoAportacion") Is DBNull.Value, 0, drTemp("AbonoAportacion")) > 0 Then
                        '        pAplicaAport = True
                        '    Else
                        '        pAplicaAport = False
                        '    End If
                        '    If IIf(drTemp("AbonoAhorro") Is DBNull.Value, 0, drTemp("AbonoAhorro")) > 0 Then
                        '        pAplicaAhorro = True
                        '    Else
                        '        pAplicaAhorro = False
                        '    End If
                        'End If
                        'If pAplicaAhorro = False And pAplicaAport = False Then
                        '    pCodReversion = "RMC" & Format(Month(oApp.Fecha), "00") & Year(oApp.Fecha) & oCred.CorrelativoReversion(ofrmAut.Usuario, ofrmAut.Password, sSucursal)
                        '    pResp = oCred.ReversionProvisiones(pCodReversion, pNoCuenta,
                        '                                       oApp.Fecha.ToShortDateString,
                        '                                       "C", Val(Me.txtTotalFactura.Text),
                        '                                       pIdMovimiento, observacion, "C", ofrmAut.Usuario,
                        '                                       ofrmAut.Password, sSucursal, txtDui.Text.Trim)
                        '    If pResp = "" Then
                        '        ' pCampos = "Estado='A',FechaAnula='" & oApp.Fecha.ToShortDateString & "'" se modifica xq no almacena la fecha de anulación
                        '        pCampos = "Estado='A',FechaAnula='" & Format(Now, "Short Date") & "'"
                        '        oItem.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", pCampos, sUsuario, sPassword, sSucursal)
                        '    End If
                        'Else
                        '    MessageBox.Show("La Reversión no se puede realizar desde esta opción, ya que el movimiento de préstamos afecta cuentas de ahorro y/o aportación." & vbCrLf & "Debe utilizar la opción de menú H29.", "Reversión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    Exit Sub
                        'End If
                    Case "1", "3", "4" 'Ahorros,AperturaDPF,PagoAportacion                  
                        If (caja.reversionMovimientosCaja(txtNumero.Text.Trim, vTipoDoc, dtpFecha.Value.ToShortDateString, pCodSucursal, txtTotalFactura.Value, observacion, sUsuario, pNoCaja, pCodCajero, 1)) > 0 Then
                            pResp = ""
                        Else
                            pResp = mensajeError
                        End If
                        'pResp = oCaja.ReversionMovimientos(pIdMovimiento, pAnnio, pTipo, dtpFecha.Value, pNoCaja, pCodCajero, observacion, ofrmAut.Usuario, ofrmAut.Password, sSucursal)
                    Case "5" 'IngresoAsociados
                        oItem.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Estado='A',FechaAnula='" & Format(Now, "Short Date") & "'", sUsuario, sPassword, sSucursal)
                    Case "7" 'Cobranza
                        oItem.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Estado='A',FechaAnula='" & Format(Now, "Short Date") & "'", sUsuario, sPassword, sSucursal)
                    Case Else 'Generico
                        oItem.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Estado='A',FechaAnula='" & Format(Now, "Short Date") & "'", sUsuario, sPassword, sSucursal)
                End Select
                If pResp = "" Then
                    MessageBox.Show("Reversión realizada con éxito.", "Reversión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MessageBox.Show(pResp, "Reversión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                ofrmAut.Autoriza = False
                ofrmAut.Dispose()
            Else
                ofrmAut.Dispose()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Property CodCajero() As String
        Get
            Return pCodCajero
        End Get
        Set(ByVal Value As String)
            pCodCajero = Value
        End Set
    End Property

    Public Property IdMovimiento() As String
        Get
            Return pIdMovimiento
        End Get
        Set(ByVal Value As String)
            pIdMovimiento = Value
        End Set
    End Property

    Public Property Annio() As Integer
        Get
            Return pAnnio
        End Get
        Set(ByVal Value As Integer)
            pAnnio = Value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return pTipo
        End Get
        Set(ByVal Value As String)
            pTipo = Value
        End Set
    End Property

#End Region
    Private Sub frmMsCaConsultaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pConsolidada = False
        Dim oCaja As New wrCaja.wsLibCaja, oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet, dr As DataRow, drA As DataRow, drD As DataRow, drI As DataRow
        ds = oCaja.ConsultarFacturasxFiltro("*", "IdMovimiento='" & Me.pIdMovimiento & "' and Annio=" & Me.pAnnio & " and Tipo='" & Me.pTipo & "' and CodSucursal ='" & pCodSucursal & "'", "IdMovimiento", sUsuario, sPassword, sSucursal)
        If ds.Tables("CaFacturas").Rows.Count > 0 Then
            dr = ds.Tables("CaFacturas").Rows(0)
            ds = oAsoc.ConsultarAsociado("*", "Dui='" & dr("Dui") & "'", "Dui", sUsuario, sPassword, sSucursal)
            drA = ds.Tables("Cat_Asociados").Rows(0)
            ds = oCaja.ConsultarDetFacturasxFiltro("*", "IdMovimiento='" & Me.pIdMovimiento & "' and Annio=" & Me.pAnnio & " and Tipo='" & Me.pTipo & "' and CodSucursal = '" & dr("CodSucursal") & "' ", "Correlativo", sUsuario, sPassword, sSucursal)
            Me.C1fgrdDetalle.DataSource = ds.Tables("CaDet_Facturas")
            Me.Factura = ds
            If Trim(dr("Nombre")) = "F_C" Then
                pConsolidada = True
            Else
                pConsolidada = False
            End If
            drD = ds.Tables("CaDet_Facturas").Rows(0)
            pNoCuenta = drD("NoCuenta")
            ds = oCaja.ConsultarCAItemsFact("IdRubro", "CodItem='" & drD("CodItem") & "'", "CodItem", sUsuario, sPassword, sSucursal)
            drI = ds.Tables("CAItemsFact").Rows(0)
            Me.txtTipoMov.Text = drI("IdRubro")
            Select Case Me.txtTipoMov.Text.Trim
                Case "2"
                    'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo
                    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo
                Case "5"
                    'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.IngresoAsociados
                    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.IngresoAsociados
                Case "3"
                    'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro
                    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro
                Case "1"
                    'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion
                    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion
                Case "4"
                    'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF
                    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF
                Case "6"
                    'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos
                    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos
                Case "7"
                    'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Cobranza
                    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza
                Case Else
                    'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Generico
                    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Generico
            End Select
            ds = oCaja.ObtenerListaRubros("Descripcion", "IdRubro='" & Me.txtTipoMov.Text.Trim & "'", sUsuario, sPassword, sSucursal)
            drI = ds.Tables("CARubros").Rows(0)
            Me.txtDescripTipoMov.Text = drI("Descripcion")

            Me.txtNumero.Text = Me.pIdMovimiento
            Me.dtpFecha.Value = dr("Fec_Mov")
            Me.txtDui.Value = dr("Dui")
            Me.txtAsociado.Text = Trim(drA("Nombres")) & " " & drA("Apellido1") & " " & drA("Apellido2") & " " & drA("ApellidoCas")
            Select Case Convert.ToString(dr("Tipo"))
                Case "F" 'Factura
                    Me.vTipoDoc = "F"
                    Me.cbTipoDoc.SelectedIndex = 0
                Case "C" 'Crédito Fiscal
                    Me.cbTipoDoc.SelectedIndex = 1
                    Me.vTipoDoc = "C"
                Case "R" 'Comprobante Retiro
                    Me.vTipoDoc = "R"
                    Me.cbTipoDoc.SelectedIndex = 2
                Case "D" 'Comprobante Depósito
                    Me.vTipoDoc = "D"
                    Me.cbTipoDoc.SelectedIndex = 3
                Case "P" 'Comprobante de Pago Excedente o Recibo
                    Me.vTipoDoc = "P"
                    Me.cbTipoDoc.SelectedIndex = 4
                Case "H" 'Comprobante de Cambio de Cheque
                    Me.vTipoDoc = "H"
                    Me.cbTipoDoc.SelectedIndex = 5
            End Select
            Me.cbTipoTrans.SelectedIndex = dr("TipoTransaccion")
            Me.cmbFormaPago.SelectedIndex = dr("FormaPago")
            Me.txtTotalFactura.Enabled = True
            Me.txtTotalFactura.ReadOnly = False
            Me.txtTotalFactura.Value = dr("Vta_Total")
            Me.txtTotalFactura.Enabled = False
            Me.txtTotalFactura.ReadOnly = True
            Me.dtpFecha.Enabled = False
        End If

    End Sub
    Protected Function GenerarComprobanteRetiro(ByVal dsValores As DataSet,
                                                   ByVal Asociado As String,
    ByVal Dui As String,
    ByVal Nocuenta As String,
    ByVal TipoCuenta As String,
           ByVal FormaRetiro As Boolean,
    ByVal Paguese As String,
    ByVal Usuario As String,
    ByVal NoCaja As Integer,
    ByVal Sucursal As String,
    ByVal TipoAhorro As String
    ) As DataSet



        Dim RptRecibo As New rptReciboRetAboAhorros
        Dim Dts As New DataSet("RetiroAhorros")
        Dim Dt As DataTable = Dts.Tables.Add("Comprobante")
        Dim Dr As DataRow
        With Dt
            .Columns.Add("Asociado", Type.GetType("System.String"))
            .Columns.Add("DUI", Type.GetType("System.String"))
            .Columns.Add("NoCuenta", Type.GetType("System.String"))
            .Columns.Add("TipoCuenta", Type.GetType("System.String"))
            .Columns.Add("MontoLetras", Type.GetType("System.String"))
            .Columns.Add("FormaRetiro", Type.GetType("System.Boolean"))
            .Columns.Add("Paguese", Type.GetType("System.String"))
            .Columns.Add("Usuario", Type.GetType("System.String"))
            .Columns.Add("NoCaja", Type.GetType("System.Int32"))
            .Columns.Add("Sucursal", Type.GetType("System.String"))
            .Columns.Add("Monto", Type.GetType("System.Double"))
        End With
        For i As Integer = 0 To dsValores.Tables("CADet_Facturas").Rows.Count - 1
            Dr = Dt.NewRow()
            Dr("Asociado") = Asociado.ToUpper
            Dr("DUI") = Dui

            Dr("TipoCuenta") = TipoAhorro.ToUpper
            Dr("NoCuenta") = dsValores.Tables("CADet_Facturas").Rows(i).Item("NoCuenta")
            Dr("FormaRetiro") = FormaRetiro
            Dr("Paguese") = Paguese.ToUpper
            Dr("Usuario") = Usuario.ToUpper
            Dr("NoCaja") = NoCaja
            Dr("Sucursal") = Sucursal.ToUpper
            If dsValores.Tables("CADet_Facturas").Rows(i).Item("Total_Vta") > 0 Then
                Dr("Monto") = dsValores.Tables("CADet_Facturas").Rows(i).Item("Total_Vta")
                Dr("MontoLetras") = dsValores.Tables("CADet_Facturas").Rows(i).Item("Descripcion")

            End If

            Dt.Rows.Add(Dr)
        Next
        Return Dts
    End Function
End Class