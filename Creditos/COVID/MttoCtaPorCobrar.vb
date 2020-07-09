Public Class MttoCtaPorCobrar
    Private asociados As New wrAsociados.wsLibAsoc
    Private contabilidad As New wrConta.wsLibContab
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New detCtaPorCobrar
        With frm
            .accion = 1
            .ShowDialog()
        End With
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim dts As New DataSet
        Dim opcion As Integer
        If rbDUI.Checked = True Then
            opcion = 2
        Else
            opcion = 1
        End If
        dts = contabilidad.consultarCuentaPorCobrar(txtDui.Text, opcion, Now, Now, "", 0)
        Me.DataGridView1.DataSource = dts.Tables(0)
        formatoGrid()
    End Sub
    Protected Sub formatoGrid()
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub rbDUI_CheckedChanged(sender As Object, e As EventArgs) Handles rbDUI.CheckedChanged
        If rbDUI.Checked = True Then
            txtDui.Enabled = True
            txtDui.Focus()
        End If

    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        If rbTodos.Checked = True Then
            txtDui.Enabled = False
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.DataGridView1.CurrentRow.Index >= 0 Then
            Dim frm As New detCtaPorCobrar
            Dim fila As Integer
            fila = DataGridView1.CurrentRow.Index
            With frm
                .accion = 3
                .idCxC = Me.DataGridView1.Item(0, fila).Value
                .txtDui.Text = Me.DataGridView1.Item("dui", fila).Value
                .txtNombre.Text = Me.DataGridView1.Item("Asociado", fila).Value
                .txtMonto.Text = Me.DataGridView1.Item("monto", fila).Value
                .txtSaldo.Text = Me.DataGridView1.Item("saldo", fila).Value
                .TextBox3.Text = Me.DataGridView1.Item("idDocOrigen", fila).Value
                .llenarTipoCtaOrigen()
                .cbTipoCtaOrigen.SelectedValue = DataGridView1.Item("Origen", fila).Value
                .cbTipoCtaOrigen_Validated(sender, e)
                .cbCuentas.SelectedValue = DataGridView1.Item("ctaOrigen", fila).Value
                .llenarSucrsales()
                .cbSucursal.SelectedValue = DataGridView1.Item("centrocosto", fila).Value
                .txtDui.Enabled = False
                .txtNombre.Enabled = False
                .txtMonto.Enabled = False
                .txtSaldo.Enabled = False
                .TextBox3.Enabled = False
                .cbTipoCtaOrigen.Enabled = False
                .cbCuentas.Enabled = False
                .cbSucursal.Enabled = False
                .btnGuardar.Enabled = False
                .ShowDialog()
            End With

        End If
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try
            If Me.DataGridView1.CurrentRow.Index >= 0 Then
                Dim fila, idCtaPorCobrar, resultado As Integer
                fila = DataGridView1.CurrentRow.Index
                idCtaPorCobrar = Me.DataGridView1.Item("IdCtaPorCobrar", fila).Value
                If Me.DataGridView1.Item("Activo", fila).Value = True Then

                    If MetroFramework.MetroMessageBox.Show(Me, "Desea anular la cuenta por cobrar No. " & idCtaPorCobrar.ToString, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                        resultado = contabilidad.anularCuentaPorCobrar(idCtaPorCobrar, sUsuario)
                        If resultado > 0 Then
                            MetroFramework.MetroMessageBox.Show(Me, "Registro anulado exitosamente", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        Else
                            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "El registro ya se encuentra anulado", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            End If
            Call btnMostrar_Click(sender, e)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub
End Class