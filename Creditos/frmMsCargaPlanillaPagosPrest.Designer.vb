<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsCargaPlanillaPagosPrest
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
        Me.btnCargar1 = New MetroFramework.Controls.MetroButton()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.cbPagaduria = New System.Windows.Forms.ComboBox()
        Me.cbCtaOrigen = New System.Windows.Forms.ComboBox()
        Me.lblCtaOrigen = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCargar1
        '
        Me.btnCargar1.Location = New System.Drawing.Point(396, 138)
        Me.btnCargar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCargar1.Name = "btnCargar1"
        Me.btnCargar1.Size = New System.Drawing.Size(100, 34)
        Me.btnCargar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCargar1.TabIndex = 238
        Me.btnCargar1.Text = "Cargar"
        Me.btnCargar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCargar1.UseSelectable = True
        Me.btnCargar1.UseStyleColors = True
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(504, 138)
        Me.btnProcesar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(100, 34)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 239
        Me.btnProcesar1.Text = "Procesar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'cbPagaduria
        '
        Me.cbPagaduria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPagaduria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPagaduria.FormattingEnabled = True
        Me.cbPagaduria.Location = New System.Drawing.Point(147, 74)
        Me.cbPagaduria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbPagaduria.Name = "cbPagaduria"
        Me.cbPagaduria.Size = New System.Drawing.Size(565, 24)
        Me.cbPagaduria.TabIndex = 9
        '
        'cbCtaOrigen
        '
        Me.cbCtaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCtaOrigen.FormattingEnabled = True
        Me.cbCtaOrigen.Location = New System.Drawing.Point(147, 106)
        Me.cbCtaOrigen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCtaOrigen.Name = "cbCtaOrigen"
        Me.cbCtaOrigen.Size = New System.Drawing.Size(565, 24)
        Me.cbCtaOrigen.TabIndex = 8
        '
        'lblCtaOrigen
        '
        Me.lblCtaOrigen.AutoSize = True
        Me.lblCtaOrigen.Location = New System.Drawing.Point(31, 102)
        Me.lblCtaOrigen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCtaOrigen.Name = "lblCtaOrigen"
        Me.lblCtaOrigen.Size = New System.Drawing.Size(108, 34)
        Me.lblCtaOrigen.TabIndex = 7
        Me.lblCtaOrigen.Text = "Remesa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveniente de:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(31, 74)
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
        Me.dtpFecha.Location = New System.Drawing.Point(147, 143)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(132, 22)
        Me.dtpFecha.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 180)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(678, 115)
        Me.DataGridView1.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(612, 138)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 34)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 240
        Me.MetroButton1.Text = "Plantilla"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 143)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 241
        Me.Label1.Text = "Fecha Carga:"
        '
        'frmMsCargaPlanillaPagosPrest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(739, 379)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCargar1)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblCtaOrigen)
        Me.Controls.Add(Me.cbCtaOrigen)
        Me.Controls.Add(Me.cbPagaduria)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMsCargaPlanillaPagosPrest"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Carga de planillas de pagos Préstamos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbPagaduria As System.Windows.Forms.ComboBox
    Friend WithEvents cbCtaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents lblCtaOrigen As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCargar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
End Class
