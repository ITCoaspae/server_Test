Public Class frmMPLAusentismo
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents cbTipoAusentismo As System.Windows.Forms.ComboBox
    Friend WithEvents chkNombres As System.Windows.Forms.CheckBox
    Friend WithEvents chkCodEmpleado As System.Windows.Forms.CheckBox
    Friend WithEvents chkTipoAusentismo As System.Windows.Forms.CheckBox
    Friend WithEvents chkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Dim oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodEmp As System.Windows.Forms.TextBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents dtpF1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpF2 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPLAusentismo))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.chkFechas = New System.Windows.Forms.CheckBox()
        Me.chkNombres = New System.Windows.Forms.CheckBox()
        Me.chkCodEmpleado = New System.Windows.Forms.CheckBox()
        Me.chkTipoAusentismo = New System.Windows.Forms.CheckBox()
        Me.cbTipoAusentismo = New System.Windows.Forms.ComboBox()
        Me.dtpF2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.dtpF1 = New System.Windows.Forms.DateTimePicker()
        Me.txtCodEmp = New System.Windows.Forms.TextBox()
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
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.chkFechas)
        Me.GroupBox2.Controls.Add(Me.chkNombres)
        Me.GroupBox2.Controls.Add(Me.chkCodEmpleado)
        Me.GroupBox2.Controls.Add(Me.chkTipoAusentismo)
        Me.GroupBox2.Controls.Add(Me.cbTipoAusentismo)
        Me.GroupBox2.Controls.Add(Me.dtpF2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.dtpF1)
        Me.GroupBox2.Controls.Add(Me.txtCodEmp)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 138)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar datos por:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(470, 99)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 66
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'chkFechas
        '
        Me.chkFechas.AutoSize = True
        Me.chkFechas.Location = New System.Drawing.Point(6, 102)
        Me.chkFechas.Name = "chkFechas"
        Me.chkFechas.Size = New System.Drawing.Size(62, 17)
        Me.chkFechas.TabIndex = 16
        Me.chkFechas.Text = "Periodo"
        Me.chkFechas.UseVisualStyleBackColor = True
        '
        'chkNombres
        '
        Me.chkNombres.AutoSize = True
        Me.chkNombres.Location = New System.Drawing.Point(6, 71)
        Me.chkNombres.Name = "chkNombres"
        Me.chkNombres.Size = New System.Drawing.Size(68, 17)
        Me.chkNombres.TabIndex = 15
        Me.chkNombres.Text = "Nombres"
        Me.chkNombres.UseVisualStyleBackColor = True
        '
        'chkCodEmpleado
        '
        Me.chkCodEmpleado.AutoSize = True
        Me.chkCodEmpleado.Location = New System.Drawing.Point(6, 48)
        Me.chkCodEmpleado.Name = "chkCodEmpleado"
        Me.chkCodEmpleado.Size = New System.Drawing.Size(124, 17)
        Me.chkCodEmpleado.TabIndex = 14
        Me.chkCodEmpleado.Text = "Código de Empleado"
        Me.chkCodEmpleado.UseVisualStyleBackColor = True
        '
        'chkTipoAusentismo
        '
        Me.chkTipoAusentismo.AutoSize = True
        Me.chkTipoAusentismo.Location = New System.Drawing.Point(6, 19)
        Me.chkTipoAusentismo.Name = "chkTipoAusentismo"
        Me.chkTipoAusentismo.Size = New System.Drawing.Size(119, 17)
        Me.chkTipoAusentismo.TabIndex = 13
        Me.chkTipoAusentismo.Text = "Tipo de Ausentismo"
        Me.chkTipoAusentismo.UseVisualStyleBackColor = True
        '
        'cbTipoAusentismo
        '
        Me.cbTipoAusentismo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoAusentismo.FormattingEnabled = True
        Me.cbTipoAusentismo.Location = New System.Drawing.Point(136, 19)
        Me.cbTipoAusentismo.Name = "cbTipoAusentismo"
        Me.cbTipoAusentismo.Size = New System.Drawing.Size(177, 21)
        Me.cbTipoAusentismo.TabIndex = 12
        '
        'dtpF2
        '
        Me.dtpF2.CustomFormat = "MMMM/yyyy"
        Me.dtpF2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpF2.Location = New System.Drawing.Point(281, 99)
        Me.dtpF2.Name = "dtpF2"
        Me.dtpF2.Size = New System.Drawing.Size(101, 20)
        Me.dtpF2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(243, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "al:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(98, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Del:"
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(319, 73)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(226, 20)
        Me.txtNombres.TabIndex = 6
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(136, 72)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(177, 21)
        Me.cbNombres.TabIndex = 5
        '
        'dtpF1
        '
        Me.dtpF1.CustomFormat = "MMMM/yyyy"
        Me.dtpF1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpF1.Location = New System.Drawing.Point(136, 99)
        Me.dtpF1.Name = "dtpF1"
        Me.dtpF1.Size = New System.Drawing.Size(101, 20)
        Me.dtpF1.TabIndex = 8
        '
        'txtCodEmp
        '
        Me.txtCodEmp.Location = New System.Drawing.Point(136, 46)
        Me.txtCodEmp.MaxLength = 25
        Me.txtCodEmp.Name = "txtCodEmp"
        Me.txtCodEmp.Size = New System.Drawing.Size(177, 20)
        Me.txtCodEmp.TabIndex = 3
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 241)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(562, 125)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 44
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 207)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 71
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 207)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 70
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 207)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 69
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 207)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 68
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLAusentismo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(608, 420)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMPLAusentismo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Ausentismo"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Encabezado()

        fg.Cols.Item(2).Caption = "No."
        fg.Cols.Item(3).Caption = "Código"
        fg.Cols.Item(4).Caption = "Cód. Ausentismo"
        fg.Cols.Item(5).Caption = "Hora Inicio"
        fg.Cols.Item(6).Caption = "Hora Fin"
        fg.Cols.Item(7).Caption = "Total Horas"
        fg.Cols.Item(8).Caption = "Fecha Inicio"
        fg.Cols.Item(9).Caption = "Fecha Fin"
        fg.Cols.Item(10).Caption = "Observaciones"
        fg.Cols.Item(11).Caption = "Período Inicio"
        fg.Cols.Item(12).Caption = "Período Fin"

        fg.Cols.Item(0).Width = 10
        fg.Cols.Item(2).Width = 0
        fg.Cols.Item(11).Width = 0

    End Sub
    Private Sub LlenarCBAusentismo()
        Dim Dts As New DataSet
        Dts = oPlan.ConsultarPLMotivoAusentismo("CodAusentismo,Descripcion", "", "CodAusentismo", sUsuario, sPassword, sSucursal)
        Me.cbTipoAusentismo.DataSource = Dts.Tables(0)
    End Sub
    Private Sub ActualizarGrid()
        Dim ds As New Data.DataSet
        Try
            ds = oPlan.ConsultarPLAusentismo("b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.*", "a.Tipo='M'", "a.CodAusentismo", True, sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frmMPLAusentismo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()
        Me.cbTipoAusentismo.DisplayMember = "Descripcion"
        Me.cbTipoAusentismo.ValueMember = "CodAusentismo"
        LlenarCBAusentismo()
    End Sub


    Private Sub rbtCodEmpleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodEmp.Focus()
    End Sub
    Private Sub rbMes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.dtpF1.Focus()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMSPLAusentismo
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.dtpFechaInicio.Value = Now
            ofrm.dtpFechaFin.Value = Now
            ofrm.dtpPI.Value = Now
            ofrm.dtpPF.Value = Now
            ofrm.StartPosition = FormStartPosition.CenterParent
            ofrm.ShowDialog()
            MetroButton1_Click(sender, e)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim dr As DataRow
        Dim ofrm As New frmMSPLAusentismo
        Dim ds As New Data.DataSet
        If fg.Row <> -1 Then
            Try
                ds = oPlan.ConsultarPLAusentismo("b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.*", "a.Correlativo = " & Trim(fg.Item(fg.Row, "Correlativo")) & "", "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.pCorrelativo = Trim(fg.Item(fg.Row, "Correlativo"))
                ofrm.txtCodEmpleado.Text = IIf(IsDBNull(dr("CodEmpleado")), "", dr("CodEmpleado"))
                ofrm.txtNomEmpleado.ReadOnly = True
                ofrm.txtCodMotivoAusentismo.Text = IIf(IsDBNull(dr("CodAusentismo")), "", dr("CodAusentismo"))
                ofrm.txtCodMotivoAusentismo.ReadOnly = True
                If Not IsDBNull(dr("FechaInicio")) Then ofrm.dtpFechaInicio.Value = dr("FechaInicio")
                If Not IsDBNull(dr("FechaFin")) Then ofrm.dtpFechaFin.Value = dr("FechaFin")
                ofrm.dtpHoraInicio.Text = dr("HoraInicio")
                ofrm.dtpHoraFin.Text = dr("HoraFin")
                ofrm.txtCantidadHoras.Text = dr("TotalHoras")
                If Not IsDBNull(dr("Tipo")) Then
                    If dr("Tipo") = "G" Then
                        ofrm.chkTotal.Checked = True
                    Else
                        ofrm.chkTotal.Checked = False
                    End If
                Else
                    ofrm.chkTotal.Checked = False
                End If
                ofrm.txtObservaciones.Text = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                ofrm.dtpPI.Value = IIf(IsDBNull(dr("PeriodoInicio")), Now, dr("PeriodoInicio"))
                ofrm.dtpPF.Value = IIf(IsDBNull(dr("PeriodoFin")), Now, dr("PeriodoFin"))
                ofrm.StartPosition = FormStartPosition.CenterParent
                ofrm.ShowDialog()
                MetroButton1_Click(sender, e)
            Catch ex As Exception
                MsgBox(mensajeError, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If fg.Row <> -1 Then
                Try
                    If (MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Módulo - Planilla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = MsgBoxResult.Ok) Then
                        If oPlan.EliminarPLAusentismo("CodEmpleado = '" & Trim(fg.Item(fg.Row, "CodEmpleado")) & "' AND CodAusentismo='" & Trim(fg.Item(fg.Row, "CodAusentismo")) & "'", sUsuario, sPassword, sSucursal) = True Then
                            MsgBox("Registro eliminado.", MsgBoxStyle.Information, "Módulo - Planilla")
                            MetroButton1_Click(sender, e)
                        Else
                            MsgBox("Registro NO eliminado.", MsgBoxStyle.Information, "Módulo - Planilla")
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Dim dr As DataRow
        Dim ofrm As New frmMSPLAusentismo
        Dim ds As New Data.DataSet
        If fg.Row <> -1 Then
            Try
                ds.Clear()
                ds = oPlan.ConsultarPLAusentismo("b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.*", "a.Correlativo = " & Trim(fg.Item(fg.Row, "Correlativo")) & "", "a.Correlativo", True, sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.pCorrelativo = Trim(fg.Item(fg.Row, "Correlativo"))
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.btnGuardar1.Enabled = False
                ofrm.txtCodEmpleado.Text = IIf(IsDBNull(dr("CodEmpleado")), "", dr("CodEmpleado"))
                ofrm.txtCodEmpleado.ReadOnly = True
                ofrm.txtCodMotivoAusentismo.Text = IIf(IsDBNull(dr("CodAusentismo")), "", dr("CodAusentismo"))
                ofrm.txtCodMotivoAusentismo.ReadOnly = True
                ofrm.txtCantidadHoras.Text = dr("TotalHoras")
                If Not IsDBNull(dr("FechaInicio")) Then ofrm.dtpFechaInicio.Value = dr("FechaInicio")
                If Not IsDBNull(dr("FechaFin")) Then ofrm.dtpFechaFin.Value = dr("FechaFin")
                ofrm.dtpHoraInicio.Text = dr("HoraInicio")
                ofrm.dtpHoraFin.Text = dr("HoraFin")
                If Not IsDBNull(dr("Tipo")) Then
                    If dr("Tipo") = "G" Then
                        ofrm.chkTotal.Checked = True
                    Else
                        ofrm.chkTotal.Checked = False
                    End If
                Else
                    ofrm.chkTotal.Checked = False
                End If
                ofrm.txtObservaciones.Text = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                ofrm.dtpPI.Value = IIf(IsDBNull(dr("PeriodoInicio")), Now, dr("PeriodoInicio"))
                ofrm.dtpPF.Value = IIf(IsDBNull(dr("PeriodoFin")), Now, dr("PeriodoFin"))
                ofrm.StartPosition = FormStartPosition.CenterParent
                ofrm.ShowDialog()
                ActualizarGrid()
            Catch ex As Exception
                MsgBox(mensajeError, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub txtCodEmp_TextChanged(sender As Object, e As EventArgs) Handles txtCodEmp.TextChanged

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim Filtro As String
        Dim ds As New Data.DataSet
        Dim Bandera As Boolean
        Bandera = False
        Filtro = ""
        Try
            If Me.chkCodEmpleado.Checked = True Then
                If Bandera = True Then
                    Filtro += " AND "
                End If
                Filtro += " a.CodEmpleado = '" & Trim(Me.txtCodEmp.Text) & "'"
                Bandera = True
            End If
            If Me.chkFechas.Checked = True Then
                If Bandera = True Then
                    Filtro += " AND "
                End If
                Filtro += " a.PeriodoInicio>= '" & Format(Me.dtpF1.Value, "Short Date") & "' and a.PeriodoFin<='" & Format(Me.dtpF2.Value, "Short Date") & "'"
                Bandera = True
            End If
            If Me.chkNombres.Checked = True Then
                If Bandera = True Then
                    Filtro += " AND "
                End If
                If cbNombres.SelectedIndex = 0 Then
                    Filtro += " b.Apellido1 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    Filtro += " b.Apellido2 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    Filtro += " b.Nombres like '" & Trim(txtNombres.Text) & "%'"
                End If
                Bandera = True
            End If
            If Me.chkTipoAusentismo.Checked = True Then
                If Bandera = True Then
                    Filtro += " AND "
                End If
                Filtro += "a.CodAusentismo ='" & Me.cbTipoAusentismo.SelectedValue & "'"
                Bandera = True
            End If
            ds = oPlan.ConsultarPLAusentismo("b.Nombres + ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.*", Filtro, "a.CodAusentismo", True, sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class