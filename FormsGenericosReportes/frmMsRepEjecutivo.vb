Public Class frmMsRepEjecutivo
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Private vTipo As String

    Public Property Tipo() As String
        Get
            Return vTipo
        End Get
        Set(ByVal Value As String)
            vTipo = Value
        End Set
    End Property

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGestor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodGestor As System.Windows.Forms.TextBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtGestor = New System.Windows.Forms.TextBox()
        Me.txtCodGestor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpR2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpR1 = New System.Windows.Forms.DateTimePicker()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.txtGestor)
        Me.GroupBox1.Controls.Add(Me.txtCodGestor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpR2)
        Me.GroupBox1.Controls.Add(Me.dtpR1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkTodos
        '
        Me.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodos.Location = New System.Drawing.Point(312, 40)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(64, 16)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "&Todos"
        Me.chkTodos.Visible = False
        '
        'txtGestor
        '
        Me.txtGestor.BackColor = System.Drawing.Color.White
        Me.txtGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGestor.Location = New System.Drawing.Point(80, 64)
        Me.txtGestor.MaxLength = 100
        Me.txtGestor.Name = "txtGestor"
        Me.txtGestor.ReadOnly = True
        Me.txtGestor.Size = New System.Drawing.Size(296, 20)
        Me.txtGestor.TabIndex = 4
        '
        'txtCodGestor
        '
        Me.txtCodGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodGestor.Location = New System.Drawing.Point(16, 64)
        Me.txtCodGestor.MaxLength = 20
        Me.txtCodGestor.Name = "txtCodGestor"
        Me.txtCodGestor.Size = New System.Drawing.Size(56, 20)
        Me.txtCodGestor.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Codigo de Ejecutivo:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(176, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Desde:"
        '
        'dtpR2
        '
        Me.dtpR2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR2.Location = New System.Drawing.Point(224, 16)
        Me.dtpR2.Name = "dtpR2"
        Me.dtpR2.Size = New System.Drawing.Size(88, 20)
        Me.dtpR2.TabIndex = 1
        '
        'dtpR1
        '
        Me.dtpR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR1.Location = New System.Drawing.Point(64, 16)
        Me.dtpR1.Name = "dtpR1"
        Me.dtpR1.Size = New System.Drawing.Size(88, 20)
        Me.dtpR1.TabIndex = 0
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(310, 165)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(107, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 44
        Me.btnProcesar1.Text = "&Procesar Reporte"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmMsRepEjecutivo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(438, 240)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsRepEjecutivo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtCodGestor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodGestor.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Ejecutivos"
        Dim oPerif As wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxFiltro("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodGestor.Text = ofrm.Resultado.Trim
            Me.txtGestor.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub frmRptConcentracionGestion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpR1.Value = Now
        Me.dtpR2.Value = Now
    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            If vTipo = "0" Then

                Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                ds = oPrest.RepMembresiaColocacionCaptacion(Me.dtpR1.Value, Me.dtpR2.Value, Me.txtCodGestor.Text.Trim, Me.chkTodos.Checked, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 196, 0)
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class