Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Configuration.ConfigurationManager

Public Class frmContratoMutuoPagareNAPORT
    Dim conn As New SqlConnection("Data Source=COOPAS4;Initial Catalog=SFBCoopPr2;User ID=UserSQL;Password=UserSQL")
    'Dim oCon As New conexion
    Protected oAdapter As New SqlDataAdapter
    'Private conn As New SqlConnection(oCon.cadena)
    Protected oParam As New SqlParameter
    Protected ocmd As New SqlCommand
    Protected oReader As SqlDataReader

    Protected Sub Llena_Reporte(ByVal pDUI As String, ByVal pFechaotorgado As Date, ByVal pNoSolicitud As String)
        'Dim conn As New SqlClient.SqlConnection(oCon.cadena)
        Dim ds As New DataSet
        Dim verDatos As New frmVisorReporte
        Dim oReporte As New crvReporteContratoMutuoPagareNAPORT

        Try
            conn.Open()
            oAdapter = New SqlDataAdapter("spRptContratoMutuoGerenciales", conn)
            oAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            oAdapter.SelectCommand.Parameters.AddWithValue("@DUI", pDUI)
            oAdapter.SelectCommand.Parameters.AddWithValue("@FechaOtorgado", Format(pFechaotorgado, "short date"))
            oAdapter.SelectCommand.Parameters.AddWithValue("@NoSolicitud", pNoSolicitud)

            oAdapter.Fill(ds, "spRptContratoMutuoGerenciales")
            oReporte.SetDataSource(ds.Tables("spRptContratoMutuoGerenciales"))

            'Aqui lleno los campos formula del reporte, Si el dato a enviar es texto, va entre comillas
            'oReporte.DataDefinition.FormulaFields("SerieDPF").Text = "'" & txtSerieDPF.Text & "'"

            'cbNoCuenta.DataSource = ds.Tables(0)
            'cbSaldoCta.DataSource = ds.Tables(0)
            'cbNoDPF.DataSource = ds.Tables(0)

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
        conn.Close()

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mskDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDui.LostFocus
        Try

            Dim oCmd As SqlCommand = New SqlCommand()
            Dim LeerDatos As SqlDataReader
            Dim vDUIAsoc As String
            Dim vNombreAsoc As String

            oCmd.Connection = conn

            conn.Open()
            vDUIAsoc = mskDui.Text
            If Me.mskDui.Text.Trim = "" Then Exit Sub
            oCmd.CommandText = ("SELECT DUI, RTRIM(Nombres)+' '+RTRIM(Apellido1)+' '+RTRIM(Apellido2)+' '+RTRIM(ApellidoCas) AS NombreAsoc " &
                                "FROM CAT_ASOCIADOS WHERE DUI = '" & vDUIAsoc & "'")

            LeerDatos = oCmd.ExecuteReader
            While LeerDatos.Read
                vNombreAsoc = LeerDatos.Item("NombreAsoc")
                txtNombreAsoc.Text = vNombreAsoc
            End While

            LeerDatos.Close()
            conn.Close()

        Catch ex As Exception
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
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
            'Dim vNoSolicitud As String

            conn.Open()
            oCmd.Connection = conn
            vDui = mskDui.Text
            'vNoSolicitud = cbNoSolicitud.Text

            da = New SqlDataAdapter(("SELECT     DAY(dbo.CRSolicitudesCredito.FechaSol) AS DiaPago, dbo.CRSolDatosGeneral.DUI, " &
                      "dbo.CRSolDatosGeneral.Nombres + ' ' + dbo.CRSolDatosGeneral.Apellido1 + ' ' + dbo.CRSolDatosGeneral.Apellido2 + ' ' + dbo.CRSolDatosGeneral.Apellido3 AS NombreAsociadoSol, " &
                      "dbo.CRSolP2Credito.MontoSolicitado, dbo.CRSolP2Credito.Plazo, dbo.CRSolP2Credito.Interes, dbo.CRSolP2Credito.Destino, " &
                      "dbo.CRTiposCredito.Descripcion AS TipoCredito, dbo.CRTipoGarantias.Descripcion AS TipoGarantia, dbo.CRSolDatosGeneral.NumSolicitud " &
                      "FROM dbo.CAT_ASOCIADOS INNER JOIN " &
                      "dbo.CRSolDatosGeneral ON dbo.CAT_ASOCIADOS.DUI = dbo.CRSolDatosGeneral.DUI INNER JOIN " &
                      "dbo.CRSolP2Credito ON dbo.CRSolDatosGeneral.CodEnlace = dbo.CRSolP2Credito.CodEnlace INNER JOIN " &
                      "dbo.CRTiposCredito ON dbo.CRSolP2Credito.CodTipoCredito = dbo.CRTiposCredito.CodTipoCredito INNER JOIN " &
                      "dbo.CRTipoGarantias ON dbo.CRTiposCredito.CodTipoGarantias = dbo.CRTipoGarantias.CodTipoGarantias INNER JOIN " &
                      "dbo.CRSolicitudesCredito ON dbo.CRSolDatosGeneral.NumSolicitud = dbo.CRSolicitudesCredito.NumSolicitud AND  " &
                      "dbo.CRSolP2Credito.NumSolicitud = dbo.CRSolicitudesCredito.NumSolicitud " &
                      "WHERE (CRTiposCredito.Tipo  = 'G' or CRTiposCredito.Tipo  = 'P') AND dbo.CRSolDatosGeneral.DUI='" & vDui & "' "), conn)

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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dispose()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try
            Call Llena_Reporte(Me.mskDui.Text, Format(Me.dtpFechaOtorgado.Value, "SHORT DATE"), Me.cbNoSolicitud.Text)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class