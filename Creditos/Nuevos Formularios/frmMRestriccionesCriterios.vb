Public Class frmMRestriccionesCriterios
    Dim creditos As New wrCredito.wsLibCred
    Public accion As Integer
    Public dtsDet_Restric As DataSet
    Public idRestriccion As Integer
    Public Sub llenarDetRestricciones(ByVal dts As DataSet)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                For i As Integer = 1 To dts.Tables(0).Rows.Count
                    If i = 1 Then
                        Dim correlativoColumn As New DataGridViewTextBoxColumn
                        With correlativoColumn
                            .HeaderText = "N"
                            .Width = 50
                        End With
                        Me.dgRestricciones.Columns.Add(correlativoColumn)
                        Dim cbCriteriosColumn As New DataGridViewComboBoxColumn
                        With cbCriteriosColumn
                            .DisplayMember = "descripcion"
                            .ValueMember = "codCriterio"
                            .Name = "CriterioEvaluacion"
                            .FlatStyle = FlatStyle.Flat
                            .Width = 800
                            .DataSource = creditos.consultarPrCriteriosEvaluacionPagadurias(1, 0, Me.cbTipoEvaluacion.SelectedValue).Tables(0)


                        End With
                        Me.dgRestricciones.Columns.Add(cbCriteriosColumn)

                        Dim chkEnabledColumn As New DataGridViewCheckBoxColumn
                        With chkEnabledColumn
                            .Name = "Enabled"
                            .HeaderText = "Habilitar"
                        End With
                        Me.dgRestricciones.Columns.Add(chkEnabledColumn)

                        Dim btnEliminarColum As New DataGridViewButtonColumn
                        With btnEliminarColum
                            .UseColumnTextForButtonValue = True
                            .Name = "btnEliminar"
                            .HeaderText = "Eliminar Criterio"
                            .Text = "Eliminar"
                            .FlatStyle = FlatStyle.Flat
                            .DefaultCellStyle.ForeColor = Color.Black
                        End With
                        Me.dgRestricciones.Columns.Add(btnEliminarColum)

                        Me.dgRestricciones.Rows.Insert(0, (i).ToString)
                    Else
                        Me.dgRestricciones.Rows.Insert(i - 1, (i).ToString)
                    End If

                Next
                estiloDg()
                ' ''Me.dgRestricciones.Columns(1).Selected = True
                ' ''For j As Integer = 0 To dgRestricciones.Rows.Count - 1
                ' ''    Me.dgRestricciones.Item(1, j).Value = Me.dts.Tables(0).Rows(j).Item("codCriterio")
                ' ''    'Me.dgRestricciones.Rows(j).Cells(1).Value = Me.dts.Tables(0).Rows(j).Item("codCriterio")
                ' ''Next
                'For Each row As DataGridViewRow In dgRestricciones.Rows
                '    row.Cells("CriterioEvaluacion").Value = Me.dts.Tables(0).Rows(row.Index).Item("codCriterio")
                'Next
            End If
        End If

    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Protected Sub estiloDg()
        Me.dgRestricciones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgRestricciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgRestricciones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgRestricciones.Columns(0).Width = 50

    End Sub
    Public Sub llenarTipoEvaluaciones()
        Dim dts As New DataSet
        dts = creditos.consultarPrTipoEvaluaciones()
        Me.cbTipoEvaluacion.ValueMember = "idTipoEval"
        Me.cbTipoEvaluacion.DisplayMember = "Descripcion"
        Me.cbTipoEvaluacion.DataSource = dts.Tables(0)
    End Sub
    Public Sub llenarCriteriosEvaluacion()
        cbCriterioPrincipal.DataSource = Nothing
        Dim dts As New DataSet
        If accion = 1 Then
            dts = creditos.consultarPrCriteriosEvaluacionPagadurias(5, 0, Me.cbTipoEvaluacion.SelectedValue)
        Else
            dts = creditos.consultarPrCriteriosEvaluacionPagadurias(1, 0, Me.cbTipoEvaluacion.SelectedValue)
        End If

        Me.cbCriterioPrincipal.ValueMember = "codCriterio"
        Me.cbCriterioPrincipal.DisplayMember = "Descripcion"
        Me.cbCriterioPrincipal.DataSource = dts.Tables(0)
    End Sub
    Private Sub frmMRestriccionesCriterios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If accion = 1 Then
            llenarTipoEvaluaciones()
            llenarCriteriosEvaluacion()
        End If
    End Sub
    Private Sub cbTipoEvaluacion_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoEvaluacion.DropDown
        llenarCriteriosEvaluacion()
    End Sub
    Private Sub cbTipoEvaluacion_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoEvaluacion.DropDownClosed
        llenarCriteriosEvaluacion()
    End Sub
    Private Sub dgRestricciones_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRestricciones.CellContentClick
        If Me.dgRestricciones.Rows.Count > 0 Then
            If Me.dgRestricciones.Columns(e.ColumnIndex).Name = "btnEliminar" Then
                If Me.dgRestricciones.CurrentRow.Index = 0 Then
                    If Me.accion = 2 Then
                        Dim codCriterio As Integer
                        Dim idDetRestriccion As Integer
                        codCriterio = dgRestricciones.Item("CriterioEvaluacion", e.RowIndex).Value
                        For i As Integer = 0 To dtsDet_Restric.Tables(0).Rows.Count - 1
                            If codCriterio = dtsDet_Restric.Tables(0).Rows(i).Item("codCriterio") Then
                                idDetRestriccion = dtsDet_Restric.Tables(0).Rows(i).Item("idDetRestriccion")
                                Dim resultado As Integer
                                resultado = creditos.eliminarPrDet_Restricciones(idDetRestriccion)
                                If resultado <> 0 Then
                                    MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Créditos")
                                    Me.dgRestricciones.Rows.Clear()
                                    dgRestricciones.Columns.Clear()

                                Else
                                    MsgBox("Error, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "Módulo - Créditos")
                                End If
                                Exit For
                            End If
                        Next
                    Else
                        Me.dgRestricciones.Rows.Clear()
                        dgRestricciones.Columns.Clear()
                    End If
                Else
                    If Me.accion = 2 Then
                        Dim codCriterio As Integer
                        Dim idDetRestriccion As Integer
                        codCriterio = dgRestricciones.Item("CriterioEvaluacion", e.RowIndex).Value
                        For i As Integer = 0 To dtsDet_Restric.Tables(0).Rows.Count - 1
                            If codCriterio = dtsDet_Restric.Tables(0).Rows(i).Item("codCriterio") Then
                                idDetRestriccion = dtsDet_Restric.Tables(0).Rows(i).Item("idDetRestriccion")
                                Dim resultado As Integer
                                resultado = creditos.eliminarPrDet_Restricciones(idDetRestriccion)
                                If resultado <> 0 Then
                                    MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Créditos")
                                    Me.dgRestricciones.Rows.RemoveAt(Me.dgRestricciones.CurrentRow.Index)
                                Else
                                    MsgBox("Error, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "Módulo - Créditos")
                                End If
                                Exit For
                            End If
                        Next
                    Else
                        Me.dgRestricciones.Rows.RemoveAt(Me.dgRestricciones.CurrentRow.Index)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dgRestricciones_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgRestricciones.RowsAdded
        If accion = 2 Or accion = 3 Then
            Me.dgRestricciones.Item("CriterioEvaluacion", e.RowIndex).Value = dtsDet_Restric.Tables(0).Rows(e.RowIndex).Item("codCriterio")
            Me.dgRestricciones.Item("Enabled", e.RowIndex).Value = dtsDet_Restric.Tables(0).Rows(e.RowIndex).Item("habilitado")
        End If
    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try

            If dgRestricciones.Rows.Count = 0 Then
                Dim correlativoColumn As New DataGridViewTextBoxColumn
                With correlativoColumn
                    .HeaderText = "N"
                    .Width = 50
                End With
                Me.dgRestricciones.Columns.Add(correlativoColumn)
                Dim cbCriteriosColumn As New DataGridViewComboBoxColumn
                With cbCriteriosColumn
                    .DisplayMember = "descripcion"
                    .ValueMember = "codCriterio"
                    .Name = "CriterioEvaluacion"
                    .FlatStyle = FlatStyle.Flat
                    .Width = 800
                    .DataSource = creditos.consultarPrCriteriosEvaluacionPagadurias(6, 0, Me.cbTipoEvaluacion.SelectedValue).Tables(0)
                End With
                Me.dgRestricciones.Columns.Add(cbCriteriosColumn)

                Dim chkEnabledColumn As New DataGridViewCheckBoxColumn
                With chkEnabledColumn
                    .Name = "Enabled"
                    .HeaderText = "Habilitar"
                End With
                Me.dgRestricciones.Columns.Add(chkEnabledColumn)

                Dim btnEliminarColum As New DataGridViewButtonColumn
                With btnEliminarColum
                    .UseColumnTextForButtonValue = True
                    .Name = "btnEliminar"
                    .HeaderText = "Eliminar Criterio"
                    .Text = "Eliminar"
                    .FlatStyle = FlatStyle.Flat
                    .DefaultCellStyle.ForeColor = Color.Black
                End With
                Me.dgRestricciones.Columns.Add(btnEliminarColum)

                Me.dgRestricciones.Rows.Insert(0, (dgRestricciones.Rows.Count + 1).ToString)
            Else
                Me.dgRestricciones.Rows.Insert(dgRestricciones.Rows.Count, (dgRestricciones.Rows.Count + 1).ToString)
            End If


            estiloDg()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If accion = 1 Then
                If Me.dgRestricciones.Rows.Count > 0 Then
                    Dim dtsRestricciones As New DataSet
                    Dim drRestricciones As DataRow
                    Dim dtRestricciones As DataTable = New DataTable("restricciones")
                    dtRestricciones.Columns.Add("codCriterio", Type.GetType("System.Int32"))
                    dtRestricciones.Columns.Add("enable", Type.GetType("System.Boolean"))
                    For Each row As DataGridViewRow In dgRestricciones.Rows
                        drRestricciones = dtRestricciones.NewRow()
                        drRestricciones("codCriterio") = row.Cells("CriterioEvaluacion").Value
                        drRestricciones("enable") = IIf(row.Cells("Enabled").Value = True, True, False)
                        dtRestricciones.Rows.Add(drRestricciones)
                    Next
                    dtsRestricciones.Tables.Add(dtRestricciones)
                    If dtsRestricciones.Tables(0).Rows.Count > 0 Then
                        Dim resultado As Integer
                        resultado = creditos.IngresarRestricciones_CriteriosEvaluacion(Me.cbCriterioPrincipal.SelectedValue, dtsRestricciones)
                        If resultado <> 0 Then
                            MsgBox("Validaciones ingresadas exitosamente", MsgBoxStyle.Information, "Créditos - Prestamos")
                            Me.Close()
                        Else
                            MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador de Sistemas", MsgBoxStyle.Critical, "Créditos - Prestamos")
                        End If
                    End If
                Else
                    MsgBox("Debe ingresar criterios dependientes.", MsgBoxStyle.Critical, "Créditos - Prestamos")
                End If
            ElseIf accion = 2 Then
                If Me.dgRestricciones.Rows.Count > 0 Then
                    Dim dtsRestricciones As New DataSet
                    Dim drRestricciones As DataRow
                    Dim dtRestricciones As DataTable = New DataTable("restricciones")
                    dtRestricciones.Columns.Add("codCriterio", Type.GetType("System.Int32"))
                    dtRestricciones.Columns.Add("enable", Type.GetType("System.Boolean"))
                    For Each row As DataGridViewRow In dgRestricciones.Rows
                        drRestricciones = dtRestricciones.NewRow()
                        drRestricciones("codCriterio") = row.Cells("CriterioEvaluacion").Value
                        drRestricciones("enable") = IIf(row.Cells("Enabled").Value = True, True, False)
                        dtRestricciones.Rows.Add(drRestricciones)
                    Next
                    dtsRestricciones.Tables.Add(dtRestricciones)
                    If dtsRestricciones.Tables(0).Rows.Count > 0 Then
                        Dim resultado As Integer
                        resultado = creditos.modificarPrDetRestriccions(idRestriccion, dtsDet_Restric, dtsRestricciones)
                        If resultado <> 0 Then
                            MsgBox("Modificación realizada exitosamente", MsgBoxStyle.Information, "Créditos - Prestamos")
                            Me.Close()
                        Else
                            MsgBox("La modificación no pudo ser realizada, por favor comunicarse con el administrador de Sistemas", MsgBoxStyle.Critical, "Créditos - Prestamos")
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class