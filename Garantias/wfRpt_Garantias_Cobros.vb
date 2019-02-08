Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class wfRPT_GARANTIAS_COBROS
    Dim CREDITO As New wrCredito.wsLibCred
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Protected Sub LLENAR_RPT(ByVal FECHA_INICIO As DateTime, ByVal FECHA_FIN As DateTime)
        Dim DTS As New DataSet
        ' DTS.Clear()
        DTS = CREDITO.RPT_GARANTIAS_X_DEPTO(sUsuario, sPassword, sSucursal, FECHA_INICIO, FECHA_FIN, 1)
        Dim RPT As New RPT_GARANTIAS_COBROS
        Dim text As TextObject
        Dim MINI As String
        Dim MFIN As String
        Dim AÑOINI, AÑOFIN As String
        Dim NMESINI, NMESFIN As Integer
        NMESINI = Month(FECHA_INICIO)
        NMESFIN = Month(FECHA_FIN)
        AÑOINI = Year(FECHA_INICIO)
        AÑOFIN = Year(FECHA_FIN)
        MINI = MonthName(NMESINI)
        MFIN = MonthName(NMESFIN)
        text = RPT.Section1.ReportObjects("txtPERIODO")
        text.Text = UCase("DEL " & FECHA_INICIO.Day.ToString & " de " & MINI & " de " & AÑOINI.ToString & _
        " al " & FECHA_FIN.Day & " de " & MFIN & " de " & AÑOFIN.ToString)
        RPT.SetDataSource(DTS.Tables("SP_RPT_GARANTIAS_COBROS"))
        Me.CrystalReportViewer1.ReportSource = RPT
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            LLENAR_RPT(Format(Me.dtFECHAINICIO.Value, "SHORT DATE"), Format(Me.dtFECHAFIN.Value, "SHORT DATE"))
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class