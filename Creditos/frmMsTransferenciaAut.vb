Public Class frmMsTransferenciaAut
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

    Private pTipo As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpR1 = New System.Windows.Forms.DateTimePicker()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha del Cálculo:"
        '
        'dtpR1
        '
        Me.dtpR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR1.Location = New System.Drawing.Point(151, 60)
        Me.dtpR1.Name = "dtpR1"
        Me.dtpR1.Size = New System.Drawing.Size(88, 20)
        Me.dtpR1.TabIndex = 0
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(245, 60)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 167
        Me.btProcesar1.Text = "Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'frmMsTransferenciaAut
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(344, 112)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.dtpR1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(344, 112)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(344, 112)
        Me.Name = "frmMsTransferenciaAut"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Transferencias Automáticas"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property Tipo() As String
        Get
            Return pTipo
        End Get
        Set(ByVal Value As String)
            pTipo = Value
        End Set
    End Property

    Private Sub frmMsTransferenciaAut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpR1.Value = Now
    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Try
            Dim oPrest As New wrPrestamo.wsLibPrest, pResp As String, oAhorro As New wrAhorro.wsLibAhorro
            If Tipo = "0" Then
                pResp = oPrest.TransferenciaAutomaticaPrestamos(Me.dtpR1.Value.ToShortDateString, sUsuario, sPassword, sSucursal, "")
            ElseIf Tipo = "1" Then
                pResp = oAhorro.TransferenciaAutomaticaCuentas(Me.dtpR1.Value, sUsuario, sPassword, sSucursal, "")
            End If
            If pResp.Trim = "" Then
                MessageBox.Show("Transferencias realizadas con éxito.", "Transferencias Automáticas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(pResp, "Transferencias Automáticas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
