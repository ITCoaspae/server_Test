<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPignoraciones
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgPignoraciones = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.rbDui = New MetroFramework.Controls.MetroRadioButton()
        Me.rbNoCuenta = New MetroFramework.Controls.MetroRadioButton()
        Me.rbCodPrestamo = New MetroFramework.Controls.MetroRadioButton()
        Me.txtDui = New MetroFramework.Controls.MetroTextBox()
        Me.txtNocuenta = New MetroFramework.Controls.MetroTextBox()
        Me.txtCodPrestamo = New MetroFramework.Controls.MetroTextBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgPignoraciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPignoraciones
        '
        Me.dgPignoraciones.AllowUserToAddRows = False
        Me.dgPignoraciones.AllowUserToDeleteRows = False
        Me.dgPignoraciones.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgPignoraciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPignoraciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPignoraciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPignoraciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPignoraciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgPignoraciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPignoraciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgPignoraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPignoraciones.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgPignoraciones.EnableHeadersVisualStyles = False
        Me.dgPignoraciones.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgPignoraciones.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPignoraciones.Location = New System.Drawing.Point(17, 150)
        Me.dgPignoraciones.Margin = New System.Windows.Forms.Padding(2)
        Me.dgPignoraciones.Name = "dgPignoraciones"
        Me.dgPignoraciones.ReadOnly = True
        Me.dgPignoraciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPignoraciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgPignoraciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgPignoraciones.RowTemplate.Height = 24
        Me.dgPignoraciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPignoraciones.Size = New System.Drawing.Size(539, 167)
        Me.dgPignoraciones.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgPignoraciones.TabIndex = 0
        Me.dgPignoraciones.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dgPignoraciones.UseCustomBackColor = True
        Me.dgPignoraciones.UseCustomForeColor = True
        Me.dgPignoraciones.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 49)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Buscar Por:"
        '
        'rbDui
        '
        Me.rbDui.AutoSize = True
        Me.rbDui.Location = New System.Drawing.Point(17, 76)
        Me.rbDui.Margin = New System.Windows.Forms.Padding(2)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(45, 15)
        Me.rbDui.TabIndex = 2
        Me.rbDui.Text = "DUI:"
        Me.rbDui.UseSelectable = True
        '
        'rbNoCuenta
        '
        Me.rbNoCuenta.AutoSize = True
        Me.rbNoCuenta.Location = New System.Drawing.Point(110, 76)
        Me.rbNoCuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.rbNoCuenta.Name = "rbNoCuenta"
        Me.rbNoCuenta.Size = New System.Drawing.Size(86, 15)
        Me.rbNoCuenta.TabIndex = 3
        Me.rbNoCuenta.Text = "No. Cuenta:"
        Me.rbNoCuenta.UseSelectable = True
        '
        'rbCodPrestamo
        '
        Me.rbCodPrestamo.AutoSize = True
        Me.rbCodPrestamo.Location = New System.Drawing.Point(202, 76)
        Me.rbCodPrestamo.Margin = New System.Windows.Forms.Padding(2)
        Me.rbCodPrestamo.Name = "rbCodPrestamo"
        Me.rbCodPrestamo.Size = New System.Drawing.Size(104, 15)
        Me.rbCodPrestamo.TabIndex = 4
        Me.rbCodPrestamo.Text = "Cod. Préstamo:"
        Me.rbCodPrestamo.UseSelectable = True
        '
        'txtDui
        '
        '
        '
        '
        Me.txtDui.CustomButton.Image = Nothing
        Me.txtDui.CustomButton.Location = New System.Drawing.Point(70, 1)
        Me.txtDui.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDui.CustomButton.Name = ""
        Me.txtDui.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtDui.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDui.CustomButton.TabIndex = 1
        Me.txtDui.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDui.CustomButton.UseSelectable = True
        Me.txtDui.CustomButton.Visible = False
        Me.txtDui.Lines = New String(-1) {}
        Me.txtDui.Location = New System.Drawing.Point(17, 95)
        Me.txtDui.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDui.MaxLength = 32767
        Me.txtDui.Name = "txtDui"
        Me.txtDui.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDui.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDui.SelectedText = ""
        Me.txtDui.SelectionLength = 0
        Me.txtDui.SelectionStart = 0
        Me.txtDui.ShortcutsEnabled = True
        Me.txtDui.Size = New System.Drawing.Size(88, 19)
        Me.txtDui.TabIndex = 5
        Me.txtDui.UseSelectable = True
        Me.txtDui.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDui.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNocuenta
        '
        '
        '
        '
        Me.txtNocuenta.CustomButton.Image = Nothing
        Me.txtNocuenta.CustomButton.Location = New System.Drawing.Point(70, 1)
        Me.txtNocuenta.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNocuenta.CustomButton.Name = ""
        Me.txtNocuenta.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtNocuenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNocuenta.CustomButton.TabIndex = 1
        Me.txtNocuenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNocuenta.CustomButton.UseSelectable = True
        Me.txtNocuenta.CustomButton.Visible = False
        Me.txtNocuenta.Lines = New String(-1) {}
        Me.txtNocuenta.Location = New System.Drawing.Point(110, 95)
        Me.txtNocuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNocuenta.MaxLength = 32767
        Me.txtNocuenta.Name = "txtNocuenta"
        Me.txtNocuenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNocuenta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNocuenta.SelectedText = ""
        Me.txtNocuenta.SelectionLength = 0
        Me.txtNocuenta.SelectionStart = 0
        Me.txtNocuenta.ShortcutsEnabled = True
        Me.txtNocuenta.Size = New System.Drawing.Size(88, 19)
        Me.txtNocuenta.TabIndex = 6
        Me.txtNocuenta.UseSelectable = True
        Me.txtNocuenta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNocuenta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCodPrestamo
        '
        '
        '
        '
        Me.txtCodPrestamo.CustomButton.Image = Nothing
        Me.txtCodPrestamo.CustomButton.Location = New System.Drawing.Point(70, 1)
        Me.txtCodPrestamo.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodPrestamo.CustomButton.Name = ""
        Me.txtCodPrestamo.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtCodPrestamo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodPrestamo.CustomButton.TabIndex = 1
        Me.txtCodPrestamo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodPrestamo.CustomButton.UseSelectable = True
        Me.txtCodPrestamo.CustomButton.Visible = False
        Me.txtCodPrestamo.Lines = New String(-1) {}
        Me.txtCodPrestamo.Location = New System.Drawing.Point(202, 95)
        Me.txtCodPrestamo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodPrestamo.MaxLength = 32767
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodPrestamo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodPrestamo.SelectedText = ""
        Me.txtCodPrestamo.SelectionLength = 0
        Me.txtCodPrestamo.SelectionStart = 0
        Me.txtCodPrestamo.ShortcutsEnabled = True
        Me.txtCodPrestamo.Size = New System.Drawing.Size(88, 19)
        Me.txtCodPrestamo.TabIndex = 7
        Me.txtCodPrestamo.UseSelectable = True
        Me.txtCodPrestamo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodPrestamo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(17, 119)
        Me.btnMostrar1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(68, 26)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 170
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Enabled = False
        Me.btnModificar1.Location = New System.Drawing.Point(191, 119)
        Me.btnModificar1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(78, 27)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 172
        Me.btnModificar1.Text = "Despignorar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(89, 119)
        Me.btnAgregar1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(98, 27)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 171
        Me.btnAgregar1.Text = "Pignorar Cuenta"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmPignoraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 348)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.btnMostrar1)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.txtNocuenta)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.rbCodPrestamo)
        Me.Controls.Add(Me.rbNoCuenta)
        Me.Controls.Add(Me.rbDui)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dgPignoraciones)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPignoraciones"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Pignoración"
        CType(Me.dgPignoraciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgPignoraciones As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents rbDui As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbNoCuenta As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbCodPrestamo As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents txtDui As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNocuenta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCodPrestamo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
End Class
