<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIF

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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.cbSucursal = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroDateTime2 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cbTipoTransaccion = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MetroPanel1.Controls.Add(Me.btnBuscar)
        Me.MetroPanel1.Controls.Add(Me.cbSucursal)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.MetroDateTime2)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.MetroDateTime1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.cbTipoTransaccion)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(652, 179)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnBuscar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnBuscar.Location = New System.Drawing.Point(532, 118)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(101, 38)
        Me.btnBuscar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseSelectable = True
        '
        'cbSucursal
        '
        Me.cbSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.ItemHeight = 24
        Me.cbSucursal.Location = New System.Drawing.Point(124, 82)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(509, 30)
        Me.cbSucursal.TabIndex = 9
        Me.cbSucursal.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 82)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(63, 20)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Sucursal:"
        '
        'MetroDateTime2
        '
        Me.MetroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime2.Location = New System.Drawing.Point(433, 46)
        Me.MetroDateTime2.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MetroDateTime2.Name = "MetroDateTime2"
        Me.MetroDateTime2.Size = New System.Drawing.Size(200, 30)
        Me.MetroDateTime2.TabIndex = 7
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(330, 46)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(71, 20)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Fecha Fin:"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(124, 46)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(200, 30)
        Me.MetroDateTime1.TabIndex = 5
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 46)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(85, 20)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Fecha Inicio:"
        '
        'cbTipoTransaccion
        '
        Me.cbTipoTransaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoTransaccion.FormattingEnabled = True
        Me.cbTipoTransaccion.ItemHeight = 24
        Me.cbTipoTransaccion.Items.AddRange(New Object() {"Operaciones en efectivo diario-UIF F1-01 por  $10,000.00", "Operaciones en Efectivo Mensual-UIF1-02 por $10,000.00", "Operaciones en otro medio  diario-UIF F2-02 por $25,000.00", "Operaciones en otro medio electrónico diario- UIF F2-01E por $25,000.00"})
        Me.cbTipoTransaccion.Location = New System.Drawing.Point(124, 10)
        Me.cbTipoTransaccion.Name = "cbTipoTransaccion"
        Me.cbTipoTransaccion.Size = New System.Drawing.Size(509, 30)
        Me.cbTipoTransaccion.TabIndex = 3
        Me.cbTipoTransaccion.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 10)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(115, 20)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Tipo Transacción:"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 248)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.RowTemplate.Height = 24
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(652, 262)
        Me.MetroGrid1.TabIndex = 1
        '
        'UIF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 593)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "UIF"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Control de Transacciones"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents cbSucursal As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbTipoTransaccion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
End Class
