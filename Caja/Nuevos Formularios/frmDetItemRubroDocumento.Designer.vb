<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetItemRubroDocumento
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdRubro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbItems = New System.Windows.Forms.ComboBox()
        Me.cbRubros = New System.Windows.Forms.ComboBox()
        Me.cbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id.:"
        '
        'txtIdRubro
        '
        Me.txtIdRubro.Location = New System.Drawing.Point(125, 63)
        Me.txtIdRubro.Name = "txtIdRubro"
        Me.txtIdRubro.Size = New System.Drawing.Size(100, 20)
        Me.txtIdRubro.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(276, 190)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 70
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Rubro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Tipo Documento:"
        '
        'cbItems
        '
        Me.cbItems.BackColor = System.Drawing.Color.White
        Me.cbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbItems.FormattingEnabled = True
        Me.cbItems.Location = New System.Drawing.Point(126, 92)
        Me.cbItems.Name = "cbItems"
        Me.cbItems.Size = New System.Drawing.Size(228, 21)
        Me.cbItems.TabIndex = 73
        '
        'cbRubros
        '
        Me.cbRubros.BackColor = System.Drawing.Color.White
        Me.cbRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRubros.FormattingEnabled = True
        Me.cbRubros.Location = New System.Drawing.Point(125, 122)
        Me.cbRubros.Name = "cbRubros"
        Me.cbRubros.Size = New System.Drawing.Size(228, 21)
        Me.cbRubros.TabIndex = 74
        '
        'cbTipoDocumento
        '
        Me.cbTipoDocumento.BackColor = System.Drawing.Color.White
        Me.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDocumento.FormattingEnabled = True
        Me.cbTipoDocumento.Location = New System.Drawing.Point(125, 158)
        Me.cbTipoDocumento.Name = "cbTipoDocumento"
        Me.cbTipoDocumento.Size = New System.Drawing.Size(228, 21)
        Me.cbTipoDocumento.TabIndex = 75
        '
        'frmDetItemRubroDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(376, 230)
        Me.Controls.Add(Me.cbTipoDocumento)
        Me.Controls.Add(Me.cbRubros)
        Me.Controls.Add(Me.cbItems)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdRubro)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(376, 230)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(376, 211)
        Me.Name = "frmDetItemRubroDocumento"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Rubros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdRubro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbItems As ComboBox
    Friend WithEvents cbRubros As ComboBox
    Friend WithEvents cbTipoDocumento As ComboBox
End Class
