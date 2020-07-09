Public Class frmMPLVacaciones
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents chkNombres As System.Windows.Forms.CheckBox
    Friend WithEvents chkPeriodo As System.Windows.Forms.CheckBox
    Friend WithEvents DgVacaciones As System.Windows.Forms.DataGridView
    Private oPlan As New wrPlanilla.wsLibPlanilla
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Dim Planilla As New wrPlanilla.wsLibPlanilla

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFI As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.chkNombres = New System.Windows.Forms.CheckBox()
        Me.chkPeriodo = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFF = New System.Windows.Forms.DateTimePicker()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.dtpFI = New System.Windows.Forms.DateTimePicker()
        Me.DgVacaciones = New System.Windows.Forms.DataGridView()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.chkNombres)
        Me.GroupBox2.Controls.Add(Me.chkPeriodo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpFF)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.dtpFI)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 155)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar datos por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(281, 117)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 118
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'chkNombres
        '
        Me.chkNombres.AutoSize = True
        Me.chkNombres.ForeColor = System.Drawing.Color.Black
        Me.chkNombres.Location = New System.Drawing.Point(19, 68)
        Me.chkNombres.Name = "chkNombres"
        Me.chkNombres.Size = New System.Drawing.Size(68, 17)
        Me.chkNombres.TabIndex = 14
        Me.chkNombres.Text = "Nombres"
        Me.chkNombres.UseVisualStyleBackColor = True
        '
        'chkPeriodo
        '
        Me.chkPeriodo.AutoSize = True
        Me.chkPeriodo.ForeColor = System.Drawing.Color.Black
        Me.chkPeriodo.Location = New System.Drawing.Point(16, 19)
        Me.chkPeriodo.Name = "chkPeriodo"
        Me.chkPeriodo.Size = New System.Drawing.Size(64, 17)
        Me.chkPeriodo.TabIndex = 13
        Me.chkPeriodo.Text = "Período"
        Me.chkPeriodo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(140, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "al:"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Del:"
        '
        'dtpFF
        '
        Me.dtpFF.CustomFormat = "yyyy/mm/dd"
        Me.dtpFF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFF.Location = New System.Drawing.Point(170, 39)
        Me.dtpFF.Name = "dtpFF"
        Me.dtpFF.Size = New System.Drawing.Size(88, 20)
        Me.dtpFF.TabIndex = 2
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(174, 91)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(182, 20)
        Me.txtNombres.TabIndex = 7
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(16, 91)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(152, 21)
        Me.cbNombres.TabIndex = 6
        '
        'dtpFI
        '
        Me.dtpFI.CustomFormat = "yyyy/mm/dd"
        Me.dtpFI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFI.Location = New System.Drawing.Point(46, 42)
        Me.dtpFI.Name = "dtpFI"
        Me.dtpFI.Size = New System.Drawing.Size(88, 20)
        Me.dtpFI.TabIndex = 1
        '
        'DgVacaciones
        '
        Me.DgVacaciones.AllowUserToAddRows = False
        Me.DgVacaciones.AllowUserToDeleteRows = False
        Me.DgVacaciones.AllowUserToOrderColumns = True
        Me.DgVacaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgVacaciones.Location = New System.Drawing.Point(23, 258)
        Me.DgVacaciones.Name = "DgVacaciones"
        Me.DgVacaciones.ReadOnly = True
        Me.DgVacaciones.Size = New System.Drawing.Size(485, 186)
        Me.DgVacaciones.TabIndex = 49
        '
        'btnImp
        '
        Me.btnImp.ForeColor = System.Drawing.Color.Teal
        Me.btnImp.Location = New System.Drawing.Point(266, 224)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 155
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.ForeColor = System.Drawing.Color.Teal
        Me.btnDel.Location = New System.Drawing.Point(185, 224)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 154
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.ForeColor = System.Drawing.Color.Teal
        Me.btnMod.Location = New System.Drawing.Point(104, 224)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 153
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.ForeColor = System.Drawing.Color.Teal
        Me.btnAdd.Location = New System.Drawing.Point(23, 224)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 152
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLVacaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(531, 493)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DgVacaciones)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximumSize = New System.Drawing.Size(1141, 599)
        Me.Name = "frmMPLVacaciones"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Vacaciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub LlenarDg(ByVal Opcion As Integer, ByVal CodEmpleado As String, ByVal FechaInicio_Vac As DateTime, ByVal FechaFin_Vac As DateTime)
        Dim Dts As New DataSet
        Dts = Planilla.Consultar_PlVacaciones(Opcion, CodEmpleado, FechaInicio_Vac, FechaFin_Vac)
        Me.DgVacaciones.DataSource = Dts.Tables(0)
        EncabezadoDG()
    End Sub
    Private Sub EncabezadoDG()
        Me.DgVacaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DgVacaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DgVacaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.DgVacaciones.Columns("Correlativo").Visible = False
        Me.DgVacaciones.Columns("CodTipoPlanilla").Visible = False
        Me.DgVacaciones.Columns("CodEmpleado").Visible = False
        Me.DgVacaciones.Columns("FECHAACTU").Visible = False
        Me.DgVacaciones.Columns("USUARIO").Visible = False
        Me.DgVacaciones.Columns("FECHAINICIO_VAC").HeaderText = "Inicio Vacación"
        Me.DgVacaciones.Columns("FECHAFIN_VAC").HeaderText = "Fin Vacación"
        Me.DgVacaciones.Columns("DESCRIPCION").HeaderText = "Tipo de Planilla"
        Me.DgVacaciones.Columns("PeriodoInicio").HeaderText = "Inicio Periodo Laboral"
        Me.DgVacaciones.Columns("PeriodoFin").HeaderText = "Fin Periodo Laboral"
        Me.DgVacaciones.Columns("Empleado").HeaderText = "Empleado"
        Me.DgVacaciones.Columns("FECHAINIPAGO").HeaderText = "Fecha Inicio Pago en Planilla"
        Me.DgVacaciones.Columns("FECHAFINPAGO").HeaderText = "Fecha Fin Pago en Planilla"
        Me.DgVacaciones.Columns("PRIMAVACACION").HeaderText = "Prima Vacación"
        Me.DgVacaciones.Columns("DIASVACACION").HeaderText = "Días Vacación"
        Me.DgVacaciones.Columns("TOTALVACACION").HeaderText = "Total Vacación"

    End Sub


    Private Sub frmMPLVacaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarDg(1, "", dtpFI.Value, dtpFF.Value)

    End Sub

    Private Sub rbtFechaInicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.dtpFI.Focus()
    End Sub

    Private Sub txtCodEmp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub dtpFF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFF.KeyDown
        If e.KeyData = Keys.Return Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim Filtro As String
        Dim ds As New Data.DataSet
        Try
            If Me.chkNombres.Checked = True And Me.chkPeriodo.Checked = False Then
                LlenarDg(3, Me.txtNombres.Text.Trim, dtpFI.Value, dtpFF.Value)
            ElseIf Me.chkNombres.Checked = False And Me.chkPeriodo.Checked = True Then
                LlenarDg(2, Me.txtNombres.Text.Trim, Format(dtpFI.Value, "Short date"), Format(dtpFF.Value, "Short Date"))
            Else
                LlenarDg(4, Me.txtNombres.Text.Trim, Format(dtpFI.Value, "Short date"), Format(dtpFF.Value, "Short Date"))
            End If

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMSPLVacaciones
            ofrm.btnGuardar1.Text = "&Guardar"

            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            LlenarDg(1, "", dtpFI.Value.ToShortDateString, dtpFF.Value.ToShortDateString)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            If Me.DgVacaciones.CurrentRow.Index > -1 Then
                Dim Frm As New frmMSPLVacaciones
                Frm.Correlativo = DgVacaciones.Item("Correlativo", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtCodEmpleado.Text = DgVacaciones.Item("CodEmpleado", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtNombreEmp.Text = DgVacaciones.Item("Empleado", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.dtpFechaIni_PL.Value = DgVacaciones.Item("PeriodoInicio", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.dtpFechaFin_PL.Value = DgVacaciones.Item("PeriodoFin", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.dtpFechaIni_Vac.Value = DgVacaciones.Item("FECHAINICIO_VAC", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.dtpFechaFin_Vac.Value = DgVacaciones.Item("FECHAFIN_VAC", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtPrimaVacacion.Text = DgVacaciones.Item("PRIMAVACACION", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtDiasVacacion.Text = DgVacaciones.Item("DIASVACACION", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtTotalVacacion.Text = DgVacaciones.Item("TOTALVACACION", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.DtpFechaIniPago.Value = DgVacaciones.Item("FECHAINIPAGO", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.DtpFechaFinPago.Value = DgVacaciones.Item("FECHAFINPAGO", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtCodTipoPlanilla.Text = DgVacaciones.Item("CodTipoPlanilla", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtDescripcion.Text = DgVacaciones.Item("DESCRIPCION", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.btnGuardar1.Text = "&Modificar"
                StartPosition = FormStartPosition.CenterScreen
                Frm.ShowDialog()
                LlenarDg(1, "", dtpFI.Value, dtpFF.Value)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Me.DgVacaciones.CurrentRow.Index > -1 Then
            Try
                If MsgBox("Desea eliminar este registro", MsgBoxStyle.YesNo, "Módulo - Planillas") = MsgBoxResult.Yes Then
                    Dim Resultado As Integer
                    Resultado = Planilla.Eliminar_PlVacaciones(Me.DgVacaciones.Item("Correlativo", Me.DgVacaciones.CurrentRow.Index).Value)
                    If Resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Planillas")
                        LlenarDg(1, "", dtpFI.Value, dtpFF.Value)
                    End If
                End If
            Catch ex As Exception
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            If Me.DgVacaciones.CurrentRow.Index > -1 Then
                Dim Frm As New frmMSPLVacaciones
                Frm.Correlativo = DgVacaciones.Item("Correlativo", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtCodEmpleado.Text = DgVacaciones.Item("CodEmpleado", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtNombreEmp.Text = DgVacaciones.Item("Empleado", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.dtpFechaIni_PL.Value = DgVacaciones.Item("PeriodoInicio", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.dtpFechaFin_PL.Value = DgVacaciones.Item("PeriodoFin", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.dtpFechaIni_Vac.Value = DgVacaciones.Item("FECHAINICIO_VAC", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.dtpFechaFin_Vac.Value = DgVacaciones.Item("FECHAFIN_VAC", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtPrimaVacacion.Text = DgVacaciones.Item("PRIMAVACACION", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtDiasVacacion.Text = DgVacaciones.Item("DIASVACACION", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtTotalVacacion.Text = DgVacaciones.Item("TOTALVACACION", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.DtpFechaIniPago.Value = DgVacaciones.Item("FECHAINIPAGO", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.DtpFechaFinPago.Value = DgVacaciones.Item("FECHAFINPAGO", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtCodTipoPlanilla.Text = DgVacaciones.Item("CodTipoPlanilla", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.txtDescripcion.Text = DgVacaciones.Item("DESCRIPCION", Me.DgVacaciones.CurrentRow.Index).Value
                Frm.btnGuardar1.Text = "&Guardar"
                Frm.btnGuardar1.Enabled = False
                StartPosition = FormStartPosition.CenterScreen
                Frm.ShowDialog()
                LlenarDg(1, "", dtpFI.Value, dtpFF.Value)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class