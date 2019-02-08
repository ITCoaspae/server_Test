Public Class frmMRestriccionesEvaluaciones
    Dim creditos As New wrCredito.wsLibCred
    Protected Sub llenarDgCriterios()
        Dim dts As New DataSet
        dts = creditos.consultarPrRestriccionesCriterios(1, 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgRestricciones.DataSource = dts.Tables(0)
                estiloDg()
            End If
        End If
    End Sub
    Protected Sub estiloDg()
        Me.dgRestricciones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal

        Me.dgRestricciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgRestricciones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgRestricciones.Columns("CriterioPrincipal").HeaderText = "Criterio Principal"
        Me.dgRestricciones.Columns("CriterioPrincipal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub frmMRestriccionesEvaluaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDgCriterios()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try
            Dim frm As New frmMRestriccionesCriterios
            With frm
                .accion = 1
                .ShowDialog()
            End With
            llenarDgCriterios()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim frm As New frmMRestriccionesCriterios
            Dim dts As New DataSet
            dts = creditos.consultarPrDet_Restricciones(Me.dgRestricciones.Item("idRestriccion", Me.dgRestricciones.CurrentRow.Index).Value)
            With frm
                .accion = 2
                .llenarTipoEvaluaciones()
                .idRestriccion = Me.dgRestricciones.Item("idRestriccion", Me.dgRestricciones.CurrentRow.Index).Value
                .cbTipoEvaluacion.SelectedValue = Me.dgRestricciones.Item("idTipoEval", Me.dgRestricciones.CurrentRow.Index).Value
                .llenarCriteriosEvaluacion()
                .cbCriterioPrincipal.SelectedValue = Me.dgRestricciones.Item("codCriterio", Me.dgRestricciones.CurrentRow.Index).Value
                .cbCriterioPrincipal.Enabled = False
                .cbTipoEvaluacion.Enabled = False
                .dtsDet_Restric = dts
                .llenarDetRestricciones(dts)
                .ShowDialog()

            End With
            llenarDgCriterios()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim frm As New frmMRestriccionesCriterios
            Dim dts As New DataSet
            dts = creditos.consultarPrDet_Restricciones(Me.dgRestricciones.Item("idRestriccion", Me.dgRestricciones.CurrentRow.Index).Value)
            With frm
                .accion = 3
                .llenarTipoEvaluaciones()
                .idRestriccion = Me.dgRestricciones.Item("idRestriccion", Me.dgRestricciones.CurrentRow.Index).Value
                .cbTipoEvaluacion.SelectedValue = Me.dgRestricciones.Item("idTipoEval", Me.dgRestricciones.CurrentRow.Index).Value
                .llenarCriteriosEvaluacion()
                .cbCriterioPrincipal.SelectedValue = Me.dgRestricciones.Item("codCriterio", Me.dgRestricciones.CurrentRow.Index).Value
                .cbCriterioPrincipal.Enabled = False
                .cbTipoEvaluacion.Enabled = False
                .dtsDet_Restric = dts
                .llenarDetRestricciones(dts)

                .btnAgregar1.Visible = False
                .btnGuardar1.Visible = False
                .dgRestricciones.Enabled = False
                .ShowDialog()

            End With
            llenarDgCriterios()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If Me.dgRestricciones.CurrentRow.Index > -1 Then
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Créditos - Préstamos") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = creditos.eliminarPrRestricciones_Criterios_Pagadurias(Me.dgRestricciones.Item("idRestriccion", Me.dgRestricciones.CurrentRow.Index).Value)
                    If resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Créditos")
                        Me.dgRestricciones.Rows.RemoveAt(Me.dgRestricciones.CurrentRow.Index)
                    Else
                        MsgBox("Error, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "Módulo - Créditos")
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgRestricciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRestricciones.CellContentClick

    End Sub
End Class