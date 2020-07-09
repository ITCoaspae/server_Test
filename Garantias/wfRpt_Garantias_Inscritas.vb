Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class wfRpt_Garantias_Inscritas
    Dim CREDITO As New wrCredito.wsLibCred
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Protected Sub MOSTRAR_REPORTES(ByVal FECHA_INICIO As DateTime, ByVal FECHA_FIN As DateTime, ByVal OPCION As Integer)
        Dim DTS As New DataSet
        Dim RPT As New RPT_GARANTIAS_INSCRITAS
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
        DTS = CREDITO.RPT_GARANTIAS_INSCRITAS(sUsuario, sPassword, sSucursal, FECHA_INICIO, FECHA_FIN, OPCION)
        RPT.SetDataSource(DTS.Tables(0))
        Me.CrystalReportViewer1.ReportSource = RPT
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim FECHAI As DateTime
            Dim FECHAF As DateTime
            Dim OPCION As Integer
            If Me.cbMOSTRARTODOS.Checked = True Then
                OPCION = 1
            Else
                OPCION = 2
            End If
            FECHAI = Format(Me.dtpFECHAINI.Value, "SHORT DATE")
            FECHAF = Format(Me.dtpFECHAFIN.Value, "SHORT DATE")
            MOSTRAR_REPORTES(FECHAI, FECHAF, OPCION)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblFechaInicio_Click(sender As Object, e As EventArgs) Handles lblFechaInicio.Click

    End Sub

    Private Sub dtpFECHAFIN_ValueChanged(sender As Object, e As EventArgs) Handles dtpFECHAFIN.ValueChanged

    End Sub

    Private Sub lblFechaFin_Click(sender As Object, e As EventArgs) Handles lblFechaFin.Click

    End Sub

    Private Sub dtpFECHAINI_ValueChanged(sender As Object, e As EventArgs) Handles dtpFECHAINI.ValueChanged

    End Sub

    Private Sub cbMOSTRARTODOS_CheckedChanged(sender As Object, e As EventArgs) Handles cbMOSTRARTODOS.CheckedChanged

    End Sub
End Class