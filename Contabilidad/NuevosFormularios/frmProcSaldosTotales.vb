Public Class frmProcSaldosTotales
    Dim contabilidad As New wrConta.wsLibContab

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            Dim ds As DataSet, sCampos As String, sMes As String, sSaldoA As String
            contabilidad.ProcesarSaldos(dtpFecha.Value.Month, dtpFecha.Value.Year, sUsuario, sPassword, sSucursal)
            MsgBox("Proceso realizado exitosamente", MsgBoxStyle.Information)
            Select Case dtpFecha.Value.Month
                Case Is = 1
                    sMes = "Enero"
                    sSaldoA = "Saldo_Anterior"
                Case Is = 2
                    sMes = "Febrero"
                    sSaldoA = "SEnero"
                Case Is = 3
                    sMes = "Marzo"
                    sSaldoA = "SFebrero"
                Case Is = 4
                    sMes = "Abril"
                    sSaldoA = "SMarzo"
                Case Is = 5
                    sMes = "Mayo"
                    sSaldoA = "SAbril"
                Case Is = 6
                    sMes = "Junio"
                    sSaldoA = "SMayo"
                Case Is = 7
                    sMes = "Julio"
                    sSaldoA = "SJunio"
                Case Is = 8
                    sMes = "Agosto"
                    sSaldoA = "SJulio"
                Case Is = 9
                    sMes = "Septiembre"
                    sSaldoA = "SAgosto"
                Case Is = 10
                    sMes = "Octubre"
                    sSaldoA = "SSeptiembre"
                Case Is = 11
                    sMes = "Noviembre"
                    sSaldoA = "SOctubre"
                Case Is = 12
                    sMes = "Diciembre"
                    sSaldoA = "SNoviembre"
            End Select

            sCampos = "Saldos.IdCuenta,Descripcion," & sSaldoA & " as Saldo_Anterior,C" & sMes & " as Cargos,A" & sMes & " as Abonos,S" & sMes & " as Saldo"
            ds = contabilidad.ConsultaSaldos(sCampos, "(" & sSaldoA & "<>0 or C" & sMes & "<>0 or A" & sMes & "<>0 or S" & sMes & "<>0) and Annio=" & dtpFecha.Value.Year & "", "Saldos.IdCuenta", sUsuario, sPassword, sSucursal)


            Me.C1FlexGrid1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try


    End Sub
End Class