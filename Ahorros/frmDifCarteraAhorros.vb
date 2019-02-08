Public Class frmDifCarteraAhorros
    Dim Ahorros As New wrAhorro.wsLibAhorro
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim Dts As New DataSet
        Dts = Ahorros.ConsultarMov_AhorrosDif(Format(dtpFechaInicio.Value, "Short Date"), _
                                              Format(dtpFechaFin.Value, "Short Date"))
        If Dts.Tables(0).Rows.Count > 0 Then
            Me.dgDifAhorros.DataSource = Dts.Tables(0)
            FormatoDg()
        End If
        For i As Integer = 0 To dgDifAhorros.Rows.Count - 1
            If Me.dgDifAhorros.Item("Diferencia", i).Value <> 0 Then
                Me.dgDifAhorros.Item("Diferencia", i).Style.BackColor = Color.Red
                Me.dgDifAhorros.Item("Diferencia", i).Style.ForeColor = Color.White
            End If
        Next
    End Sub
    Protected Sub FormatoDg()
        Me.dgDifAhorros.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgDifAhorros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgDifAhorros.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub dgDifAhorros_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDifAhorros.CellDoubleClick
        Dim Dts As New DataSet
        Dts = Ahorros.MostrarMovimientos("nocuenta", "fecha,correlativo", _
                                         Me.dgDifAhorros.Item("NoCuenta", Me.dgDifAhorros.CurrentRow.Index).Value, _
                                         "", Format(Me.dtpFechaInicio.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"), _
                                         wrAhorro.TipoCuenta.Ahorro, sUsuario, sPassword, sSucursal)
        Dim frm As New frmAGenerico
        frm.Text = "Movimientos de Ahorro Cta. No."
        frm.Datos = Dts
        frm.ColSeleccion = 0
        frm.RefrescarGrid()
        frm.ShowDialog()
    End Sub

    Private Sub dgDifAhorros_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDifAhorros.Sorted
        Dim Diferencias As Double
        For i As Integer = 0 To dgDifAhorros.Rows.Count - 1
            If Me.dgDifAhorros.Item("Diferencia", i).Value <> 0 Then
                Me.dgDifAhorros.Item("Diferencia", i).Style.BackColor = Color.Red
                Me.dgDifAhorros.Item("Diferencia", i).Style.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub btnExportar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        GridAExcel(Me.dgDifAhorros)
    End Sub
End Class