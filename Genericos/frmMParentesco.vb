Public Class frmMParentesco
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents rbDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMParentesco))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.rbDescripcion = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(22, 227)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(484, 190)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 43
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.rbDescripcion)
        Me.GroupBox2.Controls.Add(Me.rbCodigo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 113)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Parentescos por:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(389, 79)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 77
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.ForeColor = System.Drawing.Color.Black
        Me.rbTodos.Location = New System.Drawing.Point(402, 27)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(62, 24)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(106, 54)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(358, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(106, 27)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(152, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'rbDescripcion
        '
        Me.rbDescripcion.BackColor = System.Drawing.Color.White
        Me.rbDescripcion.ForeColor = System.Drawing.Color.Black
        Me.rbDescripcion.Location = New System.Drawing.Point(16, 54)
        Me.rbDescripcion.Name = "rbDescripcion"
        Me.rbDescripcion.Size = New System.Drawing.Size(84, 24)
        Me.rbDescripcion.TabIndex = 2
        Me.rbDescripcion.Text = "&Descripción"
        Me.rbDescripcion.UseVisualStyleBackColor = False
        '
        'rbCodigo
        '
        Me.rbCodigo.BackColor = System.Drawing.Color.White
        Me.rbCodigo.ForeColor = System.Drawing.Color.Black
        Me.rbCodigo.Location = New System.Drawing.Point(16, 24)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(64, 24)
        Me.rbCodigo.TabIndex = 0
        Me.rbCodigo.Text = "&Código"
        Me.rbCodigo.UseVisualStyleBackColor = False
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 193)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 85
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 193)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 84
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 193)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 83
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 193)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 82
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMParentesco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(529, 460)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMParentesco"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Parentescos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "Código"
        fg.Cols.Item(2).Caption = "Descripción"

        fg.Cols.Item(1).Width = 200
        fg.Cols.Item(2).Width = 400

    End Sub

    Private Sub frmMParentesco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
        Me.WindowState = FormWindowState.Normal
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
    End Sub

    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarParentescos("*", "", "CodParentesco,Descripcion", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Parentescos." & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Encabezado()
    End Sub

    Private Sub rbCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodigo.CheckedChanged
        If rbCodigo.Checked = True Then
            txtCodigo.Enabled = True
        ElseIf rbCodigo.Checked = False Then
            txtCodigo.Enabled = False
        End If
        Me.txtCodigo.Focus()
    End Sub

    Private Sub rbDescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDescripcion.CheckedChanged
        If rbDescripcion.Checked = True Then
            txtDescripcion.Enabled = True
        ElseIf rbDescripcion.Checked = False Then
            txtDescripcion.Enabled = False
        End If
        Me.txtDescripcion.Focus()
    End Sub
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet

            oAsoc = New wrAsociados.wsLibAsoc
            If rbCodigo.Checked = True Then
                ds = oAsoc.ConsultarParentescos("*", "CodParentesco='" & Trim(txtCodigo.Text) & "'", "CodParentesco", sUsuario, sPassword, sSucursal)
            ElseIf rbDescripcion.Checked = True Then
                ds = oAsoc.ConsultarParentescos("*", "Descripcion like '" & Trim(txtDescripcion.Text) & "%'", "Descripcion", sUsuario, sPassword, sSucursal)
            ElseIf rbTodos.Checked = True Then
                ds = oAsoc.ConsultarParentescos("*", "", "CodParentesco", sUsuario, sPassword, sSucursal)
            End If
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As frmMsParentescos = New frmMsParentescos
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.pCodigo = fg.Item(fg.Row, "CodParentesco")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                txtCodigo.Enabled = False
                txtDescripcion.Enabled = False
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If fg.Row <> -1 Then
                If MsgBox("¿Desea eliminar el parentesco seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Parentesco") = MsgBoxResult.Yes Then
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
                    oAsoc.EliminarParentescos("CodParentesco='" & fg.Item(fg.Row, "CodParentesco") & "'", sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                    txtCodigo.Enabled = False
                    txtDescripcion.Enabled = False
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As frmMsParentescos = New frmMsParentescos
                frm.pAccion = "Modificar"
                frm.pCodigo = fg.Item(fg.Row, "CodParentesco")
                frm.btnGuardar1.Enabled = False
                frm.btnGuardar1.Text = "&Consulta"
                frm.btnGuardar1.Visible = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                txtCodigo.Enabled = False
                txtDescripcion.Enabled = False
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim frm As frmMsParentescos = New frmMsParentescos
            frm.pAccion = "Agregar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class