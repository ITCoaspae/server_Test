Public Class frmMGiroEmpresa
    Dim creditos As New wrCredito.wsLibCred
    Protected Sub estiloDg()
        Me.dgGiro.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgGiro.Columns("descripcion").HeaderText = "Descripción"
        Me.dgGiro.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgGiro.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgGiro.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Protected Sub llenarDgGiroEmpresa()
        Dim dts As New DataSet
        dts = creditos.consultarPrGiroEmpresa(0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgGiro.DataSource = dts.Tables(0)
                estiloDg()
            End If
        End If
    End Sub
    Private Sub frmMGiroEmpresa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDgGiroEmpresa()
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try

            Dim frm As New frmMsGiroEmpresa
            With frm
                .accion = 1
                '.lblTitulo.Text = "Agregar Giro de Empresa"
                .ShowDialog()
            End With
            llenarDgGiroEmpresa()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.dgGiro.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsGiroEmpresa
                With frm
                    .accion = 2
                    .txtCodigo.Text = Me.dgGiro.Item("idGiroEmpresa", Me.dgGiro.CurrentRow.Index).Value
                    .txtDescripcion.Text = Me.dgGiro.Item("descripcion", Me.dgGiro.CurrentRow.Index).Value.ToString.Trim
                    '.lblTitulo.Text = "Modificar Giro de Empresa"
                    .ShowDialog()
                End With
                llenarDgGiroEmpresa()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If Me.dgGiro.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsGiroEmpresa
                With frm
                    .accion = 3
                    .txtCodigo.Text = Me.dgGiro.Item("idGiroEmpresa", Me.dgGiro.CurrentRow.Index).Value
                    .txtDescripcion.Text = Me.dgGiro.Item("descripcion", Me.dgGiro.CurrentRow.Index).Value.ToString.Trim
                    .txtDescripcion.ReadOnly = True
                    .btnGuardar1.Enabled = False
                    '.lblTitulo.Text = "Consultar Giro de Empresa"
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If Me.dgGiro.CurrentRow.Index >= 0 Then
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo - Créditos") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = creditos.eliminarPrGiroEmpresa(Me.dgGiro.Item("idGiroEmpresa", Me.dgGiro.CurrentRow.Index).Value)
                    If resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                    Else
                        MsgBox("El registro no pudo ser eliminado por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Créditos")
                    End If
                End If
            End If
            llenarDgGiroEmpresa()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class