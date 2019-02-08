Public Class frmCBGestionMora
    Dim prestamo As New wrPrestamo.wsLibPrest


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frm As New frmCDGestionMora
        With frm
            .accion = 1
            .ShowDialog()
        End With
        llenarDg()
    End Sub

    Private Sub frmCBGestionMora_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDg()
    End Sub

    Protected Sub llenarDg()
        Dim dts As New DataSet
        Dim opt As Integer
        Dim ftr As String
        opt = 1
        ftr = ""

        If rbDUI.Checked Then
            opt = 5
            ftr = txtDui.Text
        End If

        If rbPrestamo.Checked Then
            opt = 4
            ftr = txtPrestamo.Text
        End If

        dts = prestamo.consultarGestionMora(opt, 0, ftr)

        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgServiciosCoopas.DataSource = dts.Tables(0)
                Estilodg()
            End If
        End If


    End Sub

    Public Sub Estilodg()
        Me.dgServiciosCoopas.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
        Me.dgServiciosCoopas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgServiciosCoopas.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgServiciosCoopas.Columns("DUI").HeaderText = "DUI"

        Me.dgServiciosCoopas.Columns("codPrestamo").HeaderText = "Prestamo"
        
        Me.dgServiciosCoopas.Columns("idGestionMora").HeaderText = "Id"
        Me.dgServiciosCoopas.Columns("idGestionMora").Visible = False

        Me.dgServiciosCoopas.Columns("fechaGestion").HeaderText = "Fecha"
        Me.dgServiciosCoopas.Columns("fechaGestion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Me.dgServiciosCoopas.Columns("Descripcion").HeaderText = "Descripción"
        Me.dgServiciosCoopas.Columns("Descripcion").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Me.dgServiciosCoopas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders



        Me.dgServiciosCoopas.Columns("item").HeaderText = "Item Facturable"
        Me.dgServiciosCoopas.Columns("costo").HeaderText = "Costo"
        Me.dgServiciosCoopas.Columns("costo").DefaultCellStyle.Format = "C"
        Me.dgServiciosCoopas.Columns("costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.dgServiciosCoopas.Columns("pagado").HeaderText = "Monto Pagado"
        Me.dgServiciosCoopas.Columns("pagado").DefaultCellStyle.Format = "C"
        Me.dgServiciosCoopas.Columns("pagado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.dgServiciosCoopas.Columns("perdonado").HeaderText = "Monto Perdonado"
        Me.dgServiciosCoopas.Columns("perdonado").DefaultCellStyle.Format = "C"
        Me.dgServiciosCoopas.Columns("perdonado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.dgServiciosCoopas.Columns("activo").HeaderText = "Estado"
      
        Me.dgServiciosCoopas.Columns("codItem").Visible = False

        Me.dgServiciosCoopas.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgServiciosCoopas.Columns("item").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

    End Sub


    Private Sub btnMostrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        llenarDg()
    End Sub

    Private Sub rbDUI_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDUI.CheckedChanged
        If rbDUI.Checked Then
            If txtPrestamo.Enabled Then
                txtPrestamo.Text = ""
                txtPrestamo.Enabled = False
            End If
            txtDui.Enabled = True
        End If
    End Sub

    Private Sub rbPrestamo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPrestamo.CheckedChanged
        If rbPrestamo.Checked Then
            If txtDui.Enabled Then
                txtDui.Text = ""
                txtDui.Enabled = False
            End If
            txtPrestamo.Enabled = True
        End If
    End Sub

    Private Sub rbTodos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbTodos.CheckedChanged
        If rbTodos.Checked Then
            If txtDui.Enabled Then
                txtDui.Text = ""
                txtDui.Enabled = False
            End If
            If txtPrestamo.Enabled Then
                txtPrestamo.Text = ""
                txtPrestamo.Enabled = False
            End If
            txtPrestamo.Enabled = False
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim frm As New frmCDGestionMora
        With frm
            .accion = 2
            .txtCantidad.Value = Me.dgServiciosCoopas.Item("cantidad", Me.dgServiciosCoopas.CurrentRow.Index).Value
            .txtCodPrestamo.Text = Me.dgServiciosCoopas.Item("codPrestamo", Me.dgServiciosCoopas.CurrentRow.Index).Value
            .txtCosto.Value = Me.dgServiciosCoopas.Item("costo", Me.dgServiciosCoopas.CurrentRow.Index).Value
            .txtDescItemFact.Text = Me.dgServiciosCoopas.Item("item", Me.dgServiciosCoopas.CurrentRow.Index).Value
            .txtCodItem.Text = Me.dgServiciosCoopas.Item("codItem", Me.dgServiciosCoopas.CurrentRow.Index).Value
            .txtPagado.Value = Me.dgServiciosCoopas.Item("pagado", Me.dgServiciosCoopas.CurrentRow.Index).Value
            .txtPerdonado.Value = Me.dgServiciosCoopas.Item("perdonado", Me.dgServiciosCoopas.CurrentRow.Index).Value
            .dtpFechaGestion.Value = Me.dgServiciosCoopas.Item("fechaGestion", Me.dgServiciosCoopas.CurrentRow.Index).Value
            .txtDescripcion.Text = Me.dgServiciosCoopas.Item("Descripcion", Me.dgServiciosCoopas.CurrentRow.Index).Value
            .idGestion = Me.dgServiciosCoopas.Item("idGestionMora", Me.dgServiciosCoopas.CurrentRow.Index).Value
            .ShowDialog()
        End With
        llenarDg()
    End Sub

    Private Sub btnAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Dim resultado As Integer
        Dim idGestionMora As Integer

        idGestionMora = Me.dgServiciosCoopas.Item("idGestionMora", Me.dgServiciosCoopas.CurrentRow.Index).Value

        resultado = prestamo.AnularGestionMora(idGestionMora, sUsuario, sPassword, sSucursal)

        If resultado < 0 Then
            MsgBox("No tiene permiso para anular", MsgBoxStyle.Information, "Módulo - Prestamos")
        ElseIf resultado > 0 Then
            MsgBox("Gestion anulada exitosamente", MsgBoxStyle.Information, "Módulo - Prestamos")
            llenarDg()
        Else
            MsgBox("El Registro no fue actualizado.", MsgBoxStyle.Exclamation, "Módulo - Prestamos")
        End If
    End Sub
End Class