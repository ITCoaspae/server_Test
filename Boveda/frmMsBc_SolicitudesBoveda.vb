Public Class frmMsBc_SolicitudesBoveda
    'Public TipoUsuario As Integer '1 = Cajero, 2 = Encargado de Boveda, 3 = Admin Sistema
    'Public Accion As Integer '1 = Insertar,2=Modificar,3= Consultar
    'Public CodSolicitud As Integer
    'Public Sucursal As String
    Dim Bancos As New wrBancos.wsLibBancos
    Dim caja As New wrCaja.wsLibCaja
    Dim contabilidad As New wrConta.wsLibContab
    Dim vIdTipoMovCaja As Integer
    Dim vCodCajero As Integer
    Dim vCajero As String
    Dim vUsuario As String
    Dim vCodSuc As String
    Dim vCodSolic As Integer
    Dim vAccion As Integer
    Dim vTipoUser As Integer
#Region "Propiedades"
    Public Property tipoUsuario() As Integer
        Get
            Return vTipoUser
        End Get
        Set(ByVal value As Integer)
            vTipoUser = value
        End Set
    End Property
    Public Property Accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property codSolic() As Integer
        Get
            Return vCodSolic
        End Get
        Set(ByVal value As Integer)
            vCodSolic = value
        End Set
    End Property
    Public Property codSuc() As String
        Get
            Return vCodSuc
        End Get
        Set(ByVal value As String)
            vCodSuc = value
        End Set
    End Property
    Public Property idTipoMovCaja() As Integer
        Get
            Return vIdTipoMovCaja
        End Get
        Set(ByVal value As Integer)
            vIdTipoMovCaja = value
        End Set
    End Property
    Public Property codCajero() As Integer
        Get
            Return vCodCajero
        End Get
        Set(ByVal value As Integer)
            vCodCajero = value
        End Set
    End Property
    Public Property cajero() As String
        Get
            Return vCajero
        End Get
        Set(ByVal value As String)
            vCajero = value
        End Set
    End Property
    Public Property usuario() As String
        Get
            Return vUsuario
        End Get
        Set(ByVal value As String)
            vUsuario = value
        End Set
    End Property
#End Region
#Region "Eventos"
    Private Sub c1nCien_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCien.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub c1nCinco_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCinco.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub c1nCincuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCincuenta.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub c1nDiez_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nDiez.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub c1nFraccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nFraccion.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub C1nMonedaUno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1nMonedaUno.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub c1nUno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nUno.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub c1nVeinte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nVeinte.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub

    Private Function GuardarMovimientoBoveda(ByVal codTransaccion As Integer, ByVal monto As Double) As Integer
        Dim resultado As Integer
        Dim numPartida As String
        Dim saldoAnterior As Double
        Dim saldoFinal As Double
        Dim dt, dt2 As New DataTable
        Dim prefijo As String
        Dim Correlativo As Integer
        Dim idCuentaA, idCuentaC As String
        Dim dtsCtasContables As New DataSet
        Dim vista As DataView
        Dim dtsBoveda As New DataSet
        Dim dtsTranBoveda As New DataSet
        Dim idBoveda As Integer
        Try
            dtsBoveda = Bancos.ConsultarBcBoveda(0, 2, codSuc)
            idBoveda = dtsBoveda.Tables(0).Rows(0).Item("id_Boveda")
            If dtsBoveda.Tables.Count > 0 Then
                If dtsBoveda.Tables(0).Rows.Count > 0 Then
                    saldoAnterior = dtsBoveda.Tables(0).Rows(0).Item("saldo")
                    dtsTranBoveda = Bancos.ConsultarBCCatTransacciones_Boveda(2, codTransaccion)
                    If dtsTranBoveda.Tables.Count > 0 Then
                        If dtsTranBoveda.Tables(0).Rows.Count > 0 Then
                            dt = dtsTranBoveda.Tables(0)
                            vista = New DataView(dtsTranBoveda.Tables(0), "codTransaccion = " & codTransaccion & "", "", DataViewRowState.CurrentRows)
                            dt2 = vista.ToTable
                            prefijo = dt2.Rows(0).Item("PrefijoPartida").ToString
                            If dt2.Rows(0).Item("tipoMov").ToString.Equals("A") Then
                                saldoFinal = Math.Round(saldoAnterior + monto, 2)
                            ElseIf dt2.Rows(0).Item("tipoMov").ToString.Equals("C") Then
                                saldoFinal = Math.Round(saldoAnterior - monto, 2)
                            End If
                            dtsCtasContables = ConsultarTransaccionesBovedaSucursal(codSuc, codTransaccion, 0, 5)
                            If dtsCtasContables.Tables.Count > 0 Then
                                If dtsCtasContables.Tables(0).Rows.Count > 0 Then
                                    idCuentaA = dtsCtasContables.Tables(0).Rows(0).Item("idCuentaA").ToString.Trim
                                    idCuentaC = dtsCtasContables.Tables(0).Rows(0).Item("idCuentaC").ToString.Trim
                                End If
                            End If
                            If prefijo.Equals("EG") = True Then
                                numPartida = GenerarNumPartida(1, prefijo, dtpFecha.Value.Month,
                                                          dtpFecha.Value.Year)
                            Else
                                numPartida = GenerarNumPartida(2, prefijo, dtpFecha.Value.Month,
                                                          dtpFecha.Value.Year)
                            End If

                            Correlativo = CInt(numPartida.Substring(8, 5))

                            If Guardar(idBoveda, Format(Me.dtpFecha.Value, "Short Date"),
                                    dt2.Rows(0).Item("tipoMov").ToString, numPartida, saldoAnterior,
                                    monto, saldoFinal, codTransaccion,
                                    sUsuario, Now.Hour.ToString.PadLeft(2, "0") + ":" + Now.Minute.ToString.PadLeft(2, "0"), False,
                                    "partida movimiento boveda", prefijo, "A", dtpFecha.Value.Year, " ",
                                    CentroCostoSucursal, idCuentaA, idCuentaC, codSuc, Correlativo, dtpFecha.Value.Month,
                                    Me.txtObservacion.Text.Trim, codSolic.ToString.Trim,
                                    c1nUno.Value, c1nCinco.Value, c1nDiez.Value,
                                    c1nVeinte.Value, c1nCincuenta.Value, c1nCien.Value,
                                    C1nMonedaUno.Value, c1nFraccion.Value) <> 0 Then
                                MsgBox("El registro fue ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Boveda")
                            Else
                                MsgBox("El registro no fue ingresado,por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Boveda")
                            End If

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error,por favor comunicarse con el administrador del sistema" + vbCrLf + ex.Message,
                   MsgBoxStyle.Critical, "Módulo - Boveda")
        End Try
    End Function
#End Region
#Region "Funciones"
    Protected Function ConsultarTransaccionesBovedaSucursal(ByVal codSucursal As String, ByVal codtransaccion As Integer,
                                                           ByVal idSucursalTransaccionBov As Integer, ByVal opcion As Integer) As DataSet
        Dim dts As New DataSet
        dts = Bancos.ConsultarBcSucursales_TransaccionesBoveda(codSucursal, codtransaccion, idSucursalTransaccionBov, opcion)
        Return dts
    End Function
    Private Function GenerarNumPartida(ByVal opcion As Integer, ByVal prefijo As String, ByVal mes As Integer, ByVal annio As Integer) As String
        Dim NumPartida As String
        NumPartida = contabilidad.generarNumeroPartida(opcion, prefijo, mes, annio)
        Return NumPartida
    End Function
    Private Function Guardar(ByVal idBoveda As Integer, ByVal fechaMov As DateTime,
                                                    ByVal tipoMov As String, ByVal numPartida As String,
                                                    ByVal saldoAnterior As Double, ByVal monto As Double,
                                                    ByVal saldoActual As Double, ByVal codTransaccion As Integer,
                                                    ByVal usuario As String, ByVal hora As String,
                                                    ByVal anulado As Boolean, ByVal descripcionPartida As String,
                                                    ByVal prefijo As String, ByVal tipoPartida As String, ByVal annio As Integer,
                                                    ByVal cod_CBeneficio As String, ByVal cod_CCosto As String,
                                                    ByVal idCuentaA As String, ByVal idCuentaC As String, ByVal codSucursal As String,
                                                    ByVal corrPartida As Integer, ByVal mes As Integer, ByVal observacion As String,
                                                    ByVal idMovimiento As String,
                                                    ByVal cantidadBilletesUno As Integer, ByVal cantidadBilletesCinco As Integer,
                                                    ByVal cantidadBilletesDiez As Integer, ByVal cantidadBilletesVeinte As Integer,
                                                    ByVal cantidadBilletesCincuenta As Integer, ByVal cantidadBilletesCien As Integer,
                                                    ByVal cantidadMonedasUno As Integer, ByVal montoMonedaFraccionario As Double)
        Dim resultado As Integer
        resultado = Bancos.movimientosBoveda(idBoveda, fechaMov, tipoMov, numPartida, saldoAnterior, monto,
                                                 saldoActual, codTransaccion, usuario, hora, anulado,
                                                 descripcionPartida, prefijo, tipoPartida, annio,
                                                 cod_CBeneficio, cod_CCosto, idCuentaA, idCuentaC,
                                                 codSucursal, corrPartida, mes, observacion, idMovimiento,
                                                 cantidadBilletesUno, cantidadBilletesCinco,
                                                 cantidadBilletesDiez, cantidadBilletesVeinte,
                                                 cantidadBilletesCincuenta, cantidadBilletesCien,
                                                 cantidadMonedasUno, montoMonedaFraccionario)
        Return resultado
    End Function

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Try
            If Me.txtMonto.Value > 0 Then
                If Bancos.ValidarMontoMinBoveda(sSucursal, txtMonto.Value) = True Then
                    Dim Resultado As Integer
                    Resultado = Bancos.InsertarBcSolicitudes_Boveda(pCodCajero, Format(dtpFecha.Value, "Short Date"), Me.txtMonto.Value,
                                                                    "", False, Now.Hour.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.Trim.PadLeft(2, "0"),
                                                                    codSuc, sUsuario, sUsuario, sPassword, sSucursal, 1, 0)
                    If Resultado <> 0 Then
                        MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information, "Módulo - Bóveda")
                        Dim ofrm1 As New frmMB_SolicitudesBoveda
                        Me.Hide()
                        With ofrm1
                            .ShowDialog()
                        End With
                        Me.Close()
                        'Dim ofrm1 As New frmMsCaAperturaCaja
                        'Me.Hide()
                        'With ofrm1
                        '    .Origen = 1
                        '    .CodCajero = vCodCajero
                        '    .Cajero = vCajero
                        '    .Usuario = vUsuario
                        '    .C1NEMontoApertura.Value = Me.txtMonto.Value
                        '    .C1NEMontoApertura.Enabled = False
                        '    .cbTipoMov.Visible = False
                        '    .lblTipoMovCaja.Visible = False
                        '    .Show()
                        'End With
                        'ofrm1.CodCajero = vCodCajero
                        'ofrm1.Cajero = vCajero
                        'ofrm1.Usuario = vUsuario.Trim
                        'Me.Hide()
                        'ofrm1.ShowDialog()
                    Else
                        MsgBox("No se pudo ingrear el registro, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Information, "Bóveda")
                    End If
                Else
                    MsgBox("Saldo insuficiente en bóveda para procesar esta solicitud.", MsgBoxStyle.Critical, "Módulo - Bóveda")
                End If
            Else
                MsgBox("El monto debe ser mayor que cero.", MsgBoxStyle.Information, "Módulo - Bóveda")
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnAutorizar.Click
        Try
            If Me.c1nTotal.Value = Me.txtMonto.Value Then
                If idTipoMovCaja = 1 Then
                    If Bancos.ValidarMontoMinBoveda(codSuc, Me.txtMonto.Value) = False Then
                        MsgBox("Monto solicitado supera el monto mínimo de boveda.", MsgBoxStyle.Critical, "Bóveda")
                        Exit Sub
                    End If
                ElseIf idTipoMovCaja = 2 Then
                    If Bancos.ValidarMontoMaxBoveda(codSuc, Me.txtMonto.Value) = False Then
                        MsgBox("Monto solicitado supera el monto máximo de boveda.", MsgBoxStyle.Critical, "Bóveda")
                        Exit Sub
                    End If
                End If

                Dim resultado As Integer
                Dim frm As New frmMsBC_MovimientosBoveda
                resultado = Bancos.ActivarSolicitudBoveda(Me.txtObservacion.Text.Trim,
                                                          True, sUsuario, Format(Now, "short date"), Now.Hour.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.PadLeft(2, "0"),
                                                          codSolic)
                If resultado <> 0 Then

                    MsgBox("Solicitud aprobada.", MsgBoxStyle.Information, "Bóveda")
                    Dim CodTransaccion As Integer
                    Dim dtsTransacciones As New DataSet
                    dtsTransacciones = caja.consultarCaTipoMovCaja(2, idTipoMovCaja, 0, sUsuario, sPassword, sSucursal)
                    If dtsTransacciones.Tables.Count > 0 Then
                        If dtsTransacciones.Tables(0).Rows.Count > 0 Then
                            CodTransaccion = dtsTransacciones.Tables(0).Rows(0).Item("codTransaccion")
                            GuardarMovimientoBoveda(CodTransaccion, txtMonto.Value)
                        End If
                    End If
                    Me.Close()
                Else
                    MsgBox("Error, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Bóveda")
                End If
            Else
                MsgBox("Detalle de billetes no coincide con monto de solicitud.", MsgBoxStyle.Critical, "Bóveda")
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles btnDenegar.Click
        Try
            Dim resultado As Integer
            'resultado = Bancos.anularSolicitudBoveda(codSolic)
            If resultado > 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Solicitud denegada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmMsBc_SolicitudesBoveda_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
#End Region


End Class