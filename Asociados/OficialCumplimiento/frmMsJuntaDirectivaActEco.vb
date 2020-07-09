Public Class frmMsJuntaDirectivaActEco
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim vAccion, vIdPersonaJuridica, vIdJuntaDirectiva As Integer
#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return Me.vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idPersonaJur() As Integer
        Get
            Return Me.vIdPersonaJuridica
        End Get
        Set(ByVal value As Integer)
            vIdPersonaJuridica = value
        End Set
    End Property
    Public Property idJuntaDirectiva() As Integer
        Get
            Return Me.vIdJuntaDirectiva
        End Get
        Set(ByVal value As Integer)
            vIdJuntaDirectiva = value
        End Set
    End Property

    Private Sub btnGuardarDom_Click(sender As Object, e As EventArgs) Handles btnGuardarDom.Click
        Try
            If Me.txtCargo.Text.Length > 0 And Me.txtNombreDir.Text.Trim.Length > 0 Then
                If accion = 1 Then
                    If asociados.insertarAsocPersonaJuridicaDirectivos(txtNombreDir.Text.Trim, txtCargo.Text.Trim,
                                                                          chkActivo.Checked, idPersonaJur) > 0 Then
                        MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                    Else
                        MsgBox("El registro no fue ingresado, por favor comunicarse con el administrador de sistema", MsgBoxStyle.Critical, "Módulo - Asociados")
                    End If
                ElseIf accion = 2 Then
                    If asociados.actualizarAsocPersonaJuridicaDirectivos(txtNombreDir.Text.Trim, txtCargo.Text.Trim,
                                                                        chkActivo.Checked, idPersonaJur,
                                                                        idJuntaDirectiva) > 0 Then
                        MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                    Else
                        MsgBox("El registro no fue ingresado, por favor comunicarse con el administrador de sistema", MsgBoxStyle.Critical, "Módulo - Asociados")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical, "Módulo - Asociados")
        End Try
    End Sub
#End Region

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmMsJuntaDirectivaActEco_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class