Public Class frmMsCrRefBan
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pNoSolic As Long, pCodEnlace As Long, pCorrelativo As Long, pAccion As String
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtInstitucion As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecApertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblFecVenc As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblNoPrestamo As System.Windows.Forms.Label
    Friend WithEvents txtEmpresaEmisora As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpEmis As System.Windows.Forms.Label
    Friend WithEvents lblFecApertura As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtEmpresaEmisora = New System.Windows.Forms.TextBox()
        Me.lblEmpEmis = New System.Windows.Forms.Label()
        Me.txtMonto = New C1.Win.C1Input.C1TextBox()
        Me.txtNoPrestamo = New System.Windows.Forms.TextBox()
        Me.dtpFecVenc = New System.Windows.Forms.DateTimePicker()
        Me.lblFecVenc = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblNoPrestamo = New System.Windows.Forms.Label()
        Me.cbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.dtpFecApertura = New System.Windows.Forms.DateTimePicker()
        Me.txtSaldo = New C1.Win.C1Input.C1TextBox()
        Me.lblFecApertura = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInstitucion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmpresaEmisora
        '
        Me.txtEmpresaEmisora.BackColor = System.Drawing.Color.White
        Me.txtEmpresaEmisora.Location = New System.Drawing.Point(133, 188)
        Me.txtEmpresaEmisora.Name = "txtEmpresaEmisora"
        Me.txtEmpresaEmisora.ReadOnly = True
        Me.txtEmpresaEmisora.Size = New System.Drawing.Size(328, 20)
        Me.txtEmpresaEmisora.TabIndex = 87
        '
        'lblEmpEmis
        '
        Me.lblEmpEmis.Location = New System.Drawing.Point(23, 188)
        Me.lblEmpEmis.Name = "lblEmpEmis"
        Me.lblEmpEmis.Size = New System.Drawing.Size(104, 16)
        Me.lblEmpEmis.TabIndex = 88
        Me.lblEmpEmis.Text = "Empresa emisora:"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.DataType = GetType(Decimal)
        Me.txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtMonto.Location = New System.Drawing.Point(133, 136)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 5
        Me.txtMonto.Tag = Nothing
        '
        'txtNoPrestamo
        '
        Me.txtNoPrestamo.BackColor = System.Drawing.Color.White
        Me.txtNoPrestamo.Location = New System.Drawing.Point(133, 162)
        Me.txtNoPrestamo.Name = "txtNoPrestamo"
        Me.txtNoPrestamo.ReadOnly = True
        Me.txtNoPrestamo.Size = New System.Drawing.Size(328, 20)
        Me.txtNoPrestamo.TabIndex = 4
        '
        'dtpFecVenc
        '
        Me.dtpFecVenc.Enabled = False
        Me.dtpFecVenc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecVenc.Location = New System.Drawing.Point(361, 110)
        Me.dtpFecVenc.Name = "dtpFecVenc"
        Me.dtpFecVenc.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecVenc.TabIndex = 6
        Me.dtpFecVenc.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'lblFecVenc
        '
        Me.lblFecVenc.Location = New System.Drawing.Point(239, 113)
        Me.lblFecVenc.Name = "lblFecVenc"
        Me.lblFecVenc.Size = New System.Drawing.Size(116, 16)
        Me.lblFecVenc.TabIndex = 86
        Me.lblFecVenc.Text = "Fecha de Vencimiento:"
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(23, 145)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(96, 16)
        Me.lblMonto.TabIndex = 84
        Me.lblMonto.Text = "Monto Otorgado:"
        '
        'lblNoPrestamo
        '
        Me.lblNoPrestamo.Location = New System.Drawing.Point(23, 165)
        Me.lblNoPrestamo.Name = "lblNoPrestamo"
        Me.lblNoPrestamo.Size = New System.Drawing.Size(104, 16)
        Me.lblNoPrestamo.TabIndex = 83
        Me.lblNoPrestamo.Text = "No. Préstamo:"
        '
        'cbTipoCuenta
        '
        Me.cbTipoCuenta.BackColor = System.Drawing.Color.White
        Me.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoCuenta.Items.AddRange(New Object() {"Ahorros", "Depósitos a Plazo", "Préstamos", "Cuentas Corrientes", "Tarjeta de Crédito", "Otra"})
        Me.cbTipoCuenta.Location = New System.Drawing.Point(133, 83)
        Me.cbTipoCuenta.Name = "cbTipoCuenta"
        Me.cbTipoCuenta.Size = New System.Drawing.Size(328, 21)
        Me.cbTipoCuenta.TabIndex = 1
        '
        'dtpFecApertura
        '
        Me.dtpFecApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecApertura.Location = New System.Drawing.Point(133, 110)
        Me.dtpFecApertura.Name = "dtpFecApertura"
        Me.dtpFecApertura.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecApertura.TabIndex = 2
        Me.dtpFecApertura.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'txtSaldo
        '
        Me.txtSaldo.DataType = GetType(Decimal)
        Me.txtSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtSaldo.Location = New System.Drawing.Point(361, 138)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
            Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtSaldo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtSaldo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtSaldo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 3
        Me.txtSaldo.Tag = Nothing
        '
        'lblFecApertura
        '
        Me.lblFecApertura.Location = New System.Drawing.Point(23, 113)
        Me.lblFecApertura.Name = "lblFecApertura"
        Me.lblFecApertura.Size = New System.Drawing.Size(104, 16)
        Me.lblFecApertura.TabIndex = 81
        Me.lblFecApertura.Text = "Fecha de Apertura:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(239, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Saldo:"
        '
        'txtInstitucion
        '
        Me.txtInstitucion.Location = New System.Drawing.Point(133, 57)
        Me.txtInstitucion.Name = "txtInstitucion"
        Me.txtInstitucion.Size = New System.Drawing.Size(328, 20)
        Me.txtInstitucion.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Tipo Cuenta:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Institución:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(386, 214)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 217
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrRefBan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(487, 272)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtEmpresaEmisora)
        Me.Controls.Add(Me.lblEmpEmis)
        Me.Controls.Add(Me.txtNoPrestamo)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblNoPrestamo)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.dtpFecVenc)
        Me.Controls.Add(Me.txtInstitucion)
        Me.Controls.Add(Me.lblFecVenc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipoCuenta)
        Me.Controls.Add(Me.lblFecApertura)
        Me.Controls.Add(Me.dtpFecApertura)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(487, 272)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(487, 272)
        Me.Name = "frmMsCrRefBan"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Referencias Financieras"
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Trim(Me.txtInstitucion.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Nombre de la Institución no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCorrelativo = oCred.ObtenerCorrelativoRefBancaria("Correlativo", sUsuario, sPassword, sSucursal)
                pCampos = "Correlativo,NumSolicitud,Institucion,TipoCuenta,FechaApertura,Saldo,CodEnlace,NoPrestamo,Monto,FechaVencimiento,EmpresaEmisora"
                pValores = "" & pCorrelativo & "," & pNoSolic & ",'" & Trim(Me.txtInstitucion.Text) & "','" & Trim(Me.cbTipoCuenta.Text) & "','" & Format(Me.dtpFecApertura.Value, "dd/MM/yyyy") & "','" & Val(Me.txtSaldo.Value) & "'," & pCodEnlace & ",'" & Me.txtNoPrestamo.Text.Trim & "','" & Val(Me.txtMonto.Value) & "','" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") & "','" & Me.txtEmpresaEmisora.Text.Trim & "'"
                If oCred.InsertarRefBancaria(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Referencia Bancaria NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Institucion='" & Trim(Me.txtInstitucion.Text) & "',TipoCuenta='" & Trim(Me.cbTipoCuenta.Text) & "',FechaApertura='" & Format(Me.dtpFecApertura.Value, "dd/MM/yyyy") & "',Saldo='" & Val(Me.txtSaldo.Value) & "',NoPrestamo='" & Me.txtNoPrestamo.Text.Trim & "',Monto='" & Val(Me.txtMonto.Value) & "',FechaVencimiento='" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") & "',EmpresaEmisora='" & Me.txtEmpresaEmisora.Text.Trim & "'"
                If oCred.ModificarRefBancaria(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Referencia no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsCrRefBan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection, x As Integer

            Me.txtSaldo.Value = 0
            Me.dtpFecApertura.Value = Now
            Me.dtpFecVenc.Value = Now

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarRefBancaria("*", "Correlativo='" & pCorrelativo & "'", "Correlativo", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtInstitucion.Text = IIf(IsDBNull(Filas.Item(0)("Institucion")), "", Filas.Item(0)("Institucion"))
                    For x = 0 To Me.cbTipoCuenta.Items.Count - 1
                        Me.cbTipoCuenta.SelectedIndex = x
                        If Trim(IIf(IsDBNull(Filas.Item(0)("TipoCuenta")), "", Filas.Item(0)("TipoCuenta"))) = Me.cbTipoCuenta.Text.Trim Then
                            Exit For
                        End If
                    Next
                    Me.dtpFecApertura.Value = IIf(IsDBNull(Filas.Item(0)("FechaApertura")), Format(Now, "dd/MM/yyyy"), Filas.Item(0)("FechaApertura"))
                    Me.txtSaldo.Value = IIf(IsDBNull(Filas.Item(0)("Saldo")), 0, Filas.Item(0)("saldo"))
                    Me.txtNoPrestamo.Text = IIf(IsDBNull(Filas.Item(0)("NoPrestamo")), "", Filas.Item(0)("NoPrestamo"))
                    Me.txtMonto.Value = IIf(IsDBNull(Filas.Item(0)("Monto")), 0, Filas.Item(0)("Monto"))
                    Me.dtpFecVenc.Value = IIf(IsDBNull(Filas.Item(0)("FechaVencimiento")), Format(Now, "dd/MM/yyyy"), Filas.Item(0)("FechaVencimiento"))
                    Me.txtEmpresaEmisora.Text = IIf(IsDBNull(Filas.Item(0)("EmpresaEmisora")), "", Filas.Item(0)("EmpresaEmisora"))
                End If

            End If
            Me.txtInstitucion.Focus()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtSaldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar1_Click(sender, e)
        End If
    End Sub

    Private Sub cbTipoCuenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoCuenta.SelectedIndexChanged
        If Me.cbTipoCuenta.SelectedIndex = 2 Then
            Me.txtNoPrestamo.ReadOnly = False
            Me.txtMonto.ReadOnly = False
            Me.dtpFecVenc.Enabled = True
            Me.txtEmpresaEmisora.ReadOnly = True
        ElseIf Me.cbTipoCuenta.SelectedIndex = 4 Then
            Me.lblNoPrestamo.Text = "Número de Tarjeta:"
            Me.txtNoPrestamo.ReadOnly = False
            Me.txtMonto.ReadOnly = False
            Me.lblMonto.Text = "Monto Límite:"
            Me.dtpFecVenc.Enabled = True
            Me.lblFecVenc.Text = "Fecha de Otorgada:"
            Me.txtEmpresaEmisora.ReadOnly = False
            Me.dtpFecApertura.Enabled = False
        Else
            Me.txtNoPrestamo.ReadOnly = True
            Me.txtMonto.ReadOnly = True
            Me.dtpFecVenc.Enabled = False
            Me.txtEmpresaEmisora.ReadOnly = True
            Me.dtpFecApertura.Enabled = True
            Me.txtNoPrestamo.Text = ""
            Me.txtMonto.Value = 0
            Me.txtEmpresaEmisora.Text = ""
        End If
    End Sub

End Class
