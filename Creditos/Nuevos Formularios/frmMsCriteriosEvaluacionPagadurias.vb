Public Class frmMsCriteriosEvaluacionPagadurias
    Dim creditos As New wrCredito.wsLibCred
    Public accion As Integer
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Public Sub llenarCbTipoEvaluaciones()
        Dim dts As New DataSet
        dts = creditos.consultarPrTipoEvaluaciones
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbTipoEvaluacion.DataSource = dts.Tables(0)
        End If
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Protected Sub limpiar()
        Me.txtCriterio.Text = ""
        Me.txtPorcentaje.Clear()
    End Sub
    Protected Function validaciones()
        If Me.txtCriterio.Text.Trim <> "" And Me.txtCriterio.Text.Trim.Length > 0 Then
            If Me.txtPorcentaje.Value > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False

        End If
    End Function

    Private Sub frmMsCriteriosEvaluacionPagadurias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.accion = 1 Then
            llenarCbTipoEvaluaciones()
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim resultado As Integer
            Dim msg As String
            If Me.accion = 1 Then
                If validaciones() = True Then
                    'Dim dts As New DataSet
                    'dts = creditos.consultarPrCriteriosEvaluacionPagadurias(2, 0, cbTipoEvaluacion.SelectedValue)
                    'If dts.Tables.Count > 0 Then
                    '    If dts.Tables(0).Rows.Count > 0 Then
                    '        Dim total As Double
                    '        total = IIf(dts.Tables(0).Rows(0).Item(0) Is DBNull.Value, 0, dts.Tables(0).Rows(0).Item(0))
                    '        If total + txtPorcentaje.Value > 100 Then
                    '            MsgBox("La sumatoria de los criterios de evaluación no puede superar el 100 %", MsgBoxStyle.Critical, "Módulo - Créditos")
                    '        Else
                    resultado = creditos.insertarPrCriteriosEvaluacionPagadurias(txtCriterio.Text.Trim, txtPorcentaje.Value, chkActivo.Checked, cbTipoEvaluacion.SelectedValue)
                    msg = "Registro ingresado exitosamente"
                    '    End If
                    'End If
                    '        End If
                End If

            ElseIf Me.accion = 2 Then
                If validaciones() = True Then
                    'Dim dts As New DataSet
                    'dts = creditos.consultarPrCriteriosEvaluacionPagadurias(3, txtCodigo.Text.Trim, cbTipoEvaluacion.SelectedValue)
                    'If dts.Tables.Count > 0 Then
                    '    If dts.Tables(0).Rows.Count > 0 Then
                    '        Dim total As Double
                    '        total = IIf(dts.Tables(0).Rows(0).Item(0) Is DBNull.Value, 0, dts.Tables(0).Rows(0).Item(0))
                    '        If total + txtPorcentaje.Value > 100 Then
                    '            MsgBox("La sumatoria de los criterios de evaluación no puede superar el 100 %", MsgBoxStyle.Critical, "Módulo - Créditos")
                    '        Else
                    resultado = creditos.modificarPrCriteriosEvaluacionPagadurias(txtCriterio.Text.Trim, txtPorcentaje.Value, chkActivo.Checked, txtCodigo.Text.Trim, 1, cbTipoEvaluacion.SelectedValue)
                    msg = "Registro modificado exitosamente"
                    '    End If
                    'End If
                    '        End If
                End If
            End If
            If resultado <> 0 Then
                MsgBox(msg, MsgBoxStyle.Information, "Módulo - Créditos")
            Else
                MsgBox("Error, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Créditos")
            End If
            limpiar()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class