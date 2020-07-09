Public Class frmListadoCreditoSinPagoXGestion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim credito As New wrCredito.wsLibCred
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodGestor As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreGestor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreGestor = New System.Windows.Forms.TextBox()
        Me.txtCodGestor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'chkTodos
        '
        Me.chkTodos.Location = New System.Drawing.Point(425, 80)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(133, 32)
        Me.chkTodos.TabIndex = 3
        Me.chkTodos.Text = "&Todos los gestores"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(217, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "al:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(263, 83)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(134, 20)
        Me.dtpFecha2.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(77, 83)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(134, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Del:"
        '
        'txtNombreGestor
        '
        Me.txtNombreGestor.BackColor = System.Drawing.Color.White
        Me.txtNombreGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreGestor.Location = New System.Drawing.Point(131, 57)
        Me.txtNombreGestor.Name = "txtNombreGestor"
        Me.txtNombreGestor.ReadOnly = True
        Me.txtNombreGestor.Size = New System.Drawing.Size(427, 20)
        Me.txtNombreGestor.TabIndex = 15
        '
        'txtCodGestor
        '
        Me.txtCodGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodGestor.Location = New System.Drawing.Point(77, 57)
        Me.txtCodGestor.Name = "txtCodGestor"
        Me.txtCodGestor.Size = New System.Drawing.Size(48, 20)
        Me.txtCodGestor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Gestor:"
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(483, 118)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 179
        Me.btProcesar1.Text = "Mostrar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'frmListadoCreditoSinPagoXGestion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(581, 176)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodGestor)
        Me.Controls.Add(Me.txtNombreGestor)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(581, 176)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(581, 176)
        Me.Name = "frmListadoCreditoSinPagoXGestion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Listado de créditos sin pago por gestión de crédito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub txtCodGestor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodGestor.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Gestor"
        Dim ds As New DataSet
        Try

            ds = credito.ConsultarGestores("*", "", "CodGestor", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodGestor.Text = ofrm.Resultado.Trim
            Me.txtNombreGestor.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Gestores - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub frmListadoCreditoSinPagoXGestion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.dtpFecha2.Value = Now
    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Dim ds As New Data.DataSet

        Dim pAceptada As Boolean = False
        Try
            ds = credito.CreditosSinPagoMesXGestionCredito(Me.chkTodos.Checked, Me.txtCodGestor.Text, Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 40, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class