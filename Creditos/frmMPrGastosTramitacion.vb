Public Class frmMPrGastosTramitacion
    Dim Creditos As New wrCredito.wsLibCred
    Private Sub LlenarDg(ByVal Opcion As Integer, ByVal Id_CatGastos_Tramitacion As Integer, ByVal Idcuenta As String)
        Dim Dts As New DataSet
        Dts = Creditos.Consultar_PrCatGastosTramitacion(1, Id_CatGastos_Tramitacion, Idcuenta)
        Me.dgGastosTramitacion.DataSource = Dts.Tables(0)
        EncabezadoDg()
    End Sub
    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub frmMPrGastosTramitacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarDg(0, 0, "0")
    End Sub
    Private Sub btnIngresar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub EncabezadoDg()
        Me.dgGastosTramitacion.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgGastosTramitacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgGastosTramitacion.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgGastosTramitacion.Columns("Id_CatGastos_Tramitacion").Visible = False
        Me.dgGastosTramitacion.Columns("IdCuenta").Visible = False
        Me.dgGastosTramitacion.Columns("IdCuenta").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgGastosTramitacion.Columns("Id_CatGastos_Tramitacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim ofrm As New frmMsPrGastosTramitacion
            ofrm.accion = 1
            'ofrm.btnGuardar.Text = "Guardar"
            ofrm.ShowDialog()
            LlenarDg(0, 0, "0")
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If Me.dgGastosTramitacion.CurrentRow.Index <> -1 Then
                Dim ofrm As New frmMsPrGastosTramitacion
                ofrm.accion = 2
                'ofrm.btnGuardar.Text = "Modificar"
                ofrm.Id_CatGastos_Tramitacion = Me.dgGastosTramitacion.Item("Id_CatGastos_Tramitacion", Me.dgGastosTramitacion.CurrentRow.Index).Value
                ofrm.txtDescripcion.Text = Me.dgGastosTramitacion.Item("GastosTramitacion", Me.dgGastosTramitacion.CurrentRow.Index).Value.ToString.Trim
                ofrm.txtIdCtaContable.Text = Me.dgGastosTramitacion.Item("IdCuenta", Me.dgGastosTramitacion.CurrentRow.Index).Value.ToString.Trim
                ofrm.txtCuenta.Text = Me.dgGastosTramitacion.Item("CtaContable", Me.dgGastosTramitacion.CurrentRow.Index).Value.ToString.Trim
                ofrm.chkMin.Checked = Me.dgGastosTramitacion.Item("ValMontoMin", Me.dgGastosTramitacion.CurrentRow.Index).Value
                ofrm.chkMax.Checked = Me.dgGastosTramitacion.Item("ValMontoMax", Me.dgGastosTramitacion.CurrentRow.Index).Value
                ofrm.txtMin.Value = Me.dgGastosTramitacion.Item("MontoMinimo", Me.dgGastosTramitacion.CurrentRow.Index).Value
                ofrm.txtMax.Value = Me.dgGastosTramitacion.Item("MontoMaximo", Me.dgGastosTramitacion.CurrentRow.Index).Value
                ofrm.ShowDialog()
                LlenarDg(0, 0, "0")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        If MsgBox("Desea realizar esta accion", MsgBoxStyle.YesNo, "Módulo - Créditos") = MsgBoxResult.Yes Then
            Try
                Dim Resultado As Integer
                Resultado = Creditos.Eliminar_PrCatGastosTramitacion(Me.dgGastosTramitacion.Item("Id_CatGastos_Tramitacion",
                                                                                                Me.dgGastosTramitacion.CurrentRow.Index).Value)
                If Resultado <> 0 Then
                    MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                    LlenarDg(0, 0, "0")
                Else
                    MsgBox("El registro no pudo ser eliminado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Information, "Módulo - Créditos")
                End If
            Catch ex As Exception
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class