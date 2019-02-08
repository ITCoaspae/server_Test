Public Class frmMBCSaldosBancos
    Dim Bancos As New wrBancos.wsLibBancos
    Public Sub LlenarDgBancos(ByVal Id_SaldosBancos As Integer, ByVal idcuentaBanco As String, ByVal Opcion As Integer)
        Dim Dts As New DataSet
        Dts = Bancos.ConsultarBCSaldos_Bancos(Id_SaldosBancos, 0, Opcion, "")
        If Dts.Tables(0).Rows.Count > 0 Then
            Me.dgSaldos.DataSource = Dts.Tables(0)
            EstiloDG()
        End If
    End Sub
    Protected Sub EstiloDG()
        Me.dgSaldos.Columns("Id_saldosBancos").Visible = False
        Me.dgSaldos.Columns("idBanco").HeaderText = "Id. Banco"
        Me.dgSaldos.Columns("Nom_Banco").HeaderText = "Banco"
        Me.dgSaldos.Columns("IdCtaBanco").HeaderText = "Id. Cuenta Banco"
        Me.dgSaldos.Columns("Saldo").HeaderText = "Saldo"
        Me.dgSaldos.Columns("Fech_UltMov").HeaderText = "Fecha de Ult. Movimiento"

        Me.dgSaldos.Columns("Id_saldosBancos").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgSaldos.Columns("idBanco").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgSaldos.Columns("Nom_Banco").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgSaldos.Columns("IdCtaBanco").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgSaldos.Columns("Saldo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgSaldos.Columns("Fech_UltMov").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Me.dgSaldos.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgSaldos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgSaldos.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

    End Sub
    Private Sub btnAgregarCta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregarCta.Click
        Dim frm As New frmMsBCSaldosBancos
        frm.Text = "Ingresar "
        frm.ShowDialog()
    End Sub
    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim idSaldosBancos As Integer
            Dim Frm As New frmMsBCSaldosBancos
            If dgSaldos.CurrentRow.Index <> -1 Then
                idSaldosBancos = Me.dgSaldos.Item(0, Me.dgSaldos.CurrentRow.Index).Value
                Frm.Text = "Modificar Saldos Bancos"
                Frm.btnGuardar.Text = "Modificar"
                Frm.idSaldosBancos = idSaldosBancos
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Bancos")
        End Try
        
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim Resultado As Integer
            Dim Id_SaldosBancos As Integer
            Id_SaldosBancos = Me.dgSaldos.Item(0, Me.dgSaldos.CurrentRow.Index).Value
            If MsgBox("Desea eliminar el Registro seleccionado", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo - Bancos") = 6 Then
                Resultado = Bancos.EliminarBCSaldos_Bancos(Id_SaldosBancos)
                If Resultado <> 0 Then
                    MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Modulo - Bancos")
                Else
                    MsgBox("No se pudo eliminar el registro", MsgBoxStyle.Critical, "Modulo - Bancos")
                End If
                LlenarDgBancos(0, "", 1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Bancos")
        End Try
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            Dim idSaldosBancos As Integer
            Dim Frm As New frmMsBCSaldosBancos
            If dgSaldos.CurrentRow.Index <> -1 Then
                idSaldosBancos = Me.dgSaldos.Item(0, Me.dgSaldos.CurrentRow.Index).Value
                Frm.Text = "Modificar Saldos Bancos"
                Frm.btnGuardar.Text = "Consultar"
                Frm.btnGuardar.Enabled = False
                Frm.cbBancos.Enabled = False
                Frm.idSaldosBancos = idSaldosBancos
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Bancos")
        End Try
    End Sub
    Private Sub frmMBCSaldosBancos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarDgBancos(0, "", 1)
    End Sub
    Private Sub btnActualizarGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarGrid.Click
        LlenarDgBancos(0, "", 1)
    End Sub
End Class