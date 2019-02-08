Public Class frmMTipoEmpresa
    Dim creditos As New wrCredito.wsLibCred
    Protected Sub estiloDg()
        Me.dgTipoEmpresa.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTipoEmpresa.Columns("descripcion").HeaderText = "Descripción"
        Me.dgTipoEmpresa.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgTipoEmpresa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgTipoEmpresa.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Protected Sub llenarDgTipoEmpresa()
        Dim dts As New DataSet
        dts = creditos.consultarPrTipoEmpresa
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgTipoEmpresa.DataSource = dts.Tables(0)
                estiloDg()
            End If
        End If
    End Sub

    Private Sub frmMTipoEmpresa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDgTipoEmpresa()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try

            Dim frm As New frmMsTipoEmpresa
            With frm
                .accion = 1
                .Text = "Agregar Tipo de Empresa"
                .ShowDialog()
            End With

            llenarDgTipoEmpresa()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.dgTipoEmpresa.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsTipoEmpresa
                With frm
                    .accion = 2
                    .Text = "Modificar Tipo de Empresa"
                    .txtCodigo.Text = Me.dgTipoEmpresa.Item("idTipoEmp", Me.dgTipoEmpresa.CurrentRow.Index).Value
                    .txtDescripcion.Text = Me.dgTipoEmpresa.Item("descripcion", Me.dgTipoEmpresa.CurrentRow.Index).Value
                    .ShowDialog()
                End With
            End If
            llenarDgTipoEmpresa()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If Me.dgTipoEmpresa.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsTipoEmpresa
                With frm
                    .accion = 3
                    .Text = "Consultar Tipo de Empresa"
                    .txtCodigo.Text = Me.dgTipoEmpresa.Item("idTipoEmp", Me.dgTipoEmpresa.CurrentRow.Index).Value
                    .txtDescripcion.Text = Me.dgTipoEmpresa.Item("descripcion", Me.dgTipoEmpresa.CurrentRow.Index).Value
                    .txtDescripcion.ReadOnly = True
                    .btnGuardar1.Visible = False
                    .txtCodigo.ReadOnly = True
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If Me.dgTipoEmpresa.CurrentRow.Index >= 0 Then
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo - Créditos") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = creditos.eliminarPrTipoEmpresa(Me.dgTipoEmpresa.Item("idTipoEmp", Me.dgTipoEmpresa.CurrentRow.Index).Value)
                    If resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                    Else
                        MsgBox("El registro no pudo ser eliminado por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Créditos")
                    End If
                End If
            End If
            llenarDgTipoEmpresa()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class