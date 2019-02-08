<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsDbCatalogos
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
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.cbCatalogo = New System.Windows.Forms.ComboBox()
        Me.lblCatalogo = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtOpcion
        '
        Me.txtOpcion.BackColor = System.Drawing.Color.White
        Me.txtOpcion.Location = New System.Drawing.Point(78, 84)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(371, 20)
        Me.txtOpcion.TabIndex = 8
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(23, 87)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(44, 13)
        Me.lblItem.TabIndex = 7
        Me.lblItem.Text = "Opción:"
        '
        'cbCatalogo
        '
        Me.cbCatalogo.BackColor = System.Drawing.Color.White
        Me.cbCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCatalogo.FormattingEnabled = True
        Me.cbCatalogo.Location = New System.Drawing.Point(78, 57)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Size = New System.Drawing.Size(371, 21)
        Me.cbCatalogo.TabIndex = 6
        '
        'lblCatalogo
        '
        Me.lblCatalogo.AutoSize = True
        Me.lblCatalogo.Location = New System.Drawing.Point(23, 60)
        Me.lblCatalogo.Name = "lblCatalogo"
        Me.lblCatalogo.Size = New System.Drawing.Size(49, 13)
        Me.lblCatalogo.TabIndex = 0
        Me.lblCatalogo.Text = "Catalogo"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(374, 110)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 162
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsDbCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(472, 159)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.txtOpcion)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.cbCatalogo)
        Me.Controls.Add(Me.lblCatalogo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(472, 159)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(472, 159)
        Me.Name = "frmMsDbCatalogos"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Maestro de Catalogos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCatalogo As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents cbCatalogo As System.Windows.Forms.ComboBox
    Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
