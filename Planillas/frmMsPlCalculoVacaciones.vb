Public Class frmMsPlCalculoVacaciones
    Protected Planillas As New wrPlanilla.wsLibPlanilla
    Public id_Vac As Integer

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Resultado As Integer
            If Me.btnGuardar1.Text = "&Guardar" Then

                Resultado = Planillas.Insertar_PlCalculoVacaciones(Me.txtDesde.Text, Me.txtHasta.Text,
                                                                   Me.txtPrima.Text, Me.txtDias.Text, Now, sUsuario)
                If Resultado <> 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                End If
            Else
                Resultado = Planillas.Modificar_PlCalculoVacaciones(CDbl(txtDesde.Text), CDbl(Me.txtHasta.Text),
                                                                   Me.txtPrima.Text, Me.txtDias.Text, Now,
                                                                   sUsuario, id_Vac)
                If Resultado <> 0 Then
                    MsgBox("Registro Modificado exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class