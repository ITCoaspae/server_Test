Public Class frmMPartidasIntegracion
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
    Friend WithEvents cmbTipoPartidas As System.Windows.Forms.ComboBox
    Friend WithEvents rbNumero As System.Windows.Forms.RadioButton
    Friend WithEvents rbDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAgregar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar As MetroFramework.Controls.MetroButton
    Friend WithEvents rbTipo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPartidasIntegracion))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.rbDescripcion = New System.Windows.Forms.RadioButton()
        Me.cmbTipoPartidas = New System.Windows.Forms.ComboBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.rbTipo = New System.Windows.Forms.RadioButton()
        Me.rbNumero = New System.Windows.Forms.RadioButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnMostrar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnAgregar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(28, 237)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(708, 225)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 14
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(349, 81)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(183, 22)
        Me.txtDescripcion.TabIndex = 5
        '
        'rbDescripcion
        '
        Me.rbDescripcion.BackColor = System.Drawing.Color.White
        Me.rbDescripcion.Location = New System.Drawing.Point(349, 47)
        Me.rbDescripcion.Name = "rbDescripcion"
        Me.rbDescripcion.Size = New System.Drawing.Size(183, 28)
        Me.rbDescripcion.TabIndex = 4
        Me.rbDescripcion.Text = "Descripción:"
        Me.rbDescripcion.UseVisualStyleBackColor = False
        '
        'cmbTipoPartidas
        '
        Me.cmbTipoPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPartidas.Location = New System.Drawing.Point(160, 81)
        Me.cmbTipoPartidas.Name = "cmbTipoPartidas"
        Me.cmbTipoPartidas.Size = New System.Drawing.Size(182, 24)
        Me.cmbTipoPartidas.TabIndex = 3
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Location = New System.Drawing.Point(18, 82)
        Me.txtNumero.MaxLength = 6
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(134, 22)
        Me.txtNumero.TabIndex = 1
        '
        'rbTipo
        '
        Me.rbTipo.BackColor = System.Drawing.Color.White
        Me.rbTipo.Location = New System.Drawing.Point(160, 47)
        Me.rbTipo.Name = "rbTipo"
        Me.rbTipo.Size = New System.Drawing.Size(182, 28)
        Me.rbTipo.TabIndex = 2
        Me.rbTipo.Text = "Tipo Comprobante"
        Me.rbTipo.UseVisualStyleBackColor = False
        '
        'rbNumero
        '
        Me.rbNumero.BackColor = System.Drawing.Color.White
        Me.rbNumero.Checked = True
        Me.rbNumero.Location = New System.Drawing.Point(18, 47)
        Me.rbNumero.Name = "rbNumero"
        Me.rbNumero.Size = New System.Drawing.Size(134, 28)
        Me.rbNumero.TabIndex = 0
        Me.rbNumero.TabStop = True
        Me.rbNumero.Text = "Número"
        Me.rbNumero.UseVisualStyleBackColor = False
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btnMostrar)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.txtDescripcion)
        Me.MetroPanel1.Controls.Add(Me.rbDescripcion)
        Me.MetroPanel1.Controls.Add(Me.rbNumero)
        Me.MetroPanel1.Controls.Add(Me.cmbTipoPartidas)
        Me.MetroPanel1.Controls.Add(Me.txtNumero)
        Me.MetroPanel1.Controls.Add(Me.rbTipo)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 12
        Me.MetroPanel1.Location = New System.Drawing.Point(28, 73)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(700, 117)
        Me.MetroPanel1.TabIndex = 15
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 12
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(563, 73)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(90, 32)
        Me.btnMostrar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar.TabIndex = 17
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar.UseSelectable = True
        Me.btnMostrar.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(18, 10)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(129, 20)
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "Buscar Registro por"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(28, 197)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(90, 33)
        Me.btnAgregar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar.TabIndex = 16
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar.UseSelectable = True
        Me.btnAgregar.UseStyleColors = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(125, 197)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 33)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar.TabIndex = 17
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar.UseSelectable = True
        Me.btnModificar.UseStyleColors = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(222, 197)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(90, 33)
        Me.btnConsultar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar.TabIndex = 18
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar.UseSelectable = True
        Me.btnConsultar.UseStyleColors = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(319, 197)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 33)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar.UseSelectable = True
        Me.btnEliminar.UseStyleColors = True
        '
        'frmMPartidasIntegracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(764, 545)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.fg)
        Me.MinimumSize = New System.Drawing.Size(760, 523)
        Me.Name = "frmMPartidasIntegracion"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Párametros de partidas de integración contable"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMPartidasIntegracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oPartida As New wrConta.wsLibContab, oApp As New wrAdmin.wsLibAdmin
        Dim dsTipo As New DataSet, dr As DataRow

        dsTipo = oPartida.ObtenerTipoPartidasAut(oApp.Fecha.Year, sUsuario, sPassword, sSucursal)
        For Each dr In dsTipo.Tables(0).Rows
            cmbTipoPartidas.Items.Add(CStr(dr("Prefijo")) & " - " & CStr(dr("Descripcion")))
        Next
        cmbTipoPartidas.SelectedIndex = 0
        ActualizaGrid()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

    End Sub

    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "Código"
        fg.Cols.Item(2).Caption = "Descripcion"
        fg.Cols.Item(3).Caption = "Prefijo"

        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 500
        fg.Cols.Item(3).Width = 100

    End Sub

    Private Sub ActualizaGrid()
        Dim oCtb As New wrConta.wsLibContab, ds As Data.DataSet = New Data.DataSet
        Try
            ds = oCtb.ConsultarParametroPartidaIntegracion("*", "", "CodPartidaIntegrac", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Partidas de Integración." & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Encabezado()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        btnConsultar_Click(sender, e)
    End Sub



    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub cmbTipoPartidas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTipoPartidas.KeyDown
        If e.KeyData = Keys.Return Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim oCtb As New wrConta.wsLibContab, ds As New Data.DataSet
        'Dim Filas As Data.DataRowCollection, pCodigo As String

        If rbNumero.Checked = True Then
            ds = oCtb.ConsultarParametroPartidaIntegracion("*", "CodPartidaIntegrac='" & Me.txtNumero.Text.Trim & "'", "CodPartidaIntegrac", sUsuario, sPassword, sSucursal)
        ElseIf rbDescripcion.Checked = True Then
            ds = oCtb.ConsultarParametroPartidaIntegracion("*", "Descripcion like '%" & Trim(txtDescripcion.Text) & "%'", "CodPartidaIntegrac", sUsuario, sPassword, sSucursal)
        ElseIf rbTipo.Checked = True Then
            ds = oCtb.ConsultarParametroPartidaIntegracion("*", "Prefijo='" & Me.cmbTipoPartidas.Text.Substring(0, 2) & "'", "CodPartidaIntegrac", sUsuario, sPassword, sSucursal)
        End If
        fg.DataSource = ds.Tables(0)
        Encabezado()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As frmMsPartidasIntegracion = New frmMsPartidasIntegracion
        frm.Accion = "Agregar"
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        ActualizaGrid()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If fg.Row <> -1 Then
            Dim frm As frmMsPartidasIntegracion = New frmMsPartidasIntegracion
            frm.Accion = "Modificar"
            frm.Codigo = fg.Item(fg.Row, "CodPartidaIntegrac")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        End If
    End Sub

    Private Sub btnConsultar2_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If fg.Row <> -1 Then
            Dim frm As frmMsPartidasIntegracion = New frmMsPartidasIntegracion
            frm.Accion = "Modificar"
            frm.Codigo = fg.Item(fg.Row, "CodPartidaIntegrac")
            frm.btnNuevo.Enabled = False
            frm.btnModificar.Text = "&Consulta"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        End If
    End Sub

    Private Sub btnEliminar2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If fg.Row <> -1 Then
            If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Parámetro") = MsgBoxResult.Yes Then
                Dim oCtb As New wrConta.wsLibContab
                oCtb.EliminaParametroPartidaIntegracion(fg.Item(fg.Row, "CodPartidaIntegrac"), sUsuario, sPassword, sSucursal)
                ActualizaGrid()
            End If
        End If
    End Sub
End Class