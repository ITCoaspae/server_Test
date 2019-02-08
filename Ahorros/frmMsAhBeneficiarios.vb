Public Class frmMsAhBeneficiarios
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents cbParen As ComboBox
    Dim asociados As New wrAsociados.wsLibAsoc

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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
    Friend WithEvents nUpDBenef As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTelOfic As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtApe3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbParen = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtApe3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.nUpDBenef = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelOfic = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDBenef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.cbParen)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.cbEstadoCivil)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.txtApe3)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.cbDoc)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txtApellido2)
        Me.GroupBox3.Controls.Add(Me.txtDui)
        Me.GroupBox3.Controls.Add(Me.lblPorcentaje)
        Me.GroupBox3.Controls.Add(Me.nUpDBenef)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtTelOfic)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtApe1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtNombres)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtCorreo)
        Me.GroupBox3.Controls.Add(Me.txtDir)
        Me.GroupBox3.Controls.Add(Me.txtTelCasa)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(599, 327)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'cbParen
        '
        Me.cbParen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbParen.FormattingEnabled = True
        Me.cbParen.Location = New System.Drawing.Point(109, 242)
        Me.cbParen.Name = "cbParen"
        Me.cbParen.Size = New System.Drawing.Size(474, 22)
        Me.cbParen.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(293, 279)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(42, 32)
        Me.Panel1.TabIndex = 26
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Acompañado", "Viudo"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(405, 87)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(178, 22)
        Me.cbEstadoCivil.TabIndex = 11
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(311, 90)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 16)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Estado Civil:"
        '
        'txtApe3
        '
        Me.txtApe3.Location = New System.Drawing.Point(109, 113)
        Me.txtApe3.MaxLength = 50
        Me.txtApe3.Name = "txtApe3"
        Me.txtApe3.ReadOnly = True
        Me.txtApe3.Size = New System.Drawing.Size(178, 20)
        Me.txtApe3.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Apellido de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Casada:"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(311, 34)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(88, 16)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "No. Documento:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbDoc
        '
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoc.Items.AddRange(New Object() {"DUI", "NIT", "No. Licencia", "No. Residente", "No. Pasaporte", "Partida de Nacimiento"})
        Me.cbDoc.Location = New System.Drawing.Point(109, 33)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(178, 22)
        Me.cbDoc.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(16, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(87, 31)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Documento de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Identidad:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(109, 87)
        Me.txtApellido2.MaxLength = 50
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(178, 20)
        Me.txtApellido2.TabIndex = 9
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(405, 35)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(178, 18)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.Location = New System.Drawing.Point(341, 284)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(184, 23)
        Me.lblPorcentaje.TabIndex = 27
        Me.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nUpDBenef
        '
        Me.nUpDBenef.DecimalPlaces = 2
        Me.nUpDBenef.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nUpDBenef.Location = New System.Drawing.Point(109, 278)
        Me.nUpDBenef.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nUpDBenef.Name = "nUpDBenef"
        Me.nUpDBenef.Size = New System.Drawing.Size(178, 20)
        Me.nUpDBenef.TabIndex = 25
        Me.nUpDBenef.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 33)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Porcentaje " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Beneficio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelOfic
        '
        Me.txtTelOfic.Location = New System.Drawing.Point(405, 177)
        Me.txtTelOfic.MaxLength = 40
        Me.txtTelOfic.Name = "txtTelOfic"
        Me.txtTelOfic.Size = New System.Drawing.Size(178, 20)
        Me.txtTelOfic.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(311, 177)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 30)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Teléfono  de Oficina:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 32)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Parentesco     con el Asociado:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe1
        '
        Me.txtApe1.Location = New System.Drawing.Point(405, 61)
        Me.txtApe1.MaxLength = 50
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(178, 20)
        Me.txtApe1.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Apellido 2:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(311, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Apellido 1:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(109, 61)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(178, 20)
        Me.txtNombres.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Nombres:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(109, 215)
        Me.txtCorreo.MaxLength = 100
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCorreo.Size = New System.Drawing.Size(474, 20)
        Me.txtCorreo.TabIndex = 21
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(109, 139)
        Me.txtDir.MaxLength = 255
        Me.txtDir.Multiline = True
        Me.txtDir.Name = "txtDir"
        Me.txtDir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDir.Size = New System.Drawing.Size(474, 32)
        Me.txtDir.TabIndex = 15
        '
        'txtTelCasa
        '
        Me.txtTelCasa.Location = New System.Drawing.Point(109, 177)
        Me.txtTelCasa.MaxLength = 40
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(178, 20)
        Me.txtTelCasa.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(15, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 30)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Teléfono de Casa:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(16, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Dirección:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(17, 210)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 32)
        Me.Label33.TabIndex = 20
        Me.Label33.Text = "Correo electrónico:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(547, 396)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnGuardar1.TabIndex = 1
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsAhBeneficiarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(643, 468)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmMsAhBeneficiarios"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Detalle de Beneficiarios"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDBenef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, pCorrelativo As Long
    Public Sub llenarParentesco()
        Dim dts As New DataSet
        dts = asociados.ConsultarParentescos("codParentesco,descripcion", "", " descripcion ", sUsuario, sPassword, sSucursal)
        cbParen.DisplayMember = "Descripcion"
        cbParen.ValueMember = "codParentesco"
        Me.cbParen.DataSource = dts.Tables(0)
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
    Private Sub frmMsAhBeneficiarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim ds As New Data.DataSet, objRow As Data.DataRow, vPorcent As Double, oAsoc As New wrAsociados.wsLibAsoc
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, x As Integer
            Dim Filas As Data.DataRowCollection

            Me.txtNombres.Focus()
            Me.cbDoc.SelectedIndex = 0

            llenarEstadoCivil()
            ds = oAhorro.ConsultarBeneficiarios("Porcentaje,Correlativo", "CodTipoAhorro='" & pCodTipoAhorro & "' and NoCuenta='" & pNoCuenta & "'", "DuiBeneficiario", sUsuario, sPassword, sSucursal)
            For Each objRow In ds.Tables(0).Rows
                vPorcent = vPorcent + CDbl(objRow("Porcentaje"))
            Next
            Me.lblPorcentaje.Text = "Porcentaje disponible: " & CDbl(100 - vPorcent) & "%"

            Dim dsTemp As New DataSet, drTemp As DataRow
            dsTemp = oAsoc.ConsultarParentescos("*", "", "CodParentesco", sUsuario, sPassword, sSucursal)
            llenarParentesco()



            If Me.btnGuardar1.Text = "&Modificar" Then

                ds = oAhorro.ConsultarBeneficiarios("*", "DuiBeneficiario='" & Trim(Me.txtDui.Value) & "' and Correlativo=" & pCorrelativo & "", "DuiBeneficiario", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNombres.Text = IIf(Filas.Item(0)("Nombres") Is DBNull.Value, " ", Filas.Item(0)("Nombres").ToString.ToUpper)
                    txtApe1.Text = IIf(Filas.Item(0)("Apellido1") Is DBNull.Value, " ", Filas.Item(0)("Apellido1").ToString.ToUpper)
                    txtApellido2.Text = IIf(Filas.Item(0)("Apellido2") Is DBNull.Value, " ", Filas.Item(0)("Apellido2").ToString.ToUpper)
                    Me.txtApe3.Text = IIf(IsDBNull(Filas.Item(0)("ApellidoCas")), 0, Filas.Item(0)("ApellidoCas").ToString.ToUpper)
                    txtDir.Text = IIf(Filas.Item(0)("Direccion") Is DBNull.Value, " ", Filas.Item(0)("Direccion").ToString.ToUpper)
                    cbParen.SelectedValue = IIf(IsDBNull(Filas.Item(0)("CodParentesco")), "20", Filas.Item(0)("CodParentesco"))
                    txtTelCasa.Text = IIf(Filas.Item(0)("TelCasa") Is DBNull.Value, " ", Filas.Item(0)("TelCasa").ToString.ToUpper)
                    txtTelOfic.Text = IIf(Filas.Item(0)("TelOficina") Is DBNull.Value, " ", Filas.Item(0)("TelOficina").ToString.ToUpper)
                    txtCorreo.Text = IIf(Filas.Item(0)("Email") Is DBNull.Value, " ", Filas.Item(0)("Email").ToString.ToUpper)
                    nUpDBenef.Value = CDbl(Filas.Item(0)("Porcentaje"))
                    cbDoc.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("TipoDoc")), 0, Filas.Item(0)("TipoDoc"))
                    Me.cbEstadoCivil.SelectedValue = IIf(IsDBNull(Filas.Item(0)("EstadoCivil")), 35, Filas.Item(0)("EstadoCivil"))
                End If

            Else
                Me.nUpDBenef.Maximum = 100 - vPorcent
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub nUpDBenef_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nUpDBenef.GotFocus
        Me.nUpDBenef.Select(0, Len(Me.nUpDBenef.Value))
    End Sub

    Private Sub nUpDBenef_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nUpDBenef.Validating
        If Me.nUpDBenef.Value > 100 Then e.Cancel = True
    End Sub





    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Try
            Dim oAsoc As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, pCampos As String, pValores As String
            Select Case oAsoc.AutorizaDatos(IIf(IsDBNull(Me.txtDui.Value), "", Me.txtDui.Value), txtApe1.Text, txtNombres.Text, "x", "x")
                'Case 1
                '    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                '    Exit Sub
                Case 2
                    MsgBox("El campo Apellido del Beneficiario no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                Case 3
                    MsgBox("El campo Nombres del Beneficiario no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
            End Select

            If Me.nUpDBenef.Value = 0 Then
                MsgBox("El porcentaje de beneficio no puede ser cero.", MsgBoxStyle.OkOnly, "Módulo Ahorros")
                Exit Sub
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "Correlativo,DuiBeneficiario,CodTipoAhorro,NoCuenta,Apellido1,Apellido2,ApellidoCas,Nombres,CodParentesco,Porcentaje,Direccion,TelCasa,TelOficina,Email,Tipo,TipoDoc,EstadoCivil"
                pValores = "" & oAsoc.ObtenerCorrelativoBeneficiarios("Correlativo", sUsuario, sPassword, sSucursal) & ",'" & IIf(txtDui.Value.ToString.Trim.Length = 0, " ", txtDui.Value.ToString.Trim) & "','" & Me.pCodTipoAhorro & "','" & Me.pNoCuenta & "','" & Trim(txtApe1.Text) & "','" & Trim(Me.txtApellido2.Text) & "','" & Trim(Me.txtApe3.Text) & "','" & Trim(txtNombres.Text) & "','" & cbParen.SelectedValue & "'," & nUpDBenef.Value & ",'" & Trim(txtDir.Text) & "','" & Trim(txtTelCasa.Text) & "','" & Trim(txtTelOfic.Text) & "','" & Trim(Me.txtCorreo.Text) & "','A','" & Me.cbDoc.SelectedIndex & "','" & Me.cbEstadoCivil.SelectedValue & "'"
                If oAsoc.InsertarBeneficiarios(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El Beneficiario ha sido agregado.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El Beneficiario NO ha sido agregado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "DuiBeneficiario='" & Trim(Me.txtDui.Value) & "',Apellido1='" & Trim(txtApe1.Text) & "',Apellido2='" & Trim(Me.txtApellido2.Text) & "',ApellidoCas='" & Trim(Me.txtApe3.Text) & "',Nombres='" & Trim(Me.txtNombres.Text) & "',CodParentesco='" & Me.cbParen.SelectedValue & "',Porcentaje='" & nUpDBenef.Value & "',Direccion='" & Trim(txtDir.Text) & "',TelCasa='" & Trim(txtTelCasa.Text) & "',TelOficina='" & Trim(txtTelOfic.Text) & "',Email='" & Trim(txtCorreo.Text) & "',TipoDoc='" & Me.cbDoc.SelectedIndex & "',EstadoCivil='" & Me.cbEstadoCivil.SelectedValue & "'"
                If oAsoc.ModificarBeneficiarios("Correlativo=" & pCorrelativo & "", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El Beneficiario ha sido modificado.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El Beneficiario no ha sido modificado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbEstadoCivil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEstadoCivil.SelectedIndexChanged
        If Me.cbEstadoCivil.SelectedIndex = 1 Then
            Me.txtApe3.ReadOnly = False
        Else
            Me.txtApe3.ReadOnly = True
            Me.txtApe3.Text = ""
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



End Class
