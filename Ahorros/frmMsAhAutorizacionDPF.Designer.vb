<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMsAhAutorizacionDPF
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(31, 74)
        Me.lblEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(75, 17)
        Me.lblEmpleado.TabIndex = 0
        Me.lblEmpleado.Text = "Empleado:"
        '
        'cbEmpleado
        '
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(115, 70)
        Me.cbEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(363, 24)
        Me.cbEmpleado.TabIndex = 1
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(379, 103)
        Me.btnGuardar1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 193
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsAhAutorizacionDPF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(509, 175)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.cbEmpleado)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(509, 175)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(509, 175)
        Me.Name = "frmMsAhAutorizacionDPF"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Autorización Tasa DPF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents cbEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
