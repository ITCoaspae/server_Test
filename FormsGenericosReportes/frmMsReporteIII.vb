Public Class frmMsReporteIII
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

    Private vTitulo As String, vNumReporte As String, vOpcion As wrAhorro.TiposAhorroReporteMovimientos
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents C1fgrdPrestamos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents chkMora As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsReporteIII))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkMora = New System.Windows.Forms.CheckBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.C1fgrdPrestamos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chkMora)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkMora
        '
        Me.chkMora.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMora.Checked = True
        Me.chkMora.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMora.Location = New System.Drawing.Point(202, 24)
        Me.chkMora.Name = "chkMora"
        Me.chkMora.Size = New System.Drawing.Size(80, 16)
        Me.chkMora.TabIndex = 1
        Me.chkMora.Text = "Con &Mora"
        Me.chkMora.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(6, 24)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(96, 16)
        Me.lblFecha.TabIndex = 38
        Me.lblFecha.Text = "Saldos al día:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(108, 24)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'C1fgrdPrestamos
        '
        Me.C1fgrdPrestamos.AllowEditing = False
        Me.C1fgrdPrestamos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.C1fgrdPrestamos.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdPrestamos.BackColor = System.Drawing.Color.White
        Me.C1fgrdPrestamos.ColumnInfo = "30,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Caption:""CodPrestamo"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Caption:""Dui"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdPrestamos.Location = New System.Drawing.Point(61, 128)
        Me.C1fgrdPrestamos.Name = "C1fgrdPrestamos"
        Me.C1fgrdPrestamos.Rows.Count = 2
        Me.C1fgrdPrestamos.Size = New System.Drawing.Size(82, 25)
        Me.C1fgrdPrestamos.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("C1fgrdPrestamos.Styles"))
        Me.C1fgrdPrestamos.TabIndex = 8
        Me.C1fgrdPrestamos.Visible = False
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(276, 125)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 1026
        Me.btnProcesar1.Text = "Mostrar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmMsReporteIII
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(375, 193)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.C1fgrdPrestamos)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsReporteIII"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"

    Public Property Titulo() As String
        Get
            Return vTitulo
        End Get
        Set(ByVal Value As String)
            vTitulo = Value
        End Set
    End Property
    Public Property NumReporte() As String

        Get
            Return vNumReporte
        End Get
        Set(ByVal Value As String)
            vNumReporte = Value
        End Set
    End Property

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            PFecha = Format(Me.dtpFecha.Value, "SHORT DATE")
            Select Case vNumReporte
                Case "0" 'REPORTE DE SALDOS DE APORTACIONES
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    'PFecha = Format(Me.dtpFecha.Value, "SHORT DATE")
                    ds = oAhorro.SALDO_CUENTASAPORTACIONES(sUsuario, sPassword, sSucursal, Format(Me.dtpFecha.Value, "SHORT DATE"))
                    'ds = oAhorro.SaldosAhorros(Me.dtpFecha.Value, wrAhorro.TiposAhorroReporteMovimientos.Aportacion, False, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 61, 0)
                    ofrm.ShowDialog()
                Case "1" 'REPORTE DE SALDOS POR DEPOSITOS A PLAZO FIJO (DPF) 
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    'PFecha = Format(Me.dtpFecha.Value, "SHORT DATE")
                    ds = oAhorro.SALDO_CUENTASDPF(sUsuario, sPassword, sSucursal, Format(Me.dtpFecha.Value, "SHORT DATE"))
                    'ds = oahorro.SaldosAhorros(Me.dtpFecha.Value, wrAhorro.TiposAhorroReporteMovimientos.DPF, False, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 62, 0)
                    ofrm.ShowDialog()
                Case "2" 'REPORTE DE SALDOS CUENTAS DE AHORRO
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    'PFecha = Format(Me.dtpFecha.Value, "SHORT DATE")
                    ds = oAhorro.SALDO_CUENTASAHORRO(sUsuario, sPassword, sSucursal, Format(Me.dtpFecha.Value, "SHORT DATE"))
                    'ds = oahorro.SaldosAhorros(Me.dtpFecha.Value, wrAhorro.TiposAhorroReporteMovimientos.Vista, False, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 63, 0)
                    ofrm.ShowDialog()
                Case "3" 'REPORTE DE SALDO DE PRESTAMOS PARA ASEGURADORA
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet, dsTmp As New DataSet, dr As DataRow, oAsoc As New wrAsociados.wsLibAsoc
                    dsTmp = oAsoc.ConsultarParametros("EdadMax", "", "EdadMax", sUsuario, sPassword, sSucursal)
                    If dsTmp.Tables(0).Rows.Count > 0 Then
                        dr = dsTmp.Tables(0).Rows(0)
                        ds = oPrest.SaldosPrestamos_Aseguradora(Me.dtpFecha.Value, dr("EdadMax"), sUsuario, sPassword, sSucursal)
                        Dim ofrm As New frmVisor(ds, 64, 0)
                        ofrm.ShowDialog()
                    End If
                Case "4" 'REPORTE DE INTERESES POR ASOCIADOS
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.SaldosAhorros(Me.dtpFecha.Value, wrAhorro.TiposAhorroReporteMovimientos.Vista, False, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 66, 0)
                    ofrm.ShowDialog()
                Case 5 'REPORTE DE SALDOS POR ASOCIADO
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.Reporte_SaldosAsociados(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 68, 0)
                    ofrm.ShowDialog()
                Case 6 'REPORTE DE SALDOS DE PRÉSTAMOS ADMINISTRATIVOS
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.SaldosPrestamos_ClasificadoxNombre(Me.dtpFecha.Value, wrPrestamo.TipoPrestamos.Administrativos, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 69, 0)
                    ofrm.ShowDialog()
                Case 7 'REPORTE DE SALDOS DE PRÉSTAMOS JURÍDICOS
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.SaldosPrestamos_ClasificadoxNombre(Me.dtpFecha.Value, wrPrestamo.TipoPrestamos.Juridicos, sUsuario, sPassword, sSucursal)
                    ds.WriteXml("C:\ss1.xml")
                    Dim ofrm As New frmVisor(ds, 118, 0)
                    ofrm.ShowDialog()
                Case 8 'REPORTE DE MORA POR COLECTOR
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Reportes_MoraxTipo(Me.dtpFecha.Value, wrPrestamo.TipoReportesMora.Colector, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 130, 0)
                    ofrm.ShowDialog()
                Case 9 'REPORTE DE VENCIMIENTOS DPF
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.Vencimientos_DPF(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 73, 0)
                    ofrm.ShowDialog()
                Case 10 'VENCIMIENTOS DIARIOS DPF CUMPLEN MES
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.VencimientosDiarios_DPF(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 73, 0)
                    ofrm.ShowDialog()
                Case 11
                Case 12 'REPORTE DE PRÉSTAMOS NO PROVISIONADOS
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Provisiones_Prestamos(Me.dtpFecha.Value, Now, "", True, False, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 94, 0)
                    ofrm.ShowDialog()
                Case 13 'REPORTE DE PRÉSTAMOS CARTERA EN PROTESTO
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.SaldosPrestamos_ClasificadoxNombre(Me.dtpFecha.Value, wrPrestamo.TipoPrestamos.CarteraProtesto, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 69, 0)
                    ofrm.ShowDialog()
                Case 14 'REPORTE DE MORA POR GARANTÍA
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Reportes_MoraxTipo(Me.dtpFecha.Value, wrPrestamo.TipoReportesMora.Garantia, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 130, 0)
                    ofrm.ShowDialog()
                Case 15 'REPORTE DE MORA POR LÍNEA
                    Dim oCred As New wrCredito.wsLibCred
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oCred.RPT_MORA_X_LINEA(sUsuario, sPassword, sSucursal, Format(Me.dtpFecha.Value, "SHORT DATE"))
                    'ds = oPrest.Reportes_MoraxTipo(Me.dtpFecha.Value, wrPrestamo.TipoReportesMora.Linea, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 130, 0)
                    ofrm.ShowDialog()
                Case 16 'CARTERA DE DOCUMENTOS EN PROTESTO CON RESERVA 
                    Dim oCred As New wrCredito.wsLibCred, ds As New DataSet
                    '¡ds = oCred.Documentos_Protesto_Reserva(Me.dtpFecha.Value, wrCredito.TipoReporteReserva.Protesto, sUsuario, sPassword, sSucursal)
                    Dim FECHA As Date
                    FECHA = Me.dtpFecha.Value.AddDays(1)
                    ds = oCred.RPT_DOC_PROTESTO_RESERVA(sUsuario, sPassword, sSucursal, Format(FECHA, "SHORT DATE"))
                    Dim ofrm As New frmVisor(ds, 77, 0)
                    ofrm.ShowDialog()
                'Dim ofrm As New frmVisor(ds, 77, 0)
                'ofrm.ShowDialog()
                Case 17 'CARTERA DE DOCUMENTOS POR COBRAR
                    Dim oCred As New wrCredito.wsLibCred, ds As New DataSet
                    'ds = oCred.Documentos_Protesto_Reserva(Me.dtpFecha.Value, wrCredito.TipoReporteReserva.DocumentosxCobrar, sUsuario, sPassword, sSucursal)
                    Dim FECHA As Date
                    FECHA = Me.dtpFecha.Value.AddDays(1)
                    ds = oCred.RPT_DOC_X_COBRAR(sUsuario, sSucursal, sSucursal, FECHA)
                    PFecha = Format(Me.dtpFecha.Value, "SHORT DATE")
                    Dim ofrm As New frmVisor(ds, 129, 0)
                    ofrm.ShowDialog()
                Case 18 'VENCIMIENTOS DIARIOS DPF CUMPLEN MES PROYECTADOS
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.VencimientosDiarios_DPF_Proyectados(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 134, 0)
                    ofrm.ShowDialog()
                Case 19 'REPORTE DE PRÉSTAMOS POR GARANTÍA
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Reportes_PrestamosAgrupados(Me.dtpFecha.Value, wrPrestamo.TipoReportesMora.Garantia, "", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 135, 0)
                    ofrm.ShowDialog()
                Case 20 'REPORTE DE PRÉSTAMOS POR LÍNEA
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Reportes_PrestamosAgrupados(Me.dtpFecha.Value, wrPrestamo.TipoReportesMora.Linea, "", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 136, 0)
                    ofrm.ShowDialog()
                Case 21 'REPORTE DE PRÉSTAMOS POR PLAZO
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Reportes_PrestamosAgrupados(Me.dtpFecha.Value, wrPrestamo.TipoReportesMora.Plazo, "", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 137, 0)
                    ofrm.ShowDialog()
                Case 22 'REPORTE DE PRÉSTAMOS POR CATEGORÍAS
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Reportes_PrestamosAgrupados(Me.dtpFecha.Value, wrPrestamo.TipoReportesMora.Categoria, "", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 138, 0)
                    ofrm.ShowDialog()
                Case 23
                Case 24 ' REPORTE DE DOCUMENTOS POR COBRAR
                    Dim oCred As New wrCredito.wsLibCred, ds As New DataSet
                    ds = oCred.Documentos_Cobrar(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 44, 0)
                    ofrm.ShowDialog()
                Case 25 'REPORTE DE RESERVA GERENCIAL MORA
                    Dim oCred As New wrCredito.wsLibCred, ds As New DataSet
                    If Me.chkMora.Checked = True Then
                        ds = oCred.Documentos_Protesto_Reserva(Me.dtpFecha.Value, wrCredito.TipoReporteReserva.GerencialesConMora, sUsuario, sPassword, sSucursal)
                    ElseIf Me.chkMora.Checked = False Then
                        ds = oCred.Documentos_Protesto_Reserva(Me.dtpFecha.Value, wrCredito.TipoReporteReserva.GerencialesSinMora, sUsuario, sPassword, sSucursal)
                    End If
                    Dim ofrm As New frmVisor(ds, 145, 0)
                    ofrm.ShowDialog()
                Case 26 'REPORTE DE TASAS ACTIVAS
                    Dim CREDITO As New wrCredito.wsLibCred
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = CREDITO.RPT_TASAACTIVA(Format(Me.dtpFecha.Value.AddDays(1), "SHORT DATE"))
                    'ds = oPrest.ReporteTasasActivas(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 146, 0)
                    ofrm.ShowDialog()
                'Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                'ds = oPrest.ReporteTasasActivas(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                'Dim ofrm As New frmVisor(ds, 146, 0)
                'ofrm.ShowDialog()
                Case 27 'REPORTE DE TASAS PASIVAS
                    Dim AHORRO As New wrAhorro.wsLibAhorro
                    Dim ds As New DataSet
                    ds = AHORRO.RPT_TASAPASIVA(Format(Me.dtpFecha.Value.AddDays(1), "SHORT DATE"))
                    Dim ofrm As New frmVisor(ds, 217, 0)
                    ofrm.ShowDialog()
                'Dim oPrest As New wrAhorro.wsLibAhorro, ds As New DataSet
                'oPrest.Timeout = -1
                'ds = oPrest.ReporteTasasPasivas(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                'Dim ofrm As New frmVisor(ds, 146, 0)
                'ofrm.ShowDialog()
                Case 28 'Reporte de Préstamos Saneados
                    Dim oCred As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oCred.RepDocxCobrar("S", Me.dtpFecha.Value, Me.chkMora.Checked, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 173, 0)
                    ofrm.ShowDialog()
                Case 29 'Reporte de Préstamos No Saneados
                    Dim oCred As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oCred.RepDocxCobrar("P", Me.dtpFecha.Value, False, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 44, 0)
                    ofrm.ShowDialog()
                Case 30 'REPORTE DE ACTIVO FIJO GLOBAL
                    Dim oAct As New wrActivoFijo.wsLibActivoFijo, ds As New DataSet
                    ds = oAct.Reporte_ActivoFijoGlobal(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 165, 0)
                    ofrm.ShowDialog()
                Case 31 'Dividendos por pagar
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.Impresion_DividendosxPagar(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 178, 0)
                    ofrm.ShowDialog()
                Case 32 'Reporte de préstamos por rangos
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Reportes_PrestamosRangos(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 179, 0)
                    ofrm.ShowDialog()
                Case 33 'Mora DXC
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.ReporteMora_DXC(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 195, 0)
                    ofrm.ShowDialog()
                Case 34 'Detalle de Depreciaciones de Activo Fijo
                    Dim oAct As New wrActivoFijo.wsLibActivoFijo, ds As New DataSet
                    ds = oAct.Reporte_DetalleActivoFijo(Me.dtpFecha.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 197, 0)
                    ofrm.ShowDialog()
                Case 35 'Dividendos Ahorros
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.ReporteDividendosAh(Me.dtpFecha.Value.Year + 1, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 209, 0)
                    ofrm.ShowDialog()
                Case 36 'Dividendos Ex Asociados
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.ReporteDividendosRetirados(Me.dtpFecha.Value.Year, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 210, 0)
                    ofrm.ShowDialog()
                Case 37
                Case 38
                Case 39 'Dividendos Pago Efectivo
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.ReporteDividendosCaja(Me.dtpFecha.Value.Year + 1, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 212, 0)
                    ofrm.ShowDialog()
            End Select
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Property Opcion() As wrAhorro.TiposAhorroReporteMovimientos
        Get
            Return vOpcion
        End Get
        Set(ByVal Value As wrAhorro.TiposAhorroReporteMovimientos)
            vOpcion = Value
        End Set
    End Property

#End Region

    Private Sub frmMsReporteIII_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.Text = Me.Titulo
        If Me.vNumReporte = 11 Then Me.lblFecha.Text = "Fecha:"
    End Sub


End Class
