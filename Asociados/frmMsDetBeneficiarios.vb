Public Class frmMsDetBeneficiarios
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pDui As String, pCorrelativo As Long
    Friend WithEvents lblFecNac As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dtpFecNac As System.Windows.Forms.DateTimePicker

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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
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
    Friend WithEvents txtTelOfic As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nUpDBenef As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApe3 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cbPar As System.Windows.Forms.ComboBox
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker()
        Me.lblFecNac = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbPar = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtApe3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.nUpDBenef = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelOfic = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDBenef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.dtpFecNac)
        Me.GroupBox3.Controls.Add(Me.lblFecNac)
        Me.GroupBox3.Controls.Add(Me.cboSexo)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbPar)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.cbDoc)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txtDui)
        Me.GroupBox3.Controls.Add(Me.txtApe3)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblPorcentaje)
        Me.GroupBox3.Controls.Add(Me.nUpDBenef)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtTelOfic)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtApe2)
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
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(548, 470)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNac.Location = New System.Drawing.Point(394, 240)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(144, 23)
        Me.dtpFecNac.TabIndex = 169
        '
        'lblFecNac
        '
        Me.lblFecNac.AutoSize = True
        Me.lblFecNac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecNac.ForeColor = System.Drawing.Color.Black
        Me.lblFecNac.Location = New System.Drawing.Point(278, 238)
        Me.lblFecNac.Name = "lblFecNac"
        Me.lblFecNac.Size = New System.Drawing.Size(77, 32)
        Me.lblFecNac.TabIndex = 168
        Me.lblFecNac.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento"
        '
        'cboSexo
        '
        Me.cboSexo.BackColor = System.Drawing.Color.White
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cboSexo.Location = New System.Drawing.Point(127, 238)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(144, 24)
        Me.cboSexo.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Sexo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbPar
        '
        Me.cbPar.BackColor = System.Drawing.Color.White
        Me.cbPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPar.Location = New System.Drawing.Point(113, 353)
        Me.cbPar.Name = "cbPar"
        Me.cbPar.Size = New System.Drawing.Size(425, 24)
        Me.cbPar.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Teal
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(85, 52)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(22, 23)
        Me.TextBox1.TabIndex = 163
        Me.TextBox1.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(298, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 19)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "Porcentaje disponible:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(271, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(106, 19)
        Me.Label29.TabIndex = 161
        Me.Label29.Text = "No. Documento:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbDoc
        '
        Me.cbDoc.BackColor = System.Drawing.Color.White
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoc.Items.AddRange(New Object() {"DUI", "NIT", "No. Licencia", "No. Residente", "No. Pasaporte", "Partida de Nacimiento", "Ninguno"})
        Me.cbDoc.Location = New System.Drawing.Point(130, 17)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(134, 24)
        Me.cbDoc.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(7, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(115, 19)
        Me.Label28.TabIndex = 160
        Me.Label28.Text = "Doc. de Identidad:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDui.Location = New System.Drawing.Point(384, 20)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(154, 21)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtApe3
        '
        Me.txtApe3.BackColor = System.Drawing.Color.White
        Me.txtApe3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe3.Location = New System.Drawing.Point(127, 153)
        Me.txtApe3.MaxLength = 50
        Me.txtApe3.Name = "txtApe3"
        Me.txtApe3.Size = New System.Drawing.Size(411, 23)
        Me.txtApe3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 42)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Apellido de Casada:"
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.BackColor = System.Drawing.Color.White
        Me.lblPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPorcentaje.ForeColor = System.Drawing.Color.Black
        Me.lblPorcentaje.Location = New System.Drawing.Point(455, 429)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(83, 23)
        Me.lblPorcentaje.TabIndex = 13
        Me.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nUpDBenef
        '
        Me.nUpDBenef.BackColor = System.Drawing.Color.White
        Me.nUpDBenef.DecimalPlaces = 2
        Me.nUpDBenef.Location = New System.Drawing.Point(181, 427)
        Me.nUpDBenef.Name = "nUpDBenef"
        Me.nUpDBenef.Size = New System.Drawing.Size(83, 23)
        Me.nUpDBenef.TabIndex = 12
        Me.nUpDBenef.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 427)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 23)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "*Porcentaje de Beneficio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelOfic
        '
        Me.txtTelOfic.BackColor = System.Drawing.Color.White
        Me.txtTelOfic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelOfic.Location = New System.Drawing.Point(394, 202)
        Me.txtTelOfic.MaxLength = 40
        Me.txtTelOfic.Name = "txtTelOfic"
        Me.txtTelOfic.Size = New System.Drawing.Size(144, 23)
        Me.txtTelOfic.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(278, 198)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 29)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Tel. Oficina:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 24)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "*Parentesco:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe2
        '
        Me.txtApe2.BackColor = System.Drawing.Color.White
        Me.txtApe2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe2.Location = New System.Drawing.Point(127, 114)
        Me.txtApe2.MaxLength = 50
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.Size = New System.Drawing.Size(411, 23)
        Me.txtApe2.TabIndex = 4
        '
        'txtApe1
        '
        Me.txtApe1.BackColor = System.Drawing.Color.White
        Me.txtApe1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe1.Location = New System.Drawing.Point(127, 84)
        Me.txtApe1.MaxLength = 50
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(411, 23)
        Me.txtApe1.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 18)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Apellido 2:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(7, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 19)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "*Apellido 1:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(127, 50)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(411, 23)
        Me.txtNombres.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 18)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "*Nombres:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.White
        Me.txtCorreo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(113, 390)
        Me.txtCorreo.MaxLength = 100
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCorreo.Size = New System.Drawing.Size(425, 23)
        Me.txtCorreo.TabIndex = 11
        '
        'txtDir
        '
        Me.txtDir.BackColor = System.Drawing.Color.White
        Me.txtDir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.Location = New System.Drawing.Point(11, 293)
        Me.txtDir.MaxLength = 255
        Me.txtDir.Multiline = True
        Me.txtDir.Name = "txtDir"
        Me.txtDir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDir.Size = New System.Drawing.Size(527, 51)
        Me.txtDir.TabIndex = 9
        '
        'txtTelCasa
        '
        Me.txtTelCasa.BackColor = System.Drawing.Color.White
        Me.txtTelCasa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelCasa.Location = New System.Drawing.Point(127, 202)
        Me.txtTelCasa.MaxLength = 40
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(144, 23)
        Me.txtTelCasa.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(7, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 36)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Teléfono " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Casa:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 19)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Dirección:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(13, 383)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 37)
        Me.Label33.TabIndex = 78
        Me.Label33.Text = "Correo electrónico:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(472, 549)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(104, 33)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 132
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMsDetBeneficiarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(622, 633)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsDetBeneficiarios"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Beneficiarios"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDBenef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmMsDetBeneficiarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As New Data.DataSet, objRow As Data.DataRow, vPorcent As Long
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Dim Filas As Data.DataRowCollection, x As Integer
        Try
            Me.txtNombres.Focus()

            Dim dsTemp As New DataSet, drTemp As DataRow
            cbPar.ValueMember = "codParentesco"
            cbPar.DisplayMember = "descripcion"
            dsTemp = oAsoc.ConsultarParentescos("CodParentesco,descripcion", "", "CodParentesco", sUsuario, sPassword, sSucursal)
            cbPar.DataSource = dsTemp.Tables(0)
            Me.cboSexo.SelectedIndex = 0


            If Me.btnGuardar1.Text = "&Modificar" Then

                ds = oAsoc.ConsultarBeneficiarios("PorcentBeneficio,Correlativo", "Dui='" & Trim(pDui) & "'", "Dui", sUsuario, sPassword, sSucursal)
                For Each objRow In ds.Tables(0).Rows
                    If objRow("Correlativo") = pCorrelativo Then
                    Else
                        vPorcent = vPorcent + CInt(objRow("PorcentBeneficio"))
                    End If
                Next
                Me.nUpDBenef.Maximum = 100 - vPorcent
                Me.lblPorcentaje.Text = (100 - vPorcent).ToString & "%"
                ds = oAsoc.ConsultarBeneficiarios("*", "Dui='" & pDui & "' and Correlativo=" & pCorrelativo & "", "Dui", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtDui.Value = IIf(IsDBNull(Filas.Item(0)("DuiBeneficiario")), "", Filas.Item(0)("DuiBeneficiario"))
                    txtNombres.Text = (Filas.Item(0)("Nombres"))
                    txtApe1.Text = (Filas.Item(0)("Apellido1"))
                    txtApe2.Text = IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))  'IIf(IsDBNull((Filas.Item(0)("Apellido2")), " ", Filas.Item(0)("Apellido2").ToString))
                    txtApe3.Text = (IIf(IsDBNull(Filas.Item(0)("ApellidoCas")), " ", Filas.Item(0)("ApellidoCas")))
                    cboSexo.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("Sexo")), 0, Filas.Item(0)("Sexo"))
                    txtDir.Text = IIf(IsDBNull(Filas.Item(0)("Direccion")), "", Filas.Item(0)("Direccion")) '(Filas.Item(0)("Direccion"))

                    cbPar.SelectedValue = Filas.Item(0)("CodParentesco")


                    txtTelCasa.Text = IIf(IsDBNull(Filas.Item(0)("TelCasa")), "", Filas.Item(0)("TelCasa")) '(Filas.Item(0)("TelCasa"))
                    txtTelOfic.Text = IIf(IsDBNull(Filas.Item(0)("TelOficina")), "", Filas.Item(0)("TelOficina")) '(Filas.Item(0)("TelOficina"))
                    txtCorreo.Text = IIf(IsDBNull(Filas.Item(0)("Emails")), "", Filas.Item(0)("Emails")) ' (Filas.Item(0)("Emails"))
                    nUpDBenef.Value = CInt(Filas.Item(0)("PorcentBeneficio"))
                    Me.cbDoc.SelectedIndex = (IIf(IsDBNull(Filas.Item(0)("TipoDoc")), 0, Filas.Item(0)("TipoDoc")))
                    Me.dtpFecNac.Value = IIf(IsDBNull(Filas.Item(0)("fechaNac")), Now, Filas.Item(0)("fechaNac"))
                End If

            Else
                ds = oAsoc.ConsultarBeneficiarios("PorcentBeneficio", "Dui='" & pDui & "'", "Dui", sUsuario, sPassword, sSucursal)
                For Each objRow In ds.Tables(0).Rows
                    vPorcent = vPorcent + CInt(objRow("PorcentBeneficio"))
                Next
                Me.lblPorcentaje.Text = 100 - vPorcent & "%"
                Me.nUpDBenef.Maximum = 100 - vPorcent
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub nUpDBenef_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nUpDBenef.GotFocus
    '    Me.nUpDBenef.Select(0, Len(Me.nUpDBenef.Value))
    'End Sub

    'Private Sub nUpDBenef_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nUpDBenef.Validating
    '    If Me.nUpDBenef.Value > 100 Then e.Cancel = True
    'End Sub

    Private Sub cbDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDoc.SelectedIndexChanged
        If cbDoc.SelectedIndex = 0 Then
            Me.txtDui.EditMask = "00000000-0"
        ElseIf cbDoc.SelectedIndex = 1 Or cbDoc.SelectedIndex = 2 Then
            Me.txtDui.EditMask = "0000-000000-000-0"
        Else
            Me.txtDui.EditMask = ""
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
    Public Function validarCamposRequeridos()
        Me.ErrorProvider1.Clear()
        Dim valido As Boolean = True
        If txtNombres.Text.Trim.Length <= 0 Then
            Me.ErrorProvider1.SetError(txtNombres, "Campo Requerido")
            valido = False
        End If

        If txtApe1.Text.Trim.Length <= 0 Then
            Me.ErrorProvider1.SetError(txtNombres, "Campo Requerido")
            valido = False
        End If

        If cbPar.SelectedIndex <= 0 Then
            Me.ErrorProvider1.SetError(cbPar, "Campo Requerido")
            valido = False
        End If
        If cbPar.SelectedIndex <= 0 Then
            Me.ErrorProvider1.SetError(cbPar, "Campo Requerido")
            valido = False
        End If

        Return valido

    End Function
    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String
        Try
            Select Case oAsoc.AutorizaDatos(pDui, txtApe1.Text, txtNombres.Text, "x", "x")
                Case 1
                    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
                Case 2
                    MsgBox("El campo Apellido del Beneficiario no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
                Case 3
                    MsgBox("El campo Nombres del Beneficiario no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
            End Select
            If validarCamposRequeridos() = False Then
                Exit Sub
            End If
            If Me.cbDoc.SelectedIndex < 0 Then
                MsgBox("Seleccione un tipo de documento", MsgBoxStyle.OkOnly, "Módulo Asociados")
                Exit Sub
            End If
            If Me.nUpDBenef.Value = 0 Then
                MsgBox("El porcentaje de beneficio no puede ser cero.", MsgBoxStyle.OkOnly, "Módulo Asociados")
                Exit Sub
            End If
            If Now.Date = dtpFecNac.Value.Date Then
                MsgBox("Fecha de nacimiento no puede ser igual a fecha actual.", MsgBoxStyle.OkOnly, "Módulo Asociados")
                Exit Sub
            End If
            If dtpFecNac.Value.Date > Now.Date Then
                MsgBox("Fecha de nacimiento no puede ser mayor que fecha actual.", MsgBoxStyle.OkOnly, "Módulo Asociados")
                Exit Sub
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "DUI,Correlativo,Apellido1,Apellido2,ApellidoCas,Nombres,CodParentesco,PorcentBeneficio,Direccion,TelCasa,TelOficina,Emails,DuiBeneficiario,TipoDoc,Sexo,fechaNac"
                pValores = "'" & Trim(pDui) & "'," & oAsoc.ObtenerCorrelativoBeneficiarios("Correlativo", sUsuario, sPassword, sSucursal) & ",'" & Trim(txtApe1.Text) & "','" & Trim(txtApe2.Text) & "','" & Me.txtApe3.Text.Trim & "','" & Trim(txtNombres.Text) &
                "','" & Me.cbPar.SelectedValue & "'," & nUpDBenef.Value &
                ",'" & Trim(txtDir.Text) & "','" & Trim(txtTelCasa.Text) & "','" & Trim(txtTelOfic.Text) & "','" & Trim(Me.txtCorreo.Text) & "','" &
                Trim(IIf(IsDBNull(Me.txtDui.Value), "", txtDui.Value)) & "','" & Me.cbDoc.SelectedIndex & "','" & cboSexo.SelectedIndex & "', '" & Format(dtpFecNac.Value, "short date") & "' "
                If oAsoc.InsertarBeneficiarios(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El Beneficiario ha sido agregado.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El Beneficiario NO ha sido agregado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Apellido1='" & Trim(txtApe1.Text) & "',Apellido2='" & Trim(Me.txtApe2.Text) & "',ApellidoCas='" & Me.txtApe3.Text.Trim & "',Nombres='" & Trim(Me.txtNombres.Text) & "',CodParentesco='" & Me.cbPar.SelectedValue & "',PorcentBeneficio='" & nUpDBenef.Value & "',Direccion='" & Trim(txtDir.Text) & "',TelCasa='" & Trim(txtTelCasa.Text) & "',TelOficina='" & Trim(txtTelOfic.Text) & "',Emails='" & Trim(txtCorreo.Text) & "',DuiBeneficiario='" & Trim(IIf(IsDBNull(Me.txtDui.Value), "", txtDui.Value)) & "',TipoDoc='" & Me.cbDoc.SelectedIndex & "',Sexo='" & cboSexo.SelectedIndex & "', fechaNac = '" & Format(dtpFecNac.Value, "short date") & "' "
                If oAsoc.ModificarBeneficiarios("Correlativo=" & pCorrelativo & "", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El Beneficiario ha sido modificado.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El Beneficiario no ha sido modificado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsDetBeneficiarios_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class