<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsPrGastosTramitacion
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form

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
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblCtaContable = New System.Windows.Forms.Label()
        Me.txtIdCtaContable = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.chkMin = New System.Windows.Forms.CheckBox()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.txtMin = New C1.Win.C1Input.C1NumericEdit()
        Me.chkMax = New System.Windows.Forms.CheckBox()
        Me.txtMax = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 60)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(104, 60)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(387, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'lblCtaContable
        '
        Me.lblCtaContable.AutoSize = True
        Me.lblCtaContable.Location = New System.Drawing.Point(23, 89)
        Me.lblCtaContable.Name = "lblCtaContable"
        Me.lblCtaContable.Size = New System.Drawing.Size(74, 13)
        Me.lblCtaContable.TabIndex = 2
        Me.lblCtaContable.Text = "Cta. Contable:"
        '
        'txtIdCtaContable
        '
        Me.txtIdCtaContable.BackColor = System.Drawing.Color.White
        Me.txtIdCtaContable.Location = New System.Drawing.Point(104, 86)
        Me.txtIdCtaContable.Name = "txtIdCtaContable"
        Me.txtIdCtaContable.Size = New System.Drawing.Size(141, 20)
        Me.txtIdCtaContable.TabIndex = 3
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Location = New System.Drawing.Point(251, 86)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(240, 20)
        Me.txtCuenta.TabIndex = 4
        '
        'chkMin
        '
        Me.chkMin.AutoSize = True
        Me.chkMin.Location = New System.Drawing.Point(26, 112)
        Me.chkMin.Name = "chkMin"
        Me.chkMin.Size = New System.Drawing.Size(124, 17)
        Me.chkMin.TabIndex = 6
        Me.chkMin.Text = "Aplica monto mínimo"
        Me.chkMin.UseVisualStyleBackColor = True
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(248, 113)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(124, 13)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "Monto mínimo a deducir:"
        '
        'txtMin
        '
        Me.txtMin.BackColor = System.Drawing.Color.White
        Me.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMin.CustomFormat = "###,###,##0.00"
        Me.txtMin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMin.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMin.Location = New System.Drawing.Point(389, 112)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMin.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMin.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMin.ShowDropDownButton = False
        Me.txtMin.ShowUpDownButtons = False
        Me.txtMin.Size = New System.Drawing.Size(102, 21)
        Me.txtMin.TabIndex = 12
        Me.txtMin.Tag = Nothing
        Me.txtMin.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'chkMax
        '
        Me.chkMax.AutoSize = True
        Me.chkMax.Location = New System.Drawing.Point(26, 135)
        Me.chkMax.Name = "chkMax"
        Me.chkMax.Size = New System.Drawing.Size(125, 17)
        Me.chkMax.TabIndex = 13
        Me.chkMax.Text = "Aplica monto máximo"
        Me.chkMax.UseVisualStyleBackColor = True
        '
        'txtMax
        '
        Me.txtMax.BackColor = System.Drawing.Color.White
        Me.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMax.CustomFormat = "###,###,##0.00"
        Me.txtMax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMax.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMax.Location = New System.Drawing.Point(389, 139)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMax.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMax.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMax.ShowDropDownButton = False
        Me.txtMax.ShowUpDownButtons = False
        Me.txtMax.Size = New System.Drawing.Size(102, 21)
        Me.txtMax.TabIndex = 15
        Me.txtMax.Tag = Nothing
        Me.txtMax.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(248, 139)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(125, 13)
        Me.lblMax.TabIndex = 14
        Me.lblMax.Text = "Monto máximo a deducir:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(416, 166)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 160
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsPrGastosTramitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(514, 224)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.chkMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.chkMin)
        Me.Controls.Add(Me.lblCtaContable)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtIdCtaContable)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsPrGastosTramitacion"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Gastos Tramitación"
        CType(Me.txtMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblCtaContable As System.Windows.Forms.Label
    Friend WithEvents txtIdCtaContable As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents chkMin As System.Windows.Forms.CheckBox
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents txtMin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkMax As System.Windows.Forms.CheckBox
    Friend WithEvents txtMax As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
