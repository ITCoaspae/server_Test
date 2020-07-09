Public Class frmMCaFactura
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim seguridad As New wrAdmin.wsLibAdmin
    Friend WithEvents btnEfectivoDiario As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEfectivoMensual As MetroFramework.Controls.MetroButton
    Friend WithEvents btnOMDiario As MetroFramework.Controls.MetroButton
    Friend WithEvents btnOMMensual As MetroFramework.Controls.MetroButton
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim caja As New wrCaja.wsLibCaja

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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaMovimiento As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbTransaccion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbSucursal As MetroFramework.Controls.MetroComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCaFactura))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cbSucursal = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaMovimiento = New MetroFramework.Controls.MetroDateTime()
        Me.cbTransaccion = New MetroFramework.Controls.MetroComboBox()
        Me.btnEfectivoDiario = New MetroFramework.Controls.MetroButton()
        Me.btnEfectivoMensual = New MetroFramework.Controls.MetroButton()
        Me.btnOMDiario = New MetroFramework.Controls.MetroButton()
        Me.btnOMMensual = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.fg.Location = New System.Drawing.Point(19, 218)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 18
        Me.fg.Size = New System.Drawing.Size(1028, 354)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 39
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(99, 185)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 40
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(19, 185)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 41
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(19, 85)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel2.TabIndex = 59
        Me.MetroLabel2.Text = "Sucursal:"
        '
        'cbSucursal
        '
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.ItemHeight = 23
        Me.cbSucursal.Location = New System.Drawing.Point(19, 105)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(363, 29)
        Me.cbSucursal.TabIndex = 58
        Me.cbSucursal.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 52)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(98, 25)
        Me.MetroLabel1.TabIndex = 60
        Me.MetroLabel1.Text = "Buscar por:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(415, 85)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel3.TabIndex = 61
        Me.MetroLabel3.Text = "Documento:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(19, 133)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel4.TabIndex = 62
        Me.MetroLabel4.Text = "Fecha"
        '
        'dtpFechaMovimiento
        '
        Me.dtpFechaMovimiento.Location = New System.Drawing.Point(19, 153)
        Me.dtpFechaMovimiento.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpFechaMovimiento.Name = "dtpFechaMovimiento"
        Me.dtpFechaMovimiento.Size = New System.Drawing.Size(363, 30)
        Me.dtpFechaMovimiento.TabIndex = 63
        '
        'cbTransaccion
        '
        Me.cbTransaccion.FormattingEnabled = True
        Me.cbTransaccion.ItemHeight = 23
        Me.cbTransaccion.Items.AddRange(New Object() {"Factura Consumidor Final", "Crédito Fiscal", "Comprobante Retiro de Ahorro", "Comprobante Depósito de Ahorro", "Recibo de Pago Excedente", "Comprobante Cambio de Cheque"})
        Me.cbTransaccion.Location = New System.Drawing.Point(415, 105)
        Me.cbTransaccion.Name = "cbTransaccion"
        Me.cbTransaccion.Size = New System.Drawing.Size(363, 29)
        Me.cbTransaccion.TabIndex = 64
        Me.cbTransaccion.UseSelectable = True
        '
        'btnEfectivoDiario
        '
        Me.btnEfectivoDiario.Location = New System.Drawing.Point(179, 185)
        Me.btnEfectivoDiario.Name = "btnEfectivoDiario"
        Me.btnEfectivoDiario.Size = New System.Drawing.Size(168, 28)
        Me.btnEfectivoDiario.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEfectivoDiario.TabIndex = 65
        Me.btnEfectivoDiario.Text = "Efectivo Diario-UIF F1-01"
        Me.btnEfectivoDiario.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEfectivoDiario.UseSelectable = True
        Me.btnEfectivoDiario.UseStyleColors = True
        Me.btnEfectivoDiario.Visible = False
        '
        'btnEfectivoMensual
        '
        Me.btnEfectivoMensual.Location = New System.Drawing.Point(352, 185)
        Me.btnEfectivoMensual.Name = "btnEfectivoMensual"
        Me.btnEfectivoMensual.Size = New System.Drawing.Size(169, 28)
        Me.btnEfectivoMensual.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEfectivoMensual.TabIndex = 66
        Me.btnEfectivoMensual.Text = "Efectivo Mensual-UIF1-02"
        Me.btnEfectivoMensual.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEfectivoMensual.UseSelectable = True
        Me.btnEfectivoMensual.UseStyleColors = True
        Me.btnEfectivoMensual.Visible = False
        '
        'btnOMDiario
        '
        Me.btnOMDiario.Location = New System.Drawing.Point(526, 185)
        Me.btnOMDiario.Name = "btnOMDiario"
        Me.btnOMDiario.Size = New System.Drawing.Size(168, 28)
        Me.btnOMDiario.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnOMDiario.TabIndex = 67
        Me.btnOMDiario.Text = "Otro medio  diario-UIF F2-02"
        Me.btnOMDiario.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnOMDiario.UseSelectable = True
        Me.btnOMDiario.UseStyleColors = True
        Me.btnOMDiario.Visible = False
        '
        'btnOMMensual
        '
        Me.btnOMMensual.Location = New System.Drawing.Point(699, 185)
        Me.btnOMMensual.Name = "btnOMMensual"
        Me.btnOMMensual.Size = New System.Drawing.Size(168, 28)
        Me.btnOMMensual.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnOMMensual.TabIndex = 68
        Me.btnOMMensual.Text = "Otro medio Mensual UIF F2-01E"
        Me.btnOMMensual.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnOMMensual.UseSelectable = True
        Me.btnOMMensual.UseStyleColors = True
        Me.btnOMMensual.Visible = False
        '
        'frmMCaFactura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1066, 658)
        Me.Controls.Add(Me.btnOMMensual)
        Me.Controls.Add(Me.btnOMDiario)
        Me.Controls.Add(Me.btnEfectivoMensual)
        Me.Controls.Add(Me.btnEfectivoDiario)
        Me.Controls.Add(Me.cbTransaccion)
        Me.Controls.Add(Me.dtpFechaMovimiento)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.cbSucursal)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMCaFactura"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta de Transacciones"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Protected Sub LlenarCbSucursales(ByVal Campos, ByVal Filtro, ByVal Orden, ByVal sUsuario, ByVal sPassword, ByVal sSucursal)
        Dim Dts As New DataSet
        Dts = asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
        Me.cbSucursal.DataSource = Dts.Tables(0)
    End Sub
    Private Sub frmMCaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbSucursal.DisplayMember = "Nom_Sucursal"
        cbSucursal.ValueMember = "CodSucursal"
        Dim dtsRoles As New DataSet
        dtsRoles = seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
        For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
            If seguridad.ConsultarPermisoProcesos("CAI007", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                LlenarCbSucursales("CodSucursal,Nom_Sucursal", "codSucursal = '" & sSucursal & "'", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
                Me.cbSucursal.Enabled = False
                Exit For
            ElseIf seguridad.ConsultarPermisoProcesos("CAI008", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                LlenarCbSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
                Exit For
            End If
        Next
        llenarTipoDocumentos()
    End Sub
    Protected Sub llenarTipoDocumentos()
        Dim dts As New DataSet
        dts = caja.consultarCaMaestrosTipoDocumentos(1, True, 0)
        If dts.Tables.Count > 0 Then
            cbTransaccion.ValueMember = "Abrev"
            cbTransaccion.DisplayMember = "tipoDocumento"
            cbTransaccion.DataSource = dts.Tables(0)
        End If
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If fg.Row > 0 Then
                Dim ofrm As New frmMsCaConsultaFactura
                ofrm.IdMovimiento = fg.Item(fg.Row, "IdMovimiento")
                ofrm.Annio = fg.Item(fg.Row, "Annio")
                ofrm.Tipo = fg.Item(fg.Row, "Tipo")
                ofrm.NoCaja = fg.Item(fg.Row, "NoCaja")
                ofrm.CodCajero = fg.Item(fg.Row, "CodCajero")
                ofrm.codSucursal = fg.Item(fg.Row, "CodSucursal")
                ofrm.btnRevertir1.Visible = False
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim oCaja As New wrCaja.wsLibCaja, ds As New DataSet, vTipoDoc As String

            ds = oCaja.ConsultarFacturasxFiltro("idMovimiento,formapago,Annio,Tipo,Fec_Mov,Dui,Nombre,Vta_Total,estado,codCajero,NoCaja,codSucursal,hora", "Tipo='" & cbTransaccion.SelectedValue & "' and Fec_Mov='" & Me.dtpFechaMovimiento.Value.ToShortDateString & "' and codSucursal = '" & cbSucursal.SelectedValue & "' ", "Correlativo", sUsuario, sPassword, sSucursal)
            Me.fg.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub fg_Click(sender As Object, e As EventArgs) Handles fg.Click
        Try
            Dim dts As New DataSet
            Dim dtsReport As New DataSet
            dts = asociados.consultarCatReportesUIF()
            Dim idReporte As Integer
            For i As Integer = 0 To dts.Tables(0).Rows.Count - 1
                idReporte = dts.Tables(0).Rows(i).Item("idReporte")
                dtsReport = caja.consultarAplicacionFormUIF(fg.Item(fg.Row, "dui"), fg.Item(fg.Row, "Fec_Mov"), idReporte)
                If dtsReport.Tables(0).Rows.Count > 0 Then
                    Select Case idReporte
                        Case 1
                            btnEfectivoDiario.Visible = True
                        Case 2
                            btnEfectivoMensual.Visible = True
                        Case 3
                            btnOMDiario.Visible = True
                        Case 4
                            btnOMMensual.Visible = True
                    End Select
                End If
            Next
            'dts = caja.consultarAplicacionFormUIF(fg.Item(fg.Row, "IdMovimiento"), fg.Item(fg.Row, "Fec_Mov"),
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEfectivoDiario_Click(sender As Object, e As EventArgs) Handles btnEfectivoDiario.Click
        Dim frm As New uifEfectivo
        With frm
            .duip = fg.Item(fg.Row, "dui")
            .codSucursalP = fg.Item(fg.Row, "codSucursal")
            .idMovimientoP = fg.Item(fg.Row, "idMovimiento")
            .cajeroP = fg.Item(fg.Row, "codCajero")
            .tipoP = fg.Item(fg.Row, "tipo")
            .fechaFacturaP = fg.Item(fg.Row, "Fec_Mov")
            .horaFacturaP = fg.Item(fg.Row, "hora")
            .idReporteP = 1
            .Show()
        End With
    End Sub
End Class