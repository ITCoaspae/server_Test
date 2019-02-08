Public Class frmMsCBGestores
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUsuario As TextBox
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbExterno As System.Windows.Forms.RadioButton
    Friend WithEvents rbInterno As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNit As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents nuPorcentaje As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDepto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodDepto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodArea As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbExterno = New System.Windows.Forms.RadioButton()
        Me.rbInterno = New System.Windows.Forms.RadioButton()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodArea = New System.Windows.Forms.TextBox()
        Me.txtCodDepto = New System.Windows.Forms.TextBox()
        Me.txtDepto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nuPorcentaje = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNit = New C1.Win.C1Input.C1TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        CType(Me.nuPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(23, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tipo de Gestor:"
        '
        'rbExterno
        '
        Me.rbExterno.BackColor = System.Drawing.Color.White
        Me.rbExterno.Location = New System.Drawing.Point(215, 63)
        Me.rbExterno.Name = "rbExterno"
        Me.rbExterno.Size = New System.Drawing.Size(64, 16)
        Me.rbExterno.TabIndex = 2
        Me.rbExterno.Text = "&Externo"
        Me.rbExterno.UseVisualStyleBackColor = False
        '
        'rbInterno
        '
        Me.rbInterno.BackColor = System.Drawing.Color.White
        Me.rbInterno.Checked = True
        Me.rbInterno.Location = New System.Drawing.Point(145, 63)
        Me.rbInterno.Name = "rbInterno"
        Me.rbInterno.Size = New System.Drawing.Size(64, 16)
        Me.rbInterno.TabIndex = 1
        Me.rbInterno.TabStop = True
        Me.rbInterno.Text = "&Interno"
        Me.rbInterno.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(145, 141)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(368, 20)
        Me.txtNombre.TabIndex = 10
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(145, 89)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(271, 279)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 16)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Fecha de Finalización:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(23, 279)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Fecha de Ingreso:"
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(393, 275)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(120, 20)
        Me.dtpFin.TabIndex = 23
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(145, 275)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(120, 20)
        Me.dtpInicio.TabIndex = 21
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseña.Location = New System.Drawing.Point(418, 54)
        Me.txtContraseña.MaxLength = 10
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(21, 20)
        Me.txtContraseña.TabIndex = 4
        Me.txtContraseña.Visible = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(316, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 140
        Me.Label15.Text = "Contraseña:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Visible = False
        '
        'txtCodArea
        '
        Me.txtCodArea.Location = New System.Drawing.Point(302, 59)
        Me.txtCodArea.Name = "txtCodArea"
        Me.txtCodArea.Size = New System.Drawing.Size(8, 20)
        Me.txtCodArea.TabIndex = 138
        Me.txtCodArea.Visible = False
        '
        'txtCodDepto
        '
        Me.txtCodDepto.Location = New System.Drawing.Point(294, 59)
        Me.txtCodDepto.Name = "txtCodDepto"
        Me.txtCodDepto.Size = New System.Drawing.Size(8, 20)
        Me.txtCodDepto.TabIndex = 137
        Me.txtCodDepto.Visible = False
        '
        'txtDepto
        '
        Me.txtDepto.BackColor = System.Drawing.Color.White
        Me.txtDepto.Location = New System.Drawing.Point(145, 197)
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.ReadOnly = True
        Me.txtDepto.Size = New System.Drawing.Size(368, 20)
        Me.txtDepto.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Departamento:"
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpleado.Location = New System.Drawing.Point(393, 89)
        Me.txtCodEmpleado.MaxLength = 5
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(120, 20)
        Me.txtCodEmpleado.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(271, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cód. Empleado:"
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Location = New System.Drawing.Point(207, 249)
        Me.txtCuenta.MaxLength = 100
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(306, 20)
        Me.txtCuenta.TabIndex = 19
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Location = New System.Drawing.Point(145, 249)
        Me.txtIdCuenta.MaxLength = 20
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(56, 20)
        Me.txtIdCuenta.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(23, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Cuenta contable:"
        '
        'nuPorcentaje
        '
        Me.nuPorcentaje.DecimalPlaces = 2
        Me.nuPorcentaje.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nuPorcentaje.Location = New System.Drawing.Point(145, 223)
        Me.nuPorcentaje.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nuPorcentaje.Name = "nuPorcentaje"
        Me.nuPorcentaje.Size = New System.Drawing.Size(120, 20)
        Me.nuPorcentaje.TabIndex = 16
        Me.nuPorcentaje.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(23, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 28)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Porcentaje de Comisión por Gestión:"
        '
        'txtNit
        '
        Me.txtNit.EditMask = "0000-000000-000-0"
        Me.txtNit.Location = New System.Drawing.Point(145, 168)
        Me.txtNit.MaxLength = 20
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NumericInput = False
        Me.txtNit.Size = New System.Drawing.Size(120, 18)
        Me.txtNit.TabIndex = 12
        Me.txtNit.Tag = Nothing
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nit:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardar1.Location = New System.Drawing.Point(438, 301)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 24
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(145, 115)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(368, 20)
        Me.txtUsuario.TabIndex = 8
        '
        'frmMsCBGestores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(541, 361)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtCodArea)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.txtCodDepto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.nuPorcentaje)
        Me.Controls.Add(Me.rbInterno)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDepto)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.rbExterno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodEmpleado)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(541, 361)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(541, 361)
        Me.Name = "frmMsCBGestores"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Administración de Gestores"
        CType(Me.nuPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsCBGestores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection, oPerif As New wrConta.wsLibContab, oPl As New wrPlanilla.wsLibPlanilla, dr As DataRow

        If Me.pAccion = "Modificar" Then

            ds = oCred.ConsultarGestores("*", "CodGestor='" & pCodigo & "'", "CodGestor", sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtCodigo.Text = pCodigo
                txtCodigo.Enabled = False
                txtNit.Value = IIf(IsDBNull(Filas.Item(0)("Nit")), "", Filas.Item(0)("Nit"))
                txtNombre.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                txtUsuario.Text = IIf(IsDBNull(Filas.Item(0)("usuario")), "", Filas.Item(0)("usuario"))
                If CStr(Filas.Item(0)("Tipo")) = "I" Then
                    rbInterno.Checked = True
                ElseIf CStr(Filas.Item(0)("Tipo")) = "E" Then
                    rbExterno.Checked = True
                End If
                nuPorcentaje.Value = IIf(IsDBNull(Filas.Item(0)("PorcentajeComision")), 1, Filas.Item(0)("PorcentajeComision"))
                txtIdCuenta.Text = IIf(IsDBNull(Filas.Item(0)("IdCuenta")), "", Filas.Item(0)("IdCuenta"))
                txtCodEmpleado.Text = IIf(IsDBNull(Filas.Item(0)("CodEmpleado")), "", Filas.Item(0)("CodEmpleado"))
                Me.txtContraseña.ReadOnly = True
                If Not Filas.Item(0)("FechaIngreso") Is DBNull.Value Then
                    dtpInicio.Value = Filas.Item(0)("FechaIngreso")
                End If
                If Not Filas.Item(0)("FechaFinalizacion") Is DBNull.Value Then
                    dtpFin.Value = Filas.Item(0)("FechaFinalizacion")
                End If
                ds = oPerif.ObtenerCatContab("*", "IdCuenta='" & Me.txtIdCuenta.Text.Trim & "'", "IdCuenta", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtCuenta.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If

                ds = oPl.ConsultarPLPlazas("CodArea,CodDepartamento", "CodEmpleado='" & Me.txtCodEmpleado.Text.Trim & "'", "CodEmpleado", False, sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCodDepto.Text = dr("CodDepartamento")
                    Me.txtCodArea.Text = dr("CodArea")
                    If Me.txtCodDepto.Text.Trim <> "" Then
                        ds = oPl.ConsultarPLDepartamentos("Descripcion", "CodDepartamento='" & Me.txtCodDepto.Text.Trim & "' and CodArea='" & Me.txtCodArea.Text.Trim & "'", "CodArea", sUsuario, sPassword, sSucursal)
                        If ds.Tables(0).Rows.Count > 0 Then
                            dr = ds.Tables(0).Rows(0)
                            Me.txtDepto.Text = dr("Descripcion")
                        Else
                            Me.txtCodDepto.Text = ""
                            Me.txtCodArea.Text = ""
                            Me.txtDepto.Text = ""
                        End If
                    End If
                Else
                    Me.txtCodDepto.Text = ""
                    Me.txtCodArea.Text = ""
                    Me.txtDepto.Text = ""
                End If

            End If
        Else
            Me.dtpInicio.Value = Now
            Me.dtpFin.Value = Now
            Me.txtCodigo.Text = oCred.ObtenerCorrelativoGestores("CodGestor", sUsuario, sPassword, sSucursal)
        End If
        txtCodigo.Focus()
    End Sub



    Private Sub nuPorcentaje_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nuPorcentaje.GotFocus
        Me.nuPorcentaje.Select(0, Len(Me.nuPorcentaje.Value))
    End Sub

    Private Sub nuPorcentaje_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nuPorcentaje.Validating
        If Me.nuPorcentaje.Value > 100 Then e.Cancel = True
    End Sub

    Private Sub txtIdCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuenta.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Cuenta Bancaria"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("*", "", "IdCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtIdCuenta.Text = ofrm.Resultado.Trim
            Me.txtCuenta.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catálogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEmpleado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEmpleado.DoubleClick
        Dim ofrm As New frmAGenerico
        If Me.rbExterno.Checked = True Then Exit Sub
        ofrm.Text = "Buscar Empleados"
        Dim oPl As New wrPlanilla.wsLibPlanilla, ds As New Data.DataSet, dr As DataRow
        Try
            ds = oPl.ConsultarEmpleados("CodEmpleado,Apellido1,Apellido2,ApellidoCas,Nombres,Nit", "", "CodEmpleado", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodEmpleado.Text = ofrm.Resultado.Trim
            Me.txtNombre.Text = ofrm.Resultado5.Trim & " " & ofrm.Resultado4.Trim & " " & ofrm.Resultado2.Trim & " " & ofrm.Resultado3.Trim
            Me.txtNit.Value = ofrm.Resultado6.Trim
            If Me.txtCodEmpleado.Text.Trim <> "" Then
                ds = oPl.ConsultarPLPlazas("CodArea,CodDepartamento", "CodEmpleado='" & Me.txtCodEmpleado.Text.Trim & "'", "CodEmpleado", False, sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCodDepto.Text = dr("CodDepartamento")
                    Me.txtCodArea.Text = dr("CodArea")
                    If Me.txtCodDepto.Text.Trim <> "" Then
                        ds = oPl.ConsultarPLDepartamentos("Descripcion", "CodDepartamento='" & Me.txtCodDepto.Text.Trim & "' and CodArea='" & Me.txtCodArea.Text.Trim & "'", "CodArea", sUsuario, sPassword, sSucursal)
                        If ds.Tables(0).Rows.Count > 0 Then
                            dr = ds.Tables(0).Rows(0)
                            Me.txtDepto.Text = dr("Descripcion")
                        Else
                            Me.txtCodDepto.Text = ""
                            Me.txtCodArea.Text = ""
                            Me.txtDepto.Text = ""
                        End If
                    End If
                Else
                    Me.txtCodDepto.Text = ""
                    Me.txtCodArea.Text = ""
                    Me.txtDepto.Text = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Empleados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbExterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExterno.CheckedChanged
        If rbExterno.Checked = True Then
            Me.txtCodEmpleado.Text = ""
            Me.txtCodEmpleado.ReadOnly = True
            Me.txtNombre.ReadOnly = False
            Me.txtNombre.Text = ""
        ElseIf rbInterno.Checked = True Then
            Me.txtCodEmpleado.ReadOnly = False
            Me.txtNombre.ReadOnly = True
        End If
    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String, pTipo As String

            If Me.txtCodigo.Text.Trim = "" Then
                MsgBox("El Código de Gestor no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Cobranzas")
                Exit Sub
            End If

            If Me.rbInterno.Checked = True Then
                pTipo = "I"
            ElseIf Me.rbExterno.Checked = True Then
                pTipo = "E"
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "Nit,Nombre,Tipo,PorcentajeComision,IdCuenta,CodEmpleado,FechaIngreso,FechaFinalizacion,usuario"
                pValores = "'" & Trim(Me.txtNit.Value) & "','" & Trim(txtNombre.Text) & "','" & pTipo & "'," & Val(nuPorcentaje.Value) & ",'" & txtIdCuenta.Text.Trim & "','" & Me.txtCodEmpleado.Text.Trim & "','" & Format(Me.dtpInicio.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFin.Value, "dd/MM/yyyy") & "', '" & txtUsuario.Text.Trim & "' "
                If oCred.InsertarGestores(pCampos, pValores, Me.txtContraseña.Text.Trim, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Gestor NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Nit='" & Trim(Me.txtNit.Value) & "',Nombre='" & Trim(txtNombre.Text) & "',Tipo='" & pTipo & "',PorcentajeComision=" & Val(nuPorcentaje.Value) & ",IdCuenta='" & txtIdCuenta.Text.Trim & "',CodEmpleado='" & Me.txtCodEmpleado.Text.Trim & "',FechaIngreso='" & Format(Me.dtpInicio.Value, "dd/MM/yyyy") & "',FechaFinalizacion='" & Format(Me.dtpFin.Value, "dd/MM/yyyy") & "', usuario = '" & txtUsuario.Text.Trim & "'"
                If oCred.ModificarGestores(Trim(pCodigo), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Gestor no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub rbInterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInterno.CheckedChanged
        If rbExterno.Checked = True Then
            Me.txtCodEmpleado.Text = ""
            Me.txtCodEmpleado.ReadOnly = True
            Me.txtNombre.ReadOnly = False
            Me.txtNombre.Text = ""
        ElseIf rbInterno.Checked = True Then
            Me.txtCodEmpleado.ReadOnly = False
            Me.txtNombre.ReadOnly = True
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub txtUsuario_DoubleClick(sender As Object, e As EventArgs) Handles txtUsuario.DoubleClick
        Dim dts As New DataSet
        Dim admin As New wrAdmin.wsLibAdmin



        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Usuarios"

        Try
            dts = admin.ConsultarUsuario("usuario,nombre", "", "nombre", sUsuario, sPassword, sSucursal)
            ofrm.Datos = dts
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtUsuario.Text = ofrm.Resultado
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class