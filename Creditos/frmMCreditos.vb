Public Class frmMCreditos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ': Me.Icon = CType(rsc.GetObject("gnucash (1).ico"), System.Drawing.Icon)

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
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEstado1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbNombres As ComboBox
    Friend WithEvents rbNoSolic As RadioButton
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents rbNombres As RadioButton
    Friend WithEvents rbNoSocio As RadioButton
    Friend WithEvents rbDui As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rbMes As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpMes As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNoSolicitud As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNoSolicitudAl As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoSocio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCreditos))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEstado1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.rbNoSolic = New System.Windows.Forms.RadioButton()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbMes = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpMes = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txtNoSocio = New C1.Win.C1Input.C1NumericEdit()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSolicitudAl = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNoSolicitud = New C1.Win.C1Input.C1NumericEdit()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtNoSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSolicitudAl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.Location = New System.Drawing.Point(28, 314)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(774, 118)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 14
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(319, 275)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 199
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEstado1
        '
        Me.btnEstado1.Location = New System.Drawing.Point(222, 275)
        Me.btnEstado1.Name = "btnEstado1"
        Me.btnEstado1.Size = New System.Drawing.Size(90, 32)
        Me.btnEstado1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEstado1.TabIndex = 197
        Me.btnEstado1.Text = "Desembolso"
        Me.btnEstado1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEstado1.UseSelectable = True
        Me.btnEstado1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 275)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 196
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(672, 149)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 32)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 200
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'cbNombres
        '
        Me.cbNombres.BackColor = System.Drawing.Color.White
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Enabled = False
        Me.cbNombres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(104, 57)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(252, 24)
        Me.cbNombres.TabIndex = 8
        '
        'rbNoSolic
        '
        Me.rbNoSolic.BackColor = System.Drawing.Color.White
        Me.rbNoSolic.Checked = True
        Me.rbNoSolic.ForeColor = System.Drawing.Color.Black
        Me.rbNoSolic.Location = New System.Drawing.Point(7, 84)
        Me.rbNoSolic.Name = "rbNoSolic"
        Me.rbNoSolic.Size = New System.Drawing.Size(90, 28)
        Me.rbNoSolic.TabIndex = 0
        Me.rbNoSolic.TabStop = True
        Me.rbNoSolic.Text = "&Solicitud"
        Me.rbNoSolic.UseVisualStyleBackColor = False
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(364, 57)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(398, 22)
        Me.txtNombres.TabIndex = 9
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(7, 57)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(90, 27)
        Me.rbNombres.TabIndex = 7
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.ForeColor = System.Drawing.Color.Black
        Me.rbNoSocio.Location = New System.Drawing.Point(433, 22)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(139, 28)
        Me.rbNoSocio.TabIndex = 5
        Me.rbNoSocio.Text = "No. de Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        Me.rbNoSocio.Visible = False
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.ForeColor = System.Drawing.Color.Black
        Me.rbDui.Location = New System.Drawing.Point(7, 22)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(63, 28)
        Me.rbDui.TabIndex = 3
        Me.rbDui.Text = "&DUI:"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(101, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Del"
        '
        'rbMes
        '
        Me.rbMes.BackColor = System.Drawing.Color.White
        Me.rbMes.ForeColor = System.Drawing.Color.Black
        Me.rbMes.Location = New System.Drawing.Point(364, 114)
        Me.rbMes.Name = "rbMes"
        Me.rbMes.Size = New System.Drawing.Size(118, 28)
        Me.rbMes.TabIndex = 12
        Me.rbMes.Text = "&Mes Entrega"
        Me.rbMes.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(364, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Al"
        '
        'dtpMes
        '
        Me.dtpMes.CalendarMonthBackground = System.Drawing.Color.Khaki
        Me.dtpMes.CustomFormat = "MMMM"
        Me.dtpMes.Enabled = False
        Me.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMes.Location = New System.Drawing.Point(490, 119)
        Me.dtpMes.Name = "dtpMes"
        Me.dtpMes.ShowUpDown = True
        Me.dtpMes.Size = New System.Drawing.Size(272, 22)
        Me.dtpMes.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.dtpMes)
        Me.GroupBox1.Controls.Add(Me.btnMostrar1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbMes)
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbDui)
        Me.GroupBox1.Controls.Add(Me.rbNoSocio)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.txtNoSolicitudAl)
        Me.GroupBox1.Controls.Add(Me.txtNoSolicitud)
        Me.GroupBox1.Controls.Add(Me.rbNombres)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.rbNoSolic)
        Me.GroupBox1.Controls.Add(Me.cbNombres)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 195)
        Me.GroupBox1.TabIndex = 201
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(234, 117)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(122, 22)
        Me.dtpFechaFin.TabIndex = 203
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(104, 117)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(123, 22)
        Me.dtpFechaInicio.TabIndex = 202
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 119)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 21)
        Me.RadioButton1.TabIndex = 201
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Periodo"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.CustomFormat = "#######0"
        Me.txtNoSocio.DataType = GetType(Integer)
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSocio.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSocio.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtNoSocio.Location = New System.Drawing.Point(580, 24)
        Me.txtNoSocio.MaxLength = 10
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(182, 27)
        Me.txtNoSocio.TabIndex = 6
        Me.txtNoSocio.Tag = Nothing
        Me.txtNoSocio.Value = 0
        Me.txtNoSocio.Visible = False
        Me.txtNoSocio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(104, 25)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(134, 23)
        Me.txtDui.TabIndex = 4
        Me.txtDui.Tag = Nothing
        '
        'txtNoSolicitudAl
        '
        Me.txtNoSolicitudAl.BackColor = System.Drawing.Color.White
        Me.txtNoSolicitudAl.CustomFormat = "######"
        Me.txtNoSolicitudAl.DataType = GetType(Integer)
        Me.txtNoSolicitudAl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSolicitudAl.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSolicitudAl.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtNoSolicitudAl.Location = New System.Drawing.Point(400, 88)
        Me.txtNoSolicitudAl.Name = "txtNoSolicitudAl"
        Me.txtNoSolicitudAl.Size = New System.Drawing.Size(219, 26)
        Me.txtNoSolicitudAl.TabIndex = 2
        Me.txtNoSolicitudAl.Tag = Nothing
        Me.txtNoSolicitudAl.Value = 0
        Me.txtNoSolicitudAl.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtNoSolicitud
        '
        Me.txtNoSolicitud.BackColor = System.Drawing.Color.White
        Me.txtNoSolicitud.CustomFormat = "######"
        Me.txtNoSolicitud.DataType = GetType(Integer)
        Me.txtNoSolicitud.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSolicitud.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSolicitud.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtNoSolicitud.Location = New System.Drawing.Point(137, 88)
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.Size = New System.Drawing.Size(219, 26)
        Me.txtNoSolicitud.TabIndex = 1
        Me.txtNoSolicitud.Tag = Nothing
        Me.txtNoSolicitud.Value = 0
        Me.txtNoSolicitud.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 275)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 202
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'frmMCreditos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(830, 550)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEstado1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.fg)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMCreditos"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Solicitudes de Crédito"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtNoSocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSolicitudAl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub ActualizaGrid()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarSolCred("Correlativo,Numsolicitud,RTrim(Nombres) + ' ' + RTrim(Apellido1) + ' ' + RTrim(Apellido2) + ' ' + RTrim(Apellido3) as Nombres,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,Recibida,CodEjecutivo,EstadoCivil,NIT,MontoSolicitado,Destino,Interes,Plazo,Celular", "FechaEntrega='" & Format(Now, "dd/MM/yyyy") & "'", "Correlativo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Me.rbNoSolic.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Encabezado()

    End Sub

    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "No."
        fg.Cols.Item(2).Caption = "No. Solicitud"
        fg.Cols.Item(3).Caption = "Nombres"
        fg.Cols.Item(4).Caption = "Teléfonos"
        fg.Cols.Item(5).Caption = "Dirección"
        fg.Cols.Item(6).Caption = "Fecha de Entrega"
        fg.Cols.Item(7).Caption = "Lugar de Trabajo"
        fg.Cols.Item(8).Caption = "Tel. Trabajo"
        fg.Cols.Item(9).Caption = "Asociado"
        fg.Cols.Item(10).Caption = "Dui"
        fg.Cols.Item(11).Caption = "Cód. Tipo de Crédito"
        fg.Cols.Item(12).Caption = "Cód. Profesión"
        fg.Cols.Item(13).Caption = "Solic. Recibida"
        fg.Cols.Item(14).Caption = "Cód. Ejecutivo"

        fg.Cols.Item(1).Width = 50
        fg.Cols.Item(2).Width = 77
        fg.Cols.Item(3).Width = 250
        fg.Cols.Item(4).Width = 77
        fg.Cols.Item(5).Width = 300
        fg.Cols.Item(6).Width = 77
        fg.Cols.Item(7).Width = 100
        fg.Cols.Item(8).Width = 77
        fg.Cols.Item(9).Width = 77
        fg.Cols.Item(10).Width = 77
        fg.Cols.Item(11).Width = 77
        fg.Cols.Item(12).Width = 77
        fg.Cols.Item(13).Width = 77
        fg.Cols.Item(14).Width = 77
        fg.Cols.Item(15).Width = 77

    End Sub



    Private Sub frmMCreditos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
        'Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub rbNoSocio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNoSocio.CheckedChanged
        If Me.rbNoSocio.Checked = True Then
            Me.txtNoSocio.Enabled = True
        ElseIf Me.rbNoSocio.Checked = False Then
            Me.txtNoSocio.Enabled = False
        End If
        Me.txtNoSocio.Focus()
    End Sub

    Private Sub rbNoSolic_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNoSolic.CheckedChanged
        If Me.rbNoSolic.Checked = True Then
            Me.txtNoSolicitud.Enabled = True
        ElseIf Me.rbNoSolic.Checked = False Then
            Me.txtNoSolicitud.Enabled = False
        End If
        Me.txtNoSolicitud.Focus()
    End Sub

    Private Sub rbDui_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
        If Me.rbDui.Checked = True Then
            Me.txtDui.Enabled = True
        ElseIf Me.rbDui.Checked = False Then
            Me.txtDui.Enabled = False
        End If
        Me.txtDui.Focus()
    End Sub

    Private Sub rbNombres_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        If Me.rbNombres.Checked = True Then
            Me.cbNombres.Enabled = True
            Me.txtNombres.Enabled = True
        ElseIf Me.rbNombres.Checked = False Then
            Me.cbNombres.Enabled = False
            Me.txtNombres.Enabled = False
        End If
        Me.cbNombres.Focus()
    End Sub

    Private Sub rbMes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbMes.CheckedChanged
        If Me.rbMes.Checked = True Then
            Me.dtpMes.Enabled = True
        ElseIf Me.rbMes.Checked = False Then
            Me.dtpMes.Enabled = False
        End If
        Me.dtpMes.Focus()
    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
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

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoSolicitud_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSolicitud.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoSolicitudAl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSolicitudAl.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub dtpMes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpMes.KeyDown
        If e.KeyData = Keys.Return Then btnMostrar1_Click(sender, e)
    End Sub


    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsCrCreditos = New frmMsCrCreditos
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show()
            btnMostrar1_Click(sender, e)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try

            If fg.Row <> -1 Then

                Dim frm As frmMsCrCreditos = New frmMsCrCreditos
                frm.pAccion = "Modificar"
                frm.btnSaveTb1_1.Text = "&Modificar"
                frm.pCorrelativo = fg.Item(fg.Row, "Correlativo")
                frm.pNumSolicitud = fg.Item(fg.Row, "NumSolicitud")
                frm.btnSaveTb1_1.Visible = False
                frm.btnSaveTb2_1.Visible = False
                ' frm.btnSaveTb3_1.Visible = False
                'frm.btnSaveTb4_1.Visible = False
                frm.btnSaveTb5_1.Visible = False
                frm.btNewRF1.Enabled = False
                frm.btEditRF1.Enabled = False
                frm.btDelRF1.Enabled = False
                frm.btNewRP1.Enabled = False
                frm.btEditRP1.Enabled = False
                frm.btDelRP1.Enabled = False
                frm.btNewOb1.Enabled = False
                frm.btEditOb1.Enabled = False
                frm.btDelOb1.Enabled = False
                frm.btNewOA1.Enabled = False
                frm.btEditOA1.Enabled = False
                frm.btDelOA1.Enabled = False
                frm.btNewRC1.Enabled = False
                frm.btEditRC1.Enabled = False
                frm.btDelRC1.Enabled = False
                frm.btNewRB1.Enabled = False
                frm.btEditRB1.Enabled = False
                frm.btDelRB1.Enabled = False
                frm.btNewIng1.Enabled = False
                frm.btEditIng1.Enabled = False
                frm.btDelIng1.Enabled = False
                frm.btNewGt1.Enabled = False
                frm.btEditGt1.Enabled = False
                frm.btDelGt1.Enabled = False
                frm.btNewGr1.Enabled = False
                frm.btEditGr1.Enabled = False
                frm.btDelGr1.Enabled = False
                frm.btNewFd1.Enabled = False
                frm.btEditFd1.Enabled = False
                frm.btDelFd1.Enabled = False
                frm.btNewCd1.Enabled = False
                frm.btEditCd1.Enabled = False
                frm.btDelCd1.Enabled = False
                frm.btNewBI1.Enabled = False
                frm.btEditBI1.Enabled = False
                frm.btDelBI1.Enabled = False
                frm.btNewVh1.Enabled = False
                frm.btEditVh1.Enabled = False
                frm.btDelVh1.Enabled = False
                frm.btnSaveTb61.Enabled = False
                frm.btnSaveTb7_1.Enabled = False
                frm.btnSaveTb8_1.Enabled = False
                frm.btnSaveTb9_1.Enabled = False
                frm.btnSaveTb10_1.Enabled = False
                frm.btnSaveTb11_1.Enabled = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                btnMostrar1_Click(sender, e)
                Me.txtNoSolicitud.Enabled = False
                Me.txtNoSocio.Enabled = False
                Me.txtNombres.Enabled = False
                Me.txtDui.Enabled = False
                Me.cbNombres.Enabled = False
                Me.dtpMes.Enabled = False

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnEstado1_Click(sender As Object, e As EventArgs) Handles btnEstado1.Click
        Try
            If fg.Row <> -1 Then

                Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, Filas As Data.DataRowCollection, ds As New Data.DataSet, pNSol As Long

                ds = oCred.ConsultarDatGral("*", "NumSolicitud='" & fg.Item(fg.Row, "NumSolicitud") & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows
                If Filas.Count > 0 Then
                    Dim frm As frmMsCrControlEstado = New frmMsCrControlEstado
                    pNSol = fg.Item(fg.Row, "NumSolicitud")
                    frm.Dui = fg.Item(fg.Row, "Dui")
                    frm.pNoSolic = pNSol
                    frm.StartPosition = FormStartPosition.CenterScreen
                    frm.ShowDialog()
                End If

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click

        Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet, pDui As String, Filas As Data.DataRowCollection
        Try
            oCred = New wrCredito.wsLibCred
            If rbNoSolic.Checked = True Then
                If Me.txtNoSolicitudAl.Text.Trim = "" Then
                    ds = oCred.ConsultarSolCred("Correlativo,Numsolicitud,RTrim(Nombres) + ' ' + RTrim(Apellido1) + ' ' + RTrim(Apellido2) + ' ' + RTrim(Apellido3) as Nombres,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,Recibida,CodEjecutivo,EstadoCivil,NIT,MontoSolicitado,Destino,Interes,Plazo,Celular", "NumSolicitud='" & Val(Me.txtNoSolicitud.Value) & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                Else
                    ds = oCred.ConsultarSolCred("Correlativo,Numsolicitud,RTrim(Nombres) + ' ' + RTrim(Apellido1) + ' ' + RTrim(Apellido2) + ' ' + RTrim(Apellido3) as Nombres,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,Recibida,CodEjecutivo,EstadoCivil,NIT,MontoSolicitado,Destino,Interes,Plazo,Celular", "NumSolicitud>='" & Val(Me.txtNoSolicitud.Value) & "' and NumSolicitud<='" & Val(Me.txtNoSolicitudAl.Value) & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbDui.Checked = True Then
                ds = oCred.ConsultarSolCred("Correlativo,Numsolicitud,RTrim(Nombres) + ' ' + RTrim(Apellido1) + ' ' + RTrim(Apellido2) + ' ' + RTrim(Apellido3) as Nombres,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,Recibida,CodEjecutivo,EstadoCivil,NIT,MontoSolicitado,Destino,Interes,Plazo,Celular", "Dui='" & Trim(txtDui.Value) & "'", "Apellido1", sUsuario, sPassword, sSucursal)
            ElseIf rbNoSocio.Checked = True Then
                ds = oCred.ConsultarDatGral("Dui", "NoSocio='" & Val(txtNoSocio.Value) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)(0) Is DBNull.Value) Then
                        pDui = CStr(Filas.Item(0)("Dui"))
                    End If
                    ds = oCred.ConsultarSolCred("Correlativo,Numsolicitud,RTrim(Nombres) + ' ' + RTrim(Apellido1) + ' ' + RTrim(Apellido2) + ' ' + RTrim(Apellido3) as Nombres,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,Recibida,CodEjecutivo,EstadoCivil,NIT,MontoSolicitado,Destino,Interes,Plazo,Celular", "Dui='" & Trim(pDui) & "'", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbNombres.Checked = True Then
                If cbNombres.SelectedIndex = 0 Then
                    ds = oCred.ConsultarSolCred("Correlativo,Numsolicitud,RTrim(Nombres) + ' ' + RTrim(Apellido1) + ' ' + RTrim(Apellido2) + ' ' + RTrim(Apellido3) as Nombres,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,Recibida,CodEjecutivo,EstadoCivil,NIT,MontoSolicitado,Destino,Interes,Plazo,Celular", "Apellido1 like '" & Trim(txtNombres.Text) & "%'", "Apellido1,Apellido2", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 1 Then
                    ds = oCred.ConsultarSolCred("Correlativo,Numsolicitud,RTrim(Nombres) + ' ' + RTrim(Apellido1) + ' ' + RTrim(Apellido2) + ' ' + RTrim(Apellido3) as Nombres,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,Recibida,CodEjecutivo,EstadoCivil,NIT,MontoSolicitado,Destino,Interes,Plazo,Celular", "Apellido2 like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 2 Then
                    ds = oCred.ConsultarSolCred("Correlativo,Numsolicitud,RTrim(Nombres) + ' ' + RTrim(Apellido1) + ' ' + RTrim(Apellido2) + ' ' + RTrim(Apellido3) as Nombres,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,Recibida,CodEjecutivo,EstadoCivil,NIT,MontoSolicitado,Destino,Interes,Plazo,Celular", "Nombres like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbMes.Checked = True Then
                ds = oCred.ConsultarSolCred("Correlativo,Numsolicitud,RTrim(Nombres) + ' ' + RTrim(Apellido1) + ' ' + RTrim(Apellido2) + ' ' + RTrim(Apellido3) as Nombres,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,Recibida,CodEjecutivo,EstadoCivil,NIT,MontoSolicitado,Destino,Interes,Plazo,Celular", "Month(FechaEntrega)='" & Month(dtpMes.Value) & "'", "Dui,Apellido1", sUsuario, sPassword, sSucursal)
            ElseIf RadioButton1.Checked = True Then
                ds = oCred.ConsultarSolCred("Correlativo,Numsolicitud,RTrim(Nombres) + ' ' + RTrim(Apellido1) + ' ' + RTrim(Apellido2) + ' ' + RTrim(Apellido3) as Nombres,Tels,Direccion,FechaEntrega,LugarTrabajo,TelsTrabajo,Asociado,Dui,CodTipoCredito,Recibida,CodEjecutivo,EstadoCivil,NIT,MontoSolicitado,Destino,Interes,Plazo,Celular", " FechaEntrega >='" & dtpFechaInicio.Value.ToShortDateString & "' and FechaEntrega <= '" & dtpFechaFin.Value.ToShortDateString & "' ", "Dui,Apellido1", sUsuario, sPassword, sSucursal)
            End If
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                fg.DataSource = ds.Tables(0)
                Encabezado()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub fg_Click(sender As Object, e As EventArgs) Handles fg.Click

    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If fg.Row <> -1 Then

                Dim frm As frmMsCrCreditos = New frmMsCrCreditos

                Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, Filas As Data.DataRowCollection, ds As New Data.DataSet

                ds = oCred.ConsultarDatGral("*", "NumSolicitud='" & fg.Item(fg.Row, "NumSolicitud") & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows
                If Filas.Count > 0 Then
                    'frm.btnSaveTb3_1.Text = "&Modificar"
                    ' frm.btnSaveTb4_1.Text = "&Modificar"
                    frm.btnSaveTb5_1.Text = "&Modificar"
                End If

                frm.pAccion = "Modificar"
                frm.btnSaveTb1_1.Text = "&Modificar"
                frm.pCorrelativo = fg.Item(fg.Row, "Correlativo")
                frm.pNumSolicitud = fg.Item(fg.Row, "NumSolicitud")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                btnMostrar1_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class