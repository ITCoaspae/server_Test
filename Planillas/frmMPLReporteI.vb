Public Class frmMPLReporteI
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

    Private oPlan As New wrPlanilla.wsLibPlanilla
    Private vTitulo As String, vNumReporte As String
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

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
    Friend WithEvents chkInactivos As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkInactivos = New System.Windows.Forms.CheckBox()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Fecha de Ingreso:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Del:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(163, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "al:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(185, 79)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha2.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(61, 79)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'chkInactivos
        '
        Me.chkInactivos.Location = New System.Drawing.Point(166, 57)
        Me.chkInactivos.Name = "chkInactivos"
        Me.chkInactivos.Size = New System.Drawing.Size(96, 16)
        Me.chkInactivos.TabIndex = 0
        Me.chkInactivos.Text = "&Ver Inactivos"
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(279, 71)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 114
        Me.btnProcesar1.Text = "Generar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmMPLReporteI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(380, 151)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.chkInactivos)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(380, 151)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(380, 151)
        Me.Name = "frmMPLReporteI"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.ResumeLayout(False)

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



    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            Select Case vNumReporte
                Case 0 'REPORTE DE EMPLEADOS POR CARGO
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, "", "REPORTE DE EMPLEADOS POR CARGO", False, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 148, 0)
                    ofrm.ShowDialog()
                Case 1 'REPORTE DE EMPLEADOS POR FECHA DE INGRESO
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, "", "REPORTE DE EMPLEADOS POR FECHA DE INGRESO", False, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 149, 0)
                    ofrm.ShowDialog()
                Case 2 'REPORTE DE EMPLEADOS POR GÉNERO
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, "", "REPORTE DE EMPLEADOS POR GÉNERO", False, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 150, 0)
                    ofrm.ShowDialog()
                Case 3 'REPORTE DE EMPLEADOS CON DOCUMENTOS
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, "", "REPORTE DE EMPLEADOS CON DOCUMENTOS", False, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 151, 0)
                    ofrm.ShowDialog()
                Case 4 'REPORTE DE EMPLEADOS ACTIVOS
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, "", "REPORTE DE EMPLEADOS ACTIVOS", False, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 152, 0)
                    ofrm.ShowDialog()
                Case 5 'REPORTE DE EMPLEADOS NOMBRES
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, "", "REPORTE DE EMPLEADOS NOMBRES", False, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 153, 0)
                    ofrm.ShowDialog()
                Case 6 'REPORTE DATOS PERSONALES DE EMPLEADOS
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, "", "REPORTE DATOS PERSONALES DE EMPLEADOS", False, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 154, 0)
                    ofrm.ShowDialog()
                Case 7 'REPORTE DE EMPLEADOS (FORMA PAGO)
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, "", "REPORTE DE EMPLEADOS", False, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 155, 0)
                    ofrm.ShowDialog()
                Case 8 'REPORTE DE EMPLEADOS CUMPLEAÑEROS
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, "month(FechaNac)>='" & Me.dtpFecha.Value.Month & "' and month(FechaNac)<='" & Me.dtpFecha2.Value.Month & "'", "REPORTE DE EMPLEADOS CUMPLEAÑEROS", True, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 163, 0)
                    ofrm.ShowDialog()
            End Select
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMPLRepDepto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.dtpFecha2.Value = Now
        Me.Text = Me.Titulo
    End Sub

End Class