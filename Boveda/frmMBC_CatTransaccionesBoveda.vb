Public Class frmMBC_CatTransaccionesBoveda
    Dim Bancos As New wrBancos.wsLibBancos
#Region "Metodos"
    Protected Sub estiloDg()
        Me.dgTransaccionesBoveda.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgTransaccionesBoveda.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgTransaccionesBoveda.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgTransaccionesBoveda.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
    End Sub
    Protected Sub LlenarDg(ByVal codTransaccion As Integer, ByVal opcion As Integer)
        Dim dts As New DataSet
        dts = Bancos.ConsultarBCCatTransacciones_Boveda(opcion, codTransaccion)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgTransaccionesBoveda.DataSource = dts.Tables(0)
            End If
        End If
        estiloDg()
    End Sub
#End Region

#Region "Eventos"

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If Me.rbCodTransaccion.Checked = True Then
                LlenarDg(Me.txtCodTransaccion.Text, 2)
            ElseIf Me.rbCodTransaccion.Checked = False Then
                LlenarDg(0, 1)
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo Boveda")
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim frm As New frmMsBC_CatTransaccionesBoveda
            With frm
                .Accion = 1
                .btnGuardar.Text = "Guardar"
                .ShowDialog()
            End With
            If Me.rbCodTransaccion.Checked = True Then
                LlenarDg(Me.txtCodTransaccion.Text, 2)
            ElseIf Me.rbCodTransaccion.Checked = False Then
                LlenarDg(0, 1)
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo Boveda")
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If dgTransaccionesBoveda.RowCount > 0 Then
                If dgTransaccionesBoveda.CurrentRow.Index <> -1 Then
                    Dim frm As New frmMsBC_CatTransaccionesBoveda
                    With frm
                        .btnGuardar.Text = "Modificar"
                        .Accion = 2
                        .CodTransaccion = Me.dgTransaccionesBoveda.Item("CodTransaccion", Me.dgTransaccionesBoveda.CurrentRow.Index).Value
                        .txtDescripcion.Text = Me.dgTransaccionesBoveda.Item("Descripcion", Me.dgTransaccionesBoveda.CurrentRow.Index).Value
                        .cbTipoMov.SelectedIndex = IIf(Me.dgTransaccionesBoveda.Item("tipoMov", Me.dgTransaccionesBoveda.CurrentRow.Index).Value = "A", 0, 1)
                        .txtPrefijo.Text = Me.dgTransaccionesBoveda.Item("prefijoPartida", Me.dgTransaccionesBoveda.CurrentRow.Index).Value
                        .ShowDialog()
                    End With
                    If Me.rbCodTransaccion.Checked = True Then
                        LlenarDg(Me.txtCodTransaccion.Text, 2)
                    ElseIf Me.rbCodTransaccion.Checked = False Then
                        LlenarDg(0, 1)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo Boveda")
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If dgTransaccionesBoveda.CurrentRow.Index <> -1 Then
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo, "Módulo Boveda") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = Bancos.EliminarBcCatTransacciones_Boveda(Me.dgTransaccionesBoveda.Item("CodTransaccion", Me.dgTransaccionesBoveda.CurrentRow.Index).Value,
                                                                         sUsuario, sPassword, sSucursal)
                    If resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Boveda")
                        If Me.rbCodTransaccion.Checked = True Then
                            LlenarDg(Me.txtCodTransaccion.Text, 2)
                        ElseIf Me.rbCodTransaccion.Checked = False Then
                            LlenarDg(0, 1)
                        End If
                    Else
                        MsgBox("Error. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Boveda")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo Boveda")
        End Try
    End Sub
#End Region


End Class