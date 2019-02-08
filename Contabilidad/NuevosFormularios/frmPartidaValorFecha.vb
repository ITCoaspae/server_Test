Public Class frmPartidaValorFecha
    Dim contabilidad As New wrConta.wsLibContab
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim dts As New DataSet, dtsCargo As New DataSet
        Me.dgAbono.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgAbono.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgAbono.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgCargos.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgCargos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgCargos.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        If Me.MetroTabControl1.SelectedIndex = 0 Then
            dts = contabilidad.generarPartidaValorFecha(DateTimePicker1.Value.ToShortDateString, "A")
            Dim Fila As DataRow = dts.Tables(0).NewRow
            Dim totalAbonoA, totalCargoA As Double
            For i As Integer = 0 To dts.Tables(0).Rows.Count - 1
                totalAbonoA = totalAbonoA + dts.Tables(0).Rows(i).Item("abono")
                totalCargoA = totalCargoA + dts.Tables(0).Rows(i).Item("cargo")
            Next
            Fila(0) = "TOTAL"
            Fila(1) = ""
            Fila(2) = totalCargoA
            Fila(3) = totalAbonoA
            dts.Tables(0).Rows.Add(Fila)
            Me.dgAbono.DataSource = dts.Tables(0)
            Me.dgAbono.Columns(0).HeaderText = "Id. Cuenta"
            Me.dgAbono.Columns(1).HeaderText = "Centro de Costo"
            Me.dgAbono.Columns(2).HeaderText = "Cargos"
            Me.dgAbono.Columns(3).HeaderText = "Abonos"
            Me.dgAbono.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.dgAbono.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.dgAbono.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.dgAbono.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Else
            dtsCargo = contabilidad.generarPartidaValorFecha(DateTimePicker1.Value.ToShortDateString, "C")

            Dim FilaC As DataRow = dtsCargo.Tables(0).NewRow
            Dim totalAbonoC, totalCargoC As Double
            For i As Integer = 0 To dtsCargo.Tables(0).Rows.Count - 1
                totalAbonoC = totalAbonoC + dtsCargo.Tables(0).Rows(i).Item("abono")
                totalCargoC = totalCargoC + dtsCargo.Tables(0).Rows(i).Item("cargo")
            Next
            FilaC(0) = "TOTAL"
            FilaC(1) = ""
            FilaC(2) = totalCargoC
            FilaC(3) = totalAbonoC
            dtsCargo.Tables(0).Rows.Add(FilaC)

            Me.dgCargos.DataSource = dtsCargo.Tables(0)
            Me.dgCargos.Columns(0).HeaderText = "Id. Cuenta"
            Me.dgCargos.Columns(1).HeaderText = "Centro de Costo"
            Me.dgCargos.Columns(2).HeaderText = "Cargos"
            Me.dgCargos.Columns(3).HeaderText = "Abonos"
            Me.dgCargos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.dgCargos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.dgCargos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.dgCargos.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If MsgBox("¿Crear partida de aplicaciones valor fecha?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If (contabilidad.guardarPartidaValorFecha(DateTimePicker1.Value.ToShortDateString, "", sUsuario)) > 0 Then
                MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information)
            Else
                MsgBox(mensajeError, MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class