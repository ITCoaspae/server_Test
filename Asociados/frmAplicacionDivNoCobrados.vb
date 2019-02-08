Public Class frmAplicacionDivNoCobrados
    Dim asociado As New wrAsociados.wsLibAsoc
    Dim ahorros As New wrAhorro.wsLibAhorro
    Protected Sub llenardg(ByVal annio As Integer)
        Dim dts As New DataSet
        dts = asociado.consultarDividendosNoCobrados(1, annio)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgDivNoCobrados.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Function RecuperarCorrLibreta(ByVal Nocueta As String) As Integer
        Dim Dts As New DataSet
        Dim CorrLibreta As Integer
        Dts = Ahorros.ConsultarAhMovimientos("max(idlibreta)", "NoCuenta = '" & Nocueta & "'", "")
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                CorrLibreta = Dts.Tables(0).Rows(0).Item(0)
            End If
        End If
        Return CorrLibreta
    End Function
    Public Function RecuperarLineaLibreta(ByVal Nocuenta As String, ByVal CorrLibreta As Integer) As Integer
        Dim Dts As New DataSet
        Dim Linea As Integer
        Dts = Ahorros.ConsultarAhMovimientos("Max(Corr_Libreta)", "Nocuenta  ='" & Nocuenta & "' AND IDLIBRETA  ='" & CorrLibreta & "'", "")
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Linea = Dts.Tables(0).Rows(0).Item(0)

            End If
        End If
        Return Linea
    End Function

    Private Sub frmAplicacionDivNoCobrados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.nudAnnio.Value = Now.Year
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        llenardg(2012)
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        If Me.dgDivNoCobrados.RowCount > -1 Then
            Dim dui As String
            Dim saldo As Double
            Dim saldoDisp As Double
            Dim nocuenta As String
            Dim dtsAportaciones As New DataSet
            Dim MontoDiv As Double
            Dim MontoIsr As Double
            Dim Resultado As Integer
            Dim num As Integer
            Dim Corr_Libreta As Integer
            Dim LineaLibreta As Integer
            Dim Corr_LibretaIsr As Integer
            Dim LineaLibretaIsr As Integer
            For i As Integer = 0 To Me.dgDivNoCobrados.RowCount - 1
                MontoDiv = dgDivNoCobrados.Item("Saldo_Efectivo", i).Value
                MontoIsr = dgDivNoCobrados.Item("CalculoISR", i).Value
                dtsAportaciones = ahorros.ConsultarCtasAhorroDUI("nocuenta,saldo_CuentaAhorro,SaldoDisponible_CuentaAhorro",
                                                                 "a.DUI = '" & Me.dgDivNoCobrados.Item("DUI", i).Value & "' and left(a.codtipoahorro,1) = '1' and a.estado in ('A','B')",
                                                                 "", sUsuario, sPassword, sSucursal)
                If dtsAportaciones.Tables.Count > 0 Then
                    If dtsAportaciones.Tables(0).Rows.Count > 0 Then
                        saldo = dtsAportaciones.Tables(0).Rows(0).Item("saldo_cuentaAhorro")
                        saldoDisp = dtsAportaciones.Tables(0).Rows(0).Item("SaldoDisponible_CuentaAhorro")
                        nocuenta = dtsAportaciones.Tables(0).Rows(0).Item("nocuenta")
                        num = ahorros.ConsultarAhMovimientos("Max(num)", "Nocuenta = '" & nocuenta & "'", "").Tables(0).Rows(0).Item(0) + 1
                        Corr_Libreta = RecuperarCorrLibreta(nocuenta)
                        LineaLibreta = RecuperarLineaLibreta(nocuenta, Corr_Libreta)
                        If LineaLibreta = 61 Then
                            Corr_Libreta = Corr_Libreta + 1
                            LineaLibreta = 1
                        ElseIf LineaLibreta > 0 And LineaLibreta < 61 Then
                            LineaLibreta = LineaLibreta + 1
                        End If

                        If LineaLibreta = 61 Then
                            Corr_LibretaIsr = Corr_Libreta + 1
                            LineaLibretaIsr = 1
                        ElseIf LineaLibreta > 0 And LineaLibreta < 61 Then
                            LineaLibretaIsr = LineaLibreta + 1
                            Corr_LibretaIsr = Corr_Libreta
                        End If


                        Resultado = asociado.capitalzarDividendosNoCobrados("10001", nocuenta, "DEP", "",
                                                                            Format(Me.dtpFecha.Value, "Short Date"), "", saldo,
                                                                            Math.Round(MontoDiv, 2), saldo + Math.Round(MontoDiv, 2),
                                                                            0, "A", 0, 0, "N", "capitalización de Dividendos no retirados",
                                                                            i.ToString, 2013, "", num, "0", 0, "T", Now.Hour.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.PadLeft(2, "0"),
                                                                            "", LineaLibreta, Corr_Libreta, "", 0, "", MontoIsr, "ISR" + i.ToString, "Aplicación de retención sobre dividendos segun el Art. 156-B del Cod. Trib.",
                                                                            saldo + Math.Round(MontoDiv, 2), Math.Round(saldoDisp + Math.Round(MontoDiv, 2) - MontoIsr, 2),
                                                                            Math.Round(saldo + Math.Round(MontoDiv, 2) - MontoIsr, 2), num + 1, LineaLibretaIsr, Corr_LibretaIsr,
                                                                            saldo + Math.Round(MontoDiv, 2), True, Me.dgDivNoCobrados.Item("DUI", i).Value)




                    End If
                Else

                    Resultado = asociado.capitalzarDividendosNoCobrados("10001", "", "RET", "",
                                                                           Format(Me.dtpFecha.Value, "Short Date"), "", 0,
                                                                           0, 0,
                                                                           0, "C", 0, 0, "N", "capitalización de Dividendos no retirados",
                                                                           i.ToString, 2013, "", 0, "0", 0, "T", Now.Hour.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.PadLeft(2, "0"),
                                                                           "", 0, 0, "", 0, "", 0, "ISR" + i.ToString, "Aplicación de retención sobre dividendos segun el Art. 156-B del Cod. Trib.",
                                                                           0, 0,
                                                                           0, 0, 0, 0,
                                                                           0, False, Me.dgDivNoCobrados.Item("DUI", i).Value)
                End If
            Next


        End If
    End Sub

End Class