Public Class frmMCaTipoMovCaja
    Dim caja As New wrCaja.wsLibCaja
    Dim bancos As New wrBancos.wsLibBancos
#Region "Metodos"
    Protected Sub llenarDgCaTipoMovCaja(ByVal opcion As Integer, ByVal idTipoMovCaja As Integer, ByVal codTransaccion As Integer)

        Dim dts As New DataSet
        Try
            dts = caja.consultarCaTipoMovCaja(opcion, idTipoMovCaja, codTransaccion, _
                                          sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.dgCatTipoMovCaja.DataSource = dts.Tables(0)
                    estidoDg()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "Módulo - Caja")
        End Try
    End Sub
    Protected Sub llenarcbTransacciones(ByVal opcion As Integer, ByVal codTransaccion As Integer)
        Dim dts As New DataSet
        dts = bancos.ConsultarBCCatTransacciones_Boveda(opcion, codTransaccion)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTransacciones.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub estidoDg()
        Me.dgCatTipoMovCaja.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgCatTipoMovCaja.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgCatTipoMovCaja.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgCatTipoMovCaja.Columns("CodTransaccion").Visible = False
        Me.dgCatTipoMovCaja.Columns("idTipoMovCaja").HeaderText = "Id"

        Me.dgCatTipoMovCaja.Columns("idTipoMovCaja").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCatTipoMovCaja.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCatTipoMovCaja.Columns("TipoTransaccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

    End Sub
#End Region
#Region "Funciones"
    Protected Function eliminar(ByVal idTipoMovCaja As Integer) As Integer
        Try
            Dim resultado As Integer
            resultado = caja.eliminarCaTipoMovCaja(idTipoMovCaja, sUsuario, sPassword, sSucursal)
            If resultado <> 0 Then
                MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Caja")
            Else
                MsgBox("El registro no pudo ser eliminado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Caja")
            End If
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Information, "Módulo - Caja")
        End Try
    End Function
#End Region
#Region "Eventos"
    Private Sub frmMCaTipoMovCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbTransacciones.DisplayMember = "Descripcion"
        Me.cbTransacciones.ValueMember = "CodTransaccion"
        llenarcbTransacciones(1, 0)

    End Sub
    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If Me.rbMostrarTodos.Checked = True Then
                llenarDgCaTipoMovCaja(1, 0, 0)
            ElseIf Me.rbMostrarTodos.Checked = True Then
                llenarDgCaTipoMovCaja(2, 0, Me.cbTransacciones.SelectedValue)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim frm As New frmMsCaTipoMovCaja
            With frm
                .accion = 1
                .btnGuardar.Text = "Guardar"
                .ShowDialog()
            End With
            If Me.rbMostrarTodos.Checked = True Then
                llenarDgCaTipoMovCaja(1, 0, 0)
            ElseIf Me.rbMostrarTodos.Checked = True Then
                llenarDgCaTipoMovCaja(2, 0, Me.cbTransacciones.SelectedValue)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim frm As New frmMsCaTipoMovCaja
            With frm
                .accion = 2
                .btnGuardar.Text = "Modificar"
                .cbTransacciones.DisplayMember = "Descripcion"
                .cbTransacciones.ValueMember = "CodTransaccion"
                .llenarcbTransacciones(1, 0)
                .cbTransacciones.SelectedValue = Me.dgCatTipoMovCaja.Item("idTipoMovCaja", Me.dgCatTipoMovCaja.CurrentRow.Index).Value
                .idTipoMovCaja = Me.dgCatTipoMovCaja.Item("idTipoMovCaja", Me.dgCatTipoMovCaja.CurrentRow.Index).Value
                .txtTipoMov.Text = Me.dgCatTipoMovCaja.Item("Descripcion", Me.dgCatTipoMovCaja.CurrentRow.Index).Value
                .ShowDialog()
            End With
            If Me.rbMostrarTodos.Checked = True Then
                llenarDgCaTipoMovCaja(1, 0, 0)
            ElseIf Me.rbMostrarTodos.Checked = True Then
                llenarDgCaTipoMovCaja(2, 0, Me.cbTransacciones.SelectedValue)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim resultado As Integer
            If Me.dgCatTipoMovCaja.CurrentRow.Index <> -1 Then
                If MsgBox("¿Desea eliminar este registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Caja") = MsgBoxResult.Yes Then
                    resultado = eliminar(Me.dgCatTipoMovCaja.Item("idTipoMovCaja", Me.dgCatTipoMovCaja.CurrentRow.Index).Value)
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmMCaTipoMovCaja_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub


#End Region


End Class