Imports CrystalDecisions.CrystalReports.Engine
Public Class frmVisorRep
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Dim vReporte As String, vReporte2 As String, vReporte3 As String, iMes As Integer, dFechaIni As Date, dFechaFin As Date, vNumPartidaIni As String, vNumPartidaFin As String, vFechaI As String, vFechaF As String
    Dim vTodos As Boolean, vCuenta As String, vCodigoPrestamo As String, vDui As String, vNumSolicitud As String, vAnnio As Integer, vCodTransferencia As Integer
    Dim vCentroCosto As String
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Ahorros As New wrAhorro.wsLibAhorro

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm)

    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

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
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
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
        Set(ByVal Value As sifLib.Contabilidad.clsContabs.ReportesContabilidad)
            vReporte = Value
        End Set
    End Property
    Public Property ReporteBancos() As sifLib.Bancos.clsBCBancos.ReportesBancos
        Get
            Return vReporte2
        End Get
        Set(ByVal Value As sifLib.Bancos.clsBCBancos.ReportesBancos)
            vReporte2 = Value
        End Set
    End Property
    Public Property ReportePrestamos() As sifLib.Prestamos.clsPrestamos.ReportesPrestamos
        Get
            Return vReporte3
        End Get
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

    Private Sub frmVisorRep_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.BalanceComprobacion
                        RepBalComprob(Me.Mes)
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.CatalogoCuentas
                        RepCatalogoContab()
                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.CatalogoCentroCostos

                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.CatalogoCentroBeneficios

                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.BalanceGeneral

                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.PartidasDiario

                        RepPartidasDiario(Me.NumPartidaIni, Me.NumPartidaFin, Me.sFechaI, Me.sFechaF)

                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.AuxiliardeMayor
                        RepAuxMayor(Me.Mes, Me.FechaIni, Me.FechaFin)

                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.DiarioMayor
                        RepDiarioMayor(Me.Mes, Me.FechaIni, Me.FechaFin)

                    Case Is = sifLib.Contabilidad.clsContabs.ReportesContabilidad.PartidasDiarioAut
                        RepPartidasDiarioAut(Me.NumPartidaIni, Me.NumPartidaFin, Me.sFechaI, Me.sFechaF)
                End Select
            End If
            If Not (vReporte2 Is Nothing) Then
                Select Case Me.ReporteBancos
                    Case Is = sifLib.Bancos.clsBCBancos.ReportesBancos.ChequesEmitidos
                        RepBcoChequesEmitidos(Me.Todos, Me.Cuenta, Me.sFechaI, Me.sFechaF)
                End Select
            End If
            If Not (vReporte3 Is Nothing) Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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

        Dim ds As New DataSet
        Dim oRep As New wrConta.wsLibContab
        Try
            ds = oRep.RepDiarioMayor(pMes, pFecIni, pFecFin, vAnnio, sUsuario, sPassword, sSucursal)
            Dim oRpt As New crDiarioMayor
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




#Region "Funciones Modificadas 21/09/2011 Javier Martinez"
#End Region
    Public x As Integer


End Class