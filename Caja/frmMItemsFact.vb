Public Class frmMItemsFact
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtTipoItem As System.Windows.Forms.TextBox
    Friend WithEvents txtCodItem As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents rbtTipoItem As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDescripción As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCodItem As System.Windows.Forms.RadioButton
    Friend WithEvents txtRubro As System.Windows.Forms.TextBox
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents rbRubro As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMItemsFact))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtRubro = New System.Windows.Forms.TextBox()
        Me.rbRubro = New System.Windows.Forms.RadioButton()
        Me.txtTipoItem = New System.Windows.Forms.TextBox()
        Me.txtCodItem = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.rbtTipoItem = New System.Windows.Forms.RadioButton()
        Me.rbtDescripción = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbtCodItem = New System.Windows.Forms.RadioButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtRubro)
        Me.GroupBox2.Controls.Add(Me.rbRubro)
        Me.GroupBox2.Controls.Add(Me.txtTipoItem)
        Me.GroupBox2.Controls.Add(Me.txtCodItem)
        Me.GroupBox2.Controls.Add(Me.txtDesc)
        Me.GroupBox2.Controls.Add(Me.rbtTipoItem)
        Me.GroupBox2.Controls.Add(Me.rbtDescripción)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbtCodItem)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 174)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar Items por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(491, 110)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 32)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 58
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtRubro
        '
        Me.txtRubro.BackColor = System.Drawing.Color.White
        Me.txtRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRubro.Location = New System.Drawing.Point(19, 129)
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.Size = New System.Drawing.Size(183, 22)
        Me.txtRubro.TabIndex = 7
        '
        'rbRubro
        '
        Me.rbRubro.BackColor = System.Drawing.Color.White
        Me.rbRubro.Location = New System.Drawing.Point(19, 95)
        Me.rbRubro.Name = "rbRubro"
        Me.rbRubro.Size = New System.Drawing.Size(159, 27)
        Me.rbRubro.TabIndex = 6
        Me.rbRubro.Text = "Tipo de &Rubro:"
        Me.rbRubro.UseVisualStyleBackColor = False
        '
        'txtTipoItem
        '
        Me.txtTipoItem.BackColor = System.Drawing.Color.White
        Me.txtTipoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoItem.Location = New System.Drawing.Point(398, 62)
        Me.txtTipoItem.Name = "txtTipoItem"
        Me.txtTipoItem.Size = New System.Drawing.Size(183, 22)
        Me.txtTipoItem.TabIndex = 5
        '
        'txtCodItem
        '
        Me.txtCodItem.BackColor = System.Drawing.Color.White
        Me.txtCodItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodItem.Location = New System.Drawing.Point(19, 65)
        Me.txtCodItem.MaxLength = 10
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.Size = New System.Drawing.Size(183, 22)
        Me.txtCodItem.TabIndex = 1
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Location = New System.Drawing.Point(209, 62)
        Me.txtDesc.MaxLength = 15
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(182, 22)
        Me.txtDesc.TabIndex = 3
        '
        'rbtTipoItem
        '
        Me.rbtTipoItem.BackColor = System.Drawing.Color.White
        Me.rbtTipoItem.Location = New System.Drawing.Point(398, 28)
        Me.rbtTipoItem.Name = "rbtTipoItem"
        Me.rbtTipoItem.Size = New System.Drawing.Size(183, 27)
        Me.rbtTipoItem.TabIndex = 4
        Me.rbtTipoItem.Text = "Tipo de Item:"
        Me.rbtTipoItem.UseVisualStyleBackColor = False
        '
        'rbtDescripción
        '
        Me.rbtDescripción.BackColor = System.Drawing.Color.White
        Me.rbtDescripción.Location = New System.Drawing.Point(209, 28)
        Me.rbtDescripción.Name = "rbtDescripción"
        Me.rbtDescripción.Size = New System.Drawing.Size(182, 27)
        Me.rbtDescripción.TabIndex = 2
        Me.rbtDescripción.Text = "Descripción:"
        Me.rbtDescripción.UseVisualStyleBackColor = False
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(209, 95)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(182, 27)
        Me.rbTodos.TabIndex = 8
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "&Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'rbtCodItem
        '
        Me.rbtCodItem.BackColor = System.Drawing.Color.White
        Me.rbtCodItem.Location = New System.Drawing.Point(19, 28)
        Me.rbtCodItem.Name = "rbtCodItem"
        Me.rbtCodItem.Size = New System.Drawing.Size(183, 27)
        Me.rbtCodItem.TabIndex = 0
        Me.rbtCodItem.Text = "Código de Item:"
        Me.rbtCodItem.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(28, 293)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(659, 150)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 14
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 254)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 64
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 254)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 63
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(222, 254)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 62
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(319, 254)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 65
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'frmMItemsFact
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(715, 501)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMItemsFact"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Items Facturables"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "Código Item"
        fg.Cols.Item(2).Caption = "Descripción"
        fg.Cols.Item(3).Caption = "Rubro"
        fg.Cols.Item(4).Caption = "Tipo de Item"
        fg.Cols.Item(5).Caption = "Aplicación"
        fg.Cols.Item(6).Caption = "Gravado"
        fg.Cols.Item(7).Caption = "Cuenta Cargo"
        fg.Cols.Item(8).Caption = "Cuenta Abono"
        fg.Cols.Item(9).Caption = "Orden"
        fg.Cols.Item(10).Caption = "No Aplica Gravado"
        fg.Cols.Item(11).Caption = "Aplica Cuenta"
        fg.Cols.Item(12).Caption = "Tipo Movimiento"
        fg.Cols.Item(13).Caption = "Tipo Documento"
        fg.Cols.Item(14).Caption = "Id.Mov."
        fg.Cols.Item(15).Caption = "Valor"
        fg.Cols.Item(16).Caption = "Estado"

        fg.Cols.Item(0).Width = 25
        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 180
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 100
        fg.Cols.Item(5).Width = 100
        fg.Cols.Item(6).Width = 70
        fg.Cols.Item(7).Width = 100
        fg.Cols.Item(8).Width = 100
        fg.Cols.Item(9).Width = 70
        fg.Cols.Item(10).Width = 100
        fg.Cols.Item(11).Width = 100
        fg.Cols.Item(12).Width = 100
        fg.Cols.Item(13).Width = 100
        fg.Cols.Item(14).Width = 100
        fg.Cols.Item(15).Width = 100
        fg.Cols.Item(16).Width = 100

    End Sub

    Private Sub ActualizarGrid()
        Dim ds As New Data.DataSet
        Dim oItem As wrCaja.wsLibCaja = New wrCaja.wsLibCaja

        Try
            ds = oItem.ConsultarCAItemsFact("*", "", "CodItem", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos.", MsgBoxStyle.Critical, "Módulo - Asociados")
        End Try
        Encabezado()
    End Sub

#Region "Métodos"






    Private Sub ActualizaGrid()
        Dim ds As New Data.DataSet
        Dim oItem As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
        Try
            ds = oItem.ConsultarCAItemsFact("*", "", "CodItem", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Asociados")
        End Try
        Encabezado()
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oItem As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
        Dim ds As New Data.DataSet
        Try
            If Me.rbtCodItem.Checked = True Then
                ds = oItem.ConsultarCAItemsFact("*", "CodItem LIKE '" & Trim(Me.txtCodItem.Text) & "%'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbtTipoItem.Checked = True Then
                ds = oItem.ConsultarCAItemsFact("*", "Tipo_Item LIKE '" & Trim(Me.txtTipoItem.Text) & "%'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbtDescripción.Checked = True Then
                ds = oItem.ConsultarCAItemsFact("*", "Descripcion LIKE '" & Trim(Me.txtDesc.Text) & "%'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbTodos.Checked = True Then
                ds = oItem.ConsultarCAItemsFact("*", "", "CodItem", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbRubro.Checked = True Then
                ds = oItem.ConsultarCAItemsFact("*", "IdRubro LIKE '" & Trim(Me.txtRubro.Text) & "%'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            End If
            Encabezado()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub fg_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Me.btnModificar1_Click(sender, e)
    End Sub

#End Region

    Private Sub frmMItemsFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()
    End Sub

    Private Sub rbtCodItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCodItem.CheckedChanged
        Me.txtCodItem.Focus()
    End Sub

    Private Sub rbtDescripción_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtDescripción.CheckedChanged
        Me.txtDesc.Focus()
    End Sub

    Private Sub rbtTipoItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtTipoItem.CheckedChanged
        Me.txtTipoItem.Focus()
    End Sub

    Private Sub txtCodItem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodItem.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub txtTipoItem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTipoItem.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Dim frm As New frmMsItemsFact
        Dim oItem As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
        Dim NumItem As Integer
        Try
            NumItem = oItem.ObtenerNumItem(sUsuario, sPassword, sSucursal)
            frm.btnGuardar1.Text = "&Guardar"
            frm.cbRubro.SelectedIndex = 0
            frm.cbDoc.SelectedIndex = 0
            frm.cbEstado.SelectedIndex = 0
            frm.txtCodItem.Text = NumItem
            frm.txtCodItem.ReadOnly = True
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            btnMostrar_Click(sender, e)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click

        Dim ds As New Data.DataSet, dr As DataRow, x As Integer
        Dim oItem As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
        Dim ofrm As New frmMsItemsFact
        Try
            If fg.Row <> -1 Then

                ds = oItem.ConsultarCAItemsFact("*", "CodItem='" & Trim(fg.Item(fg.Row, "CodItem")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar1.Text = "&Modificar"
                If Not dr("CodItem") Is DBNull.Value Then
                    ofrm.txtCodItem.Text = CStr(dr("CodItem"))
                    ofrm.txtCodItem.ReadOnly = True
                End If
                If Not dr("Descripcion") Is DBNull.Value Then
                    ofrm.txtDesc.Text = CStr(dr("Descripcion"))
                End If
                If Not dr("Tipo_Item") Is DBNull.Value Then
                    ofrm.txtTipoItem.Text = CStr(dr("Tipo_Item"))
                End If
                If Not dr("IdApp") Is DBNull.Value Then
                    ofrm.llenarcbAplicaciones()
                    ofrm.cbAplicacion.SelectedValue = dr("IdApp")
                    'ofrm.txtIdApp.Value = dr("IdApp")
                End If

                If dr("Gravado") = "S" Then
                    ofrm.rbtGravado.Checked = True
                ElseIf dr("Gravado") = "N" Then
                    If dr("NoAplicaGravado") = "N" Then
                        ofrm.rbtExcento.Checked = True
                    ElseIf dr("NoAplicaGravado") = "S" Then
                        ofrm.rbtNoGravNoExen.Checked = True
                    End If
                End If

                If Not dr("Valor") Is DBNull.Value Then
                    ofrm.c1nValor.Value = dr("Valor")
                End If

                If Not dr("IdCuentaA") Is DBNull.Value Then
                    ofrm.txtIdCuentaA.Text = CStr(dr("IdCuentaA"))
                End If
                If Not dr("IdCuentaC") Is DBNull.Value Then
                    ofrm.txtIdCuentaC.Text = CStr(dr("IdCuentaC"))
                End If
                If Not dr("Orden") Is DBNull.Value Then
                    ofrm.txtOrden.Value = CStr(dr("Orden"))
                End If

                If Not dr("TipoMovimiento") Is DBNull.Value Then
                    ofrm.txtTipoMovimiento.Text = CStr(dr("TipoMovimiento"))
                End If

                Dim AplicaCta As String = dr("AplicaCuenta")
                If AplicaCta = "1" Then
                    ofrm.chkAplicaCuenta.Checked = True
                ElseIf AplicaCta = "0" Then
                    ofrm.chkAplicaCuenta.Checked = False
                End If

                If Not dr("TipoDoc") Is DBNull.Value Then
                    For x = 0 To ofrm.cbDoc.Items.Count - 1
                        ofrm.cbDoc.SelectedIndex = x
                        If Mid(ofrm.cbDoc.Text, 1, 1).Trim = Trim(dr("TipoDoc")) Then
                            ofrm.cbDoc.SelectedIndex = x
                            Exit For
                        End If
                    Next
                Else
                    ofrm.cbDoc.SelectedIndex = 0
                End If

                If Not dr("Estado") Is DBNull.Value Then
                    ofrm.cbEstado.SelectedIndex = dr("Estado")
                Else
                    ofrm.cbEstado.SelectedIndex = 0
                End If

                If Not dr("IdRubro") Is DBNull.Value Then
                    ofrm.llenarCbRubros()
                    ofrm.cbRubro.SelectedValue = dr("IdRubro")
                    'For x = 0 To ofrm.cbRubro.Items.Count - 1
                    '    ofrm.cbRubro.SelectedIndex = x
                    '    If Mid(ofrm.cbRubro.Text, 1, 1).Trim = Trim(dr("IdRubro")) Then
                    '        ofrm.cbRubro.SelectedIndex = x
                    '        Exit For
                    '    End If
                    'Next
                Else
                    ofrm.llenarCbRubros()
                    ofrm.cbRubro.SelectedIndex = 0
                End If

                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                btnMostrar_Click(sender, e)

            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Dim oItem As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
        Try
            If fg.Row <> -1 Then
                If oItem.EliminarCAItemsFact("'" & Trim(fg.Item(fg.Row, "CodItem")) & "'", sUsuario, sPassword, sSucursal) = True Then
                    btnMostrar_Click(sender, e)
                Else
                    MsgBox("El registro se encuentra relacionado con otra tabla", MsgBoxStyle.Information, "Módulo - Asociados")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click

        Dim ds As New Data.DataSet, dr As DataRow, x As Integer
        Dim oItem As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
        Dim ofrm As New frmMsItemsFact
        Try
            If fg.Row <> -1 Then

                ds = oItem.ConsultarCAItemsFact("*", "CodItem='" & Trim(fg.Item(fg.Row, "CodItem")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.btnGuardar1.Enabled = False
                If Not dr("CodItem") Is DBNull.Value Then
                    ofrm.txtCodItem.Text = CStr(dr("CodItem"))
                    ofrm.txtCodItem.ReadOnly = True
                End If
                If Not dr("Descripcion") Is DBNull.Value Then
                    ofrm.txtDesc.Text = CStr(dr("Descripcion"))
                End If
                If Not dr("Tipo_Item") Is DBNull.Value Then
                    ofrm.txtTipoItem.Text = CStr(dr("Tipo_Item"))
                End If
                If Not dr("IdApp") Is DBNull.Value Then
                    ofrm.llenarcbAplicaciones()
                    ofrm.cbAplicacion.SelectedValue = dr("IdApp")
                    'ofrm.txtIdApp.Value = dr("IdApp")
                End If

                If dr("Gravado") = "S" Then
                    ofrm.rbtGravado.Checked = True
                ElseIf dr("Gravado") = "N" Then
                    If dr("NoAplicaGravado") = "N" Then
                        ofrm.rbtExcento.Checked = True
                    ElseIf dr("NoAplicaGravado") = "S" Then
                        ofrm.rbtNoGravNoExen.Checked = True
                    End If
                End If

                If Not dr("Valor") Is DBNull.Value Then
                    ofrm.c1nValor.Value = dr("Valor")
                End If

                If Not dr("IdCuentaA") Is DBNull.Value Then
                    ofrm.txtIdCuentaA.Text = CStr(dr("IdCuentaA"))
                End If
                If Not dr("IdCuentaC") Is DBNull.Value Then
                    ofrm.txtIdCuentaC.Text = CStr(dr("IdCuentaC"))
                End If
                If Not dr("Orden") Is DBNull.Value Then
                    ofrm.txtOrden.Value = CStr(dr("Orden"))
                End If

                If Not dr("TipoMovimiento") Is DBNull.Value Then
                    ofrm.txtTipoMovimiento.Text = CStr(dr("TipoMovimiento"))
                End If

                Dim AplicaCta As String = dr("AplicaCuenta")
                If AplicaCta = "1" Then
                    ofrm.chkAplicaCuenta.Checked = True
                ElseIf AplicaCta = "0" Then
                    ofrm.chkAplicaCuenta.Checked = False
                End If

                If Not dr("TipoDoc") Is DBNull.Value Then
                    For x = 0 To ofrm.cbDoc.Items.Count - 1
                        ofrm.cbDoc.SelectedIndex = x
                        If Mid(ofrm.cbDoc.Text, 1, 1).Trim = Trim(dr("TipoDoc")) Then
                            ofrm.cbDoc.SelectedIndex = x
                            Exit For
                        End If
                    Next
                Else
                    ofrm.cbDoc.SelectedIndex = 0
                End If

                If Not dr("Estado") Is DBNull.Value Then
                    ofrm.cbEstado.SelectedIndex = dr("Estado")
                Else
                    ofrm.cbEstado.SelectedIndex = 0
                End If

                If Not dr("IdRubro") Is DBNull.Value Then
                    For x = 0 To ofrm.cbRubro.Items.Count - 1
                        ofrm.cbRubro.SelectedIndex = x
                        If Mid(ofrm.cbRubro.Text, 1, 1).Trim = Trim(dr("IdRubro")) Then
                            ofrm.cbRubro.SelectedIndex = x
                            Exit For
                        End If
                    Next
                Else
                    ofrm.cbRubro.SelectedIndex = 0
                End If

                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                btnMostrar_Click(sender, e)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub
End Class