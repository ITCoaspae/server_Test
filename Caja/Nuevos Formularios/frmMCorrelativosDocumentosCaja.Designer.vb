<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCorrelativosDocumentosCaja
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
        Me.dgCorrCaja = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.chkMostrarTodos = New System.Windows.Forms.CheckBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.cbSucursales = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        CType(Me.dgCorrCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgCorrCaja
        '
        Me.dgCorrCaja.AllowUserToAddRows = False
        Me.dgCorrCaja.AllowUserToDeleteRows = False
        Me.dgCorrCaja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCorrCaja.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgCorrCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCorrCaja.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgCorrCaja.Location = New System.Drawing.Point(30, 268)
        Me.dgCorrCaja.Margin = New System.Windows.Forms.Padding(4)
        Me.dgCorrCaja.Name = "dgCorrCaja"
        Me.dgCorrCaja.ReadOnly = True
        Me.dgCorrCaja.Size = New System.Drawing.Size(501, 118)
        Me.dgCorrCaja.TabIndex = 161
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscar.Location = New System.Drawing.Point(358, 82)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(128, 34)
        Me.btnBuscar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar.TabIndex = 168
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnBuscar.UseCustomBackColor = True
        Me.btnBuscar.UseSelectable = True
        Me.btnBuscar.UseStyleColors = True
        '
        'chkMostrarTodos
        '
        Me.chkMostrarTodos.AutoSize = True
        Me.chkMostrarTodos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chkMostrarTodos.Location = New System.Drawing.Point(365, 21)
        Me.chkMostrarTodos.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMostrarTodos.Name = "chkMostrarTodos"
        Me.chkMostrarTodos.Size = New System.Drawing.Size(122, 21)
        Me.chkMostrarTodos.TabIndex = 11
        Me.chkMostrarTodos.Text = "Mostrar Todos"
        Me.chkMostrarTodos.UseVisualStyleBackColor = False
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(9, 29)
        Me.lblSucursal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(67, 17)
        Me.lblSucursal.TabIndex = 10
        Me.lblSucursal.Text = "Sucursal:"
        '
        'cbSucursales
        '
        Me.cbSucursales.BackColor = System.Drawing.Color.White
        Me.cbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursales.FormattingEnabled = True
        Me.cbSucursales.Location = New System.Drawing.Point(12, 50)
        Me.cbSucursales.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSucursales.Name = "cbSucursales"
        Me.cbSucursales.Size = New System.Drawing.Size(474, 24)
        Me.cbSucursales.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.White
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregar.Location = New System.Drawing.Point(30, 207)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 34)
        Me.btnAgregar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar.TabIndex = 170
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar.UseCustomBackColor = True
        Me.btnAgregar.UseSelectable = True
        Me.btnAgregar.UseStyleColors = True
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(138, 207)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 34)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar.TabIndex = 171
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar.UseCustomBackColor = True
        Me.btnModificar.UseSelectable = True
        Me.btnModificar.UseStyleColors = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Location = New System.Drawing.Point(354, 207)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 34)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar.TabIndex = 172
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar.UseCustomBackColor = True
        Me.btnEliminar.UseSelectable = True
        Me.btnEliminar.UseStyleColors = True
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.White
        Me.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConsultar.Location = New System.Drawing.Point(246, 207)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(100, 34)
        Me.btnConsultar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar.TabIndex = 173
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar.UseCustomBackColor = True
        Me.btnConsultar.UseSelectable = True
        Me.btnConsultar.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 2)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(176, 20)
        Me.MetroLabel1.TabIndex = 174
        Me.MetroLabel1.Text = "Parametros de busqueda:"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.BackColor = System.Drawing.Color.White
        Me.MetroPanel1.Controls.Add(Me.chkMostrarTodos)
        Me.MetroPanel1.Controls.Add(Me.btnBuscar)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.lblSucursal)
        Me.MetroPanel1.Controls.Add(Me.cbSucursales)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(30, 77)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(502, 123)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroPanel1.TabIndex = 175
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'frmMCorrelativosDocumentosCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(562, 466)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgCorrCaja)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1105, 627)
        Me.Name = "frmMCorrelativosDocumentosCaja"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Correlativos por Tipo de Documento Caja"
        CType(Me.dgCorrCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgCorrCaja As System.Windows.Forms.DataGridView
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents cbSucursales As System.Windows.Forms.ComboBox
    Friend WithEvents chkMostrarTodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
End Class
