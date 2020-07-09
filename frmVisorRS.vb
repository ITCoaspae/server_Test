Imports Microsoft.Reporting.WinForms

Public Class frmVisorRS
    Dim Planillas As New wrPlanilla.wsLibPlanilla
    Dim Asociados As New wrAsociados.wsLibAsoc
    Dim Seguridad As New wrAdmin.wsLibAdmin
    Dim Bancos As New wrBancos.wsLibBancos
    Dim administracion As New wrAdmin.wsLibAdmin
    Private pDui As String
    Dim vOpcion As Boolean
    Dim vFecha As DateTime
    Dim vNoCaja As Integer
    Dim vCorrelativoMovCaja As Integer
    Dim vTodasCtas As Boolean
    Dim vIdReserva As Integer
    Dim carpetaRs As String
    Dim vCodPrestamo As String
    Dim vIdTipo As Integer 'tipoReversión
    Dim vCodReversion As String
    Dim vFechaIni, vFechaFin As DateTime
#Region "Propiedades Publicas"
    Public Property fechaIni() As DateTime
        Get
            Return vFechaIni
        End Get
        Set(ByVal value As DateTime)
            vFechaIni = value
        End Set
    End Property
    Public Property fechaFin() As DateTime
        Get
            Return vFechaFin
        End Get
        Set(ByVal value As DateTime)
            vFechaFin = value
        End Set
    End Property
    Public Property idTipo() As Integer
        Get
            Return vIdTipo
        End Get
        Set(ByVal value As Integer)
            vIdTipo = value
        End Set
    End Property
    Public Property codReversion() As String
        Get
            Return vCodReversion
        End Get
        Set(ByVal value As String)
            vCodReversion = value
        End Set
    End Property
    Public Property Opcion As Boolean
        Get
            Return vOpcion
        End Get
        Set(ByVal value As Boolean)
            vOpcion = value
        End Set
    End Property
    Public Property idReserva() As Integer
        Get
            Return vIdReserva
        End Get
        Set(ByVal value As Integer)
            vIdReserva = value
        End Set
    End Property
    Public Property todasCtas() As Boolean
        Get
            Return vTodasCtas
        End Get
        Set(ByVal value As Boolean)
            vTodasCtas = value
        End Set
    End Property
    Public Property fecha() As DateTime
        Get
            Return vFecha
        End Get
        Set(ByVal value As DateTime)
            vFecha = value
        End Set
    End Property
    Public Property noCaja() As Integer
        Get
            Return vNoCaja
        End Get
        Set(ByVal value As Integer)
            vNoCaja = value
        End Set
    End Property
    Public Property CorrelativoMovCaja() As Integer
        Get
            Return vCorrelativoMovCaja
        End Get
        Set(ByVal value As Integer)
            vCorrelativoMovCaja = value
        End Set
    End Property
    Public Property dui() As String
        Get
            Return pDui
        End Get
        Set(ByVal value As String)
            pDui = value
        End Set
    End Property
    Public Property codPrstamo() As String
        Get
            Return vCodPrestamo
        End Get
        Set(ByVal value As String)
            vCodPrestamo = value
        End Set
    End Property
#End Region

    Private Sub frmVisorRS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtsConfiguracionRs As New DataSet
        dtsConfiguracionRs = Asociados.ConsultarParametros("rutaRs,urlRs,usuarioRs,contraseniaRs", "", " rutaRs", sUsuario, sPassword, sSucursal)
        If dtsConfiguracionRs.Tables(0).Rows.Count > 0 Then

            Dim RUTA As String
            Dim userRPT As String
            Dim pwdRPT As String
            'Dim carpetaRs As String
            carpetaRs = My.Settings.CarpetaRS
            RUTA = RutaRs(OpcionRS)
            Me.rsVISOR.ServerReport.ReportPath = dtsConfiguracionRs.Tables(0).Rows(0).Item("rutaRs")
            Me.rsVISOR.ServerReport.ReportServerUrl = New Uri(dtsConfiguracionRs.Tables(0).Rows(0).Item("urlRs"))
            userRPT = dtsConfiguracionRs.Tables(0).Rows(0).Item("usuarioRs")  'My.Settings.UserRS
            pwdRPT = dtsConfiguracionRs.Tables(0).Rows(0).Item("contraseniaRs") 'My.Settings.PwdRS

            Me.rsVISOR.ServerReport.ReportServerCredentials.NetworkCredentials = New System.Net.NetworkCredential(userRPT, pwdRPT)
            Me.rsVISOR.ServerReport.ReportPath = RUTA
        End If

        'If OpcionRS = 100 Then
        '    Dim parametro As ReportParameter = New ReportParameter
        '    parametro.Name = "dui"
        '    parametro.Values.Add(pDui)
        '    'parametro.Visible = False
        '    Dim arrayParametros(0) As ReportParameter
        '    arrayParametros(0) = parametro
        '    Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
        '    Me.rsVISOR.RefreshReport()
        'End If
        If OpcionRS = 26 Then
            Dim dtsRoles As New DataSet
            dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
            For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                If Seguridad.ConsultarPermisoProcesos("AHN013", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                    Dim parametro As ReportParameter = New ReportParameter
                    parametro.Name = "CODSUCURSAL"
                    parametro.Values.Add(sSucursal)
                    parametro.Visible = False
                    Dim ArrayParametros(0) As ReportParameter
                    ArrayParametros(0) = parametro
                    Me.rsVISOR.ServerReport.SetParameters(ArrayParametros)
                    Me.rsVISOR.RefreshReport()
                    Exit For
                Else
                    Me.rsVISOR.RefreshReport()
                End If
            Next
        End If
        If OpcionRS = 8 Then
            Dim dtsRoles As New DataSet
            dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
            For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                If Seguridad.ConsultarPermisoProcesos("PRH001", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                    Dim parametro As ReportParameter = New ReportParameter
                    parametro.Name = "SUCURSALES"
                    parametro.Values.Add(sSucursal)
                    parametro.Visible = False
                    Dim ArrayParametros(0) As ReportParameter
                    ArrayParametros(0) = parametro
                    Me.rsVISOR.ServerReport.SetParameters(ArrayParametros)
                    Me.rsVISOR.RefreshReport()
                    Exit For
                Else
                    Me.rsVISOR.RefreshReport()
                End If
            Next
        End If

        If OpcionRS = 108 Or OpcionRS = 109 Or OpcionRS = 107 Then
            Dim dtsRoles As New DataSet
            dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
            For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                If Seguridad.ConsultarPermisoProcesos("PLG001", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                    Dim parametro As ReportParameter = New ReportParameter
                    parametro.Name = "codSucursal"
                    parametro.Values.Add(sSucursal)
                    parametro.Visible = False
                    Dim ArrayParametros(0) As ReportParameter
                    ArrayParametros(0) = parametro
                    Me.rsVISOR.ServerReport.SetParameters(ArrayParametros)
                    Me.rsVISOR.RefreshReport()
                    Exit For
                Else
                    Me.rsVISOR.RefreshReport()
                End If
            Next
        End If
        If OpcionRS = 102 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "noSocio"
            parametro.Values.Add(pDui)
            parametro.Visible = False
            Dim arrayParametros(0) As ReportParameter
            arrayParametros(0) = parametro
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        End If
        If OpcionRS = 97 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "nocuenta"
            parametro.Values.Add(vCodPrestamo)



            parametro.Visible = False

            Dim arrayParametros(0) As ReportParameter
            arrayParametros(0) = parametro

            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        End If
        If OpcionRS = 110 Then
            Dim parametro As ReportParameter = New ReportParameter
            Dim parametro2 As ReportParameter = New ReportParameter
            parametro.Name = "nocuenta"
            parametro.Values.Add(vCodPrestamo)
            parametro2.Name = "codSucursal"
            parametro2.Values.Add(sSucursal)



            parametro.Visible = False
            parametro2.Visible = False
            Dim arrayParametros(1) As ReportParameter
            arrayParametros(0) = parametro
            arrayParametros(1) = parametro2

            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        End If

        If OpcionRS = 90 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "Usuario"
            parametro.Values.Add(sUsuario)
            Dim sucursal As ReportParameter = New ReportParameter
            sucursal.Name = "Sucursal"
            sucursal.Values.Add(sSucursal)
            Dim prestamo As ReportParameter = New ReportParameter
            prestamo.Name = "CodPrestamo"
            prestamo.Values.Add(codPrstamo)
            Dim fechaIni As ReportParameter = New ReportParameter
            fechaIni.Name = "FecIni"
            fechaIni.Values.Add(vFechaIni)
            Dim fechaFin As ReportParameter = New ReportParameter
            fechaFin.Name = "FecFin"
            fechaFin.Values.Add(vFechaFin)
            Dim duip As ReportParameter = New ReportParameter
            duip.Name = "DUI"
            duip.Values.Add(dui)
            Dim opcion As ReportParameter = New ReportParameter
            opcion.Name = "opcion"
            opcion.Values.Add(vOpcion)
            Dim fecHist As ReportParameter = New ReportParameter
            fecHist.Name = "fecHist"
            fecHist.Values.Add(fecha)
            Dim arrayParametros(7) As ReportParameter
            arrayParametros(0) = parametro
            arrayParametros(1) = sucursal
            arrayParametros(2) = prestamo
            arrayParametros(3) = fechaIni
            arrayParametros(4) = fechaFin
            arrayParametros(5) = duip
            arrayParametros(6) = opcion
            arrayParametros(7) = fecHist
            parametro.Visible = False
            sucursal.Visible = False
            prestamo.Visible = False
            opcion.Visible = False
            fechaIni.Visible = False
            fechaFin.Visible = False
            fecHist.Visible = False
            duip.Visible = False

            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)

            Me.rsVISOR.RefreshReport()
        End If

        If OpcionRS = 96 Or OpcionRS = 99 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "dui"
            parametro.Values.Add(pDui)
            parametro.Visible = False

            Dim parametro1 As ReportParameter = New ReportParameter
            parametro1.Name = "numSolicitud"
            parametro1.Values.Add(vCodPrestamo)
            parametro1.Visible = False
            Dim arrayParametros(1) As ReportParameter
            arrayParametros(0) = parametro
            arrayParametros(1) = parametro1
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        End If

        If OpcionRS = 89 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "codTipo"
            parametro.Values.Add(vIdTipo)


            Dim codReversionP As ReportParameter = New ReportParameter
            codReversionP.Name = "codReversion"
            codReversionP.Values.Add(vCodReversion)

            parametro.Visible = False
            codReversionP.Visible = False
            Dim arrayParametros(1) As ReportParameter
            arrayParametros(0) = parametro
            arrayParametros(1) = codReversionP
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        End If
        If OpcionRS = 88 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "codPrestamo"
            parametro.Values.Add(vCodPrestamo)

            Dim usuarioP As ReportParameter = New ReportParameter
            usuarioP.Name = "usuario"
            usuarioP.Values.Add(sUsuario)

            parametro.Visible = False
            usuarioP.Visible = False
            Dim arrayParametros(1) As ReportParameter
            arrayParametros(0) = parametro
            arrayParametros(1) = usuarioP
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        End If


        If OpcionRS = 77 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "DUI"
            parametro.Values.Add(pDui)
            parametro.Visible = False
            Dim arrayParametros(0) As ReportParameter
            arrayParametros(0) = parametro
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        End If

        If OpcionRS >= 78 And OpcionRS <= 80 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "dui"
            parametro.Values.Add(pDui)
            parametro.Visible = False
            Dim arrayParametros(0) As ReportParameter
            arrayParametros(0) = parametro
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        End If
        If OpcionRS = 76 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "dui"
            parametro.Values.Add(pDui)
            parametro.Visible = False
            Dim arrayParametros(0) As ReportParameter
            arrayParametros(0) = parametro
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        End If
        If OpcionRS = 75 Then
            Dim codSucursalP As ReportParameter = New ReportParameter
            Dim UsuarioP As ReportParameter = New ReportParameter
            codSucursalP.Name = "codSucursal"
            UsuarioP.Name = "usuario"
            codSucursalP.Values.Add(sSucursal)
            UsuarioP.Values.Add(sUsuario.ToString.ToUpper)
            codSucursalP.Visible = False
            UsuarioP.Visible = False
            Dim arrayParametro(1) As ReportParameter
            arrayParametro(0) = codSucursalP
            arrayParametro(1) = UsuarioP
            Me.rsVISOR.ServerReport.SetParameters(arrayParametro)
            Me.rsVISOR.RefreshReport()
        End If
        If OpcionRS = 51 Then
            Dim usuarioP As ReportParameter = New ReportParameter
            usuarioP.Name = "usuario"
            usuarioP.Values.Add(sUsuario.ToUpper)
            Dim arrayParametro(0) As ReportParameter
            arrayParametro(0) = usuarioP
            Me.rsVISOR.ServerReport.SetParameters(arrayParametro)
            Me.rsVISOR.RefreshReport()
        End If
        If OpcionRS = 48 Or OpcionRS = 49 Or OpcionRS = 69 Or OpcionRS = 70 Then
            Dim dtsRoles As New DataSet
            dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
            For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                If Seguridad.ConsultarPermisoProcesos("FIA001", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                    Dim parametro As ReportParameter = New ReportParameter
                    parametro.Name = "codSucursal"
                    parametro.Values.Add(sSucursal)
                    parametro.Visible = False
                    Dim ArrayParametros(0) As ReportParameter
                    ArrayParametros(0) = parametro
                    Me.rsVISOR.ServerReport.SetParameters(ArrayParametros)
                    Me.rsVISOR.RefreshReport()
                    Exit For
                Else
                    Me.rsVISOR.RefreshReport()
                End If
            Next

        End If
        If OpcionRS = 44 Or OpcionRS = 45 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "codSucursal"
            parametro.Values.Add(sSucursal)
            parametro.Visible = False
            Dim ArrayParametros(0) As ReportParameter
            ArrayParametros(0) = parametro
            Me.rsVISOR.ServerReport.SetParameters(ArrayParametros)
            Me.rsVISOR.RefreshReport()
        End If
        If OpcionRS = 32 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "CODSUCURSAL"
            parametro.Values.Add(sSucursal)
            parametro.Visible = False
            Dim ArrayParametros(0) As ReportParameter
            ArrayParametros(0) = parametro
            Me.rsVISOR.ServerReport.SetParameters(ArrayParametros)
            Me.rsVISOR.RefreshReport()

            'Me.rsVISOR.ServerReport.Refresh()
        ElseIf OpcionRS = 36 Then
            Dim CodEjecutivoP As ReportParameter = New ReportParameter
            'Dim parametro As ReportParameter = New ReportParameter
            'parametro.Name = "CODSUCURSAL"
            CodEjecutivoP.Name = "CodEjecutivo"
            'Recuperamos CodEmpleado 
            Dim CodEmpleado As String
            Dim DtsEmpleado As DataSet
            Dim CodEjecutivo As String
            Dim DtsEjecutivo As DataSet
            DtsEmpleado = Planillas.ConsultarPLEmpleado("COdEmpleado", " Usuario='" & sUsuario & "'", "", sUsuario, sPassword, sSucursal)
            If DtsEmpleado.Tables(0).Rows.Count > 0 Then
                CodEmpleado = DtsEmpleado.Tables(0).Rows(0).Item("CodEmpleado")
                DtsEjecutivo = Asociados.ConsultarEjecutivosMercadeo("CodEjecMercadeo", " CodEmpleado='" & CodEmpleado & "'", "", sUsuario, sPassword, sSucursal)
                If DtsEjecutivo.Tables(0).Rows.Count > 0 Then
                    CodEjecutivo = DtsEjecutivo.Tables(0).Rows(0).Item("CodEjecMercadeo")
                    CodEjecutivoP.Values.Add(CodEjecutivo)
                End If
            End If
            'parametro.Values.Add(sSucursal)
            CodEjecutivoP.Visible = False
            'parametro.Visible = False
            Dim ArrayParametros(0) As ReportParameter
            ArrayParametros(0) = CodEjecutivoP
            Me.rsVISOR.ServerReport.SetParameters(ArrayParametros)
            Me.rsVISOR.RefreshReport()
        ElseIf OpcionRS = 38 Then
            Dim correlativoP As ReportParameter = New ReportParameter
            correlativoP.Name = "correlativo"
            correlativoP.Values.Add(vCorrelativoMovCaja)
            Dim arrayParametros(0) As ReportParameter
            arrayParametros(0) = correlativoP
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        ElseIf OpcionRS = 39 Then
            Dim dtsRoles As New DataSet
            Dim dtsBoveda As New DataSet
            Dim idBoveda As Integer
            Dim idBovedaParametro As ReportParameter = New ReportParameter
            idBovedaParametro.Name = "id_Boveda"
            dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
            If dtsRoles.Tables.Count > 0 Then
                If dtsRoles.Tables(0).Rows.Count > 0 Then
                    For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                        If Seguridad.ConsultarPermisoProcesos("BCF005", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) = True Then
                            dtsBoveda = Bancos.ConsultarBcBoveda(0, 2, sSucursal)
                            If dtsBoveda.Tables.Count > 0 Then
                                If dtsBoveda.Tables(0).Rows.Count > 0 Then
                                    idBoveda = dtsBoveda.Tables(0).Rows(0).Item("id_Boveda")
                                    idBovedaParametro.Values.Add(idBoveda)
                                    idBovedaParametro.Visible = False
                                    Dim usuarioPa As ReportParameter = New ReportParameter
                                    usuarioPa.Name = "usuarioCrea"
                                    usuarioPa.Values.Add(sUsuario.ToUpper)
                                    Dim arrayParametros(1) As ReportParameter
                                    arrayParametros(0) = idBovedaParametro
                                    arrayParametros(1) = usuarioPa
                                    Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
                                    Me.rsVISOR.RefreshReport()
                                    Exit For
                                    Exit Sub
                                End If
                            End If
                        End If
                    Next

                    Dim usuarioP As ReportParameter = New ReportParameter
                    usuarioP.Name = "usuarioCrea"
                    usuarioP.Visible = False
                    usuarioP.Values.Add(sUsuario.ToUpper)
                    Dim arrayParametro(0) As ReportParameter
                    arrayParametro(0) = usuarioP
                    Me.rsVISOR.ServerReport.SetParameters(arrayParametro)
                    Me.rsVISOR.RefreshReport()
                End If
            End If


            'Dim usuarioP As ReportParameter = New ReportParameter
            'usuarioP.Name = "usuario"
            'usuarioP.Values.Add(sUsuario.ToUpper)
            'Dim arrayParametros(0) As ReportParameter
            'arrayParametros(0) = usuarioP
            'Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
        ElseIf OpcionRS = 71 Then
            Dim parametro1 As ReportParameter = New ReportParameter
            Dim parametro2 As ReportParameter = New ReportParameter
            Dim parametro3 As ReportParameter = New ReportParameter
            parametro1.Name = "dui"
            parametro2.Name = "todos"
            parametro3.Name = "usuario"
            parametro1.Values.Add(pDui)
            parametro2.Values.Add(vTodasCtas)
            parametro3.Values.Add(sUsuario.ToUpper)
            Dim arrayParametros(2) As ReportParameter
            arrayParametros(0) = parametro1
            arrayParametros(1) = parametro2
            arrayParametros(2) = parametro3
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        ElseIf OpcionRS = 40 Then
            Dim dtsRoles
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "codSucursal"
            dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
            If dtsRoles.Tables.Count > 0 Then
                If dtsRoles.Tables(0).Rows.Count > 0 Then
                    For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                        If Seguridad.ConsultarPermisoProcesos("CAH006", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) = True Then
                            parametro.Values.Add(sSucursal)
                            parametro.Visible = False
                        End If
                    Next

                End If
            End If
            Dim arrayParametros(0) As ReportParameter
            arrayParametros(0) = parametro
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()

        ElseIf OpcionRS = 74 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "idReserva"
            parametro.Values.Add(idReserva)
            parametro.Visible = False
            Dim arrayParametros(0) As ReportParameter
            arrayParametros(0) = parametro
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()

            'ElseIf OpcionRS = 56 Or OpcionRS = 57 Then
            '    'If administracion.VerficaDerechos("CAH008", sUsuario, sPassword, sSucursal) = False Then
            '    Dim parametro As ReportParameter = New ReportParameter
            '    parametro.Name = "codSucursal"
            '    parametro.Values.Add(sSucursal)
            '    parametro.Visible = False
            '    Dim ArrayParametros(0) As ReportParameter
            '    ArrayParametros(0) = parametro
            '    Me.rsVISOR.ServerReport.SetParameters(ArrayParametros)
            '    Me.rsVISOR.ServerReport.Refresh()

        ElseIf OpcionRS = 65 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "DUI"
            parametro.Values.Add(pDui)
            parametro.Visible = False
            Dim arrayParametros(0) As ReportParameter
            arrayParametros(0) = parametro
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
        ElseIf OpcionRS = 66 Then
            Dim parametro As ReportParameter = New ReportParameter
            parametro.Name = "DUI"
            parametro.Values.Add(pDui)
            parametro.Visible = False
            Dim arrayParametros(0) As ReportParameter
            arrayParametros(0) = parametro
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
            'ElseIf OpcionRS = 69 Then

            'Else
            '    Me.rsVISOR.RefreshReport()
            'End If
        Else
            Me.rsVISOR.RefreshReport()
        End If

        'Me.rsVISOR.RefreshReport()

    End Sub
    Protected Function RutaRs(ByVal Opcion As Integer)
        Dim Ruta As String
        Select Case Opcion
            '****************************************************************
            'Planillas
            '****************************************************************
            Case 1 'Detalle de descuentos Planilla
                Ruta = "/" & carpetaRs & "/rsDetalleDesc"
            Case 2 'Detalle de Ingresos Planilla
                Ruta = "/" & carpetaRs & "/rsDetalleIngresosPlanilla"
                '-------------------------------------------------------------
                '-------------------------------------------------------------
                'Contabilidad
            Case 3 'Libro de ventas
                Ruta = "/" & carpetaRs & "/rsContaResumenLibroVentas"
            Case 4 'Reportes contabilidad vs Sistema
                Ruta = "/" & carpetaRs & "/rsContaVsSistema"
            Case 5 'Repote de disponibilidad
                Ruta = "/" & carpetaRs & "/rsDisponibilidad"
                '?????????????????????????????????????????????????????????????
                '?????????????????????????????????????????????????????????????
                'Reporte de Asociados
            Case 6 'Detalle de envio de Correos a Asoc. Cumpleañeros.
                Ruta = "/" & carpetaRs & "/rsDetEnvioCorreos"
            Case 7 'Reporte de transacciones en aportaciones
                Ruta = "/" & carpetaRs & "/rsTransaccionesAportaciones"
            '=============================================================
            '=============================================================
            'Repores Financieros
            Case 8 ' Reporte de colocacion de prestamos por sucursal
                Ruta = "/" & carpetaRs & "/rsColocacionPrestamos"
            Case 9 'Reporte de Apertura de Ctas. de Ahorro
                Ruta = "/" & carpetaRs & "/rsColocacionAhorros"
                '=============================================================
                '=============================================================
                'Repores de Cobros y Analisis de Creditos
            Case 10 ' Reporte de colocacion de prestamos por sucursal
                Ruta = "/" & carpetaRs & "/rsGestionesRealizadas"
            Case 11 'Reporte de Apertura de Ctas. de Ahorro
                Ruta = "/" & carpetaRs & "/rsHistorialCategoriasRiesgo"
                '=============================================================
                '=============================================================
                'Repores de Cuadre Diario Operacioens
            Case 12 'Reporte de cuadre diario, creditos desembolsados por sucursal
                Ruta = "/" & carpetaRs & "/rsCierreCreditosDesembolsados"
            Case 13 ' Reporte de cuadre diario por tipo de documento 
                Ruta = "/" & carpetaRs & "/rsCierreDiarioXTipoDoc"
            Case 14 ' Reporte de cuadre diario por rubro
                Ruta = "/" & carpetaRs & "/rsCierrexRubro"
            Case 15 'Detalle de Transferencias por sucursal 
                Ruta = "/" & carpetaRs & "/rsDetalleTransferencias"
            Case 16
                Ruta = "/" & carpetaRs & "/rsContaVsSistema_Prestamos"
            Case 17
                Ruta = "/" & carpetaRs & "/rsDetallePagoPlanillaPrestamos"
            Case 18 ' Saldos prestamos por vencer
                Ruta = "/" & carpetaRs & "/rsPrestamosXVencer"
            Case 19 ' Saldos prestamos y cuotas por vencer
                Ruta = "/" & carpetaRs & "/rsPrestamosyCuotasVencidas"
            Case 20 'Marcaciones Empleados
                Ruta = "/" & carpetaRs & "/rsMarcacionesEmpleados"
            Case 21 'detalle isr
                Ruta = "/" & carpetaRs & "/rsDetRetISR"
            Case 22 'detalle intereses dpf
                Ruta = "/" & carpetaRs & "/rsDetalleIntCap"
            Case 23 'Detalle cargaplanilla ahorros
                Ruta = "/" & carpetaRs & "/rsDetIngresoPlanillaAhorros"
            Case 24 'Colocacion por Garantia
                Ruta = "/" & carpetaRs & "/rsColocacionXGarantia"
            Case 25 'Saldos Prestamos Arreglos Mora
                Ruta = "/" & carpetaRs & "/rsSaldosPrestArreglosMora"
            Case 26 'apertura de cuentas por sucursal
                Ruta = "/" & carpetaRs & "/rsColocacionAhorros"
            Case 27 'Detalle de Transferencia Int de DPF a ctas. de Aportacion en mora
                Ruta = "/" & carpetaRs & "/rsDet_Trans_Int_Cuota_Aport"
            Case 28 'Planificacion Ejecutivos de Mercadeo
                Ruta = "/" & carpetaRs & "/rsConsolidadoComisiones"
            Case 29 'Consolidado Recuperacion
                Ruta = "/" & carpetaRs & "/rsConsolidadoRecuperacion"
            Case 30 'Dias Gracia
                Ruta = "/" & carpetaRs & "/rsDiasGraciaPrestamos"
            Case 31 'Aportaciones Pagadas
                Ruta = "/" & carpetaRs & "/rsAportacionesPagadas"
            Case 32 'Comisiones DPF Promocionales
                Ruta = "/" & carpetaRs & "/rsComisionPromocionesDPF"
            Case 33 'Saldo Carteras Activas'
                Ruta = "/" & carpetaRs & "/rsSaldosCarterasActivas"
            Case 34 'Saldo Carteras Pasivas
                Ruta = "/" & carpetaRs & "/rsSaldosCarterasPasivas"
            Case 35 'Vencimiento Dpf Jefaturas               
                Ruta = "/" & carpetaRs & "/rsVencimientoDPFJefaturas"
            Case 36 'Vencimiento Dpf Ejecutivos
                Ruta = "/" & carpetaRs & "/rsVencimientoDPFEjecutivos"
            Case 37 'Aplicaciones valor fecha
                Ruta = "/" & carpetaRs & "/rsAplicacionesValorFecha"
            Case 38
                Ruta = "/" & carpetaRs & "/rsSolicitudesEfectivoCaja"
            Case 39
                Ruta = "/" & carpetaRs & "/rsMovimientosBoveda"
            Case 40
                Ruta = "/" & carpetaRs & "/rsArqueoCaja"
            Case 41
                Ruta = "/" & carpetaRs & "/rsLibroCompras"
            Case 42
                Ruta = "/" & carpetaRs & "/rsDetalleLibroVentas"
            Case 43
                Ruta = "/" & carpetaRs & "/rsCancelacionesPrestamos"
            Case 44
                Ruta = "/" & carpetaRs & "/rsAsociadonSinCredito"
            Case 45
                Ruta = "/" & carpetaRs & "/rsCartCredUltOtorgado"
            Case 46
                Ruta = "/" & carpetaRs & "/rsIntDPFMundialista"
            Case 47
                Ruta = "/" & carpetaRs & "/rsDetalleTransaccionesEfectivo"
            Case 48
                Ruta = "/" & carpetaRs & "/rsComisionesJefaturasAsist"
            Case 49
                Ruta = "/" & carpetaRs & "/rsComisionesGerenciales"
            Case 50
                Ruta = "/" & carpetaRs & "/rsControlCreditosDPFSolidario"
            Case 51
                Ruta = "/" & carpetaRs & "/rsConstanciaICL"
            Case 52
                Ruta = "/" & carpetaRs & "/rsContaImpuestoDesembolso"
            Case 53
                Ruta = "/" & carpetaRs & "/rsContaImpuestoLiquidez"
            Case 54
                Ruta = "/" & carpetaRs & "/rsCategorizacionSSF"
            Case 55
                Ruta = "/" & carpetaRs & "/rsISR25000"
            Case 56
                Ruta = "/" & carpetaRs & "/rsCuadreCajaAhorros"
            Case 57
                Ruta = "/" & carpetaRs & "/rsCuadreCajaPrestamos"
            Case 58
                Ruta = "/" & carpetaRs & "/rsCuadrePrestamosSucursal"

            Case 59
                Ruta = "/" & carpetaRs & "/rsCuadreAhSucursal"
            Case 60
                Ruta = "/" & carpetaRs & "/rsContaAbonosCargosAhorros"
            Case 61
                Ruta = "/" & carpetaRs & "/rsContaAbonosPrest"
            Case 62
                Ruta = "/" & carpetaRs & "/rsDetSaldosAhorros"
            Case 63
                Ruta = "/" & carpetaRs & "/rsDetSaldosAportaciones"
            Case 64
                Ruta = "/" & carpetaRs & "/rsDetSaldosDPF"
            Case 65
                Ruta = "/" & carpetaRs & "/rsRPTAutorizacionTransferencia"
            Case 66
                Ruta = "/" & carpetaRs & "/rsRPTAutorizacionConsultaInformacion"
            Case 67
                Ruta = "/" & carpetaRs & "/rsPrestHipoAseguradora"
            Case 68
                Ruta = "/" & carpetaRs & "/rsTransaccionesAsoc"
            Case 69
                Ruta = "/" & carpetaRs & "/rsComisionesJefaturas"
            Case 70
                Ruta = "/" & carpetaRs & "/rsControlRutas"
            Case 71
                Ruta = "/" & carpetaRs & "/rsTodasCtasAsoc"
            Case 72
                Ruta = "/" & carpetaRs & "/rsSaldosPrestamosAseguradora"
            Case 73
                Ruta = "/" & carpetaRs & "/rsRenunciadeAsociados"

            Case 75
                Ruta = "/" & carpetaRs & "/rsComprobanteBusquedaLN"
            Case 76
                Ruta = "/" & carpetaRs & "/rsDeclaracionJuradaGA"
            Case 77
                Ruta = "/" & carpetaRs & "/rsRptConozcaSuClientePJ"
            Case 78
                Ruta = "/" & carpetaRs & "/rsFichaIntegralPersonalNatural" '"/rsRptConozcaSuClientePN"
            Case 79
                Ruta = "/" & carpetaRs & "/rsDeclaracionJuradaIngresoDinero"
            Case 80
                Ruta = "/" & carpetaRs & "/rsPersonaExpPolitica"
            Case 81 ' DETALLE CARTERA
                Ruta = "/" & carpetaRs & "/rsDetalleCarteraActivaSucursalEjecutivO"
            Case 82              'MATRIZ RUTAS
                Ruta = "/" & carpetaRs & "/rsDiasGraciaPrestamos"
            Case 83                           'RECUPERACION
                Ruta = "/" & carpetaRs & "/rsConsolidadoRecuperacion"
            Case 84                                        'TASA ACTIVA
                Ruta = "/" & carpetaRs & "/rsTasaActivaTipoPrestamo"
            Case 85                                        'Tdetalle de cartera prprestamos
                Ruta = "/" & carpetaRs & "/rsDetalleCartera"
            Case 86
                Ruta = "/" & carpetaRs & "/rsIngresodeAsociados"
            Case 87
                Ruta = "/" & carpetaRs & "/rsAspirantes"
            Case 88
                Ruta = "/" & carpetaRs & "/rsLiquidacionPrestamo"
            Case 89
                Ruta = "/" & carpetaRs & "/rsComprobanteValorFecha"
            Case 90
                Ruta = "/" & carpetaRs & "/rsEstadoCuentaPrestamos"
            Case 91
                Ruta = "/" & carpetaRs & "/rsDetSaldosAhorros"
            Case 92
                Ruta = "/" & carpetaRs & "/rsDetSaldosAportaciones"
            Case 93
                Ruta = "/" & carpetaRs & "/rsDetSaldosDPF"
            Case 94
                Ruta = "/" & carpetaRs & "/rsTasaPasivaTipoAhorro"
            Case 95
                Ruta = "/" & carpetaRs & "/rsTasaPasivaSucursal"
            Case 96
                Ruta = "/" & carpetaRs & "/rsSolicitudCreditoGerencial"
            Case 97     ' Certificado DPF
                Ruta = "/" & carpetaRs & "/rsCertificadoDPF"
            Case 98
                Ruta = "/" & carpetaRs & "/rsRemesasBanco"
            Case 99
                Ruta = "/" & carpetaRs & "/rsAnalisisCredito"
            Case 100
                Ruta = "/" & carpetaRs & "/rsAnalisisFiador"
            Case 101
                Ruta = "/" & carpetaRs & "/rsTransaccionesBoveda"
            Case 102
                Ruta = "/" & carpetaRs & "/rsFolioLibro"
            Case 103
                Ruta = "/" & carpetaRs & "/rsGestionesCobros"
            Case 104
                Ruta = "/" & carpetaRs & "/rsPrestamosSinGestor"
            Case 105
                Ruta = "/" & carpetaRs & "/rsDetDeduccionesPrestamos"
            Case 106
                Ruta = "/" & carpetaRs & "/rsDeduccionesPrestamos"
            Case 107
                Ruta = "/" & carpetaRs & "/rsComisionesAhorro"
            Case 108
                Ruta = "/" & carpetaRs & "/rsComisionesPrestamo"
            Case 109
                Ruta = "/" & carpetaRs & "/rsComisionesGerenciales"
            Case 110
                Ruta = "/" & carpetaRs & "/rsCertificadoDpf2018"
            Case 111
                Ruta = "/" & carpetaRs & "/rsPagoInteresesDPF"
            Case 112
                Ruta = "/" & carpetaRs & "/rsVehiculos"
            Case 113
                Ruta = "/" & carpetaRs & "/rsDetTransaccionesCajaOC"
            Case 114
                Ruta = "/" & carpetaRs & "/rsCatalogoContable"
            Case 115
                Ruta = "/" & carpetaRs & "/rsBalanceGeneral"
            Case 116
                Ruta = "/" & carpetaRs & "/rsEstadoResultado"
            Case 117
                Ruta = "/" & carpetaRs & "/rsAsociadosInhabilitados"

            Case 118
                Ruta = "/" & carpetaRs & "/rsMatrizExcedentes"
            Case 119
                Ruta = "/" & carpetaRs & "/rsDistribucionExcedentesAhorro"
            Case 120
                Ruta = "/" & carpetaRs & "/rsDistribucionExcentesPrestamo"
            Case 121
                Ruta = "/" & carpetaRs & "/rsDistribucionExcedentesEfectivo"
            Case 122
                Ruta = "/" & carpetaRs & "/rsDistribucionExcedentesExAsociados"
            Case 123
                Ruta = "/" & carpetaRs & "/rsDistribucionExcedentesPendientesCobro"
            Case 124
                Ruta = "/" & carpetaRs & "/rsCargosAbonosAhorros"
            Case 125
                Ruta = "/" & carpetaRs & "/rsCuentasPignoradas"
            Case 126
                Ruta = "/" & carpetaRs & "/rsCancelacionesTipoAhorro"
            Case 222
                Ruta = "/" & carpetaRs & "/rsCobrosAbonosxGestor"
            Case 223
                Ruta = "/" & carpetaRs & "/COBROS_ConsultaCartera"
            Case 224
                Ruta = "/" & carpetaRs & "/COBROS_RPTRutaCobro"
            Case 225
                Ruta = "/" & carpetaRs & "/rsBalanceGeneralCC"
            Case 226
                Ruta = "/" & carpetaRs & "/rsEstadoResultadosPorCostos"
            Case 227
                Ruta = "/" & carpetaRs & "/rsBalanzaPorCostos"
            Case 128
                Ruta = "/" & carpetaRs & "/rsAportaCuotasPend"
            Case 228
                Ruta = "/" & carpetaRs & "/rsCargos_prestamo_conta"
            Case 229
                Ruta = "/" & carpetaRs & "/rsAbono_Prestaomo_Conta"
            Case 230
                Ruta = "/" & carpetaRs & "/rsDetTransaccionesCajaOC"
            Case 231
                Ruta = "/" & carpetaRs & "/rsCosultaCxCPrestamos"
            Case 232
                Ruta = "/" & carpetaRs & "/rsEstadoCta_CtaPorCobrar"
            Case 233
                Ruta = "/" & carpetaRs & "/rsSolicitudRetiro"
            Case 234
                Ruta = "/" & carpetaRs & "/BusinessIntelligence/Autoevaluacion_Con_fiador"
            Case 235
                Ruta = "/" & carpetaRs & "/BusinessIntelligence/Autoevaluacion_Sin_Fiador"
            Case 236
                Ruta = "/" & carpetaRs & "/rsDetalleRenunciaFalleciiento"
            Case 237
                Ruta = "/" & carpetaRs & "/rsMov_cajasSucursal"
            Case 238
                Ruta = "/" & carpetaRs & "/rsMov_cajaPuntoXpress"
        End Select
        Return Ruta
    End Function

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class