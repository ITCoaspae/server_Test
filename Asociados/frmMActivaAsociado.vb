Public Class frmMActivaAsociado
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Friend WithEvents fgEstadoIngreso As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnActivar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBuscar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMActivaAsociado))
        Me.fgEstadoIngreso = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.rbDui = New System.Windows.Forms.RadioButton()
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
        Me.fgEstadoIngreso.BackColor = System.Drawing.Color.White
        Me.fgEstadoIngreso.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:97;Style:""TextAlign:RightCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{" &
    "Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "5{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgEstadoIngreso.Location = New System.Drawing.Point(23, 179)
        Me.fgEstadoIngreso.Name = "fgEstadoIngreso"
        Me.fgEstadoIngreso.Rows.Count = 2
        Me.fgEstadoIngreso.Rows.DefaultSize = 19
        Me.fgEstadoIngreso.Size = New System.Drawing.Size(688, 195)
        Me.fgEstadoIngreso.StyleInfo = resources.GetString("fgEstadoIngreso.StyleInfo")
        Me.fgEstadoIngreso.TabIndex = 26
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.txtNoSocio)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbNoSocio)
        Me.GroupBox2.Controls.Add(Me.rbDui)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 76)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Busqueda"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(607, 40)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 10
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(16, 48)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(152, 18)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(174, 48)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(152, 20)
        Me.txtNoSocio.TabIndex = 9
        Me.txtNoSocio.Visible = False
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Location = New System.Drawing.Point(332, 24)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(91, 24)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        Me.rbTodos.Visible = False
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.Location = New System.Drawing.Point(174, 24)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(152, 24)
        Me.rbNoSocio.TabIndex = 2
        Me.rbNoSocio.Text = "No.Socio de Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        Me.rbNoSocio.Visible = False
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Checked = True
        Me.rbDui.Location = New System.Drawing.Point(16, 24)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(152, 24)
        Me.rbDui.TabIndex = 0
        Me.rbDui.TabStop = True
        Me.rbDui.Text = "DUI de Asociado"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'btnActivar
        '
        Me.btnActivar.Location = New System.Drawing.Point(23, 145)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(75, 28)
        Me.btnActivar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnActivar.TabIndex = 11
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseSelectable = True
        Me.btnActivar.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(104, 145)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 28)
        Me.btnConsultar1.TabIndex = 12
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(185, 145)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(75, 28)
        Me.btnBuscar1.TabIndex = 13
        Me.btnBuscar1.Text = "Buscar"
        Me.btnBuscar1.UseSelectable = True
        Me.btnBuscar1.UseStyleColors = True
        Me.btnBuscar1.Visible = False
        '
        'frmMActivaAsociado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(737, 413)
        Me.Controls.Add(Me.btnBuscar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnActivar)
        Me.Controls.Add(Me.fgEstadoIngreso)
        Me.Name = "frmMActivaAsociado"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Mantenimiento - Activaci�n de Asociados"
        CType(Me.fgEstadoIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMActivaAsociado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ActualizaGrid()
        'Me.WindowState = FormWindowState.Normal
        txtNoSocio.Enabled = False
    End Sub

    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarEstadoIngreso("top 30 a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,b.EstadoIngreso as Estado", "b.EstadoIngreso=1", "a.DUI", sUsuario, sPassword, sSucursal)
            fgEstadoIngreso.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperaci�n de datos tabla Estado Ingreso Asociados" & "System Error: " & ex.Message.ToString(), "Error de Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        fgEstadoIngreso.Cols.Item(0).Width = 17
    End Sub


    Private Sub rbDui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
        Me.txtDui.Focus()
    End Sub

    Private Sub rbNoSocio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoSocio.CheckedChanged
        If rbNoSocio.Checked = True Then
            txtNoSocio.Enabled = True
        ElseIf rbNoSocio.Checked = False Then
            txtNoSocio.Enabled = False
        End If
    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub



    Private Sub fgEstadoIngreso_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgEstadoIngreso.DoubleClick
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
                ds = oAsoc.ConsultarEstadoIngreso("a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,b.EstadoIngreso as Estado", "a.Dui='" & Trim(txtDui.Text) & "'", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf rbNoSocio.Checked = True Then
                ds = oAsoc.ConsultarAsociado("Dui", "NoSocio='" & Trim(txtNoSocio.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)(0) Is DBNull.Value) Then
                        pDui = CStr(Filas.Item(0)("Dui"))
                    End If
                    ds = oAsoc.ConsultarEstadoIngreso("a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,b.EstadoIngreso as Estado", "a.Dui='" & Trim(pDui) & "'", "a.Dui", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbTodos.Checked = True Then
                ds = oAsoc.ConsultarEstadoIngreso("a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,b.EstadoIngreso as Estado", "", "a.Dui", sUsuario, sPassword, sSucursal)
            End If
            fgEstadoIngreso.Cols.Item(0).Width = 17
            fgEstadoIngreso.DataSource = ds.Tables(0)
            fgEstadoIngreso.Cols.Item(0).Width = 17
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click

        If fgEstadoIngreso.Row <> -1 Then
            Dim frm As frmMsActivaAsociado = New frmMsActivaAsociado
            frm.pEstado = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Estado")
            frm.btnGuardar1.Text = "&Guardar"
            frm.btnGuardar1.Visible = False
            frm.pCorrelativo = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Correlativo")
            frm.pDui = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "DUI")
            frm.btnGuardar1.Enabled = False
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
            txtNoSocio.Enabled = False
        End If
    End Sub

    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Estado Ingreso de Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, ds2 As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarEstadoIngreso("*", "", "a.DUI", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros
                fgEstadoIngreso.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oAsoc.ConsultarEstadoIngreso("a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,b.EstadoIngreso as Estado", "", "a.DUI", sUsuario, sPassword, sSucursal)
                fgEstadoIngreso.Cols.Item(0).Width = 17
                fgEstadoIngreso.DataSource = ds.Tables(0)
                fgEstadoIngreso.Cols.Item(0).Width = 17
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                fgEstadoIngreso.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oAsoc.ConsultarEstadoIngreso("a.Correlativo,a.NoSocio,a.Dui,b.Nombres,b.Apellido1,b.Apellido2,b.ApellidoCas,a.DocumentosCompletos,a.Fotografias,a.TituloFotocop,a.DuiFotoCop,a.NitFotocop,a.ReciboCuotaInicial,a.OtrosDescripcion,a.Otros,a.Observaciones,a.FechaCharla,a.Aprobado,a.FechaAprob,a.UsuarioAutoriza,a.FechaAutoriza,a.UsuarioGerenciaAutoriza,a.FecUsuGerenciaAutoriza,a.FecResolucionConsejo,a.Resolucion,a.Obs,a.ActaNo,a.FechaActa,a.ActivarAsociado,a.UsuarioActiva,a.FechaUsuarioActiva,a.ArchivoVinculoActa,b.EstadoIngreso as Estado", "a.Dui='" & sTexto & "'", "a.DUI", sUsuario, sPassword, sSucursal)
                fgEstadoIngreso.Cols.Item(0).Width = 17
                fgEstadoIngreso.DataSource = ds.Tables(0)
                fgEstadoIngreso.Cols.Item(0).Width = 17
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperaci�n de datos tabla Estado Ingreso de Asociados- " & "System Error: " & ex.Message.ToString() & " M�todo: " & ex.TargetSite.Name, "Error de Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        If fgEstadoIngreso.Row <> -1 Then
            Dim frm As frmMsActivaAsociado = New frmMsActivaAsociado
            frm.pEstado = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Estado")
            frm.btnGuardar1.Text = "&Guardar"
            frm.pCorrelativo = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Correlativo")
            frm.pDui = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "DUI")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
            txtNoSocio.Enabled = False
        End If
    End Sub
End Class