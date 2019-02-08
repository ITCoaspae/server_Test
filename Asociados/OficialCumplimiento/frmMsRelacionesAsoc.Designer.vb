<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMsRelacionesAsoc
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDui = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.lblParentesco = New System.Windows.Forms.Label()
        Me.cbRelaciones = New System.Windows.Forms.ComboBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.btnGuardarDom = New MetroFramework.Controls.MetroButton()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDui
        '
        Me.lblDui.AutoSize = True
        Me.lblDui.Location = New System.Drawing.Point(23, 60)
        Me.lblDui.Name = "lblDui"
        Me.lblDui.Size = New System.Drawing.Size(29, 13)
        Me.lblDui.TabIndex = 0
        Me.lblDui.Text = "DUI:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(23, 93)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.Enabled = False
        Me.txtAsociado.Location = New System.Drawing.Point(93, 90)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.Size = New System.Drawing.Size(276, 20)
        Me.txtAsociado.TabIndex = 3
        '
        'lblParentesco
        '
        Me.lblParentesco.AutoSize = True
        Me.lblParentesco.Location = New System.Drawing.Point(23, 124)
        Me.lblParentesco.Name = "lblParentesco"
        Me.lblParentesco.Size = New System.Drawing.Size(64, 13)
        Me.lblParentesco.TabIndex = 4
        Me.lblParentesco.Text = "Parentesco:"
        '
        'cbRelaciones
        '
        Me.cbRelaciones.FormattingEnabled = True
        Me.cbRelaciones.Location = New System.Drawing.Point(93, 116)
        Me.cbRelaciones.Name = "cbRelaciones"
        Me.cbRelaciones.Size = New System.Drawing.Size(276, 21)
        Me.cbRelaciones.TabIndex = 5
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(93, 60)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(96, 20)
        Me.txtDui.TabIndex = 163
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'btnGuardarDom
        '
        Me.btnGuardarDom.Location = New System.Drawing.Point(294, 143)
        Me.btnGuardarDom.Name = "btnGuardarDom"
        Me.btnGuardarDom.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardarDom.TabIndex = 164
        Me.btnGuardarDom.Text = "Guardar"
        Me.btnGuardarDom.UseSelectable = True
        Me.btnGuardarDom.UseStyleColors = True
        '
        'frmMsRelacionesAsoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 189)
        Me.Controls.Add(Me.btnGuardarDom)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.cbRelaciones)
        Me.Controls.Add(Me.lblParentesco)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblDui)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(389, 189)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(389, 189)
        Me.Name = "frmMsRelacionesAsoc"
        Me.Text = "Relaciones Asociados"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDui As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents lblParentesco As System.Windows.Forms.Label
    Friend WithEvents cbRelaciones As System.Windows.Forms.ComboBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnGuardarDom As MetroFramework.Controls.MetroButton
End Class
