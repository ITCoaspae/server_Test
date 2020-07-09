Imports System.Text

Public Class frmCargaTablasAmortizacion
    Dim prestamo As New wrPrestamo.wsLibPrest
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim CuotaSeguroDeuda As Double
    Dim pInteres As Double
    Dim pCuotaTotal As Double
    Public Property TasaInteres() As Double
        Get
            Return pInteres
        End Get
        Set(ByVal value As Double)
            pInteres = value
        End Set
    End Property
    Public Property MontoCuotaTotal() As Double
        Get
            Return pCuotaTotal
        End Get
        Set(ByVal value As Double)
            pCuotaTotal = value
        End Set
    End Property
    Protected Sub calcularCuotaSegDeuda()
        Dim dts As New DataSet
        Dim PorcSegDeu As Double
        dts = asociados.ConsultarParametros("SeguroDeuda", "", " SeguroDeuda", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                PorcSegDeu = (dts.Tables(0).Rows(0).Item("SeguroDeuda")) / 10000
                CuotaSeguroDeuda = Math.Round(TxtSaldo.Text * PorcSegDeu, 2)
            End If

        End If
    End Sub
#Region "Importar Tabla de Amortiación"

    Public Sub importarTablaPagos()

        If dtsTablaAmort.Tables.Count > 0 Then
            dtsTablaAmort.Clear()
            dtsTablaAmort.Tables.Clear()
        End If
        calcularCuotaSegDeuda()
        Dim cc As String
        Dim cb As String

        Dim dt As New DataTable("Amortiza")

        Dim i As Integer = 0
        Dim dr As DataRow
        Dim correlativo As New DataColumn("Cuota_Num")
        Dim fechaCuota As New DataColumn("FechaPago")
        Dim MontoCuota As New DataColumn("Cuota_Prestamo")
        Dim SaldoCapital As New DataColumn("Saldo")
        Dim AbonoCapital As New DataColumn("Abono_Capital")
        Dim CuotaInteres As New DataColumn("Cuota_Interes")
        Dim Dias As New DataColumn("Dias_Interes")
        Dim SeguroDeuda As New DataColumn("SeguroDeuda")
        Dim SeguroDanios As New DataColumn("SeguroDanios")
        Dim SeguroVida As New DataColumn("SeguroVida")
        Dim SeguroDesempleo As New DataColumn("SeguroDesempleo")
        Dim Aportacion As New DataColumn("Aportacion")
        Dim Ahorro As New DataColumn("Ahorros")
        Dim ComisionManejo As New DataColumn("ComisionManejo")
        Dim Otros As New DataColumn("Otros")
        Dim SeguroDeudaCuota As New DataColumn("SeguroDeuda_Cuota")
        Dim cuotaTotal As New DataColumn("Cuota_Total")
        Dim Interes As New DataColumn("Interes")
        Dim SeguroVehiculo As New DataColumn("SeguroVehiculo")

        correlativo.DataType = GetType(Integer)
        fechaCuota.DataType = GetType(DateTime)
        MontoCuota.DataType = GetType(Double)
        SaldoCapital.DataType = GetType(Double)
        AbonoCapital.DataType = GetType(Double)
        Interes.DataType = GetType(Double)
        Dias.DataType = GetType(Integer)
        SeguroDeuda.DataType = GetType(Double)
        SeguroDanios.DataType = GetType(Double)
        SeguroVida.DataType = GetType(Double)
        SeguroDesempleo.DataType = GetType(Double)
        Aportacion.DataType = GetType(Double)
        Ahorro.DataType = GetType(Double)
        ComisionManejo.DataType = GetType(Double)
        SeguroDeudaCuota.DataType = GetType(Double)
        cuotaTotal.DataType = GetType(Double)
        CuotaInteres.DataType = GetType(Double)
        SeguroVehiculo.DataType = GetType(Double)

        dt.Columns.Add(correlativo)
        dt.Columns.Add(fechaCuota)
        dt.Columns.Add(MontoCuota)
        dt.Columns.Add(SaldoCapital)
        dt.Columns.Add(AbonoCapital)
        dt.Columns.Add(CuotaInteres)
        dt.Columns.Add(Dias)
        dt.Columns.Add(SeguroDeuda)
        dt.Columns.Add(SeguroDanios)
        dt.Columns.Add(SeguroVida)
        dt.Columns.Add(SeguroDesempleo)
        dt.Columns.Add(Aportacion)
        dt.Columns.Add(Ahorro)
        dt.Columns.Add(ComisionManejo)
        dt.Columns.Add(Otros)
        dt.Columns.Add(SeguroDeudaCuota)
        dt.Columns.Add(cuotaTotal)
        dt.Columns.Add(Interes)
        dt.Columns.Add(SeguroVehiculo)
        dtsTablaAmort.Tables.Add(dt)


        Dim fileName As String = ""
        Dim ruta As String
        OpenFileDialog1.InitialDirectory = "c:\desktop"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            fileName = OpenFileDialog1.FileName
        End If
        ruta = fileName
        Dim textLine As String = ""
        Dim Splitline() As String

        If System.IO.File.Exists(fileName) = True Then
            Dim objReader As New System.IO.StreamReader(ruta, Encoding.ASCII)
            Do While objReader.Peek() <> -1
                textLine = objReader.ReadLine
                Splitline = Split(textLine, ";")
                If i > 0 Then

                    dr = dtsTablaAmort.Tables("Amortiza").NewRow()
                    dr(0) = Splitline(0)
                    dr(1) = Splitline(1)
                    dr(2) = Splitline(3)
                    dr(3) = Splitline(6)
                    dr(4) = Splitline(5)
                    dr(5) = Splitline(4)
                    dr(6) = Splitline(2)
                    dr(7) = Splitline(7)
                    dr(8) = Splitline(8)
                    dr(9) = 0
                    dr(10) = 0
                    dr(11) = Splitline(10)
                    dr(12) = Splitline(11)
                    dr(13) = 0
                    dr(14) = 0
                    dr(15) = CuotaSeguroDeuda
                    dr(16) = Splitline(13)
                    dr(17) = Splitline(14)
                    dr(18) = Splitline(9)
                    dtsTablaAmort.Tables("Amortiza").Rows.Add(dr)
                End If

                i += 1
            Loop
            DataGridView1.DataSource = dtsTablaAmort.Tables(0)
            Me.DataGridView1.Columns(9).Visible = False
            Me.DataGridView1.Columns(10).Visible = False
            Me.DataGridView1.Columns(13).Visible = False
            Me.DataGridView1.Columns(14).Visible = False
            estidoDg()
        End If
    End Sub
    Public Function ImportarPartidaExcel(ByVal Ruta As String) As DataSet
        Dim ConecExcel As System.Data.OleDb.OleDbConnection
        Dim Dts As New DataSet
        Dim ObjAdapter As System.Data.OleDb.OleDbDataAdapter
        ConecExcel = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & Ruta & "';Extended Properties='Excel 12.0 Xml;HDR=YES';")
        ObjAdapter = New System.Data.OleDb.OleDbDataAdapter("select * from [TablaAmortizacion$]", ConecExcel)
        ObjAdapter.TableMappings.Add("Tabla", "TablaAmortizacion")
        ObjAdapter.Fill(Dts, "TablaAmortizacion")
        ConecExcel.Close()
        If ConecExcel.State <> ConnectionState.Closed Then
            ConecExcel.Dispose()
        End If
        Return Dts
    End Function
    Dim ObjDataset As New DataSet
    Dim dtsTablaAmort As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Protected Function validarTotalAbonoCapital(ByVal total As Double)
        If total = Math.Round(CDbl(Me.TxtSaldo.Text), 2) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Protected Function validarCuota(ByVal cuota As Double, ByVal abonoK As Double,
                                    ByVal Interes As Double, ByVal SeguroDeuda As Double,
                                    ByVal SegDanios As Double, ByVal SeguroVida As Double,
                                    ByVal SegDesempleo As Double, ByVal Aportacion As Double,
                                    ByVal ahorro As Double, ByVal comisionManejo As Double,
                                    ByVal otros As Double) As Boolean
        Dim total As Double = Math.Round((abonoK + Interes + SeguroDeuda +
        SegDanios + SeguroVida + SegDesempleo +
        Aportacion + ahorro + comisionManejo +
        otros), 2)
        If cuota = total Then
            Return True
        Else
            Return False
        End If
    End Function
    Protected Function validarCuotaNormal(ByVal cuotaNormal As Double, ByVal abonoK As Double, ByVal interes As Double)
        Dim total As Double = Math.Round(abonoK + interes, 2)
        If cuotaNormal = total Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Protected Sub estidoDg()
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.DataGridView1.Columns("SeguroDeuda_Cuota").Visible = False
        Me.DataGridView1.Columns("Cuota_Total").Visible = False
        'Me.DataGridView1.Columns("Interes").Visible = False


    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) 
        Try
            If dtsTablaAmort.Tables.Count > 0 Then
                dtsTablaAmort.Clear()
                dtsTablaAmort.Tables.Clear()
            End If
            calcularCuotaSegDeuda()
            Dim cc As String
            Dim cb As String

            Dim dt As New DataTable("Amortiza")

            Dim i As Integer = 1
            Dim dr As DataRow
            Dim correlativo As New DataColumn("Cuota_Num")
            Dim fechaCuota As New DataColumn("FechaPago")
            Dim MontoCuota As New DataColumn("Cuota_Prestamo")
            Dim SaldoCapital As New DataColumn("Saldo")
            Dim AbonoCapital As New DataColumn("Abono_Capital")
            Dim CuotaInteres As New DataColumn("Cuota_Interes")
            Dim Dias As New DataColumn("Dias_Interes")
            Dim SeguroDeuda As New DataColumn("SeguroDeuda")
            Dim SeguroDanios As New DataColumn("SeguroDanios")
            Dim SeguroVida As New DataColumn("SeguroVida")
            Dim SeguroDesempleo As New DataColumn("SeguroDesempleo")
            Dim Aportacion As New DataColumn("Aportacion")
            Dim Ahorro As New DataColumn("Ahorros")
            Dim ComisionManejo As New DataColumn("ComisionManejo")
            Dim Otros As New DataColumn("Otros")
            Dim SeguroDeudaCuota As New DataColumn("SeguroDeuda_Cuota")
            Dim cuotaTotal As New DataColumn("Cuota_Total")
            Dim Interes As New DataColumn("Interes")
            Dim SeguroVehiculo As New DataColumn("SeguroVehiculo")

            correlativo.DataType = GetType(Integer)
            fechaCuota.DataType = GetType(DateTime)
            MontoCuota.DataType = GetType(Double)
            SaldoCapital.DataType = GetType(Double)
            AbonoCapital.DataType = GetType(Double)
            Interes.DataType = GetType(Double)
            Dias.DataType = GetType(Integer)
            SeguroDeuda.DataType = GetType(Double)
            SeguroDanios.DataType = GetType(Double)
            SeguroVida.DataType = GetType(Double)
            SeguroDesempleo.DataType = GetType(Double)
            Aportacion.DataType = GetType(Double)
            Ahorro.DataType = GetType(Double)
            ComisionManejo.DataType = GetType(Double)
            SeguroDeudaCuota.DataType = GetType(Double)
            cuotaTotal.DataType = GetType(Double)
            CuotaInteres.DataType = GetType(Double)
            SeguroVehiculo.DataType = GetType(Double)

            dt.Columns.Add(correlativo)
            dt.Columns.Add(fechaCuota)
            dt.Columns.Add(MontoCuota)
            dt.Columns.Add(SaldoCapital)
            dt.Columns.Add(AbonoCapital)
            dt.Columns.Add(CuotaInteres)
            dt.Columns.Add(Dias)
            dt.Columns.Add(SeguroDeuda)
            dt.Columns.Add(SeguroDanios)
            dt.Columns.Add(SeguroVida)
            dt.Columns.Add(SeguroDesempleo)
            dt.Columns.Add(Aportacion)
            dt.Columns.Add(Ahorro)
            dt.Columns.Add(ComisionManejo)
            dt.Columns.Add(Otros)
            dt.Columns.Add(SeguroDeudaCuota)
            dt.Columns.Add(cuotaTotal)
            dt.Columns.Add(Interes)
            dt.Columns.Add(SeguroVehiculo)
            dtsTablaAmort.Tables.Add(dt)

            Dim totalAbonoCapital As Double = 0

            Me.OpenFileDialog1.InitialDirectory = "C:"
            Me.OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            Me.OpenFileDialog1.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx||"
            If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ObjDataset = ImportarPartidaExcel(Me.OpenFileDialog1.FileName)
                If ObjDataset.Tables.Count > 0 Then
                    If ObjDataset.Tables(0).Rows.Count > 0 Then
                        For Each row As DataRow In ObjDataset.Tables(0).Rows
                            dr = dtsTablaAmort.Tables("Amortiza").NewRow()
                            If validarCuota(
                            Math.Round(row("CuotaTotal"), 2),
                            Math.Round(row("AbonoCapital"), 2),
                            Math.Round(row("Interes"), 2),
                            Math.Round(row("SeguroDeuda"), 2),
                            Math.Round(row("SeguroDanios"), 2),
                            Math.Round(row("SeguroVida"), 2),
                            Math.Round(row("SeguroDesempleo"), 2),
                            Math.Round(row("Aportacion"), 2),
                            Math.Round(row("Ahorro"), 2),
                            Math.Round(row("ComisionManejo"), 2),
                            Math.Round(row("Otros"), 2)
                                            ) = True And
                                            validarCuotaNormal(
                                            Math.Round(row("CuotaNormal"), 2),
                                            Math.Round(row("AbonoCapital"), 2),
                                            Math.Round(row("Interes"), 2)) = True Then
                                If txtTasa.Text = Math.Round(row("TasaInteres"), 2) Then
                                    dr(0) = row("No")
                                    dr(1) = row("FechaCuota")
                                    dr(2) = Math.Round(row("CuotaNormal"), 2)
                                    dr(3) = Math.Round(row("SaldoCapital"), 2)
                                    dr(4) = Math.Round(row("AbonoCapital"), 2)
                                    dr(5) = Math.Round(row("Interes"), 2)
                                    dr(6) = Math.Round(row("Dias"), 2)
                                    dr(7) = Math.Round(row("SeguroDeuda"), 2)
                                    dr(8) = Math.Round(row("SeguroDanios"), 2)
                                    dr(9) = Math.Round(row("SeguroVida"), 2)
                                    dr(10) = Math.Round(row("SeguroDesempleo"), 2)
                                    dr(11) = Math.Round(row("Aportacion"), 2)
                                    dr(12) = Math.Round(row("Ahorro"), 2)
                                    dr(13) = Math.Round(row("ComisionManejo"), 2)
                                    dr(14) = Math.Round(row("Otros"), 2)
                                    dr(15) = CuotaSeguroDeuda
                                    dr(16) = MontoCuotaTotal
                                    dr(17) = Math.Round(row("TasaInteres"), 2)
                                    totalAbonoCapital = Math.Round(totalAbonoCapital + Math.Round(row("AbonoCapital"), 2), 2)
                                    dtsTablaAmort.Tables("Amortiza").Rows.Add(dr)
                                Else
                                    MsgBox("La tasa de interes de la tabla no coincide con la tasa del préstamo." + vbCrLf + "Fila:" + row("No").ToString, MsgBoxStyle.Critical, "Créditos - Préstamos")
                                    Me.dtsTablaAmort.Tables.Clear()

                                    Exit Sub
                                End If

                            Else
                                MsgBox("El monto de la cuota no coincide con el detalle, por favor revisar." + vbCrLf + "Fila:" + row("No").ToString, MsgBoxStyle.Critical, "Créditos - Préstamos")
                                Me.dtsTablaAmort.Tables.Clear()
                                Exit Sub
                            End If

                        Next
                        If validarTotalAbonoCapital(totalAbonoCapital) = True Then
                            Me.DataGridView1.DataSource = dtsTablaAmort.Tables("Amortiza")
                            estidoDg()
                        Else
                            MsgBox("La sumatoria de el campo abono capital no coincide con el saldo del préstamo, por favor revisar", MsgBoxStyle.Critical, "Crédito - Préstamos")
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.dtsTablaAmort.Tables.Count > 0 Then
                If Me.dtsTablaAmort.Tables(0).Rows.Count > 0 Then
                    If MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        If (prestamo.ReasignarTablaAmortiza(Me.codPrest.Text.Trim, dtsTablaAmort, sUsuario, sPassword, sSucursal)) <> "" Then
                            MetroFramework.MetroMessageBox.Show(Me, "Tabla asignada exitosamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        importarTablaPagos()
        validarSaldoTabla()
    End Sub
    Protected Sub validarSaldoTabla()
        Dim saldo As Double
        For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            saldo += DataGridView1.Item("Abono_Capital", i).Value
        Next
        If saldo <> TxtSaldo.Text Then
            MetroFramework.MetroMessageBox.Show(Me, "Saldo de tabla no coincide con saldo pendiente de préstamo", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            MetroButton1.Enabled = False
        End If
    End Sub

End Class