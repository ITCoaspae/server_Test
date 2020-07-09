Public Class frmAnulacionTransferencia
    Dim ahorro As New wrAhorro.wsLibAhorro
    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        If rbFecha.Checked = True Then
            dtpFechaFin.Enabled = True
            dtpFechaIni.Enabled = True
            txtResponsable.Enabled = False
        Else
            dtpFechaFin.Enabled = False
            dtpFechaIni.Enabled = False
        End If
    End Sub

    Private Sub rbResponsable_CheckedChanged(sender As Object, e As EventArgs) Handles rbResponsable.CheckedChanged
        If rbResponsable.Checked = True Then
            txtResponsable.Enabled = True
            dtpFechaFin.Enabled = False
            dtpFechaIni.Enabled = False
        Else
            txtResponsable.Enabled = False
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim dts As New DataSet
            Dim filtro As String = ""

            If rbFecha.Checked = True Then
                filtro = " a.Fecha >= '" & dtpFechaIni.Value.ToShortDateString & "' and a.fecha <= '" & dtpFechaFin.Value.ToShortDateString & "'"
            ElseIf rbResponsable.Checked = True Then
                filtro = " a.responsable like '%" & txtResponsable.Text.Trim & "%' "
            End If
            dts = ahorro.ConsultarTransferencia("distinct a.CodTransferencia,a.Fecha,a.NoDocumento,a.NoSocio,a.Dui,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 as Nombres,ValorTransferencia as Valor,Observacion,a.Responsable,a.Estado", filtro, "a.Fecha desc,a.CodTransferencia", 3, sUsuario, sPassword, sSucursal)
            dgTransferencias.DataSource = dts.Tables(0)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try
            Dim ofrm As New frmMsCAConsultaTransferencia
            ofrm.TopLevel = True
            ofrm.pCodTransferencia = dgTransferencias.Item("codTransferencia", dgTransferencias.CurrentRow.Index).Value
            ofrm.txtResponsable.Text = dgTransferencias.Item("Responsable", dgTransferencias.CurrentRow.Index).Value
            ofrm.txtNoSocio.Text = dgTransferencias.Item("NoSocio", dgTransferencias.CurrentRow.Index).Value
            ofrm.c1txtNombreAsoc.Value = dgTransferencias.Item("Nombres", dgTransferencias.CurrentRow.Index).Value
            ofrm.dtpFecha.Value = dgTransferencias.Item("Fecha", dgTransferencias.CurrentRow.Index).Value
            ofrm.c1txtNoDoc.Value = dgTransferencias.Item("NoDocumento", dgTransferencias.CurrentRow.Index).Value
            ofrm.txtDui.Value = dgTransferencias.Item("Dui", dgTransferencias.CurrentRow.Index).Value.ToString.Trim
            ofrm.c1txtObservaciones.Value = dgTransferencias.Item("Observacion", dgTransferencias.CurrentRow.Index).Value
            ofrm.c1txtMonto.Value = dgTransferencias.Item("Valor", dgTransferencias.CurrentRow.Index).Value
            ofrm.pEstado = dgTransferencias.Item("Estado", dgTransferencias.CurrentRow.Index).Value
            ofrm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgTransferencias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTransferencias.CellContentClick

    End Sub

    Private Sub frmAnulacionTransferencia_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class