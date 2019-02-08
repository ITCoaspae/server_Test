Public Class frmMsAhMovimientosFlotantes
    Dim ahorros As New wsSysFinCoop.LibAhorro.wsLibAhorro
    Dim asociados As New wsSysFinCoop.LibAsoc.wsLibAsoc
    Protected Sub buscarAhMovimientosFlotantes()
        Dim opcion As Integer = 0
        If chkFecha.Checked = True And chkSucursal.Checked = False And chkNoCta.Checked = False Then
            opcion = 1
            llenarDgMoimientosFlotantes(opcion, Format(Me.dtpFecha.Value, "short date"), "", "")
        ElseIf chkFecha.Checked = False And chkSucursal.Checked = True And chkNoCta.Checked = False Then
            opcion = 2
            llenarDgMoimientosFlotantes(opcion, Format(Me.dtpFecha.Value, "short date"), Me.cbSucursal.SelectedValue, "")
        ElseIf chkFecha.Checked = False And chkSucursal.Checked = False And chkNoCta.Checked = True Then
            opcion = 3
            llenarDgMoimientosFlotantes(opcion, Format(Me.dtpFecha.Value, "short date"), "", txtNoCta.Text.Trim)
        ElseIf chkFecha.Checked = True And chkSucursal.Checked = True And chkNoCta.Checked = False Then
            opcion = 4
            llenarDgMoimientosFlotantes(opcion, Format(Me.dtpFecha.Value, "short date"), Me.cbSucursal.SelectedValue, txtNoCta.Text.Trim)
        ElseIf chkMostrarTodos.Checked = True Then
            opcion = 5
            llenarDgMoimientosFlotantes(opcion, Format(Me.dtpFecha.Value, "short date"), Me.cbSucursal.SelectedValue, txtNoCta.Text.Trim)
        End If
    End Sub
    Public Sub LlenarCBSucursales(ByVal Campos As String, ByVal Filtro As String, ByVal Orden As String)
        Dim Dts As New DataSet
        Dts = asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
        Me.cbSucursal.DisplayMember = "Nom_Sucursal"
        Me.cbSucursal.ValueMember = "codSucursal"
        Me.cbSucursal.DataSource = Dts.Tables(0)
    End Sub
    Public Sub llenarDgMoimientosFlotantes(ByVal opcion As Integer, ByVal fecha As DateTime, ByVal codSucursal As String, ByVal nocuenta As String)
        If Me.dgMovimientosFlotantes.Rows.Count > 0 Then
            Me.dgMovimientosFlotantes.Columns.Remove("liberar")
            Me.dgMovimientosFlotantes.DataSource = Nothing
        End If
        Dim dts As New DataSet
        dts = ahorros.consultarAhMovimientosFlotantes(fecha, codSucursal, nocuenta, opcion)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgMovimientosFlotantes.DataSource = dts.Tables(0)
                Dim btnColumnEliminar As New DataGridViewButtonColumn
                With btnColumnEliminar
                    .UseColumnTextForButtonValue = True
                    '.DefaultCellStyle.BackColor = Color.SteelBlue
                    .DefaultCellStyle.ForeColor = Color.Red
                    .Text = "Liberar Movimiento"
                    .Name = "liberar"
                    .HeaderText = "Liberar Movimiento"
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End With
                Me.dgMovimientosFlotantes.Columns.Add(btnColumnEliminar)
                estiloDgMovimientosFlotantes()
            End If
        End If
    End Sub
    Protected Sub estiloDgMovimientosFlotantes()
        Me.dgMovimientosFlotantes.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
        Me.dgMovimientosFlotantes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgMovimientosFlotantes.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgMovimientosFlotantes.Columns("correlativo").Visible = False
        Me.dgMovimientosFlotantes.Columns("noCuenta").HeaderText = "No. Cuenta"
        Me.dgMovimientosFlotantes.Columns("monto").HeaderText = "Monto"
        Me.dgMovimientosFlotantes.Columns("idMovimiento").HeaderText = "Id. Movimiento"
        Me.dgMovimientosFlotantes.Columns("estado").HeaderText = "Estado"
        Me.dgMovimientosFlotantes.Columns("asociado").HeaderText = "Nombre Asociado"
        Me.dgMovimientosFlotantes.Columns("fechaMov").HeaderText = "Fecha de Movimiento"
        Me.dgMovimientosFlotantes.Columns("Nom_Sucursal").HeaderText = "Sucursal"
        Me.dgMovimientosFlotantes.Columns("asociado").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgMovimientosFlotantes.Columns("noCuenta").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgMovimientosFlotantes.Columns("Nom_Sucursal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub chkFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFecha.Click
        If chkFecha.Checked = True Then
            Me.dtpFecha.Enabled = True
        Else
            Me.dtpFecha.Enabled = False
        End If
    End Sub

    Private Sub chkSucursal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSucursal.Click
        If chkSucursal.Checked = True Then
            Me.cbSucursal.Enabled = True
        Else
            Me.cbSucursal.Enabled = False
        End If
    End Sub

    Private Sub chkNoCta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNoCta.Click
        If chkNoCta.Checked = True Then
            Me.txtNoCta.Enabled = True
        Else
            Me.txtNoCta.Enabled = False
        End If
    End Sub


    Private Sub chkMostrarTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMostrarTodos.Click
        If Me.chkMostrarTodos.Checked = True Then
            Me.chkFecha.Enabled = False
            Me.chkNoCta.Enabled = False
            Me.chkSucursal.Enabled = False
            Me.dtpFecha.Enabled = False
            Me.txtNoCta.Enabled = False
            Me.cbSucursal.Enabled = False
            chkFecha.Checked = False
            chkNoCta.Checked = False
            chkSucursal.Checked = False
        Else
            Me.chkFecha.Enabled = True
            Me.chkNoCta.Enabled = True
            Me.chkSucursal.Enabled = True

        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        buscarAhMovimientosFlotantes()
    End Sub

    Private Sub frmMsAhMovimientosFlotantes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarCBSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal")
    End Sub

    Private Sub dgMovimientosFlotantes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMovimientosFlotantes.CellClick
        Try
            Dim noCuenta As String = ""
            Dim correlativo As Integer = 0
            Dim resultado As Integer = 0
            Dim estado As Boolean
            If Me.dgMovimientosFlotantes.CurrentRow.Index >= 0 Then
                estado = Me.dgMovimientosFlotantes.Item("estado", Me.dgMovimientosFlotantes.CurrentRow.Index).Value
                If Me.dgMovimientosFlotantes.Columns(e.ColumnIndex).Name = "liberar" And estado = True Then
                    noCuenta = Me.dgMovimientosFlotantes.Item("noCuenta", Me.dgMovimientosFlotantes.CurrentRow.Index).Value
                    correlativo = Me.dgMovimientosFlotantes.Item("correlativo", Me.dgMovimientosFlotantes.CurrentRow.Index).Value
                    If MsgBox("¿Desea liberar los fondos para la cuenta no: " & noCuenta & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Asociados") = MsgBoxResult.Yes Then
                        resultado = ahorros.anularAhMovimientosFlotantes(correlativo, sUsuario)
                        If resultado > 0 Then
                            MsgBox("Fondos liberados exitosamente.", MsgBoxStyle.Information, "Módulo - Ahorros")
                            buscarAhMovimientosFlotantes()
                        Else
                            MsgBox("Los fondos no pudieron ser liberados, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Ahorros")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
      
    End Sub
End Class