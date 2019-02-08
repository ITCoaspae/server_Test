Public Class frmMsCrPagadurias
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkFirmaSello As System.Windows.Forms.CheckBox
    Friend WithEvents chkExperiencia As System.Windows.Forms.CheckBox
    Friend WithEvents cbTipoEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoEmpresa As System.Windows.Forms.Label
    Friend WithEvents cbGiro As System.Windows.Forms.ComboBox
    Friend WithEvents lblGiroEmpresa As System.Windows.Forms.Label
    Friend WithEvents mtTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblCapitalSocial As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFundacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFundación As System.Windows.Forms.Label
    Friend WithEvents lblRegistroEmpresa As System.Windows.Forms.Label
    Friend WithEvents txtNoRegistro As System.Windows.Forms.TextBox
    Friend WithEvents mtNit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblNit As System.Windows.Forms.Label
    Friend WithEvents lblSitioWeb As System.Windows.Forms.Label
    Friend WithEvents txtSitioWeb As System.Windows.Forms.TextBox
    Public accion As Integer '1= insertar,2=modificar,3=consultar
    Public pCodigo As String
    Friend WithEvents txtCapiSocial As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Dim credito As New wrCredito.wsLibCred

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
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkDomicilio As System.Windows.Forms.CheckBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkDomicilio = New System.Windows.Forms.CheckBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCapiSocial = New C1.Win.C1Input.C1TextBox()
        Me.txtSitioWeb = New System.Windows.Forms.TextBox()
        Me.lblSitioWeb = New System.Windows.Forms.Label()
        Me.mtNit = New System.Windows.Forms.MaskedTextBox()
        Me.lblNit = New System.Windows.Forms.Label()
        Me.txtNoRegistro = New System.Windows.Forms.TextBox()
        Me.lblRegistroEmpresa = New System.Windows.Forms.Label()
        Me.lblCapitalSocial = New System.Windows.Forms.Label()
        Me.dtpFechaFundacion = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFundación = New System.Windows.Forms.Label()
        Me.chkFirmaSello = New System.Windows.Forms.CheckBox()
        Me.chkExperiencia = New System.Windows.Forms.CheckBox()
        Me.cbTipoEmpresa = New System.Windows.Forms.ComboBox()
        Me.lblTipoEmpresa = New System.Windows.Forms.Label()
        Me.cbGiro = New System.Windows.Forms.ComboBox()
        Me.lblGiroEmpresa = New System.Windows.Forms.Label()
        Me.mtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        CType(Me.txtCapiSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(113, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(362, 20)
        Me.txtNombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre Pagaduría:"
        '
        'chkDomicilio
        '
        Me.chkDomicilio.Location = New System.Drawing.Point(221, 9)
        Me.chkDomicilio.Name = "chkDomicilio"
        Me.chkDomicilio.Size = New System.Drawing.Size(128, 24)
        Me.chkDomicilio.TabIndex = 2
        Me.chkDomicilio.Text = "&Trae Planilla"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.Location = New System.Drawing.Point(113, 71)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(362, 40)
        Me.txtDireccion.TabIndex = 6
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(113, 11)
        Me.txtCodigo.MaxLength = 100
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(88, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cód. Pagaduría:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dirección:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtCapiSocial)
        Me.Panel1.Controls.Add(Me.txtSitioWeb)
        Me.Panel1.Controls.Add(Me.lblSitioWeb)
        Me.Panel1.Controls.Add(Me.mtNit)
        Me.Panel1.Controls.Add(Me.lblNit)
        Me.Panel1.Controls.Add(Me.txtNoRegistro)
        Me.Panel1.Controls.Add(Me.lblRegistroEmpresa)
        Me.Panel1.Controls.Add(Me.lblCapitalSocial)
        Me.Panel1.Controls.Add(Me.dtpFechaFundacion)
        Me.Panel1.Controls.Add(Me.lblFechaFundación)
        Me.Panel1.Controls.Add(Me.chkFirmaSello)
        Me.Panel1.Controls.Add(Me.chkExperiencia)
        Me.Panel1.Controls.Add(Me.cbTipoEmpresa)
        Me.Panel1.Controls.Add(Me.lblTipoEmpresa)
        Me.Panel1.Controls.Add(Me.cbGiro)
        Me.Panel1.Controls.Add(Me.lblGiroEmpresa)
        Me.Panel1.Controls.Add(Me.mtTelefono)
        Me.Panel1.Controls.Add(Me.lblTelefono)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chkDomicilio)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 273)
        Me.Panel1.TabIndex = 3
        '
        'txtCapiSocial
        '
        Me.txtCapiSocial.BackColor = System.Drawing.Color.White
        Me.txtCapiSocial.DataType = GetType(Decimal)
        Me.txtCapiSocial.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtCapiSocial.Location = New System.Drawing.Point(361, 170)
        Me.txtCapiSocial.MaxLength = 10000000
        Me.txtCapiSocial.Name = "txtCapiSocial"
        Me.txtCapiSocial.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtCapiSocial.Size = New System.Drawing.Size(114, 20)
        Me.txtCapiSocial.TabIndex = 18
        Me.txtCapiSocial.Tag = Nothing
        Me.txtCapiSocial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtSitioWeb
        '
        Me.txtSitioWeb.BackColor = System.Drawing.Color.White
        Me.txtSitioWeb.Location = New System.Drawing.Point(113, 232)
        Me.txtSitioWeb.Name = "txtSitioWeb"
        Me.txtSitioWeb.Size = New System.Drawing.Size(362, 20)
        Me.txtSitioWeb.TabIndex = 24
        '
        'lblSitioWeb
        '
        Me.lblSitioWeb.AutoSize = True
        Me.lblSitioWeb.Location = New System.Drawing.Point(6, 235)
        Me.lblSitioWeb.Name = "lblSitioWeb"
        Me.lblSitioWeb.Size = New System.Drawing.Size(56, 13)
        Me.lblSitioWeb.TabIndex = 23
        Me.lblSitioWeb.Text = "Sitio Web:"
        '
        'mtNit
        '
        Me.mtNit.BackColor = System.Drawing.Color.White
        Me.mtNit.Location = New System.Drawing.Point(315, 196)
        Me.mtNit.Mask = "0000-000000-000-0"
        Me.mtNit.Name = "mtNit"
        Me.mtNit.Size = New System.Drawing.Size(112, 20)
        Me.mtNit.TabIndex = 22
        '
        'lblNit
        '
        Me.lblNit.AutoSize = True
        Me.lblNit.Location = New System.Drawing.Point(281, 196)
        Me.lblNit.Name = "lblNit"
        Me.lblNit.Size = New System.Drawing.Size(28, 13)
        Me.lblNit.TabIndex = 21
        Me.lblNit.Text = "NIT:"
        '
        'txtNoRegistro
        '
        Me.txtNoRegistro.BackColor = System.Drawing.Color.White
        Me.txtNoRegistro.Location = New System.Drawing.Point(113, 196)
        Me.txtNoRegistro.Name = "txtNoRegistro"
        Me.txtNoRegistro.Size = New System.Drawing.Size(152, 20)
        Me.txtNoRegistro.TabIndex = 20
        '
        'lblRegistroEmpresa
        '
        Me.lblRegistroEmpresa.AutoSize = True
        Me.lblRegistroEmpresa.Location = New System.Drawing.Point(6, 199)
        Me.lblRegistroEmpresa.Name = "lblRegistroEmpresa"
        Me.lblRegistroEmpresa.Size = New System.Drawing.Size(69, 26)
        Me.lblRegistroEmpresa.TabIndex = 19
        Me.lblRegistroEmpresa.Text = "No. Registro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Empresa:"
        '
        'lblCapitalSocial
        '
        Me.lblCapitalSocial.AutoSize = True
        Me.lblCapitalSocial.Location = New System.Drawing.Point(281, 173)
        Me.lblCapitalSocial.Name = "lblCapitalSocial"
        Me.lblCapitalSocial.Size = New System.Drawing.Size(74, 13)
        Me.lblCapitalSocial.TabIndex = 17
        Me.lblCapitalSocial.Text = "Capital Social:"
        '
        'dtpFechaFundacion
        '
        Me.dtpFechaFundacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFundacion.Location = New System.Drawing.Point(113, 170)
        Me.dtpFechaFundacion.Name = "dtpFechaFundacion"
        Me.dtpFechaFundacion.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaFundacion.TabIndex = 16
        '
        'lblFechaFundación
        '
        Me.lblFechaFundación.AutoSize = True
        Me.lblFechaFundación.Location = New System.Drawing.Point(6, 170)
        Me.lblFechaFundación.Name = "lblFechaFundación"
        Me.lblFechaFundación.Size = New System.Drawing.Size(93, 13)
        Me.lblFechaFundación.TabIndex = 15
        Me.lblFechaFundación.Text = "Fecha Fundación:"
        '
        'chkFirmaSello
        '
        Me.chkFirmaSello.AutoSize = True
        Me.chkFirmaSello.Location = New System.Drawing.Point(396, 148)
        Me.chkFirmaSello.Name = "chkFirmaSello"
        Me.chkFirmaSello.Size = New System.Drawing.Size(79, 17)
        Me.chkFirmaSello.TabIndex = 14
        Me.chkFirmaSello.Text = "Firma/Sello"
        Me.chkFirmaSello.UseVisualStyleBackColor = True
        '
        'chkExperiencia
        '
        Me.chkExperiencia.AutoSize = True
        Me.chkExperiencia.Location = New System.Drawing.Point(309, 148)
        Me.chkExperiencia.Name = "chkExperiencia"
        Me.chkExperiencia.Size = New System.Drawing.Size(81, 17)
        Me.chkExperiencia.TabIndex = 13
        Me.chkExperiencia.Text = "Experiencia"
        Me.chkExperiencia.UseVisualStyleBackColor = True
        '
        'cbTipoEmpresa
        '
        Me.cbTipoEmpresa.BackColor = System.Drawing.Color.White
        Me.cbTipoEmpresa.FormattingEnabled = True
        Me.cbTipoEmpresa.Location = New System.Drawing.Point(113, 143)
        Me.cbTipoEmpresa.Name = "cbTipoEmpresa"
        Me.cbTipoEmpresa.Size = New System.Drawing.Size(190, 21)
        Me.cbTipoEmpresa.TabIndex = 12
        '
        'lblTipoEmpresa
        '
        Me.lblTipoEmpresa.AutoSize = True
        Me.lblTipoEmpresa.Location = New System.Drawing.Point(3, 143)
        Me.lblTipoEmpresa.Name = "lblTipoEmpresa"
        Me.lblTipoEmpresa.Size = New System.Drawing.Size(90, 13)
        Me.lblTipoEmpresa.TabIndex = 11
        Me.lblTipoEmpresa.Text = "Tipo de Empresa:"
        '
        'cbGiro
        '
        Me.cbGiro.BackColor = System.Drawing.Color.White
        Me.cbGiro.FormattingEnabled = True
        Me.cbGiro.Location = New System.Drawing.Point(253, 116)
        Me.cbGiro.Name = "cbGiro"
        Me.cbGiro.Size = New System.Drawing.Size(222, 21)
        Me.cbGiro.TabIndex = 10
        '
        'lblGiroEmpresa
        '
        Me.lblGiroEmpresa.AutoSize = True
        Me.lblGiroEmpresa.Location = New System.Drawing.Point(218, 116)
        Me.lblGiroEmpresa.Name = "lblGiroEmpresa"
        Me.lblGiroEmpresa.Size = New System.Drawing.Size(29, 13)
        Me.lblGiroEmpresa.TabIndex = 9
        Me.lblGiroEmpresa.Text = "Giro:"
        '
        'mtTelefono
        '
        Me.mtTelefono.BackColor = System.Drawing.Color.White
        Me.mtTelefono.Location = New System.Drawing.Point(113, 117)
        Me.mtTelefono.Mask = "0000-0000"
        Me.mtTelefono.Name = "mtTelefono"
        Me.mtTelefono.Size = New System.Drawing.Size(88, 20)
        Me.mtTelefono.TabIndex = 8
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(3, 116)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 7
        Me.lblTelefono.Text = "Teléfono:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(438, 342)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 213
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrPagadurias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(530, 389)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(530, 389)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(530, 389)
        Me.Name = "frmMsCrPagadurias"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Pagadurías"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtCapiSocial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub llenarTipoEmpresa()
        Dim dts As New DataSet
        dts = credito.consultarPrTipoEmpresa()
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTipoEmpresa.DataSource = dts.Tables(0)
            End If
        End If

    End Sub
    Public Sub llenarGiroEmpresa()
        Dim dts As New DataSet
        dts = credito.consultarPrGiroEmpresa(0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbGiro.DataSource = dts.Tables(0)
            End If
        End If
    End Sub

    Private Sub frmMsCrPagadurias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbGiro.DisplayMember = "descripcion"
        Me.cbGiro.ValueMember = "idGiroEmpresa"
        Me.cbTipoEmpresa.DisplayMember = "descripcion"
        Me.cbTipoEmpresa.ValueMember = "idTipoEmp"
        Try
            If accion = 1 Then
                llenarTipoEmpresa()
                llenarGiroEmpresa()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Sub limpiar()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        mtTelefono.Text = ""
        chkExperiencia.Checked = False
        chkFirmaSello.Checked = False
        dtpFechaFundacion.Value = Now
        txtCapiSocial.Clear()
        txtNoRegistro.Text = ""
        mtNit.Text = ""
        txtSitioWeb.Text = ""
        Me.cbTipoEmpresa.SelectedIndex = 0
        Me.cbGiro.SelectedIndex = 0
    End Sub
    Protected Function validaciones()

        If Me.txtNombre.Text.Trim.Equals("") Then
            MsgBox("El campo Nombre no puede quedar vacio", MsgBoxStyle.Information, "Módulo - Créditos")
            Return False
        ElseIf Me.cbGiro.Text <> "" And Me.cbTipoEmpresa.Text <> "" Then
            Return True
        ElseIf Me.cbGiro.Text <> "" And Me.cbTipoEmpresa.Text = "" Then
            MsgBox("El campo Tipo de Empresa no puede quedar vacio", MsgBoxStyle.Information, "Módulo - Créditos")
            Return False
        ElseIf Me.cbGiro.Text <> "" And Me.cbTipoEmpresa.Text = "" Then
            MsgBox("El campo Giro de Empresa no puede quedar vacio", MsgBoxStyle.Information, "Módulo - Créditos")
            Return False
        ElseIf Me.cbGiro.Text = "" And Me.cbTipoEmpresa.Text = "" Then
            MsgBox("El campo Giro y Tipo de Empresa no puede quedar vacio", MsgBoxStyle.Information, "Módulo - Créditos")
            Return False
        End If
    End Function

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If validaciones() = True Then
                If accion = 1 Then
                    If credito.insertarPrPagadurias(txtNombre.Text.Trim, txtDireccion.Text.Trim, mtTelefono.Text.Trim, cbGiro.SelectedValue, cbTipoEmpresa.SelectedValue, chkExperiencia.Checked, chkFirmaSello.Checked, Format(dtpFechaFundacion.Value, "Short Date"), txtCapiSocial.Value, txtNoRegistro.Text.Trim, mtNit.Text.Trim, txtSitioWeb.Text.Trim, Now, sUsuario) > 0 Then
                        MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                        limpiar()
                    End If
                ElseIf accion = 2 Then
                    If credito.ModificarPrPagadurias(pCodigo, txtNombre.Text.Trim, txtDireccion.Text.Trim, mtTelefono.Text.Trim, cbGiro.SelectedValue, cbTipoEmpresa.SelectedValue, chkExperiencia.Checked, chkFirmaSello.Checked, Format(dtpFechaFundacion.Value, "Short Date"), txtCapiSocial.Value, txtNoRegistro.Text.Trim, mtNit.Text.Trim, txtSitioWeb.Text.Trim, Now, sUsuario) > 0 Then
                        MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
