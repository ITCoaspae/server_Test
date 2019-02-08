Public Class frmRepAhVencimientos
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.txtTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(19, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione datos del Reporte"
        '
        'chkTodos
        '
        Me.chkTodos.ForeColor = System.Drawing.Color.Black
        Me.chkTodos.Location = New System.Drawing.Point(16, 64)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(120, 16)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "&Todos los tipos"
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.AcceptsReturn = True
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(96, 88)
        Me.txtCodTipoAhorro.MaxLength = 10
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(80, 20)
        Me.txtCodTipoAhorro.TabIndex = 3
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAhorro.Location = New System.Drawing.Point(184, 88)
        Me.txtTipoAhorro.MaxLength = 110
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.Size = New System.Drawing.Size(216, 20)
        Me.txtTipoAhorro.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Tipo de Ahorro:"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Desde Fecha:"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(208, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Hasta la Fecha:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(304, 32)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha2.TabIndex = 1
        '
        'dtpFecha1
        '
        Me.dtpFecha1.CustomFormat = ""
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha1.Location = New System.Drawing.Point(96, 32)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha1.TabIndex = 0
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(352, 189)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(83, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 223
        Me.MetroButton1.Text = "Reporte"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmRepAhVencimientos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(452, 230)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(432, 160)
        Me.Name = "frmRepAhVencimientos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Listado de Vencimientos "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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

    Private Sub frmRepAhVencimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha1.Value = Now
        Me.dtpFecha2.Value = Now
    End Sub



    Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick
        Dim ofrm As New frmAGenerico

        Try

            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection, dr As DataRow
            If Me.vTipo = "D" Then
                ds = oAhorro.ConsultarTipoAhorro("*", "left(CodTipoAhorro,1)='2'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            Else
                ds = oAhorro.ConsultarTipoAhorro("*", "left(CodTipoAhorro,1)<>'1' and left(CodTipoAhorro,1)<>'2' and left(CodTipoAhorro,1)<>'3'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            End If
            ofrm.Text = "Buscar Tipos de Ahorro"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()

            If ofrm.Resultado.Trim = "" Then Exit Sub

            txtCodTipoAhorro.Text = ofrm.Resultado.Trim
            txtTipoAhorro.Text = ofrm.Resultado2.Trim

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipos de Ahorro - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = True Then
            Me.txtCodTipoAhorro.Text = ""
            Me.txtCodTipoAhorro.Enabled = False
        Else
            Me.txtCodTipoAhorro.Enabled = True
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim pTipoAhorro As String
        Me.Cursor = Cursors.WaitCursor

        Try
            Dim ds As New DataSet, vTodos As Boolean
            Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
            If Me.vTipo = "P" Then
                pTipoAhorro = Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1)
                ds = oAh.RepVencimientos(Me.dtpFecha1.Value, Me.dtpFecha2.Value, pTipoAhorro, Me.chkTodos.Checked, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 48, 0)
                ofrm.Text = "VENCIMIENTO CUENTAS DE AHORROS"
                ofrm.MdiParent = ofrmMain
                ofrm.Show()
            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("No hay datos disponibles.", "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class