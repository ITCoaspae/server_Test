Public Class frmMGarantiasPrendarias
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ds As New Data.DataSet
    Dim frm As New frmGarantiasPrendarias
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEstado1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Dim oItem As wrCredito.wsLibCred = New wrCredito.wsLibCred
#Region " Código generado por el Diseñador "

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
    Private WithEvents rbtCodPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNoEscritura As System.Windows.Forms.RadioButton
    Friend WithEvents txtNoEscritura As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMGarantiasPrendarias))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.txtNoEscritura = New System.Windows.Forms.TextBox()
        Me.rbtNoEscritura = New System.Windows.Forms.RadioButton()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.rbtCodPrestamo = New System.Windows.Forms.RadioButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEstado1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.rbDui)
        Me.GroupBox2.Controls.Add(Me.txtNoEscritura)
        Me.GroupBox2.Controls.Add(Me.rbtNoEscritura)
        Me.GroupBox2.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox2.Controls.Add(Me.rbtCodPrestamo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(799, 86)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar por:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(712, 50)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 220
        Me.MetroButton1.Text = "&Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(275, 50)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(431, 20)
        Me.txtNombres.TabIndex = 8
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(16, 49)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(95, 24)
        Me.rbNombres.TabIndex = 6
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(117, 49)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(152, 21)
        Me.cbNombres.TabIndex = 7
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(635, 23)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(152, 20)
        Me.txtDui.TabIndex = 5
        Me.txtDui.Tag = Nothing
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Checked = True
        Me.rbDui.ForeColor = System.Drawing.Color.Black
        Me.rbDui.Location = New System.Drawing.Point(534, 21)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(95, 24)
        Me.rbDui.TabIndex = 4
        Me.rbDui.TabStop = True
        Me.rbDui.Text = "&DUI:"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'txtNoEscritura
        '
        Me.txtNoEscritura.Location = New System.Drawing.Point(376, 24)
        Me.txtNoEscritura.MaxLength = 25
        Me.txtNoEscritura.Name = "txtNoEscritura"
        Me.txtNoEscritura.Size = New System.Drawing.Size(152, 20)
        Me.txtNoEscritura.TabIndex = 3
        '
        'rbtNoEscritura
        '
        Me.rbtNoEscritura.BackColor = System.Drawing.Color.White
        Me.rbtNoEscritura.Location = New System.Drawing.Point(275, 24)
        Me.rbtNoEscritura.Name = "rbtNoEscritura"
        Me.rbtNoEscritura.Size = New System.Drawing.Size(95, 16)
        Me.rbtNoEscritura.TabIndex = 2
        Me.rbtNoEscritura.Text = "No Escritura:"
        Me.rbtNoEscritura.UseVisualStyleBackColor = False
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Location = New System.Drawing.Point(117, 23)
        Me.txtCodPrestamo.MaxLength = 25
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(152, 20)
        Me.txtCodPrestamo.TabIndex = 1
        '
        'rbtCodPrestamo
        '
        Me.rbtCodPrestamo.BackColor = System.Drawing.Color.White
        Me.rbtCodPrestamo.Checked = True
        Me.rbtCodPrestamo.Location = New System.Drawing.Point(16, 24)
        Me.rbtCodPrestamo.Name = "rbtCodPrestamo"
        Me.rbtCodPrestamo.Size = New System.Drawing.Size(95, 16)
        Me.rbtCodPrestamo.TabIndex = 0
        Me.rbtCodPrestamo.TabStop = True
        Me.rbtCodPrestamo.Text = "Prestamo:"
        Me.rbtCodPrestamo.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 189)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Size = New System.Drawing.Size(803, 291)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 21
        '
        'lblEstado
        '
        Me.lblEstado.BackColor = System.Drawing.Color.White
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Teal
        Me.lblEstado.Location = New System.Drawing.Point(347, 167)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(236, 16)
        Me.lblEstado.TabIndex = 22
        Me.lblEstado.Text = "N/A"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(104, 155)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(75, 28)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 206
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(266, 155)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 205
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEstado1
        '
        Me.btnEstado1.Location = New System.Drawing.Point(185, 155)
        Me.btnEstado1.Name = "btnEstado1"
        Me.btnEstado1.Size = New System.Drawing.Size(75, 28)
        Me.btnEstado1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEstado1.TabIndex = 204
        Me.btnEstado1.Text = "&Eliminar"
        Me.btnEstado1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEstado1.UseSelectable = True
        Me.btnEstado1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 155)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 203
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMGarantiasPrendarias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(849, 518)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEstado1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMGarantiasPrendarias"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Garantías PrendariaMantenimiento - Garantias Prendarias"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMGarantiasPrendarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()
    End Sub

    Private Sub ActualizarGrid()
        Try
            ds = oItem.ConsultarGarantiasPrNombre("c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,a.CodPrestamo,b.FechaOtorgamiento,b.FechaVencimiento,a.NoEscritura,a.OrdenLibro,a.Notario,a.Fecha", "a.Fecha='" & Now.ToShortDateString & "'", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub rbtCodPrestamo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCodPrestamo.CheckedChanged
        Me.txtCodPrestamo.Focus()
    End Sub

    Private Sub rbtNoEscritura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNoEscritura.CheckedChanged
        Me.txtNoEscritura.Focus()
    End Sub



    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub txtNoEscritura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoEscritura.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub rbDui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
        Me.txtDui.Focus()
    End Sub

    Private Sub rbDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDui.Click
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

    Private Sub fg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.Click
        Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet, dr As DataRow
        If fg.Row > 0 Then
            ds = oPrest.ConsultarPRPrestamos("Estado", "CodPrestamo='" & CStr(fg.Item(fg.Row, "CodPrestamo")).Trim & "'", "Estado", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Select Case CStr(dr("Estado")).Trim
                    Case "D" 'Digitado (sin tabla de amortización)
                        Me.lblEstado.Text = "DIGITADO"
                    Case "A" 'A: Activo (ya se ha generado tabla de amortización)
                        Me.lblEstado.Text = "ACTIVO"
                    Case "C" 'C: Cancelado
                        Me.lblEstado.Text = "CANCELADO"
                End Select
            End If
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim oItem As New wrCredito.wsLibCred, oAsoc As New wrAsociados.wsLibAsoc, oPr As New wrPrestamo.wsLibPrest
        Dim ds As New Data.DataSet, pDui As String, dr As DataRow, pFiltro As String
        Try
            If Me.rbtCodPrestamo.Checked = True Then
                ds = oItem.ConsultarGarantiasPrNombre("c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,a.CodPrestamo,b.FechaOtorgamiento,b.FechaVencimiento,a.NoEscritura,a.OrdenLibro,a.Notario,a.Fecha", "a.CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbtNoEscritura.Checked = True Then
                ds = oItem.ConsultarGarantiasPr("c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,a.CodPrestamo,b.FechaOtorgamiento,b.FechaVencimiento,a.NoEscritura,a.OrdenLibro,a.Notario,a.Fecha", "a.NoEscritura='" & Me.txtNoEscritura.Text.Trim & "'", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbDui.Checked = True Then
                ds = oAsoc.ConsultarAsociado("Dui", "Dui='" & Trim(Me.txtDui.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                pFiltro = ""
                For Each dr In ds.Tables(0).Rows
                    If pFiltro.Trim = "" Then
                        pFiltro = "Dui='" & dr("Dui") & "'"
                    Else
                        pFiltro = pFiltro & "or Dui='" & dr("Dui") & "'"
                    End If
                Next
                If pFiltro.Trim = "" Then
                    fg.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                    Exit Sub
                Else
                    If ds.Tables(0).Rows.Count > 0 Then
                        ds = oPr.ConsultarPRPrestamos("CodPrestamo", "(" & pFiltro & ")", "CodPrestamo", sUsuario, sPassword, sSucursal)
                        pFiltro = ""
                        For Each dr In ds.Tables(0).Rows
                            If pFiltro.Trim = "" Then
                                pFiltro = "a.CodPrestamo='" & dr("CodPrestamo") & "'"
                            Else
                                pFiltro = pFiltro & "or a.CodPrestamo='" & dr("CodPrestamo") & "'"
                            End If
                        Next
                        If pFiltro.Trim = "" Then
                            fg.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                            Exit Sub
                        Else
                            ds = oItem.ConsultarGarantiasPrNombre("c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,a.CodPrestamo,b.FechaOtorgamiento,b.FechaVencimiento,a.NoEscritura,a.OrdenLibro,a.Notario,a.Fecha", "(" & pFiltro & ")", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
                        End If
                    End If
                End If
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
                        pFiltro = "Dui='" & dr("Dui") & "'"
                    Else
                        pFiltro = pFiltro & "or Dui='" & dr("Dui") & "'"
                    End If
                Next
                If pFiltro.Trim = "" Then
                    fg.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                    Exit Sub
                Else
                    If ds.Tables(0).Rows.Count > 0 Then
                        ds = oPr.ConsultarPRPrestamos("CodPrestamo", "(" & pFiltro & ")", "CodPrestamo", sUsuario, sPassword, sSucursal)
                        pFiltro = ""
                        For Each dr In ds.Tables(0).Rows
                            If pFiltro.Trim = "" Then
                                pFiltro = "a.CodPrestamo='" & dr("CodPrestamo") & "'"
                            Else
                                pFiltro = pFiltro & "or a.CodPrestamo='" & dr("CodPrestamo") & "'"
                            End If
                        Next
                        If pFiltro.Trim = "" Then
                            fg.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                            Exit Sub
                        Else
                            ds = oItem.ConsultarGarantiasPrNombre("c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,a.CodPrestamo,b.FechaOtorgamiento,b.FechaVencimiento,a.NoEscritura,a.OrdenLibro,a.Notario,a.Fecha", "(" & pFiltro & ")", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
                        End If
                    End If
                End If
            End If
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            frm.btnGuardar.Text = "&Guardar"
            frm.btnGuardar.Enabled = True
            frm.cbEstatus.SelectedIndex = 0
            frm.cbTipoDocEnt.SelectedIndex = 0
            frm.TabControl1.TabPages(1).Enabled = False
            frm.cbEstatusST.SelectedIndex = 0
            frm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            Dim oItem As New wrCredito.wsLibCred, oPr As New wrPrestamo.wsLibPrest, oAsoc As New wrAsociados.wsLibAsoc
            Dim ofrm As New frmGarantiasPrendarias

            If fg.Row <> -1 Then
                ds = oItem.ConsultarGarantiasPr("*", "CodPrestamo='" & Trim(fg.Item(fg.Row, "CodPrestamo")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar.Text = "&Modificar"
                ofrm.btnGuardar.Enabled = True
                If Not dr("CodPrestamo") Is DBNull.Value Then
                    ofrm.txtCodPrestamo.Text = dr("CodPrestamo")
                    ofrm.txtCodPrestamo.ReadOnly = True
                End If
                If Not dr("NoEscritura") Is DBNull.Value Then
                    ofrm.txtNoEscritura.Text = dr("NoEscritura")
                End If
                If Not dr("OrdenLibro") Is DBNull.Value Then
                    ofrm.txtOrdenLibro.Text = dr("OrdenLibro")
                End If
                If Not dr("Notario") Is DBNull.Value Then
                    ofrm.txtNotario.Text = dr("Notario")
                End If
                If Not dr("FechaPresentacion") Is DBNull.Value Then
                    ofrm.dtFecPresentacion.Value = dr("FechaPresentacion")
                End If
                If Not dr("FechaInscripcion") Is DBNull.Value Then
                    ofrm.dtpFecInscripcion.Value = dr("FechaInscripcion")
                End If
                If Not dr("NoPresentacion") Is DBNull.Value Then
                    ofrm.txtNoPresentacion.Text = dr("NoPresentacion")
                End If
                If Not dr("Observaciones") Is DBNull.Value Then
                    ofrm.txtObs.Text = dr("Observaciones")
                End If
                If Not dr("Estatus") Is DBNull.Value Then
                    ofrm.cbEstatus.SelectedIndex = CInt(dr("Estatus"))
                Else
                    ofrm.cbEstatus.SelectedIndex = 0
                End If
                If Not dr("FechaPresentacionST") Is DBNull.Value Then
                    ofrm.dtFecPresentacionST.Value = dr("FechaPresentacionST")
                End If
                If Not dr("FechaInscripcionST") Is DBNull.Value Then
                    ofrm.dtFecInscripcionST.Value = dr("FechaInscripcionST")
                End If
                If Not dr("NoPresentacionST") Is DBNull.Value Then
                    ofrm.txtNoPresentacionST.Text = dr("NoPresentacionST")
                End If
                If Not dr("ObservacionesST") Is DBNull.Value Then
                    ofrm.txtObsST.Text = dr("ObservacionesST")
                End If
                If Not dr("EstatusST") Is DBNull.Value Then
                    ofrm.cbEstatusST.SelectedIndex = CInt(dr("EstatusST"))
                Else
                    ofrm.cbEstatusST.SelectedIndex = 0
                End If

                If Not dr("Responsable_Recibe") Is DBNull.Value Then ofrm.txtResponsable.Text = dr("Responsable_Recibe")
                If Not dr("Fecha_Entrega") Is DBNull.Value Then ofrm.dtpFecEntDC.Value = dr("Fecha_Entrega")
                If Not dr("CodDepartamento_Recibe") Is DBNull.Value Then ofrm.txtCodDeptoRecibe.Text = dr("CodDepartamento_Recibe")
                If Not dr("Fecha_Dev") Is DBNull.Value Then ofrm.dtpFecDev.Value = dr("Fecha_Dev")
                If Not dr("Responsable_Entrega") Is DBNull.Value Then ofrm.txtResponsableEntrega.Text = dr("Responsable_Entrega")
                If Not dr("CodDepartamento_Entrega") Is DBNull.Value Then ofrm.txtCodDeptoEntrega.Text = dr("CodDepartamento_Entrega")
                If Not dr("TipoDocumento_Entregado") Is DBNull.Value Then ofrm.cbTipoDocEnt.SelectedIndex = dr("TipoDocumento_Entregado")

                ds = oPr.ConsultarPRPrestamos("*", "CodPrestamo='" & ofrm.txtCodPrestamo.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                If Not dr("Dui") Is DBNull.Value Then
                    ofrm.txtDui.Value = dr("Dui")
                End If
                If Not dr("NoSocio") Is DBNull.Value Then
                    ofrm.txtNoSocio.Text = dr("NoSocio")
                End If
                If Not dr("Monto") Is DBNull.Value Then
                    ofrm.c1nMonto.Value = dr("Monto")
                End If
                If Not dr("PlazoMeses") Is DBNull.Value Then
                    ofrm.c1nPlazo.Value = dr("PlazoMeses")
                End If
                If Not dr("Tasa_Interes") Is DBNull.Value Then
                    ofrm.c1nTasa.Value = dr("Tasa_Interes")
                End If
                If Not dr("PlazoMeses") Is DBNull.Value Then
                    ofrm.txtCuotas.Text = Math.Round(dr("Saldo_Capital") / dr("Cuota"), 1)
                End If
                If Not dr("FechaOtorgamiento") Is DBNull.Value Then
                    ofrm.dtpFechaOtorgamiento.Value = dr("FechaOtorgamiento")
                End If
                If Not dr("FechaVencimiento") Is DBNull.Value Then
                    ofrm.dtpFechaVencimiento.Value = dr("FechaVencimiento")
                End If

                ds = oAsoc.ConsultarAsociado("Apellido1,Apellido2,Nombres", "Dui='" & ofrm.txtDui.Text.Trim & "'", "Dui", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.txtAsociado.Text = dr("Nombres") & " " & dr("Apellido1") & " " & dr("Apellido2")

                'ofrm.fg.DataSource = oItem.ConsultarDetGarantiasPr("*", "CodPrestamo='" & ofrm.txtCodPrestamo.Text.Trim & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)

                Dim oPlan As New wrPlanilla.wsLibPlanilla

                If frm.txtCodDeptoEntrega.Text.Trim <> "" Then
                    ds = oPlan.ConsultarPLDepartamentos("Descripcion", "CodDepartamento='" & ofrm.txtCodDeptoEntrega.Text.Trim & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        frm.txtDeptoEntrega.Text = dr("Descripcion")
                    End If
                End If

                If frm.txtCodDeptoRecibe.Text.Trim <> "" Then
                    ds = oPlan.ConsultarPLDepartamentos("Descripcion", "CodDepartamento='" & ofrm.txtCodDeptoRecibe.Text.Trim & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        frm.txtDeptoRecibe.Text = dr("Descripcion")
                    End If
                End If

                ds = oPr.ConsultarPRPrestamosTipoCredito("b.Descripcion", "a.CodPrestamo='" & ofrm.txtCodPrestamo.Text.Trim & "'", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    ofrm.txtTipoCredito.Text = dr("Descripcion")
                End If
                'ofrm.Encabezado()
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizarGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEstado1_Click(sender As Object, e As EventArgs) Handles btnEstado1.Click
        Try
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            Dim oItem As New wrCredito.wsLibCred
            If fg.Row <> -1 Then
                If oItem.EliminarGarantiasPr("CodPrestamo='" & Trim(fg.Item(fg.Row, "CodPrestamo")) & "'", sUsuario, sPassword, sSucursal) = True Then
                    oItem.EliminarDetGarantiasPr("CodPrestamo='" & Trim(fg.Item(fg.Row, "CodPrestamo")) & "'", sUsuario, sPassword, sSucursal)
                    ActualizarGrid()
                Else
                    MsgBox("El registro no se ha eliminado.", MsgBoxStyle.Information, "Módulo - Garantías")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            Dim oItem As New wrCredito.wsLibCred, oPr As New wrPrestamo.wsLibPrest, oAsoc As New wrAsociados.wsLibAsoc
            Dim ofrm As New frmGarantiasPrendarias

            If fg.Row <> -1 Then
                ds = oItem.ConsultarGarantiasPr("*", "CodPrestamo='" & Trim(fg.Item(fg.Row, "CodPrestamo")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.btnGuardar.Text = "&Modificar"
                If Not dr("CodPrestamo") Is DBNull.Value Then
                    ofrm.txtCodPrestamo.Text = dr("CodPrestamo")
                    ofrm.txtCodPrestamo.ReadOnly = True
                End If
                If Not dr("NoEscritura") Is DBNull.Value Then
                    ofrm.txtNoEscritura.Text = dr("NoEscritura")
                End If
                If Not dr("OrdenLibro") Is DBNull.Value Then
                    ofrm.txtOrdenLibro.Text = dr("OrdenLibro")
                End If
                If Not dr("Notario") Is DBNull.Value Then
                    ofrm.txtNotario.Text = dr("Notario")
                End If
                If Not dr("FechaPresentacion") Is DBNull.Value Then
                    ofrm.dtFecPresentacion.Value = dr("FechaPresentacion")
                End If
                If Not dr("FechaInscripcion") Is DBNull.Value Then
                    ofrm.dtpFecInscripcion.Value = dr("FechaInscripcion")
                End If
                If Not dr("NoPresentacion") Is DBNull.Value Then
                    ofrm.txtNoPresentacion.Text = dr("NoPresentacion")
                End If
                If Not dr("Observaciones") Is DBNull.Value Then
                    ofrm.txtObs.Text = dr("Observaciones")
                End If
                If Not dr("Estatus") Is DBNull.Value Then
                    ofrm.cbEstatus.SelectedIndex = CInt(dr("Estatus"))
                Else
                    ofrm.cbEstatus.SelectedIndex = 0
                End If
                If Not dr("FechaPresentacionST") Is DBNull.Value Then
                    ofrm.dtFecPresentacionST.Value = dr("FechaPresentacionST")
                End If
                If Not dr("FechaInscripcionST") Is DBNull.Value Then
                    ofrm.dtFecInscripcionST.Value = dr("FechaInscripcionST")
                End If
                If Not dr("NoPresentacionST") Is DBNull.Value Then
                    ofrm.txtNoPresentacionST.Text = dr("NoPresentacionST")
                End If
                If Not dr("ObservacionesST") Is DBNull.Value Then
                    ofrm.txtObsST.Text = dr("ObservacionesST")
                End If
                If Not dr("EstatusST") Is DBNull.Value Then
                    ofrm.cbEstatusST.SelectedIndex = CInt(dr("EstatusST"))
                Else
                    ofrm.cbEstatusST.SelectedIndex = 0
                End If

                If Not dr("Responsable_Recibe") Is DBNull.Value Then ofrm.txtResponsable.Text = dr("Responsable_Recibe")
                If Not dr("Fecha_Entrega") Is DBNull.Value Then ofrm.dtpFecEntDC.Value = dr("Fecha_Entrega")
                If Not dr("CodDepartamento_Recibe") Is DBNull.Value Then ofrm.txtCodDeptoRecibe.Text = dr("CodDepartamento_Recibe")
                If Not dr("Fecha_Dev") Is DBNull.Value Then ofrm.dtpFecDev.Value = dr("Fecha_Dev")
                If Not dr("Responsable_Entrega") Is DBNull.Value Then ofrm.txtResponsableEntrega.Text = dr("Responsable_Entrega")
                If Not dr("CodDepartamento_Entrega") Is DBNull.Value Then ofrm.txtCodDeptoEntrega.Text = dr("CodDepartamento_Entrega")
                If Not dr("TipoDocumento_Entregado") Is DBNull.Value Then ofrm.cbTipoDocEnt.SelectedIndex = dr("TipoDocumento_Entregado")

                ds = oPr.ConsultarPRPrestamos("*", "CodPrestamo='" & ofrm.txtCodPrestamo.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                If Not dr("Dui") Is DBNull.Value Then
                    ofrm.txtDui.Value = dr("Dui")
                End If
                If Not dr("NoSocio") Is DBNull.Value Then
                    ofrm.txtNoSocio.Text = dr("NoSocio")
                End If
                If Not dr("Monto") Is DBNull.Value Then
                    ofrm.c1nMonto.Value = dr("Monto")
                End If
                If Not dr("PlazoMeses") Is DBNull.Value Then
                    ofrm.c1nPlazo.Value = dr("PlazoMeses")
                End If
                If Not dr("Tasa_Interes") Is DBNull.Value Then
                    ofrm.c1nTasa.Value = dr("Tasa_Interes")
                End If
                If Not dr("PlazoMeses") Is DBNull.Value Then
                    ofrm.txtCuotas.Text = dr("PlazoMeses")
                End If
                If Not dr("FechaOtorgamiento") Is DBNull.Value Then
                    ofrm.dtpFechaOtorgamiento.Value = dr("FechaOtorgamiento")
                End If
                If Not dr("FechaVencimiento") Is DBNull.Value Then
                    ofrm.dtpFechaVencimiento.Value = dr("FechaVencimiento")
                End If

                ds = oAsoc.ConsultarAsociado("Apellido1,Apellido2,Nombres", "Dui='" & ofrm.txtDui.Text.Trim & "'", "Dui", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.txtAsociado.Text = dr("Nombres") & " " & dr("Apellido1") & " " & dr("Apellido2")

                'ofrm.fg.DataSource = oItem.ConsultarDetGarantiasPr("*", "CodPrestamo='" & ofrm.txtCodPrestamo.Text.Trim & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)

                Dim oPlan As New wrPlanilla.wsLibPlanilla
                If frm.txtCodDeptoEntrega.Text.Trim <> "" Then
                    ds = oPlan.ConsultarPLDepartamentos("Descripcion", "CodDepartamento='" & ofrm.txtCodDeptoEntrega.Text.Trim & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        frm.txtDeptoEntrega.Text = dr("Descripcion")
                    End If
                End If

                If frm.txtCodDeptoRecibe.Text.Trim <> "" Then
                    ds = oPlan.ConsultarPLDepartamentos("Descripcion", "CodDepartamento='" & ofrm.txtCodDeptoRecibe.Text.Trim & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        frm.txtDeptoRecibe.Text = dr("Descripcion")
                    End If
                End If
                ds = oPr.ConsultarPRPrestamosTipoCredito("b.Descripcion", "a.CodPrestamo='" & ofrm.txtCodPrestamo.Text.Trim & "'", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    ofrm.txtTipoCredito.Text = dr("Descripcion")
                End If

                'ofrm.Encabezado()
                ofrm.StartPosition = FormStartPosition.CenterScreen
                frm.btnGuardar.Text = "&Modificar"
                frm.btnGuardar.Visible = False
                ofrm.ShowDialog()
                ActualizarGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class