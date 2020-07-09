Public Class frmAsocTransferenciasAutomaticas
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim ahorros As New wrAhorro.wsLibAhorro
    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Dim frm As New frmDetAsocTransferenciasAutomaticas

        With frm
            .accion = 1
            .Show()
        End With
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dts As New DataSet
        If rbTodos.Checked = True Then
            dts = ahorros.consultarAsocTransferenciasAutomaticas(0, "", 1, "", "", "", Now, sUsuario, sPassword, sSucursal)
        ElseIf rbAsociado.Checked = True Then
            dts = ahorros.consultarAsocTransferenciasAutomaticas(0, "", 2, txtAsociado.Text.Trim, "", "", Now, sUsuario, sPassword, sSucursal)
        ElseIf rbCtaOrigen.Checked = True Then
            dts = ahorros.consultarAsocTransferenciasAutomaticas(0, "", 3, txtAsociado.Text.Trim, txtOrigen.Text.Trim, "", Now, sUsuario, sPassword, sSucursal)
        ElseIf rbCtaDestino.Checked = True Then
            dts = ahorros.consultarAsocTransferenciasAutomaticas(0, "", 4, txtAsociado.Text.Trim, txtOrigen.Text.Trim, txtDestino.Text.Trim, Now, sUsuario, sPassword, sSucursal)
        ElseIf rbFechaCrea.Checked = True Then
            dts = ahorros.consultarAsocTransferenciasAutomaticas(0, "", 5, txtAsociado.Text.Trim, txtOrigen.Text.Trim, "", dtpFecha.Value.ToShortDateString, sUsuario, sPassword, sSucursal)
        End If

        Me.DataGridView1.DataSource = dts.Tables(0)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.DataGridView1.Columns("codTransferencia").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("noCuentaOrigen").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("noCuentaDestino").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("Asociado").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("diaTransferencia").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("montoTransferencia").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("Activo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells




    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim codTransferencia As Integer
        Dim frm As New frmDetAsocTransferenciasAutomaticas
        codTransferencia = Me.DataGridView1.Item("codTransferencia", Me.DataGridView1.CurrentRow.Index).Value
        With frm
            .accion = 2
            .codTransferencia = codTransferencia
            .ShowDialog()
            .TopMost = True
        End With

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim codTransferencia As Integer
        Dim frm As New frmDetAsocTransferenciasAutomaticas
        codTransferencia = Me.DataGridView1.Item("codTransferencia", Me.DataGridView1.CurrentRow.Index).Value
        With frm
            .accion = 3
            .codTransferencia = codTransferencia
            .ShowDialog()
            .TopMost = True
        End With
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If MsgBox("¿Desea suspender la transferencia automatica seleccionada?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'If (ahorros.inactivarAsocTransferenciasAutomaticas(Me.DataGridView1.Item("codTransferencia", Me.DataGridView1.CurrentRow.Index).Value,
                '                                                  sUsuario, Now, My.Computer.Name.ToString, False,
                '                                                  sUsuario, sPassword, sSucursal)) > 0 Then
                '    MsgBox("Suspensión realizada con exito", MsgBoxStyle.Information)
                'Else
                '     MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                'End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmAsocTransferenciasAutomaticas_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class