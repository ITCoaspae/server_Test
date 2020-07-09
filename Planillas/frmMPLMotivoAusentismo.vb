Public Class frmMPLMotivoAusentismo
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents rbtDesc As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodigoAus As System.Windows.Forms.TextBox
    Friend WithEvents rbtCodAus As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPLMotivoAusentismo))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtCodigoAus = New System.Windows.Forms.TextBox()
        Me.rbtDesc = New System.Windows.Forms.RadioButton()
        Me.rbtCodAus = New System.Windows.Forms.RadioButton()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
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
        Me.fg.Location = New System.Drawing.Point(23, 214)
        Me.fg.Name = "fg"
        Me.fg.Size = New System.Drawing.Size(546, 151)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 44
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtDesc)
        Me.GroupBox2.Controls.Add(Me.txtCodigoAus)
        Me.GroupBox2.Controls.Add(Me.rbtDesc)
        Me.GroupBox2.Controls.Add(Me.rbtCodAus)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 111)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar datos por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(325, 76)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 109
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(154, 50)
        Me.txtDesc.MaxLength = 25
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(246, 20)
        Me.txtDesc.TabIndex = 13
        '
        'txtCodigoAus
        '
        Me.txtCodigoAus.Location = New System.Drawing.Point(154, 24)
        Me.txtCodigoAus.MaxLength = 10
        Me.txtCodigoAus.Name = "txtCodigoAus"
        Me.txtCodigoAus.Size = New System.Drawing.Size(152, 20)
        Me.txtCodigoAus.TabIndex = 12
        '
        'rbtDesc
        '
        Me.rbtDesc.BackColor = System.Drawing.Color.White
        Me.rbtDesc.ForeColor = System.Drawing.Color.Black
        Me.rbtDesc.Location = New System.Drawing.Point(16, 50)
        Me.rbtDesc.Name = "rbtDesc"
        Me.rbtDesc.Size = New System.Drawing.Size(132, 24)
        Me.rbtDesc.TabIndex = 11
        Me.rbtDesc.Text = "Descripción:"
        Me.rbtDesc.UseVisualStyleBackColor = False
        '
        'rbtCodAus
        '
        Me.rbtCodAus.BackColor = System.Drawing.Color.White
        Me.rbtCodAus.ForeColor = System.Drawing.Color.Black
        Me.rbtCodAus.Location = New System.Drawing.Point(16, 24)
        Me.rbtCodAus.Name = "rbtCodAus"
        Me.rbtCodAus.Size = New System.Drawing.Size(132, 24)
        Me.rbtCodAus.TabIndex = 10
        Me.rbtCodAus.Text = "Código de Ausentismo"
        Me.rbtCodAus.UseVisualStyleBackColor = False
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 180)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 119
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 180)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 118
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 180)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 117
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 180)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 116
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLMotivoAusentismo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(592, 414)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMPLMotivoAusentismo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Motivo Ausentismo"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub Encabezado()
        fg.Cols.Item(1).Caption = "Cód. de Ausentismo"
        fg.Cols.Item(2).Caption = "Motivo de Ausentismo"

        fg.Cols.Item(0).Width = 20
        fg.Cols.Item(1).Width = 120
        fg.Cols.Item(2).Width = 400
    End Sub

    Private Sub RefrescarGrid()
        Dim ds As New Data.DataSet
        Try
            ds = oPlan.ConsultarPLMotivoAusentismo("*", "", "CodAusentismo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmMPLMotivoAusentismo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefrescarGrid()
    End Sub




    Private Sub rbtCodAus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCodAus.CheckedChanged
        Me.txtCodigoAus.Focus()
    End Sub

    Private Sub rbtDesc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtDesc.CheckedChanged
        Me.txtDesc.Focus()
    End Sub

    Private Sub txtCodigoAus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoAus.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim Filtro As String
        Dim ds As New Data.DataSet
        Try
            If Me.rbtCodAus.Checked = True Then
                Filtro = "CodAusentismo LIKE '" & Trim(Me.txtCodigoAus.Text) & "%'"
            ElseIf Me.rbtDesc.Checked = True Then
                Filtro = "Descripcion LIKE '" & Trim(Me.txtDesc.Text) & "%'"
            End If
            ds = oPlan.ConsultarPLMotivoAusentismo("*", Filtro, "", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMSPLMotivoAusentismo
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            RefrescarGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim ds As New Data.DataSet
        If fg.Row <> -1 Then
            Try
                Dim dr As DataRow
                Dim ofrm As New frmMSPLMotivoAusentismo
                ds = oPlan.ConsultarPLMotivoAusentismo("*", "CodAusentismo = '" & Trim(fg.Item(fg.Row, "CodAusentismo")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.txtCodMotivoAusentismo.Text = IIf(IsDBNull(dr("CodAusentismo")), "", dr("CodAusentismo"))
                ofrm.txtCodMotivoAusentismo.ReadOnly = True
                ofrm.txtDescripcion.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                ofrm.chkGoceSueldo.Checked = IIf(IIf(IsDBNull(dr("GoceSueldo")), "N", dr("GoceSueldo")) = "N", False, True)
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                RefrescarGrid()
            Catch ex As Exception
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim ds As New Data.DataSet
        If fg.Row <> -1 Then
            Try
                Dim var As Integer = oPlan.VerificarEliminarPLMotivoAusentismo("'" & Trim(fg.Item(fg.Row, "CodAusentismo")) & "'", sUsuario, sPassword, sSucursal)
                If var = 0 Then
                    MsgBox("No puede eliminar el registro porque existen registros coincidentes en otras tablas", MsgBoxStyle.Information, "Módulo - Planilla")
                ElseIf var = 1 Then
                    If MsgBox("¿Está seguro de eliminar el registro?", MsgBoxStyle.YesNo, "Módulo - Planilla") = MsgBoxResult.Yes Then
                        If oPlan.EliminarPLMotivoAusentismo("'" & Trim(fg.Item(fg.Row, "CodAusentismo")) & "'", sUsuario, sPassword, sSucursal) = True Then
                            MsgBox("Registro eliminado", MsgBoxStyle.Information, "Módulo - Planilla")
                            RefrescarGrid()
                        Else
                            MsgBox("Registro NO eliminado", MsgBoxStyle.Information, "Módulo - Planilla")
                        End If
                    Else
                        Exit Sub
                    End If
                ElseIf var = 2 Then
                    MsgBox("Error en la Base de Datos", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            Catch ex As Exception
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        If fg.Row <> -1 Then
            Dim ds As New Data.DataSet
            Try
                Dim dr As DataRow
                Dim ofrm As New frmMSPLMotivoAusentismo
                ds = oPlan.ConsultarPLMotivoAusentismo("*", "CodAusentismo = '" & Trim(fg.Item(fg.Row, "CodAusentismo")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.btnGuardar1.Enabled = False
                ofrm.txtCodMotivoAusentismo.Text = IIf(IsDBNull(dr("CodAusentismo")), "", dr("CodAusentismo"))
                ofrm.txtCodMotivoAusentismo.ReadOnly = True
                ofrm.txtDescripcion.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                ofrm.chkGoceSueldo.Checked = IIf(IIf(IsDBNull(dr("GoceSueldo")), "N", dr("GoceSueldo")) = "N", False, True)
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
            Catch ex As Exception
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class