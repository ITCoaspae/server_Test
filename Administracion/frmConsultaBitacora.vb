Public Class frmConsultaBitacora
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents dg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTabla As System.Windows.Forms.TextBox
    Friend WithEvents chkUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents chkTabla As System.Windows.Forms.CheckBox
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaBitacora))
        Me.dg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.chkTabla = New System.Windows.Forms.CheckBox()
        Me.chkUsuario = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtTabla = New System.Windows.Forms.TextBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowEditing = False
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.BackColor = System.Drawing.Color.White
        Me.dg.ColumnInfo = "9,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.dg.ForeColor = System.Drawing.Color.Black
        Me.dg.Location = New System.Drawing.Point(28, 181)
        Me.dg.Name = "dg"
        Me.dg.Rows.Count = 2
        Me.dg.Rows.DefaultSize = 21
        Me.dg.Size = New System.Drawing.Size(572, 203)
        Me.dg.StyleInfo = resources.GetString("dg.StyleInfo")
        Me.dg.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.chkFecha)
        Me.GroupBox2.Controls.Add(Me.chkTabla)
        Me.GroupBox2.Controls.Add(Me.chkUsuario)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.txtUsuario)
        Me.GroupBox2.Controls.Add(Me.txtTabla)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(693, 90)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar Registros por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(596, 46)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 32)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 226
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'chkFecha
        '
        Me.chkFecha.Location = New System.Drawing.Point(386, 22)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(125, 28)
        Me.chkFecha.TabIndex = 4
        Me.chkFecha.Text = "&Fecha"
        '
        'chkTabla
        '
        Me.chkTabla.Location = New System.Drawing.Point(197, 22)
        Me.chkTabla.Name = "chkTabla"
        Me.chkTabla.Size = New System.Drawing.Size(125, 28)
        Me.chkTabla.TabIndex = 2
        Me.chkTabla.Text = "&Tabla"
        '
        'chkUsuario
        '
        Me.chkUsuario.Location = New System.Drawing.Point(7, 22)
        Me.chkUsuario.Name = "chkUsuario"
        Me.chkUsuario.Size = New System.Drawing.Size(125, 28)
        Me.chkUsuario.TabIndex = 0
        Me.chkUsuario.Text = "&Usuario"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(386, 55)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(183, 22)
        Me.dtpFecha.TabIndex = 5
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(7, 55)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(183, 22)
        Me.txtUsuario.TabIndex = 1
        '
        'txtTabla
        '
        Me.txtTabla.Location = New System.Drawing.Point(197, 55)
        Me.txtTabla.Name = "txtTabla"
        Me.txtTabla.Size = New System.Drawing.Size(182, 22)
        Me.txtTabla.TabIndex = 3
        '
        'frmConsultaBitacora
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(628, 446)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dg)
        Me.Name = "frmConsultaBitacora"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta Bitácora"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmConsultaBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim oAdm As New wrAdmin.wsLibAdmin, ds As New DataSet
            Me.dtpFecha.Value = Now
            ds = oAdm.ConsultarBitacora(wrAdmin.TipoBusquedaBitacora.porRangoFechas, Me.dtpFecha.Value.ToShortDateString, Me.dtpFecha.Value.ToShortDateString, wrAdmin.Modulos.Todos, "", "", sUsuario, sPassword, sSucursal)
            dg.DataSource = ds.Tables(0)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub rbtUsuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtUsuario.Focus()
    End Sub

    Private Sub rbTabla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtTabla.Focus()
    End Sub

    Private Sub rbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.dtpFecha.Focus()
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtTabla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTabla.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub dtpFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyData = Keys.Return Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            Dim oAdm As New wrAdmin.wsLibAdmin, ds As Data.DataSet = New Data.DataSet, pFiltro As String
            pFiltro = ""

            If Me.chkFecha.Checked = False And Me.chkTabla.Checked = False And Me.chkUsuario.Checked = False Then
                MessageBox.Show("Debe seleccionar una opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Me.chkUsuario.Checked = True Then
                pFiltro = "Usuario='" & Me.txtUsuario.Text.Trim & "'"
            End If
            If Me.chkTabla.Checked = True Then
                If pFiltro.Trim = "" Then
                    pFiltro = "Tabla='" & Me.txtTabla.Text.Trim & "'"
                Else
                    pFiltro = pFiltro & " and Tabla='" & Me.txtTabla.Text.Trim & "'"
                End If
            End If
            If Me.chkFecha.Checked = True Then
                If pFiltro.Trim = "" Then
                    pFiltro = "Fecha='" & Me.dtpFecha.Value.ToShortDateString & "'"
                Else
                    pFiltro = pFiltro & " and Fecha='" & Me.dtpFecha.Value.ToShortDateString & "'"
                End If
            End If
            ds = oAdm.ConsultarBitacoraxFiltro(pFiltro, sUsuario, sPassword, sSucursal)
            dg.DataSource = ds.Tables(0)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmConsultaBitacora_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class