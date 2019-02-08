<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsGarantias
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.txtNOMATRICULA = New System.Windows.Forms.TextBox()
        Me.rbNOMATRICULA = New System.Windows.Forms.RadioButton()
        Me.txtNOCOMPROBANTE = New System.Windows.Forms.TextBox()
        Me.rbNOCOMPROBANTE = New System.Windows.Forms.RadioButton()
        Me.txtDUI = New System.Windows.Forms.MaskedTextBox()
        Me.rbDUI = New System.Windows.Forms.RadioButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(23, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(571, 163)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.btnEliminar1)
        Me.GroupBox1.Controls.Add(Me.txtNOMATRICULA)
        Me.GroupBox1.Controls.Add(Me.rbNOMATRICULA)
        Me.GroupBox1.Controls.Add(Me.txtNOCOMPROBANTE)
        Me.GroupBox1.Controls.Add(Me.rbNOCOMPROBANTE)
        Me.GroupBox1.Controls.Add(Me.txtDUI)
        Me.GroupBox1.Controls.Add(Me.rbDUI)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 77)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar registro por:"
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(483, 34)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 219
        Me.btnEliminar1.Text = "Buscar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'txtNOMATRICULA
        '
        Me.txtNOMATRICULA.Location = New System.Drawing.Point(324, 42)
        Me.txtNOMATRICULA.Name = "txtNOMATRICULA"
        Me.txtNOMATRICULA.Size = New System.Drawing.Size(153, 20)
        Me.txtNOMATRICULA.TabIndex = 5
        '
        'rbNOMATRICULA
        '
        Me.rbNOMATRICULA.AutoSize = True
        Me.rbNOMATRICULA.ForeColor = System.Drawing.Color.Black
        Me.rbNOMATRICULA.Location = New System.Drawing.Point(329, 19)
        Me.rbNOMATRICULA.Name = "rbNOMATRICULA"
        Me.rbNOMATRICULA.Size = New System.Drawing.Size(133, 17)
        Me.rbNOMATRICULA.TabIndex = 4
        Me.rbNOMATRICULA.TabStop = True
        Me.rbNOMATRICULA.Text = "No. Matricula Garantía"
        Me.rbNOMATRICULA.UseVisualStyleBackColor = True
        '
        'txtNOCOMPROBANTE
        '
        Me.txtNOCOMPROBANTE.Location = New System.Drawing.Point(165, 42)
        Me.txtNOCOMPROBANTE.Name = "txtNOCOMPROBANTE"
        Me.txtNOCOMPROBANTE.Size = New System.Drawing.Size(153, 20)
        Me.txtNOCOMPROBANTE.TabIndex = 3
        '
        'rbNOCOMPROBANTE
        '
        Me.rbNOCOMPROBANTE.AutoSize = True
        Me.rbNOCOMPROBANTE.ForeColor = System.Drawing.Color.Black
        Me.rbNOCOMPROBANTE.Location = New System.Drawing.Point(170, 19)
        Me.rbNOCOMPROBANTE.Name = "rbNOCOMPROBANTE"
        Me.rbNOCOMPROBANTE.Size = New System.Drawing.Size(153, 17)
        Me.rbNOCOMPROBANTE.TabIndex = 2
        Me.rbNOCOMPROBANTE.TabStop = True
        Me.rbNOCOMPROBANTE.Text = "No. Comprobante Garantía"
        Me.rbNOCOMPROBANTE.UseVisualStyleBackColor = True
        '
        'txtDUI
        '
        Me.txtDUI.Location = New System.Drawing.Point(6, 42)
        Me.txtDUI.Mask = "00000000-0"
        Me.txtDUI.Name = "txtDUI"
        Me.txtDUI.Size = New System.Drawing.Size(153, 20)
        Me.txtDUI.TabIndex = 1
        '
        'rbDUI
        '
        Me.rbDUI.AutoSize = True
        Me.rbDUI.ForeColor = System.Drawing.Color.Black
        Me.rbDUI.Location = New System.Drawing.Point(6, 19)
        Me.rbDUI.Name = "rbDUI"
        Me.rbDUI.Size = New System.Drawing.Size(88, 17)
        Me.rbDUI.TabIndex = 0
        Me.rbDUI.TabStop = True
        Me.rbDUI.Text = "Dui Asociado"
        Me.rbDUI.UseVisualStyleBackColor = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(188, 146)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(158, 28)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 219
        Me.btnModificar1.Text = "Devolución de Documento"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 146)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(159, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 218
        Me.btnAgregar1.Text = "Prestamo de Documento"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(352, 146)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 221
        Me.MetroButton1.Text = "Modificar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(433, 146)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 220
        Me.MetroButton2.Text = "Consultar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'frmMsGarantias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(617, 390)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmMsGarantias"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "MOVIMIENTOS DE DOC. GARANTÍAS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDUI As System.Windows.Forms.RadioButton
    Friend WithEvents txtDUI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNOCOMPROBANTE As System.Windows.Forms.TextBox
    Friend WithEvents rbNOCOMPROBANTE As System.Windows.Forms.RadioButton
    Friend WithEvents rbNOMATRICULA As System.Windows.Forms.RadioButton
    Friend WithEvents txtNOMATRICULA As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
