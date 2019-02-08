Imports System.Data
Imports System.Data.SqlClient
'Imports Microsoft.Office.Interop.Excel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Configuration.ConfigurationManager

Public Class frmContratoCreditoGerencial
    'Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Protected oAdapter As New SqlDataAdapter
    Private oConn As New SqlConnection
    Protected oParam As New SqlParameter
    Protected ocmd As New SqlCommand
    Protected oReader As SqlDataReader
    'Dim conn As New SqlConnection(connectionString:=AppSettings("PRODUCCION"))
    Dim conn As New SqlConnection("Data Source=COOPAS4;Initial Catalog=SFBCoopPr2;User ID=UserSQL;Password=UserSQL")


    Protected Sub Llena_Reporte(ByVal pDUI As String) ', ByVal pNumSolicitud As String, ByVal pFechaSol As Date)

        Try
            Dim oDS As New DataSet
            Dim verDatos As New frmVisorReporte
            Dim oReporte As New crvSolicitudCreditoEspecial

            conn.Open()
            oAdapter = New SqlDataAdapter("spRptSolicitudCreditoGerencial", Me.conn)
            oAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            oAdapter.SelectCommand.Parameters.AddWithValue("@DUI", pDUI)
            'oAdapter.SelectCommand.Parameters.AddWithValue("@NumSolicitud", pNumSolicitud)
            'oAdapter.SelectCommand.Parameters.AddWithValue("@FechaSol", pFechaSol)
            oAdapter.Fill(oDS, "spRptSolicitudCreditoGerencial")
            oReporte.SetDataSource(oDS.Tables("spRptSolicitudCreditoGerencial"))
            verDatos.oReporte = oReporte
            verDatos.ShowDialog()
            frmVisorReporte.crvVisorReportes.ReportSource = oReporte
            conn.Close()
        Catch ex As Exception
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
            'En caso de existir Error, presentar el porque se genero.
            MsgBox("Ocurrio un Error en Reporte: " & ex.Message, MsgBoxStyle.Critical, "Modulo")
        End Try

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dispose()
    End Sub
    Private Sub mskDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDui.LostFocus
        Try


            Dim LeerDatos As SqlDataReader            'Dim ds As New DataSet
            'oCmd.Connection = conn

            Dim vDUIAsoc As String
            Dim vNombreAsoc As String
            vDUIAsoc = mskDui.Text
            If Me.mskDui.Text.Trim = "" Then Exit Sub
            conn.Open()
            Dim oCmd As SqlCommand = New SqlCommand("SELECT DUI, RTRIM(Nombres)+' '+RTRIM(Apellido1)+' '+RTRIM(Apellido2)+' '+RTRIM(ApellidoCas) AS NombreAsoc FROM CAT_ASOCIADOS WHERE DUI = '" & vDUIAsoc & "'", Me.conn)
            oCmd.CommandType = CommandType.Text
            ' oCmd.CommandText = ("SELECT DUI, RTRIM(Nombres)+' '+RTRIM(Apellido1)+' '+RTRIM(Apellido2)+' '+RTRIM(ApellidoCas) AS NombreAsoc FROM CAT_ASOCIADOS WHERE DUI = '" & vDUIAsoc & "'")

            LeerDatos = oCmd.ExecuteReader
            While LeerDatos.Read
                vNombreAsoc = LeerDatos.Item("NombreAsoc")
                txtNombreAsoc.Text = vNombreAsoc
            End While
            conn.Close()
        Catch ex As Exception
            If conn.State <> ConnectionState.Closed Then
                conn.Dispose()
            End If
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub cbNoSolicitud_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNoSolicitud.GotFocus

        Try
            Dim oCmd As SqlCommand = New SqlCommand()
            Dim da As New SqlDataAdapter
            Dim ds As New DataSet
            Dim vDui As String

            conn.Open()
            oCmd.Connection = conn
            vDui = mskDui.Text

            da = New SqlDataAdapter(("SELECT dbo.CRSolicitudesCredito.NumSolicitud, dbo.CRSolicitudesCredito.FechaSol, " &
                                                    "DAY(dbo.CRSolicitudesCredito.FechaSol) as DiaPago, dbo.CRSolicitudesCredito.CodSucursal, " &
                                                    "dbo.CRSolicitudesCredito.Estado, dbo.CRSolDatosGeneral.DUI, " &
                                                    "dbo.CRSolDatosGeneral.Nombres + ' ' + dbo.CRSolDatosGeneral.Apellido1 + ' ' + " &
                                                    "dbo.CRSolDatosGeneral.Apellido2 + ' ' + dbo.CRSolDatosGeneral.Apellido3 AS NombreAsociadoSol, " &
                                                    "dbo.CRSolP2Credito.MontoSolicitado, dbo.CRSolP2Credito.Plazo,dbo.CRSolP2Credito.Interes, dbo.CRSolP2Credito.Destino, " &
                                                    "dbo.CRTiposCredito.Descripcion as TipoCredito, dbo.CRTipoGarantias.Descripcion AS TipoGarantia " &
                                                    "FROM  dbo.CAT_ASOCIADOS INNER JOIN dbo.CRSolDatosGeneral ON dbo.CAT_ASOCIADOS.DUI = dbo.CRSolDatosGeneral.DUI " &
                                                    "RIGHT OUTER JOIN  dbo.CRSolicitudesCredito ON dbo.CRSolDatosGeneral.NumSolicitud = dbo.CRSolicitudesCredito.NumSolicitud " &
                                                    "LEFT OUTER JOIN dbo.CRSolP2Credito INNER JOIN dbo.CRTiposCredito INNER JOIN " &
                                                    "dbo.CRTipoGarantias ON dbo.CRTiposCredito.CodTipoGarantias = dbo.CRTipoGarantias.CodTipoGarantias ON " &
                                                    "dbo.CRSolP2Credito.CodTipoCredito = dbo.CRTiposCredito.CodTipoCredito ON " &
                                                    "dbo.CRSolicitudesCredito.NumSolicitud = dbo.CRSolP2Credito.NumSolicitud " &
                                                    "WHERE (dbo.CRSolicitudesCredito.FechaSol=CONVERT(VARCHAR,GETDATE(),103) ) AND (CRTiposCredito.Tipo  = 'G' or CRTiposCredito.Tipo  = 'P') AND  dbo.CRSolDatosGeneral.DUI = '" & vDui & "'"), conn)


            da.Fill(ds)

            cbNoSolicitud.DataSource = ds.Tables(0)
            cbNoSolicitud.DisplayMember = "NumSolicitud"
            conn.Close()

        Catch ex As Exception
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
            'En caso de existir Error, presentar el porque se genero.
            MsgBox("Ocurrio un Error en Reporte: " & ex.Message, MsgBoxStyle.Critical, "Modulo")
        End Try
    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try
            Call Llena_Reporte(Me.mskDui.Text)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmContratoCreditoGerencial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

