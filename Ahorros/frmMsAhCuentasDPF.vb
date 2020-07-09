Public Class frmMsAhCuentasDPF
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim libAhorro As New sifLib.Ahorro.clsAhorros
    Friend WithEvents MetroButton9 As MetroFramework.Controls.MetroButton
    Dim asociados As New wrAsociados.wsLibAsoc
    Friend WithEvents MetroButton11 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtApe2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtApe1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombres As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNoSocio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDireccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpFecNac As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtApe3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbEstadoCivil As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSegApellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTitular2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbParentescoTitular2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbDoc As ComboBox
    Friend WithEvents txtPartida As C1.Win.C1Input.C1TextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbTipoAhorro As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel24 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel25 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaCapitalizacion As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpFecVenc As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpFechaRenovacion As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpFecIniApertura As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpFecCanc As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel33 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel32 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel29 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel28 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel27 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbNocuenta As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel38 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel37 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel36 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbSucursal As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel34 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbEjecutivo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel35 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btDelBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewBen As MetroFramework.Controls.MetroButton
    Friend WithEvents fgBen As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtestado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel39 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbFormaPagoInt As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel40 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton12 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton13 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents BtnCtaAhorro As MetroFramework.Controls.MetroButton
    Dim ahorro As New wrAhorro.wsLibAhorro
    Private PCtaTercero As Boolean


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents tbSolic As System.Windows.Forms.TabControl
    Friend WithEvents tbDatGral As System.Windows.Forms.TabPage
    Friend WithEvents tabDatGralII As System.Windows.Forms.TabPage
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents tbCertDPF As System.Windows.Forms.TabPage
    Friend WithEvents fgRep As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tbPigRen As System.Windows.Forms.TabPage
    Friend WithEvents fgPig As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents c1nCaja As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nRemesa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nRenovacion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nTransferencia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtObs As TextBox
    Friend WithEvents cbAutorizacion As ComboBox
    Friend WithEvents btEdit As Button
    Friend WithEvents txtNoCertificado As TextBox
    Friend WithEvents c1nTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nMontoApertura As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNoCuenta As TextBox
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNew As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSaveTb1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btTasaPactada As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnContrato As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton8 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton10 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhCuentasDPF))
        Me.tbSolic = New System.Windows.Forms.TabControl()
        Me.tbDatGral = New System.Windows.Forms.TabPage()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.cbParentescoTitular2 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtTitular2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.txtDireccion = New MetroFramework.Controls.MetroTextBox()
        Me.dtpFecNac = New MetroFramework.Controls.MetroDateTime()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.txtApe3 = New MetroFramework.Controls.MetroTextBox()
        Me.cbEstadoCivil = New MetroFramework.Controls.MetroComboBox()
        Me.txtSegApellido = New MetroFramework.Controls.MetroTextBox()
        Me.txtApe2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtApe1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombres = New MetroFramework.Controls.MetroTextBox()
        Me.txtNoSocio = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton9 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnCtaAhorro = New MetroFramework.Controls.MetroButton()
        Me.MetroButton13 = New MetroFramework.Controls.MetroButton()
        Me.dtpFechaCapitalizacion = New MetroFramework.Controls.MetroDateTime()
        Me.cbNocuenta = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel38 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel37 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton12 = New MetroFramework.Controls.MetroButton()
        Me.cbFormaPagoInt = New MetroFramework.Controls.MetroComboBox()
        Me.txtestado = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel39 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel36 = New MetroFramework.Controls.MetroLabel()
        Me.cbSucursal = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel34 = New MetroFramework.Controls.MetroLabel()
        Me.cbEjecutivo = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel35 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFecCanc = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel33 = New MetroFramework.Controls.MetroLabel()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.cbAutorizacion = New System.Windows.Forms.ComboBox()
        Me.MetroLabel32 = New MetroFramework.Controls.MetroLabel()
        Me.btTasaPactada = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel28 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel27 = New MetroFramework.Controls.MetroLabel()
        Me.c1nRemesa = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCaja = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.c1nRenovacion = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nTasa = New C1.Win.C1Input.C1NumericEdit()
        Me.dtpFecVenc = New MetroFramework.Controls.MetroDateTime()
        Me.dtpFechaRenovacion = New MetroFramework.Controls.MetroDateTime()
        Me.dtpFecIniApertura = New MetroFramework.Controls.MetroDateTime()
        Me.c1nTransferencia = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel24 = New MetroFramework.Controls.MetroLabel()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.txtNoCertificado = New System.Windows.Forms.TextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.cbTipoAhorro = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.c1nMontoApertura = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.btnSaveTb1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.c1nPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.tabDatGralII = New System.Windows.Forms.TabPage()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.btDelBen = New MetroFramework.Controls.MetroButton()
        Me.MetroButton11 = New MetroFramework.Controls.MetroButton()
        Me.btEditBen = New MetroFramework.Controls.MetroButton()
        Me.btnContrato = New MetroFramework.Controls.MetroButton()
        Me.btNewBen = New MetroFramework.Controls.MetroButton()
        Me.fgBen = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.MetroButton8 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton10 = New MetroFramework.Controls.MetroButton()
        Me.tbCertDPF = New System.Windows.Forms.TabPage()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.btnNew = New MetroFramework.Controls.MetroButton()
        Me.fgRep = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbPigRen = New System.Windows.Forms.TabPage()
        Me.MetroLabel40 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.fgPig = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtPartida = New C1.Win.C1Input.C1TextBox()
        Me.tbSolic.SuspendLayout()
        Me.tbDatGral.SuspendLayout()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.c1nRemesa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nRenovacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatGralII.SuspendLayout()
        CType(Me.fgBen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCertDPF.SuspendLayout()
        CType(Me.fgRep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbPigRen.SuspendLayout()
        CType(Me.fgPig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSolic
        '
        Me.tbSolic.Controls.Add(Me.tbDatGral)
        Me.tbSolic.Controls.Add(Me.TabPage1)
        Me.tbSolic.Controls.Add(Me.tabDatGralII)
        Me.tbSolic.Controls.Add(Me.tbCertDPF)
        Me.tbSolic.Controls.Add(Me.tbPigRen)
        Me.tbSolic.ItemSize = New System.Drawing.Size(300, 18)
        Me.tbSolic.Location = New System.Drawing.Point(28, 73)
        Me.tbSolic.Multiline = True
        Me.tbSolic.Name = "tbSolic"
        Me.tbSolic.SelectedIndex = 0
        Me.tbSolic.Size = New System.Drawing.Size(933, 639)
        Me.tbSolic.TabIndex = 0
        '
        'tbDatGral
        '
        Me.tbDatGral.BackColor = System.Drawing.Color.White
        Me.tbDatGral.Controls.Add(Me.MetroDateTime1)
        Me.tbDatGral.Controls.Add(Me.MetroLabel14)
        Me.tbDatGral.Controls.Add(Me.C1TextBox1)
        Me.tbDatGral.Controls.Add(Me.MetroLabel13)
        Me.tbDatGral.Controls.Add(Me.MetroLabel12)
        Me.tbDatGral.Controls.Add(Me.cbParentescoTitular2)
        Me.tbDatGral.Controls.Add(Me.MetroLabel11)
        Me.tbDatGral.Controls.Add(Me.txtTitular2)
        Me.tbDatGral.Controls.Add(Me.MetroLabel10)
        Me.tbDatGral.Controls.Add(Me.MetroLabel19)
        Me.tbDatGral.Controls.Add(Me.txtDireccion)
        Me.tbDatGral.Controls.Add(Me.dtpFecNac)
        Me.tbDatGral.Controls.Add(Me.cbDoc)
        Me.tbDatGral.Controls.Add(Me.txtApe3)
        Me.tbDatGral.Controls.Add(Me.cbEstadoCivil)
        Me.tbDatGral.Controls.Add(Me.txtSegApellido)
        Me.tbDatGral.Controls.Add(Me.txtApe2)
        Me.tbDatGral.Controls.Add(Me.txtApe1)
        Me.tbDatGral.Controls.Add(Me.txtNombres)
        Me.tbDatGral.Controls.Add(Me.txtNoSocio)
        Me.tbDatGral.Controls.Add(Me.MetroLabel9)
        Me.tbDatGral.Controls.Add(Me.MetroLabel8)
        Me.tbDatGral.Controls.Add(Me.MetroLabel7)
        Me.tbDatGral.Controls.Add(Me.MetroLabel6)
        Me.tbDatGral.Controls.Add(Me.MetroLabel5)
        Me.tbDatGral.Controls.Add(Me.MetroLabel4)
        Me.tbDatGral.Controls.Add(Me.MetroLabel3)
        Me.tbDatGral.Controls.Add(Me.MetroLabel2)
        Me.tbDatGral.Controls.Add(Me.MetroLabel1)
        Me.tbDatGral.Controls.Add(Me.MetroLabel18)
        Me.tbDatGral.Controls.Add(Me.MetroButton9)
        Me.tbDatGral.Controls.Add(Me.MetroButton7)
        Me.tbDatGral.Controls.Add(Me.txtDui)
        Me.tbDatGral.Location = New System.Drawing.Point(4, 22)
        Me.tbDatGral.Name = "tbDatGral"
        Me.tbDatGral.Size = New System.Drawing.Size(925, 613)
        Me.tbDatGral.TabIndex = 0
        Me.tbDatGral.Text = "Información Asociado"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Location = New System.Drawing.Point(134, 407)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(308, 30)
        Me.MetroDateTime1.TabIndex = 30
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(13, 407)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(124, 20)
        Me.MetroLabel14.TabIndex = 29
        Me.MetroLabel14.Text = "Fecha Nacimiento:"
        '
        'C1TextBox1
        '
        Me.C1TextBox1.AcceptsReturn = True
        Me.C1TextBox1.EditMask = "00000000-0"
        Me.C1TextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1TextBox1.Location = New System.Drawing.Point(578, 380)
        Me.C1TextBox1.MaxLength = 20
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.NumericInput = False
        Me.C1TextBox1.Size = New System.Drawing.Size(312, 21)
        Me.C1TextBox1.TabIndex = 28
        Me.C1TextBox1.Tag = Nothing
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(451, 377)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(111, 20)
        Me.MetroLabel13.TabIndex = 27
        Me.MetroLabel13.Text = "No. Documento:"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(13, 377)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(116, 20)
        Me.MetroLabel12.TabIndex = 25
        Me.MetroLabel12.Text = "Tipo Documento:"
        '
        'cbParentescoTitular2
        '
        Me.cbParentescoTitular2.FormattingEnabled = True
        Me.cbParentescoTitular2.ItemHeight = 24
        Me.cbParentescoTitular2.Location = New System.Drawing.Point(134, 342)
        Me.cbParentescoTitular2.Name = "cbParentescoTitular2"
        Me.cbParentescoTitular2.Size = New System.Drawing.Size(756, 30)
        Me.cbParentescoTitular2.TabIndex = 24
        Me.cbParentescoTitular2.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(13, 342)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(80, 20)
        Me.MetroLabel11.TabIndex = 23
        Me.MetroLabel11.Text = "Parentesco:"
        '
        'txtTitular2
        '
        '
        '
        '
        Me.txtTitular2.CustomButton.Image = Nothing
        Me.txtTitular2.CustomButton.Location = New System.Drawing.Point(734, 1)
        Me.txtTitular2.CustomButton.Name = ""
        Me.txtTitular2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTitular2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTitular2.CustomButton.TabIndex = 1
        Me.txtTitular2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTitular2.CustomButton.UseSelectable = True
        Me.txtTitular2.CustomButton.Visible = False
        Me.txtTitular2.Lines = New String(-1) {}
        Me.txtTitular2.Location = New System.Drawing.Point(134, 312)
        Me.txtTitular2.MaxLength = 32767
        Me.txtTitular2.Name = "txtTitular2"
        Me.txtTitular2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTitular2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTitular2.SelectedText = ""
        Me.txtTitular2.SelectionLength = 0
        Me.txtTitular2.SelectionStart = 0
        Me.txtTitular2.ShortcutsEnabled = True
        Me.txtTitular2.Size = New System.Drawing.Size(756, 23)
        Me.txtTitular2.TabIndex = 22
        Me.txtTitular2.UseSelectable = True
        Me.txtTitular2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTitular2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(13, 312)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(107, 20)
        Me.MetroLabel10.TabIndex = 21
        Me.MetroLabel10.Text = "Nombre Titular:"
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel19.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel19.Location = New System.Drawing.Point(2, 267)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(119, 25)
        Me.MetroLabel19.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel19.TabIndex = 20
        Me.MetroLabel19.Text = "Datos Titular"
        Me.MetroLabel19.UseCustomBackColor = True
        Me.MetroLabel19.UseCustomForeColor = True
        Me.MetroLabel19.UseStyleColors = True
        '
        'txtDireccion
        '
        '
        '
        '
        Me.txtDireccion.CustomButton.Image = Nothing
        Me.txtDireccion.CustomButton.Location = New System.Drawing.Point(706, 1)
        Me.txtDireccion.CustomButton.Name = ""
        Me.txtDireccion.CustomButton.Size = New System.Drawing.Size(55, 55)
        Me.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDireccion.CustomButton.TabIndex = 1
        Me.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDireccion.CustomButton.UseSelectable = True
        Me.txtDireccion.CustomButton.Visible = False
        Me.txtDireccion.Lines = New String(-1) {}
        Me.txtDireccion.Location = New System.Drawing.Point(128, 195)
        Me.txtDireccion.MaxLength = 32767
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.SelectionLength = 0
        Me.txtDireccion.SelectionStart = 0
        Me.txtDireccion.ShortcutsEnabled = True
        Me.txtDireccion.Size = New System.Drawing.Size(762, 57)
        Me.txtDireccion.TabIndex = 19
        Me.txtDireccion.UseSelectable = True
        Me.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDireccion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Location = New System.Drawing.Point(578, 123)
        Me.dtpFecNac.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(312, 30)
        Me.dtpFecNac.TabIndex = 15
        '
        'cbDoc
        '
        Me.cbDoc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoc.Items.AddRange(New Object() {"DUI", "NIT", "No. Licencia", "No. Residente", "No. Partida y No. Folio", "No. Pasaporte"})
        Me.cbDoc.Location = New System.Drawing.Point(134, 377)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(308, 24)
        Me.cbDoc.TabIndex = 26
        '
        'txtApe3
        '
        '
        '
        '
        Me.txtApe3.CustomButton.Image = Nothing
        Me.txtApe3.CustomButton.Location = New System.Drawing.Point(292, 2)
        Me.txtApe3.CustomButton.Name = ""
        Me.txtApe3.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.txtApe3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApe3.CustomButton.TabIndex = 1
        Me.txtApe3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApe3.CustomButton.UseSelectable = True
        Me.txtApe3.CustomButton.Visible = False
        Me.txtApe3.Lines = New String(-1) {}
        Me.txtApe3.Location = New System.Drawing.Point(128, 123)
        Me.txtApe3.MaxLength = 32767
        Me.txtApe3.Name = "txtApe3"
        Me.txtApe3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApe3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApe3.SelectedText = ""
        Me.txtApe3.SelectionLength = 0
        Me.txtApe3.SelectionStart = 0
        Me.txtApe3.ShortcutsEnabled = True
        Me.txtApe3.Size = New System.Drawing.Size(314, 24)
        Me.txtApe3.TabIndex = 13
        Me.txtApe3.UseSelectable = True
        Me.txtApe3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtApe3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.FormattingEnabled = True
        Me.cbEstadoCivil.ItemHeight = 24
        Me.cbEstadoCivil.Location = New System.Drawing.Point(128, 159)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(762, 30)
        Me.cbEstadoCivil.TabIndex = 17
        Me.cbEstadoCivil.UseSelectable = True
        '
        'txtSegApellido
        '
        '
        '
        '
        Me.txtSegApellido.CustomButton.Image = Nothing
        Me.txtSegApellido.CustomButton.Location = New System.Drawing.Point(290, 2)
        Me.txtSegApellido.CustomButton.Name = ""
        Me.txtSegApellido.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.txtSegApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSegApellido.CustomButton.TabIndex = 1
        Me.txtSegApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSegApellido.CustomButton.UseSelectable = True
        Me.txtSegApellido.CustomButton.Visible = False
        Me.txtSegApellido.Lines = New String(-1) {}
        Me.txtSegApellido.Location = New System.Drawing.Point(578, 93)
        Me.txtSegApellido.MaxLength = 32767
        Me.txtSegApellido.Name = "txtSegApellido"
        Me.txtSegApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSegApellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSegApellido.SelectedText = ""
        Me.txtSegApellido.SelectionLength = 0
        Me.txtSegApellido.SelectionStart = 0
        Me.txtSegApellido.ShortcutsEnabled = True
        Me.txtSegApellido.Size = New System.Drawing.Size(312, 24)
        Me.txtSegApellido.TabIndex = 11
        Me.txtSegApellido.UseSelectable = True
        Me.txtSegApellido.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSegApellido.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtApe2
        '
        '
        '
        '
        Me.txtApe2.CustomButton.Image = Nothing
        Me.txtApe2.CustomButton.Location = New System.Drawing.Point(-20, 2)
        Me.txtApe2.CustomButton.Name = ""
        Me.txtApe2.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtApe2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApe2.CustomButton.TabIndex = 1
        Me.txtApe2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApe2.CustomButton.UseSelectable = True
        Me.txtApe2.CustomButton.Visible = False
        Me.txtApe2.Lines = New String(-1) {}
        Me.txtApe2.Location = New System.Drawing.Point(0, 0)
        Me.txtApe2.MaxLength = 32767
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApe2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApe2.SelectedText = ""
        Me.txtApe2.SelectionLength = 0
        Me.txtApe2.SelectionStart = 0
        Me.txtApe2.ShortcutsEnabled = True
        Me.txtApe2.Size = New System.Drawing.Size(0, 22)
        Me.txtApe2.TabIndex = 0
        Me.txtApe2.UseSelectable = True
        Me.txtApe2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtApe2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtApe1
        '
        '
        '
        '
        Me.txtApe1.CustomButton.Image = Nothing
        Me.txtApe1.CustomButton.Location = New System.Drawing.Point(292, 2)
        Me.txtApe1.CustomButton.Name = ""
        Me.txtApe1.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.txtApe1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApe1.CustomButton.TabIndex = 1
        Me.txtApe1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApe1.CustomButton.UseSelectable = True
        Me.txtApe1.CustomButton.Visible = False
        Me.txtApe1.Lines = New String(-1) {}
        Me.txtApe1.Location = New System.Drawing.Point(128, 93)
        Me.txtApe1.MaxLength = 32767
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApe1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApe1.SelectedText = ""
        Me.txtApe1.SelectionLength = 0
        Me.txtApe1.SelectionStart = 0
        Me.txtApe1.ShortcutsEnabled = True
        Me.txtApe1.Size = New System.Drawing.Size(314, 24)
        Me.txtApe1.TabIndex = 9
        Me.txtApe1.UseSelectable = True
        Me.txtApe1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtApe1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNombres
        '
        '
        '
        '
        Me.txtNombres.CustomButton.Image = Nothing
        Me.txtNombres.CustomButton.Location = New System.Drawing.Point(740, 1)
        Me.txtNombres.CustomButton.Name = ""
        Me.txtNombres.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombres.CustomButton.TabIndex = 1
        Me.txtNombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombres.CustomButton.UseSelectable = True
        Me.txtNombres.CustomButton.Visible = False
        Me.txtNombres.Lines = New String(-1) {}
        Me.txtNombres.Location = New System.Drawing.Point(128, 65)
        Me.txtNombres.MaxLength = 32767
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombres.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombres.SelectedText = ""
        Me.txtNombres.SelectionLength = 0
        Me.txtNombres.SelectionStart = 0
        Me.txtNombres.ShortcutsEnabled = True
        Me.txtNombres.Size = New System.Drawing.Size(762, 23)
        Me.txtNombres.TabIndex = 7
        Me.txtNombres.UseSelectable = True
        Me.txtNombres.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombres.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNoSocio
        '
        '
        '
        '
        Me.txtNoSocio.CustomButton.Image = Nothing
        Me.txtNoSocio.CustomButton.Location = New System.Drawing.Point(290, 1)
        Me.txtNoSocio.CustomButton.Name = ""
        Me.txtNoSocio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNoSocio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNoSocio.CustomButton.TabIndex = 1
        Me.txtNoSocio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNoSocio.CustomButton.UseSelectable = True
        Me.txtNoSocio.CustomButton.Visible = False
        Me.txtNoSocio.Lines = New String(-1) {}
        Me.txtNoSocio.Location = New System.Drawing.Point(578, 38)
        Me.txtNoSocio.MaxLength = 32767
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoSocio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNoSocio.SelectedText = ""
        Me.txtNoSocio.SelectionLength = 0
        Me.txtNoSocio.SelectionStart = 0
        Me.txtNoSocio.ShortcutsEnabled = True
        Me.txtNoSocio.Size = New System.Drawing.Size(312, 23)
        Me.txtNoSocio.TabIndex = 5
        Me.txtNoSocio.UseSelectable = True
        Me.txtNoSocio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNoSocio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(448, 123)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(124, 20)
        Me.MetroLabel9.TabIndex = 14
        Me.MetroLabel9.Text = "Fecha Nacimiento:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(13, 195)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(71, 20)
        Me.MetroLabel8.TabIndex = 18
        Me.MetroLabel8.Text = "Dirección:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(13, 159)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(82, 20)
        Me.MetroLabel7.TabIndex = 16
        Me.MetroLabel7.Text = "Estado Civil:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(13, 123)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(110, 20)
        Me.MetroLabel6.TabIndex = 12
        Me.MetroLabel6.Text = "Apellido Casada:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(451, 93)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(121, 20)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Segundo Apellido:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(13, 93)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(107, 20)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Primer Apellido:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(13, 65)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(70, 20)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Nombres:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(451, 38)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(94, 20)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "No. Asociado:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 38)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(33, 20)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Dui:"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel18.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel18.Location = New System.Drawing.Point(2, 6)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(222, 25)
        Me.MetroLabel18.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel18.TabIndex = 0
        Me.MetroLabel18.Text = "Información de Asociado"
        Me.MetroLabel18.UseCustomBackColor = True
        Me.MetroLabel18.UseCustomForeColor = True
        Me.MetroLabel18.UseStyleColors = True
        '
        'MetroButton9
        '
        Me.MetroButton9.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.MetroButton9.Location = New System.Drawing.Point(680, 407)
        Me.MetroButton9.Name = "MetroButton9"
        Me.MetroButton9.Size = New System.Drawing.Size(114, 31)
        Me.MetroButton9.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton9.TabIndex = 31
        Me.MetroButton9.Text = "&Datos Asociado"
        Me.MetroButton9.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton9.UseSelectable = True
        Me.MetroButton9.UseStyleColors = True
        '
        'MetroButton7
        '
        Me.MetroButton7.Location = New System.Drawing.Point(800, 407)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(90, 31)
        Me.MetroButton7.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton7.TabIndex = 32
        Me.MetroButton7.Text = "Siguiente"
        Me.MetroButton7.UseSelectable = True
        Me.MetroButton7.UseStyleColors = True
        '
        'txtDui
        '
        Me.txtDui.AcceptsReturn = True
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDui.Location = New System.Drawing.Point(128, 38)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(314, 21)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.BtnCtaAhorro)
        Me.TabPage1.Controls.Add(Me.MetroButton13)
        Me.TabPage1.Controls.Add(Me.dtpFechaCapitalizacion)
        Me.TabPage1.Controls.Add(Me.cbNocuenta)
        Me.TabPage1.Controls.Add(Me.MetroLabel23)
        Me.TabPage1.Controls.Add(Me.MetroLabel38)
        Me.TabPage1.Controls.Add(Me.MetroLabel37)
        Me.TabPage1.Controls.Add(Me.MetroButton12)
        Me.TabPage1.Controls.Add(Me.cbFormaPagoInt)
        Me.TabPage1.Controls.Add(Me.txtestado)
        Me.TabPage1.Controls.Add(Me.MetroLabel39)
        Me.TabPage1.Controls.Add(Me.MetroLabel36)
        Me.TabPage1.Controls.Add(Me.cbSucursal)
        Me.TabPage1.Controls.Add(Me.MetroLabel34)
        Me.TabPage1.Controls.Add(Me.cbEjecutivo)
        Me.TabPage1.Controls.Add(Me.MetroLabel35)
        Me.TabPage1.Controls.Add(Me.dtpFecCanc)
        Me.TabPage1.Controls.Add(Me.MetroLabel33)
        Me.TabPage1.Controls.Add(Me.txtObs)
        Me.TabPage1.Controls.Add(Me.cbAutorizacion)
        Me.TabPage1.Controls.Add(Me.MetroLabel32)
        Me.TabPage1.Controls.Add(Me.btTasaPactada)
        Me.TabPage1.Controls.Add(Me.MetroLabel31)
        Me.TabPage1.Controls.Add(Me.MetroLabel30)
        Me.TabPage1.Controls.Add(Me.MetroLabel29)
        Me.TabPage1.Controls.Add(Me.MetroLabel28)
        Me.TabPage1.Controls.Add(Me.MetroLabel27)
        Me.TabPage1.Controls.Add(Me.c1nRemesa)
        Me.TabPage1.Controls.Add(Me.c1nCaja)
        Me.TabPage1.Controls.Add(Me.MetroLabel22)
        Me.TabPage1.Controls.Add(Me.c1nRenovacion)
        Me.TabPage1.Controls.Add(Me.c1nTasa)
        Me.TabPage1.Controls.Add(Me.dtpFecVenc)
        Me.TabPage1.Controls.Add(Me.dtpFechaRenovacion)
        Me.TabPage1.Controls.Add(Me.dtpFecIniApertura)
        Me.TabPage1.Controls.Add(Me.c1nTransferencia)
        Me.TabPage1.Controls.Add(Me.MetroLabel26)
        Me.TabPage1.Controls.Add(Me.MetroLabel24)
        Me.TabPage1.Controls.Add(Me.btEdit)
        Me.TabPage1.Controls.Add(Me.MetroLabel25)
        Me.TabPage1.Controls.Add(Me.MetroLabel21)
        Me.TabPage1.Controls.Add(Me.MetroLabel17)
        Me.TabPage1.Controls.Add(Me.MetroLabel16)
        Me.TabPage1.Controls.Add(Me.txtNoCertificado)
        Me.TabPage1.Controls.Add(Me.MetroLabel15)
        Me.TabPage1.Controls.Add(Me.cbTipoAhorro)
        Me.TabPage1.Controls.Add(Me.MetroLabel20)
        Me.TabPage1.Controls.Add(Me.c1nMontoApertura)
        Me.TabPage1.Controls.Add(Me.MetroButton3)
        Me.TabPage1.Controls.Add(Me.btnSaveTb1)
        Me.TabPage1.Controls.Add(Me.MetroButton1)
        Me.TabPage1.Controls.Add(Me.c1nPlazo)
        Me.TabPage1.Controls.Add(Me.txtNoCuenta)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(925, 613)
        Me.TabPage1.TabIndex = 8
        Me.TabPage1.Text = "Datos Deposito a Plazo"
        '
        'BtnCtaAhorro
        '
        Me.BtnCtaAhorro.Location = New System.Drawing.Point(730, 393)
        Me.BtnCtaAhorro.Name = "BtnCtaAhorro"
        Me.BtnCtaAhorro.Size = New System.Drawing.Size(172, 33)
        Me.BtnCtaAhorro.Style = MetroFramework.MetroColorStyle.Teal
        Me.BtnCtaAhorro.TabIndex = 52
        Me.BtnCtaAhorro.Text = "Pago Int. a Cta. Terceros"
        Me.BtnCtaAhorro.UseSelectable = True
        Me.BtnCtaAhorro.UseStyleColors = True
        '
        'MetroButton13
        '
        Me.MetroButton13.Location = New System.Drawing.Point(472, 393)
        Me.MetroButton13.Name = "MetroButton13"
        Me.MetroButton13.Size = New System.Drawing.Size(222, 33)
        Me.MetroButton13.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton13.TabIndex = 51
        Me.MetroButton13.Text = "Modificar Forma de Pago de Int."
        Me.MetroButton13.UseSelectable = True
        Me.MetroButton13.UseStyleColors = True
        '
        'dtpFechaCapitalizacion
        '
        Me.dtpFechaCapitalizacion.Location = New System.Drawing.Point(149, 391)
        Me.dtpFechaCapitalizacion.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaCapitalizacion.Name = "dtpFechaCapitalizacion"
        Me.dtpFechaCapitalizacion.Size = New System.Drawing.Size(307, 30)
        Me.dtpFechaCapitalizacion.TabIndex = 36
        '
        'cbNocuenta
        '
        Me.cbNocuenta.FormattingEnabled = True
        Me.cbNocuenta.ItemHeight = 24
        Me.cbNocuenta.Location = New System.Drawing.Point(596, 346)
        Me.cbNocuenta.Name = "cbNocuenta"
        Me.cbNocuenta.Size = New System.Drawing.Size(306, 30)
        Me.cbNocuenta.TabIndex = 28
        Me.cbNocuenta.UseSelectable = True
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.Location = New System.Drawing.Point(13, 391)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(137, 20)
        Me.MetroLabel23.TabIndex = 35
        Me.MetroLabel23.Text = "Fecha Capitalización:"
        '
        'MetroLabel38
        '
        Me.MetroLabel38.AutoSize = True
        Me.MetroLabel38.Location = New System.Drawing.Point(462, 346)
        Me.MetroLabel38.Name = "MetroLabel38"
        Me.MetroLabel38.Size = New System.Drawing.Size(88, 40)
        Me.MetroLabel38.TabIndex = 27
        Me.MetroLabel38.Text = "Cuenta Pago" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Intereses:"
        '
        'MetroLabel37
        '
        Me.MetroLabel37.AutoSize = True
        Me.MetroLabel37.Location = New System.Drawing.Point(13, 346)
        Me.MetroLabel37.Name = "MetroLabel37"
        Me.MetroLabel37.Size = New System.Drawing.Size(88, 40)
        Me.MetroLabel37.TabIndex = 25
        Me.MetroLabel37.Text = "Forma Pago " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Intereses:"
        '
        'MetroButton12
        '
        Me.MetroButton12.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton12.ForeColor = System.Drawing.Color.Teal
        Me.MetroButton12.Location = New System.Drawing.Point(786, 441)
        Me.MetroButton12.Name = "MetroButton12"
        Me.MetroButton12.Size = New System.Drawing.Size(116, 29)
        Me.MetroButton12.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton12.TabIndex = 50
        Me.MetroButton12.Text = "Cambiar Ejecutivo"
        Me.MetroButton12.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton12.UseCustomBackColor = True
        Me.MetroButton12.UseCustomForeColor = True
        Me.MetroButton12.UseSelectable = True
        Me.MetroButton12.UseStyleColors = True
        '
        'cbFormaPagoInt
        '
        Me.cbFormaPagoInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFormaPagoInt.FormattingEnabled = True
        Me.cbFormaPagoInt.ItemHeight = 24
        Me.cbFormaPagoInt.Items.AddRange(New Object() {"Mensualmente", "Vencimiento de DPF"})
        Me.cbFormaPagoInt.Location = New System.Drawing.Point(149, 346)
        Me.cbFormaPagoInt.Name = "cbFormaPagoInt"
        Me.cbFormaPagoInt.Size = New System.Drawing.Size(307, 30)
        Me.cbFormaPagoInt.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbFormaPagoInt.TabIndex = 26
        Me.cbFormaPagoInt.UseSelectable = True
        '
        'txtestado
        '
        '
        '
        '
        Me.txtestado.CustomButton.Image = Nothing
        Me.txtestado.CustomButton.Location = New System.Drawing.Point(284, 1)
        Me.txtestado.CustomButton.Name = ""
        Me.txtestado.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtestado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtestado.CustomButton.TabIndex = 1
        Me.txtestado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtestado.CustomButton.UseSelectable = True
        Me.txtestado.CustomButton.Visible = False
        Me.txtestado.Lines = New String(-1) {}
        Me.txtestado.Location = New System.Drawing.Point(596, 209)
        Me.txtestado.MaxLength = 32767
        Me.txtestado.Name = "txtestado"
        Me.txtestado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtestado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtestado.SelectedText = ""
        Me.txtestado.SelectionLength = 0
        Me.txtestado.SelectionStart = 0
        Me.txtestado.ShortcutsEnabled = True
        Me.txtestado.Size = New System.Drawing.Size(306, 23)
        Me.txtestado.TabIndex = 49
        Me.txtestado.UseSelectable = True
        Me.txtestado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtestado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel39
        '
        Me.MetroLabel39.AutoSize = True
        Me.MetroLabel39.Location = New System.Drawing.Point(464, 209)
        Me.MetroLabel39.Name = "MetroLabel39"
        Me.MetroLabel39.Size = New System.Drawing.Size(53, 20)
        Me.MetroLabel39.TabIndex = 48
        Me.MetroLabel39.Text = "Estado:"
        '
        'MetroLabel36
        '
        Me.MetroLabel36.AutoSize = True
        Me.MetroLabel36.Location = New System.Drawing.Point(16, 512)
        Me.MetroLabel36.Name = "MetroLabel36"
        Me.MetroLabel36.Size = New System.Drawing.Size(105, 20)
        Me.MetroLabel36.TabIndex = 43
        Me.MetroLabel36.Text = "Observaciones:"
        '
        'cbSucursal
        '
        Me.cbSucursal.Enabled = False
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.ItemHeight = 24
        Me.cbSucursal.Location = New System.Drawing.Point(149, 477)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(753, 30)
        Me.cbSucursal.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbSucursal.TabIndex = 42
        Me.cbSucursal.UseSelectable = True
        '
        'MetroLabel34
        '
        Me.MetroLabel34.AutoSize = True
        Me.MetroLabel34.Location = New System.Drawing.Point(13, 477)
        Me.MetroLabel34.Name = "MetroLabel34"
        Me.MetroLabel34.Size = New System.Drawing.Size(63, 20)
        Me.MetroLabel34.TabIndex = 41
        Me.MetroLabel34.Text = "Sucursal:"
        '
        'cbEjecutivo
        '
        Me.cbEjecutivo.FormattingEnabled = True
        Me.cbEjecutivo.ItemHeight = 24
        Me.cbEjecutivo.Location = New System.Drawing.Point(149, 440)
        Me.cbEjecutivo.Name = "cbEjecutivo"
        Me.cbEjecutivo.Size = New System.Drawing.Size(636, 30)
        Me.cbEjecutivo.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbEjecutivo.TabIndex = 40
        Me.cbEjecutivo.UseSelectable = True
        '
        'MetroLabel35
        '
        Me.MetroLabel35.AutoSize = True
        Me.MetroLabel35.Location = New System.Drawing.Point(13, 440)
        Me.MetroLabel35.Name = "MetroLabel35"
        Me.MetroLabel35.Size = New System.Drawing.Size(68, 20)
        Me.MetroLabel35.TabIndex = 39
        Me.MetroLabel35.Text = "Ejecutivo:"
        '
        'dtpFecCanc
        '
        Me.dtpFecCanc.Location = New System.Drawing.Point(596, 310)
        Me.dtpFecCanc.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFecCanc.Name = "dtpFecCanc"
        Me.dtpFecCanc.Size = New System.Drawing.Size(306, 30)
        Me.dtpFecCanc.TabIndex = 38
        '
        'MetroLabel33
        '
        Me.MetroLabel33.AutoSize = True
        Me.MetroLabel33.Location = New System.Drawing.Point(462, 310)
        Me.MetroLabel33.Name = "MetroLabel33"
        Me.MetroLabel33.Size = New System.Drawing.Size(128, 20)
        Me.MetroLabel33.TabIndex = 37
        Me.MetroLabel33.Text = "Fecha Cancelación:"
        '
        'txtObs
        '
        Me.txtObs.AcceptsReturn = True
        Me.txtObs.BackColor = System.Drawing.Color.White
        Me.txtObs.Location = New System.Drawing.Point(149, 512)
        Me.txtObs.MaxLength = 0
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(755, 45)
        Me.txtObs.TabIndex = 44
        '
        'cbAutorizacion
        '
        Me.cbAutorizacion.BackColor = System.Drawing.Color.White
        Me.cbAutorizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAutorizacion.Enabled = False
        Me.cbAutorizacion.FormattingEnabled = True
        Me.cbAutorizacion.Location = New System.Drawing.Point(149, 243)
        Me.cbAutorizacion.Name = "cbAutorizacion"
        Me.cbAutorizacion.Size = New System.Drawing.Size(753, 24)
        Me.cbAutorizacion.TabIndex = 24
        '
        'MetroLabel32
        '
        Me.MetroLabel32.AutoSize = True
        Me.MetroLabel32.Location = New System.Drawing.Point(13, 228)
        Me.MetroLabel32.Name = "MetroLabel32"
        Me.MetroLabel32.Size = New System.Drawing.Size(109, 40)
        Me.MetroLabel32.TabIndex = 23
        Me.MetroLabel32.Text = "Autorización " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cambio de Tasa:"
        '
        'btTasaPactada
        '
        Me.btTasaPactada.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btTasaPactada.ForeColor = System.Drawing.Color.Teal
        Me.btTasaPactada.Location = New System.Drawing.Point(338, 209)
        Me.btTasaPactada.Name = "btTasaPactada"
        Me.btTasaPactada.Size = New System.Drawing.Size(118, 29)
        Me.btTasaPactada.Style = MetroFramework.MetroColorStyle.Teal
        Me.btTasaPactada.TabIndex = 22
        Me.btTasaPactada.Text = "Modificar Tasa"
        Me.btTasaPactada.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btTasaPactada.UseCustomBackColor = True
        Me.btTasaPactada.UseCustomForeColor = True
        Me.btTasaPactada.UseSelectable = True
        Me.btTasaPactada.UseStyleColors = True
        '
        'MetroLabel31
        '
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.Location = New System.Drawing.Point(13, 209)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(84, 20)
        Me.MetroLabel31.TabIndex = 20
        Me.MetroLabel31.Text = "Tasa Interes:"
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.Location = New System.Drawing.Point(462, 168)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(61, 20)
        Me.MetroLabel30.TabIndex = 18
        Me.MetroLabel30.Text = "Remesa:"
        '
        'MetroLabel29
        '
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.Location = New System.Drawing.Point(13, 168)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(126, 20)
        Me.MetroLabel29.TabIndex = 16
        Me.MetroLabel29.Text = "Fondos Renovados"
        '
        'MetroLabel28
        '
        Me.MetroLabel28.AutoSize = True
        Me.MetroLabel28.Location = New System.Drawing.Point(462, 144)
        Me.MetroLabel28.Name = "MetroLabel28"
        Me.MetroLabel28.Size = New System.Drawing.Size(94, 20)
        Me.MetroLabel28.TabIndex = 14
        Me.MetroLabel28.Text = "Transferencia:"
        '
        'MetroLabel27
        '
        Me.MetroLabel27.AutoSize = True
        Me.MetroLabel27.Location = New System.Drawing.Point(13, 144)
        Me.MetroLabel27.Name = "MetroLabel27"
        Me.MetroLabel27.Size = New System.Drawing.Size(87, 20)
        Me.MetroLabel27.TabIndex = 12
        Me.MetroLabel27.Text = "Fondos Caja:"
        '
        'c1nRemesa
        '
        Me.c1nRemesa.BackColor = System.Drawing.Color.White
        Me.c1nRemesa.CustomFormat = "###,###,##0.00"
        Me.c1nRemesa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nRemesa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nRemesa.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nRemesa.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nRemesa.Location = New System.Drawing.Point(596, 171)
        Me.c1nRemesa.Name = "c1nRemesa"
        Me.c1nRemesa.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nRemesa.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nRemesa.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nRemesa.Size = New System.Drawing.Size(308, 21)
        Me.c1nRemesa.TabIndex = 19
        Me.c1nRemesa.Tag = Nothing
        Me.c1nRemesa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nRemesa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nCaja
        '
        Me.c1nCaja.BackColor = System.Drawing.Color.White
        Me.c1nCaja.CustomFormat = "###,###,##0.00"
        Me.c1nCaja.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nCaja.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCaja.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCaja.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCaja.Location = New System.Drawing.Point(149, 144)
        Me.c1nCaja.Name = "c1nCaja"
        Me.c1nCaja.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCaja.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCaja.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCaja.Size = New System.Drawing.Size(307, 21)
        Me.c1nCaja.TabIndex = 13
        Me.c1nCaja.Tag = Nothing
        Me.c1nCaja.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCaja.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel22.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel22.Location = New System.Drawing.Point(13, 111)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(203, 25)
        Me.MetroLabel22.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel22.TabIndex = 11
        Me.MetroLabel22.Text = "Detalle Monto Apertura"
        Me.MetroLabel22.UseCustomBackColor = True
        Me.MetroLabel22.UseCustomForeColor = True
        Me.MetroLabel22.UseStyleColors = True
        '
        'c1nRenovacion
        '
        Me.c1nRenovacion.BackColor = System.Drawing.Color.White
        Me.c1nRenovacion.CustomFormat = "###,###,##0.00"
        Me.c1nRenovacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nRenovacion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nRenovacion.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nRenovacion.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nRenovacion.Location = New System.Drawing.Point(149, 171)
        Me.c1nRenovacion.Name = "c1nRenovacion"
        Me.c1nRenovacion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nRenovacion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nRenovacion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nRenovacion.Size = New System.Drawing.Size(307, 21)
        Me.c1nRenovacion.TabIndex = 17
        Me.c1nRenovacion.Tag = Nothing
        Me.c1nRenovacion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nRenovacion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nTasa
        '
        Me.c1nTasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasa.CustomFormat = "#0.00"
        Me.c1nTasa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTasa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasa.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTasa.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasa.Location = New System.Drawing.Point(149, 209)
        Me.c1nTasa.Name = "c1nTasa"
        Me.c1nTasa.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasa.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasa.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasa.ReadOnly = True
        Me.c1nTasa.Size = New System.Drawing.Size(182, 23)
        Me.c1nTasa.TabIndex = 21
        Me.c1nTasa.Tag = Nothing
        Me.c1nTasa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'dtpFecVenc
        '
        Me.dtpFecVenc.Location = New System.Drawing.Point(149, 310)
        Me.dtpFecVenc.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFecVenc.Name = "dtpFecVenc"
        Me.dtpFecVenc.Size = New System.Drawing.Size(307, 30)
        Me.dtpFecVenc.TabIndex = 34
        '
        'dtpFechaRenovacion
        '
        Me.dtpFechaRenovacion.Location = New System.Drawing.Point(596, 273)
        Me.dtpFechaRenovacion.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaRenovacion.Name = "dtpFechaRenovacion"
        Me.dtpFechaRenovacion.Size = New System.Drawing.Size(308, 30)
        Me.dtpFechaRenovacion.TabIndex = 32
        '
        'dtpFecIniApertura
        '
        Me.dtpFecIniApertura.Location = New System.Drawing.Point(149, 273)
        Me.dtpFecIniApertura.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFecIniApertura.Name = "dtpFecIniApertura"
        Me.dtpFecIniApertura.Size = New System.Drawing.Size(307, 30)
        Me.dtpFecIniApertura.TabIndex = 30
        '
        'c1nTransferencia
        '
        Me.c1nTransferencia.BackColor = System.Drawing.Color.White
        Me.c1nTransferencia.CustomFormat = "###,###,##0.00"
        Me.c1nTransferencia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTransferencia.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTransferencia.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTransferencia.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTransferencia.Location = New System.Drawing.Point(596, 143)
        Me.c1nTransferencia.Name = "c1nTransferencia"
        Me.c1nTransferencia.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTransferencia.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTransferencia.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTransferencia.Size = New System.Drawing.Size(308, 21)
        Me.c1nTransferencia.TabIndex = 15
        Me.c1nTransferencia.Tag = Nothing
        Me.c1nTransferencia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTransferencia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel26
        '
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.Location = New System.Drawing.Point(13, 273)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(108, 20)
        Me.MetroLabel26.TabIndex = 29
        Me.MetroLabel26.Text = "Fecha Apertura:"
        Me.MetroLabel26.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'MetroLabel24
        '
        Me.MetroLabel24.AutoSize = True
        Me.MetroLabel24.Location = New System.Drawing.Point(13, 310)
        Me.MetroLabel24.Name = "MetroLabel24"
        Me.MetroLabel24.Size = New System.Drawing.Size(130, 20)
        Me.MetroLabel24.TabIndex = 33
        Me.MetroLabel24.Text = "Fecha Vencimiento:"
        '
        'btEdit
        '
        Me.btEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btEdit.BackColor = System.Drawing.Color.White
        Me.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.ForeColor = System.Drawing.Color.Teal
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.Location = New System.Drawing.Point(382, 77)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(74, 28)
        Me.btEdit.TabIndex = 8
        Me.btEdit.Text = "&Modificar"
        Me.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.UseVisualStyleBackColor = False
        '
        'MetroLabel25
        '
        Me.MetroLabel25.AutoSize = True
        Me.MetroLabel25.Location = New System.Drawing.Point(462, 273)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(125, 20)
        Me.MetroLabel25.TabIndex = 31
        Me.MetroLabel25.Text = "Fecha Renovación:"
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.Location = New System.Drawing.Point(462, 81)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(111, 20)
        Me.MetroLabel21.TabIndex = 9
        Me.MetroLabel21.Text = "Monto Apertura:"
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(13, 82)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(105, 20)
        Me.MetroLabel17.TabIndex = 6
        Me.MetroLabel17.Text = "No. Certificado:"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(462, 51)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(45, 20)
        Me.MetroLabel16.TabIndex = 4
        Me.MetroLabel16.Text = "Plazo:"
        '
        'txtNoCertificado
        '
        Me.txtNoCertificado.BackColor = System.Drawing.Color.White
        Me.txtNoCertificado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCertificado.Location = New System.Drawing.Point(149, 78)
        Me.txtNoCertificado.MaxLength = 20
        Me.txtNoCertificado.Name = "txtNoCertificado"
        Me.txtNoCertificado.ReadOnly = True
        Me.txtNoCertificado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoCertificado.Size = New System.Drawing.Size(227, 25)
        Me.txtNoCertificado.TabIndex = 7
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(13, 52)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(82, 20)
        Me.MetroLabel15.TabIndex = 2
        Me.MetroLabel15.Text = "No. Cuenta:"
        '
        'cbTipoAhorro
        '
        Me.cbTipoAhorro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoAhorro.FormattingEnabled = True
        Me.cbTipoAhorro.ItemHeight = 24
        Me.cbTipoAhorro.Location = New System.Drawing.Point(149, 15)
        Me.cbTipoAhorro.Name = "cbTipoAhorro"
        Me.cbTipoAhorro.Size = New System.Drawing.Size(753, 30)
        Me.cbTipoAhorro.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbTipoAhorro.TabIndex = 1
        Me.cbTipoAhorro.UseSelectable = True
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(13, 16)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(89, 20)
        Me.MetroLabel20.TabIndex = 0
        Me.MetroLabel20.Text = "Linea Ahorro"
        '
        'c1nMontoApertura
        '
        Me.c1nMontoApertura.BackColor = System.Drawing.Color.White
        Me.c1nMontoApertura.CustomFormat = "###,###,##0.00"
        Me.c1nMontoApertura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoApertura.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoApertura.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMontoApertura.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoApertura.Location = New System.Drawing.Point(596, 82)
        Me.c1nMontoApertura.Name = "c1nMontoApertura"
        Me.c1nMontoApertura.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoApertura.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoApertura.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoApertura.Size = New System.Drawing.Size(308, 23)
        Me.c1nMontoApertura.TabIndex = 10
        Me.c1nMontoApertura.Tag = Nothing
        Me.c1nMontoApertura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoApertura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(718, 563)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 46
        Me.MetroButton3.Text = "Siguiente"
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'btnSaveTb1
        '
        Me.btnSaveTb1.Location = New System.Drawing.Point(814, 563)
        Me.btnSaveTb1.Name = "btnSaveTb1"
        Me.btnSaveTb1.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb1.TabIndex = 47
        Me.btnSaveTb1.Text = "&Guardar"
        Me.btnSaveTb1.UseSelectable = True
        Me.btnSaveTb1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(622, 563)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 45
        Me.MetroButton1.Text = "Atras"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'c1nPlazo
        '
        Me.c1nPlazo.BackColor = System.Drawing.Color.White
        Me.c1nPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPlazo.CustomFormat = "#0"
        Me.c1nPlazo.DataType = GetType(Short)
        Me.c1nPlazo.Enabled = False
        Me.c1nPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nPlazo.Location = New System.Drawing.Point(596, 53)
        Me.c1nPlazo.Name = "c1nPlazo"
        Me.c1nPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nPlazo.ReadOnly = True
        Me.c1nPlazo.Size = New System.Drawing.Size(306, 23)
        Me.c1nPlazo.TabIndex = 5
        Me.c1nPlazo.Tag = Nothing
        Me.c1nPlazo.Value = CType(0, Short)
        Me.c1nPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BackColor = System.Drawing.Color.White
        Me.txtNoCuenta.Location = New System.Drawing.Point(149, 52)
        Me.txtNoCuenta.MaxLength = 20
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.ReadOnly = True
        Me.txtNoCuenta.Size = New System.Drawing.Size(307, 22)
        Me.txtNoCuenta.TabIndex = 3
        '
        'tabDatGralII
        '
        Me.tabDatGralII.BackColor = System.Drawing.Color.White
        Me.tabDatGralII.Controls.Add(Me.MetroButton4)
        Me.tabDatGralII.Controls.Add(Me.btDelBen)
        Me.tabDatGralII.Controls.Add(Me.MetroButton11)
        Me.tabDatGralII.Controls.Add(Me.btEditBen)
        Me.tabDatGralII.Controls.Add(Me.btnContrato)
        Me.tabDatGralII.Controls.Add(Me.btNewBen)
        Me.tabDatGralII.Controls.Add(Me.fgBen)
        Me.tabDatGralII.Controls.Add(Me.MetroButton8)
        Me.tabDatGralII.Controls.Add(Me.MetroButton10)
        Me.tabDatGralII.Location = New System.Drawing.Point(4, 22)
        Me.tabDatGralII.Name = "tabDatGralII"
        Me.tabDatGralII.Size = New System.Drawing.Size(925, 613)
        Me.tabDatGralII.TabIndex = 5
        Me.tabDatGralII.Text = "Beneficiarios"
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(625, 538)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton4.TabIndex = 225
        Me.MetroButton4.Text = "Siguiente"
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'btDelBen
        '
        Me.btDelBen.Location = New System.Drawing.Point(212, 16)
        Me.btDelBen.Name = "btDelBen"
        Me.btDelBen.Size = New System.Drawing.Size(90, 32)
        Me.btDelBen.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelBen.TabIndex = 216
        Me.btDelBen.Text = "Eliminar"
        Me.btDelBen.UseSelectable = True
        Me.btDelBen.UseStyleColors = True
        '
        'MetroButton11
        '
        Me.MetroButton11.Location = New System.Drawing.Point(817, 538)
        Me.MetroButton11.Name = "MetroButton11"
        Me.MetroButton11.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton11.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton11.TabIndex = 224
        Me.MetroButton11.Text = "Certificado"
        Me.MetroButton11.UseSelectable = True
        Me.MetroButton11.UseStyleColors = True
        '
        'btEditBen
        '
        Me.btEditBen.Location = New System.Drawing.Point(116, 16)
        Me.btEditBen.Name = "btEditBen"
        Me.btEditBen.Size = New System.Drawing.Size(90, 32)
        Me.btEditBen.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditBen.TabIndex = 215
        Me.btEditBen.Text = "Modificar"
        Me.btEditBen.UseSelectable = True
        Me.btEditBen.UseStyleColors = True
        '
        'btnContrato
        '
        Me.btnContrato.Location = New System.Drawing.Point(721, 538)
        Me.btnContrato.Name = "btnContrato"
        Me.btnContrato.Size = New System.Drawing.Size(90, 32)
        Me.btnContrato.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnContrato.TabIndex = 223
        Me.btnContrato.Text = "Contrato"
        Me.btnContrato.UseSelectable = True
        Me.btnContrato.UseStyleColors = True
        '
        'btNewBen
        '
        Me.btNewBen.Location = New System.Drawing.Point(20, 16)
        Me.btNewBen.Name = "btNewBen"
        Me.btNewBen.Size = New System.Drawing.Size(90, 32)
        Me.btNewBen.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewBen.TabIndex = 214
        Me.btNewBen.Text = "Nuevo"
        Me.btNewBen.UseSelectable = True
        Me.btNewBen.UseStyleColors = True
        '
        'fgBen
        '
        Me.fgBen.AllowEditing = False
        Me.fgBen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgBen.BackColor = System.Drawing.Color.White
        Me.fgBen.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgBen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgBen.ForeColor = System.Drawing.Color.Black
        Me.fgBen.Location = New System.Drawing.Point(20, 54)
        Me.fgBen.Name = "fgBen"
        Me.fgBen.Rows.Count = 1
        Me.fgBen.Rows.DefaultSize = 22
        Me.fgBen.Size = New System.Drawing.Size(887, 471)
        Me.fgBen.StyleInfo = resources.GetString("fgBen.StyleInfo")
        Me.fgBen.TabIndex = 3
        '
        'MetroButton8
        '
        Me.MetroButton8.Location = New System.Drawing.Point(20, 538)
        Me.MetroButton8.Name = "MetroButton8"
        Me.MetroButton8.Size = New System.Drawing.Size(204, 32)
        Me.MetroButton8.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton8.TabIndex = 222
        Me.MetroButton8.Text = "Autorización de Transferencia"
        Me.MetroButton8.UseSelectable = True
        Me.MetroButton8.UseStyleColors = True
        Me.MetroButton8.Visible = False
        '
        'MetroButton10
        '
        Me.MetroButton10.Location = New System.Drawing.Point(529, 538)
        Me.MetroButton10.Name = "MetroButton10"
        Me.MetroButton10.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton10.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton10.TabIndex = 220
        Me.MetroButton10.Text = "Atras"
        Me.MetroButton10.UseSelectable = True
        Me.MetroButton10.UseStyleColors = True
        '
        'tbCertDPF
        '
        Me.tbCertDPF.BackColor = System.Drawing.Color.White
        Me.tbCertDPF.Controls.Add(Me.MetroButton2)
        Me.tbCertDPF.Controls.Add(Me.MetroButton5)
        Me.tbCertDPF.Controls.Add(Me.btnDel)
        Me.tbCertDPF.Controls.Add(Me.btnEdit)
        Me.tbCertDPF.Controls.Add(Me.btnNew)
        Me.tbCertDPF.Controls.Add(Me.fgRep)
        Me.tbCertDPF.Location = New System.Drawing.Point(4, 22)
        Me.tbCertDPF.Name = "tbCertDPF"
        Me.tbCertDPF.Size = New System.Drawing.Size(925, 613)
        Me.tbCertDPF.TabIndex = 6
        Me.tbCertDPF.Text = "Cambio de Certificado"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(814, 558)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 219
        Me.MetroButton2.Text = "Siguiente"
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(718, 558)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton5.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton5.TabIndex = 217
        Me.MetroButton5.Text = "Atras"
        Me.MetroButton5.UseSelectable = True
        Me.MetroButton5.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(350, 22)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(90, 32)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 216
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        Me.btnDel.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(254, 22)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 32)
        Me.btnEdit.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEdit.TabIndex = 215
        Me.btnEdit.Text = "Modificar"
        Me.btnEdit.UseSelectable = True
        Me.btnEdit.UseStyleColors = True
        Me.btnEdit.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(18, 22)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(230, 32)
        Me.btnNew.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnNew.TabIndex = 214
        Me.btnNew.Text = "Agregar Reposición de Certificado"
        Me.btnNew.UseSelectable = True
        Me.btnNew.UseStyleColors = True
        '
        'fgRep
        '
        Me.fgRep.AllowEditing = False
        Me.fgRep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgRep.BackColor = System.Drawing.Color.White
        Me.fgRep.ColumnInfo = "10,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgRep.ForeColor = System.Drawing.Color.Black
        Me.fgRep.Location = New System.Drawing.Point(18, 60)
        Me.fgRep.Name = "fgRep"
        Me.fgRep.Rows.Count = 1
        Me.fgRep.Rows.DefaultSize = 22
        Me.fgRep.Size = New System.Drawing.Size(886, 485)
        Me.fgRep.StyleInfo = resources.GetString("fgRep.StyleInfo")
        Me.fgRep.TabIndex = 4
        '
        'tbPigRen
        '
        Me.tbPigRen.BackColor = System.Drawing.Color.White
        Me.tbPigRen.Controls.Add(Me.MetroLabel40)
        Me.tbPigRen.Controls.Add(Me.MetroButton6)
        Me.tbPigRen.Controls.Add(Me.fgPig)
        Me.tbPigRen.Location = New System.Drawing.Point(4, 22)
        Me.tbPigRen.Name = "tbPigRen"
        Me.tbPigRen.Size = New System.Drawing.Size(925, 613)
        Me.tbPigRen.TabIndex = 7
        Me.tbPigRen.Text = "Pignoraciones"
        '
        'MetroLabel40
        '
        Me.MetroLabel40.AutoSize = True
        Me.MetroLabel40.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel40.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel40.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel40.Location = New System.Drawing.Point(2, 10)
        Me.MetroLabel40.Name = "MetroLabel40"
        Me.MetroLabel40.Size = New System.Drawing.Size(132, 25)
        Me.MetroLabel40.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel40.TabIndex = 222
        Me.MetroLabel40.Text = "Pignoraciones"
        Me.MetroLabel40.UseCustomBackColor = True
        Me.MetroLabel40.UseCustomForeColor = True
        Me.MetroLabel40.UseStyleColors = True
        '
        'MetroButton6
        '
        Me.MetroButton6.Location = New System.Drawing.Point(815, 569)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton6.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton6.TabIndex = 220
        Me.MetroButton6.Text = "Atras"
        Me.MetroButton6.UseSelectable = True
        Me.MetroButton6.UseStyleColors = True
        '
        'fgPig
        '
        Me.fgPig.AllowEditing = False
        Me.fgPig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgPig.BackColor = System.Drawing.Color.White
        Me.fgPig.ColumnInfo = "10,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgPig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgPig.ForeColor = System.Drawing.Color.Black
        Me.fgPig.Location = New System.Drawing.Point(19, 38)
        Me.fgPig.Name = "fgPig"
        Me.fgPig.Rows.Count = 1
        Me.fgPig.Rows.DefaultSize = 22
        Me.fgPig.Size = New System.Drawing.Size(886, 518)
        Me.fgPig.StyleInfo = resources.GetString("fgPig.StyleInfo")
        Me.fgPig.TabIndex = 22
        '
        'txtPartida
        '
        Me.txtPartida.AcceptsReturn = True
        Me.txtPartida.BackColor = System.Drawing.Color.White
        Me.txtPartida.EditMask = "00000000-0"
        Me.txtPartida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida.Location = New System.Drawing.Point(120, 83)
        Me.txtPartida.MaxLength = 20
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.NumericInput = False
        Me.txtPartida.Size = New System.Drawing.Size(307, 21)
        Me.txtPartida.TabIndex = 4
        Me.txtPartida.Tag = Nothing
        '
        'frmMsAhCuentasDPF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(982, 731)
        Me.Controls.Add(Me.tbSolic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhCuentasDPF"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cuenta Deposito a Plazo Fijo"
        Me.tbSolic.ResumeLayout(False)
        Me.tbDatGral.ResumeLayout(False)
        Me.tbDatGral.PerformLayout()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.c1nRemesa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nRenovacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoApertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatGralII.ResumeLayout(False)
        CType(Me.fgBen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCertDPF.ResumeLayout(False)
        CType(Me.fgRep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbPigRen.ResumeLayout(False)
        Me.tbPigRen.PerformLayout()
        CType(Me.fgPig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, vTipo As String, vConsulta As Boolean, vCancela As Boolean
    Private pTasaVigente As Boolean
    'Nuevas Variables 25/10/2013
    Dim ModificacionTasa As Boolean = False
    Dim ahorros As New wrAhorro.wsLibAhorro

    Public Sub direccionAsociado(dui As String)
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarDomicilios(dui)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    For Each row As DataRow In dts.Tables(0).Rows
                        If row("Estado").Equals(True) Then
                            txtDireccion.Text = row("Direccion").ToString
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
#Region "Grid"
    Protected Sub llenarDGPignoraciones()
        Try
            Dim dts As New DataSet
            dts = ahorro.ConsultarCuentaPignorada("CodPrestamo[Cod. Préstamo],MontoPignorado [Monto Pignorado],porcentajePignora [Porcentaje],Case when Estado = 'N' then 'Activo' else 'Cancelado'end [Estado],fechaInicioPignora[FechaPignoración]", " nocuenta = '" & pNoCuenta & "'", "porcentajePignora", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    fgPig.DataSource = dts.Tables(0)
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Protected Sub llenarDgReposiciones()
        Try
            Dim dts As New DataSet
            dts = ahorro.ConsultarReposicionCertificadosDPF("NoSolicitud,FechaSolicitud,idCertificadoDPFRepone[Certificado Anterior],IdCertificadoDPF [Nuevo No. Certificado],observacion", "nocuenta = '" & pNoCuenta & "'", "NoSolicitud", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    fgRep.DataSource = dts.Tables(0)
                    Me.fgRep.Cols.Item(0).Visible = False
                    Me.fgRep.Cols.Item(1).Width = 100
                    Me.fgRep.Cols.Item(2).Width = 250
                    Me.fgRep.Cols.Item(3).Width = 250
                    Me.fgRep.Cols.Item(4).Width = 500
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Protected Sub llenarDgBeneficiarios()
        Try
            Dim dts As New DataSet
            dts = ahorro.ConsultarReposicionCertificadosDPF("NoSolicitud,FechaSolicitud,idCertificadoDPFRepone[Certificado Anterior],IdCertificadoDPF [Nuevo No. Certificado],observacion", "nocuenta = '" & pNoCuenta & "'", "NoSolicitud", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    fgRep.DataSource = dts.Tables(0)
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Listas "
    Protected Sub llenarCbAutorizacion(ByVal codEmpleado As String, ByVal opcion As Integer, ByVal idAutorizacion As Integer)
        Me.cbAutorizacion.DisplayMember = "Empleado"
        Me.cbAutorizacion.ValueMember = "idAutorizacion"
        Dim dts As New DataSet
        dts = ahorros.consultarAhAutorizacionTasasDpf(codEmpleado, opcion, idAutorizacion)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbAutorizacion.DataSource = dts.Tables(0)
        End If
    End Sub
    Protected Sub llenarEjecutivos()
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            cbEjecutivo.DataSource = dts.Tables(0)
            cbEjecutivo.DisplayMember = "Nombres"
            cbEjecutivo.ValueMember = "CodEjecMercadeo"
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Protected Sub llenarSucursales()
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarSucursales("codSucursal,nom_sucursal", "", "nom_sucursal", sUsuario, sPassword, sSucursal)
            Me.cbSucursal.DataSource = dts.Tables(0)
            Me.cbSucursal.DisplayMember = "nom_sucursal"
            Me.cbSucursal.ValueMember = "codSucursal"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub llenarCuentasPagoInt()
        Dim dts As New DataSet
        Me.cbNocuenta.DisplayMember = "NoCuenta"
        Me.cbNocuenta.ValueMember = "NoCuenta"
        dts = ahorro.ConsultarCuentaAhorroTipoAhorro("a.NoCuenta ", "Left(a.CodTipoAhorro,1)='3' and a.Dui='" & Me.txtDui.Value & "' and a.Estado= 'A' ", "a.NoCuenta", sUsuario, sPassword, sSucursal)

        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbNocuenta.DataSource = dts.Tables(0)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Asociado no posee cuenta de ahorro, por favor crear cuenta de ahorro.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Me.Close()
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Asociado no posee cuenta de ahorro, por favor crear cuenta de ahorro.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Me.Close()
        End If

        'CAMBIO APLICADO 25/06/2020 YA QUE NO PROCEDE VALIDAR LAS CUENTAS DE AHORRO DE DPF, EN LA CREACION DE UN DPF
        ' Dim dts As New DataSet

        'dts = ahorro.ConsultarCuentaAhorroDPF("NumCuentaBancoEntregaInt ", "noCuenta='" & pNoCuenta & "'", "NoCuenta", sUsuario, sPassword, sSucursal)

        'If dts.Tables.Count > 0 Then
        '    If dts.Tables(0).Rows.Count > 0 Then
        '        Me.cbNocuenta.DataSource = Nothing
        '        Me.cbNocuenta.Items.Clear()
        '        Me.cbNocuenta.DataSource = dts.Tables(0)
        '        Me.cbNocuenta.DisplayMember = "NumCuentaBancoEntregaInt"
        '        Me.cbNocuenta.ValueMember = "NumCuentaBancoEntregaInt"
        '        Me.cbNocuenta.Enabled = False
        '    Else
        '        MetroFramework.MetroMessageBox.Show(Me, "Asociado no posee cuenta de ahorro, por favor crear cuenta de ahorro.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        '        Me.Close()
        '    End If
        'Else
        '    MetroFramework.MetroMessageBox.Show(Me, "Asociado no posee cuenta de ahorro, por favor crear cuenta de ahorro.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        '    Me.Close()
        'End If
    End Sub
    Public Sub llenarEstadoCivil()
        Dim dts As New DataSet
        Me.cbEstadoCivil.DisplayMember = "Descripcion"
        Me.cbEstadoCivil.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoCivil,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoCivil.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub llenarParentesco()
        Dim dts As New DataSet
        dts = asociados.ConsultarParentescos("CodParentesco,descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
        cbParentescoTitular2.DisplayMember = "descripcion"
        cbParentescoTitular2.ValueMember = "codparentesco"
        cbParentescoTitular2.DataSource = dts.Tables(0)
    End Sub
    Public Sub llenarTipoAhorro()
        Dim dts As New DataSet
        dts = ahorro.consultarTiposAhorrosActivos("left(a.codtipoAhorro,1) in ('" & sifLib.Ahorro.clsAhorros.tiposAhorro.dpf & "')")
        cbTipoAhorro.DataSource = dts.Tables(0)
        cbTipoAhorro.ValueMember = "codTipoAhorro"
        cbTipoAhorro.DisplayMember = "descripcion"
    End Sub
#End Region

    Protected Sub deshabilitarControlesUpdate()
        cbTipoAhorro.Enabled = False
        txtNoCuenta.Enabled = False
        c1nPlazo.Enabled = False
        txtNoCertificado.Enabled = False
        c1nMontoApertura.Enabled = False
        c1nCaja.Enabled = False
        c1nRemesa.Enabled = False
        c1nRenovacion.Enabled = False
        c1nTransferencia.Enabled = False
        c1nTasa.Enabled = False
        txtestado.Enabled = False
        btTasaPactada.Enabled = False
        btEdit.Enabled = False
        btTasaPactada.Enabled = False
        BtnCtaAhorro.Enabled = False
        MetroButton13.Enabled = False
        cbFormaPagoInt.Enabled = False
        cbNocuenta.Enabled = False
        dtpFecIniApertura.Enabled = False
        dtpFechaRenovacion.Enabled = False
        dtpFecVenc.Enabled = False
        dtpFechaCapitalizacion.Enabled = False
        dtpFecCanc.Enabled = False
        cbEjecutivo.Enabled = False
        cbSucursal.Enabled = False
    End Sub
    Private Sub frmMsAhCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim oPerif As New wrAhorro.wsLibAhorro, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Dim oAsoc As New wrAsociados.wsLibAsoc, x As Integer, dr As DataRow, FechaNac As Date
            Dim oCred As New wrCredito.wsLibCred, oPrest As New wrPrestamo.wsLibPrest
            Dim oPl As New wrPlanilla.wsLibPlanilla, oBanco As New wrBancos.wsLibBancos

            Me.txtDui.Focus()

            Me.cbDoc.SelectedIndex = 0
            'Llenamos listas
            llenarParentesco()
            llenarSucursales()
            llenarEjecutivos()
            llenarEstadoCivil()
            llenarTipoAhorro()
            '=====================================================
            llenarCbAutorizacion("", 1, 0)
            cbAutorizacion.Enabled = False
            '=====================================================
            ' controles inhabilidatos
            txtNoSocio.Enabled = False
            txtNombres.Enabled = False
            txtApe1.Enabled = False
            txtApe2.Enabled = False
            txtApe3.Enabled = False
            cbEstadoCivil.Enabled = False
            dtpFecNac.Enabled = False
            txtDireccion.Enabled = False
            txtNoCuenta.Enabled = False

            txtestado.Enabled = False
            dtpFecIniApertura.Enabled = False
            dtpFechaRenovacion.Enabled = False
            dtpFecCanc.Enabled = False
            dtpFechaCapitalizacion.Enabled = False
            dtpFecVenc.Enabled = False

            txtestado.Text = "DIGITADO"

            If Me.pAccion = "Modificar" Then
                deshabilitarControlesUpdate()
                llenarDGPignoraciones()
                llenarDgReposiciones()
                ds = oPerif.ConsultarCuentaAhorro("*", "NoCuenta='" & pNoCuenta & "' ", "NoCuenta", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    '==========================================================================
                    If IsDBNull(Filas.Item(0)("idAutorizacion")) = False Then
                        ModificacionTasa = True
                        Me.cbAutorizacion.SelectedValue = Filas.Item(0)("idAutorizacion")
                        Me.cbAutorizacion.Enabled = False
                    End If
                    '==========================================================================
                    Me.txtDui.Value = IIf(IsDBNull(Filas.Item(0)("Dui")), "", Filas.Item(0)("Dui"))
                    llenarCuentasPagoInt()
                    Me.txtNoCuenta.Text = pNoCuenta
                    '================================================================================================================================
                    'Fechas 

                    dtpFechaRenovacion.Value = IIf(IsDBNull(Filas.Item(0)("FechaApertura")), "01/01/2000", Filas.Item(0)("FechaApertura"))
                    dtpFecIniApertura.Value = IIf(IsDBNull(Filas.Item(0)("FechaInicioApertura")), "01/01/2000", Filas.Item(0)("FechaInicioApertura"))
                    dtpFecVenc.Value = IIf(IsDBNull(Filas.Item(0)("FechaVencimiento")), "01/01/2000", Filas.Item(0)("FechaVencimiento"))
                    dtpFechaCapitalizacion.Value = IIf(IsDBNull(Filas.Item(0)("FechaCapitaliza")), "01/01/2000", Filas.Item(0)("FechaCapitaliza"))
                    dtpFecCanc.Value = IIf(IsDBNull(Filas.Item(0)("FechaCancelacion")), "01/01/2000", Filas.Item(0)("FechaCancelacion"))
                    '================================================================================================================================
                    'Listas
                    Dim fechaHoy As Date = DateTime.Now.Date
                    cbTipoAhorro.SelectedValue = pCodTipoAhorro
                    cbEjecutivo.SelectedValue = IIf(IsDBNull(Filas.Item(0)("CodEjecutivo")), "", Filas.Item(0)("CodEjecutivo"))
                    If Filas.Item(0)("CodParentesco") Is DBNull.Value = False Then
                        Me.cbParentescoTitular2.SelectedValue = Filas.Item(0)("CodParentesco")
                    End If
                    cbSucursal.SelectedValue = IIf(IsDBNull(Filas.Item(0)("codSucursal")), Now, Filas.Item(0)("codSucursal"))
                    If Filas.Item(0)("Estado").Equals("A") Then
                        txtestado.Text = "Activo"
                        If dtpFechaRenovacion.Value = fechaHoy Then
                            btEdit.Enabled = True
                            btTasaPactada.Enabled = True
                            MetroButton13.Enabled = True
                            BtnCtaAhorro.Enabled = True
                        End If
                    ElseIf Filas.Item(0)("Estado").Equals("B") Then
                        txtestado.Text = "Bloqueada"
                    ElseIf Filas.Item(0)("Estado").Equals("C") Then
                        txtestado.Text = "Cancelada"
                    ElseIf Filas.Item(0)("Estado").Equals("D") Then
                        btEdit.Enabled = True
                        btTasaPactada.Enabled = True
                        MetroButton13.Enabled = True
                        BtnCtaAhorro.Enabled = True
                        txtestado.Text = "Digitada"
                    ElseIf Filas.Item(0)("Estado").Equals("I") Then
                        txtestado.Text = "Inhabilitada"
                    Else
                        txtestado.Text = "N/A"
                    End If
                    Me.c1nMontoApertura.Value = IIf(IsDBNull(Filas.Item(0)("MontoApertura")), 0, Filas.Item(0)("MontoApertura"))
                    Me.c1nPlazo.Value = IIf(IsDBNull(Filas.Item(0)("Plazo")), 0, Filas.Item(0)("Plazo"))
                    Me.c1nTasa.Value = IIf(IsDBNull(Filas.Item(0)("TasaInteres")), 0, Filas.Item(0)("TasaInteres"))
                    'Me.dtpFecIniApertura.Value = IIf(IsDBNull(Filas.Item(0)("FechaPrimeraCuota")), Now, Filas.Item(0)("FechaPrimeraCuota"))
                    Me.cbDoc.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("TipoDocTit2")), 0, Filas.Item(0)("TipoDocTit2"))
                    Me.txtTitular2.Text = IIf(IsDBNull(Filas.Item(0)("Titular2")), "", Filas.Item(0)("Titular2"))
                    Me.txtPartida.Value = IIf(IsDBNull(Filas.Item(0)("PartidaNacTitular2")), "", Filas.Item(0)("PartidaNacTitular2"))
                    Me.txtObs.Text = IIf(IsDBNull(Filas.Item(0)("Observacion")), "", Filas.Item(0)("Observacion"))
                    Me.txtNoCertificado.Text = IIf(IsDBNull(Filas.Item(0)("IdCertificadoDPF")), "", Filas.Item(0)("IdCertificadoDPF"))
                    Me.c1nCaja.Value = IIf(IsDBNull(Filas.Item(0)("MontoCaja")), 0, Filas.Item(0)("MontoCaja"))
                    Me.c1nTransferencia.Value = IIf(IsDBNull(Filas.Item(0)("MontoTransferencia")), 0, Filas.Item(0)("MontoTransferencia"))
                    Me.c1nRenovacion.Value = IIf(IsDBNull(Filas.Item(0)("MontoRenovacion")), 0, Filas.Item(0)("MontoRenovacion"))
                    Me.c1nRemesa.Value = IIf(IsDBNull(Filas.Item(0)("MontoRemesa")), 0, Filas.Item(0)("MontoRemesa"))
                    Me.dtpFecIniApertura.Enabled = False
                    Me.c1nMontoApertura.Enabled = False
                    Me.c1nCaja.Enabled = False
                    Me.c1nTransferencia.Enabled = False
                    Me.c1nRenovacion.Enabled = False
                    Me.c1nRemesa.Enabled = False
                    ActualizaGridBen()
                    ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in('2','1') ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then

                        txtNombres.Text = IIf((Filas.Item(0)("Nombres")) Is DBNull.Value, "", CStr(Filas.Item(0)("Nombres")))
                        txtApe1.Text = IIf((Filas.Item(0)("Apellido1")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido1")).Trim)
                        txtApe2.Text = IIf((Filas.Item(0)("Apellido2")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido2")))
                        txtApe3.Text = IIf((Filas.Item(0)("ApellidoCas")) Is DBNull.Value, "", Filas.Item(0)("ApellidoCas"))
                        direccionAsociado(txtDui.Value)
                        If Filas.Item(0)("codEstadoCivil") Is DBNull.Value = False Then
                            cbEstadoCivil.SelectedValue = Filas.Item(0)("codEstadoCivil")
                        End If

                        dtpFecNac.Value = IIf((Filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, Filas.Item(0)("Fecha_Nac"))
                    End If
                    ds = oPerif.ConsultarCertificadosDPF("FormaAsentaInt,NumCuentaBancoEntregaInt", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' ", "IdCertificadoDPF", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        cbFormaPagoInt.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("FormaAsentaInt")), "", Filas.Item(0)("FormaAsentaInt"))
                        'aqui voy
                        'cbNocuenta.SelectedValue = IIf(IsDBNull(Filas.Item(0)("NumCuentaBancoEntregaInt")), "", Filas.Item(0)("NumCuentaBancoEntregaInt"))
                    End If
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub ActualizaGridBen()

        Dim oAh As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarBeneficiarios("Correlativo,concat(rtrim(Nombres),' ',rtrim(Apellido1),' ',rtrim(Apellido2),' ',rtrim(ApellidoCas))[Nombre],Porcentaje ", "NoCuenta='" & pNoCuenta & "' ", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgBen.DataSource = ds.Tables(0)
            Me.fgBen.Cols.Item(0).Caption = "Correlativo"
            Me.fgBen.Cols.Item(0).Visible = False

            Me.fgBen.Cols.Item(1).Caption = "Nombre Beneficiario"
            Me.fgBen.Cols.Item(2).Caption = "Porcentaje"



            Me.fgBen.Cols.Item(1).Width = 500
            Me.fgBen.Cols.Item(2).Width = 100

            If Me.fgBen.Row <> -1 Then
                Me.btEditBen.Enabled = True
                If vConsulta = True Then
                    Me.btDelBen.Enabled = False
                Else
                    Me.btDelBen.Enabled = True
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub c1nTasa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub


    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Try
            Dim ofrm As New frmAGenerico
            ofrm.Text = "Buscar Asociados"
            Dim Filas As Data.DataRowCollection
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2", "EstadoIngreso in('2','1') and EstadoAsociado='25'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtDui.Value = ofrm.Resultado.Trim
            Me.txtTitular2.Focus()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtDui.Text.Trim = "" Then
                    txtDui_DoubleClick(sender, e)
                Else
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                    ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') and EstadoAsociado='25' ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then

                        Me.txtTitular2.Focus()

                    Else
                        txtDui_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub
    Dim digito As Integer
    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus

        Try
            If txtDui.Text.Trim <> "" Then

                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') and EstadoAsociado='25' ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then

                    txtNombres.Text = IIf((Filas.Item(0)("Nombres")) Is DBNull.Value, "", CStr(Filas.Item(0)("Nombres")))
                    txtApe1.Text = IIf((Filas.Item(0)("Apellido1")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido1")).Trim)
                    txtApe2.Text = IIf((Filas.Item(0)("Apellido2")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido2")))
                    txtApe3.Text = IIf((Filas.Item(0)("ApellidoCas")) Is DBNull.Value, "", Filas.Item(0)("ApellidoCas"))
                    direccionAsociado(txtDui.Text)
                    If Filas.Item(0)("codEstadoCivil") Is DBNull.Value = False Then
                        cbEstadoCivil.SelectedValue = Filas.Item(0)("codEstadoCivil")
                    End If
                    dtpFecNac.Value = IIf((Filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, Filas.Item(0)("Fecha_Nac"))
                    txtNoSocio.Text = IIf((Filas.Item(0)("NoSocio")) Is DBNull.Value, "", Filas.Item(0)("NoSocio"))
                    Me.txtTitular2.Focus()
                    llenarCuentasPagoInt()
                End If

            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub cbDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDoc.SelectedIndexChanged
        If cbDoc.SelectedIndex = 0 Then
            Me.txtPartida.EditMask = "00000000-0"
        ElseIf cbDoc.SelectedIndex = 1 Or cbDoc.SelectedIndex = 2 Then
            Me.txtPartida.EditMask = "0000-000000-000-0"
        Else
            Me.txtPartida.EditMask = ""
        End If
    End Sub
    Private Sub fgBen_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgBen.DoubleClick
        MetroButton2_Click_1(sender, e)
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
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            Dim oPerif As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New DataSet
            Dim frm As frmMsAhRepCert = New frmMsAhRepCert
            frm.pNoCuenta = Me.pNoCuenta
            frm.pCodTipoAhorro = Me.pCodTipoAhorro
            frm.pNoCertificado = Me.txtNoCertificado.Text.Trim
            frm.pAccion = "Guardar"
            frm.btnSaveTb4.Text = "&Guardar"
            frm.ShowDialog()
            llenarDgReposiciones()
            Dim dts As New DataSet
            dts = ahorro.ConsultarCuentaAhorro("idCertificadoDpf", "nocuenta = '" & txtNoCuenta.Text & "'", "", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    txtNoCertificado.Text = dts.Tables(0).Rows(0).Item(0)
                End If
            End If

            'ds = oPerif.ConsultarReposicionCertificadosDPF("NoSolicitud as No_Solicitud,FechaSolicitud as Fecha,IdCertificadoDPF as No_Certificado,Fecha as Fecha_Repos,Causa,FechaPublicacion1 as Fecha_Pub1,PeriodicoPublic1 as Periodico_Pub1,NoPaginaPublic1 as NoPag1,FechaPublicacion2 as Fecha_Pub2,PeriodicoPublic2 as Periodico_Pub2,NoPaginaPublic2 as NoPag2,FechaPublicacion3 as Fecha_Pub3,PeriodicoPublic3 as Periodico_Pub3,NoPaginaPublic3 as NoPag3,Estado", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' ", "Fecha desc", sUsuario, sPassword, sSucursal)
            'fgRep.DataSource = ds.Tables(0)
            'If ds.Tables(0).Rows.Count > 0 Then Me.txtNoCertificado.Text = Me.fgRep.Item(Me.fgRep.Row, "No_Certificado")
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim oPerif As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New DataSet
        Try
            If Me.fgRep.Row <> -1 Then
                If Me.fgRep.Item(Me.fgRep.Row, "Estado") = "P" Then Exit Sub
                Dim frm As frmMsAhRepCert = New frmMsAhRepCert
                frm.pNoCuenta = Me.pNoCuenta
                frm.pNoCertificado = Me.txtNoCertificado.Text.Trim
                '  frm.txtNoSolicitud.ReadOnly = True
                frm.pCodTipoAhorro = Me.pCodTipoAhorro
                frm.pCorrelativo = Me.fgRep.Item(Me.fgRep.Row, "No_Solicitud")
                frm.pAccion = "Modificar"
                If Me.vConsulta = True Then frm.btnSaveTb4.Visible = False
                frm.btnSaveTb4.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ds = oPerif.ConsultarReposicionCertificadosDPF("NoSolicitud as No_Solicitud,FechaSolicitud as Fecha,IdCertificadoDPF as No_Certificado,Fecha as Fecha_Repos,Causa,FechaPublicacion1 as Fecha_Pub1,PeriodicoPublic1 as Periodico_Pub1,NoPaginaPublic1 as NoPag1,FechaPublicacion2 as Fecha_Pub2,PeriodicoPublic2 as Periodico_Pub2,NoPaginaPublic2 as NoPag2,FechaPublicacion3 as Fecha_Pub3,PeriodicoPublic3 as Periodico_Pub3,NoPaginaPublic3 as NoPag3,Estado", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' ", "Fecha desc", sUsuario, sPassword, sSucursal)
                fgRep.DataSource = ds.Tables(0)
                Me.txtNoCertificado.Text = Me.fgRep.Item(Me.fgRep.Row, "No_Certificado")
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Dim ds As New DataSet
            If Me.fgRep.Row <> -1 Then
                If Me.fgRep.Item(Me.fgRep.Row, "Estado") = "P" Then Exit Sub
                If MsgBox("¿Desea eliminar el Registro No. " & Trim(Me.fgRep.Item(Me.fgRep.Row, "No_Solicitud")) & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Registro") = MsgBoxResult.Yes Then
                    Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oAh.EliminarReposicionCertificadosDPF(Me.fgRep.Item(Me.fgRep.Row, "No_Solicitud"), sUsuario, sPassword, sSucursal)
                    ds = oAh.ConsultarReposicionCertificadosDPF("NoSolicitud as No_Solicitud,FechaSolicitud as Fecha,IdCertificadoDPF as No_Certificado,Fecha as Fecha_Repos,Causa,FechaPublicacion1 as Fecha_Pub1,PeriodicoPublic1 as Periodico_Pub1,NoPaginaPublic1 as NoPag1,FechaPublicacion2 as Fecha_Pub2,PeriodicoPublic2 as Periodico_Pub2,NoPaginaPublic2 as NoPag2,FechaPublicacion3 as Fecha_Pub3,PeriodicoPublic3 as Periodico_Pub3,NoPaginaPublic3 as NoPag3,Estado", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' ", "Fecha desc", sUsuario, sPassword, sSucursal)
                    fgRep.DataSource = ds.Tables(0)
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton3_Click_1(sender As Object, e As EventArgs) Handles btNewBen.Click
        Try
            Dim frm As frmMsAhBeneficiarios = New frmMsAhBeneficiarios
            frm.pNoCuenta = Me.pNoCuenta
            frm.pCodTipoAhorro = Me.pCodTipoAhorro
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridBen()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton2_Click_1(sender As Object, e As EventArgs) Handles btEditBen.Click
        Try
            If Me.fgBen.Row <> -1 Then
                Dim frm As frmMsAhBeneficiarios = New frmMsAhBeneficiarios
                frm.pNoCuenta = Me.pNoCuenta
                frm.pCodTipoAhorro = Me.pCodTipoAhorro
                frm.pCorrelativo = Me.fgBen.Item(Me.fgBen.Row, "Correlativo")
                frm.pAccion = "Modificar"
                If vConsulta = True Then frm.btnGuardar1.Visible = False
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridBen()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btDelBen.Click
        Try
            If Me.fgBen.Row <> -1 Then
                If MetroFramework.MetroMessageBox.Show(Me, "¿Desea eliminar el Beneficiario No. " & Me.fgBen.Item(Me.fgBen.Row, "Correlativo") & "?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oAh.EliminarBeneficiarios("Correlativo=" & Me.fgBen.Item(Me.fgBen.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridBen()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub
    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub
    Private Sub MetroButton3_Click_2(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub
    Protected Function validaciones() As Boolean
        If Me.c1nMontoApertura.Value <= 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "Monto de apertura debe ser mayor a cero", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Me.c1nTasa.Value <= 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "Tasa de interes debe ser mayor a cero", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Me.c1nPlazo.Value < 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "El Plazo no puede tener un valor negativo.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Dim dts As New DataSet
        dts = ahorro.ConsultarParametros("*", "CodTipoAhorro='" & cbTipoAhorro.SelectedValue & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
        If dts.Tables(0).Rows.Count > 0 Then
            If Val(c1nMontoApertura.Value) < Val(dts.Tables(0).Rows(0).Item("MontoAperturaMinima")) And (CDate(Me.dtpFecIniApertura.Value.ToShortDateString) >= dts.Tables(0).Rows(0).Item("ValidoDesdeMin") And CDate(Me.dtpFecIniApertura.Value.ToShortDateString) <= dts.Tables(0).Rows(0).Item("ValidoHastaMin")) Then
                MetroFramework.MetroMessageBox.Show(Me, "El Monto de Apertura no puede ser menor que el Monto de Apertura Mínima.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            If Val(c1nMontoApertura.Value) > Val(dts.Tables(0).Rows(0).Item("MontoAperturaMaxima")) And (CDate(Me.dtpFecIniApertura.Value.ToShortDateString) >= dts.Tables(0).Rows(0).Item("ValidoDesdeMax") And CDate(Me.dtpFecIniApertura.Value.ToShortDateString) <= dts.Tables(0).Rows(0).Item("ValidoHastaMax")) Then
                MetroFramework.MetroMessageBox.Show(Me, "El Monto de Apertura no puede ser menor que el Monto de Apertura Mínima.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If
        Dim detalleApertura As Double
        detalleApertura = c1nCaja.Value + c1nRemesa.Value + c1nRenovacion.Value + c1nTransferencia.Value
        If detalleApertura <> c1nMontoApertura.Value Then
            MetroFramework.MetroMessageBox.Show(Me, "Monto de apertura no coincide con detalle, por favor verificar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    Private Sub btnSaveTb1_Click(sender As Object, e As EventArgs) Handles btnSaveTb1.Click
        Try
            Dim pCampos As String
            Dim camposCertificado As String
            Dim valoresCertificado As String = ""
            Dim pValores As String
            Dim dr As DataRow
            Dim pDocTitular As String
            Dim ds As New DataSet
            Dim Filas As DataRowCollection
            Dim pPignorado As String
            Dim vParentesco As String
            Dim CtaPagoInt As String
            If PCtaTercero = True Then
                CtaPagoInt = cbNocuenta.SelectedItem.ToString
            Else
                CtaPagoInt = cbNocuenta.SelectedValue
            End If
            If CtaPagoInt = "" Then
                Exit Sub
                MsgBox("No Selecciono la Cuenta del Pago de los Intereses", MsgBoxStyle.Information)
            End If
            ds = asociados.ConsultarAsociado("dui", "Dui='" & Trim(Me.txtDui.Text) & "' and EstadoAsociado='25' and EstadoIngreso in ('2','1') ", "DUI", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
            Else
                MetroFramework.MetroMessageBox.Show(Me, "El Dui del Asociado no coincide con el Maestro de Asociados. Verifique e intente de nuevo.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If validaciones() = False Then
                Exit Sub
            End If
            If MetroFramework.MetroMessageBox.Show(Me, "Continuar con el ingreso/actualización de la cuenta No: " & txtNoCuenta.Text.Trim & vbCrLf & "Por un Monto de: " & c1nMontoApertura.Value.ToString & vbCrLf & "Con número de certificado: " & txtNoCertificado.Text.Trim, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Me.btnSaveTb1.Text = "&Guardar" Then
                    cbEjecutivo_Validated(sender, e)
                    txtNoCuenta.Text = ahorro.generarNoCuentaTipoAhorro(txtDui.Value.Trim, cbTipoAhorro.SelectedValue, sUsuario, sPassword, sSucursal)
                    digito = ahorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)

                    Dim dtsVenc As New DataSet
                    dtsVenc = ahorro.ConsultarParametros("plazoMaximo", " codtipoahorro = '" & cbTipoAhorro.SelectedValue & "'", "", sUsuario, sPassword, sSucursal)
                    dtpFecVenc.Value = Now.AddDays(dtsVenc.Tables(0).Rows(0).Item(0) - 1)

                    cbFormaPagoInt_Validated(sender, e)
                    Me.dtpFecIniApertura.Value = Me.dtpFecIniApertura.Value
                    pPignorado = "N"
                    '==========================================
                    If ModificacionTasa = True Then
                        pCampos = "Dui,CodTipoAhorro,NoCuenta,CodPrestamo,Titular2,PartidaNacTitular2,NoLibreta," &
                        "FechaInicioApertura,FechaApertura,FechaVencimiento,FechaPrimeraCuota,MontoApertura,Plazo, " &
                        "Monto,Cuota,NoCuotas,TasaInteres,CodEjecutivo,Estado,Observacion,Pignorado,Saldo_CuentaAhorro, " &
                        "SaldoDisponible_CuentaAhorro,TipoDocTit2,IdCertificadoDPF,Prorrogado,SaldoInteresPendiente, " &
                        "CodParentesco,Digito,CodEjecApertura,MontoCaja,MontoTransferencia,MontoRenovacion, " &
                        "MontoRemesa,NoSocio,idAutorizacion,FechaCapitaliza,usuarioIngresa,FechaIngreso,pcIngresa"
                        pValores = "'" & Trim(Me.txtDui.Text) & "','" & Trim(Me.cbTipoAhorro.SelectedValue) &
                        "','" & Trim(Me.txtNoCuenta.Text) & "','','" & Trim(Me.txtTitular2.Text) &
                        "','" & pDocTitular & "','','" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") &
                        "','" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") &
                        "','" & Format(Date.Today, "dd/MM/yyyy") & "'," & Val(Me.c1nMontoApertura.Value) &
                        "," & c1nPlazo.Value & ",0,0,0," & c1nTasa.Value &
                        ",'" & Trim(cbEjecutivo.SelectedValue) & "','D','" & Trim(Me.txtObs.Text) &
                        "','" & pPignorado & "',0,0,'" & Me.cbDoc.SelectedIndex &
                        "','" & Me.txtNoCertificado.Text.Trim & "','N',0,'" & vParentesco &
                        "','" & digito &
                        "','" & cbEjecutivo.SelectedValue &
                        "'," & Val(c1nCaja.Value) & "," & Val(c1nTransferencia.Value) &
                        "," & Val(c1nRenovacion.Value) & "," & Val(c1nRemesa.Value) &
                        ",'" & Me.txtNoSocio.Text.Trim &
                        "', " & Me.cbAutorizacion.SelectedValue & ", '" & dtpFechaCapitalizacion.Value.ToShortDateString & "', '" & sUsuario & "','" & Now.ToShortDateString & "','" & sPC & "' "
                    Else
                        pCampos = "Dui,CodTipoAhorro,NoCuenta,CodPrestamo,Titular2,PartidaNacTitular2,NoLibreta," &
                        "FechaInicioApertura,FechaApertura,FechaVencimiento,FechaPrimeraCuota,MontoApertura,Plazo, " &
                        "Monto,Cuota,NoCuotas,TasaInteres,CodEjecutivo,Estado,Observacion,Pignorado,Saldo_CuentaAhorro, " &
                        "SaldoDisponible_CuentaAhorro,TipoDocTit2,IdCertificadoDPF,Prorrogado,SaldoInteresPendiente, " &
                        "CodParentesco,Digito,CodEjecApertura,MontoCaja,MontoTransferencia,MontoRenovacion, " &
                        "MontoRemesa,NoSocio,FechaCapitaliza,usuarioIngresa,FechaIngreso,pcIngresa"
                        pValores = "'" & Trim(Me.txtDui.Text) & "','" & Trim(Me.cbTipoAhorro.SelectedValue) &
                        "','" & Trim(Me.txtNoCuenta.Text) & "','','" & Trim(Me.txtTitular2.Text) &
                        "','" & pDocTitular & "','','" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") &
                        "','" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") &
                        "','" & Format(Date.Today, "dd/MM/yyyy") & "'," & Val(Me.c1nMontoApertura.Value) &
                        "," & c1nPlazo.Value & ",0,0,0," & c1nTasa.Value &
                        ",'" & Trim(cbEjecutivo.SelectedValue) & "','D','" & Trim(Me.txtObs.Text) &
                        "','" & pPignorado & "',0,0,'" & Me.cbDoc.SelectedIndex &
                        "','" & txtNoCertificado.Text.Trim & "','N',0,'" & vParentesco &
                        "','" & digito &
                        "','" & cbEjecutivo.SelectedValue &
                        "'," & Val(c1nCaja.Value) & "," & Val(c1nTransferencia.Value) &
                        "," & Val(c1nRenovacion.Value) & "," & Val(c1nRemesa.Value) &
                        ",'" & Me.txtNoSocio.Text.Trim & "', '" & dtpFechaCapitalizacion.Value.ToShortDateString & "' , '" & sUsuario & "','" & Now.ToShortDateString & "','" & sPC & "'  "

                    End If

                    'Ingresamos valores del certificado
                    camposCertificado = "IdCertificadoDPF,CodTipoAhorro,NoCuenta,Fecha,monto,plazo,TasaInteres,FormaEntregaInt,FormaAsentaInt,NumCuentaBancoEntregaInt"
                    valoresCertificado = "'" & txtNoCertificado.Text.Trim & "', '" & cbTipoAhorro.SelectedValue &
                        "','" & txtNoCuenta.Text.Trim & "','" & dtpFecIniApertura.Value.ToShortDateString &
                        "'," & c1nMontoApertura.Value & ",'" & c1nPlazo.Value & "','" & c1nTasa.Value &
                        "', '" & cbFormaPagoInt.SelectedIndex & "','" & cbFormaPagoInt.SelectedIndex &
                        "', '" & CtaPagoInt & "' "
                    '==========================================

                    If ahorro.insertarCuentaDPF(pCampos, pValores, sUsuario, sPassword, sSucursal, camposCertificado, valoresCertificado) Then
                        MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtDui.Enabled = False
                        Me.txtNombres.Enabled = False
                        Me.txtApe1.Enabled = False
                        Me.txtApe2.Enabled = False
                        Me.cbTipoAhorro.Enabled = False
                        Me.txtNoCuenta.Enabled = False
                        Me.btnNew.Enabled = True
                        Me.btnEdit.Enabled = True
                        Me.btDelBen.Enabled = True
                        Me.tbCertDPF.Enabled = True

                        Me.dtpFecIniApertura.Enabled = False

                        btnSaveTb1.Text = "&Modificar"
                        Me.pCodTipoAhorro = Trim(cbTipoAhorro.SelectedValue)
                        Me.pNoCuenta = Trim(Me.txtNoCuenta.Text)
                        Me.btEdit.Visible = False
                        Me.txtNoCertificado.Size = New Size(144, 21)
                        Me.txtNoCertificado.ReadOnly = True
                        Me.tbSolic.SelectedIndex = 1
                        vCancela = True
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                ElseIf Me.btnSaveTb1.Text = "&Modificar" Then
                    cbEjecutivo_Validated(sender, e)
                    cbFormaPagoInt_Validated(sender, e)
                    If ModificacionTasa = True Then
                        pCampos = "Titular2='" & Trim(Me.txtTitular2.Text) &
                                       "',PartidaNacTitular2='" & pDocTitular &
                                       "',Plazo=" & Val(Me.c1nPlazo.Value) &
                                       ",TasaInteres=" & Val(Me.c1nTasa.Value) &
                                       ",CodEjecutivo='" & cbEjecutivo.SelectedValue &
                                       "',Observacion='" & Trim(Me.txtObs.Text) &
                                       "',TipoDocTit2='" & Me.cbDoc.SelectedIndex &
                                       "',IdCertificadoDPF='" & Me.txtNoCertificado.Text.Trim &
                                       "',Prorrogado='N',CodParentesco='" & vParentesco &
                                       "',CodEjecApertura='" & cbEjecutivo.SelectedValue &
                                       "',MontoCaja=" & Val(c1nCaja.Value) &
                                       ",MontoTransferencia=" & Val(c1nTransferencia.Value) &
                                       ",MontoRenovacion=" & Val(c1nRenovacion.Value) &
                                       ",MontoRemesa=" & Val(c1nRemesa.Value) &
                                       ",idAutorizacion = '" & Me.cbAutorizacion.SelectedValue &
                                       "', usuarioModifica='" & sUsuario &
                                       "',FechaModifica='" & Now.ToShortDateString &
                                       "', pcModifica= '" & sPC &
                                       "',FechaCapitaliza = '" & dtpFechaCapitalizacion.Value.ToShortDateString &
                                       "', codSucursal = '" & cbSucursal.SelectedValue & "' "

                    Else
                        pCampos = "Titular2='" & Trim(Me.txtTitular2.Text) &
                                       "',PartidaNacTitular2='" & pDocTitular &
                                       "',Plazo=" & Val(Me.c1nPlazo.Value) &
                                       ",TasaInteres=" & Val(Me.c1nTasa.Value) &
                                       ",CodEjecutivo='" & cbEjecutivo.SelectedValue &
                                       "',Observacion='" & Trim(Me.txtObs.Text) &
                                       "',TipoDocTit2='" & Me.cbDoc.SelectedIndex &
                                       "',IdCertificadoDPF='" & Me.txtNoCertificado.Text.Trim &
                                       "',Prorrogado='N',CodParentesco='" & vParentesco &
                                       "',CodEjecApertura='" & cbEjecutivo.SelectedValue &
                                       "',MontoCaja=" & Val(c1nCaja.Value) &
                                       ",MontoTransferencia=" & Val(c1nTransferencia.Value) &
                                       ",MontoRenovacion=" & Val(c1nRenovacion.Value) &
                                       ",MontoRemesa=" & Val(c1nRemesa.Value) &
                                       " ,usuarioModifica='" & sUsuario &
                                       "',FechaModifica='" & Now.ToShortDateString &
                                       "',pcModifica= '" & sPC &
                                       "',FechaCapitaliza = '" & dtpFechaCapitalizacion.Value.ToShortDateString &
                                       "',codSucursal = '" & cbSucursal.SelectedValue & "' "


                    End If

                    If ahorro.ModificarCuentaAhorro(pNoCuenta, pCodTipoAhorro, pCampos, sUsuario, sPassword, sSucursal) = True Then
                        If modificarFormaPagoIntereses = True Then
                            Dim camposValores As String = "FormaEntregaInt ='" & cbFormaPagoInt.SelectedIndex & "',FormaAsentaInt='" & cbFormaPagoInt.SelectedIndex & "',NumCuentaBancoEntregaInt='" & CtaPagoInt & "'"
                            If ahorro.ModificarCertificadosDPF(txtNoCertificado.Text.Trim, camposValores, sUsuario, sPassword, sSucursal) = True Then
                                MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        Me.Dispose()
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    End If

                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton2_Click_2(sender As Object, e As EventArgs) Handles btTasaPactada.Click
        Dim ofrmAut As New frmMsAutorizacion
        ofrmAut.TipoPermiso = "P"
        ofrmAut.NumPrograma = "AHC002"
        ofrmAut.ShowDialog()
        If ofrmAut.Autoriza = True Then
            '=========================================================================================
            '25/10/2013 Javier Martines
            'Se incluye cb para detalle de persona que autoriza cambio de tasa
            ModificacionTasa = True
            MetroFramework.MetroMessageBox.Show(Me, "Seleccionar la persona que autoriza la modificación de la tasa de interes.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            c1nTasa.Enabled = True
            Me.cbAutorizacion.Enabled = True
            '=========================================================================================
            Me.c1nTasa.ReadOnly = False
            Me.c1nTasa.Focus()
            ofrmAut.Autoriza = False
            ofrmAut.Dispose()
        Else
            ofrmAut.Dispose()
        End If
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton2_Click_3(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub
    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton4_Click_1(sender As Object, e As EventArgs)
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton10_Click(sender As Object, e As EventArgs) Handles MetroButton10.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub
    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        Try
            Dim frmRpt As New frmVisorRS
            OpcionRS = 65
            frmRpt.dui = Me.txtDui.Text.Trim
            frmRpt.ShowDialog()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton11_Click(sender As Object, e As EventArgs) Handles btnContrato.Click
        Try
            If txtNoCuenta.ToString.Trim = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "No hay una cuenta seleccionada, Favor Verifique.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                Exit Sub
            End If
            Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
            ds = oAh.RptContratoDepositoPlazo(txtNoCuenta.Text)
            Dim ofrm As New frmVisor(ds, 221, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton9_Click_1(sender As Object, e As EventArgs) Handles MetroButton9.Click
        Dim frm As New frmIngresoAsoc2
        With frm
            .txtDui.Text = Me.txtDui.Value
            .accion = 2
            .Show()
        End With
    End Sub
    Dim modificarFormaPagoIntereses As Boolean = False

    Private Sub MetroButton13_Click(sender As Object, e As EventArgs) Handles MetroButton13.Click
        If txtestado.Text = "Digitada" Then
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "AHI011"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                modificarFormaPagoIntereses = True
                cbFormaPagoInt.Enabled = True
                cbNocuenta.Enabled = True
                dtpFechaCapitalizacion.Enabled = True
                ofrmAut.Autoriza = False
                ofrmAut.Dispose()
            Else
                modificarFormaPagoIntereses = False
                ofrmAut.Dispose()
            End If
        Else
            If DateAdd("m", 1, dtpFecIniApertura.Text) > Now Then
                Dim ofrmAut As New frmMsAutorizacion
                ofrmAut.TipoPermiso = "P"
                ofrmAut.NumPrograma = "AUT001"
                ofrmAut.ShowDialog()
                If ofrmAut.Autoriza = True Then
                    modificarFormaPagoIntereses = True
                    cbFormaPagoInt.Enabled = True
                    cbNocuenta.Enabled = True
                    dtpFechaCapitalizacion.Enabled = True
                    ofrmAut.Autoriza = False
                    ofrmAut.Dispose()
                Else
                    modificarFormaPagoIntereses = False
                    ofrmAut.Dispose()
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Consultar a Informática Cambio de Tipo de Pago", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub MetroButton12_Click(sender As Object, e As EventArgs) Handles MetroButton12.Click

        Dim ofrmAut As New frmMsAutorizacion
        ofrmAut.TipoPermiso = "P"
        ofrmAut.NumPrograma = "AHG016"
        ofrmAut.ShowDialog()
        If ofrmAut.Autoriza = True Then
            cbEjecutivo.Enabled = True
            ofrmAut.Autoriza = False
            ofrmAut.Dispose()
        Else
            ofrmAut.Dispose()
        End If

    End Sub

    Private Sub MetroButton11_Click_1(sender As Object, e As EventArgs) Handles MetroButton11.Click
        Try
            Dim frmRpt As New frmVisorRS
            OpcionRS = 110
            frmRpt.codPrstamo = Me.txtNoCuenta.Text.Trim
            frmRpt.ShowDialog()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    'cambio para Agregar una Cuenta de Tercero
    ' Se toma datos de un formulario externo
    '26/05/2020   Prog01
    Private Sub BtnCtaAhorro_Click(sender As Object, e As EventArgs) Handles BtnCtaAhorro.Click
        Dim ofrmAut As New frmCuentasAhorros
        ofrmAut.ShowDialog()
        cbNocuenta.DataSource = Nothing
        cbNocuenta.Items.Clear()
        cbNocuenta.Items.Add(ofrmAut.nocuenta)
        cbNocuenta.SelectedItem = ofrmAut.nocuenta
        cbNocuenta.Enabled = False
        PCtaTercero = True
        modificarFormaPagoIntereses = True
    End Sub

    Private Sub txtDui_TextChanged(sender As Object, e As EventArgs) Handles txtDui.TextChanged

    End Sub

    ' Fin del Cambio 26/05/2020

    Private Sub btEdit_Click_1(sender As Object, e As EventArgs) Handles btEdit.Click
        Dim ofrmAut As New frmMsAutorizacion
        ofrmAut.TipoPermiso = "P"
        ofrmAut.NumPrograma = "AHI002"
        ofrmAut.ShowDialog()
        If ofrmAut.Autoriza = True Then
            txtNoCertificado.Enabled = True
            Me.txtNoCertificado.ReadOnly = False
            Me.txtNoCertificado.Focus()
            ofrmAut.Autoriza = False
            ofrmAut.Dispose()
        Else
            ofrmAut.Dispose()
        End If
    End Sub

    Private Sub cbTipoAhorro_Validated(sender As Object, e As EventArgs) Handles cbTipoAhorro.Validated
        Try
            '=================================================================================================================
            'Generamos # DE CUENTA

            txtNoCuenta.Text = ahorro.generarNoCuentaTipoAhorro(txtDui.Value.Trim, cbTipoAhorro.SelectedValue, sUsuario, sPassword, sSucursal)
            txtNoCertificado.Text = ahorro.ObtenerCorrelativoCuentaAhorro("IdCertificadoDPF", sUsuario, sPassword, sSucursal)
            digito = ahorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
            Dim dts As New DataSet
            dts = ahorro.ConsultarParametros("tasaInteres,plazoMaximo", " codtipoahorro = '" & cbTipoAhorro.SelectedValue & "'", "", sUsuario, sPassword, sSucursal)
            c1nTasa.Value = dts.Tables(0).Rows(0).Item(0)
            c1nPlazo.Value = dts.Tables(0).Rows(0).Item(1)
            dtpFecVenc.Value = Now.AddDays(c1nPlazo.Value - 1)

            '=================================================================================================================
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, " Ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cbFormaPagoInt_Validated(sender As Object, e As EventArgs) Handles cbFormaPagoInt.Validated
        If cbFormaPagoInt.SelectedIndex = 0 Then
            'dtpFechaCapitalizacion.Value = Now.AddDays(29)
            Me.dtpFechaCapitalizacion.Value = DateAdd("d", 29, (Me.dtpFecIniApertura.Value))
        ElseIf cbFormaPagoInt.SelectedIndex = 1 Then
            'dtpFechaCapitalizacion.Value = Now.AddDays(c1nPlazo.Value - 1)
            Me.dtpFechaCapitalizacion.Value = DateAdd("m", (Me.c1nPlazo.Value), (Me.dtpFecIniApertura.Value))
        Else
            cbFormaPagoInt.SelectedIndex = 0
            dtpFechaCapitalizacion.Value = Now.AddDays(29)
        End If
    End Sub

    Private Sub cbEjecutivo_Validated(sender As Object, e As EventArgs) Handles cbEjecutivo.Validated
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarEjecutivosMercadeo("codSucursal", "codEjecMercadeo ='" & cbEjecutivo.SelectedValue & "'", "codEjecMercadeo", sUsuario, sPassword, sSucursal)
            Me.cbSucursal.SelectedValue = dts.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, "Ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub frmMsAhCuentasDPF_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class