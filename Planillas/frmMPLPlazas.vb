Public Class frmMPLPlazas
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents dgPlazas As System.Windows.Forms.DataGridView
    Friend WithEvents chkNombres As System.Windows.Forms.CheckBox
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents cbAreas As System.Windows.Forms.ComboBox
    Friend WithEvents chkArea As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents chkDepto As System.Windows.Forms.CheckBox
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

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
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.chkDepto = New System.Windows.Forms.CheckBox()
        Me.cbAreas = New System.Windows.Forms.ComboBox()
        Me.chkArea = New System.Windows.Forms.CheckBox()
        Me.chkNombres = New System.Windows.Forms.CheckBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.dgPlazas = New System.Windows.Forms.DataGridView()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgPlazas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox2.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox2.Controls.Add(Me.lblFechaFin)
        Me.GroupBox2.Controls.Add(Me.lblFechaInicio)
        Me.GroupBox2.Controls.Add(Me.chkFecha)
        Me.GroupBox2.Controls.Add(Me.cbDepartamento)
        Me.GroupBox2.Controls.Add(Me.chkDepto)
        Me.GroupBox2.Controls.Add(Me.cbAreas)
        Me.GroupBox2.Controls.Add(Me.chkArea)
        Me.GroupBox2.Controls.Add(Me.chkNombres)
        Me.GroupBox2.Controls.Add(Me.chkEstado)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.cbEstado)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 190)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar datos de plazas:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(462, 154)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 112
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(427, 126)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(110, 22)
        Me.dtpFechaFin.TabIndex = 22
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(219, 126)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(110, 22)
        Me.dtpFechaInicio.TabIndex = 21
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.BackColor = System.Drawing.Color.White
        Me.lblFechaFin.ForeColor = System.Drawing.Color.Black
        Me.lblFechaFin.Location = New System.Drawing.Point(335, 126)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(59, 14)
        Me.lblFechaFin.TabIndex = 20
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.BackColor = System.Drawing.Color.White
        Me.lblFechaInicio.ForeColor = System.Drawing.Color.Black
        Me.lblFechaInicio.Location = New System.Drawing.Point(124, 124)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(73, 14)
        Me.lblFechaInicio.TabIndex = 19
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.BackColor = System.Drawing.Color.White
        Me.chkFecha.ForeColor = System.Drawing.Color.Black
        Me.chkFecha.Location = New System.Drawing.Point(16, 123)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(102, 18)
        Me.chkFecha.TabIndex = 18
        Me.chkFecha.Text = "&Fecha Ingreso"
        Me.chkFecha.UseVisualStyleBackColor = False
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamento.Location = New System.Drawing.Point(127, 99)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(202, 21)
        Me.cbDepartamento.TabIndex = 17
        '
        'chkDepto
        '
        Me.chkDepto.AutoSize = True
        Me.chkDepto.BackColor = System.Drawing.Color.White
        Me.chkDepto.ForeColor = System.Drawing.Color.Black
        Me.chkDepto.Location = New System.Drawing.Point(16, 99)
        Me.chkDepto.Name = "chkDepto"
        Me.chkDepto.Size = New System.Drawing.Size(105, 18)
        Me.chkDepto.TabIndex = 16
        Me.chkDepto.Text = "&Departamento"
        Me.chkDepto.UseVisualStyleBackColor = False
        '
        'cbAreas
        '
        Me.cbAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAreas.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAreas.Location = New System.Drawing.Point(127, 72)
        Me.cbAreas.Name = "cbAreas"
        Me.cbAreas.Size = New System.Drawing.Size(202, 21)
        Me.cbAreas.TabIndex = 15
        '
        'chkArea
        '
        Me.chkArea.AutoSize = True
        Me.chkArea.BackColor = System.Drawing.Color.White
        Me.chkArea.ForeColor = System.Drawing.Color.Black
        Me.chkArea.Location = New System.Drawing.Point(16, 69)
        Me.chkArea.Name = "chkArea"
        Me.chkArea.Size = New System.Drawing.Size(51, 18)
        Me.chkArea.TabIndex = 14
        Me.chkArea.Text = "&Área"
        Me.chkArea.UseVisualStyleBackColor = False
        '
        'chkNombres
        '
        Me.chkNombres.AutoSize = True
        Me.chkNombres.BackColor = System.Drawing.Color.White
        Me.chkNombres.ForeColor = System.Drawing.Color.Black
        Me.chkNombres.Location = New System.Drawing.Point(16, 21)
        Me.chkNombres.Name = "chkNombres"
        Me.chkNombres.Size = New System.Drawing.Size(75, 18)
        Me.chkNombres.TabIndex = 13
        Me.chkNombres.Text = "&Nombres"
        Me.chkNombres.UseVisualStyleBackColor = False
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.BackColor = System.Drawing.Color.White
        Me.chkEstado.ForeColor = System.Drawing.Color.Black
        Me.chkEstado.Location = New System.Drawing.Point(16, 45)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(63, 18)
        Me.chkEstado.TabIndex = 12
        Me.chkEstado.Text = "&Estado"
        Me.chkEstado.UseVisualStyleBackColor = False
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(335, 17)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(202, 22)
        Me.txtNombres.TabIndex = 8
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(127, 18)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(202, 21)
        Me.cbNombres.TabIndex = 7
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.Items.AddRange(New Object() {"A - Activas", "I - Inactivas"})
        Me.cbEstado.Location = New System.Drawing.Point(127, 45)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(202, 21)
        Me.cbEstado.TabIndex = 5
        '
        'dgPlazas
        '
        Me.dgPlazas.AllowUserToAddRows = False
        Me.dgPlazas.AllowUserToDeleteRows = False
        Me.dgPlazas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPlazas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPlazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPlazas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgPlazas.Location = New System.Drawing.Point(20, 293)
        Me.dgPlazas.Name = "dgPlazas"
        Me.dgPlazas.ReadOnly = True
        Me.dgPlazas.Size = New System.Drawing.Size(693, 180)
        Me.dgPlazas.TabIndex = 38
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 259)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 131
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 259)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 130
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 259)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 129
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 259)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 128
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLPlazas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(736, 518)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgPlazas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMPLPlazas"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Plazas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgPlazas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub Encabezado()
        Me.dgPlazas.Columns("NoPlaza").Visible = False
        Me.dgPlazas.Columns(0).HeaderText = "Codigo Empleado"
        Me.dgPlazas.Columns(2).HeaderText = "Nombres"
        Me.dgPlazas.Columns(3).HeaderText = "Primer Apellido"
        Me.dgPlazas.Columns(4).HeaderText = "Segundo Apellido"
        Me.dgPlazas.Columns(5).HeaderText = "DUI"
        Me.dgPlazas.Columns(6).Visible = False
        Me.dgPlazas.Columns(7).HeaderText = "Area"
        Me.dgPlazas.Columns(8).Visible = False
        Me.dgPlazas.Columns(9).HeaderText = "Departamento"
        Me.dgPlazas.Columns(10).Visible = False
        Me.dgPlazas.Columns(11).HeaderText = "Cargo"
        Me.dgPlazas.Columns(12).HeaderText = "Fecha Inicial"
        Me.dgPlazas.Columns(13).HeaderText = "Fecha Final"
        Me.dgPlazas.Columns(14).HeaderText = "Sueldo Mensual"
        Me.dgPlazas.Columns(15).Visible = False
        Me.dgPlazas.Columns(16).HeaderText = "Tipo Planilla"
        Me.dgPlazas.Columns(17).HeaderText = "Caso especial"
        Me.dgPlazas.Columns(18).HeaderText = "Estatus"
        Me.dgPlazas.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgPlazas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgPlazas.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgPlazas.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(15).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(16).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(17).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlazas.Columns(18).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

    End Sub
    Public Sub ActualizaGrid(ByVal Filtro As String)
        Dim ds As New Data.DataSet
        Try
            ds = oPlan.Consultar_PlPlazas(Filtro) 'muestra todas las plazas activas
            Me.dgPlazas.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos.", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub
    Private Sub frmMPLPlazas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbAreas.DisplayMember = "Descripcion"
        Me.cbAreas.ValueMember = "CodArea"
        Me.cbDepartamento.DisplayMember = "Descripcion"
        Me.cbDepartamento.ValueMember = "CodDepartamento"
        LlenarAreas()
    End Sub


    Private Sub rbEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.cbEstado.Focus()
    End Sub
    Private Sub txtCodCargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub txtCodPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub cbEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbEstado.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub rbNombres_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.cbNombres.Focus()
    End Sub
    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub LlenarAreas()
        Dim Dts As New DataSet
        Dts = oPlan.Consultar_PlAreas(sUsuario, sPassword, sSucursal, 1, "") ' 1 MUESTRA TODAS LAS AREAS
        Me.cbAreas.DataSource = Dts.Tables(0)
    End Sub
    Private Sub LlenarDepto()
        Dim Dts As New DataSet
        Dts = oPlan.CONSULTAR_PLDEPARTAMENTOS(sUsuario, sPassword, sSucursal, 2, Me.cbAreas.SelectedValue, "", "") '2 MUESTRA TODOS LOS DEPARTAMENTOS DE UN AREÁ ESPECIFICA.
        Me.cbDepartamento.DataSource = Dts.Tables(0)
    End Sub
    Private Sub cbAreas_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAreas.DropDownClosed
        LlenarDepto()
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            Dim ds As New Data.DataSet, pFiltro As String
            Dim Filtro As String = ""
            Dim Bandera As Boolean
            Bandera = False
            If Me.chkArea.Checked = True Then
                If Bandera = True Then
                    Filtro += " AND "
                End If
                Filtro += " Pl.CodArea = '" & Me.cbAreas.SelectedValue & "' "
                Bandera = True
            End If
            If Me.chkDepto.Checked = True Then
                If Bandera = True Then
                    Filtro += " AND "
                End If
                Filtro += " Pl.CodDepartamento = '" & Me.cbDepartamento.SelectedValue & "' "
                Bandera = True
            End If
            If Me.chkEstado.Checked = True Then
                If Bandera = True Then
                    Filtro += " AND "
                End If
                Dim Estado As String
                If Me.cbEstado.SelectedIndex = 0 Then
                    Estado = "A"
                Else
                    Estado = "I"
                End If
                Filtro += " Pl.ESTATUS = '" & Estado & "' "
                Bandera = True
            End If
            If Me.chkFecha.Checked = True Then
                If Bandera = True Then
                    Filtro += " AND "
                End If
                Filtro += " Pl.FechaInicial>= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and Pl.FechaInicial<= '" & Format(Me.dtpFechaFin.Value, "Short Date") & "'"
                Bandera = True
            End If
            If Me.chkNombres.Checked = True Then
                If Bandera = True Then
                    Filtro += " AND "
                End If
                If Me.cbNombres.SelectedIndex = 0 Then
                    Filtro += " E.Apellido1 like '" & Me.txtNombres.Text.Trim & "%" & "'"
                ElseIf Me.cbNombres.SelectedIndex = 1 Then
                    Filtro += " E.Apellido2 like '" & Me.txtNombres.Text.Trim & "%" & "'"
                ElseIf Me.cbNombres.SelectedIndex = 2 Then
                    Filtro += " E.Nombres like '" & Me.txtNombres.Text.Trim & "%" & "'"
                End If
            End If
            ActualizaGrid(Filtro)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMSPLPlazas
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            ActualizaGrid(" Pl.ESTATUS='A'")
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim ofrm As New frmMSPLPlazas
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            Dim Estatus As Boolean
            If Me.dgPlazas.CurrentRow.Index > -1 Then
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.Llenar_cbAreas()
                ofrm.Llenar_cbCargos()
                ofrm.Llenar_TipoPlanilla()
                If dgPlazas.Item("ESTATUS", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim = "I" Then
                    Estatus = True
                ElseIf dgPlazas.Item("ESTATUS", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim = "A" Then
                    Estatus = False
                End If
                ofrm.maskDUI.ReadOnly = False
                ofrm.txtNombres.ReadOnly = False
                ofrm.txtApellido1.ReadOnly = False
                ofrm.txtApellido2.ReadOnly = False
                '==========================================================================================================
                'ENCABEZADO DE FORM
                ofrm.txtCodEmpleado.Text = dgPlazas.Item("CODEMPLEADO", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.maskDUI.Text = dgPlazas.Item("DUI", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.txtApellido1.Text = dgPlazas.Item("APELLIDO1", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.txtApellido2.Text = dgPlazas.Item("APELLIDO2", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.txtNombres.Text = dgPlazas.Item("NOMBRES", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                '==========================================================================================================
                'CUERPO DE FORM
                ofrm.txtNoPlaza.Text = dgPlazas.Item("NOPLAZA", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.chkEstado.Checked = Estatus
                ofrm.chCasoEspecial.Checked = IIf(IsDBNull(dgPlazas.Item("CASOESPECIAL", Me.dgPlazas.CurrentRow.Index).Value) = True, False, True)
                ofrm.cbArea.SelectedValue = dgPlazas.Item("CODAREA", Me.dgPlazas.CurrentRow.Index).Value
                ofrm.Llenar_cbDepartamentos()
                ofrm.cbDepartamento.SelectedValue = dgPlazas.Item("CODDEPARTAMENTO", Me.dgPlazas.CurrentRow.Index).Value
                ofrm.cbCargo.SelectedValue = dgPlazas.Item("CODCARGO", Me.dgPlazas.CurrentRow.Index).Value
                ofrm.dtpFechaInicio.Value = Format(dgPlazas.Item("FECHAINICIAL", Me.dgPlazas.CurrentRow.Index).Value, "SHORT DATE")
                ofrm.dtpFechaFinal.Value = IIf(IsDBNull(Format(dgPlazas.Item("FECHAFINAL", Me.dgPlazas.CurrentRow.Index).Value, "SHORT DATE")) = True, Format(Now, "SHORT DATE"), dgPlazas.Item("FECHAFINAL", Me.dgPlazas.CurrentRow.Index).Value)
                ofrm.c1nSueldoMensual.Value = dgPlazas.Item("SUELDOMENSUAL", Me.dgPlazas.CurrentRow.Index).Value
                ofrm.cbPlanilla.SelectedValue = dgPlazas.Item("CODTIPOPLANILLA", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.chCasoEspecial.Checked = dgPlazas.Item("CASOESPECIAL", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                '==========================================================================================================
                ofrm.maskDUI.ReadOnly = True
                ofrm.txtNombres.ReadOnly = True
                ofrm.txtApellido1.ReadOnly = True
                ofrm.txtApellido2.ReadOnly = True
                ofrm.txtCodEmpleado.ReadOnly = True
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                btnMostrar1_Click(sender, e)
                ActualizaGrid(" Pl.ESTATUS='A'")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Dim Var As Integer
            If Me.dgPlazas.CurrentRow.Index > -1 Then
                If Val(MsgBox("¿Está seguro de eliminar el registro?", MsgBoxStyle.OkCancel, "Módulo - Planilla") = MsgBoxResult.Ok) Then
                    oPlan.Eliminar_PlPlazas(sUsuario, sPassword, sSucursal, Me.dgPlazas.Item("CODEMPLEADO", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim,
                                            Me.dgPlazas.Item("NOPLAZA", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim)
                End If
            End If
            Me.btnMostrar1.Focus()
            ActualizaGrid(" Pl.ESTATUS='A'")
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim ofrm As New frmMSPLPlazas
            'Dim oPlan As wsSysPlanCOOPAS.LibPlanillaCOOPAS.wsLibPlanillaCOOPAS = New wsSysPlanCOOPAS.LibPlanillaCOOPAS.wsLibPlanillaCOOPAS
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            Dim Estatus As Boolean
            If Me.dgPlazas.CurrentRow.Index > -1 Then
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.Llenar_cbAreas()
                ofrm.Llenar_cbCargos()
                'ofrm.Llenar_cbDepartamentos()
                ofrm.Llenar_TipoPlanilla()
                If dgPlazas.Item("ESTATUS", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim = "I" Then
                    Estatus = True
                ElseIf dgPlazas.Item("ESTATUS", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim = "A" Then
                    Estatus = False
                End If
                '==========================================================================================================
                'ENCABEZADO DE FORM
                ofrm.txtCodEmpleado.Text = dgPlazas.Item("CODEMPLEADO", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.maskDUI.Text = dgPlazas.Item("DUI", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.txtApellido1.Text = dgPlazas.Item("APELLIDO1", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.txtApellido2.Text = dgPlazas.Item("APELLIDO2", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.txtNombres.Text = dgPlazas.Item("CODEMPLEADO", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                '==========================================================================================================
                'CUERPO DE FORM
                ofrm.txtNoPlaza.Text = dgPlazas.Item("NOPLAZA", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.chkEstado.Checked = Estatus
                ofrm.chCasoEspecial.Checked = dgPlazas.Item("CASOESPECIAL", Me.dgPlazas.CurrentRow.Index).Value
                ofrm.cbArea.SelectedValue = dgPlazas.Item("CODAREA", Me.dgPlazas.CurrentRow.Index).Value
                ofrm.Llenar_cbDepartamentos()
                ofrm.cbDepartamento.SelectedValue = dgPlazas.Item("CODDEPARTAMENTO", Me.dgPlazas.CurrentRow.Index).Value
                ofrm.cbCargo.SelectedValue = dgPlazas.Item("CODCARGO", Me.dgPlazas.CurrentRow.Index).Value
                ofrm.dtpFechaInicio.Value = Format(dgPlazas.Item("FECHAINICIAL", Me.dgPlazas.CurrentRow.Index).Value, "SHORT DATE")
                ofrm.dtpFechaFinal.Value = Format(dgPlazas.Item("FECHAFINAL", Me.dgPlazas.CurrentRow.Index).Value, "SHORT DATE")
                ofrm.c1nSueldoMensual.Value = dgPlazas.Item("SUELDOMENSUAL", Me.dgPlazas.CurrentRow.Index).Value
                ofrm.cbPlanilla.SelectedValue = dgPlazas.Item("CODTIPOPLANILLA", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                ofrm.chCasoEspecial.Checked = dgPlazas.Item("CASOESPECIAL", Me.dgPlazas.CurrentRow.Index).Value.ToString.Trim
                '==========================================================================================================
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class