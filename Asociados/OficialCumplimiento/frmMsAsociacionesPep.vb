Public Class frmMsAsociacionesPep
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim vAccion, vIdSociedad, vIdPep As Integer
    Public Property accion() As Integer
        Get
            Return Me.vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idSociedad() As Integer
        Get
            Return Me.vIdSociedad
        End Get
        Set(ByVal value As Integer)
            vIdSociedad = value
        End Set
    End Property
    Public Property idPep() As Integer
        Get
            Return Me.vIdPep
        End Get
        Set(ByVal value As Integer)
            vIdPep = value
        End Set
    End Property

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If txtPorParticipacin.Value <= 100 Then
                If accion = 1 Then
                    If asociados.insertar_AsocPep_Sociedades(idPep, txtSociedad.Text.Trim, txtPorParticipacin.Value) > 0 Then
                        MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                        Me.Close()
                    Else
                        MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Information, "Módulo - Asociados")
                    End If
                ElseIf accion = 2 Then
                    If asociados.modificarAsocPep_Sociedades(idSociedad, idPep, txtSociedad.Text.Trim, txtPorParticipacin.Value) > 0 Then
                        MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                        Me.Close()
                    Else
                        MsgBox("El registro no pudo ser modificado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Information, "Módulo - Asociados")
                    End If

                End If
            Else
                MsgBox("El porcentaje de participación no puede ser mayor que 100.", MsgBoxStyle.Critical, "Módulo - Asociados")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsAsociacionesPep_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class