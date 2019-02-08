Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Reporting
Imports CrystalDecisions.ReportSource
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Net
Imports System.ComponentModel
Public Class frmMsProgressBar
    Dim Planilla As New wrPlanilla.wsLibPlanilla
    Public codplanilla As Integer
    Public FechaInicio, FechaFin As DateTime
    Public Sub LlenarPb(ByVal Max As Integer, ByVal Min As Integer)
        Me.pb.Maximum = Max
        Me.pb.Minimum = Min
    End Sub
    Public Function envioBoleta() As Long
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim CodEmpleado As String
            Dim Correo As String
            Dim Empleado As String
            Dim Envio As Boolean
            Dim Ruta As String
            Dim Directorio As String
            codplanilla = codplanilla
            FechaInicio = FechaInicio
            FechaFin = FechaFin
            Dim Dts_rpt As New DataSet
            Dim DtsEmpleados As New DataSet
            Dim Dts As New DataSet 'Dts con direcciones de correo electronico y nombres de los empleados
            Dts = Planilla.CorreoEmpleados_Boleta(codplanilla)
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.pb.Maximum = Dts.Tables(0).Rows.Count - 1
                Me.pb.Minimum = 0
                For j As Integer = 0 To Dts.Tables(0).Rows.Count - 1
                    CodEmpleado = Dts.Tables(0).Rows(j).Item("CODEMPLEADO").ToString.Trim
                    Correo = Dts.Tables(0).Rows(j).Item("Email").ToString.Trim
                    Empleado = Dts.Tables(0).Rows(j).Item("Empleado").ToString.Trim
                    Dts_rpt.Clear()
                    DtsEmpleados = Planilla.Reporte_BoletaPagos("", "", CodEmpleado, FechaInicio, FechaFin, 4)
                    Dim dtI As New DataTable
                    Dim dtD As New DataTable
                    dtI = Planilla.Detalle_Ingresos_BoletaPagos("", "", CodEmpleado, FechaInicio, FechaFin, 4)
                    dtD = Planilla.Detalle_Descuentos_BoletaPagos("", "", CodEmpleado, FechaInicio, FechaFin, 4)
                    Dts_rpt = GenerarBoleta(DtsEmpleados, dtI, dtD)
                    If Dts_rpt.Tables(0).Rows.Count > 0 Then
                        Dim rpt As New crBoletaPago
                        rpt.SetDataSource(Dts_rpt.Tables(0))
                        Directorio = System.IO.Directory.GetCurrentDirectory + "\Boletas\CodPlanila" & codplanilla.ToString
                        System.IO.Directory.CreateDirectory(Directorio)
                        Ruta = Directorio + "\" + CodEmpleado + ".doc"
                        rpt.ExportToDisk(ExportFormatType.WordForWindows, Ruta)
                        Try
                            If EnviarCorreo(True, "", "recursoshumanos@coopas.com.sv", Correo, "Boleta de Pagos " & Empleado.Trim, "Boleta de Pagos Correspondiente al " & _
                                                         Format(FechaInicio, "SHORT DATE") & " - " & Format(FechaFin, "SHORT DATE"), Ruta) = False Then
                                Me.lbNoEnviados.Items.Add(Empleado.Trim)
                            Else
                                Me.lbEnviados.Items.Add(Empleado.Trim)
                            End If
                            Me.pb.Value = j
                            Me.lblPorciento.Text = CStr((Math.Round(j / pb.Maximum, 2)) * 100) & " %"
                            Application.DoEvents()
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
                        End Try
                    End If
                Next
                Me.btnGuardar1.Enabled = False
                MsgBox("Proceso de envio de boletas de pago finalizado", MsgBoxStyle.Information, "Módulo - Planillas")
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If MsgBox("¿Desea realizar esta acción?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Planillas") = 6 Then
                Me.btnGuardar1.Enabled = False
                envioBoleta()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function GenerarBoleta(ByVal dts As DataSet, ByVal dtI As DataTable, ByVal dtD As DataTable) As DataSet
        Dim DtsBoleta As New DataSet
        Dim DtsTablaFinal As New DataTable
        Dim row2 As DataRow
        DtsTablaFinal.TableName = "PL_DETALLE_BOLETAPAGOS"
        DtsTablaFinal.Columns.Add("EMPLEADO", GetType(String))
        DtsTablaFinal.Columns.Add("CodEmpleado", GetType(String))
        DtsTablaFinal.Columns.Add("INGRESOS", GetType(String))
        DtsTablaFinal.Columns.Add("MONTOINGRESO", GetType(Double))
        DtsTablaFinal.Columns.Add("DESCUENTO", GetType(String))
        DtsTablaFinal.Columns.Add("MONTODESCUENTOS", GetType(Double))
        DtsTablaFinal.Columns.Add("AFP", GetType(Double))
        DtsTablaFinal.Columns.Add("ISSS", GetType(Double))
        DtsTablaFinal.Columns.Add("Renta", GetType(Double))
        DtsTablaFinal.Columns.Add("TotalRecibir", GetType(Double))
        DtsTablaFinal.Columns.Add("TotalRetenido", GetType(Double))
        DtsTablaFinal.Columns.Add("OtrosDesc", GetType(Double))
        DtsTablaFinal.Columns.Add("OTROSINGRESOS", GetType(Double))
        DtsTablaFinal.Columns.Add("CARGO", GetType(String))
        DtsTablaFinal.Columns.Add("DEPARTAMENTO", GetType(String))
        DtsTablaFinal.Columns.Add("AREA", GetType(String))
        DtsTablaFinal.Columns.Add("FECHAINGRESO", GetType(Date))
        DtsTablaFinal.Columns.Add("CodArea", GetType(String))
        DtsTablaFinal.Columns.Add("CodDepartamento", GetType(String))
        DtsTablaFinal.Columns.Add("FechaPlaIni", GetType(Date))
        DtsTablaFinal.Columns.Add("FechaPlaFin", GetType(Date))
        DtsTablaFinal.Columns.Add("DT", GetType(Integer))
        DtsTablaFinal.Columns.Add("SueldoQuincenal", GetType(Double))
        DtsTablaFinal.Columns.Add("NoCuenta", GetType(String))
        DtsTablaFinal.Columns.Add("SueldoMensual", GetType(Double))
        Dim dtDatos As New DataTable
        dtDatos = dts.Tables(0)
        Dim codempleado2 As String
        Dim TotalEmpleados As Integer
        Dim Descuento As String
        Dim dtDescuentos As New DataTable
        dtDescuentos.TableName = "DetalleDescuentosEmpleados"
        dtDescuentos.Columns.Add("Descripcion", GetType(String))
        dtDescuentos.Columns.Add("Valor", GetType(Double))
        dtDescuentos.Columns.Add("CodEmpleado", GetType(String))
        Dim dtIngresos As New DataTable
        dtIngresos.TableName = "DetalleIngresosEmpleados"
        dtIngresos.Columns.Add("INGRESO", GetType(String))
        dtIngresos.Columns.Add("Monto", GetType(Double))
        dtIngresos.Columns.Add("CodEmpleado", GetType(String))
        Dim RowsDescuentos As DataRow()
        Dim RowsIngresos As DataRow()
        Dim Ingreso As String
        Dim MontoDescuento As Double
        Dim MontoIngreso As Double
        Dim TotalDescuentos As Integer
        Dim TotalIngresos As Integer
        Dim filas As Integer
        TotalEmpleados = dtDatos.Rows.Count
        For i As Integer = 0 To TotalEmpleados - 1
            codempleado2 = dtDatos.Rows(i).Item("Codempleado").ToString
            RowsDescuentos = (dtD.Select("codempleado='" & codempleado2 & "'"))
            For Each row As DataRow In RowsDescuentos
                dtDescuentos.ImportRow(row)
            Next
            RowsIngresos = dtI.Select("codempleado='" & codempleado2 & "'")
            For Each row As DataRow In RowsIngresos
                dtIngresos.ImportRow(row)
            Next
            TotalDescuentos = dtDescuentos.Rows.Count
            TotalIngresos = dtIngresos.Rows.Count
            If TotalDescuentos > TotalIngresos Then
                filas = TotalDescuentos
            ElseIf TotalIngresos > TotalDescuentos Then
                filas = TotalIngresos
            Else
                filas = TotalDescuentos
            End If
            If filas > 0 Then
                For j As Integer = 0 To filas - 1
                    If j <= TotalDescuentos Then
                        If dtDescuentos.Rows.Count - 1 >= 0 Then
                            Try
                                Descuento = dtDescuentos.Rows(j).Item("Descripcion").ToString.Trim
                                MontoDescuento = dtDescuentos.Rows(j).Item("Valor")
                            Catch ex As Exception
                                Descuento = ""
                                MontoDescuento = 0.0
                            End Try

                        End If
                    End If
                    If j <= TotalIngresos Then
                        If dtIngresos.Rows.Count - 1 >= 0 Then
                            Try
                                Ingreso = dtIngresos.Rows(j).Item("INGRESO").ToString.Trim
                                MontoIngreso = dtIngresos.Rows(j).Item("Monto")
                            Catch ex As Exception
                                Ingreso = ""
                                MontoIngreso = 0.0
                            End Try
                        End If
                    End If
                    row2 = DtsTablaFinal.NewRow
                    row2("EMPLEADO") = dtDatos.Rows(i).Item("Empleado").ToString
                    row2("CodEmpleado") = codempleado2
                    row2("INGRESOS") = Ingreso
                    row2("MONTOINGRESO") = MontoIngreso
                    row2("DESCUENTO") = Descuento
                    row2("MONTODESCUENTOS") = MontoDescuento
                    row2("AFP") = dtDatos.Rows(i).Item("AFP")
                    row2("ISSS") = dtDatos.Rows(i).Item("ISSS")
                    row2("Renta") = dtDatos.Rows(i).Item("Renta")
                    row2("TotalRecibir") = dtDatos.Rows(i).Item("TotalRecibir")
                    row2("TotalRetenido") = dtDatos.Rows(i).Item("TotalRetenido")
                    row2("OtrosDesc") = dtDatos.Rows(i).Item("OtrosDesc")
                    row2("OTROSINGRESOS") = dtDatos.Rows(i).Item("OTROSINGRESOS")
                    row2("CARGO") = dtDatos.Rows(i).Item("CARGO")
                    row2("DEPARTAMENTO") = dtDatos.Rows(i).Item("DEPARTAMENTO")
                    row2("AREA") = dtDatos.Rows(i).Item("AREA")
                    row2("FECHAINGRESO") = dtDatos.Rows(i).Item("FECHAINGRESO")
                    row2("CodArea") = dtDatos.Rows(i).Item("CodArea")
                    row2("CodDepartamento") = dtDatos.Rows(i).Item("CodDepartamento")
                    row2("FechaPlaIni") = dtDatos.Rows(i).Item("FechaPlaIni")
                    row2("FechaPlaFin") = dtDatos.Rows(i).Item("FechaPlaFin")
                    row2("DT") = dtDatos.Rows(i).Item("DT")
                    row2("SueldoQuincenal") = dtDatos.Rows(i).Item("SueldoQuincenal")
                    row2("NoCuenta") = dtDatos.Rows(i).Item("NoCuenta")
                    row2("SueldoMensual") = dtDatos.Rows(i).Item("SueldoMensual")
                    DtsTablaFinal.Rows.Add(row2)
                    Descuento = ""
                    MontoDescuento = 0
                    Ingreso = ""
                    MontoIngreso = 0
                Next
            Else
                row2 = DtsTablaFinal.NewRow
                row2("EMPLEADO") = dtDatos.Rows(i).Item("Empleado").ToString
                row2("CodEmpleado") = codempleado2
                row2("INGRESOS") = Ingreso
                row2("MONTOINGRESO") = MontoIngreso
                row2("DESCUENTO") = Descuento
                row2("MONTODESCUENTOS") = MontoDescuento
                row2("AFP") = dtDatos.Rows(i).Item("AFP")
                row2("ISSS") = dtDatos.Rows(i).Item("ISSS")
                row2("Renta") = dtDatos.Rows(i).Item("Renta")
                row2("TotalRecibir") = dtDatos.Rows(i).Item("TotalRecibir")
                row2("TotalRetenido") = dtDatos.Rows(i).Item("TotalRetenido")
                row2("OtrosDesc") = dtDatos.Rows(i).Item("OtrosDesc")
                row2("OTROSINGRESOS") = dtDatos.Rows(i).Item("OTROSINGRESOS")
                row2("CARGO") = dtDatos.Rows(i).Item("CARGO")
                row2("DEPARTAMENTO") = dtDatos.Rows(i).Item("DEPARTAMENTO")
                row2("AREA") = dtDatos.Rows(i).Item("AREA")
                row2("FECHAINGRESO") = dtDatos.Rows(i).Item("FECHAINGRESO")
                row2("CodArea") = dtDatos.Rows(i).Item("CodArea")
                row2("CodDepartamento") = dtDatos.Rows(i).Item("CodDepartamento")
                row2("FechaPlaIni") = dtDatos.Rows(i).Item("FechaPlaIni")
                row2("FechaPlaFin") = dtDatos.Rows(i).Item("FechaPlaFin")
                row2("DT") = dtDatos.Rows(i).Item("DT")
                row2("SueldoQuincenal") = dtDatos.Rows(i).Item("SueldoQuincenal")
                row2("NoCuenta") = dtDatos.Rows(i).Item("NoCuenta")
                row2("SueldoMensual") = dtDatos.Rows(i).Item("SueldoMensual")
                DtsTablaFinal.Rows.Add(row2)
            End If
            TotalDescuentos = 0
            TotalIngresos = 0
            dtDescuentos.Clear()
            dtIngresos.Clear()
        Next
        DtsBoleta.Tables.Add(DtsTablaFinal)
        Return DtsBoleta
    End Function

End Class
