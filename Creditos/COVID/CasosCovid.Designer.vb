<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CasosCovid
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.btnAnular = New MetroFramework.Controls.MetroButton()
        Me.rbDUI = New MetroFramework.Controls.MetroRadioButton()
        Me.rbCodPrestamo = New MetroFramework.Controls.MetroRadioButton()
        Me.rbFecha = New MetroFramework.Controls.MetroRadioButton()
        Me.txtDui = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodPrestamo = New MetroFramework.Controls.MetroTextBox()
        Me.dtpFechaIni = New MetroFramework.Controls.MetroDateTime()
        Me.dtpFechaFin = New MetroFramework.Controls.MetroDateTime()
        Me.rbTodos = New MetroFramework.Controls.MetroRadioButton()
        Me.btnMostrar = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Location = New System.Drawing.Point(23, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(743, 259)
        Me.DataGridView1.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 201)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 34)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 181
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(131, 201)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 34)
        Me.btnUpdate.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnUpdate.TabIndex = 182
        Me.btnUpdate.Text = "Modificar"
        Me.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnUpdate.UseSelectable = True
        Me.btnUpdate.UseStyleColors = True
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(239, 201)
        Me.btnAnular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(100, 34)
        Me.btnAnular.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAnular.TabIndex = 183
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAnular.UseSelectable = True
        Me.btnAnular.UseStyleColors = True
        '
        'rbDUI
        '
        Me.rbDUI.AutoSize = True
        Me.rbDUI.Location = New System.Drawing.Point(23, 63)
        Me.rbDUI.Name = "rbDUI"
        Me.rbDUI.Size = New System.Drawing.Size(48, 17)
        Me.rbDUI.TabIndex = 184
        Me.rbDUI.Text = "DUI:"
        Me.rbDUI.UseSelectable = True
        '
        'rbCodPrestamo
        '
        Me.rbCodPrestamo.AutoSize = True
        Me.rbCodPrestamo.Location = New System.Drawing.Point(23, 91)
        Me.rbCodPrestamo.Name = "rbCodPrestamo"
        Me.rbCodPrestamo.Size = New System.Drawing.Size(82, 17)
        Me.rbCodPrestamo.TabIndex = 185
        Me.rbCodPrestamo.Text = "Préstamo:"
        Me.rbCodPrestamo.UseSelectable = True
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(23, 120)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(130, 17)
        Me.rbFecha.TabIndex = 186
        Me.rbFecha.Text = "Fecha Suspensión:"
        Me.rbFecha.UseSelectable = True
        '
        'txtDui
        '
        Me.txtDui.Enabled = False
        Me.txtDui.Location = New System.Drawing.Point(169, 63)
        Me.txtDui.Mask = "00000000-0"
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(291, 22)
        Me.txtDui.TabIndex = 187
        '
        'txtCodPrestamo
        '
        '
        '
        '
        Me.txtCodPrestamo.CustomButton.Image = Nothing
        Me.txtCodPrestamo.CustomButton.Location = New System.Drawing.Point(269, 1)
        Me.txtCodPrestamo.CustomButton.Name = ""
        Me.txtCodPrestamo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCodPrestamo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodPrestamo.CustomButton.TabIndex = 1
        Me.txtCodPrestamo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodPrestamo.CustomButton.UseSelectable = True
        Me.txtCodPrestamo.CustomButton.Visible = False
        Me.txtCodPrestamo.Enabled = False
        Me.txtCodPrestamo.Lines = New String(-1) {}
        Me.txtCodPrestamo.Location = New System.Drawing.Point(169, 91)
        Me.txtCodPrestamo.MaxLength = 32767
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodPrestamo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodPrestamo.SelectedText = ""
        Me.txtCodPrestamo.SelectionLength = 0
        Me.txtCodPrestamo.SelectionStart = 0
        Me.txtCodPrestamo.ShortcutsEnabled = True
        Me.txtCodPrestamo.Size = New System.Drawing.Size(291, 23)
        Me.txtCodPrestamo.TabIndex = 188
        Me.txtCodPrestamo.UseSelectable = True
        Me.txtCodPrestamo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodPrestamo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Enabled = False
        Me.dtpFechaIni.Location = New System.Drawing.Point(169, 120)
        Me.dtpFechaIni.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(291, 30)
        Me.dtpFechaIni.TabIndex = 189
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaFin.Location = New System.Drawing.Point(475, 120)
        Me.dtpFechaFin.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(291, 30)
        Me.dtpFechaFin.TabIndex = 190
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(466, 63)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(60, 17)
        Me.rbTodos.TabIndex = 191
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseSelectable = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(665, 157)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(100, 34)
        Me.btnMostrar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar.TabIndex = 192
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar.UseSelectable = True
        Me.btnMostrar.UseStyleColors = True
        '
        'CasosCovid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 555)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.rbFecha)
        Me.Controls.Add(Me.rbCodPrestamo)
        Me.Controls.Add(Me.rbDUI)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CasosCovid"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "CasosCovid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAnular As MetroFramework.Controls.MetroButton
    Friend WithEvents rbDUI As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbCodPrestamo As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbFecha As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents txtDui As MaskedTextBox
    Friend WithEvents txtCodPrestamo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpFechaIni As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpFechaFin As MetroFramework.Controls.MetroDateTime
    Friend WithEvents rbTodos As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents btnMostrar As MetroFramework.Controls.MetroButton
End Class
