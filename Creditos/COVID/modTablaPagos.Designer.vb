<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modTablaPagos
    Inherits MetroFramework.Forms.MetroForm
    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtPrestamo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtTasa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnNotaCred = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mdtIni = New MetroFramework.Controls.MetroDateTime()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mdtFin = New MetroFramework.Controls.MetroDateTime()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 253)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(576, 215)
        Me.DataGridView1.TabIndex = 0
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(23, 210)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(122, 37)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = "Agregar Fila"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(151, 210)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(122, 37)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 2
        Me.MetroButton2.Text = "Eliminar fila"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.Enabled = False
        Me.txtAsociado.Location = New System.Drawing.Point(134, 73)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.Size = New System.Drawing.Size(463, 22)
        Me.txtAsociado.TabIndex = 4
        '
        'txtPrestamo
        '
        Me.txtPrestamo.Enabled = False
        Me.txtPrestamo.Location = New System.Drawing.Point(134, 101)
        Me.txtPrestamo.Name = "txtPrestamo"
        Me.txtPrestamo.Size = New System.Drawing.Size(180, 22)
        Me.txtPrestamo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cod. Préstamo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(417, 99)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(180, 22)
        Me.txtMonto.TabIndex = 8
        '
        'txtTasa
        '
        Me.txtTasa.Enabled = False
        Me.txtTasa.Location = New System.Drawing.Point(417, 129)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Size = New System.Drawing.Size(180, 22)
        Me.txtTasa.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tasa Interés:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(477, 474)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(122, 37)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar Tabla"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'btnNotaCred
        '
        Me.btnNotaCred.Location = New System.Drawing.Point(417, 210)
        Me.btnNotaCred.Name = "btnNotaCred"
        Me.btnNotaCred.Size = New System.Drawing.Size(142, 37)
        Me.btnNotaCred.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnNotaCred.TabIndex = 192
        Me.btnNotaCred.Text = "Aplicar Nota Crédito"
        Me.btnNotaCred.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnNotaCred.UseSelectable = True
        Me.btnNotaCred.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(279, 210)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(132, 37)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 193
        Me.MetroButton3.Text = "Calcular Aditivos"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 17)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "Periodo de pagos diferido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 195
        Me.Label6.Text = "Desde:"
        '
        'mdtIni
        '
        Me.mdtIni.Enabled = False
        Me.mdtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdtIni.Location = New System.Drawing.Point(134, 174)
        Me.mdtIni.MinimumSize = New System.Drawing.Size(0, 30)
        Me.mdtIni.Name = "mdtIni"
        Me.mdtIni.Size = New System.Drawing.Size(180, 30)
        Me.mdtIni.TabIndex = 196
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(320, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 197
        Me.Label7.Text = "Hasta:"
        '
        'mdtFin
        '
        Me.mdtFin.Enabled = False
        Me.mdtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdtFin.Location = New System.Drawing.Point(417, 174)
        Me.mdtFin.MinimumSize = New System.Drawing.Size(0, 30)
        Me.mdtFin.Name = "mdtFin"
        Me.mdtFin.Size = New System.Drawing.Size(180, 30)
        Me.mdtFin.TabIndex = 198
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Location = New System.Drawing.Point(134, 129)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(180, 22)
        Me.txtSaldo.TabIndex = 200
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 199
        Me.Label8.Text = "Saldo:"
        '
        'modTablaPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 574)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mdtFin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mdtIni)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.btnNotaCred)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtTasa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrestamo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "modTablaPagos"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tabla de pagos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAsociado As TextBox
    Friend WithEvents txtPrestamo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtTasa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNotaCred As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mdtIni As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label7 As Label
    Friend WithEvents mdtFin As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label8 As Label
End Class
