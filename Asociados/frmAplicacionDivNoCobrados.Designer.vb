<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicacionDivNoCobrados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.nudAnnio = New System.Windows.Forms.NumericUpDown()
        Me.lblAnnio = New System.Windows.Forms.Label()
        Me.dgDivNoCobrados = New System.Windows.Forms.DataGridView()
        Me.btnProcesar = New MetroFramework.Controls.MetroButton()
        Me.Panel2.SuspendLayout()
        CType(Me.nudAnnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDivNoCobrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnMostrar1)
        Me.Panel2.Controls.Add(Me.dtpFecha)
        Me.Panel2.Controls.Add(Me.lblFecha)
        Me.Panel2.Controls.Add(Me.nudAnnio)
        Me.Panel2.Controls.Add(Me.lblAnnio)
        Me.Panel2.Location = New System.Drawing.Point(31, 78)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 71)
        Me.Panel2.TabIndex = 156
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(314, 18)
        Me.btnMostrar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(100, 34)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 5
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(181, 18)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(125, 22)
        Me.dtpFecha.TabIndex = 3
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(120, 18)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(51, 17)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha:"
        '
        'nudAnnio
        '
        Me.nudAnnio.Location = New System.Drawing.Point(47, 18)
        Me.nudAnnio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudAnnio.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.nudAnnio.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        Me.nudAnnio.Name = "nudAnnio"
        Me.nudAnnio.Size = New System.Drawing.Size(65, 22)
        Me.nudAnnio.TabIndex = 1
        Me.nudAnnio.Value = New Decimal(New Integer() {2013, 0, 0, 0})
        '
        'lblAnnio
        '
        Me.lblAnnio.AutoSize = True
        Me.lblAnnio.Location = New System.Drawing.Point(4, 18)
        Me.lblAnnio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnnio.Name = "lblAnnio"
        Me.lblAnnio.Size = New System.Drawing.Size(33, 17)
        Me.lblAnnio.TabIndex = 0
        Me.lblAnnio.Text = "Año"
        '
        'dgDivNoCobrados
        '
        Me.dgDivNoCobrados.AllowUserToAddRows = False
        Me.dgDivNoCobrados.AllowUserToDeleteRows = False
        Me.dgDivNoCobrados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDivNoCobrados.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDivNoCobrados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDivNoCobrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDivNoCobrados.Location = New System.Drawing.Point(31, 156)
        Me.dgDivNoCobrados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgDivNoCobrados.Name = "dgDivNoCobrados"
        Me.dgDivNoCobrados.ReadOnly = True
        Me.dgDivNoCobrados.Size = New System.Drawing.Size(615, 221)
        Me.dgDivNoCobrados.TabIndex = 157
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Location = New System.Drawing.Point(537, 385)
        Me.btnProcesar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(100, 34)
        Me.btnProcesar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar.TabIndex = 6
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseSelectable = True
        Me.btnProcesar.UseStyleColors = True
        '
        'frmAplicacionDivNoCobrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 504)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.dgDivNoCobrados)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAplicacionDivNoCobrados"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Aplicación de dividendos no cobrados"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.nudAnnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDivNoCobrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgDivNoCobrados As System.Windows.Forms.DataGridView
    Friend WithEvents nudAnnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblAnnio As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProcesar As MetroFramework.Controls.MetroButton
End Class
