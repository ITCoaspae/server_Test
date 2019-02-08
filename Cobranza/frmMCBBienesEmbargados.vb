Public Class frmMCBBienesEMbargados
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
    Friend WithEvents rbCodPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodBienEmbargado As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodBienEmbargado As System.Windows.Forms.TextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCBBienesEMbargados))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.txtCodBienEmbargado = New System.Windows.Forms.TextBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbCodPrestamo = New System.Windows.Forms.RadioButton()
        Me.rbCodBienEmbargado = New System.Windows.Forms.RadioButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox2.Controls.Add(Me.txtCodBienEmbargado)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbCodPrestamo)
        Me.GroupBox2.Controls.Add(Me.rbCodBienEmbargado)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 94)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Ingresos por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(332, 48)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 181
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Location = New System.Drawing.Point(174, 54)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(152, 20)
        Me.txtCodPrestamo.TabIndex = 7
        '
        'txtCodBienEmbargado
        '
        Me.txtCodBienEmbargado.Location = New System.Drawing.Point(16, 56)
        Me.txtCodBienEmbargado.Name = "txtCodBienEmbargado"
        Me.txtCodBienEmbargado.Size = New System.Drawing.Size(152, 20)
        Me.txtCodBienEmbargado.TabIndex = 6
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(332, 24)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(75, 24)
        Me.rbTodos.TabIndex = 4
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
        'rbCodBienEmbargado
        '
        Me.rbCodBienEmbargado.BackColor = System.Drawing.Color.White
        Me.rbCodBienEmbargado.Location = New System.Drawing.Point(16, 24)
        Me.rbCodBienEmbargado.Name = "rbCodBienEmbargado"
        Me.rbCodBienEmbargado.Size = New System.Drawing.Size(168, 24)
        Me.rbCodBienEmbargado.TabIndex = 0
        Me.rbCodBienEmbargado.Text = "&Código Artículo Embargado"
        Me.rbCodBienEmbargado.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "30,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 206)
        Me.fg.Name = "fg"
        Me.fg.Size = New System.Drawing.Size(427, 238)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 34
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(185, 163)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 181
        Me.MetroButton1.Text = "Consultar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(23, 163)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 178
        Me.MetroButton2.Text = "Agregar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(104, 163)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 179
        Me.MetroButton3.Text = "Modificar"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(266, 163)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton4.TabIndex = 180
        Me.MetroButton4.Text = "Eliminar"
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'frmMCBBienesEMbargados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(473, 485)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMCBBienesEMbargados"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Bienes Embargados"
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
            ds = oCred.ConsultarCBBienesEmbargados("*", "", "CodBienEmbargado", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error en la recuperción de los datos", MsgBoxStyle.Critical, "Módulo - Créditos")
        End Try
        Encabezado()
    End Sub

    Private Sub Encabezado()
        fg.Cols.Item(1).Caption = "Código Artículo Embargado"
        fg.Cols.Item(2).Caption = "Código de Préstamo"
        fg.Cols.Item(3).Caption = "Fecha de Decomiso"
        fg.Cols.Item(4).Caption = "Persona que Decomisa"
        fg.Cols.Item(5).Caption = "Persona que Recibe"
        fg.Cols.Item(6).Caption = "Tipo"
        fg.Cols.Item(7).Caption = "Código Tipo Activo"
        fg.Cols.Item(8).Caption = "Producto"
        fg.Cols.Item(9).Caption = "Marca"
        fg.Cols.Item(10).Caption = "Serie"
        fg.Cols.Item(11).Caption = "Modelo"
        fg.Cols.Item(12).Caption = "Precio de Compra"
        fg.Cols.Item(13).Caption = "Valúo"
        fg.Cols.Item(14).Caption = "No Factura"
        fg.Cols.Item(15).Caption = "Estado"
        fg.Cols.Item(16).Caption = "Tipo Propietario"
        fg.Cols.Item(17).Caption = "Propietario"
        fg.Cols.Item(18).Caption = "Ubicación"
        fg.Cols.Item(19).Caption = "Observaciones"

        fg.Cols.Item(0).Width = 25
        fg.Cols.Item(1).Width = 150
        fg.Cols.Item(2).Width = 150
        fg.Cols.Item(3).Width = 250
        fg.Cols.Item(4).Width = 250
        fg.Cols.Item(5).Width = 150
        fg.Cols.Item(6).Width = 150
        fg.Cols.Item(7).Width = 150
        fg.Cols.Item(8).Width = 150
        fg.Cols.Item(9).Width = 150
        fg.Cols.Item(10).Width = 150
        fg.Cols.Item(11).Width = 150
        fg.Cols.Item(12).Width = 150
        fg.Cols.Item(13).Width = 150
        fg.Cols.Item(14).Width = 150
        fg.Cols.Item(15).Width = 150
        fg.Cols.Item(16).Width = 150
        fg.Cols.Item(17).Width = 150
        fg.Cols.Item(18).Width = 150
        fg.Cols.Item(19).Width = 150
    End Sub

    Private Sub frmMCBBienesEMbargados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
        Encabezado()
    End Sub

    Private Sub rbCodBienEmbargado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodBienEmbargado.CheckedChanged
        Me.txtCodBienEmbargado.Focus()
    End Sub

    Private Sub rbCodPrestamo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodPrestamo.CheckedChanged
        Me.txtCodPrestamo.Focus()
    End Sub

    Private Sub txtCodBienEmbargado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodBienEmbargado.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim ofrm As New frmMSCBBienesEmbargados
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
            Dim ofrm As New frmMSCBBienesEmbargados
            'Dim Estado As String, 
            Dim x As Integer

            ds = oCred.ConsultarCBBienesEmbargados("*", "CodBienEMbargado='" & Val(fg.Item(fg.Row, "CodBienEmbargado")) & "'", "", sUsuario, sPassword, sSucursal)
            dr = ds.Tables(0).Rows(0)
            ofrm.btnGuardar1.Text = "&Modificar"
            ofrm.dtpFechaDecomiso.Value = dr("FechaDecomiso")
            ofrm.txtPerDecomisa.Text = dr("NombreDecomisa")
            ofrm.txtPerRecibeDec.Text = dr("RecibeDecomiso")
            For x = 0 To ofrm.cbTipo.Items.Count - 1
                ofrm.cbTipo.SelectedIndex = x
                If Mid(ofrm.cbTipo.Text, 1, 1) = IIf(IsDBNull(dr("Tipo")), "", dr("Tipo")) Then
                    ofrm.cbTipo.SelectedIndex = x
                    Exit For
                End If
            Next
            ofrm.txtCodTipoActivo.Text = dr("CodTipoActivo")
            ofrm.txtProducto.Text = dr("Producto")
            ofrm.txtMarca.Text = dr("Marca")
            ofrm.txtSerie.Text = dr("Serie")
            ofrm.txtModelo.Text = dr("Modelo")
            ofrm.c1nPrecioCompra.Value = dr("Precio_Compra")
            ofrm.c1nValuo.Value = dr("Valuo")
            ofrm.txtNofactura.Text = dr("NoFactura")
            For x = 0 To ofrm.cbEstado.Items.Count - 1
                ofrm.cbEstado.SelectedIndex = x
                If Mid(ofrm.cbEstado.Text, 1, 1) = IIf(IsDBNull(dr("Estado")), "", dr("Estado")) Then
                    ofrm.cbEstado.SelectedIndex = x
                    Exit For
                End If
            Next
            For x = 0 To ofrm.cbTipoPropietario.Items.Count - 1
                ofrm.cbTipoPropietario.SelectedIndex = x
                If Mid(ofrm.cbTipoPropietario.Text, 1, 1) = IIf(IsDBNull(dr("TipoPropietario")), "", dr("TipoPropietario")) Then
                    ofrm.cbTipoPropietario.SelectedIndex = x
                    Exit For
                End If
            Next
            ofrm.txtPropietario.Text = dr("Propietario")
            ofrm.txtUbicacion.Text = dr("Ubicacion")
            ofrm.txtObservaciones.Text = dr("Observaciones")
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
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
            Dim ofrm As New frmMSCBBienesEmbargados
            'Dim Estado As String, 
            Dim x As Integer

            ds = oCred.ConsultarCBBienesEmbargados("*", "CodBienEMbargado='" & Val(fg.Item(fg.Row, "CodBienEmbargado")) & "'", "", sUsuario, sPassword, sSucursal)
            dr = ds.Tables(0).Rows(0)
            ofrm.btnGuardar1.Text = "&Modificar"
            ofrm.btnGuardar1.Enabled = False
            ofrm.dtpFechaDecomiso.Value = dr("FechaDecomiso")
            ofrm.txtPerDecomisa.Text = dr("NombreDecomisa")
            ofrm.txtPerRecibeDec.Text = dr("RecibeDecomiso")
            For x = 0 To ofrm.cbTipo.Items.Count - 1
                ofrm.cbTipo.SelectedIndex = x
                If Mid(ofrm.cbTipo.Text, 1, 1) = IIf(IsDBNull(dr("Tipo")), "", dr("Tipo")) Then
                    ofrm.cbTipo.SelectedIndex = x
                    Exit For
                End If
            Next
            ofrm.txtCodTipoActivo.Text = dr("CodTipoActivo")
            ofrm.txtProducto.Text = dr("Producto")
            ofrm.txtMarca.Text = dr("Marca")
            ofrm.txtSerie.Text = dr("Serie")
            ofrm.txtModelo.Text = dr("Modelo")
            ofrm.c1nPrecioCompra.Value = dr("Precio_Compra")
            ofrm.c1nValuo.Value = dr("Valuo")
            ofrm.txtNofactura.Text = dr("NoFactura")
            For x = 0 To ofrm.cbEstado.Items.Count - 1
                ofrm.cbEstado.SelectedIndex = x
                If Mid(ofrm.cbEstado.Text, 1, 1) = IIf(IsDBNull(dr("Estado")), "", dr("Estado")) Then
                    ofrm.cbEstado.SelectedIndex = x
                    Exit For
                End If
            Next
            For x = 0 To ofrm.cbTipoPropietario.Items.Count - 1
                ofrm.cbTipoPropietario.SelectedIndex = x
                If Mid(ofrm.cbTipoPropietario.Text, 1, 1) = IIf(IsDBNull(dr("TipoPropietario")), "", dr("TipoPropietario")) Then
                    ofrm.cbTipoPropietario.SelectedIndex = x
                    Exit For
                End If
            Next
            ofrm.txtPropietario.Text = dr("Propietario")
            ofrm.txtUbicacion.Text = dr("Ubicacion")
            ofrm.txtObservaciones.Text = dr("Observaciones")
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            ActualizaGrid()
            Encabezado()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred

            If fg.Row <> -1 Then
                oCred.EliminarCBBienesEmbargados(CInt(fg.Item(fg.Row, "CodBienEmbargado")), sUsuario, sPassword, sSucursal)
            End If
            ActualizaGrid()
            Encabezado()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim ds As New Data.DataSet

        If Me.rbCodBienEmbargado.Checked = True Then
            ds = oCred.ConsultarCBBienesEmbargados("*", "CodBienEmbargado=" & Val(Me.txtCodBienEmbargado.Text) & "", "", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        ElseIf Me.rbCodPrestamo.Checked = True Then
            ds = oCred.ConsultarCBBienesEmbargados("*", "CodPrestamo= '" & Trim(Me.txtCodPrestamo.Text) & "'", "", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        ElseIf Me.rbTodos.Checked = True Then
            ds = oCred.ConsultarCBBienesEmbargados("*", "", "CodBienEmbargado", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        End If
        Encabezado()
    End Sub
End Class