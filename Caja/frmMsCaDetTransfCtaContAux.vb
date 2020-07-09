Public Class frmMsCaDetTransfCtaContAux
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents txtNombCosto As TextBox
    Friend WithEvents txtCodCosto As TextBox
    Friend WithEvents Label2 As Label
    Dim CCodCosto As String = ""
    Private pDui As String, pNoCuenta As String, ofrmT As frmMCaTransfCtaContAux, pFecha As Date
    Private selectedIndex As Integer
    Dim contabilidad As New wrConta.wsLibContab
    Dim credito As New wrCredito.wsLibCred
    Dim pMontoTransferencia As Double
        Public ctaconta1 As String
    Public ccCuenta As String
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents txtCodTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1txtNoCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents cbTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents btNProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNombCosto = New System.Windows.Forms.TextBox()
        Me.txtCodCosto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodTipo = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.c1txtNoCuenta = New C1.Win.C1Input.C1TextBox()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.cbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btNProcesar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNoCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombCosto
        '
        Me.txtNombCosto.BackColor = System.Drawing.Color.White
        Me.txtNombCosto.Location = New System.Drawing.Point(240, 202)
        Me.txtNombCosto.Name = "txtNombCosto"
        Me.txtNombCosto.ReadOnly = True
        Me.txtNombCosto.Size = New System.Drawing.Size(453, 22)
        Me.txtNombCosto.TabIndex = 12
        '
        'txtCodCosto
        '
        Me.txtCodCosto.BackColor = System.Drawing.Color.White
        Me.txtCodCosto.Location = New System.Drawing.Point(148, 202)
        Me.txtCodCosto.Name = "txtCodCosto"
        Me.txtCodCosto.ReadOnly = True
        Me.txtCodCosto.Size = New System.Drawing.Size(86, 22)
        Me.txtCodCosto.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Centro Costo:"
        '
        'txtCodTipo
        '
        Me.txtCodTipo.BackColor = System.Drawing.Color.White
        Me.txtCodTipo.Location = New System.Drawing.Point(444, 41)
        Me.txtCodTipo.Name = "txtCodTipo"
        Me.txtCodTipo.Size = New System.Drawing.Size(58, 22)
        Me.txtCodTipo.TabIndex = 0
        Me.txtCodTipo.Visible = False
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Location = New System.Drawing.Point(240, 174)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(453, 22)
        Me.txtCuenta.TabIndex = 9
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.BackColor = System.Drawing.Color.White
        Me.txtIdCuenta.Location = New System.Drawing.Point(148, 174)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.ReadOnly = True
        Me.txtIdCuenta.Size = New System.Drawing.Size(86, 22)
        Me.txtIdCuenta.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cuenta Contable:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Monto:"
        '
        'c1txtMonto
        '
        Me.c1txtMonto.BackColor = System.Drawing.Color.White
        Me.c1txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtMonto.CustomFormat = "###,##0.00"
        Me.c1txtMonto.DataType = GetType(Double)
        Me.c1txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1txtMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1txtMonto.Location = New System.Drawing.Point(148, 144)
        Me.c1txtMonto.Name = "c1txtMonto"
        Me.c1txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(0R, Nothing, True, True)})
        Me.c1txtMonto.Size = New System.Drawing.Size(545, 24)
        Me.c1txtMonto.TabIndex = 6
        Me.c1txtMonto.Tag = Nothing
        Me.c1txtMonto.Value = 0R
        Me.c1txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1txtNoCuenta
        '
        Me.c1txtNoCuenta.BackColor = System.Drawing.Color.White
        Me.c1txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNoCuenta.Location = New System.Drawing.Point(148, 114)
        Me.c1txtNoCuenta.MaxLength = 14
        Me.c1txtNoCuenta.Name = "c1txtNoCuenta"
        Me.c1txtNoCuenta.NumericInput = False
        Me.c1txtNoCuenta.ReadOnly = True
        Me.c1txtNoCuenta.Size = New System.Drawing.Size(545, 24)
        Me.c1txtNoCuenta.TabIndex = 4
        Me.c1txtNoCuenta.Tag = Nothing
        '
        'lblCuenta
        '
        Me.lblCuenta.Location = New System.Drawing.Point(23, 115)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(119, 19)
        Me.lblCuenta.TabIndex = 3
        Me.lblCuenta.Text = "Cuenta Asociado:"
        '
        'cbTipoCuenta
        '
        Me.cbTipoCuenta.BackColor = System.Drawing.Color.White
        Me.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoCuenta.Items.AddRange(New Object() {"Prestamos", "Ahorros", "DPF", "Cuenta por cobrar"})
        Me.cbTipoCuenta.Location = New System.Drawing.Point(148, 83)
        Me.cbTipoCuenta.Name = "cbTipoCuenta"
        Me.cbTipoCuenta.Size = New System.Drawing.Size(545, 24)
        Me.cbTipoCuenta.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(23, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Tipo Cuenta:"
        '
        'btNProcesar1
        '
        Me.btNProcesar1.Location = New System.Drawing.Point(603, 230)
        Me.btNProcesar1.Name = "btNProcesar1"
        Me.btNProcesar1.Size = New System.Drawing.Size(90, 33)
        Me.btNProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNProcesar1.TabIndex = 13
        Me.btNProcesar1.Text = "Guardar"
        Me.btNProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNProcesar1.UseSelectable = True
        Me.btNProcesar1.UseStyleColors = True
        '
        'frmMsCaDetTransfCtaContAux
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(720, 289)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodCosto)
        Me.Controls.Add(Me.txtNombCosto)
        Me.Controls.Add(Me.btNProcesar1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtCodTipo)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.cbTipoCuenta)
        Me.Controls.Add(Me.c1txtNoCuenta)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.c1txtMonto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(720, 257)
        Me.Name = "frmMsCaDetTransfCtaContAux"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Cuenta Destino"
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNoCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "Propiedades"
    Public Property montoTransferencia() As Double
        Get
            Return pMontoTransferencia
        End Get
        Set(value As Double)
            pMontoTransferencia = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return pFecha
        End Get
        Set(ByVal Value As Date)
            pFecha = Value
        End Set
    End Property
    Public Property FrmT() As frmMCaTransfCtaContAux
        Get
            Return ofrmT
        End Get
        Set(ByVal Value As frmMCaTransfCtaContAux)
            ofrmT = Value
        End Set
    End Property
    Public Property Dui() As String
        Get
            Return pDui
        End Get
        Set(ByVal Value As String)
            pDui = Value
        End Set
    End Property
    Public Property NoCuenta() As String
        Get
            Return pNoCuenta
        End Get
        Set(ByVal Value As String)
            pNoCuenta = Value
        End Set
    End Property
#End Region

    Private Sub frmMsCaDetTransfCtaContAux_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbTipoCuenta.SelectedIndex = 0
    End Sub


    Private Sub cbTipoCuenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoCuenta.SelectedIndexChanged
        selectedIndex = Me.cbTipoCuenta.SelectedIndex
        If cbTipoCuenta.SelectedIndex = 3 Then
            Label1.Visible = False
            txtIdCuenta.Visible = False
            txtCuenta.Visible = False
            Label2.Visible = False
            txtCodCosto.Visible = False
            txtNombCosto.Visible = False
        Else
            Label1.Visible = True
            txtIdCuenta.Visible = True
            txtCuenta.Visible = True
            Label2.Visible = True
            txtCodCosto.Visible = True
            txtNombCosto.Visible = True
        End If
    End Sub
    Private Function validarMontoCancelar(codPrestamo As String) As Boolean
        Dim dts As New DataSet
        Dim total As Double
        dts = credito.validarMontoCancelacionPrestamo(codPrestamo)
        If dts.Tables(0).Rows.Count > 0 Then
            total = Math.Round(dts.Tables(0).Rows(0).Item("total"), 2)
            If c1txtMonto.Value > total Then
                MetroFramework.MetroMessageBox.Show(Me, "Valor no puede ser mayor que el monto de cancelación del prestamo, monto de cancelación: " & total.ToString, "Advertencia", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
                Return False
            Else
                Return True
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Error, problema al momento de validar el monto de cancelación del prestamo", "Advertencia", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            Return False
        End If
    End Function
    Private Sub btNProcesar1_Click(sender As Object, e As EventArgs) Handles btNProcesar1.Click
        Try
            If Me.c1txtNoCuenta.Text.Trim = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "El número de Cuenta no puede quedar vacío.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                Exit Sub
            End If

            If Me.c1txtMonto.Value = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Monto a transferir no puede ser cero.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Me.txtIdCuenta.Text.Trim = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Cuenta Contable no puede quedar vacía.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If montoTransferencia < c1txtMonto.Value Then
                MetroFramework.MetroMessageBox.Show(Me, "Monto no puede ser mayor, que el monto total de la transferencia", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If selectedIndex = 0 Then
                If validarMontoCancelar(c1txtNoCuenta.Value.ToString.Trim) = False Then
                    Exit Sub
                End If
            End If

            Dim oAh As New wrAhorro.wsLibAhorro, ds As DataSet, pTipoCuenta As String
            If Me.cbTipoCuenta.SelectedIndex = 0 Then 'Préstamos
                pTipoCuenta = "P"
            ElseIf cbTipoCuenta.SelectedIndex = 3 Then
                FrmT.ctaPorCobrar = True
                pTipoCuenta = "C"
            Else 'Ahorro,Aportación, DPF
                pTipoCuenta = "A"
            End If
            ccCuenta = Me.txtCodCosto.Text.ToString
            ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.c1txtNoCuenta.Value, Me.c1txtMonto.Value, Me.txtCodTipo.Text.Trim, pTipoCuenta, Me.txtIdCuenta.Text.Trim, pFecha, txtCodCosto.Text)
            FrmT.dsDetalle = ds
            FrmT.noCtaAuxiliar = c1txtNoCuenta.Value
            '--- CAMBIO PARA LA APLICACION DE CENTRO DE COSTOS
            '     HASTA QUE SE IMPLEMENTE EL PROCESO EN CONTABILIDAD
            '     PROG01   ((22/05/2020))
            'If Me.txtIdCuenta.Text.Trim = "21010101" Or Me.txtIdCuenta.Text.Trim = "21010102" Or Me.txtIdCuenta.Text.Trim = "2101030102" Then
            '    ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "C", "22010407", pFecha, CStr(txtCodCosto.Text))
            '    FrmT.dsDetalle = ds
            '    ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "A", "22010407", pFecha, ccCuenta)
            '    FrmT.dsDetalle = ds
            'End If
            'If Me.txtIdCuenta.Text.Trim = "310101" Then
            '    ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "C", "22010409", pFecha, CStr(txtCodCosto.Text))
            '    FrmT.dsDetalle = ds
            '    ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "A", "22010409", pFecha, ccCuenta)
            '    FrmT.dsDetalle = ds
            'End If
            'Dim cta2 As String = Mid(Me.txtIdCuenta.Text.Trim, 1, 6)
            'If cta2.ToString = "210102" Then
            '    If Me.txtIdCuenta.Text.Trim = "21010208" Then
            '        ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "C", "22010407", pFecha, CStr(txtCodCosto.Text))
            '        FrmT.dsDetalle = ds
            '        ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "A", "22010407", pFecha, ccCuenta)
            '        FrmT.dsDetalle = ds
            '    Else
            '        ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "C", "22010408", pFecha, CStr(txtCodCosto.Text))
            '        FrmT.dsDetalle = ds
            '        ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "A", "22010408", pFecha, ccCuenta)
            '        FrmT.dsDetalle = ds
            '    End If
            'End If
            'Dim cta3 As String = Mid(Me.txtIdCuenta.Text.Trim, 1, 6)
            'If cta3.ToString = "110402" Then
            '    ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "C", "22010406", pFecha, CStr(txtCodCosto.Text))
            '    FrmT.dsDetalle = ds
            '    ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "A", "22010406", pFecha, ccCuenta)
            '    FrmT.dsDetalle = ds
            'End If
            '--- FIN DE CAMBIO PARA LA APLICACION DE CENTRO DE COSTOS
            '     HASTA QUE SE IMPLEMENTE EL PROCESO EN CONTABILIDAD
            '     PROG01   ((22/05/2020))
            Me.Dispose()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub c1txtNoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1txtNoCuenta.DoubleClick
        Dim frm As New frmAGenerico
        Dim noCta As String
        Dim oAhorro As New wrAhorro.wsLibAhorro, oPerif As New wrConta.wsLibContab
        Dim oPrest As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
        Dim ds As New Data.DataSet, dr As DataRow

        Try
            If selectedIndex = 0 Then
                ds = oPrest.ConsultarPRPrestamosTipoCredito("a.CodPrestamo," &
                                                            "a.CodTipoCredito, " &
                                                            "b.Descripcion as Tipo_Credito, " &
                                                            "a.Monto, " &
                                                            "a.Saldo_Capital as Saldo, " &
                                                            "b.IdCuenta as Cuenta_Contable, " &
                                                            "a.FechaOtorgamiento as Fecha_Otorgamiento, " &
                                                            "sc.CodSucursal, d.Cod_CCosto, c.Descripcion ", "a.DUI='" & pDui & "' and a.Estado<>'C'", "a.Dui", sUsuario, sPassword, sSucursal)
            ElseIf selectedIndex = 1 Then
                ds = oAhorro.ConsultarCtasAhorroDUI("a.NoCuenta, " &
                                                    "a.CodTipoAhorro, " &
                                                    "b.Descripcion as Tipo, " &
                                                    "a.MontoApertura as Monto, " &
                                                    "a.SaldoDisponible_CuentaAhorro as Saldo, " &
                                                    "b.IdCuenta as Cuenta_Contable, " &
                                                    "a.FechaApertura, " &
                                                    "a.IdCertificadoDPF as No_Certificado," &
                                                    "a.codSucursal, d.Cod_CCosto, d.Descripcion ", "a.DUI='" & pDui & "' AND a.NoCuenta not like '" & pNoCuenta & "' AND left(a.CodTipoAhorro,1) <> '6'  AND a.Estado <> 'C' and a.Estado<>'B'", "", sUsuario, sPassword, sSucursal)
            ElseIf selectedIndex = 2 Then
                ds = oAhorro.ConsultarCtasAhorroDUI("a.NoCuenta, " &
                                                    "a.CodTipoAhorro, " &
                                                    "b.Descripcion as Tipo, " &
                                                    "a.MontoApertura as Monto," &
                                                    "a.SaldoDisponible_CuentaAhorro as Saldo," &
                                                    "b.IdCuenta as Cuenta_Contable," &
                                                    "a.FechaApertura," &
                                                    "a.IdCertificadoDPF as No_Certificado," &
                                                    "a.codSucursal, d.Cod_CCosto, d.Descripcion ", "a.DUI='" & pDui & "' AND a.NoCuenta not like '" & pNoCuenta & "' AND left(a.CodTipoAhorro,1) = '" & sifLib.Ahorro.clsAhorros.tiposAhorro.dpf & "'  AND a.Estado = 'D'", "", sUsuario, sPassword, sSucursal)
            ElseIf selectedIndex = 3 Then
                ds = contabilidad.consultarCuentaPorCobrar(Dui, 2, Now, Now, "", 0)
            Else
                Exit Sub
            End If
            If ds.Tables.Count > 0 Then
                frm.Text = "Buscar Cuenta"
                frm.Datos = ds
                frm.ColSeleccion = 0
                frm.RefrescarGrid()
                frm.ShowDialog()
                If frm.Resultado.Trim <> "" Then
                    noCta = IIf(IsDBNull(frm.Resultado.Trim), "", frm.Resultado.Trim)
                    Me.c1txtNoCuenta.Value = noCta
                    Me.txtCodTipo.Text = frm.Resultado2.Trim
                    If selectedIndex = 0 Then
                        Me.txtIdCuenta.Text = contabilidad.Recuperar_Cta_x_Centro_Costo(frm.Resultado8, frm.Resultado6.Trim) 'frm.Resultado7.Trim
                        txtCodCosto.Text = frm.Resultado9
                        txtNombCosto.Text = frm.Resultado10
                    ElseIf selectedIndex = 3 Then
                        Dim dtsCxC As New DataSet
                        dtsCxC = contabilidad.consultarCuentaPorCobrar("", 6, Now, Now, "", noCta)
                        If dtsCxC.Tables(0).Rows.Count > 0 Then
                            txtCodCosto.Text = dtsCxC.Tables(0).Rows(0).Item("centrocosto")
                            txtIdCuenta.Text = noCta
                        End If
                    Else
                        Me.txtIdCuenta.Text = contabilidad.Recuperar_Cta_x_Centro_Costo(frm.Resultado9, frm.Resultado6.Trim) 'frm.Resultado7.Trim
                        txtCodCosto.Text = frm.Resultado10
                        txtNombCosto.Text = frm.Resultado11
                    End If
                    If Trim(Me.txtIdCuenta.Text.Trim) <> "" Then
                        ds = oPerif.ObtenerCatContab("*", "Final='S' and IdCuenta='" & Me.txtIdCuenta.Text.Trim & "'", "idCuenta", sUsuario, sPassword, sSucursal)
                        If ds.Tables("Catalogo").Rows.Count > 0 Then
                            dr = ds.Tables("Catalogo").Rows(0)
                            Me.txtCuenta.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
