Public Class frmRepCarteraPrestamosXTipoGarantia
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(108, 86)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(144, 20)
        Me.dtpFechaFin.TabIndex = 20
        Me.dtpFechaFin.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Fecha Fin:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(108, 60)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(144, 20)
        Me.dtpFechaInicio.TabIndex = 18
        Me.dtpFechaInicio.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha Inicio:"
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(298, 78)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 170
        Me.btProcesar1.Text = "Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'frmRepCarteraPrestamosXTipoGarantia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(412, 147)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(412, 147)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(412, 147)
        Me.Name = "frmRepCarteraPrestamosXTipoGarantia"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cartera de Préstamos por Garantía"
        Me.ResumeLayout(False)

    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Dim ds As New Data.DataSet
        Dim pAceptada As Boolean = False
        Try
            Dim oItem As New wrPrestamo.wsLibPrest
            ds = oItem.ListadoCarteraPrestamoXTipoGarantia(Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 42, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


End Class
