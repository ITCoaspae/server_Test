Public Class frmMCierreCompra
    Dim compra As New wrConta.wsLibContab
    Protected Sub consultarCierre(ByVal mes As Integer, ByVal annio As Integer, ByVal opcion As Integer)
        Dim dts As New DataSet
        dts = compra.consultarCaCompraCierreMes(mes, annio, opcion, 0)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.dgCierre.DataSource = dts.Tables(0)
            Me.dgCierre.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            Me.dgCierre.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.dgCierre.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            Me.dgCierre.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        End If
    End Sub

    Private Sub frmMCierreCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtAnio.Value = Now.Year
        consultarCierre(0, Now.Year, 3)
    End Sub


    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        consultarCierre(0, txtAnio.Value, 3)
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        Try
            Dim frm As New frmMCierreMesCompra
            With frm
                .accion = 1
                .ShowDialog()
            End With
            consultarCierre(0, Now.Year, 3)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnMod1_Click(sender As Object, e As EventArgs) Handles btnMod1.Click
        Try
            Dim frm As New frmMCierreMesCompra
            With frm
                .accion = 2
                .txtAnio.Value = Me.dgCierre.Item("annio", Me.dgCierre.CurrentRow.Index).Value
                .cbMes.SelectedIndex = Me.dgCierre.Item("mes", Me.dgCierre.CurrentRow.Index).Value - 1
                .chkCerrado.Checked = Me.dgCierre.Item("Cerrado", Me.dgCierre.CurrentRow.Index).Value
                .txtBloque.Value = Me.dgCierre.Item("bloque", Me.dgCierre.CurrentRow.Index).Value
                .ShowDialog()
            End With
            consultarCierre(0, Now.Year, 3)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            Dim frm As New frmMCierreMesCompra
            With frm
                .accion = 3
                .txtAnio.Value = Me.dgCierre.Item("annio", Me.dgCierre.CurrentRow.Index).Value
                .cbMes.SelectedIndex = Me.dgCierre.Item("mes", Me.dgCierre.CurrentRow.Index).Value - 1
                .chkCerrado.Checked = Me.dgCierre.Item("Cerrado", Me.dgCierre.CurrentRow.Index).Value
                .txtBloque.Value = Me.dgCierre.Item("bloque", Me.dgCierre.CurrentRow.Index).Value
                .txtAnio.Enabled = False
                .cbMes.Enabled = False
                .txtBloque.Enabled = False
                .chkCerrado.Enabled = False
                .btnGuardar.Visible = False
                .ShowDialog()
            End With
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class