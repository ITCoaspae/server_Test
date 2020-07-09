Public Class frmActualizarSaldosCC
    Dim contabilidad As New wrConta.wsLibContab
    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            Dim resultado As Integer = 0
            'resultado = contabilidad.ActualizarSaldosCentroCosto(cbMes.SelectedIndex, txtAnio.Value)
            If resultado > 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Saldos actualizados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class