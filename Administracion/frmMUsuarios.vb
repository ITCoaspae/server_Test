Public Class frmMUsuarios
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
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents rbtUsuario As System.Windows.Forms.RadioButton
    Friend WithEvents dg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMUsuarios))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.rbtUsuario = New System.Windows.Forms.RadioButton()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.dg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.MetroButton2)
        Me.GroupBox2.Controls.Add(Me.txtUsuario)
        Me.GroupBox2.Controls.Add(Me.rbtUsuario)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 99)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar Usuario por:"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(386, 57)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 193
        Me.MetroButton2.Text = "Mostrar"
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(7, 57)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(183, 22)
        Me.txtUsuario.TabIndex = 1
        '
        'rbtUsuario
        '
        Me.rbtUsuario.BackColor = System.Drawing.Color.White
        Me.rbtUsuario.Location = New System.Drawing.Point(7, 22)
        Me.rbtUsuario.Name = "rbtUsuario"
        Me.rbtUsuario.Size = New System.Drawing.Size(183, 28)
        Me.rbtUsuario.TabIndex = 0
        Me.rbtUsuario.Text = "Usuario"
        Me.rbtUsuario.UseVisualStyleBackColor = False
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Location = New System.Drawing.Point(197, 57)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(182, 22)
        Me.txtNombres.TabIndex = 3
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.Location = New System.Drawing.Point(197, 22)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(182, 28)
        Me.rbNombres.TabIndex = 2
        Me.rbNombres.Text = "Nombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(386, 22)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(183, 28)
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
        Me.dg.Location = New System.Drawing.Point(28, 218)
        Me.dg.Name = "dg"
        Me.dg.Rows.Count = 2
        Me.dg.Rows.DefaultSize = 21
        Me.dg.Size = New System.Drawing.Size(684, 195)
        Me.dg.StyleInfo = resources.GetString("dg.StyleInfo")
        Me.dg.TabIndex = 18
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(222, 179)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 195
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(319, 179)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 194
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 179)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 193
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 179)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 192
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(416, 179)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(183, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 196
        Me.MetroButton1.Text = "Reestablecer Contraseña"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMUsuarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(739, 466)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dg)
        Me.Name = "frmMUsuarios"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Usuarios"
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
            ds = oAsoc.ConsultarUsuario("Usuario,Nombre,FecValDesde,FecValHasta,CodSucursal", "", "USUARIO", sUsuario, sPassword, sSucursal)
            dg.DataSource = ds.Tables(0)
            dg.Cols.Item(1).Caption = "Usuario"
            dg.Cols.Item(2).Caption = "Nombre"
            dg.Cols.Item(3).Caption = "Fec.Válido Desde"
            dg.Cols.Item(4).Caption = "Fec.Válido Hasta"
            dg.Cols.Item(5).Caption = "Sucursal"
            dg.Cols.Item(1).Width = 100
            dg.Cols.Item(2).Width = 200
            dg.Cols.Item(3).Width = 200
            dg.Cols.Item(4).Width = 200
            dg.Cols.Item(5).Width = 77

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
    End Sub



    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        btnModificar1_Click(sender, e)
    End Sub



    Private Sub rbtUsuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtUsuario.CheckedChanged
        Me.txtUsuario.Focus()
    End Sub

    Private Sub rbNombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        Me.txtNombres.Focus()
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton2_Click(sender, e)
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton2_Click(sender, e)
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim ofrm As New frmMsUsuarios
            ofrm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If dg.Row <> -1 Then
                Dim frm As New frmMsUsuarios, ds As New DataSet, oAdm As New wrAdmin.wsLibAdmin, dr As DataRow
                ds = oAdm.ConsultarUsuario("*", "Usuario='" & dg.Item(dg.Row, "USUARIO") & "'", "Usuario", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    frm.txtClave.ReadOnly = True
                    frm.txtConfirmarClave.ReadOnly = True
                    frm.btnGuardar1.Text = "&Modificar"
                    frm.txtUsuario.Text = dr("Usuario")
                    frm.txtUsuario.ReadOnly = True
                    frm.txtNombre.Text = dr("NOMBRE")
                    frm.dtpFecDesde.Value = dr("FECVALDESDE")
                    frm.dtpFecHasta.Value = dr("FECVALHASTA")
                    frm.llenarSucursal()
                    frm.cbSucursal.SelectedValue = IIf(IsDBNull(dr("CodSucursal")), "", dr("CodSucursal"))

                    frm.ShowDialog()
                    ActualizaGrid()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If dg.Row <> -1 Then
                If MessageBox.Show("¿Desea eliminar el Usuario?", "Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim oAsoc As New wrAdmin.wsLibAdmin
                    If oAsoc.EliminarUsuario("USUARIO='" & dg.Item(dg.Row, "USUARIO") & "'", sUsuario, sPassword, sSucursal) = True Then
                        ActualizaGrid()
                    End If
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If dg.Row <> -1 Then
                Dim frm As New frmMsUsuarios, ds As New DataSet, oAdm As New wrAdmin.wsLibAdmin, dr As DataRow
                ds = oAdm.ConsultarUsuario("*", "Usuario='" & dg.Item(dg.Row, "USUARIO") & "'", "Usuario", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    frm.btnGuardar1.Visible = False
                    frm.btnGuardar1.Text = "&Modificar"
                    frm.txtUsuario.Text = dr("Usuario")
                    frm.txtUsuario.ReadOnly = True
                    frm.txtClave.ReadOnly = True
                    frm.txtConfirmarClave.ReadOnly = True
                    frm.txtNombre.Text = dr("NOMBRE")
                    frm.dtpFecDesde.Value = dr("FECVALDESDE")
                    frm.dtpFecHasta.Value = dr("FECVALHASTA")
                    frm.llenarSucursal()
                    frm.cbSucursal.SelectedValue = IIf(IsDBNull(dr("CodSucursal")), "", dr("CodSucursal"))
                    frm.ShowDialog()
                    ActualizaGrid()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If dg.Row <> -1 Then
                Dim ofrm As New frmMsCambioPsw
                ofrm.txtClaveAnterior.Enabled = False
                ofrm.reset = True
                ofrm.Usuario = dg.Item(dg.Row, "USUARIO")
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim oAdm As New wrAdmin.wsLibAdmin, ds As New Data.DataSet

            If rbtUsuario.Checked = True Then
                ds = oAdm.ConsultarUsuario("Usuario,Nombre,FecValDesde,FecValHasta,CodSucursal", "Usuario='" & Trim(Me.txtUsuario.Text) & "'", "Usuario", sUsuario, sPassword, sSucursal)
            ElseIf rbNombres.Checked = True Then
                ds = oAdm.ConsultarUsuario("Usuario,Nombre,FecValDesde,FecValHasta,CodSucursal", "Nombre like '" & Trim(Me.txtNombres.Text) & "%'", "Usuario", sUsuario, sPassword, sSucursal)
            ElseIf rbTodos.Checked = True Then
                ds = oAdm.ConsultarUsuario("Usuario,Nombre,FecValDesde,FecValHasta,CodSucursal", "", "Usuario", sUsuario, sPassword, sSucursal)
            End If
            dg.DataSource = ds.Tables(0)
            dg.Cols.Item(1).Caption = "Usuario"
            dg.Cols.Item(2).Caption = "Nombre"
            dg.Cols.Item(3).Caption = "Fec.Válido Desde"
            dg.Cols.Item(4).Caption = "Fec.Válido Hasta"
            dg.Cols.Item(5).Caption = "Sucursal"
            dg.Cols.Item(1).Width = 100
            dg.Cols.Item(2).Width = 200
            dg.Cols.Item(3).Width = 200
            dg.Cols.Item(4).Width = 200
            dg.Cols.Item(5).Width = 77
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMUsuarios_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class