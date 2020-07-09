Public Class frmMPLIngresos
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents cbTiposIngreso As System.Windows.Forms.ComboBox
    Friend WithEvents chkNombres As System.Windows.Forms.CheckBox
    Friend WithEvents chkTipoIngreso As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPLIngresos))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.chkFechas = New System.Windows.Forms.CheckBox()
        Me.chkNombres = New System.Windows.Forms.CheckBox()
        Me.chkTipoIngreso = New System.Windows.Forms.CheckBox()
        Me.cbTiposIngreso = New System.Windows.Forms.ComboBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 217)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(549, 168)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblFechaInicio)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox2.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox2.Controls.Add(Me.chkFechas)
        Me.GroupBox2.Controls.Add(Me.chkNombres)
        Me.GroupBox2.Controls.Add(Me.chkTipoIngreso)
        Me.GroupBox2.Controls.Add(Me.cbTiposIngreso)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 114)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Ingresos:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(438, 72)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 106
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(280, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 26)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fin"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.ForeColor = System.Drawing.Color.Black
        Me.lblFechaInicio.Location = New System.Drawing.Point(119, 79)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(40, 26)
        Me.lblFechaInicio.TabIndex = 14
        Me.lblFechaInicio.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inicio"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(323, 80)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(109, 20)
        Me.dtpFechaFin.TabIndex = 13
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(165, 80)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(109, 20)
        Me.dtpFechaInicio.TabIndex = 12
        '
        'chkFechas
        '
        Me.chkFechas.AutoSize = True
        Me.chkFechas.ForeColor = System.Drawing.Color.Black
        Me.chkFechas.Location = New System.Drawing.Point(16, 83)
        Me.chkFechas.Name = "chkFechas"
        Me.chkFechas.Size = New System.Drawing.Size(61, 17)
        Me.chkFechas.TabIndex = 11
        Me.chkFechas.Text = "Fechas"
        Me.chkFechas.UseVisualStyleBackColor = True
        '
        'chkNombres
        '
        Me.chkNombres.AutoSize = True
        Me.chkNombres.ForeColor = System.Drawing.Color.Black
        Me.chkNombres.Location = New System.Drawing.Point(16, 55)
        Me.chkNombres.Name = "chkNombres"
        Me.chkNombres.Size = New System.Drawing.Size(68, 17)
        Me.chkNombres.TabIndex = 10
        Me.chkNombres.Text = "Nombres"
        Me.chkNombres.UseVisualStyleBackColor = True
        '
        'chkTipoIngreso
        '
        Me.chkTipoIngreso.AutoSize = True
        Me.chkTipoIngreso.ForeColor = System.Drawing.Color.Black
        Me.chkTipoIngreso.Location = New System.Drawing.Point(16, 28)
        Me.chkTipoIngreso.Name = "chkTipoIngreso"
        Me.chkTipoIngreso.Size = New System.Drawing.Size(100, 17)
        Me.chkTipoIngreso.TabIndex = 9
        Me.chkTipoIngreso.Text = "Tipo de Ingreso"
        Me.chkTipoIngreso.UseVisualStyleBackColor = True
        '
        'cbTiposIngreso
        '
        Me.cbTiposIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTiposIngreso.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbTiposIngreso.Location = New System.Drawing.Point(122, 26)
        Me.cbTiposIngreso.Name = "cbTiposIngreso"
        Me.cbTiposIngreso.Size = New System.Drawing.Size(152, 21)
        Me.cbTiposIngreso.TabIndex = 8
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(280, 54)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(152, 20)
        Me.txtNombres.TabIndex = 6
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(122, 53)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(152, 21)
        Me.cbNombres.TabIndex = 5
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 183)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 111
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 183)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 110
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 183)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 109
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 183)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 108
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(347, 183)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 112
        Me.MetroButton1.Text = "Bono Anual"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(428, 183)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(142, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 113
        Me.MetroButton2.Text = "Comisiones Ejecutivos"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'frmMPLIngresos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(595, 446)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMPLIngresos"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Ingresos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ActualizaGrid()
        Dim ds As New Data.DataSet
        Try
            ds = oPlan.ConsultarPLIngresos("b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,TI.Descripcion[TipoIngreso],TP.Descripcion[TipoPlanilla],a.*", "", "a.CodEmpleado", True, sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub
    Private Sub Encabezado()
        Try
            fg.Cols.Item("CodEmpleado").Visible = False
            fg.Cols.Item("CodTipoIngreso").Visible = False
            fg.Cols.Item("NoPlaza").Visible = False
            fg.Cols.Item("Aplica").Visible = False
            fg.Cols.Item("CodTipoPlanilla").Visible = False
            fg.Cols.Item("Estado").Visible = False

            fg.Cols.Item("Nombres").Caption = "Empleado"
            fg.Cols.Item("TipoIngreso").Caption = "Tipo de Ingreso"
            fg.Cols.Item("Fecha").Caption = "Fecha Inicio"
            fg.Cols.Item("FechaF").Caption = "Fecha Fin"
            fg.Cols.Item("TipoPlanilla").Caption = "Tipo de Planilla"

        Catch ex As Exception
            MsgBox("Por favor comunicarse con el administrador del sistema." + vbCrLf + vbCrLf + ex.Message,
                   MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try

    End Sub


    Private Sub frmMPLIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbTiposIngreso.DisplayMember = "Descripcion"
        Me.cbTiposIngreso.ValueMember = "CodTipoIngreso"
        LlenarTiposIngresos()
    End Sub

    Private Sub txtCodEmpleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub txtTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub rbNombres_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.cbNombres.Focus()
    End Sub
    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub LlenarTiposIngresos()
        Dim Dts As New DataSet
        Dts = oPlan.ConsultarPLTipoIngresos("*", "", "CodTipoIngreso", sUsuario, sPassword, sSucursal)
        Me.cbTiposIngreso.DataSource = Dts.Tables(0)
    End Sub


    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            Dim ds As New Data.DataSet, pFiltro As String
            Dim Campos As String = "a.Correlativo, b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres, " &
            "a.CodEmpleado,a.CodTipoIngreso,TI.Descripcion [TipoIngreso],a.NoPlaza, " &
            "a.Monto,a.NoCuotas,a.Fecha ,a.FechaF,a.Estado,a.Aplica,a.CodTipoPlanilla, " &
            "tp.Descripcion [TipoPlanilla], a.Quincena"
            '1
            If Me.chkFechas.Checked = True And Me.chkNombres.Checked = False And Me.chkTipoIngreso.Checked = False Then 'Filtra por Fechas
                ds = oPlan.ConsultarPLIngresos(Campos,
                                               "a.fecha<='" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.fechaF >='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'",
                                               "a.CodTipoIngreso", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '2
            ElseIf Me.chkFechas.Checked = False And Me.chkNombres.Checked = True And Me.chkTipoIngreso.Checked = False Then 'Filtra por Nombres
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%'"
                End If
                ds = oPlan.ConsultarPLIngresos(Campos, pFiltro, "a.CodTipoIngreso", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '3
            ElseIf Me.chkFechas.Checked = False And Me.chkNombres.Checked = False And Me.chkTipoIngreso.Checked = True Then 'Filtra por tipo de ingreso
                ds = oPlan.ConsultarPLIngresos(Campos, "a.CodTipoIngreso='" & Me.cbTiposIngreso.SelectedValue & "'", "a.CodTipoIngreso", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '4
            ElseIf Me.chkFechas.Checked = True And Me.chkNombres.Checked = True And Me.chkTipoIngreso.Checked = False Then 'Filtra por Nombres y fecha
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%'"
                End If
                ds = oPlan.ConsultarPLIngresos(Campos,
                                               pFiltro & " and Fecha <='" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and FechaF >='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'",
                                               "a.CodTipoIngreso", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '5
            ElseIf Me.chkFechas.Checked = False And Me.chkNombres.Checked = True And Me.chkTipoIngreso.Checked = True Then 'Filtra por Nombres y Tipo de Ingreso
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%'"
                End If
                ds = oPlan.ConsultarPLIngresos(Campos,
                                               pFiltro & " and a.CodTipoIngreso='" & Me.cbTiposIngreso.SelectedValue & "'",
                                               "a.CodTipoIngreso", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '6
            ElseIf Me.chkFechas.Checked = True And Me.chkNombres.Checked = False And Me.chkTipoIngreso.Checked = True Then 'Filtra por Fecha y Tipo de Ingreso
                ds = oPlan.ConsultarPLIngresos(Campos,
                                               "a.codtipoingreso='" & Me.cbTiposIngreso.SelectedValue & "' and a.Fecha <='" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaF >='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'",
                                              "a.CodTipoIngreso", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMsPLIngresos
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim ofrm As New frmMsPLIngresos, ds As New Data.DataSet, dr As DataRow
            If fg.Row <> -1 Then
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.pCorrelativo = fg.Item(fg.Row, "Correlativo")
                ofrm.cbTipoPlanilla.DisplayMember = "DESCRIPCION"
                ofrm.cbTipoPlanilla.ValueMember = "CODTIPOPLANILLA"
                ofrm.LlenarTiposPlanillas()
                ofrm.dtpFecha.Value = fg.Item(fg.Row, "Fecha")
                ofrm.dtFechaF.Value = fg.Item(fg.Row, "FechaF")
                ofrm.txtCodEmpleado.Text = fg.Item(fg.Row, "CodEmpleado")
                ofrm.txtNombreEmp.Text = fg.Item(fg.Row, "Nombres")
                ofrm.txtNumPlaza.Text = fg.Item(fg.Row, "NoPlaza")
                ofrm.txtCodTipoIngreso.Text = fg.Item(fg.Row, "CodTipoIngreso")
                ofrm.txtTipoIngreso.Text = fg.Item(fg.Row, "TipoIngreso")
                ofrm.c1Monto.Value = fg.Item(fg.Row, "Monto")
                ofrm.c1NoCuotas.Value = fg.Item(fg.Row, "NoCuotas")
                ofrm.cbTipoPlanilla.SelectedValue = fg.Item(fg.Row, "CodTipoPlanilla")
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizaGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If fg.Row <> -1 Then
                If (MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Módulo - Planilla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = MsgBoxResult.Ok) Then
                    oPlan.EliminarPLIngresos("'" & Trim(fg.Item(fg.Row, "Correlativo")) & "'", sUsuario, sPassword, sSucursal)
                    Me.btnMostrar1.Focus()
                End If
            End If
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim ofrm As New frmMsPLIngresos, ds As New Data.DataSet, dr As DataRow
            If fg.Row <> -1 Then
                ofrm.dtpFecha.Value = Now
                ofrm.dtFechaF.Value = Now
                ofrm.btnGuardar1.Text = "&Modificar"
                ds = oPlan.ConsultarPLIngresos("b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.*", "a.Correlativo='" & Trim(fg.Item(fg.Row, "Correlativo")) & "'", "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.pCorrelativo = Trim(fg.Item(fg.Row, "Correlativo"))
                ofrm.txtCodEmpleado.Text = dr("CodEmpleado")
                ofrm.txtCodEmpleado.ReadOnly = True
                ofrm.txtNumPlaza.Text = IIf(IsDBNull(dr("NoPlaza")) = True, "01", dr("NoPlaza"))
                ofrm.txtCodTipoIngreso.Text = dr("CodTipoIngreso")
                ofrm.c1Monto.Value = dr("Monto")
                ofrm.c1NoCuotas.Value = dr("NoCuotas")
                ofrm.dtpFecha.Value = dr("Fecha")
                ofrm.dtFechaF.Value = dr("FechaF")
                If IIf(IsDBNull(dr("Estado")), "N", dr("Estado")) = "N" Then
                    ofrm.chkCancelado.Checked = False
                Else
                    ofrm.chkCancelado.Checked = True
                End If
                ofrm.btnGuardar1.Enabled = False
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizaGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim Frm As New frmMsIngresoBonificacion
            Frm.lblOpcion.Text = "B"
            Frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim Frm As New frmMsIngresoComisionMerca
            Frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class