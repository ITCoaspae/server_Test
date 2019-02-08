Public Class frmMAhActivarCuentaInactiva
    Dim ahorro As New wrAhorro.wsLibAhorro
    Dim dtsCtasInactivas As New DataSet

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If txtDui.Text.Trim <> "-" Then
            dtsCtasInactivas = ahorro.consultarAhCuentasInactivas(txtDui.Text.Trim, "", 1)
            If dtsCtasInactivas.Tables.Count > 0 Then
                If dtsCtasInactivas.Tables(0).Rows.Count > 0 Then
                    Me.lblAsociado.Text = dtsCtasInactivas.Tables(0).Rows(0).Item("Asociado").ToString.Trim
                    If dtsCtasInactivas.Tables(0).Rows.Count = 1 Then
                        Me.txtCtaInactiva.Text = dtsCtasInactivas.Tables(0).Rows(0).Item("NoCuenta").ToString.Trim
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtCtaInactiva_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtaInactiva.DoubleClick
        If txtDui.Text.Trim <> "-" Then
            Dim frm As New frmAGenerico
            frm.Text = "Buscar Cuenta"
            frm.Datos = dtsCtasInactivas
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim <> "" Then
                Me.lblAsociado.Text = frm.Resultado2.ToString.Trim
                Me.txtDui.Text = frm.Resultado.ToString.Trim
            End If
        Else
            MsgBox("Por favor digite el número de DUI", MsgBoxStyle.Information, "Módulo - Ahorros")
        End If
        
    End Sub

    Private Sub txtCtaInactiva_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtaInactiva.LostFocus
        If txtCtaInactiva.Text.Trim <> "" Then
            dtsCtasInactivas = ahorro.consultarAhCuentasInactivas(txtDui.Text.Trim, "", 1)
            If dtsCtasInactivas.Tables.Count > 0 Then
                If dtsCtasInactivas.Tables(0).Rows.Count > 0 Then
                    Me.lblAsociado.Text = dtsCtasInactivas.Tables(0).Rows(0).Item("Asociado").ToString.Trim
                    Me.txtDui.Text = dtsCtasInactivas.Tables(0).Rows(0).Item("Dui").ToString.Trim
                End If
            End If
        End If
    End Sub

    Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub frmMAhActivarCuentaInactiva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtDui.Focus()
    End Sub



    Private Sub btGenCheque1_Click(sender As Object, e As EventArgs) Handles btnActivar1.Click
        Try
            If txtCtaInactiva.Text.Trim <> "" Then
                If MsgBox("La cuenta" & txtCtaInactiva.Text.Trim & " sera activada, ¿desea continuar con la operación?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Ahorros") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = ahorro.activarCuentasInactivas(sUsuario, txtCtaInactiva.Text, False)
                    If resultado <> 0 Then
                        MsgBox("Cuenta Activada Exitosamente", MsgBoxStyle.Information, "Módulo - Ahorros")
                    Else
                        MsgBox("La cuenta no pudo ser activada, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Ahorros")
                    End If
                End If
            Else
                MsgBox("Por favor ingrese el número de la cuenta.", MsgBoxStyle.Critical, "Módulo - Ahorros")
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class