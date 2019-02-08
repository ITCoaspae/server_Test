Public Class frmMsTipoCtasContables
    Dim contabilidad As New wrConta.wsLibContab
    Dim vAccion As Integer
    Dim vTipoCuenta As String
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property tipoCuenta() As String
        Get
            Return vTipoCuenta
        End Get
        Set(ByVal value As String)
            vTipoCuenta = value
        End Set
    End Property

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim resultado As Integer
            If accion = 1 Then
                resultado = contabilidad.insertarCat_TipoCtas_Contables(txtTipoCuenta.Text.Trim, txtDescripcion.Text.Trim, sUsuario)
                Me.txtDescripcion.Text = ""
                Me.txtTipoCuenta.Text = ""
            ElseIf accion = 2 Then
                resultado = contabilidad.modificarCat_TipoCtas_Contables(vTipoCuenta, txtDescripcion.Text.Trim, sUsuario)
            End If
            If resultado <> 0 Then
                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Contabilidad")
            End If
            
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMsTipoCtasContables_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vAccion = 2 Then
            Me.txtTipoCuenta.Enabled = False
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class