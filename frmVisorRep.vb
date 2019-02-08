Imports CrystalDecisions.CrystalReports.Engine
Public Class frmVisorRep
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim vReporte As String, vReporte2 As String, vReporte3 As String, iMes As Integer, dFechaIni As Date, dFechaFin As Date, vNumPartidaIni As String, vNumPartidaFin As String, vFechaI As String, vFechaF As String
    Dim vTodos As Boolean, vCuenta As String, vCodigoPrestamo As String, vDui As String, vNumSolicitud As String, vAnnio As Integer, vCodTransferencia As Integer
    Dim vCentroCosto As String
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Ahorros As New wrAhorro.wsLibAhorro

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(20, 60)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.SelectionFormula = ""
        Me.crViewer.Size = New System.Drawing.Size(840, 520)
        Me.crViewer.TabIndex = 0
        Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crViewer.ViewTimeSelectionFormula = ""
        '
        'frmVisorRep
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(880, 600)
        Me.Controls.Add(Me.crViewer)
        Me.Name = "frmVisorRep"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte - "
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"
    Public Property Reporte() As sifLib.Contabilidad.clsContabs.ReportesContabilidad
        Get
            Return vReporte
        End Get
        'Set(ByVal Value As AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad)
        Set(ByVal Value As sifLib.Contabilidad.clsContabs.ReportesContabilidad)
            vReporte = Value
        End Set
    End Property
    Public Property ReporteBancos() As sifLib.Bancos.clsBCBancos.ReportesBancos
        Get
            Return vReporte2
        End Get
        'Set(ByVal Value As AlcalaLibs.Bancos.clsBCBanco.ReportesBancos)
        Set(ByVal Value As sifLib.Bancos.clsBCBancos.ReportesBancos)
            vReporte2 = Value
        End Set
    End Property
    Public Property ReportePrestamos() As sifLib.Prestamos.clsPrestamos.ReportesPrestamos
        Get
            Return vReporte3
        End Get
        'Set(ByVal Value As AlcalaLibs.Prestamos.clsPrestamos.ReportesPrestamos)
        Set(ByVal Value As sifLib.Prestamos.clsPrestamos.ReportesPrestamos)
            vReporte3 = Value
        End Set
    End Property
    Public Property Annio() As Integer
        Get
            Return Annio
        End Get
        Set(ByVal Value As Integer)
            vAnnio = Value
        End Set
    End Property
    Public Property Mes() As Integer
        Get
            Return iMes
        End Get
        Set(ByVal Value As Integer)
            iMes = Value
        End Set
    End Property
    Public Property FechaIni() As Date
        Get
            Return dFechaIni
        End Get
        Set(ByVal Value As Date)
            dFechaIni = Value
        End Set
    End Property
    Public Property FechaFin() As Date
        Get
            Return dFechaFin
        End Get
        Set(ByVal Value As Date)
            dFechaFin = Value
        End Set
    End Property
    Public Property NumPartidaIni() As String
        Get
            Return vNumPartidaIni
        End Get
        Set(ByVal Value As String)
            vNumPartidaIni = Value
        End Set
    End Property
    Public Property NumPartidaFin() As String
        Get
            Return vNumPartidaFin
        End Get
        Set(ByVal Value As String)
            vNumPartidaFin = Value
        End Set
    End Property
    Public Property sFechaI() As String
        Get
            Return vFechaI
        End Get
        Set(ByVal Value As String)
            vFechaI = Value
        End Set
    End Property
    Public Property sFechaF() As String
        Get
            Return vFechaF
        End Get
        Set(ByVal Value As String)
            vFechaF = Value
        End Set
    End Property
    Public Property Todos() As Boolean
        Get
            Return vTodos
        End Get
        Set(ByVal Value As Boolean)
            vTodos = Value
        End Set
    End Property
    Public Property Cuenta() As String
        Get
            Return vCuenta
        End Get
        Set(ByVal Value As String)
            vCuenta = Value
        End Set
    End Property
    Public Property CodigoPrestamo() As String
        Get
            Return vCodigoPrestamo
        End Get
        Set(ByVal Value As String)
            vCodigoPrestamo = Value
        End Set
    End Property
    Public Property NumSolicitud() As String
        Get
            Return vNumSolicitud
        End Get
        Set(ByVal Value As String)
            vNumSolicitud = Value
        End Set
    End Property
    Public Property DuiAsociado() As String
        Get
            Return vDui
        End Get
        Set(ByVal Value As String)
            vDui = Value
        End Set
    End Property
    Public Property CodTransferencia() As Integer
        Get
            Return vCodTransferencia
        End Get
        Set(ByVal Value As Integer)
            vCodTransferencia = Value
        End Set
    End Property
    Public Property centroCosto() As String
        Get
            Return vCentroCosto
        End Get
        Set(ByVal value As String)
            vCentroCosto = value
        End Set
    End Property

#End Region

    Private Sub crViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crViewer.Load
        Try
            If Not (vReporte Is Nothing) Then
                Select Case Me.Reporte
                    'Case Is = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.BalanceComprobacion
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.BalanceComprobacion
                        RepBalComprob(Me.Mes)
                        'Case Is = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.CatalogoCuentas
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.CatalogoCuentas
                        RepCatalogoContab()
                        'Case Is = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.CatalogoCentroCostos
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.CatalogoCentroCostos

                        'Case Is = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.CatalogoCentroBeneficios
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.CatalogoCentroBeneficios

                        'Case Is = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.BalanceGeneral
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.BalanceGeneral

                        'Case Is = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.PartidasDiario
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.PartidasDiario

                        RepPartidasDiario(Me.NumPartidaIni, Me.NumPartidaFin, Me.sFechaI, Me.sFechaF)

                        'Case Is = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.AuxiliardeMayor
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.AuxiliardeMayor
                        RepAuxMayor(Me.Mes, Me.FechaIni, Me.FechaFin)

                        'Case Is = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.DiarioMayor
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.DiarioMayor
                        RepDiarioMayor(Me.Mes, Me.FechaIni, Me.FechaFin)

                        'Case Is = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.PartidasDiarioAut
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.PartidasDiarioAut
                        RepPartidasDiarioAut(Me.NumPartidaIni, Me.NumPartidaFin, Me.sFechaI, Me.sFechaF)
                End Select
            End If
            If Not (vReporte2 Is Nothing) Then
                Select Case Me.ReporteBancos
                    'Case Is = AlcalaLibs.Bancos.clsBCBanco.ReportesBancos.ChequesEmitidos
                    Case Is = sifLib.Bancos.clsBCBancos.ReportesBancos.ChequesEmitidos
                        RepBcoChequesEmitidos(Me.Todos, Me.Cuenta, Me.sFechaI, Me.sFechaF)
                End Select
            End If
            If Not (vReporte3 Is Nothing) Then
                Select Case Me.ReportePrestamos
                    'Case Is = AlcalaLibs.Prestamos.clsPrestamos.ReportesPrestamos.EstadoCuenta
                    Case Is = sifLib.Prestamos.clsPrestamos.ReportesPrestamos.EstadoCuenta
                        RepPREstadoCuenta(Me.CodigoPrestamo.Trim, Me.DuiAsociado.Trim, Me.FechaIni, Me.FechaFin)

                        'Case Is = AlcalaLibs.Prestamos.clsPrestamos.ReportesPrestamos.EstadoCuentaReal
                    Case Is = sifLib.Prestamos.clsPrestamos.ReportesPrestamos.EstadoCuentaReal
                        RepPREstadoCuentaReal(Me.CodigoPrestamo.Trim, Me.DuiAsociado.Trim, Me.FechaIni, Me.FechaFin)

                        'Case Is = AlcalaLibs.Prestamos.clsPrestamos.ReportesPrestamos.DetallePrestamo
                    Case Is = sifLib.Prestamos.clsPrestamos.ReportesPrestamos.DetallePrestamo
                        RepPRDetallePrestamo(Me.CodigoPrestamo.Trim, Me.NumSolicitud, Me.DuiAsociado.Trim, Me.Cuenta, Date.Now)

                        'Case Is = AlcalaLibs.Prestamos.clsPrestamos.ReportesPrestamos.DetalleSolicitud
                    Case Is = sifLib.Prestamos.clsPrestamos.ReportesPrestamos.DetalleSolicitud
                        RepPRDetalleSolicitud(Me.CodigoPrestamo.Trim, Me.DuiAsociado.Trim, Me.Cuenta, Date.Now)
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RepBalComprob(ByVal pMes As Integer)
        Dim oRpt As New crCTBBalComprob
        Dim ds As New DataSet
        Dim oRep As New wrConta.wsLibContab
        Try
            ds = oRep.RepBalComprob(pMes, FechaIni.Year, sUsuario, sPassword, sSucursal, centroCosto)
            oRpt.SetDataSource(ds)
            crViewer.ReportSource = oRpt
            Me.Text = "Reporte - Balanza de Comprobación"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepCatalogoContab()
        Dim oRpt As New crCTBCatContab
        Dim ds As New DataSet
        Dim oRep As New wrConta.wsLibContab
        Try
            ds = oRep.RepObtenerCatContab("IdCuenta,Descripcion,Nivel,Tipo_Cuenta,Cta_Dependencia,Final,Legal,Inhabilitado", "", "IdCuenta", sUsuario, sPassword, sSucursal)
            oRpt.SetDataSource(ds)
            crViewer.ReportSource = oRpt
            Me.Text = "Reporte - Catálogo de Cuentas Contables"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepPartidasDiarioAut(ByVal pNumPartidaIni As String, ByVal pNumPartidaFin As String, ByVal pFecIni As String, ByVal pFecFin As String)
        Dim oRpt As New crPartidas
        Dim ds As New DataSet
        Dim oRep As New wrConta.wsLibContab
        Try
            ds = oRep.RepPartidasDiarioAut(pNumPartidaIni, pNumPartidaFin, pFecIni, pFecFin, sUsuario, sPassword, sSucursal)
            oRpt.SetDataSource(ds)
            crViewer.ReportSource = oRpt
            Me.Text = "Reporte - Partidas de Diario"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepPartidasDiario(ByVal pNumPartidaIni As String, ByVal pNumPartidaFin As String, ByVal pFecIni As String, ByVal pFecFin As String)
        Dim oRpt As New crPartidas
        Dim ds As New DataSet
        Dim oRep As New wrConta.wsLibContab
        Try
            ds = oRep.RepPartidasDiario(pNumPartidaIni, pNumPartidaFin, pFecIni, pFecFin, sUsuario, sPassword, sSucursal)
            oRpt.SetDataSource(ds)
            crViewer.ReportSource = oRpt
            Me.Text = "Reporte - Partidas de Diario"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepAuxMayor(ByVal pMes As Integer, ByVal pFecIni As String, ByVal pFecFin As String)
        Dim oRpt As New crAuxMayor
        Dim ds As New DataSet
        Dim oRep As New wrConta.wsLibContab
        Try
            ds = oRep.RepAuxMayor(pMes, pFecIni, pFecFin, vAnnio, sUsuario, sPassword, sSucursal)
            oRpt.SetDataSource(ds)
            crViewer.ReportSource = oRpt
            Me.Text = "Reporte - Libro Auxiliar de Mayor"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepDiarioMayor(ByVal pMes As Integer, ByVal pFecIni As String, ByVal pFecFin As String)
        Dim oRpt As New crDiarioMayor
        Dim ds As New DataSet
        Dim oRep As New wrConta.wsLibContab
        Try
            ds = oRep.RepDiarioMayor(pMes, pFecIni, pFecFin, vAnnio, sUsuario, sPassword, sSucursal)
            oRpt.SetDataSource(ds)
            crViewer.ReportSource = oRpt
            Me.Text = "Reporte - Libro Diario Mayor"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepBcoChequesEmitidos(ByVal pTodos As Boolean, ByVal pCuenta As String, ByVal pFechaIni As String, ByVal pFechaFin As String)
        Dim oRpt As New crBCChequesEmitidos
        Dim ds As New DataSet
        Dim oRep As New wrBancos.wsLibBancos
        Try
            ds = oRep.RepChequesEmitidos(pTodos, pCuenta, pFechaIni, pFechaFin, sUsuario, sPassword, sSucursal)
            oRpt.SetDataSource(ds)
            crViewer.ReportSource = oRpt
            Me.Text = "Reporte - Cheques Emitidos"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepPREstadoCuenta(ByVal pcodPrestamo As String, ByVal pDUI As String, ByVal pFechaIni As Date, ByVal pFechaFin As Date)
        Dim oRpt As New crPREstadoCuenta
        Dim oPr As New wrPrestamo.wsLibPrest, ds As System.Data.DataSet
        Try
            oPr.Timeout = -1
            ds = oPr.RepEstadoCuenta(pcodPrestamo, pFechaIni.ToShortDateString, pFechaFin.ToShortDateString, pDUI, sUsuario, sPassword, sSucursal)
            If ds Is Nothing Then
                MessageBox.Show("No hay datos disponibles para este rango de fechas.", "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            oRpt.SetDataSource(ds)
            crViewer.ReportSource = oRpt
            Me.Text = "Reporte - Estado de Cuenta Préstamo"
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación del reporte. - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RepPREstadoCuentaReal(ByVal pcodPrestamo As String, ByVal pDUI As String, ByVal pFechaIni As Date, ByVal pFechaFin As Date)
        Dim oRpt As New crPREstadoCuentaReal
        Dim oPr As New wrPrestamo.wsLibPrest, ds As System.Data.DataSet
        Try
            ds = oPr.RepEstadoCuentaReal(pcodPrestamo, pFechaIni.ToShortDateString, pFechaFin.ToShortDateString, pDUI, sUsuario, sPassword, sSucursal)
            If ds Is Nothing Then
                MessageBox.Show("No hay datos disponibles para este rango de fechas.", "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            oRpt.SetDataSource(ds)
            crViewer.ReportSource = oRpt
            Me.Text = "Reporte - Estado de Cuenta Préstamo"
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación del reporte. - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#Region "Funciones Modificadas 21/09/2011 Javier Martinez"
    'Private Sub RepPRDetallePrestamo(ByVal pcodPrestamo As String, ByVal pNumSolicitud As String, ByVal pDUI As String, ByVal pTipoHonorario As String, ByVal pFecha As Date)
    '    Dim oRpt As New crDetallePrestamo, oPrest As New wrPrestamo.wsLibPrest
    '    Dim oPr As New wrPrestamo.wsLibPrest, ds As New System.Data.DataSet, dsCh As New System.Data.DataSet
    '    Try
    '        ds = oPr.RepDetallePrestamo(pcodPrestamo, pFecha, pDUI, pTipoHonorario, sUsuario, sPassword, sSucursal)
    '        dsCh = oPrest.ConsultarPRCheques("*", "NumSolicitud='" & pNumSolicitud.Trim & "'", "", sUsuario, sPassword, sSucursal)
    '        oRpt.SetDataSource(ds)
    '        oRpt.OpenSubreport("crCheque").SetDataSource(dsCh)
    '        crViewer().ReportSource = oRpt
    '        Me.Text = "Reporte - Detalle de Préstamo"

    '    Catch ex As Exception
    '        MessageBox.Show("Error en la recuperación del reporte- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub RepPRDetalleSolicitud(ByVal pcodPrestamo As String, ByVal pDUI As String, ByVal pTipoHonorario As String, ByVal pFecha As Date)
    '    Dim oRpt As New crDetallePrestamo, oPrest As New wrPrestamo.wsLibPrest
    '    Dim oPr As New wrPrestamo.wsLibPrest, ds As New System.Data.DataSet, dsCh As New System.Data.DataSet
    '    Try
    '        ds = oPr.RepDetalleSolicitud(pcodPrestamo, pFecha, pDUI, pTipoHonorario, sUsuario, sPassword, sSucursal)
    '        dsCh = oPrest.ConsultarPRCheques("*", "NumSolicitud=" & pcodPrestamo & "", "", sUsuario, sPassword, sSucursal)
    '        oRpt.SetDataSource(ds)
    '        oRpt.OpenSubreport("crCheque").SetDataSource(dsCh)
    '        crViewer().ReportSource = oRpt
    '        Me.Text = "Reporte - Detalle de Solicitud"
    '    Catch ex As Exception
    '        MessageBox.Show("Error en la recuperación del reporte- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    ' End Sub

#End Region
    'Funciones Corregidas 21/09/2011 Javier Martinez
    Public x As Integer
    Private Sub RepPRDetallePrestamo(ByVal pcodPrestamo As String, ByVal pNumSolicitud As String, ByVal pDUI As String, ByVal pTipoHonorario As String, ByVal pFecha As Date)
        '//* MODIFICADO EL 17/02/2012 
        '//* SE AGREGP JEFE SUC. LAS CASCADAS 
        '//* AUTOR:JAVIER MARTINEZ
        Dim oRpt As New crDetallePrestamoTran, oPrest As New wrPrestamo.wsLibPrest
        Dim oPr As New wrPrestamo.wsLibPrest, ds As New System.Data.DataSet, dsCh As New System.Data.DataSet
        Dim text As TextObject
        Dim SELECCION As Integer
        Dim CARGO As String
        SELECCION = x
        'If SELECCION = 0 Then
        '    CARGO = "JEFE OPERACIONES C.F."
        'ElseIf SELECCION = 1 Then
        '    CARGO = "JEFE SUC. METROCENTRO"
        'ElseIf SELECCION = 2 Then
        '    CARGO = "JEFE SUC. PLAZA MUNDO"
        'ElseIf SELECCION = 3 Then
        '    CARGO = "JEFE SUC. LAS CASCADAS"
        'End If
        Try
            ds = oPr.RepDetallePrestamo(pcodPrestamo, pFecha, pDUI, pTipoHonorario, sUsuario, sPassword, sSucursal)
            dsCh = Bancos.Consultar_BcMovCheques(1, "", "", "", Now, pNumSolicitud)
            If dsCh.Tables(0).Rows.Count > 0 Then
                oRpt.SetDataSource(ds)
                oRpt.Subreports(0).SetDataSource(dsCh.Tables(0))
                'oRpt.OpenSubreport("DetalleCheques").SetDataSource(dsCh)
                'text = oRpt.Section4.ReportObjects("txtCARGO")
                'text.Text = CARGO
                crViewer().ReportSource = oRpt
                Me.Text = "Reporte - Detalle de Préstamo"
            Else
                Dim rpt As New crDetallePrestamoTran
                dsCh = Ahorros.ConsultarTransferencia(" b.NoCuenta,rtrim(c.Nombres)+' '+rtrim(c.Apellido1)+' '+rtrim(c.Apellido2)+' '+rtrim(c.ApellidoCas)[Asociado]," & _
                                                      "case when b.IdCuenta = '21020101' then 'A la Vista' " & _
                                                      "when b.IdCuenta ='31010101' then 'Aportaciones' end [TipoCta],b.Valor", _
                                                      "a.numsolicitud = " & pNumSolicitud & " and b.Tipo = 'A' and left(b.IdCuenta,8) In ('21020101','31010101') /*and len(b.NoCuenta)=12*/ ", " a.codtransferencia", _
                                                       0, sUsuario, sPassword, sSucursal)
                rpt.SetDataSource(ds)
                rpt.Subreports(0).SetDataSource(dsCh.Tables(0))
                'text = rpt.Section4.ReportObjects("txtCARGO")
                'text.Text = CARGO
                crViewer().ReportSource = rpt
                Me.Text = "Reporte - Detalle de Préstamo"

            End If
            ''dsCh = oPrest.ConsultarPRCheques("*", "NumSolicitud='" & pNumSolicitud.Trim & "'", "", sUsuario, sPassword, sSucursal)
            'oRpt.SetDataSource(ds)
            'oRpt.Subreports(0).SetDataSource(dsCh.Tables(0))
            ''oRpt.OpenSubreport("DetalleCheques").SetDataSource(dsCh)
            ''oRpt.OpenSubreport("crCheque").SetDataSource(dsCh)
            'text = oRpt.Section4.ReportObjects("txtCARGO")
            'text.Text = CARGO
            'crViewer().ReportSource = oRpt
            'Me.Text = "Reporte - Detalle de Préstamo"
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación del reporte- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RepPRDetalleSolicitud(ByVal pcodPrestamo As String, ByVal pDUI As String, ByVal pTipoHonorario As String, ByVal pFecha As Date)
        '//* MODIFICADO EL 17/02/2012 
        '//* SE AGREGO JEFE SUC. LAS CASCADAS 
        '//* AUTOR:JAVIER MARTINEZ
        Dim oRpt As New crDetallePrestamo, oPrest As New wrPrestamo.wsLibPrest
        Dim oPr As New wrPrestamo.wsLibPrest, ds As New System.Data.DataSet, dsCh As New System.Data.DataSet
        Dim text As TextObject
        Dim SELECCION As Integer
        Dim CARGO As String
        SELECCION = x
        'If SELECCION = 0 Then
        '    CARGO = "JEFE OPERACIONES C.F."
        'ElseIf SELECCION = 1 Then
        '    CARGO = "JEFE SUC. METROCENTRO"
        'ElseIf SELECCION = 2 Then
        '    CARGO = "JEFE SUC. PLAZA MUNDO"
        'ElseIf SELECCION = 3 Then
        '    CARGO = "JEFE SUC. LAS CASCADAS"
        'End If
        Try
            ds = oPr.RepDetalleSolicitud(pcodPrestamo, pFecha, pDUI, pTipoHonorario, sUsuario, sPassword, sSucursal)
            dsCh = Bancos.Consultar_BcMovCheques(1, "", "", "", Now, pcodPrestamo)
            If dsCh.Tables.Count > 0 Then
                If dsCh.Tables(0).Rows.Count > 0 Then
                    oRpt.SetDataSource(ds)
                    oRpt.Subreports(0).SetDataSource(dsCh.Tables(0))
                    'oRpt.OpenSubreport("DetalleCheques").SetDataSource(dsCh)
                    'text = oRpt.Section4.ReportObjects("txtCARGO")
                    'text.Text = CARGO
                    crViewer().ReportSource = oRpt
                    Me.Text = "Reporte - Detalle de Solicitud"
                Else
                    Dim rpt As New crDetallePrestamoTran
                    dsCh = Ahorros.ConsultarTransferencia(" b.NoCuenta,rtrim(c.Nombres)+' '+rtrim(c.Apellido1)+' '+rtrim(c.Apellido2)+' '+rtrim(c.ApellidoCas)[Asociado]," &
                                                          "case when b.IdCuenta = '21020101' then 'A la Vista' " &
                                                          "when b.IdCuenta ='31010101' then 'Aportaciones' end [TipoCta],b.Valor",
                                                          "a.numsolicitud = " & pcodPrestamo & " and b.Tipo = 'A' and left(b.IdCuenta,8) In ('21020101','31010101') /*and len(b.NoCuenta)=12*/ ", " a.codtransferencia",
                                                           0, sUsuario, sPassword, sSucursal)
                    rpt.SetDataSource(ds)
                    rpt.Subreports(0).SetDataSource(dsCh.Tables(0))
                    'text = rpt.Section4.ReportObjects("txtCARGO")
                    'text.Text = CARGO
                    crViewer().ReportSource = rpt
                    Me.Text = "Reporte - Detalle de Solicitud"
                End If
            Else
                oRpt.SetDataSource(ds)
                crViewer().ReportSource = oRpt
                Me.Text = "Reporte - Detalle de Solicitud"
            End If
            
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación del reporte- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class