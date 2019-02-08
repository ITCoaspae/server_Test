Public Class frmMCompras
    Dim contabilidad As New wrConta.wsLibContab
    Dim adminsitracion As New wrAdmin.wsLibAdmin
    Dim asociados As New wrAsociados.wsLibAsoc

    Protected Sub estiloDg()
        Me.dgCompras.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgCompras.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgCompras.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

        Me.dgCompras.Columns("noComprobante").HeaderText = "No. Comprobante"
        Me.dgCompras.Columns("exentas_locales").HeaderText = "Exentas Locales"
        Me.dgCompras.Columns("exentas_importaciones").HeaderText = "Exentas Importaciones"
        Me.dgCompras.Columns("exentas_internacionales").HeaderText = "Exentas Internacionales"
        Me.dgCompras.Columns("gravadas_locales").HeaderText = "Gravadas Locales"
        Me.dgCompras.Columns("gravadas_importaciones").HeaderText = "Gravadas Importaciones"
        Me.dgCompras.Columns("gravadas_internacionales").HeaderText = "Gravadas internacionales"
        Me.dgCompras.Columns("creditoFiscal").HeaderText = "Crédito Fiscal"
        Me.dgCompras.Columns("totalCompras").HeaderText = "Total"
        Me.dgCompras.Columns("retencionTerceros").HeaderText = "Retención a Terceros"
        Me.dgCompras.Columns("sujetosExcluidos").HeaderText = "Sujetos Excluidos"
        Me.dgCompras.Columns("usuario").HeaderText = "Usuario"
        Me.dgCompras.Columns("fechaActu").HeaderText = "Fecha de ultima Modificación"
        Me.dgCompras.Columns("observacion").HeaderText = "Observación"
        Me.dgCompras.Columns("gravadas_locales").HeaderText = "Gravadas Locales"
        Me.dgCompras.Columns("proveedor").HeaderText = "Nombre de Proveedor"


        Me.dgCompras.Columns("idCompra").Visible = False
        Me.dgCompras.Columns("codSucursal").Visible = False
        Me.dgCompras.Columns("idProveedor").Visible = False
        Me.dgCompras.Columns("idTipoDoc").Visible = False
        Me.dgCompras.Columns("tipoDocumento").Visible = True

    End Sub
    Protected Sub llenarDgCompras(ByVal opcion As Integer, ByVal fechaInicio As DateTime, _
                                  ByVal fechaFin As DateTime, ByVal codSucursal As String)
        Dim dts As New DataSet
        dts = contabilidad.consultarCaCompras(opcion, fechaInicio, fechaFin, codSucursal, sUsuario, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgCompras.DataSource = dts.Tables(0)
            Else
                MsgBox("La consulta no ha retornado ningun registro.", MsgBoxStyle.Critical, "Módulo - Compras")
            End If
        Else
            MsgBox("La consulta no ha retornado ningun registro.", MsgBoxStyle.Critical, "Módulo - Compras")
        End If
    End Sub
    Protected Sub buscar()
        Try
            If Me.rbMostrarTodos.Checked = True Then
                llenarDgCompras(1, Now, Now, "")

            ElseIf chkFecha.Checked = True And chkSucursal.Checked = False Then
                llenarDgCompras(2, _
                                Format(DateTimePicker1.Value, "Short Date"), _
                                Format(DateTimePicker2.Value, "Short Date"), _
                                "")
            ElseIf chkFecha.Checked = True And chkSucursal.Checked = True Then
                llenarDgCompras(3, _
                                Format(DateTimePicker1.Value, "Short Date"), _
                                Format(DateTimePicker2.Value, "Short Date"), _
                                cbSucursal.SelectedValue)
            End If
            estiloDg()
        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Protected Function validarMesCerrado(ByVal mes As Integer, ByVal annio As Integer, ByVal bloque As Integer) As Boolean
        Dim dts As New DataSet
        dts = contabilidad.consultarCaCompraCierreMes(mes, annio, 5, bloque)
        If dts.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If Me.chkFecha.Checked = True Then
            Me.rbMostrarTodos.Checked = False
        End If
    End Sub

    Private Sub chkSucursal_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSucursal.CheckedChanged
        If Me.chkFecha.Checked = True Then
            Me.rbMostrarTodos.Checked = False
        End If
    End Sub

    Private Sub frmMCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dtsRoles As New DataSet
        dtsRoles = adminsitracion.ConsultarRolesUsuario(sUsuario, "", 2)
        If dtsRoles.Tables.Count > 0 Then
            If dtsRoles.Tables(0).Rows.Count > 0 Then
                For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                    If adminsitracion.ConsultarPermisoProcesos("CTI004", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) = True Then
                        Me.chkSucursal.Enabled = False
                        Me.cbSucursal.Enabled = False
                        Exit For
                        Exit Sub
                    ElseIf adminsitracion.ConsultarPermisoProcesos("CTI005", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) = True Then
                        Dim dtsSucursales As New DataSet
                        dtsSucursales = asociados.ConsultarSucursales("codSucursal,Nom_Sucursal", "", "Nom_Sucursal", sUsuario, sSucursal, sPassword)
                        Me.cbSucursal.DisplayMember = "Nom_Sucursal"
                        Me.cbSucursal.ValueMember = "CodSucursal"
                        Me.cbSucursal.DataSource = dtsSucursales.Tables(0)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        buscar()
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        Try

            Dim frm As New frmMsCompras
            With frm
                .accion = 1
                .ShowDialog()
            End With
            buscar()
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMod1_Click(sender As Object, e As EventArgs) Handles btnMod1.Click
        Try
            If Me.dgCompras.CurrentRow.Index > -1 Then
                If validarMesCerrado(Month(Me.dgCompras.Item("fecha", Me.dgCompras.CurrentRow.Index).Value),
                                     Year(Me.dgCompras.Item("fecha", Me.dgCompras.CurrentRow.Index).Value),
                                     Me.dgCompras.Item("bloque", Me.dgCompras.CurrentRow.Index).Value) Then

                End If

                If Me.dgCompras.Item("anulado", Me.dgCompras.CurrentRow.Index).Value = True Then
                    MsgBox("Registro anulado, no se pueden realizar modificaciones.", MsgBoxStyle.Critical, "Módulo - Compras")
                Else
                    Dim frm As New frmMsCompras
                    With frm
                        .accion = 2
                        .idCompra = IIf(Me.dgCompras.Item("idCompra", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              "", Me.dgCompras.Item("idCompra", Me.dgCompras.CurrentRow.Index).Value)
                        .dtpFecha.Value = IIf(Me.dgCompras.Item("fecha", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              Now, Me.dgCompras.Item("fecha", Me.dgCompras.CurrentRow.Index).Value)
                        .txtNoComprobante.Text = IIf(Me.dgCompras.Item("noComprobante", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              "", Me.dgCompras.Item("noComprobante", Me.dgCompras.CurrentRow.Index).Value)
                        .txtCodProveedor.Text = IIf(Me.dgCompras.Item("idProveedor", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              "", Me.dgCompras.Item("idProveedor", Me.dgCompras.CurrentRow.Index).Value)
                        .txtNombreProveedor.Text = IIf(Me.dgCompras.Item("Proveedor", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              "", Me.dgCompras.Item("Proveedor", Me.dgCompras.CurrentRow.Index).Value)
                        .txtExLocales.Value = IIf(Me.dgCompras.Item("exentas_locales", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("exentas_locales", Me.dgCompras.CurrentRow.Index).Value)
                        .txtExImportaciones.Value = IIf(Me.dgCompras.Item("exentas_importaciones", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("exentas_importaciones", Me.dgCompras.CurrentRow.Index).Value)
                        .txtExInternacionales.Value = IIf(Me.dgCompras.Item("exentas_internacionales", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("exentas_internacionales", Me.dgCompras.CurrentRow.Index).Value)
                        .txtGraLocales.Value = IIf(Me.dgCompras.Item("gravadas_locales", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("gravadas_locales", Me.dgCompras.CurrentRow.Index).Value)
                        .txtGraImportaciones.Value = IIf(Me.dgCompras.Item("gravadas_Importaciones", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("gravadas_Importaciones", Me.dgCompras.CurrentRow.Index).Value)
                        .txtGravadasInternacionales.Value = IIf(Me.dgCompras.Item("gravadas_Internacionales", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("gravadas_Internacionales", Me.dgCompras.CurrentRow.Index).Value)
                        .txtCreditoFiscal.Value = IIf(Me.dgCompras.Item("CreditoFiscal", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("CreditoFiscal", Me.dgCompras.CurrentRow.Index).Value)
                        .txtRetTerceros.Value = IIf(Me.dgCompras.Item("retencionTerceros", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("retencionTerceros", Me.dgCompras.CurrentRow.Index).Value)
                        .txtExImpuesto.Value = IIf(Me.dgCompras.Item("sujetosExcluidos", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("sujetosExcluidos", Me.dgCompras.CurrentRow.Index).Value)
                        .txtTotal.Value = IIf(Me.dgCompras.Item("totalCompras", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("totalCompras", Me.dgCompras.CurrentRow.Index).Value)
                        .txtObservacion.Text = IIf(Me.dgCompras.Item("observacion", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("observacion", Me.dgCompras.CurrentRow.Index).Value)
                        .idTipoDoc = IIf(Me.dgCompras.Item("idTipoDoc", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("idTipoDoc", Me.dgCompras.CurrentRow.Index).Value)
                        .txtTipoDocumento.Text = IIf(Me.dgCompras.Item("tipoDocumento", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                              0, Me.dgCompras.Item("tipoDocumento", Me.dgCompras.CurrentRow.Index).Value)
                        .btnGuardar.Text = "Modificar"
                        .ShowDialog()
                    End With
                End If

                buscar()
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If Me.dgCompras.CurrentRow.Index > -1 Then
                Dim frm As New frmMsCompras
                With frm
                    .accion = 3
                    .dtpFecha.Value = IIf(Me.dgCompras.Item("fecha", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          Now, Me.dgCompras.Item("fecha", Me.dgCompras.CurrentRow.Index).Value)
                    .txtNoComprobante.Text = IIf(Me.dgCompras.Item("noComprobante", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          "", Me.dgCompras.Item("noComprobante", Me.dgCompras.CurrentRow.Index).Value)
                    .txtCodProveedor.Text = IIf(Me.dgCompras.Item("idProveedor", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          "", Me.dgCompras.Item("idProveedor", Me.dgCompras.CurrentRow.Index).Value)
                    .txtNombreProveedor.Text = IIf(Me.dgCompras.Item("Proveedor", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          "", Me.dgCompras.Item("Proveedor", Me.dgCompras.CurrentRow.Index).Value)
                    .txtExLocales.Value = IIf(Me.dgCompras.Item("exentas_locales", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("exentas_locales", Me.dgCompras.CurrentRow.Index).Value)
                    .txtExImportaciones.Value = IIf(Me.dgCompras.Item("exentas_importaciones", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("exentas_importaciones", Me.dgCompras.CurrentRow.Index).Value)
                    .txtExInternacionales.Value = IIf(Me.dgCompras.Item("exentas_internacionales", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("exentas_internacionales", Me.dgCompras.CurrentRow.Index).Value)
                    .txtGraLocales.Value = IIf(Me.dgCompras.Item("gravadas_locales", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("gravadas_locales", Me.dgCompras.CurrentRow.Index).Value)
                    .txtGraImportaciones.Value = IIf(Me.dgCompras.Item("gravadas_Importaciones", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("gravadas_Importaciones", Me.dgCompras.CurrentRow.Index).Value)
                    .txtGravadasInternacionales.Value = IIf(Me.dgCompras.Item("gravadas_Internacionales", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("gravadas_Internacionales", Me.dgCompras.CurrentRow.Index).Value)
                    .txtCreditoFiscal.Value = IIf(Me.dgCompras.Item("CreditoFiscal", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("CreditoFiscal", Me.dgCompras.CurrentRow.Index).Value)
                    .txtRetTerceros.Value = IIf(Me.dgCompras.Item("retencionTerceros", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("retencionTerceros", Me.dgCompras.CurrentRow.Index).Value)
                    .txtExImpuesto.Value = IIf(Me.dgCompras.Item("sujetosExcluidos", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("sujetosExcluidos", Me.dgCompras.CurrentRow.Index).Value)
                    .txtTotal.Value = IIf(Me.dgCompras.Item("totalCompras", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("totalCompras", Me.dgCompras.CurrentRow.Index).Value)
                    .txtObservacion.Text = IIf(Me.dgCompras.Item("observacion", Me.dgCompras.CurrentRow.Index).Value Is DBNull.Value,
                                          0, Me.dgCompras.Item("observacion", Me.dgCompras.CurrentRow.Index).Value)
                    .ShowDialog()
                    .btnGuardar.Enabled = False
                    .dtpFecha.Enabled = False
                    .txtNoComprobante.ReadOnly = True
                    .txtCodProveedor.ReadOnly = True
                    .txtNombreProveedor.ReadOnly = True
                    .txtExLocales.ReadOnly = True
                    .txtExImportaciones.ReadOnly = True
                    .txtExInternacionales.ReadOnly = True
                    .txtGraLocales.ReadOnly = True
                    .txtGraImportaciones.ReadOnly = True
                    .txtGravadasInternacionales.ReadOnly = True
                    .txtCreditoFiscal.ReadOnly = True
                    .txtRetTerceros.ReadOnly = True
                    .txtExImpuesto.ReadOnly = True
                    .txtTotal.ReadOnly = True
                    .txtObservacion.ReadOnly = True

                End With
                buscar()
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnAnular1_Click(sender As Object, e As EventArgs) Handles btnAnular1.Click
        Try
            If Me.dgCompras.CurrentRow.Index > -1 Then
                If MsgBox("¿Desea anular el registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Compras") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = contabilidad.anularCompra(Me.dgCompras.Item("idCompra", Me.dgCompras.CurrentRow.Index).Value, True, sUsuario, Now)
                    If resultado <> 0 Then
                        MsgBox("Registro anulado exitosamente.", MsgBoxStyle.Information, "Módulo - Compras")
                    Else
                        MsgBox("El registro no pudo ser anulado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Information, "Módulo - Compras")
                    End If
                End If
            End If
            buscar()
        Catch ex As Exception
            MsgBox("El registro no pudo ser anulado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Information, "Módulo - Compras")
        End Try
    End Sub
End Class