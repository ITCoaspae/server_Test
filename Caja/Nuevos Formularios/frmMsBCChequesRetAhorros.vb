Imports CrystalDecisions.CrystalReports.Engine
Public Class frmMsBCChequesRetAhorros
    Dim Ahorros As New wrAhorro.wsLibAhorro
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Asociados As New wrAsociados.wsLibAsoc
    Dim Caja As New wrCaja.wsLibCaja
    Dim Lector As New sifLib.Lector
    Dim DtsBancos, DtsAhorros As New DataSet
    Dim IdBanco As Integer
    Dim TipoAhorro As String
    Dim CodTipoAhorro As String
    Dim SaldoCtaAhorro As Double
    Dim TasaInteres As Double
    Dim NoLibreta As String
    Dim NoSocio As Integer
    Dim vnocaja As String
    Dim vIdCorrCaja As Integer
    Dim vCodCajero As String

    Public Property NoCaja() As String
        Get
            Return vNoCaja
        End Get
        Set(ByVal Value As String)
            vNoCaja = Value
        End Set
    End Property

    Public Property CodCajero() As String
        Get
            Return vCodCajero
        End Get
        Set(ByVal Value As String)
            vCodCajero = Value
        End Set
    End Property
#Region "Metodos"
    Protected Sub ConsultarBancos(ByVal CodSucursal As String)
        DtsBancos = Bancos.ObtenerCuentaBanco("a.idCuenta,a.Nom_Cuenta,a.Corr_Cheque,a.idBanco", "CodSucursal = '" & CodSucursal & "'", "Nom_Cuenta", sUsuario, sPassword, sSucursal)
        If DtsBancos.Tables.Count > 0 Then
            If DtsBancos.Tables(0).Rows.Count > 0 Then
                Me.cbBancos.DataSource = DtsBancos.Tables(0)
            End If
        End If
    End Sub
    Protected Sub ConsultarCtasAhorroAsoc(ByVal Dui As String)

        DtsAhorros = Ahorros.ConsultarCtasAhorroDUI("distinct a.Nocuenta,a.SaldoDisponible_CuentaAhorro,b.Descripcion," &
"a.NoLibreta,a.TasaInteres,a.Saldo_CuentaAhorro, a.codtipoahorro",
"a.dui='" & Dui & "' and a.Estado = 'A' and left(a.codtipoahorro,1)not in('2','1','4') ",
"", sUsuario, sPassword, sSucursal)
        If DtsAhorros.Tables.Count > 0 Then
            If DtsAhorros.Tables(0).Rows.Count > 0 Then
                Me.cbCtasAsoc.DataSource = DtsAhorros.Tables(0)
            End If
        End If
    End Sub
    Protected Function consultarSaldo(ByVal noCuenta As String) As DataSet
        Dim dts As New DataSet
        Dim saldo As Double
        dts = Ahorros.ConsultarCtasAhorroDUI("a.saldoDisponible_CuentaAhorro,a.Saldo_CuentaAhorro", "a.nocuenta = '" & noCuenta & "' ", "", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                saldo = dts.Tables(0).Rows(0).Item("SaldoDisponible_CuentaAhorro")
            End If
        End If
        Return dts
    End Function
#End Region
#Region "Funciones"
    Protected Function GenerarComprobanteRetiro(ByVal Asociado As String, ByVal Dui As String, ByVal Nocuenta As String, ByVal TipoCuenta As String,
ByVal MontoLetras As String, ByVal FormaRetiro As Boolean, ByVal Paguese As String,
ByVal Usuario As String, ByVal NoCaja As Integer, ByVal Sucursal As String, ByVal monto As Double) As DataSet
        Dim RptRecibo As New rptReciboRetAboAhorros
        Dim Dts As New DataSet("RetiroAhorros")
        Dim Dt As DataTable = Dts.Tables.Add("Comprobante")
        Dim Dr As DataRow
        With Dt
            .Columns.Add("Asociado", Type.GetType("System.String"))
            .Columns.Add("DUI", Type.GetType("System.String"))
            .Columns.Add("NoCuenta", Type.GetType("System.String"))
            .Columns.Add("TipoCuenta", Type.GetType("System.String"))
            .Columns.Add("MontoLetras", Type.GetType("System.String"))
            .Columns.Add("FormaRetiro", Type.GetType("System.Boolean"))
            .Columns.Add("Paguese", Type.GetType("System.String"))
            .Columns.Add("Usuario", Type.GetType("System.String"))
            .Columns.Add("NoCaja", Type.GetType("System.Int32"))
            .Columns.Add("Sucursal", Type.GetType("System.String"))
            .Columns.Add("Monto", Type.GetType("System.Double"))
        End With
        Dr = Dt.NewRow()
        Dr("Asociado") = Asociado.ToUpper
        Dr("DUI") = Dui
        Dr("NoCuenta") = Nocuenta
        Dr("TipoCuenta") = TipoAhorro.ToUpper
        Dr("MontoLetras") = MontoLetras.ToUpper
        Dr("FormaRetiro") = FormaRetiro
        Dr("Paguese") = Paguese.ToUpper
        Dr("Usuario") = Usuario.ToUpper
        Dr("NoCaja") = NoCaja
        Dr("Sucursal") = Sucursal.ToUpper
        Dr("Monto") = monto
        Dt.Rows.Add(Dr)
        Return Dts
    End Function
    Protected Function NombreAsoc(ByVal Dui As String) As String
        Dim dts As New DataSet
        Dim Nombre As String = ""
        dts = Asociados.ConsultarAsociado("nombres,apellido1,apellido2,apellidocas,NoSocio", "Dui = '" & Dui & "'", "", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Nombre = RTrim(dts.Tables(0).Rows(0).Item("Nombres")) & " " &
RTrim(dts.Tables(0).Rows(0).Item("apellido1")) & " " &
RTrim(dts.Tables(0).Rows(0).Item("apellido2")) & " " &
RTrim(dts.Tables(0).Rows(0).Item("apellidocas"))
                NoSocio = dts.Tables(0).Rows(0).Item("NoSocio")
            End If
        End If
        Return Nombre
    End Function
    Public Function ValidarCamposObligatorios() As Boolean
        If txtNoCheque.Text.Length <= 0 Then
            MsgBox("El No. de Cheque no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Caja")
            Return False
            Exit Function
        ElseIf IsDBNull(C1NEMonto.Value) = True Then
            MsgBox("La cantidad no puede quedar vacia.", MsgBoxStyle.Critical, "Módulo - Caja")
            Return False
            Exit Function
        ElseIf C1NEMonto.Value <= 0 Then
            MsgBox("La cantidad a retirar debe ser mayor que cero.", MsgBoxStyle.Critical, "Módulo - Caja")
            Return False
            Exit Function
        ElseIf Me.txtConcepto.Text.Length <= 0 Then
            MsgBox("Concepoto no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Caja")
            Return False
            Exit Function
        ElseIf txtPagueseA.Text.Length = 0 Then
            MsgBox("Campo Paguese no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Caja")
            Return False
            Exit Function
        Else
            Return True
        End If




    End Function
    Public Function ValidarSaldoMinimo(ByVal CodTipoAhorro As String) As Boolean
        Dim DtsSaldoMin As New DataSet
        Dim SaldoMin As Double
        DtsSaldoMin = Ahorros.ConsultarParametrosxTipoAhorro("b.MontoSaldoMinimo", "b.CodTipoAhorro = '" & CodTipoAhorro & "'", sUsuario, sPassword, sSucursal)
        If DtsSaldoMin.Tables.Count > 0 Then
            If DtsSaldoMin.Tables(0).Rows.Count > 0 Then
                SaldoMin = DtsSaldoMin.Tables(0).Rows(0).Item("MontoSaldoMinimo")
                If (SaldoCtaAhorro - Me.C1NEMonto.Value) <= SaldoMin Then
                    Return False
                ElseIf (SaldoCtaAhorro - Me.C1NEMonto.Value) > SaldoMin Then
                    Return True
                End If
            End If
        End If
    End Function
    Public Function ValidarMontos() As Boolean

        If CDbl(Me.txtSaldoDisp.Text) >= Me.C1NEMonto.Value Then
            Return True
        ElseIf CDbl(Me.txtSaldoDisp.Text) < Me.C1NEMonto.Value Then
            Return False
        End If
    End Function
    Public Function RecuperarCtaContable(ByVal CodTipoAhorro As String)
        Dim Dts As New DataSet
        Dim CtaContable As String = ""
        Dts = Ahorros.ConsultarTipoAhorro("IdCuenta", "CodTipoAhorro = '" & CodTipoAhorro & "'", "", sUsuario, sPassword, sSucursal)
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                CtaContable = Dts.Tables(0).Rows(0).Item("IdCuenta")
            End If
        End If
        Return CtaContable
    End Function
    Public Function RecuperarCorrLibreta(ByVal Nocueta As String) As Integer
        Dim Dts As New DataSet
        Dim CorrLibreta As Integer
        Dts = Ahorros.ConsultarAhMovimientos("max(idlibreta)", "NoCuenta = '" & Nocueta & "'", "")
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                CorrLibreta = IIf(Dts.Tables(0).Rows(0).Item(0) Is DBNull.Value, 0, Dts.Tables(0).Rows(0).Item(0))
            Else
                CorrLibreta = 1
            End If
        Else
            CorrLibreta = 1
        End If
        Return CorrLibreta
    End Function
    Public Function RecuperarLineaLibreta(ByVal Nocuenta As String, ByVal CorrLibreta As Integer) As Integer
        Dim Dts As New DataSet
        Dim Linea As Integer
        Dts = Ahorros.ConsultarAhMovimientos("Max(Corr_Libreta)", "Nocuenta ='" & Nocuenta & "' AND IDLIBRETA ='" & CorrLibreta & "'", "")
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Linea = IIf(Dts.Tables(0).Rows(0).Item(0) Is DBNull.Value, 0, Dts.Tables(0).Rows(0).Item(0))
            Else
                Linea = 1
            End If
        Else
            Linea = 1
        End If
        Return Linea
    End Function
#End Region
#Region "Eventos"
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,CodAntiguo,NoSocio,Apellido1,Apellido2,Nombres", "", "Correlativo", sUsuario, sPassword, sSucursal) 'Ópcion que permite la busqueda del dui de los asociados.
            'ds = oAsoc.ConsultarAsociado("DUI,CodAntiguo,NoSocio,Apellido1,Apellido2,Nombres", "DUI='" & txtDui.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim <> "" Then
                Me.txtDui.Value = frm.Resultado.Trim
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de la información. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Caja")
        End Try

        'Filtrar Registros

    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Try
            ConsultarCtasAhorroAsoc(Me.txtDui.Text.Trim)
            Me.lblAsociado.Text = NombreAsoc(Me.txtDui.Text.Trim)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMsBCChequesRetAhorros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbBancos.ValueMember = "idCuenta"
        Me.cbBancos.DisplayMember = "Nom_Cuenta"
        Me.cbCtasAsoc.ValueMember = "SaldoDisponible_CuentaAhorro"
        Me.cbCtasAsoc.DisplayMember = "Nocuenta"
        ConsultarBancos(sSucursal)
        RecuperarCorrelativoDoc()
    End Sub



#End Region



    Protected Sub generarComprobante()
        Dim dtsFake As New DataSet
        Dim frmRpt As New frmVisor(dtsFake, 7, 0)
        'Dim rpt As New rptReciboRetAboAhorros
        Dim rpt As New rptComprobaneRetChequeAhorro
        Dim rptNocuenta As TextObject
        Dim rptDui As TextObject
        Dim rptNombre As TextObject
        Dim rptComprobante As TextObject
        Dim rptFecha As TextObject
        Dim rptNoCaja As TextObject
        Dim rptNoCajero As TextObject
        Dim rptSaldoAnterior As TextObject
        Dim rptMonto As TextObject
        Dim rptNuevoSaldo As TextObject
        rptNocuenta = rpt.Section1.ReportObjects("txtNoCuenta")
        rptDui = rpt.Section1.ReportObjects("txtDui")
        rptNombre = rpt.Section1.ReportObjects("txtAsociado")
        rptComprobante = rpt.Section1.ReportObjects("txtComprobante")
        rptFecha = rpt.Section1.ReportObjects("txtFecha")
        rptNoCaja = rpt.Section1.ReportObjects("txtNoCaja")
        rptNoCajero = rpt.Section1.ReportObjects("txtNoCajero")
        rptSaldoAnterior = rpt.Section1.ReportObjects("txtSaldoAnterior")
        rptMonto = rpt.Section1.ReportObjects("txtMonto")
        rptNuevoSaldo = rpt.Section1.ReportObjects("txtNuevoSaldo")

        rptNocuenta.Text = Me.cbCtasAsoc.Text
        rptDui.Text = Me.txtDui.Text.Trim
        rptNombre.Text = lblAsociado.Text
        rptComprobante.Text = Me.txtNoCheque.Text.Trim
        rptFecha.Text = Format(Me.dtpFec.Value, "Short Date")
        rptNoCaja.Text = pNocaja
        rptNoCajero.Text = pCodCajero
        rptSaldoAnterior.Text = Me.txtSaldoDisp.Text
        rptMonto.Text = Me.C1NEMonto.Value
        rptNuevoSaldo.Text = Math.Round(Me.txtSaldoDisp.Text - Me.C1NEMonto.Value, 2)
        'rpt.SetDataSource(dtsFake.Tables(0))
        With frmRpt
            .crView.ReportSource = rpt
            .ShowDialog()
        End With
    End Sub

    Protected Sub Limpiar()
        Me.txtDui.Text = ""
        Me.txtSaldoDisp.Text = ""
        Me.lblAsociado.Text = ""
        Me.txtNoCheque.Text = ""
        Me.C1NEMonto.Clear()
        Me.txtConcepto.Text = ""
        Me.txtCiudad.Text = ""
        Me.txtPagueseA.Text = ""
    End Sub

    Private Sub C1NEMonto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1NEMonto.LostFocus
        If Me.C1NEMonto.Value >= 571.43 Then

            MsgBox("Si el retiro no es realizado por el titular de la cta. por favor ingresar Dui y Nombre de la persona que efectua la transacción.", MsgBoxStyle.Information, "Módulo - Caja")

        End If
    End Sub

    Private Sub btnPostearLibreta_Click(sender As Object, e As EventArgs) Handles btnPostearLibreta.Click
        Try
            Dim frm As New frmMsCaPosteoLibretas
            With frm
                .txtDui.ReadOnly = False
                .txtDui.Value = txtDui.Text
                .txtAsociado.Text = Me.lblAsociado.Text.Trim
                .txtNoCuenta.Text = cbCtasAsoc.Text.ToString.Trim
                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim Dts As New DataSet
            NoNegociable = chkPersonNatural.Checked
            Me.Cursor = Cursors.WaitCursor
            Dts = Bancos.ImprimeCheque(Trim(Me.txtNoCheque.Text), Trim(txtNumPartida.Text), dtpFec.Value.ToShortDateString, False, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(Dts, 7, 0)

            ofrm.ShowDialog()
            Me.Cursor = Cursors.Default

            'Posteo de libreta comprobante de recibo
            If MessageBox.Show("¿Es un retiro con libreta?", "Posteo de Libreta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim frm As New frmMsCaPosteoLibretas
                With frm
                    .txtDui.ReadOnly = False
                    .txtDui.Value = txtDui.Text
                    .txtAsociado.Text = Me.lblAsociado.Text.Trim
                    .txtNoCuenta.Text = cbCtasAsoc.Text.ToString.Trim
                    .ShowDialog()
                End With

            End If
            generarComprobante()
            Limpiar()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            RecuperarCorrelativoDoc()
            Me.txtSaldoDisp.Text = "$" & Me.consultarSaldo(Me.cbCtasAsoc.Text.Trim).Tables(0).Rows(0).Item(0).ToString
            SaldoCtaAhorro = Me.consultarSaldo(Me.cbCtasAsoc.Text.Trim).Tables(0).Rows(0).Item(1)
            'Variables para insercion en AhMovimientos
            If ValidarCamposObligatorios() = True Then

                If ValidarMontos() = True Then
                    Dim Resultado(1) As String
                    Dim DtsMov, DtsParametrosAhorro As New DataSet
                    Dim MaxNumLibreta As Integer
                    Dim Num As Integer
                    Dim Corr_Libreta As Integer
                    Dim LineaLibreta As Integer
                    DtsParametrosAhorro = Asociados.ConsultarParametros("MaxNumLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)
                    If DtsParametrosAhorro.Tables.Count > 0 Then
                        If DtsParametrosAhorro.Tables(0).Rows.Count > 0 Then
                            MaxNumLibreta = DtsParametrosAhorro.Tables(0).Rows(0).Item(0)
                            DtsMov = Ahorros.ConsultarAhMovimientos("Max(num)", "Nocuenta = '" & Me.cbCtasAsoc.Text.ToString.Trim & "'", "")
                            If DtsMov.Tables.Count > 0 Then
                                If DtsMov.Tables(0).Rows.Count > 0 Then
                                    Num = IIf(DtsMov.Tables(0).Rows(0).Item(0) Is DBNull.Value, 0, DtsMov.Tables(0).Rows(0).Item(0)) + 1
                                    Corr_Libreta = RecuperarCorrLibreta(Me.cbCtasAsoc.Text.Trim)
                                    LineaLibreta = RecuperarLineaLibreta(Me.cbCtasAsoc.Text.Trim, Corr_Libreta)
                                    If LineaLibreta >= MaxNumLibreta Then
                                        Corr_Libreta = Corr_Libreta + 1
                                        LineaLibreta = 1
                                    ElseIf LineaLibreta > 0 And LineaLibreta < MaxNumLibreta Then
                                        LineaLibreta = LineaLibreta + 1
                                    End If

                                End If
                            End If
                        End If
                    End If





                    Dim Minutos As String
                    Minutos = Now.Minute.ToString
                    Minutos = Minutos.PadLeft(2, CChar("0"))
                    Resultado = Ahorros.RetiroAhorrosCheque(Me.txtDui.Text.Trim,
Me.cbCtasAsoc.Text.Trim,
CDbl(txtSaldoDisp.Text),
SaldoCtaAhorro,
Math.Round((SaldoCtaAhorro - Me.C1NEMonto.Value), 2),
CodTipoAhorro,
Me.cbBancos.SelectedValue,
TasaInteres,
(Now.Hour.ToString & ":" & Minutos),
IdBanco,
Me.txtNoCheque.Text,
Format(Me.dtpFec.Value, "Short Date"),
Me.C1NEMonto.Value,
Me.txtConcepto.Text.Trim,
Me.txtCiudad.Text.Trim,
Me.txtPagueseA.Text.Trim,
pCodCajero,
pNocaja,
sSucursal,
sUsuario,
"EG",
NoLibreta,
Num,
LineaLibreta,
Corr_Libreta,
"RET",
"C",
"N",
Me.dtpFec.Value.Year,
"0",
"C",
NoSocio,
RecuperarCtaContable(CodTipoAhorro),
"M",
"0",
CentroCostoSucursal,
CentroCostoSucursal)


                    If Resultado(0).Equals("1") Then
                        Me.btnImprimir.Enabled = True
                        Me.txtNumPartida.Text = Resultado(1)
                        MsgBox("Datos Ingresados Correctamente", MsgBoxStyle.Information, "Módulo - Caja")

                        If Caja.incrementarCorrelativo_CaCorrelativoCaja(Me.txtComprobante.Text, vIdCorrCaja) = 0 Then
                            MsgBox("Error al actualizar correlativo, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Caja")
                        End If

                    ElseIf Resultado(1).Equals("0") Then
                        MsgBox("Error. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Caja")
                    End If
                Else
                    MsgBox("El monto a retirar es mayor que el saldo disponible", MsgBoxStyle.Critical, "Módulo - Caja")
                End If

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImprimirComprobante_Click_1(sender As Object, e As EventArgs) Handles btnImprimirComprobante.Click
        Try
            Dim Dts As New DataSet
            Dim TipoCuenta As String
            Dim MontoLetras As String
            Dim Sucursal As String
            Dim rpt As New rptReciboRetAboAhorros
            Sucursal = Asociados.ConsultarSucursales("Nom_Sucursal", "CodSucursal = '" & sSucursal & "'", "", sUsuario, sPassword, sSucursal).Tables(0).Rows(0).Item("Nom_Sucursal")
            MontoLetras = sifLib.Lector.ProcesarCantidadEnteros(Me.C1NEMonto.Value.ToString.Trim) & " D" & ChrW(211) & "LARES CON " &
sifLib.Lector.ProcesarCantidadDecimales(Me.C1NEMonto.Value.ToString.Trim) & " / 100 CENTAVOS"
            Dts = GenerarComprobanteRetiro(Me.lblAsociado.Text.Trim, Me.txtDui.Text.Trim, Me.cbCtasAsoc.Text.Trim,
TipoCuenta, MontoLetras, True, Me.txtPagueseA.Text.Trim, sUsuario, pNocaja, Sucursal, C1NEMonto.Value)
            Dim lblmonto As TextObject
            Dim monto As TextObject
            Dim txtDui As TextObject
            Dim txtNoCuenta As TextObject
            Dim lblNoDoc As TextObject
            Dim lblNombre As TextObject
            Dim txtNoDocTitular As TextObject
            Dim txtNombreTitular As TextObject
            txtDui = rpt.PageHeaderSection1.ReportObjects("txtDui")
            txtNoCuenta = rpt.PageHeaderSection1.ReportObjects("txtNoCuenta")
            lblmonto = rpt.PageHeaderSection1.ReportObjects("lblMonto")
            monto = rpt.PageHeaderSection1.ReportObjects("monto")
            lblNoDoc = rpt.PageHeaderSection1.ReportObjects("lblNoDoc")
            lblNombre = rpt.PageHeaderSection1.ReportObjects("lblNombre")
            txtNoDocTitular = rpt.PageHeaderSection1.ReportObjects("txtNoDocTitular")
            txtNombreTitular = rpt.PageHeaderSection1.ReportObjects("txtNombreTitular")
            txtDui.Text = Me.txtDui.Text.Trim
            txtNoCuenta.Text = Me.cbCtasAsoc.Text.Trim
            monto.Text = MontoLetras.Trim.ToUpper
            lblmonto.Text = "VALOR A RETIRAR"
            If Me.txtDuiTerceros.Text.Length > 0 And Me.txtNombreTerceros.Text.Length > 0 Then
                lblNoDoc.Text = "DUI:"
                lblNombre.Text = "NOMBRE:"
                txtNoDocTitular.Text = Me.txtDuiTerceros.Text.Trim
                txtNombreTitular.Text = Me.txtNombreTerceros.Text.Trim
            Else
                lblNoDoc.Text = ""
                lblNombre.Text = ""
                txtNoDocTitular.Text = Me.txtDuiTerceros.Text.Trim
                txtNombreTitular.Text = Me.txtNombreTerceros.Text.Trim
            End If

            Dim ofrm As New frmVisor(Dts, 219, 0)
            rpt.SetDataSource(Dts.Tables(0))
            With ofrm
                .crView.ReportSource = rpt
                .ShowDialog()
            End With
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


    Protected Sub RecuperarCorrelativoDoc()
        Try
            Dim idTipoDoc As Integer
            Dim maximo As Integer

            Dim dts As New DataSet
            dts = Caja.consultarCaCorrelativoCaja(sSucursal, pNocaja, 3, 0, 3)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    maximo = dts.Tables(0).Rows(0).Item("maximo")
                    If dts.Tables(0).Rows(0).Item("correlativo") < maximo Then
                        Me.txtComprobante.Text = dts.Tables(0).Rows(0).Item("correlativo") + 1
                        vIdCorrCaja = dts.Tables(0).Rows(0).Item("idCorrCaja")
                    Else
                        MsgBox("Se ha llegado al limite de correlativos asignados, por favor solicitar una nueva asignación.", MsgBoxStyle.Information, "Módulo - Caja")
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            Me.Close()
        End Try


    End Sub

    Private Sub cbCtasAsoc_LostFocus(sender As Object, e As EventArgs) Handles cbCtasAsoc.LostFocus
        Try
            'Me.txtSaldoDisp.Text = "$ " & Me.cbCtasAsoc.SelectedValue.ToString
            Dim vistaAhorro As DataView
            Dim dt As DataTable
            Dim dt2 As DataTable
            dt = DtsAhorros.Tables(0)
            vistaAhorro = New DataView(DtsAhorros.Tables(0), "Nocuenta = '" & Me.cbCtasAsoc.Text.Trim & "'", "", DataViewRowState.CurrentRows)
            dt2 = vistaAhorro.ToTable
            TipoAhorro = dt2.Rows(0).Item("Descripcion")
            CodTipoAhorro = dt2.Rows(0).Item("CodTipoAhorro")
            SaldoCtaAhorro = dt2.Rows(0).Item("Saldo_CuentaAhorro")
            TasaInteres = dt2.Rows(0).Item("TasaInteres")
            NoLibreta = dt2.Rows(0).Item("NoLibreta")
            Me.txtSaldoDisp.Text = "$" & Me.consultarSaldo(Me.cbCtasAsoc.Text.Trim).Tables(0).Rows(0).Item(0).ToString
            SaldoCtaAhorro = Me.consultarSaldo(Me.cbCtasAsoc.Text.Trim).Tables(0).Rows(0).Item(1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbCtasAsoc_DropDownClosed(sender As Object, e As EventArgs) Handles cbCtasAsoc.DropDownClosed
        Try
            Me.txtSaldoDisp.Text = "$" & Me.consultarSaldo(Me.cbCtasAsoc.Text.Trim).Tables(0).Rows(0).Item(0).ToString
            SaldoCtaAhorro = Me.consultarSaldo(Me.cbCtasAsoc.Text.Trim).Tables(0).Rows(0).Item(1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbBancos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBancos.SelectedIndexChanged

    End Sub

    Private Sub cbBancos_DropDownClosed(sender As Object, e As EventArgs) Handles cbBancos.DropDownClosed
        Try
            Dim Vista As DataView
            Dim Dt, Dt2 As New DataTable
            Dt = DtsBancos.Tables(0)
            Vista = New DataView(DtsBancos.Tables(0), "IdCuenta = '" & Me.cbBancos.SelectedValue & "'", "", DataViewRowState.CurrentRows)
            Dt2 = Vista.ToTable
            Me.txtNoCheque.Text = Dt2.Rows(0).Item("corr_cheque") + 1
            IdBanco = Dt2.Rows(0).Item("IdBanco")
        Catch ex As Exception

        End Try

    End Sub
End Class