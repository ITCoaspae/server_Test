Imports System.Threading
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmCAFactura
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Private errorProvider1 As New System.Windows.Forms.ErrorProvider
    'Private vIdModifica As String, vAccion As AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas
    Private vIdModifica As String, vAccion As sifLib.Caja.clsCAFacturas.TipoAccionFacturas
    'Private vdsFactura As New DataSet, vTipo As AlcalaLibs.Caja.clsCAFactura.TipoMovimiento
    Private vdsFactura As New DataSet, vTipo As sifLib.Caja.clsCAFacturas.TipoMovimiento
    Private vNumFactura As Integer, oItem As DataRow
    Private oPrestamo As DataSet
    Private vPagoLibreta As String, vTipoDoc As String, vTipoMov As String, vRubro As String
    Public vCancela As Boolean
    Private vNoCaja As String, vCodCajero As String, vUsuario As String, saldoGestion As Double
    Dim vFormaPago As Integer
    Public vPagoCapital As Decimal, vPagoInteres As Decimal, vPagoCapitalMora As Decimal, vPagoInteresMora As Decimal, pNoCuenta As String, pNoCuentaAnterior As String, pCodTipoAhorro As String
    Public vPagoSeguroDeuda As Decimal, vPagoSeguroDanios As Decimal, vPagoSeguroVida As Decimal, vPagoSeguroDesempleo As Decimal, vPagoSeguroVehiculo As Decimal
    Public vPagoAportacion As Decimal, vPagoAhorro As Decimal, vPagoComision As Decimal, vPagoOtros As Decimal
    Public vTotalGravado As Decimal, vTotalNoGravado As Decimal, vTotalSIva As Decimal, vTotalIVA As Decimal, vTotalFactura As Decimal

    Public pObservacion As String, pNoReserva As String, pNoCheque As String, pNoCtaBanco As String, pBanco As String, pMontoPagado As Decimal, pNoLibreta As String
    Public pGirador As String, pPaguese As String, pCodTransaccion As String, vNoSocio As String, vNoSocioAnterior As String, pTipoTransaccion As String, pValDiv As Double, pMensajeCajas As String

    Public dtsGestiones As DataSet
    Dim MontoLetras As String
    '09/10/2013 Constructor clase caja
    Dim Caja As New wrCaja.wsLibCaja
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim prestamoLib As New wrPrestamo.wsLibPrest
    Dim dtsTiposDoc As New DataSet
    Dim vIdTipoDoc As Integer
    Dim pCancelacion As Boolean
    Friend WithEvents lblNotCan As System.Windows.Forms.Label
    Friend WithEvents txtFoto As PictureBox
    Friend WithEvents pbFirma As PictureBox
    Friend WithEvents btnProvisional As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelacionPrest1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btAbonos As MetroFramework.Controls.MetroButton
    Friend WithEvents btModificarItem As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminaItem As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLimpiar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBloquear1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLimpiarDatosCheque1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRetCheque1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSolicitudesBoveda As MetroFramework.Controls.MetroButton
    Dim vIdCorrCaja As Integer

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm)
        Me.NumFactura = 0
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-SV")
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents C1fgrdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents txtCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDescripTipoMov As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoMov As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFactura As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCodTipoDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbTipoTrans As System.Windows.Forms.ComboBox
    Friend WithEvents lblListaPrestamos As System.Windows.Forms.TextBox
    Friend WithEvents btEditFecha As System.Windows.Forms.Button
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCAFactura))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbFirma = New System.Windows.Forms.PictureBox()
        Me.txtFoto = New System.Windows.Forms.PictureBox()
        Me.lblListaPrestamos = New System.Windows.Forms.TextBox()
        Me.cbTipoTrans = New System.Windows.Forms.ComboBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtDescripTipoMov = New System.Windows.Forms.TextBox()
        Me.txtTipoMov = New System.Windows.Forms.TextBox()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btEditFecha = New System.Windows.Forms.Button()
        Me.txtTipoDoc = New System.Windows.Forms.TextBox()
        Me.txtCodTipoDoc = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New C1.Win.C1Input.C1TextBox()
        Me.C1fgrdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnCancelacionPrest1 = New MetroFramework.Controls.MetroButton()
        Me.btnProvisional = New MetroFramework.Controls.MetroButton()
        Me.lblNotCan = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtTotalFactura = New C1.Win.C1Input.C1NumericEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSolicitudesBoveda = New MetroFramework.Controls.MetroButton()
        Me.btAbonos = New MetroFramework.Controls.MetroButton()
        Me.btnRetCheque1 = New MetroFramework.Controls.MetroButton()
        Me.btModificarItem = New MetroFramework.Controls.MetroButton()
        Me.btnLimpiarDatosCheque1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminaItem = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar1 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnLimpiar1 = New MetroFramework.Controls.MetroButton()
        Me.btnBloquear1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.pbFirma)
        Me.GroupBox1.Controls.Add(Me.txtFoto)
        Me.GroupBox1.Controls.Add(Me.lblListaPrestamos)
        Me.GroupBox1.Controls.Add(Me.cbTipoTrans)
        Me.GroupBox1.Controls.Add(Me.txtMensaje)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.cbTipoDoc)
        Me.GroupBox1.Controls.Add(Me.txtDescripTipoMov)
        Me.GroupBox1.Controls.Add(Me.txtTipoMov)
        Me.GroupBox1.Controls.Add(Me.cmbFormaPago)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAsociado)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(939, 245)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'pbFirma
        '
        Me.pbFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFirma.Location = New System.Drawing.Point(7, 185)
        Me.pbFirma.Name = "pbFirma"
        Me.pbFirma.Size = New System.Drawing.Size(189, 53)
        Me.pbFirma.TabIndex = 191
        Me.pbFirma.TabStop = False
        '
        'txtFoto
        '
        Me.txtFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFoto.Location = New System.Drawing.Point(7, 16)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(141, 162)
        Me.txtFoto.TabIndex = 190
        Me.txtFoto.TabStop = False
        '
        'lblListaPrestamos
        '
        Me.lblListaPrestamos.BackColor = System.Drawing.Color.White
        Me.lblListaPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblListaPrestamos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaPrestamos.ForeColor = System.Drawing.Color.Black
        Me.lblListaPrestamos.Location = New System.Drawing.Point(277, 186)
        Me.lblListaPrestamos.Multiline = True
        Me.lblListaPrestamos.Name = "lblListaPrestamos"
        Me.lblListaPrestamos.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.lblListaPrestamos.Size = New System.Drawing.Size(649, 37)
        Me.lblListaPrestamos.TabIndex = 19
        Me.lblListaPrestamos.Visible = False
        '
        'cbTipoTrans
        '
        Me.cbTipoTrans.BackColor = System.Drawing.Color.White
        Me.cbTipoTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoTrans.Items.AddRange(New Object() {"Abono", "Cambio", "Abono - Cambio"})
        Me.cbTipoTrans.Location = New System.Drawing.Point(676, 77)
        Me.cbTipoTrans.Name = "cbTipoTrans"
        Me.cbTipoTrans.Size = New System.Drawing.Size(250, 24)
        Me.cbTipoTrans.TabIndex = 12
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMensaje.ForeColor = System.Drawing.Color.Black
        Me.txtMensaje.Location = New System.Drawing.Point(277, 142)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMensaje.Size = New System.Drawing.Size(649, 37)
        Me.txtMensaje.TabIndex = 18
        Me.txtMensaje.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(572, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Transacción:"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(572, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 18)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "Tipo de Doc.:"
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.BackColor = System.Drawing.Color.White
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.Items.AddRange(New Object() {"Factura Consumidor Final", "Crédito Fiscal", "Comprobante Retiro de Ahorro", "Comprobante Depósito de Ahorro", "Recibo de Pago Excedente", "Cambio de Cheque"})
        Me.cbTipoDoc.Location = New System.Drawing.Point(676, 46)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(250, 24)
        Me.cbTipoDoc.TabIndex = 8
        '
        'txtDescripTipoMov
        '
        Me.txtDescripTipoMov.BackColor = System.Drawing.Color.White
        Me.txtDescripTipoMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripTipoMov.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripTipoMov.ForeColor = System.Drawing.Color.Black
        Me.txtDescripTipoMov.Location = New System.Drawing.Point(332, 46)
        Me.txtDescripTipoMov.Name = "txtDescripTipoMov"
        Me.txtDescripTipoMov.ReadOnly = True
        Me.txtDescripTipoMov.Size = New System.Drawing.Size(233, 25)
        Me.txtDescripTipoMov.TabIndex = 6
        '
        'txtTipoMov
        '
        Me.txtTipoMov.BackColor = System.Drawing.Color.White
        Me.txtTipoMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoMov.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoMov.ForeColor = System.Drawing.Color.Black
        Me.txtTipoMov.Location = New System.Drawing.Point(277, 46)
        Me.txtTipoMov.Name = "txtTipoMov"
        Me.txtTipoMov.Size = New System.Drawing.Size(48, 25)
        Me.txtTipoMov.TabIndex = 5
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.BackColor = System.Drawing.Color.White
        Me.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormaPago.ItemHeight = 16
        Me.cmbFormaPago.Items.AddRange(New Object() {"Efectivo", "Cheque propio", "Cheque ajeno", "Tarjeta", "Cta.Ahorro", "Otro"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(277, 77)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(288, 24)
        Me.cmbFormaPago.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(155, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Forma de Pago:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(155, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 18)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Tipo Movimiento:"
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.ForeColor = System.Drawing.Color.Black
        Me.txtDui.Location = New System.Drawing.Point(277, 17)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(115, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(155, 142)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 36)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Mensaje " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para Cajas:"
        Me.Label19.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(400, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.Color.Black
        Me.txtAsociado.Location = New System.Drawing.Point(532, 16)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(394, 25)
        Me.txtAsociado.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(155, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 14)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "DUI:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(572, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(676, 108)
        Me.dtpFecha.MinDate = New Date(1945, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(250, 22)
        Me.dtpFecha.TabIndex = 16
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.Black
        Me.txtNumero.Location = New System.Drawing.Point(277, 108)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(288, 25)
        Me.txtNumero.TabIndex = 14
        Me.txtNumero.Text = "0"
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(155, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "No. de Doc.:"
        '
        'btEditFecha
        '
        Me.btEditFecha.BackColor = System.Drawing.Color.Teal
        Me.btEditFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEditFecha.ForeColor = System.Drawing.Color.White
        Me.btEditFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEditFecha.Location = New System.Drawing.Point(760, 23)
        Me.btEditFecha.Name = "btEditFecha"
        Me.btEditFecha.Size = New System.Drawing.Size(21, 32)
        Me.btEditFecha.TabIndex = 150
        Me.btEditFecha.Text = "Modificar &Fecha"
        Me.btEditFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEditFecha.UseVisualStyleBackColor = False
        Me.btEditFecha.Visible = False
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDoc.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTipoDoc.Location = New System.Drawing.Point(499, 43)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.ReadOnly = True
        Me.txtTipoDoc.Size = New System.Drawing.Size(63, 23)
        Me.txtTipoDoc.TabIndex = 187
        Me.txtTipoDoc.Visible = False
        '
        'txtCodTipoDoc
        '
        Me.txtCodTipoDoc.BackColor = System.Drawing.Color.Khaki
        Me.txtCodTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoDoc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoDoc.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodTipoDoc.Location = New System.Drawing.Point(464, 42)
        Me.txtCodTipoDoc.Name = "txtCodTipoDoc"
        Me.txtCodTipoDoc.Size = New System.Drawing.Size(39, 25)
        Me.txtCodTipoDoc.TabIndex = 7
        Me.txtCodTipoDoc.Visible = False
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(569, 45)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.NumericInput = False
        Me.txtCuenta.Size = New System.Drawing.Size(153, 20)
        Me.txtCuenta.TabIndex = 10
        Me.txtCuenta.Tag = Nothing
        Me.txtCuenta.Visible = False
        '
        'C1fgrdDetalle
        '
        Me.C1fgrdDetalle.AllowEditing = False
        Me.C1fgrdDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdDetalle.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdDetalle.BackColor = System.Drawing.Color.White
        Me.C1fgrdDetalle.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1fgrdDetalle.Location = New System.Drawing.Point(34, 325)
        Me.C1fgrdDetalle.Name = "C1fgrdDetalle"
        Me.C1fgrdDetalle.Rows.Count = 3
        Me.C1fgrdDetalle.Rows.DefaultSize = 22
        Me.C1fgrdDetalle.Size = New System.Drawing.Size(939, 242)
        Me.C1fgrdDetalle.StyleInfo = resources.GetString("C1fgrdDetalle.StyleInfo")
        Me.C1fgrdDetalle.TabIndex = 4
        '
        'btnCancelacionPrest1
        '
        Me.btnCancelacionPrest1.Location = New System.Drawing.Point(311, 662)
        Me.btnCancelacionPrest1.Name = "btnCancelacionPrest1"
        Me.btnCancelacionPrest1.Size = New System.Drawing.Size(176, 33)
        Me.btnCancelacionPrest1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCancelacionPrest1.TabIndex = 19
        Me.btnCancelacionPrest1.Text = "Cancelar Préstamo"
        Me.btnCancelacionPrest1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCancelacionPrest1.UseSelectable = True
        Me.btnCancelacionPrest1.UseStyleColors = True
        '
        'btnProvisional
        '
        Me.btnProvisional.Location = New System.Drawing.Point(28, 662)
        Me.btnProvisional.Name = "btnProvisional"
        Me.btnProvisional.Size = New System.Drawing.Size(90, 33)
        Me.btnProvisional.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProvisional.TabIndex = 17
        Me.btnProvisional.Text = "Provisional"
        Me.btnProvisional.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProvisional.UseSelectable = True
        Me.btnProvisional.UseStyleColors = True
        '
        'lblNotCan
        '
        Me.lblNotCan.AutoSize = True
        Me.lblNotCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotCan.ForeColor = System.Drawing.Color.Teal
        Me.lblNotCan.Location = New System.Drawing.Point(768, 573)
        Me.lblNotCan.Name = "lblNotCan"
        Me.lblNotCan.Size = New System.Drawing.Size(202, 18)
        Me.lblNotCan.TabIndex = 6
        Me.lblNotCan.Text = "Cancelación de Préstamo"
        Me.lblNotCan.Visible = False
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.White
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEstado.Location = New System.Drawing.Point(28, 573)
        Me.txtEstado.Multiline = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(703, 43)
        Me.txtEstado.TabIndex = 5
        '
        'txtTotalFactura
        '
        Me.txtTotalFactura.BackColor = System.Drawing.Color.White
        Me.txtTotalFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalFactura.Culture = 17418
        Me.txtTotalFactura.CustomFormat = "#0.00"
        Me.txtTotalFactura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFactura.ForeColor = System.Drawing.Color.Teal
        Me.txtTotalFactura.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtTotalFactura.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtTotalFactura.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtTotalFactura.Location = New System.Drawing.Point(859, 594)
        Me.txtTotalFactura.Name = "txtTotalFactura"
        Me.txtTotalFactura.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtTotalFactura.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtTotalFactura.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtTotalFactura.ReadOnly = True
        Me.txtTotalFactura.Size = New System.Drawing.Size(114, 23)
        Me.txtTotalFactura.TabIndex = 8
        Me.txtTotalFactura.Tag = Nothing
        Me.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalFactura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalFactura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(738, 593)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 22)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total Factura:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSolicitudesBoveda
        '
        Me.btnSolicitudesBoveda.Location = New System.Drawing.Point(689, 662)
        Me.btnSolicitudesBoveda.Name = "btnSolicitudesBoveda"
        Me.btnSolicitudesBoveda.Size = New System.Drawing.Size(187, 33)
        Me.btnSolicitudesBoveda.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSolicitudesBoveda.TabIndex = 21
        Me.btnSolicitudesBoveda.Text = "&Solicitudes Bóveda"
        Me.btnSolicitudesBoveda.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSolicitudesBoveda.UseSelectable = True
        Me.btnSolicitudesBoveda.UseStyleColors = True
        '
        'btAbonos
        '
        Me.btAbonos.Location = New System.Drawing.Point(28, 623)
        Me.btAbonos.Name = "btAbonos"
        Me.btAbonos.Size = New System.Drawing.Size(90, 32)
        Me.btAbonos.Style = MetroFramework.MetroColorStyle.Teal
        Me.btAbonos.TabIndex = 9
        Me.btAbonos.Text = "Anticipo"
        Me.btAbonos.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btAbonos.UseSelectable = True
        Me.btAbonos.UseStyleColors = True
        '
        'btnRetCheque1
        '
        Me.btnRetCheque1.Location = New System.Drawing.Point(494, 662)
        Me.btnRetCheque1.Name = "btnRetCheque1"
        Me.btnRetCheque1.Size = New System.Drawing.Size(188, 33)
        Me.btnRetCheque1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnRetCheque1.TabIndex = 20
        Me.btnRetCheque1.Text = "Retiro de Ahorro Cheque"
        Me.btnRetCheque1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnRetCheque1.UseSelectable = True
        Me.btnRetCheque1.UseStyleColors = True
        '
        'btModificarItem
        '
        Me.btModificarItem.Location = New System.Drawing.Point(125, 623)
        Me.btModificarItem.Name = "btModificarItem"
        Me.btModificarItem.Size = New System.Drawing.Size(133, 32)
        Me.btModificarItem.Style = MetroFramework.MetroColorStyle.Teal
        Me.btModificarItem.TabIndex = 10
        Me.btModificarItem.Text = "Modificar Detalle"
        Me.btModificarItem.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btModificarItem.UseSelectable = True
        Me.btModificarItem.UseStyleColors = True
        '
        'btnLimpiarDatosCheque1
        '
        Me.btnLimpiarDatosCheque1.Location = New System.Drawing.Point(125, 662)
        Me.btnLimpiarDatosCheque1.Name = "btnLimpiarDatosCheque1"
        Me.btnLimpiarDatosCheque1.Size = New System.Drawing.Size(179, 33)
        Me.btnLimpiarDatosCheque1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnLimpiarDatosCheque1.TabIndex = 18
        Me.btnLimpiarDatosCheque1.Text = "Limpiar Datos Cheque"
        Me.btnLimpiarDatosCheque1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLimpiarDatosCheque1.UseSelectable = True
        Me.btnLimpiarDatosCheque1.UseStyleColors = True
        '
        'btnEliminaItem
        '
        Me.btnEliminaItem.Location = New System.Drawing.Point(265, 623)
        Me.btnEliminaItem.Name = "btnEliminaItem"
        Me.btnEliminaItem.Size = New System.Drawing.Size(125, 32)
        Me.btnEliminaItem.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminaItem.TabIndex = 11
        Me.btnEliminaItem.Text = "Eliminar Detalle"
        Me.btnEliminaItem.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminaItem.UseSelectable = True
        Me.btnEliminaItem.UseStyleColors = True
        '
        'btnCancelar1
        '
        Me.btnCancelar1.Location = New System.Drawing.Point(786, 623)
        Me.btnCancelar1.Name = "btnCancelar1"
        Me.btnCancelar1.Size = New System.Drawing.Size(90, 32)
        Me.btnCancelar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCancelar1.TabIndex = 16
        Me.btnCancelar1.Text = "Cancelar"
        Me.btnCancelar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCancelar1.UseSelectable = True
        Me.btnCancelar1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(397, 623)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(90, 32)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 12
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(592, 623)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 14
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnLimpiar1
        '
        Me.btnLimpiar1.Location = New System.Drawing.Point(494, 623)
        Me.btnLimpiar1.Name = "btnLimpiar1"
        Me.btnLimpiar1.Size = New System.Drawing.Size(90, 32)
        Me.btnLimpiar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnLimpiar1.TabIndex = 13
        Me.btnLimpiar1.Text = "Limpiar"
        Me.btnLimpiar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLimpiar1.UseSelectable = True
        Me.btnLimpiar1.UseStyleColors = True
        '
        'btnBloquear1
        '
        Me.btnBloquear1.Location = New System.Drawing.Point(689, 623)
        Me.btnBloquear1.Name = "btnBloquear1"
        Me.btnBloquear1.Size = New System.Drawing.Size(90, 32)
        Me.btnBloquear1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBloquear1.TabIndex = 15
        Me.btnBloquear1.Text = "Bloquear"
        Me.btnBloquear1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnBloquear1.UseSelectable = True
        Me.btnBloquear1.UseStyleColors = True
        '
        'frmCAFactura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1001, 721)
        Me.Controls.Add(Me.btnProvisional)
        Me.Controls.Add(Me.C1fgrdDetalle)
        Me.Controls.Add(Me.btnCancelacionPrest1)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.btnSolicitudesBoveda)
        Me.Controls.Add(Me.lblNotCan)
        Me.Controls.Add(Me.btAbonos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRetCheque1)
        Me.Controls.Add(Me.btEditFecha)
        Me.Controls.Add(Me.btModificarItem)
        Me.Controls.Add(Me.txtTotalFactura)
        Me.Controls.Add(Me.btnLimpiarDatosCheque1)
        Me.Controls.Add(Me.btnEliminaItem)
        Me.Controls.Add(Me.btnCancelar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.txtTipoDoc)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtCodTipoDoc)
        Me.Controls.Add(Me.btnLimpiar1)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.btnBloquear1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1001, 721)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1001, 721)
        Me.Name = "frmCAFactura"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Facturación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1fgrdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"
    Public Property cancelacion() As Boolean
        Get
            Return pCancelacion
        End Get
        Set(ByVal value As Boolean)
            pCancelacion = value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return vUsuario
        End Get
        Set(ByVal Value As String)
            vUsuario = Value
        End Set
    End Property

    Public Property NoCaja() As String
        Get
            Return vNoCaja
        End Get
        Set(ByVal Value As String)
            vNoCaja = Value
        End Set
    End Property

    Public Property CodCajero() As String
        Get
            Return vCodCajero
        End Get
        Set(ByVal Value As String)
            vCodCajero = Value
        End Set
    End Property

    'Public Property Tipo() As AlcalaLibs.Caja.clsCAFactura.TipoMovimiento
    Public Property Tipo() As sifLib.Caja.clsCAFacturas.TipoMovimiento
        Get
            Return vTipo
        End Get
        'Set(ByVal Value As AlcalaLibs.Caja.clsCAFactura.TipoMovimiento)
        Set(ByVal Value As sifLib.Caja.clsCAFacturas.TipoMovimiento)
            vTipo = Value
        End Set
    End Property

    'Public Property Accion() As AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas
    Public Property Accion() As sifLib.Caja.clsCAFacturas.TipoAccionFacturas
        Get
            Return vAccion
        End Get
        'Set(ByVal Value As AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas)
        Set(ByVal Value As sifLib.Caja.clsCAFacturas.TipoAccionFacturas)
            vAccion = Value
        End Set
    End Property

    Public Property Factura() As System.Data.DataSet
        Get
            Return vdsFactura
        End Get
        Set(ByVal Value As System.Data.DataSet)
            vdsFactura = Value
        End Set
    End Property

    Private Property NumFactura() As Integer
        Get
            Return vNumFactura
        End Get
        Set(ByVal Value As Integer)
            vNumFactura = Value
        End Set
    End Property

    Public Property IdModifica() As String
        Get
            Return vIdModifica
        End Get
        Set(ByVal Value As String)
            vIdModifica = Value
        End Set
    End Property

    Public Property Item() As DataRow
        Get
            Return oItem
        End Get
        Set(ByVal Value As DataRow)
            oItem = Value
        End Set
    End Property

    Public Property Prestamo() As DataSet
        Get
            Return oPrestamo
        End Get
        Set(ByVal Value As DataSet)
            oPrestamo = Value
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

#End Region
#Region "Modificaciones 09/10/2013"
    Protected Sub llenarCbTipoDocumento(ByVal opcion As Integer, ByVal activo As Boolean, ByVal idTipoDoc As Integer)
        dtsTiposDoc = Caja.consultarCaMaestrosTipoDocumentos(opcion, activo, idTipoDoc)
        If dtsTiposDoc.Tables.Count > 0 Then
            If dtsTiposDoc.Tables(0).Rows.Count > 0 Then
                Me.cbTipoDoc.DataSource = dtsTiposDoc.Tables(0)
            End If
        End If
    End Sub
#End Region
    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick


        If txtDui.Text.Replace("_", " ").Replace("-", " ") = "" Then
            MessageBox.Show("Se debe ingresar el DUI del asociado", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,CodAntiguo,NoSocio,Apellido1,Apellido2,Nombres", "", "Correlativo", sUsuario, sPassword, sSucursal) 'Ópcion que permite la busqueda del dui de los asociados.
            'ds = oAsoc.ConsultarAsociado("DUI,CodAntiguo,NoSocio,Apellido1,Apellido2,Nombres", "DUI='" & txtDui.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio,CodAntiguo", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                vNoSocio = dr("NoSocio")
                vNoSocioAnterior = IIf(dr("CodAntiguo") Is DBNull.Value, "", dr("CodAntiguo"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Public Sub IniciaFactura()
        Dim oCaja As New wrCaja.wsLibCaja
        Me.vTipoDoc = "F"
        Me.cbTipoDoc.SelectedIndex = 0
        'Me.txtNumero.Text = oCaja.ObtenerCorrelativoxMovimiento("CAFacturas", Me.vTipoDoc, Me.dtpFecha.Value.Date.Year, "cast(IdMovimiento as Int)", sUsuario, sPassword,sSucursal)
        Me.Factura = oCaja.ObtenerFacturaVacia(sUsuario, sPassword, sSucursal)
        Me.cmbFormaPago.SelectedIndex = 0
        vPagoLibreta = "N"
        C1fgrdDetalle.DataSource = Me.Factura.Tables("CADet_Facturas")

        C1fgrdDetalle.Cols.Item(5).Format = "##0.00"
        C1fgrdDetalle.Cols.Item(6).Format = "##0.00"
        C1fgrdDetalle.Cols.Item(7).Format = "##0.00"
        C1fgrdDetalle.Cols.Item(8).Format = "##0.00"
        C1fgrdDetalle.Cols.Item(9).Format = "##0.00"
        C1fgrdDetalle.Cols.Item(10).Format = "##0.00"

        C1fgrdDetalle.Cols.Item(1).Width = 0
        C1fgrdDetalle.Cols.Item(11).Width = 0
        C1fgrdDetalle.Cols.Item(12).Width = 0
        C1fgrdDetalle.Cols.Item(14).Width = 0
        C1fgrdDetalle.Cols.Item(15).Width = 0
        C1fgrdDetalle.Cols.Item(16).Width = 0
        C1fgrdDetalle.Cols.Item(17).Width = 0
        C1fgrdDetalle.Cols.Item(18).Width = 0
    End Sub

    Private Sub frmCAFactura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            IniciaFactura()
            pNoLibreta = ""
            pMensajeCajas = ""
            Me.cbTipoTrans.SelectedIndex = 0
            '11/10/2013
            'Javie Escobar
            'Modificación de correlativos doc. caja
            Me.cbTipoTrans.SelectedIndex = 0
            Me.cbTipoDoc.DisplayMember = "tipoDocumento"
            Me.cbTipoDoc.ValueMember = "abrev"
            llenarCbTipoDocumento(2, True, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub C1fgrdDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1fgrdDetalle.DoubleClick
        Dim ofrmDet As New frmMsDetCaFactura
        Me.IdModifica = C1fgrdDetalle.Item(C1fgrdDetalle.Row, "CodItem")
        'ofrmDet.AccionDetalle = AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas.ModificarLinea
        ofrmDet.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.ModificarLinea
        ofrmDet.txtCodItem.Text = Me.IdModifica
        ofrmDet.txtItem.Text = C1fgrdDetalle.Item(C1fgrdDetalle.Row, "Descripcion")
        ofrmDet.ShowDialog()
    End Sub



    Private Sub btnProvisional_Click(sender As Object, e As EventArgs) Handles btnProvisional.Click
        Try
            'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then

                Dim vNo As String
                vNo = InputBox("Digite el Número de Recibo:", "Recibo Provisional", "")

                If vNo.Trim <> "" Then
                    Dim ds As New DataSet, dt As New DataTable("Datos"), dr As DataRow

                    'Tabla Datos
                    dt.Columns.Add("Dui", Type.GetType("System.String"))
                    dt.Columns.Add("NoSocio", Type.GetType("System.String"))
                    dt.Columns.Add("Nombres", Type.GetType("System.String"))
                    dt.Columns.Add("Monto", Type.GetType("System.Decimal"))
                    dt.Columns.Add("Concepto", Type.GetType("System.String"))
                    dt.Columns.Add("CodPrestamo", Type.GetType("System.String"))
                    dt.Columns.Add("NoProvisional", Type.GetType("System.String"))
                    dt.Columns.Add("Fecha", Type.GetType("System.DateTime"))
                    dt.Columns.Add("CodAntiguo", Type.GetType("System.String"))
                    dt.Columns.Add("CodPrestamoAnterior", Type.GetType("System.String"))
                    ds.Tables.Add(dt)

                    dr = ds.Tables("Datos").NewRow
                    dr("Dui") = Me.txtDui.Text.Trim
                    dr("NoSocio") = vNoSocio
                    dr("Nombres") = Me.txtAsociado.Text.Trim
                    dr("Monto") = Me.txtTotalFactura.Value
                    dr("Concepto") = "ABONO A PRÉSTAMO."
                    dr("CodPrestamo") = Me.pNoCuenta.Trim
                    dr("NoProvisional") = vNo.Trim
                    dr("Fecha") = Me.dtpFecha.Value
                    dr("CodAntiguo") = vNoSocioAnterior
                    dr("CodPrestamoAnterior") = Me.pNoCuentaAnterior.Trim
                    ds.Tables("Datos").Rows.Add(dr)

                    Dim ofrm As New frmVisor(ds, 67, 0)
                    ofrm.Show()
                End If

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancelacionPrest1_Click(sender As Object, e As EventArgs) Handles btnCancelacionPrest1.Click
        Dim frm As New frmCancelacionPrestamo
        With frm
            .noCaja = pNocaja
            .codCajero = pCodCajero
            .lblAsociado.Text = txtAsociado.Text.Trim
            .txtCodPrestamo.Text = Factura.Tables("CADet_Facturas").Rows(0).Item("NoCuenta").ToString.Trim
            .Show()
        End With
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btAbonos.Click
        Try
            Dim ofrm As New frmMsPLAbonos
            ofrm.CodCajero = Me.CodCajero
            ofrm.NoCaja = Me.NoCaja
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnBloquear1_Click(sender As Object, e As EventArgs) Handles btnBloquear1.Click
        Try
            Dim ofrm As New frmMCaBloqueoCaja
            ofrm.txtCajero.Text = Me.vUsuario
            ofrm.frm = Me
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim dr As DataRow, oCaja As New wrCaja.wsLibCaja

        Try
            RecuperarCorrelativoDoc()
            If Me.txtNumero.Text.Trim <> "" Then




                If Me.Factura.Tables("CADet_Facturas").Rows.Count <= 0 Then
                    MessageBox.Show("Debe ingresar un item.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If


                Me.Factura.Tables("CAFacturas").Clear()

                dr = Me.Factura.Tables("CAFacturas").NewRow
                dr("Correlativo") = 1
                dr("IdMovimiento") = Me.txtNumero.Text
                dr("Fec_Mov") = Me.dtpFecha.Value.Date
                dr("DUI") = Me.txtDui.Value
                dr("Vta_Gravada") = vTotalGravado
                dr("Vta_NoGravada") = vTotalNoGravado
                dr("Vta_SIva") = vTotalSIva
                dr("Total_Iva") = vTotalIVA
                dr("Vta_Total") = vTotalFactura
                dr("Nombre") = Me.txtAsociado.Text.Trim
                dr("Impreso") = "N"
                dr("DocPago") = ""
                dr("Estado") = "D"
                dr("FormaPago") = Me.cmbFormaPago.SelectedIndex
                dr("NoCaja") = Me.NoCaja
                dr("UsuarioCaja") = Me.vCodCajero
                dr("Observacion") = pObservacion
                dr("NoReserva") = pNoReserva
                dr("NoCheque") = pNoCheque
                dr("NoCtaBanco") = pNoCtaBanco
                dr("Banco") = pBanco
                dr("MontoPagado") = pMontoPagado
                dr("AbonoCapital") = vPagoCapital
                dr("AbonoInteres") = vPagoInteres
                dr("AbonoCapitalMora") = vPagoCapitalMora
                dr("AbonoInteresMora") = vPagoInteresMora
                dr("AbonoSeguroDeuda") = vPagoSeguroDeuda
                dr("AbonoSeguroDaniosyLA") = vPagoSeguroDanios
                dr("AbonoSeguroVida") = vPagoSeguroVida
                dr("AbonoSeguroDesempleo") = vPagoSeguroDesempleo
                dr("AbonoAportacion") = vPagoAportacion
                dr("AbonoAhorro") = vPagoAhorro
                dr("AbonoComisionManejo") = vPagoComision
                dr("AbonoOtros") = vPagoOtros
                dr("Tipo") = Me.vTipoDoc
                dr("Girador") = pGirador
                dr("Paguese") = pPaguese
                dr("TipoTransaccion") = Me.cbTipoTrans.SelectedIndex
                dr("Estado_Pr") = "D"
                dr("Estado_Ah") = "D"
                dr("Estado_Ap") = "D"
                dr("AbonoSeguroVehiculo") = vPagoSeguroVehiculo
                Me.Factura.Tables("CAFacturas").Rows.Add(dr)

                'Public Function GuardarFactura(ByVal pNumFactura As String, ByVal oFactura As DataSet, ByVal pTipoMov As AlcalaLibs.Caja.clsCAFactura.TipoMovimiento, ByVal pCodTransaccion As String, ByVal pConsolidado As Boolean, ByVal CodSucursal As String, ByVal pUsuario As String, ByVal pPassword As String, ByVal pSucursal As String) As Boolean

                ' AQUI FALTA EL PARAMETRO DEL  Me.CodSucursalCajero, ANTES DEL PARAMETRO DEL USUARIO************************************ OJO
                'If oCaja.GuardarFactura(Me.txtNumero.Text, Me.Factura, vTipo, pCodTransaccion, False, sUsuario, sPassword, sSucursal) Then
                If oCaja.GuardarFactura(Me.txtNumero.Text, Me.Factura, vTipo, pCodTransaccion, False, sUsuario, sPassword, sSucursal) Then
                    If isPagoCheque = True And cmbFormaPago.SelectedIndex = 2 Then
                        contaTranCheques = contaTranCheques + 1
                        vMontoCheque = vMontoCheque - txtTotalFactura.Value
                    End If
                    MessageBox.Show("Registro No." & Me.txtNumero.Text.Trim & " Guardada con éxito.", "Registro Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    If vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                        Me.btnImprimir1_Click(sender, e)
                    End If


                    Me.cbTipoDoc.Enabled = False
                    Me.btnEliminaItem.Enabled = False
                    Me.btnGuardar1.Enabled = False
                    Me.btnImprimir1.Enabled = True
                    Me.btnProvisional.Enabled = True
                    Me.btModificarItem.Enabled = False
                    Me.vCancela = False
                    Me.btnCancelar1.Enabled = True
                    Me.btnLimpiar1.Enabled = True
                    Me.txtTipoMov.Enabled = True
                    Me.cbTipoDoc.Enabled = True
                    Me.cmbFormaPago.Enabled = True
                    If cancelacion = True Then
                        Me.btnCancelacionPrest1.Enabled = True
                        Me.btnCancelacionPrest1.Visible = True
                    End If

                    Dim resultado As Integer
                    If vIdCorrCaja <> 0 Then
                        resultado = Caja.incrementarCorrelativo_CaCorrelativoCaja(Me.txtNumero.Text, vIdCorrCaja)
                        If resultado = 0 Then
                            MsgBox("Error al actualizar correlativo, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Caja")
                        End If
                    Else
                        MsgBox("Error , por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Caja")
                    End If
                Else
                    MessageBox.Show("Registro No." & Me.txtNumero.Text.Trim & " no pudo ser guardada intente de nuevo.", "Registro no guardado.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End If
            Else
                MessageBox.Show("Debe ingresar el número de documento.", "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancelar1_Click(sender As Object, e As EventArgs) Handles btnCancelar1.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiarDatosCheque1_Click(sender As Object, e As EventArgs) Handles btnLimpiarDatosCheque1.Click
        isPagoCheque = False
        vNoReserva = ""
        vNoCheque = ""
        vNoCtaBancaria = ""
        vNoBanco = ""
        vBanco = ""
    End Sub

    Private Sub txtDescripTipoMov_TextChanged(sender As Object, e As EventArgs) Handles txtDescripTipoMov.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFormaPago.SelectedIndexChanged

    End Sub

    Private Sub btnRetCheque1_Click(sender As Object, e As EventArgs) Handles btnRetCheque1.Click
        Try
            Dim Frm As New frmMsBCChequesRetAhorros
            Frm.txtDui.Value = txtDui.Value
            Frm.lblAsociado.Text = txtAsociado.Text.ToUpper.Trim
            Frm.txtComprobante.Text = txtNumero.Text
            Frm.CodCajero = pCodCajero
            Frm.NoCaja = pNocaja
            Frm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click_2(sender As Object, e As EventArgs) Handles btnSolicitudesBoveda.Click
        Try
            Dim frm As New frmMB_SolicitudesBoveda
            With frm
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Dim oItems As wrCaja.wsLibCaja = New wrCaja.wsLibCaja, ds As New Data.DataSet
        Try
            'Comprobante de Retiro y Depósito
            'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro And vTipoDoc <> "F" Then

            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro And vTipoDoc <> "F" Then
                If pTipoTransaccion = "R" Then
                    Dim frm As New frmMsCaPosteoLibretas
                    With frm
                        .txtDui.ReadOnly = False
                        .txtDui.Value = txtDui.Text
                        .txtAsociado.Text = txtAsociado.Text
                        .txtNoCuenta.Text = pNoCuenta.Trim
                        .ShowDialog()
                    End With


                    'Dim ofrmPt As New frmMsCaPosteo
                    'ofrmPt.Nombre = Me.txtAsociado.Text.Trim
                    'ofrmPt.Dui = Me.txtDui.Value
                    'ofrmPt.NoCuenta = Me.pNoCuenta.Trim
                    'ofrmPt.TipoAhorro = Me.pCodTipoAhorro.Trim
                    'ofrmPt.NoLibreta = Me.pNoLibreta.Trim
                    'ofrmPt.btnCerrar.Enabled = False
                    'ofrmPt.Retiro = True
                    'ofrmPt.ShowDialog()
                Else
                    If MessageBox.Show("¿Es un depósito con libreta?", "Posteo de Libreta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim frm As New frmMsCaPosteoLibretas
                        With frm
                            .txtDui.ReadOnly = False
                            .txtDui.Value = txtDui.Text
                            .txtAsociado.Text = txtAsociado.Text
                            .txtNoCuenta.Text = pNoCuenta.Trim
                            .ShowDialog()
                        End With
                        'Dim ofrmPt As New frmMsCaPosteo
                        'ofrmPt.Nombre = Me.txtAsociado.Text.Trim
                        'ofrmPt.Dui = Me.txtDui.Value
                        'ofrmPt.NoCuenta = Me.pNoCuenta.Trim
                        'ofrmPt.TipoAhorro = Me.pCodTipoAhorro.Trim
                        'ofrmPt.NoLibreta = Me.pNoLibreta.Trim
                        'ofrmPt.Retiro = False
                        'ofrmPt.ShowDialog()
                    End If
                End If

                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)
                ds = oItems.ConsultarDatosAhorro("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, sSucursal)
                Dim ofrm As New frmVisor(ds, 17, 0)
                ofrm.Show()
                '====================================================================================================================================================
                '====================================================================================================================================================
                '02/010/2013
                'Javier Ademir escobar martinez
            ElseIf vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.IngresoAsociados Then

                If MessageBox.Show("¿Es un depósito con libreta?", "Posteo de Libreta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim ctaAportaciones As String
                    Dim dtsCtaAportaciones As New DataSet
                    Dim ahorro As New wrAhorro.wsLibAhorro
                    dtsCtaAportaciones = ahorro.ConsultarCuentaAhorro("nocuenta", "dui = '" & txtDui.Text.Trim & "' and left(codTipoAhorro,1)= '1' and estado = 'A' and saldo_CuentaAhorro > 0 ", "", sUsuario, sPassword, sSucursal)
                    If dtsCtaAportaciones.Tables.Count > 0 Then
                        If dtsCtaAportaciones.Tables(0).Rows.Count > 0 Then
                            ctaAportaciones = dtsCtaAportaciones.Tables(0).Rows(0).Item(0).ToString.Trim
                            Dim frm As New frmMsCaPosteoLibretas
                            With frm
                                .txtDui.ReadOnly = False
                                .txtDui.Value = txtDui.Text
                                .txtAsociado.Text = txtAsociado.Text
                                .txtNoCuenta.Text = ctaAportaciones
                                .ShowDialog()
                            End With
                        Else
                            MsgBox(mensajeError, MsgBoxStyle.Critical)
                        End If
                    Else
                        MsgBox(mensajeError, MsgBoxStyle.Critical)
                    End If


                End If

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
                                       pNocaja, Sucursal, txtDescripTipoMov.Text.ToUpper)


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
                encabezado.Text = "COMPROBANTE INGRESO ASOCIADOS"
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

            ElseIf vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion And vTipoDoc = "D" Then
                If MessageBox.Show("¿Es un depósito con libreta?", "Posteo de Libreta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim frm As New frmMsCaPosteoLibretas
                    With frm
                        .txtDui.ReadOnly = False
                        .txtDui.Value = txtDui.Text
                        .txtAsociado.Text = txtAsociado.Text
                        .txtNoCuenta.Text = pNoCuenta.Trim
                        .ShowDialog()
                    End With
                    'Dim ofrmPt As New frmMsCaPosteo
                    'ofrmPt.Nombre = Me.txtAsociado.Text.Trim
                    'ofrmPt.Dui = Me.txtDui.Value
                    'ofrmPt.NoCuenta = Me.pNoCuenta.Trim
                    'ofrmPt.TipoAhorro = Me.pCodTipoAhorro.Trim
                    'ofrmPt.NoLibreta = Me.pNoLibreta.Trim
                    'ofrmPt.Retiro = False
                    'ofrmPt.ShowDialog()
                End If

                oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)




                ds = oItems.ConsultarDatosAhorro("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, sSucursal)
                Dim ofrm As New frmVisor(ds, 17, 0)
                ofrm.Show()
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro And vTipoDoc = "F" Then
            ElseIf vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF And vTipoDoc = "D" Then
                If MessageBox.Show("¿Es un depósito con libreta?", "Posteo de Libreta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim frm As New frmMsCaPosteoLibretas
                    With frm
                        .txtDui.ReadOnly = False
                        .txtDui.Value = txtDui.Text
                        .txtAsociado.Text = txtAsociado.Text
                        .txtNoCuenta.Text = pNoCuenta.Trim
                        .ShowDialog()
                    End With
                    'Dim ofrmPt As New frmMsCaPosteo
                    'ofrmPt.Nombre = Me.txtAsociado.Text.Trim
                    'ofrmPt.Dui = Me.txtDui.Value
                    'ofrmPt.NoCuenta = Me.pNoCuenta.Trim
                    'ofrmPt.TipoAhorro = Me.pCodTipoAhorro.Trim
                    'ofrmPt.NoLibreta = Me.pNoLibreta.Trim
                    'ofrmPt.Retiro = False
                    'ofrmPt.ShowDialog()
                End If
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
                                       pNocaja, Sucursal, txtDescripTipoMov.Text.ToUpper)


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
                encabezado.Text = "COMPROBANTE APERTURA DPF"
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
                'ds = oItems.ConsultarDatosAhorro("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, sSucursal)
                'Dim ofrm As New frmVisor(ds, 23, 0)
                'ofrm.Show()
                'Factura de Consumidor Final para Aportaciones
                'ElseIf (Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Or Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF) And vTipoDoc = "F" Then
            ElseIf (Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF) And vTipoDoc = "F" Then
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
                                       pNocaja, Sucursal, txtDescripTipoMov.Text.ToUpper)


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
                encabezado.Text = "COMPROBANTE DEPOSITO "
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
                '====================================================================================================================================================
                '====================================================================================================================================================
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro And vTipoDoc = "F" Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro And vTipoDoc = "F" Then
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
                                       pNocaja, Sucursal, txtDescripTipoMov.Text.ToUpper)


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
                encabezado.Text = "COMPROBANTE"
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
                'ds = oItems.ConsultarDatosAhorro("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, sSucursal)
                'Dim ofrm As New frmVisor(ds, 23, 0)
                'ofrm.Show()
                'Factura de Consumidor Final para Aportaciones
                'ElseIf (Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Or Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF) And vTipoDoc = "F" Then
            ElseIf (Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF) And vTipoDoc = "F" Then
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
                                       pNocaja, Sucursal, txtDescripTipoMov.Text.ToUpper)


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
                encabezado.Text = "COMPROBANTE DEPOSITO "
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
                'Factura de Consumidor Final para Abonos a Préstamos
                'ElseIf (Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Or Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Cobranza) And vTipoDoc = "F" Then
            ElseIf (Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza) Then
                'LUIS ALVARENGA
                Dim Dts As New DataSet
                Dim dtsMovPrestamo As New DataSet
                dtsMovPrestamo = prestamoLib.ConsultarPRPagos("codprestamo,idmovimiento,fechamov,saldoAnterior,saldo_capital", " idmovimiento = '" & txtNumero.Text & "' and codprestamo = '" & pNoCuenta & "' and  fechamov = '" & dtpFecha.Value.ToShortDateString & "'", "", sUsuario, sPassword, sSucursal)
                If dtsMovPrestamo.Tables(0).Rows.Count > 0 Then
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
                                       pNocaja, Sucursal, txtDescripTipoMov.Text.ToUpper)


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
                    encabezado.Text = "COMPROBANTE DE ABONO A PRESTAMO"
                    encabezadoRetiro.Text = "FORMA DEL ABONO"
                    lblEfectivo.Text = "EFECTIVO"
                    chkEfectivo.Text = IIf(vFormaPago = 0, "X", "")
                    lblCheque.Text = "CHEQUE"
                    chkCheque.Text = IIf(vFormaPago <> 0, "X", "")
                    txtpaguese.Text = "Saldo Anterior: $ " & dtsMovPrestamo.Tables(0).Rows(0).Item("saldoAnterior").ToString
                    lblBancotpt.Text = "Nuevo Saldo:    $ " & dtsMovPrestamo.Tables(0).Rows(0).Item("saldo_Capital").ToString
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

                End If

            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo And vTipoDoc = "C" Then
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
                                       pNocaja, Sucursal, txtDescripTipoMov.Text.ToUpper)


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
                    encabezado.Text = "COMPROBANTE DE ABONO A PRESTAMO"
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
                    'ds = oItems.ConsultarDatosPrestamo(Me.pNoCuenta, Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, sSucursal)
                    'Dim ofrm As New frmVisor(ds, 24, 0)
                    'ofrm.Show()
                    'Crédito Fiscal para Aportaciones
                    'ElseIf Me.vTipo = (AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Or Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF) And vTipoDoc = "C" Then
                ElseIf Me.vTipo = (sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF) And vTipoDoc = "C" Then
                    If MessageBox.Show("¿Es un depósito con libreta?", "Posteo de Libreta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim frm As New frmMsCaPosteoLibretas
                        With frm
                            .txtDui.ReadOnly = False
                            .txtDui.Value = txtDui.Text
                            .txtAsociado.Text = txtAsociado.Text
                            .txtNoCuenta.Text = pNoCuenta.Trim
                            .ShowDialog()
                        End With
                        'Dim ofrmPt As New frmMsCaPosteo
                        'ofrmPt.Nombre = Me.txtAsociado.Text.Trim
                        'ofrmPt.Dui = Me.txtDui.Value
                        'ofrmPt.NoCuenta = Me.pNoCuenta.Trim
                        'ofrmPt.TipoAhorro = Me.pCodTipoAhorro.Trim
                        'ofrmPt.NoLibreta = Me.pNoLibreta.Trim
                        'ofrmPt.Retiro = False
                        'ofrmPt.ShowDialog()
                    End If
                    oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)
                    ds = oItems.ConsultarDatosAhorro("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, sSucursal)
                    Dim ofrm As New frmVisor(ds, 26, 0)
                    ofrm.Show()
                    'Dividendos
                    'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos Then
                ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                    Dim oAsociado As New wrAsociados.wsLibAsoc
                    oItems.ModificaFactura("IdMovimiento='" & Me.txtNumero.Text.Trim & "' and Annio=" & Me.dtpFecha.Value.Date.Year & " and Tipo='" & vTipoDoc & "'", "Impreso='S'", sUsuario, sPassword, sSucursal)
                    ds = oAsociado.Recibo_Dividendos(Me.dtpFecha.Value, Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, Me.txtDui.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 81, 0)
                    ofrm.Show()
                Else 'Otros Ingresos, genérico
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
                                       pNocaja, Sucursal, txtDescripTipoMov.Text.ToUpper)


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
                'ds = oItems.ConsultarDatosFactura("*", Me.txtNumero.Text.Trim, Me.dtpFecha.Value.Date, vTipoDoc, sUsuario, sPassword, sSucursal, sSucursal)
                'If Me.vTipoDoc = "F" Then 'Consumidor Final
                '    Dim ofrm As New frmVisor(ds, 27, 0)
                '    ofrm.Show()
                'ElseIf Me.vTipoDoc = "C" Then 'Crédito Fiscal
                '    Dim ofrm As New frmVisor(ds, 28, 0)
                '    ofrm.Show()
                'End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
#Region "FuncionComprobante "
    Public Property FormaPago() As Integer
        Get
            Return vFormaPago
        End Get
        Set(ByVal value As Integer)
            vFormaPago = value
        End Set
    End Property

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
#End Region


    Private Sub btnLimpiar1_Click(sender As Object, e As EventArgs) Handles btnLimpiar1.Click
        Try
            IniciaFactura()
            vPagoCapital = 0
            vPagoInteres = 0
            vPagoCapitalMora = 0
            vPagoInteresMora = 0
            vPagoSeguroDeuda = 0
            vPagoSeguroDanios = 0
            vPagoSeguroVida = 0
            vPagoSeguroDesempleo = 0
            vPagoAportacion = 0
            vPagoAhorro = 0
            vPagoComision = 0
            vPagoOtros = 0
            vTotalGravado = 0
            vTotalNoGravado = 0
            vTotalSIva = 0
            vTotalIVA = 0
            vTotalFactura = 0
            vPagoSeguroVehiculo = 0
            vCancela = False
            Me.txtNumero.Text = ""
            Me.txtMensaje.Text = ""
            Me.txtTipoMov.Text = ""
            Me.txtDescripTipoMov.Text = ""
            Me.cmbFormaPago.SelectedIndex = 0
            Me.txtAsociado.Text = ""
            Me.txtDui.Value = ""
            Me.txtDui.Enabled = True
            Me.cbTipoDoc.Enabled = True
            Me.txtCuenta.Value = ""
            Me.cbTipoDoc.SelectedIndex = 0
            Me.txtCodTipoDoc.Text = ""
            Me.txtTipoDoc.Text = ""
            Me.btnGuardar1.Enabled = True
            Me.txtTotalFactura.ReadOnly = False
            Me.txtTotalFactura.Enabled = True
            Me.txtTotalFactura.Value = 0
            Me.txtTotalFactura.ReadOnly = True
            Me.txtTotalFactura.Enabled = False
            Me.btnImprimir1.Enabled = False
            Me.btnProvisional.Enabled = False
            Me.btModificarItem.Enabled = False
            Me.txtDui.Focus()
            Me.btnEliminaItem.Enabled = True
            Me.btnCancelar1.Enabled = True
            Me.btnLimpiar1.Enabled = True
            Me.txtTipoMov.Enabled = True
            Me.cbTipoDoc.Enabled = True
            Me.cmbFormaPago.Enabled = True
            Me.lblListaPrestamos.Text = ""
            Me.lblListaPrestamos.Visible = False
            Me.cancelacion = False
            pValDiv = 0
            '14/10/2013
            'Javier Escobar
            'Recuperamos correlativo de item seleccionado
            vTipoDoc = Me.cbTipoDoc.SelectedValue
            Dim idTipoDoc As Integer
            Dim maximo As Integer
            If dtsTiposDoc.Tables.Count > 0 Then
                If dtsTiposDoc.Tables(0).Rows.Count > 0 Then
                    idTipoDoc = dtsTiposDoc.Tables(0).Rows(Me.cbTipoDoc.SelectedIndex).Item("idTipoDoc")
                    Dim dts As New DataSet
                    dts = Caja.consultarCaCorrelativoCaja(sSucursal, pNocaja, idTipoDoc, 0, 3)
                    If dts.Tables.Count > 0 Then
                        If dts.Tables(0).Rows.Count > 0 Then
                            maximo = dts.Tables(0).Rows(0).Item("maximo")
                            If dts.Tables(0).Rows(0).Item("correlativo") < maximo Then
                                Me.txtNumero.Text = dts.Tables(0).Rows(0).Item("correlativo") + 1
                                vIdCorrCaja = dts.Tables(0).Rows(0).Item("idCorrCaja")
                                Me.btnGuardar1.Enabled = True
                            Else
                                Me.btnGuardar1.Enabled = False
                                MsgBox("Se ha llegado al limite de facturas asignadas, por favor solicitar una nueva asignación.", MsgBoxStyle.Information, "Módulo - Caja")
                            End If

                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btModificarItem_Click(sender As Object, e As EventArgs) Handles btModificarItem.Click
        Try
            If Me.Factura.Tables("CADet_Facturas").Rows.Count < 1 Then Exit Sub
            Dim ofrmDet As New frmMsDetCaFactura, dr As DataRow

            For Each dr In Me.Factura.Tables("CADet_Facturas").Rows
                If dr("TipoItem") = "P" Then
                    Me.IdModifica = dr("CodItem")
                    ofrmDet.txtCodItem.Text = Me.IdModifica
                    ofrmDet.txtItem.Text = dr("Descripcion")
                    Exit For
                End If
            Next
            ofrmDet.Dui = Me.txtDui.Value
            ofrmDet.Tipo = Me.vTipo
            ofrmDet.Fecha = Me.dtpFecha.Value
            ofrmDet.Rubro = Me.vRubro
            ofrmDet.TipoMov = Me.vTipoMov
            ofrmDet.TipoDoc = Me.vTipoDoc
            'ofrmDet.AccionDetalle = AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas.ModificarLinea
            ofrmDet.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.ModificarLinea
            ofrmDet.frm = Me

            If Me.cmbFormaPago.SelectedIndex = 0 Then 'Efectivo
                ofrmDet.txtBanco.Enabled = False
            ElseIf Me.cmbFormaPago.SelectedIndex = 1 Then 'Cheque Propio
                ofrmDet.txtNoReserva.ReadOnly = True
                ofrmDet.txtNoCheque.ReadOnly = False
                ofrmDet.txtBanco.ReadOnly = False
                ofrmDet.txtNoCtaBancaria.ReadOnly = False
            ElseIf Me.cmbFormaPago.SelectedIndex = 2 Then 'Cheque Ajeno
                ofrmDet.txtNoReserva.ReadOnly = False
                ofrmDet.txtNoCheque.ReadOnly = False
                ofrmDet.txtBanco.ReadOnly = False
                ofrmDet.txtNoCtaBancaria.ReadOnly = False
            ElseIf Me.cmbFormaPago.SelectedIndex = 3 Then 'Tarjeta
                ofrmDet.txtNoReserva.ReadOnly = True
                ofrmDet.txtNoCheque.ReadOnly = True
                ofrmDet.txtBanco.ReadOnly = True
                ofrmDet.txtBanco.Enabled = False
                ofrmDet.txtNoCtaBancaria.ReadOnly = True
            ElseIf Me.cmbFormaPago.SelectedIndex = 4 Then 'Cta. Ahorro
                ofrmDet.txtNoReserva.ReadOnly = True
                ofrmDet.txtNoCheque.ReadOnly = True
                ofrmDet.txtBanco.ReadOnly = True
                ofrmDet.txtBanco.Enabled = False
                ofrmDet.txtNoCtaBancaria.ReadOnly = True
            ElseIf Me.cmbFormaPago.SelectedIndex = 5 Then 'Otro
                ofrmDet.txtNoReserva.ReadOnly = True
                ofrmDet.txtNoCheque.ReadOnly = True
                ofrmDet.txtBanco.ReadOnly = True
                ofrmDet.txtBanco.Enabled = False
                ofrmDet.txtNoCtaBancaria.ReadOnly = True
            End If

            'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbPrestamo.Visible = True
                ofrmDet.txtCodPrestamo.Text = C1fgrdDetalle.Item(C1fgrdDetalle.Row, "NoCuenta")
                ofrmDet.CargaDatosPrestamo()
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Or Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbAhorros.Visible = True
                ofrmDet.gbPrestamo.Visible = False
                ofrmDet.txtNoCuenta.Text = C1fgrdDetalle.Item(C1fgrdDetalle.Row, "NoCuenta")
                ofrmDet.CargaDatosAhorro()
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbDPF.Visible = True
                ofrmDet.gbPrestamo.Visible = False
                ofrmDet.txtDPFNoCuenta.Text = C1fgrdDetalle.Item(C1fgrdDetalle.Row, "NoCuenta")
                ofrmDet.CargaDatosDPF()
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.IngresoAsociados Then
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbPrestamo.Visible = False
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Generico And Me.vTipoDoc = "H" Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Generico And Me.vTipoDoc = "H" Then
                ofrmDet.gbCheque.Visible = True
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbPrestamo.Visible = False
                ofrmDet.CargaBanco()
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Generico And Me.vTipoDoc <> "H" Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Generico And Me.vTipoDoc <> "H" Then
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbPrestamo.Visible = False
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbPrestamo.Visible = False
            Else
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbDocxCobrar.Visible = True
                ofrmDet.gbPrestamo.Visible = False
                ofrmDet.txtCodPrestamoCxC.Text = C1fgrdDetalle.Item(C1fgrdDetalle.Row, "NoCuenta")
                ofrmDet.CargaDatosPrestamoCxC()
            End If
            If Me.vTipoDoc = "H" Then
                ofrmDet.gbCheque.Visible = True
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbPrestamo.Visible = False
                ofrmDet.CargaBanco()
            End If
            ofrmDet.ShowDialog()
            If Me.Factura.Tables("CADet_Facturas").Rows.Count > 0 Then
                Me.btModificarItem.Enabled = True
                Me.btnEliminaItem.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Seleccione una fila.", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles btnEliminaItem.Click
        Try
            Me.Factura.Tables("CADet_Facturas").Rows.Clear()
            vPagoCapital = 0
            vPagoInteres = 0
            vPagoCapitalMora = 0
            vPagoInteresMora = 0
            vPagoSeguroDeuda = 0
            vPagoSeguroDanios = 0
            vPagoSeguroVida = 0
            vPagoSeguroDesempleo = 0
            vPagoAportacion = 0
            vPagoAhorro = 0
            vPagoComision = 0
            vPagoOtros = 0
            vTotalGravado = 0
            vTotalNoGravado = 0
            vTotalSIva = 0
            vTotalIVA = 0
            vTotalFactura = 0
            vCancela = False
            Me.txtTotalFactura.ReadOnly = False
            Me.txtTotalFactura.Enabled = True
            Me.txtTotalFactura.Value = 0
            Me.txtTotalFactura.ReadOnly = True
            Me.txtTotalFactura.Enabled = False
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


    Dim vCodItemRubro As String
    'Modificar aquí códigos de Rubros
    Private Sub txtTipoMov_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoMov.DoubleClick

        Dim oCaja As wrCaja.wsLibCaja, ds As New Data.DataSet("Rubros") ', dr As DataRow
        Dim frm As New frmAGenerico, sTexto As String

        frm.Text = "Buscar Movimiento para Facturar"

        Try
            oCaja = New wrCaja.wsLibCaja

            ds = oCaja.ObtenerListaRubros("*", "", sUsuario, sPassword, sSucursal)

            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                vRubro = Trim(sTexto)
                Me.txtTipoMov.Text = vRubro
                Me.txtDescripTipoMov.Text = frm.Resultado2.Trim
                'vCodItemRubro = frm.Resultado3
                Select Case vRubro
                    Case "2"
                        'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo
                        Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo
                    Case "12"
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
                    Case "7"
                        'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Cobranza
                        Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza
                    Case "6"
                        'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos
                        Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos
                        'Case "10"
                        '    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.costaCoopas
                        'Case "11"
                        '    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.gestionMora
                    Case Else
                        'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Generico
                        Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Generico
                End Select

            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla CAItemsFact- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Protected Sub RecuperarCorrelativoDoc()
        vTipoDoc = Me.cbTipoDoc.SelectedValue
        Dim idTipoDoc As Integer
        Dim maximo As Integer
        If dtsTiposDoc.Tables.Count > 0 Then
            If dtsTiposDoc.Tables(0).Rows.Count > 0 Then
                idTipoDoc = dtsTiposDoc.Tables(0).Rows(Me.cbTipoDoc.SelectedIndex).Item("idTipoDoc")
                Dim dts As New DataSet
                dts = Caja.consultarCaCorrelativoCaja(sSucursal, pNocaja, idTipoDoc, 0, 3)
                If dts.Tables.Count > 0 Then
                    If dts.Tables(0).Rows.Count > 0 Then
                        maximo = dts.Tables(0).Rows(0).Item("maximo")
                        If dts.Tables(0).Rows(0).Item("correlativo") < maximo Then
                            Me.txtNumero.Text = dts.Tables(0).Rows(0).Item("correlativo") + 1
                            vIdCorrCaja = dts.Tables(0).Rows(0).Item("idCorrCaja")
                            Me.btnGuardar1.Enabled = True
                        Else
                            Me.btnGuardar1.Enabled = False
                            MsgBox("Se ha llegado al limite de facturas asignadas, por favor solicitar una nueva asignación.", MsgBoxStyle.Information, "Módulo - Caja")
                        End If

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cbTipoDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoDoc.SelectedIndexChanged
        vTipoDoc = Me.cbTipoDoc.SelectedValue
        Dim idTipoDoc As Integer
        Dim maximo As Integer
        If dtsTiposDoc.Tables.Count > 0 Then
            If dtsTiposDoc.Tables(0).Rows.Count > 0 Then
                idTipoDoc = dtsTiposDoc.Tables(0).Rows(Me.cbTipoDoc.SelectedIndex).Item("idTipoDoc")
                Dim dts As New DataSet
                dts = Caja.consultarCaCorrelativoCaja(sSucursal, pNocaja, idTipoDoc, 0, 3)
                If dts.Tables.Count > 0 Then
                    If dts.Tables(0).Rows.Count > 0 Then
                        maximo = dts.Tables(0).Rows(0).Item("maximo")
                        If dts.Tables(0).Rows(0).Item("correlativo") < maximo Then
                            Me.txtNumero.Text = dts.Tables(0).Rows(0).Item("correlativo") + 1
                            vIdCorrCaja = dts.Tables(0).Rows(0).Item("idCorrCaja")
                            Me.btnGuardar1.Enabled = True
                        Else
                            Me.btnGuardar1.Enabled = False
                            MsgBox("Se ha llegado al limite de facturas asignadas, por favor solicitar una nueva asignación.", MsgBoxStyle.Information, "Módulo - Caja")
                        End If

                    End If
                End If

            End If
        End If
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




    Dim dtsDetReserva As New DataSet
    Dim idReserva As Integer

    '=====================================================
    '25/11/2013
    'Javier Martinez
    'Pago de mas de una transaccion con un mismo cheque
    Dim vNoReserva As String
    Dim vNoCheque As String
    Dim vNoCtaBancaria As String
    Dim vNoBanco As String
    Dim vBanco As String
    Dim isPagoCheque As Boolean
    Dim contaTranCheques As Integer
    Dim vMontoCheque As Double
    Private Sub cmbFormaPago_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFormaPago.LostFocus
        Try
            If cmbFormaPago.SelectedIndex = 2 Then
                Dim frmDatosCheque As New frmMsDatosCheque
                If isPagoCheque = False Then
                    If MsgBox("¿Se realizara más de un pago con cheque?", MsgBoxStyle.YesNo, "Módulo - Caja") = MsgBoxResult.Yes Then
                        With frmDatosCheque
                            .ShowDialog()
                        End With
                        vNoReserva = frmDatosCheque.noReserva
                        vNoCheque = frmDatosCheque.noCheque.ToString
                        vNoCtaBancaria = frmDatosCheque.noCuenta
                        vNoBanco = frmDatosCheque.idBanco
                        vBanco = frmDatosCheque.banco
                        vMontoCheque = frmDatosCheque.MontoPagosRealizados
                        If vMontoCheque <= 0 Then
                            MsgBox("Se ha superado el monto del cheque.", MsgBoxStyle.Critical, "Módulo - Caja")
                            Exit Sub
                        End If
                        contaTranCheques = frmDatosCheque.NoPagosRealizados
                        isPagoCheque = True
                    End If
                Else
                    If vMontoCheque <= 0 Then
                        MsgBox("Se ha superado el monto del cheque.", MsgBoxStyle.Critical, "Módulo - Caja")
                        Exit Sub
                    End If

                End If
            End If





            Dim ofrmDet As New frmMsDetCaFactura

            If Me.txtDui.Text.Trim = "" Then Exit Sub
            If Me.Factura.Tables("CADet_Facturas").Rows.Count > 0 Then Exit Sub
            ofrmDet.Dui = Me.txtDui.Value
            ofrmDet.Tipo = Me.vTipo
            ofrmDet.Fecha = Me.dtpFecha.Value
            ofrmDet.Rubro = Me.vRubro
            ofrmDet.TipoMov = Me.vTipoMov
            ofrmDet.TipoDoc = Me.vTipoDoc
            ofrmDet.NombreAsociado = Me.txtAsociado.Text.Trim
            ofrmDet.FormaPago = Me.cmbFormaPago.SelectedIndex
            ofrmDet.saldoGestion = saldoGestion
            'ofrmDet.codItemRubro = vCodItemRubro
            'ofrmDet.AccionDetalle = AlcalaLibs.Caja.clsCAFactura.TipoAccionFacturas.AgregarLinea
            ofrmDet.AccionDetalle = sifLib.Caja.clsCAFacturas.TipoAccionFacturas.AgregarLinea
            ofrmDet.frm = Me
            If Me.cmbFormaPago.SelectedIndex = 0 Then 'Efectivo
                ofrmDet.txtBanco.Enabled = False
            ElseIf Me.cmbFormaPago.SelectedIndex = 1 Then 'Cheque Propio
                ofrmDet.txtNoReserva.ReadOnly = True
                ofrmDet.txtNoCheque.ReadOnly = False
                ofrmDet.txtBanco.ReadOnly = False
                ofrmDet.txtNoCtaBancaria.ReadOnly = False
            ElseIf Me.cmbFormaPago.SelectedIndex = 2 Then 'Cheque Ajeno
                ofrmDet.txtNoReserva.ReadOnly = False
                ofrmDet.txtNoCheque.ReadOnly = False
                ofrmDet.txtBanco.ReadOnly = False
                ofrmDet.txtNoCtaBancaria.ReadOnly = False

                If isPagoCheque = True Then
                    ofrmDet.txtNoReserva.Text = vNoReserva
                    ofrmDet.txtNoCheque.Text = vNoCheque.ToString + "_" + contaTranCheques.ToString
                    ofrmDet.txtBanco.Text = vNoBanco
                    ofrmDet.txtNoCtaBancaria.Text = vNoCtaBancaria
                    ofrmDet.lblBanco.Text = vBanco
                End If


            ElseIf Me.cmbFormaPago.SelectedIndex = 3 Then 'Tarjeta
                ofrmDet.txtNoReserva.ReadOnly = True
                ofrmDet.txtNoCheque.ReadOnly = True
                ofrmDet.txtBanco.ReadOnly = True
                ofrmDet.txtBanco.Enabled = False
                ofrmDet.txtNoCtaBancaria.ReadOnly = True
            ElseIf Me.cmbFormaPago.SelectedIndex = 4 Then 'Cta. Ahorro
                ofrmDet.txtNoReserva.ReadOnly = True
                ofrmDet.txtNoCheque.ReadOnly = True
                ofrmDet.txtBanco.ReadOnly = True
                ofrmDet.txtBanco.Enabled = False
                ofrmDet.txtNoCtaBancaria.ReadOnly = True
            ElseIf Me.cmbFormaPago.SelectedIndex = 5 Then 'Otro
                ofrmDet.txtNoReserva.ReadOnly = True
                ofrmDet.txtNoCheque.ReadOnly = True
                ofrmDet.txtBanco.ReadOnly = True
                ofrmDet.txtBanco.Enabled = False
                ofrmDet.txtNoCtaBancaria.ReadOnly = True
            End If
            'If Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo Then
            If Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo Then
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbPrestamo.Visible = True
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Ahorro Or Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.PagoAportacion Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Ahorro Or Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.PagoAportacion Then
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbAhorros.Visible = True
                ofrmDet.gbPrestamo.Visible = False
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AperturaDPF Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AperturaDPF Then
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbDPF.Visible = True
                ofrmDet.gbPrestamo.Visible = False
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.IngresoAsociados Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.IngresoAsociados Then
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbPrestamo.Visible = False
                ofrmDet.gbOtros.Visible = True
                ofrmDet.gbItem.Enabled = True
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Generico And Me.vTipoDoc = "H" Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Generico And Me.vTipoDoc = "H" Then
                ofrmDet.gbCheque.Visible = True
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbPrestamo.Visible = False
                ofrmDet.gbItem.Enabled = True
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Generico And Me.vTipoDoc <> "H" Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Generico And Me.vTipoDoc <> "H" Then
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbPrestamo.Visible = False
                ofrmDet.gbOtros.Visible = True
                ofrmDet.gbItem.Enabled = True
                'ElseIf Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos Then
            ElseIf Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos Then
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbPrestamo.Visible = False
                ofrmDet.gbOtros.Visible = True
                ofrmDet.gbItem.Enabled = True
                ConsultaPagoDividendo()
                ofrmDet.ValDiv = Me.pValDiv
                ofrmDet.txtPago.Value = Me.pValDiv
                ofrmDet.txtPago.Enabled = False
            Else
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbCheque.Visible = False
                ofrmDet.gbDocxCobrar.Visible = True
                ofrmDet.gbPrestamo.Visible = False

            End If
            If Me.vTipoDoc = "H" Then
                ofrmDet.gbCheque.Visible = True
                ofrmDet.gbDPF.Visible = False
                ofrmDet.gbDocxCobrar.Visible = False
                ofrmDet.gbAhorros.Visible = False
                ofrmDet.gbPrestamo.Visible = False
            End If
            ofrmDet.ShowDialog()
            If Me.Factura.Tables("CADet_Facturas").Rows.Count > 0 Then
                Me.btnEliminaItem.Enabled = True
                Me.btModificarItem.Enabled = True
                Me.txtMensaje.Text = pMensajeCajas
            End If
            If vCancela = True Then
                Me.btModificarItem.Enabled = False
                Me.btnEliminaItem.Enabled = False
                Me.btnCancelar1.Enabled = False
                Me.btnLimpiar1.Enabled = False
                Me.txtTipoMov.Enabled = False
                Me.cbTipoDoc.Enabled = False
                Me.cmbFormaPago.Enabled = False
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ConsultaPagoDividendo()
        Try
            Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet, dr As DataRow, oCaja As New wrCaja.wsLibCaja, oApp As New wrAdmin.wsLibAdmin
            ds = oAsoc.ConsultarDividendos("a.*", "a.Dui='" & Me.txtDui.Value & "' and a.Estado='0' and b.Desde<='" & oApp.Fecha.ToShortDateString & "' and b.Hasta>='" & oApp.Fecha.ToShortDateString & "'", "a.Dui", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                'Modificacion Realizada el 04/05/2012 Javier Martinez
                'Resta de ISR sobre el monto del div. Para los ex- asociados.
                dr = ds.Tables(0).Rows(0)
                'If (IIf(IsDBNull(dr("Saldo_Efectivo")), 0, dr("Saldo_Efectivo")) > 0 And IIf(IsDBNull(dr("Saldo_Capitalizado")), 0, dr("Saldo_Capitalizado")) > 0) Then
                If (IIf(IsDBNull(dr("Saldo_Efectivo")), 0, dr("Saldo_Efectivo")) > 0 And IIf(IsDBNull(dr("ISRAPLICADO")), True, dr("ISRAPLICADO")) = False) Then
                    pValDiv = Math.Round(IIf(IsDBNull(dr("Saldo_Efectivo")), 0, dr("Saldo_Efectivo")) + IIf(IsDBNull(dr("Saldo_Capitalizado")), 0, dr("Saldo_Capitalizado")) - IIf(IsDBNull(dr("CalculoISR")), 0, dr("CalculoISR")), 2)
                Else
                    pValDiv = Math.Round(IIf(IsDBNull(dr("Saldo_Efectivo")), 0, dr("Saldo_Efectivo")) + IIf(IsDBNull(dr("Saldo_Capitalizado")), 0, dr("Saldo_Capitalizado")), 2)
                End If
                'dr = ds.Tables(0).Rows(0)
                'pValDiv = oCaja.Redondear(IIf(IsDBNull(dr("Saldo_Efectivo")), 0, dr("Saldo_Efectivo")), 2) + oCaja.Redondear(IIf(IsDBNull(dr("Saldo_Capitalizado")), 0, dr("Saldo_Capitalizado")), 2)
            Else
                pValDiv = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo Caja")
        End Try

    End Sub





    Private Sub txtTipoMov_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoMov.LostFocus

        Dim oCaja As wrCaja.wsLibCaja, ds As New Data.DataSet("Rubros"), dr As DataRow, dsTmp As New DataSet, pTDoc As String

        Try
            oCaja = New wrCaja.wsLibCaja
            If saldoGestion > 0 And Me.txtTipoMov.Text = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo.ToString Then
                MsgBox("Debe facturar las gestiones de mora pendientes", MsgBoxStyle.Exclamation, "Módulo - Caja")
            End If
            vRubro = Trim(Me.txtTipoMov.Text)
            ds = oCaja.ObtenerListaRubros("*", "IdRubro='" & vRubro & "'", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtTipoMov.Text = vRubro
                Me.txtDescripTipoMov.Text = dr("Descripcion")
                'vCodItemRubro = dr("codItem").ToString
                Select Case vRubro
                    Case "2"
                        'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.AbonoPrestamo
                        Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.AbonoPrestamo
                    Case "12"
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
                    Case "7"
                        'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Cobranza
                        Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Cobranza
                    Case "6"
                        'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Dividendos
                        Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Dividendos
                        'Case "10"
                        '    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.costaCoopas
                        'Case "11"
                        '    Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.gestionMora
                    Case Else
                        'Me.vTipo = AlcalaLibs.Caja.clsCAFactura.TipoMovimiento.Generico
                        Me.vTipo = sifLib.Caja.clsCAFacturas.TipoMovimiento.Generico
                End Select
            End If
            dsTmp = oCaja.ObtenerItemxRubro("IdRubro='" & vRubro & "'", sUsuario, sPassword, sSucursal)
            If dsTmp.Tables(0).Rows.Count > 0 Then
                dr = dsTmp.Tables(0).Rows(0)
                pTDoc = IIf(IsDBNull(dr("TipoDoc")), "", dr("TipoDoc"))
                If pTDoc = "F" Then 'Factura
                    cbTipoDoc.SelectedIndex = 0
                    txtCodTipoDoc.Text = "0"
                    txtCodTipoDoc_LostFocus(sender, e)
                ElseIf pTDoc = "C" Then  'Crédito Fiscal
                    cbTipoDoc.SelectedIndex = 1
                    txtCodTipoDoc.Text = "1"
                    txtCodTipoDoc_LostFocus(sender, e)
                ElseIf pTDoc = "R" Then  'Comprobante Retiro
                    cbTipoDoc.SelectedIndex = 2
                    txtCodTipoDoc.Text = "2"
                    txtCodTipoDoc_LostFocus(sender, e)
                ElseIf pTDoc = "D" Then  'Comprobante Depósito
                    cbTipoDoc.SelectedIndex = 3
                    txtCodTipoDoc.Text = "3"
                    txtCodTipoDoc_LostFocus(sender, e)
                ElseIf pTDoc = "P" Then  'Comprobante de Pago o Recibo
                    cbTipoDoc.SelectedIndex = 4
                    txtCodTipoDoc.Text = "4"
                    txtCodTipoDoc_LostFocus(sender, e)
                ElseIf pTDoc = "H" Then  'Comprobante de Cambio de Cheque
                    cbTipoDoc.SelectedIndex = 5
                    txtCodTipoDoc.Text = "5"
                    txtCodTipoDoc_LostFocus(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla CAItemsFact- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCAFactura_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If vCancela = True Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub


    Private Sub txtCodTipoDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoDoc.DoubleClick
        Try
            Dim frm As New frmAGenerico, oCaja As New wrCaja.wsLibCaja
            Dim ds As New Data.DataSet ' dr As DataRow

            ds = oCaja.ConsultarTiposDoc(sUsuario, sPassword, sSucursal)
            frm.Text = "Buscar Tipos de Documento"
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros
            ElseIf frm.Resultado.Trim <> "" Then
                txtCodTipoDoc.Text = frm.Resultado.Trim
                txtTipoDoc.Text = frm.Resultado2.Trim
                cbTipoDoc.SelectedIndex = txtCodTipoDoc.Text
            End If
        Catch ex As Exception
            MessageBox.Show("System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodTipoDoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoDoc.LostFocus
        Try
            Dim oCaja As New wrCaja.wsLibCaja
            Dim ds As New Data.DataSet, dr As DataRow

            ds = oCaja.ConsultarTiposDoc(sUsuario, sPassword, sSucursal)
            For Each dr In ds.Tables(0).Rows
                If Me.txtCodTipoDoc.Text.Trim.Equals(dr("Codigo")) Then
                    txtCodTipoDoc.Text = dr("Codigo")
                    txtTipoDoc.Text = dr("Descripcion")
                    cbTipoDoc.SelectedIndex = txtCodTipoDoc.Text
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub
    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)
    End Function
    Public Overloads Shared Function ResizeImage(bmSource As Drawing.Bitmap, TargetWidth As Int32, TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver

                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using

        Return bmDest
    End Function
    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub

        Dim sTexto As String
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Value
            If sTexto = "" Then      'Filtrar Registros
            ElseIf sTexto <> "" Then
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio,CodAntiguo,imagen,firmas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    vNoSocio = dr("NoSocio")
                    vNoSocioAnterior = IIf(dr("CodAntiguo") Is DBNull.Value, "", dr("CodAntiguo"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Try
                        If IsDBNull(ds.Tables(0).Rows(0).Item("Imagen")) = False Then
                            'Dim foto As Byte()
                            Me.txtFoto.Image = ResizeImage(ByteArrayToImage(ds.Tables(0).Rows(0).Item("Imagen")), Me.txtFoto.Width, Me.txtFoto.Height) ' ByteArrayToImage(ds.Tables(0).Rows(0).Item("Imagen"))
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If IsDBNull(ds.Tables(0).Rows(0).Item("Firmas")) = False Then
                            'Dim foto As Byte()
                            Me.pbFirma.Image = ResizeImage(ByteArrayToImage(ds.Tables(0).Rows(0).Item("Firmas")), Me.pbFirma.Width, Me.pbFirma.Height) ' ByteArrayToImage(ds.Tables(0).Rows(0).Item("Firmas"))
                        End If
                    Catch ex As Exception
                    End Try




                    Dim oPr As New wrPrestamo.wsLibPrest, dsPr As New DataSet, pTipoPr As String
                    dsPr = oPr.ConsultarPRPrestamos("*", "Dui='" & sTexto & "' and Estado='A' and Tipo<>'N'", "FechaOtorgamiento", sUsuario, sPassword, sSucursal)
                    Me.lblListaPrestamos.Visible = True
                    Me.lblListaPrestamos.Text = "Código Préstamo          Tipo" & vbCrLf
                    For Each dr In dsPr.Tables(0).Rows
                        If dr("Tipo") = "S" Then
                            pTipoPr = "Documento Saneado"
                        ElseIf dr("Tipo") = "C" Then
                            pTipoPr = "Documento x Cobrar"
                        ElseIf dr("Tipo") = "P" Then
                            pTipoPr = "Documento en Protesto"
                        End If
                        Me.lblListaPrestamos.Text = Me.lblListaPrestamos.Text & dr("CodPrestamo") & "     " & pTipoPr & vbCrLf
                    Next
                    'D: Digitado (sin tabla de amortización); A: Activo (ya se ha generado tabla de amortización); B: Bloqueado
                    'S: Documento Saneado; C: Documento x Cobrar; P: Documento en Protesto; N: Cartera Normal
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: NO ENCUENTRA DUI ASOCIADO --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class