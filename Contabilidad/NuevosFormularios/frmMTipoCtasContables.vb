Public Class frmMTipoCtasContables
    Dim contabilidad As New wrConta.wsLibContab
    Protected Sub llenarDg()
        Try
            Dim dts As New DataSet
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    dts = contabilidad.consultarCat_TipoCtas_Contables("", "", sUsuario)
                End If
            End If


        Catch ex As Exception
            MsgBox("Error al cargar los datos, por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Contabilidad")
        End Try
    End Sub

    Private Sub frmMTipoCtasContables_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDg()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim frm As New frmMsTipoCtasContables
            With frm
                .accion = 1
                .ShowDialog()
            End With
            llenarDg()
        Catch ex As Exception
            MsgBox("Error al cargar los datos, por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Contabilidad")
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim frm As New frmMsTipoCtasContables
        Try
            If Me.dgTipoCuenta.CurrentRow.Index > -1 Then
                With frm
                    .accion = 2
                    .btnGuardar.Text = "Modificar"
                    .txtTipoCuenta.Text = Me.dgTipoCuenta.Item("Tipo_Cuenta", Me.dgTipoCuenta.CurrentRow.Index).Value
                    .txtDescripcion.Text = Me.dgTipoCuenta.Item("Descripcion", Me.dgTipoCuenta.CurrentRow.Index).Value
                    .ShowDialog()
                End With
                llenarDg()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos, por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Contabilidad")
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.dgTipoCuenta.CurrentRow.Index > -1 Then
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Contabilidad") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = contabilidad.eliminarCat_TipoCtas_Contables(Me.dgTipoCuenta.Item("Tipo_Cuenta", Me.dgTipoCuenta.CurrentRow.Index).Value, sUsuario)
                    If resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Contabilidad")
                    Else
                        MsgBox("El registro no pudo ser eliminado. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Contabilidad")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error" + ex.Message, MsgBoxStyle.Critical, "Módulo - Contabilidad")
        End Try
        
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim frm As New frmMsTipoCtasContables
        Try
            If Me.dgTipoCuenta.CurrentRow.Index > -1 Then
                With frm
                    .accion = 3
                    .btnGuardar.Enabled = False
                    .txtTipoCuenta.Text = Me.dgTipoCuenta.Item("Tipo_Cuenta", Me.dgTipoCuenta.CurrentRow.Index).Value
                    .txtDescripcion.Text = Me.dgTipoCuenta.Item("Descripcion", Me.dgTipoCuenta.CurrentRow.Index).Value
                    .ShowDialog()
                End With
                llenarDg()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos, por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Contabilidad")
        End Try
    End Sub

    Private Sub dgTipoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTipoCuenta.DoubleClick
        Dim frm As New frmMsTipoCtasContables
        Try
            If Me.dgTipoCuenta.CurrentRow.Index > -1 Then
                With frm
                    .accion = 3
                    .btnGuardar.Enabled = False
                    .txtTipoCuenta.Text = Me.dgTipoCuenta.Item("Tipo_Cuenta", Me.dgTipoCuenta.CurrentRow.Index).Value
                    .txtDescripcion.Text = Me.dgTipoCuenta.Item("Descripcion", Me.dgTipoCuenta.CurrentRow.Index).Value
                    .ShowDialog()
                End With
                llenarDg()
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos, por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Contabilidad")
        End Try
    End Sub
End Class