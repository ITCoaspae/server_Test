Public Class frmDetalleRemesaBanco
    Dim banco As New wrBancos.wsLibBancos
    Public correlativo As Integer



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If validarCampos() = True Then
            If banco.insertarDetalleRemesaBanco(correlativo, txtFolio.Text.Trim, txtNoComprobante.Text.Trim, txtNombreCta.Text.Trim.ToUpper, TextBox1.Text.Trim.ToUpper, sUsuario, dtpFecMovRemesar.Value) > 0 Then
                MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information)
            Else
                MsgBox(mensajeError, MsgBoxStyle.Critical)
            End If
        End If
        Me.Close()

    End Sub
    Private Function validarCampos() As Boolean
        Me.ErrorProvider1.Clear()
        Dim valido As Boolean = True
        If txtFolio.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtFolio, "Campo Requerido")
            valido = False
        End If
        If txtNoComprobante.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtNoComprobante, "Campo Requerido")
            valido = False
        End If
        If txtNombreCta.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtNombreCta, "Campo Requerido")
            valido = False
        End If
        If dtpFecMovRemesar.Value.Date.CompareTo(Now) > 0 Then
            Me.ErrorProvider1.SetError(dtpFecMovRemesar, "Fecha Invalida")
            valido = False
        End If
        Return valido
    End Function
End Class