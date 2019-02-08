Imports System.Data.SqlClient

Public Class frmMsCrControlEstado
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim libAhorro As New sifLib.Ahorro.clsAhorros
    Dim credito As New wrCredito.wsLibCred

    Public pNoSolic As Long, pCodEnlace As Long
    Friend WithEvents chkArreglo As System.Windows.Forms.CheckBox
    Friend WithEvents tbTrans As System.Windows.Forms.TabPage
    Friend WithEvents txtObsTran As System.Windows.Forms.TextBox
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoTrans As System.Windows.Forms.ComboBox
    Friend WithEvents chkPrincipal As System.Windows.Forms.CheckBox
    Friend WithEvents lblMontoTran As System.Windows.Forms.Label
    Friend WithEvents lblObservacionesTrans As System.Windows.Forms.Label
    Friend WithEvents lblNoctaAux As System.Windows.Forms.Label
    Friend WithEvents lblTipoTrans As System.Windows.Forms.Label
    Friend WithEvents gbDatosTransferencias As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dgTransferencias As System.Windows.Forms.DataGridView
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNoEnvAseg As System.Windows.Forms.RadioButton
    Friend WithEvents rbEnvAseg As System.Windows.Forms.RadioButton
    Friend WithEvents txtTasaExtPrima As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblTasaExtPrima As System.Windows.Forms.Label
    Friend WithEvents chkExtPrima As System.Windows.Forms.CheckBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTb1_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btGastosHonorarios1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btGastosTramitacion1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btGastosEscrituracion1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDel1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProcesarTran1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnTransferencia1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btAtrasTb2_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnAsinaTA1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtFechayHora As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtCodTablaAmortiza As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dgTabla As DataGridView

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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFec1Cuota As System.Windows.Forms.DateTimePicker
    Friend WithEvents C1NEMontoGarantia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents C1NEInteres As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecOtorgamiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaActa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNoActa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tbPpal As System.Windows.Forms.TabControl
    Friend WithEvents tbCheques As System.Windows.Forms.TabPage
    Friend WithEvents tbEstado As System.Windows.Forms.TabPage
    Friend WithEvents tbDeducciones As System.Windows.Forms.TabPage
    Friend WithEvents ttip As System.Windows.Forms.ToolTip
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents fgDeducciones As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents chkRef As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoRef As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents btImagen As System.Windows.Forms.Button
    Friend WithEvents chkGeneraReserva As System.Windows.Forms.CheckBox
    Friend WithEvents cbFormaPagoP2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents c1nCuota As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtPagaduria As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPagaduria As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtCodItem As System.Windows.Forms.TextBox
    Friend WithEvents chkCasoEspecial As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents tbCondiciones As System.Windows.Forms.TabPage
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCondicionEspecial As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCrControlEstado))
        Me.tbPpal = New System.Windows.Forms.TabControl()
        Me.tbEstado = New System.Windows.Forms.TabPage()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtCodItem = New System.Windows.Forms.TextBox()
        Me.c1nMontoRef = New C1.Win.C1Input.C1NumericEdit()
        Me.chkCasoEspecial = New System.Windows.Forms.CheckBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.chkRef = New System.Windows.Forms.CheckBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtPagaduria = New System.Windows.Forms.TextBox()
        Me.chkArreglo = New System.Windows.Forms.CheckBox()
        Me.txtCodPagaduria = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
        Me.chkGeneraReserva = New System.Windows.Forms.CheckBox()
        Me.btImagen = New System.Windows.Forms.Button()
        Me.c1nCuota = New C1.Win.C1Input.C1NumericEdit()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.C1NEMontoGarantia = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFec1Cuota = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodTipoCredito = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbConclusion = New System.Windows.Forms.ComboBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.cbFormaPagoP2 = New System.Windows.Forms.ComboBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.dtpFechaActa = New System.Windows.Forms.DateTimePicker()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.C1NEPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NEInteres = New C1.Win.C1Input.C1NumericEdit()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.dtpFecOtorgamiento = New System.Windows.Forms.DateTimePicker()
        Me.txtNoActa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbDeducciones = New System.Windows.Forms.TabPage()
        Me.btDel1 = New MetroFramework.Controls.MetroButton()
        Me.btGastosHonorarios1 = New MetroFramework.Controls.MetroButton()
        Me.btGastosTramitacion1 = New MetroFramework.Controls.MetroButton()
        Me.btGastosEscrituracion1 = New MetroFramework.Controls.MetroButton()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.fgDeducciones = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbCheques = New System.Windows.Forms.TabPage()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbTrans = New System.Windows.Forms.TabPage()
        Me.btnProcesarTran1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgTransferencias = New System.Windows.Forms.DataGridView()
        Me.gbDatosTransferencias = New System.Windows.Forms.GroupBox()
        Me.btnTransferencia1 = New MetroFramework.Controls.MetroButton()
        Me.txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.lblTipoTrans = New System.Windows.Forms.Label()
        Me.lblNoctaAux = New System.Windows.Forms.Label()
        Me.txtObsTran = New System.Windows.Forms.TextBox()
        Me.chkPrincipal = New System.Windows.Forms.CheckBox()
        Me.cbTipoTrans = New System.Windows.Forms.ComboBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lblObservacionesTrans = New System.Windows.Forms.Label()
        Me.lblMontoTran = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgTabla = New System.Windows.Forms.DataGridView()
        Me.btnAsinaTA1 = New MetroFramework.Controls.MetroButton()
        Me.txtFechayHora = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCodTablaAmortiza = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbCondiciones = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtTasaExtPrima = New C1.Win.C1Input.C1NumericEdit()
        Me.lblTasaExtPrima = New System.Windows.Forms.Label()
        Me.chkExtPrima = New System.Windows.Forms.CheckBox()
        Me.rbNoEnvAseg = New System.Windows.Forms.RadioButton()
        Me.rbEnvAseg = New System.Windows.Forms.RadioButton()
        Me.txtCondicionEspecial = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnSigTb1_1 = New MetroFramework.Controls.MetroButton()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.btAtrasTb2_1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.tbPpal.SuspendLayout()
        Me.tbEstado.SuspendLayout()
        CType(Me.c1nMontoRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMontoGarantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDeducciones.SuspendLayout()
        CType(Me.fgDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCheques.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbTrans.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosTransferencias.SuspendLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCondiciones.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.txtTasaExtPrima, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPpal
        '
        Me.tbPpal.Controls.Add(Me.tbEstado)
        Me.tbPpal.Controls.Add(Me.tbDeducciones)
        Me.tbPpal.Controls.Add(Me.tbCheques)
        Me.tbPpal.Controls.Add(Me.tbTrans)
        Me.tbPpal.Controls.Add(Me.TabPage1)
        Me.tbPpal.Controls.Add(Me.tbCondiciones)
        Me.tbPpal.Location = New System.Drawing.Point(28, 73)
        Me.tbPpal.Name = "tbPpal"
        Me.tbPpal.SelectedIndex = 0
        Me.tbPpal.Size = New System.Drawing.Size(739, 592)
        Me.tbPpal.TabIndex = 4
        '
        'tbEstado
        '
        Me.tbEstado.BackColor = System.Drawing.Color.White
        Me.tbEstado.Controls.Add(Me.txtItem)
        Me.tbEstado.Controls.Add(Me.txtCodTipoAhorro)
        Me.tbEstado.Controls.Add(Me.txtCodItem)
        Me.tbEstado.Controls.Add(Me.c1nMontoRef)
        Me.tbEstado.Controls.Add(Me.chkCasoEspecial)
        Me.tbEstado.Controls.Add(Me.lblCategoria)
        Me.tbEstado.Controls.Add(Me.Label19)
        Me.tbEstado.Controls.Add(Me.Label10)
        Me.tbEstado.Controls.Add(Me.txtCodigo)
        Me.tbEstado.Controls.Add(Me.chkRef)
        Me.tbEstado.Controls.Add(Me.txtEstado)
        Me.tbEstado.Controls.Add(Me.txtPagaduria)
        Me.tbEstado.Controls.Add(Me.chkArreglo)
        Me.tbEstado.Controls.Add(Me.txtCodPagaduria)
        Me.tbEstado.Controls.Add(Me.Label16)
        Me.tbEstado.Controls.Add(Me.Label77)
        Me.tbEstado.Controls.Add(Me.txtTipoCredito)
        Me.tbEstado.Controls.Add(Me.chkGeneraReserva)
        Me.tbEstado.Controls.Add(Me.btImagen)
        Me.tbEstado.Controls.Add(Me.c1nCuota)
        Me.tbEstado.Controls.Add(Me.txtArchivo)
        Me.tbEstado.Controls.Add(Me.C1NEMontoGarantia)
        Me.tbEstado.Controls.Add(Me.Label4)
        Me.tbEstado.Controls.Add(Me.dtpFec1Cuota)
        Me.tbEstado.Controls.Add(Me.Label5)
        Me.tbEstado.Controls.Add(Me.txtCodTipoCredito)
        Me.tbEstado.Controls.Add(Me.Label76)
        Me.tbEstado.Controls.Add(Me.txtNombre)
        Me.tbEstado.Controls.Add(Me.Label2)
        Me.tbEstado.Controls.Add(Me.txtNoCuenta)
        Me.tbEstado.Controls.Add(Me.Label8)
        Me.tbEstado.Controls.Add(Me.Label85)
        Me.tbEstado.Controls.Add(Me.txtNoSocio)
        Me.tbEstado.Controls.Add(Me.Label15)
        Me.tbEstado.Controls.Add(Me.cbConclusion)
        Me.tbEstado.Controls.Add(Me.Label68)
        Me.tbEstado.Controls.Add(Me.cbFormaPagoP2)
        Me.tbEstado.Controls.Add(Me.cbEstado)
        Me.tbEstado.Controls.Add(Me.dtpFechaActa)
        Me.tbEstado.Controls.Add(Me.txtObs)
        Me.tbEstado.Controls.Add(Me.Label9)
        Me.tbEstado.Controls.Add(Me.C1NEPlazo)
        Me.tbEstado.Controls.Add(Me.C1NEInteres)
        Me.tbEstado.Controls.Add(Me.Label67)
        Me.tbEstado.Controls.Add(Me.Label13)
        Me.tbEstado.Controls.Add(Me.Label6)
        Me.tbEstado.Controls.Add(Me.Label14)
        Me.tbEstado.Controls.Add(Me.Label17)
        Me.tbEstado.Controls.Add(Me.Label12)
        Me.tbEstado.Controls.Add(Me.Label3)
        Me.tbEstado.Controls.Add(Me.Label11)
        Me.tbEstado.Controls.Add(Me.Label40)
        Me.tbEstado.Controls.Add(Me.C1NEMonto)
        Me.tbEstado.Controls.Add(Me.dtpFecOtorgamiento)
        Me.tbEstado.Controls.Add(Me.txtNoActa)
        Me.tbEstado.Controls.Add(Me.Label1)
        Me.tbEstado.Location = New System.Drawing.Point(4, 25)
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(731, 563)
        Me.tbEstado.TabIndex = 0
        Me.tbEstado.Text = "Control del Estado"
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.White
        Me.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtItem.Location = New System.Drawing.Point(280, 490)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(432, 25)
        Me.txtItem.TabIndex = 178
        Me.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.BackColor = System.Drawing.Color.LightGray
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(299, 42)
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.ReadOnly = True
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(19, 22)
        Me.txtCodTipoAhorro.TabIndex = 168
        Me.txtCodTipoAhorro.Visible = False
        '
        'txtCodItem
        '
        Me.txtCodItem.BackColor = System.Drawing.Color.White
        Me.txtCodItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodItem.Location = New System.Drawing.Point(198, 490)
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.ReadOnly = True
        Me.txtCodItem.Size = New System.Drawing.Size(67, 25)
        Me.txtCodItem.TabIndex = 177
        Me.txtCodItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'c1nMontoRef
        '
        Me.c1nMontoRef.BackColor = System.Drawing.Color.White
        Me.c1nMontoRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoRef.CustomFormat = "###,###,##0.00"
        Me.c1nMontoRef.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoRef.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoRef.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMontoRef.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoRef.Location = New System.Drawing.Point(242, 464)
        Me.c1nMontoRef.Name = "c1nMontoRef"
        Me.c1nMontoRef.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoRef.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoRef.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoRef.ReadOnly = True
        Me.c1nMontoRef.Size = New System.Drawing.Size(101, 23)
        Me.c1nMontoRef.TabIndex = 1
        Me.c1nMontoRef.Tag = Nothing
        Me.c1nMontoRef.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoRef.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkCasoEspecial
        '
        Me.chkCasoEspecial.Location = New System.Drawing.Point(7, 489)
        Me.chkCasoEspecial.Name = "chkCasoEspecial"
        Me.chkCasoEspecial.Size = New System.Drawing.Size(162, 26)
        Me.chkCasoEspecial.TabIndex = 175
        Me.chkCasoEspecial.Text = "Caso especial"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.BackColor = System.Drawing.Color.White
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.Teal
        Me.lblCategoria.Location = New System.Drawing.Point(466, 399)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(55, 29)
        Me.lblCategoria.TabIndex = 179
        Me.lblCategoria.Text = "P/E"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(372, 405)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 17)
        Me.Label19.TabIndex = 180
        Me.Label19.Text = "Clasificación:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(194, 465)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 18)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Monto:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.ForeColor = System.Drawing.Color.Maroon
        Me.txtCodigo.Location = New System.Drawing.Point(470, 103)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(242, 22)
        Me.txtCodigo.TabIndex = 154
        '
        'chkRef
        '
        Me.chkRef.Location = New System.Drawing.Point(7, 464)
        Me.chkRef.Name = "chkRef"
        Me.chkRef.Size = New System.Drawing.Size(181, 18)
        Me.chkRef.TabIndex = 0
        Me.chkRef.Text = "Es un &refinanciamiento"
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.White
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEstado.ForeColor = System.Drawing.Color.Maroon
        Me.txtEstado.Location = New System.Drawing.Point(102, 103)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(241, 22)
        Me.txtEstado.TabIndex = 157
        '
        'txtPagaduria
        '
        Me.txtPagaduria.BackColor = System.Drawing.Color.White
        Me.txtPagaduria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPagaduria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagaduria.Location = New System.Drawing.Point(198, 434)
        Me.txtPagaduria.MaxLength = 100
        Me.txtPagaduria.Name = "txtPagaduria"
        Me.txtPagaduria.ReadOnly = True
        Me.txtPagaduria.Size = New System.Drawing.Size(514, 23)
        Me.txtPagaduria.TabIndex = 172
        '
        'chkArreglo
        '
        Me.chkArreglo.AutoSize = True
        Me.chkArreglo.Location = New System.Drawing.Point(7, 348)
        Me.chkArreglo.Name = "chkArreglo"
        Me.chkArreglo.Size = New System.Drawing.Size(137, 21)
        Me.chkArreglo.TabIndex = 178
        Me.chkArreglo.Text = "Arreglo por Mora"
        Me.chkArreglo.UseVisualStyleBackColor = True
        '
        'txtCodPagaduria
        '
        Me.txtCodPagaduria.BackColor = System.Drawing.Color.White
        Me.txtCodPagaduria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPagaduria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPagaduria.Location = New System.Drawing.Point(102, 434)
        Me.txtCodPagaduria.MaxLength = 10
        Me.txtCodPagaduria.Name = "txtCodPagaduria"
        Me.txtCodPagaduria.ReadOnly = True
        Me.txtCodPagaduria.Size = New System.Drawing.Size(77, 23)
        Me.txtCodPagaduria.TabIndex = 171
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(372, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 19)
        Me.Label16.TabIndex = 153
        Me.Label16.Text = "Código:"
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.Black
        Me.Label77.Location = New System.Drawing.Point(4, 429)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(76, 19)
        Me.Label77.TabIndex = 173
        Me.Label77.Text = "Pagaduría:"
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCredito.Enabled = False
        Me.txtTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCredito.Location = New System.Drawing.Point(205, 188)
        Me.txtTipoCredito.MaxLength = 100
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.ReadOnly = True
        Me.txtTipoCredito.Size = New System.Drawing.Size(507, 23)
        Me.txtTipoCredito.TabIndex = 176
        '
        'chkGeneraReserva
        '
        Me.chkGeneraReserva.Checked = True
        Me.chkGeneraReserva.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGeneraReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkGeneraReserva.Location = New System.Drawing.Point(7, 43)
        Me.chkGeneraReserva.Name = "chkGeneraReserva"
        Me.chkGeneraReserva.Size = New System.Drawing.Size(135, 18)
        Me.chkGeneraReserva.TabIndex = 11
        Me.chkGeneraReserva.Text = "&Genera Reserva"
        Me.chkGeneraReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btImagen
        '
        Me.btImagen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btImagen.Location = New System.Drawing.Point(894, 568)
        Me.btImagen.Name = "btImagen"
        Me.btImagen.Size = New System.Drawing.Size(29, 23)
        Me.btImagen.TabIndex = 13
        Me.btImagen.Text = "..."
        Me.btImagen.UseVisualStyleBackColor = False
        Me.btImagen.Visible = False
        '
        'c1nCuota
        '
        Me.c1nCuota.BackColor = System.Drawing.Color.White
        Me.c1nCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCuota.CustomFormat = "###,###,##0.00"
        Me.c1nCuota.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCuota.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCuota.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCuota.Location = New System.Drawing.Point(102, 372)
        Me.c1nCuota.Name = "c1nCuota"
        Me.c1nCuota.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCuota.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCuota.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCuota.Size = New System.Drawing.Size(241, 23)
        Me.c1nCuota.TabIndex = 9
        Me.c1nCuota.Tag = Nothing
        Me.c1nCuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCuota.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtArchivo
        '
        Me.txtArchivo.BackColor = System.Drawing.Color.White
        Me.txtArchivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivo.Location = New System.Drawing.Point(280, 42)
        Me.txtArchivo.MaxLength = 255
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(12, 23)
        Me.txtArchivo.TabIndex = 12
        Me.txtArchivo.Visible = False
        '
        'C1NEMontoGarantia
        '
        Me.C1NEMontoGarantia.BackColor = System.Drawing.Color.White
        Me.C1NEMontoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMontoGarantia.CustomFormat = "###,###,##0.00"
        Me.C1NEMontoGarantia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMontoGarantia.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMontoGarantia.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEMontoGarantia.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMontoGarantia.Location = New System.Drawing.Point(198, 403)
        Me.C1NEMontoGarantia.Name = "C1NEMontoGarantia"
        Me.C1NEMontoGarantia.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMontoGarantia.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMontoGarantia.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMontoGarantia.Size = New System.Drawing.Size(145, 23)
        Me.C1NEMontoGarantia.TabIndex = 11
        Me.C1NEMontoGarantia.Tag = Nothing
        Me.C1NEMontoGarantia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEMontoGarantia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(149, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 15)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Archivo Acta Consejo:"
        Me.Label4.Visible = False
        '
        'dtpFec1Cuota
        '
        Me.dtpFec1Cuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFec1Cuota.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFec1Cuota.Location = New System.Drawing.Point(470, 372)
        Me.dtpFec1Cuota.Name = "dtpFec1Cuota"
        Me.dtpFec1Cuota.Size = New System.Drawing.Size(242, 23)
        Me.dtpFec1Cuota.TabIndex = 10
        Me.dtpFec1Cuota.Value = New Date(2019, 2, 4, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 24)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Monto Garantía (Hipotecaria):"
        '
        'txtCodTipoCredito
        '
        Me.txtCodTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtCodTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoCredito.Location = New System.Drawing.Point(102, 188)
        Me.txtCodTipoCredito.MaxLength = 10
        Me.txtCodTipoCredito.Name = "txtCodTipoCredito"
        Me.txtCodTipoCredito.ReadOnly = True
        Me.txtCodTipoCredito.Size = New System.Drawing.Size(96, 23)
        Me.txtCodTipoCredito.TabIndex = 1
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.Black
        Me.Label76.Location = New System.Drawing.Point(4, 372)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(86, 15)
        Me.Label76.TabIndex = 165
        Me.Label76.Text = "Cuota:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.ForeColor = System.Drawing.Color.Teal
        Me.txtNombre.Location = New System.Drawing.Point(102, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(610, 22)
        Me.txtNombre.TabIndex = 155
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(372, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "1a. Cuota:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BackColor = System.Drawing.Color.White
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Enabled = False
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.Location = New System.Drawing.Point(102, 318)
        Me.txtNoCuenta.MaxLength = 25
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.ReadOnly = True
        Me.txtNoCuenta.Size = New System.Drawing.Size(241, 23)
        Me.txtNoCuenta.TabIndex = 166
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 33)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "*Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Crédito:"
        '
        'Label85
        '
        Me.Label85.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.Black
        Me.Label85.Location = New System.Drawing.Point(4, 308)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(104, 37)
        Me.Label85.TabIndex = 167
        Me.Label85.Text = "Nº Cuenta (Transferencia):"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.ForeColor = System.Drawing.Color.Teal
        Me.txtNoSocio.Location = New System.Drawing.Point(470, 43)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(242, 22)
        Me.txtNoSocio.TabIndex = 156
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(4, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 32)
        Me.Label15.TabIndex = 152
        Me.Label15.Text = "Estado del Préstamo:"
        '
        'cbConclusion
        '
        Me.cbConclusion.BackColor = System.Drawing.SystemColors.Window
        Me.cbConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConclusion.Enabled = False
        Me.cbConclusion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConclusion.Items.AddRange(New Object() {"(P) = En Proceso", "(R) = Rechazada", "(A) = Admitida"})
        Me.cbConclusion.Location = New System.Drawing.Point(470, 14)
        Me.cbConclusion.Name = "cbConclusion"
        Me.cbConclusion.Size = New System.Drawing.Size(242, 24)
        Me.cbConclusion.TabIndex = 148
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(4, 249)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(67, 34)
        Me.Label68.TabIndex = 163
        Me.Label68.Text = "*Forma " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Pago:"
        '
        'cbFormaPagoP2
        '
        Me.cbFormaPagoP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPagoP2.Items.AddRange(New Object() {"Pago personal", "Orden de descuento", "Cobro Directo", "Pago por Transferencia"})
        Me.cbFormaPagoP2.Location = New System.Drawing.Point(102, 249)
        Me.cbFormaPagoP2.Name = "cbFormaPagoP2"
        Me.cbFormaPagoP2.Size = New System.Drawing.Size(241, 24)
        Me.cbFormaPagoP2.TabIndex = 4
        '
        'cbEstado
        '
        Me.cbEstado.BackColor = System.Drawing.SystemColors.Window
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.Items.AddRange(New Object() {"(F) = Faltan Datos", "(E) = Entrega Completa", "(L) = Analizada", "(A) = Aprobada", "(D) = Denegado", "(P) = Pendiente", "(M) = Desembolso"})
        Me.cbEstado.Location = New System.Drawing.Point(102, 10)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(241, 24)
        Me.cbEstado.TabIndex = 150
        '
        'dtpFechaActa
        '
        Me.dtpFechaActa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaActa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaActa.Location = New System.Drawing.Point(470, 318)
        Me.dtpFechaActa.Name = "dtpFechaActa"
        Me.dtpFechaActa.Size = New System.Drawing.Size(242, 23)
        Me.dtpFechaActa.TabIndex = 8
        Me.dtpFechaActa.Value = New Date(2019, 2, 4, 0, 0, 0, 0)
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(102, 144)
        Me.txtObs.MaxLength = 0
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(610, 37)
        Me.txtObs.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(372, 318)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 19)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "Fecha Acta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'C1NEPlazo
        '
        Me.C1NEPlazo.BackColor = System.Drawing.Color.White
        Me.C1NEPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEPlazo.CustomFormat = "###"
        Me.C1NEPlazo.DataType = GetType(Short)
        Me.C1NEPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEPlazo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEPlazo.Location = New System.Drawing.Point(470, 282)
        Me.C1NEPlazo.MaxLength = 3
        Me.C1NEPlazo.Name = "C1NEPlazo"
        Me.C1NEPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.C1NEPlazo.Size = New System.Drawing.Size(242, 23)
        Me.C1NEPlazo.TabIndex = 7
        Me.C1NEPlazo.Tag = Nothing
        Me.C1NEPlazo.Value = CType(0, Short)
        Me.C1NEPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'C1NEInteres
        '
        Me.C1NEInteres.BackColor = System.Drawing.Color.White
        Me.C1NEInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEInteres.CustomFormat = "#0.00"
        Me.C1NEInteres.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEInteres.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEInteres.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEInteres.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEInteres.Location = New System.Drawing.Point(102, 280)
        Me.C1NEInteres.Name = "C1NEInteres"
        Me.C1NEInteres.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEInteres.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEInteres.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEInteres.Size = New System.Drawing.Size(241, 23)
        Me.C1NEInteres.TabIndex = 6
        Me.C1NEInteres.Tag = Nothing
        Me.C1NEInteres.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEInteres.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(372, 286)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(96, 19)
        Me.Label67.TabIndex = 155
        Me.Label67.Text = "Plazo (meses):"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label6.TabIndex = 160
        Me.Label13.Location = New System.Drawing.Point(372, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 18)
        Me.Label13.TabIndex = 147
        Me.Label13.Text = "Conclusión:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(372, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 18)
        Me.Label6.Text = "Otorgamiento:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(4, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 18)
        Me.Label14.TabIndex = 169
        Me.Label14.Text = "Observaciones:"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(4, 287)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 19)
        Me.Label17.TabIndex = 154
        Me.Label17.Text = "Interés:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(4, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 19)
        Me.Label12.TabIndex = 151
        Me.Label12.Text = "Asociado:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Estado:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(372, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 19)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "No. Asociado:"
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(4, 222)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(57, 18)
        Me.Label40.TabIndex = 153
        Me.Label40.Text = "Monto:"
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BackColor = System.Drawing.Color.White
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(102, 218)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.Size = New System.Drawing.Size(241, 23)
        Me.C1NEMonto.TabIndex = 2
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'dtpFecOtorgamiento
        '
        Me.dtpFecOtorgamiento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecOtorgamiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecOtorgamiento.Location = New System.Drawing.Point(470, 222)
        Me.dtpFecOtorgamiento.Name = "dtpFecOtorgamiento"
        Me.dtpFecOtorgamiento.Size = New System.Drawing.Size(242, 23)
        Me.dtpFecOtorgamiento.TabIndex = 3
        '
        'txtNoActa
        '
        Me.txtNoActa.BackColor = System.Drawing.Color.White
        Me.txtNoActa.Location = New System.Drawing.Point(470, 252)
        Me.txtNoActa.MaxLength = 20
        Me.txtNoActa.Name = "txtNoActa"
        Me.txtNoActa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoActa.Size = New System.Drawing.Size(242, 22)
        Me.txtNoActa.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(372, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "No. Acta:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbDeducciones
        '
        Me.tbDeducciones.BackColor = System.Drawing.Color.White
        Me.tbDeducciones.Controls.Add(Me.btDel1)
        Me.tbDeducciones.Controls.Add(Me.btGastosHonorarios1)
        Me.tbDeducciones.Controls.Add(Me.btGastosTramitacion1)
        Me.tbDeducciones.Controls.Add(Me.btGastosEscrituracion1)
        Me.tbDeducciones.Controls.Add(Me.lblMonto)
        Me.tbDeducciones.Controls.Add(Me.fgDeducciones)
        Me.tbDeducciones.Location = New System.Drawing.Point(4, 25)
        Me.tbDeducciones.Name = "tbDeducciones"
        Me.tbDeducciones.Size = New System.Drawing.Size(731, 563)
        Me.tbDeducciones.TabIndex = 3
        Me.tbDeducciones.Text = "Deducciones"
        '
        'btDel1
        '
        Me.btDel1.Location = New System.Drawing.Point(10, 483)
        Me.btDel1.Name = "btDel1"
        Me.btDel1.Size = New System.Drawing.Size(90, 33)
        Me.btDel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDel1.TabIndex = 207
        Me.btDel1.Text = "Eliminar"
        Me.btDel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDel1.UseSelectable = True
        Me.btDel1.UseStyleColors = True
        '
        'btGastosHonorarios1
        '
        Me.btGastosHonorarios1.Location = New System.Drawing.Point(396, 3)
        Me.btGastosHonorarios1.Name = "btGastosHonorarios1"
        Me.btGastosHonorarios1.Size = New System.Drawing.Size(90, 33)
        Me.btGastosHonorarios1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btGastosHonorarios1.TabIndex = 206
        Me.btGastosHonorarios1.Text = "Honorarios"
        Me.btGastosHonorarios1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btGastosHonorarios1.UseSelectable = True
        Me.btGastosHonorarios1.UseStyleColors = True
        Me.btGastosHonorarios1.Visible = False
        '
        'btGastosTramitacion1
        '
        Me.btGastosTramitacion1.Location = New System.Drawing.Point(10, 3)
        Me.btGastosTramitacion1.Name = "btGastosTramitacion1"
        Me.btGastosTramitacion1.Size = New System.Drawing.Size(90, 33)
        Me.btGastosTramitacion1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btGastosTramitacion1.TabIndex = 204
        Me.btGastosTramitacion1.Text = "Tramitación"
        Me.btGastosTramitacion1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btGastosTramitacion1.UseSelectable = True
        Me.btGastosTramitacion1.UseStyleColors = True
        '
        'btGastosEscrituracion1
        '
        Me.btGastosEscrituracion1.Location = New System.Drawing.Point(493, 3)
        Me.btGastosEscrituracion1.Name = "btGastosEscrituracion1"
        Me.btGastosEscrituracion1.Size = New System.Drawing.Size(90, 33)
        Me.btGastosEscrituracion1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btGastosEscrituracion1.TabIndex = 203
        Me.btGastosEscrituracion1.Text = "Escrituración"
        Me.btGastosEscrituracion1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btGastosEscrituracion1.UseSelectable = True
        Me.btGastosEscrituracion1.UseStyleColors = True
        Me.btGastosEscrituracion1.Visible = False
        '
        'lblMonto
        '
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.Teal
        Me.lblMonto.Location = New System.Drawing.Point(509, 489)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(211, 27)
        Me.lblMonto.TabIndex = 156
        Me.lblMonto.Text = "Total: $"
        Me.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fgDeducciones
        '
        Me.fgDeducciones.AllowEditing = False
        Me.fgDeducciones.BackColor = System.Drawing.Color.White
        Me.fgDeducciones.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgDeducciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgDeducciones.Location = New System.Drawing.Point(10, 43)
        Me.fgDeducciones.Name = "fgDeducciones"
        Me.fgDeducciones.Rows.Count = 1
        Me.fgDeducciones.Rows.DefaultSize = 22
        Me.fgDeducciones.Size = New System.Drawing.Size(710, 437)
        Me.fgDeducciones.StyleInfo = resources.GetString("fgDeducciones.StyleInfo")
        Me.fgDeducciones.TabIndex = 4
        '
        'tbCheques
        '
        Me.tbCheques.BackColor = System.Drawing.Color.White
        Me.tbCheques.Controls.Add(Me.btnImprimir1)
        Me.tbCheques.Controls.Add(Me.btnModificar1)
        Me.tbCheques.Controls.Add(Me.btnEliminar1)
        Me.tbCheques.Controls.Add(Me.btnAgregar1)
        Me.tbCheques.Controls.Add(Me.fg)
        Me.tbCheques.Location = New System.Drawing.Point(4, 25)
        Me.tbCheques.Name = "tbCheques"
        Me.tbCheques.Size = New System.Drawing.Size(731, 563)
        Me.tbCheques.TabIndex = 2
        Me.tbCheques.Text = "Cheques"
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(101, 3)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(90, 33)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 207
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(198, 3)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 33)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 205
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(295, 3)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 33)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 204
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(4, 3)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 33)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 203
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.Location = New System.Drawing.Point(4, 43)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(722, 512)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 17
        '
        'tbTrans
        '
        Me.tbTrans.BackColor = System.Drawing.Color.White
        Me.tbTrans.Controls.Add(Me.btnProcesarTran1)
        Me.tbTrans.Controls.Add(Me.GroupBox6)
        Me.tbTrans.Controls.Add(Me.gbDatosTransferencias)
        Me.tbTrans.Location = New System.Drawing.Point(4, 25)
        Me.tbTrans.Name = "tbTrans"
        Me.tbTrans.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTrans.Size = New System.Drawing.Size(731, 563)
        Me.tbTrans.TabIndex = 5
        Me.tbTrans.Text = "Transferencias"
        '
        'btnProcesarTran1
        '
        Me.btnProcesarTran1.Location = New System.Drawing.Point(18, 470)
        Me.btnProcesarTran1.Name = "btnProcesarTran1"
        Me.btnProcesarTran1.Size = New System.Drawing.Size(154, 32)
        Me.btnProcesarTran1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesarTran1.TabIndex = 206
        Me.btnProcesarTran1.Text = "Procesar Transferencia"
        Me.btnProcesarTran1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesarTran1.UseSelectable = True
        Me.btnProcesarTran1.UseStyleColors = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgTransferencias)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 270)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(715, 200)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Detalle de Transferencias"
        '
        'dgTransferencias
        '
        Me.dgTransferencias.AllowUserToAddRows = False
        Me.dgTransferencias.AllowUserToDeleteRows = False
        Me.dgTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransferencias.Location = New System.Drawing.Point(11, 22)
        Me.dgTransferencias.Name = "dgTransferencias"
        Me.dgTransferencias.ReadOnly = True
        Me.dgTransferencias.Size = New System.Drawing.Size(697, 171)
        Me.dgTransferencias.TabIndex = 0
        '
        'gbDatosTransferencias
        '
        Me.gbDatosTransferencias.BackColor = System.Drawing.Color.White
        Me.gbDatosTransferencias.Controls.Add(Me.btnTransferencia1)
        Me.gbDatosTransferencias.Controls.Add(Me.txtMonto)
        Me.gbDatosTransferencias.Controls.Add(Me.lblTipoTrans)
        Me.gbDatosTransferencias.Controls.Add(Me.lblNoctaAux)
        Me.gbDatosTransferencias.Controls.Add(Me.txtObsTran)
        Me.gbDatosTransferencias.Controls.Add(Me.chkPrincipal)
        Me.gbDatosTransferencias.Controls.Add(Me.cbTipoTrans)
        Me.gbDatosTransferencias.Controls.Add(Me.txtReferencia)
        Me.gbDatosTransferencias.Controls.Add(Me.lblObservacionesTrans)
        Me.gbDatosTransferencias.Controls.Add(Me.lblMontoTran)
        Me.gbDatosTransferencias.Location = New System.Drawing.Point(7, 7)
        Me.gbDatosTransferencias.Name = "gbDatosTransferencias"
        Me.gbDatosTransferencias.Size = New System.Drawing.Size(715, 256)
        Me.gbDatosTransferencias.TabIndex = 11
        Me.gbDatosTransferencias.TabStop = False
        Me.gbDatosTransferencias.Text = "Datos Transferencia"
        '
        'btnTransferencia1
        '
        Me.btnTransferencia1.Location = New System.Drawing.Point(546, 207)
        Me.btnTransferencia1.Name = "btnTransferencia1"
        Me.btnTransferencia1.Size = New System.Drawing.Size(154, 32)
        Me.btnTransferencia1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnTransferencia1.TabIndex = 205
        Me.btnTransferencia1.Text = "Agregar Transferencia"
        Me.btnTransferencia1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnTransferencia1.UseSelectable = True
        Me.btnTransferencia1.UseStyleColors = True
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.CustomFormat = "###,###,##0.00"
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMonto.Location = New System.Drawing.Point(226, 92)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMonto.Size = New System.Drawing.Size(234, 23)
        Me.txtMonto.TabIndex = 8
        Me.txtMonto.Tag = Nothing
        Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblTipoTrans
        '
        Me.lblTipoTrans.AutoSize = True
        Me.lblTipoTrans.Location = New System.Drawing.Point(7, 35)
        Me.lblTipoTrans.Name = "lblTipoTrans"
        Me.lblTipoTrans.Size = New System.Drawing.Size(233, 17)
        Me.lblTipoTrans.TabIndex = 0
        Me.lblTipoTrans.Text = "Seleccione el Tipo de Tranferencia:"
        '
        'lblNoctaAux
        '
        Me.lblNoctaAux.AutoSize = True
        Me.lblNoctaAux.Location = New System.Drawing.Point(7, 62)
        Me.lblNoctaAux.Name = "lblNoctaAux"
        Me.lblNoctaAux.Size = New System.Drawing.Size(160, 17)
        Me.lblNoctaAux.TabIndex = 1
        Me.lblNoctaAux.Text = "Ingrese el No. de la Cta."
        '
        'txtObsTran
        '
        Me.txtObsTran.BackColor = System.Drawing.Color.White
        Me.txtObsTran.Location = New System.Drawing.Point(226, 127)
        Me.txtObsTran.Multiline = True
        Me.txtObsTran.Name = "txtObsTran"
        Me.txtObsTran.Size = New System.Drawing.Size(474, 73)
        Me.txtObsTran.TabIndex = 8
        '
        'chkPrincipal
        '
        Me.chkPrincipal.AutoSize = True
        Me.chkPrincipal.Location = New System.Drawing.Point(467, 31)
        Me.chkPrincipal.Name = "chkPrincipal"
        Me.chkPrincipal.Size = New System.Drawing.Size(84, 21)
        Me.chkPrincipal.TabIndex = 5
        Me.chkPrincipal.Text = "Principal"
        Me.chkPrincipal.UseVisualStyleBackColor = True
        '
        'cbTipoTrans
        '
        Me.cbTipoTrans.BackColor = System.Drawing.Color.White
        Me.cbTipoTrans.FormattingEnabled = True
        Me.cbTipoTrans.Items.AddRange(New Object() {"Ahorros", "Aportaciones"})
        Me.cbTipoTrans.Location = New System.Drawing.Point(226, 31)
        Me.cbTipoTrans.Name = "cbTipoTrans"
        Me.cbTipoTrans.Size = New System.Drawing.Size(234, 24)
        Me.cbTipoTrans.TabIndex = 6
        '
        'txtReferencia
        '
        Me.txtReferencia.BackColor = System.Drawing.Color.White
        Me.txtReferencia.Location = New System.Drawing.Point(226, 62)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(234, 22)
        Me.txtReferencia.TabIndex = 7
        '
        'lblObservacionesTrans
        '
        Me.lblObservacionesTrans.AutoSize = True
        Me.lblObservacionesTrans.Location = New System.Drawing.Point(7, 130)
        Me.lblObservacionesTrans.Name = "lblObservacionesTrans"
        Me.lblObservacionesTrans.Size = New System.Drawing.Size(107, 17)
        Me.lblObservacionesTrans.TabIndex = 2
        Me.lblObservacionesTrans.Text = "Observaciones:"
        '
        'lblMontoTran
        '
        Me.lblMontoTran.AutoSize = True
        Me.lblMontoTran.Location = New System.Drawing.Point(7, 92)
        Me.lblMontoTran.Name = "lblMontoTran"
        Me.lblMontoTran.Size = New System.Drawing.Size(195, 17)
        Me.lblMontoTran.TabIndex = 3
        Me.lblMontoTran.Text = "Ingrese el Monto a Transferir:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgTabla)
        Me.TabPage1.Controls.Add(Me.btnAsinaTA1)
        Me.TabPage1.Controls.Add(Me.txtFechayHora)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.txtUsuario)
        Me.TabPage1.Controls.Add(Me.txtCodTablaAmortiza)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(731, 563)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "Tabla Amortización"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgTabla
        '
        Me.dgTabla.AllowUserToAddRows = False
        Me.dgTabla.AllowUserToDeleteRows = False
        Me.dgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTabla.Location = New System.Drawing.Point(7, 138)
        Me.dgTabla.Name = "dgTabla"
        Me.dgTabla.ReadOnly = True
        Me.dgTabla.Size = New System.Drawing.Size(715, 417)
        Me.dgTabla.TabIndex = 214
        '
        'btnAsinaTA1
        '
        Me.btnAsinaTA1.Location = New System.Drawing.Point(7, 99)
        Me.btnAsinaTA1.Name = "btnAsinaTA1"
        Me.btnAsinaTA1.Size = New System.Drawing.Size(102, 33)
        Me.btnAsinaTA1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAsinaTA1.TabIndex = 213
        Me.btnAsinaTA1.Text = "CrearTabla"
        Me.btnAsinaTA1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAsinaTA1.UseSelectable = True
        Me.btnAsinaTA1.UseStyleColors = True
        '
        'txtFechayHora
        '
        Me.txtFechayHora.BackColor = System.Drawing.Color.White
        Me.txtFechayHora.Enabled = False
        Me.txtFechayHora.Location = New System.Drawing.Point(182, 76)
        Me.txtFechayHora.Name = "txtFechayHora"
        Me.txtFechayHora.ReadOnly = True
        Me.txtFechayHora.Size = New System.Drawing.Size(288, 22)
        Me.txtFechayHora.TabIndex = 145
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(7, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(168, 16)
        Me.Label23.TabIndex = 126
        Me.Label23.Text = "Código Tabla Amortización:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(182, 46)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(288, 22)
        Me.txtUsuario.TabIndex = 144
        '
        'txtCodTablaAmortiza
        '
        Me.txtCodTablaAmortiza.BackColor = System.Drawing.Color.White
        Me.txtCodTablaAmortiza.Enabled = False
        Me.txtCodTablaAmortiza.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTablaAmortiza.Location = New System.Drawing.Point(182, 16)
        Me.txtCodTablaAmortiza.MaxLength = 25
        Me.txtCodTablaAmortiza.Name = "txtCodTablaAmortiza"
        Me.txtCodTablaAmortiza.ReadOnly = True
        Me.txtCodTablaAmortiza.Size = New System.Drawing.Size(288, 23)
        Me.txtCodTablaAmortiza.TabIndex = 125
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(7, 78)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(173, 18)
        Me.Label28.TabIndex = 143
        Me.Label28.Text = "Fecha y Hora de Creación:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(7, 47)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(173, 19)
        Me.Label27.TabIndex = 142
        Me.Label27.Text = "Usuario que creó la Tabla:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'tbCondiciones
        '
        Me.tbCondiciones.BackColor = System.Drawing.Color.White
        Me.tbCondiciones.Controls.Add(Me.GroupBox7)
        Me.tbCondiciones.Controls.Add(Me.txtCondicionEspecial)
        Me.tbCondiciones.Controls.Add(Me.Label18)
        Me.tbCondiciones.Location = New System.Drawing.Point(4, 25)
        Me.tbCondiciones.Name = "tbCondiciones"
        Me.tbCondiciones.Size = New System.Drawing.Size(731, 563)
        Me.tbCondiciones.TabIndex = 4
        Me.tbCondiciones.Text = "Condiciones especiales"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtTasaExtPrima)
        Me.GroupBox7.Controls.Add(Me.lblTasaExtPrima)
        Me.GroupBox7.Controls.Add(Me.chkExtPrima)
        Me.GroupBox7.Controls.Add(Me.rbNoEnvAseg)
        Me.GroupBox7.Controls.Add(Me.rbEnvAseg)
        Me.GroupBox7.Location = New System.Drawing.Point(29, 118)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(672, 100)
        Me.GroupBox7.TabIndex = 173
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Aseguradora"
        '
        'txtTasaExtPrima
        '
        Me.txtTasaExtPrima.BackColor = System.Drawing.Color.White
        Me.txtTasaExtPrima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTasaExtPrima.CustomFormat = "###,###,##0.00"
        Me.txtTasaExtPrima.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaExtPrima.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtTasaExtPrima.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtTasaExtPrima.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtTasaExtPrima.Location = New System.Drawing.Point(257, 22)
        Me.txtTasaExtPrima.Name = "txtTasaExtPrima"
        Me.txtTasaExtPrima.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtTasaExtPrima.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtTasaExtPrima.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtTasaExtPrima.Size = New System.Drawing.Size(115, 23)
        Me.txtTasaExtPrima.TabIndex = 177
        Me.txtTasaExtPrima.Tag = Nothing
        Me.txtTasaExtPrima.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTasaExtPrima.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblTasaExtPrima
        '
        Me.lblTasaExtPrima.AutoSize = True
        Me.lblTasaExtPrima.Location = New System.Drawing.Point(124, 27)
        Me.lblTasaExtPrima.Name = "lblTasaExtPrima"
        Me.lblTasaExtPrima.Size = New System.Drawing.Size(140, 17)
        Me.lblTasaExtPrima.TabIndex = 179
        Me.lblTasaExtPrima.Text = "Tasa de Extra Prima:"
        '
        'chkExtPrima
        '
        Me.chkExtPrima.AutoSize = True
        Me.chkExtPrima.Location = New System.Drawing.Point(22, 25)
        Me.chkExtPrima.Name = "chkExtPrima"
        Me.chkExtPrima.Size = New System.Drawing.Size(102, 21)
        Me.chkExtPrima.TabIndex = 178
        Me.chkExtPrima.Text = "Extra Prima"
        Me.chkExtPrima.UseVisualStyleBackColor = True
        '
        'rbNoEnvAseg
        '
        Me.rbNoEnvAseg.AutoSize = True
        Me.rbNoEnvAseg.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.rbNoEnvAseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbNoEnvAseg.Location = New System.Drawing.Point(181, 62)
        Me.rbNoEnvAseg.Name = "rbNoEnvAseg"
        Me.rbNoEnvAseg.Size = New System.Drawing.Size(198, 21)
        Me.rbNoEnvAseg.TabIndex = 3
        Me.rbNoEnvAseg.Text = "No reportar a aseguradora"
        Me.rbNoEnvAseg.UseVisualStyleBackColor = True
        '
        'rbEnvAseg
        '
        Me.rbEnvAseg.AutoSize = True
        Me.rbEnvAseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEnvAseg.Location = New System.Drawing.Point(22, 62)
        Me.rbEnvAseg.Name = "rbEnvAseg"
        Me.rbEnvAseg.Size = New System.Drawing.Size(169, 21)
        Me.rbEnvAseg.TabIndex = 2
        Me.rbEnvAseg.Text = "Reportar aseguradora"
        Me.rbEnvAseg.UseVisualStyleBackColor = True
        '
        'txtCondicionEspecial
        '
        Me.txtCondicionEspecial.BackColor = System.Drawing.Color.White
        Me.txtCondicionEspecial.Location = New System.Drawing.Point(29, 46)
        Me.txtCondicionEspecial.MaxLength = 0
        Me.txtCondicionEspecial.Multiline = True
        Me.txtCondicionEspecial.Name = "txtCondicionEspecial"
        Me.txtCondicionEspecial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCondicionEspecial.Size = New System.Drawing.Size(672, 65)
        Me.txtCondicionEspecial.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(29, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(173, 18)
        Me.Label18.TabIndex = 171
        Me.Label18.Text = "Condiciones especiales:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(668, 672)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 205
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnSigTb1_1
        '
        Me.btnSigTb1_1.Location = New System.Drawing.Point(571, 672)
        Me.btnSigTb1_1.Name = "btnSigTb1_1"
        Me.btnSigTb1_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTb1_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTb1_1.TabIndex = 204
        Me.btnSigTb1_1.Text = "Siguiente"
        Me.btnSigTb1_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTb1_1.UseSelectable = True
        Me.btnSigTb1_1.UseStyleColors = True
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(359, 672)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(108, 32)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 203
        Me.btnProcesar1.Text = "&Liquidación"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'btAtrasTb2_1
        '
        Me.btAtrasTb2_1.Location = New System.Drawing.Point(474, 672)
        Me.btAtrasTb2_1.Name = "btAtrasTb2_1"
        Me.btAtrasTb2_1.Size = New System.Drawing.Size(90, 32)
        Me.btAtrasTb2_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btAtrasTb2_1.TabIndex = 206
        Me.btAtrasTb2_1.Text = "Atras"
        Me.btAtrasTb2_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btAtrasTb2_1.UseSelectable = True
        Me.btAtrasTb2_1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(203, 672)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(149, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 207
        Me.MetroButton1.Text = "&Contrato Gerencial"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMsCrControlEstado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(787, 735)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btAtrasTb2_1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.btnSigTb1_1)
        Me.Controls.Add(Me.tbPpal)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCrControlEstado"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Desembolso de Créditos"
        Me.tbPpal.ResumeLayout(False)
        Me.tbEstado.ResumeLayout(False)
        Me.tbEstado.PerformLayout()
        CType(Me.c1nMontoRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMontoGarantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEInteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDeducciones.ResumeLayout(False)
        CType(Me.fgDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCheques.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbTrans.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosTransferencias.ResumeLayout(False)
        Me.gbDatosTransferencias.PerformLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCondiciones.ResumeLayout(False)
        Me.tbCondiciones.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.txtTasaExtPrima, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Ahorros As New wrAhorro.wsLibAhorro
    Dim Creditos As New wrCredito.wsLibCred
    Dim prestamo As New wrPrestamo.wsLibPrest
    Dim Bancos As New wrBancos.wsLibBancos
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim Caja As New wrCaja.wsLibCaja
    Dim administracion As New wrAdmin.wsLibAdmin
    Private vCodPrestamo As String, pDui As String, vCodigoTipoCredito As String
    Dim dtTransferencias As DataTable
    Dim Dts As DataSet

#Region "Propiedades"
    Public Property CodigoTipoCredito() As String
        Get
            Return vCodigoTipoCredito
        End Get
        Set(ByVal Value As String)
            vCodigoTipoCredito = Value
        End Set
    End Property
    Public Property Dui() As String
        Get
            Return pDui
        End Get
        Set(ByVal Value As String)
            pDui = Value
        End Set
    End Property

    Public Property CodPrestamo() As String
        Get
            Return vCodPrestamo
        End Get
        Set(ByVal Value As String)
            vCodPrestamo = Value
        End Set
    End Property
#End Region



    Private Sub frmMsCrControlEstado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'Me.tbCheques.Parent = Nothing
            'Me.tbTrans.Parent = Nothing
            'Me.tbCondiciones.Parent = Nothing
            '************************************************************
            'Modificacion 
            '29092015
            'validacion de prestamos ara reporte de aseguradora
            Me.rbNoEnvAseg.Enabled = False
            Me.rbEnvAseg.Enabled = False
            Me.chkGeneraReserva.Enabled = False
            Dim dtsRoles As New DataSet
            Dim dtsProcesos As New DataSet
            dtsRoles = administracion.ConsultarRolesUsuario(sUsuario, "", 2)
            If dtsRoles.Tables.Count > 0 Then
                If dtsRoles.Tables(0).Rows.Count > 0 Then
                    For i As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                        If administracion.ConsultarPermisoProcesos("CRX008",
                                                                   dtsRoles.Tables(0).Rows(i).Item("codRol").ToString,
                                                                   4) = True Then
                            Me.rbNoEnvAseg.Enabled = True
                            Me.rbEnvAseg.Enabled = True
                            Exit For
                        End If
                    Next
                End If
            End If
            '************************************************************
            '****************************************
            'Modificación desembolso de cheques
            Me.btnModificar1.Visible = False
            Me.btnEliminar1.Visible = False
            'Valida que el desembolso se haya hecho a 
            'travez de transferencias
            If Me.ConsultarTransferencias(pNoSolic) > 0 Then
                llenarTransferencias()
                Me.btnProcesarTran1.Enabled = False
                Me.btnTransferencia1.Enabled = False
            End If

            'Si ya existen cheques desabilitamos el boton de transferencias
            If Me.fg.Rows.Count > 1 Then
                Me.btnProcesarTran1.Enabled = False
            End If
            '****************************************
            Dim pCodTipoCred As String, pMonto As Double, pInteres As Double, pPlazo As Integer, vTipoGar As String = ""
            Me.cbEstado.SelectedIndex = 0
            Me.cbConclusion.SelectedIndex = 0
            Me.dtpFec1Cuota.Value = Now
            Me.dtpFechaActa.Value = Now
            Me.dtpFecOtorgamiento.Value = Now

            Dim oItem As New wrPrestamo.wsLibPrest, oAsoc As New wrAsociados.wsLibAsoc, dr As DataRow, oCaja As New wrCaja.wsLibCaja
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, Filas As Data.DataRowCollection, ds As New Data.DataSet, x As Integer, dsCheques As New DataSet

            ds = oAsoc.ConsultarAsociado("Nombres,Apellido1,Apellido2,NoSocio", "Dui='" & pDui & "'", "Dui", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtNombre.Text = dr("Nombres") & " " & dr("Apellido1") & " " & dr("Apellido2")
                Me.txtNoSocio.Text = dr("NoSocio")
            End If
            ds.Clear()


            ds = oCred.ConsultarGarantias("CodTipoGarantia", "NumSolicitud='" & Me.pNoSolic & "' and (CodTipoGarantia='00004' or CodTipoGarantia='00006')", "CodTipoGarantia", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                Me.C1NEMontoGarantia.Enabled = True
            Else
                Me.C1NEMontoGarantia.Enabled = False
            End If
            ds.Clear()

            ds = oCred.ConsultarSolCredR("*", "NumSolicitud='" & Me.pNoSolic & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()


            Dim dtsPrestamos As New DataSet
            dtsPrestamos = oCred.ConsultarPrestamos("estado", "NumSolicitud='" & Me.pNoSolic & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
            Dim estadoPrestamo As String = ""
            If dtsPrestamos.Tables.Count > 0 Then
                If dtsPrestamos.Tables(0).Rows.Count > 0 Then
                    estadoPrestamo = dtsPrestamos.Tables(0).Rows(0).Item("estado")
                End If
            End If


            If Filas.Count > 0 Then

                For x = 0 To Me.cbEstado.Items.Count - 1
                    Me.cbEstado.SelectedIndex = x
                    If Mid(Me.cbEstado.Text, 2, 1) = IIf(IsDBNull(Filas.Item(0)("Estado")), "", Filas.Item(0)("Estado")) Then
                        Me.cbEstado.SelectedIndex = x
                        'If x = 6 Then Me.btnGuardar.Enabled = False
                        If x = 6 Then
                            Me.C1NEMonto.ReadOnly = True
                            Me.dtpFecOtorgamiento.Enabled = False
                            Me.cbFormaPagoP2.Enabled = False
                            Me.txtNoActa.ReadOnly = True
                            Me.C1NEInteres.ReadOnly = True
                            Me.C1NEPlazo.ReadOnly = True
                            Me.txtNoCuenta.ReadOnly = True
                            Me.dtpFechaActa.Enabled = False
                            Me.c1nCuota.ReadOnly = True
                            Me.dtpFec1Cuota.Enabled = False
                            Me.C1NEMontoGarantia.ReadOnly = True
                            Me.txtArchivo.ReadOnly = True
                            Me.btImagen.Enabled = False
                            Me.chkRef.Enabled = False
                            Me.cbEstado.Enabled = False

                        End If
                        Exit For
                    End If
                Next



                '==================================================
                'Javier Escobar 22/08/2014
                'Si el Prestamo no ha sido activo 
                'permite modificar la fecha de otorgamiento
                '==================================================
                If estadoPrestamo.Equals("D") Then
                    Me.dtpFecOtorgamiento.Enabled = True
                    Me.dtpFec1Cuota.Enabled = True
                    Me.C1NEMontoGarantia.ReadOnly = False
                    Me.C1NEMontoGarantia.Enabled = True
                    Me.chkRef.Enabled = True
                    Me.C1NEInteres.ReadOnly = False
                    Me.C1NEInteres.Enabled = True
                    Me.txtCodTipoCredito.Enabled = True
                    Me.txtCodTipoCredito.ReadOnly = False
                    Me.C1NEMonto.ReadOnly = False
                    Me.c1nCuota.ReadOnly = False
                    Me.dtpFechaActa.Enabled = True
                    Me.txtNoActa.Enabled = True
                    txtNoActa.ReadOnly = False



                End If
                For x = 0 To Me.cbConclusion.Items.Count - 1
                    Me.cbConclusion.SelectedIndex = x
                    If Mid(Me.cbConclusion.Text, 2, 1) = IIf(IsDBNull(Filas.Item(0)("Conclusion")), "", Filas.Item(0)("Conclusion")) Then
                        Me.cbConclusion.SelectedIndex = x
                        Exit For
                    End If
                Next
            End If
            ds = oCred.ConsultarPrestamos("*", "NumSolicitud='" & Me.pNoSolic & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then

                Me.CodPrestamo = CStr(Filas.Item(0)("CodPrestamo"))
                vCodigoTipoCredito = IIf(IsDBNull(Filas.Item(0)("CodTipoCredito")), "", Filas.Item(0)("CodTipoCredito"))
                pCodTipoCred = IIf(IsDBNull(Filas.Item(0)("CodTipoCredito")), "", Filas.Item(0)("CodTipoCredito"))
                Me.txtCodTipoCredito.Text = pCodTipoCred

                If pCodTipoCred.Trim.Length > 0 Then
                    Dim dtsTipoCredito As New DataSet
                    dtsTipoCredito = credito.ConsultarTipoCreditos("Descripcion", "CodTipoCredito = '" & pCodTipoCred & "'", "CodTipoCredito", sUsuario, sPassword, sSucursal)
                    txtTipoCredito.Text = dtsTipoCredito.Tables(0).Rows(0).Item(0).ToString.ToUpper
                End If

                Me.C1NEMonto.Value = IIf(IsDBNull(Filas.Item(0)("Monto")), 0, Filas.Item(0)("Monto"))
                Me.C1NEMontoGarantia.Value = IIf(IsDBNull(Filas.Item(0)("Monto_Garantia")), 0, Filas.Item(0)("Monto_Garantia"))
                Me.C1NEInteres.Value = IIf(IsDBNull(Filas.Item(0)("Tasa_Interes")), 0, Filas.Item(0)("Tasa_Interes"))
                Me.C1NEPlazo.Value = IIf(IsDBNull(Filas.Item(0)("PlazoMeses")), 0, Filas.Item(0)("PlazoMeses"))
                Me.txtNoActa.Text = IIf(IsDBNull(Filas.Item(0)("NoActa")), "", Filas.Item(0)("NoActa"))
                c1nCuota.Value = IIf(IsDBNull(Filas.Item(0)("CuotaTotal")), 0, Filas.Item(0)("CuotaTotal"))
                Me.dtpFechaActa.Value = IIf(IsDBNull(Filas.Item(0)("FechaActa")), Format(Now, "Short date"), Filas.Item(0)("FechaActa"))
                Me.txtArchivo.Text = IIf(IsDBNull(Filas.Item(0)("ArchivoActa")), "", Filas.Item(0)("ArchivoActa"))
                Me.dtpFecOtorgamiento.Value = IIf(IsDBNull(Filas.Item(0)("FechaOtorgamiento")), "", Filas.Item(0)("FechaOtorgamiento"))
                Me.dtpFec1Cuota.Value = IIf(IsDBNull(Filas.Item(0)("FechaPrimeraCuota")), "", Filas.Item(0)("FechaPrimeraCuota"))
                chkGeneraReserva.Checked = IIf(Filas.Item(0)("GeneraReserva") Is DBNull.Value, "N", IIf(Filas.Item(0)("GeneraReserva") = "N", False, True))

                Me.chkRef.Checked = IIf(IsDBNull(Filas.Item(0)("Refinanciamiento")), "N", IIf(Filas.Item(0)("Refinanciamiento") = "N", False, True))
                Me.c1nMontoRef.Value = IIf(IsDBNull(Filas.Item(0)("MontoRefinanciamiento")), 0, Filas.Item(0)("MontoRefinanciamiento"))
                chkCasoEspecial.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("CasoEspecial")), "", Filas.Item(0)("CasoEspecial")) = "1", True, False)
                Me.txtCodItem.Text = IIf(IsDBNull(Filas.Item(0)("CodItem")), "", Filas.Item(0)("CodItem"))
                Me.rbEnvAseg.Checked = IIf(IsDBNull(Filas.Item(0)("EnviarAseguradora")), False, Filas.Item(0)("EnviarAseguradora"))
                Me.rbNoEnvAseg.Checked = IIf(IsDBNull(Filas.Item(0)("NoEnviarAseguradora")), False, Filas.Item(0)("NoEnviarAseguradora"))
                If IsDBNull(Filas.Item(0)("ExtraPrima")) = False Then
                    Me.chkExtPrima.Checked = Filas.Item(0)("ExtraPrima")
                    If chkExtPrima.Checked = True Then
                        Me.txtTasaExtPrima.Value = Filas.Item(0)("TasaExtPrima")
                        Me.chkExtPrima.Enabled = False
                        Me.txtTasaExtPrima.Enabled = False
                    End If
                End If
                Me.cbEstado.Focus()
                Me.txtCodigo.Text = Me.CodPrestamo
                Me.tbCheques.Enabled = True
                '06/10/2012
                '***************************************
                'Modificación Parametrización Creditos con arreglos por mora
                Me.chkArreglo.Checked = IIf(IsDBNull(Filas.Item(0)("Arreglo")), False, Filas.Item(0)("Arreglo"))
                '***************************************
                'modificacion datos tabla de amortizacion
                llenarDatosTablaAmortizacion()
                '***************************************
                'Modificación Desembolso de creditos
                RefrescarGrid()

                'Encabezado()
                '***************************************'***************************************'***************************************
                EncabezadoDeducciones()

                If Me.txtCodItem.Text.Trim <> "" Then
                    ds.Clear()
                    ds = oCaja.ObtenerItem(Me.txtCodItem.Text.Trim, "IdRubro='2' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtItem.Text = Trim(IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion")))
                    End If
                End If

                ds = oCred.ConsultarSolP2Credito("*", "NumSolicitud='" & Me.pNoSolic & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    cbFormaPagoP2.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("FormaPago")), 0, Filas.Item(0)("FormaPago"))
                    txtNoCuenta.Text = IIf(IsDBNull(Filas.Item(0)("NoCuenta")), "", Filas.Item(0)("NoCuenta"))
                    txtCodTipoAhorro.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoAhorro")), "", Filas.Item(0)("CodTipoAhorro"))
                    txtCodPagaduria.Text = IIf(IsDBNull(Filas.Item(0)("CodPagaduria")), "", Filas.Item(0)("CodPagaduria"))
                    txtObs.Text = IIf(IsDBNull(Filas.Item(0)("Observaciones")), "", Filas.Item(0)("Observaciones"))
                    txtCondicionEspecial.Text = IIf(IsDBNull(Filas.Item(0)("CondicionesEspeciales")), "", Filas.Item(0)("CondicionesEspeciales"))
                    ds.Clear()
                    ds = oCred.ConsultarPagaduria("CodPagaduria,Nombre,Categoria", "CodPagaduria='" & Trim(Me.txtCodPagaduria.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtPagaduria.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                        Me.lblCategoria.Text = IIf(IsDBNull(Filas.Item(0)("Categoria")), "N/E", Filas.Item(0)("Categoria"))
                    End If
                End If



            Else

                ds = oCred.ConsultarSolP2Credito("*", "NumSolicitud='" & Me.pNoSolic & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    pMonto = IIf(IsDBNull(Filas.Item(0)("MontoSolicitado")), 0, Filas.Item(0)("MontoSolicitado"))
                    pInteres = IIf(IsDBNull(Filas.Item(0)("Interes")), 0, Filas.Item(0)("Interes"))
                    pCodTipoCred = IIf(IsDBNull(Filas.Item(0)("CodTipoCredito")), "", Filas.Item(0)("CodTipoCredito"))
                    vCodigoTipoCredito = IIf(IsDBNull(Filas.Item(0)("CodTipoCredito")), "", Filas.Item(0)("CodTipoCredito"))
                    pPlazo = IIf(IsDBNull(Filas.Item(0)("Plazo")), 0, Filas.Item(0)("Plazo"))
                    dtpFecOtorgamiento.Value = IIf(IsDBNull(Filas.Item(0)("FechaOtorgamiento")), Now, Filas.Item(0)("FechaOtorgamiento"))
                    dtpFec1Cuota.Value = IIf(IsDBNull(Filas.Item(0)("FechaPrimeraCuota")), Now, Filas.Item(0)("FechaPrimeraCuota"))
                    cbFormaPagoP2.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("FormaPago")), 0, Filas.Item(0)("FormaPago"))
                    txtNoCuenta.Text = IIf(IsDBNull(Filas.Item(0)("NoCuenta")), "", Filas.Item(0)("NoCuenta"))
                    txtCodTipoAhorro.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoAhorro")), "", Filas.Item(0)("CodTipoAhorro"))
                    chkGeneraReserva.Checked = IIf(Filas.Item(0)("GeneraReserva") Is DBNull.Value, "N", IIf(Filas.Item(0)("GeneraReserva") = "N", False, True))
                    'chkGeneraReserva.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("GeneraReserva")), "", Filas.Item(0)("GeneraReserva")) = "1", True, False)
                    c1nCuota.Value = IIf(IsDBNull(Filas.Item(0)("CuotaTotal")), 0, Filas.Item(0)("CuotaTotal"))
                    txtCodPagaduria.Text = IIf(IsDBNull(Filas.Item(0)("CodPagaduria")), "", Filas.Item(0)("CodPagaduria"))
                    txtCodTipoCredito.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoCredito")), "", Filas.Item(0)("CodTipoCredito"))
                    txtObs.Text = IIf(IsDBNull(Filas.Item(0)("Observaciones")), "", Filas.Item(0)("Observaciones"))
                    txtCondicionEspecial.Text = IIf(IsDBNull(Filas.Item(0)("CondicionesEspeciales")), "", Filas.Item(0)("CondicionesEspeciales"))
                    ds.Clear()
                    ds = oCred.ConsultarPagaduria("*", "CodPagaduria='" & Trim(Me.txtCodPagaduria.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtPagaduria.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                        Me.lblCategoria.Text = IIf(IsDBNull(Filas.Item(0)("Categoria")), "N/E", Filas.Item(0)("Categoria"))
                    End If

                    ds = oCred.ConsultarTipoCreditos("*", "CodTipoCredito='" & Trim(Me.txtCodTipoCredito.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        chkGeneraReserva.Checked = IIf(Filas.Item(0)("GeneraReserva") Is DBNull.Value, "N", IIf(Filas.Item(0)("GeneraReserva") = "N", False, True))
                        Me.txtTipoCredito.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                        vTipoGar = IIf(IsDBNull(Filas.Item(0)("CodTipoGarantias")), "", Filas.Item(0)("CodTipoGarantias"))
                    End If

                    Me.tbCheques.Enabled = False
                    '***************************************
                    'Modificación Desembolso de creditos
                    RefrescarGrid()
                    '***************************************

                    'Encabezado()
                    EncabezadoDeducciones()
                End If
                ds = oCred.ConsultarTipoCreditos("*", "CodTipoCredito='" & Trim(Me.txtCodTipoCredito.Text) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtTipoCredito.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    chkGeneraReserva.Checked = IIf(Filas.Item(0)("GeneraReserva") Is DBNull.Value, "N", IIf(Filas.Item(0)("GeneraReserva") = "N", False, True))
                    vTipoGar = IIf(IsDBNull(Filas.Item(0)("CodTipoGarantias")), "", Filas.Item(0)("CodTipoGarantias"))
                End If

                Me.C1NEMonto.Value = pMonto
                Me.C1NEInteres.Value = pInteres
                Me.C1NEPlazo.Value = pPlazo
                If vTipoGar.Trim.Trim.Length > 0 Then
                    If vTipoGar.Trim = "00002" Then Puntos_DPF()
                End If



            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    'Private Sub Encabezado()
    '    fg.Cols.Item(1).Visible = False
    '    fg.Cols.Item(2).Caption = "Código de Préstamo"
    '    fg.Cols.Item(3).Caption = "No. Solicitud"
    '    fg.Cols.Item(4).Caption = "Paguese A"
    '    fg.Cols.Item(5).Caption = "Monto"

    '    fg.Cols.Item(2).Width = 125
    '    fg.Cols.Item(3).Width = 125
    '    fg.Cols.Item(4).Width = 200
    '    fg.Cols.Item(5).Width = 100
    'End Sub

    Private Sub RefrescarGrid()
        Dim ds As New Data.DataSet
        Dim oItem As New wrPrestamo.wsLibPrest
        Try
            ds = Bancos.Consultar_BcMovCheques(1, "", "", "", Now, pNoSolic)
            If ds.Tables(0).Rows.Count = 0 Then
                ds = oItem.ConsultarPRCheques("*", "NumSolicitud='" & Me.pNoSolic & "'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            Else
                fg.DataSource = ds.Tables(0)
            End If
            'Encabezado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Dim ds As New Data.DataSet
        'Dim oItem As New wrPrestamo.wsLibPrest
        'Try
        '    ds = oItem.ConsultarPRCheques("*", "NumSolicitud='" & Me.pNoSolic & "'", "", sUsuario, sPassword, sSucursal)
        '    fg.DataSource = ds.Tables(0)
        '    Encabezado()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    'Private Sub btnSigTb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSigTb1.Click
    '    If Me.tbPpal.SelectedIndex <> 2 Then Me.tbPpal.SelectedIndex = Me.tbPpal.SelectedIndex() + 1
    'End Sub

    'Private Sub btAtrasTb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtrasTb2.Click
    '    If Me.tbPpal.SelectedIndex <> 0 Then Me.tbPpal.SelectedIndex = Me.tbPpal.SelectedIndex() - 1
    'End Sub



    Private Sub EncabezadoDeducciones()

        Try
            Dim oCred As New wrPrestamo.wsLibPrest, dr As DataRow, ds As New DataSet, vTotal As Double
            ds = oCred.ConsultarPRDeduccionesPrestamos("*", "NumSolicitud=" & Me.pNoSolic & "", "Correlativo", sUsuario, sPassword, sSucursal)
            For Each dr In ds.Tables(0).Rows
                If dr("Iva") = "1" Then
                    dr("MontoFijo") = dr("MontoFijo") '* 1.13
                End If
                vTotal = Math.Round(vTotal + dr("total"), 2)
            Next
            Me.lblMonto.Text = "Total: $" & Format(Math.Round(vTotal, 2), "##,###,###.00")

            fgDeducciones.DataSource = ds.Tables(0)
            fgDeducciones.Cols.Item(1).Caption = "No."
            fgDeducciones.Cols.Item(2).Caption = "Solicitud"
            fgDeducciones.Cols.Item(3).Caption = "Cód. Préstamo"
            fgDeducciones.Cols.Item(4).Caption = "Cód. Deducción"
            fgDeducciones.Cols.Item(5).Caption = "Descripción"
            fgDeducciones.Cols.Item(8).Caption = "Monto"
            fgDeducciones.Cols.Item(8).Format = "##0.00"
            fgDeducciones.Cols.Item(1).Width = 0
            fgDeducciones.Cols.Item(2).Width = 77
            fgDeducciones.Cols.Item(3).Width = 100
            fgDeducciones.Cols.Item(4).Width = 100
            fgDeducciones.Cols.Item(5).Width = 120
            fgDeducciones.Cols.Item(6).Width = 0
            fgDeducciones.Cols.Item(7).Width = 0
            fgDeducciones.Cols.Item(8).Width = 77
            fgDeducciones.Cols.Item(9).Width = 0
            fgDeducciones.Cols.Item(10).Width = 0
            fgDeducciones.Cols.Item(11).Width = 0
            fgDeducciones.Cols.Item(12).Width = 0
            fgDeducciones.Cols.Item(13).Width = 0
            fgDeducciones.Cols.Item(14).Width = 0
            fgDeducciones.Cols.Item(15).Width = 0
            fgDeducciones.Cols.Item(16).Width = 0
            fgDeducciones.Cols.Item(17).Width = 0
            fgDeducciones.Cols.Item(18).Width = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkRef_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRef.CheckedChanged
        If Me.chkRef.Checked = True Then
            Me.c1nMontoRef.ReadOnly = False
        Else
            Me.c1nMontoRef.ReadOnly = True
        End If
    End Sub

    Private Sub btImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImagen.Click
        Dim openDlg As OpenFileDialog = New OpenFileDialog
        Dim Resultado As DialogResult
        Try
            openDlg.Filter = "Archivos de Word (*.doc)|*.doc|Archivos de Excel (*.xls)|*.xls|Archivos de Texto (*.txt)|*.txt|Archivos xml (*.xml)|*.xml"
            Resultado = openDlg.ShowDialog()

            If Resultado = DialogResult.OK Then
                Me.txtArchivo.Text = openDlg.FileName
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbFormaPagoP2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFormaPagoP2.SelectedIndexChanged
        If Me.cbFormaPagoP2.SelectedIndex = 1 Then
            Me.txtCodPagaduria.ReadOnly = False
        Else
            Me.txtCodPagaduria.ReadOnly = True
        End If
        If Me.cbFormaPagoP2.SelectedIndex = 3 Then
            Me.txtNoCuenta.Enabled = True
        Else
            Me.txtNoCuenta.Enabled = False
        End If
    End Sub

    Private Sub txtNoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.DoubleClick
        Dim frm As New frmAGenerico, Fila As DataRowCollection, sTexto As String, vCodTipoAhorro As String
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro"), dr As DataRow

        Try

            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarCuentaAhorroTipoAhorro("a.CodTipoAhorro,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.NoCuentaAnterior,a.FechaApertura,a.Cuota,a.SaldoDisponible_CuentaAhorro as Saldo__", "a.Dui='" & pDui & "' and a.Estado<>'C' and a.Estado<>'B' and Estado<>'D'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
            frm.Text = "Buscar Cuenta"
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.C1fgrdResultado.Cols.Item(6).Format = "##0.00"
            frm.C1fgrdResultado.Cols.Item(7).Format = "##0.00"
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then

                sTexto = frm.Resultado3.Trim
                ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,FechaApertura,Cuota,SaldoDisponible_CuentaAhorro,SaldoInteresPendiente,NoLibreta,Estado,Pignorado", "NoCuenta='" & sTexto.Trim & "' and Estado<>'C' and Estado<>'B'", "NoCuenta", sUsuario, sPassword, sSucursal)
                dr = ds.Tables("AhCuentasAhorro").Rows(0)
                Me.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), 0, dr("NoCuenta"))
                Me.txtCodTipoAhorro.Text = IIf(IsDBNull(dr("CodTipoAhorro")), 0, dr("CodTipoAhorro"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEstado.SelectedIndexChanged
        Select Case Me.cbEstado.SelectedIndex
            Case 0
                Me.cbConclusion.SelectedIndex = 0
                Me.txtEstado.Text = "(F) : Faltan Datos"
            Case 1
                Me.cbConclusion.SelectedIndex = 0
                Me.txtEstado.Text = "(E) : Entrega Completa"
            Case 2
                Me.cbConclusion.SelectedIndex = 0
                Me.txtEstado.Text = "(L) : Analizada"
            Case 3
                Me.cbConclusion.SelectedIndex = 2
                Me.txtEstado.Text = "(A) : Aprobada"
            Case 5
                Me.cbConclusion.SelectedIndex = 2
                Me.txtEstado.Text = "(P) : Pendiente"
            Case 6
                Me.cbConclusion.SelectedIndex = 2
                Me.txtEstado.Text = "(M) : Desembolso"
            Case 4
                Me.cbConclusion.SelectedIndex = 1
                Me.txtEstado.Text = "(D) : Denegado"
        End Select
    End Sub

    Private Sub txtCodPagaduria_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPagaduria.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Pagaduría"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            ds = oPerif.ConsultarPagaduria("codPagaduria,Nombre,categoria", "", "CodPagaduria", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodPagaduria.Text = ofrm.Resultado.Trim
            Me.txtPagaduria.Text = ofrm.Resultado2.Trim
            Me.lblCategoria.Text = If(ofrm.Resultado3.Trim.Length = 0, "N/E", ofrm.Resultado3.Trim)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub







    Private Sub txtCodItem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodItem.DoubleClick
        Try

            Dim oCaja As New wrCaja.wsLibCaja, ds As New Data.DataSet("Items"), dr As DataRow
            Dim frm As New frmAGenerico, sTexto As String
            frm.Text = "Buscar Item facturable"

            ds = oCaja.ObtenerListaItems("*", "IdRubro='2' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oCaja.ObtenerItem(sTexto, "IdRubro='2' and IdApp=3 and Tipo_Item='P'", sUsuario, sPassword, sSucursal)
                dr = ds.Tables("CAItemsFact").Rows(0)
                Me.txtCodItem.Text = Trim(dr("CodItem"))
                Me.txtItem.Text = Trim(dr("Descripcion"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla CAItemsFact- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkCasoEspecial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCasoEspecial.CheckedChanged
        If Me.chkCasoEspecial.Checked = True Then
            Me.txtCodItem.ReadOnly = False
        Else
            Me.txtCodItem.Text = ""
            Me.txtItem.Text = ""
            Me.txtCodItem.ReadOnly = True
        End If
    End Sub

    Private Sub txtCodTipoCredito_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoCredito.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipo de Crédito"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, oApp As New wrAdmin.wsLibAdmin
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipoCreditos("CodTipoCredito as Codigo,Descripcion", "(FechaIniProm<='" & oApp.Fecha.ToShortDateString & "' and FechaFinProm>='" & oApp.Fecha.ToShortDateString & "' and Promocion='1') or (Promocion<>'1' or Promocion is null)", "CodTipoCredito", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoCredito.Text = ofrm.Resultado.Trim
            txtTipoCredito.Text = ofrm.Resultado2.Trim

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Puntos_DPF() As Double
        Try
            Dim oAh As New wrAhorro.wsLibAhorro, oAsoc As New wrAsociados.wsLibAsoc, vPuntosDPF As Double
            Dim dsG As New DataSet, dr As DataRow, oCred As New wrCredito.wsLibCred, ds As New Data.DataSet

            ds = oAsoc.ConsultarParametros("*", "", "SalarioMinimo", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vPuntosDPF = IIf(IsDBNull(dr("PuntosDPF")), 0, dr("PuntosDPF"))
            End If

            dsG = oCred.ConsultarGarantias("NoCuenta", "CodTipoGarantia='00002' and NumSolicitud=" & Me.pNoSolic & "", "CodGarantia", sUsuario, sPassword, sSucursal)
            If dsG.Tables(0).Rows.Count > 0 Then
                dr = dsG.Tables(0).Rows(0)
                If Not dr("NoCuenta") Is DBNull.Value Then
                    dsG = oAh.ConsultarCuentaAhorro("TasaInteres", "NoCuenta='" & dr("NoCuenta") & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                    If dsG.Tables(0).Rows.Count > 0 Then
                        dr = dsG.Tables(0).Rows(0)
                        If Not dr("TasaInteres") Is DBNull.Value Then
                            Me.C1NEInteres.Value = dr("TasaInteres") + vPuntosDPF
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#Region "Transferencias"
    Private Sub cbTipoTrans_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoTrans.SelectedIndexChanged
        If Me.cbTipoTrans.SelectedIndex = 2 Then
            Me.lblNoctaAux.Text = "Ingrese el Cod. de Préstamo:"
        Else
            Me.lblNoctaAux.Text = "Ingrese el No. de la Cta:"
        End If
    End Sub
    Dim IdCtaContable As String
    Dim CodTipoAhorro As String
    Dim Saldo As Double
    Dim Saldo_Disponible As Double
    Dim Nolibreta As String
    Dim TasaInteres As Double
    Dim Estado As String
    Protected Function ConsultarTransferencias(ByVal Numsolicitud As Integer) As Integer
        Dim DtsTran As New DataSet
        DtsTran = Ahorros.ConsultarTransferencia("a.NUMSOLICITUD", "NUMSOLICITUD = " & Numsolicitud, "", 0, sUsuario, sPassword, sSucursal)
        Return DtsTran.Tables(0).Rows.Count
    End Function
    Protected Sub llenarTransferencias()
        Dim DtsTran As New DataSet
        DtsTran = Ahorros.ConsultarTransferencia(" DISTINCT a.NumSolicitud,a.CodTransferencia,b.Nocuenta,b.Valor,a.Fecha,a.Responsable,rTRIM(a.Observacion) AS Observacion", " a.NUMSOLICITUD = " & pNoSolic & " and b.Tipo= 'A' ", "", 0, sUsuario, sPassword, sSucursal)
        Me.dgTransferencias.DataSource = DtsTran.Tables(0)

        'Crea Boton para Imprimir Transferencias
        Dim btnImprimir As New DataGridViewButtonColumn
        With btnImprimir
            .Width = 80
            .UseColumnTextForButtonValue = True
            '.DefaultCellStyle.BackColor = Color.Teal
            .DefaultCellStyle.ForeColor = Color.Black
            .Text = "Imprimir"
            .Name = "Imprimir"
            .HeaderText = "Imprimir Comprobante"
        End With
        Me.dgTransferencias.Columns.Add(btnImprimir)

        Me.dgTransferencias.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgTransferencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgTransferencias.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub txtReferencia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReferencia.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim Dts As DataSet
        If Me.cbTipoTrans.SelectedIndex = 0 And chkPrincipal.Checked = True Then   'Ahorros
            Dts = Ahorros.ConsultarCtasAhorroDUI("a.CodTipoAhorro as Codigo,b.Descripcion as Tipo_Ahorro, " &
                                             "a.NoCuenta, " &
                                             "a.Nolibreta,a.TasaInteres,a.Saldo_CuentaAhorro [Saldo], " &
                                             "a.SaldoDisponible_CuentaAhorro [Saldo Disponible],b.IdCuenta as Cuenta_Contable,a.Estado",
                                             "a.DUI='" & Dui & "' AND a.Estado <> 'C' and left(a.codtipoahorro,1)= '" & libAhorro.tiposAhorro.vista & "' ", "", sUsuario, sPassword, sSucursal)

        ElseIf Me.cbTipoTrans.SelectedIndex = 1 And chkPrincipal.Checked = False Then 'Aportacione s
            Dts = Ahorros.ConsultarCtasAhorroDUI("a.CodTipoAhorro as Codigo,b.Descripcion as Tipo_Ahorro, " &
                                             "a.NoCuenta, " &
                                             "a.Nolibreta,a.TasaInteres,a.Saldo_CuentaAhorro [Saldo], " &
                                             "a.SaldoDisponible_CuentaAhorro [Saldo Disponible],b.IdCuenta as Cuenta_Contable,a.Estado",
                                         "a.DUI='" & Dui & "' AND a.Estado <> 'C' and left(a.codtipoahorro,1) = '" & libAhorro.tiposAhorro.aportaciones & "'", "", sUsuario, sPassword, sSucursal)

            'ElseIf Me.cbTipoTrans.SelectedIndex = 2 Then 'Prestamos
            '    Dts = Creditos.ConsultarPrestamos("DUI,NUMSOLICITUD,CODPRESTAMO,SALDO_CAPITAL,SALDODIA_INTERES,SALDODIA_CAPITALMORA,SALDODIA_INTERESMORA", "DUI='" & Dui & "' and ESTADO='A' AND BAJA = 0", "", sUsuario, sPassword, sSucursal)
        End If
        If Dts.Tables(0).Rows.Count > 0 Then
            ofrm.Text = "Seleccionar Referencia:"
            ofrm.Datos = Dts
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            'Valida que el form retorne algun valor 
            If ofrm.Resultado.Trim <> "" Then
                CodTipoAhorro = ofrm.Resultado
                Me.txtReferencia.Text = ofrm.Resultado3.Trim
                Nolibreta = ofrm.Resultado4
                TasaInteres = ofrm.Resultado5
                Saldo = ofrm.Resultado6
                Saldo_Disponible = ofrm.Resultado7
                IdCtaContable = ofrm.Resultado8
                Estado = ofrm.Resultado9
            End If
        Else
            MsgBox("Por favor seleccione un tipo de transferencia valida", MsgBoxStyle.Information, "Módulu - Créditos")
        End If
    End Sub


    Private Sub dgTransferencias_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTransferencias.CellContentClick
        Try
            If Me.dgTransferencias.Rows.Count > 0 Then
                If Me.dgTransferencias.Columns(e.ColumnIndex).Name = "Eliminar" Then
                    If MsgBox("Desea eliminar la transferencia", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Créditos") = 6 Then
                        If Me.dgTransferencias.RowCount = 1 Then
                            Me.dgTransferencias.DataSource = ""
                            Me.dgTransferencias.Columns.Clear()
                        Else
                            Dim Indice As Integer
                            Indice = Me.dgTransferencias.CurrentRow.Index
                            'Eliminamos Fila de Datagrid
                            Me.dgTransferencias.Rows.RemoveAt(Indice)
                            'Elminamos fila de datatable.
                            Dim FilaEliminar As DataRow
                            FilaEliminar = dtTransferencias.Rows(Indice)
                            dtTransferencias.Rows().Remove(FilaEliminar)
                        End If

                    End If
                ElseIf Me.dgTransferencias.Columns(e.ColumnIndex).Name = "Imprimir" Then
                    Dim CodTransferencia As Integer
                    Dim Indice As Integer
                    Dim DtsTransferencias
                    Indice = Me.dgTransferencias.CurrentRow.Index
                    CodTransferencia = Me.dgTransferencias.Item("CodTransferencia", Indice).Value
                    DtsTransferencias = Caja.ComprobanteTransferenciasDesembolso(CodTransferencia, Format(Now, "Short Date"))
                    Dim ofrm As New frmVisor(DtsTransferencias, 56, 0)
                    ofrm.ShowDialog()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo Créditos")
        End Try
    End Sub
    Private Sub EstiloDg()
        Me.dgTransferencias.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgTransferencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgTransferencias.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgTransferencias.Columns("IdCtaContable").Visible = False

        Me.dgTransferencias.Columns("Eliminar").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.dgTransferencias.Columns("N").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTransferencias.Columns("Tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTransferencias.Columns("Cta Destino").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTransferencias.Columns("Monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTransferencias.Columns("Principal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'Me.dgTransferencias.Columns("idCuenta").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'Me.dgTransferencias.Columns("Cta Origen").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub Limpiar()
        Me.txtReferencia.Text = ""
        Me.txtMonto.Value = 0
        Me.txtObsTran.Text = ""
        Me.chkPrincipal.Checked = False
    End Sub

    Private Sub C1NEMontoGarantia_TextChanged(sender As Object, e As EventArgs) Handles C1NEMontoGarantia.TextChanged

    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        If txtCodigo.Text.Trim.Length > 0 Then
            Dim frm As New frmVisorRS
            OpcionRS = 88
            With frm
                .codPrstamo = txtCodigo.Text.Trim
                .Show()
            End With
        Else
            MsgBox("No existe código de préstamo.", MsgBoxStyle.Critical)
        End If

        'Try
        '    Me.Cursor = Cursors.WaitCursor

        '    Dim ofrm As New frmVisorRep
        '    'ofrm.ReportePrestamos = AlcalaLibs.Prestamos.clsPrestamos.ReportesPrestamos.DetalleSolicitud
        '    'ofrm.ReportePrestamos = sifLib.Prestamos.clsPrestamos.ReportesPrestamos.DetalleSolicitud
        '    'ofrm.CodigoPrestamo = pNoSolic
        '    'ofrm.DuiAsociado = pDui
        '    'ofrm.x = Me.cbCARGO.SelectedIndex
        '    'ofrm.Cuenta = "V"
        '    If Me.dgTransferencias.RowCount <= 0 Then
        '        ofrm.ReportePrestamos = sifLib.Prestamos.clsPrestamos.ReportesPrestamos.DetalleSolicitud
        '        ofrm.CodigoPrestamo = pNoSolic
        '        ofrm.DuiAsociado = pDui
        '        ofrm.x = Me.cbCARGO.SelectedIndex
        '        ofrm.Cuenta = "V"
        '    Else
        '        Dim CodTransferencia As Integer
        '        ofrm.ReportePrestamos = sifLib.Prestamos.clsPrestamos.ReportesPrestamos.DetalleSolicitud
        '        ofrm.CodigoPrestamo = pNoSolic
        '        ofrm.DuiAsociado = pDui
        '        'ofrm.CodTransferencia =
        '        ofrm.x = Me.cbCARGO.SelectedIndex
        '        ofrm.Cuenta = "V"
        '    End If
        '    ofrm.Show()
        '    Me.Cursor = Cursors.Default

        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    MsgBox(mensajeError, MsgBoxStyle.Critical)
        'End Try
    End Sub

    Private Sub btAtrasTb2_1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSigTb1_1_Click(sender As Object, e As EventArgs) Handles btnSigTb1_1.Click
        Try
            If Me.tbPpal.SelectedIndex <> 2 Then Me.tbPpal.SelectedIndex = Me.tbPpal.SelectedIndex() + 1
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String, Filas As Data.DataRowCollection, ds As New Data.DataSet
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, pTasaIntMora As Double, pFecVen As Date, pGeneraReserva As String

            If dtpFec1Cuota.Value = dtpFecOtorgamiento.Value Then
                MsgBox("Fecha de primera cuota no debe ser igual a la fecha de otorgamiento.", MsgBoxStyle.Information)
                Exit Sub
            End If

            If Mid(Me.cbEstado.Text, 2, 1) = "M" Then

                Dim pCodPrestamo As String, pCodTipoCred As String, pNoSocio As String
                ds = oCred.ConsultarSolP2Credito("*", "NumSolicitud='" & Me.pNoSolic & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables("CRSolP2Credito").Rows()
                If Filas.Count > 0 Then
                    pTasaIntMora = IIf(IsDBNull(Filas.Item(0)("InteresMoratorio")), 0, Filas.Item(0)("InteresMoratorio"))
                Else
                    MsgBox("Los datos del crédito en la Solicitud no han sido creados, verifíque.", MsgBoxStyle.Information, "Módulo Créditos")
                    Exit Sub
                End If

                ds = oCred.ConsultarDatGral("*", "NumSolicitud='" & Me.pNoSolic & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables("CRSolDatosGeneral").Rows()
                If Filas.Count > 0 Then
                    pNoSocio = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                End If

                pGeneraReserva = IIf(Me.chkGeneraReserva.Checked = True, "1", "0")

                '*********************************
                'Modificacion 08/10/2012        **
                'Javier Martinez                **
                'Se incluyo en campo arreglo    **
                '**************************************************************************************************************************************************************
                If pTasaIntMora = 0 Then
                    Dim dtsTim As New DataSet
                    dtsTim = oCred.ConsultarTipoCreditos("interesMoratorio", "codTipoCredito='" & txtCodTipoCredito.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
                    If dtsTim.Tables(0).Rows.Count > 0 Then
                        pTasaIntMora = dtsTim.Tables(0).Rows(0).Item("interesMoratorio")
                    End If
                End If
                '**************************************************************************************************************************************************************
                '**************************************************************************************************************************************************************
                ds = oCred.ConsultarPrestamos("NumSolicitud,estado", "NumSolicitud='" & Me.pNoSolic & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables("PRPrestamos").Rows()
                If Filas.Count > 0 Then
                    '*********************************
                    'Modificacion 08/10/2012        **
                    'Javier Martinez                **
                    'Se incluyo en campo arreglo    **
                    '*********************************
                    If ds.Tables(0).Rows(0).Item("estado").ToString.Equals("A") Then
                        pCampos = "Observaciones='" & Me.txtObs.Text.Trim &
                           "',CasoEspecial='" & Math.Abs(CInt(Me.chkCasoEspecial.Checked)) &
                           "',CodItem='" & Me.txtCodItem.Text.Trim &
                           "',Arreglo = '" & Me.chkArreglo.Checked &
                           "',EnviarAseguradora = '" & Me.rbEnvAseg.Checked &
                           "',NoEnviarAseguradora = '" & Me.rbNoEnvAseg.Checked &
                           "', ExtraPrima = '" & chkExtPrima.Checked &
                           "',TasaExtPrima = " & Me.txtTasaExtPrima.Value & " "
                        oCred.ModificarPrestamos(Me.pNoSolic, pCampos, sUsuario, sPassword, sSucursal)
                    ElseIf ds.Tables(0).Rows(0).Item("estado").ToString.Equals("D") Then
                        pCampos = "Observaciones='" & Me.txtObs.Text.Trim &
                         "',CasoEspecial='" & Math.Abs(CInt(Me.chkCasoEspecial.Checked)) &
                         "',CodItem='" & Me.txtCodItem.Text.Trim &
                         "',Arreglo = '" & Me.chkArreglo.Checked &
                         "',FechaOtorgamiento = '" & Format(dtpFecOtorgamiento.Value, "Short Date") &
                         "',FechaPrimeraCuota = '" & Format(Me.dtpFec1Cuota.Value, "Short Date") &
                         "',FechaVencimiento = '" & dtpFec1Cuota.Value.AddMonths(Me.C1NEPlazo.Value - 1) &
                         "',Refinanciamiento= '" & IIf(Me.chkRef.Checked = True, "1", "0") &
                         "',CodTipoCredito = '" & txtCodTipoCredito.Text.Trim &
                         "',Tasa_Interes = '" & C1NEInteres.Value &
                         "',Monto = '" & C1NEMonto.Value &
                         "',fechaActa = '" & Format(dtpFechaActa.Value, "Short Date") &
                         "',cuotaTotal= '" & c1nCuota.Value &
                         "',noActa= '" & txtNoActa.Text.Trim &
                         "',monto_garantia= '" & Me.C1NEMontoGarantia.Value &
                         "',MontoRefinanciamiento= '" & Me.c1nMontoRef.Value &
                         "',saldo_Capital = '" & C1NEMonto.Value &
                         "',EnviarAseguradora = '" & Me.rbEnvAseg.Checked &
                         "',NoEnviarAseguradora = '" & Me.rbNoEnvAseg.Checked &
                         "', ExtraPrima = '" & chkExtPrima.Checked &
                         "',TasaExtPrima = " & Me.txtTasaExtPrima.Value & " "
                        If oCred.ModificarPrestamos(Me.pNoSolic, pCampos, sUsuario, sPassword, sSucursal) = True Then
                            MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Créditos - Prestamos")
                        End If
                    End If

                Else
                    '*********************************
                    'Modificacion 08/10/2012        **
                    'Javier Martinez                **
                    'Se incluyo en campo arreglo    **
                    '*********************************
                    Dim vValor As String, pDigito As String
                    'vValor = oCred.ObtenerCorrelativoPrestamos(Month(Me.dtpFecOtorgamiento.Value),
                    '                                           Year(Me.dtpFecOtorgamiento.Value),
                    '                                           sUsuario, sPassword, sSucursal, txtCodTipoCredito.Text).ToString
                    '=================================
                    '=================================

                    '=================================
                    '=================================
                    'Generar Cod. de Préstamo
                    Dim dtsTipoCred As New DataSet
                    Dim tipoCred As String
                    Dim corte() As String
                    Dim cadCodTexto As String
                    Dim correlativo As String
                    Dim dtsCorrelativo As New DataSet
                    correlativo = oCred.ObtenerCorrelativoPrestamo(Me.pDui, sUsuario, sPassword, sSucursal, txtCodTipoCredito.Text.Trim).ToString.PadLeft(2, "0")
                    pCodPrestamo = txtNoSocio.Text.Trim.ToString & txtCodTipoCredito.Text.ToString.Trim & correlativo
                    Me.CodPrestamo = pCodPrestamo
                    txtCodigo.Text = pCodPrestamo
                    '=================================
                    '=================================

                    pDigito = 0 'oAhorro.ObtieneDigitoVerificador(pCodPrestamo.Trim, sUsuario, sPassword, sSucursal)
                    pFecVen = dtpFecOtorgamiento.Value.AddMonths(Me.C1NEPlazo.Value)
                    pCodTipoCred = Me.txtCodTipoCredito.Text.Trim
                    vCodigoTipoCredito = Me.txtCodTipoCredito.Text.Trim
                    pCampos = "CodPrestamo,CodTipoCredito,NumSolicitud,NoSocio,Dui," &
                    "Monto,Monto_Garantia,Tasa_Interes,PlazoMeses,NoActa,FechaActa," &
                    "ArchivoActa,FechaOtorgamiento,FechaPrimeraCuota,FechaVencimiento," &
                    "GeneraReserva,CodTablaAmortiza,Tasa_Interes_Mora,Saldo_Capital," &
                    "Intereses_pagados,SaldoDia_Interes,SaldoDia_CapitalMora,SaldoDia_InteresMora," &
                    "SaldoDia_SeguroDeuda,SaldoDia_SeguroDaniosyLA,SaldoDia_SeguroVida," &
                    "SaldoDia_SeguroDesempleo,SaldoDia_Aportacion,SaldoDia_Ahorro," &
                    "SaldoDia_ComisionManejo,SaldoDia_Otros,Cuota,DiasMora,Digito," &
                    "Refinanciamiento,MontoRefinanciamiento,Estado,Saldo_CapMoraGracia," &
                    "Saldo_IntMoraGracia,DiasMoraGracia,DiaGracia,FechaUltimoPago,Categoria,Arreglo"
                    pValores = "'" & pCodPrestamo & "','" & pCodTipoCred & "'," & pNoSolic &
                    ",'" & pNoSocio & " ','" & pDui & "'," & Val(Me.C1NEMonto.Value) &
                    "," & Val(Me.C1NEMontoGarantia.Value) & "," & Val(Me.C1NEInteres.Value) &
                    "," & Val(Me.C1NEPlazo.Value) & ",'" & Trim(Me.txtNoActa.Text) &
                    "','" & Format(Me.dtpFechaActa.Value, "dd/MM/yyyy") &
                    "','" & Trim(Me.txtArchivo.Text) & "','" & Format(Me.dtpFecOtorgamiento.Value, "dd/MM/yyyy") &
                    "','" & Format(Me.dtpFec1Cuota.Value, "dd/MM/yyyy") & "','" & Format(pFecVen, "dd/MM/yyyy") &
                    "','" & pGeneraReserva & "',''," & pTasaIntMora &
                    "," & Val(Me.C1NEMonto.Value) & ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,'" & pDigito &
                    "','" & IIf(Me.chkRef.Checked = True = True, "1", "0") & "'," & Me.c1nMontoRef.Value &
                    ",'D',0,0,0,'N','" & Format(Me.dtpFecOtorgamiento.Value, "dd/MM/yyyy") &
                    "','A','" & Me.chkArreglo.Checked & "'"
                    If oCred.InsertarPrestamos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Créditos - Prestamos")
                    End If
                    Me.tbCheques.Enabled = True
                End If
            End If

            pCampos = "Estado='" & Mid(Me.cbEstado.Text, 2, 1) & "',Conclusion='" & Mid(Me.cbConclusion.Text, 2, 1) & "',FechaConclusion='" & Format(Now, "dd/MM/yyyy") & "'"
            If oCred.ModificarSolCredR(pNoSolic, pCampos, sUsuario, sPassword, sSucursal) = False Then
                MsgBox("El Estado no puedo ser modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
            End If

            If Me.txtCodPagaduria.Text.Trim = "" Then Me.txtCodPagaduria.Text = "00000"
            pGeneraReserva = IIf(Me.chkGeneraReserva.Checked = True, "1", "0")
            pFecVen = dtpFec1Cuota.Value.AddMonths(Me.C1NEPlazo.Value - 1)
            pCampos = "MontoSolicitado=" & Val(Me.C1NEMonto.Value) & ",FechaOtorgamiento='" & Format(Me.dtpFecOtorgamiento.Value, "dd/MM/yyyy") & "',Plazo=" & Val(Me.C1NEPlazo.Value) & ",FormaPago='" & Me.cbFormaPagoP2.SelectedIndex & "',Interes=" & Me.C1NEInteres.Value & ",NoCuenta='" & Me.txtNoCuenta.Text.Trim & "',CuotaTotal=" & Val(Me.c1nCuota.Value) & ",FechaPrimeraCuota='" & Format(Me.dtpFec1Cuota.Value, "dd/MM/yyyy") & "',GeneraReserva='" & pGeneraReserva & "',FechaVencimiento='" & Format(pFecVen, "dd/MM/yyyy") & "',CodPagaduria='" & Me.txtCodPagaduria.Text.Trim & "',Observaciones='" & Me.txtObs.Text.Trim & "',CodTipoCredito='" & Me.txtCodTipoCredito.Text.Trim & "',CondicionesEspeciales='" & Me.txtCondicionEspecial.Text & "'"
            oCred.ModificarSolP2Credito(pNoSolic, pCampos, sUsuario, sPassword, sSucursal)

            '   Me.Dispose()

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btGastosEscrituracion1_Click(sender As Object, e As EventArgs) Handles btGastosEscrituracion1.Click
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Gastos de Escrituración"
        Dim oPerif As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest, ds As New Data.DataSet, pCampos As String, pValores As String, vPorc As Double, vAplicaIva As String, vAplicaPorc As Boolean, vValor As Double
        Try
            ds = oPerif.ConsultarPRDeducciones("CodDeduccion,Descripcion,Monto,Iva,AplicaPorcentaje", "CodTipoCredito='" & vCodigoTipoCredito & "' and Tipo='0'", "CodDeduccion", wrPrestamo.TipoDeduccion.Escrituracion, sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then

                Dim vNo As String, vCant As Integer
                vNo = InputBox("Digite el Número de Cuotas:", "Deducciones", "1")
                If vNo.Trim = "" Then Exit Sub
                If IsNumeric(vNo) = False Then Exit Sub

                vCant = vNo

                vPorc = ofrm.Resultado4.Trim
                If vPorc > 0 Then
                    vAplicaIva = "1"
                Else
                    vAplicaIva = "0"
                End If
                If ofrm.Resultado5.Trim = "1" Then
                    vAplicaPorc = True
                    vValor = Me.C1NEMonto.Value * (Val(ofrm.Resultado3.Trim) / 100)
                    vValor = vValor * vCant
                Else
                    vAplicaPorc = False
                    vValor = Val(ofrm.Resultado3.Trim)
                    vValor = vValor * vCant
                End If
                pCampos = "NumSolicitud,CodPrestamo,CodDeduccion,Descripcion,MontoFijo,Iva,Tipo"
                pValores = "" & Me.pNoSolic & ",'" & Me.CodPrestamo & "','" & ofrm.Resultado.Trim & "','" & ofrm.Resultado2.Trim & "'," & vValor & ",'" & vAplicaIva & "','0'"
                If oPerif.InsertarPRDeduccionesPrestamos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    EncabezadoDeducciones()
                Else
                    MsgBox("Los datos de la deducción NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btGastosHonorarios1_Click(sender As Object, e As EventArgs) Handles btGastosHonorarios1.Click
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Gastos de Honorarios"
        Dim oPerif As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest, ds As New Data.DataSet, pCampos As String, pValores As String, vPorc As Double
        Try
            ds = oPerif.ConsultarPRDeducciones("CodDeduccion,Descripcion,Tarifa", "CodTipoCredito='" & vCodigoTipoCredito & "' and Tipo='1' and Monto<=" & Me.C1NEMonto.Value & " and MontoMax>=" & Me.C1NEMonto.Value & "", "CodDeduccion", wrPrestamo.TipoDeduccion.Honorario, sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                pCampos = "NumSolicitud,CodPrestamo,CodDeduccion,Descripcion,MontoFijo,Iva,Tipo"
                pValores = "" & Me.pNoSolic & ",'" & Me.CodPrestamo & "','" & ofrm.Resultado.Trim & "','" & ofrm.Resultado2.Trim & "'," & ofrm.Resultado3.Trim & ",'0','1'"
                If oPerif.InsertarPRDeduccionesPrestamos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    EncabezadoDeducciones()
                Else
                    MsgBox("Los datos de la deducción NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub btGastosTramitacion1_Click(sender As Object, e As EventArgs) Handles btGastosTramitacion1.Click
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Gastos de Tramitación"
        Dim oPerif As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest, ds As New Data.DataSet, pCampos As String, pValores As String, vPorc As Double, vAplicaIva As String, vAplicaPorc As Boolean, vValor As Double
        Try
            'Partidas Automaticas Desemboloso de Creditos
            'Modificiacion 14/09/2012 Javier Martinez
            'Cambio de función, conversión a SP. 
            'ds = oPerif.ConsultarPRDeducciones("CodDeduccion,Descripcion,Monto,Iva,AplicaPorcentaje", "CodTipoCredito='" & vCodigoTipoCredito & "' and Tipo='2'", "CodDeduccion", wrPrestamo.TipoDeduccion.Tramitacion, sUsuario, sPassword, sSucursal)
            ds = Creditos.Consultar_PrDeducciones(4, vCodigoTipoCredito, 0, 2)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                Dim vNo As String, vCant As Integer
                vNo = InputBox("Digite el Número de Cuotas:", "Deducciones", "1")
                If vNo.Trim = "" Then Exit Sub
                If IsNumeric(vNo) = False Then Exit Sub

                vCant = vNo

                vPorc = ofrm.Resultado4.Trim
                If vPorc > 0 Then
                    vAplicaIva = "1"
                Else
                    vAplicaIva = "0"
                End If
                If ofrm.Resultado5.Trim = "1" Then
                    'Modificacion 08/10/2012
                    'Javier Martinez
                    'Se modifica por mal calculo de aproximaciones
                    vAplicaPorc = True
                    'vValor = Me.C1NEMonto.Value * (Val(ofrm.Resultado3.Trim) / 100)
                    'vValor = vValor * vCant
                    vValor = Math.Round(Me.C1NEMonto.Value * (Val(ofrm.Resultado3.Trim) / 100), 2)
                    vValor = Math.Round(vValor * vCant, 2)

                Else
                    vAplicaPorc = False
                    vValor = Val(ofrm.Resultado3.Trim)
                    vValor = Math.Round(vValor * vCant, 2)
                End If

                '
                Dim vMt As String, vMto As Double
                vMt = InputBox("Digite el monto:", "Deducciones", "0")
                If vMt.Trim = "" Then Exit Sub
                If IsNumeric(vMt) = False Then Exit Sub
                vMto = vMt
                If vMto > 0 Then
                    vValor = vMto
                    If ofrm.Resultado5.Trim = "1" Then
                        'Modificacion 08/10/2012
                        'Javier Martinez
                        'Se modifica por mal calculo de aproximaciones
                        vAplicaPorc = True
                        vValor = Math.Round(Me.C1NEMonto.Value * (Val(vValor) / 100), 2)
                        vValor = Math.Round(vValor * vCant, 2)
                        'vValor = Me.C1NEMonto.Value * (Val(vValor) / 100)
                        'vValor = vValor * vCant
                    Else
                        vAplicaPorc = False
                        vValor = Val(vValor)
                        vValor = Math.Round(vValor * vCant, 2)
                        'vValor = vValor * vCant
                    End If
                End If
                '***************************************************************************************
                '***************************************************************************************
                'Javier Escobar 13/03/2013
                'Verifica si deduccion tiene restricciones
                Dim DtsDeducciones As New DataSet
                Dim ValidarMontoMax As Boolean
                Dim ValidarMontoMin As Boolean
                Dim MontoMin As Double
                Dim MontoMax As Double
                DtsDeducciones = Creditos.Consultar_PrCatGastosTramitacion(2, ofrm.Resultado6, "0")
                If DtsDeducciones.Tables(0).Rows.Count <> 0 Then
                    'Monto Minimo
                    If DtsDeducciones.Tables(0).Rows(0).Item("ValMontoMin") = True Then
                        MontoMin = DtsDeducciones.Tables(0).Rows(0).Item("MontoMinimo")
                        If vValor < MontoMin Then
                            vValor = MontoMin
                        End If
                    End If
                    'Monto Maximo
                    If DtsDeducciones.Tables(0).Rows(0).Item("ValMontoMax") = True Then
                        MontoMax = DtsDeducciones.Tables(0).Rows(0).Item("MontoMaximo")
                        If vValor > MontoMax Then
                            vValor = MontoMax
                        End If
                    End If
                End If
                '***************************************************************************************
                '***************************************************************************************
                Dim totalIva As Double = 0
                Dim total As Double = 0
                Dim iva As Double = 0
                If vAplicaIva = "1" Then
                    Dim dts As New DataSet
                    dts = asociados.ConsultarParametros("iva", "", "iva", sUsuario, sPassword, sSucursal)
                    If dts.Tables(0).Rows.Count > 0 Then
                        iva = dts.Tables(0).Rows(0).Item(0)
                        If iva > 0 Then
                            iva = iva / 100
                            totalIva = Math.Round(vValor * iva, 2)
                            total = Math.Round(vValor * (1 + iva), 2)
                        End If
                    End If
                Else
                    total = vValor
                End If

                pCampos = "NumSolicitud,CodPrestamo,CodDeduccion,Descripcion,MontoFijo,Iva,Tipo,totalIva,total"
                pValores = "" & Me.pNoSolic & ",'" & Me.CodPrestamo & "','" & ofrm.Resultado.Trim &
                    "','" & ofrm.Resultado2.Trim & "'," & vValor & ",'" & vAplicaIva & "','2', '" & totalIva & "', '" & total & "'"
                If oPerif.InsertarPRDeduccionesPrestamos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    EncabezadoDeducciones()
                Else
                    MsgBox("Los datos de la deducción NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
        'Dim ofrm As New frmAGenerico

        'ofrm.Text = "Buscar Gastos de Tramitación"
        'Dim oPerif As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest, ds As New Data.DataSet, pCampos As String, pValores As String, vPorc As Double, vAplicaIva As String, vAplicaPorc As Boolean, vValor As Double
        'Try
        '    'Partidas Automaticas Desemboloso de Creditos
        '    'Modificiacion 14/09/2012 Javier Martinez
        '    'Cambio de función, conversión a SP. 
        '    'ds = oPerif.ConsultarPRDeducciones("CodDeduccion,Descripcion,Monto,Iva,AplicaPorcentaje", "CodTipoCredito='" & vCodigoTipoCredito & "' and Tipo='2'", "CodDeduccion", wrPrestamo.TipoDeduccion.Tramitacion, sUsuario, sPassword, sSucursal)
        '    ds = Creditos.Consultar_PrDeducciones(4, vCodigoTipoCredito, 0, 2)
        '    ofrm.Datos = ds
        '    ofrm.ColSeleccion = 0
        '    ofrm.RefrescarGrid()
        '    ofrm.ShowDialog()
        '    If ofrm.Resultado.Trim <> "" Then
        '        Dim vNo As String, vCant As Integer
        '        vNo = InputBox("Digite el Número de Cuotas:", "Deducciones", "1")
        '        If vNo.Trim = "" Then Exit Sub
        '        If IsNumeric(vNo) = False Then Exit Sub

        '        vCant = vNo

        '        vPorc = ofrm.Resultado4.Trim
        '        If vPorc > 0 Then
        '            vAplicaIva = "1"
        '        Else
        '            vAplicaIva = "0"
        '        End If
        '        If ofrm.Resultado5.Trim = "1" Then
        '            'Modificacion 08/10/2012
        '            'Javier Martinez
        '            'Se modifica por mal calculo de aproximaciones
        '            vAplicaPorc = True
        '            'vValor = Me.C1NEMonto.Value * (Val(ofrm.Resultado3.Trim) / 100)
        '            'vValor = vValor * vCant
        '            vValor = Math.Round(Me.C1NEMonto.Value * (Val(ofrm.Resultado3.Trim) / 100), 2)
        '            vValor = Math.Round(vValor * vCant, 2)

        '        Else
        '            vAplicaPorc = False
        '            vValor = Val(ofrm.Resultado3.Trim)
        '            vValor = Math.Round(vValor * vCant, 2)
        '        End If

        '        '
        '        Dim vMt As String, vMto As Double
        '        vMt = InputBox("Digite el monto:", "Deducciones", "0")
        '        If vMt.Trim = "" Then Exit Sub
        '        If IsNumeric(vMt) = False Then Exit Sub
        '        vMto = vMt
        '        If vMto > 0 Then
        '            vValor = vMto
        '            If ofrm.Resultado5.Trim = "1" Then
        '                'Modificacion 08/10/2012
        '                'Javier Martinez
        '                'Se modifica por mal calculo de aproximaciones
        '                vAplicaPorc = True
        '                vValor = Math.Round(Me.C1NEMonto.Value * (Val(vValor) / 100), 2)
        '                vValor = Math.Round(vValor * vCant, 2)
        '                'vValor = Me.C1NEMonto.Value * (Val(vValor) / 100)
        '                'vValor = vValor * vCant
        '            Else
        '                vAplicaPorc = False
        '                vValor = Val(vValor)
        '                vValor = Math.Round(vValor * vCant, 2)
        '                'vValor = vValor * vCant
        '            End If
        '        End If
        '        '***************************************************************************************
        '        '***************************************************************************************
        '        'Javier Escobar 13/03/2013
        '        'Verifica si deduccion tiene restricciones
        '        Dim DtsDeducciones As New DataSet
        '        Dim ValidarMontoMax As Boolean
        '        Dim ValidarMontoMin As Boolean
        '        Dim MontoMin As Double
        '        Dim MontoMax As Double
        '        DtsDeducciones = Creditos.Consultar_PrCatGastosTramitacion(2, ofrm.Resultado6, "0")
        '        If DtsDeducciones.Tables(0).Rows.Count <> 0 Then
        '            'Monto Minimo
        '            If DtsDeducciones.Tables(0).Rows(0).Item("ValMontoMin") = True Then
        '                MontoMin = DtsDeducciones.Tables(0).Rows(0).Item("MontoMinimo")
        '                If vValor < MontoMin Then
        '                    vValor = MontoMin
        '                End If
        '            End If
        '            'Monto Maximo
        '            If DtsDeducciones.Tables(0).Rows(0).Item("ValMontoMax") = True Then
        '                MontoMax = DtsDeducciones.Tables(0).Rows(0).Item("MontoMaximo")
        '                If vValor > MontoMax Then
        '                    vValor = MontoMax
        '                End If
        '            End If
        '        End If
        '        '***************************************************************************************
        '        '***************************************************************************************

        '        pCampos = "NumSolicitud,CodPrestamo,CodDeduccion,Descripcion,MontoFijo,Iva,Tipo"
        '        pValores = "" & Me.pNoSolic & ",'" & Me.CodPrestamo & "','" & ofrm.Resultado.Trim & "','" & ofrm.Resultado2.Trim & "'," & vValor & ",'" & vAplicaIva & "','2'"
        '        If oPerif.InsertarPRDeduccionesPrestamos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
        '            EncabezadoDeducciones()
        '        Else
        '            MsgBox("Los datos de la deducción NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(mensajeError, MsgBoxStyle.Critical)
        'End Try
    End Sub

    Private Sub btDel1_Click(sender As Object, e As EventArgs) Handles btDel1.Click
        Try
            If MessageBox.Show("¿Está seguro que desea eliminar la deducción seleccionada?", "Deducciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim oCred As New wrPrestamo.wsLibPrest
                If oCred.EliminarPRDeduccionesPrestamos("Correlativo='" & fgDeducciones.Item(fgDeducciones.Row, "Correlativo") & "'", sUsuario, sPassword, sSucursal) = True Then
                    EncabezadoDeducciones()
                Else
                    MessageBox.Show("Deducción no eliminada, verifíque.", "Deducciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            'Modificacion 
            'Javier Martinez, 23/08/2012
            'Muestra el FOMR de la creación de cheques.
            Dim ofrm As New frmMsBCCheque
            ofrm.CodTipoCredito = Me.txtCodTipoCredito.Text.Trim
            ofrm.Monto_Desembolso = C1NEMonto.Value
            ofrm.NumSolicitud = pNoSolic
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.FormOrigen = 1
            ofrm.ShowDialog()

            'Dim ofrm As New frmMSPRCheques
            'ofrm.btnGuardar.Text = "&Guardar"
            'ofrm.txtCodPrestamo.ReadOnly = True
            'ofrm.txtCodPrestamo.Text = Me.CodPrestamo
            'ofrm.NoSolic = Me.pNoSolic
            'ofrm.StartPosition = FormStartPosition.CenterScreen
            'ofrm.ShowDialog()
            RefrescarGrid()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click

        Dim ds As New Data.DataSet
        Dim dr As DataRow
        Dim ofrm As New frmMSPRCheques
        Dim oItem As New wrPrestamo.wsLibPrest
        If fg.Row <> -1 Then
            Try
                ds = oItem.ConsultarPRCheques("*", "Correlativo=" & fg.Item(fg.Row, "Correlativo") & "", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.NoSolic = Me.pNoSolic
                ofrm.Correlativo = CInt(dr("Correlativo"))
                If Not dr("CodPrestamo") Is DBNull.Value Then
                    ofrm.txtCodPrestamo.Text = dr("CodPrestamo")
                End If
                If Not dr("PagueseA") Is DBNull.Value Then
                    ofrm.txtPagueseA.Text = dr("PagueseA")
                End If
                If Not dr("Monto") Is DBNull.Value Then
                    Dim Monto As Double = CDbl(dr("Monto"))
                    ofrm.c1neMonto.Value = Monto
                End If
                If Not dr("NoCheque") Is DBNull.Value Then
                    ofrm.txtNoCheque.Text = dr("NoCheque")
                End If
                If Not dr("Banco") Is DBNull.Value Then
                    ofrm.txtBanco.Text = dr("Banco")
                End If
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                RefrescarGrid()
                'Encabezado()
            Catch ex As Exception
                MsgBox(mensajeError, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            Dim oItem As New wrPrestamo.wsLibPrest
            If fg.Row <> -1 Then
                If oItem.EliminarPRCheques(fg.Item(fg.Row, "Correlativo"), sUsuario, sPassword, sSucursal) Then
                    RefrescarGrid()
                    'Encabezado()
                Else
                    MessageBox.Show("Registro no eliminado")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnTransferencia1_Click(sender As Object, e As EventArgs) Handles btnTransferencia1.Click
        Try
            Dts = New DataSet
            Dts.Clear()
            Dim N As Integer
            If dtTransferencias Is Nothing Then
                If Me.chkPrincipal.Checked = True Then
                    dtTransferencias = New DataTable("Transferencias")
                    dtTransferencias.Columns.Add("N")
                    dtTransferencias.Columns.Add("Tipo")
                    'dtTransferencias.Columns.Add("Cta Origen")
                    dtTransferencias.Columns.Add("Cta Destino")
                    dtTransferencias.Columns.Add("Monto")
                    dtTransferencias.Columns.Add("Tipo de Ahorro")
                    dtTransferencias.Columns.Add("No Libreta")
                    dtTransferencias.Columns.Add("Tasa de Interes")
                    dtTransferencias.Columns.Add("Saldo")
                    dtTransferencias.Columns.Add("Saldo_Disponible")
                    dtTransferencias.Columns.Add("Observacion")
                    dtTransferencias.Columns.Add("IdCtaContable")
                    dtTransferencias.Columns.Add("Estado")
                    dtTransferencias.Columns.Add("Principal")
                    'dtTransferencias.Columns.Add("idCuenta")
                    N = dtTransferencias.Rows.Count + 1
                    dtTransferencias.Rows.Add(N, Me.cbTipoTrans.SelectedItem.ToString, Me.txtReferencia.Text,
                                              Me.txtMonto.Value, CodTipoAhorro, Nolibreta, TasaInteres,
                                              Saldo, Saldo_Disponible, Me.txtObsTran.Text.Trim, IdCtaContable, Estado,
                                              IIf(chkPrincipal.Checked, "Principal", "Secundario")) ', Me.cbBancos.SelectedValue)
                    Dts.Tables.Add(dtTransferencias)
                    Me.dgTransferencias.DataSource = Dts.Tables(0)

                    'Crea Boton para Eliminar Transferencias
                    Dim btnColumnEliminar As New DataGridViewButtonColumn
                    With btnColumnEliminar
                        .Width = 50
                        .UseColumnTextForButtonValue = True
                        '.DefaultCellStyle.BackColor = Color.Teal
                        .DefaultCellStyle.ForeColor = Color.Red
                        .Text = "Eliminar"
                        .Name = "Eliminar"
                        .HeaderText = "Eliminar Transferencia"
                    End With
                    Me.dgTransferencias.Columns.Add(btnColumnEliminar)
                    '******************************************

                    'Crea Boton para Imprimir Transferencias
                    Dim btnImprimir As New DataGridViewButtonColumn
                    With btnImprimir
                        .Width = 50
                        .UseColumnTextForButtonValue = True
                        '.DefaultCellStyle.BackColor = Color.Teal
                        .DefaultCellStyle.ForeColor = Color.Red
                        .Text = "Imprimir"
                        .Name = "Imprimir"
                        .HeaderText = "Imprimir Comprobante"
                    End With
                    Me.dgTransferencias.Columns.Add(btnImprimir)
                    '******************************************

                    'Codigo de Transferencias
                    Dim txtCodTransferencia As New DataGridViewTextBoxColumn
                    With txtCodTransferencia
                        .Name = "CodTransferencia"
                        .Width = 50
                        .HeaderText = "CodTransferencia"
                        .Visible = False
                    End With
                    Me.dgTransferencias.Columns.Add(txtCodTransferencia)
                    '******************************************


                    EstiloDg()
                Else
                    MsgBox("La primera transferencia debe estar marcada como principal.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                End If

            Else
                If Me.dgTransferencias.RowCount > 0 Then
                    If Me.chkPrincipal.Checked = False Then
                        N = dtTransferencias.Rows.Count + 1
                        Dim rowTransferencia As DataRow = dtTransferencias.NewRow
                        rowTransferencia(0) = N
                        rowTransferencia(1) = Me.cbTipoTrans.SelectedItem.ToString

                        rowTransferencia(2) = Me.txtReferencia.Text.Trim
                        rowTransferencia(3) = Me.txtMonto.Value
                        rowTransferencia(4) = CodTipoAhorro
                        rowTransferencia(5) = Nolibreta
                        rowTransferencia(6) = TasaInteres
                        rowTransferencia(7) = Saldo
                        rowTransferencia(8) = Saldo_Disponible
                        rowTransferencia(9) = Me.txtObsTran.Text.Trim
                        rowTransferencia(10) = IdCtaContable
                        rowTransferencia(11) = Estado
                        rowTransferencia(12) = IIf(chkPrincipal.Checked, "Principal", "Secundario")
                        dtTransferencias.Rows.Add(rowTransferencia)
                        Dts.Tables.Add(dtTransferencias.Copy)
                        Me.dgTransferencias.DataSource = Dts.Tables(0)
                        EstiloDg()
                    Else
                        MsgBox("No se puede marcar mas de una de transferencia como principal.", MsgBoxStyle.Critical, "Módulo Créditos")
                        Exit Sub
                    End If
                Else
                    If Me.chkPrincipal.Checked = True Then
                        dtTransferencias = New DataTable("Transferencias")
                        dtTransferencias.Columns.Add("N")
                        dtTransferencias.Columns.Add("Tipo")
                        'dtTransferencias.Columns.Add("Cta Origen")
                        dtTransferencias.Columns.Add("Cta Destino")
                        dtTransferencias.Columns.Add("Monto")
                        dtTransferencias.Columns.Add("Tipo de Ahorro")
                        dtTransferencias.Columns.Add("No Libreta")
                        dtTransferencias.Columns.Add("Tasa de Interes")
                        dtTransferencias.Columns.Add("Saldo")
                        dtTransferencias.Columns.Add("Saldo_Disponible")
                        dtTransferencias.Columns.Add("Observacion")
                        dtTransferencias.Columns.Add("IdCtaContable")
                        dtTransferencias.Columns.Add("Estado")
                        dtTransferencias.Columns.Add("Principal")
                        'dtTransferencias.Columns.Add("idCuenta")
                        N = dtTransferencias.Rows.Count + 1
                        dtTransferencias.Rows.Add(N, Me.cbTipoTrans.SelectedItem.ToString, Me.txtReferencia.Text,
                                                  Me.txtMonto.Value, CodTipoAhorro, Nolibreta, TasaInteres,
                                                  Saldo, Saldo_Disponible, Me.txtObsTran.Text.Trim, IdCtaContable, Estado,
                                                  IIf(chkPrincipal.Checked, "Principal", "Secundario")) ', Me.cbBancos.SelectedValue)
                        Dts.Tables.Add(dtTransferencias)
                        Me.dgTransferencias.DataSource = Dts.Tables(0)

                        'Crea Boton para Eliminar Transferencias
                        Dim btnColumnEliminar As New DataGridViewButtonColumn
                        With btnColumnEliminar
                            .Width = 50
                            .UseColumnTextForButtonValue = True
                            '.DefaultCellStyle.BackColor = Color.Teal
                            .DefaultCellStyle.ForeColor = Color.Red
                            .Text = "Eliminar"
                            .Name = "Eliminar"
                            .HeaderText = "Eliminar Transferencia"
                        End With
                        Me.dgTransferencias.Columns.Add(btnColumnEliminar)
                        '******************************************

                        'Crea Boton para Imprimir Transferencias
                        Dim btnImprimir As New DataGridViewButtonColumn
                        With btnImprimir
                            .Width = 50
                            .UseColumnTextForButtonValue = True
                            '.DefaultCellStyle.BackColor = Color.Teal
                            .DefaultCellStyle.ForeColor = Color.Red
                            .Text = "Imprimir"
                            .Name = "Imprimir"
                            .HeaderText = "Imprimir Comprobante"
                        End With
                        Me.dgTransferencias.Columns.Add(btnImprimir)
                        '******************************************

                        'Codigo de Transferencias
                        Dim txtCodTransferencia As New DataGridViewTextBoxColumn
                        With txtCodTransferencia
                            .Name = "CodTransferencia"
                            .Width = 50
                            .HeaderText = "CodTransferencia"
                            .Visible = False
                        End With
                        Me.dgTransferencias.Columns.Add(txtCodTransferencia)
                        '******************************************
                        EstiloDg()
                    Else
                        MsgBox("La primera transferencia debe estar marcada como principal.", MsgBoxStyle.Critical, "Módulo Créditos")
                        Exit Sub
                    End If
                End If
            End If
            Limpiar()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btAtrasTb2_1.Click
        If Me.tbPpal.SelectedIndex <> 0 Then Me.tbPpal.SelectedIndex = Me.tbPpal.SelectedIndex() - 1
    End Sub

    Private Sub btnAsinaTA1_Click(sender As Object, e As EventArgs) Handles btnAsinaTA1.Click
        Try

            Dim ds As New DataSet, oPrest As New wrPrestamo.wsLibPrest, dr As DataRow, dv As New DataView
            ds = oPrest.CargaDatosPrestamo(Me.txtCodigo.Text.Trim, sUsuario, sPassword, sSucursal)
            If ds.Tables("TablaAmortiza").Rows.Count > 0 Then 'Ya tiene asignada Tabla de Amortización
                Dim ofrmAut As New frmMsAutorizacion
                ofrmAut.TipoPermiso = "P"
                ofrmAut.NumPrograma = "CRY004"
                ofrmAut.ShowDialog()
                If ofrmAut.Autoriza = True Then
                    Dim ofrm As New frmCRTablaAmort

                    dr = ds.Tables("Prestamo").Rows(0)
                    dv = New DataView(ds.Tables("TablaAmortiza"))

                    'dv.RowFilter = "Cancelada='N'"
                    dv.Sort = "FechaCuota asc"

                    ofrm.Reasignacion = True
                    ofrm.dtpFecha.Value = dtpFecOtorgamiento.Value.AddMonths(1)
                    ofrm.dtpFechaEmision.Value = Now
                    ofrm.CodPrestamo = Me.txtCodigo.Text.Trim

                    ofrm.C1NEMonto.Value = dr("Saldo_Capital")
                    ofrm.C1NEMonto.Enabled = False

                    ofrm.C1NEInteres.Value = dr("Tasa_Interes")
                    ofrm.C1NENumPagos.Value = dr("PlazoMeses")
                    ofrm.C1NEMontoGarantia.Value = dr("Monto_Garantia")

                    ofrm.ShowDialog()
                    'Me.frmMsCRDetPrestamo_Load(sender, e)
                    ofrmAut.Autoriza = False
                    ofrmAut.Dispose()
                Else
                    ofrmAut.Dispose()
                End If
            Else
                Dim ofrm As New frmCRTablaAmort
                dr = ds.Tables("Prestamo").Rows(0)
                If dr("Saldo_Capital") > 0 Then
                    ofrm.C1NEMonto.Value = dr("Saldo_Capital")
                Else
                    ofrm.C1NEMonto.Value = txtMonto.Text
                End If
                ofrm.Reasignacion = False
                ofrm.dtpFecha.Value = dtpFec1Cuota.Value.ToShortDateString ' CDate(Me.txtFechaPrimeraCuota.Text)
                ofrm.dtpFechaEmision.Value = Now
                ofrm.CodPrestamo = Me.txtCodigo.Text
                'ofrm.C1NEMonto.Value = Double.Parse(Me.txtMonto.Text)
                ofrm.C1NEInteres.Value = C1NEInteres.Value 'Double.Parse(Me.txtTasaInteres.Text)
                ofrm.C1NENumPagos.Value = C1NEPlazo.Value '  Integer.Parse(Me.txtPlazo.Text)
                ofrm.C1NEMontoGarantia.Value = C1NEMontoGarantia.Value 'Double.Parse(Me.txtMontoGarantia.Text)
                ofrm.ShowDialog()
                'Me.frmMsCRDetPrestamo_Load(sender, e)
            End If
            'Recuperamos datos de tabla de amortización
            llenarDatosTablaAmortizacion()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    Protected Sub llenarDatosTablaAmortizacion()
        Dim dts As New DataSet
        Dim campos = "correlativo,codtablaamortiza,fechacuota,montoCuota,abonocapital,saldoCapital, " &
            "interes,segurodeuda,segurodaniosyla,segurovida,segurodesempleo,aportacion,ahorro,otros,seguroVehiculo"
        dts = prestamo.CargaDatosPrestamo(txtCodigo.Text.Trim, sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables("datosTabla").Rows.Count > 0 Then
                txtCodTablaAmortiza.Text = dts.Tables("DatosTabla").Rows(0).Item("codTablaAmortiza")
                txtUsuario.Text = dts.Tables("DatosTabla").Rows(0).Item("usuario")
                txtFechayHora.Text = dts.Tables("DatosTabla").Rows(0).Item("fechacreacion")
                Dim dtsDetTabla As New DataSet
                dtsDetTabla = Creditos.ConstultarTAmortiza(campos, "codTablaAmortiza = '" & txtCodTablaAmortiza.Text.Trim & "'",
                                                           "correlativo", sUsuario, sPassword, sSucursal)

                Me.dgTabla.DataSource = dtsDetTabla.Tables(0)
                Me.dgTabla.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                Me.dgTabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgTabla.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End If
        End If
    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Try
            Dim oRep As wrBancos.wsLibBancos = New wrBancos.wsLibBancos, pFecha As Date
            Dim ds As New Data.DataSet, pAnulado As Boolean
            pFecha = Date.Today

            If Me.fg.Item(Me.fg.Row, "idmovimiento") > 0 Then
                ds = oRep.ImprimeCheque(Trim(Me.fg.Item(Me.fg.Row, "idmovimiento").ToString),
                                        Trim(Me.fg.Item(Me.fg.Row, "Num_Partida").ToString),
                                        Me.fg.Item(Me.fg.Row, "fecha_mov"), False, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 7, 0)

                ofrm.Show()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtReferencia_TextChanged(sender As Object, e As EventArgs) Handles txtReferencia.TextChanged

    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If Val(vCodPrestamo) > 0 Then
            Try
                Dim ds As New DataSet, oCred As New wrCredito.wsLibCred
                ds = oCred.RptContratoMutuo(vCodPrestamo, sUsuario)
                Dim ofrm As New frmVisor(ds, 222, 0)

                ofrm.Show()

            Catch ex As Exception
                MsgBox(mensajeError, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnProcesarTran1_Click(sender As Object, e As EventArgs) Handles btnProcesarTran1.Click
        Try
            If MsgBox("¿Desea realizar esta acción?", MsgBoxStyle.YesNo, "Módulo Créditos - Préstamos") = MsgBoxResult.Yes Then
                'Evalua que la transferencia cuadre.
                '************************
                'Deducciones
                '************************
                Dim Principal As Integer
                For Each Fila As DataGridViewRow In Me.dgTransferencias.Rows
                    If Fila.Cells("Principal").Value.ToString.Trim = "Principal" Then
                        Principal = Principal + 1
                    End If
                Next
                If Principal = 1 Then
                    Dim NDeducciones As Integer
                    Dim TotalDeducciones As Double
                    Dim Resultado As Integer
                    NDeducciones = fgDeducciones.Rows.Count
                    If NDeducciones > 0 Then
                        For i As Integer = 1 To NDeducciones - 1
                            TotalDeducciones = TotalDeducciones + fgDeducciones.Item(i, "total")
                        Next
                    End If

                    '************************************************************

                    '************************
                    'Tramitaciones
                    '************************
                    Dim TotalTramitaciones As Double
                    Dim NTramitaciones As Integer
                    NTramitaciones = dgTransferencias.RowCount
                    If NTramitaciones > 0 Then
                        For j As Integer = 0 To NTramitaciones - 1
                            If dgTransferencias.Item("Principal", j).Value = "Principal" Then
                                TotalTramitaciones += dgTransferencias.Item("Monto", j).Value
                            End If

                        Next

                    End If


                    If Math.Round(Me.C1NEMonto.Value, 2) = Math.Round(TotalDeducciones + TotalTramitaciones, 2) Then

                        For k As Integer = 0 To dgTransferencias.RowCount - 1
                            If k = 0 Then
                                Dim ObservacionPrincipal As String
                                ObservacionPrincipal = "Desembolso de Préstamo: " & Me.txtCodigo.Text.Trim & ", DUI: " & pDui.Trim & ", " & Me.txtNombre.Text.Trim

                                If Me.dgTransferencias.Item("Principal", k).Value = "Principal" Then
                                    Resultado = Creditos.Partida_Desembolso_Prestamo(" ", "", "EG", Format(Now, "Short Date"),
                                                            ObservacionPrincipal, dgTransferencias.Item("Monto", k).Value, " ", " ",
                                                            Me.C1NEMonto.Value, Me.txtCodTipoCredito.Text.Trim, pNoSolic, sUsuario, "11", "11", sSucursal, 3,
                                                            dgTransferencias.Item("Cta Destino", k).Value, dgTransferencias.Item("Tipo de Ahorro", k).Value,
                                                            dgTransferencias.Item("Saldo", k).Value, dgTransferencias.Item("IdCtaContable", k).Value,
                                                            dgTransferencias.Item("No Libreta", k).Value, dgTransferencias.Item("Saldo_Disponible", k).Value,
                                                            dgTransferencias.Item("Tasa de Interes", k).Value, dgTransferencias.Item("Estado", k).Value)

                                End If
                            Else
                                If Me.dgTransferencias.Item("Principal", k).Value = "Secundario" Then
                                    Resultado = Creditos.Partida_Desembolso_Prestamo(" ", "", "DR", Format(Now, "Short Date"),
                                                                                                dgTransferencias.Item("Observacion", k).Value, dgTransferencias.Item("Monto", k).Value, " ", " ",
                                                                                                Me.txtMonto.Value, Me.txtCodTipoCredito.Text.Trim, pNoSolic, sUsuario, "11", "11", sSucursal, 4,
                                                                                                dgTransferencias.Item("Cta Destino", k).Value, dgTransferencias.Item("Tipo de Ahorro", k).Value,
                                                                                                dgTransferencias.Item("Saldo", k).Value, dgTransferencias.Item("IdCtaContable", k).Value,
                                                                                                dgTransferencias.Item("No Libreta", k).Value, dgTransferencias.Item("Saldo_Disponible", k).Value,
                                                                                                dgTransferencias.Item("Tasa de Interes", k).Value, dgTransferencias.Item("Estado", k).Value)



                                End If
                            End If
                        Next
                        Me.btnProcesarTran1.Enabled = False
                        Me.btnTransferencia1.Enabled = False
                        MsgBox("Transferencia realizada exitosamente", MsgBoxStyle.Information)
                        Me.dgTransferencias.DataSource = ""
                        Me.dgTransferencias.Columns.Clear()
                        llenarTransferencias()
                    Else
                        MsgBox("MONTOS NO COINCIDEN", MsgBoxStyle.Information)
                    End If
                ElseIf Principal > 1 Then
                    MsgBox("Se ha seleccionado mas de una transferencia como principal.", MsgBoxStyle.Critical)
                    Exit Sub
                ElseIf Principal = 0 Then
                    MsgBox("No se ha seleccionado ninguna transferencia como principal.", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub chkPrincipal_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPrincipal.CheckedChanged
        If Me.chkPrincipal.Checked = True Then
            Me.txtObsTran.Enabled = False
        Else
            Me.txtObsTran.Enabled = True
        End If
    End Sub
#End Region

    Private Sub dtpFecOtorgamiento_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecOtorgamiento.ValueChanged
        Me.dtpFec1Cuota.Value = dtpFecOtorgamiento.Value.AddMonths(1)
    End Sub
End Class