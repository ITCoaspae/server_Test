Public Class frmMPLDepartamentos
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
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
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents rbtDesc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCodDepartamento As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtCodDepartamento = New System.Windows.Forms.TextBox()
        Me.rbtDesc = New System.Windows.Forms.RadioButton()
        Me.rbtCodDepartamento = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.txtDesc)
        Me.GroupBox2.Controls.Add(Me.txtCodDepartamento)
        Me.GroupBox2.Controls.Add(Me.rbtDesc)
        Me.GroupBox2.Controls.Add(Me.rbtCodDepartamento)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 101)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Departamentos:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(376, 58)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 77
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(129, 64)
        Me.txtDesc.MaxLength = 25
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(241, 22)
        Me.txtDesc.TabIndex = 13
        '
        'txtCodDepartamento
        '
        Me.txtCodDepartamento.Location = New System.Drawing.Point(129, 31)
        Me.txtCodDepartamento.MaxLength = 10
        Me.txtCodDepartamento.Name = "txtCodDepartamento"
        Me.txtCodDepartamento.Size = New System.Drawing.Size(152, 22)
        Me.txtCodDepartamento.TabIndex = 12
        '
        'rbtDesc
        '
        Me.rbtDesc.BackColor = System.Drawing.Color.White
        Me.rbtDesc.ForeColor = System.Drawing.Color.Black
        Me.rbtDesc.Location = New System.Drawing.Point(16, 64)
        Me.rbtDesc.Name = "rbtDesc"
        Me.rbtDesc.Size = New System.Drawing.Size(107, 26)
        Me.rbtDesc.TabIndex = 11
        Me.rbtDesc.Text = "Descripción:"
        Me.rbtDesc.UseVisualStyleBackColor = False
        '
        'rbtCodDepartamento
        '
        Me.rbtCodDepartamento.BackColor = System.Drawing.Color.White
        Me.rbtCodDepartamento.ForeColor = System.Drawing.Color.Black
        Me.rbtCodDepartamento.Location = New System.Drawing.Point(16, 24)
        Me.rbtCodDepartamento.Name = "rbtCodDepartamento"
        Me.rbtCodDepartamento.Size = New System.Drawing.Size(107, 34)
        Me.rbtCodDepartamento.TabIndex = 10
        Me.rbtCodDepartamento.Text = "Código de Departamento:"
        Me.rbtCodDepartamento.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(556, 143)
        Me.DataGridView1.TabIndex = 35
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 170)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 83
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 170)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 82
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 170)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 81
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 170)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 80
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLDepartamentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(602, 402)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMPLDepartamentos"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Departamentos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Nuevas Funciones" ' Javier Martinez 
    Private Sub FormatoDg()
        Me.DataGridView1.Columns("CODAREA").HeaderText = "CodArea"
        Me.DataGridView1.Columns("CODDEPARTAMENTO").HeaderText = "Código de Departamento"
        Me.DataGridView1.Columns("DESCRIPCION").HeaderText = "Departamento"
        Me.DataGridView1.Columns("IDCUENTA").HeaderText = "No. Cuenta"
        Me.DataGridView1.Columns("CODAREA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("CODDEPARTAMENTO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("DESCRIPCION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("IDCUENTA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

    End Sub
    Private Sub LlenarDg(ByVal Opcion As Integer, ByVal CodArea As String, ByVal CodDepartamento As String, ByVal Departameto As String)
        Dim Dts As New DataSet
        Dts = oPlan.CONSULTAR_PLDEPARTAMENTOS(sUsuario, sPassword, sSucursal, Opcion, CodArea, CodDepartamento, Departameto)
        Me.DataGridView1.DataSource = Dts.Tables(0)
        FormatoDg()
    End Sub
#End Region

    Private Sub frmMPLDepartamentos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarDg(1, "", "", "")
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.rbtCodDepartamento.Checked = True Then
                LlenarDg(4, "", Me.txtCodDepartamento.Text.Trim, "")
            ElseIf Me.rbtDesc.Checked = True Then
                LlenarDg(3, "", "", Me.txtDesc.Text.Trim)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim frm As New frmMSPLDepartamentos
            frm.vAccion = "Guardar"
            frm.llenar_cbareas()
            frm.ShowDialog()
            LlenarDg(1, "", "", "")
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            If Me.DataGridView1.CurrentRow.Index > -1 Then
                Dim frm As New frmMSPLDepartamentos
                frm.vAccion = "Modificar"
                frm.llenar_cbareas()
                frm.cbArea.SelectedValue = Me.DataGridView1.Item("CODAREA", Me.DataGridView1.CurrentRow.Index).Value
                frm.txtCodDepartamento.Text = Me.DataGridView1.Item("CODDEPARTAMENTO", Me.DataGridView1.CurrentRow.Index).Value.ToString.Trim
                frm.txtDesc.Text = Me.DataGridView1.Item("DESCRIPCION", Me.DataGridView1.CurrentRow.Index).Value.ToString.Trim
                frm.ShowDialog()
                LlenarDg(1, "", "", "")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If Me.DataGridView1.CurrentRow.Index > -1 Then
            Try
                If MsgBox("¿Está seguro de eliminar el registro?", MsgBoxStyle.YesNo, "Módulo - Planillas") = 6 Then
                    Dim Resultado As Integer
                    Resultado = oPlan.Eliminar_PlDepartamentos(sUsuario, sPassword, sSucursal,
                                                                Me.DataGridView1.Item("CODAREA", Me.DataGridView1.CurrentRow.Index).Value,
                                                                Me.DataGridView1.Item("CODDEPARTAMENTO", Me.DataGridView1.CurrentRow.Index).Value)
                    If Resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                        LlenarDg(1, "", "", "")
                    Else
                        MsgBox("No se pudo eliminar el registro, Por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Planillas")
                    End If
                End If
            Catch ex As Exception
                MsgBox(mensajeError, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            If Me.DataGridView1.CurrentRow.Index > -1 Then
                Dim frm As New frmMSPLDepartamentos
                frm.vAccion = "CONSULTAR"
                frm.llenar_cbareas()
                frm.cbArea.SelectedValue = Me.DataGridView1.Item("CODAREA", Me.DataGridView1.CurrentRow.Index).Value
                frm.txtCodDepartamento.Text = Me.DataGridView1.Item("CODDEPARTAMENTO", Me.DataGridView1.CurrentRow.Index).Value.ToString.Trim
                frm.txtDesc.Text = Me.DataGridView1.Item("DESCRIPCION", Me.DataGridView1.CurrentRow.Index).Value.ToString.Trim
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class