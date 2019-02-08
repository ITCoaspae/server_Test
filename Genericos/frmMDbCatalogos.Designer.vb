<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDbCatalogos
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
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.rbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.rbTransacciones = New System.Windows.Forms.RadioButton()
        Me.cbCatalogo = New System.Windows.Forms.ComboBox()
        Me.dgCat = New System.Windows.Forms.DataGridView()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFiltros
        '
        Me.gbFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltros.BackColor = System.Drawing.Color.White
        Me.gbFiltros.Controls.Add(Me.MetroButton1)
        Me.gbFiltros.Controls.Add(Me.rbMostrarTodos)
        Me.gbFiltros.Controls.Add(Me.rbTransacciones)
        Me.gbFiltros.Controls.Add(Me.cbCatalogo)
        Me.gbFiltros.Location = New System.Drawing.Point(23, 63)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(526, 83)
        Me.gbFiltros.TabIndex = 165
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(434, 42)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 170
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'rbMostrarTodos
        '
        Me.rbMostrarTodos.AutoSize = True
        Me.rbMostrarTodos.Location = New System.Drawing.Point(16, 42)
        Me.rbMostrarTodos.Name = "rbMostrarTodos"
        Me.rbMostrarTodos.Size = New System.Drawing.Size(96, 17)
        Me.rbMostrarTodos.TabIndex = 9
        Me.rbMostrarTodos.Text = "Mostrar Todos:"
        Me.rbMostrarTodos.UseVisualStyleBackColor = True
        '
        'rbTransacciones
        '
        Me.rbTransacciones.AutoSize = True
        Me.rbTransacciones.Checked = True
        Me.rbTransacciones.Location = New System.Drawing.Point(16, 19)
        Me.rbTransacciones.Name = "rbTransacciones"
        Me.rbTransacciones.Size = New System.Drawing.Size(129, 17)
        Me.rbTransacciones.TabIndex = 6
        Me.rbTransacciones.TabStop = True
        Me.rbTransacciones.Text = "Seleccionar Catalogo:"
        Me.rbTransacciones.UseVisualStyleBackColor = True
        '
        'cbCatalogo
        '
        Me.cbCatalogo.BackColor = System.Drawing.Color.White
        Me.cbCatalogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCatalogo.FormattingEnabled = True
        Me.cbCatalogo.Location = New System.Drawing.Point(146, 15)
        Me.cbCatalogo.Name = "cbCatalogo"
        Me.cbCatalogo.Size = New System.Drawing.Size(363, 21)
        Me.cbCatalogo.TabIndex = 5
        '
        'dgCat
        '
        Me.dgCat.AllowUserToAddRows = False
        Me.dgCat.AllowUserToDeleteRows = False
        Me.dgCat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCat.Location = New System.Drawing.Point(23, 195)
        Me.dgCat.Name = "dgCat"
        Me.dgCat.ReadOnly = True
        Me.dgCat.Size = New System.Drawing.Size(526, 180)
        Me.dgCat.TabIndex = 166
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 152)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 169
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 152)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 168
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMDbCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(572, 421)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgCat)
        Me.Controls.Add(Me.gbFiltros)
        Me.Name = "frmMDbCatalogos"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Maestro de Catalogos"
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.dgCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents rbMostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbTransacciones As System.Windows.Forms.RadioButton
    Friend WithEvents cbCatalogo As System.Windows.Forms.ComboBox
    Friend WithEvents dgCat As System.Windows.Forms.DataGridView
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
