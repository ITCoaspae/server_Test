Public Class frmMsCrValuos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEvaluadora As System.Windows.Forms.TextBox
    Friend WithEvents txtDirProp As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecRealizado As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecRequerido As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoValuo As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProfesional As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMontoComercial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNoRegistro As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEmpVal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMontoConstruccion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtValorTerreno As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtValorTerreno = New C1.Win.C1Input.C1NumericEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMontoConstruccion = New C1.Win.C1Input.C1NumericEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCodEmpVal = New System.Windows.Forms.TextBox()
        Me.txtMontoComercial = New C1.Win.C1Input.C1NumericEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNoRegistro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProfesional = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNoValuo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEvaluadora = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDirProp = New System.Windows.Forms.TextBox()
        Me.dtpFecRealizado = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecRequerido = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtValorTerreno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoConstruccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtValorTerreno
        '
        Me.txtValorTerreno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorTerreno.CustomFormat = "###,###,##0.00"
        Me.txtValorTerreno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTerreno.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtValorTerreno.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtValorTerreno.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtValorTerreno.Location = New System.Drawing.Point(141, 274)
        Me.txtValorTerreno.Name = "txtValorTerreno"
        Me.txtValorTerreno.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtValorTerreno.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtValorTerreno.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtValorTerreno.Size = New System.Drawing.Size(130, 19)
        Me.txtValorTerreno.TabIndex = 8
        Me.txtValorTerreno.Tag = Nothing
        Me.txtValorTerreno.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorTerreno.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(23, 284)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 141
        Me.Label13.Text = "Valor Terreno:"
        '
        'txtMontoConstruccion
        '
        Me.txtMontoConstruccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoConstruccion.CustomFormat = "###,###,##0.00"
        Me.txtMontoConstruccion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoConstruccion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMontoConstruccion.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtMontoConstruccion.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMontoConstruccion.Location = New System.Drawing.Point(461, 247)
        Me.txtMontoConstruccion.Name = "txtMontoConstruccion"
        Me.txtMontoConstruccion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMontoConstruccion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMontoConstruccion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMontoConstruccion.Size = New System.Drawing.Size(112, 19)
        Me.txtMontoConstruccion.TabIndex = 7
        Me.txtMontoConstruccion.Tag = Nothing
        Me.txtMontoConstruccion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoConstruccion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(329, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 13)
        Me.Label12.TabIndex = 140
        Me.Label12.Text = "Valor de Construcción:"
        '
        'txtCodEmpVal
        '
        Me.txtCodEmpVal.Location = New System.Drawing.Point(141, 160)
        Me.txtCodEmpVal.MaxLength = 30
        Me.txtCodEmpVal.Name = "txtCodEmpVal"
        Me.txtCodEmpVal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCodEmpVal.Size = New System.Drawing.Size(48, 20)
        Me.txtCodEmpVal.TabIndex = 3
        '
        'txtMontoComercial
        '
        Me.txtMontoComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoComercial.CustomFormat = "###,###,##0.00"
        Me.txtMontoComercial.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoComercial.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMontoComercial.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtMontoComercial.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMontoComercial.Location = New System.Drawing.Point(141, 247)
        Me.txtMontoComercial.Name = "txtMontoComercial"
        Me.txtMontoComercial.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMontoComercial.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMontoComercial.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMontoComercial.Size = New System.Drawing.Size(130, 19)
        Me.txtMontoComercial.TabIndex = 6
        Me.txtMontoComercial.Tag = Nothing
        Me.txtMontoComercial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoComercial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(23, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "Valor Comercial:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(329, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Total Valúo:"
        '
        'txtNoRegistro
        '
        Me.txtNoRegistro.Location = New System.Drawing.Point(141, 221)
        Me.txtNoRegistro.MaxLength = 30
        Me.txtNoRegistro.Name = "txtNoRegistro"
        Me.txtNoRegistro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoRegistro.Size = New System.Drawing.Size(130, 20)
        Me.txtNoRegistro.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 27)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "No. Registro de Profesional:"
        '
        'txtProfesional
        '
        Me.txtProfesional.Location = New System.Drawing.Point(141, 186)
        Me.txtProfesional.MaxLength = 100
        Me.txtProfesional.Name = "txtProfesional"
        Me.txtProfesional.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProfesional.Size = New System.Drawing.Size(432, 20)
        Me.txtProfesional.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(23, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 27)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Nombre Profesional " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que avala:"
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.CustomFormat = "###,###,##0.00"
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMonto.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMonto.Location = New System.Drawing.Point(461, 274)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMonto.Size = New System.Drawing.Size(112, 19)
        Me.txtMonto.TabIndex = 9
        Me.txtMonto.Tag = Nothing
        Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtNoValuo
        '
        Me.txtNoValuo.BackColor = System.Drawing.Color.White
        Me.txtNoValuo.Enabled = False
        Me.txtNoValuo.ForeColor = System.Drawing.Color.Black
        Me.txtNoValuo.Location = New System.Drawing.Point(141, 56)
        Me.txtNoValuo.MaxLength = 200
        Me.txtNoValuo.Name = "txtNoValuo"
        Me.txtNoValuo.ReadOnly = True
        Me.txtNoValuo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoValuo.Size = New System.Drawing.Size(88, 20)
        Me.txtNoValuo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "No. Valúo:"
        '
        'txtEvaluadora
        '
        Me.txtEvaluadora.BackColor = System.Drawing.Color.White
        Me.txtEvaluadora.Location = New System.Drawing.Point(195, 160)
        Me.txtEvaluadora.MaxLength = 255
        Me.txtEvaluadora.Name = "txtEvaluadora"
        Me.txtEvaluadora.ReadOnly = True
        Me.txtEvaluadora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEvaluadora.Size = New System.Drawing.Size(378, 20)
        Me.txtEvaluadora.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 15)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Empresa Valuadora:"
        '
        'txtDirProp
        '
        Me.txtDirProp.Location = New System.Drawing.Point(141, 108)
        Me.txtDirProp.MaxLength = 255
        Me.txtDirProp.Name = "txtDirProp"
        Me.txtDirProp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDirProp.Size = New System.Drawing.Size(432, 20)
        Me.txtDirProp.TabIndex = 1
        '
        'dtpFecRealizado
        '
        Me.dtpFecRealizado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecRealizado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRealizado.Location = New System.Drawing.Point(141, 134)
        Me.dtpFecRealizado.Name = "dtpFecRealizado"
        Me.dtpFecRealizado.Size = New System.Drawing.Size(130, 20)
        Me.dtpFecRealizado.TabIndex = 2
        Me.dtpFecRealizado.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Fecha de Realizado:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Dirección Propiedad:"
        '
        'dtpFecRequerido
        '
        Me.dtpFecRequerido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecRequerido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRequerido.Location = New System.Drawing.Point(141, 82)
        Me.dtpFecRequerido.Name = "dtpFecRequerido"
        Me.dtpFecRequerido.Size = New System.Drawing.Size(130, 20)
        Me.dtpFecRequerido.TabIndex = 0
        Me.dtpFecRequerido.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Fecha de Requerido:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(498, 305)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 35
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrValuos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(593, 356)
        Me.Controls.Add(Me.txtValorTerreno)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMontoConstruccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNoValuo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMontoComercial)
        Me.Controls.Add(Me.txtCodEmpVal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFecRequerido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoRegistro)
        Me.Controls.Add(Me.txtDirProp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpFecRealizado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProfesional)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEvaluadora)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(593, 356)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(593, 356)
        Me.Name = "frmMsCrValuos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Valúos"
        CType(Me.txtValorTerreno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoConstruccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsCrValuos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            Me.dtpFecRealizado.Value = Now
            Me.dtpFecRequerido.Value = Now

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarValuos("*", "CorrelValuo='" & pCodigo & "'", "CorrelValuo", False, sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtNoValuo.Text = pCodigo
                    Me.txtNoValuo.Enabled = False
                    Me.dtpFecRequerido.Value = IIf(IsDBNull(Filas.Item(0)("FechaRequerido")), Now, Filas.Item(0)("FechaRequerido"))
                    Me.txtDirProp.Text = IIf(IsDBNull(Filas.Item(0)("DireccionPropiedad")), "", Filas.Item(0)("DireccionPropiedad"))
                    Me.dtpFecRealizado.Value = IIf(IsDBNull(Filas.Item(0)("FechaRealizado")), Now, Filas.Item(0)("FechaRealizado"))
                    Me.txtMonto.Value = IIf(IsDBNull(Filas.Item(0)("MontoValuo")), 0, Filas.Item(0)("MontoValuo"))
                    Me.txtCodEmpVal.Text = IIf(IsDBNull(Filas.Item(0)("Codigo")), "", Filas.Item(0)("Codigo"))
                    Me.txtEvaluadora.Text = IIf(IsDBNull(Filas.Item(0)("EmpresaValuadora")), "", Filas.Item(0)("EmpresaValuadora"))
                    Me.txtMontoComercial.Value = IIf(IsDBNull(Filas.Item(0)("ValorComercial")), 0, Filas.Item(0)("ValorComercial"))
                    Me.txtProfesional.Text = IIf(IsDBNull(Filas.Item(0)("ProfesionalAvala")), "", Filas.Item(0)("ProfesionalAvala"))
                    Me.txtNoRegistro.Text = IIf(IsDBNull(Filas.Item(0)("NoRegistro")), "", Filas.Item(0)("NoRegistro"))
                    Me.txtMontoConstruccion.Value = IIf(IsDBNull(Filas.Item(0)("MontoConst")), 0, Filas.Item(0)("MontoConst"))
                    Me.txtValorTerreno.Value = IIf(IsDBNull(Filas.Item(0)("MontoTerreno")), 0, Filas.Item(0)("MontoTerreno"))
                End If

            ElseIf Me.pAccion = "Agregar" Then
                Me.txtNoValuo.Text = oCred.ObtenerCorrelativoValuos("CorrelValuo", sUsuario, sPassword, sSucursal)
            End If
            Me.dtpFecRequerido.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtCodEmpVal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEmpVal.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Empresa Valuadora"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarEmpresaValuadora("Codigo,Nombre,Direccion", "Estado='1'", "Codigo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodEmpVal.Text = ofrm.Resultado.Trim
            Me.txtEvaluadora.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Protected Function ValidarMontos() As Boolean
        If Me.txtMontoConstruccion.Value <= 0 Or Me.txtValorTerreno.Value <= 0 Then
            Return False
        ElseIf Me.txtMontoConstruccion.Text.Length <> 0 Or Me.txtValorTerreno.Text.Length <> 0 Then
            Return True
        End If
    End Function

    Private Sub txtMontoConstruccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoConstruccion.LostFocus
        If Me.txtMontoConstruccion.Text.Length > 0 And Me.txtValorTerreno.Text.Length > 0 Then
            Me.txtMonto.Value = Me.txtMontoConstruccion.Value + Me.txtValorTerreno.Value
        ElseIf Me.txtMontoConstruccion.Text.Length > 0 And Me.txtValorTerreno.Text.Length = 0 Then
            Me.txtMonto.Value = Me.txtMontoConstruccion.Value
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Me.txtCodEmpVal.Text, Me.txtMonto.Text, "x", "x", "x")
                Case 1
                    MsgBox("El campo Empresa Valuadora no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 2
                    MsgBox("El Monto no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If ValidarMontos() = False Then
                MsgBox("Los Campos Valor de Construcción y Valor de Terreno no puede ser CERO", MsgBoxStyle.Critical, "Módulo Créditos")
                Exit Sub
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "CorrelValuo,FechaRequerido,DireccionPropiedad,FechaRealizado,MontoValuo,Codigo,EmpresaValuadora,ValorComercial,ProfesionalAvala,NoRegistro,MontoConst,MontoTerreno"
                pValores = "'" & Trim(Me.txtNoValuo.Text) & "','" & Format(Me.dtpFecRequerido.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtDirProp.Text) & "','" & Format(Me.dtpFecRealizado.Value, "dd/MM/yyyy") & "'," & Val(Me.txtMonto.Value) & ",'" & Me.txtCodEmpVal.Text.Trim & "','" & Trim(Me.txtEvaluadora.Text) & "'," & Val(Me.txtMontoComercial.Value) & ",'" & Trim(Me.txtProfesional.Text) & "','" & Trim(Me.txtNoRegistro.Text) & "'," & Val(Me.txtMontoConstruccion.Value) & "," & Me.txtValorTerreno.Value & ""
                If oCred.InsertarValuos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos del Valúo NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "FechaRequerido='" & Format(Me.dtpFecRequerido.Value, "dd/MM/yyyy") & "',DireccionPropiedad='" & Trim(Me.txtDirProp.Text) & "',FechaRealizado='" & Format(Me.dtpFecRealizado.Value, "dd/MM/yyyy") & "',MontoValuo=" & Val(Me.txtMonto.Value) & ",Codigo='" & Me.txtCodEmpVal.Text.Trim & "',EmpresaValuadora='" & Trim(Me.txtEvaluadora.Text) & "',ValorComercial=" & Val(Me.txtMontoComercial.Value) & ",ProfesionalAvala='" & Trim(Me.txtProfesional.Text) & "',NoRegistro='" & Trim(Me.txtNoRegistro.Text) & "',MontoConst=" & Val(Me.txtMontoConstruccion.Value) & ",MontoTerreno=" & Val(Me.txtValorTerreno.Value) & ""
                If oCred.ModificarValuos(pCodigo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos del Valúo no han sido modificados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtValorTerreno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorTerreno.LostFocus
        If Me.txtMontoConstruccion.Text.Length > 0 And Me.txtValorTerreno.Text.Length > 0 Then
            Me.txtMonto.Value = Me.txtMontoConstruccion.Value + Me.txtValorTerreno.Value
        ElseIf Me.txtMontoConstruccion.Text.Length = 0 And Me.txtValorTerreno.Text.Length > 0 Then
            Me.txtMonto.Value = Me.txtValorTerreno.Value
        End If
    End Sub
End Class