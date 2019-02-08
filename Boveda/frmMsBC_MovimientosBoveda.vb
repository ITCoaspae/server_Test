Imports System.ComponentModel

Public Class frmMsBC_MovimientosBoveda
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Asociados As New wrAsociados.wsLibAsoc
    Dim Contabilidad As New wrConta.wsLibContab
    Dim Seguridad As New wrAdmin.wsLibAdmin
    Dim vAccion, vOrigen As Integer
    Dim dtsBoveda As New DataSet
    Dim dtsTranBoveda As New DataSet
    Dim saldoAnterior As Double
    Dim saldoNuevo As Double
    Dim vCorrelativo As Integer


#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property origen() As Integer
        Get
            Return vOrigen
        End Get
        Set(ByVal value As Integer)
            vOrigen = value
        End Set
    End Property
    Public Property correlativo() As Integer
        Get
            Return vCorrelativo
        End Get
        Set(ByVal value As Integer)
            vCorrelativo = value
        End Set
    End Property
#End Region
#Region "Funciones"
    Private Function valicarDenominaciones() As Integer
        Dim valido As Integer = 0
        valido = Bancos.validarDenominacionesBoveda(cbBoveda.SelectedValue, cbTipoTransaccion.SelectedValue,
                                                 c1nUno.Value, c1nCinco.Value,
                                                 c1nDiez.Value, c1nVeinte.Value,
                                                 c1nCincuenta.Value, c1nCien.Value,
                                                 C1nMonedaUno.Value, c1nFraccion.Value)
        If valido = 0 Then
            Me.btnGuardar1.Enabled = False
        Else
            Me.btnGuardar1.Enabled = True
        End If
        Return valido
    End Function
    Protected Function ConsultarTransaccionesBovedaSucursal(ByVal codSucursal As String, ByVal codtransaccion As Integer,
                                                            ByVal idSucursalTransaccionBov As Integer, ByVal opcion As Integer) As DataSet
        Dim dts As New DataSet
        dts = Bancos.ConsultarBcSucursales_TransaccionesBoveda(codSucursal, codtransaccion, idSucursalTransaccionBov, opcion)
        Return dts
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
    Private Function GenerarNumPartida(ByVal opcion As Integer, ByVal prefijo As String, ByVal mes As Integer, ByVal annio As Integer) As String
        Dim NumPartida As String
        NumPartida = Contabilidad.generarNumeroPartida(opcion, prefijo, mes, annio)
        Return NumPartida
    End Function
    Private Function insertarDetalleEfectivo(ByVal correlativo As Integer,
                                             ByVal cantidadBilletesUno As Integer, ByVal cantidadBilletesCinco As Integer,
                                             ByVal cantidadBilletesDiez As Integer, ByVal cantidadBilletesVeinte As Integer,
                                             ByVal cantidadBilletesCincuenta As Integer, ByVal cantidadBilletesCien As Integer,
                                             ByVal cantidadMonedasUno As Integer, ByVal montoMonedaFraccionario As Double,
                                             ByVal opcion As Integer, ByVal usuarioActu As String, ByVal fechaActu As DateTime) As Integer

        Try
            Dim resultado As Integer
            resultado = Bancos.modificarBcMovimientosBoveda(0, Now, "", "", 0, 0, 0, 0, "", "", False,
                                                            correlativo, cantidadBilletesUno,
                                                            cantidadBilletesCinco, cantidadBilletesDiez,
                                                            cantidadBilletesVeinte, cantidadBilletesCincuenta,
                                                            cantidadBilletesCien, cantidadMonedasUno,
                                                            montoMonedaFraccionario, opcion, usuarioActu, fechaActu)
            Return resultado
        Catch ex As Exception
            MsgBox("Error,por favor comunicarse con el administrador del sistema" + vbCrLf + ex.Message,
                   MsgBoxStyle.Critical, "Módulo - Boveda")
        End Try
    End Function
#End Region
#Region "Metodos"
    Public Sub llenarCbBoveda(ByVal id_Boveda As Integer, ByVal opcion As Integer, ByVal codsucursal As String)
        dtsBoveda = Me.Bancos.ConsultarBcBoveda(id_Boveda, opcion, codsucursal)
        If dtsBoveda.Tables.Count > 0 Then
            If dtsBoveda.Tables(0).Rows.Count > 0 Then
                Me.cbBoveda.DataSource = dtsBoveda.Tables(0)
            End If
        End If
    End Sub
    Public Sub LlenarCBSucursales(ByVal Campos As String, ByVal Filtro As String, ByVal Orden As String)
        Dim Dts As New DataSet
        Try

            Dts = Asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
            If Dts.Tables.Count > 0 Then
                If Dts.Tables(0).Rows.Count > 0 Then
                    Me.cbSucursal.DataSource = Dts.Tables(0)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Bóveda")
        End Try
    End Sub
    Public Sub llenarCbTransacciones(ByVal opcion As Integer, ByVal codTransaccion As Integer)
        Dim Dts As New DataSet
        Try
            dtsTranBoveda = Bancos.ConsultarBcSucursales_TransaccionesBoveda(cbSucursal.SelectedValue, 0, 0, 2)
            'dtsTranBoveda = Bancos.ConsultarBCCatTransacciones_Boveda(opcion, codTransaccion)
            If dtsTranBoveda.Tables.Count > 0 Then
                If dtsTranBoveda.Tables(0).Rows.Count > 0 Then
                    Me.cbTipoTransaccion.DataSource = dtsTranBoveda.Tables(0)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Bóveda")
        End Try


    End Sub
#End Region
#Region "Eventos"
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub cbSucursal_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSucursal.DropDownClosed
        llenarCbBoveda(0, 2, cbSucursal.SelectedValue)
        llenarCbTransacciones(0, 0)
    End Sub

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
    Private Sub c1nTotal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nTotal.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub c1nUno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nUno.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub c1nVeinte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nVeinte.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub C1nMonedaUno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1nMonedaUno.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
    End Sub
    Private Sub frmMsBC_MovimientosBoveda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbSucursal.DisplayMember = "Nom_Sucursal"
        Me.cbSucursal.ValueMember = "CodSucursal"
        Me.cbTipoTransaccion.DisplayMember = "MovBoveda"
        Me.cbTipoTransaccion.ValueMember = "codTransaccion"
        Me.cbBoveda.DisplayMember = "descripcion"
        Me.cbBoveda.ValueMember = "id_Boveda"
        If vOrigen <> 1 Then

            If vAccion = 1 Then 'Insertar

                Dim dtsRoles As New DataSet
                dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
                For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                    If Seguridad.ConsultarPermisoProcesos("BCH006", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                        LlenarCBSucursales("CodSucursal,Nom_Sucursal", "codSucursal = '" & sSucursal & "'", "Nom_Sucursal")
                        Exit For
                    ElseIf Seguridad.ConsultarPermisoProcesos("BCH007", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                        LlenarCBSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal")
                        Exit For
                    End If
                Next


                llenarCbTransacciones(1, 0)
                llenarCbBoveda(0, 2, cbSucursal.SelectedValue)
            End If

        End If

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim resultado As Integer
        Dim numPartida As String
        Dim saldoAnterior As Double
        Dim saldoFinal As Double

        Dim prefijo As String
        Dim Correlativo As Integer
        Dim idCuentaA, idCuentaC As String
        Dim dtsCtasContables As New DataSet

        Dim opcion As Integer
        Dim dtsTransacciones As New DataSet


        Try
            Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
            Dim totalDenominaciones As Double
            totalDenominaciones = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value + C1nMonedaUno.Value
            If totalDenominaciones <> c1nTotal.Value Or totalDenominaciones <> C1NEMonto.Value Then
                MsgBox("Total no coincide con denominaciones, por favor revisar.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If valicarDenominaciones() = 1 Then
                If vAccion = 1 Then
                    If dtsBoveda.Tables.Count > 0 Then
                        If dtsBoveda.Tables(0).Rows.Count > 0 Then
                            saldoAnterior = dtsBoveda.Tables(0).Rows(0).Item("saldo")
                            If dtsTranBoveda.Tables.Count > 0 Then
                                If dtsTranBoveda.Tables(0).Rows.Count > 0 Then


                                    dtsTransacciones = Bancos.ConsultarBCCatTransacciones_Boveda(2, Me.cbTipoTransaccion.SelectedValue)
                                    prefijo = dtsTransacciones.Tables(0).Rows(0).Item("PrefijoPartida") 'dt2.Rows(0).Item("PrefijoPartida").ToString
                                    If dtsTransacciones.Tables(0).Rows(0).Item("tipoMov").ToString.Equals("A") Then ' dt2.Rows(0).Item("tipoMov").ToString.Equals("A") Then
                                        saldoFinal = Math.Round(saldoAnterior + C1NEMonto.Value, 2)
                                    ElseIf dtsTransacciones.Tables(0).Rows(0).Item("tipoMov").ToString.Equals("C") Then 'dt2.Rows(0).Item("tipoMov").ToString.Equals("C") Then
                                        saldoFinal = Math.Round(saldoAnterior - C1NEMonto.Value, 2)
                                    End If

                                    dtsCtasContables = ConsultarTransaccionesBovedaSucursal(sSucursal, Me.cbTipoTransaccion.SelectedValue, 0, 5)
                                    If dtsCtasContables.Tables.Count > 0 Then
                                        If dtsCtasContables.Tables(0).Rows.Count > 0 Then
                                            idCuentaA = dtsCtasContables.Tables(0).Rows(0).Item("idCuentaA").ToString.Trim
                                            ' idCuentaA = Contabilidad.Recuperar_Cta_x_Centro_Costo(Me.cbSucursal.SelectedValue, idCuentaA)
                                            idCuentaC = dtsCtasContables.Tables(0).Rows(0).Item("idCuentaC").ToString.Trim
                                            ' idCuentaC = Contabilidad.Recuperar_Cta_x_Centro_Costo(Me.cbSucursal.SelectedValue, idCuentaC)
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
                                    'If C1NEMonto.Value = c1nTotal.Value Then
                                    If Guardar(Me.cbBoveda.SelectedValue, Format(Me.dtpFecha.Value, "Short Date"),
                                        dtsTransacciones.Tables(0).Rows(0).Item("tipoMov").ToString, numPartida, saldoAnterior,
                                        Me.C1NEMonto.Value, saldoFinal, Me.cbTipoTransaccion.SelectedValue,
                                        sUsuario, Now.Hour.ToString.PadLeft(2, "0") + ":" + Now.Minute.ToString.PadLeft(2, "0"), False,
                                        Me.cbTipoTransaccion.Text, prefijo, "A", dtpFecha.Value.Year, " ",
                                        CentroCostoSucursal, idCuentaA, idCuentaC, sSucursal, Correlativo, dtpFecha.Value.Month,
                                        txtObservacion.Text.Trim, txtReferencia.Text.Trim,
                                        c1nUno.Value, c1nCinco.Value, c1nDiez.Value,
                                        c1nVeinte.Value, c1nCincuenta.Value, c1nCien.Value,
                                        C1nMonedaUno.Value, c1nFraccion.Value) <> 0 Then
                                        MsgBox("El registro fue ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Boveda")
                                        Me.Close()
                                    Else
                                        MsgBox("El registro no fue ingresado,por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Boveda")
                                        Me.Close()
                                    End If
                                    'Else
                                    '    MsgBox("Monto no coincide con detalle de efectivo", MsgBoxStyle.Critical, "Módulo - Boveda")

                                    'End If


                                End If
                            End If
                        End If
                    End If
                ElseIf vAccion = 2 Then


                    If C1NEMonto.Value = c1nTotal.Value Then
                        If insertarDetalleEfectivo(vCorrelativo, c1nUno.Value, c1nCinco.Value,
                                                   c1nDiez.Value, c1nVeinte.Value, c1nCincuenta.Value,
                                                   c1nCien.Value, C1nMonedaUno.Value, c1nFraccion.Value, 2,
                                                   sUsuario, Now) <> 0 Then
                            dtsTransacciones = Bancos.ConsultarBCCatTransacciones_Boveda(2, Me.cbTipoTransaccion.SelectedValue)

                            If dtsTransacciones.Tables(0).Rows(0).Item("tipoMov").ToString.Equals("A") Then
                                opcion = 3
                            ElseIf dtsTransacciones.Tables(0).Rows(0).Item("tipoMov").ToString.Equals("C") Then
                                opcion = 2
                            End If
                            Bancos.ModificarBcBoveda(Me.cbBoveda.SelectedValue, "", "", dtsBoveda.Tables(0).Rows(0).Item("saldo"), 0, 0, sUsuario, Now, sPassword,
                                                     sSucursal, opcion, c1nUno.Value, c1nCinco.Value,
                                                                c1nDiez.Value, c1nVeinte.Value,
                                                                c1nCincuenta.Value, c1nCien.Value,
                                                                C1nMonedaUno.Value, c1nFraccion.Value)




                            MsgBox("La información fue ingresada exitosamente.", MsgBoxStyle.Information, "Módulo - Boveda")
                            Me.Close()
                        Else
                            MsgBox("El registro no fue ingresado,por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Boveda")
                            Me.Close()
                        End If

                    Else
                        MsgBox("Monto no coincide con detalle de efectivo.", MsgBoxStyle.Critical, "Módulo - Boveda")

                    End If
                End If
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Error,por favor comunicarse con el administrador del sistema" + vbCrLf + ex.Message,
                   MsgBoxStyle.Critical, "Módulo - Boveda")
        End Try
    End Sub

    Private Sub txtReferencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReferencia.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub c1nCien_Validated(sender As Object, e As EventArgs) Handles c1nCien.Validated
        Me.ErrorProvider1.Clear()
        If valicarDenominaciones() = 0 Then
            Me.ErrorProvider1.SetError(c1nCien, "Se ha superado existencia de bóveda")
        End If
    End Sub

    Private Sub c1nCinco_Validating(sender As Object, e As CancelEventArgs) Handles c1nCinco.Validating
        Me.ErrorProvider1.Clear()
        If valicarDenominaciones() = 0 Then
            Me.ErrorProvider1.SetError(c1nCinco, "Se ha superado existencia de bóveda")
        End If
    End Sub

    Private Sub c1nCincuenta_Validating(sender As Object, e As CancelEventArgs) Handles c1nCincuenta.Validating
        Me.ErrorProvider1.Clear()
        If valicarDenominaciones() = 0 Then
            Me.ErrorProvider1.SetError(c1nCincuenta, "Se ha superado existencia de bóveda")
        End If
    End Sub

    Private Sub c1nDiez_Validating(sender As Object, e As CancelEventArgs) Handles c1nDiez.Validating
        Me.ErrorProvider1.Clear()
        If valicarDenominaciones() = 0 Then
            Me.ErrorProvider1.SetError(c1nDiez, "Se ha superado existencia de bóveda")
        End If
    End Sub

    Private Sub c1nFraccion_Validating(sender As Object, e As CancelEventArgs) Handles c1nFraccion.Validating
        Me.ErrorProvider1.Clear()
        If valicarDenominaciones() = 0 Then
            Me.ErrorProvider1.SetError(c1nFraccion, "Se ha superado existencia de bóveda")
        End If
    End Sub

    Private Sub C1nMonedaUno_Validating(sender As Object, e As CancelEventArgs) Handles C1nMonedaUno.Validating
        Me.ErrorProvider1.Clear()
        If valicarDenominaciones() = 0 Then
            Me.ErrorProvider1.SetError(C1nMonedaUno, "Se ha superado existencia de bóveda")
        End If
    End Sub

    Private Sub c1nUno_Validating(sender As Object, e As CancelEventArgs) Handles c1nUno.Validating
        Me.ErrorProvider1.Clear()
        If valicarDenominaciones() = 0 Then
            Me.ErrorProvider1.SetError(c1nUno, "Se ha superado existencia de bóveda")
        End If
    End Sub

    Private Sub c1nVeinte_Validating(sender As Object, e As CancelEventArgs) Handles c1nVeinte.Validating
        Me.ErrorProvider1.Clear()
        If valicarDenominaciones() = 0 Then
            Me.ErrorProvider1.SetError(c1nVeinte, "Se ha superado existencia de bóveda")
        End If
    End Sub

#End Region

End Class