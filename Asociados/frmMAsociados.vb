Public Class frmMAsociados
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
    Friend WithEvents C1fgrdAsociados As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMAsociados))
        Me.C1fgrdAsociados = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        CType(Me.C1fgrdAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1fgrdAsociados
        '
        Me.C1fgrdAsociados.AllowEditing = False
        Me.C1fgrdAsociados.AllowFiltering = True
        Me.C1fgrdAsociados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdAsociados.ColumnInfo = "9,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdAsociados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1fgrdAsociados.ForeColor = System.Drawing.Color.Black
        Me.C1fgrdAsociados.Location = New System.Drawing.Point(23, 215)
        Me.C1fgrdAsociados.Name = "C1fgrdAsociados"
        Me.C1fgrdAsociados.Rows.DefaultSize = 22
        Me.C1fgrdAsociados.Size = New System.Drawing.Size(884, 293)
        Me.C1fgrdAsociados.StyleInfo = resources.GetString("C1fgrdAsociados.StyleInfo")
        Me.C1fgrdAsociados.TabIndex = 10
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(315, 176)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 33)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 17
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(568, 138)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 32)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 13
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(218, 176)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 33)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 16
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(146, 78)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(183, 20)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(120, 176)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 33)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 15
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Location = New System.Drawing.Point(335, 109)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(323, 22)
        Me.txtNombres.TabIndex = 8
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 176)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 33)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 14
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.Location = New System.Drawing.Point(23, 109)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(97, 28)
        Me.rbNombres.TabIndex = 6
        Me.rbNombres.Text = "Nombres:"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.BackColor = System.Drawing.Color.White
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(147, 109)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(182, 24)
        Me.cbNombres.TabIndex = 7
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.Location = New System.Drawing.Point(23, 143)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(118, 27)
        Me.rbNoSocio.TabIndex = 4
        Me.rbNoSocio.Text = "No. Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.Location = New System.Drawing.Point(147, 145)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(182, 22)
        Me.txtNoSocio.TabIndex = 5
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Location = New System.Drawing.Point(23, 75)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(69, 28)
        Me.rbDui.TabIndex = 2
        Me.rbDui.Text = "DUI:"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(335, 143)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(122, 27)
        Me.rbTodos.TabIndex = 9
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "&Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'frmMAsociados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(935, 583)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnMostrar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.C1fgrdAsociados)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.rbDui)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.rbNombres)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.rbNoSocio)
        Me.Controls.Add(Me.cbNombres)
        Me.MinimumSize = New System.Drawing.Size(935, 540)
        Me.Name = "frmMAsociados"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Asociados"
        CType(Me.C1fgrdAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim vTipo As Integer

    Public Property oTipo() As Integer
        Get
            Return vTipo
        End Get
        Set(ByVal Value As Integer)
            vTipo = Value
        End Set
    End Property

#Region "Métodos"

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub frmMAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Select Case vTipo
        '    Case 0
        '        Me.Text = "Mantenimiento de Clientes"
        '    Case 1
        '        Me.Text = "Mantenimiento de Aspirantes"
        '        Me.btnAgregar1.Visible = False
        '    Case 2
        '        Me.Text = "Mantenimiento de Asociados"
        '        Me.btnAgregar1.Visible = False
        'End Select
        'ActualizaGrid()
        'Me.WindowState = FormWindowState.Normal
        'Me.cbEstadoActual.Enabled = False
        'Me.cbEstadoIngreso.Enabled = False

    End Sub



    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet ', var As Data.DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            Dim campos As String = "Correlativo,Dui,NoSocio,Nombres,Apellido1,Apellido2,ApellidoCas,CodAntiguo,Nit,Isss,EstadoIngreso,Direccion,TelCasa,TelOficina,EstadoAsociado"
            ds = oAsoc.ConsultarAsociado(campos, "", "Correlativo,DUI,NoSocio asc", sUsuario, sPassword, sSucursal)
            C1fgrdAsociados.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.C1fgrdAsociados.Cols.Item(0).Width = 17
    End Sub



    Private Sub C1fgrdAsociados_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1fgrdAsociados.DoubleClick
        btnConsultar1_Click(sender, e)
    End Sub

#End Region

    Private Sub rbDui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
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
        Me.txtNoSocio.Focus()
    End Sub

    Private Sub rbNombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        Me.cbNombres.Focus()
    End Sub


    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub cbEstadoActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            Dim campos As String = "Correlativo,Dui,NoSocio,Nombres,Apellido1,Apellido2,ApellidoCas,CodAntiguo,Nit,Isss,EstadoIngreso,Direccion,TelCasa,TelOficina,EstadoAsociado"
            If Me.rbTodos.Checked = True Then
                ds = oAsoc.ConsultarAsociado(campos, "", "Dui,Apellido1", sUsuario, sPassword, sSucursal)
            ElseIf rbDui.Checked = True Then
                ds = oAsoc.ConsultarAsociado(campos, "Dui='" & Trim(txtDui.Text) & "' ", "Apellido1", sUsuario, sPassword, sSucursal)
            ElseIf rbNoSocio.Checked = True Then
                ds = oAsoc.ConsultarAsociado(campos, "NoSocio='" & Trim(txtNoSocio.Text) & "' ", "Nosocio", sUsuario, sPassword, sSucursal)
            ElseIf rbNombres.Checked = True Then
                If Me.cbNombres.SelectedIndex = 0 Then
                    ds = oAsoc.ConsultarAsociado(campos, "Apellido1 like '" & Trim(txtNombres.Text) & "%'", "Apellido1,Apellido2", sUsuario, sPassword, sSucursal)
                ElseIf Me.cbNombres.SelectedIndex = 1 Then
                    ds = oAsoc.ConsultarAsociado(campos, "Apellido2 like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf Me.cbNombres.SelectedIndex = 2 Then
                    ds = oAsoc.ConsultarAsociado(campos, "Nombres like '" & Trim(txtNombres.Text) & "%' ", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
            End If

            Me.C1fgrdAsociados.Cols.Item(0).Width = 17
            C1fgrdAsociados.DataSource = ds.Tables(0)
            Me.C1fgrdAsociados.Cols.Item(0).Width = 17
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Dim frm As New frmIngresoAsoc2 'frmMsIngresoAsociados
        With frm
            .StartPosition = FormStartPosition.CenterScreen
            .accion = 1
        End With
        'frm.StartPosition = FormStartPosition.CenterScreen
        'Dim frm As frmMsAsociados = New frmMsAsociados
        'frm.StartPosition = FormStartPosition.CenterScreen
        'frm.cbEstadoAsoc.SelectedIndex = vTipo
        'frm.cbEstadoAsociado.SelectedIndex = vTipo
        Select Case vTipo
            Case 0
                frm.Text = "Mantenimiento de Asociados"
                'frm.accion = 1
                'Case 1
                '    frm.Text = "   Mantenimiento de Aspirantes"
                'Case 2
                '    frm.Text = "   Mantenimiento de Asociados"
        End Select
        frm.ShowDialog()
        ActualizaGrid()

    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If C1fgrdAsociados.Row <> -1 Then
                Dim frm As New frmIngresoAsoc2 'frmMsIngresoAsociados
                With frm
                    .accion = 2
                    .txtDui.Enabled = False
                    .txtDui.Text = C1fgrdAsociados.Item(C1fgrdAsociados.Row, "DUI").ToString
                    '.llenarDatos(C1fgrdAsociados.Item(C1fgrdAsociados.Row, "DUI").ToString)
                    .ShowDialog()
                End With
                ActualizaGrid()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If C1fgrdAsociados.Row <> -1 Then
                If CStr(C1fgrdAsociados.Item(C1fgrdAsociados.Row, "EstadoIngreso")) = "0" Then
                    If MsgBox("¿Desea eliminar el Asociado con Dui No. " & C1fgrdAsociados.Item(C1fgrdAsociados.Row, "DUI") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Asociado") = MsgBoxResult.Yes Then
                        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
                        oAsoc.EliminarAsociado(C1fgrdAsociados.Item(C1fgrdAsociados.Row, "Correlativo"), C1fgrdAsociados.Item(C1fgrdAsociados.Row, "DUI"), "", sUsuario, sPassword, sSucursal)
                        ActualizaGrid()

                    End If
                Else
                    MsgBox("El Estado de Ingreso del Asociado no permite que este sea eliminado.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Módulo Asociados")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click

        If C1fgrdAsociados.Row <> -1 Then
            Dim frm As New frmIngresoAsoc2 'frmMsIngresoAsociados
            With frm
                .accion = 3
                .txtDui.Enabled = False
                .txtDui.Text = C1fgrdAsociados.Item(C1fgrdAsociados.Row, "DUI").ToString
                '.llenarDatos(C1fgrdAsociados.Item(C1fgrdAsociados.Row, "DUI").ToString)
                .ShowDialog()
            End With
            ActualizaGrid()

        End If

    End Sub

    Private Sub frmMAsociados_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class