Public Class frmMSPLAusentismo
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Private oPlan As New wrPlanilla.wsLibPlanilla
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Public pCorrelativo As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

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
    Friend WithEvents txtCodMotivoAusentismo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescCodMotAusentismo As System.Windows.Forms.TextBox
    Friend WithEvents txtNomEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkTotal As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpPI As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpPF As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpPF = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpPI = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkTotal = New System.Windows.Forms.CheckBox()
        Me.txtCantidadHoras = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomEmpleado = New System.Windows.Forms.TextBox()
        Me.txtDescCodMotAusentismo = New System.Windows.Forms.TextBox()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodMotivoAusentismo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpPF
        '
        Me.dtpPF.CustomFormat = "MMMM"
        Me.dtpPF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPF.Location = New System.Drawing.Point(431, 309)
        Me.dtpPF.Name = "dtpPF"
        Me.dtpPF.Size = New System.Drawing.Size(131, 20)
        Me.dtpPF.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(325, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 16)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "al:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(23, 313)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 16)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Del:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(431, 112)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(131, 20)
        Me.dtpFechaFin.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(322, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 18)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Fecha fin:"
        '
        'dtpPI
        '
        Me.dtpPI.CustomFormat = "MMMM"
        Me.dtpPI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPI.Location = New System.Drawing.Point(139, 309)
        Me.dtpPI.Name = "dtpPI"
        Me.dtpPI.Size = New System.Drawing.Size(131, 20)
        Me.dtpPI.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(23, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Período al que aplican:"
        '
        'chkTotal
        '
        Me.chkTotal.Location = New System.Drawing.Point(26, 138)
        Me.chkTotal.Name = "chkTotal"
        Me.chkTotal.Size = New System.Drawing.Size(183, 18)
        Me.chkTotal.TabIndex = 2
        Me.chkTotal.Text = "&Ingresar total de ausencias"
        '
        'txtCantidadHoras
        '
        Me.txtCantidadHoras.BackColor = System.Drawing.Color.White
        Me.txtCantidadHoras.Location = New System.Drawing.Point(138, 188)
        Me.txtCantidadHoras.MaxLength = 5
        Me.txtCantidadHoras.Name = "txtCantidadHoras"
        Me.txtCantidadHoras.ReadOnly = True
        Me.txtCantidadHoras.Size = New System.Drawing.Size(132, 20)
        Me.txtCantidadHoras.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 19)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Cantidad Horas:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicio.Location = New System.Drawing.Point(139, 112)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(131, 20)
        Me.dtpFechaInicio.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Fecha inicio:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Location = New System.Drawing.Point(138, 219)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(424, 62)
        Me.txtObservaciones.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(23, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Observaciones:"
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(431, 162)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(131, 20)
        Me.dtpHoraFin.TabIndex = 6
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(139, 162)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(131, 20)
        Me.dtpHoraInicio.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(325, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Hora Fin:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNomEmpleado
        '
        Me.txtNomEmpleado.BackColor = System.Drawing.Color.White
        Me.txtNomEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomEmpleado.Location = New System.Drawing.Point(230, 86)
        Me.txtNomEmpleado.MaxLength = 10
        Me.txtNomEmpleado.Name = "txtNomEmpleado"
        Me.txtNomEmpleado.ReadOnly = True
        Me.txtNomEmpleado.Size = New System.Drawing.Size(332, 20)
        Me.txtNomEmpleado.TabIndex = 11
        '
        'txtDescCodMotAusentismo
        '
        Me.txtDescCodMotAusentismo.BackColor = System.Drawing.Color.White
        Me.txtDescCodMotAusentismo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescCodMotAusentismo.Location = New System.Drawing.Point(230, 60)
        Me.txtDescCodMotAusentismo.MaxLength = 10
        Me.txtDescCodMotAusentismo.Name = "txtDescCodMotAusentismo"
        Me.txtDescCodMotAusentismo.ReadOnly = True
        Me.txtDescCodMotAusentismo.Size = New System.Drawing.Size(332, 20)
        Me.txtDescCodMotAusentismo.TabIndex = 14
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpleado.Location = New System.Drawing.Point(138, 86)
        Me.txtCodEmpleado.MaxLength = 10
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(86, 20)
        Me.txtCodEmpleado.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Código Empleado:"
        '
        'txtCodMotivoAusentismo
        '
        Me.txtCodMotivoAusentismo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMotivoAusentismo.Location = New System.Drawing.Point(139, 60)
        Me.txtCodMotivoAusentismo.MaxLength = 10
        Me.txtCodMotivoAusentismo.Name = "txtCodMotivoAusentismo"
        Me.txtCodMotivoAusentismo.Size = New System.Drawing.Size(85, 20)
        Me.txtCodMotivoAusentismo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hora Inicio:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Motivo Ausentismo:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(487, 353)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 118
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPLAusentismo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(584, 432)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpPF)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.dtpPI)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCodMotivoAusentismo)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtCantidadHoras)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDescCodMotAusentismo)
        Me.Controls.Add(Me.txtCodEmpleado)
        Me.Controls.Add(Me.dtpHoraFin)
        Me.Controls.Add(Me.txtNomEmpleado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpHoraInicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(584, 432)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(584, 432)
        Me.Name = "frmMSPLAusentismo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Ingreso de Ausencias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub txtCodEmpleado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEmpleado.DoubleClick
        If Me.btnGuardar1.Text = "&Guardar" Then
            Dim ofrm As New frmAGenerico
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
                Me.txtNomEmpleado.Text = Ape1 & " " & Ape2 & ", " & Nom
            Catch ex As Exception
                MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
            End Try
        End If
    End Sub

    Private Sub txtCodMotivoAusentismo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodMotivoAusentismo.DoubleClick
        If Me.btnGuardar1.Text = "&Guardar" Then
            Dim ofrm As New frmAGenerico
            Dim ds As New Data.DataSet
            Dim CodAus, Desc As String
            Try
                ofrm.Text = "Buscar Motivos de Ausentismo..."
                ds = oPlan.ConsultarPLMotivoAusentismo("*", "", "CodAusentismo", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0
                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                CodAus = ofrm.Resultado.Trim
                Desc = ofrm.Resultado2.Trim
                Me.txtCodMotivoAusentismo.Text = CodAus
                Me.txtDescCodMotAusentismo.Text = Desc
            Catch ex As Exception
                MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
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
                    Else
                        Filas = ds.Tables(0).Rows()
                        Me.txtCodEmpleado.Text = CStr(Filas.Item(0)("CodEmpleado")).Trim
                        Me.txtNomEmpleado.Text = CStr(Filas.Item(0)("Apellido1")).Trim & " " & CStr(Filas.Item(0)("Apellido2")).Trim & ", " & CStr(Filas.Item(0)("Nombres")).Trim
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub chkTotal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTotal.CheckedChanged
        If Me.chkTotal.Checked = True Then
            Me.dtpHoraFin.Enabled = False
            Me.dtpHoraInicio.Enabled = False
            Me.txtCantidadHoras.ReadOnly = False
        Else
            Me.dtpHoraFin.Enabled = True
            Me.dtpHoraInicio.Enabled = True
            Me.txtCantidadHoras.ReadOnly = True
        End If
    End Sub

    Private Sub frmMSPLAusentismo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection

        ds = oPlan.ConsultarPLEmpleado("CodEmpleado,Apellido1,Apellido2,Nombres", "CodEmpleado = '" & Me.txtCodEmpleado.Text.Trim & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        If Filas.Count > 0 Then
            Me.txtCodEmpleado.Text = CStr(Filas.Item(0)("CodEmpleado")).Trim
            Me.txtNomEmpleado.Text = CStr(Filas.Item(0)("Nombres")).Trim & " " & CStr(Filas.Item(0)("Apellido1")).Trim & " " & CStr(Filas.Item(0)("Apellido2")).Trim
        End If
        ds = oPlan.ConsultarPLMotivoAusentismo("*", "CodAusentismo = '" & Me.txtCodMotivoAusentismo.Text.Trim & "'", "CodAusentismo", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        If Filas.Count > 0 Then
            Me.txtCodMotivoAusentismo.Text = CStr(Filas.Item(0)("CodAusentismo")).Trim
            Me.txtDescCodMotAusentismo.Text = CStr(Filas.Item(0)("Descripcion")).Trim
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

    Private Sub dtpHoraInicio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraInicio.LostFocus
        Dim HoraInicio As DateTime = Me.dtpHoraInicio.Value.ToShortTimeString
        Dim HoraFin As DateTime = Me.dtpHoraFin.Value.ToShortTimeString
        Me.txtCantidadHoras.Text = CDbl(DateDiff(DateInterval.Hour, HoraInicio, HoraFin))
    End Sub

    Private Sub txtCodMotivoAusentismo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodMotivoAusentismo.TextChanged
        If Me.txtCodMotivoAusentismo.Text.Trim = "04" Then
            Me.chkTotal.Text = "&Ingresar total de incapacidades"
            Me.txtCantidadHoras.ReadOnly = False
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim Campos, Valores, CamposValores, Filtro As String
        Try
            If Me.txtCantidadHoras.Text.Trim = "" Then Me.txtCantidadHoras.Text = 0
            If Me.btnGuardar1.Text = "&Guardar" Then
                If Me.txtCodMotivoAusentismo.Text = "" Or Me.txtCodEmpleado.Text = "" Then
                    MsgBox("Debe de completar todos los campos", MsgBoxStyle.Information, "Módulo - Planilla")
                Else
                    Campos = "CodEmpleado,CodAusentismo,HoraInicio,HoraFin,TotalHoras,FechaInicio,FechaFin,Observaciones,Tipo,PeriodoInicio,PeriodoFin"
                    Valores = "'" & Trim(Me.txtCodEmpleado.Text) & "','" & Trim(Me.txtCodMotivoAusentismo.Text) & "','" & Format(Me.dtpHoraInicio.Value, "HH:mm") & "','" & Format(Me.dtpHoraFin.Value, "HH:mm") & "'," & Val(Me.txtCantidadHoras.Text) & ",'" & Format(Me.dtpFechaInicio.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtObservaciones.Text) & "','" & IIf(Me.chkTotal.Checked = True, "G", "I") & "','" & Format(Me.dtpPI.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpPF.Value, "dd/MM/yyyy") & "'"
                    If oPlan.InsertarPLAusentismo(Campos, Valores, sUsuario, sPassword, sSucursal) Then
                        MsgBox("Registro ingresado", MsgBoxStyle.Information, "Módulo - Planilla")
                        Me.Dispose()
                    Else
                        MsgBox("Registro NO ingresado", MsgBoxStyle.Information, "Módulo - Planilla")
                    End If
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                Filtro = "Correlativo=" & pCorrelativo & ""
                CamposValores = "HoraInicio='" & Format(Me.dtpHoraInicio.Value, "HH:mm") & "',HoraFin='" & Format(Me.dtpHoraFin.Value, "HH:mm") & "',TotalHoras=" & Val(Me.txtCantidadHoras.Text) & ",FechaInicio='" & Format(Me.dtpFechaInicio.Value, "dd/MM/yyyy") & "',FechaFin='" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "',Observaciones='" & Trim(Me.txtObservaciones.Text) & "',Tipo='" & IIf(Me.chkTotal.Checked = True, "G", "I") & "',PeriodoInicio='" & Format(Me.dtpPI.Value, "dd/MM/yyyy") & "',PeriodoFin='" & Format(Me.dtpPF.Value, "dd/MM/yyyy") & "'"
                If oPlan.ModificarPLAusentismo(CamposValores, Filtro, sUsuario, sPassword, sSucursal) Then
                    MsgBox("Registro modificado", MsgBoxStyle.Information, "Módulo - Planilla")
                    Me.Dispose()
                Else
                    MsgBox("Registro NO modificado", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class