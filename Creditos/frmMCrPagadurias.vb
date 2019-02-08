Public Class frmMCrPagadurias
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim creditos As New wrCredito.wsLibCred
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton


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
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents rbDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents dgPagadurias As System.Windows.Forms.DataGridView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.rbDescripcion = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.dgPagadurias = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.lblEncabezado = New System.Windows.Forms.Label()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgPagadurias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(273, 27)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(76, 24)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(76, 56)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(273, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(76, 30)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(152, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'rbDescripcion
        '
        Me.rbDescripcion.BackColor = System.Drawing.Color.White
        Me.rbDescripcion.Location = New System.Drawing.Point(6, 53)
        Me.rbDescripcion.Name = "rbDescripcion"
        Me.rbDescripcion.Size = New System.Drawing.Size(67, 24)
        Me.rbDescripcion.TabIndex = 2
        Me.rbDescripcion.Text = "&Nombre"
        Me.rbDescripcion.UseVisualStyleBackColor = False
        '
        'rbCodigo
        '
        Me.rbCodigo.BackColor = System.Drawing.Color.White
        Me.rbCodigo.Location = New System.Drawing.Point(6, 30)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(64, 24)
        Me.rbCodigo.TabIndex = 0
        Me.rbCodigo.Text = "&Código"
        Me.rbCodigo.UseVisualStyleBackColor = False
        '
        'dgPagadurias
        '
        Me.dgPagadurias.AllowUserToAddRows = False
        Me.dgPagadurias.AllowUserToDeleteRows = False
        Me.dgPagadurias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPagadurias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagadurias.Location = New System.Drawing.Point(23, 188)
        Me.dgPagadurias.Name = "dgPagadurias"
        Me.dgPagadurias.ReadOnly = True
        Me.dgPagadurias.Size = New System.Drawing.Size(453, 206)
        Me.dgPagadurias.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MetroButton1)
        Me.Panel1.Controls.Add(Me.rbTodos)
        Me.Panel1.Controls.Add(Me.lblEncabezado)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.rbCodigo)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.rbDescripcion)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 85)
        Me.Panel1.TabIndex = 36
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(355, 48)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 204
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.Color.Teal
        Me.lblEncabezado.Location = New System.Drawing.Point(3, 9)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(176, 18)
        Me.lblEncabezado.TabIndex = 1
        Me.lblEncabezado.Text = "Filtrar Pagadurías por:"
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(266, 154)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 207
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(185, 154)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 206
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(104, 154)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(75, 28)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 205
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 154)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 204
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMCrPagadurias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(499, 433)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgPagadurias)
        Me.Name = "frmMCrPagadurias"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Pagadurías"
        CType(Me.dgPagadurias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMCrPagadurias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ActualizaGrid()
        Me.WindowState = FormWindowState.Normal
        txtCodigo.Enabled = False
        txtDescripcion.Enabled = False
    End Sub
    Protected Sub ActualizarGrid(ByVal codPagaduria As String, ByVal nombre As String, ByVal opcion As Integer)
        Try
            Dim dts As New DataSet
            dts = creditos.consultarPrPagadurias(codPagaduria, nombre, opcion)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.dgPagadurias.DataSource = dts.Tables(0)
                    estiloDg()
                End If
            Else
                MsgBox("Error, no se pudo recuperar la información, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Créditos")
            End If

        Catch ex As Exception
            MsgBox("Error, no se pudo recuperar la información, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Créditos")
        End Try

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

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        btnConsultar1_Click(sender, e)
    End Sub
    Protected Sub estiloDg()

        Me.dgPagadurias.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPagadurias.Columns("NIT").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPagadurias.Columns("idGiroEmpresa").Visible = False
        Me.dgPagadurias.Columns("idTipoEmp").Visible = False
        Me.dgPagadurias.Columns("fechaActu").Visible = False
        Me.dgPagadurias.Columns("usuarioActu").Visible = False
        Me.dgPagadurias.Columns("CodPagaduria").HeaderText = "Código"
        Me.dgPagadurias.Columns("categoria").HeaderText = "Categoria"
        Me.dgPagadurias.Columns("Direccion").HeaderText = "Dirección"
        Me.dgPagadurias.Columns("telefono").HeaderText = "Teléfono"
        Me.dgPagadurias.Columns("GiroEmpresa").HeaderText = "Giro"
        Me.dgPagadurias.Columns("tipoEmpresa").HeaderText = "Tipo"
        Me.dgPagadurias.Columns("FirmaSello").HeaderText = "Firma/Sello"
        Me.dgPagadurias.Columns("fechaFundacion").HeaderText = "Fundación"
        Me.dgPagadurias.Columns("CapitalSocial").HeaderText = "Capital Social"
        Me.dgPagadurias.Columns("RegistroEmpresa").HeaderText = "No. Registro"
        Me.dgPagadurias.Columns("sitioWeb").HeaderText = "Sitio Web"
        Me.dgPagadurias.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgPagadurias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgPagadurias.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke


    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.rbCodigo.Checked = True Then
                ActualizarGrid(txtCodigo.Text, "", 1)
            ElseIf Me.rbDescripcion.Checked = True Then
                ActualizarGrid("", Me.txtDescripcion.Text.Trim, 2)
            ElseIf Me.rbTodos.Checked = True Then
                ActualizarGrid("", 0, 0)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As New frmMsCrPagadurias
            With frm
                .accion = 1
                '.lblTitulo.Text = "Ingresar Nueva Pagaduría"
                .ShowDialog()
            End With
            ActualizarGrid("", "", 0)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If Me.dgPagadurias.CurrentRow.Index <> -1 Then
                Dim frm As New frmMsCrPagadurias
                With frm
                    .cbGiro.DisplayMember = "descripcion"
                    .cbGiro.ValueMember = "idGiroEmpresa"
                    .cbTipoEmpresa.DisplayMember = "descripcion"
                    .cbTipoEmpresa.ValueMember = "idTipoEmp"
                    .llenarGiroEmpresa()
                    .llenarTipoEmpresa()
                    .Text = "Modificar Pagaduría"
                    .pCodigo = Me.dgPagadurias.Item("codPagaduria", Me.dgPagadurias.CurrentRow.Index).Value
                    .pCodigo = Me.dgPagadurias.Item("codPagaduria", Me.dgPagadurias.CurrentRow.Index).Value
                    .txtCodigo.Text = Me.dgPagadurias.Item("codPagaduria", Me.dgPagadurias.CurrentRow.Index).Value.ToString.Trim
                    .accion = 2
                    .txtNombre.Text = Me.dgPagadurias.Item("Nombre", Me.dgPagadurias.CurrentRow.Index).Value
                    .txtDireccion.Text = IIf(Me.dgPagadurias.Item("Direccion", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgPagadurias.Item("Direccion", Me.dgPagadurias.CurrentRow.Index).Value)
                    .mtTelefono.Text = IIf(Me.dgPagadurias.Item("telefono", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgPagadurias.Item("telefono", Me.dgPagadurias.CurrentRow.Index).Value)
                    .cbGiro.SelectedValue = IIf(Me.dgPagadurias.Item("idGiroEmpresa", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, 0, Me.dgPagadurias.Item("idGiroEmpresa", Me.dgPagadurias.CurrentRow.Index).Value)
                    .cbTipoEmpresa.SelectedValue = IIf(Me.dgPagadurias.Item("idTipoEmp", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, 0, Me.dgPagadurias.Item("idTipoEmp", Me.dgPagadurias.CurrentRow.Index).Value)
                    .chkExperiencia.Checked = IIf(Me.dgPagadurias.Item("Experiencia", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, False, Me.dgPagadurias.Item("Experiencia", Me.dgPagadurias.CurrentRow.Index).Value)
                    .chkFirmaSello.Checked = IIf(Me.dgPagadurias.Item("FirmaSello", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, False, Me.dgPagadurias.Item("FirmaSello", Me.dgPagadurias.CurrentRow.Index).Value)
                    .dtpFechaFundacion.Value = IIf(Me.dgPagadurias.Item("fechaFundacion", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, Now, Me.dgPagadurias.Item("fechaFundacion", Me.dgPagadurias.CurrentRow.Index).Value)
                    .txtCapiSocial.Value = IIf(Me.dgPagadurias.Item("CapitalSocial", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, 0, Me.dgPagadurias.Item("CapitalSocial", Me.dgPagadurias.CurrentRow.Index).Value)
                    .txtNoRegistro.Text = IIf(Me.dgPagadurias.Item("RegistroEmpresa", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgPagadurias.Item("RegistroEmpresa", Me.dgPagadurias.CurrentRow.Index).Value)
                    .mtNit.Text = IIf(Me.dgPagadurias.Item("NIT", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgPagadurias.Item("NIT", Me.dgPagadurias.CurrentRow.Index).Value)
                    .txtSitioWeb.Text = IIf(Me.dgPagadurias.Item("NIT", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgPagadurias.Item("sitioWeb", Me.dgPagadurias.CurrentRow.Index).Value)
                    .ShowDialog()
                End With
                If Me.rbCodigo.Checked = True Then
                    ActualizarGrid(txtCodigo.Text, "", 1)
                ElseIf Me.rbDescripcion.Checked = True Then
                    ActualizarGrid("", Me.txtDescripcion.Text.Trim, 2)
                ElseIf Me.rbTodos.Checked = True Then
                    ActualizarGrid("", 0, 0)
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If Me.dgPagadurias.CurrentRow.Index <> -1 Then
                If MsgBox("¿Desea eliminar la Pagaduría seleccionada?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Pagaduría") = MsgBoxResult.Yes Then
                    creditos.EliminarPagaduria(Me.dgPagadurias.Item("CodPagaduria", Me.dgPagadurias.CurrentRow.Index).Value, sUsuario, sPassword, sSucursal)
                    ActualizarGrid("", "", 0)
                End If
            End If

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If Me.dgPagadurias.CurrentRow.Index <> -1 Then
                Dim frm As New frmMsCrPagadurias
                With frm
                    .cbGiro.DisplayMember = "descripcion"
                    .cbGiro.ValueMember = "idGiroEmpresa"
                    .cbTipoEmpresa.DisplayMember = "descripcion"
                    .cbTipoEmpresa.ValueMember = "idTipoEmp"
                    .llenarGiroEmpresa()
                    .llenarTipoEmpresa()
                    .Text = "Consultar Pagaduría"
                    .pCodigo = Me.dgPagadurias.Item("codPagaduria", Me.dgPagadurias.CurrentRow.Index).Value
                    .txtCodigo.Text = Me.dgPagadurias.Item("codPagaduria", Me.dgPagadurias.CurrentRow.Index).Value.ToString.Trim
                    .accion = 2
                    .txtNombre.Text = Me.dgPagadurias.Item("Nombre", Me.dgPagadurias.CurrentRow.Index).Value
                    .txtDireccion.Text = IIf(Me.dgPagadurias.Item("Direccion", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgPagadurias.Item("Direccion", Me.dgPagadurias.CurrentRow.Index).Value)
                    .mtTelefono.Text = IIf(Me.dgPagadurias.Item("telefono", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgPagadurias.Item("telefono", Me.dgPagadurias.CurrentRow.Index).Value)
                    .cbGiro.SelectedValue = IIf(Me.dgPagadurias.Item("idGiroEmpresa", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, 0, Me.dgPagadurias.Item("idGiroEmpresa", Me.dgPagadurias.CurrentRow.Index).Value)
                    .cbTipoEmpresa.SelectedValue = IIf(Me.dgPagadurias.Item("idTipoEmp", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, 0, Me.dgPagadurias.Item("idTipoEmp", Me.dgPagadurias.CurrentRow.Index).Value)
                    .chkExperiencia.Checked = IIf(Me.dgPagadurias.Item("Experiencia", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, False, Me.dgPagadurias.Item("Experiencia", Me.dgPagadurias.CurrentRow.Index).Value)
                    .chkFirmaSello.Checked = IIf(Me.dgPagadurias.Item("FirmaSello", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, False, Me.dgPagadurias.Item("FirmaSello", Me.dgPagadurias.CurrentRow.Index).Value)
                    .dtpFechaFundacion.Value = IIf(Me.dgPagadurias.Item("fechaFundacion", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, Now, Me.dgPagadurias.Item("fechaFundacion", Me.dgPagadurias.CurrentRow.Index).Value)
                    .txtCapiSocial.Value = IIf(Me.dgPagadurias.Item("CapitalSocial", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, 0, Me.dgPagadurias.Item("CapitalSocial", Me.dgPagadurias.CurrentRow.Index).Value)
                    .txtNoRegistro.Text = IIf(Me.dgPagadurias.Item("RegistroEmpresa", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgPagadurias.Item("RegistroEmpresa", Me.dgPagadurias.CurrentRow.Index).Value)
                    .mtNit.Text = IIf(Me.dgPagadurias.Item("NIT", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgPagadurias.Item("NIT", Me.dgPagadurias.CurrentRow.Index).Value)
                    .txtSitioWeb.Text = IIf(Me.dgPagadurias.Item("NIT", Me.dgPagadurias.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgPagadurias.Item("sitioWeb", Me.dgPagadurias.CurrentRow.Index).Value)
                    .cbGiro.Enabled = False
                    .cbTipoEmpresa.Enabled = False
                    .txtCodigo.ReadOnly = True
                    .txtNombre.ReadOnly = True
                    .txtDireccion.ReadOnly = True
                    .mtTelefono.ReadOnly = True
                    .cbGiro.Enabled = False
                    .cbTipoEmpresa.Enabled = False
                    .chkExperiencia.Enabled = False
                    .chkFirmaSello.Enabled = False
                    .dtpFechaFundacion.Enabled = False
                    .txtCapiSocial.ReadOnly = True
                    .txtNoRegistro.ReadOnly = True
                    .mtNit.ReadOnly = True
                    .txtSitioWeb.ReadOnly = True
                    .btnGuardar1.Visible = False
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar_Click(sender, e)
    'End Sub

    'Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar_Click(sender, e)
    'End Sub

End Class