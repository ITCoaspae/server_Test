Public Class CasosCovid
    Dim asociados As New wrAsociados.wsLibAsoc

    Private Sub rbCodPrestamo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodPrestamo.CheckedChanged
        If rbCodPrestamo.Checked = True Then
            txtCodPrestamo.Enabled = True
            txtDui.Enabled = False
            txtDui.Clear()
            dtpFechaIni.Enabled = False
            dtpFechaFin.Enabled = False
        End If
    End Sub

    Private Sub rbDUI_CheckedChanged(sender As Object, e As EventArgs) Handles rbDUI.CheckedChanged
        If rbDUI.Checked = True Then
            txtCodPrestamo.Enabled = False
            txtCodPrestamo.Text = ""
            txtDui.Enabled = True
            dtpFechaIni.Enabled = False
            dtpFechaFin.Enabled = False
        End If
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        If rbFecha.Checked = True Then
            txtCodPrestamo.Enabled = False
            txtCodPrestamo.Text = ""
            txtDui.Enabled = False
            txtDui.Clear()
            dtpFechaIni.Enabled = True
            dtpFechaFin.Enabled = True
        End If
    End Sub

    Private Sub rbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        txtCodPrestamo.Enabled = False
        txtCodPrestamo.Text = ""
        txtDui.Enabled = False
        txtDui.Clear()
        dtpFechaIni.Enabled = False
        dtpFechaFin.Enabled = False
    End Sub
    Protected Sub formatoGrid()
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim dts As New DataSet
        Dim opcion As Integer = 0
        Dim prestamo As String = " "
        Dim dui As String = " "

        'Opciones: 1 Todos, 2 Prestamo, 3 Dui, 4 Fecha
        If rbTodos.Checked = True Then
            opcion = 1
        ElseIf rbDUI.Checked = True Then
            dui = txtDui.Text
            opcion = 3
        ElseIf rbCodPrestamo.Checked = True Then
            prestamo = txtCodPrestamo.Text.Trim
            opcion = 2
        ElseIf rbFecha.Checked = True Then
            opcion = 4
        End If
        dts = asociados.consultarCasosCovid(prestamo, dtpFechaIni.Value.ToShortDateString, dtpFechaFin.Value.ToShortDateString, dui, opcion)
        If dts.Tables.Count > 0 Then
            Me.DataGridView1.DataSource = dts.Tables(0)
            formatoGrid()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New CasosCovidDet
        With frm
            .accion = 1
            .ShowDialog()
        End With

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If DataGridView1.Item("activo", DataGridView1.CurrentRow.Index).Value = True Then
                Dim frm As New CasosCovidDet
                With frm
                    .accion = 2
                    .id = Me.DataGridView1.Item("id", Me.DataGridView1.CurrentRow.Index).Value
                    .txtDui.Text = DataGridView1.Item("dui", DataGridView1.CurrentRow.Index).Value
                    .recuperarPrestamo()
                    .cbPrestamo.SelectedValue = DataGridView1.Item("codPrestamo", DataGridView1.CurrentRow.Index).Value
                    .dtpFechaIni.Value = DataGridView1.Item("FechaIniSuspension", DataGridView1.CurrentRow.Index).Value
                    .dtpFechaFin.Value = DataGridView1.Item("FechaFinSuspension", DataGridView1.CurrentRow.Index).Value
                    .txtNombre.Text = DataGridView1.Item("Asociado", DataGridView1.CurrentRow.Index).Value.ToString.ToUpper
                    .ShowDialog()
                End With
            Else
                MetroFramework.MetroMessageBox.Show(Me, "El registro se encuentra anulado, no se pueden realizar modificaciones.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            Call btnMostrar_Click(sender, e)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try
            If DataGridView1.Item("activo", DataGridView1.CurrentRow.Index).Value = True Then
                If (MetroFramework.MetroMessageBox.Show(Me, "¿Desea anular el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) = DialogResult.Yes Then
                    If asociados.IngresarActualizarCasosCovid(" ", Now, Now, "", Now, sUsuario, Now, False, Me.DataGridView1.Item("id", Me.DataGridView1.CurrentRow.Index).Value, 3) > 0 Then
                        MetroFramework.MetroMessageBox.Show(Me, "Registro anulado", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    End If
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "El registro ya se encuentra anulado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Call btnMostrar_Click(sender, e)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class