Public Class frmDetArregloMora
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim prestamos As New wrPrestamo.wsLibPrest
    Dim vAccion As Integer
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Protected Sub recuperarNombreAsociado(ByVal dui As String)
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarAsociado("Rtrim(nombres)+' '+rtrim(apellido1)+' '+rtrim(apellido2) as asociado", " dui = '" & dui & "'", "", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.lblNombre.Text = dts.Tables(0).Rows(0).Item(0).ToString.ToUpper
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Protected Sub recuperarPrestamo(ByVal dui As String)
        Dim dtsPrestamo As New DataSet
        dtsPrestamo = prestamos.ConsultarPRPrestamos("codprestamo,saldo_Capital,SaldoDia_CapitalMora,SaldoDia_InteresMora,saldodia_interes,tasa_interes,tasa_interes_mora", _
                                                     " dui = '" & dui & "'", "codprestamo", sUsuario, sPassword, sSucursal)
        If dtsPrestamo.Tables(0).Rows.Count > 0 Then
            Dim frm As New frmAGenerico
            frm.Datos = dtsPrestamo
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado <> "" Then
                txtCodPrestamo.Text = frm.Resultado
                txtSaldoCap.Text = frm.Resultado2
                txtCapMora.Text = frm.Resultado3
                txtSaldoIntMora.Text = frm.Resultado4
                txtSaldoInt.Text = frm.Resultado5
                txtTasa.Text = frm.Resultado6
                txtTasaMora.Text = frm.Resultado7

                txtNSaldoCap.Value = frm.Resultado2
                txtNCapMor.Value = frm.Resultado3
                txtNIntMora.Value = frm.Resultado4
                txtNSaldoInt.Value = frm.Resultado5
                txtNTasaInt.Value = frm.Resultado6
                txtNTMora.Value = frm.Resultado7



            End If
        End If
       
    End Sub

    Private Sub txtDui_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDui.Validating
        If txtDui.Text.Trim.Length >= 10 Then
            recuperarNombreAsociado(txtDui.Text.Trim)
        End If
    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        If txtDui.Text.Trim.Length >= 10 Then
            recuperarPrestamo(txtDui.Text.Trim)
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If accion = 1 Then
            Dim resultado As Integer
            resultado = prestamos.IngresarArrreglo(txtCodPrestamo.Text.Trim, txtNSaldoCap.Value, _
                                                   txtNSaldoInt.Value, txtNCapMor.Value, txtNIntMora.Value, _
                                                   sUsuario, Format(Now, "short date"), txtNTasaInt.Value, _
                                                   txtNTMora.Value)
            If resultado > 0 Then
                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
            Else
                MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub frmDetArregloMora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroPanel2_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel2.Paint

    End Sub

    Private Sub gbNv_Enter(sender As Object, e As EventArgs) Handles gbNv.Enter

    End Sub
End Class