Public Class frmMsMaestroCatalogos
    Dim catalogo As New wrAsociados.wsLibAsoc
    Dim vAccion As Integer
    Dim vDescripcion As String
    Dim vIdCatalogo As Integer
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idCatalogo() As Integer
        Get
            Return vIdCatalogo
        End Get
        Set(ByVal value As Integer)
            vIdCatalogo = value
        End Set
    End Property

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If Me.txtCat.Text.Length > 0 Then
                If vAccion = 1 Then 'Insertar
                    If catalogo.insertarCatalogosTiposCatalogo(txtCat.Text.ToUpper.Trim) > 0 Then
                        MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information, "Mantenimiento de Catalogos")
                        Me.Close()
                    Else
                        MsgBox("El registro no fue ingrsado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Mantenimiento de Catalogos")

                    End If
                ElseIf vAccion = 2 Then 'Modificar
                    If catalogo.actualizarCatalogosTiposCatalogo(txtCat.Text.ToUpper.Trim, idCatalogo) > 0 Then
                        MsgBox("Registro modificado exitosamente.", MsgBoxStyle.Information, "Mantenimiento de Catalogos")
                    Else
                        MsgBox("El registro no fue ingrsado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Mantenimiento de Catalogos")

                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class