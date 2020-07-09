Public Class frmItemRubroDocumento
    Dim caja As New wrCaja.wsLibCaja
    Public Sub llenarDgRubros()
        Try
            Dim dts As New DataSet
            dts = caja.ObtenerListaItesmRubrosDocumentos(0, 0, 0, 0, 4)
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgRubros.DataSource = dts.Tables(0)
                dgRubros.Columns("CodItem").Visible = False
                dgRubros.Columns("IdRubro").Visible = False
                dgRubros.Columns("idTipoDoc").Visible = False
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As New frmDetItemRubroDocumento
            With frm
                .accion = 1
                .ShowDialog()
                .txtIdRubro.Enabled = False
            End With
            llenarDgRubros()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If dgRubros.CurrentRow.Index >= 0 Then
                If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                    Try
                        caja.ObtenerListaItesmRubrosDocumentos(dgRubros.Item("ID", Me.dgRubros.CurrentRow.Index).Value, 0, 0, 0, 3)
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information)
                        llenarDgRubros()
                    Catch ex As Exception
                        MsgBox("Registro no fue eliminado.", MsgBoxStyle.Critical)
                    End Try
                Else
                    MsgBox("Registro no fue eliminado.", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If dgRubros.CurrentRow.Index >= 0 Then
                Dim frm As New frmDetItemRubroDocumento
                With frm
                    .accion = 2
                    .idRubro = dgRubros.Item("ID", Me.dgRubros.CurrentRow.Index).Value
                    .txtIdRubro.Text = dgRubros.Item("ID", Me.dgRubros.CurrentRow.Index).Value
                    .txtIdRubro.Enabled = False
                    .cbItems.SelectedValue = dgRubros.Item("CodItem", Me.dgRubros.CurrentRow.Index).Value
                    .cbRubros.SelectedValue = dgRubros.Item("IdRubro", Me.dgRubros.CurrentRow.Index).Value
                    .cbTipoDocumento.SelectedValue = dgRubros.Item("idTipoDoc", Me.dgRubros.CurrentRow.Index).Value

                    .ShowDialog()
                End With
                llenarDgRubros()
            End If

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmItemRubroDocumento_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            llenarDgRubros()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmItemRubroDocumento_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class