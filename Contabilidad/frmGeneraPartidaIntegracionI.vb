Public Class frmGeneraPartidaIntegracionI
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form : 
    Public rsc As System.Resources.ResourceManager

    Private vTipo As wrConta.PartidaIntegracion, vTitle As String
    Friend WithEvents btnCerrar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProcesar As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnCerrar = New MetroFramework.Controls.MetroButton()
        Me.btnProcesar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Fecha:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(79, 63)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(162, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(173, 104)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(68, 28)
        Me.btnCerrar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar.TabIndex = 141
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar.UseSelectable = True
        Me.btnCerrar.UseStyleColors = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(60, 104)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(107, 28)
        Me.btnProcesar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar.TabIndex = 140
        Me.btnProcesar.Text = "Generar Partida"
        Me.btnProcesar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar.UseSelectable = True
        Me.btnProcesar.UseStyleColors = True
        '
        'frmGeneraPartidaIntegracionI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(264, 155)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(264, 155)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(264, 155)
        Me.Name = "frmGeneraPartidaIntegracionI"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Generar Partida"
        Me.ResumeLayout(False)

    End Sub

#End Region

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

    Private Sub frmGeneraPartidaIntegracionI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.Text = vTitle
        If Me.vTipo = wrConta.PartidaIntegracion.InteresesPagados Then
            Me.Label2.Text = "Fecha vencimiento DPF:"
        End If
    End Sub



    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnProcesar_Click_1(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim oCtb As New wrConta.wsLibContab, vCodPartida As String
        If Me.vTipo = wrConta.PartidaIntegracion.IngresosCaja Then
            vCodPartida = "CA0001"
            If oCtb.GeneraPartidaIntegracionIngresoCaja(sUsuario, sPassword, sSucursal, vCodPartida, Me.dtpFecha.Value) = True Then
                MessageBox.Show("Partida generada con éxito.", vTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        ElseIf Me.vTipo = wrConta.PartidaIntegracion.InteresesPagados Then
            vCodPartida = "AH0001"
            If oCtb.GeneraPartidaInteresesPagados(sUsuario, sPassword, sSucursal, wrConta.PartidaIntegracion.InteresesPagados, vCodPartida, Me.dtpFecha.Value) = True Then
                MessageBox.Show("Partida generada con éxito.", vTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        End If
    End Sub



End Class
