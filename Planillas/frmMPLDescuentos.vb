Public Class frmMPLDescuentos
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents chkNombres As System.Windows.Forms.CheckBox
    Friend WithEvents cbDescuentos As System.Windows.Forms.ComboBox
    Friend WithEvents chkTipoDescuento As System.Windows.Forms.CheckBox
    Friend WithEvents chkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Private oPlan As New wrPlanilla.wsLibPlanilla

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPLDescuentos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.chkFechas = New System.Windows.Forms.CheckBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.chkNombres = New System.Windows.Forms.CheckBox()
        Me.cbDescuentos = New System.Windows.Forms.ComboBox()
        Me.chkTipoDescuento = New System.Windows.Forms.CheckBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox2.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblFechaInicio)
        Me.GroupBox2.Controls.Add(Me.chkFechas)
        Me.GroupBox2.Controls.Add(Me.cbEstado)
        Me.GroupBox2.Controls.Add(Me.chkEstado)
        Me.GroupBox2.Controls.Add(Me.chkNombres)
        Me.GroupBox2.Controls.Add(Me.cbDescuentos)
        Me.GroupBox2.Controls.Add(Me.chkTipoDescuento)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(585, 135)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Descuentos:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(445, 90)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 78
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(335, 98)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFin.TabIndex = 19
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(174, 98)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 26)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fin"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(128, 97)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(40, 26)
        Me.lblFechaInicio.TabIndex = 16
        Me.lblFechaInicio.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inicio"
        '
        'chkFechas
        '
        Me.chkFechas.AutoSize = True
        Me.chkFechas.Location = New System.Drawing.Point(6, 96)
        Me.chkFechas.Name = "chkFechas"
        Me.chkFechas.Size = New System.Drawing.Size(56, 17)
        Me.chkFechas.TabIndex = 14
        Me.chkFechas.Text = "Fecha"
        Me.chkFechas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFechas.UseVisualStyleBackColor = True
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Items.AddRange(New Object() {"Activo", "Cancelado"})
        Me.cbEstado.Location = New System.Drawing.Point(129, 71)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(152, 21)
        Me.cbEstado.TabIndex = 13
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(6, 73)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(59, 17)
        Me.chkEstado.TabIndex = 12
        Me.chkEstado.Text = "Estado"
        Me.chkEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'chkNombres
        '
        Me.chkNombres.AutoSize = True
        Me.chkNombres.Location = New System.Drawing.Point(6, 46)
        Me.chkNombres.Name = "chkNombres"
        Me.chkNombres.Size = New System.Drawing.Size(68, 17)
        Me.chkNombres.TabIndex = 11
        Me.chkNombres.Text = "Nombres"
        Me.chkNombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNombres.UseVisualStyleBackColor = True
        '
        'cbDescuentos
        '
        Me.cbDescuentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDescuentos.Location = New System.Drawing.Point(129, 17)
        Me.cbDescuentos.Name = "cbDescuentos"
        Me.cbDescuentos.Size = New System.Drawing.Size(152, 21)
        Me.cbDescuentos.TabIndex = 10
        '
        'chkTipoDescuento
        '
        Me.chkTipoDescuento.AutoSize = True
        Me.chkTipoDescuento.Location = New System.Drawing.Point(6, 19)
        Me.chkTipoDescuento.Name = "chkTipoDescuento"
        Me.chkTipoDescuento.Size = New System.Drawing.Size(117, 17)
        Me.chkTipoDescuento.TabIndex = 9
        Me.chkTipoDescuento.Text = "Tipo de Descuento"
        Me.chkTipoDescuento.UseVisualStyleBackColor = True
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(287, 44)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(152, 20)
        Me.txtNombres.TabIndex = 6
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(129, 44)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(152, 21)
        Me.cbNombres.TabIndex = 5
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 238)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(690, 218)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 37
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 204)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 87
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 204)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 86
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 204)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 85
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 204)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 84
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLDescuentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(736, 512)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMPLDescuentos"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Descuentos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ActualizaGrid()
        Dim ds As New Data.DataSet
        Try
            ds = oPlan.ConsultarPLDescuentos("b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.*",
                                             "a.Estado='N' and a.tipoplanilla <> 0 ", "a.CodEmpleado", True, sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub
    Private Sub LlenarcbDescuentos()
        Dim Dts As New DataSet
        Dts = oPlan.ConsultarPLTipoDescuentos("*", "", "CodTipoDescuento", sUsuario, sPassword, sSucursal)
        Me.cbDescuentos.DataSource = Dts.Tables(0)
    End Sub
    Private Sub Encabezado()
        fg.Cols.Item("CodEmpleado").Visible = False
        fg.Cols.Item("CodTipoDescuento").Visible = False
        fg.Cols.Item("TipoPlanilla").Visible = False
        fg.Cols.Item("NoPlaza").Visible = False
        fg.Cols.Item("Aplica").Visible = False
        fg.Cols.Item("Correlativo").Visible = False
        fg.Cols.Item("Fijo").Visible = False
        fg.Cols.Item("Pago").Visible = False
        fg.Cols.Item("Nombres").Caption = "Empleado"
        fg.Cols.Item("Descuento").Caption = "Tipo de Descuento"
        fg.Cols.Item("NoCuotas").Caption = "No. Cuotas"
        fg.Cols.Item("Planilla").Caption = "Tipo de Planilla"
        fg.Cols.Item("FechaInicio").Caption = "Fecha Inicio"
        fg.Cols.Item("CuotasPagadas").Caption = "Cuotas Pagadas"
        fg.Cols.Item("FechaFin").Caption = "Fecha Fin"
    End Sub


    Private Sub frmMPLDescuentosRemuneraciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbDescuentos.DisplayMember = "Descripcion"
        Me.cbDescuentos.ValueMember = "CodTipoDescuento"
        LlenarcbDescuentos()
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMSPLDescuentos
            ofrm.vAccion = "Agregar"
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            btnMostrar1_Click(sender, e)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If fg.Row <> -1 Then
                oPlan.EliminarPLDescuentos("'" & Trim(fg.Item(fg.Row, "Correlativo")) & "'", sUsuario, sPassword, sSucursal)
                Me.btnMostrar1.Focus()
            End If
            btnMostrar1_Click(sender, e)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim ofrm As New frmMSPLDescuentos
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            If fg.Row <> -1 Then
                ofrm.dtpFechaInicio.Value = Now
                ofrm.dtpFechaFin.Value = Now
                ofrm.vAccion = "Modificar"
                ofrm.btnGuardar1.Text = "&Modificar"
                ds = oPlan.ConsultarPLDescuentos("b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.*", "a.Correlativo='" & Trim(fg.Item(fg.Row, "Correlativo")) & "'", "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.vCorrelativo = Trim(fg.Item(fg.Row, "Correlativo"))
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                btnMostrar1_Click(sender, e)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim ofrm As New frmMSPLDescuentos
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            If fg.Row <> -1 Then
                ofrm.dtpFechaInicio.Value = Now
                ofrm.dtpFechaFin.Value = Now
                ofrm.vAccion = "Consultar"
                ofrm.btnGuardar1.Text = "&Consultar"
                ds = oPlan.ConsultarPLDescuentos("b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.*", "a.Correlativo='" & Trim(fg.Item(fg.Row, "Correlativo")) & "'", "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.vCorrelativo = Trim(fg.Item(fg.Row, "Correlativo"))
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                btnMostrar1_Click(sender, e)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try

            Dim ds As New Data.DataSet, pFiltro As String
            '1 Tipo de Descuentos 
            Dim Campos As String = "b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres, " &
            "a.CodEmpleado,a.CodTipoDescuento,td.Descripcion [Descuento],a.Monto,a.NoCuotas,a.MontoCuota [Cuota] ," &
            "a.FechaInicio,a.FechaFin,a.CuotasPagadas,a.Estado,a.TipoPlanilla,TP.Descripcion [Planilla],a.Observacion, " &
            "a.Aplica,a.Correlativo,a.Fijo,a.NoPlaza,a.Pago,a.Referencia,a.Saldo"

            If Me.chkTipoDescuento.Checked = True And Me.chkNombres.Checked = False And
            Me.chkEstado.Checked = False And Me.chkFechas.Checked = False Then
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                                 "a.CodTipoDescuento= '" & Trim(Me.cbDescuentos.SelectedValue) & "'",
                                                 "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '2 Nombres
            ElseIf Me.chkTipoDescuento.Checked = False And Me.chkNombres.Checked = True And
            Me.chkEstado.Checked = False And Me.chkFechas.Checked = False Then
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%'"
                End If
                ds = oPlan.ConsultarPLDescuentos("b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.*", pFiltro, "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '3 Estado
            ElseIf Me.chkTipoDescuento.Checked = False And Me.chkNombres.Checked = False And
            Me.chkEstado.Checked = True And Me.chkFechas.Checked = False Then
                Dim Estado As Char
                If Me.cbEstado.SelectedIndex = 0 Then
                    Estado = "N"
                Else
                    Estado = "C"
                End If
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                                "a.Estado= '" & Estado & "'",
                                                "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '4 Fechas
            ElseIf Me.chkTipoDescuento.Checked = False And Me.chkNombres.Checked = False And
            Me.chkEstado.Checked = False And Me.chkFechas.Checked = True Then
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                               "a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'",
                                               "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '5 nombres, tipos descuentos
            ElseIf Me.chkTipoDescuento.Checked = True And Me.chkNombres.Checked = True And
            Me.chkEstado.Checked = False And Me.chkFechas.Checked = False Then
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%' and a.CodTipoDescuento = '" & Me.cbDescuentos.SelectedValue & "'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%' and a.CodTipoDescuento = '" & Me.cbDescuentos.SelectedValue & "'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%' and a.CodTipoDescuento = '" & Me.cbDescuentos.SelectedValue & "'"
                End If
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                                 pFiltro,
                                                "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '6 Tipos descuento y estado
            ElseIf Me.chkTipoDescuento.Checked = True And Me.chkNombres.Checked = False And
            Me.chkEstado.Checked = True And Me.chkFechas.Checked = False Then
                Dim Estado As Char
                If Me.cbEstado.SelectedIndex = 0 Then
                    Estado = "N"
                Else
                    Estado = "C"
                End If
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                                "a.Estado= '" & Estado & "' and a.CodTipoDescuento = '" & Me.cbDescuentos.SelectedValue & "'",
                                                "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '7 Tipos descuento y Fecha 
            ElseIf Me.chkTipoDescuento.Checked = True And Me.chkNombres.Checked = False And
            Me.chkEstado.Checked = False And Me.chkFechas.Checked = True Then
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                              "a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "' and a.CodTipoDescuento = '" & Me.cbDescuentos.SelectedValue & "'",
                                              "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '8 Nombres y Estado
            ElseIf Me.chkTipoDescuento.Checked = False And Me.chkNombres.Checked = True And
            Me.chkEstado.Checked = True And Me.chkFechas.Checked = False Then
                Dim Estado As Char
                If Me.cbEstado.SelectedIndex = 0 Then
                    Estado = "N"
                Else
                    Estado = "C"
                End If
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%' and a.Estado = '" & Estado & "'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%' and a.Estado = '" & Estado & "'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%' and a.Estado = '" & Estado & "'"
                End If
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                                 pFiltro,
                                                "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '9 Nombres y Fecha
            ElseIf Me.chkTipoDescuento.Checked = False And Me.chkNombres.Checked = True And
            Me.chkEstado.Checked = False And Me.chkFechas.Checked = True Then
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'"
                End If
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                                 pFiltro,
                                                "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '10 Estado y Fecha
            ElseIf Me.chkTipoDescuento.Checked = False And Me.chkNombres.Checked = False And
            Me.chkEstado.Checked = True And Me.chkFechas.Checked = True Then
                Dim Estado As Char
                If Me.cbEstado.SelectedIndex = 0 Then
                    Estado = "N"
                Else
                    Estado = "C"
                End If
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                              "a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "' and a.Estado = '" & Estado & "'",
                                              "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '11 Tipo de descuento, Nombre, Estado
            ElseIf Me.chkTipoDescuento.Checked = True And Me.chkNombres.Checked = True And
            Me.chkEstado.Checked = True And Me.chkFechas.Checked = False Then
                Dim Estado As Char
                If Me.cbEstado.SelectedIndex = 0 Then
                    Estado = "N"
                Else
                    Estado = "C"
                End If
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%' and a.CodTipoDescuento='" & Me.cbDescuentos.SelectedValue & "' and a.estado='" & Estado & "'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%' and a.CodTipoDescuento='" & Me.cbDescuentos.SelectedValue & "' and a.estado='" & Estado & "'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%' and  a.CodTipoDescuento='" & Me.cbDescuentos.SelectedValue & "' and a.estado='" & Estado & "'"
                End If
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                                 pFiltro,
                                                "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '12 Tipo de descuento, Nombre, Fecha
            ElseIf Me.chkTipoDescuento.Checked = True And Me.chkNombres.Checked = True And
            Me.chkEstado.Checked = False And Me.chkFechas.Checked = True Then
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%' and a.CodTipoDescuento='" & Me.cbDescuentos.SelectedValue & "' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%' and a.CodTipoDescuento='" & Me.cbDescuentos.SelectedValue & "' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%' and  a.CodTipoDescuento='" & Me.cbDescuentos.SelectedValue & "' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'"
                End If
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                                 pFiltro,
                                                "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '13 Nombre, Estado, Fecha
            ElseIf Me.chkTipoDescuento.Checked = False And Me.chkNombres.Checked = True And
            Me.chkEstado.Checked = True And Me.chkFechas.Checked = True Then
                Dim Estado As Char
                If Me.cbEstado.SelectedIndex = 0 Then
                    Estado = "N"
                Else
                    Estado = "C"
                End If
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%' and a.estado='" & Estado & "' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%' and a.estado='" & Estado & "' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%' and a.estado='" & Estado & "' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "'"
                End If
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                                 pFiltro,
                                                "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
                '14 Nombre, Estado, Fecha,Tipo de Descuento
            ElseIf Me.chkTipoDescuento.Checked = True And Me.chkNombres.Checked = True And
            Me.chkEstado.Checked = True And Me.chkFechas.Checked = True Then
                Dim Estado As Char
                If Me.cbEstado.SelectedIndex = 0 Then
                    Estado = "N"
                Else
                    Estado = "C"
                End If
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro = "b.Apellido1 like '" & Trim(txtNombres.Text) & "%' and a.estado='" & Estado & "' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "' and a.CodTipoDescuento = '" & Me.cbDescuentos.SelectedValue & "'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro = "b.Apellido2 like '" & Trim(txtNombres.Text) & "%' and a.estado='" & Estado & "' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "' and a.CodTipoDescuento = '" & Me.cbDescuentos.SelectedValue & "'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro = "b.Nombres like '" & Trim(txtNombres.Text) & "%' and a.estado='" & Estado & "' and a.FechaInicio<= '" & Format(Me.dtpFechaInicio.Value, "Short Date") & "' and a.FechaFin>='" & Format(Me.dtpFechaFin.Value, "Short Date") & "' and a.CodTipoDescuento = '" & Me.cbDescuentos.SelectedValue & "'"
                End If
                ds = oPlan.ConsultarPLDescuentos(Campos,
                                                 pFiltro,
                                                "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class