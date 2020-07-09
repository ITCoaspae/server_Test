﻿Public Class frmMsTipoEmpresa
    Public accion As Integer
    Dim creditos As New wrCredito.wsLibCred

    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim resultado As Integer
            Dim msg As String
            If accion = 1 Then
                resultado = creditos.insertarPrTipoEmpresa(txtDescripcion.Text.Trim)
                msg = "Registro ingresado exitosamente."
            ElseIf accion = 2 Then
                resultado = creditos.modificarPrTipoEmpresa(txtDescripcion.Text.Trim, txtCodigo.Text.Trim)
                msg = "Registro modificado exitosamente."
            End If
            If resultado <> 0 Then
                MsgBox(msg, MsgBoxStyle.Information, "Módulo - Créditos")
            Else
                MsgBox("La operación no pudo ser realizada, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Créditos")
            End If
            Me.Close()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class