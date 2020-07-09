Public Class frmMCriteriosEvaluacionPagadurias
    Dim creditos As New wrCredito.wsLibCred
    Protected Sub estiloDg()
        dgCriterios.Columns("descripcion").HeaderText = "Criterio"
        dgCriterios.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCriterios.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
        Me.dgCriterios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgCriterios.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Protected Sub llenarDgCriterios(ByVal idTipoEval As Integer)
        Dim dts As New DataSet
        dts = creditos.consultarPrCriteriosEvaluacionPagadurias(1, 0, idTipoEval)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgCriterios.DataSource = dts.Tables(0)
                estiloDg()
            End If
        End If
    End Sub

    Private Sub frmMCriteriosEvaluacionPagadurias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarCbTipoEvaluacion()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Protected Sub llenarCbTipoEvaluacion()
        Dim dts As New DataSet
        dts = creditos.consultarPrTipoEvaluaciones()
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbTipoEvaluacion.DataSource = dts.Tables(0)
        End If
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Try
            Me.dgCriterios.DataSource = Nothing

            llenarDgCriterios(Me.cbTipoEvaluacion.SelectedValue)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try
            Dim frm As New frmMsCriteriosEvaluacionPagadurias
            With frm
                .accion = 1
                .ShowDialog()
            End With
            llenarDgCriterios(Me.cbTipoEvaluacion.SelectedValue)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If dgCriterios.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsCriteriosEvaluacionPagadurias
                With frm
                    .accion = 2
                    .txtCodigo.Text = Me.dgCriterios.Item("codCriterio", Me.dgCriterios.CurrentRow.Index).Value
                    .txtCriterio.Text = Me.dgCriterios.Item("descripcion", Me.dgCriterios.CurrentRow.Index).Value
                    .txtPorcentaje.Value = Me.dgCriterios.Item("porcentaje", Me.dgCriterios.CurrentRow.Index).Value
                    .chkActivo.Checked = Me.dgCriterios.Item("activo", Me.dgCriterios.CurrentRow.Index).Value
                    .llenarCbTipoEvaluaciones()
                    .cbTipoEvaluacion.SelectedValue = Me.dgCriterios.Item("idTipoEval", Me.dgCriterios.CurrentRow.Index).Value
                    .ShowDialog()
                End With
                llenarDgCriterios(Me.cbTipoEvaluacion.SelectedValue)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If dgCriterios.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsCriteriosEvaluacionPagadurias
                With frm
                    .accion = 3
                    .txtCodigo.Text = Me.dgCriterios.Item("codCriterio", Me.dgCriterios.CurrentRow.Index).Value
                    .txtCriterio.Text = Me.dgCriterios.Item("descripcion", Me.dgCriterios.CurrentRow.Index).Value
                    .txtPorcentaje.Value = Me.dgCriterios.Item("porcentaje", Me.dgCriterios.CurrentRow.Index).Value
                    .chkActivo.Checked = Me.dgCriterios.Item("activo", Me.dgCriterios.CurrentRow.Index).Value
                    .llenarCbTipoEvaluaciones()
                    .cbTipoEvaluacion.SelectedValue = Me.dgCriterios.Item("idTipoEval", Me.dgCriterios.CurrentRow.Index).Value
                    .txtPorcentaje.ReadOnly = True
                    .txtCodigo.ReadOnly = True
                    .txtCriterio.ReadOnly = True
                    .chkActivo.Enabled = False
                    .cbTipoEvaluacion.Enabled = False
                    .btnGuardar1.Visible = False
                    .ShowDialog()
                End With
                llenarDgCriterios(Me.cbTipoEvaluacion.SelectedValue)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If dgCriterios.CurrentRow.Index >= 0 Then
                If MsgBox("¿Desea desactivar el criterio de evaluación?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo - Créditos") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = creditos.modificarPrCriteriosEvaluacionPagadurias("", 0, False, Me.dgCriterios.Item("codCriterio", Me.dgCriterios.CurrentRow.Index).Value, 2, 0)
                    If resultado <> 0 Then
                        MsgBox("El registro fue eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Créditos")
                        llenarDgCriterios(Me.cbTipoEvaluacion.SelectedValue)
                    Else
                        MsgBox("El registro no pudo ser eliminado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "Módulo - Créditos")
                    End If

                End If

            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class