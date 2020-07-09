Public Class frmMCajeros
    Inherits MetroFramework.Forms.MetroForm
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodCajero As System.Windows.Forms.TextBox
    Friend WithEvents txtNumCaja As System.Windows.Forms.TextBox
    Friend WithEvents rbtNoCaja As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCodCajero As System.Windows.Forms.RadioButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btChangeClave1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCajeros))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtCodCajero = New System.Windows.Forms.TextBox()
        Me.txtNumCaja = New System.Windows.Forms.TextBox()
        Me.rbtNoCaja = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbtCodCajero = New System.Windows.Forms.RadioButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btChangeClave1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.fg.Location = New System.Drawing.Point(23, 283)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(836, 187)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtCodCajero)
        Me.GroupBox2.Controls.Add(Me.txtNumCaja)
        Me.GroupBox2.Controls.Add(Me.rbtNoCaja)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbtCodCajero)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(836, 176)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar Cajeros por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(474, 111)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 33)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 41
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtCodCajero
        '
        Me.txtCodCajero.BackColor = System.Drawing.Color.White
        Me.txtCodCajero.Location = New System.Drawing.Point(18, 122)
        Me.txtCodCajero.MaxLength = 10
        Me.txtCodCajero.Name = "txtCodCajero"
        Me.txtCodCajero.Size = New System.Drawing.Size(218, 22)
        Me.txtCodCajero.TabIndex = 13
        '
        'txtNumCaja
        '
        Me.txtNumCaja.BackColor = System.Drawing.Color.White
        Me.txtNumCaja.Location = New System.Drawing.Point(18, 61)
        Me.txtNumCaja.MaxLength = 15
        Me.txtNumCaja.Name = "txtNumCaja"
        Me.txtNumCaja.Size = New System.Drawing.Size(546, 22)
        Me.txtNumCaja.TabIndex = 12
        '
        'rbtNoCaja
        '
        Me.rbtNoCaja.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbtNoCaja.ForeColor = System.Drawing.Color.Black
        Me.rbtNoCaja.Location = New System.Drawing.Point(18, 28)
        Me.rbtNoCaja.Name = "rbtNoCaja"
        Me.rbtNoCaja.Size = New System.Drawing.Size(182, 27)
        Me.rbtNoCaja.TabIndex = 10
        Me.rbtNoCaja.Text = "Usuario Caja:"
        Me.rbtNoCaja.UseVisualStyleBackColor = False
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbTodos.Checked = True
        Me.rbTodos.ForeColor = System.Drawing.Color.Black
        Me.rbTodos.Location = New System.Drawing.Point(242, 89)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(183, 27)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "&Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'rbtCodCajero
        '
        Me.rbtCodCajero.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbtCodCajero.ForeColor = System.Drawing.Color.Black
        Me.rbtCodCajero.Location = New System.Drawing.Point(18, 89)
        Me.rbtCodCajero.Name = "rbtCodCajero"
        Me.rbtCodCajero.Size = New System.Drawing.Size(183, 27)
        Me.rbtCodCajero.TabIndex = 2
        Me.rbtCodCajero.Text = "Código de Cajero:"
        Me.rbtCodCajero.UseVisualStyleBackColor = False
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 245)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 42
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(120, 245)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 43
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(217, 245)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 44
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(314, 245)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 45
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btChangeClave1
        '
        Me.btChangeClave1.Location = New System.Drawing.Point(411, 245)
        Me.btChangeClave1.Name = "btChangeClave1"
        Me.btChangeClave1.Size = New System.Drawing.Size(138, 32)
        Me.btChangeClave1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btChangeClave1.TabIndex = 46
        Me.btChangeClave1.Text = "Cambia Contraseña"
        Me.btChangeClave1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btChangeClave1.UseSelectable = True
        Me.btChangeClave1.UseStyleColors = True
        '
        'frmMCajeros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(887, 620)
        Me.Controls.Add(Me.btChangeClave1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMCajeros"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Cajeros"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub RefrescarGrid()
        Dim ds As New Data.DataSet
        Dim oItem As New wrCaja.wsLibCaja
        Try
            ds = oItem.ConsultarCajeros("CodCajero,Nombre,Usuario,activo,codSucursal", "", "CodCajero", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            fg.Cols.Item(1).Width = 100
            fg.Cols.Item(2).Width = 300
            fg.Cols.Item(3).Width = 200
            fg.Cols.Item(4).Width = 100
            fg.Cols.Item(5).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmMCajeros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefrescarGrid()
    End Sub
    Private Sub rbtCodCajero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCodCajero.CheckedChanged
        Me.txtCodCajero.Focus()
    End Sub
    Private Sub rbtNoCaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNoCaja.CheckedChanged
        Me.txtNumCaja.Focus()
    End Sub

    Private Sub txtCodCajero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCajero.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub txtNumCaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumCaja.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim oItem As New wrCaja.wsLibCaja
        Dim ds As New Data.DataSet
        Try
            If Me.rbtCodCajero.Checked = True Then
                ds = oItem.ConsultarCajeros("CodCajero,Nombre,Usuario,activo,codSucursal", "CodCajero='" & Trim(Me.txtCodCajero.Text) & "'", "", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbtNoCaja.Checked = True Then
                ds = oItem.ConsultarCajeros("CodCajero,Nombre,Usuario,activo,codSucursal", "Usuario='" & Trim(Me.txtNumCaja.Text) & "'", "", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbTodos.Checked = True Then
                ds = oItem.ConsultarCajeros("CodCajero,Nombre,Usuario,activo,codSucursal", "", "CodCajero", sUsuario, sPassword, sSucursal)
            End If
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim ofrm As New frmMsCajeros
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.txtCodCajero.Enabled = False
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            RefrescarGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Dim ds As New Data.DataSet
        Dim dr As DataRow
        Dim oItem As New wrCaja.wsLibCaja
        Dim ofrm As New frmMsCajeros
        Try
            If fg.Row <> -1 Then
                ds = oItem.ConsultarCajeros("*", "CodCajero=" & CInt(fg.Item(fg.Row, "CodCajero")) & "", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar1.Text = "&Modificar"
                If Not dr("CodCajero") Is DBNull.Value Then
                    ofrm.txtCodCajero.Text = dr("CodCajero")
                    ofrm.txtCodCajero.ReadOnly = True
                End If
                If Not dr("Usuario") Is DBNull.Value Then
                    ofrm.txtUsuario.Text = dr("Usuario")
                End If
                If Not dr("Nombre") Is DBNull.Value Then
                    ofrm.txtNombre.Text = dr("Nombre")
                End If
                If Not dr("CodSucursal") Is DBNull.Value Then
                    ofrm.txtCodSuc.Text = dr("CodSucursal")
                End If
                If Not dr("CodEmpleado") Is DBNull.Value Then
                    ofrm.txtCodEmpleado.Text = dr("CodEmpleado")
                End If
                ofrm.txtContraseña.ReadOnly = True
                If Not dr("Activo") Is DBNull.Value Then
                    ofrm.chkActivo.Checked = IIf(dr("Activo") = "0", False, True)
                End If
                If Not dr("FechaIngreso") Is DBNull.Value Then
                    ofrm.dtpInicio.Value = dr("FechaIngreso")
                End If
                If Not dr("FechaFinalizacion") Is DBNull.Value Then
                    ofrm.dtpFin.Value = dr("FechaFinalizacion")
                End If
                ofrm.StartPosition = FormStartPosition.CenterParent
                ofrm.ShowDialog()
            End If
            RefrescarGrid()

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Dim ds As New Data.DataSet
        Dim dr As DataRow
        Dim oItem As New wrCaja.wsLibCaja
        Dim ofrm As New frmMsCajeros
        Try
            If fg.Row <> -1 Then
                ds = oItem.ConsultarCajeros("*", "CodCajero=" & CInt(fg.Item(fg.Row, "CodCajero")) & "", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.txtCodEmpleado.ReadOnly = True
                ofrm.txtCodSuc.ReadOnly = True
                ofrm.txtCodCajero.ReadOnly = True
                ofrm.txtContraseña.ReadOnly = True
                ofrm.txtUsuario.ReadOnly = True
                ofrm.txtNombre.ReadOnly = True
                ofrm.dtpFin.Enabled = False
                ofrm.dtpInicio.Enabled = False
                ofrm.btnGuardar1.Enabled = False
                If Not dr("CodCajero") Is DBNull.Value Then
                    ofrm.txtCodCajero.Text = dr("CodCajero")
                    ofrm.txtCodCajero.ReadOnly = True
                End If
                If Not dr("Usuario") Is DBNull.Value Then
                    ofrm.txtUsuario.Text = dr("Usuario")
                End If
                If Not dr("Nombre") Is DBNull.Value Then
                    ofrm.txtNombre.Text = dr("Nombre")
                End If
                If Not dr("CodSucursal") Is DBNull.Value Then
                    ofrm.txtCodSuc.Text = dr("CodSucursal")
                End If
                If Not dr("CodEmpleado") Is DBNull.Value Then
                    ofrm.txtCodEmpleado.Text = dr("CodEmpleado")
                End If
                If Not dr("Password") Is DBNull.Value Then
                    ofrm.txtContraseña.Text = dr("Password")
                End If
                If Not dr("Activo") Is DBNull.Value Then
                    ofrm.chkActivo.Checked = IIf(dr("Activo") = "0", False, True)
                End If
                If Not dr("FechaIngreso") Is DBNull.Value Then
                    ofrm.dtpInicio.Value = dr("FechaIngreso")
                End If
                If Not dr("FechaFinalizacion") Is DBNull.Value Then
                    ofrm.dtpFin.Value = dr("FechaFinalizacion")
                End If
                ofrm.StartPosition = FormStartPosition.CenterParent
                ofrm.Show()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Dim oItem As New wrCaja.wsLibCaja
        Dim ofrm As New frmMsCajeros
        Try
            If fg.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Cajero No. " & fg.Item(fg.Row, "CodCajero") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Cajero") = MsgBoxResult.Yes Then
                    If oItem.EliminarCajeros("'" & Trim(fg.Item(fg.Row, "CodCajero")) & "'", sUsuario, sPassword, sSucursal) = True Then
                        RefrescarGrid()
                    End If
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btChangeClave1_Click(sender As Object, e As EventArgs) Handles btChangeClave1.Click
        Try
            If fg.Row <> -1 Then
                Dim ofrm As New frmMsCambioClave
                ofrm.Usuario = fg.Item(fg.Row, "USUARIO")
                ofrm.Codigo = fg.Item(fg.Row, "CodCajero")
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class