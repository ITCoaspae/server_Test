Public Class frmMRol
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
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents rbtRol As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents dg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents rbDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMRol))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.rbDescripcion = New System.Windows.Forms.RadioButton()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
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
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.rbDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.rbtRol)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 86)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar Roles por:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(322, 49)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 187
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(164, 49)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(152, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'rbDescripcion
        '
        Me.rbDescripcion.BackColor = System.Drawing.Color.White
        Me.rbDescripcion.Location = New System.Drawing.Point(164, 19)
        Me.rbDescripcion.Name = "rbDescripcion"
        Me.rbDescripcion.Size = New System.Drawing.Size(152, 24)
        Me.rbDescripcion.TabIndex = 2
        Me.rbDescripcion.Text = "Descripción:"
        Me.rbDescripcion.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(6, 49)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(152, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'rbtRol
        '
        Me.rbtRol.BackColor = System.Drawing.Color.White
        Me.rbtRol.Location = New System.Drawing.Point(6, 19)
        Me.rbtRol.Name = "rbtRol"
        Me.rbtRol.Size = New System.Drawing.Size(152, 24)
        Me.rbtRol.TabIndex = 0
        Me.rbtRol.Text = "Cód. Rol:"
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
        Me.dg.BackColor = System.Drawing.Color.White
        Me.dg.ColumnInfo = "9,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.dg.Location = New System.Drawing.Point(23, 189)
        Me.dg.Name = "dg"
        Me.dg.Rows.Count = 2
        Me.dg.Size = New System.Drawing.Size(528, 208)
        Me.dg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("dg.Styles"))
        Me.dg.TabIndex = 22
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(185, 155)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 187
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(266, 155)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 186
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(104, 155)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(75, 28)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 185
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 155)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 184
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMRol
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(574, 462)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dg)
        Me.Name = "frmMRol"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Roles"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ActualizaGrid()
        Dim oAsoc As wrAdmin.wsLibAdmin, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAdmin.wsLibAdmin
            ds = oAsoc.ConsultarRol("*", "", "CodRol", sUsuario, sPassword, sSucursal)
            dg.DataSource = ds.Tables(0)
            dg.Cols.Item(1).Caption = "Código de Rol"
            dg.Cols.Item(2).Caption = "Descripción"
            dg.Cols.Item(1).Width = 100
            dg.Cols.Item(2).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMRol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
    End Sub

    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        btnConsultar1_Click(sender, e)
    End Sub


    Private Sub rbtRol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtRol.CheckedChanged
        Me.txtCodigo.Focus()
    End Sub

    Private Sub rbDescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDescripcion.CheckedChanged
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim ofrm As New frmMsRoles
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If dg.Row <> -1 Then
                Dim frm As New frmMsRoles
                frm.btnGuardar1.Text = "&Modificar"
                frm.txtCodRol.Text = dg.Item(dg.Row, "codrol")
                frm.txtCodRol.ReadOnly = True
                frm.txtDescripcion.Text = dg.Item(dg.Row, "DESCRIPCION")
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
                If MsgBox("¿Desea eliminar Rol?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Roles") = MsgBoxResult.Yes Then
                    Dim oAsoc As wrAdmin.wsLibAdmin
                    oAsoc = New wrAdmin.wsLibAdmin
                    If oAsoc.EliminarRol("CODROL='" & dg.Item(dg.Row, "CODROL").ToString.Trim & "'", sUsuario, sPassword, sSucursal) = True Then
                        ActualizaGrid()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If dg.Row <> -1 Then
                Dim frm As New frmMsRoles
                frm.btnGuardar1.Visible = False
                frm.txtCodRol.Text = dg.Item(dg.Row, "codrol")
                frm.txtCodRol.ReadOnly = True
                frm.txtDescripcion.Text = dg.Item(dg.Row, "DESCRIPCION")
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
            Dim oAsoc As wrAdmin.wsLibAdmin, ds As Data.DataSet = New Data.DataSet
            oAsoc = New wrAdmin.wsLibAdmin
            If rbtRol.Checked = True Then
                ds = oAsoc.ConsultarRol("*", "CodRol='" & Me.txtCodigo.Text & "'", "CodRol", sUsuario, sPassword, sSucursal)
                dg.DataSource = ds.Tables(0)
            ElseIf rbDescripcion.Checked = True Then
                ds = oAsoc.ConsultarRol("*", "Descripcion like '" & Me.txtDescripcion.Text.Trim & "%'", "CodRol", sUsuario, sPassword, sSucursal)
                dg.DataSource = ds.Tables(0)
            ElseIf rbTodos.Checked = True Then
                ds = oAsoc.ConsultarRol("*", "", "CodRol", sUsuario, sPassword, sSucursal)
                dg.DataSource = ds.Tables(0)
            End If
            dg.Cols.Item(1).Caption = "Código de Rol"
            dg.Cols.Item(2).Caption = "Descripción"
            dg.Cols.Item(1).Width = 100
            dg.Cols.Item(2).Width = 200
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class