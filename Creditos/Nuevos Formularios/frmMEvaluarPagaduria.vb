Public Class frmMEvaluarPagaduria
    Dim creditos As New wrCredito.wsLibCred
    Dim porcentaje As Integer
    Dim dtsPagadurias As New DataSet

    Dim dVista As DataView
    Protected Sub llenarCbTipoEvaluacion()
        Dim dts As New DataSet
        dts = creditos.consultarPrTipoEvaluaciones()
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbTipoEvaluacion.DataSource = dts.Tables(0)
        End If
    End Sub
    Protected Sub llenarPagadurias()
        'Dim dts As New DataSet
        dtsPagadurias = creditos.consultarPrPagadurias("", "", 4)
        If dtsPagadurias.Tables.Count > 0 Then
            If dtsPagadurias.Tables(0).Rows.Count > 0 Then
                Me.cbPagaduria.DataSource = dtsPagadurias.Tables(0)
            End If
        End If
    End Sub
    Protected Sub llenarCriterios()
        dgCriterios.Rows.Clear()
        dgCriterios.Columns.Clear()
        Dim dts As New DataSet
        dts = creditos.consultarPrCriteriosEvaluacionPagadurias(4, 0, cbTipoEvaluacion.SelectedValue)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgCriterios.DataSource = dts.Tables(0)
                Dim colEval As New DataGridViewCheckBoxColumn
                colEval.Name = "Evaluacion"
                colEval.HeaderText = "Evaluación"
                Me.dgCriterios.Columns.Add(colEval)
                estilodg()
                evaluarValidaciones()
            End If
        End If
    End Sub

    Private Sub frmMEvaluarPagaduria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbPagaduria.ValueMember = "CodPagaduria"
        Me.cbPagaduria.DisplayMember = "Pagaduria"
        llenarPagadurias()
        llenarCbTipoEvaluacion()
    End Sub


    Protected Sub estilodg()
        Me.dgCriterios.Columns("codCriterio").Visible = False
        Me.dgCriterios.Columns("descripcion").HeaderText = "Criterio de Evaluación"
        Me.dgCriterios.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCriterios.Columns("codCriterio").ReadOnly = True
        Me.dgCriterios.Columns("descripcion").ReadOnly = True
        Me.dgCriterios.Columns("porcentaje").ReadOnly = True
        Me.dgCriterios.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgCriterios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgCriterios.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgCriterios.Columns("descripcion").SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgCriterios.Columns("porcentaje").SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgCriterios.Columns("idTipoEval").SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgCriterios.Columns("TipoEvaluacion").SortMode = DataGridViewColumnSortMode.NotSortable
        Me.dgCriterios.Columns("Evaluacion").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

   


    Private Sub cbPagaduria_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPagaduria.DropDownClosed
        'dgCriterios.Rows.Clear()
        Dim dts As New DataSet
        Dim dtPagaduria As New DataTable
        dts = dtsPagadurias
        dtPagaduria = dts.Tables(0)
        dVista = New DataView(dtPagaduria)
        'dVista = dtPagaduria.DefaultView
        dVista.RowFilter = "CodPagaduria = '" & Me.cbPagaduria.SelectedValue & "'"
        Me.lblCategoria.Text = IIf(dVista(0)("Categoria") Is DBNull.Value, "Pendiente de evaluar", dVista(0)("Categoria"))
        dgCriterios.DataSource = Nothing
        dgCriterios.Rows.Clear()
        dgCriterios.Columns.Clear()
        'llenarCriterios()

    End Sub

   
    Protected Function obtenerCategoria(ByVal porcentaje As Double) As String
        Dim dts As New DataSet
        dts = creditos.consultarPrCatClasificacionPagadurias(2, porcentaje, cbTipoEvaluacion.SelectedValue)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Return dts.Tables(0).Rows(0).Item("categoria").ToString.Trim
            Else
                MsgBox("Error, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Créditos")
            End If
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub cbPagaduria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPagaduria.KeyDown
        Dim dts As New DataSet
        Dim dtPagaduria As New DataTable
        dts = dtsPagadurias
        dtPagaduria = dts.Tables(0)
        dVista = New DataView(dtPagaduria)
        'dVista = dtPagaduria.DefaultView
        dVista.RowFilter = "CodPagaduria = '" & Me.cbPagaduria.SelectedValue & "'"
        Me.lblCategoria.Text = IIf(dVista(0)("Categoria") Is DBNull.Value, "Pendiente de evaluar", dVista(0)("Categoria"))
        dgCriterios.DataSource = Nothing
        dgCriterios.Rows.Clear()
        dgCriterios.Columns.Clear()
        'llenarCriterios()


    End Sub

    'Private Sub cbPagaduria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbPagaduria.KeyPress
    '    Dim dts As New DataSet
    '    Dim dtPagaduria As New DataTable
    '    dts = dtsPagadurias
    '    dtPagaduria = dts.Tables(0)
    '    dVista = New DataView(dtPagaduria)
    '    'dVista = dtPagaduria.DefaultView
    '    dVista.RowFilter = "CodPagaduria = '" & Me.cbPagaduria.SelectedValue & "'"
    '    Me.lblCategoria.Text = IIf(dVista(0)("Categoria") Is DBNull.Value, "Pendiente de evaluar", dVista(0)("Categoria"))
    '    dgCriterios.DataSource = Nothing
    '    dgCriterios.Rows.Clear()
    '    dgCriterios.Columns.Clear()
    '    llenarCriterios()

    'End Sub
    Private Sub cbPagaduria_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPagaduria.KeyUp
        Dim dts As New DataSet
        Dim dtPagaduria As New DataTable
        dts = dtsPagadurias
        dtPagaduria = dts.Tables(0)
        dVista = New DataView(dtPagaduria)
        'dVista = dtPagaduria.DefaultView
        dVista.RowFilter = "CodPagaduria = '" & Me.cbPagaduria.SelectedValue & "'"
        Me.lblCategoria.Text = IIf(dVista(0)("Categoria") Is DBNull.Value, "Pendiente de evaluar", dVista(0)("Categoria"))
        dgCriterios.DataSource = Nothing
        dgCriterios.Rows.Clear()
        dgCriterios.Columns.Clear()
        'llenarCriterios()

    End Sub

   

    Private Sub cbPagaduria_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbPagaduria.MouseWheel
        Dim dts As New DataSet
        Dim dtPagaduria As New DataTable
        dts = dtsPagadurias
        dtPagaduria = dts.Tables(0)
        dVista = New DataView(dtPagaduria)
        'dVista = dtPagaduria.DefaultView
        dVista.RowFilter = "CodPagaduria = '" & Me.cbPagaduria.SelectedValue & "'"
        Me.lblCategoria.Text = IIf(dVista(0)("Categoria") Is DBNull.Value, "Pendiente de evaluar", dVista(0)("Categoria"))
        dgCriterios.DataSource = Nothing
        dgCriterios.Rows.Clear()
        dgCriterios.Columns.Clear()
        'llenarCriterios()

    End Sub

    Private Sub cbTipoEvaluacion_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoEvaluacion.DropDown
        Dim dts As New DataSet
        Dim dtPagaduria As New DataTable
        dts = dtsPagadurias
        dtPagaduria = dts.Tables(0)
        dVista = New DataView(dtPagaduria)
        'dVista = dtPagaduria.DefaultView
        dVista.RowFilter = "CodPagaduria = '" & Me.cbPagaduria.SelectedValue & "'"
        Me.lblCategoria.Text = IIf(dVista(0)("Categoria") Is DBNull.Value, "Pendiente de evaluar", dVista(0)("Categoria"))
        dgCriterios.DataSource = Nothing
        dgCriterios.Rows.Clear()
        dgCriterios.Columns.Clear()
        llenarCriterios()
    End Sub

    Private Sub cbTipoEvaluacion_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoEvaluacion.DropDownClosed
        Dim dts As New DataSet
        Dim dtPagaduria As New DataTable
        dts = dtsPagadurias
        dtPagaduria = dts.Tables(0)
        dVista = New DataView(dtPagaduria)
        'dVista = dtPagaduria.DefaultView
        dVista.RowFilter = "CodPagaduria = '" & Me.cbPagaduria.SelectedValue & "'"
        Me.lblCategoria.Text = IIf(dVista(0)("Categoria") Is DBNull.Value, "Pendiente de evaluar", dVista(0)("Categoria"))
        dgCriterios.DataSource = Nothing
        dgCriterios.Rows.Clear()
        dgCriterios.Columns.Clear()
        llenarCriterios()
    End Sub
    Protected Sub evaluarValidaciones()
        Dim dtsDependencias As New DataSet
        Dim dtsPrincipal As New DataSet
        Dim idRestriccion As Integer
        For i As Integer = 0 To dgCriterios.Rows.Count - 1
            'Consultamos si el criterio tiene alguna dependencia
            dtsPrincipal = creditos.consultarPrRestriccionesCriterios(2, Me.dgCriterios.Rows(i).Cells("codCriterio").Value)
            If dtsPrincipal.Tables.Count > 0 Then
                If dtsPrincipal.Tables(0).Rows.Count > 0 Then
                    idRestriccion = dtsPrincipal.Tables(0).Rows(0).Item(0)
                    If idRestriccion <> 0 Then
                        dtsDependencias = creditos.consultarPrDet_Restricciones(idRestriccion)
                        Dim criterioDependiente As Integer
                        For j As Integer = 0 To dtsDependencias.Tables(0).Rows.Count - 1
                            criterioDependiente = dtsDependencias.Tables(0).Rows(j).Item("codCriterio")
                            For k As Integer = 0 To dgCriterios.Rows.Count - 1
                                If Me.dgCriterios.Rows(k).Cells("codCriterio").Value = criterioDependiente Then
                                    If dtsDependencias.Tables(0).Rows(j).Item("habilitado") = True Then
                                        Me.dgCriterios.Rows(k).DefaultCellStyle.BackColor = Color.Black
                                        Me.dgCriterios.Rows(k).ReadOnly = True
                                        Me.dgCriterios.Rows(k).Cells(4).ReadOnly = True
                                        dgCriterios.Item("Evaluacion", k).ReadOnly = True
                                    Else
                                        'Me.dgCriterios.Rows(k).DefaultCellStyle.BackColor = Color.Black
                                        Me.dgCriterios.Rows(k).ReadOnly = False
                                    End If

                                End If
                            Next
                        Next
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub dgCriterios_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCriterios.CellContentClick
        If Me.dgCriterios.Rows.Count > 0 Then
            If Me.dgCriterios.Columns(e.ColumnIndex).Name = "Evaluacion" Then
                Dim dtsPrincipal As New DataSet
                Dim idRestriccion As Integer
                Dim dtsDependencias As New DataSet
                If Me.dgCriterios.Item("Evaluacion", Me.dgCriterios.CurrentRow.Index).Value = False Then
                    dtsPrincipal = creditos.consultarPrRestriccionesCriterios(2, Me.dgCriterios.Rows(e.RowIndex).Cells("codCriterio").Value)
                    If dtsPrincipal.Tables.Count > 0 Then
                        If dtsPrincipal.Tables(0).Rows.Count > 0 Then
                            idRestriccion = dtsPrincipal.Tables(0).Rows(0).Item(0)
                            If idRestriccion <> 0 Then
                                dtsDependencias = creditos.consultarPrDet_Restricciones(idRestriccion)
                                Dim criterioDependiente As Integer
                                For i As Integer = 0 To dtsDependencias.Tables(0).Rows.Count - 1
                                    criterioDependiente = dtsDependencias.Tables(0).Rows(i).Item("codCriterio")
                                    For k As Integer = 0 To dgCriterios.Rows.Count - 1
                                        If Me.dgCriterios.Rows(k).Cells("codCriterio").Value = criterioDependiente Then
                                            If dtsDependencias.Tables(0).Rows(i).Item("habilitado") = True Then
                                                Me.dgCriterios.Rows(k).DefaultCellStyle.BackColor = Color.WhiteSmoke
                                                Me.dgCriterios.Rows(k).ReadOnly = False
                                            ElseIf dtsDependencias.Tables(0).Rows(i).Item("habilitado") = False Then
                                                Me.dgCriterios.Rows(k).DefaultCellStyle.BackColor = Color.Black
                                                Me.dgCriterios.Rows(k).ReadOnly = True
                                            End If
                                        End If
                                        
                                    Next
                                Next
                            End If
                        End If
                    End If
                    If Me.dgCriterios.Rows(e.RowIndex).DefaultCellStyle.BackColor <> Color.Black Then
                        Me.dgCriterios.Item("Evaluacion", Me.dgCriterios.CurrentRow.Index).Value = True
                        porcentaje = porcentaje + dgCriterios.Item("porcentaje", Me.dgCriterios.CurrentRow.Index).Value
                        Me.lblPorcentaje.Text = porcentaje
                    End If
                   
                Else
                    dtsPrincipal = creditos.consultarPrRestriccionesCriterios(2, Me.dgCriterios.Rows(e.RowIndex).Cells("codCriterio").Value)
                    If dtsPrincipal.Tables.Count > 0 Then
                        If dtsPrincipal.Tables(0).Rows.Count > 0 Then
                            idRestriccion = dtsPrincipal.Tables(0).Rows(0).Item(0)
                            If idRestriccion <> 0 Then
                                dtsDependencias = creditos.consultarPrDet_Restricciones(idRestriccion)
                                Dim criterioDependiente As Integer
                                For i As Integer = 0 To dtsDependencias.Tables(0).Rows.Count - 1
                                    criterioDependiente = dtsDependencias.Tables(0).Rows(i).Item("codCriterio")
                                    For k As Integer = 0 To dgCriterios.Rows.Count - 1
                                        If Me.dgCriterios.Rows(k).Cells("codCriterio").Value = criterioDependiente Then
                                            If dtsDependencias.Tables(0).Rows(i).Item("habilitado") = False Then
                                                Me.dgCriterios.Rows(k).DefaultCellStyle.BackColor = Color.WhiteSmoke
                                                Me.dgCriterios.Rows(k).ReadOnly = False
                                            ElseIf dtsDependencias.Tables(0).Rows(i).Item("habilitado") = True Then
                                                Me.dgCriterios.Rows(k).DefaultCellStyle.BackColor = Color.Black
                                                Me.dgCriterios.Rows(k).ReadOnly = True
                                            End If
                                        End If
                                    Next
                                Next
                            End If
                        End If
                    End If
                    Me.dgCriterios.Item("Evaluacion", Me.dgCriterios.CurrentRow.Index).Value = False
                    porcentaje = porcentaje - dgCriterios.Item("porcentaje", Me.dgCriterios.CurrentRow.Index).Value
                    Me.lblPorcentaje.Text = porcentaje
                End If
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Try
            Dim categoria As String
            Dim dtsEvaluacion As New DataSet
            Dim dr As DataRow
            Dim resultado As Integer
            categoria = obtenerCategoria(lblPorcentaje.Text)
            If MsgBox("¿Desea almacenar la evaluación de la Pagaduría: '" &
                      Me.cbPagaduria.Text.Trim & "', Categoria: '" & categoria &
                      "'?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then

                Dim dtEvaluacion As DataTable = New DataTable("evaluacion")
                dtEvaluacion.Columns.Add("codCriterio", Type.GetType("System.Int32"))
                dtEvaluacion.Columns.Add("porcentaje", Type.GetType("System.Double"))
                For Each row As DataGridViewRow In dgCriterios.Rows
                    dr = dtEvaluacion.NewRow()
                    dr("codCriterio") = row.Cells("codCriterio").Value
                    dr("porcentaje") = IIf(row.Cells("Evaluacion").Value = True, row.Cells("porcentaje").Value, 0)
                    dtEvaluacion.Rows.Add(dr)
                Next
                dtsEvaluacion.Tables.Add(dtEvaluacion)
                If dtsEvaluacion.Tables.Count > 0 Then
                    If dtsEvaluacion.Tables(0).Rows.Count > 0 Then
                        resultado = creditos.ingresarEvaluacionPagaduria(Me.cbPagaduria.SelectedValue, CDbl(lblPorcentaje.Text),
                                                                         categoria, Now, sUsuario, dtsEvaluacion, cbTipoEvaluacion.SelectedValue)
                        If resultado <> 0 Then
                            MsgBox("Evaluación realizada Exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                            Me.lblPorcentaje.Text = ""
                            Me.lblCategoria.Text = ""
                            porcentaje = 0
                            For Each row As DataGridViewRow In dgCriterios.Rows
                                row.Cells("Evaluacion").Value = False
                            Next
                            llenarPagadurias()
                        Else
                            MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Créditos")
                        End If
                    End If
                End If
            Else
                MsgBox("Accion cancelada por el Usuario '" & sUsuario & "'", MsgBoxStyle.Information, "Módulo - Créditos")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
