Public Class frmRepCaja
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

    Private vTitulo As String, vNumReporte As String
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents txtNoCaja As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtNoCaja = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Del:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Al:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(68, 89)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(291, 23)
        Me.dtpFecha2.TabIndex = 43
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(68, 60)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(291, 23)
        Me.dtpFecha.TabIndex = 42
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(225, 118)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(134, 28)
        Me.chkTodos.TabIndex = 1
        Me.chkTodos.Text = "&Todas las cajas"
        '
        'txtNoCaja
        '
        Me.txtNoCaja.BackColor = System.Drawing.Color.White
        Me.txtNoCaja.Location = New System.Drawing.Point(153, 120)
        Me.txtNoCaja.Name = "txtNoCaja"
        Me.txtNoCaja.ReadOnly = True
        Me.txtNoCaja.Size = New System.Drawing.Size(63, 22)
        Me.txtNoCaja.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 19)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Número de Caja:"
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(269, 145)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(90, 32)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 1017
        Me.btnProcesar1.Text = "Mostrar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmRepCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(389, 204)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.txtNoCaja)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(551, 232)
        Me.MinimizeBox = False
        Me.Name = "frmRepCaja"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "MOVIMIENTOS DE CAJA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"
    Public Property Titulo() As String
        Get
            Return vTitulo
        End Get
        Set(ByVal Value As String)
            vTitulo = Value
        End Set
    End Property
    Public Property NumReporte() As String

        Get
            Return vNumReporte
        End Get
        Set(ByVal Value As String)
            vNumReporte = Value
        End Set
    End Property
#End Region

    Private Sub frmRepCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.dtpFecha2.Value = Now
        Me.Text = Me.Titulo
    End Sub


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            ' Select Case vNumReporte
            '  Case 0 'REPORTE DE MOVIMIENTOS DE CAJA
            Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, pCaja As String
                    pCaja = Me.txtNoCaja.Text.Trim
                    If pCaja = "" Then pCaja = 0
                    ds = oCaja.Movimientos_de_Caja(Format(Me.dtpFecha.Value, "short date"), Format(Me.dtpFecha2.Value, "short date"), Me.chkTodos.Checked, pCaja, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 100, 0)
                    ofrm.ShowDialog()
            'End Select
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = True Then
            Me.txtNoCaja.ReadOnly = True
        Else
            Me.txtNoCaja.ReadOnly = False
        End If
    End Sub

End Class