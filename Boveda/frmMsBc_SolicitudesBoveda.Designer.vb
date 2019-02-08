<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsBc_SolicitudesBoveda
    Inherits MetroFramework.Forms.MetroForm

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
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDenegar = New MetroFramework.Controls.MetroButton()
        Me.btnAutorizar = New MetroFramework.Controls.MetroButton()
        Me.btnProcesar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.C1nMonedaUno = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c1nTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCien = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCincuenta = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nVeinte = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nFraccion = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nDiez = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCinco = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nUno = New C1.Win.C1Input.C1NumericEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblNomCajero = New System.Windows.Forms.Label()
        Me.txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1nMonedaUno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCincuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nVeinte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nFraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nDiez, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCinco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nUno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(12, 35)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(58, 35)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(97, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(164, 35)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(89, 13)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto Solicitado:"
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Location = New System.Drawing.Point(62, 11)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(39, 13)
        Me.lblCajero.TabIndex = 6
        Me.lblCajero.Text = "Label1"
        '
        'lblObservacion
        '
        Me.lblObservacion.AutoSize = True
        Me.lblObservacion.Location = New System.Drawing.Point(12, 117)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(70, 13)
        Me.lblObservacion.TabIndex = 7
        Me.lblObservacion.Text = "Observación:"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(11, 133)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(400, 54)
        Me.txtObservacion.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnDenegar)
        Me.Panel1.Controls.Add(Me.btnAutorizar)
        Me.Panel1.Controls.Add(Me.btnProcesar)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.lblNomCajero)
        Me.Panel1.Controls.Add(Me.txtMonto)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.lblMonto)
        Me.Panel1.Controls.Add(Me.txtObservacion)
        Me.Panel1.Controls.Add(Me.lblObservacion)
        Me.Panel1.Controls.Add(Me.lblCajero)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 403)
        Me.Panel1.TabIndex = 11
        '
        'btnDenegar
        '
        Me.btnDenegar.Location = New System.Drawing.Point(99, 362)
        Me.btnDenegar.Name = "btnDenegar"
        Me.btnDenegar.Size = New System.Drawing.Size(82, 28)
        Me.btnDenegar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDenegar.TabIndex = 185
        Me.btnDenegar.Text = "Denegar"
        Me.btnDenegar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDenegar.UseSelectable = True
        Me.btnDenegar.UseStyleColors = True
        '
        'btnAutorizar
        '
        Me.btnAutorizar.Location = New System.Drawing.Point(11, 362)
        Me.btnAutorizar.Name = "btnAutorizar"
        Me.btnAutorizar.Size = New System.Drawing.Size(82, 28)
        Me.btnAutorizar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAutorizar.TabIndex = 184
        Me.btnAutorizar.Text = "Autorizar"
        Me.btnAutorizar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAutorizar.UseSelectable = True
        Me.btnAutorizar.UseStyleColors = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(11, 61)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(144, 28)
        Me.btnProcesar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar.TabIndex = 183
        Me.btnProcesar.Text = "Procesar Solicitud"
        Me.btnProcesar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar.UseSelectable = True
        Me.btnProcesar.UseStyleColors = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.C1nMonedaUno)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.c1nTotal)
        Me.GroupBox2.Controls.Add(Me.c1nCien)
        Me.GroupBox2.Controls.Add(Me.c1nCincuenta)
        Me.GroupBox2.Controls.Add(Me.c1nVeinte)
        Me.GroupBox2.Controls.Add(Me.c1nFraccion)
        Me.GroupBox2.Controls.Add(Me.c1nDiez)
        Me.GroupBox2.Controls.Add(Me.c1nCinco)
        Me.GroupBox2.Controls.Add(Me.c1nUno)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 163)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de Monto en efectivo"
        '
        'C1nMonedaUno
        '
        Me.C1nMonedaUno.BackColor = System.Drawing.Color.White
        Me.C1nMonedaUno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1nMonedaUno.CustomFormat = "###,###,##0.00"
        Me.C1nMonedaUno.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1nMonedaUno.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1nMonedaUno.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1nMonedaUno.Location = New System.Drawing.Point(112, 106)
        Me.C1nMonedaUno.Name = "C1nMonedaUno"
        Me.C1nMonedaUno.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1nMonedaUno.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1nMonedaUno.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1nMonedaUno.ShowDropDownButton = False
        Me.C1nMonedaUno.ShowUpDownButtons = False
        Me.C1nMonedaUno.Size = New System.Drawing.Size(80, 21)
        Me.C1nMonedaUno.TabIndex = 10
        Me.C1nMonedaUno.Tag = Nothing
        Me.C1nMonedaUno.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Monedas de $1.00"
        '
        'c1nTotal
        '
        Me.c1nTotal.BackColor = System.Drawing.Color.White
        Me.c1nTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotal.CustomFormat = "###,###,##0.00"
        Me.c1nTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotal.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotal.Location = New System.Drawing.Point(312, 133)
        Me.c1nTotal.Name = "c1nTotal"
        Me.c1nTotal.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotal.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotal.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotal.ReadOnly = True
        Me.c1nTotal.ShowDropDownButton = False
        Me.c1nTotal.ShowUpDownButtons = False
        Me.c1nTotal.Size = New System.Drawing.Size(80, 21)
        Me.c1nTotal.TabIndex = 7
        Me.c1nTotal.Tag = Nothing
        Me.c1nTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nCien
        '
        Me.c1nCien.BackColor = System.Drawing.Color.White
        Me.c1nCien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCien.CustomFormat = "###,###,##0.00"
        Me.c1nCien.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nCien.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCien.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCien.Location = New System.Drawing.Point(312, 79)
        Me.c1nCien.Name = "c1nCien"
        Me.c1nCien.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCien.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCien.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCien.ShowDropDownButton = False
        Me.c1nCien.ShowUpDownButtons = False
        Me.c1nCien.Size = New System.Drawing.Size(80, 21)
        Me.c1nCien.TabIndex = 6
        Me.c1nCien.Tag = Nothing
        Me.c1nCien.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nCincuenta
        '
        Me.c1nCincuenta.BackColor = System.Drawing.Color.White
        Me.c1nCincuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCincuenta.CustomFormat = "###,###,##0.00"
        Me.c1nCincuenta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nCincuenta.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCincuenta.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCincuenta.Location = New System.Drawing.Point(310, 52)
        Me.c1nCincuenta.Name = "c1nCincuenta"
        Me.c1nCincuenta.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCincuenta.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCincuenta.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCincuenta.ShowDropDownButton = False
        Me.c1nCincuenta.ShowUpDownButtons = False
        Me.c1nCincuenta.Size = New System.Drawing.Size(80, 21)
        Me.c1nCincuenta.TabIndex = 5
        Me.c1nCincuenta.Tag = Nothing
        Me.c1nCincuenta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nVeinte
        '
        Me.c1nVeinte.BackColor = System.Drawing.Color.White
        Me.c1nVeinte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nVeinte.CustomFormat = "###,###,##0.00"
        Me.c1nVeinte.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nVeinte.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nVeinte.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nVeinte.Location = New System.Drawing.Point(310, 25)
        Me.c1nVeinte.Name = "c1nVeinte"
        Me.c1nVeinte.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nVeinte.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nVeinte.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nVeinte.ShowDropDownButton = False
        Me.c1nVeinte.ShowUpDownButtons = False
        Me.c1nVeinte.Size = New System.Drawing.Size(80, 21)
        Me.c1nVeinte.TabIndex = 4
        Me.c1nVeinte.Tag = Nothing
        Me.c1nVeinte.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nFraccion
        '
        Me.c1nFraccion.BackColor = System.Drawing.Color.White
        Me.c1nFraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nFraccion.CustomFormat = "###,###,##0.00"
        Me.c1nFraccion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nFraccion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nFraccion.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nFraccion.Location = New System.Drawing.Point(312, 106)
        Me.c1nFraccion.Name = "c1nFraccion"
        Me.c1nFraccion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nFraccion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nFraccion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nFraccion.ShowDropDownButton = False
        Me.c1nFraccion.ShowUpDownButtons = False
        Me.c1nFraccion.Size = New System.Drawing.Size(80, 21)
        Me.c1nFraccion.TabIndex = 3
        Me.c1nFraccion.Tag = Nothing
        Me.c1nFraccion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nDiez
        '
        Me.c1nDiez.BackColor = System.Drawing.Color.White
        Me.c1nDiez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nDiez.CustomFormat = "###,###,##0.00"
        Me.c1nDiez.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nDiez.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nDiez.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nDiez.Location = New System.Drawing.Point(112, 79)
        Me.c1nDiez.Name = "c1nDiez"
        Me.c1nDiez.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nDiez.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nDiez.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nDiez.ShowDropDownButton = False
        Me.c1nDiez.ShowUpDownButtons = False
        Me.c1nDiez.Size = New System.Drawing.Size(80, 21)
        Me.c1nDiez.TabIndex = 2
        Me.c1nDiez.Tag = Nothing
        Me.c1nDiez.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nCinco
        '
        Me.c1nCinco.BackColor = System.Drawing.Color.White
        Me.c1nCinco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCinco.CustomFormat = "###,###,##0.00"
        Me.c1nCinco.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nCinco.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCinco.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCinco.Location = New System.Drawing.Point(112, 52)
        Me.c1nCinco.Name = "c1nCinco"
        Me.c1nCinco.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCinco.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCinco.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCinco.ShowDropDownButton = False
        Me.c1nCinco.ShowUpDownButtons = False
        Me.c1nCinco.Size = New System.Drawing.Size(80, 21)
        Me.c1nCinco.TabIndex = 1
        Me.c1nCinco.Tag = Nothing
        Me.c1nCinco.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nUno
        '
        Me.c1nUno.BackColor = System.Drawing.Color.White
        Me.c1nUno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nUno.CustomFormat = "###,###,##0.00"
        Me.c1nUno.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nUno.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nUno.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nUno.Location = New System.Drawing.Point(112, 25)
        Me.c1nUno.Name = "c1nUno"
        Me.c1nUno.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nUno.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nUno.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nUno.ShowDropDownButton = False
        Me.c1nUno.ShowUpDownButtons = False
        Me.c1nUno.Size = New System.Drawing.Size(80, 21)
        Me.c1nUno.TabIndex = 0
        Me.c1nUno.Tag = Nothing
        Me.c1nUno.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(195, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Total Detalle:"
        '
        'Label10
        '
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(206, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 27)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Moneda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fraccionaria:"
        '
        'Label9
        '
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(206, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Billetes de $100.00"
        '
        'Label8
        '
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(204, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Billetes de $50.00"
        '
        'Label7
        '
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(204, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Billetes de $20.00"
        '
        'Label6
        '
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(6, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Billetes de $10.00"
        '
        'Label5
        '
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(6, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Billetes de $5.00"
        '
        'Label12
        '
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(6, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Billetes de $1.00"
        '
        'lblNomCajero
        '
        Me.lblNomCajero.AutoSize = True
        Me.lblNomCajero.Location = New System.Drawing.Point(12, 11)
        Me.lblNomCajero.Name = "lblNomCajero"
        Me.lblNomCajero.Size = New System.Drawing.Size(40, 13)
        Me.lblNomCajero.TabIndex = 12
        Me.lblNomCajero.Text = "Cajero:"
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.CustomFormat = "###,###,##0.00"
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMonto.Location = New System.Drawing.Point(259, 34)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMonto.ShowDropDownButton = False
        Me.txtMonto.ShowUpDownButtons = False
        Me.txtMonto.Size = New System.Drawing.Size(102, 21)
        Me.txtMonto.TabIndex = 11
        Me.txtMonto.Tag = Nothing
        Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'frmMsBc_SolicitudesBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(471, 504)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(471, 504)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(471, 214)
        Me.Name = "frmMsBc_SolicitudesBoveda"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Solicitud de fondos bóveda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1nMonedaUno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCincuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nVeinte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nFraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nDiez, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCinco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nUno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblCajero As System.Windows.Forms.Label
    Friend WithEvents lblObservacion As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblNomCajero As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents C1nMonedaUno As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1nTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCien As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCincuenta As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nVeinte As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nFraccion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nDiez As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCinco As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nUno As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAutorizar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDenegar As MetroFramework.Controls.MetroButton
End Class
