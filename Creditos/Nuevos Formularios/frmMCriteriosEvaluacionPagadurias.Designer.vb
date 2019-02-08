<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCriteriosEvaluacionPagadurias
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
        Me.dgCriterios = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.cbTipoEvaluacion = New System.Windows.Forms.ComboBox()
        Me.lblTipoEvaluación = New System.Windows.Forms.Label()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnGenerar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgCriterios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgCriterios
        '
        Me.dgCriterios.AllowUserToAddRows = False
        Me.dgCriterios.AllowUserToDeleteRows = False
        Me.dgCriterios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCriterios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCriterios.Location = New System.Drawing.Point(23, 164)
        Me.dgCriterios.Name = "dgCriterios"
        Me.dgCriterios.ReadOnly = True
        Me.dgCriterios.Size = New System.Drawing.Size(542, 175)
        Me.dgCriterios.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MetroButton4)
        Me.Panel2.Controls.Add(Me.cbTipoEvaluacion)
        Me.Panel2.Controls.Add(Me.lblTipoEvaluación)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 61)
        Me.Panel2.TabIndex = 43
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(6, 27)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton4.TabIndex = 178
        Me.MetroButton4.Text = "Mostrar"
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'cbTipoEvaluacion
        '
        Me.cbTipoEvaluacion.BackColor = System.Drawing.Color.White
        Me.cbTipoEvaluacion.DisplayMember = "Descripcion"
        Me.cbTipoEvaluacion.FormattingEnabled = True
        Me.cbTipoEvaluacion.Location = New System.Drawing.Point(111, 8)
        Me.cbTipoEvaluacion.Name = "cbTipoEvaluacion"
        Me.cbTipoEvaluacion.Size = New System.Drawing.Size(346, 21)
        Me.cbTipoEvaluacion.TabIndex = 10
        Me.cbTipoEvaluacion.ValueMember = "idTipoEval"
        '
        'lblTipoEvaluación
        '
        Me.lblTipoEvaluación.AutoSize = True
        Me.lblTipoEvaluación.Location = New System.Drawing.Point(3, 11)
        Me.lblTipoEvaluación.Name = "lblTipoEvaluación"
        Me.lblTipoEvaluación.Size = New System.Drawing.Size(102, 13)
        Me.lblTipoEvaluación.TabIndex = 9
        Me.lblTipoEvaluación.Text = "Tipo de Evaluación:"
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(267, 130)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 177
        Me.MetroButton3.Text = "Eliminar"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(186, 130)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 176
        Me.MetroButton2.Text = "Consultar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(105, 130)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 175
        Me.MetroButton1.Text = "Modificar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnGenerar1
        '
        Me.btnGenerar1.Location = New System.Drawing.Point(24, 130)
        Me.btnGenerar1.Name = "btnGenerar1"
        Me.btnGenerar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGenerar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGenerar1.TabIndex = 174
        Me.btnGenerar1.Text = "Agregar"
        Me.btnGenerar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGenerar1.UseSelectable = True
        Me.btnGenerar1.UseStyleColors = True
        '
        'frmMCriteriosEvaluacionPagadurias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(588, 380)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnGenerar1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgCriterios)
        Me.Name = "frmMCriteriosEvaluacionPagadurias"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Criterios de evaluación pagadurías"
        CType(Me.dgCriterios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgCriterios As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbTipoEvaluacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoEvaluación As System.Windows.Forms.Label
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGenerar1 As MetroFramework.Controls.MetroButton
End Class
