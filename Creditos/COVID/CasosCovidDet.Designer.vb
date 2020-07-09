<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CasosCovidDet
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cbPrestamo = New System.Windows.Forms.ComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.txtDui = New System.Windows.Forms.MaskedTextBox()
        Me.btnModTabla = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 89)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(35, 20)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "DUI:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 118)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(124, 20)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Nombre Asociado:"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(385, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(188, 118)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PromptText = "Nombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(407, 23)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMark = "Nombre"
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 147)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(96, 20)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "No. Préstamo:"
        '
        'cbPrestamo
        '
        Me.cbPrestamo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPrestamo.FormattingEnabled = True
        Me.cbPrestamo.Location = New System.Drawing.Point(188, 147)
        Me.cbPrestamo.Name = "cbPrestamo"
        Me.cbPrestamo.Size = New System.Drawing.Size(407, 24)
        Me.cbPrestamo.TabIndex = 5
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 174)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(159, 20)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Fecha Inicio Suspensión:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Location = New System.Drawing.Point(188, 177)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(407, 22)
        Me.dtpFechaIni.TabIndex = 8
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(188, 205)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(407, 22)
        Me.dtpFechaFin.TabIndex = 10
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 207)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(145, 20)
        Me.MetroLabel5.TabIndex = 9
        Me.MetroLabel5.Text = "Fecha Fin Suspensión:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(494, 234)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 34)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSave.TabIndex = 181
        Me.btnSave.Text = "Guardar"
        Me.btnSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSave.UseSelectable = True
        Me.btnSave.UseStyleColors = True
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(188, 87)
        Me.txtDui.Mask = "00000000-0"
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(407, 22)
        Me.txtDui.TabIndex = 188
        '
        'btnModTabla
        '
        Me.btnModTabla.Location = New System.Drawing.Point(315, 234)
        Me.btnModTabla.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModTabla.Name = "btnModTabla"
        Me.btnModTabla.Size = New System.Drawing.Size(171, 34)
        Me.btnModTabla.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModTabla.TabIndex = 189
        Me.btnModTabla.Text = "Modificar Tabla de Pagos"
        Me.btnModTabla.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModTabla.UseSelectable = True
        Me.btnModTabla.UseStyleColors = True
        Me.btnModTabla.Visible = False
        '
        'CasosCovidDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 329)
        Me.Controls.Add(Me.btnModTabla)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.cbPrestamo)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "CasosCovidDet"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "CasosCovidDet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbPrestamo As ComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaIni As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDui As MaskedTextBox
    Friend WithEvents btnModTabla As MetroFramework.Controls.MetroButton
End Class
