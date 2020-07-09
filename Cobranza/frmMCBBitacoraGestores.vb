Public Class frmMCBBitacoraGestores
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigoPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodigoPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbFechas As System.Windows.Forms.RadioButton
    Friend WithEvents rbDUI As System.Windows.Forms.RadioButton
    Friend WithEvents txtDUI As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCargar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar As MetroFramework.Controls.MetroButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCBBitacoraGestores))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar = New MetroFramework.Controls.MetroButton()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.txtDUI = New C1.Win.C1Input.C1TextBox()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbFechas = New System.Windows.Forms.RadioButton()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.txtCodigoPrestamo = New System.Windows.Forms.TextBox()
        Me.rbCodigoPrestamo = New System.Windows.Forms.RadioButton()
        Me.rbDUI = New System.Windows.Forms.RadioButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCargar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDUI, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.fg.Location = New System.Drawing.Point(28, 290)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(1140, 198)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 52
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnMostrar)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.txtDUI)
        Me.GroupBox2.Controls.Add(Me.dtpFin)
        Me.GroupBox2.Controls.Add(Me.dtpInicio)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.rbFechas)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.txtCodigoPrestamo)
        Me.GroupBox2.Controls.Add(Me.rbCodigoPrestamo)
        Me.GroupBox2.Controls.Add(Me.rbDUI)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1140, 170)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar registros por:"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(540, 125)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(108, 32)
        Me.btnMostrar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar.TabIndex = 184
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar.UseSelectable = True
        Me.btnMostrar.UseStyleColors = True
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(209, 129)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(324, 22)
        Me.txtNombres.TabIndex = 15
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(19, 95)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(183, 27)
        Me.rbNombres.TabIndex = 13
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Enabled = False
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(19, 129)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(183, 24)
        Me.cbNombres.TabIndex = 14
        '
        'txtDUI
        '
        Me.txtDUI.EditMask = "00000000-0"
        Me.txtDUI.Location = New System.Drawing.Point(19, 65)
        Me.txtDUI.Name = "txtDUI"
        Me.txtDUI.Size = New System.Drawing.Size(183, 23)
        Me.txtDUI.TabIndex = 12
        Me.txtDUI.Tag = Nothing
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(398, 65)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(183, 22)
        Me.dtpFin.TabIndex = 11
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(209, 65)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(182, 22)
        Me.dtpInicio.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(398, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fin:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(295, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Inicio:"
        '
        'rbFechas
        '
        Me.rbFechas.BackColor = System.Drawing.Color.White
        Me.rbFechas.Location = New System.Drawing.Point(209, 28)
        Me.rbFechas.Name = "rbFechas"
        Me.rbFechas.Size = New System.Drawing.Size(182, 27)
        Me.rbFechas.TabIndex = 2
        Me.rbFechas.Text = "&Fechas:"
        Me.rbFechas.UseVisualStyleBackColor = False
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(398, 95)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(183, 27)
        Me.rbTodos.TabIndex = 6
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'txtCodigoPrestamo
        '
        Me.txtCodigoPrestamo.Location = New System.Drawing.Point(588, 65)
        Me.txtCodigoPrestamo.Name = "txtCodigoPrestamo"
        Me.txtCodigoPrestamo.Size = New System.Drawing.Size(182, 22)
        Me.txtCodigoPrestamo.TabIndex = 5
        '
        'rbCodigoPrestamo
        '
        Me.rbCodigoPrestamo.BackColor = System.Drawing.Color.White
        Me.rbCodigoPrestamo.Location = New System.Drawing.Point(580, 30)
        Me.rbCodigoPrestamo.Name = "rbCodigoPrestamo"
        Me.rbCodigoPrestamo.Size = New System.Drawing.Size(182, 28)
        Me.rbCodigoPrestamo.TabIndex = 4
        Me.rbCodigoPrestamo.Text = "Código del &Préstamo"
        Me.rbCodigoPrestamo.UseVisualStyleBackColor = False
        '
        'rbDUI
        '
        Me.rbDUI.BackColor = System.Drawing.Color.White
        Me.rbDUI.Location = New System.Drawing.Point(19, 28)
        Me.rbDUI.Name = "rbDUI"
        Me.rbDUI.Size = New System.Drawing.Size(183, 27)
        Me.rbDUI.TabIndex = 0
        Me.rbDUI.Text = "&DUI:"
        Me.rbDUI.UseVisualStyleBackColor = False
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 250)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(135, 33)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 182
        Me.btnAgregar1.Text = "Agregar Gestión"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnCargar1
        '
        Me.btnCargar1.Location = New System.Drawing.Point(170, 250)
        Me.btnCargar1.Name = "btnCargar1"
        Me.btnCargar1.Size = New System.Drawing.Size(136, 33)
        Me.btnCargar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCargar1.TabIndex = 183
        Me.btnCargar1.Text = "Cargar Datos"
        Me.btnCargar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCargar1.UseSelectable = True
        Me.btnCargar1.UseStyleColors = True
        '
        'frmMCBBitacoraGestores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1195, 556)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.btnCargar1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMCBBitacoraGestores"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Administración de Gestión del Crédito"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDUI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Encabezado()

        'fg.Cols.Item(1).Caption = "Cód. Gestor"
        'fg.Cols.Item(2).Caption = "Cód. Préstamo"
        'fg.Cols.Item(3).Caption = "Dui"
        'fg.Cols.Item(4).Caption = "Fecha Asignación"

        fg.Cols.Item(0).Width = 50
        fg.Cols.Item(1).Width = 150
        fg.Cols.Item(2).Width = 75
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 200

    End Sub

    Private Sub ActualizaGrid()
        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", "a.Estado='A'", "CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Gestores x Préstamo." & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Encabezado()
    End Sub

    Private Sub frmMCBBitacoraGestores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
        Me.WindowState = FormWindowState.Normal
    End Sub




    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub txtDUI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDUI.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDUI.ValueIsDbNull, "", txtDUI.Value)
            If Valor.Trim = "" Then
                Me.txtDUI.SelectionStart = 0
                Me.txtDUI.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDUI_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDUI.GotFocus
        Try
            Dim Valor As String
            Valor = IIf(txtDUI.ValueIsDbNull, "", txtDUI.Value)
            If Valor.Trim = "" Then
                Me.txtDUI.SelectionStart = 0
                Me.txtDUI.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbDUI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDUI.CheckedChanged
        Me.txtDUI.Focus()
    End Sub

    Private Sub rbFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFechas.CheckedChanged
        Me.dtpInicio.Focus()
    End Sub

    Private Sub rbCodigoPrestamo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodigoPrestamo.CheckedChanged
        Me.txtCodigoPrestamo.Focus()
    End Sub

    Private Sub txtCodigoPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub txtDUI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDUI.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub dtpFin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFin.KeyDown
        If e.KeyData = Keys.Return Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub dtpInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpInicio.KeyDown
        If e.KeyData = Keys.Return Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsCBCredito = New frmMsCBCredito
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCargar1_Click(sender As Object, e As EventArgs) Handles btnCargar1.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As frmMsCBCredxGestor = New frmMsCBCredxGestor
                frm.btnAgregar1.Text = "&Modificar"
                frm.CodGestor = fg.Item(fg.Row, "Cód_Gestor")
                frm.CodPrestamo = fg.Item(fg.Row, "Cód_Préstamo")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet, dr As DataRow, pFiltro As String
            Dim oPres As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
            'Dim Filas As Data.DataRowCollection, pCodigo As String
            Dim oAsoc As New wrAsociados.wsLibAsoc

            oCred = New wrCredito.wsLibCred
            If rbDUI.Checked = True Then
                ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", "a.Dui='" & Me.txtDUI.Text.Trim & "' and a.Estado='A'", "a.CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
                'ds = oPres.ConsultarGestoresxCreditoPRPrestamos("'" & Trim(Me.txtDUI.Text) & "'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf rbFechas.Checked = True Then
                ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", "a.FechaAsignacion >= '" & Me.dtpInicio.Value.ToShortDateString & "' AND a.FechaAsignacion <= '" & Me.dtpFin.Value.ToShortDateString & "' and a.Estado='A'", "a.CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
                'ds = oCred.ConsultarGestoresxCredito("*", "FechaAsignacion >= '" & Me.dtpInicio.Value.ToShortDateString & "' AND FechaAsignacion <= '" & Me.dtpFin.Value.ToShortDateString & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbCodigoPrestamo.Checked = True Then
                ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", "a.CodPrestamo='" & Me.txtCodigoPrestamo.Text.Trim & "' and a.Estado='A'", "a.CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
                'ds = oCred.ConsultarGestoresxCredito("*", "CodPrestamo LIKE '" & Trim(Me.txtCodigoPrestamo.Text) & "%'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbTodos.Checked = True Then
                ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", "a.Estado='A'", "a.CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
                'ds = oCred.ConsultarGestoresxCredito("*", "", "CodPrestamo", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf rbNombres.Checked = True Then
                If cbNombres.SelectedIndex = 0 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido1 LIKE '%" & Trim(txtNombres.Text) & "%'", "Apellido1,Apellido2", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 1 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido2 LIKE '%" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 2 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Nombres LIKE '%" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
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
                    pFiltro = pFiltro & " and a.Estado='A'"
                    If ds.Tables(0).Rows.Count > 0 Then
                        ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", "(" & pFiltro & ")", "a.CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
                        'ds = oCred.ConsultarGestoresxCredito("*", "(" & pFiltro & ")", "CodPrestamo", sUsuario, sPassword, sSucursal)
                        fg.DataSource = ds.Tables(0)
                    End If
                End If
            End If
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class