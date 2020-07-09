Public Class frmMsAsociadosISR
    Dim ahorro As New wrAhorro.wsLibAhorro

    Private Sub btnProcesar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim resultado As Integer
            resultado = ahorro.AsociadosISR(Format(dtpFechaI.Value, "Short Date"), Format(Me.dtpFechaF.Value, "Short Date"))
            If resultado <> 0 Then
                MsgBox("Registros ingresados exitosamente.", MsgBoxStyle.Information, "Módulo - Ahorros")
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsAsociadosISR_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class