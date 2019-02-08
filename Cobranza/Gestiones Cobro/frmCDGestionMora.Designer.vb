<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCDGestionMora
    Inherits System.Windows.Forms.Form

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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblEncabezado = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblPerdonado = New System.Windows.Forms.Label
        Me.txtPerdonado = New C1.Win.C1Input.C1TextBox
        Me.lblPagado = New System.Windows.Forms.Label
        Me.txtPagado = New C1.Win.C1Input.C1TextBox
        Me.dtpFechaGestion = New System.Windows.Forms.DateTimePicker
        Me.lblFecha = New System.Windows.Forms.Label
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox
        Me.lblPrestamo = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblCosto = New System.Windows.Forms.Label
        Me.txtCosto = New C1.Win.C1Input.C1TextBox
        Me.lblItemFact = New System.Windows.Forms.Label
        Me.txtDescItemFact = New System.Windows.Forms.TextBox
        Me.txtCodItem = New System.Windows.Forms.TextBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtPerdonado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPagado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblEncabezado)
        Me.Panel2.Location = New System.Drawing.Point(-5, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 33)
        Me.Panel2.TabIndex = 166
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.Color.White
        Me.lblEncabezado.Location = New System.Drawing.Point(3, 5)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(171, 24)
        Me.lblEncabezado.TabIndex = 0
        Me.lblEncabezado.Text = "Gestión por Mora"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblPerdonado)
        Me.Panel1.Controls.Add(Me.txtPerdonado)
        Me.Panel1.Controls.Add(Me.lblPagado)
        Me.Panel1.Controls.Add(Me.txtPagado)
        Me.Panel1.Controls.Add(Me.dtpFechaGestion)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.txtCodPrestamo)
        Me.Panel1.Controls.Add(Me.lblPrestamo)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.lblCosto)
        Me.Panel1.Controls.Add(Me.txtCosto)
        Me.Panel1.Controls.Add(Me.lblItemFact)
        Me.Panel1.Controls.Add(Me.txtDescItemFact)
        Me.Panel1.Controls.Add(Me.txtCodItem)
        Me.Panel1.Location = New System.Drawing.Point(11, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 165)
        Me.Panel1.TabIndex = 167
        '
        'lblPerdonado
        '
        Me.lblPerdonado.AutoSize = True
        Me.lblPerdonado.Location = New System.Drawing.Point(166, 132)
        Me.lblPerdonado.Name = "lblPerdonado"
        Me.lblPerdonado.Size = New System.Drawing.Size(62, 13)
        Me.lblPerdonado.TabIndex = 141
        Me.lblPerdonado.Text = "Perdonado:"
        '
        'txtPerdonado
        '
        Me.txtPerdonado.BackColor = System.Drawing.Color.Khaki
        Me.txtPerdonado.DataType = GetType(Decimal)
        Me.txtPerdonado.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtPerdonado.Location = New System.Drawing.Point(233, 128)
        Me.txtPerdonado.Name = "txtPerdonado"
        Me.txtPerdonado.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtPerdonado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtPerdonado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtPerdonado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtPerdonado.Size = New System.Drawing.Size(68, 20)
        Me.txtPerdonado.TabIndex = 142
        Me.txtPerdonado.Tag = Nothing
        Me.txtPerdonado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPagado
        '
        Me.lblPagado.AutoSize = True
        Me.lblPagado.Location = New System.Drawing.Point(7, 134)
        Me.lblPagado.Name = "lblPagado"
        Me.lblPagado.Size = New System.Drawing.Size(47, 13)
        Me.lblPagado.TabIndex = 139
        Me.lblPagado.Text = "Pagado:"
        '
        'txtPagado
        '
        Me.txtPagado.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPagado.DataType = GetType(Decimal)
        Me.txtPagado.Enabled = False
        Me.txtPagado.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtPagado.Location = New System.Drawing.Point(74, 130)
        Me.txtPagado.Name = "txtPagado"
        Me.txtPagado.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtPagado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtPagado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtPagado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtPagado.Size = New System.Drawing.Size(68, 20)
        Me.txtPagado.TabIndex = 140
        Me.txtPagado.Tag = Nothing
        Me.txtPagado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dtpFechaGestion
        '
        Me.dtpFechaGestion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaGestion.Location = New System.Drawing.Point(275, 10)
        Me.dtpFechaGestion.Name = "dtpFechaGestion"
        Me.dtpFechaGestion.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaGestion.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(219, 12)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 138
        Me.lblFecha.Text = "Fecha"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BackColor = System.Drawing.Color.Khaki
        Me.txtCodPrestamo.Location = New System.Drawing.Point(71, 10)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(126, 20)
        Me.txtCodPrestamo.TabIndex = 0
        '
        'lblPrestamo
        '
        Me.lblPrestamo.AutoSize = True
        Me.lblPrestamo.Location = New System.Drawing.Point(8, 13)
        Me.lblPrestamo.Name = "lblPrestamo"
        Me.lblPrestamo.Size = New System.Drawing.Size(54, 13)
        Me.lblPrestamo.TabIndex = 136
        Me.lblPrestamo.Text = "Prestamo:"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.Khaki
        Me.txtCantidad.Location = New System.Drawing.Point(203, 72)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(51, 20)
        Me.txtCantidad.TabIndex = 5
        Me.txtCantidad.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cantidad:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.Khaki
        Me.txtDescripcion.Location = New System.Drawing.Point(71, 43)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(318, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(4, 46)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Location = New System.Drawing.Point(4, 76)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(37, 13)
        Me.lblCosto.TabIndex = 2
        Me.lblCosto.Text = "Costo:"
        '
        'txtCosto
        '
        Me.txtCosto.BackColor = System.Drawing.Color.Khaki
        Me.txtCosto.DataType = GetType(Decimal)
        Me.txtCosto.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtCosto.Location = New System.Drawing.Point(71, 72)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtCosto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtCosto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtCosto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtCosto.Size = New System.Drawing.Size(68, 20)
        Me.txtCosto.TabIndex = 3
        Me.txtCosto.Tag = Nothing
        Me.txtCosto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblItemFact
        '
        Me.lblItemFact.AutoSize = True
        Me.lblItemFact.Location = New System.Drawing.Point(4, 95)
        Me.lblItemFact.Name = "lblItemFact"
        Me.lblItemFact.Size = New System.Drawing.Size(60, 26)
        Me.lblItemFact.TabIndex = 8
        Me.lblItemFact.Text = "Item " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Facturable:"
        '
        'txtDescItemFact
        '
        Me.txtDescItemFact.BackColor = System.Drawing.Color.Khaki
        Me.txtDescItemFact.Location = New System.Drawing.Point(127, 98)
        Me.txtDescItemFact.Name = "txtDescItemFact"
        Me.txtDescItemFact.Size = New System.Drawing.Size(261, 20)
        Me.txtDescItemFact.TabIndex = 135
        '
        'txtCodItem
        '
        Me.txtCodItem.BackColor = System.Drawing.Color.Khaki
        Me.txtCodItem.Location = New System.Drawing.Point(71, 98)
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.Size = New System.Drawing.Size(50, 20)
        Me.txtCodItem.TabIndex = 5
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(333, 222)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(70, 28)
        Me.btnCerrar.TabIndex = 170
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(246, 222)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(81, 28)
        Me.btnGuardar.TabIndex = 169
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmCDGestionMora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(415, 269)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(415, 415)
        Me.Name = "frmCDGestionMora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCDGestionMora"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtPerdonado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPagado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblCosto As System.Windows.Forms.Label
    Friend WithEvents txtCosto As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblItemFact As System.Windows.Forms.Label
    Friend WithEvents txtDescItemFact As System.Windows.Forms.TextBox
    Friend WithEvents txtCodItem As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents lblPrestamo As System.Windows.Forms.Label
    Friend WithEvents dtpFechaGestion As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblPerdonado As System.Windows.Forms.Label
    Friend WithEvents txtPerdonado As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblPagado As System.Windows.Forms.Label
    Friend WithEvents txtPagado As C1.Win.C1Input.C1TextBox
End Class
