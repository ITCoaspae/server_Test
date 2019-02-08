<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMB_SolicitudesBoveda
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
        Me.dgBoveda = New System.Windows.Forms.DataGridView()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir = New MetroFramework.Controls.MetroButton()
        CType(Me.dgBoveda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgBoveda
        '
        Me.dgBoveda.AllowUserToAddRows = False
        Me.dgBoveda.AllowUserToDeleteRows = False
        Me.dgBoveda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgBoveda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBoveda.Location = New System.Drawing.Point(23, 97)
        Me.dgBoveda.Name = "dgBoveda"
        Me.dgBoveda.ReadOnly = True
        Me.dgBoveda.Size = New System.Drawing.Size(537, 141)
        Me.dgBoveda.TabIndex = 0
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(185, 63)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 165
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(347, 63)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 164
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 63)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 163
        Me.btnMod.Text = "Autorizar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(23, 63)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar.TabIndex = 162
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar.UseSelectable = True
        Me.btnAgregar.UseStyleColors = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(266, 63)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 28)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar.TabIndex = 166
        Me.btnModificar.Text = "Actualizar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar.UseSelectable = True
        Me.btnModificar.UseStyleColors = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(428, 63)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 28)
        Me.btnImprimir.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir.TabIndex = 167
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir.UseSelectable = True
        Me.btnImprimir.UseStyleColors = True
        '
        'frmMB_SolicitudesBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(583, 290)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgBoveda)
        Me.MinimumSize = New System.Drawing.Size(583, 290)
        Me.Name = "frmMB_SolicitudesBoveda"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Solicitudes Bóveda"
        CType(Me.dgBoveda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgBoveda As System.Windows.Forms.DataGridView
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir As MetroFramework.Controls.MetroButton
End Class
