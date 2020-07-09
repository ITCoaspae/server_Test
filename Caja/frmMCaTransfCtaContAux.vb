Public Class frmMCaTransfCtaContAux
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private sNoCuenta As String, pCodTransferencia As String ', sSupervisor As String, pPassword As String
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btBorrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNombCosto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodCosto As TextBox
    Public dsDetalle As New DataSet
    Private pCtaPorCobrar As Boolean
    Private pNoCtaAuxiliar As String
    Dim ahorro As New wrAhorro.wsLibAhorro
    Dim admin As New wrAdmin.wsLibAdmin
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim Bancos As New wrBancos.wsLibBancos
    Dim contabilidad As New wrConta.wsLibContab

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents gbDestino As System.Windows.Forms.GroupBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents c1txtObservaciones As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents c1txtNoDoc As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1txtNombreAsoc As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCaTransfCtaContAux))
        Me.gbDestino = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodCosto = New System.Windows.Forms.TextBox()
        Me.txtNombCosto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.c1txtObservaciones = New C1.Win.C1Input.C1TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c1txtNoDoc = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1txtNombreAsoc = New C1.Win.C1Input.C1TextBox()
        Me.c1txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btNProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.btBorrar1 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.gbDestino.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNombreAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDestino
        '
        Me.gbDestino.Controls.Add(Me.txtTotal)
        Me.gbDestino.Controls.Add(Me.fg)
        Me.gbDestino.Controls.Add(Me.btnAgregar1)
        Me.gbDestino.Controls.Add(Me.btnEliminar1)
        Me.gbDestino.ForeColor = System.Drawing.Color.Teal
        Me.gbDestino.Location = New System.Drawing.Point(28, 388)
        Me.gbDestino.Name = "gbDestino"
        Me.gbDestino.Size = New System.Drawing.Size(777, 188)
        Me.gbDestino.TabIndex = 3
        Me.gbDestino.TabStop = False
        Me.gbDestino.Text = "Cuenta(s) de Destino:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(547, 28)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(221, 22)
        Me.txtTotal.TabIndex = 2
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Teal
        Me.fg.Location = New System.Drawing.Point(10, 64)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(758, 118)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 3
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(7, 25)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 33)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 0
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(104, 25)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 33)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 1
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtCodCosto)
        Me.GroupBox1.Controls.Add(Me.txtNombCosto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.txtIdCuenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtResponsable)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.c1txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.c1txtNoDoc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.c1txtNombreAsoc)
        Me.GroupBox1.Controls.Add(Me.c1txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(777, 309)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta de Origen"
        '
        'txtCodCosto
        '
        Me.txtCodCosto.BackColor = System.Drawing.Color.White
        Me.txtCodCosto.Location = New System.Drawing.Point(134, 190)
        Me.txtCodCosto.Name = "txtCodCosto"
        Me.txtCodCosto.ReadOnly = True
        Me.txtCodCosto.Size = New System.Drawing.Size(116, 22)
        Me.txtCodCosto.TabIndex = 16
        '
        'txtNombCosto
        '
        Me.txtNombCosto.BackColor = System.Drawing.Color.White
        Me.txtNombCosto.Location = New System.Drawing.Point(256, 190)
        Me.txtNombCosto.Name = "txtNombCosto"
        Me.txtNombCosto.ReadOnly = True
        Me.txtNombCosto.Size = New System.Drawing.Size(515, 22)
        Me.txtNombCosto.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Centro Costos:"
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Location = New System.Drawing.Point(256, 162)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(515, 22)
        Me.txtCuenta.TabIndex = 14
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.BackColor = System.Drawing.Color.White
        Me.txtIdCuenta.Location = New System.Drawing.Point(134, 162)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.ReadOnly = True
        Me.txtIdCuenta.Size = New System.Drawing.Size(116, 22)
        Me.txtIdCuenta.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cuenta Contable:"
        '
        'txtResponsable
        '
        Me.txtResponsable.BackColor = System.Drawing.Color.White
        Me.txtResponsable.Location = New System.Drawing.Point(134, 53)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(637, 22)
        Me.txtResponsable.TabIndex = 3
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(134, 107)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(238, 20)
        Me.txtDui.TabIndex = 7
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(533, 107)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(238, 23)
        Me.txtNoSocio.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Asociado:"
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(378, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "No. Asociado:"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Responsable:"
        '
        'c1txtObservaciones
        '
        Me.c1txtObservaciones.BackColor = System.Drawing.Color.White
        Me.c1txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtObservaciones.Location = New System.Drawing.Point(134, 247)
        Me.c1txtObservaciones.MaxLength = 255
        Me.c1txtObservaciones.Multiline = True
        Me.c1txtObservaciones.Name = "c1txtObservaciones"
        Me.c1txtObservaciones.NumericInput = False
        Me.c1txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtObservaciones.Size = New System.Drawing.Size(636, 51)
        Me.c1txtObservaciones.TabIndex = 21
        Me.c1txtObservaciones.Tag = Nothing
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Observaciones:"
        '
        'c1txtNoDoc
        '
        Me.c1txtNoDoc.BackColor = System.Drawing.Color.White
        Me.c1txtNoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNoDoc.CustomFormat = "00000000000000000000"
        Me.c1txtNoDoc.DataType = GetType(Long)
        Me.c1txtNoDoc.Location = New System.Drawing.Point(134, 81)
        Me.c1txtNoDoc.MaxLength = 14
        Me.c1txtNoDoc.Name = "c1txtNoDoc"
        Me.c1txtNoDoc.NumericInput = False
        Me.c1txtNoDoc.Size = New System.Drawing.Size(637, 20)
        Me.c1txtNoDoc.TabIndex = 5
        Me.c1txtNoDoc.Tag = Nothing
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. Documento:"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Monto:"
        '
        'c1txtNombreAsoc
        '
        Me.c1txtNombreAsoc.BackColor = System.Drawing.Color.White
        Me.c1txtNombreAsoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNombreAsoc.Location = New System.Drawing.Point(134, 136)
        Me.c1txtNombreAsoc.MaxLength = 14
        Me.c1txtNombreAsoc.Name = "c1txtNombreAsoc"
        Me.c1txtNombreAsoc.NumericInput = False
        Me.c1txtNombreAsoc.ReadOnly = True
        Me.c1txtNombreAsoc.Size = New System.Drawing.Size(636, 20)
        Me.c1txtNombreAsoc.TabIndex = 11
        Me.c1txtNombreAsoc.Tag = Nothing
        '
        'c1txtMonto
        '
        Me.c1txtMonto.BackColor = System.Drawing.Color.White
        Me.c1txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtMonto.CustomFormat = "###,##0.00"
        Me.c1txtMonto.DataType = GetType(Double)
        Me.c1txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1txtMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1txtMonto.Location = New System.Drawing.Point(134, 218)
        Me.c1txtMonto.Name = "c1txtMonto"
        Me.c1txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(0R, Nothing, True, True)})
        Me.c1txtMonto.Size = New System.Drawing.Size(238, 23)
        Me.c1txtMonto.TabIndex = 19
        Me.c1txtMonto.Tag = Nothing
        Me.c1txtMonto.Value = 0R
        Me.c1txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DUI:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(134, 25)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(637, 22)
        Me.dtpFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Movimiento:"
        '
        'btNProcesar1
        '
        Me.btNProcesar1.Location = New System.Drawing.Point(521, 582)
        Me.btNProcesar1.Name = "btNProcesar1"
        Me.btNProcesar1.Size = New System.Drawing.Size(90, 32)
        Me.btNProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNProcesar1.TabIndex = 4
        Me.btNProcesar1.Text = "Procesar"
        Me.btNProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNProcesar1.UseSelectable = True
        Me.btNProcesar1.UseStyleColors = True
        '
        'btBorrar1
        '
        Me.btBorrar1.Location = New System.Drawing.Point(618, 582)
        Me.btBorrar1.Name = "btBorrar1"
        Me.btBorrar1.Size = New System.Drawing.Size(90, 32)
        Me.btBorrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btBorrar1.TabIndex = 0
        Me.btBorrar1.Text = "Borrar"
        Me.btBorrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btBorrar1.UseSelectable = True
        Me.btBorrar1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(715, 582)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(90, 32)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 1
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'frmMCaTransfCtaContAux
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(825, 640)
        Me.Controls.Add(Me.btNProcesar1)
        Me.Controls.Add(Me.btBorrar1)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbDestino)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMCaTransfCtaContAux"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Transferencia Cuenta Contable a Cuenta(s) Auxiliar(es)"
        Me.gbDestino.ResumeLayout(False)
        Me.gbDestino.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNombreAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"
    Public Property ctaPorCobrar() As Boolean
        Get
            Return pCtaPorCobrar
        End Get
        Set(value As Boolean)
            pCtaPorCobrar = value
        End Set
    End Property
    Public Property noCtaAuxiliar() As String
        Get
            Return pNoCtaAuxiliar
        End Get
        Set(value As String)
            pNoCtaAuxiliar = value
        End Set
    End Property
#End Region
    Private Sub frmMCaTransfCtaContAux_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtResponsable.Text = sUsuario
        Me.txtIdCuenta.ReadOnly = True
        Me.dtpFecha.Value = Now
        dsDetalle = ahorro.ObtenerDetalleTransferenciaVacio
    End Sub
    Private Sub Encabezado()
        fg.Cols.Item(1).Caption = "No."
        fg.Cols.Item(2).Caption = "No. Cuenta"
        fg.Cols.Item(3).Caption = "Cta. Contable"
        fg.Cols.Item(4).Caption = "Valor"
        fg.Cols.Item(5).Caption = "Tipo Movimiento"
        fg.Cols.Item(6).Caption = "Tipo Cuenta"
        fg.Cols.Item(4).Format = "##0.00"
        fg.Cols.Item(1).Width = 77
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 77
        fg.Cols.Item(5).Width = 0
        fg.Cols.Item(6).Width = 0
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub

        Dim dr As DataRow, ds As New Data.DataSet
        Try

            ds = asociados.ConsultarAsociado("DUI,Nombres+' '+Apellido1+' '+Apellido2+' '+ApellidoCas as NombreAsociado,NoSocio", "Dui='" & Me.txtDui.Value & "'", "DUI", sUsuario, sPassword, sSucursal)
            If ds.Tables("Cat_Asociados").Rows.Count > 0 Then
                dr = ds.Tables("Cat_Asociados").Rows(0)
                Me.txtDui.Value = dr("Dui").ToString.Trim
                Me.c1txtNombreAsoc.Value = dr("NombreAsociado").ToString.Trim
                Me.txtNoSocio.Text = dr("NoSocio").ToString.Trim
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
        Dim sNomb, campos As String
        Dim ds As New Data.DataSet
        Try


            campos = " DUI,Nombres+' '+Apellido1+' '+Apellido2+' '+ApellidoCas as NombreAsociado,"
            campos += "NoSocio,NIT,ISSS,LugarExtDUI,FechaExtDUI,NumPasaporte,EstadoIngreso,Fecha_Nac,Direccion "
            ds = asociados.ConsultarAsociado(campos, "", "DUI", sUsuario, sPassword, sSucursal)
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
    Private Sub Limpiar()
        Dim ds As New DataSet
        Me.dtpFecha.Value = Now
        Me.c1txtNoDoc.Value = 0
        Me.txtDui.Value = ""
        Me.txtNoSocio.Text = ""
        Me.c1txtNombreAsoc.Value = ""
        Me.c1txtObservaciones.Value = ""
        Me.c1txtMonto.Value = 0
        Me.btnAgregar1.Enabled = False
        Me.fg.DataSource = ds
        Me.dsDetalle.Clear()
        Me.txtDui.Focus()
        Me.btnImprimir1.Enabled = False
        pCodTransferencia = ""
        Me.btNProcesar1.Enabled = True
    End Sub

    Private Sub txtIdCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuenta.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Cuenta Contable"
        Dim ds As New DataSet
        Dim dts As DataSet
        Dim dr As DataRow
        Try

            ds = contabilidad.ObtenerCatContab("idCuenta,Descripcion", "Final='S' and Inhabilitado = 'N' or (CuentaComun = '1')", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtIdCuenta.Text = ofrm.Resultado.Trim
            Me.txtCuenta.Text = ofrm.Resultado2.Trim
            dts = contabilidad.RecuperarCodCostoXsucursal(sSucursal)
            dr = dts.Tables("CodCostos").Rows(0)
            txtCodCosto.Text = dr("Cod_CCosto")
            txtNombCosto.Text = dr("Descripcion")

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtIdCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuenta.LostFocus
        If Me.txtIdCuenta.Text.Trim <> "" Then
            Me.btnAgregar1.Enabled = True
        Else
            Me.btnAgregar1.Enabled = False
        End If
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txtDui_LostFocus(sender, e)
        End If
    End Sub
    Private Sub SumaDetalle()
        Dim pSum As Double, dr As DataRow, x As Integer
        x = 0
        For Each dr In dsDetalle.Tables(0).Rows
            pSum = pSum + (IIf(dr("IdCuenta") = "22010407" Or dr("IdCuenta") = "22010406" Or dr("IdCuenta") = "22010408" Or dr("IdCuenta") = "22010409", 0, dr("Valor")))
        Next
        If x > 0 Then
            Me.c1txtMonto.Enabled = False
        Else
            Me.c1txtMonto.Enabled = True
        End If
        pSum = Me.c1txtMonto.Text - pSum
        Me.txtTotal.Text = "Pendiente: $" & pSum
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim ofrm As New frmMsCaDetTransfCtaContAux
            ofrm.NoCuenta = Me.txtIdCuenta.Text.Trim
            ofrm.Dui = Me.txtDui.Value
            ofrm.Fecha = Me.dtpFecha.Value
            ofrm.montoTransferencia = c1txtMonto.Value
            ofrm.c1txtMonto.Value = c1txtMonto.Value
            ofrm.FrmT = Me
            ofrm.ccCuenta = Me.txtCodCosto.Text.trim
            ofrm.ctaconta1 = Me.txtIdCuenta.Text
            ofrm.ShowDialog()
            fg.DataSource = dsDetalle.Tables(0)
            fg.Refresh()
            Encabezado()
            SumaDetalle()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If fg.Row <> -1 Then
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

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
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
            MsgBox(Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btBorrar1_Click(sender As Object, e As EventArgs) Handles btBorrar1.Click
        Try
            Limpiar()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNProcesar1_Click(sender As Object, e As EventArgs) Handles btNProcesar1.Click

        Dim dsDestino As New DataSet
        Dim pResponse As String = ""
        Dim dsOrigen As New DataSet

        Try
            If ctaPorCobrar = True Then
                pCodTransferencia = contabilidad.ingresarAbonoCuentaPorCobrarTransferencia(dtpFecha.Value.ToShortDateString, txtDui.Value, txtNoSocio.Text.Trim, sUsuario, c1txtMonto.Value, c1txtObservaciones.Text.Trim, c1txtNoDoc.Value, txtIdCuenta.Text.Trim, False, txtIdCuenta.Text.Trim, noCtaAuxiliar, fg.Item(0, "codCosto").ToString)
            Else
                pCodTransferencia = ahorro.ObtenerCorrelativoTransferencia("CodTransferencia", "2", "(MONTH(Fecha) = '" & Me.dtpFecha.Value.Month & "')  AND (YEAR(Fecha) = " & Me.dtpFecha.Value.Year & ")", sUsuario, sPassword, sSucursal)
                pResponse = ahorro.TransferenciaCuentas(Me.c1txtNoDoc.Text.Trim, "2", Me.dtpFecha.Value.ToShortDateString, Me.txtDui.Value, Me.txtNoSocio.Text.Trim, Me.txtResponsable.Text.Trim, CDbl(Me.c1txtMonto.Text), Me.c1txtObservaciones.Text.Trim, Me.txtIdCuenta.Text.Trim, pCodTransferencia, Me.txtIdCuenta.Text.Trim, "", dsDetalle, "", "M", Me.c1txtNombreAsoc.Text.Trim, "0", sUsuario, sPassword, sSucursal, txtCodCosto.Text)
            End If

            If pResponse <> "" Then
                MessageBox.Show(pResponse, "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                MessageBox.Show("Transferencia realizada.", "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btnImprimir1.Enabled = True
                Me.btNProcesar1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function VerificaPrestamo() As Boolean
        Dim dr As DataRow

        For Each dr In dsDetalle.Tables(0).Rows
            If dr("TipoCuenta") = "P" Then
                Return True
            End If
        Next
        Return False
    End Function

End Class