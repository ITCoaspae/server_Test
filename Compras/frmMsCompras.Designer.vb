<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsCompras
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
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTipoDocumento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTipoCont = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBloque = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNRC = New System.Windows.Forms.TextBox()
        Me.lblNRC = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.MaskedTextBox()
        Me.lblNIT = New System.Windows.Forms.Label()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.txtCodProveedor = New System.Windows.Forms.TextBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.txtNoComprobante = New System.Windows.Forms.TextBox()
        Me.lblNoComprobante = New System.Windows.Forms.Label()
        Me.gbComprasExentas = New System.Windows.Forms.GroupBox()
        Me.txtExInternacionales = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExImportaciones = New C1.Win.C1Input.C1NumericEdit()
        Me.lblExImportaciones = New System.Windows.Forms.Label()
        Me.txtExLocales = New C1.Win.C1Input.C1NumericEdit()
        Me.lblExLocales = New System.Windows.Forms.Label()
        Me.gbGravadas = New System.Windows.Forms.GroupBox()
        Me.txtGravadasInternacionales = New C1.Win.C1Input.C1NumericEdit()
        Me.lblGraInternacionales = New System.Windows.Forms.Label()
        Me.txtGraImportaciones = New C1.Win.C1Input.C1NumericEdit()
        Me.lblGraImportaciones = New System.Windows.Forms.Label()
        Me.txtGraLocales = New C1.Win.C1Input.C1NumericEdit()
        Me.lblGraLocales = New System.Windows.Forms.Label()
        Me.lblCreditoFiscal = New System.Windows.Forms.Label()
        Me.txtCreditoFiscal = New C1.Win.C1Input.C1NumericEdit()
        Me.txtRetTerceros = New C1.Win.C1Input.C1NumericEdit()
        Me.lblRetTerceros = New System.Windows.Forms.Label()
        Me.txtExImpuesto = New C1.Win.C1Input.C1NumericEdit()
        Me.lblSujetosExcluidos = New System.Windows.Forms.Label()
        Me.txtTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.lblObservación = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnCheques = New MetroFramework.Controls.MetroButton()
        Me.Panel2.SuspendLayout()
        CType(Me.txtBloque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbComprasExentas.SuspendLayout()
        CType(Me.txtExInternacionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExImportaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExLocales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGravadas.SuspendLayout()
        CType(Me.txtGravadasInternacionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGraImportaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGraLocales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreditoFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRetTerceros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExImpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(3, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 167
        Me.lblFecha.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(68, 9)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(87, 20)
        Me.dtpFecha.TabIndex = 168
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtTipoDocumento)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtTipoCont)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtBloque)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtNRC)
        Me.Panel2.Controls.Add(Me.lblNRC)
        Me.Panel2.Controls.Add(Me.txtNit)
        Me.Panel2.Controls.Add(Me.lblNIT)
        Me.Panel2.Controls.Add(Me.txtNombreProveedor)
        Me.Panel2.Controls.Add(Me.txtCodProveedor)
        Me.Panel2.Controls.Add(Me.lblProveedor)
        Me.Panel2.Controls.Add(Me.txtNoComprobante)
        Me.Panel2.Controls.Add(Me.lblNoComprobante)
        Me.Panel2.Controls.Add(Me.lblFecha)
        Me.Panel2.Controls.Add(Me.dtpFecha)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(489, 149)
        Me.Panel2.TabIndex = 169
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.BackColor = System.Drawing.Color.White
        Me.txtTipoDocumento.Location = New System.Drawing.Point(116, 120)
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.ReadOnly = True
        Me.txtTipoDocumento.Size = New System.Drawing.Size(362, 20)
        Me.txtTipoDocumento.TabIndex = 184
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 183
        Me.Label4.Text = "Tipo de Documento:"
        '
        'txtTipoCont
        '
        Me.txtTipoCont.BackColor = System.Drawing.Color.White
        Me.txtTipoCont.Enabled = False
        Me.txtTipoCont.Location = New System.Drawing.Point(116, 91)
        Me.txtTipoCont.Name = "txtTipoCont"
        Me.txtTipoCont.Size = New System.Drawing.Size(239, 20)
        Me.txtTipoCont.TabIndex = 182
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Tipo Contribuyente: "
        '
        'txtBloque
        '
        Me.txtBloque.BackColor = System.Drawing.Color.White
        Me.txtBloque.Location = New System.Drawing.Point(429, 6)
        Me.txtBloque.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txtBloque.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtBloque.Name = "txtBloque"
        Me.txtBloque.Size = New System.Drawing.Size(49, 20)
        Me.txtBloque.TabIndex = 180
        Me.txtBloque.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Bloque:"
        '
        'txtNRC
        '
        Me.txtNRC.BackColor = System.Drawing.Color.White
        Me.txtNRC.Location = New System.Drawing.Point(272, 35)
        Me.txtNRC.Name = "txtNRC"
        Me.txtNRC.Size = New System.Drawing.Size(206, 20)
        Me.txtNRC.TabIndex = 178
        '
        'lblNRC
        '
        Me.lblNRC.AutoSize = True
        Me.lblNRC.Location = New System.Drawing.Point(236, 38)
        Me.lblNRC.Name = "lblNRC"
        Me.lblNRC.Size = New System.Drawing.Size(30, 13)
        Me.lblNRC.TabIndex = 177
        Me.lblNRC.Text = "NRC"
        '
        'txtNit
        '
        Me.txtNit.BackColor = System.Drawing.Color.White
        Me.txtNit.Location = New System.Drawing.Point(68, 35)
        Me.txtNit.Mask = "0000-000000-000-0"
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(109, 20)
        Me.txtNit.TabIndex = 176
        '
        'lblNIT
        '
        Me.lblNIT.AutoSize = True
        Me.lblNIT.Location = New System.Drawing.Point(3, 38)
        Me.lblNIT.Name = "lblNIT"
        Me.lblNIT.Size = New System.Drawing.Size(28, 13)
        Me.lblNIT.TabIndex = 175
        Me.lblNIT.Text = "NIT:"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.BackColor = System.Drawing.Color.White
        Me.txtNombreProveedor.Enabled = False
        Me.txtNombreProveedor.Location = New System.Drawing.Point(116, 61)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(362, 20)
        Me.txtNombreProveedor.TabIndex = 173
        '
        'txtCodProveedor
        '
        Me.txtCodProveedor.BackColor = System.Drawing.Color.White
        Me.txtCodProveedor.Location = New System.Drawing.Point(68, 61)
        Me.txtCodProveedor.Name = "txtCodProveedor"
        Me.txtCodProveedor.ReadOnly = True
        Me.txtCodProveedor.Size = New System.Drawing.Size(42, 20)
        Me.txtCodProveedor.TabIndex = 172
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(3, 61)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(59, 13)
        Me.lblProveedor.TabIndex = 171
        Me.lblProveedor.Text = "Proveedor:"
        '
        'txtNoComprobante
        '
        Me.txtNoComprobante.BackColor = System.Drawing.Color.White
        Me.txtNoComprobante.Location = New System.Drawing.Point(272, 6)
        Me.txtNoComprobante.Name = "txtNoComprobante"
        Me.txtNoComprobante.Size = New System.Drawing.Size(102, 20)
        Me.txtNoComprobante.TabIndex = 170
        '
        'lblNoComprobante
        '
        Me.lblNoComprobante.AutoSize = True
        Me.lblNoComprobante.Location = New System.Drawing.Point(161, 9)
        Me.lblNoComprobante.Name = "lblNoComprobante"
        Me.lblNoComprobante.Size = New System.Drawing.Size(105, 13)
        Me.lblNoComprobante.TabIndex = 169
        Me.lblNoComprobante.Text = "No. de Comprobante"
        '
        'gbComprasExentas
        '
        Me.gbComprasExentas.BackColor = System.Drawing.Color.White
        Me.gbComprasExentas.Controls.Add(Me.txtExInternacionales)
        Me.gbComprasExentas.Controls.Add(Me.Label1)
        Me.gbComprasExentas.Controls.Add(Me.txtExImportaciones)
        Me.gbComprasExentas.Controls.Add(Me.lblExImportaciones)
        Me.gbComprasExentas.Controls.Add(Me.txtExLocales)
        Me.gbComprasExentas.Controls.Add(Me.lblExLocales)
        Me.gbComprasExentas.Location = New System.Drawing.Point(23, 218)
        Me.gbComprasExentas.Name = "gbComprasExentas"
        Me.gbComprasExentas.Size = New System.Drawing.Size(489, 48)
        Me.gbComprasExentas.TabIndex = 170
        Me.gbComprasExentas.TabStop = False
        Me.gbComprasExentas.Text = "Compras Exentas"
        '
        'txtExInternacionales
        '
        Me.txtExInternacionales.BackColor = System.Drawing.Color.White
        Me.txtExInternacionales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExInternacionales.CustomFormat = "###,###,##0.00"
        Me.txtExInternacionales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtExInternacionales.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtExInternacionales.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtExInternacionales.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtExInternacionales.Location = New System.Drawing.Point(398, 19)
        Me.txtExInternacionales.Name = "txtExInternacionales"
        Me.txtExInternacionales.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtExInternacionales.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtExInternacionales.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtExInternacionales.Size = New System.Drawing.Size(80, 19)
        Me.txtExInternacionales.TabIndex = 5
        Me.txtExInternacionales.Tag = Nothing
        Me.txtExInternacionales.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExInternacionales.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Internacionales"
        '
        'txtExImportaciones
        '
        Me.txtExImportaciones.BackColor = System.Drawing.Color.White
        Me.txtExImportaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExImportaciones.CustomFormat = "###,###,##0.00"
        Me.txtExImportaciones.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtExImportaciones.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtExImportaciones.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtExImportaciones.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtExImportaciones.Location = New System.Drawing.Point(227, 19)
        Me.txtExImportaciones.Name = "txtExImportaciones"
        Me.txtExImportaciones.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtExImportaciones.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtExImportaciones.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtExImportaciones.Size = New System.Drawing.Size(80, 19)
        Me.txtExImportaciones.TabIndex = 3
        Me.txtExImportaciones.Tag = Nothing
        Me.txtExImportaciones.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExImportaciones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblExImportaciones
        '
        Me.lblExImportaciones.AutoSize = True
        Me.lblExImportaciones.Location = New System.Drawing.Point(145, 19)
        Me.lblExImportaciones.Name = "lblExImportaciones"
        Me.lblExImportaciones.Size = New System.Drawing.Size(76, 13)
        Me.lblExImportaciones.TabIndex = 2
        Me.lblExImportaciones.Text = "Importaciones:"
        '
        'txtExLocales
        '
        Me.txtExLocales.BackColor = System.Drawing.Color.White
        Me.txtExLocales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExLocales.CustomFormat = "###,###,##0.00"
        Me.txtExLocales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtExLocales.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtExLocales.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtExLocales.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtExLocales.Location = New System.Drawing.Point(59, 19)
        Me.txtExLocales.Name = "txtExLocales"
        Me.txtExLocales.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtExLocales.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtExLocales.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtExLocales.Size = New System.Drawing.Size(80, 19)
        Me.txtExLocales.TabIndex = 1
        Me.txtExLocales.Tag = Nothing
        Me.txtExLocales.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExLocales.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblExLocales
        '
        Me.lblExLocales.AutoSize = True
        Me.lblExLocales.Location = New System.Drawing.Point(6, 19)
        Me.lblExLocales.Name = "lblExLocales"
        Me.lblExLocales.Size = New System.Drawing.Size(47, 13)
        Me.lblExLocales.TabIndex = 0
        Me.lblExLocales.Text = "Locales:"
        '
        'gbGravadas
        '
        Me.gbGravadas.BackColor = System.Drawing.Color.White
        Me.gbGravadas.Controls.Add(Me.txtGravadasInternacionales)
        Me.gbGravadas.Controls.Add(Me.lblGraInternacionales)
        Me.gbGravadas.Controls.Add(Me.txtGraImportaciones)
        Me.gbGravadas.Controls.Add(Me.lblGraImportaciones)
        Me.gbGravadas.Controls.Add(Me.txtGraLocales)
        Me.gbGravadas.Controls.Add(Me.lblGraLocales)
        Me.gbGravadas.Location = New System.Drawing.Point(23, 265)
        Me.gbGravadas.Name = "gbGravadas"
        Me.gbGravadas.Size = New System.Drawing.Size(489, 63)
        Me.gbGravadas.TabIndex = 171
        Me.gbGravadas.TabStop = False
        Me.gbGravadas.Text = "Compras Gravadas"
        '
        'txtGravadasInternacionales
        '
        Me.txtGravadasInternacionales.BackColor = System.Drawing.Color.White
        Me.txtGravadasInternacionales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGravadasInternacionales.CustomFormat = "###,###,##0.00"
        Me.txtGravadasInternacionales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtGravadasInternacionales.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtGravadasInternacionales.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtGravadasInternacionales.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtGravadasInternacionales.Location = New System.Drawing.Point(398, 19)
        Me.txtGravadasInternacionales.Name = "txtGravadasInternacionales"
        Me.txtGravadasInternacionales.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtGravadasInternacionales.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtGravadasInternacionales.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtGravadasInternacionales.Size = New System.Drawing.Size(80, 19)
        Me.txtGravadasInternacionales.TabIndex = 5
        Me.txtGravadasInternacionales.Tag = Nothing
        Me.txtGravadasInternacionales.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGravadasInternacionales.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblGraInternacionales
        '
        Me.lblGraInternacionales.AutoSize = True
        Me.lblGraInternacionales.Location = New System.Drawing.Point(313, 19)
        Me.lblGraInternacionales.Name = "lblGraInternacionales"
        Me.lblGraInternacionales.Size = New System.Drawing.Size(79, 13)
        Me.lblGraInternacionales.TabIndex = 4
        Me.lblGraInternacionales.Text = "Internacionales"
        '
        'txtGraImportaciones
        '
        Me.txtGraImportaciones.BackColor = System.Drawing.Color.White
        Me.txtGraImportaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGraImportaciones.CustomFormat = "###,###,##0.00"
        Me.txtGraImportaciones.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtGraImportaciones.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtGraImportaciones.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtGraImportaciones.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtGraImportaciones.Location = New System.Drawing.Point(227, 19)
        Me.txtGraImportaciones.Name = "txtGraImportaciones"
        Me.txtGraImportaciones.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtGraImportaciones.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtGraImportaciones.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtGraImportaciones.Size = New System.Drawing.Size(80, 19)
        Me.txtGraImportaciones.TabIndex = 3
        Me.txtGraImportaciones.Tag = Nothing
        Me.txtGraImportaciones.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGraImportaciones.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblGraImportaciones
        '
        Me.lblGraImportaciones.AutoSize = True
        Me.lblGraImportaciones.Location = New System.Drawing.Point(145, 19)
        Me.lblGraImportaciones.Name = "lblGraImportaciones"
        Me.lblGraImportaciones.Size = New System.Drawing.Size(76, 13)
        Me.lblGraImportaciones.TabIndex = 2
        Me.lblGraImportaciones.Text = "Importaciones:"
        '
        'txtGraLocales
        '
        Me.txtGraLocales.BackColor = System.Drawing.Color.White
        Me.txtGraLocales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGraLocales.CustomFormat = "###,###,##0.00"
        Me.txtGraLocales.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtGraLocales.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtGraLocales.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtGraLocales.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtGraLocales.Location = New System.Drawing.Point(59, 19)
        Me.txtGraLocales.Name = "txtGraLocales"
        Me.txtGraLocales.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtGraLocales.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtGraLocales.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtGraLocales.Size = New System.Drawing.Size(80, 19)
        Me.txtGraLocales.TabIndex = 1
        Me.txtGraLocales.Tag = Nothing
        Me.txtGraLocales.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGraLocales.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblGraLocales
        '
        Me.lblGraLocales.AutoSize = True
        Me.lblGraLocales.Location = New System.Drawing.Point(6, 19)
        Me.lblGraLocales.Name = "lblGraLocales"
        Me.lblGraLocales.Size = New System.Drawing.Size(47, 13)
        Me.lblGraLocales.TabIndex = 0
        Me.lblGraLocales.Text = "Locales:"
        '
        'lblCreditoFiscal
        '
        Me.lblCreditoFiscal.AutoSize = True
        Me.lblCreditoFiscal.Location = New System.Drawing.Point(6, 12)
        Me.lblCreditoFiscal.Name = "lblCreditoFiscal"
        Me.lblCreditoFiscal.Size = New System.Drawing.Size(43, 26)
        Me.lblCreditoFiscal.TabIndex = 172
        Me.lblCreditoFiscal.Text = "Crédito " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fiscal:"
        '
        'txtCreditoFiscal
        '
        Me.txtCreditoFiscal.BackColor = System.Drawing.Color.White
        Me.txtCreditoFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCreditoFiscal.CustomFormat = "###,###,##0.00"
        Me.txtCreditoFiscal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtCreditoFiscal.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCreditoFiscal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtCreditoFiscal.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtCreditoFiscal.Location = New System.Drawing.Point(59, 12)
        Me.txtCreditoFiscal.Name = "txtCreditoFiscal"
        Me.txtCreditoFiscal.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtCreditoFiscal.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtCreditoFiscal.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtCreditoFiscal.Size = New System.Drawing.Size(80, 19)
        Me.txtCreditoFiscal.TabIndex = 173
        Me.txtCreditoFiscal.Tag = Nothing
        Me.txtCreditoFiscal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCreditoFiscal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtRetTerceros
        '
        Me.txtRetTerceros.BackColor = System.Drawing.Color.White
        Me.txtRetTerceros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRetTerceros.CustomFormat = "###,###,##0.00"
        Me.txtRetTerceros.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtRetTerceros.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtRetTerceros.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtRetTerceros.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtRetTerceros.Location = New System.Drawing.Point(227, 12)
        Me.txtRetTerceros.Name = "txtRetTerceros"
        Me.txtRetTerceros.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtRetTerceros.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtRetTerceros.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtRetTerceros.Size = New System.Drawing.Size(80, 19)
        Me.txtRetTerceros.TabIndex = 175
        Me.txtRetTerceros.Tag = Nothing
        Me.txtRetTerceros.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRetTerceros.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblRetTerceros
        '
        Me.lblRetTerceros.AutoSize = True
        Me.lblRetTerceros.Location = New System.Drawing.Point(145, 12)
        Me.lblRetTerceros.Name = "lblRetTerceros"
        Me.lblRetTerceros.Size = New System.Drawing.Size(68, 26)
        Me.lblRetTerceros.TabIndex = 174
        Me.lblRetTerceros.Text = "Retención a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Terceros:"
        '
        'txtExImpuesto
        '
        Me.txtExImpuesto.BackColor = System.Drawing.Color.White
        Me.txtExImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExImpuesto.CustomFormat = "###,###,##0.00"
        Me.txtExImpuesto.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtExImpuesto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtExImpuesto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtExImpuesto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtExImpuesto.Location = New System.Drawing.Point(412, 12)
        Me.txtExImpuesto.Name = "txtExImpuesto"
        Me.txtExImpuesto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtExImpuesto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtExImpuesto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtExImpuesto.Size = New System.Drawing.Size(66, 19)
        Me.txtExImpuesto.TabIndex = 177
        Me.txtExImpuesto.Tag = Nothing
        Me.txtExImpuesto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtExImpuesto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblSujetosExcluidos
        '
        Me.lblSujetosExcluidos.AutoSize = True
        Me.lblSujetosExcluidos.Location = New System.Drawing.Point(313, 9)
        Me.lblSujetosExcluidos.Name = "lblSujetosExcluidos"
        Me.lblSujetosExcluidos.Size = New System.Drawing.Size(93, 26)
        Me.lblSujetosExcluidos.TabIndex = 176
        Me.lblSujetosExcluidos.Text = "Sujetos Excluidos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del Impuesto"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Culture = 17418
        Me.txtTotal.CustomFormat = "#0.00"
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Teal
        Me.txtTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtTotal.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txtTotal.Location = New System.Drawing.Point(383, 39)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtTotal.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtTotal.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(95, 19)
        Me.txtTotal.TabIndex = 179
        Me.txtTotal.Tag = Nothing
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(334, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 21)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Total:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtObservacion)
        Me.Panel3.Controls.Add(Me.lblObservación)
        Me.Panel3.Controls.Add(Me.txtTotal)
        Me.Panel3.Controls.Add(Me.txtExImpuesto)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblSujetosExcluidos)
        Me.Panel3.Controls.Add(Me.txtRetTerceros)
        Me.Panel3.Controls.Add(Me.lblCreditoFiscal)
        Me.Panel3.Controls.Add(Me.lblRetTerceros)
        Me.Panel3.Controls.Add(Me.txtCreditoFiscal)
        Me.Panel3.Location = New System.Drawing.Point(23, 332)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(489, 149)
        Me.Panel3.TabIndex = 180
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.White
        Me.txtObservacion.Location = New System.Drawing.Point(79, 66)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(399, 73)
        Me.txtObservacion.TabIndex = 181
        '
        'lblObservación
        '
        Me.lblObservación.AutoSize = True
        Me.lblObservación.Location = New System.Drawing.Point(6, 64)
        Me.lblObservación.Name = "lblObservación"
        Me.lblObservación.Size = New System.Drawing.Size(70, 13)
        Me.lblObservación.TabIndex = 180
        Me.lblObservación.Text = "Observación:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(442, 489)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(70, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 181
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'btnCheques
        '
        Me.btnCheques.Location = New System.Drawing.Point(359, 489)
        Me.btnCheques.Name = "btnCheques"
        Me.btnCheques.Size = New System.Drawing.Size(70, 28)
        Me.btnCheques.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCheques.TabIndex = 182
        Me.btnCheques.Text = "Cheques"
        Me.btnCheques.UseSelectable = True
        Me.btnCheques.UseStyleColors = True
        '
        'frmMsCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(534, 525)
        Me.Controls.Add(Me.btnCheques)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.gbGravadas)
        Me.Controls.Add(Me.gbComprasExentas)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(534, 525)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(534, 467)
        Me.Name = "frmMsCompras"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Ingreso de Compra"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtBloque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbComprasExentas.ResumeLayout(False)
        Me.gbComprasExentas.PerformLayout()
        CType(Me.txtExInternacionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExImportaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExLocales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGravadas.ResumeLayout(False)
        Me.gbGravadas.PerformLayout()
        CType(Me.txtGravadasInternacionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGraImportaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGraLocales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreditoFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRetTerceros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExImpuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents txtNoComprobante As System.Windows.Forms.TextBox
    Friend WithEvents lblNoComprobante As System.Windows.Forms.Label
    Friend WithEvents gbComprasExentas As System.Windows.Forms.GroupBox
    Friend WithEvents lblExLocales As System.Windows.Forms.Label
    Friend WithEvents txtExInternacionales As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExImportaciones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblExImportaciones As System.Windows.Forms.Label
    Friend WithEvents txtExLocales As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents gbGravadas As System.Windows.Forms.GroupBox
    Friend WithEvents txtGravadasInternacionales As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblGraInternacionales As System.Windows.Forms.Label
    Friend WithEvents txtGraImportaciones As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblGraImportaciones As System.Windows.Forms.Label
    Friend WithEvents txtGraLocales As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblGraLocales As System.Windows.Forms.Label
    Friend WithEvents lblCreditoFiscal As System.Windows.Forms.Label
    Friend WithEvents txtCreditoFiscal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtRetTerceros As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblRetTerceros As System.Windows.Forms.Label
    Friend WithEvents txtExImpuesto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblSujetosExcluidos As System.Windows.Forms.Label
    Friend WithEvents txtTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents lblObservación As System.Windows.Forms.Label
    Friend WithEvents lblNRC As System.Windows.Forms.Label
    Friend WithEvents txtNit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblNIT As System.Windows.Forms.Label
    Friend WithEvents txtNRC As System.Windows.Forms.TextBox
    Friend WithEvents txtBloque As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCheques As MetroFramework.Controls.MetroButton
    Friend WithEvents txtTipoCont As TextBox
    Friend WithEvents txtTipoDocumento As TextBox
    Friend WithEvents Label4 As Label
End Class
