Public Class frmDifCarteraPrestamos
    Dim Prestamos As New wrPrestamo.wsLibPrest

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Protected Sub FormatoDg()
        Me.dgDiferencias.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgDiferencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgDiferencias.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub btnExportar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgDiferencias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDiferencias.CellDoubleClick
        Dim dtsPagos As New DataSet
        dtsPagos = Prestamos.ConsultarMov_PrestamosDif(Me.dgDiferencias.Item("CodPrestamo", Me.dgDiferencias.CurrentRow.Index).Value, _
                                                        Format(Me.dtpFechaInicio.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"), _
                                                        1)

        Dim frm As New frmAGenerico
        frm.Text = "Pagos de Préstamo"
        frm.Datos = dtsPagos
        frm.ColSeleccion = 0
        frm.RefrescarGrid()
        frm.ShowDialog()
    End Sub

    Private Sub dgDiferencias_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDiferencias.Sorted
        Dim Diferencias As Double
        For i As Integer = 0 To dgDiferencias.Rows.Count - 1
            If Me.dgDiferencias.Item("Diferencia", i).Value <> 0 Then
                Me.dgDiferencias.Item("Diferencia", i).Style.BackColor = Color.Red
                Me.dgDiferencias.Item("Diferencia", i).Style.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try
            'Dim Diferencias As Double
            Dim Dts As New DataSet
            Dts = Prestamos.ConsultarDif_CarteraPrestamos(Format(Me.dtpFechaInicio.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
            'Dim dtCalculos As DataTable = New DataTable("Calculos")
            Me.dgDiferencias.DataSource = Dts.Tables(0)
            FormatoDg()
            For i As Integer = 0 To dgDiferencias.Rows.Count - 1
                If Me.dgDiferencias.Item("Diferencia", i).Value <> 0 Then
                    Me.dgDiferencias.Item("Diferencia", i).Style.BackColor = Color.Red
                    Me.dgDiferencias.Item("Diferencia", i).Style.ForeColor = Color.White
                End If
            Next
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnExportar1_Click(sender As Object, e As EventArgs) Handles btnExportar1.Click
        Try
            GridAExcel(Me.dgDiferencias)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class