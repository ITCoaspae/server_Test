Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class wfESTADO_RES
    Protected Contabilidad As New wrConta.wsLibContab
#Region "Centro de Costos"
    Public Sub llenarCbCentroCostos()
        Dim dts As New DataSet
        dts = Contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbCC.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub wfESTADO_RES_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbCC.DisplayMember = "Descripcion"
        Me.cbCC.ValueMember = "Cod_Ccosto"
        llenarCbCentroCostos()
    End Sub
#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dts As New DataSet
        If chkSaldosHistoricos.Checked = False Then
            Dts = Contabilidad.Rpt_EstadoResultado(Format(Me.DateTimePicker1.Value, "Short Date"),
                                                   Format(Me.DateTimePicker2.Value, "Short Date"),
                                                   Me.cbCC.SelectedValue)
        Else
            Dts = Contabilidad.Rpt_EstadoResultadoHistorico(Format(Me.DateTimePicker1.Value, "Short Date"),
                                                            Format(Me.DateTimePicker2.Value, "Short Date"))
        End If
        If Dts.Tables(0).Rows.Count > 0 Then
            Dim RPT As New RPT_ESTADOR_RES
            Dim NMES As String
            NMES = MonthName(Month(Me.DateTimePicker1.Value))
            Dim LASTDIA As Integer
            If DateTimePicker2.Value.Month = 2 Then
                If DateTime.IsLeapYear(Year(Me.DateTimePicker2.Value)) = True Then
                    LASTDIA = 29
                Else
                    LASTDIA = 28
                End If
            Else
                LASTDIA = DateTime.DaysInMonth(Me.DateTimePicker1.Value.Year, Me.DateTimePicker2.Value.Month)
            End If
            Dim text As TextObject
            Dim texEnc As TextObject
            texEnc = RPT.Section1.ReportObjects("txtEncabezado")
            text = RPT.Section1.ReportObjects("txtPERIODO")
            texEnc.Text = "SIF . (" + UCase(Me.cbCC.Text) + ")"
            text.Text = UCase("ESTADO DE RESULTADOS DEL 01 DE " & NMES & " AL " & LASTDIA & " DE " & MonthName(Me.DateTimePicker2.Value.Month) & " DE " & Year(DateTimePicker1.Value))
            RPT.SetDataSource(Dts)
            Me.CrystalReportViewer1.ReportSource = RPT
        Else
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim Dts As New DataSet
        If chkSaldosHistoricos.Checked = False Then
            Dts = Contabilidad.Rpt_EstadoResultado(Format(Me.DateTimePicker1.Value, "Short Date"),
                                                   Format(Me.DateTimePicker2.Value, "Short Date"),
                                                   Me.cbCC.SelectedValue)
        Else
            Dts = Contabilidad.Rpt_EstadoResultadoHistorico(Format(Me.DateTimePicker1.Value, "Short Date"),
                                                            Format(Me.DateTimePicker2.Value, "Short Date"))
        End If
        If Dts.Tables(0).Rows.Count > 0 Then
            Dim RPT As New RPT_ESTADOR_RES
            Dim NMES As String
            NMES = MonthName(Month(Me.DateTimePicker1.Value))
            Dim LASTDIA As Integer
            If DateTimePicker2.Value.Month = 2 Then
                If DateTime.IsLeapYear(Year(Me.DateTimePicker2.Value)) = True Then
                    LASTDIA = 29
                Else
                    LASTDIA = 28
                End If
            Else
                LASTDIA = DateTime.DaysInMonth(Me.DateTimePicker1.Value.Year, Me.DateTimePicker2.Value.Month)
            End If
            Dim text As TextObject
            Dim texEnc As TextObject
            texEnc = RPT.Section1.ReportObjects("txtEncabezado")
            text = RPT.Section1.ReportObjects("txtPERIODO")
            texEnc.Text = "SIF . (" + UCase(Me.cbCC.Text) + ")"
            text.Text = UCase("ESTADO DE RESULTADOS DEL 01 DE " & NMES & " AL " & LASTDIA & " DE " & MonthName(Me.DateTimePicker2.Value.Month) & " DE " & Year(DateTimePicker1.Value))
            RPT.SetDataSource(Dts)
            Me.CrystalReportViewer1.ReportSource = RPT
        Else
        End If
    End Sub
End Class