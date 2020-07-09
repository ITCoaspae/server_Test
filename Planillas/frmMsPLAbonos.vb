Public Class frmMsPLAbonos
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

    Private pNoCaja As Integer, pCodCajero As Integer, pNoAbono As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombreEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1Monto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1nMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1nSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodDescuento As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.c1nSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1nMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodDescuento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreEmp = New System.Windows.Forms.TextBox()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c1Monto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Monto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1nSaldo
        '
        Me.c1nSaldo.BackColor = System.Drawing.Color.White
        Me.c1nSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nSaldo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nSaldo.Location = New System.Drawing.Point(427, 137)
        Me.c1nSaldo.Name = "c1nSaldo"
        Me.c1nSaldo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldo.ReadOnly = True
        Me.c1nSaldo.ShowDropDownButton = False
        Me.c1nSaldo.ShowUpDownButtons = False
        Me.c1nSaldo.Size = New System.Drawing.Size(104, 20)
        Me.c1nSaldo.TabIndex = 115
        Me.c1nSaldo.Tag = Nothing
        Me.c1nSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(372, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Saldo:"
        '
        'c1nMonto
        '
        Me.c1nMonto.BackColor = System.Drawing.Color.White
        Me.c1nMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nMonto.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMonto.Location = New System.Drawing.Point(141, 137)
        Me.c1nMonto.Name = "c1nMonto"
        Me.c1nMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMonto.ReadOnly = True
        Me.c1nMonto.ShowDropDownButton = False
        Me.c1nMonto.ShowUpDownButtons = False
        Me.c1nMonto.Size = New System.Drawing.Size(104, 20)
        Me.c1nMonto.TabIndex = 112
        Me.c1nMonto.Tag = Nothing
        Me.c1nMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Monto Inicial:"
        '
        'txtReferencia
        '
        Me.txtReferencia.BackColor = System.Drawing.Color.White
        Me.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReferencia.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtReferencia.Location = New System.Drawing.Point(141, 163)
        Me.txtReferencia.MaxLength = 1
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.ReadOnly = True
        Me.txtReferencia.Size = New System.Drawing.Size(390, 20)
        Me.txtReferencia.TabIndex = 107
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Referencia:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(141, 60)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(104, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(23, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Fecha de Aplicación:"
        '
        'txtCodDescuento
        '
        Me.txtCodDescuento.BackColor = System.Drawing.Color.White
        Me.txtCodDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDescuento.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodDescuento.Location = New System.Drawing.Point(141, 112)
        Me.txtCodDescuento.MaxLength = 1
        Me.txtCodDescuento.Name = "txtCodDescuento"
        Me.txtCodDescuento.Size = New System.Drawing.Size(104, 20)
        Me.txtCodDescuento.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Descuento:"
        '
        'txtNombreEmp
        '
        Me.txtNombreEmp.BackColor = System.Drawing.Color.White
        Me.txtNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreEmp.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.txtNombreEmp.Location = New System.Drawing.Point(235, 86)
        Me.txtNombreEmp.MaxLength = 1
        Me.txtNombreEmp.Name = "txtNombreEmp"
        Me.txtNombreEmp.ReadOnly = True
        Me.txtNombreEmp.Size = New System.Drawing.Size(296, 20)
        Me.txtNombreEmp.TabIndex = 7
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.BackColor = System.Drawing.Color.White
        Me.txtCodEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpleado.Location = New System.Drawing.Point(141, 86)
        Me.txtCodEmpleado.MaxLength = 12
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(88, 20)
        Me.txtCodEmpleado.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Empleado:"
        '
        'c1Monto
        '
        Me.c1Monto.BackColor = System.Drawing.Color.White
        Me.c1Monto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Monto.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1Monto.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1Monto.Location = New System.Drawing.Point(141, 189)
        Me.c1Monto.Name = "c1Monto"
        Me.c1Monto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1Monto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1Monto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1Monto.ShowDropDownButton = False
        Me.c1Monto.ShowUpDownButtons = False
        Me.c1Monto.Size = New System.Drawing.Size(96, 20)
        Me.c1Monto.TabIndex = 3
        Me.c1Monto.Tag = Nothing
        Me.c1Monto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Monto:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(456, 189)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 116
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(375, 189)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(75, 28)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 117
        Me.btnImprimir1.Text = "&Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'frmMsPLAbonos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(553, 272)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1Monto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.c1nSaldo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.c1nMonto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtCodDescuento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodEmpleado)
        Me.Controls.Add(Me.txtNombreEmp)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(553, 272)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(553, 272)
        Me.Name = "frmMsPLAbonos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Abono a Anticipos de Empleados"
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Monto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"

    Public Property NoCaja() As Integer
        Get
            Return pNoCaja
        End Get
        Set(ByVal Value As Integer)
            pNoCaja = Value
        End Set
    End Property

    Public Property CodCajero() As Integer
        Get
            Return pCodCajero
        End Get
        Set(ByVal Value As Integer)
            pCodCajero = Value
        End Set
    End Property

#End Region

    Private Sub frmMsPLAbonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
    End Sub


    Private Sub txtCodEmpleado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEmpleado.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet
        Dim CodEmp, Ape1, Ape2, Nom As String
        Try
            ofrm.Text = "Buscar Empleados"
            ds = oPlan.ConsultarPLEmpleado("CodEmpleado,Apellido1,Apellido2,Nombres", "Estado='A'", "CodEmpleado", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim = "" Then Exit Sub
            CodEmp = ofrm.Resultado.Trim
            Ape1 = ofrm.Resultado2.Trim
            Ape2 = ofrm.Resultado3.Trim
            Nom = ofrm.Resultado4.Trim
            Me.txtCodEmpleado.Text = CodEmp
            Me.txtNombreEmp.Text = Nom & " " & Ape1 & " " & Ape2
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtCodEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodEmpleado.Validating
        Try
            If Me.txtCodEmpleado.Text.Trim = "" Then Exit Sub
            Dim ds As New Data.DataSet, oPlan As New wrPlanilla.wsLibPlanilla
            Dim Filas As Data.DataRowCollection
            ds = oPlan.ConsultarPLEmpleado("*", "CodEmpleado LIKE '" & Trim(Me.txtCodEmpleado.Text) & "' and Estado='A'", "CodEmpleado", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count <= 0 Then
                Me.txtCodEmpleado.Text = ""
                Me.txtNombreEmp.Text = ""
            Else
                Filas = ds.Tables(0).Rows()
                Me.txtCodEmpleado.Text = CStr(Filas.Item(0)("CodEmpleado")).Trim
                Me.txtNombreEmp.Text = CStr(Filas.Item(0)("Nombres")).Trim & " " & CStr(Filas.Item(0)("Apellido1")).Trim & " " & CStr(Filas.Item(0)("Apellido2")).Trim
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtCodDescuento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDescuento.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet
        Try
            ofrm.Text = "Buscar Descuentos"
            ds = oPlan.ConsultarPLDescuentosTipo("a.Correlativo as No,b.Descripcion as Tipo_Descuento,a.NoPlaza,a.Monto,a.FechaInicio,a.FechaFin,a.Referencia,a.Saldo,a.NoCuotas", "CodEmpleado='" & Me.txtCodEmpleado.Text.Trim & "'", "a.CodEmpleado", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim = "" Then Exit Sub
            Me.txtCodDescuento.Text = ofrm.Resultado
            Me.c1nMonto.Value = ofrm.Resultado4
            Me.c1nSaldo.Value = ofrm.Resultado8
            Me.txtReferencia.Text = ofrm.Resultado7
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Try
            Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
            ds = oPlan.ImprimirPLAbonos(pNoAbono, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 95, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try

            If Me.txtCodEmpleado.Text.Trim = "" Then
                MessageBox.Show("Debe digitar el código de empleado.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.txtCodDescuento.Text.Trim = "" Then
                MessageBox.Show("Debe seleccionar el descuento.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim pHora As String, pHoras As String, pMinutos As String
            pHoras = Now.TimeOfDay.Hours.ToString
            pMinutos = Now.TimeOfDay.Minutes
            pHora = pHoras.PadLeft(2, "0") & ":" & pMinutos.PadLeft(2, "0")

            Dim oPlan As New wrPlanilla.wsLibPlanilla, oApp As New wrAdmin.wsLibAdmin
            pNoAbono = oPlan.ObtenerCorrelativoAbonos("NoAbono", sUsuario, sPassword, sSucursal)
            If oPlan.InsertarPLAbonos("NoAbono,CodEmpleado,Nombre,NoDescuento,FechaPago,Valor,FechaAplicaPago,Hora,NoCaja,CodCajero,CodSucursal", "" & pNoAbono & ",'" & Me.txtCodEmpleado.Text.Trim & "','" & Me.txtNombreEmp.Text.Trim & "','" & Me.txtCodDescuento.Text.Trim & "','" & oApp.Fecha.ToShortDateString & "'," & Me.c1Monto.Value & ",'" & Me.dtpFecha.Value.ToShortDateString & "','" & pHora & "'," & pNoCaja & "," & pCodCajero & ",'" & sSucursal & "'", Me.c1Monto.Value, Me.txtCodDescuento.Text.Trim, sUsuario, sPassword, sSucursal) = True Then
                MessageBox.Show("Los datos han sido guardados con éxito.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btnGuardar1.Enabled = False
                Me.txtCodEmpleado.ReadOnly = True
                Me.txtCodDescuento.ReadOnly = True
                Me.c1Monto.Enabled = False
                Me.btnImprimir1.Enabled = True
            Else
                MessageBox.Show("Los datos No han sido guardados.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



End Class