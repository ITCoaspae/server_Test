Public Class frmVisorLib
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal ds As DataSet, ByVal nReport As Integer, ByVal nLin As Integer, ByVal nLib As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)
        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)
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
        'frmVisorLib
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
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


            Case 4
                Dim crTemp As New crMovxCuenta
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

            Case 9 'REPORTE DE PRÉSTAMOS POR INTERÉS
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
            Case 22 'REPORTE DE PRÉSTAMOS POR PLAZO
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

            Case 26
                Dim crTemp As New crCACreditoFiscalAp
                Me.Cursor = Cursors.WaitCursor
                crTemp.SetDataSource(ds)
                crView().ReportSource = crTemp
                Me.Cursor = Cursors.Default
            Case 27 'Factura Consumidor Final Genérico
                Dim crTemp As New crCaFacturaGr
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 28 'Crédito Fiscal Genérico
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

            Case 33 'Listado Carter de Préstamos
                Dim crTemp As New crListadoCarteraPrestamo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 34 'Consulta Amortización
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

            Case 37 'Concentración por Gestor
                Dim crTemp As New crCBConcentracionGestion
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 38 'Recuperación por Gestor
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
            Case 40 'Listado Créditos sin Pago
                Dim crTemp As New crListadoCreditosSinPagoMesXGestion
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 41 'Cartera de Préstamos por Ejecutivo
                Dim crTemp As New crCarteraPrestamosXEjecutivo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 42 'Cartera de Préstamos por Garantía
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

            Case 47 'Colocación de Préstamos
                Dim crTemp As New crAperturaCred
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
            Case 54 'Resumen Movimientos de Caja agrupados por Transacción
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
            Case 58 'Nota de Cargo Préstamo
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




            Case 70 'Reporte de Saldos por Tipos de Préstamos
                Dim crTemp As New crPRRepSaldosPrestamosxTipo
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 71 'Reporte de Saldos por Líneas de Préstamos
                Dim crTemp As New crPRRepSaldosPrestamosxLinea
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

            Case 89 'IMPRESIÓN DE CERTIFICADO DPF
                Dim crTemp As New crCertificadoDPF
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default


            Case 92 'CÁLCULO DE CUOTA PARA PRÉSTAMOS
                Dim crTemp As New crCuota
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 93 'REPORTE DE PROVISIÓN DE CUENTAS DE AHORRO
                Dim crTemp As New crProvisiones_Ahorros
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
                Me.Cursor = Cursors.Default
            Case 94 'REPORTE DE PROVISIÓN DE PRÉSTAMOS
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

            Case 108 'REPORTE APLICACIONES VALOR FECHA AHORROS
                Dim crTemp As New crAplicacionesV_F_A
                Me.Cursor = Cursors.WaitCursor
                crtemp.SetDataSource(ds)
                crView().ReportSource = crtemp
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

            Case 119 'CARTERA DE PRÉSTAMOS POR GESTOR
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

            Case 131 'FORMULARIO DE RENUNCIA
                Dim crTemp As New crFormRenuncia
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