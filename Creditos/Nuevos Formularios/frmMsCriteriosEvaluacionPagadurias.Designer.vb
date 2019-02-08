<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsCriteriosEvaluacionPagadurias
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
        Me.txtCriterio = New System.Windows.Forms.TextBox()
        Me.lblCriterio = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New C1.Win.C1Input.C1TextBox()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblTipoEvaluacion = New System.Windows.Forms.Label()
        Me.cbTipoEvaluacion = New System.Windows.Forms.ComboBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCriterio
        '
        Me.txtCriterio.BackColor = System.Drawing.Color.White
        Me.txtCriterio.Location = New System.Drawing.Point(80, 83)
        Me.txtCriterio.Multiline = True
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(399, 49)
        Me.txtCriterio.TabIndex = 18
        '
        'lblCriterio
        '
        Me.lblCriterio.AutoSize = True
        Me.lblCriterio.Location = New System.Drawing.Point(23, 86)
        Me.lblCriterio.Name = "lblCriterio"
        Me.lblCriterio.Size = New System.Drawing.Size(42, 13)
        Me.lblCriterio.TabIndex = 17
        Me.lblCriterio.Text = "Criterio:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(80, 57)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(52, 20)
        Me.txtCodigo.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "id:"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.BackColor = System.Drawing.Color.White
        Me.txtPorcentaje.DataType = GetType(Decimal)
        Me.txtPorcentaje.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.txtPorcentaje.Location = New System.Drawing.Point(80, 138)
        Me.txtPorcentaje.MaxLength = 10000000
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.ParseInfo.NumberStyle = CType(((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtPorcentaje.Size = New System.Drawing.Size(82, 20)
        Me.txtPorcentaje.TabIndex = 22
        Me.txtPorcentaje.Tag = Nothing
        Me.txtPorcentaje.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(17, 138)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(61, 13)
        Me.lblDesde.TabIndex = 21
        Me.lblDesde.Text = "Porcentaje:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(138, 59)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 23
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblTipoEvaluacion
        '
        Me.lblTipoEvaluacion.AutoSize = True
        Me.lblTipoEvaluacion.Location = New System.Drawing.Point(168, 138)
        Me.lblTipoEvaluacion.Name = "lblTipoEvaluacion"
        Me.lblTipoEvaluacion.Size = New System.Drawing.Size(60, 26)
        Me.lblTipoEvaluacion.TabIndex = 24
        Me.lblTipoEvaluacion.Text = "Tipo de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Evaluación"
        '
        'cbTipoEvaluacion
        '
        Me.cbTipoEvaluacion.BackColor = System.Drawing.Color.White
        Me.cbTipoEvaluacion.DisplayMember = "Descripcion"
        Me.cbTipoEvaluacion.FormattingEnabled = True
        Me.cbTipoEvaluacion.Location = New System.Drawing.Point(234, 143)
        Me.cbTipoEvaluacion.Name = "cbTipoEvaluacion"
        Me.cbTipoEvaluacion.Size = New System.Drawing.Size(245, 21)
        Me.cbTipoEvaluacion.TabIndex = 25
        Me.cbTipoEvaluacion.ValueMember = "idTipoEval"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(404, 170)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 187
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCriteriosEvaluacionPagadurias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(502, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.cbTipoEvaluacion)
        Me.Controls.Add(Me.lblTipoEvaluacion)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.txtCriterio)
        Me.Controls.Add(Me.lblCriterio)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.MaximumSize = New System.Drawing.Size(502, 221)
        Me.MinimumSize = New System.Drawing.Size(502, 221)
        Me.Name = "frmMsCriteriosEvaluacionPagadurias"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Criterios de evaluación"
        CType(Me.txtPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentaje As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblTipoEvaluacion As System.Windows.Forms.Label
    Friend WithEvents cbTipoEvaluacion As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
