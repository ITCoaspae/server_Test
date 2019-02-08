Public Class frmEstadoIngAsociado
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents fgEstadoIngreso As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBuscar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnActivar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoIngAsociado))
        Me.fgEstadoIngreso = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnActivar = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnBuscar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fgEstadoIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fgEstadoIngreso
        '
        Me.fgEstadoIngreso.AllowEditing = False
        Me.fgEstadoIngreso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgEstadoIngreso.BackColor = System.Drawing.Color.White
        Me.fgEstadoIngreso.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:45;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:97;TextAlign:RightCenter;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:150" &
    ";}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "5{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgEstadoIngreso.Location = New System.Drawing.Point(23, 217)
        Me.fgEstadoIngreso.Name = "fgEstadoIngreso"
        Me.fgEstadoIngreso.Rows.Count = 2
        Me.fgEstadoIngreso.Size = New System.Drawing.Size(681, 187)
        Me.fgEstadoIngreso.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgEstadoIngreso.Styles"))
        Me.fgEstadoIngreso.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.txtNoSocio)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbNoSocio)
        Me.GroupBox2.Controls.Add(Me.rbDui)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(681, 114)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar por:"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(6, 47)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(152, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(299, 47)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(236, 20)
        Me.txtNombres.TabIndex = 6
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(164, 18)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(152, 23)
        Me.rbNombres.TabIndex = 4
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Enabled = False
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(164, 47)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(129, 21)
        Me.cbNombres.TabIndex = 5
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(541, 46)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(111, 20)
        Me.txtNoSocio.TabIndex = 8
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(8, 86)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(72, 24)
        Me.rbTodos.TabIndex = 7
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.Location = New System.Drawing.Point(540, 17)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(112, 24)
        Me.rbNoSocio.TabIndex = 2
        Me.rbNoSocio.Text = "No. de Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Location = New System.Drawing.Point(6, 18)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(152, 24)
        Me.rbDui.TabIndex = 0
        Me.rbDui.Text = "DUI de Asociado"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(577, 72)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.TabIndex = 9
        Me.MetroButton1.Text = "Mostrar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnActivar
        '
        Me.btnActivar.Location = New System.Drawing.Point(23, 183)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(75, 28)
        Me.btnActivar.TabIndex = 10
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseSelectable = True
        Me.btnActivar.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(106, 183)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 28)
        Me.btnConsultar1.TabIndex = 11
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(187, 183)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(75, 28)
        Me.btnBuscar1.TabIndex = 12
        Me.btnBuscar1.Text = "Buscar"
        Me.btnBuscar1.UseSelectable = True
        Me.btnBuscar1.UseStyleColors = True
        '
        'frmEstadoIngAsociado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(725, 436)
        Me.Controls.Add(Me.btnBuscar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnActivar)
        Me.Controls.Add(Me.fgEstadoIngreso)
        Me.Name = "frmEstadoIngAsociado"
        Me.Text = "Mantenimiento - Activación de Aspirantes"
        CType(Me.fgEstadoIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmEstadoIngAsociado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ActualizaGrid()
        'Me.WindowState = FormWindowState.Normal
        txtDui.Enabled = False
        txtNoSocio.Enabled = False
    End Sub

    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarEstadoIngreso("top 30 a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,EstadoIngreso as Estado", "EstadoIngreso=0", "a.DUI", sUsuario, sPassword, sSucursal)
            fgEstadoIngreso.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Estado Ingreso Asociados" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        fgEstadoIngreso.Cols.Item(0).Width = 45
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

    'Private Sub txtNoSocio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    'End Sub



    'Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    '    Dim frm As frmMsEstadoIngAsociado = New frmMsEstadoIngAsociado
    '    frm.btnSave.Text = "&Guardar"
    '    frm.StartPosition = FormStartPosition.CenterScreen
    '    frm.ShowDialog()
    '    ActualizaGrid()
    'End Sub


    Private Sub fgEstadoIngreso_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgEstadoIngreso.DoubleClick
        btnConsultar1_Click(sender, e)
    End Sub


    Private Sub rbNombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        If Me.rbNombres.Checked = True Then
            Me.cbNombres.Enabled = True
            Me.txtNombres.Enabled = True
        ElseIf Me.rbNombres.Checked = False Then
            Me.cbNombres.Enabled = False
            Me.txtNombres.Enabled = False
        End If
        Me.cbNombres.Focus()
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

    'Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnConsultar1 _Click(sender, e)
    'End Sub

    'Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    'End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
            Dim Filas As Data.DataRowCollection, pDui As String

            oAsoc = New wrAsociados.wsLibAsoc
            If rbDui.Checked = True Then
                ds = oAsoc.ConsultarEstadoIngreso("top 30 a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,EstadoIngreso as Estado", "a.Dui='" & Trim(txtDui.Text) & "'", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf rbNoSocio.Checked = True Then
                ds = oAsoc.ConsultarAsociado("Dui", "NoSocio='" & Trim(txtNoSocio.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)(0) Is DBNull.Value) Then
                        pDui = CStr(Filas.Item(0)("Dui"))
                    End If
                    ds = oAsoc.ConsultarEstadoIngreso("top 30 a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,EstadoIngreso as Estado", "a.Dui='" & Trim(pDui) & "'", "a.Dui", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbTodos.Checked = True Then
                ds = oAsoc.ConsultarEstadoIngreso("top 30 a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,EstadoIngreso as Estado", "", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf rbNombres.Checked = True Then
                If cbNombres.SelectedIndex = 0 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido1 = '" & Trim(txtNombres.Text) & "'", "Apellido1,Apellido2", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 1 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido2 = '" & Trim(txtNombres.Text) & "'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 2 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Nombres ='" & Trim(txtNombres.Text) & "'", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
                For Each dr In ds.Tables(0).Rows
                    ds = oAsoc.ConsultarEstadoIngreso("top 30 a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,EstadoIngreso as Estado", "a.Dui='" & dr("Dui") & "'", "a.Dui", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        fgEstadoIngreso.Cols.Item(0).Width = 17
                        fgEstadoIngreso.DataSource = ds.Tables(0)
                        fgEstadoIngreso.Cols.Item(0).Width = 17
                        Exit Sub
                    End If
                Next
            End If
            fgEstadoIngreso.Cols.Item(0).Width = 45
            fgEstadoIngreso.DataSource = ds.Tables(0)
            fgEstadoIngreso.Cols.Item(0).Width = 45

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        Try
            If fgEstadoIngreso.Row <> -1 Then
                Dim frm As frmMsEstadoIngAsociado = New frmMsEstadoIngAsociado
                frm.pEstado = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Estado")
                'frm.btnSave.Text = "&Guardar"
                frm.pCorrelativo = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Correlativo")
                frm.pNoSocio = IIf(fgEstadoIngreso.Item(fgEstadoIngreso.Row, "NoSocio") Is DBNull.Value, "", fgEstadoIngreso.Item(fgEstadoIngreso.Row, "NoSocio"))
                frm.pDui = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "DUI")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                txtDui.Enabled = False
                txtNoSocio.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If fgEstadoIngreso.Row <> -1 Then
                Dim frm As frmMsEstadoIngAsociado = New frmMsEstadoIngAsociado
                frm.pEstado = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Estado")
                ' frm.btnSave.Text = "&Guardar"
                ' frm.btnSave.Visible = False
                frm.pCorrelativo = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Correlativo")
                frm.pNoSocio = IIf(fgEstadoIngreso.Item(fgEstadoIngreso.Row, "NoSocio") Is DBNull.Value, "", fgEstadoIngreso.Item(fgEstadoIngreso.Row, "NoSocio"))
                frm.pDui = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "DUI")
                'frm.btnSave.Enabled = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                txtDui.Enabled = False
                txtNoSocio.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        Dim frm As New frmAGenerico
        Dim sTexto As String

        frm.Text = "Buscar Estado Ingreso de Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, ds2 As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarEstadoIngreso("top 30 a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,EstadoIngreso as Estado", "EstadoIngreso=0", "a.DUI", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros
                fgEstadoIngreso.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oAsoc.ConsultarEstadoIngreso("top 30 a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,EstadoIngreso as Estado", "EstadoIngreso=0", "a.DUI", sUsuario, sPassword, sSucursal)
                fgEstadoIngreso.Cols.Item(0).Width = 45
                fgEstadoIngreso.DataSource = ds.Tables(0)
                fgEstadoIngreso.Cols.Item(0).Width = 45
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                fgEstadoIngreso.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oAsoc.ConsultarEstadoIngreso("top 30 a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,EstadoIngreso as Estado", "a.Dui='" & sTexto & "' and EstadoIngreso=0", "a.DUI", sUsuario, sPassword, sSucursal)
                fgEstadoIngreso.Cols.Item(0).Width = 45
                fgEstadoIngreso.DataSource = ds.Tables(0)
                fgEstadoIngreso.Cols.Item(0).Width = 45
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Estado Ingreso de Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class