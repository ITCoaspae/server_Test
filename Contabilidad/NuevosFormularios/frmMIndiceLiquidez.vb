Public Class frmMIndiceLiquidez
    Dim contabilidad As New wrConta.wsLibContab
#Region "Metodos"

    Protected Sub llenarDg()
        Dim dts As New DataSet
        If chkTodos.Checked = True Then
            dts = contabilidad.consultarContaIndiceLiquidez(0, 0, 1)
        Else
            dts = contabilidad.consultarContaIndiceLiquidez(0, nudAnnio.Value, 3)
        End If
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgLiquidez.DataSource = dts.Tables(0)
            End If
        End If
        estiloDg()
    End Sub
    Protected Sub estiloDg()
        Me.dgLiquidez.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
        Me.dgLiquidez.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgLiquidez.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgLiquidez.Columns("correlativo").Visible = False
        Me.dgLiquidez.Columns("annio").HeaderText = "Año"
        Me.dgLiquidez.Columns("mes").HeaderText = "Mes"
        Me.dgLiquidez.Columns("indice").HeaderText = "Indice"
        Me.dgLiquidez.Columns("usuarioActu").HeaderText = "Usuario"
        Me.dgLiquidez.Columns("fechaActu").HeaderText = "Fecha de actualización"

        Me.dgLiquidez.Columns("annio").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgLiquidez.Columns("mes").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgLiquidez.Columns("indice").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgLiquidez.Columns("usuarioActu").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgLiquidez.Columns("fechaActu").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells


    End Sub
#End Region
#Region "Eventos"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        llenarDg()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frm As New frmMsIndiceLiquidez
        With frm
            .accion = 1
            .btnGuardar.Text = "Guardar"
            .btnCerrar.Text = "Cerrar"
            .lblEncabezado.Text = "Ingresar Indice de Liquidez"
            .ShowDialog()
        End With
        llenarDg()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.dgLiquidez.RowCount > 0 Then
            If Me.dgLiquidez.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsIndiceLiquidez
                With frm
                    .accion = 2
                    .btnGuardar.Text = "Modificar"
                    .btnCerrar.Text = "Cerrar"
                    .lblEncabezado.Text = "Modificar Indice de Liquidez"
                    .id = Me.dgLiquidez.Item("correlativo", Me.dgLiquidez.CurrentRow.Index).Value
                    .nudAnnio.Value = Me.dgLiquidez.Item("annio", Me.dgLiquidez.CurrentRow.Index).Value
                    .cbMes.SelectedIndex = Me.dgLiquidez.Item("mes", Me.dgLiquidez.CurrentRow.Index).Value - 1
                    .txtIndice.Value = Me.dgLiquidez.Item("indice", Me.dgLiquidez.CurrentRow.Index).Value
                    .ShowDialog()
                End With
                llenarDg()
            End If
        End If
    End Sub
    Private Sub dgLiquidez_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgLiquidez.CellMouseDoubleClick
        If Me.dgLiquidez.RowCount > 0 Then
            If Me.dgLiquidez.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsIndiceLiquidez
                With frm
                    .accion = 2
                    .btnGuardar.Text = "Modificar"
                    .btnCerrar.Text = "Cerrar"
                    .lblEncabezado.Text = "Modificar Indice de Liquidez"
                    .id = Me.dgLiquidez.Item("correlativo", Me.dgLiquidez.CurrentRow.Index).Value
                    .nudAnnio.Value = Me.dgLiquidez.Item("annio", Me.dgLiquidez.CurrentRow.Index).Value
                    .cbMes.SelectedIndex = Me.dgLiquidez.Item("mes", Me.dgLiquidez.CurrentRow.Index).Value - 1
                    .txtIndice.Value = Me.dgLiquidez.Item("indice", Me.dgLiquidez.CurrentRow.Index).Value
                    .Show(Me)
                End With
                llenarDg()
            End If
        End If
    End Sub
#End Region
    
    
End Class