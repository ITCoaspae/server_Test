Public Class frmMPartidas
    Inherits MetroFramework.Forms.MetroForm 'System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private dsPartidas As DataSet, vIdPartida As String, vPrefijo As String, vTipoPartida As String
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAnu As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBuscar2 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoPartidas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumeroIni As System.Windows.Forms.TextBox
    Friend WithEvents optEstado As System.Windows.Forms.RadioButton
    Friend WithEvents optTipo As System.Windows.Forms.RadioButton
    Friend WithEvents optFecha As System.Windows.Forms.RadioButton
    Friend WithEvents optNumero As System.Windows.Forms.RadioButton
    Friend WithEvents optMesAnioActual As System.Windows.Forms.RadioButton
    Friend WithEvents txtNumeroFin As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.optMesAnioActual = New System.Windows.Forms.RadioButton()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbTipoPartidas = New System.Windows.Forms.ComboBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroFin = New System.Windows.Forms.TextBox()
        Me.txtNumeroIni = New System.Windows.Forms.TextBox()
        Me.optEstado = New System.Windows.Forms.RadioButton()
        Me.optTipo = New System.Windows.Forms.RadioButton()
        Me.optFecha = New System.Windows.Forms.RadioButton()
        Me.optNumero = New System.Windows.Forms.RadioButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnBuscar2 = New MetroFramework.Controls.MetroButton()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnAnu = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optMesAnioActual
        '
        Me.optMesAnioActual.BackColor = System.Drawing.Color.White
        Me.optMesAnioActual.Location = New System.Drawing.Point(340, 91)
        Me.optMesAnioActual.Name = "optMesAnioActual"
        Me.optMesAnioActual.Size = New System.Drawing.Size(152, 24)
        Me.optMesAnioActual.TabIndex = 15
        Me.optMesAnioActual.Text = "Año y Mes Actual"
        Me.optMesAnioActual.UseVisualStyleBackColor = False
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Location = New System.Drawing.Point(179, 121)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(152, 21)
        Me.cmbEstado.TabIndex = 13
        '
        'cmbTipoPartidas
        '
        Me.cmbTipoPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPartidas.Location = New System.Drawing.Point(21, 121)
        Me.cmbTipoPartidas.Name = "cmbTipoPartidas"
        Me.cmbTipoPartidas.Size = New System.Drawing.Size(152, 21)
        Me.cmbTipoPartidas.TabIndex = 12
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(519, 65)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(112, 20)
        Me.dtpFechaFin.TabIndex = 11
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(375, 65)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(112, 20)
        Me.dtpFechaIni.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(493, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Al"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(337, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Del"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(179, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Al"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(21, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Del"
        '
        'txtNumeroFin
        '
        Me.txtNumeroFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroFin.Location = New System.Drawing.Point(206, 65)
        Me.txtNumeroFin.Name = "txtNumeroFin"
        Me.txtNumeroFin.Size = New System.Drawing.Size(112, 20)
        Me.txtNumeroFin.TabIndex = 5
        '
        'txtNumeroIni
        '
        Me.txtNumeroIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroIni.Location = New System.Drawing.Point(61, 65)
        Me.txtNumeroIni.Name = "txtNumeroIni"
        Me.txtNumeroIni.Size = New System.Drawing.Size(112, 20)
        Me.txtNumeroIni.TabIndex = 4
        '
        'optEstado
        '
        Me.optEstado.BackColor = System.Drawing.Color.White
        Me.optEstado.Location = New System.Drawing.Point(182, 91)
        Me.optEstado.Name = "optEstado"
        Me.optEstado.Size = New System.Drawing.Size(152, 24)
        Me.optEstado.TabIndex = 3
        Me.optEstado.Text = "Estado"
        Me.optEstado.UseVisualStyleBackColor = False
        '
        'optTipo
        '
        Me.optTipo.BackColor = System.Drawing.Color.White
        Me.optTipo.Location = New System.Drawing.Point(21, 91)
        Me.optTipo.Name = "optTipo"
        Me.optTipo.Size = New System.Drawing.Size(152, 24)
        Me.optTipo.TabIndex = 2
        Me.optTipo.Text = "Tipo Comprobante"
        Me.optTipo.UseVisualStyleBackColor = False
        '
        'optFecha
        '
        Me.optFecha.BackColor = System.Drawing.Color.White
        Me.optFecha.Location = New System.Drawing.Point(340, 33)
        Me.optFecha.Name = "optFecha"
        Me.optFecha.Size = New System.Drawing.Size(152, 24)
        Me.optFecha.TabIndex = 1
        Me.optFecha.Text = "Fecha"
        Me.optFecha.UseVisualStyleBackColor = False
        '
        'optNumero
        '
        Me.optNumero.BackColor = System.Drawing.Color.White
        Me.optNumero.Checked = True
        Me.optNumero.Location = New System.Drawing.Point(21, 33)
        Me.optNumero.Name = "optNumero"
        Me.optNumero.Size = New System.Drawing.Size(152, 24)
        Me.optNumero.TabIndex = 0
        Me.optNumero.TabStop = True
        Me.optNumero.Text = "Número"
        Me.optNumero.UseVisualStyleBackColor = False
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.btnBuscar2)
        Me.MetroPanel1.Controls.Add(Me.optMesAnioActual)
        Me.MetroPanel1.Controls.Add(Me.cmbEstado)
        Me.MetroPanel1.Controls.Add(Me.cmbTipoPartidas)
        Me.MetroPanel1.Controls.Add(Me.optNumero)
        Me.MetroPanel1.Controls.Add(Me.dtpFechaFin)
        Me.MetroPanel1.Controls.Add(Me.optFecha)
        Me.MetroPanel1.Controls.Add(Me.dtpFechaIni)
        Me.MetroPanel1.Controls.Add(Me.optTipo)
        Me.MetroPanel1.Controls.Add(Me.Label3)
        Me.MetroPanel1.Controls.Add(Me.optEstado)
        Me.MetroPanel1.Controls.Add(Me.Label4)
        Me.MetroPanel1.Controls.Add(Me.txtNumeroIni)
        Me.MetroPanel1.Controls.Add(Me.Label2)
        Me.MetroPanel1.Controls.Add(Me.txtNumeroFin)
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(844, 161)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroPanel1.TabIndex = 10
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "Filtros de Busqueda"
        '
        'btnBuscar2
        '
        Me.btnBuscar2.Location = New System.Drawing.Point(519, 104)
        Me.btnBuscar2.Name = "btnBuscar2"
        Me.btnBuscar2.Size = New System.Drawing.Size(112, 23)
        Me.btnBuscar2.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar2.TabIndex = 16
        Me.btnBuscar2.Text = "Buscar"
        Me.btnBuscar2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnBuscar2.UseSelectable = True
        Me.btnBuscar2.UseStyleColors = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 264)
        Me.MetroGrid1.MultiSelect = False
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(844, 180)
        Me.MetroGrid1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroGrid1.TabIndex = 11
        Me.MetroGrid1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 230)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 230)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 13
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 230)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 230)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 15
        Me.btnImp.Text = "Imprimir"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnAnu
        '
        Me.btnAnu.Location = New System.Drawing.Point(347, 230)
        Me.btnAnu.Name = "btnAnu"
        Me.btnAnu.Size = New System.Drawing.Size(75, 28)
        Me.btnAnu.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAnu.TabIndex = 16
        Me.btnAnu.Text = "Anular"
        Me.btnAnu.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAnu.UseSelectable = True
        Me.btnAnu.UseStyleColors = True
        '
        'frmMPartidas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(882, 488)
        Me.Controls.Add(Me.btnAnu)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MinimumSize = New System.Drawing.Size(882, 488)
        Me.Name = "frmMPartidas"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Maestro de Partidas Contables"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "PROPIEDADES"
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



    Private Sub frmMPartidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oPartida As New wrConta.wsLibContab
            Dim dsTipo As New DataSet, dsEstado As New DataSet, dr As DataRow

            dsTipo = oPartida.ObtenerTipoPartidas(Date.Now.Year, sUsuario, sPassword, sSucursal)
            dsEstado = oPartida.ObtenerEstadoPartidas(sUsuario, sPassword, sSucursal)
            dsPartidas = oPartida.ConsultaPartidasxMes(Date.Now.Year, Date.Now.Month, sUsuario, sPassword, sSucursal)
            'C1fgrdDiario.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
            'C1fgrdDiario.DataSource = dsPartidas.Tables(0)
            For Each dr In dsTipo.Tables(0).Rows
                cmbTipoPartidas.Items.Add(CStr(dr("Prefijo")) & " - " & CStr(dr("Descripcion")))
            Next
            For Each dr In dsEstado.Tables(0).Rows
                cmbEstado.Items.Add(CStr(dr("IdEstado")) & " - " & CStr(dr("Descripcion")))
            Next
            cmbTipoPartidas.SelectedIndex = 0
            cmbEstado.SelectedIndex = 0
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



    Public Function validarPartidaCerrada()
        Dim cierre As String
        cierre = Me.MetroGrid1.Item("Cierre", Me.MetroGrid1.CurrentRow.Index).Value.ToString

        'cierre = IIf(Me.MetroGrid1.Item("Cierre", Me.MetroGrid1.CurrentRow.Index).Value Is DBNull.Value, "0", MetroGrid1.Item("Cierre", Me.MetroGrid1.CurrentRow.Index))
        If cierre.Equals("1") Then
            MsgBox("El mes se encuentra cerrado, no es posible modificar la partida.", MsgBoxStyle.Information, "Error de validación")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub optNumero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNumero.CheckedChanged
        Me.txtNumeroIni.Focus()
    End Sub

    Private Sub optFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optFecha.CheckedChanged
        Me.dtpFechaIni.Focus()
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        IdPartida = Me.MetroGrid1.Item("Num_Partida", Me.MetroGrid1.CurrentRow.Index).Value
        Me.Prefijo = Me.MetroGrid1.Item("Prefijo", Me.MetroGrid1.CurrentRow.Index).Value
        Me.TipoPartida = Me.MetroGrid1.Item("Tipo_Partida", Me.MetroGrid1.CurrentRow.Index).Value
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As frmPartida = New frmPartida
        frm.Prefijo = ""
        'frm.Accion = Contabilidad.clsPartida.TipoAccionPartidas.AgregarPartida
        frm.Accion = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.AgregarPartida
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim frm As frmPartida = New frmPartida
        Try
            If validarPartidaCerrada() = True Then
                Exit Sub
            End If

            If Me.Prefijo = "EG" Or Me.TipoPartida.Trim = "A" Then
                frm.Prefijo = vPrefijo
            Else
                frm.Prefijo = ""
            End If
            'frm.Accion = Contabilidad.clsPartida.TipoAccionPartidas.ModificarPartida
            frm.Accion = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarPartida
            frm.IdModifica = Me.IdPartida.Trim
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Debe Seleccionar una partida existente", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim oPartida As New wrConta.wsLibContab
        If validarPartidaCerrada() = True Then
            Exit Sub
        End If

        If Me.Prefijo = "EG" Then
            MessageBox.Show("La Partida se origina en el módulo de Bancos, no puede ser eliminada desde este módulo.", "Eliminar Partida", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If Me.TipoPartida.Trim = "A" Then
            MessageBox.Show("Partida generada automaticamente, no puede ser eliminada desde este módulo.", "Eliminar Partida", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea Eliminar la Partida: " & Me.IdPartida.Trim & "?", "Eliminar Partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If oPartida.EliminaPartida(sUsuario, sPassword, sSucursal, Me.IdPartida) = True Then
                MessageBox.Show("Partida " & Me.IdPartida & " Eliminada con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("La Partida " & Me.IdPartida & " NO puede ser Eliminada", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Dim oRep As wrConta.wsLibContab = New wrConta.wsLibContab, ds As New Data.DataSet
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim ofrm As New frmVisorRep
            'ofrm.Reporte = Contabilidad.clsContab.ReportesContabilidad.PartidasDiario
            ofrm.Reporte = sifLib.Contabilidad.clsContabs.ReportesContabilidad.PartidasDiario
            ofrm.FechaIni = Date.Today
            ofrm.sFechaI = Date.Today.ToString
            ofrm.FechaFin = Date.Today
            ofrm.sFechaF = Date.Today.ToString
            ofrm.NumPartidaIni = Me.IdPartida.Trim
            ofrm.NumPartidaFin = Me.IdPartida.Trim
            
            ofrm.Show()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("No hay datos disponibles.", "Validación de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnAnu_Click(sender As Object, e As EventArgs) Handles btnAnu.Click
        Dim oPartida As New wrConta.wsLibContab
        Dim iRow As Integer
        If validarPartidaCerrada() = True Then
            Exit Sub
        End If

        If Me.Prefijo = "EG" Then
            MessageBox.Show("La Partida se origina en el módulo de Bancos, no puede ser anulada desde este módulo.", "Anular Partida", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If Me.TipoPartida.Trim = "A" Then
            MessageBox.Show("Partida generada automaticamente, no puede ser anulada desde este módulo.", "Anular Partida", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea Anular la Partida: " & Me.IdPartida.Trim & "?", "Anular Partida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If oPartida.AnulaPartida(sUsuario, sPassword, sSucursal, Me.IdPartida) = True Then
                MessageBox.Show("Partida " & Me.IdPartida & " Anulada con éxito", "Anular", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("La Partida " & Me.IdPartida & " NO puede ser Anulada", "Anular", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub optTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTipo.CheckedChanged
        Me.cmbTipoPartidas.Focus()
    End Sub

    Private Sub optEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optEstado.CheckedChanged
        Me.cmbEstado.Focus()
    End Sub



    Private Sub btnBuscar2_Click(sender As Object, e As EventArgs) Handles btnBuscar2.Click
        Dim oPartida As New wrConta.wsLibContab

        If optNumero.Checked = True Then
            dsPartidas = oPartida.BuscarPartidasxNumero(txtNumeroIni.Text.Trim, txtNumeroFin.Text.Trim, sUsuario, sPassword, sSucursal)
        ElseIf optFecha.Checked = True Then
            dsPartidas = oPartida.BuscarPartidasxFecha(dtpFechaIni.Value, dtpFechaFin.Value, sUsuario, sPassword, sSucursal)
        ElseIf optTipo.Checked = True Then
            dsPartidas = oPartida.BuscarPartidasxTipo(cmbTipoPartidas.Text.Substring(0, 2), " ", sUsuario, sPassword, sSucursal)
        ElseIf optEstado.Checked = True Then
            dsPartidas = oPartida.BuscarPartidasxEstado(cmbEstado.Text.Substring(0, 1), " ", sUsuario, sPassword, sSucursal)
        ElseIf optMesAnioActual.Checked = True Then
            dsPartidas = oPartida.BuscarPartidasxMesyAnioActual(Date.Now.Year, Date.Now.Month, sUsuario, sPassword, sSucursal)
        End If
        Me.MetroGrid1.DataSource = dsPartidas.Tables(0)
    End Sub



End Class