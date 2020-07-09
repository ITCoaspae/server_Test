Public Class frmMAhCuentasAhorro
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents rbNoCuenta As System.Windows.Forms.RadioButton
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents lblEstado As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMAhCuentasAhorro))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.rbNoCuenta = New System.Windows.Forms.RadioButton()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblEstado = New MetroFramework.Controls.MetroLabel()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "36,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(23, 245)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(625, 244)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 14
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(200, 178)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(348, 22)
        Me.txtNombres.TabIndex = 6
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(23, 143)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(171, 27)
        Me.rbNombres.TabIndex = 4
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(554, 168)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 32)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 169
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Enabled = False
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(23, 177)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(171, 24)
        Me.cbNombres.TabIndex = 5
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(200, 117)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(171, 22)
        Me.txtNoSocio.TabIndex = 3
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.Location = New System.Drawing.Point(208, 83)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(146, 28)
        Me.rbNoSocio.TabIndex = 2
        Me.rbNoSocio.Text = "&No. de Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(23, 117)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(171, 23)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.Location = New System.Drawing.Point(377, 117)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(171, 22)
        Me.txtNoCuenta.TabIndex = 8
        '
        'rbNoCuenta
        '
        Me.rbNoCuenta.BackColor = System.Drawing.Color.White
        Me.rbNoCuenta.Location = New System.Drawing.Point(377, 83)
        Me.rbNoCuenta.Name = "rbNoCuenta"
        Me.rbNoCuenta.Size = New System.Drawing.Size(138, 28)
        Me.rbNoCuenta.TabIndex = 7
        Me.rbNoCuenta.Text = "No. &Cuenta"
        Me.rbNoCuenta.UseVisualStyleBackColor = False
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Location = New System.Drawing.Point(23, 83)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(87, 28)
        Me.rbDui.TabIndex = 0
        Me.rbDui.Text = "&DUI"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(120, 207)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 168
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 207)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 167
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(217, 207)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 170
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(84, 20)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel1.TabIndex = 177
        Me.MetroLabel1.Text = "Buscar Por"
        Me.MetroLabel1.UseStyleColors = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblEstado.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblEstado.Location = New System.Drawing.Point(530, 213)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(0, 0)
        Me.lblEstado.Style = MetroFramework.MetroColorStyle.Teal
        Me.lblEstado.TabIndex = 178
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblEstado.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblEstado.UseStyleColors = True
        '
        'frmMAhCuentasAhorro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(671, 572)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.cbNombres)
        Me.Controls.Add(Me.rbNombres)
        Me.Controls.Add(Me.btnMostrar1)
        Me.Controls.Add(Me.txtNoCuenta)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.rbNoCuenta)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.rbNoSocio)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.rbDui)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMAhCuentasAhorro"
        Me.Opacity = 0.8R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Cuentas de Ahorro"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "Dui"
        fg.Cols.Item(2).Caption = "Nombre_Asociado"
        fg.Cols.Item(3).Caption = "No.Cuenta"
        fg.Cols.Item(4).Caption = "Cód.Tipo Ahorro"
        fg.Cols.Item(5).Caption = "Descripción de Cuenta"
        fg.Cols.Item(6).Caption = "No. Cuenta Anterior"
        fg.Cols.Item(7).Caption = "Monto Apertura"
        fg.Cols.Item(7).Format = "##0.00"
        fg.Cols.Item(8).Caption = "Fec. Apertura"
        fg.Cols.Item(9).Caption = "Fec. Ini. Apertura"
        fg.Cols.Item(10).Caption = "Monto"
        fg.Cols.Item(10).Format = "##0.00"
        fg.Cols.Item(11).Caption = "No. Libreta"
        fg.Cols.Item(12).Caption = "Tasa Interés"
        fg.Cols.Item(13).Caption = "Destino"
        fg.Cols.Item(14).Caption = "Titular 2"
        fg.Cols.Item(15).Caption = "No. Documento"
        fg.Cols.Item(16).Caption = "Saldo Cta. Ahorro"
        fg.Cols.Item(16).Format = "##0.00"
        fg.Cols.Item(17).Caption = "Saldo Disp. Cta. Ahorro"
        fg.Cols.Item(17).Format = "##0.00"
        fg.Cols.Item(18).Caption = "Observación"
        fg.Cols.Item(19).Caption = "Ejecutivo"
        fg.Cols.Item(20).Caption = "Cobro Domicilio"
        fg.Cols.Item(21).Caption = "Fecha Cancelación"
        fg.Cols.Item(22).Caption = "Motivo Cancelación"
        fg.Cols.Item(23).Caption = "Ejec.Cancela"
        fg.Cols.Item(24).Caption = "Estado"

        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 200
        fg.Cols.Item(3).Width = 90
        fg.Cols.Item(4).Width = 100
        fg.Cols.Item(5).Width = 150
        fg.Cols.Item(6).Width = 110
        fg.Cols.Item(7).Width = 100
        fg.Cols.Item(8).Width = 77
        fg.Cols.Item(9).Width = 0
        fg.Cols.Item(10).Width = 200
        fg.Cols.Item(11).Width = 77
        fg.Cols.Item(12).Width = 77
        fg.Cols.Item(13).Width = 77
        fg.Cols.Item(14).Width = 77
        fg.Cols.Item(15).Width = 77
        fg.Cols.Item(16).Width = 77
        fg.Cols.Item(17).Width = 77
        fg.Cols.Item(18).Width = 77
        fg.Cols.Item(19).Width = 77
        fg.Cols.Item(20).Width = 77
        fg.Cols.Item(21).Width = 77
        fg.Cols.Item(22).Width = 77
        fg.Cols.Item(23).Width = 77
        fg.Cols.Item(24).Width = 77

    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        btnConsultar1_Click(sender, e)
    End Sub


    Private Sub rbNombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        If Me.rbNombres.Checked = True Then
            Me.cbNombres.Enabled = True
            Me.txtNombres.Enabled = True
        ElseIf Me.rbNombres.Checked = False Then
            Me.cbNombres.Enabled = False
            Me.txtNombres.Enabled = False
        End If
        Me.cbNombres.Focus()
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

    Private Sub rbDui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
        Me.txtDui.Focus()
    End Sub

    Private Sub rbNoSocio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoSocio.CheckedChanged
        Me.txtNoSocio.Focus()
    End Sub

    Private Sub rbNoCuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoCuenta.CheckedChanged
        Me.txtNoCuenta.Focus()
    End Sub


    Private Sub txtNoCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoLibreta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click

        Dim oAh As wrAhorro.wsLibAhorro, oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow, pFiltro As String
        Try
            oAh = New wrAhorro.wsLibAhorro
            oAsoc = New wrAsociados.wsLibAsoc
            If rbDui.Checked = True Then
                ds = oAh.ConsultarCuentaAhorro("V", "a.Dui='" & Trim(Me.txtDui.Text) & "' and (Left(a.CodTipoAhorro,1)<>'1' and Left(a.CodTipoAhorro,1)<>'6')", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf rbNoCuenta.Checked = True Then
                ds = oAh.ConsultarCuentaAhorro("V", "NoCuenta like '" & Trim(Me.txtNoCuenta.Text) & "%' and (Left(a.CodTipoAhorro,1)<>'1' and Left(a.CodTipoAhorro,1)<>'6')", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbNoSocio.Checked = True Then
                ds = oAh.ConsultarCuentaAhorro("V", "a.NoSocio='" & Me.txtNoSocio.Text & "' and (Left(a.CodTipoAhorro,1)<>'1' and Left(a.CodTipoAhorro,1)<>'6')", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbNombres.Checked = True Then
                If cbNombres.SelectedIndex = 0 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido1 like '" & Trim(txtNombres.Text) & "%'", "Apellido1,Apellido2", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 1 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido2 like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 2 Then
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
                    fg.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                    Exit Sub
                Else
                    If ds.Tables(0).Rows.Count > 0 Then
                        ds = oAh.ConsultarCuentaAhorro("V", "(" & pFiltro & ") and (Left(a.CodTipoAhorro,1)<>'1' and Left(a.CodTipoAhorro,1)<>'6')", "a.Dui", sUsuario, sPassword, sSucursal)
                    End If
                End If
            End If
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MessageBox.Show("Error. Por favor comunicarse con el administrador de sistema.", "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsAhCuentas = New frmMsAhCuentas
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            btnMostrar1_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Error. Por favor comunicarse con el administrador de sistema.", "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If fg.Row <> -1 Then

                Dim frm As frmMsAhCuentas = New frmMsAhCuentas
                frm.pAccion = "Modificar"

                frm.btnSaveTb3.Text = "&Modificar"
                frm.pCodTipoAhorro = fg.Item(fg.Row, "CodTipoAhorro")
                frm.pNoCuenta = fg.Item(fg.Row, "NoCuenta")
                frm.btNewBen.Enabled = True
                frm.btEditBen.Enabled = True
                frm.btDelBen.Enabled = True

                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                btnMostrar1_Click(sender, e)

            End If
        Catch ex As Exception
            MessageBox.Show("Error. Por favor comunicarse con el administrador de sistema.", "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If fg.Row <> -1 Then

                Dim frm As frmMsAhCuentas = New frmMsAhCuentas
                frm.pAccion = "Modificar"
                frm.btnSaveTb3.Text = "&Modificar"
                frm.pNoCuenta = fg.Item(fg.Row, "NoCuenta")
                frm.pCodTipoAhorro = fg.Item(fg.Row, "CodTipoAhorro")

                frm.btnSaveTb3.Enabled = False
                frm.btnSaveTb3.Visible = False


                frm.btNewBen.Enabled = False
                frm.btDelBen.Enabled = False


                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                btnMostrar1_Click(sender, e)

            End If
        Catch ex As Exception
            MessageBox.Show("Error. Por favor comunicarse con el administrador de sistema.", "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fg_Click(sender As Object, e As EventArgs) Handles fg.Click
        Try
            If fg.Row <> -1 Then
                Select Case fg.Item(fg.Row, "Estado")
                    Case "A"
                        lblEstado.Text = "ACTIVO"
                    Case "B"
                        lblEstado.Text = "BLOQUEADO"
                    Case "C"
                        lblEstado.Text = "CANCELADO"
                    Case "D"
                        lblEstado.Text = "DIGITADO"

                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class