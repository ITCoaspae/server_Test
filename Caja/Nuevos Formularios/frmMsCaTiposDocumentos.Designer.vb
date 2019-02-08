<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsCaTiposDocumentos
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
        Me.rbInactivo = New System.Windows.Forms.RadioButton()
        Me.rbActivo = New System.Windows.Forms.RadioButton()
        Me.txtAbrev = New System.Windows.Forms.TextBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblAbrev = New System.Windows.Forms.Label()
        Me.txtTipoDoc = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.rbInactivo)
        Me.Panel2.Controls.Add(Me.rbActivo)
        Me.Panel2.Controls.Add(Me.txtAbrev)
        Me.Panel2.Controls.Add(Me.lblTipoDoc)
        Me.Panel2.Controls.Add(Me.lblAbrev)
        Me.Panel2.Controls.Add(Me.txtTipoDoc)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.MaximumSize = New System.Drawing.Size(387, 64)
        Me.Panel2.MinimumSize = New System.Drawing.Size(387, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(387, 64)
        Me.Panel2.TabIndex = 161
        '
        'rbInactivo
        '
        Me.rbInactivo.AutoSize = True
        Me.rbInactivo.Location = New System.Drawing.Point(312, 38)
        Me.rbInactivo.Name = "rbInactivo"
        Me.rbInactivo.Size = New System.Drawing.Size(63, 17)
        Me.rbInactivo.TabIndex = 6
        Me.rbInactivo.Text = "Inactivo"
        Me.rbInactivo.UseVisualStyleBackColor = True
        '
        'rbActivo
        '
        Me.rbActivo.AutoSize = True
        Me.rbActivo.Checked = True
        Me.rbActivo.Location = New System.Drawing.Point(251, 38)
        Me.rbActivo.Name = "rbActivo"
        Me.rbActivo.Size = New System.Drawing.Size(55, 17)
        Me.rbActivo.TabIndex = 5
        Me.rbActivo.TabStop = True
        Me.rbActivo.Text = "Activo"
        Me.rbActivo.UseVisualStyleBackColor = True
        '
        'txtAbrev
        '
        Me.txtAbrev.BackColor = System.Drawing.Color.White
        Me.txtAbrev.Location = New System.Drawing.Point(74, 37)
        Me.txtAbrev.MaxLength = 1
        Me.txtAbrev.Name = "txtAbrev"
        Me.txtAbrev.Size = New System.Drawing.Size(116, 20)
        Me.txtAbrev.TabIndex = 4
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(3, 11)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(65, 13)
        Me.lblTipoDoc.TabIndex = 0
        Me.lblTipoDoc.Text = "Documento:"
        '
        'lblAbrev
        '
        Me.lblAbrev.AutoSize = True
        Me.lblAbrev.Location = New System.Drawing.Point(3, 37)
        Me.lblAbrev.Name = "lblAbrev"
        Me.lblAbrev.Size = New System.Drawing.Size(31, 13)
        Me.lblAbrev.TabIndex = 1
        Me.lblAbrev.Text = "Tipo:"
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.BackColor = System.Drawing.Color.White
        Me.txtTipoDoc.Location = New System.Drawing.Point(74, 8)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New System.Drawing.Size(302, 20)
        Me.txtTipoDoc.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(335, 133)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 177
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmMsCaTiposDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(486, 194)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(419, 181)
        Me.Name = "frmMsCaTiposDocumentos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Tipo de Documentos Caja"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents lblAbrev As System.Windows.Forms.Label
    Friend WithEvents txtTipoDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtAbrev As System.Windows.Forms.TextBox
    Friend WithEvents rbInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
End Class
