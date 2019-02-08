Public Class frmCambioDui
    Dim asociados As New wrAsociados.wsLibAsoc

    Private Sub btnCambio_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtDuiAnt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuiAnt.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDuiAnt.ValueIsDbNull, "", txtDuiAnt.Value)
            If Valor.Trim = "" Then
                Me.txtDuiAnt.SelectionStart = 0
                Me.txtDuiAnt.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNuevoDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNuevoDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtNuevoDui.ValueIsDbNull, "", txtNuevoDui.Value)
            If Valor.Trim = "" Then
                Me.txtNuevoDui.SelectionStart = 0
                Me.txtNuevoDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDuiAnt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuiAnt.DoubleClick
        If txtDuiAnt.Text.Replace("_", " ").Replace("-", " ") = "" Then
            MessageBox.Show("Se debe ingresar el DUI del asociado", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,CodAntiguo,NoSocio,Apellido1,Apellido2,Nombres", "", "Correlativo", sUsuario, sPassword, sSucursal) 'Ópcion que permite la busqueda del dui de los asociados.
            'ds = oAsoc.ConsultarAsociado("DUI,CodAntiguo,NoSocio,Apellido1,Apellido2,Nombres", "DUI='" & txtDui.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio,CodAntiguo", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDuiAnt.Value = Trim(dr("DUI"))
                Me.lblCliente.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        If MsgBox("¿Desea realizar esta transacción?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If txtDuiAnt.Text.Length >= 10 And txtNuevoDui.Text.Length >= 10 Then
                If asociados.cambioDui(txtDuiAnt.Text.Trim, txtNuevoDui.Text.Trim) > 0 Then
                    MsgBox("Cambio realizado exitosamente", MsgBoxStyle.Information)
                    Me.Close()
                End If
            Else
                MsgBox("El cambio no fue realizado, comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub frmCambioDui_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dts As New DataSet
        Dim data As New AutoCompleteStringCollection
        dts = asociados.ConsultarAsociado("concat(nombres ,' ',Apellido1,' ',apellido2,' ',ApellidoCas) as asociado, dui", " ", " nombres", sUsuario, sPassword, sSucursal)
        Dim i As Integer
        For i = 0 To dts.Tables(0).Rows.Count - 1
            data.Add(dts.Tables(0).Rows(i).Item("asociado").ToString.Trim)

        Next

        Me.TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TextBox1.AutoCompleteCustomSource = data
        Me.TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest


    End Sub
End Class