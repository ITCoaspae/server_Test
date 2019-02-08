<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsBC_CatTransaccionesBoveda
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
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPrefijo = New System.Windows.Forms.TextBox()
        Me.lblPrefijo = New System.Windows.Forms.Label()
        Me.cbTipoMov = New System.Windows.Forms.ComboBox()
        Me.lblTipoMov = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(9, 9)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(81, 6)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(352, 49)
        Me.txtDescripcion.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtPrefijo)
        Me.Panel2.Controls.Add(Me.lblPrefijo)
        Me.Panel2.Controls.Add(Me.cbTipoMov)
        Me.Panel2.Controls.Add(Me.lblTipoMov)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.lblDescripcion)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(444, 108)
        Me.Panel2.TabIndex = 155
        '
        'txtPrefijo
        '
        Me.txtPrefijo.Location = New System.Drawing.Point(375, 71)
        Me.txtPrefijo.MaxLength = 2
        Me.txtPrefijo.Name = "txtPrefijo"
        Me.txtPrefijo.Size = New System.Drawing.Size(58, 20)
        Me.txtPrefijo.TabIndex = 5
        '
        'lblPrefijo
        '
        Me.lblPrefijo.AutoSize = True
        Me.lblPrefijo.Location = New System.Drawing.Point(330, 74)
        Me.lblPrefijo.Name = "lblPrefijo"
        Me.lblPrefijo.Size = New System.Drawing.Size(39, 13)
        Me.lblPrefijo.TabIndex = 4
        Me.lblPrefijo.Text = "Prefijo:"
        '
        'cbTipoMov
        '
        Me.cbTipoMov.FormattingEnabled = True
        Me.cbTipoMov.Items.AddRange(New Object() {"Abono", "Cargo"})
        Me.cbTipoMov.Location = New System.Drawing.Point(81, 71)
        Me.cbTipoMov.Name = "cbTipoMov"
        Me.cbTipoMov.Size = New System.Drawing.Size(165, 21)
        Me.cbTipoMov.TabIndex = 3
        '
        'lblTipoMov
        '
        Me.lblTipoMov.AutoSize = True
        Me.lblTipoMov.Location = New System.Drawing.Point(9, 71)
        Me.lblTipoMov.Name = "lblTipoMov"
        Me.lblTipoMov.Size = New System.Drawing.Size(64, 26)
        Me.lblTipoMov.TabIndex = 2
        Me.lblTipoMov.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Movimiento:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(392, 177)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 182
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmMsBC_CatTransaccionesBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(489, 225)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(16, 181)
        Me.Name = "frmMsBC_CatTransaccionesBoveda"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tipos de Movimientos Boveda"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtPrefijo As System.Windows.Forms.TextBox
    Friend WithEvents lblPrefijo As System.Windows.Forms.Label
    Friend WithEvents cbTipoMov As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoMov As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
End Class
