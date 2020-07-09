Public Class frmMsCaTiposDocumentos
    Dim caja As New wrCaja.wsLibCaja
    Dim vAccion As Integer '1=Insertar;2=Modificar;3=Consultar
    Dim vIdTipoDoc As Integer
#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idTipoDoc() As Integer
        Get
            Return vIdTipoDoc
        End Get
        Set(ByVal value As Integer)
            vIdTipoDoc = value
        End Set
    End Property
#End Region
#Region "Funcion"
    Protected Function guardarTipoDoc(ByVal tipoDocumento As String, ByVal abrev As String, ByVal activo As Boolean) As Integer
        Dim resultado As Integer
        resultado = caja.insertarCaMaestroTipoDocumentos(tipoDocumento, abrev, activo)
        Return resultado
    End Function

    Protected Function ModificarTipoDoc(ByVal idTipoDoc As Integer, ByVal tipoDocumento As String, ByVal activo As Boolean, ByVal abrev As String) As Integer
        Dim resultado As Integer
        resultado = caja.modificarCaMaestroTipoDocumentos(tipoDocumento, abrev, activo, idTipoDoc)
        Return resultado
    End Function
#End Region
#Region "Metodos"
    Protected Sub limpiar()
        Me.txtAbrev.Text = ""
        Me.txtTipoDoc.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If vAccion = 1 Then
                If Me.txtTipoDoc.Text.Length > 0 And Me.txtTipoDoc.Text.Trim <> "" And Me.txtAbrev.Text.Length > 0 Then
                    If guardarTipoDoc(Me.txtTipoDoc.Text.Trim, Me.txtAbrev.Text, IIf(Me.rbActivo.Checked = True, True, False)) <> 0 Then
                        MsgBox("Tipo de documento ingresado exitosamente.", MsgBoxStyle.Information, "Módulo - Caja")
                    End If
                End If
            ElseIf vAccion = 2 Then
                If Me.txtTipoDoc.Text.Length > 0 And Me.txtTipoDoc.Text.Trim <> "" And Me.txtAbrev.Text.Length > 0 Then
                    If ModificarTipoDoc(vIdTipoDoc, txtTipoDoc.Text.Trim, IIf(Me.rbActivo.Checked = True, True, False), txtAbrev.Text.Trim) <> 0 Then
                        MsgBox("Tipo de documento modificado exitosamente.", MsgBoxStyle.Information, "Módulo - Caja")
                    End If
                End If
            End If
            limpiar()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "Eventos"


#End Region



End Class