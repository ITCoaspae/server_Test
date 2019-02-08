Public Class frmMBC_Boveda
    Dim Bancos As New wrBancos.wsLibBancos
#Region "Metodos"
    Public Sub LlenardgBovedas(ByVal id_Boveda As Integer, ByVal Opcion As Integer, _
                               ByVal CodSucursal As String)
        Dim Dts As New DataSet
        Dts = Bancos.ConsultarBcBoveda(id_Boveda, Opcion, CodSucursal)
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.dgBoveda.DataSource = Dts.Tables(0)
                Estilodg()
            End If
        End If
    End Sub
    Public Sub Estilodg()
        Me.dgBoveda.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgBoveda.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgBoveda.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgBoveda.Columns("id_Boveda").HeaderText = "Id. Bóveda"
        Me.dgBoveda.Columns("Descripcion").HeaderText = "Bóveda"
        Me.dgBoveda.Columns("Nom_Sucursal").HeaderText = "Sucursal"
        Me.dgBoveda.Columns("SaldoMin").HeaderText = "Saldo Minimo"
        Me.dgBoveda.Columns("SaldoMax").HeaderText = "Saldo Maximo"

        Me.dgBoveda.Columns("CodSucursal").Visible = False

        Me.dgBoveda.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBoveda.Columns("Nom_Sucursal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

    End Sub
#End Region
#Region "Eventos"
    Private Sub frmMBC_Boveda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenardgBovedas(0, 1, "")
    End Sub
#End Region
    
    Private Sub dgBoveda_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBoveda.CellDoubleClick
        If dgBoveda.RowCount > 0 Then
            Dim frm As New frmMsBC_Boveda
            frm.Accion = 4
            frm.txtNomBoveda.Text = Me.dgBoveda.Item("Descripcion", Me.dgBoveda.CurrentRow.Index).Value
            frm.txtSaldo.Text = Me.dgBoveda.Item("Saldo", Me.dgBoveda.CurrentRow.Index).Value
            frm.txtMontoMin.Text = Me.dgBoveda.Item("SaldoMin", Me.dgBoveda.CurrentRow.Index).Value
            frm.txtMontoMax.Text = Me.dgBoveda.Item("SaldoMax", Me.dgBoveda.CurrentRow.Index).Value
            frm.cbSucursal.DisplayMember = "Nom_Sucursal"
            frm.cbSucursal.ValueMember = "CodSucursal"
            frm.LlenarCBSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal")
            frm.cbSucursal.SelectedValue = Me.dgBoveda.Item("CodSucursal", Me.dgBoveda.CurrentRow.Index).Value
            frm.ShowDialog()
        End If
    End Sub


    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim frm As New frmMsBC_Boveda
            frm.Accion = 1
            frm.ShowDialog()
            LlenardgBovedas(0, 1, "")
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If dgBoveda.RowCount > 0 Then
                Dim frm As New frmMsBC_Boveda
                frm.Accion = 2
                frm.IdBoveda = Me.dgBoveda.Item("id_Boveda", Me.dgBoveda.CurrentRow.Index).Value
                frm.txtNomBoveda.Text = Me.dgBoveda.Item("Descripcion", Me.dgBoveda.CurrentRow.Index).Value
                frm.txtSaldo.Text = Me.dgBoveda.Item("Saldo", Me.dgBoveda.CurrentRow.Index).Value
                frm.txtMontoMin.Text = Me.dgBoveda.Item("SaldoMin", Me.dgBoveda.CurrentRow.Index).Value
                frm.txtMontoMax.Text = Me.dgBoveda.Item("SaldoMax", Me.dgBoveda.CurrentRow.Index).Value
                'Denominaciones
                frm.c1nUno.Value = Me.dgBoveda.Item("cantidadBilletesUno", Me.dgBoveda.CurrentRow.Index).Value
                frm.c1nCinco.Value = Me.dgBoveda.Item("cantidadBilletesCinco", Me.dgBoveda.CurrentRow.Index).Value
                frm.c1nDiez.Value = Me.dgBoveda.Item("cantidadBilletesDiez", Me.dgBoveda.CurrentRow.Index).Value
                frm.c1nVeinte.Value = Me.dgBoveda.Item("cantidadBilletesVeinte", Me.dgBoveda.CurrentRow.Index).Value
                frm.c1nCincuenta.Value = Me.dgBoveda.Item("cantidadBilletesCincuenta", Me.dgBoveda.CurrentRow.Index).Value
                frm.c1nCien.Value = Me.dgBoveda.Item("cantidadBilletesCien", Me.dgBoveda.CurrentRow.Index).Value
                frm.C1nMonedaUno.Value = Me.dgBoveda.Item("cantidadMonedasUno", Me.dgBoveda.CurrentRow.Index).Value
                frm.c1nFraccion.Value = Me.dgBoveda.Item("MontoMonedaFraccionaria", Me.dgBoveda.CurrentRow.Index).Value

                frm.cbSucursal.DisplayMember = "Nom_Sucursal"
                frm.cbSucursal.ValueMember = "CodSucursal"
                frm.LlenarCBSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal")
                frm.cbSucursal.SelectedValue = Me.dgBoveda.Item("CodSucursal", Me.dgBoveda.CurrentRow.Index).Value
                frm.total()
                frm.ShowDialog()
                LlenardgBovedas(0, 1, "")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If MsgBox("¿Desea eliminar este registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Boveda") = MsgBoxResult.Yes Then
                Dim Resultado As Integer
                Resultado = Bancos.EliminarBcBoveda(Me.dgBoveda.Item("id_Boveda", Me.dgBoveda.CurrentRow.Index).Value, sUsuario, sPassword, sSucursal)
                If Resultado <> 0 Then
                    MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Boveda")
                    LlenardgBovedas(0, 1, "")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try

    End Sub
End Class