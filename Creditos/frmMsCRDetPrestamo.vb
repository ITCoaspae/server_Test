Public Class frmMsCRDetPrestamo
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tb As System.Windows.Forms.TabControl
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents ttipAsoc As System.Windows.Forms.ToolTip
    Friend WithEvents txtNumSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAnterior As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents txtNoAsoc As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbDatGral As System.Windows.Forms.TabPage
    Friend WithEvents tbTblAmort As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtFechaVencimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaOtorgamiento As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaPrimeraCuota As System.Windows.Forms.TextBox
    Friend WithEvents txtTasaInteresMora As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents txtTasaInteres As System.Windows.Forms.TextBox
    Friend WithEvents txtNoActa As System.Windows.Forms.TextBox
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtInteresPagado As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaUltimoPago As System.Windows.Forms.TextBox
    Friend WithEvents chkGeneraReserva As System.Windows.Forms.CheckBox
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtCuota As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTablaAmortiza As System.Windows.Forms.TextBox
    Friend WithEvents tbSaldos As System.Windows.Forms.TabPage
    Friend WithEvents txtSaldoDiaInteresMora As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoDiaCapitalMora As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoDiaInteres As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaSegDeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaComision As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaSegDanios As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDiaAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents C1fgrdDetalleTA As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1fgrdProv As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtSaldoDiaAportacion As System.Windows.Forms.TextBox
    Friend WithEvents tbGarantias As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents fgGr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgCd As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgFd As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tbHistorial As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents fgHistorial As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgDetalleHistorial As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents btnSigTb1_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTb2_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btAtrasTb2_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCargarTabla1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAsinaTA1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditCd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelCd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewCd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditFd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelFd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewFd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditGr1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelGr1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewGr1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btConsultaGarantiasInt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtFechayHora As System.Windows.Forms.TextBox


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCRDetPrestamo))
        Me.tb = New System.Windows.Forms.TabControl()
        Me.tbDatGral = New System.Windows.Forms.TabPage()
        Me.btnSigTb1_1 = New MetroFramework.Controls.MetroButton()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaVencimiento = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtFechaOtorgamiento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFechaPrimeraCuota = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTasaInteresMora = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMontoGarantia = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoAsoc = New System.Windows.Forms.TextBox()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
        Me.txtTasaInteres = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtNoActa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumSolicitud = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtCodAnterior = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.tbTblAmort = New System.Windows.Forms.TabPage()
        Me.btnSigTb2_1 = New MetroFramework.Controls.MetroButton()
        Me.btAtrasTb2_1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFechayHora = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnAsinaTA1 = New MetroFramework.Controls.MetroButton()
        Me.btnCargarTabla1 = New MetroFramework.Controls.MetroButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtInteresPagado = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtFechaUltimoPago = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkGeneraReserva = New System.Windows.Forms.CheckBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCuota = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.C1fgrdDetalleTA = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtCodTablaAmortiza = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbSaldos = New System.Windows.Forms.TabPage()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSaldoDiaAportacion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaComision = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaSegDanios = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaAhorro = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaSegDeuda = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaInteresMora = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaCapitalMora = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSaldoDiaInteres = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.C1fgrdProv = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbHistorial = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.fgDetalleHistorial = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.fgHistorial = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbGarantias = New System.Windows.Forms.TabPage()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btEditCd1 = New MetroFramework.Controls.MetroButton()
        Me.btDelCd1 = New MetroFramework.Controls.MetroButton()
        Me.btNewCd1 = New MetroFramework.Controls.MetroButton()
        Me.fgCd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btEditFd1 = New MetroFramework.Controls.MetroButton()
        Me.btDelFd1 = New MetroFramework.Controls.MetroButton()
        Me.btNewFd1 = New MetroFramework.Controls.MetroButton()
        Me.fgFd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btConsultaGarantiasInt1 = New MetroFramework.Controls.MetroButton()
        Me.btEditGr1 = New MetroFramework.Controls.MetroButton()
        Me.btDelGr1 = New MetroFramework.Controls.MetroButton()
        Me.btNewGr1 = New MetroFramework.Controls.MetroButton()
        Me.fgGr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ttipAsoc = New System.Windows.Forms.ToolTip(Me.components)
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.tb.SuspendLayout()
        Me.tbDatGral.SuspendLayout()
        Me.gbDatDoc.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbTblAmort.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.C1fgrdDetalleTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbSaldos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1fgrdProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbHistorial.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.fgDetalleHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.fgHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbGarantias.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.fgCd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.fgFd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.fgGr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb
        '
        Me.tb.Controls.Add(Me.tbDatGral)
        Me.tb.Controls.Add(Me.tbTblAmort)
        Me.tb.Controls.Add(Me.tbSaldos)
        Me.tb.Controls.Add(Me.tbHistorial)
        Me.tb.Controls.Add(Me.tbGarantias)
        Me.tb.HotTrack = True
        Me.tb.Location = New System.Drawing.Point(28, 73)
        Me.tb.Name = "tb"
        Me.tb.SelectedIndex = 0
        Me.tb.Size = New System.Drawing.Size(796, 443)
        Me.tb.TabIndex = 15
        '
        'tbDatGral
        '
        Me.tbDatGral.BackColor = System.Drawing.Color.White
        Me.tbDatGral.Controls.Add(Me.btnSigTb1_1)
        Me.tbDatGral.Controls.Add(Me.gbDatDoc)
        Me.tbDatGral.ImageIndex = 0
        Me.tbDatGral.Location = New System.Drawing.Point(4, 25)
        Me.tbDatGral.Name = "tbDatGral"
        Me.tbDatGral.Size = New System.Drawing.Size(788, 414)
        Me.tbDatGral.TabIndex = 0
        Me.tbDatGral.Text = "A - Datos Generales"
        Me.tbDatGral.ToolTipText = "Datos Generales del Préstamo"
        '
        'btnSigTb1_1
        '
        Me.btnSigTb1_1.Location = New System.Drawing.Point(688, 358)
        Me.btnSigTb1_1.Name = "btnSigTb1_1"
        Me.btnSigTb1_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTb1_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTb1_1.TabIndex = 212
        Me.btnSigTb1_1.Text = "Siguiente"
        Me.btnSigTb1_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTb1_1.UseSelectable = True
        Me.btnSigTb1_1.UseStyleColors = True
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.Label3)
        Me.gbDatDoc.Controls.Add(Me.txtFechaVencimiento)
        Me.gbDatDoc.Controls.Add(Me.txtCategoria)
        Me.gbDatDoc.Controls.Add(Me.Label1)
        Me.gbDatDoc.Controls.Add(Me.txtNombre)
        Me.gbDatDoc.Controls.Add(Me.Label35)
        Me.gbDatDoc.Controls.Add(Me.txtFechaOtorgamiento)
        Me.gbDatDoc.Controls.Add(Me.Label12)
        Me.gbDatDoc.Controls.Add(Me.txtFechaPrimeraCuota)
        Me.gbDatDoc.Controls.Add(Me.Label11)
        Me.gbDatDoc.Controls.Add(Me.txtTasaInteresMora)
        Me.gbDatDoc.Controls.Add(Me.Label9)
        Me.gbDatDoc.Controls.Add(Me.Label5)
        Me.gbDatDoc.Controls.Add(Me.txtMontoGarantia)
        Me.gbDatDoc.Controls.Add(Me.txtDui)
        Me.gbDatDoc.Controls.Add(Me.txtNoAsoc)
        Me.gbDatDoc.Controls.Add(Me.txtCodPrestamo)
        Me.gbDatDoc.Controls.Add(Me.txtTipoCredito)
        Me.gbDatDoc.Controls.Add(Me.txtTasaInteres)
        Me.gbDatDoc.Controls.Add(Me.Label48)
        Me.gbDatDoc.Controls.Add(Me.txtNoActa)
        Me.gbDatDoc.Controls.Add(Me.Label10)
        Me.gbDatDoc.Controls.Add(Me.txtPlazo)
        Me.gbDatDoc.Controls.Add(Me.Label8)
        Me.gbDatDoc.Controls.Add(Me.Label7)
        Me.gbDatDoc.Controls.Add(Me.Label6)
        Me.gbDatDoc.Controls.Add(Me.txtNumSolicitud)
        Me.gbDatDoc.Controls.Add(Me.Label4)
        Me.gbDatDoc.Controls.Add(Me.Label2)
        Me.gbDatDoc.Controls.Add(Me.Label18)
        Me.gbDatDoc.Controls.Add(Me.Label30)
        Me.gbDatDoc.Controls.Add(Me.Label31)
        Me.gbDatDoc.Controls.Add(Me.txtCodAnterior)
        Me.gbDatDoc.Controls.Add(Me.txtMonto)
        Me.gbDatDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Teal
        Me.gbDatDoc.Location = New System.Drawing.Point(10, 9)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(768, 342)
        Me.gbDatDoc.TabIndex = 47
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Datos Generales del Préstamo"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Fecha Vencimiento:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.BackColor = System.Drawing.Color.White
        Me.txtFechaVencimiento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(173, 293)
        Me.txtFechaVencimiento.MaxLength = 25
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.ReadOnly = True
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(144, 23)
        Me.txtFechaVencimiento.TabIndex = 131
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.White
        Me.txtCategoria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(617, 293)
        Me.txtCategoria.MaxLength = 25
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(144, 23)
        Me.txtCategoria.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(439, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 19)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Categoría del Prestamo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(355, 28)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(406, 23)
        Me.txtNombre.TabIndex = 127
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(278, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 28)
        Me.Label35.TabIndex = 128
        Me.Label35.Text = "Nombre Asociado:"
        '
        'txtFechaOtorgamiento
        '
        Me.txtFechaOtorgamiento.BackColor = System.Drawing.Color.White
        Me.txtFechaOtorgamiento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaOtorgamiento.Location = New System.Drawing.Point(173, 265)
        Me.txtFechaOtorgamiento.MaxLength = 25
        Me.txtFechaOtorgamiento.Name = "txtFechaOtorgamiento"
        Me.txtFechaOtorgamiento.ReadOnly = True
        Me.txtFechaOtorgamiento.Size = New System.Drawing.Size(144, 23)
        Me.txtFechaOtorgamiento.TabIndex = 125
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(19, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 19)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Fecha Otorgamiento:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtFechaPrimeraCuota
        '
        Me.txtFechaPrimeraCuota.BackColor = System.Drawing.Color.White
        Me.txtFechaPrimeraCuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaPrimeraCuota.Location = New System.Drawing.Point(617, 267)
        Me.txtFechaPrimeraCuota.MaxLength = 25
        Me.txtFechaPrimeraCuota.Name = "txtFechaPrimeraCuota"
        Me.txtFechaPrimeraCuota.ReadOnly = True
        Me.txtFechaPrimeraCuota.Size = New System.Drawing.Size(144, 23)
        Me.txtFechaPrimeraCuota.TabIndex = 123
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(439, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 19)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "Fecha Primera Cuota:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtTasaInteresMora
        '
        Me.txtTasaInteresMora.BackColor = System.Drawing.Color.White
        Me.txtTasaInteresMora.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaInteresMora.Location = New System.Drawing.Point(617, 211)
        Me.txtTasaInteresMora.MaxLength = 10
        Me.txtTasaInteresMora.Name = "txtTasaInteresMora"
        Me.txtTasaInteresMora.ReadOnly = True
        Me.txtTasaInteresMora.Size = New System.Drawing.Size(144, 23)
        Me.txtTasaInteresMora.TabIndex = 121
        Me.ttipAsoc.SetToolTip(Me.txtTasaInteresMora, "Este código se digita si no se encuentra en la Base de Datos.")
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(439, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 18)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "Tasa de Interés Moratorio:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(439, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 19)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Monto de la Garantía:"
        '
        'txtMontoGarantia
        '
        Me.txtMontoGarantia.BackColor = System.Drawing.Color.White
        Me.txtMontoGarantia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoGarantia.Location = New System.Drawing.Point(617, 183)
        Me.txtMontoGarantia.MaxLength = 20
        Me.txtMontoGarantia.Name = "txtMontoGarantia"
        Me.txtMontoGarantia.ReadOnly = True
        Me.txtMontoGarantia.Size = New System.Drawing.Size(144, 23)
        Me.txtMontoGarantia.TabIndex = 119
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDui.Location = New System.Drawing.Point(125, 28)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(134, 24)
        Me.txtDui.TabIndex = 117
        Me.txtDui.Tag = Nothing
        '
        'txtNoAsoc
        '
        Me.txtNoAsoc.BackColor = System.Drawing.Color.White
        Me.txtNoAsoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoAsoc.Location = New System.Drawing.Point(125, 65)
        Me.txtNoAsoc.MaxLength = 8
        Me.txtNoAsoc.Name = "txtNoAsoc"
        Me.txtNoAsoc.ReadOnly = True
        Me.txtNoAsoc.Size = New System.Drawing.Size(134, 23)
        Me.txtNoAsoc.TabIndex = 116
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BackColor = System.Drawing.Color.White
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.Location = New System.Drawing.Point(125, 102)
        Me.txtCodPrestamo.MaxLength = 8
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.ReadOnly = True
        Me.txtCodPrestamo.Size = New System.Drawing.Size(134, 23)
        Me.txtCodPrestamo.TabIndex = 115
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCredito.Location = New System.Drawing.Point(355, 62)
        Me.txtTipoCredito.MaxLength = 8
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.ReadOnly = True
        Me.txtTipoCredito.Size = New System.Drawing.Size(406, 23)
        Me.txtTipoCredito.TabIndex = 113
        '
        'txtTasaInteres
        '
        Me.txtTasaInteres.BackColor = System.Drawing.Color.White
        Me.txtTasaInteres.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaInteres.Location = New System.Drawing.Point(173, 210)
        Me.txtTasaInteres.MaxLength = 10
        Me.txtTasaInteres.Name = "txtTasaInteres"
        Me.txtTasaInteres.ReadOnly = True
        Me.txtTasaInteres.Size = New System.Drawing.Size(144, 23)
        Me.txtTasaInteres.TabIndex = 3
        Me.ttipAsoc.SetToolTip(Me.txtTasaInteres, "Este código se digita si no se encuentra en la Base de Datos.")
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(19, 210)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(106, 18)
        Me.Label48.TabIndex = 112
        Me.Label48.Text = "Tasa de Interés:"
        '
        'txtNoActa
        '
        Me.txtNoActa.BackColor = System.Drawing.Color.White
        Me.txtNoActa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActa.Location = New System.Drawing.Point(173, 238)
        Me.txtNoActa.MaxLength = 50
        Me.txtNoActa.Name = "txtNoActa"
        Me.txtNoActa.ReadOnly = True
        Me.txtNoActa.Size = New System.Drawing.Size(144, 23)
        Me.txtNoActa.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(19, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 18)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "No. Acta Otorgamiento:"
        '
        'txtPlazo
        '
        Me.txtPlazo.BackColor = System.Drawing.Color.White
        Me.txtPlazo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlazo.Location = New System.Drawing.Point(617, 239)
        Me.txtPlazo.MaxLength = 25
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.ReadOnly = True
        Me.txtPlazo.Size = New System.Drawing.Size(144, 23)
        Me.txtPlazo.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(439, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 18)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Plazo en Meses:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(19, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 18)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "DUI:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(281, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 37)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Tipo de Crédito:"
        '
        'txtNumSolicitud
        '
        Me.txtNumSolicitud.BackColor = System.Drawing.Color.White
        Me.txtNumSolicitud.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumSolicitud.Location = New System.Drawing.Point(626, 102)
        Me.txtNumSolicitud.MaxLength = 8
        Me.txtNumSolicitud.Name = "txtNumSolicitud"
        Me.txtNumSolicitud.ReadOnly = True
        Me.txtNumSolicitud.Size = New System.Drawing.Size(135, 23)
        Me.txtNumSolicitud.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "No. Asociado:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(509, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Num.Solicitud:"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(281, 102)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 36)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "Código " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anterior:"
        Me.Label18.Visible = False
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(19, 182)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(135, 19)
        Me.Label30.TabIndex = 84
        Me.Label30.Text = "Monto del Préstamo:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(19, 102)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(96, 36)
        Me.Label31.TabIndex = 79
        Me.Label31.Text = "Código Préstamo:"
        '
        'txtCodAnterior
        '
        Me.txtCodAnterior.BackColor = System.Drawing.Color.White
        Me.txtCodAnterior.Location = New System.Drawing.Point(355, 102)
        Me.txtCodAnterior.MaxLength = 25
        Me.txtCodAnterior.Name = "txtCodAnterior"
        Me.txtCodAnterior.ReadOnly = True
        Me.txtCodAnterior.Size = New System.Drawing.Size(129, 23)
        Me.txtCodAnterior.TabIndex = 1
        Me.txtCodAnterior.Visible = False
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(173, 182)
        Me.txtMonto.MaxLength = 20
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(144, 23)
        Me.txtMonto.TabIndex = 7
        '
        'tbTblAmort
        '
        Me.tbTblAmort.BackColor = System.Drawing.Color.White
        Me.tbTblAmort.Controls.Add(Me.MetroButton4)
        Me.tbTblAmort.Controls.Add(Me.btnSigTb2_1)
        Me.tbTblAmort.Controls.Add(Me.btAtrasTb2_1)
        Me.tbTblAmort.Controls.Add(Me.GroupBox3)
        Me.tbTblAmort.Location = New System.Drawing.Point(4, 25)
        Me.tbTblAmort.Name = "tbTblAmort"
        Me.tbTblAmort.Size = New System.Drawing.Size(788, 414)
        Me.tbTblAmort.TabIndex = 2
        Me.tbTblAmort.Text = "B - Tablas Amortización"
        Me.tbTblAmort.ToolTipText = "Tabla de Amortización vigente para Control del Préstamo"
        '
        'btnSigTb2_1
        '
        Me.btnSigTb2_1.Location = New System.Drawing.Point(688, 374)
        Me.btnSigTb2_1.Name = "btnSigTb2_1"
        Me.btnSigTb2_1.Size = New System.Drawing.Size(90, 32)
        Me.btnSigTb2_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTb2_1.TabIndex = 216
        Me.btnSigTb2_1.Text = "Siguiente"
        Me.btnSigTb2_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTb2_1.UseSelectable = True
        Me.btnSigTb2_1.UseStyleColors = True
        '
        'btAtrasTb2_1
        '
        Me.btAtrasTb2_1.Location = New System.Drawing.Point(590, 374)
        Me.btAtrasTb2_1.Name = "btAtrasTb2_1"
        Me.btAtrasTb2_1.Size = New System.Drawing.Size(90, 32)
        Me.btAtrasTb2_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btAtrasTb2_1.TabIndex = 215
        Me.btAtrasTb2_1.Text = "Atras"
        Me.btAtrasTb2_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btAtrasTb2_1.UseSelectable = True
        Me.btAtrasTb2_1.UseStyleColors = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtFechayHora)
        Me.GroupBox3.Controls.Add(Me.txtUsuario)
        Me.GroupBox3.Controls.Add(Me.btnAsinaTA1)
        Me.GroupBox3.Controls.Add(Me.btnCargarTabla1)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.txtInteresPagado)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtFechaUltimoPago)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.chkGeneraReserva)
        Me.GroupBox3.Controls.Add(Me.txtSaldo)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtCuota)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.C1fgrdDetalleTA)
        Me.GroupBox3.Controls.Add(Me.txtCodTablaAmortiza)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(768, 363)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tablas de Amortización"
        '
        'txtFechayHora
        '
        Me.txtFechayHora.BackColor = System.Drawing.Color.White
        Me.txtFechayHora.Location = New System.Drawing.Point(566, 46)
        Me.txtFechayHora.Name = "txtFechayHora"
        Me.txtFechayHora.ReadOnly = True
        Me.txtFechayHora.Size = New System.Drawing.Size(190, 23)
        Me.txtFechayHora.TabIndex = 145
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(173, 44)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(288, 23)
        Me.txtUsuario.TabIndex = 144
        '
        'btnAsinaTA1
        '
        Me.btnAsinaTA1.Location = New System.Drawing.Point(605, 320)
        Me.btnAsinaTA1.Name = "btnAsinaTA1"
        Me.btnAsinaTA1.Size = New System.Drawing.Size(151, 32)
        Me.btnAsinaTA1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAsinaTA1.TabIndex = 213
        Me.btnAsinaTA1.Text = "Nueva Tabla"
        Me.btnAsinaTA1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAsinaTA1.UseSelectable = True
        Me.btnAsinaTA1.UseStyleColors = True
        '
        'btnCargarTabla1
        '
        Me.btnCargarTabla1.Location = New System.Drawing.Point(407, 320)
        Me.btnCargarTabla1.Name = "btnCargarTabla1"
        Me.btnCargarTabla1.Size = New System.Drawing.Size(191, 32)
        Me.btnCargarTabla1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCargarTabla1.TabIndex = 214
        Me.btnCargarTabla1.Text = "Importar Tabla"
        Me.btnCargarTabla1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCargarTabla1.UseSelectable = True
        Me.btnCargarTabla1.UseStyleColors = True
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(468, 36)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(109, 33)
        Me.Label28.TabIndex = 143
        Me.Label28.Text = "Fecha y Hora " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Creación:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(7, 43)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(173, 18)
        Me.Label27.TabIndex = 142
        Me.Label27.Text = "Usuario que creó la Tabla:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtInteresPagado
        '
        Me.txtInteresPagado.BackColor = System.Drawing.Color.White
        Me.txtInteresPagado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInteresPagado.Location = New System.Drawing.Point(127, 323)
        Me.txtInteresPagado.MaxLength = 8
        Me.txtInteresPagado.Name = "txtInteresPagado"
        Me.txtInteresPagado.ReadOnly = True
        Me.txtInteresPagado.Size = New System.Drawing.Size(119, 23)
        Me.txtInteresPagado.TabIndex = 140
        Me.txtInteresPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(5, 323)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 19)
        Me.Label20.TabIndex = 141
        Me.Label20.Text = "Interés Pagado:"
        '
        'txtFechaUltimoPago
        '
        Me.txtFechaUltimoPago.BackColor = System.Drawing.Color.White
        Me.txtFechaUltimoPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaUltimoPago.Location = New System.Drawing.Point(127, 293)
        Me.txtFechaUltimoPago.MaxLength = 8
        Me.txtFechaUltimoPago.Name = "txtFechaUltimoPago"
        Me.txtFechaUltimoPago.ReadOnly = True
        Me.txtFechaUltimoPago.Size = New System.Drawing.Size(119, 23)
        Me.txtFechaUltimoPago.TabIndex = 138
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(4, 293)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 19)
        Me.Label19.TabIndex = 139
        Me.Label19.Text = "Fecha último Pago:"
        '
        'chkGeneraReserva
        '
        Me.chkGeneraReserva.Enabled = False
        Me.chkGeneraReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkGeneraReserva.ForeColor = System.Drawing.Color.Black
        Me.chkGeneraReserva.Location = New System.Drawing.Point(472, 12)
        Me.chkGeneraReserva.Name = "chkGeneraReserva"
        Me.chkGeneraReserva.Size = New System.Drawing.Size(134, 27)
        Me.chkGeneraReserva.TabIndex = 137
        Me.chkGeneraReserva.Text = "Genera Reserva"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(510, 288)
        Me.txtSaldo.MaxLength = 8
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(119, 23)
        Me.txtSaldo.TabIndex = 135
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(455, 293)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 19)
        Me.Label17.TabIndex = 136
        Me.Label17.Text = "Saldo:"
        '
        'txtCuota
        '
        Me.txtCuota.BackColor = System.Drawing.Color.White
        Me.txtCuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuota.Location = New System.Drawing.Point(342, 290)
        Me.txtCuota.MaxLength = 8
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.ReadOnly = True
        Me.txtCuota.Size = New System.Drawing.Size(106, 23)
        Me.txtCuota.TabIndex = 133
        Me.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(253, 293)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 19)
        Me.Label16.TabIndex = 134
        Me.Label16.Text = "Cuota total:"
        '
        'C1fgrdDetalleTA
        '
        Me.C1fgrdDetalleTA.AllowEditing = False
        Me.C1fgrdDetalleTA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdDetalleTA.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdDetalleTA.BackColor = System.Drawing.Color.White
        Me.C1fgrdDetalleTA.ColumnInfo = resources.GetString("C1fgrdDetalleTA.ColumnInfo")
        Me.C1fgrdDetalleTA.ForeColor = System.Drawing.Color.Teal
        Me.C1fgrdDetalleTA.Location = New System.Drawing.Point(7, 76)
        Me.C1fgrdDetalleTA.Name = "C1fgrdDetalleTA"
        Me.C1fgrdDetalleTA.Rows.DefaultSize = 22
        Me.C1fgrdDetalleTA.Size = New System.Drawing.Size(749, 207)
        Me.C1fgrdDetalleTA.StyleInfo = resources.GetString("C1fgrdDetalleTA.StyleInfo")
        Me.C1fgrdDetalleTA.TabIndex = 128
        '
        'txtCodTablaAmortiza
        '
        Me.txtCodTablaAmortiza.BackColor = System.Drawing.Color.White
        Me.txtCodTablaAmortiza.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTablaAmortiza.Location = New System.Drawing.Point(253, 14)
        Me.txtCodTablaAmortiza.MaxLength = 25
        Me.txtCodTablaAmortiza.Name = "txtCodTablaAmortiza"
        Me.txtCodTablaAmortiza.ReadOnly = True
        Me.txtCodTablaAmortiza.Size = New System.Drawing.Size(208, 23)
        Me.txtCodTablaAmortiza.TabIndex = 125
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(239, 16)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "Código Tabla Amortización Asignada:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'tbSaldos
        '
        Me.tbSaldos.BackColor = System.Drawing.Color.White
        Me.tbSaldos.Controls.Add(Me.MetroButton1)
        Me.tbSaldos.Controls.Add(Me.MetroButton2)
        Me.tbSaldos.Controls.Add(Me.GroupBox1)
        Me.tbSaldos.Location = New System.Drawing.Point(4, 25)
        Me.tbSaldos.Name = "tbSaldos"
        Me.tbSaldos.Size = New System.Drawing.Size(788, 414)
        Me.tbSaldos.TabIndex = 3
        Me.tbSaldos.Text = "C - Consulta Saldos al Día"
        Me.tbSaldos.ToolTipText = "Consulta de Saldos al Día del Préstamo"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(688, 373)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 218
        Me.MetroButton1.Text = "Siguiente"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(590, 373)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 217
        Me.MetroButton2.Text = "Atras"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.C1fgrdProv)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 364)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Últimas Ciento Veinte Provisiones"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtSaldoDiaAportacion)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtSaldoDiaComision)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtSaldoDiaSegDanios)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtSaldoDiaAhorro)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.txtSaldoDiaSegDeuda)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtSaldoDiaInteresMora)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtSaldoDiaCapitalMora)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtSaldoDiaInteres)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 102)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldos al Día"
        '
        'txtSaldoDiaAportacion
        '
        Me.txtSaldoDiaAportacion.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaAportacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaAportacion.Location = New System.Drawing.Point(643, 65)
        Me.txtSaldoDiaAportacion.MaxLength = 8
        Me.txtSaldoDiaAportacion.Name = "txtSaldoDiaAportacion"
        Me.txtSaldoDiaAportacion.ReadOnly = True
        Me.txtSaldoDiaAportacion.Size = New System.Drawing.Size(87, 23)
        Me.txtSaldoDiaAportacion.TabIndex = 163
        Me.txtSaldoDiaAportacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(566, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 18)
        Me.Label15.TabIndex = 162
        Me.Label15.Text = "Aportación:"
        '
        'txtSaldoDiaComision
        '
        Me.txtSaldoDiaComision.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaComision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaComision.Location = New System.Drawing.Point(461, 65)
        Me.txtSaldoDiaComision.MaxLength = 8
        Me.txtSaldoDiaComision.Name = "txtSaldoDiaComision"
        Me.txtSaldoDiaComision.ReadOnly = True
        Me.txtSaldoDiaComision.Size = New System.Drawing.Size(86, 23)
        Me.txtSaldoDiaComision.TabIndex = 160
        Me.txtSaldoDiaComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(346, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(134, 18)
        Me.Label22.TabIndex = 161
        Me.Label22.Text = "Comisión Manejo:"
        '
        'txtSaldoDiaSegDanios
        '
        Me.txtSaldoDiaSegDanios.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaSegDanios.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaSegDanios.Location = New System.Drawing.Point(240, 65)
        Me.txtSaldoDiaSegDanios.MaxLength = 8
        Me.txtSaldoDiaSegDanios.Name = "txtSaldoDiaSegDanios"
        Me.txtSaldoDiaSegDanios.ReadOnly = True
        Me.txtSaldoDiaSegDanios.Size = New System.Drawing.Size(86, 23)
        Me.txtSaldoDiaSegDanios.TabIndex = 158
        Me.txtSaldoDiaSegDanios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(154, 67)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 18)
        Me.Label24.TabIndex = 159
        Me.Label24.Text = "Seg.Daños:"
        '
        'txtSaldoDiaAhorro
        '
        Me.txtSaldoDiaAhorro.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaAhorro.Location = New System.Drawing.Point(58, 65)
        Me.txtSaldoDiaAhorro.MaxLength = 8
        Me.txtSaldoDiaAhorro.Name = "txtSaldoDiaAhorro"
        Me.txtSaldoDiaAhorro.ReadOnly = True
        Me.txtSaldoDiaAhorro.Size = New System.Drawing.Size(86, 23)
        Me.txtSaldoDiaAhorro.TabIndex = 156
        Me.txtSaldoDiaAhorro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(10, 67)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 18)
        Me.Label26.TabIndex = 157
        Me.Label26.Text = "Ahorro:"
        '
        'txtSaldoDiaSegDeuda
        '
        Me.txtSaldoDiaSegDeuda.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaSegDeuda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaSegDeuda.Location = New System.Drawing.Point(643, 25)
        Me.txtSaldoDiaSegDeuda.MaxLength = 8
        Me.txtSaldoDiaSegDeuda.Name = "txtSaldoDiaSegDeuda"
        Me.txtSaldoDiaSegDeuda.ReadOnly = True
        Me.txtSaldoDiaSegDeuda.Size = New System.Drawing.Size(87, 23)
        Me.txtSaldoDiaSegDeuda.TabIndex = 155
        Me.txtSaldoDiaSegDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(566, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 18)
        Me.Label14.TabIndex = 154
        Me.Label14.Text = "Seg. Deuda:"
        '
        'txtSaldoDiaInteresMora
        '
        Me.txtSaldoDiaInteresMora.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaInteresMora.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaInteresMora.Location = New System.Drawing.Point(461, 25)
        Me.txtSaldoDiaInteresMora.MaxLength = 8
        Me.txtSaldoDiaInteresMora.Name = "txtSaldoDiaInteresMora"
        Me.txtSaldoDiaInteresMora.ReadOnly = True
        Me.txtSaldoDiaInteresMora.Size = New System.Drawing.Size(86, 23)
        Me.txtSaldoDiaInteresMora.TabIndex = 152
        Me.txtSaldoDiaInteresMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(346, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 18)
        Me.Label21.TabIndex = 153
        Me.Label21.Text = "Interés Moratorio:"
        '
        'txtSaldoDiaCapitalMora
        '
        Me.txtSaldoDiaCapitalMora.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaCapitalMora.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaCapitalMora.Location = New System.Drawing.Point(240, 25)
        Me.txtSaldoDiaCapitalMora.MaxLength = 8
        Me.txtSaldoDiaCapitalMora.Name = "txtSaldoDiaCapitalMora"
        Me.txtSaldoDiaCapitalMora.ReadOnly = True
        Me.txtSaldoDiaCapitalMora.Size = New System.Drawing.Size(86, 23)
        Me.txtSaldoDiaCapitalMora.TabIndex = 148
        Me.txtSaldoDiaCapitalMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(154, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 18)
        Me.Label23.TabIndex = 149
        Me.Label23.Text = "Capital Mora:"
        '
        'txtSaldoDiaInteres
        '
        Me.txtSaldoDiaInteres.BackColor = System.Drawing.Color.White
        Me.txtSaldoDiaInteres.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoDiaInteres.Location = New System.Drawing.Point(58, 25)
        Me.txtSaldoDiaInteres.MaxLength = 8
        Me.txtSaldoDiaInteres.Name = "txtSaldoDiaInteres"
        Me.txtSaldoDiaInteres.ReadOnly = True
        Me.txtSaldoDiaInteres.Size = New System.Drawing.Size(86, 23)
        Me.txtSaldoDiaInteres.TabIndex = 144
        Me.txtSaldoDiaInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(10, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 18)
        Me.Label25.TabIndex = 145
        Me.Label25.Text = "Interés:"
        '
        'C1fgrdProv
        '
        Me.C1fgrdProv.AllowEditing = False
        Me.C1fgrdProv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdProv.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdProv.BackColor = System.Drawing.Color.White
        Me.C1fgrdProv.ColumnInfo = resources.GetString("C1fgrdProv.ColumnInfo")
        Me.C1fgrdProv.ForeColor = System.Drawing.Color.Teal
        Me.C1fgrdProv.Location = New System.Drawing.Point(10, 18)
        Me.C1fgrdProv.Name = "C1fgrdProv"
        Me.C1fgrdProv.Rows.DefaultSize = 22
        Me.C1fgrdProv.Size = New System.Drawing.Size(748, 235)
        Me.C1fgrdProv.StyleInfo = resources.GetString("C1fgrdProv.StyleInfo")
        Me.C1fgrdProv.TabIndex = 128
        '
        'tbHistorial
        '
        Me.tbHistorial.BackColor = System.Drawing.Color.White
        Me.tbHistorial.Controls.Add(Me.GroupBox8)
        Me.tbHistorial.Controls.Add(Me.GroupBox7)
        Me.tbHistorial.Location = New System.Drawing.Point(4, 25)
        Me.tbHistorial.Name = "tbHistorial"
        Me.tbHistorial.Size = New System.Drawing.Size(788, 414)
        Me.tbHistorial.TabIndex = 5
        Me.tbHistorial.Text = "D - Historial Tablas Amortización"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.fgDetalleHistorial)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(10, 197)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(768, 209)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        '
        'fgDetalleHistorial
        '
        Me.fgDetalleHistorial.AllowEditing = False
        Me.fgDetalleHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgDetalleHistorial.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.fgDetalleHistorial.BackColor = System.Drawing.Color.White
        Me.fgDetalleHistorial.ColumnInfo = resources.GetString("fgDetalleHistorial.ColumnInfo")
        Me.fgDetalleHistorial.Location = New System.Drawing.Point(10, 18)
        Me.fgDetalleHistorial.Name = "fgDetalleHistorial"
        Me.fgDetalleHistorial.Rows.Count = 2
        Me.fgDetalleHistorial.Rows.DefaultSize = 21
        Me.fgDetalleHistorial.Size = New System.Drawing.Size(748, 182)
        Me.fgDetalleHistorial.StyleInfo = resources.GetString("fgDetalleHistorial.StyleInfo")
        Me.fgDetalleHistorial.TabIndex = 129
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.fgHistorial)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox7.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(768, 181)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Seleccione un registro del historial para ver el detalle en la cuadrícula de abaj" &
    "o:"
        '
        'fgHistorial
        '
        Me.fgHistorial.AllowEditing = False
        Me.fgHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgHistorial.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.fgHistorial.BackColor = System.Drawing.Color.White
        Me.fgHistorial.ColumnInfo = resources.GetString("fgHistorial.ColumnInfo")
        Me.fgHistorial.Location = New System.Drawing.Point(10, 18)
        Me.fgHistorial.Name = "fgHistorial"
        Me.fgHistorial.Rows.Count = 2
        Me.fgHistorial.Rows.DefaultSize = 21
        Me.fgHistorial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.fgHistorial.Size = New System.Drawing.Size(748, 154)
        Me.fgHistorial.StyleInfo = resources.GetString("fgHistorial.StyleInfo")
        Me.fgHistorial.TabIndex = 129
        '
        'tbGarantias
        '
        Me.tbGarantias.BackColor = System.Drawing.Color.White
        Me.tbGarantias.Controls.Add(Me.MetroButton3)
        Me.tbGarantias.Controls.Add(Me.GroupBox6)
        Me.tbGarantias.Controls.Add(Me.GroupBox5)
        Me.tbGarantias.Controls.Add(Me.GroupBox4)
        Me.tbGarantias.Location = New System.Drawing.Point(4, 25)
        Me.tbGarantias.Name = "tbGarantias"
        Me.tbGarantias.Size = New System.Drawing.Size(788, 414)
        Me.tbGarantias.TabIndex = 4
        Me.tbGarantias.Text = "E - Garantías"
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(688, 374)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 218
        Me.MetroButton3.Text = "Atras"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.btEditCd1)
        Me.GroupBox6.Controls.Add(Me.btDelCd1)
        Me.GroupBox6.Controls.Add(Me.btNewCd1)
        Me.GroupBox6.Controls.Add(Me.fgCd)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox6.Location = New System.Drawing.Point(10, 248)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(768, 120)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Codeudores"
        '
        'btEditCd1
        '
        Me.btEditCd1.Location = New System.Drawing.Point(104, 15)
        Me.btEditCd1.Name = "btEditCd1"
        Me.btEditCd1.Size = New System.Drawing.Size(90, 23)
        Me.btEditCd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditCd1.TabIndex = 208
        Me.btEditCd1.Text = "Modificar"
        Me.btEditCd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditCd1.UseSelectable = True
        Me.btEditCd1.UseStyleColors = True
        '
        'btDelCd1
        '
        Me.btDelCd1.Location = New System.Drawing.Point(202, 15)
        Me.btDelCd1.Name = "btDelCd1"
        Me.btDelCd1.Size = New System.Drawing.Size(90, 23)
        Me.btDelCd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelCd1.TabIndex = 207
        Me.btDelCd1.Text = "Eliminar"
        Me.btDelCd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelCd1.UseSelectable = True
        Me.btDelCd1.UseStyleColors = True
        '
        'btNewCd1
        '
        Me.btNewCd1.Location = New System.Drawing.Point(7, 15)
        Me.btNewCd1.Name = "btNewCd1"
        Me.btNewCd1.Size = New System.Drawing.Size(90, 23)
        Me.btNewCd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewCd1.TabIndex = 206
        Me.btNewCd1.Text = "Agregar"
        Me.btNewCd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewCd1.UseSelectable = True
        Me.btNewCd1.UseStyleColors = True
        '
        'fgCd
        '
        Me.fgCd.AllowEditing = False
        Me.fgCd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgCd.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgCd.ForeColor = System.Drawing.Color.Teal
        Me.fgCd.Location = New System.Drawing.Point(10, 45)
        Me.fgCd.Name = "fgCd"
        Me.fgCd.Rows.Count = 1
        Me.fgCd.Rows.DefaultSize = 22
        Me.fgCd.Size = New System.Drawing.Size(748, 68)
        Me.fgCd.StyleInfo = resources.GetString("fgCd.StyleInfo")
        Me.fgCd.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.btEditFd1)
        Me.GroupBox5.Controls.Add(Me.btDelFd1)
        Me.GroupBox5.Controls.Add(Me.btNewFd1)
        Me.GroupBox5.Controls.Add(Me.fgFd)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox5.Location = New System.Drawing.Point(10, 128)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(768, 120)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fiadores"
        '
        'btEditFd1
        '
        Me.btEditFd1.Location = New System.Drawing.Point(107, 15)
        Me.btEditFd1.Name = "btEditFd1"
        Me.btEditFd1.Size = New System.Drawing.Size(90, 23)
        Me.btEditFd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditFd1.TabIndex = 208
        Me.btEditFd1.Text = "Modificar"
        Me.btEditFd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditFd1.UseSelectable = True
        Me.btEditFd1.UseStyleColors = True
        '
        'btDelFd1
        '
        Me.btDelFd1.Location = New System.Drawing.Point(204, 15)
        Me.btDelFd1.Name = "btDelFd1"
        Me.btDelFd1.Size = New System.Drawing.Size(90, 23)
        Me.btDelFd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelFd1.TabIndex = 207
        Me.btDelFd1.Text = "Eliminar"
        Me.btDelFd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelFd1.UseSelectable = True
        Me.btDelFd1.UseStyleColors = True
        '
        'btNewFd1
        '
        Me.btNewFd1.Location = New System.Drawing.Point(10, 15)
        Me.btNewFd1.Name = "btNewFd1"
        Me.btNewFd1.Size = New System.Drawing.Size(90, 23)
        Me.btNewFd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewFd1.TabIndex = 206
        Me.btNewFd1.Text = "Agregar"
        Me.btNewFd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewFd1.UseSelectable = True
        Me.btNewFd1.UseStyleColors = True
        '
        'fgFd
        '
        Me.fgFd.AllowEditing = False
        Me.fgFd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgFd.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgFd.ForeColor = System.Drawing.Color.Teal
        Me.fgFd.Location = New System.Drawing.Point(10, 45)
        Me.fgFd.Name = "fgFd"
        Me.fgFd.Rows.Count = 1
        Me.fgFd.Rows.DefaultSize = 22
        Me.fgFd.Size = New System.Drawing.Size(748, 68)
        Me.fgFd.StyleInfo = resources.GetString("fgFd.StyleInfo")
        Me.fgFd.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.btConsultaGarantiasInt1)
        Me.GroupBox4.Controls.Add(Me.btEditGr1)
        Me.GroupBox4.Controls.Add(Me.btDelGr1)
        Me.GroupBox4.Controls.Add(Me.btNewGr1)
        Me.GroupBox4.Controls.Add(Me.fgGr)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(768, 130)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Garantías"
        '
        'btConsultaGarantiasInt1
        '
        Me.btConsultaGarantiasInt1.Location = New System.Drawing.Point(301, 15)
        Me.btConsultaGarantiasInt1.Name = "btConsultaGarantiasInt1"
        Me.btConsultaGarantiasInt1.Size = New System.Drawing.Size(141, 23)
        Me.btConsultaGarantiasInt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btConsultaGarantiasInt1.TabIndex = 209
        Me.btConsultaGarantiasInt1.Text = "Grantías Internas"
        Me.btConsultaGarantiasInt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btConsultaGarantiasInt1.UseSelectable = True
        Me.btConsultaGarantiasInt1.UseStyleColors = True
        '
        'btEditGr1
        '
        Me.btEditGr1.Location = New System.Drawing.Point(107, 15)
        Me.btEditGr1.Name = "btEditGr1"
        Me.btEditGr1.Size = New System.Drawing.Size(90, 23)
        Me.btEditGr1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditGr1.TabIndex = 208
        Me.btEditGr1.Text = "Modificar"
        Me.btEditGr1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditGr1.UseSelectable = True
        Me.btEditGr1.UseStyleColors = True
        '
        'btDelGr1
        '
        Me.btDelGr1.Location = New System.Drawing.Point(204, 15)
        Me.btDelGr1.Name = "btDelGr1"
        Me.btDelGr1.Size = New System.Drawing.Size(90, 23)
        Me.btDelGr1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelGr1.TabIndex = 207
        Me.btDelGr1.Text = "Eliminar"
        Me.btDelGr1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDelGr1.UseSelectable = True
        Me.btDelGr1.UseStyleColors = True
        '
        'btNewGr1
        '
        Me.btNewGr1.Location = New System.Drawing.Point(10, 15)
        Me.btNewGr1.Name = "btNewGr1"
        Me.btNewGr1.Size = New System.Drawing.Size(90, 23)
        Me.btNewGr1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewGr1.TabIndex = 206
        Me.btNewGr1.Text = "Agregar"
        Me.btNewGr1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNewGr1.UseSelectable = True
        Me.btNewGr1.UseStyleColors = True
        '
        'fgGr
        '
        Me.fgGr.AllowEditing = False
        Me.fgGr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgGr.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgGr.ForeColor = System.Drawing.Color.Teal
        Me.fgGr.Location = New System.Drawing.Point(10, 45)
        Me.fgGr.Name = "fgGr"
        Me.fgGr.Rows.Count = 1
        Me.fgGr.Rows.DefaultSize = 22
        Me.fgGr.Size = New System.Drawing.Size(748, 72)
        Me.fgGr.StyleInfo = resources.GetString("fgGr.StyleInfo")
        Me.fgGr.TabIndex = 4
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(384, 374)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(200, 32)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton4.TabIndex = 217
        Me.MetroButton4.Text = "Imprimir Tabla de Amortización"
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'frmMsCRDetPrestamo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(839, 556)
        Me.Controls.Add(Me.tb)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCRDetPrestamo"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Préstamo"
        Me.tb.ResumeLayout(False)
        Me.tbDatGral.ResumeLayout(False)
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbTblAmort.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.C1fgrdDetalleTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbSaldos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1fgrdProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbHistorial.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.fgDetalleHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.fgHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbGarantias.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.fgCd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.fgFd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.fgGr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declaraciones"
    Private vIdPrestamo As String, pCodEnlace As Long
#End Region

#Region "Propiedades"
    Public Property IdPrestamo() As String
        Get
            Return vIdPrestamo
        End Get
        Set(ByVal Value As String)
            vIdPrestamo = Value
        End Set
    End Property
#End Region

#Region "Métodos"

#Region "Métodos de Navegación"



    Private Sub btnAtrasTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub



#End Region


#End Region



    Private Sub frmMsCRDetPrestamo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oPrest As New wrPrestamo.wsLibPrest, oCred As New wrCredito.wsLibCred
        Dim ds As New DataSet("Prestamo"), dr As DataRow ', drTbAm As DataRow
        Dim ds2 As New DataSet
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred
        'Dim pNumSolicitud As String
        Try
            ds = oPrest.CargaDatosPrestamo(Me.IdPrestamo, sUsuario, sPassword, sSucursal)
            If ds.Tables("Prestamo").Rows.Count <= 0 Then Exit Sub
            dr = ds.Tables("Prestamo").Rows(0)

            Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
            Me.txtCodAnterior.Text = IIf(IsDBNull(dr("CodAnteriorPrestamo")), 0, dr("CodAnteriorPrestamo"))
            Me.txtNumSolicitud.Text = IIf(IsDBNull(dr("NumSolicitud")), 0, dr("NumSolicitud"))
            Me.txtTipoCredito.Text = IIf(IsDBNull(dr("TipoCredito")), " ", dr("TipoCredito"))
            Me.txtNoAsoc.Text = IIf(IsDBNull(dr("NoSocio")), " ", dr("NoSocio"))
            Me.txtDui.ReadOnly = False
            Me.txtDui.Value = IIf(IsDBNull(dr("DUI")), " ", dr("DUI"))
            Me.txtDui.ReadOnly = True
            Me.txtNombre.Text = IIf(IsDBNull(dr("Nombre")), " ", dr("Nombre"))
            Me.txtMonto.Text = IIf(IsDBNull(dr("Monto")), 0, dr("Monto"))
            Me.txtMontoGarantia.Text = IIf(IsDBNull(dr("Monto_Garantia")), 0, dr("Monto_Garantia"))
            Me.txtTasaInteres.Text = IIf(IsDBNull(dr("Tasa_Interes")), 0, dr("Tasa_Interes"))
            Me.txtTasaInteresMora.Text = IIf(IsDBNull(dr("Tasa_Interes_Mora")), 0, dr("Tasa_Interes_Mora"))
            Me.txtNoActa.Text = IIf(IsDBNull(dr("NoActa")), " ", dr("NoActa"))
            Me.txtPlazo.Text = IIf(IsDBNull(dr("PlazoMeses")), 0, dr("PlazoMeses"))
            If Not IsDBNull(dr("FechaPrimeraCuota")) Then
                Me.txtFechaPrimeraCuota.Text = dr("FechaPrimeraCuota")
            End If
            If Not IsDBNull(dr("FechaOtorgamiento")) Then
                Me.txtFechaOtorgamiento.Text = dr("FechaOtorgamiento")
            End If
            Me.txtCategoria.Text = IIf(IsDBNull(dr("Categoria")), " ", dr("Categoria"))
            If Not IsDBNull(dr("Fechavencimiento")) Then
                Me.txtFechaVencimiento.Text = dr("FechaVencimiento")
            End If
            Me.txtCodTablaAmortiza.Text = IIf(IsDBNull(dr("CodTablaAmortiza")), " ", dr("CodTablaAmortiza"))
            If IIf(IsDBNull(dr("GeneraReserva")) = True, 0, dr("GeneraReserva")) = 1 Then
                Me.chkGeneraReserva.Checked = True
            Else
                Me.chkGeneraReserva.Checked = False
            End If
            If Not IsDBNull(dr("FechaultimoPago")) Then
                Me.txtFechaUltimoPago.Text = dr("FechaultimoPago")
            End If
            Me.txtSaldoDiaInteres.Text = Format(IIf(IsDBNull(dr("SaldoDia_Interes")), " ", dr("SaldoDia_Interes")), "###,##0.00")
            If IIf(IsDBNull(dr("DiaGracia")), "N", dr("DiaGracia")) = "S" Then
                Me.txtSaldoDiaCapitalMora.Text = Format(IIf(IsDBNull(dr("Saldo_CapMoraGracia")), " ", dr("Saldo_CapMoraGracia")), "###,##0.00")
                Me.txtSaldoDiaInteresMora.Text = Format(IIf(IsDBNull(dr("Saldo_IntMoraGracia")), " ", dr("Saldo_IntMoraGracia")), "###,##0.00")
            Else
                Me.txtSaldoDiaCapitalMora.Text = Format(IIf(IsDBNull(dr("SaldoDia_CapitalMora")), " ", dr("SaldoDia_CapitalMora")), "###,##0.00")
                Me.txtSaldoDiaInteresMora.Text = Format(IIf(IsDBNull(dr("SaldoDia_InteresMora")), " ", dr("SaldoDia_InteresMora")), "###,##0.00")
            End If
            Me.txtSaldoDiaSegDeuda.Text = Format(IIf(IsDBNull(dr("SaldoDia_SeguroDeuda")), " ", dr("SaldoDia_SeguroDeuda")), "###,##0.00")
            Me.txtSaldoDiaAhorro.Text = Format(IIf(IsDBNull(dr("SaldoDia_Ahorro")), " ", dr("SaldoDia_Ahorro")), "###,##0.00")
            Me.txtSaldoDiaSegDanios.Text = Format(IIf(IsDBNull(dr("SaldoDia_SeguroDaniosyLA")), " ", dr("SaldoDia_SeguroDaniosyLA")), "###,##0.00")
            Me.txtSaldoDiaComision.Text = Format(IIf(IsDBNull(dr("SaldoDia_ComisionManejo")), " ", dr("SaldoDia_ComisionManejo")), "###,##0.00")
            Me.txtSaldoDiaAportacion.Text = Format(IIf(IsDBNull(dr("SaldoDia_Aportacion")), " ", dr("SaldoDia_Aportacion")), "###,##0.00")
            Me.txtCuota.Text = Format(IIf(IsDBNull(dr("CuotaTotal")), 0, dr("CuotaTotal")), "###,##0.00")
            Me.txtSaldo.Text = Format(IIf(IsDBNull(dr("Saldo_Capital")), 0, dr("Saldo_Capital")), "###,##0.00")
            Me.txtInteresPagado.Text = Format(IIf(IsDBNull(dr("Intereses_Pagados")), 0, dr("Intereses_Pagados")), "###,##0.00")
            Me.C1fgrdDetalleTA.DataSource = ds.Tables("TablaAmortiza").DefaultView
            Me.C1fgrdProv.DataSource = ds.Tables("Provisiones").DefaultView
            ds2 = oPerif.ConsultarGarantias("*", "NumSolicitud=" & Me.txtNumSolicitud.Text & "", "CodGarantia", sUsuario, sPassword, sSucursal)
            Me.fgGr.DataSource = ds2.Tables(0)

            ds2 = oPerif.ConsultarDatGral("*", "NumSolicitud=" & Me.txtNumSolicitud.Text & " and Fiador='1'", "CodEnlace", sUsuario, sPassword, sSucursal)
            Me.fgFd.DataSource = ds2.Tables(0)

            ds2 = oPerif.ConsultarDatGral("*", "NumSolicitud=" & Me.txtNumSolicitud.Text & " and Fiador='2'", "CodEnlace", sUsuario, sPassword, sSucursal)
            Me.fgCd.DataSource = ds2.Tables(0)

            ds2 = oCred.ConsultarSolP2Credito("CodEnlace", "NumSolicitud='" & Me.txtNumSolicitud.Text.Trim & "'", "CodEnlace", sUsuario, sPassword, sSucursal)
            If ds2.Tables("CRSolP2Credito").Rows.Count > 0 Then
                dr = ds2.Tables("CRSolP2Credito").Rows(0)
                pCodEnlace = dr("CodEnlace")
            End If

            ds2 = oPrest.CargaHistorial_TablaAmortizacion(Me.IdPrestamo, sUsuario, sPassword, sSucursal)
            Me.fgHistorial.DataSource = ds2.Tables(0)

            If ds.Tables("DatosTabla").Rows.Count <= 0 Then Exit Sub
            dr = ds.Tables("DatosTabla").Rows(0)
            Me.txtUsuario.Text = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
            Me.txtFechayHora.Text = IIf(IsDBNull(dr("FechaCreacion")), "", dr("FechaCreacion"))

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub ActualizaGridGr()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGarantias("*", "NumSolicitud='" & Me.txtNumSolicitud.Text.Trim & "'", "CodGarantia", sUsuario, sPassword, sSucursal)

            Me.fgGr.DataSource = ds.Tables(0)
            Me.fgGr.Cols.Item(0).Caption = "Código"
            Me.fgGr.Cols.Item(1).Caption = "Descripción"
            Me.fgGr.Cols.Item(2).Caption = "No. Solicitud"
            Me.fgGr.Cols.Item(3).Caption = "Tipo Garantía"
            Me.fgGr.Cols.Item(4).Caption = "Cód. Enlace"
            Me.fgGr.Cols.Item(5).Caption = "No. Factura"
            Me.fgGr.Cols.Item(6).Caption = "No. Valúo"

            Me.fgGr.Cols.Item(0).Width = 77
            Me.fgGr.Cols.Item(1).Width = 150
            Me.fgGr.Cols.Item(2).Width = 77
            Me.fgGr.Cols.Item(3).Width = 77
            Me.fgGr.Cols.Item(4).Width = 77
            Me.fgGr.Cols.Item(5).Width = 77
            Me.fgGr.Cols.Item(6).Width = 77

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub ActualizaGridFd()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarDatGral("*", "NumSolicitud='" & Me.txtNumSolicitud.Text.Trim & "' and Fiador='1'", "CodEnlace", sUsuario, sPassword, sSucursal)

            Me.fgFd.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub ActualizaGridCd()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarDatGral("*", "NumSolicitud='" & Me.txtNumSolicitud.Text.Trim & "' and Fiador='2'", "CodEnlace", sUsuario, sPassword, sSucursal)

            Me.fgCd.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub fgHistorial_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgHistorial.DoubleClick
        Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
        ds = oPrest.CargaDetalleHistorial_TablaAmortizacion(Me.fgHistorial.Item(Me.fgHistorial.Row, "Codigo"), sUsuario, sPassword, sSucursal)
        Me.fgDetalleHistorial.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnSigTb1_1_Click(sender As Object, e As EventArgs) Handles btnSigTb1_1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub btAtrasTb2_1_Click(sender As Object, e As EventArgs) Handles btAtrasTb2_1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub btnSigTb2_1_Click(sender As Object, e As EventArgs) Handles btnSigTb2_1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub btnCargarTabla1_Click(sender As Object, e As EventArgs) Handles btnCargarTabla1.Click
        Try
            Dim ds As New DataSet, oPrest As New wrPrestamo.wsLibPrest, dr As DataRow, dv As New DataView
            ds = oPrest.CargaDatosPrestamo(Me.txtCodPrestamo.Text.Trim, sUsuario, sPassword, sSucursal)
            If ds.Tables("TablaAmortiza").Rows.Count > 0 Then 'Ya tiene asignada Tabla de Amortización
                Dim ofrmAut As New frmMsAutorizacion
                ofrmAut.TipoPermiso = "P"
                ofrmAut.NumPrograma = "CRY007"
                ofrmAut.ShowDialog()
                If ofrmAut.Autoriza = True Then
                    Dim frm As New frmCargaTablasAmortizacion
                    With frm
                        .lblAsociado.Text = txtNombre.Text.Trim
                        .txtTasa.Text = Me.txtTasaInteres.Text
                        .MontoCuotaTotal = Me.txtCuota.Text
                        .txtMonto.Text = txtMonto.Text
                        .TxtSaldo.Text = txtSaldo.Text
                        .dtpFechaOtor.Value = Me.txtFechaOtorgamiento.Text
                        .dtpFecVencimiento.Value = Me.txtFechaVencimiento.Text
                        .codPrest.Text = Me.txtCodPrestamo.Text.Trim
                        .ShowDialog()
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAsinaTA1_Click(sender As Object, e As EventArgs) Handles btnAsinaTA1.Click
        Try

            Dim ds As New DataSet, oPrest As New wrPrestamo.wsLibPrest, dr As DataRow, dv As New DataView
            ds = oPrest.CargaDatosPrestamo(Me.txtCodPrestamo.Text.Trim, sUsuario, sPassword, sSucursal)
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
                    ofrm.dtpFecha.Value = dv.Item(0)("FechaCuota")
                    ofrm.dtpFechaEmision.Value = Now
                    ofrm.CodPrestamo = Me.txtCodPrestamo.Text.Trim

                    ofrm.C1NEMonto.Value = dr("Saldo_Capital")
                    ofrm.C1NEMonto.Enabled = False

                    ofrm.C1NEInteres.Value = dr("Tasa_Interes")
                    ofrm.C1NENumPagos.Value = dr("PlazoMeses")
                    ofrm.C1NEMontoGarantia.Value = dr("Monto_Garantia")
                    ofrm.pNombre = CStr(txtNombre.Text)
                    ofrm.ShowDialog()
                    Me.frmMsCRDetPrestamo_Load(sender, e)
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
                ofrm.dtpFecha.Value = CDate(Me.txtFechaPrimeraCuota.Text)
                ofrm.dtpFechaEmision.Value = Now
                ofrm.CodPrestamo = Me.txtCodPrestamo.Text
                ofrm.pNombre = CStr(txtNombre.Text)

                'ofrm.C1NEMonto.Value = Double.Parse(Me.txtMonto.Text)
                ofrm.C1NEInteres.Value = Double.Parse(Me.txtTasaInteres.Text)
                ofrm.C1NENumPagos.Value = Integer.Parse(Me.txtPlazo.Text)
                ofrm.C1NEMontoGarantia.Value = Double.Parse(Me.txtMontoGarantia.Text)
                ofrm.ShowDialog()
                Me.frmMsCRDetPrestamo_Load(sender, e)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub btNewCd1_Click(sender As Object, e As EventArgs) Handles btNewCd1.Click
        Try
            Dim frm As frmMsCrFiadores = New frmMsCrFiadores
            frm.vFiador = 2
            frm.Text = "Mantenimiento de Codeudores"
            frm.pNumSolicitud = Me.txtNumSolicitud.Text.Trim
            frm.pAccion = "Guardar"
            frm.btnSaveTb1_1.Text = "&Guardar"
            frm.btnSaveTb2_1.Text = "&Guardar"
            frm.btnSaveTb3_1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridCd()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btEditCd1_Click(sender As Object, e As EventArgs) Handles btEditCd1.Click
        Try
            If Me.fgFd.Row <> -1 Then
                Dim frm As frmMsCrFiadores = New frmMsCrFiadores
                frm.vFiador = 2
                frm.Text = "Mantenimiento de Codeudores"
                frm.pNumSolicitud = Me.txtNumSolicitud.Text.Trim
                frm.pCodEnlace = Me.fgCd.Item(Me.fgCd.Row, "CodEnlace")
                frm.pAccion = "Modificar"
                frm.btnSaveTb1_1.Text = "&Modificar"
                frm.btnSaveTb2_1.Text = "&Modificar"
                frm.btnSaveTb3_1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridCd()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btDelCd1_Click(sender As Object, e As EventArgs) Handles btDelCd1.Click
        Try
            If Me.fgCd.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Codeudor " & Me.fgCd.Item(Me.fgCd.Row, "CodEnlace") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Codeudor") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarDatGral("" & Me.fgCd.Item(Me.fgCd.Row, "CodEnlace") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridCd()
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btNewFd1_Click(sender As Object, e As EventArgs) Handles btNewFd1.Click
        Try
            Dim frm As frmMsCrFiadores = New frmMsCrFiadores
            frm.vFiador = 1
            frm.pNumSolicitud = Me.txtNumSolicitud.Text.Trim
            frm.pAccion = "Guardar"
            frm.btnSaveTb1_1.Text = "&Guardar"
            frm.btnSaveTb2_1.Text = "&Guardar"
            frm.btnSaveTb3_1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridFd()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub btEditFd1_Click(sender As Object, e As EventArgs) Handles btEditFd1.Click
        Try
            If Me.fgFd.Row <> -1 Then
                Dim frm As frmMsCrFiadores = New frmMsCrFiadores
                frm.vFiador = 1
                frm.pNumSolicitud = Me.txtNumSolicitud.Text.Trim
                frm.pCodEnlace = Me.fgFd.Item(Me.fgFd.Row, "CodEnlace")
                frm.pAccion = "Modificar"
                frm.btnSaveTb1_1.Text = "&Modificar"
                frm.btnSaveTb2_1.Text = "&Modificar"
                frm.btnSaveTb3_1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridFd()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btDelFd1_Click(sender As Object, e As EventArgs) Handles btDelFd1.Click
        Try
            If Me.fgFd.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Fiador " & Me.fgFd.Item(Me.fgFd.Row, "CodEnlace") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Fiador") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarDatGral("" & Me.fgFd.Item(Me.fgFd.Row, "CodEnlace") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridFd()
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btNewGr1_Click(sender As Object, e As EventArgs) Handles btNewGr1.Click
        Try
            Dim frm As frmMsCrGarantias = New frmMsCrGarantias
            frm.pNoSolic = Me.txtNumSolicitud.Text.Trim
            frm.pCodEnlace = Me.pCodEnlace
            frm.pDui = Me.txtDui.Text.Trim
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridGr()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btEditGr1_Click(sender As Object, e As EventArgs) Handles btEditGr1.Click
        Try
            If Me.fgGr.Row <> -1 Then
                Dim frm As frmMsCrGarantias = New frmMsCrGarantias
                frm.pNoSolic = Me.txtNumSolicitud.Text.Trim
                frm.pCodEnlace = Me.pCodEnlace
                frm.pCodigo = Me.fgGr.Item(Me.fgGr.Row, "CodGarantia")
                frm.pDui = Me.txtDui.Text.Trim
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridGr()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btDelGr1_Click(sender As Object, e As EventArgs) Handles btDelGr1.Click
        Try
            If Me.fgGr.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Garantía " & Me.fgGr.Item(Me.fgGr.Row, "CodGarantia") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Garantía") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarGarantias("" & Me.fgGr.Item(Me.fgGr.Row, "CodGarantia") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridGr()
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Dim dsR As New DataSet, oAhorro As New wrCredito.wsLibCred

        Try
            dsR = oAhorro.TablaAmortizacion(txtCodPrestamo.Text.Trim, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(dsR, 34, 0)
            ofrm.TopMost = True
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btConsultaGarantiasInt1_Click(sender As Object, e As EventArgs) Handles btConsultaGarantiasInt1.Click
        Try
            Dim ofrm As New frmMsCrConsultaGarInt
            ofrm.NoSolicitud = Me.txtNumSolicitud.Text.Trim
            ofrm.NoSocio = Me.txtNoAsoc.Text
            ofrm.Dui = Me.txtDui.Value
            ofrm.Nombre = Me.txtNombre.Text.Trim
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class