Public Class frmMCBGestionCredito
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
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents rbCodigoPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents rbDUI As System.Windows.Forms.RadioButton
    Friend WithEvents txtDUI As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCBGestionCredito))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.txtDUI = New C1.Win.C1Input.C1TextBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.rbCodigoPrestamo = New System.Windows.Forms.RadioButton()
        Me.rbDUI = New System.Windows.Forms.RadioButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(19, 176)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 18
        Me.fg.Size = New System.Drawing.Size(595, 309)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 56
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(287, 83)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(221, 20)
        Me.txtNombres.TabIndex = 9
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(19, 83)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(106, 24)
        Me.rbNombres.TabIndex = 7
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Enabled = False
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(130, 83)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(152, 21)
        Me.cbNombres.TabIndex = 8
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Location = New System.Drawing.Point(357, 56)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(151, 20)
        Me.txtCodPrestamo.TabIndex = 6
        '
        'txtDUI
        '
        Me.txtDUI.EditMask = "00000000-0"
        Me.txtDUI.Location = New System.Drawing.Point(130, 56)
        Me.txtDUI.Name = "txtDUI"
        Me.txtDUI.Size = New System.Drawing.Size(111, 16)
        Me.txtDUI.TabIndex = 1
        Me.txtDUI.Tag = Nothing
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(19, 113)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(106, 24)
        Me.rbTodos.TabIndex = 10
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Location = New System.Drawing.Point(397, 107)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(111, 25)
        Me.btnMostrar.TabIndex = 11
        Me.btnMostrar.Text = "Mos&trar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'rbCodigoPrestamo
        '
        Me.rbCodigoPrestamo.BackColor = System.Drawing.Color.White
        Me.rbCodigoPrestamo.Location = New System.Drawing.Point(246, 54)
        Me.rbCodigoPrestamo.Name = "rbCodigoPrestamo"
        Me.rbCodigoPrestamo.Size = New System.Drawing.Size(106, 24)
        Me.rbCodigoPrestamo.TabIndex = 5
        Me.rbCodigoPrestamo.Text = "Cod. Préstamo:"
        Me.rbCodigoPrestamo.UseVisualStyleBackColor = False
        '
        'rbDUI
        '
        Me.rbDUI.BackColor = System.Drawing.Color.White
        Me.rbDUI.Location = New System.Drawing.Point(19, 55)
        Me.rbDUI.Name = "rbDUI"
        Me.rbDUI.Size = New System.Drawing.Size(106, 23)
        Me.rbDUI.TabIndex = 0
        Me.rbDUI.Text = "&DUI:"
        Me.rbDUI.UseVisualStyleBackColor = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(134, 142)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 29)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 188
        Me.MetroButton1.Text = "Consultar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(19, 142)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(110, 29)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 186
        Me.MetroButton2.Text = "Agregar Gestión"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Enabled = False
        Me.MetroButton3.Location = New System.Drawing.Point(214, 142)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 29)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 187
        Me.MetroButton3.Text = "Modificar"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        Me.MetroButton3.Visible = False
        '
        'frmMCBGestionCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(638, 546)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.cbNombres)
        Me.Controls.Add(Me.rbNombres)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.txtDUI)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.rbCodigoPrestamo)
        Me.Controls.Add(Me.rbDUI)
        Me.Name = "frmMCBGestionCredito"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Gestión de Credito"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDUI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables privadas del formulario"
    Private vCodGestor As String
#End Region

#Region "Propiedades del formulario"

    Public Property CodGestor() As String
        Get
            Return vCodGestor
        End Get
        Set(ByVal Value As String)
            vCodGestor = Value
        End Set
    End Property

#End Region

    Private Sub Encabezado()
        'fg.Cols.Item(1).Caption = "Código de Gestor"
        'fg.Cols.Item(2).Caption = "Código de Préstamo"
        'fg.Cols.Item(3).Caption = "Dui"
        'fg.Cols.Item(4).Caption = "Fecha de Asignación"
        'fg.Cols.Item(5).Caption = "Estado"

        fg.Cols.Item(0).Width = 50
        fg.Cols.Item(1).Width = 150
        fg.Cols.Item(2).Width = 75
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 200

    End Sub

    Private Sub ActualizarGrid()
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim ds As New Data.DataSet
        Try
            Dim dts As New DataSet
            Dim idGestor As Integer
            dts = oCred.ConsultarGestores("codGestor", " usuario = '" & sUsuario & "' ", "codGestor", sUsuario, sPassword, sSucursal)
            If dts.Tables(0).Rows.Count > 0 Then
                idGestor = dts.Tables(0).Rows(0).Item(0)
                vCodGestor = idGestor
                ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", "a.CodGestor='" & idGestor & "' and a.Estado='A'", "CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
            End If


            'ds = oCred.ConsultarGestoresxCredito("*", "CodGestor='" & vCodGestor.Trim & "'", "FechaAsignacion", sUsuario, sPassword,sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - créditos")
        End Try
        Encabezado()
    End Sub



    Private Sub frmCBMGestionCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()
        Me.cbNombres.SelectedIndex = 0
    End Sub


    Private Sub btnMostrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet, dr As DataRow
        Dim oPres As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
        Dim Filas As Data.DataRowCollection, pCodigo As String, oAsoc As New wrAsociados.wsLibAsoc, pDui As String, pFiltro As String

        oCred = New wrCredito.wsLibCred
        If rbDUI.Checked = True Then
            ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,CONCAT(c.Nombres, ' ',c.Apellido1 , ' ' ,c.Apellido2) as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", "a.Dui='" & Me.txtDUI.Text.Trim & "'  and a.Estado='A'", "a.CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
            'ds = oCred.ConsultarGestoresxCredito("*", "Dui='" & Me.txtDUI.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables("CBGestoresxCredito")

        ElseIf Me.rbCodigoPrestamo.Checked = True Then
            ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", "a.CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "' and a.Estado='A'", "a.CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
            'ds = oCred.ConsultarGestoresxCredito("*", "CodPrestamo LIKE '" & Trim(Me.txtCodPrestamo.Text) & "%' AND CodGestor = '" & Trim(Me.vCodGestor) & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables("CBGestoresxCredito")
        ElseIf Me.rbTodos.Checked = True Then
            ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", " a.Estado='A'", "a.CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
            'ds = oCred.ConsultarGestoresxCredito("*", "CodGestor = '" & Trim(Me.vCodGestor) & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables("CBGestoresxCredito")
        ElseIf rbNombres.Checked = True Then
            If cbNombres.SelectedIndex = 0 Then
                ds = oAsoc.ConsultarAsociado("Dui", "Apellido1 = '" & Trim(txtNombres.Text) & "'", "Apellido1,Apellido2", sUsuario, sPassword, sSucursal)
            ElseIf cbNombres.SelectedIndex = 1 Then
                ds = oAsoc.ConsultarAsociado("Dui", "Apellido2 = '" & Trim(txtNombres.Text) & "'", "Apellido1", sUsuario, sPassword, sSucursal)
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
                pFiltro = pFiltro & " and a.Estado='A' "
                If ds.Tables(0).Rows.Count > 0 Then
                    ds = oCred.ConsultarGestoresxCredito_Asociado("a.CodPrestamo as Cód_Préstamo,a.Dui,a.FechaAsignacion as Fecha_Asignación,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombre_Asociado,d.Monto,d.Saldo_Capital as Saldo,d.FechaVencimiento as Fecha_Vancimiento,d.FechaUltimoPago as Ultimo_Movimiento,e.Descripcion as Tipo_Credito,d.SaldoDia_CapitalMora as Saldo_Mora,a.CodGestor as Cód_Gestor,b.Nombre as Gestor", "(" & pFiltro & ")", "a.CodGestor,FechaAsignacion", sUsuario, sPassword, sSucursal)
                    'ds = oCred.ConsultarGestoresxCredito("*", pFiltro, "CodPrestamo", sUsuario, sPassword, sSucursal)
                    fg.DataSource = ds.Tables("CBGestoresxCredito")
                End If
            End If
        End If
        Encabezado()
    End Sub

    Private Sub rbDUI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDUI.CheckedChanged
        Me.txtDUI.Focus()
    End Sub



    Private Sub rbCodigoPrestamo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodigoPrestamo.CheckedChanged
        Me.txtCodPrestamo.Focus()
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


    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click_1(sender, e)
    End Sub

    Private Sub txtDUI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDUI.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click_1(sender, e)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click_1(sender, e)
    End Sub

    Private Sub dtpInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Return Then btnMostrar_Click_1(sender, e)
    End Sub

    Private Sub dtpFin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Return Then btnMostrar_Click_1(sender, e)
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim ofrm As New frmMsCBGestionCredito
            If fg.Row <> -1 Then
                ofrm.CodPrestamo = Trim(fg.Item(fg.Row, "Cód_Préstamo"))
                ofrm.CodGestor = Trim(fg.Item(fg.Row, "Cód_Gestor"))
                'ofrm.btnAdd1.Text = "&Agregar Gestión"
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizarGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If fg.Row <> -1 Then
                Dim ofrm As New frmMsCBGestionCredEdit
                Dim ofrmAut As New frmMsAutorizacion
                ofrmAut.TipoPermiso = "P"
                ofrmAut.NumPrograma = "CBE002"
                ofrmAut.ShowDialog()
                If ofrmAut.Autoriza = True Then
                    ofrm.pAccion = "Modificar"
                    ofrm.CodPrestamo = Trim(fg.Item(fg.Row, "Cód_Préstamo"))
                    ofrm.CodGestor = Trim(fg.Item(fg.Row, "Cód_Gestor"))
                    ofrm.StartPosition = FormStartPosition.CenterScreen
                    ofrm.ShowDialog()
                    ActualizarGrid()
                    ofrmAut.Autoriza = False
                    ofrmAut.Dispose()
                Else
                    ofrmAut.Dispose()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim ofrm As New frmMsCBGestionCredEdit
            If fg.Row <> -1 Then
                ofrm.btnGuardar1.Visible = False
                ofrm.pAccion = "Consultar"
                ofrm.CodPrestamo = Trim(fg.Item(fg.Row, "Cód_Préstamo"))
                ofrm.CodGestor = Trim(fg.Item(fg.Row, "Cód_Gestor"))
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizarGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class