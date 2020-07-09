<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarSaldosCC
    Inherits MetroFramework.Forms.MetroForm

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
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.NumericUpDown()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mes:"
        '
        'cbMes
        '
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Items.AddRange(New Object() {"-- Seleccione Mes -- ", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMes.Location = New System.Drawing.Point(66, 109)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(336, 24)
        Me.cbMes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Año:"
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(66, 81)
        Me.txtAnio.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.txtAnio.Minimum = New Decimal(New Integer() {2018, 0, 0, 0})
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(336, 22)
        Me.txtAnio.TabIndex = 3
        Me.txtAnio.Value = New Decimal(New Integer() {2018, 0, 0, 0})
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(294, 139)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(108, 32)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 204
        Me.btnProcesar1.Text = "Procesar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmActualizarSaldosCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 229)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbMes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmActualizarSaldosCC"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Actualizar Saldos "
        CType(Me.txtAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbMes As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnio As NumericUpDown
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
End Class
