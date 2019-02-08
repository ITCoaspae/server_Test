<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsBCChequesRetAhorros
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.lblDUI = New System.Windows.Forms.Label()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        Me.btnPostearLibreta = New MetroFramework.Controls.MetroButton()
        Me.btnImprimirComprobante = New MetroFramework.Controls.MetroButton()
        Me.txtDuiTerceros = New C1.Win.C1Input.C1TextBox()
        Me.lblDuiTerceros = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtComprobante = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cbCtasAsoc = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtSaldoDisp = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.cbBancos = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtNoCheque = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFec = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtConcepto = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtCiudad = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumPartida = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.txtPagueseA = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.chkPersonNatural = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombreTerceros = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.lblAsociado = New MetroFramework.Controls.MetroLabel()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuiTerceros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(116, 64)
        Me.txtDui.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(154, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Location = New System.Drawing.Point(27, 64)
        Me.lblDUI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(31, 17)
        Me.lblDUI.TabIndex = 0
        Me.lblDUI.Text = "DUI"
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BackColor = System.Drawing.Color.White
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NEMonto.Calculator.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(152, 341)
        Me.C1NEMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.Size = New System.Drawing.Size(458, 23)
        Me.C1NEMonto.TabIndex = 17
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.C1NEMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(510, 652)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 35
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(363, 652)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(139, 34)
        Me.btnImprimir.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir.TabIndex = 34
        Me.btnImprimir.Text = "Imprimir Cheque"
        Me.btnImprimir.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir.UseSelectable = True
        Me.btnImprimir.UseStyleColors = True
        '
        'btnPostearLibreta
        '
        Me.btnPostearLibreta.Location = New System.Drawing.Point(227, 652)
        Me.btnPostearLibreta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPostearLibreta.Name = "btnPostearLibreta"
        Me.btnPostearLibreta.Size = New System.Drawing.Size(128, 34)
        Me.btnPostearLibreta.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnPostearLibreta.TabIndex = 33
        Me.btnPostearLibreta.Text = "Postear Libreta"
        Me.btnPostearLibreta.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnPostearLibreta.UseSelectable = True
        Me.btnPostearLibreta.UseStyleColors = True
        '
        'btnImprimirComprobante
        '
        Me.btnImprimirComprobante.Location = New System.Drawing.Point(30, 652)
        Me.btnImprimirComprobante.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimirComprobante.Name = "btnImprimirComprobante"
        Me.btnImprimirComprobante.Size = New System.Drawing.Size(189, 34)
        Me.btnImprimirComprobante.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimirComprobante.TabIndex = 32
        Me.btnImprimirComprobante.Text = "Imprimir Comprobante"
        Me.btnImprimirComprobante.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimirComprobante.UseSelectable = True
        Me.btnImprimirComprobante.UseStyleColors = True
        '
        'txtDuiTerceros
        '
        Me.txtDuiTerceros.BackColor = System.Drawing.Color.White
        Me.txtDuiTerceros.EditMask = "00000000-0"
        Me.txtDuiTerceros.Location = New System.Drawing.Point(152, 577)
        Me.txtDuiTerceros.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDuiTerceros.Name = "txtDuiTerceros"
        Me.txtDuiTerceros.NumericInput = False
        Me.txtDuiTerceros.Size = New System.Drawing.Size(458, 20)
        Me.txtDuiTerceros.TabIndex = 29
        Me.txtDuiTerceros.Tag = Nothing
        Me.txtDuiTerceros.Value = ""
        '
        'lblDuiTerceros
        '
        Me.lblDuiTerceros.AutoSize = True
        Me.lblDuiTerceros.ForeColor = System.Drawing.Color.Black
        Me.lblDuiTerceros.Location = New System.Drawing.Point(31, 580)
        Me.lblDuiTerceros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDuiTerceros.Name = "lblDuiTerceros"
        Me.lblDuiTerceros.Size = New System.Drawing.Size(33, 17)
        Me.lblDuiTerceros.TabIndex = 28
        Me.lblDuiTerceros.Text = "Dui:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "No. Comprobante:"
        '
        'txtComprobante
        '
        '
        '
        '
        Me.txtComprobante.CustomButton.Image = Nothing
        Me.txtComprobante.CustomButton.Location = New System.Drawing.Point(150, 1)
        Me.txtComprobante.CustomButton.Name = ""
        Me.txtComprobante.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtComprobante.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtComprobante.CustomButton.TabIndex = 1
        Me.txtComprobante.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtComprobante.CustomButton.UseSelectable = True
        Me.txtComprobante.CustomButton.Visible = False
        Me.txtComprobante.Enabled = False
        Me.txtComprobante.Lines = New String(-1) {}
        Me.txtComprobante.Location = New System.Drawing.Point(438, 61)
        Me.txtComprobante.MaxLength = 32767
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComprobante.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtComprobante.SelectedText = ""
        Me.txtComprobante.SelectionLength = 0
        Me.txtComprobante.SelectionStart = 0
        Me.txtComprobante.ShortcutsEnabled = True
        Me.txtComprobante.Size = New System.Drawing.Size(172, 23)
        Me.txtComprobante.TabIndex = 3
        Me.txtComprobante.UseSelectable = True
        Me.txtComprobante.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtComprobante.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(30, 136)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(82, 20)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "No. Cuenta:"
        '
        'cbCtasAsoc
        '
        Me.cbCtasAsoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCtasAsoc.FormattingEnabled = True
        Me.cbCtasAsoc.ItemHeight = 24
        Me.cbCtasAsoc.Location = New System.Drawing.Point(152, 136)
        Me.cbCtasAsoc.Name = "cbCtasAsoc"
        Me.cbCtasAsoc.Size = New System.Drawing.Size(458, 30)
        Me.cbCtasAsoc.TabIndex = 6
        Me.cbCtasAsoc.UseSelectable = True
        Me.cbCtasAsoc.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(30, 172)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(112, 20)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Saldo disponible:"
        '
        'txtSaldoDisp
        '
        '
        '
        '
        Me.txtSaldoDisp.CustomButton.Image = Nothing
        Me.txtSaldoDisp.CustomButton.Location = New System.Drawing.Point(436, 1)
        Me.txtSaldoDisp.CustomButton.Name = ""
        Me.txtSaldoDisp.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSaldoDisp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSaldoDisp.CustomButton.TabIndex = 1
        Me.txtSaldoDisp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSaldoDisp.CustomButton.UseSelectable = True
        Me.txtSaldoDisp.CustomButton.Visible = False
        Me.txtSaldoDisp.Lines = New String(-1) {}
        Me.txtSaldoDisp.Location = New System.Drawing.Point(152, 172)
        Me.txtSaldoDisp.MaxLength = 32767
        Me.txtSaldoDisp.Name = "txtSaldoDisp"
        Me.txtSaldoDisp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSaldoDisp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSaldoDisp.SelectedText = ""
        Me.txtSaldoDisp.SelectionLength = 0
        Me.txtSaldoDisp.SelectionStart = 0
        Me.txtSaldoDisp.ShortcutsEnabled = True
        Me.txtSaldoDisp.Size = New System.Drawing.Size(458, 23)
        Me.txtSaldoDisp.TabIndex = 8
        Me.txtSaldoDisp.UseSelectable = True
        Me.txtSaldoDisp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSaldoDisp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(30, 237)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(50, 20)
        Me.MetroLabel3.TabIndex = 10
        Me.MetroLabel3.Text = "Banco:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(30, 203)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(218, 25)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Información de cheque"
        '
        'cbBancos
        '
        Me.cbBancos.FormattingEnabled = True
        Me.cbBancos.ItemHeight = 24
        Me.cbBancos.Location = New System.Drawing.Point(152, 237)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(458, 30)
        Me.cbBancos.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbBancos.TabIndex = 11
        Me.cbBancos.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cbBancos.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(30, 275)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(87, 20)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "No. Cheque:"
        '
        'txtNoCheque
        '
        '
        '
        '
        Me.txtNoCheque.CustomButton.Image = Nothing
        Me.txtNoCheque.CustomButton.Location = New System.Drawing.Point(436, 1)
        Me.txtNoCheque.CustomButton.Name = ""
        Me.txtNoCheque.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNoCheque.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNoCheque.CustomButton.TabIndex = 1
        Me.txtNoCheque.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNoCheque.CustomButton.UseSelectable = True
        Me.txtNoCheque.CustomButton.Visible = False
        Me.txtNoCheque.Lines = New String(-1) {}
        Me.txtNoCheque.Location = New System.Drawing.Point(152, 275)
        Me.txtNoCheque.MaxLength = 32767
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoCheque.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNoCheque.SelectedText = ""
        Me.txtNoCheque.SelectionLength = 0
        Me.txtNoCheque.SelectionStart = 0
        Me.txtNoCheque.ShortcutsEnabled = True
        Me.txtNoCheque.Size = New System.Drawing.Size(458, 23)
        Me.txtNoCheque.TabIndex = 13
        Me.txtNoCheque.UseSelectable = True
        Me.txtNoCheque.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNoCheque.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(30, 304)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(49, 20)
        Me.MetroLabel6.TabIndex = 14
        Me.MetroLabel6.Text = "Fecha:"
        '
        'dtpFec
        '
        Me.dtpFec.Enabled = False
        Me.dtpFec.Location = New System.Drawing.Point(152, 304)
        Me.dtpFec.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFec.Name = "dtpFec"
        Me.dtpFec.Size = New System.Drawing.Size(458, 30)
        Me.dtpFec.TabIndex = 15
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(30, 341)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(66, 20)
        Me.MetroLabel7.TabIndex = 16
        Me.MetroLabel7.Text = "Cantidad:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(30, 376)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(72, 20)
        Me.MetroLabel8.TabIndex = 18
        Me.MetroLabel8.Text = "Concepto:"
        '
        'txtConcepto
        '
        '
        '
        '
        Me.txtConcepto.CustomButton.Image = Nothing
        Me.txtConcepto.CustomButton.Location = New System.Drawing.Point(400, 1)
        Me.txtConcepto.CustomButton.Name = ""
        Me.txtConcepto.CustomButton.Size = New System.Drawing.Size(57, 57)
        Me.txtConcepto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtConcepto.CustomButton.TabIndex = 1
        Me.txtConcepto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtConcepto.CustomButton.UseSelectable = True
        Me.txtConcepto.CustomButton.Visible = False
        Me.txtConcepto.Lines = New String(-1) {}
        Me.txtConcepto.Location = New System.Drawing.Point(152, 376)
        Me.txtConcepto.MaxLength = 32767
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConcepto.SelectedText = ""
        Me.txtConcepto.SelectionLength = 0
        Me.txtConcepto.SelectionStart = 0
        Me.txtConcepto.ShortcutsEnabled = True
        Me.txtConcepto.Size = New System.Drawing.Size(458, 59)
        Me.txtConcepto.TabIndex = 19
        Me.txtConcepto.UseSelectable = True
        Me.txtConcepto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtConcepto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(30, 441)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(55, 20)
        Me.MetroLabel9.TabIndex = 20
        Me.MetroLabel9.Text = "Ciudad:"
        '
        'txtCiudad
        '
        '
        '
        '
        Me.txtCiudad.CustomButton.Image = Nothing
        Me.txtCiudad.CustomButton.Location = New System.Drawing.Point(436, 1)
        Me.txtCiudad.CustomButton.Name = ""
        Me.txtCiudad.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCiudad.CustomButton.TabIndex = 1
        Me.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCiudad.CustomButton.UseSelectable = True
        Me.txtCiudad.CustomButton.Visible = False
        Me.txtCiudad.Lines = New String(-1) {}
        Me.txtCiudad.Location = New System.Drawing.Point(152, 441)
        Me.txtCiudad.MaxLength = 32767
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCiudad.SelectedText = ""
        Me.txtCiudad.SelectionLength = 0
        Me.txtCiudad.SelectionStart = 0
        Me.txtCiudad.ShortcutsEnabled = True
        Me.txtCiudad.Size = New System.Drawing.Size(458, 23)
        Me.txtCiudad.TabIndex = 21
        Me.txtCiudad.UseSelectable = True
        Me.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCiudad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNumPartida
        '
        '
        '
        '
        Me.txtNumPartida.CustomButton.Image = Nothing
        Me.txtNumPartida.CustomButton.Location = New System.Drawing.Point(436, 1)
        Me.txtNumPartida.CustomButton.Name = ""
        Me.txtNumPartida.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNumPartida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumPartida.CustomButton.TabIndex = 1
        Me.txtNumPartida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumPartida.CustomButton.UseSelectable = True
        Me.txtNumPartida.CustomButton.Visible = False
        Me.txtNumPartida.Lines = New String(-1) {}
        Me.txtNumPartida.Location = New System.Drawing.Point(152, 470)
        Me.txtNumPartida.MaxLength = 32767
        Me.txtNumPartida.Name = "txtNumPartida"
        Me.txtNumPartida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumPartida.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumPartida.SelectedText = ""
        Me.txtNumPartida.SelectionLength = 0
        Me.txtNumPartida.SelectionStart = 0
        Me.txtNumPartida.ShortcutsEnabled = True
        Me.txtNumPartida.Size = New System.Drawing.Size(458, 23)
        Me.txtNumPartida.TabIndex = 23
        Me.txtNumPartida.UseSelectable = True
        Me.txtNumPartida.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumPartida.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(30, 469)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(111, 20)
        Me.MetroLabel10.TabIndex = 22
        Me.MetroLabel10.Text = "Numero partida:"
        '
        'txtPagueseA
        '
        '
        '
        '
        Me.txtPagueseA.CustomButton.Image = Nothing
        Me.txtPagueseA.CustomButton.Location = New System.Drawing.Point(436, 1)
        Me.txtPagueseA.CustomButton.Name = ""
        Me.txtPagueseA.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPagueseA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPagueseA.CustomButton.TabIndex = 1
        Me.txtPagueseA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPagueseA.CustomButton.UseSelectable = True
        Me.txtPagueseA.CustomButton.Visible = False
        Me.txtPagueseA.Lines = New String(-1) {}
        Me.txtPagueseA.Location = New System.Drawing.Point(152, 499)
        Me.txtPagueseA.MaxLength = 32767
        Me.txtPagueseA.Name = "txtPagueseA"
        Me.txtPagueseA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPagueseA.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPagueseA.SelectedText = ""
        Me.txtPagueseA.SelectionLength = 0
        Me.txtPagueseA.SelectionStart = 0
        Me.txtPagueseA.ShortcutsEnabled = True
        Me.txtPagueseA.Size = New System.Drawing.Size(458, 23)
        Me.txtPagueseA.TabIndex = 25
        Me.txtPagueseA.UseSelectable = True
        Me.txtPagueseA.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPagueseA.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(30, 498)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(64, 20)
        Me.MetroLabel11.TabIndex = 24
        Me.MetroLabel11.Text = "Paguese:"
        '
        'chkPersonNatural
        '
        Me.chkPersonNatural.AutoSize = True
        Me.chkPersonNatural.Location = New System.Drawing.Point(152, 528)
        Me.chkPersonNatural.Name = "chkPersonNatural"
        Me.chkPersonNatural.Size = New System.Drawing.Size(118, 17)
        Me.chkPersonNatural.TabIndex = 26
        Me.chkPersonNatural.Text = "Persona Natural"
        Me.chkPersonNatural.UseSelectable = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel12.Location = New System.Drawing.Point(30, 548)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(226, 25)
        Me.MetroLabel12.TabIndex = 27
        Me.MetroLabel12.Text = "Información de terceros"
        '
        'txtNombreTerceros
        '
        '
        '
        '
        Me.txtNombreTerceros.CustomButton.Image = Nothing
        Me.txtNombreTerceros.CustomButton.Location = New System.Drawing.Point(436, 1)
        Me.txtNombreTerceros.CustomButton.Name = ""
        Me.txtNombreTerceros.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombreTerceros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombreTerceros.CustomButton.TabIndex = 1
        Me.txtNombreTerceros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombreTerceros.CustomButton.UseSelectable = True
        Me.txtNombreTerceros.CustomButton.Visible = False
        Me.txtNombreTerceros.Lines = New String(-1) {}
        Me.txtNombreTerceros.Location = New System.Drawing.Point(152, 609)
        Me.txtNombreTerceros.MaxLength = 32767
        Me.txtNombreTerceros.Name = "txtNombreTerceros"
        Me.txtNombreTerceros.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreTerceros.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreTerceros.SelectedText = ""
        Me.txtNombreTerceros.SelectionLength = 0
        Me.txtNombreTerceros.SelectionStart = 0
        Me.txtNombreTerceros.ShortcutsEnabled = True
        Me.txtNombreTerceros.Size = New System.Drawing.Size(458, 23)
        Me.txtNombreTerceros.TabIndex = 31
        Me.txtNombreTerceros.UseSelectable = True
        Me.txtNombreTerceros.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombreTerceros.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(30, 609)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(64, 20)
        Me.MetroLabel13.TabIndex = 30
        Me.MetroLabel13.Text = "Nombre:"
        '
        'lblAsociado
        '
        Me.lblAsociado.AutoSize = True
        Me.lblAsociado.Location = New System.Drawing.Point(29, 97)
        Me.lblAsociado.Name = "lblAsociado"
        Me.lblAsociado.Size = New System.Drawing.Size(65, 20)
        Me.lblAsociado.TabIndex = 4
        Me.lblAsociado.Text = "Asociado"
        '
        'frmMsBCChequesRetAhorros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(649, 748)
        Me.Controls.Add(Me.lblAsociado)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtNombreTerceros)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.btnPostearLibreta)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.btnImprimirComprobante)
        Me.Controls.Add(Me.C1NEMonto)
        Me.Controls.Add(Me.chkPersonNatural)
        Me.Controls.Add(Me.txtDuiTerceros)
        Me.Controls.Add(Me.lblDuiTerceros)
        Me.Controls.Add(Me.txtPagueseA)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.txtNumPartida)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.dtpFec)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtNoCheque)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.cbBancos)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtSaldoDisp)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.cbCtasAsoc)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtComprobante)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDUI)
        Me.Controls.Add(Me.txtDui)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsBCChequesRetAhorros"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Retiros Cuentas de Ahorro por Medio de Cheque"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuiTerceros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblDUI As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDuiTerceros As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblDuiTerceros As System.Windows.Forms.Label
    Friend WithEvents btnImprimirComprobante As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPostearLibreta As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtComprobante As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCtasAsoc As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSaldoDisp As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbBancos As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNoCheque As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFec As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtConcepto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCiudad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumPartida As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPagueseA As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkPersonNatural As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombreTerceros As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAsociado As MetroFramework.Controls.MetroLabel
End Class
