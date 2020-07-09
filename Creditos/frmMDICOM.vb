Public Class frmMDICOM
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoSolicitudAl As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNoSolicitud As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents rbNoSolic As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNIT As C1.Win.C1Input.C1TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoDICOM As System.Windows.Forms.TextBox
    Friend WithEvents rbtNoDICOM As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNIT As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDICOM))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoSolicitudAl = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNIT = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSolicitud = New C1.Win.C1Input.C1NumericEdit()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.rbtFecha = New System.Windows.Forms.RadioButton()
        Me.txtNoDICOM = New System.Windows.Forms.TextBox()
        Me.rbtNoDICOM = New System.Windows.Forms.RadioButton()
        Me.rbtNIT = New System.Windows.Forms.RadioButton()
        Me.rbNoSolic = New System.Windows.Forms.RadioButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSolicitudAl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.rbDui)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNoSolicitudAl)
        Me.GroupBox2.Controls.Add(Me.txtNIT)
        Me.GroupBox2.Controls.Add(Me.txtNoSolicitud)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.rbtFecha)
        Me.GroupBox2.Controls.Add(Me.txtNoDICOM)
        Me.GroupBox2.Controls.Add(Me.rbtNoDICOM)
        Me.GroupBox2.Controls.Add(Me.rbtNIT)
        Me.GroupBox2.Controls.Add(Me.rbNoSolic)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(609, 138)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar registros por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(494, 92)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 33)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 229
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(274, 98)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(134, 23)
        Me.txtDui.TabIndex = 10
        Me.txtDui.Tag = Nothing
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.ForeColor = System.Drawing.Color.Black
        Me.rbDui.Location = New System.Drawing.Point(208, 93)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(58, 28)
        Me.rbDui.TabIndex = 9
        Me.rbDui.Text = "Dui:"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(395, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Al"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(197, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Del"
        '
        'txtNoSolicitudAl
        '
        Me.txtNoSolicitudAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSolicitudAl.CustomFormat = "######"
        Me.txtNoSolicitudAl.DataType = GetType(Integer)
        Me.txtNoSolicitudAl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSolicitudAl.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSolicitudAl.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtNoSolicitudAl.Location = New System.Drawing.Point(431, 31)
        Me.txtNoSolicitudAl.Name = "txtNoSolicitudAl"
        Me.txtNoSolicitudAl.Size = New System.Drawing.Size(153, 27)
        Me.txtNoSolicitudAl.TabIndex = 2
        Me.txtNoSolicitudAl.Tag = Nothing
        Me.txtNoSolicitudAl.Value = 0
        Me.txtNoSolicitudAl.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtNIT
        '
        Me.txtNIT.EditMask = "0000-000000-000-0"
        Me.txtNIT.Location = New System.Drawing.Point(76, 59)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.NumericInput = False
        Me.txtNIT.Size = New System.Drawing.Size(182, 23)
        Me.txtNIT.TabIndex = 4
        Me.txtNIT.Tag = Nothing
        '
        'txtNoSolicitud
        '
        Me.txtNoSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSolicitud.CustomFormat = "######"
        Me.txtNoSolicitud.DataType = GetType(Integer)
        Me.txtNoSolicitud.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSolicitud.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSolicitud.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtNoSolicitud.Location = New System.Drawing.Point(233, 31)
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.Size = New System.Drawing.Size(153, 27)
        Me.txtNoSolicitud.TabIndex = 1
        Me.txtNoSolicitud.Tag = Nothing
        Me.txtNoSolicitud.Value = 0
        Me.txtNoSolicitud.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(85, 98)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(115, 22)
        Me.dtpFecha.TabIndex = 8
        '
        'rbtFecha
        '
        Me.rbtFecha.BackColor = System.Drawing.Color.White
        Me.rbtFecha.ForeColor = System.Drawing.Color.Black
        Me.rbtFecha.Location = New System.Drawing.Point(7, 93)
        Me.rbtFecha.Name = "rbtFecha"
        Me.rbtFecha.Size = New System.Drawing.Size(71, 28)
        Me.rbtFecha.TabIndex = 7
        Me.rbtFecha.Text = "Fecha"
        Me.rbtFecha.UseVisualStyleBackColor = False
        '
        'txtNoDICOM
        '
        Me.txtNoDICOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoDICOM.Location = New System.Drawing.Point(402, 62)
        Me.txtNoDICOM.Name = "txtNoDICOM"
        Me.txtNoDICOM.Size = New System.Drawing.Size(182, 22)
        Me.txtNoDICOM.TabIndex = 6
        '
        'rbtNoDICOM
        '
        Me.rbtNoDICOM.BackColor = System.Drawing.Color.White
        Me.rbtNoDICOM.ForeColor = System.Drawing.Color.Black
        Me.rbtNoDICOM.Location = New System.Drawing.Point(265, 59)
        Me.rbtNoDICOM.Name = "rbtNoDICOM"
        Me.rbtNoDICOM.Size = New System.Drawing.Size(125, 28)
        Me.rbtNoDICOM.TabIndex = 5
        Me.rbtNoDICOM.Text = "Número DICOM"
        Me.rbtNoDICOM.UseVisualStyleBackColor = False
        '
        'rbtNIT
        '
        Me.rbtNIT.BackColor = System.Drawing.Color.White
        Me.rbtNIT.ForeColor = System.Drawing.Color.Black
        Me.rbtNIT.Location = New System.Drawing.Point(7, 59)
        Me.rbtNIT.Name = "rbtNIT"
        Me.rbtNIT.Size = New System.Drawing.Size(61, 28)
        Me.rbtNIT.TabIndex = 3
        Me.rbtNIT.Text = "&NIT"
        Me.rbtNIT.UseVisualStyleBackColor = False
        '
        'rbNoSolic
        '
        Me.rbNoSolic.BackColor = System.Drawing.Color.White
        Me.rbNoSolic.Checked = True
        Me.rbNoSolic.ForeColor = System.Drawing.Color.Black
        Me.rbNoSolic.Location = New System.Drawing.Point(7, 24)
        Me.rbNoSolic.Name = "rbNoSolic"
        Me.rbNoSolic.Size = New System.Drawing.Size(183, 28)
        Me.rbNoSolic.TabIndex = 0
        Me.rbNoSolic.TabStop = True
        Me.rbNoSolic.Text = "&Número de Solicitud"
        Me.rbNoSolic.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.ForeColor = System.Drawing.Color.Navy
        Me.fg.Location = New System.Drawing.Point(28, 257)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(625, 191)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 18
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(319, 218)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 232
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(222, 218)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 231
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 218)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 230
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 218)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 228
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMDICOM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(680, 499)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMDICOM"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento DICOM"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSolicitudAl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ActualizaGrid()
        Dim oCred As wrCredito.wsLibCred
        Dim ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarDICOM("*", "", "CorrelativoDicom", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Me.rbNoSolic.Checked = True
            Encabezado()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Encabezado()
        fg.Cols.Item(1).Caption = "Correlativo Dicom"
        fg.Cols.Item(2).Caption = "Número Solicitud"
        fg.Cols.Item(3).Caption = "Fecha"
        fg.Cols.Item(4).Caption = "Hora"
        fg.Cols.Item(5).Caption = "Número Dicom"
        fg.Cols.Item(6).Caption = "Solicitante"
        fg.Cols.Item(7).Caption = "Fiador"
        fg.Cols.Item(8).Caption = "Nombre"
        fg.Cols.Item(9).Caption = "Dui"
        fg.Cols.Item(10).Caption = "NIT"
        fg.Cols.Item(11).Caption = "Observaciones"
        fg.Cols.Item(12).Caption = "Mora Banca"
        fg.Cols.Item(13).Caption = "Mora Actual"
        fg.Cols.Item(14).Caption = "Mora Histórica"
        fg.Cols.Item(15).Caption = "Banco"
        fg.Cols.Item(16).Caption = "Tarjeta Crédito"
        fg.Cols.Item(17).Caption = "Comercial"
        fg.Cols.Item(18).Caption = "Cód. Enlace"

        fg.Cols.Item(0).Width = 20
        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 100
        fg.Cols.Item(5).Width = 100
        fg.Cols.Item(6).Width = 75
        fg.Cols.Item(7).Width = 200
        fg.Cols.Item(8).Width = 100
        fg.Cols.Item(9).Width = 250
        fg.Cols.Item(10).Width = 75
        fg.Cols.Item(11).Width = 200
    End Sub





    Private Sub frmMDICOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
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

    Private Sub rbNoSolic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoSolic.CheckedChanged
        Me.txtNoSolicitud.Focus()
    End Sub

    Private Sub rbtNIT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNIT.CheckedChanged
        Me.txtNIT.Focus()
    End Sub

    Private Sub rbtNoDICOM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNoDICOM.CheckedChanged
        Me.txtNoDICOM.Focus()
    End Sub

    Private Sub rbtFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFecha.CheckedChanged
        Me.dtpFecha.Focus()
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNIT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNIT.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoDICOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoDICOM.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoSolicitud_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSolicitud.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoSolicitudAl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSolicitudAl.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub dtpFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyData = Keys.Return Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred
            Dim ds As New Data.DataSet
            'Dim dr As DataRow

            oCred = New wrCredito.wsLibCred
            If rbNoSolic.Checked = True Then
                If Me.txtNoSolicitudAl.Text.Trim = "" Then
                    ds = oCred.ConsultarDICOM("*", "NumSolicitud=" & Me.txtNoSolicitud.Value & "", "", sUsuario, sPassword, sSucursal)
                Else
                    ds = oCred.ConsultarDICOM("*", "NumSolicitud>='" & Me.txtNoSolicitud.Value & "' and NumSolicitud<='" & Me.txtNoSolicitudAl.Value & "'", "", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbtNIT.Checked = True Then
                ds = oCred.ConsultarDICOM("*", "NIT='" & Trim(txtNIT.Value) & "'", "", sUsuario, sPassword, sSucursal)
            ElseIf rbtNoDICOM.Checked = True Then
                ds = oCred.ConsultarDICOM("*", "NumDicom=" & Me.txtNoDICOM.Text & "", "", sUsuario, sPassword, sSucursal)
            ElseIf rbtFecha.Checked = True Then
                ds = oCred.ConsultarDICOM("*", "Fecha='" & Format(dtpFecha.Value, "dd/MM/yyyy") & "'", "", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbDui.Checked = True Then
                ds = oCred.ConsultarDICOM("*", "Dui='" & Me.txtDui.Value & "'", "", sUsuario, sPassword, sSucursal)
            End If
            If ds.Tables.Count > 0 Then
                fg.DataSource = ds.Tables(0)
                Encabezado()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As New frmMsFiltroDicom
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.pAccion = "Guardar"
            frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            Dim frm As New frmMsFiltroDicom
            frm.pAccion = "Modificar"
            frm.txtNoSolicitud.Value = fg.Item(fg.Row, "NumSolicitud")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As New frmMsDICOM
                Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                Dim dr As Data.DataRow
                Dim ds As New Data.DataSet

                ds = oCred.ConsultarDICOM("*", "CorrelativoDicom='" & fg.Item(fg.Row, "CorrelativoDicom") & "'", "", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    oCred.EliminarDICOM(CInt(dr("CorrelativoDicom")), sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            Dim frm As New frmMsFiltroDicom
            frm.pAccion = "Modificar"
            frm.btNuevo1.Enabled = False
            frm.btEliminar1.Enabled = False
            frm.btModificar1.Text = "&Consultar"
            frm.txtNoSolicitud.Value = fg.Item(fg.Row, "NumSolicitud")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class