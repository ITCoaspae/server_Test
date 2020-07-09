<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsJuntaDirectivaActEco
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreDir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardarDom = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkActivo)
        Me.Panel1.Controls.Add(Me.txtCargo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNombreDir)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(31, 78)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 111)
        Me.Panel1.TabIndex = 163
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(8, 86)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(68, 21)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.White
        Me.txtCargo.Location = New System.Drawing.Point(81, 54)
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(448, 22)
        Me.txtCargo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cargo:"
        '
        'txtNombreDir
        '
        Me.txtNombreDir.BackColor = System.Drawing.Color.White
        Me.txtNombreDir.Location = New System.Drawing.Point(81, 14)
        Me.txtNombreDir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreDir.Name = "txtNombreDir"
        Me.txtNombreDir.Size = New System.Drawing.Size(448, 22)
        Me.txtNombreDir.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Directivo:"
        '
        'btnGuardarDom
        '
        Me.btnGuardarDom.Location = New System.Drawing.Point(481, 196)
        Me.btnGuardarDom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardarDom.Name = "btnGuardarDom"
        Me.btnGuardarDom.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardarDom.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardarDom.TabIndex = 165
        Me.btnGuardarDom.Text = "Guardar"
        Me.btnGuardarDom.UseSelectable = True
        Me.btnGuardarDom.UseStyleColors = True
        '
        'frmMsJuntaDirectivaActEco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(609, 242)
        Me.Controls.Add(Me.btnGuardarDom)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(609, 242)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(609, 242)
        Me.Name = "frmMsJuntaDirectivaActEco"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Junta Directiva"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreDir As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardarDom As MetroFramework.Controls.MetroButton
End Class
