Public Class frmGeneraPartidaIntegracionII
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form : 
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents btnCerrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProcesar As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnCerrar = New MetroFramework.Controls.MetroButton()
        Me.btnProcesar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Del:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(163, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "al:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(196, 60)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha2.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(61, 60)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(240, 96)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(68, 28)
        Me.btnCerrar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar.TabIndex = 143
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar.UseSelectable = True
        Me.btnCerrar.UseStyleColors = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(127, 96)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(107, 28)
        Me.btnProcesar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar.TabIndex = 142
        Me.btnProcesar.Text = "Generar Partida"
        Me.btnProcesar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar.UseSelectable = True
        Me.btnProcesar.UseStyleColors = True
        '
        'frmGeneraPartidaIntegracionII
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(331, 135)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.dtpFecha2)
        Me.MaximumSize = New System.Drawing.Size(331, 135)
        Me.MinimumSize = New System.Drawing.Size(331, 135)
        Me.Name = "frmGeneraPartidaIntegracionII"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Generar Partida"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private vTipo As wrConta.PartidaIntegracion, vTitle As String

#Region "Propiedades"

    Public Property Tipo() As wrConta.PartidaIntegracion
        Get
            Return vTipo
        End Get
        Set(ByVal Value As wrConta.PartidaIntegracion)
            vTipo = Value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return vTitle
        End Get
        Set(ByVal Value As String)
            vTitle = Value
        End Set
    End Property

#End Region

    Private Sub frmGeneraPartidaIntegracionII_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = vTitle
        Me.dtpFecha.Value = Now
        Me.dtpFecha2.Value = Now
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnProcesar_Click_1(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim oCtb As New wrConta.wsLibContab, vTipoAhorro As String, vCodPartida As String
        vCodPartida = "AS0001"
        If oCtb.GenerarPartidaLiquidacionAspirante(vCodPartida, Now, Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal) = True Then
            MessageBox.Show("Partida generada con éxito.", vTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        End If
    End Sub



End Class