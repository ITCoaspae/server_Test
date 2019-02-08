Public Class frmMAhCuentasAhorroDPF
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) '' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents rbNoCuenta As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoLibreta As System.Windows.Forms.RadioButton
    Friend WithEvents txtNoLibreta As System.Windows.Forms.TextBox
    Friend WithEvents rbTipoAhorro As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents rbEstado As System.Windows.Forms.RadioButton
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelarCuenta1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMAhCuentasAhorroDPF))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.rbEstado = New System.Windows.Forms.RadioButton()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.rbTipoAhorro = New System.Windows.Forms.RadioButton()
        Me.txtNoLibreta = New System.Windows.Forms.TextBox()
        Me.rbNoLibreta = New System.Windows.Forms.RadioButton()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.rbNoCuenta = New System.Windows.Forms.RadioButton()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnCancelarCuenta1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.fg.Location = New System.Drawing.Point(28, 292)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(824, 217)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.txtNoSocio)
        Me.GroupBox2.Controls.Add(Me.rbNoSocio)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.cbEstado)
        Me.GroupBox2.Controls.Add(Me.rbEstado)
        Me.GroupBox2.Controls.Add(Me.txtCodTipoAhorro)
        Me.GroupBox2.Controls.Add(Me.rbTipoAhorro)
        Me.GroupBox2.Controls.Add(Me.txtNoLibreta)
        Me.GroupBox2.Controls.Add(Me.rbNoLibreta)
        Me.GroupBox2.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox2.Controls.Add(Me.rbNoCuenta)
        Me.GroupBox2.Controls.Add(Me.rbDui)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(796, 174)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar Cuentas de Ahorro por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(398, 120)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 32)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnMostrar1.TabIndex = 176
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(588, 63)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(182, 22)
        Me.txtNombres.TabIndex = 6
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(398, 28)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(183, 27)
        Me.rbNombres.TabIndex = 4
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Enabled = False
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(398, 62)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(183, 24)
        Me.cbNombres.TabIndex = 5
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(209, 65)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(182, 22)
        Me.txtNoSocio.TabIndex = 3
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.Location = New System.Drawing.Point(209, 28)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(182, 27)
        Me.rbNoSocio.TabIndex = 2
        Me.rbNoSocio.Text = "&No. Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(19, 65)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(183, 23)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Items.AddRange(New Object() {"A - Activa", "C - Cerrada / Cancelada", "I - Inactiva", "B - Bloqueada", "D - Digitada"})
        Me.cbEstado.Location = New System.Drawing.Point(576, 128)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(62, 24)
        Me.cbEstado.TabIndex = 11
        Me.cbEstado.Visible = False
        '
        'rbEstado
        '
        Me.rbEstado.BackColor = System.Drawing.Color.Teal
        Me.rbEstado.Location = New System.Drawing.Point(576, 93)
        Me.rbEstado.Name = "rbEstado"
        Me.rbEstado.Size = New System.Drawing.Size(62, 28)
        Me.rbEstado.TabIndex = 10
        Me.rbEstado.Text = "&Estado"
        Me.rbEstado.UseVisualStyleBackColor = False
        Me.rbEstado.Visible = False
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(646, 129)
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(124, 22)
        Me.txtCodTipoAhorro.TabIndex = 9
        Me.txtCodTipoAhorro.Visible = False
        '
        'rbTipoAhorro
        '
        Me.rbTipoAhorro.BackColor = System.Drawing.Color.Teal
        Me.rbTipoAhorro.Checked = True
        Me.rbTipoAhorro.Location = New System.Drawing.Point(646, 95)
        Me.rbTipoAhorro.Name = "rbTipoAhorro"
        Me.rbTipoAhorro.Size = New System.Drawing.Size(124, 27)
        Me.rbTipoAhorro.TabIndex = 8
        Me.rbTipoAhorro.TabStop = True
        Me.rbTipoAhorro.Text = "T&ipo de Ahorro"
        Me.rbTipoAhorro.UseVisualStyleBackColor = False
        Me.rbTipoAhorro.Visible = False
        '
        'txtNoLibreta
        '
        Me.txtNoLibreta.Location = New System.Drawing.Point(209, 129)
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.Size = New System.Drawing.Size(182, 22)
        Me.txtNoLibreta.TabIndex = 10
        '
        'rbNoLibreta
        '
        Me.rbNoLibreta.BackColor = System.Drawing.Color.White
        Me.rbNoLibreta.Location = New System.Drawing.Point(209, 95)
        Me.rbNoLibreta.Name = "rbNoLibreta"
        Me.rbNoLibreta.Size = New System.Drawing.Size(182, 27)
        Me.rbNoLibreta.TabIndex = 9
        Me.rbNoLibreta.Text = "No. &Libreta"
        Me.rbNoLibreta.UseVisualStyleBackColor = False
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.Location = New System.Drawing.Point(19, 129)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(183, 22)
        Me.txtNoCuenta.TabIndex = 8
        '
        'rbNoCuenta
        '
        Me.rbNoCuenta.BackColor = System.Drawing.Color.White
        Me.rbNoCuenta.Location = New System.Drawing.Point(19, 95)
        Me.rbNoCuenta.Name = "rbNoCuenta"
        Me.rbNoCuenta.Size = New System.Drawing.Size(183, 27)
        Me.rbNoCuenta.TabIndex = 7
        Me.rbNoCuenta.Text = "No. &Cuenta"
        Me.rbNoCuenta.UseVisualStyleBackColor = False
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Location = New System.Drawing.Point(19, 28)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(183, 27)
        Me.rbDui.TabIndex = 0
        Me.rbDui.Text = "&DUI de Asociado"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'lblEstado
        '
        Me.lblEstado.BackColor = System.Drawing.Color.White
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Red
        Me.lblEstado.Location = New System.Drawing.Point(474, 267)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(192, 18)
        Me.lblEstado.TabIndex = 17
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelarCuenta1
        '
        Me.btnCancelarCuenta1.Location = New System.Drawing.Point(319, 253)
        Me.btnCancelarCuenta1.Name = "btnCancelarCuenta1"
        Me.btnCancelarCuenta1.Size = New System.Drawing.Size(147, 32)
        Me.btnCancelarCuenta1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnCancelarCuenta1.TabIndex = 175
        Me.btnCancelarCuenta1.Text = "Cancelar Cuenta"
        Me.btnCancelarCuenta1.UseSelectable = True
        Me.btnCancelarCuenta1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(222, 253)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnConsultar1.TabIndex = 174
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 253)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnModificar1.TabIndex = 173
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 253)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnAgregar1.TabIndex = 172
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMAhCuentasAhorroDPF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(880, 600)
        Me.Controls.Add(Me.btnCancelarCuenta1)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMAhCuentasAhorroDPF"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Mantenimiento - Cuentas de Depósito a Plazo Fijo"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private vDPF As String

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
        fg.Cols.Item(9).Caption = "No. Certificado"
        fg.Cols.Item(10).Caption = "Monto"
        fg.Cols.Item(10).Format = "##0.00"
        fg.Cols.Item(11).Caption = "Saldo Cta. Ahorro"
        fg.Cols.Item(11).Format = "##0.00"
        fg.Cols.Item(12).Caption = "Fec. Ini. Apertura"
        fg.Cols.Item(13).Caption = "Fecha Vencimiento"
        fg.Cols.Item(14).Caption = "Tasa Interés"
        fg.Cols.Item(15).Caption = "Interés Pagado"
        fg.Cols.Item(16).Caption = "Plazo"
        fg.Cols.Item(17).Caption = "Saldo Interes Pendiente"
        fg.Cols.Item(17).Format = "##0.00"
        fg.Cols.Item(18).Caption = "Cta. Ahorro"
        fg.Cols.Item(19).Caption = "Titular 2"
        fg.Cols.Item(20).Caption = "No. Documento"
        fg.Cols.Item(21).Caption = "Pignorado"
        fg.Cols.Item(22).Caption = "Monto Pignorado"
        fg.Cols.Item(22).Format = "##0.00"
        fg.Cols.Item(23).Caption = "Porcentaje Pignora"
        fg.Cols.Item(23).Format = "##0.00"
        fg.Cols.Item(24).Caption = "Observación"
        fg.Cols.Item(25).Caption = "Ejecutivo"
        fg.Cols.Item(26).Caption = "Fec. Cancelación"
        fg.Cols.Item(27).Caption = "Motivo Cancelación"
        fg.Cols.Item(28).Caption = "Ejecutivo Canc."
        fg.Cols.Item(29).Caption = "Prorrogado"
        fg.Cols.Item(30).Caption = "Estado"

        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 200
        fg.Cols.Item(3).Width = 90
        fg.Cols.Item(4).Width = 100
        fg.Cols.Item(5).Width = 150
        fg.Cols.Item(6).Width = 110
        fg.Cols.Item(7).Width = 100
        fg.Cols.Item(8).Width = 77
        fg.Cols.Item(9).Width = 100
        fg.Cols.Item(10).Width = 100
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
        fg.Cols.Item(25).Width = 77
        fg.Cols.Item(26).Width = 77
        fg.Cols.Item(27).Width = 77
        fg.Cols.Item(28).Width = 77
        fg.Cols.Item(29).Width = 77
        fg.Cols.Item(30).Width = 77

    End Sub


    Private Sub frmMCuentasAhorro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        vDPF = "6"
        Me.cbEstado.SelectedIndex = 0
        btnMostrar1_Click(sender, e)


    End Sub





    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        btnConsultar1_Click(sender, e)
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

    Private Sub rbNoLibreta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoLibreta.CheckedChanged
        Me.txtNoLibreta.Focus()
    End Sub

    Private Sub rbTipoAhorro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTipoAhorro.CheckedChanged
        Me.txtCodTipoAhorro.Focus()
    End Sub

    Private Sub rbEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEstado.CheckedChanged
        Me.cbEstado.Focus()
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

    Private Sub txtCodTipoAhorro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoAhorro.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoLibreta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoLibreta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub fg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.Click
        Try
            Select Case CStr(fg.Item(fg.Row, "Estado")).Trim
                Case "D" 'Digitada
                    Me.lblEstado.Text = "DIGITADA"
                Case "A" 'A: Activa
                    Me.lblEstado.Text = "ACTIVA"
                Case "C" 'C: Cancelada
                    Me.lblEstado.Text = "CANCELADA"
                Case "I" 'Inactiva
                    Me.lblEstado.Text = "INACTIVA"
                Case "B" 'Bloqueada
                    Me.lblEstado.Text = "BLOQUEADA"
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub fg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fg.KeyPress
        Try
            Select Case CStr(fg.Item(fg.Row, "Estado")).Trim
                Case "D" 'Digitada
                    Me.lblEstado.Text = "DIGITADA"
                Case "A" 'A: Activa
                    Me.lblEstado.Text = "ACTIVA"
                Case "C" 'C: Cancelada
                    Me.lblEstado.Text = "CANCELADA"
                Case "I" 'Inactiva
                    Me.lblEstado.Text = "INACTIVA"
                Case "B" 'Bloqueada
                    Me.lblEstado.Text = "BLOQUEADA"
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsAhCuentasDPF = New frmMsAhCuentasDPF
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            btnMostrar1_Click(sender, e)
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If fg.Row <> -1 Then

                Dim frm As frmMsAhCuentasDPF = New frmMsAhCuentasDPF
                frm.pAccion = "Modificar"
                frm.vConsulta = False
                frm.btnSaveTb1.Text = "&Modificar"
                frm.btnSaveTb4.Enabled = True
                frm.gbPig.Enabled = True
                frm.btnNew.Enabled = True
                frm.btDelBen.Enabled = True
                frm.pCodTipoAhorro = fg.Item(fg.Row, "CodTipoAhorro")
                frm.pNoCuenta = fg.Item(fg.Row, "NoCuenta")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                btnMostrar1_Click(sender, e)

            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If fg.Row <> -1 Then

                Dim frm As frmMsAhCuentasDPF = New frmMsAhCuentasDPF
                frm.pAccion = "Modificar"
                frm.vConsulta = True
                frm.btnSaveTb1.Text = "&Modificar"
                frm.pNoCuenta = fg.Item(fg.Row, "NoCuenta")
                frm.pCodTipoAhorro = fg.Item(fg.Row, "CodTipoAhorro")
                frm.btnSaveTb4.Visible = False
                frm.btnSaveTb1.Visible = False
                frm.btnSaveTb3.Visible = False
                frm.btDelBen.Enabled = False
                frm.btnNew.Enabled = False
                frm.gbPig.Enabled = True
                frm.cbAutorizacion.Enabled = False
                frm.btTasaPactada.Enabled = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                btnMostrar1_Click(sender, e)

            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancelarCuenta1_Click(sender As Object, e As EventArgs) Handles btnCancelarCuenta1.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As frmMsAhCuentasDPF = New frmMsAhCuentasDPF
                frm.pAccion = "Modificar"
                frm.btnSaveTb1.Text = "&Cancelar Cta."
                frm.btnSaveTb3.Text = "&Cancelar Cta."
                frm.pNoCuenta = fg.Item(fg.Row, "NoCuenta")
                frm.pCodTipoAhorro = fg.Item(fg.Row, "CodTipoAhorro")
                'frm.btnAtrasTb3.Left = 304
                frm.btnSaveTb3.Width = 120
                frm.btnSaveTb3.Left = 480
                frm.tbSolic.TabPages.Item(0).Enabled = False
                frm.tbSolic.TabPages.Item(1).Enabled = False
                frm.tbSolic.TabPages.Item(2).Enabled = False
                frm.btnSaveTb1.Enabled = False
                frm.btnSaveTb1.Visible = False
                frm.btnSaveTb3.Enabled = True
                frm.btnSaveTb4.Enabled = False
                frm.btnSaveTb4.Visible = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.tbSolic.SelectedIndex = 3
                frm.txtMotivoCancela.Focus()
                frm.gbCancela.Enabled = True
                frm.ShowDialog()
                btnMostrar1_Click(sender, e)

            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click

        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet
        Dim oAsoc As New wrAsociados.wsLibAsoc, pFiltro As String, dr As DataRow
        Try
            oAh = New wrAhorro.wsLibAhorro
            If rbNoLibreta.Checked = True Then
                ds = oAh.ConsultarCuentaAhorro("D", "a.NoLibreta='" & Me.txtNoLibreta.Text.Trim & "' and Left(a.CodTipoAhorro,1)='" & vDPF & "'", "a.NoLibreta", sUsuario, sPassword, sSucursal)
            ElseIf rbDui.Checked = True Then
                ds = oAh.ConsultarCuentaAhorro("D", "a.Dui='" & Trim(Me.txtDui.Text) & "' and Left(a.CodTipoAhorro,1)='" & vDPF & "'", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf rbNoCuenta.Checked = True Then
                ds = oAh.ConsultarCuentaAhorro("D", "a.NoCuenta like '" & Trim(Me.txtNoCuenta.Text) & "%' and Left(a.CodTipoAhorro,1)='" & vDPF & "'", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf rbTipoAhorro.Checked = True Then
                ds = oAh.ConsultarCuentaAhorro("D", "a.CodTipoAhorro='" & Trim(Me.txtCodTipoAhorro.Text) & "' and Left(a.CodTipoAhorro,1)='" & vDPF & "'", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf rbNombres.Checked = True Then
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
                    fg.Clear(C1.Win.C1FlexGrid.ClearFlags.All)
                    Exit Sub
                Else
                    If ds.Tables(0).Rows.Count > 0 Then
                        ds = oAh.ConsultarCuentaAhorro("D", "(" & pFiltro & ") and (Left(a.CodTipoAhorro,1)='" & vDPF & "')", "a.Dui", sUsuario, sPassword, sSucursal)
                    End If
                End If
            ElseIf rbEstado.Checked = True Then
                ds = oAh.ConsultarCuentaAhorro("D", "a.Estado='" & Mid(Trim(Me.cbEstado.Text), 1, 1) & "' and Left(a.CodTipoAhorro,1)='" & vDPF & "'", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf rbNoSocio.Checked = True Then
                ds = oAh.ConsultarCuentaAhorro("D", "a.NoSocio='" & Me.txtNoSocio.Text.Trim & "' and Left(a.CodTipoAhorro,1)='" & vDPF & "'", "a.Dui", sUsuario, sPassword, sSucursal)
            End If
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class