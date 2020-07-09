Public Class frmMPLInstituciones
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodInstitucion As System.Windows.Forms.TextBox
    Friend WithEvents rbtNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCodInstitucion As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPLInstituciones))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodInstitucion = New System.Windows.Forms.TextBox()
        Me.rbtNombre = New System.Windows.Forms.RadioButton()
        Me.rbtCodInstitucion = New System.Windows.Forms.RadioButton()
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
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtCodInstitucion)
        Me.GroupBox2.Controls.Add(Me.rbtNombre)
        Me.GroupBox2.Controls.Add(Me.rbtCodInstitucion)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 114)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Instituciones:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(320, 80)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 107
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(152, 54)
        Me.txtNombre.MaxLength = 25
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(243, 20)
        Me.txtNombre.TabIndex = 13
        '
        'txtCodInstitucion
        '
        Me.txtCodInstitucion.Location = New System.Drawing.Point(152, 28)
        Me.txtCodInstitucion.MaxLength = 10
        Me.txtCodInstitucion.Name = "txtCodInstitucion"
        Me.txtCodInstitucion.Size = New System.Drawing.Size(152, 20)
        Me.txtCodInstitucion.TabIndex = 12
        '
        'rbtNombre
        '
        Me.rbtNombre.BackColor = System.Drawing.Color.White
        Me.rbtNombre.ForeColor = System.Drawing.Color.Black
        Me.rbtNombre.Location = New System.Drawing.Point(16, 54)
        Me.rbtNombre.Name = "rbtNombre"
        Me.rbtNombre.Size = New System.Drawing.Size(130, 24)
        Me.rbtNombre.TabIndex = 11
        Me.rbtNombre.Text = "Nombre:"
        Me.rbtNombre.UseVisualStyleBackColor = False
        '
        'rbtCodInstitucion
        '
        Me.rbtCodInstitucion.BackColor = System.Drawing.Color.White
        Me.rbtCodInstitucion.ForeColor = System.Drawing.Color.Black
        Me.rbtCodInstitucion.Location = New System.Drawing.Point(16, 24)
        Me.rbtCodInstitucion.Name = "rbtCodInstitucion"
        Me.rbtCodInstitucion.Size = New System.Drawing.Size(130, 24)
        Me.rbtCodInstitucion.TabIndex = 10
        Me.rbtCodInstitucion.Text = "Código de Institución:"
        Me.rbtCodInstitucion.UseVisualStyleBackColor = False
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
        Me.fg.Size = New System.Drawing.Size(414, 167)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 37
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 183)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 115
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
        Me.btnDel.TabIndex = 114
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
        Me.btnMod.TabIndex = 113
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
        Me.btnAdd.TabIndex = 112
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLInstituciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(460, 437)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMPLInstituciones"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Instituciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub Encabezado()

        fg.Cols.Item(1).Caption = "Código Institución"
        fg.Cols.Item(2).Caption = "Nombre"
        fg.Cols.Item(3).Caption = "Inst. Bancaria"

        fg.Cols.Item(0).Width = 20
        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 300
        fg.Cols.Item(3).Width = 100

    End Sub

    Public Sub ActualizaGrid()

        Dim ds As New Data.DataSet
        Try
            ds = oPlan.ConsultarPLInstituciones("*", "", "CodInstitucion", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub frmMPLInstituciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ActualizaGrid()
        Encabezado()

    End Sub



    Private Sub rbtCodInstitucion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCodInstitucion.CheckedChanged
        Me.txtCodInstitucion.Focus()
    End Sub

    Private Sub rbtNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNombre.CheckedChanged
        Me.txtNombre.Focus()
    End Sub

    Private Sub txtCodInstitucion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodInstitucion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMSPLInstituciones
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            ActualizaGrid()
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim ofrm As New frmMSPLInstituciones
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            If fg.Row <> -1 Then
                ofrm.btnGuardar1.Text = "&Modificar"
                ds = oPlan.ConsultarPLInstituciones("*", "CodInstitucion='" & Trim(fg.Item(fg.Row, "CodInstitucion")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.txtCodInstitucion.Text = dr("CodInstitucion")
                ofrm.txtCodInstitucion.ReadOnly = True
                ofrm.txtNombreInstitucion.Text = dr("Nombre")
                If dr("Tipo") = "1" Then
                    ofrm.chkInstBanc.Checked = True
                Else
                    ofrm.chkInstBanc.Checked = False
                End If
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizaGrid()
                Encabezado()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Dim Var As Integer
            If fg.Row <> -1 Then
                Var = oPlan.EliminarPLInstitucionesVerificacion("'" & Trim(fg.Item(fg.Row, "CodInstitucion")) & "'", sUsuario, sPassword, sSucursal)
                If Var = 0 Then
                    MsgBox("EL usuario no tiene derechos para realizar esta Operación", MsgBoxStyle.Information, "Módulo - Planilla")
                ElseIf Var = 1 Then
                    MsgBox("No puede eliminar el registro porque se encuentra relacionado con otras tablas", MsgBoxStyle.Information, "Módulo - Planilla")
                ElseIf Var = 2 Then
                    If Val(MsgBox("¿Está seguro de eliminar el registro?", MsgBoxStyle.YesNo, "Módulo - Planilla") = MsgBoxResult.Yes) Then
                        oPlan.EliminarPLInstituciones("'" & Trim(fg.Item(fg.Row, "CodInstitucion")) & "'", sUsuario, sPassword, sSucursal)
                    Else
                        Exit Sub
                    End If
                ElseIf Var = 3 Then
                    MsgBox("Error en la base de datos", MsgBoxStyle.Critical, "Módulo - Planilla")
                End If
            End If
            Me.btnMostrar1.Focus()
            ActualizaGrid()
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim ofrm As New frmMSPLInstituciones
            Dim ds As New Data.DataSet
            Dim dr As DataRow

            If fg.Row <> -1 Then
                ofrm.btnGuardar1.Text = "&Modificar"
                ds = oPlan.ConsultarPLInstituciones("*", "CodInstitucion='" & Trim(fg.Item(fg.Row, "CodInstitucion")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.txtCodInstitucion.Text = dr("CodInstitucion")
                ofrm.txtCodInstitucion.ReadOnly = True
                ofrm.txtNombreInstitucion.Text = dr("Nombre")
                If dr("Tipo") = "1" Then
                    ofrm.chkInstBanc.Checked = True
                Else
                    ofrm.chkInstBanc.Checked = False
                End If
                ofrm.btnGuardar1.Enabled = False
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizaGrid()
                Encabezado()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            Dim ds As New Data.DataSet
            If Me.rbtCodInstitucion.Checked = True Then
                ds = oPlan.ConsultarPLInstituciones("*", "CodInstitucion LIKE '" & Trim(Me.txtCodInstitucion.Text) & "%'", "CodInstitucion", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbtNombre.Checked = True Then
                ds = oPlan.ConsultarPLInstituciones("*", "Nombre LIKE '" & Trim(Me.txtNombre.Text) & "%'", "CodInstitucion", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            Else
                ActualizaGrid()
            End If
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class