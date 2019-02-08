Public Class frmVisorLib
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager


#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New(ByVal ds As DataSet, ByVal nReport As Integer, ByVal nLin As Integer, ByVal nLib As Integer)
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)
        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)
        Me.nReport = nReport
        Me.nUltLinea = nLin
        Me.nLibreta = nLib
        PoblarReporte(ds)

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    'Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crView As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crView = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crView
        '
        Me.crView.ActiveViewIndex = -1
        Me.crView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crView.Cursor = System.Windows.Forms.Cursors.Default
        Me.crView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crView.Location = New System.Drawing.Point(20, 60)
        Me.crView.Name = "crView"
        Me.crView.SelectionFormula = ""
        Me.crView.Size = New System.Drawing.Size(840, 520)
        Me.crView.TabIndex = 0
        Me.crView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crView.ViewTimeSelectionFormula = ""
        '
        'frmVisorLib
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(880, 600)
        Me.Controls.Add(Me.crView)
        Me.Name = "frmVisorLib"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Visor de Reportes"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim nReport As Integer, dSet As New Data.DataSet, nUltLinea As Integer, nMaxLinea As Integer, nLibreta As Integer

    Public Property MaxLinea() As Integer
        Get
            Return nMaxLinea
        End Get
        Set(ByVal Value As Integer)
            nMaxLinea = Value
        End Set
    End Property

    Public Property NumeroReporte() As Integer
        Get
            Return nReport
        End Get
        Set(ByVal Value As Integer)
            nReport = Value
        End Set
    End Property

    Public Property ds() As DataSet
        Get
            Return dSet
        End Get
        Set(ByVal Value As DataSet)
            dSet = Value
        End Set
    End Property

    Public Property UltimaLinea() As Integer
        Get
            Return nUltLinea
        End Get
        Set(ByVal Value As Integer)
            nUltLinea = Value
        End Set
    End Property

    Private Sub PoblarReporte(ByVal ds As DataSet)
        Select Case nReport
            Case 0, 1
                Dim crTemp As New crCartaAsociado
                Me.Cursor = Cursors.WaitCursor()
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
                If nReport = 0 Then
                    Me.Text = "Carta de Retirados"
                Else
                    Me.Text = "Carta de Asociados"
                End If
            Case 2
                Dim crTemp As New crBalGral
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
                Me.Text = "Reporte - Balance General"
            Case 3
                Dim crTemp As New crEstRes
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 4
                Dim crTemp As New crMovxCuenta
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 5
                Dim crTemp As New crIngresoAsoc
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 7
                Dim crTemp As New crCheque
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 8 'ORDEN DE DESCUENTO - PR�STAMOS
                Dim crTemp As New crPrOrden_Descuento
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 9 'REPORTE DE PR�STAMOS POR INTER�S
                Dim crTemp As New crPrestamosxInteres
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 10
                Dim crTemp As New crMovimientosIngresoCaja
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 11
                Dim crTemp As New crCADepositoRetiro
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 12
                Dim crTemp As New crCAEmisionFacturaConsumidorfinal
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 13
                'Dim crTemp As New crCAEmisionFacturaCreditoFiscal
                Dim crTemp As New crCAFacturaPR
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 14
                Dim crTemp As New rpCBCorbosxGestiones
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 15
                Dim crTemp As New crAhAperturaCtas
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 16
                Dim crTemp As New crAhAperturaCtasDPF
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 17
                Dim crTemp As New crComprobanteAhorro 'crAhFactura
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 18
                Dim crTemp As New crAhLibretaAhorros
                Me.Cursor = Cursors.WaitCursor
                'ds.WriteXml("C:\ds.xml")
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 19
                Dim crTemp As New crReporteCorteCaja
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 20
                Dim crTemp As New crReporteEstadoCuentaAhorroAportacion
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 21
                Dim crTemp As New crAhPosteo
                Me.Cursor = Cursors.WaitCursor


                Dim oAsoc As New wrAsociados.wsLibAsoc, dr As DataRow, dsAsoc As New DataSet, pMaxPag As Integer
                dsAsoc = oAsoc.ConsultarParametros("MaxNumLibreta,movPagLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)

                If dsAsoc.Tables(0).Rows.Count > 0 Then
                    dr = dsAsoc.Tables(0).Rows(0)
                    nMaxLinea = dr("MaxNumLibreta")
                    pMaxPag = dr("movPagLibreta")
                End If
                If Me.nLibreta = 1 Then
                    'If nUltLinea < pMaxPag Then
                    crTemp.Section6.Height = 1000 + (240 * nUltLinea)
                        'Else
                        '    crTemp.Section6.Height = 240 * (nUltLinea - 35)
                        'End If
                    Else
                    ' If (nUltLinea - ((Fix(nUltLinea / nMaxLinea)) * nMaxLinea)) < pMaxPag Then
                    crTemp.Section6.Height = 1000 + (240 * (nUltLinea - ((Fix(nUltLinea / nMaxLinea)) * nMaxLinea)))
                        'Else
                        '    crTemp.Section6.Height = 240 * ((nUltLinea - ((Fix(nUltLinea / nMaxLinea)) * nMaxLinea)) - 35)
                        'End If
                    End If
                crTemp.Section6.Height = 1000 + (240 * nUltLinea)
                crTemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 22 'REPORTE DE PR�STAMOS POR PLAZO
                Dim crTemp As New crPrestamosxPlazo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 23
                Dim crTemp As New crCaFacturaAp
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 24
                Dim crTemp As New crCACreditoFiscalPR
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 25
                Dim crTemp As New crRetiroAsoc
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 26
                Dim crTemp As New crCACreditoFiscalAp
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 27 'Factura Consumidor Final Gen�rico
                Dim crTemp As New crCaFacturaGr
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 28 'Cr�dito Fiscal Gen�rico
                Dim crTemp As New crCaCreditoFiscalGr
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 29 'Movimientos x Cheque
                Dim crTemp As New crMovCheques
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 30 'Corte de Caja
                Dim crTemp As New crCorteMovCaja
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 31 'Nuevos Asociados
                Dim crTemp As New crNuevosAsociados
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 32 'Cobros por Inactividad
                Dim crTemp As New crCobroInactividad
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 33 'Listado Carter de Pr�stamos
                Dim crTemp As New crListadoCarteraPrestamo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 34 'Consulta Amortizaci�n
                Dim crTemp As New crRptTablaAmortiza
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 35 'Renuncia de Asociados
                Dim crTemp As New crSolicitudRenunciaAsociado
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 36 'Intereses Diarios
                Dim crTemp As New crPagoInteresDiarioDepPlazo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 37 'Concentraci�n por Gestor
                Dim crTemp As New crCBConcentracionGestion
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 38 'Recuperaci�n por Gestor
                Dim crTemp As New crCBRecuperacionxGestor
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 39 'Tabla Amortiza Simulada
                Dim crTemp As New crTablaAmortizaSimulada
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 40 'Listado Cr�ditos sin Pago
                Dim crTemp As New crListadoCreditosSinPagoMesXGestion
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 41 'Cartera de Pr�stamos por Ejecutivo
                Dim crTemp As New crCarteraPrestamosXEjecutivo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 42 'Cartera de Pr�stamos por Garant�a
                Dim crTemp As New crCarteraPrestamoXCodTipoGarantia
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 43 'Planilla
                Dim crTemp As New crPlanilla
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 44 'Docs. x Cobrar
                Dim crTemp As New crDocsxCobrar
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 45 'Carta Informativa
                Dim crTemp As New crCartaInformativa
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 46 'Colocaci�n de Pr�stamos
                Dim crTemp As New crRepColocacionCredito
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 47 'Colocaci�n de Pr�stamos
                Dim crTemp As New crAperturaCred
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 48 'Vencimientos Cuentas de Ahorro
                Dim crTemp As New crAhVencimientosAhorro
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 49 'Captaci�n DPF Acumulado
                Dim crTemp As New crAcumuladoDPF
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 50 'Pr�stamos Gerenciales
                Dim crTemp As New crPrestamosGerenciales
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 51 'Ingreso Asociados
                Dim crTemp As New crGerIngresoAsoc
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 52 'Apertura Aportaciones
                Dim crTemp As New crAperturaAportacion
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 53 'Resumen Movimientos de Caja agrupados por Documentos
                Dim crTemp As New crMovCajaxDoc
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 54 'Resumen Movimientos de Caja agrupados por Transacci�n
                Dim crTemp As New crMovCajaxTransac
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 55 'Corte de Movimientos de Caja (Cuenta Contable)
                Dim crTemp As New crMovCaja
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 56 'Nota de Cargo
                Dim crTemp As New crNotaCargo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 57 'Arqueo de Caja
                Dim crTemp As New crArqueoCaja
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 58 'Nota de Cargo Pr�stamo
                Dim crTemp As New crNotaCargoPrestamo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 59 'REPORTE MOVIMIENTOS DIARIOS DE ABONOS A PRESTAMOS
                Dim crTemp As New crMovAbonoPrestamo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 60 'REPORTE MOVIMIENTOS DIARIOS DE AHORROS
                Dim crTemp As New crRepMovimientosAhorros
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 61 'REPORTE DE SALDOS DE APORTACIONES
                Dim crTemp As New crSaldosAportacion
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 62 'REPORTE DE SALDOS POR DEPOSITOS A PLAZO FIJO (DPF)
                Dim crTemp As New crSaldosDPF
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 63 'REPORTE DE SALDOS CUENTAS DE AHORRO
                Dim crTemp As New crSaldosAhorros
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 64 'REPORTE DE SALDO DE PRESTAMOS PARA ASEGURADORA
                Dim crTemp As New crSaldoPrestamoAseguradora
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 65 'REPORTE CUENTAS DE ASOCIADOS
                Dim crTemp As New crASCuentasAsociado
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 66 'REPORTE DE INTERESES POR ASOCIADOS
                Dim crTemp As New crAhorroInteresxAsociado
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 67 'Recibo Provisional
                Dim crTemp As New crRecibo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 68 'REPORT DE SALDOS POR ASOCIADO
                Dim crTemp As New crSaldosAsociado
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 69 'REPORTE DE SALDOS DE PR�STAMOS ADMINISTRATIVOS
                Dim crTemp As New crSaldosPrestamosAdm
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 70 'Reporte de Saldos por Tipos de Pr�stamos
                Dim crTemp As New crPRRepSaldosPrestamosxTipo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 71 'Reporte de Saldos por L�neas de Pr�stamos
                Dim crTemp As New crPRRepSaldosPrestamosxLinea
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 72 'REPORTE DE SALDOS DE CUENTAS DE APORTACI�N CANCELADAS
                Dim crTemp As New crSaldosCtasCanceladas
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 73 'REPORTE DE VENCIMIENTOS DPF
                Dim crTemp As New crVencimientos_DPF
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 74 'REPORTE DE TRANSFERENCIAS
                Dim crTemp As New crTransferencias
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 75 'RETIRO DE ASOCIADOS
                Dim crTemp As New crRetiros_Asociados
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 76 'REPORTE DIARIO DE ASOCIADOS EN MORA
                Dim crTemp As New crAsociados_Mora
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 77 'CARTERA EN DOCUMENTOS EN PROTESTO CON RESERVA
                Dim crTemp As New crDocProtesto_Reserva
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 79 'ASOCIADOS INHABILITADOS
                Dim crTemp As New crAsociados_Inhabilitados
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 80 'REPORTE PARA DETALLE DE FIADORES
                Dim crTemp As New crFiadoresPrestamos
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 81 ' RECIBO DE DIVIDENDOS
                Dim crTemp As New crReciboDiv
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 82 'REPORTE DE CUENTAS INACTIVAS
                Dim crTemp As New crCtasInact
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 83 'Reporte de Reversiones diarias
                Dim crTemp As New crReversiones
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 84 'REPORTE CONSOLIDADO DE CARTERA EN DOCUMENTOS EN PROTESTO CON RESERVA 
                Dim crTemp As New crCarteraDocProtestoReserva
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 85 'REPORTE CONSOLIDADO DE CARTERA DE DEPOSITOS A PLAZO FIJO (DPF)
                Dim crTemp As New crGerencialCarteraDPF
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 86 'REPORTE GERENCIAL CON GARANTIAS DPF EN MORA
                Dim crTemp As New crGarantiaDPFMora
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 87 'REPORTE DE MOVIMIENTOS EN CUENTAS DE AHORROS
                Dim crTemp As New crGerencial_MovCuentasAhorro
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 88 'REPORTE DE DATOS DPF
                Dim crTemp As New crDatosDPF
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 89 'IMPRESI�N DE CERTIFICADO DPF
                Dim crTemp As New crCertificadoDPF
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 90 'COMISIONES DE MERCADEO
                Dim crTemp As New crComisiones
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 91 'REPORTE DE DATOS DE PR�STAMOS
                Dim crTemp As New crDatosPrestamos
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 92 'C�LCULO DE CUOTA PARA PR�STAMOS
                Dim crTemp As New crCuota
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 93 'REPORTE DE PROVISI�N DE CUENTAS DE AHORRO
                Dim crTemp As New crProvisiones_Ahorros
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 94 'REPORTE DE PROVISI�N DE PR�STAMOS
                Dim crTemp As New crProvisiones_Prestamos
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 95 'RECIBO DE ABONO DE ANTICIPOS A EMPLEADOS
                Dim crTemp As New crAbonosAnticipos
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 96 'DETALLE DE APERTURA DE CAJA
                Dim crTemp As New crDetalle_Apertura
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 97 'REPORTE DE SALDOS DE APORTACIONES CANCELADAS POR PER�ODO
                Dim crTemp As New crCuentas_Canceladas
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 98 'REPORTE DE CUENTAS PIGNORADAS POR TIPO DE CUENTA
                Dim crTemp As New crCuentas_Pignoradas
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 99 'REPORTE DE APLICACIONES VALOR FECHA PARA PR�STAMOS
                Dim crTemp As New crReversiones_Prestamos
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 100 'REPORTE DE MOVIMIENTOS DE CAJA
                Dim crTemp As New crMov_de_Caja
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 101 'REPORTE DETALLADO DE FACTURAS
                Dim crTemp As New crDetallado_Facturas
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 102 'DETERMINACI�N DE RESERVAS CONSOLIDADA
                Dim crTemp As New crDetReservaConsolidado
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 103 'CONTROL DE RUTA DE COBRO GENERAL
                Dim crTemp As New crRutaCobro
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 104 'DETALLE DE CUOTA PARA CONTROL DE RUTA DE COBRO GENERAL
                Dim crTemp As New crDetalleCuotaRuta
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 105 'Frente libreta de ahorro programado
                Dim crTemp As New crAhLibretaProgramado
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 106 'Encabezado Libreta reverso
                Dim crTemp As New crAhPosteoReverso
                Me.Cursor = Cursors.WaitCursor
                crtemp.Section6.Height = 1000 + (240 * nUltLinea)
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 107 'DEP�SITOS A PLAZO FIJO ANULADOS
                Dim crTemp As New crDPFAnulados
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 108 'REPORTE APLICACIONES VALOR FECHA AHORROS
                Dim crTemp As New crAplicacionesV_F_A
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 109 'REPORTE DE ASOCIADOS CON CUENTAS
                Dim crTemp As New crAsociadosAhorrantes
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 110 'REPORTE DE ASOCIADOS INHABILITADOS
                Dim crTemp As New crAsociadosInhabilitados
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 111 'REPORTE DE ASOCIADOS EXCLUIDOS
                Dim crTemp As New crAsociados_Excluidos
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 112 'COMPROBANTE DE APLICACION VALOR FECHA
                Dim crTemp As New crComprobanteReversion
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 113 'Estado de Cuenta Proyecciones
                Dim crTemp As New crPREstadoCuenta
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 114 'REPORTE DE CANCELACIONES DE CUENTAS POR TIPO DE TRANSACCI�N
                Dim crTemp As New crCancelacionCtas_Transf
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 115 'REPORTE DE CR�DITOS CANCELADOS EN EL MES
                Dim crTemp As New crCreditos_Cancelados_en_elMes
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 116 'COMPROBANTE DE APLICACION VALOR FECHA AHORROS
                Dim crTemp As New crComprobante_RevAhorros
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 117 'Detalle de Fiadores(Reporte por Fiador)
                Dim crTemp As New crDetalleFiadores
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 118 'REPORTE DE SALDOS DE PR�STAMOS JUR�DICOS
                Dim crTemp As New crSaldosPrestamosJur
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 119 'CARTERA DE PR�STAMOS POR GESTOR
                Dim crTemp As New crCarteraPrestamos_Gestor
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 120 'PROMESAS DIARIAS COBRANZA
                Dim crTemp As New crCBGestionesDiarias
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 121 'COBRO MENSUAL POR EJECUTIVO
                Dim crTemp As New crCobro_Mensual
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 122 'PROYECCI�N DE SALDOS
                Dim crTemp As New crProyeccionSaldos
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 123 'Pr�stamos Hipotecarios
                Dim crTemp As New crSaldoPrestamoHipotecario
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 124 'DETERMINACI�N DE RESERVAS CONSOLIDADA X GARANT�A
                Dim crTemp As New crDetReservaConsolidadoGar
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 125 'REPORTE DE CANCELACIONES DE CUENTAS 
                Dim crTemp As New crCancelacionCtas
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 126 'Nuevos Asociados Aportaciones
                Dim crTemp As New crNuevosAsociadosAportaciones
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 127 'REPORTE DE MORA POR D�AS
                Dim crTemp As New crMora_porDias
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 128 'REPORTE DE ASOCIADOS EN MORA
                Dim crTemp As New crCarteraPrestamos_AsociadosMora
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 129 'REPORTE RESERVA DOCUMENTOS POR COBRAR
                Dim crTemp As New crDocProtesto_Reserva_DXC
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 130 'REPORTE DE MORA POR COLECTOR
                Dim crTemp As New crMoraxTipo
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 131 'FORMULARIO DE RENUNCIA
                Dim crTemp As New crFormRenuncia
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 132 'ORDEN DE DESCUENTO - PR�STAMOS (FORMATO 2)
                Dim crTemp As New crPrOrden_DescuentoF2
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 133 ' Posteo de libretas hoja par
                Dim crTemp As New crPosteoHojaPar
                Me.Cursor = Cursors.WaitCursor


                Dim oAsoc As New wrAsociados.wsLibAsoc, dr As DataRow, dsAsoc As New DataSet, pMaxPag As Integer
                dsAsoc = oAsoc.ConsultarParametros("MaxNumLibreta,movPagLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)

                If dsAsoc.Tables(0).Rows.Count > 0 Then
                    dr = dsAsoc.Tables(0).Rows(0)
                    nMaxLinea = dr("MaxNumLibreta")
                    pMaxPag = dr("movPagLibreta")
                End If
                'If Me.nLibreta = 1 Then
                '    If nUltLinea < pMaxPag Then
                '        crTemp.Section3.Height = 1000 + (240 * nUltLinea)
                '    Else
                '        crTemp.Section3.Height = 240 * (nUltLinea - 35)
                '    End If
                'Else
                '    If (nUltLinea - ((Fix(nUltLinea / nMaxLinea)) * nMaxLinea)) < pMaxPag Then
                '        crTemp.Section3.Height = 1000 + (240 * (nUltLinea - ((Fix(nUltLinea / nMaxLinea)) * nMaxLinea)))
                '    Else
                '        crTemp.Section3.Height = 240 * ((nUltLinea - ((Fix(nUltLinea / nMaxLinea)) * nMaxLinea)) - 35)
                '    End If
                'End If
                'crTemp.Section3.Height = 1000 + (240 * nUltLinea)
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
        End Select

    End Sub

End Class