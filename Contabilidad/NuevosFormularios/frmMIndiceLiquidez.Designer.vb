<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMIndiceLiquidez
    Inherits System.Windows.Forms.Form

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
        Me.dgLiquidez = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.nudAnnio = New System.Windows.Forms.NumericUpDown
        Me.Button1 = New System.Windows.Forms.Button
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.lblAnnio = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblEncabezado = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        CType(Me.dgLiquidez, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nudAnnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgLiquidez
        '
        Me.dgLiquidez.AllowUserToAddRows = False
        Me.dgLiquidez.AllowUserToDeleteRows = False
        Me.dgLiquidez.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLiquidez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLiquidez.Location = New System.Drawing.Point(12, 87)
        Me.dgLiquidez.Name = "dgLiquidez"
        Me.dgLiquidez.ReadOnly = True
        Me.dgLiquidez.Size = New System.Drawing.Size(520, 183)
        Me.dgLiquidez.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.nudAnnio)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.chkTodos)
        Me.Panel1.Controls.Add(Me.lblAnnio)
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 43)
        Me.Panel1.TabIndex = 1
        '
        'nudAnnio
        '
        Me.nudAnnio.BackColor = System.Drawing.Color.Khaki
        Me.nudAnnio.Location = New System.Drawing.Point(57, 14)
        Me.nudAnnio.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudAnnio.Minimum = New Decimal(New Integer() {1990, 0, 0, 0})
        Me.nudAnnio.Name = "nudAnnio"
        Me.nudAnnio.Size = New System.Drawing.Size(59, 20)
        Me.nudAnnio.TabIndex = 6
        Me.nudAnnio.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        'Me.Button1.Image = My.Resources.resMain._001_382
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(222, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Filtrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(122, 14)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(94, 17)
        Me.chkTodos.TabIndex = 4
        Me.chkTodos.Text = "Mostrar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'lblAnnio
        '
        Me.lblAnnio.AutoSize = True
        Me.lblAnnio.Location = New System.Drawing.Point(13, 15)
        Me.lblAnnio.Name = "lblAnnio"
        Me.lblAnnio.Size = New System.Drawing.Size(29, 13)
        Me.lblAnnio.TabIndex = 2
        Me.lblAnnio.Text = "Año:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblEncabezado)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 33)
        Me.Panel2.TabIndex = 155
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.Color.White
        Me.lblEncabezado.Location = New System.Drawing.Point(3, 6)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(182, 24)
        Me.lblEncabezado.TabIndex = 0
        Me.lblEncabezado.Text = "Indice de Liquidez"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnEliminar)
        Me.Panel3.Controls.Add(Me.btnAgregar)
        Me.Panel3.Controls.Add(Me.btnModificar)
        Me.Panel3.Location = New System.Drawing.Point(12, 276)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(519, 35)
        Me.Panel3.TabIndex = 158
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        'Me.btnAgregar.Image = My.Resources.resMain.add
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(6, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        'Me.btnModificar.Image = My.Resources.resMain._001_45
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(87, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 28)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        'Me.btnEliminar.Image = My.Resources.resMain.delete1
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(179, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'frmMIndiceLiquidez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(543, 323)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgLiquidez)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMIndiceLiquidez"
        Me.ShowIcon = False
        CType(Me.dgLiquidez, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudAnnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgLiquidez As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents lblAnnio As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents nudAnnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
