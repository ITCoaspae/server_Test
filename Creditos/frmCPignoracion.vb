Public Class frmCPignoracion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim oAsoc As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
    Friend WithEvents btnGenerar1 As MetroFramework.Controls.MetroButton
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
    Friend WithEvents fgEstadoIngreso As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCodPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCPignoracion))
        Me.fgEstadoIngreso = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGenerar1 = New MetroFramework.Controls.MetroButton()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbtCodPrestamo = New System.Windows.Forms.RadioButton()
        CType(Me.fgEstadoIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fgEstadoIngreso
        '
        Me.fgEstadoIngreso.AllowEditing = False
        Me.fgEstadoIngreso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgEstadoIngreso.BackColor = System.Drawing.Color.White
        Me.fgEstadoIngreso.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:97;Style:""TextAlign:RightCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{" &
    "Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "5{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgEstadoIngreso.Location = New System.Drawing.Point(28, 220)
        Me.fgEstadoIngreso.Name = "fgEstadoIngreso"
        Me.fgEstadoIngreso.Rows.Count = 2
        Me.fgEstadoIngreso.Rows.DefaultSize = 21
        Me.fgEstadoIngreso.Size = New System.Drawing.Size(579, 147)
        Me.fgEstadoIngreso.StyleInfo = resources.GetString("fgEstadoIngreso.StyleInfo")
        Me.fgEstadoIngreso.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnGenerar1)
        Me.GroupBox2.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.rbtCodPrestamo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 140)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione el filtro:"
        '
        'btnGenerar1
        '
        Me.btnGenerar1.Location = New System.Drawing.Point(382, 92)
        Me.btnGenerar1.Name = "btnGenerar1"
        Me.btnGenerar1.Size = New System.Drawing.Size(90, 33)
        Me.btnGenerar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGenerar1.TabIndex = 167
        Me.btnGenerar1.Text = "Mostrar"
        Me.btnGenerar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGenerar1.UseSelectable = True
        Me.btnGenerar1.UseStyleColors = True
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Location = New System.Drawing.Point(161, 83)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(182, 22)
        Me.txtCodPrestamo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(161, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Código de Préstamo:"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(19, 83)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(135, 23)
        Me.txtDui.TabIndex = 8
        Me.txtDui.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Dui de Asociado:"
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.White
        Me.rbTodos.ForeColor = System.Drawing.Color.Black
        Me.rbTodos.Location = New System.Drawing.Point(350, 58)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(183, 27)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.Text = "Mostrar &todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'rbtCodPrestamo
        '
        Me.rbtCodPrestamo.BackColor = System.Drawing.Color.White
        Me.rbtCodPrestamo.Checked = True
        Me.rbtCodPrestamo.ForeColor = System.Drawing.Color.Black
        Me.rbtCodPrestamo.Location = New System.Drawing.Point(19, 28)
        Me.rbtCodPrestamo.Name = "rbtCodPrestamo"
        Me.rbtCodPrestamo.Size = New System.Drawing.Size(183, 27)
        Me.rbtCodPrestamo.TabIndex = 0
        Me.rbtCodPrestamo.TabStop = True
        Me.rbtCodPrestamo.Text = "Préstamo:"
        Me.rbtCodPrestamo.UseVisualStyleBackColor = False
        '
        'frmCPignoracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(635, 427)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fgEstadoIngreso)
        Me.Name = "frmCPignoracion"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta de Pignoración"
        CType(Me.fgEstadoIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCPignoracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultarPignoracion("")
        fgEstadoIngreso.Cols(5).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
        fgEstadoIngreso.Cols(9).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
    End Sub

    Private Sub consultarPignoracion(ByVal codPrestamo As String)
        Try
            oAsoc = New wrAhorro.wsLibAhorro
            ds = oAsoc.ConsultarPignoracion(codPrestamo, sUsuario, sPassword, sSucursal)
            fgEstadoIngreso.DataSource = ds.Tables(0)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.CargarListaPrestamos(False, "", "", Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                dr = ds.Tables("Prestamo").Rows(0)
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Correlativo,NoSocio,Apellido1,Apellido2,Nombres", "", "Correlativo", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDui.Validating
        If Me.txtDui.Text.Trim = "" Then Exit Sub

        Dim sTexto As String
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Value
            If sTexto = "" Then      'Filtrar Registros
            ElseIf sTexto <> "" Then
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
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

    Private Sub rbtCodPrestamo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtCodPrestamo.CheckedChanged
        Me.txtDui.Focus()
    End Sub

    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try
            If Me.rbTodos.Checked = True Then
                consultarPignoracion("")
            Else
                consultarPignoracion(txtCodPrestamo.Text.ToString)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

End Class