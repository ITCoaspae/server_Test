Public Class frmMBc_MovimientosBoveda
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Asociados As New wrAsociados.wsLibAsoc
    Dim contabilidad As New wrConta.wsLibContab
#Region "Metodos"
    Protected Sub LlenarCbSucursales(ByVal Campos, ByVal Filtro, ByVal Orden, ByVal sUsuario, ByVal sPassword, ByVal sSucursal)
        Dim Dts As New DataSet
        Dts = Asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
        Me.cbSucursales.DataSource = Dts.Tables(0)
    End Sub
    Protected Sub llenarDgMovimientosBoveda(ByVal fecha As DateTime, ByVal codSucural As String, ByVal opcion As Integer)
        Dim dts As New DataSet
        dts = Bancos.consultarBcMovimientosBoveda(opcion, codSucural, fecha)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgMovimientos.DataSource = dts.Tables(0)
                estiloDg()
            End If
        End If
    End Sub
    Protected Sub estiloDg()
        Me.dgMovimientos.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgMovimientos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgMovimientos.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgMovimientos.Columns("Descripcion").HeaderText = "Bóveda"
        Me.dgMovimientos.Columns("Num_Partida").HeaderText = "Número de partida"
        Me.dgMovimientos.Columns("FechaMov").HeaderText = "Fecha"
        Me.dgMovimientos.Columns("TipoMov").HeaderText = "Tipo de Movimiento"
        Me.dgMovimientos.Columns("SaldoAnterior").HeaderText = "Saldo Anterior"
        Me.dgMovimientos.Columns("SaldoActual").HeaderText = "Saldo"

        Me.dgMovimientos.Columns("CodSucursal").Visible = False
        Me.dgMovimientos.Columns("id_Boveda").Visible = False
        Me.dgMovimientos.Columns("CodTransaccion").Visible = False
        Me.dgMovimientos.Columns("idMovimiento").Visible = False

        Me.dgMovimientos.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
#End Region
#Region "Eventos"

    Private Sub frmMBc_MovimientosBoveda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbSucursales.DisplayMember = "Nom_Sucursal"
        Me.cbSucursales.ValueMember = "CodSucursal"
        LlenarCbSucursales("nom_sucursal,codsucursal", "CodSucursal = '" & sSucursal & "'", "", sUsuario, sPassword, sSucursal)
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnInsertarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCambioEfectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Try
            llenarDgMovimientosBoveda(Format(Me.dtpFecha.Value, "short date"), Me.cbSucursales.SelectedValue, 4)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim ofrm As New frmMsBC_MovimientosBoveda
            With ofrm
                '.LlenarCBSucursales("CodSucursal,nom_sucursal", "CodSucursal = '" & sSucursal & "'", "")
                .accion = 1
                .ShowDialog()
            End With
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.dgMovimientos.CurrentRow.Index > -1 Then
                Dim frm As New frmMsBC_MovimientosBoveda
                With frm
                    .accion = 2
                    .cbSucursal.DisplayMember = "Nom_Sucursal"
                    .cbSucursal.ValueMember = "CodSucursal"
                    .cbTipoTransaccion.DisplayMember = "Descripcion"
                    .cbTipoTransaccion.ValueMember = "codTransaccion"
                    .cbBoveda.DisplayMember = "descripcion"
                    .cbBoveda.ValueMember = "id_Boveda"
                    .LlenarCBSucursales("CodSucursal,nom_sucursal", "CodSucursal = '" & Me.dgMovimientos.Item("CodSucursal", Me.dgMovimientos.CurrentRow.Index).Value.ToString.Trim & "'", "")
                    .llenarCbBoveda(0, 2, Me.dgMovimientos.Item("CodSucursal", Me.dgMovimientos.CurrentRow.Index).Value.ToString.Trim & "'")
                    .llenarCbTransacciones(2, Me.dgMovimientos.Item("CodTransaccion", Me.dgMovimientos.CurrentRow.Index).Value)
                    .C1NEMonto.Value = Me.dgMovimientos.Item("Monto", Me.dgMovimientos.CurrentRow.Index).Value
                    .dtpFecha.Value = Me.dgMovimientos.Item("FechaMov", Me.dgMovimientos.CurrentRow.Index).Value
                    .cbBoveda.Enabled = False
                    .cbSucursal.Enabled = False
                    .cbTipoTransaccion.Enabled = False
                    .C1NEMonto.ReadOnly = True
                    .correlativo = Me.dgMovimientos.Item("Correlativo", Me.dgMovimientos.CurrentRow.Index).Value
                    .dtpFecha.Enabled = False
                    .cbSucursal.Enabled = False
                    .cbBoveda.Enabled = False
                    .cbTipoTransaccion.Enabled = False
                    .txtObservacion.Text = Me.dgMovimientos.Item("observacion", Me.dgMovimientos.CurrentRow.Index).Value
                    .txtReferencia.Text = Me.dgMovimientos.Item("idMovimiento", Me.dgMovimientos.CurrentRow.Index).Value
                    .txtReferencia.ReadOnly = True
                    .txtObservacion.ReadOnly = True
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            Dim frm As New frmMsBc_CambioEfectivo
            With frm
                .ShowDialog()
            End With
            llenarDgMovimientosBoveda(Format(Me.dtpFecha.Value, "short date"), Me.cbSucursales.SelectedValue, 4)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs)
        Try
            Dim ofrm As New frmMsBC_MovimientosBoveda
            With ofrm
                .accion = 2
                .LlenarCBSucursales("CodSucursal,nom_sucursal", "CodSucursal = '" & Me.dgMovimientos.Item("CodSucursal", Me.dgMovimientos.CurrentRow.Index).Value.ToString.Trim & "'", "")
                .llenarCbBoveda(0, 2, Me.dgMovimientos.Item("CodSucursal", Me.dgMovimientos.CurrentRow.Index).Value.ToString.Trim & "'")
                .llenarCbTransacciones(2, Me.dgMovimientos.Item("CodTransaccion", Me.dgMovimientos.CurrentRow.Index).Value)
                .C1NEMonto.Value = Me.dgMovimientos.Item("Monto", Me.dgMovimientos.CurrentRow.Index).Value
                .dtpFecha.Value = Me.dgMovimientos.Item("FechaMov", Me.dgMovimientos.CurrentRow.Index).Value
                .ShowDialog()
            End With
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            Dim ofrm As New frmMsBC_MovimientosBoveda
            With ofrm
                .accion = 3
                .cbSucursal.DisplayMember = "Nom_Sucursal"
                .cbSucursal.ValueMember = "CodSucursal"
                .cbTipoTransaccion.DisplayMember = "Descripcion"
                .cbTipoTransaccion.ValueMember = "codTransaccion"
                .cbBoveda.DisplayMember = "descripcion"
                .cbBoveda.ValueMember = "id_Boveda"
                .LlenarCBSucursales("CodSucursal,nom_sucursal", "CodSucursal = '" & Me.dgMovimientos.Item("CodSucursal", Me.dgMovimientos.CurrentRow.Index).Value.ToString.Trim & "'", "")
                .llenarCbBoveda(0, 2, Me.dgMovimientos.Item("CodSucursal", Me.dgMovimientos.CurrentRow.Index).Value.ToString.Trim & "'")
                .llenarCbTransacciones(2, Me.dgMovimientos.Item("CodTransaccion", Me.dgMovimientos.CurrentRow.Index).Value)
                .C1NEMonto.Value = Me.dgMovimientos.Item("Monto", Me.dgMovimientos.CurrentRow.Index).Value
                .dtpFecha.Value = Me.dgMovimientos.Item("FechaMov", Me.dgMovimientos.CurrentRow.Index).Value
                .c1nUno.Value = Me.dgMovimientos.Item("cantidadBilletesUno", Me.dgMovimientos.CurrentRow.Index).Value
                .c1nCinco.Value = Me.dgMovimientos.Item("cantidadBilletesCinco", Me.dgMovimientos.CurrentRow.Index).Value
                .c1nDiez.Value = Me.dgMovimientos.Item("cantidadBilletesDiez", Me.dgMovimientos.CurrentRow.Index).Value
                .c1nVeinte.Value = Me.dgMovimientos.Item("cantidadBilletesVeinte", Me.dgMovimientos.CurrentRow.Index).Value
                .c1nCincuenta.Value = Me.dgMovimientos.Item("cantidadBilletesCincuenta", Me.dgMovimientos.CurrentRow.Index).Value
                .c1nCien.Value = Me.dgMovimientos.Item("cantidadBilletesCien", Me.dgMovimientos.CurrentRow.Index).Value
                .C1nMonedaUno.Value = Me.dgMovimientos.Item("cantidadMonedasUno", Me.dgMovimientos.CurrentRow.Index).Value
                .c1nFraccion.Value = Me.dgMovimientos.Item("MontoMonedaFraccionaria", Me.dgMovimientos.CurrentRow.Index).Value
                .c1nTotal.Value = Me.dgMovimientos.Item("Monto", Me.dgMovimientos.CurrentRow.Index).Value
                .txtObservacion.Text = Me.dgMovimientos.Item("Observacion", Me.dgMovimientos.CurrentRow.Index).Value
                .cbBoveda.Enabled = False
                .cbSucursal.Enabled = False
                .cbTipoTransaccion.Enabled = False
                .C1NEMonto.ReadOnly = True
                .dtpFecha.Enabled = False
                .ShowDialog()
            End With
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)
        Try
            If MsgBox("¿Desea eliminar este registro?", MsgBoxStyle.YesNo, "Módulo - Boveda") = MsgBoxResult.Yes Then
                Dim dtsPartidas As New DataSet
                Dim numpartida As String
                numpartida = Me.dgMovimientos.Item("numPartida", Me.dgMovimientos.CurrentRow.Index).Value

                dtsPartidas = contabilidad.BuscarPartidasxNumero("NumPartida", numpartida, numpartida, sUsuario, sPassword)
                If dtsPartidas.Tables.Count > 0 Then
                    If dtsPartidas.Tables(0).Rows.Count > 0 Then
                        Dim autorizado As String
                        Dim Estado As String
                        autorizado = dtsPartidas.Tables(0).Rows(0).Item("Autorizado")
                        Estado = autorizado = dtsPartidas.Tables(0).Rows(0).Item("IdEstado")
                        If autorizado.Trim.Equals("0") = True And Estado.Trim.Equals("D") = True Then

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Try
            If Me.dgMovimientos.Item("noremesa", Me.dgMovimientos.CurrentRow.Index).Value Is DBNull.Value Then
                Dim frm As New frmDetalleRemesaBanco
                With frm
                    .correlativo = Me.dgMovimientos.Item("Correlativo", Me.dgMovimientos.CurrentRow.Index).Value
                    .ShowDialog()
                End With
            Else
                MsgBox("Los datos de remesa ya fueron ingresados", MsgBoxStyle.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class