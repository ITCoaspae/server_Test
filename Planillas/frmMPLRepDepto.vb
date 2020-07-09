Public Class frmMPLRepDepto
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
    Friend WithEvents txtDescCodDep As System.Windows.Forms.TextBox
    Friend WithEvents txtCodDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
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
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtDescCodDep = New System.Windows.Forms.TextBox()
        Me.txtCodDepartamento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
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
        Me.Label3.Location = New System.Drawing.Point(212, 83)
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
        Me.dtpFecha2.Location = New System.Drawing.Point(234, 79)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha2.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(110, 79)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'chkInactivos
        '
        Me.chkInactivos.Location = New System.Drawing.Point(26, 131)
        Me.chkInactivos.Name = "chkInactivos"
        Me.chkInactivos.Size = New System.Drawing.Size(176, 16)
        Me.chkInactivos.TabIndex = 4
        Me.chkInactivos.Text = "&Mostrar empleados inactivos"
        '
        'chkTodos
        '
        Me.chkTodos.Location = New System.Drawing.Point(364, 82)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(168, 16)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "&Todos los Departamentos"
        Me.chkTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescCodDep
        '
        Me.txtDescCodDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescCodDep.Location = New System.Drawing.Point(196, 105)
        Me.txtDescCodDep.Name = "txtDescCodDep"
        Me.txtDescCodDep.ReadOnly = True
        Me.txtDescCodDep.Size = New System.Drawing.Size(336, 20)
        Me.txtDescCodDep.TabIndex = 2
        '
        'txtCodDepartamento
        '
        Me.txtCodDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDepartamento.Location = New System.Drawing.Point(110, 105)
        Me.txtCodDepartamento.MaxLength = 10
        Me.txtCodDepartamento.Name = "txtCodDepartamento"
        Me.txtCodDepartamento.Size = New System.Drawing.Size(80, 20)
        Me.txtCodDepartamento.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Departamento:"
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(457, 131)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 113
        Me.btnProcesar1.Text = "Generar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmMPLRepDepto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(552, 204)
        Me.Controls.Add(Me.chkInactivos)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescCodDep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodDepartamento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnProcesar1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMPLRepDepto"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
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

    Private Sub txtCodDepartamento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDepartamento.DoubleClick
        Dim ds As New Data.DataSet
        Dim sResultado1 As String, sResultado2 As String
        Dim ofrm As New frmAGenerico

        Try
            ofrm.Text = "Buscar Departamentos"
            ds = oPlan.ConsultarPLDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado2.Trim = "" Then Exit Sub
            Me.txtCodDepartamento.Text = ofrm.Resultado2
            Me.txtDescCodDep.Text = ofrm.Resultado3
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtCodDepartamento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodDepartamento.Validating
        Try
            If Me.txtCodDepartamento.Text.Trim = "" Then Exit Sub
            Dim ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection
            ds = oPlan.ConsultarPLDepartamentos("*", "CodDepartamento= '" & Trim(Me.txtCodDepartamento.Text) & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count <= 0 Then
            Else
                Filas = ds.Tables(0).Rows()
                Me.txtDescCodDep.Text = CStr(Filas.Item(0)("Descripcion")).Trim
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            Select Case vNumReporte
                Case 0 'REPORTE DE EMPLEADOS POR DEPARTAMENTO
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet, pFiltro As String
                    If Me.txtCodDepartamento.Text.Trim = "" Then
                        pFiltro = ""
                    Else
                        pFiltro = "b.CodDepartamento='" & Me.txtCodDepartamento.Text.Trim & "'"
                    End If
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, pFiltro, "REPORTE DE EMPLEADOS POR DEPARTAMENTO", Me.chkTodos.Checked, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 147, 0)
                    ofrm.ShowDialog()
                Case 1 'REPORTE DE EMPLEADOS POR CARGO
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet, pFiltro As String
                    If Me.txtCodDepartamento.Text.Trim = "" Then
                        pFiltro = ""
                    Else
                        pFiltro = "b.CodCargo='" & Me.txtCodDepartamento.Text.Trim & "'"
                    End If
                    ds = oPlan.Reporte_Datos_Empleado(Me.dtpFecha.Value, Me.dtpFecha2.Value, pFiltro, "REPORTE DE EMPLEADOS POR DEPARTAMENTO", Me.chkTodos.Checked, Me.chkInactivos.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 147, 0)
                    ofrm.ShowDialog()
            End Select
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub frmMPLRepDepto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.dtpFecha2.Value = Now
        Me.Text = Me.Titulo
    End Sub

End Class