Public Class frmMPRReversion
    Dim prestamo As New wrPrestamo.wsLibPrest

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim dts As New DataSet
        If rbCodPrestamo.Checked = True Then
            dts = prestamo.ConsultarPRReversiones("correlativo,codReversion,fecha as fechaAplicacion,tipoMov,Monto,codPrestamo,usu_autoriza,fechaAplicacion as fechaEjecución,idmovimiento,observaciones,monto", "codprestamo='" & txtCodPrestamo.Text.Trim & "'", "correlativo", sUsuario, sPassword, sSucursal)
        ElseIf rbCodReversion.Checked = True Then
            dts = prestamo.ConsultarPRReversiones("correlativo,codReversion,fecha as fechaAplicacion,tipoMov,Monto,codPrestamo,usu_autoriza,fechaAplicacion as fechaEjecución,idmovimiento,observaciones,monto", "codReversion='" & txtCodReversion.Text.Trim & "'", "correlativo", sUsuario, sPassword, sSucursal)

        ElseIf rbPeriodo.Checked = True Then
            dts = prestamo.ConsultarPRReversiones("correlativo,codReversion,fecha as fechaAplicacion,tipoMov,Monto,codPrestamo,usu_autoriza,fechaAplicacion as fechaEjecución,idmovimiento,observaciones,monto", "fechaaplicacion >='" & Format(dtpFechaIni.Value, "Short date") & "' and fechaaplicacion <='" & Format(dtpFechaFin.Value, "short date") & "'  ", "correlativo", sUsuario, sPassword, sSucursal)
        End If
        Me.dgReversiones.DataSource = dts.Tables(0)
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Dim frm As New frmMsPRReversion
        With frm
            .ShowDialog()
        End With
        Me.btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Dim frm As New frmMsPRReversion
        Dim dts As New DataSet
        dts = prestamo.CargaDatosPrestamo(Me.dgReversiones.Item("codPrestamo", Me.dgReversiones.CurrentRow.Index).Value.ToString, sUsuario, sPassword, sSucursal)


        With frm
            .txtNoSocio.Text = IIf(IsDBNull(dts.Tables("Prestamo").Rows(0).Item("NoSocio")), "", dts.Tables("Prestamo").Rows(0).Item("NoSocio").ToString.ToUpper)
            .txtCodReversion.Text = Me.dgReversiones.Item("codReversion", Me.dgReversiones.CurrentRow.Index).Value
            .rbAbono.Checked = IIf(Me.dgReversiones.Item("tipoMov", Me.dgReversiones.CurrentRow.Index).Value = "A", True, False)
            .rbCargo.Checked = IIf(Me.dgReversiones.Item("tipoMov", Me.dgReversiones.CurrentRow.Index).Value = "C", True, False)
            .txtAsociado.Text = IIf(IsDBNull(dts.Tables("Prestamo").Rows(0).Item("nombre")), "", dts.Tables("Prestamo").Rows(0).Item("nombre").ToString.ToUpper)
            .txtDui.Value = IIf(IsDBNull(dts.Tables("Prestamo").Rows(0).Item("dui")), "", dts.Tables("Prestamo").Rows(0).Item("dui").ToString.ToUpper)
            .txtCodPrestamo.Text = Me.dgReversiones.Item("codPrestamo", Me.dgReversiones.CurrentRow.Index).Value.ToString
            .dtpDia.Value = Me.dgReversiones.Item("fechaAplicacion", Me.dgReversiones.CurrentRow.Index).Value.ToString
            .txtNoDocumento.Text = Me.dgReversiones.Item("idMovimiento", Me.dgReversiones.CurrentRow.Index).Value.ToString
            .txtObs.Text = Me.dgReversiones.Item("observaciones", Me.dgReversiones.CurrentRow.Index).Value.ToString
            .C1NEMonto.Value = Me.dgReversiones.Item("monto", Me.dgReversiones.CurrentRow.Index).Value.ToString
            .btnAplicar.Enabled = False
            .rbAbono.Enabled = False
            .rbCargo.Enabled = False
            .rbCaja.Enabled = False
            .rbTransferencia.Enabled = False
            .rbReversion.Enabled = False
            .dtpDia.Enabled = False
            .txtNoDocumento.Enabled = False
            .txtCodPrestamo.Enabled = False
            .txtDui.Enabled = False
            .C1NEMonto.Visible = False
            .txtObs.Enabled = False
            .ShowDialog()

        End With
        Me.btnMostrar1_Click(sender, e)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try

            Dim tipo As Integer
                If Me.dgReversiones.Item("tipoMov", Me.dgReversiones.CurrentRow.Index).Value = "A" Then
                    tipo = 1
                ElseIf Me.dgReversiones.Item("tipoMov", Me.dgReversiones.CurrentRow.Index).Value = "C" Then
                    tipo = 2
                End If

            OpcionRS = 89
                    Dim frm As New frmVisorRS
                    With frm
                        .idTipo = tipo
                        .codReversion = Me.dgReversiones.Item("codReversion", Me.dgReversiones.CurrentRow.Index).Value
                        .Show()
                    End With


        Catch ex As Exception

        End Try
    End Sub
End Class