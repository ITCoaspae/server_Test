<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detNotaCredPrest
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
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtPrestamo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNotaCred = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(396, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Enabled = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(153, 79)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PromptText = "Nombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(418, 23)
        Me.txtNombre.TabIndex = 5
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMark = "Nombre"
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 79)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(124, 20)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Nombre Asociado:"
        '
        'txtPrestamo
        '
        Me.txtPrestamo.Enabled = False
        Me.txtPrestamo.Location = New System.Drawing.Point(153, 108)
        Me.txtPrestamo.Name = "txtPrestamo"
        Me.txtPrestamo.Size = New System.Drawing.Size(418, 22)
        Me.txtPrestamo.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cod. Préstamo:"
        '
        'btnNotaCred
        '
        Me.btnNotaCred.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotaCred.Location = New System.Drawing.Point(429, 441)
        Me.btnNotaCred.Name = "btnNotaCred"
        Me.btnNotaCred.Size = New System.Drawing.Size(142, 37)
        Me.btnNotaCred.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnNotaCred.TabIndex = 193
        Me.btnNotaCred.Text = "Aplicar Nota Crédito"
        Me.btnNotaCred.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnNotaCred.UseSelectable = True
        Me.btnNotaCred.UseStyleColors = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(23, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(548, 263)
        Me.DataGridView1.TabIndex = 194
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "Fecha de Pago:"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Enabled = False
        Me.MetroDateTime1.Location = New System.Drawing.Point(153, 136)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(418, 30)
        Me.MetroDateTime1.TabIndex = 196
        '
        'detNotaCredPrest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 528)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnNotaCred)
        Me.Controls.Add(Me.txtPrestamo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Name = "detNotaCredPrest"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Nota de crédito"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPrestamo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNotaCred As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
End Class
