<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsCaTipoMovCaja
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
        Me.cbTransacciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipoMov = New System.Windows.Forms.TextBox()
        Me.lblTipoMov = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cbTransacciones)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtTipoMov)
        Me.Panel2.Controls.Add(Me.lblTipoMov)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(476, 62)
        Me.Panel2.TabIndex = 161
        '
        'cbTransacciones
        '
        Me.cbTransacciones.BackColor = System.Drawing.Color.White
        Me.cbTransacciones.FormattingEnabled = True
        Me.cbTransacciones.Location = New System.Drawing.Point(157, 33)
        Me.cbTransacciones.Name = "cbTransacciones"
        Me.cbTransacciones.Size = New System.Drawing.Size(305, 21)
        Me.cbTransacciones.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo de Transacción Bóveda:"
        '
        'txtTipoMov
        '
        Me.txtTipoMov.BackColor = System.Drawing.Color.White
        Me.txtTipoMov.Location = New System.Drawing.Point(157, 7)
        Me.txtTipoMov.Name = "txtTipoMov"
        Me.txtTipoMov.Size = New System.Drawing.Size(305, 20)
        Me.txtTipoMov.TabIndex = 1
        '
        'lblTipoMov
        '
        Me.lblTipoMov.AutoSize = True
        Me.lblTipoMov.Location = New System.Drawing.Point(3, 10)
        Me.lblTipoMov.Name = "lblTipoMov"
        Me.lblTipoMov.Size = New System.Drawing.Size(102, 13)
        Me.lblTipoMov.TabIndex = 0
        Me.lblTipoMov.Text = "Tipo de movimiento:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(424, 131)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 176
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmMsCaTipoMovCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(520, 201)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 201)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(520, 201)
        Me.Name = "frmMsCaTipoMovCaja"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Catalogo Tipo de Movimientos Caja"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipoMov As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoMov As System.Windows.Forms.Label
    Friend WithEvents cbTransacciones As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
End Class
