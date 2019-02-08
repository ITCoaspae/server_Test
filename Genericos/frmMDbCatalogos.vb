Public Class frmMDbCatalogos
    Dim catalogo As New wrAsociados.wsLibAsoc
    Protected Sub llenarDg(ByVal idCatalogo As Integer, ByVal idTipoCatalogo As Integer, ByVal opcion As Integer)
        Dim dts As New DataSet
        dts = catalogo.consultarDbCatalogosCatalogos(idCatalogo, idTipoCatalogo, opcion)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgCat.DataSource = dts.Tables(0)
                Me.dgCat.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                Me.dgCat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgCat.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End If
        End If
    End Sub
    Protected Sub llenarCbMaestroCat()
        Dim dts As New DataSet
        dts = catalogo.consultarCatalogosTiposCatalogo(0, 1)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbCatalogo.DataSource = dts.Tables(0)

            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMDbCatalogos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbCatalogo.DisplayMember = "descripcion"
        Me.cbCatalogo.ValueMember = "idTipo"
        llenarCbMaestroCat()
        Me.dgCat.Anchor = AnchorStyles.Top
        Me.dgCat.Anchor = AnchorStyles.Left
        Me.dgCat.Anchor = AnchorStyles.Right
        Me.dgCat.Anchor = AnchorStyles.Bottom
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMsDbCatalogos
            With ofrm
                .btnGuardar1.Text = "Guardar"
                .accion = 1
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            If Me.dgCat.RowCount > 0 Then
                Dim ofrm As New frmMsDbCatalogos
                With ofrm
                    .btnGuardar1.Text = "Modificar"
                    .accion = 2
                    .idTipoCat = Me.dgCat.Item("idTipoCatalogo", Me.dgCat.CurrentRow.Index).Value
                    .txtOpcion.Text = Me.dgCat.Item("descripcion", Me.dgCat.CurrentRow.Index).Value
                    .idCatalogo = Me.dgCat.Item("idCatalogo", Me.dgCat.CurrentRow.Index).Value
                    .ShowDialog()
                End With
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.rbMostrarTodos.Checked = False Then
                llenarDg(0, Me.cbCatalogo.SelectedValue, 2)
            Else
                llenarDg(0, 0, 1)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class