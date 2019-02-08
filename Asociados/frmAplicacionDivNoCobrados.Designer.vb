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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.nudAnnio = New System.Windows.Forms.NumericUpDown()
        Me.lblAnnio = New System.Windows.Forms.Label()
        Me.dgDivNoCobrados = New System.Windows.Forms.DataGridView()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
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
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(576, 58)
        Me.Panel2.TabIndex = 156
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(136, 15)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(90, 15)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha:"
        '
        'nudAnnio
        '
        Me.nudAnnio.Location = New System.Drawing.Point(35, 15)
        Me.nudAnnio.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.nudAnnio.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        Me.nudAnnio.Name = "nudAnnio"
        Me.nudAnnio.Size = New System.Drawing.Size(49, 20)
        Me.nudAnnio.TabIndex = 1
        Me.nudAnnio.Value = New Decimal(New Integer() {2013, 0, 0, 0})
        '
        'lblAnnio
        '
        Me.lblAnnio.AutoSize = True
        Me.lblAnnio.Location = New System.Drawing.Point(3, 15)
        Me.lblAnnio.Name = "lblAnnio"
        Me.lblAnnio.Size = New System.Drawing.Size(26, 13)
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
        Me.dgDivNoCobrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDivNoCobrados.Location = New System.Drawing.Point(23, 127)
        Me.dgDivNoCobrados.Name = "dgDivNoCobrados"
        Me.dgDivNoCobrados.ReadOnly = True
        Me.dgDivNoCobrados.Size = New System.Drawing.Size(576, 142)
        Me.dgDivNoCobrados.TabIndex = 157
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(237, 15)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 5
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Location = New System.Drawing.Point(23, 275)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar.TabIndex = 6
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseSelectable = True
        Me.btnProcesar.UseStyleColors = True
        '
        'frmAplicacionDivNoCobrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 309)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.dgDivNoCobrados)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmAplicacionDivNoCobrados"
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
