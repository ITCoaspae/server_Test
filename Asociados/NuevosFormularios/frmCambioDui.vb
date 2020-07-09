Public Class frmCambioDui
    Dim asociados As New wrAsociados.wsLibAsoc


    Private Sub txtDuiAnt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuiAnt.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDuiAnt.ValueIsDbNull, "", txtDuiAnt.Value)
            If Valor.Trim = "" Then
                Me.txtDuiAnt.SelectionStart = 0
                Me.txtDuiAnt.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNuevoDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNuevoDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtNuevoDui.ValueIsDbNull, "", txtNuevoDui.Value)
            If Valor.Trim = "" Then
                Me.txtNuevoDui.SelectionStart = 0
                Me.txtNuevoDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDuiAnt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuiAnt.DoubleClick
        If txtDuiAnt.Text.Replace("_", " ").Replace("-", " ") = "" Then
            MessageBox.Show("Se debe ingresar el DUI del asociado", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim ds As New Data.DataSet
        Try

            ds = asociados.ConsultarAsociado("DUI,concat(rtrim(Nombres),' ',rtrim(Apellido1),' ',rtrim(apellido2),' ', rtrim(apellidocas))[Asociado]", "", "Asociado", sUsuario, sPassword, sSucursal)

            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.C1fgrdResultado.Cols.Item(1).Width = 100
            frm.C1fgrdResultado.Cols.Item(2).Width = 500
            frm.ShowDialog()
            txtDuiAnt.Text = frm.Resultado.ToString.Trim
            txtAsociado.Text = frm.Resultado2


        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click

        If MetroFramework.MetroMessageBox.Show(Me, "¿Desea continuar con la operación?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If txtDuiAnt.Text.Length >= 10 And txtNuevoDui.Text.Length >= 10 Then
                If asociados.cambioDui(txtDuiAnt.Text.Trim, txtNuevoDui.Text.Trim) > 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Cambio realizado exitosamente", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                    Me.Close()
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Cambio realizado exitosamente", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        End If
    End Sub



    Private Sub frmCambioDui_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class