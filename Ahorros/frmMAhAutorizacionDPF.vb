Public Class frmMAhAutorizacionDPF
    Dim ahorros As New wrAhorro.wsLibAhorro
    Protected Sub eliminarAutorizacion(ByVal idAutorizacion)
        Dim resultado As Integer
        resultado = ahorros.eliminarAhAutorizacionTasasDpf(idAutorizacion)
        If resultado <> 0 Then
            MsgBox("El registro fue elminado exitosamente.", MsgBoxStyle.Information, "Módulo - Ahorros")
        Else
            MsgBox("El registro no fue elminado.", MsgBoxStyle.Critical, "Módulo - Ahorros")
        End If
    End Sub
    Protected Sub llenarDgAutorizaciones()
        Dim dts As New DataSet
        dts = ahorros.consultarAhAutorizacionTasasDpf("", 1, 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgAutorizacion.DataSource = dts.Tables(0)
            End If
        End If
        Me.dgAutorizacion.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgAutorizacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgAutorizacion.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub frmMAhAutorizacionDPF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarDgAutorizaciones()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As New frmMsAhAutorizacionDPF
            With frm
                .accion = 1
                .ShowDialog()
            End With
            llenarDgAutorizaciones()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            Dim frm As New frmMsAhAutorizacionDPF
            With frm
                .accion = 2
                .codEmpleado = Me.dgAutorizacion.Item("CodEmpleado", Me.dgAutorizacion.CurrentRow.Index).Value
                .idAutorizacion = Me.dgAutorizacion.Item("idAutorizacion", Me.dgAutorizacion.CurrentRow.Index).Value
                .ShowDialog()
            End With
            llenarDgAutorizaciones()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If MsgBox("¿Desea eliminar este registro?", MsgBoxStyle.YesNo, "Módulo - Ahorros") = MsgBoxResult.Yes Then
                If dgAutorizacion.CurrentRow.Index > -1 Then
                    eliminarAutorizacion(Me.dgAutorizacion.Item("idAutorizacion", Me.dgAutorizacion.CurrentRow.Index).Value)
                    llenarDgAutorizaciones()
                End If
            End If
        Catch ex As Exception
            MsgBox("El registro no fue elminado. Por favor comunicarse con el administrador del sistema" + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Ahorros")
        End Try
    End Sub

    Private Sub frmMAhAutorizacionDPF_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class