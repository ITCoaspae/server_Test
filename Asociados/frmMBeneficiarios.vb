Public Class frmMBeneficiarios
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
    Friend WithEvents C1fGrdBeneficiarios As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMBeneficiarios))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.C1fGrdBeneficiarios = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1fGrdBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.txtNoSocio)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.rbNoSocio)
        Me.GroupBox2.Controls.Add(Me.rbDui)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(726, 90)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(618, 46)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 32)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 16
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(7, 57)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(135, 23)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(150, 57)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(127, 22)
        Me.txtNoSocio.TabIndex = 3
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(428, 55)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(183, 22)
        Me.txtNombres.TabIndex = 6
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.Location = New System.Drawing.Point(284, 21)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(137, 27)
        Me.rbNombres.TabIndex = 4
        Me.rbNombres.Text = "Nombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(618, 22)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(90, 28)
        Me.rbTodos.TabIndex = 7
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(284, 55)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(137, 24)
        Me.cbNombres.TabIndex = 5
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.Location = New System.Drawing.Point(149, 22)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(127, 28)
        Me.rbNoSocio.TabIndex = 2
        Me.rbNoSocio.Text = "No. Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Location = New System.Drawing.Point(7, 22)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(135, 28)
        Me.rbDui.TabIndex = 0
        Me.rbDui.Text = "DUI Asociado"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'C1fGrdBeneficiarios
        '
        Me.C1fGrdBeneficiarios.AllowEditing = False
        Me.C1fGrdBeneficiarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fGrdBeneficiarios.BackColor = System.Drawing.Color.White
        Me.C1fGrdBeneficiarios.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fGrdBeneficiarios.Location = New System.Drawing.Point(28, 209)
        Me.C1fGrdBeneficiarios.Name = "C1fGrdBeneficiarios"
        Me.C1fGrdBeneficiarios.Rows.Count = 2
        Me.C1fGrdBeneficiarios.Rows.DefaultSize = 21
        Me.C1fGrdBeneficiarios.Size = New System.Drawing.Size(731, 158)
        Me.C1fGrdBeneficiarios.StyleInfo = resources.GetString("C1fGrdBeneficiarios.StyleInfo")
        Me.C1fGrdBeneficiarios.TabIndex = 14
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(319, 170)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 52
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(222, 170)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 51
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 170)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 50
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 170)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 49
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMBeneficiarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(782, 424)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.C1fGrdBeneficiarios)
        Me.Name = "frmMBeneficiarios"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Beneficiarios de Asociados"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1fGrdBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarBeneficiarios("*", "", "DUI,Correlativo", sUsuario, sPassword, sSucursal)
            C1fGrdBeneficiarios.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Beneficiarios" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        C1fGrdBeneficiarios.Cols.Item(0).Width = 17
    End Sub

    Private Sub frmMBeneficiarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ActualizaGrid()
        'Me.WindowState = FormWindowState.Normal
        txtDui.Enabled = False
        txtNombres.Enabled = False
        txtNoSocio.Enabled = False
        cbNombres.SelectedIndex = 0
        cbNombres.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frm As New frmAGenerico
        Dim sTexto As String

        frm.Text = "Buscar Beneficiario"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, ds2 As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarBeneficiarios("*", "", "DUI", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros
                C1fGrdBeneficiarios.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oAsoc.ConsultarBeneficiarios("*", "", "DUI", sUsuario, sPassword, sSucursal)
                C1fGrdBeneficiarios.Cols.Item(0).Width = 17
                C1fGrdBeneficiarios.DataSource = ds.Tables(0)
                C1fGrdBeneficiarios.Cols.Item(0).Width = 17
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado2.Trim
                C1fGrdBeneficiarios.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oAsoc.ConsultarBeneficiarios("*", "Correlativo='" & sTexto & "'", "DUI", sUsuario, sPassword, sSucursal)
                C1fGrdBeneficiarios.Cols.Item(0).Width = 17
                C1fGrdBeneficiarios.DataSource = ds.Tables(0)
                C1fGrdBeneficiarios.Cols.Item(0).Width = 17
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Beneficiarios- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub rbDui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
        If rbDui.Checked = True Then
            txtDui.Enabled = True
        ElseIf rbDui.Checked = False Then
            txtDui.Enabled = False
        End If
        Me.txtDui.Focus()
    End Sub

    Private Sub rbNoSocio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoSocio.CheckedChanged
        If rbNoSocio.Checked = True Then
            txtNoSocio.Enabled = True
        ElseIf rbNoSocio.Checked = False Then
            txtNoSocio.Enabled = False
        End If
        Me.txtNoSocio.Focus()
    End Sub

    Private Sub rbNombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        If rbNombres.Checked = True Then
            cbNombres.Enabled = True
            txtNombres.Enabled = True
        ElseIf rbNombres.Checked = False Then
            cbNombres.Enabled = False
            txtNombres.Enabled = False
        End If
        Me.cbNombres.Focus()
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub C1fGrdBeneficiarios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1fGrdBeneficiarios.DoubleClick
        btnConsultar1_Click(sender, e)
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

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection, pDui As String
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            If rbDui.Checked = True Then
                ds = oAsoc.ConsultarBeneficiarios("*", "Dui='" & Trim(txtDui.Text) & "'", "Apellido1", sUsuario, sPassword, sSucursal)
            ElseIf rbNoSocio.Checked = True Then
                ds = oAsoc.ConsultarAsociado("Dui", "NoSocio='" & Trim(txtNoSocio.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)(0) Is DBNull.Value) Then
                        pDui = CStr(Filas.Item(0)("Dui"))
                    End If
                    ds = oAsoc.ConsultarBeneficiarios("*", "Dui='" & Trim(pDui) & "'", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbNombres.Checked = True Then
                If Me.cbNombres.SelectedIndex = 0 Then
                    ds = oAsoc.ConsultarBeneficiarios("*", "Apellido1 like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf Me.cbNombres.SelectedIndex = 1 Then
                    ds = oAsoc.ConsultarBeneficiarios("*", "Apellido2 like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf Me.cbNombres.SelectedIndex = 2 Then
                    ds = oAsoc.ConsultarBeneficiarios("*", "Nombres like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbTodos.Checked = True Then
                ds = oAsoc.ConsultarBeneficiarios("*", "", "Apellido1", sUsuario, sPassword, sSucursal)
            End If
            C1fGrdBeneficiarios.Cols.Item(0).Width = 17
            C1fGrdBeneficiarios.DataSource = ds.Tables(0)
            C1fGrdBeneficiarios.Cols.Item(0).Width = 17

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Dim frm As frmMsBeneficiarios = New frmMsBeneficiarios
        frm.pAccion = "Agregar"
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        ActualizaGrid()
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        If C1fGrdBeneficiarios.Row <> -1 Then
            Dim frm As frmMsBeneficiarios = New frmMsBeneficiarios
            frm.pAccion = "Modificar"
            frm.pDui = C1fGrdBeneficiarios.Item(C1fGrdBeneficiarios.Row, "DUI")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
            txtDui.Enabled = False
            txtNombres.Enabled = False
            txtNoSocio.Enabled = False
            cbNombres.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If C1fGrdBeneficiarios.Row <> -1 Then
                If MsgBox("¿Desea eliminar los Beneficiarios del Asociado Dui No. " & C1fGrdBeneficiarios.Item(C1fGrdBeneficiarios.Row, "DUI") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Beneficiarios") = MsgBoxResult.Yes Then
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
                    oAsoc.EliminarBeneficiarios("DUI='" & C1fGrdBeneficiarios.Item(C1fGrdBeneficiarios.Row, "DUI") & "'", sUsuario, sPassword, sSucursal)
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

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click

        If C1fGrdBeneficiarios.Row <> -1 Then
            Dim frm As frmMsBeneficiarios = New frmMsBeneficiarios
            frm.pAccion = "Modificar"
            frm.btnNuevo1.Enabled = False
            frm.btnModificar1.Text = "&Consulta"
            frm.pDui = C1fGrdBeneficiarios.Item(C1fGrdBeneficiarios.Row, "DUI")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
            txtDui.Enabled = False
            txtNombres.Enabled = False
            txtNoSocio.Enabled = False
            cbNombres.Enabled = False
        End If
    End Sub

    Private Sub frmMBeneficiarios_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
