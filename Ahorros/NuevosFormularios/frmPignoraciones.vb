Public Class frmPignoraciones
    Dim ahorro As New wrAhorro.wsLibAhorro

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim dts As New DataSet
        If rbDui.Checked = True Then
            dts = ahorro.ConsultarCuentaAhorro("P", "a.Dui='" & txtDui.Text & "' and a.Estado='A' and a.Pignorado='S' and b.Estado='N'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
            dgPignoraciones.DataSource = dts.Tables(0)
            If dts.Tables(0).Rows.Count > 0 Then
                btnModificar1.Enabled = True
            End If
        ElseIf rbNoCuenta.Checked = True Then
                dts = ahorro.ConsultarCuentaAhorro("P", " a.nocuenta='" & txtNocuenta.Text & "' and a.Estado='A' and a.Pignorado='S' and b.Estado='N'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
                dgPignoraciones.DataSource = dts.Tables(0)
            If dts.Tables(0).Rows.Count > 0 Then
                btnModificar1.Enabled = True
            End If
        ElseIf rbCodPrestamo.Checked = True Then
            dts = ahorro.ConsultarCuentaAhorro("P", " b.codPrestamo='" & txtDui.Text & "' and a.Estado='A' and a.Pignorado='S' and b.Estado='N'", "a.NoCuenta", sUsuario, sPassword, sSucursal)
                dgPignoraciones.DataSource = dts.Tables(0)
            If dts.Tables(0).Rows.Count > 0 Then
                btnModificar1.Enabled = True
            End If
        Else
            btnModificar1.Enabled = False
            MetroFramework.MetroMessageBox.Show(Me, "Por favor seleccione un parametro de busqueda.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Dim frm As New frmMsAhPignoracion
        With frm
            .Show()
        End With
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        If txtDui.Text <> "" Or txtNocuenta.Text <> "" Or txtCodPrestamo.Text <> "" Then
            Dim frm As New frmMsAhPignoracion

            With frm
                .id = dgPignoraciones.Item("correlativo", Me.dgPignoraciones.CurrentRow.Index).Value
                .accion = 2
                .MetroButton3.Visible = False
                .MetroButton1.Visible = True
                .Show()
            End With
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Realizar Busqueda de Cuentas Pignoradas.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub frmPignoraciones_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class