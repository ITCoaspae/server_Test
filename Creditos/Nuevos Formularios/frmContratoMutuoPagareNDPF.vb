Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Configuration.ConfigurationManager

Public Class frmContratoMutuoPagareNDPF
    Dim conn As New SqlConnection("Data Source=COOPAS4;Initial Catalog=SFBCoopPr2;User ID=UserSQL;Password=UserSQL")
    'Dim oCon As New conexion
    Protected oAdapter As New SqlDataAdapter
    'Private conn As New SqlConnection(oCon.cadena)
    Protected oParam As New SqlParameter
    Protected ocmd As New SqlCommand
    Protected oReader As SqlDataReader
    Dim Ahorros As New wrAhorro.wsLibAhorro

    Protected Sub Llena_Reporte(ByVal pDUI As String, ByVal pFechaotorgado As Date, ByVal pNoSolicitud As String)
        'Dim conn As New SqlClient.SqlConnection(oCon.cadena)
        Dim ds As New DataSet
        Dim verDatos As New frmVisorReporte
        Dim oReporte As New crvReporteContratoMutuoPagareNDPF

        Try
            conn.Open()
            oAdapter = New SqlDataAdapter("spRptContratoMutuoGerencialesDPF", conn)
            oAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            oAdapter.SelectCommand.Parameters.AddWithValue("@DUI", pDUI)
            oAdapter.SelectCommand.Parameters.AddWithValue("@FechaOtorgado", Format(pFechaotorgado, "short date"))
            oAdapter.SelectCommand.Parameters.AddWithValue("@NoSolicitud", pNoSolicitud)

            oAdapter.Fill(ds, "spRptContratoMutuoGerenciales")
            oReporte.SetDataSource(ds.Tables("spRptContratoMutuoGerenciales"))

            'Aqui lleno los campos formula del reporte, Si el dato a enviar es texto, va entre comillas
            oReporte.DataDefinition.FormulaFields("SerieDPF").Text = "'" & txtSerieDPF.Text & "'"
            oReporte.DataDefinition.FormulaFields("Nocuenta").Text = "'" & txtNocuenta.Text.Trim & "'"
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

    Private Sub txtNocuenta_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtNocuenta.MouseDoubleClick
        If Me.mskDui.Text <> "" Then
            Dim Dts As New DataSet
            Dts = Ahorros.ConsultarCuentaAhorroTipoAhorro("a.Nocuenta,b.descripcion,a.Saldo_CuentaAhorro,a.Estado", "a.Dui ='" & mskDui.Text.Trim & "' and  a.Estado = 'A' and left(a.codtipoahorro,1)not in ('1','2')", "a.CodtipoAhorro", sUsuario, sPassword, sSucursal)
            If Dts.Tables.Count > 0 Then
                If Dts.Tables(0).Rows.Count > 0 Then
                    Dim Frm As New frmAGenerico
                    Frm.Text = "Buscar Cuentas de Ahorro"
                    Frm.Datos = Dts
                    Frm.ColSeleccion = 0
                    Frm.RefrescarGrid()
                    Frm.ShowDialog()
                    If Frm.Resultado.Trim <> "" Then   '
                        Dim Cuenta As String = ""
                        For i As Integer = 0 To Frm.Resultado.Length - 1
                            Select Case Frm.Resultado.Substring(i, 1)
                                Case "0"
                                    Cuenta = Cuenta + " CERO"
                                Case "1"
                                    Cuenta = Cuenta + " UNO"
                                Case "2"
                                    Cuenta = Cuenta + " DOS"
                                Case "3"
                                    Cuenta = Cuenta + " TRES"
                                Case "4"
                                    Cuenta = Cuenta + " CUARTRO"
                                Case "5"
                                    Cuenta = Cuenta + " CINCO"
                                Case "6"
                                    Cuenta = Cuenta + " SEIS"
                                Case "7"
                                    Cuenta = Cuenta + " SIETE"
                                Case "8"
                                    Cuenta = Cuenta + " OCHO"
                                Case "9"
                                    Cuenta = Cuenta + " NUEVE"
                            End Select

                        Next
                        Me.txtNocuenta.Text = Cuenta
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Try
            Call Llena_Reporte(Me.mskDui.Text, Format(Me.dtpFechaOtorgado.Value, "SHORT DATE"), Me.cbNoSolicitud.Text)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub frmContratoMutuoPagareNDPF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class