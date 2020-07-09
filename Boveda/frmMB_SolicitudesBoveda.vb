Public Class frmMB_SolicitudesBoveda
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Seguridad As New wrAdmin.wsLibAdmin
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim caja As New wrCaja.wsLibCaja
    Dim TipoUsuario As Integer
    Dim vIdTipoMovCaja As Integer
    Dim vCodCajero As Integer
    Dim vCajero As String
    Dim vUsuario As String
#Region "Propiedades"
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
#Region "Metodos"
    'Protected Sub llenarCbCajeros(ByVal campos As String, ByVal filtro As String)
    '    Dim dts As New DataSet
    '    dts = caja.ConsultarCajeros(campos, filtro, "", sUsuario, sPassword, sSucursal)
    '    If dts.Tables.Count > 0 Then
    '        If dts.Tables(0).Rows.Count > 0 Then
    '            Me.cbCajero.DataSource = dts.Tables(0)
    '        End If
    '    End If


    'End Sub
    'Protected Sub LlenarCbSucursales(ByVal Campos, ByVal Filtro, ByVal Orden, ByVal sUsuario, ByVal sPassword, ByVal sSucursal)
    '    Dim Dts As New DataSet
    '    Dts = asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
    '    Me.cbSucursales.DataSource = Dts.Tables(0)
    'End Sub
    Public Sub LlenarDgSolicitudes(ByVal Usuario As String, ByVal Fecha As DateTime, _
                                   ByVal CodSucursal As String, ByVal UsuarioAutoriza As String, _
                                   ByVal CodCajero As Integer, ByVal NoCaja As Integer, _
                                   ByVal Opcion As Integer)
        Dim Dts As New DataSet
        Dts = Bancos.ConsultarBcSolicitudes_Boveda(Usuario, Fecha, CodSucursal, _
                                                   Usuario, CodCajero, NoCaja, _
                                                   Opcion, sUsuario, sPassword, _
                                                   sSucursal)
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.dgBoveda.DataSource = Dts.Tables(0)

                estiloDg()
            End If
        End If
    End Sub
    Protected Sub estiloDg()
        Me.dgBoveda.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgBoveda.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgBoveda.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgBoveda.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders


        Me.dgBoveda.Columns("CodSolicitud").HeaderText = "No. Solicitud"
        Me.dgBoveda.Columns("Nom_Sucursal").HeaderText = "Sucursal"
        Me.dgBoveda.Columns("usuarioautoriza").HeaderText = "Autorizado Por"
        Me.dgBoveda.Columns("fechaautoriza").HeaderText = "Fecha de Autorización"
        Me.dgBoveda.Columns("horaautoriza").HeaderText = "Hora de Autorización"

        Me.dgBoveda.Columns("CodCajero").Visible = False
        Me.dgBoveda.Columns("CodSucursal").Visible = False
        Me.dgBoveda.Columns("idTipoMovCaja").Visible = False
        Me.dgBoveda.Columns("CantidadBilletesUno").Visible = False
        Me.dgBoveda.Columns("CantidadBilletesCinco").Visible = False
        Me.dgBoveda.Columns("CantidadBilletesDiez").Visible = False
        Me.dgBoveda.Columns("CantidadBilletesVeinte").Visible = False
        Me.dgBoveda.Columns("CantidadBilletesCincuenta").Visible = False
        Me.dgBoveda.Columns("CantidadBilletesCien").Visible = False
        Me.dgBoveda.Columns("CantidadMonedasUno").Visible = False
        Me.dgBoveda.Columns("MontoMonedaFraccionaria").Visible = False


        Me.dgBoveda.Columns("CodSolicitud").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBoveda.Columns("Cajero").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBoveda.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBoveda.Columns("Monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBoveda.Columns("Hora").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBoveda.Columns("Usuario").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBoveda.Columns("Nom_Sucursal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBoveda.Columns("usuarioautoriza").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBoveda.Columns("fechaautoriza").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBoveda.Columns("horaautoriza").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells


    End Sub
#End Region
#Region "Funciones"
    Protected Function ConsultarAccesos(ByVal Usuario As String, ByVal Pwd As String, ByVal Sucursal As String) As Boolean
        Try

            Dim dtsRoles As New DataSet
            dtsRoles = Seguridad.ConsultarRolesUsuario(Usuario, "", 2)
            If dtsRoles.Tables.Count > 0 Then
                If dtsRoles.Tables(0).Rows.Count > 0 Then
                    For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                        If Seguridad.ConsultarPermisoProcesos("BCH005", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                            LlenarDgSolicitudes("", Format(Now, "Short Date"), Sucursal, "", pCodCajero, pNocaja, 1)
                            TipoUsuario = 1
                            Me.btnAgregar.Enabled = True
                            Me.btnModificar.Enabled = False
                            Me.btnMod.Enabled = False
                            Exit For
                        ElseIf Seguridad.ConsultarPermisoProcesos("BCH006", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                            TipoUsuario = 2
                            Me.btnAgregar.Enabled = False
                            Me.btnModificar.Enabled = True
                            Exit For
                        ElseIf Seguridad.ConsultarPermisoProcesos("BCH007", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then


                            TipoUsuario = 3

                            Exit For
                        End If

                    Next
                End If
            End If

        Catch ex As Exception

        End Try
    End Function
#End Region
#Region "Eventos"
    Private Sub frmMB_SolicitudesBoveda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'cbCajero.DisplayMember = "Nombre"
        'cbCajero.ValueMember = "CodCajero"
        'Me.cbSucursales.DisplayMember = "Nom_Sucursal"
        'Me.cbSucursales.ValueMember = "CodSucursal"
        ConsultarAccesos(sUsuario, sPassword, sSucursal)
        If TipoUsuario = 1 Then
            Me.btnImprimir.Visible = True
        ElseIf TipoUsuario = 2 Then 'Jefatura.
            LlenarDgSolicitudes(sUsuario, Format(Now, "Short Date"), sSucursal, sUsuario, 0, 0, 2)
            Me.btnImprimir.Visible = False
        ElseIf TipoUsuario = 3 Then
            LlenarDgSolicitudes(sUsuario, Format(Now, "Short Date"), sSucursal, sUsuario, 0, 0, 3)
            Me.btnImprimir.Visible = True
        End If

    End Sub



#End Region

    Protected Sub generarReporte(ByVal correlativo As Integer, ByVal fecha As DateTime)
        Dim frmVisorRpt As New frmVisorRS
        OpcionRS = 38
        With frmVisorRpt
            .noCaja = pNocaja
            .fecha = Format(fecha, "short date")
            .CorrelativoMovCaja = correlativo
            .ShowDialog()
        End With
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dgBoveda_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBoveda.DoubleClick
        If TipoUsuario = 1 Then
            If Me.dgBoveda.CurrentRow.Index >= 0 Then
                If Me.dgBoveda.Item("Aprobada", Me.dgBoveda.CurrentRow.Index).Value = True Then
                    Dim frm As New frmMsCaAperturaCaja
                    With frm
                        .Origen = 1
                        .CodCajero = Me.dgBoveda.Item("CodCajero", Me.dgBoveda.CurrentRow.Index).Value
                        .Cajero = Me.dgBoveda.Item("Cajero", Me.dgBoveda.CurrentRow.Index).Value
                        .Usuario = vUsuario
                        .C1NEMontoApertura.Value = Me.dgBoveda.Item("Monto", Me.dgBoveda.CurrentRow.Index).Value
                        .C1NEMontoApertura.Enabled = False
                        .cbTipoMov.Visible = False
                        .lblTipoMov.Visible = False
                        .c1nUno.Value = Me.dgBoveda.Item("CantidadBilletesUno", Me.dgBoveda.CurrentRow.Index).Value
                        .c1nCinco.Value = Me.dgBoveda.Item("CantidadBilletesCinco", Me.dgBoveda.CurrentRow.Index).Value
                        .c1nDiez.Value = Me.dgBoveda.Item("CantidadBilletesDiez", Me.dgBoveda.CurrentRow.Index).Value
                        .c1nVeinte.Value = Me.dgBoveda.Item("CantidadBilletesVeinte", Me.dgBoveda.CurrentRow.Index).Value
                        .c1nCincuenta.Value = Me.dgBoveda.Item("CantidadBilletesCincuenta", Me.dgBoveda.CurrentRow.Index).Value
                        .c1nCien.Value = Me.dgBoveda.Item("CantidadBilletesCien", Me.dgBoveda.CurrentRow.Index).Value
                        .C1nMonedaUno.Value = Me.dgBoveda.Item("CantidadMonedasUno", Me.dgBoveda.CurrentRow.Index).Value
                        .c1nFraccion.Value = Me.dgBoveda.Item("MontoMonedaFraccionaria", Me.dgBoveda.CurrentRow.Index).Value
                        .c1nTotal.Value = Me.dgBoveda.Item("Monto", Me.dgBoveda.CurrentRow.Index).Value
                        .codSolicitud = Me.dgBoveda.Item("codSolicitud", Me.dgBoveda.CurrentRow.Index).Value
                        ' desabilitamos detalle
                        .c1nUno.ReadOnly = True
                        .c1nCinco.ReadOnly = True
                        .c1nDiez.ReadOnly = True
                        .c1nVeinte.ReadOnly = True
                        .c1nCincuenta.ReadOnly = True
                        .c1nCien.ReadOnly = True
                        .C1nMonedaUno.ReadOnly = True
                        .c1nFraccion.ReadOnly = True
                        .c1nTotal.ReadOnly = True
                        .ShowDialog()
                    End With
                Else
                    MsgBox("La solicitud no ha sido autorizada.", MsgBoxStyle.Information, "Módulo - Caja")
                End If
                
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            Dim frm As New frmMsCaAperturaCaja
            With frm
                .cbTipoCaja.Visible = False
                .Text = "Solicitudes Bóveda"
                .lblTipoCaja.Visible = False
                .lblMonto.Text = "Monto:"
                .lblEncabezado2.Text = "Detalle de Transacción"
                .Origen = 2
                .ShowDialog()
            End With
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            If Me.dgBoveda.RowCount > 0 Then
                If Me.dgBoveda.Item("Aprobada", Me.dgBoveda.CurrentRow.Index).Value = False And
                Me.dgBoveda.Item("UsuarioAutoriza", Me.dgBoveda.CurrentRow.Index).Value Is DBNull.Value = True Then
                    Dim dtsMovCaja As New DataSet
                    dtsMovCaja = caja.consultarCaTipoMovCaja(2, Me.dgBoveda.Item("idTipoMovCaja", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim, 0, sUsuario, sPassword, sSucursal)
                    If dtsMovCaja.Tables.Count > 0 Then
                        If dtsMovCaja.Tables(0).Rows.Count > 0 Then
                            Dim dtsTransaccionesBoveda As New DataSet
                            dtsTransaccionesBoveda = Bancos.ConsultarBCCatTransacciones_Boveda(2, dtsMovCaja.Tables(0).Rows(0).Item(0))
                            If dtsTransaccionesBoveda.Tables.Count > 0 Then
                                If dtsTransaccionesBoveda.Tables(0).Rows.Count > 0 Then
                                    Dim tipoMov As String
                                    tipoMov = dtsTransaccionesBoveda.Tables(0).Rows(0).Item("tipoMov")
                                    'If tipoMov.Equals("A") Then
                                    Dim frm As New frmMsBc_SolicitudesBoveda
                                    Dim dtsmovimientosCaja As New DataSet
                                    dtsmovimientosCaja = caja.ConsultarMovimientoCaja(" CantidadMonedaUno, CantidadUno, CantidadCinco, CantidadDiez, CantidadVeinte, " &
                                                                                      "CantidadCincuenta, CantidadCien, CantidadFraccion",
                                                                                      "Correlativo= " & dgBoveda.Item("codTransaccion", Me.dgBoveda.CurrentRow.Index).Value,
                                                                                      "", sUsuario, sPassword, sSucursal)
                                    If dtsmovimientosCaja.Tables(0).Rows.Count > 0 Then
                                        With frm
                                            .tipoUsuario = TipoUsuario
                                            .Accion = 2
                                            .lblCajero.Visible = True
                                            .lblObservacion.Visible = True
                                            .btnAutorizar.Visible = True
                                            .btnDenegar.Visible = True
                                            .idTipoMovCaja = Me.dgBoveda.Item("idTipoMovCaja", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                                            .lblCajero.Text = Me.dgBoveda.Item("Cajero", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                                            .txtMonto.Value = Me.dgBoveda.Item("Monto", Me.dgBoveda.CurrentRow.Index).Value
                                            .btnProcesar.Visible = False
                                            .codSolic = Me.dgBoveda.Item("CodSolicitud", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                                            .codSuc = Me.dgBoveda.Item("CodSucursal", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                                            .c1nUno.Value = IIf(dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadUno") Is DBNull.Value, 0, dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadUno"))
                                            .c1nCinco.Value = IIf(dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadCinco") Is DBNull.Value, 0, dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadCinco"))
                                            .c1nDiez.Value = IIf(dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadDiez") Is DBNull.Value, 0, dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadDiez"))
                                            .c1nVeinte.Value = IIf(dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadVeinte") Is DBNull.Value, 0, dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadVeinte"))
                                            .c1nCincuenta.Value = IIf(dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadCincuenta") Is DBNull.Value, 0, dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadCincuenta"))
                                            .c1nCien.Value = IIf(dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadCien") Is DBNull.Value, 0, dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadCien"))
                                            .C1nMonedaUno.Value = IIf(dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadMonedaUno") Is DBNull.Value, 0, dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadMonedaUno"))
                                            .c1nFraccion.Value = IIf(dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadFraccion") Is DBNull.Value, 0, dtsmovimientosCaja.Tables(0).Rows(0).Item("CantidadFraccion"))
                                            .c1nTotal.Value = Me.dgBoveda.Item("Monto", Me.dgBoveda.CurrentRow.Index).Value
                                            .ShowDialog()
                                            ConsultarAccesos(sUsuario, sPassword, sSucursal)
                                            If TipoUsuario = 1 Then
                                                Me.btnImprimir.Visible = True
                                            ElseIf TipoUsuario = 2 Then 'Jefatura.
                                                LlenarDgSolicitudes(sUsuario, Format(Now, "Short Date"), sSucursal, sUsuario, 0, 0, 2)
                                                Me.btnImprimir.Visible = False
                                            ElseIf TipoUsuario = 3 Then
                                                LlenarDgSolicitudes(sUsuario, Format(Now, "Short Date"), sSucursal, sUsuario, 0, 0, 3)
                                                Me.btnImprimir.Visible = True
                                            End If

                                        End With
                                    Else
                                        With frm
                                            .tipoUsuario = TipoUsuario
                                            .Accion = 2
                                            .lblCajero.Visible = True
                                            .lblObservacion.Visible = True
                                            .btnAutorizar.Visible = True
                                            .btnDenegar.Visible = True
                                            .idTipoMovCaja = Me.dgBoveda.Item("idTipoMovCaja", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                                            .lblCajero.Text = Me.dgBoveda.Item("Cajero", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                                            .txtMonto.Value = Me.dgBoveda.Item("Monto", Me.dgBoveda.CurrentRow.Index).Value
                                            .btnProcesar.Visible = False
                                            .codSolic = Me.dgBoveda.Item("CodSolicitud", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                                            .codSuc = Me.dgBoveda.Item("CodSucursal", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                                            .c1nUno.Value = 0
                                            .c1nCinco.Value = 0
                                            .c1nDiez.Value = 0
                                            .c1nVeinte.Value = 0
                                            .c1nCincuenta.Value = 0
                                            .c1nCien.Value = 0
                                            .C1nMonedaUno.Value = 0
                                            .c1nFraccion.Value = 0
                                            .c1nTotal.Value = 0
                                            .ShowDialog()
                                            ConsultarAccesos(sUsuario, sPassword, sSucursal)
                                            If TipoUsuario = 1 Then
                                                Me.btnImprimir.Visible = True
                                            ElseIf TipoUsuario = 2 Then 'Jefatura.
                                                LlenarDgSolicitudes(sUsuario, Format(Now, "Short Date"), sSucursal, sUsuario, 0, 0, 2)
                                                Me.btnImprimir.Visible = False
                                            ElseIf TipoUsuario = 3 Then
                                                LlenarDgSolicitudes(sUsuario, Format(Now, "Short Date"), sSucursal, sUsuario, 0, 0, 3)
                                                Me.btnImprimir.Visible = True
                                            End If
                                        End With
                                    End If
                                End If
                            End If
                        End If
                    End If

                ElseIf Me.dgBoveda.Item("Aprobada", Me.dgBoveda.CurrentRow.Index).Value = True And
                Me.dgBoveda.Item("Aprobada", Me.dgBoveda.CurrentRow.Index).Value Is DBNull.Value = False Then
                    MsgBox("La solicitud ya fue autorizada", MsgBoxStyle.Information, "Módulo - Bóveda")
                End If

            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim frm As New frmMsBc_SolicitudesBoveda
            If TipoUsuario = 1 Then
                With frm
                    .tipoUsuario = TipoUsuario
                    .Accion = 2
                    .lblCajero.Visible = True
                    .lblObservacion.Visible = True
                    .btnAutorizar.Visible = True
                    .btnDenegar.Visible = True
                    .lblCajero.Visible = False
                    '.lblCajero.Text = Me.dgBoveda.Item("Cajero", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                    .txtMonto.Value = Me.dgBoveda.Item("Monto", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                    .btnProcesar.Enabled = False
                    .codSolic = Me.dgBoveda.Item("CodSolicitud", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                End With
            Else
                With frm
                    .tipoUsuario = TipoUsuario
                    .Accion = 2
                    .lblCajero.Visible = True
                    .lblObservacion.Enabled = False
                    .btnAutorizar.Enabled = False
                    .btnDenegar.Visible = True
                    .lblCajero.Text = Me.dgBoveda.Item("Cajero", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                    .txtMonto.Value = Me.dgBoveda.Item("Monto", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                    .btnProcesar.Enabled = False
                    .codSolic = Me.dgBoveda.Item("CodSolicitud", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim
                End With
            End If
            frm.ShowDialog()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            ConsultarAccesos(sUsuario, sPassword, sSucursal)
            If TipoUsuario = 1 Then
                Me.btnImprimir.Visible = True
            ElseIf TipoUsuario = 2 Then 'Jefatura.
                LlenarDgSolicitudes(sUsuario, Format(Now, "Short Date"), sSucursal, sUsuario, 0, 0, 2)
                Me.btnImprimir.Visible = False
            ElseIf TipoUsuario = 3 Then
                LlenarDgSolicitudes(sUsuario, Format(Now, "Short Date"), sSucursal, sUsuario, 0, 0, 3)
                Me.btnImprimir.Visible = True
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If MsgBox("¿Desea eliminar este registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Bóveda") = MsgBoxResult.Yes Then
                Dim Resultado As Integer
                Resultado = Bancos.EliminarBcSolicitudes_Boveda(Me.dgBoveda.Item("CodSolicitud", Me.dgBoveda.CurrentRow.Index).Value.ToString.Trim, sUsuario, sPassword, sSucursal)
                If Resultado <> 0 Then
                    MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Bóveda")
                Else
                    MsgBox("No se pudo eliminar el registro, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Information, "Bóveda")
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            If TipoUsuario = 1 Or TipoUsuario = 3 Then
                If Me.dgBoveda.CurrentRow.Index > -1 Then
                    Dim correlativo As Integer
                    Dim fecha As DateTime
                    correlativo = Me.dgBoveda.Item("CorrelativoMovCaja", Me.dgBoveda.CurrentRow.Index).Value
                    fecha = Me.dgBoveda.Item("Fecha", Me.dgBoveda.CurrentRow.Index).Value
                    generarReporte(correlativo, fecha)
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMB_SolicitudesBoveda_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class