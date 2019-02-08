Public Class frmDifCarteraAportaciones
    Dim Ahorros As New wrAhorro.wsLibAhorro
    Private Sub btnGenerar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim Dts As New DataSet
        Dts = Ahorros.ConsultarMov_AportacionesDif(Format(dtpFechaInicio.Value, "Short Date"), _
                                              Format(dtpFechaFin.Value, "Short Date"))
        If Dts.Tables(0).Rows.Count > 0 Then
            Me.dgDifAportaciones.DataSource = Dts.Tables(0)
            FormatoDg()
        End If
        For i As Integer = 0 To dgDifAportaciones.Rows.Count - 1
            If Me.dgDifAportaciones.Item("Diferencia", i).Value <> 0 Then
                Me.dgDifAportaciones.Item("Diferencia", i).Style.BackColor = Color.Red
                Me.dgDifAportaciones.Item("Diferencia", i).Style.ForeColor = Color.White
            End If
        Next
    End Sub
    Protected Sub FormatoDg()
        Me.dgDifAportaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgDifAportaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgDifAportaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub dgDifAportaciones_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDifAportaciones.CellDoubleClick
        Dim Dts As New DataSet
        Dts = Ahorros.MostrarMovimientos("nocuenta", "fecha,correlativo", _
                                         Me.dgDifAportaciones.Item("NoCuenta", dgDifAportaciones.CurrentRow.Index).Value, _
                                         "", Format(Me.dtpFechaInicio.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"), _
                                         wrAhorro.TipoCuenta.Aportacion, sUsuario, sPassword, sSucursal)
        Dim frm As New frmAGenerico
        frm.Text = "Movimientos de Ahorro Cta. No."
        frm.Datos = Dts
        frm.ColSeleccion = 0
        frm.RefrescarGrid()
        frm.ShowDialog()
    End Sub
    Private Sub dgDifAportaciones_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDifAportaciones.Sorted
        Dim Diferencias As Double
        For i As Integer = 0 To dgDifAportaciones.Rows.Count - 1
            If Me.dgDifAportaciones.Item("Diferencia", i).Value <> 0 Then
                Me.dgDifAportaciones.Item("Diferencia", i).Style.BackColor = Color.Red
                Me.dgDifAportaciones.Item("Diferencia", i).Style.ForeColor = Color.White
            End If
        Next
    End Sub
    Private Sub btnExportar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        GridAExcel(Me.dgDifAportaciones)
    End Sub
End Class