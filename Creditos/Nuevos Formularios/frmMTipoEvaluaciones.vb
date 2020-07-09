Public Class frmMTipoEvaluaciones
    Dim creditos As New wrCredito.wsLibCred
    Protected Sub estiloDg()
        Me.dgTipoEvaluaciones.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTipoEvaluaciones.Columns("Descripcion").HeaderText = "Descripción"
        Me.dgTipoEvaluaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgTipoEvaluaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgTipoEvaluaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

    End Sub


    Protected Sub llenarDgTipoEvaluaciones()
        Dim dts As New DataSet
        dts = creditos.consultarPrTipoEvaluaciones
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgTipoEvaluaciones.DataSource = dts.Tables(0)
                estiloDg()
            End If
        End If
    End Sub



    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMTipoEvaluaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDgTipoEvaluaciones()
    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try

            Dim frm As New frmMsTipoEvaluaciones
            With frm
                .accion = 1
                .Text = "Tipo de Evaluación"
                .ShowDialog()
            End With

            llenarDgTipoEvaluaciones()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.dgTipoEvaluaciones.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsTipoEmpresa
                With frm
                    .accion = 2
                    .Text = "Tipo de Evaluación"
                    .txtCodigo.Text = Me.dgTipoEvaluaciones.Item("idTipoEval", Me.dgTipoEvaluaciones.CurrentRow.Index).Value
                    .txtDescripcion.Text = Me.dgTipoEvaluaciones.Item("Descripcion", Me.dgTipoEvaluaciones.CurrentRow.Index).Value
                    .ShowDialog()
                End With
            End If
            llenarDgTipoEvaluaciones()
        Catch
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If Me.dgTipoEvaluaciones.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsTipoEmpresa
                With frm
                    .accion = 3
                    .Text = "Consultar Tipo de Evaluación"
                    .txtCodigo.Text = Me.dgTipoEvaluaciones.Item("idTipoEval", Me.dgTipoEvaluaciones.CurrentRow.Index).Value
                    .txtDescripcion.Text = Me.dgTipoEvaluaciones.Item("descripcion", Me.dgTipoEvaluaciones.CurrentRow.Index).Value
                    .txtDescripcion.ReadOnly = True
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
            If Me.dgTipoEvaluaciones.CurrentRow.Index >= 0 Then
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo - Créditos") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = creditos.eliminarPrTipoEvaluaciones(Me.dgTipoEvaluaciones.Item("idTipoEval", Me.dgTipoEvaluaciones.CurrentRow.Index).Value)
                    If resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                    Else
                        MsgBox("El registro no pudo ser eliminado por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Créditos")
                    End If
                End If
            End If
            llenarDgTipoEvaluaciones()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class