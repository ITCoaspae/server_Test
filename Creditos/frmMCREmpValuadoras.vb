Public Class frmMCREmpValuadoras
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents rbEmpresa As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCREmpValuadoras))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.rbEmpresa = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.txtEmpresa)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.btnMostrar)
        Me.GroupBox2.Controls.Add(Me.rbEmpresa)
        Me.GroupBox2.Controls.Add(Me.rbCodigo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(753, 106)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Empresas por:"
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.ForeColor = System.Drawing.Color.Black
        Me.rbTodos.Location = New System.Drawing.Point(408, 28)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(182, 27)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Enabled = False
        Me.txtEmpresa.Location = New System.Drawing.Point(209, 65)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(182, 22)
        Me.txtEmpresa.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(19, 65)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(183, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Location = New System.Drawing.Point(398, 62)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(135, 28)
        Me.btnMostrar.TabIndex = 5
        Me.btnMostrar.Text = "Mos&trar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'rbEmpresa
        '
        Me.rbEmpresa.BackColor = System.Drawing.Color.White
        Me.rbEmpresa.ForeColor = System.Drawing.Color.Black
        Me.rbEmpresa.Location = New System.Drawing.Point(209, 28)
        Me.rbEmpresa.Name = "rbEmpresa"
        Me.rbEmpresa.Size = New System.Drawing.Size(182, 27)
        Me.rbEmpresa.TabIndex = 2
        Me.rbEmpresa.Text = "&Nombre Empresa:"
        Me.rbEmpresa.UseVisualStyleBackColor = False
        '
        'rbCodigo
        '
        Me.rbCodigo.BackColor = System.Drawing.Color.White
        Me.rbCodigo.ForeColor = System.Drawing.Color.Black
        Me.rbCodigo.Location = New System.Drawing.Point(19, 28)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(183, 27)
        Me.rbCodigo.TabIndex = 0
        Me.rbCodigo.Text = "&Código:"
        Me.rbCodigo.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(28, 226)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(621, 237)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 37
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(319, 187)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 199
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(222, 187)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 198
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 187)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 197
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 187)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 196
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMCREmpValuadoras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(676, 518)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMCREmpValuadoras"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Empresas Valuadoras"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ActualizaGrid()
        Dim oCred As New wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            ds = oCred.ConsultarEmpresaValuadora("*", "", "Codigo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Encabezado()
        fg.Cols.Item(1).Caption = "Código"
        fg.Cols.Item(2).Caption = "Nombre"
        fg.Cols.Item(3).Caption = "Dirección"
        fg.Cols.Item(4).Caption = "Teléfono"
        fg.Cols.Item(5).Caption = "Período Contrato del"
        fg.Cols.Item(6).Caption = "Período Contrato al"
        fg.Cols.Item(1).Width = 77
        fg.Cols.Item(2).Width = 150
        fg.Cols.Item(3).Width = 200
        fg.Cols.Item(4).Width = 77
        fg.Cols.Item(5).Width = 100
        fg.Cols.Item(6).Width = 100
    End Sub

    Private Sub frmMCREmpValuadoras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
        Me.WindowState = FormWindowState.Normal
        Me.txtCodigo.Enabled = False
        Me.txtEmpresa.Enabled = False
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub



    Private Sub rbCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodigo.CheckedChanged
        If rbCodigo.Checked = True Then
            txtCodigo.Enabled = True
        ElseIf rbCodigo.Checked = False Then
            txtCodigo.Enabled = False
        End If
        Me.txtCodigo.Focus()
    End Sub

    Private Sub rbEmpresa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEmpresa.CheckedChanged
        If Me.rbEmpresa.Checked = True Then
            Me.txtEmpresa.Enabled = True
        ElseIf Me.rbEmpresa.Checked = False Then
            Me.txtEmpresa.Enabled = False
        End If
        Me.txtEmpresa.Focus()
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection, pCodigo As String

        Try
            If Me.rbCodigo.Checked = True Then
                ds = oCred.ConsultarEmpresaValuadora("*", "Codigo='" & Trim(txtCodigo.Text) & "'", "Codigo", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbEmpresa.Checked = True Then
                ds = oCred.ConsultarEmpresaValuadora("*", "Nombre like '" & Trim(Me.txtEmpresa.Text) & "%'", "Nombre", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbTodos.Checked = True Then
                ds = oCred.ConsultarEmpresaValuadora("*", "", "Codigo", sUsuario, sPassword, sSucursal)
            End If
            Me.fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        btnConsultar1_Click(sender, e)
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub txtEmpresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmpresa.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsCrEmpValuadora = New frmMsCrEmpValuadora
            frm.Accion = "Agregar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try

            If fg.Row <> -1 Then
                Dim frm As frmMsCrEmpValuadora = New frmMsCrEmpValuadora
                frm.Accion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.Codigo = fg.Item(fg.Row, "Codigo")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                Me.txtCodigo.Enabled = False
                Me.txtEmpresa.Enabled = False
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If fg.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Empresa seleccionada?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Empresas Valuadoras") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarEmpresaValuadora(fg.Item(fg.Row, "Codigo"), sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                    Me.txtCodigo.Enabled = False
                    Me.txtEmpresa.Enabled = False
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As frmMsCrEmpValuadora = New frmMsCrEmpValuadora
                frm.Accion = "Modificar"
                frm.Codigo = fg.Item(fg.Row, "Codigo")
                frm.btnGuardar1.Enabled = False
                frm.btnGuardar1.Text = "&Consulta"
                frm.btnGuardar1.Visible = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                Me.txtCodigo.Enabled = False
                Me.txtEmpresa.Enabled = False
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class