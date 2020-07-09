<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaTablasAmortizacion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTasa = New System.Windows.Forms.TextBox()
        Me.lblTasaInteres = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaVenc = New System.Windows.Forms.Label()
        Me.dtpFechaOtor = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.codPrest = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAsociado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtTasa)
        Me.GroupBox1.Controls.Add(Me.lblTasaInteres)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtSaldo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFecVencimiento)
        Me.GroupBox1.Controls.Add(Me.LblFechaVenc)
        Me.GroupBox1.Controls.Add(Me.dtpFechaOtor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.codPrest)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblAsociado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(31, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(659, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Préstamo"
        '
        'txtTasa
        '
        Me.txtTasa.BackColor = System.Drawing.Color.White
        Me.txtTasa.Location = New System.Drawing.Point(496, 110)
        Me.txtTasa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.ReadOnly = True
        Me.txtTasa.Size = New System.Drawing.Size(132, 22)
        Me.txtTasa.TabIndex = 15
        '
        'lblTasaInteres
        '
        Me.lblTasaInteres.AutoSize = True
        Me.lblTasaInteres.ForeColor = System.Drawing.Color.Black
        Me.lblTasaInteres.Location = New System.Drawing.Point(347, 117)
        Me.lblTasaInteres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTasaInteres.Name = "lblTasaInteres"
        Me.lblTasaInteres.Size = New System.Drawing.Size(111, 17)
        Me.lblTasaInteres.TabIndex = 14
        Me.lblTasaInteres.Text = "Tasa de Interes:"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.Location = New System.Drawing.Point(496, 78)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(132, 22)
        Me.txtMonto.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(347, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Monto:"
        '
        'TxtSaldo
        '
        Me.TxtSaldo.BackColor = System.Drawing.Color.White
        Me.TxtSaldo.Location = New System.Drawing.Point(155, 113)
        Me.TxtSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.ReadOnly = True
        Me.TxtSaldo.Size = New System.Drawing.Size(183, 22)
        Me.TxtSaldo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Saldo Capital:"
        '
        'dtpFecVencimiento
        '
        Me.dtpFecVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecVencimiento.Location = New System.Drawing.Point(155, 81)
        Me.dtpFecVencimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecVencimiento.Name = "dtpFecVencimiento"
        Me.dtpFecVencimiento.Size = New System.Drawing.Size(183, 22)
        Me.dtpFecVencimiento.TabIndex = 7
        '
        'LblFechaVenc
        '
        Me.LblFechaVenc.AutoSize = True
        Me.LblFechaVenc.ForeColor = System.Drawing.Color.Black
        Me.LblFechaVenc.Location = New System.Drawing.Point(12, 81)
        Me.LblFechaVenc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFechaVenc.Name = "LblFechaVenc"
        Me.LblFechaVenc.Size = New System.Drawing.Size(132, 17)
        Me.LblFechaVenc.TabIndex = 6
        Me.LblFechaVenc.Text = "Fecha Vencimiento:"
        '
        'dtpFechaOtor
        '
        Me.dtpFechaOtor.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaOtor.Location = New System.Drawing.Point(496, 46)
        Me.dtpFechaOtor.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaOtor.Name = "dtpFechaOtor"
        Me.dtpFechaOtor.Size = New System.Drawing.Size(132, 22)
        Me.dtpFechaOtor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(347, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Otorgamiento:"
        '
        'codPrest
        '
        Me.codPrest.BackColor = System.Drawing.Color.White
        Me.codPrest.Location = New System.Drawing.Point(155, 49)
        Me.codPrest.Margin = New System.Windows.Forms.Padding(4)
        Me.codPrest.Name = "codPrest"
        Me.codPrest.Size = New System.Drawing.Size(183, 22)
        Me.codPrest.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Codigo de préstamo:"
        '
        'lblAsociado
        '
        Me.lblAsociado.AutoSize = True
        Me.lblAsociado.ForeColor = System.Drawing.Color.Black
        Me.lblAsociado.Location = New System.Drawing.Point(88, 20)
        Me.lblAsociado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsociado.Name = "lblAsociado"
        Me.lblAsociado.Size = New System.Drawing.Size(51, 17)
        Me.lblAsociado.TabIndex = 1
        Me.lblAsociado.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asociado:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 282)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(709, 197)
        Me.DataGridView1.TabIndex = 1
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(146, 240)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 34)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 165
        Me.MetroButton1.Text = "Guardar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(31, 240)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(107, 34)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 166
        Me.MetroButton2.Text = "Importar Tabla"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'frmCargaTablasAmortizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(771, 527)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCargaTablasAmortizacion"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "m "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAsociado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents codPrest As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaOtor As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaVenc As System.Windows.Forms.Label
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTasaInteres As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtTasa As TextBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
