Public Class frmMCaTiposDocumetos
    Dim caja As New wrCaja.wsLibCaja
    Dim asociados As New wrAsociados.wsLibAsoc
#Region "Metodos"
    Protected Sub llenarDgTipoDocs(ByVal activo As Boolean, ByVal idTipoDoc As Integer, ByVal opcion As Integer)
        Dim dts As New DataSet
        dts = caja.consultarCaMaestrosTipoDocumentos(opcion, activo, idTipoDoc)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgTipoDocs.DataSource = dts.Tables(0)
                estiloDg()
            End If
        End If
    End Sub
    Protected Sub estiloDg()
        Me.dgTipoDocs.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgTipoDocs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgTipoDocs.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgTipoDocs.Columns("idTipoDoc").HeaderText = "Id. Tipo de Documento"
        Me.dgTipoDocs.Columns("tipoDocumento").HeaderText = "Tipo de Documento"
        Me.dgTipoDocs.Columns("abrev").HeaderText = "Tipo"
        Me.dgTipoDocs.Columns("activo").HeaderText = "Activo"

    End Sub
#End Region
#Region "Funciones"
    Protected Function DesactivarTipoDoc(ByVal activo As Boolean, ByVal idTipoDoc As Integer) As Integer
        Dim resultado As Integer
        resultado = caja.desactivarCaMaestroTipoDocumentos(activo, idTipoDoc)
        Return resultado
    End Function
#End Region
#Region "Eventos"
    Private Sub frmMCaTiposDocumetos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDgTipoDocs(True, 0, 1)
    End Sub


    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim ofrm As New frmMsCaTiposDocumentos
            With ofrm
                .accion = 1
                .ShowDialog()
            End With
            llenarDgTipoDocs(True, 0, 1)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim ofrm As New frmMsCaTiposDocumentos
            With ofrm
                .accion = 2
                .idTipoDoc = Me.dgTipoDocs.Item("idTipoDoc", Me.dgTipoDocs.CurrentRow.Index).Value
                .txtTipoDoc.Text = Me.dgTipoDocs.Item("tipoDocumento", Me.dgTipoDocs.CurrentRow.Index).Value
                .txtAbrev.Text = Me.dgTipoDocs.Item("abrev", Me.dgTipoDocs.CurrentRow.Index).Value
                .rbActivo.Checked = IIf(Me.dgTipoDocs.Item("Activo", Me.dgTipoDocs.CurrentRow.Index).Value = True, True, False)
                .rbInactivo.Checked = IIf(Me.dgTipoDocs.Item("Activo", Me.dgTipoDocs.CurrentRow.Index).Value = True, False, True)
                .btnGuardar.Text = "Modificar"
                .ShowDialog()
            End With
            llenarDgTipoDocs(True, 0, 1)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If Me.dgTipoDocs.CurrentRow.Index <> -1 Then
                If MsgBox("¿ Desea desactivar este tipo de documento ? ", MsgBoxStyle.YesNo, "Módulo - Caja") = MsgBoxResult.Yes Then
                    DesactivarTipoDoc(False, Me.dgTipoDocs.Item("idTipoDoc", Me.dgTipoDocs.CurrentRow.Index).Value)
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgTipoDocs_DoubleClick(sender As Object, e As EventArgs) Handles dgTipoDocs.DoubleClick
        Try
            Dim ofrm As New frmMsCaTiposDocumentos
            With ofrm
                .accion = 2
                .idTipoDoc = Me.dgTipoDocs.Item("idTipoDoc", Me.dgTipoDocs.CurrentRow.Index).Value
                .txtTipoDoc.Text = Me.dgTipoDocs.Item("tipoDocumento", Me.dgTipoDocs.CurrentRow.Index).Value
                .txtAbrev.Text = Me.dgTipoDocs.Item("abrev", Me.dgTipoDocs.CurrentRow.Index).Value
                .rbActivo.Checked = IIf(Me.dgTipoDocs.Item("Activo", Me.dgTipoDocs.CurrentRow.Index).Value = True, True, False)
                .rbInactivo.Checked = IIf(Me.dgTipoDocs.Item("Activo", Me.dgTipoDocs.CurrentRow.Index).Value = True, False, True)
                .txtTipoDoc.ReadOnly = True
                .txtAbrev.ReadOnly = True
                .rbActivo.Enabled = False
                .rbInactivo.Enabled = False
                .btnGuardar.Visible = False
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


#End Region

End Class