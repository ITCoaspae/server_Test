Public Class frmMSPLPlazas
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents cbCargo As System.Windows.Forms.ComboBox
    Friend WithEvents cbArea As System.Windows.Forms.ComboBox
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cbPlanilla As System.Windows.Forms.ComboBox
    Friend WithEvents chCasoEspecial As System.Windows.Forms.CheckBox
    Friend WithEvents maskDUI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private oPlan As New wrPlanilla.wsLibPlanilla

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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoPlaza As System.Windows.Forms.TextBox
    Friend WithEvents c1nSueldoMensual As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents chkSueldoVar As System.Windows.Forms.CheckBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.maskDUI = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtEstatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.chkSueldoVar = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtNoPlaza = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c1nSueldoMensual = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.cbPlanilla = New System.Windows.Forms.ComboBox()
        Me.chCasoEspecial = New System.Windows.Forms.CheckBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1nSueldoMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'maskDUI
        '
        Me.maskDUI.Location = New System.Drawing.Point(121, 92)
        Me.maskDUI.Mask = "00000000-0"
        Me.maskDUI.Name = "maskDUI"
        Me.maskDUI.Size = New System.Drawing.Size(157, 20)
        Me.maskDUI.TabIndex = 124
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpleado.Location = New System.Drawing.Point(121, 66)
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(157, 20)
        Me.txtCodEmpleado.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 26)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Código de Empleado:"
        '
        'txtApellido2
        '
        Me.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido2.Location = New System.Drawing.Point(355, 144)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(157, 20)
        Me.txtApellido2.TabIndex = 107
        '
        'txtApellido1
        '
        Me.txtApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido1.Location = New System.Drawing.Point(121, 144)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(157, 20)
        Me.txtApellido1.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(284, 146)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "Apellido2:"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(23, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 104
        Me.Label15.Text = "Apellido1:"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(23, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 103
        Me.Label14.Text = "Nombres:"
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(121, 118)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(391, 20)
        Me.txtNombres.TabIndex = 3
        '
        'txtEstatus
        '
        Me.txtEstatus.BackColor = System.Drawing.Color.White
        Me.txtEstatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstatus.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstatus.ForeColor = System.Drawing.Color.Teal
        Me.txtEstatus.Location = New System.Drawing.Point(383, 70)
        Me.txtEstatus.MaxLength = 1
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.Size = New System.Drawing.Size(120, 16)
        Me.txtEstatus.TabIndex = 17
        Me.txtEstatus.Text = "ESTADO: ACTIVA"
        Me.txtEstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "DUI:"
        '
        'chkEstado
        '
        Me.chkEstado.Location = New System.Drawing.Point(332, 172)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(72, 16)
        Me.chkEstado.TabIndex = 8
        Me.chkEstado.Text = "&Inactiva"
        '
        'chkSueldoVar
        '
        Me.chkSueldoVar.Location = New System.Drawing.Point(400, 303)
        Me.chkSueldoVar.Name = "chkSueldoVar"
        Me.chkSueldoVar.Size = New System.Drawing.Size(112, 16)
        Me.chkSueldoVar.TabIndex = 13
        Me.chkSueldoVar.Text = "&Sueldo Variable"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(27, 198)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Área:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(23, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Tipo de planilla:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Cargo:"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Checked = False
        Me.dtpFechaFinal.Enabled = False
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(355, 277)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(157, 21)
        Me.dtpFechaFinal.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(284, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Fecha Fin:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(121, 277)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(157, 21)
        Me.dtpFechaInicio.TabIndex = 7
        '
        'txtNoPlaza
        '
        Me.txtNoPlaza.BackColor = System.Drawing.Color.White
        Me.txtNoPlaza.Location = New System.Drawing.Point(121, 170)
        Me.txtNoPlaza.MaxLength = 10
        Me.txtNoPlaza.Name = "txtNoPlaza"
        Me.txtNoPlaza.ReadOnly = True
        Me.txtNoPlaza.Size = New System.Drawing.Size(157, 20)
        Me.txtNoPlaza.TabIndex = 4
        Me.txtNoPlaza.Text = "01"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Fecha de Inicio:"
        '
        'c1nSueldoMensual
        '
        Me.c1nSueldoMensual.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSueldoMensual.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nSueldoMensual.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nSueldoMensual.Location = New System.Drawing.Point(121, 304)
        Me.c1nSueldoMensual.Name = "c1nSueldoMensual"
        Me.c1nSueldoMensual.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSueldoMensual.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSueldoMensual.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSueldoMensual.ShowDropDownButton = False
        Me.c1nSueldoMensual.ShowUpDownButtons = False
        Me.c1nSueldoMensual.Size = New System.Drawing.Size(157, 21)
        Me.c1nSueldoMensual.TabIndex = 10
        Me.c1nSueldoMensual.Tag = Nothing
        Me.c1nSueldoMensual.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Sueldo Mensual:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Departamento:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Número de Plaza:"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.BackColor = System.Drawing.Color.White
        Me.cbDepartamento.DisplayMember = "DESCRIPCION"
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbDepartamento.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(121, 223)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(391, 21)
        Me.cbDepartamento.TabIndex = 119
        Me.cbDepartamento.ValueMember = "CODDEPARTAMENTO"
        '
        'cbArea
        '
        Me.cbArea.BackColor = System.Drawing.Color.White
        Me.cbArea.DisplayMember = "DESCRIPCION"
        Me.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArea.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbArea.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Location = New System.Drawing.Point(121, 196)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(391, 21)
        Me.cbArea.TabIndex = 120
        Me.cbArea.ValueMember = "CODAREA"
        '
        'cbCargo
        '
        Me.cbCargo.BackColor = System.Drawing.Color.White
        Me.cbCargo.DisplayMember = "DESCRIPCION"
        Me.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCargo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbCargo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Location = New System.Drawing.Point(121, 250)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(391, 21)
        Me.cbCargo.TabIndex = 121
        Me.cbCargo.ValueMember = "CODCARGO"
        '
        'cbPlanilla
        '
        Me.cbPlanilla.DisplayMember = "DESCRIPCION"
        Me.cbPlanilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlanilla.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlanilla.FormattingEnabled = True
        Me.cbPlanilla.Location = New System.Drawing.Point(121, 331)
        Me.cbPlanilla.Name = "cbPlanilla"
        Me.cbPlanilla.Size = New System.Drawing.Size(391, 21)
        Me.cbPlanilla.TabIndex = 122
        Me.cbPlanilla.ValueMember = "CODTIPOPLANILLA"
        '
        'chCasoEspecial
        '
        Me.chCasoEspecial.AutoSize = True
        Me.chCasoEspecial.Location = New System.Drawing.Point(410, 170)
        Me.chCasoEspecial.Name = "chCasoEspecial"
        Me.chCasoEspecial.Size = New System.Drawing.Size(93, 17)
        Me.chCasoEspecial.TabIndex = 123
        Me.chCasoEspecial.Text = "Caso Especial"
        Me.chCasoEspecial.UseVisualStyleBackColor = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(437, 358)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 138
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPLPlazas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(536, 425)
        Me.Controls.Add(Me.cbPlanilla)
        Me.Controls.Add(Me.chCasoEspecial)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.cbCargo)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.cbArea)
        Me.Controls.Add(Me.maskDUI)
        Me.Controls.Add(Me.txtNoPlaza)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.c1nSueldoMensual)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.chkSueldoVar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCodEmpleado)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEstatus)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(536, 425)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(536, 425)
        Me.Name = "frmMSPLPlazas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Plazas"
        CType(Me.c1nSueldoMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Private Sub txtCodEmpleado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEmpleado.DoubleClick
        Dim ds As New Data.DataSet
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Empleado por Código"
            ds = oPlan.ConsultarPLEmpleado("DUI,CodEmpleado,Apellido1,Apellido2,Nombres,FechaIngreso", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                Me.maskDUI.Text = ofrm.Resultado
                Me.txtCodEmpleado.Text = ofrm.Resultado2
                Me.txtApellido1.Text = ofrm.Resultado3
                Me.txtApellido2.Text = ofrm.Resultado4
                Me.txtNombres.Text = ofrm.Resultado5
                Me.dtpFechaInicio.Value = ofrm.Resultado6
                Me.txtNoPlaza.Text = oPlan.ObtenerNoPlaza(Me.txtCodEmpleado.Text.Trim, sUsuario, sPassword, sSucursal)
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub
    Private Sub frmMSPLPlazas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.btnGuardar1.Text = "&Guardar" Then
            Llenar_cbAreas()
            Llenar_cbCargos()
            Llenar_TipoPlanilla()
        End If
    End Sub
    Private Sub chkSueldoVar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSueldoVar.CheckedChanged
        If Me.chkSueldoVar.Checked = True Then
            Me.c1nSueldoMensual.Enabled = False
        Else
            Me.c1nSueldoMensual.Enabled = True
        End If
    End Sub
    Private Sub chkEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEstado.CheckedChanged
        If Me.chkEstado.Checked = True Then
            Me.dtpFechaFinal.Enabled = True
        Else
            Me.dtpFechaFinal.Enabled = False
        End If
    End Sub
#Region "Llenar Combobox"
    Public Sub Llenar_cbAreas()
        Dim Dts As New DataSet
        Dts = oPlan.Consultar_PlAreas(sUsuario, sPassword, sSucursal, 1, "") ' 1 MUESTRA TODAS LAS AREAS
        Me.cbArea.DataSource = Dts.Tables(0)
    End Sub
    Public Sub Llenar_cbDepartamentos()
        Dim Dts As New DataSet
        Dts = oPlan.CONSULTAR_PLDEPARTAMENTOS(sUsuario, sPassword, sSucursal, 2, Me.cbArea.SelectedValue, "", "") '2 MUESTRA TODOS LOS DEPARTAMENTOS DE UN AREÁ ESPECIFICA.
        Me.cbDepartamento.DataSource = Dts.Tables(0)
    End Sub
    Public Sub Llenar_cbCargos()
        Dim Dts As New DataSet
        Dts = oPlan.Consultar_PlCargos(sUsuario, sPassword, sSucursal, 1, "") '1 Muestra todos los cargos
        Me.cbCargo.DataSource = Dts.Tables(0)
    End Sub
    Public Sub Llenar_TipoPlanilla()
        Dim Dts As New DataSet
        Dts = oPlan.CONSULTAR_PLTIPOPLANILLA(sUsuario, sPassword, sSucursal)
        Me.cbPlanilla.DataSource = Dts.Tables(0)
    End Sub
#End Region
    Private Sub cbArea_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbArea.DropDownClosed
        Llenar_cbDepartamentos()
    End Sub
    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos As String, Valores As String, CamposValores As String
            Dim Resultado As Integer
            If Me.btnGuardar1.Text = "&Guardar" Then
                Resultado = oPlan.Insertar_PlPlazas(sUsuario, sPassword, sSucursal, Me.txtCodEmpleado.Text.Trim, Me.cbDepartamento.SelectedValue,
                                                     Me.cbArea.SelectedValue, Format(Me.dtpFechaInicio.Value, "SHORT DATE"), Format(Me.dtpFechaFinal.Value, "SHORT DATE"),
                                                    IIf(chkSueldoVar.Checked = True, "1", "0"), Me.c1nSueldoMensual.Value, Me.cbCargo.SelectedValue, Me.cbPlanilla.SelectedValue.ToString,
                                                    IIf(chkEstado.Checked = True, "I", "A"), IIf(chCasoEspecial.Checked = True, True, False))
                If Resultado <> 0 Then
                    MsgBox("Los datos fueron ingresados correctamente", MsgBoxStyle.Information, "Módulo - Planilla")
                    Me.Dispose()
                Else
                    MsgBox("Los datos NO fueron ingresados correctamente", MsgBoxStyle.Critical, "Módulo - Planilla")
                    Me.Dispose()
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                Resultado = oPlan.Modificar_PlPlazas(sUsuario, sPassword, sSucursal, Me.txtCodEmpleado.Text.Trim, Me.txtNoPlaza.Text.Trim, Me.cbDepartamento.SelectedValue,
                                                     Me.cbArea.SelectedValue, Format(Me.dtpFechaInicio.Value, "SHORT DATE"), Format(Me.dtpFechaFinal.Value, "SHORT DATE"),
                                                    IIf(chkSueldoVar.Checked = True, "1", "0"), Me.c1nSueldoMensual.Value, Me.cbCargo.SelectedValue, Me.cbPlanilla.SelectedValue.ToString,
                                                    IIf(chkEstado.Checked = True, "I", "A"), IIf(chCasoEspecial.Checked = True, True, False))
                If Resultado <> 0 Then
                    MsgBox("Los datos fueron modificados correctamente", MsgBoxStyle.Information, "Módulo - Planilla")
                    Me.Dispose()
                Else
                    MsgBox("Los datos NO fueron modificados correctamente", MsgBoxStyle.Critical, "Módulo - Planilla")
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
