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
        Me.txtTelOficina.Location = New System.Drawing.Point(560, 331)
        Me.txtTelOficina.Mask = "0000-0000"
        Me.txtTelOficina.Name = "txtTelOficina"
        Me.txtTelOficina.Size = New System.Drawing.Size(77, 20)
        Me.txtTelOficina.TabIndex = 67
        '
        'txtDescripcionActEco
        '
        Me.txtDescripcionActEco.BackColor = System.Drawing.Color.White
        Me.txtDescripcionActEco.Enabled = False
        Me.txtDescripcionActEco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionActEco.Location = New System.Drawing.Point(161, 63)
        Me.txtDescripcionActEco.Name = "txtDescripcionActEco"
        Me.txtDescripcionActEco.Size = New System.Drawing.Size(582, 20)
        Me.txtDescripcionActEco.TabIndex = 44
        '
        'txtCodActEconomica
        '
        Me.txtCodActEconomica.BackColor = System.Drawing.Color.White
        Me.txtCodActEconomica.Location = New System.Drawing.Point(104, 63)
        Me.txtCodActEconomica.Name = "txtCodActEconomica"
        Me.txtCodActEconomica.Size = New System.Drawing.Size(51, 20)
        Me.txtCodActEconomica.TabIndex = 43
        '
        'cbLugarTrabajo
        '
        Me.cbLugarTrabajo.BackColor = System.Drawing.Color.White
        Me.cbLugarTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLugarTrabajo.DropDownWidth = 639
        Me.cbLugarTrabajo.FormattingEnabled = True
        Me.cbLugarTrabajo.Location = New System.Drawing.Point(104, 97)
        Me.cbLugarTrabajo.MaxDropDownItems = 10
        Me.cbLugarTrabajo.Name = "cbLugarTrabajo"
        Me.cbLugarTrabajo.Size = New System.Drawing.Size(639, 21)
        Me.cbLugarTrabajo.TabIndex = 46
        '
        'txtGiroPrim
        '
        Me.txtGiroPrim.BackColor = System.Drawing.Color.White
        Me.txtGiroPrim.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiroPrim.Location = New System.Drawing.Point(86, 210)
        Me.txtGiroPrim.MaxLength = 50
        Me.txtGiroPrim.Name = "txtGiroPrim"
        Me.txtGiroPrim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGiroPrim.Size = New System.Drawing.Size(657, 20)
        Me.txtGiroPrim.TabIndex = 53
        '
        'lblLugarTrabajo
        '
        Me.lblLugarTrabajo.AutoSize = True
        Me.lblLugarTrabajo.Location = New System.Drawing.Point(23, 92)
        Me.lblLugarTrabajo.Name = "lblLugarTrabajo"
        Me.lblLugarTrabajo.Size = New System.Drawing.Size(52, 26)
        Me.lblLugarTrabajo.TabIndex = 45
        Me.lblLugarTrabajo.Text = "Lugar de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trabajo:"
        '
        'lblGiro
        '
        Me.lblGiro.AutoSize = True
        Me.lblGiro.Location = New System.Drawing.Point(23, 213)
        Me.lblGiro.Name = "lblGiro"
        Me.lblGiro.Size = New System.Drawing.Size(29, 13)
        Me.lblGiro.TabIndex = 52
        Me.lblGiro.Text = "Giro:"
        '
        'txtRazonSocialPrim
        '
        Me.txtRazonSocialPrim.BackColor = System.Drawing.Color.White
        Me.txtRazonSocialPrim.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocialPrim.Location = New System.Drawing.Point(86, 272)
        Me.txtRazonSocialPrim.MaxLength = 150
        Me.txtRazonSocialPrim.Name = "txtRazonSocialPrim"
        Me.txtRazonSocialPrim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRazonSocialPrim.Size = New System.Drawing.Size(657, 20)
        Me.txtRazonSocialPrim.TabIndex = 57
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(23, 270)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(41, 26)
        Me.Label51.TabIndex = 56
        Me.Label51.Text = "Razón " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Social:"
        '
        'txtDirOfi
        '
        Me.txtDirOfi.BackColor = System.Drawing.Color.White
        Me.txtDirOfi.Location = New System.Drawing.Point(86, 414)
        Me.txtDirOfi.Multiline = True
        Me.txtDirOfi.Name = "txtDirOfi"
        Me.txtDirOfi.Size = New System.Drawing.Size(657, 39)
        Me.txtDirOfi.TabIndex = 83
        '
        'lblDirOfi
        '
        Me.lblDirOfi.AutoSize = True
        Me.lblDirOfi.Location = New System.Drawing.Point(23, 417)
        Me.lblDirOfi.Name = "lblDirOfi"
        Me.lblDirOfi.Size = New System.Drawing.Size(59, 13)
        Me.lblDirOfi.TabIndex = 82
        Me.lblDirOfi.Text = "*Dirección:"
        '
        'cbMunOfi
        '
        Me.cbMunOfi.BackColor = System.Drawing.Color.White
        Me.cbMunOfi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMunOfi.FormattingEnabled = True
        Me.cbMunOfi.Location = New System.Drawing.Point(435, 387)
        Me.cbMunOfi.Name = "cbMunOfi"
        Me.cbMunOfi.Size = New System.Drawing.Size(308, 21)
        Me.cbMunOfi.TabIndex = 81
        '
        'lblMunicipioOfi
        '
        Me.lblMunicipioOfi.AutoSize = True
        Me.lblMunicipioOfi.Location = New System.Drawing.Point(371, 390)
        Me.lblMunicipioOfi.Name = "lblMunicipioOfi"
        Me.lblMunicipioOfi.Size = New System.Drawing.Size(59, 13)
        Me.lblMunicipioOfi.TabIndex = 80
        Me.lblMunicipioOfi.Text = "*Municipio:"
        '
        'cbDeptoOfi
        '
        Me.cbDeptoOfi.BackColor = System.Drawing.Color.White
        Me.cbDeptoOfi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDeptoOfi.FormattingEnabled = True
        Me.cbDeptoOfi.Location = New System.Drawing.Point(86, 387)
        Me.cbDeptoOfi.Name = "cbDeptoOfi"
        Me.cbDeptoOfi.Size = New System.Drawing.Size(279, 21)
        Me.cbDeptoOfi.TabIndex = 79
        '
        'lblDeptoTrabajo
        '
        Me.lblDeptoTrabajo.AutoSize = True
        Me.lblDeptoTrabajo.Location = New System.Drawing.Point(23, 390)
        Me.lblDeptoTrabajo.Name = "lblDeptoTrabajo"
        Me.lblDeptoTrabajo.Size = New System.Drawing.Size(43, 13)
        Me.lblDeptoTrabajo.TabIndex = 78
        Me.lblDeptoTrabajo.Text = "*Depto."
        '
        'txtExtOficinaPrim
        '
        Me.txtExtOficinaPrim.BackColor = System.Drawing.Color.White
        Me.txtExtOficinaPrim.Location = New System.Drawing.Point(703, 328)
        Me.txtExtOficinaPrim.Name = "txtExtOficinaPrim"
        Me.txtExtOficinaPrim.Size = New System.Drawing.Size(40, 20)
        Me.txtExtOficinaPrim.TabIndex = 69
        '
        'lblExtOficina
        '
        Me.lblExtOficina.AutoSize = True
        Me.lblExtOficina.Location = New System.Drawing.Point(643, 329)
        Me.lblExtOficina.Name = "lblExtOficina"
        Me.lblExtOficina.Size = New System.Drawing.Size(43, 26)
        Me.lblExtOficina.TabIndex = 68
        Me.lblExtOficina.Text = "Ext. de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Oficina:"
        '
        'lblTelOfic
        '
        Me.lblTelOfic.AutoSize = True
        Me.lblTelOfic.Location = New System.Drawing.Point(511, 329)
        Me.lblTelOfic.Name = "lblTelOfic"
        Me.lblTelOfic.Size = New System.Drawing.Size(43, 26)
        Me.lblTelOfic.TabIndex = 66
        Me.lblTelOfic.Text = "Tel." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Oficina:"
        '
        'txtIngresosPrim
        '
        Me.txtIngresosPrim.BackColor = System.Drawing.Color.White
        Me.txtIngresosPrim.DataType = GetType(Decimal)
        Me.txtIngresosPrim.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtIngresosPrim.Location = New System.Drawing.Point(86, 361)
        Me.txtIngresosPrim.Name = "txtIngresosPrim"
        Me.txtIngresosPrim.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtIngresosPrim.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtIngresosPrim.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtIngresosPrim.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtIngresosPrim.Size = New System.Drawing.Size(188, 18)
        Me.txtIngresosPrim.TabIndex = 71
        Me.txtIngresosPrim.Tag = Nothing
        Me.txtIngresosPrim.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "*Ingresos:"
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.White
        Me.txtCargo.Location = New System.Drawing.Point(233, 335)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(272, 20)
        Me.txtCargo.TabIndex = 65
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(189, 338)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(38, 13)
        Me.lblCargo.TabIndex = 64
        Me.lblCargo.Text = "Cargo:"
        '
        'dtpFechaIniTra
        '
        Me.dtpFechaIniTra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIniTra.Location = New System.Drawing.Point(86, 335)
        Me.dtpFechaIniTra.Name = "dtpFechaIniTra"
        Me.dtpFechaIniTra.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaIniTra.TabIndex = 63
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(23, 329)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(37, 26)
        Me.lblFechaInicio.TabIndex = 62
        Me.lblFechaInicio.Text = "Fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inicio:"
        '
        'lblSeccionTrabajo
        '
        Me.lblSeccionTrabajo.AutoSize = True
        Me.lblSeccionTrabajo.Location = New System.Drawing.Point(280, 300)
        Me.lblSeccionTrabajo.Name = "lblSeccionTrabajo"
        Me.lblSeccionTrabajo.Size = New System.Drawing.Size(96, 26)
        Me.lblSeccionTrabajo.TabIndex = 60
        Me.lblSeccionTrabajo.Text = "Area,Seccion /" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depto. de Trabajo:"
        '
        'lblEstadoLaboral
        '
        Me.lblEstadoLaboral.AutoSize = True
        Me.lblEstadoLaboral.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoLaboral.Location = New System.Drawing.Point(23, 300)
        Me.lblEstadoLaboral.Name = "lblEstadoLaboral"
        Me.lblEstadoLaboral.Size = New System.Drawing.Size(46, 28)
        Me.lblEstadoLaboral.TabIndex = 58
        Me.lblEstadoLaboral.Text = "Estado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laboral:"
        '
        'txtDptoTrabajo
        '
        Me.txtDptoTrabajo.BackColor = System.Drawing.Color.White
        Me.txtDptoTrabajo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDptoTrabajo.Location = New System.Drawing.Point(386, 302)
        Me.txtDptoTrabajo.MaxLength = 50
        Me.txtDptoTrabajo.Name = "txtDptoTrabajo"
        Me.txtDptoTrabajo.Size = New System.Drawing.Size(357, 20)
        Me.txtDptoTrabajo.TabIndex = 61
        '
        'txtNomComEc
        '
        Me.txtNomComEc.BackColor = System.Drawing.Color.White
        Me.txtNomComEc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomComEc.Location = New System.Drawing.Point(86, 244)
        Me.txtNomComEc.MaxLength = 50
        Me.txtNomComEc.Name = "txtNomComEc"
        Me.txtNomComEc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNomComEc.Size = New System.Drawing.Size(657, 20)
        Me.txtNomComEc.TabIndex = 55
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(23, 238)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 28)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comercial:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(261, 185)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 14)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "NRC:"
        '
        'chkcontribuyente
        '
        Me.chkcontribuyente.AutoSize = True
        Me.chkcontribuyente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcontribuyente.Location = New System.Drawing.Point(147, 184)
        Me.chkcontribuyente.Name = "chkcontribuyente"
        Me.chkcontribuyente.Size = New System.Drawing.Size(108, 18)
        Me.chkcontribuyente.TabIndex = 49
        Me.chkcontribuyente.Text = "Es Contribuyente"
        Me.chkcontribuyente.UseVisualStyleBackColor = True
        '
        'txtNoRegContribuyente
        '
        Me.txtNoRegContribuyente.BackColor = System.Drawing.Color.White
        Me.txtNoRegContribuyente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRegContribuyente.Location = New System.Drawing.Point(298, 184)
        Me.txtNoRegContribuyente.MaxLength = 50
        Me.txtNoRegContribuyente.Name = "txtNoRegContribuyente"
        Me.txtNoRegContribuyente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoRegContribuyente.Size = New System.Drawing.Size(157, 20)
        Me.txtNoRegContribuyente.TabIndex = 51
        '
        'chkNegFormal
        '
        Me.chkNegFormal.AutoSize = True
        Me.chkNegFormal.Location = New System.Drawing.Point(26, 184)
        Me.chkNegFormal.Name = "chkNegFormal"
        Me.chkNegFormal.Size = New System.Drawing.Size(100, 17)
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
        Me.gbUIF.Location = New System.Drawing.Point(26, 124)
        Me.gbUIF.Name = "gbUIF"
        Me.gbUIF.Size = New System.Drawing.Size(717, 54)
        Me.gbUIF.TabIndex = 47
        Me.gbUIF.TabStop = False
        Me.gbUIF.Text = "APNFD"
        '
        'dtpVencimientoUIF
        '
        Me.dtpVencimientoUIF.Enabled = False
        Me.dtpVencimientoUIF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimientoUIF.Location = New System.Drawing.Point(604, 22)
        Me.dtpVencimientoUIF.Name = "dtpVencimientoUIF"
        Me.dtpVencimientoUIF.Size = New System.Drawing.Size(103, 20)
        Me.dtpVencimientoUIF.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(497, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha Vencimiento:"
        '
        'dtpFechAcre
        '
        Me.dtpFechAcre.Enabled = False
        Me.dtpFechAcre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechAcre.Location = New System.Drawing.Point(388, 22)
        Me.dtpFechAcre.Name = "dtpFechAcre"
        Me.dtpFechAcre.Size = New System.Drawing.Size(103, 20)
        Me.dtpFechAcre.TabIndex = 3
        '
        'lblFechaAcreditacion
        '
        Me.lblFechaAcreditacion.AutoSize = True
        Me.lblFechaAcreditacion.Location = New System.Drawing.Point(280, 24)
        Me.lblFechaAcreditacion.Name = "lblFechaAcreditacion"
        Me.lblFechaAcreditacion.Size = New System.Drawing.Size(102, 13)
        Me.lblFechaAcreditacion.TabIndex = 2
        Me.lblFechaAcreditacion.Text = "Fecha Acreditación:"
        '
        'txtNoAcreUIF
        '
        Me.txtNoAcreUIF.BackColor = System.Drawing.Color.White
        Me.txtNoAcreUIF.Enabled = False
        Me.txtNoAcreUIF.Location = New System.Drawing.Point(101, 22)
        Me.txtNoAcreUIF.Name = "txtNoAcreUIF"
        Me.txtNoAcreUIF.Size = New System.Drawing.Size(173, 20)
        Me.txtNoAcreUIF.TabIndex = 1
        '
        'lblNoAcreditacionUIF
        '
        Me.lblNoAcreditacionUIF.AutoSize = True
        Me.lblNoAcreditacionUIF.Location = New System.Drawing.Point(6, 25)
        Me.lblNoAcreditacionUIF.Name = "lblNoAcreditacionUIF"
        Me.lblNoAcreditacionUIF.Size = New System.Drawing.Size(89, 13)
        Me.lblNoAcreditacionUIF.TabIndex = 0
        Me.lblNoAcreditacionUIF.Text = "No. Acreditación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 26)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "*Tipo Actividad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Económica:"
        '
        'cbEstadoLaboral
        '
        Me.cbEstadoLaboral.BackColor = System.Drawing.Color.White
        Me.cbEstadoLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoLaboral.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoLaboral.Items.AddRange(New Object() {"Empleado", "Desempleado", "Jubilado", "Otro"})
        Me.cbEstadoLaboral.Location = New System.Drawing.Point(86, 302)
        Me.cbEstadoLaboral.Name = "cbEstadoLaboral"
        Me.cbEstadoLaboral.Size = New System.Drawing.Size(188, 22)
        Me.cbEstadoLaboral.TabIndex = 59
        '
        'btnGuardarDom
        '
        Me.btnGuardarDom.Location = New System.Drawing.Point(670, 459)
        Me.btnGuardarDom.Name = "btnGuardarDom"
        Me.btnGuardarDom.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardarDom.TabIndex = 84
        Me.btnGuardarDom.Text = "Guardar"
        Me.btnGuardarDom.UseSelectable = True
        Me.btnGuardarDom.UseStyleColors = True
        '
        'chkPrincipal
        '
        Me.chkPrincipal.AutoSize = True
        Me.chkPrincipal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrincipal.Location = New System.Drawing.Point(677, 184)
        Me.chkPrincipal.Name = "chkPrincipal"
        Me.chkPrincipal.Size = New System.Drawing.Size(66, 18)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 499)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMActividadEco"
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
