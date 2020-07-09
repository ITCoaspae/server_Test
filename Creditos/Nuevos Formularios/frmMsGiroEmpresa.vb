Public Class frmMsGiroEmpresa
    Dim creditos As New wrCredito.wsLibCred
    Public accion As Integer '1 = insertar,2=modificar,3= consultar


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim resultado As Integer
            If Me.accion = 1 Then
                If Me.txtDescripcion.Text.Length > 0 And Me.txtDescripcion.Text.Trim <> "" Then
                    resultado = creditos.insertarPrGiroEmpresa(txtDescripcion.Text.Trim)
                    If resultado <> 0 Then
                        MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information, "Módulo - Creditos")
                    Else
                        MsgBox("El registro no fue ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Creditos")
                    End If
                Else
                    MsgBox("El campo 'Giro de Empresa' no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Creditos")
                End If
            ElseIf Me.accion = 2 Then
                If Me.txtDescripcion.Text.Length > 0 And Me.txtDescripcion.Text.Trim <> "" Then
                    resultado = creditos.modificarPrGiroEmpresa(txtDescripcion.Text.Trim, txtCodigo.Text.Trim)
                    If resultado <> 0 Then
                        MsgBox("Registro modificado exitosamente.", MsgBoxStyle.Information, "Módulo - Creditos")
                    Else
                        MsgBox("El registro no fue modificado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Creditos")
                    End If
                Else
                    MsgBox("El campo 'Giro de Empresa' no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Creditos")
                End If
            End If

            Me.Close()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class