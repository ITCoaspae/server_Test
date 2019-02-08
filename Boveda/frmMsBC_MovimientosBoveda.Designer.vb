<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsBC_MovimientosBoveda
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
        Me.components = New System.ComponentModel.Container()
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
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lblNoRefencia = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.cbTipoTransaccion = New System.Windows.Forms.ComboBox()
        Me.lblTipoTransaccion = New System.Windows.Forms.Label()
        Me.cbBoveda = New System.Windows.Forms.ComboBox()
        Me.lblBoveda = New System.Windows.Forms.Label()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        CType(Me.C1nMonedaUno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCincuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nVeinte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nFraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nDiez, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCinco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nUno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1nMonedaUno
        '
        Me.C1nMonedaUno.BackColor = System.Drawing.Color.White
        Me.C1nMonedaUno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1nMonedaUno.CustomFormat = "###,###,##0.00"
        Me.C1nMonedaUno.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1nMonedaUno.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1nMonedaUno.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1nMonedaUno.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1nMonedaUno.Location = New System.Drawing.Point(261, 340)
        Me.C1nMonedaUno.Margin = New System.Windows.Forms.Padding(4)
        Me.C1nMonedaUno.Name = "C1nMonedaUno"
        Me.C1nMonedaUno.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1nMonedaUno.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1nMonedaUno.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1nMonedaUno.Size = New System.Drawing.Size(225, 23)
        Me.C1nMonedaUno.TabIndex = 18
        Me.C1nMonedaUno.Tag = Nothing
        Me.C1nMonedaUno.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1nMonedaUno.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(264, 316)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Monedas de $1.00"
        '
        'c1nTotal
        '
        Me.c1nTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.c1nTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotal.CustomFormat = "###,###,##0.00"
        Me.c1nTotal.Enabled = False
        Me.c1nTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTotal.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nTotal.Location = New System.Drawing.Point(493, 440)
        Me.c1nTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.c1nTotal.Name = "c1nTotal"
        Me.c1nTotal.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTotal.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTotal.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTotal.ReadOnly = True
        Me.c1nTotal.Size = New System.Drawing.Size(225, 23)
        Me.c1nTotal.TabIndex = 32
        Me.c1nTotal.Tag = Nothing
        Me.c1nTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nCien
        '
        Me.c1nCien.BackColor = System.Drawing.Color.White
        Me.c1nCien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCien.CustomFormat = "###,###,##0.00"
        Me.c1nCien.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nCien.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCien.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCien.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCien.Location = New System.Drawing.Point(31, 440)
        Me.c1nCien.Margin = New System.Windows.Forms.Padding(4)
        Me.c1nCien.Name = "c1nCien"
        Me.c1nCien.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCien.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCien.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCien.Size = New System.Drawing.Size(225, 23)
        Me.c1nCien.TabIndex = 28
        Me.c1nCien.Tag = Nothing
        Me.c1nCien.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCien.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nCincuenta
        '
        Me.c1nCincuenta.BackColor = System.Drawing.Color.White
        Me.c1nCincuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCincuenta.CustomFormat = "###,###,##0.00"
        Me.c1nCincuenta.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nCincuenta.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCincuenta.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCincuenta.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCincuenta.Location = New System.Drawing.Point(493, 390)
        Me.c1nCincuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.c1nCincuenta.Name = "c1nCincuenta"
        Me.c1nCincuenta.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCincuenta.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCincuenta.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCincuenta.Size = New System.Drawing.Size(225, 23)
        Me.c1nCincuenta.TabIndex = 26
        Me.c1nCincuenta.Tag = Nothing
        Me.c1nCincuenta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCincuenta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nVeinte
        '
        Me.c1nVeinte.BackColor = System.Drawing.Color.White
        Me.c1nVeinte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nVeinte.CustomFormat = "###,###,##0.00"
        Me.c1nVeinte.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nVeinte.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nVeinte.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nVeinte.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nVeinte.Location = New System.Drawing.Point(261, 390)
        Me.c1nVeinte.Margin = New System.Windows.Forms.Padding(4)
        Me.c1nVeinte.Name = "c1nVeinte"
        Me.c1nVeinte.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nVeinte.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nVeinte.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nVeinte.Size = New System.Drawing.Size(225, 23)
        Me.c1nVeinte.TabIndex = 24
        Me.c1nVeinte.Tag = Nothing
        Me.c1nVeinte.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nVeinte.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nFraccion
        '
        Me.c1nFraccion.BackColor = System.Drawing.Color.White
        Me.c1nFraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nFraccion.CustomFormat = "###,###,##0.00"
        Me.c1nFraccion.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nFraccion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nFraccion.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nFraccion.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nFraccion.Location = New System.Drawing.Point(261, 440)
        Me.c1nFraccion.Margin = New System.Windows.Forms.Padding(4)
        Me.c1nFraccion.Name = "c1nFraccion"
        Me.c1nFraccion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nFraccion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nFraccion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nFraccion.Size = New System.Drawing.Size(225, 23)
        Me.c1nFraccion.TabIndex = 30
        Me.c1nFraccion.Tag = Nothing
        Me.c1nFraccion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nFraccion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nDiez
        '
        Me.c1nDiez.BackColor = System.Drawing.Color.White
        Me.c1nDiez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nDiez.CustomFormat = "###,###,##0.00"
        Me.c1nDiez.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nDiez.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nDiez.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nDiez.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nDiez.Location = New System.Drawing.Point(31, 390)
        Me.c1nDiez.Margin = New System.Windows.Forms.Padding(4)
        Me.c1nDiez.Name = "c1nDiez"
        Me.c1nDiez.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nDiez.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nDiez.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nDiez.Size = New System.Drawing.Size(222, 23)
        Me.c1nDiez.TabIndex = 22
        Me.c1nDiez.Tag = Nothing
        Me.c1nDiez.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nDiez.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nCinco
        '
        Me.c1nCinco.BackColor = System.Drawing.Color.White
        Me.c1nCinco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCinco.CustomFormat = "###,###,##0.00"
        Me.c1nCinco.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nCinco.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCinco.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nCinco.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nCinco.Location = New System.Drawing.Point(494, 339)
        Me.c1nCinco.Margin = New System.Windows.Forms.Padding(4)
        Me.c1nCinco.Name = "c1nCinco"
        Me.c1nCinco.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCinco.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCinco.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nCinco.Size = New System.Drawing.Size(225, 23)
        Me.c1nCinco.TabIndex = 20
        Me.c1nCinco.Tag = Nothing
        Me.c1nCinco.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nCinco.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nUno
        '
        Me.c1nUno.BackColor = System.Drawing.Color.White
        Me.c1nUno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nUno.CustomFormat = "###,###,##0.00"
        Me.c1nUno.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nUno.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nUno.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nUno.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nUno.Location = New System.Drawing.Point(31, 340)
        Me.c1nUno.Margin = New System.Windows.Forms.Padding(4)
        Me.c1nUno.Name = "c1nUno"
        Me.c1nUno.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nUno.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nUno.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nUno.Size = New System.Drawing.Size(222, 23)
        Me.c1nUno.TabIndex = 16
        Me.c1nUno.Tag = Nothing
        Me.c1nUno.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nUno.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(489, 417)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 20)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Total Detalle:"
        '
        'Label10
        '
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(264, 417)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(228, 19)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Moneda Fraccionaria:"
        '
        'Label9
        '
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(31, 417)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 19)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Billetes de $100.00"
        '
        'Label8
        '
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(494, 367)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(228, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Billetes de $50.00"
        '
        'Label7
        '
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(264, 367)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Billetes de $20.00"
        '
        'Label6
        '
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(31, 367)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 19)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Billetes de $10.00"
        '
        'Label5
        '
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(490, 316)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Billetes de $5.00"
        '
        'Label12
        '
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(28, 316)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Billetes de $1.00"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(31, 241)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(687, 46)
        Me.txtObservacion.TabIndex = 13
        '
        'lblObservacion
        '
        Me.lblObservacion.AutoSize = True
        Me.lblObservacion.Location = New System.Drawing.Point(32, 220)
        Me.lblObservacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(92, 17)
        Me.lblObservacion.TabIndex = 12
        Me.lblObservacion.Text = "Observación:"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(264, 194)
        Me.txtReferencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(225, 22)
        Me.txtReferencia.TabIndex = 9
        '
        'lblNoRefencia
        '
        Me.lblNoRefencia.AutoSize = True
        Me.lblNoRefencia.Location = New System.Drawing.Point(264, 172)
        Me.lblNoRefencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoRefencia.Name = "lblNoRefencia"
        Me.lblNoRefencia.Size = New System.Drawing.Size(107, 17)
        Me.lblNoRefencia.TabIndex = 8
        Me.lblNoRefencia.Text = "No. Referencia:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(497, 191)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(225, 22)
        Me.dtpFecha.TabIndex = 11
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(494, 173)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(51, 17)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "Fecha:"
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(31, 193)
        Me.C1NEMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.Size = New System.Drawing.Size(225, 23)
        Me.C1NEMonto.TabIndex = 7
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(32, 172)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(51, 17)
        Me.lblMonto.TabIndex = 6
        Me.lblMonto.Text = "Monto:"
        '
        'cbTipoTransaccion
        '
        Me.cbTipoTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoTransaccion.FormattingEnabled = True
        Me.cbTipoTransaccion.Location = New System.Drawing.Point(31, 144)
        Me.cbTipoTransaccion.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTipoTransaccion.Name = "cbTipoTransaccion"
        Me.cbTipoTransaccion.Size = New System.Drawing.Size(691, 24)
        Me.cbTipoTransaccion.TabIndex = 5
        '
        'lblTipoTransaccion
        '
        Me.lblTipoTransaccion.AutoSize = True
        Me.lblTipoTransaccion.Location = New System.Drawing.Point(32, 123)
        Me.lblTipoTransaccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoTransaccion.Name = "lblTipoTransaccion"
        Me.lblTipoTransaccion.Size = New System.Drawing.Size(142, 17)
        Me.lblTipoTransaccion.TabIndex = 4
        Me.lblTipoTransaccion.Text = "Tipo de Transacción:"
        '
        'cbBoveda
        '
        Me.cbBoveda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBoveda.FormattingEnabled = True
        Me.cbBoveda.Location = New System.Drawing.Point(379, 95)
        Me.cbBoveda.Margin = New System.Windows.Forms.Padding(4)
        Me.cbBoveda.Name = "cbBoveda"
        Me.cbBoveda.Size = New System.Drawing.Size(339, 24)
        Me.cbBoveda.TabIndex = 3
        '
        'lblBoveda
        '
        Me.lblBoveda.AutoSize = True
        Me.lblBoveda.Location = New System.Drawing.Point(380, 74)
        Me.lblBoveda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBoveda.Name = "lblBoveda"
        Me.lblBoveda.Size = New System.Drawing.Size(60, 17)
        Me.lblBoveda.TabIndex = 2
        Me.lblBoveda.Text = "Boveda:"
        '
        'cbSucursal
        '
        Me.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(31, 95)
        Me.cbSucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(340, 24)
        Me.cbSucursal.TabIndex = 1
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(31, 74)
        Me.lblSucursal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(67, 17)
        Me.lblSucursal.TabIndex = 0
        Me.lblSucursal.Text = "Sucursal:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(618, 471)
        Me.btnGuardar1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 33
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(27, 291)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(71, 25)
        Me.MetroLabel1.TabIndex = 14
        Me.MetroLabel1.Text = "Detalle"
        '
        'frmMsBC_MovimientosBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(751, 566)
        Me.Controls.Add(Me.c1nTotal)
        Me.Controls.Add(Me.C1nMonedaUno)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.c1nFraccion)
        Me.Controls.Add(Me.c1nCien)
        Me.Controls.Add(Me.c1nDiez)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.c1nCincuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.c1nCinco)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblObservacion)
        Me.Controls.Add(Me.c1nVeinte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.cbSucursal)
        Me.Controls.Add(Me.lblNoRefencia)
        Me.Controls.Add(Me.c1nUno)
        Me.Controls.Add(Me.lblBoveda)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cbBoveda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblTipoTransaccion)
        Me.Controls.Add(Me.C1NEMonto)
        Me.Controls.Add(Me.cbTipoTransaccion)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.Label12)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(751, 566)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(751, 566)
        Me.Name = "frmMsBC_MovimientosBoveda"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Movimientos Bóveda"
        CType(Me.C1nMonedaUno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCincuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nVeinte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nFraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nDiez, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCinco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nUno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbBoveda As System.Windows.Forms.ComboBox
    Friend WithEvents lblBoveda As System.Windows.Forms.Label
    Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents cbTipoTransaccion As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoTransaccion As System.Windows.Forms.Label
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents lblObservacion As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents lblNoRefencia As System.Windows.Forms.Label
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
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    'Friend WithEvents C1SuperTooltip1 As C1SuperTooltip
End Class
