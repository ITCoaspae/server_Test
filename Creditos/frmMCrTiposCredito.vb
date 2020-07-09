Public Class frmMCrTiposCredito
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) '' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCrTiposCredito))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.rbCodigo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(596, 108)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Tipos de Crédito por:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(209, 54)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 33)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 224
        Me.MetroButton1.Text = "Mostrar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(19, 63)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(183, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'rbCodigo
        '
        Me.rbCodigo.BackColor = System.Drawing.Color.White
        Me.rbCodigo.Location = New System.Drawing.Point(19, 28)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(183, 27)
        Me.rbCodigo.TabIndex = 0
        Me.rbCodigo.Text = "&Código"
        Me.rbCodigo.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(28, 227)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(807, 246)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 34
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(319, 188)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 223
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(222, 188)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 222
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 188)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 221
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 188)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 220
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMCrTiposCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(862, 533)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMCrTiposCredito"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Tipos de Crédito"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMCrTiposCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
        Me.WindowState = FormWindowState.Normal
        txtCodigo.Enabled = False
    End Sub

    Private Sub Encabezado()
        fg.Cols.Item(1).Caption = "Código"
        fg.Cols.Item(2).Caption = "Descripción"
        fg.Cols.Item(3).Caption = "Plazo Máximo"
        fg.Cols.Item(4).Caption = "Interés Actual"
        fg.Cols.Item(5).Caption = "Código Línea Crédito"
        fg.Cols.Item(6).Caption = "Genera Reserva"
        fg.Cols.Item(11).Caption = "Plazo Mínimo"
        fg.Cols.Item(12).Caption = "Promoción"
        fg.Cols.Item(13).Caption = "Inicio Promoción"
        fg.Cols.Item(14).Caption = "Fin Promoción"
        fg.Cols.Item(15).Caption = "Tipo Garantía"
        fg.Cols.Item(16).Caption = "Cuenta Contable"
        fg.Cols.Item(17).Caption = "Interés Moratorio"
        fg.Cols.Item(18).Caption = "Días Gracia"

        fg.Cols.Item(1).Width = 77
        fg.Cols.Item(2).Width = 150
        fg.Cols.Item(3).Width = 200
        fg.Cols.Item(4).Width = 100
        fg.Cols.Item(5).Width = 100
        fg.Cols.Item(6).Width = 100
        fg.Cols.Item(7).Width = 0
        fg.Cols.Item(8).Width = 0
        fg.Cols.Item(9).Width = 0
        fg.Cols.Item(10).Width = 0
        fg.Cols.Item(11).Width = 100
        fg.Cols.Item(12).Width = 77
        fg.Cols.Item(13).Width = 100
        fg.Cols.Item(14).Width = 100
        fg.Cols.Item(15).Width = 100
        fg.Cols.Item(16).Width = 100
        fg.Cols.Item(17).Width = 100
        fg.Cols.Item(18).Width = 100

    End Sub

    Private Sub ActualizaGrid()
        Dim oCred As New wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            ds = oCred.ConsultarTipoCreditos("*", "", "CodTipoCredito,Descripcion", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub rbCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodigo.CheckedChanged
        If rbCodigo.Checked = True Then
            txtCodigo.Enabled = True
        ElseIf rbCodigo.Checked = False Then
            txtCodigo.Enabled = False
        End If
        Me.txtCodigo.Focus()
    End Sub

    Private Sub fg_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        btnConsultar1_Click(sender, e)
    End Sub



    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsCrTipoCred = New frmMsCrTipoCred
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
                Dim frm As frmMsCrTipoCred = New frmMsCrTipoCred
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Text = "&Modificar"
                frm.pCodigo = fg.Item(fg.Row, "CodTipoCredito")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                txtCodigo.Enabled = False
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            Try
                If fg.Row <> -1 Then
                    If MsgBox("¿Desea eliminar el Tipo de Crédito seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Tipos de Crédito") = MsgBoxResult.Yes Then
                        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                        oCred.EliminarTipoCreditos(fg.Item(fg.Row, "CodTipoCredito"), sUsuario, sPassword, sSucursal)
                        ActualizaGrid()
                        txtCodigo.Enabled = False
                    End If
                End If
            Catch ex As Exception
               MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try

            If fg.Row <> -1 Then
                Dim frm As frmMsCrTipoCred = New frmMsCrTipoCred
                frm.pAccion = "Modificar"
                frm.pCodigo = fg.Item(fg.Row, "CodTipoCredito")
                frm.btnGuardar1.Enabled = False
                frm.btnGuardar1.Text = "&Consulta"
                frm.btnGuardar1.Visible = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                txtCodigo.Enabled = False
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet

            If rbCodigo.Checked = True Then
                ds = oCred.ConsultarTipoCreditos("*", "CodTipoCredito='" & Trim(txtCodigo.Text) & "'", "CodTipoCredito", sUsuario, sPassword, sSucursal)
            End If
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class