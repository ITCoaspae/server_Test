Public Class frmMUsuarioporRol
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents rbtUsuario As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents rbtRol As System.Windows.Forms.RadioButton
    Friend WithEvents dg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMUsuarioporRol))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.rbtUsuario = New System.Windows.Forms.RadioButton()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.rbtRol = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.dg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.txtUsuario)
        Me.GroupBox2.Controls.Add(Me.rbtUsuario)
        Me.GroupBox2.Controls.Add(Me.txtRol)
        Me.GroupBox2.Controls.Add(Me.rbtRol)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 87)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar Registros por:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(322, 49)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 191
        Me.MetroButton1.Text = "Mostrar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(6, 51)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(152, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'rbtUsuario
        '
        Me.rbtUsuario.BackColor = System.Drawing.Color.White
        Me.rbtUsuario.Location = New System.Drawing.Point(6, 19)
        Me.rbtUsuario.Name = "rbtUsuario"
        Me.rbtUsuario.Size = New System.Drawing.Size(152, 24)
        Me.rbtUsuario.TabIndex = 0
        Me.rbtUsuario.Text = "Usuario"
        Me.rbtUsuario.UseVisualStyleBackColor = False
        '
        'txtRol
        '
        Me.txtRol.Location = New System.Drawing.Point(164, 51)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(152, 20)
        Me.txtRol.TabIndex = 3
        '
        'rbtRol
        '
        Me.rbtRol.BackColor = System.Drawing.Color.White
        Me.rbtRol.Location = New System.Drawing.Point(164, 19)
        Me.rbtRol.Name = "rbtRol"
        Me.rbtRol.Size = New System.Drawing.Size(152, 24)
        Me.rbtRol.TabIndex = 2
        Me.rbtRol.Text = "Rol"
        Me.rbtRol.UseVisualStyleBackColor = False
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(322, 19)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(152, 24)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "&Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'dg
        '
        Me.dg.AllowEditing = False
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.BackColor = System.Drawing.SystemColors.Window
        Me.dg.ColumnInfo = "9,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.dg.Location = New System.Drawing.Point(23, 190)
        Me.dg.Name = "dg"
        Me.dg.Rows.Count = 2
        Me.dg.Size = New System.Drawing.Size(554, 216)
        Me.dg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("dg.Styles"))
        Me.dg.TabIndex = 26
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(185, 156)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 191
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(266, 156)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 190
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(104, 156)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(75, 28)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 189
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 156)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 188
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMUsuarioporRol
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(600, 451)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMUsuarioporRol"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Usuarios por Rol"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ActualizaGrid()
        Try
            Dim oAsoc As wrAdmin.wsLibAdmin, ds As Data.DataSet = New Data.DataSet
            oAsoc = New wrAdmin.wsLibAdmin
            ds = oAsoc.ConsultarUsuarioxRol("*", "", "a.Correlativo", sUsuario, sPassword, sSucursal)
            dg.DataSource = ds.Tables(0)
            dg.Cols.Item(1).Caption = "No"
            dg.Cols.Item(2).Caption = "Código de Rol"
            dg.Cols.Item(3).Caption = "Descripción"
            dg.Cols.Item(4).Caption = "Usuario"
            dg.Cols.Item(5).Caption = "Nombre"
            dg.Cols.Item(1).Width = 0
            dg.Cols.Item(2).Width = 100
            dg.Cols.Item(3).Width = 200
            dg.Cols.Item(4).Width = 200
            dg.Cols.Item(5).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMUsuarioporRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
    End Sub



    Private Sub rbtUsuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtUsuario.CheckedChanged
        Me.txtUsuario.Focus()
    End Sub

    Private Sub rbtRol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtRol.CheckedChanged
        Me.txtRol.Focus()
    End Sub

    Private Sub txtRol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRol.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim ofrm As New frmMsUsuarioporRol
            ofrm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If dg.Row <> -1 Then
                Dim frm As New frmMsUsuarioporRol
                frm.btnGuardar1.Text = "&Modificar"
                frm.txtRol.Text = dg.Item(dg.Row, "CodRol")
                frm.Correlativo = dg.Item(dg.RowSel, "Correlativo")
                frm.txtDescRol.Text = dg.Item(dg.Row, "Rol")
                frm.txtCodUsuario.Text = dg.Item(dg.Row, "Usuario")
                frm.txtDescUsuario.Text = dg.Item(dg.Row, "Nombre")
                frm.txtObservaciones.Text = dg.Item(dg.Row, "Descripcion")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If dg.Row <> -1 Then
                If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Registro") = MsgBoxResult.Yes Then
                    Dim oAdm As wrAdmin.wsLibAdmin = New wrAdmin.wsLibAdmin
                    oAdm.EliminarUsuarioxRol("Correlativo=" & CInt(dg.Item(dg.Row, "Correlativo")) & "", sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If dg.Row <> -1 Then
                Dim frm As New frmMsUsuarioporRol
                frm.btnGuardar1.Text = "&Modificar"
                frm.btnGuardar1.Visible = False
                frm.txtRol.Text = dg.Item(dg.Row, "CodRol")
                frm.txtRol.ReadOnly = True
                frm.txtDescRol.Text = dg.Item(dg.Row, "Rol")
                frm.txtCodUsuario.Text = dg.Item(dg.Row, "Usuario")
                frm.txtCodUsuario.ReadOnly = True
                frm.txtDescUsuario.Text = dg.Item(dg.Row, "Nombre")
                frm.txtObservaciones.Text = dg.Item(dg.Row, "Descripcion")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim oAdm As New wrAdmin.wsLibAdmin, ds As New Data.DataSet
            If rbtUsuario.Checked = True Then
                ds = oAdm.ConsultarUsuarioxRol("*", "a.Usuario='" & Trim(Me.txtUsuario.Text) & "'", "a.CodRol,a.Correlativo", sUsuario, sPassword, sSucursal)
            ElseIf rbtRol.Checked = True Then
                ds = oAdm.ConsultarUsuarioxRol("*", "a.CodRol='" & Trim(Me.txtRol.Text) & "'", "a.CodRol,a.Correlativo", sUsuario, sPassword, sSucursal)
            ElseIf rbTodos.Checked = True Then
                ds = oAdm.ConsultarUsuarioxRol("*", "", "a.CodRol,a.Correlativo", sUsuario, sPassword, sSucursal)
            End If
            dg.DataSource = ds.Tables(0)
            dg.Cols.Item(1).Caption = "No"
            dg.Cols.Item(2).Caption = "Código de Rol"
            dg.Cols.Item(3).Caption = "Descripción"
            dg.Cols.Item(4).Caption = "Usuario"
            dg.Cols.Item(5).Caption = "Nombre"
            dg.Cols.Item(1).Width = 0
            dg.Cols.Item(2).Width = 100
            dg.Cols.Item(3).Width = 200
            dg.Cols.Item(4).Width = 200
            dg.Cols.Item(5).Width = 200
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class