<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCierreMesCompra
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
        Me.chkCerrado = New System.Windows.Forms.CheckBox()
        Me.txtBloque = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.txtAnio = New System.Windows.Forms.NumericUpDown()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblAnnio = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        CType(Me.txtBloque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkCerrado)
        Me.Panel1.Controls.Add(Me.txtBloque)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbMes)
        Me.Panel1.Controls.Add(Me.txtAnio)
        Me.Panel1.Controls.Add(Me.lblMes)
        Me.Panel1.Controls.Add(Me.lblAnnio)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 110)
        Me.Panel1.TabIndex = 0
        '
        'chkCerrado
        '
        Me.chkCerrado.AutoSize = True
        Me.chkCerrado.Location = New System.Drawing.Point(125, 71)
        Me.chkCerrado.Name = "chkCerrado"
        Me.chkCerrado.Size = New System.Drawing.Size(63, 17)
        Me.chkCerrado.TabIndex = 4
        Me.chkCerrado.Text = "Cerrado"
        Me.chkCerrado.UseVisualStyleBackColor = True
        '
        'txtBloque
        '
        Me.txtBloque.BackColor = System.Drawing.Color.White
        Me.txtBloque.Location = New System.Drawing.Point(52, 70)
        Me.txtBloque.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txtBloque.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtBloque.Name = "txtBloque"
        Me.txtBloque.Size = New System.Drawing.Size(49, 20)
        Me.txtBloque.TabIndex = 182
        Me.txtBloque.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Bloque:"
        '
        'cbMes
        '
        Me.cbMes.BackColor = System.Drawing.Color.White
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Items.AddRange(New Object() {"Enero", "Febrero ", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMes.Location = New System.Drawing.Point(52, 40)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(136, 21)
        Me.cbMes.TabIndex = 3
        '
        'txtAnio
        '
        Me.txtAnio.BackColor = System.Drawing.Color.White
        Me.txtAnio.Location = New System.Drawing.Point(52, 14)
        Me.txtAnio.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.txtAnio.Minimum = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(136, 20)
        Me.txtAnio.TabIndex = 2
        Me.txtAnio.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(2, 43)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(30, 13)
        Me.lblMes.TabIndex = 1
        Me.lblMes.Text = "Mes:"
        '
        'lblAnnio
        '
        Me.lblAnnio.AutoSize = True
        Me.lblAnnio.Location = New System.Drawing.Point(3, 19)
        Me.lblAnnio.Name = "lblAnnio"
        Me.lblAnnio.Size = New System.Drawing.Size(29, 13)
        Me.lblAnnio.TabIndex = 0
        Me.lblAnnio.Text = "Año:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(179, 179)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(70, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 166
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmMCierreMesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(266, 217)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(266, 217)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(266, 217)
        Me.Name = "frmMCierreMesCompra"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cierre Mes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtBloque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAnnio As System.Windows.Forms.Label
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents txtAnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkCerrado As System.Windows.Forms.CheckBox
    Friend WithEvents txtBloque As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
End Class
