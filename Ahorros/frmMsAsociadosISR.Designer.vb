<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMsAsociadosISR
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
        Me.dtpFechaF = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaI = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpFechaF
        '
        Me.dtpFechaF.Location = New System.Drawing.Point(126, 104)
        Me.dtpFechaF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaF.Name = "dtpFechaF"
        Me.dtpFechaF.Size = New System.Drawing.Size(272, 22)
        Me.dtpFechaF.TabIndex = 3
        '
        'dtpFechaI
        '
        Me.dtpFechaI.Location = New System.Drawing.Point(126, 74)
        Me.dtpFechaI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaI.Name = "dtpFechaI"
        Me.dtpFechaI.Size = New System.Drawing.Size(272, 22)
        Me.dtpFechaI.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Fin:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(291, 134)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(107, 34)
        Me.btnAceptar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptar.TabIndex = 218
        Me.btnAceptar.Text = "Procesar"
        Me.btnAceptar.UseSelectable = True
        Me.btnAceptar.UseStyleColors = True
        '
        'frmMsAsociadosISR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(425, 218)
        Me.Controls.Add(Me.dtpFechaF)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFechaI)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAsociadosISR"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Aplicacion de ISR Asociados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
End Class
