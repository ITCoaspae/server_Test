<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsClasificacionPagaduria
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
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.txtDesde = New C1.Win.C1Input.C1TextBox()
        Me.txtHasta = New C1.Win.C1Input.C1TextBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblTipoEvaluacion = New System.Windows.Forms.Label()
        Me.cbTipoEvaluaciones = New System.Windows.Forms.ComboBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.White
        Me.txtCategoria.Location = New System.Drawing.Point(237, 51)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(52, 20)
        Me.txtCategoria.TabIndex = 3
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(163, 51)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(57, 13)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Categoría:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(75, 51)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(52, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "id:"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(10, 77)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(41, 13)
        Me.lblDesde.TabIndex = 4
        Me.lblDesde.Text = "Desde:"
        '
        'txtDesde
        '
        Me.txtDesde.BackColor = System.Drawing.Color.White
        Me.txtDesde.DataType = GetType(Decimal)
        Me.txtDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.txtDesde.Location = New System.Drawing.Point(75, 77)
        Me.txtDesde.MaxLength = 10000000
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.ParseInfo.NumberStyle = CType(((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtDesde.Size = New System.Drawing.Size(82, 20)
        Me.txtDesde.TabIndex = 5
        Me.txtDesde.Tag = Nothing
        Me.txtDesde.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtHasta
        '
        Me.txtHasta.BackColor = System.Drawing.Color.White
        Me.txtHasta.DataType = GetType(Decimal)
        Me.txtHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.txtHasta.Location = New System.Drawing.Point(207, 77)
        Me.txtHasta.MaxLength = 10000000
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.ParseInfo.NumberStyle = CType(((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtHasta.Size = New System.Drawing.Size(82, 20)
        Me.txtHasta.TabIndex = 7
        Me.txtHasta.Tag = Nothing
        Me.txtHasta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(163, 77)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblHasta.TabIndex = 6
        Me.lblHasta.Text = "Hasta:"
        '
        'lblTipoEvaluacion
        '
        Me.lblTipoEvaluacion.AutoSize = True
        Me.lblTipoEvaluacion.Location = New System.Drawing.Point(12, 98)
        Me.lblTipoEvaluacion.Name = "lblTipoEvaluacion"
        Me.lblTipoEvaluacion.Size = New System.Drawing.Size(63, 26)
        Me.lblTipoEvaluacion.TabIndex = 8
        Me.lblTipoEvaluacion.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Evaluación:"
        '
        'cbTipoEvaluaciones
        '
        Me.cbTipoEvaluaciones.BackColor = System.Drawing.Color.White
        Me.cbTipoEvaluaciones.DisplayMember = "Descripcion"
        Me.cbTipoEvaluaciones.FormattingEnabled = True
        Me.cbTipoEvaluaciones.Location = New System.Drawing.Point(75, 103)
        Me.cbTipoEvaluaciones.Name = "cbTipoEvaluaciones"
        Me.cbTipoEvaluaciones.Size = New System.Drawing.Size(214, 21)
        Me.cbTipoEvaluaciones.TabIndex = 9
        Me.cbTipoEvaluaciones.ValueMember = "idTipoEval"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(15, 129)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 186
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsClasificacionPagaduria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(305, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.cbTipoEvaluaciones)
        Me.Controls.Add(Me.lblTipoEvaluacion)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMsClasificacionPagaduria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación Pagadurías"
        CType(Me.txtDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHasta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents txtDesde As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtHasta As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblTipoEvaluacion As System.Windows.Forms.Label
    Friend WithEvents cbTipoEvaluaciones As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
