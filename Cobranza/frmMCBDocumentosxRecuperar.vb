Public Class frmMCBDocumentosxRecuperar
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
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents rbtNoActa As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCodPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents txtNoActa As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCBDocumentosxRecuperar))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.txtNoActa = New System.Windows.Forms.TextBox()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbtNoActa = New System.Windows.Forms.RadioButton()
        Me.rbtCodPrestamo = New System.Windows.Forms.RadioButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.txtNoActa)
        Me.GroupBox2.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbtNoActa)
        Me.GroupBox2.Controls.Add(Me.rbtCodPrestamo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(901, 108)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Documentos por:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(788, 55)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 33)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 188
        Me.MetroButton1.Text = "Mostrar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(588, 66)
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
        Me.cbNombres.Location = New System.Drawing.Point(398, 65)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(183, 24)
        Me.cbNombres.TabIndex = 5
        '
        'txtNoActa
        '
        Me.txtNoActa.Location = New System.Drawing.Point(209, 65)
        Me.txtNoActa.Name = "txtNoActa"
        Me.txtNoActa.Size = New System.Drawing.Size(182, 22)
        Me.txtNoActa.TabIndex = 3
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Location = New System.Drawing.Point(19, 65)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(183, 22)
        Me.txtCodPrestamo.TabIndex = 1
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(788, 21)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(90, 27)
        Me.rbTodos.TabIndex = 7
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "&Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'rbtNoActa
        '
        Me.rbtNoActa.BackColor = System.Drawing.Color.White
        Me.rbtNoActa.Location = New System.Drawing.Point(217, 28)
        Me.rbtNoActa.Name = "rbtNoActa"
        Me.rbtNoActa.Size = New System.Drawing.Size(174, 27)
        Me.rbtNoActa.TabIndex = 2
        Me.rbtNoActa.Text = "&Número de Acta"
        Me.rbtNoActa.UseVisualStyleBackColor = False
        '
        'rbtCodPrestamo
        '
        Me.rbtCodPrestamo.BackColor = System.Drawing.Color.White
        Me.rbtCodPrestamo.Location = New System.Drawing.Point(19, 28)
        Me.rbtCodPrestamo.Name = "rbtCodPrestamo"
        Me.rbtCodPrestamo.Size = New System.Drawing.Size(191, 27)
        Me.rbtCodPrestamo.TabIndex = 0
        Me.rbtCodPrestamo.Text = "&Código de Prestamo"
        Me.rbtCodPrestamo.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "25,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(28, 227)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(899, 228)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 42
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(28, 188)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 186
        Me.MetroButton2.Text = "Agregar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(125, 188)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 187
        Me.MetroButton3.Text = "Modificar"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'frmMCBDocumentosxRecuperar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(955, 528)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMCBDocumentosxRecuperar"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Documentos en Proceso de Recuperación"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ActualizarGrid()
        Dim ds As New Data.DataSet
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Try
            ds = oCred.ConsultarDatosDocumentosxRecuperar("a.CodPrestamo,a.Dui,a.Fecha,a.TipoDocumento as Tipo,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,b.Monto,b.Saldo_Capital as Saldo,b.FechaOtorgamiento as Fecha_Otorgamiento,b.FechaVencimiento as Fecha_Vencimiento,b.FechaUltimoPago as Fecha_Ultimo_Movimiento,d.Descripcion as Tipo_Credito,b.SaldoDia_CapitalMora as Saldo_Mora,f.Nombre as Gestor", "", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo Cobranza")
        End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim ds As New Data.DataSet
        Dim ofrm As New frmAGenerico
        Dim Resultado As String

        Try
            ds = oCred.ConsultarDatosDocumentosxRecuperar("a.CodPrestamo,a.Dui,a.Fecha,a.TipoDocumento as Tipo,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,b.Monto,b.Saldo_Capital as Saldo,b.FechaOtorgamiento as Fecha_Otorgamiento,b.FechaVencimiento as Fecha_Vencimiento,b.FechaUltimoPago as Fecha_Ultimo_Movimiento,d.Descripcion as Tipo_Credito,b.SaldoDia_CapitalMora as Saldo_Mora,f.Nombre as Gestor", "", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado = "" Then
                ds = oCred.ConsultarDatosDocumentosxRecuperar("a.CodPrestamo,a.Dui,a.Fecha,a.TipoDocumento as Tipo,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,b.Monto,b.Saldo_Capital as Saldo,b.FechaOtorgamiento as Fecha_Otorgamiento,b.FechaVencimiento as Fecha_Vencimiento,b.FechaUltimoPago as Fecha_Ultimo_Movimiento,d.Descripcion as Tipo_Credito,b.SaldoDia_CapitalMora as Saldo_Mora,f.Nombre as Gestor", "", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf ofrm.Resultado <> "" Then
                Resultado = ofrm.Resultado
                ds = oCred.ConsultarDatosDocumentosxRecuperar("a.CodPrestamo,a.Dui,a.Fecha,a.TipoDocumento as Tipo,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,b.Monto,b.Saldo_Capital as Saldo,b.FechaOtorgamiento as Fecha_Otorgamiento,b.FechaVencimiento as Fecha_Vencimiento,b.FechaUltimoPago as Fecha_Ultimo_Movimiento,d.Descripcion as Tipo_Credito,b.SaldoDia_CapitalMora as Saldo_Mora,f.Nombre as Gestor", "a.CodPrestamo = '" & Resultado & "'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo Cobranza")
        End Try
    End Sub




    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Me.MetroButton3_Click(sender, e)
    End Sub

    Private Sub rbtCodPrestamo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCodPrestamo.CheckedChanged
        Me.txtCodPrestamo.Focus()
    End Sub

    Private Sub rbtNoActa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNoActa.CheckedChanged
        Me.txtNoActa.Focus()
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



    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub txtNoActa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoActa.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim ofrm As New frmMsCBDocumentosxRecuperar
            ofrm.btnGuardar1.Text = "&Aperturar documento"
            ofrm.StartPosition = FormStartPosition.CenterParent
            ofrm.ShowDialog()
            ActualizarGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            Dim ofrm As New frmMsCBDocumentosxRecuperar
            ofrm.txtCodPrestamo.Text = fg.Item(fg.Row, "CodPrestamo")
            ofrm.btnGuardar1.Text = "&Modificar"
            ofrm.StartPosition = FormStartPosition.CenterParent
            ofrm.ShowDialog()
            ActualizarGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try

            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, dr As DataRow, pFiltro As String
            Dim oAsoc As New wrAsociados.wsLibAsoc
            Dim ds As New Data.DataSet

            If Me.rbtCodPrestamo.Checked = True Then
                ds = oCred.ConsultarDatosDocumentosxRecuperar("a.CodPrestamo,a.Dui,a.Fecha,a.TipoDocumento as Tipo,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,b.Monto,b.Saldo_Capital as Saldo,b.FechaOtorgamiento as Fecha_Otorgamiento,b.FechaVencimiento as Fecha_Vencimiento,b.FechaUltimoPago as Fecha_Ultimo_Movimiento,d.Descripcion as Tipo_Credito,b.SaldoDia_CapitalMora as Saldo_Mora,f.Nombre as Gestor", "a.CodPrestamo LIKE '" & Trim(Me.txtCodPrestamo.Text) & "%'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbtNoActa.Checked = True Then
                ds = oCred.ConsultarDatosDocumentosxRecuperar("a.CodPrestamo,a.Dui,a.Fecha,a.TipoDocumento as Tipo,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,b.Monto,b.Saldo_Capital as Saldo,b.FechaOtorgamiento as Fecha_Otorgamiento,b.FechaVencimiento as Fecha_Vencimiento,b.FechaUltimoPago as Fecha_Ultimo_Movimiento,d.Descripcion as Tipo_Credito,b.SaldoDia_CapitalMora as Saldo_Mora,f.Nombre as Gestor", "a.NoActa_ComiteMora LIKE '" & Trim(Me.txtNoActa.Text) & "%'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbTodos.Checked = True Then
                ds = oCred.ConsultarDatosDocumentosxRecuperar("a.CodPrestamo,a.Dui,a.Fecha,a.TipoDocumento as Tipo,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,b.Monto,b.Saldo_Capital as Saldo,b.FechaOtorgamiento as Fecha_Otorgamiento,b.FechaVencimiento as Fecha_Vencimiento,b.FechaUltimoPago as Fecha_Ultimo_Movimiento,d.Descripcion as Tipo_Credito,b.SaldoDia_CapitalMora as Saldo_Mora,f.Nombre as Gestor", "", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
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
                    fg.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                    Exit Sub
                Else
                    If ds.Tables(0).Rows.Count > 0 Then
                        ds = oCred.ConsultarDatosDocumentosxRecuperar("a.CodPrestamo,a.Dui,a.Fecha,a.TipoDocumento as Tipo,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,b.Monto,b.Saldo_Capital as Saldo,b.FechaOtorgamiento as Fecha_Otorgamiento,b.FechaVencimiento as Fecha_Vencimiento,b.FechaUltimoPago as Fecha_Ultimo_Movimiento,d.Descripcion as Tipo_Credito,b.SaldoDia_CapitalMora as Saldo_Mora,f.Nombre as Gestor", "(" & pFiltro & ")", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
                        fg.DataSource = ds.Tables(0)
                    End If
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

End Class