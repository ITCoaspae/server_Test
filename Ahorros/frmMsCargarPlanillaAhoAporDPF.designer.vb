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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.cbPagaduria = New System.Windows.Forms.ComboBox()
        Me.cbCtaOrigen = New System.Windows.Forms.ComboBox()
        Me.lblCtaOrigen = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
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
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(695, 132)
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
        Me.Panel1.Location = New System.Drawing.Point(26, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 74)
        Me.Panel1.TabIndex = 12
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(109, 143)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(80, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 220
        Me.MetroButton1.Text = "Procesar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(23, 143)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 28)
        Me.btnAceptar.Style = MetroFramework.MetroColorStyle.Green
        Me.btnAceptar.TabIndex = 219
        Me.btnAceptar.Text = "Cargar Datos"
        Me.btnAceptar.UseSelectable = True
        Me.btnAceptar.UseStyleColors = True
        '
        'cbPagaduria
        '
        Me.cbPagaduria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPagaduria.FormattingEnabled = True
        Me.cbPagaduria.Location = New System.Drawing.Point(91, 8)
        Me.cbPagaduria.Name = "cbPagaduria"
        Me.cbPagaduria.Size = New System.Drawing.Size(415, 21)
        Me.cbPagaduria.TabIndex = 9
        '
        'cbCtaOrigen
        '
        Me.cbCtaOrigen.FormattingEnabled = True
        Me.cbCtaOrigen.Location = New System.Drawing.Point(91, 40)
        Me.cbCtaOrigen.Name = "cbCtaOrigen"
        Me.cbCtaOrigen.Size = New System.Drawing.Size(415, 21)
        Me.cbCtaOrigen.TabIndex = 8
        '
        'lblCtaOrigen
        '
        Me.lblCtaOrigen.AutoSize = True
        Me.lblCtaOrigen.Location = New System.Drawing.Point(3, 38)
        Me.lblCtaOrigen.Name = "lblCtaOrigen"
        Me.lblCtaOrigen.Size = New System.Drawing.Size(82, 26)
        Me.lblCtaOrigen.TabIndex = 7
        Me.lblCtaOrigen.Text = "Remesa " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proveniente de:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 12)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(58, 13)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Pagaduria:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(512, 8)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(166, 20)
        Me.dtpFecha.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnPlantilla
        '
        Me.btnPlantilla.Location = New System.Drawing.Point(195, 143)
        Me.btnPlantilla.Name = "btnPlantilla"
        Me.btnPlantilla.Size = New System.Drawing.Size(80, 28)
        Me.btnPlantilla.Style = MetroFramework.MetroColorStyle.Green
        Me.btnPlantilla.TabIndex = 221
        Me.btnPlantilla.Text = "Plantilla"
        Me.btnPlantilla.UseSelectable = True
        Me.btnPlantilla.UseStyleColors = True
        '
        'frmMsCargarPlanillaAhoAporDPF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(744, 370)
        Me.Controls.Add(Me.btnPlantilla)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.DataGridView1)
        Me.MinimumSize = New System.Drawing.Size(744, 370)
        Me.Name = "frmMsCargarPlanillaAhoAporDPF"
        Me.Style = MetroFramework.MetroColorStyle.Green
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
