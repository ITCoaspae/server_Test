Public Class frmMBCEmbargos
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
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents rbNomAbogado As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNombreAbogado As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMBCEmbargos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.txtNombreAbogado = New System.Windows.Forms.TextBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbCodPrestamo = New System.Windows.Forms.RadioButton()
        Me.rbNomAbogado = New System.Windows.Forms.RadioButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox2.Controls.Add(Me.txtNombreAbogado)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbCodPrestamo)
        Me.GroupBox2.Controls.Add(Me.rbNomAbogado)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(738, 90)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Ingresos por:"
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(490, 53)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(152, 20)
        Me.txtNombres.TabIndex = 6
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(332, 24)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(152, 24)
        Me.rbNombres.TabIndex = 4
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Enabled = False
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(332, 53)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(152, 21)
        Me.cbNombres.TabIndex = 5
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Location = New System.Drawing.Point(174, 54)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(152, 20)
        Me.txtCodPrestamo.TabIndex = 3
        '
        'txtNombreAbogado
        '
        Me.txtNombreAbogado.Location = New System.Drawing.Point(16, 54)
        Me.txtNombreAbogado.Name = "txtNombreAbogado"
        Me.txtNombreAbogado.Size = New System.Drawing.Size(152, 20)
        Me.txtNombreAbogado.TabIndex = 1
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(642, 19)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(81, 24)
        Me.rbTodos.TabIndex = 7
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "&Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'rbCodPrestamo
        '
        Me.rbCodPrestamo.BackColor = System.Drawing.Color.White
        Me.rbCodPrestamo.Location = New System.Drawing.Point(174, 24)
        Me.rbCodPrestamo.Name = "rbCodPrestamo"
        Me.rbCodPrestamo.Size = New System.Drawing.Size(152, 24)
        Me.rbCodPrestamo.TabIndex = 2
        Me.rbCodPrestamo.Text = "&Código de Préstamo"
        Me.rbCodPrestamo.UseVisualStyleBackColor = False
        '
        'rbNomAbogado
        '
        Me.rbNomAbogado.BackColor = System.Drawing.Color.White
        Me.rbNomAbogado.Location = New System.Drawing.Point(16, 24)
        Me.rbNomAbogado.Name = "rbNomAbogado"
        Me.rbNomAbogado.Size = New System.Drawing.Size(168, 24)
        Me.rbNomAbogado.TabIndex = 0
        Me.rbNomAbogado.Text = "&Nombre Abogado"
        Me.rbNomAbogado.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "30,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 193)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(738, 255)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 38
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(185, 159)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 177
        Me.MetroButton1.Text = "Consultar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(23, 159)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 174
        Me.MetroButton2.Text = "Agregar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(104, 159)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 175
        Me.MetroButton3.Text = "Modificar"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(266, 159)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton4.TabIndex = 176
        Me.MetroButton4.Text = "Eliminar"
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(648, 49)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 178
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'frmMBCEmbargos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(784, 501)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMBCEmbargos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Embargos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ActualizaGrid()
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim ds As New Data.DataSet
        Try
            ds = oCred.ConsultarBCEmbargos("*", "", "FechaEntAbogado,CodPrestamo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error en la recuperción de los datos", MsgBoxStyle.Critical, "Módulo - Créditos")
        End Try
        Encabezado()
    End Sub

    Private Sub Encabezado()
        fg.Cols.Item(1).Caption = "Código Préstamo"
        fg.Cols.Item(2).Caption = "Dui"
        fg.Cols.Item(3).Caption = "Nombre del Abogado"
        fg.Cols.Item(4).Caption = "Nombre del Tribunal"
        fg.Cols.Item(5).Caption = "Nombre Demandado I"
        fg.Cols.Item(6).Caption = "Nombre Demandado II"
        fg.Cols.Item(7).Caption = "Nombre Demandado III"
        fg.Cols.Item(8).Caption = "Fecha Entrega Abogado"
        fg.Cols.Item(9).Caption = "No Referencia"
        fg.Cols.Item(10).Caption = "Comentarios"
        fg.Cols.Item(11).Caption = "Observaciones"

        fg.Cols.Item(0).Width = 25
        fg.Cols.Item(1).Width = 200
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 250
        fg.Cols.Item(4).Width = 200
        fg.Cols.Item(5).Width = 200
        fg.Cols.Item(6).Width = 200
        fg.Cols.Item(7).Width = 100
        fg.Cols.Item(8).Width = 250
        fg.Cols.Item(9).Width = 250
        fg.Cols.Item(10).Width = 250
        fg.Cols.Item(11).Width = 250

    End Sub




    Private Sub frmMBCEmbargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
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

    Private Sub rbNomAbogado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNomAbogado.CheckedChanged
        Me.txtNombreAbogado.Focus()
    End Sub

    Private Sub rbCodPrestamo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodPrestamo.CheckedChanged
        Me.txtCodPrestamo.Focus()
    End Sub

    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNombreAbogado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreAbogado.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim ofrm As New frmMsCBEmbargos
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            ActualizaGrid()
            Encabezado()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            Dim ofrm As New frmMsCBEmbargos
            If fg.Row <> -1 Then
                ds = oCred.ConsultarBCEmbargos("*", "CodPrestamo='" & Trim(fg.Item(fg.Row, "CodPrestamo")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.txtDui.Value = dr("Dui")
                ofrm.txtDui.Enabled = False
                ofrm.txtNit.Enabled = False
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.txtCodPrestamo.Text = dr("CodPrestamo")
                ofrm.txtCodPrestamo.Enabled = False
                ofrm.txtNombreAbogado.Text = dr("NombreAbogado")
                ofrm.txtNombreTribunal.Text = dr("NombreTribunal")
                ofrm.txtDemandadoI.Text = dr("DemandadoI")
                ofrm.txtDemandadoII.Text = dr("DemandadoII")
                ofrm.txtDemandadoIII.Text = dr("DemandadoIII")
                ofrm.dtpFechaEntAbogado.Value = dr("FechaEntAbogado")
                ofrm.txtNoReferencia.Text = dr("NoReferencia")
                ofrm.txtComentario.Text = dr("Comentarios")
                ofrm.txtObservaciones.Text = dr("Observaciones")
                ofrm.cbTipoEmbargo.SelectedIndex = dr("TipoEmbargo")
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizaGrid()
                Encabezado()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred

            If fg.Row <> -1 Then
                oCred.EliminarBCEmbargos("'" & Trim(fg.Item(fg.Row, "CodPrestamo")) & "'", sUsuario, sPassword, sSucursal)
                oCred.EliminarCBBienesEmbargados("CodPrestamo='" & Trim(fg.Item(fg.Row, "CodPrestamo")) & "'", sUsuario, sPassword, sSucursal)
            End If
            ActualizaGrid()
            Encabezado()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            Dim ofrm As New frmMsCBEmbargos
            If fg.Row <> -1 Then
                ds = oCred.ConsultarBCEmbargos("*", "CodPrestamo='" & Trim(fg.Item(fg.Row, "CodPrestamo")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.txtDui.Value = dr("Dui")
                ofrm.txtDui.Enabled = False
                ofrm.txtNit.Enabled = False
                ofrm.btnGuardar1.Text = "&Modificar"
                ofrm.btnGuardar1.Enabled = False
                ofrm.txtCodPrestamo.Text = dr("CodPrestamo")
                ofrm.txtCodPrestamo.ReadOnly = True
                ofrm.txtNombreAbogado.Text = dr("NombreAbogado")
                ofrm.txtNombreTribunal.Text = dr("NombreTribunal")
                ofrm.txtDemandadoI.Text = dr("DemandadoI")
                ofrm.txtDemandadoII.Text = dr("DemandadoII")
                ofrm.txtDemandadoIII.Text = dr("DemandadoIII")
                ofrm.dtpFechaEntAbogado.Value = dr("FechaEntAbogado")
                ofrm.txtNoReferencia.Text = dr("NoReferencia")
                ofrm.txtComentario.Text = dr("Comentarios")
                ofrm.txtObservaciones.Text = dr("Observaciones")
                ofrm.cbTipoEmbargo.SelectedIndex = dr("TipoEmbargo")
                ofrm.cbTipoEmbargo.Enabled = False
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizaGrid()
                Encabezado()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try

            Dim oAsoc As New wrAsociados.wsLibAsoc, dr As DataRow
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim ds As New Data.DataSet

            If Me.rbCodPrestamo.Checked = True Then
                ds = oCred.ConsultarBCEmbargos("*", "CodPrestamo='" & Trim(Me.txtCodPrestamo.Text) & "'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbNomAbogado.Checked = True Then
                ds = oCred.ConsultarBCEmbargos("*", "NombreAbogado LIKE '" & Trim(Me.txtNombreAbogado.Text) & "%'", "", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf Me.rbTodos.Checked = True Then
                ds = oCred.ConsultarBCEmbargos("*", "", "CodPrestamo", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            ElseIf rbNombres.Checked = True Then
                If cbNombres.SelectedIndex = 0 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido1 = '" & Trim(txtNombres.Text) & "'", "Apellido1,Apellido2", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 1 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido2 = '" & Trim(txtNombres.Text) & "'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 2 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Nombres ='" & Trim(txtNombres.Text) & "'", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    ds = oCred.ConsultarBCEmbargos("*", "Dui='" & dr("Dui") & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                    fg.DataSource = ds.Tables(0)
                End If
            End If
            Encabezado()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class