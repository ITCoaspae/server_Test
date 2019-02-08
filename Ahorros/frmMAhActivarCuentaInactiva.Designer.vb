<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMAhActivarCuentaInactiva
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
        Me.lblDui = New System.Windows.Forms.Label()
        Me.lblAsociado = New System.Windows.Forms.Label()
        Me.lblNoCuenta = New System.Windows.Forms.Label()
        Me.txtCtaInactiva = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnActivar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(47, 11)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(96, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'lblDui
        '
        Me.lblDui.AutoSize = True
        Me.lblDui.Location = New System.Drawing.Point(12, 11)
        Me.lblDui.Name = "lblDui"
        Me.lblDui.Size = New System.Drawing.Size(29, 13)
        Me.lblDui.TabIndex = 2
        Me.lblDui.Text = "DUI:"
        '
        'lblAsociado
        '
        Me.lblAsociado.AutoSize = True
        Me.lblAsociado.BackColor = System.Drawing.Color.Khaki
        Me.lblAsociado.ForeColor = System.Drawing.Color.Maroon
        Me.lblAsociado.Location = New System.Drawing.Point(149, 11)
        Me.lblAsociado.Name = "lblAsociado"
        Me.lblAsociado.Size = New System.Drawing.Size(0, 13)
        Me.lblAsociado.TabIndex = 158
        '
        'lblNoCuenta
        '
        Me.lblNoCuenta.AutoSize = True
        Me.lblNoCuenta.Location = New System.Drawing.Point(12, 40)
        Me.lblNoCuenta.Name = "lblNoCuenta"
        Me.lblNoCuenta.Size = New System.Drawing.Size(102, 13)
        Me.lblNoCuenta.TabIndex = 159
        Me.lblNoCuenta.Text = "No Cuenta Inactiva:"
        '
        'txtCtaInactiva
        '
        Me.txtCtaInactiva.BackColor = System.Drawing.Color.White
        Me.txtCtaInactiva.Location = New System.Drawing.Point(119, 37)
        Me.txtCtaInactiva.Name = "txtCtaInactiva"
        Me.txtCtaInactiva.Size = New System.Drawing.Size(197, 20)
        Me.txtCtaInactiva.TabIndex = 160
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCtaInactiva)
        Me.Panel1.Controls.Add(Me.txtDui)
        Me.Panel1.Controls.Add(Me.lblDui)
        Me.Panel1.Controls.Add(Me.lblNoCuenta)
        Me.Panel1.Controls.Add(Me.lblAsociado)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 69)
        Me.Panel1.TabIndex = 162
        '
        'btnActivar1
        '
        Me.btnActivar1.Location = New System.Drawing.Point(363, 138)
        Me.btnActivar1.Name = "btnActivar1"
        Me.btnActivar1.Size = New System.Drawing.Size(139, 28)
        Me.btnActivar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnActivar1.TabIndex = 164
        Me.btnActivar1.Text = "Activar Cuenta"
        Me.btnActivar1.UseSelectable = True
        Me.btnActivar1.UseStyleColors = True
        Me.btnActivar1.Visible = False
        '
        'frmMAhActivarCuentaInactiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 185)
        Me.Controls.Add(Me.btnActivar1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(523, 185)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(523, 185)
        Me.Name = "frmMAhActivarCuentaInactiva"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Habilitar Cuentas de Ahorro Inactivas"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblDui As System.Windows.Forms.Label
    Friend WithEvents lblAsociado As System.Windows.Forms.Label
    Friend WithEvents lblNoCuenta As System.Windows.Forms.Label
    Friend WithEvents txtCtaInactiva As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnActivar1 As MetroFramework.Controls.MetroButton
End Class
