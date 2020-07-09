Public Class frmMFallecimiento
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
    Friend WithEvents fgFallecimiento As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMFallecimiento))
        Me.fgFallecimiento = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fgFallecimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fgFallecimiento
        '
        Me.fgFallecimiento.AllowEditing = False
        Me.fgFallecimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgFallecimiento.BackColor = System.Drawing.Color.White
        Me.fgFallecimiento.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgFallecimiento.Location = New System.Drawing.Point(23, 214)
        Me.fgFallecimiento.Name = "fgFallecimiento"
        Me.fgFallecimiento.Rows.DefaultSize = 21
        Me.fgFallecimiento.Size = New System.Drawing.Size(576, 249)
        Me.fgFallecimiento.StyleInfo = resources.GetString("fgFallecimiento.StyleInfo")
        Me.fgFallecimiento.TabIndex = 36
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(507, 136)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 33)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 18
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(120, 76)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(135, 23)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(462, 76)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(135, 22)
        Me.txtNoSocio.TabIndex = 3
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(259, 112)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(338, 22)
        Me.txtNombres.TabIndex = 6
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.Location = New System.Drawing.Point(23, 107)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(91, 28)
        Me.rbNombres.TabIndex = 4
        Me.rbNombres.Text = "Nombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(23, 141)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(229, 28)
        Me.rbTodos.TabIndex = 7
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(120, 110)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(133, 24)
        Me.cbNombres.TabIndex = 5
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.Location = New System.Drawing.Point(337, 73)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(119, 28)
        Me.rbNoSocio.TabIndex = 2
        Me.rbNoSocio.Text = "No. Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Location = New System.Drawing.Point(23, 73)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(63, 28)
        Me.rbDui.TabIndex = 0
        Me.rbDui.Text = "DUI"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(314, 175)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 33)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 68
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(217, 175)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 33)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 67
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(120, 175)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 33)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 66
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 175)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 33)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 65
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMFallecimiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(627, 523)
        Me.Controls.Add(Me.btnMostrar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.rbNombres)
        Me.Controls.Add(Me.cbNombres)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.rbNoSocio)
        Me.Controls.Add(Me.fgFallecimiento)
        Me.Controls.Add(Me.rbDui)
        Me.Name = "frmMFallecimiento"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Proceso de Registro de Asociados Fallecidos"
        CType(Me.fgFallecimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Métodos"

    Private Sub LoadForm()
        'ActualizaGrid()
        ' Me.WindowState = FormWindowState.Normal
        txtDui.Enabled = False
        txtNombres.Enabled = False
        txtNoSocio.Enabled = False
        cbNombres.SelectedIndex = 0
        cbNombres.Enabled = False
    End Sub

    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarFallecidos("*", "", "Correlativo,DUI", sUsuario, sPassword, sSucursal)
            fgFallecimiento.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Fallecidos." & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        fgFallecimiento.Cols.Item(0).Width = 17
    End Sub

    Private Sub Agregar()
        Dim frm As frmMsFallecimiento = New frmMsFallecimiento
        frm.btnGuardar1.Text = "&Guardar"
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        ActualizaGrid()
    End Sub

    Private Sub Modificar()
        If fgFallecimiento.Row <> -1 Then
            Dim frm As frmMsFallecimiento = New frmMsFallecimiento
            frm.btnGuardar1.Text = "&Modificar"
            frm.Correlativo = Me.fgFallecimiento.Item(Me.fgFallecimiento.Row, "Correlativo")
            frm.txtDui.Value = fgFallecimiento.Item(Me.fgFallecimiento.Row, "DUI")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
            txtDui.Enabled = False
            txtNombres.Enabled = False
            txtNoSocio.Enabled = False
            cbNombres.Enabled = False
        End If
    End Sub

    Private Sub Eliminar()
        Try
            If fgFallecimiento.Row <> -1 Then
                If MsgBox("¿Desea eliminar el registro del Asociado Dui No. " & fgFallecimiento.Item(Me.fgFallecimiento.Row, "DUI") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Fallecidos") = MsgBoxResult.Yes Then
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
                    oAsoc.EliminarFallecidos("DUI='" & fgFallecimiento.Item(Me.fgFallecimiento.Row, "DUI") & "'", sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                    txtDui.Enabled = False
                    txtNombres.Enabled = False
                    txtNoSocio.Enabled = False
                    cbNombres.Enabled = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Buscar()

        Dim frm As New frmAGenerico, sTexto As String, oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarFallecidos("*", "", "Correlativo,DUI", sUsuario, sPassword, sSucursal)
            frm.Text = "Buscar Fallecidos"
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros
                fgFallecimiento.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oAsoc.ConsultarFallecidos("*", "", "DUI", sUsuario, sPassword, sSucursal)
                fgFallecimiento.Cols.Item(0).Width = 17
                fgFallecimiento.DataSource = ds.Tables(0)
                fgFallecimiento.Cols.Item(0).Width = 17
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado2.Trim
                fgFallecimiento.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oAsoc.ConsultarFallecidos("*", "Dui='" & sTexto & "'", "", sUsuario, sPassword, sSucursal)
                fgFallecimiento.Cols.Item(0).Width = 17
                fgFallecimiento.DataSource = ds.Tables(0)
                fgFallecimiento.Cols.Item(0).Width = 17
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Fallecidos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Mostrar()

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection, pDui As String

        Try
            oAsoc = New wrAsociados.wsLibAsoc
            If rbDui.Checked = True Then
                ds = oAsoc.ConsultarFallecidos("*", "Dui='" & Trim(txtDui.Text) & "'", "", sUsuario, sPassword, sSucursal)
            ElseIf rbNoSocio.Checked = True Then
                ds = oAsoc.ConsultarAsociado("Dui", "NoSocio='" & Trim(txtNoSocio.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)(0) Is DBNull.Value) Then
                        pDui = CStr(Filas.Item(0)("Dui"))
                    End If
                    ds = oAsoc.ConsultarFallecidos("*", "Dui='" & Trim(pDui) & "'", "", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbNombres.Checked = True Then
                If Me.cbNombres.SelectedIndex = 0 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido1 like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf Me.cbNombres.SelectedIndex = 1 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido2 like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf Me.cbNombres.SelectedIndex = 2 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Nombres like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)(0) Is DBNull.Value) Then
                        pDui = CStr(Filas.Item(0)("Dui"))
                    End If
                    ds = oAsoc.ConsultarFallecidos("*", "Dui='" & Trim(pDui) & "'", "", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbTodos.Checked = True Then
                ds = oAsoc.ConsultarFallecidos("*", "", "Correlativo,Dui", sUsuario, sPassword, sSucursal)
            End If
            fgFallecimiento.Cols.Item(0).Width = 17
            fgFallecimiento.DataSource = ds.Tables(0)
            fgFallecimiento.Cols.Item(0).Width = 17

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Fallecidos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Eventos"

    Private Sub frmMFallecimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Buscar()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub rbNombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rbNombres.Checked = True Then
            cbNombres.Enabled = True
            txtNombres.Enabled = True
        ElseIf rbNombres.Checked = False Then
            cbNombres.Enabled = False
            txtNombres.Enabled = False
        End If
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnMostrar1_Click(sender, e)
        End If
    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnMostrar1_Click(sender, e)
        End If
    End Sub

    Private Sub fgFallecimiento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgFallecimiento.DoubleClick
        btnConsultar1_Click(sender, e)
    End Sub

#End Region

    Private Sub rbDui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
        If rbDui.Checked = True Then
            txtDui.Enabled = True
        ElseIf rbDui.Checked = False Then
            txtDui.Enabled = False
        End If
        Me.txtDui.Focus()
    End Sub

    Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbNoSocio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoSocio.CheckedChanged
        Me.txtNoSocio.Enabled = rbNoSocio.Checked
        Me.txtNoSocio.Focus()
    End Sub

    Private Sub rbNombres_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        cbNombres.Enabled = rbNombres.Checked
        txtNombres.Enabled = rbNombres.Checked
        Me.cbNombres.Focus()
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNombres_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoSocio_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub


    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Mostrar()
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Agregar()
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Modificar()
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Eliminar()
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        If fgFallecimiento.Row <> -1 Then
            Dim frm As frmMsFallecimiento = New frmMsFallecimiento
            frm.btnGuardar1.Text = "&Modificar"
            frm.btnGuardar1.Enabled = False
            frm.btnGuardar1.Visible = False
            frm.Correlativo = Me.fgFallecimiento.Item(Me.fgFallecimiento.Row, "Correlativo")
            frm.txtDui.Value = fgFallecimiento.Item(Me.fgFallecimiento.Row, "DUI")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
            txtDui.Enabled = False
            txtNombres.Enabled = False
            txtNoSocio.Enabled = False
            cbNombres.Enabled = False
        End If
    End Sub

    Private Sub frmMFallecimiento_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class