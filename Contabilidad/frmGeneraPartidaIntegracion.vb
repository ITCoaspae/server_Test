Public Class frmGeneraPartidaIntegracion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private vTipo As wrConta.PartidaIntegracion, vTitle As String
    Friend WithEvents btnProcesar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCerrar As MetroFramework.Controls.MetroButton

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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbTipoAhorro As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbTipoAhorro = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnProcesar = New MetroFramework.Controls.MetroButton()
        Me.btnCerrar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'cbTipoAhorro
        '
        Me.cbTipoAhorro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoAhorro.Items.AddRange(New Object() {"Depósitos a Plazo Fijo", "Ahorro a la Vista", "Ahorro Restringido", "Ahorro Programado"})
        Me.cbTipoAhorro.Location = New System.Drawing.Point(117, 91)
        Me.cbTipoAhorro.Name = "cbTipoAhorro"
        Me.cbTipoAhorro.Size = New System.Drawing.Size(232, 21)
        Me.cbTipoAhorro.TabIndex = 137
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "Tipo de Ahorro:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(117, 65)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(97, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(168, 131)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(107, 28)
        Me.btnProcesar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar.TabIndex = 138
        Me.btnProcesar.Text = "Generar Partida"
        Me.btnProcesar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar.UseSelectable = True
        Me.btnProcesar.UseStyleColors = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(281, 131)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(68, 28)
        Me.btnCerrar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar.TabIndex = 139
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar.UseSelectable = True
        Me.btnCerrar.UseStyleColors = True
        '
        'frmGeneraPartidaIntegracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(371, 180)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.cbTipoAhorro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(371, 180)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(371, 180)
        Me.Name = "frmGeneraPartidaIntegracion"
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

    Private Sub frmGeneraPartidaIntegracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.Text = vTitle
        Me.cbTipoAhorro.SelectedIndex = 0
    End Sub



    Private Sub btnProcesar_Click_1(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim oCtb As New wrConta.wsLibContab, vTipoAhorro As String, vCodPartida As String
        vTipoAhorro = Me.cbTipoAhorro.SelectedIndex + 2
        If vTipo = wrConta.PartidaIntegracion.ProvisionAhorros Then
            If vTipoAhorro = "2" Then 'Depósitos a Plazo Fijo
                vCodPartida = "AH0001"
            ElseIf vTipoAhorro = "3" Then 'Ahorro a la Vista
                vCodPartida = "AH0002"
            ElseIf vTipoAhorro = "4" Then 'Ahorro(Restringido)
                vCodPartida = "AH0003"
            ElseIf vTipoAhorro = "5" Then 'Ahorro(Programado)
                vCodPartida = "AH0004"
            End If
        ElseIf vTipo = wrConta.PartidaIntegracion.PagoInteresesAhorros Then
            If vTipoAhorro = "2" Then 'Depósitos a Plazo Fijo
                vCodPartida = "AH0005"
            ElseIf vTipoAhorro = "3" Then 'Ahorro a la Vista
                vCodPartida = "AH0006"
            ElseIf vTipoAhorro = "4" Then 'Ahorro(Restringido)
                vCodPartida = "AH0007"
            ElseIf vTipoAhorro = "5" Then 'Ahorro(Programado)
                vCodPartida = "AH0008"
            End If
        End If
        If oCtb.GeneraPartidaIntegracionAhorros(sUsuario, sPassword, sSucursal, vTipo, vTipoAhorro, vCodPartida, Me.dtpFecha.Value) = True Then
            MessageBox.Show("Partida generada con éxito.", vTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        End If
    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub



End Class