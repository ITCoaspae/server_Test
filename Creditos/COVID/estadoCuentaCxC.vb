Public Class estadoCuentaCxC
    Dim contabilidad As New wrConta.wsLibContab
    Dim asociados As New wrAsociados.wsLibAsoc
    Private Sub recuperarCuentasOrigen(dui As String)
        Dim dts As New DataSet
        dts = contabilidad.consultarCuentaPorCobrar(dui, 2, Now, Now, "", 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbOrigen.DataSource = dts.Tables(0)
                cbOrigen.DisplayMember = "CtaOrigen"
                cbOrigen.ValueMember = "CtaOrigen"
            End If
        End If

    End Sub
    Private Sub cuentaPorCobrar(NoCuentaOrigen)
        Dim dts As New DataSet
        dts = contabilidad.consultarCuentaPorCobrar("", 4, Now, Now, NoCuentaOrigen, 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cb.DataSource = dts.Tables(0)
                cb.DisplayMember = "IdCtaPorCobrar"
                cb.ValueMember = "IdCtaPorCobrar"
            End If
        End If
    End Sub
    Private Sub txtDui_DoubleClick(sender As Object, e As EventArgs) Handles txtDui.DoubleClick
        If txtDui.Text.Replace("_", " ").Replace("-", " ") = "" Then
            MessageBox.Show("Se debe ingresar el DUI del asociado", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim ds As New Data.DataSet, dr As DataRow
        Try

            ds = asociados.ConsultarAsociado("DUI,CodAntiguo,NoSocio,Apellido1,Apellido2,Nombres", "", "Correlativo", sUsuario, sPassword, sSucursal) 'Ópcion que permite la busqueda del dui de los asociados.

            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = asociados.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio,CodAntiguo", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                txtDui.Text = Trim(dr("DUI"))
                txtNombre.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")

            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_Validated(sender As Object, e As EventArgs) Handles txtDui.Validated
        Dim ds As New Data.DataSet, dr As DataRow
        Try

            ds = asociados.ConsultarAsociado("DUI,CodAntiguo,NoSocio,Apellido1,Apellido2,Nombres", "", "Correlativo", sUsuario, sPassword, sSucursal) 'Ópcion que permite la busqueda del dui de los asociados.



            ds = asociados.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio,CodAntiguo", "DUI='" & txtDui.Text & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            dr = ds.Tables(0).Rows(0)
                txtDui.Text = Trim(dr("DUI"))
                txtNombre.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")

            recuperarCuentasOrigen(txtDui.Text)
            cbOrigen.Focus()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbOrigen_LostFocus(sender As Object, e As EventArgs) Handles cbOrigen.LostFocus
        cuentaPorCobrar(cbOrigen.SelectedValue.ToString)
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim frm As New frmVisorRS
        OpcionRS = 232
        With frm
            .codPrstamo = cb.SelectedValue
            .fecha = DateTimePicker1.Value.ToShortDateString
            .ShowDialog()
        End With
    End Sub
End Class