<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMActividadEco
    Inherits MetroFramework.Forms.MetroForm ''Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtTelOficina = New System.Windows.Forms.MaskedTextBox()
        Me.txtDescripcionActEco = New System.Windows.Forms.TextBox()
        Me.txtCodActEconomica = New System.Windows.Forms.TextBox()
        Me.cbLugarTrabajo = New System.Windows.Forms.ComboBox()
        Me.txtGiroPrim = New System.Windows.Forms.TextBox()
        Me.lblLugarTrabajo = New System.Windows.Forms.Label()
        Me.lblGiro = New System.Windows.Forms.Label()
        Me.txtRazonSocialPrim = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtDirOfi = New System.Windows.Forms.TextBox()
        Me.lblDirOfi = New System.Windows.Forms.Label()
        Me.cbMunOfi = New System.Windows.Forms.ComboBox()
        Me.lblMunicipioOfi = New System.Windows.Forms.Label()
        Me.cbDeptoOfi = New System.Windows.Forms.ComboBox()
        Me.lblDeptoTrabajo = New System.Windows.Forms.Label()
        Me.txtExtOficinaPrim = New System.Windows.Forms.TextBox()
        Me.lblExtOficina = New System.Windows.Forms.Label()
        Me.lblTelOfic = New System.Windows.Forms.Label()
        Me.txtIngresosPrim = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.dtpFechaIniTra = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblSeccionTrabajo = New System.Windows.Forms.Label()
        Me.lblEstadoLaboral = New System.Windows.Forms.Label()
        Me.txtDptoTrabajo = New System.Windows.Forms.TextBox()
        Me.txtNomComEc = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkcontribuyente = New System.Windows.Forms.CheckBox()
        Me.txtNoRegContribuyente = New System.Windows.Forms.TextBox()
        Me.chkNegFormal = New System.Windows.Forms.CheckBox()
        Me.gbUIF = New System.Windows.Forms.GroupBox()
        Me.dtpVencimientoUIF = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechAcre = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaAcreditacion = New System.Windows.Forms.Label()
        Me.txtNoAcreUIF = New System.Windows.Forms.TextBox()
        Me.lblNoAcreditacionUIF = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEstadoLaboral = New System.Windows.Forms.ComboBox()
        Me.btnGuardarDom = New MetroFramework.Controls.MetroButton()
        Me.chkPrincipal = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.txtIngresosPrim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUIF.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTelOficina
        '
        Me.txtTelOficina.BackColor = System.Drawing.Color.White
        Me.txtTelOficina.Location = New System.Drawing.Point(747, 407)
        Me.txtTelOficina.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelOficina.Mask = "0000-0000"
        Me.txtTelOficina.Name = "txtTelOficina"
        Me.txtTelOficina.Size = New System.Drawing.Size(101, 22)
        Me.txtTelOficina.TabIndex = 67
        '
        'txtDescripcionActEco
        '
        Me.txtDescripcionActEco.BackColor = System.Drawing.Color.White
        Me.txtDescripcionActEco.Enabled = False
        Me.txtDescripcionActEco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionActEco.Location = New System.Drawing.Point(215, 78)
        Me.txtDescripcionActEco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcionActEco.Name = "txtDescripcionActEco"
        Me.txtDescripcionActEco.Size = New System.Drawing.Size(775, 23)
        Me.txtDescripcionActEco.TabIndex = 44
        '
        'txtCodActEconomica
        '
        Me.txtCodActEconomica.BackColor = System.Drawing.Color.White
        Me.txtCodActEconomica.Location = New System.Drawing.Point(139, 78)
        Me.txtCodActEconomica.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodActEconomica.Name = "txtCodActEconomica"
        Me.txtCodActEconomica.Size = New System.Drawing.Size(67, 22)
        Me.txtCodActEconomica.TabIndex = 43
        '
        'cbLugarTrabajo
        '
        Me.cbLugarTrabajo.BackColor = System.Drawing.Color.White
        Me.cbLugarTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLugarTrabajo.DropDownWidth = 639
        Me.cbLugarTrabajo.FormattingEnabled = True
        Me.cbLugarTrabajo.Location = New System.Drawing.Point(139, 119)
        Me.cbLugarTrabajo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbLugarTrabajo.MaxDropDownItems = 10
        Me.cbLugarTrabajo.Name = "cbLugarTrabajo"
        Me.cbLugarTrabajo.Size = New System.Drawing.Size(851, 24)
        Me.cbLugarTrabajo.TabIndex = 46
        '
        'txtGiroPrim
        '
        Me.txtGiroPrim.BackColor = System.Drawing.Color.White
        Me.txtGiroPrim.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiroPrim.Location = New System.Drawing.Point(115, 258)
        Me.txtGiroPrim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGiroPrim.MaxLength = 50
        Me.txtGiroPrim.Name = "txtGiroPrim"
        Me.txtGiroPrim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGiroPrim.Size = New System.Drawing.Size(875, 23)
        Me.txtGiroPrim.TabIndex = 53
        '
        'lblLugarTrabajo
        '
        Me.lblLugarTrabajo.AutoSize = True
        Me.lblLugarTrabajo.Location = New System.Drawing.Point(31, 113)
        Me.lblLugarTrabajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLugarTrabajo.Name = "lblLugarTrabajo"
        Me.lblLugarTrabajo.Size = New System.Drawing.Size(69, 34)
        Me.lblLugarTrabajo.TabIndex = 45
        Me.lblLugarTrabajo.Text = "Lugar de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trabajo:"
        '
        'lblGiro
        '
        Me.lblGiro.AutoSize = True
        Me.lblGiro.Location = New System.Drawing.Point(31, 262)
        Me.lblGiro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGiro.Name = "lblGiro"
        Me.lblGiro.Size = New System.Drawing.Size(39, 17)
        Me.lblGiro.TabIndex = 52
        Me.lblGiro.Text = "Giro:"
        '
        'txtRazonSocialPrim
        '
        Me.txtRazonSocialPrim.BackColor = System.Drawing.Color.White
        Me.txtRazonSocialPrim.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialPrim.Location = New System.Drawing.Point(115, 335)
        Me.txtRazonSocialPrim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRazonSocialPrim.MaxLength = 150
        Me.txtRazonSocialPrim.Name = "txtRazonSocialPrim"
        Me.txtRazonSocialPrim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRazonSocialPrim.Size = New System.Drawing.Size(875, 23)
        Me.txtRazonSocialPrim.TabIndex = 57
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(31, 332)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(53, 34)
        Me.Label51.TabIndex = 56
        Me.Label51.Text = "Razón " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Social:"
        '
        'txtDirOfi
        '
        Me.txtDirOfi.BackColor = System.Drawing.Color.White
        Me.txtDirOfi.Location = New System.Drawing.Point(115, 510)
        Me.txtDirOfi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDirOfi.Multiline = True
        Me.txtDirOfi.Name = "txtDirOfi"
        Me.txtDirOfi.Size = New System.Drawing.Size(875, 47)
        Me.txtDirOfi.TabIndex = 83
        '
        'lblDirOfi
        '
        Me.lblDirOfi.AutoSize = True
        Me.lblDirOfi.Location = New System.Drawing.Point(31, 513)
        Me.lblDirOfi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDirOfi.Name = "lblDirOfi"
        Me.lblDirOfi.Size = New System.Drawing.Size(76, 17)
        Me.lblDirOfi.TabIndex = 82
        Me.lblDirOfi.Text = "*Dirección:"
        '
        'cbMunOfi
        '
        Me.cbMunOfi.BackColor = System.Drawing.Color.White
        Me.cbMunOfi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMunOfi.FormattingEnabled = True
        Me.cbMunOfi.Location = New System.Drawing.Point(580, 476)
        Me.cbMunOfi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMunOfi.Name = "cbMunOfi"
        Me.cbMunOfi.Size = New System.Drawing.Size(409, 24)
        Me.cbMunOfi.TabIndex = 81
        '
        'lblMunicipioOfi
        '
        Me.lblMunicipioOfi.AutoSize = True
        Me.lblMunicipioOfi.Location = New System.Drawing.Point(495, 480)
        Me.lblMunicipioOfi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMunicipioOfi.Name = "lblMunicipioOfi"
        Me.lblMunicipioOfi.Size = New System.Drawing.Size(76, 17)
        Me.lblMunicipioOfi.TabIndex = 80
        Me.lblMunicipioOfi.Text = "*Municipio:"
        '
        'cbDeptoOfi
        '
        Me.cbDeptoOfi.BackColor = System.Drawing.Color.White
        Me.cbDeptoOfi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDeptoOfi.FormattingEnabled = True
        Me.cbDeptoOfi.Location = New System.Drawing.Point(115, 476)
        Me.cbDeptoOfi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbDeptoOfi.Name = "cbDeptoOfi"
        Me.cbDeptoOfi.Size = New System.Drawing.Size(371, 24)
        Me.cbDeptoOfi.TabIndex = 79
        '
        'lblDeptoTrabajo
        '
        Me.lblDeptoTrabajo.AutoSize = True
        Me.lblDeptoTrabajo.Location = New System.Drawing.Point(31, 480)
        Me.lblDeptoTrabajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeptoTrabajo.Name = "lblDeptoTrabajo"
        Me.lblDeptoTrabajo.Size = New System.Drawing.Size(55, 17)
        Me.lblDeptoTrabajo.TabIndex = 78
        Me.lblDeptoTrabajo.Text = "*Depto."
        '
        'txtExtOficinaPrim
        '
        Me.txtExtOficinaPrim.BackColor = System.Drawing.Color.White
        Me.txtExtOficinaPrim.Location = New System.Drawing.Point(937, 404)
        Me.txtExtOficinaPrim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtExtOficinaPrim.Name = "txtExtOficinaPrim"
        Me.txtExtOficinaPrim.Size = New System.Drawing.Size(52, 22)
        Me.txtExtOficinaPrim.TabIndex = 69
        '
        'lblExtOficina
        '
        Me.lblExtOficina.AutoSize = True
        Me.lblExtOficina.Location = New System.Drawing.Point(857, 405)
        Me.lblExtOficina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExtOficina.Name = "lblExtOficina"
        Me.lblExtOficina.Size = New System.Drawing.Size(56, 34)
        Me.lblExtOficina.TabIndex = 68
        Me.lblExtOficina.Text = "Ext. de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Oficina:"
        '
        'lblTelOfic
        '
        Me.lblTelOfic.AutoSize = True
        Me.lblTelOfic.Location = New System.Drawing.Point(681, 405)
        Me.lblTelOfic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelOfic.Name = "lblTelOfic"
        Me.lblTelOfic.Size = New System.Drawing.Size(56, 34)
        Me.lblTelOfic.TabIndex = 66
        Me.lblTelOfic.Text = "Tel." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Oficina:"
        '
        'txtIngresosPrim
        '
        Me.txtIngresosPrim.BackColor = System.Drawing.Color.White
        Me.txtIngresosPrim.DataType = GetType(Decimal)
        Me.txtIngresosPrim.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtIngresosPrim.Location = New System.Drawing.Point(115, 444)
        Me.txtIngresosPrim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIngresosPrim.Name = "txtIngresosPrim"
        Me.txtIngresosPrim.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtIngresosPrim.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtIngresosPrim.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtIngresosPrim.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtIngresosPrim.Size = New System.Drawing.Size(251, 25)
        Me.txtIngresosPrim.TabIndex = 71
        Me.txtIngresosPrim.Tag = Nothing
        Me.txtIngresosPrim.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 444)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "*Ingresos:"
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.White
        Me.txtCargo.Location = New System.Drawing.Point(311, 412)
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(361, 22)
        Me.txtCargo.TabIndex = 65
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(252, 416)
        Me.lblCargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(50, 17)
        Me.lblCargo.TabIndex = 64
        Me.lblCargo.Text = "Cargo:"
        '
        'dtpFechaIniTra
        '
        Me.dtpFechaIniTra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIniTra.Location = New System.Drawing.Point(115, 412)
        Me.dtpFechaIniTra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaIniTra.Name = "dtpFechaIniTra"
        Me.dtpFechaIniTra.Size = New System.Drawing.Size(128, 22)
        Me.dtpFechaIniTra.TabIndex = 63
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(31, 405)
        Me.lblFechaInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(47, 34)
        Me.lblFechaInicio.TabIndex = 62
        Me.lblFechaInicio.Text = "Fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inicio:"
        '
        'lblSeccionTrabajo
        '
        Me.lblSeccionTrabajo.AutoSize = True
        Me.lblSeccionTrabajo.Location = New System.Drawing.Point(373, 369)
        Me.lblSeccionTrabajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeccionTrabajo.Name = "lblSeccionTrabajo"
        Me.lblSeccionTrabajo.Size = New System.Drawing.Size(127, 34)
        Me.lblSeccionTrabajo.TabIndex = 60
        Me.lblSeccionTrabajo.Text = "Area,Seccion /" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depto. de Trabajo:"
        '
        'lblEstadoLaboral
        '
        Me.lblEstadoLaboral.AutoSize = True
        Me.lblEstadoLaboral.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoLaboral.Location = New System.Drawing.Point(31, 369)
        Me.lblEstadoLaboral.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstadoLaboral.Name = "lblEstadoLaboral"
        Me.lblEstadoLaboral.Size = New System.Drawing.Size(60, 32)
        Me.lblEstadoLaboral.TabIndex = 58
        Me.lblEstadoLaboral.Text = "Estado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laboral:"
        '
        'txtDptoTrabajo
        '
        Me.txtDptoTrabajo.BackColor = System.Drawing.Color.White
        Me.txtDptoTrabajo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDptoTrabajo.Location = New System.Drawing.Point(515, 372)
        Me.txtDptoTrabajo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDptoTrabajo.MaxLength = 50
        Me.txtDptoTrabajo.Name = "txtDptoTrabajo"
        Me.txtDptoTrabajo.Size = New System.Drawing.Size(475, 23)
        Me.txtDptoTrabajo.TabIndex = 61
        '
        'txtNomComEc
        '
        Me.txtNomComEc.BackColor = System.Drawing.Color.White
        Me.txtNomComEc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomComEc.Location = New System.Drawing.Point(115, 300)
        Me.txtNomComEc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNomComEc.MaxLength = 50
        Me.txtNomComEc.Name = "txtNomComEc"
        Me.txtNomComEc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNomComEc.Size = New System.Drawing.Size(875, 23)
        Me.txtNomComEc.TabIndex = 55
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(31, 293)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 32)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comercial:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(348, 228)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 16)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "NRC:"
        '
        'chkcontribuyente
        '
        Me.chkcontribuyente.AutoSize = True
        Me.chkcontribuyente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontribuyente.Location = New System.Drawing.Point(196, 226)
        Me.chkcontribuyente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkcontribuyente.Name = "chkcontribuyente"
        Me.chkcontribuyente.Size = New System.Drawing.Size(139, 20)
        Me.chkcontribuyente.TabIndex = 49
        Me.chkcontribuyente.Text = "Es Contribuyente"
        Me.chkcontribuyente.UseVisualStyleBackColor = True
        '
        'txtNoRegContribuyente
        '
        Me.txtNoRegContribuyente.BackColor = System.Drawing.Color.White
        Me.txtNoRegContribuyente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRegContribuyente.Location = New System.Drawing.Point(397, 226)
        Me.txtNoRegContribuyente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoRegContribuyente.MaxLength = 50
        Me.txtNoRegContribuyente.Name = "txtNoRegContribuyente"
        Me.txtNoRegContribuyente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoRegContribuyente.Size = New System.Drawing.Size(208, 23)
        Me.txtNoRegContribuyente.TabIndex = 51
        '
        'chkNegFormal
        '
        Me.chkNegFormal.AutoSize = True
        Me.chkNegFormal.Location = New System.Drawing.Point(35, 226)
        Me.chkNegFormal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkNegFormal.Name = "chkNegFormal"
        Me.chkNegFormal.Size = New System.Drawing.Size(129, 21)
        Me.chkNegFormal.TabIndex = 48
        Me.chkNegFormal.Text = "Negocio Formal"
        Me.chkNegFormal.UseVisualStyleBackColor = True
        '
        'gbUIF
        '
        Me.gbUIF.Controls.Add(Me.dtpVencimientoUIF)
        Me.gbUIF.Controls.Add(Me.Label4)
        Me.gbUIF.Controls.Add(Me.dtpFechAcre)
        Me.gbUIF.Controls.Add(Me.lblFechaAcreditacion)
        Me.gbUIF.Controls.Add(Me.txtNoAcreUIF)
        Me.gbUIF.Controls.Add(Me.lblNoAcreditacionUIF)
        Me.gbUIF.Location = New System.Drawing.Point(35, 153)
        Me.gbUIF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbUIF.Name = "gbUIF"
        Me.gbUIF.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbUIF.Size = New System.Drawing.Size(956, 66)
        Me.gbUIF.TabIndex = 47
        Me.gbUIF.TabStop = False
        Me.gbUIF.Text = "APNFD"
        '
        'dtpVencimientoUIF
        '
        Me.dtpVencimientoUIF.Enabled = False
        Me.dtpVencimientoUIF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimientoUIF.Location = New System.Drawing.Point(805, 27)
        Me.dtpVencimientoUIF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpVencimientoUIF.Name = "dtpVencimientoUIF"
        Me.dtpVencimientoUIF.Size = New System.Drawing.Size(136, 22)
        Me.dtpVencimientoUIF.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(663, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha Vencimiento:"
        '
        'dtpFechAcre
        '
        Me.dtpFechAcre.Enabled = False
        Me.dtpFechAcre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechAcre.Location = New System.Drawing.Point(517, 27)
        Me.dtpFechAcre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechAcre.Name = "dtpFechAcre"
        Me.dtpFechAcre.Size = New System.Drawing.Size(136, 22)
        Me.dtpFechAcre.TabIndex = 3
        '
        'lblFechaAcreditacion
        '
        Me.lblFechaAcreditacion.AutoSize = True
        Me.lblFechaAcreditacion.Location = New System.Drawing.Point(373, 30)
        Me.lblFechaAcreditacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaAcreditacion.Name = "lblFechaAcreditacion"
        Me.lblFechaAcreditacion.Size = New System.Drawing.Size(133, 17)
        Me.lblFechaAcreditacion.TabIndex = 2
        Me.lblFechaAcreditacion.Text = "Fecha Acreditación:"
        '
        'txtNoAcreUIF
        '
        Me.txtNoAcreUIF.BackColor = System.Drawing.Color.White
        Me.txtNoAcreUIF.Enabled = False
        Me.txtNoAcreUIF.Location = New System.Drawing.Point(135, 27)
        Me.txtNoAcreUIF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoAcreUIF.Name = "txtNoAcreUIF"
        Me.txtNoAcreUIF.Size = New System.Drawing.Size(229, 22)
        Me.txtNoAcreUIF.TabIndex = 1
        '
        'lblNoAcreditacionUIF
        '
        Me.lblNoAcreditacionUIF.AutoSize = True
        Me.lblNoAcreditacionUIF.Location = New System.Drawing.Point(8, 31)
        Me.lblNoAcreditacionUIF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoAcreditacionUIF.Name = "lblNoAcreditacionUIF"
        Me.lblNoAcreditacionUIF.Size = New System.Drawing.Size(116, 17)
        Me.lblNoAcreditacionUIF.TabIndex = 0
        Me.lblNoAcreditacionUIF.Text = "No. Acreditación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 34)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "*Tipo Actividad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Económica:"
        '
        'cbEstadoLaboral
        '
        Me.cbEstadoLaboral.BackColor = System.Drawing.Color.White
        Me.cbEstadoLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoLaboral.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoLaboral.Items.AddRange(New Object() {"Empleado", "Desempleado", "Jubilado", "Otro"})
        Me.cbEstadoLaboral.Location = New System.Drawing.Point(115, 372)
        Me.cbEstadoLaboral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbEstadoLaboral.Name = "cbEstadoLaboral"
        Me.cbEstadoLaboral.Size = New System.Drawing.Size(249, 24)
        Me.cbEstadoLaboral.TabIndex = 59
        '
        'btnGuardarDom
        '
        Me.btnGuardarDom.ForeColor = System.Drawing.Color.Teal
        Me.btnGuardarDom.Location = New System.Drawing.Point(893, 565)
        Me.btnGuardarDom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardarDom.Name = "btnGuardarDom"
        Me.btnGuardarDom.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardarDom.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardarDom.TabIndex = 84
        Me.btnGuardarDom.Text = "Guardar"
        Me.btnGuardarDom.UseSelectable = True
        '
        'chkPrincipal
        '
        Me.chkPrincipal.AutoSize = True
        Me.chkPrincipal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrincipal.Location = New System.Drawing.Point(903, 226)
        Me.chkPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkPrincipal.Name = "chkPrincipal"
        Me.chkPrincipal.Size = New System.Drawing.Size(84, 20)
        Me.chkPrincipal.TabIndex = 85
        Me.chkPrincipal.Text = "Principal"
        Me.chkPrincipal.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMActividadEco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 683)
        Me.Controls.Add(Me.chkPrincipal)
        Me.Controls.Add(Me.btnGuardarDom)
        Me.Controls.Add(Me.txtTelOficina)
        Me.Controls.Add(Me.txtDescripcionActEco)
        Me.Controls.Add(Me.txtCodActEconomica)
        Me.Controls.Add(Me.cbLugarTrabajo)
        Me.Controls.Add(Me.txtGiroPrim)
        Me.Controls.Add(Me.lblLugarTrabajo)
        Me.Controls.Add(Me.lblGiro)
        Me.Controls.Add(Me.txtRazonSocialPrim)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.txtDirOfi)
        Me.Controls.Add(Me.lblDirOfi)
        Me.Controls.Add(Me.cbMunOfi)
        Me.Controls.Add(Me.lblMunicipioOfi)
        Me.Controls.Add(Me.cbDeptoOfi)
        Me.Controls.Add(Me.lblDeptoTrabajo)
        Me.Controls.Add(Me.txtExtOficinaPrim)
        Me.Controls.Add(Me.lblExtOficina)
        Me.Controls.Add(Me.lblTelOfic)
        Me.Controls.Add(Me.txtIngresosPrim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.dtpFechaIniTra)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.lblSeccionTrabajo)
        Me.Controls.Add(Me.lblEstadoLaboral)
        Me.Controls.Add(Me.txtDptoTrabajo)
        Me.Controls.Add(Me.txtNomComEc)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.chkcontribuyente)
        Me.Controls.Add(Me.txtNoRegContribuyente)
        Me.Controls.Add(Me.chkNegFormal)
        Me.Controls.Add(Me.gbUIF)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbEstadoLaboral)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMActividadEco"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Actividad Económica"
        CType(Me.txtIngresosPrim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUIF.ResumeLayout(False)
        Me.gbUIF.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTelOficina As MaskedTextBox
    Friend WithEvents txtDescripcionActEco As TextBox
    Friend WithEvents txtCodActEconomica As TextBox
    Friend WithEvents cbLugarTrabajo As ComboBox
    Friend WithEvents txtGiroPrim As TextBox
    Friend WithEvents lblLugarTrabajo As Label
    Friend WithEvents lblGiro As Label
    Friend WithEvents txtRazonSocialPrim As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents txtDirOfi As TextBox
    Friend WithEvents lblDirOfi As Label
    Friend WithEvents cbMunOfi As ComboBox
    Friend WithEvents lblMunicipioOfi As Label
    Friend WithEvents cbDeptoOfi As ComboBox
    Friend WithEvents lblDeptoTrabajo As Label
    Friend WithEvents txtExtOficinaPrim As TextBox
    Friend WithEvents lblExtOficina As Label
    Friend WithEvents lblTelOfic As Label
    Friend WithEvents txtIngresosPrim As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents lblCargo As Label
    Friend WithEvents dtpFechaIniTra As DateTimePicker
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents lblSeccionTrabajo As Label
    Friend WithEvents lblEstadoLaboral As Label
    Friend WithEvents txtDptoTrabajo As TextBox
    Friend WithEvents txtNomComEc As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents chkcontribuyente As CheckBox
    Friend WithEvents txtNoRegContribuyente As TextBox
    Friend WithEvents chkNegFormal As CheckBox
    Friend WithEvents gbUIF As GroupBox
    Friend WithEvents dtpVencimientoUIF As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechAcre As DateTimePicker
    Friend WithEvents lblFechaAcreditacion As Label
    Friend WithEvents txtNoAcreUIF As TextBox
    Friend WithEvents lblNoAcreditacionUIF As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEstadoLaboral As ComboBox
    Friend WithEvents btnGuardarDom As MetroFramework.Controls.MetroButton
    Friend WithEvents chkPrincipal As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
