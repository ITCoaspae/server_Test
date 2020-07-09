Public Class modTablaPagos
    Dim prestamos As New wrPrestamo.wsLibPrest
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim accion As Integer     ' 1 = Add; 2 = Delete
    Private saldoPrestamo As Double = 0
    Private vCodPrestamo As String
    Private cuotaTotal
    Private fechaOtorgamiento As Date
    Private fechaPrimCuota As Date
#Region "Propiedades"
    Public Property codPrestamo() As String
        Get
            Return vCodPrestamo
        End Get
        Set(value As String)
            vCodPrestamo = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Protected Function seguroDeudaPorProvision(fechaini As Date, fechafin As Date) As Double
        Dim dts As New DataSet
        Dim saldoSeguro As Double = 0
        dts = prestamos.CargaDatosPrestamoxRango(txtPrestamo.Text.Trim, fechaini, fechafin, "S", sUsuario, sPassword, sSucursal)
        If dts.Tables("Provisiones").Rows.Count > 0 Then
            For Each fila As DataRow In dts.Tables("Provisiones").Rows
                saldoSeguro = saldoSeguro + fila.Item("seguroDeuda")
            Next
        End If
        Return Math.Round(saldoSeguro, 2)
    End Function
    Protected Function calcularInteres() As Date
        Dim dtsPagos As New DataSet
        Dim dtsDiferidos As New DataSet
        Dim nuevaFecha As Date
        Dim fechaPago As Date
        Dim fechaIniCovid As Date
        Dim fechaFinCovid As Date
        Dim saldoK As Double = 0
        Dim dtsK As New DataSet
        Dim Interes As Double = 0
        Dim tasaInteres As Double
        Dim dias As Integer
        Dim saldoKant As Double = 0
        Dim tasaDeuda As Double = 0
        Dim tasaDanios As Double = 0
        Dim segDanios As Double = 0
        Dim segDeuda As Double = 0
        Dim segVEH
        Dim dtsSeg As New DataSet
        Try
            dtsSeg = asociados.ConsultarParametros("SeguroDeuda,SeguroDanios", "", "SeguroDanios", sUsuario, sPassword, sSucursal)
            If dtsSeg.Tables.Count > 0 Then
                If dtsSeg.Tables(0).Rows.Count > 0 Then
                    tasaDanios = ((dtsSeg.Tables(0).Rows(0).Item(1)) / 10000)
                    tasaDeuda = ((dtsSeg.Tables(0).Rows(0).Item(0)) / 10000)
                End If
            End If
            dtsK = prestamos.ConsultarPRPrestamos("saldo_Capital,tasa_Interes", "codprestamo = '" & txtPrestamo.Text & "'", "", sUsuario, sPassword, sSucursal)
            If dtsK.Tables.Count > 0 Then
                If dtsK.Tables(0).Rows.Count > 0 Then
                    saldoK = dtsK.Tables(0).Rows(0).Item(0)
                    tasaInteres = dtsK.Tables(0).Rows(0).Item(1)
                End If
            End If
            dtsDiferidos = asociados.consultarCasosCovid(txtPrestamo.Text.Trim, Now, Now, "", 2)
            If dtsDiferidos.Tables.Count > 0 Then
                If dtsDiferidos.Tables(0).Rows.Count Then

                    For Each fila As DataGridViewRow In DataGridView1.Rows
                        fechaPago = fila.Cells("FechaCuota").Value

                        For Each filadt As DataRow In dtsDiferidos.Tables(0).Rows
                            fechaIniCovid = filadt.Item("FechaIniSuspension")
                            fechaFinCovid = filadt.Item("FechaFinSuspension")
                            If DateTime.Compare(fechaPago, fechaIniCovid) >= 0 And DateTime.Compare(fechaPago, fechaFinCovid) <= 0 Then
                                'validar que el index no sea cero
                                Dim fechaCuotaAnt As Date
                                Dim fechaCuotaAct As Date
                                If fila.Index > 0 Then
                                    fechaCuotaAnt = DataGridView1.Item("fechaCuota", fila.Index - 1).Value
                                    fechaCuotaAct = DataGridView1.Item("fechaCuota", fila.Index).Value
                                Else
                                    fechaCuotaAnt = DateAdd(DateInterval.Month, -1, DataGridView1.Item("fechaCuota", fila.Index).Value)
                                    fechaCuotaAct = DataGridView1.Item("fechaCuota", fila.Index).Value
                                End If
                                dtsPagos = prestamos.ConsultarPRPagos("fechamov,codprestamo,abonoInteres", " codprestamo = '" & txtPrestamo.Text.Trim & "' and  fechamov > ='" & fechaCuotaAnt & "' and fechamov <= '" & fechaCuotaAct & "'  ", "fechamov desc", sUsuario, sPassword, sSucursal)
                                If dtsPagos.Tables.Count > 0 Then
                                    If dtsPagos.Tables(0).Rows.Count > 0 Then
                                        nuevaFecha = dtsPagos.Tables(0).Rows(0).Item("fechaMov")
                                    Else
                                        nuevaFecha = fechaCuotaAnt 'DataGridView1.Item("fechaCuota", fila.Index - 1).Value
                                    End If
                                    dias = DateDiff(DateInterval.Day, nuevaFecha, fechaPago) '+1
                                    Interes = ((saldoK * (tasaInteres / 100)) / IIf(DateTime.IsLeapYear(Year(fechaPago)), 366, 365)) * dias
                                    If DataGridView1.Item("SeguroDeuda", fila.Index + 3).Value > 0 Then


                                        If fila.Index = 0 Then
                                            If fechaPago < Now.ToShortDateString Then
                                                seguroDeudaPorProvision(DateAdd(DateInterval.Day, 1, nuevaFecha), fechaPago)
                                            Else
                                                segDeuda = Math.Round((((saldoK) * tasaDeuda) / DataGridView1.Item("Dias", fila.Index).Value) * dias, 2)
                                            End If

                                        Else
                                            segDeuda = Math.Round((((DataGridView1.Item("SaldoCapital", fila.Index - 1).Value) * tasaDeuda) / DataGridView1.Item("Dias", fila.Index).Value) * dias, 2)
                                        End If
                                    End If
                                    segDanios = Math.Round(DataGridView1.Item("SeguroDaniosyLA", fila.Index + 3).Value, 2)
                                    fila.Cells("Interes").Value = Math.Round(Interes, 2)
                                    fila.Cells("SeguroDeuda").Value = segDeuda
                                    fila.Cells("SeguroDaniosyLA").Value = segDanios
                                    fila.Cells("SeguroVehiculo").Value = DataGridView1.Item("SeguroVehiculo", fila.Index + 3).Value
                                    calcularCuota(fila.Index)
                                    sumaCuotaTotal(fila.Index)
                                End If

                            End If

                        Next
                    Next

                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try



    End Function
    Protected Sub modificarPagosPost(index As Integer)
        If accion = 1 Then
            For i As Integer = index + 1 To DataGridView1.Rows.Count - 1

                Me.DataGridView1.Item("Correlativo", i).Value = DataGridView1.Item("Correlativo", i).Value + 1
                Me.DataGridView1.Item("FechaCuota", i).Value = DateAdd(DateInterval.Month, 1, DataGridView1.Item("FechaCuota", i).Value)
                Me.DataGridView1.Item("Dias", i).Value = DateDiff(DateInterval.Day, Me.DataGridView1.Item("FechaCuota", i - 1).Value, Me.DataGridView1.Item("FechaCuota", i).Value)
            Next
        ElseIf accion = 2 Then
            For i As Integer = index To DataGridView1.Rows.Count - 1
                Me.DataGridView1.Item("Correlativo", i).Value = DataGridView1.Item("Correlativo", i).Value - 1
                Me.DataGridView1.Item("FechaCuota", i).Value = DateAdd(DateInterval.Month, -1, DataGridView1.Item("FechaCuota", i).Value)
                Me.DataGridView1.Item("Dias", i).Value = DateDiff(DateInterval.Day, Me.DataGridView1.Item("FechaCuota", i - 1).Value, Me.DataGridView1.Item("FechaCuota", i).Value)
            Next
        End If

    End Sub
    Private Sub calcularCuota(Fila As Integer)
        Dim abonoK As Double = DataGridView1.Item("AbonoCapital", Fila).Value
        Dim abonoInt As Double = DataGridView1.Item("Interes", Fila).Value
        Me.DataGridView1.Item("MontoCuota", Fila).Value = Math.Round(abonoK + abonoInt, 2)



    End Sub
    Private Sub llenarDatagrid()
        Dim dts As New DataSet
        dts = prestamos.CargaDatosPrestamo(codPrestamo, sUsuario, sPassword, sSucursal)
        Me.DataGridView1.Columns.Add("Correlativo", "Pago No.")   '0
        Me.DataGridView1.Columns.Add("CodTablaAmortiza", "Cod. Tabla") '1
        Me.DataGridView1.Columns.Add("FechaCuota", "Fecha Pago")       '2
        Me.DataGridView1.Columns.Add("MontoCuota", "Cuota a Pagar (Capital + Intereses) ") '3
        Me.DataGridView1.Columns.Add("CuotaTotal", "Cuota total")                           '4
        Me.DataGridView1.Columns.Add("AbonoCapital", "Abono Capital") '5
        Me.DataGridView1.Columns.Add("SaldoCapital", "Saldo")                        '6
        Me.DataGridView1.Columns.Add("Interes", "Interés") '7
        Me.DataGridView1.Columns.Add("TasaInteres", "Tasa Interés")                     '8
        Me.DataGridView1.Columns.Add("Dias", "Dias")                                      '9
        Me.DataGridView1.Columns.Add("SeguroDeuda", "Seguro Deuda") '10
        Me.DataGridView1.Columns.Add("SeguroDaniosyLA", "Seguro Daños") '11
        Me.DataGridView1.Columns.Add("SeguroVida", "Seguro Vida") '12
        Me.DataGridView1.Columns.Add("SeguroDesempleo", "Seguro Desempleo") '13
        Me.DataGridView1.Columns.Add("Aportacion", "Aportacion") '14
        Me.DataGridView1.Columns.Add("Ahorro", "Ahorro") '15
        Me.DataGridView1.Columns.Add("ComisionManejo", "Comision Manejo") '16
        Me.DataGridView1.Columns.Add("Otros", "Otros") '17
        Me.DataGridView1.Columns.Add("Cancelada", "Cancelada")                                                   '18
        Me.DataGridView1.Columns.Add("SeguroDeudaCuota", "Cuota Seguro de Deuda")                                   '19
        Me.DataGridView1.Columns.Add("SeguroVehiculo", "Seguro Vehículo") '20

        ' Ingresamos datos
        saldoPrestamo = dts.Tables("TablaAmortiza").Rows(0).Item("AbonoCapital") + dts.Tables("TablaAmortiza").Rows(0).Item("SaldoCapital")
        Dim cuotaTotal As Double

        For Each fila As DataRow In dts.Tables("TablaAmortiza").Rows
            cuotaTotal = fila(4) + fila(6) + fila(9) + fila(10) + fila(11) + fila(12) + fila(13) + fila(14) + fila(15) + fila(19)
            Me.DataGridView1.Rows.Add(fila(0), fila(1), fila(2), fila(3), cuotaTotal, fila(4), fila(5), fila(6), fila(7), fila(8), fila(9), fila(10), fila(11), fila(12), fila(13), fila(14), fila(15), fila(16), fila(17), fila(18), fila(19))
        Next

        columnasSoloLectura()
        ocultarColumnas()
        formatoGrid()
    End Sub
    Protected Sub formatoGrid()
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Protected Sub columnasSoloLectura()
        Me.DataGridView1.Columns(0).ReadOnly = True
        Me.DataGridView1.Columns(1).ReadOnly = True
        'Me.DataGridView1.Columns(2).ReadOnly = True
        Me.DataGridView1.Columns(3).ReadOnly = True
        Me.DataGridView1.Columns(6).ReadOnly = True
        Me.DataGridView1.Columns(8).ReadOnly = True
        Me.DataGridView1.Columns(9).ReadOnly = True
        Me.DataGridView1.Columns(18).ReadOnly = True
    End Sub
    Protected Sub ocultarColumnas()
        Me.DataGridView1.Columns(1).Visible = False
        Me.DataGridView1.Columns(12).Visible = False
        Me.DataGridView1.Columns(13).Visible = False
        Me.DataGridView1.Columns(16).Visible = False
        Me.DataGridView1.Columns(18).Visible = False
        Me.DataGridView1.Columns(19).Visible = False


    End Sub

    Private Sub calcularSaldo(fila As Integer)
        If accion = 2 Then
            For i As Integer = fila To DataGridView1.Rows.Count - 1


                If i = DataGridView1.Rows.Count - 1 Then
                    Me.DataGridView1.Item("AbonoCapital", i).Value = Me.DataGridView1.Item("SaldoCapital", i - 1).Value
                    Me.DataGridView1.Item("SaldoCapital", i).Value = Math.Round(DataGridView1.Item("SaldoCapital", i - 1).Value - Me.DataGridView1.Item("AbonoCapital", i).Value, 2)
                Else
                    Me.DataGridView1.Item("SaldoCapital", i).Value = Math.Round(DataGridView1.Item("SaldoCapital", i - 1).Value - Me.DataGridView1.Item("AbonoCapital", i).Value, 2)
                End If
                calcularCuota(i)

            Next
        Else
            For i As Integer = fila + 1 To DataGridView1.Rows.Count - 1

                If i = DataGridView1.Rows.Count - 1 Then
                    Me.DataGridView1.Item("AbonoCapital", i).Value = Me.DataGridView1.Item("SaldoCapital", i - 1).Value

                    Me.DataGridView1.Item("SaldoCapital", i).Value = Math.Round(DataGridView1.Item("SaldoCapital", i - 1).Value - Me.DataGridView1.Item("AbonoCapital", i).Value, 2)
                ElseIf i = 0 Then
                    Me.DataGridView1.Item("SaldoCapital", i).Value = txtSaldo.Text
                Else
                    Me.DataGridView1.Item("SaldoCapital", i).Value = Math.Round(DataGridView1.Item("SaldoCapital", i - 1).Value - Me.DataGridView1.Item("AbonoCapital", i).Value, 2)

                End If
                calcularCuota(i)
            Next
        End If


    End Sub
    Private Sub Validar_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Dim Celda As DataGridViewCell = Me.DataGridView1.CurrentCell()

        If Celda.ColumnIndex = 5 Or Celda.ColumnIndex = 7 Or Celda.ColumnIndex = 10 Or Celda.ColumnIndex = 11 Or Celda.ColumnIndex = 12 Or Celda.ColumnIndex = 13 Or Celda.ColumnIndex = 14 Or Celda.ColumnIndex = 15 Or Celda.ColumnIndex = 16 Or Celda.ColumnIndex = 17 Or Celda.ColumnIndex = 19 Or Celda.ColumnIndex = 20 Then

            If e.KeyChar = "."c Then

                If InStr(Celda.EditedFormattedValue.ToString, ".", CompareMethod.Text) > 0 Then

                    e.Handled = True
                Else

                    e.Handled = False
                End If
            Else

                If Len(Trim(Celda.EditedFormattedValue.ToString)) > 0 Then

                    If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                        e.Handled = False
                    Else

                        e.Handled = True
                    End If
                Else

                    If e.KeyChar = "0"c Then

                        e.Handled = True
                    Else

                        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(8) Then

                            e.Handled = False
                        Else

                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region "Eventos"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dts As New DataSet
        dts = prestamos.CargaDatosPrestamo(codPrestamo, sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            txtMonto.Text = dts.Tables("Prestamo").Rows(0).Item("Monto")
            txtTasa.Text = dts.Tables("Prestamo").Rows(0).Item("Tasa_Interes")
            cuotaTotal = dts.Tables("Prestamo").Rows(0).Item("CuotaTotal")
            txtSaldo.Text = dts.Tables("Prestamo").Rows(0).Item("Saldo_capital")
            fechaPrimCuota = dts.Tables("Prestamo").Rows(0).Item("fechaPrimeraCuota")
        End If
        llenarDatagrid()
    End Sub
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            accion = 1
            Dim fila As Integer
            Dim correlativo As Integer
            Dim fechaCuota As DateTime
            Dim codTabla As String
            Dim saldo As Double
            Dim tasaInteres As Double
            Dim dias As Integer
            Dim fecha As Date

            fila = DataGridView1.CurrentRow.Index + 1
            tasaInteres = DataGridView1.Item("TasaInteres", Me.DataGridView1.CurrentRow.Index).Value
            codTabla = DataGridView1.Item("CodTablaAmortiza", Me.DataGridView1.CurrentRow.Index).Value
            saldo = DataGridView1.Item("SaldoCapital", Me.DataGridView1.CurrentRow.Index).Value
            fecha = DataGridView1.Item("FechaCuota", Me.DataGridView1.CurrentRow.Index).Value

            If DateTime.IsLeapYear(Year(fecha)) = True Then
                If Month(fecha) = 2 And fecha.Day = 29 Then
                    fechaCuota = String.Concat(fechaPrimCuota.Day.ToString, "/03/", Year(fecha).ToString) '  UltimoDiaDelMes(DateAdd(DateInterval.Month, 1, DataGridView1.Item("FechaCuota", Me.DataGridView1.CurrentRow.Index).Value))
                Else
                    fechaCuota = DateAdd(DateInterval.Month, 1, DataGridView1.Item("FechaCuota", Me.DataGridView1.CurrentRow.Index).Value)
                End If

            Else
                If Month(fecha) = 2 And fecha.Day = 28 Then
                    fechaCuota = String.Concat(fechaPrimCuota.Day.ToString, "/03/", Year(fecha).ToString) ' UltimoDiaDelMes(DateAdd(DateInterval.Month, 1, DataGridView1.Item("FechaCuota", Me.DataGridView1.CurrentRow.Index).Value))
                Else
                    fechaCuota = DateAdd(DateInterval.Month, 1, DataGridView1.Item("FechaCuota", Me.DataGridView1.CurrentRow.Index).Value)
                End If

            End If

            'fechaCuota = DateAdd(DateInterval.Month, 1, DataGridView1.Item("FechaCuota", Me.DataGridView1.CurrentRow.Index).Value)
            correlativo = DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value + 1
            dias = DateDiff(DateInterval.Day, DataGridView1.Item("FechaCuota", Me.DataGridView1.CurrentRow.Index).Value, fechaCuota,)



            Me.DataGridView1.Rows.Insert(fila, correlativo, codTabla, fechaCuota, 0, 0, 0, saldo, 0, tasaInteres, dias, 0, 0, 0, 0, 0, 0, 0, 0, "N", 0, 0)
            modificarPagosPost(fila)
            accion = 0

        Catch ex As Exception

        End Try
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        accion = 2
        Me.DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        modificarPagosPost(DataGridView1.CurrentRow.Index)
        calcularSaldo(DataGridView1.CurrentRow.Index)
        accion = 0
    End Sub
    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf Validar_Numeros
    End Sub
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim Celda As DataGridViewCell = Me.DataGridView1.CurrentCell()
        If Celda.ColumnIndex = 5 Then
            If Me.DataGridView1.CurrentRow.Index = 0 Then
                Me.DataGridView1.Item("SaldoCapital", Celda.RowIndex).Value = saldoPrestamo - Me.DataGridView1.Item(Celda.ColumnIndex, Celda.RowIndex).Value
            Else
                Me.DataGridView1.Item("SaldoCapital", Celda.RowIndex).Value = DataGridView1.Item("SaldoCapital", Celda.RowIndex - 1).Value - Me.DataGridView1.Item(Celda.ColumnIndex, Celda.RowIndex).Value
            End If
            calcularCuota(Celda.RowIndex)
            calcularSaldo(Celda.RowIndex)
        ElseIf Celda.ColumnIndex = 7 Then
            calcularCuota(Celda.RowIndex)

        Else
            calcularSaldo(Celda.RowIndex)
        End If
        sumaCuotaTotal(Celda.RowIndex)
    End Sub
    Protected Sub sumaCuotaTotal(fila As Integer)
        DataGridView1.Item("CuotaTotal", fila).Value = Math.Round(DataGridView1.Item("AbonoCapital", fila).Value +
        DataGridView1.Item("Interes", fila).Value + DataGridView1.Item("SeguroDeuda", fila).Value +
        DataGridView1.Item("SeguroDaniosyLA", fila).Value + DataGridView1.Item("SeguroVida", fila).Value +
        DataGridView1.Item("SeguroDesempleo", fila).Value + DataGridView1.Item("Aportacion", fila).Value +
        DataGridView1.Item("Ahorro", fila).Value + DataGridView1.Item("Otros", fila).Value +
        DataGridView1.Item("SeguroVehiculo", fila).Value, 2)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If (MetroFramework.MetroMessageBox.Show(Me, "¿Desea guardar la nueva tabla de pagos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) = DialogResult.Yes Then
                Dim dt As New DataTable
                dt.TableName = "Amortiza"
                Dim dts As New DataSet
                dt.Columns.Add("correlativo")
                dt.Columns.Add("CodTablaAmortiza")
                dt.Columns.Add("FechaPago")
                dt.Columns.Add("Cuota_Prestamo")
                dt.Columns.Add("Abono_Capital")
                dt.Columns.Add("Saldo")
                dt.Columns.Add("Cuota_Interes")
                dt.Columns.Add("Interes")
                dt.Columns.Add("Dias_Interes")
                dt.Columns.Add("SeguroDeuda")
                dt.Columns.Add("SeguroDanios")
                dt.Columns.Add("SeguroVida")
                dt.Columns.Add("SeguroDesempleo")
                dt.Columns.Add("Aportacion")
                dt.Columns.Add("Ahorros")
                dt.Columns.Add("ComisionManejo")
                dt.Columns.Add("Otros")
                dt.Columns.Add("Cancelada")
                dt.Columns.Add("SeguroDeuda_Cuota")
                dt.Columns.Add("SeguroVehiculo")
                dt.Columns.Add("Cuota_Total")

                For Each fila As DataGridViewRow In Me.DataGridView1.Rows
                    Dim f As DataRow = dt.NewRow()
                    f(0) = fila.Cells(0).Value
                    f(1) = fila.Cells(1).Value
                    f(2) = fila.Cells(2).Value
                    f(3) = fila.Cells(3).Value
                    f(4) = fila.Cells(5).Value
                    f(5) = fila.Cells(6).Value
                    f(6) = fila.Cells(7).Value
                    f(7) = fila.Cells(8).Value
                    f(8) = fila.Cells(9).Value
                    f(9) = fila.Cells(10).Value
                    f(10) = fila.Cells(11).Value
                    f(11) = fila.Cells(12).Value
                    f(12) = fila.Cells(13).Value
                    f(13) = fila.Cells(14).Value
                    f(14) = fila.Cells(15).Value
                    f(15) = fila.Cells(16).Value
                    f(16) = fila.Cells(17).Value
                    f(17) = fila.Cells(18).Value
                    f(18) = fila.Cells(19).Value
                    f(19) = fila.Cells(20).Value
                    f(20) = cuotaTotal
                    dt.Rows.Add(f)
                Next
                dts.Tables.Add(dt)
                If (prestamos.ReasignarTablaAmortiza(Me.codPrestamo, dts, sUsuario, sPassword, sSucursal)) > 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)


                End If

            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnNotaCred_Click(sender As Object, e As EventArgs) Handles btnNotaCred.Click
        Try


            Dim frm As New detNotaCredPrest
            Dim dts As New DataSet
            Dim dt As New DataTable
            Dim fila As Integer
            Dim total As Double = 0


            dt.TableName = "Detalle"
            dt.Columns.Add("Concepto")
            dt.Columns.Add("Valor")
            fila = Me.DataGridView1.CurrentRow.Index
            If CDate(DataGridView1.Item("FechaCuota", fila).Value) <= Now.ToShortDateString Then


                If fila >= 0 Then
                    For Each col As DataGridViewColumn In Me.DataGridView1.Columns

                        If col.Name = "AbonoCapital" Or col.Name = "Interes" Or col.Name = "SeguroDeuda" Or col.Name = "SeguroDaniosyLA" Or col.Name = "SeguroVida" Or col.Name = "Aportacion" Or col.Name = "Ahorro" Or col.Name = "ComisionManejo" Or col.Name = "Otros" Or col.Name = "SeguroVehiculo" Or col.Name = "SeguroDesempleo" Then
                            If Me.DataGridView1.Item(col.Index, fila).Value > 0 Then
                                Dim f As DataRow = dt.NewRow()
                                f(0) = col.Name.ToString.ToUpper
                                f(1) = DataGridView1.Item(col.Index, fila).Value
                                total = total + DataGridView1.Item(col.Index, fila).Value
                                dt.Rows.Add(f)
                            End If
                        End If
                    Next
                    Dim fTotal As DataRow = dt.NewRow
                    fTotal(0) = "TOTAL: "
                    fTotal(1) = total
                    dt.Rows.Add(fTotal)
                    dts.Tables.Add(dt)
                    With frm
                        .dts = dts
                        .txtNombre.Text = txtAsociado.Text.ToUpper
                        .txtPrestamo.Text = txtPrestamo.Text
                        .fecha = DataGridView1.Item("FechaCuota", fila).Value
                        .MetroDateTime1.Value = DataGridView1.Item("FechaCuota", fila).Value
                        .ShowDialog()
                    End With
                    Me.Close()
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        calcularInteres()

    End Sub



#End Region











End Class