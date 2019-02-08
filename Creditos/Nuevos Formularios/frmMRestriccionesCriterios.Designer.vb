<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRestriccionesCriterios
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
        Me.lblTipoEvaluacion = New System.Windows.Forms.Label()
        Me.cbTipoEvaluacion = New System.Windows.Forms.ComboBox()
        Me.cbCriterioPrincipal = New System.Windows.Forms.ComboBox()
        Me.lblCriterio = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgRestricciones = New System.Windows.Forms.DataGridView()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Panel2.SuspendLayout()
        CType(Me.dgRestricciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipoEvaluacion
        '
        Me.lblTipoEvaluacion.AutoSize = True
        Me.lblTipoEvaluacion.Location = New System.Drawing.Point(5, 10)
        Me.lblTipoEvaluacion.Name = "lblTipoEvaluacion"
        Me.lblTipoEvaluacion.Size = New System.Drawing.Size(102, 13)
        Me.lblTipoEvaluacion.TabIndex = 2
        Me.lblTipoEvaluacion.Text = "Tipo de Evaluación:"
        '
        'cbTipoEvaluacion
        '
        Me.cbTipoEvaluacion.BackColor = System.Drawing.Color.White
        Me.cbTipoEvaluacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoEvaluacion.FormattingEnabled = True
        Me.cbTipoEvaluacion.Location = New System.Drawing.Point(3, 26)
        Me.cbTipoEvaluacion.Name = "cbTipoEvaluacion"
        Me.cbTipoEvaluacion.Size = New System.Drawing.Size(456, 21)
        Me.cbTipoEvaluacion.TabIndex = 3
        '
        'cbCriterioPrincipal
        '
        Me.cbCriterioPrincipal.BackColor = System.Drawing.Color.White
        Me.cbCriterioPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCriterioPrincipal.FormattingEnabled = True
        Me.cbCriterioPrincipal.Location = New System.Drawing.Point(3, 66)
        Me.cbCriterioPrincipal.Name = "cbCriterioPrincipal"
        Me.cbCriterioPrincipal.Size = New System.Drawing.Size(456, 21)
        Me.cbCriterioPrincipal.TabIndex = 5
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(5, 50)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(152, 13)
        Me.lblCriterio.TabIndex = 4
        Me.lblCriterio.Text = "Seleccione el Criterio Principal:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbCriterioPrincipal)
        Me.Panel2.Controls.Add(Me.lblTipoEvaluacion)
        Me.Panel2.Controls.Add(Me.lblCriterio)
        Me.Panel2.Controls.Add(Me.cbTipoEvaluacion)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(481, 100)
        Me.Panel2.TabIndex = 6
        '
        'dgRestricciones
        '
        Me.dgRestricciones.AllowUserToAddRows = False
        Me.dgRestricciones.AllowUserToDeleteRows = False
        Me.dgRestricciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRestricciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRestricciones.Location = New System.Drawing.Point(26, 203)
        Me.dgRestricciones.Name = "dgRestricciones"
        Me.dgRestricciones.Size = New System.Drawing.Size(482, 206)
        Me.dgRestricciones.TabIndex = 8
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 169)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 179
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar1.Location = New System.Drawing.Point(430, 428)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 180
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMRestriccionesCriterios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(531, 466)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.dgRestricciones)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmMRestriccionesCriterios"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Validaciones Criterios de Evaluación"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgRestricciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTipoEvaluacion As System.Windows.Forms.Label
    Friend WithEvents cbTipoEvaluacion As System.Windows.Forms.ComboBox
    Friend WithEvents cbCriterioPrincipal As System.Windows.Forms.ComboBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgRestricciones As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
