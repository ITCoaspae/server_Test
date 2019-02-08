Public Class frmMsClasificacionPagaduria
    Dim creditos As New wrCredito.wsLibCred
    Public accion As Integer

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Protected Sub limpiar()
        Me.txtCategoria.Text = ""
        Me.txtDesde.Clear()
        txtHasta.Clear()
    End Sub
    Public Sub llenarTipoEvaluaciones()
        Dim dts As New DataSet
        dts = creditos.consultarPrTipoEvaluaciones
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbTipoEvaluaciones.DataSource = dts.Tables(0)
        End If
    End Sub
    Private Sub frmMsClasificacionPagaduria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If accion = 1 Then
            llenarTipoEvaluaciones()
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim resultado As Integer
            Dim msg As String
            If Me.accion = 1 Then
                resultado = creditos.insertarPrCatClasificacionPagadurias(txtCategoria.Text.Trim, txtDesde.Value, txtHasta.Value, Me.cbTipoEvaluaciones.SelectedValue)
                msg = "Registro ingresado exitosamente"
            ElseIf accion = 2 Then
                resultado = creditos.modificarPrCatClasificacionPagadurias(txtCategoria.Text.Trim, txtDesde.Value, txtHasta.Value, txtCodigo.Text.Trim, Me.cbTipoEvaluaciones.SelectedValue)
                msg = "Registro modificado exitosamente"
            End If
            If resultado <> 0 Then
                MsgBox(msg, MsgBoxStyle.Information, "Módulo - Créditos")
            Else
                MsgBox("Error, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Créditos")
            End If
            limpiar()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class