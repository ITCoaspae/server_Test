Public Class frmMProcesoRetiro
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents fgRetiro As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMProcesoRetiro))
        Me.fgRetiro = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fgRetiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fgRetiro
        '
        Me.fgRetiro.AllowEditing = False
        Me.fgRetiro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgRetiro.BackColor = System.Drawing.Color.White
        Me.fgRetiro.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.fgRetiro.Location = New System.Drawing.Point(19, 166)
        Me.fgRetiro.Name = "fgRetiro"
        Me.fgRetiro.Rows.Count = 2
        Me.fgRetiro.Rows.DefaultSize = 18
        Me.fgRetiro.Size = New System.Drawing.Size(603, 354)
        Me.fgRetiro.StyleInfo = resources.GetString("fgRetiro.StyleInfo")
        Me.fgRetiro.TabIndex = 29
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(437, 107)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 21
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(103, 56)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(153, 16)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.Location = New System.Drawing.Point(360, 56)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(152, 20)
        Me.txtNoSocio.TabIndex = 3
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.Location = New System.Drawing.Point(261, 83)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(251, 20)
        Me.txtNombres.TabIndex = 6
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.Location = New System.Drawing.Point(19, 83)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(79, 18)
        Me.rbNombres.TabIndex = 4
        Me.rbNombres.Text = "Nombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(19, 109)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(152, 18)
        Me.rbTodos.TabIndex = 7
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.BackColor = System.Drawing.Color.White
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(103, 83)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(153, 21)
        Me.cbNombres.TabIndex = 5
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.Location = New System.Drawing.Point(261, 53)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(94, 23)
        Me.rbNoSocio.TabIndex = 2
        Me.rbNoSocio.Text = "No. Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Location = New System.Drawing.Point(19, 55)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(49, 23)
        Me.rbDui.TabIndex = 0
        Me.rbDui.Text = "DUI"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(262, 133)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 27)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 80
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(181, 133)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 27)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 79
        Me.btnEliminar1.Text = "Anular"
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(100, 133)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(75, 27)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 78
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(19, 133)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 27)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 77
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMProcesoRetiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(641, 599)
        Me.Controls.Add(Me.btnMostrar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.rbNombres)
        Me.Controls.Add(Me.rbNoSocio)
        Me.Controls.Add(Me.cbNombres)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.fgRetiro)
        Me.Controls.Add(Me.rbDui)
        Me.Name = "frmMProcesoRetiro"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Proceso de Retiro Voluntario"
        CType(Me.fgRetiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub frmMProcesoRetiro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ActualizaGrid()
        'Me.WindowState = FormWindowState.Normal
        txtDui.Enabled = False
        txtNombres.Enabled = False
        txtNoSocio.Enabled = False
        cbNombres.SelectedIndex = 0
        cbNombres.Enabled = False


    End Sub


    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarRetiros("A", "a.FechaActa='" & Now.ToShortDateString & "'", "a.Correlativo", sUsuario, sPassword, sSucursal)
            fgRetiro.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Retiros." & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        fgRetiro.Cols.Item(0).Width = 17
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmAGenerico
        Dim sTexto As String

        frm.Text = "Buscar Retiros"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, ds2 As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarRetiros("A", "", "a.NoSolicitudRetiro,a.DUI", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 2
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros
                fgRetiro.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oAsoc.ConsultarRetiros("A", "", "a.DUI", sUsuario, sPassword, sSucursal)
                fgRetiro.Cols.Item(0).Width = 17
                fgRetiro.DataSource = ds.Tables(0)
                fgRetiro.Cols.Item(0).Width = 17
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                fgRetiro.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oAsoc.ConsultarRetiros("A", "a.Dui='" & sTexto & "'", "", sUsuario, sPassword, sSucursal)
                fgRetiro.Cols.Item(0).Width = 17
                fgRetiro.DataSource = ds.Tables(0)
                fgRetiro.Cols.Item(0).Width = 17
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Retiros - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub rbNombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        If rbNombres.Checked = True Then
            cbNombres.Enabled = True
            txtNombres.Enabled = True
        ElseIf rbNombres.Checked = False Then
            cbNombres.Enabled = False
            txtNombres.Enabled = False
        End If
        Me.cbNombres.Focus()
    End Sub

    Private Sub rbDui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
        If rbDui.Checked = True Then
            txtDui.Enabled = True
        ElseIf rbDui.Checked = False Then
            txtDui.Enabled = False
        End If
        Me.txtDui.Focus()
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnMostrar1_Click(sender, e)
        End If
    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnMostrar1_Click(sender, e)
        End If
    End Sub

    Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbNoSocio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoSocio.CheckedChanged
        Me.txtNoSocio.Enabled = Me.rbNoSocio.Checked
        Me.txtNoSocio.Focus()
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Dim pFiltro As String
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            If rbDui.Checked = True Then
                ds = oAsoc.ConsultarRetiros("A", "a.Dui='" & Trim(txtDui.Text) & "'", "a.NoSolicitudRetiro", sUsuario, sPassword, sSucursal)
            ElseIf rbNoSocio.Checked = True Then
                ds = oAsoc.ConsultarAsociado("Dui", "NoSocio='" & Trim(txtNoSocio.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                pFiltro = ""
                For Each dr In ds.Tables(0).Rows
                    If pFiltro.Trim = "" Then
                        pFiltro = "a.Dui='" & dr("Dui") & "'"
                    Else
                        pFiltro = pFiltro & "or a.Dui='" & dr("Dui") & "'"
                    End If
                Next
                If pFiltro.Trim = "" Then
                    fgRetiro.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                    fgRetiro.Cols.Item(0).Width = 17
                    Exit Sub
                Else
                    If ds.Tables(0).Rows.Count > 0 Then
                        ds = oAsoc.ConsultarRetiros("A", "(" & pFiltro & ")", "a.Dui", sUsuario, sPassword, sSucursal)
                    End If
                End If
            ElseIf rbNombres.Checked = True Then
                If Me.cbNombres.SelectedIndex = 0 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido1 like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf Me.cbNombres.SelectedIndex = 1 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido2 like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf Me.cbNombres.SelectedIndex = 2 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Nombres like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
                pFiltro = ""
                For Each dr In ds.Tables(0).Rows
                    If pFiltro.Trim = "" Then
                        pFiltro = "a.Dui='" & dr("Dui") & "'"
                    Else
                        pFiltro = pFiltro & "or a.Dui='" & dr("Dui") & "'"
                    End If
                Next
                If pFiltro.Trim = "" Then
                    fgRetiro.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                    fgRetiro.Cols.Item(0).Width = 17
                    Exit Sub
                Else
                    If ds.Tables(0).Rows.Count > 0 Then
                        ds = oAsoc.ConsultarRetiros("A", "(" & pFiltro & ")", "a.Dui", sUsuario, sPassword, sSucursal)
                    End If
                End If
            ElseIf rbTodos.Checked = True Then
                ds = oAsoc.ConsultarRetiros("A", "", "a.NoSolicitudRetiro", sUsuario, sPassword, sSucursal)
            End If
            fgRetiro.Cols.Item(0).Width = 17
            fgRetiro.DataSource = ds.Tables(0)
            fgRetiro.Cols.Item(0).Width = 17
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Dim frm As frmMsProcesoRetiro = New frmMsProcesoRetiro
        frm.pCont = False
        frm.btnGuardar1.Text = "&Guardar"
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        ActualizaGrid()
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        If fgRetiro.Row <> -1 Then
            If fgRetiro.Item(Me.fgRetiro.Row, "Anulado") = False And IsDBNull(fgRetiro.Item(fgRetiro.Row, "RetiroEfectuado")) = True Then

                Dim frm As New frmMsProcesoRetiro
                frm.pCont = False
                frm.btnGuardar1.Text = "&Modificar"
                frm.pCorr = fgRetiro.Item(Me.fgRetiro.Row, "Correlativo")
                frm.txtDui.Value = fgRetiro.Item(Me.fgRetiro.Row, "DUI")
                frm.txtMonto.Text = fgRetiro.Item(Me.fgRetiro.Row, "montoLiquidar")
                frm.btnGuardar1.Enabled = False

                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                txtDui.Enabled = False
                txtNombres.Enabled = False
                txtNoSocio.Enabled = False
                cbNombres.Enabled = False
            Else
                MsgBox("Proceso de retiro anulado.", MsgBoxStyle.Critical, "Módulo - Asociados")
            End If

        End If
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If fgRetiro.Row <> -1 Then
                If MsgBox("¿Desea anular el registro del Asociado Dui No. " & fgRetiro.Item(Me.fgRetiro.Row, "DUI") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Anular Retiro") = MsgBoxResult.Yes Then
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
                    'oAsoc.EliminarRetiros("Correlativo='" & fgRetiro.Item(Me.fgRetiro.Row, "Correlativo") & "'", sUsuario, sPassword, sSucursal)
                    If oAsoc.ModificarRetiros("Correlativo = '" & fgRetiro.Item(Me.fgRetiro.Row, "Correlativo") & "'", "Anulado = 'True'", sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Anulación realizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                    Else
                        MsgBox("La anulación no fue realalizada, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Asociados")
                    End If
                    ActualizaGrid()
                    txtDui.Enabled = False
                    txtNombres.Enabled = False
                    txtNoSocio.Enabled = False
                    cbNombres.Enabled = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        If fgRetiro.Row <> -1 Then
            Dim frm As frmMsProcesoRetiro = New frmMsProcesoRetiro
            frm.btnGuardar1.Text = "&Modificar"
            frm.pCont = False
            frm.pCorr = fgRetiro.Item(Me.fgRetiro.Row, "Correlativo")
            frm.txtDui.Value = fgRetiro.Item(Me.fgRetiro.Row, "DUI")
            frm.btnGuardar1.Visible = False
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
            txtDui.Enabled = False
            txtNombres.Enabled = False
            txtNoSocio.Enabled = False
            cbNombres.Enabled = False
        End If
    End Sub

    Private Sub frmMProcesoRetiro_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class