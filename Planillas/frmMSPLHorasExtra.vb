Public Class frmMSPLHorasExtra
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Private oPlan As New wrPlanilla.wsLibPlanilla
    Public pCorrelativo As String
    Private vPorcentaje As Double, vHoras As Double, vSalario As Double
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1nValor As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCantidadHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTipoHoraExtra As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoHoraExtra As System.Windows.Forms.TextBox
    Friend WithEvents txtNumPlaza As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkCantidad As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkCantidad = New System.Windows.Forms.CheckBox()
        Me.txtNumPlaza = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCodTipoHoraExtra = New System.Windows.Forms.TextBox()
        Me.txtTipoHoraExtra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidadHoras = New System.Windows.Forms.TextBox()
        Me.txtNombreEmp = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c1nValor = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1nValor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkCantidad
        '
        Me.chkCantidad.Checked = True
        Me.chkCantidad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCantidad.Location = New System.Drawing.Point(424, 189)
        Me.chkCantidad.Name = "chkCantidad"
        Me.chkCantidad.Size = New System.Drawing.Size(152, 20)
        Me.chkCantidad.TabIndex = 7
        Me.chkCantidad.Text = "&Ingresar total de horas"
        '
        'txtNumPlaza
        '
        Me.txtNumPlaza.Location = New System.Drawing.Point(430, 112)
        Me.txtNumPlaza.MaxLength = 10
        Me.txtNumPlaza.Name = "txtNumPlaza"
        Me.txtNumPlaza.Size = New System.Drawing.Size(146, 20)
        Me.txtNumPlaza.TabIndex = 2
        Me.txtNumPlaza.Text = "01"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(303, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "Número de Plaza:"
        '
        'txtCodTipoHoraExtra
        '
        Me.txtCodTipoHoraExtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoHoraExtra.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtCodTipoHoraExtra.Location = New System.Drawing.Point(151, 86)
        Me.txtCodTipoHoraExtra.MaxLength = 1
        Me.txtCodTipoHoraExtra.Name = "txtCodTipoHoraExtra"
        Me.txtCodTipoHoraExtra.Size = New System.Drawing.Size(64, 20)
        Me.txtCodTipoHoraExtra.TabIndex = 1
        '
        'txtTipoHoraExtra
        '
        Me.txtTipoHoraExtra.BackColor = System.Drawing.Color.White
        Me.txtTipoHoraExtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoHoraExtra.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtTipoHoraExtra.Location = New System.Drawing.Point(221, 87)
        Me.txtTipoHoraExtra.MaxLength = 1
        Me.txtTipoHoraExtra.Name = "txtTipoHoraExtra"
        Me.txtTipoHoraExtra.ReadOnly = True
        Me.txtTipoHoraExtra.Size = New System.Drawing.Size(355, 20)
        Me.txtTipoHoraExtra.TabIndex = 94
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Tipo de Hora Extra:"
        '
        'txtCantidadHoras
        '
        Me.txtCantidadHoras.BackColor = System.Drawing.Color.White
        Me.txtCantidadHoras.Enabled = False
        Me.txtCantidadHoras.Location = New System.Drawing.Point(151, 190)
        Me.txtCantidadHoras.MaxLength = 5
        Me.txtCantidadHoras.Name = "txtCantidadHoras"
        Me.txtCantidadHoras.ReadOnly = True
        Me.txtCantidadHoras.Size = New System.Drawing.Size(146, 20)
        Me.txtCantidadHoras.TabIndex = 8
        '
        'txtNombreEmp
        '
        Me.txtNombreEmp.BackColor = System.Drawing.Color.White
        Me.txtNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEmp.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtNombreEmp.Location = New System.Drawing.Point(221, 61)
        Me.txtNombreEmp.MaxLength = 1
        Me.txtNombreEmp.Name = "txtNombreEmp"
        Me.txtNombreEmp.ReadOnly = True
        Me.txtNombreEmp.Size = New System.Drawing.Size(355, 20)
        Me.txtNombreEmp.TabIndex = 90
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(151, 216)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(425, 48)
        Me.txtObservaciones.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(23, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Observaciones"
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(430, 164)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(146, 20)
        Me.dtpHoraFin.TabIndex = 6
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(151, 164)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(146, 20)
        Me.dtpHoraInicio.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(303, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Hora Fin:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 16)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Hora Inicio:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(430, 138)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(146, 20)
        Me.dtpFechaFin.TabIndex = 4
        Me.dtpFechaFin.Visible = False
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicio.Location = New System.Drawing.Point(151, 138)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(146, 20)
        Me.dtpFechaInicio.TabIndex = 3
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.Location = New System.Drawing.Point(151, 60)
        Me.txtCodEmpleado.MaxLength = 12
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEmpleado.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Empleado:"
        '
        'c1nValor
        '
        Me.c1nValor.BackColor = System.Drawing.Color.White
        Me.c1nValor.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nValor.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nValor.Location = New System.Drawing.Point(151, 112)
        Me.c1nValor.Name = "c1nValor"
        Me.c1nValor.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nValor.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nValor.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nValor.ReadOnly = True
        Me.c1nValor.ShowDropDownButton = False
        Me.c1nValor.ShowUpDownButtons = False
        Me.c1nValor.Size = New System.Drawing.Size(146, 20)
        Me.c1nValor.TabIndex = 2
        Me.c1nValor.Tag = Nothing
        Me.c1nValor.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(303, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Fecha Fin:"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Cantidad Horas:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Valor:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(501, 270)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 129
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPLHorasExtra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(598, 343)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.chkCantidad)
        Me.Controls.Add(Me.txtCantidadHoras)
        Me.Controls.Add(Me.txtNumPlaza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpHoraFin)
        Me.Controls.Add(Me.txtCodEmpleado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpHoraInicio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTipoHoraExtra)
        Me.Controls.Add(Me.txtCodTipoHoraExtra)
        Me.Controls.Add(Me.txtNombreEmp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1nValor)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(598, 343)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(598, 343)
        Me.Name = "frmMSPLHorasExtra"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Ingreso de Horas Extra"
        CType(Me.c1nValor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property Porcentaje() As Double
        Get
            Return vPorcentaje
        End Get
        Set(ByVal Value As Double)
            vPorcentaje = Value
        End Set
    End Property

    Public Property Horas() As Double
        Get
            Return vHoras
        End Get
        Set(ByVal Value As Double)
            vHoras = Value
        End Set
    End Property

    Public Property Salario() As Double
        Get
            Return vSalario
        End Get
        Set(ByVal Value As Double)
            vSalario = Value
        End Set
    End Property

    Private Sub txtCodEmpleado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEmpleado.DoubleClick
        If Me.btnGuardar1.Text = "&Guardar" Then
            Dim ofrm As New frmAGenerico, Filas As Data.DataRowCollection
            Dim ds As New Data.DataSet
            Dim CodEmp, Ape1, Ape2, Nom As String
            Try
                ofrm.Text = "Buscar Empleados..."
                ds = oPlan.ConsultarPLEmpleado("CodEmpleado,Apellido1,Apellido2,Nombres", "", "CodEmpleado", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0

                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                CodEmp = ofrm.Resultado.Trim
                Ape1 = ofrm.Resultado2.Trim
                Ape2 = ofrm.Resultado3.Trim
                Nom = ofrm.Resultado4.Trim
                Me.txtCodEmpleado.Text = CodEmp
                Me.txtNombreEmp.Text = Ape1 & " " & Ape2 & ", " & Nom
                ds = oPlan.ConsultarPLPlazas("*", "CodEmpleado = '" & Me.txtCodEmpleado.Text.Trim & "'", "NoPlaza", False, sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    vSalario = CDbl(Filas.Item(0)("SueldoMensual") / 2)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtCodEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodEmpleado.Validating
        If Me.btnGuardar1.Text = "&Guardar" Then
            Try
                If Me.txtCodEmpleado.Text.Trim <> "" Then
                    Dim ds As New Data.DataSet
                    Dim Filas As Data.DataRowCollection
                    ds = oPlan.ConsultarPLEmpleado("*", "CodEmpleado LIKE '" & Trim(Me.txtCodEmpleado.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count <= 0 Then
                        MsgBox("No existe ningún Código de Empleado con esas iniciales", MsgBoxStyle.Information, "Módulo - Planilla")
                    Else
                        Filas = ds.Tables(0).Rows()
                        Me.txtCodEmpleado.Text = CStr(Filas.Item(0)("CodEmpleado")).Trim
                        Me.txtNombreEmp.Text = CStr(Filas.Item(0)("Apellido1")).Trim & " " & CStr(Filas.Item(0)("Apellido2")).Trim & ", " & CStr(Filas.Item(0)("Nombres")).Trim
                        ds = oPlan.ConsultarPLPlazas("*", "CodEmpleado = '" & Me.txtCodEmpleado.Text.Trim & "'", "NoPlaza", False, sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            vSalario = CDbl(Filas.Item(0)("SueldoMensual") / 2)
                        End If
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub ckbHoraInicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dtpHoraInicio.Enabled = True Then
            Me.dtpHoraInicio.Enabled = False
        ElseIf Me.dtpHoraInicio.Enabled = False Then
            Me.dtpHoraInicio.Enabled = True
        End If
    End Sub

    Private Sub ckbHoraFin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dtpHoraFin.Enabled = True Then
            Me.dtpHoraFin.Enabled = False
        ElseIf Me.dtpHoraFin.Enabled = False Then
            Me.dtpHoraFin.Enabled = True
        End If
    End Sub

    Private Sub dtpHoraFin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraFin.LostFocus
        Dim pVal As Long, pval2 As Double
        Dim HoraInicio As DateTime = Me.dtpHoraInicio.Value.ToShortTimeString
        Dim HoraFin As DateTime = Me.dtpHoraFin.Value.ToShortTimeString
        pVal = CDbl(DateDiff(DateInterval.Minute, HoraInicio, HoraFin))
        pval2 = CDbl(DateDiff(DateInterval.Minute, HoraInicio, HoraFin))
        Me.txtCantidadHoras.Text = CDbl(DateDiff(DateInterval.Minute, HoraInicio, HoraFin)) / 60
    End Sub

    Private Sub txtCodTipoHoraExtra_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoHoraExtra.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String

        Try
            ofrm.Text = "Buscar Tipo de Hora Extra"
            ds = oPlan.ConsultarPLTipoHoraExtra("*", "", "CodTipoHoraExtra", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sResultado1 = ofrm.Resultado.Trim
            sResultado2 = ofrm.Resultado2.Trim
            Me.txtCodTipoHoraExtra.Text = sResultado1
            Me.txtTipoHoraExtra.Text = sResultado2
            Horas = IIf(ofrm.Resultado4.Trim = "", 0, CDbl(ofrm.Resultado4.Trim))
            Porcentaje = IIf(ofrm.Resultado5.Trim = "", 0, CDbl(ofrm.Resultado5.Trim))
            Me.c1nValor.Value = (Salario / 2 * Porcentaje) / Horas
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub frmMSPLHorasExtra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        ds = oPlan.ConsultarPLEmpleado("CodEmpleado,Apellido1,Apellido2,Nombres", "CodEmpleado = '" & Me.txtCodEmpleado.Text.Trim & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        If Filas.Count > 0 Then
            Me.txtCodEmpleado.Text = CStr(Filas.Item(0)("CodEmpleado")).Trim
            Me.txtNombreEmp.Text = CStr(Filas.Item(0)("Nombres")).Trim & " " & CStr(Filas.Item(0)("Apellido1")).Trim & " " & CStr(Filas.Item(0)("Apellido2")).Trim
        End If
        ds = oPlan.ConsultarPLTipoHoraExtra("*", "CodTipoHoraExtra = '" & Me.txtCodTipoHoraExtra.Text.Trim & "'", "CodTipoHoraExtra", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        If Filas.Count > 0 Then
            Me.txtCodTipoHoraExtra.Text = CStr(Filas.Item(0)("CodTipoHoraExtra")).Trim
            Me.txtTipoHoraExtra.Text = CStr(Filas.Item(0)("Descripcion")).Trim
        End If
        ds = oPlan.ConsultarPLPlazas("*", "CodEmpleado = '" & Me.txtCodEmpleado.Text.Trim & "'", "NoPlaza", False, sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        If Filas.Count > 0 Then
            vSalario = CDbl(Filas.Item(0)("SueldoMensual") / 2)
        End If
    End Sub

    Private Sub txtNumPlaza_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumPlaza.DoubleClick
        Dim ds As New Data.DataSet
        Dim sResultado1 As String, sResultado2 As String
        Dim ofrm As New frmAGenerico

        Try
            ofrm.Text = "Buscar Número de Plaza"
            ds = oPlan.ConsultarPLPlazas("*", "CodEmpleado='" & Me.txtCodEmpleado.Text.Trim & "'", "NoPlaza", False, sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado2.Trim = "" Then Exit Sub
            Me.txtNumPlaza.Text = ofrm.Resultado2
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtNumPlaza_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumPlaza.Validating
        If Me.btnGuardar1.Text = "&Guardar" Then
            Try
                If Me.txtCodEmpleado.Text.Trim = "" Then Exit Sub
                Dim ds As New Data.DataSet
                Dim Filas As Data.DataRowCollection
                ds = oPlan.ConsultarPLPlazas("*", "CodEmpleado = '" & Trim(Me.txtCodEmpleado.Text) & "' and NoPlaza='" & Me.txtNumPlaza.Text.Trim & "'", "CodEmpleado", False, sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count <= 0 Then
                Else
                    Filas = ds.Tables(0).Rows()
                    Me.txtNumPlaza.Text = CStr(Filas.Item(0)("NoPlaza")).Trim
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim Campos, Valores, CamposValores, Filtro As String
        Try
            Dim HoraInicio As String = Me.dtpHoraInicio.Value.ToShortTimeString.ToString
            Dim HoraFin As String = Me.dtpHoraFin.Value.ToShortTimeString.ToString
            If Me.btnGuardar1.Text = "&Guardar" Then
                Campos = "CodEmpleado,CodTipoHoraExtra,Valor,FechaInicio,FechaFin,HoraInicio,HoraFin,TotalHoras,Observaciones,NoPlaza"
                Valores = "'" & Trim(Me.txtCodEmpleado.Text) & "','" & Me.txtCodTipoHoraExtra.Text.Trim & "'," & Trim(Me.c1nValor.Value) & ",'" & Format(Me.dtpFechaInicio.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "','" & Mid(HoraInicio, 1, 5) & "','" & Mid(HoraFin, 1, 5) & "','" & Me.txtCantidadHoras.Text & "','" & Me.txtObservaciones.Text & "','" & Trim(Me.txtNumPlaza.Text) & "'"
                If oPlan.InsertarPLHorasExtras(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Registro no ingresado.", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "CodTipoHoraExtra='" & Me.txtCodTipoHoraExtra.Text.Trim & "',Valor=" & Trim(Me.c1nValor.Value) & ",FechaInicio='" & Format(Me.dtpFechaInicio.Value, "dd/MM/yyyy") & "',FechaFin='" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "',HoraInicio='" & Mid(HoraInicio, 1, 5) & "',HoraFin='" & Mid(HoraFin, 1, 5) & "',TotalHoras='" & Me.txtCantidadHoras.Text & "',Observaciones='" & Me.txtObservaciones.Text & "',NoPlaza='" & Trim(Me.txtNumPlaza.Text) & "'"
                Filtro = pCorrelativo
                If oPlan.ModificarPLHorasExtras(CamposValores, Filtro, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Registro no modificado.", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkCantidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCantidad.CheckedChanged
        If Me.chkCantidad.Checked = True Then
            Me.dtpHoraFin.Enabled = False
            Me.dtpHoraInicio.Enabled = False
            Me.txtCantidadHoras.Enabled = True
            Me.txtCantidadHoras.ReadOnly = False
        Else
            Me.dtpHoraFin.Enabled = True
            Me.dtpHoraInicio.Enabled = True
            Me.txtCantidadHoras.Enabled = False
            Me.txtCantidadHoras.ReadOnly = True
        End If
    End Sub

    Private Sub dtpHoraInicio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraInicio.LostFocus
        Dim pVal As Long, pval2 As Double
        Dim HoraInicio As DateTime = Me.dtpHoraInicio.Value.ToShortTimeString
        Dim HoraFin As DateTime = Me.dtpHoraFin.Value.ToShortTimeString
        pVal = CDbl(DateDiff(DateInterval.Minute, HoraInicio, HoraFin))
        pval2 = CDbl(DateDiff(DateInterval.Minute, HoraInicio, HoraFin))
        Me.txtCantidadHoras.Text = CDbl(DateDiff(DateInterval.Minute, HoraInicio, HoraFin)) / 60
    End Sub

End Class