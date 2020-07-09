<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnulacionTransferencia
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
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaIni = New MetroFramework.Controls.MetroDateTime()
        Me.rbFecha = New MetroFramework.Controls.MetroRadioButton()
        Me.dtpFechaFin = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.rbResponsable = New MetroFramework.Controls.MetroRadioButton()
        Me.txtResponsable = New MetroFramework.Controls.MetroTextBox()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.dgTransferencias = New MetroFramework.Controls.MetroGrid()
        Me.btnAnular = New MetroFramework.Controls.MetroButton()
        CType(Me.dgTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(105, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "Buscar Por:"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(32, 116)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(52, 20)
        Me.MetroLabel1.TabIndex = 10
        Me.MetroLabel1.Text = "Desde:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Location = New System.Drawing.Point(90, 116)
        Me.dtpFechaIni.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(222, 30)
        Me.dtpFechaIni.TabIndex = 11
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(32, 96)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(66, 17)
        Me.rbFecha.Style = MetroFramework.MetroColorStyle.Teal
        Me.rbFecha.TabIndex = 12
        Me.rbFecha.Text = "Fechas:"
        Me.rbFecha.UseSelectable = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(370, 116)
        Me.dtpFechaFin.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(222, 30)
        Me.dtpFechaFin.TabIndex = 14
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(318, 116)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(46, 20)
        Me.MetroLabel3.TabIndex = 13
        Me.MetroLabel3.Text = "Hasta:"
        '
        'rbResponsable
        '
        Me.rbResponsable.AutoSize = True
        Me.rbResponsable.Location = New System.Drawing.Point(32, 152)
        Me.rbResponsable.Name = "rbResponsable"
        Me.rbResponsable.Size = New System.Drawing.Size(102, 17)
        Me.rbResponsable.Style = MetroFramework.MetroColorStyle.Teal
        Me.rbResponsable.TabIndex = 15
        Me.rbResponsable.Text = "Responsable:"
        Me.rbResponsable.UseSelectable = True
        '
        'txtResponsable
        '
        '
        '
        '
        Me.txtResponsable.CustomButton.Image = Nothing
        Me.txtResponsable.CustomButton.Location = New System.Drawing.Point(538, 1)
        Me.txtResponsable.CustomButton.Name = ""
        Me.txtResponsable.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtResponsable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtResponsable.CustomButton.TabIndex = 1
        Me.txtResponsable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtResponsable.CustomButton.UseSelectable = True
        Me.txtResponsable.CustomButton.Visible = False
        Me.txtResponsable.Lines = New String(-1) {}
        Me.txtResponsable.Location = New System.Drawing.Point(32, 175)
        Me.txtResponsable.MaxLength = 32767
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResponsable.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtResponsable.SelectedText = ""
        Me.txtResponsable.SelectionLength = 0
        Me.txtResponsable.SelectionStart = 0
        Me.txtResponsable.ShortcutsEnabled = True
        Me.txtResponsable.Size = New System.Drawing.Size(560, 23)
        Me.txtResponsable.TabIndex = 16
        Me.txtResponsable.UseSelectable = True
        Me.txtResponsable.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtResponsable.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(29, 204)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(99, 33)
        Me.btnBuscar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar.TabIndex = 235
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseSelectable = True
        Me.btnBuscar.UseStyleColors = True
        '
        'dgTransferencias
        '
        Me.dgTransferencias.AllowUserToAddRows = False
        Me.dgTransferencias.AllowUserToDeleteRows = False
        Me.dgTransferencias.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgTransferencias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTransferencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTransferencias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTransferencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgTransferencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgTransferencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTransferencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTransferencias.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgTransferencias.EnableHeadersVisualStyles = False
        Me.dgTransferencias.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgTransferencias.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTransferencias.Location = New System.Drawing.Point(31, 243)
        Me.dgTransferencias.Name = "dgTransferencias"
        Me.dgTransferencias.ReadOnly = True
        Me.dgTransferencias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTransferencias.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgTransferencias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgTransferencias.RowTemplate.Height = 24
        Me.dgTransferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTransferencias.Size = New System.Drawing.Size(559, 257)
        Me.dgTransferencias.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgTransferencias.TabIndex = 236
        Me.dgTransferencias.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dgTransferencias.UseCustomBackColor = True
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(134, 204)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(99, 33)
        Me.btnAnular.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAnular.TabIndex = 237
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.UseSelectable = True
        Me.btnAnular.UseStyleColors = True
        '
        'frmAnulacionTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 566)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.dgTransferencias)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtResponsable)
        Me.Controls.Add(Me.rbResponsable)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.rbFecha)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Name = "frmAnulacionTransferencia"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Anulación Transferencia"
        CType(Me.dgTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaIni As MetroFramework.Controls.MetroDateTime
    Friend WithEvents rbFecha As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents dtpFechaFin As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents rbResponsable As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents txtResponsable As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents dgTransferencias As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnAnular As MetroFramework.Controls.MetroButton
End Class
