Public Class frmMSPLVacaciones
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Private oPlan As New wrPlanilla.wsLibPlanilla
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDiasVacacion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPrimaVacacion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalIngresos As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPromComisiones As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDias As System.Windows.Forms.TextBox
    Friend WithEvents txtPrima As System.Windows.Forms.TextBox
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents txtTotalVacacion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFinPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaIniPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Dim Planillas As New wrPlanilla.wsLibPlanilla
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Private vCorrelativo As Integer
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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni_Vac As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin_Vac As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodTipoPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin_PL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblFiPer As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni_PL As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpFechaFinPago = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaIniPago = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodTipoPlanilla = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtTotalVacacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDiasVacacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPrimaVacacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalIngresos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPromComisiones = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.txtPrima = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaIni_Vac = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin_Vac = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFiPer = New System.Windows.Forms.Label()
        Me.dtpFechaFin_PL = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIni_PL = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombreEmp = New System.Windows.Forms.TextBox()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.DtpFechaFinPago)
        Me.GroupBox5.Controls.Add(Me.DtpFechaIniPago)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txtCodTipoPlanilla)
        Me.GroupBox5.Controls.Add(Me.txtDescripcion)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 274)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(657, 73)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pago de Vacaciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Tipo de Planilla:"
        '
        'DtpFechaFinPago
        '
        Me.DtpFechaFinPago.CustomFormat = "MMMM"
        Me.DtpFechaFinPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinPago.Location = New System.Drawing.Point(241, 16)
        Me.DtpFechaFinPago.Name = "DtpFechaFinPago"
        Me.DtpFechaFinPago.Size = New System.Drawing.Size(89, 20)
        Me.DtpFechaFinPago.TabIndex = 34
        '
        'DtpFechaIniPago
        '
        Me.DtpFechaIniPago.CustomFormat = "MMMM"
        Me.DtpFechaIniPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIniPago.Location = New System.Drawing.Point(83, 16)
        Me.DtpFechaIniPago.Name = "DtpFechaIniPago"
        Me.DtpFechaIniPago.Size = New System.Drawing.Size(89, 20)
        Me.DtpFechaIniPago.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(178, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Fecha Fin:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Fecha Inicio:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(395, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Tipo Personal"
        Me.Label1.Visible = False
        '
        'txtCodTipoPlanilla
        '
        Me.txtCodTipoPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoPlanilla.Location = New System.Drawing.Point(98, 42)
        Me.txtCodTipoPlanilla.MaxLength = 10
        Me.txtCodTipoPlanilla.Name = "txtCodTipoPlanilla"
        Me.txtCodTipoPlanilla.Size = New System.Drawing.Size(59, 20)
        Me.txtCodTipoPlanilla.TabIndex = 36
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(163, 42)
        Me.txtDescripcion.MaxLength = 10
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(435, 20)
        Me.txtDescripcion.TabIndex = 37
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.MetroButton2)
        Me.GroupBox4.Controls.Add(Me.MetroButton1)
        Me.GroupBox4.Controls.Add(Me.txtTotalVacacion)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtDiasVacacion)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtPrimaVacacion)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtTotalIngresos)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtPromComisiones)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtDias)
        Me.GroupBox4.Controls.Add(Me.txtPrima)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 148)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(657, 120)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Calculo de Vacación:"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(85, 16)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(116, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 148
        Me.MetroButton2.Text = "Modificar Calculo"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(6, 16)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 147
        Me.MetroButton1.Text = "Calcular"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtTotalVacacion
        '
        Me.txtTotalVacacion.Location = New System.Drawing.Point(491, 79)
        Me.txtTotalVacacion.Name = "txtTotalVacacion"
        Me.txtTotalVacacion.Size = New System.Drawing.Size(99, 20)
        Me.txtTotalVacacion.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(386, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Total de Vacación:"
        '
        'txtDiasVacacion
        '
        Me.txtDiasVacacion.Location = New System.Drawing.Point(491, 53)
        Me.txtDiasVacacion.Name = "txtDiasVacacion"
        Me.txtDiasVacacion.Size = New System.Drawing.Size(99, 20)
        Me.txtDiasVacacion.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(386, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Días de Vacación:"
        '
        'txtPrimaVacacion
        '
        Me.txtPrimaVacacion.Location = New System.Drawing.Point(491, 27)
        Me.txtPrimaVacacion.Name = "txtPrimaVacacion"
        Me.txtPrimaVacacion.Size = New System.Drawing.Size(99, 20)
        Me.txtPrimaVacacion.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(386, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Prima de Vacación:"
        '
        'txtTotalIngresos
        '
        Me.txtTotalIngresos.Location = New System.Drawing.Point(251, 79)
        Me.txtTotalIngresos.Name = "txtTotalIngresos"
        Me.txtTotalIngresos.Size = New System.Drawing.Size(99, 20)
        Me.txtTotalIngresos.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(195, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 26)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Total de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingresos:"
        '
        'txtPromComisiones
        '
        Me.txtPromComisiones.Location = New System.Drawing.Point(82, 79)
        Me.txtPromComisiones.Name = "txtPromComisiones"
        Me.txtPromComisiones.Size = New System.Drawing.Size(99, 20)
        Me.txtPromComisiones.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 26)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Promedio de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comisiones:"
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(251, 51)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(99, 20)
        Me.txtDias.TabIndex = 19
        '
        'txtPrima
        '
        Me.txtPrima.Location = New System.Drawing.Point(82, 50)
        Me.txtPrima.Name = "txtPrima"
        Me.txtPrima.Size = New System.Drawing.Size(99, 20)
        Me.txtPrima.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(195, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Días:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Prima:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(651, 101)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 364
        Me.LineShape1.X2 = 365
        Me.LineShape1.Y1 = -3
        Me.LineShape1.Y2 = 89
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dtpFechaIni_Vac)
        Me.GroupBox3.Controls.Add(Me.dtpFechaFin_Vac)
        Me.GroupBox3.Location = New System.Drawing.Point(305, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 41)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Periodo Vacacional"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha Fin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fecha Inicio:"
        '
        'dtpFechaIni_Vac
        '
        Me.dtpFechaIni_Vac.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaIni_Vac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIni_Vac.Location = New System.Drawing.Point(79, 16)
        Me.dtpFechaIni_Vac.Name = "dtpFechaIni_Vac"
        Me.dtpFechaIni_Vac.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaIni_Vac.TabIndex = 10
        '
        'dtpFechaFin_Vac
        '
        Me.dtpFechaFin_Vac.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaFin_Vac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin_Vac.Location = New System.Drawing.Point(244, 16)
        Me.dtpFechaFin_Vac.Name = "dtpFechaFin_Vac"
        Me.dtpFechaFin_Vac.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaFin_Vac.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFiPer)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFin_PL)
        Me.GroupBox2.Controls.Add(Me.dtpFechaIni_PL)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 41)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo Laboral Correspondiente a la Vacación"
        '
        'lblFiPer
        '
        Me.lblFiPer.Location = New System.Drawing.Point(6, 16)
        Me.lblFiPer.Name = "lblFiPer"
        Me.lblFiPer.Size = New System.Drawing.Size(31, 16)
        Me.lblFiPer.TabIndex = 4
        Me.lblFiPer.Text = "Del:"
        Me.lblFiPer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaFin_PL
        '
        Me.dtpFechaFin_PL.CustomFormat = "MMMM"
        Me.dtpFechaFin_PL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin_PL.Location = New System.Drawing.Point(157, 14)
        Me.dtpFechaFin_PL.Name = "dtpFechaFin_PL"
        Me.dtpFechaFin_PL.Size = New System.Drawing.Size(89, 20)
        Me.dtpFechaFin_PL.TabIndex = 7
        '
        'dtpFechaIni_PL
        '
        Me.dtpFechaIni_PL.CustomFormat = "MMMM"
        Me.dtpFechaIni_PL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni_PL.Location = New System.Drawing.Point(43, 14)
        Me.dtpFechaIni_PL.Name = "dtpFechaIni_PL"
        Me.dtpFechaIni_PL.Size = New System.Drawing.Size(89, 20)
        Me.dtpFechaIni_PL.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(138, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "al:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombreEmp
        '
        Me.txtNombreEmp.BackColor = System.Drawing.Color.White
        Me.txtNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEmp.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtNombreEmp.Location = New System.Drawing.Point(189, 64)
        Me.txtNombreEmp.MaxLength = 1
        Me.txtNombreEmp.Name = "txtNombreEmp"
        Me.txtNombreEmp.ReadOnly = True
        Me.txtNombreEmp.Size = New System.Drawing.Size(445, 20)
        Me.txtNombreEmp.TabIndex = 2
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.Location = New System.Drawing.Point(103, 63)
        Me.txtCodEmpleado.MaxLength = 12
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(80, 20)
        Me.txtCodEmpleado.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(21, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Empleado:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(562, 353)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 146
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPLVacaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(675, 430)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCodEmpleado)
        Me.Controls.Add(Me.txtNombreEmp)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(675, 430)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(675, 430)
        Me.Name = "frmMSPLVacaciones"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Vacaciones"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public Property Correlativo() As String
        Get
            Return vCorrelativo
        End Get
        Set(ByVal Value As String)
            vCorrelativo = Value
        End Set
    End Property

    Private Sub txtCodTipoPersonal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.DoubleClick
        If Me.btnGuardar1.Text = "&Guardar" Then
            Dim ofrm As New frmAGenerico
            Dim ds As New Data.DataSet
            Dim CodTP, Desc As String
            Try
                ofrm.Text = "Buscar Tipos de Personal..."
                ds = oPlan.ConsultarPLTipoPersonal("*", "", "CodTipoPersonal", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0
                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                CodTP = ofrm.Resultado.Trim
                Desc = ofrm.Resultado2.Trim
                Me.txtDescripcion.Text = CodTP
                'Me.txtDescCodTipoPersonal.Text = Desc
            Catch ex As Exception
                MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
            End Try
        End If
    End Sub

    Private Sub txtCodTipoPlanilla_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoPlanilla.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String

        Try
            ofrm.Text = "Buscar Tipos de Planilla..."
            ds = oPlan.ConsultarPLTipoPlanilla("*", "", "CodTipoPlanilla", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sResultado1 = ofrm.Resultado.Trim
            sResultado2 = ofrm.Resultado2.Trim
            Me.txtCodTipoPlanilla.Text = sResultado1
            Me.txtDescripcion.Text = sResultado2
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub
    Private Sub frmMSPLVacaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDias.Enabled = False
        Me.txtDiasVacacion.Enabled = False
        Me.txtPrima.Enabled = False
        Me.txtPrimaVacacion.Enabled = False
        Me.txtTotalIngresos.Enabled = False
        Me.txtPromComisiones.Enabled = False
        Me.txtTotalVacacion.Enabled = False

    End Sub
    Private Sub txtCodEmpleado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEmpleado.DoubleClick
        Dim ds As New Data.DataSet
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Empleado por Código"
            ds = oPlan.ConsultarPLEmpleado("DUI,CodEmpleado,Apellido1,Apellido2,Nombres,CodTipoPersonal", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodEmpleado.Text = ofrm.Resultado2
            Me.txtNombreEmp.Text = ofrm.Resultado5 & " " & ofrm.Resultado3 & " " & ofrm.Resultado4
            Me.txtDescripcion.Text = ofrm.Resultado6
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim Campos, Valores, CamposValores As String
        Try
            Dim Resultado As Integer
            If Me.btnGuardar1.Text = "&Guardar" Then
                Resultado = Planillas.Insertar_PlVacaciones(Format(Me.dtpFechaIni_Vac.Value, "short date"), Format(Me.dtpFechaFin_Vac.Value, "short date"),
                                                             Me.txtCodTipoPlanilla.Text.Trim, Format(Me.dtpFechaIni_PL.Value, "short date"),
                                                             Format(Me.dtpFechaFin_PL.Value, "short date"), Me.txtCodEmpleado.Text,
                                                             Format(Me.DtpFechaIniPago.Value, "short date"), Format(Me.DtpFechaFinPago.Value, "short date"),
                                                             Me.txtPrimaVacacion.Text, Me.txtDiasVacacion.Text.Trim, Me.txtTotalVacacion.Text.Trim,
                                                             Now, sUsuario)
                If Resultado <> 0 Then
                    'Insertamos registro en plingresos
                    Planillas.Insertar_PlIngresos(sUsuario, sPassword, sSucursal, Me.txtCodEmpleado.Text.Trim, "004", 1, Me.txtTotalVacacion.Text.Trim,
                                                  1, Format(DtpFechaIniPago.Value, "Short Date"), Format(DtpFechaFinPago.Value, "Short Date"),
                                                  "N", "1", 1, 1)
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                End If

            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                Resultado = Planillas.Modificar_PlVacaciones(Me.vCorrelativo, Format(Me.dtpFechaIni_Vac.Value, "short date"), Format(Me.dtpFechaFin_Vac.Value, "short date"),
                                                          Me.txtCodTipoPlanilla.Text.Trim, Format(Me.dtpFechaIni_PL.Value, "short date"),
                                                          Format(Me.dtpFechaFin_PL.Value, "short date"), Me.txtCodEmpleado.Text,
                                                          Format(Me.DtpFechaIniPago.Value, "short date"), Format(Me.DtpFechaFinPago.Value, "short date"),
                                                          Me.txtPrimaVacacion.Text, Me.txtDiasVacacion.Text.Trim, Me.txtTotalVacacion.Text.Trim,
                                                          Now, sUsuario)
                If Resultado <> 0 Then
                    MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                End If

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim Dts As New DataSet
            Dts = Planillas.Calculo_Vacaciones(Format(Me.dtpFechaIni_Vac.Value, "short Date"), Format(Me.dtpFechaFin_Vac.Value, "short date"), Me.txtCodEmpleado.Text.Trim)
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.txtPrima.Text = Dts.Tables(0).Rows(0).Item("PRIMA").ToString.Trim
                Me.txtDias.Text = Dts.Tables(0).Rows(0).Item("DIAS").ToString.Trim
                Me.txtPromComisiones.Text = Dts.Tables(0).Rows(0).Item("PROMEDIOCOMISIONES").ToString.Trim
                Me.txtTotalIngresos.Text = Dts.Tables(0).Rows(0).Item("TOTALINGRESOS").ToString.Trim
                Me.txtPrimaVacacion.Text = Dts.Tables(0).Rows(0).Item("PRIMA_VACACION").ToString.Trim
                Me.txtDiasVacacion.Text = Dts.Tables(0).Rows(0).Item("PAGODIAS_VACACION").ToString.Trim
                Me.txtTotalVacacion.Text = Dts.Tables(0).Rows(0).Item("TOTAL_VACACION").ToString.Trim
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "PLF001"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                Me.txtDiasVacacion.Enabled = True
                Me.txtPrimaVacacion.Enabled = True
                Me.txtTotalVacacion.Enabled = True
                ofrmAut.Dispose()
            Else
                ofrmAut.Dispose()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class