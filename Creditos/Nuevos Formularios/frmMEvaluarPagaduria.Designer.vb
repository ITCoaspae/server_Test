<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMEvaluarPagaduria
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
        Me.lblPagaduria = New System.Windows.Forms.Label()
        Me.cbPagaduria = New System.Windows.Forms.ComboBox()
        Me.dgCriterios = New System.Windows.Forms.DataGridView()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbTipoEvaluacion = New System.Windows.Forms.ComboBox()
        Me.lblTipoEvaluación = New System.Windows.Forms.Label()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgCriterios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPagaduria
        '
        Me.lblPagaduria.AutoSize = True
        Me.lblPagaduria.Location = New System.Drawing.Point(3, 12)
        Me.lblPagaduria.Name = "lblPagaduria"
        Me.lblPagaduria.Size = New System.Drawing.Size(60, 13)
        Me.lblPagaduria.TabIndex = 0
        Me.lblPagaduria.Text = "Pagaduría:"
        '
        'cbPagaduria
        '
        Me.cbPagaduria.BackColor = System.Drawing.Color.White
        Me.cbPagaduria.DisplayMember = "Pagaduria"
        Me.cbPagaduria.FormattingEnabled = True
        Me.cbPagaduria.Location = New System.Drawing.Point(69, 12)
        Me.cbPagaduria.Name = "cbPagaduria"
        Me.cbPagaduria.Size = New System.Drawing.Size(616, 21)
        Me.cbPagaduria.TabIndex = 1
        Me.cbPagaduria.ValueMember = "CodPagaduria"
        '
        'dgCriterios
        '
        Me.dgCriterios.AllowUserToAddRows = False
        Me.dgCriterios.AllowUserToDeleteRows = False
        Me.dgCriterios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCriterios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCriterios.Location = New System.Drawing.Point(23, 143)
        Me.dgCriterios.Name = "dgCriterios"
        Me.dgCriterios.ReadOnly = True
        Me.dgCriterios.Size = New System.Drawing.Size(762, 263)
        Me.dgCriterios.TabIndex = 2
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.BackColor = System.Drawing.Color.Khaki
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.Maroon
        Me.lblCategoria.Location = New System.Drawing.Point(520, 45)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(0, 15)
        Me.lblCategoria.TabIndex = 5
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Location = New System.Drawing.Point(457, 48)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(57, 13)
        Me.lblCat.TabIndex = 6
        Me.lblCat.Text = "Categoría:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cbTipoEvaluacion)
        Me.Panel1.Controls.Add(Me.lblTipoEvaluación)
        Me.Panel1.Controls.Add(Me.lblCategoria)
        Me.Panel1.Controls.Add(Me.lblCat)
        Me.Panel1.Controls.Add(Me.lblPagaduria)
        Me.Panel1.Controls.Add(Me.cbPagaduria)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 74)
        Me.Panel1.TabIndex = 7
        '
        'cbTipoEvaluacion
        '
        Me.cbTipoEvaluacion.BackColor = System.Drawing.Color.White
        Me.cbTipoEvaluacion.DisplayMember = "Descripcion"
        Me.cbTipoEvaluacion.FormattingEnabled = True
        Me.cbTipoEvaluacion.Location = New System.Drawing.Point(105, 44)
        Me.cbTipoEvaluacion.Name = "cbTipoEvaluacion"
        Me.cbTipoEvaluacion.Size = New System.Drawing.Size(346, 21)
        Me.cbTipoEvaluacion.TabIndex = 8
        Me.cbTipoEvaluacion.ValueMember = "idTipoEval"
        '
        'lblTipoEvaluación
        '
        Me.lblTipoEvaluación.AutoSize = True
        Me.lblTipoEvaluación.Location = New System.Drawing.Point(3, 48)
        Me.lblTipoEvaluación.Name = "lblTipoEvaluación"
        Me.lblTipoEvaluación.Size = New System.Drawing.Size(102, 13)
        Me.lblTipoEvaluación.TabIndex = 7
        Me.lblTipoEvaluación.Text = "Tipo de Evaluación:"
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.BackColor = System.Drawing.Color.Khaki
        Me.lblPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentaje.ForeColor = System.Drawing.Color.Maroon
        Me.lblPorcentaje.Location = New System.Drawing.Point(637, 412)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(0, 16)
        Me.lblPorcentaje.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(570, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Porcentaje:"
        '
        'MetroButton4
        '
        Me.MetroButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroButton4.Location = New System.Drawing.Point(710, 412)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton4.TabIndex = 179
        Me.MetroButton4.Text = "Evaluar"
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'frmMEvaluarPagaduria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(808, 472)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPorcentaje)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgCriterios)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(808, 472)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(808, 472)
        Me.Name = "frmMEvaluarPagaduria"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Evaluar Pagaduría"
        CType(Me.dgCriterios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPagaduria As System.Windows.Forms.Label
    Friend WithEvents cbPagaduria As System.Windows.Forms.ComboBox
    Friend WithEvents dgCriterios As System.Windows.Forms.DataGridView
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblCat As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipoEvaluacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoEvaluación As System.Windows.Forms.Label
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
End Class
