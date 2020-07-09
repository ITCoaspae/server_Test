Public Class frmRubros
    Dim caja As New wrCaja.wsLibCaja
    Public Sub llenarDgRubros()
        Try
            Dim dts As New DataSet
            dts = caja.ObtenerListaRubros("idRubro,descripcion", "", sUsuario, sPassword, sSucursal)
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgRubros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                Me.dgRubros.ColumnHeadersHeight = 100
                Me.dgRubros.DataSource = dts.Tables(0)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As New frmDetRubros
            With frm
                .accion = 1
                .ShowDialog()
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
                    If (caja.eliminarCaRubro(dgRubros.Item("idRubro", Me.dgRubros.CurrentRow.Index).Value, sUsuario, sPassword, sSucursal)) = True Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information)
                        llenarDgRubros()
                    Else
                        MsgBox("Registro no fue eliminado.", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If dgRubros.CurrentRow.Index >= 0 Then
                Dim frm As New frmDetRubros
                With frm
                    .accion = 2
                    .idRubro = dgRubros.Item("idRubro", Me.dgRubros.CurrentRow.Index).Value
                    .txtIdRubro.Text = dgRubros.Item("idRubro", Me.dgRubros.CurrentRow.Index).Value
                    '.txtCodItem.Text = IIf(dgRubros.Item("codItem", dgRubros.CurrentRow.Index).Value Is DBNull.Value, "", dgRubros.Item("codItem", dgRubros.CurrentRow.Index).Value Is DBNull.Value)

                    '.recuperarDescripcionItem(IIf(dgRubros.Item("codItem", dgRubros.CurrentRow.Index).Value Is DBNull.Value, "", dgRubros.Item("codItem", dgRubros.CurrentRow.Index).Value Is DBNull.Value))
                    .txtIdRubro.Enabled = False
                    .txtRubro.Text = dgRubros.Item("descripcion", Me.dgRubros.CurrentRow.Index).Value.ToString.ToUpper
                    .ShowDialog()
                End With
                llenarDgRubros()
            End If

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRubros_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            llenarDgRubros()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class