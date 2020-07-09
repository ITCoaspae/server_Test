Imports Microsoft.Reporting.WinForms


Public Class frmVisorRs_Contratos
    Dim asociados As New wrAsociados.wsLibAsoc
    Private pRuta As String
    Private pNoCuenta As String
    Public Property ruta() As String
        Get
            Return pRuta
        End Get
        Set(ByVal value As String)
            pRuta = value
        End Set
    End Property
    Public Property nocuenta() As String
        Get
            Return pNoCuenta
        End Get
        Set(ByVal value As String)
            pNoCuenta = value
        End Set
    End Property
    Private Sub frmVisorRs_Contratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtsConfiguracionRs As New DataSet
        dtsConfiguracionRs = Asociados.ConsultarParametros("rutaRs,urlRs,usuarioRs,contraseniaRs", "", "", sUsuario, sPassword, sSucursal)
        If dtsConfiguracionRs.Tables(0).Rows.Count > 0 Then

            Dim RUTA As String
            Dim userRPT As String
            Dim pwdRPT As String
            'Dim carpetaRs As String
            'carpetaRs = My.Settings.CarpetaRS
            'RUTA = RutaRs(OpcionRS)
            Me.rsVisor.ServerReport.ReportPath = dtsConfiguracionRs.Tables(0).Rows(0).Item("rutaRs")
            Me.rsVisor.ServerReport.ReportServerUrl = dtsConfiguracionRs.Tables(0).Rows(0).Item("urlRs")
            userRPT = dtsConfiguracionRs.Tables(0).Rows(0).Item("usuarioRs")  'My.Settings.UserRS
            pwdRPT = dtsConfiguracionRs.Tables(0).Rows(0).Item("contraseniaRs") 'My.Settings.PwdRS

            Me.rsVisor.ServerReport.ReportServerCredentials.NetworkCredentials = New System.Net.NetworkCredential(userRPT, pwdRPT)
            Me.rsVisor.ServerReport.ReportPath = RUTA
        End If

        'Dim userRPT As String
        'Dim pwdRPT As String
        'userRPT = My.Settings.UserRS
        'pwdRPT = My.Settings.PwdRS
        'Me.rsVisor.ServerReport.ReportServerCredentials.NetworkCredentials = New System.Net.NetworkCredential(userRPT, pwdRPT)
        'Me.rsVisor.ServerReport.ReportPath = ruta
        Dim parametro As ReportParameter = New ReportParameter
        parametro.Name = "nocuenta"
        parametro.Values.Add(pNoCuenta)
        parametro.Visible = False
        Dim ArrayParametros(0) As ReportParameter
        ArrayParametros(0) = parametro
        Me.rsVisor.ServerReport.SetParameters(ArrayParametros)
        Me.rsVisor.RefreshReport()
    End Sub

    Private Sub frmVisorRs_Contratos_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class