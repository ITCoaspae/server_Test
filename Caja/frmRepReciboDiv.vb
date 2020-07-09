Public Class frmRepReciboDiv
    Protected Asociados As New wrAsociados.wsLibAsoc
    Dim accion As Boolean = False
    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        Dim Opcion As Integer
        Dim Dts As New DataSet
        frm.Text = "Buscar Asociado"
        accion = True
        Try
            Dts = Asociados.ConsultarAsociados_AhDividendos(Opcion)
            frm.Datos = Dts
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim <> "" Then
                Dim Dts_Asoc As New DataSet
                Dim dr As DataRow
                sTexto = frm.Resultado.Trim
                Me.txtDui.Text = sTexto
                Dts_Asoc = Asociados.ConsultarAsociado("Nombres,Apellido1,Apellido2,ApellidoCas,Nosocio", "Dui='" & Me.txtDui.Text.Trim & "'", "Dui", sUsuario, sPassword, sSucursal)
                dr = Dts_Asoc.Tables(0).Rows(0)
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Modulo - Asociados")
        End Try
    End Sub
    Private Sub btnGenerar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text <> "" And accion = False Then
            Dim Dts As New DataSet
            Dim dr As DataRow
            Dts = Asociados.ConsultarAsociado("Nombres,Apellido1,Apellido2,ApellidoCas,Nosocio", "Dui='" & Me.txtDui.Text.Trim & "'", "Dui", sUsuario, sPassword, sSucursal)
            dr = Dts.Tables(0).Rows(0)
            Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
            accion = False
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Dts As New DataSet
            Dts = Asociados.Recibo_Dividendos(Now, "", Now.Date, "", Me.txtDui.Text.Trim, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(Dts, 81, 0)
            ofrm.Show()
            accion = False
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class