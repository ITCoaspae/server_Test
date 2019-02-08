Public Class frmMsIndiceLiquidez
    Dim vAccion, vId As Integer
    Dim contabilidad As New wrConta.wsLibContab
#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property id() As Integer
        Get
            Return vId
        End Get
        Set(ByVal value As Integer)
            vId = value
        End Set
    End Property
#End Region
#Region "Funciones"
    Protected Function guardar(ByVal mes As Integer, ByVal annio As Integer, ByVal indice As Double) As Integer
        Dim resultado As Integer
        resultado = contabilidad.insertarContaIndiceLiquidez(mes, annio, indice, sUsuario, Now)
        Return resultado
    End Function
    Protected Function modificar(ByVal corr As Integer, ByVal mes As Integer, ByVal annio As Integer, ByVal indice As Double)
        Dim resultado As Integer
        resultado = contabilidad.modificarContaIndiceLiquidez(mes, annio, indice, sUsuario, Now, corr)
        Return resultado
    End Function
    Protected Function validaciones(ByVal mes As Integer, ByVal annio As Integer) As Boolean
        Dim dts As New DataSet
        dts = contabilidad.consultarContaIndiceLiquidez(mes, annio, 2)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function
#End Region
#Region "Eventos"
    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If accion = 1 Then 'Guardar
            If validaciones(cbMes.SelectedIndex + 1, nudAnnio.Value) = True Then
                If guardar(cbMes.SelectedIndex + 1, nudAnnio.Value, txtIndice.Value) <> 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo de Contabilidad")
                Else
                    MsgBox("Error, el registro no pudo ser ingresado, por favor comunicarse con el administrador de sistemas.", MsgBoxStyle.Critical, "Módulo de Contabilidad")
                End If
            Else
                MsgBox("Ya existe registro para el mes y años seleccionado.", MsgBoxStyle.Critical, "Módulo de Contabilidad")
            End If
        ElseIf accion = 2 Then ' Modificar
            If modificar(id, cbMes.SelectedIndex + 1, nudAnnio.Value, txtIndice.Value) <> 0 Then
                MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "Módulo de Contabilidad")
            Else
                MsgBox("Error, el registro no pudo ser modificado, por favor comunicarse con el administrador de sistemas.", MsgBoxStyle.Critical, "Módulo de Contabilidad")
            End If
        End If
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
#End Region

End Class