<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsDatosCheque
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.txtNoCheque = New System.Windows.Forms.TextBox()
        Me.txtIdBanco = New System.Windows.Forms.TextBox()
        Me.txtNoReserva = New System.Windows.Forms.TextBox()
        Me.txtNoCtaBancaria = New System.Windows.Forms.TextBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.lblNoCtaBancaria = New System.Windows.Forms.Label()
        Me.lblNoCheque = New System.Windows.Forms.Label()
        Me.lblNoReserva = New System.Windows.Forms.Label()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.Panel2.SuspendLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtMonto)
        Me.Panel2.Controls.Add(Me.lblMonto)
        Me.Panel2.Controls.Add(Me.txtBanco)
        Me.Panel2.Controls.Add(Me.txtNoCheque)
        Me.Panel2.Controls.Add(Me.txtIdBanco)
        Me.Panel2.Controls.Add(Me.txtNoReserva)
        Me.Panel2.Controls.Add(Me.txtNoCtaBancaria)
        Me.Panel2.Controls.Add(Me.lblBanco)
        Me.Panel2.Controls.Add(Me.lblNoCtaBancaria)
        Me.Panel2.Controls.Add(Me.lblNoCheque)
        Me.Panel2.Controls.Add(Me.lblNoReserva)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(293, 153)
        Me.Panel2.TabIndex = 158
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.CustomFormat = "###,###,##0.00"
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMonto.Location = New System.Drawing.Point(94, 123)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMonto.ShowDropDownButton = False
        Me.txtMonto.ShowUpDownButtons = False
        Me.txtMonto.Size = New System.Drawing.Size(187, 21)
        Me.txtMonto.TabIndex = 14
        Me.txtMonto.Tag = Nothing
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(3, 123)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(40, 13)
        Me.lblMonto.TabIndex = 5
        Me.lblMonto.Text = "Monto:"
        '
        'txtBanco
        '
        Me.txtBanco.BackColor = System.Drawing.Color.White
        Me.txtBanco.Location = New System.Drawing.Point(140, 11)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.ReadOnly = True
        Me.txtBanco.Size = New System.Drawing.Size(141, 20)
        Me.txtBanco.TabIndex = 1
        '
        'txtNoCheque
        '
        Me.txtNoCheque.BackColor = System.Drawing.Color.White
        Me.txtNoCheque.Location = New System.Drawing.Point(94, 97)
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(187, 20)
        Me.txtNoCheque.TabIndex = 4
        '
        'txtIdBanco
        '
        Me.txtIdBanco.BackColor = System.Drawing.Color.White
        Me.txtIdBanco.Location = New System.Drawing.Point(94, 11)
        Me.txtIdBanco.Name = "txtIdBanco"
        Me.txtIdBanco.Size = New System.Drawing.Size(40, 20)
        Me.txtIdBanco.TabIndex = 0
        '
        'txtNoReserva
        '
        Me.txtNoReserva.BackColor = System.Drawing.Color.White
        Me.txtNoReserva.Location = New System.Drawing.Point(94, 71)
        Me.txtNoReserva.Name = "txtNoReserva"
        Me.txtNoReserva.Size = New System.Drawing.Size(187, 20)
        Me.txtNoReserva.TabIndex = 3
        '
        'txtNoCtaBancaria
        '
        Me.txtNoCtaBancaria.BackColor = System.Drawing.Color.White
        Me.txtNoCtaBancaria.Location = New System.Drawing.Point(94, 41)
        Me.txtNoCtaBancaria.Name = "txtNoCtaBancaria"
        Me.txtNoCtaBancaria.Size = New System.Drawing.Size(187, 20)
        Me.txtNoCtaBancaria.TabIndex = 2
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(3, 11)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(41, 13)
        Me.lblBanco.TabIndex = 3
        Me.lblBanco.Text = "Banco:"
        '
        'lblNoCtaBancaria
        '
        Me.lblNoCtaBancaria.AutoSize = True
        Me.lblNoCtaBancaria.Location = New System.Drawing.Point(3, 35)
        Me.lblNoCtaBancaria.Name = "lblNoCtaBancaria"
        Me.lblNoCtaBancaria.Size = New System.Drawing.Size(79, 26)
        Me.lblNoCtaBancaria.TabIndex = 2
        Me.lblNoCtaBancaria.Text = "No. de Cuenta " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bancaria:"
        '
        'lblNoCheque
        '
        Me.lblNoCheque.AutoSize = True
        Me.lblNoCheque.Location = New System.Drawing.Point(3, 100)
        Me.lblNoCheque.Name = "lblNoCheque"
        Me.lblNoCheque.Size = New System.Drawing.Size(82, 13)
        Me.lblNoCheque.TabIndex = 1
        Me.lblNoCheque.Text = "No. de Cheque:"
        '
        'lblNoReserva
        '
        Me.lblNoReserva.AutoSize = True
        Me.lblNoReserva.Location = New System.Drawing.Point(3, 74)
        Me.lblNoReserva.Name = "lblNoReserva"
        Me.lblNoReserva.Size = New System.Drawing.Size(85, 13)
        Me.lblNoReserva.TabIndex = 0
        Me.lblNoReserva.Text = "No. de Reserva:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(241, 222)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 28)
        Me.btnAceptar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptar.TabIndex = 179
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAceptar.UseSelectable = True
        Me.btnAceptar.UseStyleColors = True
        '
        'frmMsDatosCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(337, 284)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(337, 284)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(337, 284)
        Me.Name = "frmMsDatosCheque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Datos de Cheque"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNoReserva As System.Windows.Forms.TextBox
    Friend WithEvents txtNoCtaBancaria As System.Windows.Forms.TextBox
    Friend WithEvents lblBanco As System.Windows.Forms.Label
    Friend WithEvents lblNoCtaBancaria As System.Windows.Forms.Label
    Friend WithEvents lblNoCheque As System.Windows.Forms.Label
    Friend WithEvents lblNoReserva As System.Windows.Forms.Label
    Friend WithEvents txtIdBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
End Class
