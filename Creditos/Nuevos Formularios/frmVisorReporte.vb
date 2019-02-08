Imports CrystalDecisions.CrystalReports.Engine

Public Class frmVisorReporte
    'Parametro que permite recibir el reporte a mostrar en el Visor.
    'Tiene que haber una propiedad Pública de tipo ReportDocument correspondiente a Crystal Reports, además de ahorrar código, podemos
    'importar librerias facilmente.
    Public oReporte As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private Sub frmVisorReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Se llama al Reporte
        Try
            crvVisorReportes.ReportSource = oReporte
            crvVisorReportes.Show()
            ' Me.crvSolicitudCreditoEspecial.Show()

        Catch ex As Exception
            'En caso de existir Error, presentar el porque se genero.
            MsgBox("Ocurrio un Error en FrmVisorReporte_Load" & ex.Message, MsgBoxStyle.Critical, "Contrato")
        End Try


    End Sub
End Class