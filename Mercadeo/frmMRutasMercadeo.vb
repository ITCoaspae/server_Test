Public Class frmMRutasMercadeo
    Dim rutas As New wsSysFinCoop.LibAsoc.wsLibAsoc
    Dim Seguridad As New wsSysFinCoop.LibAdmin.wsLibAdmin
    Dim tipoUsuario As Integer '1:asesor;2:Jefe;3:Admin
    Protected Sub llenarCbAsesores(ByVal codSucursal As String)
        Dim dts As New DataSet
        dts = rutas.consultarMercaRutasAsesores(codSucursal) 'Seguridad.ConsultarUsuario("usuario,nombre", "CodSucursal = '" & codSucursal & "'", " nombre", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEjecutivo.DisplayMember = "nombre"
                Me.cbEjecutivo.ValueMember = "usuario"
                Me.cbEjecutivo.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub consultarAccesos()
        Try
            Dim dtsRoles As New DataSet
            dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
            If dtsRoles.Tables.Count > 0 Then
                If dtsRoles.Tables(0).Rows.Count > 0 Then
                    For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                        If Seguridad.ConsultarPermisoProcesos("MER001", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                            tipoUsuario = 1
                            'llenarDg(3, sSucursal, sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                            Exit For
                        ElseIf Seguridad.ConsultarPermisoProcesos("MER002", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                            tipoUsuario = 2
                            'llenarDg(4, sSucursal, sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                            Exit For
                        ElseIf Seguridad.ConsultarPermisoProcesos("MER003", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                            tipoUsuario = 3
                            'llenarDg(1, sSucursal, sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                            Exit For
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox("Error por favor cominicarse con el administrador de sistemas.", MsgBoxStyle.Critical, "Rutas")
        End Try
    End Sub
    Protected Sub llenarDg(ByVal opcion As Integer, ByVal codSucursal As String, _
                           ByVal usuario As String, ByVal fechaIni As DateTime, _
                           ByVal fechaFin As DateTime)
        Dim dts As New DataSet
        dts = rutas.consultarMercaRutas(opcion, codSucursal, _
                                        usuario, fechaIni, fechaFin, 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgRutas.DataSource = dts.Tables(0)
                estiloDg()
                'For i As Integer = 0 To dgRutas.Rows.Count - 1
                '    If Me.dgRutas.Item("idTipoGestion", i).Value = 5 Then
                '        Me.dgRutas.Rows(i).DefaultCellStyle.BackColor = Color.Maroon
                '        Me.dgRutas.Rows(i).DefaultCellStyle.ForeColor = Color.White
                '        'Me.dgRutas.Item("idTipoGestion", i).Style.BackColor = Color.Maroon
                '        'Me.dgRutas.Item("idTipoGestion", i).Style.ForeColor = Color.White
                '    ElseIf Me.dgRutas.Item("idTipoGestion", i).Value = 6 Then
                '        Me.dgRutas.Rows(i).DefaultCellStyle.BackColor = Color.Khaki
                '        Me.dgRutas.Rows(i).DefaultCellStyle.ForeColor = Color.White
                '        'Me.dgRutas.Item("idTipoGestion", i).Style.BackColor = Color.YellowGreen
                '        'Me.dgRutas.Item("idTipoGestion", i).Style.ForeColor = Color.Black
                '    ElseIf Me.dgRutas.Item("idTipoGestion", i).Value = 13 Then
                '        Me.dgRutas.Rows(i).DefaultCellStyle.BackColor = Color.OliveDrab
                '        Me.dgRutas.Rows(i).DefaultCellStyle.ForeColor = Color.White
                '        'Me.dgRutas.Item("idTipoGestion", i).Style.BackColor = Color.OliveDrab
                '        'Me.dgRutas.Item("idTipoGestion", i).Style.ForeColor = Color.White
                '    End If
                'Next


            End If
        End If
    End Sub
    Protected Sub estiloDg()
        Me.dgRutas.Columns("idRuta").Visible = False
        Me.dgRutas.Columns("codPagaduria").Visible = False
        Me.dgRutas.Columns("idActividad").Visible = False
        Me.dgRutas.Columns("idTipoGestion").Visible = False
        Me.dgRutas.Columns("fechaActu").Visible = False
        Me.dgRutas.Columns("usuarioActu").Visible = False
        Me.dgRutas.Columns("idMercaRutaVisitas").Visible = False
        Me.dgRutas.Columns("Actividad").Visible = False
        Me.dgRutas.Columns("TipoGestion").Visible = False
        Me.dgRutas.Columns("Usuario").Visible = False
        Me.dgRutas.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
        Me.dgRutas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        'Me.dgRutas.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgRutas.Columns("nombre").HeaderText = "Asesor"
        Me.dgRutas.Columns("nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgRutas.Columns("cliente").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgRutas.Columns("pagaduria").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgRutas.Columns("Actividad").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgRutas.Columns("TipoGestion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgRutas.Columns("Observacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        If tipoUsuario = 1 Then
            'Me.dgRutas.Columns("revisado").Visible = False
            'Me.dgRutas.Columns("fechaRevision").Visible = False
            Me.dgRutas.Columns("UsuarioRevisa").Visible = False
            Me.dgRutas.Columns("ObsRevision").Visible = False
        End If
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frm As New frmMsRutasMercadeo
        With frm
            .accion = 1
            .lblEncabezado.Text = "Ingreso de Ruta Asesor Financiero"
            .ShowDialog(Me)
        End With
        If tipoUsuario = 1 Then
            llenarDg(3, "", sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
        ElseIf tipoUsuario = 2 Then
            llenarDg(4, Me.cbSucursal.SelectedValue, Me.cbEjecutivo.SelectedValue, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
            llenarCbAsesores(Me.cbSucursal.SelectedValue)
        ElseIf tipoUsuario = 3 Then
            If Me.chkMostrarTodos.Checked = True Then
                llenarDg(1, "", sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
            Else
                llenarDg(4, cbSucursal.SelectedValue, cbEjecutivo.SelectedValue, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
            End If

        End If
    End Sub

    Private Sub frmMRutasMercadeo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        consultarAccesos()
        If tipoUsuario = 1 Then
            Me.cbSucursal.Enabled = False
        End If
        'llenarDg(1, "", "", Now, Now)
        Me.cbSucursal.DisplayMember = "Nom_Sucursal"
        Me.cbSucursal.ValueMember = "CodSucursal"
        LlenarCBSucursales("codSucursal,Nom_Sucursal", "", "Nom_Sucursal")
        llenarCbAsesores(sSucursal)
        If tipoUsuario = 1 Then
            Me.chkMostrarTodos.Enabled = False
            Me.cbEjecutivo.SelectedValue = sUsuario
            Me.cbEjecutivo.Enabled = False
            Me.cbSucursal.SelectedValue = sSucursal
            Me.cbSucursal.Enabled = False
            Me.dtpFechaIni.Enabled = True
            Me.dtpFechaFin.Enabled = True
        ElseIf tipoUsuario = 2 Then
            Me.chkMostrarTodos.Enabled = False
            Me.cbEjecutivo.Enabled = True
            Me.cbSucursal.SelectedValue = sSucursal
            Me.cbSucursal.Enabled = False
            Me.dtpFechaIni.Enabled = True
            Me.dtpFechaFin.Enabled = True
        ElseIf tipoUsuario = 3 Then
            Me.chkMostrarTodos.Enabled = True
            Me.cbSucursal.Enabled = True
            Me.cbEjecutivo.Enabled = True
            Me.dtpFechaIni.Enabled = True
            Me.dtpFechaFin.Enabled = True
        End If
        
    End Sub

    Private Sub dgRutas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRutas.CellClick
        If Me.dgRutas.Rows.Count > 0 Then
            If e.ColumnIndex > -1 Then
                If Me.dgRutas.Columns(e.ColumnIndex).Name = "revisado" Then
                    If Me.dgRutas.Item("Revisado", Me.dgRutas.CurrentRow.Index).Value = False Then
                        If tipoUsuario = 3 Then
                            If MsgBox("¿Ingresar revisión de ruta?", MsgBoxStyle.YesNo, "Rutas") = MsgBoxResult.Yes Then
                                Dim frm As New frmMsRutasMercadeo
                                With frm
                                    .accion = 4

                                    .lblEncabezado.Text = "Revisión de ruta"
                                    .idAccion = Me.dgRutas.Item("idActividad", Me.dgRutas.CurrentRow.Index).Value
                                    .idGestion = Me.dgRutas.Item("idTipoGestion", Me.dgRutas.CurrentRow.Index).Value
                                    .idRuta = Me.dgRutas.Item("idRuta", Me.dgRutas.CurrentRow.Index).Value
                                    .idVisitaRuta = Me.dgRutas.Item("idMercaRutaVisitas", Me.dgRutas.CurrentRow.Index).Value
                                    .codPagaduria = Me.dgRutas.Item("codPagaduria", Me.dgRutas.CurrentRow.Index).Value
                                    '.txtNombreCliente.Text = IIf(Me.dgRutas.Item("cliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("cliente", Me.dgRutas.CurrentRow.Index).Value)
                                    '.txtTel.Text = IIf(Me.dgRutas.Item("telCliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("telCliente", Me.dgRutas.CurrentRow.Index).Value)
                                    '.txtCorreo.Text = IIf(Me.dgRutas.Item("correoCliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("correoCliente", Me.dgRutas.CurrentRow.Index).Value)
                                    .txtNombreCliente.ReadOnly = True
                                    .cbLugarTrabajo.Enabled = False
                                    .txtTel.ReadOnly = True
                                    .txtCorreo.ReadOnly = True
                                    .dtpFechaVis.Enabled = False
                                    .cbProducto.Enabled = False
                                    .cbTipoEvento.Enabled = False
                                    .cbLugarTrabajo.Enabled = False
                                    .cbGestion.Enabled = False
                                    .ShowDialog(Me)
                                End With
                                If tipoUsuario = 1 Then
                                    llenarDg(3, "", sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                                ElseIf tipoUsuario = 2 Then
                                    llenarDg(4, Me.cbSucursal.SelectedValue, Me.cbEjecutivo.SelectedValue, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                                ElseIf tipoUsuario = 3 Then
                                    If Me.chkMostrarTodos.Checked = True Then
                                        llenarDg(1, "", sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                                    Else
                                        llenarDg(4, cbSucursal.SelectedValue, cbEjecutivo.SelectedValue, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                                    End If

                                End If
                            End If
                        ElseIf tipoUsuario = 2 And dgRutas.Item("usuario", Me.dgRutas.CurrentRow.Index).Value.ToString.Trim <> sUsuario.Trim Then
                            If MsgBox("¿Ingresar revisión de ruta?", MsgBoxStyle.YesNo, "Rutas") = MsgBoxResult.Yes Then
                                Dim frm As New frmMsRutasMercadeo
                                With frm
                                    .accion = 4
                                    .lblEncabezado.Text = "Revisión de ruta"
                                    .idAccion = Me.dgRutas.Item("idActividad", Me.dgRutas.CurrentRow.Index).Value
                                    .idGestion = Me.dgRutas.Item("idTipoGestion", Me.dgRutas.CurrentRow.Index).Value
                                    .idRuta = Me.dgRutas.Item("idRuta", Me.dgRutas.CurrentRow.Index).Value
                                    .idVisitaRuta = Me.dgRutas.Item("idMercaRutaVisitas", Me.dgRutas.CurrentRow.Index).Value
                                    .codPagaduria = Me.dgRutas.Item("codPagaduria", Me.dgRutas.CurrentRow.Index).Value
                                    .cbTipoEvento.Enabled = False
                                    .cbProducto.Enabled = False
                                    .cbGestion.Enabled = False
                                    '.txtNombreCliente.Text = IIf(Me.dgRutas.Item("cliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("cliente", Me.dgRutas.CurrentRow.Index).Value)
                                    '.txtTel.Text = IIf(Me.dgRutas.Item("telCliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("telCliente", Me.dgRutas.CurrentRow.Index).Value)
                                    '.txtCorreo.Text = IIf(Me.dgRutas.Item("correoCliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("correoCliente", Me.dgRutas.CurrentRow.Index).Value)
                                    .txtNombreCliente.ReadOnly = True
                                    .cbLugarTrabajo.Enabled = False
                                    .txtTel.ReadOnly = True
                                    .txtCorreo.ReadOnly = True
                                    .dtpFechaVis.Enabled = False
                                    .cbProducto.Enabled = False
                                    .cbTipoEvento.Enabled = False
                                    .cbLugarTrabajo.Enabled = False
                                    .ShowDialog(Me)
                                End With
                                If tipoUsuario = 1 Then
                                    llenarDg(3, "", sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                                ElseIf tipoUsuario = 2 Then
                                    llenarDg(4, Me.cbSucursal.SelectedValue, Me.cbEjecutivo.SelectedValue, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                                ElseIf tipoUsuario = 3 Then
                                    If Me.chkMostrarTodos.Checked = True Then
                                        llenarDg(1, "", sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                                    Else
                                        llenarDg(4, cbSucursal.SelectedValue, cbEjecutivo.SelectedValue, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                                    End If

                                End If
                            End If
                        End If

                    End If
                End If
            End If
        End If
       
    End Sub

    Public Sub LlenarCBSucursales(ByVal Campos As String, ByVal Filtro As String, ByVal Orden As String)
        Dim Dts As New DataSet
        Try

            Dts = rutas.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
            If Dts.Tables.Count > 0 Then
                If Dts.Tables(0).Rows.Count > 0 Then
                    Me.cbSucursal.DataSource = Dts.Tables(0)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Bóveda")
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim frm As New frmMsRutasMercadeo
        If Me.dgRutas.Item("idTipoGestion", Me.dgRutas.CurrentRow.Index).Value <> 7 Then
            With frm
                .accion = 2
                .lblEncabezado.Text = "Ingreso de Nueva Visita"
                .idAccion = Me.dgRutas.Item("idActividad", Me.dgRutas.CurrentRow.Index).Value
                .idGestion = Me.dgRutas.Item("idTipoGestion", Me.dgRutas.CurrentRow.Index).Value
                .idRuta = Me.dgRutas.Item("idRuta", Me.dgRutas.CurrentRow.Index).Value
                .cbTipoEvento.Enabled = False
                .cbProducto.Enabled = False
                '.codPagaduria = Me.dgRutas.Item("codPagaduria", Me.dgRutas.CurrentRow.Index).Value
                '.txtNombreCliente.Text = IIf(Me.dgRutas.Item("cliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("cliente", Me.dgRutas.CurrentRow.Index).Value)
                '.txtTel.Text = IIf(Me.dgRutas.Item("telCliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("telCliente", Me.dgRutas.CurrentRow.Index).Value)
                '.txtCorreo.Text = IIf(Me.dgRutas.Item("correoCliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("correoCliente", Me.dgRutas.CurrentRow.Index).Value)
                .txtNombreCliente.ReadOnly = True
                .cbLugarTrabajo.Enabled = False
                .txtTel.ReadOnly = True
                .txtCorreo.ReadOnly = True
                .txtDui.Enabled = False
                '.txtDui.Value = IIf(Me.dgRutas.Item("dui", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("dui", Me.dgRutas.CurrentRow.Index).Value)
                '.chkAsociado.Checked = IIf(Me.dgRutas.Item("asociado", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, False, Me.dgRutas.Item("asociado", Me.dgRutas.CurrentRow.Index).Value)
                .ShowDialog(Me)
            End With
            If tipoUsuario = 1 Then
                llenarDg(3, "", sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
            ElseIf tipoUsuario = 2 Then
                llenarDg(4, Me.cbSucursal.SelectedValue, Me.cbEjecutivo.SelectedValue, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
            ElseIf tipoUsuario = 3 Then
                If Me.chkMostrarTodos.Checked = True Then
                    llenarDg(1, "", sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                Else
                    llenarDg(4, cbSucursal.SelectedValue, cbEjecutivo.SelectedValue, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                End If
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If tipoUsuario = 1 Then
            llenarDg(3, "", sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
        ElseIf tipoUsuario = 2 Then
            llenarDg(4, Me.cbSucursal.SelectedValue, Me.cbEjecutivo.SelectedValue, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
        ElseIf tipoUsuario = 3 Then
            If Me.chkMostrarTodos.Checked = True Then
                llenarDg(1, "", sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
            Else
                llenarDg(4, cbSucursal.SelectedValue, cbEjecutivo.SelectedValue, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
            End If

        End If

    End Sub

    Private Sub dgRutas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRutas.CellDoubleClick
        If e.ColumnIndex > -1 Then
            Dim frm As New frmMsRutasMercadeo
            With frm
                .accion = 3
                .lblEncabezado.Text = "Rutas"
                .idAccion = Me.dgRutas.Item("idActividad", Me.dgRutas.CurrentRow.Index).Value
                .idGestion = Me.dgRutas.Item("idTipoGestion", Me.dgRutas.CurrentRow.Index).Value
                .idRuta = Me.dgRutas.Item("idRuta", Me.dgRutas.CurrentRow.Index).Value
                .codPagaduria = Me.dgRutas.Item("codPagaduria", Me.dgRutas.CurrentRow.Index).Value
                .txtNombreCliente.Text = IIf(Me.dgRutas.Item("cliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("cliente", Me.dgRutas.CurrentRow.Index).Value)
                .txtTel.Text = IIf(Me.dgRutas.Item("telCliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("telCliente", Me.dgRutas.CurrentRow.Index).Value)
                .txtCorreo.Text = IIf(Me.dgRutas.Item("correoCliente", Me.dgRutas.CurrentRow.Index).Value Is DBNull.Value, "", Me.dgRutas.Item("correoCliente", Me.dgRutas.CurrentRow.Index).Value)
                .txtNombreCliente.ReadOnly = True
                .cbLugarTrabajo.Enabled = False
                .txtTel.ReadOnly = True
                .txtCorreo.ReadOnly = True
                .txtObs.ReadOnly = True
                .cbProducto.Enabled = False
                .cbGestion.Enabled = False
                .btnGuardar.Enabled = False
                .dtpFechaVis.Enabled = False
                .txtDui.Enabled = False
                .cbTipoEvento.Enabled = False
                .ShowDialog(Me)
            End With
        End If
    End Sub

    Private Sub chkMostrarTodos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMostrarTodos.CheckedChanged
        If Me.chkMostrarTodos.Checked = True Then
            Me.cbSucursal.Enabled = False
            Me.cbEjecutivo.Enabled = False
        Else
            Me.cbSucursal.Enabled = True
            Me.cbEjecutivo.Enabled = True
        End If
    End Sub

    Private Sub cbSucursal_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSucursal.DropDownClosed
        llenarCbAsesores(Me.cbSucursal.SelectedValue)
    End Sub
End Class