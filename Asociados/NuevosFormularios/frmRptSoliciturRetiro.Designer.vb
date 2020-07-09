<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptSoliciturRetiro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnReporte = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DUI:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(145, 24)
        Me.MaskedTextBox1.Mask = "00000000-0"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(395, 22)
        Me.MaskedTextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.Location = New System.Drawing.Point(145, 52)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.Size = New System.Drawing.Size(395, 22)
        Me.txtAsociado.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Solicitud:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(145, 80)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(395, 22)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Motivo Retiro:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(145, 108)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(395, 220)
        Me.TextBox1.TabIndex = 7
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(288, 334)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(125, 32)
        Me.btnReporte.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnReporte.TabIndex = 8
        Me.btnReporte.Text = "Generar Reporte"
        Me.btnReporte.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnReporte.UseSelectable = True
        Me.btnReporte.UseStyleColors = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(419, 334)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(121, 32)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar Solicitud"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmRptSoliciturRetiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 422)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRptSoliciturRetiro"
        Me.Text = "frmRptSoliciturRetiro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAsociado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnReporte As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
End Class
