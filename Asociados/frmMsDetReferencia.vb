Public Class frmMsDetReferencia
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pDui As String, pCorrelativo As Long, ofrm As frmMsReferencia
    Friend WithEvents txtTelCasa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTelOfic As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtLugTrab As System.Windows.Forms.TextBox
    Friend WithEvents txtDirTrab As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents cbPar As System.Windows.Forms.ComboBox
    Friend WithEvents cbParentesco As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelOfic = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtLugTrab = New System.Windows.Forms.TextBox()
        Me.txtDirTrab = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtTelCasa = New System.Windows.Forms.MaskedTextBox()
        Me.cbPar = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cbParentesco = New System.Windows.Forms.ComboBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtCelular)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtTelOfic)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtCargo)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtLugTrab)
        Me.GroupBox2.Controls.Add(Me.txtDirTrab)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(28, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(598, 181)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Trabajo"
        '
        'txtCelular
        '
        Me.txtCelular.BackColor = System.Drawing.Color.White
        Me.txtCelular.Location = New System.Drawing.Point(478, 143)
        Me.txtCelular.Mask = "0000-0000"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(105, 23)
        Me.txtCelular.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(406, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Celular:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelOfic
        '
        Me.txtTelOfic.BackColor = System.Drawing.Color.White
        Me.txtTelOfic.Location = New System.Drawing.Point(132, 143)
        Me.txtTelOfic.Mask = "0000-0000"
        Me.txtTelOfic.Name = "txtTelOfic"
        Me.txtTelOfic.Size = New System.Drawing.Size(121, 23)
        Me.txtTelOfic.TabIndex = 88
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(10, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 38)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Teléfono " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Oficina:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.White
        Me.txtCargo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(132, 113)
        Me.txtCargo.MaxLength = 50
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCargo.Size = New System.Drawing.Size(451, 23)
        Me.txtCargo.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(10, 113)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 19)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "Cargo:"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(10, 58)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 18)
        Me.Label25.TabIndex = 55
        Me.Label25.Text = "Dirección:"
        '
        'txtLugTrab
        '
        Me.txtLugTrab.BackColor = System.Drawing.Color.White
        Me.txtLugTrab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugTrab.Location = New System.Drawing.Point(132, 24)
        Me.txtLugTrab.MaxLength = 100
        Me.txtLugTrab.Name = "txtLugTrab"
        Me.txtLugTrab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLugTrab.Size = New System.Drawing.Size(451, 23)
        Me.txtLugTrab.TabIndex = 0
        '
        'txtDirTrab
        '
        Me.txtDirTrab.BackColor = System.Drawing.Color.White
        Me.txtDirTrab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirTrab.Location = New System.Drawing.Point(132, 54)
        Me.txtDirTrab.MaxLength = 255
        Me.txtDirTrab.Multiline = True
        Me.txtDirTrab.Name = "txtDirTrab"
        Me.txtDirTrab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDirTrab.Size = New System.Drawing.Size(451, 52)
        Me.txtDirTrab.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(10, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 18)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Lugar de trabajo:"
        '
        'gbDatos
        '
        Me.gbDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDatos.BackColor = System.Drawing.Color.White
        Me.gbDatos.Controls.Add(Me.txtTelCasa)
        Me.gbDatos.Controls.Add(Me.cbPar)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.txtApe2)
        Me.gbDatos.Controls.Add(Me.txtApe1)
        Me.gbDatos.Controls.Add(Me.Label9)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.txtNombres)
        Me.gbDatos.Controls.Add(Me.Label10)
        Me.gbDatos.Controls.Add(Me.txtCorreo)
        Me.gbDatos.Controls.Add(Me.txtDir)
        Me.gbDatos.Controls.Add(Me.Label14)
        Me.gbDatos.Controls.Add(Me.Label13)
        Me.gbDatos.Controls.Add(Me.Label33)
        Me.gbDatos.Controls.Add(Me.cbParentesco)
        Me.gbDatos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.ForeColor = System.Drawing.Color.Black
        Me.gbDatos.Location = New System.Drawing.Point(28, 73)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(598, 212)
        Me.gbDatos.TabIndex = 0
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos de la Referencia"
        '
        'txtTelCasa
        '
        Me.txtTelCasa.BackColor = System.Drawing.Color.White
        Me.txtTelCasa.Location = New System.Drawing.Point(103, 84)
        Me.txtTelCasa.Mask = "0000-0000"
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(106, 23)
        Me.txtTelCasa.TabIndex = 87
        '
        'cbPar
        '
        Me.cbPar.BackColor = System.Drawing.Color.White
        Me.cbPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPar.Location = New System.Drawing.Point(103, 175)
        Me.cbPar.Name = "cbPar"
        Me.cbPar.Size = New System.Drawing.Size(475, 24)
        Me.cbPar.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "*Parentesco:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe2
        '
        Me.txtApe2.BackColor = System.Drawing.Color.White
        Me.txtApe2.Location = New System.Drawing.Point(386, 52)
        Me.txtApe2.MaxLength = 25
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.Size = New System.Drawing.Size(192, 23)
        Me.txtApe2.TabIndex = 2
        '
        'txtApe1
        '
        Me.txtApe1.BackColor = System.Drawing.Color.White
        Me.txtApe1.Location = New System.Drawing.Point(103, 51)
        Me.txtApe1.MaxLength = 25
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(192, 23)
        Me.txtApe1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(302, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 19)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Apellido 2:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 18)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "*Apellido 1:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Location = New System.Drawing.Point(103, 21)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(475, 23)
        Me.txtNombres.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(10, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 18)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "*Nombres:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.White
        Me.txtCorreo.Location = New System.Drawing.Point(346, 85)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCorreo.Size = New System.Drawing.Size(232, 23)
        Me.txtCorreo.TabIndex = 6
        '
        'txtDir
        '
        Me.txtDir.BackColor = System.Drawing.Color.White
        Me.txtDir.Location = New System.Drawing.Point(103, 114)
        Me.txtDir.MaxLength = 255
        Me.txtDir.Multiline = True
        Me.txtDir.Name = "txtDir"
        Me.txtDir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDir.Size = New System.Drawing.Size(475, 56)
        Me.txtDir.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(10, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 36)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Teléfono " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Casa:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(10, 115)
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
        Me.Label33.Location = New System.Drawing.Point(226, 85)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(121, 22)
        Me.Label33.TabIndex = 78
        Me.Label33.Text = "Correo electrónico:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbParentesco
        '
        Me.cbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbParentesco.Location = New System.Drawing.Point(103, 175)
        Me.cbParentesco.Name = "cbParentesco"
        Me.cbParentesco.Size = New System.Drawing.Size(231, 24)
        Me.cbParentesco.TabIndex = 5
        Me.cbParentesco.Visible = False
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(526, 480)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(104, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 133
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMsDetReferencia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(654, 585)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbDatos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsDetReferencia"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Referencias Personales"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmMsDetReferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, x As Integer
            gbDatos.Focus()

            Dim dsTemp As New DataSet, drTemp As DataRow
            dsTemp = oAsoc.ConsultarParentescos("*", "", "CodParentesco", sUsuario, sPassword, sSucursal)
            For Each drTemp In dsTemp.Tables(0).Rows
                cbParentesco.Items.Add(CStr(drTemp("CodParentesco")).Trim & " - " & CStr(drTemp("Descripcion")).Trim)
                cbPar.Items.Add(CStr(drTemp("Descripcion")).Trim)
            Next

            Me.cbPar.SelectedIndex = 0
            Me.cbParentesco.SelectedIndex = 0

            If Me.btnGuardar1.Text = "&Modificar" Then

                Dim ds As New Data.DataSet
                Dim Filas As Data.DataRowCollection

                ds = oAsoc.ConsultarReferencias("*", "Dui='" & pDui & "' and NumRef=" & pCorrelativo & "", "Dui", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNombres.Text = CStr(Filas.Item(0)("Nombre"))
                    txtApe1.Text = CStr(Filas.Item(0)("Apellido1"))
                    txtApe2.Text = CStr(Filas.Item(0)("Apellido2"))
                    txtDir.Text = CStr(Filas.Item(0)("Direccion"))
                    txtTelCasa.Text = CStr(Filas.Item(0)("TelCasa"))
                    txtTelOfic.Text = CStr(Filas.Item(0)("TelOficina"))
                    txtCorreo.Text = CStr(Filas.Item(0)("Emails"))
                    txtDirTrab.Text = CStr(Filas.Item(0)("DireccionTrabajo"))
                    txtLugTrab.Text = CStr(Filas.Item(0)("LugarTrabajo"))
                    txtCargo.Text = CStr(Filas.Item(0)("Cargo"))
                    txtCelular.Text = CStr(Filas.Item(0)("Celular"))
                    For x = 0 To cbParentesco.Items.Count - 1
                        cbParentesco.SelectedIndex = x
                        If Mid(cbParentesco.Text, 1, 5).Trim = Trim(IIf(IsDBNull(Filas.Item(0)("CodParentesco")), "", Filas.Item(0)("CodParentesco"))) Then
                            cbParentesco.SelectedIndex = x
                            cbPar.SelectedIndex = x
                            Exit For
                        End If
                    Next

                End If

            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String
        Try
            Select Case oAsoc.AutorizaDatos(pDui, pCorrelativo, txtApe1.Text, txtNombres.Text, "x")
                Case 1
                    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
                Case 2
                    MsgBox("El campo Número de Referencia no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
                Case 3
                    MsgBox("El campo Apellido no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
                Case 4
                    MsgBox("El campo Nombres no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
            End Select

            If validarCamposRequeridos() = False Then
                Exit Sub
            End If


            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "DUI,NumRef,Apellido1,Apellido2,Nombre,Direccion,TelCasa,LugarTrabajo,Cargo,DireccionTrabajo,TelOficina,Emails,CodParentesco,Celular"
                pValores = "'" & Trim(pDui) & "'," & oAsoc.ObtenerCorrelativoReferencias(pDui, sUsuario, sPassword, sSucursal) & ",'" & Trim(txtApe1.Text) & "','" & Trim(txtApe2.Text) & "','" & Trim(txtNombres.Text) & "','" & Trim(txtDir.Text) & "','" & Trim(txtTelCasa.Text) & "','" & Trim(txtLugTrab.Text) & "','" & Trim(txtCargo.Text) & "','" & Trim(txtDirTrab.Text) & "','" & Trim(txtTelOfic.Text) & "','" & Trim(txtCorreo.Text) & "','" & Me.cbParentesco.Text.Substring(0, 5).Trim & "','" & txtCelular.Text.Trim & "'"
                If oAsoc.InsertarReferencias(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("La Referencia ha sido agregada.", MsgBoxStyle.Information)
                    ofrm.txtNoSocio.ReadOnly = True
                    ofrm.txtDui.ReadOnly = True
                    ofrm.txtNombre.ReadOnly = True
                    Me.Dispose()
                Else
                    MsgBox("La Referencia NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Apellido1='" & Trim(txtApe1.Text) &
                "',Apellido2='" & Trim(Me.txtApe2.Text) &
                "',Nombre='" & Trim(Me.txtNombres.Text) &
                "',Direccion='" & Trim(txtDir.Text) &
                "',TelCasa='" & Trim(txtTelCasa.Text) &
                "',LugarTrabajo='" & Trim(txtLugTrab.Text) &
                "',Cargo='" & Trim(txtCargo.Text) &
                "',DireccionTrabajo='" & Trim(txtDirTrab.Text) &
                "',TelOficina='" & Trim(txtTelOfic.Text) &
                "',Emails='" & Trim(txtCorreo.Text) &
                "',CodParentesco='" & Me.cbParentesco.Text.Substring(0, 5).Trim &
                "',Celular = '" & txtCelular.Text & "'"
                If oAsoc.ModificarReferencias("NumRef=" & pCorrelativo & " and Dui='" & pDui & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("La Referencia ha sido modificada.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("La Referencia no ha sido modificada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbPar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPar.SelectedIndexChanged
        Me.cbParentesco.SelectedIndex = Me.cbPar.SelectedIndex
    End Sub

    Public Function validarCamposRequeridos() As Boolean
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

        If cbParentesco.SelectedIndex <= 0 Then
            Me.ErrorProvider1.SetError(cbParentesco, "Campo Requerido")
            valido = False
        End If
        If cbPar.SelectedIndex <= 0 Then
            Me.ErrorProvider1.SetError(cbPar, "Campo Requerido")
            valido = False
        End If
        Return valido
    End Function

    Private Sub frmMsDetReferencia_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class