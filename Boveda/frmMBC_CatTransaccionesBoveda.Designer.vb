<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMBC_CatTransaccionesBoveda
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
        Me.dgTransaccionesBoveda = New System.Windows.Forms.DataGridView()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.txtCodTransaccion = New System.Windows.Forms.TextBox()
        Me.rbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.rbCodTransaccion = New System.Windows.Forms.RadioButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgTransaccionesBoveda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgTransaccionesBoveda
        '
        Me.dgTransaccionesBoveda.AllowUserToAddRows = False
        Me.dgTransaccionesBoveda.AllowUserToDeleteRows = False
        Me.dgTransaccionesBoveda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTransaccionesBoveda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransaccionesBoveda.Location = New System.Drawing.Point(23, 156)
        Me.dgTransaccionesBoveda.Name = "dgTransaccionesBoveda"
        Me.dgTransaccionesBoveda.ReadOnly = True
        Me.dgTransaccionesBoveda.Size = New System.Drawing.Size(490, 104)
        Me.dgTransaccionesBoveda.TabIndex = 0
        '
        'gbFiltros
        '
        Me.gbFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltros.BackColor = System.Drawing.Color.White
        Me.gbFiltros.Controls.Add(Me.MetroButton3)
        Me.gbFiltros.Controls.Add(Me.txtCodTransaccion)
        Me.gbFiltros.Controls.Add(Me.rbMostrarTodos)
        Me.gbFiltros.Controls.Add(Me.rbCodTransaccion)
        Me.gbFiltros.Location = New System.Drawing.Point(23, 63)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(490, 53)
        Me.gbFiltros.TabIndex = 160
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros"
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(385, 19)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 172
        Me.MetroButton3.Text = "Buscar"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'txtCodTransaccion
        '
        Me.txtCodTransaccion.Location = New System.Drawing.Point(150, 20)
        Me.txtCodTransaccion.Name = "txtCodTransaccion"
        Me.txtCodTransaccion.Size = New System.Drawing.Size(121, 20)
        Me.txtCodTransaccion.TabIndex = 8
        '
        'rbMostrarTodos
        '
        Me.rbMostrarTodos.AutoSize = True
        Me.rbMostrarTodos.Location = New System.Drawing.Point(283, 21)
        Me.rbMostrarTodos.Name = "rbMostrarTodos"
        Me.rbMostrarTodos.Size = New System.Drawing.Size(96, 17)
        Me.rbMostrarTodos.TabIndex = 6
        Me.rbMostrarTodos.TabStop = True
        Me.rbMostrarTodos.Text = "Mostrar Todos:"
        Me.rbMostrarTodos.UseVisualStyleBackColor = True
        '
        'rbCodTransaccion
        '
        Me.rbCodTransaccion.AutoSize = True
        Me.rbCodTransaccion.Location = New System.Drawing.Point(6, 20)
        Me.rbCodTransaccion.Name = "rbCodTransaccion"
        Me.rbCodTransaccion.Size = New System.Drawing.Size(138, 17)
        Me.rbCodTransaccion.TabIndex = 4
        Me.rbCodTransaccion.TabStop = True
        Me.rbCodTransaccion.Text = "Codigo de Transaccion:"
        Me.rbCodTransaccion.UseVisualStyleBackColor = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(104, 122)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 173
        Me.MetroButton1.Text = "Actualizar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 122)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 172
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(23, 122)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 171
        Me.MetroButton2.Text = "Agregar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'frmMBC_CatTransaccionesBoveda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(536, 324)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.dgTransaccionesBoveda)
        Me.Controls.Add(Me.gbFiltros)
        Me.MinimumSize = New System.Drawing.Size(536, 324)
        Me.Name = "frmMBC_CatTransaccionesBoveda"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Catalogo de Transacciones Boveda"
        CType(Me.dgTransaccionesBoveda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTransaccionesBoveda As System.Windows.Forms.DataGridView
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodTransaccion As System.Windows.Forms.TextBox
    Friend WithEvents rbMostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodTransaccion As System.Windows.Forms.RadioButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
