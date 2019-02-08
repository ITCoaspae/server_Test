Imports System.ComponentModel

Public Class frmMCaTransferenciaContable
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Private sNoCuenta As String ', sSupervisor As String, pPassword As String
    Public dsDetalle As New DataSet, pCodTransferencia As String
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btBorrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Dim Bancos As New wrBancos.wsLibBancos
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtResponsable As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCentroCosto As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtNoSocio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents c1txtNombreAsoc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCuenta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents c1txtObservaciones As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Dim CCodCosto As String
    Dim contabilidad As New wrConta.wsLibContab
    Friend WithEvents txtIdCuenta As TextBox
    Dim asociados As New wrAsociados.wsLibAsoc

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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtNoDoc As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents chkMembresia As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCaTransferenciaContable))
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.chkMembresia = New System.Windows.Forms.CheckBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.c1txtNoDoc = New C1.Win.C1Input.C1TextBox()
        Me.c1txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.btNProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.btBorrar1 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFecha = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtResponsable = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.cbCentroCosto = New MetroFramework.Controls.MetroComboBox()
        Me.txtNoSocio = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.c1txtNombreAsoc = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtCuenta = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.c1txtObservaciones = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(119, 434)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 33)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 25
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 434)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 33)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 24
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(421, 445)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(221, 22)
        Me.txtTotal.TabIndex = 26
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.Location = New System.Drawing.Point(23, 479)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(619, 191)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 27
        '
        'chkMembresia
        '
        Me.chkMembresia.Location = New System.Drawing.Point(23, 307)
        Me.chkMembresia.Name = "chkMembresia"
        Me.chkMembresia.Size = New System.Drawing.Size(199, 25)
        Me.chkMembresia.TabIndex = 18
        Me.chkMembresia.Text = "&Membresía de Aspirantes"
        Me.chkMembresia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(140, 189)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(115, 20)
        Me.txtDui.TabIndex = 8
        Me.txtDui.Tag = Nothing
        '
        'c1txtNoDoc
        '
        Me.c1txtNoDoc.BackColor = System.Drawing.Color.White
        Me.c1txtNoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNoDoc.CustomFormat = "00000000000000000000"
        Me.c1txtNoDoc.DataType = GetType(Long)
        Me.c1txtNoDoc.Location = New System.Drawing.Point(140, 160)
        Me.c1txtNoDoc.MaxLength = 14
        Me.c1txtNoDoc.Name = "c1txtNoDoc"
        Me.c1txtNoDoc.NumericInput = False
        Me.c1txtNoDoc.Size = New System.Drawing.Size(502, 20)
        Me.c1txtNoDoc.TabIndex = 6
        Me.c1txtNoDoc.Tag = Nothing
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
        Me.c1txtMonto.Location = New System.Drawing.Point(434, 312)
        Me.c1txtMonto.Name = "c1txtMonto"
        Me.c1txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(0R, Nothing, True, True)})
        Me.c1txtMonto.Size = New System.Drawing.Size(208, 23)
        Me.c1txtMonto.TabIndex = 20
        Me.c1txtMonto.Tag = Nothing
        Me.c1txtMonto.Value = 0R
        Me.c1txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'btNProcesar1
        '
        Me.btNProcesar1.Location = New System.Drawing.Point(363, 676)
        Me.btNProcesar1.Name = "btNProcesar1"
        Me.btNProcesar1.Size = New System.Drawing.Size(90, 32)
        Me.btNProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNProcesar1.TabIndex = 28
        Me.btNProcesar1.Text = "Procesar"
        Me.btNProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNProcesar1.UseSelectable = True
        Me.btNProcesar1.UseStyleColors = True
        '
        'btBorrar1
        '
        Me.btBorrar1.Location = New System.Drawing.Point(460, 676)
        Me.btBorrar1.Name = "btBorrar1"
        Me.btBorrar1.Size = New System.Drawing.Size(90, 32)
        Me.btBorrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btBorrar1.TabIndex = 29
        Me.btBorrar1.Text = "Borrar"
        Me.btBorrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btBorrar1.UseSelectable = True
        Me.btBorrar1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(557, 676)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(90, 32)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 30
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(135, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Origen Fondos:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 95)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(49, 20)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(140, 95)
        Me.dtpFecha.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(502, 30)
        Me.dtpFecha.TabIndex = 2
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 128)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(90, 20)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Responsable:"
        '
        'txtResponsable
        '
        Me.txtResponsable.Enabled = False
        Me.txtResponsable.Lines = New String() {"MetroTextBox1"}
        Me.txtResponsable.Location = New System.Drawing.Point(140, 131)
        Me.txtResponsable.MaxLength = 32767
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResponsable.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtResponsable.SelectedText = ""
        Me.txtResponsable.Size = New System.Drawing.Size(502, 23)
        Me.txtResponsable.TabIndex = 4
        Me.txtResponsable.Text = "MetroTextBox1"
        Me.txtResponsable.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 160)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(111, 20)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "No. Documento:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 189)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(35, 20)
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "DUI:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 276)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(93, 20)
        Me.MetroLabel6.TabIndex = 16
        Me.MetroLabel6.Text = "Centro Costo:"
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.FormattingEnabled = True
        Me.cbCentroCosto.ItemHeight = 24
        Me.cbCentroCosto.Location = New System.Drawing.Point(140, 276)
        Me.cbCentroCosto.Name = "cbCentroCosto"
        Me.cbCentroCosto.Size = New System.Drawing.Size(502, 30)
        Me.cbCentroCosto.TabIndex = 17
        Me.cbCentroCosto.UseSelectable = True
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Enabled = False
        Me.txtNoSocio.Lines = New String(-1) {}
        Me.txtNoSocio.Location = New System.Drawing.Point(470, 189)
        Me.txtNoSocio.MaxLength = 32767
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoSocio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNoSocio.SelectedText = ""
        Me.txtNoSocio.Size = New System.Drawing.Size(172, 23)
        Me.txtNoSocio.TabIndex = 10
        Me.txtNoSocio.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(370, 189)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(94, 20)
        Me.MetroLabel7.TabIndex = 9
        Me.MetroLabel7.Text = "No. Asociado:"
        '
        'c1txtNombreAsoc
        '
        Me.c1txtNombreAsoc.Enabled = False
        Me.c1txtNombreAsoc.Lines = New String(-1) {}
        Me.c1txtNombreAsoc.Location = New System.Drawing.Point(140, 218)
        Me.c1txtNombreAsoc.MaxLength = 32767
        Me.c1txtNombreAsoc.Name = "c1txtNombreAsoc"
        Me.c1txtNombreAsoc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.c1txtNombreAsoc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.c1txtNombreAsoc.SelectedText = ""
        Me.c1txtNombreAsoc.Size = New System.Drawing.Size(502, 23)
        Me.c1txtNombreAsoc.TabIndex = 12
        Me.c1txtNombreAsoc.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(23, 218)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(68, 20)
        Me.MetroLabel8.TabIndex = 11
        Me.MetroLabel8.Text = "Asociado:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(23, 247)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(115, 20)
        Me.MetroLabel9.TabIndex = 13
        Me.MetroLabel9.Text = "Cuenta Contable:"
        Me.MetroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuenta
        '
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Lines = New String(-1) {}
        Me.txtCuenta.Location = New System.Drawing.Point(261, 247)
        Me.txtCuenta.MaxLength = 32767
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuenta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCuenta.SelectedText = ""
        Me.txtCuenta.Size = New System.Drawing.Size(381, 23)
        Me.txtCuenta.TabIndex = 15
        Me.txtCuenta.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(376, 312)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(52, 20)
        Me.MetroLabel10.TabIndex = 19
        Me.MetroLabel10.Text = "Monto:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(23, 343)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(105, 20)
        Me.MetroLabel11.TabIndex = 21
        Me.MetroLabel11.Text = "Observaciones:"
        '
        'c1txtObservaciones
        '
        Me.c1txtObservaciones.Lines = New String(-1) {}
        Me.c1txtObservaciones.Location = New System.Drawing.Point(140, 341)
        Me.c1txtObservaciones.MaxLength = 32767
        Me.c1txtObservaciones.Multiline = True
        Me.c1txtObservaciones.Name = "c1txtObservaciones"
        Me.c1txtObservaciones.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.c1txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.c1txtObservaciones.SelectedText = ""
        Me.c1txtObservaciones.Size = New System.Drawing.Size(502, 57)
        Me.c1txtObservaciones.TabIndex = 22
        Me.c1txtObservaciones.UseSelectable = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.Location = New System.Drawing.Point(23, 396)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(77, 25)
        Me.MetroLabel12.TabIndex = 23
        Me.MetroLabel12.Text = "Destino:"
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Location = New System.Drawing.Point(140, 247)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(115, 22)
        Me.txtIdCuenta.TabIndex = 14
        '
        'frmMCaTransferenciaContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(670, 791)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.c1txtObservaciones)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.c1txtNombreAsoc)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.cbCentroCosto)
        Me.Controls.Add(Me.c1txtNoDoc)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.chkMembresia)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtResponsable)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.c1txtMonto)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btNProcesar1)
        Me.Controls.Add(Me.btBorrar1)
        Me.Controls.Add(Me.btnImprimir1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(670, 791)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(670, 791)
        Me.Name = "frmMCaTransferenciaContable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Transferencia entre cuentas contables"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub frmMCaTransferenciaContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAh As New wrAhorro.wsLibAhorro
        Me.txtResponsable.Text = sUsuario 'Me.Supervisor
        dsDetalle = oAh.ObtenerDetalleTransferenciaVacio
        llenarCbCC()
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
        Dim oAh As wrAhorro.wsLibAhorro, oAsoc As wrAsociados.wsLibAsoc
        Dim dr As DataRow, ds As New Data.DataSet

        Try
            oAh = New wrAhorro.wsLibAhorro
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres+' '+Apellido1+' '+Apellido2+' '+ApellidoCas as NombreAsociado,NoSocio", "Dui='" & Me.txtDui.Value & "'", "DUI", sUsuario, sPassword, sSucursal)
            If ds.Tables("Cat_Asociados").Rows.Count > 0 Then
                dr = ds.Tables("Cat_Asociados").Rows(0)
                Me.txtDui.Value = dr("Dui")
                Me.c1txtNombreAsoc.Text = dr("NombreAsociado")
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
        Dim sNomb, campos As String ', var As Integer, corrDic As Integer
        'Dim dr As DataRow, 
        Dim ds As New Data.DataSet
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
                Me.c1txtNombreAsoc.Text = sNomb
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
        Me.c1txtNombreAsoc.Text = ""
        Me.c1txtObservaciones.Text = ""
        Me.c1txtMonto.Value = 0
        Me.btnAgregar1.Enabled = False
        Me.fg.DataSource = ds
        Me.dsDetalle.Clear()
        Me.txtDui.Focus()
        Me.btnImprimir1.Enabled = False
        pCodTransferencia = ""
        Me.btNProcesar1.Enabled = True
    End Sub



    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txtDui_LostFocus(sender, e)
        End If
    End Sub

    Private Sub btNProcesar1_Click(sender As Object, e As EventArgs) Handles btNProcesar1.Click
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim dsDestino As New DataSet
        Dim oAhorro As New wrAhorro.wsLibAhorro
        Dim pResponse As String
        Dim dsOrigen As New DataSet ', dr As DataRow
        Dim resultado As Integer
        Try
            If chkMembresia.Checked = True Then
                If (asociados.AperturaCtaAportacionesTransferencia(c1txtNoDoc.Value, "0", dtpFecha.Value.ToShortDateString, txtDui.Value, txtNoSocio.Text, txtResponsable.Text.ToUpper,
                                                                           c1txtMonto.Value, c1txtObservaciones.Text.ToUpper, sUsuario, "0", "N", "M", "1", txtIdCuenta.Text, cbCentroCosto.SelectedValue)) > 0 Then
                    MsgBox("Transferencia realizada exitosamente.", MsgBoxStyle.Information)
                Else
                    MsgBox(mensajeError, MsgBoxStyle.Critical)
                End If
            Else
                pCodTransferencia = oAhorro.ObtenerCorrelativoTransferencia("CodTransferencia", "0", "(MONTH(Fecha) = '" & Me.dtpFecha.Value.Month & "')  AND (YEAR(Fecha) = " & Me.dtpFecha.Value.Year & ")", sUsuario, sPassword, sSucursal)
                pResponse = oAhorro.TransferenciaCuentas(Me.c1txtNoDoc.Text.Trim, "0", Me.dtpFecha.Value.ToShortDateString, Me.txtDui.Value, Me.txtNoSocio.Text.Trim, Me.txtResponsable.Text.Trim, CDbl(Me.c1txtMonto.Text), Me.c1txtObservaciones.Text.Trim, Me.txtIdCuenta.Text.Trim, pCodTransferencia, Me.txtIdCuenta.Text.Trim, "", dsDetalle, "", "M", Me.c1txtNombreAsoc.Text.Trim, IIf(Me.chkMembresia.Checked = True, "1", "0"), sUsuario, sPassword, sSucursal, cbCentroCosto.SelectedValue)
                If pResponse <> "" Then
                    MessageBox.Show(pResponse, "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    MessageBox.Show("Transferencia realizada.", "Transferencia de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.btnImprimir1.Enabled = True
                    Me.btNProcesar1.Enabled = False
                End If
            End If

        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btBorrar1_Click(sender As Object, e As EventArgs) Handles btBorrar1.Click
        Try
            Limpiar()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
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
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim ofrm As New frmMsCaDetTransfContable
            ofrm.NoCuenta = Me.txtIdCuenta.Text.Trim
            ofrm.Dui = Me.txtDui.Value
            ofrm.Fecha = Me.dtpFecha.Value
            ofrm.FrmT = Me
            ofrm.ShowDialog()
            fg.DataSource = dsDetalle.Tables(0)
            fg.Refresh()
            Encabezado()
            SumaDetalle()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If fg.Row <> -1 Then
                Dim pNocuenta As String
                pNocuenta = Trim(fg.Item(fg.Row, "NoCuenta")).ToString
                If MessageBox.Show("¿Está seguro que desea eliminar la Cuenta " & pNocuenta & "?", "Transferencia Cuentas Contables", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub SumaDetalle()
        Dim pSum As Double, dr As DataRow, x As Integer
        x = 0
        For Each dr In dsDetalle.Tables(0).Rows
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
    Private Sub llenarCbCC()
        Dim dts As New DataSet
        Dim campos As String
        campos = "Cod_CCosto,Descripcion"
        dts = contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, campos, " FINAL = 'S' ", "Descripcion", sUsuario, sPassword, sSucursal)
        cbCentroCosto.DisplayMember = "Descripcion"
        cbCentroCosto.ValueMember = "Cod_CCosto"
        cbCentroCosto.DataSource = dts.Tables(0)
    End Sub

    Private Sub c1txtMonto_Validating(sender As Object, e As CancelEventArgs) Handles c1txtMonto.Validating
        SumaDetalle()
    End Sub

    Private Sub chkMembresia_CheckedChanged(sender As Object, e As EventArgs) Handles chkMembresia.CheckedChanged
        Try
            If chkMembresia.Checked = True Then
                Dim dts As New DataSet
                Dim dtsCuota As New DataSet
                dts = asociados.ConsultarEstadoIngreso("codCuota", " a.nosocio = '" & txtNoSocio.Text & "'", "", sUsuario, sPassword, sSucursal)
                If dts.Tables(0).Rows.Count > 0 Then
                    dtsCuota = asociados.ConsultarTipoCuota("valor_total", " codCuota = '" & dts.Tables(0).Rows(0).Item(0).ToString & "'", "", sUsuario, sPassword, sSucursal)
                    c1txtMonto.Value = dtsCuota.Tables(0).Rows(0).Item(0)
                    c1txtMonto.Enabled = False
                    btnAgregar1.Enabled = False
                    txtTotal.Text = 0
                    txtTotal.Enabled = False
                End If
            Else
                Limpiar()
                c1txtMonto.Enabled = True
                btnAgregar1.Enabled = True
                txtTotal.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub txtIdCuenta_DoubleClick(sender As Object, e As EventArgs) Handles txtIdCuenta.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("idCuenta,Descripcion", "Final='S' and Inhabilitado = 'N' ", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtIdCuenta.Text = ofrm.Resultado.Trim
            Me.txtCuenta.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class