Public Class frmRepAhVencimientos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ahorro As New wrAhorro.wsLibAhorro
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbTipoAhorro As MetroFramework.Controls.MetroComboBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.cbTipoAhorro = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'chkTodos
        '
        Me.chkTodos.ForeColor = System.Drawing.Color.Black
        Me.chkTodos.Location = New System.Drawing.Point(23, 137)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(268, 18)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "&Todos los tipos"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 18)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Tipo de Ahorro:"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Desde Fecha:"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(291, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Hasta la Fecha:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(414, 72)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(139, 23)
        Me.dtpFecha2.TabIndex = 1
        '
        'dtpFecha1
        '
        Me.dtpFecha1.CustomFormat = ""
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha1.Location = New System.Drawing.Point(146, 72)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(139, 23)
        Me.dtpFecha1.TabIndex = 0
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(453, 137)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 223
        Me.MetroButton1.Text = "Reporte"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'cbTipoAhorro
        '
        Me.cbTipoAhorro.FormattingEnabled = True
        Me.cbTipoAhorro.ItemHeight = 24
        Me.cbTipoAhorro.Items.AddRange(New Object() {"-- SELECCIONE TIPO DE AHORRO -- ", "AHORRO A LA VISTA", "AHORRO PROGRAMADO", "AHORRO RESTRINGIDO", "DEPOSITOS A PLAZO"})
        Me.cbTipoAhorro.Location = New System.Drawing.Point(146, 101)
        Me.cbTipoAhorro.Name = "cbTipoAhorro"
        Me.cbTipoAhorro.Size = New System.Drawing.Size(407, 30)
        Me.cbTipoAhorro.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbTipoAhorro.TabIndex = 224
        Me.cbTipoAhorro.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cbTipoAhorro.UseCustomBackColor = True
        Me.cbTipoAhorro.UseCustomForeColor = True
        Me.cbTipoAhorro.UseSelectable = True
        Me.cbTipoAhorro.UseStyleColors = True
        '
        'frmRepAhVencimientos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(592, 221)
        Me.Controls.Add(Me.cbTipoAhorro)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(518, 185)
        Me.Name = "frmRepAhVencimientos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Listado de Vencimientos "
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim vTipo As String

    Public Property Tipo() As String
        Get
            Return vTipo
        End Get
        Set(ByVal Value As String)
            vTipo = Value
        End Set
    End Property
    Protected Sub llenarTipoAhorro()
        Dim dts As New DataSet
        cbTipoAhorro.DisplayMember = "Descripcion"
        cbTipoAhorro.ValueMember = "codTipoAhorro"
        dts = ahorro.ConsultarTipoAhorro("codTipoAhorro,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        cbTipoAhorro.DataSource = dts.Tables(0)
    End Sub
    Private Sub frmRepAhVencimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha1.Value = Now
        Me.dtpFecha2.Value = Now
        'llenarTipoAhorro()
    End Sub







    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = True Then
            cbTipoAhorro.Enabled = False
        Else
            cbTipoAhorro.Enabled = True
        End If
    End Sub
    Dim pTipoAhorro As String
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Me.Cursor = Cursors.WaitCursor

        Try
            Dim ds As New DataSet, vTodos As Boolean
            Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
            If Me.vTipo = "P" Then
                'pTipoAhorro = Mid(cbTipoAhorro.SelectedValue, 1, 1)
                ds = oAh.RepVencimientos(Me.dtpFecha1.Value, Me.dtpFecha2.Value, pTipoAhorro, Me.chkTodos.Checked, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 48, 0)
                ofrm.Text = "VENCIMIENTO CUENTAS DE AHORROS"
                
                ofrm.Show()
            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbTipoAhorro_Validated(sender As Object, e As EventArgs) Handles cbTipoAhorro.Validated

        If cbTipoAhorro.SelectedIndex = 1 Then
            pTipoAhorro = "3"
        ElseIf cbTipoAhorro.SelectedIndex = 2 Then
            pTipoAhorro = "4"
        ElseIf cbTipoAhorro.SelectedIndex = 3 Then
            pTipoAhorro = "5"
        ElseIf cbTipoAhorro.SelectedIndex = 4 Then
            pTipoAhorro = "6"
        End If
    End Sub

    Private Sub frmRepAhVencimientos_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class