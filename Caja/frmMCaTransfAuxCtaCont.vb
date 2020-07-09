Public Class frmMCaTransfAuxCtaCont
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim Bancos As New wrBancos.wsLibBancos
    Private sNoCuenta As String, pSaldoOrigen As Double, pPignorado As String, vCancela As Boolean, pCodTransferencia As String, pCodTransaccion As String, vDPF As Boolean ', sSupervisor As String, pPassword As String
    Public dsDetalle As New DataSet
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btBorrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNProcesar1 As MetroFramework.Controls.MetroButton
    Dim contabilidad As New wrConta.wsLibContab
    Dim Cod_Costo As String
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
    Friend WithEvents txtCodTipo As System.Windows.Forms.TextBox
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
    Friend WithEvents c1txtCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1txtNombreAsoc As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCaTransfAuxCtaCont))
        Me.gbDestino = New System.Windows.Forms.GroupBox()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodTipo = New System.Windows.Forms.TextBox()
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
        Me.c1txtCuenta = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1txtNombreAsoc = New C1.Win.C1Input.C1TextBox()
        Me.c1txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btBorrar1 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btNProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.gbDestino.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNombreAsoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDestino
        '
        Me.gbDestino.BackColor = System.Drawing.Color.White
        Me.gbDestino.Controls.Add(Me.btnEliminar1)
        Me.gbDestino.Controls.Add(Me.btnAgregar1)
        Me.gbDestino.Controls.Add(Me.txtTotal)
        Me.gbDestino.Controls.Add(Me.fg)
        Me.gbDestino.ForeColor = System.Drawing.Color.Teal
        Me.gbDestino.Location = New System.Drawing.Point(23, 319)
        Me.gbDestino.Name = "gbDestino"
        Me.gbDestino.Size = New System.Drawing.Size(687, 183)
        Me.gbDestino.TabIndex = 1
        Me.gbDestino.TabStop = False
        Me.gbDestino.Text = "Cuenta(s) de Destino:"
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(89, 15)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 50
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(8, 15)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 49
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(484, 15)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(184, 20)
        Me.txtTotal.TabIndex = 5
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.Location = New System.Drawing.Point(9, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(659, 117)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.txtIdCuenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCodTipo)
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
        Me.GroupBox1.Controls.Add(Me.c1txtCuenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.c1txtNombreAsoc)
        Me.GroupBox1.Controls.Add(Me.c1txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 250)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta de Origen"
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Location = New System.Drawing.Point(203, 143)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(465, 20)
        Me.txtCuenta.TabIndex = 166
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.BackColor = System.Drawing.Color.White
        Me.txtIdCuenta.Location = New System.Drawing.Point(112, 143)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.ReadOnly = True
        Me.txtIdCuenta.Size = New System.Drawing.Size(85, 20)
        Me.txtIdCuenta.TabIndex = 165
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "Cuenta Contable:"
        '
        'txtCodTipo
        '
        Me.txtCodTipo.Location = New System.Drawing.Point(264, 65)
        Me.txtCodTipo.Name = "txtCodTipo"
        Me.txtCodTipo.Size = New System.Drawing.Size(16, 20)
        Me.txtCodTipo.TabIndex = 164
        Me.txtCodTipo.Visible = False
        '
        'txtResponsable
        '
        Me.txtResponsable.BackColor = System.Drawing.Color.White
        Me.txtResponsable.Location = New System.Drawing.Point(308, 16)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(360, 20)
        Me.txtResponsable.TabIndex = 1
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(112, 68)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(96, 18)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(588, 68)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(80, 20)
        Me.txtNoSocio.TabIndex = 163
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 15)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Asociado:"
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(502, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "No. Asociado:"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(214, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Responsable:"
        '
        'c1txtObservaciones
        '
        Me.c1txtObservaciones.BackColor = System.Drawing.Color.White
        Me.c1txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtObservaciones.Location = New System.Drawing.Point(112, 169)
        Me.c1txtObservaciones.MaxLength = 255
        Me.c1txtObservaciones.Multiline = True
        Me.c1txtObservaciones.Name = "c1txtObservaciones"
        Me.c1txtObservaciones.NumericInput = False
        Me.c1txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtObservaciones.Size = New System.Drawing.Size(556, 62)
        Me.c1txtObservaciones.TabIndex = 6
        Me.c1txtObservaciones.Tag = Nothing
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Observaciones:"
        '
        'c1txtNoDoc
        '
        Me.c1txtNoDoc.BackColor = System.Drawing.Color.White
        Me.c1txtNoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNoDoc.CustomFormat = "00000000000000000000"
        Me.c1txtNoDoc.DataType = GetType(Long)
        Me.c1txtNoDoc.Location = New System.Drawing.Point(112, 42)
        Me.c1txtNoDoc.MaxLength = 14
        Me.c1txtNoDoc.Name = "c1txtNoDoc"
        Me.c1txtNoDoc.NumericInput = False
        Me.c1txtNoDoc.Size = New System.Drawing.Size(96, 18)
        Me.c1txtNoDoc.TabIndex = 2
        Me.c1txtNoDoc.Tag = Nothing
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "No. Documento:"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(332, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Valor Transferencia:"
        '
        'c1txtCuenta
        '
        Me.c1txtCuenta.BackColor = System.Drawing.Color.White
        Me.c1txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtCuenta.Location = New System.Drawing.Point(112, 117)
        Me.c1txtCuenta.MaxLength = 14
        Me.c1txtCuenta.Name = "c1txtCuenta"
        Me.c1txtCuenta.NumericInput = False
        Me.c1txtCuenta.ReadOnly = True
        Me.c1txtCuenta.Size = New System.Drawing.Size(206, 18)
        Me.c1txtCuenta.TabIndex = 4
        Me.c1txtCuenta.Tag = Nothing
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Cuenta:"
        '
        'c1txtNombreAsoc
        '
        Me.c1txtNombreAsoc.BackColor = System.Drawing.Color.White
        Me.c1txtNombreAsoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNombreAsoc.Location = New System.Drawing.Point(112, 91)
        Me.c1txtNombreAsoc.MaxLength = 14
        Me.c1txtNombreAsoc.Name = "c1txtNombreAsoc"
        Me.c1txtNombreAsoc.NumericInput = False
        Me.c1txtNombreAsoc.ReadOnly = True
        Me.c1txtNombreAsoc.Size = New System.Drawing.Size(556, 18)
        Me.c1txtNombreAsoc.TabIndex = 94
        Me.c1txtNombreAsoc.Tag = Nothing
        '
        'c1txtMonto
        '
        Me.c1txtMonto.BackColor = System.Drawing.Color.White
        Me.c1txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtMonto.CustomFormat = "###,###,##0.00"
        Me.c1txtMonto.DataType = GetType(Double)
        Me.c1txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1txtMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1txtMonto.Location = New System.Drawing.Point(462, 117)
        Me.c1txtMonto.Name = "c1txtMonto"
        Me.c1txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(0R, Nothing, True, True)})
        Me.c1txtMonto.Size = New System.Drawing.Size(206, 19)
        Me.c1txtMonto.TabIndex = 5
        Me.c1txtMonto.Tag = Nothing
        Me.c1txtMonto.Value = 0R
        Me.c1txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "DUI:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(112, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Fecha Movimiento:"
        '
        'btBorrar1
        '
        Me.btBorrar1.Location = New System.Drawing.Point(554, 508)
        Me.btBorrar1.Name = "btBorrar1"
        Me.btBorrar1.Size = New System.Drawing.Size(75, 28)
        Me.btBorrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btBorrar1.TabIndex = 52
        Me.btBorrar1.Text = "Borrar"
        Me.btBorrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btBorrar1.UseSelectable = True
        Me.btBorrar1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(635, 508)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(75, 28)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 51
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btNProcesar1
        '
        Me.btNProcesar1.Location = New System.Drawing.Point(473, 508)
        Me.btNProcesar1.Name = "btNProcesar1"
        Me.btNProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btNProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNProcesar1.TabIndex = 53
        Me.btNProcesar1.Text = "Procesar"
        Me.btNProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNProcesar1.UseSelectable = True
        Me.btNProcesar1.UseStyleColors = True
        '
        'frmMCaTransfAuxCtaCont
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(891, 676)
        Me.Controls.Add(Me.btNProcesar1)
        Me.Controls.Add(Me.btBorrar1)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbDestino)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMCaTransfAuxCtaCont"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Transferencia Cuenta Auxiliar a Cuenta(s) Contable(s)"
        Me.gbDestino.ResumeLayout(False)
        Me.gbDestino.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNombreAsoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMCaTransfAuxCtaCont_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAh As New wrAhorro.wsLibAhorro, oApp As New wrAdmin.wsLibAdmin
        Me.txtResponsable.Text = sUsuario
        dsDetalle = oAh.ObtenerDetalleTransferenciaVacio
        Me.dtpFecha.Value = oApp.Fecha
        vCancela = False
        vDPF = False
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

    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
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

    Private Sub Limpiar()
        Dim ds As New DataSet
        Me.c1txtCuenta.Value = ""
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
        vCancela = False
        vDPF = False
        Me.txtIdCuenta.Text = ""
        Me.txtCuenta.Text = ""
        Me.c1txtCuenta.Enabled = True
        Me.c1txtMonto.Enabled = True
        Me.btBorrar1.Enabled = True
        'Me.btSalir.Enabled = True
        Me.txtDui.Enabled = True
        pCodTransaccion = ""
        Me.btnImprimir1.Enabled = False
        pCodTransferencia = ""
        Me.btNProcesar1.Enabled = True
    End Sub

    Private Sub c1txtCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1txtCuenta.DoubleClick
        Dim ds As New DataSet, oAh As New wrAhorro.wsLibAhorro, dr As DataRow
        Dim frm As New frmAGenerico, oPerif As New wrConta.wsLibContab
        Dim campos As String
        campos = " a.CodTipoAhorro as Codigo, " &
                                        "b.Descripcion as Tipo_Ahorro, " &
                                        "a.NoCuenta, " &
                                        "a.NoCuentaAnterior, " &
                                        "a.IdCertificadoDPF as No_Certificado, " &
                                        "a.SaldoDisponible_CuentaAhorro as Saldo, " &
                                        "b.IdCuenta as Cuenta_Contable, " &
                                        "a.Pignorado, " &
                                        "a.codSucursal, " &
                                        "d.Cod_CCosto  "
        ds = oAh.ConsultarCtasAhorroDUI(campos, " a.DUI='" & Me.txtDui.Value & "' AND a.Estado <> 'C'", "", sUsuario, sPassword, sSucursal)
        frm.Text = "Buscar Cuentas Auxiliares"
        frm.Datos = ds
        frm.ColSeleccion = 0
        frm.RefrescarGrid()
        frm.ShowDialog()
        If frm.Resultado.Trim <> "" Then
            Me.c1txtCuenta.Value = frm.Resultado3.Trim
            Me.txtCodTipo.Text = frm.Resultado.Trim
            Me.txtIdCuenta.Text = contabilidad.Recuperar_Cta_x_Centro_Costo(frm.Resultado9, frm.Resultado7.Trim) 'frm.Resultado7.Trim
            Cod_Costo = frm.Resultado10
            pSaldoOrigen = frm.Resultado6
            If Me.txtCodTipo.Text.Trim.Substring(0, 1) = "6" Then 'DPF
                Me.c1txtMonto.Value = pSaldoOrigen
                Me.c1txtMonto.Enabled = False
                vDPF = True
            Else
                vDPF = False
            End If
            pPignorado = frm.Resultado8.Trim
            If Trim(Me.txtIdCuenta.Text.Trim) <> "" Then
                ds = oPerif.ObtenerCatContab("*", "Final='S' and IdCuenta='" & Me.txtIdCuenta.Text.Trim & "'", "idCuenta", sUsuario, sPassword, sSucursal)
                If ds.Tables("Catalogo").Rows.Count > 0 Then
                    dr = ds.Tables("Catalogo").Rows(0)
                    Me.txtCuenta.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                End If
            End If
        End If
    End Sub


    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim ofrm As New frmMsCaDetTransfAuxCtaCont
            ofrm.NoCuenta = Me.c1txtCuenta.Value
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

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
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

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Try
            Dim ds As New DataSet
            Dim oCaja As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
            ds = oCaja.NotaCargo(pCodTransferencia, Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 56, 0)
            ofrm.ShowDialog()
            Limpiar()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btBorrar1_Click(sender As Object, e As EventArgs) Handles btBorrar1.Click
        Limpiar()
    End Sub

    Private Sub btNProcesar1_Click(sender As Object, e As EventArgs) Handles btNProcesar1.Click
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim dsDestino As New DataSet
        'Dim saldoCapDB, montoCtaDest
        Dim oAhorro As New wrAhorro.wsLibAhorro, oAsoc As New wrAsociados.wsLibAsoc
        Dim CamposValores As String, pFiltro As String, noCuentaDestino As String, noCuentaOrigen As String, pResponse As String
        Dim saldoCtaDispoDB As Double, saldoCtaDB As Double, saldoAnterior As Double, montoCtaOrig As Double, saldoActual As Double, pMontoParam As Double
        Dim dsOrigen As New DataSet, dr As DataRow, dsAhorro As New DataSet, drAhorro As DataRow, dsPar As New DataSet, drPar As DataRow
        Try
            If Math.Round(pSaldoOrigen, 2) >= Math.Round(CDbl(Me.c1txtMonto.Text), 2) Then
            Else
                MessageBox.Show("El Monto de Retiro es mayor que el Saldo disponible.", "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.txtIdCuenta.Text.Trim = "" Then
                MessageBox.Show("La Cuenta Contable no puede quedar vacía.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
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
                            Dim ofrmAut As New frmMsAutorizacion
                            ofrmAut.TipoPermiso = "P"
                            ofrmAut.NumPrograma = "AHG010"
                            ofrmAut.ShowDialog()
                            If ofrmAut.Autoriza = True Then
                                'Cancelar la Cuenta
                                dsPar = oAsoc.ConsultarParametros("*", "", "SalarioMinimo", sUsuario, sPassword, sSucursal)
                                If dsPar.Tables(0).Rows.Count > 0 Then
                                    drPar = dsPar.Tables(0).Rows(0)
                                    pMontoParam = IIf(IsDBNull(drPar("MontoDPF")), 0, drPar("MontoDPF"))
                                Else
                                    pMontoParam = 0
                                End If
                                'Dim ofrmCC As New frmMsAhCancelaCuenta
                                'If Me.txtCodTipo.Text.Trim.Substring(0, 1) = "2" Then
                                '    If pSaldoOrigen >= pMontoParam Then
                                '        ofrmCC.vAplicaAut = True
                                '    Else
                                '        ofrmCC.vAplicaAut = False
                                '    End If
                                'Else
                                '    ofrmCC.vAplicaAut = False
                                'End If
                                'ofrmCC.vCUsuario = ofrmAut.Usuario
                                'ofrmCC.vCPassword = ofrmAut.Password
                                'ofrmCC.NoCaja = "0"
                                'ofrmCC.CodCajero = "0"
                                'ofrmCC.NoCuenta = Me.c1txtCuenta.Text.Trim
                                'ofrmCC.CodTipoAhorro = Me.txtCodTipo.Text.Trim
                                'ofrmCC.ShowDialog()
                                'If ofrmCC.Autorizado = False Then
                                '    MessageBox.Show("La cuenta no se ha cancelado, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                '    Exit Sub
                                'Else
                                '    vCancela = True
                                '    CargaDatosCuentaCancelada()
                                '    MessageBox.Show("Cuenta cancelada.", "Cancelación de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                '    Exit Sub
                                'End If
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
            pCodTransferencia = oAhorro.ObtenerCorrelativoTransferencia("CodTransferencia", "1", "(MONTH(Fecha) = '" & Me.dtpFecha.Value.Month & "')  AND (YEAR(Fecha) = " & Me.dtpFecha.Value.Year & ")", sUsuario, sPassword, sSucursal)
            pResponse = oAhorro.TransferenciaCuentas(Me.c1txtNoDoc.Text.Trim, "1", Me.dtpFecha.Value.ToShortDateString, Me.txtDui.Value, Me.txtNoSocio.Text.Trim, Me.txtResponsable.Text.Trim, CDbl(Me.c1txtMonto.Text), Me.c1txtObservaciones.Text.Trim, Me.c1txtCuenta.Text.Trim, pCodTransferencia, Me.txtIdCuenta.Text.Trim, Me.txtCodTipo.Text.Trim, dsDetalle, pCodTransaccion, "M", Me.c1txtNombreAsoc.Text.Trim, "0", sUsuario, sPassword, sSucursal, Cod_Costo)
            If pResponse <> "" Then
                MessageBox.Show(pResponse, "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                MessageBox.Show("Transferencia realizada.", "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btnImprimir1.Enabled = True
                Me.btNProcesar1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub c1txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles c1txtCuenta.TextChanged

    End Sub

    Private Sub c1txtCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1txtCuenta.LostFocus
        If Me.c1txtCuenta.Text.Trim <> "" Then
            Me.btnAgregar1.Enabled = True
        Else
            Me.btnAgregar1.Enabled = False
        End If
    End Sub

    Private Sub CargaDatosCuentaCancelada()

        Dim ds As New DataSet, oAh As New wrAhorro.wsLibAhorro, dr As DataRow
        ds = oAh.ConsultarCtasAhorroDUI("a.CodTipoAhorro as Codigo,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.SaldoDisponible_CuentaAhorro as Saldo,b.IdCuenta as Cuenta_Contable,Pignorado", "a.Nocuenta='" & Me.c1txtCuenta.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count > 0 Then
            dr = ds.Tables(0).Rows(0)
            pSaldoOrigen = dr("Saldo")
            Me.c1txtMonto.Value = pSaldoOrigen
        End If
        Me.c1txtCuenta.Enabled = False
        Me.c1txtMonto.Enabled = False
        Me.btBorrar1.Enabled = False
        '  Me.btSalir.Enabled = False
        Me.txtDui.Enabled = False
        pCodTransaccion = "CAN"

    End Sub

    Private Sub frmMCaTransfAuxCtaCont_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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

    Private Sub SumaDetalle()
        Dim pSum As Double, dr As DataRow, x As Integer
        x = 0
        For Each dr In dsDetalle.Tables(0).Rows
            pSum = pSum + dr("Valor")
        Next
        If x > 0 Then
            Me.c1txtCuenta.Enabled = False
            Me.c1txtMonto.Enabled = False
        Else
            Me.c1txtCuenta.Enabled = True
            Me.c1txtMonto.Enabled = True
        End If
        pSum = Me.c1txtMonto.Text - pSum
        Me.txtTotal.Text = "Pendiente: $" & pSum
    End Sub

End Class