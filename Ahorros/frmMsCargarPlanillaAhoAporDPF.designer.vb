<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsCargarPlanillaAhoAporDPF
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbPagaduria = New System.Windows.Forms.ComboBox()
        Me.cbCtaOrigen = New System.Windows.Forms.ComboBox()
        Me.lblCtaOrigen = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnPlantilla = New MetroFramework.Controls.MetroButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(31, 218)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Size = New System.Drawing.Size(927, 162)
        Me.DataGridView1.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cbPagaduria)
        Me.Panel1.Controls.Add(Me.cbCtaOrigen)
        Me.Panel1.Controls.Add(Me.lblCtaOrigen)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Location = New System.Drawing.Point(35, 78)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 91)
        Me.Panel1.TabIndex = 12
        '
        'cbPagaduria
        '
        Me.cbPagaduria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPagaduria.FormattingEnabled = True
        Me.cbPagaduria.Location = New System.Drawing.Point(121, 10)
        Me.cbPagaduria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbPagaduria.Name = "cbPagaduria"
        Me.cbPagaduria.Size = New System.Drawing.Size(552, 24)
        Me.cbPagaduria.TabIndex = 9
        '
        'cbCtaOrigen
        '
        Me.cbCtaOrigen.FormattingEnabled = True
        Me.cbCtaOrigen.Location = New System.Drawing.Point(121, 49)
        Me.cbCtaOrigen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCtaOrigen.Name = "cbCtaOrigen"
        Me.cbCtaOrigen.Size = New System.Drawing.Size(552, 24)
        Me.cbCtaOrigen.TabIndex = 8
        '
        'lblCtaOrigen
        '
        Me.lblCtaOrigen.AutoSize = True
        Me.lblCtaOrigen.Location = New System.Drawing.Point(4, 47)
        Me.lblCtaOrigen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCtaOrigen.Name = "lblCtaOrigen"
        Me.lblCtaOrigen.Size = New System.Drawing.Size(108, 34)
        Me.lblCtaOrigen.TabIndex = 7
        Me.lblCtaOrigen.Text = "Remesa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveniente de:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(4, 15)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(77, 17)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Pagaduria:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(683, 10)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(220, 22)
        Me.dtpFecha.TabIndex = 6
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(145, 176)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(107, 34)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 220
        Me.MetroButton1.Text = "Procesar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(31, 176)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(107, 34)
        Me.btnAceptar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptar.TabIndex = 219
        Me.btnAceptar.Text = "Cargar Datos"
        Me.btnAceptar.UseSelectable = True
        Me.btnAceptar.UseStyleColors = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnPlantilla
        '
        Me.btnPlantilla.Location = New System.Drawing.Point(260, 176)
        Me.btnPlantilla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPlantilla.Name = "btnPlantilla"
        Me.btnPlantilla.Size = New System.Drawing.Size(107, 34)
        Me.btnPlantilla.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnPlantilla.TabIndex = 221
        Me.btnPlantilla.Text = "Plantilla"
        Me.btnPlantilla.UseSelectable = True
        Me.btnPlantilla.UseStyleColors = True
        '
        'frmMsCargarPlanillaAhoAporDPF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(992, 455)
        Me.Controls.Add(Me.btnPlantilla)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(992, 455)
        Me.Name = "frmMsCargarPlanillaAhoAporDPF"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Carga de planillas de ahorros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbPagaduria As System.Windows.Forms.ComboBox
    Friend WithEvents cbCtaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents lblCtaOrigen As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPlantilla As MetroFramework.Controls.MetroButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
