Imports CrystalDecisions.CrystalReports.Engine
Public Class frmVisor
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager



#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal ds As DataSet, ByVal nReport As Integer, ByVal nLin As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)
        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)
        Me.nReport = nReport
        Me.nUltLinea = nLin
        PoblarReporte(ds)
    End Sub

    'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)
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
        'frmVisor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(880, 600)
        Me.Controls.Add(Me.crView)
        Me.Name = "frmVisor"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Visor de Reportes"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim nReport As Integer, dSet As New Data.DataSet, nUltLinea As Integer, nMaxLinea As Integer

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

    Private Sub crView_Load(sender As Object, e As EventArgs) Handles crView.Load

    End Sub

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

    Private Sub frmVisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub PoblarReporte(ByVal ds As DataSet)
        Select Case nReport


            Case 3
                'Dim crTemp As New crEstRes
                Dim crTemp As New RPT_ESTRES
                'Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView.ReportSource = crTemp
                'crView().ReportSource = crTemp
                'Me.Cursor = Cursors.Default
            Case 4
                Dim crTemp As New crMovxCuenta
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 7
                Dim crTemp As New crCheque
                If NoNegociable = True Then
                    Dim txtObj As TextObject
                    txtObj = crTemp.Section6.ReportObjects("txtNoNegociable")
                    txtObj.Text = "NO NEGOCIABLE"
                End If
                'Dim txtObj As TextObject
                'txtObj = crTemp.Section7.ReportObjects("txtUsuario")
                'txtObj.Text = sUsuario
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 9 'REPORTE DE PRÉSTAMOS POR INTERÉS
                Dim crTemp As New crPrestamosxInteres
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 10
                Dim crTemp As New crMovimientosIngresoCaja
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 11
                Dim crTemp As New crCADepositoRetiro
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 12
                Dim crTemp As New crCAEmisionFacturaConsumidorfinal
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 13
                Dim crTemp As New crCAFacturaPR
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default



            Case 17
                Dim crTemp As New crComprobanteAhorro
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 18
                Dim crTemp As New crAhLibretaAhorros
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

                '    Me.Cursor = Cursors.WaitCursor
                '    Dim text As TextObject
                '    Dim titular As TextObject
                '    text = crTemp.Section6.ReportObjects("textNoctaDui")
                '    text.Text = vNocta.Trim + ",    DUI: " + vDui.Trim
                '    'titular = Me.Cursor.NombreAhorrante.value'
                '    crTemp.SetDataSource(ds)
                '    crView().ReportSource = crTemp
                '    Me.Cursor = Cursors.Default
            Case 19
                Dim crTemp As New crReporteCorteCaja
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 20
                Dim crTemp As New crReporteEstadoCuentaAhorroAportacion
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 21
                Dim crTemp As New crAhPosteo
                Me.Cursor = Cursors.WaitCursor
                Dim oAsoc As New wrAsociados.wsLibAsoc, dr As DataRow, dsAsoc As New DataSet, pMaxPag As Integer
                dsAsoc = oAsoc.ConsultarParametros("MaxNumLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)
                If dsAsoc.Tables(0).Rows.Count > 0 Then
                    dr = dsAsoc.Tables(0).Rows(0)
                    nMaxLinea = dr("MaxNumLibreta")
                    pMaxPag = nMaxLinea - 12
                End If
                If Fix(nUltLinea / nMaxLinea) + 1 = 1 Then
                    If nUltLinea < pMaxPag Then
                        crTemp.Section6.Height = 1000 + (240 * nUltLinea)
                    Else
                        crTemp.Section6.Height = 240 * (nUltLinea - 35)
                    End If
                Else
                    If (nUltLinea - ((Fix(nUltLinea / nMaxLinea)) * nMaxLinea)) < pMaxPag Then
                        crTemp.Section6.Height = 1000 + (240 * (nUltLinea - ((Fix(nUltLinea / nMaxLinea)) * nMaxLinea)))
                    Else
                        crTemp.Section6.Height = 240 * ((nUltLinea - ((Fix(nUltLinea / nMaxLinea)) * nMaxLinea)) - 35)
                    End If
                End If
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 22 'REPORTE DE PRÉSTAMOS POR PLAZO
                Dim crTemp As New crPrestamosxPlazo
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 23
                Dim crTemp As New crCaFacturaAp
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 24
                Dim crTemp As New crCACreditoFiscalPR
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
            Case 27 'Factura Consumidor Final Genérico
                Dim crTemp As New crCaFacturaGr
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 28 'Crédito Fiscal Genérico
                Dim crTemp As New crCaCreditoFiscalGr
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
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


            Case 33 'Listado Cartera de Préstamos
                Dim crTemp As New crListadoCarteraPrestamo
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 34 'Consulta Amortización
                Dim crTemp As New crRptTablaAmortiza
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 35 'Renuncia de Asociados
                Dim crTemp As New crSolicitudRenunciaAsociado
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 37 'Concentración por Gestor
                Dim crTemp As New crCBConcentracionGestion
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 38 'Recuperación por Gestor
                Dim crTemp As New crCBRecuperacionxGestor
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 39 'Tabla Amortiza Simulada
                Dim crTemp As New crTablaAmortizaSimulada
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 40 'Listado Créditos sin Pago
                Dim crTemp As New crListadoCreditosSinPagoMesXGestion
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 41 'Cartera de Préstamos por Ejecutivo
                Dim crTemp As New crCarteraPrestamosXEjecutivo
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 42 'Cartera de Préstamos por Garantía
                Dim crTemp As New crCarteraPrestamoXCodTipoGarantia
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 43 'Planilla

                Dim rpt As New RPT_PLANILLA
                Me.Cursor = Cursors.WaitCursor
                rpt.SetDataSource(ds.Tables("RPT_PLANILLA"))
                crView().ReportSource = rpt
                Me.Cursor = Cursors.Default
            Case 44 'Documentos x Cobrar
                Dim crTemp As New crDocsxCobrar
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 45 'Carta Informativa
                Dim crTemp As New crCartaInformativa
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 47 'Colocación de Préstamos
                Dim crTemp As New crAperturaCred
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 53 'Resumen Movimientos de Caja agrupados por Documentos
                Dim crTemp As New crMovCajaxDoc
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 54 'Resumen Movimientos de Caja agrupados por Transacción
                Dim crTemp As New crMovCajaxTransac
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 55 'Corte de Movimientos de Caja (Cuenta Contable)
                Dim crTemp As New crMovCaja
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 56 'Nota de Cargo
                Dim crTemp As New crNotaCargo
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 57 'Arqueo de Caja
                Dim crTemp As New crArqueoCaja
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 58 'Nota de Cargo Préstamo
                Dim crTemp As New crNotaCargoPrestamo
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 59 'REPORTE MOVIMIENTOS DIARIOS DE ABONOS A PRESTAMOS
                Dim crTemp As New crMovAbonoPrestamo
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 60 'REPORTE DE ESTADO DE CUENTAS DE APORTACIONES  13/09/2019  PROG01---
                Dim crTemp As New crReporteEstadoCuentaAportacion
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default


            Case 70 'Reporte de Saldos por Tipos de Préstamos
                Dim crTemp As New crPRRepSaldosPrestamosxTipo
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 71 'Reporte de Saldos por Líneas de Préstamos
                Dim crTemp As New crPRRepSaldosPrestamosxLinea
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 74 'REPORTE DE TRANSFERENCIAS
                Dim crTemp As New crTransferencias
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default


            Case 80 'REPORTE PARA DETALLE DE FIADORES
                Dim crTemp As New crFiadoresPrestamos
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 81 ' RECIBO DE DIVIDENDOS
                Dim crTemp As New crReciboDiv
                Me.Cursor = Cursors.WaitCursor
                Dim text As TextObject
                'text = crTemp.Section2.ReportObjects("txtUsuario")
                'text.Text = sUsuario.ToLower.Trim
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 83 'Reporte de Reversiones diarias
                Dim crTemp As New crReversiones
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 84 'REPORTE CONSOLIDADO DE CARTERA EN DOCUMENTOS EN PROTESTO CON RESERVA 
                Dim crTemp As New crCarteraDocProtestoReserva
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 86 'REPORTE GERENCIAL CON GARANTIAS DPF EN MORA
                Dim crTemp As New crGarantiaDPFMora
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 87 'REPORTE DE MOVIMIENTOS EN CUENTAS DE AHORROS
                Dim crTemp As New crGerencial_MovCuentasAhorro
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 89 'IMPRESIÓN DE CERTIFICADO DPF
                Dim crTemp As New crCertificadoDPF
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default


            Case 92 'CÁLCULO DE CUOTA PARA PRÉSTAMOS
                Dim crTemp As New crCuota
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 93 'REPORTE DE PROVISIÓN DE CUENTAS DE AHORRO
                Dim crTemp As New crProvisiones_Ahorros
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 94 'REPORTE DE PROVISIÓN DE PRÉSTAMOS
                Dim crTemp As New crProvisiones_Prestamos
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 95 'RECIBO DE ABONO DE ANTICIPOS A EMPLEADOS
                Dim crTemp As New crAbonosAnticipos
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 96 'DETALLE DE APERTURA DE CAJA
                Dim crTemp As New crDetalle_Apertura
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default



            Case 100 'REPORTE DE MOVIMIENTOS DE CAJA
                Dim crTemp As New crMov_de_Caja
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 101 'REPORTE DETALLADO DE FACTURAS
                Dim crTemp As New crDetallado_Facturas
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 104 'Frente libreta de ahorro programado
                Dim crTemp As New crAhLibretaAhInfantil 'crAhLibretaProgramado
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 105 'Frente libreta de ahorro programado
                Dim crTemp As New crAhLibretaAhInfantil
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 106 'Encabezado Libreta reverso
                Dim crTemp As New crAhPosteoReverso
                Me.Cursor = Cursors.WaitCursor
                crTemp.Section6.Height = 1000 + (240 * nUltLinea)
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 108 'REPORTE APLICACIONES VALOR FECHA AHORROS
                Dim crTemp As New crAplicacionesV_F_A
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default



            Case 116 'COMPROBANTE DE APLICACION VALOR FECHA AHORROS
                Dim crTemp As New crComprobante_RevAhorros
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 117 'Detalle de Fiadores(Reporte por Fiador)
                Dim crTemp As New crDetalleFiadores
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 119 'CARTERA DE PRÉSTAMOS POR GESTOR
                Dim crTemp As New crCarteraPrestamos_Gestor
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 120 'PROMESAS DIARIAS COBRANZA
                Dim crTemp As New crCBGestionesDiarias
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 121 'COBRO MENSUAL POR EJECUTIVO
                Dim crTemp As New crCobro_Mensual
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default



            Case 127 'REPORTE DE MORA POR DÍAS
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


            Case 131 'FORMULARIO DE RENUNCIA
                Dim crTemp As New crFormRenuncia
                Me.Cursor = Cursors.WaitCursor
                'crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 139 'Liquidación Asociado Retirado
                Dim crTemp As New crLiquidacionAsociado
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 140 'Factura Consolidada
                Dim crTemp As New crCaFacturaCn
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 145 'REPORTE RESERVA GERENCIAL MORA
                Dim crTemp As New crGerencialReservaMora
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 147 'REPORTE DE EMPLEADOS POR DEPARTAMENTO
                Dim crTemp As New crReporteEmpleadosXDepto
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 148 'REPORTE DE EMPLEADOS POR CARGO
                Dim crTemp As New crEmpleadosxCargo
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 149 'REPORTE DE EMPLEADOS POR FECHA DE INGRESO
                Dim crTemp As New crEmpleadosxFechaIngreso
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 150 'REPORTE DE EMPLEADOS POR GÉNERO
                Dim crTemp As New crEmpleadosxGenero
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 151 'REPORTE DE EMPLEADOS DOCUMENTOS
                Dim crTemp As New crEmpleadosDocumentos
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 152 'REPORTE DE EMPLEADOS ACTIVOS
                'REPORTE MODIFICADO 30/05/2012
                'SE MODIFICA POR DUPLICIDAD DE RESULTADOS,
                'Y POR INCLUSIÓN DE NUEVOS CAMPOS (GENERO,EDAD)
                Dim Rpt As New crEmpleadosActivos
                Dim text As TextObject
                Me.Cursor = Cursors.WaitCursor
                Dim Fecha As Date
                Fecha = PFecha
                Dim Dia As String
                Dim Mes As String
                Dim AÑO As String
                Dia = Fecha.Day
                Mes = MonthName(Fecha.Month)
                AÑO = Year(Fecha)
                text = Rpt.Section2.ReportObjects("txtPeriodo")
                text.Text = UCase("AL " + Dia + " DE " + Mes + " DE " + AÑO)
                Rpt.SetDataSource(ds.Tables(0))
                Me.crView.ReportSource = Rpt
                Me.Cursor = Cursors.Default
                'Dim crTemp As New crEmpleadosActivos
                'Me.Cursor = Cursors.WaitCursor
                'crTemp.SetDataSource(ds)
                'crView().ReportSource = crTemp
                'Me.Cursor = Cursors.Default
            Case 153 'REPORTE DE EMPLEADOS NOMBRES
                Dim crTemp As New crEmpleadosNombres
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 154 'REPORTE DATOS PERSONALES DE EMPLEADOS NOMBRES
                Dim crTemp As New crDatosPersonalesEmpleados
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 155 'REPORTE DE EMPLEADOS (FORMA PAGO)
                Dim crTemp As New crDatosEmpleadosFormaPago
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 161 'MOVIMIENTOS DIARIOS DE PRÉSTAMOS X GESTOR
                Dim crTemp As New crMovAbonoPrestamoxGestor
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 163 'REPORTE DE EMPLEADOS CUMPLEAÑEROS
                Dim crTemp As New crReporteEmpleadosCumple
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 164 'REPORTE MOVIMIENTOS DIARIOS DE ABONOS A PRESTAMOS COBRANZA
                Dim crTemp As New crMovAbonoPrestamoCb
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 169 'REPORTE DE CUENTAS DE AHORRO NO PROVISIONADAS
                Dim crTemp As New crNoProvisiones_Ahorros
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 170 'LISTADO DE CRÉDITOS PIGNORADOS
                Dim crTemp As New crListadoCreditosPignorados
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 171 'LISTADO DE ASOCIADOS FALLECIDOS
                Dim crTemp As New crAsociados_Fallecidos
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default


            Case 175 'Cheques Anulados
                Dim crTemp As New crCheques_Anulados
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 179 'REPORTE DE PRÉSTAMOS POR RANGO
                Dim crTemp As New crPrestRango
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 182 'Reporte Diario de Cobros y Cargos de Préstamos
                Dim crTemp As New crMovAbonoPrestamoxGestorCB
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 186 'Reporte de Mora Detallada
                Dim crTemp As New crMora_Detalle
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 192 'Reporte de Créditos sin Garantías
                Dim crTemp As New crGarantias_SinGarantias
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 193 'Reporte de Créditos por Tipo de Hipoteca
                Dim crTemp As New crGarantias_TipoHipoteca
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 194 'Reporte de Garantías Prendarias
                Dim crTemp As New crGarantias_Prendarias
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 195 'Mora DXC
                Dim crTemp As New crMora_DXC
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default


            Case 200 'Reporte de Ausentismos
                Dim crTemp As New crReporteAusentismos
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 201 'Reporte de Tipos de Descuento
                Dim crTemp As New crReporteDescuentos
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 202 'Reporte de Vacaciones
                Dim crTemp As New crReporteVacaciones
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default

            Case 206 'Recibos de Pago
                Dim crTemp As New crReciboPago
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            'Case 207 'Consolidado Resultados Mercadeo
            '    Dim crTemp As New crConsolidadoInformeResultadosMercadeo
            '    Me.Cursor = Cursors.WaitCursor
            '    crTemp.SetDataSource(ds)
            '    crView().ReportSource = crTemp
            '    Me.Cursor = Cursors.Default
            'Case 208 'Resultados Comparados
            '    Dim crTemp As New crResultadosComparados
            '    Me.Cursor = Cursors.WaitCursor
            '    crTemp.SetDataSource(ds)
            '    crView().ReportSource = crTemp
            '    Me.Cursor = Cursors.Default


                'Nuevos Reportes
            Case 216 'reporte boletas de pago
                Dim rpt As New crBoletaPago
                Me.Cursor = Cursors.WaitCursor
                rpt.SetDataSource(ds)
                Me.crView.ReportSource = rpt
                Me.Cursor = Cursors.Default

            Case 218
                Dim rpt As New crSolicitudIngreso
                rpt.SetDataSource(ds.Tables("Asoc_RptSolicitudIngreso"))
                rpt.Subreports("crRefPerSolIng.rpt").SetDataSource(ds.Tables("Asoc_RptReferenciaAsociados"))
                rpt.Subreports("crBeneficiariosSolIng.rpt").SetDataSource(ds.Tables("Asoc_RptBeneficiarios"))
                Me.crView.ReportSource = rpt
            'Case 219
            '    Dim rpt As New crContratoInvestigacion
            '    Me.Cursor = Cursors.WaitCursor
            '    rpt.SetDataSource(ds.Tables())
            '    Me.crView.ReportSource = rpt
            '    Me.Cursor = Cursors.Default
            Case 220
                Dim rpt As New crContratoCuentaAhorro
                Me.Cursor = Cursors.WaitCursor
                rpt.SetDataSource(ds)
                Me.crView.ReportSource = rpt
                Me.Cursor = Cursors.Default
            Case 221
                Dim rpt As New crAhContratoDepositoPlazo
                Me.Cursor = Cursors.WaitCursor
                rpt.SetDataSource(ds)
                Me.crView.ReportSource = rpt
                Me.Cursor = Cursors.Default
            Case 222
                Dim rpt As New crContratoMutuo
                Me.Cursor = Cursors.WaitCursor
                rpt.SetDataSource(ds.Tables(0))
                Me.crView.ReportSource = rpt
                Me.Cursor = Cursors.Default
            Case 224
                Dim rpt As New crContratoCuentaAhorroProg
                Me.Cursor = Cursors.WaitCursor
                rpt.SetDataSource(ds)
                Me.crView.ReportSource = rpt
                Me.Cursor = Cursors.Default
            Case 225
                Dim rpt As New crContratoCuentaAhorroVista
                Me.Cursor = Cursors.WaitCursor
                rpt.SetDataSource(ds)
                Me.crView.ReportSource = rpt
                Me.Cursor = Cursors.Default
        End Select
    End Sub

End Class