Public Class frmMMovCaja
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ds As New Data.DataSet
    Dim cc As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Private vTipoMov As Integer

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbtNoCaja As System.Windows.Forms.RadioButton
    Friend WithEvents txtNoCaja As System.Windows.Forms.TextBox
    Friend WithEvents rbtFecha As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMMovCaja))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtNoCaja = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.rbtFecha = New System.Windows.Forms.RadioButton()
        Me.rbtNoCaja = New System.Windows.Forms.RadioButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
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
        Me.fg.Location = New System.Drawing.Point(28, 219)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(662, 122)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtNoCaja)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.rbtFecha)
        Me.GroupBox2.Controls.Add(Me.rbtNoCaja)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(477, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar registros por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(349, 43)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 32)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 59
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtNoCaja
        '
        Me.txtNoCaja.BackColor = System.Drawing.Color.White
        Me.txtNoCaja.Location = New System.Drawing.Point(19, 65)
        Me.txtNoCaja.Name = "txtNoCaja"
        Me.txtNoCaja.Size = New System.Drawing.Size(135, 22)
        Me.txtNoCaja.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(209, 65)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(105, 22)
        Me.dtpFecha.TabIndex = 3
        Me.dtpFecha.Value = New Date(2006, 12, 19, 16, 2, 34, 463)
        '
        'rbtFecha
        '
        Me.rbtFecha.BackColor = System.Drawing.Color.White
        Me.rbtFecha.ForeColor = System.Drawing.Color.Black
        Me.rbtFecha.Location = New System.Drawing.Point(209, 28)
        Me.rbtFecha.Name = "rbtFecha"
        Me.rbtFecha.Size = New System.Drawing.Size(67, 27)
        Me.rbtFecha.TabIndex = 2
        Me.rbtFecha.Text = "&Fecha"
        Me.rbtFecha.UseVisualStyleBackColor = False
        '
        'rbtNoCaja
        '
        Me.rbtNoCaja.BackColor = System.Drawing.Color.White
        Me.rbtNoCaja.Checked = True
        Me.rbtNoCaja.ForeColor = System.Drawing.Color.Black
        Me.rbtNoCaja.Location = New System.Drawing.Point(19, 28)
        Me.rbtNoCaja.Name = "rbtNoCaja"
        Me.rbtNoCaja.Size = New System.Drawing.Size(183, 27)
        Me.rbtNoCaja.TabIndex = 0
        Me.rbtNoCaja.TabStop = True
        Me.rbtNoCaja.Text = "&Número de Caja"
        Me.rbtNoCaja.UseVisualStyleBackColor = False
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(222, 180)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 68
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 180)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 67
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 180)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 66
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'frmMMovCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(717, 396)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMMovCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Transacciones de Caja"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property TipoMov() As Integer
        Get
            Return vTipoMov
        End Get
        Set(ByVal Value As Integer)
            vTipoMov = Value
        End Set
    End Property

    Private Sub CargarDatos()
        Try
            If vTipoMov = 0 Then
                ds = cc.ConsultarMovimientoCaja("*", "TipoMov<>'S' and TipoMov<>'T' and TipoMov<>'C' and TipoMov<>'A'", "CORRELATIVO", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf vTipoMov = 1 Then
                ds = cc.ConsultarMovimientoCaja("*", "TipoMov='S' or TipoMov='T'", "CORRELATIVO", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                Encabezado()
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - créditos")
        End Try
    End Sub

    Private Sub frmMMovCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        CargarDatos()
    End Sub



    Private Sub rbtFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFecha.CheckedChanged
        dtpFecha.Enabled = True
        txtNoCaja.Enabled = False
        Me.dtpFecha.Focus()
    End Sub

    Private Sub rbtNoCaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNoCaja.CheckedChanged
        dtpFecha.Enabled = False
        txtNoCaja.Enabled = True
        Me.txtNoCaja.Focus()
    End Sub



    Private Sub Encabezado()

        fg.Cols.Item(6).Width = 0
        fg.Cols.Item(7).Width = 0
        fg.Cols.Item(8).Width = 0
        fg.Cols.Item(9).Width = 0
        fg.Cols.Item(10).Width = 0
        fg.Cols.Item(11).Width = 0
        fg.Cols.Item(12).Width = 0

    End Sub

    Private Sub txtNoCaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCaja.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub dtpFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyData = Keys.Return Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            If rbtNoCaja.Checked = True Then
                If vTipoMov = 0 Then
                    ds = cc.ConsultarMovimientoCaja("*", "NOCAJA=" & txtNoCaja.Text.ToString.Trim & " and TipoMov<>'S' and TipoMov<>'T' and TipoMov<>'C' and TipoMov<>'A'", "CORRELATIVO", sUsuario, sPassword, sSucursal)
                    fg.DataSource = ds.Tables(0)
                ElseIf vTipoMov = 1 Then
                    ds = cc.ConsultarMovimientoCaja("*", "NOCAJA=" & txtNoCaja.Text.ToString.Trim & " and (TipoMov='S' or TipoMov='T')", "CORRELATIVO", sUsuario, sPassword, sSucursal)
                    fg.DataSource = ds.Tables(0)
                    Encabezado()
                End If
            End If
            If rbtFecha.Checked = True Then
                ds = cc.ConsultarMovimientoCaja("*", "FECHA='" & dtpFecha.Value.ToShortDateString & "'", "CORRELATIVO", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
                If vTipoMov = 1 Then Encabezado()
            End If

        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try

            If Me.vTipoMov = 0 Then
                Dim ofrm As New frmMovCaja
                ofrm.cboTipoMovimiento.SelectedIndex = 0
                ofrm.Origen = "M"
                ofrm.ShowDialog()
            ElseIf Me.vTipoMov = 1 Then
                Dim ofrmAut As New frmMsAutorizacion
                ofrmAut.TipoPermiso = "P"
                ofrmAut.NumPrograma = "CAH004"
                ofrmAut.ShowDialog()
                If ofrmAut.Autoriza = True Then
                    Dim ofrm As New frmMovCaja
                    ofrm.Supervisor = ofrmAut.Usuario
                    ofrm.Password = ofrmAut.Password
                    ofrm.cboTipoMovimiento.SelectedIndex = 0
                    ofrm.Origen = "F"
                    ofrm.Text = "Registro de faltantes y sobrantes de caja"
                    ofrmAut.Autoriza = False
                    ofrm.ShowDialog()
                    ofrmAut.Dispose()
                Else
                    ofrmAut.Dispose()
                End If
            End If
            CargarDatos()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            Dim ofrm As New frmMovCaja, ds As New DataSet, dr As DataRow
            If fg.Row <> -1 Then

                If Me.vTipoMov = 0 Then
                    ds = cc.ConsultarMovimientoCaja("*", "Correlativo=" & CInt(fg.Item(fg.Row, "Correlativo")) & "", "Correlativo", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        ofrm.Origen = "M"
                        ofrm.Correlativo = CInt(fg.Item(fg.Row, "Correlativo"))
                        ofrm.btnGuardar1.Visible = True
                        ofrm.btnGuardar1.Text = "&Modificar"
                        ofrm.txtCaja.Text = dr("NoCaja")
                        ofrm.dtpR1.Value = dr("Fecha")
                        ofrm.txtMonto.Value = dr("Monto")
                        If Me.vTipoMov = 0 Then
                            If dr("TipoMov") = "R" Then
                                ofrm.cboTipoMovimiento.SelectedIndex = 0
                            ElseIf dr("TipoMov") = "F" Then
                                ofrm.cboTipoMovimiento.SelectedIndex = 1
                            End If
                        ElseIf Me.vTipoMov = 1 Then
                            If dr("TipoMov") = "T" Then
                                ofrm.cboTipoMovimiento.SelectedIndex = 0
                            ElseIf dr("TipoMov") = "S" Then
                                ofrm.cboTipoMovimiento.SelectedIndex = 1
                            End If
                        End If
                        ofrm.dtpR1.Value = dr("Fecha")
                        If Not dr("CantidadUno") Is DBNull.Value Then ofrm.c1nUno.Value = dr("CantidadUno")
                        If Not dr("CantidadCinco") Is DBNull.Value Then ofrm.c1nCinco.Value = dr("CantidadCinco")
                        If Not dr("CantidadDiez") Is DBNull.Value Then ofrm.c1nDiez.Value = dr("CantidadDiez")
                        If Not dr("CantidadVeinte") Is DBNull.Value Then ofrm.c1nVeinte.Value = dr("CantidadVeinte")
                        If Not dr("CantidadCincuenta") Is DBNull.Value Then ofrm.c1nCincuenta.Value = dr("CantidadCincuenta")
                        If Not dr("CantidadCien") Is DBNull.Value Then ofrm.c1nCien.Value = dr("CantidadCien")
                        If Not dr("CantidadFraccion") Is DBNull.Value Then ofrm.c1nFraccion.Value = dr("CantidadFraccion")
                        ofrm.c1nTotal.Value = dr("Monto")
                        ofrm.ShowDialog()
                        CargarDatos()
                    End If
                ElseIf Me.vTipoMov = 1 Then
                    Dim ofrmAut As New frmMsAutorizacion
                    ofrmAut.TipoPermiso = "P"
                    ofrmAut.NumPrograma = "CAH005"
                    ofrmAut.ShowDialog()
                    If ofrmAut.Autoriza = True Then
                        ofrm.Supervisor = ofrmAut.Usuario
                        ofrm.Password = ofrmAut.Password
                        ofrm.Origen = "F"
                        ofrm.cboTipoMovimiento.Items.Clear()
                        ofrm.cboTipoMovimiento.Items.Add("Faltante")
                        ofrm.cboTipoMovimiento.Items.Add("Sobrante")
                        ofrm.cboTipoMovimiento.SelectedIndex = 0
                        ofrm.Correlativo = CInt(fg.Item(fg.Row, "Correlativo"))
                        ofrm.Text = "Registro de faltantes y sobrantes de caja"
                        ofrmAut.Autoriza = False
                        ds = cc.ConsultarMovimientoCaja("*", "Correlativo=" & CInt(fg.Item(fg.Row, "Correlativo")) & "", "Correlativo", sUsuario, sPassword, sSucursal)
                        If ds.Tables(0).Rows.Count > 0 Then
                            dr = ds.Tables(0).Rows(0)
                            ofrm.btnGuardar1.Visible = True
                            ofrm.btnGuardar1.Text = "&Modificar"
                            ofrm.txtCaja.Text = dr("NoCaja")
                            ofrm.dtpR1.Value = dr("Fecha")
                            ofrm.txtMonto.Value = dr("Monto")
                            If Me.vTipoMov = 0 Then
                                If dr("TipoMov") = "R" Then
                                    ofrm.cboTipoMovimiento.SelectedIndex = 0
                                ElseIf dr("TipoMov") = "F" Then
                                    ofrm.cboTipoMovimiento.SelectedIndex = 1
                                End If
                            ElseIf Me.vTipoMov = 1 Then
                                If dr("TipoMov") = "T" Then
                                    ofrm.cboTipoMovimiento.SelectedIndex = 0
                                ElseIf dr("TipoMov") = "S" Then
                                    ofrm.cboTipoMovimiento.SelectedIndex = 1
                                End If
                            End If
                            ofrm.dtpR1.Value = dr("Fecha")
                            If Not dr("CantidadUno") Is DBNull.Value Then ofrm.c1nUno.Value = dr("CantidadUno")
                            If Not dr("CantidadCinco") Is DBNull.Value Then ofrm.c1nCinco.Value = dr("CantidadCinco")
                            If Not dr("CantidadDiez") Is DBNull.Value Then ofrm.c1nDiez.Value = dr("CantidadDiez")
                            If Not dr("CantidadVeinte") Is DBNull.Value Then ofrm.c1nVeinte.Value = dr("CantidadVeinte")
                            If Not dr("CantidadCincuenta") Is DBNull.Value Then ofrm.c1nCincuenta.Value = dr("CantidadCincuenta")
                            If Not dr("CantidadCien") Is DBNull.Value Then ofrm.c1nCien.Value = dr("CantidadCien")
                            If Not dr("CantidadFraccion") Is DBNull.Value Then ofrm.c1nFraccion.Value = dr("CantidadFraccion")
                            ofrm.c1nTotal.Value = dr("Monto")
                            ofrm.ShowDialog()
                            CargarDatos()
                        End If
                        ofrmAut.Dispose()
                    Else
                        ofrmAut.Dispose()
                        Exit Sub
                    End If
                End If

            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            Dim ofrm As New frmMovCaja, ds As New DataSet, dr As DataRow
            If fg.Row <> -1 Then
                ds = cc.ConsultarMovimientoCaja("*", "Correlativo=" & CInt(fg.Item(fg.Row, "Correlativo")) & "", "Correlativo", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    If Me.vTipoMov = 0 Then
                        ofrm.Origen = "M"
                    ElseIf Me.vTipoMov = 1 Then
                        ofrm.Origen = "F"
                        ofrm.cboTipoMovimiento.Items.Clear()
                        ofrm.cboTipoMovimiento.Items.Add("Faltante")
                        ofrm.cboTipoMovimiento.Items.Add("Sobrante")
                        ofrm.cboTipoMovimiento.SelectedIndex = 0
                    End If
                    ofrm.btnGuardar1.Visible = False
                    ofrm.txtCaja.Text = dr("NoCaja")
                    ofrm.dtpR1.Value = dr("Fecha")
                    ofrm.txtMonto.Value = dr("Monto")
                    If Me.vTipoMov = 0 Then
                        If dr("TipoMov") = "R" Then
                            ofrm.cboTipoMovimiento.SelectedIndex = 0
                        ElseIf dr("TipoMov") = "F" Then
                            ofrm.cboTipoMovimiento.SelectedIndex = 1
                        End If
                    ElseIf Me.vTipoMov = 1 Then
                        If dr("TipoMov") = "T" Then
                            ofrm.cboTipoMovimiento.SelectedIndex = 0
                        ElseIf dr("TipoMov") = "S" Then
                            ofrm.cboTipoMovimiento.SelectedIndex = 1
                        End If
                    End If
                    ofrm.dtpR1.Value = dr("Fecha")
                    If Not dr("CantidadUno") Is DBNull.Value Then ofrm.c1nUno.Value = dr("CantidadUno")
                    If Not dr("CantidadCinco") Is DBNull.Value Then ofrm.c1nCinco.Value = dr("CantidadCinco")
                    If Not dr("CantidadDiez") Is DBNull.Value Then ofrm.c1nDiez.Value = dr("CantidadDiez")
                    If Not dr("CantidadVeinte") Is DBNull.Value Then ofrm.c1nVeinte.Value = dr("CantidadVeinte")
                    If Not dr("CantidadCincuenta") Is DBNull.Value Then ofrm.c1nCincuenta.Value = dr("CantidadCincuenta")
                    If Not dr("CantidadCien") Is DBNull.Value Then ofrm.c1nCien.Value = dr("CantidadCien")
                    If Not dr("CantidadFraccion") Is DBNull.Value Then ofrm.c1nFraccion.Value = dr("CantidadFraccion")
                    ofrm.c1nTotal.Value = dr("Monto")
                    ofrm.ShowDialog()
                    CargarDatos()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class