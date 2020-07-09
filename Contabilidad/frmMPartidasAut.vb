Public Class frmMPartidasAut
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form : 
    Public rsc As System.Resources.ResourceManager

    Private dsPartidas As DataSet, vIdPartida As String, vPrefijo As String, vTipoPartida As String, vAutorizado As String
    Friend WithEvents ChkTrasladar As System.Windows.Forms.CheckBox
    Friend WithEvents btnAceptarLin2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAnular2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnTrasladar2 As MetroFramework.Controls.MetroButton
    Friend WithEvents trasladar2 As DataGridViewCheckBoxColumn
    Friend WithEvents dgPartAut2 As DataGridView
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumeroIni As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumeroFin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpFechaIni As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaFin As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmbTipoPartidas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbEstado As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Dim Conta As New wrConta.wsLibContab
    Friend WithEvents chkEstado As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkTipo As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkFecha As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPartida As MetroFramework.Controls.MetroCheckBox
    Dim asociados As New wrAsociados.wsLibAsoc

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ChkTrasladar = New System.Windows.Forms.CheckBox()
        Me.btnAceptarLin2 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar2 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar2 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir2 = New MetroFramework.Controls.MetroButton()
        Me.btnAnular2 = New MetroFramework.Controls.MetroButton()
        Me.btnTrasladar2 = New MetroFramework.Controls.MetroButton()
        Me.dgPartAut2 = New System.Windows.Forms.DataGridView()
        Me.trasladar2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumeroIni = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumeroFin = New MetroFramework.Controls.MetroTextBox()
        Me.dtpFechaIni = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaFin = New MetroFramework.Controls.MetroDateTime()
        Me.cmbTipoPartidas = New MetroFramework.Controls.MetroComboBox()
        Me.cmbEstado = New MetroFramework.Controls.MetroComboBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.chkEstado = New MetroFramework.Controls.MetroCheckBox()
        Me.chkTipo = New MetroFramework.Controls.MetroCheckBox()
        Me.chkFecha = New MetroFramework.Controls.MetroCheckBox()
        Me.chkPartida = New MetroFramework.Controls.MetroCheckBox()
        CType(Me.dgPartAut2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkTrasladar
        '
        Me.ChkTrasladar.AutoSize = True
        Me.ChkTrasladar.Location = New System.Drawing.Point(21, 324)
        Me.ChkTrasladar.Name = "ChkTrasladar"
        Me.ChkTrasladar.Size = New System.Drawing.Size(114, 21)
        Me.ChkTrasladar.TabIndex = 1
        Me.ChkTrasladar.Text = "MarcarTodos"
        Me.ChkTrasladar.UseVisualStyleBackColor = True
        '
        'btnAceptarLin2
        '
        Me.btnAceptarLin2.Location = New System.Drawing.Point(540, 191)
        Me.btnAceptarLin2.Name = "btnAceptarLin2"
        Me.btnAceptarLin2.Size = New System.Drawing.Size(90, 32)
        Me.btnAceptarLin2.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAceptarLin2.TabIndex = 0
        Me.btnAceptarLin2.Text = "Buscar"
        Me.btnAceptarLin2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAceptarLin2.UseSelectable = True
        Me.btnAceptarLin2.UseStyleColors = True
        '
        'btnModificar2
        '
        Me.btnModificar2.Location = New System.Drawing.Point(160, 324)
        Me.btnModificar2.Name = "btnModificar2"
        Me.btnModificar2.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar2.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar2.TabIndex = 2
        Me.btnModificar2.Text = "Modificar"
        Me.btnModificar2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar2.UseSelectable = True
        Me.btnModificar2.UseStyleColors = True
        '
        'btnEliminar2
        '
        Me.btnEliminar2.Location = New System.Drawing.Point(256, 324)
        Me.btnEliminar2.Name = "btnEliminar2"
        Me.btnEliminar2.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar2.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar2.TabIndex = 3
        Me.btnEliminar2.Text = "Eliminar"
        Me.btnEliminar2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar2.UseSelectable = True
        Me.btnEliminar2.UseStyleColors = True
        '
        'btnImprimir2
        '
        Me.btnImprimir2.Location = New System.Drawing.Point(352, 324)
        Me.btnImprimir2.Name = "btnImprimir2"
        Me.btnImprimir2.Size = New System.Drawing.Size(90, 32)
        Me.btnImprimir2.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir2.TabIndex = 4
        Me.btnImprimir2.Text = "Imprimir"
        Me.btnImprimir2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir2.UseSelectable = True
        Me.btnImprimir2.UseStyleColors = True
        '
        'btnAnular2
        '
        Me.btnAnular2.Location = New System.Drawing.Point(448, 324)
        Me.btnAnular2.Name = "btnAnular2"
        Me.btnAnular2.Size = New System.Drawing.Size(90, 32)
        Me.btnAnular2.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAnular2.TabIndex = 5
        Me.btnAnular2.Text = "Anular"
        Me.btnAnular2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAnular2.UseSelectable = True
        Me.btnAnular2.UseStyleColors = True
        '
        'btnTrasladar2
        '
        Me.btnTrasladar2.Location = New System.Drawing.Point(544, 324)
        Me.btnTrasladar2.Name = "btnTrasladar2"
        Me.btnTrasladar2.Size = New System.Drawing.Size(90, 32)
        Me.btnTrasladar2.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnTrasladar2.TabIndex = 6
        Me.btnTrasladar2.Text = "Trasladar"
        Me.btnTrasladar2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnTrasladar2.UseSelectable = True
        Me.btnTrasladar2.UseStyleColors = True
        '
        'dgPartAut2
        '
        Me.dgPartAut2.AllowUserToAddRows = False
        Me.dgPartAut2.AllowUserToDeleteRows = False
        Me.dgPartAut2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPartAut2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPartAut2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgPartAut2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgPartAut2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPartAut2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trasladar2})
        Me.dgPartAut2.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgPartAut2.Location = New System.Drawing.Point(23, 362)
        Me.dgPartAut2.Name = "dgPartAut2"
        Me.dgPartAut2.ReadOnly = True
        Me.dgPartAut2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgPartAut2.RowTemplate.Height = 24
        Me.dgPartAut2.Size = New System.Drawing.Size(708, 169)
        Me.dgPartAut2.TabIndex = 7
        '
        'trasladar2
        '
        Me.trasladar2.Frozen = True
        Me.trasladar2.HeaderText = "Trasladar"
        Me.trasladar2.Name = "trasladar2"
        Me.trasladar2.ReadOnly = True
        Me.trasladar2.Width = 75
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(10, 13)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(124, 20)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Buscar Partida Por:"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(44, 58)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(102, 20)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Numero Inicial:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(358, 58)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(96, 20)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Numero Final:"
        '
        'txtNumeroIni
        '
        Me.txtNumeroIni.Lines = New String(-1) {}
        Me.txtNumeroIni.Location = New System.Drawing.Point(152, 58)
        Me.txtNumeroIni.MaxLength = 32767
        Me.txtNumeroIni.Name = "txtNumeroIni"
        Me.txtNumeroIni.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroIni.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroIni.SelectedText = ""
        Me.txtNumeroIni.Size = New System.Drawing.Size(170, 23)
        Me.txtNumeroIni.TabIndex = 4
        Me.txtNumeroIni.UseSelectable = True
        '
        'txtNumeroFin
        '
        Me.txtNumeroFin.Lines = New String(-1) {}
        Me.txtNumeroFin.Location = New System.Drawing.Point(460, 55)
        Me.txtNumeroFin.MaxLength = 32767
        Me.txtNumeroFin.Name = "txtNumeroFin"
        Me.txtNumeroFin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroFin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroFin.SelectedText = ""
        Me.txtNumeroFin.Size = New System.Drawing.Size(170, 23)
        Me.txtNumeroFin.TabIndex = 6
        Me.txtNumeroFin.UseSelectable = True
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(152, 101)
        Me.dtpFechaIni.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(170, 30)
        Me.dtpFechaIni.TabIndex = 9
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(44, 101)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(87, 20)
        Me.MetroLabel5.TabIndex = 8
        Me.MetroLabel5.Text = "Fecha Inicial:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(358, 101)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(81, 20)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Fecha Final:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(460, 101)
        Me.dtpFechaFin.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(170, 30)
        Me.dtpFechaFin.TabIndex = 11
        '
        'cmbTipoPartidas
        '
        Me.cmbTipoPartidas.FormattingEnabled = True
        Me.cmbTipoPartidas.ItemHeight = 24
        Me.cmbTipoPartidas.Location = New System.Drawing.Point(44, 155)
        Me.cmbTipoPartidas.Name = "cmbTipoPartidas"
        Me.cmbTipoPartidas.Size = New System.Drawing.Size(278, 30)
        Me.cmbTipoPartidas.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbTipoPartidas.TabIndex = 13
        Me.cmbTipoPartidas.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cmbTipoPartidas.UseCustomBackColor = True
        Me.cmbTipoPartidas.UseSelectable = True
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.ItemHeight = 24
        Me.cmbEstado.Location = New System.Drawing.Point(352, 155)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(278, 30)
        Me.cmbEstado.Style = MetroFramework.MetroColorStyle.Teal
        Me.cmbEstado.TabIndex = 15
        Me.cmbEstado.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cmbEstado.UseCustomBackColor = True
        Me.cmbEstado.UseSelectable = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.chkEstado)
        Me.MetroPanel2.Controls.Add(Me.chkTipo)
        Me.MetroPanel2.Controls.Add(Me.chkFecha)
        Me.MetroPanel2.Controls.Add(Me.chkPartida)
        Me.MetroPanel2.Controls.Add(Me.btnAceptarLin2)
        Me.MetroPanel2.Controls.Add(Me.cmbEstado)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel2.Controls.Add(Me.cmbTipoPartidas)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.Controls.Add(Me.dtpFechaFin)
        Me.MetroPanel2.Controls.Add(Me.txtNumeroIni)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel2.Controls.Add(Me.txtNumeroFin)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.dtpFechaIni)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(23, 63)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(647, 232)
        Me.MetroPanel2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroPanel2.TabIndex = 0
        Me.MetroPanel2.UseStyleColors = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(341, 132)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(67, 17)
        Me.chkEstado.Style = MetroFramework.MetroColorStyle.Teal
        Me.chkEstado.TabIndex = 14
        Me.chkEstado.Text = "Estado:"
        Me.chkEstado.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkEstado.UseCustomBackColor = True
        Me.chkEstado.UseSelectable = True
        '
        'chkTipo
        '
        Me.chkTipo.AutoSize = True
        Me.chkTipo.Location = New System.Drawing.Point(10, 132)
        Me.chkTipo.Name = "chkTipo"
        Me.chkTipo.Size = New System.Drawing.Size(53, 17)
        Me.chkTipo.Style = MetroFramework.MetroColorStyle.Teal
        Me.chkTipo.TabIndex = 12
        Me.chkTipo.Text = "Tipo:"
        Me.chkTipo.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkTipo.UseCustomBackColor = True
        Me.chkTipo.UseSelectable = True
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(10, 81)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(60, 17)
        Me.chkFecha.Style = MetroFramework.MetroColorStyle.Teal
        Me.chkFecha.TabIndex = 7
        Me.chkFecha.Text = "Fecha:"
        Me.chkFecha.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkFecha.UseCustomBackColor = True
        Me.chkFecha.UseSelectable = True
        '
        'chkPartida
        '
        Me.chkPartida.AutoSize = True
        Me.chkPartida.Location = New System.Drawing.Point(10, 38)
        Me.chkPartida.Name = "chkPartida"
        Me.chkPartida.Size = New System.Drawing.Size(136, 17)
        Me.chkPartida.Style = MetroFramework.MetroColorStyle.Teal
        Me.chkPartida.TabIndex = 2
        Me.chkPartida.Text = "Número de Partida"
        Me.chkPartida.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkPartida.UseCustomBackColor = True
        Me.chkPartida.UseSelectable = True
        '
        'frmMPartidasAut
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.AutoSize = True
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(799, 599)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.dgPartAut2)
        Me.Controls.Add(Me.btnTrasladar2)
        Me.Controls.Add(Me.btnAnular2)
        Me.Controls.Add(Me.btnImprimir2)
        Me.Controls.Add(Me.btnEliminar2)
        Me.Controls.Add(Me.btnModificar2)
        Me.Controls.Add(Me.ChkTrasladar)
        Me.MinimumSize = New System.Drawing.Size(799, 599)
        Me.Name = "frmMPartidasAut"
        Me.Padding = New System.Windows.Forms.Padding(20, 60, 60, 20)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Partidas Automáticas"
        CType(Me.dgPartAut2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"
    Public Property Autorizado() As String
        Get
            Return vAutorizado
        End Get
        Set(ByVal Value As String)
            vAutorizado = Value
        End Set
    End Property

    Public Property IdPartida() As String
        Get
            Return vIdPartida
        End Get
        Set(ByVal Value As String)
            vIdPartida = Value.Trim
        End Set
    End Property

    Public Property Prefijo() As String
        Get
            Return vPrefijo
        End Get
        Set(ByVal Value As String)
            vPrefijo = Value.Trim
        End Set
    End Property

    Public Property TipoPartida() As String
        Get
            Return vTipoPartida
        End Get
        Set(ByVal Value As String)
            vTipoPartida = Value.Trim
        End Set
    End Property
#End Region

    Private Sub frmMPartidasAut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaIni.Enabled = False
        Me.txtNumeroFin.Enabled = False
        Me.txtNumeroIni.Enabled = False
        Me.cmbEstado.Enabled = False
        Me.cmbTipoPartidas.Enabled = False

        Dim oPartida As New wrConta.wsLibContab
        Dim dsTipo As New DataSet, dsEstado As New DataSet, xFilas As Integer, dr As DataRow
        dsTipo = oPartida.ObtenerTipoPartidasAut(Date.Now.Year, sUsuario, sPassword, sSucursal)
        dsEstado = oPartida.ObtenerEstadoPartidas(sUsuario, sPassword, sSucursal)
        For Each dr In dsTipo.Tables(0).Rows
            cmbTipoPartidas.Items.Add(CStr(dr("Prefijo")) & " - " & CStr(dr("Descripcion")))
        Next
        For Each dr In dsEstado.Tables(0).Rows
            cmbEstado.Items.Add(CStr(dr("IdEstado")) & " - " & CStr(dr("Descripcion")))
        Next
        cmbTipoPartidas.SelectedIndex = 0
        cmbEstado.SelectedIndex = 0
    End Sub



    Private Sub cmbEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnAceptarLin2_Click(sender, e)
    End Sub

    Private Sub cmbTipoPartidas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnAceptarLin2_Click(sender, e)
    End Sub

    Private Sub txtNumeroFin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnAceptarLin2_Click(sender, e)
    End Sub

    Private Sub txtNumeroIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnAceptarLin2_Click(sender, e)
    End Sub

    Private Sub dtpFechaFin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Return Then btnAceptarLin2_Click(sender, e)
    End Sub

    Private Sub dtpFechaIni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Return Then btnAceptarLin2_Click(sender, e)
    End Sub

    Private Sub btnModificar2_Click(sender As Object, e As EventArgs) Handles btnModificar2.Click
        Dim frm As frmPartidasAut = New frmPartidasAut
        Try
            frm.Prefijo = ""
            frm.Accion = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarPartida
            frm.IdModifica = Me.dgPartAut2.Item("Num_Partida", Me.dgPartAut2.CurrentRow.Index).Value 'Me.IdPartida.Trim
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar una partida existente", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnEliminar2_Click(sender As Object, e As EventArgs) Handles btnEliminar2.Click
        Dim oPartida As New wrConta.wsLibContab
        If Me.Prefijo = "EG" Then
            MessageBox.Show("La Partida se origina en el módulo de Bancos, no puede ser eliminada desde este módulo.", "Eliminar Partida", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If Me.TipoPartida.Trim = "A" Then
            MessageBox.Show("Partida generada automaticamente, no puede ser eliminada desde este módulo.", "Eliminar Partida", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea Eliminar la Partida: " & Me.IdPartida.Trim & "?", "Eliminar Partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If oPartida.EliminaPartidaAut(sUsuario, sPassword, sSucursal, Me.IdPartida) = True Then
                MessageBox.Show("Partida " & Me.IdPartida & " Eliminada con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("La Partida " & Me.IdPartida & " NO puede ser Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub btnImprimir2_Click(sender As Object, e As EventArgs) Handles btnImprimir2.Click
        Dim oRep As wrConta.wsLibContab = New wrConta.wsLibContab, ds As New Data.DataSet

        Try


            Dim ofrm As New frmVisorRep
            ofrm.Reporte = sifLib.Contabilidad.clsContabs.ReportesContabilidad.PartidasDiarioAut
            ofrm.FechaIni = Now
            ofrm.sFechaI = Now
            ofrm.FechaFin = Now
            ofrm.sFechaF = Now
            ofrm.NumPartidaIni = Me.IdPartida.Trim
            ofrm.NumPartidaFin = Me.IdPartida.Trim

            ofrm.ShowDialog()
            ofrm.TopMost = True


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("No hay datos disponibles.", "Validación de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnAnular2_Click(sender As Object, e As EventArgs) Handles btnAnular2.Click
        Try
            Dim oPartida As New wrConta.wsLibContab
            If Me.Prefijo = "EG" Then
                MessageBox.Show("La Partida se origina en el módulo de Bancos, no puede ser anulada desde este módulo.", "Anular Partida", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If Me.TipoPartida.Trim = "A" Then
                MessageBox.Show("Partida generada automaticamente, no puede ser anulada desde este módulo.", "Anular Partida", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If MessageBox.Show("¿Desea Anular la Partida: " & Me.IdPartida.Trim & "?", "Anular Partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                If oPartida.AnulaPartidaAut(sUsuario, sPassword, sSucursal, Me.IdPartida) = True Then
                    MessageBox.Show("Partida " & Me.IdPartida & " Anulada con éxito", "Anular", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("La Partida " & Me.IdPartida & " NO puede ser Anulada", "Anular", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub dgPartAut2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgPartAut2.CellContentClick
        Try
            Me.IdPartida = Me.dgPartAut2.Item("Num_Partida", Me.dgPartAut2.CurrentRow.Index).Value.ToString
            If Me.dgPartAut2.Columns(e.ColumnIndex).Name.ToString.Equals("trasladar2") Then
                If Me.dgPartAut2.Item("Trasladar2", Me.dgPartAut2.CurrentRow.Index).Value = False Then
                    Me.dgPartAut2.Item("Trasladar2", Me.dgPartAut2.CurrentRow.Index).Value = True
                    Me.dgPartAut2.Rows(Me.dgPartAut2.CurrentRow.Index).DefaultCellStyle.BackColor = Color.Teal
                Else
                    Me.dgPartAut2.Item("Trasladar2", Me.dgPartAut2.CurrentRow.Index).Value = False
                    Me.dgPartAut2.Rows(Me.dgPartAut2.CurrentRow.Index).DefaultCellStyle.BackColor = Color.WhiteSmoke
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnTrasladar2_Click(sender As Object, e As EventArgs) Handles btnTrasladar2.Click
        Try
            Dim Contador As Integer
            Dim ErrorPartidas As Integer
            Dim partida As String = ""
            If MsgBox("¿Desea realizar está acción?", MsgBoxStyle.YesNo, "Traslado de Partidas") = MsgBoxResult.Yes Then
                For i As Integer = 0 To Me.dgPartAut2.Rows.Count - 1

                    If Me.dgPartAut2.Item("Autorizado", i).Value.ToString.Trim <> "1" Then
                        If Me.dgPartAut2.Item("Trasladar2", i).Value = True Then
                            If Conta.AutorizaPartidasAut(Me.dgPartAut2.Item("Num_Partida", i).Value, sUsuario, sPassword, sSucursal).Trim = "" Then
                                Contador = Contador + 1
                            Else
                                ErrorPartidas = ErrorPartidas + 1
                            End If
                        End If
                    End If
                Next
                Me.btnAceptarLin2_Click(sender, e)
                MsgBox(Contador.ToString + " Partidas Trasladadas con exito. " & vbCrLf & vbCrLf & ErrorPartidas & " No trasladadas", MsgBoxStyle.Information, "Traslado de Partidas")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAceptarLin2_Click(sender As Object, e As EventArgs) Handles btnAceptarLin2.Click
        Try
            Dim oPartida As New wrConta.wsLibContab
            Dim campos As String = " Select Num_partida,Prefijo,Fecha,Descripcion [Concepto],Cargo,Abono,Autorizado,IdEstado [Estado],Usu_Digita[Usuario]"
            Dim filtro As String = ""
            Dim dts As New DataSet


            If chkPartida.Checked = True Then
                If filtro = "" Then
                    filtro = " where num_Partida  > ='" & txtNumeroIni.Text.Trim & "' and num_partida <= '" & txtNumeroFin.Text.Trim & "' "
                Else
                    filtro = filtro & " and num_Partida  > ='" & txtNumeroIni.Text.Trim & "' and num_partida <= '" & txtNumeroFin.Text.Trim & "' "
                End If
            End If
            If chkFecha.Checked = True Then
                If filtro = "" Then
                    filtro = " where  fecha > = '" & dtpFechaIni.Value.ToShortDateString & "' and fecha <='" & dtpFechaFin.Value.ToShortDateString & "' "
                Else
                    filtro = filtro & " and fecha > = '" & dtpFechaIni.Value.ToShortDateString & "' and fecha <='" & dtpFechaFin.Value.ToShortDateString & "' "
                End If
            End If
            If chkTipo.Checked = True Then
                If filtro = "" Then
                    filtro = " where  PREFIJO = '" & cmbTipoPartidas.Text.Substring(0, 2).ToString.Trim & "' "
                Else
                    filtro = filtro & " and   PREFIJO = '" & cmbTipoPartidas.Text.Substring(0, 2).ToString.Trim & "' "
                End If
            End If
            If chkEstado.Checked = True Then
                If filtro = "" Then
                    filtro = " where idEstado = '" & cmbEstado.Text.Substring(0, 1) & "' "
                Else
                    filtro = filtro & " and  idEstado = '" & cmbEstado.Text.Substring(0, 1) & "' "
                End If
            End If

            dts = Conta.consultarCaDiario(campos, filtro, sUsuario, sPassword, sSucursal)
            Me.dgPartAut2.DataSource = dts.Tables(0)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try



    End Sub



#Region "Datagrid Partidas Automaticas"

    Private Sub ChkTrasladar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkTrasladar.CheckedChanged
        Try
            If Me.ChkTrasladar.Checked = True Then

                For i As Integer = 0 To Me.dgPartAut2.Rows.Count - 1
                    Me.dgPartAut2.Item("Trasladar2", i).Value = True
                Next
            Else
                For i As Integer = 0 To Me.dgPartAut2.Rows.Count - 1
                    Me.dgPartAut2.Item("Trasladar2", i).Value = False
                Next
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        If chkEstado.Checked = True Then
            Me.cmbEstado.Enabled = True
            Me.cmbEstado.Focus()
        Else
            Me.cmbEstado.Enabled = False
        End If
    End Sub

    Private Sub chkFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkFecha.CheckedChanged
        If chkFecha.Checked = True Then
            Me.dtpFechaIni.Enabled = True
            Me.dtpFechaFin.Enabled = True
            Me.dtpFechaIni.Focus()
        Else
            Me.dtpFechaIni.Enabled = False
            Me.dtpFechaFin.Enabled = False
        End If
    End Sub

    Private Sub chkPartida_CheckedChanged(sender As Object, e As EventArgs) Handles chkPartida.CheckedChanged
        If chkPartida.Checked = True Then
            Me.txtNumeroIni.Focus()
            Me.txtNumeroIni.Enabled = True
            Me.txtNumeroFin.Enabled = True
            Me.txtNumeroIni.Text = ""
            Me.txtNumeroFin.Text = ""
        Else
            Me.txtNumeroIni.Enabled = False
            Me.txtNumeroFin.Enabled = False
            Me.txtNumeroIni.Text = ""
            Me.txtNumeroFin.Text = ""
        End If
    End Sub

    Private Sub chkTipo_CheckedChanged(sender As Object, e As EventArgs) Handles chkTipo.CheckedChanged
        If chkTipo.Checked = True Then
            cmbTipoPartidas.Focus()
            Me.cmbTipoPartidas.Enabled = True
        Else
            Me.cmbTipoPartidas.Enabled = False
        End If
    End Sub




#End Region
End Class