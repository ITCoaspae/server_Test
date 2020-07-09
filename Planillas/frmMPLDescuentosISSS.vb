Public Class frmMPLDescuentosISSS
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents dgISSS As System.Windows.Forms.DataGridView
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Private Planilla As New wrPlanilla.wsLibPlanilla

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgISSS = New System.Windows.Forms.DataGridView()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        CType(Me.dgISSS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgISSS
        '
        Me.dgISSS.AllowUserToAddRows = False
        Me.dgISSS.AllowUserToDeleteRows = False
        Me.dgISSS.AllowUserToOrderColumns = True
        Me.dgISSS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgISSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgISSS.Location = New System.Drawing.Point(23, 97)
        Me.dgISSS.Name = "dgISSS"
        Me.dgISSS.ReadOnly = True
        Me.dgISSS.Size = New System.Drawing.Size(477, 168)
        Me.dgISSS.TabIndex = 35
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 63)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 91
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 63)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 90
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 63)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 89
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 63)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 88
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLDescuentosISSS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(523, 307)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgISSS)
        Me.Name = "frmMPLDescuentosISSS"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Descuentos ISSS"
        CType(Me.dgISSS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub HeaderDg()
        Me.dgISSS.Columns("id_Isss").Visible = False
        Me.dgISSS.Columns("PorcentajeTrabajador").HeaderText = "Porcentaje Trabajador"
        Me.dgISSS.Columns("PorcentajePatrono").HeaderText = "Porcentaje Patrono"
        Me.dgISSS.Columns("IVMTrabajador").HeaderText = "IVM Trabajador"
        Me.dgISSS.Columns("IVMPatrono").HeaderText = "IVM Patrono"
        Me.dgISSS.Columns("MaximoSalario").HeaderText = "Maximo Salario"
        Me.dgISSS.Columns("MaximoDescuento").HeaderText = "Maximo Descuento"
        Me.dgISSS.Columns("PorcentajeTrabajador").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgISSS.Columns("PorcentajePatrono").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgISSS.Columns("IVMTrabajador").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgISSS.Columns("IVMPatrono").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgISSS.Columns("MaximoSalario").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgISSS.Columns("MaximoDescuento").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgISSS.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgISSS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgISSS.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub LlenarDg(ByVal Opcion As Integer, ByVal Id_ISSS As Integer)
        Dim Dts As New DataSet
        Dts = Planilla.Consultar_PlDescuentosISSS(Opcion, Id_ISSS)
        Me.dgISSS.DataSource = Dts.Tables(0)
        HeaderDg()
    End Sub

    Private Sub frmMPLDescuentosISSS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarDg(1, 0)
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim Form As New frmMSPLDescuentosISSS
            Dim Id_ISSS As Integer
            Form.btnGuardar1.Text = "Guardar"
            Form.ShowDialog()
            LlenarDg(1, 0)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim Form As New frmMSPLDescuentosISSS
            Dim Id_ISSS As Integer
            If Me.dgISSS.CurrentRow.Index <> -1 Then
                Id_ISSS = Me.dgISSS.Item("id_Isss", Me.dgISSS.CurrentRow.Index).Value
                Form.txtPorcentajeTrabajador.Text = Me.dgISSS.Item("PorcentajeTrabajador", Me.dgISSS.CurrentRow.Index).Value
                Form.txtPorcentajePatrono.Text = Me.dgISSS.Item("PorcentajePatrono", Me.dgISSS.CurrentRow.Index).Value
                Form.txtIVMTrabajador.Text = Me.dgISSS.Item("IVMTrabajador", Me.dgISSS.CurrentRow.Index).Value
                Form.txtIVMPatrono.Text = Me.dgISSS.Item("IVMPatrono", Me.dgISSS.CurrentRow.Index).Value
                Form.txtMaxSalario.Text = Me.dgISSS.Item("MaximoSalario", Me.dgISSS.CurrentRow.Index).Value
                Form.txtMaxDesc.Text = Me.dgISSS.Item("MaximoDescuento", Me.dgISSS.CurrentRow.Index).Value
                Form.lblId_ISSS.Text = Id_ISSS
                Form.btnGuardar1.Text = "Modificar"
                Form.ShowDialog()
                LlenarDg(1, 0)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim Resultado As Integer
        Dim Id_ISSS As Integer
        Try
            If Me.dgISSS.CurrentRow.Index <> -1 Then
                Id_ISSS = Me.dgISSS.Item("id_Isss", Me.dgISSS.CurrentRow.Index).Value
                If MsgBox("Desea eliminar este registro", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo - Planillas") = 6 Then
                    Resultado = Planilla.Eliminar_PlDescuentosISSS(Id_ISSS)
                    If Resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                        LlenarDg(1, 0)
                    Else
                        MsgBox("El registro no pudo ser eliminado, Por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Planillas")
                    End If
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim Form As New frmMSPLDescuentosISSS
            Dim Id_ISSS As Integer
            If Me.dgISSS.CurrentRow.Index <> -1 Then
                Id_ISSS = Me.dgISSS.Item("id_Isss", Me.dgISSS.CurrentRow.Index).Value
                Form.txtPorcentajeTrabajador.Text = Me.dgISSS.Item("PorcentajeTrabajador", Me.dgISSS.CurrentRow.Index).Value
                Form.txtPorcentajePatrono.Text = Me.dgISSS.Item("PorcentajePatrono", Me.dgISSS.CurrentRow.Index).Value
                Form.txtIVMTrabajador.Text = Me.dgISSS.Item("IVMTrabajador", Me.dgISSS.CurrentRow.Index).Value
                Form.txtIVMPatrono.Text = Me.dgISSS.Item("IVMPatrono", Me.dgISSS.CurrentRow.Index).Value
                Form.txtMaxSalario.Text = Me.dgISSS.Item("MaximoSalario", Me.dgISSS.CurrentRow.Index).Value
                Form.txtMaxDesc.Text = Me.dgISSS.Item("MaximoDescuento", Me.dgISSS.CurrentRow.Index).Value
                Form.lblId_ISSS.Text = Id_ISSS
                Form.btnGuardar1.Enabled = False
                Form.txtIVMPatrono.ReadOnly = True
                Form.txtIVMTrabajador.ReadOnly = True
                Form.txtMaxDesc.ReadOnly = True
                Form.txtMaxSalario.ReadOnly = True
                Form.txtPorcentajePatrono.ReadOnly = True
                Form.txtPorcentajeTrabajador.ReadOnly = True
                Form.ShowDialog()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
