Public Class frmMAhFechasCap
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents rbDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMAhFechasCap))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.rbDescripcion = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
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
        Me.fg.Location = New System.Drawing.Point(30, 223)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(624, 174)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 44
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cbMes)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.rbDescripcion)
        Me.GroupBox2.Controls.Add(Me.rbCodigo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 104)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Fechas Capitalización por:"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMes.Location = New System.Drawing.Point(209, 63)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(164, 24)
        Me.cbMes.TabIndex = 136
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(383, 28)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(182, 27)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(19, 65)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(183, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(383, 55)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 33)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 181
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'rbDescripcion
        '
        Me.rbDescripcion.BackColor = System.Drawing.Color.White
        Me.rbDescripcion.Location = New System.Drawing.Point(209, 28)
        Me.rbDescripcion.Name = "rbDescripcion"
        Me.rbDescripcion.Size = New System.Drawing.Size(161, 27)
        Me.rbDescripcion.TabIndex = 2
        Me.rbDescripcion.Text = "&Fecha"
        Me.rbDescripcion.UseVisualStyleBackColor = False
        '
        'rbCodigo
        '
        Me.rbCodigo.BackColor = System.Drawing.Color.White
        Me.rbCodigo.Location = New System.Drawing.Point(19, 28)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(183, 27)
        Me.rbCodigo.TabIndex = 0
        Me.rbCodigo.Text = "&Código Tipo de Ahorro"
        Me.rbCodigo.UseVisualStyleBackColor = False
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(319, 183)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 33)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 182
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 183)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 33)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 180
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 183)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 33)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 179
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(222, 183)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 33)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 183
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'frmMAhFechasCap
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(687, 455)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMAhFechasCap"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Fechas Capitalización"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Encabezado()

        fg.Cols.Item("Correlativo").Caption = "No."
        fg.Cols.Item("CodTipoAhorro").Caption = "Cód. Tipo"
        fg.Cols.Item("Descripcion").Caption = "Tipo de Ahorro"
        fg.Cols.Item("Fecha").Caption = "Día/Mes"

        fg.Cols.Item("Correlativo").Width = 100
        fg.Cols.Item("CodTipoAhorro").Width = 100
        fg.Cols.Item("Descripcion").Width = 200
        fg.Cols.Item("Fecha").Width = 100
        fg.Cols.Item("Fecha").Format = "dd/MM"

    End Sub

    Private Sub ActualizaGrid()
        Dim oAh As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarFechasCapitalizacionTipo("a.Correlativo,a.CodTipoAhorro,b.Descripcion,a.Fecha", "", "a.CodTipoAhorro,a.Correlativo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
        Encabezado()
    End Sub

    Private Sub frmMAhFechasCap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrid()
        Me.cbMes.SelectedIndex = 0
        Me.WindowState = FormWindowState.Normal
        txtCodigo.Enabled = False
    End Sub



    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        btnConsultar1_Click(sender, e)
    End Sub



    Private Sub rbCodigo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbCodigo.CheckedChanged
        If rbCodigo.Checked = True Then
            txtCodigo.Enabled = True
        ElseIf rbCodigo.Checked = False Then
            txtCodigo.Enabled = False
        End If
        Me.txtCodigo.Focus()
    End Sub

    Private Sub rbDescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDescripcion.CheckedChanged
        Me.cbMes.Focus()
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub cbMes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbMes.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click

        Dim oCred As wrAhorro.wsLibAhorro, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection, pCodigo As String
        Try
            oCred = New wrAhorro.wsLibAhorro
            If rbCodigo.Checked = True Then
                ds = oCred.ConsultarFechasCapitalizacionTipo("a.Correlativo,a.CodTipoAhorro,b.Descripcion,a.Fecha", "a.CodTipoAhorro='" & Trim(txtCodigo.Text) & "'", "a.Correlativo,a.Fecha", sUsuario, sPassword, sSucursal)
            ElseIf rbDescripcion.Checked = True Then
                ds = oCred.ConsultarFechasCapitalizacionTipo("a.Correlativo,a.CodTipoAhorro,b.Descripcion,a.Fecha", "Month(a.Fecha)='" & Me.cbMes.SelectedIndex + 1 & "'", "a.CodTipoAhorro,a.Fecha", sUsuario, sPassword, sSucursal)
            ElseIf rbTodos.Checked = True Then
                ds = oCred.ConsultarFechasCapitalizacionTipo("a.Correlativo,a.CodTipoAhorro,b.Descripcion,a.Fecha", "", "a.CodTipoAhorro,a.Correlativo", sUsuario, sPassword, sSucursal)
            End If
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsAhFechasCap = New frmMsAhFechasCap
            frm.pAccion = "Agregar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try

            If fg.Row <> -1 Then
                Dim frm As frmMsAhFechasCap = New frmMsAhFechasCap
                frm.pAccion = "Modificar"
                frm.pCodigo = fg.Item(fg.Row, "CodTipoAhorro")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                txtCodigo.Enabled = False
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If fg.Row <> -1 Then
                If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Fechas de Capitalización") = MsgBoxResult.Yes Then
                    Dim oCred As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oCred.EliminarFechasCapitalizacion(fg.Item(fg.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                    txtCodigo.Enabled = False
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As frmMsAhFechasCap = New frmMsAhFechasCap
                frm.pAccion = "Modificar"
                frm.pCodigo = fg.Item(fg.Row, "CodTipoAhorro")
                frm.btNProcesar1.Enabled = False
                frm.MetroButton1.Enabled = False
                frm.btNProcesar1.Text = "&Consulta"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
                txtCodigo.Enabled = False
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMAhFechasCap_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class