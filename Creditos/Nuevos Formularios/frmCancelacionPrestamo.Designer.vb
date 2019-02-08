<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelacionPrestamo
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
        Me.lblAsociado = New System.Windows.Forms.Label()
        Me.lblCodPrestamo = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.lblMotivoCan = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAsociado
        '
        Me.lblAsociado.AutoSize = True
        Me.lblAsociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsociado.ForeColor = System.Drawing.Color.Teal
        Me.lblAsociado.Location = New System.Drawing.Point(23, 60)
        Me.lblAsociado.Name = "lblAsociado"
        Me.lblAsociado.Size = New System.Drawing.Size(106, 13)
        Me.lblAsociado.TabIndex = 0
        Me.lblAsociado.Text = "Nombre Asociado"
        '
        'lblCodPrestamo
        '
        Me.lblCodPrestamo.AutoSize = True
        Me.lblCodPrestamo.Location = New System.Drawing.Point(23, 85)
        Me.lblCodPrestamo.Name = "lblCodPrestamo"
        Me.lblCodPrestamo.Size = New System.Drawing.Size(90, 13)
        Me.lblCodPrestamo.TabIndex = 1
        Me.lblCodPrestamo.Text = "Código Préstamo:"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BackColor = System.Drawing.Color.White
        Me.txtCodPrestamo.ForeColor = System.Drawing.Color.Maroon
        Me.txtCodPrestamo.Location = New System.Drawing.Point(119, 82)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.ReadOnly = True
        Me.txtCodPrestamo.Size = New System.Drawing.Size(210, 20)
        Me.txtCodPrestamo.TabIndex = 2
        '
        'lblMotivoCan
        '
        Me.lblMotivoCan.AutoSize = True
        Me.lblMotivoCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivoCan.ForeColor = System.Drawing.Color.Teal
        Me.lblMotivoCan.Location = New System.Drawing.Point(20, 199)
        Me.lblMotivoCan.Name = "lblMotivoCan"
        Me.lblMotivoCan.Size = New System.Drawing.Size(182, 17)
        Me.lblMotivoCan.TabIndex = 3
        Me.lblMotivoCan.Text = "Causas de Cancelación:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 219)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(527, 184)
        Me.DataGridView1.TabIndex = 4
        '
        'lblObservacion
        '
        Me.lblObservacion.AutoSize = True
        Me.lblObservacion.Location = New System.Drawing.Point(23, 116)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(70, 13)
        Me.lblObservacion.TabIndex = 157
        Me.lblObservacion.Text = "Observación:"
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.White
        Me.txtObservacion.Location = New System.Drawing.Point(23, 132)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ReadOnly = True
        Me.txtObservacion.Size = New System.Drawing.Size(527, 64)
        Me.txtObservacion.TabIndex = 158
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(475, 414)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 163
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmCancelacionPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(573, 472)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblObservacion)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblMotivoCan)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.lblCodPrestamo)
        Me.Controls.Add(Me.lblAsociado)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(573, 472)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(573, 472)
        Me.Name = "frmCancelacionPrestamo"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cancelación de Préstamos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAsociado As System.Windows.Forms.Label
    Friend WithEvents lblCodPrestamo As System.Windows.Forms.Label
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents lblMotivoCan As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblObservacion As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
