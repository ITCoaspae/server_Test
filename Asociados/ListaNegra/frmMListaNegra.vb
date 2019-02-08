Public Class frmMListaNegra
    Dim listaNegra As New wrAsociados.wsLibAsoc
    Protected Sub llenarDg(ByVal opcion As Integer)
        Try
            Dim dts As New DataSet
            dts = listaNegra.consultarListaNegra(opcion)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.dgListaNegra1.DataSource = dts.Tables(0)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Asociados")

        End Try
       
    End Sub



    Private Sub frmMListaNegra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDg(1)
    End Sub



    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As New frmMsListaNegra
            With frm
                .accion = 1
                .ShowDialog()
            End With
            llenarDg(1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Asociados")
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If Me.dgListaNegra1.RowCount > 0 Then

                Dim frm As New frmMsListaNegra
                With frm
                    .llenarCbNacionalidades()
                    .llenarCbEstado()
                    .idLista = Me.dgListaNegra1.Item("idLista", Me.dgListaNegra1.CurrentRow.Index).Value
                    .txtNomReport.Text = IIf(IsDBNull(Me.dgListaNegra1.Item("nombreReportado", Me.dgListaNegra1.CurrentRow.Index).Value), "", Me.dgListaNegra1.Item("nombreReportado", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .cbNacionalidad.SelectedValue = Me.dgListaNegra1.Item("codNacionalidad", Me.dgListaNegra1.CurrentRow.Index).Value
                    .txtInstReporta.Text = IIf(IsDBNull(Me.dgListaNegra1.Item("InstReporta", Me.dgListaNegra1.CurrentRow.Index).Value), "", Me.dgListaNegra1.Item("InstReporta", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .txtDuiA.Text = IIf(IsDBNull(Me.dgListaNegra1.Item("DUI", Me.dgListaNegra1.CurrentRow.Index).Value), "", Me.dgListaNegra1.Item("DUI", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .txtNit.Value = IIf(IsDBNull(Me.dgListaNegra1.Item("NIT", Me.dgListaNegra1.CurrentRow.Index).Value), "", dgListaNegra1.Item("NIT", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .txtNoPas.Text = IIf(IsDBNull(Me.dgListaNegra1.Item("NoPasaporte", Me.dgListaNegra1.CurrentRow.Index).Value), "", dgListaNegra1.Item("NoPasaporte", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .txtNoRes.Text = IIf(IsDBNull(Me.dgListaNegra1.Item("CarneResidente", Me.dgListaNegra1.CurrentRow.Index).Value), "", Me.dgListaNegra1.Item("CarneResidente", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .txtMotIngreso.Text = IIf(IsDBNull(Me.dgListaNegra1.Item("MotivoIngreso", Me.dgListaNegra1.CurrentRow.Index).Value), "", Me.dgListaNegra1.Item("MotivoIngreso", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .chkActivo.Checked = IIf(IsDBNull(Me.dgListaNegra1.Item("activo", Me.dgListaNegra1.CurrentRow.Index).Value), False, Me.dgListaNegra1.Item("activo", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .txtAlias.Text = IIf(IsDBNull(Me.dgListaNegra1.Item("Alias", Me.dgListaNegra1.CurrentRow.Index).Value), "", Me.dgListaNegra1.Item("Alias", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .txtNoOficio.Text = IIf(IsDBNull(Me.dgListaNegra1.Item("NoOficio", Me.dgListaNegra1.CurrentRow.Index).Value), "", Me.dgListaNegra1.Item("NoOficio", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .txtRefOficio.Text = IIf(IsDBNull(Me.dgListaNegra1.Item("ReferenciaOficio", Me.dgListaNegra1.CurrentRow.Index).Value), "", Me.dgListaNegra1.Item("ReferenciaOficio", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .txtInfComp.Text = IIf(IsDBNull(Me.dgListaNegra1.Item("InfComplementaria", Me.dgListaNegra1.CurrentRow.Index).Value), "", Me.dgListaNegra1.Item("InfComplementaria", Me.dgListaNegra1.CurrentRow.Index).Value)
                    .cbEstado.SelectedValue = Me.dgListaNegra1.Item("estado", Me.dgListaNegra1.CurrentRow.Index).Value
                    .chkActivo.Enabled = False
                    .accion = 2
                    .ShowDialog()
                End With
                llenarDg(1)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Asociados")
        End Try
    End Sub

    Private Sub btnEliminar2_Click(sender As Object, e As EventArgs) Handles btnEliminar2.Click
        Try
            If Me.dgListaNegra1.RowCount > 0 Then
                If Me.dgListaNegra1.Item("activo", Me.dgListaNegra1.CurrentRow.Index).Value = True Then
                    If MsgBox("¿Desea inactivar el registro?", MsgBoxStyle.YesNo, "Módulo - Asociados") = MsgBoxResult.Yes Then
                        If (listaNegra.cambiarEstadoListaNegra(sUsuario, Now, False, Me.dgListaNegra1.Item("idLista", Me.dgListaNegra1.CurrentRow.Index).Value)) > 0 Then
                            MsgBox("Registro inactivo", MsgBoxStyle.Information, "Módulo - Asociados")
                        Else
                            MsgBox("El registro no pudo ser modificado.", MsgBoxStyle.Critical, "Módulo - Asociados")
                        End If
                    End If
                End If
            End If
            llenarDg(1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Asociados")
        End Try
    End Sub

End Class