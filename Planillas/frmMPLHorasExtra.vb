Public Class frmMPLHorasExtra
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents rbtCodEmpleado As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPLHorasExtra))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.rbtCodEmpleado = New System.Windows.Forms.RadioButton()
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
        Me.fg.Location = New System.Drawing.Point(23, 155)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(497, 182)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 48
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtCodEmpleado)
        Me.GroupBox2.Controls.Add(Me.rbtCodEmpleado)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 52)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar datos por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(352, 20)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 105
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.Location = New System.Drawing.Point(194, 24)
        Me.txtCodEmpleado.MaxLength = 10
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(152, 20)
        Me.txtCodEmpleado.TabIndex = 12
        '
        'rbtCodEmpleado
        '
        Me.rbtCodEmpleado.BackColor = System.Drawing.Color.White
        Me.rbtCodEmpleado.ForeColor = System.Drawing.Color.Black
        Me.rbtCodEmpleado.Location = New System.Drawing.Point(16, 24)
        Me.rbtCodEmpleado.Name = "rbtCodEmpleado"
        Me.rbtCodEmpleado.Size = New System.Drawing.Size(159, 24)
        Me.rbtCodEmpleado.TabIndex = 10
        Me.rbtCodEmpleado.Text = "Código de Empleado"
        Me.rbtCodEmpleado.UseVisualStyleBackColor = False
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 121)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 107
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 121)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 106
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 121)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 105
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 121)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 104
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLHorasExtra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(543, 401)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMPLHorasExtra"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Horas Extras"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub RefrescarGrid()
        Dim ds As New Data.DataSet
        Try
            ds = oPlan.ConsultarPLHorasExtras("*", "", "CodEmpleado", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmMPLHorasExtra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefrescarGrid()
    End Sub


    Private Sub rbtCodEmpleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCodEmpleado.CheckedChanged
        Me.txtCodEmpleado.Focus()
    End Sub

    Private Sub txtCodEmpleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEmpleado.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub



    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim Filtro As String
        Dim ds As New Data.DataSet
        Try
            If Me.rbtCodEmpleado.Checked = True Then
                Filtro = "CodEmpleado LIKE '" & Trim(Me.txtCodEmpleado.Text) & "%'"
            End If
            ds = oPlan.ConsultarPLHorasExtras("*", Filtro, "CodEmpleado", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMSPLHorasExtra
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            RefrescarGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        If fg.Row <> -1 Then
            Dim ds As New Data.DataSet
            Dim ofrm As New frmMSPLHorasExtra
            Dim dr As Data.DataRow
            Try
                ds = oPlan.ConsultarPLHorasExtras("*", "Correlativo='" & Trim(fg.Item(fg.Row, "Correlativo")) & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.pCorrelativo = IIf(IsDBNull(dr("Correlativo")), "", dr("Correlativo"))
                ofrm.txtCodEmpleado.Text = IIf(IsDBNull(dr("CodEmpleado")), "", dr("CodEmpleado"))
                ofrm.txtCodEmpleado.ReadOnly = True
                ofrm.txtCodTipoHoraExtra.Text = IIf(IsDBNull(dr("CodTipoHoraExtra")), "", dr("CodTipoHoraExtra"))
                ofrm.c1nValor.Value = IIf(IsDBNull(dr("Valor")), "", dr("Valor"))
                If Not IsDBNull(dr("FechaInicio")) Then
                    ofrm.dtpFechaInicio.Value = dr("FechaInicio")
                End If
                If Not IsDBNull(dr("FechaFin")) Then
                    ofrm.dtpFechaFin.Value = dr("FechaFin")
                End If
                ofrm.dtpFechaInicio.Visible = True
                ofrm.dtpHoraInicio.Text = dr("HoraInicio")
                ofrm.dtpHoraFin.Text = dr("HoraFin")
                ofrm.txtCantidadHoras.Text = IIf(IsDBNull(dr("TotalHoras")), "", dr("TotalHoras"))
                ofrm.txtObservaciones.Text = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                ofrm.txtNumPlaza.Text = dr("NoPlaza")
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                RefrescarGrid()
            Catch ex As Exception
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Try
                If oPlan.EliminarPLHorasExtras("" & fg.Item(fg.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal) = True Then
                    RefrescarGrid()
                    MsgBox("Registro eliminado", MsgBoxStyle.Information, "Módulo - Planilla")
                Else
                    MsgBox("Registro NO eliminado", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            If fg.Row <> -1 Then
                Dim ds As New Data.DataSet
                Dim ofrm As New frmMSPLHorasExtra
                Dim dr As Data.DataRow
                Try
                    ds = oPlan.ConsultarPLHorasExtras("*", "Correlativo='" & Trim(fg.Item(fg.Row, "Correlativo")) & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                    dr = ds.Tables(0).Rows(0)
                    ofrm.btnGuardar1.Text = "&Modificar"
                    ofrm.btnGuardar1.Enabled = False
                    ofrm.pCorrelativo = IIf(IsDBNull(dr("Correlativo")), "", dr("Correlativo"))
                    ofrm.txtCodEmpleado.Text = IIf(IsDBNull(dr("CodEmpleado")), "", dr("CodEmpleado"))
                    ofrm.txtCodTipoHoraExtra.Text = IIf(IsDBNull(dr("CodTipoHoraExtra")), "", dr("CodTipoHoraExtra"))
                    ofrm.txtCodEmpleado.ReadOnly = True
                    ofrm.c1nValor.Value = IIf(IsDBNull(dr("Valor")), "", dr("Valor"))
                    If Not IsDBNull(dr("FechaInicio")) Then
                        ofrm.dtpFechaInicio.Value = dr("FechaInicio")
                    End If
                    If Not IsDBNull(dr("FechaFin")) Then
                        ofrm.dtpFechaFin.Value = dr("FechaFin")
                    End If
                    ofrm.dtpHoraInicio.Text = dr("HoraInicio")
                    ofrm.dtpHoraFin.Text = dr("HoraFin")
                    ofrm.txtCantidadHoras.Text = IIf(IsDBNull(dr("TotalHoras")), "", dr("TotalHoras"))
                    ofrm.txtObservaciones.Text = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                    ofrm.txtNumPlaza.Text = dr("NoPlaza")
                    ofrm.StartPosition = FormStartPosition.CenterScreen
                    ofrm.ShowDialog()
                    RefrescarGrid()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class