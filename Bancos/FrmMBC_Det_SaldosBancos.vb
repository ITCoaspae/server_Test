Public Class FrmMBC_Det_SaldosBancos
    Dim Bancos As New wrBancos.wsLibBancos
    Public Sub LlenarCBBancos(ByVal Campos As String, ByVal Orden As String, ByVal Usuario As String, ByVal Pwd As String, ByVal Psucursal As String)
        Dim Dts As New DataSet
        Dts = Bancos.ObtenerCuentaBanco(Campos, "", Orden, Usuario, Pwd, Psucursal)
        Me.cbBancos.DataSource = Dts.Tables(0)
    End Sub
    Public Sub LlenarDg(ByVal Id_DetSalBancos As Integer, ByVal Opcion As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, _
                              ByVal IdMovimiento As String, ByVal IdCtaBanco As String, ByVal Origen As Char)
        Dim Dts As New DataSet
        Dts = Bancos.ConsultarBCDet_SaldosBancos(Id_DetSalBancos, Opcion, FechaInicio, FechaFin, IdMovimiento, IdCtaBanco, Origen)
        Me.DataGridView1.DataSource = Dts.Tables(0)
        'Dim btnColumn As New DataGridViewButtonColumn
        'btnColumn.Name = "Anular"
        'btnColumn.UseColumnTextForButtonValue = True
        'btnColumn.Text = "Anular"
        'btnColumn.FlatStyle = FlatStyle.System
        'btnColumn.Width = 50
        'btnColumn.DefaultCellStyle.ForeColor = Color.Red
        'btnColumn.HeaderText = "Anular Registro"
        'Me.DataGridView1.Columns.Add(btnColumn)
        HeaderDg()
    End Sub
    Public Sub HeaderDg()
        Me.DataGridView1.Columns("Id_DetSalBancos").Visible = False
        Me.DataGridView1.Columns("IdMovimiento").HeaderText = "Id. Movimiento"
        Me.DataGridView1.Columns("Id_SaldosBancos").Visible = False
        Me.DataGridView1.Columns("IdCtaBanco").HeaderText = "Cta. Banco"
        Me.DataGridView1.Columns("CodTransaccion").HeaderText = "Cod. de Transacción"
        Me.DataGridView1.Columns("Monto").HeaderText = "Monto"
        Me.DataGridView1.Columns("FechaTran").HeaderText = "Fecha del Movimiento"
        Me.DataGridView1.Columns("Saldo_Ant").HeaderText = "Saldo Anterior"
        Me.DataGridView1.Columns("Saldo_Actu").HeaderText = "Saldo Actual"
        Me.DataGridView1.Columns("Hora").HeaderText = "Hora del Movimiento"
        Me.DataGridView1.Columns("Usuario").HeaderText = "Usuario"
        Me.DataGridView1.Columns("CodSucursal").HeaderText = "Cod. Sucursal"
        Me.DataGridView1.Columns("ORIGEN").HeaderText = "Origen"

        Me.DataGridView1.Columns("Id_DetSalBancos").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("IdMovimiento").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("Id_SaldosBancos").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("IdCtaBanco").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("CodTransaccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("Monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("FechaTran").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("Saldo_Ant").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("Saldo_Actu").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("Hora").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("Usuario").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("CodSucursal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("FechaTran").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke


    End Sub
    Private Sub FrmMBC_Det_SaldosBancos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarDg(0, 1, Now, Now, "", "", "")
        Me.cbBancos.DisplayMember = "NOM_Cuenta"
        Me.cbBancos.ValueMember = "IdCtaBanco"
        LlenarCBBancos("IdCtaBanco,NOM_Cuenta", "Nom_Banco", sUsuario, sPassword, sSucursal)
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.rbBanco.Checked = True Then
            LlenarDg(0, 4, Now, Now, "", Me.cbBancos.SelectedValue, "")
        ElseIf Me.rbFecha.Checked = True Then
            LlenarDg(0, 3, Format(Me.dtpFechaInicio.Value, "SHORT DATE"), Format(Me.dtpFechaFin.Value, "SHORT DATE"), "", Me.cbBancos.SelectedValue, "")
        ElseIf Me.rbMov.Checked = True Then
            LlenarDg(0, 6, Format(Me.dtpFechaInicio.Value, "SHORT DATE"), Format(Me.dtpFechaFin.Value, "SHORT DATE"), Me.txtIdMov.Text.Trim, Me.cbBancos.SelectedValue, "")
        ElseIf Me.rbOrigen.Checked = True Then
            LlenarDg(0, 5, Format(Me.dtpFechaInicio.Value, "SHORT DATE"), Format(Me.dtpFechaFin.Value, "SHORT DATE"), Me.txtIdMov.Text.Trim, Me.cbBancos.SelectedValue, Me.cbOrigen.SelectedValue)
        Else
            LlenarDg(0, 1, Now, Now, "", "", "")
        End If
    End Sub
    Private Sub btnAgregarMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMov.Click
        If MsgBox("Esta opción solo permite ingresar remesas" & vbCrLf & "¿Desea continuar con esta acción?", MsgBoxStyle.YesNo, "Módulo - Contabilidad") = 6 Then
            Dim frm As New frmMsBC_Det_SaldosBancos
            frm.ShowDialog()
        End If
    End Sub
    Private Sub rbBanco_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbBanco.CheckedChanged
        If Me.rbBanco.Checked = True Then
            Me.cbBancos.Enabled = True
            Me.txtIdMov.Enabled = False
            Me.cbOrigen.Enabled = False
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFin.Enabled = False
        End If
    End Sub
    Private Sub rbFecha_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFecha.CheckedChanged
        If Me.rbFecha.Checked = True Then
            Me.cbBancos.Enabled = False
            Me.txtIdMov.Enabled = False
            Me.cbOrigen.Enabled = False
            Me.dtpFechaInicio.Enabled = True
            Me.dtpFechaFin.Enabled = True
        End If
    End Sub
    Private Sub rbMostrarTodos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbMostrarTodos.CheckedChanged
        If Me.rbMostrarTodos.Checked = True Then
            Me.cbBancos.Enabled = False
            Me.txtIdMov.Enabled = False
            Me.cbOrigen.Enabled = False
            Me.dtpFechaInicio.Enabled = True
            Me.dtpFechaFin.Enabled = True
        End If
    End Sub
    Private Sub rbMov_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbMov.CheckedChanged
        If Me.rbMov.Checked = True Then
            Me.cbBancos.Enabled = False
            Me.txtIdMov.Enabled = True
            Me.cbOrigen.Enabled = False
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFin.Enabled = False
        End If
    End Sub
    Private Sub rbOrigen_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOrigen.CheckedChanged
        If Me.rbOrigen.Checked = True Then
            Me.cbBancos.Enabled = False
            Me.txtIdMov.Enabled = False
            Me.cbOrigen.Enabled = True
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFin.Enabled = False
        End If
    End Sub
    'Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    If Me.DataGridView1.CurrentRow.Index <> -1 Then
    '        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "Anular" Then
    '            If MsgBox("Desea anular esta transacción", MsgBoxStyle.YesNo, "Prueba") = 6 Then

    '            End If
    '        End If
    '    End If
    'End Sub
End Class