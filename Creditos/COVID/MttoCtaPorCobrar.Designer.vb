<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MttoCtaPorCobrar
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbTodos = New MetroFramework.Controls.MetroRadioButton()
        Me.txtDui = New System.Windows.Forms.MaskedTextBox()
        Me.rbDUI = New MetroFramework.Controls.MetroRadioButton()
        Me.btnMostrar = New MetroFramework.Controls.MetroButton()
        Me.btnAnular = New MetroFramework.Controls.MetroButton()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(393, 88)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(60, 17)
        Me.rbTodos.TabIndex = 196
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseSelectable = True
        '
        'txtDui
        '
        Me.txtDui.Enabled = False
        Me.txtDui.Location = New System.Drawing.Point(87, 88)
        Me.txtDui.Mask = "00000000-0"
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(291, 22)
        Me.txtDui.TabIndex = 194
        '
        'rbDUI
        '
        Me.rbDUI.AutoSize = True
        Me.rbDUI.Location = New System.Drawing.Point(23, 88)
        Me.rbDUI.Name = "rbDUI"
        Me.rbDUI.Size = New System.Drawing.Size(48, 17)
        Me.rbDUI.TabIndex = 192
        Me.rbDUI.Text = "DUI:"
        Me.rbDUI.UseSelectable = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(460, 81)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(100, 34)
        Me.btnMostrar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar.TabIndex = 200
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar.UseSelectable = True
        Me.btnMostrar.UseStyleColors = True
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(239, 138)
        Me.btnAnular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(100, 34)
        Me.btnAnular.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAnular.TabIndex = 199
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAnular.UseSelectable = True
        Me.btnAnular.UseStyleColors = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(131, 138)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 34)
        Me.btnUpdate.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnUpdate.TabIndex = 198
        Me.btnUpdate.Text = "Consultar"
        Me.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnUpdate.UseSelectable = True
        Me.btnUpdate.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 138)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 34)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 197
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(546, 174)
        Me.DataGridView1.TabIndex = 201
        '
        'MttoCtaPorCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 417)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.rbDUI)
        Me.Name = "MttoCtaPorCobrar"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "MttoCtaPorCobrar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbTodos As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents txtDui As MaskedTextBox
    Friend WithEvents rbDUI As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents btnMostrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAnular As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
End Class
