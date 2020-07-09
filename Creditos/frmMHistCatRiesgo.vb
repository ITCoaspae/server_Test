Public Class frmMHistCatRiesgo
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Private ds As DataSet

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
    Friend WithEvents C1fgrdPrestamos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents txtdelCodPrest As System.Windows.Forms.TextBox
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCat As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMHistCatRiesgo))
        Me.C1fgrdPrestamos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.txtdelCodPrest = New System.Windows.Forms.TextBox()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1fgrdPrestamos
        '
        Me.C1fgrdPrestamos.AllowEditing = False
        Me.C1fgrdPrestamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdPrestamos.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdPrestamos.BackColor = System.Drawing.Color.White
        Me.C1fgrdPrestamos.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdPrestamos.Location = New System.Drawing.Point(28, 211)
        Me.C1fgrdPrestamos.Name = "C1fgrdPrestamos"
        Me.C1fgrdPrestamos.Rows.Count = 2
        Me.C1fgrdPrestamos.Rows.DefaultSize = 21
        Me.C1fgrdPrestamos.Size = New System.Drawing.Size(781, 206)
        Me.C1fgrdPrestamos.StyleInfo = resources.GetString("C1fgrdPrestamos.StyleInfo")
        Me.C1fgrdPrestamos.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtCat)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.rbNoSocio)
        Me.GroupBox2.Controls.Add(Me.txtdelCodPrest)
        Me.GroupBox2.Controls.Add(Me.rbDui)
        Me.GroupBox2.Controls.Add(Me.rbCodigo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(778, 131)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por filtro:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(110, 92)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(168, 33)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 231
        Me.MetroButton1.Text = "&Generar Reporte"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(13, 92)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 33)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 230
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtCat
        '
        Me.txtCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCat.Location = New System.Drawing.Point(631, 23)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(135, 22)
        Me.txtCat.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Seleccione el año de consulta:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(209, 23)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.ShowUpDown = True
        Me.dtpFecha.Size = New System.Drawing.Size(67, 22)
        Me.dtpFecha.TabIndex = 0
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(350, 23)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(135, 23)
        Me.txtDui.TabIndex = 2
        Me.txtDui.Tag = Nothing
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(283, 55)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(202, 22)
        Me.txtNombres.TabIndex = 7
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(13, 54)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(88, 19)
        Me.rbNombres.TabIndex = 5
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(108, 54)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(168, 24)
        Me.cbNombres.TabIndex = 6
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.ForeColor = System.Drawing.Color.Black
        Me.rbNoSocio.Location = New System.Drawing.Point(492, 25)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(132, 19)
        Me.rbNoSocio.TabIndex = 3
        Me.rbNoSocio.Text = "Categoría Riesgo"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        '
        'txtdelCodPrest
        '
        Me.txtdelCodPrest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdelCodPrest.Location = New System.Drawing.Point(631, 55)
        Me.txtdelCodPrest.Name = "txtdelCodPrest"
        Me.txtdelCodPrest.Size = New System.Drawing.Size(135, 22)
        Me.txtdelCodPrest.TabIndex = 9
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Location = New System.Drawing.Point(283, 22)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(60, 28)
        Me.rbDui.TabIndex = 1
        Me.rbDui.Text = "DUI:"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'rbCodigo
        '
        Me.rbCodigo.BackColor = System.Drawing.Color.White
        Me.rbCodigo.Checked = True
        Me.rbCodigo.Location = New System.Drawing.Point(492, 50)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(89, 27)
        Me.rbCodigo.TabIndex = 8
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Préstamo"
        Me.rbCodigo.UseVisualStyleBackColor = False
        '
        'frmMHistCatRiesgo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(836, 474)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.C1fgrdPrestamos)
        Me.Name = "frmMHistCatRiesgo"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta Historial de Categorías de Riesgo"
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMPrestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
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

    Private Sub rbDui_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
        Me.txtDui.Focus()
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim oCred As New wrCredito.wsLibCred
        Try
            If Me.rbCodigo.Checked = True Then
                ds = oCred.ReporteHistorialCategoria(Me.dtpFecha.Value.Year, "a.CodPrestamo='" & Me.txtdelCodPrest.Text.Trim & "'", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbDui.Checked = True Then
                ds = oCred.ReporteHistorialCategoria(Me.dtpFecha.Value.Year, "a.Dui='" & Me.txtDui.Text & "'", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbNombres.Checked = True Then
                If cbNombres.SelectedIndex = 0 Then
                    ds = oCred.ReporteHistorialCategoria(Me.dtpFecha.Value.Year, "b.Nombres like '" & Me.txtNombres.Text.Trim & "%'", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 1 Then
                    ds = oCred.ReporteHistorialCategoria(Me.dtpFecha.Value.Year, "b.Apellido1 like '" & Me.txtNombres.Text.Trim & "%'", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 2 Then
                    ds = oCred.ReporteHistorialCategoria(Me.dtpFecha.Value.Year, "b.Apellido2 like '" & Me.txtNombres.Text.Trim & "%'", sUsuario, sPassword, sSucursal)
                End If
            ElseIf Me.rbNoSocio.Checked = True Then
                ds = oCred.ReporteHistorialCategoria(Me.dtpFecha.Value.Year, "Categoria='" & Me.txtCat.Text.Trim & "'", sUsuario, sPassword, sSucursal)
            End If
            Me.C1fgrdPrestamos.DataSource = ds.Tables("Datos")
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim frm As New frmVisor(ds, 198, 0)
            frm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class