Public Class frmMsReporteI
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

    Private vTitulo As String, vNumReporte As String, vOpcion As wrAhorro.TiposAhorroReporteMovimientos
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk As System.Windows.Forms.CheckBox
    Friend WithEvents C1fgrdPrestamos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents chkActivas As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsReporteI))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkActivas = New System.Windows.Forms.CheckBox()
        Me.chk = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
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
        Me.GroupBox1.Controls.Add(Me.chkActivas)
        Me.GroupBox1.Controls.Add(Me.chk)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkActivas
        '
        Me.chkActivas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivas.Location = New System.Drawing.Point(374, 28)
        Me.chkActivas.Name = "chkActivas"
        Me.chkActivas.Size = New System.Drawing.Size(87, 37)
        Me.chkActivas.TabIndex = 43
        Me.chkActivas.Text = "&Cuentas Activas"
        Me.chkActivas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivas.Visible = False
        '
        'chk
        '
        Me.chk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk.Location = New System.Drawing.Point(163, 9)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(298, 19)
        Me.chk.TabIndex = 42
        Me.chk.Text = "&Mostrar todos los DPF"
        Me.chk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(29, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Del:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(202, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "al:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(250, 37)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(115, 23)
        Me.dtpFecha2.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(67, 37)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(115, 23)
        Me.dtpFecha.TabIndex = 0
        '
        'C1fgrdPrestamos
        '
        Me.C1fgrdPrestamos.AllowEditing = False
        Me.C1fgrdPrestamos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.C1fgrdPrestamos.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdPrestamos.BackColor = System.Drawing.Color.White
        Me.C1fgrdPrestamos.ColumnInfo = "30,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Caption:""CodPrestamo"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Caption:""Dui"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdPrestamos.Location = New System.Drawing.Point(-104, 35)
        Me.C1fgrdPrestamos.Name = "C1fgrdPrestamos"
        Me.C1fgrdPrestamos.Rows.Count = 2
        Me.C1fgrdPrestamos.Rows.DefaultSize = 21
        Me.C1fgrdPrestamos.Size = New System.Drawing.Size(59, 11)
        Me.C1fgrdPrestamos.StyleInfo = resources.GetString("C1fgrdPrestamos.StyleInfo")
        Me.C1fgrdPrestamos.TabIndex = 7
        Me.C1fgrdPrestamos.Visible = False
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(408, 158)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(90, 32)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 1024
        Me.btnProcesar1.Text = "Mostrar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmMsReporteI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(546, 242)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.C1fgrdPrestamos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsReporteI"
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
            Select Case vNumReporte
                Case "0" 'REPORTE MOVIMIENTOS DIARIOS DE ABONOS A PRESTAMOS 
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.MovAbonoPrestamos(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 59, 0)
                    ofrm.ShowDialog()
                Case "1" 'REPORTE MOVIMIENTOS DIARIOS DE AHORROS
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.MovimientosAhorros(Me.dtpFecha.Value, Me.dtpFecha2.Value, vOpcion, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 60, 0)
                    ofrm.ShowDialog()
                Case "2" 'REPORTE MOVIMIENTOS DIARIOS DE CARGOS A PRESTAMOS 
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.MovCargoPrestamos(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 59, 0)
                    ofrm.ShowDialog()
                Case "4"
                Case 6
                Case 7 'REPORTE DE SALDOS DE CUENTAS DE APORTACIÓN CANCELADAS
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.SaldosAhorros_Rango(Me.dtpFecha.Value, Me.dtpFecha2.Value, wrAhorro.TiposAhorroReporteMovimientos.Aportacion, True, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 72, 0)
                    ofrm.ShowDialog()
                Case 8 'REPORTE DE REVERSIONES EN CAJA
                    Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet
                    ds = oCaja.RepReversionesDiarias(Format(Me.dtpFecha.Value, "short date"), Format(Me.dtpFecha2.Value, "short date"), sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 83, 0)
                    ofrm.ShowDialog()
                Case 9 'REPORTE CONSOLIDADO DE CARTERA EN DOCUMENTOS EN PROTESTO CON RESERVA 
                    Dim oCred As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oCred.Cartera_DocProtesto_Reserva(Format(Me.dtpFecha.Value, "short date"), Format(Me.dtpFecha2.Value, "short date"), sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 84, 0)
                    ofrm.ShowDialog()
                Case 10 'REPORTE CONSOLIDADO DE CARTERA DE DEPOSITOS A PLAZO FIJO (DPF)
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.Gerencial_Cartera_DPF(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 85, 0)
                    ofrm.ShowDialog()
                Case 11 'REPORTE GERENCIAL CON GARANTÍAS DPF EN MORA
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Garantia_DPF_Mora(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 86, 0)
                    ofrm.ShowDialog()
                Case 12 'REPORTE DE MOVIMIENTOS EN CUENTAS DE AHORROS
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.Gerencial_MovCuentasAhorro(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 87, 0)
                    ofrm.ShowDialog()
                Case 13 'DATOS DPF PARA EXPORTACIÓN
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.ExportacionDatos_DPF(Me.chk.Checked, False, "", Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim openDlg As SaveFileDialog = New SaveFileDialog
                    Dim Resultado As DialogResult
                    Try
                        openDlg.Filter = "Archivos Excel (*.csv)|*.csv"
                        openDlg.FileName = "Datos_DPF"
                        Resultado = openDlg.ShowDialog()
                        If Resultado = DialogResult.OK Then
                            If openDlg.FileName.Trim = "" Then
                                MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                Me.C1fgrdPrestamos.DataSource = ds.Tables(0)
                                Me.C1fgrdPrestamos.SaveGrid(openDlg.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                                MessageBox.Show("El archivo ha sido generado.", "Exportación datos DPF", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                Case 14 'REPORTE DE DATOS DPF
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.Reporte_Datos_DPF(Me.chk.Checked, Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 88, 0)
                    ofrm.ShowDialog()
                Case 15 'DATOS PRÉSTAMOS PARA EXPORTACIÓN
                    Dim oCred As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oCred.ExportacionDatos_Prestamos(Me.chk.Checked, False, "", Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim openDlg As SaveFileDialog = New SaveFileDialog
                    Dim Resultado As DialogResult
                    Try
                        openDlg.Filter = "Archivos Excel (*.csv)|*.csv"
                        openDlg.FileName = "Datos_Prestamos"
                        Resultado = openDlg.ShowDialog()
                        If Resultado = DialogResult.OK Then
                            If openDlg.FileName.Trim = "" Then
                                MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                Me.C1fgrdPrestamos.DataSource = ds.Tables(0)
                                Me.C1fgrdPrestamos.SaveGrid(openDlg.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                                MessageBox.Show("El archivo ha sido generado.", "Exportación datos Préstamos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                Case 16 'REPORTE DE DATOS PRÉSTAMOS
                    Dim oCred As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oCred.Reporte_Datos_Prestamos(Me.chk.Checked, Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 91, 0)
                    ofrm.ShowDialog()
                Case 17 'REPORTE DE PROVISIÓN DE CUENTAS DE AHORRO
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.Provisiones_Ahorros(Me.dtpFecha.Value, Me.dtpFecha2.Value, 0, True, True, "", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 93, 0)
                    ofrm.ShowDialog()
                Case 18 'REPORTE DE PROVISIÓN DE PRÉSTAMOS
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Provisiones_Prestamos(Me.dtpFecha.Value, Me.dtpFecha2.Value, "", True, True, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 94, 0)
                    ofrm.ShowDialog()
                Case 19 'DETALLE DE APERTURA DE CAJA
                    Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet
                    ds = oCaja.DetalleApertura_Caja(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 96, 0)
                    ofrm.ShowDialog()
                Case 20 'REPORTE DE SALDOS DE APORTACIONES CANCELADAS POR PERÍODO
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.Cuentas_Canceladas(Me.dtpFecha.Value, Me.dtpFecha2.Value, wrAhorro.TiposAhorroReporteMovimientos.Aportacion, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 97, 0)
                    ofrm.ShowDialog()
                Case 21 'REPORTE DE CUENTAS PIGNORADAS POR TIPO DE CUENTA
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.Cuentas_Pignoradas(Me.dtpFecha.Value, Me.dtpFecha2.Value, wrAhorro.TiposAhorroReporteMovimientos.Aportacion, True, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 98, 0)
                    ofrm.ShowDialog()
                Case 22 'REPORTE APLICACIONES VALOR FECHA DE PRÉSTAMOS
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Reversiones_Prestamos(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 99, 0)
                    ofrm.ShowDialog()
                Case 24 'REPORTE DETALLADO DE FACTURAS
                    Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet
                    ds = oCaja.Detallado_Facturas(Format(Me.dtpFecha.Value, "short date"), Format(Me.dtpFecha2.Value, "short date"), sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 101, 0)
                    ofrm.ShowDialog()
                Case 25 'CONTROL DE RUTA DE COBRO GENERAL
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Control_RutaCobro(Me.dtpFecha.Value, Me.dtpFecha2.Value, False, True, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 103, 0)
                    ofrm.ShowDialog()
                Case 26 'CONTROL DE RUTA DE COBRO PARA CARTERA EN MORA
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Control_RutaCobro(Me.dtpFecha.Value, Me.dtpFecha2.Value, True, False, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 103, 0)
                    ofrm.ShowDialog()
                Case 27 'CONTROL DE RUTA DE COBRO PARA CARTERA NORMAL
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Control_RutaCobro(Me.dtpFecha.Value, Me.dtpFecha2.Value, False, False, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 103, 0)
                    ofrm.ShowDialog()
                Case 28 'DETALLE DE CUOTA PARA CONTROL DE RUTA DE COBRO GENERAL
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Control_RutaCobro(Me.dtpFecha.Value, Me.dtpFecha2.Value, False, True, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 104, 0)
                    ofrm.ShowDialog()
                Case 29 'DEPÓSITOS A PLAZO FIJO ANULADOS
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.DPF_Anulados(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 107, 0)
                    ofrm.ShowDialog()
                Case 30 'REPORTE DE APLICACIONES VALOR FECHA AHORROS
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.RepValorFecha_Ahorros(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 108, 0)
                    ofrm.ShowDialog()
                Case 31 'REPORTE DE ASOCIADOS CON CUENTAS
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepAsociadosCtas(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 109, 0)
                    ofrm.ShowDialog()
                Case 32 'REPORTE DE ASOCIADOS INHABILITADOS
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepAsociadosInhabilitados(Me.dtpFecha.Value, Me.dtpFecha2.Value, "I", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 110, 0)
                    ofrm.ShowDialog()
                Case 33 'REPORTE DE ASOCIADOS EXCLUIDOS
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepAsociadosExcluidos(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 111, 0)
                    ofrm.ShowDialog()
                Case 35 'DATOS AHORROS PARA EXPORTACIÓN
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet, pFiltro As String
                    If Me.chkActivas.Checked = True Then
                        pFiltro = "a.Estado='A'"
                    Else
                        pFiltro = "a.Estado='C'"
                    End If
                    ds = oAhorro.ExportacionDatos_Ahorros(Me.chk.Checked, pFiltro, Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim openDlg As SaveFileDialog = New SaveFileDialog
                    Dim Resultado As DialogResult
                    Try
                        openDlg.Filter = "Archivos Excel (*.csv)|*.csv"
                        openDlg.FileName = "Datos_Ahorros"
                        Resultado = openDlg.ShowDialog()
                        If Resultado = DialogResult.OK Then
                            If openDlg.FileName.Trim = "" Then
                                MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                Me.C1fgrdPrestamos.DataSource = ds.Tables(0)
                                Me.C1fgrdPrestamos.SaveGrid(openDlg.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                                MessageBox.Show("El archivo ha sido generado.", "Exportación datos Ahorros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                Case 36 'ACUERDOS Y PROMESAS DIARIAS COBRANZA
                    Dim oCred As New wrCredito.wsLibCred, ds As New DataSet
                    ds = oCred.Gestiones_Diarias_Cobranza(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 120, 0)
                    ofrm.ShowDialog()

                Case "41" 'REPORTE MOVIMIENTOS DIARIOS DE ABONOS A PRESTAMOS 
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.MovAbonoPrestamos(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 164, 0)
                    ofrm.ShowDialog()
                Case "42" 'REPORTE MOVIMIENTOS DIARIOS DE CARGOS A PRESTAMOS 
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.MovCargoPrestamos(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 164, 0)
                    ofrm.ShowDialog()

                Case "45" 'REPORTE DE ASOCIADOS FALLECIDOS
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepAsociadosFallecidos(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 171, 0)
                    ofrm.ShowDialog()
                Case "46" 'REPORTE DE ASOCIADOS HABILITADOS
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepAsociadosInhabilitados(Me.dtpFecha.Value, Me.dtpFecha2.Value, "H", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 172, 0)
                    ofrm.ShowDialog()
                Case "47" 'EXPORTACIÓN DE SOLICITUDES DE CRÉDITO
                    Dim oCred As New wrCredito.wsLibCred, ds As New DataSet, pos As Long, vDirectorio As String
                    ds = oCred.ExportacionDatos_Solicitud(False, "", Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim openDlg As SaveFileDialog = New SaveFileDialog
                    Dim Resultado As DialogResult
                    openDlg.Filter = "Archivos Excel (*.csv)|*.csv"
                    openDlg.FileName = "Datos_SolicitudCredito"
                    Resultado = openDlg.ShowDialog()
                    If Resultado = DialogResult.OK Then
                        If openDlg.FileName.Trim = "" Then
                            MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        Else
                            Me.C1fgrdPrestamos.DataSource = ds.Tables("Datos")
                            Me.C1fgrdPrestamos.SaveGrid(openDlg.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                            Me.C1fgrdPrestamos.DataSource = ds.Tables("Garantias")
                            Me.C1fgrdPrestamos.SaveGrid("Garantias.csv", C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                            Me.C1fgrdPrestamos.DataSource = ds.Tables("Fiadores")
                            Me.C1fgrdPrestamos.SaveGrid("Fiadores.csv", C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                            Me.C1fgrdPrestamos.DataSource = ds.Tables("RefFam")
                            Me.C1fgrdPrestamos.SaveGrid("Referencia_Familiar.csv", C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                            Me.C1fgrdPrestamos.DataSource = ds.Tables("RefPer")
                            Me.C1fgrdPrestamos.SaveGrid("Referencia_Personal.csv", C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                            Me.C1fgrdPrestamos.DataSource = ds.Tables("Inmueble")
                            Me.C1fgrdPrestamos.SaveGrid("Inmueble.csv", C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                            MessageBox.Show("El archivo ha sido generado.", "Exportación datos Solicitudes de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Case 48 'Reingreso de Asociados
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepReingresosAsociados(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 174, 0)
                    ofrm.ShowDialog()
                Case 49 'Reporte de Préstamos Refinanciados
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.SaldosPrestamos(Me.dtpFecha.Value, Me.dtpFecha2.Value, "R", "", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 180, 0)
                    ofrm.ShowDialog()
                Case 50 'PRÉSTAMOS POR GARANTÍA (FORMATO PAGARÉS Y LETRAS)
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.SaldosPrestamos(Me.dtpFecha.Value, Me.dtpFecha2.Value, "G", "00005", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 181, 0)
                    ofrm.ShowDialog()
                Case 51 'Reporte Informe Metas Mercadeo
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepInformeMetasMercadeo(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 183, 0)
                    ofrm.ShowDialog()
                Case 52 'Reporte Informe de Metas por Producto/Servicio
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepInformeMetasxProducto(Me.dtpFecha.Value, Me.dtpFecha2.Value, "00027", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 184, 0)
                    ofrm.ShowDialog()
                Case 53 'Gerencial Acumulado Metas
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepGerencial_AcumuladoMetas(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 185, 0)
                    ofrm.ShowDialog()
                Case 54 'Colocación Montos Desembolsados
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.RepColocacionMontos_Desembolsados(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 187, 0)
                    ofrm.ShowDialog()
                Case 55 'Colocación de Préstamos Consolidado
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.RepColocacionPrestamos_Consolidado(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    If Me.chk.Checked = True Then
                        Me.C1fgrdPrestamos.DataSource = ds.Tables(0)
                        Dim openDlg As SaveFileDialog = New SaveFileDialog
                        Dim Resultado As DialogResult
                        openDlg.Filter = "Archivos Excel (*.csv)|*.csv"
                        openDlg.FileName = "Colocacion_PrestamosConsolidados"
                        Resultado = openDlg.ShowDialog()
                        If Resultado = DialogResult.OK Then
                            If openDlg.FileName.Trim = "" Then
                                MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                Me.C1fgrdPrestamos.SaveGrid(openDlg.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                                MessageBox.Show("El archivo ha sido generado.", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                    Dim ofrm As New frmVisor(ds, 188, 0)
                    ofrm.ShowDialog()

                Case 56 'Gerencial Consolidado Evaluación por Año
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepGerencial_EvaluacionxAnio(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 189, 0)
                    ofrm.ShowDialog()
                Case 57 'Consolidado Resultados Históricos
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepGerencial_ResultadosHistoricos(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 190, 0)
                    ofrm.ShowDialog()
                Case 58 'Cartera DPF
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.Cartera_DPF(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 191, 0)
                    ofrm.ShowDialog()
                Case 59 'Reporte de Créditos sin Garantías
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.ReporteCreditos_SinGarantias(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 192, 0)
                    ofrm.ShowDialog()
                Case 60 'Reporte de Créditos por Tipo de Hipoteca
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.ReporteCreditos_TipoHipoteca(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 193, 0)
                    ofrm.ShowDialog()
                Case 61 'Reporte de Garantías Prendarias
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.ReporteCreditos_GarantiasPrendarias(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 194, 0)
                    ofrm.ShowDialog()
                Case 62 'Reporte de Motivos de Ausentismo
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Ausentismos(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 200, 0)
                    ofrm.ShowDialog()
                Case 63 'Reporte de Tipos de Descuentos
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Descuentos(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 201, 0)
                    ofrm.ShowDialog()
                Case 64 'Reporte de Vacaciones
                    Dim oPlan As New wrPlanilla.wsLibPlanilla, ds As New DataSet
                    ds = oPlan.Reporte_Vacaciones(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 202, 0)
                    ofrm.ShowDialog()
                Case 65 'Consolidado Resultados Mercadeo
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepConsolidadoResultadosMercadeo(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 207, 0)
                    ofrm.ShowDialog()
                Case 67 'Resultados Comparados
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.RepResultadosComparados(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 208, 0)
                    ofrm.ShowDialog()
                Case 68 'Dividendos Aportaciones
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.ReporteDividendosAp(Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 209, 0)
                    ofrm.ShowDialog()
                Case 69 'Dividendos Préstamos
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
                    ds = oAsoc.ReporteDividendosPrest(dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 211, 0)
                    ofrm.ShowDialog()
            End Select
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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

    Private Sub frmMsReporteI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.dtpFecha2.Value = Now
        Me.Text = Me.Titulo
        If vNumReporte = "13" Then
            Me.chk.Visible = True
        ElseIf vNumReporte = "35" Then
            Me.chk.Visible = True
            Me.chk.Text = "&Mostrar todas las cuentas de Ahorros"
            Me.chkActivas.Visible = True
        ElseIf vNumReporte = "15" Then
            Me.chk.Visible = True
            Me.chk.Text = "&Mostrar todos los Préstamos"
        Else
            Me.chk.Visible = False
        End If
    End Sub



End Class