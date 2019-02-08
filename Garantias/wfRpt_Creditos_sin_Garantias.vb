Imports CrystalDecisions.CrystalReports.Engine
Public Class wfRpt_Creditos_sin_Garantias
    Dim CREDITO As New wrCredito.wsLibCred

    Protected Sub MOSTRAR_REPORTE(ByVal FECHA_INICIO As Date, ByVal FECHA_FIN As Date)
        Dim DTS As New DataSet
        Dim RPT As New RPT_CREDITOSINGARANTIAS
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
        DTS.Clear()
        DTS = CREDITO.CREDITOS_SIN_GARANTIAS(sUsuario, sPassword, sSucursal, FECHA_INICIO, FECHA_FIN)
        RPT.SetDataSource(DTS.Tables("G_RPT_CREDITOS_SIN_GARANTIAS"))
        Me.CrystalReportViewer1.ReportSource = RPT
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            MOSTRAR_REPORTE(Format(Me.dtFECHAINICIO.Value, "SHORT DATE"), Format(Me.dtFECHAFIN.Value, "SHORT DATE"))
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class