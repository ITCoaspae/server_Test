Public Class frmMsBc_CambioEfectivo
    Dim bancos As New wrBancos.wsLibBancos
    Dim dtsBoveda As New DataSet

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Public Sub llenarCbBoveda(ByVal id_Boveda As Integer, ByVal opcion As Integer, ByVal codsucursal As String)
        dtsBoveda = Me.bancos.ConsultarBcBoveda(id_Boveda, opcion, codsucursal)
        If dtsBoveda.Tables.Count > 0 Then
            If dtsBoveda.Tables(0).Rows.Count > 0 Then
                Me.cbBoveda.DataSource = dtsBoveda.Tables(0)
            End If
        End If
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub
#Region "Efectivo Entregado"
    Private Sub c1nCienEntregado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCienEntregado.LostFocus
        Me.txtTotalEntregado.Value = Me.c1nUnoEntregado.Value _
        + (Me.c1nCincoEntregado.Value * 5) _
        + (Me.c1nDiezEntregado.Value * 10) _
        + (Me.c1nVeinteEntregado.Value * 20) _
        + (Me.c1nCincuentaEntregado.Value * 50) _
        + (Me.c1nCienEntregado.Value * 100) _
        + Me.C1nMonedaUnoEntregado.Value _
        + Me.c1nFraccionEntregado.Value
    End Sub

    Private Sub c1nCincoEntregado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCincoEntregado.LostFocus
        Me.txtTotalEntregado.Value = Me.c1nUnoEntregado.Value _
         + (Me.c1nCincoEntregado.Value * 5) _
         + (Me.c1nDiezEntregado.Value * 10) _
         + (Me.c1nVeinteEntregado.Value * 20) _
         + (Me.c1nCincuentaEntregado.Value * 50) _
         + (Me.c1nCienEntregado.Value * 100) _
         + Me.C1nMonedaUnoEntregado.Value _
         + Me.c1nFraccionEntregado.Value
    End Sub

    Private Sub c1nCincuentaEntregado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCincuentaEntregado.LostFocus
        Me.txtTotalEntregado.Value = Me.c1nUnoEntregado.Value _
            + (Me.c1nCincoEntregado.Value * 5) _
            + (Me.c1nDiezEntregado.Value * 10) _
            + (Me.c1nVeinteEntregado.Value * 20) _
            + (Me.c1nCincuentaEntregado.Value * 50) _
            + (Me.c1nCienEntregado.Value * 100) _
            + Me.C1nMonedaUnoEntregado.Value _
            + Me.c1nFraccionEntregado.Value
    End Sub

    Private Sub c1nVeinteEntregado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nVeinteEntregado.LostFocus
        Me.txtTotalEntregado.Value = Me.c1nUnoEntregado.Value _
               + (Me.c1nCincoEntregado.Value * 5) _
               + (Me.c1nDiezEntregado.Value * 10) _
               + (Me.c1nVeinteEntregado.Value * 20) _
               + (Me.c1nCincuentaEntregado.Value * 50) _
               + (Me.c1nCienEntregado.Value * 100) _
               + Me.C1nMonedaUnoEntregado.Value _
               + Me.c1nFraccionEntregado.Value
    End Sub

    Private Sub c1nDiezEntregado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nDiezEntregado.LostFocus
        Me.txtTotalEntregado.Value = Me.c1nUnoEntregado.Value _
             + (Me.c1nCincoEntregado.Value * 5) _
             + (Me.c1nDiezEntregado.Value * 10) _
             + (Me.c1nVeinteEntregado.Value * 20) _
             + (Me.c1nCincuentaEntregado.Value * 50) _
             + (Me.c1nCienEntregado.Value * 100) _
             + Me.C1nMonedaUnoEntregado.Value _
             + Me.c1nFraccionEntregado.Value
    End Sub

    Private Sub c1nUnoEntregado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nUnoEntregado.LostFocus
        Me.txtTotalEntregado.Value = Me.c1nUnoEntregado.Value _
                + (Me.c1nCincoEntregado.Value * 5) _
                + (Me.c1nDiezEntregado.Value * 10) _
                + (Me.c1nVeinteEntregado.Value * 20) _
                + (Me.c1nCincuentaEntregado.Value * 50) _
                + (Me.c1nCienEntregado.Value * 100) _
                + Me.C1nMonedaUnoEntregado.Value _
                + Me.c1nFraccionEntregado.Value
    End Sub

    Private Sub C1nMonedaUnoEntregado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1nMonedaUnoEntregado.LostFocus
        Me.txtTotalEntregado.Value = Me.c1nUnoEntregado.Value _
              + (Me.c1nCincoEntregado.Value * 5) _
              + (Me.c1nDiezEntregado.Value * 10) _
              + (Me.c1nVeinteEntregado.Value * 20) _
              + (Me.c1nCincuentaEntregado.Value * 50) _
              + (Me.c1nCienEntregado.Value * 100) _
              + Me.C1nMonedaUnoEntregado.Value _
              + Me.c1nFraccionEntregado.Value
    End Sub

    Private Sub c1nFraccionEntregado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nFraccionEntregado.LostFocus
        Me.txtTotalEntregado.Value = Me.c1nUnoEntregado.Value _
             + (Me.c1nCincoEntregado.Value * 5) _
             + (Me.c1nDiezEntregado.Value * 10) _
             + (Me.c1nVeinteEntregado.Value * 20) _
             + (Me.c1nCincuentaEntregado.Value * 50) _
             + (Me.c1nCienEntregado.Value * 100) _
             + Me.C1nMonedaUnoEntregado.Value _
             + Me.c1nFraccionEntregado.Value
    End Sub
#End Region
#Region "Efectivo Recibido"
    Private Sub c1nCienRecibido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCienRecibido.LostFocus
        Me.txtTotalRecibido.Value = (c1nCienRecibido.Value * 100) _
        + (c1nCincuentaRecibido.Value * 50) _
        + (c1nVeinteRecibido.Value * 20) _
        + (c1nDiezRecibido.Value * 10) _
        + (c1nCincoRecibido.Value * 5) _
        + c1nUnoRecibido.Value _
        + c1nMonedaUnoRecibido.Value _
        + c1nFraccionRecibido.Value
    End Sub

    Private Sub c1nCincuentaRecibido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCincuentaRecibido.LostFocus
        Me.txtTotalRecibido.Value = (c1nCienRecibido.Value * 100) _
             + (c1nCincuentaRecibido.Value * 50) _
             + (c1nVeinteRecibido.Value * 20) _
             + (c1nDiezRecibido.Value * 10) _
             + (c1nCincoRecibido.Value * 5) _
             + c1nUnoRecibido.Value _
             + c1nMonedaUnoRecibido.Value _
             + c1nFraccionRecibido.Value
    End Sub

    Private Sub c1nVeinteRecibido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nVeinteRecibido.LostFocus
        Me.txtTotalRecibido.Value = (c1nCienRecibido.Value * 100) _
         + (c1nCincuentaRecibido.Value * 50) _
         + (c1nVeinteRecibido.Value * 20) _
         + (c1nDiezRecibido.Value * 10) _
         + (c1nCincoRecibido.Value * 5) _
         + c1nUnoRecibido.Value _
         + c1nMonedaUnoRecibido.Value _
         + c1nFraccionRecibido.Value
    End Sub

    Private Sub c1nDiezRecibido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nDiezRecibido.LostFocus
        Me.txtTotalRecibido.Value = (c1nCienRecibido.Value * 100) _
       + (c1nCincuentaRecibido.Value * 50) _
       + (c1nVeinteRecibido.Value * 20) _
       + (c1nDiezRecibido.Value * 10) _
       + (c1nCincoRecibido.Value * 5) _
       + c1nUnoRecibido.Value _
       + c1nMonedaUnoRecibido.Value _
       + c1nFraccionRecibido.Value
    End Sub
    Private Sub c1nCincoRecibido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCincoRecibido.LostFocus
        Me.txtTotalRecibido.Value = (c1nCienRecibido.Value * 100) _
         + (c1nCincuentaRecibido.Value * 50) _
         + (c1nVeinteRecibido.Value * 20) _
         + (c1nDiezRecibido.Value * 10) _
         + (c1nCincoRecibido.Value * 5) _
         + c1nUnoRecibido.Value _
         + c1nMonedaUnoRecibido.Value _
         + c1nFraccionRecibido.Value
    End Sub

    Private Sub c1nUnoRecibido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nUnoRecibido.LostFocus
        Me.txtTotalRecibido.Value = (c1nCienRecibido.Value * 100) _
        + (c1nCincuentaRecibido.Value * 50) _
        + (c1nVeinteRecibido.Value * 20) _
        + (c1nDiezRecibido.Value * 10) _
        + (c1nCincoRecibido.Value * 5) _
        + c1nUnoRecibido.Value _
        + c1nMonedaUnoRecibido.Value _
        + c1nFraccionRecibido.Value
    End Sub

    Private Sub c1nMonedaUnoRecibido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nMonedaUnoRecibido.LostFocus
        Me.txtTotalRecibido.Value = (c1nCienRecibido.Value * 100) _
        + (c1nCincuentaRecibido.Value * 50) _
        + (c1nVeinteRecibido.Value * 20) _
        + (c1nDiezRecibido.Value * 10) _
        + (c1nCincoRecibido.Value * 5) _
        + c1nUnoRecibido.Value _
        + c1nMonedaUnoRecibido.Value _
        + c1nFraccionRecibido.Value
    End Sub

    Private Sub c1nFraccionRecibido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nFraccionRecibido.LostFocus
        Me.txtTotalRecibido.Value = (c1nCienRecibido.Value * 100) _
        + (c1nCincuentaRecibido.Value * 50) _
        + (c1nVeinteRecibido.Value * 20) _
        + (c1nDiezRecibido.Value * 10) _
        + (c1nCincoRecibido.Value * 5) _
        + c1nUnoRecibido.Value _
        + c1nMonedaUnoRecibido.Value _
        + c1nFraccionRecibido.Value
    End Sub
#End Region
    Private Sub frmMsBc_CambioEfectivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarCbBoveda(0, 2, sSucursal)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If Me.txtmontoCambio.Value > 0 Then

                If Me.txtmontoCambio.Value = Me.txtTotalEntregado.Value And txtmontoCambio.Value = txtTotalRecibido.Value Then

                    If dtsBoveda.Tables(0).Rows.Count > 0 Then
                        Dim saldoAnterior As Double = dtsBoveda.Tables(0).Rows(0).Item("saldo")
                        If bancos.CambiosEfectivo(Me.cbBoveda.SelectedValue, Format(Now, "Short Date"),
                                              saldoAnterior, Me.txtmontoCambio.Value, Math.Round(saldoAnterior - txtmontoCambio.Value, 2),
                                              Math.Round(saldoAnterior - txtmontoCambio.Value, 2), txtmontoCambio.Value,
                                              Math.Round((saldoAnterior - txtmontoCambio.Value + txtmontoCambio.Value), 2),
                                              sUsuario, Now.Hour.ToString.PadLeft(2, "0") + ":" + Now.Minute.ToString.PadLeft(2, "0"),
                                              txtObservacion.Text.Trim,
                                              c1nUnoEntregado.Value, c1nCincoEntregado.Value,
                                              c1nDiezEntregado.Value, c1nVeinteEntregado.Value,
                                              c1nCincuentaEntregado.Value, c1nCienEntregado.Value,
                                              C1nMonedaUnoEntregado.Value, c1nFraccionEntregado.Value,
                                              c1nUnoRecibido.Value, c1nCincoRecibido.Value,
                                              c1nDiezRecibido.Value, c1nVeinteRecibido.Value,
                                              c1nCincuentaRecibido.Value, c1nCienRecibido.Value,
                                              c1nMonedaUnoRecibido.Value, c1nFraccionRecibido.Value) <> 0 Then
                            MsgBox("Cambio realizado exitosamente", MsgBoxStyle.Information, "Módulo - Boveda")
                            Me.Close()
                        Else
                            MsgBox("La operación no fue realizada, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Boveda")
                        End If

                    End If
                Else
                    MsgBox("Los montos no coinciden, por favor revisar.", MsgBoxStyle.Information, "Módulo - Boveda")
                End If
            Else
                MsgBox("El monto a cambiar no puede ser menor o igual a cero.", MsgBoxStyle.Information, "Módulo - Boveda")
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class