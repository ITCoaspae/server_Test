Public Class frmMPLDescuentosRenta
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPLDescuentosRenta))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "15,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 97)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(480, 150)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 37
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 63)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 95
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
        Me.btnDel.TabIndex = 94
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
        Me.btnMod.TabIndex = 93
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
        Me.btnAdd.TabIndex = 92
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLDescuentosRenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(526, 295)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMPLDescuentosRenta"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Descuentos Renta"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Encabezado()
        fg.Cols.Item(1).Caption = "Correlativo"
        fg.Cols.Item(2).Caption = "Tipo"
        fg.Cols.Item(3).Caption = "Desde"
        fg.Cols.Item(4).Caption = "Hasta"
        fg.Cols.Item(5).Caption = "Valor Fijo"
        fg.Cols.Item(6).Caption = "Porcentaje"
        fg.Cols.Item(7).Caption = "Valor Sobre"

        fg.Cols.Item(0).Width = 20
        fg.Cols.Item(1).Width = 75
        fg.Cols.Item(2).Width = 75
        fg.Cols.Item(3).Width = 75
        fg.Cols.Item(4).Width = 75
        fg.Cols.Item(5).Width = 75
        fg.Cols.Item(6).Width = 75
        fg.Cols.Item(7).Width = 75

    End Sub

    Private Sub ActualizarGrid()

        Dim ds As New Data.DataSet
        Try
            ds = oPlan.ConsultarPLDescuentosRenta("*", "", "Tipo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub frmMPLDescuentosRenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()
        Encabezado()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMSPLDescuentosRenta
            ofrm.vAccion = "Agregar"
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.txtCorrelativo.Visible = False
            ofrm.lblCorrelativo.Visible = False
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            ActualizarGrid()
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim ofrm As New frmMSPLDescuentosRenta

            Dim ds As New Data.DataSet
            Dim dr As DataRow
            If fg.Row <> -1 Then
                ofrm.vAccion = "Modificar"
                ofrm.btnGuardar1.Text = "&Modificar"
                ds = oPlan.ConsultarPLDescuentosRenta("*", "Correlativo='" & Val(fg.Item(fg.Row, "Correlativo")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.lblCorrelativo.Visible = True
                ofrm.txtCorrelativo.Visible = True
                ofrm.txtCorrelativo.Text = dr("Correlativo")
                ofrm.txtCorrelativo.ReadOnly = True
                ofrm.txtTipo.Text = dr("Tipo")
                ofrm.c1nDesde.Value = dr("Desde")
                ofrm.c1nHasta.Value = dr("Hasta")
                ofrm.c1nValorFijo.Value = dr("Valor_Fijo")
                ofrm.c1nPorcentaje.Value = dr("Porcentaje")
                ofrm.c1nValorSobre.Value = dr("Valor_Sobre")
                ofrm.lblCorrelativo.Visible = True
                ofrm.txtCorrelativo.Visible = True
                ofrm.txtCorrelativo.Text = fg.Item(fg.Row, "Correlativo")
                ofrm.txtCorrelativo.ReadOnly = True
                ofrm.txtTipo.Text = fg.Item(fg.Row, "Tipo")
                ofrm.c1nDesde.Value = Val(fg.Item(fg.Row, "Desde"))
                ofrm.c1nHasta.Value = Val(fg.Item(fg.Row, "Hasta"))
                ofrm.c1nValorFijo.Value = Val(fg.Item(fg.Row, "Valor_Fijo"))
                ofrm.c1nPorcentaje.Value = Val(fg.Item(fg.Row, "Porcentaje"))
                ofrm.c1nValorSobre.Value = Val(fg.Item(fg.Row, "Valor_Sobre"))
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizarGrid()
                Encabezado()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If fg.Row <> -1 Then
                oPlan.EliminarPLDescuentosRenta(Val(fg.Item(fg.Row, "Correlativo")), sUsuario, sPassword, sSucursal)
            End If
            ActualizarGrid()
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim ofrm As New frmMSPLDescuentosRenta

            Dim ds As New Data.DataSet
            Dim dr As DataRow

            If fg.Row <> -1 Then
                ofrm.vAccion = "Modificar"
                ofrm.btnGuardar1.Text = "&Modificar"
                ds = oPlan.ConsultarPLDescuentosRenta("*", "Correlativo='" & Val(fg.Item(fg.Row, "Correlativo")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.lblCorrelativo.Visible = True
                ofrm.txtCorrelativo.Visible = True
                ofrm.txtCorrelativo.Text = dr("Correlativo")
                ofrm.txtCorrelativo.ReadOnly = True
                ofrm.txtTipo.Text = dr("Tipo")
                ofrm.c1nDesde.Value = dr("Desde")
                ofrm.c1nHasta.Value = dr("Hasta")
                ofrm.c1nValorFijo.Value = dr("Valor_Fijo")
                ofrm.c1nPorcentaje.Value = dr("Porcentaje")
                ofrm.c1nValorSobre.Value = dr("Valor_Sobre")
                ofrm.lblCorrelativo.Visible = True
                ofrm.txtCorrelativo.Visible = True
                ofrm.txtCorrelativo.Text = fg.Item(fg.Row, "Correlativo")
                ofrm.txtCorrelativo.ReadOnly = True
                ofrm.txtTipo.Text = fg.Item(fg.Row, "Tipo")
                ofrm.c1nDesde.Value = Val(fg.Item(fg.Row, "Desde"))
                ofrm.c1nHasta.Value = Val(fg.Item(fg.Row, "Hasta"))
                ofrm.c1nValorFijo.Value = Val(fg.Item(fg.Row, "Valor_Fijo"))
                ofrm.c1nPorcentaje.Value = Val(fg.Item(fg.Row, "Porcentaje"))
                ofrm.c1nValorSobre.Value = Val(fg.Item(fg.Row, "Valor_Sobre"))
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizarGrid()
                Encabezado()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
