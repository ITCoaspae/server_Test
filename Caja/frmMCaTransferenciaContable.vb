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
        Me.btnEliminar1.Location = New System.Drawing.Point(99, 376)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 29)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 25
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(19, 376)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 29)
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
        Me.txtTotal.Location = New System.Drawing.Point(351, 386)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(184, 20)
        Me.txtTotal.TabIndex = 26
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(19, 415)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(516, 166)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 27
        '
        'chkMembresia
        '
        Me.chkMembresia.Location = New System.Drawing.Point(19, 266)
        Me.chkMembresia.Name = "chkMembresia"
        Me.chkMembresia.Size = New System.Drawing.Size(166, 22)
        Me.chkMembresia.TabIndex = 18
        Me.chkMembresia.Text = "&Membresía de Aspirantes"
        Me.chkMembresia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(117, 164)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(95, 18)
        Me.txtDui.TabIndex = 8
        Me.txtDui.Tag = Nothing
        '
        'c1txtNoDoc
        '
        Me.c1txtNoDoc.BackColor = System.Drawing.Color.White
        Me.c1txtNoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNoDoc.CustomFormat = "00000000000000000000"
        Me.c1txtNoDoc.DataType = GetType(Long)
        Me.c1txtNoDoc.Location = New System.Drawing.Point(117, 139)
        Me.c1txtNoDoc.MaxLength = 14
        Me.c1txtNoDoc.Name = "c1txtNoDoc"
        Me.c1txtNoDoc.NumericInput = False
        Me.c1txtNoDoc.Size = New System.Drawing.Size(418, 18)
        Me.c1txtNoDoc.TabIndex = 6
        Me.c1txtNoDoc.Tag = Nothing
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
        Me.c1txtMonto.Location = New System.Drawing.Point(362, 270)
        Me.c1txtMonto.Name = "c1txtMonto"
        Me.c1txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(0R, Nothing, True, True)})
        Me.c1txtMonto.Size = New System.Drawing.Size(173, 19)
        Me.c1txtMonto.TabIndex = 20
        Me.c1txtMonto.Tag = Nothing
        Me.c1txtMonto.Value = 0R
        Me.c1txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'btNProcesar1
        '
        Me.btNProcesar1.Location = New System.Drawing.Point(302, 586)
        Me.btNProcesar1.Name = "btNProcesar1"
        Me.btNProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btNProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNProcesar1.TabIndex = 28
        Me.btNProcesar1.Text = "Procesar"
        Me.btNProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNProcesar1.UseSelectable = True
        Me.btNProcesar1.UseStyleColors = True
        '
        'btBorrar1
        '
        Me.btBorrar1.Location = New System.Drawing.Point(383, 586)
        Me.btBorrar1.Name = "btBorrar1"
        Me.btBorrar1.Size = New System.Drawing.Size(75, 28)
        Me.btBorrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btBorrar1.TabIndex = 29
        Me.btBorrar1.Text = "Borrar"
        Me.btBorrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btBorrar1.UseSelectable = True
        Me.btBorrar1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(464, 586)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(75, 28)
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
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 52)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(129, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Origen Fondos:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(19, 82)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(117, 82)
        Me.dtpFecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(418, 29)
        Me.dtpFecha.TabIndex = 2
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(19, 111)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Responsable:"
        '
        'txtResponsable
        '
        '
        '
        '
        Me.txtResponsable.CustomButton.Image = Nothing
        Me.txtResponsable.CustomButton.Location = New System.Drawing.Point(400, 1)
        Me.txtResponsable.CustomButton.Name = ""
        Me.txtResponsable.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtResponsable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtResponsable.CustomButton.TabIndex = 1
        Me.txtResponsable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtResponsable.CustomButton.UseSelectable = True
        Me.txtResponsable.CustomButton.Visible = False
        Me.txtResponsable.Enabled = False
        Me.txtResponsable.Lines = New String() {"MetroTextBox1"}
        Me.txtResponsable.Location = New System.Drawing.Point(117, 114)
        Me.txtResponsable.MaxLength = 32767
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResponsable.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtResponsable.SelectedText = ""
        Me.txtResponsable.SelectionLength = 0
        Me.txtResponsable.SelectionStart = 0
        Me.txtResponsable.ShortcutsEnabled = True
        Me.txtResponsable.Size = New System.Drawing.Size(418, 19)
        Me.txtResponsable.TabIndex = 4
        Me.txtResponsable.Text = "MetroTextBox1"
        Me.txtResponsable.UseSelectable = True
        Me.txtResponsable.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtResponsable.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(19, 139)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "No. Documento:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(19, 164)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "DUI:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(19, 239)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel6.TabIndex = 16
        Me.MetroLabel6.Text = "Centro Costo:"
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.FormattingEnabled = True
        Me.cbCentroCosto.ItemHeight = 23
        Me.cbCentroCosto.Location = New System.Drawing.Point(117, 239)
        Me.cbCentroCosto.Name = "cbCentroCosto"
        Me.cbCentroCosto.Size = New System.Drawing.Size(418, 29)
        Me.cbCentroCosto.TabIndex = 17
        Me.cbCentroCosto.UseSelectable = True
        '
        'txtNoSocio
        '
        '
        '
        '
        Me.txtNoSocio.CustomButton.Image = Nothing
        Me.txtNoSocio.CustomButton.Location = New System.Drawing.Point(125, 2)
        Me.txtNoSocio.CustomButton.Name = ""
        Me.txtNoSocio.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtNoSocio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNoSocio.CustomButton.TabIndex = 1
        Me.txtNoSocio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNoSocio.CustomButton.UseSelectable = True
        Me.txtNoSocio.CustomButton.Visible = False
        Me.txtNoSocio.Enabled = False
        Me.txtNoSocio.Lines = New String(-1) {}
        Me.txtNoSocio.Location = New System.Drawing.Point(392, 164)
        Me.txtNoSocio.MaxLength = 32767
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoSocio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNoSocio.SelectedText = ""
        Me.txtNoSocio.SelectionLength = 0
        Me.txtNoSocio.SelectionStart = 0
        Me.txtNoSocio.ShortcutsEnabled = True
        Me.txtNoSocio.Size = New System.Drawing.Size(143, 20)
        Me.txtNoSocio.TabIndex = 10
        Me.txtNoSocio.UseSelectable = True
        Me.txtNoSocio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNoSocio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(308, 164)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel7.TabIndex = 9
        Me.MetroLabel7.Text = "No. Asociado:"
        '
        'c1txtNombreAsoc
        '
        '
        '
        '
        Me.c1txtNombreAsoc.CustomButton.Image = Nothing
        Me.c1txtNombreAsoc.CustomButton.Location = New System.Drawing.Point(400, 2)
        Me.c1txtNombreAsoc.CustomButton.Name = ""
        Me.c1txtNombreAsoc.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.c1txtNombreAsoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.c1txtNombreAsoc.CustomButton.TabIndex = 1
        Me.c1txtNombreAsoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.c1txtNombreAsoc.CustomButton.UseSelectable = True
        Me.c1txtNombreAsoc.CustomButton.Visible = False
        Me.c1txtNombreAsoc.Enabled = False
        Me.c1txtNombreAsoc.Lines = New String(-1) {}
        Me.c1txtNombreAsoc.Location = New System.Drawing.Point(117, 189)
        Me.c1txtNombreAsoc.MaxLength = 32767
        Me.c1txtNombreAsoc.Name = "c1txtNombreAsoc"
        Me.c1txtNombreAsoc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.c1txtNombreAsoc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.c1txtNombreAsoc.SelectedText = ""
        Me.c1txtNombreAsoc.SelectionLength = 0
        Me.c1txtNombreAsoc.SelectionStart = 0
        Me.c1txtNombreAsoc.ShortcutsEnabled = True
        Me.c1txtNombreAsoc.Size = New System.Drawing.Size(418, 20)
        Me.c1txtNombreAsoc.TabIndex = 12
        Me.c1txtNombreAsoc.UseSelectable = True
        Me.c1txtNombreAsoc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.c1txtNombreAsoc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(19, 189)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel8.TabIndex = 11
        Me.MetroLabel8.Text = "Asociado:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(19, 214)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel9.TabIndex = 13
        Me.MetroLabel9.Text = "Cuenta Contable:"
        Me.MetroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuenta
        '
        '
        '
        '
        Me.txtCuenta.CustomButton.Image = Nothing
        Me.txtCuenta.CustomButton.Location = New System.Drawing.Point(300, 2)
        Me.txtCuenta.CustomButton.Name = ""
        Me.txtCuenta.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCuenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCuenta.CustomButton.TabIndex = 1
        Me.txtCuenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCuenta.CustomButton.UseSelectable = True
        Me.txtCuenta.CustomButton.Visible = False
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Lines = New String(-1) {}
        Me.txtCuenta.Location = New System.Drawing.Point(217, 214)
        Me.txtCuenta.MaxLength = 32767
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuenta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCuenta.SelectedText = ""
        Me.txtCuenta.SelectionLength = 0
        Me.txtCuenta.SelectionStart = 0
        Me.txtCuenta.ShortcutsEnabled = True
        Me.txtCuenta.Size = New System.Drawing.Size(318, 20)
        Me.txtCuenta.TabIndex = 15
        Me.txtCuenta.UseSelectable = True
        Me.txtCuenta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCuenta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(313, 270)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel10.TabIndex = 19
        Me.MetroLabel10.Text = "Monto:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(19, 297)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel11.TabIndex = 21
        Me.MetroLabel11.Text = "Observaciones:"
        '
        'c1txtObservaciones
        '
        '
        '
        '
        Me.c1txtObservaciones.CustomButton.Image = Nothing
        Me.c1txtObservaciones.CustomButton.Location = New System.Drawing.Point(370, 1)
        Me.c1txtObservaciones.CustomButton.Name = ""
        Me.c1txtObservaciones.CustomButton.Size = New System.Drawing.Size(47, 47)
        Me.c1txtObservaciones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.c1txtObservaciones.CustomButton.TabIndex = 1
        Me.c1txtObservaciones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.c1txtObservaciones.CustomButton.UseSelectable = True
        Me.c1txtObservaciones.CustomButton.Visible = False
        Me.c1txtObservaciones.Lines = New String(-1) {}
        Me.c1txtObservaciones.Location = New System.Drawing.Point(117, 296)
        Me.c1txtObservaciones.MaxLength = 32767
        Me.c1txtObservaciones.Multiline = True
        Me.c1txtObservaciones.Name = "c1txtObservaciones"
        Me.c1txtObservaciones.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.c1txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.c1txtObservaciones.SelectedText = ""
        Me.c1txtObservaciones.SelectionLength = 0
        Me.c1txtObservaciones.SelectionStart = 0
        Me.c1txtObservaciones.ShortcutsEnabled = True
        Me.c1txtObservaciones.Size = New System.Drawing.Size(418, 49)
        Me.c1txtObservaciones.TabIndex = 22
        Me.c1txtObservaciones.UseSelectable = True
        Me.c1txtObservaciones.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.c1txtObservaciones.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.Location = New System.Drawing.Point(19, 343)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(73, 25)
        Me.MetroLabel12.TabIndex = 23
        Me.MetroLabel12.Text = "Destino:"
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Location = New System.Drawing.Point(117, 214)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(95, 20)
        Me.txtIdCuenta.TabIndex = 14
        '
        'frmMCaTransferenciaContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(558, 686)
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
        Me.MaximumSize = New System.Drawing.Size(558, 686)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(558, 629)
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
        Me.MaximizeBox = False
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
                     MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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