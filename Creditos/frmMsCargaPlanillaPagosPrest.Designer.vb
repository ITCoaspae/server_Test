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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbPagaduria = New System.Windows.Forms.ComboBox()
        Me.cbCtaOrigen = New System.Windows.Forms.ComboBox()
        Me.lblCtaOrigen = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCargar1 = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCargar1)
        Me.Panel1.Controls.Add(Me.btnProcesar1)
        Me.Panel1.Controls.Add(Me.cbPagaduria)
        Me.Panel1.Controls.Add(Me.cbCtaOrigen)
        Me.Panel1.Controls.Add(Me.lblCtaOrigen)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 67)
        Me.Panel1.TabIndex = 11
        '
        'cbPagaduria
        '
        Me.cbPagaduria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPagaduria.FormattingEnabled = True
        Me.cbPagaduria.Location = New System.Drawing.Point(72, 5)
        Me.cbPagaduria.Name = "cbPagaduria"
        Me.cbPagaduria.Size = New System.Drawing.Size(425, 21)
        Me.cbPagaduria.TabIndex = 9
        '
        'cbCtaOrigen
        '
        Me.cbCtaOrigen.FormattingEnabled = True
        Me.cbCtaOrigen.Location = New System.Drawing.Point(72, 32)
        Me.cbCtaOrigen.Name = "cbCtaOrigen"
        Me.cbCtaOrigen.Size = New System.Drawing.Size(425, 21)
        Me.cbCtaOrigen.TabIndex = 8
        '
        'lblCtaOrigen
        '
        Me.lblCtaOrigen.AutoSize = True
        Me.lblCtaOrigen.Location = New System.Drawing.Point(3, 35)
        Me.lblCtaOrigen.Name = "lblCtaOrigen"
        Me.lblCtaOrigen.Size = New System.Drawing.Size(63, 13)
        Me.lblCtaOrigen.TabIndex = 7
        Me.lblCtaOrigen.Text = "Cta. Origen:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 9)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(58, 13)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Pagaduria:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(503, 6)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
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
        Me.DataGridView1.Location = New System.Drawing.Point(23, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(717, 206)
        Me.DataGridView1.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(584, 32)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 239
        Me.btnProcesar1.Text = "Procesar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'btnCargar1
        '
        Me.btnCargar1.Location = New System.Drawing.Point(503, 32)
        Me.btnCargar1.Name = "btnCargar1"
        Me.btnCargar1.Size = New System.Drawing.Size(75, 28)
        Me.btnCargar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCargar1.TabIndex = 238
        Me.btnCargar1.Text = "Cargar"
        Me.btnCargar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCargar1.UseSelectable = True
        Me.btnCargar1.UseStyleColors = True
        '
        'frmMsCargaPlanillaPagosPrest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(763, 397)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMsCargaPlanillaPagosPrest"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Carga de planillas de pagos Préstamos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbPagaduria As System.Windows.Forms.ComboBox
    Friend WithEvents cbCtaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents lblCtaOrigen As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCargar1 As MetroFramework.Controls.MetroButton
End Class
