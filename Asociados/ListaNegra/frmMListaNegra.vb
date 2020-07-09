Public Class frmMListaNegra
    Dim listaNegra As New wrAsociados.wsLibAsoc




    Private Sub frmMListaNegra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub



    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As New frmMsListaNegra
            With frm
                .accion = 1
                .ShowDialog()
            End With
            btnBuscar_Click(sender, e)
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
                btnBuscar_Click(sender, e)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Asociados")
        End Try
    End Sub

    Private Sub btnEliminar2_Click(sender As Object, e As EventArgs) Handles btnEliminar2.Click
        Try
            If Me.dgListaNegra1.RowCount > 0 Then
                If Me.dgListaNegra1.Item("activo", Me.dgListaNegra1.CurrentRow.Index).Value = True Then

                    If MetroFramework.MetroMessageBox.Show(Me, "Desea desactivar el registro seleccionado.", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        If (listaNegra.cambiarEstadoListaNegra(sUsuario, Now, False, Me.dgListaNegra1.Item("idLista", Me.dgListaNegra1.CurrentRow.Index).Value)) > 0 Then
                            MetroFramework.MetroMessageBox.Show(Me, "Registro desactivado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        End If
                    End If
                End If
            End If
            btnBuscar_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Asociados")
        End Try
    End Sub

    Private Sub frmMListaNegra_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dts As New DataSet
        Dim reportado As String = ""
        Dim institucion As String = ""
        Dim oficio As String = ""
        Dim opcion As Integer = 0
        If rbReportado.Checked = True Then
            reportado = txtNombre.Text.Trim
            txtInstitucion.Text = ""
            txtOficio.Text = ""
            opcion = 2
        ElseIf rbInstitucion.Checked = True Then
            txtNombre.Text = ""
            institucion = txtInstitucion.Text
            txtOficio.Text = ""
            opcion = 3
        ElseIf rbOficio.Checked = True Then
            txtNombre.Text = ""
            txtInstitucion.Text = ""
            oficio = txtOficio.Text
            opcion = 4
        ElseIf rbTodos.Checked = True Then
            txtNombre.Text = ""
            txtInstitucion.Text = ""
            txtOficio.Text = ""
            opcion = 1
        End If

        dts = listaNegra.consultarListaNegra(opcion, reportado, institucion, oficio)
        dgListaNegra1.DataSource = dts.Tables(0)
    End Sub


End Class