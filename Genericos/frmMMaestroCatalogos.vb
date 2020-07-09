Public Class frmMMaestroCatalogos
    Dim catalogo As New wrAsociados.wsLibAsoc
    Public Sub llenarDg()
        Dim dts As New DataSet
        dts = catalogo.consultarCatalogosTiposCatalogo(0, 1)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgMaestro.DataSource = dts.Tables(0)
                Me.dgMaestro.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                Me.dgMaestro.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgMaestro.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End If
        End If
    End Sub
    Private Sub frmMMaestroCatalogos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDg()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim frm As New frmMsMaestroCatalogos
            With frm
                .accion = 1
                .Text = "Ingresar Catalogo"
                .btnGuardar1.Text = "Guardar"
                .ShowDialog()
            End With
            llenarDg()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim frm As New frmMsMaestroCatalogos
            With frm
                .Text = "Modificar Catalogo"
                .btnGuardar1.Text = "Modificar"
                .accion = 2
                .idCatalogo = Me.dgMaestro.Item("idTipo", Me.dgMaestro.CurrentRow.Index).Value
                .txtCat.Text = Me.dgMaestro.Item("descripcion", Me.dgMaestro.CurrentRow.Index).Value
                .ShowDialog()
            End With
            llenarDg()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class