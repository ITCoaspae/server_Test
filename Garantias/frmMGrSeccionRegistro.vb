Public Class frmMGrSeccionRegistro
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMGrSeccionRegistro))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
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
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 98)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(536, 219)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 52
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(185, 64)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 215
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(104, 63)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(75, 28)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 214
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 63)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 213
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(266, 63)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 216
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'frmMGrSeccionRegistro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(582, 379)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMGrSeccionRegistro"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Secciones de Registro"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "Código"
        fg.Cols.Item(2).Caption = "Descripción"

        fg.Cols.Item(0).Width = 50
        fg.Cols.Item(1).Width = 200
        fg.Cols.Item(2).Width = 500

    End Sub

    Private Sub ActualizaGrid()
        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarSeccionRegistro("*", "", "CodSeccion", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Secciones del Registro" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Encabezado()
    End Sub

    Private Sub frmMGrSeccionRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        btnConsultar1_Click(sender, e)
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsGrSeccionRegistro = New frmMsGrSeccionRegistro
            frm.pAccion = "Agregar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As frmMsGrSeccionRegistro = New frmMsGrSeccionRegistro
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.pCodigo = fg.Item(fg.Row, "CodSeccion")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If fg.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Sección de Registro seleccionada?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Sección del Registro") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarSeccionRegistro(fg.Item(fg.Row, "CodSeccion"), sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As frmMsGrSeccionRegistro = New frmMsGrSeccionRegistro
                frm.pAccion = "Modificar"
                frm.pCodigo = fg.Item(fg.Row, "CodSeccion")
                frm.btnGuardar1.Enabled = False
                frm.btnGuardar1.Text = "&Consulta"
                frm.btnGuardar1.Visible = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class