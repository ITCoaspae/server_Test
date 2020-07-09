Public Class frmMClasificacionPagaduria
    Dim creditos As New wrCredito.wsLibCred
    Protected Sub estiloDg()
        Me.dgClasificacion.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgClasificacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgClasificacion.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Protected Sub llenarDgClasificaciones()
        Dim dts As New DataSet
        dts = creditos.consultarPrCatClasificacionPagadurias(1, 0, 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgClasificacion.DataSource = dts.Tables(0)
                estiloDg()
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMClasificacionPagaduria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDgClasificaciones()
    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try
            Dim frm As New frmMsClasificacionPagaduria
            With frm
                .accion = 1
                .ShowDialog()
            End With
            llenarDgClasificaciones()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If dgClasificacion.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsClasificacionPagaduria
                With frm
                    .accion = 2
                    .llenarTipoEvaluaciones()
                    .txtCodigo.Text = Me.dgClasificacion.Item("idCategoria", Me.dgClasificacion.CurrentRow.Index).Value
                    .txtCategoria.Text = Me.dgClasificacion.Item("categoria", Me.dgClasificacion.CurrentRow.Index).Value
                    .txtDesde.Value = Me.dgClasificacion.Item("desde", Me.dgClasificacion.CurrentRow.Index).Value
                    .txtHasta.Value = Me.dgClasificacion.Item("hasta", Me.dgClasificacion.CurrentRow.Index).Value
                    .cbTipoEvaluaciones.SelectedValue = Me.dgClasificacion.Item("idTipoEval", Me.dgClasificacion.CurrentRow.Index).Value
                    .ShowDialog()
                End With
            End If
            llenarDgClasificaciones()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If dgClasificacion.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsClasificacionPagaduria
                With frm
                    .accion = 3
                    .llenarTipoEvaluaciones()
                    .txtCodigo.Text = Me.dgClasificacion.Item("idCategoria", Me.dgClasificacion.CurrentRow.Index).Value
                    .txtCategoria.Text = Me.dgClasificacion.Item("categoria", Me.dgClasificacion.CurrentRow.Index).Value
                    .txtDesde.Value = Me.dgClasificacion.Item("desde", Me.dgClasificacion.CurrentRow.Index).Value
                    .txtHasta.Value = Me.dgClasificacion.Item("hasta", Me.dgClasificacion.CurrentRow.Index).Value
                    .cbTipoEvaluaciones.SelectedValue = Me.dgClasificacion.Item("idTipoEval", Me.dgClasificacion.CurrentRow.Index).Value
                    .txtCategoria.ReadOnly = True
                    .cbTipoEvaluaciones.Enabled = False
                    .txtDesde.ReadOnly = True
                    .txtHasta.ReadOnly = True
                    .btnGuardar1.Visible = False
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If Me.dgClasificacion.CurrentRow.Index >= 0 Then
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Créditos") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = creditos.eliminarPrCatClasificacionPagadurias(Me.dgClasificacion.Item("idCategoria", Me.dgClasificacion.CurrentRow.Index).Value)
                    If resultado <> 0 Then
                        MsgBox("El registro fue eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Créditos")
                    Else
                        MsgBox("El registro no pudo ser eliminado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "Módulo - Créditos")
                    End If
                End If
            End If
            llenarDgClasificaciones()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class