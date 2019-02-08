Public Class frmArregloMora
    Dim prestamo As New wrPrestamo.wsLibPrest
    Protected Sub consultarArreglos(ByVal codprestamo As String, ByVal dui As String, ByVal fechaInicio As DateTime, ByVal fechaFin As DateTime, ByVal opcion As Integer)
        Dim dts As New DataSet
        dts = prestamo.consultarPrBitacoraArregloMora(opcion, codprestamo, fechaInicio, fechaFin, dui)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.DataGridView1.DataSource = dts.Tables(0)
                estiloDg()
            End If
        End If
    End Sub
    Protected Sub estiloDg()
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsulta_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim dts As New DataSet
        Dim opcion As Integer
        If mrbDui.Checked = True Then
            opcion = 3
        ElseIf mrbCodPrestamo.Checked = True Then
            opcion = 2
        ElseIf MetroRadioButton2.Checked = True Then
            opcion = 1
        End If
        If opcion > 0 Then
            consultarArreglos(mTxtCodPrestamo.Text, mTxtDui.Text.Trim, Format(dtpFechaIni.Value, "short date"), Format(dtpFechaFin.Value, "short date"), opcion)

        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim frm As New frmDetArregloMora
        With frm
            .accion = 1
            .ShowDialog()
        End With
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            Dim frm As New frmDetArregloMora
            With frm
                .txtDui.Value = Me.DataGridView1.Item("dui", Me.DataGridView1.CurrentRow.Index).Value
                .lblNombre.Text = Me.DataGridView1.Item("nombres", Me.DataGridView1.CurrentRow.Index).Value
                .txtCodPrestamo.Text = Me.DataGridView1.Item("codprestamo", Me.DataGridView1.CurrentRow.Index).Value
                .txtSaldoCap.Text = Me.DataGridView1.Item("SaldoAnt", Me.DataGridView1.CurrentRow.Index).Value
                .txtTasa.Text = Me.DataGridView1.Item("TasaAnt", Me.DataGridView1.CurrentRow.Index).Value
                .txtTasaMora.Text = Me.DataGridView1.Item("TasaMoraAnt", Me.DataGridView1.CurrentRow.Index).Value
                .txtCapMora.Text = Me.DataGridView1.Item("moraAnt", Me.DataGridView1.CurrentRow.Index).Value
                .txtSaldoInt.Text = Me.DataGridView1.Item("IntAnt", Me.DataGridView1.CurrentRow.Index).Value
                .txtSaldoIntMora.Text = Me.DataGridView1.Item("IntMoraAnt", Me.DataGridView1.CurrentRow.Index).Value

                .txtNSaldoCap.Value = Me.DataGridView1.Item("NuevoSaldo", Me.DataGridView1.CurrentRow.Index).Value
                .txtNCapMor.Value = Me.DataGridView1.Item("NuevoSaldoMora", Me.DataGridView1.CurrentRow.Index).Value
                .txtNTasaInt.Value = Me.DataGridView1.Item("NuevaTasa", Me.DataGridView1.CurrentRow.Index).Value
                .txtNTMora.Value = Me.DataGridView1.Item("NuevaTasaMora", Me.DataGridView1.CurrentRow.Index).Value
                .txtNSaldoInt.Value = Me.DataGridView1.Item("NuevoInt", Me.DataGridView1.CurrentRow.Index).Value
                .txtNIntMora.Value = Me.DataGridView1.Item("nuevoIntMora", Me.DataGridView1.CurrentRow.Index).Value
                .btnGuardar.Visible = False

                .ShowDialog()
                .accion = 0

            End With
        Catch ex As Exception
            MsgBox("Por favor comunicarse con el administrador de sistema", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class